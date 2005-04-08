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
using SimPe.Cache;

namespace SimPe.Interfaces.Plugin.Scanner
{
	/// <summary>
	/// Determins the Type of a Plugin
	/// </summary>
	public enum ScannerPluginType : byte
	{
		None = 0x0,
		Scanner = 0x1,
		Identifier = 0x2,
		Both = 0x03,
	}

	/// <summary>
	/// Implements the very basic Interface for a Scanner/Identifier, 
	/// this is used to determin wether or not a Scanner/Identifier can be loaded!
	/// </summary>
	public interface IScannerPluginBase
	{	
		/// <summary>
		/// Returns the Version of the IIdentifier Interface the scanner/identifier is implementing
		/// </summary>
		/// <remarks>
		/// The current Scan Folders Plugin will only process Scanners/identifiers 
		/// with a Version of 1
		/// </remarks>
		uint Version 
		{
			get;
		}

		/// <summary>
		/// Returns the Position of the Index in the ScanList
		/// </summary>
		/// <remarks>
		/// Identifiers are ordere, meaning you can determin in which order the 
		/// scanners are called, specifiyinga low index (negative) will make a 
		/// Identifier to be executed early, a High Index will execute it later
		/// </remarks>
		int Index 
		{
			get;
		}

		/// <summary>
		/// Returns the Interface that is implemented by the Plugin
		/// </summary>
		ScannerPluginType PluginType 
		{
			get;
		}
	}	

	/// <summary>
	/// Identifies the Type of a Package
	/// </summary>
	public interface IIdentifier : IScannerPluginBase
	{
		/// <summary>
		/// Retunrs the Primary Type of the passed Pacakge
		/// </summary>
		/// <param name="pkg">The Package too check</param>
		/// <returns>The type</returns>
		/// <remarks>Returns Unknown if this Identifier was unable to determin the Type</remarks>
		PackageType GetType(IPackageFile pkg);
	}
}
