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

namespace SimPe.Actions.Default
{
	/// <summary>
	/// Zusammenfassung für ExportAction.
	/// </summary>
	public class DeleteAction : AbstractActionDefault
	{
		public DeleteAction()
		{
			
		}
		#region IToolAction Member		

		public override bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs[] es, LoadedPackage guipackage)
		{
			bool res = base.ChangeEnabledStateEventHandler (sender, es, guipackage);
			if (res) 
			{
				res = false;
				foreach (SimPe.Events.ResourceEventArgs e in es)
					if (e.Resource!=null) 
						if (e.Resource.FileDescriptor!=null)
							if (!e.Resource.FileDescriptor.MarkForDelete) return true;								
			}
			return false;
		}

		public override void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs[] es, LoadedPackage guipackage)
		{
			if (!ChangeEnabledStateEventHandler(null, es, guipackage)) return;

			foreach (SimPe.Events.ResourceEventArgs e in es) 
				e.Resource.FileDescriptor.MarkForDelete = true;				
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Delete";
		}

		#endregion

		#region IToolExt Member		
		public override System.Drawing.Image Icon
		{
			get
			{
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.actiondelete.png"));
			}
		}

		public override System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.ShiftDel;
			}
		}

		#endregion
	}
}
