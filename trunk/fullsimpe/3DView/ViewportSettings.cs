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
using System.Drawing;
using Microsoft.DirectX;

namespace Ambertation
{
	/// <summary>
	/// Contains attributes tha determin the location of the Object in the Viewport
	/// </summary>
	public class ViewportSetting 
	{
		float angx, angy, posx, posy, posz, scale;
		Vector3 campos, camtarget, camup;
		float fov, aspect, near, far;

		internal ViewportSetting()
		{
			Reset();			
		}


		/// <summary>
		/// Reset the Parameters
		/// </summary>
		public void Reset()
		{
			angx = angy = 0;
			posx = posy = posz = 0;
			scale = 1;

			fov = (float)(Math.PI / 4);
			aspect = 1;
			near = 1;
			far = 100;

			campos = new Vector3( 0.0f, 3.0f, 5.0f );
			camtarget = new Vector3( 0.0f, 0.0f, 0.0f );
			camup = new Vector3( 0.0f, 1.0f, 0.0f );
		}

		public Vector3 CameraUpVector
		{
			get { return camup; }
			set { camup = value; }
		}

		public Vector3 CameraTarget
		{
			get { return camtarget; }
			set { camtarget = value; }
		}

		public Vector3 CameraPosition
		{
			get { return campos; }
			set { campos = value; }
		}

		public float NearPlane
		{
			get { return near; }
			set { near = value; }
		}

		public float FarPlane
		{
			get { return far; }
			set { far = value; }
		}

		public float Aspect
		{
			get { return aspect; }
			set { aspect = value; }
		}

		public float FoV
		{
			get { return fov; }
			set { fov = value; }
		}

		public float AngelX
		{
			get { return angx; }
			set { angx = value; }
		}

		public float AngelY
		{
			get { return angy; }
			set { angy = value; }
		}

		public float X
		{
			get { return posx; }
			set { posx = value; }
		}

		public float Y
		{
			get { return posy; }
			set { posy = value; }
		}

		public float Z
		{
			get { return posz; }
			set { posz = value; }
		}

		public float Scale
		{
			get { return scale; }
			set { scale = value; }
		}
	}
}
