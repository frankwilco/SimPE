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
using SimPe.Interfaces.Files;

namespace SimPe.Interfaces.Providers
{
	/// <summary>
	/// Interface to obtain the SimFamilyNames Alias List from the Type Registry
	/// </summary>
	public interface ISimFamilyNames : ICommonPackage
	{		
		/// <summary>
		/// Returns the the Alias with the specified Type
		/// </summary>
		/// <param name="id">The id of a Sim</param>
		/// <returns>The Alias of the Sim</returns>
		IAlias FindName(uint id);

		/// <summary>
		/// Returns a List of All SimID's found in the Package
		/// </summary>
		/// <returns>The List of found SimID's</returns>
		ArrayList GetAllSimIDs();
	}
}
