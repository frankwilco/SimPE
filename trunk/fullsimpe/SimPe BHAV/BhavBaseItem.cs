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

namespace SimPe.Plugin
{
	/// <summary>
	/// Class Providing a Package and an Ocode Provider
	/// </summary>
	public class BhavBaseItem
	{
		/// <summary>
		/// contains the list of Opcode Names
		/// </summary>
		//protected static SimPe.Interfaces.Providers.IOpcodeProvider opcodes;

		/// <summary>
		/// contains a package fiel or null
		/// </summary>
		protected static SimPe.Interfaces.Files.IPackageFile package;

		/// <summary>
		/// Returns /Setst the OpcodeProvider
		/// </summary>
		/*public static SimPe.Interfaces.Providers.IOpcodeProvider OpcodeProvider 
		{
			get { return opcodes; }
			set { opcodes = value; }
		}*/

		/// <summary>
		/// Returns / Sets the Package
		/// </summary>
		public static SimPe.Interfaces.Files.IPackageFile Package 
		{
			get { return package; }
			set { package = value; }
		}

		
	}
}
