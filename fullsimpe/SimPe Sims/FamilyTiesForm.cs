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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für FamilyTiesForm.
	/// </summary>
	public class FamilyTiesForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FamilyTiesForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			ThemeManager tc = SimPe.ThemeManager.Global.CreateChild();
			tc.AddControl(this.pnfamt);
			tc.AddControl(this.panel2);
			tc.AddControl(this.pool);
			tc.AddControl(this.xpGradientPanel1);
			tc.AddControl(this.miAddTie);

			ties.Parent = null;
			ties.Parent = this.panel1;

			this.cbrel.Enum = typeof(Data.MetaData.FamilyTieTypes);
			this.cbrel.ResourceManager = Localization.Manager;
			//Data.MetaData.FamilyTieTypes[] ns = (Data.MetaData.FamilyTieTypes[])System.Enum.GetValues(typeof(Data.MetaData.FamilyTieTypes));
			//foreach (Data.MetaData.FamilyTieTypes n in ns) this.cbrel.Items.Add((Data.LocalizedFamilyTieTypes)n);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FamilyTiesForm));
			this.pnfamt = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.ties = new SimPe.PackedFiles.Wrapper.FamilyTieGraph();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.xpLine1 = new SteepValley.Windows.Forms.XPLine();
			this.button1 = new System.Windows.Forms.Button();
			this.cbkeep = new System.Windows.Forms.CheckBox();
			this.cbrel = new Ambertation.Windows.Forms.EnumComboBox();
			this.llrem = new System.Windows.Forms.LinkLabel();
			this.label3 = new System.Windows.Forms.Label();
			this.lbname = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pool = new SimPe.PackedFiles.Wrapper.SimPoolControl();
			this.label12 = new System.Windows.Forms.Label();
			this.sbm = new TD.SandBar.SandBarManager();
			this.leftSandBarDock = new TD.SandBar.ToolBarContainer();
			this.rightSandBarDock = new TD.SandBar.ToolBarContainer();
			this.bottomSandBarDock = new TD.SandBar.ToolBarContainer();
			this.topSandBarDock = new TD.SandBar.ToolBarContainer();
			this.menuBar1 = new TD.SandBar.MenuBar();
			this.miTies = new TD.SandBar.ContextMenuBarItem();
			this.miAddTie = new TD.SandBar.MenuButtonItem();
			this.miOpenSdesc = new TD.SandBar.MenuButtonItem();
			this.pnfamt.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.topSandBarDock.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnfamt
			// 
			this.pnfamt.AccessibleDescription = resources.GetString("pnfamt.AccessibleDescription");
			this.pnfamt.AccessibleName = resources.GetString("pnfamt.AccessibleName");
			this.pnfamt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnfamt.Anchor")));
			this.pnfamt.AutoScroll = ((bool)(resources.GetObject("pnfamt.AutoScroll")));
			this.pnfamt.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnfamt.AutoScrollMargin")));
			this.pnfamt.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnfamt.AutoScrollMinSize")));
			this.pnfamt.BackColor = System.Drawing.SystemColors.Control;
			this.pnfamt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnfamt.BackgroundImage")));
			this.pnfamt.Controls.Add(this.panel1);
			this.pnfamt.Controls.Add(this.panel4);
			this.pnfamt.Controls.Add(this.panel3);
			this.pnfamt.Controls.Add(this.panel2);
			this.pnfamt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnfamt.Dock")));
			this.pnfamt.Enabled = ((bool)(resources.GetObject("pnfamt.Enabled")));
			this.pnfamt.Font = ((System.Drawing.Font)(resources.GetObject("pnfamt.Font")));
			this.pnfamt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnfamt.ImeMode")));
			this.pnfamt.Location = ((System.Drawing.Point)(resources.GetObject("pnfamt.Location")));
			this.pnfamt.Name = "pnfamt";
			this.pnfamt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnfamt.RightToLeft")));
			this.pnfamt.Size = ((System.Drawing.Size)(resources.GetObject("pnfamt.Size")));
			this.pnfamt.TabIndex = ((int)(resources.GetObject("pnfamt.TabIndex")));
			this.pnfamt.Text = resources.GetString("pnfamt.Text");
			this.pnfamt.Visible = ((bool)(resources.GetObject("pnfamt.Visible")));
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.ties);
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
			// ties
			// 
			this.ties.AccessibleDescription = resources.GetString("ties.AccessibleDescription");
			this.ties.AccessibleName = resources.GetString("ties.AccessibleName");
			this.ties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ties.Anchor")));
			this.ties.AutoScroll = ((bool)(resources.GetObject("ties.AutoScroll")));
			this.ties.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("ties.AutoScrollMargin")));
			this.ties.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("ties.AutoScrollMinSize")));
			this.ties.AutoSize = true;
			this.ties.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ties.BackgroundImage")));
			this.ties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ties.Dock")));
			this.ties.Enabled = ((bool)(resources.GetObject("ties.Enabled")));
			this.ties.Font = ((System.Drawing.Font)(resources.GetObject("ties.Font")));
			this.ties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ties.ImeMode")));
			this.ties.LineMode = Ambertation.Windows.Forms.Graph.LinkControlLineMode.Bezier;
			this.ties.Location = ((System.Drawing.Point)(resources.GetObject("ties.Location")));
			this.ties.LockItems = false;
			this.ties.MinHeight = 296;
			this.ties.MinWidth = 520;
			this.ties.Name = "ties";
			this.ties.Quality = true;
			this.ties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ties.RightToLeft")));
			this.ties.SaveBounds = true;
			this.ties.SelectedElement = null;
			this.ties.Size = ((System.Drawing.Size)(resources.GetObject("ties.Size")));
			this.ties.TabIndex = ((int)(resources.GetObject("ties.TabIndex")));
			this.ties.Text = resources.GetString("ties.Text");
			this.ties.Visible = ((bool)(resources.GetObject("ties.Visible")));
			this.ties.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.ties_SelectedSimChanged);
			this.ties.DoubleClickSim += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.ties_DoubleClickSim);
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
			this.panel4.Controls.Add(this.label1);
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
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.xpGradientPanel1);
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
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
			this.xpGradientPanel1.Controls.Add(this.xpLine1);
			this.xpGradientPanel1.Controls.Add(this.button1);
			this.xpGradientPanel1.Controls.Add(this.cbkeep);
			this.xpGradientPanel1.Controls.Add(this.cbrel);
			this.xpGradientPanel1.Controls.Add(this.llrem);
			this.xpGradientPanel1.Controls.Add(this.label3);
			this.xpGradientPanel1.Controls.Add(this.lbname);
			this.xpGradientPanel1.Controls.Add(this.label2);
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// xpLine1
			// 
			this.xpLine1.AccessibleDescription = resources.GetString("xpLine1.AccessibleDescription");
			this.xpLine1.AccessibleName = resources.GetString("xpLine1.AccessibleName");
			this.xpLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpLine1.Anchor")));
			this.xpLine1.AutoScroll = ((bool)(resources.GetObject("xpLine1.AutoScroll")));
			this.xpLine1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpLine1.AutoScrollMargin")));
			this.xpLine1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpLine1.AutoScrollMinSize")));
			this.xpLine1.BackColor = System.Drawing.Color.Transparent;
			this.xpLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpLine1.BackgroundImage")));
			this.xpLine1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpLine1.Dock")));
			this.xpLine1.Enabled = ((bool)(resources.GetObject("xpLine1.Enabled")));
			this.xpLine1.Font = ((System.Drawing.Font)(resources.GetObject("xpLine1.Font")));
			this.xpLine1.ForeColor = System.Drawing.Color.Transparent;
			this.xpLine1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpLine1.ImeMode")));
			this.xpLine1.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(125)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.xpLine1.Location = ((System.Drawing.Point)(resources.GetObject("xpLine1.Location")));
			this.xpLine1.Name = "xpLine1";
			this.xpLine1.Orientation = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.xpLine1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpLine1.RightToLeft")));
			this.xpLine1.Size = ((System.Drawing.Size)(resources.GetObject("xpLine1.Size")));
			this.xpLine1.TabIndex = ((int)(resources.GetObject("xpLine1.TabIndex")));
			this.xpLine1.Visible = ((bool)(resources.GetObject("xpLine1.Visible")));
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
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbkeep
			// 
			this.cbkeep.AccessibleDescription = resources.GetString("cbkeep.AccessibleDescription");
			this.cbkeep.AccessibleName = resources.GetString("cbkeep.AccessibleName");
			this.cbkeep.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbkeep.Anchor")));
			this.cbkeep.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbkeep.Appearance")));
			this.cbkeep.BackColor = System.Drawing.Color.Transparent;
			this.cbkeep.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbkeep.BackgroundImage")));
			this.cbkeep.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbkeep.CheckAlign")));
			this.cbkeep.Checked = true;
			this.cbkeep.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbkeep.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbkeep.Dock")));
			this.cbkeep.Enabled = ((bool)(resources.GetObject("cbkeep.Enabled")));
			this.cbkeep.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbkeep.FlatStyle")));
			this.cbkeep.Font = ((System.Drawing.Font)(resources.GetObject("cbkeep.Font")));
			this.cbkeep.Image = ((System.Drawing.Image)(resources.GetObject("cbkeep.Image")));
			this.cbkeep.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbkeep.ImageAlign")));
			this.cbkeep.ImageIndex = ((int)(resources.GetObject("cbkeep.ImageIndex")));
			this.cbkeep.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbkeep.ImeMode")));
			this.cbkeep.Location = ((System.Drawing.Point)(resources.GetObject("cbkeep.Location")));
			this.cbkeep.Name = "cbkeep";
			this.cbkeep.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbkeep.RightToLeft")));
			this.cbkeep.Size = ((System.Drawing.Size)(resources.GetObject("cbkeep.Size")));
			this.cbkeep.TabIndex = ((int)(resources.GetObject("cbkeep.TabIndex")));
			this.cbkeep.Text = resources.GetString("cbkeep.Text");
			this.cbkeep.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbkeep.TextAlign")));
			this.cbkeep.Visible = ((bool)(resources.GetObject("cbkeep.Visible")));
			// 
			// cbrel
			// 
			this.cbrel.AccessibleDescription = resources.GetString("cbrel.AccessibleDescription");
			this.cbrel.AccessibleName = resources.GetString("cbrel.AccessibleName");
			this.cbrel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbrel.Anchor")));
			this.cbrel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbrel.BackgroundImage")));			
			this.cbrel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbrel.Dock")));
			this.cbrel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbrel.Enabled = ((bool)(resources.GetObject("cbrel.Enabled")));
			this.cbrel.Enum = null;
			this.cbrel.Font = ((System.Drawing.Font)(resources.GetObject("cbrel.Font")));
			this.cbrel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbrel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbrel.ImeMode")));
			this.cbrel.IntegralHeight = ((bool)(resources.GetObject("cbrel.IntegralHeight")));
			this.cbrel.ItemHeight = ((int)(resources.GetObject("cbrel.ItemHeight")));
			this.cbrel.Location = ((System.Drawing.Point)(resources.GetObject("cbrel.Location")));
			this.cbrel.MaxDropDownItems = ((int)(resources.GetObject("cbrel.MaxDropDownItems")));
			this.cbrel.MaxLength = ((int)(resources.GetObject("cbrel.MaxLength")));
			this.cbrel.Name = "cbrel";
			this.cbrel.ResourceManager = null;
			this.cbrel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbrel.RightToLeft")));
			this.cbrel.Size = ((System.Drawing.Size)(resources.GetObject("cbrel.Size")));
			this.cbrel.TabIndex = ((int)(resources.GetObject("cbrel.TabIndex")));
			this.cbrel.Text = resources.GetString("cbrel.Text");
			this.cbrel.Visible = ((bool)(resources.GetObject("cbrel.Visible")));
			this.cbrel.SelectedIndexChanged += new System.EventHandler(this.cbrel_SelectedIndexChanged);
			// 
			// llrem
			// 
			this.llrem.AccessibleDescription = resources.GetString("llrem.AccessibleDescription");
			this.llrem.AccessibleName = resources.GetString("llrem.AccessibleName");
			this.llrem.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llrem.Anchor")));
			this.llrem.AutoSize = ((bool)(resources.GetObject("llrem.AutoSize")));
			this.llrem.BackColor = System.Drawing.Color.Transparent;
			this.llrem.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llrem.Dock")));
			this.llrem.Enabled = ((bool)(resources.GetObject("llrem.Enabled")));
			this.llrem.Font = ((System.Drawing.Font)(resources.GetObject("llrem.Font")));
			this.llrem.Image = ((System.Drawing.Image)(resources.GetObject("llrem.Image")));
			this.llrem.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrem.ImageAlign")));
			this.llrem.ImageIndex = ((int)(resources.GetObject("llrem.ImageIndex")));
			this.llrem.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llrem.ImeMode")));
			this.llrem.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llrem.LinkArea")));
			this.llrem.Location = ((System.Drawing.Point)(resources.GetObject("llrem.Location")));
			this.llrem.Name = "llrem";
			this.llrem.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llrem.RightToLeft")));
			this.llrem.Size = ((System.Drawing.Size)(resources.GetObject("llrem.Size")));
			this.llrem.TabIndex = ((int)(resources.GetObject("llrem.TabIndex")));
			this.llrem.TabStop = true;
			this.llrem.Text = resources.GetString("llrem.Text");
			this.llrem.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrem.TextAlign")));
			this.llrem.Visible = ((bool)(resources.GetObject("llrem.Visible")));
			this.llrem.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llrem_LinkClicked);
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
			// lbname
			// 
			this.lbname.AccessibleDescription = resources.GetString("lbname.AccessibleDescription");
			this.lbname.AccessibleName = resources.GetString("lbname.AccessibleName");
			this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbname.Anchor")));
			this.lbname.AutoSize = ((bool)(resources.GetObject("lbname.AutoSize")));
			this.lbname.BackColor = System.Drawing.Color.Transparent;
			this.lbname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbname.Dock")));
			this.lbname.Enabled = ((bool)(resources.GetObject("lbname.Enabled")));
			this.lbname.Font = ((System.Drawing.Font)(resources.GetObject("lbname.Font")));
			this.lbname.Image = ((System.Drawing.Image)(resources.GetObject("lbname.Image")));
			this.lbname.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbname.ImageAlign")));
			this.lbname.ImageIndex = ((int)(resources.GetObject("lbname.ImageIndex")));
			this.lbname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbname.ImeMode")));
			this.lbname.Location = ((System.Drawing.Point)(resources.GetObject("lbname.Location")));
			this.lbname.Name = "lbname";
			this.lbname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbname.RightToLeft")));
			this.lbname.Size = ((System.Drawing.Size)(resources.GetObject("lbname.Size")));
			this.lbname.TabIndex = ((int)(resources.GetObject("lbname.TabIndex")));
			this.lbname.Text = resources.GetString("lbname.Text");
			this.lbname.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbname.TextAlign")));
			this.lbname.Visible = ((bool)(resources.GetObject("lbname.Visible")));
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
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.SystemColors.Info;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.pool);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
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
			// pool
			// 
			this.pool.AccessibleDescription = resources.GetString("pool.AccessibleDescription");
			this.pool.AccessibleName = resources.GetString("pool.AccessibleName");
			this.pool.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pool.Anchor")));
			this.pool.AutoScroll = ((bool)(resources.GetObject("pool.AutoScroll")));
			this.pool.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pool.AutoScrollMargin")));
			this.pool.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pool.AutoScrollMinSize")));
			this.pool.BackColor = System.Drawing.SystemColors.Info;
			this.pool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pool.BackgroundImage")));
			this.pool.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pool.Dock")));
			this.pool.Enabled = ((bool)(resources.GetObject("pool.Enabled")));
			this.pool.Font = ((System.Drawing.Font)(resources.GetObject("pool.Font")));
			this.pool.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pool.ImeMode")));
			this.pool.Location = ((System.Drawing.Point)(resources.GetObject("pool.Location")));
			this.pool.Name = "pool";
			this.pool.Package = null;
			this.pool.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pool.RightToLeft")));
			this.menuBar1.SetSandBarMenu(this.pool, this.miTies);
			this.pool.SelectedElement = null;
			this.pool.Size = ((System.Drawing.Size)(resources.GetObject("pool.Size")));
			this.pool.TabIndex = ((int)(resources.GetObject("pool.TabIndex")));
			this.pool.Visible = ((bool)(resources.GetObject("pool.Visible")));
			this.pool.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.pool_SelectedSimChanged);
			this.pool.ClickOverSim += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.pool_ClickOverSim);
			// 
			// label12
			// 
			this.label12.AccessibleDescription = resources.GetString("label12.AccessibleDescription");
			this.label12.AccessibleName = resources.GetString("label12.AccessibleName");
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label12.Anchor")));
			this.label12.AutoSize = ((bool)(resources.GetObject("label12.AutoSize")));
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
			// sbm
			// 
			this.sbm.OwnerForm = this;
			// 
			// leftSandBarDock
			// 
			this.leftSandBarDock.AccessibleDescription = resources.GetString("leftSandBarDock.AccessibleDescription");
			this.leftSandBarDock.AccessibleName = resources.GetString("leftSandBarDock.AccessibleName");
			this.leftSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("leftSandBarDock.Anchor")));
			this.leftSandBarDock.AutoScroll = ((bool)(resources.GetObject("leftSandBarDock.AutoScroll")));
			this.leftSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.AutoScrollMargin")));
			this.leftSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.AutoScrollMinSize")));
			this.leftSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftSandBarDock.BackgroundImage")));
			this.leftSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("leftSandBarDock.Dock")));
			this.leftSandBarDock.Enabled = ((bool)(resources.GetObject("leftSandBarDock.Enabled")));
			this.leftSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("leftSandBarDock.Font")));
			this.leftSandBarDock.Guid = new System.Guid("ef23c66a-0fa2-4990-8a0e-f7102ab62084");
			this.leftSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("leftSandBarDock.ImeMode")));
			this.leftSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("leftSandBarDock.Location")));
			this.leftSandBarDock.Manager = this.sbm;
			this.leftSandBarDock.Name = "leftSandBarDock";
			this.leftSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("leftSandBarDock.RightToLeft")));
			this.leftSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.Size")));
			this.leftSandBarDock.TabIndex = ((int)(resources.GetObject("leftSandBarDock.TabIndex")));
			this.leftSandBarDock.Text = resources.GetString("leftSandBarDock.Text");
			this.leftSandBarDock.Visible = ((bool)(resources.GetObject("leftSandBarDock.Visible")));
			// 
			// rightSandBarDock
			// 
			this.rightSandBarDock.AccessibleDescription = resources.GetString("rightSandBarDock.AccessibleDescription");
			this.rightSandBarDock.AccessibleName = resources.GetString("rightSandBarDock.AccessibleName");
			this.rightSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rightSandBarDock.Anchor")));
			this.rightSandBarDock.AutoScroll = ((bool)(resources.GetObject("rightSandBarDock.AutoScroll")));
			this.rightSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.AutoScrollMargin")));
			this.rightSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.AutoScrollMinSize")));
			this.rightSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightSandBarDock.BackgroundImage")));
			this.rightSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rightSandBarDock.Dock")));
			this.rightSandBarDock.Enabled = ((bool)(resources.GetObject("rightSandBarDock.Enabled")));
			this.rightSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("rightSandBarDock.Font")));
			this.rightSandBarDock.Guid = new System.Guid("3ba7fc21-aa74-4555-918d-8ea2562f1b6d");
			this.rightSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rightSandBarDock.ImeMode")));
			this.rightSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("rightSandBarDock.Location")));
			this.rightSandBarDock.Manager = this.sbm;
			this.rightSandBarDock.Name = "rightSandBarDock";
			this.rightSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rightSandBarDock.RightToLeft")));
			this.rightSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.Size")));
			this.rightSandBarDock.TabIndex = ((int)(resources.GetObject("rightSandBarDock.TabIndex")));
			this.rightSandBarDock.Text = resources.GetString("rightSandBarDock.Text");
			this.rightSandBarDock.Visible = ((bool)(resources.GetObject("rightSandBarDock.Visible")));
			// 
			// bottomSandBarDock
			// 
			this.bottomSandBarDock.AccessibleDescription = resources.GetString("bottomSandBarDock.AccessibleDescription");
			this.bottomSandBarDock.AccessibleName = resources.GetString("bottomSandBarDock.AccessibleName");
			this.bottomSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bottomSandBarDock.Anchor")));
			this.bottomSandBarDock.AutoScroll = ((bool)(resources.GetObject("bottomSandBarDock.AutoScroll")));
			this.bottomSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("bottomSandBarDock.AutoScrollMargin")));
			this.bottomSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("bottomSandBarDock.AutoScrollMinSize")));
			this.bottomSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomSandBarDock.BackgroundImage")));
			this.bottomSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bottomSandBarDock.Dock")));
			this.bottomSandBarDock.Enabled = ((bool)(resources.GetObject("bottomSandBarDock.Enabled")));
			this.bottomSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("bottomSandBarDock.Font")));
			this.bottomSandBarDock.Guid = new System.Guid("f7bd50a9-cc81-43c3-a955-f5ba54be102c");
			this.bottomSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bottomSandBarDock.ImeMode")));
			this.bottomSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("bottomSandBarDock.Location")));
			this.bottomSandBarDock.Manager = this.sbm;
			this.bottomSandBarDock.Name = "bottomSandBarDock";
			this.bottomSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bottomSandBarDock.RightToLeft")));
			this.bottomSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("bottomSandBarDock.Size")));
			this.bottomSandBarDock.TabIndex = ((int)(resources.GetObject("bottomSandBarDock.TabIndex")));
			this.bottomSandBarDock.Text = resources.GetString("bottomSandBarDock.Text");
			this.bottomSandBarDock.Visible = ((bool)(resources.GetObject("bottomSandBarDock.Visible")));
			// 
			// topSandBarDock
			// 
			this.topSandBarDock.AccessibleDescription = resources.GetString("topSandBarDock.AccessibleDescription");
			this.topSandBarDock.AccessibleName = resources.GetString("topSandBarDock.AccessibleName");
			this.topSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("topSandBarDock.Anchor")));
			this.topSandBarDock.AutoScroll = ((bool)(resources.GetObject("topSandBarDock.AutoScroll")));
			this.topSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.AutoScrollMargin")));
			this.topSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.AutoScrollMinSize")));
			this.topSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topSandBarDock.BackgroundImage")));
			this.topSandBarDock.Controls.Add(this.menuBar1);
			this.topSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("topSandBarDock.Dock")));
			this.topSandBarDock.Enabled = ((bool)(resources.GetObject("topSandBarDock.Enabled")));
			this.topSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("topSandBarDock.Font")));
			this.topSandBarDock.Guid = new System.Guid("1415b04d-c7b9-4bbc-bb17-767e257b871d");
			this.topSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("topSandBarDock.ImeMode")));
			this.topSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("topSandBarDock.Location")));
			this.topSandBarDock.Manager = this.sbm;
			this.topSandBarDock.Name = "topSandBarDock";
			this.topSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("topSandBarDock.RightToLeft")));
			this.topSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.Size")));
			this.topSandBarDock.TabIndex = ((int)(resources.GetObject("topSandBarDock.TabIndex")));
			this.topSandBarDock.Text = resources.GetString("topSandBarDock.Text");
			this.topSandBarDock.Visible = ((bool)(resources.GetObject("topSandBarDock.Visible")));
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
			this.menuBar1.Guid = new System.Guid("95c4d2fa-618f-4909-9750-debbac66fc2d");
			this.menuBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuBar1.ImeMode")));
			this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.miTies});
			this.menuBar1.Location = ((System.Drawing.Point)(resources.GetObject("menuBar1.Location")));
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.OwnerForm = this;
			this.menuBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuBar1.RightToLeft")));
			this.menuBar1.Size = ((System.Drawing.Size)(resources.GetObject("menuBar1.Size")));
			this.menuBar1.TabIndex = ((int)(resources.GetObject("menuBar1.TabIndex")));
			this.menuBar1.Text = resources.GetString("menuBar1.Text");
			this.menuBar1.Visible = ((bool)(resources.GetObject("menuBar1.Visible")));
			// 
			// miTies
			// 
			this.miTies.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			this.miAddTie,
																			this.miOpenSdesc});
			this.miTies.Text = resources.GetString("miTies.Text");
			this.miTies.ToolTipText = resources.GetString("miTies.ToolTipText");
			this.miTies.BeforePopup += new TD.SandBar.MenuItemBase.BeforePopupEventHandler(this.miAddTie_BeforePopup);
			// 
			// miAddTie
			// 
			this.miAddTie.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAddTie.Shortcut")));
			this.miAddTie.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAddTie.Shortcut2")));
			this.miAddTie.Tag = "\"{name}\" in die Familie von \"{gname}\" aufnehmen";
			this.miAddTie.Text = resources.GetString("miAddTie.Text");
			this.miAddTie.ToolTipText = resources.GetString("miAddTie.ToolTipText");
			this.miAddTie.Activate += new System.EventHandler(this.Activate_miAddTie);
			// 
			// miOpenSdesc
			// 
			this.miOpenSdesc.Image = ((System.Drawing.Image)(resources.GetObject("miOpenSdesc.Image")));
			this.miOpenSdesc.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenSdesc.Shortcut")));
			this.miOpenSdesc.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenSdesc.Shortcut2")));
			this.miOpenSdesc.Text = resources.GetString("miOpenSdesc.Text");
			this.miOpenSdesc.ToolTipText = resources.GetString("miOpenSdesc.ToolTipText");
			this.miOpenSdesc.Activate += new System.EventHandler(this.Activate_miOpenSDesc);
			// 
			// FamilyTiesForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.pnfamt);
			this.Controls.Add(this.leftSandBarDock);
			this.Controls.Add(this.rightSandBarDock);
			this.Controls.Add(this.bottomSandBarDock);
			this.Controls.Add(this.topSandBarDock);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "FamilyTiesForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.pnfamt.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.xpGradientPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.topSandBarDock.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.Panel pnfamt;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label label12;
		internal SimPe.PackedFiles.Wrapper.SimPoolControl pool;
		private System.Windows.Forms.Panel panel1;
		internal SimPe.PackedFiles.Wrapper.FamilyTieGraph ties;
		private TD.SandBar.SandBarManager sbm;
		private TD.SandBar.ToolBarContainer leftSandBarDock;
		private TD.SandBar.ToolBarContainer rightSandBarDock;
		private TD.SandBar.ToolBarContainer bottomSandBarDock;
		private TD.SandBar.ToolBarContainer topSandBarDock;
		private TD.SandBar.MenuBar menuBar1;

		internal Wrapper.ExtFamilyTies wrapper;
		private TD.SandBar.ContextMenuBarItem miTies;
		private TD.SandBar.MenuButtonItem miAddTie;


		SimPe.PackedFiles.Wrapper.SDesc lastsdsc, currentsdsc;
		internal System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel3;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.Label label3;
	
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel llrem;
		private Ambertation.Windows.Forms.EnumComboBox cbrel;
		private System.Windows.Forms.CheckBox cbkeep;
		private TD.SandBar.MenuButtonItem miOpenSdesc;
		private SteepValley.Windows.Forms.XPLine xpLine1;
		Image thumb;
		internal void pool_SelectedSimChanged(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			thumb = null;
			lastsdsc = null;
			currentsdsc = sdesc;
			ties.UpdateGraph(sdesc, wrapper);
		}

		private void miAddTie_BeforePopup(object sender, TD.SandBar.MenuPopupEventArgs e)
		{
			this.miAddTie.Enabled = (lastsdsc!=null && currentsdsc!=null && currentsdsc!=lastsdsc);
			this.miOpenSdesc.Enabled = (lastsdsc!=null);
			this.miAddTie.Image = thumb;
			//this.miOpenSdesc.Image = thumb;
			if (thumb!=null) miAddTie.Image = Ambertation.Drawing.GraphicRoutines.ScaleImage(thumb, 32, 32, true);
			if (lastsdsc!=null && currentsdsc!=null) 
			{
				string name = SimPe.Localization.GetString("AddFamilyTieCaption");
				name = name.Replace("{name}", lastsdsc.SimName+" "+lastsdsc.SimFamilyName);
				name = name.Replace("{gname}", currentsdsc.SimName+" "+currentsdsc.SimFamilyName);
				this.miAddTie.Text = name;

				SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = wrapper.FindTies(currentsdsc);
				if (fts!=null) if (fts.FindTie(lastsdsc)!=null) miAddTie.Enabled = false;				
			}

			if (lastsdsc!=null)
			{
				string name = SimPe.Localization.GetString("OpenSDesc");
				name = name.Replace("{name}", lastsdsc.SimName+" "+lastsdsc.SimFamilyName);
				this.miOpenSdesc.Text = name;
			}
		}

		private void pool_ClickOverSim(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			lastsdsc = sdesc;
			this.thumb = thumb;
		}

		private void Activate_miAddTie(object sender, System.EventArgs e)
		{
			SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = wrapper.CreateTie(currentsdsc);
			SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti = fts.CreateTie(lastsdsc, Data.MetaData.FamilyTieTypes.MySiblingIs);
			
			ties.AddTieToGraph(lastsdsc, 0, 0, fti.Type);

			if (this.cbkeep.Checked) 
			{
				fts = wrapper.CreateTie(lastsdsc);
				fti = fts.CreateTie(currentsdsc,  Data.MetaData.FamilyTieTypes.MySiblingIs);
			}
			wrapper.Changed = true;
		}

		private void ties_SelectedSimChanged(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			
			if (sdesc!=null) 
			{
				cbrel.Tag = null;
				this.lbname.Text = sdesc.SimName+" "+sdesc.SimFamilyName;
				cbrel.Enabled = (sdesc!=currentsdsc);
				if (cbrel.Enabled) 
				{
					SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = wrapper.FindTies(currentsdsc);
					SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti = fts.FindTie(sdesc);
					cbrel.SelectedValue = fti.Type;		
					cbrel.Tag = fti;
				}
			} 
			else 
			{
				
				cbrel.Enabled = (ties.SelectedElement!=null);
				if (!cbrel.Enabled) 
				{
					lbname.Text = "";
					cbrel.Tag = null;
				}
			}

			llrem.Enabled = cbrel.Enabled;
		}

		private void ties_DoubleClickSim(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			if (sdesc!=null && sdesc!=currentsdsc) 
			{
				//Ambertation.Windows.Forms.Graph.ImagePanel ip = pool.FindItem(sdesc);				
				pool.SelectedElement = sdesc;
			}
			
		}

		private void cbrel_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbrel.Tag!=null) 
			{
				SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti = (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem)cbrel.Tag;
				Ambertation.Windows.Forms.Graph.ImagePanel ip = (Ambertation.Windows.Forms.Graph.ImagePanel)ties.SelectedElement;
				fti.Type = (Data.MetaData.FamilyTieTypes)cbrel.SelectedValue;
				wrapper.Changed = true;

				Ambertation.Windows.Forms.Graph.LinkGraphic lg = ties.MainSimElement.GetChildLink(ip);
				if (lg!=null) lg.Text = cbrel.Text;

				if (this.cbkeep.Checked) 
				{
					SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = wrapper.CreateTie(fti.SimDescription);
					fti = fts.CreateTie(currentsdsc,  FamilyTieGraph.GetAntiTie(currentsdsc, fti.Type));
				}
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			wrapper.SynchronizeUserData();
		}

		private void llrem_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{		
			if (cbrel.Tag!=null) 
			{
				SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = wrapper.FindTies(currentsdsc);
				SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti = (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem)cbrel.Tag;
				
				if (fts.RemoveTie(fti)) 
				{
					Ambertation.Windows.Forms.Graph.ImagePanel ip = (Ambertation.Windows.Forms.Graph.ImagePanel)ties.SelectedElement;
					ip.Parent = null;						
					ip.Dispose();					
					wrapper.Changed = true;
				}
			}
		}

		private void Activate_miOpenSDesc(object sender, System.EventArgs e)
		{
			if (lastsdsc!=null)
				SimPe.RemoteControl.OpenPackedFile(lastsdsc.FileDescriptor, lastsdsc.Package);
		}
	}
}
