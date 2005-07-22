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

namespace SimPe.Collections.IO
{
	/// <summary>
	/// This class contains a Index of all found Files
	/// </summary>
	public class ResourceIndex
	{

		/// <summary>
		/// This Hashtable (FileType) contains a Hashtable (Group) of Hashtables (Instance) of ArrayLists (coliding Files)
		/// </summary>
		Hashtable index;
		SimPe.Interfaces.Files.IPackageFile pkg;
		uint higestoffset;
		PackedFileDescriptors pfds;
		
		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <remarks>Same as a call to FileIndex(null)</remarks>
		public ResourceIndex(SimPe.Interfaces.Files.IPackageFile pkg) : this(pkg, false)
		{
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <remarks>Same as a call to FileIndex(null)</remarks>
		public ResourceIndex(SimPe.Interfaces.Files.IPackageFile pkg, bool flat)
		{
			this.pkg = pkg;
			pfds = new PackedFileDescriptors();
			this.flat = flat;
			higestoffset = 0;
			LoadIndex();
		}
		
		bool flat;
		public bool Flat
		{
			get { return flat; }
		}

		/// <summary>
		/// Returns the next free offset in the File
		/// </summary>
		public uint NextFreeOffset
		{
			get { return higestoffset; }
		}

		/// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public ResourceIndex Clone()
		{
			ResourceIndex ret = new ResourceIndex(this.pkg);
			ret.index = (Hashtable)this.index.Clone();		

			return ret;
		}

		internal void LoadIndex()
		{
			LoadIndex(null);
		}

		/// <summary>
		/// Initialize the instance Data
		/// </summary>
		/// <param name="folders">Fodlers to scan</param>
		internal void LoadIndex(SimPe.Collections.IO.PackedFileDescriptors pfds)
		{							
			index = new Hashtable();									
			
			bool wasrunning = WaitingScreen.Running;
			WaitingScreen.Wait();
			index.Clear();

			if (pfds!=null) this.AddIndexFromPfd(pfds);

			if (!wasrunning) WaitingScreen.Stop();
		}

		
		

		

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		internal void AddIndexFromPfd(SimPe.Collections.IO.PackedFileDescriptors pfds)
		{
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				AddIndexFromPfd(pfd);
		}

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		internal void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			pfd.Closed += new SimPe.Events.PackedFileChanged(ClosedDescriptor);		
			pfd.DescriptionChanged += new EventHandler(DescriptorChanged);

			Hashtable groups = null;
			Hashtable instances = null;
			PackedFileDescriptors files = null;		
	
			if (pfd.Offset+pfd.Size > higestoffset) higestoffset = (uint)(pfd.Offset+pfd.Size);
			
			if (!flat) 
			{
				if (index.ContainsKey(pfd.Type)) groups = (Hashtable)index[pfd.Type];
				else 
				{
					groups = new Hashtable();
					index[pfd.Type] = groups;
				}

				if (groups.ContainsKey(pfd.Group)) instances = (Hashtable)groups[pfd.Group];
				else 
				{
					instances = new Hashtable();
					groups[pfd.Group] = instances;
				}

				if (instances.ContainsKey(pfd.LongInstance)) files = (PackedFileDescriptors)instances[pfd.LongInstance];
				else 
				{
					files = new PackedFileDescriptors();
					instances[pfd.LongInstance] = files;
				}
			
				files.Add(pfd);	
			}
			pfds.Add(pfd);	
		}

		internal void RemoveChanged(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			if (!flat) 
			{
				foreach (uint type in index.Keys) 
				{
					Hashtable groups = (Hashtable)index[type];
					foreach (uint group in groups.Keys)
					{
						Hashtable instances = (Hashtable)groups[group];
						foreach (ulong instance in instances.Keys) 
						{
							PackedFileDescriptors list = (PackedFileDescriptors)instances[instance];
							for (int i=list.Count-1; i>=0; i--) 
								if (list[i] == pfd) 
								{
									pfds.Remove(list[i]);
									list.RemoveAt(i);																	
								}
						}
					}
				}	
			} 
			else pfds.Remove(pfd);			
		}

		/// <summary>
		/// Removes an Item from the Table
		/// </summary>
		/// <param name="pfd">The item you want to remove</param>
		internal void RemoveItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{			
			ArrayList list = new ArrayList();

			if (!flat) 
			{
				if (index.ContainsKey(pfd.Type)) 
				{
					Hashtable groups = (Hashtable)index[pfd.Type];
					if (groups.ContainsKey(pfd.Group)) 
					{
						Hashtable instances = (Hashtable)groups[pfd.Group];
						if (instances.ContainsKey(pfd.LongInstance)) 
						{
							list = (ArrayList)instances[pfd.LongInstance];
							list.Remove(pfd);
							pfds.Remove(pfd);
						}
					}				
				}
			} 
			else 
			{
				pfds.Remove(pfd);
			}
		}

		/// <summary>
		/// Removes an Item from the Table
		/// </summary>
		/// <param name="pfd">The item you want to remove</param>
		internal PackedFileDescriptors RemoveDeleteMarkedItem()
		{			
			PackedFileDescriptors list;
			PackedFileDescriptors removed = new PackedFileDescriptors();

			if (!flat) 
			{
				foreach (uint type in index.Keys) 
				{
					Hashtable groups = (Hashtable)index[type];
					foreach (uint group in groups.Keys)
					{
						Hashtable instances = (Hashtable)groups[group];
						foreach (ulong instance in instances.Keys) 
						{
							list = (PackedFileDescriptors)instances[instance];
							for (int i=list.Count-1; i>=0; i--) 
								if (list[i].MarkForDelete) 
								{
									pfds.Remove(list[i]);
									removed.Add(list[i]);
									list.RemoveAt(i);									
								
								}
						}
					}
				}	
			} 
			else 
			{
				for (int i=this.pfds.Count-1; i>=0; i--) 				
					if (pfds[i].MarkForDelete) 					
						pfds.RemoveAt(i);
			}

			return removed;
		}

		/// <summary>
		/// Returns all matching FileIndexItems
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFile(Interfaces.Files.IPackedFileDescriptor pfd)
		{
			ArrayList list = new ArrayList();

			if (!flat) 
			{
				if (index.ContainsKey(pfd.Type)) 
				{
					Hashtable groups = (Hashtable)index[pfd.Type];
					if (groups.ContainsKey(pfd.Group)) 
					{
						Hashtable instances = (Hashtable)groups[pfd.Group];
						if (instances.ContainsKey(pfd.LongInstance)) 
						{
							return (PackedFileDescriptors)instances[pfd.LongInstance];
						}
					}
				}

				return new PackedFileDescriptors();
			} 
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.Equals(pfd)) ret.Add(i);
				
				return ret;
			}						
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFile(uint type)
		{
			PackedFileDescriptors list = new PackedFileDescriptors();

			if (!flat) 
			{
				if (index.ContainsKey(type)) 
				{
					Hashtable groups = (Hashtable)index[type];
					foreach (uint group in groups.Keys) 
					{
						if (groups.ContainsKey(group)) 
						{
							Hashtable instances = (Hashtable)groups[group];

							foreach (ulong instance in instances.Keys) 
							{
								list.AddRange((PackedFileDescriptors)instances[instance]);
							}
						}
					}
				}
			} 
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.Type == type) ret.Add(i);
				
				return ret;
			}
			
			return list;
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFile(uint type, uint group, ulong instance)
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
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFile(uint type, uint group, uint subtype, uint instance)
		{
			SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
			pfd.Group = group;
			pfd.Type = type;
			pfd.SubType = subtype;
			pfd.Instance = instance;

			return FindFile(pfd);
		}

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFile(uint type, uint group)
		{
			PackedFileDescriptors list = new PackedFileDescriptors();

			if (!flat) 
			{
				if (index.ContainsKey(type)) 
				{
					Hashtable groups = (Hashtable)index[type];
					if (groups.Contains(group)) 
					{
						Hashtable instances = (Hashtable)groups[group];

						foreach (ulong instance in instances.Keys) 
						{
							list.AddRange((PackedFileDescriptors)instances[instance]);
						}
					}
				}

				return list;
			} 
			
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.Type == type && i.Group==group) ret.Add(i);
				
				return ret;
			}		
		}

		/// <summary>
		/// Returns all matching FileIndexItems while Ignoring the Group
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileDiscardingGroup(Interfaces.Files.IPackedFileDescriptor pfd)
		{
			return FindFileDiscardingGroup(pfd.Type, pfd.LongInstance);
		}
		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileDiscardingGroup(uint type, ulong instance) 
		{
			PackedFileDescriptors list = new PackedFileDescriptors();

			if (!flat)
			{
				if (index.ContainsKey(type)) 
				{
					Hashtable groups = (Hashtable)index[type];
					foreach (uint group in groups.Keys) 
					{
						Hashtable instances = (Hashtable)groups[group];
						if (instances.ContainsKey(instance)) 
						{
							list.AddRange((PackedFileDescriptors)instances[instance]);
						}						
					}
				}
			} 
			
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.Type==type && i.LongInstance==instance) ret.Add(i);
				
				return ret;
			}
			
			
			//return the Result
			return list;
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByInstance(uint subtype, uint instance)
		{
			return FindFileByInstance((((ulong)subtype << 32) & 0xffffffff00000000) | (ulong)instance);
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByInstance(ulong instance)
		{
			if (!flat) 
			{
				PackedFileDescriptors list = new PackedFileDescriptors();

				foreach (uint type in index.Keys) 
				{
					Hashtable groups = (Hashtable)index[type];
					foreach (uint group in groups.Keys) 
					{
						Hashtable instances = (Hashtable)groups[group];
						if (instances.ContainsKey(instance))
						{
							list.AddRange((PackedFileDescriptors)instances[instance]);
						}
					}
				}
			
				//return the Result
				return list;
			} 
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.LongInstance == instance) ret.Add(i);
				
				return ret;
			}
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByInstance(uint type, uint subtype, uint instance)
		{
			return FindFileDiscardingGroup(type, (((ulong)subtype << 32) & 0xffffffff00000000) | (ulong)instance);
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByInstance(uint type, ulong instance)
		{
			return FindFileDiscardingGroup(type, instance);
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="group">The Group you are looking for</param>
		/// <param name="instance">The instance you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByGroupAndInstance(uint group, ulong instance)
		{
			if (!flat) 
			{
				PackedFileDescriptors list = new PackedFileDescriptors();

				foreach (uint type in index.Keys) 
				{
					Hashtable groups = (Hashtable)index[type];
					if (groups.ContainsKey(group))  
					{
						Hashtable instances = (Hashtable)groups[group];
						if (instances.ContainsKey(instance)) list.AddRange((PackedFileDescriptors)instances[instance]);
					}
				}
			
				//return the Result
				return list;
			} 
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.LongInstance == instance && i.Group == group) ret.Add(i);
				
				return ret;
			}
		}

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="group">The Group you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		public PackedFileDescriptors FindFileByGroup(uint group)
		{
			if (!flat) 
			{
				PackedFileDescriptors list = new PackedFileDescriptors();

				foreach (uint type in index.Keys) 
				{
					Hashtable groups = (Hashtable)index[type];
					if (groups.ContainsKey(group))  
					{
						Hashtable instances = (Hashtable)groups[group];
						foreach (ulong instance in instances.Keys)
						{
							list.AddRange((PackedFileDescriptors)instances[instance]);
						}
					}
				}
			
				//return the Result
				return list;
			} 
			else 
			{
				PackedFileDescriptors ret = new PackedFileDescriptors();
				foreach (Interfaces.Files.IPackedFileDescriptor i in pfds)				
					if (i.Group == group) ret.Add(i);
				
				return ret;
			}
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
		public Interfaces.Files.IPackedFileDescriptor FindSingleFile(Interfaces.Files.IPackedFileDescriptor pfd, bool betolerant)
		{
			PackedFileDescriptors list;
			list = this.FindFile(pfd);
			

			if (list.Length>0) return list[0];
			return null;
		}
		
		/// <summary>
		/// Return a flat list of all stored pfds
		/// </summary>
		/// <returns></returns>
		public PackedFileDescriptors Flatten()
		{
			if (pfds==null) pfds = new PackedFileDescriptors();
			return pfds;			
		}
		
		internal void Clear()
		{
			if (index==null) return;
			PackedFileDescriptors list;
			foreach (uint type in index.Keys) 
			{
				Hashtable groups = (Hashtable)index[type];
				foreach (uint group in groups.Keys)
				{
					Hashtable instances = (Hashtable)groups[group];
					foreach (ulong instance in instances.Keys) 
					{
						list = (PackedFileDescriptors)instances[instance];
						list.Clear();
					}
					instances.Clear();
				}
				groups.Clear();
			}	
			index.Clear();
			pfds.Clear();
		}

		public int Count
		{
			get { return Flatten().Length; }
		}

		private void ClosedDescriptor(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
		{

		}

		private void DescriptorChanged(object sender, EventArgs e)
		{
			if (sender is SimPe.Interfaces.Files.IPackedFileDescriptor) 
			{
				this.RemoveChanged((SimPe.Interfaces.Files.IPackedFileDescriptor)sender);
				this.AddIndexFromPfd((SimPe.Interfaces.Files.IPackedFileDescriptor)sender);
			}
		}
	}
}
