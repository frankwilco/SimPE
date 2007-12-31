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
	/// Dockable Tool that displays Wrapper specific Informations
	/// </summary>
	public class WrapperDockTool : SimPe.Interfaces.IDockableTool
	{
		ResourceDock rd;
		public WrapperDockTool(ResourceDock rd)
		{
			this.rd = rd;
		}

		#region IDockableTool Member

        public Ambertation.Windows.Forms.DockPanel GetDockableControl()
		{
			return rd.dcWrapper;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (!es.Empty)
				if (es.HasFileDescriptor)
					{
						SimPe.Interfaces.IWrapper wrp = FileTable.WrapperRegistry.FindHandler(es[0].Resource.FileDescriptor.Type);

						if (wrp!=null) 
						{
							rd.lbName.Text = wrp.WrapperDescription.Name;
							rd.lbAuthor.Text = wrp.WrapperDescription.Author;
							rd.lbVersion.Text = wrp.WrapperDescription.Version.ToString();
							rd.lbDesc.Text = wrp.WrapperDescription.Description;
							rd.pb.Image = wrp.WrapperDescription.Icon;
							if (rd.pb.Image!=null) rd.lbName.Left = rd.pb.Right+4;
							else rd.lbName.Left = rd.pb.Left;
							return;
						}
					}

			rd.lbName.Text = SimPe.Localization.GetString("Unknown");
			rd.lbAuthor.Text = SimPe.Localization.GetString("Unknown");
			rd.lbVersion.Text = SimPe.Localization.GetString("Unknown");
			rd.lbDesc.Text = SimPe.Localization.GetString("");
			rd.pb.Image = null;
			rd.lbName.Left = rd.pb.Left;
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return rd.dcWrapper.Text;
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
				return rd.dcWrapper.TabImage;
			}
		}	

		public virtual bool Visible 
		{
			get { return GetDockableControl().IsDocked ||  GetDockableControl().IsFloating; }
		}

		#endregion
	}
}
