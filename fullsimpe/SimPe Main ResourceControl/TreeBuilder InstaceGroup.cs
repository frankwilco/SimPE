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
	public abstract class InstanceGroupTreeBuilder  :TreeBuilderBase
	{
		GroupInstanceResourceLister giarl;

		internal InstanceGroupTreeBuilder(LoadedPackage pkg, ViewFilter filter, TreeView tv) : base(pkg, filter, tv)
		{
			
			giarl = new GroupInstanceResourceLister(pkg, filter);
			giarl.Finished += new EventHandler(OnFinishedThread);
		}


        protected void RefreshGroupInstance(ResourceListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			giarl.Prepare(lv, p, tag);						
			ResourceListerBase.Start(giarl);	
		}	
	}
}
