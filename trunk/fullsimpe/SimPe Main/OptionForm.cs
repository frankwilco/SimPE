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
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox lbfolder;
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
		private System.ComponentModel.IContainer components;		

		public OptionForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			for (byte i=1; i<0x44; i++) this.cblang.Items.Add(new SimPe.PackedFiles.Wrapper.StrLanguage(i));
			SelectCategory(nbFolders, null);

			SimPe.GuiTheme[] gts = (SimPe.GuiTheme[])System.Enum.GetValues(typeof(SimPe.GuiTheme));
			foreach (SimPe.GuiTheme gt in gts) cbThemes.Items.Add(gt);
			cbThemes.SelectedIndex = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OptionForm));
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
			this.lldds2 = new System.Windows.Forms.LinkLabel();
			this.lldds = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.llsetep1 = new System.Windows.Forms.LinkLabel();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbow = new System.Windows.Forms.CheckBox();
			this.cbshowobjd = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tbthumb = new System.Windows.Forms.TextBox();
			this.button6 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbpkgmaint = new System.Windows.Forms.CheckBox();
			this.cbupdate = new System.Windows.Forms.CheckBox();
			this.cbhidden = new System.Windows.Forms.CheckBox();
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
			this.lbfolder = new System.Windows.Forms.ListBox();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbscale = new System.Windows.Forms.TextBox();
			this.cbjointname = new System.Windows.Forms.CheckBox();
			this.hcFolders = new TD.Eyefinder.HeaderControl();
			this.hcSettings = new TD.Eyefinder.HeaderControl();
			this.button8 = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.cbFirefox = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.cbThemes = new System.Windows.Forms.ComboBox();
			this.button7 = new System.Windows.Forms.Button();
			this.hcTools = new TD.Eyefinder.HeaderControl();
			this.hcFileTable = new TD.Eyefinder.HeaderControl();
			this.btdn = new System.Windows.Forms.Button();
			this.btup = new System.Windows.Forms.Button();
			this.hcSceneGraph = new TD.Eyefinder.HeaderControl();
			this.bb = new Divelements.Navisight.ButtonBar();
			this.nbFolders = new Divelements.Navisight.NavigationButton();
			this.nbSettings = new Divelements.Navisight.NavigationButton();
			this.nbTools = new Divelements.Navisight.NavigationButton();
			this.nbFileTable = new Divelements.Navisight.NavigationButton();
			this.nbSceneGraph = new Divelements.Navisight.NavigationButton();
			this.nbPlugins = new Divelements.Navisight.NavigationButton();
			this.hcPlugins = new TD.Eyefinder.HeaderControl();
			this.btpup = new System.Windows.Forms.Button();
			this.btpdown = new System.Windows.Forms.Button();
			this.cnt = new System.Windows.Forms.Panel();
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
			this.hcSceneGraph.SuspendLayout();
			this.hcPlugins.SuspendLayout();
			this.SuspendLayout();
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
			this.button1.Click += new System.EventHandler(this.SaveOptionsClick);
			// 
			// tbgame
			// 
			this.tbgame.AccessibleDescription = resources.GetString("tbgame.AccessibleDescription");
			this.tbgame.AccessibleName = resources.GetString("tbgame.AccessibleName");
			this.tbgame.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgame.Anchor")));
			this.tbgame.AutoSize = ((bool)(resources.GetObject("tbgame.AutoSize")));
			this.tbgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgame.BackgroundImage")));
			this.tbgame.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgame.Dock")));
			this.tbgame.Enabled = ((bool)(resources.GetObject("tbgame.Enabled")));
			this.tbgame.Font = ((System.Drawing.Font)(resources.GetObject("tbgame.Font")));
			this.tbgame.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgame.ImeMode")));
			this.tbgame.Location = ((System.Drawing.Point)(resources.GetObject("tbgame.Location")));
			this.tbgame.MaxLength = ((int)(resources.GetObject("tbgame.MaxLength")));
			this.tbgame.Multiline = ((bool)(resources.GetObject("tbgame.Multiline")));
			this.tbgame.Name = "tbgame";
			this.tbgame.PasswordChar = ((char)(resources.GetObject("tbgame.PasswordChar")));
			this.tbgame.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgame.RightToLeft")));
			this.tbgame.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgame.ScrollBars")));
			this.tbgame.Size = ((System.Drawing.Size)(resources.GetObject("tbgame.Size")));
			this.tbgame.TabIndex = ((int)(resources.GetObject("tbgame.TabIndex")));
			this.tbgame.Text = resources.GetString("tbgame.Text");
			this.tbgame.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgame.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgame, resources.GetString("tbgame.ToolTip"));
			this.tbgame.Visible = ((bool)(resources.GetObject("tbgame.Visible")));
			this.tbgame.WordWrap = ((bool)(resources.GetObject("tbgame.WordWrap")));
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
			this.label2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("label2.LinkArea")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.TabStop = true;
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			this.label2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label2_LinkClicked);
			// 
			// tbsavegame
			// 
			this.tbsavegame.AccessibleDescription = resources.GetString("tbsavegame.AccessibleDescription");
			this.tbsavegame.AccessibleName = resources.GetString("tbsavegame.AccessibleName");
			this.tbsavegame.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsavegame.Anchor")));
			this.tbsavegame.AutoSize = ((bool)(resources.GetObject("tbsavegame.AutoSize")));
			this.tbsavegame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsavegame.BackgroundImage")));
			this.tbsavegame.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsavegame.Dock")));
			this.tbsavegame.Enabled = ((bool)(resources.GetObject("tbsavegame.Enabled")));
			this.tbsavegame.Font = ((System.Drawing.Font)(resources.GetObject("tbsavegame.Font")));
			this.tbsavegame.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsavegame.ImeMode")));
			this.tbsavegame.Location = ((System.Drawing.Point)(resources.GetObject("tbsavegame.Location")));
			this.tbsavegame.MaxLength = ((int)(resources.GetObject("tbsavegame.MaxLength")));
			this.tbsavegame.Multiline = ((bool)(resources.GetObject("tbsavegame.Multiline")));
			this.tbsavegame.Name = "tbsavegame";
			this.tbsavegame.PasswordChar = ((char)(resources.GetObject("tbsavegame.PasswordChar")));
			this.tbsavegame.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsavegame.RightToLeft")));
			this.tbsavegame.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsavegame.ScrollBars")));
			this.tbsavegame.Size = ((System.Drawing.Size)(resources.GetObject("tbsavegame.Size")));
			this.tbsavegame.TabIndex = ((int)(resources.GetObject("tbsavegame.TabIndex")));
			this.tbsavegame.Text = resources.GetString("tbsavegame.Text");
			this.tbsavegame.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsavegame.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsavegame, resources.GetString("tbsavegame.ToolTip"));
			this.tbsavegame.Visible = ((bool)(resources.GetObject("tbsavegame.Visible")));
			this.tbsavegame.WordWrap = ((bool)(resources.GetObject("tbsavegame.WordWrap")));
			// 
			// cbdebug
			// 
			this.cbdebug.AccessibleDescription = resources.GetString("cbdebug.AccessibleDescription");
			this.cbdebug.AccessibleName = resources.GetString("cbdebug.AccessibleName");
			this.cbdebug.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbdebug.Anchor")));
			this.cbdebug.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbdebug.Appearance")));
			this.cbdebug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbdebug.BackgroundImage")));
			this.cbdebug.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebug.CheckAlign")));
			this.cbdebug.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbdebug.Dock")));
			this.cbdebug.Enabled = ((bool)(resources.GetObject("cbdebug.Enabled")));
			this.cbdebug.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbdebug.FlatStyle")));
			this.cbdebug.Font = ((System.Drawing.Font)(resources.GetObject("cbdebug.Font")));
			this.cbdebug.Image = ((System.Drawing.Image)(resources.GetObject("cbdebug.Image")));
			this.cbdebug.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebug.ImageAlign")));
			this.cbdebug.ImageIndex = ((int)(resources.GetObject("cbdebug.ImageIndex")));
			this.cbdebug.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbdebug.ImeMode")));
			this.cbdebug.Location = ((System.Drawing.Point)(resources.GetObject("cbdebug.Location")));
			this.cbdebug.Name = "cbdebug";
			this.cbdebug.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbdebug.RightToLeft")));
			this.cbdebug.Size = ((System.Drawing.Size)(resources.GetObject("cbdebug.Size")));
			this.cbdebug.TabIndex = ((int)(resources.GetObject("cbdebug.TabIndex")));
			this.cbdebug.Text = resources.GetString("cbdebug.Text");
			this.cbdebug.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebug.TextAlign")));
			this.toolTip1.SetToolTip(this.cbdebug, resources.GetString("cbdebug.ToolTip"));
			this.cbdebug.Visible = ((bool)(resources.GetObject("cbdebug.Visible")));
			// 
			// cbblur
			// 
			this.cbblur.AccessibleDescription = resources.GetString("cbblur.AccessibleDescription");
			this.cbblur.AccessibleName = resources.GetString("cbblur.AccessibleName");
			this.cbblur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbblur.Anchor")));
			this.cbblur.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbblur.Appearance")));
			this.cbblur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbblur.BackgroundImage")));
			this.cbblur.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbblur.CheckAlign")));
			this.cbblur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbblur.Dock")));
			this.cbblur.Enabled = ((bool)(resources.GetObject("cbblur.Enabled")));
			this.cbblur.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbblur.FlatStyle")));
			this.cbblur.Font = ((System.Drawing.Font)(resources.GetObject("cbblur.Font")));
			this.cbblur.Image = ((System.Drawing.Image)(resources.GetObject("cbblur.Image")));
			this.cbblur.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbblur.ImageAlign")));
			this.cbblur.ImageIndex = ((int)(resources.GetObject("cbblur.ImageIndex")));
			this.cbblur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbblur.ImeMode")));
			this.cbblur.Location = ((System.Drawing.Point)(resources.GetObject("cbblur.Location")));
			this.cbblur.Name = "cbblur";
			this.cbblur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbblur.RightToLeft")));
			this.cbblur.Size = ((System.Drawing.Size)(resources.GetObject("cbblur.Size")));
			this.cbblur.TabIndex = ((int)(resources.GetObject("cbblur.TabIndex")));
			this.cbblur.Text = resources.GetString("cbblur.Text");
			this.cbblur.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbblur.TextAlign")));
			this.toolTip1.SetToolTip(this.cbblur, resources.GetString("cbblur.ToolTip"));
			this.cbblur.Visible = ((bool)(resources.GetObject("cbblur.Visible")));
			// 
			// cbsound
			// 
			this.cbsound.AccessibleDescription = resources.GetString("cbsound.AccessibleDescription");
			this.cbsound.AccessibleName = resources.GetString("cbsound.AccessibleName");
			this.cbsound.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsound.Anchor")));
			this.cbsound.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbsound.Appearance")));
			this.cbsound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsound.BackgroundImage")));
			this.cbsound.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsound.CheckAlign")));
			this.cbsound.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsound.Dock")));
			this.cbsound.Enabled = ((bool)(resources.GetObject("cbsound.Enabled")));
			this.cbsound.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbsound.FlatStyle")));
			this.cbsound.Font = ((System.Drawing.Font)(resources.GetObject("cbsound.Font")));
			this.cbsound.Image = ((System.Drawing.Image)(resources.GetObject("cbsound.Image")));
			this.cbsound.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsound.ImageAlign")));
			this.cbsound.ImageIndex = ((int)(resources.GetObject("cbsound.ImageIndex")));
			this.cbsound.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsound.ImeMode")));
			this.cbsound.Location = ((System.Drawing.Point)(resources.GetObject("cbsound.Location")));
			this.cbsound.Name = "cbsound";
			this.cbsound.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsound.RightToLeft")));
			this.cbsound.Size = ((System.Drawing.Size)(resources.GetObject("cbsound.Size")));
			this.cbsound.TabIndex = ((int)(resources.GetObject("cbsound.TabIndex")));
			this.cbsound.Text = resources.GetString("cbsound.Text");
			this.cbsound.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsound.TextAlign")));
			this.toolTip1.SetToolTip(this.cbsound, resources.GetString("cbsound.ToolTip"));
			this.cbsound.Visible = ((bool)(resources.GetObject("cbsound.Visible")));
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
			// 
			// lbext
			// 
			this.lbext.AccessibleDescription = resources.GetString("lbext.AccessibleDescription");
			this.lbext.AccessibleName = resources.GetString("lbext.AccessibleName");
			this.lbext.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbext.Anchor")));
			this.lbext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbext.BackgroundImage")));
			this.lbext.ColumnWidth = ((int)(resources.GetObject("lbext.ColumnWidth")));
			this.lbext.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbext.Dock")));
			this.lbext.Enabled = ((bool)(resources.GetObject("lbext.Enabled")));
			this.lbext.Font = ((System.Drawing.Font)(resources.GetObject("lbext.Font")));
			this.lbext.HorizontalExtent = ((int)(resources.GetObject("lbext.HorizontalExtent")));
			this.lbext.HorizontalScrollbar = ((bool)(resources.GetObject("lbext.HorizontalScrollbar")));
			this.lbext.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbext.ImeMode")));
			this.lbext.IntegralHeight = ((bool)(resources.GetObject("lbext.IntegralHeight")));
			this.lbext.ItemHeight = ((int)(resources.GetObject("lbext.ItemHeight")));
			this.lbext.Location = ((System.Drawing.Point)(resources.GetObject("lbext.Location")));
			this.lbext.Name = "lbext";
			this.lbext.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbext.RightToLeft")));
			this.lbext.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbext.ScrollAlwaysVisible")));
			this.lbext.Size = ((System.Drawing.Size)(resources.GetObject("lbext.Size")));
			this.lbext.TabIndex = ((int)(resources.GetObject("lbext.TabIndex")));
			this.toolTip1.SetToolTip(this.lbext, resources.GetString("lbext.ToolTip"));
			this.lbext.Visible = ((bool)(resources.GetObject("lbext.Visible")));
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
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
			this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddExt);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AccessibleDescription = resources.GetString("linkLabel2.AccessibleDescription");
			this.linkLabel2.AccessibleName = resources.GetString("linkLabel2.AccessibleName");
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel2.Anchor")));
			this.linkLabel2.AutoSize = ((bool)(resources.GetObject("linkLabel2.AutoSize")));
			this.linkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel2.Dock")));
			this.linkLabel2.Enabled = ((bool)(resources.GetObject("linkLabel2.Enabled")));
			this.linkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel2.Font")));
			this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
			this.linkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.ImageAlign")));
			this.linkLabel2.ImageIndex = ((int)(resources.GetObject("linkLabel2.ImageIndex")));
			this.linkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel2.ImeMode")));
			this.linkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel2.LinkArea")));
			this.linkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel2.Location")));
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel2.RightToLeft")));
			this.linkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel2.Size")));
			this.linkLabel2.TabIndex = ((int)(resources.GetObject("linkLabel2.TabIndex")));
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = resources.GetString("linkLabel2.Text");
			this.linkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel2, resources.GetString("linkLabel2.ToolTip"));
			this.linkLabel2.Visible = ((bool)(resources.GetObject("linkLabel2.Visible")));
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteExt);
			// 
			// fbd
			// 
			this.fbd.Description = resources.GetString("fbd.Description");
			this.fbd.SelectedPath = resources.GetString("fbd.SelectedPath");
			// 
			// button2
			// 
			this.button2.AccessibleDescription = resources.GetString("button2.AccessibleDescription");
			this.button2.AccessibleName = resources.GetString("button2.AccessibleName");
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button2.Anchor")));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button2.Dock")));
			this.button2.Enabled = ((bool)(resources.GetObject("button2.Enabled")));
			this.button2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button2.FlatStyle")));
			this.button2.Font = ((System.Drawing.Font)(resources.GetObject("button2.Font")));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.ImageAlign")));
			this.button2.ImageIndex = ((int)(resources.GetObject("button2.ImageIndex")));
			this.button2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button2.ImeMode")));
			this.button2.Location = ((System.Drawing.Point)(resources.GetObject("button2.Location")));
			this.button2.Name = "button2";
			this.button2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button2.RightToLeft")));
			this.button2.Size = ((System.Drawing.Size)(resources.GetObject("button2.Size")));
			this.button2.TabIndex = ((int)(resources.GetObject("button2.TabIndex")));
			this.button2.Text = resources.GetString("button2.Text");
			this.button2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.TextAlign")));
			this.toolTip1.SetToolTip(this.button2, resources.GetString("button2.ToolTip"));
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.AccessibleDescription = resources.GetString("button3.AccessibleDescription");
			this.button3.AccessibleName = resources.GetString("button3.AccessibleName");
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button3.Anchor")));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button3.Dock")));
			this.button3.Enabled = ((bool)(resources.GetObject("button3.Enabled")));
			this.button3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button3.FlatStyle")));
			this.button3.Font = ((System.Drawing.Font)(resources.GetObject("button3.Font")));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.ImageAlign")));
			this.button3.ImageIndex = ((int)(resources.GetObject("button3.ImageIndex")));
			this.button3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button3.ImeMode")));
			this.button3.Location = ((System.Drawing.Point)(resources.GetObject("button3.Location")));
			this.button3.Name = "button3";
			this.button3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button3.RightToLeft")));
			this.button3.Size = ((System.Drawing.Size)(resources.GetObject("button3.Size")));
			this.button3.TabIndex = ((int)(resources.GetObject("button3.TabIndex")));
			this.button3.Text = resources.GetString("button3.Text");
			this.button3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.TextAlign")));
			this.toolTip1.SetToolTip(this.button3, resources.GetString("button3.ToolTip"));
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.AccessibleDescription = resources.GetString("button4.AccessibleDescription");
			this.button4.AccessibleName = resources.GetString("button4.AccessibleName");
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button4.Anchor")));
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button4.Dock")));
			this.button4.Enabled = ((bool)(resources.GetObject("button4.Enabled")));
			this.button4.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button4.FlatStyle")));
			this.button4.Font = ((System.Drawing.Font)(resources.GetObject("button4.Font")));
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button4.ImageAlign")));
			this.button4.ImageIndex = ((int)(resources.GetObject("button4.ImageIndex")));
			this.button4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button4.ImeMode")));
			this.button4.Location = ((System.Drawing.Point)(resources.GetObject("button4.Location")));
			this.button4.Name = "button4";
			this.button4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button4.RightToLeft")));
			this.button4.Size = ((System.Drawing.Size)(resources.GetObject("button4.Size")));
			this.button4.TabIndex = ((int)(resources.GetObject("button4.TabIndex")));
			this.button4.Text = resources.GetString("button4.Text");
			this.button4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button4.TextAlign")));
			this.toolTip1.SetToolTip(this.button4, resources.GetString("button4.ToolTip"));
			this.button4.Visible = ((bool)(resources.GetObject("button4.Visible")));
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// tbdds
			// 
			this.tbdds.AccessibleDescription = resources.GetString("tbdds.AccessibleDescription");
			this.tbdds.AccessibleName = resources.GetString("tbdds.AccessibleName");
			this.tbdds.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbdds.Anchor")));
			this.tbdds.AutoSize = ((bool)(resources.GetObject("tbdds.AutoSize")));
			this.tbdds.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbdds.BackgroundImage")));
			this.tbdds.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbdds.Dock")));
			this.tbdds.Enabled = ((bool)(resources.GetObject("tbdds.Enabled")));
			this.tbdds.Font = ((System.Drawing.Font)(resources.GetObject("tbdds.Font")));
			this.tbdds.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbdds.ImeMode")));
			this.tbdds.Location = ((System.Drawing.Point)(resources.GetObject("tbdds.Location")));
			this.tbdds.MaxLength = ((int)(resources.GetObject("tbdds.MaxLength")));
			this.tbdds.Multiline = ((bool)(resources.GetObject("tbdds.Multiline")));
			this.tbdds.Name = "tbdds";
			this.tbdds.PasswordChar = ((char)(resources.GetObject("tbdds.PasswordChar")));
			this.tbdds.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbdds.RightToLeft")));
			this.tbdds.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbdds.ScrollBars")));
			this.tbdds.Size = ((System.Drawing.Size)(resources.GetObject("tbdds.Size")));
			this.tbdds.TabIndex = ((int)(resources.GetObject("tbdds.TabIndex")));
			this.tbdds.Text = resources.GetString("tbdds.Text");
			this.tbdds.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbdds.TextAlign")));
			this.toolTip1.SetToolTip(this.tbdds, resources.GetString("tbdds.ToolTip"));
			this.tbdds.Visible = ((bool)(resources.GetObject("tbdds.Visible")));
			this.tbdds.WordWrap = ((bool)(resources.GetObject("tbdds.WordWrap")));
			this.tbdds.TextChanged += new System.EventHandler(this.DDSChanged);
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
			// 
			// ofd
			// 
			this.ofd.Filter = resources.GetString("ofd.Filter");
			this.ofd.Title = resources.GetString("ofd.Title");
			// 
			// tbep1
			// 
			this.tbep1.AccessibleDescription = resources.GetString("tbep1.AccessibleDescription");
			this.tbep1.AccessibleName = resources.GetString("tbep1.AccessibleName");
			this.tbep1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbep1.Anchor")));
			this.tbep1.AutoSize = ((bool)(resources.GetObject("tbep1.AutoSize")));
			this.tbep1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbep1.BackgroundImage")));
			this.tbep1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbep1.Dock")));
			this.tbep1.Enabled = ((bool)(resources.GetObject("tbep1.Enabled")));
			this.tbep1.Font = ((System.Drawing.Font)(resources.GetObject("tbep1.Font")));
			this.tbep1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbep1.ImeMode")));
			this.tbep1.Location = ((System.Drawing.Point)(resources.GetObject("tbep1.Location")));
			this.tbep1.MaxLength = ((int)(resources.GetObject("tbep1.MaxLength")));
			this.tbep1.Multiline = ((bool)(resources.GetObject("tbep1.Multiline")));
			this.tbep1.Name = "tbep1";
			this.tbep1.PasswordChar = ((char)(resources.GetObject("tbep1.PasswordChar")));
			this.tbep1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbep1.RightToLeft")));
			this.tbep1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbep1.ScrollBars")));
			this.tbep1.Size = ((System.Drawing.Size)(resources.GetObject("tbep1.Size")));
			this.tbep1.TabIndex = ((int)(resources.GetObject("tbep1.TabIndex")));
			this.tbep1.Text = resources.GetString("tbep1.Text");
			this.tbep1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbep1.TextAlign")));
			this.toolTip1.SetToolTip(this.tbep1, resources.GetString("tbep1.ToolTip"));
			this.tbep1.Visible = ((bool)(resources.GetObject("tbep1.Visible")));
			this.tbep1.WordWrap = ((bool)(resources.GetObject("tbep1.WordWrap")));
			// 
			// button5
			// 
			this.button5.AccessibleDescription = resources.GetString("button5.AccessibleDescription");
			this.button5.AccessibleName = resources.GetString("button5.AccessibleName");
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button5.Anchor")));
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button5.Dock")));
			this.button5.Enabled = ((bool)(resources.GetObject("button5.Enabled")));
			this.button5.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button5.FlatStyle")));
			this.button5.Font = ((System.Drawing.Font)(resources.GetObject("button5.Font")));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button5.ImageAlign")));
			this.button5.ImageIndex = ((int)(resources.GetObject("button5.ImageIndex")));
			this.button5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button5.ImeMode")));
			this.button5.Location = ((System.Drawing.Point)(resources.GetObject("button5.Location")));
			this.button5.Name = "button5";
			this.button5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button5.RightToLeft")));
			this.button5.Size = ((System.Drawing.Size)(resources.GetObject("button5.Size")));
			this.button5.TabIndex = ((int)(resources.GetObject("button5.TabIndex")));
			this.button5.Text = resources.GetString("button5.Text");
			this.button5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button5.TextAlign")));
			this.toolTip1.SetToolTip(this.button5, resources.GetString("button5.ToolTip"));
			this.button5.Visible = ((bool)(resources.GetObject("button5.Visible")));
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// linkLabel4
			// 
			this.linkLabel4.AccessibleDescription = resources.GetString("linkLabel4.AccessibleDescription");
			this.linkLabel4.AccessibleName = resources.GetString("linkLabel4.AccessibleName");
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel4.Anchor")));
			this.linkLabel4.AutoSize = ((bool)(resources.GetObject("linkLabel4.AutoSize")));
			this.linkLabel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel4.Dock")));
			this.linkLabel4.Enabled = ((bool)(resources.GetObject("linkLabel4.Enabled")));
			this.linkLabel4.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel4.Font")));
			this.linkLabel4.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel4.Image")));
			this.linkLabel4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel4.ImageAlign")));
			this.linkLabel4.ImageIndex = ((int)(resources.GetObject("linkLabel4.ImageIndex")));
			this.linkLabel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel4.ImeMode")));
			this.linkLabel4.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel4.LinkArea")));
			this.linkLabel4.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel4.Location")));
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel4.RightToLeft")));
			this.linkLabel4.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel4.Size")));
			this.linkLabel4.TabIndex = ((int)(resources.GetObject("linkLabel4.TabIndex")));
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = resources.GetString("linkLabel4.Text");
			this.linkLabel4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel4.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel4, resources.GetString("linkLabel4.ToolTip"));
			this.linkLabel4.Visible = ((bool)(resources.GetObject("linkLabel4.Visible")));
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// lldds2
			// 
			this.lldds2.AccessibleDescription = resources.GetString("lldds2.AccessibleDescription");
			this.lldds2.AccessibleName = resources.GetString("lldds2.AccessibleName");
			this.lldds2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldds2.Anchor")));
			this.lldds2.AutoSize = ((bool)(resources.GetObject("lldds2.AutoSize")));
			this.lldds2.BackColor = System.Drawing.SystemColors.Window;
			this.lldds2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldds2.Dock")));
			this.lldds2.Enabled = ((bool)(resources.GetObject("lldds2.Enabled")));
			this.lldds2.Font = ((System.Drawing.Font)(resources.GetObject("lldds2.Font")));
			this.lldds2.ForeColor = System.Drawing.Color.Gray;
			this.lldds2.Image = ((System.Drawing.Image)(resources.GetObject("lldds2.Image")));
			this.lldds2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldds2.ImageAlign")));
			this.lldds2.ImageIndex = ((int)(resources.GetObject("lldds2.ImageIndex")));
			this.lldds2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldds2.ImeMode")));
			this.lldds2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldds2.LinkArea")));
			this.lldds2.LinkColor = System.Drawing.Color.Red;
			this.lldds2.Location = ((System.Drawing.Point)(resources.GetObject("lldds2.Location")));
			this.lldds2.Name = "lldds2";
			this.lldds2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldds2.RightToLeft")));
			this.lldds2.Size = ((System.Drawing.Size)(resources.GetObject("lldds2.Size")));
			this.lldds2.TabIndex = ((int)(resources.GetObject("lldds2.TabIndex")));
			this.lldds2.TabStop = true;
			this.lldds2.Text = resources.GetString("lldds2.Text");
			this.lldds2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldds2.TextAlign")));
			this.toolTip1.SetToolTip(this.lldds2, resources.GetString("lldds2.ToolTip"));
			this.lldds2.Visible = ((bool)(resources.GetObject("lldds2.Visible")));
			this.lldds2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoadDDS);
			// 
			// lldds
			// 
			this.lldds.AccessibleDescription = resources.GetString("lldds.AccessibleDescription");
			this.lldds.AccessibleName = resources.GetString("lldds.AccessibleName");
			this.lldds.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldds.Anchor")));
			this.lldds.AutoSize = ((bool)(resources.GetObject("lldds.AutoSize")));
			this.lldds.BackColor = System.Drawing.SystemColors.Window;
			this.lldds.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldds.Dock")));
			this.lldds.Enabled = ((bool)(resources.GetObject("lldds.Enabled")));
			this.lldds.Font = ((System.Drawing.Font)(resources.GetObject("lldds.Font")));
			this.lldds.ForeColor = System.Drawing.Color.Gray;
			this.lldds.Image = ((System.Drawing.Image)(resources.GetObject("lldds.Image")));
			this.lldds.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldds.ImageAlign")));
			this.lldds.ImageIndex = ((int)(resources.GetObject("lldds.ImageIndex")));
			this.lldds.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldds.ImeMode")));
			this.lldds.Location = ((System.Drawing.Point)(resources.GetObject("lldds.Location")));
			this.lldds.Name = "lldds";
			this.lldds.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldds.RightToLeft")));
			this.lldds.Size = ((System.Drawing.Size)(resources.GetObject("lldds.Size")));
			this.lldds.TabIndex = ((int)(resources.GetObject("lldds.TabIndex")));
			this.lldds.Text = resources.GetString("lldds.Text");
			this.lldds.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldds.TextAlign")));
			this.toolTip1.SetToolTip(this.lldds, resources.GetString("lldds.ToolTip"));
			this.lldds.Visible = ((bool)(resources.GetObject("lldds.Visible")));
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.toolTip1.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
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
			// 
			// llsetep1
			// 
			this.llsetep1.AccessibleDescription = resources.GetString("llsetep1.AccessibleDescription");
			this.llsetep1.AccessibleName = resources.GetString("llsetep1.AccessibleName");
			this.llsetep1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsetep1.Anchor")));
			this.llsetep1.AutoSize = ((bool)(resources.GetObject("llsetep1.AutoSize")));
			this.llsetep1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsetep1.Dock")));
			this.llsetep1.Enabled = ((bool)(resources.GetObject("llsetep1.Enabled")));
			this.llsetep1.Font = ((System.Drawing.Font)(resources.GetObject("llsetep1.Font")));
			this.llsetep1.Image = ((System.Drawing.Image)(resources.GetObject("llsetep1.Image")));
			this.llsetep1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsetep1.ImageAlign")));
			this.llsetep1.ImageIndex = ((int)(resources.GetObject("llsetep1.ImageIndex")));
			this.llsetep1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsetep1.ImeMode")));
			this.llsetep1.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llsetep1.LinkArea")));
			this.llsetep1.Location = ((System.Drawing.Point)(resources.GetObject("llsetep1.Location")));
			this.llsetep1.Name = "llsetep1";
			this.llsetep1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsetep1.RightToLeft")));
			this.llsetep1.Size = ((System.Drawing.Size)(resources.GetObject("llsetep1.Size")));
			this.llsetep1.TabIndex = ((int)(resources.GetObject("llsetep1.TabIndex")));
			this.llsetep1.TabStop = true;
			this.llsetep1.Text = resources.GetString("llsetep1.Text");
			this.llsetep1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsetep1.TextAlign")));
			this.toolTip1.SetToolTip(this.llsetep1, resources.GetString("llsetep1.ToolTip"));
			this.llsetep1.Visible = ((bool)(resources.GetObject("llsetep1.Visible")));
			this.llsetep1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.visualStyleLinkLabel1_LinkClicked);
			// 
			// groupBox3
			// 
			this.groupBox3.AccessibleDescription = resources.GetString("groupBox3.AccessibleDescription");
			this.groupBox3.AccessibleName = resources.GetString("groupBox3.AccessibleName");
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox3.Anchor")));
			this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
			this.groupBox3.Controls.Add(this.cbow);
			this.groupBox3.Controls.Add(this.cbshowobjd);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.tbthumb);
			this.groupBox3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox3.Dock")));
			this.groupBox3.Enabled = ((bool)(resources.GetObject("groupBox3.Enabled")));
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Font = ((System.Drawing.Font)(resources.GetObject("groupBox3.Font")));
			this.groupBox3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox3.ImeMode")));
			this.groupBox3.Location = ((System.Drawing.Point)(resources.GetObject("groupBox3.Location")));
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox3.RightToLeft")));
			this.groupBox3.Size = ((System.Drawing.Size)(resources.GetObject("groupBox3.Size")));
			this.groupBox3.TabIndex = ((int)(resources.GetObject("groupBox3.TabIndex")));
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = resources.GetString("groupBox3.Text");
			this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
			this.groupBox3.Visible = ((bool)(resources.GetObject("groupBox3.Visible")));
			// 
			// cbow
			// 
			this.cbow.AccessibleDescription = resources.GetString("cbow.AccessibleDescription");
			this.cbow.AccessibleName = resources.GetString("cbow.AccessibleName");
			this.cbow.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbow.Anchor")));
			this.cbow.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbow.Appearance")));
			this.cbow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbow.BackgroundImage")));
			this.cbow.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbow.CheckAlign")));
			this.cbow.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbow.Dock")));
			this.cbow.Enabled = ((bool)(resources.GetObject("cbow.Enabled")));
			this.cbow.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbow.FlatStyle")));
			this.cbow.Font = ((System.Drawing.Font)(resources.GetObject("cbow.Font")));
			this.cbow.Image = ((System.Drawing.Image)(resources.GetObject("cbow.Image")));
			this.cbow.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbow.ImageAlign")));
			this.cbow.ImageIndex = ((int)(resources.GetObject("cbow.ImageIndex")));
			this.cbow.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbow.ImeMode")));
			this.cbow.Location = ((System.Drawing.Point)(resources.GetObject("cbow.Location")));
			this.cbow.Name = "cbow";
			this.cbow.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbow.RightToLeft")));
			this.cbow.Size = ((System.Drawing.Size)(resources.GetObject("cbow.Size")));
			this.cbow.TabIndex = ((int)(resources.GetObject("cbow.TabIndex")));
			this.cbow.Text = resources.GetString("cbow.Text");
			this.cbow.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbow.TextAlign")));
			this.toolTip1.SetToolTip(this.cbow, resources.GetString("cbow.ToolTip"));
			this.cbow.Visible = ((bool)(resources.GetObject("cbow.Visible")));
			// 
			// cbshowobjd
			// 
			this.cbshowobjd.AccessibleDescription = resources.GetString("cbshowobjd.AccessibleDescription");
			this.cbshowobjd.AccessibleName = resources.GetString("cbshowobjd.AccessibleName");
			this.cbshowobjd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbshowobjd.Anchor")));
			this.cbshowobjd.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbshowobjd.Appearance")));
			this.cbshowobjd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbshowobjd.BackgroundImage")));
			this.cbshowobjd.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbshowobjd.CheckAlign")));
			this.cbshowobjd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbshowobjd.Dock")));
			this.cbshowobjd.Enabled = ((bool)(resources.GetObject("cbshowobjd.Enabled")));
			this.cbshowobjd.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbshowobjd.FlatStyle")));
			this.cbshowobjd.Font = ((System.Drawing.Font)(resources.GetObject("cbshowobjd.Font")));
			this.cbshowobjd.Image = ((System.Drawing.Image)(resources.GetObject("cbshowobjd.Image")));
			this.cbshowobjd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbshowobjd.ImageAlign")));
			this.cbshowobjd.ImageIndex = ((int)(resources.GetObject("cbshowobjd.ImageIndex")));
			this.cbshowobjd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbshowobjd.ImeMode")));
			this.cbshowobjd.Location = ((System.Drawing.Point)(resources.GetObject("cbshowobjd.Location")));
			this.cbshowobjd.Name = "cbshowobjd";
			this.cbshowobjd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbshowobjd.RightToLeft")));
			this.cbshowobjd.Size = ((System.Drawing.Size)(resources.GetObject("cbshowobjd.Size")));
			this.cbshowobjd.TabIndex = ((int)(resources.GetObject("cbshowobjd.TabIndex")));
			this.cbshowobjd.Text = resources.GetString("cbshowobjd.Text");
			this.cbshowobjd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbshowobjd.TextAlign")));
			this.toolTip1.SetToolTip(this.cbshowobjd, resources.GetString("cbshowobjd.ToolTip"));
			this.cbshowobjd.Visible = ((bool)(resources.GetObject("cbshowobjd.Visible")));
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
			// 
			// tbthumb
			// 
			this.tbthumb.AccessibleDescription = resources.GetString("tbthumb.AccessibleDescription");
			this.tbthumb.AccessibleName = resources.GetString("tbthumb.AccessibleName");
			this.tbthumb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbthumb.Anchor")));
			this.tbthumb.AutoSize = ((bool)(resources.GetObject("tbthumb.AutoSize")));
			this.tbthumb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbthumb.BackgroundImage")));
			this.tbthumb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbthumb.Dock")));
			this.tbthumb.Enabled = ((bool)(resources.GetObject("tbthumb.Enabled")));
			this.tbthumb.Font = ((System.Drawing.Font)(resources.GetObject("tbthumb.Font")));
			this.tbthumb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbthumb.ImeMode")));
			this.tbthumb.Location = ((System.Drawing.Point)(resources.GetObject("tbthumb.Location")));
			this.tbthumb.MaxLength = ((int)(resources.GetObject("tbthumb.MaxLength")));
			this.tbthumb.Multiline = ((bool)(resources.GetObject("tbthumb.Multiline")));
			this.tbthumb.Name = "tbthumb";
			this.tbthumb.PasswordChar = ((char)(resources.GetObject("tbthumb.PasswordChar")));
			this.tbthumb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbthumb.RightToLeft")));
			this.tbthumb.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbthumb.ScrollBars")));
			this.tbthumb.Size = ((System.Drawing.Size)(resources.GetObject("tbthumb.Size")));
			this.tbthumb.TabIndex = ((int)(resources.GetObject("tbthumb.TabIndex")));
			this.tbthumb.Text = resources.GetString("tbthumb.Text");
			this.tbthumb.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbthumb.TextAlign")));
			this.toolTip1.SetToolTip(this.tbthumb, resources.GetString("tbthumb.ToolTip"));
			this.tbthumb.Visible = ((bool)(resources.GetObject("tbthumb.Visible")));
			this.tbthumb.WordWrap = ((bool)(resources.GetObject("tbthumb.WordWrap")));
			// 
			// button6
			// 
			this.button6.AccessibleDescription = resources.GetString("button6.AccessibleDescription");
			this.button6.AccessibleName = resources.GetString("button6.AccessibleName");
			this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button6.Anchor")));
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button6.Dock")));
			this.button6.Enabled = ((bool)(resources.GetObject("button6.Enabled")));
			this.button6.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button6.FlatStyle")));
			this.button6.Font = ((System.Drawing.Font)(resources.GetObject("button6.Font")));
			this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
			this.button6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button6.ImageAlign")));
			this.button6.ImageIndex = ((int)(resources.GetObject("button6.ImageIndex")));
			this.button6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button6.ImeMode")));
			this.button6.Location = ((System.Drawing.Point)(resources.GetObject("button6.Location")));
			this.button6.Name = "button6";
			this.button6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button6.RightToLeft")));
			this.button6.Size = ((System.Drawing.Size)(resources.GetObject("button6.Size")));
			this.button6.TabIndex = ((int)(resources.GetObject("button6.TabIndex")));
			this.button6.Text = resources.GetString("button6.Text");
			this.button6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button6.TextAlign")));
			this.toolTip1.SetToolTip(this.button6, resources.GetString("button6.ToolTip"));
			this.button6.Visible = ((bool)(resources.GetObject("button6.Visible")));
			this.button6.Click += new System.EventHandler(this.ClearCaches);
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.cbpkgmaint);
			this.groupBox2.Controls.Add(this.cbupdate);
			this.groupBox2.Controls.Add(this.cbhidden);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.cbautobak);
			this.groupBox2.Controls.Add(this.cbcache);
			this.groupBox2.Controls.Add(this.cblang);
			this.groupBox2.Controls.Add(this.cbsilent);
			this.groupBox2.Controls.Add(this.cbwait);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Enabled = ((bool)(resources.GetObject("groupBox2.Enabled")));
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = ((System.Drawing.Font)(resources.GetObject("groupBox2.Font")));
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			// 
			// cbpkgmaint
			// 
			this.cbpkgmaint.AccessibleDescription = resources.GetString("cbpkgmaint.AccessibleDescription");
			this.cbpkgmaint.AccessibleName = resources.GetString("cbpkgmaint.AccessibleName");
			this.cbpkgmaint.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpkgmaint.Anchor")));
			this.cbpkgmaint.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpkgmaint.Appearance")));
			this.cbpkgmaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpkgmaint.BackgroundImage")));
			this.cbpkgmaint.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpkgmaint.CheckAlign")));
			this.cbpkgmaint.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpkgmaint.Dock")));
			this.cbpkgmaint.Enabled = ((bool)(resources.GetObject("cbpkgmaint.Enabled")));
			this.cbpkgmaint.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpkgmaint.FlatStyle")));
			this.cbpkgmaint.Font = ((System.Drawing.Font)(resources.GetObject("cbpkgmaint.Font")));
			this.cbpkgmaint.Image = ((System.Drawing.Image)(resources.GetObject("cbpkgmaint.Image")));
			this.cbpkgmaint.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpkgmaint.ImageAlign")));
			this.cbpkgmaint.ImageIndex = ((int)(resources.GetObject("cbpkgmaint.ImageIndex")));
			this.cbpkgmaint.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpkgmaint.ImeMode")));
			this.cbpkgmaint.Location = ((System.Drawing.Point)(resources.GetObject("cbpkgmaint.Location")));
			this.cbpkgmaint.Name = "cbpkgmaint";
			this.cbpkgmaint.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpkgmaint.RightToLeft")));
			this.cbpkgmaint.Size = ((System.Drawing.Size)(resources.GetObject("cbpkgmaint.Size")));
			this.cbpkgmaint.TabIndex = ((int)(resources.GetObject("cbpkgmaint.TabIndex")));
			this.cbpkgmaint.Text = resources.GetString("cbpkgmaint.Text");
			this.cbpkgmaint.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpkgmaint.TextAlign")));
			this.toolTip1.SetToolTip(this.cbpkgmaint, resources.GetString("cbpkgmaint.ToolTip"));
			this.cbpkgmaint.Visible = ((bool)(resources.GetObject("cbpkgmaint.Visible")));
			// 
			// cbupdate
			// 
			this.cbupdate.AccessibleDescription = resources.GetString("cbupdate.AccessibleDescription");
			this.cbupdate.AccessibleName = resources.GetString("cbupdate.AccessibleName");
			this.cbupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbupdate.Anchor")));
			this.cbupdate.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbupdate.Appearance")));
			this.cbupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbupdate.BackgroundImage")));
			this.cbupdate.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.CheckAlign")));
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
			// 
			// cbhidden
			// 
			this.cbhidden.AccessibleDescription = resources.GetString("cbhidden.AccessibleDescription");
			this.cbhidden.AccessibleName = resources.GetString("cbhidden.AccessibleName");
			this.cbhidden.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbhidden.Anchor")));
			this.cbhidden.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbhidden.Appearance")));
			this.cbhidden.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbhidden.BackgroundImage")));
			this.cbhidden.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbhidden.CheckAlign")));
			this.cbhidden.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbhidden.Dock")));
			this.cbhidden.Enabled = ((bool)(resources.GetObject("cbhidden.Enabled")));
			this.cbhidden.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbhidden.FlatStyle")));
			this.cbhidden.Font = ((System.Drawing.Font)(resources.GetObject("cbhidden.Font")));
			this.cbhidden.Image = ((System.Drawing.Image)(resources.GetObject("cbhidden.Image")));
			this.cbhidden.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbhidden.ImageAlign")));
			this.cbhidden.ImageIndex = ((int)(resources.GetObject("cbhidden.ImageIndex")));
			this.cbhidden.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbhidden.ImeMode")));
			this.cbhidden.Location = ((System.Drawing.Point)(resources.GetObject("cbhidden.Location")));
			this.cbhidden.Name = "cbhidden";
			this.cbhidden.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbhidden.RightToLeft")));
			this.cbhidden.Size = ((System.Drawing.Size)(resources.GetObject("cbhidden.Size")));
			this.cbhidden.TabIndex = ((int)(resources.GetObject("cbhidden.TabIndex")));
			this.cbhidden.Text = resources.GetString("cbhidden.Text");
			this.cbhidden.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbhidden.TextAlign")));
			this.toolTip1.SetToolTip(this.cbhidden, resources.GetString("cbhidden.ToolTip"));
			this.cbhidden.Visible = ((bool)(resources.GetObject("cbhidden.Visible")));
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
			// 
			// cbautobak
			// 
			this.cbautobak.AccessibleDescription = resources.GetString("cbautobak.AccessibleDescription");
			this.cbautobak.AccessibleName = resources.GetString("cbautobak.AccessibleName");
			this.cbautobak.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbautobak.Anchor")));
			this.cbautobak.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbautobak.Appearance")));
			this.cbautobak.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbautobak.BackgroundImage")));
			this.cbautobak.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautobak.CheckAlign")));
			this.cbautobak.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbautobak.Dock")));
			this.cbautobak.Enabled = ((bool)(resources.GetObject("cbautobak.Enabled")));
			this.cbautobak.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbautobak.FlatStyle")));
			this.cbautobak.Font = ((System.Drawing.Font)(resources.GetObject("cbautobak.Font")));
			this.cbautobak.Image = ((System.Drawing.Image)(resources.GetObject("cbautobak.Image")));
			this.cbautobak.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautobak.ImageAlign")));
			this.cbautobak.ImageIndex = ((int)(resources.GetObject("cbautobak.ImageIndex")));
			this.cbautobak.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbautobak.ImeMode")));
			this.cbautobak.Location = ((System.Drawing.Point)(resources.GetObject("cbautobak.Location")));
			this.cbautobak.Name = "cbautobak";
			this.cbautobak.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbautobak.RightToLeft")));
			this.cbautobak.Size = ((System.Drawing.Size)(resources.GetObject("cbautobak.Size")));
			this.cbautobak.TabIndex = ((int)(resources.GetObject("cbautobak.TabIndex")));
			this.cbautobak.Text = resources.GetString("cbautobak.Text");
			this.cbautobak.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautobak.TextAlign")));
			this.toolTip1.SetToolTip(this.cbautobak, resources.GetString("cbautobak.ToolTip"));
			this.cbautobak.Visible = ((bool)(resources.GetObject("cbautobak.Visible")));
			// 
			// cbcache
			// 
			this.cbcache.AccessibleDescription = resources.GetString("cbcache.AccessibleDescription");
			this.cbcache.AccessibleName = resources.GetString("cbcache.AccessibleName");
			this.cbcache.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcache.Anchor")));
			this.cbcache.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcache.Appearance")));
			this.cbcache.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcache.BackgroundImage")));
			this.cbcache.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcache.CheckAlign")));
			this.cbcache.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcache.Dock")));
			this.cbcache.Enabled = ((bool)(resources.GetObject("cbcache.Enabled")));
			this.cbcache.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcache.FlatStyle")));
			this.cbcache.Font = ((System.Drawing.Font)(resources.GetObject("cbcache.Font")));
			this.cbcache.Image = ((System.Drawing.Image)(resources.GetObject("cbcache.Image")));
			this.cbcache.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcache.ImageAlign")));
			this.cbcache.ImageIndex = ((int)(resources.GetObject("cbcache.ImageIndex")));
			this.cbcache.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcache.ImeMode")));
			this.cbcache.Location = ((System.Drawing.Point)(resources.GetObject("cbcache.Location")));
			this.cbcache.Name = "cbcache";
			this.cbcache.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcache.RightToLeft")));
			this.cbcache.Size = ((System.Drawing.Size)(resources.GetObject("cbcache.Size")));
			this.cbcache.TabIndex = ((int)(resources.GetObject("cbcache.TabIndex")));
			this.cbcache.Text = resources.GetString("cbcache.Text");
			this.cbcache.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcache.TextAlign")));
			this.toolTip1.SetToolTip(this.cbcache, resources.GetString("cbcache.ToolTip"));
			this.cbcache.Visible = ((bool)(resources.GetObject("cbcache.Visible")));
			// 
			// cblang
			// 
			this.cblang.AccessibleDescription = resources.GetString("cblang.AccessibleDescription");
			this.cblang.AccessibleName = resources.GetString("cblang.AccessibleName");
			this.cblang.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblang.Anchor")));
			this.cblang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblang.BackgroundImage")));
			this.cblang.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblang.Dock")));
			this.cblang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cblang.Enabled = ((bool)(resources.GetObject("cblang.Enabled")));
			this.cblang.Font = ((System.Drawing.Font)(resources.GetObject("cblang.Font")));
			this.cblang.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblang.ImeMode")));
			this.cblang.IntegralHeight = ((bool)(resources.GetObject("cblang.IntegralHeight")));
			this.cblang.ItemHeight = ((int)(resources.GetObject("cblang.ItemHeight")));
			this.cblang.Location = ((System.Drawing.Point)(resources.GetObject("cblang.Location")));
			this.cblang.MaxDropDownItems = ((int)(resources.GetObject("cblang.MaxDropDownItems")));
			this.cblang.MaxLength = ((int)(resources.GetObject("cblang.MaxLength")));
			this.cblang.Name = "cblang";
			this.cblang.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblang.RightToLeft")));
			this.cblang.Size = ((System.Drawing.Size)(resources.GetObject("cblang.Size")));
			this.cblang.TabIndex = ((int)(resources.GetObject("cblang.TabIndex")));
			this.cblang.Text = resources.GetString("cblang.Text");
			this.toolTip1.SetToolTip(this.cblang, resources.GetString("cblang.ToolTip"));
			this.cblang.Visible = ((bool)(resources.GetObject("cblang.Visible")));
			// 
			// cbsilent
			// 
			this.cbsilent.AccessibleDescription = resources.GetString("cbsilent.AccessibleDescription");
			this.cbsilent.AccessibleName = resources.GetString("cbsilent.AccessibleName");
			this.cbsilent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsilent.Anchor")));
			this.cbsilent.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbsilent.Appearance")));
			this.cbsilent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsilent.BackgroundImage")));
			this.cbsilent.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsilent.CheckAlign")));
			this.cbsilent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsilent.Dock")));
			this.cbsilent.Enabled = ((bool)(resources.GetObject("cbsilent.Enabled")));
			this.cbsilent.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbsilent.FlatStyle")));
			this.cbsilent.Font = ((System.Drawing.Font)(resources.GetObject("cbsilent.Font")));
			this.cbsilent.Image = ((System.Drawing.Image)(resources.GetObject("cbsilent.Image")));
			this.cbsilent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsilent.ImageAlign")));
			this.cbsilent.ImageIndex = ((int)(resources.GetObject("cbsilent.ImageIndex")));
			this.cbsilent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsilent.ImeMode")));
			this.cbsilent.Location = ((System.Drawing.Point)(resources.GetObject("cbsilent.Location")));
			this.cbsilent.Name = "cbsilent";
			this.cbsilent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsilent.RightToLeft")));
			this.cbsilent.Size = ((System.Drawing.Size)(resources.GetObject("cbsilent.Size")));
			this.cbsilent.TabIndex = ((int)(resources.GetObject("cbsilent.TabIndex")));
			this.cbsilent.Text = resources.GetString("cbsilent.Text");
			this.cbsilent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsilent.TextAlign")));
			this.toolTip1.SetToolTip(this.cbsilent, resources.GetString("cbsilent.ToolTip"));
			this.cbsilent.Visible = ((bool)(resources.GetObject("cbsilent.Visible")));
			// 
			// cbwait
			// 
			this.cbwait.AccessibleDescription = resources.GetString("cbwait.AccessibleDescription");
			this.cbwait.AccessibleName = resources.GetString("cbwait.AccessibleName");
			this.cbwait.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbwait.Anchor")));
			this.cbwait.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbwait.Appearance")));
			this.cbwait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbwait.BackgroundImage")));
			this.cbwait.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwait.CheckAlign")));
			this.cbwait.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbwait.Dock")));
			this.cbwait.Enabled = ((bool)(resources.GetObject("cbwait.Enabled")));
			this.cbwait.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbwait.FlatStyle")));
			this.cbwait.Font = ((System.Drawing.Font)(resources.GetObject("cbwait.Font")));
			this.cbwait.Image = ((System.Drawing.Image)(resources.GetObject("cbwait.Image")));
			this.cbwait.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwait.ImageAlign")));
			this.cbwait.ImageIndex = ((int)(resources.GetObject("cbwait.ImageIndex")));
			this.cbwait.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbwait.ImeMode")));
			this.cbwait.Location = ((System.Drawing.Point)(resources.GetObject("cbwait.Location")));
			this.cbwait.Name = "cbwait";
			this.cbwait.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbwait.RightToLeft")));
			this.cbwait.Size = ((System.Drawing.Size)(resources.GetObject("cbwait.Size")));
			this.cbwait.TabIndex = ((int)(resources.GetObject("cbwait.TabIndex")));
			this.cbwait.Text = resources.GetString("cbwait.Text");
			this.cbwait.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbwait.TextAlign")));
			this.toolTip1.SetToolTip(this.cbwait, resources.GetString("cbwait.ToolTip"));
			this.cbwait.Visible = ((bool)(resources.GetObject("cbwait.Visible")));
			// 
			// cbSimple
			// 
			this.cbSimple.AccessibleDescription = resources.GetString("cbSimple.AccessibleDescription");
			this.cbSimple.AccessibleName = resources.GetString("cbSimple.AccessibleName");
			this.cbSimple.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbSimple.Anchor")));
			this.cbSimple.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbSimple.Appearance")));
			this.cbSimple.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbSimple.BackgroundImage")));
			this.cbSimple.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbSimple.CheckAlign")));
			this.cbSimple.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbSimple.Dock")));
			this.cbSimple.Enabled = ((bool)(resources.GetObject("cbSimple.Enabled")));
			this.cbSimple.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbSimple.FlatStyle")));
			this.cbSimple.Font = ((System.Drawing.Font)(resources.GetObject("cbSimple.Font")));
			this.cbSimple.Image = ((System.Drawing.Image)(resources.GetObject("cbSimple.Image")));
			this.cbSimple.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbSimple.ImageAlign")));
			this.cbSimple.ImageIndex = ((int)(resources.GetObject("cbSimple.ImageIndex")));
			this.cbSimple.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbSimple.ImeMode")));
			this.cbSimple.Location = ((System.Drawing.Point)(resources.GetObject("cbSimple.Location")));
			this.cbSimple.Name = "cbSimple";
			this.cbSimple.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbSimple.RightToLeft")));
			this.cbSimple.Size = ((System.Drawing.Size)(resources.GetObject("cbSimple.Size")));
			this.cbSimple.TabIndex = ((int)(resources.GetObject("cbSimple.TabIndex")));
			this.cbSimple.Text = resources.GetString("cbSimple.Text");
			this.cbSimple.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbSimple.TextAlign")));
			this.toolTip1.SetToolTip(this.cbSimple, resources.GetString("cbSimple.ToolTip"));
			this.cbSimple.Visible = ((bool)(resources.GetObject("cbSimple.Visible")));
			// 
			// cbmulti
			// 
			this.cbmulti.AccessibleDescription = resources.GetString("cbmulti.AccessibleDescription");
			this.cbmulti.AccessibleName = resources.GetString("cbmulti.AccessibleName");
			this.cbmulti.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbmulti.Anchor")));
			this.cbmulti.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbmulti.Appearance")));
			this.cbmulti.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmulti.BackgroundImage")));
			this.cbmulti.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmulti.CheckAlign")));
			this.cbmulti.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbmulti.Dock")));
			this.cbmulti.Enabled = ((bool)(resources.GetObject("cbmulti.Enabled")));
			this.cbmulti.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbmulti.FlatStyle")));
			this.cbmulti.Font = ((System.Drawing.Font)(resources.GetObject("cbmulti.Font")));
			this.cbmulti.Image = ((System.Drawing.Image)(resources.GetObject("cbmulti.Image")));
			this.cbmulti.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmulti.ImageAlign")));
			this.cbmulti.ImageIndex = ((int)(resources.GetObject("cbmulti.ImageIndex")));
			this.cbmulti.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbmulti.ImeMode")));
			this.cbmulti.Location = ((System.Drawing.Point)(resources.GetObject("cbmulti.Location")));
			this.cbmulti.Name = "cbmulti";
			this.cbmulti.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbmulti.RightToLeft")));
			this.cbmulti.Size = ((System.Drawing.Size)(resources.GetObject("cbmulti.Size")));
			this.cbmulti.TabIndex = ((int)(resources.GetObject("cbmulti.TabIndex")));
			this.cbmulti.Text = resources.GetString("cbmulti.Text");
			this.cbmulti.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmulti.TextAlign")));
			this.toolTip1.SetToolTip(this.cbmulti, resources.GetString("cbmulti.ToolTip"));
			this.cbmulti.Visible = ((bool)(resources.GetObject("cbmulti.Visible")));
			this.cbmulti.CheckedChanged += new System.EventHandler(this.cbmulti_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.cbdebug);
			this.groupBox1.Controls.Add(this.cbblur);
			this.groupBox1.Controls.Add(this.cbsound);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// lladddown
			// 
			this.lladddown.AccessibleDescription = resources.GetString("lladddown.AccessibleDescription");
			this.lladddown.AccessibleName = resources.GetString("lladddown.AccessibleName");
			this.lladddown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lladddown.Anchor")));
			this.lladddown.AutoSize = ((bool)(resources.GetObject("lladddown.AutoSize")));
			this.lladddown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lladddown.Dock")));
			this.lladddown.Enabled = ((bool)(resources.GetObject("lladddown.Enabled")));
			this.lladddown.Font = ((System.Drawing.Font)(resources.GetObject("lladddown.Font")));
			this.lladddown.Image = ((System.Drawing.Image)(resources.GetObject("lladddown.Image")));
			this.lladddown.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladddown.ImageAlign")));
			this.lladddown.ImageIndex = ((int)(resources.GetObject("lladddown.ImageIndex")));
			this.lladddown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lladddown.ImeMode")));
			this.lladddown.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lladddown.LinkArea")));
			this.lladddown.Location = ((System.Drawing.Point)(resources.GetObject("lladddown.Location")));
			this.lladddown.Name = "lladddown";
			this.lladddown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lladddown.RightToLeft")));
			this.lladddown.Size = ((System.Drawing.Size)(resources.GetObject("lladddown.Size")));
			this.lladddown.TabIndex = ((int)(resources.GetObject("lladddown.TabIndex")));
			this.lladddown.TabStop = true;
			this.lladddown.Text = resources.GetString("lladddown.Text");
			this.lladddown.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladddown.TextAlign")));
			this.toolTip1.SetToolTip(this.lladddown, resources.GetString("lladddown.ToolTip"));
			this.lladddown.Visible = ((bool)(resources.GetObject("lladddown.Visible")));
			this.lladddown.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladddown_LinkClicked);
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
			this.toolTip1.SetToolTip(this.lldel, resources.GetString("lldel.ToolTip"));
			this.lldel.Visible = ((bool)(resources.GetObject("lldel.Visible")));
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
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
			this.toolTip1.SetToolTip(this.lladd, resources.GetString("lladd.ToolTip"));
			this.lladd.Visible = ((bool)(resources.GetObject("lladd.Visible")));
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
			// 
			// lbfolder
			// 
			this.lbfolder.AccessibleDescription = resources.GetString("lbfolder.AccessibleDescription");
			this.lbfolder.AccessibleName = resources.GetString("lbfolder.AccessibleName");
			this.lbfolder.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbfolder.Anchor")));
			this.lbfolder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbfolder.BackgroundImage")));
			this.lbfolder.ColumnWidth = ((int)(resources.GetObject("lbfolder.ColumnWidth")));
			this.lbfolder.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbfolder.Dock")));
			this.lbfolder.Enabled = ((bool)(resources.GetObject("lbfolder.Enabled")));
			this.lbfolder.Font = ((System.Drawing.Font)(resources.GetObject("lbfolder.Font")));
			this.lbfolder.HorizontalExtent = ((int)(resources.GetObject("lbfolder.HorizontalExtent")));
			this.lbfolder.HorizontalScrollbar = ((bool)(resources.GetObject("lbfolder.HorizontalScrollbar")));
			this.lbfolder.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbfolder.ImeMode")));
			this.lbfolder.IntegralHeight = ((bool)(resources.GetObject("lbfolder.IntegralHeight")));
			this.lbfolder.ItemHeight = ((int)(resources.GetObject("lbfolder.ItemHeight")));
			this.lbfolder.Location = ((System.Drawing.Point)(resources.GetObject("lbfolder.Location")));
			this.lbfolder.Name = "lbfolder";
			this.lbfolder.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbfolder.RightToLeft")));
			this.lbfolder.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbfolder.ScrollAlwaysVisible")));
			this.lbfolder.Size = ((System.Drawing.Size)(resources.GetObject("lbfolder.Size")));
			this.lbfolder.TabIndex = ((int)(resources.GetObject("lbfolder.TabIndex")));
			this.toolTip1.SetToolTip(this.lbfolder, resources.GetString("lbfolder.ToolTip"));
			this.lbfolder.Visible = ((bool)(resources.GetObject("lbfolder.Visible")));
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
			// 
			// groupBox4
			// 
			this.groupBox4.AccessibleDescription = resources.GetString("groupBox4.AccessibleDescription");
			this.groupBox4.AccessibleName = resources.GetString("groupBox4.AccessibleName");
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox4.Anchor")));
			this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.tbscale);
			this.groupBox4.Controls.Add(this.cbjointname);
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
			this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			// 
			// tbscale
			// 
			this.tbscale.AccessibleDescription = resources.GetString("tbscale.AccessibleDescription");
			this.tbscale.AccessibleName = resources.GetString("tbscale.AccessibleName");
			this.tbscale.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbscale.Anchor")));
			this.tbscale.AutoSize = ((bool)(resources.GetObject("tbscale.AutoSize")));
			this.tbscale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbscale.BackgroundImage")));
			this.tbscale.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbscale.Dock")));
			this.tbscale.Enabled = ((bool)(resources.GetObject("tbscale.Enabled")));
			this.tbscale.Font = ((System.Drawing.Font)(resources.GetObject("tbscale.Font")));
			this.tbscale.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbscale.ImeMode")));
			this.tbscale.Location = ((System.Drawing.Point)(resources.GetObject("tbscale.Location")));
			this.tbscale.MaxLength = ((int)(resources.GetObject("tbscale.MaxLength")));
			this.tbscale.Multiline = ((bool)(resources.GetObject("tbscale.Multiline")));
			this.tbscale.Name = "tbscale";
			this.tbscale.PasswordChar = ((char)(resources.GetObject("tbscale.PasswordChar")));
			this.tbscale.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbscale.RightToLeft")));
			this.tbscale.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbscale.ScrollBars")));
			this.tbscale.Size = ((System.Drawing.Size)(resources.GetObject("tbscale.Size")));
			this.tbscale.TabIndex = ((int)(resources.GetObject("tbscale.TabIndex")));
			this.tbscale.Text = resources.GetString("tbscale.Text");
			this.tbscale.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbscale.TextAlign")));
			this.toolTip1.SetToolTip(this.tbscale, resources.GetString("tbscale.ToolTip"));
			this.tbscale.Visible = ((bool)(resources.GetObject("tbscale.Visible")));
			this.tbscale.WordWrap = ((bool)(resources.GetObject("tbscale.WordWrap")));
			// 
			// cbjointname
			// 
			this.cbjointname.AccessibleDescription = resources.GetString("cbjointname.AccessibleDescription");
			this.cbjointname.AccessibleName = resources.GetString("cbjointname.AccessibleName");
			this.cbjointname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbjointname.Anchor")));
			this.cbjointname.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbjointname.Appearance")));
			this.cbjointname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbjointname.BackgroundImage")));
			this.cbjointname.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjointname.CheckAlign")));
			this.cbjointname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbjointname.Dock")));
			this.cbjointname.Enabled = ((bool)(resources.GetObject("cbjointname.Enabled")));
			this.cbjointname.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbjointname.FlatStyle")));
			this.cbjointname.Font = ((System.Drawing.Font)(resources.GetObject("cbjointname.Font")));
			this.cbjointname.Image = ((System.Drawing.Image)(resources.GetObject("cbjointname.Image")));
			this.cbjointname.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjointname.ImageAlign")));
			this.cbjointname.ImageIndex = ((int)(resources.GetObject("cbjointname.ImageIndex")));
			this.cbjointname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbjointname.ImeMode")));
			this.cbjointname.Location = ((System.Drawing.Point)(resources.GetObject("cbjointname.Location")));
			this.cbjointname.Name = "cbjointname";
			this.cbjointname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbjointname.RightToLeft")));
			this.cbjointname.Size = ((System.Drawing.Size)(resources.GetObject("cbjointname.Size")));
			this.cbjointname.TabIndex = ((int)(resources.GetObject("cbjointname.TabIndex")));
			this.cbjointname.Text = resources.GetString("cbjointname.Text");
			this.cbjointname.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjointname.TextAlign")));
			this.toolTip1.SetToolTip(this.cbjointname, resources.GetString("cbjointname.ToolTip"));
			this.cbjointname.Visible = ((bool)(resources.GetObject("cbjointname.Visible")));
			// 
			// hcFolders
			// 
			this.hcFolders.AccessibleDescription = resources.GetString("hcFolders.AccessibleDescription");
			this.hcFolders.AccessibleName = resources.GetString("hcFolders.AccessibleName");
			this.hcFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcFolders.Anchor")));
			this.hcFolders.AutoScroll = ((bool)(resources.GetObject("hcFolders.AutoScroll")));
			this.hcFolders.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcFolders.AutoScrollMargin")));
			this.hcFolders.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcFolders.AutoScrollMinSize")));
			this.hcFolders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcFolders.BackgroundImage")));
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
			this.hcFolders.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcFolders.Dock")));
			this.hcFolders.Enabled = ((bool)(resources.GetObject("hcFolders.Enabled")));
			this.hcFolders.Font = ((System.Drawing.Font)(resources.GetObject("hcFolders.Font")));
			this.hcFolders.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcFolders.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcFolders.ImeMode")));
			this.hcFolders.Location = ((System.Drawing.Point)(resources.GetObject("hcFolders.Location")));
			this.hcFolders.Name = "hcFolders";
			this.hcFolders.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcFolders.RightToLeft")));
			this.hcFolders.Size = ((System.Drawing.Size)(resources.GetObject("hcFolders.Size")));
			this.hcFolders.TabIndex = ((int)(resources.GetObject("hcFolders.TabIndex")));
			this.hcFolders.Text = resources.GetString("hcFolders.Text");
			this.toolTip1.SetToolTip(this.hcFolders, resources.GetString("hcFolders.ToolTip"));
			this.hcFolders.Visible = ((bool)(resources.GetObject("hcFolders.Visible")));
			// 
			// hcSettings
			// 
			this.hcSettings.AccessibleDescription = resources.GetString("hcSettings.AccessibleDescription");
			this.hcSettings.AccessibleName = resources.GetString("hcSettings.AccessibleName");
			this.hcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcSettings.Anchor")));
			this.hcSettings.AutoScroll = ((bool)(resources.GetObject("hcSettings.AutoScroll")));
			this.hcSettings.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcSettings.AutoScrollMargin")));
			this.hcSettings.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcSettings.AutoScrollMinSize")));
			this.hcSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcSettings.BackgroundImage")));
			this.hcSettings.Controls.Add(this.button8);
			this.hcSettings.Controls.Add(this.groupBox6);
			this.hcSettings.Controls.Add(this.groupBox5);
			this.hcSettings.Controls.Add(this.button6);
			this.hcSettings.Controls.Add(this.groupBox2);
			this.hcSettings.Controls.Add(this.groupBox1);
			this.hcSettings.Controls.Add(this.groupBox3);
			this.hcSettings.Controls.Add(this.button7);
			this.hcSettings.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcSettings.Dock")));
			this.hcSettings.Enabled = ((bool)(resources.GetObject("hcSettings.Enabled")));
			this.hcSettings.Font = ((System.Drawing.Font)(resources.GetObject("hcSettings.Font")));
			this.hcSettings.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcSettings.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcSettings.ImeMode")));
			this.hcSettings.Location = ((System.Drawing.Point)(resources.GetObject("hcSettings.Location")));
			this.hcSettings.Name = "hcSettings";
			this.hcSettings.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcSettings.RightToLeft")));
			this.hcSettings.Size = ((System.Drawing.Size)(resources.GetObject("hcSettings.Size")));
			this.hcSettings.TabIndex = ((int)(resources.GetObject("hcSettings.TabIndex")));
			this.hcSettings.Text = resources.GetString("hcSettings.Text");
			this.toolTip1.SetToolTip(this.hcSettings, resources.GetString("hcSettings.ToolTip"));
			this.hcSettings.Visible = ((bool)(resources.GetObject("hcSettings.Visible")));
			// 
			// button8
			// 
			this.button8.AccessibleDescription = resources.GetString("button8.AccessibleDescription");
			this.button8.AccessibleName = resources.GetString("button8.AccessibleName");
			this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button8.Anchor")));
			this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
			this.button8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button8.Dock")));
			this.button8.Enabled = ((bool)(resources.GetObject("button8.Enabled")));
			this.button8.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button8.FlatStyle")));
			this.button8.Font = ((System.Drawing.Font)(resources.GetObject("button8.Font")));
			this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
			this.button8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button8.ImageAlign")));
			this.button8.ImageIndex = ((int)(resources.GetObject("button8.ImageIndex")));
			this.button8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button8.ImeMode")));
			this.button8.Location = ((System.Drawing.Point)(resources.GetObject("button8.Location")));
			this.button8.Name = "button8";
			this.button8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button8.RightToLeft")));
			this.button8.Size = ((System.Drawing.Size)(resources.GetObject("button8.Size")));
			this.button8.TabIndex = ((int)(resources.GetObject("button8.TabIndex")));
			this.button8.Text = resources.GetString("button8.Text");
			this.button8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button8.TextAlign")));
			this.toolTip1.SetToolTip(this.button8, resources.GetString("button8.ToolTip"));
			this.button8.Visible = ((bool)(resources.GetObject("button8.Visible")));
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.AccessibleDescription = resources.GetString("groupBox6.AccessibleDescription");
			this.groupBox6.AccessibleName = resources.GetString("groupBox6.AccessibleName");
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox6.Anchor")));
			this.groupBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox6.BackgroundImage")));
			this.groupBox6.Controls.Add(this.cbFirefox);
			this.groupBox6.Controls.Add(this.cbSimple);
			this.groupBox6.Controls.Add(this.cbmulti);
			this.groupBox6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox6.Dock")));
			this.groupBox6.Enabled = ((bool)(resources.GetObject("groupBox6.Enabled")));
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox6.Font = ((System.Drawing.Font)(resources.GetObject("groupBox6.Font")));
			this.groupBox6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox6.ImeMode")));
			this.groupBox6.Location = ((System.Drawing.Point)(resources.GetObject("groupBox6.Location")));
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox6.RightToLeft")));
			this.groupBox6.Size = ((System.Drawing.Size)(resources.GetObject("groupBox6.Size")));
			this.groupBox6.TabIndex = ((int)(resources.GetObject("groupBox6.TabIndex")));
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = resources.GetString("groupBox6.Text");
			this.toolTip1.SetToolTip(this.groupBox6, resources.GetString("groupBox6.ToolTip"));
			this.groupBox6.Visible = ((bool)(resources.GetObject("groupBox6.Visible")));
			// 
			// cbFirefox
			// 
			this.cbFirefox.AccessibleDescription = resources.GetString("cbFirefox.AccessibleDescription");
			this.cbFirefox.AccessibleName = resources.GetString("cbFirefox.AccessibleName");
			this.cbFirefox.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbFirefox.Anchor")));
			this.cbFirefox.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbFirefox.Appearance")));
			this.cbFirefox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbFirefox.BackgroundImage")));
			this.cbFirefox.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbFirefox.CheckAlign")));
			this.cbFirefox.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbFirefox.Dock")));
			this.cbFirefox.Enabled = ((bool)(resources.GetObject("cbFirefox.Enabled")));
			this.cbFirefox.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbFirefox.FlatStyle")));
			this.cbFirefox.Font = ((System.Drawing.Font)(resources.GetObject("cbFirefox.Font")));
			this.cbFirefox.Image = ((System.Drawing.Image)(resources.GetObject("cbFirefox.Image")));
			this.cbFirefox.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbFirefox.ImageAlign")));
			this.cbFirefox.ImageIndex = ((int)(resources.GetObject("cbFirefox.ImageIndex")));
			this.cbFirefox.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbFirefox.ImeMode")));
			this.cbFirefox.Location = ((System.Drawing.Point)(resources.GetObject("cbFirefox.Location")));
			this.cbFirefox.Name = "cbFirefox";
			this.cbFirefox.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbFirefox.RightToLeft")));
			this.cbFirefox.Size = ((System.Drawing.Size)(resources.GetObject("cbFirefox.Size")));
			this.cbFirefox.TabIndex = ((int)(resources.GetObject("cbFirefox.TabIndex")));
			this.cbFirefox.Text = resources.GetString("cbFirefox.Text");
			this.cbFirefox.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbFirefox.TextAlign")));
			this.toolTip1.SetToolTip(this.cbFirefox, resources.GetString("cbFirefox.ToolTip"));
			this.cbFirefox.Visible = ((bool)(resources.GetObject("cbFirefox.Visible")));
			// 
			// groupBox5
			// 
			this.groupBox5.AccessibleDescription = resources.GetString("groupBox5.AccessibleDescription");
			this.groupBox5.AccessibleName = resources.GetString("groupBox5.AccessibleName");
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox5.Anchor")));
			this.groupBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox5.BackgroundImage")));
			this.groupBox5.Controls.Add(this.cbThemes);
			this.groupBox5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox5.Dock")));
			this.groupBox5.Enabled = ((bool)(resources.GetObject("groupBox5.Enabled")));
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Font = ((System.Drawing.Font)(resources.GetObject("groupBox5.Font")));
			this.groupBox5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox5.ImeMode")));
			this.groupBox5.Location = ((System.Drawing.Point)(resources.GetObject("groupBox5.Location")));
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox5.RightToLeft")));
			this.groupBox5.Size = ((System.Drawing.Size)(resources.GetObject("groupBox5.Size")));
			this.groupBox5.TabIndex = ((int)(resources.GetObject("groupBox5.TabIndex")));
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = resources.GetString("groupBox5.Text");
			this.toolTip1.SetToolTip(this.groupBox5, resources.GetString("groupBox5.ToolTip"));
			this.groupBox5.Visible = ((bool)(resources.GetObject("groupBox5.Visible")));
			// 
			// cbThemes
			// 
			this.cbThemes.AccessibleDescription = resources.GetString("cbThemes.AccessibleDescription");
			this.cbThemes.AccessibleName = resources.GetString("cbThemes.AccessibleName");
			this.cbThemes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbThemes.Anchor")));
			this.cbThemes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbThemes.BackgroundImage")));
			this.cbThemes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbThemes.Dock")));
			this.cbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbThemes.Enabled = ((bool)(resources.GetObject("cbThemes.Enabled")));
			this.cbThemes.Font = ((System.Drawing.Font)(resources.GetObject("cbThemes.Font")));
			this.cbThemes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbThemes.ImeMode")));
			this.cbThemes.IntegralHeight = ((bool)(resources.GetObject("cbThemes.IntegralHeight")));
			this.cbThemes.ItemHeight = ((int)(resources.GetObject("cbThemes.ItemHeight")));
			this.cbThemes.Location = ((System.Drawing.Point)(resources.GetObject("cbThemes.Location")));
			this.cbThemes.MaxDropDownItems = ((int)(resources.GetObject("cbThemes.MaxDropDownItems")));
			this.cbThemes.MaxLength = ((int)(resources.GetObject("cbThemes.MaxLength")));
			this.cbThemes.Name = "cbThemes";
			this.cbThemes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbThemes.RightToLeft")));
			this.cbThemes.Size = ((System.Drawing.Size)(resources.GetObject("cbThemes.Size")));
			this.cbThemes.TabIndex = ((int)(resources.GetObject("cbThemes.TabIndex")));
			this.cbThemes.Text = resources.GetString("cbThemes.Text");
			this.toolTip1.SetToolTip(this.cbThemes, resources.GetString("cbThemes.ToolTip"));
			this.cbThemes.Visible = ((bool)(resources.GetObject("cbThemes.Visible")));
			this.cbThemes.SelectedIndexChanged += new System.EventHandler(this.ChangedThemeHandler);
			// 
			// button7
			// 
			this.button7.AccessibleDescription = resources.GetString("button7.AccessibleDescription");
			this.button7.AccessibleName = resources.GetString("button7.AccessibleName");
			this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button7.Anchor")));
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button7.Dock")));
			this.button7.Enabled = ((bool)(resources.GetObject("button7.Enabled")));
			this.button7.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button7.FlatStyle")));
			this.button7.Font = ((System.Drawing.Font)(resources.GetObject("button7.Font")));
			this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
			this.button7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button7.ImageAlign")));
			this.button7.ImageIndex = ((int)(resources.GetObject("button7.ImageIndex")));
			this.button7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button7.ImeMode")));
			this.button7.Location = ((System.Drawing.Point)(resources.GetObject("button7.Location")));
			this.button7.Name = "button7";
			this.button7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button7.RightToLeft")));
			this.button7.Size = ((System.Drawing.Size)(resources.GetObject("button7.Size")));
			this.button7.TabIndex = ((int)(resources.GetObject("button7.TabIndex")));
			this.button7.Text = resources.GetString("button7.Text");
			this.button7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button7.TextAlign")));
			this.toolTip1.SetToolTip(this.button7, resources.GetString("button7.ToolTip"));
			this.button7.Visible = ((bool)(resources.GetObject("button7.Visible")));
			this.button7.Click += new System.EventHandler(this.ResetLayoutClick);
			// 
			// hcTools
			// 
			this.hcTools.AccessibleDescription = resources.GetString("hcTools.AccessibleDescription");
			this.hcTools.AccessibleName = resources.GetString("hcTools.AccessibleName");
			this.hcTools.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcTools.Anchor")));
			this.hcTools.AutoScroll = ((bool)(resources.GetObject("hcTools.AutoScroll")));
			this.hcTools.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcTools.AutoScrollMargin")));
			this.hcTools.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcTools.AutoScrollMinSize")));
			this.hcTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcTools.BackgroundImage")));
			this.hcTools.Controls.Add(this.lbext);
			this.hcTools.Controls.Add(this.linkLabel1);
			this.hcTools.Controls.Add(this.linkLabel2);
			this.hcTools.Controls.Add(this.label1);
			this.hcTools.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcTools.Dock")));
			this.hcTools.Enabled = ((bool)(resources.GetObject("hcTools.Enabled")));
			this.hcTools.Font = ((System.Drawing.Font)(resources.GetObject("hcTools.Font")));
			this.hcTools.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcTools.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcTools.ImeMode")));
			this.hcTools.Location = ((System.Drawing.Point)(resources.GetObject("hcTools.Location")));
			this.hcTools.Name = "hcTools";
			this.hcTools.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcTools.RightToLeft")));
			this.hcTools.Size = ((System.Drawing.Size)(resources.GetObject("hcTools.Size")));
			this.hcTools.TabIndex = ((int)(resources.GetObject("hcTools.TabIndex")));
			this.hcTools.Text = resources.GetString("hcTools.Text");
			this.toolTip1.SetToolTip(this.hcTools, resources.GetString("hcTools.ToolTip"));
			this.hcTools.Visible = ((bool)(resources.GetObject("hcTools.Visible")));
			// 
			// hcFileTable
			// 
			this.hcFileTable.AccessibleDescription = resources.GetString("hcFileTable.AccessibleDescription");
			this.hcFileTable.AccessibleName = resources.GetString("hcFileTable.AccessibleName");
			this.hcFileTable.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcFileTable.Anchor")));
			this.hcFileTable.AutoScroll = ((bool)(resources.GetObject("hcFileTable.AutoScroll")));
			this.hcFileTable.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcFileTable.AutoScrollMargin")));
			this.hcFileTable.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcFileTable.AutoScrollMinSize")));
			this.hcFileTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcFileTable.BackgroundImage")));
			this.hcFileTable.Controls.Add(this.btdn);
			this.hcFileTable.Controls.Add(this.btup);
			this.hcFileTable.Controls.Add(this.lladddown);
			this.hcFileTable.Controls.Add(this.lldel);
			this.hcFileTable.Controls.Add(this.lladd);
			this.hcFileTable.Controls.Add(this.lbfolder);
			this.hcFileTable.Controls.Add(this.label9);
			this.hcFileTable.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcFileTable.Dock")));
			this.hcFileTable.Enabled = ((bool)(resources.GetObject("hcFileTable.Enabled")));
			this.hcFileTable.Font = ((System.Drawing.Font)(resources.GetObject("hcFileTable.Font")));
			this.hcFileTable.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcFileTable.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcFileTable.ImeMode")));
			this.hcFileTable.Location = ((System.Drawing.Point)(resources.GetObject("hcFileTable.Location")));
			this.hcFileTable.Name = "hcFileTable";
			this.hcFileTable.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcFileTable.RightToLeft")));
			this.hcFileTable.Size = ((System.Drawing.Size)(resources.GetObject("hcFileTable.Size")));
			this.hcFileTable.TabIndex = ((int)(resources.GetObject("hcFileTable.TabIndex")));
			this.hcFileTable.Text = resources.GetString("hcFileTable.Text");
			this.toolTip1.SetToolTip(this.hcFileTable, resources.GetString("hcFileTable.ToolTip"));
			this.hcFileTable.Visible = ((bool)(resources.GetObject("hcFileTable.Visible")));
			// 
			// btdn
			// 
			this.btdn.AccessibleDescription = resources.GetString("btdn.AccessibleDescription");
			this.btdn.AccessibleName = resources.GetString("btdn.AccessibleName");
			this.btdn.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btdn.Anchor")));
			this.btdn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdn.BackgroundImage")));
			this.btdn.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btdn.Dock")));
			this.btdn.Enabled = ((bool)(resources.GetObject("btdn.Enabled")));
			this.btdn.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btdn.FlatStyle")));
			this.btdn.Font = ((System.Drawing.Font)(resources.GetObject("btdn.Font")));
			this.btdn.Image = ((System.Drawing.Image)(resources.GetObject("btdn.Image")));
			this.btdn.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdn.ImageAlign")));
			this.btdn.ImageIndex = ((int)(resources.GetObject("btdn.ImageIndex")));
			this.btdn.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btdn.ImeMode")));
			this.btdn.Location = ((System.Drawing.Point)(resources.GetObject("btdn.Location")));
			this.btdn.Name = "btdn";
			this.btdn.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btdn.RightToLeft")));
			this.btdn.Size = ((System.Drawing.Size)(resources.GetObject("btdn.Size")));
			this.btdn.TabIndex = ((int)(resources.GetObject("btdn.TabIndex")));
			this.btdn.Text = resources.GetString("btdn.Text");
			this.btdn.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdn.TextAlign")));
			this.toolTip1.SetToolTip(this.btdn, resources.GetString("btdn.ToolTip"));
			this.btdn.Visible = ((bool)(resources.GetObject("btdn.Visible")));
			this.btdn.Click += new System.EventHandler(this.btdn_Click);
			// 
			// btup
			// 
			this.btup.AccessibleDescription = resources.GetString("btup.AccessibleDescription");
			this.btup.AccessibleName = resources.GetString("btup.AccessibleName");
			this.btup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btup.Anchor")));
			this.btup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btup.BackgroundImage")));
			this.btup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btup.Dock")));
			this.btup.Enabled = ((bool)(resources.GetObject("btup.Enabled")));
			this.btup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btup.FlatStyle")));
			this.btup.Font = ((System.Drawing.Font)(resources.GetObject("btup.Font")));
			this.btup.Image = ((System.Drawing.Image)(resources.GetObject("btup.Image")));
			this.btup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btup.ImageAlign")));
			this.btup.ImageIndex = ((int)(resources.GetObject("btup.ImageIndex")));
			this.btup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btup.ImeMode")));
			this.btup.Location = ((System.Drawing.Point)(resources.GetObject("btup.Location")));
			this.btup.Name = "btup";
			this.btup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btup.RightToLeft")));
			this.btup.Size = ((System.Drawing.Size)(resources.GetObject("btup.Size")));
			this.btup.TabIndex = ((int)(resources.GetObject("btup.TabIndex")));
			this.btup.Text = resources.GetString("btup.Text");
			this.btup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btup.TextAlign")));
			this.toolTip1.SetToolTip(this.btup, resources.GetString("btup.ToolTip"));
			this.btup.Visible = ((bool)(resources.GetObject("btup.Visible")));
			this.btup.Click += new System.EventHandler(this.btup_Click);
			// 
			// hcSceneGraph
			// 
			this.hcSceneGraph.AccessibleDescription = resources.GetString("hcSceneGraph.AccessibleDescription");
			this.hcSceneGraph.AccessibleName = resources.GetString("hcSceneGraph.AccessibleName");
			this.hcSceneGraph.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcSceneGraph.Anchor")));
			this.hcSceneGraph.AutoScroll = ((bool)(resources.GetObject("hcSceneGraph.AutoScroll")));
			this.hcSceneGraph.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcSceneGraph.AutoScrollMargin")));
			this.hcSceneGraph.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcSceneGraph.AutoScrollMinSize")));
			this.hcSceneGraph.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcSceneGraph.BackgroundImage")));
			this.hcSceneGraph.Controls.Add(this.groupBox4);
			this.hcSceneGraph.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcSceneGraph.Dock")));
			this.hcSceneGraph.Enabled = ((bool)(resources.GetObject("hcSceneGraph.Enabled")));
			this.hcSceneGraph.Font = ((System.Drawing.Font)(resources.GetObject("hcSceneGraph.Font")));
			this.hcSceneGraph.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcSceneGraph.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcSceneGraph.ImeMode")));
			this.hcSceneGraph.Location = ((System.Drawing.Point)(resources.GetObject("hcSceneGraph.Location")));
			this.hcSceneGraph.Name = "hcSceneGraph";
			this.hcSceneGraph.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcSceneGraph.RightToLeft")));
			this.hcSceneGraph.Size = ((System.Drawing.Size)(resources.GetObject("hcSceneGraph.Size")));
			this.hcSceneGraph.TabIndex = ((int)(resources.GetObject("hcSceneGraph.TabIndex")));
			this.hcSceneGraph.Text = resources.GetString("hcSceneGraph.Text");
			this.toolTip1.SetToolTip(this.hcSceneGraph, resources.GetString("hcSceneGraph.ToolTip"));
			this.hcSceneGraph.Visible = ((bool)(resources.GetObject("hcSceneGraph.Visible")));
			// 
			// bb
			// 
			this.bb.AccessibleDescription = resources.GetString("bb.AccessibleDescription");
			this.bb.AccessibleName = resources.GetString("bb.AccessibleName");
			this.bb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bb.Anchor")));
			this.bb.AutoScroll = ((bool)(resources.GetObject("bb.AutoScroll")));
			this.bb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("bb.AutoScrollMargin")));
			this.bb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("bb.AutoScrollMinSize")));
			this.bb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bb.BackgroundImage")));
			this.bb.Buttons.AddRange(new Divelements.Navisight.NavigationButton[] {
																					  this.nbFolders,
																					  this.nbSettings,
																					  this.nbTools,
																					  this.nbFileTable,
																					  this.nbSceneGraph,
																					  this.nbPlugins});
			this.bb.ButtonSpacing = 16;
			this.bb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bb.Dock")));
			this.bb.Enabled = ((bool)(resources.GetObject("bb.Enabled")));
			this.bb.Font = ((System.Drawing.Font)(resources.GetObject("bb.Font")));
			this.bb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bb.ImeMode")));
			this.bb.Location = ((System.Drawing.Point)(resources.GetObject("bb.Location")));
			this.bb.Name = "bb";
			this.bb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bb.RightToLeft")));
			this.bb.Size = ((System.Drawing.Size)(resources.GetObject("bb.Size")));
			this.bb.TabIndex = ((int)(resources.GetObject("bb.TabIndex")));
			this.bb.Text = resources.GetString("bb.Text");
			this.toolTip1.SetToolTip(this.bb, resources.GetString("bb.ToolTip"));
			this.bb.Visible = ((bool)(resources.GetObject("bb.Visible")));
			// 
			// nbFolders
			// 
			this.nbFolders.Checked = true;
			this.nbFolders.Image = ((System.Drawing.Image)(resources.GetObject("nbFolders.Image")));
			this.nbFolders.Text = resources.GetString("nbFolders.Text");
			this.nbFolders.ToolTipText = resources.GetString("nbFolders.ToolTipText");
			this.nbFolders.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// nbSettings
			// 
			this.nbSettings.Image = ((System.Drawing.Image)(resources.GetObject("nbSettings.Image")));
			this.nbSettings.Text = resources.GetString("nbSettings.Text");
			this.nbSettings.ToolTipText = resources.GetString("nbSettings.ToolTipText");
			this.nbSettings.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// nbTools
			// 
			this.nbTools.Image = ((System.Drawing.Image)(resources.GetObject("nbTools.Image")));
			this.nbTools.Text = resources.GetString("nbTools.Text");
			this.nbTools.ToolTipText = resources.GetString("nbTools.ToolTipText");
			this.nbTools.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// nbFileTable
			// 
			this.nbFileTable.Image = ((System.Drawing.Image)(resources.GetObject("nbFileTable.Image")));
			this.nbFileTable.Text = resources.GetString("nbFileTable.Text");
			this.nbFileTable.ToolTipText = resources.GetString("nbFileTable.ToolTipText");
			this.nbFileTable.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// nbSceneGraph
			// 
			this.nbSceneGraph.Image = ((System.Drawing.Image)(resources.GetObject("nbSceneGraph.Image")));
			this.nbSceneGraph.Text = resources.GetString("nbSceneGraph.Text");
			this.nbSceneGraph.ToolTipText = resources.GetString("nbSceneGraph.ToolTipText");
			this.nbSceneGraph.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// nbPlugins
			// 
			this.nbPlugins.Image = ((System.Drawing.Image)(resources.GetObject("nbPlugins.Image")));
			this.nbPlugins.Text = resources.GetString("nbPlugins.Text");
			this.nbPlugins.ToolTipText = resources.GetString("nbPlugins.ToolTipText");
			this.nbPlugins.Activate += new System.EventHandler(this.SelectCategory);
			// 
			// hcPlugins
			// 
			this.hcPlugins.AccessibleDescription = resources.GetString("hcPlugins.AccessibleDescription");
			this.hcPlugins.AccessibleName = resources.GetString("hcPlugins.AccessibleName");
			this.hcPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("hcPlugins.Anchor")));
			this.hcPlugins.AutoScroll = ((bool)(resources.GetObject("hcPlugins.AutoScroll")));
			this.hcPlugins.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("hcPlugins.AutoScrollMargin")));
			this.hcPlugins.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("hcPlugins.AutoScrollMinSize")));
			this.hcPlugins.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hcPlugins.BackgroundImage")));
			this.hcPlugins.Controls.Add(this.btpup);
			this.hcPlugins.Controls.Add(this.btpdown);
			this.hcPlugins.Controls.Add(this.cnt);
			this.hcPlugins.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("hcPlugins.Dock")));
			this.hcPlugins.Enabled = ((bool)(resources.GetObject("hcPlugins.Enabled")));
			this.hcPlugins.Font = ((System.Drawing.Font)(resources.GetObject("hcPlugins.Font")));
			this.hcPlugins.HeaderFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.hcPlugins.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("hcPlugins.ImeMode")));
			this.hcPlugins.Location = ((System.Drawing.Point)(resources.GetObject("hcPlugins.Location")));
			this.hcPlugins.Name = "hcPlugins";
			this.hcPlugins.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("hcPlugins.RightToLeft")));
			this.hcPlugins.Size = ((System.Drawing.Size)(resources.GetObject("hcPlugins.Size")));
			this.hcPlugins.TabIndex = ((int)(resources.GetObject("hcPlugins.TabIndex")));
			this.hcPlugins.Text = resources.GetString("hcPlugins.Text");
			this.toolTip1.SetToolTip(this.hcPlugins, resources.GetString("hcPlugins.ToolTip"));
			this.hcPlugins.Visible = ((bool)(resources.GetObject("hcPlugins.Visible")));
			// 
			// btpup
			// 
			this.btpup.AccessibleDescription = resources.GetString("btpup.AccessibleDescription");
			this.btpup.AccessibleName = resources.GetString("btpup.AccessibleName");
			this.btpup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btpup.Anchor")));
			this.btpup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btpup.BackgroundImage")));
			this.btpup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btpup.Dock")));
			this.btpup.Enabled = ((bool)(resources.GetObject("btpup.Enabled")));
			this.btpup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btpup.FlatStyle")));
			this.btpup.Font = ((System.Drawing.Font)(resources.GetObject("btpup.Font")));
			this.btpup.Image = ((System.Drawing.Image)(resources.GetObject("btpup.Image")));
			this.btpup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btpup.ImageAlign")));
			this.btpup.ImageIndex = ((int)(resources.GetObject("btpup.ImageIndex")));
			this.btpup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btpup.ImeMode")));
			this.btpup.Location = ((System.Drawing.Point)(resources.GetObject("btpup.Location")));
			this.btpup.Name = "btpup";
			this.btpup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btpup.RightToLeft")));
			this.btpup.Size = ((System.Drawing.Size)(resources.GetObject("btpup.Size")));
			this.btpup.TabIndex = ((int)(resources.GetObject("btpup.TabIndex")));
			this.btpup.Text = resources.GetString("btpup.Text");
			this.btpup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btpup.TextAlign")));
			this.toolTip1.SetToolTip(this.btpup, resources.GetString("btpup.ToolTip"));
			this.btpup.Visible = ((bool)(resources.GetObject("btpup.Visible")));
			this.btpup.Click += new System.EventHandler(this.btpup_Click);
			// 
			// btpdown
			// 
			this.btpdown.AccessibleDescription = resources.GetString("btpdown.AccessibleDescription");
			this.btpdown.AccessibleName = resources.GetString("btpdown.AccessibleName");
			this.btpdown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btpdown.Anchor")));
			this.btpdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btpdown.BackgroundImage")));
			this.btpdown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btpdown.Dock")));
			this.btpdown.Enabled = ((bool)(resources.GetObject("btpdown.Enabled")));
			this.btpdown.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btpdown.FlatStyle")));
			this.btpdown.Font = ((System.Drawing.Font)(resources.GetObject("btpdown.Font")));
			this.btpdown.Image = ((System.Drawing.Image)(resources.GetObject("btpdown.Image")));
			this.btpdown.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btpdown.ImageAlign")));
			this.btpdown.ImageIndex = ((int)(resources.GetObject("btpdown.ImageIndex")));
			this.btpdown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btpdown.ImeMode")));
			this.btpdown.Location = ((System.Drawing.Point)(resources.GetObject("btpdown.Location")));
			this.btpdown.Name = "btpdown";
			this.btpdown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btpdown.RightToLeft")));
			this.btpdown.Size = ((System.Drawing.Size)(resources.GetObject("btpdown.Size")));
			this.btpdown.TabIndex = ((int)(resources.GetObject("btpdown.TabIndex")));
			this.btpdown.Text = resources.GetString("btpdown.Text");
			this.btpdown.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btpdown.TextAlign")));
			this.toolTip1.SetToolTip(this.btpdown, resources.GetString("btpdown.ToolTip"));
			this.btpdown.Visible = ((bool)(resources.GetObject("btpdown.Visible")));
			this.btpdown.Click += new System.EventHandler(this.btpdown_Click);
			// 
			// cnt
			// 
			this.cnt.AccessibleDescription = resources.GetString("cnt.AccessibleDescription");
			this.cnt.AccessibleName = resources.GetString("cnt.AccessibleName");
			this.cnt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cnt.Anchor")));
			this.cnt.AutoScroll = ((bool)(resources.GetObject("cnt.AutoScroll")));
			this.cnt.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("cnt.AutoScrollMargin")));
			this.cnt.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("cnt.AutoScrollMinSize")));
			this.cnt.BackColor = System.Drawing.SystemColors.Window;
			this.cnt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cnt.BackgroundImage")));
			this.cnt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cnt.Dock")));
			this.cnt.Enabled = ((bool)(resources.GetObject("cnt.Enabled")));
			this.cnt.Font = ((System.Drawing.Font)(resources.GetObject("cnt.Font")));
			this.cnt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cnt.ImeMode")));
			this.cnt.Location = ((System.Drawing.Point)(resources.GetObject("cnt.Location")));
			this.cnt.Name = "cnt";
			this.cnt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cnt.RightToLeft")));
			this.cnt.Size = ((System.Drawing.Size)(resources.GetObject("cnt.Size")));
			this.cnt.TabIndex = ((int)(resources.GetObject("cnt.TabIndex")));
			this.cnt.Text = resources.GetString("cnt.Text");
			this.toolTip1.SetToolTip(this.cnt, resources.GetString("cnt.ToolTip"));
			this.cnt.Visible = ((bool)(resources.GetObject("cnt.Visible")));
			// 
			// baloonTip
			// 
			this.baloonTip.Enabled = true;
			// 
			// navigationButton1
			// 
			this.navigationButton1.Text = resources.GetString("navigationButton1.Text");
			this.navigationButton1.ToolTipText = resources.GetString("navigationButton1.ToolTipText");
			// 
			// navigationButton2
			// 
			this.navigationButton2.Text = resources.GetString("navigationButton2.Text");
			this.navigationButton2.ToolTipText = resources.GetString("navigationButton2.ToolTipText");
			// 
			// OptionForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.bb);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.hcSettings);
			this.Controls.Add(this.hcPlugins);
			this.Controls.Add(this.hcTools);
			this.Controls.Add(this.hcFileTable);
			this.Controls.Add(this.hcFolders);
			this.Controls.Add(this.hcSceneGraph);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "OptionForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.hcFolders.ResumeLayout(false);
			this.hcSettings.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.hcTools.ResumeLayout(false);
			this.hcFileTable.ResumeLayout(false);
			this.hcSceneGraph.ResumeLayout(false);
			this.hcPlugins.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		void Execute()
		{
			//linkLabel3.Enabled = (Helper.WindowsRegistry.EPInstalled>=1);
			tbgame.Text = Helper.WindowsRegistry.SimsPath;
			tbep1.Text = Helper.WindowsRegistry.SimsEP1Path;
			//tbep1.Text = Helper.WindowsRegistry.RealEP1GamePath;
			tbsavegame.Text = Helper.WindowsRegistry.SimSavegameFolder;
			tbdds.Text = Helper.WindowsRegistry.NvidiaDDSPath;
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

			this.tbep1.ReadOnly = (Helper.WindowsRegistry.EPInstalled<1);
			this.button5.Enabled = (Helper.WindowsRegistry.EPInstalled>=1);
			llsetep1.Enabled = button5.Enabled;

			if (((byte)Helper.WindowsRegistry.LanguageCode <= cblang.Items.Count) && ((byte)Helper.WindowsRegistry.LanguageCode > 0))
			{
				cblang.SelectedIndex = (byte)Helper.WindowsRegistry.LanguageCode-1;
			}

			lbext.Items.Clear();
			foreach (ToolLoaderItemExt tli in ToolLoaderExt.Items) lbext.Items.Add(tli);

			//FileTable
			ArrayList folders = FileTable.DefaultFolders;
			lbfolder.Items.Clear();
			foreach (FileTableItem fti in folders) 
			{
				lbfolder.Items.Add(fti);
			}

			//Favorite Theme
			GuiTheme gt = (GuiTheme)Helper.WindowsRegistry.Layout.SelectedTheme;
			for (int i=0; i<cbThemes.Items.Count; i++) 			
				if ((GuiTheme)cbThemes.Items[i]==gt) 
					cbThemes.SelectedIndex = i;

			this.ShowDialog();
		}

		private void SaveOptionsClick(object sender, System.EventArgs e)
		{
			Helper.WindowsRegistry.SimsPath = this.tbgame.Text;
			Helper.WindowsRegistry.SimsEP1Path = this.tbep1.Text;
			Helper.WindowsRegistry.SimSavegameFolder = this.tbsavegame.Text;
			Helper.WindowsRegistry.NvidiaDDSPath = tbdds.Text;
			Helper.WindowsRegistry.LanguageCode = (Data.MetaData.Languages)cblang.SelectedIndex+1;
			Helper.WindowsRegistry.GameDebug = cbdebug.Checked;
			Helper.WindowsRegistry.AutoBackup = cbautobak.Checked;
			Helper.WindowsRegistry.BlurNudity = cbblur.Checked;
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
			
			StoreFoldersXml();
			try 
			{
				Helper.WindowsRegistry.OWThumbSize = Convert.ToInt32(tbthumb.Text);
				Helper.WindowsRegistry.ImportExportScaleFactor = Convert.ToSingle(tbscale.Text);
			}
			catch {}

			
			
			ToolLoaderExt.Items = new ToolLoaderItemExt[0];
			foreach (ToolLoaderItemExt tli in lbext.Items) ToolLoaderExt.Add(tli);;
			ToolLoaderExt.StoreTools();
			Close();
		}

		private void DeleteExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbext.SelectedIndex<0) return;
			lbext.Items.Remove(lbext.Items[lbext.SelectedIndex]);
		}

		private void AddExt(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			AddExtTool aet = new AddExtTool();
			ToolLoaderItemExt tli = aet.Execute();

			if (tli!=null) lbext.Items.Add(tli);
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbgame.Text)) fbd.SelectedPath = tbgame.Text;
			if (fbd.ShowDialog()==DialogResult.OK) this.tbgame.Text = fbd.SelectedPath;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbsavegame.Text)) fbd.SelectedPath = tbsavegame.Text;
			if (fbd.ShowDialog()==DialogResult.OK) this.tbsavegame.Text = fbd.SelectedPath;
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbdds.Text)) ofd.InitialDirectory = tbdds.Text;
			if (ofd.ShowDialog()==DialogResult.OK) this.tbdds.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
		}
		
		private void label2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			tbgame.Text = Helper.WindowsRegistry.RealGamePath;			
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			tbep1.Text = Helper.WindowsRegistry.RealEP1GamePath;
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			tbsavegame.Text = Helper.WindowsRegistry.RealSavegamePath;
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			if (System.IO.Directory.Exists(tbgame.Text)) fbd.SelectedPath = tbep1.Text;
			if (fbd.ShowDialog()==DialogResult.OK) this.tbep1.Text = fbd.SelectedPath;
		}

		private void ClearCaches(object sender, System.EventArgs e)
		{
			string[] files = System.IO.Directory.GetFiles(Helper.SimPeDataPath, "*.simpepkg");
			foreach (string file in files) 
			{
				try 
				{
					System.IO.File.Delete(file);
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}
			}
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
			FileTableItem fti = new FileTableItem("Downloads", true, false, true);
			fti.Name = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");
			fti.Type = FileTableItemType.SaveGameFolder;
			lbfolder.Items.Insert(0, fti);
		}

		private void btup_Click(object sender, System.EventArgs e)
		{
			if (lbfolder.SelectedIndex<1) return;
			object o = lbfolder.Items[lbfolder.SelectedIndex-1];
			lbfolder.Items[lbfolder.SelectedIndex-1] = lbfolder.Items[lbfolder.SelectedIndex];
			lbfolder.Items[lbfolder.SelectedIndex] = o;

			lbfolder.SelectedIndex--;
		}

		private void btdn_Click(object sender, System.EventArgs e)
		{
			if (lbfolder.SelectedIndex>lbfolder.Items.Count-2) return;
			object o = lbfolder.Items[lbfolder.SelectedIndex+1];
			lbfolder.Items[lbfolder.SelectedIndex+1] = lbfolder.Items[lbfolder.SelectedIndex];
			lbfolder.Items[lbfolder.SelectedIndex] = o;

			lbfolder.SelectedIndex++;
		}

		private void lldel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbfolder.SelectedIndex<0) return;
			lbfolder.Items.RemoveAt(lbfolder.SelectedIndex);
		}

		private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (fbd.ShowDialog()==DialogResult.OK) 
			{
				FileTableItem fti = new FileTableItem(fbd.SelectedPath);
				lbfolder.Items.Insert(0, fti);
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
						
						if (fti.Type!=FileTableItemType.Absolute) 
						{
							switch (fti.Type) 
							{
								case FileTableItemType.EP1GameFolder: 
								{
									tw.Write(" root=\"ep1\"");
									break;
								}
								case FileTableItemType.GameFolder:
								{
									tw.Write(" root=\"game\"");
									break;
								}
								case FileTableItemType.SaveGameFolder: 
								{
									tw.Write(" root=\"save\"");
									break;
								}
								case FileTableItemType.SimPEFolder:
								{
									tw.Write(" root=\"simpe\"");
									break;
								}
								case FileTableItemType.SimPEDataFolder:
								{
									tw.Write(" root=\"simpeData\"");
									break;
								}
								case FileTableItemType.SimPEPluginFolder:
								{
									tw.Write(" root=\"simpePlugin\"");
									break;
								}
							} //switch
						}
	
						if (fti.IsRecursive) tw.Write(" recursive=\"1\"");
						if (!fti.IsUseable) tw.Write(" epversion=\"1\"");

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
			tbep1.Text = Helper.WindowsRegistry.RealEP1GamePath;
		}

		void EnablePanel(Divelements.Navisight.NavigationButton panel) 
		{
			hcFolders.Visible = (panel==nbFolders);
			hcSettings.Visible = (panel==nbSettings);
			hcTools.Visible = (panel==nbTools);
			hcFileTable.Visible = (panel==nbFileTable);
			hcSceneGraph.Visible = (panel==nbSceneGraph);
			hcPlugins.Visible = (panel==nbPlugins);
		}

		private void SelectCategory(object sender, System.EventArgs e)
		{
			foreach (Divelements.Navisight.NavigationButton nb in bb.Buttons) 
			{
				nb.Checked = (nb==sender);

				if (nb.Checked) 
				{
					if (nb == nbFolders) EnablePanel(nbFolders);
					else if (nb == nbSettings) EnablePanel(nbSettings);
					else if (nb == nbTools) EnablePanel(nbTools);
					else if (nb == nbFileTable) EnablePanel(nbFileTable);
					else if (nb == nbSceneGraph) EnablePanel(nbSceneGraph);
					else if (nb == nbPlugins) EnablePanel(nbPlugins);
				}
			}
		}

		private void ChangedThemeHandler(object sender, System.EventArgs e)
		{
			if (NewTheme!=null) NewTheme((SimPe.GuiTheme)cbThemes.Items[cbThemes.SelectedIndex]);
		}

		private void ResetLayoutClick(object sender, System.EventArgs e)
		{
			if (ResetLayout!=null) ResetLayout(this, e);
		}

		#region Events
		public event SimPe.Events.ChangedThemeEvent NewTheme;
		public event System.EventHandler ResetLayout;
		#endregion

		#region Plugins
		public Image GetImage(SimPe.Interfaces.IWrapper wrapper)
		{
			if (uids.Contains(wrapper.WrapperDescription.UID)) 
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png"));

			if (wrapper.Priority>=0) 
				return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.enabled.png"));
			
			return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.disabled.png"));
		}

		public void  SetPanel(SimPe.Interfaces.IWrapper wrapper, TD.Eyefinder.HeaderControl pn)
		{
			

			if (wrapper.Priority<0) 
			{
				pn.Text = "("+wrapper.WrapperDescription.Name+")";
				pn.ForeColor = SystemColors.ControlDarkDark;
			}
			else 
			{
				pn.Text = wrapper.WrapperDescription.Name;
				pn.ForeColor = SystemColors.ControlText;
			}
			pn.Text = "     "+pn.Text;

		}

		public Image GetShrinkImage(TD.Eyefinder.HeaderControl pn) 
		{			
			if (pn.Height==pn.DisplayRectangle.Top+1) 
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


		System.Collections.ArrayList uids ;
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

			if (wrapper.Priority>=0) wrapper.Priority = index+1;
			else wrapper.Priority = -1 * (index+1);
		

			
			const int imgwidth = 22;
			int top = 4 + index * (height + 4);
			TD.Eyefinder.HeaderControl pn = new TD.Eyefinder.HeaderControl();
			pn.Parent = cnt;
			pn.Top = top;
			pn.Left = 4;
			pn.Width = cnt.Width - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth - 2 - 2*pn.Left;
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
			
			
			PictureBox ipb = new PictureBox();
			ipb.Parent = pn;
			ipb.Left = 2;
			ipb.Top = 1;
			ipb.BackColor = Color.Transparent;
			ipb.SizeMode = PictureBoxSizeMode.StretchImage;
			if (wrapper.WrapperDescription.Icon!=null) 
			{
				ipb.Height = Math.Min(wrapper.WrapperDescription.Icon.Height, pn.DisplayRectangle.Top-2);
				ipb.Width = Math.Min(wrapper.WrapperDescription.Icon.Width, pn.DisplayRectangle.Top-2);			
				ipb.Image = wrapper.WrapperDescription.Icon;
			} 
			else 
			{
				ipb.Height = 16;
				ipb.Width = 16;			
//				ipb.Image = FileTable.WrapperRegistry.WrapperImageList.Images[1];
			}
			

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
			lb.Left = lbauthor.Right+4;
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
			lbversion.Left = lb.Right+16;
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
			lb.Left = lbversion.Right+4;
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
			lb.Left = lbfile.Right+4;
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
			lb.Left = lbui.Right+4;
			lb.AutoSize = true;
			lb.Text = "0x"+Helper.HexString(wrapper.WrapperDescription.UID);
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
			tb.Left = lbdesc.Right+4;
			tb.Width = pn.Width - lb.Left - imgwidth - 12;
			tb.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
			tb.Text = wrapper.WrapperDescription.Description;
#if DEBUG
			tb.Text +=Helper.lbr+wrapper.GetType().FullName + " " + wrapper.GetType().Assembly.FullName;
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
				pb.Left = pn.Width - 2*pb.Width - 16;
				pb.Top = pn.DisplayRectangle.Top + 4; //pn.DisplayRectangle.Top + 4 + pb.Height + 4; //pn.Height - 2*pb.Height -16;
				pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
				pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.multienabled.png"));				
				pb.Click += new EventHandler(pn_Click);
				this.toolTip1.SetToolTip(pb, "Allows Multiple instance");

				
				pb = new PictureBox();
				pb.Parent = pn;
				pb.Width = pn.DisplayRectangle.Top+1;
				pb.Height = pn.DisplayRectangle.Top;	
				pb.SizeMode = PictureBoxSizeMode.CenterImage;
				pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
				pb.Left = pn.Width - 3*pb.Width - pb.Top;
				pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
				pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.smallmultienabled.png"));
				pb.BackColor = Color.Transparent;

				this.toolTip1.SetToolTip(pb, "Allows Multiple instance.");				
			}	
		
			if (wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper) 
			{
				pb = new PictureBox();
				pb.Parent = pn;
				pb.Width = pn.DisplayRectangle.Top+1;
				pb.Height = pn.DisplayRectangle.Top;	
				pb.SizeMode = PictureBoxSizeMode.CenterImage;
				pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
				if (wrapper.AllowMultipleInstances) pb.Left = pn.Width - 4*pb.Width - pb.Top;
				else pb.Left = pn.Width - 3*pb.Width - pb.Top;
				pb.Anchor = AnchorStyles.Top | AnchorStyles.Right;
				pb.Image = System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.error.png")).GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);;
				pb.BackColor = Color.Transparent;
				this.toolTip1.SetToolTip(pb, "This wrapper caused an Error while loading.");
			}

			PictureBox pbe = new PictureBox();
			pbe.Parent = pn;
			pbe.Width = pn.DisplayRectangle.Top+1;
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
			pb.Width = pn.DisplayRectangle.Top+1;
			pb.Height = pn.DisplayRectangle.Top;	
			pb.SizeMode = PictureBoxSizeMode.CenterImage;
			pb.Top = (pn.DisplayRectangle.Top + 1 - pb.Height) / 2;
			pb.Left = pn.Width - 2*pb.Width - pb.Top;
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
			if (icon!=null) f.Icon = icon;
			SimPe.Interfaces.IWrapper[] wrappers = FileTable.WrapperRegistry.AllWrappers;
					
			for (int ct=wrappers.Length-1; ct>=0; ct--) 
			{
				SimPe.Interfaces.IWrapper wrapper = wrappers[ct];
				f.cnt.Controls.Add(f.BuildPanel(wrapper, tm, ct));
			}
				
			f.uids.Clear();
			if (f.cnt.Controls.Count>0) f.cnt.Controls[0].Focus();
			
			f.Execute();

			foreach (SimPe.Interfaces.IWrapper wrapper in wrappers) 
			{
				if (! (wrapper is SimPe.PackedFiles.Wrapper.ErrorWrapper))
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

			btpup.Enabled = wrappers[0]!=pn;
			btpdown.Enabled = wrappers[wrappers.Count-1]!=pn;

			lastpn = pn;
			if (pn.Controls.Count>9) pn.Controls[9].BackColor = pn.BackColor;
		}

		private void pn_LostFocus(object sender, EventArgs e)
		{			
			TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)sender;			
			pn.BackColor = SystemColors.ControlLight;
			pn.Font = new Font(pn.Font.Name, pn.Font.Size, FontStyle.Regular, pn.Font.Unit);
			if (pn.Controls.Count>9) pn.Controls[9].BackColor = pn.BackColor;
		}

		private void pb_Click(object sender, EventArgs e)
		{
			PictureBox pb = (PictureBox)sender;
			TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;
			SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;

			wrapper.Priority *= -1;
			SetPanel(wrapper, pn);

			Image i = this.GetImage(wrapper);

			SetBackgroundColor(pn.Controls[pn.Controls.Count-2], i, true);
			SetBackgroundColor(pn.Controls[pn.Controls.Count-3], i, false);
		}

		int FindPanelIndex(TD.Eyefinder.HeaderControl pn)
		{
			for (int i=0; i<wrappers.Count; i++)
			{
				if (wrappers[i]==pn) return i;
			}

			return -1;
		}

		void Exchange(int index, int o) 
		{			
			TD.Eyefinder.HeaderControl pn1 = (TD.Eyefinder.HeaderControl)wrappers[index];
			TD.Eyefinder.HeaderControl pn2 = (TD.Eyefinder.HeaderControl)wrappers[index+o];

			int d = pn1.Top;
			pn1.Top = pn2.Top;
			pn2.Top = d;		
			SimPe.Interfaces.IWrapper w1 = (SimPe.Interfaces.IWrapper)pn1.Tag;
			SimPe.Interfaces.IWrapper w2 = (SimPe.Interfaces.IWrapper)pn2.Tag;

			int p1 = w1.Priority;
			int p2 = w2.Priority;

			if (p1>=0) w1.Priority = Math.Abs(p2);
			else w1.Priority = -1 * Math.Abs(p2);

			if (p2>=0) w2.Priority = Math.Abs(p1);
			else w2.Priority = -1 * Math.Abs(p1);

			wrappers[index] = pn2;
			wrappers[index+o] = pn1;
			
			cnt.Controls.SetChildIndex(pn1, index+o);
		}

		private void btpup_Click(object sender, System.EventArgs e)
		{
			if (lastpn==null) return;

			int index = FindPanelIndex(lastpn);
			if (index<1) return;

			Exchange(index, -1);
			
			lastpn.Focus();
		}

		private void btpdown_Click(object sender, System.EventArgs e)
		{
			if (lastpn==null) return;

			int index = FindPanelIndex(lastpn);
			if (index<0) return;
			if (index>=wrappers.Count-1) return;

			Exchange(index, 1);

			lastpn.Focus();
		}
		
		void SetBackgroundColor(object sender, Image i, bool small)
		{
			PictureBox pb = (PictureBox)sender;
			if (small)	pb.Image = i.GetThumbnailImage(16, 16, new Image.GetThumbnailImageAbort(ThumbnailCallback), IntPtr.Zero);
			else pb.Image = i;
			/*if (wrapper.Priority<0) pb.BackColor = Color.FromArgb(0x70FF5B60);
			else pb.BackColor = Color.FromArgb(0x7087D300);*/
		}

		private void pb_ExpandClick(object sender, EventArgs e)
		{
			PictureBox pb = (PictureBox)sender;
			TD.Eyefinder.HeaderControl pn = (TD.Eyefinder.HeaderControl)pb.Tag;

			if (pn.Height==pn.DisplayRectangle.Top+1) 
			{
				pn.Controls[pn.Controls.Count-1].Visible = true;
				pn.Height = height;
			}
			else 
			{
				pn.Controls[pn.Controls.Count-1].Visible = false;
				pn.Height = pn.DisplayRectangle.Top+1;
			}


			pb.Image = GetShrinkImage(pn);
			SimPe.Interfaces.IWrapper wrapper = (SimPe.Interfaces.IWrapper)pn.Tag;
			//SetBackgroundColor(pb, wrapper);
		}
		

		private void tb_GotFocus(object sender, EventArgs e)
		{
			if (lastpn!=null) 
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
	}
}
