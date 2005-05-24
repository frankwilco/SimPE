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
using System.IO;
using System.Globalization;
using System.Collections;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// This Section References the Element Data
	/// </summary>
	public class GmdcLink : GmdcLinkBlock
	{
		#region Attributes

		IntArrayList items1;	
		/// <summary>
		/// This returns the List of all used <see cref="GmdcElement"/> Items. The Values are Indices
		/// for the <see cref="GeometryDataContainer.Elements"/> Property.
		/// </summary>
		public IntArrayList ReferencedElement
		{
			get { return items1; }
			set { items1 = value; }
		}

		int unknown1;
		/// <summary>
		/// The Number of Elements that are Referenced by this Link
		/// </summary>
		public int ReferencedSize 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		/// <summary>
		/// How many <see cref="GmdcElement"/> Items are referenced by this Link
		/// </summary>
		public int ActiveElements 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		IntArrayList[] refs;
		/// <summary>
		/// This Array Contains three <see cref="IntArrayList"/> Items. Each Item has to be interporeted as 
		/// Element Index Alias.
		/// The <see cref="GmdcGroup"/> is referencing the Vertices that form a Face by an Index. If one of 
		/// this Lists is set, it means, that whenever you pares an Index, read the value stored at that Index 
		/// in one of this Lists. The Value read from there is then thge actual <see cref="GmdcElement"/> Index.
		/// 
		/// The first List store here is an Alias Map for the first referenced <see cref="GmdcElement"/> in the
		/// <see cref="ReferencedElement"/> Property.
		/// </summary>
		public IntArrayList[] AliasValues
		{
			get { return refs; }
		}		
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public GmdcLink(GeometryDataContainer parent) : base(parent)
		{
			items1 = new IntArrayList();
			refs = new IntArrayList[3];
			for (int i=0; i< refs.Length; i++) refs[i] = new IntArrayList();
		}

		
			
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			ReadBlock(reader, items1);

			unknown1 = reader.ReadInt32();
			unknown2 = reader.ReadInt32();
			
			for (int i=0; i< refs.Length; i++) ReadBlock(reader, refs[i]);
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public  void Serialize(System.IO.BinaryWriter writer)
		{
			WriteBlock(writer, items1);

			writer.Write(unknown1);
			writer.Write(unknown2);

			for (int i=0; i< refs.Length; i++) WriteBlock(writer, refs[i]);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			string s = items1.Length.ToString();
			for (int i=0; i< refs.Length; i++) s += ", "+refs[i].Length;
			return s;
		}

		/// <summary>
		/// Returns the first Element Referenced from this Link that implements 
		/// the passed <see cref="ElementIdentity"/>.
		/// </summary>
		/// <param name="id">Identity you are looking for</param>
		/// <returns>null or the First mathcing Element</returns>
		public GmdcElement FindElementType(ElementIdentity id)
		{
			foreach (int i in this.ReferencedElement)
			{
				if (parent.Elements[i].Identity==id) return parent.Elements[i];
			}

			return null;
		}

		/// <summary>
		/// Returns the nr (as it can be used in GetValue() Method) of the passed Element in this Link Section
		/// </summary>
		/// <param name="e">Element you are looking for</param>
		/// <returns>
		/// -1 if the Element is not referenced from this Link or the index of that Element in the 
		/// ReferenceElement Member
		/// </returns>
		public int GetElementNr(GmdcElement e)
		{
			for (int i=0; i<this.items1.Length; i++) 
				if (parent.Elements[items1[i]]==e) return i;
			
			return -1;
		}

		/// <summary>
		/// Returns a specific Value
		/// </summary>
		/// <param name="nr">The Number of the referenced Element (index to the ReferencedElement Member)</param>
		/// <param name="index">The index of the value you want to read from thet Element</param>
		/// <returns>The stored Value or null on error</returns>
		/// <remarks>To retrieve the correct number for an Element, see the GetElementNr() Method</remarks>
		public SimPe.Plugin.Gmdc.GmdcElementValueBase GetValue(int nr, int index)
		{
			try 
			{
				//if (nr>=this.items1.Length) return null;
				int enr = this.items1[nr];

				//if (enr>=this.parent.Elements.Length) return null;
				GmdcElement e = this.parent.Elements[enr];

				//Higher Number
				if (nr>=refs.Length) 
				{
					//if (index>=e.Values.Length) return null;
					return e.Values[index];
				}
			
				//Do we have aliases?
				if (refs[nr].Length==0) //no
				{
					//if (index>=e.Values.Length) return null;
					return e.Values[index];
				} 
				else //yes
				{
					//if (index>=this.refs.Length) return null;
					index = refs[nr][index];
					//if (index>=e.Values.Length) return null;
					return e.Values[index];
				}
			} 
			catch 
			{
				return null;
			}
		}

		/// <summary>
		/// Returns a specific Value
		/// </summary>
		/// <param name="nr">The Number of the referenced Element (index to the ReferencedElement Member)</param>
		/// <param name="index">The index of the value you want to read from thet Element</param>
		/// <returns>-1 or an Element Index</returns>
		/// <remarks>To retrieve the correct number for an Element, see the GetElementNr() Method</remarks>
		public int GetRealIndex(int nr, int index)
		{
			try 
			{
				int enr = this.items1[nr];

				GmdcElement e = this.parent.Elements[enr];

				//Higher Number
				if (nr>=refs.Length) return index;				
			
				//Do we have aliases?
				if (refs[nr].Length==0) return index; 
				else return refs[nr][index];				
			} 
			catch 
			{
				return -1;
			}
		}
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for GmdcLink Objects
	/// </summary>
	public class GmdcLinks : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcLink this[int index]
		{
			get { return ((GmdcLink)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcLink this[uint index]
		{
			get { return ((GmdcLink)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcLink item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcLink item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcLink item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcLink item)
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
		public override object Clone()
		{
			GmdcLinks list = new GmdcLinks();
			foreach (GmdcLink item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
