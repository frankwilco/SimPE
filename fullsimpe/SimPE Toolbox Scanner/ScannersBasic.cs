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
using SimPe.Cache;
using SimPe.PackedFiles.Wrapper;
using System.Collections;
using SimPe.Interfaces.Plugin.Scanner;
using SimPe.Plugin;

namespace SimPe.Plugin.Scanner
{
	/// <summary>
	/// Abstract Base class for all Scanners
	/// </summary>
	public abstract class AbstractScanner 
	{
		public delegate void UpdateList(bool savecache, bool rescan);

		#region Static Methods
		static System.Drawing.Size sz;
		/// <summary>
		/// Returns the suggested Size for Thumbnails
		/// </summary>
		public static System.Drawing.Size ThumbnailSize 
		{
			get 
			{
				if (sz.Width == 0) sz =  new System.Drawing.Size(96, 96);
				return sz;
			}
		}

		/// <summary>
		/// Add a new Column to a ListView
		/// </summary>
		/// <param name="lv"></param>
		/// <param name="name"></param>
		public static void AddColumn(System.Windows.Forms.ListView lv, string name, int width) 
		{
			System.Windows.Forms.ColumnHeader ch = new System.Windows.Forms.ColumnHeader();
			ch.Text = name;
			lv.Columns.Add(ch);

			if (width>0) ch.Width = width;
		}

		
		/// <summary>
		/// Set the Name and color of a Column
		/// </summary>
		/// <param name="lvi">The ListViewItem where you want to add that column</param>
		/// <param name="index">The Index of the Column</param>
		/// <param name="name">The Name you want to display</param>
		public static void SetSubItem(System.Windows.Forms.ListViewItem lvi, int index, string name) 
		{
			SetSubItem(lvi, index, name, lvi.ForeColor);
		}

		/// <summary>
		/// Set the Name and color of a Column
		/// </summary>
		/// <param name="lvi">The ListViewItem where you want to add that column</param>
		/// <param name="index">The Index of the Column</param>
		/// <param name="name">The Name you want to display</param>
		/// <param name="ps">If state is null, the default color is used, false will be red, true will be green</param>
		public static void SetSubItem(System.Windows.Forms.ListViewItem lvi, int index, string name, SimPe.Cache.PackageState ps) 
		{
			System.Drawing.Color cl = lvi.ForeColor;
			if (ps!=null) 
			{
				if (ps.State == SimPe.Cache.TriState.True) cl = System.Drawing.Color.Green;
				else if (ps.State == SimPe.Cache.TriState.False) cl = System.Drawing.Color.Red;							
			}

			SetSubItem(lvi, index, name, cl);
		}

		/// <summary>
		/// Set the Name and color of a Column
		/// </summary>
		/// <param name="lvi">The ListViewItem where you want to add that column</param>
		/// <param name="index">The Index of the Column</param>
		/// <param name="name">The Name you want to display</param>
		/// <param name="cl">The Color for this Item</param>
		public static void SetSubItem(System.Windows.Forms.ListViewItem lvi, int index, string name, System.Drawing.Color cl) 
		{
			if (cl==System.Drawing.Color.Red) lvi.ForeColor = cl;
			while (lvi.SubItems.Count<=index) lvi.SubItems.Add("");
			lvi.SubItems[index].Text = name;
			lvi.SubItems[index].ForeColor = cl;
		}

		#endregion

		#region IScannerPluginBase Member
		public ScannerPluginType PluginType 
		{
			get { return ScannerPluginType.Scanner; }
		}
		#endregion

		#region FileIndex Addition
		static SimPe.Interfaces.Scenegraph.IScenegraphFileIndex  mfi;
		/// <summary>
		/// Returns a FileTable, that is unly used for the event of scanning Files, and will be removed from the global FileTable afterwards
		/// </summary>
		public static SimPe.Interfaces.Scenegraph.IScenegraphFileIndex MyFileIndex 
		{
			get 
			{
				if (mfi==null) AssignFileTable();
				return mfi;
			}
		}		

		public static void AssignFileTable()
		{
			DeAssignFileTable();
			if (mfi==null) mfi = FileTable.FileIndex.AddNewChild();
			else FileTable.FileIndex.AddChild(mfi);
		}

		public static void DeAssignFileTable()
		{
			if (mfi!=null) 
			{
				FileTable.FileIndex.RemoveChild(mfi);
				mfi.Clear();
				mfi.ClearChilds();
			}
			
			mfi = null;
		}

		protected SimPe.Interfaces.Scenegraph.IScenegraphFileIndex FileIndex
		{
			get {return MyFileIndex;}
		}
		#endregion

		#region IScanner Implementations		

		uint uid;
		/// <summary>
		/// Returns the uid assigned to this specific Scanner
		/// </summary>
		/// <remarks>
		/// the uid is calulated using the Filename, class name, namespace 
		/// and visible Name of the Scanner. Changing either one of the, will 
		/// result in a new uid and force a rescan of the State
		/// </remarks>
		public uint Uid
		{
			get { return uid; }
		}

		/// <summary>
		/// Returns true, if this Scanner should be listed on the Top of the List
		/// </summary>
		public virtual bool OnTop
		{
			get { return false; }
		}

		int startcolumn;
		/// <summary>
		/// Returns the first Colum in the Listview that was used for this Scanner
		/// </summary>
		protected int StartColum 
		{
			get { return startcolumn; }
		}

		System.Windows.Forms.ListView lv;
		/// <summary>
		/// Returns the ListView that was assigned to this Scanner
		/// </summary>
		protected System.Windows.Forms.ListView ListView 
		{
			get { return lv; }
		}

		

		protected AbstractScanner() 
		{
			byte[] b = Helper.ToBytes(this.UniqueName);
			this.uid = BitConverter.ToUInt32(Hashes.Crc32.ComputeHash(b, 0 , b.Length), 0);
			this.startcolumn = 0;			
		}

		public void InitScan(System.Windows.Forms.ListView lv)
		{
			this.lv = lv;
			this.startcolumn = lv.Columns.Count;
			DoInitScan();
		}

		public virtual bool IsActiveByDefault
		{
			get { return false; }
		}

		System.Windows.Forms.Control mycontrol;
		public virtual System.Windows.Forms.Control OperationControl
		{
			get 
			{
					if (mycontrol==null) mycontrol = CreateOperationControl();
					return mycontrol;
			}
		}

		public void EnableControl(bool active)
		{
			EnableControl(new ScannerItem[0], active);
		}

		public void EnableControl(ScannerItem item, bool active)
		{
			if (item!=null) 
			{
				ScannerItem[] items = new ScannerItem[1];
				items[0] = item;

				EnableControl(items, active);
			} else EnableControl(new ScannerItem[0], active);
		}

		public virtual void EnableControl(ScannerItem[] items, bool active)
		{
			if (OperationControl!=null) OperationControl.Enabled = active;
		}

		SimPe.Plugin.Scanner.AbstractScanner.UpdateList finishcallback;
		/// <summary>
		/// Retunrs the Function that should be called after a OperatioControl Execution (can be null);
		/// </summary>
		protected SimPe.Plugin.Scanner.AbstractScanner.UpdateList CallbackFinish 
		{
			get {return finishcallback;}
		}

		public void SetFinishCallback(SimPe.Plugin.Scanner.AbstractScanner.UpdateList fkt)
		{
			finishcallback = fkt;
		}
		#endregion

		protected string UniqueName
		{
			get 
			{
				Type t = GetType();
				string[] parts = t.Assembly.FullName.Split(",".ToCharArray(), 2);

				string ret = ToString()+";"+t.Namespace+"."+t.Name+".";
				if (parts.Length>0) ret += ";"+parts[0];

				return ret;
			}
		}
			

		protected virtual System.Windows.Forms.Control CreateOperationControl()
		{
			return null;
		}
		protected abstract void DoInitScan();
	}

	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class NameScanner : AbstractScanner, IScanner
	{
		public NameScanner () : base () {}

		
		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 100; }
		}
		#endregion

		#region IScanner Member
		public override bool OnTop
		{
			get { return true; }
		}

		protected override void DoInitScan()
		{
			AbstractScanner.AddColumn(ListView, "Caption", 180);
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{
			ps.State = TriState.False;
			si.PackageCacheItem.Name = Localization.Manager.GetString("unknown");

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.CTSS_FILE);
			if (pfds.Length==0) pfds = si.Package.FindFiles(Data.MetaData.STRING_FILE);

			//Check for Str compatible Items
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfds[0], si.Package, false);

				SimPe.PackedFiles.Wrapper.StrItemList list = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
				foreach (SimPe.PackedFiles.Wrapper.StrItem item in list) 
				{
					if (item.Title.Trim()!="") 
					{
						ps.State = TriState.True;
						si.PackageCacheItem.Name = item.Title;
						break;
					}
				}
			} 
			else 
			{
				pfds = si.Package.FindFiles(Data.MetaData.GZPS);
				if (pfds.Length==0) pfds = si.Package.FindFiles(0xCCA8E925); //Object XML
				if (pfds.Length==0) pfds = si.Package.FindFiles(Data.MetaData.MMAT);

				//Check for Cpf compatible Items
				if (pfds.Length>0) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfds[0], si.Package, false);

					si.PackageCacheItem.Name = cpf.GetSaveItem("name").StringValue;
					if (si.PackageCacheItem.Name.Trim()!="") ps.State = TriState.True;
				}
			}

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{			
			AbstractScanner.SetSubItem(lvi, this.StartColum, si.PackageCacheItem.Name);
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return true; }
		}
		
		#endregion

		public override string ToString()
		{
			return "Caption Scanner";
		}
	}

	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class ImageScanner : AbstractScanner, IScanner
	{
		public ImageScanner () : base () { }

		
		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 200; }
		}
		#endregion

		#region IScanner Member
		public override bool OnTop
		{
			get { return true; }
		}

		protected override void DoInitScan()
		{
			ListView.SmallImageList = ListView.LargeImageList;
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{
			System.Drawing.Size sz = AbstractScanner.ThumbnailSize;
			if (si.PackageCacheItem.Type == PackageType.Object || si.PackageCacheItem.Type == PackageType.MaxisObject || si.PackageCacheItem.Type == PackageType.Recolor) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.OBJD_FILE);
					
				uint group = 0;
				if (pfds.Length>0) group = pfds[0].Group;

				if (group==Data.MetaData.LOCAL_GROUP) 
				{
					SimPe.Interfaces.Wrapper.IGroupCacheItem gci = FileTable.GroupCache.GetItem(si.FileName);
					if (gci!=null) group = gci.LocalGroup;					
				}
				string[] modelnames = SimPe.Plugin.Scenegraph.FindModelNames(si.Package);

				foreach (string modelname in modelnames) 
				{                    
                    System.Drawing.Image img = SimPe.Plugin.Workshop.GetThumbnail(group, modelname);
					if (img!=null) 
					{
						si.PackageCacheItem.Thumbnail = img;
						ps.State = TriState.True;
						break;
					}
				}
			}

			//no Thumbnail, do we have a Image File?
			if ( ps.State == TriState.Null) 
			{
				SimPe.PackedFiles.Wrapper.Picture pic = new Picture();
				uint[] types = pic.AssignableTypes;
				foreach (uint type in types) 
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(type);
					if (pfds.Length>0) 
					{
						//get image with smallest Instance
						SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor p in pfds) if (p.Instance<pfd.Instance) pfd = p;						

						pic.ProcessData(pfd, si.Package, false);

						si.PackageCacheItem.Thumbnail = pic.Image;
						if (si.PackageCacheItem.Thumbnail!=null) 
						{
							si.PackageCacheItem.Thumbnail = ImageLoader.Preview(si.PackageCacheItem.Thumbnail, sz);
							ps.State = TriState.True;
						}

						break;
					}
				} //foreach
			}
			
			//no Thumbnail generated by the Game?
			if ( ps.State == TriState.Null) 
			{
				//load the Texture Image
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.TXTR);
				if (pfds.Length>0) 
				{
					SimPe.Plugin.GenericRcol rcol = new GenericRcol(null, false);

					//get biggest texture
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
					foreach (SimPe.Interfaces.Files.IPackedFileDescriptor p in pfds) if (p.Size>pfd.Size) pfd = p;
					
					rcol.ProcessData(pfd, si.Package, false);

					SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)rcol.Blocks[0];
					
					SimPe.Plugin.MipMap mm = id.GetLargestTexture(sz);

					if (mm.Texture!=null) 
					{
						si.PackageCacheItem.Thumbnail = ImageLoader.Preview(mm.Texture, sz);
						ps.State = TriState.True;
					}

					rcol.Dispose();
				}
			}

			if (si.PackageCacheItem.Thumbnail!=null) WaitingScreen.UpdateImage(si.PackageCacheItem.Thumbnail);
			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{			
			//Add the Thumbnail if available
			if (si.PackageCacheItem.Thumbnail!=null) 
			{
				ListView.SmallImageList.Images.Add(si.PackageCacheItem.Thumbnail);
				lvi.ImageIndex = ListView.SmallImageList.Images.Count-1;
			}
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return true; }
		}		
		#endregion

		public override string ToString()
		{
			return "Thumbnail Scanner";
		}
	}

	/// <summary>
	/// This class is retriving the Name of a Package
	/// </summary>
	internal class GuidScanner : AbstractScanner, IScanner
	{
		static SimPe.Cache.MemoryCacheFile cachefile;
		public GuidScanner () : base () { }

		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 300; }
		}
		#endregion

		#region IScanner Member

		Hashtable list;
		protected override void DoInitScan()
		{
			if (list==null) list = new Hashtable();
			else list.Clear();

			if (cachefile==null) 
			{
				cachefile = MemoryCacheFile.InitCacheFile();
				cachefile.Save();
				cachefile.Dispose();
				GC.Collect();
				GC.WaitForPendingFinalizers();
				cachefile = null;
				cachefile = MemoryCacheFile.InitCacheFile();
			}
			
			AbstractScanner.AddColumn(ListView, "GUIDs", 180);
			AbstractScanner.AddColumn(ListView, "Duplicate GUID", 80);
			AbstractScanner.AddColumn(ListView, "First found", 80);

			foreach (MemoryCacheItem mci in cachefile.List) 
			{
				string flname = null;
				if (mci.ParentCacheContainer==null)  
					flname = mci.FileDescriptor.Filename;
				else
					flname = mci.ParentCacheContainer.FileName;				
				list[(uint)mci.Guid] = flname.Trim().ToLower();
				/*if (mci.Guid == guid) 
				{
					if (mci.ParentCacheContainer!=null) 
					{
						if (mci.ParentCacheContainer.FileName.Trim().ToLower() != flname) 
						{ 
							ps.State = TriState.False;
							break;
						}
					}
				}*/
			}
		}


		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.OBJD_FILE);
			ArrayList mylist = new ArrayList();
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.PackedFiles.Wrapper.ExtObjd objd = new ExtObjd(null);
				objd.ProcessData(pfd, si.Package, false);				

				mylist.Add(objd.Guid);
				objd.Dispose();
			}

			uint[] guids = new uint[mylist.Count];
			mylist.CopyTo(guids);
			si.PackageCacheItem.Guids = guids;
			ps.State = TriState.True;

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{	
			ps.State = TriState.True;
			string guids = "";
			string ff = SimPe.Localization.Manager.GetString("unknown");
			foreach (uint guid in si.PackageCacheItem.Guids) 
			{
				string flname = si.FileName.Trim().ToLower();
				if (guids!="") guids += ", ";
				guids += "0x"+Helper.HexString(guid);

				/*foreach (MemoryCacheItem mci in cachefile.List) 
				{
					if (mci.Guid == guid) 
					{
						if (mci.ParentCacheContainer!=null) 
						{
							if (mci.ParentCacheContainer.FileName.Trim().ToLower() != flname) 
							{ 
								ps.State = TriState.False;
								break;
							}
						}
					}
				}*/

				string fl = si.Package.FileName.Trim().ToLower();
				if (list.ContainsKey(guid)) 
				{ 		
					string cmp = (string)list[guid];
					if (cmp!=fl) 
					{
						ps.State = TriState.False;
						ff = cmp;
					}
					else ps.State = TriState.True;
				} 
				else 
				{
					list.Add(guid, fl);
				}
			}

			string text = "no";
			if (ps.State == TriState.False) text = "yes";

			AbstractScanner.SetSubItem(lvi, this.StartColum, guids);	
			AbstractScanner.SetSubItem(lvi, this.StartColum+1, text, ps);	
			AbstractScanner.SetSubItem(lvi, this.StartColum+2, ff);	
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return false; }
		}		
		#endregion

		public override string ToString()
		{
			return "GUID Scanner";
		}
	}

	/// <summary>
	/// This class checks if the Base CRES for the Recolor is still available
	/// </summary>
	internal class RecolorBasemeshScanner : AbstractScanner, IScanner
	{
		static SimPe.Cache.MemoryCacheFile cachefile;

		public RecolorBasemeshScanner () : base () {		
		}

		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 900; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{
			if (cachefile==null) cachefile = MemoryCacheFile.InitCacheFile();
			
			AbstractScanner.AddColumn(ListView, "Found Base", 180);
		}


		
		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.MMAT);
			//ArrayList list = new ArrayList();

			ps.State = TriState.True;
			//FileTable.FileIndex.StoreCurrentState();
			if (!FileTable.FileIndex.ContainsPath(System.IO.Path.GetDirectoryName(si.FileName)))
				FileIndex.AddIndexFromFolder(System.IO.Path.GetDirectoryName(si.FileName));

			FileIndex.AddIndexFromPackage(si.Package);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.Plugin.MmatWrapper mmat = new MmatWrapper();
				mmat.ProcessData(pfd, si.Package, false);

				string m = mmat.ModelName.Trim().ToLower();
				if (!m.EndsWith("_cres")) m += "_cres";

				//Add the current package				
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = FileTable.FileIndex.FindFileByName(m, Data.MetaData.CRES, Data.MetaData.LOCAL_GROUP, true);				

				if (item==null) ps.State = TriState.False;

				item = null;
				mmat.Dispose();
				m = null;
			}		
			//FileTable.FileIndex.RestoreLastState();	

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{	
			

			string text = "yes";
			if (ps.State == TriState.False) text = "no";
			AbstractScanner.SetSubItem(lvi, this.StartColum, text, ps);		
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return false; }
		}		
		#endregion

		public override string ToString()
		{
			return "Recolor-Basemesh Scanner";
		}
	}


	/// <summary>
	/// This class checks if the Base CRES for the Recolor is still available
	/// </summary>
	internal class MeshScanner : AbstractScanner, IScanner
	{
		static SimPe.Cache.MemoryCacheFile cachefile;

		public MeshScanner () : base () 
		{		
		}

		#region IScannerBase Member
		public uint Version 
		{
			get { return 1; }
		}

		public int Index 
		{
			get { return 850; }
		}
		#endregion

		#region IScanner Member

		protected override void DoInitScan()
		{			
			AbstractScanner.AddColumn(ListView, "Vertices", 60);
			AbstractScanner.AddColumn(ListView, "Faces", 60);
		}


		
		public void ScanPackage(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = si.Package.FindFiles(Data.MetaData.GMDC);
			//ArrayList list = new ArrayList();

			ps.State = TriState.True;			
			
			uint fct = 0; uint vct = 0;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.Plugin.Rcol rcol = new GenericRcol();
				rcol.ProcessData(pfd, si.Package, true);

				SimPe.Plugin.GeometryDataContainer gmdc = rcol.Blocks[0] as SimPe.Plugin.GeometryDataContainer;
				foreach (SimPe.Plugin.Gmdc.GmdcGroup g in gmdc.Groups)
				{
					fct += (uint)g.FaceCount;
					vct += (uint)g.UsedVertexCount;
				}
				rcol.Dispose();
			}		
			ps.Data = new uint[] {vct, fct};	

			UpdateState(si, ps, lvi);
		}

		public void UpdateState(ScannerItem si, SimPe.Cache.PackageState ps, System.Windows.Forms.ListViewItem lvi)
		{	
			uint fct = ps.Data[1];
			uint vct = ps.Data[0];
			AbstractScanner.SetSubItem(lvi, this.StartColum, vct.ToString(), ps);		
			AbstractScanner.SetSubItem(lvi, this.StartColum+1, fct.ToString(), ps);	
		}

		public void FinishScan() { }

		public override bool IsActiveByDefault
		{
			get { return false; }
		}		
		#endregion

		public override string ToString()
		{
			return "Mesh Scanner";
		}
	}

	
}
