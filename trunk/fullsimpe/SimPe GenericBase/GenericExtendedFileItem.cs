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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Use this class to implement specific FileItems
	/// </summary>
	public class GenericExtendedItem
	{
		/// <summary>
		/// The based FileItem
		/// </summary>
		private GenericCommon baseitem;

		/// <summary>
		/// Returns the based FileItem
		/// </summary>
		protected GenericCommon Base 
		{
			get 
			{
				return baseitem;
			}
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="item">The based GenericItem Object</param>
		public GenericExtendedItem(GenericCommon item)
		{
			baseitem = item;
		}

		/// <summary>
		/// This is used so you can easily create a new Object by assigning  a GenericItem Object
		/// </summary>
		/// <param name="item">The FileItem you want to convert from</param>
		/// <returns>The new ExtendedFileItem Object</returns>
		/// <remarks>Every derived class should Implement this for it's implementation!</remarks>
		public static implicit operator GenericExtendedItem(GenericItem item)
		{
			return new GenericExtendedItem(item);
		}	
	
		/// <summary>
		/// This is used so you can easily create a new Object by assigning  a GenericItem Object
		/// </summary>
		/// <param name="item">The Common Object you want to convert from</param>
		/// <returns>The new ExtendedFileItem Object</returns>
		/// <remarks>Every derived class should Implement this for it's implementation!</remarks>
		public static implicit operator GenericExtendedItem(GenericCommon item)
		{
			return new GenericExtendedItem(item);
		}	
	}
}
