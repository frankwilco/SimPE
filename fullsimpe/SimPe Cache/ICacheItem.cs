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
using SimPe;

namespace SimPe.Cache
{

	/// <summary>
	/// Contains one CacheItem
	/// </summary>
	public interface ICacheItem
	{		
		/// <summary>
		/// Load the Item from the Stream
		/// </summary>
		/// <param name="reader">the Stream Reader</param>
		void Load(System.IO.BinaryReader reader);

		/// <summary>
		/// Save the Item to the Stream
		/// </summary>
		/// <param name="writer">the Stream Writer</param>
		void Save(System.IO.BinaryWriter writer) ;

		/// <summary>
		/// Returns the Version of this CacheItem
		/// </summary>
		byte Version 
		{
			get;
		}
	}
}
