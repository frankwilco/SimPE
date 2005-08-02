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
using SimPe.Interfaces.Files;

namespace SimPe.Interfaces.Plugin.Internal
{
	
	/// <summary>
	/// Interface for Filehanders that are able to save their content to a BinaryStream
	/// </summary>
	/// <remarks>If you want to Implement a Wrapper you must use the SimPe.Interfaces.Plugin.IFileWrapperSaveExtension</remarks>
	public interface IPackedFileSaveExtension
	{
		/// <summary>
		/// Returns the FileDescriptor Associated with the File
		/// </summary>
		/// <remarks>
		/// When the Descriptor is returned, make sure that the userdata is not out of Data;
		/// </remarks>
		IPackedFileDescriptor FileDescriptor 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the current Stream (the Data that is stored in the Attributes of the wrapper)
		/// </summary>
		/// <remarks>
		/// This Property is used to process the SynchronizeUserData() Command, and returns 
		/// the BinaryStream representation of the current State of this Wrapper.
		/// </remarks>
		System.IO.MemoryStream CurrentStateData 
		{
			get;
		}

		/// <summary>
		/// Used to update the UserData contained in a Packed File
		/// </summary>
		void SynchronizeUserData();

		/// <summary>
		/// Saves the data representet by this Objet to the writer
		/// </summary>
		/// <param name="writer">The BinaryWriter</param>
		/// <returns>The Size of the Datat written</returns>
		int Save(System.IO.BinaryWriter writer);
		
		/// <summary>
		/// Saves the data in the UserData Attribute of a PackedFileDescriptor
		/// </summary>
		/// <param name="pfd">The Descriptor you where you want to store the Data in</param>
		void Save(IPackedFileDescriptor pfd);	
	
		/// <summary>
		/// true if the stored Data was changed but SynchronizeUserData wasn't called
		/// </summary>
		bool Changed 
		{
			get;
			set;
		}
	}
}
