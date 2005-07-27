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
	public class InstanceTreeBuilder  :InstanceGroupTreeBuilder
	{
		InstanceResourceLister iarl;

		internal InstanceTreeBuilder(LoadedPackage pkg, ViewFilter filter, TreeView tv) : base(pkg, filter, tv)
		{
			iarl = new InstanceResourceLister(pkg, filter);
			iarl.Finished += new EventHandler(OnFinishedThread);	

		}

		protected override void BuildNode(TreeNode root, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, int ct)
		{
			TreeNode parent = GetNode(root.Nodes, pfd.LongInstance.ToString(), "0x"+Helper.HexString(pfd.LongInstance), null);
			TreeNode child = GetNode(parent.Nodes, pfd.LongInstance.ToString()+"-"+pfd.Group.ToString(), "0x"+Helper.HexString(pfd.Group), null);				
				
			if (parent.Tag==null) parent.Tag = new TreeNodeTag(parent.Text, new TreeNodeTag.RefreshResourceList(RefreshInstance), pfd, null);
			if (child.Tag==null) child.Tag = new TreeNodeTag(child.Text, new TreeNodeTag.RefreshResourceList(RefreshGroupInstance), pfd, null);
							
			((TreeNodeTag)parent.Tag).ResourceCount++;
			((TreeNodeTag)child.Tag).ResourceCount++;
			((TreeNodeTag)root.Tag).ResourceCount++;
			ct++;		
		}		

		void RefreshInstance(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			iarl.Prepare(lv, p, tag);						
			ResourceListerBase.Start(iarl);	
		}
	}
}
