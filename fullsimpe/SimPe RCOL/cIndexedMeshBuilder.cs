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
	/// Items for the IndexedMeshBuilder class
	/// </summary>
	public class IndexedMeshBuilderItem
	{
		#region Attributes
		string s1;							
		public string String1 
		{
			get { return s1; }
			set { s1 = value; }
		}

		string s2;							
		public string String2 
		{
			get { return s2; }
			set { s2 = value; }
		}

		Vectors4f v1;							
		public Vectors4f Vectors 
		{
			get { return v1; }
			set { v1 = value; }
		}

		int u1;							
		public int Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}
		#endregion

		public IndexedMeshBuilderItem()
		{
			s1 = "";
			s2 = "";
					 
			v1 = new Vectors4f();
		}
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal virtual void Unserialize(System.IO.BinaryReader reader)
		{
			s1 = reader.ReadString();
			s2 = reader.ReadString();
			int count = reader.ReadInt32();
			v1.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector4f o = new Vector4f();
				o.Unserialize(reader);
				v1.Add(o);
			}
			u1 = reader.ReadInt32();
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
			writer.Write(s1);
			writer.Write(s2);
			writer.Write((int)v1.Count);
			for (int i=0; i<v1.Count; i++) v1[i].Serialize(writer);			
			writer.Write(u1);
		}
	}

	/// <summary>
	/// Zusammenfassung für cIndexedMeshBuilder.
	/// </summary>
	public class IndexedMeshBuilder
		: AbstractRcolBlock
	{
		#region Attributes
		GeometryBuilder gb;
		
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

		Vectors2f v3;				
		public Vectors2f Vectors3 
		{
			get { return v3; }
			set { v3 = value; }
		}

		Vectors2f v4;				
		public Vectors2f Vectors4 
		{
			get { return v4; }
			set { v4 = value; }
		}

		Vectors2f v5;						
		public Vectors2f Vectors5 
		{
			get { return v5; }
			set { v5 = value; }
		}

		Vectors2f v6;						
		public Vectors2f Vectors6 
		{
			get { return v6; }
			set { v6 = value; }
		}

		IntArrayList ia1;						
		public IntArrayList Numbers1 
		{
			get { return ia1; }
			set { ia1 = value; }
		}

		IntArrayList ia2;						
		public IntArrayList Numbers2 
		{
			get { return ia2; }
			set { ia2 = value; }
		}

		IntArrayList ia3;								
		public IntArrayList Numbers3 
		{
			get { return ia3; }
			set { ia3 = value; }
		}

		IntArrayList ia4;						
		public IntArrayList Numbers4 
		{
			get { return ia4; }
			set { ia4 = value; }
		}

		byte[] zero1;
		public byte[] Zero1 
		{
			get { return zero1;}
		}

		byte[] zero2;
		public byte[] Zero2 
		{
			get { return zero2; }
		}

		int refcount;								
		public int ReferencedCount 
		{
			get { return refcount; }
			set { refcount = value; }
		}
		int u1;								
		public int Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}

		float[] u2;
		public float[] Unknown2 
		{
			get { return u2; }
		}

		IndexedMeshBuilderItems mbi;							
		public IndexedMeshBuilderItems Items 
		{
			get { return mbi; }
			set { mbi = value; }
		}


		int u3;							
		public int Unknown3 
		{
			get { return u3; }
			set { u3 = value; }
		}

		int u4;							
		public int Unknown4 
		{
			get { return u4; }
			set { u4 = value; }
		}

		int u5;							
		public int Unknown5 
		{
			get { return u5; }
			set { u5 = value; }
		}

		int u6;							
		public int Unknown6 
		{
			get { return u6; }
			set { u6 = value; }
		}

		int u7;							
		public int Unknown7 
		{
			get { return u7; }
			set { u7 = value; }
		}

		int u8;							
		public int Unknown8 
		{
			get { return u8; }
			set { u8 = value; }
		}

		int u9;							
		public int Unknown9 
		{
			get { return u9; }
			set { u9 = value; }
		}

		int u10;							
		public int Unknown10 
		{
			get { return u10; }
			set { u10 = value; }
		}

		string s1;							
		public string Name 
		{
			get { return s1; }
			set { s1 = value; }
		}

		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public IndexedMeshBuilder(Rcol parent) : base(parent)
		{
			gb = new GeometryBuilder(null);			
			BlockID = 0x9bffc10d;

			v1 = new Vectors3f();
			v2 = new Vectors3f();
			v3 = new Vectors2f();
			v4 = new Vectors2f();
			v5 = new Vectors2f();
			v6 = new Vectors2f();

			ia1 = new IntArrayList();
			ia2 = new IntArrayList();
			ia3 = new IntArrayList();
			ia4 = new IntArrayList();

			mbi = new IndexedMeshBuilderItems();

			zero1 = new byte[0x14];
			zero2 = new byte[0x14];

			u2 = new float[0x200];
			s1 = "face";
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

			count = reader.ReadInt32();
			v3.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector2f o = new Vector2f();				
				o.Unserialize(reader);
				v3.Add(o);
			}

			zero1 = reader.ReadBytes(zero1.Length);
			refcount = reader.ReadInt32();
			u1 = reader.ReadInt32();
			zero2 = reader.ReadBytes(zero2.Length);

			count = reader.ReadInt32();
			v4.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector2f o = new Vector2f();				
				o.Unserialize(reader);
				v4.Add(o);
			}

			count = reader.ReadInt32();
			v5.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector2f o = new Vector2f();				
				o.Unserialize(reader);
				v5.Add(o);
			}

			count = reader.ReadInt32();
			v6.Clear();
			for (int i=0; i<count; i++) 
			{
				Vector2f o = new Vector2f();				
				o.Unserialize(reader);
				v6.Add(o);
			}

			for (int i=0; i<u2.Length; i++) u2[i] = reader.ReadSingle();

			count = reader.ReadInt32();
			mbi.Clear();
			for (int i=0; i<count; i++) 
			{
				IndexedMeshBuilderItem o =  new IndexedMeshBuilderItem();
				o.Unserialize(reader);
				mbi.Add(o);
			}

			u3 = reader.ReadInt32();
			u4 = reader.ReadInt32();

			count = reader.ReadInt32();
			ia1.Clear();
			for (int i=0; i<count; i++) ia1.Add(reader.ReadInt32());

			count = reader.ReadInt32();
			ia2.Clear();
			for (int i=0; i<count; i++) ia2.Add(reader.ReadInt32());

			count = reader.ReadInt32();
			ia3.Clear();
			for (int i=0; i<count; i++) ia3.Add(reader.ReadInt32());

			count = reader.ReadInt32();
			ia4.Clear();
			for (int i=0; i<count; i++) ia4.Add(reader.ReadInt32());

			u5 = reader.ReadInt32();
			u6 = reader.ReadInt32();
			u7 = reader.ReadInt32();
			u8 = reader.ReadInt32();
			u9 = reader.ReadInt32();
			u10 = reader.ReadInt32();

			s1 = reader.ReadString();
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

			writer.Write((int)v1.Count);			
			for (int i=0; i<v1.Count; i++) v1[i].Serialize(writer);

			writer.Write((int)v2.Count);			
			for (int i=0; i<v2.Count; i++) v2[i].Serialize(writer);

			writer.Write((int)v3.Count);			
			for (int i=0; i<v3.Count; i++) v3[i].Serialize(writer);			

			writer.Write(zero1);
			writer.Write(refcount);
			writer.Write(u1);
			writer.Write(zero2);

			writer.Write((int)v4.Count);			
			for (int i=0; i<v4.Count; i++) v4[i].Serialize(writer);

			writer.Write((int)v5.Count);			
			for (int i=0; i<v5.Count; i++) v5[i].Serialize(writer);

			writer.Write((int)v6.Count);			
			for (int i=0; i<v6.Count; i++) v6[i].Serialize(writer);

			for (int i=0; i<u2.Length; i++) writer.Write(u2[i]);


			writer.Write((int)mbi.Count);			
			for (int i=0; i<mbi.Count; i++) mbi[i].Serialize(writer);			

			writer.Write(u3);
			writer.Write(u4);

			writer.Write((int)ia1.Count);			
			for (int i=0; i<ia1.Count; i++) writer.Write(ia1[i]);

			writer.Write((int)ia2.Count);			
			for (int i=0; i<ia2.Count; i++) writer.Write(ia2[i]);

			writer.Write((int)ia3.Count);			
			for (int i=0; i<ia3.Count; i++) writer.Write(ia3[i]);

			writer.Write((int)ia4.Count);			
			for (int i=0; i<ia4.Count; i++) writer.Write(ia4[i]);
			

			writer.Write(u5);
			writer.Write(u6);
			writer.Write(u7);
			writer.Write(u8);
			writer.Write(u9);
			writer.Write(u10);

			writer.Write(s1);
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
	/// Typesave ArrayList for IndexedMeshBuilderItem Objects
	/// </summary>
	public class IndexedMeshBuilderItems : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new IndexedMeshBuilderItem this[int index]
		{
			get { return ((IndexedMeshBuilderItem)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public IndexedMeshBuilderItem this[uint index]
		{
			get { return ((IndexedMeshBuilderItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(IndexedMeshBuilderItem item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, IndexedMeshBuilderItem item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(IndexedMeshBuilderItem item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(IndexedMeshBuilderItem item)
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
			IndexedMeshBuilderItems list = new IndexedMeshBuilderItems();
			foreach (IndexedMeshBuilderItem item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
