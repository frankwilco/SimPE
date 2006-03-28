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
using SimPe.PackedFiles.Wrapper.Supporting;

namespace SimPe.PackedFiles.UserInterface 
{
	/// <summary>
	/// Zusammenfassung für Elements.
	/// </summary>
	internal class Elements : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label banner;
		internal System.Windows.Forms.PictureBox pb;
		internal System.Windows.Forms.Panel JpegPanel;
		internal System.Windows.Forms.Panel xmlPanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.RichTextBox rtb;
		private System.ComponentModel.IContainer components;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel2;
		internal System.Windows.Forms.TextBox tbsimid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label12;
		internal System.Windows.Forms.Panel objdPanel;
		internal System.Windows.Forms.TextBox tbsimname;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		internal System.Windows.Forms.Panel famiPanel;
		internal System.Windows.Forms.TextBox tblotinst;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button llFamiDeleteSim;
		private System.Windows.Forms.Button llFamiAddSim;
		private System.Windows.Forms.Button button1;
		internal System.Windows.Forms.ComboBox cbsims;
		internal System.Windows.Forms.ListBox lbmembers;
		internal System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.TextBox tbfamily;
		internal System.Windows.Forms.TextBox tbmoney;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Windows.Forms.Panel realPanel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label56;
		internal System.Windows.Forms.TextBox tblongterm;
		internal System.Windows.Forms.TextBox tbshortterm;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label58;
		private Skybound.VisualStyles.VisualStyleLinkLabel llrelcommit;
		private System.Windows.Forms.GroupBox gbrelation;
		internal System.Windows.Forms.CheckBox cbmarried;
		internal System.Windows.Forms.CheckBox cbengaged;
		internal System.Windows.Forms.CheckBox cbsteady;
		internal System.Windows.Forms.CheckBox cblove;
		internal System.Windows.Forms.CheckBox cbcrush;
		internal System.Windows.Forms.CheckBox cbenemy;
		internal System.Windows.Forms.CheckBox cbbuddie;
		internal System.Windows.Forms.CheckBox cbfriend;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label68;
		internal System.Windows.Forms.Panel familytiePanel;
		private System.Windows.Forms.Button bttiecommit;
		internal System.Windows.Forms.ComboBox cbtiesims;
		private System.Windows.Forms.GroupBox gbties;
		internal System.Windows.Forms.ComboBox cbtietype;
		internal System.Windows.Forms.Button btdeletetie;
		internal System.Windows.Forms.Button btaddtie;
		internal System.Windows.Forms.ListBox lbties;
		internal System.Windows.Forms.ComboBox cballtieablesims;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcommitties;
		internal System.Windows.Forms.Button btnewtie;
		internal System.Windows.Forms.TextBox tblottype;
		private System.Windows.Forms.Label label65;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcommitobjd;
		private System.Windows.Forms.GroupBox gbelements;
		internal System.Windows.Forms.Panel pnelements;
		private Skybound.VisualStyles.VisualStyleLinkLabel llgetGUID;
		internal System.Windows.Forms.Label lbtypename;
		internal System.Windows.Forms.CheckBox cbfamily;
		internal System.Windows.Forms.CheckBox cbbest;
		private Skybound.VisualStyles.VisualStyleLinkLabel llsrelcommit;
		internal System.Windows.Forms.ComboBox cbfamtype;
		private System.Windows.Forms.Label label91;
		internal System.Windows.Forms.TextBox tbflag;
		private System.Windows.Forms.Label label92;
		internal System.Windows.Forms.TextBox tbalbum;
		private System.Windows.Forms.Label label93;
		internal System.Windows.Forms.TextBox tborgguid;
		internal System.Windows.Forms.TextBox tbproxguid;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbphone;
		private System.Windows.Forms.CheckBox cbbaby;
		private System.Windows.Forms.CheckBox cbcomputer;
		private System.Windows.Forms.CheckBox cblot;
		private System.Windows.Forms.CheckBox cbupdate;
		internal System.Windows.Forms.TextBox tbsubhood;
		private System.Windows.Forms.Label label89;
		private Skybound.VisualStyles.VisualStyleProvider visualStyleProvider1;
		private System.Windows.Forms.Button btPicExport;


		internal SimPe.Interfaces.Plugin.IFileWrapperSaveExtension wrapper = null;
		public Elements()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
		
			InitializeComponent();			
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Elements));
			this.JpegPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.banner = new System.Windows.Forms.Label();
			this.btPicExport = new System.Windows.Forms.Button();
			this.pb = new System.Windows.Forms.PictureBox();
			this.xmlPanel = new System.Windows.Forms.Panel();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.visualStyleLinkLabel2 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.objdPanel = new System.Windows.Forms.Panel();
			this.cbupdate = new System.Windows.Forms.CheckBox();
			this.label63 = new System.Windows.Forms.Label();
			this.tbproxguid = new System.Windows.Forms.TextBox();
			this.label97 = new System.Windows.Forms.Label();
			this.tborgguid = new System.Windows.Forms.TextBox();
			this.lbtypename = new System.Windows.Forms.Label();
			this.llgetGUID = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbelements = new System.Windows.Forms.GroupBox();
			this.pnelements = new System.Windows.Forms.Panel();
			this.llcommitobjd = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tblottype = new System.Windows.Forms.TextBox();
			this.label65 = new System.Windows.Forms.Label();
			this.tbsimname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbsimid = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.familytiePanel = new System.Windows.Forms.Panel();
			this.gbties = new System.Windows.Forms.GroupBox();
			this.btnewtie = new System.Windows.Forms.Button();
			this.cballtieablesims = new System.Windows.Forms.ComboBox();
			this.cbtietype = new System.Windows.Forms.ComboBox();
			this.lbties = new System.Windows.Forms.ListBox();
			this.btdeletetie = new System.Windows.Forms.Button();
			this.btaddtie = new System.Windows.Forms.Button();
			this.llcommitties = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.cbtiesims = new System.Windows.Forms.ComboBox();
			this.bttiecommit = new System.Windows.Forms.Button();
			this.label64 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label68 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.famiPanel = new System.Windows.Forms.Panel();
			this.tbsubhood = new System.Windows.Forms.TextBox();
			this.label89 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbcomputer = new System.Windows.Forms.CheckBox();
			this.cblot = new System.Windows.Forms.CheckBox();
			this.cbbaby = new System.Windows.Forms.CheckBox();
			this.cbphone = new System.Windows.Forms.CheckBox();
			this.tbalbum = new System.Windows.Forms.TextBox();
			this.label93 = new System.Windows.Forms.Label();
			this.tbflag = new System.Windows.Forms.TextBox();
			this.label92 = new System.Windows.Forms.Label();
			this.tblotinst = new System.Windows.Forms.TextBox();
			this.llFamiDeleteSim = new System.Windows.Forms.Button();
			this.llFamiAddSim = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cbsims = new System.Windows.Forms.ComboBox();
			this.lbmembers = new System.Windows.Forms.ListBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbfamily = new System.Windows.Forms.TextBox();
			this.tbmoney = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.realPanel = new System.Windows.Forms.Panel();
			this.label91 = new System.Windows.Forms.Label();
			this.cbfamtype = new System.Windows.Forms.ComboBox();
			this.llsrelcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbrelation = new System.Windows.Forms.GroupBox();
			this.cbbest = new System.Windows.Forms.CheckBox();
			this.cbfamily = new System.Windows.Forms.CheckBox();
			this.cbmarried = new System.Windows.Forms.CheckBox();
			this.cbengaged = new System.Windows.Forms.CheckBox();
			this.cbsteady = new System.Windows.Forms.CheckBox();
			this.cblove = new System.Windows.Forms.CheckBox();
			this.cbcrush = new System.Windows.Forms.CheckBox();
			this.cbbuddie = new System.Windows.Forms.CheckBox();
			this.cbfriend = new System.Windows.Forms.CheckBox();
			this.cbenemy = new System.Windows.Forms.CheckBox();
			this.tblongterm = new System.Windows.Forms.TextBox();
			this.tbshortterm = new System.Windows.Forms.TextBox();
			this.label57 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label56 = new System.Windows.Forms.Label();
			this.llrelcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.visualStyleProvider1 = new Skybound.VisualStyles.VisualStyleProvider();
			this.JpegPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.xmlPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.objdPanel.SuspendLayout();
			this.gbelements.SuspendLayout();
			this.panel6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.familytiePanel.SuspendLayout();
			this.gbties.SuspendLayout();
			this.panel8.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.famiPanel.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.realPanel.SuspendLayout();
			this.gbrelation.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// JpegPanel
			// 
			this.JpegPanel.AccessibleDescription = resources.GetString("JpegPanel.AccessibleDescription");
			this.JpegPanel.AccessibleName = resources.GetString("JpegPanel.AccessibleName");
			this.JpegPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("JpegPanel.Anchor")));
			this.JpegPanel.AutoScroll = ((bool)(resources.GetObject("JpegPanel.AutoScroll")));
			this.JpegPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("JpegPanel.AutoScrollMargin")));
			this.JpegPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("JpegPanel.AutoScrollMinSize")));
			this.JpegPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JpegPanel.BackgroundImage")));
			this.JpegPanel.Controls.Add(this.panel2);
			this.JpegPanel.Controls.Add(this.pb);
			this.JpegPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("JpegPanel.Dock")));
			this.JpegPanel.Enabled = ((bool)(resources.GetObject("JpegPanel.Enabled")));
			this.JpegPanel.Font = ((System.Drawing.Font)(resources.GetObject("JpegPanel.Font")));
			this.JpegPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("JpegPanel.ImeMode")));
			this.JpegPanel.Location = ((System.Drawing.Point)(resources.GetObject("JpegPanel.Location")));
			this.JpegPanel.Name = "JpegPanel";
			this.JpegPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("JpegPanel.RightToLeft")));
			this.JpegPanel.Size = ((System.Drawing.Size)(resources.GetObject("JpegPanel.Size")));
			this.JpegPanel.TabIndex = ((int)(resources.GetObject("JpegPanel.TabIndex")));
			this.JpegPanel.Text = resources.GetString("JpegPanel.Text");
			this.toolTip1.SetToolTip(this.JpegPanel, resources.GetString("JpegPanel.ToolTip"));
			this.JpegPanel.Visible = ((bool)(resources.GetObject("JpegPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.JpegPanel, true);
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
			this.panel2.Controls.Add(this.banner);
			this.panel2.Controls.Add(this.btPicExport);
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
			this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel2, true);
			// 
			// banner
			// 
			this.banner.AccessibleDescription = resources.GetString("banner.AccessibleDescription");
			this.banner.AccessibleName = resources.GetString("banner.AccessibleName");
			this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("banner.Anchor")));
			this.banner.AutoSize = ((bool)(resources.GetObject("banner.AutoSize")));
			this.banner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("banner.Dock")));
			this.banner.Enabled = ((bool)(resources.GetObject("banner.Enabled")));
			this.banner.Font = ((System.Drawing.Font)(resources.GetObject("banner.Font")));
			this.banner.Image = ((System.Drawing.Image)(resources.GetObject("banner.Image")));
			this.banner.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.ImageAlign")));
			this.banner.ImageIndex = ((int)(resources.GetObject("banner.ImageIndex")));
			this.banner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("banner.ImeMode")));
			this.banner.Location = ((System.Drawing.Point)(resources.GetObject("banner.Location")));
			this.banner.Name = "banner";
			this.banner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("banner.RightToLeft")));
			this.banner.Size = ((System.Drawing.Size)(resources.GetObject("banner.Size")));
			this.banner.TabIndex = ((int)(resources.GetObject("banner.TabIndex")));
			this.banner.Text = resources.GetString("banner.Text");
			this.banner.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.TextAlign")));
			this.toolTip1.SetToolTip(this.banner, resources.GetString("banner.ToolTip"));
			this.banner.Visible = ((bool)(resources.GetObject("banner.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.banner, true);
			// 
			// btPicExport
			// 
			this.btPicExport.AccessibleDescription = resources.GetString("btPicExport.AccessibleDescription");
			this.btPicExport.AccessibleName = resources.GetString("btPicExport.AccessibleName");
			this.btPicExport.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btPicExport.Anchor")));
			this.btPicExport.BackColor = System.Drawing.SystemColors.Control;
			this.btPicExport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btPicExport.BackgroundImage")));
			this.btPicExport.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btPicExport.Dock")));
			this.btPicExport.Enabled = ((bool)(resources.GetObject("btPicExport.Enabled")));
			this.btPicExport.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btPicExport.FlatStyle")));
			this.btPicExport.Font = ((System.Drawing.Font)(resources.GetObject("btPicExport.Font")));
			this.btPicExport.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btPicExport.Image = ((System.Drawing.Image)(resources.GetObject("btPicExport.Image")));
			this.btPicExport.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btPicExport.ImageAlign")));
			this.btPicExport.ImageIndex = ((int)(resources.GetObject("btPicExport.ImageIndex")));
			this.btPicExport.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btPicExport.ImeMode")));
			this.btPicExport.Location = ((System.Drawing.Point)(resources.GetObject("btPicExport.Location")));
			this.btPicExport.Name = "btPicExport";
			this.btPicExport.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btPicExport.RightToLeft")));
			this.btPicExport.Size = ((System.Drawing.Size)(resources.GetObject("btPicExport.Size")));
			this.btPicExport.TabIndex = ((int)(resources.GetObject("btPicExport.TabIndex")));
			this.btPicExport.Text = resources.GetString("btPicExport.Text");
			this.btPicExport.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btPicExport.TextAlign")));
			this.toolTip1.SetToolTip(this.btPicExport, resources.GetString("btPicExport.ToolTip"));
			this.btPicExport.Visible = ((bool)(resources.GetObject("btPicExport.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btPicExport, true);
			this.btPicExport.Click += new System.EventHandler(this.btPicExport_Click);
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
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
			this.toolTip1.SetToolTip(this.pb, resources.GetString("pb.ToolTip"));
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.pb, true);
			// 
			// xmlPanel
			// 
			this.xmlPanel.AccessibleDescription = resources.GetString("xmlPanel.AccessibleDescription");
			this.xmlPanel.AccessibleName = resources.GetString("xmlPanel.AccessibleName");
			this.xmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xmlPanel.Anchor")));
			this.xmlPanel.AutoScroll = ((bool)(resources.GetObject("xmlPanel.AutoScroll")));
			this.xmlPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xmlPanel.AutoScrollMargin")));
			this.xmlPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xmlPanel.AutoScrollMinSize")));
			this.xmlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xmlPanel.BackgroundImage")));
			this.xmlPanel.Controls.Add(this.rtb);
			this.xmlPanel.Controls.Add(this.panel3);
			this.xmlPanel.Controls.Add(this.visualStyleLinkLabel2);
			this.xmlPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xmlPanel.Dock")));
			this.xmlPanel.Enabled = ((bool)(resources.GetObject("xmlPanel.Enabled")));
			this.xmlPanel.Font = ((System.Drawing.Font)(resources.GetObject("xmlPanel.Font")));
			this.xmlPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xmlPanel.ImeMode")));
			this.xmlPanel.Location = ((System.Drawing.Point)(resources.GetObject("xmlPanel.Location")));
			this.xmlPanel.Name = "xmlPanel";
			this.xmlPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xmlPanel.RightToLeft")));
			this.xmlPanel.Size = ((System.Drawing.Size)(resources.GetObject("xmlPanel.Size")));
			this.xmlPanel.TabIndex = ((int)(resources.GetObject("xmlPanel.TabIndex")));
			this.xmlPanel.Text = resources.GetString("xmlPanel.Text");
			this.toolTip1.SetToolTip(this.xmlPanel, resources.GetString("xmlPanel.ToolTip"));
			this.xmlPanel.Visible = ((bool)(resources.GetObject("xmlPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.xmlPanel, true);
			// 
			// rtb
			// 
			this.rtb.AccessibleDescription = resources.GetString("rtb.AccessibleDescription");
			this.rtb.AccessibleName = resources.GetString("rtb.AccessibleName");
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtb.Anchor")));
			this.rtb.AutoSize = ((bool)(resources.GetObject("rtb.AutoSize")));
			this.rtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtb.BackgroundImage")));
			this.rtb.BulletIndent = ((int)(resources.GetObject("rtb.BulletIndent")));
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
			this.rtb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtb.ImeMode")));
			this.rtb.Location = ((System.Drawing.Point)(resources.GetObject("rtb.Location")));
			this.rtb.MaxLength = ((int)(resources.GetObject("rtb.MaxLength")));
			this.rtb.Multiline = ((bool)(resources.GetObject("rtb.Multiline")));
			this.rtb.Name = "rtb";
			this.rtb.RightMargin = ((int)(resources.GetObject("rtb.RightMargin")));
			this.rtb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtb.RightToLeft")));
			this.rtb.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtb.ScrollBars")));
			this.rtb.Size = ((System.Drawing.Size)(resources.GetObject("rtb.Size")));
			this.rtb.TabIndex = ((int)(resources.GetObject("rtb.TabIndex")));
			this.rtb.Text = resources.GetString("rtb.Text");
			this.toolTip1.SetToolTip(this.rtb, resources.GetString("rtb.ToolTip"));
			this.rtb.Visible = ((bool)(resources.GetObject("rtb.Visible")));
			this.rtb.WordWrap = ((bool)(resources.GetObject("rtb.WordWrap")));
			this.rtb.ZoomFactor = ((System.Single)(resources.GetObject("rtb.ZoomFactor")));
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
			this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel3, true);
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
			this.visualStyleProvider1.SetVisualStyleSupport(this.label1, true);
			// 
			// visualStyleLinkLabel2
			// 
			this.visualStyleLinkLabel2.AccessibleDescription = resources.GetString("visualStyleLinkLabel2.AccessibleDescription");
			this.visualStyleLinkLabel2.AccessibleName = resources.GetString("visualStyleLinkLabel2.AccessibleName");
			this.visualStyleLinkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("visualStyleLinkLabel2.Anchor")));
			this.visualStyleLinkLabel2.AutoSize = ((bool)(resources.GetObject("visualStyleLinkLabel2.AutoSize")));
			this.visualStyleLinkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("visualStyleLinkLabel2.Dock")));
			this.visualStyleLinkLabel2.Enabled = ((bool)(resources.GetObject("visualStyleLinkLabel2.Enabled")));
			this.visualStyleLinkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("visualStyleLinkLabel2.Font")));
			this.visualStyleLinkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("visualStyleLinkLabel2.Image")));
			this.visualStyleLinkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("visualStyleLinkLabel2.ImageAlign")));
			this.visualStyleLinkLabel2.ImageIndex = ((int)(resources.GetObject("visualStyleLinkLabel2.ImageIndex")));
			this.visualStyleLinkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("visualStyleLinkLabel2.ImeMode")));
			this.visualStyleLinkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("visualStyleLinkLabel2.LinkArea")));
			this.visualStyleLinkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("visualStyleLinkLabel2.Location")));
			this.visualStyleLinkLabel2.Name = "visualStyleLinkLabel2";
			this.visualStyleLinkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("visualStyleLinkLabel2.RightToLeft")));
			this.visualStyleLinkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("visualStyleLinkLabel2.Size")));
			this.visualStyleLinkLabel2.TabIndex = ((int)(resources.GetObject("visualStyleLinkLabel2.TabIndex")));
			this.visualStyleLinkLabel2.TabStop = true;
			this.visualStyleLinkLabel2.Text = resources.GetString("visualStyleLinkLabel2.Text");
			this.visualStyleLinkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("visualStyleLinkLabel2.TextAlign")));
			this.toolTip1.SetToolTip(this.visualStyleLinkLabel2, resources.GetString("visualStyleLinkLabel2.ToolTip"));
			this.visualStyleLinkLabel2.Visible = ((bool)(resources.GetObject("visualStyleLinkLabel2.Visible")));
			this.visualStyleLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitXmlClick);
			// 
			// objdPanel
			// 
			this.objdPanel.AccessibleDescription = resources.GetString("objdPanel.AccessibleDescription");
			this.objdPanel.AccessibleName = resources.GetString("objdPanel.AccessibleName");
			this.objdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("objdPanel.Anchor")));
			this.objdPanel.AutoScroll = ((bool)(resources.GetObject("objdPanel.AutoScroll")));
			this.objdPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("objdPanel.AutoScrollMargin")));
			this.objdPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("objdPanel.AutoScrollMinSize")));
			this.objdPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("objdPanel.BackgroundImage")));
			this.objdPanel.Controls.Add(this.cbupdate);
			this.objdPanel.Controls.Add(this.label63);
			this.objdPanel.Controls.Add(this.tbproxguid);
			this.objdPanel.Controls.Add(this.label97);
			this.objdPanel.Controls.Add(this.tborgguid);
			this.objdPanel.Controls.Add(this.lbtypename);
			this.objdPanel.Controls.Add(this.llgetGUID);
			this.objdPanel.Controls.Add(this.gbelements);
			this.objdPanel.Controls.Add(this.llcommitobjd);
			this.objdPanel.Controls.Add(this.tblottype);
			this.objdPanel.Controls.Add(this.label65);
			this.objdPanel.Controls.Add(this.tbsimname);
			this.objdPanel.Controls.Add(this.label9);
			this.objdPanel.Controls.Add(this.tbsimid);
			this.objdPanel.Controls.Add(this.label8);
			this.objdPanel.Controls.Add(this.panel6);
			this.objdPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("objdPanel.Dock")));
			this.objdPanel.Enabled = ((bool)(resources.GetObject("objdPanel.Enabled")));
			this.objdPanel.Font = ((System.Drawing.Font)(resources.GetObject("objdPanel.Font")));
			this.objdPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("objdPanel.ImeMode")));
			this.objdPanel.Location = ((System.Drawing.Point)(resources.GetObject("objdPanel.Location")));
			this.objdPanel.Name = "objdPanel";
			this.objdPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("objdPanel.RightToLeft")));
			this.objdPanel.Size = ((System.Drawing.Size)(resources.GetObject("objdPanel.Size")));
			this.objdPanel.TabIndex = ((int)(resources.GetObject("objdPanel.TabIndex")));
			this.objdPanel.Text = resources.GetString("objdPanel.Text");
			this.toolTip1.SetToolTip(this.objdPanel, resources.GetString("objdPanel.ToolTip"));
			this.objdPanel.Visible = ((bool)(resources.GetObject("objdPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.objdPanel, true);
			// 
			// cbupdate
			// 
			this.cbupdate.AccessibleDescription = resources.GetString("cbupdate.AccessibleDescription");
			this.cbupdate.AccessibleName = resources.GetString("cbupdate.AccessibleName");
			this.cbupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbupdate.Anchor")));
			this.cbupdate.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbupdate.Appearance")));
			this.cbupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbupdate.BackgroundImage")));
			this.cbupdate.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.CheckAlign")));
			this.cbupdate.Checked = true;
			this.cbupdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbupdate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbupdate.Dock")));
			this.cbupdate.Enabled = ((bool)(resources.GetObject("cbupdate.Enabled")));
			this.cbupdate.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbupdate.FlatStyle")));
			this.cbupdate.Font = ((System.Drawing.Font)(resources.GetObject("cbupdate.Font")));
			this.cbupdate.Image = ((System.Drawing.Image)(resources.GetObject("cbupdate.Image")));
			this.cbupdate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.ImageAlign")));
			this.cbupdate.ImageIndex = ((int)(resources.GetObject("cbupdate.ImageIndex")));
			this.cbupdate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbupdate.ImeMode")));
			this.cbupdate.Location = ((System.Drawing.Point)(resources.GetObject("cbupdate.Location")));
			this.cbupdate.Name = "cbupdate";
			this.cbupdate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbupdate.RightToLeft")));
			this.cbupdate.Size = ((System.Drawing.Size)(resources.GetObject("cbupdate.Size")));
			this.cbupdate.TabIndex = ((int)(resources.GetObject("cbupdate.TabIndex")));
			this.cbupdate.Text = resources.GetString("cbupdate.Text");
			this.cbupdate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.TextAlign")));
			this.toolTip1.SetToolTip(this.cbupdate, resources.GetString("cbupdate.ToolTip"));
			this.cbupdate.Visible = ((bool)(resources.GetObject("cbupdate.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbupdate, true);
			// 
			// label63
			// 
			this.label63.AccessibleDescription = resources.GetString("label63.AccessibleDescription");
			this.label63.AccessibleName = resources.GetString("label63.AccessibleName");
			this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label63.Anchor")));
			this.label63.AutoSize = ((bool)(resources.GetObject("label63.AutoSize")));
			this.label63.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label63.Dock")));
			this.label63.Enabled = ((bool)(resources.GetObject("label63.Enabled")));
			this.label63.Font = ((System.Drawing.Font)(resources.GetObject("label63.Font")));
			this.label63.Image = ((System.Drawing.Image)(resources.GetObject("label63.Image")));
			this.label63.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label63.ImageAlign")));
			this.label63.ImageIndex = ((int)(resources.GetObject("label63.ImageIndex")));
			this.label63.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label63.ImeMode")));
			this.label63.Location = ((System.Drawing.Point)(resources.GetObject("label63.Location")));
			this.label63.Name = "label63";
			this.label63.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label63.RightToLeft")));
			this.label63.Size = ((System.Drawing.Size)(resources.GetObject("label63.Size")));
			this.label63.TabIndex = ((int)(resources.GetObject("label63.TabIndex")));
			this.label63.Text = resources.GetString("label63.Text");
			this.label63.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label63.TextAlign")));
			this.toolTip1.SetToolTip(this.label63, resources.GetString("label63.ToolTip"));
			this.label63.Visible = ((bool)(resources.GetObject("label63.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label63, true);
			// 
			// tbproxguid
			// 
			this.tbproxguid.AccessibleDescription = resources.GetString("tbproxguid.AccessibleDescription");
			this.tbproxguid.AccessibleName = resources.GetString("tbproxguid.AccessibleName");
			this.tbproxguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbproxguid.Anchor")));
			this.tbproxguid.AutoSize = ((bool)(resources.GetObject("tbproxguid.AutoSize")));
			this.tbproxguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbproxguid.BackgroundImage")));
			this.tbproxguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbproxguid.Dock")));
			this.tbproxguid.Enabled = ((bool)(resources.GetObject("tbproxguid.Enabled")));
			this.tbproxguid.Font = ((System.Drawing.Font)(resources.GetObject("tbproxguid.Font")));
			this.tbproxguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbproxguid.ImeMode")));
			this.tbproxguid.Location = ((System.Drawing.Point)(resources.GetObject("tbproxguid.Location")));
			this.tbproxguid.MaxLength = ((int)(resources.GetObject("tbproxguid.MaxLength")));
			this.tbproxguid.Multiline = ((bool)(resources.GetObject("tbproxguid.Multiline")));
			this.tbproxguid.Name = "tbproxguid";
			this.tbproxguid.PasswordChar = ((char)(resources.GetObject("tbproxguid.PasswordChar")));
			this.tbproxguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbproxguid.RightToLeft")));
			this.tbproxguid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbproxguid.ScrollBars")));
			this.tbproxguid.Size = ((System.Drawing.Size)(resources.GetObject("tbproxguid.Size")));
			this.tbproxguid.TabIndex = ((int)(resources.GetObject("tbproxguid.TabIndex")));
			this.tbproxguid.Text = resources.GetString("tbproxguid.Text");
			this.tbproxguid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbproxguid.TextAlign")));
			this.toolTip1.SetToolTip(this.tbproxguid, resources.GetString("tbproxguid.ToolTip"));
			this.tbproxguid.Visible = ((bool)(resources.GetObject("tbproxguid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbproxguid, true);
			this.tbproxguid.WordWrap = ((bool)(resources.GetObject("tbproxguid.WordWrap")));
			// 
			// label97
			// 
			this.label97.AccessibleDescription = resources.GetString("label97.AccessibleDescription");
			this.label97.AccessibleName = resources.GetString("label97.AccessibleName");
			this.label97.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label97.Anchor")));
			this.label97.AutoSize = ((bool)(resources.GetObject("label97.AutoSize")));
			this.label97.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label97.Dock")));
			this.label97.Enabled = ((bool)(resources.GetObject("label97.Enabled")));
			this.label97.Font = ((System.Drawing.Font)(resources.GetObject("label97.Font")));
			this.label97.Image = ((System.Drawing.Image)(resources.GetObject("label97.Image")));
			this.label97.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label97.ImageAlign")));
			this.label97.ImageIndex = ((int)(resources.GetObject("label97.ImageIndex")));
			this.label97.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label97.ImeMode")));
			this.label97.Location = ((System.Drawing.Point)(resources.GetObject("label97.Location")));
			this.label97.Name = "label97";
			this.label97.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label97.RightToLeft")));
			this.label97.Size = ((System.Drawing.Size)(resources.GetObject("label97.Size")));
			this.label97.TabIndex = ((int)(resources.GetObject("label97.TabIndex")));
			this.label97.Text = resources.GetString("label97.Text");
			this.label97.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label97.TextAlign")));
			this.toolTip1.SetToolTip(this.label97, resources.GetString("label97.ToolTip"));
			this.label97.Visible = ((bool)(resources.GetObject("label97.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label97, true);
			// 
			// tborgguid
			// 
			this.tborgguid.AccessibleDescription = resources.GetString("tborgguid.AccessibleDescription");
			this.tborgguid.AccessibleName = resources.GetString("tborgguid.AccessibleName");
			this.tborgguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tborgguid.Anchor")));
			this.tborgguid.AutoSize = ((bool)(resources.GetObject("tborgguid.AutoSize")));
			this.tborgguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tborgguid.BackgroundImage")));
			this.tborgguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tborgguid.Dock")));
			this.tborgguid.Enabled = ((bool)(resources.GetObject("tborgguid.Enabled")));
			this.tborgguid.Font = ((System.Drawing.Font)(resources.GetObject("tborgguid.Font")));
			this.tborgguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tborgguid.ImeMode")));
			this.tborgguid.Location = ((System.Drawing.Point)(resources.GetObject("tborgguid.Location")));
			this.tborgguid.MaxLength = ((int)(resources.GetObject("tborgguid.MaxLength")));
			this.tborgguid.Multiline = ((bool)(resources.GetObject("tborgguid.Multiline")));
			this.tborgguid.Name = "tborgguid";
			this.tborgguid.PasswordChar = ((char)(resources.GetObject("tborgguid.PasswordChar")));
			this.tborgguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tborgguid.RightToLeft")));
			this.tborgguid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tborgguid.ScrollBars")));
			this.tborgguid.Size = ((System.Drawing.Size)(resources.GetObject("tborgguid.Size")));
			this.tborgguid.TabIndex = ((int)(resources.GetObject("tborgguid.TabIndex")));
			this.tborgguid.Text = resources.GetString("tborgguid.Text");
			this.tborgguid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tborgguid.TextAlign")));
			this.toolTip1.SetToolTip(this.tborgguid, resources.GetString("tborgguid.ToolTip"));
			this.tborgguid.Visible = ((bool)(resources.GetObject("tborgguid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tborgguid, true);
			this.tborgguid.WordWrap = ((bool)(resources.GetObject("tborgguid.WordWrap")));
			// 
			// lbtypename
			// 
			this.lbtypename.AccessibleDescription = resources.GetString("lbtypename.AccessibleDescription");
			this.lbtypename.AccessibleName = resources.GetString("lbtypename.AccessibleName");
			this.lbtypename.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbtypename.Anchor")));
			this.lbtypename.AutoSize = ((bool)(resources.GetObject("lbtypename.AutoSize")));
			this.lbtypename.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbtypename.Dock")));
			this.lbtypename.Enabled = ((bool)(resources.GetObject("lbtypename.Enabled")));
			this.lbtypename.Font = ((System.Drawing.Font)(resources.GetObject("lbtypename.Font")));
			this.lbtypename.Image = ((System.Drawing.Image)(resources.GetObject("lbtypename.Image")));
			this.lbtypename.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtypename.ImageAlign")));
			this.lbtypename.ImageIndex = ((int)(resources.GetObject("lbtypename.ImageIndex")));
			this.lbtypename.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbtypename.ImeMode")));
			this.lbtypename.Location = ((System.Drawing.Point)(resources.GetObject("lbtypename.Location")));
			this.lbtypename.Name = "lbtypename";
			this.lbtypename.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbtypename.RightToLeft")));
			this.lbtypename.Size = ((System.Drawing.Size)(resources.GetObject("lbtypename.Size")));
			this.lbtypename.TabIndex = ((int)(resources.GetObject("lbtypename.TabIndex")));
			this.lbtypename.Text = resources.GetString("lbtypename.Text");
			this.lbtypename.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtypename.TextAlign")));
			this.toolTip1.SetToolTip(this.lbtypename, resources.GetString("lbtypename.ToolTip"));
			this.lbtypename.Visible = ((bool)(resources.GetObject("lbtypename.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.lbtypename, true);
			// 
			// llgetGUID
			// 
			this.llgetGUID.AccessibleDescription = resources.GetString("llgetGUID.AccessibleDescription");
			this.llgetGUID.AccessibleName = resources.GetString("llgetGUID.AccessibleName");
			this.llgetGUID.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llgetGUID.Anchor")));
			this.llgetGUID.AutoSize = ((bool)(resources.GetObject("llgetGUID.AutoSize")));
			this.llgetGUID.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llgetGUID.Dock")));
			this.llgetGUID.Enabled = ((bool)(resources.GetObject("llgetGUID.Enabled")));
			this.llgetGUID.Font = ((System.Drawing.Font)(resources.GetObject("llgetGUID.Font")));
			this.llgetGUID.Image = ((System.Drawing.Image)(resources.GetObject("llgetGUID.Image")));
			this.llgetGUID.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llgetGUID.ImageAlign")));
			this.llgetGUID.ImageIndex = ((int)(resources.GetObject("llgetGUID.ImageIndex")));
			this.llgetGUID.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llgetGUID.ImeMode")));
			this.llgetGUID.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llgetGUID.LinkArea")));
			this.llgetGUID.Location = ((System.Drawing.Point)(resources.GetObject("llgetGUID.Location")));
			this.llgetGUID.Name = "llgetGUID";
			this.llgetGUID.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llgetGUID.RightToLeft")));
			this.llgetGUID.Size = ((System.Drawing.Size)(resources.GetObject("llgetGUID.Size")));
			this.llgetGUID.TabIndex = ((int)(resources.GetObject("llgetGUID.TabIndex")));
			this.llgetGUID.TabStop = true;
			this.llgetGUID.Text = resources.GetString("llgetGUID.Text");
			this.llgetGUID.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llgetGUID.TextAlign")));
			this.toolTip1.SetToolTip(this.llgetGUID, resources.GetString("llgetGUID.ToolTip"));
			this.llgetGUID.Visible = ((bool)(resources.GetObject("llgetGUID.Visible")));
			this.llgetGUID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetGUIDClicked);
			// 
			// gbelements
			// 
			this.gbelements.AccessibleDescription = resources.GetString("gbelements.AccessibleDescription");
			this.gbelements.AccessibleName = resources.GetString("gbelements.AccessibleName");
			this.gbelements.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbelements.Anchor")));
			this.gbelements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbelements.BackgroundImage")));
			this.gbelements.Controls.Add(this.pnelements);
			this.gbelements.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbelements.Dock")));
			this.gbelements.Enabled = ((bool)(resources.GetObject("gbelements.Enabled")));
			this.gbelements.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbelements.Font = ((System.Drawing.Font)(resources.GetObject("gbelements.Font")));
			this.gbelements.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbelements.ImeMode")));
			this.gbelements.Location = ((System.Drawing.Point)(resources.GetObject("gbelements.Location")));
			this.gbelements.Name = "gbelements";
			this.gbelements.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbelements.RightToLeft")));
			this.gbelements.Size = ((System.Drawing.Size)(resources.GetObject("gbelements.Size")));
			this.gbelements.TabIndex = ((int)(resources.GetObject("gbelements.TabIndex")));
			this.gbelements.TabStop = false;
			this.gbelements.Text = resources.GetString("gbelements.Text");
			this.toolTip1.SetToolTip(this.gbelements, resources.GetString("gbelements.ToolTip"));
			this.gbelements.Visible = ((bool)(resources.GetObject("gbelements.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbelements, true);
			// 
			// pnelements
			// 
			this.pnelements.AccessibleDescription = resources.GetString("pnelements.AccessibleDescription");
			this.pnelements.AccessibleName = resources.GetString("pnelements.AccessibleName");
			this.pnelements.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnelements.Anchor")));
			this.pnelements.AutoScroll = ((bool)(resources.GetObject("pnelements.AutoScroll")));
			this.pnelements.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnelements.AutoScrollMargin")));
			this.pnelements.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnelements.AutoScrollMinSize")));
			this.pnelements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnelements.BackgroundImage")));
			this.pnelements.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnelements.Dock")));
			this.pnelements.Enabled = ((bool)(resources.GetObject("pnelements.Enabled")));
			this.pnelements.Font = ((System.Drawing.Font)(resources.GetObject("pnelements.Font")));
			this.pnelements.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnelements.ImeMode")));
			this.pnelements.Location = ((System.Drawing.Point)(resources.GetObject("pnelements.Location")));
			this.pnelements.Name = "pnelements";
			this.pnelements.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnelements.RightToLeft")));
			this.pnelements.Size = ((System.Drawing.Size)(resources.GetObject("pnelements.Size")));
			this.pnelements.TabIndex = ((int)(resources.GetObject("pnelements.TabIndex")));
			this.pnelements.Text = resources.GetString("pnelements.Text");
			this.toolTip1.SetToolTip(this.pnelements, resources.GetString("pnelements.ToolTip"));
			this.pnelements.Visible = ((bool)(resources.GetObject("pnelements.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnelements, true);
			// 
			// llcommitobjd
			// 
			this.llcommitobjd.AccessibleDescription = resources.GetString("llcommitobjd.AccessibleDescription");
			this.llcommitobjd.AccessibleName = resources.GetString("llcommitobjd.AccessibleName");
			this.llcommitobjd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommitobjd.Anchor")));
			this.llcommitobjd.AutoSize = ((bool)(resources.GetObject("llcommitobjd.AutoSize")));
			this.llcommitobjd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommitobjd.Dock")));
			this.llcommitobjd.Enabled = ((bool)(resources.GetObject("llcommitobjd.Enabled")));
			this.llcommitobjd.Font = ((System.Drawing.Font)(resources.GetObject("llcommitobjd.Font")));
			this.llcommitobjd.Image = ((System.Drawing.Image)(resources.GetObject("llcommitobjd.Image")));
			this.llcommitobjd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitobjd.ImageAlign")));
			this.llcommitobjd.ImageIndex = ((int)(resources.GetObject("llcommitobjd.ImageIndex")));
			this.llcommitobjd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommitobjd.ImeMode")));
			this.llcommitobjd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommitobjd.LinkArea")));
			this.llcommitobjd.Location = ((System.Drawing.Point)(resources.GetObject("llcommitobjd.Location")));
			this.llcommitobjd.Name = "llcommitobjd";
			this.llcommitobjd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommitobjd.RightToLeft")));
			this.llcommitobjd.Size = ((System.Drawing.Size)(resources.GetObject("llcommitobjd.Size")));
			this.llcommitobjd.TabIndex = ((int)(resources.GetObject("llcommitobjd.TabIndex")));
			this.llcommitobjd.TabStop = true;
			this.llcommitobjd.Text = resources.GetString("llcommitobjd.Text");
			this.llcommitobjd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitobjd.TextAlign")));
			this.toolTip1.SetToolTip(this.llcommitobjd, resources.GetString("llcommitobjd.ToolTip"));
			this.llcommitobjd.Visible = ((bool)(resources.GetObject("llcommitobjd.Visible")));
			this.llcommitobjd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitObjdClicked);
			// 
			// tblottype
			// 
			this.tblottype.AccessibleDescription = resources.GetString("tblottype.AccessibleDescription");
			this.tblottype.AccessibleName = resources.GetString("tblottype.AccessibleName");
			this.tblottype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblottype.Anchor")));
			this.tblottype.AutoSize = ((bool)(resources.GetObject("tblottype.AutoSize")));
			this.tblottype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblottype.BackgroundImage")));
			this.tblottype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblottype.Dock")));
			this.tblottype.Enabled = ((bool)(resources.GetObject("tblottype.Enabled")));
			this.tblottype.Font = ((System.Drawing.Font)(resources.GetObject("tblottype.Font")));
			this.tblottype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblottype.ImeMode")));
			this.tblottype.Location = ((System.Drawing.Point)(resources.GetObject("tblottype.Location")));
			this.tblottype.MaxLength = ((int)(resources.GetObject("tblottype.MaxLength")));
			this.tblottype.Multiline = ((bool)(resources.GetObject("tblottype.Multiline")));
			this.tblottype.Name = "tblottype";
			this.tblottype.PasswordChar = ((char)(resources.GetObject("tblottype.PasswordChar")));
			this.tblottype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblottype.RightToLeft")));
			this.tblottype.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblottype.ScrollBars")));
			this.tblottype.Size = ((System.Drawing.Size)(resources.GetObject("tblottype.Size")));
			this.tblottype.TabIndex = ((int)(resources.GetObject("tblottype.TabIndex")));
			this.tblottype.Text = resources.GetString("tblottype.Text");
			this.tblottype.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblottype.TextAlign")));
			this.toolTip1.SetToolTip(this.tblottype, resources.GetString("tblottype.ToolTip"));
			this.tblottype.Visible = ((bool)(resources.GetObject("tblottype.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblottype, true);
			this.tblottype.WordWrap = ((bool)(resources.GetObject("tblottype.WordWrap")));
			// 
			// label65
			// 
			this.label65.AccessibleDescription = resources.GetString("label65.AccessibleDescription");
			this.label65.AccessibleName = resources.GetString("label65.AccessibleName");
			this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label65.Anchor")));
			this.label65.AutoSize = ((bool)(resources.GetObject("label65.AutoSize")));
			this.label65.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label65.Dock")));
			this.label65.Enabled = ((bool)(resources.GetObject("label65.Enabled")));
			this.label65.Font = ((System.Drawing.Font)(resources.GetObject("label65.Font")));
			this.label65.Image = ((System.Drawing.Image)(resources.GetObject("label65.Image")));
			this.label65.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label65.ImageAlign")));
			this.label65.ImageIndex = ((int)(resources.GetObject("label65.ImageIndex")));
			this.label65.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label65.ImeMode")));
			this.label65.Location = ((System.Drawing.Point)(resources.GetObject("label65.Location")));
			this.label65.Name = "label65";
			this.label65.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label65.RightToLeft")));
			this.label65.Size = ((System.Drawing.Size)(resources.GetObject("label65.Size")));
			this.label65.TabIndex = ((int)(resources.GetObject("label65.TabIndex")));
			this.label65.Text = resources.GetString("label65.Text");
			this.label65.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label65.TextAlign")));
			this.toolTip1.SetToolTip(this.label65, resources.GetString("label65.ToolTip"));
			this.label65.Visible = ((bool)(resources.GetObject("label65.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label65, true);
			// 
			// tbsimname
			// 
			this.tbsimname.AccessibleDescription = resources.GetString("tbsimname.AccessibleDescription");
			this.tbsimname.AccessibleName = resources.GetString("tbsimname.AccessibleName");
			this.tbsimname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimname.Anchor")));
			this.tbsimname.AutoSize = ((bool)(resources.GetObject("tbsimname.AutoSize")));
			this.tbsimname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimname.BackgroundImage")));
			this.tbsimname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimname.Dock")));
			this.tbsimname.Enabled = ((bool)(resources.GetObject("tbsimname.Enabled")));
			this.tbsimname.Font = ((System.Drawing.Font)(resources.GetObject("tbsimname.Font")));
			this.tbsimname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimname.ImeMode")));
			this.tbsimname.Location = ((System.Drawing.Point)(resources.GetObject("tbsimname.Location")));
			this.tbsimname.MaxLength = ((int)(resources.GetObject("tbsimname.MaxLength")));
			this.tbsimname.Multiline = ((bool)(resources.GetObject("tbsimname.Multiline")));
			this.tbsimname.Name = "tbsimname";
			this.tbsimname.PasswordChar = ((char)(resources.GetObject("tbsimname.PasswordChar")));
			this.tbsimname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimname.RightToLeft")));
			this.tbsimname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimname.ScrollBars")));
			this.tbsimname.Size = ((System.Drawing.Size)(resources.GetObject("tbsimname.Size")));
			this.tbsimname.TabIndex = ((int)(resources.GetObject("tbsimname.TabIndex")));
			this.tbsimname.Text = resources.GetString("tbsimname.Text");
			this.tbsimname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimname.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsimname, resources.GetString("tbsimname.ToolTip"));
			this.tbsimname.Visible = ((bool)(resources.GetObject("tbsimname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimname, true);
			this.tbsimname.WordWrap = ((bool)(resources.GetObject("tbsimname.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label9, true);
			// 
			// tbsimid
			// 
			this.tbsimid.AccessibleDescription = resources.GetString("tbsimid.AccessibleDescription");
			this.tbsimid.AccessibleName = resources.GetString("tbsimid.AccessibleName");
			this.tbsimid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimid.Anchor")));
			this.tbsimid.AutoSize = ((bool)(resources.GetObject("tbsimid.AutoSize")));
			this.tbsimid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimid.BackgroundImage")));
			this.tbsimid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimid.Dock")));
			this.tbsimid.Enabled = ((bool)(resources.GetObject("tbsimid.Enabled")));
			this.tbsimid.Font = ((System.Drawing.Font)(resources.GetObject("tbsimid.Font")));
			this.tbsimid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimid.ImeMode")));
			this.tbsimid.Location = ((System.Drawing.Point)(resources.GetObject("tbsimid.Location")));
			this.tbsimid.MaxLength = ((int)(resources.GetObject("tbsimid.MaxLength")));
			this.tbsimid.Multiline = ((bool)(resources.GetObject("tbsimid.Multiline")));
			this.tbsimid.Name = "tbsimid";
			this.tbsimid.PasswordChar = ((char)(resources.GetObject("tbsimid.PasswordChar")));
			this.tbsimid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimid.RightToLeft")));
			this.tbsimid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimid.ScrollBars")));
			this.tbsimid.Size = ((System.Drawing.Size)(resources.GetObject("tbsimid.Size")));
			this.tbsimid.TabIndex = ((int)(resources.GetObject("tbsimid.TabIndex")));
			this.tbsimid.Text = resources.GetString("tbsimid.Text");
			this.tbsimid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimid.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsimid, resources.GetString("tbsimid.ToolTip"));
			this.tbsimid.Visible = ((bool)(resources.GetObject("tbsimid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimid, true);
			this.tbsimid.WordWrap = ((bool)(resources.GetObject("tbsimid.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label8, true);
			// 
			// panel6
			// 
			this.panel6.AccessibleDescription = resources.GetString("panel6.AccessibleDescription");
			this.panel6.AccessibleName = resources.GetString("panel6.AccessibleName");
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel6.Anchor")));
			this.panel6.AutoScroll = ((bool)(resources.GetObject("panel6.AutoScroll")));
			this.panel6.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMargin")));
			this.panel6.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMinSize")));
			this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.Controls.Add(this.label12);
			this.panel6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel6.Dock")));
			this.panel6.Enabled = ((bool)(resources.GetObject("panel6.Enabled")));
			this.panel6.Font = ((System.Drawing.Font)(resources.GetObject("panel6.Font")));
			this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel6.ImeMode")));
			this.panel6.Location = ((System.Drawing.Point)(resources.GetObject("panel6.Location")));
			this.panel6.Name = "panel6";
			this.panel6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel6.RightToLeft")));
			this.panel6.Size = ((System.Drawing.Size)(resources.GetObject("panel6.Size")));
			this.panel6.TabIndex = ((int)(resources.GetObject("panel6.TabIndex")));
			this.panel6.Text = resources.GetString("panel6.Text");
			this.toolTip1.SetToolTip(this.panel6, resources.GetString("panel6.ToolTip"));
			this.panel6.Visible = ((bool)(resources.GetObject("panel6.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel6, true);
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
			this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
			this.label12.Visible = ((bool)(resources.GetObject("label12.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label12, true);
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = resources.GetString("tabControl1.AccessibleDescription");
			this.tabControl1.AccessibleName = resources.GetString("tabControl1.AccessibleName");
			this.tabControl1.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl1.Alignment")));
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl1.Anchor")));
			this.tabControl1.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl1.Appearance")));
			this.tabControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl1.BackgroundImage")));
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl1.Dock")));
			this.tabControl1.Enabled = ((bool)(resources.GetObject("tabControl1.Enabled")));
			this.tabControl1.Font = ((System.Drawing.Font)(resources.GetObject("tabControl1.Font")));
			this.tabControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl1.ImeMode")));
			this.tabControl1.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControl1.ItemSize")));
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl1.Padding")));
			this.tabControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl1.RightToLeft")));
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = ((bool)(resources.GetObject("tabControl1.ShowToolTips")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			this.tabControl1.TabIndex = ((int)(resources.GetObject("tabControl1.TabIndex")));
			this.tabControl1.Text = resources.GetString("tabControl1.Text");
			this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
			this.tabControl1.Visible = ((bool)(resources.GetObject("tabControl1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabControl1, true);
			// 
			// tabPage4
			// 
			this.tabPage4.AccessibleDescription = resources.GetString("tabPage4.AccessibleDescription");
			this.tabPage4.AccessibleName = resources.GetString("tabPage4.AccessibleName");
			this.tabPage4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage4.Anchor")));
			this.tabPage4.AutoScroll = ((bool)(resources.GetObject("tabPage4.AutoScroll")));
			this.tabPage4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMargin")));
			this.tabPage4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMinSize")));
			this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
			this.tabPage4.Controls.Add(this.familytiePanel);
			this.tabPage4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage4.Dock")));
			this.tabPage4.Enabled = ((bool)(resources.GetObject("tabPage4.Enabled")));
			this.tabPage4.Font = ((System.Drawing.Font)(resources.GetObject("tabPage4.Font")));
			this.tabPage4.ImageIndex = ((int)(resources.GetObject("tabPage4.ImageIndex")));
			this.tabPage4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage4.ImeMode")));
			this.tabPage4.Location = ((System.Drawing.Point)(resources.GetObject("tabPage4.Location")));
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage4.RightToLeft")));
			this.tabPage4.Size = ((System.Drawing.Size)(resources.GetObject("tabPage4.Size")));
			this.tabPage4.TabIndex = ((int)(resources.GetObject("tabPage4.TabIndex")));
			this.tabPage4.Text = resources.GetString("tabPage4.Text");
			this.toolTip1.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
			this.tabPage4.ToolTipText = resources.GetString("tabPage4.ToolTipText");
			this.tabPage4.Visible = ((bool)(resources.GetObject("tabPage4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage4, true);
			// 
			// familytiePanel
			// 
			this.familytiePanel.AccessibleDescription = resources.GetString("familytiePanel.AccessibleDescription");
			this.familytiePanel.AccessibleName = resources.GetString("familytiePanel.AccessibleName");
			this.familytiePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("familytiePanel.Anchor")));
			this.familytiePanel.AutoScroll = ((bool)(resources.GetObject("familytiePanel.AutoScroll")));
			this.familytiePanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("familytiePanel.AutoScrollMargin")));
			this.familytiePanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("familytiePanel.AutoScrollMinSize")));
			this.familytiePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("familytiePanel.BackgroundImage")));
			this.familytiePanel.Controls.Add(this.gbties);
			this.familytiePanel.Controls.Add(this.cbtiesims);
			this.familytiePanel.Controls.Add(this.bttiecommit);
			this.familytiePanel.Controls.Add(this.label64);
			this.familytiePanel.Controls.Add(this.panel8);
			this.familytiePanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("familytiePanel.Dock")));
			this.familytiePanel.Enabled = ((bool)(resources.GetObject("familytiePanel.Enabled")));
			this.familytiePanel.Font = ((System.Drawing.Font)(resources.GetObject("familytiePanel.Font")));
			this.familytiePanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("familytiePanel.ImeMode")));
			this.familytiePanel.Location = ((System.Drawing.Point)(resources.GetObject("familytiePanel.Location")));
			this.familytiePanel.Name = "familytiePanel";
			this.familytiePanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("familytiePanel.RightToLeft")));
			this.familytiePanel.Size = ((System.Drawing.Size)(resources.GetObject("familytiePanel.Size")));
			this.familytiePanel.TabIndex = ((int)(resources.GetObject("familytiePanel.TabIndex")));
			this.familytiePanel.Text = resources.GetString("familytiePanel.Text");
			this.toolTip1.SetToolTip(this.familytiePanel, resources.GetString("familytiePanel.ToolTip"));
			this.familytiePanel.Visible = ((bool)(resources.GetObject("familytiePanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.familytiePanel, true);
			// 
			// gbties
			// 
			this.gbties.AccessibleDescription = resources.GetString("gbties.AccessibleDescription");
			this.gbties.AccessibleName = resources.GetString("gbties.AccessibleName");
			this.gbties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbties.Anchor")));
			this.gbties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbties.BackgroundImage")));
			this.gbties.Controls.Add(this.btnewtie);
			this.gbties.Controls.Add(this.cballtieablesims);
			this.gbties.Controls.Add(this.cbtietype);
			this.gbties.Controls.Add(this.lbties);
			this.gbties.Controls.Add(this.btdeletetie);
			this.gbties.Controls.Add(this.btaddtie);
			this.gbties.Controls.Add(this.llcommitties);
			this.gbties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbties.Dock")));
			this.gbties.Enabled = ((bool)(resources.GetObject("gbties.Enabled")));
			this.gbties.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbties.Font = ((System.Drawing.Font)(resources.GetObject("gbties.Font")));
			this.gbties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbties.ImeMode")));
			this.gbties.Location = ((System.Drawing.Point)(resources.GetObject("gbties.Location")));
			this.gbties.Name = "gbties";
			this.gbties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbties.RightToLeft")));
			this.gbties.Size = ((System.Drawing.Size)(resources.GetObject("gbties.Size")));
			this.gbties.TabIndex = ((int)(resources.GetObject("gbties.TabIndex")));
			this.gbties.TabStop = false;
			this.gbties.Text = resources.GetString("gbties.Text");
			this.toolTip1.SetToolTip(this.gbties, resources.GetString("gbties.ToolTip"));
			this.gbties.Visible = ((bool)(resources.GetObject("gbties.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbties, true);
			// 
			// btnewtie
			// 
			this.btnewtie.AccessibleDescription = resources.GetString("btnewtie.AccessibleDescription");
			this.btnewtie.AccessibleName = resources.GetString("btnewtie.AccessibleName");
			this.btnewtie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnewtie.Anchor")));
			this.btnewtie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnewtie.BackgroundImage")));
			this.btnewtie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnewtie.Dock")));
			this.btnewtie.Enabled = ((bool)(resources.GetObject("btnewtie.Enabled")));
			this.btnewtie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnewtie.FlatStyle")));
			this.btnewtie.Font = ((System.Drawing.Font)(resources.GetObject("btnewtie.Font")));
			this.btnewtie.Image = ((System.Drawing.Image)(resources.GetObject("btnewtie.Image")));
			this.btnewtie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnewtie.ImageAlign")));
			this.btnewtie.ImageIndex = ((int)(resources.GetObject("btnewtie.ImageIndex")));
			this.btnewtie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnewtie.ImeMode")));
			this.btnewtie.Location = ((System.Drawing.Point)(resources.GetObject("btnewtie.Location")));
			this.btnewtie.Name = "btnewtie";
			this.btnewtie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnewtie.RightToLeft")));
			this.btnewtie.Size = ((System.Drawing.Size)(resources.GetObject("btnewtie.Size")));
			this.btnewtie.TabIndex = ((int)(resources.GetObject("btnewtie.TabIndex")));
			this.btnewtie.Text = resources.GetString("btnewtie.Text");
			this.btnewtie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnewtie.TextAlign")));
			this.toolTip1.SetToolTip(this.btnewtie, resources.GetString("btnewtie.ToolTip"));
			this.btnewtie.Visible = ((bool)(resources.GetObject("btnewtie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btnewtie, true);
			this.btnewtie.Click += new System.EventHandler(this.AddSimToTiesClick);
			// 
			// cballtieablesims
			// 
			this.cballtieablesims.AccessibleDescription = resources.GetString("cballtieablesims.AccessibleDescription");
			this.cballtieablesims.AccessibleName = resources.GetString("cballtieablesims.AccessibleName");
			this.cballtieablesims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cballtieablesims.Anchor")));
			this.cballtieablesims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cballtieablesims.BackgroundImage")));
			this.cballtieablesims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cballtieablesims.Dock")));
			this.cballtieablesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cballtieablesims.Enabled = ((bool)(resources.GetObject("cballtieablesims.Enabled")));
			this.cballtieablesims.Font = ((System.Drawing.Font)(resources.GetObject("cballtieablesims.Font")));
			this.cballtieablesims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cballtieablesims.ImeMode")));
			this.cballtieablesims.IntegralHeight = ((bool)(resources.GetObject("cballtieablesims.IntegralHeight")));
			this.cballtieablesims.ItemHeight = ((int)(resources.GetObject("cballtieablesims.ItemHeight")));
			this.cballtieablesims.Location = ((System.Drawing.Point)(resources.GetObject("cballtieablesims.Location")));
			this.cballtieablesims.MaxDropDownItems = ((int)(resources.GetObject("cballtieablesims.MaxDropDownItems")));
			this.cballtieablesims.MaxLength = ((int)(resources.GetObject("cballtieablesims.MaxLength")));
			this.cballtieablesims.Name = "cballtieablesims";
			this.cballtieablesims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cballtieablesims.RightToLeft")));
			this.cballtieablesims.Size = ((System.Drawing.Size)(resources.GetObject("cballtieablesims.Size")));
			this.cballtieablesims.TabIndex = ((int)(resources.GetObject("cballtieablesims.TabIndex")));
			this.cballtieablesims.Text = resources.GetString("cballtieablesims.Text");
			this.toolTip1.SetToolTip(this.cballtieablesims, resources.GetString("cballtieablesims.ToolTip"));
			this.cballtieablesims.Visible = ((bool)(resources.GetObject("cballtieablesims.Visible")));
			this.cballtieablesims.SelectedIndexChanged += new System.EventHandler(this.AllTieableSimsIndexChanged);
			// 
			// cbtietype
			// 
			this.cbtietype.AccessibleDescription = resources.GetString("cbtietype.AccessibleDescription");
			this.cbtietype.AccessibleName = resources.GetString("cbtietype.AccessibleName");
			this.cbtietype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtietype.Anchor")));
			this.cbtietype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtietype.BackgroundImage")));
			this.cbtietype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtietype.Dock")));
			this.cbtietype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtietype.Enabled = ((bool)(resources.GetObject("cbtietype.Enabled")));
			this.cbtietype.Font = ((System.Drawing.Font)(resources.GetObject("cbtietype.Font")));
			this.cbtietype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtietype.ImeMode")));
			this.cbtietype.IntegralHeight = ((bool)(resources.GetObject("cbtietype.IntegralHeight")));
			this.cbtietype.ItemHeight = ((int)(resources.GetObject("cbtietype.ItemHeight")));
			this.cbtietype.Location = ((System.Drawing.Point)(resources.GetObject("cbtietype.Location")));
			this.cbtietype.MaxDropDownItems = ((int)(resources.GetObject("cbtietype.MaxDropDownItems")));
			this.cbtietype.MaxLength = ((int)(resources.GetObject("cbtietype.MaxLength")));
			this.cbtietype.Name = "cbtietype";
			this.cbtietype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtietype.RightToLeft")));
			this.cbtietype.Size = ((System.Drawing.Size)(resources.GetObject("cbtietype.Size")));
			this.cbtietype.TabIndex = ((int)(resources.GetObject("cbtietype.TabIndex")));
			this.cbtietype.Text = resources.GetString("cbtietype.Text");
			this.toolTip1.SetToolTip(this.cbtietype, resources.GetString("cbtietype.ToolTip"));
			this.cbtietype.Visible = ((bool)(resources.GetObject("cbtietype.Visible")));
			// 
			// lbties
			// 
			this.lbties.AccessibleDescription = resources.GetString("lbties.AccessibleDescription");
			this.lbties.AccessibleName = resources.GetString("lbties.AccessibleName");
			this.lbties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbties.Anchor")));
			this.lbties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbties.BackgroundImage")));
			this.lbties.ColumnWidth = ((int)(resources.GetObject("lbties.ColumnWidth")));
			this.lbties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbties.Dock")));
			this.lbties.Enabled = ((bool)(resources.GetObject("lbties.Enabled")));
			this.lbties.Font = ((System.Drawing.Font)(resources.GetObject("lbties.Font")));
			this.lbties.HorizontalExtent = ((int)(resources.GetObject("lbties.HorizontalExtent")));
			this.lbties.HorizontalScrollbar = ((bool)(resources.GetObject("lbties.HorizontalScrollbar")));
			this.lbties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbties.ImeMode")));
			this.lbties.IntegralHeight = ((bool)(resources.GetObject("lbties.IntegralHeight")));
			this.lbties.ItemHeight = ((int)(resources.GetObject("lbties.ItemHeight")));
			this.lbties.Location = ((System.Drawing.Point)(resources.GetObject("lbties.Location")));
			this.lbties.Name = "lbties";
			this.lbties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbties.RightToLeft")));
			this.lbties.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbties.ScrollAlwaysVisible")));
			this.lbties.Size = ((System.Drawing.Size)(resources.GetObject("lbties.Size")));
			this.lbties.TabIndex = ((int)(resources.GetObject("lbties.TabIndex")));
			this.toolTip1.SetToolTip(this.lbties, resources.GetString("lbties.ToolTip"));
			this.lbties.Visible = ((bool)(resources.GetObject("lbties.Visible")));
			this.lbties.SelectedIndexChanged += new System.EventHandler(this.TieIndexChanged);
			// 
			// btdeletetie
			// 
			this.btdeletetie.AccessibleDescription = resources.GetString("btdeletetie.AccessibleDescription");
			this.btdeletetie.AccessibleName = resources.GetString("btdeletetie.AccessibleName");
			this.btdeletetie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btdeletetie.Anchor")));
			this.btdeletetie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdeletetie.BackgroundImage")));
			this.btdeletetie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btdeletetie.Dock")));
			this.btdeletetie.Enabled = ((bool)(resources.GetObject("btdeletetie.Enabled")));
			this.btdeletetie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btdeletetie.FlatStyle")));
			this.btdeletetie.Font = ((System.Drawing.Font)(resources.GetObject("btdeletetie.Font")));
			this.btdeletetie.Image = ((System.Drawing.Image)(resources.GetObject("btdeletetie.Image")));
			this.btdeletetie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeletetie.ImageAlign")));
			this.btdeletetie.ImageIndex = ((int)(resources.GetObject("btdeletetie.ImageIndex")));
			this.btdeletetie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btdeletetie.ImeMode")));
			this.btdeletetie.Location = ((System.Drawing.Point)(resources.GetObject("btdeletetie.Location")));
			this.btdeletetie.Name = "btdeletetie";
			this.btdeletetie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btdeletetie.RightToLeft")));
			this.btdeletetie.Size = ((System.Drawing.Size)(resources.GetObject("btdeletetie.Size")));
			this.btdeletetie.TabIndex = ((int)(resources.GetObject("btdeletetie.TabIndex")));
			this.btdeletetie.Text = resources.GetString("btdeletetie.Text");
			this.btdeletetie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeletetie.TextAlign")));
			this.toolTip1.SetToolTip(this.btdeletetie, resources.GetString("btdeletetie.ToolTip"));
			this.btdeletetie.Visible = ((bool)(resources.GetObject("btdeletetie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btdeletetie, true);
			this.btdeletetie.Click += new System.EventHandler(this.DeleteTieClick);
			// 
			// btaddtie
			// 
			this.btaddtie.AccessibleDescription = resources.GetString("btaddtie.AccessibleDescription");
			this.btaddtie.AccessibleName = resources.GetString("btaddtie.AccessibleName");
			this.btaddtie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btaddtie.Anchor")));
			this.btaddtie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btaddtie.BackgroundImage")));
			this.btaddtie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btaddtie.Dock")));
			this.btaddtie.Enabled = ((bool)(resources.GetObject("btaddtie.Enabled")));
			this.btaddtie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btaddtie.FlatStyle")));
			this.btaddtie.Font = ((System.Drawing.Font)(resources.GetObject("btaddtie.Font")));
			this.btaddtie.Image = ((System.Drawing.Image)(resources.GetObject("btaddtie.Image")));
			this.btaddtie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddtie.ImageAlign")));
			this.btaddtie.ImageIndex = ((int)(resources.GetObject("btaddtie.ImageIndex")));
			this.btaddtie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btaddtie.ImeMode")));
			this.btaddtie.Location = ((System.Drawing.Point)(resources.GetObject("btaddtie.Location")));
			this.btaddtie.Name = "btaddtie";
			this.btaddtie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btaddtie.RightToLeft")));
			this.btaddtie.Size = ((System.Drawing.Size)(resources.GetObject("btaddtie.Size")));
			this.btaddtie.TabIndex = ((int)(resources.GetObject("btaddtie.TabIndex")));
			this.btaddtie.Text = resources.GetString("btaddtie.Text");
			this.btaddtie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddtie.TextAlign")));
			this.toolTip1.SetToolTip(this.btaddtie, resources.GetString("btaddtie.ToolTip"));
			this.btaddtie.Visible = ((bool)(resources.GetObject("btaddtie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btaddtie, true);
			this.btaddtie.Click += new System.EventHandler(this.AddTieClick);
			// 
			// llcommitties
			// 
			this.llcommitties.AccessibleDescription = resources.GetString("llcommitties.AccessibleDescription");
			this.llcommitties.AccessibleName = resources.GetString("llcommitties.AccessibleName");
			this.llcommitties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommitties.Anchor")));
			this.llcommitties.AutoSize = ((bool)(resources.GetObject("llcommitties.AutoSize")));
			this.llcommitties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommitties.Dock")));
			this.llcommitties.Enabled = ((bool)(resources.GetObject("llcommitties.Enabled")));
			this.llcommitties.Font = ((System.Drawing.Font)(resources.GetObject("llcommitties.Font")));
			this.llcommitties.Image = ((System.Drawing.Image)(resources.GetObject("llcommitties.Image")));
			this.llcommitties.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitties.ImageAlign")));
			this.llcommitties.ImageIndex = ((int)(resources.GetObject("llcommitties.ImageIndex")));
			this.llcommitties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommitties.ImeMode")));
			this.llcommitties.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommitties.LinkArea")));
			this.llcommitties.Location = ((System.Drawing.Point)(resources.GetObject("llcommitties.Location")));
			this.llcommitties.Name = "llcommitties";
			this.llcommitties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommitties.RightToLeft")));
			this.llcommitties.Size = ((System.Drawing.Size)(resources.GetObject("llcommitties.Size")));
			this.llcommitties.TabIndex = ((int)(resources.GetObject("llcommitties.TabIndex")));
			this.llcommitties.TabStop = true;
			this.llcommitties.Text = resources.GetString("llcommitties.Text");
			this.llcommitties.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitties.TextAlign")));
			this.toolTip1.SetToolTip(this.llcommitties, resources.GetString("llcommitties.ToolTip"));
			this.llcommitties.Visible = ((bool)(resources.GetObject("llcommitties.Visible")));
			this.llcommitties.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitSimTieClicked);
			// 
			// cbtiesims
			// 
			this.cbtiesims.AccessibleDescription = resources.GetString("cbtiesims.AccessibleDescription");
			this.cbtiesims.AccessibleName = resources.GetString("cbtiesims.AccessibleName");
			this.cbtiesims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtiesims.Anchor")));
			this.cbtiesims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtiesims.BackgroundImage")));
			this.cbtiesims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtiesims.Dock")));
			this.cbtiesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtiesims.Enabled = ((bool)(resources.GetObject("cbtiesims.Enabled")));
			this.cbtiesims.Font = ((System.Drawing.Font)(resources.GetObject("cbtiesims.Font")));
			this.cbtiesims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtiesims.ImeMode")));
			this.cbtiesims.IntegralHeight = ((bool)(resources.GetObject("cbtiesims.IntegralHeight")));
			this.cbtiesims.ItemHeight = ((int)(resources.GetObject("cbtiesims.ItemHeight")));
			this.cbtiesims.Location = ((System.Drawing.Point)(resources.GetObject("cbtiesims.Location")));
			this.cbtiesims.MaxDropDownItems = ((int)(resources.GetObject("cbtiesims.MaxDropDownItems")));
			this.cbtiesims.MaxLength = ((int)(resources.GetObject("cbtiesims.MaxLength")));
			this.cbtiesims.Name = "cbtiesims";
			this.cbtiesims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtiesims.RightToLeft")));
			this.cbtiesims.Size = ((System.Drawing.Size)(resources.GetObject("cbtiesims.Size")));
			this.cbtiesims.TabIndex = ((int)(resources.GetObject("cbtiesims.TabIndex")));
			this.cbtiesims.Text = resources.GetString("cbtiesims.Text");
			this.toolTip1.SetToolTip(this.cbtiesims, resources.GetString("cbtiesims.ToolTip"));
			this.cbtiesims.Visible = ((bool)(resources.GetObject("cbtiesims.Visible")));
			this.cbtiesims.SelectedIndexChanged += new System.EventHandler(this.FamilyTieSimIndexChanged);
			// 
			// bttiecommit
			// 
			this.bttiecommit.AccessibleDescription = resources.GetString("bttiecommit.AccessibleDescription");
			this.bttiecommit.AccessibleName = resources.GetString("bttiecommit.AccessibleName");
			this.bttiecommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bttiecommit.Anchor")));
			this.bttiecommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttiecommit.BackgroundImage")));
			this.bttiecommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bttiecommit.Dock")));
			this.bttiecommit.Enabled = ((bool)(resources.GetObject("bttiecommit.Enabled")));
			this.bttiecommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("bttiecommit.FlatStyle")));
			this.bttiecommit.Font = ((System.Drawing.Font)(resources.GetObject("bttiecommit.Font")));
			this.bttiecommit.Image = ((System.Drawing.Image)(resources.GetObject("bttiecommit.Image")));
			this.bttiecommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("bttiecommit.ImageAlign")));
			this.bttiecommit.ImageIndex = ((int)(resources.GetObject("bttiecommit.ImageIndex")));
			this.bttiecommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bttiecommit.ImeMode")));
			this.bttiecommit.Location = ((System.Drawing.Point)(resources.GetObject("bttiecommit.Location")));
			this.bttiecommit.Name = "bttiecommit";
			this.bttiecommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bttiecommit.RightToLeft")));
			this.bttiecommit.Size = ((System.Drawing.Size)(resources.GetObject("bttiecommit.Size")));
			this.bttiecommit.TabIndex = ((int)(resources.GetObject("bttiecommit.TabIndex")));
			this.bttiecommit.Text = resources.GetString("bttiecommit.Text");
			this.bttiecommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("bttiecommit.TextAlign")));
			this.toolTip1.SetToolTip(this.bttiecommit, resources.GetString("bttiecommit.ToolTip"));
			this.bttiecommit.Visible = ((bool)(resources.GetObject("bttiecommit.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.bttiecommit, true);
			this.bttiecommit.Click += new System.EventHandler(this.CommitTieClick);
			// 
			// label64
			// 
			this.label64.AccessibleDescription = resources.GetString("label64.AccessibleDescription");
			this.label64.AccessibleName = resources.GetString("label64.AccessibleName");
			this.label64.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label64.Anchor")));
			this.label64.AutoSize = ((bool)(resources.GetObject("label64.AutoSize")));
			this.label64.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label64.Dock")));
			this.label64.Enabled = ((bool)(resources.GetObject("label64.Enabled")));
			this.label64.Font = ((System.Drawing.Font)(resources.GetObject("label64.Font")));
			this.label64.Image = ((System.Drawing.Image)(resources.GetObject("label64.Image")));
			this.label64.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label64.ImageAlign")));
			this.label64.ImageIndex = ((int)(resources.GetObject("label64.ImageIndex")));
			this.label64.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label64.ImeMode")));
			this.label64.Location = ((System.Drawing.Point)(resources.GetObject("label64.Location")));
			this.label64.Name = "label64";
			this.label64.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label64.RightToLeft")));
			this.label64.Size = ((System.Drawing.Size)(resources.GetObject("label64.Size")));
			this.label64.TabIndex = ((int)(resources.GetObject("label64.TabIndex")));
			this.label64.Text = resources.GetString("label64.Text");
			this.label64.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label64.TextAlign")));
			this.toolTip1.SetToolTip(this.label64, resources.GetString("label64.ToolTip"));
			this.label64.Visible = ((bool)(resources.GetObject("label64.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label64, true);
			// 
			// panel8
			// 
			this.panel8.AccessibleDescription = resources.GetString("panel8.AccessibleDescription");
			this.panel8.AccessibleName = resources.GetString("panel8.AccessibleName");
			this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel8.Anchor")));
			this.panel8.AutoScroll = ((bool)(resources.GetObject("panel8.AutoScroll")));
			this.panel8.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel8.AutoScrollMargin")));
			this.panel8.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel8.AutoScrollMinSize")));
			this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
			this.panel8.Controls.Add(this.label68);
			this.panel8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel8.Dock")));
			this.panel8.Enabled = ((bool)(resources.GetObject("panel8.Enabled")));
			this.panel8.Font = ((System.Drawing.Font)(resources.GetObject("panel8.Font")));
			this.panel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel8.ImeMode")));
			this.panel8.Location = ((System.Drawing.Point)(resources.GetObject("panel8.Location")));
			this.panel8.Name = "panel8";
			this.panel8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel8.RightToLeft")));
			this.panel8.Size = ((System.Drawing.Size)(resources.GetObject("panel8.Size")));
			this.panel8.TabIndex = ((int)(resources.GetObject("panel8.TabIndex")));
			this.panel8.Text = resources.GetString("panel8.Text");
			this.toolTip1.SetToolTip(this.panel8, resources.GetString("panel8.ToolTip"));
			this.panel8.Visible = ((bool)(resources.GetObject("panel8.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel8, true);
			// 
			// label68
			// 
			this.label68.AccessibleDescription = resources.GetString("label68.AccessibleDescription");
			this.label68.AccessibleName = resources.GetString("label68.AccessibleName");
			this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label68.Anchor")));
			this.label68.AutoSize = ((bool)(resources.GetObject("label68.AutoSize")));
			this.label68.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label68.Dock")));
			this.label68.Enabled = ((bool)(resources.GetObject("label68.Enabled")));
			this.label68.Font = ((System.Drawing.Font)(resources.GetObject("label68.Font")));
			this.label68.Image = ((System.Drawing.Image)(resources.GetObject("label68.Image")));
			this.label68.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label68.ImageAlign")));
			this.label68.ImageIndex = ((int)(resources.GetObject("label68.ImageIndex")));
			this.label68.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label68.ImeMode")));
			this.label68.Location = ((System.Drawing.Point)(resources.GetObject("label68.Location")));
			this.label68.Name = "label68";
			this.label68.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label68.RightToLeft")));
			this.label68.Size = ((System.Drawing.Size)(resources.GetObject("label68.Size")));
			this.label68.TabIndex = ((int)(resources.GetObject("label68.TabIndex")));
			this.label68.Text = resources.GetString("label68.Text");
			this.label68.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label68.TextAlign")));
			this.toolTip1.SetToolTip(this.label68, resources.GetString("label68.ToolTip"));
			this.label68.Visible = ((bool)(resources.GetObject("label68.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label68, true);
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleDescription = resources.GetString("tabPage1.AccessibleDescription");
			this.tabPage1.AccessibleName = resources.GetString("tabPage1.AccessibleName");
			this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
			this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
			this.tabPage1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMargin")));
			this.tabPage1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMinSize")));
			this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
			this.tabPage1.Controls.Add(this.famiPanel);
			this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
			this.tabPage1.Enabled = ((bool)(resources.GetObject("tabPage1.Enabled")));
			this.tabPage1.Font = ((System.Drawing.Font)(resources.GetObject("tabPage1.Font")));
			this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
			this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
			this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
			this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
			this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
			this.tabPage1.Text = resources.GetString("tabPage1.Text");
			this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
			this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
			this.tabPage1.Visible = ((bool)(resources.GetObject("tabPage1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage1, true);
			// 
			// famiPanel
			// 
			this.famiPanel.AccessibleDescription = resources.GetString("famiPanel.AccessibleDescription");
			this.famiPanel.AccessibleName = resources.GetString("famiPanel.AccessibleName");
			this.famiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("famiPanel.Anchor")));
			this.famiPanel.AutoScroll = ((bool)(resources.GetObject("famiPanel.AutoScroll")));
			this.famiPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("famiPanel.AutoScrollMargin")));
			this.famiPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("famiPanel.AutoScrollMinSize")));
			this.famiPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("famiPanel.BackgroundImage")));
			this.famiPanel.Controls.Add(this.tbsubhood);
			this.famiPanel.Controls.Add(this.label89);
			this.famiPanel.Controls.Add(this.groupBox4);
			this.famiPanel.Controls.Add(this.tbalbum);
			this.famiPanel.Controls.Add(this.label93);
			this.famiPanel.Controls.Add(this.tbflag);
			this.famiPanel.Controls.Add(this.label92);
			this.famiPanel.Controls.Add(this.tblotinst);
			this.famiPanel.Controls.Add(this.llFamiDeleteSim);
			this.famiPanel.Controls.Add(this.llFamiAddSim);
			this.famiPanel.Controls.Add(this.button1);
			this.famiPanel.Controls.Add(this.cbsims);
			this.famiPanel.Controls.Add(this.lbmembers);
			this.famiPanel.Controls.Add(this.tbname);
			this.famiPanel.Controls.Add(this.label6);
			this.famiPanel.Controls.Add(this.tbfamily);
			this.famiPanel.Controls.Add(this.tbmoney);
			this.famiPanel.Controls.Add(this.label5);
			this.famiPanel.Controls.Add(this.label4);
			this.famiPanel.Controls.Add(this.label3);
			this.famiPanel.Controls.Add(this.panel4);
			this.famiPanel.Controls.Add(this.label15);
			this.famiPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("famiPanel.Dock")));
			this.famiPanel.Enabled = ((bool)(resources.GetObject("famiPanel.Enabled")));
			this.famiPanel.Font = ((System.Drawing.Font)(resources.GetObject("famiPanel.Font")));
			this.famiPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("famiPanel.ImeMode")));
			this.famiPanel.Location = ((System.Drawing.Point)(resources.GetObject("famiPanel.Location")));
			this.famiPanel.Name = "famiPanel";
			this.famiPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("famiPanel.RightToLeft")));
			this.famiPanel.Size = ((System.Drawing.Size)(resources.GetObject("famiPanel.Size")));
			this.famiPanel.TabIndex = ((int)(resources.GetObject("famiPanel.TabIndex")));
			this.famiPanel.Text = resources.GetString("famiPanel.Text");
			this.toolTip1.SetToolTip(this.famiPanel, resources.GetString("famiPanel.ToolTip"));
			this.famiPanel.Visible = ((bool)(resources.GetObject("famiPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.famiPanel, true);
			// 
			// tbsubhood
			// 
			this.tbsubhood.AccessibleDescription = resources.GetString("tbsubhood.AccessibleDescription");
			this.tbsubhood.AccessibleName = resources.GetString("tbsubhood.AccessibleName");
			this.tbsubhood.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsubhood.Anchor")));
			this.tbsubhood.AutoSize = ((bool)(resources.GetObject("tbsubhood.AutoSize")));
			this.tbsubhood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsubhood.BackgroundImage")));
			this.tbsubhood.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsubhood.Dock")));
			this.tbsubhood.Enabled = ((bool)(resources.GetObject("tbsubhood.Enabled")));
			this.tbsubhood.Font = ((System.Drawing.Font)(resources.GetObject("tbsubhood.Font")));
			this.tbsubhood.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsubhood.ImeMode")));
			this.tbsubhood.Location = ((System.Drawing.Point)(resources.GetObject("tbsubhood.Location")));
			this.tbsubhood.MaxLength = ((int)(resources.GetObject("tbsubhood.MaxLength")));
			this.tbsubhood.Multiline = ((bool)(resources.GetObject("tbsubhood.Multiline")));
			this.tbsubhood.Name = "tbsubhood";
			this.tbsubhood.PasswordChar = ((char)(resources.GetObject("tbsubhood.PasswordChar")));
			this.tbsubhood.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsubhood.RightToLeft")));
			this.tbsubhood.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsubhood.ScrollBars")));
			this.tbsubhood.Size = ((System.Drawing.Size)(resources.GetObject("tbsubhood.Size")));
			this.tbsubhood.TabIndex = ((int)(resources.GetObject("tbsubhood.TabIndex")));
			this.tbsubhood.Text = resources.GetString("tbsubhood.Text");
			this.tbsubhood.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsubhood.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsubhood, resources.GetString("tbsubhood.ToolTip"));
			this.tbsubhood.Visible = ((bool)(resources.GetObject("tbsubhood.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsubhood, true);
			this.tbsubhood.WordWrap = ((bool)(resources.GetObject("tbsubhood.WordWrap")));
			// 
			// label89
			// 
			this.label89.AccessibleDescription = resources.GetString("label89.AccessibleDescription");
			this.label89.AccessibleName = resources.GetString("label89.AccessibleName");
			this.label89.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label89.Anchor")));
			this.label89.AutoSize = ((bool)(resources.GetObject("label89.AutoSize")));
			this.label89.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label89.Dock")));
			this.label89.Enabled = ((bool)(resources.GetObject("label89.Enabled")));
			this.label89.Font = ((System.Drawing.Font)(resources.GetObject("label89.Font")));
			this.label89.Image = ((System.Drawing.Image)(resources.GetObject("label89.Image")));
			this.label89.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label89.ImageAlign")));
			this.label89.ImageIndex = ((int)(resources.GetObject("label89.ImageIndex")));
			this.label89.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label89.ImeMode")));
			this.label89.Location = ((System.Drawing.Point)(resources.GetObject("label89.Location")));
			this.label89.Name = "label89";
			this.label89.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label89.RightToLeft")));
			this.label89.Size = ((System.Drawing.Size)(resources.GetObject("label89.Size")));
			this.label89.TabIndex = ((int)(resources.GetObject("label89.TabIndex")));
			this.label89.Text = resources.GetString("label89.Text");
			this.label89.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label89.TextAlign")));
			this.toolTip1.SetToolTip(this.label89, resources.GetString("label89.ToolTip"));
			this.label89.Visible = ((bool)(resources.GetObject("label89.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label89, true);
			// 
			// groupBox4
			// 
			this.groupBox4.AccessibleDescription = resources.GetString("groupBox4.AccessibleDescription");
			this.groupBox4.AccessibleName = resources.GetString("groupBox4.AccessibleName");
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox4.Anchor")));
			this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
			this.groupBox4.Controls.Add(this.cbcomputer);
			this.groupBox4.Controls.Add(this.cblot);
			this.groupBox4.Controls.Add(this.cbbaby);
			this.groupBox4.Controls.Add(this.cbphone);
			this.groupBox4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox4.Dock")));
			this.groupBox4.Enabled = ((bool)(resources.GetObject("groupBox4.Enabled")));
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Font = ((System.Drawing.Font)(resources.GetObject("groupBox4.Font")));
			this.groupBox4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox4.ImeMode")));
			this.groupBox4.Location = ((System.Drawing.Point)(resources.GetObject("groupBox4.Location")));
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox4.RightToLeft")));
			this.groupBox4.Size = ((System.Drawing.Size)(resources.GetObject("groupBox4.Size")));
			this.groupBox4.TabIndex = ((int)(resources.GetObject("groupBox4.TabIndex")));
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = resources.GetString("groupBox4.Text");
			this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
			this.groupBox4.Visible = ((bool)(resources.GetObject("groupBox4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox4, true);
			// 
			// cbcomputer
			// 
			this.cbcomputer.AccessibleDescription = resources.GetString("cbcomputer.AccessibleDescription");
			this.cbcomputer.AccessibleName = resources.GetString("cbcomputer.AccessibleName");
			this.cbcomputer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcomputer.Anchor")));
			this.cbcomputer.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcomputer.Appearance")));
			this.cbcomputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcomputer.BackgroundImage")));
			this.cbcomputer.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.CheckAlign")));
			this.cbcomputer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcomputer.Dock")));
			this.cbcomputer.Enabled = ((bool)(resources.GetObject("cbcomputer.Enabled")));
			this.cbcomputer.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcomputer.FlatStyle")));
			this.cbcomputer.Font = ((System.Drawing.Font)(resources.GetObject("cbcomputer.Font")));
			this.cbcomputer.Image = ((System.Drawing.Image)(resources.GetObject("cbcomputer.Image")));
			this.cbcomputer.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.ImageAlign")));
			this.cbcomputer.ImageIndex = ((int)(resources.GetObject("cbcomputer.ImageIndex")));
			this.cbcomputer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcomputer.ImeMode")));
			this.cbcomputer.Location = ((System.Drawing.Point)(resources.GetObject("cbcomputer.Location")));
			this.cbcomputer.Name = "cbcomputer";
			this.cbcomputer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcomputer.RightToLeft")));
			this.cbcomputer.Size = ((System.Drawing.Size)(resources.GetObject("cbcomputer.Size")));
			this.cbcomputer.TabIndex = ((int)(resources.GetObject("cbcomputer.TabIndex")));
			this.cbcomputer.Text = resources.GetString("cbcomputer.Text");
			this.cbcomputer.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.TextAlign")));
			this.toolTip1.SetToolTip(this.cbcomputer, resources.GetString("cbcomputer.ToolTip"));
			this.cbcomputer.Visible = ((bool)(resources.GetObject("cbcomputer.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbcomputer, true);
			this.cbcomputer.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cblot
			// 
			this.cblot.AccessibleDescription = resources.GetString("cblot.AccessibleDescription");
			this.cblot.AccessibleName = resources.GetString("cblot.AccessibleName");
			this.cblot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblot.Anchor")));
			this.cblot.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cblot.Appearance")));
			this.cblot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblot.BackgroundImage")));
			this.cblot.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.CheckAlign")));
			this.cblot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblot.Dock")));
			this.cblot.Enabled = ((bool)(resources.GetObject("cblot.Enabled")));
			this.cblot.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cblot.FlatStyle")));
			this.cblot.Font = ((System.Drawing.Font)(resources.GetObject("cblot.Font")));
			this.cblot.Image = ((System.Drawing.Image)(resources.GetObject("cblot.Image")));
			this.cblot.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.ImageAlign")));
			this.cblot.ImageIndex = ((int)(resources.GetObject("cblot.ImageIndex")));
			this.cblot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblot.ImeMode")));
			this.cblot.Location = ((System.Drawing.Point)(resources.GetObject("cblot.Location")));
			this.cblot.Name = "cblot";
			this.cblot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblot.RightToLeft")));
			this.cblot.Size = ((System.Drawing.Size)(resources.GetObject("cblot.Size")));
			this.cblot.TabIndex = ((int)(resources.GetObject("cblot.TabIndex")));
			this.cblot.Text = resources.GetString("cblot.Text");
			this.cblot.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.TextAlign")));
			this.toolTip1.SetToolTip(this.cblot, resources.GetString("cblot.ToolTip"));
			this.cblot.Visible = ((bool)(resources.GetObject("cblot.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cblot, true);
			this.cblot.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cbbaby
			// 
			this.cbbaby.AccessibleDescription = resources.GetString("cbbaby.AccessibleDescription");
			this.cbbaby.AccessibleName = resources.GetString("cbbaby.AccessibleName");
			this.cbbaby.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbaby.Anchor")));
			this.cbbaby.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbaby.Appearance")));
			this.cbbaby.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbaby.BackgroundImage")));
			this.cbbaby.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.CheckAlign")));
			this.cbbaby.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbaby.Dock")));
			this.cbbaby.Enabled = ((bool)(resources.GetObject("cbbaby.Enabled")));
			this.cbbaby.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbaby.FlatStyle")));
			this.cbbaby.Font = ((System.Drawing.Font)(resources.GetObject("cbbaby.Font")));
			this.cbbaby.Image = ((System.Drawing.Image)(resources.GetObject("cbbaby.Image")));
			this.cbbaby.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.ImageAlign")));
			this.cbbaby.ImageIndex = ((int)(resources.GetObject("cbbaby.ImageIndex")));
			this.cbbaby.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbaby.ImeMode")));
			this.cbbaby.Location = ((System.Drawing.Point)(resources.GetObject("cbbaby.Location")));
			this.cbbaby.Name = "cbbaby";
			this.cbbaby.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbaby.RightToLeft")));
			this.cbbaby.Size = ((System.Drawing.Size)(resources.GetObject("cbbaby.Size")));
			this.cbbaby.TabIndex = ((int)(resources.GetObject("cbbaby.TabIndex")));
			this.cbbaby.Text = resources.GetString("cbbaby.Text");
			this.cbbaby.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbaby, resources.GetString("cbbaby.ToolTip"));
			this.cbbaby.Visible = ((bool)(resources.GetObject("cbbaby.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbaby, true);
			this.cbbaby.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cbphone
			// 
			this.cbphone.AccessibleDescription = resources.GetString("cbphone.AccessibleDescription");
			this.cbphone.AccessibleName = resources.GetString("cbphone.AccessibleName");
			this.cbphone.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbphone.Anchor")));
			this.cbphone.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbphone.Appearance")));
			this.cbphone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbphone.BackgroundImage")));
			this.cbphone.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.CheckAlign")));
			this.cbphone.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbphone.Dock")));
			this.cbphone.Enabled = ((bool)(resources.GetObject("cbphone.Enabled")));
			this.cbphone.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbphone.FlatStyle")));
			this.cbphone.Font = ((System.Drawing.Font)(resources.GetObject("cbphone.Font")));
			this.cbphone.Image = ((System.Drawing.Image)(resources.GetObject("cbphone.Image")));
			this.cbphone.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.ImageAlign")));
			this.cbphone.ImageIndex = ((int)(resources.GetObject("cbphone.ImageIndex")));
			this.cbphone.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbphone.ImeMode")));
			this.cbphone.Location = ((System.Drawing.Point)(resources.GetObject("cbphone.Location")));
			this.cbphone.Name = "cbphone";
			this.cbphone.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbphone.RightToLeft")));
			this.cbphone.Size = ((System.Drawing.Size)(resources.GetObject("cbphone.Size")));
			this.cbphone.TabIndex = ((int)(resources.GetObject("cbphone.TabIndex")));
			this.cbphone.Text = resources.GetString("cbphone.Text");
			this.cbphone.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.TextAlign")));
			this.toolTip1.SetToolTip(this.cbphone, resources.GetString("cbphone.ToolTip"));
			this.cbphone.Visible = ((bool)(resources.GetObject("cbphone.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbphone, true);
			this.cbphone.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// tbalbum
			// 
			this.tbalbum.AccessibleDescription = resources.GetString("tbalbum.AccessibleDescription");
			this.tbalbum.AccessibleName = resources.GetString("tbalbum.AccessibleName");
			this.tbalbum.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbalbum.Anchor")));
			this.tbalbum.AutoSize = ((bool)(resources.GetObject("tbalbum.AutoSize")));
			this.tbalbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbalbum.BackgroundImage")));
			this.tbalbum.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbalbum.Dock")));
			this.tbalbum.Enabled = ((bool)(resources.GetObject("tbalbum.Enabled")));
			this.tbalbum.Font = ((System.Drawing.Font)(resources.GetObject("tbalbum.Font")));
			this.tbalbum.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbalbum.ImeMode")));
			this.tbalbum.Location = ((System.Drawing.Point)(resources.GetObject("tbalbum.Location")));
			this.tbalbum.MaxLength = ((int)(resources.GetObject("tbalbum.MaxLength")));
			this.tbalbum.Multiline = ((bool)(resources.GetObject("tbalbum.Multiline")));
			this.tbalbum.Name = "tbalbum";
			this.tbalbum.PasswordChar = ((char)(resources.GetObject("tbalbum.PasswordChar")));
			this.tbalbum.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbalbum.RightToLeft")));
			this.tbalbum.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbalbum.ScrollBars")));
			this.tbalbum.Size = ((System.Drawing.Size)(resources.GetObject("tbalbum.Size")));
			this.tbalbum.TabIndex = ((int)(resources.GetObject("tbalbum.TabIndex")));
			this.tbalbum.Text = resources.GetString("tbalbum.Text");
			this.tbalbum.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbalbum.TextAlign")));
			this.toolTip1.SetToolTip(this.tbalbum, resources.GetString("tbalbum.ToolTip"));
			this.tbalbum.Visible = ((bool)(resources.GetObject("tbalbum.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbalbum, true);
			this.tbalbum.WordWrap = ((bool)(resources.GetObject("tbalbum.WordWrap")));
			// 
			// label93
			// 
			this.label93.AccessibleDescription = resources.GetString("label93.AccessibleDescription");
			this.label93.AccessibleName = resources.GetString("label93.AccessibleName");
			this.label93.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label93.Anchor")));
			this.label93.AutoSize = ((bool)(resources.GetObject("label93.AutoSize")));
			this.label93.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label93.Dock")));
			this.label93.Enabled = ((bool)(resources.GetObject("label93.Enabled")));
			this.label93.Font = ((System.Drawing.Font)(resources.GetObject("label93.Font")));
			this.label93.Image = ((System.Drawing.Image)(resources.GetObject("label93.Image")));
			this.label93.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label93.ImageAlign")));
			this.label93.ImageIndex = ((int)(resources.GetObject("label93.ImageIndex")));
			this.label93.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label93.ImeMode")));
			this.label93.Location = ((System.Drawing.Point)(resources.GetObject("label93.Location")));
			this.label93.Name = "label93";
			this.label93.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label93.RightToLeft")));
			this.label93.Size = ((System.Drawing.Size)(resources.GetObject("label93.Size")));
			this.label93.TabIndex = ((int)(resources.GetObject("label93.TabIndex")));
			this.label93.Text = resources.GetString("label93.Text");
			this.label93.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label93.TextAlign")));
			this.toolTip1.SetToolTip(this.label93, resources.GetString("label93.ToolTip"));
			this.label93.Visible = ((bool)(resources.GetObject("label93.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label93, true);
			// 
			// tbflag
			// 
			this.tbflag.AccessibleDescription = resources.GetString("tbflag.AccessibleDescription");
			this.tbflag.AccessibleName = resources.GetString("tbflag.AccessibleName");
			this.tbflag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbflag.Anchor")));
			this.tbflag.AutoSize = ((bool)(resources.GetObject("tbflag.AutoSize")));
			this.tbflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbflag.BackgroundImage")));
			this.tbflag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbflag.Dock")));
			this.tbflag.Enabled = ((bool)(resources.GetObject("tbflag.Enabled")));
			this.tbflag.Font = ((System.Drawing.Font)(resources.GetObject("tbflag.Font")));
			this.tbflag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbflag.ImeMode")));
			this.tbflag.Location = ((System.Drawing.Point)(resources.GetObject("tbflag.Location")));
			this.tbflag.MaxLength = ((int)(resources.GetObject("tbflag.MaxLength")));
			this.tbflag.Multiline = ((bool)(resources.GetObject("tbflag.Multiline")));
			this.tbflag.Name = "tbflag";
			this.tbflag.PasswordChar = ((char)(resources.GetObject("tbflag.PasswordChar")));
			this.tbflag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbflag.RightToLeft")));
			this.tbflag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbflag.ScrollBars")));
			this.tbflag.Size = ((System.Drawing.Size)(resources.GetObject("tbflag.Size")));
			this.tbflag.TabIndex = ((int)(resources.GetObject("tbflag.TabIndex")));
			this.tbflag.Text = resources.GetString("tbflag.Text");
			this.tbflag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbflag.TextAlign")));
			this.toolTip1.SetToolTip(this.tbflag, resources.GetString("tbflag.ToolTip"));
			this.tbflag.Visible = ((bool)(resources.GetObject("tbflag.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbflag, true);
			this.tbflag.WordWrap = ((bool)(resources.GetObject("tbflag.WordWrap")));
			this.tbflag.TextChanged += new System.EventHandler(this.FlagChanged);
			// 
			// label92
			// 
			this.label92.AccessibleDescription = resources.GetString("label92.AccessibleDescription");
			this.label92.AccessibleName = resources.GetString("label92.AccessibleName");
			this.label92.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label92.Anchor")));
			this.label92.AutoSize = ((bool)(resources.GetObject("label92.AutoSize")));
			this.label92.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label92.Dock")));
			this.label92.Enabled = ((bool)(resources.GetObject("label92.Enabled")));
			this.label92.Font = ((System.Drawing.Font)(resources.GetObject("label92.Font")));
			this.label92.Image = ((System.Drawing.Image)(resources.GetObject("label92.Image")));
			this.label92.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label92.ImageAlign")));
			this.label92.ImageIndex = ((int)(resources.GetObject("label92.ImageIndex")));
			this.label92.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label92.ImeMode")));
			this.label92.Location = ((System.Drawing.Point)(resources.GetObject("label92.Location")));
			this.label92.Name = "label92";
			this.label92.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label92.RightToLeft")));
			this.label92.Size = ((System.Drawing.Size)(resources.GetObject("label92.Size")));
			this.label92.TabIndex = ((int)(resources.GetObject("label92.TabIndex")));
			this.label92.Text = resources.GetString("label92.Text");
			this.label92.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label92.TextAlign")));
			this.toolTip1.SetToolTip(this.label92, resources.GetString("label92.ToolTip"));
			this.label92.Visible = ((bool)(resources.GetObject("label92.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label92, true);
			// 
			// tblotinst
			// 
			this.tblotinst.AccessibleDescription = resources.GetString("tblotinst.AccessibleDescription");
			this.tblotinst.AccessibleName = resources.GetString("tblotinst.AccessibleName");
			this.tblotinst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblotinst.Anchor")));
			this.tblotinst.AutoSize = ((bool)(resources.GetObject("tblotinst.AutoSize")));
			this.tblotinst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblotinst.BackgroundImage")));
			this.tblotinst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblotinst.Dock")));
			this.tblotinst.Enabled = ((bool)(resources.GetObject("tblotinst.Enabled")));
			this.tblotinst.Font = ((System.Drawing.Font)(resources.GetObject("tblotinst.Font")));
			this.tblotinst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblotinst.ImeMode")));
			this.tblotinst.Location = ((System.Drawing.Point)(resources.GetObject("tblotinst.Location")));
			this.tblotinst.MaxLength = ((int)(resources.GetObject("tblotinst.MaxLength")));
			this.tblotinst.Multiline = ((bool)(resources.GetObject("tblotinst.Multiline")));
			this.tblotinst.Name = "tblotinst";
			this.tblotinst.PasswordChar = ((char)(resources.GetObject("tblotinst.PasswordChar")));
			this.tblotinst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblotinst.RightToLeft")));
			this.tblotinst.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblotinst.ScrollBars")));
			this.tblotinst.Size = ((System.Drawing.Size)(resources.GetObject("tblotinst.Size")));
			this.tblotinst.TabIndex = ((int)(resources.GetObject("tblotinst.TabIndex")));
			this.tblotinst.Text = resources.GetString("tblotinst.Text");
			this.tblotinst.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblotinst.TextAlign")));
			this.toolTip1.SetToolTip(this.tblotinst, resources.GetString("tblotinst.ToolTip"));
			this.tblotinst.Visible = ((bool)(resources.GetObject("tblotinst.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblotinst, true);
			this.tblotinst.WordWrap = ((bool)(resources.GetObject("tblotinst.WordWrap")));
			// 
			// llFamiDeleteSim
			// 
			this.llFamiDeleteSim.AccessibleDescription = resources.GetString("llFamiDeleteSim.AccessibleDescription");
			this.llFamiDeleteSim.AccessibleName = resources.GetString("llFamiDeleteSim.AccessibleName");
			this.llFamiDeleteSim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llFamiDeleteSim.Anchor")));
			this.llFamiDeleteSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("llFamiDeleteSim.BackgroundImage")));
			this.llFamiDeleteSim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llFamiDeleteSim.Dock")));
			this.llFamiDeleteSim.Enabled = ((bool)(resources.GetObject("llFamiDeleteSim.Enabled")));
			this.llFamiDeleteSim.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("llFamiDeleteSim.FlatStyle")));
			this.llFamiDeleteSim.Font = ((System.Drawing.Font)(resources.GetObject("llFamiDeleteSim.Font")));
			this.llFamiDeleteSim.Image = ((System.Drawing.Image)(resources.GetObject("llFamiDeleteSim.Image")));
			this.llFamiDeleteSim.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiDeleteSim.ImageAlign")));
			this.llFamiDeleteSim.ImageIndex = ((int)(resources.GetObject("llFamiDeleteSim.ImageIndex")));
			this.llFamiDeleteSim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llFamiDeleteSim.ImeMode")));
			this.llFamiDeleteSim.Location = ((System.Drawing.Point)(resources.GetObject("llFamiDeleteSim.Location")));
			this.llFamiDeleteSim.Name = "llFamiDeleteSim";
			this.llFamiDeleteSim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llFamiDeleteSim.RightToLeft")));
			this.llFamiDeleteSim.Size = ((System.Drawing.Size)(resources.GetObject("llFamiDeleteSim.Size")));
			this.llFamiDeleteSim.TabIndex = ((int)(resources.GetObject("llFamiDeleteSim.TabIndex")));
			this.llFamiDeleteSim.Text = resources.GetString("llFamiDeleteSim.Text");
			this.llFamiDeleteSim.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiDeleteSim.TextAlign")));
			this.toolTip1.SetToolTip(this.llFamiDeleteSim, resources.GetString("llFamiDeleteSim.ToolTip"));
			this.llFamiDeleteSim.Visible = ((bool)(resources.GetObject("llFamiDeleteSim.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.llFamiDeleteSim, true);
			this.llFamiDeleteSim.Click += new System.EventHandler(this.FamiDeleteSimClick);
			// 
			// llFamiAddSim
			// 
			this.llFamiAddSim.AccessibleDescription = resources.GetString("llFamiAddSim.AccessibleDescription");
			this.llFamiAddSim.AccessibleName = resources.GetString("llFamiAddSim.AccessibleName");
			this.llFamiAddSim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llFamiAddSim.Anchor")));
			this.llFamiAddSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("llFamiAddSim.BackgroundImage")));
			this.llFamiAddSim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llFamiAddSim.Dock")));
			this.llFamiAddSim.Enabled = ((bool)(resources.GetObject("llFamiAddSim.Enabled")));
			this.llFamiAddSim.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("llFamiAddSim.FlatStyle")));
			this.llFamiAddSim.Font = ((System.Drawing.Font)(resources.GetObject("llFamiAddSim.Font")));
			this.llFamiAddSim.Image = ((System.Drawing.Image)(resources.GetObject("llFamiAddSim.Image")));
			this.llFamiAddSim.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiAddSim.ImageAlign")));
			this.llFamiAddSim.ImageIndex = ((int)(resources.GetObject("llFamiAddSim.ImageIndex")));
			this.llFamiAddSim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llFamiAddSim.ImeMode")));
			this.llFamiAddSim.Location = ((System.Drawing.Point)(resources.GetObject("llFamiAddSim.Location")));
			this.llFamiAddSim.Name = "llFamiAddSim";
			this.llFamiAddSim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llFamiAddSim.RightToLeft")));
			this.llFamiAddSim.Size = ((System.Drawing.Size)(resources.GetObject("llFamiAddSim.Size")));
			this.llFamiAddSim.TabIndex = ((int)(resources.GetObject("llFamiAddSim.TabIndex")));
			this.llFamiAddSim.Text = resources.GetString("llFamiAddSim.Text");
			this.llFamiAddSim.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiAddSim.TextAlign")));
			this.toolTip1.SetToolTip(this.llFamiAddSim, resources.GetString("llFamiAddSim.ToolTip"));
			this.llFamiAddSim.Visible = ((bool)(resources.GetObject("llFamiAddSim.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.llFamiAddSim, true);
			this.llFamiAddSim.Click += new System.EventHandler(this.FamiSimAddClick);
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
			this.visualStyleProvider1.SetVisualStyleSupport(this.button1, true);
			this.button1.Click += new System.EventHandler(this.CommitFamiClick);
			// 
			// cbsims
			// 
			this.cbsims.AccessibleDescription = resources.GetString("cbsims.AccessibleDescription");
			this.cbsims.AccessibleName = resources.GetString("cbsims.AccessibleName");
			this.cbsims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsims.Anchor")));
			this.cbsims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsims.BackgroundImage")));
			this.cbsims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsims.Dock")));
			this.cbsims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsims.Enabled = ((bool)(resources.GetObject("cbsims.Enabled")));
			this.cbsims.Font = ((System.Drawing.Font)(resources.GetObject("cbsims.Font")));
			this.cbsims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsims.ImeMode")));
			this.cbsims.IntegralHeight = ((bool)(resources.GetObject("cbsims.IntegralHeight")));
			this.cbsims.ItemHeight = ((int)(resources.GetObject("cbsims.ItemHeight")));
			this.cbsims.Location = ((System.Drawing.Point)(resources.GetObject("cbsims.Location")));
			this.cbsims.MaxDropDownItems = ((int)(resources.GetObject("cbsims.MaxDropDownItems")));
			this.cbsims.MaxLength = ((int)(resources.GetObject("cbsims.MaxLength")));
			this.cbsims.Name = "cbsims";
			this.cbsims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsims.RightToLeft")));
			this.cbsims.Size = ((System.Drawing.Size)(resources.GetObject("cbsims.Size")));
			this.cbsims.TabIndex = ((int)(resources.GetObject("cbsims.TabIndex")));
			this.cbsims.Text = resources.GetString("cbsims.Text");
			this.toolTip1.SetToolTip(this.cbsims, resources.GetString("cbsims.ToolTip"));
			this.cbsims.Visible = ((bool)(resources.GetObject("cbsims.Visible")));
			this.cbsims.SelectedIndexChanged += new System.EventHandler(this.SimSelectionChange);
			// 
			// lbmembers
			// 
			this.lbmembers.AccessibleDescription = resources.GetString("lbmembers.AccessibleDescription");
			this.lbmembers.AccessibleName = resources.GetString("lbmembers.AccessibleName");
			this.lbmembers.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbmembers.Anchor")));
			this.lbmembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbmembers.BackgroundImage")));
			this.lbmembers.ColumnWidth = ((int)(resources.GetObject("lbmembers.ColumnWidth")));
			this.lbmembers.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbmembers.Dock")));
			this.lbmembers.Enabled = ((bool)(resources.GetObject("lbmembers.Enabled")));
			this.lbmembers.Font = ((System.Drawing.Font)(resources.GetObject("lbmembers.Font")));
			this.lbmembers.HorizontalExtent = ((int)(resources.GetObject("lbmembers.HorizontalExtent")));
			this.lbmembers.HorizontalScrollbar = ((bool)(resources.GetObject("lbmembers.HorizontalScrollbar")));
			this.lbmembers.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbmembers.ImeMode")));
			this.lbmembers.IntegralHeight = ((bool)(resources.GetObject("lbmembers.IntegralHeight")));
			this.lbmembers.ItemHeight = ((int)(resources.GetObject("lbmembers.ItemHeight")));
			this.lbmembers.Location = ((System.Drawing.Point)(resources.GetObject("lbmembers.Location")));
			this.lbmembers.Name = "lbmembers";
			this.lbmembers.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbmembers.RightToLeft")));
			this.lbmembers.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbmembers.ScrollAlwaysVisible")));
			this.lbmembers.Size = ((System.Drawing.Size)(resources.GetObject("lbmembers.Size")));
			this.lbmembers.TabIndex = ((int)(resources.GetObject("lbmembers.TabIndex")));
			this.toolTip1.SetToolTip(this.lbmembers, resources.GetString("lbmembers.ToolTip"));
			this.lbmembers.Visible = ((bool)(resources.GetObject("lbmembers.Visible")));
			this.lbmembers.SelectedIndexChanged += new System.EventHandler(this.FamiMemberSelectionClick);
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
			this.toolTip1.SetToolTip(this.tbname, resources.GetString("tbname.ToolTip"));
			this.tbname.Visible = ((bool)(resources.GetObject("tbname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbname, true);
			this.tbname.WordWrap = ((bool)(resources.GetObject("tbname.WordWrap")));
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
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
			this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label6, true);
			// 
			// tbfamily
			// 
			this.tbfamily.AccessibleDescription = resources.GetString("tbfamily.AccessibleDescription");
			this.tbfamily.AccessibleName = resources.GetString("tbfamily.AccessibleName");
			this.tbfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfamily.Anchor")));
			this.tbfamily.AutoSize = ((bool)(resources.GetObject("tbfamily.AutoSize")));
			this.tbfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfamily.BackgroundImage")));
			this.tbfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfamily.Dock")));
			this.tbfamily.Enabled = ((bool)(resources.GetObject("tbfamily.Enabled")));
			this.tbfamily.Font = ((System.Drawing.Font)(resources.GetObject("tbfamily.Font")));
			this.tbfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfamily.ImeMode")));
			this.tbfamily.Location = ((System.Drawing.Point)(resources.GetObject("tbfamily.Location")));
			this.tbfamily.MaxLength = ((int)(resources.GetObject("tbfamily.MaxLength")));
			this.tbfamily.Multiline = ((bool)(resources.GetObject("tbfamily.Multiline")));
			this.tbfamily.Name = "tbfamily";
			this.tbfamily.PasswordChar = ((char)(resources.GetObject("tbfamily.PasswordChar")));
			this.tbfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfamily.RightToLeft")));
			this.tbfamily.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfamily.ScrollBars")));
			this.tbfamily.Size = ((System.Drawing.Size)(resources.GetObject("tbfamily.Size")));
			this.tbfamily.TabIndex = ((int)(resources.GetObject("tbfamily.TabIndex")));
			this.tbfamily.Text = resources.GetString("tbfamily.Text");
			this.tbfamily.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfamily, resources.GetString("tbfamily.ToolTip"));
			this.tbfamily.Visible = ((bool)(resources.GetObject("tbfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfamily, true);
			this.tbfamily.WordWrap = ((bool)(resources.GetObject("tbfamily.WordWrap")));
			// 
			// tbmoney
			// 
			this.tbmoney.AccessibleDescription = resources.GetString("tbmoney.AccessibleDescription");
			this.tbmoney.AccessibleName = resources.GetString("tbmoney.AccessibleName");
			this.tbmoney.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmoney.Anchor")));
			this.tbmoney.AutoSize = ((bool)(resources.GetObject("tbmoney.AutoSize")));
			this.tbmoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmoney.BackgroundImage")));
			this.tbmoney.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmoney.Dock")));
			this.tbmoney.Enabled = ((bool)(resources.GetObject("tbmoney.Enabled")));
			this.tbmoney.Font = ((System.Drawing.Font)(resources.GetObject("tbmoney.Font")));
			this.tbmoney.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmoney.ImeMode")));
			this.tbmoney.Location = ((System.Drawing.Point)(resources.GetObject("tbmoney.Location")));
			this.tbmoney.MaxLength = ((int)(resources.GetObject("tbmoney.MaxLength")));
			this.tbmoney.Multiline = ((bool)(resources.GetObject("tbmoney.Multiline")));
			this.tbmoney.Name = "tbmoney";
			this.tbmoney.PasswordChar = ((char)(resources.GetObject("tbmoney.PasswordChar")));
			this.tbmoney.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmoney.RightToLeft")));
			this.tbmoney.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmoney.ScrollBars")));
			this.tbmoney.Size = ((System.Drawing.Size)(resources.GetObject("tbmoney.Size")));
			this.tbmoney.TabIndex = ((int)(resources.GetObject("tbmoney.TabIndex")));
			this.tbmoney.Text = resources.GetString("tbmoney.Text");
			this.tbmoney.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmoney.TextAlign")));
			this.toolTip1.SetToolTip(this.tbmoney, resources.GetString("tbmoney.ToolTip"));
			this.tbmoney.Visible = ((bool)(resources.GetObject("tbmoney.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbmoney, true);
			this.tbmoney.WordWrap = ((bool)(resources.GetObject("tbmoney.WordWrap")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
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
			this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label5, true);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
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
			this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label4, true);
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
			this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label3, true);
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
			this.panel4.Controls.Add(this.label2);
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
			this.toolTip1.SetToolTip(this.panel4, resources.GetString("panel4.ToolTip"));
			this.panel4.Visible = ((bool)(resources.GetObject("panel4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel4, true);
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
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label2, true);
			// 
			// label15
			// 
			this.label15.AccessibleDescription = resources.GetString("label15.AccessibleDescription");
			this.label15.AccessibleName = resources.GetString("label15.AccessibleName");
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label15.Anchor")));
			this.label15.AutoSize = ((bool)(resources.GetObject("label15.AutoSize")));
			this.label15.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label15.Dock")));
			this.label15.Enabled = ((bool)(resources.GetObject("label15.Enabled")));
			this.label15.Font = ((System.Drawing.Font)(resources.GetObject("label15.Font")));
			this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
			this.label15.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label15.ImageAlign")));
			this.label15.ImageIndex = ((int)(resources.GetObject("label15.ImageIndex")));
			this.label15.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label15.ImeMode")));
			this.label15.Location = ((System.Drawing.Point)(resources.GetObject("label15.Location")));
			this.label15.Name = "label15";
			this.label15.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label15.RightToLeft")));
			this.label15.Size = ((System.Drawing.Size)(resources.GetObject("label15.Size")));
			this.label15.TabIndex = ((int)(resources.GetObject("label15.TabIndex")));
			this.label15.Text = resources.GetString("label15.Text");
			this.label15.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label15.TextAlign")));
			this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
			this.label15.Visible = ((bool)(resources.GetObject("label15.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label15, true);
			// 
			// tabPage3
			// 
			this.tabPage3.AccessibleDescription = resources.GetString("tabPage3.AccessibleDescription");
			this.tabPage3.AccessibleName = resources.GetString("tabPage3.AccessibleName");
			this.tabPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage3.Anchor")));
			this.tabPage3.AutoScroll = ((bool)(resources.GetObject("tabPage3.AutoScroll")));
			this.tabPage3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMargin")));
			this.tabPage3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMinSize")));
			this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
			this.tabPage3.Controls.Add(this.realPanel);
			this.tabPage3.Controls.Add(this.JpegPanel);
			this.tabPage3.Controls.Add(this.objdPanel);
			this.tabPage3.Controls.Add(this.xmlPanel);
			this.tabPage3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage3.Dock")));
			this.tabPage3.Enabled = ((bool)(resources.GetObject("tabPage3.Enabled")));
			this.tabPage3.Font = ((System.Drawing.Font)(resources.GetObject("tabPage3.Font")));
			this.tabPage3.ImageIndex = ((int)(resources.GetObject("tabPage3.ImageIndex")));
			this.tabPage3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage3.ImeMode")));
			this.tabPage3.Location = ((System.Drawing.Point)(resources.GetObject("tabPage3.Location")));
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage3.RightToLeft")));
			this.tabPage3.Size = ((System.Drawing.Size)(resources.GetObject("tabPage3.Size")));
			this.tabPage3.TabIndex = ((int)(resources.GetObject("tabPage3.TabIndex")));
			this.tabPage3.Text = resources.GetString("tabPage3.Text");
			this.toolTip1.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
			this.tabPage3.ToolTipText = resources.GetString("tabPage3.ToolTipText");
			this.tabPage3.Visible = ((bool)(resources.GetObject("tabPage3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage3, true);
			// 
			// realPanel
			// 
			this.realPanel.AccessibleDescription = resources.GetString("realPanel.AccessibleDescription");
			this.realPanel.AccessibleName = resources.GetString("realPanel.AccessibleName");
			this.realPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("realPanel.Anchor")));
			this.realPanel.AutoScroll = ((bool)(resources.GetObject("realPanel.AutoScroll")));
			this.realPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("realPanel.AutoScrollMargin")));
			this.realPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("realPanel.AutoScrollMinSize")));
			this.realPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("realPanel.BackgroundImage")));
			this.realPanel.Controls.Add(this.label91);
			this.realPanel.Controls.Add(this.cbfamtype);
			this.realPanel.Controls.Add(this.llsrelcommit);
			this.realPanel.Controls.Add(this.gbrelation);
			this.realPanel.Controls.Add(this.tblongterm);
			this.realPanel.Controls.Add(this.tbshortterm);
			this.realPanel.Controls.Add(this.label57);
			this.realPanel.Controls.Add(this.label58);
			this.realPanel.Controls.Add(this.panel7);
			this.realPanel.Controls.Add(this.llrelcommit);
			this.realPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("realPanel.Dock")));
			this.realPanel.Enabled = ((bool)(resources.GetObject("realPanel.Enabled")));
			this.realPanel.Font = ((System.Drawing.Font)(resources.GetObject("realPanel.Font")));
			this.realPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("realPanel.ImeMode")));
			this.realPanel.Location = ((System.Drawing.Point)(resources.GetObject("realPanel.Location")));
			this.realPanel.Name = "realPanel";
			this.realPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("realPanel.RightToLeft")));
			this.realPanel.Size = ((System.Drawing.Size)(resources.GetObject("realPanel.Size")));
			this.realPanel.TabIndex = ((int)(resources.GetObject("realPanel.TabIndex")));
			this.realPanel.Text = resources.GetString("realPanel.Text");
			this.toolTip1.SetToolTip(this.realPanel, resources.GetString("realPanel.ToolTip"));
			this.realPanel.Visible = ((bool)(resources.GetObject("realPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.realPanel, true);
			// 
			// label91
			// 
			this.label91.AccessibleDescription = resources.GetString("label91.AccessibleDescription");
			this.label91.AccessibleName = resources.GetString("label91.AccessibleName");
			this.label91.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label91.Anchor")));
			this.label91.AutoSize = ((bool)(resources.GetObject("label91.AutoSize")));
			this.label91.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label91.Dock")));
			this.label91.Enabled = ((bool)(resources.GetObject("label91.Enabled")));
			this.label91.Font = ((System.Drawing.Font)(resources.GetObject("label91.Font")));
			this.label91.Image = ((System.Drawing.Image)(resources.GetObject("label91.Image")));
			this.label91.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.ImageAlign")));
			this.label91.ImageIndex = ((int)(resources.GetObject("label91.ImageIndex")));
			this.label91.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label91.ImeMode")));
			this.label91.Location = ((System.Drawing.Point)(resources.GetObject("label91.Location")));
			this.label91.Name = "label91";
			this.label91.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label91.RightToLeft")));
			this.label91.Size = ((System.Drawing.Size)(resources.GetObject("label91.Size")));
			this.label91.TabIndex = ((int)(resources.GetObject("label91.TabIndex")));
			this.label91.Text = resources.GetString("label91.Text");
			this.label91.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.TextAlign")));
			this.toolTip1.SetToolTip(this.label91, resources.GetString("label91.ToolTip"));
			this.label91.Visible = ((bool)(resources.GetObject("label91.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label91, true);
			// 
			// cbfamtype
			// 
			this.cbfamtype.AccessibleDescription = resources.GetString("cbfamtype.AccessibleDescription");
			this.cbfamtype.AccessibleName = resources.GetString("cbfamtype.AccessibleName");
			this.cbfamtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamtype.Anchor")));
			this.cbfamtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamtype.BackgroundImage")));
			this.cbfamtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamtype.Dock")));
			this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbfamtype.Enabled = ((bool)(resources.GetObject("cbfamtype.Enabled")));
			this.cbfamtype.Font = ((System.Drawing.Font)(resources.GetObject("cbfamtype.Font")));
			this.cbfamtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamtype.ImeMode")));
			this.cbfamtype.IntegralHeight = ((bool)(resources.GetObject("cbfamtype.IntegralHeight")));
			this.cbfamtype.ItemHeight = ((int)(resources.GetObject("cbfamtype.ItemHeight")));
			this.cbfamtype.Location = ((System.Drawing.Point)(resources.GetObject("cbfamtype.Location")));
			this.cbfamtype.MaxDropDownItems = ((int)(resources.GetObject("cbfamtype.MaxDropDownItems")));
			this.cbfamtype.MaxLength = ((int)(resources.GetObject("cbfamtype.MaxLength")));
			this.cbfamtype.Name = "cbfamtype";
			this.cbfamtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamtype.RightToLeft")));
			this.cbfamtype.Size = ((System.Drawing.Size)(resources.GetObject("cbfamtype.Size")));
			this.cbfamtype.TabIndex = ((int)(resources.GetObject("cbfamtype.TabIndex")));
			this.cbfamtype.Text = resources.GetString("cbfamtype.Text");
			this.toolTip1.SetToolTip(this.cbfamtype, resources.GetString("cbfamtype.ToolTip"));
			this.cbfamtype.Visible = ((bool)(resources.GetObject("cbfamtype.Visible")));
			// 
			// llsrelcommit
			// 
			this.llsrelcommit.AccessibleDescription = resources.GetString("llsrelcommit.AccessibleDescription");
			this.llsrelcommit.AccessibleName = resources.GetString("llsrelcommit.AccessibleName");
			this.llsrelcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsrelcommit.Anchor")));
			this.llsrelcommit.AutoSize = ((bool)(resources.GetObject("llsrelcommit.AutoSize")));
			this.llsrelcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsrelcommit.Dock")));
			this.llsrelcommit.Enabled = ((bool)(resources.GetObject("llsrelcommit.Enabled")));
			this.llsrelcommit.Font = ((System.Drawing.Font)(resources.GetObject("llsrelcommit.Font")));
			this.llsrelcommit.Image = ((System.Drawing.Image)(resources.GetObject("llsrelcommit.Image")));
			this.llsrelcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsrelcommit.ImageAlign")));
			this.llsrelcommit.ImageIndex = ((int)(resources.GetObject("llsrelcommit.ImageIndex")));
			this.llsrelcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsrelcommit.ImeMode")));
			this.llsrelcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llsrelcommit.LinkArea")));
			this.llsrelcommit.Location = ((System.Drawing.Point)(resources.GetObject("llsrelcommit.Location")));
			this.llsrelcommit.Name = "llsrelcommit";
			this.llsrelcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsrelcommit.RightToLeft")));
			this.llsrelcommit.Size = ((System.Drawing.Size)(resources.GetObject("llsrelcommit.Size")));
			this.llsrelcommit.TabIndex = ((int)(resources.GetObject("llsrelcommit.TabIndex")));
			this.llsrelcommit.TabStop = true;
			this.llsrelcommit.Text = resources.GetString("llsrelcommit.Text");
			this.llsrelcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsrelcommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llsrelcommit, resources.GetString("llsrelcommit.ToolTip"));
			this.llsrelcommit.Visible = ((bool)(resources.GetObject("llsrelcommit.Visible")));
			this.llsrelcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RelationshipFileCommit);
			// 
			// gbrelation
			// 
			this.gbrelation.AccessibleDescription = resources.GetString("gbrelation.AccessibleDescription");
			this.gbrelation.AccessibleName = resources.GetString("gbrelation.AccessibleName");
			this.gbrelation.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbrelation.Anchor")));
			this.gbrelation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbrelation.BackgroundImage")));
			this.gbrelation.Controls.Add(this.cbbest);
			this.gbrelation.Controls.Add(this.cbfamily);
			this.gbrelation.Controls.Add(this.cbmarried);
			this.gbrelation.Controls.Add(this.cbengaged);
			this.gbrelation.Controls.Add(this.cbsteady);
			this.gbrelation.Controls.Add(this.cblove);
			this.gbrelation.Controls.Add(this.cbcrush);
			this.gbrelation.Controls.Add(this.cbbuddie);
			this.gbrelation.Controls.Add(this.cbfriend);
			this.gbrelation.Controls.Add(this.cbenemy);
			this.gbrelation.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbrelation.Dock")));
			this.gbrelation.Enabled = ((bool)(resources.GetObject("gbrelation.Enabled")));
			this.gbrelation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbrelation.Font = ((System.Drawing.Font)(resources.GetObject("gbrelation.Font")));
			this.gbrelation.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbrelation.ImeMode")));
			this.gbrelation.Location = ((System.Drawing.Point)(resources.GetObject("gbrelation.Location")));
			this.gbrelation.Name = "gbrelation";
			this.gbrelation.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbrelation.RightToLeft")));
			this.gbrelation.Size = ((System.Drawing.Size)(resources.GetObject("gbrelation.Size")));
			this.gbrelation.TabIndex = ((int)(resources.GetObject("gbrelation.TabIndex")));
			this.gbrelation.TabStop = false;
			this.gbrelation.Text = resources.GetString("gbrelation.Text");
			this.toolTip1.SetToolTip(this.gbrelation, resources.GetString("gbrelation.ToolTip"));
			this.gbrelation.Visible = ((bool)(resources.GetObject("gbrelation.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbrelation, true);
			// 
			// cbbest
			// 
			this.cbbest.AccessibleDescription = resources.GetString("cbbest.AccessibleDescription");
			this.cbbest.AccessibleName = resources.GetString("cbbest.AccessibleName");
			this.cbbest.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbest.Anchor")));
			this.cbbest.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbest.Appearance")));
			this.cbbest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbest.BackgroundImage")));
			this.cbbest.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.CheckAlign")));
			this.cbbest.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbest.Dock")));
			this.cbbest.Enabled = ((bool)(resources.GetObject("cbbest.Enabled")));
			this.cbbest.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbest.FlatStyle")));
			this.cbbest.Font = ((System.Drawing.Font)(resources.GetObject("cbbest.Font")));
			this.cbbest.Image = ((System.Drawing.Image)(resources.GetObject("cbbest.Image")));
			this.cbbest.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.ImageAlign")));
			this.cbbest.ImageIndex = ((int)(resources.GetObject("cbbest.ImageIndex")));
			this.cbbest.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbest.ImeMode")));
			this.cbbest.Location = ((System.Drawing.Point)(resources.GetObject("cbbest.Location")));
			this.cbbest.Name = "cbbest";
			this.cbbest.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbest.RightToLeft")));
			this.cbbest.Size = ((System.Drawing.Size)(resources.GetObject("cbbest.Size")));
			this.cbbest.TabIndex = ((int)(resources.GetObject("cbbest.TabIndex")));
			this.cbbest.Text = resources.GetString("cbbest.Text");
			this.cbbest.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbest, resources.GetString("cbbest.ToolTip"));
			this.cbbest.Visible = ((bool)(resources.GetObject("cbbest.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbest, true);
			// 
			// cbfamily
			// 
			this.cbfamily.AccessibleDescription = resources.GetString("cbfamily.AccessibleDescription");
			this.cbfamily.AccessibleName = resources.GetString("cbfamily.AccessibleName");
			this.cbfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamily.Anchor")));
			this.cbfamily.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfamily.Appearance")));
			this.cbfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamily.BackgroundImage")));
			this.cbfamily.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.CheckAlign")));
			this.cbfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamily.Dock")));
			this.cbfamily.Enabled = ((bool)(resources.GetObject("cbfamily.Enabled")));
			this.cbfamily.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfamily.FlatStyle")));
			this.cbfamily.Font = ((System.Drawing.Font)(resources.GetObject("cbfamily.Font")));
			this.cbfamily.Image = ((System.Drawing.Image)(resources.GetObject("cbfamily.Image")));
			this.cbfamily.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.ImageAlign")));
			this.cbfamily.ImageIndex = ((int)(resources.GetObject("cbfamily.ImageIndex")));
			this.cbfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamily.ImeMode")));
			this.cbfamily.Location = ((System.Drawing.Point)(resources.GetObject("cbfamily.Location")));
			this.cbfamily.Name = "cbfamily";
			this.cbfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamily.RightToLeft")));
			this.cbfamily.Size = ((System.Drawing.Size)(resources.GetObject("cbfamily.Size")));
			this.cbfamily.TabIndex = ((int)(resources.GetObject("cbfamily.TabIndex")));
			this.cbfamily.Text = resources.GetString("cbfamily.Text");
			this.cbfamily.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.cbfamily, resources.GetString("cbfamily.ToolTip"));
			this.cbfamily.Visible = ((bool)(resources.GetObject("cbfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfamily, true);
			// 
			// cbmarried
			// 
			this.cbmarried.AccessibleDescription = resources.GetString("cbmarried.AccessibleDescription");
			this.cbmarried.AccessibleName = resources.GetString("cbmarried.AccessibleName");
			this.cbmarried.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbmarried.Anchor")));
			this.cbmarried.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbmarried.Appearance")));
			this.cbmarried.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmarried.BackgroundImage")));
			this.cbmarried.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.CheckAlign")));
			this.cbmarried.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbmarried.Dock")));
			this.cbmarried.Enabled = ((bool)(resources.GetObject("cbmarried.Enabled")));
			this.cbmarried.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbmarried.FlatStyle")));
			this.cbmarried.Font = ((System.Drawing.Font)(resources.GetObject("cbmarried.Font")));
			this.cbmarried.Image = ((System.Drawing.Image)(resources.GetObject("cbmarried.Image")));
			this.cbmarried.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.ImageAlign")));
			this.cbmarried.ImageIndex = ((int)(resources.GetObject("cbmarried.ImageIndex")));
			this.cbmarried.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbmarried.ImeMode")));
			this.cbmarried.Location = ((System.Drawing.Point)(resources.GetObject("cbmarried.Location")));
			this.cbmarried.Name = "cbmarried";
			this.cbmarried.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbmarried.RightToLeft")));
			this.cbmarried.Size = ((System.Drawing.Size)(resources.GetObject("cbmarried.Size")));
			this.cbmarried.TabIndex = ((int)(resources.GetObject("cbmarried.TabIndex")));
			this.cbmarried.Text = resources.GetString("cbmarried.Text");
			this.cbmarried.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.TextAlign")));
			this.toolTip1.SetToolTip(this.cbmarried, resources.GetString("cbmarried.ToolTip"));
			this.cbmarried.Visible = ((bool)(resources.GetObject("cbmarried.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbmarried, true);
			// 
			// cbengaged
			// 
			this.cbengaged.AccessibleDescription = resources.GetString("cbengaged.AccessibleDescription");
			this.cbengaged.AccessibleName = resources.GetString("cbengaged.AccessibleName");
			this.cbengaged.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbengaged.Anchor")));
			this.cbengaged.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbengaged.Appearance")));
			this.cbengaged.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbengaged.BackgroundImage")));
			this.cbengaged.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.CheckAlign")));
			this.cbengaged.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbengaged.Dock")));
			this.cbengaged.Enabled = ((bool)(resources.GetObject("cbengaged.Enabled")));
			this.cbengaged.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbengaged.FlatStyle")));
			this.cbengaged.Font = ((System.Drawing.Font)(resources.GetObject("cbengaged.Font")));
			this.cbengaged.Image = ((System.Drawing.Image)(resources.GetObject("cbengaged.Image")));
			this.cbengaged.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.ImageAlign")));
			this.cbengaged.ImageIndex = ((int)(resources.GetObject("cbengaged.ImageIndex")));
			this.cbengaged.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbengaged.ImeMode")));
			this.cbengaged.Location = ((System.Drawing.Point)(resources.GetObject("cbengaged.Location")));
			this.cbengaged.Name = "cbengaged";
			this.cbengaged.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbengaged.RightToLeft")));
			this.cbengaged.Size = ((System.Drawing.Size)(resources.GetObject("cbengaged.Size")));
			this.cbengaged.TabIndex = ((int)(resources.GetObject("cbengaged.TabIndex")));
			this.cbengaged.Text = resources.GetString("cbengaged.Text");
			this.cbengaged.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.TextAlign")));
			this.toolTip1.SetToolTip(this.cbengaged, resources.GetString("cbengaged.ToolTip"));
			this.cbengaged.Visible = ((bool)(resources.GetObject("cbengaged.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbengaged, true);
			// 
			// cbsteady
			// 
			this.cbsteady.AccessibleDescription = resources.GetString("cbsteady.AccessibleDescription");
			this.cbsteady.AccessibleName = resources.GetString("cbsteady.AccessibleName");
			this.cbsteady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsteady.Anchor")));
			this.cbsteady.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbsteady.Appearance")));
			this.cbsteady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsteady.BackgroundImage")));
			this.cbsteady.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.CheckAlign")));
			this.cbsteady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsteady.Dock")));
			this.cbsteady.Enabled = ((bool)(resources.GetObject("cbsteady.Enabled")));
			this.cbsteady.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbsteady.FlatStyle")));
			this.cbsteady.Font = ((System.Drawing.Font)(resources.GetObject("cbsteady.Font")));
			this.cbsteady.Image = ((System.Drawing.Image)(resources.GetObject("cbsteady.Image")));
			this.cbsteady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.ImageAlign")));
			this.cbsteady.ImageIndex = ((int)(resources.GetObject("cbsteady.ImageIndex")));
			this.cbsteady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsteady.ImeMode")));
			this.cbsteady.Location = ((System.Drawing.Point)(resources.GetObject("cbsteady.Location")));
			this.cbsteady.Name = "cbsteady";
			this.cbsteady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsteady.RightToLeft")));
			this.cbsteady.Size = ((System.Drawing.Size)(resources.GetObject("cbsteady.Size")));
			this.cbsteady.TabIndex = ((int)(resources.GetObject("cbsteady.TabIndex")));
			this.cbsteady.Text = resources.GetString("cbsteady.Text");
			this.cbsteady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.TextAlign")));
			this.toolTip1.SetToolTip(this.cbsteady, resources.GetString("cbsteady.ToolTip"));
			this.cbsteady.Visible = ((bool)(resources.GetObject("cbsteady.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbsteady, true);
			// 
			// cblove
			// 
			this.cblove.AccessibleDescription = resources.GetString("cblove.AccessibleDescription");
			this.cblove.AccessibleName = resources.GetString("cblove.AccessibleName");
			this.cblove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblove.Anchor")));
			this.cblove.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cblove.Appearance")));
			this.cblove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblove.BackgroundImage")));
			this.cblove.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.CheckAlign")));
			this.cblove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblove.Dock")));
			this.cblove.Enabled = ((bool)(resources.GetObject("cblove.Enabled")));
			this.cblove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cblove.FlatStyle")));
			this.cblove.Font = ((System.Drawing.Font)(resources.GetObject("cblove.Font")));
			this.cblove.Image = ((System.Drawing.Image)(resources.GetObject("cblove.Image")));
			this.cblove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.ImageAlign")));
			this.cblove.ImageIndex = ((int)(resources.GetObject("cblove.ImageIndex")));
			this.cblove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblove.ImeMode")));
			this.cblove.Location = ((System.Drawing.Point)(resources.GetObject("cblove.Location")));
			this.cblove.Name = "cblove";
			this.cblove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblove.RightToLeft")));
			this.cblove.Size = ((System.Drawing.Size)(resources.GetObject("cblove.Size")));
			this.cblove.TabIndex = ((int)(resources.GetObject("cblove.TabIndex")));
			this.cblove.Text = resources.GetString("cblove.Text");
			this.cblove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.TextAlign")));
			this.toolTip1.SetToolTip(this.cblove, resources.GetString("cblove.ToolTip"));
			this.cblove.Visible = ((bool)(resources.GetObject("cblove.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cblove, true);
			// 
			// cbcrush
			// 
			this.cbcrush.AccessibleDescription = resources.GetString("cbcrush.AccessibleDescription");
			this.cbcrush.AccessibleName = resources.GetString("cbcrush.AccessibleName");
			this.cbcrush.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcrush.Anchor")));
			this.cbcrush.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcrush.Appearance")));
			this.cbcrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcrush.BackgroundImage")));
			this.cbcrush.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.CheckAlign")));
			this.cbcrush.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcrush.Dock")));
			this.cbcrush.Enabled = ((bool)(resources.GetObject("cbcrush.Enabled")));
			this.cbcrush.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcrush.FlatStyle")));
			this.cbcrush.Font = ((System.Drawing.Font)(resources.GetObject("cbcrush.Font")));
			this.cbcrush.Image = ((System.Drawing.Image)(resources.GetObject("cbcrush.Image")));
			this.cbcrush.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.ImageAlign")));
			this.cbcrush.ImageIndex = ((int)(resources.GetObject("cbcrush.ImageIndex")));
			this.cbcrush.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcrush.ImeMode")));
			this.cbcrush.Location = ((System.Drawing.Point)(resources.GetObject("cbcrush.Location")));
			this.cbcrush.Name = "cbcrush";
			this.cbcrush.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcrush.RightToLeft")));
			this.cbcrush.Size = ((System.Drawing.Size)(resources.GetObject("cbcrush.Size")));
			this.cbcrush.TabIndex = ((int)(resources.GetObject("cbcrush.TabIndex")));
			this.cbcrush.Text = resources.GetString("cbcrush.Text");
			this.cbcrush.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.TextAlign")));
			this.toolTip1.SetToolTip(this.cbcrush, resources.GetString("cbcrush.ToolTip"));
			this.cbcrush.Visible = ((bool)(resources.GetObject("cbcrush.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbcrush, true);
			// 
			// cbbuddie
			// 
			this.cbbuddie.AccessibleDescription = resources.GetString("cbbuddie.AccessibleDescription");
			this.cbbuddie.AccessibleName = resources.GetString("cbbuddie.AccessibleName");
			this.cbbuddie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbuddie.Anchor")));
			this.cbbuddie.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbuddie.Appearance")));
			this.cbbuddie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbuddie.BackgroundImage")));
			this.cbbuddie.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.CheckAlign")));
			this.cbbuddie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbuddie.Dock")));
			this.cbbuddie.Enabled = ((bool)(resources.GetObject("cbbuddie.Enabled")));
			this.cbbuddie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbuddie.FlatStyle")));
			this.cbbuddie.Font = ((System.Drawing.Font)(resources.GetObject("cbbuddie.Font")));
			this.cbbuddie.Image = ((System.Drawing.Image)(resources.GetObject("cbbuddie.Image")));
			this.cbbuddie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.ImageAlign")));
			this.cbbuddie.ImageIndex = ((int)(resources.GetObject("cbbuddie.ImageIndex")));
			this.cbbuddie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbuddie.ImeMode")));
			this.cbbuddie.Location = ((System.Drawing.Point)(resources.GetObject("cbbuddie.Location")));
			this.cbbuddie.Name = "cbbuddie";
			this.cbbuddie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbuddie.RightToLeft")));
			this.cbbuddie.Size = ((System.Drawing.Size)(resources.GetObject("cbbuddie.Size")));
			this.cbbuddie.TabIndex = ((int)(resources.GetObject("cbbuddie.TabIndex")));
			this.cbbuddie.Text = resources.GetString("cbbuddie.Text");
			this.cbbuddie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbuddie, resources.GetString("cbbuddie.ToolTip"));
			this.cbbuddie.Visible = ((bool)(resources.GetObject("cbbuddie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbuddie, true);
			// 
			// cbfriend
			// 
			this.cbfriend.AccessibleDescription = resources.GetString("cbfriend.AccessibleDescription");
			this.cbfriend.AccessibleName = resources.GetString("cbfriend.AccessibleName");
			this.cbfriend.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfriend.Anchor")));
			this.cbfriend.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfriend.Appearance")));
			this.cbfriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfriend.BackgroundImage")));
			this.cbfriend.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.CheckAlign")));
			this.cbfriend.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfriend.Dock")));
			this.cbfriend.Enabled = ((bool)(resources.GetObject("cbfriend.Enabled")));
			this.cbfriend.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfriend.FlatStyle")));
			this.cbfriend.Font = ((System.Drawing.Font)(resources.GetObject("cbfriend.Font")));
			this.cbfriend.Image = ((System.Drawing.Image)(resources.GetObject("cbfriend.Image")));
			this.cbfriend.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.ImageAlign")));
			this.cbfriend.ImageIndex = ((int)(resources.GetObject("cbfriend.ImageIndex")));
			this.cbfriend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfriend.ImeMode")));
			this.cbfriend.Location = ((System.Drawing.Point)(resources.GetObject("cbfriend.Location")));
			this.cbfriend.Name = "cbfriend";
			this.cbfriend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfriend.RightToLeft")));
			this.cbfriend.Size = ((System.Drawing.Size)(resources.GetObject("cbfriend.Size")));
			this.cbfriend.TabIndex = ((int)(resources.GetObject("cbfriend.TabIndex")));
			this.cbfriend.Text = resources.GetString("cbfriend.Text");
			this.cbfriend.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.TextAlign")));
			this.toolTip1.SetToolTip(this.cbfriend, resources.GetString("cbfriend.ToolTip"));
			this.cbfriend.Visible = ((bool)(resources.GetObject("cbfriend.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfriend, true);
			// 
			// cbenemy
			// 
			this.cbenemy.AccessibleDescription = resources.GetString("cbenemy.AccessibleDescription");
			this.cbenemy.AccessibleName = resources.GetString("cbenemy.AccessibleName");
			this.cbenemy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbenemy.Anchor")));
			this.cbenemy.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbenemy.Appearance")));
			this.cbenemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbenemy.BackgroundImage")));
			this.cbenemy.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.CheckAlign")));
			this.cbenemy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbenemy.Dock")));
			this.cbenemy.Enabled = ((bool)(resources.GetObject("cbenemy.Enabled")));
			this.cbenemy.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbenemy.FlatStyle")));
			this.cbenemy.Font = ((System.Drawing.Font)(resources.GetObject("cbenemy.Font")));
			this.cbenemy.Image = ((System.Drawing.Image)(resources.GetObject("cbenemy.Image")));
			this.cbenemy.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.ImageAlign")));
			this.cbenemy.ImageIndex = ((int)(resources.GetObject("cbenemy.ImageIndex")));
			this.cbenemy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbenemy.ImeMode")));
			this.cbenemy.Location = ((System.Drawing.Point)(resources.GetObject("cbenemy.Location")));
			this.cbenemy.Name = "cbenemy";
			this.cbenemy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbenemy.RightToLeft")));
			this.cbenemy.Size = ((System.Drawing.Size)(resources.GetObject("cbenemy.Size")));
			this.cbenemy.TabIndex = ((int)(resources.GetObject("cbenemy.TabIndex")));
			this.cbenemy.Text = resources.GetString("cbenemy.Text");
			this.cbenemy.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.TextAlign")));
			this.toolTip1.SetToolTip(this.cbenemy, resources.GetString("cbenemy.ToolTip"));
			this.cbenemy.Visible = ((bool)(resources.GetObject("cbenemy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbenemy, true);
			// 
			// tblongterm
			// 
			this.tblongterm.AccessibleDescription = resources.GetString("tblongterm.AccessibleDescription");
			this.tblongterm.AccessibleName = resources.GetString("tblongterm.AccessibleName");
			this.tblongterm.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblongterm.Anchor")));
			this.tblongterm.AutoSize = ((bool)(resources.GetObject("tblongterm.AutoSize")));
			this.tblongterm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblongterm.BackgroundImage")));
			this.tblongterm.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblongterm.Dock")));
			this.tblongterm.Enabled = ((bool)(resources.GetObject("tblongterm.Enabled")));
			this.tblongterm.Font = ((System.Drawing.Font)(resources.GetObject("tblongterm.Font")));
			this.tblongterm.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblongterm.ImeMode")));
			this.tblongterm.Location = ((System.Drawing.Point)(resources.GetObject("tblongterm.Location")));
			this.tblongterm.MaxLength = ((int)(resources.GetObject("tblongterm.MaxLength")));
			this.tblongterm.Multiline = ((bool)(resources.GetObject("tblongterm.Multiline")));
			this.tblongterm.Name = "tblongterm";
			this.tblongterm.PasswordChar = ((char)(resources.GetObject("tblongterm.PasswordChar")));
			this.tblongterm.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblongterm.RightToLeft")));
			this.tblongterm.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblongterm.ScrollBars")));
			this.tblongterm.Size = ((System.Drawing.Size)(resources.GetObject("tblongterm.Size")));
			this.tblongterm.TabIndex = ((int)(resources.GetObject("tblongterm.TabIndex")));
			this.tblongterm.Text = resources.GetString("tblongterm.Text");
			this.tblongterm.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblongterm.TextAlign")));
			this.toolTip1.SetToolTip(this.tblongterm, resources.GetString("tblongterm.ToolTip"));
			this.tblongterm.Visible = ((bool)(resources.GetObject("tblongterm.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblongterm, true);
			this.tblongterm.WordWrap = ((bool)(resources.GetObject("tblongterm.WordWrap")));
			// 
			// tbshortterm
			// 
			this.tbshortterm.AccessibleDescription = resources.GetString("tbshortterm.AccessibleDescription");
			this.tbshortterm.AccessibleName = resources.GetString("tbshortterm.AccessibleName");
			this.tbshortterm.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbshortterm.Anchor")));
			this.tbshortterm.AutoSize = ((bool)(resources.GetObject("tbshortterm.AutoSize")));
			this.tbshortterm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbshortterm.BackgroundImage")));
			this.tbshortterm.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbshortterm.Dock")));
			this.tbshortterm.Enabled = ((bool)(resources.GetObject("tbshortterm.Enabled")));
			this.tbshortterm.Font = ((System.Drawing.Font)(resources.GetObject("tbshortterm.Font")));
			this.tbshortterm.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbshortterm.ImeMode")));
			this.tbshortterm.Location = ((System.Drawing.Point)(resources.GetObject("tbshortterm.Location")));
			this.tbshortterm.MaxLength = ((int)(resources.GetObject("tbshortterm.MaxLength")));
			this.tbshortterm.Multiline = ((bool)(resources.GetObject("tbshortterm.Multiline")));
			this.tbshortterm.Name = "tbshortterm";
			this.tbshortterm.PasswordChar = ((char)(resources.GetObject("tbshortterm.PasswordChar")));
			this.tbshortterm.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbshortterm.RightToLeft")));
			this.tbshortterm.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbshortterm.ScrollBars")));
			this.tbshortterm.Size = ((System.Drawing.Size)(resources.GetObject("tbshortterm.Size")));
			this.tbshortterm.TabIndex = ((int)(resources.GetObject("tbshortterm.TabIndex")));
			this.tbshortterm.Text = resources.GetString("tbshortterm.Text");
			this.tbshortterm.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbshortterm.TextAlign")));
			this.toolTip1.SetToolTip(this.tbshortterm, resources.GetString("tbshortterm.ToolTip"));
			this.tbshortterm.Visible = ((bool)(resources.GetObject("tbshortterm.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbshortterm, true);
			this.tbshortterm.WordWrap = ((bool)(resources.GetObject("tbshortterm.WordWrap")));
			// 
			// label57
			// 
			this.label57.AccessibleDescription = resources.GetString("label57.AccessibleDescription");
			this.label57.AccessibleName = resources.GetString("label57.AccessibleName");
			this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label57.Anchor")));
			this.label57.AutoSize = ((bool)(resources.GetObject("label57.AutoSize")));
			this.label57.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label57.Dock")));
			this.label57.Enabled = ((bool)(resources.GetObject("label57.Enabled")));
			this.label57.Font = ((System.Drawing.Font)(resources.GetObject("label57.Font")));
			this.label57.Image = ((System.Drawing.Image)(resources.GetObject("label57.Image")));
			this.label57.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label57.ImageAlign")));
			this.label57.ImageIndex = ((int)(resources.GetObject("label57.ImageIndex")));
			this.label57.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label57.ImeMode")));
			this.label57.Location = ((System.Drawing.Point)(resources.GetObject("label57.Location")));
			this.label57.Name = "label57";
			this.label57.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label57.RightToLeft")));
			this.label57.Size = ((System.Drawing.Size)(resources.GetObject("label57.Size")));
			this.label57.TabIndex = ((int)(resources.GetObject("label57.TabIndex")));
			this.label57.Text = resources.GetString("label57.Text");
			this.label57.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label57.TextAlign")));
			this.toolTip1.SetToolTip(this.label57, resources.GetString("label57.ToolTip"));
			this.label57.Visible = ((bool)(resources.GetObject("label57.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label57, true);
			// 
			// label58
			// 
			this.label58.AccessibleDescription = resources.GetString("label58.AccessibleDescription");
			this.label58.AccessibleName = resources.GetString("label58.AccessibleName");
			this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label58.Anchor")));
			this.label58.AutoSize = ((bool)(resources.GetObject("label58.AutoSize")));
			this.label58.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label58.Dock")));
			this.label58.Enabled = ((bool)(resources.GetObject("label58.Enabled")));
			this.label58.Font = ((System.Drawing.Font)(resources.GetObject("label58.Font")));
			this.label58.Image = ((System.Drawing.Image)(resources.GetObject("label58.Image")));
			this.label58.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label58.ImageAlign")));
			this.label58.ImageIndex = ((int)(resources.GetObject("label58.ImageIndex")));
			this.label58.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label58.ImeMode")));
			this.label58.Location = ((System.Drawing.Point)(resources.GetObject("label58.Location")));
			this.label58.Name = "label58";
			this.label58.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label58.RightToLeft")));
			this.label58.Size = ((System.Drawing.Size)(resources.GetObject("label58.Size")));
			this.label58.TabIndex = ((int)(resources.GetObject("label58.TabIndex")));
			this.label58.Text = resources.GetString("label58.Text");
			this.label58.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label58.TextAlign")));
			this.toolTip1.SetToolTip(this.label58, resources.GetString("label58.ToolTip"));
			this.label58.Visible = ((bool)(resources.GetObject("label58.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label58, true);
			// 
			// panel7
			// 
			this.panel7.AccessibleDescription = resources.GetString("panel7.AccessibleDescription");
			this.panel7.AccessibleName = resources.GetString("panel7.AccessibleName");
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel7.Anchor")));
			this.panel7.AutoScroll = ((bool)(resources.GetObject("panel7.AutoScroll")));
			this.panel7.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel7.AutoScrollMargin")));
			this.panel7.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel7.AutoScrollMinSize")));
			this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
			this.panel7.Controls.Add(this.label56);
			this.panel7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel7.Dock")));
			this.panel7.Enabled = ((bool)(resources.GetObject("panel7.Enabled")));
			this.panel7.Font = ((System.Drawing.Font)(resources.GetObject("panel7.Font")));
			this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel7.ImeMode")));
			this.panel7.Location = ((System.Drawing.Point)(resources.GetObject("panel7.Location")));
			this.panel7.Name = "panel7";
			this.panel7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel7.RightToLeft")));
			this.panel7.Size = ((System.Drawing.Size)(resources.GetObject("panel7.Size")));
			this.panel7.TabIndex = ((int)(resources.GetObject("panel7.TabIndex")));
			this.panel7.Text = resources.GetString("panel7.Text");
			this.toolTip1.SetToolTip(this.panel7, resources.GetString("panel7.ToolTip"));
			this.panel7.Visible = ((bool)(resources.GetObject("panel7.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel7, true);
			// 
			// label56
			// 
			this.label56.AccessibleDescription = resources.GetString("label56.AccessibleDescription");
			this.label56.AccessibleName = resources.GetString("label56.AccessibleName");
			this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label56.Anchor")));
			this.label56.AutoSize = ((bool)(resources.GetObject("label56.AutoSize")));
			this.label56.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label56.Dock")));
			this.label56.Enabled = ((bool)(resources.GetObject("label56.Enabled")));
			this.label56.Font = ((System.Drawing.Font)(resources.GetObject("label56.Font")));
			this.label56.Image = ((System.Drawing.Image)(resources.GetObject("label56.Image")));
			this.label56.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label56.ImageAlign")));
			this.label56.ImageIndex = ((int)(resources.GetObject("label56.ImageIndex")));
			this.label56.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label56.ImeMode")));
			this.label56.Location = ((System.Drawing.Point)(resources.GetObject("label56.Location")));
			this.label56.Name = "label56";
			this.label56.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label56.RightToLeft")));
			this.label56.Size = ((System.Drawing.Size)(resources.GetObject("label56.Size")));
			this.label56.TabIndex = ((int)(resources.GetObject("label56.TabIndex")));
			this.label56.Text = resources.GetString("label56.Text");
			this.label56.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label56.TextAlign")));
			this.toolTip1.SetToolTip(this.label56, resources.GetString("label56.ToolTip"));
			this.label56.Visible = ((bool)(resources.GetObject("label56.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label56, true);
			// 
			// llrelcommit
			// 
			this.llrelcommit.AccessibleDescription = resources.GetString("llrelcommit.AccessibleDescription");
			this.llrelcommit.AccessibleName = resources.GetString("llrelcommit.AccessibleName");
			this.llrelcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llrelcommit.Anchor")));
			this.llrelcommit.AutoSize = ((bool)(resources.GetObject("llrelcommit.AutoSize")));
			this.llrelcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llrelcommit.Dock")));
			this.llrelcommit.Enabled = ((bool)(resources.GetObject("llrelcommit.Enabled")));
			this.llrelcommit.Font = ((System.Drawing.Font)(resources.GetObject("llrelcommit.Font")));
			this.llrelcommit.Image = ((System.Drawing.Image)(resources.GetObject("llrelcommit.Image")));
			this.llrelcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrelcommit.ImageAlign")));
			this.llrelcommit.ImageIndex = ((int)(resources.GetObject("llrelcommit.ImageIndex")));
			this.llrelcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llrelcommit.ImeMode")));
			this.llrelcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llrelcommit.LinkArea")));
			this.llrelcommit.Location = ((System.Drawing.Point)(resources.GetObject("llrelcommit.Location")));
			this.llrelcommit.Name = "llrelcommit";
			this.llrelcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llrelcommit.RightToLeft")));
			this.llrelcommit.Size = ((System.Drawing.Size)(resources.GetObject("llrelcommit.Size")));
			this.llrelcommit.TabIndex = ((int)(resources.GetObject("llrelcommit.TabIndex")));
			this.llrelcommit.Text = resources.GetString("llrelcommit.Text");
			this.llrelcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrelcommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llrelcommit, resources.GetString("llrelcommit.ToolTip"));
			this.llrelcommit.Visible = ((bool)(resources.GetObject("llrelcommit.Visible")));
			// 
			// Elements
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.tabControl1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Elements";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.JpegPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.xmlPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.objdPanel.ResumeLayout(false);
			this.gbelements.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.familytiePanel.ResumeLayout(false);
			this.gbties.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.famiPanel.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.realPanel.ResumeLayout(false);
			this.gbrelation.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CommitFamiClick(object sender, System.EventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					SimPe.PackedFiles.Wrapper.Fami fami = (Wrapper.Fami)wrapper;
					fami.Money = Convert.ToInt32(tbmoney.Text);
					fami.Friends = Convert.ToUInt32(tbfamily.Text);
					fami.Flags = Convert.ToUInt32(tbflag.Text, 16);
					fami.AlbumGUID = Convert.ToUInt32(tbalbum.Text, 16);
					fami.SubHoodNumber = Convert.ToUInt32(tbsubhood.Text, 16);

					uint[] members = new uint[lbmembers.Items.Count];
					for (int i=0; i< members.Length; i++) 
					{
						members[i] = ((SimPe.Interfaces.IAlias)lbmembers.Items[i]).Id;
						SimPe.PackedFiles.Wrapper.SDesc sdesc = fami.GetDescriptionFile(members[i]);
						sdesc.FamilyInstance = (ushort)fami.FileDescriptor.Instance;
						sdesc.SynchronizeUserData();
					}
					fami.Members = members;

					fami.LotInstance = Convert.ToUInt32(this.tblotinst.Text, 16);
					//name was changed
					if (tbname.Text != fami.Name) fami.Name = tbname.Text;

					wrapper.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				}
				catch (Exception ex) {
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitfamily"), ex);
				}
				finally 
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void CommitXmlClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.Xml xml = (Wrapper.Xml)wrapper;
					xml.Text = rtb.Text;
					wrapper.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				} 
				catch (Exception) {}
			}
		}
		
		private void FamiSimAddClick(object sender, System.EventArgs e)
		{
			if (cbsims.SelectedIndex>=0) 
			{
				if (!this.lbmembers.Items.Contains(cbsims.Items[cbsims.SelectedIndex]))
					this.lbmembers.Items.Add(cbsims.Items[cbsims.SelectedIndex]);
			}
		}

		private void SimSelectionChange(object sender, System.EventArgs e)
		{
			this.llFamiAddSim.Enabled = ((((ComboBox)sender).SelectedIndex>=0) && (((ComboBox)sender).Items.Count>0));
		}

		private void FamiMemberSelectionClick(object sender, System.EventArgs e)
		{
			this.llFamiDeleteSim.Enabled = (((ListBox)sender).SelectedIndex>=0);
			this.llFamiDeleteSim.Invalidate();
			this.llFamiDeleteSim.Update();
		}

		private void FamiDeleteSimClick(object sender, System.EventArgs e)
		{
			if (lbmembers.SelectedIndex>=0) 
			{
				lbmembers.Items.Remove(lbmembers.Items[lbmembers.SelectedIndex]);
			}
		}

		private void FileNameMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) 
			{
				if (((Label)sender).Tag!=null)
					Clipboard.SetDataObject(((Label)sender).Tag, true);
			}
		}				
		
		#region FAMi ProgressBar Handling		
		internal void ProgressBarMaximize(Control parent) 
		{
			foreach(Control c in parent.Controls) 
			{
				if (c.GetType()== typeof(ProgressBar)) 
				{
					ProgressBar pb = ((ProgressBar)c);
					if (pb.Maximum<1000) pb.Value = pb.Maximum;
					else pb.Value = pb.Maximum-1;											 
				}				
			}
			ProgressBarUpdate(parent);
		}

		internal void ProgressBarUpdate(Control parent) 
		{
			foreach(Control c in parent.Controls) 
			{
				if (c.GetType().Name=="ProgressBar") ProgressBarUpdate((ProgressBar)c, null);
			}
		}		

		private void ProgressBarUpdate(ProgressBar pb, System.Windows.Forms.MouseEventArgs e) 
		{
			if (e!=null) pb.Value = Math.Max(pb.Minimum, Math.Min(pb.Maximum, Convert.ToInt32(Math.Round(((double)e.X / (double)pb.Width) * pb.Maximum))));
			foreach(Control c in pb.Parent.Controls) 
			{
				if (c.GetType().Name=="TextBox") 
				{
					TextBox tb = (TextBox)c;
					if (tb.Name == pb.Name.Replace("pb", "tb")) 
					{
						if (pb.Tag!=null) c.Text = (pb.Value - (int)pb.Tag).ToString();
						else c.Text = pb.Value.ToString();
					}
				}
			}
		}

		private void ProgressBarMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			//pb.Tag = null;
			ProgressBarUpdate(pb, e);
		}

		private void ProgressBarMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			//pb.Tag = true;
			ProgressBarUpdate(pb, e);
		}

		private void ProgressBarMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			if (e.Button == MouseButtons.Left) 
			{
				ProgressBarUpdate(pb, e);
			}

		}

		protected void GetAssignedProgressbar(TextBox tb) 
		{
			foreach(Control c in tb.Parent.Controls) 
			{
				if (c.GetType().Name=="ProgressBar") 
				{
					ProgressBar pb = (ProgressBar)c;	
					if (tb.Name == pb.Name.Replace("pb", "tb")) 
					{
						tb.Tag = pb;
						break;
					}
				}
			}
		}

		private void ProgressBarTextChanged(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			ProgressBar pb = null;
			if (tb.Tag == null ) GetAssignedProgressbar(tb);			
			if (tb.Tag == null ) return;

			pb = (ProgressBar)tb.Tag;
			try 
			{
				if (pb.Tag!=null) pb.Value = Math.Max(0, Math.Min(pb.Maximum, Convert.ToInt16(tb.Text) + (int)pb.Tag));
				else pb.Value = Math.Max(0, Math.Min(pb.Maximum, Convert.ToInt16(tb.Text)));
			} 
			catch(Exception){}
		}

		private void ProgressBarTextLeave(object sender, System.EventArgs e)
		{
			if (sender.GetType() != typeof(TextBox)) return;
			TextBox tb = (TextBox)sender;
			ProgressBar pb = null;
			if (tb.Tag == null ) GetAssignedProgressbar(tb);	
			if (tb.Tag == null ) return;

			pb = (ProgressBar)tb.Tag;
			try 
			{
				if (pb.Tag!=null) tb.Text = (pb.Value - (int)pb.Tag).ToString();
				else tb.Text = pb.Value.ToString();
			} 
			catch(Exception){}
		}
		#endregion

		#region Family Ties
		private void FamilyTieSimIndexChanged(object sender, System.EventArgs e)
		{
			this.btdeletetie.Enabled = false;
			if (this.cbtiesims.SelectedIndex < 0) return;
			FamilyTieSim sim = (FamilyTieSim)cbtiesims.Items[cbtiesims.SelectedIndex];

			this.lbties.Items.Clear();
			foreach (FamilyTieItem tie in sim.Ties) 
			{
				lbties.Items.Add(tie);
			}
		}

		private void AllTieableSimsIndexChanged(object sender, System.EventArgs e)
		{
			this.btaddtie.Enabled = false;
			this.btnewtie.Enabled = false;
			if (this.cballtieablesims.SelectedIndex < 0) return;
			this.btnewtie.Enabled = true;
			if (this.cbtiesims.SelectedIndex < 0) return;			
			this.btaddtie.Enabled = true;
		}		

		private void DeleteTieClick(object sender, System.EventArgs e)
		{
			this.btaddtie.Enabled = false;
			if (this.lbties.SelectedIndex < 0) return;
			lbties.Items.Remove(lbties.Items[lbties.SelectedIndex]);
		}

		private void AddTieClick(object sender, System.EventArgs e)
		{
			if (this.cballtieablesims.SelectedIndex < 0) return;
			if (this.cbtietype.SelectedIndex < 0) return;

			try 
			{
				SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				Data.MetaData.FamilyTieTypes ftt = (Data.LocalizedFamilyTieTypes)this.cbtietype.Items[cbtietype.SelectedIndex];
				FamilyTieSim fts = (FamilyTieSim)this.cballtieablesims.Items[cballtieablesims.SelectedIndex];
				FamilyTieItem tie = new FamilyTieItem(ftt, fts.Instance, famt);
				this.lbties.Items.Add(tie);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("cantaddtie"), ex);
			}
		}

		private void CommitSimTieClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.cbtiesims.SelectedIndex < 0) return;

			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				
					FamilyTieSim fts = (FamilyTieSim)cbtiesims.Items[cbtiesims.SelectedIndex];
					FamilyTieItem[] ftis = new FamilyTieItem[lbties.Items.Count];
					for (int i=0; i<lbties.Items.Count; i++) 
					{
						ftis[i] = (FamilyTieItem)lbties.Items[i];
					}
					fts.Ties = ftis;					
				}
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitfamt"), ex);
				}
			}
		}		

		private void TieIndexChanged(object sender, System.EventArgs e)
		{
			this.btdeletetie.Enabled = false;
			if (this.lbties.SelectedIndex < 0) return;
			this.btdeletetie.Enabled = true;
		}

		private void CommitTieClick(object sender, System.EventArgs e)
		{
			CommitSimTieClicked(null, null);
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				
					FamilyTieSim[] sims = new FamilyTieSim[cbtiesims.Items.Count];
					for (int i=0; i<sims.Length; i++) 
					{
						sims[i] = (FamilyTieSim)cbtiesims.Items[i];
					}
					famt.Sims = sims;

					famt.SynchronizeUserData();				
				}
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommittie"), ex);
				}
			}
		}		

		private void AddSimToTiesClick(object sender, System.EventArgs e)
		{
			if (this.cballtieablesims.SelectedIndex < 0) return;
			FamilyTieSim sim = (FamilyTieSim)this.cballtieablesims.Items[cballtieablesims.SelectedIndex];
			sim.Ties = new FamilyTieItem[0];			

			//check if the tie exists
			bool exists = false;
			foreach (FamilyTieSim exsim in cbtiesims.Items) 
			{
				if (exsim.Instance==sim.Instance) 
				{
					exists = true;
					break;
				}
			}//foreach

			if (!exists) 
			{
				cbtiesims.Items.Add(sim);
			}
		}
		#endregion

		#region Relationships
		
		private void RelationshipFileCommit(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.SRel srel = (Wrapper.SRel)wrapper;
					srel.Shortterm = Convert.ToInt32(tbshortterm.Text);
					srel.Longterm = Convert.ToInt32(tblongterm.Text);

					SimPe.PackedFiles.Wrapper.RelationshipFlags outf = new SimPe.PackedFiles.Wrapper.RelationshipFlags(0);
					outf.IsEnemy = this.cbenemy.Checked;
					outf.IsFriend = this.cbfriend.Checked;
					outf.IsBuddie = this.cbbuddie.Checked;
					outf.IsKnown = this.cbbest.Checked;
					outf.HasCrush = this.cbcrush.Checked;
					outf.InLove = this.cblove.Checked;
					outf.GoSteady = this.cbsteady.Checked;
					outf.IsEngaged = this.cbengaged.Checked;
					outf.IsMarried = this.cbmarried.Checked;
					outf.IsFamilyMember = this.cbfamily.Checked;
					srel.RelationState = outf;
					if (cbfamtype.SelectedIndex>0)
						srel.FamilyRelation = (Data.LocalizedRelationshipTypes)cbfamtype.Items[cbfamtype.SelectedIndex];


					wrapper.SynchronizeUserData();
					MessageBox.Show("Changes were comitted!");
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("Unable to Save Relationship Information!", ex);
				}
			}
		}		
		#endregion		

		private void CommitObjdClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					SimPe.PackedFiles.Wrapper.Objd objd = (Wrapper.Objd)wrapper;					

					foreach (Control c in pnelements.Controls) 
					{
						if (c.GetType() == typeof(TextBox)) 
						{
							TextBox tb = (TextBox)c;
							if (tb.Tag!=null) 
							{
								string name = (string)tb.Tag;
								Wrapper.ObjdItem item = (Wrapper.ObjdItem)objd.Attributes[name];
								item.val = Convert.ToUInt16(tb.Text, 16);
								objd.Attributes[name] = item;
							}
						}
					}

					objd.Type = (ushort)Helper.HexStringToUInt(tblottype.Text);
					objd.Guid = (uint)Helper.HexStringToUInt(tbsimid.Text);
					objd.FileName = tbsimname.Text;
					objd.OriginalGuid = (uint)Helper.HexStringToUInt(this.tborgguid.Text);
					objd.ProxyGuid = (uint)Helper.HexStringToUInt(this.tbproxguid.Text);

					objd.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitobjd"), ex);
				}
			}
		}

		private void GetGUIDClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Sims.GUID.GUIDGetterForm form = new Sims.GUID.GUIDGetterForm();
			Registry reg = Helper.WindowsRegistry;

			try 
			{
				uint oldguid = Convert.ToUInt32(tbsimid.Text, 16);
				uint guid = form.GetNewGUID(reg.Username, reg.Password, oldguid);

				reg.Username = form.tbusername.Text;
				reg.Password = form.tbpassword.Text;
				this.tbsimid.Text = "0x"+Helper.HexString(guid);

				if (cbupdate.Checked) 
				{
					SimPe.Plugin.FixGuid fg = new SimPe.Plugin.FixGuid(((SimPe.PackedFiles.Wrapper.Objd)wrapper).Package);
					ArrayList al = new ArrayList();
					SimPe.Plugin.GuidSet gs = new SimPe.Plugin.GuidSet();
					gs.oldguid = oldguid;
					gs.guid = guid;
					al.Add(gs);

					fg.FixGuids(al);

					((SimPe.PackedFiles.Wrapper.Objd)wrapper).Guid = guid;
					wrapper.SynchronizeUserData();
				}
			} 
			catch (Exception) {}
		}

		internal bool simnamechanged;
		private void SimNameChanged(object sender, System.EventArgs e)
		{
			simnamechanged = true;
		}

		private void FlagChanged(object sender, System.EventArgs e)
		{
			if (tbflag.Tag!=null) return;
			tbflag.Tag = true;
			try 
			{
				uint flag = Convert.ToUInt32(tbflag.Text, 16);
				SimPe.PackedFiles.Wrapper.FamiFlags flags = new SimPe.PackedFiles.Wrapper.FamiFlags((ushort)flag);

				this.cbphone.Checked = flags.HasPhone;
				this.cbcomputer.Checked = flags.HasComputer;
				this.cbbaby.Checked = flags.HasBaby;
				this.cblot.Checked = flags.NewLot;

				
			} 
			catch (Exception) {}
			finally 
			{
				tbflag.Tag = null;
			}
		}

		private void ChangeFlags(object sender, System.EventArgs e)
		{
			if (tbflag.Tag!=null) return;
			tbflag.Tag = true;
			try {
				uint flag = Convert.ToUInt32(tbflag.Text, 16) & 0xffff0000;
				
				SimPe.PackedFiles.Wrapper.FamiFlags flags = new SimPe.PackedFiles.Wrapper.FamiFlags(0);

				flags.HasPhone = this.cbphone.Checked;
				flags.HasComputer = this.cbcomputer.Checked;
				flags.HasBaby = this.cbbaby.Checked;
				flags.NewLot = this.cblot.Checked;

				flag = flag | flags.Value;
				tbflag.Text = "0x"+Helper.HexString(flag);
			} 
			catch (Exception) {}
			finally 
			{
				tbflag.Tag = null;
			}
		}

		private void cboutfamtype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}		

		private void tbuni_Click(object sender, System.EventArgs e)
		{
		
		}

		

		internal SimPe.Interfaces.Plugin.IFileWrapper picwrapper;
		private void btPicExport_Click(object sender, System.EventArgs e)
		{
			SimPe.PackedFiles.Wrapper.Picture wrp = (SimPe.PackedFiles.Wrapper.Picture)picwrapper;
			System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Image (*.png) | *.png";

			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				try 
				{
					wrp.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(ex);
				}
			}
		}

		

		

	}
}
