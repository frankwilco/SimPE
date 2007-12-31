using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für SimTypeHandler.
	/// </summary>
	public class RecolorTypeHandler : Downloads.ITypeHandler, System.IDisposable
	{
		protected PackageInfo nfo;
		public RecolorTypeHandler()
		{
			
		}

		protected void PostponedRender(object sender, EventArgs e)
		{
			Wait.SubStart();
			Wait.Message = "Building Preview";
			PackageInfo nfo = sender as PackageInfo;
			object[] data = nfo.RenderData as object[];
			tmppkg = SimPe.Packages.GeneratableFile.LoadFromFile(data[1].ToString());
			if (tmppkg==null) return;
			
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fii = SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.AddNewChild();
			SimPe.Plugin.MmatWrapper mmat = data[0] as SimPe.Plugin.MmatWrapper;

			mmat.ProcessData(mmat.FileDescriptor, tmppkg);
			if (mmat!=null) 
			{					
				fii.AddIndexFromPackage(mmat.Package, true);
				try 
				{
					Ambertation.Scenes.Scene scn = SimPe.Plugin.PreviewForm.RenderScene(mmat);
					nfo.RenderedImage = Downloads.DefaultTypeHandler.Get3dPreview(scn);
					scn.Dispose();
					mmat.Dispose();
				} 
				catch {}
			}


			fii.CloseAssignedPackages();
			SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.RemoveChild(fii);
			
			this.DisposeTmpPkg();
			Wait.SubStop();
		}

		SimPe.Interfaces.Files.IPackageFile tmppkg;		
		protected virtual bool BeforeLoadContent(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg)
		{			
			bool ret = false;
			DisposeTmpPkg();
			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.MMAT);
			if (pfds.Length>0)
			{
				SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
				mmat.ProcessData(pfds[0], pkg);
				nfo.Name = mmat.ModelName+", "+mmat.SubsetName;

				if (SimPe.Plugin.DownloadsToolFactory.Settings.LoadBasedataForRecolors) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fii = SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.AddNewChild();	
					if (System.IO.File.Exists(pkg.SaveFileName)) 
					{
						string dir = System.IO.Path.GetDirectoryName(pkg.SaveFileName);
						string[]files = System.IO.Directory.GetFiles(dir);
						foreach (string file in files)
							if (file.EndsWith(".package")||file.EndsWith(".sims"))
									if (!FileTable.FileIndex.Contains(file))
										fii.AddIndexFromPackage(file);
					}
			
					//SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.WriteContentToConsole();
					tmppkg = SimPe.Plugin.Tool.Dockable.ObjectWorkshopHelper.CreatCloneByGuid(mmat.ObjectGUID);
					if (SimPe.Plugin.DownloadsToolFactory.Settings.BuildPreviewForRecolors) 
					{
						if (tmppkg.Index.Length>0) ret = true;
						tmppkg.CopyDescriptors(pkg);
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in tmppkg.Index)				
							if (pfd.Equals(mmat.FileDescriptor))
								mmat.ProcessData(pfd, tmppkg);				

						string name = "render.tmp";
						int index = 0;
					
						string rname = null;
						do
						{
							rname = System.IO.Path.Combine(Helper.SimPeTeleportPath, index+"_"+name); 
							index++;
						} while (System.IO.File.Exists(rname));
						tmppkg.Save(rname);

						nfo.RenderData = new object[] {mmat, tmppkg.SaveFileName};
						nfo.PostponedRenderer = new EventHandler(PostponedRender);		
					}
							
					fii.CloseAssignedPackages();	
					SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.RemoveChild(fii);				
				}
			}

			return ret;
		}
		protected virtual void AfterLoadContent(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			DisposeTmpPkg();
		}

		void DisposeTmpPkg()
		{
			if (tmppkg!=null) 
			{
				tmppkg.Close();
				SimPe.Packages.StreamFactory.CloseStream(tmppkg.SaveFileName);
				if (tmppkg is SimPe.Packages.GeneratableFile)
					((SimPe.Packages.GeneratableFile)tmppkg).Dispose();
			}
			tmppkg = null;
		}


		

		#region ITypeHandler Member

		

		public void LoadContent(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			nfo = new PackageInfo(pkg);
			bool hasprev = BeforeLoadContent(type, pkg);			
			
			if (tmppkg!=null) 
			{
				Downloads.XTypeHandler hnd = new XTypeHandler(SimPe.Cache.PackageType.Object, tmppkg, false, false);
				if (hnd.Objects.Length>0) 
				{
					PackageInfo snfo = hnd.Objects[0] as PackageInfo;
					if (snfo!=null)
					{
						if (snfo.Name.Trim()=="") snfo.Name = nfo.Name;
						snfo.Image = nfo.Image;
						snfo.RenderedImage = nfo.RenderedImage;
						snfo.RenderData = nfo.RenderData;
						snfo.PostponedRenderer = nfo.PostponedRenderer;
						nfo.Dispose();
						nfo = snfo;
						nfo.ClearGuidList();
					}				
				}
				hnd.Dispose();
			}

			if (!hasprev) 
			{
				nfo.Image = WallpaperTypeHandler.SetFromTxtr(pkg);
				nfo.KnockoutThumbnail = false;
			}

			AfterLoadContent(type, pkg);
		}		

		public IPackageInfo[] Objects
		{
			get
			{
				return new IPackageInfo[] {nfo};
			}
		}

		#endregion

		public virtual void Dispose()
		{
			nfo = null;
			DisposeTmpPkg();
		}

	}
}
