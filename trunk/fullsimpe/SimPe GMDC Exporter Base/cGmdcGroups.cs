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
	/// Contains the Group Section of a GMDC
	/// </summary>
	public class GmdcGroup  : GmdcLinkBlock
	{
		#region Attributes

		PrimitiveType unknown1;
		/// <summary>
		/// Determins the Primitive Type of the Faces
		/// </summary>
		public PrimitiveType PrimitiveType 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int alternate;
		/// <summary>
		/// The Index of the <see cref="GmdcLink"/> Object that is referenced by this Group. (Index into the <see cref="GeometryDataContainer.Links"/> Property.
		/// </summary>
		public int LinkIndex 
		{
			get { return alternate; }
			set { alternate = value; }
		}

		/// <summary>
		/// The Link Element
		/// </summary>
		public GmdcLink Link
		{
			get 
			{
				if (parent==null) return null;
				if (LinkIndex<0 || LinkIndex>=parent.Links.Count) return null;

				return parent.Links[LinkIndex];
			}
		}

		string name;
		/// <summary>
		/// The Name of this Group
		/// </summary>
		public String Name 
		{
			get { return name; }
			set { name = value; }
		}
		
		IntArrayList items1;
		/// <summary>
		/// The Index of the used Vertices
		/// </summary>
		public IntArrayList Faces 
		{
			get { return items1; }
			set { items1 = value; }
		}

		uint opacity;
		/// <summary>
		/// The opacity of this Group (0=transparent; 3=shadow; -1=opaque)
		/// </summary>
		public uint Opacity 
		{
			get { return opacity; }
			set { opacity = value; }
		}

		IntArrayList items2;
		/// <summary>
		/// List all Joints used by this Group
		/// </summary>
		public IntArrayList UsedJoints 
		{
			get { return items2; }
			set { items2 = value; }
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public GmdcGroup(GeometryDataContainer parent) : base(parent)
		{
			items1 = new IntArrayList();
			items2 = new IntArrayList();
			name = "";
		}

			
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			unknown1 = (PrimitiveType)reader.ReadUInt32();
			alternate = reader.ReadInt32();
			name = reader.ReadString();

			ReadBlock(reader, items1);

			if (parent.Version!=0x03) opacity = reader.ReadUInt32();
			else opacity = 0;

			if (parent.Version!=0x01) ReadBlock(reader, items2); 
			else items2.Clear();
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
			writer.Write((uint)unknown1);
			writer.Write(alternate);
			writer.Write(name);

			WriteBlock(writer, items1);

			if (parent.Version!=0x03) writer.Write((uint)opacity);

			if (parent.Version!=0x01) WriteBlock(writer, items2); 
		}

		/// <summary>
		/// The Face Count for this Group
		/// </summary>
		public int FaceCount 
		{
			get { return this.Faces.Count/3; }
		}

		/// <summary>
		/// The Number of diffrent Vertices used by this Group
		/// </summary>
		public int UsedVertexCount 
		{
			get 
			{				
				ArrayList refs = new ArrayList();			
				foreach (int i in Faces) if (!refs.Contains(i)) refs.Add(i);			
				return refs.Count;
			}
		}

		/// <summary>
		/// The Number of referenced Vertices
		/// </summary>
		public int ReferencedVertexCount 
		{
			get 
			{
				int vertcount = 0;
				if (this.LinkIndex<parent.Links.Count) 
				{
					if (LinkIndex>=0 && LinkIndex<parent.Links.Count) vertcount = parent.Links[LinkIndex].ReferencedSize;
				}
				return vertcount;
			}
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{			
			return name + " (FaceCount="+(FaceCount).ToString()+", VertexCount="+UsedVertexCount.ToString()+")";
		}
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for GmdcGroup Objects
	/// </summary>
	public class GmdcGroups : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcGroup this[int index]
		{
			get { return ((GmdcGroup)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcGroup this[uint index]
		{
			get { return ((GmdcGroup)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcGroup item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcGroup item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcGroup item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcGroup item)
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
			GmdcGroups list = new GmdcGroups();
			foreach (GmdcGroup item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
