using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Component to display Details about a passed Object
	/// </summary>
	public class ObjectPreview : SimpleObjectPreview
	{
		
		uint[] xtypes;		
		public ObjectPreview() : base()
		{
			xtypes = new uint[] { Data.MetaData.XFLR, Data.MetaData.XFNC, Data.MetaData.XROF, Data.MetaData.XOBJ, Data.MetaData.XNGB };			
		}

		public override bool Loaded
		{
			get
			{
				return base.Loaded ||(cpf!=null);
			}
		}


		SimPe.PackedFiles.Wrapper.Cpf cpf;
		[Browsable(false)]
		public SimPe.PackedFiles.Wrapper.Cpf SelectedXObject 
		{
			get { return cpf; }
			set 
			{
				if (cpf!=value)
				{
					cpf = value;
					UpdateXObjScreen();
				}
			}
		}	

		public override void SetFromObjectCacheItem(SimPe.Cache.ObjectCacheItem oci)
		{
			if (oci==null) 
			{
				objd = null;
				ClearScreen();
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
			cpf  = null;
			if (oci.Tag!=null)
				if (oci.Tag is SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem) 
				{
					cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);												 		
				}
		

			UpdateXObjScreen();		
			if (pb.Image==null) 
			{
				if (oci.Thumbnail == null) pb.Image = defimg;
				else pb.Image = GenerateImage(pb.Size, oci.Thumbnail, true);
			}
			lbName.Text = oci.Name;				
		}


		public override void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg==null) 
			{
				objd = null;
				ClearScreen();
				return;
			}

			//this is a regular Object?
			if (pkg.FindFiles(Data.MetaData.OBJD_FILE).Length>0) 
			{
				cpf = null;
				base.SetFromPackage (pkg);
				return;
			}

			objd = null;
			

			
			foreach (uint t in xtypes) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(t);
				if (pfds.Length>0) 
				{
					cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfds[0], pkg);			
					break;
				} 
			}

			UpdateXObjScreen();
		}

		public void SetFromXObject(SimPe.PackedFiles.Wrapper.Cpf cpf)
		{
			this.cpf = cpf;
			UpdateXObjScreen();
		}

		protected void UpdateXObjScreen()
		{
			ClearScreen();
			if (cpf==null) return;

			this.lbExpansion.Text = SimPe.Localization.GetString(FileFrom(cpf.FileDescriptor).ToString());
			SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, (SimPe.Data.ObjFunctionSubSort)GetFunctionSort(cpf), Data.ObjectTypes.Normal, SimPe.Cache.ObjectClass.XObject));

			pb.Image = null;
			pb.Image =  GenerateImage(pb.Size, GetXThumbnail(cpf) , true);
		
			SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
			if (strs!=null) 
			{
				if (strs.Count>0) this.lbName.Text = strs[0].Title;
				if (strs.Count>1) this.lbAbout.Text = strs[1].Title;
			} 
			else 
			{
				this.lbName.Text = cpf.GetSaveItem("name").StringValue;
				this.lbAbout.Text = cpf.GetSaveItem("description").StringValue;
			}
						
			
			this.lbPrice.Text = cpf.GetSaveItem("cost").UIntegerValue.ToString()+" $";

			if (pb.Image == null) pb.Image = defimg;		
		}

		protected override SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
		{
			if (cpf!=null) 
			{								
				//Get the Name of the Object
				Interfaces.Files.IPackedFileDescriptor ctss = cpf.Package.FindFile(
					cpf.GetSaveItem("stringsetrestypeid").UIntegerValue, 
					0, 
					cpf.GetSaveItem("stringsetgroupid").UIntegerValue, 
					cpf.GetSaveItem("stringsetid").UIntegerValue);			
			
				
				return base.GetCtssItems(ctss, cpf.Package);
			} 
			else return base.GetCtssItems ();
		}


		public static Data.XObjFunctionSubSort GetFunctionSort(SimPe.PackedFiles.Wrapper.Cpf cpf)
		{
			string type = cpf.GetSaveItem("type").StringValue.Trim().ToLower();
			switch (type) 
			{
				case "" :
				case "canh" : 
				{
					string stype = cpf.GetSaveItem("sort").StringValue.Trim().ToLower();
					if (stype=="landmark") return Data.XObjFunctionSubSort.Hood_Landmark;
					else if (stype=="flora") return Data.XObjFunctionSubSort.Hood_Flora;					
					else if (stype=="effects") return Data.XObjFunctionSubSort.Hood_Effects;
					else if (stype=="misc") return Data.XObjFunctionSubSort.Hood_Misc;
					else if (stype=="stone") return Data.XObjFunctionSubSort.Hood_Stone;
					else return Data.XObjFunctionSubSort.Hood_Other;
				}
				case "wall" : 
				{
					string stype = cpf.GetSaveItem("subsort").StringValue.Trim().ToLower();
					if (stype=="brick") return Data.XObjFunctionSubSort.Wall_Brick;
					else if (stype=="masonry") return Data.XObjFunctionSubSort.Wall_Masonry;					
					else if (stype=="paint") return Data.XObjFunctionSubSort.Wall_Paint;
					else if (stype=="paneling") return Data.XObjFunctionSubSort.Wall_Paneling;
					else if (stype=="poured") return Data.XObjFunctionSubSort.Wall_Poured;
					else if (stype=="siding") return Data.XObjFunctionSubSort.Wall_Siding;
					else if (stype=="tile") return Data.XObjFunctionSubSort.Wall_Tile;
					else if (stype=="wallpaper") return Data.XObjFunctionSubSort.Wall_Wallpaper;
					else return Data.XObjFunctionSubSort.Wall_Other;
				}
				case "terrainpaint":
				{
					return Data.XObjFunctionSubSort.Terrain;
				}
				case "floor" : 
				{
					string stype = cpf.GetSaveItem("subsort").StringValue.Trim().ToLower();
					if (stype=="brick") return Data.XObjFunctionSubSort.Floor_Brick;
					else if (stype=="carpet") return Data.XObjFunctionSubSort.Floor_Carpet;
					else if (stype=="lino") return Data.XObjFunctionSubSort.Floor_Lino;					
					else if (stype=="poured") return Data.XObjFunctionSubSort.Floor_Poured;
					else if (stype=="stone") return Data.XObjFunctionSubSort.Floor_Stone;
					else if (stype=="tile") return Data.XObjFunctionSubSort.Floor_Tile;
					else if (stype=="wood") return Data.XObjFunctionSubSort.Floor_Wood;
					else return Data.XObjFunctionSubSort.Floor_Other;
				}
				case "roof" : 
				{
					return Data.XObjFunctionSubSort.Roof;
				}					
				case "fence" : 
				{
					if (cpf.GetSaveItem("ishalfwall").UIntegerValue == 1) return Data.XObjFunctionSubSort.Fence_Halfwall;
					return Data.XObjFunctionSubSort.Fence_Rail;
				}
				default :
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
			Data.XObjFunctionSubSort fss = ObjectPreview.GetFunctionSort(cpf);

			uint inst = cpf.GetSaveItem("guid").UIntegerValue;
			uint grp = cpf.FileDescriptor.Group;
			if (cpf.GetItem("thumbnailinstanceid")!=null)
			{
				inst = cpf.GetSaveItem("thumbnailinstanceid").UIntegerValue;
				grp = cpf.GetSaveItem("thumbnailgroupid").UIntegerValue;
			}
			

			//get Thumbnail Type
			uint[] types = new uint[] {0x8C311262, 0x8C31125E}; //floors, walls
			if (fss == Data.XObjFunctionSubSort.Roof) types = new uint[] {0xCC489E46};
			else if (fss == Data.XObjFunctionSubSort.Fence_Rail || fss == Data.XObjFunctionSubSort.Fence_Halfwall) types = new uint[] {0xCC30CDF8};
			else if (fss == Data.XObjFunctionSubSort.Roof) types = new uint[] {0xCC489E46};
			else if (fss == Data.XObjFunctionSubSort.Terrain) 
			{
				types = new uint[] {0xEC3126C4};
				if (cpf.GetItem("texturetname")!=null)
					inst = Hashes.GetCrc32(Hashes.StripHashFromName(cpf.GetItem("texturetname").StringValue.Trim().ToLower()));
			} 
			else if (cpf.FileDescriptor.Type==Data.MetaData.XNGB) 
			{
				types = new uint[] {0x4D533EDD};
                if (nthumbs == null) nthumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Thumbnails\\CANHObjectsThumbnails.package"));
				tmbs = nthumbs;
			}
			
			
			return GetThumbnail(cpf.GetSaveItem("name").StringValue, types, grp, inst, tmbs);
			//tmbs = null;
			/*ArrayList types = new ArrayList();			
			types.Add(0xEC3126C4); // Terrain
			types.Add(0xCC30CDF8); //fences
			types.Add(0x8C311262); //floors						
			types.Add(0xCC489E46); //roof
			types.Add(0x8C31125E); //wall*/
		}
		#endregion
	}
}

