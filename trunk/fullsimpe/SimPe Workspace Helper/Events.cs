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

namespace SimPe.Events
{
	#region Resource Events
	/// <summary>
	/// Fired when a Resource was changed by a ToolPlugin
	/// </summary>
	public delegate void ChangedResourceEvent(object sender, ResourceEventArgs e);	

	/// <summary>
	/// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
	/// </summary>
	public delegate bool ChangeEnabledStateEvent(object sender, ResourceEventArgs e);

	/// <summary>
	/// Used by <see cref="ChangedResourceEvent"/>
	/// </summary>
	public class ResourceEventArgs : System.EventArgs, IEnumerable
	{
		LoadedPackage lp;
		ResourceContainers list;
		
		/// <summary>
		/// Create a new Isntance
		/// </summary>
		/// <param name="lp"></param>
		public ResourceEventArgs(LoadedPackage lp)
		{
			this.lp = lp;
			list = new ResourceContainers();
		}

		/// <summary>
		/// Returns the stored List
		/// </summary>
		public ResourceContainers Items 
		{
			get { return list; }
		}

		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new ResourceContainer this[int index]
		{
			get { return list[index]; }
			set { list[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public ResourceContainer this[uint index]
		{
			get { return list[index]; }
			set { list[index] = value; }
		}

		/// <summary>
		/// Returns the loaded package
		/// </summary>
		public LoadedPackage LoadedPackage 
		{
			get { return lp; }
		}

		/// <summary>
		/// true if the stored List is Empty
		/// </summary>
		public new bool Empty 
		{
			get 
			{
				return list.Count == 0;		
			}
		}

		/// <summary>
		/// true, if at least one of the stored <see cref="ResourceContainer"/> has a valid Resource
		/// </summary>
		public bool HasResource 
		{
			get 
			{
				foreach (ResourceContainer r in list) if (r.HasResource) return true;
				return false;
			}
		}

		/// <summary>
		/// true, if at least one of the stored <see cref="ResourceContainer"/> has a valid FileDescriptor
		/// </summary>
		public bool HasFileDescriptor
		{
			get 
			{
				foreach (ResourceContainer r in list) if (r.HasFileDescriptor) return true;
				return false;
			}
		}

		/// <summary>
		/// true, if at least one of the stored <see cref="ResourceContainer"/> has a valid Package
		/// </summary>
		public bool HasPackage 
		{
			get 
			{
				foreach (ResourceContainer r in list) if (r.HasPackage) return true;
				return false;
			}
		}		

		/// <summary>
		/// Number of stored Items
		/// </summary>
		public int Count 
		{
			get { return list.Count; }
		}

		#region IEnumerable Member

		public IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion
	}

	/// <summary>
	/// Used as Item in <see cref="ResourceEventArgs"/>
	/// </summary>
	public class ResourceContainer : SimPe.Interfaces.Plugin.IToolResult 
	{
		public ResourceContainer(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item)
		{
			this.item = item;
			cpfd = false;
		}

		SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item;

		/// <summary>
		/// Returns the Resource
		/// </summary>
		public SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem Resource
		{
			get { return item; }
		}


		bool cpfd;
		#region IToolResult Member

		public bool ChangedPackage 
		{
			get { return false;	}			
		}

		public bool ChangedFile 
		{
			get { return this.cpfd;	}
			set { cpfd = value; }
		}

		public bool ChangedAny 
		{
			get
			{
				return (ChangedPackage || ChangedFile);
			}
		}

		#endregion

		public override int GetHashCode()
		{
			if (this.Resource==null) return base.GetHashCode ();			
			return this.Resource.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (!(obj is ResourceContainer)) return false;

			ResourceContainer e = (ResourceContainer)obj;			

			if (e.Resource==null) 
			{
				return (this.Resource==null);
			} 
			else if (this.Resource==null) return false;

			return (e.Resource.Equals(this.Resource));
		}

		/// <summary>
		/// true if the stored Resource is accessible
		/// </summary>
		public bool HasResource 
		{
			get 
			{
				if (Resource==null) return false;				
				return true;
			}
		}

		/// <summary>
		/// true if the FileDescriptor of the stored Resource is accessible
		/// </summary>
		public bool HasFileDescriptor 
		{
			get 
			{
				if (!HasResource) return false;
				if (Resource.FileDescriptor==null) return false;
				return true;
			}
		}

		/// <summary>
		/// true if the Package of the stored Resource is accessible
		/// </summary>
		public bool HasPackage 
		{
			get 
			{
				if (!HasResource) return false;
				if (Resource.Package==null) return false;
				return true;
			}
		}

		/// <summary>
		/// Returns the FileName of the store package (will never return null)
		/// </summary>
		public string FileName 
		{
			get 
			{
				if (!HasPackage) return "";
				if (Resource.Package.FileName==null) return "";
				return Resource.Package.FileName;
			}
		}		
	}

	#region ResourceContainers	
	/// <summary>
	/// Typesave ArrayList for <see cref="ResourceContainer"/> Objects
	/// </summary>
	public class ResourceContainers : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new ResourceContainer this[int index]
		{
			get { return ((ResourceContainer)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public ResourceContainer this[uint index]
		{
			get { return ((ResourceContainer)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(ResourceContainer item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, ResourceContainer item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(ResourceContainer item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(ResourceContainer item)
		{
			return base.Contains(item);
		}		

		/// <summary>
		/// Number of stored Elements
		/// </summary>
		public int Length 
		{
			get { return this.Count; }
		}

		/// <summary>
		/// Create a clone of this Object
		/// </summary>
		/// <returns>The clone</returns>
		public override object Clone()
		{
			ResourceContainers list = new ResourceContainers();
			foreach (ResourceContainer item in this) list.Add(item);

			return list;
		}
	}
	#endregion

	#endregion

	#region File Events
	/// <summary>
	/// Passed as Event Argument in <see cref="PackageFileLoadEvent"/>
	/// </summary>
	public class FileNameEventArg  : System.EventArgs 
	{
		public FileNameEventArg(string filename) 
		{
			cancel = false;
			this.filename = filename;
		}

		string filename;
		public string FileName 
		{
			get { return filename; }
			set {filename = value; }
		}

		bool cancel;		
		public bool Cancel 
		{
			get { return cancel; }
			set {cancel = value; }
		}
	}
	/// <summary>
	/// A function that can be executed when a new File has to be loaded
	/// </summary>
	public delegate void PackageFileLoadEvent(LoadedPackage sender, FileNameEventArg e);

	/// <summary>
	/// A function that can be executed when a new File hwas loaded
	/// </summary>
	public delegate void PackageFileLoadedEvent(LoadedPackage sender);
	/// <summary>
	/// A function that can be executed when a File has to be saved
	/// </summary>
	public delegate void PackageFileSaveEvent(LoadedPackage sender, FileNameEventArg e);

	/// <summary>
	/// A function that can be executed when a File was saved
	/// </summary>
	public delegate void PackageFileSavedEvent(LoadedPackage sender);
	#endregion
}
