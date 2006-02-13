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

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Describes the Order how Vectors should be Exported/read from a 3d-File
	/// </summary>
	public enum ElementSorting: byte 
	{
		/// <summary>
		/// Normal X, Y, Z Order
		/// </summary>
		XYZ = 0,
		/// <summary>
		/// Flipped Depth with width (X, Z, Y)
		/// </summary>
		XZY = 1,
		/// <summary>
		/// Used when you want to display a Preview
		/// </summary>
		Preview
	}

	/// <summary>
	/// Helper Class that is used to determin the Element Order
	/// </summary>
	public class ElementOrder 
	{
		ElementSorting s;

		/// <summary>
		/// Returns/Sets the Sorting that should be Used
		/// </summary>
		public ElementSorting Sorting 
		{
			get { return s; }
			set 
			{ 
				s = value; 
				if (s==ElementSorting.XZY||s==ElementSorting.Preview) 
				{
					SimPe.Geometry.Matrixd mt = SimPe.Geometry.Matrixd.RotateYawPitchRoll(Math.PI, -Math.PI/2, 0);
					m = mt.To33Matrix();
					
					mt = SimPe.Geometry.Matrixd.RotateYawPitchRoll(Math.PI, -Math.PI/2, 0);
					mi = mt.To33Matrix();
				} 
				else 
				{
					m = SimPe.Geometry.Matrixd.GetIdentity(3, 3);	
					mi = SimPe.Geometry.Matrixd.GetIdentity(3, 3);	
				}

				ms = SimPe.Geometry.Matrixd.Scale(Helper.WindowsRegistry.ImportExportScaleFactor).To33Matrix();
				msi = SimPe.Geometry.Matrixd.Scale(1.0/Helper.WindowsRegistry.ImportExportScaleFactor).To33Matrix();				
							
				if (m.Orthogonal) 
				{
					mn = m;
					mni = mn.GetTranspose();
				}
				else 
				{
					mn = mi.GetTranspose();
					mni = !mn;
				}
			}
		}

		SimPe.Geometry.Matrixd m, mn, mi, mni, ms, msi;

		

		/// <summary>
		/// Create a new Class with the given Sorting
		/// </summary>
		/// <param name="sorting">the sorting that should be used</param>
		public ElementOrder(ElementSorting sorting) 
		{
			Sorting = sorting;
		}

		public SimPe.Geometry.Matrixd TransformMatrix
		{
			get {return m;}
		}

		public SimPe.Geometry.Matrixd ScaleMatrix
		{
			get {return ms;}
		}

		public SimPe.Geometry.Quaternion TransformRotation(SimPe.Geometry.Quaternion q) 
		{
			SimPe.Geometry.Vector3f r = q.Axis;				
			r = this.Transform(r);								
			q = SimPe.Geometry.Quaternion.FromAxisAngle(r, q.Angle);

			return q;
		}

		public SimPe.Geometry.Quaternion InverseTransformRotation(SimPe.Geometry.Quaternion q) 
		{
			SimPe.Geometry.Vector3f r = q.Axis;				
			r = this.InverseTransform(r);								
			q = SimPe.Geometry.Quaternion.FromAxisAngle(r, q.Angle);

			return q;
		}

		/// <summary>
		/// Transform the passed vector to fit into the specified Coordinate System
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f Transform(SimPe.Geometry.Vector3f v) 
		{
			return m*v;
		}

		/// <summary>
		/// the inveres to <see cref="Transform"/>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f InverseTransform(SimPe.Geometry.Vector3f v) 
		{
			return mi*v;
		}

		/// <summary>
		/// Transform the passed normalvector to fit into the specified Coordinate System
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f TransformNormal(SimPe.Geometry.Vector3f v) 
		{
			return mn*v;
		}

		/// <summary>
		/// the inveres to <see cref="TransformNormal"/>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f InverseTransformNormal(SimPe.Geometry.Vector3f v) 
		{
			return mni*v;
		}

		/// <summary>
		/// Transform the passed vector to fit into the specified Coordinate System and Scale
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f TransformScaled(SimPe.Geometry.Vector3f v) 
		{
			return (m*ms)*v;
		}

		/// <summary>
		/// the inveres to <see cref="TransformScaled"/>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f InverseTransformScaled(SimPe.Geometry.Vector3f v) 
		{
			return !(m*ms) * v;
		}

		/// <summary>
		/// Scale the passed Vector
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f Scale(SimPe.Geometry.Vector3f v) 
		{
			return ms*v;
		}

		/// <summary>
		/// the inveres to <see cref="Scale"/>
		/// </summary>
		/// <param name="v"></param>
		/// <returns></returns>
		public SimPe.Geometry.Vector3f InverseScale(SimPe.Geometry.Vector3f v) 
		{
			return msi * v;
		}
	}

}
