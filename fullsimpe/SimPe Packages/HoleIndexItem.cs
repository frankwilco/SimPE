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
	/// Structure of an HoleIndex Item
	/// </summary>
	public class HoleIndexItem
	{		

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="offset">the offset of the Hole</param>
		/// <param name="size">the size of the Hole</param>
		public HoleIndexItem (uint offset, int size) 
		{
			this.offset = offset;
			this.size = size;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		internal HoleIndexItem () {
			this.offset = 0;
			this.size = 0;
		}

		/// <summary>
		/// Location of the File within the Package
		/// </summary>
		internal uint offset;

		/// <summary>
		/// Returns the Location of the File within the Package
		/// </summary>
		public uint Offset
		{
			get 
			{
				return offset;
			}
			set { offset = value; }
		}



		/// <summary>
		/// Size of the compressed File
		/// </summary>		
		internal int size;

		/// <summary>
		/// Returns the Size of the File
		/// </summary>
		public virtual int Size
		{
			get 
			{
				return size;
			}
			set { size = value;}
		}

		/// <summary>
		/// return true if the passed Hole Index directly follows this one
		/// </summary>
		/// <param name="hii">another Hole</param>
		/// <returns>true if it follows the current Hole</returns>
		public bool IsMyFollowup(HoleIndexItem hii) 
		{
			return((offset+size)==hii.Offset);
		}
	}
}
