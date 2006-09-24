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
    /// <summary>
    /// Zusammenfassung für OptionForm.
    /// </summary>
    public class OptionForm : System.Windows.Forms.Form
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
        private System.ComponentModel.IContainer components;

        public OptionForm()
        {
            //
            // Erforderlich für die Windows Form-Designerunterstützung
            //
            InitializeComponent();

            this.pgPaths.SelectedObject = SimPe.PathSettings.Global;


            for (byte i = 1; i < 0x44; i++) this.cblang.Items.Add(new SimPe.PackedFiles.Wrapper.StrLanguage(i));
            SelectCategory(nbFolders, null);

            SimPe.GuiTheme[] gts = (SimPe.GuiTheme[])System.Enum.GetValues(typeof(SimPe.GuiTheme));
            foreach (SimPe.GuiTheme gt in gts) cbThemes.Items.Add(gt);
            cbThemes.SelectedIndex = 0;

            SimPe.Registry.ReportFormats[] rfs = (SimPe.Registry.ReportFormats[])System.Enum.GetValues(typeof(SimPe.Registry.ReportFormats));
            foreach (SimPe.Registry.ReportFormats rf in rfs) cbReport.Items.Add(rf);
            cbReport.SelectedIndex = 0;

            foreach (SimPe.Interfaces.ISettings settings in FileTable.SettingsRegistry.Settings)
                this.cbCustom.Items.Add(settings);
            if (cbCustom.Items.Count > 0) cbCustom.SelectedIndex = 0;

            CreateFileTableCheckboxes();
        }

        private void CreateFileTableCheckboxes()
        {
            int cwd = cbIncCep.Parent.Width - 2 * cbIncCep.Left + 4;
            cbIncCep.Width = (cwd / 4) - 4;
            int left = cbIncCep.Right + 4;
            int top = cbIncCep.Top;
            foreach (ExpansionItem ei in PathProvider.Global.Expansions)
            {
                if (left + cbIncCep.Width > cbIncCep.Parent.Width -  cbIncCep.Left)
                {
                    left = cbIncCep.Left;
                    top += cbIncCep.Height - 2;
                }

                CheckBox cb = new CheckBox();
                cb.Parent = cbIncCep.Parent;
                cb.SetBounds(left, top, cbIncCep.Width, cbIncCep.Height);
                cb.Tag = ei;
                cb.Text = SimPe.Localization.GetString("FileTableSectionInclude").Replace("{what}", ei.NameShort);
                cb.Visible = true;
                cb.CheckedChanged += new System.EventHandler(this.cbIncNightlife_CheckedChanged);
                cb.Font = cbIncCep.Font;

                if (!ei.Exists)
                {
                    cb.CheckState = CheckState.Unchecked;
                    cb.Enabled = false;
                }

                left += cb.Width + 4;                
            }

            top += cbIncCep.Height + 2;
            groupBox8.Height = top;
            groupBox9.Top = groupBox8.Bottom + 8;
            groupBox9.Height = hcFileTable.Height - groupBox9.Top - 8;
        }

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
            this.pgPaths = new SimPe.MyPropertyGrid();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cbSimTemp = new System.Windows.Forms.CheckBox();
            this.cbDeep = new System.Windows.Forms.CheckBox();
            this.bb = new Divelements.Navisight.ButtonBar();
            this.nbFolders = new Divelements.Navisight.NavigationButton();
            this.nbCheck = new Divelements.Navisight.NavigationButton();
            this.nbSettings = new Divelements.Navisight.NavigationButton();
            this.nbCustom = new Divelements.Navisight.NavigationButton();
            this.nbSceneGraph = new Divelements.Navisight.NavigationButton();
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
            this.groupBox7.SuspendLayout();
            this.hcPlugins.SuspendLayout();
            this.hcIdent.SuspendLayout();
            this.hcCheck.SuspendLayout();
            this.hcCustom.SuspendLayout();
            this.SuspendLayout();
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
            this.button1.Click += new System.EventHandler(this.SaveOptionsClick);
            // 
            // tbgame
            // 
            this.tbgame.AccessibleDescription = null;
            this.tbgame.AccessibleName = null;
            resources.ApplyResources(this.tbgame, "tbgame");
            this.tbgame.BackgroundImage = null;
            this.tbgame.Font = null;
            this.tbgame.Name = "tbgame";
            this.toolTip1.SetToolTip(this.tbgame, resources.GetString("tbgame.ToolTip"));
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.TabStop = true;
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            this.label2.UseCompatibleTextRendering = true;
            this.label2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label2_LinkClicked);
            // 
            // tbsavegame
            // 
            this.tbsavegame.AccessibleDescription = null;
            this.tbsavegame.AccessibleName = null;
            resources.ApplyResources(this.tbsavegame, "tbsavegame");
            this.tbsavegame.BackgroundImage = null;
            this.tbsavegame.Font = null;
            this.tbsavegame.Name = "tbsavegame";
            this.toolTip1.SetToolTip(this.tbsavegame, resources.GetString("tbsavegame.ToolTip"));
            // 
            // cbdebug
            // 
            this.cbdebug.AccessibleDescription = null;
            this.cbdebug.AccessibleName = null;
            resources.ApplyResources(this.cbdebug, "cbdebug");
            this.cbdebug.BackgroundImage = null;
            this.cbdebug.Name = "cbdebug";
            this.toolTip1.SetToolTip(this.cbdebug, resources.GetString("cbdebug.ToolTip"));
            // 
            // cbblur
            // 
            this.cbblur.AccessibleDescription = null;
            this.cbblur.AccessibleName = null;
            resources.ApplyResources(this.cbblur, "cbblur");
            this.cbblur.BackgroundImage = null;
            this.cbblur.Name = "cbblur";
            this.toolTip1.SetToolTip(this.cbblur, resources.GetString("cbblur.ToolTip"));
            this.cbblur.CheckedChanged += new System.EventHandler(this.cbblur_CheckedChanged);
            // 
            // cbsound
            // 
            this.cbsound.AccessibleDescription = null;
            this.cbsound.AccessibleName = null;
            resources.ApplyResources(this.cbsound, "cbsound");
            this.cbsound.BackgroundImage = null;
            this.cbsound.Name = "cbsound";
            this.toolTip1.SetToolTip(this.cbsound, resources.GetString("cbsound.ToolTip"));
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // lbext
            // 
            this.lbext.AccessibleDescription = null;
            this.lbext.AccessibleName = null;
            resources.ApplyResources(this.lbext, "lbext");
            this.lbext.BackgroundImage = null;
            this.lbext.Font = null;
            this.lbext.Name = "lbext";
            this.toolTip1.SetToolTip(this.lbext, resources.GetString("lbext.ToolTip"));
            // 
            // linkLabel1
            // 
            this.linkLabel1.AccessibleDescription = null;
            this.linkLabel1.AccessibleName = null;
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddExt);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AccessibleDescription = null;
            this.linkLabel2.AccessibleName = null;
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel2, resources.GetString("linkLabel2.ToolTip"));
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteExt);
            // 
            // fbd
            // 
            resources.ApplyResources(this.fbd, "fbd");
            // 
            // button2
            // 
            this.button2.AccessibleDescription = null;
            this.button2.AccessibleName = null;
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = null;
            this.button2.Font = null;
            this.button2.Name = "button2";
            this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = null;
            this.button3.AccessibleName = null;
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackgroundImage = null;
            this.button3.Font = null;
            this.button3.Name = "button3";
            this.toolTip1.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.AccessibleDescription = null;
            this.button4.AccessibleName = null;
            resources.ApplyResources(this.button4, "button4");
            this.button4.BackgroundImage = null;
            this.button4.Font = null;
            this.button4.Name = "button4";
            this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbdds
            // 
            this.tbdds.AccessibleDescription = null;
            this.tbdds.AccessibleName = null;
            resources.ApplyResources(this.tbdds, "tbdds");
            this.tbdds.BackgroundImage = null;
            this.tbdds.Font = null;
            this.tbdds.Name = "tbdds";
            this.toolTip1.SetToolTip(this.tbdds, resources.GetString("tbdds.ToolTip"));
            this.tbdds.TextChanged += new System.EventHandler(this.DDSChanged);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
            // 
            // ofd
            // 
            resources.ApplyResources(this.ofd, "ofd");
            // 
            // tbep1
            // 
            this.tbep1.AccessibleDescription = null;
            this.tbep1.AccessibleName = null;
            resources.ApplyResources(this.tbep1, "tbep1");
            this.tbep1.BackgroundImage = null;
            this.tbep1.Font = null;
            this.tbep1.Name = "tbep1";
            this.toolTip1.SetToolTip(this.tbep1, resources.GetString("tbep1.ToolTip"));
            // 
            // button5
            // 
            this.button5.AccessibleDescription = null;
            this.button5.AccessibleName = null;
            resources.ApplyResources(this.button5, "button5");
            this.button5.BackgroundImage = null;
            this.button5.Font = null;
            this.button5.Name = "button5";
            this.toolTip1.SetToolTip(this.button5, resources.GetString("button5.ToolTip"));
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.AccessibleDescription = null;
            this.linkLabel4.AccessibleName = null;
            resources.ApplyResources(this.linkLabel4, "linkLabel4");
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel4, resources.GetString("linkLabel4.ToolTip"));
            this.linkLabel4.UseCompatibleTextRendering = true;
            this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
            // 
            // llsetep1
            // 
            this.llsetep1.AccessibleDescription = null;
            this.llsetep1.AccessibleName = null;
            resources.ApplyResources(this.llsetep1, "llsetep1");
            this.llsetep1.Name = "llsetep1";
            this.llsetep1.TabStop = true;
            this.toolTip1.SetToolTip(this.llsetep1, resources.GetString("llsetep1.ToolTip"));
            this.llsetep1.UseCompatibleTextRendering = true;
            this.llsetep1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visualStyleLinkLabel1_LinkClicked);
            // 
            // tbthumb
            // 
            this.tbthumb.AccessibleDescription = null;
            this.tbthumb.AccessibleName = null;
            resources.ApplyResources(this.tbthumb, "tbthumb");
            this.tbthumb.BackgroundImage = null;
            this.tbthumb.Name = "tbthumb";
            this.toolTip1.SetToolTip(this.tbthumb, resources.GetString("tbthumb.ToolTip"));
            // 
            // cbLock
            // 
            this.cbLock.AccessibleDescription = null;
            this.cbLock.AccessibleName = null;
            resources.ApplyResources(this.cbLock, "cbLock");
            this.cbLock.BackgroundImage = null;
            this.cbLock.Name = "cbLock";
            this.toolTip1.SetToolTip(this.cbLock, resources.GetString("cbLock.ToolTip"));
            this.cbLock.CheckedChanged += new System.EventHandler(this.cbLock_CheckedChanged);
            // 
            // cbAsync
            // 
            this.cbAsync.AccessibleDescription = null;
            this.cbAsync.AccessibleName = null;
            resources.ApplyResources(this.cbAsync, "cbAsync");
            this.cbAsync.BackgroundImage = null;
            this.cbAsync.Name = "cbAsync";
            this.toolTip1.SetToolTip(this.cbAsync, resources.GetString("cbAsync.ToolTip"));
            // 
            // cbhidden
            // 
            this.cbhidden.AccessibleDescription = null;
            this.cbhidden.AccessibleName = null;
            resources.ApplyResources(this.cbhidden, "cbhidden");
            this.cbhidden.BackgroundImage = null;
            this.cbhidden.Name = "cbhidden";
            this.toolTip1.SetToolTip(this.cbhidden, resources.GetString("cbhidden.ToolTip"));
            // 
            // tbscale
            // 
            this.tbscale.AccessibleDescription = null;
            this.tbscale.AccessibleName = null;
            resources.ApplyResources(this.tbscale, "tbscale");
            this.tbscale.BackgroundImage = null;
            this.tbscale.Name = "tbscale";
            this.toolTip1.SetToolTip(this.tbscale, resources.GetString("tbscale.ToolTip"));
            // 
            // llNightlife
            // 
            this.llNightlife.AccessibleDescription = null;
            this.llNightlife.AccessibleName = null;
            resources.ApplyResources(this.llNightlife, "llNightlife");
            this.llNightlife.Name = "llNightlife";
            this.llNightlife.TabStop = true;
            this.toolTip1.SetToolTip(this.llNightlife, resources.GetString("llNightlife.ToolTip"));
            this.llNightlife.UseCompatibleTextRendering = true;
            this.llNightlife.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llNightlife_LinkClicked);
            // 
            // button8
            // 
            this.button8.AccessibleDescription = null;
            this.button8.AccessibleName = null;
            resources.ApplyResources(this.button8, "button8");
            this.button8.BackgroundImage = null;
            this.button8.Font = null;
            this.button8.Name = "button8";
            this.toolTip1.SetToolTip(this.button8, resources.GetString("button8.ToolTip"));
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.AccessibleDescription = null;
            this.button7.AccessibleName = null;
            resources.ApplyResources(this.button7, "button7");
            this.button7.BackgroundImage = null;
            this.button7.Name = "button7";
            this.toolTip1.SetToolTip(this.button7, resources.GetString("button7.ToolTip"));
            this.button7.Click += new System.EventHandler(this.ResetLayoutClick);
            // 
            // lldds2
            // 
            this.lldds2.AccessibleDescription = null;
            this.lldds2.AccessibleName = null;
            resources.ApplyResources(this.lldds2, "lldds2");
            this.lldds2.BackColor = System.Drawing.SystemColors.Window;
            this.lldds2.ForeColor = System.Drawing.Color.Gray;
            this.lldds2.LinkColor = System.Drawing.Color.Red;
            this.lldds2.Name = "lldds2";
            this.lldds2.TabStop = true;
            this.toolTip1.SetToolTip(this.lldds2, resources.GetString("lldds2.ToolTip"));
            this.lldds2.UseCompatibleTextRendering = true;
            this.lldds2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadDDS);
            // 
            // lldds
            // 
            this.lldds.AccessibleDescription = null;
            this.lldds.AccessibleName = null;
            resources.ApplyResources(this.lldds, "lldds");
            this.lldds.BackColor = System.Drawing.SystemColors.Window;
            this.lldds.ForeColor = System.Drawing.Color.Gray;
            this.lldds.Name = "lldds";
            this.toolTip1.SetToolTip(this.lldds, resources.GetString("lldds.ToolTip"));
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // groupBox3
            // 
            this.groupBox3.AccessibleDescription = null;
            this.groupBox3.AccessibleName = null;
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackgroundImage = null;
            this.groupBox3.Controls.Add(this.cbow);
            this.groupBox3.Controls.Add(this.cbshowobjd);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbthumb);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
            // 
            // cbow
            // 
            this.cbow.AccessibleDescription = null;
            this.cbow.AccessibleName = null;
            resources.ApplyResources(this.cbow, "cbow");
            this.cbow.BackgroundImage = null;
            this.cbow.Name = "cbow";
            this.toolTip1.SetToolTip(this.cbow, resources.GetString("cbow.ToolTip"));
            // 
            // cbshowobjd
            // 
            this.cbshowobjd.AccessibleDescription = null;
            this.cbshowobjd.AccessibleName = null;
            resources.ApplyResources(this.cbshowobjd, "cbshowobjd");
            this.cbshowobjd.BackgroundImage = null;
            this.cbshowobjd.Name = "cbshowobjd";
            this.toolTip1.SetToolTip(this.cbshowobjd, resources.GetString("cbshowobjd.ToolTip"));
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
            // 
            // button6
            // 
            this.button6.AccessibleDescription = null;
            this.button6.AccessibleName = null;
            resources.ApplyResources(this.button6, "button6");
            this.button6.BackgroundImage = null;
            this.button6.Font = null;
            this.button6.Name = "button6";
            this.toolTip1.SetToolTip(this.button6, resources.GetString("button6.ToolTip"));
            this.button6.Click += new System.EventHandler(this.ClearCaches);
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = null;
            this.groupBox2.AccessibleName = null;
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackgroundImage = null;
            this.groupBox2.Controls.Add(this.cbLock);
            this.groupBox2.Controls.Add(this.cbReport);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cbAsync);
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
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // cbReport
            // 
            this.cbReport.AccessibleDescription = null;
            this.cbReport.AccessibleName = null;
            resources.ApplyResources(this.cbReport, "cbReport");
            this.cbReport.BackgroundImage = null;
            this.cbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReport.Name = "cbReport";
            this.toolTip1.SetToolTip(this.cbReport, resources.GetString("cbReport.ToolTip"));
            // 
            // label9
            // 
            this.label9.AccessibleDescription = null;
            this.label9.AccessibleName = null;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
            // 
            // cbpkgmaint
            // 
            this.cbpkgmaint.AccessibleDescription = null;
            this.cbpkgmaint.AccessibleName = null;
            resources.ApplyResources(this.cbpkgmaint, "cbpkgmaint");
            this.cbpkgmaint.BackgroundImage = null;
            this.cbpkgmaint.Name = "cbpkgmaint";
            this.toolTip1.SetToolTip(this.cbpkgmaint, resources.GetString("cbpkgmaint.ToolTip"));
            // 
            // cbupdate
            // 
            this.cbupdate.AccessibleDescription = null;
            this.cbupdate.AccessibleName = null;
            resources.ApplyResources(this.cbupdate, "cbupdate");
            this.cbupdate.BackgroundImage = null;
            this.cbupdate.Name = "cbupdate";
            this.toolTip1.SetToolTip(this.cbupdate, resources.GetString("cbupdate.ToolTip"));
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // cbautobak
            // 
            this.cbautobak.AccessibleDescription = null;
            this.cbautobak.AccessibleName = null;
            resources.ApplyResources(this.cbautobak, "cbautobak");
            this.cbautobak.BackgroundImage = null;
            this.cbautobak.Name = "cbautobak";
            this.toolTip1.SetToolTip(this.cbautobak, resources.GetString("cbautobak.ToolTip"));
            // 
            // cbcache
            // 
            this.cbcache.AccessibleDescription = null;
            this.cbcache.AccessibleName = null;
            resources.ApplyResources(this.cbcache, "cbcache");
            this.cbcache.BackgroundImage = null;
            this.cbcache.Name = "cbcache";
            this.toolTip1.SetToolTip(this.cbcache, resources.GetString("cbcache.ToolTip"));
            // 
            // cblang
            // 
            this.cblang.AccessibleDescription = null;
            this.cblang.AccessibleName = null;
            resources.ApplyResources(this.cblang, "cblang");
            this.cblang.BackgroundImage = null;
            this.cblang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblang.Name = "cblang";
            this.toolTip1.SetToolTip(this.cblang, resources.GetString("cblang.ToolTip"));
            // 
            // cbsilent
            // 
            this.cbsilent.AccessibleDescription = null;
            this.cbsilent.AccessibleName = null;
            resources.ApplyResources(this.cbsilent, "cbsilent");
            this.cbsilent.BackgroundImage = null;
            this.cbsilent.Name = "cbsilent";
            this.toolTip1.SetToolTip(this.cbsilent, resources.GetString("cbsilent.ToolTip"));
            // 
            // cbwait
            // 
            this.cbwait.AccessibleDescription = null;
            this.cbwait.AccessibleName = null;
            resources.ApplyResources(this.cbwait, "cbwait");
            this.cbwait.BackgroundImage = null;
            this.cbwait.Name = "cbwait";
            this.toolTip1.SetToolTip(this.cbwait, resources.GetString("cbwait.ToolTip"));
            // 
            // cbSimple
            // 
            this.cbSimple.AccessibleDescription = null;
            this.cbSimple.AccessibleName = null;
            resources.ApplyResources(this.cbSimple, "cbSimple");
            this.cbSimple.BackgroundImage = null;
            this.cbSimple.Name = "cbSimple";
            this.toolTip1.SetToolTip(this.cbSimple, resources.GetString("cbSimple.ToolTip"));
            // 
            // cbmulti
            // 
            this.cbmulti.AccessibleDescription = null;
            this.cbmulti.AccessibleName = null;
            resources.ApplyResources(this.cbmulti, "cbmulti");
            this.cbmulti.BackgroundImage = null;
            this.cbmulti.Name = "cbmulti";
            this.toolTip1.SetToolTip(this.cbmulti, resources.GetString("cbmulti.ToolTip"));
            this.cbmulti.CheckedChanged += new System.EventHandler(this.cbmulti_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleDescription = null;
            this.groupBox1.AccessibleName = null;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackgroundImage = null;
            this.groupBox1.Controls.Add(this.cbdebug);
            this.groupBox1.Controls.Add(this.cbblur);
            this.groupBox1.Controls.Add(this.cbsound);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // lladddown
            // 
            this.lladddown.AccessibleDescription = null;
            this.lladddown.AccessibleName = null;
            resources.ApplyResources(this.lladddown, "lladddown");
            this.lladddown.Name = "lladddown";
            this.lladddown.TabStop = true;
            this.toolTip1.SetToolTip(this.lladddown, resources.GetString("lladddown.ToolTip"));
            this.lladddown.UseCompatibleTextRendering = true;
            this.lladddown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladddown_LinkClicked);
            // 
            // lldel
            // 
            this.lldel.AccessibleDescription = null;
            this.lldel.AccessibleName = null;
            resources.ApplyResources(this.lldel, "lldel");
            this.lldel.Name = "lldel";
            this.lldel.TabStop = true;
            this.toolTip1.SetToolTip(this.lldel, resources.GetString("lldel.ToolTip"));
            this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
            // 
            // lladd
            // 
            this.lladd.AccessibleDescription = null;
            this.lladd.AccessibleName = null;
            resources.ApplyResources(this.lladd, "lladd");
            this.lladd.Name = "lladd";
            this.lladd.TabStop = true;
            this.toolTip1.SetToolTip(this.lladd, resources.GetString("lladd.ToolTip"));
            this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleDescription = null;
            this.groupBox4.AccessibleName = null;
            resources.ApplyResources(this.groupBox4, "groupBox4");
            this.groupBox4.BackgroundImage = null;
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.tbscale);
            this.groupBox4.Controls.Add(this.cbjointname);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
            // 
            // label10
            // 
            this.label10.AccessibleDescription = null;
            this.label10.AccessibleName = null;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
            // 
            // cbjointname
            // 
            this.cbjointname.AccessibleDescription = null;
            this.cbjointname.AccessibleName = null;
            resources.ApplyResources(this.cbjointname, "cbjointname");
            this.cbjointname.BackgroundImage = null;
            this.cbjointname.Name = "cbjointname";
            this.toolTip1.SetToolTip(this.cbjointname, resources.GetString("cbjointname.ToolTip"));
            // 
            // hcFolders
            // 
            this.hcFolders.AccessibleDescription = null;
            this.hcFolders.AccessibleName = null;
            resources.ApplyResources(this.hcFolders, "hcFolders");
            this.hcFolders.BackgroundImage = null;
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
            this.hcFolders.Font = null;
            this.hcFolders.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcFolders.Name = "hcFolders";
            this.toolTip1.SetToolTip(this.hcFolders, resources.GetString("hcFolders.ToolTip"));
            // 
            // pgPaths
            // 
            this.pgPaths.AccessibleDescription = null;
            this.pgPaths.AccessibleName = null;
            resources.ApplyResources(this.pgPaths, "pgPaths");
            this.pgPaths.BackgroundImage = null;
            this.pgPaths.CommandsBackColor = System.Drawing.SystemColors.Window;
            this.pgPaths.Font = null;
            this.pgPaths.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.pgPaths.Name = "pgPaths";
            this.pgPaths.ToolbarVisible = false;
            this.toolTip1.SetToolTip(this.pgPaths, resources.GetString("pgPaths.ToolTip"));
            // 
            // tbep2
            // 
            this.tbep2.AccessibleDescription = null;
            this.tbep2.AccessibleName = null;
            resources.ApplyResources(this.tbep2, "tbep2");
            this.tbep2.BackgroundImage = null;
            this.tbep2.Font = null;
            this.tbep2.Name = "tbep2";
            this.toolTip1.SetToolTip(this.tbep2, resources.GetString("tbep2.ToolTip"));
            // 
            // btNightlife
            // 
            this.btNightlife.AccessibleDescription = null;
            this.btNightlife.AccessibleName = null;
            resources.ApplyResources(this.btNightlife, "btNightlife");
            this.btNightlife.BackgroundImage = null;
            this.btNightlife.Font = null;
            this.btNightlife.Name = "btNightlife";
            this.toolTip1.SetToolTip(this.btNightlife, resources.GetString("btNightlife.ToolTip"));
            this.btNightlife.Click += new System.EventHandler(this.btNightlife_Click);
            // 
            // label14
            // 
            this.label14.AccessibleDescription = null;
            this.label14.AccessibleName = null;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
            // 
            // hcSettings
            // 
            this.hcSettings.AccessibleDescription = null;
            this.hcSettings.AccessibleName = null;
            resources.ApplyResources(this.hcSettings, "hcSettings");
            this.hcSettings.BackgroundImage = null;
            this.hcSettings.Controls.Add(this.button8);
            this.hcSettings.Controls.Add(this.groupBox6);
            this.hcSettings.Controls.Add(this.groupBox5);
            this.hcSettings.Controls.Add(this.button6);
            this.hcSettings.Controls.Add(this.groupBox2);
            this.hcSettings.Controls.Add(this.groupBox1);
            this.hcSettings.Controls.Add(this.groupBox3);
            this.hcSettings.Controls.Add(this.button7);
            this.hcSettings.Font = null;
            this.hcSettings.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcSettings.Name = "hcSettings";
            this.toolTip1.SetToolTip(this.hcSettings, resources.GetString("hcSettings.ToolTip"));
            // 
            // groupBox6
            // 
            this.groupBox6.AccessibleDescription = null;
            this.groupBox6.AccessibleName = null;
            resources.ApplyResources(this.groupBox6, "groupBox6");
            this.groupBox6.BackgroundImage = null;
            this.groupBox6.Controls.Add(this.cbFirefox);
            this.groupBox6.Controls.Add(this.cbSimple);
            this.groupBox6.Controls.Add(this.cbmulti);
            this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
            // 
            // cbFirefox
            // 
            this.cbFirefox.AccessibleDescription = null;
            this.cbFirefox.AccessibleName = null;
            resources.ApplyResources(this.cbFirefox, "cbFirefox");
            this.cbFirefox.BackgroundImage = null;
            this.cbFirefox.Name = "cbFirefox";
            this.toolTip1.SetToolTip(this.cbFirefox, resources.GetString("cbFirefox.ToolTip"));
            // 
            // groupBox5
            // 
            this.groupBox5.AccessibleDescription = null;
            this.groupBox5.AccessibleName = null;
            resources.ApplyResources(this.groupBox5, "groupBox5");
            this.groupBox5.BackgroundImage = null;
            this.groupBox5.Controls.Add(this.cbThemes);
            this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
            // 
            // cbThemes
            // 
            this.cbThemes.AccessibleDescription = null;
            this.cbThemes.AccessibleName = null;
            resources.ApplyResources(this.cbThemes, "cbThemes");
            this.cbThemes.BackgroundImage = null;
            this.cbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThemes.Name = "cbThemes";
            this.toolTip1.SetToolTip(this.cbThemes, resources.GetString("cbThemes.ToolTip"));
            this.cbThemes.SelectedIndexChanged += new System.EventHandler(this.ChangedThemeHandler);
            // 
            // hcTools
            // 
            this.hcTools.AccessibleDescription = null;
            this.hcTools.AccessibleName = null;
            resources.ApplyResources(this.hcTools, "hcTools");
            this.hcTools.BackgroundImage = null;
            this.hcTools.Controls.Add(this.lbext);
            this.hcTools.Controls.Add(this.linkLabel1);
            this.hcTools.Controls.Add(this.linkLabel2);
            this.hcTools.Controls.Add(this.label1);
            this.hcTools.Font = null;
            this.hcTools.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcTools.Name = "hcTools";
            this.toolTip1.SetToolTip(this.hcTools, resources.GetString("hcTools.ToolTip"));
            // 
            // hcFileTable
            // 
            this.hcFileTable.AccessibleDescription = null;
            this.hcFileTable.AccessibleName = null;
            resources.ApplyResources(this.hcFileTable, "hcFileTable");
            this.hcFileTable.BackgroundImage = null;
            this.hcFileTable.Controls.Add(this.groupBox8);
            this.hcFileTable.Controls.Add(this.btReload);
            this.hcFileTable.Controls.Add(this.groupBox9);
            this.hcFileTable.Font = null;
            this.hcFileTable.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcFileTable.Name = "hcFileTable";
            this.toolTip1.SetToolTip(this.hcFileTable, resources.GetString("hcFileTable.ToolTip"));
            // 
            // groupBox8
            // 
            this.groupBox8.AccessibleDescription = null;
            this.groupBox8.AccessibleName = null;
            resources.ApplyResources(this.groupBox8, "groupBox8");
            this.groupBox8.BackgroundImage = null;
            this.groupBox8.Controls.Add(this.cbIncCep);
            this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox8, resources.GetString("groupBox8.ToolTip"));
            // 
            // cbIncCep
            // 
            this.cbIncCep.AccessibleDescription = null;
            this.cbIncCep.AccessibleName = null;
            resources.ApplyResources(this.cbIncCep, "cbIncCep");
            this.cbIncCep.BackgroundImage = null;
            this.cbIncCep.Name = "cbIncCep";
            this.toolTip1.SetToolTip(this.cbIncCep, resources.GetString("cbIncCep.ToolTip"));
            this.cbIncCep.CheckedChanged += new System.EventHandler(this.cbIncNightlife_CheckedChanged);
            // 
            // btReload
            // 
            this.btReload.AccessibleDescription = null;
            this.btReload.AccessibleName = null;
            resources.ApplyResources(this.btReload, "btReload");
            this.btReload.BackgroundImage = null;
            this.btReload.Name = "btReload";
            this.toolTip1.SetToolTip(this.btReload, resources.GetString("btReload.ToolTip"));
            this.btReload.Click += new System.EventHandler(this.btReload_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.AccessibleDescription = null;
            this.groupBox9.AccessibleName = null;
            resources.ApplyResources(this.groupBox9, "groupBox9");
            this.groupBox9.BackgroundImage = null;
            this.groupBox9.Controls.Add(this.btup);
            this.groupBox9.Controls.Add(this.btdn);
            this.groupBox9.Controls.Add(this.linkLabel6);
            this.groupBox9.Controls.Add(this.lldel);
            this.groupBox9.Controls.Add(this.lladddown);
            this.groupBox9.Controls.Add(this.lbfolder);
            this.groupBox9.Controls.Add(this.llchg);
            this.groupBox9.Controls.Add(this.lladd);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox9, resources.GetString("groupBox9.ToolTip"));
            // 
            // btup
            // 
            this.btup.AccessibleDescription = null;
            this.btup.AccessibleName = null;
            resources.ApplyResources(this.btup, "btup");
            this.btup.BackgroundImage = null;
            this.btup.Name = "btup";
            this.toolTip1.SetToolTip(this.btup, resources.GetString("btup.ToolTip"));
            this.btup.Click += new System.EventHandler(this.btup_Click);
            // 
            // btdn
            // 
            this.btdn.AccessibleDescription = null;
            this.btdn.AccessibleName = null;
            resources.ApplyResources(this.btdn, "btdn");
            this.btdn.BackgroundImage = null;
            this.btdn.Name = "btdn";
            this.toolTip1.SetToolTip(this.btdn, resources.GetString("btdn.ToolTip"));
            this.btdn.Click += new System.EventHandler(this.btdn_Click);
            // 
            // linkLabel6
            // 
            this.linkLabel6.AccessibleDescription = null;
            this.linkLabel6.AccessibleName = null;
            resources.ApplyResources(this.linkLabel6, "linkLabel6");
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel6, resources.GetString("linkLabel6.ToolTip"));
            this.linkLabel6.UseCompatibleTextRendering = true;
            this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
            // 
            // lbfolder
            // 
            this.lbfolder.AccessibleDescription = null;
            this.lbfolder.AccessibleName = null;
            resources.ApplyResources(this.lbfolder, "lbfolder");
            this.lbfolder.BackgroundImage = null;
            this.lbfolder.Name = "lbfolder";
            this.toolTip1.SetToolTip(this.lbfolder, resources.GetString("lbfolder.ToolTip"));
            this.lbfolder.SelectedIndexChanged += new System.EventHandler(this.lbfolder_SelectedIndexChanged);
            this.lbfolder.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lbfolder_ItemCheck);
            // 
            // llchg
            // 
            this.llchg.AccessibleDescription = null;
            this.llchg.AccessibleName = null;
            resources.ApplyResources(this.llchg, "llchg");
            this.llchg.Name = "llchg";
            this.llchg.TabStop = true;
            this.toolTip1.SetToolTip(this.llchg, resources.GetString("llchg.ToolTip"));
            this.llchg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llchg_LinkClicked);
            // 
            // hcSceneGraph
            // 
            this.hcSceneGraph.AccessibleDescription = null;
            this.hcSceneGraph.AccessibleName = null;
            resources.ApplyResources(this.hcSceneGraph, "hcSceneGraph");
            this.hcSceneGraph.BackgroundImage = null;
            this.hcSceneGraph.Controls.Add(this.groupBox7);
            this.hcSceneGraph.Controls.Add(this.groupBox4);
            this.hcSceneGraph.Font = null;
            this.hcSceneGraph.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcSceneGraph.Name = "hcSceneGraph";
            this.toolTip1.SetToolTip(this.hcSceneGraph, resources.GetString("hcSceneGraph.ToolTip"));
            // 
            // groupBox7
            // 
            this.groupBox7.AccessibleDescription = null;
            this.groupBox7.AccessibleName = null;
            resources.ApplyResources(this.groupBox7, "groupBox7");
            this.groupBox7.BackgroundImage = null;
            this.groupBox7.Controls.Add(this.cbSimTemp);
            this.groupBox7.Controls.Add(this.cbDeep);
            this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox7, resources.GetString("groupBox7.ToolTip"));
            // 
            // cbSimTemp
            // 
            this.cbSimTemp.AccessibleDescription = null;
            this.cbSimTemp.AccessibleName = null;
            resources.ApplyResources(this.cbSimTemp, "cbSimTemp");
            this.cbSimTemp.BackgroundImage = null;
            this.cbSimTemp.Name = "cbSimTemp";
            this.toolTip1.SetToolTip(this.cbSimTemp, resources.GetString("cbSimTemp.ToolTip"));
            // 
            // cbDeep
            // 
            this.cbDeep.AccessibleDescription = null;
            this.cbDeep.AccessibleName = null;
            resources.ApplyResources(this.cbDeep, "cbDeep");
            this.cbDeep.BackgroundImage = null;
            this.cbDeep.Name = "cbDeep";
            this.toolTip1.SetToolTip(this.cbDeep, resources.GetString("cbDeep.ToolTip"));
            this.cbDeep.CheckedChanged += new System.EventHandler(this.cbDeep_CheckedChanged);
            // 
            // bb
            // 
            this.bb.AccessibleDescription = null;
            this.bb.AccessibleName = null;
            resources.ApplyResources(this.bb, "bb");
            this.bb.BackgroundImage = null;
            this.bb.Buttons.AddRange(new Divelements.Navisight.NavigationButton[] {
            this.nbFolders,
            this.nbCheck,
            this.nbSettings,
            this.nbCustom,
            this.nbSceneGraph,
            this.nbFileTable,
            this.nbPlugins,
            this.nbTools,
            this.nbIdent});
            this.bb.ButtonSpacing = 16;
            this.bb.Font = null;
            this.bb.Name = "bb";
            this.toolTip1.SetToolTip(this.bb, resources.GetString("bb.ToolTip"));
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
            // nbCustom
            // 
            this.nbCustom.Image = ((System.Drawing.Image)(resources.GetObject("nbCustom.Image")));
            resources.ApplyResources(this.nbCustom, "nbCustom");
            this.nbCustom.Activate += new System.EventHandler(this.SelectCategory);
            // 
            // nbSceneGraph
            // 
            this.nbSceneGraph.Image = ((System.Drawing.Image)(resources.GetObject("nbSceneGraph.Image")));
            resources.ApplyResources(this.nbSceneGraph, "nbSceneGraph");
            this.nbSceneGraph.Activate += new System.EventHandler(this.SelectCategory);
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
            this.hcPlugins.AccessibleDescription = null;
            this.hcPlugins.AccessibleName = null;
            resources.ApplyResources(this.hcPlugins, "hcPlugins");
            this.hcPlugins.BackgroundImage = null;
            this.hcPlugins.Controls.Add(this.btpup);
            this.hcPlugins.Controls.Add(this.btpdown);
            this.hcPlugins.Controls.Add(this.cnt);
            this.hcPlugins.Font = null;
            this.hcPlugins.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcPlugins.Name = "hcPlugins";
            this.toolTip1.SetToolTip(this.hcPlugins, resources.GetString("hcPlugins.ToolTip"));
            // 
            // btpup
            // 
            this.btpup.AccessibleDescription = null;
            this.btpup.AccessibleName = null;
            resources.ApplyResources(this.btpup, "btpup");
            this.btpup.BackgroundImage = null;
            this.btpup.Font = null;
            this.btpup.Name = "btpup";
            this.toolTip1.SetToolTip(this.btpup, resources.GetString("btpup.ToolTip"));
            this.btpup.Click += new System.EventHandler(this.btpup_Click);
            // 
            // btpdown
            // 
            this.btpdown.AccessibleDescription = null;
            this.btpdown.AccessibleName = null;
            resources.ApplyResources(this.btpdown, "btpdown");
            this.btpdown.BackgroundImage = null;
            this.btpdown.Font = null;
            this.btpdown.Name = "btpdown";
            this.toolTip1.SetToolTip(this.btpdown, resources.GetString("btpdown.ToolTip"));
            this.btpdown.Click += new System.EventHandler(this.btpdown_Click);
            // 
            // cnt
            // 
            this.cnt.AccessibleDescription = null;
            this.cnt.AccessibleName = null;
            resources.ApplyResources(this.cnt, "cnt");
            this.cnt.BackColor = System.Drawing.SystemColors.Window;
            this.cnt.BackgroundImage = null;
            this.cnt.Font = null;
            this.cnt.Name = "cnt";
            this.toolTip1.SetToolTip(this.cnt, resources.GetString("cnt.ToolTip"));
            // 
            // hcIdent
            // 
            this.hcIdent.AccessibleDescription = null;
            this.hcIdent.AccessibleName = null;
            resources.ApplyResources(this.hcIdent, "hcIdent");
            this.hcIdent.BackgroundImage = null;
            this.hcIdent.Controls.Add(this.linkLabel5);
            this.hcIdent.Controls.Add(this.cbValid);
            this.hcIdent.Controls.Add(this.linkLabel3);
            this.hcIdent.Controls.Add(this.tbUserId);
            this.hcIdent.Controls.Add(this.label13);
            this.hcIdent.Controls.Add(this.tbPassword);
            this.hcIdent.Controls.Add(this.label12);
            this.hcIdent.Controls.Add(this.tbUsername);
            this.hcIdent.Controls.Add(this.label11);
            this.hcIdent.Font = null;
            this.hcIdent.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcIdent.Name = "hcIdent";
            this.toolTip1.SetToolTip(this.hcIdent, resources.GetString("hcIdent.ToolTip"));
            // 
            // linkLabel5
            // 
            this.linkLabel5.AccessibleDescription = null;
            this.linkLabel5.AccessibleName = null;
            resources.ApplyResources(this.linkLabel5, "linkLabel5");
            this.linkLabel5.Font = null;
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel5, resources.GetString("linkLabel5.ToolTip"));
            this.linkLabel5.UseCompatibleTextRendering = true;
            this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
            // 
            // cbValid
            // 
            this.cbValid.AccessibleDescription = null;
            this.cbValid.AccessibleName = null;
            resources.ApplyResources(this.cbValid, "cbValid");
            this.cbValid.BackgroundImage = null;
            this.cbValid.Font = null;
            this.cbValid.Name = "cbValid";
            this.toolTip1.SetToolTip(this.cbValid, resources.GetString("cbValid.ToolTip"));
            // 
            // linkLabel3
            // 
            this.linkLabel3.AccessibleDescription = null;
            this.linkLabel3.AccessibleName = null;
            resources.ApplyResources(this.linkLabel3, "linkLabel3");
            this.linkLabel3.Font = null;
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.TabStop = true;
            this.toolTip1.SetToolTip(this.linkLabel3, resources.GetString("linkLabel3.ToolTip"));
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked_1);
            // 
            // tbUserId
            // 
            this.tbUserId.AccessibleDescription = null;
            this.tbUserId.AccessibleName = null;
            resources.ApplyResources(this.tbUserId, "tbUserId");
            this.tbUserId.BackgroundImage = null;
            this.tbUserId.Font = null;
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.ReadOnly = true;
            this.toolTip1.SetToolTip(this.tbUserId, resources.GetString("tbUserId.ToolTip"));
            this.tbUserId.TextChanged += new System.EventHandler(this.tbUserId_TextChanged);
            // 
            // label13
            // 
            this.label13.AccessibleDescription = null;
            this.label13.AccessibleName = null;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
            // 
            // tbPassword
            // 
            this.tbPassword.AccessibleDescription = null;
            this.tbPassword.AccessibleName = null;
            resources.ApplyResources(this.tbPassword, "tbPassword");
            this.tbPassword.BackgroundImage = null;
            this.tbPassword.Font = null;
            this.tbPassword.Name = "tbPassword";
            this.toolTip1.SetToolTip(this.tbPassword, resources.GetString("tbPassword.ToolTip"));
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label12
            // 
            this.label12.AccessibleDescription = null;
            this.label12.AccessibleName = null;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
            // 
            // tbUsername
            // 
            this.tbUsername.AccessibleDescription = null;
            this.tbUsername.AccessibleName = null;
            resources.ApplyResources(this.tbUsername, "tbUsername");
            this.tbUsername.BackgroundImage = null;
            this.tbUsername.Font = null;
            this.tbUsername.Name = "tbUsername";
            this.toolTip1.SetToolTip(this.tbUsername, resources.GetString("tbUsername.ToolTip"));
            this.tbUsername.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // label11
            // 
            this.label11.AccessibleDescription = null;
            this.label11.AccessibleName = null;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
            // 
            // hcCheck
            // 
            this.hcCheck.AccessibleDescription = null;
            this.hcCheck.AccessibleName = null;
            resources.ApplyResources(this.hcCheck, "hcCheck");
            this.hcCheck.BackgroundImage = null;
            this.hcCheck.Controls.Add(this.checkControl1);
            this.hcCheck.Font = null;
            this.hcCheck.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcCheck.Name = "hcCheck";
            this.toolTip1.SetToolTip(this.hcCheck, resources.GetString("hcCheck.ToolTip"));
            // 
            // checkControl1
            // 
            this.checkControl1.AccessibleDescription = null;
            this.checkControl1.AccessibleName = null;
            resources.ApplyResources(this.checkControl1, "checkControl1");
            this.checkControl1.BackgroundImage = null;
            this.checkControl1.Name = "checkControl1";
            this.toolTip1.SetToolTip(this.checkControl1, resources.GetString("checkControl1.ToolTip"));
            this.checkControl1.FixedFileTable += new System.EventHandler(this.checkControl1_FixedFileTable);
            // 
            // hcCustom
            // 
            this.hcCustom.AccessibleDescription = null;
            this.hcCustom.AccessibleName = null;
            resources.ApplyResources(this.hcCustom, "hcCustom");
            this.hcCustom.BackgroundImage = null;
            this.hcCustom.Controls.Add(this.pgcustom);
            this.hcCustom.Controls.Add(this.cbCustom);
            this.hcCustom.Font = null;
            this.hcCustom.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.hcCustom.Name = "hcCustom";
            this.toolTip1.SetToolTip(this.hcCustom, resources.GetString("hcCustom.ToolTip"));
            // 
            // pgcustom
            // 
            this.pgcustom.AccessibleDescription = null;
            this.pgcustom.AccessibleName = null;
            resources.ApplyResources(this.pgcustom, "pgcustom");
            this.pgcustom.BackgroundImage = null;
            this.pgcustom.CommandsBackColor = System.Drawing.SystemColors.Window;
            this.pgcustom.Font = null;
            this.pgcustom.LineColor = System.Drawing.SystemColors.ScrollBar;
            this.pgcustom.Name = "pgcustom";
            this.toolTip1.SetToolTip(this.pgcustom, resources.GetString("pgcustom.ToolTip"));
            // 
            // cbCustom
            // 
            this.cbCustom.AccessibleDescription = null;
            this.cbCustom.AccessibleName = null;
            resources.ApplyResources(this.cbCustom, "cbCustom");
            this.cbCustom.BackgroundImage = null;
            this.cbCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustom.Font = null;
            this.cbCustom.Name = "cbCustom";
            this.toolTip1.SetToolTip(this.cbCustom, resources.GetString("cbCustom.ToolTip"));
            this.cbCustom.SelectedIndexChanged += new System.EventHandler(this.cbCustom_SelectedIndexChanged);
            // 
            // baloonTip
            // 
            this.baloonTip.Enabled = true;
            // 
            // navigationButton1
            // 
            resources.ApplyResources(this.navigationButton1, "navigationButton1");
            // 
            // navigationButton2
            // 
            resources.ApplyResources(this.navigationButton2, "navigationButton2");
            // 
            // OptionForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = null;
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
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
            this.groupBox7.ResumeLayout(false);
            this.hcPlugins.ResumeLayout(false);
            this.hcIdent.ResumeLayout(false);
            this.hcIdent.PerformLayout();
            this.hcCheck.ResumeLayout(false);
            this.hcCustom.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        void Execute()
        {
            this.Tag = true;
            //linkLabel3.Enabled = (Helper.WindowsRegistry.EPInstalled>=1);
            tbgame.Text = PathProvider.Global[Expansions.BaseGame].InstallFolder;
            tbep1.Text = PathProvider.Global[Expansions.University].InstallFolder;
            tbep2.Text = PathProvider.Global[Expansions.Business].InstallFolder;
            //tbep1.Text = Helper.WindowsRegistry.RealEP1GamePath;
            tbsavegame.Text = PathProvider.Global.SimSavegameFolder;
            tbdds.Text = PathProvider.Global.NvidiaDDSPath;
            this.cbdebug.Checked = Helper.WindowsRegistry.GameDebug;
            cbautobak.Checked = Helper.WindowsRegistry.AutoBackup;
            cbblur.Checked = Helper.WindowsRegistry.BlurNudity;
            cbsound.Checked = Helper.WindowsRegistry.EnableSound;
            cbwait.Checked = Helper.WindowsRegistry.WaitingScreen;
            cbow.Checked = Helper.WindowsRegistry.LoadOWFast;
            cbsilent.Checked = Helper.WindowsRegistry.Silent;
            cbcache.Checked = Helper.WindowsRegistry.UseCache;
            cbshowobjd.Checked = Helper.WindowsRegistry.ShowObjdNames;
            cbhidden.Checked = Helper.WindowsRegistry.HiddenMode;
            cbjointname.Checked = Helper.WindowsRegistry.ShowJointNames;
            tbthumb.Text = Helper.WindowsRegistry.OWThumbSize.ToString();
            tbscale.Text = Helper.WindowsRegistry.ImportExportScaleFactor.ToString();
            cbupdate.Checked = Helper.WindowsRegistry.CheckForUpdates;
            cbpkgmaint.Checked = Helper.WindowsRegistry.UsePackageMaintainer;
            cbmulti.Checked = Helper.WindowsRegistry.MultipleFiles;
            cbSimple.Checked = Helper.WindowsRegistry.SimpleResourceSelect;
            cbFirefox.Checked = Helper.WindowsRegistry.FirefoxTabbing;
            cbDeep.Checked = Helper.WindowsRegistry.DeepSimScan;
            cbSimTemp.Checked = Helper.WindowsRegistry.DeepSimTemplateScan;
            cbAsync.Checked = Helper.WindowsRegistry.AsynchronLoad;

            cbLock.Checked = Helper.WindowsRegistry.LockDocks;
            this.cbLock_CheckedChanged(cbLock, null);

            this.tbUserId.Text = "0x" + Helper.HexString(Helper.WindowsRegistry.CachedUserId);
            this.tbUsername.Text = Helper.WindowsRegistry.Username;
            this.tbPassword.Text = Helper.WindowsRegistry.Password;

            this.tbep1.ReadOnly = (PathProvider.Global.EPInstalled < 1);
            this.tbep2.ReadOnly = (PathProvider.Global.EPInstalled < 2);
            this.button5.Enabled = (PathProvider.Global.EPInstalled >= 1);
            this.btNightlife.Enabled = (PathProvider.Global.EPInstalled >= 2);
            llsetep1.Enabled = button5.Enabled;
            llNightlife.Enabled = btNightlife.Enabled;

            if (((byte)Helper.WindowsRegistry.LanguageCode <= cblang.Items.Count) && ((byte)Helper.WindowsRegistry.LanguageCode > 0))
            {
                cblang.SelectedIndex = (byte)Helper.WindowsRegistry.LanguageCode - 1;
            }

            lbext.Items.Clear();
            foreach (ToolLoaderItemExt tli in ToolLoaderExt.Items) lbext.Items.Add(tli);

            //FileTable
            ArrayList folders = FileTable.DefaultFolders;
            lbfolder.Items.Clear();
            foreach (FileTableItem fti in folders)
            {
                lbfolder.Items.Add(fti, !fti.Ignore);
            }

            //Favorite Theme
            GuiTheme gt = (GuiTheme)Helper.WindowsRegistry.Layout.SelectedTheme;
            for (int i = 0; i < cbThemes.Items.Count; i++)
                if ((GuiTheme)cbThemes.Items[i] == gt)
                    cbThemes.SelectedIndex = i;

            //Report Format
            SimPe.Registry.ReportFormats rf = (SimPe.Registry.ReportFormats)Helper.WindowsRegistry.ReportFormat;
            for (int i = 0; i < cbReport.Items.Count; i++)
                if ((SimPe.Registry.ReportFormats)cbReport.Items[i] == rf)
                    cbReport.SelectedIndex = i;

            //state
            cbSimTemp.Enabled = cbDeep.Checked;

            this.Tag = null;
            btReload.Enabled = false;
            SetupFileTableCheckboxes();
            this.ShowDialog();
        }

        private void SaveOptionsClick(object sender, System.EventArgs e)
        {
            /*Helper.WindowsRegistry.SimsPath = this.tbgame.Text;
            Helper.WindowsRegistry.SimsEP1Path = this.tbep1.Text;
            Helper.WindowsRegistry.SimsEP2Path = this.tbep2.Text;
            Helper.WindowsRegistry.SimSavegameFolder = this.tbsavegame.Text;*/
            PathProvider.Global.NvidiaDDSPath = tbdds.Text;
            Helper.WindowsRegistry.LanguageCode = (Data.MetaData.Languages)cblang.SelectedIndex + 1;
            Helper.WindowsRegistry.GameDebug = cbdebug.Checked;
            Helper.WindowsRegistry.AutoBackup = cbautobak.Checked;
            //Helper.WindowsRegistry.BlurNudity = cbblur.Checked;
            Helper.WindowsRegistry.EnableSound = cbsound.Checked;
            Helper.WindowsRegistry.WaitingScreen = cbwait.Checked;
            Helper.WindowsRegistry.LoadOWFast = cbow.Checked;
            Helper.WindowsRegistry.Silent = cbsilent.Checked;
            Helper.WindowsRegistry.UseCache = cbcache.Checked;
            Helper.WindowsRegistry.ShowObjdNames = cbshowobjd.Checked;
            Helper.WindowsRegistry.HiddenMode = cbhidden.Checked;
            Helper.WindowsRegistry.ShowJointNames = cbjointname.Checked;
            Helper.WindowsRegistry.CheckForUpdates = cbupdate.Checked;
            Helper.WindowsRegistry.UsePackageMaintainer = cbpkgmaint.Checked;
            Helper.WindowsRegistry.MultipleFiles = cbmulti.Checked;
            Helper.WindowsRegistry.Layout.SelectedTheme = (byte)cbThemes.Items[cbThemes.SelectedIndex];
            Helper.WindowsRegistry.SimpleResourceSelect = cbSimple.Checked;
            Helper.WindowsRegistry.FirefoxTabbing = cbFirefox.Checked;
            Helper.WindowsRegistry.DeepSimScan = cbDeep.Checked;
            Helper.WindowsRegistry.DeepSimTemplateScan = cbSimTemp.Checked;
            Helper.WindowsRegistry.AsynchronLoad = cbAsync.Checked;
            Helper.WindowsRegistry.ReportFormat = (Registry.ReportFormats)cbReport.SelectedItem;
            Helper.WindowsRegistry.LockDocks = cbLock.Checked;

            Helper.WindowsRegistry.Username = tbUsername.Text;
            Helper.WindowsRegistry.Password = tbPassword.Text;
            Helper.WindowsRegistry.CachedUserId = Helper.StringToUInt32(tbUserId.Text, 0, 16);

            StoreFoldersXml();
            try
            {
                Helper.WindowsRegistry.OWThumbSize = Convert.ToInt32(tbthumb.Text);
                Helper.WindowsRegistry.ImportExportScaleFactor = Convert.ToSingle(tbscale.Text);
            }
            catch { }



            ToolLoaderExt.Items = new ToolLoaderItemExt[0];
            foreach (ToolLoaderItemExt tli in lbext.Items) ToolLoaderExt.Add(tli); ;
            ToolLoaderExt.StoreTools();

            Helper.WindowsRegistry.Flush();

            FileTable.FileIndex.BaseFolders.Clear();
            FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;

            Close();
        }

        private void DeleteExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbext.SelectedIndex < 0) return;
            lbext.Items.Remove(lbext.Items[lbext.SelectedIndex]);
        }

        private void AddExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            AddExtTool aet = new AddExtTool();
            ToolLoaderItemExt tli = aet.Execute();

            if (tli != null) lbext.Items.Add(tli);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbgame.Text)) fbd.SelectedPath = tbgame.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbgame.Text = fbd.SelectedPath;
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbsavegame.Text)) fbd.SelectedPath = tbsavegame.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbsavegame.Text = fbd.SelectedPath;
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbdds.Text)) ofd.InitialDirectory = tbdds.Text;
            if (ofd.ShowDialog() == DialogResult.OK) this.tbdds.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
        }

        private void label2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbgame.Text = PathProvider.Global[Expansions.BaseGame].RealInstallFolder;
        }

        private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep1.Text = PathProvider.Global[Expansions.University].RealInstallFolder;
        }

        private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbsavegame.Text = PathProvider.Global.RealSavegamePath;
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbep1.Text)) fbd.SelectedPath = tbep1.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbep1.Text = fbd.SelectedPath;
        }

        private void ClearCaches(object sender, System.EventArgs e)
        {
            SimPe.CheckControl.ClearCache();
        }

        private void DDSChanged(object sender, System.EventArgs e)
        {
            string name = System.IO.Path.Combine(this.tbdds.Text, "nvdxt.exe");
            lldds.Visible = (!System.IO.File.Exists(name));
            lldds2.Visible = lldds.Visible;
        }

        private void LoadDDS(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Windows.Forms.Help.ShowHelp(this, "http://developer.nvidia.com/object/nv_texture_tools.html");
        }

        private void lladddown_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            FileTableItem fti = new FileTableItem("Downloads", true, false, -1);
            fti.Name = System.IO.Path.Combine(PathProvider.Global.SimSavegameFolder, "Downloads");
            fti.Type = FileTablePaths.SaveGameFolder;
            lbfolder.Items.Insert(0, fti);
            this.btReload.Enabled = true;
            SetupFileTableCheckboxes();
        }

        private void btup_Click(object sender, System.EventArgs e)
        {
            if (lbfolder.SelectedIndex < 1) return;
            object o = lbfolder.Items[lbfolder.SelectedIndex - 1];
            lbfolder.Items[lbfolder.SelectedIndex - 1] = lbfolder.Items[lbfolder.SelectedIndex];
            lbfolder.Items[lbfolder.SelectedIndex] = o;

            bool sel = lbfolder.GetItemChecked(lbfolder.SelectedIndex - 1);
            lbfolder.SetItemChecked(lbfolder.SelectedIndex - 1, lbfolder.GetItemChecked(lbfolder.SelectedIndex));
            lbfolder.SetItemChecked(lbfolder.SelectedIndex, sel);

            lbfolder.SelectedIndex--;
            this.btReload.Enabled = true;
        }

        private void btdn_Click(object sender, System.EventArgs e)
        {
            if (lbfolder.SelectedIndex > lbfolder.Items.Count - 2) return;
            object o = lbfolder.Items[lbfolder.SelectedIndex + 1];
            lbfolder.Items[lbfolder.SelectedIndex + 1] = lbfolder.Items[lbfolder.SelectedIndex];
            lbfolder.Items[lbfolder.SelectedIndex] = o;

            bool sel = lbfolder.GetItemChecked(lbfolder.SelectedIndex + 1);
            lbfolder.SetItemChecked(lbfolder.SelectedIndex + 1, lbfolder.GetItemChecked(lbfolder.SelectedIndex));
            lbfolder.SetItemChecked(lbfolder.SelectedIndex, sel);

            lbfolder.SelectedIndex++;
            this.btReload.Enabled = true;
        }

        private void lldel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbfolder.SelectedIndex < 0) return;
            lbfolder.Items.RemoveAt(lbfolder.SelectedIndex);
            this.btReload.Enabled = true;
            SetupFileTableCheckboxes();
        }

        private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            FileTableItem fti = FileTableItemForm.Execute();
            if (fti != null)
            {
                lbfolder.Items.Insert(0, fti);
                this.btReload.Enabled = true;
                SetupFileTableCheckboxes();
            }
        }

        void StoreFoldersXml()
        {
            try
            {
                System.IO.TextWriter tw = System.IO.File.CreateText(FileTable.FolderFile);

                try
                {
                    tw.WriteLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
                    tw.WriteLine("<folders>");
                    tw.WriteLine("  <filetable>");
                    foreach (FileTableItem fti in lbfolder.Items)
                    {
                        if (fti.IsFile) tw.Write("     <file");
                        else tw.Write("     <path");

                        if (fti.Type != FileTablePaths.Absolute)
                        {
                            bool ok = false;
                            foreach (ExpansionItem ei in PathProvider.Global.Expansions)
                            {
                                if (fti.Type == ei.Expansion)
                                {
                                    tw.Write(" root=\""+ei.ShortId.ToLower()+"\"");
                                    ok = true;
                                    break;
                                }
                            }
                            if (!ok)
                            {
                                switch (fti.Type.AsUint)
                                {

                                    case (uint)FileTablePaths.SaveGameFolder:
                                        {
                                            tw.Write(" root=\"save\"");
                                            break;
                                        }
                                    case (uint)FileTablePaths.SimPEFolder:
                                        {
                                            tw.Write(" root=\"simpe\"");
                                            break;
                                        }
                                    case (uint)FileTablePaths.SimPEDataFolder:
                                        {
                                            tw.Write(" root=\"simpeData\"");
                                            break;
                                        }
                                    case (uint)FileTablePaths.SimPEPluginFolder:
                                        {
                                            tw.Write(" root=\"simpePlugin\"");
                                            break;
                                        }
                                } //switch
                            }
                        }

                        if (fti.IsRecursive) tw.Write(" recursive=\"1\"");
                        if (fti.EpVersion >= 0) tw.Write(" version=\"" + fti.EpVersion.ToString() + "\"");
                        if (fti.Ignore) tw.Write(" ignore=\"1\"");

                        tw.Write(">");
                        tw.Write(fti.RelativePath);
                        if (fti.IsFile)
                        {
                            tw.WriteLine("</file>");
                        }
                        else
                        {
                            tw.WriteLine("</path>");
                        }

                    }
                    tw.WriteLine("  </filetable>");
                    tw.WriteLine("</folders>");

                }
                finally
                {
                    tw.Close();
                }
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("", ex);
            }
        }

        private void visualStyleLinkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep1.Text = SimPe.PathProvider.Global[Expansions.University].RealInstallFolder;
        }

        void EnablePanel(Divelements.Navisight.NavigationButton panel)
        {
            hcFolders.Visible = (panel == nbFolders);
            hcSettings.Visible = (panel == nbSettings);
            hcTools.Visible = (panel == nbTools);
            hcFileTable.Visible = (panel == nbFileTable);
            hcSceneGraph.Visible = (panel == nbSceneGraph);
            hcPlugins.Visible = (panel == nbPlugins);
            hcIdent.Visible = (panel == nbIdent);
            hcCheck.Visible = (panel == nbCheck);
            hcCustom.Visible = (panel == nbCustom);
        }

        private void SelectCategory(object sender, System.EventArgs e)
        {
            foreach (Divelements.Navisight.NavigationButton nb in bb.Buttons)
            {
                nb.Checked = (nb == sender);

                if (nb.Checked)
                {
                    if (nb == nbFolders) EnablePanel(nbFolders);
                    else if (nb == nbSettings) EnablePanel(nbSettings);
                    else if (nb == nbTools) EnablePanel(nbTools);
                    else if (nb == nbFileTable) EnablePanel(nbFileTable);
                    else if (nb == nbSceneGraph) EnablePanel(nbSceneGraph);
                    else if (nb == nbPlugins) EnablePanel(nbPlugins);
                    else if (nb == nbIdent) EnablePanel(nbIdent);
                    else if (nb == nbCheck) EnablePanel(nbCheck);
                    else if (nb == nbCustom) EnablePanel(nbCustom);
                }
            }
        }

        private void ChangedThemeHandler(object sender, System.EventArgs e)
        {
            if (NewTheme != null) NewTheme((SimPe.GuiTheme)cbThemes.Items[cbThemes.SelectedIndex]);
        }

        private void ResetLayoutClick(object sender, System.EventArgs e)
        {
            if (ResetLayout != null) ResetLayout(this, e);
        }

        private void LockDocksClick(object sender, System.EventArgs e)
        {
            if (LockDocks != null) LockDocks(this, e);
        }

        private void UnlockDocksClick(object sender, System.EventArgs e)
        {
            if (UnlockDocks != null) UnlockDocks(this, e);
        }

        #region Events
        public event SimPe.Events.ChangedThemeEvent NewTheme;
        public event System.EventHandler ResetLayout;
        public event System.EventHandler LockDocks;
        public event System.EventHandler UnlockDocks;
        #endregion

        #region Plugins
        public Image GetImage(SimPe.Interfaces.IWrapper wrapper)
        {
            if (uids.Contains(wrapper.WrapperDescription.UID))
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png"));

            if (wrapper.Priority >= 0)
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.enabled.png"));

            return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.disabled.png"));
        }

        public void SetPanel(SimPe.Interfaces.IWrapper wrapper, TD.Eyefinder.HeaderControl pn)
        {


            if (wrapper.Priority < 0)
            {
                pn.Text = "(" + wrapper.WrapperDescription.Name + ")";
                pn.ForeColor = SystemColors.ControlDarkDark;
            }
            else
            {
                pn.Text = wrapper.WrapperDescription.Name;
                pn.ForeColor = SystemColors.ControlText;
            }
            pn.Text = "     " + pn.Text;

        }

        public Image GetShrinkImage(TD.Eyefinder.HeaderControl pn)
        {
            if (pn.Height == pn.DisplayRectangle.Top + 1)
            {
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.expand.png"));
            }
            else
            {
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.shrink.png"));
            }

        }

        public bool ThumbnailCallback()
        {
            return false;
        }


        System.Collections.ArrayList uids;
        System.Collections.ArrayList wrappers;
#if DEBUG
        const int height = 148;
#else
		const int height = 116;
#endif
        public Control BuildPanel(SimPe.Interfaces.IWrapper wrapper, ThemeManager tm, int index)
        {
            if (uids == null) uids = new ArrayList();
            if (wrappers == null) wrappers = new ArrayList();

            if (wrapper.Priority >= 0) wrapper.Priority = index + 1;
            else wrapper.Priority = -1 * (index + 1);



            const int imgwidth = 22;
            int top = 4 + index * (height + 4);
            TD.Eyefinder.HeaderControl pn = new TD.Eyefinder.HeaderControl();
            pn.Parent = cnt;
            pn.Top = top;
            pn.Left = 4;
            pn.Width = cnt.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth - 2 - 2 * pn.Left;
            pn.Height = height;
            pn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
            pn.HeaderStyle = TD.Eyefinder.HeaderStyle.SubHeading;
            pn.Click += new EventHandler(pn_Click);
            pn.LostFocus += new EventHandler(pn_LostFocus);
            pn.GotFocus += new EventHandler(pn_Focused);
            pn.Enter += new EventHandler(pn_Focused);
            pn.Leave += new EventHandler(pn_LostFocus);
            pn_LostFocus(pn, null);
            SetPanel(wrapper, pn);
            pn.Tag = wrapper;
            pn.Dock = DockStyle.Top;

            wrappers.Add(pn);

            #region Author
            Label lbauthor = new Label();
            lbauthor.Parent = pn;
            lbauthor.Top = pn.DisplayRectangle.Top + 8;
            lbauthor.Left = 8;
            lbauthor.Text = "Author:";
            lbauthor.Width = 85;
            lbauthor.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Bold, cnt.Font.Unit);
            lbauthor.Height = (int)lbauthor.Font.SizeInPoints * 2;
            lbauthor.ForeColor = SystemColors.ControlDarkDark;
            lbauthor.TextAlign = ContentAlignment.TopRight;
            lbauthor.Click += new EventHandler(pn_Click);

            Label lb = new Label();
            lb.Parent = pn;
            lb.Top = lbauthor.Top;
            lb.Left = lbauthor.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperDescription.Author;
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region Version
            Label lbversion = new Label();
            lbversion.Parent = pn;
            lbversion.Top = lbauthor.Top;
            lbversion.Left = lb.Right + 16;
            lbversion.Width = lbauthor.Width;
            lbversion.Height = lbauthor.Height;
            lbversion.Text = "Version:";
            lbversion.Font = lbauthor.Font;
            lbversion.ForeColor = lbauthor.ForeColor;
            lbversion.TextAlign = lbauthor.TextAlign;
            lbversion.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbversion.Top;
            lb.Left = lbversion.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperDescription.Version.ToString();
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region FileName
            Label lbfile = new Label();
            lbfile.Parent = pn;
            lbfile.Top = lbversion.Bottom;
            lbfile.Left = lbauthor.Left;
            lbfile.Width = lbauthor.Width;
            lbfile.Height = lbauthor.Height;
            lbfile.Text = "Filename:";
            lbfile.Font = lbauthor.Font;
            lbfile.ForeColor = lbauthor.ForeColor;
            lbfile.TextAlign = lbauthor.TextAlign;
            lbfile.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbfile.Top;
            lb.Left = lbfile.Right + 4;
            lb.AutoSize = true;
            lb.Text = wrapper.WrapperFileName;
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region UID
            Label lbui = new Label();
            lbui.Parent = pn;
            lbui.Top = lbfile.Bottom;
            lbui.Left = lbauthor.Left;
            lbui.Width = lbauthor.Width;
            lbui.Height = lbauthor.Height;
            lbui.Text = "UID:";
            lbui.Font = lbauthor.Font;
            lbui.ForeColor = lbauthor.ForeColor;
            lbui.TextAlign = lbauthor.TextAlign;
            lbui.Click += new EventHandler(pn_Click);

            lb = new Label();
            lb.Parent = pn;
            lb.Top = lbui.Top;
            lb.Left = lbui.Right + 4;
            lb.AutoSize = true;
            lb.Text = "0x" + Helper.HexString(wrapper.WrapperDescription.UID);
            lb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            lb.Height = lbauthor.Height;
            lb.ForeColor = lbauthor.ForeColor;
            lb.Click += new EventHandler(pn_Click);
            #endregion

            #region Description
            Label lbdesc = new Label();
            lbdesc.Parent = pn;
            lbdesc.Top = lbui.Bottom;
            lbdesc.Left = lbauthor.Left;
            lbdesc.Width = lbauthor.Width;
            lbdesc.Height = lbauthor.Height;
            lbdesc.Text = "Description:";
            lbdesc.Font = lbauthor.Font;
            lbdesc.ForeColor = lbauthor.ForeColor;
            lbdesc.TextAlign = lbauthor.TextAlign;
            lbdesc.Click += new EventHandler(pn_Click);

            TextBox tb = new TextBox();
            tb.Parent = pn;
            tb.Top = lbdesc.Top;
            tb.Left = lbdesc.Right + 4;
            tb.Width = pn.Width - lb.Left - imgwidth - 12;
            tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            tb.Text = wrapper.WrapperDescription.Description;
#if DEBUG
            tb.Text += Helper.lbr + wrapper.GetType().FullName + " " + wrapper.GetType().Assembly.FullName;
#endif
            tb.Multiline = true;
            tb.WordWrap = true;
            tb.ScrollBars = ScrollBars.Vertical;
            tb.BorderStyle = BorderStyle.None;
            tb.BackColor = pn.BackColor;

            tb.Font = new Font(cnt.Font.Name, cnt.Font.Size, FontStyle.Regular, cnt.Font.Unit);
            tb.Height = pn.Height - tb.Top - 8;
            tb.ForeColor = lbauthor.ForeColor;
            tb.GotFocus += new EventHandler(tb_GotFocus);
            tb.Enter += new EventHandler(tb_GotFocus);
            tb.ReadOnly = true;
            #endregion

            PictureBox pb = null;

            if (wrapper.AllowMultipleInstances)
            {
                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = imgwidth;
                pb.Height = imgwidth;
                pb.Left = pn.Width - 2 * pb.Width - 16;
                pb.Top = pn.DisplayRectangle.Top + 4; //pn.DisplayRectangle.Top + 4 + pb.Height + 4; //pn.Height - 2*pb.Height -16;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.multienabled.png"));
                pb.Click += new EventHandler(pn_Click);
                this.toolTip1.SetToolTip(pb, "Allows Multiple instance");


                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = pn.DisplayRectangle.Top + 1;
                pb.Height = pn.DisplayRectangle.Top;
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
                pb.Left = pn.Width - 3 * pb.Width - pb.Top;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.smallmultienabled.png"));
                pb.BackColor = Color.Transparent;

                this.toolTip1.SetToolTip(pb, "Allows Multiple instance.");
            }

            if (wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper)
            {
                pb = new PictureBox();
                pb.Parent = pn;
                pb.Width = pn.DisplayRectangle.Top + 1;
                pb.Height = pn.DisplayRectangle.Top;
                pb.SizeMode = PictureBoxSizeMode.CenterImage;
                pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
                if (wrapper.AllowMultipleInstances) pb.Left = pn.Width - 4 * pb.Width - pb.Top;
                else pb.Left = pn.Width - 3 * pb.Width - pb.Top;
                pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png")).GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero); ;
                pb.BackColor = Color.Transparent;
                this.toolTip1.SetToolTip(pb, "This wrapper caused an Error while loading.");
            }

            PictureBox ipb = new PictureBox();
            ipb.Parent = pn;
            ipb.Left = 2;
            ipb.Top = 1;
            ipb.BackColor = Color.Transparent;
            ipb.SizeMode = PictureBoxSizeMode.StretchImage;
            if (wrapper.WrapperDescription.Icon != null)
            {
                ipb.Height = Math.Min(wrapper.WrapperDescription.Icon.Height, pn.DisplayRectangle.Top - 2);
                ipb.Width = Math.Min(wrapper.WrapperDescription.Icon.Width, pn.DisplayRectangle.Top - 2);
                ipb.Image = wrapper.WrapperDescription.Icon;
            }
            else
            {
                ipb.Height = 16;
                ipb.Width = 16;
                //				ipb.Image = FileTable.WrapperRegistry.WrapperImageList.Images[1];
            }

            PictureBox pbe = new PictureBox();
            pbe.Parent = pn;
            pbe.Width = pn.DisplayRectangle.Top + 1;
            pbe.Height = pn.DisplayRectangle.Top;
            pbe.SizeMode = PictureBoxSizeMode.CenterImage;
            pbe.Top = (pn.DisplayRectangle.Top + 1 - pbe.Height) / 2;
            pbe.Left = pn.Width - pbe.Width - pbe.Top;
            pbe.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pbe.Image = GetShrinkImage(pn);
            pbe.Tag = pn;
            pbe.BackColor = Color.Transparent;
            pbe.Click += new EventHandler(pb_ExpandClick);
            this.toolTip1.SetToolTip(pbe, "Collapse/Expand");

            pb = new PictureBox();
            pb.Parent = pn;
            pb.Width = imgwidth;
            pb.Height = imgwidth;
            pb.Left = pn.Width - pb.Width - 8;
            pb.Top = pn.DisplayRectangle.Top + 4; //pn.Height - pb.Height -8;
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb.Image = GetImage(wrapper);
            pb.Tag = pn;
            pb.BackColor = Color.Transparent;
            pb.Click += new EventHandler(pb_Click);
            this.toolTip1.SetToolTip(pb, "Enable/Disable");

            pb = new PictureBox();
            pb.Parent = pn;
            pb.Width = pn.DisplayRectangle.Top + 1;
            pb.Height = pn.DisplayRectangle.Top;
            pb.SizeMode = PictureBoxSizeMode.CenterImage;
            pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
            pb.Left = pn.Width - 2 * pb.Width - pb.Top;
            pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pb.Image = GetImage(wrapper).GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            pb.BackColor = Color.Transparent;
            pb.Tag = pn;
            pb.Click += new EventHandler(pb_Click);
            this.toolTip1.SetToolTip(pb, "Enable/Disable");

            Panel pan = new Panel();
            pan.BackColor = this.cnt.BackColor;
            pan.Parent = pn;
            pan.Height = 4;
            pan.Dock = DockStyle.Bottom;

            uids.Add(wrapper.WrapperDescription.UID);
            pb_ExpandClick(pbe, null);
            return pn;
        }

        public void Execute(Icon icon)
        {
            ThemeManager tm = new ThemeManager(ThemeManager.Global.CurrentTheme);
            tm.Parent = ThemeManager.Global;

            OptionForm f = this;
            if (icon != null) f.Icon = icon;
            SimPe.Interfaces.IWrapper[] wrappers = FileTable.WrapperRegistry.AllWrappers;

            for (int ct = wrappers.Length - 1; ct >= 0; ct--)
            {
                SimPe.Interfaces.IWrapper wrapper = wrappers[ct];
                f.cnt.Controls.Add(f.BuildPanel(wrapper, tm, ct));
            }

            f.uids.Clear();
            if (f.cnt.Controls.Count > 0) f.cnt.Controls[0].Focus();

            f.Execute();

            foreach (SimPe.Interfaces.IWrapper wrapper in wrappers)
            {
                if (!(wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper))
                    Helper.WindowsRegistry.SetWrapperPriority(wrapper.WrapperDescription.UID, wrapper.Priority);
            }
        }

        private void pn_Click(object sender, EventArgs e)
        {
            if (sender is TD.Eyefinder.HeaderControl)
            {
                TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
                pn.Focus();
            }
            else if (sender is Control)
            {
                TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)((Control)sender).Parent;
                pn.Focus();
            }
        }

        TD.Eyefinder.HeaderControl lastpn;
        private void pn_Focused(object sender, EventArgs e)
        {
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
            pn.BackColor = SystemColors.Window;
            pn.Font = new Font(pn.Font.Name, pn.Font.Size, FontStyle.Bold, pn.Font.Unit);

            btpup.Enabled = wrappers[0] != pn;
            btpdown.Enabled = wrappers[wrappers.Count - 1] != pn;

            lastpn = pn;
            if (pn.Controls.Count > 9) pn.Controls[9].BackColor = pn.BackColor;
        }

        private void pn_LostFocus(object sender, EventArgs e)
        {
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;
            pn.BackColor = SystemColors.ControlLight;
            pn.Font = new Font(pn.Font.Name, pn.Font.Size, FontStyle.Regular, pn.Font.Unit);
            if (pn.Controls.Count > 9) pn.Controls[9].BackColor = pn.BackColor;
        }

        private void pb_Click(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;
            SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;

            wrapper.Priority *= -1;
            SetPanel(wrapper, pn);

            Image i = this.GetImage(wrapper);

            SetBackgroundColor(pn.Controls[pn.Controls.Count - 2], i, true);
            SetBackgroundColor(pn.Controls[pn.Controls.Count - 3], i, false);
        }

        int FindPanelIndex(TD.Eyefinder.HeaderControl pn)
        {
            for (int i = 0; i < wrappers.Count; i++)
            {
                if (wrappers[i] == pn) return i;
            }

            return -1;
        }

        void Exchange(int index, int o)
        {
            TD.Eyefinder.HeaderControl pn1 = (TD.Eyefinder.HeaderControl)wrappers[index];
            TD.Eyefinder.HeaderControl pn2 = (TD.Eyefinder.HeaderControl)wrappers[index + o];

            int d = pn1.Top;
            pn1.Top = pn2.Top;
            pn2.Top = d;
            SimPe.Interfaces.IWrapper w1 = (SimPe.Interfaces.IWrapper)pn1.Tag;
            SimPe.Interfaces.IWrapper w2 = (SimPe.Interfaces.IWrapper)pn2.Tag;

            int p1 = w1.Priority;
            int p2 = w2.Priority;

            if (p1 >= 0) w1.Priority = Math.Abs(p2);
            else w1.Priority = -1 * Math.Abs(p2);

            if (p2 >= 0) w2.Priority = Math.Abs(p1);
            else w2.Priority = -1 * Math.Abs(p1);

            wrappers[index] = pn2;
            wrappers[index + o] = pn1;

            cnt.Controls.SetChildIndex(pn1, index + o);
        }

        private void btpup_Click(object sender, System.EventArgs e)
        {
            if (lastpn == null) return;

            int index = FindPanelIndex(lastpn);
            if (index < 1) return;

            Exchange(index, -1);

            lastpn.Focus();
        }

        private void btpdown_Click(object sender, System.EventArgs e)
        {
            if (lastpn == null) return;

            int index = FindPanelIndex(lastpn);
            if (index < 0) return;
            if (index >= wrappers.Count - 1) return;

            Exchange(index, 1);

            lastpn.Focus();
        }

        void SetBackgroundColor(object sender, Image i, bool small)
        {
            PictureBox pb = (PictureBox)sender;
            if (small) pb.Image = i.GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
            else pb.Image = i;
            /*if (wrapper.Priority<0) pb.BackColor = Color.FromArgb(0x70FF5B60);
            else pb.BackColor = Color.FromArgb(0x7087D300);*/
        }

        private void pb_ExpandClick(object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;

            if (pn.Height == pn.DisplayRectangle.Top + 1)
            {
                pn.Controls[pn.Controls.Count - 1].Visible = true;
                pn.Height = height;
            }
            else
            {
                pn.Controls[pn.Controls.Count - 1].Visible = false;
                pn.Height = pn.DisplayRectangle.Top + 1;
            }


            pb.Image = GetShrinkImage(pn);
            SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;
            //SetBackgroundColor(pb, wrapper);
        }


        private void tb_GotFocus(object sender, EventArgs e)
        {
            if (lastpn != null)
            {
                this.pn_Focused(lastpn, null);
            }
        }

        #endregion

        private void cbmulti_CheckedChanged(object sender, System.EventArgs e)
        {
            cbFirefox.Enabled = cbmulti.Checked;
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            Helper.WindowsRegistry.ClearRecentFileList();
        }

        private void tbPassword_Leave(object sender, System.EventArgs e)
        {
            tbUserId_TextChanged(null, null);
            if (this.Tag != null) return;

            uint guid = Sims.GUID.GUIDGetterForm.GetUserGuid(tbUsername.Text, tbPassword.Text);
            uint uid = UserVerification.GenerateUserId(guid, tbUsername.Text, tbPassword.Text);

            tbUserId.Text = "0x" + Helper.HexString(uid);
            tbUserId_TextChanged(null, null);
        }

        private void linkLabel3_LinkClicked_1(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbPassword_Leave(null, null);
        }

        private void tbUserId_TextChanged(object sender, System.EventArgs e)
        {
            uint i = Helper.StringToUInt32(tbUserId.Text, 0, 16);
            cbValid.Checked = UserVerification.ValidUserId(i, tbUsername.Text, tbPassword.Text);
        }

        private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbUserId.Text = "0x" + Helper.HexString(0);
        }

        private void llNightlife_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            tbep2.Text = PathProvider.Global[Expansions.Nightlife].RealInstallFolder;
        }

        private void btNightlife_Click(object sender, System.EventArgs e)
        {
            if (System.IO.Directory.Exists(tbep2.Text)) fbd.SelectedPath = tbep2.Text;
            if (fbd.ShowDialog() == DialogResult.OK) this.tbep2.Text = fbd.SelectedPath;
        }

        private void cbblur_CheckedChanged(object sender, System.EventArgs e)
        {
            Helper.WindowsRegistry.BlurNudity = cbblur.Checked;
            cbblur.Checked = Helper.WindowsRegistry.BlurNudity;
        }

        private void llchg_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            if (lbfolder.SelectedItem != null)
                if (FileTableItemForm.Execute((FileTableItem)lbfolder.SelectedItem))
                {
                    lbfolder.Items[lbfolder.SelectedIndex] = (FileTableItem)lbfolder.SelectedItem;
                    this.btReload.Enabled = true;
                    SetupFileTableCheckboxes();
                }
        }

        private void cbDeep_CheckedChanged(object sender, System.EventArgs e)
        {
            cbSimTemp.Enabled = cbDeep.Checked;
        }

        private void lbfolder_ItemCheck(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (this.Tag != null) return;
            if (lbfolder.SelectedItem == null) return;

            ((FileTableItem)lbfolder.SelectedItem).Ignore = !((FileTableItem)lbfolder.SelectedItem).Ignore;
            btReload.Enabled = true;
            SetupFileTableCheckboxes();
        }

        private void lbfolder_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btdn.Enabled = lbfolder.SelectedIndex < lbfolder.Items.Count - 1;
            btup.Enabled = lbfolder.SelectedIndex > 0;
        }

        private void btReload_Click(object sender, System.EventArgs e)
        {
            StoreFoldersXml();
            FileTable.Reload();
            btReload.Enabled = false;
        }

        void RebuildFileTableList()
        {
            lbfolder.Items.Clear();
            foreach (FileTableItem fti in FileTable.FileIndex.BaseFolders)
            {
                lbfolder.Items.Add(fti, !fti.Ignore);
            }
        }

        private void linkLabel6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            FileTable.BuildFolderXml();
            FileTable.FileIndex.BaseFolders.Clear();
            FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;

            RebuildFileTableList();

            btReload.Enabled = true;
            SetupFileTableCheckboxes();
        }

        #region Simple FileTable Settings
        void SetupFileTableCheckboxe(CheckBox cb, FileTableItemType epver, bool cep)
        {
            if (this.cbIncCep.Tag != null) return;
            int found = 0;
            int ignored = 0;


            foreach (FileTableItem fti in lbfolder.Items)
            {
                if (fti.IsFile)
                {
                    if (Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.GMND_PACKAGE) || Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.MMAT_PACKAGE))
                    {
                        if (!cep) continue;
                        else
                        {
                            found++;
                            if (fti.Ignore) ignored++;
                        }
                    }
                }

                if (fti.Type == epver && !cep)
                {
                    found++;
                    if (fti.Ignore) ignored++;
                }
            }

            this.cbIncCep.Tag = true;
            if (ignored == 0) cb.CheckState = CheckState.Checked;
            else if (ignored != found) cb.CheckState = CheckState.Indeterminate;
            else cb.CheckState = CheckState.Unchecked;
            this.cbIncCep.Tag = null;
        }

        void ChangeFileTable(CheckBox cb, FileTableItemType epver, bool cep)
        {
            bool firstobjpkg = true;
            this.cbIncCep.Tag = true;
            for (int i = 0; i < lbfolder.Items.Count; i++)
            {
                FileTableItem fti = (FileTableItem)lbfolder.Items[i];

                if (fti.IsFile)
                {
                    if (Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.GMND_PACKAGE) || Helper.CompareableFileName(fti.Name) == Helper.CompareableFileName(Data.MetaData.MMAT_PACKAGE))
                    {
                        if (!cep) continue;
                        else lbfolder.SetItemChecked(i, cb.CheckState != CheckState.Unchecked);
                    }
                }

                if (fti.Type == epver && !cep)
                {
                    lbfolder.SetItemChecked(i, cb.CheckState != CheckState.Unchecked);
                }

                fti.Ignore = !lbfolder.GetItemChecked(i);

                if (!fti.Ignore && (Helper.CompareableFileName(fti.Name).EndsWith("tsdata\\res\\objects") || Helper.CompareableFileName(fti.Name).EndsWith("tsdata\\res\\objects\\")))
                {
                    if (firstobjpkg)
                    {
                        firstobjpkg = false;
                        fti.EpVersion = -1;
                    }
                    else
                    {
                        fti.EpVersion = FileTableItem.GetEPVersion(fti.Type);
                    }

                    if (FileTableItem.GetEPVersion(fti.Type) == PathProvider.Global.GameVersion)
                        fti.EpVersion = FileTableItem.GetEPVersion(fti.Type);

                    lbfolder.Items[i] = fti;
                }

            }
            this.cbIncCep.Tag = null;
        }

        void SetupFileTableCheckboxes()
        {
            foreach (Control c in cbIncCep.Parent.Controls)
            {
                CheckBox cb = c as CheckBox;
                if (cb == null) continue;
                if (cb.Tag == null) continue;
                ExpansionItem ei = cb.Tag as ExpansionItem;
                SetupFileTableCheckboxe(cb, ei.Expansion, false);
                
            }
            SetupFileTableCheckboxe(this.cbIncCep, FileTablePaths.Absolute, true);
        }

        private void cbIncNightlife_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (this.cbIncCep.Tag != null) return;

            btReload.Enabled = true;
            if (cb == this.cbIncCep) ChangeFileTable(cb, FileTablePaths.Absolute, true);
            else
            {
                ExpansionItem ei = cb.Tag as ExpansionItem;
                ChangeFileTable(cb, ei.Expansion, false);
            } 
        }

        #endregion

        private void cbLock_CheckedChanged(object sender, System.EventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.Checked) this.LockDocksClick(sender, e);
            else this.UnlockDocksClick(sender, e);
        }

        private void checkControl1_FixedFileTable(object sender, System.EventArgs e)
        {
            RebuildFileTableList();
        }

        private void cbCustom_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            this.pgcustom.SelectedObject = cbCustom.SelectedItem;
        }
    }

    class MyPropertyGrid : PropertyGrid
    {

    }
}
