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
		private System.Windows.Forms.Button btPicExport;
        internal TextBox tbvac;
        private Label label7;
        internal GroupBox gbCastaway;
        internal TextBox tbcaunk;
        private Label label13;
        internal TextBox tbcares;
        private Label label11;
        internal TextBox tbcafood1;
        private Label label10;
        internal TextBox tbblot;
        private Label label14;
        internal TextBox tbbmoney;
        private Label label16;


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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elements));
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
            this.tbbmoney = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbblot = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbCastaway = new System.Windows.Forms.GroupBox();
            this.tbcaunk = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcares = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbcafood1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbvac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.JpegPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
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
            this.gbCastaway.SuspendLayout();
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
            this.JpegPanel.AccessibleDescription = null;
            this.JpegPanel.AccessibleName = null;
            resources.ApplyResources(this.JpegPanel, "JpegPanel");
            this.JpegPanel.BackgroundImage = null;
            this.JpegPanel.Controls.Add(this.panel2);
            this.JpegPanel.Controls.Add(this.pb);
            this.JpegPanel.Font = null;
            this.JpegPanel.Name = "JpegPanel";
            this.toolTip1.SetToolTip(this.JpegPanel, resources.GetString("JpegPanel.ToolTip"));
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BackgroundImage = null;
            this.panel2.Controls.Add(this.banner);
            this.panel2.Controls.Add(this.btPicExport);
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Name = "panel2";
            this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
            // 
            // banner
            // 
            this.banner.AccessibleDescription = null;
            this.banner.AccessibleName = null;
            resources.ApplyResources(this.banner, "banner");
            this.banner.Font = null;
            this.banner.Name = "banner";
            this.toolTip1.SetToolTip(this.banner, resources.GetString("banner.ToolTip"));
            // 
            // btPicExport
            // 
            this.btPicExport.AccessibleDescription = null;
            this.btPicExport.AccessibleName = null;
            resources.ApplyResources(this.btPicExport, "btPicExport");
            this.btPicExport.BackColor = System.Drawing.SystemColors.Control;
            this.btPicExport.BackgroundImage = null;
            this.btPicExport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btPicExport.Name = "btPicExport";
            this.toolTip1.SetToolTip(this.btPicExport, resources.GetString("btPicExport.ToolTip"));
            this.btPicExport.UseVisualStyleBackColor = false;
            this.btPicExport.Click += new System.EventHandler(this.btPicExport_Click);
            // 
            // pb
            // 
            this.pb.AccessibleDescription = null;
            this.pb.AccessibleName = null;
            resources.ApplyResources(this.pb, "pb");
            this.pb.BackgroundImage = null;
            this.pb.Font = null;
            this.pb.ImageLocation = null;
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            this.toolTip1.SetToolTip(this.pb, resources.GetString("pb.ToolTip"));
            // 
            // xmlPanel
            // 
            this.xmlPanel.AccessibleDescription = null;
            this.xmlPanel.AccessibleName = null;
            resources.ApplyResources(this.xmlPanel, "xmlPanel");
            this.xmlPanel.BackgroundImage = null;
            this.xmlPanel.Controls.Add(this.rtb);
            this.xmlPanel.Controls.Add(this.panel3);
            this.xmlPanel.Controls.Add(this.visualStyleLinkLabel2);
            this.xmlPanel.Font = null;
            this.xmlPanel.Name = "xmlPanel";
            this.toolTip1.SetToolTip(this.xmlPanel, resources.GetString("xmlPanel.ToolTip"));
            // 
            // rtb
            // 
            this.rtb.AccessibleDescription = null;
            this.rtb.AccessibleName = null;
            resources.ApplyResources(this.rtb, "rtb");
            this.rtb.BackgroundImage = null;
            this.rtb.Font = null;
            this.rtb.Name = "rtb";
            this.toolTip1.SetToolTip(this.rtb, resources.GetString("rtb.ToolTip"));
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = null;
            this.panel3.AccessibleName = null;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel3.BackgroundImage = null;
            this.panel3.Controls.Add(this.label1);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Name = "panel3";
            this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Font = null;
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // visualStyleLinkLabel2
            // 
            this.visualStyleLinkLabel2.AccessibleDescription = null;
            this.visualStyleLinkLabel2.AccessibleName = null;
            resources.ApplyResources(this.visualStyleLinkLabel2, "visualStyleLinkLabel2");
            this.visualStyleLinkLabel2.Font = null;
            this.visualStyleLinkLabel2.Name = "visualStyleLinkLabel2";
            this.visualStyleLinkLabel2.TabStop = true;
            this.toolTip1.SetToolTip(this.visualStyleLinkLabel2, resources.GetString("visualStyleLinkLabel2.ToolTip"));
            this.visualStyleLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitXmlClick);
            // 
            // objdPanel
            // 
            this.objdPanel.AccessibleDescription = null;
            this.objdPanel.AccessibleName = null;
            resources.ApplyResources(this.objdPanel, "objdPanel");
            this.objdPanel.BackgroundImage = null;
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
            this.objdPanel.Font = null;
            this.objdPanel.Name = "objdPanel";
            this.toolTip1.SetToolTip(this.objdPanel, resources.GetString("objdPanel.ToolTip"));
            // 
            // cbupdate
            // 
            this.cbupdate.AccessibleDescription = null;
            this.cbupdate.AccessibleName = null;
            resources.ApplyResources(this.cbupdate, "cbupdate");
            this.cbupdate.BackgroundImage = null;
            this.cbupdate.Checked = true;
            this.cbupdate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbupdate.Font = null;
            this.cbupdate.Name = "cbupdate";
            this.toolTip1.SetToolTip(this.cbupdate, resources.GetString("cbupdate.ToolTip"));
            // 
            // label63
            // 
            this.label63.AccessibleDescription = null;
            this.label63.AccessibleName = null;
            resources.ApplyResources(this.label63, "label63");
            this.label63.Name = "label63";
            this.toolTip1.SetToolTip(this.label63, resources.GetString("label63.ToolTip"));
            // 
            // tbproxguid
            // 
            this.tbproxguid.AccessibleDescription = null;
            this.tbproxguid.AccessibleName = null;
            resources.ApplyResources(this.tbproxguid, "tbproxguid");
            this.tbproxguid.BackgroundImage = null;
            this.tbproxguid.Font = null;
            this.tbproxguid.Name = "tbproxguid";
            this.toolTip1.SetToolTip(this.tbproxguid, resources.GetString("tbproxguid.ToolTip"));
            // 
            // label97
            // 
            this.label97.AccessibleDescription = null;
            this.label97.AccessibleName = null;
            resources.ApplyResources(this.label97, "label97");
            this.label97.Name = "label97";
            this.toolTip1.SetToolTip(this.label97, resources.GetString("label97.ToolTip"));
            // 
            // tborgguid
            // 
            this.tborgguid.AccessibleDescription = null;
            this.tborgguid.AccessibleName = null;
            resources.ApplyResources(this.tborgguid, "tborgguid");
            this.tborgguid.BackgroundImage = null;
            this.tborgguid.Font = null;
            this.tborgguid.Name = "tborgguid";
            this.toolTip1.SetToolTip(this.tborgguid, resources.GetString("tborgguid.ToolTip"));
            // 
            // lbtypename
            // 
            this.lbtypename.AccessibleDescription = null;
            this.lbtypename.AccessibleName = null;
            resources.ApplyResources(this.lbtypename, "lbtypename");
            this.lbtypename.Font = null;
            this.lbtypename.Name = "lbtypename";
            this.toolTip1.SetToolTip(this.lbtypename, resources.GetString("lbtypename.ToolTip"));
            // 
            // llgetGUID
            // 
            this.llgetGUID.AccessibleDescription = null;
            this.llgetGUID.AccessibleName = null;
            resources.ApplyResources(this.llgetGUID, "llgetGUID");
            this.llgetGUID.Font = null;
            this.llgetGUID.Name = "llgetGUID";
            this.llgetGUID.TabStop = true;
            this.toolTip1.SetToolTip(this.llgetGUID, resources.GetString("llgetGUID.ToolTip"));
            this.llgetGUID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetGUIDClicked);
            // 
            // gbelements
            // 
            this.gbelements.AccessibleDescription = null;
            this.gbelements.AccessibleName = null;
            resources.ApplyResources(this.gbelements, "gbelements");
            this.gbelements.BackgroundImage = null;
            this.gbelements.Controls.Add(this.pnelements);
            this.gbelements.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbelements.Font = null;
            this.gbelements.Name = "gbelements";
            this.gbelements.TabStop = false;
            this.toolTip1.SetToolTip(this.gbelements, resources.GetString("gbelements.ToolTip"));
            // 
            // pnelements
            // 
            this.pnelements.AccessibleDescription = null;
            this.pnelements.AccessibleName = null;
            resources.ApplyResources(this.pnelements, "pnelements");
            this.pnelements.BackgroundImage = null;
            this.pnelements.Font = null;
            this.pnelements.Name = "pnelements";
            this.toolTip1.SetToolTip(this.pnelements, resources.GetString("pnelements.ToolTip"));
            // 
            // llcommitobjd
            // 
            this.llcommitobjd.AccessibleDescription = null;
            this.llcommitobjd.AccessibleName = null;
            resources.ApplyResources(this.llcommitobjd, "llcommitobjd");
            this.llcommitobjd.Font = null;
            this.llcommitobjd.Name = "llcommitobjd";
            this.llcommitobjd.TabStop = true;
            this.toolTip1.SetToolTip(this.llcommitobjd, resources.GetString("llcommitobjd.ToolTip"));
            this.llcommitobjd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitObjdClicked);
            // 
            // tblottype
            // 
            this.tblottype.AccessibleDescription = null;
            this.tblottype.AccessibleName = null;
            resources.ApplyResources(this.tblottype, "tblottype");
            this.tblottype.BackgroundImage = null;
            this.tblottype.Font = null;
            this.tblottype.Name = "tblottype";
            this.toolTip1.SetToolTip(this.tblottype, resources.GetString("tblottype.ToolTip"));
            // 
            // label65
            // 
            this.label65.AccessibleDescription = null;
            this.label65.AccessibleName = null;
            resources.ApplyResources(this.label65, "label65");
            this.label65.Name = "label65";
            this.toolTip1.SetToolTip(this.label65, resources.GetString("label65.ToolTip"));
            // 
            // tbsimname
            // 
            this.tbsimname.AccessibleDescription = null;
            this.tbsimname.AccessibleName = null;
            resources.ApplyResources(this.tbsimname, "tbsimname");
            this.tbsimname.BackgroundImage = null;
            this.tbsimname.Font = null;
            this.tbsimname.Name = "tbsimname";
            this.toolTip1.SetToolTip(this.tbsimname, resources.GetString("tbsimname.ToolTip"));
            // 
            // label9
            // 
            this.label9.AccessibleDescription = null;
            this.label9.AccessibleName = null;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // tbsimid
            // 
            this.tbsimid.AccessibleDescription = null;
            this.tbsimid.AccessibleName = null;
            resources.ApplyResources(this.tbsimid, "tbsimid");
            this.tbsimid.BackgroundImage = null;
            this.tbsimid.Font = null;
            this.tbsimid.Name = "tbsimid";
            this.toolTip1.SetToolTip(this.tbsimid, resources.GetString("tbsimid.ToolTip"));
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // panel6
            // 
            this.panel6.AccessibleDescription = null;
            this.panel6.AccessibleName = null;
            resources.ApplyResources(this.panel6, "panel6");
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.BackgroundImage = null;
            this.panel6.Controls.Add(this.label12);
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Name = "panel6";
            this.toolTip1.SetToolTip(this.panel6, resources.GetString("panel6.ToolTip"));
            // 
            // label12
            // 
            this.label12.AccessibleDescription = null;
            this.label12.AccessibleName = null;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Font = null;
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleDescription = null;
            this.tabControl1.AccessibleName = null;
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.BackgroundImage = null;
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = null;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
            // 
            // tabPage4
            // 
            this.tabPage4.AccessibleDescription = null;
            this.tabPage4.AccessibleName = null;
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.BackgroundImage = null;
            this.tabPage4.Controls.Add(this.familytiePanel);
            this.tabPage4.Font = null;
            this.tabPage4.Name = "tabPage4";
            this.toolTip1.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
            // 
            // familytiePanel
            // 
            this.familytiePanel.AccessibleDescription = null;
            this.familytiePanel.AccessibleName = null;
            resources.ApplyResources(this.familytiePanel, "familytiePanel");
            this.familytiePanel.BackgroundImage = null;
            this.familytiePanel.Controls.Add(this.gbties);
            this.familytiePanel.Controls.Add(this.cbtiesims);
            this.familytiePanel.Controls.Add(this.bttiecommit);
            this.familytiePanel.Controls.Add(this.label64);
            this.familytiePanel.Controls.Add(this.panel8);
            this.familytiePanel.Font = null;
            this.familytiePanel.Name = "familytiePanel";
            this.toolTip1.SetToolTip(this.familytiePanel, resources.GetString("familytiePanel.ToolTip"));
            // 
            // gbties
            // 
            this.gbties.AccessibleDescription = null;
            this.gbties.AccessibleName = null;
            resources.ApplyResources(this.gbties, "gbties");
            this.gbties.BackgroundImage = null;
            this.gbties.Controls.Add(this.btnewtie);
            this.gbties.Controls.Add(this.cballtieablesims);
            this.gbties.Controls.Add(this.cbtietype);
            this.gbties.Controls.Add(this.lbties);
            this.gbties.Controls.Add(this.btdeletetie);
            this.gbties.Controls.Add(this.btaddtie);
            this.gbties.Controls.Add(this.llcommitties);
            this.gbties.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbties.Name = "gbties";
            this.gbties.TabStop = false;
            this.toolTip1.SetToolTip(this.gbties, resources.GetString("gbties.ToolTip"));
            // 
            // btnewtie
            // 
            this.btnewtie.AccessibleDescription = null;
            this.btnewtie.AccessibleName = null;
            resources.ApplyResources(this.btnewtie, "btnewtie");
            this.btnewtie.BackgroundImage = null;
            this.btnewtie.Name = "btnewtie";
            this.toolTip1.SetToolTip(this.btnewtie, resources.GetString("btnewtie.ToolTip"));
            this.btnewtie.Click += new System.EventHandler(this.AddSimToTiesClick);
            // 
            // cballtieablesims
            // 
            this.cballtieablesims.AccessibleDescription = null;
            this.cballtieablesims.AccessibleName = null;
            resources.ApplyResources(this.cballtieablesims, "cballtieablesims");
            this.cballtieablesims.BackgroundImage = null;
            this.cballtieablesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cballtieablesims.Name = "cballtieablesims";
            this.toolTip1.SetToolTip(this.cballtieablesims, resources.GetString("cballtieablesims.ToolTip"));
            this.cballtieablesims.SelectedIndexChanged += new System.EventHandler(this.AllTieableSimsIndexChanged);
            // 
            // cbtietype
            // 
            this.cbtietype.AccessibleDescription = null;
            this.cbtietype.AccessibleName = null;
            resources.ApplyResources(this.cbtietype, "cbtietype");
            this.cbtietype.BackgroundImage = null;
            this.cbtietype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtietype.Name = "cbtietype";
            this.toolTip1.SetToolTip(this.cbtietype, resources.GetString("cbtietype.ToolTip"));
            // 
            // lbties
            // 
            this.lbties.AccessibleDescription = null;
            this.lbties.AccessibleName = null;
            resources.ApplyResources(this.lbties, "lbties");
            this.lbties.BackgroundImage = null;
            this.lbties.Name = "lbties";
            this.toolTip1.SetToolTip(this.lbties, resources.GetString("lbties.ToolTip"));
            this.lbties.SelectedIndexChanged += new System.EventHandler(this.TieIndexChanged);
            // 
            // btdeletetie
            // 
            this.btdeletetie.AccessibleDescription = null;
            this.btdeletetie.AccessibleName = null;
            resources.ApplyResources(this.btdeletetie, "btdeletetie");
            this.btdeletetie.BackgroundImage = null;
            this.btdeletetie.Name = "btdeletetie";
            this.toolTip1.SetToolTip(this.btdeletetie, resources.GetString("btdeletetie.ToolTip"));
            this.btdeletetie.Click += new System.EventHandler(this.DeleteTieClick);
            // 
            // btaddtie
            // 
            this.btaddtie.AccessibleDescription = null;
            this.btaddtie.AccessibleName = null;
            resources.ApplyResources(this.btaddtie, "btaddtie");
            this.btaddtie.BackgroundImage = null;
            this.btaddtie.Name = "btaddtie";
            this.toolTip1.SetToolTip(this.btaddtie, resources.GetString("btaddtie.ToolTip"));
            this.btaddtie.Click += new System.EventHandler(this.AddTieClick);
            // 
            // llcommitties
            // 
            this.llcommitties.AccessibleDescription = null;
            this.llcommitties.AccessibleName = null;
            resources.ApplyResources(this.llcommitties, "llcommitties");
            this.llcommitties.Font = null;
            this.llcommitties.Name = "llcommitties";
            this.llcommitties.TabStop = true;
            this.toolTip1.SetToolTip(this.llcommitties, resources.GetString("llcommitties.ToolTip"));
            this.llcommitties.UseCompatibleTextRendering = true;
            this.llcommitties.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitSimTieClicked);
            // 
            // cbtiesims
            // 
            this.cbtiesims.AccessibleDescription = null;
            this.cbtiesims.AccessibleName = null;
            resources.ApplyResources(this.cbtiesims, "cbtiesims");
            this.cbtiesims.BackgroundImage = null;
            this.cbtiesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtiesims.Font = null;
            this.cbtiesims.Name = "cbtiesims";
            this.toolTip1.SetToolTip(this.cbtiesims, resources.GetString("cbtiesims.ToolTip"));
            this.cbtiesims.SelectedIndexChanged += new System.EventHandler(this.FamilyTieSimIndexChanged);
            // 
            // bttiecommit
            // 
            this.bttiecommit.AccessibleDescription = null;
            this.bttiecommit.AccessibleName = null;
            resources.ApplyResources(this.bttiecommit, "bttiecommit");
            this.bttiecommit.BackgroundImage = null;
            this.bttiecommit.Font = null;
            this.bttiecommit.Name = "bttiecommit";
            this.toolTip1.SetToolTip(this.bttiecommit, resources.GetString("bttiecommit.ToolTip"));
            this.bttiecommit.Click += new System.EventHandler(this.CommitTieClick);
            // 
            // label64
            // 
            this.label64.AccessibleDescription = null;
            this.label64.AccessibleName = null;
            resources.ApplyResources(this.label64, "label64");
            this.label64.Name = "label64";
            this.toolTip1.SetToolTip(this.label64, resources.GetString("label64.ToolTip"));
            // 
            // panel8
            // 
            this.panel8.AccessibleDescription = null;
            this.panel8.AccessibleName = null;
            resources.ApplyResources(this.panel8, "panel8");
            this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel8.BackgroundImage = null;
            this.panel8.Controls.Add(this.label68);
            this.panel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel8.Name = "panel8";
            this.toolTip1.SetToolTip(this.panel8, resources.GetString("panel8.ToolTip"));
            // 
            // label68
            // 
            this.label68.AccessibleDescription = null;
            this.label68.AccessibleName = null;
            resources.ApplyResources(this.label68, "label68");
            this.label68.Font = null;
            this.label68.Name = "label68";
            this.toolTip1.SetToolTip(this.label68, resources.GetString("label68.ToolTip"));
            // 
            // tabPage1
            // 
            this.tabPage1.AccessibleDescription = null;
            this.tabPage1.AccessibleName = null;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.BackgroundImage = null;
            this.tabPage1.Controls.Add(this.famiPanel);
            this.tabPage1.Font = null;
            this.tabPage1.Name = "tabPage1";
            this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
            // 
            // famiPanel
            // 
            this.famiPanel.AccessibleDescription = null;
            this.famiPanel.AccessibleName = null;
            resources.ApplyResources(this.famiPanel, "famiPanel");
            this.famiPanel.BackgroundImage = null;
            this.famiPanel.Controls.Add(this.tbbmoney);
            this.famiPanel.Controls.Add(this.label16);
            this.famiPanel.Controls.Add(this.tbblot);
            this.famiPanel.Controls.Add(this.label14);
            this.famiPanel.Controls.Add(this.gbCastaway);
            this.famiPanel.Controls.Add(this.tbvac);
            this.famiPanel.Controls.Add(this.label7);
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
            this.famiPanel.Font = null;
            this.famiPanel.Name = "famiPanel";
            this.toolTip1.SetToolTip(this.famiPanel, resources.GetString("famiPanel.ToolTip"));
            // 
            // tbbmoney
            // 
            resources.ApplyResources(this.tbbmoney, "tbbmoney");
            this.tbbmoney.AccessibleName = null;
            this.tbbmoney.BackgroundImage = null;
            this.tbbmoney.Font = null;
            this.tbbmoney.Name = "tbbmoney";
            this.toolTip1.SetToolTip(this.tbbmoney, resources.GetString("tbbmoney.ToolTip"));
            this.tbbmoney.TextChanged += new System.EventHandler(this.ChangedBMoney);
            // 
            // label16
            // 
            this.label16.AccessibleDescription = null;
            this.label16.AccessibleName = null;
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
            // 
            // tbblot
            // 
            this.tbblot.AccessibleDescription = null;
            this.tbblot.AccessibleName = null;
            resources.ApplyResources(this.tbblot, "tbblot");
            this.tbblot.BackgroundImage = null;
            this.tbblot.Font = null;
            this.tbblot.Name = "tbblot";
            this.toolTip1.SetToolTip(this.tbblot, resources.GetString("tbblot.ToolTip"));
            // 
            // label14
            // 
            this.label14.AccessibleDescription = null;
            this.label14.AccessibleName = null;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // gbCastaway
            // 
            this.gbCastaway.AccessibleDescription = null;
            this.gbCastaway.AccessibleName = null;
            resources.ApplyResources(this.gbCastaway, "gbCastaway");
            this.gbCastaway.BackgroundImage = null;
            this.gbCastaway.Controls.Add(this.tbcaunk);
            this.gbCastaway.Controls.Add(this.label13);
            this.gbCastaway.Controls.Add(this.tbcares);
            this.gbCastaway.Controls.Add(this.label11);
            this.gbCastaway.Controls.Add(this.tbcafood1);
            this.gbCastaway.Controls.Add(this.label10);
            this.gbCastaway.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCastaway.Name = "gbCastaway";
            this.gbCastaway.TabStop = false;
            this.toolTip1.SetToolTip(this.gbCastaway, resources.GetString("gbCastaway.ToolTip"));
            // 
            // tbcaunk
            // 
            this.tbcaunk.AccessibleDescription = null;
            this.tbcaunk.AccessibleName = null;
            resources.ApplyResources(this.tbcaunk, "tbcaunk");
            this.tbcaunk.BackgroundImage = null;
            this.tbcaunk.Name = "tbcaunk";
            this.toolTip1.SetToolTip(this.tbcaunk, resources.GetString("tbcaunk.ToolTip"));
            this.tbcaunk.TextChanged += new System.EventHandler(this.ChangedBMoney);
            // 
            // label13
            // 
            this.label13.AccessibleDescription = null;
            this.label13.AccessibleName = null;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // tbcares
            // 
            this.tbcares.AccessibleDescription = null;
            this.tbcares.AccessibleName = null;
            resources.ApplyResources(this.tbcares, "tbcares");
            this.tbcares.BackgroundImage = null;
            this.tbcares.Name = "tbcares";
            this.toolTip1.SetToolTip(this.tbcares, resources.GetString("tbcares.ToolTip"));
            // 
            // label11
            // 
            this.label11.AccessibleDescription = null;
            this.label11.AccessibleName = null;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // tbcafood1
            // 
            this.tbcafood1.AccessibleDescription = null;
            this.tbcafood1.AccessibleName = null;
            resources.ApplyResources(this.tbcafood1, "tbcafood1");
            this.tbcafood1.BackgroundImage = null;
            this.tbcafood1.Name = "tbcafood1";
            this.toolTip1.SetToolTip(this.tbcafood1, resources.GetString("tbcafood1.ToolTip"));
            this.tbcafood1.TextChanged += new System.EventHandler(this.ChangedMoney);
            // 
            // label10
            // 
            this.label10.AccessibleDescription = null;
            this.label10.AccessibleName = null;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // tbvac
            // 
            this.tbvac.AccessibleDescription = null;
            this.tbvac.AccessibleName = null;
            resources.ApplyResources(this.tbvac, "tbvac");
            this.tbvac.BackgroundImage = null;
            this.tbvac.Font = null;
            this.tbvac.Name = "tbvac";
            this.toolTip1.SetToolTip(this.tbvac, resources.GetString("tbvac.ToolTip"));
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // tbsubhood
            // 
            this.tbsubhood.AccessibleDescription = null;
            this.tbsubhood.AccessibleName = null;
            resources.ApplyResources(this.tbsubhood, "tbsubhood");
            this.tbsubhood.BackgroundImage = null;
            this.tbsubhood.Font = null;
            this.tbsubhood.Name = "tbsubhood";
            this.toolTip1.SetToolTip(this.tbsubhood, resources.GetString("tbsubhood.ToolTip"));
            // 
            // label89
            // 
            this.label89.AccessibleDescription = null;
            this.label89.AccessibleName = null;
            resources.ApplyResources(this.label89, "label89");
            this.label89.Name = "label89";
            this.toolTip1.SetToolTip(this.label89, resources.GetString("label89.ToolTip"));
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = null;
            this.groupBox4.AccessibleName = null;
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackgroundImage = null;
            this.groupBox4.Controls.Add(this.cbcomputer);
            this.groupBox4.Controls.Add(this.cblot);
            this.groupBox4.Controls.Add(this.cbbaby);
            this.groupBox4.Controls.Add(this.cbphone);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // cbcomputer
            // 
            this.cbcomputer.AccessibleDescription = null;
            this.cbcomputer.AccessibleName = null;
            resources.ApplyResources(this.cbcomputer, "cbcomputer");
            this.cbcomputer.BackgroundImage = null;
            this.cbcomputer.Name = "cbcomputer";
            this.toolTip1.SetToolTip(this.cbcomputer, resources.GetString("cbcomputer.ToolTip"));
            this.cbcomputer.CheckedChanged += new System.EventHandler(this.ChangeFlags);
            // 
            // cblot
            // 
            this.cblot.AccessibleDescription = null;
            this.cblot.AccessibleName = null;
            resources.ApplyResources(this.cblot, "cblot");
            this.cblot.BackgroundImage = null;
            this.cblot.Name = "cblot";
            this.toolTip1.SetToolTip(this.cblot, resources.GetString("cblot.ToolTip"));
            this.cblot.CheckedChanged += new System.EventHandler(this.ChangeFlags);
            // 
            // cbbaby
            // 
            this.cbbaby.AccessibleDescription = null;
            this.cbbaby.AccessibleName = null;
            resources.ApplyResources(this.cbbaby, "cbbaby");
            this.cbbaby.BackgroundImage = null;
            this.cbbaby.Name = "cbbaby";
            this.toolTip1.SetToolTip(this.cbbaby, resources.GetString("cbbaby.ToolTip"));
            this.cbbaby.CheckedChanged += new System.EventHandler(this.ChangeFlags);
            // 
            // cbphone
            // 
            this.cbphone.AccessibleDescription = null;
            this.cbphone.AccessibleName = null;
            resources.ApplyResources(this.cbphone, "cbphone");
            this.cbphone.BackgroundImage = null;
            this.cbphone.Name = "cbphone";
            this.toolTip1.SetToolTip(this.cbphone, resources.GetString("cbphone.ToolTip"));
            this.cbphone.CheckedChanged += new System.EventHandler(this.ChangeFlags);
            // 
            // tbalbum
            // 
            this.tbalbum.AccessibleDescription = null;
            this.tbalbum.AccessibleName = null;
            resources.ApplyResources(this.tbalbum, "tbalbum");
            this.tbalbum.BackgroundImage = null;
            this.tbalbum.Font = null;
            this.tbalbum.Name = "tbalbum";
            this.toolTip1.SetToolTip(this.tbalbum, resources.GetString("tbalbum.ToolTip"));
            // 
            // label93
            // 
            this.label93.AccessibleDescription = null;
            this.label93.AccessibleName = null;
            resources.ApplyResources(this.label93, "label93");
            this.label93.Name = "label93";
            this.toolTip1.SetToolTip(this.label93, resources.GetString("label93.ToolTip"));
            // 
            // tbflag
            // 
            this.tbflag.AccessibleDescription = null;
            this.tbflag.AccessibleName = null;
            resources.ApplyResources(this.tbflag, "tbflag");
            this.tbflag.BackgroundImage = null;
            this.tbflag.Font = null;
            this.tbflag.Name = "tbflag";
            this.toolTip1.SetToolTip(this.tbflag, resources.GetString("tbflag.ToolTip"));
            this.tbflag.TextChanged += new System.EventHandler(this.FlagChanged);
            // 
            // label92
            // 
            this.label92.AccessibleDescription = null;
            this.label92.AccessibleName = null;
            resources.ApplyResources(this.label92, "label92");
            this.label92.Name = "label92";
            this.toolTip1.SetToolTip(this.label92, resources.GetString("label92.ToolTip"));
            // 
            // tblotinst
            // 
            this.tblotinst.AccessibleDescription = null;
            this.tblotinst.AccessibleName = null;
            resources.ApplyResources(this.tblotinst, "tblotinst");
            this.tblotinst.BackgroundImage = null;
            this.tblotinst.Font = null;
            this.tblotinst.Name = "tblotinst";
            this.toolTip1.SetToolTip(this.tblotinst, resources.GetString("tblotinst.ToolTip"));
            // 
            // llFamiDeleteSim
            // 
            this.llFamiDeleteSim.AccessibleDescription = null;
            this.llFamiDeleteSim.AccessibleName = null;
            resources.ApplyResources(this.llFamiDeleteSim, "llFamiDeleteSim");
            this.llFamiDeleteSim.BackgroundImage = null;
            this.llFamiDeleteSim.Font = null;
            this.llFamiDeleteSim.Name = "llFamiDeleteSim";
            this.toolTip1.SetToolTip(this.llFamiDeleteSim, resources.GetString("llFamiDeleteSim.ToolTip"));
            this.llFamiDeleteSim.Click += new System.EventHandler(this.FamiDeleteSimClick);
            // 
            // llFamiAddSim
            // 
            this.llFamiAddSim.AccessibleDescription = null;
            this.llFamiAddSim.AccessibleName = null;
            resources.ApplyResources(this.llFamiAddSim, "llFamiAddSim");
            this.llFamiAddSim.BackgroundImage = null;
            this.llFamiAddSim.Font = null;
            this.llFamiAddSim.Name = "llFamiAddSim";
            this.toolTip1.SetToolTip(this.llFamiAddSim, resources.GetString("llFamiAddSim.ToolTip"));
            this.llFamiAddSim.Click += new System.EventHandler(this.FamiSimAddClick);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = null;
            this.button1.AccessibleName = null;
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = null;
            this.button1.Font = null;
            this.button1.Name = "button1";
            this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.Click += new System.EventHandler(this.CommitFamiClick);
            // 
            // cbsims
            // 
            this.cbsims.AccessibleDescription = null;
            this.cbsims.AccessibleName = null;
            resources.ApplyResources(this.cbsims, "cbsims");
            this.cbsims.BackgroundImage = null;
            this.cbsims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsims.Font = null;
            this.cbsims.Name = "cbsims";
            this.toolTip1.SetToolTip(this.cbsims, resources.GetString("cbsims.ToolTip"));
            this.cbsims.SelectedIndexChanged += new System.EventHandler(this.SimSelectionChange);
            // 
            // lbmembers
            // 
            this.lbmembers.AccessibleDescription = null;
            this.lbmembers.AccessibleName = null;
            resources.ApplyResources(this.lbmembers, "lbmembers");
            this.lbmembers.BackgroundImage = null;
            this.lbmembers.Font = null;
            this.lbmembers.Name = "lbmembers";
            this.toolTip1.SetToolTip(this.lbmembers, resources.GetString("lbmembers.ToolTip"));
            this.lbmembers.SelectedIndexChanged += new System.EventHandler(this.FamiMemberSelectionClick);
            // 
            // tbname
            // 
            this.tbname.AccessibleDescription = null;
            this.tbname.AccessibleName = null;
            resources.ApplyResources(this.tbname, "tbname");
            this.tbname.BackgroundImage = null;
            this.tbname.Font = null;
            this.tbname.Name = "tbname";
            this.toolTip1.SetToolTip(this.tbname, resources.GetString("tbname.ToolTip"));
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // tbfamily
            // 
            this.tbfamily.AccessibleDescription = null;
            this.tbfamily.AccessibleName = null;
            resources.ApplyResources(this.tbfamily, "tbfamily");
            this.tbfamily.BackgroundImage = null;
            this.tbfamily.Font = null;
            this.tbfamily.Name = "tbfamily";
            this.toolTip1.SetToolTip(this.tbfamily, resources.GetString("tbfamily.ToolTip"));
            // 
            // tbmoney
            // 
            this.tbmoney.AccessibleDescription = null;
            this.tbmoney.AccessibleName = null;
            resources.ApplyResources(this.tbmoney, "tbmoney");
            this.tbmoney.BackgroundImage = null;
            this.tbmoney.Font = null;
            this.tbmoney.Name = "tbmoney";
            this.toolTip1.SetToolTip(this.tbmoney, resources.GetString("tbmoney.ToolTip"));
            this.tbmoney.TextChanged += new System.EventHandler(this.ChangedMoney);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = null;
            this.panel4.AccessibleName = null;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.BackgroundImage = null;
            this.panel4.Controls.Add(this.label2);
            this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Name = "panel4";
            this.toolTip1.SetToolTip(this.panel4, resources.GetString("panel4.ToolTip"));
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Font = null;
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label15
            // 
            this.label15.AccessibleDescription = null;
            this.label15.AccessibleName = null;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.AccessibleDescription = null;
            this.tabPage3.AccessibleName = null;
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.BackgroundImage = null;
            this.tabPage3.Controls.Add(this.realPanel);
            this.tabPage3.Controls.Add(this.JpegPanel);
            this.tabPage3.Controls.Add(this.objdPanel);
            this.tabPage3.Controls.Add(this.xmlPanel);
            this.tabPage3.Name = "tabPage3";
            this.toolTip1.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
            // 
            // realPanel
            // 
            this.realPanel.AccessibleDescription = null;
            this.realPanel.AccessibleName = null;
            resources.ApplyResources(this.realPanel, "realPanel");
            this.realPanel.BackgroundImage = null;
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
            this.realPanel.Font = null;
            this.realPanel.Name = "realPanel";
            this.toolTip1.SetToolTip(this.realPanel, resources.GetString("realPanel.ToolTip"));
            // 
            // label91
            // 
            this.label91.AccessibleDescription = null;
            this.label91.AccessibleName = null;
            resources.ApplyResources(this.label91, "label91");
            this.label91.Name = "label91";
            this.toolTip1.SetToolTip(this.label91, resources.GetString("label91.ToolTip"));
            // 
            // cbfamtype
            // 
            this.cbfamtype.AccessibleDescription = null;
            this.cbfamtype.AccessibleName = null;
            resources.ApplyResources(this.cbfamtype, "cbfamtype");
            this.cbfamtype.BackgroundImage = null;
            this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbfamtype.Name = "cbfamtype";
            this.toolTip1.SetToolTip(this.cbfamtype, resources.GetString("cbfamtype.ToolTip"));
            // 
            // llsrelcommit
            // 
            this.llsrelcommit.AccessibleDescription = null;
            this.llsrelcommit.AccessibleName = null;
            resources.ApplyResources(this.llsrelcommit, "llsrelcommit");
            this.llsrelcommit.Name = "llsrelcommit";
            this.llsrelcommit.TabStop = true;
            this.toolTip1.SetToolTip(this.llsrelcommit, resources.GetString("llsrelcommit.ToolTip"));
            this.llsrelcommit.UseCompatibleTextRendering = true;
            this.llsrelcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RelationshipFileCommit);
            // 
            // gbrelation
            // 
            this.gbrelation.AccessibleDescription = null;
            this.gbrelation.AccessibleName = null;
            resources.ApplyResources(this.gbrelation, "gbrelation");
            this.gbrelation.BackgroundImage = null;
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
            this.gbrelation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbrelation.Name = "gbrelation";
            this.gbrelation.TabStop = false;
            this.toolTip1.SetToolTip(this.gbrelation, resources.GetString("gbrelation.ToolTip"));
            // 
            // cbbest
            // 
            this.cbbest.AccessibleDescription = null;
            this.cbbest.AccessibleName = null;
            resources.ApplyResources(this.cbbest, "cbbest");
            this.cbbest.BackgroundImage = null;
            this.cbbest.Name = "cbbest";
            this.toolTip1.SetToolTip(this.cbbest, resources.GetString("cbbest.ToolTip"));
            // 
            // cbfamily
            // 
            this.cbfamily.AccessibleDescription = null;
            this.cbfamily.AccessibleName = null;
            resources.ApplyResources(this.cbfamily, "cbfamily");
            this.cbfamily.BackgroundImage = null;
            this.cbfamily.Name = "cbfamily";
            this.toolTip1.SetToolTip(this.cbfamily, resources.GetString("cbfamily.ToolTip"));
            // 
            // cbmarried
            // 
            this.cbmarried.AccessibleDescription = null;
            this.cbmarried.AccessibleName = null;
            resources.ApplyResources(this.cbmarried, "cbmarried");
            this.cbmarried.BackgroundImage = null;
            this.cbmarried.Name = "cbmarried";
            this.toolTip1.SetToolTip(this.cbmarried, resources.GetString("cbmarried.ToolTip"));
            // 
            // cbengaged
            // 
            this.cbengaged.AccessibleDescription = null;
            this.cbengaged.AccessibleName = null;
            resources.ApplyResources(this.cbengaged, "cbengaged");
            this.cbengaged.BackgroundImage = null;
            this.cbengaged.Name = "cbengaged";
            this.toolTip1.SetToolTip(this.cbengaged, resources.GetString("cbengaged.ToolTip"));
            // 
            // cbsteady
            // 
            this.cbsteady.AccessibleDescription = null;
            this.cbsteady.AccessibleName = null;
            resources.ApplyResources(this.cbsteady, "cbsteady");
            this.cbsteady.BackgroundImage = null;
            this.cbsteady.Name = "cbsteady";
            this.toolTip1.SetToolTip(this.cbsteady, resources.GetString("cbsteady.ToolTip"));
            // 
            // cblove
            // 
            this.cblove.AccessibleDescription = null;
            this.cblove.AccessibleName = null;
            resources.ApplyResources(this.cblove, "cblove");
            this.cblove.BackgroundImage = null;
            this.cblove.Name = "cblove";
            this.toolTip1.SetToolTip(this.cblove, resources.GetString("cblove.ToolTip"));
            // 
            // cbcrush
            // 
            this.cbcrush.AccessibleDescription = null;
            this.cbcrush.AccessibleName = null;
            resources.ApplyResources(this.cbcrush, "cbcrush");
            this.cbcrush.BackgroundImage = null;
            this.cbcrush.Name = "cbcrush";
            this.toolTip1.SetToolTip(this.cbcrush, resources.GetString("cbcrush.ToolTip"));
            // 
            // cbbuddie
            // 
            this.cbbuddie.AccessibleDescription = null;
            this.cbbuddie.AccessibleName = null;
            resources.ApplyResources(this.cbbuddie, "cbbuddie");
            this.cbbuddie.BackgroundImage = null;
            this.cbbuddie.Name = "cbbuddie";
            this.toolTip1.SetToolTip(this.cbbuddie, resources.GetString("cbbuddie.ToolTip"));
            // 
            // cbfriend
            // 
            this.cbfriend.AccessibleDescription = null;
            this.cbfriend.AccessibleName = null;
            resources.ApplyResources(this.cbfriend, "cbfriend");
            this.cbfriend.BackgroundImage = null;
            this.cbfriend.Name = "cbfriend";
            this.toolTip1.SetToolTip(this.cbfriend, resources.GetString("cbfriend.ToolTip"));
            // 
            // cbenemy
            // 
            this.cbenemy.AccessibleDescription = null;
            this.cbenemy.AccessibleName = null;
            resources.ApplyResources(this.cbenemy, "cbenemy");
            this.cbenemy.BackgroundImage = null;
            this.cbenemy.Name = "cbenemy";
            this.toolTip1.SetToolTip(this.cbenemy, resources.GetString("cbenemy.ToolTip"));
            // 
            // tblongterm
            // 
            this.tblongterm.AccessibleDescription = null;
            this.tblongterm.AccessibleName = null;
            resources.ApplyResources(this.tblongterm, "tblongterm");
            this.tblongterm.BackgroundImage = null;
            this.tblongterm.Font = null;
            this.tblongterm.Name = "tblongterm";
            this.toolTip1.SetToolTip(this.tblongterm, resources.GetString("tblongterm.ToolTip"));
            // 
            // tbshortterm
            // 
            this.tbshortterm.AccessibleDescription = null;
            this.tbshortterm.AccessibleName = null;
            resources.ApplyResources(this.tbshortterm, "tbshortterm");
            this.tbshortterm.BackgroundImage = null;
            this.tbshortterm.Font = null;
            this.tbshortterm.Name = "tbshortterm";
            this.toolTip1.SetToolTip(this.tbshortterm, resources.GetString("tbshortterm.ToolTip"));
            // 
            // label57
            // 
            this.label57.AccessibleDescription = null;
            this.label57.AccessibleName = null;
            resources.ApplyResources(this.label57, "label57");
            this.label57.Name = "label57";
            this.toolTip1.SetToolTip(this.label57, resources.GetString("label57.ToolTip"));
            // 
            // label58
            // 
            this.label58.AccessibleDescription = null;
            this.label58.AccessibleName = null;
            resources.ApplyResources(this.label58, "label58");
            this.label58.Name = "label58";
            this.toolTip1.SetToolTip(this.label58, resources.GetString("label58.ToolTip"));
            // 
            // panel7
            // 
            this.panel7.AccessibleDescription = null;
            this.panel7.AccessibleName = null;
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel7.BackgroundImage = null;
            this.panel7.Controls.Add(this.label56);
            this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Name = "panel7";
            this.toolTip1.SetToolTip(this.panel7, resources.GetString("panel7.ToolTip"));
            // 
            // label56
            // 
            this.label56.AccessibleDescription = null;
            this.label56.AccessibleName = null;
            resources.ApplyResources(this.label56, "label56");
            this.label56.Font = null;
            this.label56.Name = "label56";
            this.toolTip1.SetToolTip(this.label56, resources.GetString("label56.ToolTip"));
            // 
            // llrelcommit
            // 
            this.llrelcommit.AccessibleDescription = null;
            this.llrelcommit.AccessibleName = null;
            resources.ApplyResources(this.llrelcommit, "llrelcommit");
            this.llrelcommit.Font = null;
            this.llrelcommit.Name = "llrelcommit";
            this.toolTip1.SetToolTip(this.llrelcommit, resources.GetString("llrelcommit.ToolTip"));
            // 
            // Elements
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.tabControl1);
            this.Font = null;
            this.Icon = null;
            this.Name = "Elements";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.JpegPanel.ResumeLayout(false);
            this.JpegPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.xmlPanel.ResumeLayout(false);
            this.xmlPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.objdPanel.ResumeLayout(false);
            this.objdPanel.PerformLayout();
            this.gbelements.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.familytiePanel.ResumeLayout(false);
            this.familytiePanel.PerformLayout();
            this.gbties.ResumeLayout(false);
            this.gbties.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.famiPanel.ResumeLayout(false);
            this.famiPanel.PerformLayout();
            this.gbCastaway.ResumeLayout(false);
            this.gbCastaway.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.realPanel.ResumeLayout(false);
            this.realPanel.PerformLayout();
            this.gbrelation.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
                    fami.VacationLotInstance = Helper.StringToUInt32(tbvac.Text, fami.VacationLotInstance, 16);
                    fami.CurrentlyOnLotInstance = Helper.StringToUInt32(tbblot.Text, fami.CurrentlyOnLotInstance, 16);
                    fami.BusinessMoney = Helper.StringToInt32(this.tbbmoney.Text, fami.BusinessMoney, 10);

                    fami.CastAwayFood = Helper.StringToInt32(this.tbcafood1.Text, fami.CastAwayFood, 10);
                    fami.CastAwayResources = Helper.StringToInt32(tbcares.Text, fami.CastAwayResources, 10);
                    fami.CastAwayUnk = Helper.StringToInt32(tbcaunk.Text, fami.CastAwayUnk, 16);

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
					MessageBox.Show(Localization.Manager.GetString("commited"));
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        bool intern = false;
        private void ChangedMoney(object sender, EventArgs e)
        {
            if (intern) return;
            intern = true;
            SimPe.PackedFiles.Wrapper.Fami fami = (Wrapper.Fami)wrapper;
            TextBox tb = (TextBox)sender;
            fami.Money = Helper.StringToInt32(tb.Text, fami.Money, 10);
            fami.CastAwayFood = fami.Money;

            if (tb!=tbmoney) tbmoney.Text = fami.Money.ToString();
            if (tb != tbcafood1) tbcafood1.Text = fami.CastAwayFood.ToString();
            intern = false;
        }

        private void ChangedBMoney(object sender, EventArgs e)
        {
            if (intern) return;
            intern = true;
            SimPe.PackedFiles.Wrapper.Fami fami = (Wrapper.Fami)wrapper;
            TextBox tb = (TextBox)sender;
            fami.BusinessMoney = Helper.StringToInt32(tb.Text, fami.BusinessMoney, 10);
            fami.CastAwayUnk = fami.BusinessMoney;

            if (tb != tbbmoney) tbbmoney.Text = fami.BusinessMoney.ToString();
            if (tb != tbcaunk) tbcaunk.Text = fami.CastAwayUnk.ToString();
            intern = false;
        }

		

		

	}
}
