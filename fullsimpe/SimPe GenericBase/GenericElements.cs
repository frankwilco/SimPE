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

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für Elements.
	/// </summary>
	internal class GenericElements : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		internal System.Windows.Forms.Label listBanner;
		internal System.Windows.Forms.ListView listList;
		internal System.Windows.Forms.Panel ListPanel;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		internal System.Windows.Forms.Panel itemPanel;
		internal System.Windows.Forms.Panel treeItemPanel;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label treeBanner;
		internal System.Windows.Forms.Panel TreePanel;
		internal System.Windows.Forms.TreeView mytree;
		private ColumnSorter sorter;
		internal LinkLabel lllvcommit;

		internal SimPe.Interfaces.Plugin.IFileWrapperSaveExtension wrapper = null;
		public GenericElements()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			sorter = new ColumnSorter();
			sorter.CurrentColumn = 0;

			listList.ListViewItemSorter = sorter;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GenericElements));
			this.ListPanel = new System.Windows.Forms.Panel();
			this.itemPanel = new System.Windows.Forms.Panel();
			this.listList = new System.Windows.Forms.ListView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listBanner = new System.Windows.Forms.Label();
			this.lllvcommit = new System.Windows.Forms.LinkLabel();
			this.TreePanel = new System.Windows.Forms.Panel();
			this.mytree = new System.Windows.Forms.TreeView();
			this.treeItemPanel = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.treeBanner = new System.Windows.Forms.Label();
			this.ListPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.TreePanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// ListPanel
			// 
			this.ListPanel.AccessibleDescription = resources.GetString("ListPanel.AccessibleDescription");
			this.ListPanel.AccessibleName = resources.GetString("ListPanel.AccessibleName");
			this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ListPanel.Anchor")));
			this.ListPanel.AutoScroll = ((bool)(resources.GetObject("ListPanel.AutoScroll")));
			this.ListPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("ListPanel.AutoScrollMargin")));
			this.ListPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("ListPanel.AutoScrollMinSize")));
			this.ListPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ListPanel.BackgroundImage")));
			this.ListPanel.Controls.Add(this.itemPanel);
			this.ListPanel.Controls.Add(this.listList);
			this.ListPanel.Controls.Add(this.panel2);
			this.ListPanel.Controls.Add(this.lllvcommit);
			this.ListPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ListPanel.Dock")));
			this.ListPanel.Enabled = ((bool)(resources.GetObject("ListPanel.Enabled")));
			this.ListPanel.Font = ((System.Drawing.Font)(resources.GetObject("ListPanel.Font")));
			this.ListPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ListPanel.ImeMode")));
			this.ListPanel.Location = ((System.Drawing.Point)(resources.GetObject("ListPanel.Location")));
			this.ListPanel.Name = "ListPanel";
			this.ListPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ListPanel.RightToLeft")));
			this.ListPanel.Size = ((System.Drawing.Size)(resources.GetObject("ListPanel.Size")));
			this.ListPanel.TabIndex = ((int)(resources.GetObject("ListPanel.TabIndex")));
			this.ListPanel.Text = resources.GetString("ListPanel.Text");
			this.ListPanel.Visible = ((bool)(resources.GetObject("ListPanel.Visible")));
			// 
			// itemPanel
			// 
			this.itemPanel.AccessibleDescription = resources.GetString("itemPanel.AccessibleDescription");
			this.itemPanel.AccessibleName = resources.GetString("itemPanel.AccessibleName");
			this.itemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("itemPanel.Anchor")));
			this.itemPanel.AutoScroll = ((bool)(resources.GetObject("itemPanel.AutoScroll")));
			this.itemPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("itemPanel.AutoScrollMargin")));
			this.itemPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("itemPanel.AutoScrollMinSize")));
			this.itemPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.itemPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemPanel.BackgroundImage")));
			this.itemPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("itemPanel.Dock")));
			this.itemPanel.Enabled = ((bool)(resources.GetObject("itemPanel.Enabled")));
			this.itemPanel.Font = ((System.Drawing.Font)(resources.GetObject("itemPanel.Font")));
			this.itemPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("itemPanel.ImeMode")));
			this.itemPanel.Location = ((System.Drawing.Point)(resources.GetObject("itemPanel.Location")));
			this.itemPanel.Name = "itemPanel";
			this.itemPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("itemPanel.RightToLeft")));
			this.itemPanel.Size = ((System.Drawing.Size)(resources.GetObject("itemPanel.Size")));
			this.itemPanel.TabIndex = ((int)(resources.GetObject("itemPanel.TabIndex")));
			this.itemPanel.Text = resources.GetString("itemPanel.Text");
			this.itemPanel.Visible = ((bool)(resources.GetObject("itemPanel.Visible")));
			// 
			// listList
			// 
			this.listList.AccessibleDescription = resources.GetString("listList.AccessibleDescription");
			this.listList.AccessibleName = resources.GetString("listList.AccessibleName");
			this.listList.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("listList.Alignment")));
			this.listList.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listList.Anchor")));
			this.listList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("listList.BackgroundImage")));
			this.listList.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listList.Dock")));
			this.listList.Enabled = ((bool)(resources.GetObject("listList.Enabled")));
			this.listList.Font = ((System.Drawing.Font)(resources.GetObject("listList.Font")));
			this.listList.FullRowSelect = true;
			this.listList.GridLines = true;
			this.listList.HideSelection = false;
			this.listList.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listList.ImeMode")));
			this.listList.LabelWrap = ((bool)(resources.GetObject("listList.LabelWrap")));
			this.listList.Location = ((System.Drawing.Point)(resources.GetObject("listList.Location")));
			this.listList.MultiSelect = false;
			this.listList.Name = "listList";
			this.listList.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listList.RightToLeft")));
			this.listList.Size = ((System.Drawing.Size)(resources.GetObject("listList.Size")));
			this.listList.TabIndex = ((int)(resources.GetObject("listList.TabIndex")));
			this.listList.Text = resources.GetString("listList.Text");
			this.listList.View = System.Windows.Forms.View.Details;
			this.listList.Visible = ((bool)(resources.GetObject("listList.Visible")));
			this.listList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listList_ColumnClick);
			this.listList.SelectedIndexChanged += new System.EventHandler(this.listList_SelectedIndexChanged);
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.listBanner);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// listBanner
			// 
			this.listBanner.AccessibleDescription = resources.GetString("listBanner.AccessibleDescription");
			this.listBanner.AccessibleName = resources.GetString("listBanner.AccessibleName");
			this.listBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("listBanner.Anchor")));
			this.listBanner.AutoSize = ((bool)(resources.GetObject("listBanner.AutoSize")));
			this.listBanner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("listBanner.Dock")));
			this.listBanner.Enabled = ((bool)(resources.GetObject("listBanner.Enabled")));
			this.listBanner.Font = ((System.Drawing.Font)(resources.GetObject("listBanner.Font")));
			this.listBanner.Image = ((System.Drawing.Image)(resources.GetObject("listBanner.Image")));
			this.listBanner.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("listBanner.ImageAlign")));
			this.listBanner.ImageIndex = ((int)(resources.GetObject("listBanner.ImageIndex")));
			this.listBanner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("listBanner.ImeMode")));
			this.listBanner.Location = ((System.Drawing.Point)(resources.GetObject("listBanner.Location")));
			this.listBanner.Name = "listBanner";
			this.listBanner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("listBanner.RightToLeft")));
			this.listBanner.Size = ((System.Drawing.Size)(resources.GetObject("listBanner.Size")));
			this.listBanner.TabIndex = ((int)(resources.GetObject("listBanner.TabIndex")));
			this.listBanner.Text = resources.GetString("listBanner.Text");
			this.listBanner.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("listBanner.TextAlign")));
			this.listBanner.Visible = ((bool)(resources.GetObject("listBanner.Visible")));
			// 
			// lllvcommit
			// 
			this.lllvcommit.AccessibleDescription = resources.GetString("lllvcommit.AccessibleDescription");
			this.lllvcommit.AccessibleName = resources.GetString("lllvcommit.AccessibleName");
			this.lllvcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lllvcommit.Anchor")));
			this.lllvcommit.AutoSize = ((bool)(resources.GetObject("lllvcommit.AutoSize")));
			this.lllvcommit.BackColor = System.Drawing.Color.Transparent;
			this.lllvcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lllvcommit.Dock")));
			this.lllvcommit.Enabled = ((bool)(resources.GetObject("lllvcommit.Enabled")));
			this.lllvcommit.Font = ((System.Drawing.Font)(resources.GetObject("lllvcommit.Font")));
			this.lllvcommit.Image = ((System.Drawing.Image)(resources.GetObject("lllvcommit.Image")));
			this.lllvcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lllvcommit.ImageAlign")));
			this.lllvcommit.ImageIndex = ((int)(resources.GetObject("lllvcommit.ImageIndex")));
			this.lllvcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lllvcommit.ImeMode")));
			this.lllvcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lllvcommit.LinkArea")));
			this.lllvcommit.Location = ((System.Drawing.Point)(resources.GetObject("lllvcommit.Location")));
			this.lllvcommit.Name = "lllvcommit";
			this.lllvcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lllvcommit.RightToLeft")));
			this.lllvcommit.Size = ((System.Drawing.Size)(resources.GetObject("lllvcommit.Size")));
			this.lllvcommit.TabIndex = ((int)(resources.GetObject("lllvcommit.TabIndex")));
			this.lllvcommit.TabStop = true;
			this.lllvcommit.Text = resources.GetString("lllvcommit.Text");
			this.lllvcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lllvcommit.TextAlign")));
			this.lllvcommit.Visible = ((bool)(resources.GetObject("lllvcommit.Visible")));
			this.lllvcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitListViewClick);
			// 
			// TreePanel
			// 
			this.TreePanel.AccessibleDescription = resources.GetString("TreePanel.AccessibleDescription");
			this.TreePanel.AccessibleName = resources.GetString("TreePanel.AccessibleName");
			this.TreePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TreePanel.Anchor")));
			this.TreePanel.AutoScroll = ((bool)(resources.GetObject("TreePanel.AutoScroll")));
			this.TreePanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("TreePanel.AutoScrollMargin")));
			this.TreePanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("TreePanel.AutoScrollMinSize")));
			this.TreePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TreePanel.BackgroundImage")));
			this.TreePanel.Controls.Add(this.mytree);
			this.TreePanel.Controls.Add(this.treeItemPanel);
			this.TreePanel.Controls.Add(this.panel4);
			this.TreePanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TreePanel.Dock")));
			this.TreePanel.Enabled = ((bool)(resources.GetObject("TreePanel.Enabled")));
			this.TreePanel.Font = ((System.Drawing.Font)(resources.GetObject("TreePanel.Font")));
			this.TreePanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TreePanel.ImeMode")));
			this.TreePanel.Location = ((System.Drawing.Point)(resources.GetObject("TreePanel.Location")));
			this.TreePanel.Name = "TreePanel";
			this.TreePanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TreePanel.RightToLeft")));
			this.TreePanel.Size = ((System.Drawing.Size)(resources.GetObject("TreePanel.Size")));
			this.TreePanel.TabIndex = ((int)(resources.GetObject("TreePanel.TabIndex")));
			this.TreePanel.Text = resources.GetString("TreePanel.Text");
			this.TreePanel.Visible = ((bool)(resources.GetObject("TreePanel.Visible")));
			// 
			// mytree
			// 
			this.mytree.AccessibleDescription = resources.GetString("mytree.AccessibleDescription");
			this.mytree.AccessibleName = resources.GetString("mytree.AccessibleName");
			this.mytree.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("mytree.Anchor")));
			this.mytree.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mytree.BackgroundImage")));
			this.mytree.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("mytree.Dock")));
			this.mytree.Enabled = ((bool)(resources.GetObject("mytree.Enabled")));
			this.mytree.Font = ((System.Drawing.Font)(resources.GetObject("mytree.Font")));
			this.mytree.ImageIndex = ((int)(resources.GetObject("mytree.ImageIndex")));
			this.mytree.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("mytree.ImeMode")));
			this.mytree.Indent = ((int)(resources.GetObject("mytree.Indent")));
			this.mytree.ItemHeight = ((int)(resources.GetObject("mytree.ItemHeight")));
			this.mytree.Location = ((System.Drawing.Point)(resources.GetObject("mytree.Location")));
			this.mytree.Name = "mytree";
			this.mytree.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mytree.RightToLeft")));
			this.mytree.SelectedImageIndex = ((int)(resources.GetObject("mytree.SelectedImageIndex")));
			this.mytree.Size = ((System.Drawing.Size)(resources.GetObject("mytree.Size")));
			this.mytree.TabIndex = ((int)(resources.GetObject("mytree.TabIndex")));
			this.mytree.Text = resources.GetString("mytree.Text");
			this.mytree.Visible = ((bool)(resources.GetObject("mytree.Visible")));
			this.mytree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.mytree_AfterSelect);
			// 
			// treeItemPanel
			// 
			this.treeItemPanel.AccessibleDescription = resources.GetString("treeItemPanel.AccessibleDescription");
			this.treeItemPanel.AccessibleName = resources.GetString("treeItemPanel.AccessibleName");
			this.treeItemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("treeItemPanel.Anchor")));
			this.treeItemPanel.AutoScroll = ((bool)(resources.GetObject("treeItemPanel.AutoScroll")));
			this.treeItemPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("treeItemPanel.AutoScrollMargin")));
			this.treeItemPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("treeItemPanel.AutoScrollMinSize")));
			this.treeItemPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("treeItemPanel.BackgroundImage")));
			this.treeItemPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("treeItemPanel.Dock")));
			this.treeItemPanel.Enabled = ((bool)(resources.GetObject("treeItemPanel.Enabled")));
			this.treeItemPanel.Font = ((System.Drawing.Font)(resources.GetObject("treeItemPanel.Font")));
			this.treeItemPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("treeItemPanel.ImeMode")));
			this.treeItemPanel.Location = ((System.Drawing.Point)(resources.GetObject("treeItemPanel.Location")));
			this.treeItemPanel.Name = "treeItemPanel";
			this.treeItemPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("treeItemPanel.RightToLeft")));
			this.treeItemPanel.Size = ((System.Drawing.Size)(resources.GetObject("treeItemPanel.Size")));
			this.treeItemPanel.TabIndex = ((int)(resources.GetObject("treeItemPanel.TabIndex")));
			this.treeItemPanel.Text = resources.GetString("treeItemPanel.Text");
			this.treeItemPanel.Visible = ((bool)(resources.GetObject("treeItemPanel.Visible")));
			// 
			// panel4
			// 
			this.panel4.AccessibleDescription = resources.GetString("panel4.AccessibleDescription");
			this.panel4.AccessibleName = resources.GetString("panel4.AccessibleName");
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel4.Anchor")));
			this.panel4.AutoScroll = ((bool)(resources.GetObject("panel4.AutoScroll")));
			this.panel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMargin")));
			this.panel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMinSize")));
			this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Controls.Add(this.treeBanner);
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
			// treeBanner
			// 
			this.treeBanner.AccessibleDescription = resources.GetString("treeBanner.AccessibleDescription");
			this.treeBanner.AccessibleName = resources.GetString("treeBanner.AccessibleName");
			this.treeBanner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("treeBanner.Anchor")));
			this.treeBanner.AutoSize = ((bool)(resources.GetObject("treeBanner.AutoSize")));
			this.treeBanner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("treeBanner.Dock")));
			this.treeBanner.Enabled = ((bool)(resources.GetObject("treeBanner.Enabled")));
			this.treeBanner.Font = ((System.Drawing.Font)(resources.GetObject("treeBanner.Font")));
			this.treeBanner.Image = ((System.Drawing.Image)(resources.GetObject("treeBanner.Image")));
			this.treeBanner.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("treeBanner.ImageAlign")));
			this.treeBanner.ImageIndex = ((int)(resources.GetObject("treeBanner.ImageIndex")));
			this.treeBanner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("treeBanner.ImeMode")));
			this.treeBanner.Location = ((System.Drawing.Point)(resources.GetObject("treeBanner.Location")));
			this.treeBanner.Name = "treeBanner";
			this.treeBanner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("treeBanner.RightToLeft")));
			this.treeBanner.Size = ((System.Drawing.Size)(resources.GetObject("treeBanner.Size")));
			this.treeBanner.TabIndex = ((int)(resources.GetObject("treeBanner.TabIndex")));
			this.treeBanner.Text = resources.GetString("treeBanner.Text");
			this.treeBanner.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("treeBanner.TextAlign")));
			this.treeBanner.Visible = ((bool)(resources.GetObject("treeBanner.Visible")));
			// 
			// GenericElements
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.TreePanel);
			this.Controls.Add(this.ListPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "GenericElements";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.GenericElements_Load);
			this.ListPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.TreePanel.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Sort by Column
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listList_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if (((ListView)sender).ListViewItemSorter == null) ((ListView)sender).ListViewItemSorter = sorter;
			sorter.CurrentColumn = e.Column;
			((ListView)sender).Sort();
		}

		/// <summary>
		/// Show Data in the Items Panel
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void listList_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			try 
			{
				ListView lv = (ListView)sender;
				if (lv.SelectedItems.Count==0) return;

				ListViewItem lvi = lv.SelectedItems[0];
				for (int i=0; i<lvi.SubItems.Count; i++)
				{
					foreach (Control c in itemPanel.Controls) 
					{
						//a textBox with a Tag?
						if (c.Tag!=null) 
						{
							int v = (int)c.Tag;
							//this Textbox is for this Item
							if (v==i) 
							{
								TextBox tb = (TextBox)c;
								tb.Text = lvi.SubItems[i].Text;
								tb.Tag = i;
							}
						}
					}
				}
			} 
			catch (Exception ex) 
			{
				this.Text = ex.Message;
			}
		}

		private void mytree_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			try 
			{
				TreeView tv = (TreeView)sender;
				Wrapper.GenericItem item = (Wrapper.GenericItem)tv.SelectedNode.Tag;
				string[] names = item.Names;

				foreach (Control c in treeItemPanel.Controls) 
				{
					//a textBox with a Tag?
					if (c.Tag!=null) 
					{
						int v = (int)c.Tag;
						//this Textbox is for this Item
						if ((v>=0) && (v<names.Length))
						{
							TextBox tb = (TextBox)c;
							object o = item.Properties[names[v]];
							if (o==null) o="";
							tb.Text = o.ToString();							
						}
					}
				}

			} 
			catch (Exception ex) 
			{
				this.Text = ex.Message;
			}
		}

		private void CommitListViewClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (listList.SelectedItems.Count==0) return;
			if (wrapper==null) return;

			foreach (Control c in itemPanel.Controls) 
			{
				if (c.Tag != null) 
				{
					listList.SelectedItems[0].SubItems[(int)c.Tag].Text = c.Text;

					if (listList.SelectedItems[0].Tag != null) 
					{
						SimPe.PackedFiles.Wrapper.GenericItem fileitem = (SimPe.PackedFiles.Wrapper.GenericItem)listList.SelectedItems[0].Tag;
						fileitem.Properties[listList.Columns[(int)c.Tag].Text] = c.Text;
					}
				}
			}
			wrapper.SynchronizeUserData();
		}

		private void GenericElements_Load(object sender, System.EventArgs e)
		{
		
		}
	}
}
