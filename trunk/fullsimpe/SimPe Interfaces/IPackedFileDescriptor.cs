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

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Interface for PackedFile Descriptors
	/// </summary>
	public interface IPackedFileDescriptor
	{
		/// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Cloned Object</returns>
		IPackedFileDescriptor Clone();

		/// <summary>
		/// Returns the Offset within the Package File
		/// </summary>
		uint Offset
		{
			get; 			
		}

		/// <summary>
		/// Returns the Size of the referenced File
		/// </summary>
		/// <remarks>
		/// This must return either the size stored in the Index or the Size of the Userdata (if defined)
		/// </remarks>
		int Size
		{
			get; 			
		}

		/// <summary>
		/// Returns the Size of the File as stored in the Index
		/// </summary>
		/// <remarks>
		/// This must return the size of the File as it was stored in the Fileindex, 
		/// even if the Size did change! (it is used during the IncrementalBuild Methode of a Package File!)
		/// If the file is new, this value must return 0.
		/// </remarks>
		int IndexedSize 
		{
			get;
		}
		
		/// <summary>
		/// Returns the Type of the referenced File
		/// </summary>
		UInt32 Type
		{
			get; 
			set;
		}

		/// <summary>
		/// Returns the Name of the represented Type
		/// </summary>
		Data.TypeAlias TypeName 
		{
			get;
		}

		/// <summary>
		/// Returns the Name of the represented Type
		/// </summary>
		/*Data.TypeAlias TypeName 
		{
			get;
		}*/

		/// <summary>
		/// Returns the Group the referenced file is assigned to
		/// </summary>
		UInt32 Group
		{
			get;
			set;
		}



		/// <summary>
		/// Returns the Instance Data
		/// </summary>
		UInt32 Instance
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the Long Instance
		/// </summary>
		/// <remarks>Combination of SubType and Instance</remarks>
		UInt64 LongInstance
		{
			get;
			set;
		}


		/// <summary>
		/// Returns an yet unknown Type
		/// </summary>		
		/// <remarks>Only in Version 1.1 of package Files</remarks>
		UInt32 SubType
		{
			get; 
			set;
		}

		/// <summary>
		/// Returns or Sets the Filename
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		string Filename 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns or Setst the File Path
		/// </summary>
		/// <remarks>This is mostly of intrest when you extract packedFiles</remarks>
		string Path
		{
			get;
			set;
		}


		/// <summary>
		/// Generates MetInformations about a Packed File
		/// </summary>
		/// <param name="pfd">The description of the File</param>
		/// <returns>A String representing the Description as XML output</returns>
		string GenerateXmlMetaInfo();	
	
		/// <summary>
		/// Returns true if theis File was changed since the last Save
		/// </summary>
		bool Changed
		{
			get;
			set;
		}

		/// <summary>
		/// Returns true, if Userdate is available
		/// </summary>
		/// <remarks>This happens when a user assigns new Data</remarks>
		bool HasUserdata
		{
			get;
		}		

		/// <summary>
		/// Puts Userdefined Data into the File
		/// </summary>
		byte[] UserData 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns/sets if this file should be keept in the Index for the next Save
		/// </summary>
		bool MarkForDelete  
		{
			get;
			set;
		}

		/// <summary>
		/// Returns/sets if this File should be Recompressed during the next Save Operation
		/// </summary>
		bool MarkForReCompress
		{
			get;
			set;
		}

		/// <summary>
		/// Must override the Equals Method!
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		bool Equals(object obj);

		/// <summary>
		/// additional Data
		/// </summary>
		object Tag 
		{
			get;
			set;
		}

		/// <summary>
		/// Close this Descriptor (make it invalid)
		/// </summary>
		void MarkInvalid();

		/// <summary>
		/// true, if this Descriptor is Invalid
		/// </summary>
		bool Invalid
		{
			get;
		}

		/// <summary>
		/// Called whenever the content represented by this descripotr was changed
		/// </summary>
		PackedFileChanged ChangedUserData
		{
			get;
			set;
		}

		/// <summary>
		/// Called whenever the Desciptor get's invalid
		/// </summary>
		event PackedFileChanged Closed;

		/// <summary>
		/// Triggered whenever the Content of the Descriptor was changed
		/// </summary>
		event System.EventHandler DescriptionChanged;

		/// <summary>
		/// Triggered whenever the Descriptor get's AMrked for Deletion
		/// </summary>
		event System.EventHandler Deleted;
	}
}
