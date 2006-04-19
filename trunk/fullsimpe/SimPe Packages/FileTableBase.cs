using System;
using System.Collections;
using System.Xml;
using SimPe.Interfaces.Wrapper;

namespace SimPe
{	
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

										if (a.Name=="version" || a.Name=="epversion" ) 
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
												case "sp1":
												 {
													 root = Helper.WindowsRegistry.SimsSP1Path;
													 ftitype = FileTableItemType.SP1GameFolder;
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
					tw.WriteLine("    <path root=\"sp1\" version=\"4\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"sp1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"ep3\" version=\"3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep3\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"ep2\" version=\"2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep2\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"ep1\" version=\"1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");					
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"3D</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Materials</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Skins</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Patterns</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"CANHObjects</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Wants</path>");
					tw.WriteLine("    <path root=\"ep1\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"UI</path>");
					tw.WriteLine("    <path root=\"game\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Catalog"+Helper.PATH_SEP+"Bins</path>");
					tw.WriteLine("    <path root=\"game\" version=\"0\">TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects</path>");
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
