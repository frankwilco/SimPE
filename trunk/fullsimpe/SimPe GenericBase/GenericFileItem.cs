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
	/// A SubItem of a Generic File
	/// </summary>
	public class GenericItem : GenericCommon
	{
		/// <summary>
		/// SubItems
		/// </summary>
		private GenericItem[] subitems = null;

		/// <summary>
		/// Returns or sets the List of Subitems
		/// </summary>
		public GenericItem[] Subitems
		{
			get 
			{
				return GetSubitems();
			}
			set 
			{
				subitems = value;
			}
		}

		/// <summary>
		/// Number of Subitems stored
		/// </summary>
		public int Count 
		{
			get 
			{
				if (subitems!=null) 
				{
					return subitems.Length;
				} 
				else 
				{
					return 0;
				}
			}
		}

		/// <summary>
		/// Returns the List of Subitems
		/// </summary>
		protected GenericItem[] GetSubitems()
		{
			if (subitems==null) 
			{
				return new GenericItem[0];
			} 
			else 
			{
				return subitems;			
			}
		}
	}	
}
