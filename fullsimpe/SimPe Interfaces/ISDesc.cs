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
using System.Drawing;

namespace SimPe.Interfaces.Wrapper
{
	/// <summary>
	/// Interface for Sim Description Files
	/// </summary>
	public interface ISDesc
	{
		/// <summary>
		/// Returns/Sets the Sim Id
		/// </summary>
		uint SimId
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the FirstName of a Sim 
		/// </summary>
		/// <remarks>If no SimName Provider is available, '---' will be delivered</remarks>
		string SimName 
		{
			get;
		}

		/// <summary>
		/// Returns the Image stored for a specific Sim
		/// </summary>
		System.Drawing.Image Image 
		{
			get;
		}

		/// <summary>
		/// Returns the Name of the File the Character is stored in
		/// </summary>
		/// <remarks>null, if no File was found</remarks>
		string CharacterFileName
		{
			get;
		}

		/// <summary>
		/// Returns or Sets the Instance Number
		/// </summary>
		ushort Instance 
		{
			get;
			set;
		}

		/// <summary>
		/// Returs /Sets the Family Instance
		/// </summary>
		ushort FamilyInstance 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the FamilyName of a Sim 
		/// </summary>
		/// <remarks>If no SimFamilyName Provider is available, '---' will be delivered</remarks>
		string SimFamilyName 
		{
			get;
		}

		/// <summary>
		/// Returns the FamilyName of a Sim that is stored in the current Package
		/// </summary>
		/// <remarks>If no SimFamilyName Provider is available, '---' will be delivered</remarks>
		string HouseholdName
		{
			get;
		}

		/// <summary>
		/// Returns the Filedescriptor used to obtain the current Data
		/// </summary>
		Files.IPackedFileDescriptor FileDescriptor 
		{
			get;
		}
	}
}
