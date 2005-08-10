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

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// Specialization of an IRcol Interface, providing additional Methods to find refereced Scenegraph Resources
	/// </summary>
	public interface IScenegraphItem
	{
		/// <summary>
		/// Returns all Referenced Scenegraph Resources sorted by type of Reference
		/// </summary>
		/// <remarks>The Key is the name of the Reference Type, the value is an ArrayList containing all ReferencedFiles</remarks>
		Hashtable ReferenceChains
		{
			get;
		}
		
		/// <summary>
		/// Returns the first Referenced RCOL Resource for the passed Type
		/// </summary>
		/// <param name="type">Type of the Resource you are looking for</param>
		/// <returns>Descriptor for the first found RCOL Resource or null</returns>
		//FindReferencedType(uint type);
	}
}
