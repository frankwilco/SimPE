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
	#region GMDCElementValue
	/// <summary>
	/// Contains a SingleFloat Value
	/// </summary>
	public class GmdcElementValueBase
	{

		/// <summary>
		/// Scalar Multiplication
		/// </summary>
		/// <param name="evb">First Value</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Value</returns>
		public static GmdcElementValueBase operator *(GmdcElementValueBase evb, double d) 
		{
			GmdcElementValueBase n = evb.Clone();
			for (int i=0; i<n.data.Length; i++) n.data[i] = (float)(n.data[i] * d);
			return n;
		}

		/// <summary>
		/// Scalar Multiplication
		/// </summary>
		/// <param name="evb">First Value</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Value</returns>
		public static GmdcElementValueBase operator *(double d, GmdcElementValueBase evb) 
		{
			return evb*d;
		}

		float[] data;		

		/// <summary>
		/// The plain stored Data
		/// </summary>
		public float[] Data
		{
			get { return data; }
			set { data = value; }
		}	
	
		/// <summary>
		/// Returns the number of Float Elements stored here
		/// </summary>
		internal virtual byte Size 
		{
			get {return 0;}
		}

		public GmdcElementValueBase()
		{
			data = new float[Size];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal virtual void Unserialize(System.IO.BinaryReader reader)
		{
			for (int i=0; i<data.Length; i++) data[i] = reader.ReadSingle();			
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
			for (int i=0; i<data.Length; i++) writer.Write(data[i]);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			string s = "";
			for (int i=0; i<data.Length; i++) 
			{
				if (i!=0) s+=", ";
				s += data[i].ToString("N6");
			}
			return s;
		}

		/// <summary>
		/// Create a Clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public virtual GmdcElementValueBase Clone()
		{
			return this;
		}

		/// <summary>
		/// This Method supports the Internal process of creating a Clone
		/// </summary>
		/// <param name="dest">The object that should receive the copied Data</param>
		protected void Clone(GmdcElementValueBase dest) 
		{
			for (int i=0; i<data.Length; i++) dest.Data[i] = data[i];
		}

		public override int GetHashCode()
		{
			int f = 0;
			for (int i=0; i<data.Length; i++) f += data[i].GetHashCode();
			return f;
		}


		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (obj is GmdcElementValueBase) 
			{
				float epsilon = float.Epsilon*10;
				GmdcElementValueBase g = (GmdcElementValueBase)obj;
				if (g.data.Length!=data.Length) return false;

				for (int i=0; i<data.Length; i++)				
					if (Math.Abs(g.data[i]-data[i])>epsilon) return false;				

				return true;
			}
			return base.Equals (obj);
		}

	}

	/// <summary>
	/// Contains a single Float Value
	/// </summary>
	public class GmdcElementValueOneFloat : GmdcElementValueBase
	{
		internal override byte Size
		{
			get {return 1;}
		}

		internal GmdcElementValueOneFloat() : base() {}
		/// <summary>
		/// Create an Instance of this class
		/// </summary>
		/// <param name="f1">The Float Value</param>
		public GmdcElementValueOneFloat(float f1)
		{
			Data = new float[Size];
			Data[0] = f1;
		}

		/// <summary>
		/// Create a Clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public override GmdcElementValueBase Clone()
		{
			GmdcElementValueBase dest = new GmdcElementValueOneFloat();
			Clone(dest);
			return dest;
		}

	}	

	/// <summary>
	/// Contains a two gloat Value
	/// </summary>
	public class GmdcElementValueTwoFloat : GmdcElementValueBase
	{
		internal override byte Size
		{
			get {return 2;}
		}

		internal GmdcElementValueTwoFloat() : base() {}
		/// <summary>
		/// Create an Instance of this class
		/// </summary>
		/// <param name="f1">The first Value</param>
		/// <param name="f2">The second Value</param>
		public GmdcElementValueTwoFloat(float f1, float f2)
		{
			Data = new float[Size];
			Data[0] = f1;
			Data[1] = f2;
		}

		/// <summary>
		/// Create a Clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public override GmdcElementValueBase Clone()
		{
			GmdcElementValueBase dest = new GmdcElementValueTwoFloat();
			Clone(dest);
			return dest;
		}
	}

	/// <summary>
	/// Contains a three gloat Value
	/// </summary>
	public class GmdcElementValueThreeFloat : GmdcElementValueBase
	{
		internal  override byte Size
		{
			get {return 3;}
		}

		internal GmdcElementValueThreeFloat() : base() {}
		/// <summary>
		/// Create an Instance of this class
		/// </summary>
		/// <param name="f1">The first Value</param>
		/// <param name="f2">The second Value</param>
		/// <param name="f3">The third Value</param>
		public GmdcElementValueThreeFloat(float f1, float f2, float f3)
		{
			Data = new float[Size];
			Data[0] = f1;
			Data[1] = f2;
			Data[2] = f3;
		}

		/// <summary>
		/// Create a Clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public override GmdcElementValueBase Clone()
		{
			GmdcElementValueBase dest = new GmdcElementValueThreeFloat();
			Clone(dest);
			return dest;
		}
	}	

	/// <summary>
	/// Contains a two gloat Value
	/// </summary>
	public class GmdcElementValueOneInt : GmdcElementValueBase
	{
		internal  override byte Size
		{
			get {return 1;}
		}

		internal GmdcElementValueOneInt() : base() {}
		/// <summary>
		/// Create an Instance of this class
		/// </summary>
		/// <param name="i1">The integer Value</param>
		public GmdcElementValueOneInt(int i1)
		{
			Data = new float[Size];
			Value = i1;
		}

		/// <summary>
		/// Returns /Sets the stored Value
		/// </summary>
		public int Value 
		{
			get {
				return val;//(int)Data[0];
			}
			set {
				Data[0] = (float)value;
				val = value;
			}
		}

		/// <summary>
		/// Returns / Sets the Bytes that are stored as one Dword Value
		/// </summary>
		/// <remarks>
		/// Changein one of the passed Bytes will NOT effect the stored Value, you have to 
		/// write a complete Array back into this Property to change the stored Value!
		/// </remarks>
		public byte[] Bytes 
		{
			get 
			{				
				return BitConverter.GetBytes(Value);
			}
			set 
			{
				Value = BitConverter.ToInt32(value, 0);
			}
		}

		public void SetByte(int index, byte val)
		{
			byte[] r = Bytes;
			r[index] = val;
			Bytes = r;
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			string s = Value.ToString() + " (";
			byte[] b = Bytes;
			for (int i=0; i<b.Length; i++) s += b[i].ToString()+ " ";
			s = s.Trim() + ")";
			return s;
		}

		internal override void Serialize(BinaryWriter writer)
		{
			//writer.Write((int)Data[0]);
			writer.Write(val);
		}

		int val;
		internal override void Unserialize(BinaryReader reader)
		{
			val = reader.ReadInt32();
			Data[0] = (float)val;
		}

		/// <summary>
		/// Create a Clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		public override GmdcElementValueBase Clone()
		{
			GmdcElementValueBase dest = new GmdcElementValueOneInt();
			Clone(dest);
			return dest;
		}


	}
	#endregion

	/// <summary>
	/// This class contains the Elements Section of a Geometric Data Container
	/// </summary>
	public class GmdcElement : GmdcLinkBlock
	{
		#region Attributes

		int number;
		/// <summary>
		/// Number of stored <see cref="Values"/> that can be used
		/// </summary>
		public int Number 
		{
			get { return number; }
			set { number = value; }
		}

		ElementIdentity identity;
		/// <summary>
		/// The Type of Data that is stored in <see cref="Values"/>.
		/// </summary>
		public ElementIdentity Identity 
		{
			get { return identity; }
			set { identity = value; }
		}

		int repeat;
		/// <summary>
		/// If one <see cref="GmdcLink"/> is referenceing more than one <see cref="GmdcElement"/> 
		/// of the same <see cref="Identity"/>, this value is used to differ them. (Zero based)
		/// </summary>
		public int GroupId 
		{
			get { return repeat; }
			set { repeat = value; }
		}

		BlockFormat blockformat;
		/// <summary>
		/// What Type are the <see cref="Values"/> stored in.
		/// </summary>
		/// <remarks>This Filed Determins which SubClass of <see cref="GmdcElementValueBase"/> is used for 
		/// the <see cref="Values"/> Members</remarks>
		public BlockFormat BlockFormat 
		{
			get { return blockformat; }
			set { blockformat = value; }
		}

		SetFormat setformat;
		/// <summary>
		/// Describes the Elemnet
		/// </summary>
		public SetFormat SetFormat 
		{
			get { return setformat; }
			set { setformat = value; }
		}

		GmdcElementValues data;	
		/// <summary>
		/// Contains a List of <see cref="GmdcElementValueBase"/> Values. The Type of the Elements 
		/// is determined by the <see cref="BlockFormat"/> Property.
		/// </summary>
		public GmdcElementValues Values
		{
			get { return data; }
			set { data = value; }
		}

		IntArrayList items;	
		/// <summary>
		/// Yet unknown what this is doing
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
		public GmdcElement(GeometryDataContainer parent) : base (parent)
		{
			data = new GmdcElementValues();
			items = new IntArrayList();			
		}

		/// <summary>
		/// Returns an instance of GmdcElementValueBase class in the apropriate Format
		/// </summary>
		/// <returns>A class Instance</returns>
		/// <remarks>The Type of the instance is determined using the SubType</remarks>
		public GmdcElementValueBase GetValueInstance()
		{			
			switch (blockformat) 
			{
					
				case BlockFormat.OneDword :
					return new Gmdc.GmdcElementValueOneInt();
				case BlockFormat.OneFloat:
					return new Gmdc.GmdcElementValueOneFloat();
				case BlockFormat.TwoFloat:
					return new Gmdc.GmdcElementValueTwoFloat();
				case BlockFormat.ThreeFloat:
					return new Gmdc.GmdcElementValueThreeFloat();
			}

			return new Gmdc.GmdcElementValueOneFloat();
		}
			
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			number = reader.ReadInt32();
			uint id = reader.ReadUInt32();
			identity = (ElementIdentity)id;
			repeat = reader.ReadInt32();
			blockformat = (SimPe.Plugin.Gmdc.BlockFormat)reader.ReadInt32();
			setformat = (SimPe.Plugin.Gmdc.SetFormat)reader.ReadInt32();
			
			GmdcElementValueBase dummy = GetValueInstance();
			int len = reader.ReadInt32() / (4 * dummy.Size);
			data.Clear();
			for (int i=0; i<len; i++) 
			{				
				dummy = GetValueInstance();
				dummy.Unserialize(reader);
				data.Add(dummy);
			}

			this.ReadBlock(reader, items);
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
            //automatically keep the Number Field correct
            if (items.Length == 0)
            {
                number = data.Length;
                foreach (int i in this.items)
                    if (i > number) number = i - 1;
            }

            writer.Write(number); 

			writer.Write((int)identity);
			writer.Write(repeat);
			writer.Write((uint)blockformat);
			writer.Write((uint)setformat);

			int size = 1;
			if (data.Length>0) size = data[0].Size;

			writer.Write((int)(data.Length * 4 * size));
			for (int i=0; i<data.Length; i++) 
			{
				data[i].Serialize(writer);
			}
			
			this.WriteBlock(writer, items);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return this.Identity.ToString()+", "+this.SetFormat.ToString()+", "+this.BlockFormat.ToString()+" ("+this.Values.Count.ToString()+")";
		}

	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for GmdcElementValueBase Objects
	/// </summary>
	public class GmdcElementValues : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcElementValueBase this[int index]
		{
			get { return ((GmdcElementValueBase)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcElementValueBase this[uint index]
		{
			get { return ((GmdcElementValueBase)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcElementValueBase item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcElementValueBase item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcElementValueBase item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcElementValueBase item)
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
			GmdcElementValues list = new GmdcElementValues();
			foreach (GmdcElementValueBase item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for GmdcElement Objects
	/// </summary>
	public class GmdcElements : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new GmdcElement this[int index]
		{
			get { return ((GmdcElement)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public GmdcElement this[uint index]
		{
			get { return ((GmdcElement)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(GmdcElement item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, GmdcElement item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(GmdcElement item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(GmdcElement item)
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
			GmdcElements list = new GmdcElements();
			foreach (GmdcElement item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
