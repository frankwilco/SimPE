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
	public class WantsUI : IPackedFileUI
	{
		#region Code to Startup the UI

		/// <summary>
		/// Holds a reference to the Form containing the UI Panel
		/// </summary>
		internal WantsForm form;

		/// <summary>
		/// Constructor for the Class
		/// </summary>
		public WantsUI()
		{
			//form = WrapperFactory.form;
			form = new WantsForm();
			
			form.cbtype.Items.Add(WantType.Undefined);			
			form.cbtype.Items.Add(WantType.None);
			form.cbtype.Items.Add(WantType.Sim);
			form.cbtype.Items.Add(WantType.Object);
			form.cbtype.Items.Add(WantType.Category);
			form.cbtype.Items.Add(WantType.Skill);
			form.cbtype.Items.Add(WantType.Career);
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
				return form.wantsPanel;
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
			Want wrp = (Want) wrapper;
			form.wrapper = wrp;
			form.Tag = true;

			try 
			{
				SimPe.Interfaces.Wrapper.ISDesc sdsc = wrp.SimDescription;
				if (sdsc!=null)
					form.lbsimname.Text = sdsc.SimName + " " + sdsc.SimFamilyName;
				else 
					form.lbsimname.Text = Localization.Manager.GetString("Unknown");

				form.ListWants();
				form.lastwi = null;
				form.lastlvi = null;

				WaitingScreen.Wait();			
				form.lvwant.Items.Clear();
				form.iwant.Images.Clear();
				foreach (WantItem wi in wrp.Wants) form.AddWantToList(form.lvwant, form.iwant, wi);

				form.lvfear.Items.Clear();
				form.ifear.Images.Clear();
				foreach (WantItem wi in wrp.Fears) form.AddWantToList(form.lvfear, form.ifear, wi);

				form.lvlife.Items.Clear();
				form.ilife.Images.Clear();
				foreach (WantItem wi in wrp.LifetimeWants) form.AddWantToList(form.lvlife, form.ilife, wi);

				form.tvhist.Nodes.Clear();
				form.ihist.Images.Clear();			
				form.ihist.Images.Add(new System.Drawing.Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.nothumb.png")));
			

				if (wrp.Version >= 0x06) 
				{
					if (!form.tabControl1.TabPages.Contains(form.tblife)) 
					{
						form.tabControl1.TabPages.Add(form.tblife);
						form.tabControl1.SelectedIndex = 3;
					}
				} 
				else 
				{
					if (form.tabControl1.TabPages.Contains(form.tblife)) 
					{
						form.tabControl1.TabPages.Remove(form.tblife);
						form.tabControl1.SelectedIndex = 0;
					}
				}				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				form.Tag = null;
				WaitingScreen.Stop();				
			}
		}		

		#endregion
	}
}
