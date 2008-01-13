using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using System.Collections;
using SimPe.Data;
using SimPe.Plugin.Properties;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	public class CloneClothing : Procedure
	{
		public CloneClothing()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="archetype"></param>
		public override void ApplyItem(IPackageFile archetype)
		{
			// for the time being, the SkinReferenceTable object
			// only manages the clothes being used by the sim.
			SkinReferenceTable skinArch = new SkinReferenceTable(GetAgeData(archetype));
			SkinReferenceTable skinPat = new SkinReferenceTable(GetAgeData(this.SimPackage));

			this.GetType();

			foreach (SkinReferenceItem item in skinArch)
			{
				if (item.Category == SkinCategory.Skin)
					continue;

				switch (item.Outfit)
				{
					case OutfitType.None:
					case OutfitType.Hair:
					case OutfitType.Face:
						continue;
				}

				skinPat.Add(item);
			}

			skinPat.CommitChanges();

		}


	}
}
