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
	/// Zusammenfassung für Sims.
	/// </summary>
	public class Surgery : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pbpatient;
		private System.Windows.Forms.PictureBox pbarche;
		private System.Windows.Forms.LinkLabel llusepatient;
		private System.Windows.Forms.LinkLabel llusearche;
		private System.Windows.Forms.Label lbpatname;
		private System.Windows.Forms.Label lbpatlife;
		private System.Windows.Forms.Label lbarchlife;
		private System.Windows.Forms.Label lbarchname;
		private System.Windows.Forms.CheckBox cbface;
		private System.Windows.Forms.CheckBox cbskin;
		private System.Windows.Forms.LinkLabel llexport;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public Surgery()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Surgery));
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.lv = new System.Windows.Forms.ListView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lbpatlife = new System.Windows.Forms.Label();
			this.lbpatname = new System.Windows.Forms.Label();
			this.pbpatient = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.llusepatient = new System.Windows.Forms.LinkLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lbarchlife = new System.Windows.Forms.Label();
			this.lbarchname = new System.Windows.Forms.Label();
			this.llusearche = new System.Windows.Forms.LinkLabel();
			this.pbarche = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbface = new System.Windows.Forms.CheckBox();
			this.cbskin = new System.Windows.Forms.CheckBox();
			this.llexport = new System.Windows.Forms.LinkLabel();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.SmallImageList = this.ilist;
			this.lv.StateImageList = this.ilist;
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.toolTip1.SetToolTip(this.lv, resources.GetString("lv.ToolTip"));
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.DoubleClick += new System.EventHandler(this.Open);
			this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectSim);
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
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.Open);
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
			this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.llexport);
			this.groupBox1.Controls.Add(this.lbpatlife);
			this.groupBox1.Controls.Add(this.lbpatname);
			this.groupBox1.Controls.Add(this.pbpatient);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.llusepatient);
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
			this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// lbpatlife
			// 
			this.lbpatlife.AccessibleDescription = resources.GetString("lbpatlife.AccessibleDescription");
			this.lbpatlife.AccessibleName = resources.GetString("lbpatlife.AccessibleName");
			this.lbpatlife.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbpatlife.Anchor")));
			this.lbpatlife.AutoSize = ((bool)(resources.GetObject("lbpatlife.AutoSize")));
			this.lbpatlife.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbpatlife.Dock")));
			this.lbpatlife.Enabled = ((bool)(resources.GetObject("lbpatlife.Enabled")));
			this.lbpatlife.Font = ((System.Drawing.Font)(resources.GetObject("lbpatlife.Font")));
			this.lbpatlife.Image = ((System.Drawing.Image)(resources.GetObject("lbpatlife.Image")));
			this.lbpatlife.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbpatlife.ImageAlign")));
			this.lbpatlife.ImageIndex = ((int)(resources.GetObject("lbpatlife.ImageIndex")));
			this.lbpatlife.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbpatlife.ImeMode")));
			this.lbpatlife.Location = ((System.Drawing.Point)(resources.GetObject("lbpatlife.Location")));
			this.lbpatlife.Name = "lbpatlife";
			this.lbpatlife.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbpatlife.RightToLeft")));
			this.lbpatlife.Size = ((System.Drawing.Size)(resources.GetObject("lbpatlife.Size")));
			this.lbpatlife.TabIndex = ((int)(resources.GetObject("lbpatlife.TabIndex")));
			this.lbpatlife.Text = resources.GetString("lbpatlife.Text");
			this.lbpatlife.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbpatlife.TextAlign")));
			this.toolTip1.SetToolTip(this.lbpatlife, resources.GetString("lbpatlife.ToolTip"));
			this.lbpatlife.Visible = ((bool)(resources.GetObject("lbpatlife.Visible")));
			// 
			// lbpatname
			// 
			this.lbpatname.AccessibleDescription = resources.GetString("lbpatname.AccessibleDescription");
			this.lbpatname.AccessibleName = resources.GetString("lbpatname.AccessibleName");
			this.lbpatname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbpatname.Anchor")));
			this.lbpatname.AutoSize = ((bool)(resources.GetObject("lbpatname.AutoSize")));
			this.lbpatname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbpatname.Dock")));
			this.lbpatname.Enabled = ((bool)(resources.GetObject("lbpatname.Enabled")));
			this.lbpatname.Font = ((System.Drawing.Font)(resources.GetObject("lbpatname.Font")));
			this.lbpatname.Image = ((System.Drawing.Image)(resources.GetObject("lbpatname.Image")));
			this.lbpatname.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbpatname.ImageAlign")));
			this.lbpatname.ImageIndex = ((int)(resources.GetObject("lbpatname.ImageIndex")));
			this.lbpatname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbpatname.ImeMode")));
			this.lbpatname.Location = ((System.Drawing.Point)(resources.GetObject("lbpatname.Location")));
			this.lbpatname.Name = "lbpatname";
			this.lbpatname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbpatname.RightToLeft")));
			this.lbpatname.Size = ((System.Drawing.Size)(resources.GetObject("lbpatname.Size")));
			this.lbpatname.TabIndex = ((int)(resources.GetObject("lbpatname.TabIndex")));
			this.lbpatname.Text = resources.GetString("lbpatname.Text");
			this.lbpatname.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbpatname.TextAlign")));
			this.toolTip1.SetToolTip(this.lbpatname, resources.GetString("lbpatname.ToolTip"));
			this.lbpatname.Visible = ((bool)(resources.GetObject("lbpatname.Visible")));
			// 
			// pbpatient
			// 
			this.pbpatient.AccessibleDescription = resources.GetString("pbpatient.AccessibleDescription");
			this.pbpatient.AccessibleName = resources.GetString("pbpatient.AccessibleName");
			this.pbpatient.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbpatient.Anchor")));
			this.pbpatient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbpatient.BackgroundImage")));
			this.pbpatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbpatient.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbpatient.Dock")));
			this.pbpatient.Enabled = ((bool)(resources.GetObject("pbpatient.Enabled")));
			this.pbpatient.Font = ((System.Drawing.Font)(resources.GetObject("pbpatient.Font")));
			this.pbpatient.Image = ((System.Drawing.Image)(resources.GetObject("pbpatient.Image")));
			this.pbpatient.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbpatient.ImeMode")));
			this.pbpatient.Location = ((System.Drawing.Point)(resources.GetObject("pbpatient.Location")));
			this.pbpatient.Name = "pbpatient";
			this.pbpatient.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbpatient.RightToLeft")));
			this.pbpatient.Size = ((System.Drawing.Size)(resources.GetObject("pbpatient.Size")));
			this.pbpatient.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbpatient.SizeMode")));
			this.pbpatient.TabIndex = ((int)(resources.GetObject("pbpatient.TabIndex")));
			this.pbpatient.TabStop = false;
			this.pbpatient.Text = resources.GetString("pbpatient.Text");
			this.toolTip1.SetToolTip(this.pbpatient, resources.GetString("pbpatient.ToolTip"));
			this.pbpatient.Visible = ((bool)(resources.GetObject("pbpatient.Visible")));
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
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
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
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// llusepatient
			// 
			this.llusepatient.AccessibleDescription = resources.GetString("llusepatient.AccessibleDescription");
			this.llusepatient.AccessibleName = resources.GetString("llusepatient.AccessibleName");
			this.llusepatient.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llusepatient.Anchor")));
			this.llusepatient.AutoSize = ((bool)(resources.GetObject("llusepatient.AutoSize")));
			this.llusepatient.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llusepatient.Dock")));
			this.llusepatient.Enabled = ((bool)(resources.GetObject("llusepatient.Enabled")));
			this.llusepatient.Font = ((System.Drawing.Font)(resources.GetObject("llusepatient.Font")));
			this.llusepatient.Image = ((System.Drawing.Image)(resources.GetObject("llusepatient.Image")));
			this.llusepatient.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llusepatient.ImageAlign")));
			this.llusepatient.ImageIndex = ((int)(resources.GetObject("llusepatient.ImageIndex")));
			this.llusepatient.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llusepatient.ImeMode")));
			this.llusepatient.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llusepatient.LinkArea")));
			this.llusepatient.Location = ((System.Drawing.Point)(resources.GetObject("llusepatient.Location")));
			this.llusepatient.Name = "llusepatient";
			this.llusepatient.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llusepatient.RightToLeft")));
			this.llusepatient.Size = ((System.Drawing.Size)(resources.GetObject("llusepatient.Size")));
			this.llusepatient.TabIndex = ((int)(resources.GetObject("llusepatient.TabIndex")));
			this.llusepatient.TabStop = true;
			this.llusepatient.Text = resources.GetString("llusepatient.Text");
			this.llusepatient.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llusepatient.TextAlign")));
			this.toolTip1.SetToolTip(this.llusepatient, resources.GetString("llusepatient.ToolTip"));
			this.llusepatient.Visible = ((bool)(resources.GetObject("llusepatient.Visible")));
			this.llusepatient.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UsePatient);
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.lbarchlife);
			this.groupBox2.Controls.Add(this.lbarchname);
			this.groupBox2.Controls.Add(this.llusearche);
			this.groupBox2.Controls.Add(this.pbarche);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Enabled = ((bool)(resources.GetObject("groupBox2.Enabled")));
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = ((System.Drawing.Font)(resources.GetObject("groupBox2.Font")));
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			// 
			// lbarchlife
			// 
			this.lbarchlife.AccessibleDescription = resources.GetString("lbarchlife.AccessibleDescription");
			this.lbarchlife.AccessibleName = resources.GetString("lbarchlife.AccessibleName");
			this.lbarchlife.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbarchlife.Anchor")));
			this.lbarchlife.AutoSize = ((bool)(resources.GetObject("lbarchlife.AutoSize")));
			this.lbarchlife.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbarchlife.Dock")));
			this.lbarchlife.Enabled = ((bool)(resources.GetObject("lbarchlife.Enabled")));
			this.lbarchlife.Font = ((System.Drawing.Font)(resources.GetObject("lbarchlife.Font")));
			this.lbarchlife.Image = ((System.Drawing.Image)(resources.GetObject("lbarchlife.Image")));
			this.lbarchlife.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbarchlife.ImageAlign")));
			this.lbarchlife.ImageIndex = ((int)(resources.GetObject("lbarchlife.ImageIndex")));
			this.lbarchlife.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbarchlife.ImeMode")));
			this.lbarchlife.Location = ((System.Drawing.Point)(resources.GetObject("lbarchlife.Location")));
			this.lbarchlife.Name = "lbarchlife";
			this.lbarchlife.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbarchlife.RightToLeft")));
			this.lbarchlife.Size = ((System.Drawing.Size)(resources.GetObject("lbarchlife.Size")));
			this.lbarchlife.TabIndex = ((int)(resources.GetObject("lbarchlife.TabIndex")));
			this.lbarchlife.Text = resources.GetString("lbarchlife.Text");
			this.lbarchlife.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbarchlife.TextAlign")));
			this.toolTip1.SetToolTip(this.lbarchlife, resources.GetString("lbarchlife.ToolTip"));
			this.lbarchlife.Visible = ((bool)(resources.GetObject("lbarchlife.Visible")));
			// 
			// lbarchname
			// 
			this.lbarchname.AccessibleDescription = resources.GetString("lbarchname.AccessibleDescription");
			this.lbarchname.AccessibleName = resources.GetString("lbarchname.AccessibleName");
			this.lbarchname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbarchname.Anchor")));
			this.lbarchname.AutoSize = ((bool)(resources.GetObject("lbarchname.AutoSize")));
			this.lbarchname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbarchname.Dock")));
			this.lbarchname.Enabled = ((bool)(resources.GetObject("lbarchname.Enabled")));
			this.lbarchname.Font = ((System.Drawing.Font)(resources.GetObject("lbarchname.Font")));
			this.lbarchname.Image = ((System.Drawing.Image)(resources.GetObject("lbarchname.Image")));
			this.lbarchname.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbarchname.ImageAlign")));
			this.lbarchname.ImageIndex = ((int)(resources.GetObject("lbarchname.ImageIndex")));
			this.lbarchname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbarchname.ImeMode")));
			this.lbarchname.Location = ((System.Drawing.Point)(resources.GetObject("lbarchname.Location")));
			this.lbarchname.Name = "lbarchname";
			this.lbarchname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbarchname.RightToLeft")));
			this.lbarchname.Size = ((System.Drawing.Size)(resources.GetObject("lbarchname.Size")));
			this.lbarchname.TabIndex = ((int)(resources.GetObject("lbarchname.TabIndex")));
			this.lbarchname.Text = resources.GetString("lbarchname.Text");
			this.lbarchname.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbarchname.TextAlign")));
			this.toolTip1.SetToolTip(this.lbarchname, resources.GetString("lbarchname.ToolTip"));
			this.lbarchname.Visible = ((bool)(resources.GetObject("lbarchname.Visible")));
			// 
			// llusearche
			// 
			this.llusearche.AccessibleDescription = resources.GetString("llusearche.AccessibleDescription");
			this.llusearche.AccessibleName = resources.GetString("llusearche.AccessibleName");
			this.llusearche.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llusearche.Anchor")));
			this.llusearche.AutoSize = ((bool)(resources.GetObject("llusearche.AutoSize")));
			this.llusearche.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llusearche.Dock")));
			this.llusearche.Enabled = ((bool)(resources.GetObject("llusearche.Enabled")));
			this.llusearche.Font = ((System.Drawing.Font)(resources.GetObject("llusearche.Font")));
			this.llusearche.Image = ((System.Drawing.Image)(resources.GetObject("llusearche.Image")));
			this.llusearche.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llusearche.ImageAlign")));
			this.llusearche.ImageIndex = ((int)(resources.GetObject("llusearche.ImageIndex")));
			this.llusearche.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llusearche.ImeMode")));
			this.llusearche.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llusearche.LinkArea")));
			this.llusearche.Location = ((System.Drawing.Point)(resources.GetObject("llusearche.Location")));
			this.llusearche.Name = "llusearche";
			this.llusearche.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llusearche.RightToLeft")));
			this.llusearche.Size = ((System.Drawing.Size)(resources.GetObject("llusearche.Size")));
			this.llusearche.TabIndex = ((int)(resources.GetObject("llusearche.TabIndex")));
			this.llusearche.TabStop = true;
			this.llusearche.Text = resources.GetString("llusearche.Text");
			this.llusearche.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llusearche.TextAlign")));
			this.toolTip1.SetToolTip(this.llusearche, resources.GetString("llusearche.ToolTip"));
			this.llusearche.Visible = ((bool)(resources.GetObject("llusearche.Visible")));
			this.llusearche.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UseArchetype);
			// 
			// pbarche
			// 
			this.pbarche.AccessibleDescription = resources.GetString("pbarche.AccessibleDescription");
			this.pbarche.AccessibleName = resources.GetString("pbarche.AccessibleName");
			this.pbarche.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbarche.Anchor")));
			this.pbarche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbarche.BackgroundImage")));
			this.pbarche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbarche.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbarche.Dock")));
			this.pbarche.Enabled = ((bool)(resources.GetObject("pbarche.Enabled")));
			this.pbarche.Font = ((System.Drawing.Font)(resources.GetObject("pbarche.Font")));
			this.pbarche.Image = ((System.Drawing.Image)(resources.GetObject("pbarche.Image")));
			this.pbarche.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbarche.ImeMode")));
			this.pbarche.Location = ((System.Drawing.Point)(resources.GetObject("pbarche.Location")));
			this.pbarche.Name = "pbarche";
			this.pbarche.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbarche.RightToLeft")));
			this.pbarche.Size = ((System.Drawing.Size)(resources.GetObject("pbarche.Size")));
			this.pbarche.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbarche.SizeMode")));
			this.pbarche.TabIndex = ((int)(resources.GetObject("pbarche.TabIndex")));
			this.pbarche.TabStop = false;
			this.pbarche.Text = resources.GetString("pbarche.Text");
			this.toolTip1.SetToolTip(this.pbarche, resources.GetString("pbarche.ToolTip"));
			this.pbarche.Visible = ((bool)(resources.GetObject("pbarche.Visible")));
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
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
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
			this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// cbface
			// 
			this.cbface.AccessibleDescription = resources.GetString("cbface.AccessibleDescription");
			this.cbface.AccessibleName = resources.GetString("cbface.AccessibleName");
			this.cbface.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbface.Anchor")));
			this.cbface.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbface.Appearance")));
			this.cbface.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbface.BackgroundImage")));
			this.cbface.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbface.CheckAlign")));
			this.cbface.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbface.Dock")));
			this.cbface.Enabled = ((bool)(resources.GetObject("cbface.Enabled")));
			this.cbface.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbface.FlatStyle")));
			this.cbface.Font = ((System.Drawing.Font)(resources.GetObject("cbface.Font")));
			this.cbface.Image = ((System.Drawing.Image)(resources.GetObject("cbface.Image")));
			this.cbface.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbface.ImageAlign")));
			this.cbface.ImageIndex = ((int)(resources.GetObject("cbface.ImageIndex")));
			this.cbface.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbface.ImeMode")));
			this.cbface.Location = ((System.Drawing.Point)(resources.GetObject("cbface.Location")));
			this.cbface.Name = "cbface";
			this.cbface.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbface.RightToLeft")));
			this.cbface.Size = ((System.Drawing.Size)(resources.GetObject("cbface.Size")));
			this.cbface.TabIndex = ((int)(resources.GetObject("cbface.TabIndex")));
			this.cbface.Text = resources.GetString("cbface.Text");
			this.cbface.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbface.TextAlign")));
			this.toolTip1.SetToolTip(this.cbface, resources.GetString("cbface.ToolTip"));
			this.cbface.Visible = ((bool)(resources.GetObject("cbface.Visible")));
			// 
			// cbskin
			// 
			this.cbskin.AccessibleDescription = resources.GetString("cbskin.AccessibleDescription");
			this.cbskin.AccessibleName = resources.GetString("cbskin.AccessibleName");
			this.cbskin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbskin.Anchor")));
			this.cbskin.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbskin.Appearance")));
			this.cbskin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbskin.BackgroundImage")));
			this.cbskin.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbskin.CheckAlign")));
			this.cbskin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbskin.Dock")));
			this.cbskin.Enabled = ((bool)(resources.GetObject("cbskin.Enabled")));
			this.cbskin.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbskin.FlatStyle")));
			this.cbskin.Font = ((System.Drawing.Font)(resources.GetObject("cbskin.Font")));
			this.cbskin.Image = ((System.Drawing.Image)(resources.GetObject("cbskin.Image")));
			this.cbskin.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbskin.ImageAlign")));
			this.cbskin.ImageIndex = ((int)(resources.GetObject("cbskin.ImageIndex")));
			this.cbskin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbskin.ImeMode")));
			this.cbskin.Location = ((System.Drawing.Point)(resources.GetObject("cbskin.Location")));
			this.cbskin.Name = "cbskin";
			this.cbskin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbskin.RightToLeft")));
			this.cbskin.Size = ((System.Drawing.Size)(resources.GetObject("cbskin.Size")));
			this.cbskin.TabIndex = ((int)(resources.GetObject("cbskin.TabIndex")));
			this.cbskin.Text = resources.GetString("cbskin.Text");
			this.cbskin.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbskin.TextAlign")));
			this.toolTip1.SetToolTip(this.cbskin, resources.GetString("cbskin.ToolTip"));
			this.cbskin.Visible = ((bool)(resources.GetObject("cbskin.Visible")));
			// 
			// llexport
			// 
			this.llexport.AccessibleDescription = resources.GetString("llexport.AccessibleDescription");
			this.llexport.AccessibleName = resources.GetString("llexport.AccessibleName");
			this.llexport.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llexport.Anchor")));
			this.llexport.AutoSize = ((bool)(resources.GetObject("llexport.AutoSize")));
			this.llexport.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llexport.Dock")));
			this.llexport.Enabled = ((bool)(resources.GetObject("llexport.Enabled")));
			this.llexport.Font = ((System.Drawing.Font)(resources.GetObject("llexport.Font")));
			this.llexport.Image = ((System.Drawing.Image)(resources.GetObject("llexport.Image")));
			this.llexport.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llexport.ImageAlign")));
			this.llexport.ImageIndex = ((int)(resources.GetObject("llexport.ImageIndex")));
			this.llexport.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llexport.ImeMode")));
			this.llexport.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llexport.LinkArea")));
			this.llexport.Location = ((System.Drawing.Point)(resources.GetObject("llexport.Location")));
			this.llexport.Name = "llexport";
			this.llexport.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llexport.RightToLeft")));
			this.llexport.Size = ((System.Drawing.Size)(resources.GetObject("llexport.Size")));
			this.llexport.TabIndex = ((int)(resources.GetObject("llexport.TabIndex")));
			this.llexport.TabStop = true;
			this.llexport.Text = resources.GetString("llexport.Text");
			this.llexport.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llexport.TextAlign")));
			this.toolTip1.SetToolTip(this.llexport, resources.GetString("llexport.ToolTip"));
			this.llexport.Visible = ((bool)(resources.GetObject("llexport.Visible")));
			this.llexport.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Export);
			// 
			// sfd
			// 
			this.sfd.Filter = resources.GetString("sfd.Filter");
			this.sfd.Title = resources.GetString("sfd.Title");
			// 
			// toolTip1
			// 
			this.toolTip1.AutoPopDelay = 30000;
			this.toolTip1.InitialDelay = 500;
			this.toolTip1.ReshowDelay = 100;
			// 
			// Surgery
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.cbskin);
			this.Controls.Add(this.cbface);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Surgery";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.ShowInTaskbar = false;
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected void AddImage(SimPe.PackedFiles.Wrapper.SDesc sdesc) 
		{
			if (sdesc.Image!=null) 
			{
				if ((sdesc.Unlinked!=0x00) || (!sdesc.AvailableCharacterData))
				{
					Image img = (Image)sdesc.Image.Clone();
					System.Drawing.Graphics g = Graphics.FromImage(img);
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

					Pen pen = new Pen(Data.MetaData.SpecialSimColor, 3);

					g.FillRectangle(pen.Brush, 0, 0, img.Width, img.Height);

					int pos = 2;
					if (sdesc.Unlinked!=0x00) 
					{
						g.FillRectangle(new Pen(Data.MetaData.UnlinkedSim, 1).Brush, pos, 2, 25, 25);
						pos += 28;
					}
					if (!sdesc.AvailableCharacterData) 
					{
						g.FillRectangle(new Pen(Data.MetaData.InactiveSim, 1).Brush, pos, 2, 25, 25);
						pos += 28;
					}

					this.ilist.Images.Add(img);
				} 
				else 
				{
					this.ilist.Images.Add(sdesc.Image);
				}
			} 
			else 
			{
				this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")));
			}
		}

		protected void AddSim(SimPe.PackedFiles.Wrapper.SDesc sdesc) 
		{
			if (!sdesc.HasImage) return;
			if (!sdesc.AvailableCharacterData) return;

			AddImage(sdesc);
			ListViewItem lvi = new ListViewItem();
			lvi.Text = sdesc.SimName +" "+sdesc.SimFamilyName;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.Tag = sdesc;

			lv.Items.Add(lvi);
		}

		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		Interfaces.IProviderRegistry prov;
		public Interfaces.Plugin.IToolResult Execute(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov) 
		{
			this.Cursor = Cursors.WaitCursor;
			
			this.pfd = null;
			this.prov = prov;
			ilist.Images.Clear();
			lv.Items.Clear();

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			foreach(Interfaces.Files.IPackedFileDescriptor spfd in pfds) 
			{
				WaitingScreen.Wait();
				PackedFiles.Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(prov.SimNameProvider, prov.SimFamilynameProvider, null);
				sdesc.ProcessData(spfd, package);
				
				//WaitingScreen.UpdateImage(ImageLoader.Preview(sdesc.Image, new Size(64, 64)));
				AddSim(sdesc);
			}

			this.Cursor = Cursors.Default;
			this.llusearche.Enabled = false;
			this.llusepatient.Enabled = false;
			this.llexport.Enabled = false;
			button1.Enabled = false;
			if (lv.Items.Count>0) lv.Items[0].Selected = true;

			WaitingScreen.Stop();
			ShowDialog();

			if (this.pfd!=null) pfd = this.pfd;
			return new Plugin.ToolResult((this.pfd!=null), false);
		}

		private void Open(object sender, System.EventArgs e)
		{
			if ((pbpatient.Image==null) || (pbarche.Image==null)) return;
			
			if ((!this.cbface.Checked) && (!this.cbskin.Checked)) PractiseSurgery();

			if (this.cbskin.Checked) SkinToneSurgery();
			if (this.cbface.Checked) FaceSurgery();
			Close();
		}

		private void SelectSim(object sender, System.EventArgs e)
		{
			this.llusearche.Enabled = false;
			this.llusepatient.Enabled = false;
			if (lv.SelectedItems.Count==0) return;
			this.llusearche.Enabled = true;
			this.llusepatient.Enabled = true;
		}

		SimPe.PackedFiles.Wrapper.SDesc spatient = null;
		SimPe.PackedFiles.Wrapper.SDesc sarche = null;
		private void UsePatient(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.llexport.Enabled = (spatient!=null);
			if (lv.SelectedItems.Count==0) return;
			if (lv.SelectedItems[0].ImageIndex>=0) pbpatient.Image = ilist.Images[lv.SelectedItems[0].ImageIndex];

			this.lbpatname.Text = lv.SelectedItems[0].Text;
			
			spatient = (SimPe.PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
			lbpatlife.Text = spatient.CharacterDescription.LifeSection.ToString();
			lbpatlife.Text += ", " + spatient.CharacterDescription.Gender.ToString();

			button1.Enabled =  (pbpatient.Image!=null) && (pbarche.Image!=null);
			pfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)spatient.FileDescriptor;
			this.llexport.Enabled = (spatient!=null);
		}

		private void UseArchetype(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;
			if (lv.SelectedItems[0].ImageIndex>=0) this.pbarche.Image = ilist.Images[lv.SelectedItems[0].ImageIndex];

			this.lbarchname.Text = lv.SelectedItems[0].Text;
			
			sarche = (SimPe.PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
			lbarchlife.Text = sarche.CharacterDescription.LifeSection.ToString();
			lbarchlife.Text += ", " + sarche.CharacterDescription.Gender.ToString();

			button1.Enabled =  (pbpatient.Image!=null) && (pbarche.Image!=null);
		}

		protected void FaceSurgery()
		{
			try 
			{
				SimPe.Packages.GeneratableFile patient = new SimPe.Packages.GeneratableFile(spatient.CharacterFileName);
				SimPe.Packages.File archetype = new SimPe.Packages.File(sarche.CharacterFileName);

				//Load Facial Data
				Interfaces.Files.IPackedFileDescriptor[] apfds = archetype.FindFiles(0xCCCEF852); //LxNR, Face
				if (apfds.Length==0) return;
				Interfaces.Files.IPackedFile file = archetype.Read(apfds[0]);

				Interfaces.Files.IPackedFileDescriptor[] ppfds = patient.FindFiles(0xCCCEF852); //LxNR, Face
				if (ppfds.Length==0) return;

				ppfds[0].UserData = file.UncompressedData;

#if DEBUG
				//Load Shape Data
				/*apfds = archetype.FindFiles(0xFC6EB1F7); //SHPE
				if (apfds.Length==0) return;
				file = archetype.Read(apfds[0]);

				ppfds = patient.FindFiles(0xFC6EB1F7); //SHPE
				if (ppfds.Length==0) return;

				ppfds[0].UserData = file.UncompressedData;*/
#endif
				
				//System.IO.MemoryStream ms = patient.Build();
				//patient.Reader.Close();
				patient.Save(spatient.CharacterFileName);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to update the new Character Package.", ex);
			}
		}

		protected void SkinToneSurgery()
		{
			try 
			{
				SimPe.Packages.GeneratableFile patient = new SimPe.Packages.GeneratableFile(spatient.CharacterFileName);
				SimPe.Packages.File archetype = new SimPe.Packages.File(sarche.CharacterFileName);

				//get SkinTone Value from the age Data in the archetype
				Interfaces.Files.IPackedFileDescriptor[] ageds = archetype.FindFiles(0xAC598EAC);
				if (ageds.Length==0) return;
				SimPe.PackedFiles.Wrapper.Cpf aged = new SimPe.PackedFiles.Wrapper.Cpf();
				aged.ProcessData(ageds[0], archetype);
				SimPe.PackedFiles.Wrapper.CpfItem skintone = aged.GetItem("skincolor");
				if (skintone==null) return;

				//set Siknintone in Property sets and Age Data of patient
				Interfaces.Files.IPackedFileDescriptor[] pageds = patient.FindFiles(0xAC598EAC);
				Interfaces.Files.IPackedFileDescriptor[] pprops = patient.FindFiles(0xEBCF3E27);

				foreach (Interfaces.Files.IPackedFileDescriptor paged in pageds) 
				{
					SimPe.PackedFiles.Wrapper.Cpf flaged = new SimPe.PackedFiles.Wrapper.Cpf();
					flaged.ProcessData(paged, patient);

					SimPe.PackedFiles.Wrapper.CpfItem item = flaged.GetItem("skincolor");
					if (item!=null) item.StringValue = skintone.StringValue;
					flaged.SynchronizeUserData();
				}

				foreach (Interfaces.Files.IPackedFileDescriptor pprop in pprops) 
				{
					SimPe.PackedFiles.Wrapper.Cpf flprop = new SimPe.PackedFiles.Wrapper.Cpf();
					flprop.ProcessData(pprop, patient);

					SimPe.PackedFiles.Wrapper.CpfItem item = flprop.GetItem("skintone");
					if (item!=null) item.StringValue = skintone.StringValue;
					flprop.SynchronizeUserData();
				}

				//now we need to load the Refernce File (3IDR)
				SimPe.Plugin.RefFile aref = new SimPe.Plugin.RefFile(this.prov);
				Interfaces.Files.IPackedFileDescriptor apfd = archetype.FindFile(0xAC506764, 0, 0xffffffff, 0x1);
				aref.ProcessData(apfd, archetype);

				SimPe.Plugin.RefFile pref = new SimPe.Plugin.RefFile(this.prov);
				Interfaces.Files.IPackedFileDescriptor ppfd = patient.FindFile(0xAC506764, 0, 0xffffffff, 0x1);
				pref.ProcessData(ppfd, patient);

				//remove all unneeded skins and replace the first found skins with the one from the archetype
				int index = 0;
				for (int i=0; i<pref.Items.Length; i++) 
				{
					SimPe.Packages.PackedFileDescriptor pfd = (SimPe.Packages.PackedFileDescriptor)pref.Items[i];
					SimPe.Plugin.RefFileItem item = new SimPe.Plugin.RefFileItem(pfd, pref);

					//found a matching Skin
					if ((item.Category & 0x80) == 0x80) 
					{
						int found = 0;
						bool check = false;
						for (int k=0; k<aref.Items.Length; k++) 
						{
							SimPe.Plugin.RefFileItem aitem = new SimPe.Plugin.RefFileItem(aref.Items[k], aref);
							if ((aitem.Category & 0x80) == 0x80) 
							{
								if (found==index) 
								{
									item.Group = aitem.Group;
									item.SubType = aitem.SubType;
									item.Type = aitem.Type;
									item.Instance = aitem.Instance;

									pfd.Group = aitem.Group;
									pfd.SubType = aitem.SubType;
									pfd.Type = aitem.Type;
									pfd.Instance = aitem.Instance;
									check = true;
									break;
								} 
								else 
								{
									found++;
								}
							}
						} // for k
						if ((index>=3) && (!check)) 
						{
							item.Group = 0;
							item.SubType = 0;
							item.Type = 0;
							item.Instance = 0;
						}
						index++;
					}
				}//for i

				pref.SynchronizeUserData();
				//System.IO.MemoryStream ms = patient.Build();
				//patient.Reader.Close();
				patient.Save(spatient.CharacterFileName);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to update the new Character Package.", ex);
			}
		}

		protected void PractiseSurgery()
		{
			try 
			{
				//open and create all needed Packages
				SimPe.Packages.GeneratableFile newpackage = new SimPe.Packages.GeneratableFile((System.IO.BinaryReader)null);
				SimPe.Packages.File patient = new SimPe.Packages.File(spatient.CharacterFileName);
				SimPe.Packages.File archetype = new SimPe.Packages.File(sarche.CharacterFileName);

				//list of all Files top copy from the Archetype
				ArrayList list = new ArrayList();
				list.Add((uint)0xAC506764); //3IDR
				list.Add((uint)0xE519C933); //CRES
				list.Add((uint)0xEBCF3E27); //GZPS, Property Set
				list.Add((uint)0xAC598EAC); //AGED
				list.Add((uint)0xCCCEF852); //LxNR, Face
				list.Add((uint)0x856DDBAC); //IMG
				list.Add((uint)0x534C4F54); //SLOT
				list.Add((uint)0xAC4F8687); //GMDC
				list.Add((uint)0x7BA3838C); //GMND				
				list.Add((uint)0x49596978); //MATD
				list.Add((uint)0xFC6EB1F7); //SHPE

				//get all Files of the above group from the archetype to the new
				foreach (uint type in list)
				{
					Interfaces.Files.IPackedFileDescriptor[] pfds = archetype.FindFiles(type);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
					{
						SimPe.Interfaces.Files.IPackedFile file = archetype.Read(pfd);
						pfd.UserData = file.UncompressedData;
						newpackage.Add(pfd);
					}
				}
				
				//do not copy the compresed File Dir 
				list.Add((uint)0xE86B1EEF);	//Compressed File Directory

				//now get everything else from the Patient
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in patient.Index)
				{
					if (!list.Contains((uint)pfd.Type)) 
					{
						SimPe.Interfaces.Files.IPackedFile file = patient.Read(pfd);
						pfd.UserData = file.UncompressedData;
						newpackage.Add(pfd);
					}
				}

				//patient.Reader.Close();
				patient = null;
				newpackage.Save(/*newpackage.Build(),*/ spatient.CharacterFileName);
				prov.SimNameProvider.StoredData = null;
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("Unable to create the new Character Package.", ex);
			}
		}

		private void Export(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (spatient==null) return;


			try 
			{
				//list of all Files top copy from the Archetype
				ArrayList list = new ArrayList();
				list.Add((uint)0xAC506764); //3IDR
				list.Add((uint)0xE519C933); //CRES
				list.Add((uint)0xEBCF3E27); //GZPS, Property Set
				list.Add((uint)0xAC598EAC); //AGED
				list.Add((uint)0xCCCEF852); //LxNR, Face
				list.Add((uint)0x0C560F39); //BINX
				list.Add((uint)0xAC4F8687); //GMDC
				list.Add((uint)0x7BA3838C); //GMND				
				list.Add((uint)0x49596978); //MATD
				list.Add((uint)0xFC6EB1F7); //SHPE

				System.IO.BinaryReader br1 = new System.IO.BinaryReader(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.3d.simpe"));
				System.IO.BinaryReader br2 = new System.IO.BinaryReader(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.bin.simpe"));

				SimPe.Packages.PackedFileDescriptor pfd1 = new SimPe.Packages.PackedFileDescriptor();
				pfd1.Group = 0xffffffff; pfd1.SubType = 0x00000000; pfd1.Instance = 0xFF123456; pfd1.Type = 0xAC506764; //3IDR
				pfd1.UserData = br1.ReadBytes((int)br1.BaseStream.Length);

				SimPe.Packages.PackedFileDescriptor pfd2 = new SimPe.Packages.PackedFileDescriptor();
				pfd2.Group = 0xffffffff; pfd2.SubType = 0x00000000; pfd2.Instance = 0xFF123456; pfd2.Type = 0x0C560F39; //BINX
				pfd2.UserData = br2.ReadBytes((int)br2.BaseStream.Length);

				sfd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "SavedSims");
				sfd.FileName = System.IO.Path.GetFileNameWithoutExtension(spatient.CharacterFileName);

				SimPe.Packages.GeneratableFile source = new SimPe.Packages.GeneratableFile(spatient.CharacterFileName);
				if (sfd.ShowDialog()==DialogResult.OK) 
				{
					SimPe.Packages.GeneratableFile patient = new SimPe.Packages.GeneratableFile((System.IO.BinaryReader)null);
					patient.FileName = "";
					patient.Add(pfd1);
					patient.Add(pfd2);

					foreach (Interfaces.Files.IPackedFileDescriptor pfd in source.Index) 
					{
						if (list.Contains(pfd.Type)) 
						{
							Interfaces.Files.IPackedFile file = source.Read(pfd);
							pfd.UserData = file.UncompressedData;
							patient.Add(pfd);
						}
					}

					patient.Save(sfd.FileName);
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
			
		}
	}
}
