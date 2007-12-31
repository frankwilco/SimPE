using System;
using System.Collections;

namespace SimPe.Plugin.Downloads
{
	/// <summary>
	/// Zusammenfassung für TypedPackageHandler.
	/// </summary>
	public class Sims2PackHandler : ArchiveHandler
	{
		public Sims2PackHandler(string filename) : base(filename)
		{		
			
		}
			
		

		protected override StringArrayList ExtractArchive()
		{
			StringArrayList ret = new StringArrayList();	
			SimPe.Packages.S2CPDescriptor[] content = SimPe.Packages.Sims2CommunityPack.Open(this.ArchiveName);
			
			foreach (SimPe.Packages.S2CPDescriptor desc in content)
			{
				string name = System.IO.Path.Combine(Helper.SimPeTeleportPath, desc.Name);
				string rname = name; int ct = 0;
				while (System.IO.File.Exists(rname))
				{
					rname = System.IO.Path.Combine(Helper.SimPeTeleportPath, ct.ToString()+"_"+desc.Name);
					ct++;
				}
				desc.Package.Save(rname);	
				if (System.IO.File.Exists(rname))
					ret.Add(rname);
			}			
			return ret;
		}		
	}
}
