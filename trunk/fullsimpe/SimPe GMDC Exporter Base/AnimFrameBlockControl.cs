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

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Zusammenfassung für AnimFrameBlockControl.
	/// </summary>
	public class AnimFrameBlockControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn1;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn2;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn3;
		private System.Windows.Forms.Panel pnSplit1;
		private System.Windows.Forms.Panel pnSplit2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.LinkLabel llClear;
		private System.Windows.Forms.LinkLabel llAdd;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox tbTimeCode;
		private System.Windows.Forms.Label lbTimeCode;
		private System.Windows.Forms.LinkLabel llRefresh;
		private System.Windows.Forms.LinkLabel llClone;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem miExp;
		private System.Windows.Forms.MenuItem miRem;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnimFrameBlockControl()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();

			tm.AddControl(splitter1);
			panel1.BackColor = splitter1.BackColor;
			panel3.BackColor = splitter1.BackColor;
			panel6.BackColor = splitter1.BackColor;
			Clear();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnimFrameBlockControl));
			this.tv = new System.Windows.Forms.TreeView();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.miExp = new System.Windows.Forms.MenuItem();
			this.miRem = new System.Windows.Forms.MenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pn3 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.pnSplit2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pn2 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.pnSplit1 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pn1 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.llClone = new System.Windows.Forms.LinkLabel();
			this.llRefresh = new System.Windows.Forms.LinkLabel();
			this.lbTimeCode = new System.Windows.Forms.Label();
			this.tbTimeCode = new System.Windows.Forms.TextBox();
			this.llAdd = new System.Windows.Forms.LinkLabel();
			this.llClear = new System.Windows.Forms.LinkLabel();
			this.panel2.SuspendLayout();
			this.pnSplit2.SuspendLayout();
			this.pnSplit1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv
			// 
			this.tv.AccessibleDescription = resources.GetString("tv.AccessibleDescription");
			this.tv.AccessibleName = resources.GetString("tv.AccessibleName");
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tv.Anchor")));
			this.tv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tv.BackgroundImage")));
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tv.ContextMenu = this.contextMenu1;
			this.tv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tv.Dock")));
			this.tv.Enabled = ((bool)(resources.GetObject("tv.Enabled")));
			this.tv.Font = ((System.Drawing.Font)(resources.GetObject("tv.Font")));
			this.tv.HideSelection = false;
			this.tv.ImageIndex = ((int)(resources.GetObject("tv.ImageIndex")));
			this.tv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tv.ImeMode")));
			this.tv.Indent = ((int)(resources.GetObject("tv.Indent")));
			this.tv.ItemHeight = ((int)(resources.GetObject("tv.ItemHeight")));
			this.tv.Location = ((System.Drawing.Point)(resources.GetObject("tv.Location")));
			this.tv.Name = "tv";
			this.tv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tv.RightToLeft")));
			this.tv.SelectedImageIndex = ((int)(resources.GetObject("tv.SelectedImageIndex")));
			this.tv.Size = ((System.Drawing.Size)(resources.GetObject("tv.Size")));
			this.tv.TabIndex = ((int)(resources.GetObject("tv.TabIndex")));
			this.tv.Text = resources.GetString("tv.Text");
			this.tv.Visible = ((bool)(resources.GetObject("tv.Visible")));
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.miExp,
																						 this.miRem});
			this.contextMenu1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("contextMenu1.RightToLeft")));
			// 
			// miExp
			// 
			this.miExp.Enabled = ((bool)(resources.GetObject("miExp.Enabled")));
			this.miExp.Index = 0;
			this.miExp.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miExp.Shortcut")));
			this.miExp.ShowShortcut = ((bool)(resources.GetObject("miExp.ShowShortcut")));
			this.miExp.Text = resources.GetString("miExp.Text");
			this.miExp.Visible = ((bool)(resources.GetObject("miExp.Visible")));
			this.miExp.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// miRem
			// 
			this.miRem.Enabled = ((bool)(resources.GetObject("miRem.Enabled")));
			this.miRem.Index = 1;
			this.miRem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRem.Shortcut")));
			this.miRem.ShowShortcut = ((bool)(resources.GetObject("miRem.ShowShortcut")));
			this.miRem.Text = resources.GetString("miRem.Text");
			this.miRem.Visible = ((bool)(resources.GetObject("miRem.Visible")));
			this.miRem.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitter1.BackgroundImage")));
			this.splitter1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitter1.Dock")));
			this.splitter1.Enabled = ((bool)(resources.GetObject("splitter1.Enabled")));
			this.splitter1.Font = ((System.Drawing.Font)(resources.GetObject("splitter1.Font")));
			this.splitter1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitter1.ImeMode")));
			this.splitter1.Location = ((System.Drawing.Point)(resources.GetObject("splitter1.Location")));
			this.splitter1.MinExtra = ((int)(resources.GetObject("splitter1.MinExtra")));
			this.splitter1.MinSize = ((int)(resources.GetObject("splitter1.MinSize")));
			this.splitter1.Name = "splitter1";
			this.splitter1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitter1.RightToLeft")));
			this.splitter1.Size = ((System.Drawing.Size)(resources.GetObject("splitter1.Size")));
			this.splitter1.TabIndex = ((int)(resources.GetObject("splitter1.TabIndex")));
			this.splitter1.TabStop = false;
			this.splitter1.Visible = ((bool)(resources.GetObject("splitter1.Visible")));
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.pn3);
			this.panel2.Controls.Add(this.pnSplit2);
			this.panel2.Controls.Add(this.pn2);
			this.panel2.Controls.Add(this.pnSplit1);
			this.panel2.Controls.Add(this.pn1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.DockPadding.Left = 8;
			this.panel2.DockPadding.Right = 8;
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// pn3
			// 
			this.pn3.AccessibleDescription = resources.GetString("pn3.AccessibleDescription");
			this.pn3.AccessibleName = resources.GetString("pn3.AccessibleName");
			this.pn3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pn3.Anchor")));
			this.pn3.AutoScroll = ((bool)(resources.GetObject("pn3.AutoScroll")));
			this.pn3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pn3.AutoScrollMargin")));
			this.pn3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pn3.AutoScrollMinSize")));
			this.pn3.AxisTransform = null;
			this.pn3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn3.BackgroundImage")));
			this.pn3.CanCreate = false;
			this.pn3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pn3.Dock")));
			this.pn3.Enabled = ((bool)(resources.GetObject("pn3.Enabled")));
			this.pn3.Font = ((System.Drawing.Font)(resources.GetObject("pn3.Font")));
			this.pn3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pn3.ImeMode")));
			this.pn3.Location = ((System.Drawing.Point)(resources.GetObject("pn3.Location")));
			this.pn3.Name = "pn3";
			this.pn3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pn3.RightToLeft")));
			this.pn3.Size = ((System.Drawing.Size)(resources.GetObject("pn3.Size")));
			this.pn3.TabIndex = ((int)(resources.GetObject("pn3.TabIndex")));
			this.pn3.Visible = ((bool)(resources.GetObject("pn3.Visible")));
			this.pn3.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn3.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn3.VisibleChanged += new System.EventHandler(this.pn3_VisibleChanged);
			this.pn3.CreateClicked += new System.EventHandler(this.pn3_CreateClicked);
			// 
			// pnSplit2
			// 
			this.pnSplit2.AccessibleDescription = resources.GetString("pnSplit2.AccessibleDescription");
			this.pnSplit2.AccessibleName = resources.GetString("pnSplit2.AccessibleName");
			this.pnSplit2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSplit2.Anchor")));
			this.pnSplit2.AutoScroll = ((bool)(resources.GetObject("pnSplit2.AutoScroll")));
			this.pnSplit2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSplit2.AutoScrollMargin")));
			this.pnSplit2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSplit2.AutoScrollMinSize")));
			this.pnSplit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSplit2.BackgroundImage")));
			this.pnSplit2.Controls.Add(this.panel3);
			this.pnSplit2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSplit2.Dock")));
			this.pnSplit2.Enabled = ((bool)(resources.GetObject("pnSplit2.Enabled")));
			this.pnSplit2.Font = ((System.Drawing.Font)(resources.GetObject("pnSplit2.Font")));
			this.pnSplit2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSplit2.ImeMode")));
			this.pnSplit2.Location = ((System.Drawing.Point)(resources.GetObject("pnSplit2.Location")));
			this.pnSplit2.Name = "pnSplit2";
			this.pnSplit2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSplit2.RightToLeft")));
			this.pnSplit2.Size = ((System.Drawing.Size)(resources.GetObject("pnSplit2.Size")));
			this.pnSplit2.TabIndex = ((int)(resources.GetObject("pnSplit2.TabIndex")));
			this.pnSplit2.Text = resources.GetString("pnSplit2.Text");
			this.pnSplit2.Visible = ((bool)(resources.GetObject("pnSplit2.Visible")));
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			// 
			// pn2
			// 
			this.pn2.AccessibleDescription = resources.GetString("pn2.AccessibleDescription");
			this.pn2.AccessibleName = resources.GetString("pn2.AccessibleName");
			this.pn2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pn2.Anchor")));
			this.pn2.AutoScroll = ((bool)(resources.GetObject("pn2.AutoScroll")));
			this.pn2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pn2.AutoScrollMargin")));
			this.pn2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pn2.AutoScrollMinSize")));
			this.pn2.AxisTransform = null;
			this.pn2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn2.BackgroundImage")));
			this.pn2.CanCreate = false;
			this.pn2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pn2.Dock")));
			this.pn2.Enabled = ((bool)(resources.GetObject("pn2.Enabled")));
			this.pn2.Font = ((System.Drawing.Font)(resources.GetObject("pn2.Font")));
			this.pn2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pn2.ImeMode")));
			this.pn2.Location = ((System.Drawing.Point)(resources.GetObject("pn2.Location")));
			this.pn2.Name = "pn2";
			this.pn2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pn2.RightToLeft")));
			this.pn2.Size = ((System.Drawing.Size)(resources.GetObject("pn2.Size")));
			this.pn2.TabIndex = ((int)(resources.GetObject("pn2.TabIndex")));
			this.pn2.Visible = ((bool)(resources.GetObject("pn2.Visible")));
			this.pn2.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn2.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn2.VisibleChanged += new System.EventHandler(this.pn2_VisibleChanged);
			this.pn2.CreateClicked += new System.EventHandler(this.pn2_CreateClicked);
			// 
			// pnSplit1
			// 
			this.pnSplit1.AccessibleDescription = resources.GetString("pnSplit1.AccessibleDescription");
			this.pnSplit1.AccessibleName = resources.GetString("pnSplit1.AccessibleName");
			this.pnSplit1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSplit1.Anchor")));
			this.pnSplit1.AutoScroll = ((bool)(resources.GetObject("pnSplit1.AutoScroll")));
			this.pnSplit1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSplit1.AutoScrollMargin")));
			this.pnSplit1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSplit1.AutoScrollMinSize")));
			this.pnSplit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSplit1.BackgroundImage")));
			this.pnSplit1.Controls.Add(this.panel1);
			this.pnSplit1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSplit1.Dock")));
			this.pnSplit1.Enabled = ((bool)(resources.GetObject("pnSplit1.Enabled")));
			this.pnSplit1.Font = ((System.Drawing.Font)(resources.GetObject("pnSplit1.Font")));
			this.pnSplit1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSplit1.ImeMode")));
			this.pnSplit1.Location = ((System.Drawing.Point)(resources.GetObject("pnSplit1.Location")));
			this.pnSplit1.Name = "pnSplit1";
			this.pnSplit1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSplit1.RightToLeft")));
			this.pnSplit1.Size = ((System.Drawing.Size)(resources.GetObject("pnSplit1.Size")));
			this.pnSplit1.TabIndex = ((int)(resources.GetObject("pnSplit1.TabIndex")));
			this.pnSplit1.Text = resources.GetString("pnSplit1.Text");
			this.pnSplit1.Visible = ((bool)(resources.GetObject("pnSplit1.Visible")));
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
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
			// pn1
			// 
			this.pn1.AccessibleDescription = resources.GetString("pn1.AccessibleDescription");
			this.pn1.AccessibleName = resources.GetString("pn1.AccessibleName");
			this.pn1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pn1.Anchor")));
			this.pn1.AutoScroll = ((bool)(resources.GetObject("pn1.AutoScroll")));
			this.pn1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pn1.AutoScrollMargin")));
			this.pn1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pn1.AutoScrollMinSize")));
			this.pn1.AxisTransform = null;
			this.pn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pn1.BackgroundImage")));
			this.pn1.CanCreate = false;
			this.pn1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pn1.Dock")));
			this.pn1.Enabled = ((bool)(resources.GetObject("pn1.Enabled")));
			this.pn1.Font = ((System.Drawing.Font)(resources.GetObject("pn1.Font")));
			this.pn1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pn1.ImeMode")));
			this.pn1.Location = ((System.Drawing.Point)(resources.GetObject("pn1.Location")));
			this.pn1.Name = "pn1";
			this.pn1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pn1.RightToLeft")));
			this.pn1.Size = ((System.Drawing.Size)(resources.GetObject("pn1.Size")));
			this.pn1.TabIndex = ((int)(resources.GetObject("pn1.TabIndex")));
			this.pn1.Visible = ((bool)(resources.GetObject("pn1.Visible")));
			this.pn1.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn1.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn1.CreateClicked += new System.EventHandler(this.pn1_CreateClicked);
			// 
			// panel5
			// 
			this.panel5.AccessibleDescription = resources.GetString("panel5.AccessibleDescription");
			this.panel5.AccessibleName = resources.GetString("panel5.AccessibleName");
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel5.Anchor")));
			this.panel5.AutoScroll = ((bool)(resources.GetObject("panel5.AutoScroll")));
			this.panel5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMargin")));
			this.panel5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMinSize")));
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel5.Dock")));
			this.panel5.Enabled = ((bool)(resources.GetObject("panel5.Enabled")));
			this.panel5.Font = ((System.Drawing.Font)(resources.GetObject("panel5.Font")));
			this.panel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel5.ImeMode")));
			this.panel5.Location = ((System.Drawing.Point)(resources.GetObject("panel5.Location")));
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel5.RightToLeft")));
			this.panel5.Size = ((System.Drawing.Size)(resources.GetObject("panel5.Size")));
			this.panel5.TabIndex = ((int)(resources.GetObject("panel5.TabIndex")));
			this.panel5.Text = resources.GetString("panel5.Text");
			this.panel5.Visible = ((bool)(resources.GetObject("panel5.Visible")));
			// 
			// panel6
			// 
			this.panel6.AccessibleDescription = resources.GetString("panel6.AccessibleDescription");
			this.panel6.AccessibleName = resources.GetString("panel6.AccessibleName");
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel6.Anchor")));
			this.panel6.AutoScroll = ((bool)(resources.GetObject("panel6.AutoScroll")));
			this.panel6.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMargin")));
			this.panel6.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMinSize")));
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel6.Dock")));
			this.panel6.Enabled = ((bool)(resources.GetObject("panel6.Enabled")));
			this.panel6.Font = ((System.Drawing.Font)(resources.GetObject("panel6.Font")));
			this.panel6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel6.ImeMode")));
			this.panel6.Location = ((System.Drawing.Point)(resources.GetObject("panel6.Location")));
			this.panel6.Name = "panel6";
			this.panel6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel6.RightToLeft")));
			this.panel6.Size = ((System.Drawing.Size)(resources.GetObject("panel6.Size")));
			this.panel6.TabIndex = ((int)(resources.GetObject("panel6.TabIndex")));
			this.panel6.Text = resources.GetString("panel6.Text");
			this.panel6.Visible = ((bool)(resources.GetObject("panel6.Visible")));
			// 
			// panel4
			// 
			this.panel4.AccessibleDescription = resources.GetString("panel4.AccessibleDescription");
			this.panel4.AccessibleName = resources.GetString("panel4.AccessibleName");
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel4.Anchor")));
			this.panel4.AutoScroll = ((bool)(resources.GetObject("panel4.AutoScroll")));
			this.panel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMargin")));
			this.panel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMinSize")));
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Controls.Add(this.llClone);
			this.panel4.Controls.Add(this.llRefresh);
			this.panel4.Controls.Add(this.lbTimeCode);
			this.panel4.Controls.Add(this.tbTimeCode);
			this.panel4.Controls.Add(this.llAdd);
			this.panel4.Controls.Add(this.llClear);
			this.panel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel4.Dock")));
			this.panel4.Enabled = ((bool)(resources.GetObject("panel4.Enabled")));
			this.panel4.Font = ((System.Drawing.Font)(resources.GetObject("panel4.Font")));
			this.panel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel4.ImeMode")));
			this.panel4.Location = ((System.Drawing.Point)(resources.GetObject("panel4.Location")));
			this.panel4.Name = "panel4";
			this.panel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel4.RightToLeft")));
			this.panel4.Size = ((System.Drawing.Size)(resources.GetObject("panel4.Size")));
			this.panel4.TabIndex = ((int)(resources.GetObject("panel4.TabIndex")));
			this.panel4.Text = resources.GetString("panel4.Text");
			this.panel4.Visible = ((bool)(resources.GetObject("panel4.Visible")));
			// 
			// llClone
			// 
			this.llClone.AccessibleDescription = resources.GetString("llClone.AccessibleDescription");
			this.llClone.AccessibleName = resources.GetString("llClone.AccessibleName");
			this.llClone.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llClone.Anchor")));
			this.llClone.AutoSize = ((bool)(resources.GetObject("llClone.AutoSize")));
			this.llClone.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llClone.Dock")));
			this.llClone.Enabled = ((bool)(resources.GetObject("llClone.Enabled")));
			this.llClone.Font = ((System.Drawing.Font)(resources.GetObject("llClone.Font")));
			this.llClone.Image = ((System.Drawing.Image)(resources.GetObject("llClone.Image")));
			this.llClone.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llClone.ImageAlign")));
			this.llClone.ImageIndex = ((int)(resources.GetObject("llClone.ImageIndex")));
			this.llClone.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llClone.ImeMode")));
			this.llClone.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llClone.LinkArea")));
			this.llClone.Location = ((System.Drawing.Point)(resources.GetObject("llClone.Location")));
			this.llClone.Name = "llClone";
			this.llClone.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llClone.RightToLeft")));
			this.llClone.Size = ((System.Drawing.Size)(resources.GetObject("llClone.Size")));
			this.llClone.TabIndex = ((int)(resources.GetObject("llClone.TabIndex")));
			this.llClone.TabStop = true;
			this.llClone.Text = resources.GetString("llClone.Text");
			this.llClone.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llClone.TextAlign")));
			this.llClone.Visible = ((bool)(resources.GetObject("llClone.Visible")));
			this.llClone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClone_LinkClicked);
			// 
			// llRefresh
			// 
			this.llRefresh.AccessibleDescription = resources.GetString("llRefresh.AccessibleDescription");
			this.llRefresh.AccessibleName = resources.GetString("llRefresh.AccessibleName");
			this.llRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llRefresh.Anchor")));
			this.llRefresh.AutoSize = ((bool)(resources.GetObject("llRefresh.AutoSize")));
			this.llRefresh.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llRefresh.Dock")));
			this.llRefresh.Enabled = ((bool)(resources.GetObject("llRefresh.Enabled")));
			this.llRefresh.Font = ((System.Drawing.Font)(resources.GetObject("llRefresh.Font")));
			this.llRefresh.Image = ((System.Drawing.Image)(resources.GetObject("llRefresh.Image")));
			this.llRefresh.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llRefresh.ImageAlign")));
			this.llRefresh.ImageIndex = ((int)(resources.GetObject("llRefresh.ImageIndex")));
			this.llRefresh.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llRefresh.ImeMode")));
			this.llRefresh.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llRefresh.LinkArea")));
			this.llRefresh.Location = ((System.Drawing.Point)(resources.GetObject("llRefresh.Location")));
			this.llRefresh.Name = "llRefresh";
			this.llRefresh.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llRefresh.RightToLeft")));
			this.llRefresh.Size = ((System.Drawing.Size)(resources.GetObject("llRefresh.Size")));
			this.llRefresh.TabIndex = ((int)(resources.GetObject("llRefresh.TabIndex")));
			this.llRefresh.TabStop = true;
			this.llRefresh.Text = resources.GetString("llRefresh.Text");
			this.llRefresh.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llRefresh.TextAlign")));
			this.llRefresh.Visible = ((bool)(resources.GetObject("llRefresh.Visible")));
			this.llRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRefresh_LinkClicked);
			// 
			// lbTimeCode
			// 
			this.lbTimeCode.AccessibleDescription = resources.GetString("lbTimeCode.AccessibleDescription");
			this.lbTimeCode.AccessibleName = resources.GetString("lbTimeCode.AccessibleName");
			this.lbTimeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbTimeCode.Anchor")));
			this.lbTimeCode.AutoSize = ((bool)(resources.GetObject("lbTimeCode.AutoSize")));
			this.lbTimeCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbTimeCode.Dock")));
			this.lbTimeCode.Enabled = ((bool)(resources.GetObject("lbTimeCode.Enabled")));
			this.lbTimeCode.Font = ((System.Drawing.Font)(resources.GetObject("lbTimeCode.Font")));
			this.lbTimeCode.Image = ((System.Drawing.Image)(resources.GetObject("lbTimeCode.Image")));
			this.lbTimeCode.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbTimeCode.ImageAlign")));
			this.lbTimeCode.ImageIndex = ((int)(resources.GetObject("lbTimeCode.ImageIndex")));
			this.lbTimeCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbTimeCode.ImeMode")));
			this.lbTimeCode.Location = ((System.Drawing.Point)(resources.GetObject("lbTimeCode.Location")));
			this.lbTimeCode.Name = "lbTimeCode";
			this.lbTimeCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbTimeCode.RightToLeft")));
			this.lbTimeCode.Size = ((System.Drawing.Size)(resources.GetObject("lbTimeCode.Size")));
			this.lbTimeCode.TabIndex = ((int)(resources.GetObject("lbTimeCode.TabIndex")));
			this.lbTimeCode.Text = resources.GetString("lbTimeCode.Text");
			this.lbTimeCode.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbTimeCode.TextAlign")));
			this.lbTimeCode.Visible = ((bool)(resources.GetObject("lbTimeCode.Visible")));
			// 
			// tbTimeCode
			// 
			this.tbTimeCode.AccessibleDescription = resources.GetString("tbTimeCode.AccessibleDescription");
			this.tbTimeCode.AccessibleName = resources.GetString("tbTimeCode.AccessibleName");
			this.tbTimeCode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbTimeCode.Anchor")));
			this.tbTimeCode.AutoSize = ((bool)(resources.GetObject("tbTimeCode.AutoSize")));
			this.tbTimeCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbTimeCode.BackgroundImage")));
			this.tbTimeCode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbTimeCode.Dock")));
			this.tbTimeCode.Enabled = ((bool)(resources.GetObject("tbTimeCode.Enabled")));
			this.tbTimeCode.Font = ((System.Drawing.Font)(resources.GetObject("tbTimeCode.Font")));
			this.tbTimeCode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbTimeCode.ImeMode")));
			this.tbTimeCode.Location = ((System.Drawing.Point)(resources.GetObject("tbTimeCode.Location")));
			this.tbTimeCode.MaxLength = ((int)(resources.GetObject("tbTimeCode.MaxLength")));
			this.tbTimeCode.Multiline = ((bool)(resources.GetObject("tbTimeCode.Multiline")));
			this.tbTimeCode.Name = "tbTimeCode";
			this.tbTimeCode.PasswordChar = ((char)(resources.GetObject("tbTimeCode.PasswordChar")));
			this.tbTimeCode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbTimeCode.RightToLeft")));
			this.tbTimeCode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbTimeCode.ScrollBars")));
			this.tbTimeCode.Size = ((System.Drawing.Size)(resources.GetObject("tbTimeCode.Size")));
			this.tbTimeCode.TabIndex = ((int)(resources.GetObject("tbTimeCode.TabIndex")));
			this.tbTimeCode.Text = resources.GetString("tbTimeCode.Text");
			this.tbTimeCode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbTimeCode.TextAlign")));
			this.tbTimeCode.Visible = ((bool)(resources.GetObject("tbTimeCode.Visible")));
			this.tbTimeCode.WordWrap = ((bool)(resources.GetObject("tbTimeCode.WordWrap")));
			this.tbTimeCode.TextChanged += new System.EventHandler(this.tbTimeCode_TextChanged_1);
			this.tbTimeCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTimeCode_KeyUp);
			// 
			// llAdd
			// 
			this.llAdd.AccessibleDescription = resources.GetString("llAdd.AccessibleDescription");
			this.llAdd.AccessibleName = resources.GetString("llAdd.AccessibleName");
			this.llAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llAdd.Anchor")));
			this.llAdd.AutoSize = ((bool)(resources.GetObject("llAdd.AutoSize")));
			this.llAdd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llAdd.Dock")));
			this.llAdd.Enabled = ((bool)(resources.GetObject("llAdd.Enabled")));
			this.llAdd.Font = ((System.Drawing.Font)(resources.GetObject("llAdd.Font")));
			this.llAdd.Image = ((System.Drawing.Image)(resources.GetObject("llAdd.Image")));
			this.llAdd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llAdd.ImageAlign")));
			this.llAdd.ImageIndex = ((int)(resources.GetObject("llAdd.ImageIndex")));
			this.llAdd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llAdd.ImeMode")));
			this.llAdd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llAdd.LinkArea")));
			this.llAdd.Location = ((System.Drawing.Point)(resources.GetObject("llAdd.Location")));
			this.llAdd.Name = "llAdd";
			this.llAdd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llAdd.RightToLeft")));
			this.llAdd.Size = ((System.Drawing.Size)(resources.GetObject("llAdd.Size")));
			this.llAdd.TabIndex = ((int)(resources.GetObject("llAdd.TabIndex")));
			this.llAdd.TabStop = true;
			this.llAdd.Text = resources.GetString("llAdd.Text");
			this.llAdd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llAdd.TextAlign")));
			this.llAdd.Visible = ((bool)(resources.GetObject("llAdd.Visible")));
			this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
			// 
			// llClear
			// 
			this.llClear.AccessibleDescription = resources.GetString("llClear.AccessibleDescription");
			this.llClear.AccessibleName = resources.GetString("llClear.AccessibleName");
			this.llClear.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llClear.Anchor")));
			this.llClear.AutoSize = ((bool)(resources.GetObject("llClear.AutoSize")));
			this.llClear.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llClear.Dock")));
			this.llClear.Enabled = ((bool)(resources.GetObject("llClear.Enabled")));
			this.llClear.Font = ((System.Drawing.Font)(resources.GetObject("llClear.Font")));
			this.llClear.Image = ((System.Drawing.Image)(resources.GetObject("llClear.Image")));
			this.llClear.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llClear.ImageAlign")));
			this.llClear.ImageIndex = ((int)(resources.GetObject("llClear.ImageIndex")));
			this.llClear.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llClear.ImeMode")));
			this.llClear.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llClear.LinkArea")));
			this.llClear.Location = ((System.Drawing.Point)(resources.GetObject("llClear.Location")));
			this.llClear.Name = "llClear";
			this.llClear.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llClear.RightToLeft")));
			this.llClear.Size = ((System.Drawing.Size)(resources.GetObject("llClear.Size")));
			this.llClear.TabIndex = ((int)(resources.GetObject("llClear.TabIndex")));
			this.llClear.TabStop = true;
			this.llClear.Text = resources.GetString("llClear.Text");
			this.llClear.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llClear.TextAlign")));
			this.llClear.Visible = ((bool)(resources.GetObject("llClear.Visible")));
			this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
			// 
			// AnimFrameBlockControl
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.tv);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel2);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "AnimFrameBlockControl";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.panel2.ResumeLayout(false);
			this.pnSplit2.ResumeLayout(false);
			this.pnSplit1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Properties
		AnimationFrameBlock afb;
		public AnimationFrameBlock FrameBlock
		{
			get { return afb; }
			set { 
				afb = value; 
				RefreshData();
			}
		}
		#endregion

		public void Clear()
		{			
			miRem.Enabled = false;
			miExp.Enabled = false;

			intern = true;
			this.tv.Nodes.Clear();
			llClone.Enabled = false;
			llAdd.Enabled = false;
			llClear.Enabled = false;

			this.tbTimeCode.Enabled = false;
			this.lbTimeCode.Enabled = tbTimeCode.Enabled;

			intern = false;
		}

		public void RefreshData()
		{
			Clear();

			if (afb!=null)
			{				
				miRem.Enabled = true;
				miExp.Enabled = true;
				llAdd.Enabled = true;
				llClear.Enabled = true;				

				AddFrames(afb.Frames, "");
			}
		}

		protected void AddFrames(AnimationFrame[] fr, string prefix)
		{
			foreach (AnimationFrame af in fr)			
				AddFrames(af, prefix);			
		}

		protected void AddFrames(AnimationFrame af, string prefix)
		{
			int ct = 0;
			foreach (AnimationAxisTransform aat in af.Blocks) 
				if (aat!=null) 
					ct++;

			TreeNode tn = new TreeNode(prefix+"tc="+af.TimeCode.ToString()+", comp="+ct+", "+af.Type.ToString());
			tn.Tag = af;

			AddFrame(tn, af.XBlock, "X: ");
			AddFrame(tn, af.YBlock, "Y: ");
			AddFrame(tn, af.ZBlock, "Z: ");

			tv.Nodes.Add(tn);
		}

		protected void AddFrame(TreeNode parent, AnimationAxisTransform aat, string prefix)
		{
			if (parent==null) return;
			if (aat==null) return;

			TreeNode tn = new TreeNode(prefix+aat.ToString());
			tn.Tag = aat;

			parent.Nodes.Add(tn);
		}

		bool intern;
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			pn1.AxisTransform = null;
			pn2.Visible=false;
			pn3.Visible=false;
			pn2.AxisTransform = null;
			pn3.AxisTransform = null;
			panel2.AutoScroll = false;
			pn1.CanCreate = false;
			this.tbTimeCode.Enabled = false;
			this.lbTimeCode.Enabled = tbTimeCode.Enabled;
			llClone.Enabled = false;
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;


			if (e.Node.Tag is AnimationAxisTransform)
			{				
				pn1.AxisTransform = (AnimationAxisTransform)e.Node.Tag;
				
				pn1.Tag = e.Node;
			} 
			else if (e.Node.Tag is AnimationFrame)
			{
				
				llClone.Enabled = true;
				pn3.Visible=true;
				pn2.Visible=true;

				
				panel2.AutoScroll = true;
				pn1.CanCreate = true;
				pn2.CanCreate = true;
				pn3.CanCreate = true;

				AnimAxisTransformControl[] aatcs = new AnimAxisTransformControl[3];
				aatcs[0] = pn1; aatcs[1] = pn2; aatcs[2] = pn3;
				
				foreach (TreeNode n in e.Node.Nodes) 
				{
					int ct = 0;
					if (n.Text[0]=='X') ct = 0;
					else if (n.Text[0]=='Y') ct = 1;
					else if (n.Text[0]=='Z') ct = 2;
					else continue;

					aatcs[ct].AxisTransform = (AnimationAxisTransform)n.Tag;
					aatcs[ct].Tag = n;

					if (!tbTimeCode.Enabled) 
					{
						intern = true;
						this.tbTimeCode.Enabled = true;
						this.lbTimeCode.Enabled = tbTimeCode.Enabled;
						if (aatcs[ct].AxisTransform!=null)
							tbTimeCode.Text = aatcs[ct].AxisTransform.TimeCode.ToString();
						intern = false;
					}
				}
				
			}
		}

		private void pn3_VisibleChanged(object sender, System.EventArgs e)
		{
			pnSplit2.Visible = pn3.Visible;
		}

		private void pn2_VisibleChanged(object sender, System.EventArgs e)
		{
			pnSplit1.Visible = pn2.Visible;
		}

		private void pn1_Deleted(object sender, System.EventArgs e)
		{
			if (!(sender is AnimAxisTransformControl)) return;
			AnimAxisTransformControl s = (AnimAxisTransformControl)sender;
			TreeNode n = (TreeNode)s.Tag;

			n.Parent.Nodes.Remove(n);
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void pn1_Changed(object sender, System.EventArgs e)
		{
			if (!(sender is AnimAxisTransformControl)) return;
			AnimAxisTransformControl s = (AnimAxisTransformControl)sender;
			TreeNode n = (TreeNode)s.Tag;

			if (n!=null && s.AxisTransform!=null) 
			{
				n.Text = n.Text.Substring(0, 3)+s.AxisTransform.ToString();
				if (Changed!=null) Changed(this, new System.EventArgs());			
			}
		}

		private void llClear_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			afb.ClearFrames();
			tv.Nodes.Clear();

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void llAdd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (afb.AxisCount==0) afb.CreateBaseAxisSet();

			afb.AddFrame((short)(afb.GetDuration()+1), 0, 0, 0, false);
			AddFrames(afb.Frames[afb.FrameCount-1], "");

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void pn1_CreateClicked(object sender, System.EventArgs e)
		{			
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<1) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[0].Add(af.TimeCode, 0, 0, 0, af.Linear);
			af.XBlock = afb.AxisSet[0].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "X: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));
		}

		private void pn2_CreateClicked(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<2) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[1].Add(af.TimeCode, 0, 0, 0, af.Linear);
			af.YBlock = afb.AxisSet[1].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "Y: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));
		}

		private void pn3_CreateClicked(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<3) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[2].Add(af.TimeCode, 0, 0, 0, af.Linear);
			af.ZBlock = afb.AxisSet[2].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "Z: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));		
		}

		private void tbTimeCode_TextChanged(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			if (intern) return;
			intern = true;
			try 
			{
				short val = Helper.StringToInt16(this.tbTimeCode.Text, 0, 10);

				AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
				if (af.XBlock!=null) af.XBlock.TimeCode = val;
				if (af.YBlock!=null) af.YBlock.TimeCode = val;
				if (af.ZBlock!=null) af.ZBlock.TimeCode = val;

				this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));	
				this.pn1_Changed(pn1, null);
				this.pn1_Changed(pn2, null);
				this.pn1_Changed(pn3, null);
			}
			finally 
			{
				intern = false;
			}
		}

		private void tbTimeCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) tbTimeCode_TextChanged(sender, null);
		}

		private void llRefresh_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.RefreshData();
		}

		private void llClone_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;

			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;			
			afb.AddFrame((short)(afb.GetDuration()+1), af.X, af.Y, af.Z, af.Linear);
			AddFrames(afb.Frames[afb.FrameCount-1], "");

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void tbTimeCode_TextChanged_1(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			if (intern) return;
			intern = true;
			try 
			{
				short val = Helper.StringToInt16(this.tbTimeCode.Text, 0, 10);

				AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
				if (af.XBlock!=null) af.XBlock.TimeCode = val;
				if (af.YBlock!=null) af.YBlock.TimeCode = val;
				if (af.ZBlock!=null) af.ZBlock.TimeCode = val;
				
				this.pn1_Changed(pn1, null);
				this.pn1_Changed(pn2, null);
				this.pn1_Changed(pn3, null);
			}
			finally 
			{
				intern = false;
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			foreach (TreeNode tn in tv.Nodes) tn.ExpandAll();	
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			if (afb!=null) 
			{
				afb.RemoveUnneededFrames();
				this.RefreshData();

				if (Changed!=null) Changed(this, new System.EventArgs());	
			}
		}

		

		
		

	


		#region Events
		public event System.EventHandler Changed;
		#endregion
	}
}
