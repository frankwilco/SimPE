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
using SimPe.Events;
using System.Windows.Forms;
using SimPe.Collections;

namespace SimPe
{
	

	/// <summary>
	/// Used to load Packages from the FileSystem
	/// </summary>
	public class LoadedPackage : System.IDisposable
	{		
		

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		public LoadedPackage()
		{
			
		}

		/// <summary>
		/// Maximum Number of Characters in the Recent File Menu
		/// </summary>
		const int MAX_FILENAME_LENGTH=75;

		

		#region Events
		/// <summary>
		/// Called when a Recent File should be loaded
		/// </summary>
		public event PackageFileLoadEvent BeforeRecentFileLoad;
		/// <summary>
		/// Called after a Recent File was sucesfully Loaded
		/// </summary>
		public event PackageFileLoadedEvent AfterRecentFileLoad;
		/// <summary>
		/// Called when a File should be saved
		/// </summary>
		public event PackageFileSaveEvent BeforeFileSave;
		/// <summary>
		/// Called after a File was sucesfully SAved
		/// </summary>
		public event PackageFileSavedEvent AfterFileSave;
		/// <summary>
		/// Called before any File is loaded
		/// </summary>
		public event PackageFileLoadEvent BeforeFileLoad;
		/// <summary>
		/// Called before any File is loaded
		/// </summary>
		public event PackageFileCloseEvent BeforeFileClose;
		/// <summary>
		/// Called After any File was sucesfully loaded
		/// </summary>
		public event PackageFileLoadedEvent AfterFileLoad;
		/// <summary>
		/// Triggered whenever the Content of the Package was changed
		/// </summary>
		public event System.EventHandler IndexChanged;
		/// <summary>
		/// Triggered after a package got Saved somewhere (not necesarry by this class!)
		/// </summary>
		public event System.EventHandler SavedIndex;

		/// <summary>
		/// Triggered whenever a new Resource was added
		/// </summary>
		public event System.EventHandler AddedResource;

		/// <summary>
		/// Triggered whenever a Resource was Removed
		/// </summary>
		public event System.EventHandler RemovedResource;
		#endregion

		SimPe.Packages.GeneratableFile pkg;

		/// <summary>
		/// Returns the current Package or null if it is not loaded
		/// </summary>
		public SimPe.Packages.GeneratableFile Package 
		{
			get { return pkg; }
		}

		/// <summary>
		/// true, if a package was loaded
		/// </summary>
		public bool Loaded
		{
			get { return pkg!=null; }
		}

		/// <summary>
		/// returns an empty string or the FileName of the current package
		/// </summary>
		public string FileName
		{
			get 
			{
				if (pkg==null) return "";
				if (pkg.FileName==null) return "";
				return pkg.FileName;
			}
		}		

		/// <summary>
		/// Make sure the Events get Linked
		/// </summary>
		/// <param name="add">false, if you want to remove linked Events</param>
		void SetupEvents(bool add)
		{			
			if (add) 
			{
				pkg.IndexChanged += new EventHandler(IndexChangedHandler);
				pkg.AddedResource += new EventHandler(AddedResourceHandler);
				pkg.RemovedResource += new EventHandler(RemovedResourcehandler);
				pkg.SavedIndex += new EventHandler(SavedIndexHandler);

				SimPe.Packages.StreamFactory.LockStream(pkg.SaveFileName);
			} 
			else 
			{
				SimPe.Packages.StreamFactory.UnlockStream(pkg.SaveFileName);

				pkg.IndexChanged -= new EventHandler(IndexChangedHandler);
				pkg.AddedResource -= new EventHandler(AddedResourceHandler);
				pkg.RemovedResource -= new EventHandler(RemovedResourcehandler);
				pkg.SavedIndex -= new EventHandler(SavedIndexHandler);
			}
		}

		/// <summary>
		/// Load a File from the Disc
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <returns>true, if the file was loaded</returns>
		public bool LoadFromFile(string flname) 
		{
			return LoadFromFile(flname, true);
		}

		/// <summary>
		/// Load a File from the Disc
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <param name="sync">
		/// Only needed if a PackageMaintainer is used. This will tell the Maintainer, that
		/// it should reload the Package from the Disk, and not only get the Package in Memory
		/// </param>
		/// <returns>true, if the file was loaded</returns>
		public bool LoadFromFile(string flname, bool sync) 
		{
			try 
			{
				FileNameEventArg e = new FileNameEventArg(flname);		
				if (BeforeFileLoad!=null) BeforeFileLoad(this, e);
				if (e.Cancel) return false;
				
				Wait.SubStart();
				Wait.Message = "Loading File";

				if (pkg!=null) this.SetupEvents(false);				

				pkg = SimPe.Packages.File.LoadFromFile(e.FileName, sync);
				if (pkg.Index.Length<Helper.WindowsRegistry.BigPackageResourceCount)
					pkg.LoadCompressedState();
				
				this.SetupEvents(true);					
				Helper.WindowsRegistry.AddRecentFile(flname);

				Wait.SubStop();

				if (AfterFileLoad!=null) AfterFileLoad(this);
				return true;
			} 
			catch (Exception ex)
			{
				SimPe.Helper.ExceptionMessage(ex);
				pkg = null;
				return false;
			}
		}

		/// <summary>
		/// Save the current package
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			if (this.FileName.Trim()=="") return false;
			return Save(this.FileName, false);
		}

		/// <summary>
		/// Save the current package
		/// </summary>
		/// <param name="filname">the new Filename</param>
		/// <param name="savetocopy">true if you want to save to a copy</param>
		/// <returns></returns>
		public bool Save(string filname, bool savetocopy)
		{
			if (!this.Loaded) return false;
			try 
			{			
				FileNameEventArg e = new FileNameEventArg(filname);		
				if (BeforeFileSave!=null) BeforeFileSave(this, e);
				if (e.Cancel) return false;

				Wait.SubStart();
				Wait.Message = "Saving File";

				string oname = this.FileName;
				this.Package.Save(e.FileName);

				if (savetocopy) Package.FileName = oname;

				Helper.WindowsRegistry.AddRecentFile(e.FileName);
				

				Wait.SubStop();

				if (AfterFileSave!=null) AfterFileSave(this);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
				return false;
			}

			return true;
		}		

		/// <summary>
		/// Load another Package
		/// </summary>
		/// <param name="newpkg">the Package that should be the currently opened</param>
		/// <returns>true, if the file was loaded</returns>
		public bool LoadFromPackage(SimPe.Packages.GeneratableFile newpkg) 
		{
			if (newpkg==null) return false;
			string flname = newpkg.FileName;
			if (flname==null) flname="";

			FileNameEventArg e = new FileNameEventArg(flname);		
			if (BeforeFileLoad!=null) BeforeFileLoad(this, e);
			if (e.Cancel) return false;			

			if (pkg!=null) 
			{
				this.SetupEvents(false);	
			}

			pkg = newpkg;
			pkg.LoadCompressedState();			

			if (pkg!=null) 
			{
				this.SetupEvents(true);	
			}

			if (pkg.FileName!=null) Helper.WindowsRegistry.AddRecentFile(pkg.FileName);
			if (AfterFileLoad!=null) AfterFileLoad(this);

			return true;
		}

		/// <summary>
		/// Update the old Provider Infrastructure
		/// </summary>
		public void UpdateProviders()
		{
			if (Helper.IsNeighborhoodFile(FileName) && (Helper.WindowsRegistry.LoadMetaInfo))
			{
				SimPe.Interfaces.Files.IPackageFile pkg = Package;
				try 
				{
					string mname = Helper.GetMainNeighborhoodFile(pkg.SaveFileName);
					if (mname != pkg.SaveFileName)
						pkg = SimPe.Packages.GeneratableFile.LoadFromFile(mname);
				} 
				catch {}
				FileTable.ProviderRegistry.SimFamilynameProvider.BasePackage = pkg;
				FileTable.ProviderRegistry.SimDescriptionProvider.BasePackage = pkg;				
				FileTable.ProviderRegistry.SimNameProvider.BaseFolder = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(FileName), "Characters");
				FileTable.ProviderRegistry.LotProvider.BaseFolder  = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(FileName), "Lots");				
			} 
			else 
			{
				FileTable.ProviderRegistry.SimNameProvider.BaseFolder = "";
				FileTable.ProviderRegistry.SimFamilynameProvider.BasePackage = null;
				FileTable.ProviderRegistry.SimDescriptionProvider.BasePackage = null;
				FileTable.ProviderRegistry.LotProvider.BaseFolder = "";
			}
		}

		/// <summary>
		/// Close the current Package
		/// </summary>
		/// <returns>true, if the Package was closed</returns>
		public bool Close()
		{
			if (pkg!=null) 
			{
				bool res = true;
				if (pkg.HasUserChanges) 
				{
					DialogResult dr = SimPe.Message.Show(
						SimPe.Localization.Manager.GetString("savechanges").Replace("{filename}", FileName), 
						SimPe.Localization.Manager.GetString("savechanges?"),
						MessageBoxButtons.YesNoCancel);

					if (dr==DialogResult.Yes) res = Save();
					else if (dr==DialogResult.Cancel) return false;
				}
				if (res) 
				{
					FileNameEventArg e = new FileNameEventArg(this.FileName);
					if (BeforeFileClose!=null) BeforeFileClose(this, e);
					if (e.Cancel) res = false;
				}

				if (res) 
				{										
					pkg.Close();
					this.SetupEvents(false);	
					pkg = null;
				} else return false;
			}

			return true;
		}

		/// <summary>
		/// Executed when the user clicks on one of the RecentFiles Menu Items
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void OpenRecent(object sender, System.EventArgs e)
		{
			if (sender is ToolStripMenuItem) 
			{
                ToolStripMenuItem mbi = (ToolStripMenuItem)sender;

				FileNameEventArg me = new FileNameEventArg(mbi.Tag.ToString());									
				if (BeforeRecentFileLoad!=null) BeforeRecentFileLoad(this, me);				

				if (!me.Cancel)  				
					if (LoadFromFile(me.FileName)) 
						if (AfterRecentFileLoad!=null) AfterRecentFileLoad(this);							
			}
		}

		/// <summary>
		/// Get a fitting Shortcut
		/// </summary>
		/// <param name="i">Number of the Item</param>
		/// <returns></returns>
		System.Windows.Forms.Shortcut GetShortCut(int i)
		{			
			if (i==1) return System.Windows.Forms.Shortcut.Ctrl1;
			if (i==2) return System.Windows.Forms.Shortcut.Ctrl2;
			if (i==3) return System.Windows.Forms.Shortcut.Ctrl3;
			if (i==4) return System.Windows.Forms.Shortcut.Ctrl4;
			if (i==5) return System.Windows.Forms.Shortcut.Ctrl5;
			if (i==6) return System.Windows.Forms.Shortcut.Ctrl6;
			if (i==7) return System.Windows.Forms.Shortcut.Ctrl7;
			if (i==8) return System.Windows.Forms.Shortcut.Ctrl8;
			if (i==9) return System.Windows.Forms.Shortcut.Ctrl9;
			if (i==10) return System.Windows.Forms.Shortcut.Ctrl0;

			
			if (i==11) return System.Windows.Forms.Shortcut.Alt1;
			if (i==12) return System.Windows.Forms.Shortcut.Alt2;
			if (i==13) return System.Windows.Forms.Shortcut.Alt3;
			if (i==14) return System.Windows.Forms.Shortcut.Alt4;
			if (i==15) return System.Windows.Forms.Shortcut.Alt5;
			if (i==16) return System.Windows.Forms.Shortcut.Alt6;
			if (i==17) return System.Windows.Forms.Shortcut.Alt7;
			if (i==18) return System.Windows.Forms.Shortcut.Alt8;
			if (i==19) return System.Windows.Forms.Shortcut.Alt9;
			if (i==20) return System.Windows.Forms.Shortcut.Alt0;

			return System.Windows.Forms.Shortcut.None;
		}

		/// <summary>
		/// Add a List of recently Opened Files to the Menu
		/// </summary>
		/// <param name="menu"></param>
        public void UpdateRecentFileMenu(System.Windows.Forms.ToolStripMenuItem menu)
		{
			menu.DropDownItems.Clear();

			string[] files = Helper.WindowsRegistry.GetRecentFiles();
			foreach (string file in files)
			{
				if (System.IO.File.Exists(file)) 
				{
					string sname = file;
					if (sname.Length>MAX_FILENAME_LENGTH) 
						sname = "..."+sname.Substring(file.Length-MAX_FILENAME_LENGTH, MAX_FILENAME_LENGTH);

                    System.Windows.Forms.ToolStripMenuItem mbi = new System.Windows.Forms.ToolStripMenuItem(sname);
					mbi.Tag = file;
					mbi.Click += new EventHandler(OpenRecent);
                    System.Windows.Forms.KeysConverter kc = new KeysConverter();

                    LoadFileWrappersExt.SetShurtcutKey(mbi, GetShortCut(menu.DropDownItems.Count + 1));					
					
					menu.DropDownItems.Add(mbi);
				}
			}
		}

		/// <summary>
		/// Load a Package File or add exported Files
		/// </summary>
		/// <param name="names">list of FileNames</param>
		/// <param name="create">true, if you want to create a new Package if none was loaded</param>
		public void LoadOrImportFiles(string[] names, bool create) 
		{			
			if (names.Length==0) return;
			if (!Loaded && !create) return;

			if (!Loaded && create) this.LoadFromPackage(SimPe.Packages.GeneratableFile.CreateNew());

			ExtensionType et = ExtensionProvider.GetExtension(names[0]);
			if (names.Length==1 && (et == ExtensionType.Package || et == ExtensionType.DisabledPackage ))
			{				
				if (System.IO.File.Exists(names[0])) this.LoadFromFile(names[0]);
			}
            else if (et == ExtensionType.ExtractedFile || et == ExtensionType.ExtractedFileDescriptor || names.Length > 1 || et == ExtensionType.ExtrackedPackageDescriptor)
			{
				this.PauseIndexChangedEvents();
                this.Package.BeginUpdate();
				try 
				{
					for (int i=0; i<names.Length; i++) 					
						if (System.IO.File.Exists(names[i])) 
						{
							PackedFileDescriptors pfds = LoadDescriptorsFromDisk(names[i]);
                            
							foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) this.Package.Add(pfd);
                            
						}				
				} 
				finally 
				{
                    this.Package.EndUpdate();
					this.RestartIndexChangedEvents();
				}
			}
		}

		#region Statics		

		/// <summary>
		/// Load FileDescriptors that are stored in the given File
		/// </summary>
		/// <param name="flnames">List of FileNames</param>
		/// <returns></returns>
		public static PackedFileDescriptors LoadDescriptorsFromDisk(string[] flnames) 
		{
			PackedFileDescriptors list = new PackedFileDescriptors();
			foreach (string flname in flnames) LoadDescriptorsFromDisk(flname, list);
			return list;
		}

		/// <summary>
		/// Load FileDescriptors that are stored in the given File
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		public static PackedFileDescriptors LoadDescriptorsFromDisk(string flname) 
		{
			PackedFileDescriptors list = new PackedFileDescriptors();
			LoadDescriptorsFromDisk(flname, list);
			return list;
		}

		/// <summary>
		/// Load FileDescriptors that are stored in the given File
		/// </summary>
		/// <param name="flname"></param>
		/// <param name="list">null or the list that should be used to add the Items</param>
		/// <returns></returns>
		public static void LoadDescriptorsFromDisk(string flname, PackedFileDescriptors list) 
		{
			if (list==null) return;
			bool run = WaitingScreen.Running;
			if (!run) WaitingScreen.Wait();
			WaitingScreen.UpdateMessage("Saving File");
			//list = new PackedFileDescriptors();
			try 
			{
				if (flname.ToLower().EndsWith("package.xml")) 
				{				
					SimPe.Packages.File pkg = Packages.GeneratableFile.LoadFromStream(XmlPackageReader.OpenExtractedPackage(null, flname));
                    foreach (Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
					{
						Interfaces.Files.IPackedFile file = pkg.Read(pfd);
						pfd.UserData = file.UncompressedData;
						if (!list.Contains(pfd)) list.Add(pfd);
					}
                    
				} 
				else if (flname.ToLower().EndsWith(".xml")) 
				{		
					Interfaces.Files.IPackedFileDescriptor pfd = XmlPackageReader.OpenExtractedPackedFile(flname);
					if (!list.Contains(pfd)) list.Add(pfd);					
				} 
				else if (flname.ToLower().EndsWith(".package") || flname.ToLower().EndsWith(".simpedis")) 
				{
					SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(flname);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
					{
						Interfaces.Files.IPackedFile file = pkg.Read(pfd);
						pfd.UserData = file.UncompressedData;
						if (!list.Contains(pfd)) list.Add(pfd);
					}
				}
				else 
				{
					
					Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
					pfd.Type = 0xffffffff;
					ToolLoaderItemExt.OpenPackedFile(flname, ref pfd);
					list.Add(pfd);
				}
			}
			finally 
			{
				if (!run) WaitingScreen.Stop();
			}
		}
		#endregion

		#region IndexChanged Events
		/// <summary>
		/// Triggered whenever the Index of the stored Package was changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void IndexChangedHandler(object sender, EventArgs e)
		{
			if (paused) indexChangedHandler = sender;
			else if (IndexChanged!=null) IndexChanged(sender, e);
		
		}
		void SavedIndexHandler(object sender, EventArgs e)
		{
			if (paused) savedIndexHandler = sender;
			else if (SavedIndex!=null) SavedIndex(sender, e);
		}

		object savedIndexHandler;
		object indexChangedHandler;
		object addedResourceHandler;
		object removedResourcehandler;
		bool paused = false;
		/// <summary>
		///Blocks IndexChanged Events until <see cref="RestartIndexChangedEvents"/> is called
		/// </summary>
		public void PauseIndexChangedEvents()
		{
			indexChangedHandler = null;
			addedResourceHandler = null;
			removedResourcehandler = null;
			savedIndexHandler = null;
			paused = true;
		}

		/// <summary>
		/// Unblocks IndexChanged Events. If a Event was fired during the Pause, 
		/// the last one will be fired
		/// </summary>
		public void RestartIndexChangedEvents()
		{
			paused = false;
			if (savedIndexHandler!=null) SavedIndexHandler(savedIndexHandler, null);
			if (indexChangedHandler!=null) IndexChangedHandler(indexChangedHandler, null);
			if (addedResourceHandler!=null) AddedResourceHandler(addedResourceHandler, null);
			if (removedResourcehandler!=null) RemovedResourcehandler(removedResourcehandler, null);
		}		

		private void AddedResourceHandler(object sender, EventArgs e)
		{
			if (paused) addedResourceHandler = sender;
			else if (this.AddedResource!=null) AddedResource(sender, e);
		}

		private void RemovedResourcehandler(object sender, EventArgs e)
		{
			if (paused) removedResourcehandler = sender;
			else if (this.RemovedResource!=null) RemovedResource(sender, e);
		}
		#endregion

		#region IDisposable Member

		public void Dispose()
		{			

		}

		#endregion
	}
}
