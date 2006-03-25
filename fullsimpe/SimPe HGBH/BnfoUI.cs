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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblot;
		private TD.SandBar.ToolBar toolBar1;
		private System.Windows.Forms.Panel panel1;
		private TD.SandBar.ButtonItem biMax;
		private TD.SandBar.ButtonItem biReward;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCur;
		private System.Windows.Forms.TextBox tbMax;
		
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public BnfoUI()
		{			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();	
		
			toolBar1.Renderer = new TD.SandBar.MediaPlayerRenderer();
			toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Chevron;

			ThemeManager.AddControl(this.toolBar1);
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblot = new System.Windows.Forms.Label();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biMax = new TD.SandBar.ButtonItem();
			this.biReward = new TD.SandBar.ButtonItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbMax = new System.Windows.Forms.TextBox();
			this.tbCur = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
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
			// toolBar1
			// 
			this.toolBar1.AccessibleDescription = resources.GetString("toolBar1.AccessibleDescription");
			this.toolBar1.AccessibleName = resources.GetString("toolBar1.AccessibleName");
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar1.Anchor")));
			this.toolBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar1.BackgroundImage")));
			this.toolBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar1.Dock")));
			this.toolBar1.Enabled = ((bool)(resources.GetObject("toolBar1.Enabled")));
			this.toolBar1.Font = ((System.Drawing.Font)(resources.GetObject("toolBar1.Font")));
			this.toolBar1.Guid = new System.Guid("1b9c3745-6103-4a33-9fa3-912463438a13");
			this.toolBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar1.ImeMode")));
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biMax,
																			  this.biReward});
			this.toolBar1.Location = ((System.Drawing.Point)(resources.GetObject("toolBar1.Location")));
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar1.RightToLeft")));
			this.toolBar1.Size = ((System.Drawing.Size)(resources.GetObject("toolBar1.Size")));
			this.toolBar1.TabIndex = ((int)(resources.GetObject("toolBar1.TabIndex")));
			this.toolBar1.Text = resources.GetString("toolBar1.Text");
			this.toolBar1.TextAlign = TD.SandBar.ToolBarTextAlign.Underneath;
			this.toolBar1.Visible = ((bool)(resources.GetObject("toolBar1.Visible")));
			// 
			// biMax
			// 
			this.biMax.Image = ((System.Drawing.Image)(resources.GetObject("biMax.Image")));
			this.biMax.MinimumSize = 50;
			this.biMax.Text = resources.GetString("biMax.Text");
			this.biMax.ToolTipText = resources.GetString("biMax.ToolTipText");
			this.biMax.Activate += new System.EventHandler(this.biMax_Activate);
			// 
			// biReward
			// 
			this.biReward.Image = ((System.Drawing.Image)(resources.GetObject("biReward.Image")));
			this.biReward.Text = resources.GetString("biReward.Text");
			this.biReward.ToolTipText = resources.GetString("biReward.ToolTipText");
			this.biReward.Activate += new System.EventHandler(this.biReward_Activate);
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.tbMax);
			this.panel1.Controls.Add(this.tbCur);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lv);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.bnfoCustomerItemUI1);
			this.panel1.Controls.Add(this.lblot);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// tbMax
			// 
			this.tbMax.AccessibleDescription = resources.GetString("tbMax.AccessibleDescription");
			this.tbMax.AccessibleName = resources.GetString("tbMax.AccessibleName");
			this.tbMax.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbMax.Anchor")));
			this.tbMax.AutoSize = ((bool)(resources.GetObject("tbMax.AutoSize")));
			this.tbMax.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbMax.BackgroundImage")));
			this.tbMax.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbMax.Dock")));
			this.tbMax.Enabled = ((bool)(resources.GetObject("tbMax.Enabled")));
			this.tbMax.Font = ((System.Drawing.Font)(resources.GetObject("tbMax.Font")));
			this.tbMax.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbMax.ImeMode")));
			this.tbMax.Location = ((System.Drawing.Point)(resources.GetObject("tbMax.Location")));
			this.tbMax.MaxLength = ((int)(resources.GetObject("tbMax.MaxLength")));
			this.tbMax.Multiline = ((bool)(resources.GetObject("tbMax.Multiline")));
			this.tbMax.Name = "tbMax";
			this.tbMax.PasswordChar = ((char)(resources.GetObject("tbMax.PasswordChar")));
			this.tbMax.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbMax.RightToLeft")));
			this.tbMax.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbMax.ScrollBars")));
			this.tbMax.Size = ((System.Drawing.Size)(resources.GetObject("tbMax.Size")));
			this.tbMax.TabIndex = ((int)(resources.GetObject("tbMax.TabIndex")));
			this.tbMax.Text = resources.GetString("tbMax.Text");
			this.tbMax.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbMax.TextAlign")));
			this.tbMax.Visible = ((bool)(resources.GetObject("tbMax.Visible")));
			this.tbMax.WordWrap = ((bool)(resources.GetObject("tbMax.WordWrap")));
			this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
			// 
			// tbCur
			// 
			this.tbCur.AccessibleDescription = resources.GetString("tbCur.AccessibleDescription");
			this.tbCur.AccessibleName = resources.GetString("tbCur.AccessibleName");
			this.tbCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbCur.Anchor")));
			this.tbCur.AutoSize = ((bool)(resources.GetObject("tbCur.AutoSize")));
			this.tbCur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbCur.BackgroundImage")));
			this.tbCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbCur.Dock")));
			this.tbCur.Enabled = ((bool)(resources.GetObject("tbCur.Enabled")));
			this.tbCur.Font = ((System.Drawing.Font)(resources.GetObject("tbCur.Font")));
			this.tbCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbCur.ImeMode")));
			this.tbCur.Location = ((System.Drawing.Point)(resources.GetObject("tbCur.Location")));
			this.tbCur.MaxLength = ((int)(resources.GetObject("tbCur.MaxLength")));
			this.tbCur.Multiline = ((bool)(resources.GetObject("tbCur.Multiline")));
			this.tbCur.Name = "tbCur";
			this.tbCur.PasswordChar = ((char)(resources.GetObject("tbCur.PasswordChar")));
			this.tbCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbCur.RightToLeft")));
			this.tbCur.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbCur.ScrollBars")));
			this.tbCur.Size = ((System.Drawing.Size)(resources.GetObject("tbCur.Size")));
			this.tbCur.TabIndex = ((int)(resources.GetObject("tbCur.TabIndex")));
			this.tbCur.Text = resources.GetString("tbCur.Text");
			this.tbCur.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbCur.TextAlign")));
			this.tbCur.Visible = ((bool)(resources.GetObject("tbCur.Visible")));
			this.tbCur.WordWrap = ((bool)(resources.GetObject("tbCur.WordWrap")));
			this.tbCur.TextChanged += new System.EventHandler(this.tbCur_TextChanged);
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// BnfoUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolBar1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "BnfoUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.panel1, 0);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public Bnfo Bnfo
		{
			get { return (Bnfo)Wrapper; }
		}

		bool intern;
		protected override void RefreshGUI()
		{			
			if (intern) return;
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BnfoUI));
			this.HeaderText = resources.GetString("$this.HeaderText");
			intern = true;
			if (Bnfo!=null) 
			{
				lv.Items = Bnfo.CustomerItems;
				biMax.Enabled = true;
				biReward.Enabled = true;

				SimPe.Interfaces.Providers.ILotItem ili = FileTable.ProviderRegistry.LotProvider.FindLot(Bnfo.FileDescriptor.Instance);
				if (ili!=null)
					this.lblot.Text = ili.LotName;
				else
					this.lblot.Text = SimPe.Localization.GetString("Unknown");

				tbCur.Text = Bnfo.CurrentBusinessState.ToString();
				tbMax.Text = Bnfo.MaxSeenBusinessState.ToString();

				this.HeaderText += ": " + lblot.Text;
			} 
			else 
			{
				lv.Items = null;
				this.lblot.Text = "";
				
				biMax.Enabled = false;
				biReward.Enabled = false;				
			}

			tbMax.Enabled = biMax.Enabled;
			tbCur.Enabled = biMax.Enabled;
			intern=false;
		}

		public override void OnCommit()
		{
			Bnfo.SynchronizeUserData(true, false);
		}


		private void biMax_Activate(object sender, System.EventArgs e)
		{
			if (lv.Items==null) return;
			foreach (BnfoCustomerItem item in lv.Items)			
				item.LoyaltyScore = 1000;
						
			lv.Refresh();
		}

		private void biReward_Activate(object sender, System.EventArgs e)
		{
			if (Bnfo==null) return;
			Bnfo.CurrentBusinessState = 0;
			Bnfo.MaxSeenBusinessState = 0;
			RefreshGUI();
		}

		private void tbCur_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (Bnfo==null) return;
			Bnfo.CurrentBusinessState = Helper.StringToUInt32(tbCur.Text, Bnfo.CurrentBusinessState, 10);
		}

		private void tbMax_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (Bnfo==null) return;
			Bnfo.MaxSeenBusinessState = Helper.StringToUInt32(tbMax.Text, Bnfo.MaxSeenBusinessState, 10);
		}

								
	}
}
