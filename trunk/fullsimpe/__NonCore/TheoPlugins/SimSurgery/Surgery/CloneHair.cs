using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.Plugin.Wrapper;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin.Surgery
{
	public class CloneHair : GeneticProcedure
	{
		SkinReferenceTable skinArch;

		public CloneHair()
		{
		}

		public override void ApplyItem(IPackageFile archetype)
		{
			using (AgeData agedArch = this.GetAgeData(archetype))
			{
				if (agedArch != null)
				{
					GenericCpfInfo info = new TextureOverlayInfo(new Cpf());
					info.Family = agedArch.Hairtone;

					this.skinArch = new SkinReferenceTable(agedArch);

					this.ApplyItem(info, false);

					SimDNA dna = this.BuildSimDNA(archetype);
					this.UpdateDNA(dna);
				}

			}

		}

		public override void ApplyItem(GenericCpfInfo cpfInfo)
		{
			this.ApplyItem(cpfInfo, true);
		}

		void ApplyItem(GenericCpfInfo cpfInfo, bool updateDNA)
		{
			TextureOverlayInfo item = cpfInfo as TextureOverlayInfo;
			if (item != null)
			{
				this.UpdateAgeData(item);

				// TODO: use the clothing procedure to change current hair style

				if (updateDNA)
				{
					SimDNA dna = this.BuildSimDNA(cpfInfo);
					this.UpdateDNA(dna);
				}
			}

		}

		void UpdateAgeData(TextureOverlayInfo sourceItem)
		{
			AgeData agedPat = this.GetAgeData(this.SimPackage);
			agedPat.Hairtone = sourceItem.Family;

			if (this.skinArch != null)
			{
				SkinReferenceTable skinPat = new SkinReferenceTable(agedPat);
				foreach (SkinReferenceItem item in skinArch)
					if (item.Outfit == OutfitType.Hair)
						skinPat.Add(item);

				skinPat.CommitChanges();
			}
			else
			{
				// find a FileDescriptor from the hairtone family
				agedPat.CommitChanges();
			}

			

			
		}

		void UpdateDNA(SimDNA source)
		{

			using (SimDNA dna = this.GetSimDNA(this.SimDescription.Instance))
			{
				if (dna != null)
				{
					dna.Dominant.Hair = source.Dominant.Hair;
					if (this.OverrideRecessiveGenes)
						dna.Recessive.Hair = source.Recessive.Hair;

					dna.SynchronizeUserData();
				}
			}

		}


		SimDNA BuildSimDNA(GenericCpfInfo cpfInfo)
		{
			SimDNA ret = new SimDNA();
			ret.Dominant.Hair = cpfInfo.Family.ToString();
			ret.Recessive.Hair = cpfInfo.Family.ToString();
			return ret;
		}

	}
}
