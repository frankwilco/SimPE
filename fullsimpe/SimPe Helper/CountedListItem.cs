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

namespace SimPe
{
	/// <summary>
	/// Can be used as a Wrapper Class when adding unnamed Objects to a List
	/// </summary>
	public class CountedListItem : System.IDisposable
	{
		object obj;
		bool hex;

		/// <summary>
		/// Returns/Sets the stored Object
		/// </summary>
		public object Object
		{
			get { return obj; }
			set { obj = value; }
		}

		int index;
		internal CountedListItem(int index, object obj, bool hex)
		{
			this.obj = obj;
			this.index = index;
			this.hex = hex;
		}

		public override string ToString()
		{
			if (hex) 
			{
				return "0x"+index.ToString("X")+": "+obj.ToString();
			} else return index.ToString()+": "+obj.ToString();
		}


		static int offset = 0;
		/// <summary>
		/// Returns/Sets the lowest Number used for the Index
		/// </summary>
		public static int Offset 
		{
			get { return offset; }
			set { offset = value; }
		}

		/// <summary>
		/// Adds an Item to the given ComboBox
		/// </summary>
		/// <param name="cb">The ComboBox</param>
		/// <param name="obj">The Item you want to add</param>
		public static void Add(System.Windows.Forms.ComboBox cb, object obj) 
		{
			cb.Items.Add(new CountedListItem(cb.Items.Count+offset, obj, false));
		}

		/// <summary>
		/// Adds an Item to the given ListBox
		/// </summary>
		/// <param name="lb">The ListBox</param>
		/// <param name="obj">The Item you want to add</param>
		public static void Add(System.Windows.Forms.ListBox lb, object obj) 
		{
			lb.Items.Add(new CountedListItem(lb.Items.Count+offset, obj, false));
		}

		/// <summary>
		/// Adds an Item to the given ComboBox
		/// </summary>
		/// <param name="cb">The ComboBox</param>
		/// <param name="obj">The Item you want to add</param>
		public static void AddHex(System.Windows.Forms.ComboBox cb, object obj) 
		{
			cb.Items.Add(new CountedListItem(cb.Items.Count+offset, obj, true));
		}

		/// <summary>
		/// Adds an Item to the given ListBox
		/// </summary>
		/// <param name="lb">The ListBox</param>
		/// <param name="obj">The Item you want to add</param>
		public static void AddHex(System.Windows.Forms.ListBox lb, object obj) 
		{
			lb.Items.Add(new CountedListItem(lb.Items.Count+offset, obj, true));
		}

		#region IDisposable Member

		public void Dispose()
		{
			this.obj = null;
		}

		#endregion
	}
}
