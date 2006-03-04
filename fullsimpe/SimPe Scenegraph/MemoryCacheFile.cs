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
using SimPe;
using SimPe.Plugin;


namespace SimPe.Cache
{
	/// <summary>
	/// Contains an Instance of a CacheFile
	/// </summary>
	public class MemoryCacheFile: CacheFile
	{
		/// <summary>
		/// Updates and Loads the Memory Cache
		/// </summary>
		/// <returns></returns>
		public static MemoryCacheFile InitCacheFile() 
		{
			bool running = WaitingScreen.Running;
			if (!running) WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Loading Cache");

			MemoryCacheFile cachefile = new MemoryCacheFile();
			cachefile.Load(Helper.SimPeLanguageCache);

			FileTable.FileIndex.Load();
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.OBJD_FILE, true);
			
			bool added = false;
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
			{
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] citems = cachefile.FileIndex.FindFile(item.FileDescriptor, null);
				if (citems.Length==0) 
				{
					WaitingScreen.UpdateMessage("Updating Cache");
					SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
					objd.ProcessData(item);

					cachefile.AddItem(objd);					
					added = true;
				}
			}

			if (added) 
			{
				cachefile.Save(cachefile.FileName);
				cachefile.LoadMemTable();
				cachefile.LoadMemList();
			}

			if (!running) WaitingScreen.Stop();

			return cachefile;
		}
		/// <summary>
		/// Creaet a new Instance for an empty File
		/// </summary>
		public MemoryCacheFile() : base()
		{
			DEFAULT_TYPE = ContainerType.Memory;
		}		

		/// <summary>
		/// Add a MaterialOverride to the Cache
		/// </summary>
		/// <param name="objd">The Object Data File</param>
		public MemoryCacheItem AddItem(SimPe.PackedFiles.Wrapper.ExtObjd objd) 
		{
			CacheContainer mycc = this.UseConatiner(ContainerType.Memory, objd.Package.FileName);
			
			MemoryCacheItem mci = new MemoryCacheItem();			
			mci.FileDescriptor = objd.FileDescriptor;
			mci.Guid = objd.Guid;			
			mci.ObjectType = objd.Type;		
			mci.ObjdName = objd.FileName;

			try 
			{
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] sitems = FileTable.FileIndex.FindFile(Data.MetaData.CTSS_FILE, objd.FileDescriptor.Group, objd.CTSSInstance, null);
				if (sitems.Length>0) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
					str.ProcessData(sitems[0]);
					SimPe.PackedFiles.Wrapper.StrItemList strs = str.LanguageItems(Helper.WindowsRegistry.LanguageCode);																
					if (strs.Length>0) mci.Name = strs[0].Title;
								
					//not found?
					if (mci.Name== "") 
					{
						strs = str.LanguageItems(1);																
						if (strs.Length>0) mci.Name = strs[0].Title;
					}							
				}

			}
			catch (Exception) {}
			
			//still no name?
			if (mci.Name == "") mci.Name = objd.FileName;
					
			//having an icon?
			SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] iitems = FileTable.FileIndex.FindFile(Data.MetaData.SIM_IMAGE_FILE, objd.FileDescriptor.Group, 1, null);	
			if (iitems.Length>0) 
			{
				pic.ProcessData(iitems[0]);
				mci.Icon = pic.Image;
				WaitingScreen.UpdateImage(mci.Icon);
			}

			WaitingScreen.UpdateMessage(mci.Name);
			//mci.ParentCacheContainer = mycc; //why was this disbaled?
			mycc.Items.Add(mci);

			return mci;
		}

		Hashtable map;
		/// <summary>
		/// Return the FileIndex represented by the Cached Files
		/// </summary>
		public Hashtable Map 
		{
			get { 
				if (map==null) LoadMem();
				return map; 
			}
		}

		/// <summary>
		/// Creates the Map
		/// </summary>
		/// <returns>the FileIndex</returns>
		/// <remarks>
		/// The Tags of the FileDescriptions contain the MMATCachItem Object, 
		/// the FileNames of the FileDescriptions contain the Name of the package File
		/// </remarks>
		public void LoadMem()
		{
			map = new Hashtable();
			

			foreach (CacheContainer cc in Containers) 
			{
				if (cc.Type==ContainerType.Memory && cc.Valid) 
				{
					foreach (MemoryCacheItem mci in cc.Items) 
					{
						map[mci.Guid] = mci;
					}
				}
			}//foreach
		}	

		ArrayList list;
		/// <summary>
		/// Return a List of all cached Memory Items
		/// </summary>
		public ArrayList List
		{
			get 
			{ 
				if (list==null) LoadMemList();
				return list; 
			}
		}

		/// <summary>
		/// Creates the List
		/// </summary>
		/// <returns>the FileIndex</returns>
		/// <remarks>
		/// The Tags of the FileDescriptions contain the MMATCachItem Object, 
		/// the FileNames of the FileDescriptions contain the Name of the package File
		/// </remarks>
		public void LoadMemList()
		{
			list = new ArrayList();
			

			foreach (CacheContainer cc in Containers) 
			{
				if (cc.Type==ContainerType.Memory && cc.Valid) 
				{
					foreach (MemoryCacheItem mci in cc.Items) 
					{						
						list.Add(mci);
					}
				}
			}//foreach
		}
	
		FileIndex fi;
		/// <summary>
		/// Return the FileIndex represented by the Cached Files
		/// </summary>
		public FileIndex FileIndex 
		{
			get 
			{ 
				if (fi==null) LoadMemTable();
				return fi; 
			}
		}

		/// <summary>
		/// Creates a FileIndex with all available MMAT Files
		/// </summary>
		/// <returns>the FileIndex</returns>
		/// <remarks>
		/// The Tags of the FileDescriptions contain the MMATCachItem Object, 
		/// the FileNames of the FileDescriptions contain the Name of the package File
		/// </remarks>
		public void LoadMemTable()
		{
			fi = new FileIndex(new ArrayList());
			fi.Duplicates = false;
			
			foreach (CacheContainer cc in Containers) 
			{
				if (cc.Type==ContainerType.Memory && cc.Valid) 
				{
					foreach (MemoryCacheItem mci in cc.Items) 
					{
						Interfaces.Files.IPackedFileDescriptor pfd = mci.FileDescriptor;
						pfd.Filename = cc.FileName;
						fi.AddIndexFromPfd(pfd, null, FileIndex.GetLocalGroup(pfd.Filename));
					}
				}
			}//foreach
		}

		/// <summary>
		/// Returns an Alias for the given Guid
		/// </summary>
		/// <param name="guid"></param>
		/// <returns></returns>
		public MemoryCacheItem FindItem(uint guid)
		{
			MemoryCacheItem mci = (MemoryCacheItem)Map[guid];
			return mci;
		}

		/// <summary>
		/// Returns an Alias for the given Guid
		/// </summary>
		/// <param name="guid"></param>
		/// <returns></returns>
		public SimPe.Interfaces.IAlias FindObject(uint guid)
		{
			MemoryCacheItem mci = FindItem(guid);
			SimPe.Data.Alias a;
			if (mci==null)
			     a = new SimPe.Data.Alias(guid, Localization.Manager.GetString("Unknown"));
			else
				 a = new SimPe.Data.Alias(guid, mci.Name);

			object[] o = new object[3];
			o[0] = mci.FileDescriptor;
			o[1] = mci.ObjectType;
			o[2] = mci.Icon;
			a.Tag = o;

			return a;
		}		
	}
}
