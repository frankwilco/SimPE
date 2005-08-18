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
using System.IO;

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Structural Data of a .package Header
	/// </summary>
	public interface IPackageHeader
	{
		/// <summary>
		/// Returns the Identifier of the File
		/// </summary>
		/// <remarks>This value should be DBPF</remarks>
		string Identifier
		{
			get;
		}
		

		/// <summary>
		/// Returns the Major Version of The Packages FileFormat
		/// </summary>
		/// <remarks>This value should be 1</remarks>
		Int32 MajorVersion
		{
			get;
		}



		/// <summary>
		/// Returns the Minor Version of The Packages FileFormat 
		/// </summary>
		/// <remarks>This value should be 0 or 1</remarks>
		Int32 MinorVersion
		{
			get;
		}

		/// <summary>
		/// Returns the Overall Version of this Package
		/// </summary>
		long Version 
		{
			get;
		}

		/// <summary>
		/// Returns or Sets the Type of the Package
		/// </summary>
		Data.MetaData.IndexTypes IndexType
		{
			get;
			set;
		}

		/// <summary>
		/// true if the version is greater or equal than 1.1
		/// </summary>
		bool IsVersion0101
		{
			get;
		}

		/// <summary>
		/// Returns Index Informations stored in the Header
		/// </summary>
		IPackageHeaderIndex Index
		{
			get;
		}

		/// <summary>
		/// Returns Hole Index Informations stored in the Header
		/// </summary>
		IPackageHeaderHoleIndex HoleIndex
		{
			get;
		}

		/// <summary>
		/// This is missused in SimPE as a Unique Creator ID
		/// </summary>
		uint Created
		{
			get;
			set;
		}
	}
}
