using System;
using System.Drawing;
using System.Collections;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Reads the Content of a Package
	/// </summary>
	public class DefaultTypeHandler : Downloads.ITypeHandler, System.IDisposable
	{		
		#region Preview
		static Ambertation.Graphics.DirectXPanel dxp;
		static void InitPreview()
		{
			if (dxp!=null) return;
			dxp = new Ambertation.Graphics.DirectXPanel();
			dxp.Width = 128 * 3;
			dxp.Height = dxp.Width;
			dxp.BackColor = Color.FromArgb(10, 10, 40);
			dxp.Settings.MeshPassCullMode = Microsoft.DirectX.Direct3D.Cull.Clockwise;

			dxp.Settings.AddAxis = false;
			dxp.Settings.AddLightIndicators = false;
			dxp.Settings.RenderJoints = false;
		}
		#endregion

		protected PackageInfo nfo;
        protected string flname;
        protected SimPe.PackedFiles.Wrapper.ExtObjd objd;
		bool rendergmdc;
		bool countvert;
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="type">Type of the stored Data in the Package</param>
		/// <param name="pkg">The package</param>
		/// <param name="countvert">false, if you don't need to know the number of 
		/// stored vertices (you will not get a Preview if this is set to false!)</param>
		/// <param name="rendergmdc">If true, SimPE will generate a Preview from 
		/// the GMDC (only if countvert is also true)</param>
		internal DefaultTypeHandler(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg, bool countvert, bool rendergmdc) : this()		
		{
			this.rendergmdc = rendergmdc;
			this.countvert = countvert;
			LoadContent(type, pkg);
		}

		internal DefaultTypeHandler()
		{
			rendergmdc = true;
			this.countvert = true;
		}

        public void LoadContent(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg)
		{
            this.flname = pkg.SaveFileName;
			nfo = new PackageInfo(pkg);
			nfo.Type = type;
            OnLoadContent();

			this.SetFromPackage(pkg);
		}

        protected virtual void OnLoadContent()
        {
        }

		protected virtual void UpdateScreen()
		{
		}

		#region Thumbnails
		/// <summary>
		/// Returns the Instance Number for the assigned Thumbnail
		/// </summary>
		/// <param name="group">The Group of the Object</param>
		/// <param name="modelname">The Name of teh Model (inst 0x86)</param>
		/// <returns>Instance of the Thumbnail</returns>
		public static uint ThumbnailHash(uint group, string modelname) 
		{
			string name = group.ToString()+modelname;
			return (uint)Hashes.ToLong(Hashes.Crc32.ComputeHash(Helper.ToBytes(name.Trim().ToLower())));
		}

		static SimPe.Packages.File thumbs = null;

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname) 
		{
			return GetThumbnail(group, modelname, null);
		}
		
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message) 
		{
			
			if (thumbs==null) 
			{
                thumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Thumbnails\\ObjectThumbnails.package"));
				thumbs.Persistent = true;
			}

			Image img = GetThumbnail(group, modelname, message, thumbs);	
			return img;
		}
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message, SimPe.Packages.File thumbs) 
		{
			uint inst = ThumbnailHash(group, modelname);
			Image img = GetThumbnail(message, new uint[] { 0xAC2950C1}, group, inst, thumbs);
 	
			
			return img;
		}
		
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(string message, uint type, uint group, uint inst, SimPe.Packages.File thumbs) 
		{
			return GetThumbnail(message, new uint[] { type }, group, inst, thumbs);
		}

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(string message, uint[] types, uint group, uint inst, SimPe.Packages.File thumbs) 
		{			
			foreach (uint type in types)
			{
				//0x6C2A22C3
				Interfaces.Files.IPackedFileDescriptor[] pfds = thumbs.FindFile(type, group, inst);
				if (pfds.Length==0) pfds = thumbs.FindFile(type, 0, inst);
				if (pfds.Length>0) 
				{
					Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
					try 
					{
						SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
						pic.ProcessData(pfd, thumbs);
						Bitmap bm = (Bitmap)ImageLoader.Preview(pic.Image, WaitingScreen.ImageSize);
						WaitingScreen.Update(bm, message);
						return pic.Image;
					}
					catch(Exception){}
				}
			}
			return null;
		}
		#endregion

				
		protected void SetupCategories(string[][] catss)
		{			
			nfo.Category = "";
			foreach(string[] cats in catss) 
			{
				string res = "";
				foreach (string cat in cats)
				{
					if (res!="") res += " / ";
					res += cat.Trim();
				}

				if (res!="") nfo.Category = res;
			}			
		}		

		public virtual void SetFromObjectCacheItem(SimPe.Cache.ObjectCacheItem oci)
		{
			ClearScreen();
			if (oci==null) 
			{
				objd = null;
				
				return;
			}

			objd = null;
			if (oci.Tag!=null)
				if (oci.Tag is SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem) 
				{
					objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
					objd.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);
				} 			
		

			UpdateScreen(null, false);			
			if (oci.Thumbnail == null) nfo.Image = null;
			else nfo.Image = oci.Thumbnail;
			nfo.Name = oci.Name;	
			nfo.VertexCount = 0;	
			nfo.FaceCount = 0;			
		}

		static Ambertation.Scenes.Scene scn;
		public virtual void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{			
			ClearScreen();
			if (pkg==null) 
			{
				objd = null;				
				return;
			}

            GetObjd(pkg);			
			UpdateScreen(pkg, false);			
		}

        protected void GetObjd(SimPe.Interfaces.Files.IPackageFile pkg)
        {
            SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.OBJD_FILE);
            if (pfds.Length > 0)
            {
                foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
                {
                    SimPe.PackedFiles.Wrapper.ExtObjd mobjd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
                    mobjd.ProcessData(pfd, pkg);

					nfo.AddGuid(mobjd.Guid);

					if (objd==null) objd = mobjd;
                    if (pfds.Length == 1) break;
                    if (mobjd.Data.Length > 0xb)
                        if (mobjd.Data[0xb] == -1) objd = mobjd;
                }
            }
        }

		protected void PostponedRender(object sender, EventArgs e)
		{
			Wait.SubStart();
			Wait.Message = "Building Preview";
			SimPe.Plugin.GeometryDataContainerExt ext = ((sender as PackageInfo).RenderData) as SimPe.Plugin.GeometryDataContainerExt;
			Ambertation.Scenes.Scene scn = ext.GetScene(new SimPe.Plugin.Gmdc.ElementOrder(SimPe.Plugin.Gmdc.ElementSorting.Preview));
			nfo.RenderedImage = Get3dPreview(scn);
			scn.Dispose();

			ext.Gmdc.Dispose();
			ext.Dispose();
			Wait.SubStop();
		}

        /// <summary>
        /// Renders the Preview form the GMDC and loads the vertex and face Count for an Object
        /// </summary>
        /// <param name="pkg"></param>
        protected void RenderGmdcPreview(SimPe.Interfaces.Files.IPackageFile pkg)
        {
			
            int fct = 0; int vct = 0;
			if (this.countvert)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.GMDC);
				bool first = !nfo.HasThumbnail;

				Wait.SubStart();
				System.Windows.Forms.Application.DoEvents();
				Wait.Message = "Counting Vertices";
				System.Windows.Forms.Application.DoEvents();
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					SimPe.Plugin.Rcol rcol = new GenericRcol();
					rcol.ProcessData(pfd, pkg, true);

					SimPe.Plugin.GeometryDataContainer gmdc = rcol.Blocks[0] as SimPe.Plugin.GeometryDataContainer;
					bool hasmesh = false;
					foreach (SimPe.Plugin.Gmdc.GmdcGroup g in gmdc.Groups)
					{
						if (g.Opacity == 0xFFFFFFFF) hasmesh = true;
						fct += g.FaceCount;
						vct += g.UsedVertexCount;
					}

					bool dispose = true;
					if (SimPe.Plugin.DownloadsToolFactory.Settings.BuildPreviewForObjects) 
					{
						if (first && hasmesh && rendergmdc)
						{
							first = false;
							SimPe.Plugin.GeometryDataContainerExt ext = new GeometryDataContainerExt(gmdc);
							nfo.RenderData = ext;
							nfo.PostponedRenderer = new EventHandler(PostponedRender);
							dispose = false;
						}
					}

					if (dispose)
					{
						gmdc.Dispose();
						rcol.Dispose();
					}
				}
				Wait.SubStop();
				pfds = null;
			}
            nfo.VertexCount = vct;
            nfo.FaceCount = fct;   
       
			if (!nfo.HasThumbnail && !SimPe.Plugin.DownloadsToolFactory.Settings.BuildPreviewForObjects)
			{
				nfo.Image = Downloads.WallpaperTypeHandler.SetFromTxtr(pkg);
				nfo.KnockoutThumbnail = false;
			}
        }

		public static Image Get3dPreview(Ambertation.Scenes.Scene scene)
		{
			if (scene==null) return null;
			scn = scene;
			InitPreview();
			
			dxp.ResetDevice += new EventHandler(dxp_ResetDevice);

			dxp.Reset();
			dxp.ResetDefaultViewport();
			dxp.Settings.AngelX = (float)(Math.PI / 8.0);
			dxp.Settings.AngelY = (float)(Math.PI / -6.0);
			dxp.Settings.Z *= 0.3f;
			dxp.UpdateRotation();
			dxp.Render();
			Image ret = dxp.Screenshot(Microsoft.DirectX.Direct3D.ImageFileFormat.Png);
			
			/*System.Windows.Forms.Form f = new System.Windows.Forms.Form();
			f.Controls.Add(dxp);
			f.ShowDialog();*/


			dxp.ResetDevice -= new EventHandler(dxp_ResetDevice);

			return ret;
		}

		protected void ClearScreen()
		{
			SimPe.Cache.PackageType t = nfo.Type;
			nfo.Reset();
			nfo.Type = t;
		}		

		

		public void UpdateScreen(SimPe.Interfaces.Files.IPackageFile pkg, bool clear)
		{
			if (clear) ClearScreen();
			if (objd==null) return;
			
			
			nfo.FirstExpansion = PackageInfo.FileFrom(objd.FileDescriptor);
			
			string[] mn = GetModelnames();			
			if (mn.Length>0) 
			{
				uint grp = objd.FileDescriptor.Group;				
				nfo.Image =  GetThumbnail(objd.FileDescriptor.Group, mn[0]);
			}
			else nfo.Image = null;

            if (pkg!=null) RenderGmdcPreview(pkg);

			SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, objd.FunctionSubSort, objd.Type, SimPe.Cache.ObjectClass.Object));							

			SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
			if (strs!=null) 
			{
				if (strs.Count>0) nfo.Name = strs[0].Title;
				if (strs.Count>1) nfo.Description = strs[1].Title;
			} 
			else nfo.Name = objd.FileName;
			
			nfo.Price = objd.Price;	
			UpdateScreen();
		}

		protected string[] GetModelnames()
		{
			if (objd==null) return new string[0];
			if (objd.Package == null) return new string[0];

			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = objd.Package.FindFile(Data.MetaData.STRING_FILE, 0, objd.FileDescriptor.Group, 0x85);
			ArrayList list = new ArrayList();
			if (pfd!=null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, objd.Package);
				SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
				for (int i=1; i<items.Length; i++) list.Add(items[i].Title);
				
			}
			string[] refname = new string[list.Count];
			list.CopyTo(refname);

			return refname;
		}

		internal static SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems(Interfaces.Files.IPackedFileDescriptor ctss, SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			if (ctss!= null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(ctss, pkg);

				return str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				
			} 

			return null;
		}

		protected virtual SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
		{
			if (objd==null) return null;
			if (objd.Package == null) return null;
			if (objd.FileDescriptor == null) return null;

			//Get the Name of the Object
			Interfaces.Files.IPackedFileDescriptor ctss = objd.Package.FindFile(Data.MetaData.CTSS_FILE, 0, objd.FileDescriptor.Group, objd.CTSSInstance);			
			
			return GetCtssItems(ctss, objd.Package);
		}		



		#region IPackageHandler Member		

		public IPackageInfo[] Objects
		{
			get
			{				
				return new IPackageInfo[]{nfo};
			}
		}

		#endregion

		private static void dxp_ResetDevice(object sender, EventArgs e)
		{
			Ambertation.Graphics.DirectXPanel dxp = sender as Ambertation.Graphics.DirectXPanel;
			dxp.Meshes.Clear();
			dxp.AddScene(scn);
		}

        #region IDisposable Member

        public virtual void Dispose()
        {
            nfo = null;
            flname = null;
            objd = null;
        }

        #endregion
    }
}
