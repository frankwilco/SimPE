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

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// An Item in the FileIndex
	/// </summary>
	public interface IScenegraphFileIndexItem
	{
		/// <summary>
		/// The Descriptor of that File
		/// </summary>
		/// <remarks>Contains the original Group </remarks>
		SimPe.Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get;
			set;
		}

		/// <summary>
		/// The Descriptor of that File, with a real Group value
		/// </summary>
		/// <returns>A Clonde FileDescriptor, that contains the correct Group</returns>
		/// <remarks>Contains the local Group (can never be 0xffffffff)</remarks>
		SimPe.Interfaces.Files.IPackedFileDescriptor GetLocalFileDescriptor();

		/// <summary>
		/// The package the File is stored in
		/// </summary>
		SimPe.Interfaces.Files.IPackageFile Package
		{
			get;
		}

		/// <summary>
		/// Get the Local Group alue used for this Package
		/// </summary>
		uint LocalGroup
		{
			get;
		}
	}
}
