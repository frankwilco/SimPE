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

namespace SimPe.Plugin.Tool.Action
{
	/*public class TestListener  : SimPe.Interfaces.IListener, SimPe.Interfaces.ITool
	{
		#region IListener Member

		public void SelectionChangedHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			Message.Show("Notified new Interface");
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Test Listener";
		}

		#endregion

		#region ITool Member

		public bool IsEnabled(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package)
		{
			System.Windows.Forms.MessageBox.Show("Notified old Interface");
			return false;
		}

		public SimPe.Interfaces.Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package)
		{
			
			return null;
		}

		#endregion
	}*/

	/// <summary>
	/// The UniqueInstance Action
	/// </summary>
	public class ActionUniqueInstance : SimPe.Interfaces.IToolAction
	{
		
		#region IToolAction Member

        public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
        {
            return true;
        }

        private bool RealChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
        {
            return es.HasFileDescriptor;
        }

		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
            if (!RealChangeEnabledStateEventHandler(null, e))
            {
                System.Windows.Forms.MessageBox.Show(Localization.GetString("This is not an appropriate context in which to use this tool"),
                    Localization.GetString(this.ToString()));
                return;
            }
					
			SimPe.Collections.PackedFileDescriptors pfds = e.GetDescriptors();
			bool first = true;
			uint inst = 0x8000;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				if (first) 
				{
					first =false;
					inst = pfd.Instance;
				} 
				else 
				{
					pfd.Instance = inst;
				}

				inst ++;
			}
		}

		#endregion		

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Unique Instances";
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
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.agent.png"));
			}
		}

		public virtual bool Visible 
		{
			get {return true;}
		}

		#endregion
	}
}
