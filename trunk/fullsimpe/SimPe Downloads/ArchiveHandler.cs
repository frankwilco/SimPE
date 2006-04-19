using System;
using System.Collections;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für ArchiveHandler.
	/// </summary>
	public abstract class ArchiveHandler : Downloads.IPackageHandler, System.IDisposable
	{
		string flname;
		PackageInfoCollection nfos;
		protected PackageInfoCollection Nfos
		{
			get {return nfos;}
		}

		protected string ArchiveName
		{
			get {return flname;}
		}
		
		public ArchiveHandler(string filename)		
		{		
			DoInit(filename);
		}

		protected void DoInit(string filename)
		{
			nfos = new PackageInfoCollection();
			this.flname = filename;
			Reset();
			LoadContent();
		}

		~ArchiveHandler()
		{
			Reset();
		}
			
		
		
		protected virtual void OnReset()
		{
		}

		protected abstract SimPe.StringArrayList ExtractArchive();

		protected void LoadContent()
		{			
			Wait.Message = "Extracting Archive";
			SimPe.StringArrayList files = ExtractArchive();

			Wait.SubStart(files.Count);
			
			files = SortFilesByType(files);
			LoadFiles(files);			

			Wait.SubStop();
		}

		private void LoadFiles(SimPe.StringArrayList files)
		{
			int nr = 0;
			foreach (string file in files)
			{
				Wait.Progress = nr++;
				Wait.Message = System.IO.Path.GetFileName(file);				
				
				if (!FileTable.FileIndex.Contains(file))
					SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.AddIndexFromPackage(file);

				Downloads.IPackageHandler hnd = HandlerRegistry.Global.LoadFileHandler(file);
				if (hnd!=null)				
					nfos.AddRange(hnd.Objects);	
			
				
				SimPe.Packages.StreamFactory.CloseStream(file);
			}
		}

		private SimPe.StringArrayList SortFilesByType(SimPe.StringArrayList files)
		{
			SimPe.StringArrayList objects = new StringArrayList();
			SimPe.StringArrayList other = new StringArrayList();
			foreach (string file in files)
			{
				SimPe.Cache.PackageType type = PackageInfo.ClassifyPackage(file);
				SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.AddIndexFromPackage(file);

				if (type == SimPe.Cache.PackageType.Object || type == SimPe.Cache.PackageType.MaxisObject || type == SimPe.Cache.PackageType.Sim)
					objects.Add(file);
				else
					other.Add(file);
			}
			objects.AddRange(other);
			other.Clear(); other = null;
			files.Clear(); files=null;

			return objects;
		}

		public virtual void FreeResources()
		{
		}
		
		protected void Reset()
		{														
			OnReset();	
			nfos.Clear();	
		}

		#region IPackageHandler Member

		public IPackageInfo[] Objects
		{
			get
			{
				return nfos.ToArray();
			}
		}

		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			if (nfos!=null) nfos.Clear();
			nfos = null;
			flname = null;			
		}

		#endregion
	}
}
