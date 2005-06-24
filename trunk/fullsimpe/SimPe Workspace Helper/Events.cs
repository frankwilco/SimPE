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

namespace SimPe.Events
{
	#region Resource Events
	/// <summary>
	/// Fired when a Resource was changed by a ToolPlugin
	/// </summary>
	public delegate void ChangedResourceEvent(object sender, ResourceEventArgs[] e, LoadedPackage guipackage);

	/// <summary>
	/// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
	/// </summary>
	public delegate bool ChangeEnabledStateEvent(object sender, ResourceEventArgs[] e, LoadedPackage guipackage);

	/// <summary>
	/// Used by <see cref="ChangedResourceEvent"/>
	/// </summary>
	public class ResourceEventArgs : System.EventArgs, SimPe.Interfaces.Plugin.IToolResult 
	{
		public ResourceEventArgs(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item)
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
			if (!(obj is ResourceEventArgs)) return false;

			ResourceEventArgs e = (ResourceEventArgs)obj;			

			if (e.Resource==null) 
			{
				return (this.Resource==null);
			} 
			else if (this.Resource==null) return false;

			return (e.Resource.Equals(this.Resource));
		}

	}
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
