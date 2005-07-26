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
	public class TypeTreeBuilder  :TreeBuilderBase
	{
		TypeResourceLister tarl;

		internal TypeTreeBuilder(LoadedPackage pkg, ViewFilter filter, TreeView tv) : base(pkg, filter, tv)
		{
			tarl = new TypeResourceLister(pkg, filter);
			tarl.Finished += new EventHandler(OnFinishedThread);	
		}

		protected override void BuildNode(TreeNode root, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, int ct)
		{
			Data.TypeAlias ta = Data.MetaData.FindTypeAlias(pfd.Type);
			TreeNode parent = GetNode(root.Nodes, pfd.Type, ta.ToString() + " ("+ta.shortname+")", pfd);				
			if (parent.Tag==null) parent.Tag =new TreeNodeTag(parent.Text, new TreeNodeTag.RefreshResourceList(RefreshType), pfd, null);

			((TreeNodeTag)parent.Tag).ResourceCount++;
			((TreeNodeTag)root.Tag).ResourceCount++;
		}		

		void RefreshType(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			tarl.Prepare(lv, p, tag);						
			ResourceListerBase.Start(tarl);	
		}		
	}
}
