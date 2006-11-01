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
	public class AddAction : ReplaceAction
	{
		public AddAction()
		{
			
		}
		#region IToolAction Member		

		public override bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (es.LoadedPackage==null) return false;
			return es.LoadedPackage.Loaded;
		}

		public override void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (!ChangeEnabledStateEventHandler(null, es)) return;

			SimPe.Collections.PackedFileDescriptors pfds = this.LoadDescriptors(true);
            es.LoadedPackage.Package.BeginUpdate();
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				es.LoadedPackage.Package.Add(pfd);
            es.LoadedPackage.Package.EndUpdate();
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Add...";
		}

		#endregion

		#region IToolExt Member		
		public override System.Drawing.Image Icon
		{
			get
			{
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.actionimport.png"));
			}
		}
		#endregion
	}
}
