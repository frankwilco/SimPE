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

namespace SimPe.Cache
{
	/// <summary>
	/// a Cache Exception
	/// </summary>
	public class CacheException : Exception
	{
		string filename;
		byte ver;

		/// <summary>
		/// Creaet a new Instance of the Exception
		/// </summary>
		/// <param name="message">The Message</param>
		/// <param name="filename">the Name of the Cache File (can be null)</param>
		/// <param name="version">the Version of the Cache File</param>
		public CacheException(string message, string filename, byte version) : base(message + " (file="+filename+", version="+version.ToString()+")")
		{
			this.filename = filename;
			this.ver = version;
		}
	}
}
