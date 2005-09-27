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
		EP2GameFolder = 0x7
	}
	/// <summary>
	/// The type and location of a Folder/file
	/// </summary>
	public class FileTableItem
	{
		bool recursive;
		bool file;
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
		}

		public FileTableItem( string relpath, bool rec, bool fl) : this (relpath, rec, fl, -1)
		{
		}
		public FileTableItem( string relpath, bool rec, bool fl, int ver) 
		{			
			
			this.recursive = rec;
			this.file = fl;
			this.ver = ver;
			this.type = FileTableItemType.Absolute;
			this.SetName(relpath);
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
			else if (type==FileTableItemType.GameFolder) ret = Helper.WindowsRegistry.SimsPath;
			else if (type==FileTableItemType.SaveGameFolder) ret = Helper.WindowsRegistry.SimSavegameFolder;
			else if (type==FileTableItemType.SimPEDataFolder) ret = Helper.SimPeDataPath;
			else if (type==FileTableItemType.SimPEFolder) ret = Helper.SimPePath;
			else if (type==FileTableItemType.SimPEPluginFolder) ret = Helper.SimPePluginPath;

			if (!ret.EndsWith(@"\")) ret+=@"\";

			return ret;
		}

		bool CutName(string name, FileTableItemType type)
		{
			if (!System.IO.Path.IsPathRooted(name)) return false;

			string root = GetRoot(type);
			if (root==null) return false;
			root = Helper.ToLongPathName(root).Trim().ToLower();

			if (name.StartsWith(root))
			{
				this.path = name.Replace(root, "");
				this.Type = type;				
				return true;
			} 

			return false;
		}

		internal void SetName(string name) 
		{
			string n = Helper.ToLongPathName(name).Trim().ToLower();
			if (CutName(n, FileTableItemType.GameFolder)) return;
			if (CutName(n, FileTableItemType.EP1GameFolder)) return;
			if (CutName(n, FileTableItemType.EP2GameFolder)) return;
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
				if (p.StartsWith(@"\")) p = path.Substring(1);
				return System.IO.Path.Combine(r, p);
			}
			set { SetName(value); }
		}

		public string RelativePath 
		{
			get { return path; }
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
				files[0] = path;
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
							
									FileTableItem fti = new FileTableItem(name, false, false);
									
									
									#region add Path Root if needed
									foreach (XmlAttribute a in foldernode.Attributes) 
									{
										if (a.Name=="recursive") 
										{
											if (a.Value != "0") fti.SetRecursive(true);
										}

										if (a.Name=="epversion") 
										{
											try 
											{
												int ver = Convert.ToInt32(a.Value);
												fti.EpVersion = ver;
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
													fti.Type = FileTableItemType.GameFolder;
													break;
												}
												case "ep1":
												{
													root = Helper.WindowsRegistry.SimsEP1Path;
													fti.Type = FileTableItemType.EP1GameFolder;
													break;
												}
												case "ep2":
												{
													root = Helper.WindowsRegistry.SimsEP2Path;
													fti.Type = FileTableItemType.EP2GameFolder;
													break;
												}
												case "save":
												{
													root = Helper.WindowsRegistry.SimSavegameFolder;
													fti.Type = FileTableItemType.SaveGameFolder;
													break;
												}
												case "simpe":
												{
													root = Helper.SimPePath;
													fti.Type = FileTableItemType.SimPEFolder;
													break;
												}
												case "simpeData":
												{
													root = Helper.SimPeDataPath;
													fti.Type = FileTableItemType.SimPEDataFolder;
													break;
												}
												case "simpePlugin":
												{
													root = Helper.SimPePluginPath;
													fti.Type = FileTableItemType.SimPEPluginFolder;
													break;
												}
											}//switch

											name = System.IO.Path.Combine(root, name);
										}
									} //foreach

									fti.SetName(name);
									if (foldernode.Name == "file") fti.SetFile(true);
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
		protected static void BuildFolderXml()
		{
			try 
			{
				System.IO.TextWriter tw = System.IO.File.CreateText(FolderFile);

				try 
				{
					tw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
					tw.WriteLine("<folders>");
					tw.WriteLine("  <filetable>");
					tw.WriteLine("    <file root=\"save\">Downloads\\_EnableColorOptionsGMND.package</file>");
					tw.WriteLine("    <path root=\"ep2\" epversion=\"2\">TSData\\Res\\Objects</path>");					
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\3D</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\Catalog\\Materials</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\Catalog\\Skins</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\Catalog\\Patterns</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\Wants</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData\\Res\\UI</path>");
					tw.WriteLine("    <path root=\"ep1\" epversion=\"1\">TSData\\Res\\Objects</path>");					
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\3D</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\Catalog\\Materials</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\Catalog\\Skins</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\Catalog\\Patterns</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\Wants</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData\\Res\\UI</path>");
					tw.WriteLine("    <path root=\"game\" epversion=\"0\">TSData\\Res\\Objects</path>");
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\Sims3D</path>");
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\Catalog\\Materials</path>");
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\Catalog\\Skins</path>");
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\Catalog\\Patterns</path>");
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\Wants</path>");					
					tw.WriteLine("    <path root=\"game\">TSData\\Res\\UI</path>");
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
