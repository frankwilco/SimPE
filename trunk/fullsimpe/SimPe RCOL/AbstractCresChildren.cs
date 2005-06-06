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
using System.Windows.Forms;
using SimPe.Plugin;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// Implemented common Methods of the ICresChildren Interface
	/// </summary>
	public abstract class AbstractCresChildren : AbstractRcolBlock, ICresChildren
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AbstractCresChildren(Rcol parent) : base(parent) {}

		/// <summary>
		/// Returns the Child Block with the given Index from the Parent Rcol
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public ICresChildren GetBlock(int index) 
		{
			if (Parent==null) return null;

			if (index<0) return null;
			if (index>= this.Parent.Blocks.Length) return null;

			object o = Parent.Blocks[index];

			if (o.GetType().GetInterface("ICresChildren", false) == typeof(ICresChildren)) 
				return (ICresChildren)o;
			
			return null;
		}

		/// <summary>
		/// Returns a List of all Child Blocks referenced by this Element
		/// </summary>
		public abstract IntArrayList ChildBlocks 
		{
			get;
		}	
	
		public abstract int ImageIndex 
		{
			get;
		}
	}
}
