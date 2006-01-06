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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This is A ResourceWrapper, which is added when an external Wrapper could not be loaded
	/// </summary>
	public class ErrorWrapper : SimPe.Interfaces.IWrapper, SimPe.Interfaces.Plugin.IFileWrapper
	{
		string flname;
		Exception e;
		public ErrorWrapper(string filename, Exception e)
		{
			flname = filename;
			this.e = e;
			p=-1;
		}
		#region IWrapper Member

		public string WrapperFileName
		{
			get
			{
				return System.IO.Path.GetFileName(flname);
			}
		}

		public void Register(SimPe.Interfaces.IWrapperRegistry registry)
		{
			registry.Register((SimPe.Interfaces.IWrapper)this);
		}

		int p;
		public int Priority
		{
			get
			{
				return p;
			}
			set
			{	
				p = value;
			}
		}

		public override string ToString()
		{
			return "Error Wrapper";
		}

		public SimPe.Interfaces.Plugin.IWrapperInfo WrapperDescription
		{
			get
			{				
				return new SimPe.Interfaces.Plugin.AbstractWrapperInfo(
					WrapperFileName,
					SimPe.Localization.GetString("Unknown"),
					e.ToString()+":"+e.Message,
					1
					);
			}
		}

		public bool CheckVersion(uint version)
		{
			return false;
		}

		public bool AllowMultipleInstances
		{
			get
			{
				return false;
			}
		}

		#endregion

		#region IFileWrapper Member

		public byte[] FileSignature
		{
			get
			{
				return new byte[0];
			}
		}

		public uint[] AssignableTypes
		{
			get
			{				
				return new uint[0];
			}
		}

		#endregion

		#region IPackedFileWrapper Member

		public void RefreshUI()
		{			
		}

		public string ResourceName
		{
			get
			{
				return "";
			}
		}

		public void ProcessData(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, bool catchex)
		{
			
		}

		void SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper.ProcessData(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, SimPe.Interfaces.Files.IPackedFile file, bool catchex)
		{
			
		}

		void SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper.ProcessData(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item, bool catchex)
		{
			
		}

		void SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper.ProcessData(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{

		}

		void SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper.ProcessData(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, SimPe.Interfaces.Files.IPackedFile file)
		{

		}

		void SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper.ProcessData(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item)
		{	
		}

		public string Description
		{
			get
			{
				return "Error Object";
			}
		}

		public string DescriptionHeader
		{
			get
			{
				return "Error";
			}
		}

		public System.IO.BinaryReader StoredData
		{
			get
			{
				return null;
			}
		}

		public void LoadUI()
		{
			
		}

		public void Fix(SimPe.Interfaces.IWrapperRegistry registry)
		{
			
		}

		public System.IO.MemoryStream Content
		{
			get
			{
				return null;
			}
		}

		public SimPe.Interfaces.Files.IPackageFile Package
		{
			get
			{
				return null;
			}
		}

		public SimPe.Interfaces.Plugin.IPackedFileUI UIHandler
		{
			get
			{
				return null;
			}
			set
			{
				
			}
		}

		public SimPe.Interfaces.Plugin.IFileWrapper Activate()
		{
			return this;
		}

		public void Refresh()
		{
			
		}

		public string FileExtension
		{
			get
			{
				return ".err";
			}
		}

		public SimPe.Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get
			{
				return null;
			}
		}

		#endregion
		
		#region IDisposable Member
		public virtual void Dispose()
		{			
		}
		#endregion
	}
}
