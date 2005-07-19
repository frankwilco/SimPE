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
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Drawing;

namespace SimPe.Plugin.Tool.Dockable
{	
  
	internal class MyMonitor
	{
		// Anzahl der Elemente
		public static bool finished_create;
		public static bool finished_consume;
  
		// Thread - Lock - Variablen
		private static object buffer_free = "";
		private static object buffer_not_empty = "";
		private static object consuming = "";
  
		// Buffer - Variables
		private const int N = 50; // maximum Number of Elements in the Buffer
		private static int counter=0; // Number of Elements in the Buffer
		public static object[] buffer = new object[N]; // Buffer
		internal static bool changedcache;
  
		// Synchronisierte create - Methode
		public static void create(Object o)
		{
			lock(buffer_not_empty)
			{
				if(MyMonitor.counter==N) // Is Buffer full
				{
					// wait until a slot is available
					Monitor.Wait(buffer_free);
				}

				// Add Data to the Buffer
				buffer[MyMonitor.counter] = o;			
				// -------------
				MyMonitor.counter++;
    
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}

		public static void Init()
		{
			changedcache = false;
			finished_create = false;
			finished_consume = false;
		}

		public static void Finish()
		{
			lock(buffer_not_empty)
			{
				finished_create = true; 
				// Signal that we have added a Element
				Monitor.PulseAll(buffer_not_empty);
			}
		}
  
		// Synchronisierte consume - Methode
		public static Object consume()
		{
			Object o = new Object();
   
			lock(buffer_free)
			{
				lock(consuming)
				{
					//Monitor.Wait( consuming );
					while (MyMonitor.counter==0 ) // is Buffer Empty
					{
						if (!MyMonitor.finished_create) 
						{
							// wait until an Element is added
							Monitor.Wait(buffer_not_empty);
						} 
						else 
						{
							MyMonitor.finished_consume = true;
							return null;
						}
					}

				
					// Hole Daten ab
					o = buffer[MyMonitor.counter-1];
					buffer[MyMonitor.counter-1] = null;
				
					// -------------
					MyMonitor.counter--;	
				
					Monitor.PulseAll(consuming);
				}

				// Signal that we have removed an Element from the Buffer
				Monitor.PulseAll(buffer_free);
			}
   
			return o;
		}
	}
 
	internal class ObjectReader
	{

		public ObjectReader()
		{			
			cachechg = false;
		}

		#region Cache Handling		
		SimPe.Cache.ObjectCacheFile cachefile;
		bool cachechg;

		/// <summary>
		/// Get the Name of the Object Cache File
		/// </summary>
		string CacheFileName 
		{
			get {return Helper.SimPeLanguageCache;}
		}

		/// <summary>
		/// Load the Object Cache
		/// </summary>
		void LoadCachIndex()
		{
			if (cachefile!=null) return;
			
			cachechg = false;
			cachefile = new SimPe.Cache.ObjectCacheFile();
		
			if (!Helper.WindowsRegistry.UseCache) return;
			WaitingScreen.UpdateMessage("Loading Cache");
			try 
			{
				cachefile.Load(CacheFileName);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}			

			cachefile.LoadObjects();
		}

		/// <summary>
		/// Save the Cache to the Disk
		/// </summary>
		void SaveCacheIndex()
		{
			if (!Helper.WindowsRegistry.UseCache) return;
			if (!cachechg && !MyMonitor.changedcache) return;
			WaitingScreen.UpdateMessage("Saving Cache");

			cachefile.Save(CacheFileName);
		}		
		#endregion

		public event System.EventHandler Finished;

		public void start()
		{
			MyMonitor.Init();
			bool run = WaitingScreen.Running;
			WaitingScreen.Wait();
			LoadCachIndex();								

			
			ArrayList pitems = new ArrayList();
			ArrayList groups = new ArrayList();
			int ct = 0;				
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] nrefitems = FileTable.FileIndex.Sort(FileTable.FileIndex.FindFile(Data.MetaData.OBJD_FILE, true));
			string len = " / " + nrefitems.Length.ToString();

			SimPe.Data.MetaData.Languages deflang = Helper.WindowsRegistry.LanguageCode;
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem in nrefitems)
			{
				ct++;
				if (ct%134==1) WaitingScreen.UpdateMessage(ct.ToString() + len);
					

				if (nrefitem.FileDescriptor.Instance != 0x41A7) continue;
				if (nrefitem.LocalGroup == Data.MetaData.LOCAL_GROUP) continue;
				if (pitems.Contains(nrefitem)) continue;
				if (groups.Contains(nrefitem.LocalGroup)) continue;					

				Interfaces.Scenegraph.IScenegraphFileIndexItem[] cacheitems = cachefile.FileIndex.FindFile(nrefitem.FileDescriptor);

				//find the correct File
				int cindex = -1;
				string pname = nrefitem.Package.FileName.Trim().ToLower();
				for (int i=0; i<cacheitems.Length; i++)
				{
					Interfaces.Scenegraph.IScenegraphFileIndexItem citem = cacheitems[i];
						
					if (citem.FileDescriptor.Filename == pname) 
					{
						cindex=i;
						break;
					}
				}

				if (cindex!=-1) //found in the cache
				{
					SimPe.Cache.ObjectCacheItem oci = (SimPe.Cache.ObjectCacheItem)cacheitems[cindex].FileDescriptor.Tag;			
					if (!oci.Useable) continue;
					pitems.Add(nrefitem);
					groups.Add(nrefitem.LocalGroup);

					oci.Tag = nrefitem;
					MyMonitor.create(oci);
				} 
				else 
				{
					pitems.Add(nrefitem);
					groups.Add(nrefitem.LocalGroup);

					SimPe.Cache.ObjectCacheItem oci = new SimPe.Cache.ObjectCacheItem();
					oci.Tag = nrefitem;
					oci.Useable = false;
					cachechg = true;
					cachefile.AddItem(oci, nrefitem.Package.FileName);
					
					MyMonitor.create(oci);
				}
			}
					
			MyMonitor.Finish();
			while (!MyMonitor.finished_consume)
				Thread.Sleep(500);

			this.SaveCacheIndex();			
			if (!run) WaitingScreen.Stop();
			if (Finished!=null) Finished(this, new System.EventArgs());
		}
	}
 
	internal class ObjectConsumer
	{
		#region Thumbnails
		/// <summary>
		/// Returns the Instance Number for the assigned Thumbnail
		/// </summary>
		/// <param name="group">The Group of the Object</param>
		/// <param name="modelname">The Name of teh Model (inst 0x86)</param>
		/// <returns>Instance of the Thumbnail</returns>
		public static uint ThumbnailHash(uint group, string modelname) 
		{
			string name = group.ToString()+modelname;
			return (uint)Hashes.ToLong(Hashes.Crc32.ComputeHash(Helper.ToBytes(name.Trim().ToLower())));
		}

		static SimPe.Packages.File thumbs = null;

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname) 
		{
			return GetThumbnail(group, modelname, null);
		}
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message) 
		{
			uint inst = ThumbnailHash(group, modelname);
			if (thumbs==null) 
			{
				thumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Thumbnails\\ObjectThumbnails.package"));
				thumbs.Persistent = true;
			}

			//0x6C2A22C3
			Interfaces.Files.IPackedFileDescriptor[] pfds = thumbs.FindFile(0xAC2950C1, 0, inst);
			if (pfds.Length>0) 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
				try 
				{
					SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
					pic.ProcessData(pfd, thumbs);
					Bitmap bm = (Bitmap)ImageLoader.Preview(pic.Image, WaitingScreen.ImageSize);
					WaitingScreen.Update(bm, message);
					return pic.Image;
				}
				catch(Exception){}
			}
			return null;
		}
		#endregion

		
		public event ObjectLoader.LoadItemHandler LoadedItem;
		public void start()
		{				
			SimPe.Data.MetaData.Languages deflang = Helper.WindowsRegistry.LanguageCode;
			while(!MyMonitor.finished_consume)
			{
				// consume Data
				Object o = MyMonitor.consume();				
				if (o==null) break;

				SimPe.Cache.ObjectCacheItem oci = (SimPe.Cache.ObjectCacheItem)o;
				Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem = (Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag;

				//this item is new to the cache, so load the Data
				if ((!oci.Useable || oci.ObjectVersion!=SimPe.Cache.ObjectCacheItemVersions.DockableOW))
				{
					SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
					nrefitem.FileDescriptor.UserData = nrefitem.Package.Read(nrefitem.FileDescriptor).UncompressedData;
					objd.ProcessData(nrefitem);

					oci.FileDescriptor = nrefitem.FileDescriptor;
					oci.LocalGroup = nrefitem.LocalGroup;							
					oci.ObjectType = objd.Type;
					oci.ObjectFunctionSort = (uint)objd.FunctionSubSort;
					oci.ObjectFileName = objd.FileName;
					oci.Useable = true;
					oci.Class = SimPe.Cache.ObjectClass.Object;

					//this is needed, so that objects get sorted into the right categories
					if (objd.Type == Data.ObjectTypes.Normal && objd.CTSSInstance==0) 
					{
						oci.Useable = false;						
						continue;
					}

					//Get the Name of the Object
					Interfaces.Scenegraph.IScenegraphFileIndexItem[] ctssitems = FileTable.FileIndex.FindFile(Data.MetaData.CTSS_FILE, nrefitem.LocalGroup);
					if (ctssitems.Length>0) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
						str.ProcessData(ctssitems[0]);
						SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(deflang);
						if (items.Length>0) oci.Name = items[0].Title;
						else 
						{
							items = str.LanguageItems(1);
							if (items.Length>0) oci.Name = items[0].Title;
							else oci.Name = "";
						}
					} 
					else 
					{
						oci.Name = "";
					}

					//now the ModeName File
					Interfaces.Scenegraph.IScenegraphFileIndexItem[] txtitems = FileTable.FileIndex.FindFile(Data.MetaData.STRING_FILE, nrefitem.LocalGroup, 0x85);
					if (txtitems.Length>0) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str(2);
						str.ProcessData(txtitems[0]);
						SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
						if (items.Length>1) oci.ModelName = items[1].Title;
					}

					MyMonitor.changedcache = true;
				} //if not loaded

				if (oci.Thumbnail==null) 
				{
					oci.Thumbnail = GetThumbnail(nrefitem.FileDescriptor.Group, oci.ModelName);										
					if (oci.Thumbnail!=null) 
					{
						WaitingScreen.UpdateImage(oci.Thumbnail);
						MyMonitor.changedcache = true;
					}
				}

#if DEBUG
				Data.Alias a = new Data.Alias(oci.FileDescriptor.Group, "---");//, "{name} ({id}: {1}, {2}) ");
#else
				Data.Alias a = new Data.Alias(oci.FileDescriptor.Group, "---");//, "{name} ({id}: {1}) ");
#endif
				object[] os = new object[4];
				os[0] = nrefitem.FileDescriptor;
				os[1] = nrefitem.LocalGroup;
				os[2] = oci.ModelName;
				os[3] = oci;

				a.Tag = os;

				if (Helper.WindowsRegistry.ShowObjdNames) a.Name = oci.ObjectFileName;	
				else a.Name = oci.Name;
				a.Name +=  " (cached)";
				Image img = oci.Thumbnail;			
				
				if (LoadedItem!=null) LoadedItem(oci, nrefitem, a);
			}

			MyMonitor.finished_consume = true;
		}
	}

	/// <summary>
	/// This calss provides Methods to Lbufferd available Objects form the HD or Cache
	/// </summary>
	public class ObjectLoader
	{
		public delegate void LoadItemHandler(SimPe.Cache.ObjectCacheItem oci, Interfaces.Scenegraph.IScenegraphFileIndexItem fii, Data.Alias a);
		public event ObjectLoader.LoadItemHandler LoadedItem;
		public event System.EventHandler Finished;

		ImageList ilist;
		public ObjectLoader(ImageList ilist)
		{
			if (ilist==null) ilist=new ImageList();			
			ilist.ImageSize = new System.Drawing.Size(Helper.WindowsRegistry.OWThumbSize,Helper.WindowsRegistry.OWThumbSize);
			ilist.ColorDepth = ColorDepth.Depth32Bit;

			this.ilist = ilist;
		}

		public void LoadData()
		{
			WaitingScreen.Wait();
			FileTable.FileIndex.Load();
			
			ObjectReader erz = new ObjectReader();
			ObjectConsumer ver1 = new ObjectConsumer();
			ObjectConsumer ver2 = new ObjectConsumer();

			ver1.LoadedItem += new LoadItemHandler(ver1_LoadedItem);
			ver2.LoadedItem += new LoadItemHandler(ver1_LoadedItem);
			erz.Finished += new EventHandler(erz_Finished);
			Thread te = new Thread(new ThreadStart(erz.start));
			Thread tv1 = new Thread(new ThreadStart(ver1.start));
			Thread tv2 = new Thread(new ThreadStart(ver2.start));
			te.Start();
			tv1.Start();	
		}

		private void ver1_LoadedItem(SimPe.Cache.ObjectCacheItem oci, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Data.Alias a)
		{
			if (LoadedItem!=null) LoadedItem(oci, fii, a);
		}

		private void erz_Finished(object sender, EventArgs e)
		{
			WaitingScreen.Stop();
			if (Finished!=null) Finished(this, new System.EventArgs());
		}
	}
}
