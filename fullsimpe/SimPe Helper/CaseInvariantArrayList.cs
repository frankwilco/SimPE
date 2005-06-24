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
	/// List that handles Strings case Invariant
	/// </summary>
	public class CaseInvariantArrayList : System.Collections.ArrayList
	{
		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public override bool Contains(object o)
		{
			if (o is string) 
			{
				string s = (string)o;
				s = s.ToLower();
				foreach(object i in this) 
				{
					if (i==null) continue;
					if (i is string) 
						if (((string)i).ToLower() == s) 
							return true;
				}

				return false;
			}
			else return base.Contains(o);
		}	

		public override void Remove(object obj)
		{
			if (obj is string) 
			{
				string s = (string)obj;
				s = s.ToLower();
				for (int k=0; k<this.Count; k++)
				{
					object i = this[k];
					if (i==null) continue;
					if (i is string) 
						if (((string)i).ToLower() == s) 
						{
							base.RemoveAt(k);
							return;
						}
				}
					
			} 
			else 
			{
				base.Remove (obj);
			}
		}

	}
}
