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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhItemsListViewItem.
	/// </summary>
	public class NgbhItemsListView : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private TD.SandBar.FlatComboBox cbadd;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.LinkLabel lldel;
		private Button btUp;
		private Button btDown;
		private TD.SandBar.MenuBar menuBar1;
		private TD.SandBar.MenuButtonItem miCopy;
		private TD.SandBar.MenuButtonItem miPaste;
		private TD.SandBar.ContextMenuBarItem menu;
		private TD.SandBar.MenuButtonItem miPasteGossip;
		private TD.SandBar.MenuButtonItem miClone;
		private TD.SandBar.MenuButtonItem miDelCascade;
		private ListView lv;

		public NgbhItemsListView()
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
			
			SmallImageList = new ImageList();
			SmallImageList.ImageSize = new Size(NgbhItem.ICON_SIZE, NgbhItem.ICON_SIZE);
			SmallImageList.ColorDepth = ColorDepth.Depth32Bit;				

			lv.SelectedIndexChanged += new EventHandler(lv_SelectedIndexChanged);
			
			SlotType = Data.NeighborhoodSlots.Sims;

			InitTheo();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhItemsListView));
			this.lv = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.cbadd = new TD.SandBar.FlatComboBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.btUp = new System.Windows.Forms.Button();
			this.btDown = new System.Windows.Forms.Button();
			this.menuBar1 = new TD.SandBar.MenuBar();
			this.menu = new TD.SandBar.ContextMenuBarItem();
			this.miCopy = new TD.SandBar.MenuButtonItem();
			this.miPaste = new TD.SandBar.MenuButtonItem();
			this.miPasteGossip = new TD.SandBar.MenuButtonItem();
			this.miClone = new TD.SandBar.MenuButtonItem();
			this.miDelCascade = new TD.SandBar.MenuButtonItem();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
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
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.menuBar1.SetSandBarMenu(this.lv, this.menu);
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.View = System.Windows.Forms.View.List;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged_1);
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
			this.panel1.Controls.Add(this.lladd);
			this.panel1.Controls.Add(this.cbadd);
			this.panel1.Controls.Add(this.lldel);
			this.panel1.Controls.Add(this.btUp);
			this.panel1.Controls.Add(this.btDown);
			this.panel1.Controls.Add(this.menuBar1);
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
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
			// 
			// cbadd
			// 
			this.cbadd.AccessibleDescription = resources.GetString("cbadd.AccessibleDescription");
			this.cbadd.AccessibleName = resources.GetString("cbadd.AccessibleName");
			this.cbadd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbadd.Anchor")));
			this.cbadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbadd.BackgroundImage")));
			this.cbadd.DefaultText = resources.GetString("cbadd.DefaultText");
			this.cbadd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbadd.Dock")));
			this.cbadd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbadd.Enabled = ((bool)(resources.GetObject("cbadd.Enabled")));
			this.cbadd.Font = ((System.Drawing.Font)(resources.GetObject("cbadd.Font")));
			this.cbadd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbadd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbadd.ImeMode")));
			this.cbadd.IntegralHeight = ((bool)(resources.GetObject("cbadd.IntegralHeight")));
			this.cbadd.ItemHeight = ((int)(resources.GetObject("cbadd.ItemHeight")));
			this.cbadd.Location = ((System.Drawing.Point)(resources.GetObject("cbadd.Location")));
			this.cbadd.MaxDropDownItems = ((int)(resources.GetObject("cbadd.MaxDropDownItems")));
			this.cbadd.MaxLength = ((int)(resources.GetObject("cbadd.MaxLength")));
			this.cbadd.Name = "cbadd";
			this.cbadd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbadd.RightToLeft")));
			this.cbadd.Size = ((System.Drawing.Size)(resources.GetObject("cbadd.Size")));
			this.cbadd.TabIndex = ((int)(resources.GetObject("cbadd.TabIndex")));
			this.cbadd.Text = resources.GetString("cbadd.Text");
			this.cbadd.Visible = ((bool)(resources.GetObject("cbadd.Visible")));
			this.cbadd.SelectedIndexChanged += new System.EventHandler(this.cbadd_SelectedIndexChanged);
			// 
			// lldel
			// 
			this.lldel.AccessibleDescription = resources.GetString("lldel.AccessibleDescription");
			this.lldel.AccessibleName = resources.GetString("lldel.AccessibleName");
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldel.Anchor")));
			this.lldel.AutoSize = ((bool)(resources.GetObject("lldel.AutoSize")));
			this.lldel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldel.Dock")));
			this.lldel.Enabled = ((bool)(resources.GetObject("lldel.Enabled")));
			this.lldel.Font = ((System.Drawing.Font)(resources.GetObject("lldel.Font")));
			this.lldel.Image = ((System.Drawing.Image)(resources.GetObject("lldel.Image")));
			this.lldel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.ImageAlign")));
			this.lldel.ImageIndex = ((int)(resources.GetObject("lldel.ImageIndex")));
			this.lldel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldel.ImeMode")));
			this.lldel.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldel.LinkArea")));
			this.lldel.Location = ((System.Drawing.Point)(resources.GetObject("lldel.Location")));
			this.lldel.Name = "lldel";
			this.lldel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldel.RightToLeft")));
			this.lldel.Size = ((System.Drawing.Size)(resources.GetObject("lldel.Size")));
			this.lldel.TabIndex = ((int)(resources.GetObject("lldel.TabIndex")));
			this.lldel.TabStop = true;
			this.lldel.Text = resources.GetString("lldel.Text");
			this.lldel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.TextAlign")));
			this.lldel.Visible = ((bool)(resources.GetObject("lldel.Visible")));
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
			// 
			// btUp
			// 
			this.btUp.AccessibleDescription = resources.GetString("btUp.AccessibleDescription");
			this.btUp.AccessibleName = resources.GetString("btUp.AccessibleName");
			this.btUp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btUp.Anchor")));
			this.btUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUp.BackgroundImage")));
			this.btUp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btUp.Dock")));
			this.btUp.Enabled = ((bool)(resources.GetObject("btUp.Enabled")));
			this.btUp.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btUp.FlatStyle")));
			this.btUp.Font = ((System.Drawing.Font)(resources.GetObject("btUp.Font")));
			this.btUp.Image = ((System.Drawing.Image)(resources.GetObject("btUp.Image")));
			this.btUp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btUp.ImageAlign")));
			this.btUp.ImageIndex = ((int)(resources.GetObject("btUp.ImageIndex")));
			this.btUp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btUp.ImeMode")));
			this.btUp.Location = ((System.Drawing.Point)(resources.GetObject("btUp.Location")));
			this.btUp.Name = "btUp";
			this.btUp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btUp.RightToLeft")));
			this.btUp.Size = ((System.Drawing.Size)(resources.GetObject("btUp.Size")));
			this.btUp.TabIndex = ((int)(resources.GetObject("btUp.TabIndex")));
			this.btUp.Text = resources.GetString("btUp.Text");
			this.btUp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btUp.TextAlign")));
			this.btUp.Visible = ((bool)(resources.GetObject("btUp.Visible")));
			this.btUp.Click += new System.EventHandler(this.btUp_Click);
			// 
			// btDown
			// 
			this.btDown.AccessibleDescription = resources.GetString("btDown.AccessibleDescription");
			this.btDown.AccessibleName = resources.GetString("btDown.AccessibleName");
			this.btDown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btDown.Anchor")));
			this.btDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDown.BackgroundImage")));
			this.btDown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btDown.Dock")));
			this.btDown.Enabled = ((bool)(resources.GetObject("btDown.Enabled")));
			this.btDown.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btDown.FlatStyle")));
			this.btDown.Font = ((System.Drawing.Font)(resources.GetObject("btDown.Font")));
			this.btDown.Image = ((System.Drawing.Image)(resources.GetObject("btDown.Image")));
			this.btDown.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btDown.ImageAlign")));
			this.btDown.ImageIndex = ((int)(resources.GetObject("btDown.ImageIndex")));
			this.btDown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btDown.ImeMode")));
			this.btDown.Location = ((System.Drawing.Point)(resources.GetObject("btDown.Location")));
			this.btDown.Name = "btDown";
			this.btDown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btDown.RightToLeft")));
			this.btDown.Size = ((System.Drawing.Size)(resources.GetObject("btDown.Size")));
			this.btDown.TabIndex = ((int)(resources.GetObject("btDown.TabIndex")));
			this.btDown.Text = resources.GetString("btDown.Text");
			this.btDown.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btDown.TextAlign")));
			this.btDown.Visible = ((bool)(resources.GetObject("btDown.Visible")));
			this.btDown.Click += new System.EventHandler(this.btDown_Click);
			// 
			// menuBar1
			// 
			this.menuBar1.AccessibleDescription = resources.GetString("menuBar1.AccessibleDescription");
			this.menuBar1.AccessibleName = resources.GetString("menuBar1.AccessibleName");
			this.menuBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("menuBar1.Anchor")));
			this.menuBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBar1.BackgroundImage")));
			this.menuBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("menuBar1.Dock")));
			this.menuBar1.Enabled = ((bool)(resources.GetObject("menuBar1.Enabled")));
			this.menuBar1.Font = ((System.Drawing.Font)(resources.GetObject("menuBar1.Font")));
			this.menuBar1.Guid = new System.Guid("76f91bf3-cf27-473c-951c-2f9066087017");
			this.menuBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuBar1.ImeMode")));
			this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.menu});
			this.menuBar1.Location = ((System.Drawing.Point)(resources.GetObject("menuBar1.Location")));
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.OwnerForm = null;
			this.menuBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuBar1.RightToLeft")));
			this.menuBar1.Size = ((System.Drawing.Size)(resources.GetObject("menuBar1.Size")));
			this.menuBar1.TabIndex = ((int)(resources.GetObject("menuBar1.TabIndex")));
			this.menuBar1.Text = resources.GetString("menuBar1.Text");
			this.menuBar1.Visible = ((bool)(resources.GetObject("menuBar1.Visible")));
			// 
			// menu
			// 
			this.menu.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																		  this.miCopy,
																		  this.miPaste,
																		  this.miPasteGossip,
																		  this.miClone,
																		  this.miDelCascade});
			this.menu.Text = resources.GetString("menu.Text");
			this.menu.ToolTipText = resources.GetString("menu.ToolTipText");
			this.menu.BeforePopup += new TD.SandBar.MenuItemBase.BeforePopupEventHandler(this.contextMenuBarItem1_BeforePopup);
			// 
			// miCopy
			// 
			this.miCopy.Image = ((System.Drawing.Image)(resources.GetObject("miCopy.Image")));
			this.miCopy.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miCopy.Shortcut")));
			this.miCopy.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miCopy.Shortcut2")));
			this.miCopy.Text = resources.GetString("miCopy.Text");
			this.miCopy.ToolTipText = resources.GetString("miCopy.ToolTipText");
			this.miCopy.Activate += new System.EventHandler(this.CopyItems);
			// 
			// miPaste
			// 
			this.miPaste.Image = ((System.Drawing.Image)(resources.GetObject("miPaste.Image")));
			this.miPaste.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPaste.Shortcut")));
			this.miPaste.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPaste.Shortcut2")));
			this.miPaste.Text = resources.GetString("miPaste.Text");
			this.miPaste.ToolTipText = resources.GetString("miPaste.ToolTipText");
			this.miPaste.Activate += new System.EventHandler(this.PasteItems);
			// 
			// miPasteGossip
			// 
			this.miPasteGossip.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPasteGossip.Shortcut")));
			this.miPasteGossip.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPasteGossip.Shortcut2")));
			this.miPasteGossip.Text = resources.GetString("miPasteGossip.Text");
			this.miPasteGossip.ToolTipText = resources.GetString("miPasteGossip.ToolTipText");
			this.miPasteGossip.Activate += new System.EventHandler(this.PasteItemsAsGossip);
			// 
			// miClone
			// 
			this.miClone.BeginGroup = true;
			this.miClone.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miClone.Shortcut")));
			this.miClone.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miClone.Shortcut2")));
			this.miClone.Text = resources.GetString("miClone.Text");
			this.miClone.ToolTipText = resources.GetString("miClone.ToolTipText");
			this.miClone.Activate += new System.EventHandler(this.CloneItem);
			// 
			// miDelCascade
			// 
			this.miDelCascade.Image = ((System.Drawing.Image)(resources.GetObject("miDelCascade.Image")));
			this.miDelCascade.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miDelCascade.Shortcut")));
			this.miDelCascade.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miDelCascade.Shortcut2")));
			this.miDelCascade.Text = resources.GetString("miDelCascade.Text");
			this.miDelCascade.ToolTipText = resources.GetString("miDelCascade.ToolTipText");
			this.miDelCascade.Activate += new System.EventHandler(this.DeleteCascadeItems);
			// 
			// NgbhItemsListView
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.lv);
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NgbhItemsListView";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		SimPe.Data.NeighborhoodSlots st;
		public SimPe.Data.NeighborhoodSlots SlotType 
		{
			get {return st;}
			set 
			{
				if (st!=value) 
				{
					st = value;
					SetContent();
				}
			}
		}

		public NgbhSlotList Slot
		{
			get 
			{
				if (NgbhItems==null) return null;
				else return NgbhItems.Parent;
			}
			set 
			{				
				if (value!=null)
					NgbhItems = value.GetItems(this.SlotType);
				else
					NgbhItems = null;				
			}
		}

		Collections.NgbhItems items;
		[System.ComponentModel.Browsable(false)]
		public Collections.NgbhItems NgbhItems 
		{
			get {return items;}
			set 
			{
				//if (value!=items)
			{
				items = value;
				SetContent();
			}
			}
		}

		void SetContent()
		{
			this.Clear();
			this.cbadd.Items.Clear();

			if (items!=null)
			{
				lv.BeginUpdate();
				foreach (NgbhItem i in items)								
					AddItemToList(i);								
				lv.EndUpdate();

				SetAvailableAddTypes();
			}
		}

		public  void Refresh(bool full)
		{
			if (full) SetContent();
			base.Refresh();
		}
		public new void Refresh()
		{
			Refresh(true);
		}

		void AddItemToList(NgbhItem item)
		{
			if (item==null) return;

			NgbhItemsListViewItem lvi = new NgbhItemsListViewItem(this, item); 
		}

		void InsertItemToList(int index, NgbhItem item)
		{
			if (item==null) return;

			NgbhItemsListViewItem lvi = new NgbhItemsListViewItem(this, item, false); 
			lv.Items.Insert(index, lvi);
		}

		void SetAvailableAddTypes()
		{
			string prefix = typeof(SimMemoryType).Namespace+"."+typeof(SimMemoryType).Name+".";
			SimMemoryType[] sts = Ngbh.AllowedMemoryTypes(st);
			foreach (SimMemoryType mst in sts)				
				cbadd.Items.Add(new Data.Alias((uint)mst, SimPe.Localization.GetString(prefix+ mst.ToString()), "{name}"));
			if (cbadd.Items.Count>0) cbadd.SelectedIndex = 0;
		}

		public void Clear()
		{
			lv.Clear();
			if (lv.SmallImageList!=null)
				lv.SmallImageList.Images.Clear();
		}


		[System.ComponentModel.Browsable(false)]
		public NgbhItemsListViewItem SelectedItem
		{
			get 
			{
				if (lv.SelectedItems.Count==0) return null;
				
				if (lv.FocusedItem!=null) 
					if (lv.FocusedItem.Selected) return lv.FocusedItem as NgbhItemsListViewItem;				
				
				return lv.SelectedItems[0] as NgbhItemsListViewItem;
			}
		}

		[System.ComponentModel.Browsable(false)]
		public NgbhItem SelectedNgbhItem
		{
			get 
			{
				if (SelectedItem==null) return null;
				return SelectedItem.Item;
			}
		}

		[System.ComponentModel.Browsable(false)]
		public Collections.NgbhItems SelectedNgbhItems
		{
			get 
			{
				NgbhSlotList parent = null;
				if (items != null) parent = items.Parent;
				Collections.NgbhItems ret = new Collections.NgbhItems(parent);
				foreach (NgbhItemsListViewItem lvi in lv.SelectedItems)
					ret.Add(lvi.Item);

				return ret;
			}
		}

		[System.ComponentModel.Browsable(false)]
		public bool SelectedMultiple
		{
			get {return lv.SelectedItems.Count>1;}
		}

		internal void UpdateSelected(NgbhItem item)
		{
			if (item==null) return;
			if (SelectedItem==null) return;

			SelectedItem.Update();
			this.Refresh(false);

			
		}

		public ListView.ListViewItemCollection Items
		{
			get { return lv.Items;}
		}

		ImageList sil;
		public ImageList SmallImageList
		{
			get { return sil;}
			set 
			{ 
				lv.SmallImageList = value;
				sil = value;
			}
		}

		public event EventHandler SelectedIndexChanged;

		private void lv_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedIndexChanged!=null) SelectedIndexChanged(this, e);
		}

		private void cbadd_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			lladd.Enabled = cbadd.SelectedIndex>=0 && items!=null;
		}

		private void lv_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			lldel.Enabled = (lv.SelectedItems.Count>0 && items!=null);
			if (lv.Items.Count==0 || lv.SelectedItems.Count!=1 || items==null)
			{
				btUp.Enabled = false;
				btDown.Enabled = false;
			} 
			else 
			{
				btUp.Enabled = lldel.Enabled && !lv.Items[0].Selected;
				btDown.Enabled = lldel.Enabled && !lv.Items[lv.Items.Count-1].Selected;
			}
		}

		private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (items==null || cbadd.SelectedIndex<0) return;

			Data.Alias a = cbadd.SelectedItem as Data.Alias;
			SimMemoryType smt = (SimMemoryType)a.Id;

			int index = this.NextItemIndex(true);
			NgbhItem item = items.InsertNew(index, smt);
			item.SetInitialGuid(smt);
			InsertItemToList(index, item);
			
			lv.Items[index].Selected = true;
			lv.Items[index].EnsureVisible();
		}

		private void lldel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0 ||items==null) return;
			//NgbhItemsListViewItem item = this.SelectedItem;
			Collections.NgbhItems nitems = this.SelectedNgbhItems;			
			items.Remove(nitems);

			for (int i=lv.SelectedItems.Count; i>0; i--)
				lv.Items.Remove(lv.SelectedItems[0]);
		}

		void SwapListViewItem(int i1, int i2)
		{
			if (i1<0 || i2<0 || i1>=lv.Items.Count || i2>=lv.Items.Count) return;
			ListViewItem o1 = lv.Items[i1];
			ListViewItem o2 = lv.Items[i2];
			
			lv.Items[i1] = new ListViewItem();
			lv.Items[i2] = o1;
			lv.Items[i1] = o2;
		}

		int SelectedIndex
		{
			get 
			{
				if (lv.SelectedIndices.Count==0) return -1;
				return lv.SelectedIndices[0];
			}
		}

		private void btUp_Click(object sender, System.EventArgs e)
		{
			int index = SelectedIndex;
			items.Swap(index, index-1);
			SwapListViewItem(index, index-1);
		}

		private void btDown_Click(object sender, System.EventArgs e)
		{
			int index = SelectedIndex;
			items.Swap(index, index+1);
			SwapListViewItem(index, index+1);
		}

		
		#region Extensions by Theo
		System.Collections.Queue clipboard;

		void InitTheo()
		{
			clipboard = new Queue();
		}

		
		void CopyItems(object sender, EventArgs e)
		{
			CopyItems();
		}

		void CopyItems()
		{
			Collections.NgbhItems selitems =  SelectedNgbhItems;
			if (selitems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				try
				{
					clipboard.Clear();
					foreach (NgbhItem item in selitems)
					{
						clipboard.Enqueue(item);
					}
				}
				catch (Exception exception1)
				{
					this.Cursor = Cursors.Default;
					Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), exception1);
				}
				this.Cursor = Cursors.Default;
			}

		}

		void PasteItems(object sender, EventArgs e)
		{
			PasteItems(false);
		}

		void PasteItemsAsGossip(object sender, EventArgs e)
		{
			PasteItems(true);
		}

		void PasteItems(bool asgossip)
		{
			int itemIndex = this.NextItemIndex(false);
			this.Cursor = Cursors.WaitCursor;
			try
			{
				while (clipboard.Count > 0)
				{
					NgbhItem item = clipboard.Dequeue() as NgbhItem;
					
					if (item != null)
					{
						item = item.Clone(this.Slot);

						if (item.IsMemory && item.OwnerInstance > 0 && !asgossip)
							item.OwnerInstance = (ushort)items.Parent.SlotID;								

						AddItemAfterSelected(item);
					}
				}
			}
			catch (Exception exception1)
			{
				this.Cursor = Cursors.Default;
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), exception1);
			}
			this.Cursor = Cursors.Default;			
		}

		void AddItemAfterSelected(NgbhItem item)
		{
			//if (this.lv.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				try
				{
					int selectedIndex = this.NextItemIndex(true);

					NgbhItems.Insert(selectedIndex, item);					
					this.AddItemAt(item, selectedIndex);
					this.lv.Items[selectedIndex].Selected = true;
					this.lv.Items[selectedIndex].EnsureVisible();					
				}
				catch (Exception exception1)
				{
					this.Cursor = Cursors.Default;
					Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), exception1);
				}

				this.Cursor = Cursors.Default;
			}
		}

		private void AddItemAt(NgbhItem item, int index)
		{
			this.InsertItemToList(index, item);
			this.lv.SelectedItems.Clear();
			this.lv.Items[index].Selected = true;
			this.lv.Items[index].EnsureVisible();	
			if (this.SelectedIndexChanged!=null) SelectedIndexChanged(this, new EventArgs());
		}

		int NextItemIndex(bool clearSelection)
		{
			int selectedIndex = this.lv.Items.Count - 1;

			// get index of the last selected item (if any)
			if (this.lv.SelectedIndices.Count > 0)
				selectedIndex = this.lv.SelectedIndices[this.lv.SelectedIndices.Count - 1];

			// deselect previous (if applicable)
			if (clearSelection)
				this.lv.SelectedItems.Clear();

			// should not exceed the number of items (?)
			selectedIndex = Math.Min(++selectedIndex, this.lv.Items.Count);

			return selectedIndex;
		}

		void CloneItem(object sender, EventArgs e)
		{
			CloneItem();
		}

		void CloneItem()
		{
			if (this.lv.SelectedItems.Count > 0)
			{
				this.Cursor = Cursors.WaitCursor;
				try
				{
					// this command operates on a single item only;
					// to avoid ambiguity, use the focused item
					NgbhItem item = this.GetFocusedItem();
					if (item != null)
					{
						int itemIndex = this.lv.FocusedItem.Index + 1;
						NgbhItem item1 = item.Clone();

						items.Insert(itemIndex, item1);											
						this.AddItemAt(item1, itemIndex);

						this.lv.FocusedItem.Focused = false;
					}
				}
				catch (Exception exception1)
				{
					this.Cursor = Cursors.Default;
					Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), exception1);
				}
				this.Cursor = Cursors.Default;
			}

		}

		NgbhItem GetFocusedItem()
		{
			NgbhItemsListViewItem li = this.SelectedItem;
			if (li==null) return null;
			return li.Item;
		}

		public void SelectMemoriesByGuid(Collections.NgbhItems items)
		{
			if (items.Length > 0)
			{
				this.lv.Enabled = false;

				ArrayList guidList = new ArrayList();
				foreach (NgbhItem item in items)
					if (!guidList.Contains(item.Guid))
						guidList.Add(item.Guid);

				foreach (ListViewItem li in this.lv.Items)
				{
					NgbhItem item = li.Tag as NgbhItem;
					if (guidList.Contains(item.Guid))
						li.Selected = true;
				}

				this.lv.Enabled = true;
			}
		}

		void DeleteItems(object sender, EventArgs e)
		{
			this.DeleteItems(false);
		}		

		void DeleteCascadeItems(object sender, EventArgs e)
		{
			this.DeleteItems(true);
		}		

		void DeleteItems(bool cascade)
		{
			if (lv.SelectedItems.Count != 0)
			{
				this.Cursor = Cursors.WaitCursor;
				try
				{
					ArrayList items = new ArrayList();
					foreach (ListViewItem li in lv.SelectedItems)
						items.Add(li);

					Collections.NgbhItems memoryItems = this.SelectedNgbhItems;

					if (cascade)
						((EnhancedNgbh)Slot.Parent).DeleteMemoryEchoes(memoryItems, Slot.SlotID);

					memoryItems[0].ParentSlot.ItemsB.Remove(memoryItems);

					foreach (ListViewItem li in items)
						lv.Items.Remove(li);

					lv.SelectedItems.Clear();
				}
				catch (Exception exception1)
				{
					this.Cursor = Cursors.Default;
					Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), exception1);
				}
				this.Cursor = Cursors.Default;
			}
		}

		private void contextMenuBarItem1_BeforePopup(object sender, TD.SandBar.MenuPopupEventArgs e)
		{
			miCopy.Enabled = lv.SelectedItems.Count>0;
			miClone.Enabled = miCopy.Enabled;			
			miPaste.Enabled = clipboard.Count>0;

			if (((NgbhSlot)items.Parent).Type == Data.NeighborhoodSlots.Sims || ((NgbhSlot)items.Parent).Type == Data.NeighborhoodSlots.SimsIntern)
			{
				miDelCascade.Enabled = miCopy.Enabled;				
				miPasteGossip.Enabled = miPaste.Enabled;
			} 
			else 
			{
				miDelCascade.Enabled = false;
				miPasteGossip.Enabled = false;
			}
		}
		


		
		#endregion

		
	}
}
