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


namespace SimPe.Geometry
{
	/// <summary>
	/// Zusammenfassung für Quaternion.
	/// </summary>
	public class Quaternion : Vector4f
	{
		/// <summary>
		/// Creates new Quaternion i*x + j*y + k*z + w
		/// </summary>
		/// <param name="x">X-Imaginary Part</param>
		/// <param name="y">Y-Imaginary Part</param>
		/// <param name="z">Z-Imaginary Part</param>
		/// <param name="w">RealPart</param>
		public Quaternion (float x, float y, float z, float w) : base(x, y, z, w) 
		{
			
		}

		/// <summary>
		/// Creates new Quaternion i*x + j*y + k*z + w
		/// </summary>
		/// <param name="v">The (unit) Axis for the Rotation</param>
		/// <param name="a">The angle (in Radiants)</param>
		public Quaternion (Vector3f v, float a)  : base()
		{
			float sina = (float)Math.Sin(a/2.0);
			X = v.X * sina;
			Y = v.Y * sina;
			Z = v.Z * sina;

			W = (float)Math.Cos(a/2.0);
		}	
	
		/// <summary>
		/// Creates a new Identity Quaternion
		/// </summary>
		public Quaternion () : base () {}

		/// <summary>
		/// Returns the Norm of the Quaternion
		/// </summary>
		public new float Norm 
		{
			get 
			{
				double n = Imaginary.Norm + Math.Pow(W, 2);
				return (float)n;
			}
		}

		/// <summary>
		/// Returns the Length of the Quaternion
		/// </summary>
		public new float Length 
		{
			get 
			{
				return (float)Math.Sqrt(Norm);
			}
		}

		/// <summary>
		/// Returns the Conjugate for this Quaternion
		/// </summary>
		public Quaternion Conjugate 
		{
			get 
			{
				return new Quaternion(this.Imaginary.Inverse, this.W);
			}
		}

		/// <summary>
		/// Returns the Inverse of this Quaternion
		/// </summary>
		public new Quaternion Inverse 
		{
			get 
			{
				return Conjugate * (float)(1.0 / (this & this));
			}
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(Quaternion q1, Quaternion q2) 
		{
			return new Quaternion(q1.Imaginary | q2.Imaginary + q1.Imaginary*q2.W + q2.Imaginary*q1.W, q1.W*q2.W - (q1.Imaginary*q2.Imaginary));
		}

		/// <summary>
		/// Scalar, dot or inner Product
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static float operator &(Quaternion q1, Quaternion q2) 
		{
			return q1.W*q2.W + (q1.Imaginary&q2.Imaginary);
		}

		/// <summary>
		/// Cross Product
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator |(Quaternion q1, Quaternion q2) 
		{
			return new Quaternion(q1.Imaginary|q2.Imaginary, 0);
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="d">a Scalar Value</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(Quaternion q1, float d) 
		{
			return q1 * (new Quaternion(new Vector3f(), d));
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="d">a Scalar Value</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(float d, Quaternion q1) 
		{
			return (new Quaternion(new Vector3f(), d)) * q1;
		}

		/// <summary>
		/// Addition
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator +(Quaternion q1, Quaternion q2) 
		{
			return new Quaternion(q1.Imaginary + q2.Imaginary, q1.W + q2.W);
		}

		/// <summary>
		/// Returns the Imaginary Part of the Quaternion
		/// </summary>
		public Vector3f Imaginary 
		{
			get { return (Vector3f)this;}
		}

		/// <summary>
		/// Returns an Identity Quaternion
		/// </summary>
		public static Quaternion Identity 
		{
			get { return new Quaternion(0, 0, 0, 1); }
		}	

		/// <summary>
		/// Returns an Angle in Degree
		/// </summary>
		/// <param name="rad">Angle in Radiants</param>
		/// <returns>Angle in Degree</returns>
		public static float RadToDeg(float rad) 
		{
			return (float)((rad * 180.0) / Math.PI);
		}

		/// <summary>
		/// Returns an Angle in Radiants
		/// </summary>
		/// <param name="deg">Angle in Degree</param>
		/// <returns>Angle in Radiants</returns>
		public static float DegToRad(float deg) 
		{
			return (float)((deg * Math.PI) / 180.0);
		}
	
		/// <summary>
		/// Makes sure this Quaternion is a Unit Quaternion
		/// </summary>
		public void MakeUnitQuaternion()
		{
			float l = Length;
			X = X/l;
			Y = Y/l;
			Z = Z/l;
			W = W/l;
		}

		/// <summary>
		/// Returns the Rotation Angle (in Radiants)
		/// </summary>
		public float Angle 
		{
			get {
				return (float)(Math.Acos(W) * 2.0);
			}
		}

		/// <summary>
		/// Returns the rotation (unit-)Axis
		/// </summary>
		public Vector3f Axis 
		{
			get {
				float sina = (float)Math.Sin(Angle/2.0);

				if (sina==0) return new Vector3f(0, 0, 0);
				return new Vector3f(X / sina, Y /sina, Z / sina);
			}
		}

		public override string ToString()
		{
			return base.ToString() + " (X=" +Axis.X.ToString("N3") + ", Y=" + Axis.Y.ToString("N3") + ", Z=" + Axis.Z.ToString("N3") + ", a=" + RadToDeg(Angle).ToString("N3") + ")";
		}
	}

	#region Container
	/// <summary>
	/// Typesave ArrayList for Quaternion Objects
	/// </summary>
	public class Quaternions : ArrayList 
	{
		/// <summary>
		/// Integer Indexer
		/// </summary>
		public new Quaternion this[int index]
		{
			get { return ((Quaternion)base[index]); }
			set { base[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public Quaternion this[uint index]
		{
			get { return ((Quaternion)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		/// <summary>
		/// add a new Element
		/// </summary>
		/// <param name="item">The object you want to add</param>
		/// <returns>The index it was added on</returns>
		public int Add(Quaternion item)
		{
			return base.Add(item);
		}

		/// <summary>
		/// insert a new Element
		/// </summary>
		/// <param name="index">The Index where the Element should be stored</param>
		/// <param name="item">The object that should be inserted</param>
		public void Insert(int index, Quaternion item)
		{
			base.Insert(index, item);
		}

		/// <summary>
		/// remove an Element
		/// </summary>
		/// <param name="item">The object that should be removed</param>
		public void Remove(Quaternion item)
		{
			base.Remove(item);
		}

		/// <summary>
		/// Checks wether or not the object is already stored in the List
		/// </summary>
		/// <param name="item">The Object you are looking for</param>
		/// <returns>true, if it was found</returns>
		public bool Contains(Quaternion item)
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
			Quaternions list = new Quaternions();
			foreach (Quaternion item in this) list.Add(item);

			return list;
		}		

	}
	#endregion
}
