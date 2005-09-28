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
using System.Threading;
using Ambertation.Threading;

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
	public class SimNames : StoppableThread, SimPe.Interfaces.Providers.ISimNames
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
		/// Additional FileIndex fro template SimNames
		/// </summary>
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndex characterfi;

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		/// <param name="folder">The Folder with the Character Files</param>
		public SimNames(string folder, Interfaces.Providers.IOpcodeProvider opcodes) : base()
		{			
			BaseFolder = folder;
			this.opcodes = opcodes;

			ArrayList folders = new ArrayList();
			if (Helper.WindowsRegistry.EPInstalled>=1) 
			{
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U001\Characters\")));
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U002\Characters\")));
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U003\Characters\")));
			}
			if (Helper.WindowsRegistry.EPInstalled>=2) 
			{
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP2Path, @"TSData\Res\NeighborhoodTemplate\D001\Characters\")));
				
			}
			
			characterfi = new SimPe.Plugin.FileIndex(folders);
		}

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public SimNames(Interfaces.Providers.IOpcodeProvider opcodes) : this("", opcodes)
		{			
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
				if (dir!=value) 
				{
					WaitForEnd();
					names = null;					
				}
				dir = value;
			}
		}

		protected Alias AddSim(SimPe.Interfaces.Files.IPackageFile fl, IPackedFileDescriptor objdpfd, ref int ct, int step)
		{
			SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
			objd.ProcessData(objdpfd, fl);

			return AddSim(objd, ref ct, step, false);
		}

		/// <summary>
		/// Adds a Sim to the List
		/// </summary>
		/// <param name="objd"></param>
		/// <param name="ct"></param>
		/// <param name="step"></param>
		/// <returns>The Alias for that Sim</returns>
		/// <remarks>
		/// Alias.Tag has the following Structure:
		/// [0] : FileName of Character File (if NPC, this will be null)
		/// [1] : Thumbnail
		/// [2] : FamilyName
		/// [3] : Contains Age Data
		/// [4] : When NPC, this will get the Flename
		/// </remarks>
		protected Alias AddSim(SimPe.PackedFiles.Wrapper.ExtObjd objd, ref int ct, int step, bool npc)
		{
			//if (objd.Type!=Data.ObjectTypes.Person) return null;

			SimPe.Interfaces.Files.IPackageFile fl = objd.Package;
			//BinaryReader br = new BinaryReader(File.OpenRead(file));//new StreamReader(file)
			object[] tags = new object[5];
			tags[0] = fl.FileName;
			tags[1] = null;
			tags[2] = Localization.Manager.GetString("Unknown");
			tags[3] = (fl.FindFiles(0xAC598EAC).Length>0); //has Age Data?
			tags[4] = null; 

			//set stuff for NPCs
			if (npc) 
			{
				tags[4] = tags[0];
				tags[0] = "";				
				tags[2] += " (NPC)";
			}

			Alias a = null;
			
			

				
			
			
			Interfaces.Files.IPackedFileDescriptor str_pfd = fl.FindFile(Data.MetaData.CTSS_FILE, 0, objd.FileDescriptor.Group, objd.CTSSInstance);
						
			if (str_pfd != null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
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
			

			if (a!=null) 
			{
				IPackedFileDescriptor[] piclist = fl.FindFiles(Data.MetaData.SIM_IMAGE_FILE);
				foreach (IPackedFileDescriptor pfd in piclist) 
				{
					if (pfd.Group != objd.FileDescriptor.Group) continue;
					if (pfd.Instance < 0x200) 
					{
						SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
						pic.ProcessData(pfd, fl);	
						/*if (Helper.StartedGui==Executable.Classic) 
							WaitingScreen.UpdateImage(pic.Image);
						else
							Wait.Image = pic.Image;								*/
							
						tags[1] = pic.Image;							
						break;
					}						
				}

				a.Tag = tags;
				//if (Helper.StartedGui!=Executable.Classic) 
				{
					ct++;
					if (ct%step==1) 
					{
						Wait.Message = a.ToString();
						Wait.Progress = ct;
					}
				}

				//set stuff for NPCs
				if (npc) a.Tag[2] = a.Tag[2].ToString()+" (NPC)";

				if (names==null) return null;
				if (!names.Contains(objd.Guid)) names.Add(objd.Guid, a);
			
			}

			return a;
		}
		

		protected void ScanFileTable()
		{
			if (Helper.StartedGui==Executable.Classic) return;
			if (Helper.WindowsRegistry.DeepSimTemplateScan) characterfi.Load();

			FileTable.FileIndex.AddChild(characterfi);
			try 
			{
				ScanFileTable(0x80);
			}
			finally 
			{
				FileTable.FileIndex.RemoveChild(characterfi);
			}
			
		}
		
		protected void ScanFileTable(uint inst)
		{
			if (Helper.StartedGui==Executable.Classic) return;
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileDiscardingGroup(Data.MetaData.OBJD_FILE, inst);
			Wait.MaxProgress = items.Length;
			int ct = 0;
			int step = Math.Max(2, Wait.MaxProgress / 100);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
			{
				if (this.HaveToStop) break;

				SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData(item);

				if (objd.Type==Data.ObjectTypes.Person || objd.Type==Data.ObjectTypes.Template) AddSim(objd, ref ct, step, true);
				
			}
		}

		protected override void StartThread()
		{
			string[] files = Directory.GetFiles(dir, "*.package");
			if (Helper.StartedGui==Executable.Classic)
				WaitingScreen.Wait();	
			else Wait.SubStart(files.Length);
			try 
			{
				bool breaked = false;			
				SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(opcodes);
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				//ArrayList al = new ArrayList();
				int ct = 0;
				int step = Math.Max(2, Wait.MaxProgress / 100);
				foreach(string file in files) 
				{
					if (this.HaveToStop) 
					{
						breaked = true;
						break;
					}

					SimPe.Packages.File fl = null;
					try 
					{
						fl = SimPe.Packages.File.LoadFromFile(file);
					} 
					catch {break;}
									
					IPackedFileDescriptor[] list = fl.FindFiles(Data.MetaData.OBJD_FILE);
					if (list.Length>0)	AddSim(fl, list[0], ref ct, step);
					//fl.Reader.Close();
				}//foreach

				if (!breaked) ScanFileTable();
			}  
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			} 
			finally 
			{
				if (Helper.StartedGui==Executable.Classic) WaitingScreen.Stop();
				else Wait.SubStop();
			}
				
			ended.Set();
		}

		
		object sync = new object();

		

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadSimsFromFolder() 
		{
			WaitForEnd();

			names = new Hashtable();
			if (!Directory.Exists(dir)) return;
						
			if (Helper.WindowsRegistry.DeepSimScan && Helper.StartedGui!=Executable.Classic) 
				FileTable.FileIndex.Load();
			this.ExecuteThread(ThreadPriority.AboveNormal, "Sim Name Provider", true, true);						
		}

		/// <summary>
		/// Returns the the Alias with the specified Type
		/// </summary>
		/// <param name="id">The id of a Sim</param>
		/// <returns>The Alias of the Sim</returns>
		/// <remarks>
		/// Alias.Tag has the following Structure:
		/// [0] : FileName of Character File (if NPC, this will be null)
		/// [1] : Thumbnail
		/// [2] : FamilyName
		/// [3] : Contains Age Data
		/// [4] : When NPC, this will get the Flename
		/// </remarks>
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
