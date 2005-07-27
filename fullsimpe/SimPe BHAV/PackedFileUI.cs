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
	public class BhavUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		internal BhavForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public BhavUI()
		{
			//form = WrapperFactory.form;
			form = new BhavForm();
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
			form.wrapper = (IFileWrapperSaveExtension)wrapper;

			Bhav mywrapper = (Bhav) wrapper;

			form.SetReadOnly(true);
			form.internalchg = true;
			form.csel = -1;
			form.pnflowcontainer.AutoScrollPosition = new System.Drawing.Point(0, 0);
			form.llcommit.Enabled = false;
			form.lldel.Enabled = false;
			form.llopenbhav.Enabled = false;
			form.CreateFlowPanel(mywrapper.Instructions);
			form.btwiz.Enabled = false;
			

			//form.tbopcode.Text = "0x0000";
			form.tbargc.Text = mywrapper.Header.ArgumentCount.ToString();
			form.tbflags.Text = "0x"+Helper.HexString(mywrapper.Header.Flags);
			form.tbformat.Text = "0x"+Helper.HexString(mywrapper.Header.Format);
			form.tblocals.Text = mywrapper.Header.LocalVarCount.ToString();
			form.tbtype.Text = "0x"+Helper.HexString(mywrapper.Header.Type);
			form.tbzero.Text = "0x"+Helper.HexString(mywrapper.Header.Zero);

			form.lbbhav.Text = mywrapper.FileName;
			form.internalchg = false;
		}		

		#endregion
	}
}
