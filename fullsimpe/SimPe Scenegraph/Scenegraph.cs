using System;
using System.Collections;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class builds the SceneGraph Chain based on a modelname
	/// </summary>
	public class Scenegraph
	{
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
		/// <param name="list">A List containing all pfd Files</param>
		/// <param name="itemlist">A List of all FileIndexItems already added</param>
		/// <param name="rcol">The Rcol File (Scenegraph Resource)</param>
		/// <param name="item">The Item that was used to load the rcol</param>
		/// <param name="recursive">true if you want to add all sub Rcols</param>
		protected void LoadReferenced(ArrayList list, ArrayList itemlist, SimPe.Plugin.GenericRcol rcol, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item, bool recursive) 
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
							SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
							sub.ProcessData(subitem.FileDescriptor, subitem.Package);
							if (recursive) LoadReferenced(list, itemlist, sub, subitem, true);
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
				sub.ProcessData(item.FileDescriptor, item.Package);
				LoadReferenced(files, itemlist, sub, item, true);
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
		/// Adds all know MMATs that reference one of the models;
		/// </summary>
		/// <param name="pkg"></param>
		/// <param name="onlydefault">true, if you only want to read default MMATS</param>
		/// <param name="subitems">true, if you also want to load MMAT Files that reference Files ouside the passed package</param>
		/// <param name="exception">true if you want to throw an exception when something goes wrong</param>
		/// <returns>List of all referenced GUIDs</returns>
		public void AddMaterialOverrides(SimPe.Interfaces.Files.IPackageFile pkg, bool onlydefault, bool subitems, bool exception)
		{			
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.MMAT, true);
			ArrayList itemlist = new ArrayList();
			ArrayList contentlist = new ArrayList();
			ArrayList defaultfam = new ArrayList();
			ArrayList guids = new ArrayList();

			//collect a list of Default Material Override family values first
			if (onlydefault) 
			{
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
					mmat.ProcessData(item.FileDescriptor, item.Package);					

					if (!mmat.GetSaveItem("defaultMaterial").BooleanValue) continue;
					defaultfam.Add(mmat.GetSaveItem("family").StringValue);
				}
			}

			//now do the real collect
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
			{
				if (!itemlist.Contains(item)) 
				{
					SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
					mmat.ProcessData(item.FileDescriptor, item.Package);					

					if (onlydefault && !defaultfam.Contains(mmat.GetSaveItem("family").StringValue)) continue;

					string name = mmat.GetSaveItem("modelName").StringValue.Trim().ToLower();
					if (this.modelnames.Contains(name)) 
					{
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
									SimPe.Plugin.GenericRcol sub = new GenericRcol(null, false);	
									sub.ProcessData(txmtitem.FileDescriptor, txmtitem.Package);
									ArrayList newfiles = new ArrayList();
									LoadReferenced(newfiles, itemlist, sub, txmtitem, true);
						
									BuildPackage(newfiles, pkg);
								} 
								else 
								{
									if (exception) throw new ScenegraphException("Invalid Scenegraph Link", new ScenegraphException("Unable to find Referenced File "+name+"_txmt.", mmat.FileDescriptor), mmat.FileDescriptor);
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
					}//if modelname						
					itemlist.Add(item);
				} // if itemlist
			}
		}

		/// <summary>
		/// Will return a List of all SubSets that can be recolored
		/// </summary>
		/// <param name="pkg"></param>
		/// <returns></returns>
		public static ArrayList GetRecolorableSubsets(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			ArrayList list = new ArrayList();
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
						if (dle.Extension.VarName.Trim().ToLower() == "tsdesignmodeenabled") 
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
			return map;
		}

		/// <summary>
		/// Return al Hashtable (subset) of Hashtable (family) of ArrayLists (mmat Files) specifiying all available Material Overrides
		/// </summary>
		/// <param name="pkg">The package you want to scan</param>
		/// <returns>The Hashtable</returns>
		public static Hashtable GetMMATMap(SimPe.Interfaces.Files.IPackageFile pkg)
		{
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
			SimPe.Packages.GeneratableFile pkg = new SimPe.Packages.GeneratableFile("simpe_memory");
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
	}
}
