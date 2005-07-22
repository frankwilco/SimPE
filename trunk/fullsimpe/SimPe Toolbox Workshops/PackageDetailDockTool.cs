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
	public class PackageDetailDockTool : SimPe.Interfaces.IDockableTool
	{
		dcPackageDetails dc;
		public PackageDetailDockTool()
		{
			dc = new dcPackageDetails();
			pkg = null;
		}

		#region IDockableTool Member

		public TD.SandDock.DockControl GetDockableControl()
		{
			return dc;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		SimPe.Interfaces.Files.IPackageFile pkg;
		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (!es.Loaded) dc.SetPackage(null);
			else 
			{
				//Only once for a package
				if (pkg!=null) if (pkg.Equals(es.LoadedPackage.Package)) return;

				dc.SetPackage(es.LoadedPackage.Package);
			}
	
			pkg = es.LoadedPackage.Package;
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return dc.Text;
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
				return dc.TabImage;
			}
		}

		#endregion
	}
}
