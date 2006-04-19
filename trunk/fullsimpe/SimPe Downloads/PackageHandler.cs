using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für TypedPackageHandler.
	/// </summary>
	public class PackageHandler : Downloads.IPackageHandler, System.IDisposable
	{
		SimPe.Cache.PackageType type;
		string flname;
		Downloads.ITypeHandler hnd;
		public PackageHandler(string filename): this(SimPe.Packages.File.LoadFromFile(filename))			
		{
			
		}

		public PackageHandler(SimPe.Interfaces.Files.IPackageFile pkg)			
		{	
			this.flname = pkg.SaveFileName;
			type = SimPe.Cache.PackageType.Undefined;
			DeterminType(pkg);
			Reset();

			if (type==SimPe.Cache.PackageType.Object || type==SimPe.Cache.PackageType.Sim || type==SimPe.Cache.PackageType.MaxisObject)
				SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.ReloadCache(SimPe.Plugin.DownloadsToolFactory.FileIndex, false);
			
			hnd = HandlerRegistry.Global.LoadTypeHandler(type, pkg);
			LoadContent( pkg);
		}	

		protected virtual void DeterminType(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			type = PackageInfo.ClassifyPackage(pkg);
		}		

		protected virtual void OnLoadContent(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Cache.PackageType type)
		{
		}

		protected virtual void OnReset(SimPe.Cache.PackageType type)
		{
		}

		protected void LoadContent(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			hnd.LoadContent(type, pkg);
			foreach (Downloads.IPackageInfo nfo in hnd.Objects)
				if (nfo is Downloads.PackageInfo)
					((Downloads.PackageInfo)nfo).Type = type;

			OnLoadContent(pkg, type);
		}
		
		protected void Reset()
		{
			OnReset(type);
		}

		#region IPackageHandler Member
		public void FreeResources()
		{
			SimPe.Packages.StreamFactory.CloseStream(this.flname);
		}
		public IPackageInfo[] Objects
		{
			get
			{
				return hnd.Objects;
			}
		}

		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			flname = null;
			hnd = null;
		}

		#endregion
	}
}
