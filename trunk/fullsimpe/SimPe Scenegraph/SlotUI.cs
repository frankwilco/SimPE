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
	/// UI Handler for a Str Wrapper
	/// </summary>
	public class SlotUI : IPackedFileUI	
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		static SlotForm form;
		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public SlotUI()
		{
			if (form==null) form = new SlotForm();

			SlotItemType[] vals = (SlotItemType[])System.Enum.GetValues(typeof(SlotItemType));
			foreach (SlotItemType v in vals) 
			{
				form.cbtype.Items.Add(v);
			}
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
				return form.pnslot;
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
			Slot wrp = (Slot) wrapper;
			form.wrapper = wrp;
			form.Tag = true;

			try 
			{
				form.tbver.Text = "0x"+Helper.HexString(wrp.Version);
				form.tbname.Text = wrp.FileName;

				form.lv.BeginUpdate();
				form.lv.Items.Clear();
				form.lv.Columns.Clear();

				System.Windows.Forms.ColumnHeader c = new System.Windows.Forms.ColumnHeader();
				c.Text = "Type"; c.Width=100; form.lv.Columns.Add(c);

				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "F1"; c.Width=40; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "F2"; c.Width=40; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "F3"; c.Width=40; form.lv.Columns.Add(c);

				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "I1"; c.Width=30; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "I2"; c.Width=30; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "I3"; c.Width=30; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "I4"; c.Width=30; form.lv.Columns.Add(c);
				c = new System.Windows.Forms.ColumnHeader();
				c.Text = "I5"; c.Width=30; form.lv.Columns.Add(c);

				if (wrp.Version>=5) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "F4"; c.Width=40; form.lv.Columns.Add(c);
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "F5"; c.Width=40; form.lv.Columns.Add(c);
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "F6"; c.Width=40; form.lv.Columns.Add(c);

					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "I6"; c.Width=30; form.lv.Columns.Add(c);
				}

				if (wrp.Version>=6) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "S1"; c.Width=30; form.lv.Columns.Add(c);
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "S2"; c.Width=30; form.lv.Columns.Add(c);
				}

				if (wrp.Version>=7) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "F7"; c.Width=40; form.lv.Columns.Add(c);
				}
				if (wrp.Version>=8) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "I7"; c.Width=30; form.lv.Columns.Add(c);
				}
				if (wrp.Version>=9) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "I8"; c.Width=30; form.lv.Columns.Add(c);
				}
				if (wrp.Version>=0x10) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "F8"; c.Width=40; form.lv.Columns.Add(c);
				}

				if (wrp.Version>=0x40) 
				{
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "I9"; c.Width=30; form.lv.Columns.Add(c);
					c = new System.Windows.Forms.ColumnHeader();
					c.Text = "I10"; c.Width=30; form.lv.Columns.Add(c);
				}

				foreach (SlotItem i in wrp.Items) form.ShowItem(i);
				form.lv.EndUpdate();
			} 
			finally 
			{
				form.Tag = null;
			}
		}		

		#endregion
	}
}
