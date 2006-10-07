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
	/// Docakble Tool to view/change Resource specific Informations
	/// </summary>
	public class HexDockTool : SimPe.Interfaces.IDockableTool
	{
		ResourceDock rd;
		public HexDockTool(ResourceDock rd)
		{
			this.rd = rd;
		}

		#region IDockableTool Member

        public Ambertation.Windows.Forms.DockPanel GetDockableControl()
		{
			return rd.dcHex;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			rd.button1.Enabled = false;
			if (!rd.dcHex.IsFloating && !rd.dcHex.IsDocked) return;
			if (es.HasFileDescriptor) 
			{
				foreach (SimPe.Events.ResourceContainer e in es) 
				{
					if (e.HasFileDescriptor && e.HasPackage)
					{
						try 
						{							
							rd.hexpfd = e.Resource.FileDescriptor;
							SimPe.Interfaces.Files.IPackedFile pf = e.Resource.Package.Read(e.Resource.FileDescriptor);
							rd.hvc.Data = pf.UncompressedData;
							rd.button1.Enabled = true;
							return;
						} 
						catch {}
						
					}
				}
			}
			
			rd.hvc.Data = null;
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return rd.dcResource.Text;
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
				return rd.dcResource.TabImage;
			}
		}		

		public virtual bool Visible 
		{
			get { return GetDockableControl().IsDocked ||  GetDockableControl().IsFloating; }
		}

		#endregion
	}
}
