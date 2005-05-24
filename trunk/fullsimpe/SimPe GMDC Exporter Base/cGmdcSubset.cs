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
	/// Contains the Subset Section of a GMDC
	/// </summary>
	public class GmdcBone : GmdcLinkBlock
	{
		#region Attributes	
		/// <summary>
		/// Number of Vertices stored in this SubSet
		/// </summary>
		public int VertexCount
		{
			get { return verts.Length; }
		}

		Vectors3i verts;
		/// <summary>
		/// Vertex Definitions for this SubSet
		/// </summary>
		public Vectors3i Vertices 
		{
			get { return verts; }
			set { verts = value; }
		}

		IntArrayList items;
		/// <summary>
		/// Some additional Index Data (yet unknown)
		/// </summary>
		public IntArrayList Items 
		{
			get { return items; }
			set { items = value; }
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public GmdcBone(GeometryDataContainer parent) : base(parent)
		{
			verts = new Vectors3i();
			items = new IntArrayList();
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			int vcount = reader.ReadInt32();

			if (vcount>0) 
			{
				try 
				{
					int count = reader.ReadInt32();
					verts.Clear();
					for (int i=0; i<vcount; i++)
					{
						Vector3i f = new Vector3i();
						f.Unserialize(reader);
						verts.Add(f);
					}

					items.Clear();
					for (int i=0; i<count; i++) items.Add(this.ReadValue(reader));
				}
				catch (Exception ex)
				{
					Helper.ExceptionMessage("", ex);
				}
			}
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
			writer.Write((int)verts.Count);

			if (verts.Count>0) 
			{	
				writer.Write((int)items.Length);
				for (int i=0; i<verts.Count; i++) verts[i].Serialize(writer);
				for (int i=0; i<items.Length; i++) this.WriteValue(writer, items[i]);
			}	
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return this.Vertices.Count.ToString()+", "+this.Items.Count.ToString();
		}

	}
	
	#region Container
	/// <summary>
	/// Typesave ArrayList for GmdcBone Objects
	/// </summary>
	public class GmdcBones : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcBone this[int index]
		{
			get { return ((GmdcBone)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcBone this[uint index]
		{
			get { return ((GmdcBone)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcBone item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcBone item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcBone item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcBone item)
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
			GmdcBones list = new GmdcBones();
			foreach (GmdcBone item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
