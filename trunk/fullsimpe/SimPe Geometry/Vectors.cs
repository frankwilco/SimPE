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

namespace SimPe.Geometry
{
	#region Vectors
	/// <summary>
	/// Contains the a 3D Vector
	/// </summary>
	public class Vector3f 
	{
		float x, y, z;
		
		/// <summary>
		/// The X Coordinate of teh Vector
		/// </summary>
		public float X 
		{
			get { return x; }
			set { x = value; }
		}
		/// <summary>
		/// The Y Coordinate of teh Vector
		/// </summary>
		public float Y 
		{
			get { return y; }
			set { y = value; }
		}
		/// <summary>
		/// The Z Coordinate of teh Vector
		/// </summary>
		public float Z 
		{
			get { return z; }
			set { z = value; }
		}

		/// <summary>
		/// Creates a new Vector Instance (0-Vector)
		/// </summary>
		public Vector3f ()
		{
			x = 0; y = 0; z = 0;
		}

		/// <summary>
		/// Creates new Vector Instance
		/// </summary>
		/// <param name="x">X-Coordinate</param>
		/// <param name="y">Y-Coordinate</param>
		/// <param name="z">Z-Coordinate</param>
		public Vector3f (float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public virtual void Unserialize(System.IO.BinaryReader reader)
		{
			x = reader.ReadSingle();			
			y = reader.ReadSingle();
			z = reader.ReadSingle();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public virtual void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(x);
			writer.Write(y);
			writer.Write(z);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return x.ToString("N6")+", "+y.ToString("N6")+", "+z.ToString("N6");
		}

		/// <summary>
		/// Returns the Norm of the Vector
		/// </summary>
		public float Norm 
		{
			get 
			{
				double n = Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2);
				return (float)n;
			}
		}

		/// <summary>
		/// Returns the Length of the Vector
		/// </summary>
		public float Length 
		{
			get 
			{
				return (float)Math.Sqrt(Norm);
			}
		}

		/// <summary>
		/// Returns the Inverse Vector
		/// </summary>
		public Vector3f Inverse 
		{
			get { return this * (float)(-1.0);}
		}

		/// <summary>
		/// Vector addition
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator +(Vector3f v1, Vector3f v2) 
		{
			return new Vector3f(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
		}

		/// <summary>
		/// Vector substraction
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator -(Vector3f v1, Vector3f v2) 
		{
			return new Vector3f(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
		}

		/// <summary>
		/// Scalar Product
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static float operator *(Vector3f v1, Vector3f v2) 
		{
			return v1.X * v2.X + v1.Y * v2.Y + v1.Z * v2.Z;
		}

		/// <summary>
		/// Scalar Product
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static float operator &(Vector3f v1, Vector3f v2) 
		{
			return v1 * v2;
		}

		/// <summary>
		/// Scalar Multiplication
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator *(Vector3f v1, float d) 
		{
			return new Vector3f(v1.X * d, v1.Y * d, v1.Z * d);
		}

		/// <summary>
		/// Scalar Multiplication
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator *(float d, Vector3f v1) 
		{
			return v1*d;
		}

		/// <summary>
		/// Scalar Division
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator /(Vector3f v1, float d) 
		{
			return new Vector3f(v1.X / d, v1.Y / d, v1.Z / d);
		}

		/// <summary>
		/// Scalar Division
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="d">Scalar Factor</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator /(float d, Vector3f v1) 
		{
			return v1 / d;
		}

		/// <summary>
		/// Cross Product
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static Vector3f operator |(Vector3f v1, Vector3f v2) 
		{
			return new Vector3f(v1.Y*v2.Z - v1.Z*v2.Y, v1.Z*v2.X - v1.X*v2.Z, v1.X*v2.Y - v1.Y*v2.X);
		}

		/// <summary>
		/// Compare
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static bool operator ==(Vector3f v1, Vector3f v2) 
		{
			return (v1.X==v2.X) && (v1.Y==v2.Y) && (v1.Z==v2.Z);
		}

		/// <summary>
		/// Returns a HashCode to identify this Instance
		/// </summary>
		/// <returns></returns>
		public override int GetHashCode()
		{
			return base.GetHashCode ();
		}

		/// <summary>
		/// Returns true if the passed Objects equals this one
		/// </summary>
		/// <param name="obj"></param>
		/// <returns></returns>
		public override bool Equals(object obj)
		{
			return base.Equals (obj);
		}



		/// <summary>
		/// Compare
		/// </summary>
		/// <param name="v1">First Vector</param>
		/// <param name="v2">Second Vector</param>
		/// <returns>The resulting Vector</returns>
		public static bool operator !=(Vector3f v1, Vector3f v2) 
		{
			return (v1.X!=v2.X) || (v1.Y!=v2.Y) || (v1.Z!=v2.Z);
		}
	}

	/// <summary>
	/// Contains the a 3D Vector
	/// </summary>
	public class Vector3i 
	{
		int x, y, z;
		
		/// <summary>
		/// The X Coordinate of the Vector
		/// </summary>
		public int X 
		{
			get { return x; }
			set { x = value; }
		}
		/// <summary>
		/// The Y Coordinate of the Vector
		/// </summary>
		public int Y 
		{
			get { return y; }
			set { y = value; }
		}
		/// <summary>
		/// The Z Coordinate of the Vector
		/// </summary>
		public int Z 
		{
			get { return z; }
			set { z = value; }
		}

		/// <summary>
		/// Creates a new Vector Instance (0-Vector)
		/// </summary>
		public Vector3i ()
		{
			x = 0; y = 0; z = 0;
		}

		/// <summary>
		/// Creates new Vector Instance
		/// </summary>
		/// <param name="x">X-Coordinate</param>
		/// <param name="y">Y-Coordinate</param>
		/// <param name="z">Z-Coordinate</param>
		public Vector3i (int x, int y, int z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public virtual void Unserialize(System.IO.BinaryReader reader)
		{
			x = reader.ReadInt32();
			y = reader.ReadInt32();
			z = reader.ReadInt32();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public virtual void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(x);
			writer.Write(y);
			writer.Write(z);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return Helper.HexString(x) + ", " + Helper.HexString(y) + ", " + Helper.HexString(z);
		}

	}

	/// <summary>
	/// Contains the a 4D Vector
	/// </summary>
	public class Vector4f : Vector3f
	{
		float w;
		/// <summary>
		/// The 4th Component of an Vector (often used as focal Point)
		/// </summary>
		public float W
		{
			get { return w; }
			set { w = value; }
		}

		/// <summary>
		/// Creates a new Vector Instance (0-Vector)
		/// </summary>
		public Vector4f () : base()
		{
			w = 0;
		}

		/// <summary>
		/// Creates new Vector Instance
		/// </summary>
		/// <param name="x">X-Coordinate</param>
		/// <param name="y">Y-Coordinate</param>
		/// <param name="z">Z-Coordinate</param>
		/// <param name="w">4th-Coordinate (often the focal Point)</param>
		public Vector4f (float x, float y, float z, float w) : base(x, y, z)
		{
			this.w = w;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			base.Unserialize(reader);
			w = reader.ReadSingle();				
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
			base.Serialize(writer);
			writer.Write(w);
		}

		/// <summary>
		/// This output is used in the ListBox View
		/// </summary>
		/// <returns>A String Describing the Data</returns>
		public override string ToString()
		{
			return base.ToString()+", "+w.ToString("N6");
		}
	}
	#endregion

	#region Container	
	/// <summary>
	/// Typesave ArrayList for Vector3i Objects
	/// </summary>
	public class Vectors3i : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Vector3i this[int index]
		{
			get { return ((Vector3i)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Vector3i this[uint index]
		{
			get { return ((Vector3i)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(Vector3i item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, Vector3i item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(Vector3i item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Vector3i item)
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
			Vectors3i list = new Vectors3i();
			foreach (Vector3i item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for Vector3f Objects
	/// </summary>
	public class Vectors3f : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Vector3f this[int index]
		{
			get { return ((Vector3f)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Vector3f this[uint index]
		{
			get { return ((Vector3f)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(Vector3f item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, Vector3f item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(Vector3f item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Vector3f item)
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
			Vectors3f list = new Vectors3f();
			foreach (Vector3f item in this) list.Add(item);

			return list;
		}
	}

	/// <summary>
	/// Typesave ArrayList for Vector4f Objects
	/// </summary>
	public class Vectors4f : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Vector4f this[int index]
		{
			get { return ((Vector4f)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Vector4f this[uint index]
		{
			get { return ((Vector4f)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(Vector4f item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, Vector4f item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(Vector4f item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Vector4f item)
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
			Vectors4f list = new Vectors4f();
			foreach (Vector4f item in this) list.Add(item);

			return list;
		}
	}
	#endregion
}
