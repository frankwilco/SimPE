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
using System.Windows.Forms;
using System.Collections;

namespace SimPe
{
	/// <summary>
	/// This can be assigned to a TreeNode.Tag and contains the delegate that should update the ListView
	/// and the <see cref="SimPe.Interfaces.Files.IPackedFileDescriptor"/> that represents the File or 
	/// arbitary extra Data
	/// </summary>
	public class TreeNodeTag
	{
		/// <summary>
		/// This delegate is used to call the ListView Update Functions
		/// </summary>
		public delegate void RefreshResourceList(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, object tag);

		RefreshResourceList fkt;
		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		object tag;
		string name;

		/// <summary>
		/// Create a new Isntance
		/// </summary>
		/// <param name="fkt">The function that should be called to update the ResourceView (can be null)</param>
		/// <param name="pfd">The ResourceDescriptor (can be null)</param>
		/// <param name="tag">arbitary Data (can be null)</param>
		internal TreeNodeTag(string name, RefreshResourceList fkt, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, object tag)
		{
			this.fkt = fkt;
			this.pfd = pfd;
			this.tag = tag;
			this.name = name;

			resct = 0;
		}

		/// <summary>
		/// Refresh the content of the passed ListView
		/// </summary>
		/// <param name="lv"></param>
		public void Refresh(ListView lv) 
		{
			if (fkt==null) return;
			//lv.BeginUpdate();
			TreeBuilder.ClearListView(lv);
			fkt(lv, this.pfd, this.tag);
			//lv.EndUpdate();
		}

		int resct;
		/// <summary>
		/// Returns the Number of stared Resources
		/// </summary>
		public int ResourceCount
		{
			get {return resct; }
			set {resct = value; }
		}

		/// <summary>
		/// Name of this Node
		/// </summary>
		public string Name 
		{
			get { return name; }
		}

		public override string ToString()
		{
			return name + " ("+resct.ToString()+")";
		}

	}

}
