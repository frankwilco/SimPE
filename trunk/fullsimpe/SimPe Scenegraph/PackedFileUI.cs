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
using SimPe.Interfaces.Plugin;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class RefFileUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		internal RefFileForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public RefFileUI()
		{
			//form = WrapperFactory.form;
			form = new RefFileForm();

			foreach (Interfaces.IAlias alias in SimPe.Helper.TGILoader.FileTypes) form.cbtypes.Items.Add(alias);
		}
		#endregion

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get
			{
				return form.wrapperPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <param name="wrapper">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrapper)
		{
			FileTable.FileIndex.Load();
			form.wrapper = (IFileWrapperSaveExtension)wrapper;

			RefFile mywrapper = (RefFile) wrapper;

			form.llcommit.Enabled = false;
			form.lldelete.Enabled = false;
			form.btup.Enabled = false;
			form.btdown.Enabled = false;
			form.miRem.Enabled = false;
			form.lblist.Items.Clear();
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mywrapper.Items) 
			{
				form.lblist.Items.Add(pfd);
			}
		}		

		#endregion
		
		#region IDisposable Member
		public virtual void Dispose()
		{
			this.form.Dispose();
		}
		#endregion
	}
}
