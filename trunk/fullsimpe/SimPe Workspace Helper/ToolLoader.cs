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
using SimPe.Packages;
using System.Threading;
using System.Diagnostics;
using Microsoft.Win32;
using System.Collections;

namespace SimPe
{
	/// <summary>
	/// just a Little class with a shorter ToString output
	/// </summary>
	public class ToolLoaderListBoxItemExt : ToolLoaderItemExt 
	{
		public ToolLoaderListBoxItemExt(ToolLoaderItemExt tli) : base (tli.Name) 
		{
			name = tli.Name;
			filename = tli.FileName;
			arguments = tli.Attributes;
			type = tli.Type;
		}

		public override string ToString()
		{
			return Name;
		}

	}

	/// <summary>
	/// This class contains all Information neede for one ExternalTool
	/// </summary>
	public class ToolLoaderItemExt 
	{
		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="name">Name of this Tool</param>
		public ToolLoaderItemExt(string name)
		{
			this.name = name;
			filename = "";
			arguments = "{tempfile}";
			type = 0xffffffff;
		}

		protected string name;
		/// <summary>
		/// Returnsthe Name of a Plugin
		/// </summary>
		public string Name 
		{
			get { return name; }
		}

		protected string filename;
		/// <summary>
		/// Returns/sets the FileName of the External Application
		/// </summary>
		public string FileName 
		{
			get { return filename; }
			set { filename = value; }
		}

		/// <summary>
		/// Returns/sets the FileName of the External Application
		/// </summary>
		/// <remarks>the Palceholder {simple} will be replaced with the real Simpe Installation Path</remarks>
		public string RealFileName 
		{
			get { return filename.Replace("{simpe}", Helper.SimPePath); }
		}

		protected string arguments;
		/// <summary>
		/// Returns/sets the Arguments we have to send to the Application
		/// </summary>
		/// <remarks>use "{tempname}" as a Plcaeholder for the Filename simPe uses to store the Temporary File</remarks>
		public string Attributes 
		{
			get { return arguments; }
			set { arguments = value; }
		}

		protected uint type;
		/// <summary>
		/// Returns the Type of the Packged File this Application can be used with
		/// </summary>
		/// <remarks>0xfffffff for all Types</remarks>
		public uint Type 
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// saves the packed File
		/// </summary>
		/// <param name="filename"></param>
		/// <param name="dscfile"></param>
		public static void SavePackedFile(string filename, bool dscfile, SimPe.Packages.PackedFileDescriptor pfd, SimPe.Packages.GeneratableFile package)
		{
#if !DEBUG
			try 
#endif
			{
				pfd.Path = System.IO.Path.GetDirectoryName(filename);
				pfd.Path = ".\\";
				pfd.Filename = System.IO.Path.GetFileName(filename);
				package.SavePackedFile(filename, null, pfd, dscfile);
			}
#if !DEBUG
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile")+filename, ex);
			} 
#endif
		}

		/// <summary>
		/// Open a Packed File and add it to the package
		/// </summary>
		/// <param name="filename">Name of the File</param>
		/// <param name="pfd">Descriptor of the Target File</param>
		/// <param name="package">The package the Fille sould be added to</param>
		/// <returns>true if succesfull</returns>
		public static bool OpenPackedFile(string filename, ref Packages.PackedFileDescriptor pfd) 
		{			
			try 
			{
				try 
				{
					if (filename.ToLower().EndsWith(".xml")) 
					{
						pfd = XmlPackageReader.OpenExtractedPackedFile(filename);
						filename = System.IO.Path.Combine(pfd.Path, pfd.Filename);
					} 
					else 
					{
						string[] part = System.IO.Path.GetFileNameWithoutExtension(filename).Split("-".ToCharArray(), 4);
						try 
						{
							pfd.Type = Convert.ToUInt32(part[0].Trim(), 16);
							pfd.SubType = Convert.ToUInt32(part[1].Trim(), 16);
							pfd.Group = Convert.ToUInt32(part[2].Trim(), 16);
							pfd.Instance = Convert.ToUInt32(part[3].Trim(), 16);
						} 
						catch (Exception) {
							part = System.IO.Path.GetFileNameWithoutExtension(filename).Split("-".ToCharArray(), 5);

							try 
							{
								pfd.Type = Convert.ToUInt32(part[0].Trim(), 16);
								pfd.SubType = Convert.ToUInt32(part[2].Trim(), 16);
								pfd.Group = Convert.ToUInt32(part[3].Trim(), 16);
								pfd.Instance = Convert.ToUInt32(part[4].Trim(), 16);
							} 
							catch (Exception) 
							{}
						}

						try
						{
							part = System.IO.Path.GetDirectoryName(filename).Split("\\".ToCharArray());
							if (part.Length>0) 
							{
								string last = part[part.Length-1];
								part = last.Split("-".ToCharArray(), 2);
								pfd.Type = Convert.ToUInt32(part[0].Trim(), 16);
							}
						} 
						catch (Exception) {}

						
					}
				}
				catch (Exception) 
				{
				}
					
				System.IO.FileStream fs = System.IO.File.OpenRead(filename);			

				try 
				{														
					System.IO.BinaryReader mbr = new System.IO.BinaryReader(fs);
					byte[] data = new byte[mbr.BaseStream.Length];
					for (int i=0; i<data.Length; i++) data[i] = mbr.ReadByte();
					pfd.UserData = data;
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("err003").Replace("{0}", filename), ex);
					return false;
				}
				finally 
				{
					fs.Close();
					fs.Dispose();
					fs = null;
				}
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile")+" "+filename, ex);
				return false;
			}
			return true;
		}

		/// <summary>
		/// Starts the external Plugin
		/// </summary>
		/// <param name="pfd">File Descriptor of the Selected File</param>
		/// <param name="package">The package the File is stored in</param>
		public void Execute(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item) 
		{
			if (item==null) return;
			if (item.FileDescriptor==null) return;
			if (item.Package==null) return;

			string extfile = System.IO.Path.Combine(System.IO.Path.GetTempPath(), "simpe");			
			uint ct = 0;
			while (System.IO.File.Exists(extfile+Helper.HexString(ct)+".tmp")) ct++;
			extfile = extfile+Helper.HexString(ct)+".tmp";

			try 
			{
				SavePackedFile(extfile, false, (SimPe.Packages.PackedFileDescriptor)item.FileDescriptor, (SimPe.Packages.GeneratableFile)item.Package);
			
				Process p = new Process();
				p.StartInfo.FileName = RealFileName;
				p.StartInfo.Arguments = Attributes.Replace("{tempname}", "\""+extfile+"\"").Replace("{tempfile}", "\""+extfile+"\"");

				p.Start();

				p.WaitForExit();
				p.Close();

				SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor)item.FileDescriptor;
				OpenPackedFile(extfile, ref pfd);
				pfd.Filename = null;
				pfd.Path = null;
			} 
			finally 
			{
				try 
				{
					System.IO.File.Delete(extfile);
				} 
				catch (Exception) {}
			}
		}

		/// <summary>
		/// Remove the Registry Settings
		/// </summary>
		public void DeleteSettings() 
		{
			XmlRegistryKey rk = Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools");
			rk.DeleteSubKey(Helper.HexString(type)+"-"+name, false);
		}

		/// <summary>
		/// Put the Settings to the Registry
		/// </summary>
		public void SaveSettings() 
		{
			XmlRegistryKey rk = Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools");
			rk = rk.CreateSubKey(Helper.HexString(type)+"-"+name);

			rk.SetValue("name", Name);
			rk.SetValue("type", Type);
			rk.SetValue("filename", FileName);
			rk.SetValue("attributes", Attributes);
		}

		/// <summary>
		/// Retunrs the real Name
		/// </summary>
		/// <param name="regname">Name of the Registry SubKey</param>
		/// <returns></returns>
		public static string SplitName(string regname) 
		{
			string[] str = regname.Split("-".ToCharArray(), 2);
			if (str.Length>1) return str[1];
			else return Localization.Manager.GetString("Unknown");
		}

		/// <summary>
		/// Override
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name + " (0x"+Helper.HexString(type)+", "+FileName+" "+Attributes+")";
		}

	}

	/// <summary>
	/// This calass provides some Methods that can be used to handle external Tools
	/// </summary>
	public class ToolLoaderExt
	{
		static ToolLoaderItemExt[] items;

		/// <summary>
		/// List of all available Items
		/// </summary>
		public static ToolLoaderItemExt[] Items 
		{
			get { if (items==null) Load(); return items; }
			set { items = value; }
		}


		/// <summary>
		/// Add the Passed item
		/// </summary>
		/// <param name="tli"></param>
		public static void Add(ToolLoaderItemExt tli) 
		{
			if (items==null) Load();
			items = (ToolLoaderItemExt[])Helper.Add(items, tli);
		}

		/// <summary>
		/// Remove the passed Item
		/// </summary>
		/// <param name="tli"></param>
		public static void Remove(ToolLoaderItemExt tli) 
		{
			if (items==null) Load();
			items = (ToolLoaderItemExt[])Helper.Delete(items, tli);
		}

		/// <summary>
		/// Save the Toollist
		/// </summary>
		public static void StoreTools()
		{
			if (items==null) return;

			string[] names = Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools").GetSubKeyNames();

			foreach (string name in names) 
			{
				Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools").DeleteSubKey(name, false);
			}
			Helper.WindowsRegistry.RegistryKey.DeleteSubKey("ExtTools", false);
			XmlRegistryKey rk = Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools");

			foreach (ToolLoaderItemExt tli in items) 
			{
				tli.SaveSettings();
			}
		}

		protected static void Load() 
		{
			ArrayList list = new ArrayList();

			XmlRegistryKey rk = Helper.WindowsRegistry.RegistryKey.CreateSubKey("ExtTools");
			string[] names = rk.GetSubKeyNames();

			foreach (string name in names) 
			{
				string rname = ToolLoaderItemExt.SplitName(name);
				XmlRegistryKey srk = rk.CreateSubKey(name);

				ToolLoaderItemExt tli = new ToolLoaderItemExt(rname);
				tli.Type = Convert.ToUInt32(srk.GetValue("type"));
				//tli.Name = Convert.ToString(srk.GetValue("name"));
				tli.FileName = Convert.ToString(srk.GetValue("filename"));
				tli.Attributes = Convert.ToString(srk.GetValue("attributes"));

				list.Add(tli);
			}

			items = new ToolLoaderItemExt[list.Count];
			list.CopyTo(items);
		}

		/// <summary>
		/// Returns the List of all known Tools for this Type
		/// </summary>
		/// <param name="type"></param>
		/// <returns></returns>
		public static ToolLoaderItemExt[] UsableItems(uint type) 
		{
			if (items==null) Load();

			ArrayList list = new ArrayList();
			if (type!=0xffffffff) foreach (ToolLoaderItemExt tli in items) if (tli.Type == type) list.Add(tli);
			foreach (ToolLoaderItemExt tli in items) if (tli.Type == 0xffffffff) list.Add(tli);

			ToolLoaderItemExt[] ret = new ToolLoaderItemExt[list.Count];
			list.CopyTo(ret);

			return ret;
		}
	}
}
