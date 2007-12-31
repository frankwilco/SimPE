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
using SimPe.Plugin.Anim;

namespace SimPe.Plugin
{
	/// <summary>
	/// Used to display the MeshBlock Listing
	/// </summary>
	class ListedMeshBlocks
	{
		AnimationMeshBlock amb;
		SimPe.Plugin.GenericRcol cres, gmdc;
		public ListedMeshBlocks(AnimationMeshBlock amb)
		{
			this.amb = amb;
			cres = amb.FindDefiningCRES();
			if (cres!=null) gmdc = amb.FindUsedGMDC(cres);
		}

		public AnimationMeshBlock ANIMBlock
		{
			get {return amb;}
		}

		public SimPe.Plugin.GenericRcol CRES 
		{
			get {return cres;}
		}

		public SimPe.Plugin.GenericRcol GMDC 
		{
			get {return gmdc;}
		}

		public override string ToString()
		{
			string s= amb.ToString ();
			if (cres==null) s += "[No CRES found]";
			else if (gmdc==null) s += "[No GMDC found]";

			return s;
		}

	}
}
