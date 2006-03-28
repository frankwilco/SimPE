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
using System.ComponentModel;
using SimPe.Geometry;
using System.Collections;

namespace SimPe.Plugin
{	

	/// <summary>
	/// Items for the TSFaceGeometryBuilder class
	/// </summary>
	public class TSFaceGeometryBuilderItem
	{
		#region Attributes
		Vectors3f v1;							
		public Vectors3f Vectors1 
		{
			get { return v1; }
			set { v1 = value; }
		}
		Vectors3f v2;							
		public Vectors3f Vectors2
		{
			get { return v2; }
			set { v2 = value; }
		}
		short u1;								
		public short Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}

		int u2;								
		public int Unknown2 
		{
			get { return u2; }
			set { u2 = value; }
		}
		#endregion

		public TSFaceGeometryBuilderItem()
		{
			v1 = new Vectors3f();
			v2 = new Vectors3f();
		}
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal virtual void Unserialize(System.IO.BinaryReader reader)
		{
			u1 = reader.ReadInt16();
			u2 = reader.ReadInt32();
			int count = reader.ReadInt32();
			v1.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector3f o = new Vector3f();
				o.Unserialize(reader);
				v1.Add(o);
			}
			
			count = reader.ReadInt32();
			v2.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector3f o = new Vector3f();
				o.Unserialize(reader);
				v2.Add(o);
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
		internal virtual void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(u1);
			writer.Write(u2);

			writer.Write((int)v1.Count);
			for (int i=0; i<v1.Count; i++) v1[i].Serialize(writer);			
			
			writer.Write((int)v2.Count);
			for (int i=0; i<v2.Count; i++) v2[i].Serialize(writer);			
		}
	}

	/// <summary>
	/// Zusammenfassung für cTSFaceGeometryBuilder.
	/// </summary>
	public class TSFaceGeometryBuilder
		: AbstractRcolBlock
	{
		#region Attributes
		GeometryBuilder gb;
		
		
		int u1;						
		public int Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}
		byte u2;						
		public byte Unknown2 
		{
			get { return u2; }
			set { u2 = value; }
		}
		int u3;						
		public int Unknown3 
		{
			get { return u3; }
			set { u3 = value; }
		}

		TSFaceGeometryBuilderItems items;							
		public TSFaceGeometryBuilderItems Items 
		{
			get { return items; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public TSFaceGeometryBuilder(Rcol parent) : base(parent)
		{
			gb = new GeometryBuilder(null);			
			BlockID = 0x2b70b86e;

			items = new TSFaceGeometryBuilderItems();
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();

			string name = reader.ReadString();
			uint myid = reader.ReadUInt32();		
			gb.Unserialize(reader);
			gb.BlockID = myid;

		
			u1 = reader.ReadInt32();
			u2 = reader.ReadByte();
			u3 = reader.ReadInt32();
	
			for (int i=0; i<10; i++) 
			{
				TSFaceGeometryBuilderItem o =  new TSFaceGeometryBuilderItem();
				o.Unserialize(reader);
				if (items.Count<=i) items.IntAdd(o);
				else items[i] = o;
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
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);

			writer.Write(gb.BlockName);
			writer.Write(gb.BlockID);
			gb.Serialize(writer);

			writer.Write(u1);
			writer.Write(u2);
			writer.Write(u3);
				
			for (int i=0; i<10; i++) 
			{
				if (i<items.Count) items[i].Serialize(writer);	
				else 
				{
					TSFaceGeometryBuilderItem o =  new TSFaceGeometryBuilderItem();
					o.Serialize(writer);
				}
			}
		}

		//fShapeRefNode form = null;
		TabPage.GenericRcol tGenericRcol;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (tGenericRcol==null) tGenericRcol = new SimPe.Plugin.TabPage.GenericRcol();
				return tGenericRcol;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (tGenericRcol==null) tGenericRcol = new SimPe.Plugin.TabPage.GenericRcol();
			tGenericRcol.tb_ver.Text = "0x"+Helper.HexString(this.version);
			tGenericRcol.gen_pg.SelectedObject = this;
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.gb.AddToTabControl(tc);
		}


		#region IDisposable Member

		public override void Dispose()
		{
			if (this.tGenericRcol!=null) this.tGenericRcol.Dispose();
			tGenericRcol = null;
		}

		#endregion
	}


	#region Container	
	
	/// <summary>
	/// Typesave ArrayList for TSFaceGeometryBuilderItem Objects
	/// </summary>
	public class TSFaceGeometryBuilderItems : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new TSFaceGeometryBuilderItem this[int index]
		{
			get { return ((TSFaceGeometryBuilderItem)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public TSFaceGeometryBuilderItem this[uint index]
		{
			get { return ((TSFaceGeometryBuilderItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(TSFaceGeometryBuilderItem item)
		{
			return -1;
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		internal int IntAdd(TSFaceGeometryBuilderItem item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, TSFaceGeometryBuilderItem item)
		{
			//base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(TSFaceGeometryBuilderItem item)
		{
			//base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(TSFaceGeometryBuilderItem item)
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
			TSFaceGeometryBuilderItems list = new TSFaceGeometryBuilderItems();
			foreach (TSFaceGeometryBuilderItem item in this) list.Add(item);

			return list;
		}
	}
	#endregion
	
}
