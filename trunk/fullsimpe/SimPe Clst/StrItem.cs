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
using System.IO;

namespace SimPe.PackedFiles.Wrapper
{
	public class StrLanguage : System.Collections.IComparer
	{

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="lid">The Language eID</param>
		public StrLanguage(byte lid) 
		{
			this.lid = lid;
		}


		byte lid;
		/// <summary>
		/// Retusn the Language Id
		/// </summary>
		public byte Id
		{
			get { return lid;}
			set { lid = value; }
		}

		public override string ToString()
		{
			string txt = "0x"+Helper.HexString(lid)+" - ";
			string s = Localization.Manager.GetString(((Data.MetaData.Languages)lid).ToString());
			if (s!=null) return txt+s;
			else return txt+((Data.MetaData.Languages)lid).ToString();			
		}

		public static implicit operator StrLanguage(byte val)
		{
			return new StrLanguage(val);
		}

		public static implicit operator byte(StrLanguage val)
		{
			return val.Id;
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType()==typeof(StrLanguage)) 
			{
				StrLanguage sl = (StrLanguage)obj;
				return (Id==sl.Id);
			} else	return base.Equals (obj);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}

		#region IComparer Member

		public int Compare(object x, object y)
		{
			if ((x.GetType()==typeof(StrLanguage)) && (y.GetType()==typeof(StrLanguage)))
			{
				StrLanguage sl1 = (StrLanguage)x;
				StrLanguage sl2 = (StrLanguage)y;
				return sl2.Id-sl1.Id;
			}
			if ((x.GetType()==typeof(byte)) && (y.GetType()==typeof(byte)))
			{
				return (int)y-(int)x;
			}
			return 0;
		}

		#endregion
	}

	/// <summary>
	/// An Item stored in a STR# File
	/// </summary>
	public class StrItem 
	{
		public StrItem() 
		{
			this.title = "";
			this.desc = "";
			this.lid = new StrLanguage(1);
			index = 0;
		}

		StrLanguage lid;
		/// <summary>
		/// Retusn the Language Id
		/// </summary>
		public StrLanguage Language
		{
			get { return lid;}
			set { lid = value; }
		}

		string title;
		/// <summary>
		/// Returns the Title String
		/// </summary>
		public string Title 
		{
			get { return title;}
			set { title = value; }
		}

		string desc;
		/// <summary>
		/// Returns the Description String
		/// </summary>
		public string Description 
		{
			get { return desc;}
			set { desc = value; }
		}		
		

		int index;
		/// <summary>
		/// Returns or sets the Index of this Item in the current language
		/// </summary>
		public int Index
		{
			get { return index;}
			set { index = value; }
		}

		public override string ToString()
		{
			return "0x"+index.ToString("X")+": "+Title;
		}

		internal void MakeValid()		
		{
			if (Title==null) Title = "";
			if (Description==null) Description = "";		
		}

		internal void Unserialize(BinaryReader reader, Hashtable lines)
		{
			this.Language = reader.ReadByte();
				
			StrItemList lng = (StrItemList)lines[this.Language.Id];
			if (lng==null) 
			{
				lng = new StrItemList();
				lines[this.Language.Id] = lng;
			}

			this.Index = lng.Count;			

			this.Title = "";
			char b = (char)0;
			if (reader.BaseStream.Position<reader.BaseStream.Length) b = reader.ReadChar();
			else b = (char)0;
			while (b!=0) 
			{				
				this.Title += b.ToString();	
				if (reader.BaseStream.Position<reader.BaseStream.Length) b = reader.ReadChar();
				else b = (char)0;
			}

			this.Description = "";
			if (reader.BaseStream.Position<reader.BaseStream.Length) b = reader.ReadChar();
			else b = (char)0;

			while (b!=0)
			{		
				this.Description += b.ToString();
				if (reader.BaseStream.Position<reader.BaseStream.Length) b = reader.ReadChar();
				else b = (char)0;
			}

			lng.Add(this);
		}

		internal void Serialize(BinaryWriter writer)
		{
			MakeValid();
			writer.Write(this.Language.Id);
				
			foreach (char c in this.Title) writer.Write(c);
			writer.Write((char)0);
			foreach (char c in this.Description) writer.Write(c);
			writer.Write((char)0);
		}
	}

	/// <summary>
	/// Typesave ArrayList for StrIte Objects
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

	/// <summary>
	/// Typesave ArrayList for StrIte Objects
	/// </summary>
	public class StrItemList : ArrayList 
	{
		public new StrItem this[int index]
		{
			get { return ((StrItem)base[index]); }
			set { base[index] = value; }
		}

		public StrItem this[uint index]
		{
			get { return ((StrItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(StrItem stritem)
		{
			return base.Add(stritem);
		}

		public void Insert(int index, StrItem stritem)
		{
			base.Insert(index, stritem);
		}

		public void Remove(StrItem stritem)
		{
			base.Remove(stritem);
		}

		public bool Contains(StrItem stritem)
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
			foreach (StrItem si in this) sil.Add(si);

			return sil;
		}

	}
}
