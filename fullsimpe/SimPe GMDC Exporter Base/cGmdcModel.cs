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
	/// Stores two String Items
	/// </summary>
	public class GmdcNamePair 
	{
		string blendname;
		/// <summary>
		/// The Name of the Belnding Group
		/// </summary>
		public string BlendGroupName 
		{
			get { return blendname; }
			set { blendname = value; }
		}

		string elementname;
		/// <summary>
		/// The Name of the Element that should be assigned to that Group
		/// </summary>
		public string AssignedElementName
		{
			get { return elementname; }
			set { elementname = value; }
		}

		internal GmdcNamePair()
		{
			blendname = "";
			elementname = "";
		}

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		/// <param name="blend">Name of the Blendgroup</param>
		/// <param name="element">Name of the Element that should be assigned to that Blend Group</param>
		public GmdcNamePair(string blend, string element)
		{
			blendname = blend;
			elementname = element;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal virtual void Unserialize(System.IO.BinaryReader reader)
		{
			blendname = reader.ReadString();
			elementname = reader.ReadString();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		internal virtual void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(blendname);
			writer.Write(elementname);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return blendname+", "+elementname;
		}

	}

	/// <summary>
	/// Contains the Model Section of a GMDC
	/// </summary>
	public class GmdcModel : GmdcLinkBlock
	{
		#region Attributes
		VectorTransformations transforms;
		/// <summary>
		/// Set of Transformations
		/// </summary>
		public VectorTransformations Transformations 
		{
			get { return transforms; }
			set {transforms = value; }
		}		

		GmdcNamePairs names;
		/// <summary>
		/// Groups to BlendGroup assignements
		/// </summary>
		public GmdcNamePairs BlendGroupDefinition 
		{
			get { return names; }
			set {names = value; }
		}		

		GmdcJoint subset;
		/// <summary>
		/// Some SubSet Data (yet unknown)
		/// </summary>
		public GmdcJoint BoundingMesh
		{
			get { return subset; }
			set { subset = value; }
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public GmdcModel(GeometryDataContainer parent) : base(parent)
		{
			transforms = new VectorTransformations();
			names = new GmdcNamePairs();
			subset = new GmdcJoint(parent);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			int count = reader.ReadInt32();
			transforms.Clear();
			for (int i=0; i<count; i++)
			{
				VectorTransformation t = new VectorTransformation(VectorTransformation.TransformOrder.RotateTranslate);
				t.Unserialize(reader);
				transforms.Add(t);
			}

			count = reader.ReadInt32();
			names.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcNamePair p = new GmdcNamePair();
				p.Unserialize(reader);
				names.Add(p);
			}

			subset.Unserialize(reader);
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
			int count = transforms.Length;
			writer.Write((int)count);
			for (int i=0; i<count; i++) 
			{
				transforms[i].Order = VectorTransformation.TransformOrder.RotateTranslate;
				transforms[i].Serialize(writer);
			}
			writer.Write((int)names.Length);
			for (int i=0; i<names.Length; i++) names[i].Serialize(writer);

			subset.Serialize(writer);
		}

		/// <summary>
		/// Clear the BoundingMesh definition
		/// </summary>
		public void ClearBoundingMesh()
		{
			this.BoundingMesh.Items.Clear();
			this.BoundingMesh.Vertices.Clear();
		}

		/// <summary>
		/// Add the passed Group to the BoundingMesh Definition
		/// </summary>
		/// <param name="g"></param>
		public void AddGroupToBoundingMesh(GmdcGroup g)
		{
			if (g==null) return;
			if (g.Link==null) return;
			int nr = g.Link.GetElementNr(g.Link.FindElementType(ElementIdentity.Vertex));
			int offset = this.BoundingMesh.VertexCount;

			for (int i = 0; i < g.Link.ReferencedSize; i++) 
			{
				Vector3f v = new Vector3f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1], g.Link.GetValue(nr, i).Data[2]);
				this.BoundingMesh.Vertices.Add(v);
			}

			for (int i=0; i<g.Faces.Count; i++)			
				this.BoundingMesh.Items.Add(g.Faces[i]+offset);			
		}
	}
	
	#region Container	

	/// <summary>
	/// Typesave ArrayList for GmdcModel Objects
	/// </summary>
	public class GmdcModels : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcModel this[int index]
		{
			get { return ((GmdcModel)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcModel this[uint index]
		{
			get { return ((GmdcModel)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcModel item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcModel item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcModel item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcModel item)
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
			GmdcModels list = new GmdcModels();
			foreach (GmdcModel item in this) list.Add(item);

			return list;
		}
	}	

	/// <summary>
	/// Typesave ArrayList for GmdcNamePair Objects
	/// </summary>
	public class GmdcNamePairs : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcNamePair this[int index]
		{
			get { return ((GmdcNamePair)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcNamePair this[uint index]
		{
			get { return ((GmdcNamePair)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcNamePair item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcNamePair item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcNamePair item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcNamePair item)
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
			GmdcNamePairs list = new GmdcNamePairs();
			foreach (GmdcNamePair item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
