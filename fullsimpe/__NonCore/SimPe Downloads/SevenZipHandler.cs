using System;
using System.Collections;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für SevenZipHandler.
	/// </summary>
	public class SevenZipHandler : ArchiveHandler
	{		
		public SevenZipHandler(string filename) : base(filename)
		{		
		
		}								

		protected override StringArrayList ExtractArchive()
		{
			StringArrayList ret = new StringArrayList();					
			Ambertation.SevenZip.IO.CommandlineArchive a = new Ambertation.SevenZip.IO.CommandlineArchive(this.ArchiveName);
			Ambertation.SevenZip.IO.ArchiveFile[] content = a.ListContent();
			a.Extract(SimPe.Helper.SimPeTeleportPath, false);

			foreach (Ambertation.SevenZip.IO.ArchiveFile desc in content)
			{				
				string rname = System.IO.Path.Combine(Helper.SimPeTeleportPath, desc.Name);	
				if (System.IO.File.Exists(rname))
					ret.Add(rname);
			}
			return ret;
		}		
	}
}
