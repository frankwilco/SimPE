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
using System.IO;
using System.Collections;
using SimPe.Data;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Providers
{
	/// <summary>
	/// Provides an Alias Matching a SimID with it's Name
	/// </summary>
	/// <remarks>
	/// The Tag of the NameProvider is an Object Array with the following content:
	///  0: The Name of the Character File
	///  1: Image of the Sim (if available)
	///  2: Familyname of the Sim
	/// </remarks>
	public class SimNames : SimPe.Interfaces.Providers.ISimNames
	{
		/// <summary>
		/// List of known Aliases (can be null)
		/// </summary>
		private Hashtable names;

		/// <summary>
		/// This is needed for the OBJD to work
		/// </summary>
		Interfaces.Providers.IOpcodeProvider opcodes;

		/// <summary>
		/// The Folder from where the SimInformation was loaded
		/// </summary>
		private string dir;

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		/// <param name="folder">The Folder with the Character Files</param>
		public SimNames(string folder, Interfaces.Providers.IOpcodeProvider opcodes)
		{			
			BaseFolder = folder;
			this.opcodes = opcodes;
		}

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public SimNames(Interfaces.Providers.IOpcodeProvider opcodes)
		{
			dir="";
			this.opcodes = opcodes;
		}


		/// <summary>
		/// Returns or sets the Folder where the Character Files are stored
		/// </summary>
		/// <remarks>Sets the names List to null</remarks>
		public string BaseFolder
		{
			get 
			{
				return dir;
			}
			set 
			{
				if (dir!=value) names = null;
				dir = value;
			}
		}

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadSimsFromFolder() 
		{
			names = new Hashtable();
			if (!Directory.Exists(dir)) return;
			

			string[] files = Directory.GetFiles(dir, "*.package");

			WaitingScreen.Wait();	
			
			SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(opcodes);
			SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
			//ArrayList al = new ArrayList();
			foreach(string file in files) 
			{
				//BinaryReader br = new BinaryReader(File.OpenRead(file));//new StreamReader(file)
				object[] tags = new object[4];
				tags[0] = file;
				tags[1] = null;
				tags[2] = Localization.Manager.GetString("Unknown");
				tags[3] = false;

				SimPe.Packages.File fl = SimPe.Packages.File.LoadFromFile(file);
				Alias a = null;
				//check if package contains a AgeData File
				tags[3] = (fl.FindFiles(0xAC598EAC).Length>0);

				foreach (uint type in objd.AssignableTypes) 
				{
					IPackedFileDescriptor[] list = fl.FindFiles(type);
					if (list.Length>0) 
					{
						objd.ProcessData(list[0], fl);
						Interfaces.Files.IPackedFileDescriptor str_pfd = fl.FindFile(Data.MetaData.CTSS_FILE, 0, 0xffffffff, objd.CTSSInstance);
						
						if (str_pfd != null) 
						{
							str.ProcessData(str_pfd, fl);
							SimPe.PackedFiles.Wrapper.StrItemList its = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
							if (its.Length>0) 
							{
#if DEBUG
								a = new Alias(objd.Guid, its[0].Title, "{name} {2} (0x{id})");						
#else
								a = new Alias(objd.Guid, its[0].Title, "{name} {2} (0x{id})");
#endif
								if (its.Length>2) tags[2] = its[2].Title;
							}
						}

						break;
					}

					if (a!=null) break;
				}//foreach

				if (a!=null) 
				{
					IPackedFileDescriptor[] piclist = fl.FindFiles(Data.MetaData.SIM_IMAGE_FILE);
					foreach (IPackedFileDescriptor pfd in piclist) 
					{
						if (pfd.Instance < 0x1000) 
						{
							SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
							pic.ProcessData(pfd, fl);	
							WaitingScreen.UpdateImage(pic.Image);
							tags[1] = pic.Image;							
							break;
						}						
					}

					a.Tag = tags;
					if (!names.Contains(objd.Guid)) names.Add(objd.Guid, a);
				}
				//fl.Reader.Close();
			}//foreach

			/*names = new Alias[al.Count];
			al.CopyTo(names);*/

			WaitingScreen.Stop();
		}

		/// <summary>
		/// Returns the the Alias with the specified Type
		/// </summary>
		/// <param name="id">The id of a Sim</param>
		/// <returns>The Alias of the Sim</returns>
		public IAlias FindName(uint id) 
		{			
			if (names==null) LoadSimsFromFolder();

			object o = names[id];
			if (o!=null) return (IAlias)o;
			else return new Alias(id, Localization.Manager.GetString("unknown"));
		}		

		/// <summary>
		/// Returrns the stored Alias Data
		/// </summary>
		public Hashtable StoredData 
		{
			get
			{
				if (names==null) LoadSimsFromFolder();
				return names;
			}
			set 
			{
				names = value;
			}
		}

		
	}
}
