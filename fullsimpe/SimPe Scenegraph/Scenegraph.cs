using System;
using System.Collections;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class builds the SceneGraph Chain based on a modelname
	/// </summary>
	public class Scenegraph
	{
		/// <summary>
		/// A List of Files you the Reference Check should exclude
		/// </summary>
		static ArrayList excludefiles = new ArrayList();

		/// <summary>
		/// A List of Files the SceneGraph will ignore when following a Reference
		/// </summary>
		public static ArrayList FileExcludeList
		{
			get { return excludefiles; }		
			set { excludefiles = value; }
		}

		/// <summary>
		/// The Default List for FileExcludeList
		/// </summary>
		public static ArrayList DefaultFileExcludeList 
		{
			get 
			{
				ArrayList ret = new ArrayList();
				ret.Add("simple_mirror_reflection_txmt");								
				return ret;
			}
		}

		/// <summary>
		/// Contains the base Modelnames
		/// </summary>
		ArrayList modelnames;	

		/// <summary>
		/// Contains all found Files
		/// </summary>
		ArrayList files;

		/// <summary>
		/// All loaded Items
		/// </summary>
		ArrayList itemlist;

		/// <summary>
		/// List of all References that should not be followed
		/// </summary>
		ArrayList exclude;

		/// <summary>
		/// Returns a List of a References that should be excluded
		/// </summary>
		public ArrayList ExcludedReferences
		{
			get { return exclude; }
		}


		/// <summary>
		/// Create a clone of the Descriptor, so changes won't affect the source Package anymore!
		/// </summary>
		/// <param name="item">Clone the Descriptor in this Item</param>
		public static void Clone(Interfaces.Scenegraph.IScenegraphFileIndexItem item) 
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Type = item.FileDescriptor.Type;
			pfd.Group = item.FileDescriptor.Group;
			pfd.LongInstance = item.FileDescriptor.LongInstance;

			pfd.Offset = item.FileDescriptor.Offset;
			pfd.Size = item.FileDescriptor.Size;

			pfd.UserData = item.FileDescriptor.UserData;

			item.FileDescriptor = pfd;
		}

		/// <summary>
		/// Create a clone of the Descriptor, so changes won't affect the source Package anymore!
		/// </summary>
		/// <param name="item">Clone the Descriptor in this Item</param>
		public static SimPe.Packages.PackedFileDescriptor Clone(SimPe.Interfaces.Files.IPackedFileDescriptor org) 
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Type = org.Type;
			pfd.Group = org.Group;
			pfd.LongInstance = org.LongInstance;

			return pfd;
		}

		/// <summary>
		/// Return all Modelnames that can be found in this package
		/// </summary>
		/// <param name="pkg">The Package you want to scan</param>
		/// <returns>a list of Modelnames</returns>
		public static string[] FindModelNames(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			ArrayList names = new ArrayList();

			Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFile(Data.MetaData.STRING_FILE, 0, 0x85);
			if (pfds.Length>0) 
			{
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
					str.ProcessData(pfd, pkg);

					foreach (SimPe.PackedFiles.Wrapper.StrItem item in str.Items) 
					{
						string mname = Hashes.StripHashFromName(item.Title.Trim().ToLower());
						if (!mname.EndsWith("_cres")) mname += "_cres";
						if ((mname!="") && (!names.Contains(mname))) names.Add(mname);
					}
				}
			}

			pfds = pkg.FindFiles(Data.MetaData.MMAT);
			if (pfds.Length>0) 
			{
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfd, pkg);

					string mname = Hashes.StripHashFromName(cpf.GetSaveItem("modelName").StringValue.Trim().ToLower());
					if (!mname.EndsWith("_cres")) mname += "_cres";
					if ((mname!="") && (!names.Contains(mname))) names.Add(mname);
				}
			}

			string[] ret = new string[names.Count];
			names.CopyTo(ret);

			return ret;
		}

		/// <summary>
		/// Load all pending CRES Files
		/// </summary>
		/// <param name="modelnames"></param>
		/// <returns></returns>
		protected ArrayList LoadCres(string[] modelnames)
		{
			ArrayList cres = new ArrayList();
			for (int i=0; i< modelnames.Length; i++) 
			{
				modelnames[i] = modelnames[i].Trim().ToLower();
				if (!modelnames[i].EndsWith("_cres")) modelnames[i] += "_cres";
				Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(modelnames[i], Data.MetaData.CRES, Data.MetaData.LOCAL_GROUP, true);
				//Clone(item);

				if (item!=null) cres.Add(item);
			}

			return cres;
		}

		
		
		/// <summary>
		/// Load all File referenced by the passed rcol File
		/// </summary>
		/// <param name="modelnames">The Modulenames</param>
		/// <param name="exclude">The Exclude List</param>
		/// <param name="list">A List containing all Rcol Files</param>
		/// <param name="itemlist">A List of all FileIndexItems already added</param>
		/// <param name="rcol">The Rcol File (Scenegraph Resource)</param>
		/// <param name="item">The Item that was used to load the rcol</param>
		/// <param name="recursive">true if you want to add all sub Rcols</param>
		protected static void LoadReferenced(ArrayList modelnames, ArrayList exclude, ArrayList list, ArrayList itemlist, SimPe.Plugin.GenericRcol rcol, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item, bool recursive) 
		{
			//if we load a CRES, we also have to add the Modelname!
			if (rcol.FileDescriptor.Type == Data.MetaData.CRES) 
				modelnames.Add(rcol.FileName.Trim().ToLower());
			
			list.Add(rcol);
			itemlist.Add(item);

			Hashtable map = rcol.ReferenceChains;
			foreach (string s in map.Keys) 
			{
				if (exclude.Contains(s)) continue;

				ArrayList descs = (ArrayList)map[s];
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in descs) 
				{				
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem subitem = FileTable.FileIndex.FindSingleFile(pfd, true);

					if (subitem!=null) 
					{
						if (!itemlist.Contains(subitem)) 
						{
							try 
							{
								SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
								sub.ProcessData(subitem.FileDescriptor, subitem.Package, false);

								if (Scenegraph.excludefiles.Contains(sub.FileName.Trim().ToLower())) continue;

								if (recursive) LoadReferenced(modelnames, exclude, list, itemlist, sub, subitem, true);
							}
							catch (Exception ex) 
							{
								Helper.ExceptionMessage("", new CorruptedFileException(subitem, ex));								
							}
						}
					}
				}
			}
		}

		

		/// <summary>
		/// Create a new Instance and build the CRES chain
		/// </summary>
		/// <param name="modelnames">Name of all Models</param>
		public Scenegraph(string modelname)
		{
			string[] modelnames = new string[1];
			modelnames[0] = modelname;
			Init(modelnames, new ArrayList());
		}

		/// <summary>
		/// Create a new Instance and build the CRES chain
		/// </summary>
		/// <param name="modelnames">Name of all Models</param>
		public Scenegraph(string[] modelnames)
		{
			Init(modelnames, new ArrayList());
		}
		

		/// <summary>
		/// Create a new Instance and build the CRES chain
		/// </summary>
		/// <param name="modelnames">Name of all Models</param>
		/// <param name="ex">List of all ReferenceNames that should be excluded from the chain</param>
		public Scenegraph(string[] modelnames, ArrayList ex)
		{
			Init(modelnames, ex);
			
		}

		/// <summary>
		/// Create a new Instance and build the CRES chain
		/// </summary>
		/// <param name="modelnames">Name of all Models</param>
		/// <param name="ex">List of all ReferenceNames that should be excluded from the chain</param>
		public void Init(string[] modelnames, ArrayList ex)
		{						
			exclude = ex;
			this.modelnames = new ArrayList();			
			ArrayList cres = LoadCres(modelnames);

			files = new ArrayList();
			itemlist = new ArrayList();
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in cres) 
			{
				SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
				sub.ProcessData(item);
				LoadReferenced(this.modelnames, ex, files, itemlist, sub, item, true);
			}
			foreach (string s in modelnames) this.modelnames.Add(s);
			
		}

		/// <summary>
		/// returns a unique identifier for the MMAT Files
		/// </summary>
		/// <param name="mmat"></param>
		/// <returns></returns>
		public static string MmatContent(SimPe.PackedFiles.Wrapper.Cpf mmat)
		{
			return mmat.GetSaveItem("modelName").StringValue/*+mmat.GetSaveItem("family").StringValue*/+mmat.GetSaveItem("subsetName").StringValue+mmat.GetSaveItem("name").StringValue+Helper.HexString(mmat.GetSaveItem("objectStateIndex").UIntegerValue)+Helper.HexString(mmat.GetSaveItem("materialStateFlags").UIntegerValue)+Helper.HexString(mmat.GetSaveItem("objectGUID").UIntegerValue);
		}

		/// <summary>
		/// Loads Slave TXMTs by name Replacement
		/// </summary>
		/// <param name="rcol">a TXMT File</param>
		/// <param name="pkg">the package File with the base TXMTs</param>
		/// <param name="slaves">The Hashtable holding als Slave Subsets</param>
		public static void AddSlaveTxmts(ArrayList modelnames, ArrayList ex, ArrayList list, ArrayList itemlist, Rcol rcol, Hashtable slaves) 
		{
			string name = rcol.FileName.Trim().ToLower();
			foreach (string k in slaves.Keys)
				foreach (string sub in (ArrayList)slaves[k])
				{
					string slavename = name.Replace("_"+k+"_", "_"+sub+"_");
					if (slavename!=name) 
					{
						SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(slavename, Data.MetaData.TXMT, Data.MetaData.LOCAL_GROUP, true);
						if (item!=null) 
						{
							GenericRcol txmt = new GenericRcol(null, false);
							txmt.ProcessData(item);
							txmt.FileDescriptor = (Interfaces.Files.IPackedFileDescriptor)item.FileDescriptor.Clone();														
							
							LoadReferenced(modelnames, ex, list, itemlist, txmt, item, true);
						}
					}
				}
		}

		/// <summary>
		/// Loads Slave TXMTs by name Replacement
		/// </summary>
		/// <param name="slaves">The Hashtable holding als Slave Subsets</param>
		public  void AddSlaveTxmts(Hashtable slaves)
		{
			for (int i=files.Count-1; i>=0; i--)
			{
				GenericRcol rcol = (GenericRcol) files[i];

				if (rcol.FileDescriptor.Type == Data.MetaData.TXMT)				
					AddSlaveTxmts(this.modelnames, this.exclude, files, itemlist, rcol, slaves);				
			}
		}

		/// <summary>
		/// Loads Slave TXMTs by name Replacement
		/// </summary>
		/// <param name="pkg">the package File with the base TXMTs</param>
		/// <param name="slaves">The Hashtable holding als Slave Subsets</param>
		public static void AddSlaveTxmts(SimPe.Interfaces.Files.IPackageFile pkg, Hashtable slaves)
		{
			ArrayList files = new ArrayList();
			ArrayList items = new ArrayList();

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.TXMT);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				GenericRcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, pkg);

				if (rcol.FileDescriptor.Type == Data.MetaData.TXMT)				
					AddSlaveTxmts(new ArrayList(), new ArrayList(), files, items, rcol, slaves);				
			}

			foreach (GenericRcol rcol in files) 
			{
				if (pkg.FindFile(rcol.FileDescriptor)==null)
				{
					rcol.FileDescriptor = rcol.FileDescriptor.Clone();
					rcol.SynchronizeUserData();
					pkg.Add(rcol.FileDescriptor);
				}
			}
		}

		#region Cache Handling
		static SimPe.Cache.MMATCacheFile cachefile;
		static void LoadCache()
		{
			if (cachefile!=null) return;
			
			cachefile = new SimPe.Cache.MMATCacheFile();
			if (Helper.WindowsRegistry.UseCache) cachefile.Load(Helper.SimPeCache);
		}

		static void SaveCache() 
		{
			if (Helper.WindowsRegistry.UseCache) cachefile.Save(Helper.SimPeCache);
		}
		#endregion

		/// <summary>
		/// Adds all know MMATs that reference one of the models;
		/// </summary>
		/// <param name="pkg"></param>
		/// <param name="onlydefault">true, if you only want to read default MMATS</param>
		/// <param name="subitems">true, if you also want to load MMAT Files that reference Files ouside the passed package</param>
		/// <param name="exception">true if you want to throw an exception when something goes wrong</param>
		/// <returns>List of all referenced GUIDs</returns>
		public void AddMaterialOverrides(SimPe.Interfaces.Files.IPackageFile pkg, bool onlydefault, bool subitems, bool exception)
		{			
			LoadCache();

			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.MMAT, true);
			ArrayList itemlist = new ArrayList();
			ArrayList contentlist = new ArrayList();
			ArrayList defaultfam = new ArrayList();
			ArrayList guids = new ArrayList();

			//create an UpTo Date Cache
			bool chgcache = false;
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
			{
				string pname = item.Package.FileName.Trim().ToLower();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] citems = cachefile.FileIndex.FindFile(item.FileDescriptor);
				bool have=false;
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem citem in citems) 
				{
					if (citem.FileDescriptor.Filename == pname) 
					{
						have = true;
						break;
					}
				}

				//Not in cache, so add that File
				if (!have) 
				{
					SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
					mmat.ProcessData(item.FileDescriptor, item.Package);

					cachefile.AddItem(mmat);
					chgcache = true;
				}
			}
			if (chgcache) SaveCache();

			//collect a list of Default Material Override family values first
			if (onlydefault) 
			{
				foreach (SimPe.Cache.MMATCacheItem mci in (SimPe.Cache.CacheItems)cachefile.DefaultMap[true])
					defaultfam.Add(mci.Family);				
			}

			//now do the real collect
			foreach (string k in modelnames) 
			{
				SimPe.Cache.CacheItems list = (SimPe.Cache.CacheItems)cachefile.ModelMap[k.Trim().ToLower()];
				if (list!=null)				
				{
					foreach (SimPe.Cache.MMATCacheItem mci in list) 
					{
						if (onlydefault && !defaultfam.Contains(mci.Family)) continue;

						string name = k;
						items = FileTable.FileIndex.FindFile(mci.FileDescriptor);						

						foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
						{
							if (itemlist.Contains(item)) continue;
							itemlist.Add(item);
							SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
							mmat.ProcessData(item);

							string content = Scenegraph.MmatContent(mmat);
							content = content.Trim().ToLower();
							if (!contentlist.Contains(content)) 
							{
								mmat.FileDescriptor = Clone(mmat.FileDescriptor);
								mmat.SynchronizeUserData();						

								if (subitems) 
								{
									if (pkg.FindFile(mmat.FileDescriptor)==null)
										pkg.Add(mmat.FileDescriptor);

									SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem txmtitem = SimPe.FileTable.FileIndex.FindFileByName(mmat.GetSaveItem("name").StringValue+"_txmt", Data.MetaData.TXMT, Data.MetaData.LOCAL_GROUP, true);
									if (txmtitem!=null) 
									{
										
										try 
										{
											SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
											sub.ProcessData(txmtitem.FileDescriptor, txmtitem.Package, false);
											ArrayList newfiles = new ArrayList();
											LoadReferenced(this.modelnames, this.exclude, newfiles, itemlist, sub, txmtitem, true);
											BuildPackage(newfiles, pkg);
										} 
										catch (Exception ex) 
										{
											Helper.ExceptionMessage("", new CorruptedFileException(txmtitem, ex));
										}						
										

									} 
									else 
									{
										continue;
										//if (exception) throw new ScenegraphException("Invalid Scenegraph Link", new ScenegraphException("Unable to find Referenced File "+name+"_txmt.", mmat.FileDescriptor), mmat.FileDescriptor);
									}
								} 
								else 
								{
									if (pkg.FindFile(mmat.FileDescriptor)==null) 
									{
										string txmtname = mmat.GetSaveItem("name").StringValue.Trim();
										if (!txmtname.EndsWith("_txmt")) txmtname += "_txmt";
										if (pkg.FindFile(txmtname, Data.MetaData.TXMT).Length>0) 
										{
											pkg.Add(mmat.FileDescriptor);
										}
									}
								}
								contentlist.Add(content);
							} //if contentlist
						} //foreach item
					} //foreach MMATCacheItem
				} // if list !=null
			}
		}

		/// <summary>
		/// Will return a List of all SubSets that can be recolored
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns>a List of Subset Names</returns>
		public static ArrayList GetRecolorableSubsets(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			return GetSubsets(pkg, "tsdesignmodeenabled");
		}

		/// <summary>
		/// Will return a List of all SubSets that are borrowed from a Parent Object
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns>a List of Subset Names</returns>
		public static ArrayList GetParentSubsets(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			return GetSubsets(pkg, "tsMaterialsMeshName");
		}

		/// <summary>
		/// Will return a List of all SubSets that can be recolored
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns>a List of Subset Names</returns>
		public static ArrayList GetSubsets(SimPe.Interfaces.Files.IPackageFile pkg, string blockname)
		{
			ArrayList list = new ArrayList();
			blockname = blockname.Trim().ToLower();
			SimPe.Interfaces.Files.IPackedFileDescriptor[] gmnds = pkg.FindFiles(Data.MetaData.GMND);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in gmnds) 
			{
				SimPe.Plugin.GenericRcol gmnd = new GenericRcol(null, false);
				gmnd.ProcessData(pfd, pkg);

				foreach (IRcolBlock irb in gmnd.Blocks) 
				{
					if (irb.BlockName == "cDataListExtension") 
					{
						DataListExtension dle = (DataListExtension)irb;
						if (dle.Extension.VarName.Trim().ToLower() == blockname) 
						{
							foreach (ExtensionItem ei in dle.Extension.Items) 
							{
								list.Add(ei.Name.Trim().ToLower());
							}
						}
					}
				}
			}
			return list;
		}


		/// <summary>
		/// Adds the Slave definitions of the passed gmnd to the passed map
		/// </summary>
		/// <param name="gmnd">the GMND File</param>
		/// <param name="map">the Map Table (key=master subset name, value= ArrayList of slave subsets</param>
		public static void GetSlaveSubsets(SimPe.Plugin.GenericRcol gmnd, Hashtable map)
		{
			foreach (IRcolBlock irb in gmnd.Blocks) 
			{
				if (irb.BlockName == "cDataListExtension") 
				{
					DataListExtension dle = (DataListExtension)irb;
					if (dle.Extension.VarName.Trim().ToLower() == "tsdesignmodeslavesubsets") 
					{
						foreach (ExtensionItem ei in dle.Extension.Items) 
						{
							string[] slaves = ei.String.Split(",".ToCharArray());
							ArrayList slavelist = new ArrayList();
							foreach (string s in slaves) slavelist.Add(s.Trim().ToLower());

							map[ei.Name.Trim().ToLower()] = slavelist;
						}
					}
				}
			}
		}

		/// <summary>
		/// Will return a Hashtable (key = subset name) of ArrayLists (slave subset names)
		/// </summary>
		/// <returns>The Hashtable</returns>
		public Hashtable GetSlaveSubsets()
		{			
			Hashtable map = new Hashtable();
			foreach (SimPe.Plugin.GenericRcol gmnd in files) 
			{
				if (gmnd.FileDescriptor.Type == Data.MetaData.GMND) GetSlaveSubsets(gmnd, map);
			}
			return map;
		}

		/// <summary>
		/// Will return a Hashtable (key = subset name) of ArrayLists (slave subset names)
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns></returns>
		public static Hashtable GetSlaveSubsets(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			Hashtable map = new Hashtable();
			SimPe.Interfaces.Files.IPackedFileDescriptor[] gmnds = pkg.FindFiles(Data.MetaData.GMND);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in gmnds) 
			{
				SimPe.Plugin.GenericRcol gmnd = new GenericRcol(null, false);
				gmnd.ProcessData(pfd, pkg);

				GetSlaveSubsets(gmnd, map);
			}
			return map;
		}

		/// <summary>
		/// Return al Hashtable (subset) of Hashtable (family) of ArrayLists (mmat Files) specifiying all available Material Overrides
		/// </summary>
		/// <param name="pkg">The package you want to scan</param>
		/// <returns>The Hashtable</returns>
		public static Hashtable GetMMATMap(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg==null) return new Hashtable();

			SimPe.Interfaces.Files.IPackedFileDescriptor[] mmats = pkg.FindFiles(Data.MetaData.MMAT);
			Hashtable ht = new Hashtable();

			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in mmats) 
			{
				SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
				mmat.ProcessData(pfd, pkg);

				string subset = mmat.GetSaveItem("subsetName").StringValue.Trim().ToLower();
				string family = mmat.GetSaveItem("family").StringValue;

				//get the available families
				Hashtable families = null;
				if (!ht.ContainsKey(subset)) {
					families = new Hashtable();
					ht[subset] = families;
				} else families = (Hashtable)ht[subset];

				//get listing of the current Family
				ArrayList list = null;
				if (!families.ContainsKey(family)) 
				{
					list = new ArrayList();
					families[family] = list;
				} else list = (ArrayList)families[family];

				//add the MMAT File
				list.Add(mmat);
			}

			return ht;
		}

		/// <summary>
		/// Create a package based on the collected Files
		/// </summary>
		/// <returns></returns>
		public SimPe.Packages.GeneratableFile BuildPackage()
		{
			SimPe.Packages.GeneratableFile pkg = SimPe.Packages.GeneratableFile.LoadFromFile("simpe_memory");
			BuildPackage(pkg);

			return pkg;
		}

		/// <summary>
		/// Create a package based on the collected Files
		/// </summary>
		/// <returns></returns>
		public void BuildPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			BuildPackage(files, pkg);
		}

		/// <summary>
		/// Create a package based on the collected Files
		/// </summary>
		/// <returns></returns>
		public static void BuildPackage(ArrayList files, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			foreach (SimPe.Plugin.GenericRcol rcol in files)
			{
				rcol.FileDescriptor = Clone(rcol.FileDescriptor);
				rcol.SynchronizeUserData();

				if (pkg.FindFile(rcol.FileDescriptor)==null)
					pkg.Add(rcol.FileDescriptor);
			}
		}

		/// <summary>
		/// Loads the ModelNames of the Objects referenced in all tsMaterialsMeshName Block
		/// </summary>
		/// <param name="pkg"></param>
		/// <param name="delete">true, if the tsMaterialsMeshName Blocks should get cleared</param>
		/// <returns>A List of Modelnames</returns>		
		public static string[] LoadParentModelNames(SimPe.Interfaces.Files.IPackageFile pkg, bool delete)
		{
			WaitingScreen.UpdateMessage("Loading Parent Modelnames");
			ArrayList list = new ArrayList();

			Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.GMND);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				Rcol rcol = new GenericRcol(null, false);
				rcol.ProcessData(pfd, pkg);

				foreach (IRcolBlock irb in rcol.Blocks) 
				{
					if (irb.BlockName.Trim().ToLower() == "cdatalistextension") 
					{
						DataListExtension dle = (DataListExtension)irb;
						if (dle.Extension.VarName.Trim().ToLower()=="tsmaterialsmeshname") 
						{
							foreach (ExtensionItem ei in dle.Extension.Items) 
							{
								string mname = ei.String.Trim().ToLower();
								if (mname.EndsWith("_cres")) mname+="_cres";

								if (!list.Contains(mname)) list.Add(mname);
							}

							dle.Extension.Items = new ExtensionItem[0];
							rcol.SynchronizeUserData();
							break;
						}
					}
				}
			}

			string[] ret = new string[list.Count];
			list.CopyTo(ret);

			return ret;
		}

		/// <summary>
		/// Load all pending Wallmask Files
		/// </summary>
		/// <param name="modelname"></param>
		/// <returns></returns>
		protected ArrayList LoadWallmask(string modelname)
		{
			ArrayList txmt = new ArrayList();

			//known types (based on a List created by Numenor)
			string[] list = { 
								"0_0_0_n",		//for all the straight doors/windows/arches
								"0_1s_0_s",		//for all the straight doors/windows/arches
								"1e_0_0_n",		//in addition to them, the 2-tile straight doors/windows/arches
								"1e_1s_0_s",	//in addition to them, the 2-tile straight doors/windows/arches
								"0_0_0_nw",		//all the diagonal doors/window/arches have
								"0_0_0_se",		//all the diagonal doors/window/arches have
								"1e_1n_0_nw",	// in addition to them, the 2-tile diagonals have
								"1e_1n_0_se"	// in addition to them, the 2-tile diagonals have
							};

			modelname =modelname.Trim().ToLower();
			if (modelname.EndsWith("_cres")) modelname = modelname.Substring(0, modelname.Length-5);
				
			foreach (string s in list)
			{
				string nmn = modelname + "_" + s + "_wallmask_txmt";

				Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(nmn, Data.MetaData.TXMT, Data.MetaData.LOCAL_GROUP, true);

				if (item!=null) txmt.Add(item);
			}

			return txmt;
		}

		/// <summary>
		/// Add Wallmasks (if available) to the Clone
		/// </summary>
		/// <param name="modelnames"></param>
		/// <remarks>based on Instructions By Numenor</remarks>
		public void AddWallmasks(string[] modelnames)
		{			
			foreach (string s in modelnames) 
			{
				ArrayList txmt = LoadWallmask(s);

				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in txmt) 
				{
					SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
					sub.ProcessData(item);
					LoadReferenced(this.modelnames, this.exclude, files, itemlist, sub, item, true);
				}
			}			
		}

		/// <summary>
		/// Load a ANIM Resource
		/// </summary>
		/// <param name="name"></param>
		/// <returns></returns>
		protected ArrayList LoadAnim(string name)
		{
			ArrayList anim = new ArrayList();
			
			name = name.Trim().ToLower();
			if (!name.EndsWith("_anim")) name += "_anim";
				
			Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(name, Data.MetaData.ANIM, Data.MetaData.LOCAL_GROUP, true);
			if (item!=null) anim.Add(item);			

			return anim;
		}

		/// <summary>
		/// Add Anim Resources (if available) to the Clone
		/// </summary>
		/// <param name="names"></param>
		public void AddAnims(string[] names)
		{			
			foreach (string s in names) 
			{
				ArrayList anim = LoadAnim(s);

				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in anim) 
				{
					SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
					sub.ProcessData(item);
					LoadReferenced(this.modelnames, this.exclude, files, itemlist, sub, item, true);
				}
			}			
		}
		

		/// <summary>
		/// Add Resources referenced from 3IDR Files
		/// </summary>
		/// <param name="names"></param>
		public void AddFrom3IDR(SimPe.Interfaces.Files.IPackageFile pkg)
		{			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.REF_FILE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				SimPe.Plugin.RefFile re = new RefFile();
				re.ProcessData(pfd, pkg);				

				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor p in re.Items) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(p);
					foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
					{
						try 
						{
							SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
							sub.ProcessData(item);
							LoadReferenced(this.modelnames, this.exclude, files, itemlist, sub, item, true);
						} 
						catch (Exception ex)
						{
							if (Helper.DebugMode) 
								Helper.ExceptionMessage("", ex);
						}
					}
				}
				
			}			
		}
	}
}
