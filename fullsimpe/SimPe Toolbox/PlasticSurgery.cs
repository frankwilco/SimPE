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

		#region simple Clone
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
		#endregion

		#region SkinTone only
		/// <summary>
		/// Set by the CloneSkintone Methode during calls to UpdateSkinTone
		/// </summary>
		uint patientgender = 1;

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
				}
			}

			return "";
		}

		/// <summary>
		/// If this is a skinFile it will be relinked to a property Set for the passed skintone
		/// </summary>
		/// <param name="skinfile">a PropertySet</param>
		/// <param name="skin">the new skintone</param>
		/// <param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>		
		/// <returns>FileDescriptor for the new SkinFile</returns>
		SimPe.Interfaces.Files.IPackedFileDescriptor UpdateSkintone(Cpf skinfile, string skin, Hashtable skinfiles)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor ret = skinfile.FileDescriptor;

			//this is a skin!
			if ((skinfile.GetSaveItem("category").UIntegerValue&(uint)Data.SkinCategories.Skin)==(uint)Data.SkinCategories.Skin) 
			{
				
				//the values that are checked for equality to find a matching Property Set in the target skintone
				Hashtable props = new Hashtable();

				props.Add("fitness", skinfile.GetSaveItem("fitness").StringValue.Trim().ToLower());
				props.Add("gender", skinfile.GetSaveItem("gender").StringValue.Trim().ToLower());
				props.Add("outfit", skinfile.GetSaveItem("outfit").StringValue.Trim().ToLower());
				props.Add("override0subset", skinfile.GetSaveItem("override0subset").StringValue.Trim().ToLower());

				foreach (Cpf newcpf in (ArrayList)skinfiles[skin]) 
				{
					if (((skinfile.GetSaveItem("age").UIntegerValue&newcpf.GetSaveItem("age").UIntegerValue)!=0)) 
					{
						bool use = true;
						foreach (string k in props.Keys) 
						{
						
							if (newcpf.GetSaveItem(k).StringValue.Trim().ToLower() != (string)props[k]) 
							{
								patientgender = skinfile.GetSaveItem("gender").UIntegerValue;
								use = false;
								break;
							}
						}
						if (use) 
						{
							ret = newcpf.FileDescriptor;
							return ret;
						}
					} 
				} //foreach
			}

			return ret;
		}

		/// <summary>
		/// Updates the SkinTone References in the 3IDR Files
		/// </summary>
		/// <param name="reffile">the 3IDR File</param><param name="skin">the new skintone</param>
		/// <param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>	
		void UpdateSkintone(SimPe.Plugin.RefFile reffile, string skin, Hashtable skinfiles)
		{
			for (int i=0; i<reffile.Items.Length; i++)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor pfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)reffile.Items[i];
				if (pfd.Type == Data.MetaData.GZPS) 
				{

					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fii = FileTable.FileIndex.FindFile(pfd);
					if (fii.Length>0) 
					{
						Cpf skinfile = new Cpf();
						skinfile.ProcessData(fii[0]);

						reffile.Items[i] = UpdateSkintone(skinfile, skin, skinfiles);
					}						
				}
			}

			reffile.SynchronizeUserData();
		}

		/// <summary>
		/// Updates the SkinTone References in the 3IDR Files
		/// </summary>
		/// <param name="md">The Metreial Definition</param>
		/// <param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>	
		/// <param name="sourceskin">the hash for the source skin</param>
		/// <param name="targetskin">the hash for the target skin</param>
		void UpdateSkintone(MaterialDefinition md, string targetskin, Hashtable skinfiles)
		{
			uint age = (uint)Data.MetaData.AgeTranslation((Data.MetaData.LifeSections)spatient.CharacterDescription.Age);
			try { age = (uint)Math.Pow(2, Convert.ToInt32(md.FindProperty("paramAge")));}  catch {}
			try { patientgender = Convert.ToUInt32(md.FindProperty("paramGender"));}  catch {}

			foreach (Cpf newcpf in (ArrayList)skinfiles[targetskin]) 
			{
				if (newcpf.GetSaveItem("override0subset").StringValue.Trim().ToLower()=="face") 				
					if ((newcpf.GetSaveItem("age").UIntegerValue & age) == age) 					
						if ((newcpf.GetSaveItem("gender").UIntegerValue & patientgender) == patientgender) 
						{
							Interfaces.Files.IPackedFileDescriptor[] pfds = newcpf.Package.FindFile(0xAC506764, newcpf.FileDescriptor.SubType, newcpf.FileDescriptor.Instance);

							if (pfds.Length>0) 
							{
								RefFile reffile = new RefFile();
								reffile.ProcessData(pfds[0], newcpf.Package);

								foreach (Interfaces.Files.IPackedFileDescriptor pfd in reffile.Items) 
								{
									if (pfd.Type == Data.MetaData.TXMT) 
									{
										Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(pfd);
										if (items.Length>0) 
										{
											Rcol rcol = new GenericRcol(null, false);
											rcol.ProcessData(items[0]);

											string name = rcol.FileName.Trim();
											if (name.ToLower().EndsWith("_txmt")) name = name.Substring(0, name.Length-5);

											string basename = name;
											
											if (basename.IndexOf("#")==0) 
											{
												basename+="~stdMatBaseTextureName";
												name = "_"+name;
											}
											else 
											{
												//while (name.Split("_").Length<2) name = "_"+name;
												basename = basename.Replace("_", "-");
											}											
											

											int count = 0;
											try { count = Convert.ToInt32(md.FindProperty("numTexturesToComposite").Value); } 
											catch {}

											if (count>0) 
											{
												md.FindProperty("baseTexture0").Value = basename;												
												md.FindProperty("stdMatBaseTextureName").Value = basename;
												
												string txtrname = name;
												for (int i=1; i<count; i++)
												{
													if (i!=0) txtrname += "_";
													txtrname += md.FindProperty("baseTexture"+i.ToString()).Value.Replace("-", "_");
												}

												md.FindProperty("compositeBaseTextureName").Value = txtrname;
												if (md.Listing.Length==1) md.Listing[0] = txtrname;
											}
										}
									}
								} //foreach reffile item
							}
							
						}
			}			
		}

		/// <summary>
		/// Change the SkinTone of a Sim (to the one of the archetype)
		/// </summary>
		/// <param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneSkinTone(Hashtable skinfiles)
		{
			string askin = GetSkintone(this.archetype);
			return CloneSkinTone(askin, skinfiles);
		}

		
		/// <summary>
		/// Change the SkinTone of a Sim
		/// </summary>
		/// <param name="skin">the new skintone</param>
		/// param name="skinfiles">a Hashtable listing al Proerty Sets for each available skintone (key=skintone string, value= ArrayList of Cpf Objects)</param>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneSkinTone(string skin, Hashtable skinfiles)
		{
			SimPe.Packages.GeneratableFile ret = new SimPe.Packages.GeneratableFile((string)null);
			string pskin = GetSkintone(this.patient);

			ArrayList list = new ArrayList();
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

			//Update 3IDR Files
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = ret.FindFiles(0xAC506764);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.RefFile reffile = new RefFile();
				reffile.ProcessData(pfd, ret);

				UpdateSkintone(reffile, skin, skinfiles);
			}

			//Update TXMT Files for the Face
			pfds = ret.FindFiles(Data.MetaData.TXMT);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, ret);

				MaterialDefinition md = (MaterialDefinition)rcol.Blocks[0];
				this.UpdateSkintone(md, skin, skinfiles);

				rcol.SynchronizeUserData();
			}

			
			return ret;
		}

		#endregion

		#region Face Only
		/// <summary>
		/// Clone the Face of a Sim
		/// </summary>
		/// <returns>the new Package for the patient Sim</returns>
		public SimPe.Packages.GeneratableFile CloneFace()
		{
			SimPe.Packages.GeneratableFile ret = new SimPe.Packages.GeneratableFile((string)null);

			

			ArrayList list = new ArrayList();
			list.Add((uint)0xCCCEF852); //LxNR, Face

			uint hashgroup = this.GetPatientHash();
			

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
				}
			}			
			
			return ret;
		}
		#endregion
	}
}
