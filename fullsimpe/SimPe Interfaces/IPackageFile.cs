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

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Interface for PackeFile Classes
	/// </summary>
	public interface IPackageFile
	{
		/// <summary>
		/// Returns the File Reader
		/// </summary>
		System.IO.BinaryReader Reader
		{
			get;
		}

		/// <summary>
		/// Set/returns the Persistent state of this Package
		/// </summary>
		/// <remarks>If persistent the FileHandle won't be closed!</remarks>
		bool Persistent 
		{
			get;
			set;
		}

		/// <summary>
		/// Create a Clone of this Package File
		/// </summary>
		/// <returns>the new Package File</returns>
		Interfaces.Files.IPackageFile Clone();

		#region FileIndex Handling
		/// <summary>
		/// Returns the FileIndexItem for the given File
		/// </summary>
		/// <param name="index">Number of the File within the FileIndex (0-Based)</param>
		/// <returns>The FileIndexItem for this Entry, or null if the index was over limit</returns>
		IPackedFileDescriptor GetFileIndex(uint index);

		/// <summary>
		/// Temoves the described File from the Index
		/// </summary>
		/// <param name="pfd">A Packed File Descriptor</param>
		void Remove(IPackedFileDescriptor pfd);

		/// <summary>
		/// Removes all FileDescriptors that are marked for Deletion
		/// </summary>
		void RemoveMarked();

		/// <summary>
		/// Ads a list of Descriptors to the Index
		/// </summary>
		/// <param name="pfds">List of Descriptors</param>
		void Add(IPackedFileDescriptor[] pfds);

		/// <summary>
		/// Ads a new Descriptor to the Index
		/// </summary>
		/// <param name="type">The Type of the new File</param>
		/// <param name="subtype">The SubType/classID/ResourceID of the new File</param>
		/// <param name="group">The Group for the File</param>
		/// <param name="instance">The Instance of the FIle</param>
		/// <returns>The created PackedFileDescriptor</returns>
		IPackedFileDescriptor Add(uint type, uint subtype, uint group, uint instance);

		/// <summary>
		/// Ads a new Descriptor to the Index
		/// </summary>
		/// <param name="pfd">The PackedFile Descriptor</param>
		void Add(IPackedFileDescriptor pfd);

		/// <summary>
		/// Ads a new Descriptor to the Index
		/// </summary>
		/// <param name="pfd">The PackedFile Descriptor</param>
		/// <param name="isnew">truze, if offset should be set a unique Value</param>
		void Add(IPackedFileDescriptor pfd, bool isnew);

		/// <summary>
		/// Returns or Changes the stored Fileindex
		/// </summary>
		IPackedFileDescriptor[] Index 
		{
			get;
		}

		/// <summary>
		/// Creates a new File descriptor
		/// </summary>
		/// <returns>the new File descriptor</returns>
		IPackedFileDescriptor NewDescriptor(uint type, uint subtype, uint group, uint instance);


		#endregion

		#region Find Files
		/// <summary>
		/// Returns all Files that could contain a RCOL with the passed Filename
		/// </summary>
		/// <param name="filename">The Filename you are looking for</param>
		/// <returns>List of matching Files</returns>
		IPackedFileDescriptor[] FindFile(string filename);

		/// <summary>
		/// Returns all Files that could contain a RCOL with the passed Filename
		/// </summary>
		/// <param name="filename">The Filename you are looking for</param>
		/// <returns>List of matching Files</returns>
		IPackedFileDescriptor[] FindFile(string filename, uint type);

		/// <summary>
		/// Returns a List ofa all Files matching the passed type
		/// </summary>
		/// <param name="type">Type you want to look for</param>
		/// <returns>A List of Files</returns>
		IPackedFileDescriptor[] FindFiles(uint type);

		/// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="subtype">SubType you want to look for</param>
		/// <returns>The descriptor for the matching Dile or null</returns>
		IPackedFileDescriptor[] FindFile(uint subtype, uint instance);

		/// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="type">Type you want to look for</param>
		/// <returns>The descriptor for the matching Dile or null</returns>
		IPackedFileDescriptor[] FindFile(uint type, uint subtype, uint instance);


		/// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="pfd">Type you want to look for</param>
		/// <returns>The descriptor for the matching Dile or null</returns>
		IPackedFileDescriptor FindFile(Interfaces.Files.IPackedFileDescriptor pfd);

		// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="type">Type you want to look for</param>
		/// <returns>The descriptor for the matching File or null</returns>
		IPackedFileDescriptor FindFile(uint type, uint subtype, uint group, uint instance);

		/// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="pfd">Type you want to look for</param>
		/// <returns>The descriptor for the matching Dile or null</returns>
		IPackedFileDescriptor FindExactFile(Interfaces.Files.IPackedFileDescriptor pfd) ;

		/// <summary>
		/// Returns the first File matching 
		/// </summary>
		/// <param name="type">Type you want to look for</param>
		/// <returns>The descriptor for the matching Dile or null</returns>
		IPackedFileDescriptor FindExactFile(uint type, uint subtype, uint group, uint instance, uint offset); 
		

		/// <summary>
		/// Returns a List ofa all Files matching the passed group
		/// </summary>
		/// <param name="group">Group you want to look for</param>
		/// <returns>A List of Files</returns>
		IPackedFileDescriptor[] FindFilesByGroup(uint group);
		#endregion

		#region HoleIndex Handling
		/// <summary>
		/// Returns the FileIndexItem for the given File
		/// </summary>
		/// <param name="item">Number of the File within the FileIndex (0-Based)</param>
		/// <returns>The FileIndexItem for this Entry</returns>
		//HoleIndexItem GetHoleIndex(uint item);

				
		#endregion

		#region Header Handling
		/// <summary>
		/// The Structural Data of the Header
		/// </summary>
		Interfaces.Files.IPackageHeader Header
		{
			get;
		}
		#endregion

		#region File Handling
		/// <summary>
		/// True if the User has changed a PackedFile
		/// </summary>
		bool HasUserChanges
		{
			get;
		}

		/// <summary>
		/// Returns the FileName of the Current Package
		/// </summary>
		string FileName 
		{
			get;
		}

		/// <summary>
		/// Returns the hash Group Value for this File
		/// </summary>
		uint FileGroupHash 
		{
			get;
		}

		/// <summary>
		/// Reads the File specified by the given itemIndex
		/// </summary>
		/// <param name="item">the itemIndex for the File</param>
		/// <returns>The plain Content of the File</returns>
		IPackedFile Read(uint item);

		/// <summary>
		/// Reads a File specified by a FileIndexItem
		/// </summary>
		/// <param name="pfd">The PackedFileDescriptor</param>
		/// <returns>The plain Content of the File</returns>
		IPackedFile Read(IPackedFileDescriptor pfd);
		#endregion

		/// <summary>
		/// Close this Instance, leaving the FileDescripors valid
		/// </summary>
		void Close();

		/// <summary>
		/// Close this Instance
		/// </summary>
		/// <param name="total">true, if the FileDescriptors should be marked invalid</param>
		void Close(bool total);

		void Save();
		void Save(string filename);

		#region Events
		/// <summary>
		/// Derefers <see cref="IPackedFileDescriptor.DescriptionChanged"/> and 
		/// <see cref="IPackedFileDescriptor.ChangedData"/> for all stored Descriptors 
		/// until <see cref="EndUpdate"/> is called
		/// </summary>
		void BeginUpdate();

		/// <summary>
		/// Executes Events Derrefered by <see cref="BeginUpdate"/>
		/// </summary>
		void EndUpdate();

		/// <summary>
		/// Triggered whenever a new Resource was added
		/// </summary>
		event System.EventHandler AddedResource;

		/// <summary>
		/// Triggered whenever a Resource was Removed
		/// </summary>
		event System.EventHandler RemovedResource;

		/// <summary>
		/// Triggered whenever the Content of the Package was changed
		/// </summary>
		event System.EventHandler IndexChanged;
		#endregion
	}
}
