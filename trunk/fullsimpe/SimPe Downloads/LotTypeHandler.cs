using System;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für LotTypeHandler.
	/// </summary>
	public class LotTypeHandler : SimpleTypeHandler
	{		
		public LotTypeHandler() : base()
		{
			
		}

		protected override void SetName(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SetName(Data.MetaData.STRING_FILE, pkg);			
		}

		protected override void SetImage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(0x856DDBAC, 0, Data.MetaData.LOCAL_GROUP, 0x35CA0002);
			if (pfd==null) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(0x856DDBAC);
				if (pfds.Length>0) pfd = pfds[0];
			}

			if (pfd!=null)
			{
				SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
				pic.ProcessData(pfd, pkg);
				nfo.Image = pic.Image;
			}

			nfo.KnockoutThumbnail = false;
		}
	}
}
