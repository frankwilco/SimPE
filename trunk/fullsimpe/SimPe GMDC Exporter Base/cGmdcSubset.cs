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
using SimPe.Geometry;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Contains the Subset Section of a GMDC
	/// </summary>
	public class GmdcJoint : GmdcLinkBlock
	{
		#region Attributes	
		/// <summary>
		/// Number of Vertices stored in this SubSet
		/// </summary>
		public int VertexCount
		{
			get { return verts.Length; }
		}

		Vectors3f verts;
		/// <summary>
		/// Vertex Definitions for this SubSet
		/// </summary>
		public Vectors3f Vertices 
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
		public GmdcJoint(GeometryDataContainer parent) : base(parent)
		{
			verts = new Vectors3f();
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
						Vector3f f = new Vector3f();
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
		/// Adjusts the Vertex List, from all Elements Vertices that are assigned to this joint
		/// </summary>
		public void CollectVertices()
		{
			//first get my Number in the Parent
			int index = -1;
			for (int i=0; i<parent.Joints.Count; i++) 
			{
				if (parent.Joints[i]==this) 
				{
					index = i;
					break;
				}
			}

			this.Vertices.Clear();
			this.Items.Clear();

			if (index==-1) return; //not within Parent!

			//scan all Groups in the Parent for Joint Assignements
			foreach (GmdcGroup g in parent.Groups) 
			{
				GmdcLink l = parent.Links[g.LinkIndex];
				GmdcElement joints = l.FindElementType(ElementIdentity.BoneAssignment);
				
				GmdcElement vertices = l.FindElementType(ElementIdentity.Vertex);
				int vindex = l.GetElementNr(vertices);

				if (joints==null || vertices==null) continue;
				for (int i=0; i<g.UsedJoints.Count; i++) 
				{
					//this Bone is a Match, so add all assigned vertices
					if (g.UsedJoints[i]==index) 
					{
						Hashtable indices = new Hashtable();

						//load the vertices
						for (int k=0; k<joints.Values.Count; k++)						 
						{							
							GmdcElementValueOneInt voi = (GmdcElementValueOneInt)joints.Values[k];
							if (voi.Bytes[0]==(byte)i) 
							{
								indices.Add(k, this.Vertices.Count);
								this.Vertices.Add(new Vector3f(vertices.Values[k].Data[0], vertices.Values[k].Data[1], vertices.Values[k].Data[2]));
							}
						}

						//now all faces that are completley assigned to the Bone
						for (int f=0; f<g.Faces.Count-2; f+=3) 
						{
							if (indices.ContainsKey(l.GetRealIndex(vindex, g.Faces[f])) &&
								indices.ContainsKey(l.GetRealIndex(vindex, g.Faces[f+1])) &&
								indices.ContainsKey(l.GetRealIndex(vindex, g.Faces[f+2])) ) 
							{
								this.Items.Add((int)indices[l.GetRealIndex(vindex, g.Faces[f])]);
								this.Items.Add((int)indices[l.GetRealIndex(vindex, g.Faces[f+1])]);
								this.Items.Add((int)indices[l.GetRealIndex(vindex, g.Faces[f+2])]);
							}
						}
					}
				}
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
	/// Typesave ArrayList for GmdcJoint Objects
	/// </summary>
	public class GmdcJoints : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcJoint this[int index]
		{
			get { return ((GmdcJoint)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcJoint this[uint index]
		{
			get { return ((GmdcJoint)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcJoint item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcJoint item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcJoint item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcJoint item)
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
			GmdcJoints list = new GmdcJoints();
			foreach (GmdcJoint item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
