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
using Microsoft.Win32;
using System.Collections;
using System.IO;
using System.Xml;


namespace SimPe
{
	/// <summary>
	/// Handles Application Settings tored in the Registry
	/// </summary>
	public class Registry
	{
		///Number of Recent Files stored in the Reg
		public const byte RECENT_COUNT = 15;
		/// <summary>
		/// The Root Registry Kex for this Application
		/// </summary>
		private RegistryKey rk;

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public Registry()
		{
			rk = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\Ambertation\\SimPe");
		}

		/// <summary>
		/// Returns the Registry Key you can use to store Optional Plugin Data
		/// </summary>
		public RegistryKey PluginRegistryKey
		{
			get 
			{
				return rk.CreateSubKey("PluginSettings");
			}
		}

		/// <summary>
		/// Returns the Base Registry Key
		/// </summary>
		public RegistryKey RegistryKey
		{
			get 
			{
				return rk;
			}
		}

		/// <summary>
		/// true, if the user wants the Pescado Mode
		/// </summary>
		public  bool Silent
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("PescadoMode");
				if (o==null) return false;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("PescadoMode", value);
			}
		}

		/// <summary>
		/// true, if user wants to activate the Cache
		/// </summary>
		public  bool UseCache
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("UseCache");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("UseCache", value);
			}
		}

		/// <summary>
		/// true, if user wants to activate the Cache
		/// </summary>
		public  bool XPStyle
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("XPStyle");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("XPStyle", value);
			}
		}

		/// <summary>
		/// true, if the user wanted to use the HexViewer
		/// </summary>
		public  bool HexViewState 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("HexViewEnabled");
				if (o==null) return false;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("HexViewEnabled", value);
			}
		}

		/// <summary>
		/// true, if the HiddenMode is activated
		/// </summary>
		public bool HiddenMode
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("EnableSimPEHiddenMode");
				if (o==null) return false;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("EnableSimPEHiddenMode", value);
			}
		}

		/// <summary>
		/// true, if the user wanted to decode Filenames
		/// </summary>
		public  bool DecodeFilenamesState 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("DecodeFilenames");
				if (o==null) return false;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("DecodeFilenames", value);
			}
		}

		/// <summary>
		/// GUID Username
		/// </summary>
		public string Username
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("Username");
				if (o==null) return "";
				else return o.ToString();
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("Username", value);
			}
		}

		/// <summary>
		/// Update the SimPE paths
		/// </summary>
		public void UpdateSimPEDirectory()
		{
			RegistryKey rkf = rk.CreateSubKey("Settings");
			rkf.SetValue("Path", Helper.SimPePath);
			rkf.SetValue("DataPath", Helper.SimPeDataPath);
			rkf.SetValue("PluginPath", Helper.SimPePluginPath);
		}

		/// <summary>
		/// GUID Username
		/// </summary>
		public Data.MetaData.Languages LanguageCode
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("Language");
				if (o==null) return Helper.GetMatchingLanguage();
				else return (Data.MetaData.Languages)Convert.ToByte(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("Language", (byte)value);
			}
		}

		/// <summary>
		/// GUID Password
		/// </summary>
		public string Password
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("Password");
				if (o==null) return "";
				else return o.ToString();
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("Password", value);
			}
		}

		/// <summary>
		/// The Version that was executed last Time SimPE was started
		/// </summary>
		public int Version
		{
			get 
			{
				try 
				{
					RegistryKey rkf = rk.CreateSubKey("Settings");
					object o = rkf.GetValue("Version");
					if (o==null) return 0;
					else return (int)o;
				} 
				catch (Exception) 
				{
					return 0;
				}
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("Version", value);
			}
		}

		/// <summary>
		/// Returns the Location of the Personal Folder
		/// </summary>
		protected string PersonalFolder 
		{
			get 
			{
				return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			}
		}

		/// <summary>
		/// Returns the Real Instalation Folder
		/// </summary>
		public string RealGamePath 
		{
			get 
			{
				try 
				{
					RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\EA Games\\The Sims 2");
					object o = rk.GetValue("Install Dir");
					if (o==null) return "";
					else return o.ToString();
				} 
				catch (Exception) 
				{
					return "";
				}
			}
		}

		/// <summary>
		/// Returns the Real Instalation Folder
		/// </summary>
		public string RealEP1GamePath 
		{
			get 
			{
				try 
				{
					RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\EA Games\\The Sims 2 University");
					object o = rk.GetValue("Install Dir");
					if (o==null) return "";
					else return o.ToString();
				} 
				catch (Exception) 
				{
					return "";
				}
			}
		}

		/// <summary>
		/// Returns the highest number of installed EPs
		/// </summary>
		public int EPInstalled
		{
			get 
			{
				try 
				{
					RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\EA Games\\The Sims 2");
					object o = rk.GetValue("EPsInstalled");
					if (o==null) return 0;
					else return 1; //Sims2EP1.exe
				} 
				catch (Exception) 
				{
					return 0;
				}
			}
		}

		public string RealSavegamePath
		{
			get 
			{
				try 
				{
					string path = System.IO.Path.Combine(this.PersonalFolder, "EA Games");
					path = System.IO.Path.Combine(path, this.DisplayedName);
					return path;
				} 
				catch (Exception) 
				{
					return "";
				}
			}
		}

		/// <summary>
		/// Returns the Displayed Sims 2 name
		/// </summary>
		protected string DisplayedName 
		{
			get 
			{
				try 
				{
					RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("Software\\EA Games\\The Sims 2");
					object o = rk.GetValue("DisplayName");
					if (o==null) return "The Sims 2";
					else return o.ToString();
				} 
				catch (Exception) 
				{
					return "The Sims 2";
				}
			}
		}

		/// <summary>
		/// Name of the Nvidia DDS Path
		/// </summary>
		public string NvidiaDDSPath
		{
			get 
			{
				try 
				{
					RegistryKey rkf = rk.CreateSubKey("Settings");
					object o = rkf.GetValue("NvidiaDDS");
					if (o==null) return "";
					return o.ToString();
				} 
				catch (Exception) 
				{
					return "";
				}
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("NvidiaDDS", value);
			}
		}

		/// <summary>
		/// The location of theNvidia Tool
		/// </summary>
		public string NvidiaDDSTool 
		{
			get 
			{
				return System.IO.Path.Combine(NvidiaDDSPath, "nvdxt.exe");
			}
		}

		/// <summary>
		/// Name of the Sims Application
		/// </summary>
		public string SimsPath
		{
			get 
			{
				try 
				{
					RegistryKey rkf = rk.CreateSubKey("Settings");
					object o = rkf.GetValue("SimsPath");
					if (o==null) o = rkf.GetValue("SimsApplication");	//this key is obsolete!
					if (o==null) return RealGamePath;
					else 
					{
						string fl = o.ToString().Trim().ToLower();
						if (fl.EndsWith(".exe")) 
						{
							fl = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(fl), "..");
						}
						return fl;
					}
				} 
				catch (Exception) 
				{
					return "";
				}
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("SimsPath", value);
			}
		}

		/// <summary>
		/// Name of the Sims Application
		/// </summary>
		public string SimsEP1Path
		{
			get 
			{
				/*try 
				{
					RegistryKey rkf = rk.CreateSubKey("Settings");
					object o = rkf.GetValue("SimsEP1Path");
					if (o==null) return this.RealEP1GamePath;
					else 
					{
						string fl = o.ToString().Trim().ToLower();
						return fl;
					}
				} 
				catch (Exception) 
				{
					return "";
				}*/
				return this.RealEP1GamePath;
			}
			set
			{
				/*RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("SimsEP1Path", value);*/
			}
		}

		/// <summary>
		/// Name of the Sims Application
		/// </summary>
		public string SimsApplication
		{
			get 
			{
				try 
				{
					if (this.EPInstalled==1) return System.IO.Path.Combine(this.SimsEP1Path, "TSBin\\Sims2EP1.exe");
					else return System.IO.Path.Combine(this.SimsPath, "TSBin\\Sims2.exe");					
				} 
				catch (Exception) 
				{
					return "";
				}
			}
			
		}

		public string SimSavegameFolder 
		{
			get 
			{
				try 
				{
					RegistryKey rkf = rk.CreateSubKey("Settings");
					object o = rkf.GetValue("SavegamePath");
					if (o==null) 
					{
						return this.RealSavegamePath;
					}
					else 
					{
						return o.ToString();
					}
				} 
				catch (Exception) 
				{
					return "";
				}
			}
			set 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("SavegamePath", value);
			}
		}

		/// <summary>
		/// returns the Fodler where the users Neighborhood is stored
		/// </summary>
		public string NeighborhoodFolder 
		{
			get 
			{
				try 
				{
					return System.IO.Path.Combine(this.SimSavegameFolder, "Neighborhoods");
				} 
				catch (Exception) 
				{
					return "";
				}
			}
		}

		/// <summary>
		/// returns the Fodler where the Backups are stored
		/// </summary>
		public string BackupFolder 
		{
			get 
			{
				try 
				{
					return System.IO.Path.Combine(System.IO.Path.Combine(this.PersonalFolder, "EA Games"), "SimPE Backup");
				} 
				catch (Exception) 
				{
					return "";
				}
			}
		}

		/// <summary>
		/// Store a List of known Memory Groups (can be null)
		/// </summary>
		public ArrayList MemoryGroups
		{
			get 
			{
				ArrayList list = new ArrayList();
				if (File.Exists(System.IO.Path.Combine(Helper.SimPeDataPath, "data001.xml")))
				{					
					System.Xml.XmlDocument xmlfile = new XmlDocument();
					xmlfile.Load(System.IO.Path.Combine(Helper.SimPeDataPath, "data001.xml"));

					//seek Root Node
					XmlNodeList XMLData = xmlfile.GetElementsByTagName("memory");					

					//Process all Root Node Entries
					for (int i=0; i<XMLData.Count; i++)
					{
						XmlNode node = XMLData.Item(i);																
												
						foreach (XmlNode subnode in node) 
						{
							if (subnode.LocalName == "item") 
							{
								object[] o = new object[2];
								o[0] = Convert.ToUInt32(subnode.Attributes["value"].Value);
								o[1] = subnode.InnerText;
								list.Add(o);
							}
						}
					}//for i
				} 
				return list;
			}
			set 
			{
				StreamWriter sw = System.IO.File.CreateText(System.IO.Path.Combine(Helper.SimPeDataPath, "data001.xml"));
				try 
				{
					sw.BaseStream.SetLength(0);
					sw.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
					sw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
					sw.WriteLine("<memory>");
					foreach (object[] o in value) sw.WriteLine("<item value=\""+o[0].ToString()+"\">"+o[1].ToString().Replace(">", "&gt;").Replace("<", "&lt;").Replace("&", "&amp;")+"</item>");
					sw.WriteLine("</memory>");
				} 
				finally 
				{
					sw.Close();
				}
			}
		}

		/// <summary>
		/// true, if the user wanted to use the HexViewer
		/// </summary>
		public bool LoadMetaInfo 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("LoadMetaInfos");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("LoadMetaInfos", value);
			}
		}

		/// <summary>
		/// true, if the user want's to start the Game with Sound
		/// </summary>
		public bool EnableSound 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("EnableSound");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("EnableSound", value);
			}
		}

		/// <summary>
		/// Returns the Priority for the Wrapper identified with the given UID
		/// </summary>
		/// <param name="uid">uique id of the Wrapper</param>
		/// <returns>Priority for the Wrapper</returns>
		public int GetWrapperPriority(ulong uid)
		{
			RegistryKey rkf = rk.CreateSubKey("Priorities");
			object o = rkf.GetValue(Helper.HexString(uid));
			if (o==null) return 0x00000000;
			else return Convert.ToInt32(o);
		}

		/// <summary>
		/// Stores the Priority of a Wrapper
		/// </summary>
		/// <param name="uid">uique id of the Wrapper</param>
		/// <param name="priority">the new Priority</param>
		public void SetWrapperPriority(ulong uid, int priority) 
		{
			RegistryKey rkf = rk.CreateSubKey("Priorities");
			rkf.SetValue(Helper.HexString(uid), priority);
		}

		/// <summary>
		/// Returns a List of recently opened Files
		/// </summary>
		/// <returns>List of Filenames</returns>
		public string[] GetRecentFiles() 
		{
			RegistryKey rkf = rk.CreateSubKey("RecentFiles");
			string[] names = rkf.GetValueNames();

			
			ArrayList list = new ArrayList();
			foreach (string name in names) 
			{
				object file = rkf.GetValue(name);
				if (file==null) file="";
				list.Add(file);				
			}

			string[] res = new string[list.Count];
			list.CopyTo(res);
			return res;
		}

		/// <summary>
		/// Adds a File to the List of recently opened Files
		/// </summary>
		/// <param name="filename">The Filename</param>
		public void AddRecentFile(string filename) 
		{
			if (filename==null) return;
			if (filename.Trim()=="") return;
			if (!System.IO.File.Exists(filename)) return;

			RegistryKey rkf = rk.CreateSubKey("RecentFiles");
			string[] names = rkf.GetValueNames();			
			rkf = rk.OpenSubKey("RecentFiles", true);
			

			if (names.Length==0) 
			{
				rkf.SetValue("0", filename);
			} 
			else 
			{
				uint ct = 0;
				string last = filename;
				string next = "";
				foreach (string name in names) 
				{
					object file = rkf.GetValue(name);
					if (file==null) file="";
				
					object o = rkf.GetValue(ct.ToString());
					if (o!=null) next = o.ToString();
					else next = "";

					rkf.SetValue(ct.ToString(), last);
					ct++;
					last = next;
					if (next==filename) break;

					if (ct>=RECENT_COUNT) return;
				}

				if (ct==0) rkf.SetValue(ct.ToString(), last);
				else if ((last!=filename) && (ct<RECENT_COUNT)) rkf.SetValue(ct.ToString(), last);
			}
		}

		/// <summary>
		/// Returns the Name of the Startup Cheat File
		/// </summary>
		public string StartupCheatFile 
		{
			get 
			{
				return System.IO.Path.Combine(this.SimSavegameFolder, "Config\\userStartup.cheat");
			}
		}


		/// <summary>
		/// Returns true if the Game will start in Debug Mode
		/// </summary>
		public bool GameDebug 
		{
			get 
			{
				if (!System.IO.File.Exists(this.StartupCheatFile)) return false;

				try 
				{
					System.IO.TextReader fs = System.IO.File.OpenText(this.StartupCheatFile);
					string cont = fs.ReadToEnd();
					fs.Close();
					string[] lines = cont.Split("\n".ToCharArray());

					foreach (string line in lines) 
					{
						string pline = line.ToLower().Trim();
						while (pline.IndexOf("  ")!=-1) pline = pline.Replace("  ", " ");
						string[] tokens = pline.Split(" ".ToCharArray());

						if (tokens.Length==3) 
						{
							if ( (tokens[0]=="boolprop") &&
								(tokens[1]=="testingcheatsenabled") &&
								(tokens[2]=="true") 
								) return true;
						}
					}
				} 
				catch (Exception) {}

				return false;
			}

			set 
			{
				if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(this.StartupCheatFile))) return;

				try 
				{
					string newcont = "";
					bool found = false;
					if (System.IO.File.Exists(this.StartupCheatFile)) 
					{
						System.IO.TextReader fs = System.IO.File.OpenText(this.StartupCheatFile);
						string cont = fs.ReadToEnd();
						fs.Close();
						
						string[] lines = cont.Split("\n".ToCharArray());
						

						foreach (string line in lines) 
						{
							string pline = line.ToLower().Trim();
							while (pline.IndexOf("  ")!=-1) pline = pline.Replace("  ", " ");
							string[] tokens = pline.Split(" ".ToCharArray());

							if (tokens.Length==3) 
							{
								if ( (tokens[0]=="boolprop") &&
									(tokens[1]=="testingcheatsenabled") 
									) 
								{
									if (!found) 
									{
										newcont += "boolProp testingCheatsEnabled ";
										if (value) newcont += "true"; else newcont += "false";
										newcont += Helper.lbr;
										found = true;
									}
									continue;
								}
							}
							newcont += line.Trim();
							newcont += Helper.lbr;
						}

						System.IO.File.Delete(this.StartupCheatFile);
					}

					if (!found) 
					{
						newcont += "boolProp testingCheatsEnabled ";
						if (value) newcont += "true"; else newcont += "false";
						newcont += Helper.lbr;
					}

					System.IO.TextWriter fw = System.IO.File.CreateText(this.StartupCheatFile);
					fw.Write(newcont.Trim());
					fw.Close();
				} 
				catch (Exception) {}
			}
		}

		/// <summary>
		/// Returns true if the Game will start in Debug Mode
		/// </summary>
		public bool BlurNudity 
		{
			get 
			{
				if (!System.IO.File.Exists(this.StartupCheatFile)) return true;

				try 
				{
					System.IO.TextReader fs = System.IO.File.OpenText(this.StartupCheatFile);
					string cont = fs.ReadToEnd();
					fs.Close();
					string[] lines = cont.Split("\n".ToCharArray());

					foreach (string line in lines) 
					{
						string pline = line.ToLower().Trim();
						while (pline.IndexOf("  ")!=-1) pline = pline.Replace("  ", " ");
						string[] tokens = pline.Split(" ".ToCharArray());

						if (tokens.Length==3) 
						{
							if ( (tokens[0]=="intprop") &&
								(tokens[1]=="censorgridsize") 
								) return (Convert.ToInt32(tokens[2])!=0);
						}
					}
				} 
				catch (Exception) {}

				return true;
			}

			set 
			{
				if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(this.StartupCheatFile))) return;

				try 
				{
					string newcont = "";
					bool found = false;
					if (System.IO.File.Exists(this.StartupCheatFile)) 
					{
						System.IO.TextReader fs = System.IO.File.OpenText(this.StartupCheatFile);
						string cont = fs.ReadToEnd();
						fs.Close();
						
						string[] lines = cont.Split("\n".ToCharArray());
						

						foreach (string line in lines) 
						{
							string pline = line.ToLower().Trim();
							while (pline.IndexOf("  ")!=-1) pline = pline.Replace("  ", " ");
							string[] tokens = pline.Split(" ".ToCharArray());

							if (tokens.Length==3) 
							{
								if ( (tokens[0]=="intprop") &&
									(tokens[1]=="censorgridsize") 
									) 
								{
									if (!found) 
									{
										if (!value) 
										{
											newcont += "intprop censorgridsize 0";
											newcont += Helper.lbr;
										}
										found = true;
									}
									continue;
								}
							}
							newcont += line.Trim();
							newcont += Helper.lbr;
						}

						System.IO.File.Delete(this.StartupCheatFile);
					}

					if (!found) 
					{
						if (!value) 
						{
							newcont += "intprop censorgridsize 0";
							newcont += Helper.lbr;
						}
					}

					System.IO.TextWriter fw = System.IO.File.CreateText(this.StartupCheatFile);
					fw.Write(newcont.Trim());
					fw.Close();
				} 
				catch (Exception) {}
			}
		}

		/// <summary>
		/// true, if the user wanted to use the HexViewer
		/// </summary>
		public bool AutoBackup 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("AutoBackup");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("AutoBackup", value);
			}
		}

		/// <summary>
		/// true, if the user wants the Waiting Screen
		/// </summary>
		public bool WaitingScreen 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("WaitingScreen");
				if (o==null) return true;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("WaitingScreen", value);
			}
		}

		/// <summary>
		/// true, if the user wants the Waiting Screen
		/// </summary>
		public bool LoadOWFast 
		{
			get 
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				object o = rkf.GetValue("LoadOWFast");
				if (o==null) return false;
				else return Convert.ToBoolean(o);
			}
			set
			{
				RegistryKey rkf = rk.CreateSubKey("Settings");
				rkf.SetValue("LoadOWFast", value);
			}
		}
	}
}
