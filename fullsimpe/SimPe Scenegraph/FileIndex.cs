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
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is a Item describing the File
	/// </summary>
	public class FileIndexItem : IScenegraphFileIndexItem, IComparer, System.IDisposable
	{
		uint localgr;
		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		/// <summary>
		/// The Descriptor of that File
		/// </summary>
		/// <remarks>Contains the original Group </remarks>
		public SimPe.Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get { return pfd; }
			set { pfd = value; }
		}

		SimPe.Interfaces.Files.IPackageFile package;
		/// <summary>
		/// The package the File is stored in
		/// </summary>
		public SimPe.Interfaces.Files.IPackageFile Package
		{
			get { return package; }
		}

		/// <summary>
		/// Get the Local Group alue used for this Package
		/// </summary>
		public uint LocalGroup
		{
			get { 
				if (pfd.Group == Data.MetaData.LOCAL_GROUP)
					return localgr; 
				else
					return pfd.Group;
			}
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="pfd">the Descriptor</param>
		/// <param name="package">the package</param>
		public FileIndexItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			if (pfd==null) pfd = new SimPe.Packages.PackedFileDescriptor();
			if (package==null) package = SimPe.Packages.GeneratableFile.LoadFromStream((System.IO.BinaryReader)null);
			this.pfd = pfd;
			this.package = package;

			localgr = FileIndex.GetLocalGroup(package);
		}

		public override string ToString()
		{
			if (pfd!=null) return pfd.Filename;
			else return Localization.Manager.GetString("unknown");
		}

		public override int GetHashCode()
		{
			return this.FileDescriptor.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (obj.GetType()==typeof(FileIndexItem)) 
			{
				FileIndexItem fii = (FileIndexItem)obj;
				if (fii.FileDescriptor==null) return this.FileDescriptor==null;

				if (fii.LocalGroup != LocalGroup) return false;

				bool res = fii.FileDescriptor.Equals(this.FileDescriptor);

				//null Values for Packages
				if (fii.Package==null) 
				{
					if (Package!=null) return false;
					else return res;
				} else if (Package==null) return false;

				//null Values for FileNames
				/*if (fii.Package.FileName==null) 
				{
					if (Package.FileName!=null) return false;
					else return true;
				} else if (Package.FileName==null) return false;*/

				return (res && fii.Package.Equals(this.Package));
			}
			else return base.Equals(obj);
		}

		/// <summary>
		/// returns a String that can identify this Instance
		/// </summary>
		/// <returns></returns>
		public string GetLongHashCode()
		{
			string flname = this.Package.FileName;
			if (flname==null) flname = "";
			return this.FileDescriptor.ToString()+"-"+flname;
		}

		#region IComparer Member

		public int Compare(object x, object y)
		{
			if (x.GetType()==typeof(FileIndexItem) && y.GetType()==typeof(FileIndexItem))
			{
				FileIndexItem a = (FileIndexItem)x;
				FileIndexItem b = (FileIndexItem)y;

				return (int)((long)a.FileDescriptor.Instance - (long)b.FileDescriptor.Instance);
			}
			return 0;
		}

		#endregion

		public void Dispose()
		{
			this.pfd = null;
			this.package = null;
		}
	}

	/// <summary>
	/// Typesave ArrayList for FileIndexItem Objects
	/// </summary>
	public class FileIndexItems : ArrayList 
	{
		public new FileIndexItem this[int index]
		{
			get { return ((FileIndexItem)base[index]); }
			set { base[index] = value; }
		}

		public FileIndexItem this[uint index]
		{
			get { return ((FileIndexItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(FileIndexItem fii)
		{
			return base.Add(fii);
		}

		public void Insert(int index, FileIndexItem fii)
		{
			base.Insert(index, fii);
		}

		public void Remove(FileIndexItem fii)
		{
			base.Remove(fii);
		}

		public bool Contains(FileIndexItem fii)
		{
			foreach (FileIndexItem i in this) if (i.Equals(fii)) return true;
			
			return false;
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override void Sort()
		{
			base.Sort (new FileIndexItem(null, null));
		}

	}

	/// <summary>
	/// This class contains a Index of all found Files
	/// </summary>
	public class FileIndex : Ambertation.Threading.StoppableThread, IScenegraphFileIndex, System.IDisposable
	{

		/// <summary>
		/// This Hashtable (FileType) contains a Hashtable (Group) of Hashtables (Instance) of ArrayLists (coliding Files)
		/// </summary>
		Hashtable index;

		/// <summary>
		/// Contains a List of all Folders you want to check
		/// </summary>
		ArrayList folders;

		/// <summary>
		/// Contains a List of the Filenames of all added packages
		/// </summary>
		ArrayList addedfilenames;
#if DEBUG
		/// <summary>
		/// Just for Debugging
		/// </summary>
		public ArrayList StoredFiles
		{
			get 
			{
				ArrayList ret = new ArrayList();

				foreach (IScenegraphFileIndex fi in childs) 
					ret.AddRange(((FileIndex)fi).StoredFiles);

				ret.AddRange(addedfilenames);
				return ret;
			}
		}
#endif

		/// <summary>
		/// Contains a Mapping from a Filename ro a local Group
		/// </summary>
		static Hashtable localGroupMap;

		/// <summary>
		/// Contains the next number the Core can assign as a localGroup
		/// </summary>
		static uint lastLocalGroup = 0x6f000000;

		/// <summary>
		/// Contains a Listing of all alternate Groups SimPe should check if the first try was no success
		/// </summary>
		static ArrayList alternaiveGroups;

		/// <summary>
		/// true if you want to have duplicate TGI's availabe
		/// </summary>
		bool duplicates;

		public bool Duplicates
		{
			get { return duplicates; }
			set { duplicates = value; }
		}


		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <remarks>Same as a call to FileIndex(null)</remarks>
		public FileIndex() :base()
		{
			loaded = false;
			childs = new ArrayList();
			Init(null);
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="folders">The Folders where you want to look for packages, null for the default Set</param>
		/// <remarks>The Default set is read from the Folder.xml File</remarks>
		public FileIndex(ArrayList folders) :base()
		{
			childs = new ArrayList();
			Init(folders);
		}

		/// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public IScenegraphFileIndex Clone()
		{
			FileIndex ret = new FileIndex(new ArrayList());
			ret.index = (Hashtable)this.index.Clone();
			ret.folders = (ArrayList)this.folders.Clone();
			ret.addedfilenames = (ArrayList)this.addedfilenames.Clone();
			ret.duplicates = this.duplicates;
			ret.loaded = this.loaded;

			return ret;
		}

		#region StoreState
		ArrayList oldnames;
		Hashtable oldindex;
		bool olddup;

		/// <summary>
		/// Stores the current State of the FileIndex.
		/// 
		/// You can revert to the last stored state by calling RestoreLastState()
		/// </summary>
		public void StoreCurrentState()
		{
			oldnames = (ArrayList)this.addedfilenames.Clone();
			oldindex = (Hashtable)this.index.Clone();
			olddup = duplicates;
		}

		/// <summary>
		/// Restores the last stored state (if one is available)
		/// </summary>
		public void RestoreLastState()
		{
			if (oldnames==null || oldindex==null) return;
			
			PrepareAllForRemove();

			addedfilenames = oldnames;
			index = oldindex;
			duplicates = olddup;

			oldnames = null;
			oldindex = null;

			this.PrepareAllForAdd();
		}

		#endregion

		/// <summary>
		/// Initialize the instance Data
		/// </summary>
		/// <param name="folders">Fodlers to scan</param>
		protected void Init(ArrayList folders)
		{	
			addedfilenames = new ArrayList();
			duplicates = false;			

			//Add alternate Groups
			if (alternaiveGroups==null) 
			{
				alternaiveGroups = new ArrayList();								
				alternaiveGroups.Add(Data.MetaData.CUSTOM_GROUP);
				alternaiveGroups.Add(Data.MetaData.GLOBAL_GROUP);
				alternaiveGroups.Add(Data.MetaData.LOCAL_GROUP);
			}

			index = new Hashtable();
			StoreCurrentState();

			if (folders==null) folders = FileTable.DefaultFolders;
			this.folders = folders;
		}

		/// <summary>
		/// Return the suggested local Group for the passed package
		/// </summary>
		/// <param name="package">The package File</param>
		/// <returns>the local Group</returns>
		public static uint GetLocalGroup(SimPe.Interfaces.Files.IPackageFile package)
		{
			string flname = package.FileName;
			return GetLocalGroup(flname);
		}

		/// <summary>
		/// Return the suggested local Group for the passed package
		/// </summary>
		/// <param name="flname">The filename of the package</param>
		/// <returns>the local Group</returns>
		public static uint GetLocalGroup(string flname)
		{
			if (FileTable.GroupCache == null) ScenegraphWrapperFactory.LoadGroupCache();
			if (localGroupMap==null) localGroupMap = new Hashtable();

			
			if (flname==null) flname="memoryfile";
			flname = flname.Trim().ToLower();

			SimPe.Interfaces.Wrapper.IGroupCacheItem gci = FileTable.GroupCache.GetItem(flname);			
			return gci.LocalGroup;
		}

		bool loaded;
		/// <summary>
		/// Load the FileIndex if it is not available yet
		/// </summary>
		/// <remarks>
		/// Use Load() if you want to make sure that the FileIndex is available, 
		/// use ForceReload() if you want to reload the FileIndex (for example, 
		/// becuase the Files changed)
		/// </remarks>
		public void Load() 
		{			
			if (loaded) return;
			ForceReload();
		}

		/// <summary>
		/// Add all Files stored in all the packages found in the passed Folder
		/// </summary>
		/// <remarks>
		/// Use Load() if you want to make sure that the FileIndex is available, 
		/// use ForceReload() if you want to reload the FileIndex (for example, 
		/// becuase the Files changed)
		/// </remarks>
		public void ForceReload()
		{
			//this.WaitForEnd();
			loaded = true;
			
			//this.ExecuteThread(System.Threading.ThreadPriority.Normal, "FileTable Reload", true, true, 1000);
			StartThread();
		}

		/// <summary>
		/// This is used to start the Reload Thread
		/// </summary>
		protected override void StartThread()
		{
			Wait.SubStart(folders.Count);
			Wait.Message = SimPe.Localization.GetString("Loading")+" Group Cache";
			ScenegraphWrapperFactory.LoadGroupCache();	
						
			this.Clear();

			int ct = 0;
			foreach (FileTableItem fti in folders) 
			{
				if (HaveToStop) break;
				Wait.Progress = ct++;
				AddIndexFromFolder(fti);
			}

			Wait.SubStop();
		}

		/// <summary>
		/// Add all Files stored in all the packages found in the passed Folder
		/// </summary>
		/// <param name="fti">A FileTableItem describing the Location</param>
		public void AddIndexFromFolder(FileTableItem fti)
		{
			string[] files = fti.GetFiles();
			
			foreach (string afile in files)
				AddIndexFromPackage(afile);
			
			if (fti.IsRecursive) 
			{
				string[] folders = System.IO.Directory.GetDirectories(fti.Name);
				foreach (string folder in folders)
					AddIndexFromFolder(":"+folder);
			}
		}

		/// <summary>
		/// Add all Files stored in all the packages found in the passed Folder
		/// </summary>
		/// <param name="path">The Folder you want to scan</param>
		public void AddIndexFromFolder(string path)
		{
			path = path.Trim();
			if (path=="") return;

			FileTableItem fti = new FileTableItem(path);
			AddIndexFromFolder(fti);
		}

		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="file">Name of the package File</param>
		/// <remarks>Updates the WaitingScreen Message</remarks>
		public void AddIndexFromPackage(string file)
		{
			Wait.Message = SimPe.Localization.GetString("Loading")+" \""+System.IO.Path.GetFileNameWithoutExtension(file)+"\"";
			try 
			{
				SimPe.Interfaces.Files.IPackageFile package = SimPe.Packages.File.LoadFromFile(file, false);
				AddIndexFromPackage(package, false);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}			
		}
		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="package">The package File</param>
		public void AddIndexFromPackage(SimPe.Interfaces.Files.IPackageFile package){
			AddIndexFromPackage(package, false);
		}		

		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="package">The package File</param>
		/// <param name="overwrite">true, if an existing Instance of that File should be overwritten</param>
		public void AddIndexFromPackage(SimPe.Interfaces.Files.IPackageFile package, bool overwrite)
		{
			package.Persistent = true;			
			if (package.FileName!=null) 
			{
				if ((addedfilenames.Contains(package.FileName.Trim().ToLower())) && !overwrite) return;
				addedfilenames.Add(package.FileName.Trim().ToLower());
			}

			uint local = GetLocalGroup(package);

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in package.Index)
				AddIndexFromPfd(pfd, package, local);

			package.Persistent = false;
		}

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		public void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			uint local = GetLocalGroup(package);
			AddIndexFromPfd(pfd, package, local);
		}

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		public void AddIndexFromPfd(SimPe.Collections.IO.PackedFileDescriptors pfds, SimPe.Interfaces.Files.IPackageFile package)
		{
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				AddIndexFromPfd(pfd, package);
		}

		/// <summary>
		/// Make sure the FileTable is empty
		/// </summary>
		public void Clear()
		{
			this.addedfilenames.Clear();
			/*if (parent!=null) 
			{
				foreach (string s in parent.addedfilenames)
					addedfilenames.Add(s);
			}*/

			foreach (Hashtable groups in index.Values) 
			{
				foreach (Hashtable instances in groups.Values) 
				{
					foreach (ArrayList res in instances.Values) 
					{
						foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem pfd in res)
							PrepareForRemove(pfd.FileDescriptor);

						res.Clear();
					}
					instances.Clear();
				}
				groups.Clear();
			}

			index.Clear();
		}

		protected void PrepareAllForAdd()
		{
			foreach (Hashtable groups in index.Values) 
			{
				foreach (Hashtable instances in groups.Values) 
				{
					foreach (ArrayList res in instances.Values) 
					{
						foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in res)
							PrepareForAdd(item.FileDescriptor);
					}
				}
			}
		}

		protected void PrepareAllForRemove()
		{
			foreach (Hashtable groups in index.Values) 
			{
				foreach (Hashtable instances in groups.Values) 
				{
					foreach (ArrayList res in instances.Values) 
					{
						foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in res)
							PrepareForRemove(item.FileDescriptor);
					}
				}
			}
		}

		protected void PrepareForRemove(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			pfd.Closed -= new SimPe.Events.PackedFileChanged(ClosedDescriptor);
		}

		protected void PrepareForAdd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			pfd.Closed += new SimPe.Events.PackedFileChanged(ClosedDescriptor);
		}

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		/// <param name="localgroup">use this groupa as replacement for 0xffffffff</param>
		public void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, uint localgroup)
		{
			PrepareForAdd(pfd);
			FileIndexItem item = new FileIndexItem(pfd, package);

			Hashtable groups = null;
			Hashtable instances = null;
			FileIndexItems files = null;			
			
			if (index.ContainsKey(item.FileDescriptor.Type)) groups = (Hashtable)index[item.FileDescriptor.Type];
			else 
			{
				groups = new Hashtable();
				index[item.FileDescriptor.Type] = groups;
			}

			if (groups.ContainsKey(item.FileDescriptor.Group)) instances = (Hashtable)groups[item.FileDescriptor.Group];
			else 
			{
				instances = new Hashtable();
				groups[item.FileDescriptor.Group] = instances;
			}

			if (instances.ContainsKey(item.FileDescriptor.LongInstance)) files = (FileIndexItems)instances[item.FileDescriptor.LongInstance];
			else 
			{
				files = new FileIndexItems();
				instances[item.FileDescriptor.LongInstance] = files;
			}
			
			if (duplicates || (!files.Contains(item))) files.Add(item);

			//add it a second Time if it is a local Group
			if (pfd.Group == 0xffffffff)
			{
				if (groups.ContainsKey(localgroup)) instances = (Hashtable)groups[localgroup];
				else 
				{
					instances = new Hashtable();
					groups[localgroup] = instances;
				}

				if (instances.ContainsKey(item.FileDescriptor.Group)) files = (FileIndexItems)instances[item.FileDescriptor.LongInstance];
				else 
				{
					files = new FileIndexItems();
					instances[item.FileDescriptor.LongInstance] = files;
				}

				if (duplicates || (!files.Contains(item))) files.Add(item);
			}

			
		}

		/// <summary>
		/// Removes an Item from the Table
		/// </summary>
		/// <param name="item">The item you want to remove</param>
		public void RemoveItem(Interfaces.Scenegraph.IScenegraphFileIndexItem item)
		{
			Interfaces.Files.IPackedFileDescriptor pfd = item.FileDescriptor;
			ArrayList list = new ArrayList();

			if (index.ContainsKey(pfd.Type)) 
			{
				Hashtable groups = (Hashtable)index[pfd.Type];
				if (groups.ContainsKey(pfd.Group)) 
				{
					Hashtable instances = (Hashtable)groups[pfd.Group];
					if (instances.ContainsKey(pfd.LongInstance)) 
					{
						list = (ArrayList)instances[pfd.LongInstance];
						list.Remove(item);
					}
				}

				if (pfd.Group==Data.MetaData.LOCAL_GROUP) 
				{
					if (groups.ContainsKey(item.LocalGroup)) 
					{
						Hashtable instances = (Hashtable)groups[item.LocalGroup];
						if (instances.ContainsKey(pfd.LongInstance)) 
						{
							list = (ArrayList)instances[pfd.LongInstance];
							list.Remove(item);
						}
					}
				}
			}

			PrepareForRemove(item.FileDescriptor);
		}

		// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileDiscardingHighInstance(uint type, uint group, uint instance, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			ArrayList list = new ArrayList();
			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFileDiscardingHighInstance(type, group, instance, pkg);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			if (index.ContainsKey(type)) 
			{
				Hashtable groups = (Hashtable)index[type];
				if (groups.ContainsKey(group)) 
				{
					Hashtable instances = (Hashtable)groups[group];
					foreach (ulong i in instances.Keys)
						if ((i&0xffffffff) == instance)
							list.AddRange((ArrayList)instances[i]);					
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}


		/// <summary>
		/// Returns all matching FileIndexItems
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFile(Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			ArrayList list = new ArrayList();
			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFile(pfd, pkg);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}
			

			//second, we scan our FileTable
			if (index.ContainsKey(pfd.Type)) 
			{
				Hashtable groups = (Hashtable)index[pfd.Type];
				if (groups.ContainsKey(pfd.Group)) 
				{
					Hashtable instances = (Hashtable)groups[pfd.Group];
					if (instances.ContainsKey(pfd.LongInstance)) 
					{
						
						/*if (pkg!=null) 
						{
							foreach (FileIndexItem fii in (ArrayList)instances[pfd.LongInstance]) 
							{								
								if (fii.Package.Equals(pkg)) list.Add(fii);
							}
						} 
						else */	list = (ArrayList)instances[pfd.LongInstance];
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="nolocal">true, if you don't want to get local Files (group=0xffffffff) returned</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFile(uint type, bool nolocal)
		{
			ArrayList list = new ArrayList();
			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFile(type, nolocal);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			if (index.ContainsKey(type)) 
			{
				Hashtable groups = (Hashtable)index[type];
				foreach (uint group in groups.Keys) 
				{
					if ((nolocal) && (group==Data.MetaData.LOCAL_GROUP)) continue;

					if (groups.ContainsKey(group)) 
					{
						Hashtable instances = (Hashtable)groups[group];

						foreach (ulong instance in instances.Keys) 
						{
							list.AddRange((ArrayList)instances[instance]);
						}
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFile(uint type, uint group, ulong instance, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Group = group;
			pfd.Type = type;
			pfd.LongInstance = instance;

			return FindFile(pfd, pkg);
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFile(uint type, uint group)
		{
			ArrayList list = new ArrayList();

			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFile(type, group);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			if (index.ContainsKey(type)) 
			{
				Hashtable groups = (Hashtable)index[type];
				if (groups.Contains(group)) 
				{
					Hashtable instances = (Hashtable)groups[group];

					foreach (ulong instance in instances.Keys) 
					{
						list.AddRange((ArrayList)instances[instance]);
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Returns all matching FileIndexItems while Ignoring the Group
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileDiscardingGroup(Interfaces.Files.IPackedFileDescriptor pfd)
		{
			return FindFileDiscardingGroup(pfd.Type, pfd.LongInstance);
		}
		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileDiscardingGroup(uint type, ulong instance) 
		{
			ArrayList list = new ArrayList();
			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFileDiscardingGroup(type, instance);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			
			if (index.ContainsKey(type)) 
			{
				Hashtable groups = (Hashtable)index[type];
				foreach (uint group in groups.Keys) 
				{
					if (groups.ContainsKey(group)) 
					{
						Hashtable instances = (Hashtable)groups[group];
						if (instances.ContainsKey(instance)) 
						{
							list.AddRange((ArrayList)instances[instance]);
						}
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileByInstance(ulong instance)
		{
			ArrayList list = new ArrayList();
			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFileByInstance(instance);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable			
			foreach (uint type in index.Keys) 
			{
				Hashtable groups = (Hashtable)index[type];
				foreach (uint group in groups.Keys) 
				{
					Hashtable instances = (Hashtable)groups[group];
					if (instances.ContainsKey(instance))
					{
						list.AddRange((ArrayList)instances[instance]);
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="group">The Group you are looking for</param>
		/// <param name="instance">The instance you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileByGroupAndInstance(uint group, ulong instance)
		{
			ArrayList list = new ArrayList();

			//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFileByGroupAndInstance(group, instance);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			foreach (uint type in index.Keys) 
			{
				Hashtable groups = (Hashtable)index[type];
				if (groups.ContainsKey(group))  
				{
					Hashtable instances = (Hashtable)groups[group];
					if (instances.ContainsKey(instance)) list.AddRange((ArrayList)instances[instance]);
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="group">The Group you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileByGroup(uint group)
		{
			ArrayList list = new ArrayList();//first, we scan the Child Tables
			foreach (IScenegraphFileIndex fi in childs) 
			{
				IScenegraphFileIndexItem[] res = fi.FindFileByGroup(group);
				foreach (IScenegraphFileIndexItem i in res) list.Add(i);
			}

			//second, we scan our FileTable
			

			foreach (uint type in index.Keys) 
			{
				Hashtable groups = (Hashtable)index[type];
				if (groups.ContainsKey(group))  
				{
					Hashtable instances = (Hashtable)groups[group];
					foreach (ulong instance in instances.Keys)
					{
						list.AddRange((ArrayList)instances[instance]);
					}
				}
			}
			
			//return the Result
			FileIndexItem[] files = new FileIndexItem[list.Count];
			list.CopyTo(files);
			return files;
		}

		/// <summary>
		/// Looks for a File based on the Filename
		/// </summary>
		/// <param name="filename">The name of the File (applies only to Scenegraüh Resources)</param>
		/// <param name="type">The Type of the File you are looking for</param>
		/// <param name="defgroup">If the Filename has no group Hash, use this one</param>
		/// <param name="betolerant">
		/// set true if you want to enable a 
		/// fallback Algorithm in case of the precice Search failing
		/// </param>
		/// <returns>The first matching File or null if none</returns>
		public IScenegraphFileIndexItem FindFileByName(string filename, uint type, uint defgroup, bool betolerant)
		{
			Interfaces.Files.IPackedFileDescriptor pfd = SimPe.Plugin.ScenegraphHelper.BuildPfd(filename, type, defgroup);
			IScenegraphFileIndexItem ret = FindSingleFile(pfd, null, betolerant);

			if ((ret==null) && betolerant)
			{
				pfd.SubType = 0;
				ret = FindSingleFile(pfd, null, betolerant);
			} 

			return ret;
		}

		/// <summary>
		/// Looks for a File based on the Filename
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <param name="betolerant">
		/// set true if you want to enable a 
		/// fallback Algorithm in case of the precice Search failing
		/// </param>
		/// <returns>The first matching File or null if none</returns>
		public IScenegraphFileIndexItem FindSingleFile(Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg, bool betolerant)
		{
			IScenegraphFileIndexItem[] list;
			list = this.FindFile(pfd, pkg);

			//something is wrong with the Link, try to be tolerant
			if (list.Length==0) 
			{
				//check alternaive Groups
				for (int i=0; i<alternaiveGroups.Count; i++)
				{
					pfd.Group = (uint)alternaiveGroups[i];
					list = this.FindFile(pfd, pkg);
					if (list.Length>0) break;
				}

				//ignor Group andd look for any Files with that Instance
				if (list.Length==0) 
				{
					list = this.FindFileDiscardingGroup(pfd);
				}
			}

			if (list.Length>0) return list[0];
			return null;
		}

		/// <summary>
		/// Sort the Files in this type ascending by instance value
		/// </summary>
		/// <param name="files">The Files you want to sort</param>
		public IScenegraphFileIndexItem[] Sort(IScenegraphFileIndexItem[] files)
		{
			FileIndexItems fii = new FileIndexItems();
			foreach (FileIndexItem f in files) fii.Add(f);

			fii.Sort();

			FileIndexItem[] ret = new FileIndexItem[fii.Count];
			fii.CopyTo(ret);
			return ret;
		}

		/// <summary>
		/// Remove the trace of a Package from the FileTable
		/// </summary>
		/// <param name="pkg"></param>
		public void ClosePackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			if (pkg==null) return;
			string flname = pkg.FileName;
			pkg.Close(true);

			if (flname==null) return;			
			addedfilenames.Remove(flname.Trim().ToLower());
		}

		/// <summary>
		/// Remove a FileItem from the Tree when it is closed
		/// </summary>
		/// <param name="sender"></param>
		private void ClosedDescriptor(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
		{
			
			///
			/// TODO: This might be critical! Maybe we need to send the parent package along 
			/// with this Data, otherwise to many Files could get removed!
			/// 
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] sgis = FindFile(sender, null);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem sgi in sgis) RemoveItem(sgi);			
		}

		/// <summary>
		/// Creates a new FileIndexItem
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="pkg"></param>
		/// <returns></returns>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem CreateFileIndexItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			return new SimPe.Plugin.FileIndexItem(pfd, pkg);
		}

		/// <summary>
		/// Creates a new FileIndex
		/// </summary>
		/// <param name="pfds"></param>
		/// <param name="package"></param>
		/// <returns></returns>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndex CreateFileIndex(SimPe.Collections.IO.PackedFileDescriptors pfds, SimPe.Interfaces.Files.IPackageFile package)
		{
			SimPe.Plugin.FileIndex fi =  new SimPe.Plugin.FileIndex();
			if (pfds!=null) fi.AddIndexFromPfd(pfds, package);
			return fi;
		}

		#region Handle FileTableChains
		public bool Contains(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			return this.Contains(pkg.SaveFileName);
		}

		public bool Contains(string flname)
		{
			foreach (IScenegraphFileIndex fi in childs) 
				if (fi.Contains(flname)) return true;

			flname = flname.Trim().ToLower();
			if (addedfilenames.Contains(flname)) return true;

			return false;

		}
		ArrayList childs;
		FileIndex parent;
		public IScenegraphFileIndex AddNewChild()
		{
			FileIndex fi = new FileIndex();
			AddChild(fi);

			return fi;
		}

		public void AddChild(IScenegraphFileIndex cld)
		{
			if (!childs.Contains(cld)) 
			{
				if (cld is FileIndex) 
					((FileIndex)cld).parent = this;
				childs.Add(cld);
			}
		}

		public void ClearChilds()
		{
			childs.Clear();
		}

		public void RemoveChild(IScenegraphFileIndex cld)
		{
			int c = childs.Count;
			childs.Remove(cld);
			if (c!=childs.Count)
				if (cld is FileIndex) 
					((FileIndex)cld).parent = null;
		}
		#endregion

		#region IDisposable Member

		public override void Dispose()
		{
			try 
			{
				ClearChilds();
				Clear();
			} 
			catch{}

			this.index = null;
			this.oldindex = null;
			this.addedfilenames = null;
			this.oldnames = null;

			base.Dispose();
		}

		#endregion
	}
}
