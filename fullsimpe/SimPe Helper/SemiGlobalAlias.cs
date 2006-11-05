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
	/// Overrides the Alias class
	/// </summary>
	public class SemiGlobalAlias : Data.Alias , IComparable<SemiGlobalAlias>
	{
		/// <summary>
		/// true, if this can be used as a valid Global
		/// </summary>
		bool known;

		public SemiGlobalAlias(uint id, string name) : base (id, name) 
		{
			known = false;
		}

		public SemiGlobalAlias(bool known, uint id, string name) : base (id, name) 
		{
			this.known = known;
		}

		/// <summary>
		/// returns true if this Global is know for certain
		/// </summary>
		public bool Known 
		{
			get { return known; }
		}

		public override string ToString()
		{
			return this.Name;
		}


        #region IComparable<SemiGlobalAlias> Member

        public int CompareTo(SemiGlobalAlias other)
        {
            return ToString().CompareTo(other.ToString());
        }

        #endregion
    }
}
