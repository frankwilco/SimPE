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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Wrapper;
using SimPe.Data;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für Elements2.
	/// </summary>
	public class Elements2 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Elements2()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			ThemeManager tm = FileTable.ThemeManager.CreateChild();
			tm.AddControl(this.NrefPanel);
			tm.AddControl(this.CpfPanel);
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Elements2));
			this.btprev = new System.Windows.Forms.Button();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.rtbcpfname = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rtbcpf = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btcpfcommit = new System.Windows.Forms.Button();
			this.lbcpf = new System.Windows.Forms.ListBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.tbNref = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbnrefhash = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.NrefPanel = new SteepValley.Windows.Forms.XPGradientPanel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.CpfPanel = new SteepValley.Windows.Forms.XPGradientPanel();
			this.llcpfadd = new System.Windows.Forms.LinkLabel();
			this.llcpfchange = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.panel5.SuspendLayout();
			this.NrefPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.CpfPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btprev
			// 
			this.btprev.AccessibleDescription = resources.GetString("btprev.AccessibleDescription");
			this.btprev.AccessibleName = resources.GetString("btprev.AccessibleName");
			this.btprev.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btprev.Anchor")));
			this.btprev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btprev.BackgroundImage")));
			this.btprev.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btprev.Dock")));
			this.btprev.Enabled = ((bool)(resources.GetObject("btprev.Enabled")));
			this.btprev.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btprev.FlatStyle")));
			this.btprev.Font = ((System.Drawing.Font)(resources.GetObject("btprev.Font")));
			this.btprev.Image = ((System.Drawing.Image)(resources.GetObject("btprev.Image")));
			this.btprev.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btprev.ImageAlign")));
			this.btprev.ImageIndex = ((int)(resources.GetObject("btprev.ImageIndex")));
			this.btprev.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btprev.ImeMode")));
			this.btprev.Location = ((System.Drawing.Point)(resources.GetObject("btprev.Location")));
			this.btprev.Name = "btprev";
			this.btprev.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btprev.RightToLeft")));
			this.btprev.Size = ((System.Drawing.Size)(resources.GetObject("btprev.Size")));
			this.btprev.TabIndex = ((int)(resources.GetObject("btprev.TabIndex")));
			this.btprev.Text = resources.GetString("btprev.Text");
			this.btprev.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btprev.TextAlign")));
			this.btprev.Visible = ((bool)(resources.GetObject("btprev.Visible")));
			this.btprev.Click += new System.EventHandler(this.btprev_Click);
			// 
			// cbtype
			// 
			this.cbtype.AccessibleDescription = resources.GetString("cbtype.AccessibleDescription");
			this.cbtype.AccessibleName = resources.GetString("cbtype.AccessibleName");
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtype.Anchor")));
			this.cbtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtype.BackgroundImage")));
			this.cbtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtype.Dock")));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = ((bool)(resources.GetObject("cbtype.Enabled")));
			this.cbtype.Font = ((System.Drawing.Font)(resources.GetObject("cbtype.Font")));
			this.cbtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtype.ImeMode")));
			this.cbtype.IntegralHeight = ((bool)(resources.GetObject("cbtype.IntegralHeight")));
			this.cbtype.ItemHeight = ((int)(resources.GetObject("cbtype.ItemHeight")));
			this.cbtype.Location = ((System.Drawing.Point)(resources.GetObject("cbtype.Location")));
			this.cbtype.MaxDropDownItems = ((int)(resources.GetObject("cbtype.MaxDropDownItems")));
			this.cbtype.MaxLength = ((int)(resources.GetObject("cbtype.MaxLength")));
			this.cbtype.Name = "cbtype";
			this.cbtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtype.RightToLeft")));
			this.cbtype.Size = ((System.Drawing.Size)(resources.GetObject("cbtype.Size")));
			this.cbtype.TabIndex = ((int)(resources.GetObject("cbtype.TabIndex")));
			this.cbtype.Text = resources.GetString("cbtype.Text");
			this.cbtype.Visible = ((bool)(resources.GetObject("cbtype.Visible")));
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.CpfAutoChange);
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Enabled = ((bool)(resources.GetObject("label8.Enabled")));
			this.label8.Font = ((System.Drawing.Font)(resources.GetObject("label8.Font")));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			// 
			// rtbcpfname
			// 
			this.rtbcpfname.AccessibleDescription = resources.GetString("rtbcpfname.AccessibleDescription");
			this.rtbcpfname.AccessibleName = resources.GetString("rtbcpfname.AccessibleName");
			this.rtbcpfname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtbcpfname.Anchor")));
			this.rtbcpfname.AutoSize = ((bool)(resources.GetObject("rtbcpfname.AutoSize")));
			this.rtbcpfname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtbcpfname.BackgroundImage")));
			this.rtbcpfname.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbcpfname.BulletIndent = ((int)(resources.GetObject("rtbcpfname.BulletIndent")));
			this.rtbcpfname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtbcpfname.Dock")));
			this.rtbcpfname.Enabled = ((bool)(resources.GetObject("rtbcpfname.Enabled")));
			this.rtbcpfname.Font = ((System.Drawing.Font)(resources.GetObject("rtbcpfname.Font")));
			this.rtbcpfname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtbcpfname.ImeMode")));
			this.rtbcpfname.Location = ((System.Drawing.Point)(resources.GetObject("rtbcpfname.Location")));
			this.rtbcpfname.MaxLength = ((int)(resources.GetObject("rtbcpfname.MaxLength")));
			this.rtbcpfname.Multiline = ((bool)(resources.GetObject("rtbcpfname.Multiline")));
			this.rtbcpfname.Name = "rtbcpfname";
			this.rtbcpfname.RightMargin = ((int)(resources.GetObject("rtbcpfname.RightMargin")));
			this.rtbcpfname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtbcpfname.RightToLeft")));
			this.rtbcpfname.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtbcpfname.ScrollBars")));
			this.rtbcpfname.Size = ((System.Drawing.Size)(resources.GetObject("rtbcpfname.Size")));
			this.rtbcpfname.TabIndex = ((int)(resources.GetObject("rtbcpfname.TabIndex")));
			this.rtbcpfname.Text = resources.GetString("rtbcpfname.Text");
			this.rtbcpfname.Visible = ((bool)(resources.GetObject("rtbcpfname.Visible")));
			this.rtbcpfname.WordWrap = ((bool)(resources.GetObject("rtbcpfname.WordWrap")));
			this.rtbcpfname.ZoomFactor = ((System.Single)(resources.GetObject("rtbcpfname.ZoomFactor")));
			this.rtbcpfname.TextChanged += new System.EventHandler(this.CpfAutoChange);
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
			// 
			// rtbcpf
			// 
			this.rtbcpf.AccessibleDescription = resources.GetString("rtbcpf.AccessibleDescription");
			this.rtbcpf.AccessibleName = resources.GetString("rtbcpf.AccessibleName");
			this.rtbcpf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtbcpf.Anchor")));
			this.rtbcpf.AutoSize = ((bool)(resources.GetObject("rtbcpf.AutoSize")));
			this.rtbcpf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtbcpf.BackgroundImage")));
			this.rtbcpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbcpf.BulletIndent = ((int)(resources.GetObject("rtbcpf.BulletIndent")));
			this.rtbcpf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtbcpf.Dock")));
			this.rtbcpf.Enabled = ((bool)(resources.GetObject("rtbcpf.Enabled")));
			this.rtbcpf.Font = ((System.Drawing.Font)(resources.GetObject("rtbcpf.Font")));
			this.rtbcpf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtbcpf.ImeMode")));
			this.rtbcpf.Location = ((System.Drawing.Point)(resources.GetObject("rtbcpf.Location")));
			this.rtbcpf.MaxLength = ((int)(resources.GetObject("rtbcpf.MaxLength")));
			this.rtbcpf.Multiline = ((bool)(resources.GetObject("rtbcpf.Multiline")));
			this.rtbcpf.Name = "rtbcpf";
			this.rtbcpf.RightMargin = ((int)(resources.GetObject("rtbcpf.RightMargin")));
			this.rtbcpf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtbcpf.RightToLeft")));
			this.rtbcpf.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtbcpf.ScrollBars")));
			this.rtbcpf.Size = ((System.Drawing.Size)(resources.GetObject("rtbcpf.Size")));
			this.rtbcpf.TabIndex = ((int)(resources.GetObject("rtbcpf.TabIndex")));
			this.rtbcpf.Text = resources.GetString("rtbcpf.Text");
			this.rtbcpf.Visible = ((bool)(resources.GetObject("rtbcpf.Visible")));
			this.rtbcpf.WordWrap = ((bool)(resources.GetObject("rtbcpf.WordWrap")));
			this.rtbcpf.ZoomFactor = ((System.Single)(resources.GetObject("rtbcpf.ZoomFactor")));
			this.rtbcpf.TextChanged += new System.EventHandler(this.CpfAutoChange);
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Enabled = ((bool)(resources.GetObject("label6.Enabled")));
			this.label6.Font = ((System.Drawing.Font)(resources.GetObject("label6.Font")));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			// 
			// btcpfcommit
			// 
			this.btcpfcommit.AccessibleDescription = resources.GetString("btcpfcommit.AccessibleDescription");
			this.btcpfcommit.AccessibleName = resources.GetString("btcpfcommit.AccessibleName");
			this.btcpfcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btcpfcommit.Anchor")));
			this.btcpfcommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcpfcommit.BackgroundImage")));
			this.btcpfcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btcpfcommit.Dock")));
			this.btcpfcommit.Enabled = ((bool)(resources.GetObject("btcpfcommit.Enabled")));
			this.btcpfcommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btcpfcommit.FlatStyle")));
			this.btcpfcommit.Font = ((System.Drawing.Font)(resources.GetObject("btcpfcommit.Font")));
			this.btcpfcommit.Image = ((System.Drawing.Image)(resources.GetObject("btcpfcommit.Image")));
			this.btcpfcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcpfcommit.ImageAlign")));
			this.btcpfcommit.ImageIndex = ((int)(resources.GetObject("btcpfcommit.ImageIndex")));
			this.btcpfcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btcpfcommit.ImeMode")));
			this.btcpfcommit.Location = ((System.Drawing.Point)(resources.GetObject("btcpfcommit.Location")));
			this.btcpfcommit.Name = "btcpfcommit";
			this.btcpfcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btcpfcommit.RightToLeft")));
			this.btcpfcommit.Size = ((System.Drawing.Size)(resources.GetObject("btcpfcommit.Size")));
			this.btcpfcommit.TabIndex = ((int)(resources.GetObject("btcpfcommit.TabIndex")));
			this.btcpfcommit.Text = resources.GetString("btcpfcommit.Text");
			this.btcpfcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcpfcommit.TextAlign")));
			this.btcpfcommit.Visible = ((bool)(resources.GetObject("btcpfcommit.Visible")));
			this.btcpfcommit.Click += new System.EventHandler(this.CpfCommit);
			// 
			// lbcpf
			// 
			this.lbcpf.AccessibleDescription = resources.GetString("lbcpf.AccessibleDescription");
			this.lbcpf.AccessibleName = resources.GetString("lbcpf.AccessibleName");
			this.lbcpf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbcpf.Anchor")));
			this.lbcpf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbcpf.BackgroundImage")));
			this.lbcpf.ColumnWidth = ((int)(resources.GetObject("lbcpf.ColumnWidth")));
			this.lbcpf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbcpf.Dock")));
			this.lbcpf.Enabled = ((bool)(resources.GetObject("lbcpf.Enabled")));
			this.lbcpf.Font = ((System.Drawing.Font)(resources.GetObject("lbcpf.Font")));
			this.lbcpf.HorizontalExtent = ((int)(resources.GetObject("lbcpf.HorizontalExtent")));
			this.lbcpf.HorizontalScrollbar = ((bool)(resources.GetObject("lbcpf.HorizontalScrollbar")));
			this.lbcpf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbcpf.ImeMode")));
			this.lbcpf.IntegralHeight = ((bool)(resources.GetObject("lbcpf.IntegralHeight")));
			this.lbcpf.ItemHeight = ((int)(resources.GetObject("lbcpf.ItemHeight")));
			this.lbcpf.Location = ((System.Drawing.Point)(resources.GetObject("lbcpf.Location")));
			this.lbcpf.Name = "lbcpf";
			this.lbcpf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbcpf.RightToLeft")));
			this.lbcpf.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbcpf.ScrollAlwaysVisible")));
			this.lbcpf.Size = ((System.Drawing.Size)(resources.GetObject("lbcpf.Size")));
			this.lbcpf.TabIndex = ((int)(resources.GetObject("lbcpf.TabIndex")));
			this.lbcpf.Visible = ((bool)(resources.GetObject("lbcpf.Visible")));
			this.lbcpf.SelectedIndexChanged += new System.EventHandler(this.CpfItemSelect);
			// 
			// panel5
			// 
			this.panel5.AccessibleDescription = resources.GetString("panel5.AccessibleDescription");
			this.panel5.AccessibleName = resources.GetString("panel5.AccessibleName");
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel5.Anchor")));
			this.panel5.AutoScroll = ((bool)(resources.GetObject("panel5.AutoScroll")));
			this.panel5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMargin")));
			this.panel5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMinSize")));
			this.panel5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(120)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Controls.Add(this.label5);
			this.panel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel5.Dock")));
			this.panel5.Enabled = ((bool)(resources.GetObject("panel5.Enabled")));
			this.panel5.Font = ((System.Drawing.Font)(resources.GetObject("panel5.Font")));
			this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel5.ImeMode")));
			this.panel5.Location = ((System.Drawing.Point)(resources.GetObject("panel5.Location")));
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel5.RightToLeft")));
			this.panel5.Size = ((System.Drawing.Size)(resources.GetObject("panel5.Size")));
			this.panel5.TabIndex = ((int)(resources.GetObject("panel5.TabIndex")));
			this.panel5.Text = resources.GetString("panel5.Text");
			this.panel5.Visible = ((bool)(resources.GetObject("panel5.Visible")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// tbNref
			// 
			this.tbNref.AccessibleDescription = resources.GetString("tbNref.AccessibleDescription");
			this.tbNref.AccessibleName = resources.GetString("tbNref.AccessibleName");
			this.tbNref.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbNref.Anchor")));
			this.tbNref.AutoSize = ((bool)(resources.GetObject("tbNref.AutoSize")));
			this.tbNref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbNref.BackgroundImage")));
			this.tbNref.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbNref.Dock")));
			this.tbNref.Enabled = ((bool)(resources.GetObject("tbNref.Enabled")));
			this.tbNref.Font = ((System.Drawing.Font)(resources.GetObject("tbNref.Font")));
			this.tbNref.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbNref.ImeMode")));
			this.tbNref.Location = ((System.Drawing.Point)(resources.GetObject("tbNref.Location")));
			this.tbNref.MaxLength = ((int)(resources.GetObject("tbNref.MaxLength")));
			this.tbNref.Multiline = ((bool)(resources.GetObject("tbNref.Multiline")));
			this.tbNref.Name = "tbNref";
			this.tbNref.PasswordChar = ((char)(resources.GetObject("tbNref.PasswordChar")));
			this.tbNref.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbNref.RightToLeft")));
			this.tbNref.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbNref.ScrollBars")));
			this.tbNref.Size = ((System.Drawing.Size)(resources.GetObject("tbNref.Size")));
			this.tbNref.TabIndex = ((int)(resources.GetObject("tbNref.TabIndex")));
			this.tbNref.Text = resources.GetString("tbNref.Text");
			this.tbNref.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbNref.TextAlign")));
			this.tbNref.Visible = ((bool)(resources.GetObject("tbNref.Visible")));
			this.tbNref.WordWrap = ((bool)(resources.GetObject("tbNref.WordWrap")));
			this.tbNref.TextChanged += new System.EventHandler(this.tbnref_TextChanged);
			// 
			// label10
			// 
			this.label10.AccessibleDescription = resources.GetString("label10.AccessibleDescription");
			this.label10.AccessibleName = resources.GetString("label10.AccessibleName");
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label10.Anchor")));
			this.label10.AutoSize = ((bool)(resources.GetObject("label10.AutoSize")));
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label10.Dock")));
			this.label10.Enabled = ((bool)(resources.GetObject("label10.Enabled")));
			this.label10.Font = ((System.Drawing.Font)(resources.GetObject("label10.Font")));
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.ImageAlign")));
			this.label10.ImageIndex = ((int)(resources.GetObject("label10.ImageIndex")));
			this.label10.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label10.ImeMode")));
			this.label10.Location = ((System.Drawing.Point)(resources.GetObject("label10.Location")));
			this.label10.Name = "label10";
			this.label10.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label10.RightToLeft")));
			this.label10.Size = ((System.Drawing.Size)(resources.GetObject("label10.Size")));
			this.label10.TabIndex = ((int)(resources.GetObject("label10.TabIndex")));
			this.label10.Text = resources.GetString("label10.Text");
			this.label10.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.TextAlign")));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			// 
			// tbnrefhash
			// 
			this.tbnrefhash.AccessibleDescription = resources.GetString("tbnrefhash.AccessibleDescription");
			this.tbnrefhash.AccessibleName = resources.GetString("tbnrefhash.AccessibleName");
			this.tbnrefhash.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbnrefhash.Anchor")));
			this.tbnrefhash.AutoSize = ((bool)(resources.GetObject("tbnrefhash.AutoSize")));
			this.tbnrefhash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbnrefhash.BackgroundImage")));
			this.tbnrefhash.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbnrefhash.Dock")));
			this.tbnrefhash.Enabled = ((bool)(resources.GetObject("tbnrefhash.Enabled")));
			this.tbnrefhash.Font = ((System.Drawing.Font)(resources.GetObject("tbnrefhash.Font")));
			this.tbnrefhash.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbnrefhash.ImeMode")));
			this.tbnrefhash.Location = ((System.Drawing.Point)(resources.GetObject("tbnrefhash.Location")));
			this.tbnrefhash.MaxLength = ((int)(resources.GetObject("tbnrefhash.MaxLength")));
			this.tbnrefhash.Multiline = ((bool)(resources.GetObject("tbnrefhash.Multiline")));
			this.tbnrefhash.Name = "tbnrefhash";
			this.tbnrefhash.PasswordChar = ((char)(resources.GetObject("tbnrefhash.PasswordChar")));
			this.tbnrefhash.ReadOnly = true;
			this.tbnrefhash.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbnrefhash.RightToLeft")));
			this.tbnrefhash.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbnrefhash.ScrollBars")));
			this.tbnrefhash.Size = ((System.Drawing.Size)(resources.GetObject("tbnrefhash.Size")));
			this.tbnrefhash.TabIndex = ((int)(resources.GetObject("tbnrefhash.TabIndex")));
			this.tbnrefhash.Text = resources.GetString("tbnrefhash.Text");
			this.tbnrefhash.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbnrefhash.TextAlign")));
			this.tbnrefhash.Visible = ((bool)(resources.GetObject("tbnrefhash.Visible")));
			this.tbnrefhash.WordWrap = ((bool)(resources.GetObject("tbnrefhash.WordWrap")));
			// 
			// label9
			// 
			this.label9.AccessibleDescription = resources.GetString("label9.AccessibleDescription");
			this.label9.AccessibleName = resources.GetString("label9.AccessibleName");
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label9.Dock")));
			this.label9.Enabled = ((bool)(resources.GetObject("label9.Enabled")));
			this.label9.Font = ((System.Drawing.Font)(resources.GetObject("label9.Font")));
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.ImageAlign")));
			this.label9.ImageIndex = ((int)(resources.GetObject("label9.ImageIndex")));
			this.label9.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label9.ImeMode")));
			this.label9.Location = ((System.Drawing.Point)(resources.GetObject("label9.Location")));
			this.label9.Name = "label9";
			this.label9.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label9.RightToLeft")));
			this.label9.Size = ((System.Drawing.Size)(resources.GetObject("label9.Size")));
			this.label9.TabIndex = ((int)(resources.GetObject("label9.TabIndex")));
			this.label9.Text = resources.GetString("label9.Text");
			this.label9.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.TextAlign")));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
			// 
			// button2
			// 
			this.button2.AccessibleDescription = resources.GetString("button2.AccessibleDescription");
			this.button2.AccessibleName = resources.GetString("button2.AccessibleName");
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button2.Anchor")));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button2.Dock")));
			this.button2.Enabled = ((bool)(resources.GetObject("button2.Enabled")));
			this.button2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button2.FlatStyle")));
			this.button2.Font = ((System.Drawing.Font)(resources.GetObject("button2.Font")));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.ImageAlign")));
			this.button2.ImageIndex = ((int)(resources.GetObject("button2.ImageIndex")));
			this.button2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button2.ImeMode")));
			this.button2.Location = ((System.Drawing.Point)(resources.GetObject("button2.Location")));
			this.button2.Name = "button2";
			this.button2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button2.RightToLeft")));
			this.button2.Size = ((System.Drawing.Size)(resources.GetObject("button2.Size")));
			this.button2.TabIndex = ((int)(resources.GetObject("button2.TabIndex")));
			this.button2.Text = resources.GetString("button2.Text");
			this.button2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.TextAlign")));
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.NrefCommit);
			// 
			// NrefPanel
			// 
			this.NrefPanel.AccessibleDescription = resources.GetString("NrefPanel.AccessibleDescription");
			this.NrefPanel.AccessibleName = resources.GetString("NrefPanel.AccessibleName");
			this.NrefPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("NrefPanel.Anchor")));
			this.NrefPanel.AutoScroll = ((bool)(resources.GetObject("NrefPanel.AutoScroll")));
			this.NrefPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("NrefPanel.AutoScrollMargin")));
			this.NrefPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("NrefPanel.AutoScrollMinSize")));
			this.NrefPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NrefPanel.BackgroundImage")));
			this.NrefPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.NrefPanel.Controls.Add(this.panel4);
			this.NrefPanel.Controls.Add(this.tbnrefhash);
			this.NrefPanel.Controls.Add(this.button2);
			this.NrefPanel.Controls.Add(this.tbNref);
			this.NrefPanel.Controls.Add(this.label9);
			this.NrefPanel.Controls.Add(this.label10);
			this.NrefPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("NrefPanel.Dock")));
			this.NrefPanel.Enabled = ((bool)(resources.GetObject("NrefPanel.Enabled")));
			this.NrefPanel.Font = ((System.Drawing.Font)(resources.GetObject("NrefPanel.Font")));
			this.NrefPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("NrefPanel.ImeMode")));
			this.NrefPanel.Location = ((System.Drawing.Point)(resources.GetObject("NrefPanel.Location")));
			this.NrefPanel.Name = "NrefPanel";
			this.NrefPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("NrefPanel.RightToLeft")));
			this.NrefPanel.Size = ((System.Drawing.Size)(resources.GetObject("NrefPanel.Size")));
			this.NrefPanel.TabIndex = ((int)(resources.GetObject("NrefPanel.TabIndex")));
			this.NrefPanel.Text = resources.GetString("NrefPanel.Text");
			this.NrefPanel.Visible = ((bool)(resources.GetObject("NrefPanel.Visible")));
			this.NrefPanel.Watermark = ((System.Drawing.Image)(resources.GetObject("NrefPanel.Watermark")));
			this.NrefPanel.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("NrefPanel.WatermarkSize")));
			// 
			// panel4
			// 
			this.panel4.AccessibleDescription = resources.GetString("panel4.AccessibleDescription");
			this.panel4.AccessibleName = resources.GetString("panel4.AccessibleName");
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel4.Anchor")));
			this.panel4.AutoScroll = ((bool)(resources.GetObject("panel4.AutoScroll")));
			this.panel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMargin")));
			this.panel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMinSize")));
			this.panel4.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(120)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Controls.Add(this.label12);
			this.panel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel4.Dock")));
			this.panel4.Enabled = ((bool)(resources.GetObject("panel4.Enabled")));
			this.panel4.Font = ((System.Drawing.Font)(resources.GetObject("panel4.Font")));
			this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel4.ImeMode")));
			this.panel4.Location = ((System.Drawing.Point)(resources.GetObject("panel4.Location")));
			this.panel4.Name = "panel4";
			this.panel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel4.RightToLeft")));
			this.panel4.Size = ((System.Drawing.Size)(resources.GetObject("panel4.Size")));
			this.panel4.TabIndex = ((int)(resources.GetObject("panel4.TabIndex")));
			this.panel4.Text = resources.GetString("panel4.Text");
			this.panel4.Visible = ((bool)(resources.GetObject("panel4.Visible")));
			// 
			// label12
			// 
			this.label12.AccessibleDescription = resources.GetString("label12.AccessibleDescription");
			this.label12.AccessibleName = resources.GetString("label12.AccessibleName");
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label12.Anchor")));
			this.label12.AutoSize = ((bool)(resources.GetObject("label12.AutoSize")));
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label12.Dock")));
			this.label12.Enabled = ((bool)(resources.GetObject("label12.Enabled")));
			this.label12.Font = ((System.Drawing.Font)(resources.GetObject("label12.Font")));
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.ImageAlign")));
			this.label12.ImageIndex = ((int)(resources.GetObject("label12.ImageIndex")));
			this.label12.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label12.ImeMode")));
			this.label12.Location = ((System.Drawing.Point)(resources.GetObject("label12.Location")));
			this.label12.Name = "label12";
			this.label12.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label12.RightToLeft")));
			this.label12.Size = ((System.Drawing.Size)(resources.GetObject("label12.Size")));
			this.label12.TabIndex = ((int)(resources.GetObject("label12.TabIndex")));
			this.label12.Text = resources.GetString("label12.Text");
			this.label12.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.TextAlign")));
			this.label12.Visible = ((bool)(resources.GetObject("label12.Visible")));
			// 
			// CpfPanel
			// 
			this.CpfPanel.AccessibleDescription = resources.GetString("CpfPanel.AccessibleDescription");
			this.CpfPanel.AccessibleName = resources.GetString("CpfPanel.AccessibleName");
			this.CpfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("CpfPanel.Anchor")));
			this.CpfPanel.AutoScroll = ((bool)(resources.GetObject("CpfPanel.AutoScroll")));
			this.CpfPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("CpfPanel.AutoScrollMargin")));
			this.CpfPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("CpfPanel.AutoScrollMinSize")));
			this.CpfPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CpfPanel.BackgroundImage")));
			this.CpfPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CpfPanel.Controls.Add(this.btcpfcommit);
			this.CpfPanel.Controls.Add(this.lbcpf);
			this.CpfPanel.Controls.Add(this.panel5);
			this.CpfPanel.Controls.Add(this.btprev);
			this.CpfPanel.Controls.Add(this.rtbcpf);
			this.CpfPanel.Controls.Add(this.llcpfadd);
			this.CpfPanel.Controls.Add(this.llcpfchange);
			this.CpfPanel.Controls.Add(this.linkLabel1);
			this.CpfPanel.Controls.Add(this.rtbcpfname);
			this.CpfPanel.Controls.Add(this.cbtype);
			this.CpfPanel.Controls.Add(this.label6);
			this.CpfPanel.Controls.Add(this.label8);
			this.CpfPanel.Controls.Add(this.label7);
			this.CpfPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("CpfPanel.Dock")));
			this.CpfPanel.Enabled = ((bool)(resources.GetObject("CpfPanel.Enabled")));
			this.CpfPanel.Font = ((System.Drawing.Font)(resources.GetObject("CpfPanel.Font")));
			this.CpfPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("CpfPanel.ImeMode")));
			this.CpfPanel.Location = ((System.Drawing.Point)(resources.GetObject("CpfPanel.Location")));
			this.CpfPanel.Name = "CpfPanel";
			this.CpfPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("CpfPanel.RightToLeft")));
			this.CpfPanel.Size = ((System.Drawing.Size)(resources.GetObject("CpfPanel.Size")));
			this.CpfPanel.TabIndex = ((int)(resources.GetObject("CpfPanel.TabIndex")));
			this.CpfPanel.Text = resources.GetString("CpfPanel.Text");
			this.CpfPanel.Visible = ((bool)(resources.GetObject("CpfPanel.Visible")));
			this.CpfPanel.Watermark = ((System.Drawing.Image)(resources.GetObject("CpfPanel.Watermark")));
			this.CpfPanel.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("CpfPanel.WatermarkSize")));
			// 
			// llcpfadd
			// 
			this.llcpfadd.AccessibleDescription = resources.GetString("llcpfadd.AccessibleDescription");
			this.llcpfadd.AccessibleName = resources.GetString("llcpfadd.AccessibleName");
			this.llcpfadd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcpfadd.Anchor")));
			this.llcpfadd.AutoSize = ((bool)(resources.GetObject("llcpfadd.AutoSize")));
			this.llcpfadd.BackColor = System.Drawing.Color.Transparent;
			this.llcpfadd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcpfadd.Dock")));
			this.llcpfadd.Enabled = ((bool)(resources.GetObject("llcpfadd.Enabled")));
			this.llcpfadd.Font = ((System.Drawing.Font)(resources.GetObject("llcpfadd.Font")));
			this.llcpfadd.Image = ((System.Drawing.Image)(resources.GetObject("llcpfadd.Image")));
			this.llcpfadd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcpfadd.ImageAlign")));
			this.llcpfadd.ImageIndex = ((int)(resources.GetObject("llcpfadd.ImageIndex")));
			this.llcpfadd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcpfadd.ImeMode")));
			this.llcpfadd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcpfadd.LinkArea")));
			this.llcpfadd.Location = ((System.Drawing.Point)(resources.GetObject("llcpfadd.Location")));
			this.llcpfadd.Name = "llcpfadd";
			this.llcpfadd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcpfadd.RightToLeft")));
			this.llcpfadd.Size = ((System.Drawing.Size)(resources.GetObject("llcpfadd.Size")));
			this.llcpfadd.TabIndex = ((int)(resources.GetObject("llcpfadd.TabIndex")));
			this.llcpfadd.TabStop = true;
			this.llcpfadd.Text = resources.GetString("llcpfadd.Text");
			this.llcpfadd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcpfadd.TextAlign")));
			this.llcpfadd.Visible = ((bool)(resources.GetObject("llcpfadd.Visible")));
			this.llcpfadd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddCpf);
			// 
			// llcpfchange
			// 
			this.llcpfchange.AccessibleDescription = resources.GetString("llcpfchange.AccessibleDescription");
			this.llcpfchange.AccessibleName = resources.GetString("llcpfchange.AccessibleName");
			this.llcpfchange.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcpfchange.Anchor")));
			this.llcpfchange.AutoSize = ((bool)(resources.GetObject("llcpfchange.AutoSize")));
			this.llcpfchange.BackColor = System.Drawing.Color.Transparent;
			this.llcpfchange.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcpfchange.Dock")));
			this.llcpfchange.Enabled = ((bool)(resources.GetObject("llcpfchange.Enabled")));
			this.llcpfchange.Font = ((System.Drawing.Font)(resources.GetObject("llcpfchange.Font")));
			this.llcpfchange.Image = ((System.Drawing.Image)(resources.GetObject("llcpfchange.Image")));
			this.llcpfchange.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcpfchange.ImageAlign")));
			this.llcpfchange.ImageIndex = ((int)(resources.GetObject("llcpfchange.ImageIndex")));
			this.llcpfchange.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcpfchange.ImeMode")));
			this.llcpfchange.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcpfchange.LinkArea")));
			this.llcpfchange.Location = ((System.Drawing.Point)(resources.GetObject("llcpfchange.Location")));
			this.llcpfchange.Name = "llcpfchange";
			this.llcpfchange.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcpfchange.RightToLeft")));
			this.llcpfchange.Size = ((System.Drawing.Size)(resources.GetObject("llcpfchange.Size")));
			this.llcpfchange.TabIndex = ((int)(resources.GetObject("llcpfchange.TabIndex")));
			this.llcpfchange.TabStop = true;
			this.llcpfchange.Text = resources.GetString("llcpfchange.Text");
			this.llcpfchange.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcpfchange.TextAlign")));
			this.llcpfchange.Visible = ((bool)(resources.GetObject("llcpfchange.Visible")));
			this.llcpfchange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CpfChange);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel1.Dock")));
			this.linkLabel1.Enabled = ((bool)(resources.GetObject("linkLabel1.Enabled")));
			this.linkLabel1.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel1.Font")));
			this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
			this.linkLabel1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.ImageAlign")));
			this.linkLabel1.ImageIndex = ((int)(resources.GetObject("linkLabel1.ImageIndex")));
			this.linkLabel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel1.ImeMode")));
			this.linkLabel1.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel1.LinkArea")));
			this.linkLabel1.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel1.Location")));
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel1.RightToLeft")));
			this.linkLabel1.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel1.Size")));
			this.linkLabel1.TabIndex = ((int)(resources.GetObject("linkLabel1.TabIndex")));
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
			this.linkLabel1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.TextAlign")));
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteCpf);
			// 
			// Elements2
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.NrefPanel);
			this.Controls.Add(this.CpfPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Elements2";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.panel5.ResumeLayout(false);
			this.NrefPanel.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.CpfPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panel5;
		internal System.Windows.Forms.Label label5;
		internal System.Windows.Forms.ListBox lbcpf;
		internal System.Windows.Forms.RichTextBox rtbcpf;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.RichTextBox rtbcpfname;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.Button btcpfcommit;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label label12;
		internal System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox tbnrefhash;
		internal System.Windows.Forms.Label label10;
		internal System.Windows.Forms.Button btprev;
		internal System.Windows.Forms.TextBox tbNref;
		internal SteepValley.Windows.Forms.XPGradientPanel NrefPanel;
		internal SteepValley.Windows.Forms.XPGradientPanel CpfPanel;
		internal System.Windows.Forms.LinkLabel linkLabel1;
		internal System.Windows.Forms.LinkLabel llcpfadd;
		internal System.Windows.Forms.LinkLabel llcpfchange;

		#region Str Attributes
		internal IFileWrapperSaveExtension wrapper;

		#endregion

		#region Str
		/*
		private void StrDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbtexts.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;
				StrItem[] ist = wrp.Items;
				ArrayList list = new ArrayList();

				StrItem item = (StrItem)lbtexts.Items[lbtexts.SelectedIndex];
				for (int i=0; i<ist.Length; i++)
				{
					if ((ist[i].Language != item.Language) || (ist[i].Index != item.Index)) list.Add(ist[i]);
					if ((ist[i].Language != item.Language) || (ist[i].Index > item.Index)) ist[i].Index--;
				}

				StrItem[] items = new StrItem[list.Count];
				list.CopyTo(items);
				wrp.Items = items;
				lbtexts.Items.Remove(lbtexts.Items[lbtexts.SelectedIndex]);
				LanguageChanged(null, null);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void DelInAll(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbtexts.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;
				StrItem[] ist = wrp.Items;
				ArrayList list = new ArrayList();

				StrItem item = (StrItem)lbtexts.Items[lbtexts.SelectedIndex];
				for (int i=0; i<ist.Length; i++)
				{
					if (ist[i].Index != item.Index) list.Add(ist[i]);
					if (ist[i].Index > item.Index) ist[i].Index--;
				}

				StrItem[] items = new StrItem[list.Count];
				list.CopyTo(items);
				wrp.Items = items;
				lbtexts.Items.Remove(lbtexts.Items[lbtexts.SelectedIndex]);
				LanguageChanged(null, null);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void CreateTextFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				string list = "";
				foreach (StrItem item in this.lbtexts.Items) 
				{
					list += "0x" + item.Index.ToString("X") +": " + item.Title + " ("+item.CharacterDescription+")"+Helper.lbr;
				}

				Clipboard.SetDataObject(list, true);
			} 
			catch (Exception) { }
		}

		private void ClearStr(object sender, System.EventArgs e)
		{

			try 
			{
				Str wrp = (Str)wrapper;	
				wrp.Items = new StrItem[0];

				this.cblanguage.Items.Clear();
				StrLanguage[] lngs = new StrLanguage[44];
				for (int i=1; i<lngs.Length+1; i++) 
				{
					StrLanguage lng = new StrLanguage((byte)i);
					cblanguage.Items.Add(lng);
					lngs[i-1] = lng;
				}
				wrp.Languages = lngs;
				this.cblanguage.SelectedIndex = 0;
				LanguageChanged(null, null);
			} 
			catch (Exception) { }
		}

		private void LanguageChanged(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			lbtexts.Items.Clear();
			if (this.cblanguage.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;	
				foreach (StrItem s in wrp.LanguageItems((StrLanguage)cblanguage.Items[cblanguage.SelectedIndex])) lbtexts.Items.Add(s);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}  			
			
		}

		private void StringSelected(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			llchangeall.Enabled = false;
			lldelete.Enabled = false;
			lldelall.Enabled = false;
			if (lbtexts.SelectedIndex<0) return;
			try 
			{
				StrItem s = (StrItem)lbtexts.Items[lbtexts.SelectedIndex];

				rtbvalue.Text = s.Title;
				rtbdesc.Text = s.CharacterDescription;
				llcommit.Enabled = true;
				llchangeall.Enabled = true;
				lldelete.Enabled = true;
				lldelall.Enabled = true;

				gbstr.Text = "0x"+Helper.HexString((ushort)s.Index);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}  
		}

		private void StrAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbtexts.SelectedIndex = -1;
			CommitChanges(null, null);
			lbtexts.SelectedIndex = lbtexts.Items.Count -1;
		}

		private void CommitChanges(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llcommit.Enabled = (lbtexts.SelectedIndex<0);
			if (this.cblanguage.SelectedIndex<0) return;

			try 
			{				
				Str wrp = (Str)wrapper;
				StrItem s = null;
				if (lbtexts.SelectedIndex<0) s = new StrItem();
				else s = (StrItem)lbtexts.Items[lbtexts.SelectedIndex];

				s.Title = rtbvalue.Text;
				s.CharacterDescription = rtbdesc.Text;
				
				if (lbtexts.SelectedIndex<0) 
				{
					StrLanguage lng = (StrLanguage)cblanguage.Items[cblanguage.SelectedIndex];
					s.Language = lng;
					s.Index = lbtexts.Items.Count;

					wrp.Add(s);
					lbtexts.Items.Add(s);
				}
				else lbtexts.Items[lbtexts.SelectedIndex] = s;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
		}

		private void CommitStr(object sender, System.EventArgs e)
		{
			try 
			{
				if (this.lbtexts.SelectedIndex>=0) CommitChanges(null, null);
				Str wrp = (Str)wrapper;	
				//foreach (StrItem s in wrp.LanguageItems((StrLanguage)cblanguage.Items[cblanguage.SelectedIndex])) lbtexts.Items.Add(s);
				wrp.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}  
		} 

		private void ChangeInAllLanguages(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.lbtexts.SelectedIndex<0) return;
			try 
			{				
				Str wrp = (Str)wrapper;
				StrItem s = null;
				s = (StrItem)lbtexts.Items[lbtexts.SelectedIndex];
				
				s.Title = rtbvalue.Text;
				s.CharacterDescription = rtbdesc.Text;

				foreach (StrLanguage lng in wrp.Languages) 
				{
					if (lng == null) continue;
					
					while (wrp.LanguageItems(lng).Length <= s.Index) 
					{
						StrItem si = new StrItem();
						si.Title = "";
						si.CharacterDescription = "";
						si.Language = lng;
						si.Index = wrp.LanguageItems(lng).Length;
						wrp.Add(si);
					}
					
					StrItem[] sis = wrp.LanguageItems(lng);
					sis[s.Index].Title = s.Title;
					sis[s.Index].CharacterDescription = s.CharacterDescription;
				}

				LanguageChanged(null, null);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}		
		}

		private void AddToAll(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{				
				Str wrp = (Str)wrapper;
				StrItem s = null;
				s = new StrItem();
				
				s.Title = rtbvalue.Text;
				s.CharacterDescription = rtbdesc.Text;
				
				//find longest String List
				int count = 0;
				foreach (StrLanguage lng in wrp.Languages) count = Math.Max(count, wrp.LanguageItems(lng).Length);
				

				foreach (StrLanguage lng in wrp.Languages) 
				{
					if (lng == null) continue;
					while (wrp.LanguageItems(lng).Length < count) 
					{
						StrItem si = new StrItem();
						si.Title = "";
						si.CharacterDescription = "";
						si.Language = lng;
						si.Index = wrp.LanguageItems(lng).Length;
						wrp.Add(si);
					}

					StrItem sn = new StrItem();
					sn.Title = s.Title;
					sn.CharacterDescription = s.CharacterDescription;
					sn.Language = lng;
					sn.Index = count;
					wrp.Add(sn);
				}

				LanguageChanged(null, null);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}		
		}*/

		#endregion

		#region CPF
		private void CpfItemSelect(object sender, System.EventArgs e)
		{
			if (rtbcpfname.Tag!=null) return;
			this.llcpfchange.Enabled = false;
			if (this.lbcpf.SelectedIndex<0) return;
			this.llcpfchange.Enabled = true;

			rtbcpfname.Tag = true;
			try 
			{
				CpfItem item = (CpfItem)lbcpf.Items[lbcpf.SelectedIndex];
				this.rtbcpfname.Text = item.Name;
				for(int i=0; i<cbtype.Items.Count; i++)
				{					
					cbtype.SelectedIndex = -1;
					Data.MetaData.DataTypes type = (Data.MetaData.DataTypes)cbtype.Items[i];
					if (type==item.Datatype) 
					{
						cbtype.SelectedIndex = i;
						break;
					}
				}

				switch (item.Datatype) 
				{
					case Data.MetaData.DataTypes.dtSingle: 
					{
						rtbcpf.Text = item.SingleValue.ToString();
						break;
					}
					case Data.MetaData.DataTypes.dtInteger:  
					{
						rtbcpf.Text = "0x"+Helper.HexString((uint)item.IntegerValue);
						break;
					}
					case Data.MetaData.DataTypes.dtUInteger:
					{
						rtbcpf.Text = "0x"+Helper.HexString((uint)item.UIntegerValue);
						break;
					}
					case Data.MetaData.DataTypes.dtBoolean: 
					{
						if (item.BooleanValue) rtbcpf.Text = "1";
						else rtbcpf.Text = "0";
						break;
					}
					default:
					{
						rtbcpf.Text = item.StringValue;
						break;
					}
				}
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				rtbcpfname.Tag = null;
			}
		}

		private void CpfChange(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (cbtype.SelectedIndex<0) cbtype.SelectedIndex = cbtype.Items.Count -1;
			CpfItem item;
			if (lbcpf.SelectedIndex<0) item = new CpfItem();
			else item = (CpfItem)lbcpf.Items[lbcpf.SelectedIndex];
			
			item.Name = rtbcpfname.Text;
			item.Datatype = (Data.MetaData.DataTypes)cbtype.Items[cbtype.SelectedIndex];

			switch (item.Datatype) 
			{
				case Data.MetaData.DataTypes.dtInteger:  
				{
					try 
					{
						item.IntegerValue = Convert.ToInt32(rtbcpf.Text, 16);
					} 
					catch (Exception) 
					{
						item.IntegerValue = 0;
					}
					break;
				}
				case Data.MetaData.DataTypes.dtUInteger:
				{
					try 
					{
						item.UIntegerValue = Convert.ToUInt32(rtbcpf.Text, 16);
					} 
					catch (Exception) 
					{
						item.UIntegerValue = 0;
					}
					break;
				}
				case Data.MetaData.DataTypes.dtSingle: 
				{
					try 
					{
						item.SingleValue = Convert.ToSingle(rtbcpf.Text);
					} 
					catch (Exception) 
					{
						item.SingleValue = 0;
					}
					break;
				}
				case Data.MetaData.DataTypes.dtBoolean: 
				{
					try 
					{
						item.BooleanValue = (Convert.ToByte(rtbcpf.Text)!=0);
					} 
					catch (Exception) 
					{
						item.BooleanValue = false;
					}
					break;
				}
				default: 
				{
					item.StringValue = rtbcpf.Text;
					break;
				}
			} //switch

			if (lbcpf.SelectedIndex<0) lbcpf.Items.Add(item);
			else lbcpf.Items[lbcpf.SelectedIndex] = item;

			if (wrapper!=null) wrapper.Changed = true;
		}

		private void AddCpf(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbcpf.SelectedIndex = -1;
			CpfChange(null, null);
			lbcpf.SelectedIndex = lbcpf.Items.Count-1;
			CpfUpdate();
		}

		private void CpfUpdate()
		{
			Cpf wrp = (Cpf)wrapper;	
				
			CpfItem[] items = new CpfItem[lbcpf.Items.Count];
			for (int i=0; i<items.Length; i++) items[i] = (CpfItem)lbcpf.Items[i];
			wrp.Items = items;
		}

		private void CpfCommit(object sender, System.EventArgs e)
		{
			try 
			{
				if (this.lbcpf.SelectedIndex>=0) CpfChange(null, null);
				CpfUpdate();
				Cpf wrp = (Cpf)wrapper;	

				wrp.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		#endregion		

		private void tbnref_TextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				Nref wrp = (Nref)wrapper;
				tbnrefhash.Text = "0x"+Helper.HexString(wrp.Group);

				if (tbNref.Tag!=null) return;
				wrp.FileName = tbNref.Text;
				wrp.Changed = true;
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void NrefCommit(object sender, System.EventArgs e)
		{
			try 
			{
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void CpfAutoChange()
		{
			if (rtbcpfname.Tag!=null) return;
			if (lbcpf.SelectedIndex<0) return;
			rtbcpfname.Tag = true;
			try 
			{
				CpfChange(null, null);
			}
			finally
			{
				rtbcpfname.Tag = null;
			}
		}

		

		internal SimPe.PackedFiles.UserInterface.CpfUI.ExecutePreview fkt;
		private void btprev_Click(object sender, System.EventArgs e)
		{
			if (fkt==null) return;
			try 
			{
				Cpf cpf = (Cpf)wrapper;
				fkt(cpf, cpf.Package);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void DeleteCpf(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
			if (lbcpf.SelectedIndex<0) return;
			CpfItem item = (CpfItem)lbcpf.Items[lbcpf.SelectedIndex];
			lbcpf.Items.Remove(item);
			CpfUpdate();
			wrapper.Changed = true;
		}

		private void CpfAutoChange(object sender, System.EventArgs e)
		{
			CpfAutoChange();
		}
		
	}
}
