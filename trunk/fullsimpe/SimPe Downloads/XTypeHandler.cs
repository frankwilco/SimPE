using System;
using System.Text;
using System.Drawing;

namespace SimPe.Plugin.Downloads
{
    public class XTypeHandler : DefaultTypeHandler
    {
        static uint[] xtypes = new uint[] { Data.MetaData.XFLR, Data.MetaData.XFNC, Data.MetaData.XROF, Data.MetaData.XOBJ, Data.MetaData.XNGB };			        

		
        public XTypeHandler(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg,  bool countvert, bool rendergmdc)
            : base(type, pkg, countvert, rendergmdc)
        {			
        }

		public XTypeHandler() 
			: base()
		{
			
		}

        SimPe.PackedFiles.Wrapper.Cpf cpf;
        public override void SetFromObjectCacheItem(SimPe.Cache.ObjectCacheItem oci)
        {
            ClearScreen();
            if (oci == null)
            {
                objd = null;                
                return;
            }

            //Original Implementation
            if (oci.Class == SimPe.Cache.ObjectClass.Object)
            {
                cpf = null;
                base.SetFromObjectCacheItem(oci);
                return;
            }


            objd = null;
            cpf = null;
            if (oci.Tag != null)
                if (oci.Tag is SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)
                {
                    cpf = new SimPe.PackedFiles.Wrapper.Cpf();
                    cpf.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);
                }


            UpdateXObjScreen(null, false);
            nfo.Image = oci.Thumbnail;
            nfo.Name = oci.Name;
        }


        public override void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
        {
            ClearScreen();
            if (pkg == null)
            {
                objd = null;                
                return;
            }

            //this is a regular Object?
            if (pkg.FindFiles(Data.MetaData.OBJD_FILE).Length > 0)
            {
                cpf = null;
                base.SetFromPackage(pkg);
                return;
            }

            objd = null;
            GetCpf(pkg);			

            UpdateXObjScreen(pkg, false);
        }

        protected void GetCpf(SimPe.Interfaces.Files.IPackageFile pkg)
        {
            foreach (uint t in xtypes)
            {
                SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(t);
                foreach ( SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
                {
                    cpf = new SimPe.PackedFiles.Wrapper.Cpf();
                    cpf.ProcessData(pfd, pkg);
                    
					SimPe.PackedFiles.Wrapper.CpfItem item = cpf.GetItem("guid");
					if (item!=null)	nfo.AddGuid(item.UIntegerValue);
                }
            }
        }

        public void SetFromXObject(SimPe.PackedFiles.Wrapper.Cpf cpf)
        {
            this.cpf = cpf;
            UpdateXObjScreen(cpf.Package, true);
        }

        protected void UpdateXObjScreen(SimPe.Interfaces.Files.IPackageFile pkg, bool clear)
        {
            if (clear) ClearScreen();
            if (cpf == null) return;

            nfo.FirstExpansion = PackageInfo.FileFrom(cpf.FileDescriptor);
            SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, (SimPe.Data.ObjFunctionSubSort)GetFunctionSort(cpf), Data.ObjectTypes.Normal, SimPe.Cache.ObjectClass.XObject));

            nfo.Image = GetXThumbnail(cpf);
            if (pkg!=null) RenderGmdcPreview(pkg);

            SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
            if (strs != null)
            {
                if (strs.Count > 0) nfo.Name = strs[0].Title;
                if (strs.Count > 1) nfo.Description = strs[1].Title;
            }
            else
            {
                nfo.Name = cpf.GetSaveItem("name").StringValue;
                nfo.Description = cpf.GetSaveItem("description").StringValue;
            }


            nfo.Price = (int)cpf.GetSaveItem("cost").UIntegerValue;
			UpdateScreen();
        }

        protected override SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
        {
            if (cpf != null)
            {
                //Get the Name of the Object
                Interfaces.Files.IPackedFileDescriptor ctss = cpf.Package.FindFile(
                    cpf.GetSaveItem("stringsetrestypeid").UIntegerValue,
                    0,
                    cpf.GetSaveItem("stringsetgroupid").UIntegerValue,
                    cpf.GetSaveItem("stringsetid").UIntegerValue);


                return GetCtssItems(ctss, cpf.Package);
            }
            else return base.GetCtssItems();
        }


        public static Data.XObjFunctionSubSort GetFunctionSort(SimPe.PackedFiles.Wrapper.Cpf cpf)
        {
            string type = cpf.GetSaveItem("type").StringValue.Trim().ToLower();
            switch (type)
            {
                case "":
                case "canh":
                    {
                        string stype = cpf.GetSaveItem("sort").StringValue.Trim().ToLower();
                        if (stype == "landmark") return Data.XObjFunctionSubSort.Hood_Landmark;
                        else if (stype == "flora") return Data.XObjFunctionSubSort.Hood_Flora;
                        else if (stype == "effects") return Data.XObjFunctionSubSort.Hood_Effects;
                        else if (stype == "misc") return Data.XObjFunctionSubSort.Hood_Misc;
                        else if (stype == "stone") return Data.XObjFunctionSubSort.Hood_Stone;
                        else return Data.XObjFunctionSubSort.Hood_Other;
                    }
                case "wall":
                    {
                        string stype = cpf.GetSaveItem("subsort").StringValue.Trim().ToLower();
                        if (stype == "brick") return Data.XObjFunctionSubSort.Wall_Brick;
                        else if (stype == "masonry") return Data.XObjFunctionSubSort.Wall_Masonry;
                        else if (stype == "paint") return Data.XObjFunctionSubSort.Wall_Paint;
                        else if (stype == "paneling") return Data.XObjFunctionSubSort.Wall_Paneling;
                        else if (stype == "poured") return Data.XObjFunctionSubSort.Wall_Poured;
                        else if (stype == "siding") return Data.XObjFunctionSubSort.Wall_Siding;
                        else if (stype == "tile") return Data.XObjFunctionSubSort.Wall_Tile;
                        else if (stype == "wallpaper") return Data.XObjFunctionSubSort.Wall_Wallpaper;
                        else return Data.XObjFunctionSubSort.Wall_Other;
                    }
                case "terrainpaint":
                    {
                        return Data.XObjFunctionSubSort.Terrain;
                    }
                case "floor":
                    {
                        string stype = cpf.GetSaveItem("subsort").StringValue.Trim().ToLower();
                        if (stype == "brick") return Data.XObjFunctionSubSort.Floor_Brick;
                        else if (stype == "carpet") return Data.XObjFunctionSubSort.Floor_Carpet;
                        else if (stype == "lino") return Data.XObjFunctionSubSort.Floor_Lino;
                        else if (stype == "poured") return Data.XObjFunctionSubSort.Floor_Poured;
                        else if (stype == "stone") return Data.XObjFunctionSubSort.Floor_Stone;
                        else if (stype == "tile") return Data.XObjFunctionSubSort.Floor_Tile;
                        else if (stype == "wood") return Data.XObjFunctionSubSort.Floor_Wood;
                        else return Data.XObjFunctionSubSort.Floor_Other;
                    }
                case "roof":
                    {
                        return Data.XObjFunctionSubSort.Roof;
                    }
                case "fence":
                    {
                        if (cpf.GetSaveItem("ishalfwall").UIntegerValue == 1) return Data.XObjFunctionSubSort.Fence_Halfwall;
                        return Data.XObjFunctionSubSort.Fence_Rail;
                    }
                default:
                    {
                        return (Data.XObjFunctionSubSort)0;
                    }
            }
        }

        #region Thumbnails
        static SimPe.Packages.File xthumbs, nthumbs;
        public static Image GetXThumbnail(SimPe.PackedFiles.Wrapper.Cpf cpf)
        {
            if (xthumbs == null) xthumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Thumbnails\\BuildModeThumbnails.package"));

            SimPe.Packages.File tmbs = xthumbs;
            Data.XObjFunctionSubSort fss = GetFunctionSort(cpf);

            uint inst = cpf.GetSaveItem("guid").UIntegerValue;
            uint grp = cpf.FileDescriptor.Group;
            if (cpf.GetItem("thumbnailinstanceid") != null)
            {
                inst = cpf.GetSaveItem("thumbnailinstanceid").UIntegerValue;
                grp = cpf.GetSaveItem("thumbnailgroupid").UIntegerValue;
            }


            //get Thumbnail Type
            uint[] types = new uint[] { 0x8C311262, 0x8C31125E }; //floors, walls
            if (fss == Data.XObjFunctionSubSort.Roof) types = new uint[] { 0xCC489E46 };
            else if (fss == Data.XObjFunctionSubSort.Fence_Rail || fss == Data.XObjFunctionSubSort.Fence_Halfwall) types = new uint[] { 0xCC30CDF8 };
            else if (fss == Data.XObjFunctionSubSort.Roof) types = new uint[] { 0xCC489E46 };
            else if (fss == Data.XObjFunctionSubSort.Terrain)
            {
                types = new uint[] { 0xEC3126C4 };
                if (cpf.GetItem("texturetname") != null)
                    inst = Hashes.GetCrc32(Hashes.StripHashFromName(cpf.GetItem("texturetname").StringValue.Trim().ToLower()));
            }
            else if (cpf.FileDescriptor.Type == Data.MetaData.XNGB)
            {
                types = new uint[] { 0x4D533EDD };
                if (nthumbs == null) nthumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Thumbnails\\CANHObjectsThumbnails.package"));
                tmbs = nthumbs;
            }


            return GetThumbnail(cpf.GetSaveItem("name").StringValue, types, grp, inst, tmbs);
            //tmbs = null;
        }
        #endregion
    }
}
