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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// This class is used to fill the UI for this FileType with Data
	/// </summary>
	public class TtabUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		private BhavForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public TtabUI()
		{
			form = SimPe.Plugin.WrapperFactory.form;
		}
		#endregion

		#region IPackedFileUI Member

		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Panel GUIHandle
		{
			get
			{
				return form.TtabPanel;
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
			form.wrapper = (IFileWrapperSaveExtension)wrapper;

			Ttab mywrapper = (Ttab) wrapper;

			form.internalchg = true;
			form.llchangettab.Enabled = false;
			form.lllistchange.Enabled = false;

			form.lbttab.Items.Clear();
			foreach (TtabItem i in mywrapper.Items) 
			{
				form.lbttab.Items.Add(i);
			}
			form.internalchg = false;
			if (form.lbttab.Items.Count>0) form.lbttab.SelectedIndex = 0;

			form.internalchg = true;
			form.tbver.Text = "0x"+Helper.HexString(mywrapper.Format);
			form.lbttabfile.Text = mywrapper.FileName;
			form.internalchg = false;
		}		

		#endregion
	}
}
