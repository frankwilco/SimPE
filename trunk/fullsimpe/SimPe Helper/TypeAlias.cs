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

namespace SimPe.Data
{
	/// <summary>
	/// Conects an Type Id Value with a name
	/// </summary>
	public sealed class TypeAlias : Alias
	{

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="shortname">The short name</param>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		public TypeAlias(bool containsflname, string shortname, uint val, string name) : base(val, name)
		{
			this.shortname = shortname;
			this.extension = null;
			knowntype = true;
			this.containsfilename = containsflname;
		}

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="shortname">The short name</param>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		/// <param name="extension">proposed File Extension</param>
		/// <param name="containsflname">true if the first 64 Bytes are the Filename</param>
		/// <param name="known">true if the filetype is known(default)</param>
		public TypeAlias(bool containsflname, string shortname, uint val, string name, string extension) : this(containsflname, shortname, val, name,extension, true)
		{
		}

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="shortname">The short name</param>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		/// <param name="extension">proposed File Extension</param>
		/// <param name="containsflname">true if the first 64 Bytes are the Filename</param>
		/// <param name="known">true if the filetype is known(default)</param>
		public TypeAlias(bool containsflname, string shortname, uint val, string name, string extension, bool known) : base(val, name)
		{
			this.shortname = shortname;
			this.extension = extension;
			this.knowntype = known;
			this.containsfilename = containsflname;
		}

		/// <summary>
		/// true, if the Type is known
		/// </summary>
		private bool knowntype;

		/// <summary>
		/// Cosntructor of the class
		/// </summary>
		/// <param name="shortname">The short name</param>
		/// <param name="val">The id</param>
		/// <param name="name">The name</param>
		/// <param name="known">true if the filetype is known(default)</param>
		public TypeAlias(bool containsflname, string shortname, uint val, string name, bool known) : base(val, name)
		{

			this.shortname = shortname;
			this.extension = "";
			knowntype = known;
			this.containsfilename = containsflname;
		}

		/// <summary>
		/// True if the first 64 Byte of this Type are interpreted as Filename
		/// </summary>
		public bool containsfilename;

		/// <summary>
		/// The associated short name
		/// </summary>
		public string shortname;

		/// <summary>
		/// null, or a proposed File extension
		/// </summary>
		private string extension;

		/// <summary>
		/// Returns the default Extension
		/// </summary>
		public string Extension 
		{
			get 
			{
				if (extension==null) return "simpe";
				else if (extension=="") return "simpe";
				
				return extension;
			}
		}

		/// <summary>
		/// Craetes a String from the Object
		/// </summary>
		/// <returns>Simply Returns the Name Attribute</returns>
		public override string ToString()
		{
			return Name;
		}

		/// <summary>
		/// Returns true if the Type is known
		/// </summary>
		public bool Known
		{
			get 
			{
				return knowntype;
			}
		}

	}
}
