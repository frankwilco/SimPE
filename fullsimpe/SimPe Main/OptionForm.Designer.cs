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

namespace SimPe
{
    partial class OptionForm
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbgame;
        private System.Windows.Forms.LinkLabel label2;
        private System.Windows.Forms.TextBox tbsavegame;
        private System.Windows.Forms.CheckBox cbdebug;
        private System.Windows.Forms.CheckBox cbblur;
        private System.Windows.Forms.CheckBox cbsound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbext;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox tbdds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.TextBox tbep1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbautobak;
        private System.Windows.Forms.CheckBox cbcache;
        private System.Windows.Forms.ComboBox cblang;
        private System.Windows.Forms.CheckBox cbow;
        private System.Windows.Forms.CheckBox cbsilent;
        private System.Windows.Forms.CheckBox cbwait;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox tbthumb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbshowobjd;
        private System.Windows.Forms.LinkLabel lldds2;
        private System.Windows.Forms.Label lldds;
        private System.Windows.Forms.LinkLabel lladd;
        private System.Windows.Forms.LinkLabel lldel;
        private System.Windows.Forms.LinkLabel lladddown;
        private System.Windows.Forms.LinkLabel llsetep1;
        private System.Windows.Forms.CheckBox cbhidden;
        private System.Windows.Forms.CheckBox cbjointname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbscale;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbupdate;
        private System.Windows.Forms.CheckBox cbpkgmaint;
        private TD.Eyefinder.HeaderControl hcFolders;
        private TD.Eyefinder.HeaderControl hcSettings;
        private TD.Eyefinder.HeaderControl hcTools;
        private TD.Eyefinder.HeaderControl hcFileTable;
        private TD.Eyefinder.HeaderControl hcSceneGraph;
        private Divelements.Navisight.NavigationButton nbFolders;
        private Divelements.Navisight.NavigationButton nbSettings;
        private Divelements.Navisight.NavigationButton nbTools;
        private Divelements.Navisight.NavigationButton nbFileTable;
        private Divelements.Navisight.NavigationButton nbSceneGraph;
        private Divelements.Navisight.ButtonBar bb;
        private System.Windows.Forms.CheckBox cbmulti;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbThemes;
        private SteepValley.Windows.Forms.XPBalloonTip baloonTip;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.CheckBox cbSimple;
        private TD.Eyefinder.HeaderControl hcPlugins;
        private Divelements.Navisight.NavigationButton navigationButton1;
        private Divelements.Navisight.NavigationButton navigationButton2;
        private Divelements.Navisight.NavigationButton nbPlugins;
        private System.Windows.Forms.Panel cnt;
        private System.Windows.Forms.Button btdn;
        private System.Windows.Forms.Button btup;
        private System.Windows.Forms.Button btpup;
        private System.Windows.Forms.Button btpdown;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cbFirefox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cbDeep;
        private System.Windows.Forms.CheckBox cbAsync;
        private TD.Eyefinder.HeaderControl hcIdent;
        private Divelements.Navisight.NavigationButton nbIdent;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.CheckBox cbValid;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.Button btNightlife;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.LinkLabel llNightlife;
        private System.Windows.Forms.TextBox tbep2;
        private System.Windows.Forms.LinkLabel llchg;
        private System.Windows.Forms.CheckBox cbSimTemp;
        private System.Windows.Forms.CheckedListBox lbfolder;
        private System.Windows.Forms.Button btReload;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox cbIncCep;

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbReport;
        private System.Windows.Forms.CheckBox cbLock;
        private MyPropertyGrid pgPaths;
        private Divelements.Navisight.NavigationButton nbCheck;
        private TD.Eyefinder.HeaderControl hcCheck;
        private SimPe.CheckControl checkControl1;
        private TD.Eyefinder.HeaderControl hcCustom;
        private Divelements.Navisight.NavigationButton nbCustom;
        private System.Windows.Forms.ComboBox cbCustom;
        private System.Windows.Forms.PropertyGrid pgcustom;
        private CheckBox cbsplash;
        private GroupBox groupBox10;
        private CheckBox cbAsyncSort;
        private Ambertation.Windows.Forms.EnumComboBox cbRLExt;
        private Label label17;
        private Ambertation.Windows.Forms.EnumComboBox cbRLTGI;
        private Label label16;
        private Ambertation.Windows.Forms.EnumComboBox cbRLNames;
        private Label label15;
        private System.ComponentModel.IContainer components;


        /// <summary>
        /// Die verwendeten Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code
        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.button1 = new System.Windows.Forms.Button();
            this.tbgame = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.LinkLabel();
            this.tbsavegame = new System.Windows.Forms.TextBox();
            this.cbdebug = new System.Windows.Forms.CheckBox();
            this.cbblur = new System.Windows.Forms.CheckBox();
            this.cbsound = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbext = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbdds = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tbep1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.llsetep1 = new System.Windows.Forms.LinkLabel();
            this.tbthumb = new System.Windows.Forms.TextBox();
            this.cbLock = new System.Windows.Forms.CheckBox();
            this.cbAsync = new System.Windows.Forms.CheckBox();
            this.cbhidden = new System.Windows.Forms.CheckBox();
            this.tbscale = new System.Windows.Forms.TextBox();
            this.llNightlife = new System.Windows.Forms.LinkLabel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.cbsplash = new System.Windows.Forms.CheckBox();
            this.lldds2 = new System.Windows.Forms.LinkLabel();
            this.lldds = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbow = new System.Windows.Forms.CheckBox();
            this.cbshowobjd = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbReport = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbpkgmaint = new System.Windows.Forms.CheckBox();
            this.cbupdate = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbautobak = new System.Windows.Forms.CheckBox();
            this.cbcache = new System.Windows.Forms.CheckBox();
            this.cblang = new System.Windows.Forms.ComboBox();
            this.cbsilent = new System.Windows.Forms.CheckBox();
            this.cbwait = new System.Windows.Forms.CheckBox();
            this.cbSimple = new System.Windows.Forms.CheckBox();
            this.cbmulti = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lladddown = new System.Windows.Forms.LinkLabel();
            this.lldel = new System.Windows.Forms.LinkLabel();
            this.lladd = new System.Windows.Forms.LinkLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbjointname = new System.Windows.Forms.CheckBox();
            this.hcFolders = new TD.Eyefinder.HeaderControl();
            this.pgPaths = new MyPropertyGrid();
            this.tbep2 = new System.Windows.Forms.TextBox();
            this.btNightlife = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.hcSettings = new TD.Eyefinder.HeaderControl();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbFirefox = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbThemes = new System.Windows.Forms.ComboBox();
            this.hcTools = new TD.Eyefinder.HeaderControl();
            this.hcFileTable = new TD.Eyefinder.HeaderControl();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.cbIncCep = new System.Windows.Forms.CheckBox();
            this.btReload = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btup = new System.Windows.Forms.Button();
            this.btdn = new System.Windows.Forms.Button();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.lbfolder = new System.Windows.Forms.CheckedListBox();
            this.llchg = new System.Windows.Forms.LinkLabel();
            this.hcSceneGraph = new TD.Eyefinder.HeaderControl();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.cbAsyncSort = new System.Windows.Forms.CheckBox();
            this.cbRLExt = new Ambertation.Windows.Forms.EnumComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cbRLTGI = new Ambertation.Windows.Forms.EnumComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbRLNames = new Ambertation.Windows.Forms.EnumComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbSimTemp = new System.Windows.Forms.CheckBox();
            this.cbDeep = new System.Windows.Forms.CheckBox();
            this.bb = new Divelements.Navisight.ButtonBar();
            this.nbFolders = new Divelements.Navisight.NavigationButton();
            this.nbCheck = new Divelements.Navisight.NavigationButton();
            this.nbSettings = new Divelements.Navisight.NavigationButton();
            this.nbSceneGraph = new Divelements.Navisight.NavigationButton();
            this.nbCustom = new Divelements.Navisight.NavigationButton();
            this.nbFileTable = new Divelements.Navisight.NavigationButton();
            this.nbPlugins = new Divelements.Navisight.NavigationButton();
            this.nbTools = new Divelements.Navisight.NavigationButton();
            this.nbIdent = new Divelements.Navisight.NavigationButton();
            this.hcPlugins = new TD.Eyefinder.HeaderControl();
            this.btpup = new System.Windows.Forms.Button();
            this.btpdown = new System.Windows.Forms.Button();
            this.cnt = new System.Windows.Forms.Panel();
            this.hcIdent = new TD.Eyefinder.HeaderControl();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.cbValid = new System.Windows.Forms.CheckBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.hcCheck = new TD.Eyefinder.HeaderControl();
            this.checkControl1 = new SimPe.CheckControl();
            this.hcCustom = new TD.Eyefinder.HeaderControl();
            this.pgcustom = new System.Windows.Forms.PropertyGrid();
            this.cbCustom = new System.Windows.Forms.ComboBox();
            this.baloonTip = new SteepValley.Windows.Forms.XPBalloonTip(this.components);
            this.navigationButton1 = new Divelements.Navisight.NavigationButton();
            this.navigationButton2 = new Divelements.Navisight.NavigationButton();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.hcFolders.SuspendLayout();
            this.hcSettings.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.hcTools.SuspendLayout();
            this.hcFileTable.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.hcSceneGraph.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.hcPlugins.SuspendLayout();
            this.hcIdent.SuspendLayout();
            this.hcCheck.SuspendLayout();
            this.hcCustom.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.SaveOptionsClick);
            // 
            // tbgame
            // 
            resources.ApplyResources(this.tbgame, "tbgame");
            this.tbgame.Name = "tbgame";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.TabStop = true;
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.UseCompatibleTextRendering = true;
            this.label2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label2_LinkClicked);
            // 
            // tbsavegame
            // 
            resources.ApplyResources(this.tbsavegame, "tbsavegame");
            this.tbsavegame.Name = "tbsavegame";
            // 
            // cbdebug
            // 
            resources.ApplyResources(this.cbdebug, "cbdebug");
            this.cbdebug.Name = "cbdebug";
            // 
            // cbblur
            // 
            resources.ApplyResources(this.cbblur, "cbblur");
            this.cbblur.Name = "cbblur";
            this.cbblur.CheckedChanged += new System.EventHandler(this.cbblur_CheckedChanged);
            // 
            // cbsound
            // 
            resources.ApplyResources(this.cbsound, "cbsound");
            this.cbsound.Name = "cbsound";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lbext
            // 
            resources.ApplyResources(this.lbext, "lbext");
            this.lbext.Name = "lbext";
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddExt);
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteExt);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbdds
            // 
            resources.ApplyResources(this.tbdds, "tbdds");
            this.tbdds.Name = "tbdds";
            this.tbdds.TextChanged += new System.EventHandler(this.DDSChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // ofd
            // 
            resources.ApplyResources(this.ofd, "ofd");
            // 
            // tbep1
            // 
            resources.ApplyResources(this.tbep1, "tbep1");
            this.tbep1.Name = "tbep1";
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // linkLabel4
            // 
            resources.ApplyResources(this.linkLabel4, "linkLabel4");
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel4, resources.GetString("linkLabel4.ToolTip"));
            this.linkLabel4.UseCompatibleTextRendering = true;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // llsetep1
            // 
            resources.ApplyResources(this.llsetep1, "llsetep1");
            this.llsetep1.Name = "llsetep1";
            this.llsetep1.TabStop = true;
            this.toolTip1.SetToolTip(this.llsetep1, resources.GetString("llsetep1.ToolTip"));
            this.llsetep1.UseCompatibleTextRendering = true;
            this.llsetep1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visualStyleLinkLabel1_LinkClicked);
            // 
            // tbthumb
            // 
            resources.ApplyResources(this.tbthumb, "tbthumb");
            this.tbthumb.Name = "tbthumb";
            this.toolTip1.SetToolTip(this.tbthumb, resources.GetString("tbthumb.ToolTip"));
            // 
            // cbLock
            // 
            resources.ApplyResources(this.cbLock, "cbLock");
            this.cbLock.Name = "cbLock";
            this.toolTip1.SetToolTip(this.cbLock, resources.GetString("cbLock.ToolTip"));
            this.cbLock.CheckedChanged += new System.EventHandler(this.cbLock_CheckedChanged);
            // 
            // cbAsync
            // 
            resources.ApplyResources(this.cbAsync, "cbAsync");
            this.cbAsync.Name = "cbAsync";
            this.toolTip1.SetToolTip(this.cbAsync, resources.GetString("cbAsync.ToolTip"));
            // 
            // cbhidden
            // 
            resources.ApplyResources(this.cbhidden, "cbhidden");
            this.cbhidden.Name = "cbhidden";
            this.toolTip1.SetToolTip(this.cbhidden, resources.GetString("cbhidden.ToolTip"));
            // 
            // tbscale
            // 
            resources.ApplyResources(this.tbscale, "tbscale");
            this.tbscale.Name = "tbscale";
            this.toolTip1.SetToolTip(this.tbscale, resources.GetString("tbscale.ToolTip"));
            // 
            // llNightlife
            // 
            resources.ApplyResources(this.llNightlife, "llNightlife");
            this.llNightlife.Name = "llNightlife";
            this.llNightlife.TabStop = true;
            this.toolTip1.SetToolTip(this.llNightlife, resources.GetString("llNightlife.ToolTip"));
            this.llNightlife.UseCompatibleTextRendering = true;
            this.llNightlife.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNightlife_LinkClicked);
            // 
            // button8
            // 
            resources.ApplyResources(this.button8, "button8");
            this.button8.Name = "button8";
            this.toolTip1.SetToolTip(this.button8, resources.GetString("button8.ToolTip"));
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.toolTip1.SetToolTip(this.button7, resources.GetString("button7.ToolTip"));
            this.button7.Click += new System.EventHandler(this.ResetLayoutClick);
            // 
            // cbsplash
            // 
            resources.ApplyResources(this.cbsplash, "cbsplash");
            this.cbsplash.Name = "cbsplash";
            this.toolTip1.SetToolTip(this.cbsplash, resources.GetString("cbsplash.ToolTip"));
            // 
            // lldds2
            // 
            this.lldds2.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.lldds2, "lldds2");
            this.lldds2.ForeColor = System.Drawing.Color.Gray;
            this.lldds2.LinkColor = System.Drawing.Color.Red;
            this.lldds2.Name = "lldds2";
            this.lldds2.TabStop = true;
            this.lldds2.UseCompatibleTextRendering = true;
            this.lldds2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadDDS);
            // 
            // lldds
            // 
            this.lldds.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.lldds, "lldds");
            this.lldds.ForeColor = System.Drawing.Color.Gray;
            this.lldds.Name = "lldds";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbow);
            this.groupBox3.Controls.Add(this.cbshowobjd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbthumb);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // cbow
            // 
            resources.ApplyResources(this.cbow, "cbow");
            this.cbow.Name = "cbow";
            // 
            // cbshowobjd
            // 
            resources.ApplyResources(this.cbshowobjd, "cbshowobjd");
            this.cbshowobjd.Name = "cbshowobjd";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.Name = "button6";
            this.button6.Click += new System.EventHandler(this.ClearCaches);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbsplash);
            this.groupBox2.Controls.Add(this.cbLock);
            this.groupBox2.Controls.Add(this.cbReport);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbpkgmaint);
            this.groupBox2.Controls.Add(this.cbupdate);
            this.groupBox2.Controls.Add(this.cbhidden);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbautobak);
            this.groupBox2.Controls.Add(this.cbcache);
            this.groupBox2.Controls.Add(this.cblang);
            this.groupBox2.Controls.Add(this.cbsilent);
            this.groupBox2.Controls.Add(this.cbwait);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // cbReport
            // 
            resources.ApplyResources(this.cbReport, "cbReport");
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.Name = "cbReport";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbpkgmaint
            // 
            resources.ApplyResources(this.cbpkgmaint, "cbpkgmaint");
            this.cbpkgmaint.Name = "cbpkgmaint";
            // 
            // cbupdate
            // 
            resources.ApplyResources(this.cbupdate, "cbupdate");
            this.cbupdate.Name = "cbupdate";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbautobak
            // 
            resources.ApplyResources(this.cbautobak, "cbautobak");
            this.cbautobak.Name = "cbautobak";
            this.cbautobak.CheckedChanged += new EventHandler(cbautobak_CheckedChanged);
            // 
            // cbcache
            // 
            resources.ApplyResources(this.cbcache, "cbcache");
            this.cbcache.Name = "cbcache";
            // 
            // cblang
            // 
            resources.ApplyResources(this.cblang, "cblang");
            this.cblang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblang.Name = "cblang";
            // 
            // cbsilent
            // 
            resources.ApplyResources(this.cbsilent, "cbsilent");
            this.cbsilent.Name = "cbsilent";
            // 
            // cbwait
            // 
            resources.ApplyResources(this.cbwait, "cbwait");
            this.cbwait.Name = "cbwait";
            // 
            // cbSimple
            // 
            resources.ApplyResources(this.cbSimple, "cbSimple");
            this.cbSimple.Name = "cbSimple";
            // 
            // cbmulti
            // 
            resources.ApplyResources(this.cbmulti, "cbmulti");
            this.cbmulti.Name = "cbmulti";
            this.cbmulti.CheckedChanged += new System.EventHandler(this.cbmulti_CheckedChanged);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.cbdebug);
            this.groupBox1.Controls.Add(this.cbblur);
            this.groupBox1.Controls.Add(this.cbsound);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lladddown
            // 
            resources.ApplyResources(this.lladddown, "lladddown");
            this.lladddown.Name = "lladddown";
            this.lladddown.TabStop = true;
            this.lladddown.UseCompatibleTextRendering = true;
            this.lladddown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladddown_LinkClicked);
            // 
            // lldel
            // 
            resources.ApplyResources(this.lldel, "lldel");
            this.lldel.Name = "lldel";
            this.lldel.TabStop = true;
            this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
            // 
            // lladd
            // 
            resources.ApplyResources(this.lladd, "lladd");
            this.lladd.Name = "lladd";
            this.lladd.TabStop = true;
            this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
            // 
            // groupBox4
            // 
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbscale);
            this.groupBox4.Controls.Add(this.cbjointname);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // cbjointname
            // 
            resources.ApplyResources(this.cbjointname, "cbjointname");
            this.cbjointname.Name = "cbjointname";
            // 
            // hcFolders
            // 
            this.hcFolders.Controls.Add(this.pgPaths);
            this.hcFolders.Controls.Add(this.tbep2);
            this.hcFolders.Controls.Add(this.btNightlife);
            this.hcFolders.Controls.Add(this.label14);
            this.hcFolders.Controls.Add(this.llNightlife);
            this.hcFolders.Controls.Add(this.button2);
            this.hcFolders.Controls.Add(this.tbsavegame);
            this.hcFolders.Controls.Add(this.button3);
            this.hcFolders.Controls.Add(this.button4);
            this.hcFolders.Controls.Add(this.tbdds);
            this.hcFolders.Controls.Add(this.label5);
            this.hcFolders.Controls.Add(this.linkLabel4);
            this.hcFolders.Controls.Add(this.tbep1);
            this.hcFolders.Controls.Add(this.button5);
            this.hcFolders.Controls.Add(this.tbgame);
            this.hcFolders.Controls.Add(this.lldds2);
            this.hcFolders.Controls.Add(this.lldds);
            this.hcFolders.Controls.Add(this.label7);
            this.hcFolders.Controls.Add(this.label6);
            this.hcFolders.Controls.Add(this.label3);
            this.hcFolders.Controls.Add(this.llsetep1);
            this.hcFolders.Controls.Add(this.label2);
            this.hcFolders.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcFolders, "hcFolders");
            this.hcFolders.Name = "hcFolders";
            // 
            // pgPaths
            // 
            this.pgPaths.CommandsBackColor = System.Drawing.SystemColors.Window;
            this.pgPaths.LineColor = System.Drawing.SystemColors.ScrollBar;
            resources.ApplyResources(this.pgPaths, "pgPaths");
            this.pgPaths.Name = "pgPaths";
            this.pgPaths.ToolbarVisible = false;
            // 
            // tbep2
            // 
            resources.ApplyResources(this.tbep2, "tbep2");
            this.tbep2.Name = "tbep2";
            // 
            // btNightlife
            // 
            resources.ApplyResources(this.btNightlife, "btNightlife");
            this.btNightlife.Name = "btNightlife";
            this.btNightlife.Click += new System.EventHandler(this.btNightlife_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // hcSettings
            // 
            this.hcSettings.Controls.Add(this.button8);
            this.hcSettings.Controls.Add(this.groupBox6);
            this.hcSettings.Controls.Add(this.groupBox5);
            this.hcSettings.Controls.Add(this.button6);
            this.hcSettings.Controls.Add(this.groupBox2);
            this.hcSettings.Controls.Add(this.groupBox1);
            this.hcSettings.Controls.Add(this.groupBox3);
            this.hcSettings.Controls.Add(this.button7);
            this.hcSettings.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcSettings, "hcSettings");
            this.hcSettings.Name = "hcSettings";
            // 
            // groupBox6
            // 
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.Controls.Add(this.cbFirefox);
            this.groupBox6.Controls.Add(this.cbSimple);
            this.groupBox6.Controls.Add(this.cbmulti);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            // 
            // cbFirefox
            // 
            resources.ApplyResources(this.cbFirefox, "cbFirefox");
            this.cbFirefox.Name = "cbFirefox";
            // 
            // groupBox5
            // 
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.Controls.Add(this.cbThemes);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            // 
            // cbThemes
            // 
            resources.ApplyResources(this.cbThemes, "cbThemes");
            this.cbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThemes.Name = "cbThemes";
            this.cbThemes.SelectedIndexChanged += new System.EventHandler(this.ChangedThemeHandler);
            // 
            // hcTools
            // 
            this.hcTools.Controls.Add(this.lbext);
            this.hcTools.Controls.Add(this.linkLabel1);
            this.hcTools.Controls.Add(this.linkLabel2);
            this.hcTools.Controls.Add(this.label1);
            this.hcTools.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcTools, "hcTools");
            this.hcTools.Name = "hcTools";
            // 
            // hcFileTable
            // 
            this.hcFileTable.Controls.Add(this.groupBox8);
            this.hcFileTable.Controls.Add(this.btReload);
            this.hcFileTable.Controls.Add(this.groupBox9);
            this.hcFileTable.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcFileTable, "hcFileTable");
            this.hcFileTable.Name = "hcFileTable";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.cbIncCep);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            // 
            // cbIncCep
            // 
            resources.ApplyResources(this.cbIncCep, "cbIncCep");
            this.cbIncCep.Name = "cbIncCep";
            this.cbIncCep.CheckedChanged += new System.EventHandler(this.cbIncNightlife_CheckedChanged);
            // 
            // btReload
            // 
            resources.ApplyResources(this.btReload, "btReload");
            this.btReload.Name = "btReload";
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btup);
            this.groupBox9.Controls.Add(this.btdn);
            this.groupBox9.Controls.Add(this.linkLabel6);
            this.groupBox9.Controls.Add(this.lldel);
            this.groupBox9.Controls.Add(this.lladddown);
            this.groupBox9.Controls.Add(this.lbfolder);
            this.groupBox9.Controls.Add(this.llchg);
            this.groupBox9.Controls.Add(this.lladd);
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            // 
            // btup
            // 
            resources.ApplyResources(this.btup, "btup");
            this.btup.Name = "btup";
            this.btup.Click += new System.EventHandler(this.btup_Click);
            // 
            // btdn
            // 
            resources.ApplyResources(this.btdn, "btdn");
            this.btdn.Name = "btdn";
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // linkLabel6
            // 
            resources.ApplyResources(this.linkLabel6, "linkLabel6");
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.TabStop = true;
            this.linkLabel6.UseCompatibleTextRendering = true;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // lbfolder
            // 
            resources.ApplyResources(this.lbfolder, "lbfolder");
            this.lbfolder.Name = "lbfolder";
            this.lbfolder.CheckOnClick = true;
            this.lbfolder.SelectedIndexChanged += new System.EventHandler(this.lbfolder_SelectedIndexChanged);
            this.lbfolder.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbfolder_ItemCheck);
            // 
            // llchg
            // 
            resources.ApplyResources(this.llchg, "llchg");
            this.llchg.Name = "llchg";
            this.llchg.TabStop = true;
            this.llchg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llchg_LinkClicked);
            // 
            // hcSceneGraph
            // 
            this.hcSceneGraph.Controls.Add(this.groupBox10);
            this.hcSceneGraph.Controls.Add(this.groupBox7);
            this.hcSceneGraph.Controls.Add(this.groupBox4);
            this.hcSceneGraph.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcSceneGraph, "hcSceneGraph");
            this.hcSceneGraph.Name = "hcSceneGraph";
            // 
            // groupBox10
            // 
            resources.ApplyResources(this.groupBox10, "groupBox10");
            this.groupBox10.Controls.Add(this.cbAsyncSort);
            this.groupBox10.Controls.Add(this.cbRLExt);
            this.groupBox10.Controls.Add(this.cbAsync);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.cbRLTGI);
            this.groupBox10.Controls.Add(this.label16);
            this.groupBox10.Controls.Add(this.cbRLNames);
            this.groupBox10.Controls.Add(this.label15);
            this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.TabStop = false;
            // 
            // cbAsyncSort
            // 
            resources.ApplyResources(this.cbAsyncSort, "cbAsyncSort");
            this.cbAsyncSort.Name = "cbAsyncSort";
            // 
            // cbRLExt
            // 
            this.cbRLExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRLExt.Enum = null;
            resources.ApplyResources(this.cbRLExt, "cbRLExt");
            this.cbRLExt.FormattingEnabled = true;
            this.cbRLExt.Name = "cbRLExt";
            this.cbRLExt.ResourceManager = null;
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // cbRLTGI
            // 
            this.cbRLTGI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRLTGI.Enum = null;
            resources.ApplyResources(this.cbRLTGI, "cbRLTGI");
            this.cbRLTGI.FormattingEnabled = true;
            this.cbRLTGI.Name = "cbRLTGI";
            this.cbRLTGI.ResourceManager = null;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // cbRLNames
            // 
            this.cbRLNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRLNames.Enum = null;
            resources.ApplyResources(this.cbRLNames, "cbRLNames");
            this.cbRLNames.FormattingEnabled = true;
            this.cbRLNames.Name = "cbRLNames";
            this.cbRLNames.ResourceManager = null;
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // groupBox7
            // 
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.Controls.Add(this.cbSimTemp);
            this.groupBox7.Controls.Add(this.cbDeep);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            // 
            // cbSimTemp
            // 
            resources.ApplyResources(this.cbSimTemp, "cbSimTemp");
            this.cbSimTemp.Name = "cbSimTemp";
            // 
            // cbDeep
            // 
            resources.ApplyResources(this.cbDeep, "cbDeep");
            this.cbDeep.Name = "cbDeep";
            this.cbDeep.CheckedChanged += new System.EventHandler(this.cbDeep_CheckedChanged);
            // 
            // bb
            // 
            resources.ApplyResources(this.bb, "bb");
            this.bb.Buttons.AddRange(new Divelements.Navisight.NavigationButton[] {
            this.nbFolders,
            this.nbCheck,
            this.nbSettings,
            this.nbFileTable,
            this.nbCustom,
            this.nbSceneGraph,
            this.nbPlugins,
            this.nbTools,
            this.nbIdent});
            this.bb.ButtonSpacing = 16;
            this.bb.Name = "bb";
            // 
            // nbFolders
            // 
            this.nbFolders.Checked = true;
            this.nbFolders.Image = ((System.Drawing.Image)(resources.GetObject("nbFolders.Image")));
            resources.ApplyResources(this.nbFolders, "nbFolders");
            this.nbFolders.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbCheck
            // 
            this.nbCheck.Image = ((System.Drawing.Image)(resources.GetObject("nbCheck.Image")));
            resources.ApplyResources(this.nbCheck, "nbCheck");
            this.nbCheck.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbSettings
            // 
            this.nbSettings.Image = ((System.Drawing.Image)(resources.GetObject("nbSettings.Image")));
            resources.ApplyResources(this.nbSettings, "nbSettings");
            this.nbSettings.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbSceneGraph
            // 
            this.nbSceneGraph.Image = ((System.Drawing.Image)(resources.GetObject("nbSceneGraph.Image")));
            resources.ApplyResources(this.nbSceneGraph, "nbSceneGraph");
            this.nbSceneGraph.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbCustom
            // 
            this.nbCustom.Image = ((System.Drawing.Image)(resources.GetObject("nbCustom.Image")));
            resources.ApplyResources(this.nbCustom, "nbCustom");
            this.nbCustom.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbFileTable
            // 
            this.nbFileTable.Image = ((System.Drawing.Image)(resources.GetObject("nbFileTable.Image")));
            resources.ApplyResources(this.nbFileTable, "nbFileTable");
            this.nbFileTable.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbPlugins
            // 
            this.nbPlugins.Image = ((System.Drawing.Image)(resources.GetObject("nbPlugins.Image")));
            resources.ApplyResources(this.nbPlugins, "nbPlugins");
            this.nbPlugins.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbTools
            // 
            this.nbTools.Image = ((System.Drawing.Image)(resources.GetObject("nbTools.Image")));
            resources.ApplyResources(this.nbTools, "nbTools");
            this.nbTools.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbIdent
            // 
            this.nbIdent.Image = ((System.Drawing.Image)(resources.GetObject("nbIdent.Image")));
            resources.ApplyResources(this.nbIdent, "nbIdent");
            this.nbIdent.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // hcPlugins
            // 
            this.hcPlugins.Controls.Add(this.btpup);
            this.hcPlugins.Controls.Add(this.btpdown);
            this.hcPlugins.Controls.Add(this.cnt);
            this.hcPlugins.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcPlugins, "hcPlugins");
            this.hcPlugins.Name = "hcPlugins";
            // 
            // btpup
            // 
            resources.ApplyResources(this.btpup, "btpup");
            this.btpup.Name = "btpup";
            this.btpup.Click += new System.EventHandler(this.btpup_Click);
            // 
            // btpdown
            // 
            resources.ApplyResources(this.btpdown, "btpdown");
            this.btpdown.Name = "btpdown";
            this.btpdown.Click += new System.EventHandler(this.btpdown_Click);
            // 
            // cnt
            // 
            resources.ApplyResources(this.cnt, "cnt");
            this.cnt.BackColor = System.Drawing.SystemColors.Window;
            this.cnt.Name = "cnt";
            // 
            // hcIdent
            // 
            this.hcIdent.Controls.Add(this.linkLabel5);
            this.hcIdent.Controls.Add(this.cbValid);
            this.hcIdent.Controls.Add(this.linkLabel3);
            this.hcIdent.Controls.Add(this.tbUserId);
            this.hcIdent.Controls.Add(this.label13);
            this.hcIdent.Controls.Add(this.tbPassword);
            this.hcIdent.Controls.Add(this.label12);
            this.hcIdent.Controls.Add(this.tbUsername);
            this.hcIdent.Controls.Add(this.label11);
            this.hcIdent.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcIdent, "hcIdent");
            this.hcIdent.Name = "hcIdent";
            // 
            // linkLabel5
            // 
            resources.ApplyResources(this.linkLabel5, "linkLabel5");
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.TabStop = true;
            this.linkLabel5.UseCompatibleTextRendering = true;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // cbValid
            // 
            resources.ApplyResources(this.cbValid, "cbValid");
            this.cbValid.Name = "cbValid";
            // 
            // linkLabel3
            // 
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // tbUserId
            // 
            resources.ApplyResources(this.tbUserId, "tbUserId");
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.ReadOnly = true;
            this.tbUserId.TextChanged += new System.EventHandler(this.tbUserId_TextChanged);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbPassword
            // 
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // tbUsername
            // 
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // hcCheck
            // 
            this.hcCheck.Controls.Add(this.checkControl1);
            this.hcCheck.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcCheck, "hcCheck");
            this.hcCheck.Name = "hcCheck";
            // 
            // checkControl1
            // 
            resources.ApplyResources(this.checkControl1, "checkControl1");
            this.checkControl1.Name = "checkControl1";
            this.checkControl1.FixedFileTable += new System.EventHandler(this.checkControl1_FixedFileTable);
            // 
            // hcCustom
            // 
            this.hcCustom.Controls.Add(this.pgcustom);
            this.hcCustom.Controls.Add(this.cbCustom);
            this.hcCustom.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.hcCustom, "hcCustom");
            this.hcCustom.Name = "hcCustom";
            // 
            // pgcustom
            // 
            resources.ApplyResources(this.pgcustom, "pgcustom");
            this.pgcustom.CommandsBackColor = System.Drawing.SystemColors.Window;
            this.pgcustom.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.pgcustom.Name = "pgcustom";
            // 
            // cbCustom
            // 
            resources.ApplyResources(this.cbCustom, "cbCustom");
            this.cbCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.SelectedIndexChanged += new System.EventHandler(this.cbCustom_SelectedIndexChanged);
            // 
            // baloonTip
            // 
            this.baloonTip.Enabled = true;
            // 
            // OptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.bb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hcFileTable);
            this.Controls.Add(this.hcCustom);
            this.Controls.Add(this.hcCheck);
            this.Controls.Add(this.hcFolders);
            this.Controls.Add(this.hcSceneGraph);
            this.Controls.Add(this.hcSettings);
            this.Controls.Add(this.hcIdent);
            this.Controls.Add(this.hcPlugins);
            this.Controls.Add(this.hcTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.hcFolders.ResumeLayout(false);
            this.hcFolders.PerformLayout();
            this.hcSettings.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.hcTools.ResumeLayout(false);
            this.hcTools.PerformLayout();
            this.hcFileTable.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.hcSceneGraph.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.hcPlugins.ResumeLayout(false);
            this.hcIdent.ResumeLayout(false);
            this.hcIdent.PerformLayout();
            this.hcCheck.ResumeLayout(false);
            this.hcCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}
