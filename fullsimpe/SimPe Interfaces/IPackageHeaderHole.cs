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

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Hole Index of the File
	/// </summary>
	/// <remarks>
	/// Holes ar simple Placeholders filled with Data currently nor usefull.
	/// </remarks>
	public interface IPackageHeaderHoleIndex
	{
		/// <summary>
		/// Returns the Number of items stored in the Index
		/// </summary>
		int Count
		{
			get;
			set;
		}



		/// <summary>
		/// Returns the Offset for the Hole Index
		/// </summary>
		uint Offset
		{
			get;
			set;
		}



		/// <summary>
		/// Returns the Size of the Hole Index
		/// </summary>
		int Size
		{
			get;
			set;
		}


		/// <summary>
		/// Returns the size of One Item stored in the index
		/// </summary>
		int ItemSize
		{
			get;
		}
	}
}
