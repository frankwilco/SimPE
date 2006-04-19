using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für SimTypeHandler.
	/// </summary>
	public class NeighborhoodTypeHandler : SimpleTypeHandler
	{
		public NeighborhoodTypeHandler()
		{
			
		}

		protected override void SetName(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.CTSS_FILE);

			if (pfds.Length>0)
			{
				SimPe.PackedFiles.Wrapper.StrItemList items = Downloads.DefaultTypeHandler.GetCtssItems(pfds[0], pkg);
				if (items.Length>0) nfo.Name = items[0].Title;
				if (items.Length>1) nfo.Description = items[1].Title;
			}
		}
		

		protected override void SetImage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SetImage(0x856DDBAC, pkg);
			nfo.KnockoutThumbnail = true;
		}
	}
}
