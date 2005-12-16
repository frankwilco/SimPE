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

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// Implemented by Blocks available in a CRES Hirarchy to link to child Blocks
	/// </summary>
	public interface ICresChildren : System.Collections.IEnumerable
	{
		/// <summary>
		/// Returns a List of all Child Blocks referenced by this Element
		/// </summary>
		IntArrayList ChildBlocks 
		{
			get;
		}

		/// <summary>
		/// Returns the Index of this node within it's Parent (-1 if not found)
		/// </summary>
		int Index 
		{
			get;
		}

		/// <summary>
		/// Returns a List of all Parent Nodes
		/// </summary>
		IntArrayList GetParentBlocks();
		
		/// <summary>
		/// Returns the First Block that is holds this Node as a Child
		/// </summary>
		/// <returns></returns>
		ICresChildren GetFirstParent();

		/// <summary>
		/// Returns the TransformNode Object of this Node (can be null!)
		/// </summary>
		TransformNode StoredTransformNode
		{
			get;
		}
		
		/// <summary>
		/// Returns the parent RCol Container
		/// </summary>
		Rcol Parent 
		{
			get;
		}

		/// <summary>
		/// Returns the Child Block with the given Index from the Parent Rcol
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		ICresChildren GetBlock(int index);

		/// <summary>
		/// Returns the Index of the Image that should be displayed in the TreeView
		/// </summary>
		/// <remarks>
		/// 0 = Nothing
		/// 1 = Joint
		/// 2 = Light
		/// 3 = Shape
		/// 4 = Error
		/// </remarks>
		int ImageIndex 
		{
			get;
		}

		/// <summary>
		/// Returns the effective Transformation, that is described by the CresHirarchy
		/// </summary>
		/// <returns>Effective Transformation</returns>
		SimPe.Geometry.VectorTransformation GetEffectiveTransformation();

		string GetName();		
	}
}
