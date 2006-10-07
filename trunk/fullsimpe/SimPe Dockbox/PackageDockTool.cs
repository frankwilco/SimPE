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

namespace SimPe.Plugin.Tool.Dockable
{
	

	/// <summary>
	/// Dockable Tool that displays Package specific Informations
	/// </summary>
	public class PackageDockTool : SimPe.Interfaces.IDockableTool
	{
		ResourceDock rd;
		public PackageDockTool(ResourceDock rd)
		{
			this.rd = rd;
		}

		#region IDockableTool Member

		public Ambertation.Windows.Forms.DockPanel GetDockableControl()
		{
			return rd.dcPackage;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		SimPe.Interfaces.Files.IPackageFile pkg;
		
		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (es.LoadedPackage!=null)
				if (es.LoadedPackage.Loaded) 
				{
					bool newpkg = (pkg==null);
					if (!newpkg) newpkg = !es.LoadedPackage.Package.Equals(pkg);
			
					
					if (newpkg) 
					{
						SimPe.Packages.PackageRepair pr = new SimPe.Packages.PackageRepair(es.LoadedPackage.Package);
						if (Helper.WindowsRegistry.HiddenMode)
							rd.pgHead.SelectedObject = pr.IndexDetailsAdvanced;
						else
							rd.pgHead.SelectedObject = pr.IndexDetails;					
						
						pkg = es.LoadedPackage.Package;
						
						rd.lv.Items.Clear();						
						for (uint i=0; i<pkg.Header.HoleIndex.Count; i++) 
						{
							System.Windows.Forms.ListViewItem lvi = new System.Windows.Forms.ListViewItem();
							SimPe.Packages.HoleIndexItem hii = es.LoadedPackage.Package.GetHoleIndex(i);
							lvi.Text = "0x"+Helper.HexString(hii.Offset);
							lvi.SubItems.Add("0x"+Helper.HexString(hii.Size));
							rd.lv.Items.Add(lvi);
						}
					}
					return;
				}
			
			pkg = null;
			rd.pgHead.SelectedObject = null;
			rd.lv.Items.Clear();
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return rd.dcPackage.Text;
		}

		#endregion

		#region IToolExt Member

		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return rd.dcPackage.TabImage;
			}
		}	

		public virtual bool Visible 
		{
			get { return GetDockableControl().IsDocked ||  GetDockableControl().IsFloating; }
		}

		#endregion
	}
}
