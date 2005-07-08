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
		internal System.Windows.Forms.PropertyGrid pgHead;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ColumnHeader clOffset;
		private System.Windows.Forms.ColumnHeader clSize;
		internal TD.SandDock.DockControl dcConvert;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel4;
		private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;
		private System.Windows.Forms.TextBox tbHex;
		private System.Windows.Forms.TextBox tbDec;
		internal TD.SandDock.DockControl dcHex;
		internal Ambertation.Windows.Forms.HexViewControl hvc;
		private System.Windows.Forms.TextBox tbBin;
		internal System.Windows.Forms.Button button1;
		private Ambertation.Windows.Forms.HexEditControl hexEditControl1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		internal System.Windows.Forms.PictureBox pb;
		private System.ComponentModel.IContainer components;

		public ResourceDock()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			ThemeManager tm = ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);
			tm.AddControl(this.xpGradientPanel2);
			tm.AddControl(this.xpGradientPanel3);
			tm.AddControl(this.xpGradientPanel4);

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ResourceDock));
			this.sandDockManager1 = new TD.SandDock.SandDockManager();
			this.leftSandDock = new TD.SandDock.DockContainer();
			this.rightSandDock = new TD.SandDock.DockContainer();
			this.bottomSandDock = new TD.SandDock.DockContainer();
			this.dcResource = new TD.SandDock.DockControl();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
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
			this.dcHex = new TD.SandDock.DockControl();
			this.hexEditControl1 = new Ambertation.Windows.Forms.HexEditControl();
			this.hvc = new Ambertation.Windows.Forms.HexViewControl();
			this.button1 = new System.Windows.Forms.Button();
			this.dcPackage = new TD.SandDock.DockControl();
			this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.lv = new System.Windows.Forms.ListView();
			this.clOffset = new System.Windows.Forms.ColumnHeader();
			this.clSize = new System.Windows.Forms.ColumnHeader();
			this.label4 = new System.Windows.Forms.Label();
			this.pgHead = new System.Windows.Forms.PropertyGrid();
			this.dcConvert = new TD.SandDock.DockControl();
			this.xpGradientPanel4 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.tbBin = new System.Windows.Forms.TextBox();
			this.tbDec = new System.Windows.Forms.TextBox();
			this.tbHex = new System.Windows.Forms.TextBox();
			this.dcWrapper = new TD.SandDock.DockControl();
			this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.lbDesc = new System.Windows.Forms.Label();
			this.lbVersion = new System.Windows.Forms.Label();
			this.lbAuthor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.topSandDock = new TD.SandDock.DockContainer();
			this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
			this.bottomSandDock.SuspendLayout();
			this.dcResource.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.pntypes.SuspendLayout();
			this.dcHex.SuspendLayout();
			this.dcPackage.SuspendLayout();
			this.xpGradientPanel3.SuspendLayout();
			this.dcConvert.SuspendLayout();
			this.xpGradientPanel4.SuspendLayout();
			this.dcWrapper.SuspendLayout();
			this.xpGradientPanel2.SuspendLayout();
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
			this.bottomSandDock.Controls.Add(this.dcHex);
			this.bottomSandDock.Controls.Add(this.dcPackage);
			this.bottomSandDock.Controls.Add(this.dcConvert);
			this.bottomSandDock.Controls.Add(this.dcWrapper);
			this.bottomSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bottomSandDock.Dock")));
			this.bottomSandDock.Enabled = ((bool)(resources.GetObject("bottomSandDock.Enabled")));
			this.bottomSandDock.Font = ((System.Drawing.Font)(resources.GetObject("bottomSandDock.Font")));
			this.bottomSandDock.Guid = new System.Guid("f2b6c0a5-8de3-4a6e-8133-dd2ab495affc");
			this.bottomSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bottomSandDock.ImeMode")));
			this.bottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											   new TD.SandDock.ControlLayoutSystem(856, 376, new TD.SandDock.DockControl[] {
																																																															   this.dcPackage,
																																																															   this.dcResource,
																																																															   this.dcWrapper,
																																																															   this.dcConvert,
																																																															   this.dcHex}, this.dcWrapper)});
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
			this.xpGradientPanel1.Controls.Add(this.linkLabel1);
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
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
			this.xpCueBannerExtender1.SetCueBannerText(this.cbComp, "");
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
			this.xpCueBannerExtender1.SetCueBannerText(this.tbinstance2, "");
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
			this.tbinstance2.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbinstance2.Leave += new System.EventHandler(this.tbinstance2_TextChanged);
			this.tbinstance2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance2_KeyUp);
			// 
			// tbinstance
			// 
			this.tbinstance.AccessibleDescription = resources.GetString("tbinstance.AccessibleDescription");
			this.tbinstance.AccessibleName = resources.GetString("tbinstance.AccessibleName");
			this.tbinstance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinstance.Anchor")));
			this.tbinstance.AutoSize = ((bool)(resources.GetObject("tbinstance.AutoSize")));
			this.tbinstance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinstance.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbinstance, "");
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
			this.tbinstance.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbinstance.Leave += new System.EventHandler(this.tbinstance_TextChanged);
			this.tbinstance.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbinstance_KeyUp);
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
			this.xpCueBannerExtender1.SetCueBannerText(this.tbtype, "");
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
			this.xpCueBannerExtender1.SetCueBannerText(this.tbgroup, "");
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
			this.tbgroup.TextChanged += new System.EventHandler(this.TextChanged);
			this.tbgroup.Leave += new System.EventHandler(this.tbgroup_TextChanged);
			this.tbgroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbgroup_KeyUp);
			// 
			// cbtypes
			// 
			this.cbtypes.AccessibleDescription = resources.GetString("cbtypes.AccessibleDescription");
			this.cbtypes.AccessibleName = resources.GetString("cbtypes.AccessibleName");
			this.cbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtypes.Anchor")));
			this.cbtypes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtypes.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.cbtypes, "");
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
			// dcHex
			// 
			this.dcHex.AccessibleDescription = resources.GetString("dcHex.AccessibleDescription");
			this.dcHex.AccessibleName = resources.GetString("dcHex.AccessibleName");
			this.dcHex.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcHex.Anchor")));
			this.dcHex.AutoScroll = ((bool)(resources.GetObject("dcHex.AutoScroll")));
			this.dcHex.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcHex.AutoScrollMargin")));
			this.dcHex.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcHex.AutoScrollMinSize")));
			this.dcHex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcHex.BackgroundImage")));
			this.dcHex.Controls.Add(this.hexEditControl1);
			this.dcHex.Controls.Add(this.button1);
			this.dcHex.Controls.Add(this.hvc);
			this.dcHex.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcHex.Dock")));
			this.dcHex.Enabled = ((bool)(resources.GetObject("dcHex.Enabled")));
			this.dcHex.FloatingSize = new System.Drawing.Size(856, 335);
			this.dcHex.Font = ((System.Drawing.Font)(resources.GetObject("dcHex.Font")));
			this.dcHex.Guid = new System.Guid("da8908d7-800f-4200-894a-83653dbf5767");
			this.dcHex.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcHex.ImeMode")));
			this.dcHex.Location = ((System.Drawing.Point)(resources.GetObject("dcHex.Location")));
			this.dcHex.Name = "dcHex";
			this.dcHex.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcHex.RightToLeft")));
			this.dcHex.Size = ((System.Drawing.Size)(resources.GetObject("dcHex.Size")));
			this.dcHex.TabImage = ((System.Drawing.Image)(resources.GetObject("dcHex.TabImage")));
			this.dcHex.TabIndex = ((int)(resources.GetObject("dcHex.TabIndex")));
			this.dcHex.TabText = resources.GetString("dcHex.TabText");
			this.dcHex.Text = resources.GetString("dcHex.Text");
			this.dcHex.ToolTipText = resources.GetString("dcHex.ToolTipText");
			this.dcHex.Visible = ((bool)(resources.GetObject("dcHex.Visible")));
			this.dcHex.VisibleChanged += new System.EventHandler(this.dcHex_VisibleChanged);
			this.dcHex.Closed += new System.EventHandler(this.dcHex_Closed);
			this.dcHex.BeforeFirstShown += new System.EventHandler(this.dcHex_BeforeFirstShown);
			// 
			// hexEditControl1
			// 
			this.hexEditControl1.AccessibleDescription = resources.GetString("hexEditControl1.AccessibleDescription");
			this.hexEditControl1.AccessibleName = resources.GetString("hexEditControl1.AccessibleName");
			this.hexEditControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hexEditControl1.Anchor")));
			this.hexEditControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hexEditControl1.BackgroundImage")));
			this.hexEditControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hexEditControl1.Dock")));
			this.hexEditControl1.Enabled = ((bool)(resources.GetObject("hexEditControl1.Enabled")));
			this.hexEditControl1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.hexEditControl1.Font = ((System.Drawing.Font)(resources.GetObject("hexEditControl1.Font")));
			this.hexEditControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hexEditControl1.ImeMode")));
			this.hexEditControl1.LabelFont = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Italic);
			this.hexEditControl1.Location = ((System.Drawing.Point)(resources.GetObject("hexEditControl1.Location")));
			this.hexEditControl1.Name = "hexEditControl1";
			this.hexEditControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hexEditControl1.RightToLeft")));
			this.hexEditControl1.Size = ((System.Drawing.Size)(resources.GetObject("hexEditControl1.Size")));
			this.hexEditControl1.TabIndex = ((int)(resources.GetObject("hexEditControl1.TabIndex")));
			this.hexEditControl1.TabStop = false;
			this.hexEditControl1.Text = resources.GetString("hexEditControl1.Text");
			this.hexEditControl1.TextBoxFont = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.hexEditControl1.Vertical = false;
			this.hexEditControl1.View = Ambertation.Windows.Forms.HexViewControl.ViewState.Hex;
			this.hexEditControl1.Viewer = this.hvc;
			this.hexEditControl1.Visible = ((bool)(resources.GetObject("hexEditControl1.Visible")));
			// 
			// hvc
			// 
			this.hvc.AccessibleDescription = resources.GetString("hvc.AccessibleDescription");
			this.hvc.AccessibleName = resources.GetString("hvc.AccessibleName");
			this.hvc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hvc.Anchor")));
			this.hvc.AutoScroll = ((bool)(resources.GetObject("hvc.AutoScroll")));
			this.hvc.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hvc.AutoScrollMargin")));
			this.hvc.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hvc.AutoScrollMinSize")));
			this.hvc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hvc.BackgroundImage")));
			this.hvc.Blocks = ((System.Byte)(2));
			this.hvc.CharBoxWidth = 220;
			this.hvc.CurrentRow = 0;
			this.hvc.Data = new System.Byte[0];
			this.hvc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hvc.Dock")));
			this.hvc.Enabled = ((bool)(resources.GetObject("hvc.Enabled")));
			this.hvc.FocusedForeColor = System.Drawing.Color.FromArgb(((System.Byte)(96)), ((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(0)));
			this.hvc.Font = ((System.Drawing.Font)(resources.GetObject("hvc.Font")));
			this.hvc.GridColor = System.Drawing.Color.FromArgb(((System.Byte)(50)), ((System.Byte)(255)), ((System.Byte)(140)), ((System.Byte)(0)));
			this.hvc.HeadColor = System.Drawing.Color.DarkOrange;
			this.hvc.HeadForeColor = System.Drawing.Color.SeaShell;
			this.hvc.HighlightColor = System.Drawing.Color.FromArgb(((System.Byte)(190)), ((System.Byte)(255)), ((System.Byte)(140)), ((System.Byte)(0)));
			this.hvc.HighlightForeColor = System.Drawing.SystemColors.HighlightText;
			this.hvc.HighlightZeros = false;
			this.hvc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hvc.ImeMode")));
			this.hvc.Location = ((System.Drawing.Point)(resources.GetObject("hvc.Location")));
			this.hvc.Name = "hvc";
			this.hvc.Offset = 0;
			this.hvc.OffsetBoxWidth = 83;
			this.hvc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hvc.RightToLeft")));
			this.hvc.SelectedByte = ((System.Byte)(0));
			this.hvc.SelectedChar = '\0';
			this.hvc.SelectedDouble = 0;
			this.hvc.SelectedFloat = 0F;
			this.hvc.SelectedInt = 0;
			this.hvc.SelectedLong = ((long)(0));
			this.hvc.SelectedShort = ((short)(0));
			// TODO: Beim Generieren des Codes für 'this.hvc.SelectedUInt' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt32. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.hvc.SelectedULong' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt64. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			// TODO: Beim Generieren des Codes für 'this.hvc.SelectedUShort' ist die Ausnahme 'Ungültiger primitiver Typ: System.UInt16. Es können nur mit CLS kompatible primitive Typen verwendet werden. Verwenden Sie CodeObjectCreateExpression.' aufgetreten.
			this.hvc.Selection = new System.Byte[0];
			this.hvc.SelectionColor = System.Drawing.SystemColors.Highlight;
			this.hvc.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.hvc.ShowGrid = true;
			this.hvc.Size = ((System.Drawing.Size)(resources.GetObject("hvc.Size")));
			this.hvc.TabIndex = ((int)(resources.GetObject("hvc.TabIndex")));
			this.hvc.View = Ambertation.Windows.Forms.HexViewControl.ViewState.Hex;
			this.hvc.Visible = ((bool)(resources.GetObject("hvc.Visible")));
			this.hvc.ZeroCellColor = System.Drawing.Color.FromArgb(((System.Byte)(150)), ((System.Byte)(158)), ((System.Byte)(210)), ((System.Byte)(49)));
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
			this.xpGradientPanel3.Controls.Add(this.lv);
			this.xpGradientPanel3.Controls.Add(this.label4);
			this.xpGradientPanel3.Controls.Add(this.pgHead);
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
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.clOffset,
																				 this.clSize});
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.FullRowSelect = true;
			this.lv.GridLines = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			// 
			// clOffset
			// 
			this.clOffset.Text = resources.GetString("clOffset.Text");
			this.clOffset.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clOffset.TextAlign")));
			this.clOffset.Width = ((int)(resources.GetObject("clOffset.Width")));
			// 
			// clSize
			// 
			this.clSize.Text = resources.GetString("clSize.Text");
			this.clSize.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clSize.TextAlign")));
			this.clSize.Width = ((int)(resources.GetObject("clSize.Width")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// pgHead
			// 
			this.pgHead.AccessibleDescription = resources.GetString("pgHead.AccessibleDescription");
			this.pgHead.AccessibleName = resources.GetString("pgHead.AccessibleName");
			this.pgHead.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pgHead.Anchor")));
			this.pgHead.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pgHead.BackgroundImage")));
			this.pgHead.CommandsVisibleIfAvailable = true;
			this.pgHead.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pgHead.Dock")));
			this.pgHead.Enabled = ((bool)(resources.GetObject("pgHead.Enabled")));
			this.pgHead.Font = ((System.Drawing.Font)(resources.GetObject("pgHead.Font")));
			this.pgHead.HelpVisible = ((bool)(resources.GetObject("pgHead.HelpVisible")));
			this.pgHead.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pgHead.ImeMode")));
			this.pgHead.LargeButtons = false;
			this.pgHead.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pgHead.Location = ((System.Drawing.Point)(resources.GetObject("pgHead.Location")));
			this.pgHead.Name = "pgHead";
			this.pgHead.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pgHead.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pgHead.RightToLeft")));
			this.pgHead.Size = ((System.Drawing.Size)(resources.GetObject("pgHead.Size")));
			this.pgHead.TabIndex = ((int)(resources.GetObject("pgHead.TabIndex")));
			this.pgHead.Text = resources.GetString("pgHead.Text");
			this.pgHead.ToolbarVisible = false;
			this.pgHead.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pgHead.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pgHead.Visible = ((bool)(resources.GetObject("pgHead.Visible")));
			// 
			// dcConvert
			// 
			this.dcConvert.AccessibleDescription = resources.GetString("dcConvert.AccessibleDescription");
			this.dcConvert.AccessibleName = resources.GetString("dcConvert.AccessibleName");
			this.dcConvert.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcConvert.Anchor")));
			this.dcConvert.AutoScroll = ((bool)(resources.GetObject("dcConvert.AutoScroll")));
			this.dcConvert.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcConvert.AutoScrollMargin")));
			this.dcConvert.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcConvert.AutoScrollMinSize")));
			this.dcConvert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcConvert.BackgroundImage")));
			this.dcConvert.Controls.Add(this.xpGradientPanel4);
			this.dcConvert.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcConvert.Dock")));
			this.dcConvert.Enabled = ((bool)(resources.GetObject("dcConvert.Enabled")));
			this.dcConvert.FloatingSize = new System.Drawing.Size(152, 59);
			this.dcConvert.Font = ((System.Drawing.Font)(resources.GetObject("dcConvert.Font")));
			this.dcConvert.Guid = new System.Guid("8ca80417-63c2-4b3f-ab5b-1a8f15d7026d");
			this.dcConvert.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcConvert.ImeMode")));
			this.dcConvert.Location = ((System.Drawing.Point)(resources.GetObject("dcConvert.Location")));
			this.dcConvert.Name = "dcConvert";
			this.dcConvert.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcConvert.RightToLeft")));
			this.dcConvert.Size = ((System.Drawing.Size)(resources.GetObject("dcConvert.Size")));
			this.dcConvert.TabImage = ((System.Drawing.Image)(resources.GetObject("dcConvert.TabImage")));
			this.dcConvert.TabIndex = ((int)(resources.GetObject("dcConvert.TabIndex")));
			this.dcConvert.TabText = resources.GetString("dcConvert.TabText");
			this.dcConvert.Text = resources.GetString("dcConvert.Text");
			this.dcConvert.ToolTipText = resources.GetString("dcConvert.ToolTipText");
			this.dcConvert.Visible = ((bool)(resources.GetObject("dcConvert.Visible")));
			// 
			// xpGradientPanel4
			// 
			this.xpGradientPanel4.AccessibleDescription = resources.GetString("xpGradientPanel4.AccessibleDescription");
			this.xpGradientPanel4.AccessibleName = resources.GetString("xpGradientPanel4.AccessibleName");
			this.xpGradientPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel4.Anchor")));
			this.xpGradientPanel4.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel4.AutoScroll")));
			this.xpGradientPanel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel4.AutoScrollMargin")));
			this.xpGradientPanel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel4.AutoScrollMinSize")));
			this.xpGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel4.BackgroundImage")));
			this.xpGradientPanel4.Controls.Add(this.tbBin);
			this.xpGradientPanel4.Controls.Add(this.tbDec);
			this.xpGradientPanel4.Controls.Add(this.tbHex);
			this.xpGradientPanel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel4.Dock")));
			this.xpGradientPanel4.Enabled = ((bool)(resources.GetObject("xpGradientPanel4.Enabled")));
			this.xpGradientPanel4.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel4.Font")));
			this.xpGradientPanel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel4.ImeMode")));
			this.xpGradientPanel4.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel4.Location")));
			this.xpGradientPanel4.Name = "xpGradientPanel4";
			this.xpGradientPanel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel4.RightToLeft")));
			this.xpGradientPanel4.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel4.Size")));
			this.xpGradientPanel4.TabIndex = ((int)(resources.GetObject("xpGradientPanel4.TabIndex")));
			this.xpGradientPanel4.Text = resources.GetString("xpGradientPanel4.Text");
			this.xpGradientPanel4.Visible = ((bool)(resources.GetObject("xpGradientPanel4.Visible")));
			this.xpGradientPanel4.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel4.Watermark")));
			this.xpGradientPanel4.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel4.WatermarkSize")));
			// 
			// tbBin
			// 
			this.tbBin.AccessibleDescription = resources.GetString("tbBin.AccessibleDescription");
			this.tbBin.AccessibleName = resources.GetString("tbBin.AccessibleName");
			this.tbBin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbBin.Anchor")));
			this.tbBin.AutoSize = ((bool)(resources.GetObject("tbBin.AutoSize")));
			this.tbBin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbBin.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbBin, "Binary");
			this.tbBin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbBin.Dock")));
			this.tbBin.Enabled = ((bool)(resources.GetObject("tbBin.Enabled")));
			this.tbBin.Font = ((System.Drawing.Font)(resources.GetObject("tbBin.Font")));
			this.tbBin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbBin.ImeMode")));
			this.tbBin.Location = ((System.Drawing.Point)(resources.GetObject("tbBin.Location")));
			this.tbBin.MaxLength = ((int)(resources.GetObject("tbBin.MaxLength")));
			this.tbBin.Multiline = ((bool)(resources.GetObject("tbBin.Multiline")));
			this.tbBin.Name = "tbBin";
			this.tbBin.PasswordChar = ((char)(resources.GetObject("tbBin.PasswordChar")));
			this.tbBin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbBin.RightToLeft")));
			this.tbBin.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbBin.ScrollBars")));
			this.tbBin.Size = ((System.Drawing.Size)(resources.GetObject("tbBin.Size")));
			this.tbBin.TabIndex = ((int)(resources.GetObject("tbBin.TabIndex")));
			this.tbBin.Text = resources.GetString("tbBin.Text");
			this.tbBin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbBin.TextAlign")));
			this.tbBin.Visible = ((bool)(resources.GetObject("tbBin.Visible")));
			this.tbBin.WordWrap = ((bool)(resources.GetObject("tbBin.WordWrap")));
			this.tbBin.TextChanged += new System.EventHandler(this.BinChanged);
			// 
			// tbDec
			// 
			this.tbDec.AccessibleDescription = resources.GetString("tbDec.AccessibleDescription");
			this.tbDec.AccessibleName = resources.GetString("tbDec.AccessibleName");
			this.tbDec.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbDec.Anchor")));
			this.tbDec.AutoSize = ((bool)(resources.GetObject("tbDec.AutoSize")));
			this.tbDec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDec.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbDec, "Decimal");
			this.tbDec.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbDec.Dock")));
			this.tbDec.Enabled = ((bool)(resources.GetObject("tbDec.Enabled")));
			this.tbDec.Font = ((System.Drawing.Font)(resources.GetObject("tbDec.Font")));
			this.tbDec.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbDec.ImeMode")));
			this.tbDec.Location = ((System.Drawing.Point)(resources.GetObject("tbDec.Location")));
			this.tbDec.MaxLength = ((int)(resources.GetObject("tbDec.MaxLength")));
			this.tbDec.Multiline = ((bool)(resources.GetObject("tbDec.Multiline")));
			this.tbDec.Name = "tbDec";
			this.tbDec.PasswordChar = ((char)(resources.GetObject("tbDec.PasswordChar")));
			this.tbDec.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbDec.RightToLeft")));
			this.tbDec.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbDec.ScrollBars")));
			this.tbDec.Size = ((System.Drawing.Size)(resources.GetObject("tbDec.Size")));
			this.tbDec.TabIndex = ((int)(resources.GetObject("tbDec.TabIndex")));
			this.tbDec.Text = resources.GetString("tbDec.Text");
			this.tbDec.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbDec.TextAlign")));
			this.tbDec.Visible = ((bool)(resources.GetObject("tbDec.Visible")));
			this.tbDec.WordWrap = ((bool)(resources.GetObject("tbDec.WordWrap")));
			this.tbDec.TextChanged += new System.EventHandler(this.DecChanged);
			// 
			// tbHex
			// 
			this.tbHex.AccessibleDescription = resources.GetString("tbHex.AccessibleDescription");
			this.tbHex.AccessibleName = resources.GetString("tbHex.AccessibleName");
			this.tbHex.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbHex.Anchor")));
			this.tbHex.AutoSize = ((bool)(resources.GetObject("tbHex.AutoSize")));
			this.tbHex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbHex.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbHex, "Hex.");
			this.tbHex.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbHex.Dock")));
			this.tbHex.Enabled = ((bool)(resources.GetObject("tbHex.Enabled")));
			this.tbHex.Font = ((System.Drawing.Font)(resources.GetObject("tbHex.Font")));
			this.tbHex.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbHex.ImeMode")));
			this.tbHex.Location = ((System.Drawing.Point)(resources.GetObject("tbHex.Location")));
			this.tbHex.MaxLength = ((int)(resources.GetObject("tbHex.MaxLength")));
			this.tbHex.Multiline = ((bool)(resources.GetObject("tbHex.Multiline")));
			this.tbHex.Name = "tbHex";
			this.tbHex.PasswordChar = ((char)(resources.GetObject("tbHex.PasswordChar")));
			this.tbHex.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbHex.RightToLeft")));
			this.tbHex.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbHex.ScrollBars")));
			this.tbHex.Size = ((System.Drawing.Size)(resources.GetObject("tbHex.Size")));
			this.tbHex.TabIndex = ((int)(resources.GetObject("tbHex.TabIndex")));
			this.tbHex.Text = resources.GetString("tbHex.Text");
			this.tbHex.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbHex.TextAlign")));
			this.tbHex.Visible = ((bool)(resources.GetObject("tbHex.Visible")));
			this.tbHex.WordWrap = ((bool)(resources.GetObject("tbHex.WordWrap")));
			this.tbHex.TextChanged += new System.EventHandler(this.HexChanged);
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
			this.xpGradientPanel2.Controls.Add(this.lbName);
			this.xpGradientPanel2.Controls.Add(this.pb);
			this.xpGradientPanel2.Controls.Add(this.lbDesc);
			this.xpGradientPanel2.Controls.Add(this.lbVersion);
			this.xpGradientPanel2.Controls.Add(this.lbAuthor);
			this.xpGradientPanel2.Controls.Add(this.label5);
			this.xpGradientPanel2.Controls.Add(this.label2);
			this.xpGradientPanel2.Controls.Add(this.label1);
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
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackColor = System.Drawing.Color.Transparent;
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pb.SizeMode")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TabStop = false;
			this.pb.Text = resources.GetString("pb.Text");
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
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
			this.dcHex.ResumeLayout(false);
			this.dcPackage.ResumeLayout(false);
			this.xpGradientPanel3.ResumeLayout(false);
			this.dcConvert.ResumeLayout(false);
			this.xpGradientPanel4.ResumeLayout(false);
			this.dcWrapper.ResumeLayout(false);
			this.xpGradientPanel2.ResumeLayout(false);
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
			this.tbtype.Tag = true;
			tbtype_TextChanged2(this.tbtype, e);
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
			TextChanged(sender, null);
		}

		private void tbtype_TextChanged2(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;
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
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

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
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;


				try
				{
					e.Resource.FileDescriptor.Instance = Convert.ToUInt32(tbinstance.Text, 16);

					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();
		}

		private void tbinstance2_TextChanged(object sender, System.EventArgs ea)
		{
			if (items==null || ((TextBox)sender).Tag==null) return;
			((TextBox)sender).Tag = null;

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
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbtype_TextChanged2(sender, null);
			}
		}

		private void tbgroup_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbgroup_TextChanged(sender, null);
			}
		}

		private void tbinstance_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbinstance_TextChanged(sender, null);
			}
		}

		private void tbinstance2_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode ==  Keys.Enter) 
			{
				TextChanged(sender, null);
				this.tbinstance2_TextChanged(sender, null);
			}
		}

		#region Hex <-> Dec Converter
		bool sysupdate = false;
		private void BinChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				long val = Convert.ToInt64(tbBin.Text, 2);
				this.tbDec.Text = val.ToString();
				this.tbHex.Text = Helper.HexString(val);
			} 
			catch (Exception) 
			{
				this.tbDec.Text = "";
				this.tbHex.Text = "";
			}
			sysupdate = false;
		}
		private void HexChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				long val = Convert.ToInt64(tbHex.Text, 16);				
				this.tbBin.Text = Convert.ToString(val, 2);
				this.tbDec.Text = val.ToString();
			} 
			catch (Exception) {
				this.tbDec.Text = "";
				this.tbBin.Text = "";
			}
			sysupdate = false;
		}

		private void DecChanged(object sender, System.EventArgs e)
		{
			if (sysupdate) return;
			sysupdate = true;
			try 
			{
				ulong val = (ulong)Convert.ToInt64(tbDec.Text);				
				this.tbBin.Text = Convert.ToString((long)val, 2);
				tbHex.Text = "0x"+Helper.HexString(val);
			} 
			catch (Exception) {
				this.tbHex.Text = "";
				this.tbBin.Text = "";
			}
			sysupdate = false;
		}
		#endregion

		internal SimPe.Interfaces.Files.IPackedFileDescriptor hexpfd;
		private new void TextChanged(object sender, System.EventArgs e)
		{
			if (items==null) return;
			((TextBox)sender).Tag = true;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			hexpfd.UserData = hvc.Data;
		}

		private void dcHex_Closed(object sender, System.EventArgs e)
		{
			
		}

		private void dcHex_BeforeFirstShown(object sender, System.EventArgs e)
		{
			
		}

		private void dcHex_VisibleChanged(object sender, System.EventArgs e)
		{
			this.hvc.Visible = dcHex.Visible;							
			hvc.Refresh(true);
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs ev)
		{
			if (items==null) return;			
			guipackage.PauseIndexChangedEvents();
			foreach (SimPe.Events.ResourceContainer e in items) 
			{
				if (!e.HasFileDescriptor) continue;
				try
				{
					e.Resource.FileDescriptor.Type = Convert.ToUInt32(tbtype.Text, 16);
					e.Resource.FileDescriptor.Group = Convert.ToUInt32(tbgroup.Text, 16);
					e.Resource.FileDescriptor.Instance = Convert.ToUInt32(tbinstance.Text, 16);
					e.Resource.FileDescriptor.SubType = Convert.ToUInt32(tbinstance2.Text, 16);
					e.Resource.FileDescriptor.MarkForReCompress = (cbComp.SelectedIndex==1 && !e.Resource.FileDescriptor.WasCompressed);

					e.Resource.FileDescriptor.Changed = true;
				} 
				catch {}
			}
			guipackage.RestartIndexChangedEvents();		
		}

		

		


		
	}
}
