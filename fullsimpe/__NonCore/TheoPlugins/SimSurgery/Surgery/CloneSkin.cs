using System;
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces.Files;
using SimPe.PackedFiles.Wrapper;
using SimPe.Data;
using System.Collections;
using SimPe.Packages;
using SimPe.Interfaces.Scenegraph;
using SimPe.Plugin.Helper;
using System.Collections.Specialized;
using SimPe.Plugin.Wrapper;

namespace SimPe.Plugin.Surgery
{
	public class CloneSkin : GeneticProcedure
	{
		List<MaterialDefinitionInfo> txmtListArchetype;
		List<MaterialDefinitionInfo> txmtListPatient;

		public CloneSkin()
		{
		}

		public override void ApplyItem(IPackageFile archetype)
		{
			this.txmtListArchetype = MaterialDefinitionInfo.FindMaterials(archetype);

			using (AgeData data = this.GetAgeData(archetype))
			{
				if (data != null)
				{
					GenericCpfInfo info = this.FileDatabase.FindItemByFamily(data.Skintone);

					if (info == null)
					{
						// DANGER! Skin package not in FileTable!
						// Luckily, it appears that the change in
						// the SDNA resource is enough, and the game
						// will propagate the changes from there...
						info = new SkinInfo();
						info.PropertySet = new Cpf();
						info.Family = data.Skintone;
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
			if (!(cpfInfo is SkinInfo))
				throw new ArgumentException();

			SkinInfo selectedSkin = cpfInfo as SkinInfo;

			this.UpdateAgeData(selectedSkin);

			this.UpdateMaterials(selectedSkin);

			foreach (IPackedFileDescriptor pfd in this.SimPackage.Index)
			{
				if (pfd.Type == Utility.DataType.GZPS)
				{
					Cpf cpf = new Cpf();
					cpf.ProcessData(pfd, this.SimPackage);
					cpf.GetSaveItem("skintone").StringValue = selectedSkin.Family.ToString();

					cpf.SynchronizeUserData();
					break;
				}


			} // foreach


			this.UpdateReferences(selectedSkin);

			if (updateDNA)
			{
				SimDNA dna = this.BuildSimDNA(selectedSkin);
				this.UpdateDNA(dna);
			}

		}


		void UpdateAgeData(SkinInfo sourceInfo)
		{
			using (AgeData data = this.GetAgeData(this.SimPackage))
			{
				if (data != null)
				{
					data.Skintone = sourceInfo.Family;
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
					dna.Dominant.Skintone = source.Dominant.Skintone;
					dna.Dominant.SkintoneRange = source.Dominant.SkintoneRange;
					if (this.OverrideRecessiveGenes)
					{
						dna.Recessive.Skintone = source.Recessive.Skintone;
						dna.Recessive.SkintoneRange = source.Recessive.SkintoneRange;
					}

					dna.SynchronizeUserData();
				}
			}

		}

		void UpdateMaterials(SkinInfo sourceInfo)
		{

			txmtListPatient = MaterialDefinitionInfo.FindMaterials(this.SimPackage);
			foreach (MaterialDefinitionInfo txmtPatient in txmtListPatient)
			{
				txmtPatient.Skintone = sourceInfo.Family;

				if (!Utility.IsNullOrEmpty(sourceInfo.Items))
				{
					foreach (TextureOverlayInfo item in sourceInfo.Items)
					{
						if (
							(item.OverrideCount > 0) &&
							(item.OverrideList[0].Subset.Equals("face", StringComparison.InvariantCultureIgnoreCase)) &&
							(item.Age == txmtPatient.Age) &&
							(item.Gender == txmtPatient.Gender)
							)
						{
							txmtPatient.TextureNames[0] = item.MaterialDefinitions[0].BaseTextureName;
							break;
						}
					}
				}
				else {
					// we must find another route...
					if (!Utility.IsNullOrEmpty(this.txmtListArchetype))
					{
						MaterialDefinitionInfo txmt = MaterialDefinitionInfo.FindMaterial(
							this.txmtListArchetype,
							txmtPatient.Age,
							txmtPatient.Gender);

						if (txmt != null)
							txmtPatient.TextureNames[0] = txmt.TextureNames[0]; // :P
					}
					else
					{
						// 
						this.EventLog.Add("Unable to find the skin texture name for: {0} {1}",
							txmtPatient.Age,
							txmtPatient.Gender);
					}

				}


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

		void UpdateReferences(SkinInfo targetSkin)
		{
			//Update 3IDR Files
			IPackedFileDescriptor[] pfds = this.SimPackage.FindFiles(MetaData.REF_FILE);
			foreach (IPackedFileDescriptor pfdRef in pfds)
			{
				RefFile reffile = new RefFile();
				reffile.ProcessData(pfdRef, this.SimPackage);

				if (reffile.Items == null) return;
				if (reffile.Package == null) return;

				for (int i = 0; i < reffile.Items.Length; i++)
				{
					IPackedFileDescriptor pfd = (IPackedFileDescriptor)reffile.Items[i];
					if (pfd == null)
						continue;

					if (pfd.Type == MetaData.GZPS)
					{
						IScenegraphFileIndexItem[] fii = FileTable.FileIndex.FindFile(pfd, reffile.Package);
						if (fii.Length > 0)
						{
							Cpf skinfile = new Cpf();
							skinfile.ProcessData(fii[0]);

							reffile.Items[i] = UpdatePropertySet(skinfile, targetSkin);
						}
					}
				}

				reffile.SynchronizeUserData();
			}

		}

		/// <summary>
		/// If this is a skinFile it will be relinked to a property Set for the passed skintone
		/// </summary>
		/// <param name="skinfile">a PropertySet</param>
		/// <param name="skin">the new skintone</param>
		/// <param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>		
		/// <returns>FileDescriptor for the new SkinFile</returns>
		IPackedFileDescriptor UpdatePropertySet(Cpf skinfile, SkinInfo targetSkin)
		{
			IPackedFileDescriptor ret = skinfile.FileDescriptor;

			TextureOverlayInfo skinInfo = new TextureOverlayInfo(skinfile);

			//this is a skin!
			if (skinInfo.Category == SkinCategories.Skin)
			{

				//the values that are checked for equality to find a matching Property Set in the target skintone
				NameValueCollection props = new NameValueCollection();

				props.Add("fitness", skinInfo.GetItem("fitness").StringValue.Trim());
				props.Add("gender", skinInfo.Gender.ToString());
				props.Add("outfit", skinInfo.OutfitType.ToString());
				props.Add("override0subset", skinInfo.OverrideList[0].Subset);

				foreach (TextureOverlayInfo newcpf in targetSkin.Items)
				{
					if ((skinInfo.Age &	newcpf.Age) != 0) // serves as equality comparison??
					{
						bool use = true;
						foreach (string k in props.AllKeys)
						{

							if (
								String.Compare(
									newcpf.GetItem(k).StringValue.Trim(),
									props[k],
									StringComparison.InvariantCultureIgnoreCase
									) != 0
								)
							{
								//patientGender = skinfile.GetSaveItem("gender").UIntegerValue;
								use = false;
								break;
							}
						}

						if (use)
						{
							ret = newcpf.PropertySet.FileDescriptor;
							return ret;
						}
					}
				} //foreach
			}

			return ret;
		}



		SimDNA BuildSimDNA(GenericCpfInfo cpfInfo)
		{
			SimDNA ret = new SimDNA();
			ret.Dominant.Skintone = cpfInfo.Family.ToString();
			ret.Dominant.SkintoneRange = cpfInfo.Family.ToString();
			ret.Recessive.Skintone = cpfInfo.Family.ToString();
			ret.Recessive.SkintoneRange = cpfInfo.Family.ToString();
			return ret;
		}


	} // class
}
