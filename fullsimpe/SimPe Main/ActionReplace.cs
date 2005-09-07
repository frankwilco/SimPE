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
	public class ReplaceAction : AbstractActionDefault
	{

		public ReplaceAction()
		{
			
		}

		/// <summary>
		/// Load a list of FIleDescriptors from the disc
		/// </summary>
		/// <param name="add">true if you want to add them lateron</param>
		/// <returns></returns>
		protected SimPe.Collections.PackedFileDescriptors LoadDescriptors(bool add) 
		{
			System.Windows.Forms.OpenFileDialog ofd = new System.Windows.Forms.OpenFileDialog();
			if (!add) 
			{
				ofd.Filter =  ExtensionProvider.BuildFilterString(
					new SimPe.ExtensionType[] {
												  SimPe.ExtensionType.ExtractedFile,
												  SimPe.ExtensionType.ExtractedFileDescriptor,
												  SimPe.ExtensionType.AllFiles
											  }
					);
			} 
			else 
			{
				ofd.Filter =  ExtensionProvider.BuildFilterString(
					new SimPe.ExtensionType[] {
												  SimPe.ExtensionType.ExtractedFileDescriptor,
												  SimPe.ExtensionType.ExtrackedPackageDescriptor,
												  SimPe.ExtensionType.ExtractedFile,
												  SimPe.ExtensionType.Package,
												  SimPe.ExtensionType.DisabledPackage,
												  SimPe.ExtensionType.AllFiles
											  }
					);
			}

			ofd.Title = SimPe.Localization.GetString(this.ToString());
			ofd.Multiselect = add;
			if (ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK) 
			{
				SimPe.Collections.PackedFileDescriptors pfds = LoadedPackage.LoadDescriptorsFromDisk(ofd.FileNames);
				return pfds;
			}

			return new SimPe.Collections.PackedFileDescriptors();
		}
		#region IToolAction Member		

		public override bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			bool res = base.ChangeEnabledStateEventHandler (sender, es);
			return (res && es.Count==1);											
		}		

		public override void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (!ChangeEnabledStateEventHandler(null, es)) return;

			SimPe.Collections.PackedFileDescriptors pfds = this.LoadDescriptors(false);
			if (es.Count>0) 
			{
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 		
					if (pfd!=null)
						if (es[0].Resource!=null)
							if (es[0].Resource.FileDescriptor!=null)
								es[0].Resource.FileDescriptor.UserData = pfd.UserData;						
			}
		}

		#endregion

		#region IToolPlugin Member

		public override string ToString()
		{
			return "Replace...";
		}

		#endregion

		#region IToolExt Member		
		public override System.Drawing.Image Icon
		{
			get
			{
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.actionreplace.png"));
			}
		}		
		#endregion
	}
}
