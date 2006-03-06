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
	/// Zusammenfassung für LotProvider.
	/// </summary>
	public class LotProvider : StoppableThread, SimPe.Interfaces.Providers.ILotProvider
	{
		public class LotItem : SimPe.Interfaces.Providers.ILotItem
		{
			string name;
			System.Drawing.Image img;
			uint inst;
			internal LotItem(uint inst, string name, System.Drawing.Image img)
			{
				this.name = name;
				this.img = img;
				this.inst = inst;
			}

			public uint Instance
			{
				get {return inst;}
			}

			public System.Drawing.Image Image
			{
				get {return img;}
			}

			public string Name
			{
				get {return name;}
			}

			public override int GetHashCode()
			{
				return (int)inst;
			}

			public override string ToString()
			{
				return name;
			}


		}
		Hashtable content;
		/// <summary>
		/// The Folder from where the SimInformation was loaded
		/// </summary>
		private string dir;

		/// <summary>
		/// Additional FileIndex fro template SimNames
		/// </summary>
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndex lotfi;
		SimPe.Interfaces.Scenegraph.IScenegraphFileIndex ngbhfi;

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		/// <param name="folder">The Folder with the Character Files</param>
		public LotProvider(string folder) : base()
		{			
			BaseFolder = folder;

			ArrayList folders = new ArrayList();
			/*if (Helper.WindowsRegistry.EPInstalled>=1) 
			{
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U001\Lots\")));
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U002\Lots\")));
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, @"TSData\Res\NeighborhoodTemplate\U003\Lots\")));
			}
			if (Helper.WindowsRegistry.EPInstalled>=2) 
			{
				folders.Add(new SimPe.FileTableItem(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP2Path, @"TSData\Res\NeighborhoodTemplate\D001\Lots\")));				
			}*/
			
			lotfi = new SimPe.Plugin.FileIndex(folders);
			ngbhfi = lotfi.AddNewChild();
		}

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public LotProvider() : this("")
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
					content = null;							
				}
				dir = value;
			}
		}		

		protected uint GetInstanceFromFilename(string flname)
		{
			flname = System.IO.Path.GetFileNameWithoutExtension(flname).ToLower();
			int pos = flname.IndexOf("_lot");
			flname = flname.Substring(pos+4);

			return Helper.StringToUInt32(flname, 0, 10);
		}

		protected override void StartThread()
		{			
			lotfi.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = lotfi.FindFile(0x856DDBAC, Data.MetaData.LOCAL_GROUP, 0x35CA0002, null);
			Wait.SubStart(items.Length);
			try 
			{
								
				int ct = 0;
				int step = Math.Max(2, Wait.MaxProgress / 100);
				foreach(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					if (this.HaveToStop) 
						break;					

					
					SimPe.Interfaces.Files.IPackageFile pkg = item.Package;
					
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(Data.MetaData.STRING_FILE, 0, Data.MetaData.LOCAL_GROUP, 0x00000A46);
					string name = SimPe.Localization.GetString("Unknown");
					if (pfd!=null) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
						str.ProcessData(pfd, pkg);

						SimPe.PackedFiles.Wrapper.StrItemList list = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
						if (list.Count>0) name = list[0].Title;
					}

					SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
					pic.ProcessData(item);

					LotItem li = new LotItem(GetInstanceFromFilename(pkg.SaveFileName), name, pic.Image);
					content[li.Instance] = li;
					ct++;
					if (ct%step==0)
					{
						Wait.Message = name;
						Wait.Progress = ct;
					}

				}//foreach				
			}  
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			} 
			finally 
			{
				Wait.SubStop();
			}
				
			ended.Set();
			
		}

		
		object sync = new object();

		

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadLotsFromFolder() 
		{
			WaitForEnd();

			content = new Hashtable();
			if (!Directory.Exists(dir)) return;
			ngbhfi.Clear();
			ngbhfi.AddIndexFromFolder(dir);
							
			if (Helper.StartedGui==Executable.Classic) return;
			this.ExecuteThread(ThreadPriority.AboveNormal, "Lot Provider", true, true);						
		}

		public SimPe.Interfaces.Providers.ILotItem FindLot(uint inst)
		{
			object o = StoredData[inst];
			if (o==null) return new LotItem(inst, SimPe.Localization.GetString("Unknown"), null);
			return o as SimPe.Interfaces.Providers.ILotItem;
		}

		public string[] GetNames()
		{
			Hashtable c = StoredData;
			string[] ret = new string[c.Values.Count];
			int ct=0;
			foreach (LotItem li in c.Values) 			
				ret[ct++] = li.Name;
			
			return ret;
		}

		/// <summary>
		/// Returrns the stored Alias Data
		/// </summary>
		public Hashtable StoredData 
		{
			get
			{
				if (content==null) LoadLotsFromFolder();
				return content;
			}
			set 
			{
				content = value;
			}
		}

		
	}
}
