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
using SimPe.Packages;
using SimPe.Interfaces.Files;


namespace SimPe.Plugin
{
	internal class MmatListCompare : System.Collections.IComparer
	{
		#region IComparer Member

		public int Compare(object x, object y)
		{
			SimPe.Plugin.MmatWrapper mmat1 = (SimPe.Plugin.MmatWrapper)x;
			SimPe.Plugin.MmatWrapper mmat2 = (SimPe.Plugin.MmatWrapper)y;

			int cmp = mmat1.GetSaveItem("materialStateFlags").IntegerValue - mmat2.GetSaveItem("materialStateFlags").IntegerValue;
			if (cmp==0) cmp = mmat1.GetSaveItem("objectStateIndex").IntegerValue - mmat2.GetSaveItem("objectStateIndex").IntegerValue;

			return cmp;
		}

		#endregion

	}

}
