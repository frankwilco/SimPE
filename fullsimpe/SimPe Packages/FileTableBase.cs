using System;
using System.Collections;
using System.Xml;
using SimPe.Interfaces.Wrapper;

namespace SimPe
{

	public enum FileTableItemType 
	{
		Absolute = 0x0,
		GameFolder = 0x1,
		EP1GameFolder = 0x2,
		SaveGameFolder = 0x3,
		SimPEFolder = 0x4,
		SimPEDataFolder = 0x5,
		SimPEPluginFolder = 0x6,
		EP2GameFolder = 0x7,
		EP3GameFolder = 0x8
	}
	/// <summary>
	/// The type and location of a Folder/file
	/// </summary>
	public class FileTableItem
	{
		bool recursive;
		bool file;
		bool ignore;
		int ver;
		string relpath;
		string path;
		FileTableItemType type;

		public FileTableItem(string path) 
		{
			recursive = false;
			file = false;
			if (path.StartsWith(":")) 
			{
				path = path.Substring(1, path.Length-1);
				recursive = true;
			} 
			else if (path.StartsWith("*")) 
			{
				path = path.Substring(1, path.Length-1);
				file = true;
			}

			this.path = path;
			this.relpath = path;
			this.ver = -1;
			this.type = FileTableItemType.Absolute;
			this.ignore = false;
		}

		public bool Ignore
		{
			get {return ignore;}
			set {ignore = value;}
		}

		public FileTableItem(string path, bool rec, bool fl) : this (path, rec, fl, -1, false)
		{
		}
		public FileTableItem(string path, bool rec, bool fl, int ver) : this (path, rec, fl, ver, false)
		{
		}

		public FileTableItem(string path, bool rec, bool fl, int ver, bool ign) : this(path, FileTableItemType.Absolute, rec, fl, ver, ign)
		{
		}

		public FileTableItem(string relpath, FileTableItemType type, bool rec, bool fl, int ver, bool ign) 
		{						
			this.recursive = rec;
			this.file = fl;
			this.ver = ver;
			this.type = type;
			this.SetName(relpath);
			this.ignore = ign;
		}		

		internal void SetRecursive(bool state) 
		{
			this.recursive = state;
		}

		internal void SetFile(bool state) 
		{
			this.file = state;
		}

		public static string GetRoot(FileTableItemType type)
		{
			string ret = null;
			if (type==FileTableItemType.EP1GameFolder) ret = Helper.WindowsRegistry.SimsEP1Path;
			else if (type==FileTableItemType.EP2GameFolder) ret = Helper.WindowsRegistry.SimsEP2Path;
			else if (type==FileTableItemType.EP3GameFolder) ret = Helper.WindowsRegistry.SimsEP3Path;
			else if (type==FileTableItemType.GameFolder) ret = Helper.WindowsRegistry.SimsPath;
			else if (type==FileTableItemType.SaveGameFolder) ret = Helper.WindowsRegistry.SimSavegameFolder;
			else if (type==FileTableItemType.SimPEDataFolder) ret = Helper.SimPeDataPath;
			else if (type==FileTableItemType.SimPEFolder) ret = Helper.SimPePath;
			else if (type==FileTableItemType.SimPEPluginFolder) ret = Helper.SimPePluginPath;

			if (ret!=null)
				if (!ret.EndsWith(Helper.PATH_SEP)) ret += Helper.PATH_SEP;

			if (ret==Helper.PATH_SEP) ret=null;
			return ret;
		}

		public static int GetEPVersion(FileTableItemType type)
		{
			if (type==FileTableItemType.EP1GameFolder) return 1;
			else if (type==FileTableItemType.EP2GameFolder) return 2;
			else if (type==FileTableItemType.EP3GameFolder) return 3;
			else if (type==FileTableItemType.GameFolder) return 0;
			
			return -1;
		}

		bool CutName(string name, FileTableItemType type)
		{
			try 
			{
				if (System.IO.Directory.Exists(name)) 
					if (!Helper.IsAbsolutePath(name)) return false;
			} 
#if DEBUG
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}

#else
			catch {}
#endif

			string root = GetRoot(type);
			if (root==null || root=="" || root==Helper.PATH_SEP) return false;

			root = Helper.ToLongPathName(root).Trim().ToLower();
			if (!root.EndsWith(Helper.PATH_SEP)) root+=Helper.PATH_SEP;

			string ename = name.Trim().ToLower();
			if (!ename.EndsWith(Helper.PATH_SEP)) ename+=Helper.PATH_SEP;

			if (ename.StartsWith(root))
			{
				this.path = ename.Replace(root, "");
				if (!this.IsFile)
					if (this.path.StartsWith(Helper.PATH_SEP)) path = path.Substring(1);
				this.Type = type;				
				return true;
			} 

			return false;
		}

		internal void SetName(string name) 
		{
			string n = name;

			if (Helper.IsAbsolutePath(name)) name = Helper.ToLongPathName(name).Trim().ToLower();

			if (CutName(n, FileTableItemType.GameFolder)) return;
			if (CutName(n, FileTableItemType.EP1GameFolder)) return;
			if (CutName(n, FileTableItemType.EP2GameFolder)) return;
			if (CutName(n, FileTableItemType.EP3GameFolder)) return;
			if (CutName(n, FileTableItemType.SaveGameFolder)) return;
			if (CutName(n, FileTableItemType.SimPEDataFolder)) return;
			if (CutName(n, FileTableItemType.SimPEFolder)) return;
			if (CutName(n, FileTableItemType.SimPEPluginFolder)) return;
						
			this.path = name;	
		}

		public FileTableItemType Type 
		{
			get { return type; }
			set { this.type = value; }
		}

		public bool IsRecursive 
		{
			get { return recursive; }
			set { recursive = value; }
		}

		public bool IsFile
		{
			get { return file; }
			set { file = value; }
		}

		public bool IsUseable
		{
			get { return ver==-1 || ver==Helper.WindowsRegistry.EPInstalled; }			
		}

		public int EpVersion
		{
			get {return ver;}
			set {ver = value;}
		}

		public bool IsAvail
		{
			get 
			{
				if (!IsUseable) return false;

				if (IsFile) return System.IO.File.Exists(Name);
				else return System.IO.Directory.Exists(Name);
			}
		}

		public string Name 
		{
			get { 
				string r = GetRoot(this.type);

				if (r==null) return path; 
				
				string p = path.Trim();
				if (p.StartsWith(Helper.PATH_SEP)) p = path.Substring(1);
				string ret = System.IO.Path.Combine(r, p);

				if (this.IsFile)
					if (ret.EndsWith(Helper.PATH_SEP)) ret = ret.Substring(0, ret.Length-1);
				return ret;
			}
			set { SetName(value); }
		}

		public string RelativePath 
		{
			get { 
				if (this.IsFile)
					if (path.EndsWith(Helper.PATH_SEP)) path = path.Substring(0, path.Length-1);
				return path; 
			}
		}

		public string[] GetFiles()
		{
			string[] files;

			if (!IsUseable || !IsAvail) 
			{
				files = new string[0];
			} 
			else if (IsFile) 
			{
				files = new string[1];
				files[0] = this.Name;
			} 
			else 
			{
				string n = this.Name;
				if (System.IO.Directory.Exists(n))
					files = System.IO.Directory.GetFiles(n, "*.package");
				else files = new string[0];
			}

			return files;
		}

		public override string ToString()
		{
			string n = "";
			if (IsFile) n += "File: ";
			else if (IsRecursive) n += "RecursiveFolder: ";
			else n += "Folder: ";

			if (!IsUseable) n = "(Unused) "+n;
			else if (!IsAvail) n = "(Missing) "+n;
			n += "{"+type.ToString()+"}"+path;

			if (ver!=-1) n+= " (Only when GameVersion="+ver.ToString()+")";
			return n;
		}

	}

	/// <summary>
	/// Do not use this class direct, use <see cref="SimPe.FileTable"/> instead!
	/// </summary>
	public class FileTableBase
	{
		static Interfaces.Scenegraph.IScenegraphFileIndex fileindex;

		/// <summary>
		/// Returns the FileIndex
		/// </summary>
		/// <remarks>This will be initialized by the RCOL Factory</remarks>
		public static Interfaces.Scenegraph.IScenegraphFileIndex FileIndex
		{
			get { return fileindex; }
			set { fileindex = value; }
		}

		/// <summary>
		/// Returns the Filename for the Folder.xml File
		/// </summary>
		public static string FolderFile
		{
			get { return System.IO.Path.Combine(Helper.SimPeDataPath, "folders.xreg"); }
		}		

		/// <summary>
		/// Returns a List of all Folders the User want's to scan for Content
		/// </summary>
		public static ArrayList DefaultFolders
		{
			get 
			{
				if (!System.IO.File.Exists(FolderFile)) BuildFolderXml();

				try 
				{
					ArrayList folders = new ArrayList();

					//read XML File
					System.Xml.XmlDocument xmlfile = new XmlDocument();
					xmlfile.Load(FolderFile);

					//seek Root Node
					XmlNodeList XMLData = xmlfile.GetElementsByTagName("folders");					
#if MAC
					Console.WriteLine("Reading Folders from \""+FolderFile+"\".");
#endif
					//Process all Root Node Entries
					for (int i=0; i<XMLData.Count; i++)
					{
						XmlNode node = XMLData.Item(i);	
						foreach (XmlNode subnode in node) 
						{
							if (subnode.Name == "filetable")
							{
								foreach (XmlNode foldernode in subnode.ChildNodes) 
								{
									if (foldernode.Name != "path" && foldernode.Name != "file") continue;									
									string name = foldernode.InnerText.Trim();		
									int ftiver = -1;
									bool ftiignore = false;
									bool ftirec = false;
									FileTableItemType ftitype = FileTableItemType.Absolute;									
									
									
									
									#region add Path Root if needed
									foreach (XmlAttribute a in foldernode.Attributes) 
									{
										if (a.Name=="recursive") 
										{
											if (a.Value != "0") ftirec = true;
										}

										if (a.Name=="ignore") 
										{
											ftiignore = (a.Value != "0");
										}

										if (a.Name=="epversion") 
										{
											try 
											{
												int ver = Convert.ToInt32(a.Value);
												ftiver = ver;
											} 
											catch {}																				
										}

										if (a.Name=="root") 
										{
											string root = a.Value;
											switch (root) 
											{
												case "game":
												{
													root = Helper.WindowsRegistry.SimsPath;
													ftitype = FileTableItemType.GameFolder;
													break;
												}
												case "ep1":
												{
													root = Helper.WindowsRegistry.SimsEP1Path;
													ftitype = FileTableItemType.EP1GameFolder;
													break;
												}
												case "ep2":
												{
													root = Helper.WindowsRegistry.SimsEP2Path;
													ftitype = FileTableItemType.EP2GameFolder;
													break;
												}													
												case "ep3":
												{
													root = Helper.WindowsRegistry.SimsEP3Path;
													ftitype = FileTableItemType.EP3GameFolder;
													break;
												}
												case "save":
												{
													root = Helper.WindowsRegistry.SimSavegameFolder;
													ftitype = FileTableItemType.SaveGameFolder;
													break;
												}
												case "simpe":
												{
													root = Helper.SimPePath;
													ftitype = FileTableItemType.SimPEFolder;
													break;
												}
												case "simpeData":
												{
													root = Helper.SimPeDataPath;
													ftitype = FileTableItemType.SimPEDataFolder;
													break;
												}
												case "simpePlugin":
												{
													root = Helper.SimPePluginPath;
													ftitype = FileTableItemType.SimPEPluginFolder;
													break;
												}
											}//switch

											//name = System.IO.Path.Combine(root, name);
										}
									} //foreach


									FileTableItem fti;
									if (foldernode.Name == "file") fti = new FileTableItem(name, ftitype, false, true, ftiver, ftiignore);
									else  fti = new FileTableItem(name, ftitype, ftirec, false, ftiver, ftiignore);

#if MAC
									Console.WriteLine("    -> "+fti.Name);
#endif
									#endregion

									folders.Add(fti);
							
								} //foreach foldernode
							}
						} //foreach subnode
					}	 //for i
	
					return folders;
				}
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
					return new ArrayList();
				}
			}
		}

		/// <summary>
		/// Creates a default Folder xml
		/// </summary>
		public static void BuildFolderXml()
		{
			try 
			{
				System.IO.TextWriter tw = System.IO.File.CreateText(FolderFile);

				try 
				{
					tw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
					tw.WriteLine("<folders>");
					tw.WriteLine("  <filetable>");
					tw.WriteLine("    <file root=\"save\">Downloads"+Helper.PATH_SEP+"_EnableColorOptionsGMND.package</file>");
					tw.WriteLine("    <file root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Sims3D"+Helper.PATH_SEP+"_EnableColorOptionsMMAT.package</file>");
					tw.WriteLine("    <path root=\"ep3\" epversion=\"3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"ep2\" epversion=\"2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"ep1\" epversion=\"1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Bins</path>");
					tw.WriteLine("    <path root=\"game\" epversion=\"0\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Sims3D</path>");										
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");					
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("  </filetable>");
					tw.WriteLine("</folders>");

				} 
				finally 
				{
					tw.Close();
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to create default Folder File!", ex);
			}
		}

		static SimPe.Interfaces.IWrapperRegistry wreg;
		/// <summary>
		/// Returns/Sets a WrapperRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IWrapperRegistry WrapperRegistry
		{
			get { return wreg; }
			set { wreg = value;}
		}		

		static SimPe.Interfaces.IProviderRegistry preg;
		/// <summary>
		/// Returns/Sets a ProviderRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IProviderRegistry ProviderRegistry
		{
			get { return preg; }
			set { preg = value;}
		}
		
		static IGroupCache gc;
		/// <summary>
		/// Returns The Group Cache used to determin local Groups
		/// </summary>
		public static IGroupCache GroupCache 
		{
			get { return gc; }
			set { gc = value;}
		}		
	}
}
