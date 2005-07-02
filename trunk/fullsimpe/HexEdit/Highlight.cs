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

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// This Class determins a Highlighted Section
	/// </summary>
	public class Highlight 
	{
		int start, len, max;
		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="start"></param>
		/// <param name="len"></param>
		/// <param name="max"></param>
		public Highlight(int start, int len, int max)
		{
			this.Maximum = max;
			this.len = len;
			Start = start;			
		}

		/// <summary>
		/// Returns or Sets the start of the Highlight
		/// </summary>
		public int Start
		{
			get {return start; }
			set {
				start =  Math.Min(max-1, Math.Max(0, value)); 
				Length = len;
			}
		}

		/// <summary>
		/// Returns or Sets the length of the Highlight
		/// </summary>
		public int Length 
		{
			get {return len; }
			set {len = Math.Max(0, Math.Min(max-start, value)); }
		}

		/// <summary>
		/// Returns the Last selected Position
		/// </summary>
		public int End 
		{
			get {return start+len-1;}
		}

		/// <summary>
		/// Changes the allowed Maximum
		/// </summary>
		internal int Maximum 
		{
			set 
			{ 
				if (max!=value) 
				{
					max = value;
					len = 0;
					start = 0;
				}
			}
		}

		/// <summary>
		/// true if the Offset is within this Highlight
		/// </summary>
		/// <param name="offset"></param>
		/// <returns></returns>
		public bool Contains(int offset)
		{
			return (offset>=Start && offset<=End );
		}
	}
}

namespace Ambertation.Collections
{

	/// <summary>
	/// Typesave ArrayList for Highlight Objects
	/// </summary>
	public class Highlights : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Ambertation.Windows.Forms.Highlight this[int index]
		{
			get { return ((Ambertation.Windows.Forms.Highlight)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Ambertation.Windows.Forms.Highlight this[uint index]
		{
			get { return ((Ambertation.Windows.Forms.Highlight)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		internal  int Add(Ambertation.Windows.Forms.Highlight item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		internal void Insert(int index, Ambertation.Windows.Forms.Highlight item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		internal void Remove(Ambertation.Windows.Forms.Highlight item)
		{
			base.Remove(item);
		}		

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Ambertation.Windows.Forms.Highlight item)
		{
			return base.Contains(item);
		}		

		/// <summary>
		/// Number of stored Elements
		/// </summary>
		public int Length 
		{
			get { return this.Count; }
		}

		/// <summary>
		/// Create a clone of this Object
		/// </summary>
		/// <returns>The clone</returns>
		internal new object Clone()
		{
			Highlights list = new Highlights();
			foreach (Ambertation.Windows.Forms.Highlight item in this) list.Add(item);

			return list;
		}
	}
}
