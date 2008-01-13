using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{

	public class CloneEyes : GeneticProcedure
	{
		List<MaterialDefinitionInfo> txmtListArchetype;
		List<MaterialDefinitionInfo> txmtListPatient;

		public CloneEyes()
		{
		}


		public override void ApplyItem(IPackageFile archetype)
		{
			this.txmtListArchetype = MaterialDefinitionInfo.FindMaterials(archetype);

			using (AgeData data = this.GetAgeData(archetype))
			{
				if (data != null)
				{
					GenericCpfInfo info = this.FileDatabase.FindItemByFamily(data.Eyecolor);
					if (info == null)
					{
						// DANGER! Skin package not in FileTable!
						info = new TextureOverlayInfo(new Cpf());
						info.Family = data.Eyecolor;
					}


					// the dna update is more accurate on this side ;)
					this.ApplyItem(info, false);

					SimDNA dna = this.BuildSimDNA(archetype);
					this.UpdateDNA(dna);

				}

			}

		}

		public override void ApplyItem(GenericCpfInfo cpfInfo)
		{
			// when it's an external call, perform dna update too
			this.ApplyItem(cpfInfo, true);
		}

		void ApplyItem(GenericCpfInfo cpfInfo, bool updateDNA)
		{
			TextureOverlayInfo item = cpfInfo as TextureOverlayInfo;
			if (item != null)
			{
				this.UpdateAgeData(item);
				this.UpdateMaterials(item);

				if (updateDNA)
				{
					SimDNA dna = this.BuildSimDNA(item);
					this.UpdateDNA(dna);
				}

			}

		}

		void UpdateAgeData(TextureOverlayInfo sourceItem)
		{
			using (AgeData data = this.GetAgeData(this.SimPackage))
			{
				if (data != null)
				{
					data.Eyecolor = sourceItem.Family;
					data.CommitChanges();
				}
			}
		}

		void UpdateDNA(SimDNA source)
		{

			using (SimDNA dna = this.GetSimDNA(this.SimDescription.Instance))
			{
				if (dna != null)
				{
					dna.Dominant.Eye = source.Dominant.Eye;
					if (this.OverrideRecessiveGenes)
						dna.Recessive.Eye = source.Recessive.Eye;

					dna.SynchronizeUserData();
				}
			}

		}

		SimDNA BuildSimDNA(GenericCpfInfo cpfInfo)
		{
			SimDNA ret = new SimDNA();
			ret.Dominant.Eye = cpfInfo.Family.ToString();
			ret.Recessive.Eye = cpfInfo.Family.ToString();
			return ret;
		}

		void UpdateMaterials(TextureOverlayInfo sourceItem)
		{
			txmtListPatient = MaterialDefinitionInfo.FindMaterials(this.SimPackage);
			foreach (MaterialDefinitionInfo txmtPatient in txmtListPatient)
			{
				txmtPatient.OverlayGuids[0] = sourceItem.Family;

				if (!Utility.IsNullOrEmpty(this.txmtListArchetype))
				{
					MaterialDefinitionInfo txmt = MaterialDefinitionInfo.FindMaterial(
						this.txmtListArchetype,
						txmtPatient.Age,
						txmtPatient.Gender);

					if (txmt != null)
						txmtPatient.TextureNames[1] = txmt.TextureNames[1]; // textureName;
				}
				else if (!Utility.IsNullOrEmpty(sourceItem.MaterialDefinitions))
				{
					txmtPatient.TextureNames[1] = sourceItem.MaterialDefinitions[0].BaseTextureName;
				}
				else
					// no archetype? need to find a way to get the eye's
					// texture name, even without a FileTable entry :o
					throw new ApplicationException();


				try
				{
					// problem can happen here...
					txmtPatient.CommitChanges();
				}
				catch (Exception x)
				{
					// TODO: provide more detailed information
					this.EventLog.Add(x);
				}

			}

		}



	} // class




}
