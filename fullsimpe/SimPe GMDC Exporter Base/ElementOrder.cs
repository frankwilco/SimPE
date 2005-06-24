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
		XZY = 1
	}

	/// <summary>
	/// Helper Class that is used to determin the Element Order
	/// </summary>
	public class ElementOrder 
	{
		static byte[,] components = null;
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
				if (s==ElementSorting.XZY) 
				{
					//rotate 90° around X-Axis
					m = new SimPe.Geometry.Matrixd(3, 3);
					m[0,0] = -1;			m[0,1] = 0;			m[0,2] = 0;
					m[1,0] = 0;			m[1,1] = 0;			m[1,2] = 1;
					m[2,0] = 0;			m[2,1] = 1;			m[2,2] = 0;
				}
				else m=SimPe.Geometry.Matrixd.GetIdentity(3, 3);	


				ms = new SimPe.Geometry.Matrixd(3, 3);
				ms[0,0] = Helper.WindowsRegistry.ImportExportScaleFactor;	ms[0,1] = 0;												ms[0,2] = 0;
				ms[1,0] = 0;												ms[1,1] = Helper.WindowsRegistry.ImportExportScaleFactor;	ms[1,2] = 0;
				ms[2,0] = 0;												ms[2,1] = 0;												ms[2,2] = Helper.WindowsRegistry.ImportExportScaleFactor;
				
				//get the inverse
				msi = !ms;
							
				if (m.Orthogonal) 
				{
					mi = m.GetTranspose();
					mn = m;
					mni = mn.GetTranspose();
				}
				else 
				{
					mi = !m;
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

			if (components == null) 
			{
				components = new byte[2,3];

				//XYZ-Order
				components[0,0] = 0;
				components[0,1] = 1;
				components[0,2] = 2;

				//XZY-Order
				components[1,0] = 0;
				components[1,1] = 2;
				components[1,2] = 1;
			}

			
		}

		/// <summary>
		/// Index of the X-Components
		/// </summary>
		public int X
		{
			get { return components[(int)s, 0]; }
		}

		/// <summary>
		/// Index of the Y-Components
		/// </summary>
		public int Y
		{
			get { return components[(int)s, 1]; }
		}

		/// <summary>
		/// Index of the Z-Components
		/// </summary>
		public int Z
		{
			get { return components[(int)s, 2]; }
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
