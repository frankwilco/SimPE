using System;
using System.Collections;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// GLoabl regisry, that contains a listing of all Package Content Handler
	/// </summary>
	public sealed class HandlerRegistry
	{
		static HandlerRegistry glob;
		public static HandlerRegistry Global
		{
			get 
			{
				if (glob==null) glob = new HandlerRegistry();
				return glob;
			}
		}		

		Hashtable reg, subreg;
		HandlerRegistry()
		{
			reg = new Hashtable();
			subreg = new Hashtable();
			
			AddFilehandler(ExtensionType.Package, typeof(PackageHandler));
			AddFilehandler(ExtensionType.DisabledPackage, typeof(PackageHandler));
			AddFilehandler(ExtensionType.Sim2Pack, typeof(PackageHandler));
			Ambertation.SevenZip.IO.CommandlineArchive a = new Ambertation.SevenZip.IO.CommandlineArchive("");
			foreach (string ext in a.SupportedForUnpack)
				this.AddFileHandler(ext, typeof(SevenZipHandler));
			
			this.AddTypeHandler(SimPe.Cache.PackageType.Lot, typeof(LotTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Wallpaper, typeof(WallpaperTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Floor, typeof(WallpaperTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Roof, typeof(WallpaperTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Terrain, typeof(WallpaperTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Sim, typeof(SimTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Neighborhood, typeof(NeighborhoodTypeHandler));
			this.AddTypeHandler(SimPe.Cache.PackageType.Recolor, typeof(RecolorTypeHandler));
		}

		void AddFilehandler(ExtensionType ext, Type handler)
		{
			ExtensionDescriptor ed = ExtensionProvider.ExtensionMap[ext] as ExtensionDescriptor;
			foreach (string mext in ed.Extensions)	
			{			
				string fext = mext.Replace("*", "");
				if (!fext.StartsWith(".")) fext = "."+fext;
				AddFileHandler(fext, handler);	
			}
		}

		public void AddTypeHandler(SimPe.Cache.PackageType type, Type handler)
		{						
			subreg[type] = handler;
		}

		public ITypeHandler LoadTypeHandler(SimPe.Cache.PackageType type, SimPe.Interfaces.Files.IPackageFile pkg)
		{			
			Type t = subreg[type] as Type;
			if (t==null) return new XTypeHandler();

			return System.Activator.CreateInstance(t, new object[] {}) as ITypeHandler;
		}

		string FixedExtension(string extension)
		{
			extension = extension.Trim().ToLower();
			if (!extension.StartsWith(".")) extension = "."+extension;
			return extension;
		}

		public void AddFileHandler(string extension, Type handler)
		{			
			extension = FixedExtension(extension);
			reg[extension] = handler;
		}

		public bool HasFileHandler(string filename)
		{
			string ext = System.IO.Path.GetExtension(filename).Trim().ToLower();;
			object o = reg[ext];
			return (o!=null);
		}

		public IPackageHandler LoadFileHandler(string filename)
		{
			string ext = System.IO.Path.GetExtension(filename).Trim().ToLower();;
			Type t = reg[ext] as Type;
			if (t==null) return null;

			if (!FileTable.FileIndex.Loaded) FileTable.FileIndex.Load();
			return System.Activator.CreateInstance(t, new object[] {filename}) as IPackageHandler;
		}
	}
}
