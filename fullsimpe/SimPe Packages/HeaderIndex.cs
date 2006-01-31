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

namespace SimPe.Packages
{
	/// <summary>
	/// Index Informations stored in the Header
	/// </summary>
	public class HeaderIndex : HeaderHole, SimPe.Interfaces.Files.IPackageHeaderIndex, System.IDisposable
	{
		Interfaces.Files.IPackageHeader parent;
		internal HeaderIndex(Interfaces.Files.IPackageHeader hd) 
		{
			this.parent = hd;
		}
		/// <summary>
		/// IndexType of the File
		/// </summary>
		internal Int32 type;

		/// <summary>
		/// returns the Index Type of the File
		/// </summary>
		/// <remarks>This value should be 7</remarks>
		public int Type
		{
			get 
			{
				return type;
			}
			set 
			{
				type = value; 
			}
		}		

		public override int ItemSize
		{
			get
			{
				if (parent.IndexType == SimPe.Data.MetaData.IndexTypes.ptLongFileIndex)
					return 6*4;
				else if (parent.IndexType == SimPe.Data.MetaData.IndexTypes.ptShortFileIndex)
					return 5*4;
				return base.ItemSize;
			}
		}

		internal Interfaces.Files.IPackageHeader Parent
		{
			get {return parent;}
		}

		internal void UseInParent()
		{
			if (parent==null) return;
			if (parent is HeaderData) 
			{
				HeaderData hd = parent as HeaderData;			
				hd.index = this;
			}
		}

		public virtual void Dispose()
		{
			
		}
	}

}
