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

namespace SimPe.Packages
{
	/// <summary>
	/// Hole Index of the File
	/// </summary>
	/// <remarks>
	/// Holes ar simple Placeholders filled with Data currently nor usefull.
	/// </remarks>
	public class HeaderHole : SimPe.Interfaces.Files.IPackageHeaderHoleIndex
	{
		/// <summary>
		/// Number of Holes stored in the File
		/// </summary>
		internal Int32 count;

		/// <summary>
		/// Returns the Number of items stored in the Index
		/// </summary>
		public int Count
		{
			get	{ return count; }
			set { count = value; }
		}



		/// <summary>
		/// Offset for the Hole Index
		/// </summary>
		internal uint offset;

		/// <summary>
		/// Returns the Offset for the Hole Index
		/// </summary>
		public uint Offset
		{
			get	{ return offset; }
			set { offset = value; }
		}



		/// <summary>
		/// Size of the Hole Index
		/// </summary>
		internal Int32 size;

		/// <summary>
		/// Returns the Size of the Hole Index
		/// </summary>
		public int Size
		{
			get	{ return size; }
			set { size = value; }
		}


		/// <summary>
		/// Returns the size of One Item stored in the index
		/// </summary>
		public virtual int ItemSize
		{
			get 
			{				
				if (Count!=0) 
				{
					return Size/Count;
				} 
				else 
				{
					return 0;
				}
				
			}
		}
	}

}