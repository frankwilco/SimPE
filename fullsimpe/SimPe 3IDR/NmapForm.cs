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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NmapForm.
	/// </summary>
	public class NmapForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NmapForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NmapForm));
			this.wrapperPanel = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbfindname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btref = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.gbtypes = new System.Windows.Forms.GroupBox();
			this.pntypes = new System.Windows.Forms.Panel();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.lldelete = new System.Windows.Forms.LinkLabel();
			this.tbinstance = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.tbgroup = new System.Windows.Forms.TextBox();
			this.llcommit = new System.Windows.Forms.LinkLabel();
			this.lblist = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.wrapperPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbtypes.SuspendLayout();
			this.pntypes.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// wrapperPanel
			// 
			this.wrapperPanel.AccessibleDescription = resources.GetString("wrapperPanel.AccessibleDescription");
			this.wrapperPanel.AccessibleName = resources.GetString("wrapperPanel.AccessibleName");
			this.wrapperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wrapperPanel.Anchor")));
			this.wrapperPanel.AutoScroll = ((bool)(resources.GetObject("wrapperPanel.AutoScroll")));
			this.wrapperPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.AutoScrollMargin")));
			this.wrapperPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.AutoScrollMinSize")));
			this.wrapperPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapperPanel.BackgroundImage")));
			this.wrapperPanel.Controls.Add(this.groupBox1);
			this.wrapperPanel.Controls.Add(this.btref);
			this.wrapperPanel.Controls.Add(this.button1);
			this.wrapperPanel.Controls.Add(this.gbtypes);
			this.wrapperPanel.Controls.Add(this.lblist);
			this.wrapperPanel.Controls.Add(this.panel3);
			this.wrapperPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wrapperPanel.Dock")));
			this.wrapperPanel.Enabled = ((bool)(resources.GetObject("wrapperPanel.Enabled")));
			this.wrapperPanel.Font = ((System.Drawing.Font)(resources.GetObject("wrapperPanel.Font")));
			this.wrapperPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wrapperPanel.ImeMode")));
			this.wrapperPanel.Location = ((System.Drawing.Point)(resources.GetObject("wrapperPanel.Location")));
			this.wrapperPanel.Name = "wrapperPanel";
			this.wrapperPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wrapperPanel.RightToLeft")));
			this.wrapperPanel.Size = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.Size")));
			this.wrapperPanel.TabIndex = ((int)(resources.GetObject("wrapperPanel.TabIndex")));
			this.wrapperPanel.Text = resources.GetString("wrapperPanel.Text");
			this.wrapperPanel.Visible = ((bool)(resources.GetObject("wrapperPanel.Visible")));
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.tbfindname);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
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
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTextFile);
			// 
			// tbfindname
			// 
			this.tbfindname.AccessibleDescription = resources.GetString("tbfindname.AccessibleDescription");
			this.tbfindname.AccessibleName = resources.GetString("tbfindname.AccessibleName");
			this.tbfindname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfindname.Anchor")));
			this.tbfindname.AutoSize = ((bool)(resources.GetObject("tbfindname.AutoSize")));
			this.tbfindname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfindname.BackgroundImage")));
			this.tbfindname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfindname.Dock")));
			this.tbfindname.Enabled = ((bool)(resources.GetObject("tbfindname.Enabled")));
			this.tbfindname.Font = ((System.Drawing.Font)(resources.GetObject("tbfindname.Font")));
			this.tbfindname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfindname.ImeMode")));
			this.tbfindname.Location = ((System.Drawing.Point)(resources.GetObject("tbfindname.Location")));
			this.tbfindname.MaxLength = ((int)(resources.GetObject("tbfindname.MaxLength")));
			this.tbfindname.Multiline = ((bool)(resources.GetObject("tbfindname.Multiline")));
			this.tbfindname.Name = "tbfindname";
			this.tbfindname.PasswordChar = ((char)(resources.GetObject("tbfindname.PasswordChar")));
			this.tbfindname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfindname.RightToLeft")));
			this.tbfindname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfindname.ScrollBars")));
			this.tbfindname.Size = ((System.Drawing.Size)(resources.GetObject("tbfindname.Size")));
			this.tbfindname.TabIndex = ((int)(resources.GetObject("tbfindname.TabIndex")));
			this.tbfindname.Text = resources.GetString("tbfindname.Text");
			this.tbfindname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfindname.TextAlign")));
			this.tbfindname.Visible = ((bool)(resources.GetObject("tbfindname.Visible")));
			this.tbfindname.WordWrap = ((bool)(resources.GetObject("tbfindname.WordWrap")));
			this.tbfindname.TextChanged += new System.EventHandler(this.tbfindname_TextChanged);
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
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
			// btref
			// 
			this.btref.AccessibleDescription = resources.GetString("btref.AccessibleDescription");
			this.btref.AccessibleName = resources.GetString("btref.AccessibleName");
			this.btref.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btref.Anchor")));
			this.btref.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btref.BackgroundImage")));
			this.btref.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btref.Dock")));
			this.btref.Enabled = ((bool)(resources.GetObject("btref.Enabled")));
			this.btref.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btref.FlatStyle")));
			this.btref.Font = ((System.Drawing.Font)(resources.GetObject("btref.Font")));
			this.btref.Image = ((System.Drawing.Image)(resources.GetObject("btref.Image")));
			this.btref.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btref.ImageAlign")));
			this.btref.ImageIndex = ((int)(resources.GetObject("btref.ImageIndex")));
			this.btref.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btref.ImeMode")));
			this.btref.Location = ((System.Drawing.Point)(resources.GetObject("btref.Location")));
			this.btref.Name = "btref";
			this.btref.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btref.RightToLeft")));
			this.btref.Size = ((System.Drawing.Size)(resources.GetObject("btref.Size")));
			this.btref.TabIndex = ((int)(resources.GetObject("btref.TabIndex")));
			this.btref.Text = resources.GetString("btref.Text");
			this.btref.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btref.TextAlign")));
			this.btref.Visible = ((bool)(resources.GetObject("btref.Visible")));
			this.btref.Click += new System.EventHandler(this.ShowPackageSelector);
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.CommitAll);
			// 
			// gbtypes
			// 
			this.gbtypes.AccessibleDescription = resources.GetString("gbtypes.AccessibleDescription");
			this.gbtypes.AccessibleName = resources.GetString("gbtypes.AccessibleName");
			this.gbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbtypes.Anchor")));
			this.gbtypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbtypes.BackgroundImage")));
			this.gbtypes.Controls.Add(this.pntypes);
			this.gbtypes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbtypes.Dock")));
			this.gbtypes.Enabled = ((bool)(resources.GetObject("gbtypes.Enabled")));
			this.gbtypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbtypes.Font = ((System.Drawing.Font)(resources.GetObject("gbtypes.Font")));
			this.gbtypes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbtypes.ImeMode")));
			this.gbtypes.Location = ((System.Drawing.Point)(resources.GetObject("gbtypes.Location")));
			this.gbtypes.Name = "gbtypes";
			this.gbtypes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbtypes.RightToLeft")));
			this.gbtypes.Size = ((System.Drawing.Size)(resources.GetObject("gbtypes.Size")));
			this.gbtypes.TabIndex = ((int)(resources.GetObject("gbtypes.TabIndex")));
			this.gbtypes.TabStop = false;
			this.gbtypes.Text = resources.GetString("gbtypes.Text");
			this.gbtypes.Visible = ((bool)(resources.GetObject("gbtypes.Visible")));
			// 
			// pntypes
			// 
			this.pntypes.AccessibleDescription = resources.GetString("pntypes.AccessibleDescription");
			this.pntypes.AccessibleName = resources.GetString("pntypes.AccessibleName");
			this.pntypes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pntypes.Anchor")));
			this.pntypes.AutoScroll = ((bool)(resources.GetObject("pntypes.AutoScroll")));
			this.pntypes.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pntypes.AutoScrollMargin")));
			this.pntypes.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pntypes.AutoScrollMinSize")));
			this.pntypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pntypes.BackgroundImage")));
			this.pntypes.Controls.Add(this.tbname);
			this.pntypes.Controls.Add(this.label2);
			this.pntypes.Controls.Add(this.lladd);
			this.pntypes.Controls.Add(this.lldelete);
			this.pntypes.Controls.Add(this.tbinstance);
			this.pntypes.Controls.Add(this.label11);
			this.pntypes.Controls.Add(this.label9);
			this.pntypes.Controls.Add(this.tbgroup);
			this.pntypes.Controls.Add(this.llcommit);
			this.pntypes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pntypes.Dock")));
			this.pntypes.Enabled = ((bool)(resources.GetObject("pntypes.Enabled")));
			this.pntypes.Font = ((System.Drawing.Font)(resources.GetObject("pntypes.Font")));
			this.pntypes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pntypes.ImeMode")));
			this.pntypes.Location = ((System.Drawing.Point)(resources.GetObject("pntypes.Location")));
			this.pntypes.Name = "pntypes";
			this.pntypes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pntypes.RightToLeft")));
			this.pntypes.Size = ((System.Drawing.Size)(resources.GetObject("pntypes.Size")));
			this.pntypes.TabIndex = ((int)(resources.GetObject("pntypes.TabIndex")));
			this.pntypes.Text = resources.GetString("pntypes.Text");
			this.pntypes.Visible = ((bool)(resources.GetObject("pntypes.Visible")));
			// 
			// tbname
			// 
			this.tbname.AccessibleDescription = resources.GetString("tbname.AccessibleDescription");
			this.tbname.AccessibleName = resources.GetString("tbname.AccessibleName");
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbname.Anchor")));
			this.tbname.AutoSize = ((bool)(resources.GetObject("tbname.AutoSize")));
			this.tbname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbname.BackgroundImage")));
			this.tbname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbname.Dock")));
			this.tbname.Enabled = ((bool)(resources.GetObject("tbname.Enabled")));
			this.tbname.Font = ((System.Drawing.Font)(resources.GetObject("tbname.Font")));
			this.tbname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbname.ImeMode")));
			this.tbname.Location = ((System.Drawing.Point)(resources.GetObject("tbname.Location")));
			this.tbname.MaxLength = ((int)(resources.GetObject("tbname.MaxLength")));
			this.tbname.Multiline = ((bool)(resources.GetObject("tbname.Multiline")));
			this.tbname.Name = "tbname";
			this.tbname.PasswordChar = ((char)(resources.GetObject("tbname.PasswordChar")));
			this.tbname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbname.RightToLeft")));
			this.tbname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbname.ScrollBars")));
			this.tbname.Size = ((System.Drawing.Size)(resources.GetObject("tbname.Size")));
			this.tbname.TabIndex = ((int)(resources.GetObject("tbname.TabIndex")));
			this.tbname.Text = resources.GetString("tbname.Text");
			this.tbname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbname.TextAlign")));
			this.tbname.Visible = ((bool)(resources.GetObject("tbname.Visible")));
			this.tbname.WordWrap = ((bool)(resources.GetObject("tbname.WordWrap")));
			this.tbname.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
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
			// lladd
			// 
			this.lladd.AccessibleDescription = resources.GetString("lladd.AccessibleDescription");
			this.lladd.AccessibleName = resources.GetString("lladd.AccessibleName");
			this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lladd.Anchor")));
			this.lladd.AutoSize = ((bool)(resources.GetObject("lladd.AutoSize")));
			this.lladd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lladd.Dock")));
			this.lladd.Enabled = ((bool)(resources.GetObject("lladd.Enabled")));
			this.lladd.Font = ((System.Drawing.Font)(resources.GetObject("lladd.Font")));
			this.lladd.Image = ((System.Drawing.Image)(resources.GetObject("lladd.Image")));
			this.lladd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.ImageAlign")));
			this.lladd.ImageIndex = ((int)(resources.GetObject("lladd.ImageIndex")));
			this.lladd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lladd.ImeMode")));
			this.lladd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lladd.LinkArea")));
			this.lladd.Location = ((System.Drawing.Point)(resources.GetObject("lladd.Location")));
			this.lladd.Name = "lladd";
			this.lladd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lladd.RightToLeft")));
			this.lladd.Size = ((System.Drawing.Size)(resources.GetObject("lladd.Size")));
			this.lladd.TabIndex = ((int)(resources.GetObject("lladd.TabIndex")));
			this.lladd.TabStop = true;
			this.lladd.Text = resources.GetString("lladd.Text");
			this.lladd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.TextAlign")));
			this.lladd.Visible = ((bool)(resources.GetObject("lladd.Visible")));
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddFile);
			// 
			// lldelete
			// 
			this.lldelete.AccessibleDescription = resources.GetString("lldelete.AccessibleDescription");
			this.lldelete.AccessibleName = resources.GetString("lldelete.AccessibleName");
			this.lldelete.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldelete.Anchor")));
			this.lldelete.AutoSize = ((bool)(resources.GetObject("lldelete.AutoSize")));
			this.lldelete.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldelete.Dock")));
			this.lldelete.Enabled = ((bool)(resources.GetObject("lldelete.Enabled")));
			this.lldelete.Font = ((System.Drawing.Font)(resources.GetObject("lldelete.Font")));
			this.lldelete.Image = ((System.Drawing.Image)(resources.GetObject("lldelete.Image")));
			this.lldelete.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelete.ImageAlign")));
			this.lldelete.ImageIndex = ((int)(resources.GetObject("lldelete.ImageIndex")));
			this.lldelete.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldelete.ImeMode")));
			this.lldelete.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldelete.LinkArea")));
			this.lldelete.Location = ((System.Drawing.Point)(resources.GetObject("lldelete.Location")));
			this.lldelete.Name = "lldelete";
			this.lldelete.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldelete.RightToLeft")));
			this.lldelete.Size = ((System.Drawing.Size)(resources.GetObject("lldelete.Size")));
			this.lldelete.TabIndex = ((int)(resources.GetObject("lldelete.TabIndex")));
			this.lldelete.TabStop = true;
			this.lldelete.Text = resources.GetString("lldelete.Text");
			this.lldelete.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelete.TextAlign")));
			this.lldelete.Visible = ((bool)(resources.GetObject("lldelete.Visible")));
			this.lldelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteFile);
			// 
			// tbinstance
			// 
			this.tbinstance.AccessibleDescription = resources.GetString("tbinstance.AccessibleDescription");
			this.tbinstance.AccessibleName = resources.GetString("tbinstance.AccessibleName");
			this.tbinstance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinstance.Anchor")));
			this.tbinstance.AutoSize = ((bool)(resources.GetObject("tbinstance.AutoSize")));
			this.tbinstance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinstance.BackgroundImage")));
			this.tbinstance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinstance.Dock")));
			this.tbinstance.Enabled = ((bool)(resources.GetObject("tbinstance.Enabled")));
			this.tbinstance.Font = ((System.Drawing.Font)(resources.GetObject("tbinstance.Font")));
			this.tbinstance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinstance.ImeMode")));
			this.tbinstance.Location = ((System.Drawing.Point)(resources.GetObject("tbinstance.Location")));
			this.tbinstance.MaxLength = ((int)(resources.GetObject("tbinstance.MaxLength")));
			this.tbinstance.Multiline = ((bool)(resources.GetObject("tbinstance.Multiline")));
			this.tbinstance.Name = "tbinstance";
			this.tbinstance.PasswordChar = ((char)(resources.GetObject("tbinstance.PasswordChar")));
			this.tbinstance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinstance.RightToLeft")));
			this.tbinstance.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinstance.ScrollBars")));
			this.tbinstance.Size = ((System.Drawing.Size)(resources.GetObject("tbinstance.Size")));
			this.tbinstance.TabIndex = ((int)(resources.GetObject("tbinstance.TabIndex")));
			this.tbinstance.Text = resources.GetString("tbinstance.Text");
			this.tbinstance.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinstance.TextAlign")));
			this.tbinstance.Visible = ((bool)(resources.GetObject("tbinstance.Visible")));
			this.tbinstance.WordWrap = ((bool)(resources.GetObject("tbinstance.WordWrap")));
			this.tbinstance.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label11
			// 
			this.label11.AccessibleDescription = resources.GetString("label11.AccessibleDescription");
			this.label11.AccessibleName = resources.GetString("label11.AccessibleName");
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label11.Anchor")));
			this.label11.AutoSize = ((bool)(resources.GetObject("label11.AutoSize")));
			this.label11.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label11.Dock")));
			this.label11.Enabled = ((bool)(resources.GetObject("label11.Enabled")));
			this.label11.Font = ((System.Drawing.Font)(resources.GetObject("label11.Font")));
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label11.ImageAlign")));
			this.label11.ImageIndex = ((int)(resources.GetObject("label11.ImageIndex")));
			this.label11.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label11.ImeMode")));
			this.label11.Location = ((System.Drawing.Point)(resources.GetObject("label11.Location")));
			this.label11.Name = "label11";
			this.label11.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label11.RightToLeft")));
			this.label11.Size = ((System.Drawing.Size)(resources.GetObject("label11.Size")));
			this.label11.TabIndex = ((int)(resources.GetObject("label11.TabIndex")));
			this.label11.Text = resources.GetString("label11.Text");
			this.label11.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label11.TextAlign")));
			this.label11.Visible = ((bool)(resources.GetObject("label11.Visible")));
			// 
			// label9
			// 
			this.label9.AccessibleDescription = resources.GetString("label9.AccessibleDescription");
			this.label9.AccessibleName = resources.GetString("label9.AccessibleName");
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
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
			// tbgroup
			// 
			this.tbgroup.AccessibleDescription = resources.GetString("tbgroup.AccessibleDescription");
			this.tbgroup.AccessibleName = resources.GetString("tbgroup.AccessibleName");
			this.tbgroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgroup.Anchor")));
			this.tbgroup.AutoSize = ((bool)(resources.GetObject("tbgroup.AutoSize")));
			this.tbgroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgroup.BackgroundImage")));
			this.tbgroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgroup.Dock")));
			this.tbgroup.Enabled = ((bool)(resources.GetObject("tbgroup.Enabled")));
			this.tbgroup.Font = ((System.Drawing.Font)(resources.GetObject("tbgroup.Font")));
			this.tbgroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgroup.ImeMode")));
			this.tbgroup.Location = ((System.Drawing.Point)(resources.GetObject("tbgroup.Location")));
			this.tbgroup.MaxLength = ((int)(resources.GetObject("tbgroup.MaxLength")));
			this.tbgroup.Multiline = ((bool)(resources.GetObject("tbgroup.Multiline")));
			this.tbgroup.Name = "tbgroup";
			this.tbgroup.PasswordChar = ((char)(resources.GetObject("tbgroup.PasswordChar")));
			this.tbgroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgroup.RightToLeft")));
			this.tbgroup.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgroup.ScrollBars")));
			this.tbgroup.Size = ((System.Drawing.Size)(resources.GetObject("tbgroup.Size")));
			this.tbgroup.TabIndex = ((int)(resources.GetObject("tbgroup.TabIndex")));
			this.tbgroup.Text = resources.GetString("tbgroup.Text");
			this.tbgroup.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgroup.TextAlign")));
			this.tbgroup.Visible = ((bool)(resources.GetObject("tbgroup.Visible")));
			this.tbgroup.WordWrap = ((bool)(resources.GetObject("tbgroup.WordWrap")));
			this.tbgroup.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// llcommit
			// 
			this.llcommit.AccessibleDescription = resources.GetString("llcommit.AccessibleDescription");
			this.llcommit.AccessibleName = resources.GetString("llcommit.AccessibleName");
			this.llcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommit.Anchor")));
			this.llcommit.AutoSize = ((bool)(resources.GetObject("llcommit.AutoSize")));
			this.llcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommit.Dock")));
			this.llcommit.Enabled = ((bool)(resources.GetObject("llcommit.Enabled")));
			this.llcommit.Font = ((System.Drawing.Font)(resources.GetObject("llcommit.Font")));
			this.llcommit.Image = ((System.Drawing.Image)(resources.GetObject("llcommit.Image")));
			this.llcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.ImageAlign")));
			this.llcommit.ImageIndex = ((int)(resources.GetObject("llcommit.ImageIndex")));
			this.llcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommit.ImeMode")));
			this.llcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommit.LinkArea")));
			this.llcommit.Location = ((System.Drawing.Point)(resources.GetObject("llcommit.Location")));
			this.llcommit.Name = "llcommit";
			this.llcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommit.RightToLeft")));
			this.llcommit.Size = ((System.Drawing.Size)(resources.GetObject("llcommit.Size")));
			this.llcommit.TabIndex = ((int)(resources.GetObject("llcommit.TabIndex")));
			this.llcommit.TabStop = true;
			this.llcommit.Text = resources.GetString("llcommit.Text");
			this.llcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.TextAlign")));
			this.llcommit.Visible = ((bool)(resources.GetObject("llcommit.Visible")));
			this.llcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeFile);
			// 
			// lblist
			// 
			this.lblist.AccessibleDescription = resources.GetString("lblist.AccessibleDescription");
			this.lblist.AccessibleName = resources.GetString("lblist.AccessibleName");
			this.lblist.AllowDrop = true;
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lblist.Anchor")));
			this.lblist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblist.BackgroundImage")));
			this.lblist.ColumnWidth = ((int)(resources.GetObject("lblist.ColumnWidth")));
			this.lblist.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lblist.Dock")));
			this.lblist.Enabled = ((bool)(resources.GetObject("lblist.Enabled")));
			this.lblist.Font = ((System.Drawing.Font)(resources.GetObject("lblist.Font")));
			this.lblist.HorizontalExtent = ((int)(resources.GetObject("lblist.HorizontalExtent")));
			this.lblist.HorizontalScrollbar = ((bool)(resources.GetObject("lblist.HorizontalScrollbar")));
			this.lblist.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lblist.ImeMode")));
			this.lblist.IntegralHeight = ((bool)(resources.GetObject("lblist.IntegralHeight")));
			this.lblist.ItemHeight = ((int)(resources.GetObject("lblist.ItemHeight")));
			this.lblist.Location = ((System.Drawing.Point)(resources.GetObject("lblist.Location")));
			this.lblist.Name = "lblist";
			this.lblist.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lblist.RightToLeft")));
			this.lblist.ScrollAlwaysVisible = ((bool)(resources.GetObject("lblist.ScrollAlwaysVisible")));
			this.lblist.Size = ((System.Drawing.Size)(resources.GetObject("lblist.Size")));
			this.lblist.TabIndex = ((int)(resources.GetObject("lblist.TabIndex")));
			this.lblist.Visible = ((bool)(resources.GetObject("lblist.Visible")));
			this.lblist.DragDrop += new System.Windows.Forms.DragEventHandler(this.PackageItemDrop);
			this.lblist.DragEnter += new System.Windows.Forms.DragEventHandler(this.PackageItemDragEnter);
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.SelectFile);
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
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
			// sfd
			// 
			this.sfd.Filter = resources.GetString("sfd.Filter");
			this.sfd.Title = resources.GetString("sfd.Title");
			// 
			// NmapForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.wrapperPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "NmapForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.wrapperPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbtypes.ResumeLayout(false);
			this.pntypes.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.Panel wrapperPanel;
		internal System.Windows.Forms.ListBox lblist;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox gbtypes;
		internal System.Windows.Forms.LinkLabel lladd;
		internal System.Windows.Forms.LinkLabel lldelete;
		internal System.Windows.Forms.TextBox tbinstance;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label9;
		internal System.Windows.Forms.TextBox tbgroup;
		internal System.Windows.Forms.LinkLabel llcommit;
		private System.Windows.Forms.Panel pntypes;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.Button btref;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.TextBox tbfindname;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.SaveFileDialog sfd;

		internal SimPe.Plugin.Nmap wrapper;

		private void SelectFile(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			lldelete.Enabled = false;
			if (lblist.SelectedIndex<0) return;
			llcommit.Enabled = true;
			lldelete.Enabled = true;

			if (tbgroup.Tag!=null) return;
			try 
			{
				tbgroup.Tag = true;
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
				this.tbgroup.Text = "0x"+Helper.HexString(pfd.Group);
				this.tbinstance.Text = "0x"+Helper.HexString(pfd.Instance);
				this.tbname.Text = pfd.Filename;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbgroup.Tag = null;
			}
		}

		private void ChangeFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				Packages.PackedFileDescriptor pfd = null;
				if (lblist.SelectedIndex>=0) pfd = (Packages.PackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
				else pfd = new NmapItem(wrapper);

				pfd.Group = Convert.ToUInt32(this.tbgroup.Text, 16);
				pfd.Instance = Convert.ToUInt32(this.tbinstance.Text, 16);
				pfd.Filename = this.tbname.Text;

				if (lblist.SelectedIndex>=0) lblist.Items[lblist.SelectedIndex] = pfd;
				else lblist.Items.Add(pfd);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void AddFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblist.SelectedIndex = -1;
			ChangeFile(null, null);
			lblist.SelectedIndex = lblist.Items.Count - 1;
		}

		private void DeleteFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llcommit.Enabled = false;
			lldelete.Enabled = false;
			if (lblist.SelectedIndex<0) return;
			llcommit.Enabled = true;
			lldelete.Enabled = true;

			lblist.Items.Remove(lblist.Items[lblist.SelectedIndex]);
		}

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbgroup.Tag != null) return;

			tbgroup.Tag = true;
			if (lblist.SelectedIndex>=0) ChangeFile(null, null);
			tbgroup.Tag = null;
		}

		private void CommitAll(object sender, System.EventArgs e)
		{
			try 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = new Interfaces.Files.IPackedFileDescriptor[lblist.Items.Count];
				for (int i=0; i<pfds.Length; i++) 
				{
					pfds[i] = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[i];
				}

				wrapper.Items = pfds;
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}	
		}

		#region Package Selector
		private void ShowPackageSelector(object sender, System.EventArgs e)
		{
			SimPe.PackageSelectorForm form = new SimPe.PackageSelectorForm();
			form.Execute(wrapper.Package);
		}

		private void PackageItemDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(SimPe.Packages.PackedFileDescriptor))) 
			{				
				e.Effect = DragDropEffects.Copy;	
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}					
		}

		private void PackageItemDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = null;
				pfd = (Interfaces.Files.IPackedFileDescriptor)e.Data.GetData(typeof(SimPe.Packages.PackedFileDescriptor));
				
				NmapItem nmi = new NmapItem(wrapper);
				nmi.Group = pfd.Group;
				nmi.Type = pfd.Type;
				nmi.SubType = pfd.SubType;
				nmi.Instance = pfd.Instance;
				nmi.Filename = Data.MetaData.FindTypeAlias(pfd.Type).Name;
				lblist.Items.Add(nmi);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}
		#endregion

		private void tbfindname_TextChanged(object sender, System.EventArgs e)
		{
			
			string name = tbfindname.Text.Trim().ToLower();
			for (int i=0; i<lblist.Items.Count; i++)
			{
				Packages.PackedFileDescriptor pfd = (Packages.PackedFileDescriptor)lblist.Items[i];
				if (pfd.Filename.Trim().ToLower().StartsWith(name)) 
				{
					tbfindname.Text = pfd.Filename.Trim();
					tbfindname.SelectionStart = name.Length;
					tbfindname.SelectionLength = Math.Max(0, tbfindname.Text.Length - name.Length);
					lblist.SelectedIndex = i;
					break;
				}
			}
		}

		private void CreateTextFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			sfd.FileName = System.IO.Path.GetFileNameWithoutExtension(wrapper.Package.FileName) + "_NameMap.txt";
			if (sfd.ShowDialog()==DialogResult.OK)
			{
				try 
				{
					
					System.IO.TextWriter tw = System.IO.File.CreateText(sfd.FileName);
					try 
					{
						tw.WriteLine(
							"Filename; "+
							"Group; "+
							"Instance; "
							);
						foreach (Packages.PackedFileDescriptor pfd in lblist.Items) 
						{
							tw.WriteLine(
								pfd.Filename + "; "+
								"0x"+Helper.HexString(pfd.Group) + "; "+
								"0x"+Helper.HexString(pfd.Instance) + "; "
								);
						}
					} 
					finally 
					{
						tw.Close();
						tw.Dispose();
						tw = null;
					}
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}
			}
		}
	}
}
