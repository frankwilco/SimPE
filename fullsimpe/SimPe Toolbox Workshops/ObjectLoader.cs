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
using Ambertation.Threading;

namespace SimPe.Plugin.Tool.Dockable
{	
	internal class ObjectReader : ProducerThread
	{
		internal static bool changedcache;
		public ObjectReader()
		{			
			cachechg = false;
		}

		#region Cache Handling		
		SimPe.Cache.ObjectLoaderCacheFile cachefile;
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
			cachefile = new SimPe.Cache.ObjectLoaderCacheFile();
		
			if (!Helper.WindowsRegistry.UseCache) return;
			Wait.Message = "Loading Cache";
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
			if (!cachechg && !ObjectReader.changedcache) return;
			Wait.Message = "Saving Cache";

			cachefile.Save(CacheFileName);
		}		
		#endregion
		
		
		void ProduceByXObj(uint type)
		{
			ArrayList pitems = new ArrayList();
			ArrayList groups = new ArrayList();
			int ct = 0;		
			//this is the first part loading by objd Resources
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] nrefitems = FileTable.FileIndex.Sort(FileTable.FileIndex.FindFile(type, true));
			string len = " / " + nrefitems.Length.ToString();

			SimPe.Data.MetaData.Languages deflang = Helper.WindowsRegistry.LanguageCode;
			Wait.Message = "Loading Walls, Fences and Floors";
			Wait.MaxProgress = nrefitems.Length;
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem lnrefitem in nrefitems)
			{
				ct++;
				Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem = lnrefitem;
				if (ct%134==1) 				
					Wait.Progress = ct;				
				
#if MAC
				Console.WriteLine(ct.ToString()+len);
#endif

				//if (nrefitem.FileDescriptor.Instance != 0x41A7) continue;
				if (nrefitem.LocalGroup == Data.MetaData.LOCAL_GROUP) continue;
				if (pitems.Contains(nrefitem)) continue;
				if (groups.Contains(nrefitem.FileDescriptor.Instance)) continue;		
	

				//try to find the best objd				
				

							

				Interfaces.Scenegraph.IScenegraphFileIndexItem[] cacheitems = cachefile.FileIndex.FindFile(nrefitem.FileDescriptor, nrefitem.Package);

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
					groups.Add(nrefitem.FileDescriptor.Instance);

					oci.Tag = nrefitem;
					this.AddToBuffer(oci);
				} 
				else 
				{
					pitems.Add(nrefitem);
					groups.Add(nrefitem.FileDescriptor.Instance);

					SimPe.Cache.ObjectCacheItem oci = new SimPe.Cache.ObjectCacheItem();
					oci.Tag = nrefitem;
					oci.Useable = false;
					cachechg = true;
					cachefile.AddItem(oci, nrefitem.Package.FileName);
					
					this.AddToBuffer(oci);
				}
			}		
		}

		protected override void Produce()
		{			
			LoadCachIndex();	
			changedcache = false;				

			
			ArrayList pitems = new ArrayList();
			ArrayList groups = new ArrayList();
			int ct = 0;		
			//this is the first part loading by objd Resources
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] nrefitems = FileTable.FileIndex.Sort(FileTable.FileIndex.FindFile(Data.MetaData.OBJD_FILE, true));
		
			string len = " / " + nrefitems.Length.ToString();

			SimPe.Data.MetaData.Languages deflang = Helper.WindowsRegistry.LanguageCode;
			Wait.Message = "Loading Objects";
			Wait.MaxProgress = nrefitems.Length;
			foreach (Interfaces.Scenegraph.IScenegraphFileIndexItem lnrefitem in nrefitems)
			{                
				ct++;
				Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem = lnrefitem;
				if (ct%134==1) Wait.Progress = ct;				

				//if (nrefitem.FileDescriptor.Instance != 0x41A7) continue;
				if (nrefitem.LocalGroup == Data.MetaData.LOCAL_GROUP) continue;
				if (pitems.Contains(nrefitem)) continue;
				if (groups.Contains(nrefitem.LocalGroup)) continue;		
	

				//try to find the best objd				
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] oitems = FileTable.FileIndex.FindFile(nrefitem.FileDescriptor.Type, nrefitem.LocalGroup);
				if (oitems.Length>1) 
				{
					for (int i=0; i<oitems.Length; i++)
						if (oitems[i].FileDescriptor.Instance == 0x41A7 || oitems[i].FileDescriptor.Instance == 0x41AF) 
						{
							nrefitem = oitems[i];
							break;
						}
				}

							

				Interfaces.Scenegraph.IScenegraphFileIndexItem[] cacheitems = cachefile.FileIndex.FindFile(nrefitem.FileDescriptor, nrefitem.Package);

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
					this.AddToBuffer(oci);
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
					
					this.AddToBuffer(oci);
				}
			}												

			if (Helper.WindowsRegistry.HiddenMode) 
			{
				//In the second pass we use ObjectXml Resources to load Objects like Walls
				ProduceByXObj(Data.MetaData.XOBJ);
				ProduceByXObj(Data.MetaData.XROF);
				ProduceByXObj(Data.MetaData.XFLR);
				ProduceByXObj(Data.MetaData.XFNC);
				ProduceByXObj(Data.MetaData.XNGB);
			}
		}

		protected override void OnFinish()
		{
			base.OnFinish();
			this.SaveCacheIndex();
		}

	}
 
	internal class ObjectConsumer : ConsumerThread
	{
		

		SimPe.Data.MetaData.Languages deflang;
		ArrayList pict;
		internal ObjectConsumer(ProducerThread pt) : base(pt)
		{
			deflang = Helper.WindowsRegistry.LanguageCode;

			this.pict = new ArrayList();
			SimPe.PackedFiles.Wrapper.Picture pw = new SimPe.PackedFiles.Wrapper.Picture();
			uint[] picts = pw.AssignableTypes;
			foreach (uint p in picts) this.pict.Add(p);
		}
		
		public event ObjectLoader.LoadItemHandler LoadedItem;

		static void SetFunctionSortForXObj(SimPe.PackedFiles.Wrapper.Cpf cpf, SimPe.Cache.ObjectCacheItem oci)
		{
			oci.ObjectFunctionSort = (uint)ObjectPreview.GetFunctionSort(cpf);			
		}

		static void ConsumeFromXobj(SimPe.Cache.ObjectCacheItem oci, Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem, SimPe.Data.MetaData.Languages deflang)
		{
			SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
			nrefitem.FileDescriptor.UserData = nrefitem.Package.Read(nrefitem.FileDescriptor).UncompressedData;
			cpf.ProcessData(nrefitem);

			oci.FileDescriptor = nrefitem.FileDescriptor;
			oci.LocalGroup = nrefitem.LocalGroup;							
			oci.ObjectType = SimPe.Data.ObjectTypes.Normal;
			
			SetFunctionSortForXObj(cpf, oci);
						
			oci.ObjectFileName = cpf.GetSaveItem("filename").StringValue;
			if (oci.ObjectFileName=="") oci.ObjectFileName = cpf.GetSaveItem("name").StringValue;

			oci.Useable = true; 
			oci.Class = SimPe.Cache.ObjectClass.XObject;
			

			
			Interfaces.Scenegraph.IScenegraphFileIndexItem[] ctssitems = FileTable.FileIndex.FindFile(cpf.GetSaveItem("stringsetrestypeid").UIntegerValue, cpf.GetSaveItem("stringsetgroupid").UIntegerValue, cpf.GetSaveItem("stringsetid").UIntegerValue, null); //Data.MetaData.STRING_FILE
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

			if (oci.Name=="") oci.Name = oci.ObjectFileName;

			//now the ModeName File
			if (cpf.GetItem("texturetname")!=null)			
				oci.ModelName = cpf.GetItem("texturetname").StringValue;
			else if (cpf.GetItem("filename")!=null)
				oci.ModelName = cpf.GetItem("filename").StringValue;
			else
				oci.ModelName = cpf.GetSaveItem("material").StringValue;
			
			//oci.Name = cpf.GetSaveItem("type").StringValue + " - "+ cpf.GetSaveItem("subsort").StringValue;


			if (oci.Thumbnail==null) 
				oci.Thumbnail = ObjectPreview.GetXThumbnail(cpf);
			ObjectReader.changedcache = true;
		}

		protected override bool Consume(Object o)
		{
			return DoConsume(o, LoadedItem, deflang);
		}

		internal static bool DoConsume(Object o, ObjectLoader.LoadItemHandler LoadedItem, SimPe.Data.MetaData.Languages deflang)
		{				
			
			SimPe.Cache.ObjectCacheItem oci = (SimPe.Cache.ObjectCacheItem)o;
			Interfaces.Scenegraph.IScenegraphFileIndexItem nrefitem = (Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag;

			
			//this item is new to the cache, so load the Data
			if ((!oci.Useable || oci.ObjectVersion!=SimPe.Cache.ObjectCacheItemVersions.DockableOW) && nrefitem.FileDescriptor.Type == Data.MetaData.OBJD_FILE)
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
				/*if (objd.Type == Data.ObjectTypes.Normal && objd.CTSSInstance==0) 
				{
					oci.Useable = false;						
					return true;
				}*/

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

				if (oci.Name=="") oci.Name = objd.FileName;

				//now the ModeName File
				Interfaces.Scenegraph.IScenegraphFileIndexItem[] txtitems = FileTable.FileIndex.FindFile(Data.MetaData.STRING_FILE, nrefitem.LocalGroup, 0x85, null);
				if (txtitems.Length>0) 
				{
					SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str(2);
					str.ProcessData(txtitems[0]);
					SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
					if (items.Length>1) oci.ModelName = items[1].Title;
				}

				ObjectReader.changedcache = true;
			} //if not loaded from objd

			if ((!oci.Useable || oci.ObjectVersion!=SimPe.Cache.ObjectCacheItemVersions.DockableOW) && nrefitem.FileDescriptor.Type != Data.MetaData.OBJD_FILE)
			{
				ConsumeFromXobj(oci, nrefitem, deflang);
			}

			if (oci.Thumbnail==null) 
			{
				oci.Thumbnail = ObjectPreview.GetThumbnail(nrefitem.FileDescriptor.Group, oci.ModelName);	
				
				if (oci.Thumbnail!=null) 
				{
					Wait.Image =oci.Thumbnail;
					ObjectReader.changedcache = true;
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
			
			return true;
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

		public static SimPe.Cache.ObjectCacheItem ObjectCacheItemFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Cache.ObjectCacheItem oci = new SimPe.Cache.ObjectCacheItem();
			
			oci.Class = SimPe.Cache.ObjectClass.Object;
			

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.OBJD_FILE);
			bool first = true;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(pfd, pkg);
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
				{
					if (first || item.FileDescriptor.Instance == 0x41A7 || item.FileDescriptor.Instance == 0x41AF) 
					{
						oci.Tag = item;
						oci.Useable = false;

						ObjectConsumer.DoConsume(oci, null, Helper.WindowsRegistry.LanguageCode);

						first = false;
					}
				}
			}
				
			return oci;
		}

		public void LoadData()
		{
			Wait.SubStart();
			FileTable.FileIndex.Load();
			
			ObjectReader erz = new ObjectReader();
			ObjectConsumer ver1 = new ObjectConsumer(erz);
			//ObjectConsumer ver2 = new ObjectConsumer(erz);

			ver1.LoadedItem += new LoadItemHandler(ver1_LoadedItem);
			//ver2.LoadedItem += new LoadItemHandler(ver1_LoadedItem);
			erz.Finished += new EventHandler(erz_Finished);
			Thread te = new Thread(new ThreadStart(erz.start));
			Thread tv1 = new Thread(new ThreadStart(ver1.start));
			//Thread tv2 = new Thread(new ThreadStart(ver2.start));
			te.Name = "Object Loader: Producer";
			tv1.Name = "Object Loader: Consumer";
			te.Start();
			tv1.Start();	
		}

		private void ver1_LoadedItem(SimPe.Cache.ObjectCacheItem oci, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii, SimPe.Data.Alias a)
		{
			if (LoadedItem!=null) LoadedItem(oci, fii, a);
		}

		private void erz_Finished(object sender, EventArgs e)
		{
			Wait.SubStop();
			if (Finished!=null) Finished(this, new System.EventArgs());
		}        

		public static TreeNode GetParentNode(TreeNodeCollection nodes, string[] names, int id, SimPe.Cache.ObjectCacheItem oci, SimPe.Data.Alias a, ImageList ilist)
		{	
			TreeNode ret = null;
			if (id<names.Length) 
			{	
				string name = names[id];
				//does the nodes list already contain a Node with this Name?
				foreach (TreeNode tn in nodes) 
				{
					if (tn.Text.Trim().ToLower() == name.Trim().ToLower())
					{
						ret = tn;
						if (id<names.Length-1) 
							ret = GetParentNode(tn.Nodes, names, id+1, oci, a, ilist);

						if (ret==null) ret = tn;

						break;
					}
				}
			}

			//no Node with this Name found so far, create one
			if (ret==null) 
			{
				if (id<names.Length) ret = new TreeNode(names[id]);
				else ret = new TreeNode(SimPe.Localization.GetString("Unknown"));

				nodes.Add(ret);
				ret.SelectedImageIndex = 0;
				ret.ImageIndex = 0;

				if (id<names.Length-1) 
					ret = GetParentNode(ret.Nodes, names, id+1, oci, a, ilist);
			}

			if (id==0) 
			{
				TreeNode tn = new TreeNode(a.ToString());
				tn.Tag = a;

				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag;
				string flname = "";
				if (fii.Package!=null)
					if (fii.Package.FileName!=null)
						flname = fii.Package.FileName.Trim().ToLower();

                if (flname.StartsWith(PathProvider.Global.SimSavegameFolder.Trim().ToLower())) 
				{
					tn.ImageIndex = 2;
				}
				else if (oci.Thumbnail!=null) 
				{
					Image img = oci.Thumbnail;
					//if (Helper.WindowsRegistry.GraphQuality) img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new System.Drawing.Point(0,0), System.Drawing.Color.Magenta);
					img = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, ilist.ImageSize.Width, ilist.ImageSize.Height, Helper.WindowsRegistry.GraphQuality);

					ilist.Images.Add(img);
					tn.ImageIndex = ilist.Images.Count-1;					
				}
				else
					tn.ImageIndex = 1;
				tn.SelectedImageIndex = tn.ImageIndex;
				ret.Nodes.Add(tn);
			}
			return ret;
		}
	}
}
