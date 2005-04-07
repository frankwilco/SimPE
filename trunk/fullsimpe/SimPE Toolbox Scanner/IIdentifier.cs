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
using SimPe.Interfaces.Files;
using SimPe.Cache;

namespace SimPe.Plugin
{
	/// <summary>
	/// Identifies the Type of a Package
	/// </summary>
	internal interface IIdentifier
	{
		/// <summary>
		/// Retunrs the Primary Type of the passed Pacakge
		/// </summary>
		/// <param name="pkg">The Package too check</param>
		/// <returns>The type</returns>
		/// <remarks>Returns Unknown if this Identifier was unable to determin the Type</remarks>
		PackageType GetType(IPackageFile pkg);
	}
}
