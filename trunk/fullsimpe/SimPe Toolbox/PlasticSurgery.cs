using System;
using System.Collections;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// Performs the Sim Surgery
	/// </summary>
	public class PlasticSurgery
	{
		Interfaces.Files.IPackageFile patient;
		Interfaces.Files.IPackageFile archetype;		
		Interfaces.Files.IPackageFile ngbh;

		SDesc spatient;
		SDesc sarchetype;
		

		/// <summary>
		/// Init the Plastic Surgery
		/// </summary>
		/// <param name="ngbh">The Neighborhood the Sim lives in (needed for DNA)</param>
		/// <param name="patient">The Sim that should be changed</param>
		/// <param name="archetype">The Template Sime</param>
		public PlasticSurgery(Interfaces.Files.IPackageFile ngbh, Interfaces.Files.IPackageFile patient, SDesc spatient, Interfaces.Files.IPackageFile archetype, SDesc sarchetype)
		{
			this.patient = patient;
			this.archetype = archetype;
			this.ngbh = ngbh;

			this.spatient = spatient;
			this.sarchetype = sarchetype;
		}

		/// <summary>
		/// Returns the Hasvalue used for the Patient
		/// </summary>
		/// <returns></returns>
		uint GetPatientHash()
		{
			Random rn = new Random();
			uint hashgroup = (uint)((uint)rn.Next(0xffffff)|0xff000000);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in patient.Index) 
			{
				///This is a scenegraph Resource so get the Hash from there!
				if (Data.MetaData.RcolList.Contains(pfd.Type)) 
				{
					SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, patient);
					hashgroup = Hashes.GroupHash(rcol.FileName);
					break;
				}
			}

			return hashgroup;
		}

		/// <summary>
		/// Returns the Hasvalue used for the Patient
		/// </summary>
		/// <returns></returns>
		string GetSkintone(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
			{
				///This is a scenegraph Resource so get the Hash from there!
				if (pfd.Type == Data.MetaData.GZPS) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
					cpf.ProcessData(pfd, pkg);
					return cpf.GetSaveItem("skintone").StringValue;
					break;
				}
			}

			return "";
		}

		/// <summary>
		/// Create a cloned Sim
		/// </summary>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneSim()
		{
			SimPe.Packages.GeneratableFile ret = new SimPe.Packages.GeneratableFile((string)null);

			

			ArrayList list = new ArrayList();
			list.Add((uint)0xAC506764); //3IDR			
			list.Add(Data.MetaData.GZPS); //GZPS, Property Set
			list.Add((uint)0xAC598EAC); //AGED
			list.Add((uint)0xCCCEF852); //LxNR, Face
			list.Add((uint)0x856DDBAC); //IMG
			list.Add((uint)0x534C4F54); //SLOT
			list.AddRange(Data.MetaData.RcolList);

			uint hashgroup = this.GetPatientHash();
			

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in archetype.Index) 
			{
				if (list.Contains(pfd.Type)) 
				{
					Interfaces.Files.IPackedFile fl = archetype.Read(pfd);

					Interfaces.Files.IPackedFileDescriptor newpfd = ret.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
					newpfd.UserData = fl.UncompressedData;
					ret.Add(newpfd);

					///This is a scenegraph Resource and needs a new Hash
					if (Data.MetaData.RcolList.Contains(pfd.Type)) 
					{
						SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
						rcol.ProcessData(newpfd, ret);

						rcol.FileName = "#0x"+Helper.HexString(hashgroup)+"!"+Hashes.StripHashFromName(rcol.FileName);

						switch (pfd.Type) 
						{
							case Data.MetaData.SHPE:
							{
								Shape shp = (Shape)rcol.Blocks[0];
								foreach (ShapeItem i in shp.Items) 
								{
									i.FileName = "#0x"+Helper.HexString(hashgroup)+"!"+Hashes.StripHashFromName(i.FileName);
								}
								break;
							}
						}
						rcol.SynchronizeUserData();
					}
				}
			}

			list.Add((uint)0xE86B1EEF); //make sure the compressed Directory won't be copied!
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in patient.Index) 
			{
				if (!list.Contains(pfd.Type)) 
				{
					Interfaces.Files.IPackedFile fl = patient.Read(pfd);

					Interfaces.Files.IPackedFileDescriptor newpfd = ret.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
					newpfd.UserData = fl.UncompressedData;
					ret.Add(newpfd);
				}
			}

			//Copy DNA File
			Interfaces.Files.IPackedFileDescriptor dna = ngbh.FindFile(0xEBFEE33F, 0, Data.MetaData.LOCAL_GROUP, sarchetype.Instance);
			if (dna!=null)
			{
				Interfaces.Files.IPackedFileDescriptor tna = ngbh.FindFile(0xEBFEE33F, 0, Data.MetaData.LOCAL_GROUP, spatient.Instance);
				if (tna==null) 
				{
					tna = ngbh.NewDescriptor(0xEBFEE33F, 0, Data.MetaData.LOCAL_GROUP, spatient.Instance);
					tna.Changed = true;
					ngbh.Add(tna);
				}

				Interfaces.Files.IPackedFile fl = ngbh.Read(dna);

				tna.UserData = fl.UncompressedData;
			}
			
			return ret;
		}

		/// <summary>
		/// Change the SkinTone of a Sim (to the one of the archetype)
		/// </summary>
		/// <param name="skin">the new skintone (or null if archetypes skin)</param>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneSkinTone()
		{
			string askin = GetSkintone(this.archetype);
			return CloneSkinTone(askin);
		}

		
		/// <summary>
		/// Change the SkinTone of a Sim
		/// </summary>
		/// <param name="skin">the new skintone (or null if archetypes skin)</param>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneSkinTone(string skin)
		{
			SimPe.Packages.GeneratableFile ret = new SimPe.Packages.GeneratableFile((string)null);

									
			
			string pskin = GetSkintone(patient);

			ArrayList list = new ArrayList();
			//list.Add((uint)0xAC506764); //3IDR
			

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in archetype.Index) 
			{
				if (list.Contains(pfd.Type)) 
				{
					Interfaces.Files.IPackedFile fl = archetype.Read(pfd);

					Interfaces.Files.IPackedFileDescriptor newpfd = ret.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
					newpfd.UserData = fl.UncompressedData;
					ret.Add(newpfd);					
				}
			}

			list.Add((uint)0xE86B1EEF); //make sure the compressed Directory won't be copied!
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in patient.Index) 
			{
				if (!list.Contains(pfd.Type)) 
				{
					Interfaces.Files.IPackedFile fl = patient.Read(pfd);

					Interfaces.Files.IPackedFileDescriptor newpfd = ret.NewDescriptor(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
					newpfd.UserData = fl.UncompressedData;
					ret.Add(newpfd);

					switch (newpfd.Type) 
					{
						case (uint)0xAC598EAC: //AGED
						{
							SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
							cpf.ProcessData(newpfd, ret);
							cpf.GetSaveItem("skincolor").StringValue = skin;

							cpf.SynchronizeUserData();
							break;
						}
						case Data.MetaData.GZPS: 
						{
							SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
							cpf.ProcessData(newpfd, ret);
							cpf.GetSaveItem("skintone").StringValue = skin;

							cpf.SynchronizeUserData();
							break;
						}
						case Data.MetaData.TXMT:
						{
							SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
							rcol.ProcessData(newpfd, ret);
							MaterialDefinition txmt = (MaterialDefinition)rcol.Blocks[0];							
							txmt.FindProperty("cafSkinTone").Value = skin;

							rcol.SynchronizeUserData();
							break;
						}
					}
				}
			}

			//Update DNA File
			Interfaces.Files.IPackedFileDescriptor dna = ngbh.FindFile(0xEBFEE33F, 0, Data.MetaData.LOCAL_GROUP, spatient.Instance);
			if (dna!=null)
			{				
				SimPe.PackedFiles.Wrapper.Cpf cpf = new Cpf();
				cpf.ProcessData(dna, ngbh);
				cpf.GetSaveItem("2").StringValue = skin;				
				cpf.GetSaveItem("6").StringValue = skin;

				cpf.SynchronizeUserData();
			}
			
			return ret;
		}
	}
}
