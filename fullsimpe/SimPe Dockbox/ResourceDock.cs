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

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Zusammenfassung für ResourceDock.
	/// </summary>
	public class ResourceDock : System.Windows.Forms.Form
	{
		private TD.SandDock.SandDockManager sandDockManager1;
		private TD.SandDock.DockContainer leftSandDock;
		private TD.SandDock.DockContainer rightSandDock;
		private TD.SandDock.DockContainer bottomSandDock;
		private TD.SandDock.DockContainer topSandDock;
		internal TD.SandDock.DockControl dcWrapper;
		internal TD.SandDock.DockControl dcResource;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
		internal System.Windows.Forms.Panel pntypes;
		internal System.Windows.Forms.TextBox tbinstance;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbgroup;
		internal System.Windows.Forms.ComboBox cbtypes;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.ComboBox cbComp;
		internal System.Windows.Forms.TextBox tbinstance2;
		internal System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.Label lbAuthor;
		internal System.Windows.Forms.Label lbVersion;
		internal System.Windows.Forms.Label lbDesc;
		internal System.Windows.Forms.Label lbComp;
		internal TD.SandDock.DockControl dcPackage;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ResourceDock()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			ThemeManager tm = FileTable.ThemeManager.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.xpGradientPanel2);
			tm.AddControl(this.xpGradientPanel3);

			foreach (SimPe.Data.TypeAlias a in SimPe.Helper.TGILoader.FileTypes) 
				cbtypes.Items.Add(a);			
			cbtypes.Sorted = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ResourceDock));
			this.sandDockManager1 = new TD.SandDock.SandDockManager();
			this.leftSandDock = new TD.SandDock.DockContainer();
			this.rightSandDock = new TD.SandDock.DockContainer();
			this.bottomSandDock = new TD.SandDock.DockContainer();
			this.dcResource = new TD.SandDock.DockControl();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.lbComp = new System.Windows.Forms.Label();
			this.cbComp = new System.Windows.Forms.ComboBox();
			this.pntypes = new System.Windows.Forms.Panel();
			this.tbinstance2 = new System.Windows.Forms.TextBox();
			this.tbinstance = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbgroup = new System.Windows.Forms.TextBox();
			this.cbtypes = new System.Windows.Forms.ComboBox();
			this.dcWrapper = new TD.SandDock.DockControl();
			this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.lbDesc = new System.Windows.Forms.Label();
			this.lbVersion = new System.Windows.Forms.Label();
			this.lbAuthor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.topSandDock = new TD.SandDock.DockContainer();
			this.dcPackage = new TD.SandDock.DockControl();
			this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.bottomSandDock.SuspendLayout();
			this.dcResource.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.pntypes.SuspendLayout();
			this.dcWrapper.SuspendLayout();
			this.xpGradientPanel2.SuspendLayout();
			this.dcPackage.SuspendLayout();
			this.SuspendLayout();
			// 
			// sandDockManager1
			// 
			this.sandDockManager1.OwnerForm = this;
			// 
			// leftSandDock
			// 
			this.leftSandDock.AccessibleDescription = resources.GetString("leftSandDock.AccessibleDescription");
			this.leftSandDock.AccessibleName = resources.GetString("leftSandDock.AccessibleName");
			this.leftSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("leftSandDock.Anchor")));
			this.leftSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftSandDock.BackgroundImage")));
			this.leftSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("leftSandDock.Dock")));
			this.leftSandDock.Enabled = ((bool)(resources.GetObject("leftSandDock.Enabled")));
			this.leftSandDock.Font = ((System.Drawing.Font)(resources.GetObject("leftSandDock.Font")));
			this.leftSandDock.Guid = new System.Guid("de247abc-edef-426a-8521-4ff2b66d4955");
			this.leftSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("leftSandDock.ImeMode")));
			this.leftSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.leftSandDock.Location = ((System.Drawing.Point)(resources.GetObject("leftSandDock.Location")));
			this.leftSandDock.Manager = this.sandDockManager1;
			this.leftSandDock.Name = "leftSandDock";
			this.leftSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("leftSandDock.RightToLeft")));
			this.leftSandDock.Size = ((System.Drawing.Size)(resources.GetObject("leftSandDock.Size")));
			this.leftSandDock.TabIndex = ((int)(resources.GetObject("leftSandDock.TabIndex")));
			this.leftSandDock.Text = resources.GetString("leftSandDock.Text");
			this.leftSandDock.Visible = ((bool)(resources.GetObject("leftSandDock.Visible")));
			// 
			// rightSandDock
			// 
			this.rightSandDock.AccessibleDescription = resources.GetString("rightSandDock.AccessibleDescription");
			this.rightSandDock.AccessibleName = resources.GetString("rightSandDock.AccessibleName");
			this.rightSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rightSandDock.Anchor")));
			this.rightSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightSandDock.BackgroundImage")));
			this.rightSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rightSandDock.Dock")));
			this.rightSandDock.Enabled = ((bool)(resources.GetObject("rightSandDock.Enabled")));
			this.rightSandDock.Font = ((System.Drawing.Font)(resources.GetObject("rightSandDock.Font")));
			this.rightSandDock.Guid = new System.Guid("bdfa5bc8-5b43-4cd2-9679-08a2ff53382f");
			this.rightSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rightSandDock.ImeMode")));
			this.rightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.rightSandDock.Location = ((System.Drawing.Point)(resources.GetObject("rightSandDock.Location")));
			this.rightSandDock.Manager = this.sandDockManager1;
			this.rightSandDock.Name = "rightSandDock";
			this.rightSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rightSandDock.RightToLeft")));
			this.rightSandDock.Size = ((System.Drawing.Size)(resources.GetObject("rightSandDock.Size")));
			this.rightSandDock.TabIndex = ((int)(resources.GetObject("rightSandDock.TabIndex")));
			this.rightSandDock.Text = resources.GetString("rightSandDock.Text");
			this.rightSandDock.Visible = ((bool)(resources.GetObject("rightSandDock.Visible")));
			// 
			// bottomSandDock
			// 
			this.bottomSandDock.AccessibleDescription = resources.GetString("bottomSandDock.AccessibleDescription");
			this.bottomSandDock.AccessibleName = resources.GetString("bottomSandDock.AccessibleName");
			this.bottomSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bottomSandDock.Anchor")));
			this.bottomSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomSandDock.BackgroundImage")));
			this.bottomSandDock.Controls.Add(this.dcResource);
			this.bottomSandDock.Controls.Add(this.dcPackage);
			this.bottomSandDock.Controls.Add(this.dcWrapper);
			this.bottomSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bottomSandDock.Dock")));
			this.bottomSandDock.Enabled = ((bool)(resources.GetObject("bottomSandDock.Enabled")));
			this.bottomSandDock.Font = ((System.Drawing.Font)(resources.GetObject("bottomSandDock.Font")));
			this.bottomSandDock.Guid = new System.Guid("f2b6c0a5-8de3-4a6e-8133-dd2ab495affc");
			this.bottomSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bottomSandDock.ImeMode")));
			this.bottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Vertical, new TD.SandDock.LayoutSystemBase[] {
																																											 new TD.SandDock.ControlLayoutSystem(632, 244, new TD.SandDock.DockControl[] {
																																																															 this.dcPackage,
																																																															 this.dcResource,
																																																															 this.dcWrapper}, this.dcPackage)});
			this.bottomSandDock.Location = ((System.Drawing.Point)(resources.GetObject("bottomSandDock.Location")));
			this.bottomSandDock.Manager = this.sandDockManager1;
			this.bottomSandDock.Name = "bottomSandDock";
			this.bottomSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bottomSandDock.RightToLeft")));
			this.bottomSandDock.Size = ((System.Drawing.Size)(resources.GetObject("bottomSandDock.Size")));
			this.bottomSandDock.TabIndex = ((int)(resources.GetObject("bottomSandDock.TabIndex")));
			this.bottomSandDock.Text = resources.GetString("bottomSandDock.Text");
			this.bottomSandDock.Visible = ((bool)(resources.GetObject("bottomSandDock.Visible")));
			// 
			// dcResource
			// 
			this.dcResource.AccessibleDescription = resources.GetString("dcResource.AccessibleDescription");
			this.dcResource.AccessibleName = resources.GetString("dcResource.AccessibleName");
			this.dcResource.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcResource.Anchor")));
			this.dcResource.AutoScroll = ((bool)(resources.GetObject("dcResource.AutoScroll")));
			this.dcResource.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcResource.AutoScrollMargin")));
			this.dcResource.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcResource.AutoScrollMinSize")));
			this.dcResource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcResource.BackgroundImage")));
			this.dcResource.Controls.Add(this.xpGradientPanel1);
			this.dcResource.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcResource.Dock")));
			this.dcResource.Enabled = ((bool)(resources.GetObject("dcResource.Enabled")));
			this.dcResource.FloatingSize = new System.Drawing.Size(496, 155);
			this.dcResource.Font = ((System.Drawing.Font)(resources.GetObject("dcResource.Font")));
			this.dcResource.Guid = new System.Guid("92cdd0fd-9459-4ee1-996e-12209714eadb");
			this.dcResource.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcResource.ImeMode")));
			this.dcResource.Location = ((System.Drawing.Point)(resources.GetObject("dcResource.Location")));
			this.dcResource.Name = "dcResource";
			this.dcResource.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcResource.RightToLeft")));
			this.dcResource.Size = ((System.Drawing.Size)(resources.GetObject("dcResource.Size")));
			this.dcResource.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResource.TabImage")));
			this.dcResource.TabIndex = ((int)(resources.GetObject("dcResource.TabIndex")));
			this.dcResource.TabText = resources.GetString("dcResource.TabText");
			this.dcResource.Text = resources.GetString("dcResource.Text");
			this.dcResource.ToolTipText = resources.GetString("dcResource.ToolTipText");
			this.dcResource.Visible = ((bool)(resources.GetObject("dcResource.Visible")));
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
			this.xpGradientPanel1.Controls.Add(this.lbComp);
			this.xpGradientPanel1.Controls.Add(this.cbComp);
			this.xpGradientPanel1.Controls.Add(this.pntypes);
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
			// lbComp
			// 
			this.lbComp.AccessibleDescription = resources.GetString("lbComp.AccessibleDescription");
			this.lbComp.AccessibleName = resources.GetString("lbComp.AccessibleName");
			this.lbComp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbComp.Anchor")));
			this.lbComp.AutoSize = ((bool)(resources.GetObject("lbComp.AutoSize")));
			this.lbComp.BackColor = System.Drawing.Color.Transparent;
			this.lbComp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbComp.Dock")));
			this.lbComp.Enabled = ((bool)(resources.GetObject("lbComp.Enabled")));
			this.lbComp.Font = ((System.Drawing.Font)(resources.GetObject("lbComp.Font")));
			this.lbComp.Image = ((System.Drawing.Image)(resources.GetObject("lbComp.Image")));
			this.lbComp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbComp.ImageAlign")));
			this.lbComp.ImageIndex = ((int)(resources.GetObject("lbComp.ImageIndex")));
			this.lbComp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbComp.ImeMode")));
			this.lbComp.Location = ((System.Drawing.Point)(resources.GetObject("lbComp.Location")));
			this.lbComp.Name = "lbComp";
			this.lbComp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbComp.RightToLeft")));
			this.lbComp.Size = ((System.Drawing.Size)(resources.GetObject("lbComp.Size")));
			this.lbComp.TabIndex = ((int)(resources.GetObject("lbComp.TabIndex")));
			this.lbComp.Text = resources.GetString("lbComp.Text");
			this.lbComp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbComp.TextAlign")));
			this.lbComp.Visible = ((bool)(resources.GetObject("lbComp.Visible")));
			// 
			// cbComp
			// 
			this.cbComp.AccessibleDescription = resources.GetString("cbComp.AccessibleDescription");
			this.cbComp.AccessibleName = resources.GetString("cbComp.AccessibleName");
			this.cbComp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbComp.Anchor")));
			this.cbComp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbComp.BackgroundImage")));
			this.cbComp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbComp.Dock")));
			this.cbComp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbComp.Enabled = ((bool)(resources.GetObject("cbComp.Enabled")));
			this.cbComp.Font = ((System.Drawing.Font)(resources.GetObject("cbComp.Font")));
			this.cbComp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbComp.ImeMode")));
			this.cbComp.IntegralHeight = ((bool)(resources.GetObject("cbComp.IntegralHeight")));
			this.cbComp.ItemHeight = ((int)(resources.GetObject("cbComp.ItemHeight")));
			this.cbComp.Items.AddRange(new object[] {
														resources.GetString("cbComp.Items"),
														resources.GetString("cbComp.Items1"),
														resources.GetString("cbComp.Items2")});
			this.cbComp.Location = ((System.Drawing.Point)(resources.GetObject("cbComp.Location")));
			this.cbComp.MaxDropDownItems = ((int)(resources.GetObject("cbComp.MaxDropDownItems")));
			this.cbComp.MaxLength = ((int)(resources.GetObject("cbComp.MaxLength")));
			this.cbComp.Name = "cbComp";
			this.cbComp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbComp.RightToLeft")));
			this.cbComp.Size = ((System.Drawing.Size)(resources.GetObject("cbComp.Size")));
			this.cbComp.TabIndex = ((int)(resources.GetObject("cbComp.TabIndex")));
			this.cbComp.Text = resources.GetString("cbComp.Text");
			this.cbComp.Visible = ((bool)(resources.GetObject("cbComp.Visible")));
			this.cbComp.SelectedIndexChanged += new System.EventHandler(this.cbComp_SelectedIndexChanged);
			// 
			// pntypes
			// 
			this.pntypes.AccessibleDescription = resources.GetString("pntypes.AccessibleDescription");
			this.pntypes.AccessibleName = resources.GetString("pntypes.AccessibleName");
			this.pntypes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pntypes.Anchor")));
			this.pntypes.AutoScroll = ((bool)(resources.GetObject("pntypes.AutoScroll")));
			this.pntypes.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pntypes.AutoScrollMargin")));
			this.pntypes.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pntypes.AutoScrollMinSize")));
			this.pntypes.BackColor = System.Drawing.Color.Transparent;
			this.pntypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pntypes.BackgroundImage")));
			this.pntypes.Controls.Add(this.tbinstance2);
			this.pntypes.Controls.Add(this.tbinstance);
			this.pntypes.Controls.Add(this.label11);
			this.pntypes.Controls.Add(this.tbtype);
			this.pntypes.Controls.Add(this.label8);
			this.pntypes.Controls.Add(this.label9);
			this.pntypes.Controls.Add(this.label10);
			this.pntypes.Controls.Add(this.tbgroup);
			this.pntypes.Controls.Add(this.cbtypes);
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
			// tbinstance2
			// 
			this.tbinstance2.AccessibleDescription = resources.GetString("tbinstance2.AccessibleDescription");
			this.tbinstance2.AccessibleName = resources.GetString("tbinstance2.AccessibleName");
			this.tbinstance2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinstance2.Anchor")));
			this.tbinstance2.AutoSize = ((bool)(resources.GetObject("tbinstance2.AutoSize")));
			this.tbinstance2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinstance2.BackgroundImage")));
			this.tbinstance2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinstance2.Dock")));
			this.tbinstance2.Enabled = ((bool)(resources.GetObject("tbinstance2.Enabled")));
			this.tbinstance2.Font = ((System.Drawing.Font)(resources.GetObject("tbinstance2.Font")));
			this.tbinstance2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinstance2.ImeMode")));
			this.tbinstance2.Location = ((System.Drawing.Point)(resources.GetObject("tbinstance2.Location")));
			this.tbinstance2.MaxLength = ((int)(resources.GetObject("tbinstance2.MaxLength")));
			this.tbinstance2.Multiline = ((bool)(resources.GetObject("tbinstance2.Multiline")));
			this.tbinstance2.Name = "tbinstance2";
			this.tbinstance2.PasswordChar = ((char)(resources.GetObject("tbinstance2.PasswordChar")));
			this.tbinstance2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinstance2.RightToLeft")));
			this.tbinstance2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinstance2.ScrollBars")));
			this.tbinstance2.Size = ((System.Drawing.Size)(resources.GetObject("tbinstance2.Size")));
			this.tbinstance2.TabIndex = ((int)(resources.GetObject("tbinstance2.TabIndex")));
			this.tbinstance2.Text = resources.GetString("tbinstance2.Text");
			this.tbinstance2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinstance2.TextAlign")));
			this.tbinstance2.Visible = ((bool)(resources.GetObject("tbinstance2.Visible")));
			this.tbinstance2.WordWrap = ((bool)(resources.GetObject("tbinstance2.WordWrap")));
			this.tbinstance2.TextChanged += new System.EventHandler(this.tbinstance_TextChanged);
			this.tbinstance2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance_KeyUp);
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
			this.tbinstance.TextChanged += new System.EventHandler(this.tbinstance2_TextChanged);
			this.tbinstance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance2_KeyUp);
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
			// tbtype
			// 
			this.tbtype.AccessibleDescription = resources.GetString("tbtype.AccessibleDescription");
			this.tbtype.AccessibleName = resources.GetString("tbtype.AccessibleName");
			this.tbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbtype.Anchor")));
			this.tbtype.AutoSize = ((bool)(resources.GetObject("tbtype.AutoSize")));
			this.tbtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbtype.BackgroundImage")));
			this.tbtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbtype.Dock")));
			this.tbtype.Enabled = ((bool)(resources.GetObject("tbtype.Enabled")));
			this.tbtype.Font = ((System.Drawing.Font)(resources.GetObject("tbtype.Font")));
			this.tbtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbtype.ImeMode")));
			this.tbtype.Location = ((System.Drawing.Point)(resources.GetObject("tbtype.Location")));
			this.tbtype.MaxLength = ((int)(resources.GetObject("tbtype.MaxLength")));
			this.tbtype.Multiline = ((bool)(resources.GetObject("tbtype.Multiline")));
			this.tbtype.Name = "tbtype";
			this.tbtype.PasswordChar = ((char)(resources.GetObject("tbtype.PasswordChar")));
			this.tbtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbtype.RightToLeft")));
			this.tbtype.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbtype.ScrollBars")));
			this.tbtype.Size = ((System.Drawing.Size)(resources.GetObject("tbtype.Size")));
			this.tbtype.TabIndex = ((int)(resources.GetObject("tbtype.TabIndex")));
			this.tbtype.Text = resources.GetString("tbtype.Text");
			this.tbtype.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbtype.TextAlign")));
			this.tbtype.Visible = ((bool)(resources.GetObject("tbtype.Visible")));
			this.tbtype.WordWrap = ((bool)(resources.GetObject("tbtype.WordWrap")));
			this.tbtype.TextChanged += new System.EventHandler(this.tbtype_TextChanged);
			this.tbtype.Leave += new System.EventHandler(this.tbtype_TextChanged2);
			this.tbtype.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbtype_KeyUp);
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
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
			// label10
			// 
			this.label10.AccessibleDescription = resources.GetString("label10.AccessibleDescription");
			this.label10.AccessibleName = resources.GetString("label10.AccessibleName");
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label10.Anchor")));
			this.label10.AutoSize = ((bool)(resources.GetObject("label10.AutoSize")));
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
			this.tbgroup.Leave += new System.EventHandler(this.tbgroup_TextChanged);
			this.tbgroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbgroup_KeyUp);
			// 
			// cbtypes
			// 
			this.cbtypes.AccessibleDescription = resources.GetString("cbtypes.AccessibleDescription");
			this.cbtypes.AccessibleName = resources.GetString("cbtypes.AccessibleName");
			this.cbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtypes.Anchor")));
			this.cbtypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtypes.BackgroundImage")));
			this.cbtypes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtypes.Dock")));
			this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtypes.Enabled = ((bool)(resources.GetObject("cbtypes.Enabled")));
			this.cbtypes.Font = ((System.Drawing.Font)(resources.GetObject("cbtypes.Font")));
			this.cbtypes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtypes.ImeMode")));
			this.cbtypes.IntegralHeight = ((bool)(resources.GetObject("cbtypes.IntegralHeight")));
			this.cbtypes.ItemHeight = ((int)(resources.GetObject("cbtypes.ItemHeight")));
			this.cbtypes.Location = ((System.Drawing.Point)(resources.GetObject("cbtypes.Location")));
			this.cbtypes.MaxDropDownItems = ((int)(resources.GetObject("cbtypes.MaxDropDownItems")));
			this.cbtypes.MaxLength = ((int)(resources.GetObject("cbtypes.MaxLength")));
			this.cbtypes.Name = "cbtypes";
			this.cbtypes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtypes.RightToLeft")));
			this.cbtypes.Size = ((System.Drawing.Size)(resources.GetObject("cbtypes.Size")));
			this.cbtypes.TabIndex = ((int)(resources.GetObject("cbtypes.TabIndex")));
			this.cbtypes.Text = resources.GetString("cbtypes.Text");
			this.cbtypes.Visible = ((bool)(resources.GetObject("cbtypes.Visible")));
			this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.cbtypes_SelectedIndexChanged);
			// 
			// dcWrapper
			// 
			this.dcWrapper.AccessibleDescription = resources.GetString("dcWrapper.AccessibleDescription");
			this.dcWrapper.AccessibleName = resources.GetString("dcWrapper.AccessibleName");
			this.dcWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcWrapper.Anchor")));
			this.dcWrapper.AutoScroll = ((bool)(resources.GetObject("dcWrapper.AutoScroll")));
			this.dcWrapper.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcWrapper.AutoScrollMargin")));
			this.dcWrapper.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcWrapper.AutoScrollMinSize")));
			this.dcWrapper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcWrapper.BackgroundImage")));
			this.dcWrapper.Controls.Add(this.xpGradientPanel2);
			this.dcWrapper.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcWrapper.Dock")));
			this.dcWrapper.Enabled = ((bool)(resources.GetObject("dcWrapper.Enabled")));
			this.dcWrapper.FloatingSize = new System.Drawing.Size(336, 203);
			this.dcWrapper.Font = ((System.Drawing.Font)(resources.GetObject("dcWrapper.Font")));
			this.dcWrapper.Guid = new System.Guid("08b8d9e4-7e3d-4458-8f9b-cd42de900a07");
			this.dcWrapper.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcWrapper.ImeMode")));
			this.dcWrapper.Location = ((System.Drawing.Point)(resources.GetObject("dcWrapper.Location")));
			this.dcWrapper.Name = "dcWrapper";
			this.dcWrapper.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcWrapper.RightToLeft")));
			this.dcWrapper.Size = ((System.Drawing.Size)(resources.GetObject("dcWrapper.Size")));
			this.dcWrapper.TabImage = ((System.Drawing.Image)(resources.GetObject("dcWrapper.TabImage")));
			this.dcWrapper.TabIndex = ((int)(resources.GetObject("dcWrapper.TabIndex")));
			this.dcWrapper.TabText = resources.GetString("dcWrapper.TabText");
			this.dcWrapper.Text = resources.GetString("dcWrapper.Text");
			this.dcWrapper.ToolTipText = resources.GetString("dcWrapper.ToolTipText");
			this.dcWrapper.Visible = ((bool)(resources.GetObject("dcWrapper.Visible")));
			// 
			// xpGradientPanel2
			// 
			this.xpGradientPanel2.AccessibleDescription = resources.GetString("xpGradientPanel2.AccessibleDescription");
			this.xpGradientPanel2.AccessibleName = resources.GetString("xpGradientPanel2.AccessibleName");
			this.xpGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel2.Anchor")));
			this.xpGradientPanel2.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel2.AutoScroll")));
			this.xpGradientPanel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.AutoScrollMargin")));
			this.xpGradientPanel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.AutoScrollMinSize")));
			this.xpGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel2.BackgroundImage")));
			this.xpGradientPanel2.Controls.Add(this.lbDesc);
			this.xpGradientPanel2.Controls.Add(this.lbVersion);
			this.xpGradientPanel2.Controls.Add(this.lbAuthor);
			this.xpGradientPanel2.Controls.Add(this.label5);
			this.xpGradientPanel2.Controls.Add(this.label2);
			this.xpGradientPanel2.Controls.Add(this.label1);
			this.xpGradientPanel2.Controls.Add(this.lbName);
			this.xpGradientPanel2.Controls.Add(this.label3);
			this.xpGradientPanel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel2.Dock")));
			this.xpGradientPanel2.Enabled = ((bool)(resources.GetObject("xpGradientPanel2.Enabled")));
			this.xpGradientPanel2.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel2.Font")));
			this.xpGradientPanel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel2.ImeMode")));
			this.xpGradientPanel2.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel2.Location")));
			this.xpGradientPanel2.Name = "xpGradientPanel2";
			this.xpGradientPanel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel2.RightToLeft")));
			this.xpGradientPanel2.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.Size")));
			this.xpGradientPanel2.TabIndex = ((int)(resources.GetObject("xpGradientPanel2.TabIndex")));
			this.xpGradientPanel2.Text = resources.GetString("xpGradientPanel2.Text");
			this.xpGradientPanel2.Visible = ((bool)(resources.GetObject("xpGradientPanel2.Visible")));
			this.xpGradientPanel2.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel2.Watermark")));
			this.xpGradientPanel2.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.WatermarkSize")));
			// 
			// lbDesc
			// 
			this.lbDesc.AccessibleDescription = resources.GetString("lbDesc.AccessibleDescription");
			this.lbDesc.AccessibleName = resources.GetString("lbDesc.AccessibleName");
			this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbDesc.Anchor")));
			this.lbDesc.AutoSize = ((bool)(resources.GetObject("lbDesc.AutoSize")));
			this.lbDesc.BackColor = System.Drawing.Color.Transparent;
			this.lbDesc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbDesc.Dock")));
			this.lbDesc.Enabled = ((bool)(resources.GetObject("lbDesc.Enabled")));
			this.lbDesc.Font = ((System.Drawing.Font)(resources.GetObject("lbDesc.Font")));
			this.lbDesc.Image = ((System.Drawing.Image)(resources.GetObject("lbDesc.Image")));
			this.lbDesc.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbDesc.ImageAlign")));
			this.lbDesc.ImageIndex = ((int)(resources.GetObject("lbDesc.ImageIndex")));
			this.lbDesc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbDesc.ImeMode")));
			this.lbDesc.Location = ((System.Drawing.Point)(resources.GetObject("lbDesc.Location")));
			this.lbDesc.Name = "lbDesc";
			this.lbDesc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbDesc.RightToLeft")));
			this.lbDesc.Size = ((System.Drawing.Size)(resources.GetObject("lbDesc.Size")));
			this.lbDesc.TabIndex = ((int)(resources.GetObject("lbDesc.TabIndex")));
			this.lbDesc.Text = resources.GetString("lbDesc.Text");
			this.lbDesc.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbDesc.TextAlign")));
			this.lbDesc.Visible = ((bool)(resources.GetObject("lbDesc.Visible")));
			// 
			// lbVersion
			// 
			this.lbVersion.AccessibleDescription = resources.GetString("lbVersion.AccessibleDescription");
			this.lbVersion.AccessibleName = resources.GetString("lbVersion.AccessibleName");
			this.lbVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbVersion.Anchor")));
			this.lbVersion.AutoSize = ((bool)(resources.GetObject("lbVersion.AutoSize")));
			this.lbVersion.BackColor = System.Drawing.Color.Transparent;
			this.lbVersion.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbVersion.Dock")));
			this.lbVersion.Enabled = ((bool)(resources.GetObject("lbVersion.Enabled")));
			this.lbVersion.Font = ((System.Drawing.Font)(resources.GetObject("lbVersion.Font")));
			this.lbVersion.Image = ((System.Drawing.Image)(resources.GetObject("lbVersion.Image")));
			this.lbVersion.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVersion.ImageAlign")));
			this.lbVersion.ImageIndex = ((int)(resources.GetObject("lbVersion.ImageIndex")));
			this.lbVersion.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbVersion.ImeMode")));
			this.lbVersion.Location = ((System.Drawing.Point)(resources.GetObject("lbVersion.Location")));
			this.lbVersion.Name = "lbVersion";
			this.lbVersion.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbVersion.RightToLeft")));
			this.lbVersion.Size = ((System.Drawing.Size)(resources.GetObject("lbVersion.Size")));
			this.lbVersion.TabIndex = ((int)(resources.GetObject("lbVersion.TabIndex")));
			this.lbVersion.Text = resources.GetString("lbVersion.Text");
			this.lbVersion.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVersion.TextAlign")));
			this.lbVersion.Visible = ((bool)(resources.GetObject("lbVersion.Visible")));
			// 
			// lbAuthor
			// 
			this.lbAuthor.AccessibleDescription = resources.GetString("lbAuthor.AccessibleDescription");
			this.lbAuthor.AccessibleName = resources.GetString("lbAuthor.AccessibleName");
			this.lbAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbAuthor.Anchor")));
			this.lbAuthor.AutoSize = ((bool)(resources.GetObject("lbAuthor.AutoSize")));
			this.lbAuthor.BackColor = System.Drawing.Color.Transparent;
			this.lbAuthor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbAuthor.Dock")));
			this.lbAuthor.Enabled = ((bool)(resources.GetObject("lbAuthor.Enabled")));
			this.lbAuthor.Font = ((System.Drawing.Font)(resources.GetObject("lbAuthor.Font")));
			this.lbAuthor.Image = ((System.Drawing.Image)(resources.GetObject("lbAuthor.Image")));
			this.lbAuthor.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbAuthor.ImageAlign")));
			this.lbAuthor.ImageIndex = ((int)(resources.GetObject("lbAuthor.ImageIndex")));
			this.lbAuthor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbAuthor.ImeMode")));
			this.lbAuthor.Location = ((System.Drawing.Point)(resources.GetObject("lbAuthor.Location")));
			this.lbAuthor.Name = "lbAuthor";
			this.lbAuthor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbAuthor.RightToLeft")));
			this.lbAuthor.Size = ((System.Drawing.Size)(resources.GetObject("lbAuthor.Size")));
			this.lbAuthor.TabIndex = ((int)(resources.GetObject("lbAuthor.TabIndex")));
			this.lbAuthor.Text = resources.GetString("lbAuthor.Text");
			this.lbAuthor.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbAuthor.TextAlign")));
			this.lbAuthor.Visible = ((bool)(resources.GetObject("lbAuthor.Visible")));
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
			// lbName
			// 
			this.lbName.AccessibleDescription = resources.GetString("lbName.AccessibleDescription");
			this.lbName.AccessibleName = resources.GetString("lbName.AccessibleName");
			this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbName.Anchor")));
			this.lbName.AutoSize = ((bool)(resources.GetObject("lbName.AutoSize")));
			this.lbName.BackColor = System.Drawing.Color.Transparent;
			this.lbName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbName.Dock")));
			this.lbName.Enabled = ((bool)(resources.GetObject("lbName.Enabled")));
			this.lbName.Font = ((System.Drawing.Font)(resources.GetObject("lbName.Font")));
			this.lbName.Image = ((System.Drawing.Image)(resources.GetObject("lbName.Image")));
			this.lbName.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbName.ImageAlign")));
			this.lbName.ImageIndex = ((int)(resources.GetObject("lbName.ImageIndex")));
			this.lbName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbName.ImeMode")));
			this.lbName.Location = ((System.Drawing.Point)(resources.GetObject("lbName.Location")));
			this.lbName.Name = "lbName";
			this.lbName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbName.RightToLeft")));
			this.lbName.Size = ((System.Drawing.Size)(resources.GetObject("lbName.Size")));
			this.lbName.TabIndex = ((int)(resources.GetObject("lbName.TabIndex")));
			this.lbName.Text = resources.GetString("lbName.Text");
			this.lbName.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbName.TextAlign")));
			this.lbName.Visible = ((bool)(resources.GetObject("lbName.Visible")));
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
			// topSandDock
			// 
			this.topSandDock.AccessibleDescription = resources.GetString("topSandDock.AccessibleDescription");
			this.topSandDock.AccessibleName = resources.GetString("topSandDock.AccessibleName");
			this.topSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("topSandDock.Anchor")));
			this.topSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topSandDock.BackgroundImage")));
			this.topSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("topSandDock.Dock")));
			this.topSandDock.Enabled = ((bool)(resources.GetObject("topSandDock.Enabled")));
			this.topSandDock.Font = ((System.Drawing.Font)(resources.GetObject("topSandDock.Font")));
			this.topSandDock.Guid = new System.Guid("7962cf0b-ae0c-4511-b000-2beeeb8f2b47");
			this.topSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("topSandDock.ImeMode")));
			this.topSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.topSandDock.Location = ((System.Drawing.Point)(resources.GetObject("topSandDock.Location")));
			this.topSandDock.Manager = this.sandDockManager1;
			this.topSandDock.Name = "topSandDock";
			this.topSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("topSandDock.RightToLeft")));
			this.topSandDock.Size = ((System.Drawing.Size)(resources.GetObject("topSandDock.Size")));
			this.topSandDock.TabIndex = ((int)(resources.GetObject("topSandDock.TabIndex")));
			this.topSandDock.Text = resources.GetString("topSandDock.Text");
			this.topSandDock.Visible = ((bool)(resources.GetObject("topSandDock.Visible")));
			// 
			// dcPackage
			// 
			this.dcPackage.AccessibleDescription = resources.GetString("dcPackage.AccessibleDescription");
			this.dcPackage.AccessibleName = resources.GetString("dcPackage.AccessibleName");
			this.dcPackage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcPackage.Anchor")));
			this.dcPackage.AutoScroll = ((bool)(resources.GetObject("dcPackage.AutoScroll")));
			this.dcPackage.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcPackage.AutoScrollMargin")));
			this.dcPackage.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcPackage.AutoScrollMinSize")));
			this.dcPackage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcPackage.BackgroundImage")));
			this.dcPackage.Controls.Add(this.xpGradientPanel3);
			this.dcPackage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcPackage.Dock")));
			this.dcPackage.Enabled = ((bool)(resources.GetObject("dcPackage.Enabled")));
			this.dcPackage.Font = ((System.Drawing.Font)(resources.GetObject("dcPackage.Font")));
			this.dcPackage.Guid = new System.Guid("d259ab3a-94c5-4303-bdfc-c471f471b090");
			this.dcPackage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcPackage.ImeMode")));
			this.dcPackage.Location = ((System.Drawing.Point)(resources.GetObject("dcPackage.Location")));
			this.dcPackage.Name = "dcPackage";
			this.dcPackage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcPackage.RightToLeft")));
			this.dcPackage.Size = ((System.Drawing.Size)(resources.GetObject("dcPackage.Size")));
			this.dcPackage.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPackage.TabImage")));
			this.dcPackage.TabIndex = ((int)(resources.GetObject("dcPackage.TabIndex")));
			this.dcPackage.TabText = resources.GetString("dcPackage.TabText");
			this.dcPackage.Text = resources.GetString("dcPackage.Text");
			this.dcPackage.ToolTipText = resources.GetString("dcPackage.ToolTipText");
			this.dcPackage.Visible = ((bool)(resources.GetObject("dcPackage.Visible")));
			// 
			// xpGradientPanel3
			// 
			this.xpGradientPanel3.AccessibleDescription = resources.GetString("xpGradientPanel3.AccessibleDescription");
			this.xpGradientPanel3.AccessibleName = resources.GetString("xpGradientPanel3.AccessibleName");
			this.xpGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel3.Anchor")));
			this.xpGradientPanel3.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel3.AutoScroll")));
			this.xpGradientPanel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.AutoScrollMargin")));
			this.xpGradientPanel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.AutoScrollMinSize")));
			this.xpGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel3.BackgroundImage")));
			this.xpGradientPanel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel3.Dock")));
			this.xpGradientPanel3.Enabled = ((bool)(resources.GetObject("xpGradientPanel3.Enabled")));
			this.xpGradientPanel3.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel3.Font")));
			this.xpGradientPanel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel3.ImeMode")));
			this.xpGradientPanel3.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel3.Location")));
			this.xpGradientPanel3.Name = "xpGradientPanel3";
			this.xpGradientPanel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel3.RightToLeft")));
			this.xpGradientPanel3.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.Size")));
			this.xpGradientPanel3.TabIndex = ((int)(resources.GetObject("xpGradientPanel3.TabIndex")));
			this.xpGradientPanel3.Text = resources.GetString("xpGradientPanel3.Text");
			this.xpGradientPanel3.Visible = ((bool)(resources.GetObject("xpGradientPanel3.Visible")));
			this.xpGradientPanel3.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel3.Watermark")));
			this.xpGradientPanel3.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.WatermarkSize")));
			// 
			// ResourceDock
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.leftSandDock);
			this.Controls.Add(this.rightSandDock);
			this.Controls.Add(this.bottomSandDock);
			this.Controls.Add(this.topSandDock);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "ResourceDock";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.Load += new System.EventHandler(this.ResourceDock_Load);
			this.bottomSandDock.ResumeLayout(false);
			this.dcResource.ResumeLayout(false);
			this.xpGradientPanel1.ResumeLayout(false);
			this.pntypes.ResumeLayout(false);
			this.dcWrapper.ResumeLayout(false);
			this.xpGradientPanel2.ResumeLayout(false);
			this.dcPackage.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal SimPe.Events.ResourceEventArgs items;
		internal LoadedPackage guipackage;

		private void ResourceDock_Load(object sender, System.EventArgs e)
		{
		
		}

		private void cbtypes_SelectedIndexChanged(object sender, System.EventArgs e)
		{			
			if (cbtypes.Tag != null) return;
			tbtype.Text = "0x"+Helper.HexString(((SimPe.Data.TypeAlias)cbtypes.Items[cbtypes.SelectedIndex]).Id);			
			tbtype_TextChanged2(sender, e);
		}

		private void tbtype_TextChanged(object sender, System.EventArgs e)
		{
			cbtypes.Tag = true;
			Data.TypeAlias a = Data.MetaData.FindTypeAlias(Helper.HexStringToUInt(tbtype.Text));

			int ct=0;
			foreach(Data.TypeAlias i in cbtypes.Items) 
			{								
				if (i==a) 
				{
					cbtypes.SelectedIndex = ct;
					cbtypes.Tag = null;
					return;
				}
				ct++;
			}

			cbtypes.SelectedIndex = -1;
			cbtypes.Tag = null;			
		}

		private void tbtype_TextChanged2(object sender, System.EventArgs ea)
		{
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Type = Convert.ToUInt32(tbtype.Text, 16);
					
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}

		private void tbgroup_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Group = Convert.ToUInt32(tbgroup.Text, 16);
					
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}

		private void tbinstance_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;


				try
				{
					e.Resource.FileDescriptor.Instance = Convert.ToUInt32(tbinstance.Text, 16);
					e.Resource.FileDescriptor.SubType = Convert.ToUInt32(tbinstance2.Text, 16);

					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}

		private void tbinstance2_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;


				try
				{
					e.Resource.FileDescriptor.SubType = Convert.ToUInt32(tbinstance2.Text, 16);
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}
		

		private void cbComp_SelectedIndexChanged(object sender, System.EventArgs ea)
		{
			if (this.cbComp.SelectedIndex<0) return;
			if (this.cbComp.SelectedIndex>1) return;
			if (items==null) return;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;

				try
				{
					e.Resource.FileDescriptor.MarkForReCompress = (cbComp.SelectedIndex==1);
					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}

		private void tbtype_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) this.tbtype_TextChanged(sender, null);
		}

		private void tbgroup_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) this.tbgroup_TextChanged(sender, null);
		}

		private void tbinstance_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) this.tbinstance_TextChanged(sender, null);
		}

		private void tbinstance2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) this.tbinstance2_TextChanged(sender, null);
		}

		

		


		
	}
}
