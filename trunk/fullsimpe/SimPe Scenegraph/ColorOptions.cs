/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Collections;
using SimPe.Packages;
using SimPe.Interfaces.Files;


namespace SimPe.Plugin
{
	/// <summary>
	/// Creates a new Color Option package based on the passed package
	/// </summary>
	public class ColorOptions
	{
		/// <summary>
		/// The Base Package
		/// </summary>
		IPackageFile package;

		/// <summary>
		/// The tempory new package
		/// </summary>
		//IPackageFile newpkg;

		/// <summary>
		/// The Base Package
		/// </summary>
		public IPackageFile Package
		{
			get { return package; }
		}


		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="package">the source package</param>
		public ColorOptions(IPackageFile package)
		{
			this.package = package;
		}

		/*/// <summary>
		/// Loads a list of all subsets that support the design Mode
		/// </summary>
		/// <returns>a list of all SubSet Names this Package supports</returns>
		protected string[] GetSubsets() 
		{
			ArrayList list = new ArrayList();

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0x7BA3838C); //GMNDs
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol gmnd = new GenericRcol(null, false);
				gmnd.ProcessData(pfd, package);
				
				foreach (SimPe.Plugin.IRcolBlock rb in gmnd.Blocks) 
				{
					if (rb.BlockName=="cDataListExtension") 
					{
						DataListExtension dle = (DataListExtension)rb;
						if (dle.Extension.VarName.Trim().ToLower()=="tsdesignmodeenabled") 
						{
							foreach (ExtensionItem ei in dle.Extension.Items) 
							{
								string subset = ei.Name.Trim().ToLower();
								if (!list.Contains(subset)) list.Add(subset);
							}
						}
					}					
				}
			}

			string[] ret = new string[list.Count];
			list.CopyTo(ret);
			return ret;
		}

		/// <summary>
		/// Loads all MMATs belonging to a SubSet
		/// </summary>
		/// <param name="subsets">List of SubSets</param>
		/// <returns>Hastbale (key=subset Name, value=pfds for the loaded MMATs</returns>
		protected Hashtable GetMMATs(SubsetItem[] subsets, ArrayList cres) 
		{
			ArrayList subs = new ArrayList();
			foreach (SubsetItem s in subsets) subs.Add(s.Name);

			ArrayList processed = new ArrayList();

			Hashtable list = new Hashtable();

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0x4C697E5A); //MMATs
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
				mmat.ProcessData(pfd, package);

				//only files for referenced Cres
				if (!cres.Contains(mmat.GetSaveItem("modelName").StringValue.Trim().ToLower())) continue;

				ColorOptionsItem item = new ColorOptionsItem(mmat);
				//if (!item.Default) continue;

				string subset = "#0x"+Helper.HexString(item.Guid)+"!"+item.Subset;

				//not listed
				if (!subs.Contains(item.Subset)) continue;
				if (!processed.Contains(item.Subset)) processed.Add(item.Subset);

				Hashtable fams = null;
				ArrayList mmats = null;
				if (!list.Contains(subset)) 
				{
					fams = new Hashtable();
					list.Add(subset, fams);
				} 
				else 
				{
					fams = (Hashtable)list[subset];
				}

				if (!fams.Contains(item.Family)) 
				{
					mmats = new ArrayList();
					fams.Add(item.Family, mmats);
				} 
				else 
				{
					mmats = (ArrayList)fams[item.Family];
				}
				mmats.Add(item);
			}

			return list;
		}

		/// <summary>
		/// Loads the SubSet List 
		/// </summary>
		/// <param name="mmats"></param>
		/// <param name="guids">List of all GUIDs</param>
		/// <returns></returns>
		protected void LoadSubSetList(Hashtable mmats, ArrayList guids, SubsetItem[] subsets)
		{
			ArrayList txtrs = new ArrayList();
			ArrayList slaves = new ArrayList();

			bool first = true;
			int ct = 0;

			Hashtable matdrep = new Hashtable();
			Hashtable txtrrep = new Hashtable();

			string namefam = null;

			//build an ordered List of available SubSets

			//build a list of prefered Materials
			Hashtable prefered = new Hashtable();
			foreach (string subset in mmats.Keys) 
			{
				Hashtable fams = (Hashtable)mmats[subset];
				foreach (string fam in fams.Keys)
				{		
					foreach (ColorOptionsItem coi in (ArrayList)fams[fam]) 
					{
						if (!prefered.ContainsKey(coi.TxtrRef)) prefered.Add(coi.TxtrRef, 1);
						else 
						{
							int nr = (int)prefered[coi.TxtrRef] + 1;
							prefered[coi.TxtrRef] = nr;
						}
					}
				}
			}

			foreach (string subset in mmats.Keys) 
			{
				Hashtable fams = (Hashtable)mmats[subset];
				string family = null;
				string bestfam = null;
				int bestfamcount = 0;
				

				foreach (string fam in fams.Keys)
				{		
					family = fam;

					//choose a family that contains a TXTR that is already loaded
					bool stop = false;
						
					if (first)
					{
						foreach (ColorOptionsItem coi in (ArrayList)fams[family]) 
						{
							if (coi.MMAT!=null)  
							{
								//if (coi.Default) 
								{
									uint guid = coi.Guid;
									if (guids.Contains(guid)) 
									{
								//		stop=true;
								//		break;
										int count = (int)prefered[coi.TxtrRef];
										if (count>bestfamcount) 
										{
											bestfam = family;
											bestfamcount = count;
										}
									}
								}
							}
						} //foreach coi
					} 
					else 
					{	
						foreach (ColorOptionsItem coi in (ArrayList)fams[family]) 
						{
							if (coi.MATD!=null)  
							{
								if (txtrs.Contains(Hashes.StripHashFromName(coi.TxtrRef))) 
								{
									//if (guids.Contains(coi.Guid)) 
									{
										//		stop=true;
										//		break;
										int count = (int)prefered[coi.TxtrRef];
										if (count>bestfamcount) 
										{
											bestfam = family;
											bestfamcount = count;
										}
									}
								}
							}
						} //foreach coi						
					}

					if (stop) break;
					
				}

				//use the family with the most TxtrRferences
				if (bestfam!=null) family = bestfam;

				if (family!=null) 
				{
					string newfamily = System.Guid.NewGuid().ToString();
					if (namefam==null) namefam = newfamily;
					foreach (ColorOptionsItem coi in (ArrayList)fams[family]) 
					{

						//string oldtxtr = coi.Fix(namefam, newpkg.FileGroupHash, ref ct, matdrep, txtrrep, guids);
						string oldtxtr = coi.Fix(namefam, newpkg.FileGroupHash, ref ct, matdrep, txtrrep, new ArrayList());

						coi.MMAT.SynchronizeUserData();
						if (newpkg.FindFile(coi.MMAT.FileDescriptor)==null) newpkg.Add(coi.MMAT.FileDescriptor);

						if (coi.MATD!=null)  
						{
							coi.MATD.SynchronizeUserData();
							if (newpkg.FindFile(coi.MATD.FileDescriptor)==null) newpkg.Add(coi.MATD.FileDescriptor);
						}

						if (coi.TXTR!=null)  
						{
							coi.TXTR.SynchronizeUserData();
							if (newpkg.FindFile(coi.TXTR.FileDescriptor)==null) 
							{
								newpkg.Add(coi.TXTR.FileDescriptor);
								txtrs.Add(oldtxtr);
							}
						}

						///none slaves get 0xffffffff as group, later
						if (!coi.IsSlave(subset, subsets)) 
						{
							if (coi.MATD!=null) slaves.Add(coi.MATD.FileDescriptor);
							if (coi.TXTR!=null) slaves.Add(coi.TXTR.FileDescriptor);
						}
					}
				}

				first = false;
			}

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in slaves) pfd.Group = 0x1c050000; //0xffffffff;
		}

		/// <summary>
		/// Replace the Lifo References with the real Image
		/// </summary>
		protected void GetLifoFiles()
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = newpkg.FindFiles(0x1C4A276C); //TXTRs
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol txtr = new GenericRcol(null, false);
				txtr.ProcessData(pfd, newpkg);
				//we also need to get all LIFO Files
				foreach (IRcolBlock irc in txtr.Blocks)
				{
					if (irc.BlockName=="cImageData") 
					{
						ImageData id = (ImageData)irc;
						foreach (MipMapBlock mmp in id.MipMapBlocks) 
						{
							foreach (MipMap mm in mmp.MipMaps) 
							{
								//this is a LIFO Reference
								if (mm.Texture==null) 
								{
									Interfaces.Files.IPackedFileDescriptor[] lifos = package.FindFile(mm.LifoFile, 0xED534136);
									if (lifos.Length>0) 
									{
										Lifo l = new Lifo(null, false);
										l.ProcessData(lifos[0], package);
										if (l.Blocks.Length>0) 
										{
											mm.Texture = null;
											mm.Data = ((LevelInfo)l.Blocks[0]).Data;
										}
									}
								}
							}
						}
					}
				}

				txtr.SynchronizeUserData();
			}//foreach
		}


		/// <summary>
		/// Returns a hastable of a Slaves assigned to a subset
		/// </summary>
		/// <returns>The Slave Table</returns>
		protected Hashtable LoadSlaveSubsets() 
		{
			Hashtable list = new Hashtable();

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0x7BA3838C); //GMNDs
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.Rcol gmnd = new GenericRcol(null, false);
				gmnd.ProcessData(pfd, package);
				
				foreach (SimPe.Plugin.IRcolBlock rb in gmnd.Blocks) 
				{
					if (rb.BlockName=="cDataListExtension") 
					{
						DataListExtension dle = (DataListExtension)rb;
						if (dle.Extension.VarName.Trim().ToLower()=="tsdesignmodeslavesubsets") 
						{
							foreach (ExtensionItem ei in dle.Extension.Items) 
							{
								string subset = ei.Name.Trim().ToLower();
								string slaves = ei.String.Trim().ToLower();
								
								if (!list.Contains(subset)) list.Add(subset, slaves);
								else 
								{
									string slv = (string)list[subset];
									list[subset] = slaves+","+slv;
								}
							}
						}
					}					
				}
			}

			return list;
		}

		/// <summary>
		/// load a Slave Subsets for the selections
		/// </summary>
		/// <param name="subsets">the current Subsets</param>
		/// <returns>List of all needed subsets</returns>
		protected SubsetItem[] GetSlaveSubsets(string[] subsets)
		{
			ArrayList sets = new ArrayList();
			

			//find the tsDesignModeSlaveSubsets Block if it exists;
			Hashtable slaves = LoadSlaveSubsets();

			//now add the slaves
			foreach (string subset in subsets) 
			{
				sets.Add(new SubsetItem(subset, false));

				string slv = (string)slaves[subset];
				if (slv != null)
				{
					string[] slvs = slv.Split(",".ToCharArray());
					foreach (string s in slvs) if (!sets.Contains(s)) sets.Add(new SubsetItem(s, true));
				}
			}

			SubsetItem[] ret = new SubsetItem[sets.Count];
			sets.CopyTo(ret);
			return ret;
		}

		/// <summary>
		/// Returns a List of all GUIDs found for this Object
		/// </summary>
		/// <returns>Guid List</returns>
		protected ArrayList GetGUIDs()
		{
			ArrayList al = new ArrayList();
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE); //OBJDs
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				//if (pfd.Instance!=0x000041A7) continue;

				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfd, package);
				al.Add(objd.Guid);
			}

			return al;
		}

		/// <summary>
		/// Load all files from the Parent Object
		/// </summary>
		/// <param name="pfds">List of Geometry Nodes</param>
		/// <param name="subsets">Selected Subsets</param>
		protected void GetParentCres(ArrayList cres, SubsetItem[] subsets) 
		{
			ArrayList susets = new ArrayList();
			foreach(SubsetItem s in subsets) susets.Add(s.Name.Trim().ToLower());

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(0x7BA3838C);

			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				Rcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, package);

				foreach (SimPe.Plugin.IRcolBlock irb in rcol.Blocks) 
				{
					if (irb.BlockName=="cDataListExtension") 
					{
						SimPe.Plugin.DataListExtension dle = (SimPe.Plugin.DataListExtension)irb;
						if (dle.Extension.VarName.Trim().ToLower() == "tsmaterialsmeshname") 
						{
							foreach (SimPe.Plugin.ExtensionItem ei in dle.Extension.Items) 
							{
								if (!susets.Contains(ei.Name.Trim().ToLower())) continue;
								string name = ei.String.Trim();
								if (name!="") 
								{
									name = name.ToLower()+"_cres";
									if (!cres.Contains(name)) cres.Add(name);
								}
							}
						}
					}
				}
			}
		}

		/// <summary>
		/// Returns the List of allowed modeNames for this File
		/// </summary>
		/// <param name="subsets">All Selected Subsets</param>
		/// <returns>List of all Names (including _cres)</returns>
		protected ArrayList GetCresNames(SubsetItem[] subsets) 
		{
			ArrayList ret = new ArrayList();
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFile(Data.MetaData.STRING_FILE, 0, 0x85);

			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, package);

				for (int i=1; i<str.Items.Length; i++)
				{
					SimPe.PackedFiles.Wrapper.StrItem item = str.Items[i];
					string name = Hashes.StripHashFromName(item.Title.Trim());
					if (name!="") 
					{
						name = name.Trim().ToLower();
						if (name.IndexOf("_cres")!=(name.Length-5)) name += "_cres";
						if (!ret.Contains(name)) ret.Add(name);
					}
				}

				//only the first one is an original
				break;
			}

			GetParentCres(ret, subsets);
			return ret;
		}*/
		
		/// <summary>
		/// Adds the MMAT Files specified in the map to the new package
		/// </summary>
		/// <param name="newpkg"></param>
		/// <param name="map">Contains the MMATs that should be added</param>
		/// <param name="fullmap">Contains a List of all available MMATs</param>
		public void ProcessMmatMap(IPackageFile newpkg, Hashtable map, Hashtable fullmap) 
		{
			WaitingScreen.UpdateMessage("Loading Slave Subsets");
			AddSlavesSubsets(map, fullmap);

			uint inst = 0x6000;
			string unique = null;
			foreach (Hashtable ht in map.Values) 
			{
				foreach (ArrayList list in ht.Values) 
				{
					string family = System.Guid.NewGuid().ToString();
					if (unique == null) unique = family;

					foreach (SimPe.Plugin.MmatWrapper mmat in list) 
					{
						mmat.FileDescriptor = Scenegraph.Clone(mmat.FileDescriptor);
						mmat.FileDescriptor.Instance = inst++;
						mmat.FileDescriptor.Group = Data.MetaData.LOCAL_GROUP;
						mmat.Family = family;
						mmat.DefaultMaterial = false;
						
						

						GenericRcol txmt = mmat.TXMT;
						GenericRcol txtr = mmat.TXTR;
						//Get/Update Material Definition
						if (txmt!=null) 
						{
							string name = Hashes.StripHashFromName(txmt.FileName.Trim());
							if (name.ToLower().EndsWith("_txmt")) name = name.Substring(0, name.Length-5);

							txmt.FileName = FixObject.GetUniqueTxmtName(name, unique, mmat.SubsetName, true);///*"##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+*/name+"_"+unique+"_txmt";							
							txmt.FileDescriptor = ScenegraphHelper.BuildPfd(txmt.FileName, Data.MetaData.TXMT, Data.MetaData.CUSTOM_GROUP);														

							mmat.Name = "##0x"+Helper.HexString(txmt.FileDescriptor.Group)+"!"+FixObject.GetUniqueTxmtName(name, unique, mmat.SubsetName, false);
							
							//Get/Update Texture
							if (txtr!=null) 
							{
								//this was the old TextureName
								string old = Hashes.StripHashFromName(txtr.FileName.Trim().ToLower());
								if (old.EndsWith("_txtr")) old = old.Substring(0, old.Length-5);

								name = txtr.FileName.Trim();
								if (name.ToLower().EndsWith("_txtr")) name = name.Substring(0, name.Length-5);

								txtr.FileName = /*"##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+*/name+"_"+unique+"_txtr";							
								txtr.FileDescriptor = ScenegraphHelper.BuildPfd(txtr.FileName, Data.MetaData.TXTR, Data.MetaData.CUSTOM_GROUP);	

								MaterialDefinition md = (MaterialDefinition)txmt.Blocks[0];
								for (int i=0; i<md.Listing.Length; i++) 
								{
									if (Hashes.StripHashFromName(md.Listing[i].Trim().ToLower())==old) md.Listing[i] = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+name+"_"+unique;
								}
								
								//update References
								foreach (string k in txmt.ReferenceChains.Keys) 
								{
									if (k=="TXTR" || k=="Generic") continue;
									string thisname = Hashes.StripHashFromName(md.FindProperty(k).Value.Trim().ToLower());
									if (thisname==old)
										md.FindProperty(k).Value = "##0x"+Helper.HexString(Data.MetaData.CUSTOM_GROUP)+"!"+name+"_"+unique;
								}	
								md.FileDescription = Hashes.StripHashFromName(txmt.FileName).Trim();
								if (md.FileDescription.ToLower().EndsWith("_txmt")) md.FileDescription = md.FileDescription.Substring(0, md.FileDescription.Length-5);
							
								//Load the Lifos into the Texture File
								ImageData id = (ImageData)txtr.Blocks[0];
								id.GetReferencedLifos();
							}							
						}

						mmat.SynchronizeUserData();
						newpkg.Add(mmat.FileDescriptor);

						if (txmt!=null) 
						{
							txmt.SynchronizeUserData();
							if (newpkg.FindFile(txmt.FileDescriptor)==null)
								newpkg.Add(txmt.FileDescriptor);
						}

						if (txtr!=null) 
						{
							txtr.SynchronizeUserData();
							if (newpkg.FindFile(txtr.FileDescriptor)==null)
								newpkg.Add(txtr.FileDescriptor);
						}
					}
				}
			}
		}

		/// <summary>
		/// Returns the first MMAT file that links to the same Texture File as the passed mmat. 
		/// </summary>
		/// <param name="fullmap"></param>
		/// <param name="subset"></param>
		/// <returns></returns>
		/// <param name="mmat">If none was found, the first MMAT will be returned. Can also be null if no MMATS are available</param>
		protected ArrayList FindTxtrMatchingMmat(SimPe.Plugin.MmatWrapper mmat, Hashtable fullmap, string subset)
		{
			ArrayList ret = null;


			if ((fullmap.ContainsKey(subset)) && mmat.TXTR!=null)
			{
				Hashtable ht = (Hashtable)fullmap[subset];
				foreach (ArrayList list in ht.Values) 
				{
					foreach (SimPe.Plugin.MmatWrapper cur in list) 
					{
						if (ret == null) ret=list;
						if (cur.TXTR==null) continue;

						if (mmat.TXTR.FileName == cur.TXTR.FileName) return list;
					}
				}
			}
			return ret;
		}


		/// <summary>
		/// Adds the SlaveSubsets to the map 
		/// </summary>
		/// <param name="map">Contains the MMATs that should be added</param>
		/// <param name="fullmap">Contains a List of all available MMATs</param>
		/// <remarks>The slave MMAT files will be added to the map</remarks>
		protected void AddSlavesSubsets(Hashtable map, Hashtable fullmap)
		{			
			Hashtable slavemap = Scenegraph.GetSlaveSubsets(package);
			Hashtable newmap = new Hashtable();

			int ct = 0;
			foreach (string k in map.Keys) 
			{
				if (slavemap.ContainsKey(k)) 
				{
					if (map.ContainsKey(k)) 
					{
						ArrayList slaves = (ArrayList)slavemap[k];
						Hashtable families = (Hashtable)map[k];
						foreach (ArrayList list in families.Values) 
						{
							foreach (SimPe.Plugin.MmatWrapper mmat in list) 
							{
								foreach (string subset in slaves) 
								{
									ArrayList slavemmat = this.FindTxtrMatchingMmat(mmat, fullmap, subset);
									if (slavemmat!=null) 
									{
										Hashtable slaveht = new Hashtable();										
										slaveht["simpe_slave_loader_"+subset+"-"+ct.ToString()] = slavemmat;
										newmap[subset] = slaveht;
										ct++;
									}
								} //foreach subset
							} //foreach mmat
						} //foreach list						
					} //if (map.ContainsKey(k))
				}
			}

			if (newmap.Count>0) AddSlavesSubsets(newmap, fullmap);

			foreach (string k in newmap.Keys) map[k] = newmap[k];
		}

		public delegate void CreateSelectionCallback(SubsetSelectForm ssf, bool userselect, Hashtable fullmap);

		/// <summary>
		/// Create a new Color Options package
		/// </summary>
		/// <param name="newpkg">The Package the color Option should be added to</param>
		/// <param name="ask">if ask is true, a Dialog will be displayed that lets the 
		/// user decide which Subsets to recolor</param>
		public void Create(IPackageFile newpkg)
		{
			WaitingScreen.Wait();
			try 
			{
				//this.newpkg = newpkg;

				WaitingScreen.UpdateMessage("Loading available Color Options");
				Hashtable fullmap = Scenegraph.GetMMATMap(package);
				Hashtable map = fullmap;
				ArrayList allowedSubsets = Scenegraph.GetRecolorableSubsets(package);

				//Check if the User can select a Subset
				bool userselect = false;
				if (map.Count>1) userselect = true;
				else 
				{
					if (map.Count==1) 
					{
						foreach (string s in map.Keys) 
						{
							Hashtable ht = (Hashtable)map[s];
							if (ht.Count>1) userselect = true;
						}
					}
				}

				//let the user Select now					
				if (userselect) 
					map = SubsetSelectForm.Execute(map, allowedSubsets);
					
				
				
				ProcessMmatMap(newpkg, map, fullmap);
				
			}
			finally 
			{
				WaitingScreen.Stop();
			}
		}

		/// <summary>
		/// Create a new Color Options package
		/// </summary>
		/// <param name="newpkg">The Package the color Option should be added to</param>
		/// <param name="fkt">The function that ahs to be called wne the Selection should be displayed</param>
		public void Create(IPackageFile newpkg, CreateSelectionCallback fkt)
		{
			WaitingScreen.Wait();
			try 
			{
				//this.newpkg = newpkg;

				WaitingScreen.UpdateMessage("Loading available Color Options");
				Hashtable fullmap = Scenegraph.GetMMATMap(package);
				Hashtable map = fullmap;
				ArrayList allowedSubsets = Scenegraph.GetRecolorableSubsets(package);

				//Check if the User can select a Subset
				bool userselect = false;
				if (map.Count>1) userselect = true;
				else 
				{
					if (map.Count==1) 
					{
						foreach (string s in map.Keys) 
						{
							Hashtable ht = (Hashtable)map[s];
							if (ht.Count>1) userselect = true;
						}
					}
				}

				SubsetSelectForm ssf = SubsetSelectForm.Prepare(map, allowedSubsets);						
				fkt(ssf, userselect, fullmap);				
			}
			finally 
			{
				WaitingScreen.Stop();
			}
			return;
			/*string[] subsets = GetSubsets();

			//let the user Select
			if ((subsets.Length>1) && (ask))
			{
				Listing l = new Listing();
				subsets = l.Execute(subsets);
			}

			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Getting slave Subsets");
			SubsetItem[] subsetsi = GetSlaveSubsets(subsets);

			WaitingScreen.UpdateMessage("Getting Resource Nodes");
			ArrayList cres = GetCresNames(subsetsi);

			WaitingScreen.UpdateMessage("Getting Material Overrides");
			Hashtable mmats = GetMMATs(subsetsi, cres);
			ArrayList guids = GetGUIDs();

			LoadSubSetList(mmats, guids, subsetsi);

			WaitingScreen.UpdateMessage("Load LIFO Files");
			GetLifoFiles();

			WaitingScreen.Stop();*/
		}
	}
}
