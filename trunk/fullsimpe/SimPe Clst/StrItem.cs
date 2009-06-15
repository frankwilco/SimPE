/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2005 by Peter L Jones (blame me for string bugs!)       *
 *   pljones@users.sf.net                                                  *
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
using System.IO;

namespace SimPe.PackedFiles.Wrapper
{
	#region StrLanguage
	/// <summary>
	/// This class exists:
	/// - to provide access to Language Names given a Language ID
	/// - to make Language IDs comparable so that StrLanguageLists can be sorted
	/// </summary>
	public class StrLanguage : System.Collections.IComparer
	{
		/// <summary>
		/// Language ID
		/// </summary>
		byte lid;

		/// <summary>
		/// Constructor
		/// This is the only way to set the Language ID
		/// </summary>
		/// <param name="lid">The Language ID</param>
		public StrLanguage(byte lid)
		{
			this.lid = lid;
		}


		#region Accessor methods
		/// <summary>
		/// Returns/Sets the Language Id
		/// </summary>
		public byte Id
		{
			get { return lid;}
		}

		/// <summary>
		/// Returns the Language Name
		/// </summary>
		public string Name
		{
			get
			{
				string enumName = ((Data.MetaData.Languages)lid).ToString();
				string s = Localization.Manager.GetString( enumName );
				if (s != null) return s;
				return enumName;
			}
		}
		#endregion

		#region Cast methods
		public override string ToString()
		{
			return "0x" + Helper.HexString(lid) + " - " + this.Name;
		}

		// Enable casting byte to StrLanguage
		public static implicit operator StrLanguage(byte val)
		{
			return new StrLanguage(val);
		}

		// Enable casting StrLanguage to byte
		public static implicit operator byte(StrLanguage val)
		{
			return val.Id;
		}
		#endregion

		public override bool Equals(object obj)
		{
			if (obj.GetType() == typeof(StrLanguage))
				return (lid == ((StrLanguage)obj).Id);
			return base.Equals(obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		#region IComparer Member
		/// <summary>
		/// Allow StrLanguage and byte objects to be compared
		/// </summary>
		/// <param name="x">First item (StrLanguage, byte)</param>
		/// <param name="y">Second Item (StrLanguage, byte)</param>
		/// <returns>Comparison value or "equal" if invalid object types passed</returns>
		public int Compare(object x, object y)
		{
			int a, b;

			if (x.GetType() == typeof(StrLanguage))	a = ((StrLanguage)x).Id;
			else if (x.GetType()==typeof(byte))		a = (byte)x;
			else									return 0;

			if (y.GetType() == typeof(StrLanguage))	b = ((StrLanguage)y).Id;
			else if (y.GetType()==typeof(byte))		b = (byte)y;
			else									return 0;

			return b - a;
		}
		#endregion
	}
	#endregion


	#region StrLanguageList
	/// <summary>
	/// Typesave ArrayList for StrItem Objects
	/// </summary>
	public class StrLanguageList : ArrayList
	{
		public new StrLanguage this[int index]
		{
			get { return ((StrLanguage)base[index]); }
			set { base[index] = value; }
		}

		public int Add(StrLanguage strlng)
		{
			return base.Add(strlng);
		}

		public void Insert(int index, StrLanguage strlng)
		{
			base.Insert(index, strlng);
		}

		public void Remove(StrLanguage strlng)
		{
			base.Remove(strlng);
		}

		public bool Contains(StrLanguage strlng)
		{
			return base.Contains(strlng);
		}

		public int Length
		{
			get { return this.Count; }
		}

		public override void Sort()
		{
			StrLanguage sl = new StrLanguage(0);
			base.Sort(sl);
		}
	}
	#endregion


	#region StrItem
	/// <summary>
	/// An Item stored in a STR# File
	/// </summary>
	public class StrToken
	{
		int index;
		StrLanguage lid;
		string title;
		string desc;
		/// <summary>
		/// Indicates whether the object has been updated since creation (can't be cleared!)
		/// </summary>
		bool dirty;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="index">hack to give line numbers</param>
		/// <param name="lid">Language ID (byte)</param>
		/// <param name="title">Item Title</param>
		/// <param name="desc">Item Description</param>
		public StrToken(int index, byte lid, string title, string desc)
		{
			this.index = index;
			this.lid = new StrLanguage(lid);
			this.title = title;
			this.desc = desc;
			dirty = false;
		}


		#region Accessor methods
		internal int Index
		{
			get {return index; }
		}
		/// <summary>
		/// Language is read-only
		/// </summary>
		public StrLanguage Language
		{
			get { return lid; }
		}

		public string Title
		{
			get { return title; }
			set { if (title != value) { title = value; dirty = true; } }
		}

		public string Description
		{
			get { return desc; }
			set { if (desc != value) { desc = value; dirty = true; } }
		}

		/// <summary>
		/// Dirty is read-only
		/// </summary>
		public bool IsDirty
		{
			get { return dirty; }
		}
		#endregion


		#region Serialize / Unserialize
		/*
		 * File format is:
		 * byte - Language ID
		 * char[]\0 - Title
		 * char[]\0 - Description
		 */
		internal static void Unserialize(BinaryReader reader, Hashtable lines)
		{
			StrLanguage lid = new StrLanguage(reader.ReadByte());
			string title = StreamHelper.ReadPChar(reader);
			string desc = StreamHelper.ReadPChar(reader);

			if (lines[lid.Id] == null) lines[lid.Id] = new StrItemList(); // Add a new StrItemList if needed

			((StrItemList)lines[lid.Id]).Add(new StrToken(((StrItemList)lines[lid.Id]).Count, lid, title, desc));
		}


		internal void Serialize(BinaryWriter writer)
		{
			if (lid   != null) writer.Write(lid.Id); else writer.Write((byte)0);
            if (title != null) StreamHelper.WritePChar(writer, title); else StreamHelper.WritePChar(writer, "");
            if (desc != null) StreamHelper.WritePChar(writer, desc); else StreamHelper.WritePChar(writer, "");
//			dirty = false;
			// Mmm, "dirty" means what?  OK, so I added it...
		}
		#endregion

		public override string ToString()
		{
			return "0x" + index.ToString("X") + " - " + this.Title;
		}

	}
	#endregion


	#region StrItemList
	/// <summary>
	/// Typesave ArrayList for StrItem Objects
	/// </summary>
	public class StrItemList : ArrayList
	{
		public new StrToken this[int index]
		{
			get { return ((StrToken)base[index]); }
			set { base[index] = value; }
		}

		public StrToken this[uint index]
		{
			get { return ((StrToken)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(StrToken stritem)
		{
			return base.Add(stritem);
		}

		public void Insert(int index, StrToken stritem)
		{
			base.Insert(index, stritem);
		}

		public void Remove(StrToken stritem)
		{
			base.Remove(stritem);
		}

		public bool Contains(StrToken stritem)
		{
			return base.Contains(stritem);
		}

		public int Length
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			StrItemList sil = new StrItemList();
			foreach (StrToken si in this) sil.Add(si);

			return sil;
		}

	}
	#endregion
}
