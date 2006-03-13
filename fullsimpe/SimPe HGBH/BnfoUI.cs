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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;
using SimPe.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ExtNgbhUI.
	/// </summary>
	public class BnfoUI : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private SimPe.Plugin.BnfoCustomerItemsUI lv;
		private SimPe.Plugin.BnfoCustomerItemUI bnfoCustomerItemUI1;
		
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public BnfoUI()
		{			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();			
		}
		


		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BnfoUI));
			this.lv = new SimPe.Plugin.BnfoCustomerItemsUI();
			this.bnfoCustomerItemUI1 = new SimPe.Plugin.BnfoCustomerItemUI();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.AutoScroll = ((bool)(resources.GetObject("lv.AutoScroll")));
			this.lv.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("lv.AutoScrollMargin")));
			this.lv.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("lv.AutoScrollMinSize")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.Items = null;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			// 
			// bnfoCustomerItemUI1
			// 
			this.bnfoCustomerItemUI1.AccessibleDescription = resources.GetString("bnfoCustomerItemUI1.AccessibleDescription");
			this.bnfoCustomerItemUI1.AccessibleName = resources.GetString("bnfoCustomerItemUI1.AccessibleName");
			this.bnfoCustomerItemUI1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bnfoCustomerItemUI1.Anchor")));
			this.bnfoCustomerItemUI1.AutoScroll = ((bool)(resources.GetObject("bnfoCustomerItemUI1.AutoScroll")));
			this.bnfoCustomerItemUI1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("bnfoCustomerItemUI1.AutoScrollMargin")));
			this.bnfoCustomerItemUI1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("bnfoCustomerItemUI1.AutoScrollMinSize")));
			this.bnfoCustomerItemUI1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bnfoCustomerItemUI1.BackgroundImage")));
			this.bnfoCustomerItemUI1.BnfoCustomerItemsUI = this.lv;
			this.bnfoCustomerItemUI1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bnfoCustomerItemUI1.Dock")));
			this.bnfoCustomerItemUI1.Enabled = ((bool)(resources.GetObject("bnfoCustomerItemUI1.Enabled")));
			this.bnfoCustomerItemUI1.Font = ((System.Drawing.Font)(resources.GetObject("bnfoCustomerItemUI1.Font")));
			this.bnfoCustomerItemUI1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bnfoCustomerItemUI1.ImeMode")));
			this.bnfoCustomerItemUI1.Item = null;
			this.bnfoCustomerItemUI1.Location = ((System.Drawing.Point)(resources.GetObject("bnfoCustomerItemUI1.Location")));
			this.bnfoCustomerItemUI1.Name = "bnfoCustomerItemUI1";
			this.bnfoCustomerItemUI1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bnfoCustomerItemUI1.RightToLeft")));
			this.bnfoCustomerItemUI1.Size = ((System.Drawing.Size)(resources.GetObject("bnfoCustomerItemUI1.Size")));
			this.bnfoCustomerItemUI1.TabIndex = ((int)(resources.GetObject("bnfoCustomerItemUI1.TabIndex")));
			this.bnfoCustomerItemUI1.Visible = ((bool)(resources.GetObject("bnfoCustomerItemUI1.Visible")));
			// 
			// BnfoUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.bnfoCustomerItemUI1);
			this.Controls.Add(this.lv);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "BnfoUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.lv, 0);
			this.Controls.SetChildIndex(this.bnfoCustomerItemUI1, 0);
			this.ResumeLayout(false);

		}
		#endregion

		public Bnfo Bnfo
		{
			get { return (Bnfo)Wrapper; }
		}

		protected override void RefreshGUI()
		{			
			if (Bnfo!=null) 
			{
				lv.Items = Bnfo.CustomerItems;
			} 
			else 
			{
				lv.Items = null;
			}
		}

		public override void OnCommit()
		{
			Bnfo.SynchronizeUserData(true, false);
		}						
	}
}
