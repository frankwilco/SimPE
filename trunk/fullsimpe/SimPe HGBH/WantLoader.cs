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
using System.Collections;
using SimPe.Interfaces.Plugin;
using System.Windows.Forms;
using SimPe.Cache;


namespace SimPe.Plugin
{
	/// <summary>
	/// This basically is a Class describing the Wants (loaded from the Cache)
	/// </summary>
	public class WantCacheInformation  : WantInformation
	{
		/// <summary>
		/// Use WantInformation::LoadWant() to create a new Instance
		/// </summary>
		/// <param name="guid">The guid of the Want</param>
		WantCacheInformation(uint guid):base(guid)
		{
			name = "";
		}

		/// <summary>
		/// Use WantInformation::LoadWant() to create a new Instance
		/// </summary>
		WantCacheInformation():base()
		{
			name = "";
		}

		/// <summary>
		/// Load Informations about a specific Want
		/// </summary>
		/// <param name="guid">The GUID of the want</param>
		/// <returns>A Want Information Structure</returns>
		public static WantCacheInformation LoadWant(SimPe.Cache.WantCacheItem wci) 
		{
			WantCacheInformation ret = new WantCacheInformation();
			ret.icon = wci.Icon;
			ret.name = wci.Name;
			ret.guid = wci.Guid;

			XWant w = new XWant();
			SimPe.PackedFiles.Wrapper.CpfItem i = new SimPe.PackedFiles.Wrapper.CpfItem(); i.Name = "id"; i.UIntegerValue = wci.Guid; w.AddItem(i, true);
			i = new SimPe.PackedFiles.Wrapper.CpfItem(); i.Name = "folder"; i.StringValue = wci.Folder; w.AddItem(i, true);
			i = new SimPe.PackedFiles.Wrapper.CpfItem(); i.Name = "score"; i.IntegerValue = wci.Score; w.AddItem(i, true);
			i = new SimPe.PackedFiles.Wrapper.CpfItem(); i.Name = "influence"; i.IntegerValue = wci.Influence; w.AddItem(i, true);
			i = new SimPe.PackedFiles.Wrapper.CpfItem(); i.Name = "objectType"; i.StringValue = wci.ObjectType; w.AddItem(i, true);

			ret.wnt = w;
			
			return ret;
		}

		System.Drawing.Image icon;
		public override System.Drawing.Image Icon
		{
			get
			{
				return icon;
			}
		}

		string name;
		public override string Name
		{
			get
			{
				return name;
			}
		}

	}

	/// <summary>
	/// This basically is a Class describing the Wants
	/// </summary>
	public class WantInformation 
	{
		protected XWant wnt;
		SimPe.PackedFiles.Wrapper.Str str;
		SimPe.PackedFiles.Wrapper.Picture primicon;
		protected uint guid;
		internal string prefix="";

		static Hashtable wantcache;

		/// <summary>
		/// Use WantInformation::LoadWant() to create a new Instance
		/// </summary>
		protected WantInformation() 
		{
		}

		/// <summary>
		/// Use WantInformation::LoadWant() to create a new Instance
		/// </summary>
		/// <param name="guid">The guid of the Want</param>
		protected WantInformation(uint guid)
		{
			this.guid = guid;
			
			wnt = WantLoader.GetWant(guid);
			str = WantLoader.LoadText(wnt);
			primicon = WantLoader.LoadIcon(wnt);				 				
		}

		#region Cache 
		static WantCacheFile cachefile;

		static void LoadCache()
		{
			if (cachefile!=null) return;

			cachefile = new WantCacheFile();
            Wait.SubStart();
            Wait.Message = "Loading Cache";
			if (!Helper.WindowsRegistry.UseCache) return;
			try 
			{
				cachefile.Load(Helper.SimPeLanguageCache, true);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
            Wait.SubStop();
		}

		/// <summary>
		/// Save the Cache to the FileSystem
		/// </summary>
		public static void SaveCache()
		{
			if (!Helper.WindowsRegistry.UseCache) return;
			if (cachefile==null) return;

            Wait.SubStart();
            Wait.Message = "Saveing Cache";
			cachefile.Save(Helper.SimPeLanguageCache);
            Wait.SubStop();
		}
		#endregion

		/// <summary>
		/// Load Informations about a specific Want
		/// </summary>
		/// <param name="guid">The GUID of the want</param>
		/// <returns>A Want Information Structure</returns>
		public static WantInformation LoadWant(uint guid) 
		{
			LoadCache();
			if (wantcache == null) wantcache = cachefile.Map;

			if (wantcache.ContainsKey(guid)) 
			{
				object o = wantcache[guid];
				WantInformation wf;
				if (o.GetType()==typeof(WantInformation)) 
					 wf = (WantInformation)o;
				else 
					wf = WantCacheInformation.LoadWant((WantCacheItem)o);

				return wf;
			}  
			else 
			{
				WantInformation wf = new WantInformation(guid);
				wantcache[guid] = wf;
				cachefile.AddItem(wf);
				return wf;
			}
		}

		/// <summary>
		/// Returns the XWant File
		/// </summary>
		public XWant XWant 
		{
			get {return wnt;}
			
		}

		/// <summary>
		/// Returns the Name of this Want
		/// </summary>
		public virtual string Name 
		{
			get 
			{
				if (str==null) return "0x"+Helper.HexString(guid);
				return str.FallbackedLanguageItem(Helper.WindowsRegistry.LanguageCode, 0).Title;
			}
		}

		/// <summary>
		/// Returns Icon for this want or null
		/// </summary>
		public virtual System.Drawing.Image Icon
		{
			get 
			{
				if (primicon==null) return null;
				return primicon.Image;
			}
		}

		/// <summary>
		/// The guid of the current Want
		/// </summary>
		public uint Guid 
		{
			get { return guid; }
		}

		public override string ToString()
		{
			return prefix+Name;
		}


	}

	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class WantLoader
	{
		static Hashtable wants = null;
		static SimPe.Packages.File txtpkg = null;
		static WantNameLoader wnl;

		/// <summary>
		/// Returns a Hashtable of all available Wants
		/// </summary>
		/// <remarks>key is the want GUID, value is a XWant object</remarks>
		public static Hashtable Wants 
		{
			get 
			{
				if (wants==null) LoadWants();
				return wants;
			}
		}

		/// <summary>
		/// Returns a WantNameLoader ou can use to determin Names
		/// </summary>
		public static WantNameLoader WantNameLoader 
		{
			get 
			{
				if (wnl==null) wnl = new WantNameLoader();
				return wnl;
			}
		}

		/// <summary>
		/// Loads the Text Package File
		/// </summary>
		static void LoadTextPackage()
		{
            Wait.SubStart();
			txtpkg = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(SimPe.PathProvider.Global[Expansions.BaseGame].InstallFolder, "TSData\\Res\\Text\\Wants.package"));

            foreach (ExpansionItem ei in PathProvider.Global.Expansions) {
                if (ei.Exists && ei.Flag.LoadWantText)
                {
                    SimPe.Packages.File txtpkg2 = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(ei.InstallFolder, "TSData\\Res\\Text\\Wants.package"));
                    txtpkg2.Persistent = true;
                    foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in txtpkg2.Index)
                    {
                        pfd.UserData = txtpkg2.Read(pfd).UncompressedData;
                        txtpkg.Add(pfd);
                    }
                    txtpkg2.Persistent = false;	                    
                }
        }

        Wait.SubStop();
		}

		/// <summary>
		/// Load the available Wants
		/// </summary>
		static void LoadWants()
		{
            Wait.SubStart();
			wants = new Hashtable();

			FileTable.FileIndex.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] wtss = FileTable.FileIndex.FindFile(Data.MetaData.XWNT, true);

			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem wts in wtss)
			{
				wants[wts.FileDescriptor.Instance] = wts;
			}

            Wait.SubStop();
		}

		/// <summary>
		/// Returns a XWAnt File for this Item or null
		/// </summary>
		/// <param name="guid">The GUID of the Want</param>
		/// <returns>The Xant Object representing That want (or null if not found)</returns>
		public static XWant GetWant(uint guid)
		{
			if (wants==null) LoadWants();

			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem wts = (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)wants[guid];
			if (wts!=null) 
			{
				XWant xwnt = new XWant();
				wts.FileDescriptor.UserData = wts.Package.Read(wts.FileDescriptor).UncompressedData;
				xwnt.ProcessData(wts);

				return xwnt;
			}

			return null;
		}

		/// <summary>
		/// Returns the String File describing that want
		/// </summary>
		/// <param name="wnt">The Want File</param>
		/// <returns>The Str File or null if none was found</returns>
		public static SimPe.PackedFiles.Wrapper.Str LoadText(XWant wnt)
		{
			if (wnt==null) return null;
			if (txtpkg==null) LoadTextPackage();

			Interfaces.Files.IPackedFileDescriptor[] pfds = txtpkg.FindFile(Data.MetaData.STRING_FILE, 0, wnt.StringInstance);
			if (pfds.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				pfds[0].UserData = txtpkg.Read(pfds[0]).UncompressedData;
				str.ProcessData(pfds[0], txtpkg);

				return str;
			}

			return null;
		}	
	
		/// <summary>
		/// Returns the Icon File for the passed Want
		/// </summary>
		/// <param name="wnt">The Want File</param>
		/// <returns>The Picture File or null if none was found</returns>
		public static SimPe.PackedFiles.Wrapper.Picture LoadIcon(XWant wnt)
		{
			if (wnt==null) return null;
			if (txtpkg==null) LoadTextPackage();

			Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(wnt.IconFileDescriptor, null);
			if (items.Length>0) 
			{
				SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
				items[0].FileDescriptor.UserData = items[0].Package.Read(items[0].FileDescriptor).UncompressedData;
				pic.ProcessData(items[0]);

				return pic;
			}
			return null;
		}
	}

}
