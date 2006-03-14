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
		private System.Windows.Forms.LinkLabel llmax;
		private System.Windows.Forms.LinkLabel llrew;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblot;
		
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
			this.llmax = new System.Windows.Forms.LinkLabel();
			this.llrew = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblot = new System.Windows.Forms.Label();
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
			this.bnfoCustomerItemUI1.BackColor = System.Drawing.Color.Transparent;
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
			// llmax
			// 
			this.llmax.AccessibleDescription = resources.GetString("llmax.AccessibleDescription");
			this.llmax.AccessibleName = resources.GetString("llmax.AccessibleName");
			this.llmax.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llmax.Anchor")));
			this.llmax.AutoSize = ((bool)(resources.GetObject("llmax.AutoSize")));
			this.llmax.BackColor = System.Drawing.Color.Transparent;
			this.llmax.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llmax.Dock")));
			this.llmax.Enabled = ((bool)(resources.GetObject("llmax.Enabled")));
			this.llmax.Font = ((System.Drawing.Font)(resources.GetObject("llmax.Font")));
			this.llmax.Image = ((System.Drawing.Image)(resources.GetObject("llmax.Image")));
			this.llmax.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmax.ImageAlign")));
			this.llmax.ImageIndex = ((int)(resources.GetObject("llmax.ImageIndex")));
			this.llmax.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llmax.ImeMode")));
			this.llmax.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llmax.LinkArea")));
			this.llmax.Location = ((System.Drawing.Point)(resources.GetObject("llmax.Location")));
			this.llmax.Name = "llmax";
			this.llmax.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llmax.RightToLeft")));
			this.llmax.Size = ((System.Drawing.Size)(resources.GetObject("llmax.Size")));
			this.llmax.TabIndex = ((int)(resources.GetObject("llmax.TabIndex")));
			this.llmax.TabStop = true;
			this.llmax.Text = resources.GetString("llmax.Text");
			this.llmax.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmax.TextAlign")));
			this.llmax.Visible = ((bool)(resources.GetObject("llmax.Visible")));
			this.llmax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llmax_LinkClicked);
			// 
			// llrew
			// 
			this.llrew.AccessibleDescription = resources.GetString("llrew.AccessibleDescription");
			this.llrew.AccessibleName = resources.GetString("llrew.AccessibleName");
			this.llrew.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llrew.Anchor")));
			this.llrew.AutoSize = ((bool)(resources.GetObject("llrew.AutoSize")));
			this.llrew.BackColor = System.Drawing.Color.Transparent;
			this.llrew.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llrew.Dock")));
			this.llrew.Enabled = ((bool)(resources.GetObject("llrew.Enabled")));
			this.llrew.Font = ((System.Drawing.Font)(resources.GetObject("llrew.Font")));
			this.llrew.Image = ((System.Drawing.Image)(resources.GetObject("llrew.Image")));
			this.llrew.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrew.ImageAlign")));
			this.llrew.ImageIndex = ((int)(resources.GetObject("llrew.ImageIndex")));
			this.llrew.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llrew.ImeMode")));
			this.llrew.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llrew.LinkArea")));
			this.llrew.Location = ((System.Drawing.Point)(resources.GetObject("llrew.Location")));
			this.llrew.Name = "llrew";
			this.llrew.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llrew.RightToLeft")));
			this.llrew.Size = ((System.Drawing.Size)(resources.GetObject("llrew.Size")));
			this.llrew.TabIndex = ((int)(resources.GetObject("llrew.TabIndex")));
			this.llrew.TabStop = true;
			this.llrew.Text = resources.GetString("llrew.Text");
			this.llrew.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrew.TextAlign")));
			this.llrew.Visible = ((bool)(resources.GetObject("llrew.Visible")));
			this.llrew.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llrew_LinkClicked);
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// lblot
			// 
			this.lblot.AccessibleDescription = resources.GetString("lblot.AccessibleDescription");
			this.lblot.AccessibleName = resources.GetString("lblot.AccessibleName");
			this.lblot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lblot.Anchor")));
			this.lblot.AutoSize = ((bool)(resources.GetObject("lblot.AutoSize")));
			this.lblot.BackColor = System.Drawing.Color.Transparent;
			this.lblot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lblot.Dock")));
			this.lblot.Enabled = ((bool)(resources.GetObject("lblot.Enabled")));
			this.lblot.Font = ((System.Drawing.Font)(resources.GetObject("lblot.Font")));
			this.lblot.Image = ((System.Drawing.Image)(resources.GetObject("lblot.Image")));
			this.lblot.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lblot.ImageAlign")));
			this.lblot.ImageIndex = ((int)(resources.GetObject("lblot.ImageIndex")));
			this.lblot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lblot.ImeMode")));
			this.lblot.Location = ((System.Drawing.Point)(resources.GetObject("lblot.Location")));
			this.lblot.Name = "lblot";
			this.lblot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lblot.RightToLeft")));
			this.lblot.Size = ((System.Drawing.Size)(resources.GetObject("lblot.Size")));
			this.lblot.TabIndex = ((int)(resources.GetObject("lblot.TabIndex")));
			this.lblot.Text = resources.GetString("lblot.Text");
			this.lblot.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lblot.TextAlign")));
			this.lblot.Visible = ((bool)(resources.GetObject("lblot.Visible")));
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
			this.Controls.Add(this.lblot);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.llrew);
			this.Controls.Add(this.llmax);
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
			this.Controls.SetChildIndex(this.llmax, 0);
			this.Controls.SetChildIndex(this.llrew, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.lblot, 0);
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
				llmax.Enabled = true;
				llrew.Enabled = true;

				SimPe.Interfaces.Providers.ILotItem ili = FileTable.ProviderRegistry.LotProvider.FindLot(Bnfo.FileDescriptor.Instance);
				if (ili!=null)
					this.lblot.Text = ili.Name;
				else
					this.lblot.Text = SimPe.Localization.GetString("Unknown");
			} 
			else 
			{
				lv.Items = null;
				this.lblot.Text = "";
				
				llmax.Enabled = false;
				llrew.Enabled = false;
			}
		}

		public override void OnCommit()
		{
			Bnfo.SynchronizeUserData(true, false);
		}

		private void llmax_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.Items==null) return;
			foreach (BnfoCustomerItem item in lv.Items)			
				item.LoyaltyScore = 1000;
			
			lv.Refresh();
		}

		private void llrew_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Bnfo==null) return;
			Bnfo.CurrentBusinessState = 0;
			Bnfo.MaxSeenBusinessState = 0;
		}

								
	}
}
