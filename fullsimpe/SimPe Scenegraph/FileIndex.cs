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
	public class FileIndexItem : IScenegraphFileIndexItem, IComparer
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
		internal FileIndexItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			if (pfd==null) pfd = new SimPe.Packages.PackedFileDescriptor();
			if (package==null) package = new SimPe.Packages.GeneratableFile((System.IO.BinaryReader)null);
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
			return base.GetHashCode ();
		}

		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (obj.GetType()==typeof(FileIndexItem)) 
			{
				FileIndexItem fii = (FileIndexItem)obj;
				if (fii.FileDescriptor==null) return this.FileDescriptor==null;

				if (fii.LocalGroup != LocalGroup) return false;
				return (fii.FileDescriptor.Equals(this.FileDescriptor));
			}
			else return base.Equals(obj);
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
	public class FileIndex : IScenegraphFileIndex
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


		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <remarks>Same as a call to FileIndex(null)</remarks>
		public FileIndex()
		{
			Init(null);
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="folders">The Folders where you want to look for packages, null for the default Set</param>
		/// <remarks>The Default set is read from the Folder.xml File</remarks>
		public FileIndex(ArrayList folders)
		{
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

			return ret;
		}

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
			if (localGroupMap==null) localGroupMap = new Hashtable();

			string flname = package.FileName;
			if (flname==null) flname="memoryfile";
			flname = flname.Trim().ToLower();

			uint local = 0;
			if (localGroupMap.ContainsKey(flname)) local = (uint)localGroupMap[flname];
			else 
			{
				local = lastLocalGroup++;
				localGroupMap[flname] = local;
			}

			return local;
		}

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
			if (index.Count>0) return;
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
			addedfilenames.Clear();
			bool wasrunning = WaitingScreen.Running;
			WaitingScreen.Wait();
			index.Clear();

			foreach (string path in folders)
				AddIndexFromFolder(path);

			if (!wasrunning) WaitingScreen.Stop();
		}

		/// <summary>
		/// Add all Files stored in all the packages found in the passed Folder
		/// </summary>
		/// <param name="path">The Folder you want to scan</param>
		/// <remarks>If the first character in Path is &, the Folder will be scanned recursive</remarks>
		public void AddIndexFromFolder(string path)
		{
			path = path.Trim();
			if (path=="") return;


			bool recursive = false;
			if (path.StartsWith("&")) 
			{
				path = path.Substring(1, path.Length-1);
				recursive = true;
			}

			string[] files = System.IO.Directory.GetFiles(path, "*.package");
			foreach (string file in files)
				AddIndexFromPackage(file);
			
			if (recursive) 
			{
				string[] folders = System.IO.Directory.GetDirectories(path);
				foreach (string folder in folders)
					AddIndexFromFolder("&"+folder);
			}
		}

		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="file">Name of the package File</param>
		/// <remarks>Updates the WaitingScreen Message</remarks>
		public void AddIndexFromPackage(string file)
		{
			WaitingScreen.UpdateMessage(System.IO.Path.GetFileNameWithoutExtension(file));
			try 
			{
				SimPe.Interfaces.Files.IPackageFile package = new SimPe.Packages.File(file);
				AddIndexFromPackage(package);
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
		public void AddIndexFromPackage(SimPe.Interfaces.Files.IPackageFile package)
		{
			package.Persistent = true;			
			if (package.FileName!=null) 
			{
				if (addedfilenames.Contains(package.FileName)) return;
				addedfilenames.Add(package.FileName);
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
		/// <param name="localgroup">use this groupa as replacement for 0xffffffff</param>
		public void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, uint localgroup)
		{
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
		/// Returns all matching FileIndexItems
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFile(Interfaces.Files.IPackedFileDescriptor pfd)
		{
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
		public IScenegraphFileIndexItem[] FindFile(uint type, uint group, ulong instance)
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Group = group;
			pfd.Type = type;
			pfd.LongInstance = instance;

			return FindFile(pfd);
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
		/// <returns>all FileIndexItems</returns>
		public IScenegraphFileIndexItem[] FindFileByGroup(uint group)
		{
			ArrayList list = new ArrayList();

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
			return FindSingleFile(pfd, betolerant);
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
		public IScenegraphFileIndexItem FindSingleFile(Interfaces.Files.IPackedFileDescriptor pfd, bool betolerant)
		{
			IScenegraphFileIndexItem[] list;
			list = this.FindFile(pfd);

			//something is wrong with the Link, try to be tolerant
			if (list.Length==0) 
			{
				//check alternaive Groups
				for (int i=0; i<alternaiveGroups.Count; i++)
				{
					pfd.Group = (uint)alternaiveGroups[i];
					list = this.FindFile(pfd);
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
	}
}
