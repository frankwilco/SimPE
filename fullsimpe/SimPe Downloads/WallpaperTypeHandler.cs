using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für WallpaperTypeHandler.
	/// </summary>
	public class WallpaperTypeHandler : LotTypeHandler
	{
		public WallpaperTypeHandler() : base()
		{			
		}

		internal static System.Drawing.Image SetFromTxtr(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.TXTR);
			if (pfds.Length>0) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor p in pfds)				
					if (p.Size>pfd.Size) pfd = p;
				
				SimPe.Plugin.Rcol rcol = new SimPe.Plugin.GenericRcol();
				rcol.ProcessData(pfd, pkg);
				if (rcol.Blocks.Length>0) 
				{
					SimPe.Plugin.ImageData id = rcol.Blocks[0] as SimPe.Plugin.ImageData;
					if (id!=null)
					{
						SimPe.Plugin.MipMap m = id.GetLargestTexture(new System.Drawing.Size(PackageInfo.IMAGESIZE, PackageInfo.IMAGESIZE));
						if (m!=null) return m.Texture;
					}
				}
			}	
		
			return null;
		}

		protected override void SetImage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			nfo.Image = SetFromTxtr(pkg);
			nfo.KnockoutThumbnail = false;
		}
	}
}
