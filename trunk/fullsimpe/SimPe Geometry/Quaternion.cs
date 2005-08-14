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
	internal enum QuaternionParameterType : byte
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
		internal Quaternion (QuaternionParameterType p, double x, double y, double z, double w) : base ()
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
		internal Quaternion (QuaternionParameterType p, Vector3f v, double a)  : base()
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
		/// Returns an Empty Quaternion
		/// </summary>
		public static Quaternion Zero 
		{
			get { return new Quaternion(QuaternionParameterType.ImaginaryReal, 0, 0, 0, 0); }
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
			if (l!=0)
			{
				X = X/l;
				Y = Y/l;
				Z = Z/l;
				W = W/l;
			}
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
		/// X=Head
		/// Y=Pitch
		/// Z=Roll
		/// </remarks>
		public static Quaternion FromEulerAngles(Vector3f ea) 
		{			
			/*Quaternion q1 = new Quaternion(QuaternionParameterType.ImaginaryReal, Math.Sin(ea.Y/2), 0, 0, Math.Cos(ea.Y/2));
			Quaternion q2 = new Quaternion(QuaternionParameterType.ImaginaryReal, 0, Math.Sin(ea.X/2), 0, Math.Cos(ea.X/2));
			Quaternion q3 = new Quaternion(QuaternionParameterType.ImaginaryReal, 0, 0, Math.Sin(ea.Z/2), Math.Cos(ea.Z/2));

			return (q3 * q1) *q2;*/

			Quaternion q = new Quaternion();
			double angle;
			angle = ea.X * 0.5;
			double sr = (double)Math.Sin(angle);
			double cr = (double)Math.Cos(angle);
 
			angle = ea.Y * 0.5;
			double sp = (double)Math.Sin(angle);
			double cp = (double)Math.Cos(angle);
 
			angle = ea.Z * 0.5;
			double sy = (double)Math.Sin(angle);
			double cy = (double)Math.Cos(angle);

			double cpcy = cp * cy;
			double spcy = sp * cy;
			double cpsy = cp * sy;
			double spsy = sp * sy; 

			q.X = sr * cpcy - cr * spsy;
			q.Y = cr * spcy + sr * cpsy;
			q.Z = cr * cpsy - sr * spcy;
			q.W = cr * cpcy + sr * spsy;
 
			q.MakeUnitQuaternion();
			return q;
		}

		/// <summary>
		/// Set the quaternion based on the passed Euler Angles
		/// </summary>
		public static Quaternion FromEulerAngles(double head, double pitch, double roll) 
		{			
			return FromEulerAngles(new Vector3f(head, pitch, roll));
		}

		public static Quaternion FromAxisAngle(Vector3f v, double angle)
		{
			v.MakeUnitVector();
			return new Quaternion(QuaternionParameterType.UnitAxisAngle, v.X, v.Y, v.Z, angle);
		}

		public static Quaternion FromAxisAngle(double x, double y, double z, double angle)
		{
			return new Quaternion(QuaternionParameterType.UnitAxisAngle, x, y, z, angle);
		}

		public static Quaternion FromImaginaryReal(Vector3f v, double w)
		{			
			return new Quaternion(QuaternionParameterType.ImaginaryReal, v.X, v.Y, v.Z, w);
		}

		public static Quaternion FromImaginaryReal(Vector4f v)
		{			
			return new Quaternion(QuaternionParameterType.ImaginaryReal, v.X, v.Y, v.Z, v.W);
		}

		public static Quaternion FromImaginaryReal(double x, double y, double z, double w)
		{
			return new Quaternion(QuaternionParameterType.ImaginaryReal, x, y, z, w);
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
		protected Vector3f GetEulerAnglesOlder()
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

		/// <summary>
		/// Makes sure that the passed Radius has only one Pi cycle. Result is in Intervall [-Pi; +PI]
		/// </summary>
		/// <param name="rad"></param>
		/// <returns></returns>
		double NormalizeRad(double rad)
		{
			while (rad>Math.PI) rad -= 2*Math.PI;
			while (rad<-Math.PI) rad += 2*Math.PI;

			return rad;
		}

		/// <summary>
		/// Get the Euler Angles represented by this Quaternion
		/// </summary>
		/// <returns></returns>
		/// X=Yaw
		/// Y=Pitch
		/// Z=Roll
		/// </remarks>
		public Vector3f GetEulerAngles()
		{
			Vector3f a = Axis;

			double dx = Math.Abs(a.X)-1.0; if (Math.Abs(dx)<10*float.Epsilon) dx = 0;
			double dy = Math.Abs(a.Y)-1.0; if (Math.Abs(dy)<10*float.Epsilon) dy = 0;
			double dz = Math.Abs(a.Z)-1.0; if (Math.Abs(dz)<10*float.Epsilon) dz = 0;

			if (dx==0 && dy!=0 && dz!=0) return new Vector3f(a.X*Angle, 0, 0);
			if (dx!=0 && dy==0 && dz!=0) return new Vector3f(0, a.Y*Angle, 0);
			if (dx!=0 && dy!=0 && dz==0) return new Vector3f(0, 0, a.Z*Angle);
			
			double sqw = W*W;    
			double sqx = X*X;    
			double sqy = Y*Y;    
			double sqz = Z*Z; 
			Vector3f euler = new Vector3f();
 
			// heading = rotaton about z-axis 
			euler.Z = (Math.Atan2(2.0 * (X*Y +Z*W),(sqx - sqy - sqz + sqw))); 

			// bank = rotation about x-axis 
			euler.X =  (Math.Atan2(2.0 * (Y*Z +X*W),(-sqx - sqy + sqz + sqw))); 

			// attitude = rotation about y-axis 
			euler.Y =  (Math.Asin(-2.0 * (X*Z - Y*W)));

			euler.X = NormalizeRad(euler.X);
			euler.Y = NormalizeRad(euler.Y);
			euler.Z = NormalizeRad(euler.Z);
			return euler;
		}

		/// <summary>
		/// Get the Euler Angles represented by this Quaternion
		/// </summary>
		/// <returns></returns>
		/// X=Yaw
		/// Y=Pitch
		/// Z=Roll
		/// </remarks>
		protected Vector3f GetEulerAnglesOld()
		{			
			Matrixd m= this.Matrix;
			Vector3f ea = new Vector3f();
	
			ea.X = Math.Atan2(-m[2,0], m[2, 2]);
			ea.Y = Math.Asin(m[2, 1]);

			if (Math.Cos(ea.Y)==0) 
				ea.Z = Math.Atan2(m[1, 0], m[0, 0]);
			else 
				ea.Z = Math.Atan2(-m[0, 1], m[1, 1]);

			return ea;			
		}

		

		
	

		public override string ToString()
		{
			return base.ToString() + " (X=" +Axis.X.ToString("N2") + ", Y=" + Axis.Y.ToString("N2") + ", Z=" + Axis.Z.ToString("N2") + ", a=" + RadToDeg(Angle).ToString("N1")+"    euler=h:"+Quaternion.RadToDeg(GetEulerAngles().X).ToString("N1")+"; p:"+Quaternion.RadToDeg(GetEulerAngles().Y).ToString("N1")+"; r:"+Quaternion.RadToDeg(GetEulerAngles().Z).ToString("N1") + ")";
		}

		/// <summary>
		/// Rotate the passed Vector by this Quaternion
		/// </summary>
		/// <param name="v">Vector you want to rotate</param>
		/// <returns>rotated Vector</returns>
		/// <remarks>Make sure the Quaternion is normalized before you rotate a Vector!</remarks>
		public Vector3f Rotate(Vector3f v) 
		{
			/*Quaternion vq = new Quaternion(QuaternionParameterType.ImaginaryReal, v.X, v.Y, v.Z, 1);			
			vq = this * vq * this.GetInverse();
			return new Vector3f(vq.X, vq.Y, vq.Z);*/

			SimPe.Geometry.Vector4f v4 = new SimPe.Geometry.Vector4f(v.X, v.Y, v.Z, 0);
			v4 = Matrix*v4;
			return new SimPe.Geometry.Vector3f(v4.X, v4.Y, v4.Z);
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

		/// <summary>
		/// Returns the Matirx for this Quaternion. 		
		/// </summary>
		/// <remarks>
		/// Before the Matrix is generated, the Quaternion will get Normalized!!!
		/// </remarks>
		public Matrixd Matrix
		{
			get 
			{
				this.MakeUnitQuaternion();

				Matrixd m = new SimPe.Geometry.Matrixd(4, 4);
				double sx = Math.Pow(X, 2);
				double sy = Math.Pow(Y, 2);
				double sz = Math.Pow(Z, 2);
				double sw = Math.Pow(W, 2);
				m[0, 0] = 1 - 2*(sy+sz);	m[0, 1] = 2*(X*Y - W*Z);	m[0, 2] = 2*(X*Z + W*Y);	m[0, 3] = 0;
				m[1, 0] = 2*(X*Y + W*Z);	m[1, 1] = 1 - 2*(sx+sz);	m[1, 2] = 2*(Y*Z - W*X);	m[1, 3] = 0;
				m[2, 0] = 2*(X*Z - W*Y);	m[2, 1] = 2*(Y*Z + W*X);	m[2, 2] =  1 - 2*(sx+sy);	m[2, 3] = 0;
				m[3, 0] = 0;				m[3, 1] = 0;				m[3, 2] = 0;				m[3, 3] = 1;

				return m;
			}
		}

		void LoadCorrection()
		{
			W = -W;
			//X = -X;
			//Y = Z;
			//Z = -Z;
		}
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			base.Unserialize(reader);
			
			LoadCorrection();
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
			LoadCorrection();
			base.Serialize(writer);	
			LoadCorrection();
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
