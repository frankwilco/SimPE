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
	/// Determins the type of the passed Arguments
	/// </summary>
	public enum QuaternionParameterType : byte
	{
		/*/// <summary>
		/// Arguments represent an Euler Angle
		/// </summary>
		EulerAngles = 0x00,*/
		/// <summary>
		/// Arguments represent a (unit-)Axis/Angle Pair
		/// </summary>
		UnitAxisAngle = 0x01,
		/// <summary>
		/// Arguments represent the Imaginary koeef. of a Quaternion and the Real Part
		/// </summary>
		ImaginaryReal = 0x02
	}
	/// <summary>
	/// Zusammenfassung für Quaternion.
	/// </summary>
	public class Quaternion : Vector4f
	{
		/// <summary>
		/// Creates new Quaternion i*x + j*y + k*z + w (Based an an coefficients/unit-Axis/Angle)
		/// </summary>
		/// <param name="p">How do you want to create the Quaternion</param>
		/// <param name="x">X-Imaginary Part/X-Axis</param>
		/// <param name="y">Y-Imaginary Part/Y-Axis</param>
		/// <param name="z">Z-Imaginary Part/Z-Axis</param>
		/// <param name="w">RealPart/Angle</param>
		public Quaternion (QuaternionParameterType p, double x, double y, double z, double w) : base ()
		{
			if (p==QuaternionParameterType.ImaginaryReal) 
			{
				X = x; Y = y; Z = z; W = w;
			} 
			else if (p==QuaternionParameterType.UnitAxisAngle) 
			{
				this.SetFromAxisAngle(new Vector3f(x, y, z), w);
			}
		}

		/// <summary>
		/// Creates new Quaternion i*x + j*y + k*z + w (Based an an coefficients/unit-Axis/Angle)
		/// </summary>
		/// <param name="p">How do you want to create the Quaternion</param>
		/// <param name="v">The (unit) Axis for the Rotation/Imaginary part</param>
		/// <param name="a">The angle (in Radiants)/Real Part</param>
		public Quaternion (QuaternionParameterType p, Vector3f v, double a)  : base()
		{
			if (p==QuaternionParameterType.ImaginaryReal) 
			{
				X = v.X; Y = v.Y; Z = v.Z; W = a;
			} 
			else if (p==QuaternionParameterType.UnitAxisAngle) 
			{
				this.SetFromAxisAngle(v, a);
			}
		}	

		/// <summary>
		/// Creates new Quaternion i*x + j*y + k*z + w (Based on Euler Angles)
		/// </summary>
		/// <param name="v">The Euler Angles</param>
		public Quaternion (Vector3f v)  : base()
		{
			SetFromEulerAngles(v);
		}	
	
		/// <summary>
		/// Creates a new Identity Quaternion
		/// </summary>
		public Quaternion () : base () {}

		/// <summary>
		/// Returns the Norm of the Quaternion
		/// </summary>
		public new double Norm 
		{
			get 
			{
				double n = Imaginary.Norm + Math.Pow(W, 2);
				return (double)n;
			}
		}

		/// <summary>
		/// Returns the Length of the Quaternion
		/// </summary>
		public new double Length 
		{
			get 
			{
				return (double)Math.Sqrt(Norm);
			}
		}

		/// <summary>
		/// Returns the Conjugate for this Quaternion
		/// </summary>
		public Quaternion Conjugate 
		{
			get 
			{
				return new Quaternion(QuaternionParameterType.ImaginaryReal, !this.Imaginary, this.W);				
			}
		}

#if DEBUG
		/// <summary>
		/// returns the Euler Angles
		/// </summary>
		public Vector3f Euler 
		{
			get 
			{
				return this.GetEulerAngles();
			}
		}

		public bool IsComplex(double z)
		{
			return ((Math.Pow(X+Y+Z+W, 2) - 4.0*(Norm-z)) <0.0);
		}

		public double GetMovePlus(double z)
		{
			double d1 = ((-2.0 * (X+Y+Z+W)) + (2*Math.Sqrt(Math.Pow(X+Y+Z+W, 2) - 4.0*(Norm-z)))) / 8.0;
			double d2 = ((-2.0 * (X+Y+Z+W)) - (2*Math.Sqrt(Math.Pow(X+Y+Z+W, 2) - 4.0*(Norm-z)))) / 8.0;
			if (d1<d2) return d2;
			else return d1;
		}

		public double GetMoveMinus(double z)
		{
			double d1 = ((-2.0 * (X+Y+Z+W)) + (2*Math.Sqrt(Math.Pow(X+Y+Z+W, 2) - 4.0*(Norm-z)))) / 8.0;
			double d2 = ((-2.0 * (X+Y+Z+W)) - (2*Math.Sqrt(Math.Pow(X+Y+Z+W, 2) - 4.0*(Norm-z)))) / 8.0;
			if (d1>d2) return d2;
			else return d1;
		}
#endif

		/// <summary>
		/// Create the Inverse of a Quaternion
		/// </summary>
		/// <param name="q">The Quaternion you want to Invert</param>
		/// <returns>The inverted Quaternion</returns>
		public static Quaternion operator !(Quaternion q)
		{
			return q.GetInverse();
		}

		/// <summary>
		/// Returns the Inverse of this Quaternion
		/// </summary>
		/// <returns>Inverted Quaternion</returns>
		public new Quaternion GetInverse() 
		{
			return Conjugate * (double)(1.0 / this.Norm);			
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(Quaternion q2, Quaternion q1) 
		{
			return new Quaternion( 
				QuaternionParameterType.ImaginaryReal, 				
				(q1.Imaginary | q2.Imaginary) + (q2.W*q1.Imaginary) + (q1.W*q2.Imaginary),
				q1.W*q2.W - ((Vector3f)q1.Imaginary & (Vector3f)q2.Imaginary));			
		}

		/// <summary>
		/// Scalar, dot or inner Product
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static double operator &(Quaternion q1, Quaternion q2) 
		{
			return q1.W*q2.W + ((Vector3f)q1.Imaginary&(Vector3f)q2.Imaginary);
		}

		/// <summary>
		/// Cross Product
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator |(Quaternion q1, Quaternion q2) 
		{
			return new Quaternion(QuaternionParameterType.ImaginaryReal, (Vector3f)q2.Imaginary|(Vector3f)q1.Imaginary, 0);
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="d">a Scalar Value</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(Quaternion q1, double d) 
		{			
			return new Quaternion(QuaternionParameterType.ImaginaryReal, (Vector3f)q1.Imaginary * d, q1.W * d);
		}

		/// <summary>
		/// Multiplication
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="d">a Scalar Value</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator *(double d, Quaternion q1) 
		{
			return q1 * d;
		}

		/// <summary>
		/// Addition
		/// </summary>
		/// <param name="q1">First Quaternion</param>
		/// <param name="q2">Second Quaternion</param>
		/// <returns>The resulting Quaternion</returns>
		public static Quaternion operator +(Quaternion q1, Quaternion q2) 
		{
			return new Quaternion(QuaternionParameterType.ImaginaryReal, q1.Imaginary + q2.Imaginary, q1.W + q2.W);
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
			get { return new Quaternion(QuaternionParameterType.ImaginaryReal, 0, 0, 0, 1); }
		}	

		/// <summary>
		/// Returns an Angle in Degree
		/// </summary>
		/// <param name="rad">Angle in Radiants</param>
		/// <returns>Angle in Degree</returns>
		public static double RadToDeg(double rad) 
		{
			return (double)((rad * 180.0) / Math.PI);
		}

		/// <summary>
		/// Returns an Angle in Radiants
		/// </summary>
		/// <param name="deg">Angle in Degree</param>
		/// <returns>Angle in Radiants</returns>
		public static double DegToRad(double deg) 
		{
			return (double)((deg * Math.PI) / 180.0);
		}
	
		/// <summary>
		/// Makes sure this Quaternion is a Unit Quaternion (Length=1)
		/// </summary>
		public void MakeUnitQuaternion()
		{
			double l = Length;
			X = X/l;
			Y = Y/l;
			Z = Z/l;
			W = W/l;
		}

		/// <summary>
		/// Returns the Rotation Angle (in Radiants)
		/// </summary>
		public double Angle 
		{
			get 
			{
				return (double)(Math.Acos(W) * 2.0);
			}
		}

		/// <summary>
		/// Returns the rotation (unit-)Axis
		/// </summary>
		public Vector3f Axis 
		{
			get 
			{
				double sina = (double)Math.Sin(Angle/2.0);

				if (sina==0) return new Vector3f(0, 0, 0);
				return new Vector3f(X / sina, Y /sina, Z / sina);
			}
		}

		/// <summary>
		/// Set the Quaternion based on an Axis-Angle pair
		/// </summary>
		/// <param name="axis">The (unit-)Axis</param>
		/// <param name="a">The rotation Angle</param>
		public void SetFromAxisAngle(Vector3f axis, double a) 
		{
			axis.MakeUnitVector();

			double sina = (double)Math.Sin(a/2.0);
			X = axis.X * sina;
			Y = axis.Y * sina;
			Z = axis.Z * sina;

			W = (double)Math.Cos(a/2.0);
		}

		/// <summary>
		/// Set the quaternion based on the passed Euler Angles
		/// </summary>
		/// <param name="ea">The Euler Angles</param>
		/// <remarks>
		/// Based on SourceCode from  
		/// http://vered.rose.utoronto.ca/people/david_dir/GEMS/GEMS.html
		/// 
		/// X=Head
		/// Y=Pitch
		/// Z=Roll
		/// </remarks>
		public void SetFromEulerAngles(Vector3f ea) 
		{
			Vector3f a = new Vector3f();
			double ti, tj, th, ci, cj, ch, si, sj, sh, cc, cs, sc, ss;
			
			ti = ea.X*0.5; tj = ea.Y*0.5; th = ea.Z*0.5;
			ci = Math.Cos(ti);  cj = Math.Cos(tj);  ch = Math.Cos(th);
			si = Math.Sin(ti);  sj = Math.Sin(tj);  sh = Math.Sin(th);
			cc = ci*ch; cs = ci*sh; sc = si*ch; ss = si*sh;
			X = (double)(cj*sc - sj*cs);
			Y = (double)(cj*ss + sj*cc);
			Z = (double)(cj*cs - sj*sc);
			W = (double)(cj*cc + sj*ss);
						
			//this.MakeUnitQuaternion();
		}

		/// <summary>
		/// Get the Euler Angles represented by this Quaternion
		/// </summary>
		/// <returns></returns>
		/// <remarks>
		/// Based on SourceCode from  
		/// http://vered.rose.utoronto.ca/people/david_dir/GEMS/GEMS.html
		/// 
		/// X=Head
		/// Y=Pitch
		/// Z=Roll
		/// </remarks>
		public Vector3f GetEulerAngles()
		{
			Vector3f ea = new Vector3f();			
			
			double Nq = Norm;
			double sf = (Nq > 0.0) ? (2.0 / Nq) : 0.0;
			double xs = X*sf,	  ys = Y*sf,	 zs = Z*sf;
			double wx = W*xs,	  wy = W*ys,	 wz = W*zs;
			double xx = X*xs,	  xy = X*ys,	 xz = X*zs;
			double yy = Y*ys,	  yz = Y*zs,	 zz = Z*zs;

			Vector4f[] m = new Vector4f[4];
			m[0] = new Vector4f((double)(1.0 - (yy + zz)),	(double)(xy - wz) ,			(double)(xz + wy),			0);
			m[1] = new Vector4f((double)(xy + wz),			(double)(1.0 - (xx + zz)),	(double)(yz - wx),			0);
			m[2] = new Vector4f((double)(xz - wy),			(double)(yz + wx),			(double)(1.0 - (xx + yy)),	0);
			m[3] = new Vector4f(0,							0,							0,							1);

			int i,j,k;
			i=0;
			j=1;
			k=2;

			
			double cy = Math.Sqrt(m[i][i]*m[i][i] + m[j][i]*m[j][i]);
			if (cy > 16*double.MinValue) 
			{
				ea.X = (double)Math.Atan2(m[k][j], m[k][k]);
				ea.Y = (double)Math.Atan2(-m[k][i], cy);
				ea.Z = (double)Math.Atan2(m[j][i], m[i][i]);
			} 
			else 
			{
				ea.X = (double)Math.Atan2(-m[j][k], m[j][j]);
				ea.Y = (double)Math.Atan2(-m[k][i], cy);
				ea.Z = 0;
			}
		
			
			return ea;
		}

		public override string ToString()
		{
			return base.ToString() + " (X=" +Axis.X.ToString("N2") + ", Y=" + Axis.Y.ToString("N2") + ", Z=" + Axis.Z.ToString("N2") + ", a=" + RadToDeg(Angle).ToString("N1") + ")";
		}

		/// <summary>
		/// Rotate the passed Vector by this Quaternion
		/// </summary>
		/// <param name="v">Vector you want to rotate</param>
		/// <returns>rotated Vector</returns>
		/// <remarks>Make sure the Quaternion is normalized before you rotate a Vector!</remarks>
		public Vector3f Rotate(Vector3f v) 
		{
			Quaternion vq = new Quaternion(QuaternionParameterType.ImaginaryReal, v.X, v.Y, v.Z, 1);			
			vq = this * vq * this.GetInverse();
			return new Vector3f(vq.X, vq.Y, vq.Z);
		}

		/// <summary>
		/// Create a clone of this Quaternion
		/// </summary>
		/// <returns></returns>
		public new Quaternion Clone() 
		{
			Quaternion q = new Quaternion(QuaternionParameterType.ImaginaryReal, this.X, this.Y, this.Z, this.W);
			return q;
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
