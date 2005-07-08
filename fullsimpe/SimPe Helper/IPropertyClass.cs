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

namespace Ambertation
{
	/// <summary>
	/// This Interface has to be implemented by classes that should be lodable by the class directive
	/// in <see cref="Ambertation.PropertyParser"/>
	/// </summary>
	/// <remarks>
	/// Classes implementing this Interface MUST have a constructur that takes one object as argument!
	/// </remarks>
	public interface IPropertyClass
	{
		/// <summary>
		/// Create a new Instance of this Class
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		//IPropertyClass Create(object o);
	}
}
