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


namespace SimPe.Plugin
{
	/// <summary>
	/// This basically is a Class describing the Wants
	/// </summary>
	public class WantInformation 
	{
		XWant wnt;
		SimPe.PackedFiles.Wrapper.Str str;
		SimPe.PackedFiles.Wrapper.Picture primicon;
		uint guid;
		internal string prefix="";

		static Hashtable wantcache;

		/// <summary>
		/// Use WantInformation::LoadWant() to create a new Instance
		/// </summary>
		/// <param name="guid">The guid of the Want</param>
		WantInformation(uint guid)
		{
			this.guid = guid;
			
			wnt = WantLoader.GetWant(guid);
			str = WantLoader.LoadText(wnt);
			primicon = WantLoader.LoadIcon(wnt);				 	
		}

		/// <summary>
		/// Load Informations about a specific Want
		/// </summary>
		/// <param name="guid">The GUID of the want</param>
		/// <returns>A Want Information Structure</returns>
		public static WantInformation LoadWant(uint guid) 
		{
			if (wantcache == null) wantcache = new Hashtable();

			if (wantcache.ContainsKey(guid)) 
			{
				WantInformation wf = (WantInformation)wantcache[guid];
				return wf;
			}  
			else 
			{
				WantInformation wf = new WantInformation(guid);
				wantcache[guid] = wf;
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
		public string Name 
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
		public System.Drawing.Image Icon
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
		/// Loads the Text Package File
		/// </summary>
		static void LoadTextPackage()
		{
			bool running = WaitingScreen.Running;
			WaitingScreen.Wait();
			txtpkg = new SimPe.Packages.File(System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res\\Text\\Wants.package"));

			if (Helper.WindowsRegistry.EPInstalled==0x01) 
			{
				SimPe.Packages.File txtpkg2 = new SimPe.Packages.File(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, "TSData\\Res\\Text\\Wants.package"));			
				txtpkg2.Persistent = true;
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in txtpkg2.Index)
				{
					pfd.UserData = txtpkg2.Read(pfd).UncompressedData;
					txtpkg.Add(pfd);
				}
				txtpkg2.Persistent = false;				
			}
			if (!running) WaitingScreen.Stop();
		}

		/// <summary>
		/// Load the available Wants
		/// </summary>
		static void LoadWants()
		{
			bool running = WaitingScreen.Running;
			WaitingScreen.Wait();
			wants = new Hashtable();

			FileTable.FileIndex.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] wtss = FileTable.FileIndex.FindFile(Data.MetaData.XWNT, true);

			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem wts in wtss)
			{
				wants[wts.FileDescriptor.Instance] = wts;
			}

			if (!running) WaitingScreen.Stop();
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

			Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(wnt.IconFileDescriptor);
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
