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

namespace SimPe.Interfaces.Providers
{
	/// <summary>
	/// Interface to obtain the SimNames Alias List from the Type Registry
	/// </summary>
	public interface ISimNames
	{
		/// <summary>
		/// Returns or sets the Folder where the Character Files are stored
		/// </summary>
		/// <remarks>Automatically Updates the stored Names</remarks>
		string BaseFolder
		{
			get;
			set;
		}

		/// <summary>
		/// Returrns the stored Alias Data (key is the simid, value an IAlias Object)
		/// </summary>
		Hashtable StoredData 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the the Alias with the specified Type
		/// </summary>
		/// <param name="id">The id of a Sim</param>
		/// <returns>The Alias of the Sim</returns>
		IAlias FindName(uint id);
	}
}
