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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MyPackedFileForm.
	/// </summary>
	public class BhavForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel wrapperPanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btcommit;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox tbformat;
		internal System.Windows.Forms.TextBox tbtype;
		internal System.Windows.Forms.TextBox tbargc;
		internal System.Windows.Forms.TextBox tbflags;
		internal System.Windows.Forms.TextBox tblocals;
		internal System.Windows.Forms.TextBox tbzero;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		internal System.Windows.Forms.TextBox tbopcode;
		internal System.Windows.Forms.TextBox tbres;
		internal System.Windows.Forms.TextBox tbo0;
		internal System.Windows.Forms.TextBox tbo1;
		internal System.Windows.Forms.TextBox tbo2;
		internal System.Windows.Forms.TextBox tbo3;
		internal System.Windows.Forms.TextBox tbo7;
		internal System.Windows.Forms.TextBox tbo6;
		internal System.Windows.Forms.TextBox tbo5;
		internal System.Windows.Forms.TextBox tbo4;
		internal System.Windows.Forms.TextBox tbu7;
		internal System.Windows.Forms.TextBox tbu6;
		internal System.Windows.Forms.TextBox tbu5;
		internal System.Windows.Forms.TextBox tbu4;
		internal System.Windows.Forms.TextBox tbu3;
		internal System.Windows.Forms.TextBox tbu2;
		internal System.Windows.Forms.TextBox tbu1;
		internal System.Windows.Forms.TextBox tbu0;
		internal System.Windows.Forms.LinkLabel llcommit;
		private System.Windows.Forms.GroupBox gbopcodes;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		internal System.Windows.Forms.TextBox tbconstflag;
		internal System.Windows.Forms.ListBox constants;
		internal System.Windows.Forms.Panel bconPanel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.LinkLabel llcadd;
		internal System.Windows.Forms.LinkLabel llccommit;
		internal System.Windows.Forms.TextBox tbvalue;
		private System.Windows.Forms.Label label18;
		internal System.Windows.Forms.Panel pnflowcontainer;
		internal System.Windows.Forms.LinkLabel lldel;
		private System.Windows.Forms.ComboBox tba1;
		private System.Windows.Forms.ComboBox tba2;
		private System.Windows.Forms.PictureBox pnflow1;
		private System.Windows.Forms.PictureBox pnflow2;
		internal System.Windows.Forms.LinkLabel llopenbhav;
		internal System.Windows.Forms.Panel ObjfPanel;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.ListBox lbobjf;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label lbobjffile;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label15;
		internal System.Windows.Forms.LinkLabel llchangeobjf;
		internal System.Windows.Forms.TextBox tbguard;
		private System.Windows.Forms.Button btcommitobjf;
		internal System.Windows.Forms.TextBox tbaction;
		private System.Windows.Forms.Label lbname;
		internal System.Windows.Forms.TextBox lbbhav;
		private System.Windows.Forms.Label label16;
		internal System.Windows.Forms.Panel TtabPanel;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label label23;
		internal System.Windows.Forms.ListBox lbttab;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel5;
		internal System.Windows.Forms.Label lbttabfile;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		internal System.Windows.Forms.LinkLabel llchangettab;
		internal System.Windows.Forms.TextBox tbttabaction;
		internal System.Windows.Forms.TextBox tbttabguard;
		internal System.Windows.Forms.TextBox tbinst2;
		private System.Windows.Forms.Label label20;
		internal System.Windows.Forms.TextBox tbinst1;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.GroupBox gbttab;
		internal System.Windows.Forms.TextBox tbres6;
		private System.Windows.Forms.Label label29;
		internal System.Windows.Forms.TextBox tbres5;
		private System.Windows.Forms.Label label30;
		internal System.Windows.Forms.TextBox tbres2;
		private System.Windows.Forms.Label label31;
		internal System.Windows.Forms.TextBox tbres1;
		private System.Windows.Forms.Label label32;
		internal System.Windows.Forms.TextBox tbres8;
		private System.Windows.Forms.Label label33;
		internal System.Windows.Forms.TextBox tbres7;
		private System.Windows.Forms.Label label34;
		internal System.Windows.Forms.TextBox tbres4;
		private System.Windows.Forms.Label label35;
		internal System.Windows.Forms.TextBox tbres3;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.ComboBox cbgroups;
		private System.Windows.Forms.ListBox lblist;
		internal System.Windows.Forms.TextBox tblisttype;
		private System.Windows.Forms.Label label37;
		internal System.Windows.Forms.TextBox tbdelta;
		private System.Windows.Forms.Label label38;
		internal System.Windows.Forms.TextBox tbmin;
		private System.Windows.Forms.Label label39;
		internal System.Windows.Forms.LinkLabel lllistchange;
		internal System.Windows.Forms.TextBox tbpie;
		private System.Windows.Forms.Label label40;
		internal System.Windows.Forms.TextBox tbver;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbvisitor;
		private System.Windows.Forms.CheckBox cbjoinable;
		private System.Windows.Forms.CheckBox cbimmediately;
		private System.Windows.Forms.CheckBox cbconsecutive;
		private System.Windows.Forms.CheckBox cbchildren;
		private System.Windows.Forms.CheckBox cbdemochild;
		private System.Windows.Forms.CheckBox cbteens;
		private System.Windows.Forms.CheckBox cbelders;
		private System.Windows.Forms.CheckBox cbtodlers;
		private System.Windows.Forms.CheckBox cbautofirst;
		private System.Windows.Forms.CheckBox cbdebugmenu;
		private System.Windows.Forms.CheckBox cbadults;
		private System.Windows.Forms.CheckBox cbunk2;
		private System.Windows.Forms.CheckBox cbunk1;
		private System.Windows.Forms.CheckBox cbunk3;
		private System.Windows.Forms.CheckBox cbunk4;
		private System.Windows.Forms.ContextMenu cmcopy;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		internal System.Windows.Forms.Panel pnGlob;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel6;
		internal System.Windows.Forms.Label lbglobfile;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label42;
		internal System.Windows.Forms.ComboBox cbseminame;
		private System.Windows.Forms.Label label43;
		internal System.Windows.Forms.TextBox tbgroup;
		private System.Windows.Forms.Label lbguard;
		private System.Windows.Forms.Label lbaction;
		private System.Windows.Forms.Button button4;
		internal System.Windows.Forms.LinkLabel llsort;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button btobjaction;
		private System.Windows.Forms.Button btobjguard;
		internal System.Windows.Forms.LinkLabel lldelttab;
		internal System.Windows.Forms.LinkLabel llcdel;
		internal System.Windows.Forms.Button btwiz;
		internal System.Windows.Forms.TextBox tbdec;
		private System.Windows.Forms.Label label44;
		internal System.Windows.Forms.TextBox lbcon;
		private System.Windows.Forms.TextBox lbtext;
		internal System.Windows.Forms.LinkLabel llmove;
		private System.Windows.Forms.Label label45;
		internal System.Windows.Forms.TextBox tbmv;
		private System.ComponentModel.IContainer components;

		public BhavForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			FlipPanel();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BhavForm));
			this.wrapperPanel = new System.Windows.Forms.Panel();
			this.llsort = new System.Windows.Forms.LinkLabel();
			this.label16 = new System.Windows.Forms.Label();
			this.lbbhav = new System.Windows.Forms.TextBox();
			this.pnflowcontainer = new System.Windows.Forms.Panel();
			this.pnflow1 = new System.Windows.Forms.PictureBox();
			this.pnflow2 = new System.Windows.Forms.PictureBox();
			this.gbopcodes = new System.Windows.Forms.GroupBox();
			this.label45 = new System.Windows.Forms.Label();
			this.llmove = new System.Windows.Forms.LinkLabel();
			this.tbmv = new System.Windows.Forms.TextBox();
			this.btwiz = new System.Windows.Forms.Button();
			this.llopenbhav = new System.Windows.Forms.LinkLabel();
			this.tba2 = new System.Windows.Forms.ComboBox();
			this.tba1 = new System.Windows.Forms.ComboBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.llcommit = new System.Windows.Forms.LinkLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.tbu7 = new System.Windows.Forms.TextBox();
			this.tbu6 = new System.Windows.Forms.TextBox();
			this.tbu5 = new System.Windows.Forms.TextBox();
			this.tbu4 = new System.Windows.Forms.TextBox();
			this.tbu3 = new System.Windows.Forms.TextBox();
			this.tbu2 = new System.Windows.Forms.TextBox();
			this.tbu1 = new System.Windows.Forms.TextBox();
			this.tbu0 = new System.Windows.Forms.TextBox();
			this.tbo7 = new System.Windows.Forms.TextBox();
			this.tbo6 = new System.Windows.Forms.TextBox();
			this.tbo5 = new System.Windows.Forms.TextBox();
			this.tbo4 = new System.Windows.Forms.TextBox();
			this.tbo3 = new System.Windows.Forms.TextBox();
			this.tbo2 = new System.Windows.Forms.TextBox();
			this.tbo1 = new System.Windows.Forms.TextBox();
			this.tbo0 = new System.Windows.Forms.TextBox();
			this.tbres = new System.Windows.Forms.TextBox();
			this.tbopcode = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.lbtext = new System.Windows.Forms.TextBox();
			this.tbzero = new System.Windows.Forms.TextBox();
			this.tblocals = new System.Windows.Forms.TextBox();
			this.tbflags = new System.Windows.Forms.TextBox();
			this.tbargc = new System.Windows.Forms.TextBox();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.tbformat = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btcommit = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.bconPanel = new System.Windows.Forms.Panel();
			this.label44 = new System.Windows.Forms.Label();
			this.lbcon = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbdec = new System.Windows.Forms.TextBox();
			this.llcdel = new System.Windows.Forms.LinkLabel();
			this.llcadd = new System.Windows.Forms.LinkLabel();
			this.llccommit = new System.Windows.Forms.LinkLabel();
			this.tbvalue = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.tbconstflag = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.constants = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.ObjfPanel = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btobjaction = new System.Windows.Forms.Button();
			this.btobjguard = new System.Windows.Forms.Button();
			this.lbname = new System.Windows.Forms.Label();
			this.tbaction = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.llchangeobjf = new System.Windows.Forms.LinkLabel();
			this.tbguard = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.lbobjf = new System.Windows.Forms.ListBox();
			this.btcommitobjf = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbobjffile = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.TtabPanel = new System.Windows.Forms.Panel();
			this.lbttab = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lbttabfile = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.gbttab = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lllistchange = new System.Windows.Forms.LinkLabel();
			this.tblisttype = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.tbdelta = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.tbmin = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.lblist = new System.Windows.Forms.ListBox();
			this.cbgroups = new System.Windows.Forms.ComboBox();
			this.lldelttab = new System.Windows.Forms.LinkLabel();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.lbaction = new System.Windows.Forms.Label();
			this.lbguard = new System.Windows.Forms.Label();
			this.tbver = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.tbpie = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.tbres8 = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.tbres7 = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.tbres4 = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.tbres3 = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.tbres6 = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.tbres5 = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.tbres2 = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.tbres1 = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.tbinst2 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tbinst1 = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.tbttabaction = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.llchangettab = new System.Windows.Forms.LinkLabel();
			this.tbttabguard = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbunk3 = new System.Windows.Forms.CheckBox();
			this.cbunk4 = new System.Windows.Forms.CheckBox();
			this.cbunk1 = new System.Windows.Forms.CheckBox();
			this.cbunk2 = new System.Windows.Forms.CheckBox();
			this.cbteens = new System.Windows.Forms.CheckBox();
			this.cbelders = new System.Windows.Forms.CheckBox();
			this.cbtodlers = new System.Windows.Forms.CheckBox();
			this.cbautofirst = new System.Windows.Forms.CheckBox();
			this.cbdebugmenu = new System.Windows.Forms.CheckBox();
			this.cbadults = new System.Windows.Forms.CheckBox();
			this.cbdemochild = new System.Windows.Forms.CheckBox();
			this.cbchildren = new System.Windows.Forms.CheckBox();
			this.cbconsecutive = new System.Windows.Forms.CheckBox();
			this.cbimmediately = new System.Windows.Forms.CheckBox();
			this.cbjoinable = new System.Windows.Forms.CheckBox();
			this.cbvisitor = new System.Windows.Forms.CheckBox();
			this.cmcopy = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.pnGlob = new System.Windows.Forms.Panel();
			this.tbgroup = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.cbseminame = new System.Windows.Forms.ComboBox();
			this.label42 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lbglobfile = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.wrapperPanel.SuspendLayout();
			this.pnflowcontainer.SuspendLayout();
			this.gbopcodes.SuspendLayout();
			this.panel3.SuspendLayout();
			this.bconPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.ObjfPanel.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.TtabPanel.SuspendLayout();
			this.panel5.SuspendLayout();
			this.gbttab.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.pnGlob.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// wrapperPanel
			// 
			this.wrapperPanel.AccessibleDescription = resources.GetString("wrapperPanel.AccessibleDescription");
			this.wrapperPanel.AccessibleName = resources.GetString("wrapperPanel.AccessibleName");
			this.wrapperPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("wrapperPanel.Anchor")));
			this.wrapperPanel.AutoScroll = ((bool)(resources.GetObject("wrapperPanel.AutoScroll")));
			this.wrapperPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.AutoScrollMargin")));
			this.wrapperPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.AutoScrollMinSize")));
			this.wrapperPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wrapperPanel.BackgroundImage")));
			this.wrapperPanel.Controls.Add(this.llsort);
			this.wrapperPanel.Controls.Add(this.label16);
			this.wrapperPanel.Controls.Add(this.lbbhav);
			this.wrapperPanel.Controls.Add(this.pnflowcontainer);
			this.wrapperPanel.Controls.Add(this.gbopcodes);
			this.wrapperPanel.Controls.Add(this.tbzero);
			this.wrapperPanel.Controls.Add(this.tblocals);
			this.wrapperPanel.Controls.Add(this.tbflags);
			this.wrapperPanel.Controls.Add(this.tbargc);
			this.wrapperPanel.Controls.Add(this.tbtype);
			this.wrapperPanel.Controls.Add(this.tbformat);
			this.wrapperPanel.Controls.Add(this.label7);
			this.wrapperPanel.Controls.Add(this.label6);
			this.wrapperPanel.Controls.Add(this.label5);
			this.wrapperPanel.Controls.Add(this.label4);
			this.wrapperPanel.Controls.Add(this.label3);
			this.wrapperPanel.Controls.Add(this.label2);
			this.wrapperPanel.Controls.Add(this.btcommit);
			this.wrapperPanel.Controls.Add(this.panel3);
			this.wrapperPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("wrapperPanel.Dock")));
			this.wrapperPanel.Enabled = ((bool)(resources.GetObject("wrapperPanel.Enabled")));
			this.wrapperPanel.Font = ((System.Drawing.Font)(resources.GetObject("wrapperPanel.Font")));
			this.wrapperPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("wrapperPanel.ImeMode")));
			this.wrapperPanel.Location = ((System.Drawing.Point)(resources.GetObject("wrapperPanel.Location")));
			this.wrapperPanel.Name = "wrapperPanel";
			this.wrapperPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("wrapperPanel.RightToLeft")));
			this.wrapperPanel.Size = ((System.Drawing.Size)(resources.GetObject("wrapperPanel.Size")));
			this.wrapperPanel.TabIndex = ((int)(resources.GetObject("wrapperPanel.TabIndex")));
			this.wrapperPanel.Text = resources.GetString("wrapperPanel.Text");
			this.wrapperPanel.Visible = ((bool)(resources.GetObject("wrapperPanel.Visible")));
			// 
			// llsort
			// 
			this.llsort.AccessibleDescription = resources.GetString("llsort.AccessibleDescription");
			this.llsort.AccessibleName = resources.GetString("llsort.AccessibleName");
			this.llsort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsort.Anchor")));
			this.llsort.AutoSize = ((bool)(resources.GetObject("llsort.AutoSize")));
			this.llsort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsort.Dock")));
			this.llsort.Enabled = ((bool)(resources.GetObject("llsort.Enabled")));
			this.llsort.Font = ((System.Drawing.Font)(resources.GetObject("llsort.Font")));
			this.llsort.Image = ((System.Drawing.Image)(resources.GetObject("llsort.Image")));
			this.llsort.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsort.ImageAlign")));
			this.llsort.ImageIndex = ((int)(resources.GetObject("llsort.ImageIndex")));
			this.llsort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsort.ImeMode")));
			this.llsort.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llsort.LinkArea")));
			this.llsort.Location = ((System.Drawing.Point)(resources.GetObject("llsort.Location")));
			this.llsort.Name = "llsort";
			this.llsort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsort.RightToLeft")));
			this.llsort.Size = ((System.Drawing.Size)(resources.GetObject("llsort.Size")));
			this.llsort.TabIndex = ((int)(resources.GetObject("llsort.TabIndex")));
			this.llsort.TabStop = true;
			this.llsort.Text = resources.GetString("llsort.Text");
			this.llsort.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsort.TextAlign")));
			this.llsort.Visible = ((bool)(resources.GetObject("llsort.Visible")));
			this.llsort.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SortInstructions);
			// 
			// label16
			// 
			this.label16.AccessibleDescription = resources.GetString("label16.AccessibleDescription");
			this.label16.AccessibleName = resources.GetString("label16.AccessibleName");
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label16.Anchor")));
			this.label16.AutoSize = ((bool)(resources.GetObject("label16.AutoSize")));
			this.label16.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label16.Dock")));
			this.label16.Enabled = ((bool)(resources.GetObject("label16.Enabled")));
			this.label16.Font = ((System.Drawing.Font)(resources.GetObject("label16.Font")));
			this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
			this.label16.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.ImageAlign")));
			this.label16.ImageIndex = ((int)(resources.GetObject("label16.ImageIndex")));
			this.label16.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label16.ImeMode")));
			this.label16.Location = ((System.Drawing.Point)(resources.GetObject("label16.Location")));
			this.label16.Name = "label16";
			this.label16.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label16.RightToLeft")));
			this.label16.Size = ((System.Drawing.Size)(resources.GetObject("label16.Size")));
			this.label16.TabIndex = ((int)(resources.GetObject("label16.TabIndex")));
			this.label16.Text = resources.GetString("label16.Text");
			this.label16.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.TextAlign")));
			this.label16.Visible = ((bool)(resources.GetObject("label16.Visible")));
			// 
			// lbbhav
			// 
			this.lbbhav.AccessibleDescription = resources.GetString("lbbhav.AccessibleDescription");
			this.lbbhav.AccessibleName = resources.GetString("lbbhav.AccessibleName");
			this.lbbhav.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbbhav.Anchor")));
			this.lbbhav.AutoSize = ((bool)(resources.GetObject("lbbhav.AutoSize")));
			this.lbbhav.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbbhav.BackgroundImage")));
			this.lbbhav.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbbhav.Dock")));
			this.lbbhav.Enabled = ((bool)(resources.GetObject("lbbhav.Enabled")));
			this.lbbhav.Font = ((System.Drawing.Font)(resources.GetObject("lbbhav.Font")));
			this.lbbhav.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbbhav.ImeMode")));
			this.lbbhav.Location = ((System.Drawing.Point)(resources.GetObject("lbbhav.Location")));
			this.lbbhav.MaxLength = ((int)(resources.GetObject("lbbhav.MaxLength")));
			this.lbbhav.Multiline = ((bool)(resources.GetObject("lbbhav.Multiline")));
			this.lbbhav.Name = "lbbhav";
			this.lbbhav.PasswordChar = ((char)(resources.GetObject("lbbhav.PasswordChar")));
			this.lbbhav.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbbhav.RightToLeft")));
			this.lbbhav.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("lbbhav.ScrollBars")));
			this.lbbhav.Size = ((System.Drawing.Size)(resources.GetObject("lbbhav.Size")));
			this.lbbhav.TabIndex = ((int)(resources.GetObject("lbbhav.TabIndex")));
			this.lbbhav.Text = resources.GetString("lbbhav.Text");
			this.lbbhav.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("lbbhav.TextAlign")));
			this.lbbhav.Visible = ((bool)(resources.GetObject("lbbhav.Visible")));
			this.lbbhav.WordWrap = ((bool)(resources.GetObject("lbbhav.WordWrap")));
			this.lbbhav.TextChanged += new System.EventHandler(this.AutoChangeBhav);
			// 
			// pnflowcontainer
			// 
			this.pnflowcontainer.AccessibleDescription = resources.GetString("pnflowcontainer.AccessibleDescription");
			this.pnflowcontainer.AccessibleName = resources.GetString("pnflowcontainer.AccessibleName");
			this.pnflowcontainer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnflowcontainer.Anchor")));
			this.pnflowcontainer.AutoScroll = ((bool)(resources.GetObject("pnflowcontainer.AutoScroll")));
			this.pnflowcontainer.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnflowcontainer.AutoScrollMargin")));
			this.pnflowcontainer.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnflowcontainer.AutoScrollMinSize")));
			this.pnflowcontainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnflowcontainer.BackgroundImage")));
			this.pnflowcontainer.Controls.Add(this.pnflow1);
			this.pnflowcontainer.Controls.Add(this.pnflow2);
			this.pnflowcontainer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnflowcontainer.Dock")));
			this.pnflowcontainer.Enabled = ((bool)(resources.GetObject("pnflowcontainer.Enabled")));
			this.pnflowcontainer.Font = ((System.Drawing.Font)(resources.GetObject("pnflowcontainer.Font")));
			this.pnflowcontainer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnflowcontainer.ImeMode")));
			this.pnflowcontainer.Location = ((System.Drawing.Point)(resources.GetObject("pnflowcontainer.Location")));
			this.pnflowcontainer.Name = "pnflowcontainer";
			this.pnflowcontainer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnflowcontainer.RightToLeft")));
			this.pnflowcontainer.Size = ((System.Drawing.Size)(resources.GetObject("pnflowcontainer.Size")));
			this.pnflowcontainer.TabIndex = ((int)(resources.GetObject("pnflowcontainer.TabIndex")));
			this.pnflowcontainer.Text = resources.GetString("pnflowcontainer.Text");
			this.pnflowcontainer.Visible = ((bool)(resources.GetObject("pnflowcontainer.Visible")));
			this.pnflowcontainer.Resize += new System.EventHandler(this.FlowResize);
			// 
			// pnflow1
			// 
			this.pnflow1.AccessibleDescription = resources.GetString("pnflow1.AccessibleDescription");
			this.pnflow1.AccessibleName = resources.GetString("pnflow1.AccessibleName");
			this.pnflow1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnflow1.Anchor")));
			this.pnflow1.BackColor = System.Drawing.SystemColors.Control;
			this.pnflow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnflow1.BackgroundImage")));
			this.pnflow1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnflow1.Dock")));
			this.pnflow1.Enabled = ((bool)(resources.GetObject("pnflow1.Enabled")));
			this.pnflow1.Font = ((System.Drawing.Font)(resources.GetObject("pnflow1.Font")));
			this.pnflow1.Image = ((System.Drawing.Image)(resources.GetObject("pnflow1.Image")));
			this.pnflow1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnflow1.ImeMode")));
			this.pnflow1.Location = ((System.Drawing.Point)(resources.GetObject("pnflow1.Location")));
			this.pnflow1.Name = "pnflow1";
			this.pnflow1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnflow1.RightToLeft")));
			this.pnflow1.Size = ((System.Drawing.Size)(resources.GetObject("pnflow1.Size")));
			this.pnflow1.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pnflow1.SizeMode")));
			this.pnflow1.TabIndex = ((int)(resources.GetObject("pnflow1.TabIndex")));
			this.pnflow1.TabStop = false;
			this.pnflow1.Text = resources.GetString("pnflow1.Text");
			this.pnflow1.Visible = ((bool)(resources.GetObject("pnflow1.Visible")));
			// 
			// pnflow2
			// 
			this.pnflow2.AccessibleDescription = resources.GetString("pnflow2.AccessibleDescription");
			this.pnflow2.AccessibleName = resources.GetString("pnflow2.AccessibleName");
			this.pnflow2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnflow2.Anchor")));
			this.pnflow2.BackColor = System.Drawing.SystemColors.Control;
			this.pnflow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnflow2.BackgroundImage")));
			this.pnflow2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnflow2.Dock")));
			this.pnflow2.Enabled = ((bool)(resources.GetObject("pnflow2.Enabled")));
			this.pnflow2.Font = ((System.Drawing.Font)(resources.GetObject("pnflow2.Font")));
			this.pnflow2.Image = ((System.Drawing.Image)(resources.GetObject("pnflow2.Image")));
			this.pnflow2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnflow2.ImeMode")));
			this.pnflow2.Location = ((System.Drawing.Point)(resources.GetObject("pnflow2.Location")));
			this.pnflow2.Name = "pnflow2";
			this.pnflow2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnflow2.RightToLeft")));
			this.pnflow2.Size = ((System.Drawing.Size)(resources.GetObject("pnflow2.Size")));
			this.pnflow2.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pnflow2.SizeMode")));
			this.pnflow2.TabIndex = ((int)(resources.GetObject("pnflow2.TabIndex")));
			this.pnflow2.TabStop = false;
			this.pnflow2.Text = resources.GetString("pnflow2.Text");
			this.pnflow2.Visible = ((bool)(resources.GetObject("pnflow2.Visible")));
			// 
			// gbopcodes
			// 
			this.gbopcodes.AccessibleDescription = resources.GetString("gbopcodes.AccessibleDescription");
			this.gbopcodes.AccessibleName = resources.GetString("gbopcodes.AccessibleName");
			this.gbopcodes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbopcodes.Anchor")));
			this.gbopcodes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbopcodes.BackgroundImage")));
			this.gbopcodes.Controls.Add(this.label45);
			this.gbopcodes.Controls.Add(this.llmove);
			this.gbopcodes.Controls.Add(this.tbmv);
			this.gbopcodes.Controls.Add(this.btwiz);
			this.gbopcodes.Controls.Add(this.llopenbhav);
			this.gbopcodes.Controls.Add(this.tba2);
			this.gbopcodes.Controls.Add(this.tba1);
			this.gbopcodes.Controls.Add(this.lldel);
			this.gbopcodes.Controls.Add(this.lladd);
			this.gbopcodes.Controls.Add(this.llcommit);
			this.gbopcodes.Controls.Add(this.label14);
			this.gbopcodes.Controls.Add(this.label13);
			this.gbopcodes.Controls.Add(this.tbu7);
			this.gbopcodes.Controls.Add(this.tbu6);
			this.gbopcodes.Controls.Add(this.tbu5);
			this.gbopcodes.Controls.Add(this.tbu4);
			this.gbopcodes.Controls.Add(this.tbu3);
			this.gbopcodes.Controls.Add(this.tbu2);
			this.gbopcodes.Controls.Add(this.tbu1);
			this.gbopcodes.Controls.Add(this.tbu0);
			this.gbopcodes.Controls.Add(this.tbo7);
			this.gbopcodes.Controls.Add(this.tbo6);
			this.gbopcodes.Controls.Add(this.tbo5);
			this.gbopcodes.Controls.Add(this.tbo4);
			this.gbopcodes.Controls.Add(this.tbo3);
			this.gbopcodes.Controls.Add(this.tbo2);
			this.gbopcodes.Controls.Add(this.tbo1);
			this.gbopcodes.Controls.Add(this.tbo0);
			this.gbopcodes.Controls.Add(this.tbres);
			this.gbopcodes.Controls.Add(this.tbopcode);
			this.gbopcodes.Controls.Add(this.label12);
			this.gbopcodes.Controls.Add(this.label11);
			this.gbopcodes.Controls.Add(this.label10);
			this.gbopcodes.Controls.Add(this.label9);
			this.gbopcodes.Controls.Add(this.button4);
			this.gbopcodes.Controls.Add(this.lbtext);
			this.gbopcodes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbopcodes.Dock")));
			this.gbopcodes.Enabled = ((bool)(resources.GetObject("gbopcodes.Enabled")));
			this.gbopcodes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbopcodes.Font = ((System.Drawing.Font)(resources.GetObject("gbopcodes.Font")));
			this.gbopcodes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbopcodes.ImeMode")));
			this.gbopcodes.Location = ((System.Drawing.Point)(resources.GetObject("gbopcodes.Location")));
			this.gbopcodes.Name = "gbopcodes";
			this.gbopcodes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbopcodes.RightToLeft")));
			this.gbopcodes.Size = ((System.Drawing.Size)(resources.GetObject("gbopcodes.Size")));
			this.gbopcodes.TabIndex = ((int)(resources.GetObject("gbopcodes.TabIndex")));
			this.gbopcodes.TabStop = false;
			this.gbopcodes.Text = resources.GetString("gbopcodes.Text");
			this.gbopcodes.Visible = ((bool)(resources.GetObject("gbopcodes.Visible")));
			// 
			// label45
			// 
			this.label45.AccessibleDescription = resources.GetString("label45.AccessibleDescription");
			this.label45.AccessibleName = resources.GetString("label45.AccessibleName");
			this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label45.Anchor")));
			this.label45.AutoSize = ((bool)(resources.GetObject("label45.AutoSize")));
			this.label45.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label45.Dock")));
			this.label45.Enabled = ((bool)(resources.GetObject("label45.Enabled")));
			this.label45.Font = ((System.Drawing.Font)(resources.GetObject("label45.Font")));
			this.label45.Image = ((System.Drawing.Image)(resources.GetObject("label45.Image")));
			this.label45.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label45.ImageAlign")));
			this.label45.ImageIndex = ((int)(resources.GetObject("label45.ImageIndex")));
			this.label45.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label45.ImeMode")));
			this.label45.Location = ((System.Drawing.Point)(resources.GetObject("label45.Location")));
			this.label45.Name = "label45";
			this.label45.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label45.RightToLeft")));
			this.label45.Size = ((System.Drawing.Size)(resources.GetObject("label45.Size")));
			this.label45.TabIndex = ((int)(resources.GetObject("label45.TabIndex")));
			this.label45.Text = resources.GetString("label45.Text");
			this.label45.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label45.TextAlign")));
			this.label45.Visible = ((bool)(resources.GetObject("label45.Visible")));
			// 
			// llmove
			// 
			this.llmove.AccessibleDescription = resources.GetString("llmove.AccessibleDescription");
			this.llmove.AccessibleName = resources.GetString("llmove.AccessibleName");
			this.llmove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llmove.Anchor")));
			this.llmove.AutoSize = ((bool)(resources.GetObject("llmove.AutoSize")));
			this.llmove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llmove.Dock")));
			this.llmove.Enabled = ((bool)(resources.GetObject("llmove.Enabled")));
			this.llmove.Font = ((System.Drawing.Font)(resources.GetObject("llmove.Font")));
			this.llmove.Image = ((System.Drawing.Image)(resources.GetObject("llmove.Image")));
			this.llmove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmove.ImageAlign")));
			this.llmove.ImageIndex = ((int)(resources.GetObject("llmove.ImageIndex")));
			this.llmove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llmove.ImeMode")));
			this.llmove.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llmove.LinkArea")));
			this.llmove.Location = ((System.Drawing.Point)(resources.GetObject("llmove.Location")));
			this.llmove.Name = "llmove";
			this.llmove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llmove.RightToLeft")));
			this.llmove.Size = ((System.Drawing.Size)(resources.GetObject("llmove.Size")));
			this.llmove.TabIndex = ((int)(resources.GetObject("llmove.TabIndex")));
			this.llmove.TabStop = true;
			this.llmove.Text = resources.GetString("llmove.Text");
			this.llmove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmove.TextAlign")));
			this.llmove.Visible = ((bool)(resources.GetObject("llmove.Visible")));
			this.llmove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llmove_LinkClicked);
			// 
			// tbmv
			// 
			this.tbmv.AccessibleDescription = resources.GetString("tbmv.AccessibleDescription");
			this.tbmv.AccessibleName = resources.GetString("tbmv.AccessibleName");
			this.tbmv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmv.Anchor")));
			this.tbmv.AutoSize = ((bool)(resources.GetObject("tbmv.AutoSize")));
			this.tbmv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmv.BackgroundImage")));
			this.tbmv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmv.Dock")));
			this.tbmv.Enabled = ((bool)(resources.GetObject("tbmv.Enabled")));
			this.tbmv.Font = ((System.Drawing.Font)(resources.GetObject("tbmv.Font")));
			this.tbmv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmv.ImeMode")));
			this.tbmv.Location = ((System.Drawing.Point)(resources.GetObject("tbmv.Location")));
			this.tbmv.MaxLength = ((int)(resources.GetObject("tbmv.MaxLength")));
			this.tbmv.Multiline = ((bool)(resources.GetObject("tbmv.Multiline")));
			this.tbmv.Name = "tbmv";
			this.tbmv.PasswordChar = ((char)(resources.GetObject("tbmv.PasswordChar")));
			this.tbmv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmv.RightToLeft")));
			this.tbmv.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmv.ScrollBars")));
			this.tbmv.Size = ((System.Drawing.Size)(resources.GetObject("tbmv.Size")));
			this.tbmv.TabIndex = ((int)(resources.GetObject("tbmv.TabIndex")));
			this.tbmv.Text = resources.GetString("tbmv.Text");
			this.tbmv.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmv.TextAlign")));
			this.tbmv.Visible = ((bool)(resources.GetObject("tbmv.Visible")));
			this.tbmv.WordWrap = ((bool)(resources.GetObject("tbmv.WordWrap")));
			this.tbmv.TextChanged += new System.EventHandler(this.tbmv_TextChanged);
			// 
			// btwiz
			// 
			this.btwiz.AccessibleDescription = resources.GetString("btwiz.AccessibleDescription");
			this.btwiz.AccessibleName = resources.GetString("btwiz.AccessibleName");
			this.btwiz.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btwiz.Anchor")));
			this.btwiz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btwiz.BackgroundImage")));
			this.btwiz.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btwiz.Dock")));
			this.btwiz.Enabled = ((bool)(resources.GetObject("btwiz.Enabled")));
			this.btwiz.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btwiz.FlatStyle")));
			this.btwiz.Font = ((System.Drawing.Font)(resources.GetObject("btwiz.Font")));
			this.btwiz.Image = ((System.Drawing.Image)(resources.GetObject("btwiz.Image")));
			this.btwiz.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btwiz.ImageAlign")));
			this.btwiz.ImageIndex = ((int)(resources.GetObject("btwiz.ImageIndex")));
			this.btwiz.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btwiz.ImeMode")));
			this.btwiz.Location = ((System.Drawing.Point)(resources.GetObject("btwiz.Location")));
			this.btwiz.Name = "btwiz";
			this.btwiz.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btwiz.RightToLeft")));
			this.btwiz.Size = ((System.Drawing.Size)(resources.GetObject("btwiz.Size")));
			this.btwiz.TabIndex = ((int)(resources.GetObject("btwiz.TabIndex")));
			this.btwiz.Text = resources.GetString("btwiz.Text");
			this.btwiz.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btwiz.TextAlign")));
			this.btwiz.Visible = ((bool)(resources.GetObject("btwiz.Visible")));
			this.btwiz.Click += new System.EventHandler(this.OpenOperandWiz);
			// 
			// llopenbhav
			// 
			this.llopenbhav.AccessibleDescription = resources.GetString("llopenbhav.AccessibleDescription");
			this.llopenbhav.AccessibleName = resources.GetString("llopenbhav.AccessibleName");
			this.llopenbhav.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llopenbhav.Anchor")));
			this.llopenbhav.AutoSize = ((bool)(resources.GetObject("llopenbhav.AutoSize")));
			this.llopenbhav.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llopenbhav.Dock")));
			this.llopenbhav.Enabled = ((bool)(resources.GetObject("llopenbhav.Enabled")));
			this.llopenbhav.Font = ((System.Drawing.Font)(resources.GetObject("llopenbhav.Font")));
			this.llopenbhav.Image = ((System.Drawing.Image)(resources.GetObject("llopenbhav.Image")));
			this.llopenbhav.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llopenbhav.ImageAlign")));
			this.llopenbhav.ImageIndex = ((int)(resources.GetObject("llopenbhav.ImageIndex")));
			this.llopenbhav.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llopenbhav.ImeMode")));
			this.llopenbhav.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llopenbhav.LinkArea")));
			this.llopenbhav.Location = ((System.Drawing.Point)(resources.GetObject("llopenbhav.Location")));
			this.llopenbhav.Name = "llopenbhav";
			this.llopenbhav.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llopenbhav.RightToLeft")));
			this.llopenbhav.Size = ((System.Drawing.Size)(resources.GetObject("llopenbhav.Size")));
			this.llopenbhav.TabIndex = ((int)(resources.GetObject("llopenbhav.TabIndex")));
			this.llopenbhav.TabStop = true;
			this.llopenbhav.Text = resources.GetString("llopenbhav.Text");
			this.llopenbhav.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llopenbhav.TextAlign")));
			this.llopenbhav.Visible = ((bool)(resources.GetObject("llopenbhav.Visible")));
			this.llopenbhav.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenBhavClicked);
			// 
			// tba2
			// 
			this.tba2.AccessibleDescription = resources.GetString("tba2.AccessibleDescription");
			this.tba2.AccessibleName = resources.GetString("tba2.AccessibleName");
			this.tba2.AllowDrop = true;
			this.tba2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tba2.Anchor")));
			this.tba2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tba2.BackgroundImage")));
			this.tba2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tba2.Dock")));
			this.tba2.Enabled = ((bool)(resources.GetObject("tba2.Enabled")));
			this.tba2.Font = ((System.Drawing.Font)(resources.GetObject("tba2.Font")));
			this.tba2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tba2.ImeMode")));
			this.tba2.IntegralHeight = ((bool)(resources.GetObject("tba2.IntegralHeight")));
			this.tba2.ItemHeight = ((int)(resources.GetObject("tba2.ItemHeight")));
			this.tba2.Items.AddRange(new object[] {
													  resources.GetString("tba2.Items"),
													  resources.GetString("tba2.Items1"),
													  resources.GetString("tba2.Items2")});
			this.tba2.Location = ((System.Drawing.Point)(resources.GetObject("tba2.Location")));
			this.tba2.MaxDropDownItems = ((int)(resources.GetObject("tba2.MaxDropDownItems")));
			this.tba2.MaxLength = ((int)(resources.GetObject("tba2.MaxLength")));
			this.tba2.Name = "tba2";
			this.tba2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tba2.RightToLeft")));
			this.tba2.Size = ((System.Drawing.Size)(resources.GetObject("tba2.Size")));
			this.tba2.TabIndex = ((int)(resources.GetObject("tba2.TabIndex")));
			this.tba2.Text = resources.GetString("tba2.Text");
			this.tba2.Visible = ((bool)(resources.GetObject("tba2.Visible")));
			this.tba2.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemDrop);
			this.tba2.TextChanged += new System.EventHandler(this.AutoChangePoiningInst);
			this.tba2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemDragEnter);
			// 
			// tba1
			// 
			this.tba1.AccessibleDescription = resources.GetString("tba1.AccessibleDescription");
			this.tba1.AccessibleName = resources.GetString("tba1.AccessibleName");
			this.tba1.AllowDrop = true;
			this.tba1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tba1.Anchor")));
			this.tba1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tba1.BackgroundImage")));
			this.tba1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tba1.Dock")));
			this.tba1.Enabled = ((bool)(resources.GetObject("tba1.Enabled")));
			this.tba1.Font = ((System.Drawing.Font)(resources.GetObject("tba1.Font")));
			this.tba1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tba1.ImeMode")));
			this.tba1.IntegralHeight = ((bool)(resources.GetObject("tba1.IntegralHeight")));
			this.tba1.ItemHeight = ((int)(resources.GetObject("tba1.ItemHeight")));
			this.tba1.Items.AddRange(new object[] {
													  resources.GetString("tba1.Items"),
													  resources.GetString("tba1.Items1"),
													  resources.GetString("tba1.Items2")});
			this.tba1.Location = ((System.Drawing.Point)(resources.GetObject("tba1.Location")));
			this.tba1.MaxDropDownItems = ((int)(resources.GetObject("tba1.MaxDropDownItems")));
			this.tba1.MaxLength = ((int)(resources.GetObject("tba1.MaxLength")));
			this.tba1.Name = "tba1";
			this.tba1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tba1.RightToLeft")));
			this.tba1.Size = ((System.Drawing.Size)(resources.GetObject("tba1.Size")));
			this.tba1.TabIndex = ((int)(resources.GetObject("tba1.TabIndex")));
			this.tba1.Text = resources.GetString("tba1.Text");
			this.tba1.Visible = ((bool)(resources.GetObject("tba1.Visible")));
			this.tba1.DragOver += new System.Windows.Forms.DragEventHandler(this.ItemDragEnter);
			this.tba1.DragDrop += new System.Windows.Forms.DragEventHandler(this.ItemDrop);
			this.tba1.TextChanged += new System.EventHandler(this.AutoChangePoiningInst);
			this.tba1.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(this.ItemQueryContinueDragTarget);
			this.tba1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ItemDragEnter);
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
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteOpcodeClicked);
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
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddOpcodeClicked);
			// 
			// llcommit
			// 
			this.llcommit.AccessibleDescription = resources.GetString("llcommit.AccessibleDescription");
			this.llcommit.AccessibleName = resources.GetString("llcommit.AccessibleName");
			this.llcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommit.Anchor")));
			this.llcommit.AutoSize = ((bool)(resources.GetObject("llcommit.AutoSize")));
			this.llcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommit.Dock")));
			this.llcommit.Enabled = ((bool)(resources.GetObject("llcommit.Enabled")));
			this.llcommit.Font = ((System.Drawing.Font)(resources.GetObject("llcommit.Font")));
			this.llcommit.Image = ((System.Drawing.Image)(resources.GetObject("llcommit.Image")));
			this.llcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.ImageAlign")));
			this.llcommit.ImageIndex = ((int)(resources.GetObject("llcommit.ImageIndex")));
			this.llcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommit.ImeMode")));
			this.llcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommit.LinkArea")));
			this.llcommit.Location = ((System.Drawing.Point)(resources.GetObject("llcommit.Location")));
			this.llcommit.Name = "llcommit";
			this.llcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommit.RightToLeft")));
			this.llcommit.Size = ((System.Drawing.Size)(resources.GetObject("llcommit.Size")));
			this.llcommit.TabIndex = ((int)(resources.GetObject("llcommit.TabIndex")));
			this.llcommit.TabStop = true;
			this.llcommit.Text = resources.GetString("llcommit.Text");
			this.llcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.TextAlign")));
			this.llcommit.Visible = ((bool)(resources.GetObject("llcommit.Visible")));
			this.llcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitOpcodeClicked);
			// 
			// label14
			// 
			this.label14.AccessibleDescription = resources.GetString("label14.AccessibleDescription");
			this.label14.AccessibleName = resources.GetString("label14.AccessibleName");
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label14.Anchor")));
			this.label14.AutoSize = ((bool)(resources.GetObject("label14.AutoSize")));
			this.label14.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label14.Dock")));
			this.label14.Enabled = ((bool)(resources.GetObject("label14.Enabled")));
			this.label14.Font = ((System.Drawing.Font)(resources.GetObject("label14.Font")));
			this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
			this.label14.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.ImageAlign")));
			this.label14.ImageIndex = ((int)(resources.GetObject("label14.ImageIndex")));
			this.label14.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label14.ImeMode")));
			this.label14.Location = ((System.Drawing.Point)(resources.GetObject("label14.Location")));
			this.label14.Name = "label14";
			this.label14.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label14.RightToLeft")));
			this.label14.Size = ((System.Drawing.Size)(resources.GetObject("label14.Size")));
			this.label14.TabIndex = ((int)(resources.GetObject("label14.TabIndex")));
			this.label14.Text = resources.GetString("label14.Text");
			this.label14.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.TextAlign")));
			this.label14.Visible = ((bool)(resources.GetObject("label14.Visible")));
			// 
			// label13
			// 
			this.label13.AccessibleDescription = resources.GetString("label13.AccessibleDescription");
			this.label13.AccessibleName = resources.GetString("label13.AccessibleName");
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label13.Anchor")));
			this.label13.AutoSize = ((bool)(resources.GetObject("label13.AutoSize")));
			this.label13.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label13.Dock")));
			this.label13.Enabled = ((bool)(resources.GetObject("label13.Enabled")));
			this.label13.Font = ((System.Drawing.Font)(resources.GetObject("label13.Font")));
			this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
			this.label13.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label13.ImageAlign")));
			this.label13.ImageIndex = ((int)(resources.GetObject("label13.ImageIndex")));
			this.label13.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label13.ImeMode")));
			this.label13.Location = ((System.Drawing.Point)(resources.GetObject("label13.Location")));
			this.label13.Name = "label13";
			this.label13.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label13.RightToLeft")));
			this.label13.Size = ((System.Drawing.Size)(resources.GetObject("label13.Size")));
			this.label13.TabIndex = ((int)(resources.GetObject("label13.TabIndex")));
			this.label13.Text = resources.GetString("label13.Text");
			this.label13.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label13.TextAlign")));
			this.label13.Visible = ((bool)(resources.GetObject("label13.Visible")));
			// 
			// tbu7
			// 
			this.tbu7.AccessibleDescription = resources.GetString("tbu7.AccessibleDescription");
			this.tbu7.AccessibleName = resources.GetString("tbu7.AccessibleName");
			this.tbu7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu7.Anchor")));
			this.tbu7.AutoSize = ((bool)(resources.GetObject("tbu7.AutoSize")));
			this.tbu7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu7.BackgroundImage")));
			this.tbu7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu7.Dock")));
			this.tbu7.Enabled = ((bool)(resources.GetObject("tbu7.Enabled")));
			this.tbu7.Font = ((System.Drawing.Font)(resources.GetObject("tbu7.Font")));
			this.tbu7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu7.ImeMode")));
			this.tbu7.Location = ((System.Drawing.Point)(resources.GetObject("tbu7.Location")));
			this.tbu7.MaxLength = ((int)(resources.GetObject("tbu7.MaxLength")));
			this.tbu7.Multiline = ((bool)(resources.GetObject("tbu7.Multiline")));
			this.tbu7.Name = "tbu7";
			this.tbu7.PasswordChar = ((char)(resources.GetObject("tbu7.PasswordChar")));
			this.tbu7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu7.RightToLeft")));
			this.tbu7.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu7.ScrollBars")));
			this.tbu7.Size = ((System.Drawing.Size)(resources.GetObject("tbu7.Size")));
			this.tbu7.TabIndex = ((int)(resources.GetObject("tbu7.TabIndex")));
			this.tbu7.Text = resources.GetString("tbu7.Text");
			this.tbu7.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu7.TextAlign")));
			this.tbu7.Visible = ((bool)(resources.GetObject("tbu7.Visible")));
			this.tbu7.WordWrap = ((bool)(resources.GetObject("tbu7.WordWrap")));
			this.tbu7.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu6
			// 
			this.tbu6.AccessibleDescription = resources.GetString("tbu6.AccessibleDescription");
			this.tbu6.AccessibleName = resources.GetString("tbu6.AccessibleName");
			this.tbu6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu6.Anchor")));
			this.tbu6.AutoSize = ((bool)(resources.GetObject("tbu6.AutoSize")));
			this.tbu6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu6.BackgroundImage")));
			this.tbu6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu6.Dock")));
			this.tbu6.Enabled = ((bool)(resources.GetObject("tbu6.Enabled")));
			this.tbu6.Font = ((System.Drawing.Font)(resources.GetObject("tbu6.Font")));
			this.tbu6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu6.ImeMode")));
			this.tbu6.Location = ((System.Drawing.Point)(resources.GetObject("tbu6.Location")));
			this.tbu6.MaxLength = ((int)(resources.GetObject("tbu6.MaxLength")));
			this.tbu6.Multiline = ((bool)(resources.GetObject("tbu6.Multiline")));
			this.tbu6.Name = "tbu6";
			this.tbu6.PasswordChar = ((char)(resources.GetObject("tbu6.PasswordChar")));
			this.tbu6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu6.RightToLeft")));
			this.tbu6.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu6.ScrollBars")));
			this.tbu6.Size = ((System.Drawing.Size)(resources.GetObject("tbu6.Size")));
			this.tbu6.TabIndex = ((int)(resources.GetObject("tbu6.TabIndex")));
			this.tbu6.Text = resources.GetString("tbu6.Text");
			this.tbu6.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu6.TextAlign")));
			this.tbu6.Visible = ((bool)(resources.GetObject("tbu6.Visible")));
			this.tbu6.WordWrap = ((bool)(resources.GetObject("tbu6.WordWrap")));
			this.tbu6.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu5
			// 
			this.tbu5.AccessibleDescription = resources.GetString("tbu5.AccessibleDescription");
			this.tbu5.AccessibleName = resources.GetString("tbu5.AccessibleName");
			this.tbu5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu5.Anchor")));
			this.tbu5.AutoSize = ((bool)(resources.GetObject("tbu5.AutoSize")));
			this.tbu5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu5.BackgroundImage")));
			this.tbu5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu5.Dock")));
			this.tbu5.Enabled = ((bool)(resources.GetObject("tbu5.Enabled")));
			this.tbu5.Font = ((System.Drawing.Font)(resources.GetObject("tbu5.Font")));
			this.tbu5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu5.ImeMode")));
			this.tbu5.Location = ((System.Drawing.Point)(resources.GetObject("tbu5.Location")));
			this.tbu5.MaxLength = ((int)(resources.GetObject("tbu5.MaxLength")));
			this.tbu5.Multiline = ((bool)(resources.GetObject("tbu5.Multiline")));
			this.tbu5.Name = "tbu5";
			this.tbu5.PasswordChar = ((char)(resources.GetObject("tbu5.PasswordChar")));
			this.tbu5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu5.RightToLeft")));
			this.tbu5.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu5.ScrollBars")));
			this.tbu5.Size = ((System.Drawing.Size)(resources.GetObject("tbu5.Size")));
			this.tbu5.TabIndex = ((int)(resources.GetObject("tbu5.TabIndex")));
			this.tbu5.Text = resources.GetString("tbu5.Text");
			this.tbu5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu5.TextAlign")));
			this.tbu5.Visible = ((bool)(resources.GetObject("tbu5.Visible")));
			this.tbu5.WordWrap = ((bool)(resources.GetObject("tbu5.WordWrap")));
			this.tbu5.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu4
			// 
			this.tbu4.AccessibleDescription = resources.GetString("tbu4.AccessibleDescription");
			this.tbu4.AccessibleName = resources.GetString("tbu4.AccessibleName");
			this.tbu4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu4.Anchor")));
			this.tbu4.AutoSize = ((bool)(resources.GetObject("tbu4.AutoSize")));
			this.tbu4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu4.BackgroundImage")));
			this.tbu4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu4.Dock")));
			this.tbu4.Enabled = ((bool)(resources.GetObject("tbu4.Enabled")));
			this.tbu4.Font = ((System.Drawing.Font)(resources.GetObject("tbu4.Font")));
			this.tbu4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu4.ImeMode")));
			this.tbu4.Location = ((System.Drawing.Point)(resources.GetObject("tbu4.Location")));
			this.tbu4.MaxLength = ((int)(resources.GetObject("tbu4.MaxLength")));
			this.tbu4.Multiline = ((bool)(resources.GetObject("tbu4.Multiline")));
			this.tbu4.Name = "tbu4";
			this.tbu4.PasswordChar = ((char)(resources.GetObject("tbu4.PasswordChar")));
			this.tbu4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu4.RightToLeft")));
			this.tbu4.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu4.ScrollBars")));
			this.tbu4.Size = ((System.Drawing.Size)(resources.GetObject("tbu4.Size")));
			this.tbu4.TabIndex = ((int)(resources.GetObject("tbu4.TabIndex")));
			this.tbu4.Text = resources.GetString("tbu4.Text");
			this.tbu4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu4.TextAlign")));
			this.tbu4.Visible = ((bool)(resources.GetObject("tbu4.Visible")));
			this.tbu4.WordWrap = ((bool)(resources.GetObject("tbu4.WordWrap")));
			this.tbu4.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu3
			// 
			this.tbu3.AccessibleDescription = resources.GetString("tbu3.AccessibleDescription");
			this.tbu3.AccessibleName = resources.GetString("tbu3.AccessibleName");
			this.tbu3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu3.Anchor")));
			this.tbu3.AutoSize = ((bool)(resources.GetObject("tbu3.AutoSize")));
			this.tbu3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu3.BackgroundImage")));
			this.tbu3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu3.Dock")));
			this.tbu3.Enabled = ((bool)(resources.GetObject("tbu3.Enabled")));
			this.tbu3.Font = ((System.Drawing.Font)(resources.GetObject("tbu3.Font")));
			this.tbu3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu3.ImeMode")));
			this.tbu3.Location = ((System.Drawing.Point)(resources.GetObject("tbu3.Location")));
			this.tbu3.MaxLength = ((int)(resources.GetObject("tbu3.MaxLength")));
			this.tbu3.Multiline = ((bool)(resources.GetObject("tbu3.Multiline")));
			this.tbu3.Name = "tbu3";
			this.tbu3.PasswordChar = ((char)(resources.GetObject("tbu3.PasswordChar")));
			this.tbu3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu3.RightToLeft")));
			this.tbu3.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu3.ScrollBars")));
			this.tbu3.Size = ((System.Drawing.Size)(resources.GetObject("tbu3.Size")));
			this.tbu3.TabIndex = ((int)(resources.GetObject("tbu3.TabIndex")));
			this.tbu3.Text = resources.GetString("tbu3.Text");
			this.tbu3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu3.TextAlign")));
			this.tbu3.Visible = ((bool)(resources.GetObject("tbu3.Visible")));
			this.tbu3.WordWrap = ((bool)(resources.GetObject("tbu3.WordWrap")));
			this.tbu3.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu2
			// 
			this.tbu2.AccessibleDescription = resources.GetString("tbu2.AccessibleDescription");
			this.tbu2.AccessibleName = resources.GetString("tbu2.AccessibleName");
			this.tbu2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu2.Anchor")));
			this.tbu2.AutoSize = ((bool)(resources.GetObject("tbu2.AutoSize")));
			this.tbu2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu2.BackgroundImage")));
			this.tbu2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu2.Dock")));
			this.tbu2.Enabled = ((bool)(resources.GetObject("tbu2.Enabled")));
			this.tbu2.Font = ((System.Drawing.Font)(resources.GetObject("tbu2.Font")));
			this.tbu2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu2.ImeMode")));
			this.tbu2.Location = ((System.Drawing.Point)(resources.GetObject("tbu2.Location")));
			this.tbu2.MaxLength = ((int)(resources.GetObject("tbu2.MaxLength")));
			this.tbu2.Multiline = ((bool)(resources.GetObject("tbu2.Multiline")));
			this.tbu2.Name = "tbu2";
			this.tbu2.PasswordChar = ((char)(resources.GetObject("tbu2.PasswordChar")));
			this.tbu2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu2.RightToLeft")));
			this.tbu2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu2.ScrollBars")));
			this.tbu2.Size = ((System.Drawing.Size)(resources.GetObject("tbu2.Size")));
			this.tbu2.TabIndex = ((int)(resources.GetObject("tbu2.TabIndex")));
			this.tbu2.Text = resources.GetString("tbu2.Text");
			this.tbu2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu2.TextAlign")));
			this.tbu2.Visible = ((bool)(resources.GetObject("tbu2.Visible")));
			this.tbu2.WordWrap = ((bool)(resources.GetObject("tbu2.WordWrap")));
			this.tbu2.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu1
			// 
			this.tbu1.AccessibleDescription = resources.GetString("tbu1.AccessibleDescription");
			this.tbu1.AccessibleName = resources.GetString("tbu1.AccessibleName");
			this.tbu1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu1.Anchor")));
			this.tbu1.AutoSize = ((bool)(resources.GetObject("tbu1.AutoSize")));
			this.tbu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu1.BackgroundImage")));
			this.tbu1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu1.Dock")));
			this.tbu1.Enabled = ((bool)(resources.GetObject("tbu1.Enabled")));
			this.tbu1.Font = ((System.Drawing.Font)(resources.GetObject("tbu1.Font")));
			this.tbu1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu1.ImeMode")));
			this.tbu1.Location = ((System.Drawing.Point)(resources.GetObject("tbu1.Location")));
			this.tbu1.MaxLength = ((int)(resources.GetObject("tbu1.MaxLength")));
			this.tbu1.Multiline = ((bool)(resources.GetObject("tbu1.Multiline")));
			this.tbu1.Name = "tbu1";
			this.tbu1.PasswordChar = ((char)(resources.GetObject("tbu1.PasswordChar")));
			this.tbu1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu1.RightToLeft")));
			this.tbu1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu1.ScrollBars")));
			this.tbu1.Size = ((System.Drawing.Size)(resources.GetObject("tbu1.Size")));
			this.tbu1.TabIndex = ((int)(resources.GetObject("tbu1.TabIndex")));
			this.tbu1.Text = resources.GetString("tbu1.Text");
			this.tbu1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu1.TextAlign")));
			this.tbu1.Visible = ((bool)(resources.GetObject("tbu1.Visible")));
			this.tbu1.WordWrap = ((bool)(resources.GetObject("tbu1.WordWrap")));
			this.tbu1.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbu0
			// 
			this.tbu0.AccessibleDescription = resources.GetString("tbu0.AccessibleDescription");
			this.tbu0.AccessibleName = resources.GetString("tbu0.AccessibleName");
			this.tbu0.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbu0.Anchor")));
			this.tbu0.AutoSize = ((bool)(resources.GetObject("tbu0.AutoSize")));
			this.tbu0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbu0.BackgroundImage")));
			this.tbu0.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbu0.Dock")));
			this.tbu0.Enabled = ((bool)(resources.GetObject("tbu0.Enabled")));
			this.tbu0.Font = ((System.Drawing.Font)(resources.GetObject("tbu0.Font")));
			this.tbu0.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbu0.ImeMode")));
			this.tbu0.Location = ((System.Drawing.Point)(resources.GetObject("tbu0.Location")));
			this.tbu0.MaxLength = ((int)(resources.GetObject("tbu0.MaxLength")));
			this.tbu0.Multiline = ((bool)(resources.GetObject("tbu0.Multiline")));
			this.tbu0.Name = "tbu0";
			this.tbu0.PasswordChar = ((char)(resources.GetObject("tbu0.PasswordChar")));
			this.tbu0.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbu0.RightToLeft")));
			this.tbu0.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbu0.ScrollBars")));
			this.tbu0.Size = ((System.Drawing.Size)(resources.GetObject("tbu0.Size")));
			this.tbu0.TabIndex = ((int)(resources.GetObject("tbu0.TabIndex")));
			this.tbu0.Text = resources.GetString("tbu0.Text");
			this.tbu0.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbu0.TextAlign")));
			this.tbu0.Visible = ((bool)(resources.GetObject("tbu0.Visible")));
			this.tbu0.WordWrap = ((bool)(resources.GetObject("tbu0.WordWrap")));
			this.tbu0.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo7
			// 
			this.tbo7.AccessibleDescription = resources.GetString("tbo7.AccessibleDescription");
			this.tbo7.AccessibleName = resources.GetString("tbo7.AccessibleName");
			this.tbo7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo7.Anchor")));
			this.tbo7.AutoSize = ((bool)(resources.GetObject("tbo7.AutoSize")));
			this.tbo7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo7.BackgroundImage")));
			this.tbo7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo7.Dock")));
			this.tbo7.Enabled = ((bool)(resources.GetObject("tbo7.Enabled")));
			this.tbo7.Font = ((System.Drawing.Font)(resources.GetObject("tbo7.Font")));
			this.tbo7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo7.ImeMode")));
			this.tbo7.Location = ((System.Drawing.Point)(resources.GetObject("tbo7.Location")));
			this.tbo7.MaxLength = ((int)(resources.GetObject("tbo7.MaxLength")));
			this.tbo7.Multiline = ((bool)(resources.GetObject("tbo7.Multiline")));
			this.tbo7.Name = "tbo7";
			this.tbo7.PasswordChar = ((char)(resources.GetObject("tbo7.PasswordChar")));
			this.tbo7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo7.RightToLeft")));
			this.tbo7.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo7.ScrollBars")));
			this.tbo7.Size = ((System.Drawing.Size)(resources.GetObject("tbo7.Size")));
			this.tbo7.TabIndex = ((int)(resources.GetObject("tbo7.TabIndex")));
			this.tbo7.Text = resources.GetString("tbo7.Text");
			this.tbo7.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo7.TextAlign")));
			this.tbo7.Visible = ((bool)(resources.GetObject("tbo7.Visible")));
			this.tbo7.WordWrap = ((bool)(resources.GetObject("tbo7.WordWrap")));
			this.tbo7.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo6
			// 
			this.tbo6.AccessibleDescription = resources.GetString("tbo6.AccessibleDescription");
			this.tbo6.AccessibleName = resources.GetString("tbo6.AccessibleName");
			this.tbo6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo6.Anchor")));
			this.tbo6.AutoSize = ((bool)(resources.GetObject("tbo6.AutoSize")));
			this.tbo6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo6.BackgroundImage")));
			this.tbo6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo6.Dock")));
			this.tbo6.Enabled = ((bool)(resources.GetObject("tbo6.Enabled")));
			this.tbo6.Font = ((System.Drawing.Font)(resources.GetObject("tbo6.Font")));
			this.tbo6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo6.ImeMode")));
			this.tbo6.Location = ((System.Drawing.Point)(resources.GetObject("tbo6.Location")));
			this.tbo6.MaxLength = ((int)(resources.GetObject("tbo6.MaxLength")));
			this.tbo6.Multiline = ((bool)(resources.GetObject("tbo6.Multiline")));
			this.tbo6.Name = "tbo6";
			this.tbo6.PasswordChar = ((char)(resources.GetObject("tbo6.PasswordChar")));
			this.tbo6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo6.RightToLeft")));
			this.tbo6.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo6.ScrollBars")));
			this.tbo6.Size = ((System.Drawing.Size)(resources.GetObject("tbo6.Size")));
			this.tbo6.TabIndex = ((int)(resources.GetObject("tbo6.TabIndex")));
			this.tbo6.Text = resources.GetString("tbo6.Text");
			this.tbo6.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo6.TextAlign")));
			this.tbo6.Visible = ((bool)(resources.GetObject("tbo6.Visible")));
			this.tbo6.WordWrap = ((bool)(resources.GetObject("tbo6.WordWrap")));
			this.tbo6.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo5
			// 
			this.tbo5.AccessibleDescription = resources.GetString("tbo5.AccessibleDescription");
			this.tbo5.AccessibleName = resources.GetString("tbo5.AccessibleName");
			this.tbo5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo5.Anchor")));
			this.tbo5.AutoSize = ((bool)(resources.GetObject("tbo5.AutoSize")));
			this.tbo5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo5.BackgroundImage")));
			this.tbo5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo5.Dock")));
			this.tbo5.Enabled = ((bool)(resources.GetObject("tbo5.Enabled")));
			this.tbo5.Font = ((System.Drawing.Font)(resources.GetObject("tbo5.Font")));
			this.tbo5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo5.ImeMode")));
			this.tbo5.Location = ((System.Drawing.Point)(resources.GetObject("tbo5.Location")));
			this.tbo5.MaxLength = ((int)(resources.GetObject("tbo5.MaxLength")));
			this.tbo5.Multiline = ((bool)(resources.GetObject("tbo5.Multiline")));
			this.tbo5.Name = "tbo5";
			this.tbo5.PasswordChar = ((char)(resources.GetObject("tbo5.PasswordChar")));
			this.tbo5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo5.RightToLeft")));
			this.tbo5.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo5.ScrollBars")));
			this.tbo5.Size = ((System.Drawing.Size)(resources.GetObject("tbo5.Size")));
			this.tbo5.TabIndex = ((int)(resources.GetObject("tbo5.TabIndex")));
			this.tbo5.Text = resources.GetString("tbo5.Text");
			this.tbo5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo5.TextAlign")));
			this.tbo5.Visible = ((bool)(resources.GetObject("tbo5.Visible")));
			this.tbo5.WordWrap = ((bool)(resources.GetObject("tbo5.WordWrap")));
			this.tbo5.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo4
			// 
			this.tbo4.AccessibleDescription = resources.GetString("tbo4.AccessibleDescription");
			this.tbo4.AccessibleName = resources.GetString("tbo4.AccessibleName");
			this.tbo4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo4.Anchor")));
			this.tbo4.AutoSize = ((bool)(resources.GetObject("tbo4.AutoSize")));
			this.tbo4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo4.BackgroundImage")));
			this.tbo4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo4.Dock")));
			this.tbo4.Enabled = ((bool)(resources.GetObject("tbo4.Enabled")));
			this.tbo4.Font = ((System.Drawing.Font)(resources.GetObject("tbo4.Font")));
			this.tbo4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo4.ImeMode")));
			this.tbo4.Location = ((System.Drawing.Point)(resources.GetObject("tbo4.Location")));
			this.tbo4.MaxLength = ((int)(resources.GetObject("tbo4.MaxLength")));
			this.tbo4.Multiline = ((bool)(resources.GetObject("tbo4.Multiline")));
			this.tbo4.Name = "tbo4";
			this.tbo4.PasswordChar = ((char)(resources.GetObject("tbo4.PasswordChar")));
			this.tbo4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo4.RightToLeft")));
			this.tbo4.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo4.ScrollBars")));
			this.tbo4.Size = ((System.Drawing.Size)(resources.GetObject("tbo4.Size")));
			this.tbo4.TabIndex = ((int)(resources.GetObject("tbo4.TabIndex")));
			this.tbo4.Text = resources.GetString("tbo4.Text");
			this.tbo4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo4.TextAlign")));
			this.tbo4.Visible = ((bool)(resources.GetObject("tbo4.Visible")));
			this.tbo4.WordWrap = ((bool)(resources.GetObject("tbo4.WordWrap")));
			this.tbo4.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo3
			// 
			this.tbo3.AccessibleDescription = resources.GetString("tbo3.AccessibleDescription");
			this.tbo3.AccessibleName = resources.GetString("tbo3.AccessibleName");
			this.tbo3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo3.Anchor")));
			this.tbo3.AutoSize = ((bool)(resources.GetObject("tbo3.AutoSize")));
			this.tbo3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo3.BackgroundImage")));
			this.tbo3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo3.Dock")));
			this.tbo3.Enabled = ((bool)(resources.GetObject("tbo3.Enabled")));
			this.tbo3.Font = ((System.Drawing.Font)(resources.GetObject("tbo3.Font")));
			this.tbo3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo3.ImeMode")));
			this.tbo3.Location = ((System.Drawing.Point)(resources.GetObject("tbo3.Location")));
			this.tbo3.MaxLength = ((int)(resources.GetObject("tbo3.MaxLength")));
			this.tbo3.Multiline = ((bool)(resources.GetObject("tbo3.Multiline")));
			this.tbo3.Name = "tbo3";
			this.tbo3.PasswordChar = ((char)(resources.GetObject("tbo3.PasswordChar")));
			this.tbo3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo3.RightToLeft")));
			this.tbo3.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo3.ScrollBars")));
			this.tbo3.Size = ((System.Drawing.Size)(resources.GetObject("tbo3.Size")));
			this.tbo3.TabIndex = ((int)(resources.GetObject("tbo3.TabIndex")));
			this.tbo3.Text = resources.GetString("tbo3.Text");
			this.tbo3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo3.TextAlign")));
			this.tbo3.Visible = ((bool)(resources.GetObject("tbo3.Visible")));
			this.tbo3.WordWrap = ((bool)(resources.GetObject("tbo3.WordWrap")));
			this.tbo3.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo2
			// 
			this.tbo2.AccessibleDescription = resources.GetString("tbo2.AccessibleDescription");
			this.tbo2.AccessibleName = resources.GetString("tbo2.AccessibleName");
			this.tbo2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo2.Anchor")));
			this.tbo2.AutoSize = ((bool)(resources.GetObject("tbo2.AutoSize")));
			this.tbo2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo2.BackgroundImage")));
			this.tbo2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo2.Dock")));
			this.tbo2.Enabled = ((bool)(resources.GetObject("tbo2.Enabled")));
			this.tbo2.Font = ((System.Drawing.Font)(resources.GetObject("tbo2.Font")));
			this.tbo2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo2.ImeMode")));
			this.tbo2.Location = ((System.Drawing.Point)(resources.GetObject("tbo2.Location")));
			this.tbo2.MaxLength = ((int)(resources.GetObject("tbo2.MaxLength")));
			this.tbo2.Multiline = ((bool)(resources.GetObject("tbo2.Multiline")));
			this.tbo2.Name = "tbo2";
			this.tbo2.PasswordChar = ((char)(resources.GetObject("tbo2.PasswordChar")));
			this.tbo2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo2.RightToLeft")));
			this.tbo2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo2.ScrollBars")));
			this.tbo2.Size = ((System.Drawing.Size)(resources.GetObject("tbo2.Size")));
			this.tbo2.TabIndex = ((int)(resources.GetObject("tbo2.TabIndex")));
			this.tbo2.Text = resources.GetString("tbo2.Text");
			this.tbo2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo2.TextAlign")));
			this.tbo2.Visible = ((bool)(resources.GetObject("tbo2.Visible")));
			this.tbo2.WordWrap = ((bool)(resources.GetObject("tbo2.WordWrap")));
			this.tbo2.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo1
			// 
			this.tbo1.AccessibleDescription = resources.GetString("tbo1.AccessibleDescription");
			this.tbo1.AccessibleName = resources.GetString("tbo1.AccessibleName");
			this.tbo1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo1.Anchor")));
			this.tbo1.AutoSize = ((bool)(resources.GetObject("tbo1.AutoSize")));
			this.tbo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo1.BackgroundImage")));
			this.tbo1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo1.Dock")));
			this.tbo1.Enabled = ((bool)(resources.GetObject("tbo1.Enabled")));
			this.tbo1.Font = ((System.Drawing.Font)(resources.GetObject("tbo1.Font")));
			this.tbo1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo1.ImeMode")));
			this.tbo1.Location = ((System.Drawing.Point)(resources.GetObject("tbo1.Location")));
			this.tbo1.MaxLength = ((int)(resources.GetObject("tbo1.MaxLength")));
			this.tbo1.Multiline = ((bool)(resources.GetObject("tbo1.Multiline")));
			this.tbo1.Name = "tbo1";
			this.tbo1.PasswordChar = ((char)(resources.GetObject("tbo1.PasswordChar")));
			this.tbo1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo1.RightToLeft")));
			this.tbo1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo1.ScrollBars")));
			this.tbo1.Size = ((System.Drawing.Size)(resources.GetObject("tbo1.Size")));
			this.tbo1.TabIndex = ((int)(resources.GetObject("tbo1.TabIndex")));
			this.tbo1.Text = resources.GetString("tbo1.Text");
			this.tbo1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo1.TextAlign")));
			this.tbo1.Visible = ((bool)(resources.GetObject("tbo1.Visible")));
			this.tbo1.WordWrap = ((bool)(resources.GetObject("tbo1.WordWrap")));
			this.tbo1.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbo0
			// 
			this.tbo0.AccessibleDescription = resources.GetString("tbo0.AccessibleDescription");
			this.tbo0.AccessibleName = resources.GetString("tbo0.AccessibleName");
			this.tbo0.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbo0.Anchor")));
			this.tbo0.AutoSize = ((bool)(resources.GetObject("tbo0.AutoSize")));
			this.tbo0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbo0.BackgroundImage")));
			this.tbo0.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbo0.Dock")));
			this.tbo0.Enabled = ((bool)(resources.GetObject("tbo0.Enabled")));
			this.tbo0.Font = ((System.Drawing.Font)(resources.GetObject("tbo0.Font")));
			this.tbo0.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbo0.ImeMode")));
			this.tbo0.Location = ((System.Drawing.Point)(resources.GetObject("tbo0.Location")));
			this.tbo0.MaxLength = ((int)(resources.GetObject("tbo0.MaxLength")));
			this.tbo0.Multiline = ((bool)(resources.GetObject("tbo0.Multiline")));
			this.tbo0.Name = "tbo0";
			this.tbo0.PasswordChar = ((char)(resources.GetObject("tbo0.PasswordChar")));
			this.tbo0.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbo0.RightToLeft")));
			this.tbo0.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbo0.ScrollBars")));
			this.tbo0.Size = ((System.Drawing.Size)(resources.GetObject("tbo0.Size")));
			this.tbo0.TabIndex = ((int)(resources.GetObject("tbo0.TabIndex")));
			this.tbo0.Text = resources.GetString("tbo0.Text");
			this.tbo0.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbo0.TextAlign")));
			this.tbo0.Visible = ((bool)(resources.GetObject("tbo0.Visible")));
			this.tbo0.WordWrap = ((bool)(resources.GetObject("tbo0.WordWrap")));
			this.tbo0.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbres
			// 
			this.tbres.AccessibleDescription = resources.GetString("tbres.AccessibleDescription");
			this.tbres.AccessibleName = resources.GetString("tbres.AccessibleName");
			this.tbres.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres.Anchor")));
			this.tbres.AutoSize = ((bool)(resources.GetObject("tbres.AutoSize")));
			this.tbres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres.BackgroundImage")));
			this.tbres.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres.Dock")));
			this.tbres.Enabled = ((bool)(resources.GetObject("tbres.Enabled")));
			this.tbres.Font = ((System.Drawing.Font)(resources.GetObject("tbres.Font")));
			this.tbres.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres.ImeMode")));
			this.tbres.Location = ((System.Drawing.Point)(resources.GetObject("tbres.Location")));
			this.tbres.MaxLength = ((int)(resources.GetObject("tbres.MaxLength")));
			this.tbres.Multiline = ((bool)(resources.GetObject("tbres.Multiline")));
			this.tbres.Name = "tbres";
			this.tbres.PasswordChar = ((char)(resources.GetObject("tbres.PasswordChar")));
			this.tbres.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres.RightToLeft")));
			this.tbres.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres.ScrollBars")));
			this.tbres.Size = ((System.Drawing.Size)(resources.GetObject("tbres.Size")));
			this.tbres.TabIndex = ((int)(resources.GetObject("tbres.TabIndex")));
			this.tbres.Text = resources.GetString("tbres.Text");
			this.tbres.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres.TextAlign")));
			this.tbres.Visible = ((bool)(resources.GetObject("tbres.Visible")));
			this.tbres.WordWrap = ((bool)(resources.GetObject("tbres.WordWrap")));
			this.tbres.TextChanged += new System.EventHandler(this.AutoChangeInst);
			// 
			// tbopcode
			// 
			this.tbopcode.AccessibleDescription = resources.GetString("tbopcode.AccessibleDescription");
			this.tbopcode.AccessibleName = resources.GetString("tbopcode.AccessibleName");
			this.tbopcode.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbopcode.Anchor")));
			this.tbopcode.AutoSize = ((bool)(resources.GetObject("tbopcode.AutoSize")));
			this.tbopcode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbopcode.BackgroundImage")));
			this.tbopcode.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbopcode.Dock")));
			this.tbopcode.Enabled = ((bool)(resources.GetObject("tbopcode.Enabled")));
			this.tbopcode.Font = ((System.Drawing.Font)(resources.GetObject("tbopcode.Font")));
			this.tbopcode.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbopcode.ImeMode")));
			this.tbopcode.Location = ((System.Drawing.Point)(resources.GetObject("tbopcode.Location")));
			this.tbopcode.MaxLength = ((int)(resources.GetObject("tbopcode.MaxLength")));
			this.tbopcode.Multiline = ((bool)(resources.GetObject("tbopcode.Multiline")));
			this.tbopcode.Name = "tbopcode";
			this.tbopcode.PasswordChar = ((char)(resources.GetObject("tbopcode.PasswordChar")));
			this.tbopcode.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbopcode.RightToLeft")));
			this.tbopcode.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbopcode.ScrollBars")));
			this.tbopcode.Size = ((System.Drawing.Size)(resources.GetObject("tbopcode.Size")));
			this.tbopcode.TabIndex = ((int)(resources.GetObject("tbopcode.TabIndex")));
			this.tbopcode.Text = resources.GetString("tbopcode.Text");
			this.tbopcode.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbopcode.TextAlign")));
			this.tbopcode.Visible = ((bool)(resources.GetObject("tbopcode.Visible")));
			this.tbopcode.WordWrap = ((bool)(resources.GetObject("tbopcode.WordWrap")));
			this.tbopcode.TextChanged += new System.EventHandler(this.AutoChangeInst);
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
			this.button4.Visible = ((bool)(resources.GetObject("button4.Visible")));
			this.button4.Click += new System.EventHandler(this.GetOpcode);
			// 
			// lbtext
			// 
			this.lbtext.AccessibleDescription = resources.GetString("lbtext.AccessibleDescription");
			this.lbtext.AccessibleName = resources.GetString("lbtext.AccessibleName");
			this.lbtext.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbtext.Anchor")));
			this.lbtext.AutoSize = ((bool)(resources.GetObject("lbtext.AutoSize")));
			this.lbtext.BackColor = System.Drawing.SystemColors.Control;
			this.lbtext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbtext.BackgroundImage")));
			this.lbtext.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbtext.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbtext.Dock")));
			this.lbtext.Enabled = ((bool)(resources.GetObject("lbtext.Enabled")));
			this.lbtext.Font = ((System.Drawing.Font)(resources.GetObject("lbtext.Font")));
			this.lbtext.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbtext.ImeMode")));
			this.lbtext.Location = ((System.Drawing.Point)(resources.GetObject("lbtext.Location")));
			this.lbtext.MaxLength = ((int)(resources.GetObject("lbtext.MaxLength")));
			this.lbtext.Multiline = ((bool)(resources.GetObject("lbtext.Multiline")));
			this.lbtext.Name = "lbtext";
			this.lbtext.PasswordChar = ((char)(resources.GetObject("lbtext.PasswordChar")));
			this.lbtext.ReadOnly = true;
			this.lbtext.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbtext.RightToLeft")));
			this.lbtext.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("lbtext.ScrollBars")));
			this.lbtext.Size = ((System.Drawing.Size)(resources.GetObject("lbtext.Size")));
			this.lbtext.TabIndex = ((int)(resources.GetObject("lbtext.TabIndex")));
			this.lbtext.Text = resources.GetString("lbtext.Text");
			this.lbtext.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("lbtext.TextAlign")));
			this.lbtext.Visible = ((bool)(resources.GetObject("lbtext.Visible")));
			this.lbtext.WordWrap = ((bool)(resources.GetObject("lbtext.WordWrap")));
			// 
			// tbzero
			// 
			this.tbzero.AccessibleDescription = resources.GetString("tbzero.AccessibleDescription");
			this.tbzero.AccessibleName = resources.GetString("tbzero.AccessibleName");
			this.tbzero.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbzero.Anchor")));
			this.tbzero.AutoSize = ((bool)(resources.GetObject("tbzero.AutoSize")));
			this.tbzero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbzero.BackgroundImage")));
			this.tbzero.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbzero.Dock")));
			this.tbzero.Enabled = ((bool)(resources.GetObject("tbzero.Enabled")));
			this.tbzero.Font = ((System.Drawing.Font)(resources.GetObject("tbzero.Font")));
			this.tbzero.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbzero.ImeMode")));
			this.tbzero.Location = ((System.Drawing.Point)(resources.GetObject("tbzero.Location")));
			this.tbzero.MaxLength = ((int)(resources.GetObject("tbzero.MaxLength")));
			this.tbzero.Multiline = ((bool)(resources.GetObject("tbzero.Multiline")));
			this.tbzero.Name = "tbzero";
			this.tbzero.PasswordChar = ((char)(resources.GetObject("tbzero.PasswordChar")));
			this.tbzero.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbzero.RightToLeft")));
			this.tbzero.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbzero.ScrollBars")));
			this.tbzero.Size = ((System.Drawing.Size)(resources.GetObject("tbzero.Size")));
			this.tbzero.TabIndex = ((int)(resources.GetObject("tbzero.TabIndex")));
			this.tbzero.Text = resources.GetString("tbzero.Text");
			this.tbzero.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbzero.TextAlign")));
			this.tbzero.Visible = ((bool)(resources.GetObject("tbzero.Visible")));
			this.tbzero.WordWrap = ((bool)(resources.GetObject("tbzero.WordWrap")));
			this.tbzero.TextChanged += new System.EventHandler(this.AutoChangeBhav);
			// 
			// tblocals
			// 
			this.tblocals.AccessibleDescription = resources.GetString("tblocals.AccessibleDescription");
			this.tblocals.AccessibleName = resources.GetString("tblocals.AccessibleName");
			this.tblocals.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblocals.Anchor")));
			this.tblocals.AutoSize = ((bool)(resources.GetObject("tblocals.AutoSize")));
			this.tblocals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblocals.BackgroundImage")));
			this.tblocals.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblocals.Dock")));
			this.tblocals.Enabled = ((bool)(resources.GetObject("tblocals.Enabled")));
			this.tblocals.Font = ((System.Drawing.Font)(resources.GetObject("tblocals.Font")));
			this.tblocals.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblocals.ImeMode")));
			this.tblocals.Location = ((System.Drawing.Point)(resources.GetObject("tblocals.Location")));
			this.tblocals.MaxLength = ((int)(resources.GetObject("tblocals.MaxLength")));
			this.tblocals.Multiline = ((bool)(resources.GetObject("tblocals.Multiline")));
			this.tblocals.Name = "tblocals";
			this.tblocals.PasswordChar = ((char)(resources.GetObject("tblocals.PasswordChar")));
			this.tblocals.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblocals.RightToLeft")));
			this.tblocals.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblocals.ScrollBars")));
			this.tblocals.Size = ((System.Drawing.Size)(resources.GetObject("tblocals.Size")));
			this.tblocals.TabIndex = ((int)(resources.GetObject("tblocals.TabIndex")));
			this.tblocals.Text = resources.GetString("tblocals.Text");
			this.tblocals.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblocals.TextAlign")));
			this.tblocals.Visible = ((bool)(resources.GetObject("tblocals.Visible")));
			this.tblocals.WordWrap = ((bool)(resources.GetObject("tblocals.WordWrap")));
			this.tblocals.TextChanged += new System.EventHandler(this.AutoChangeBhav);
			// 
			// tbflags
			// 
			this.tbflags.AccessibleDescription = resources.GetString("tbflags.AccessibleDescription");
			this.tbflags.AccessibleName = resources.GetString("tbflags.AccessibleName");
			this.tbflags.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbflags.Anchor")));
			this.tbflags.AutoSize = ((bool)(resources.GetObject("tbflags.AutoSize")));
			this.tbflags.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbflags.BackgroundImage")));
			this.tbflags.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbflags.Dock")));
			this.tbflags.Enabled = ((bool)(resources.GetObject("tbflags.Enabled")));
			this.tbflags.Font = ((System.Drawing.Font)(resources.GetObject("tbflags.Font")));
			this.tbflags.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbflags.ImeMode")));
			this.tbflags.Location = ((System.Drawing.Point)(resources.GetObject("tbflags.Location")));
			this.tbflags.MaxLength = ((int)(resources.GetObject("tbflags.MaxLength")));
			this.tbflags.Multiline = ((bool)(resources.GetObject("tbflags.Multiline")));
			this.tbflags.Name = "tbflags";
			this.tbflags.PasswordChar = ((char)(resources.GetObject("tbflags.PasswordChar")));
			this.tbflags.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbflags.RightToLeft")));
			this.tbflags.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbflags.ScrollBars")));
			this.tbflags.Size = ((System.Drawing.Size)(resources.GetObject("tbflags.Size")));
			this.tbflags.TabIndex = ((int)(resources.GetObject("tbflags.TabIndex")));
			this.tbflags.Text = resources.GetString("tbflags.Text");
			this.tbflags.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbflags.TextAlign")));
			this.tbflags.Visible = ((bool)(resources.GetObject("tbflags.Visible")));
			this.tbflags.WordWrap = ((bool)(resources.GetObject("tbflags.WordWrap")));
			this.tbflags.TextChanged += new System.EventHandler(this.AutoChangeBhav);
			// 
			// tbargc
			// 
			this.tbargc.AccessibleDescription = resources.GetString("tbargc.AccessibleDescription");
			this.tbargc.AccessibleName = resources.GetString("tbargc.AccessibleName");
			this.tbargc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbargc.Anchor")));
			this.tbargc.AutoSize = ((bool)(resources.GetObject("tbargc.AutoSize")));
			this.tbargc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbargc.BackgroundImage")));
			this.tbargc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbargc.Dock")));
			this.tbargc.Enabled = ((bool)(resources.GetObject("tbargc.Enabled")));
			this.tbargc.Font = ((System.Drawing.Font)(resources.GetObject("tbargc.Font")));
			this.tbargc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbargc.ImeMode")));
			this.tbargc.Location = ((System.Drawing.Point)(resources.GetObject("tbargc.Location")));
			this.tbargc.MaxLength = ((int)(resources.GetObject("tbargc.MaxLength")));
			this.tbargc.Multiline = ((bool)(resources.GetObject("tbargc.Multiline")));
			this.tbargc.Name = "tbargc";
			this.tbargc.PasswordChar = ((char)(resources.GetObject("tbargc.PasswordChar")));
			this.tbargc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbargc.RightToLeft")));
			this.tbargc.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbargc.ScrollBars")));
			this.tbargc.Size = ((System.Drawing.Size)(resources.GetObject("tbargc.Size")));
			this.tbargc.TabIndex = ((int)(resources.GetObject("tbargc.TabIndex")));
			this.tbargc.Text = resources.GetString("tbargc.Text");
			this.tbargc.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbargc.TextAlign")));
			this.tbargc.Visible = ((bool)(resources.GetObject("tbargc.Visible")));
			this.tbargc.WordWrap = ((bool)(resources.GetObject("tbargc.WordWrap")));
			this.tbargc.TextChanged += new System.EventHandler(this.AutoChangeBhav);
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
			this.tbtype.TextChanged += new System.EventHandler(this.AutoChangeBhav);
			// 
			// tbformat
			// 
			this.tbformat.AccessibleDescription = resources.GetString("tbformat.AccessibleDescription");
			this.tbformat.AccessibleName = resources.GetString("tbformat.AccessibleName");
			this.tbformat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbformat.Anchor")));
			this.tbformat.AutoSize = ((bool)(resources.GetObject("tbformat.AutoSize")));
			this.tbformat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbformat.BackgroundImage")));
			this.tbformat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbformat.Dock")));
			this.tbformat.Enabled = ((bool)(resources.GetObject("tbformat.Enabled")));
			this.tbformat.Font = ((System.Drawing.Font)(resources.GetObject("tbformat.Font")));
			this.tbformat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbformat.ImeMode")));
			this.tbformat.Location = ((System.Drawing.Point)(resources.GetObject("tbformat.Location")));
			this.tbformat.MaxLength = ((int)(resources.GetObject("tbformat.MaxLength")));
			this.tbformat.Multiline = ((bool)(resources.GetObject("tbformat.Multiline")));
			this.tbformat.Name = "tbformat";
			this.tbformat.PasswordChar = ((char)(resources.GetObject("tbformat.PasswordChar")));
			this.tbformat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbformat.RightToLeft")));
			this.tbformat.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbformat.ScrollBars")));
			this.tbformat.Size = ((System.Drawing.Size)(resources.GetObject("tbformat.Size")));
			this.tbformat.TabIndex = ((int)(resources.GetObject("tbformat.TabIndex")));
			this.tbformat.Text = resources.GetString("tbformat.Text");
			this.tbformat.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbformat.TextAlign")));
			this.tbformat.Visible = ((bool)(resources.GetObject("tbformat.Visible")));
			this.tbformat.WordWrap = ((bool)(resources.GetObject("tbformat.WordWrap")));
			this.tbformat.TextChanged += new System.EventHandler(this.AutoChangeBhav);
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
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
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
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
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
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
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
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
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
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// btcommit
			// 
			this.btcommit.AccessibleDescription = resources.GetString("btcommit.AccessibleDescription");
			this.btcommit.AccessibleName = resources.GetString("btcommit.AccessibleName");
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btcommit.Anchor")));
			this.btcommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcommit.BackgroundImage")));
			this.btcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btcommit.Dock")));
			this.btcommit.Enabled = ((bool)(resources.GetObject("btcommit.Enabled")));
			this.btcommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btcommit.FlatStyle")));
			this.btcommit.Font = ((System.Drawing.Font)(resources.GetObject("btcommit.Font")));
			this.btcommit.Image = ((System.Drawing.Image)(resources.GetObject("btcommit.Image")));
			this.btcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommit.ImageAlign")));
			this.btcommit.ImageIndex = ((int)(resources.GetObject("btcommit.ImageIndex")));
			this.btcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btcommit.ImeMode")));
			this.btcommit.Location = ((System.Drawing.Point)(resources.GetObject("btcommit.Location")));
			this.btcommit.Name = "btcommit";
			this.btcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btcommit.RightToLeft")));
			this.btcommit.Size = ((System.Drawing.Size)(resources.GetObject("btcommit.Size")));
			this.btcommit.TabIndex = ((int)(resources.GetObject("btcommit.TabIndex")));
			this.btcommit.Text = resources.GetString("btcommit.Text");
			this.btcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommit.TextAlign")));
			this.btcommit.Visible = ((bool)(resources.GetObject("btcommit.Visible")));
			this.btcommit.Click += new System.EventHandler(this.CommitClick);
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
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
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
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// bconPanel
			// 
			this.bconPanel.AccessibleDescription = resources.GetString("bconPanel.AccessibleDescription");
			this.bconPanel.AccessibleName = resources.GetString("bconPanel.AccessibleName");
			this.bconPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bconPanel.Anchor")));
			this.bconPanel.AutoScroll = ((bool)(resources.GetObject("bconPanel.AutoScroll")));
			this.bconPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("bconPanel.AutoScrollMargin")));
			this.bconPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("bconPanel.AutoScrollMinSize")));
			this.bconPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bconPanel.BackgroundImage")));
			this.bconPanel.Controls.Add(this.label44);
			this.bconPanel.Controls.Add(this.lbcon);
			this.bconPanel.Controls.Add(this.groupBox1);
			this.bconPanel.Controls.Add(this.tbconstflag);
			this.bconPanel.Controls.Add(this.label22);
			this.bconPanel.Controls.Add(this.constants);
			this.bconPanel.Controls.Add(this.button1);
			this.bconPanel.Controls.Add(this.panel2);
			this.bconPanel.Controls.Add(this.label28);
			this.bconPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bconPanel.Dock")));
			this.bconPanel.Enabled = ((bool)(resources.GetObject("bconPanel.Enabled")));
			this.bconPanel.Font = ((System.Drawing.Font)(resources.GetObject("bconPanel.Font")));
			this.bconPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bconPanel.ImeMode")));
			this.bconPanel.Location = ((System.Drawing.Point)(resources.GetObject("bconPanel.Location")));
			this.bconPanel.Name = "bconPanel";
			this.bconPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bconPanel.RightToLeft")));
			this.bconPanel.Size = ((System.Drawing.Size)(resources.GetObject("bconPanel.Size")));
			this.bconPanel.TabIndex = ((int)(resources.GetObject("bconPanel.TabIndex")));
			this.bconPanel.Text = resources.GetString("bconPanel.Text");
			this.bconPanel.Visible = ((bool)(resources.GetObject("bconPanel.Visible")));
			// 
			// label44
			// 
			this.label44.AccessibleDescription = resources.GetString("label44.AccessibleDescription");
			this.label44.AccessibleName = resources.GetString("label44.AccessibleName");
			this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label44.Anchor")));
			this.label44.AutoSize = ((bool)(resources.GetObject("label44.AutoSize")));
			this.label44.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label44.Dock")));
			this.label44.Enabled = ((bool)(resources.GetObject("label44.Enabled")));
			this.label44.Font = ((System.Drawing.Font)(resources.GetObject("label44.Font")));
			this.label44.Image = ((System.Drawing.Image)(resources.GetObject("label44.Image")));
			this.label44.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label44.ImageAlign")));
			this.label44.ImageIndex = ((int)(resources.GetObject("label44.ImageIndex")));
			this.label44.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label44.ImeMode")));
			this.label44.Location = ((System.Drawing.Point)(resources.GetObject("label44.Location")));
			this.label44.Name = "label44";
			this.label44.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label44.RightToLeft")));
			this.label44.Size = ((System.Drawing.Size)(resources.GetObject("label44.Size")));
			this.label44.TabIndex = ((int)(resources.GetObject("label44.TabIndex")));
			this.label44.Text = resources.GetString("label44.Text");
			this.label44.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label44.TextAlign")));
			this.label44.Visible = ((bool)(resources.GetObject("label44.Visible")));
			// 
			// lbcon
			// 
			this.lbcon.AccessibleDescription = resources.GetString("lbcon.AccessibleDescription");
			this.lbcon.AccessibleName = resources.GetString("lbcon.AccessibleName");
			this.lbcon.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbcon.Anchor")));
			this.lbcon.AutoSize = ((bool)(resources.GetObject("lbcon.AutoSize")));
			this.lbcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbcon.BackgroundImage")));
			this.lbcon.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbcon.Dock")));
			this.lbcon.Enabled = ((bool)(resources.GetObject("lbcon.Enabled")));
			this.lbcon.Font = ((System.Drawing.Font)(resources.GetObject("lbcon.Font")));
			this.lbcon.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbcon.ImeMode")));
			this.lbcon.Location = ((System.Drawing.Point)(resources.GetObject("lbcon.Location")));
			this.lbcon.MaxLength = ((int)(resources.GetObject("lbcon.MaxLength")));
			this.lbcon.Multiline = ((bool)(resources.GetObject("lbcon.Multiline")));
			this.lbcon.Name = "lbcon";
			this.lbcon.PasswordChar = ((char)(resources.GetObject("lbcon.PasswordChar")));
			this.lbcon.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbcon.RightToLeft")));
			this.lbcon.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("lbcon.ScrollBars")));
			this.lbcon.Size = ((System.Drawing.Size)(resources.GetObject("lbcon.Size")));
			this.lbcon.TabIndex = ((int)(resources.GetObject("lbcon.TabIndex")));
			this.lbcon.Text = resources.GetString("lbcon.Text");
			this.lbcon.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("lbcon.TextAlign")));
			this.lbcon.Visible = ((bool)(resources.GetObject("lbcon.Visible")));
			this.lbcon.WordWrap = ((bool)(resources.GetObject("lbcon.WordWrap")));
			this.lbcon.TextChanged += new System.EventHandler(this.BconFilename);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.tbdec);
			this.groupBox1.Controls.Add(this.llcdel);
			this.groupBox1.Controls.Add(this.llcadd);
			this.groupBox1.Controls.Add(this.llccommit);
			this.groupBox1.Controls.Add(this.tbvalue);
			this.groupBox1.Controls.Add(this.label18);
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
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// tbdec
			// 
			this.tbdec.AccessibleDescription = resources.GetString("tbdec.AccessibleDescription");
			this.tbdec.AccessibleName = resources.GetString("tbdec.AccessibleName");
			this.tbdec.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbdec.Anchor")));
			this.tbdec.AutoSize = ((bool)(resources.GetObject("tbdec.AutoSize")));
			this.tbdec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbdec.BackgroundImage")));
			this.tbdec.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbdec.Dock")));
			this.tbdec.Enabled = ((bool)(resources.GetObject("tbdec.Enabled")));
			this.tbdec.Font = ((System.Drawing.Font)(resources.GetObject("tbdec.Font")));
			this.tbdec.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbdec.ImeMode")));
			this.tbdec.Location = ((System.Drawing.Point)(resources.GetObject("tbdec.Location")));
			this.tbdec.MaxLength = ((int)(resources.GetObject("tbdec.MaxLength")));
			this.tbdec.Multiline = ((bool)(resources.GetObject("tbdec.Multiline")));
			this.tbdec.Name = "tbdec";
			this.tbdec.PasswordChar = ((char)(resources.GetObject("tbdec.PasswordChar")));
			this.tbdec.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbdec.RightToLeft")));
			this.tbdec.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbdec.ScrollBars")));
			this.tbdec.Size = ((System.Drawing.Size)(resources.GetObject("tbdec.Size")));
			this.tbdec.TabIndex = ((int)(resources.GetObject("tbdec.TabIndex")));
			this.tbdec.Text = resources.GetString("tbdec.Text");
			this.tbdec.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbdec.TextAlign")));
			this.tbdec.Visible = ((bool)(resources.GetObject("tbdec.Visible")));
			this.tbdec.WordWrap = ((bool)(resources.GetObject("tbdec.WordWrap")));
			this.tbdec.TextChanged += new System.EventHandler(this.BConDecValueChanged);
			// 
			// llcdel
			// 
			this.llcdel.AccessibleDescription = resources.GetString("llcdel.AccessibleDescription");
			this.llcdel.AccessibleName = resources.GetString("llcdel.AccessibleName");
			this.llcdel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcdel.Anchor")));
			this.llcdel.AutoSize = ((bool)(resources.GetObject("llcdel.AutoSize")));
			this.llcdel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcdel.Dock")));
			this.llcdel.Enabled = ((bool)(resources.GetObject("llcdel.Enabled")));
			this.llcdel.Font = ((System.Drawing.Font)(resources.GetObject("llcdel.Font")));
			this.llcdel.Image = ((System.Drawing.Image)(resources.GetObject("llcdel.Image")));
			this.llcdel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcdel.ImageAlign")));
			this.llcdel.ImageIndex = ((int)(resources.GetObject("llcdel.ImageIndex")));
			this.llcdel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcdel.ImeMode")));
			this.llcdel.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcdel.LinkArea")));
			this.llcdel.Location = ((System.Drawing.Point)(resources.GetObject("llcdel.Location")));
			this.llcdel.Name = "llcdel";
			this.llcdel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcdel.RightToLeft")));
			this.llcdel.Size = ((System.Drawing.Size)(resources.GetObject("llcdel.Size")));
			this.llcdel.TabIndex = ((int)(resources.GetObject("llcdel.TabIndex")));
			this.llcdel.TabStop = true;
			this.llcdel.Text = resources.GetString("llcdel.Text");
			this.llcdel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcdel.TextAlign")));
			this.llcdel.Visible = ((bool)(resources.GetObject("llcdel.Visible")));
			this.llcdel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteConstantClicked);
			// 
			// llcadd
			// 
			this.llcadd.AccessibleDescription = resources.GetString("llcadd.AccessibleDescription");
			this.llcadd.AccessibleName = resources.GetString("llcadd.AccessibleName");
			this.llcadd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcadd.Anchor")));
			this.llcadd.AutoSize = ((bool)(resources.GetObject("llcadd.AutoSize")));
			this.llcadd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcadd.Dock")));
			this.llcadd.Enabled = ((bool)(resources.GetObject("llcadd.Enabled")));
			this.llcadd.Font = ((System.Drawing.Font)(resources.GetObject("llcadd.Font")));
			this.llcadd.Image = ((System.Drawing.Image)(resources.GetObject("llcadd.Image")));
			this.llcadd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcadd.ImageAlign")));
			this.llcadd.ImageIndex = ((int)(resources.GetObject("llcadd.ImageIndex")));
			this.llcadd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcadd.ImeMode")));
			this.llcadd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcadd.LinkArea")));
			this.llcadd.Location = ((System.Drawing.Point)(resources.GetObject("llcadd.Location")));
			this.llcadd.Name = "llcadd";
			this.llcadd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcadd.RightToLeft")));
			this.llcadd.Size = ((System.Drawing.Size)(resources.GetObject("llcadd.Size")));
			this.llcadd.TabIndex = ((int)(resources.GetObject("llcadd.TabIndex")));
			this.llcadd.TabStop = true;
			this.llcadd.Text = resources.GetString("llcadd.Text");
			this.llcadd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcadd.TextAlign")));
			this.llcadd.Visible = ((bool)(resources.GetObject("llcadd.Visible")));
			this.llcadd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddConstantClicked);
			// 
			// llccommit
			// 
			this.llccommit.AccessibleDescription = resources.GetString("llccommit.AccessibleDescription");
			this.llccommit.AccessibleName = resources.GetString("llccommit.AccessibleName");
			this.llccommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llccommit.Anchor")));
			this.llccommit.AutoSize = ((bool)(resources.GetObject("llccommit.AutoSize")));
			this.llccommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llccommit.Dock")));
			this.llccommit.Enabled = ((bool)(resources.GetObject("llccommit.Enabled")));
			this.llccommit.Font = ((System.Drawing.Font)(resources.GetObject("llccommit.Font")));
			this.llccommit.Image = ((System.Drawing.Image)(resources.GetObject("llccommit.Image")));
			this.llccommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llccommit.ImageAlign")));
			this.llccommit.ImageIndex = ((int)(resources.GetObject("llccommit.ImageIndex")));
			this.llccommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llccommit.ImeMode")));
			this.llccommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llccommit.LinkArea")));
			this.llccommit.Location = ((System.Drawing.Point)(resources.GetObject("llccommit.Location")));
			this.llccommit.Name = "llccommit";
			this.llccommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llccommit.RightToLeft")));
			this.llccommit.Size = ((System.Drawing.Size)(resources.GetObject("llccommit.Size")));
			this.llccommit.TabIndex = ((int)(resources.GetObject("llccommit.TabIndex")));
			this.llccommit.TabStop = true;
			this.llccommit.Text = resources.GetString("llccommit.Text");
			this.llccommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llccommit.TextAlign")));
			this.llccommit.Visible = ((bool)(resources.GetObject("llccommit.Visible")));
			this.llccommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitConstantClicked);
			// 
			// tbvalue
			// 
			this.tbvalue.AccessibleDescription = resources.GetString("tbvalue.AccessibleDescription");
			this.tbvalue.AccessibleName = resources.GetString("tbvalue.AccessibleName");
			this.tbvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbvalue.Anchor")));
			this.tbvalue.AutoSize = ((bool)(resources.GetObject("tbvalue.AutoSize")));
			this.tbvalue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbvalue.BackgroundImage")));
			this.tbvalue.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbvalue.Dock")));
			this.tbvalue.Enabled = ((bool)(resources.GetObject("tbvalue.Enabled")));
			this.tbvalue.Font = ((System.Drawing.Font)(resources.GetObject("tbvalue.Font")));
			this.tbvalue.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbvalue.ImeMode")));
			this.tbvalue.Location = ((System.Drawing.Point)(resources.GetObject("tbvalue.Location")));
			this.tbvalue.MaxLength = ((int)(resources.GetObject("tbvalue.MaxLength")));
			this.tbvalue.Multiline = ((bool)(resources.GetObject("tbvalue.Multiline")));
			this.tbvalue.Name = "tbvalue";
			this.tbvalue.PasswordChar = ((char)(resources.GetObject("tbvalue.PasswordChar")));
			this.tbvalue.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbvalue.RightToLeft")));
			this.tbvalue.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbvalue.ScrollBars")));
			this.tbvalue.Size = ((System.Drawing.Size)(resources.GetObject("tbvalue.Size")));
			this.tbvalue.TabIndex = ((int)(resources.GetObject("tbvalue.TabIndex")));
			this.tbvalue.Text = resources.GetString("tbvalue.Text");
			this.tbvalue.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbvalue.TextAlign")));
			this.tbvalue.Visible = ((bool)(resources.GetObject("tbvalue.Visible")));
			this.tbvalue.WordWrap = ((bool)(resources.GetObject("tbvalue.WordWrap")));
			this.tbvalue.TextChanged += new System.EventHandler(this.AutoChangeConst);
			// 
			// label18
			// 
			this.label18.AccessibleDescription = resources.GetString("label18.AccessibleDescription");
			this.label18.AccessibleName = resources.GetString("label18.AccessibleName");
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label18.Anchor")));
			this.label18.AutoSize = ((bool)(resources.GetObject("label18.AutoSize")));
			this.label18.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label18.Dock")));
			this.label18.Enabled = ((bool)(resources.GetObject("label18.Enabled")));
			this.label18.Font = ((System.Drawing.Font)(resources.GetObject("label18.Font")));
			this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
			this.label18.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label18.ImageAlign")));
			this.label18.ImageIndex = ((int)(resources.GetObject("label18.ImageIndex")));
			this.label18.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label18.ImeMode")));
			this.label18.Location = ((System.Drawing.Point)(resources.GetObject("label18.Location")));
			this.label18.Name = "label18";
			this.label18.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label18.RightToLeft")));
			this.label18.Size = ((System.Drawing.Size)(resources.GetObject("label18.Size")));
			this.label18.TabIndex = ((int)(resources.GetObject("label18.TabIndex")));
			this.label18.Text = resources.GetString("label18.Text");
			this.label18.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label18.TextAlign")));
			this.label18.Visible = ((bool)(resources.GetObject("label18.Visible")));
			// 
			// tbconstflag
			// 
			this.tbconstflag.AccessibleDescription = resources.GetString("tbconstflag.AccessibleDescription");
			this.tbconstflag.AccessibleName = resources.GetString("tbconstflag.AccessibleName");
			this.tbconstflag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbconstflag.Anchor")));
			this.tbconstflag.AutoSize = ((bool)(resources.GetObject("tbconstflag.AutoSize")));
			this.tbconstflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbconstflag.BackgroundImage")));
			this.tbconstflag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbconstflag.Dock")));
			this.tbconstflag.Enabled = ((bool)(resources.GetObject("tbconstflag.Enabled")));
			this.tbconstflag.Font = ((System.Drawing.Font)(resources.GetObject("tbconstflag.Font")));
			this.tbconstflag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbconstflag.ImeMode")));
			this.tbconstflag.Location = ((System.Drawing.Point)(resources.GetObject("tbconstflag.Location")));
			this.tbconstflag.MaxLength = ((int)(resources.GetObject("tbconstflag.MaxLength")));
			this.tbconstflag.Multiline = ((bool)(resources.GetObject("tbconstflag.Multiline")));
			this.tbconstflag.Name = "tbconstflag";
			this.tbconstflag.PasswordChar = ((char)(resources.GetObject("tbconstflag.PasswordChar")));
			this.tbconstflag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbconstflag.RightToLeft")));
			this.tbconstflag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbconstflag.ScrollBars")));
			this.tbconstflag.Size = ((System.Drawing.Size)(resources.GetObject("tbconstflag.Size")));
			this.tbconstflag.TabIndex = ((int)(resources.GetObject("tbconstflag.TabIndex")));
			this.tbconstflag.Text = resources.GetString("tbconstflag.Text");
			this.tbconstflag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbconstflag.TextAlign")));
			this.tbconstflag.Visible = ((bool)(resources.GetObject("tbconstflag.Visible")));
			this.tbconstflag.WordWrap = ((bool)(resources.GetObject("tbconstflag.WordWrap")));
			this.tbconstflag.TextChanged += new System.EventHandler(this.BconFilename);
			// 
			// label22
			// 
			this.label22.AccessibleDescription = resources.GetString("label22.AccessibleDescription");
			this.label22.AccessibleName = resources.GetString("label22.AccessibleName");
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label22.Anchor")));
			this.label22.AutoSize = ((bool)(resources.GetObject("label22.AutoSize")));
			this.label22.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label22.Dock")));
			this.label22.Enabled = ((bool)(resources.GetObject("label22.Enabled")));
			this.label22.Font = ((System.Drawing.Font)(resources.GetObject("label22.Font")));
			this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
			this.label22.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label22.ImageAlign")));
			this.label22.ImageIndex = ((int)(resources.GetObject("label22.ImageIndex")));
			this.label22.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label22.ImeMode")));
			this.label22.Location = ((System.Drawing.Point)(resources.GetObject("label22.Location")));
			this.label22.Name = "label22";
			this.label22.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label22.RightToLeft")));
			this.label22.Size = ((System.Drawing.Size)(resources.GetObject("label22.Size")));
			this.label22.TabIndex = ((int)(resources.GetObject("label22.TabIndex")));
			this.label22.Text = resources.GetString("label22.Text");
			this.label22.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label22.TextAlign")));
			this.label22.Visible = ((bool)(resources.GetObject("label22.Visible")));
			// 
			// constants
			// 
			this.constants.AccessibleDescription = resources.GetString("constants.AccessibleDescription");
			this.constants.AccessibleName = resources.GetString("constants.AccessibleName");
			this.constants.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("constants.Anchor")));
			this.constants.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("constants.BackgroundImage")));
			this.constants.ColumnWidth = ((int)(resources.GetObject("constants.ColumnWidth")));
			this.constants.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("constants.Dock")));
			this.constants.Enabled = ((bool)(resources.GetObject("constants.Enabled")));
			this.constants.Font = ((System.Drawing.Font)(resources.GetObject("constants.Font")));
			this.constants.HorizontalExtent = ((int)(resources.GetObject("constants.HorizontalExtent")));
			this.constants.HorizontalScrollbar = ((bool)(resources.GetObject("constants.HorizontalScrollbar")));
			this.constants.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("constants.ImeMode")));
			this.constants.IntegralHeight = ((bool)(resources.GetObject("constants.IntegralHeight")));
			this.constants.ItemHeight = ((int)(resources.GetObject("constants.ItemHeight")));
			this.constants.Location = ((System.Drawing.Point)(resources.GetObject("constants.Location")));
			this.constants.Name = "constants";
			this.constants.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("constants.RightToLeft")));
			this.constants.ScrollAlwaysVisible = ((bool)(resources.GetObject("constants.ScrollAlwaysVisible")));
			this.constants.Size = ((System.Drawing.Size)(resources.GetObject("constants.Size")));
			this.constants.TabIndex = ((int)(resources.GetObject("constants.TabIndex")));
			this.constants.Visible = ((bool)(resources.GetObject("constants.Visible")));
			this.constants.SelectedIndexChanged += new System.EventHandler(this.ConstantCHanged);
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
			this.button1.Click += new System.EventHandler(this.ConstnatCommitClicked);
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
			this.panel2.Controls.Add(this.label27);
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
			// label27
			// 
			this.label27.AccessibleDescription = resources.GetString("label27.AccessibleDescription");
			this.label27.AccessibleName = resources.GetString("label27.AccessibleName");
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label27.Anchor")));
			this.label27.AutoSize = ((bool)(resources.GetObject("label27.AutoSize")));
			this.label27.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label27.Dock")));
			this.label27.Enabled = ((bool)(resources.GetObject("label27.Enabled")));
			this.label27.Font = ((System.Drawing.Font)(resources.GetObject("label27.Font")));
			this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
			this.label27.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.ImageAlign")));
			this.label27.ImageIndex = ((int)(resources.GetObject("label27.ImageIndex")));
			this.label27.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label27.ImeMode")));
			this.label27.Location = ((System.Drawing.Point)(resources.GetObject("label27.Location")));
			this.label27.Name = "label27";
			this.label27.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label27.RightToLeft")));
			this.label27.Size = ((System.Drawing.Size)(resources.GetObject("label27.Size")));
			this.label27.TabIndex = ((int)(resources.GetObject("label27.TabIndex")));
			this.label27.Text = resources.GetString("label27.Text");
			this.label27.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.TextAlign")));
			this.label27.Visible = ((bool)(resources.GetObject("label27.Visible")));
			// 
			// label28
			// 
			this.label28.AccessibleDescription = resources.GetString("label28.AccessibleDescription");
			this.label28.AccessibleName = resources.GetString("label28.AccessibleName");
			this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label28.Anchor")));
			this.label28.AutoSize = ((bool)(resources.GetObject("label28.AutoSize")));
			this.label28.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label28.Dock")));
			this.label28.Enabled = ((bool)(resources.GetObject("label28.Enabled")));
			this.label28.Font = ((System.Drawing.Font)(resources.GetObject("label28.Font")));
			this.label28.Image = ((System.Drawing.Image)(resources.GetObject("label28.Image")));
			this.label28.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label28.ImageAlign")));
			this.label28.ImageIndex = ((int)(resources.GetObject("label28.ImageIndex")));
			this.label28.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label28.ImeMode")));
			this.label28.Location = ((System.Drawing.Point)(resources.GetObject("label28.Location")));
			this.label28.Name = "label28";
			this.label28.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label28.RightToLeft")));
			this.label28.Size = ((System.Drawing.Size)(resources.GetObject("label28.Size")));
			this.label28.TabIndex = ((int)(resources.GetObject("label28.TabIndex")));
			this.label28.Text = resources.GetString("label28.Text");
			this.label28.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label28.TextAlign")));
			this.label28.Visible = ((bool)(resources.GetObject("label28.Visible")));
			// 
			// ObjfPanel
			// 
			this.ObjfPanel.AccessibleDescription = resources.GetString("ObjfPanel.AccessibleDescription");
			this.ObjfPanel.AccessibleName = resources.GetString("ObjfPanel.AccessibleName");
			this.ObjfPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ObjfPanel.Anchor")));
			this.ObjfPanel.AutoScroll = ((bool)(resources.GetObject("ObjfPanel.AutoScroll")));
			this.ObjfPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("ObjfPanel.AutoScrollMargin")));
			this.ObjfPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("ObjfPanel.AutoScrollMinSize")));
			this.ObjfPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ObjfPanel.BackgroundImage")));
			this.ObjfPanel.Controls.Add(this.groupBox2);
			this.ObjfPanel.Controls.Add(this.lbobjf);
			this.ObjfPanel.Controls.Add(this.btcommitobjf);
			this.ObjfPanel.Controls.Add(this.panel4);
			this.ObjfPanel.Controls.Add(this.label19);
			this.ObjfPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ObjfPanel.Dock")));
			this.ObjfPanel.Enabled = ((bool)(resources.GetObject("ObjfPanel.Enabled")));
			this.ObjfPanel.Font = ((System.Drawing.Font)(resources.GetObject("ObjfPanel.Font")));
			this.ObjfPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ObjfPanel.ImeMode")));
			this.ObjfPanel.Location = ((System.Drawing.Point)(resources.GetObject("ObjfPanel.Location")));
			this.ObjfPanel.Name = "ObjfPanel";
			this.ObjfPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ObjfPanel.RightToLeft")));
			this.ObjfPanel.Size = ((System.Drawing.Size)(resources.GetObject("ObjfPanel.Size")));
			this.ObjfPanel.TabIndex = ((int)(resources.GetObject("ObjfPanel.TabIndex")));
			this.ObjfPanel.Text = resources.GetString("ObjfPanel.Text");
			this.ObjfPanel.Visible = ((bool)(resources.GetObject("ObjfPanel.Visible")));
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.btobjaction);
			this.groupBox2.Controls.Add(this.btobjguard);
			this.groupBox2.Controls.Add(this.lbname);
			this.groupBox2.Controls.Add(this.tbaction);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.llchangeobjf);
			this.groupBox2.Controls.Add(this.tbguard);
			this.groupBox2.Controls.Add(this.label8);
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
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			// 
			// btobjaction
			// 
			this.btobjaction.AccessibleDescription = resources.GetString("btobjaction.AccessibleDescription");
			this.btobjaction.AccessibleName = resources.GetString("btobjaction.AccessibleName");
			this.btobjaction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btobjaction.Anchor")));
			this.btobjaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btobjaction.BackgroundImage")));
			this.btobjaction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btobjaction.Dock")));
			this.btobjaction.Enabled = ((bool)(resources.GetObject("btobjaction.Enabled")));
			this.btobjaction.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btobjaction.FlatStyle")));
			this.btobjaction.Font = ((System.Drawing.Font)(resources.GetObject("btobjaction.Font")));
			this.btobjaction.Image = ((System.Drawing.Image)(resources.GetObject("btobjaction.Image")));
			this.btobjaction.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btobjaction.ImageAlign")));
			this.btobjaction.ImageIndex = ((int)(resources.GetObject("btobjaction.ImageIndex")));
			this.btobjaction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btobjaction.ImeMode")));
			this.btobjaction.Location = ((System.Drawing.Point)(resources.GetObject("btobjaction.Location")));
			this.btobjaction.Name = "btobjaction";
			this.btobjaction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btobjaction.RightToLeft")));
			this.btobjaction.Size = ((System.Drawing.Size)(resources.GetObject("btobjaction.Size")));
			this.btobjaction.TabIndex = ((int)(resources.GetObject("btobjaction.TabIndex")));
			this.btobjaction.Text = resources.GetString("btobjaction.Text");
			this.btobjaction.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btobjaction.TextAlign")));
			this.btobjaction.Visible = ((bool)(resources.GetObject("btobjaction.Visible")));
			this.btobjaction.Click += new System.EventHandler(this.GetObjfAction);
			// 
			// btobjguard
			// 
			this.btobjguard.AccessibleDescription = resources.GetString("btobjguard.AccessibleDescription");
			this.btobjguard.AccessibleName = resources.GetString("btobjguard.AccessibleName");
			this.btobjguard.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btobjguard.Anchor")));
			this.btobjguard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btobjguard.BackgroundImage")));
			this.btobjguard.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btobjguard.Dock")));
			this.btobjguard.Enabled = ((bool)(resources.GetObject("btobjguard.Enabled")));
			this.btobjguard.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btobjguard.FlatStyle")));
			this.btobjguard.Font = ((System.Drawing.Font)(resources.GetObject("btobjguard.Font")));
			this.btobjguard.Image = ((System.Drawing.Image)(resources.GetObject("btobjguard.Image")));
			this.btobjguard.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btobjguard.ImageAlign")));
			this.btobjguard.ImageIndex = ((int)(resources.GetObject("btobjguard.ImageIndex")));
			this.btobjguard.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btobjguard.ImeMode")));
			this.btobjguard.Location = ((System.Drawing.Point)(resources.GetObject("btobjguard.Location")));
			this.btobjguard.Name = "btobjguard";
			this.btobjguard.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btobjguard.RightToLeft")));
			this.btobjguard.Size = ((System.Drawing.Size)(resources.GetObject("btobjguard.Size")));
			this.btobjguard.TabIndex = ((int)(resources.GetObject("btobjguard.TabIndex")));
			this.btobjguard.Text = resources.GetString("btobjguard.Text");
			this.btobjguard.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btobjguard.TextAlign")));
			this.btobjguard.Visible = ((bool)(resources.GetObject("btobjguard.Visible")));
			this.btobjguard.Click += new System.EventHandler(this.GetObjfGuard);
			// 
			// lbname
			// 
			this.lbname.AccessibleDescription = resources.GetString("lbname.AccessibleDescription");
			this.lbname.AccessibleName = resources.GetString("lbname.AccessibleName");
			this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbname.Anchor")));
			this.lbname.AutoSize = ((bool)(resources.GetObject("lbname.AutoSize")));
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
			// tbaction
			// 
			this.tbaction.AccessibleDescription = resources.GetString("tbaction.AccessibleDescription");
			this.tbaction.AccessibleName = resources.GetString("tbaction.AccessibleName");
			this.tbaction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbaction.Anchor")));
			this.tbaction.AutoSize = ((bool)(resources.GetObject("tbaction.AutoSize")));
			this.tbaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbaction.BackgroundImage")));
			this.tbaction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbaction.Dock")));
			this.tbaction.Enabled = ((bool)(resources.GetObject("tbaction.Enabled")));
			this.tbaction.Font = ((System.Drawing.Font)(resources.GetObject("tbaction.Font")));
			this.tbaction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbaction.ImeMode")));
			this.tbaction.Location = ((System.Drawing.Point)(resources.GetObject("tbaction.Location")));
			this.tbaction.MaxLength = ((int)(resources.GetObject("tbaction.MaxLength")));
			this.tbaction.Multiline = ((bool)(resources.GetObject("tbaction.Multiline")));
			this.tbaction.Name = "tbaction";
			this.tbaction.PasswordChar = ((char)(resources.GetObject("tbaction.PasswordChar")));
			this.tbaction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbaction.RightToLeft")));
			this.tbaction.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbaction.ScrollBars")));
			this.tbaction.Size = ((System.Drawing.Size)(resources.GetObject("tbaction.Size")));
			this.tbaction.TabIndex = ((int)(resources.GetObject("tbaction.TabIndex")));
			this.tbaction.Text = resources.GetString("tbaction.Text");
			this.tbaction.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbaction.TextAlign")));
			this.tbaction.Visible = ((bool)(resources.GetObject("tbaction.Visible")));
			this.tbaction.WordWrap = ((bool)(resources.GetObject("tbaction.WordWrap")));
			this.tbaction.TextChanged += new System.EventHandler(this.AutoChangeObjf);
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
			this.label15.Visible = ((bool)(resources.GetObject("label15.Visible")));
			// 
			// llchangeobjf
			// 
			this.llchangeobjf.AccessibleDescription = resources.GetString("llchangeobjf.AccessibleDescription");
			this.llchangeobjf.AccessibleName = resources.GetString("llchangeobjf.AccessibleName");
			this.llchangeobjf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llchangeobjf.Anchor")));
			this.llchangeobjf.AutoSize = ((bool)(resources.GetObject("llchangeobjf.AutoSize")));
			this.llchangeobjf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llchangeobjf.Dock")));
			this.llchangeobjf.Enabled = ((bool)(resources.GetObject("llchangeobjf.Enabled")));
			this.llchangeobjf.Font = ((System.Drawing.Font)(resources.GetObject("llchangeobjf.Font")));
			this.llchangeobjf.Image = ((System.Drawing.Image)(resources.GetObject("llchangeobjf.Image")));
			this.llchangeobjf.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangeobjf.ImageAlign")));
			this.llchangeobjf.ImageIndex = ((int)(resources.GetObject("llchangeobjf.ImageIndex")));
			this.llchangeobjf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llchangeobjf.ImeMode")));
			this.llchangeobjf.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llchangeobjf.LinkArea")));
			this.llchangeobjf.Location = ((System.Drawing.Point)(resources.GetObject("llchangeobjf.Location")));
			this.llchangeobjf.Name = "llchangeobjf";
			this.llchangeobjf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llchangeobjf.RightToLeft")));
			this.llchangeobjf.Size = ((System.Drawing.Size)(resources.GetObject("llchangeobjf.Size")));
			this.llchangeobjf.TabIndex = ((int)(resources.GetObject("llchangeobjf.TabIndex")));
			this.llchangeobjf.TabStop = true;
			this.llchangeobjf.Text = resources.GetString("llchangeobjf.Text");
			this.llchangeobjf.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangeobjf.TextAlign")));
			this.llchangeobjf.Visible = ((bool)(resources.GetObject("llchangeobjf.Visible")));
			this.llchangeobjf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ObjfChanged);
			// 
			// tbguard
			// 
			this.tbguard.AccessibleDescription = resources.GetString("tbguard.AccessibleDescription");
			this.tbguard.AccessibleName = resources.GetString("tbguard.AccessibleName");
			this.tbguard.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbguard.Anchor")));
			this.tbguard.AutoSize = ((bool)(resources.GetObject("tbguard.AutoSize")));
			this.tbguard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbguard.BackgroundImage")));
			this.tbguard.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbguard.Dock")));
			this.tbguard.Enabled = ((bool)(resources.GetObject("tbguard.Enabled")));
			this.tbguard.Font = ((System.Drawing.Font)(resources.GetObject("tbguard.Font")));
			this.tbguard.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbguard.ImeMode")));
			this.tbguard.Location = ((System.Drawing.Point)(resources.GetObject("tbguard.Location")));
			this.tbguard.MaxLength = ((int)(resources.GetObject("tbguard.MaxLength")));
			this.tbguard.Multiline = ((bool)(resources.GetObject("tbguard.Multiline")));
			this.tbguard.Name = "tbguard";
			this.tbguard.PasswordChar = ((char)(resources.GetObject("tbguard.PasswordChar")));
			this.tbguard.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbguard.RightToLeft")));
			this.tbguard.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbguard.ScrollBars")));
			this.tbguard.Size = ((System.Drawing.Size)(resources.GetObject("tbguard.Size")));
			this.tbguard.TabIndex = ((int)(resources.GetObject("tbguard.TabIndex")));
			this.tbguard.Text = resources.GetString("tbguard.Text");
			this.tbguard.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbguard.TextAlign")));
			this.tbguard.Visible = ((bool)(resources.GetObject("tbguard.Visible")));
			this.tbguard.WordWrap = ((bool)(resources.GetObject("tbguard.WordWrap")));
			this.tbguard.TextChanged += new System.EventHandler(this.AutoChangeObjf);
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
			// lbobjf
			// 
			this.lbobjf.AccessibleDescription = resources.GetString("lbobjf.AccessibleDescription");
			this.lbobjf.AccessibleName = resources.GetString("lbobjf.AccessibleName");
			this.lbobjf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbobjf.Anchor")));
			this.lbobjf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbobjf.BackgroundImage")));
			this.lbobjf.ColumnWidth = ((int)(resources.GetObject("lbobjf.ColumnWidth")));
			this.lbobjf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbobjf.Dock")));
			this.lbobjf.Enabled = ((bool)(resources.GetObject("lbobjf.Enabled")));
			this.lbobjf.Font = ((System.Drawing.Font)(resources.GetObject("lbobjf.Font")));
			this.lbobjf.HorizontalExtent = ((int)(resources.GetObject("lbobjf.HorizontalExtent")));
			this.lbobjf.HorizontalScrollbar = ((bool)(resources.GetObject("lbobjf.HorizontalScrollbar")));
			this.lbobjf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbobjf.ImeMode")));
			this.lbobjf.IntegralHeight = ((bool)(resources.GetObject("lbobjf.IntegralHeight")));
			this.lbobjf.ItemHeight = ((int)(resources.GetObject("lbobjf.ItemHeight")));
			this.lbobjf.Location = ((System.Drawing.Point)(resources.GetObject("lbobjf.Location")));
			this.lbobjf.Name = "lbobjf";
			this.lbobjf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbobjf.RightToLeft")));
			this.lbobjf.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbobjf.ScrollAlwaysVisible")));
			this.lbobjf.Size = ((System.Drawing.Size)(resources.GetObject("lbobjf.Size")));
			this.lbobjf.TabIndex = ((int)(resources.GetObject("lbobjf.TabIndex")));
			this.lbobjf.Visible = ((bool)(resources.GetObject("lbobjf.Visible")));
			this.lbobjf.SelectedIndexChanged += new System.EventHandler(this.ObjfChanged);
			// 
			// btcommitobjf
			// 
			this.btcommitobjf.AccessibleDescription = resources.GetString("btcommitobjf.AccessibleDescription");
			this.btcommitobjf.AccessibleName = resources.GetString("btcommitobjf.AccessibleName");
			this.btcommitobjf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btcommitobjf.Anchor")));
			this.btcommitobjf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcommitobjf.BackgroundImage")));
			this.btcommitobjf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btcommitobjf.Dock")));
			this.btcommitobjf.Enabled = ((bool)(resources.GetObject("btcommitobjf.Enabled")));
			this.btcommitobjf.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btcommitobjf.FlatStyle")));
			this.btcommitobjf.Font = ((System.Drawing.Font)(resources.GetObject("btcommitobjf.Font")));
			this.btcommitobjf.Image = ((System.Drawing.Image)(resources.GetObject("btcommitobjf.Image")));
			this.btcommitobjf.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommitobjf.ImageAlign")));
			this.btcommitobjf.ImageIndex = ((int)(resources.GetObject("btcommitobjf.ImageIndex")));
			this.btcommitobjf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btcommitobjf.ImeMode")));
			this.btcommitobjf.Location = ((System.Drawing.Point)(resources.GetObject("btcommitobjf.Location")));
			this.btcommitobjf.Name = "btcommitobjf";
			this.btcommitobjf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btcommitobjf.RightToLeft")));
			this.btcommitobjf.Size = ((System.Drawing.Size)(resources.GetObject("btcommitobjf.Size")));
			this.btcommitobjf.TabIndex = ((int)(resources.GetObject("btcommitobjf.TabIndex")));
			this.btcommitobjf.Text = resources.GetString("btcommitobjf.Text");
			this.btcommitobjf.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommitobjf.TextAlign")));
			this.btcommitobjf.Visible = ((bool)(resources.GetObject("btcommitobjf.Visible")));
			this.btcommitobjf.Click += new System.EventHandler(this.ObjfCommit);
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
			this.panel4.Controls.Add(this.lbobjffile);
			this.panel4.Controls.Add(this.label17);
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
			// lbobjffile
			// 
			this.lbobjffile.AccessibleDescription = resources.GetString("lbobjffile.AccessibleDescription");
			this.lbobjffile.AccessibleName = resources.GetString("lbobjffile.AccessibleName");
			this.lbobjffile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbobjffile.Anchor")));
			this.lbobjffile.AutoSize = ((bool)(resources.GetObject("lbobjffile.AutoSize")));
			this.lbobjffile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbobjffile.Dock")));
			this.lbobjffile.Enabled = ((bool)(resources.GetObject("lbobjffile.Enabled")));
			this.lbobjffile.Font = ((System.Drawing.Font)(resources.GetObject("lbobjffile.Font")));
			this.lbobjffile.Image = ((System.Drawing.Image)(resources.GetObject("lbobjffile.Image")));
			this.lbobjffile.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbobjffile.ImageAlign")));
			this.lbobjffile.ImageIndex = ((int)(resources.GetObject("lbobjffile.ImageIndex")));
			this.lbobjffile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbobjffile.ImeMode")));
			this.lbobjffile.Location = ((System.Drawing.Point)(resources.GetObject("lbobjffile.Location")));
			this.lbobjffile.Name = "lbobjffile";
			this.lbobjffile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbobjffile.RightToLeft")));
			this.lbobjffile.Size = ((System.Drawing.Size)(resources.GetObject("lbobjffile.Size")));
			this.lbobjffile.TabIndex = ((int)(resources.GetObject("lbobjffile.TabIndex")));
			this.lbobjffile.Text = resources.GetString("lbobjffile.Text");
			this.lbobjffile.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbobjffile.TextAlign")));
			this.lbobjffile.Visible = ((bool)(resources.GetObject("lbobjffile.Visible")));
			// 
			// label17
			// 
			this.label17.AccessibleDescription = resources.GetString("label17.AccessibleDescription");
			this.label17.AccessibleName = resources.GetString("label17.AccessibleName");
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label17.Anchor")));
			this.label17.AutoSize = ((bool)(resources.GetObject("label17.AutoSize")));
			this.label17.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label17.Dock")));
			this.label17.Enabled = ((bool)(resources.GetObject("label17.Enabled")));
			this.label17.Font = ((System.Drawing.Font)(resources.GetObject("label17.Font")));
			this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
			this.label17.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label17.ImageAlign")));
			this.label17.ImageIndex = ((int)(resources.GetObject("label17.ImageIndex")));
			this.label17.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label17.ImeMode")));
			this.label17.Location = ((System.Drawing.Point)(resources.GetObject("label17.Location")));
			this.label17.Name = "label17";
			this.label17.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label17.RightToLeft")));
			this.label17.Size = ((System.Drawing.Size)(resources.GetObject("label17.Size")));
			this.label17.TabIndex = ((int)(resources.GetObject("label17.TabIndex")));
			this.label17.Text = resources.GetString("label17.Text");
			this.label17.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label17.TextAlign")));
			this.label17.Visible = ((bool)(resources.GetObject("label17.Visible")));
			// 
			// label19
			// 
			this.label19.AccessibleDescription = resources.GetString("label19.AccessibleDescription");
			this.label19.AccessibleName = resources.GetString("label19.AccessibleName");
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label19.Anchor")));
			this.label19.AutoSize = ((bool)(resources.GetObject("label19.AutoSize")));
			this.label19.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label19.Dock")));
			this.label19.Enabled = ((bool)(resources.GetObject("label19.Enabled")));
			this.label19.Font = ((System.Drawing.Font)(resources.GetObject("label19.Font")));
			this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
			this.label19.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label19.ImageAlign")));
			this.label19.ImageIndex = ((int)(resources.GetObject("label19.ImageIndex")));
			this.label19.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label19.ImeMode")));
			this.label19.Location = ((System.Drawing.Point)(resources.GetObject("label19.Location")));
			this.label19.Name = "label19";
			this.label19.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label19.RightToLeft")));
			this.label19.Size = ((System.Drawing.Size)(resources.GetObject("label19.Size")));
			this.label19.TabIndex = ((int)(resources.GetObject("label19.TabIndex")));
			this.label19.Text = resources.GetString("label19.Text");
			this.label19.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label19.TextAlign")));
			this.label19.Visible = ((bool)(resources.GetObject("label19.Visible")));
			// 
			// TtabPanel
			// 
			this.TtabPanel.AccessibleDescription = resources.GetString("TtabPanel.AccessibleDescription");
			this.TtabPanel.AccessibleName = resources.GetString("TtabPanel.AccessibleName");
			this.TtabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("TtabPanel.Anchor")));
			this.TtabPanel.AutoScroll = ((bool)(resources.GetObject("TtabPanel.AutoScroll")));
			this.TtabPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("TtabPanel.AutoScrollMargin")));
			this.TtabPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("TtabPanel.AutoScrollMinSize")));
			this.TtabPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TtabPanel.BackgroundImage")));
			this.TtabPanel.Controls.Add(this.lbttab);
			this.TtabPanel.Controls.Add(this.button2);
			this.TtabPanel.Controls.Add(this.panel5);
			this.TtabPanel.Controls.Add(this.label26);
			this.TtabPanel.Controls.Add(this.gbttab);
			this.TtabPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("TtabPanel.Dock")));
			this.TtabPanel.Enabled = ((bool)(resources.GetObject("TtabPanel.Enabled")));
			this.TtabPanel.Font = ((System.Drawing.Font)(resources.GetObject("TtabPanel.Font")));
			this.TtabPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("TtabPanel.ImeMode")));
			this.TtabPanel.Location = ((System.Drawing.Point)(resources.GetObject("TtabPanel.Location")));
			this.TtabPanel.Name = "TtabPanel";
			this.TtabPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("TtabPanel.RightToLeft")));
			this.TtabPanel.Size = ((System.Drawing.Size)(resources.GetObject("TtabPanel.Size")));
			this.TtabPanel.TabIndex = ((int)(resources.GetObject("TtabPanel.TabIndex")));
			this.TtabPanel.Text = resources.GetString("TtabPanel.Text");
			this.TtabPanel.Visible = ((bool)(resources.GetObject("TtabPanel.Visible")));
			// 
			// lbttab
			// 
			this.lbttab.AccessibleDescription = resources.GetString("lbttab.AccessibleDescription");
			this.lbttab.AccessibleName = resources.GetString("lbttab.AccessibleName");
			this.lbttab.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbttab.Anchor")));
			this.lbttab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbttab.BackgroundImage")));
			this.lbttab.ColumnWidth = ((int)(resources.GetObject("lbttab.ColumnWidth")));
			this.lbttab.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbttab.Dock")));
			this.lbttab.Enabled = ((bool)(resources.GetObject("lbttab.Enabled")));
			this.lbttab.Font = ((System.Drawing.Font)(resources.GetObject("lbttab.Font")));
			this.lbttab.HorizontalExtent = ((int)(resources.GetObject("lbttab.HorizontalExtent")));
			this.lbttab.HorizontalScrollbar = ((bool)(resources.GetObject("lbttab.HorizontalScrollbar")));
			this.lbttab.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbttab.ImeMode")));
			this.lbttab.IntegralHeight = ((bool)(resources.GetObject("lbttab.IntegralHeight")));
			this.lbttab.ItemHeight = ((int)(resources.GetObject("lbttab.ItemHeight")));
			this.lbttab.Location = ((System.Drawing.Point)(resources.GetObject("lbttab.Location")));
			this.lbttab.Name = "lbttab";
			this.lbttab.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbttab.RightToLeft")));
			this.lbttab.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbttab.ScrollAlwaysVisible")));
			this.lbttab.Size = ((System.Drawing.Size)(resources.GetObject("lbttab.Size")));
			this.lbttab.TabIndex = ((int)(resources.GetObject("lbttab.TabIndex")));
			this.lbttab.Visible = ((bool)(resources.GetObject("lbttab.Visible")));
			this.lbttab.SelectedIndexChanged += new System.EventHandler(this.TtabSelect);
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
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.Ttabcommit);
			// 
			// panel5
			// 
			this.panel5.AccessibleDescription = resources.GetString("panel5.AccessibleDescription");
			this.panel5.AccessibleName = resources.GetString("panel5.AccessibleName");
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel5.Anchor")));
			this.panel5.AutoScroll = ((bool)(resources.GetObject("panel5.AutoScroll")));
			this.panel5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMargin")));
			this.panel5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMinSize")));
			this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Controls.Add(this.lbttabfile);
			this.panel5.Controls.Add(this.label25);
			this.panel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel5.Dock")));
			this.panel5.Enabled = ((bool)(resources.GetObject("panel5.Enabled")));
			this.panel5.Font = ((System.Drawing.Font)(resources.GetObject("panel5.Font")));
			this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel5.ImeMode")));
			this.panel5.Location = ((System.Drawing.Point)(resources.GetObject("panel5.Location")));
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel5.RightToLeft")));
			this.panel5.Size = ((System.Drawing.Size)(resources.GetObject("panel5.Size")));
			this.panel5.TabIndex = ((int)(resources.GetObject("panel5.TabIndex")));
			this.panel5.Text = resources.GetString("panel5.Text");
			this.panel5.Visible = ((bool)(resources.GetObject("panel5.Visible")));
			// 
			// lbttabfile
			// 
			this.lbttabfile.AccessibleDescription = resources.GetString("lbttabfile.AccessibleDescription");
			this.lbttabfile.AccessibleName = resources.GetString("lbttabfile.AccessibleName");
			this.lbttabfile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbttabfile.Anchor")));
			this.lbttabfile.AutoSize = ((bool)(resources.GetObject("lbttabfile.AutoSize")));
			this.lbttabfile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbttabfile.Dock")));
			this.lbttabfile.Enabled = ((bool)(resources.GetObject("lbttabfile.Enabled")));
			this.lbttabfile.Font = ((System.Drawing.Font)(resources.GetObject("lbttabfile.Font")));
			this.lbttabfile.Image = ((System.Drawing.Image)(resources.GetObject("lbttabfile.Image")));
			this.lbttabfile.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbttabfile.ImageAlign")));
			this.lbttabfile.ImageIndex = ((int)(resources.GetObject("lbttabfile.ImageIndex")));
			this.lbttabfile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbttabfile.ImeMode")));
			this.lbttabfile.Location = ((System.Drawing.Point)(resources.GetObject("lbttabfile.Location")));
			this.lbttabfile.Name = "lbttabfile";
			this.lbttabfile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbttabfile.RightToLeft")));
			this.lbttabfile.Size = ((System.Drawing.Size)(resources.GetObject("lbttabfile.Size")));
			this.lbttabfile.TabIndex = ((int)(resources.GetObject("lbttabfile.TabIndex")));
			this.lbttabfile.Text = resources.GetString("lbttabfile.Text");
			this.lbttabfile.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbttabfile.TextAlign")));
			this.lbttabfile.Visible = ((bool)(resources.GetObject("lbttabfile.Visible")));
			// 
			// label25
			// 
			this.label25.AccessibleDescription = resources.GetString("label25.AccessibleDescription");
			this.label25.AccessibleName = resources.GetString("label25.AccessibleName");
			this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label25.Anchor")));
			this.label25.AutoSize = ((bool)(resources.GetObject("label25.AutoSize")));
			this.label25.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label25.Dock")));
			this.label25.Enabled = ((bool)(resources.GetObject("label25.Enabled")));
			this.label25.Font = ((System.Drawing.Font)(resources.GetObject("label25.Font")));
			this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
			this.label25.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label25.ImageAlign")));
			this.label25.ImageIndex = ((int)(resources.GetObject("label25.ImageIndex")));
			this.label25.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label25.ImeMode")));
			this.label25.Location = ((System.Drawing.Point)(resources.GetObject("label25.Location")));
			this.label25.Name = "label25";
			this.label25.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label25.RightToLeft")));
			this.label25.Size = ((System.Drawing.Size)(resources.GetObject("label25.Size")));
			this.label25.TabIndex = ((int)(resources.GetObject("label25.TabIndex")));
			this.label25.Text = resources.GetString("label25.Text");
			this.label25.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label25.TextAlign")));
			this.label25.Visible = ((bool)(resources.GetObject("label25.Visible")));
			// 
			// label26
			// 
			this.label26.AccessibleDescription = resources.GetString("label26.AccessibleDescription");
			this.label26.AccessibleName = resources.GetString("label26.AccessibleName");
			this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label26.Anchor")));
			this.label26.AutoSize = ((bool)(resources.GetObject("label26.AutoSize")));
			this.label26.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label26.Dock")));
			this.label26.Enabled = ((bool)(resources.GetObject("label26.Enabled")));
			this.label26.Font = ((System.Drawing.Font)(resources.GetObject("label26.Font")));
			this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
			this.label26.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label26.ImageAlign")));
			this.label26.ImageIndex = ((int)(resources.GetObject("label26.ImageIndex")));
			this.label26.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label26.ImeMode")));
			this.label26.Location = ((System.Drawing.Point)(resources.GetObject("label26.Location")));
			this.label26.Name = "label26";
			this.label26.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label26.RightToLeft")));
			this.label26.Size = ((System.Drawing.Size)(resources.GetObject("label26.Size")));
			this.label26.TabIndex = ((int)(resources.GetObject("label26.TabIndex")));
			this.label26.Text = resources.GetString("label26.Text");
			this.label26.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label26.TextAlign")));
			this.label26.Visible = ((bool)(resources.GetObject("label26.Visible")));
			// 
			// gbttab
			// 
			this.gbttab.AccessibleDescription = resources.GetString("gbttab.AccessibleDescription");
			this.gbttab.AccessibleName = resources.GetString("gbttab.AccessibleName");
			this.gbttab.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbttab.Anchor")));
			this.gbttab.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbttab.BackgroundImage")));
			this.gbttab.Controls.Add(this.groupBox3);
			this.gbttab.Controls.Add(this.lldelttab);
			this.gbttab.Controls.Add(this.button6);
			this.gbttab.Controls.Add(this.button5);
			this.gbttab.Controls.Add(this.lbaction);
			this.gbttab.Controls.Add(this.lbguard);
			this.gbttab.Controls.Add(this.tbver);
			this.gbttab.Controls.Add(this.label41);
			this.gbttab.Controls.Add(this.tbpie);
			this.gbttab.Controls.Add(this.label40);
			this.gbttab.Controls.Add(this.tbres8);
			this.gbttab.Controls.Add(this.label33);
			this.gbttab.Controls.Add(this.tbres7);
			this.gbttab.Controls.Add(this.label34);
			this.gbttab.Controls.Add(this.tbres4);
			this.gbttab.Controls.Add(this.label35);
			this.gbttab.Controls.Add(this.tbres3);
			this.gbttab.Controls.Add(this.label36);
			this.gbttab.Controls.Add(this.tbres6);
			this.gbttab.Controls.Add(this.label29);
			this.gbttab.Controls.Add(this.tbres5);
			this.gbttab.Controls.Add(this.label30);
			this.gbttab.Controls.Add(this.tbres2);
			this.gbttab.Controls.Add(this.label31);
			this.gbttab.Controls.Add(this.tbres1);
			this.gbttab.Controls.Add(this.label32);
			this.gbttab.Controls.Add(this.tbinst2);
			this.gbttab.Controls.Add(this.label20);
			this.gbttab.Controls.Add(this.tbinst1);
			this.gbttab.Controls.Add(this.label24);
			this.gbttab.Controls.Add(this.tbttabaction);
			this.gbttab.Controls.Add(this.label21);
			this.gbttab.Controls.Add(this.linkLabel1);
			this.gbttab.Controls.Add(this.llchangettab);
			this.gbttab.Controls.Add(this.tbttabguard);
			this.gbttab.Controls.Add(this.label23);
			this.gbttab.Controls.Add(this.groupBox4);
			this.gbttab.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbttab.Dock")));
			this.gbttab.Enabled = ((bool)(resources.GetObject("gbttab.Enabled")));
			this.gbttab.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbttab.Font = ((System.Drawing.Font)(resources.GetObject("gbttab.Font")));
			this.gbttab.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbttab.ImeMode")));
			this.gbttab.Location = ((System.Drawing.Point)(resources.GetObject("gbttab.Location")));
			this.gbttab.Name = "gbttab";
			this.gbttab.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbttab.RightToLeft")));
			this.gbttab.Size = ((System.Drawing.Size)(resources.GetObject("gbttab.Size")));
			this.gbttab.TabIndex = ((int)(resources.GetObject("gbttab.TabIndex")));
			this.gbttab.TabStop = false;
			this.gbttab.Text = resources.GetString("gbttab.Text");
			this.gbttab.Visible = ((bool)(resources.GetObject("gbttab.Visible")));
			// 
			// groupBox3
			// 
			this.groupBox3.AccessibleDescription = resources.GetString("groupBox3.AccessibleDescription");
			this.groupBox3.AccessibleName = resources.GetString("groupBox3.AccessibleName");
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox3.Anchor")));
			this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
			this.groupBox3.Controls.Add(this.lllistchange);
			this.groupBox3.Controls.Add(this.tblisttype);
			this.groupBox3.Controls.Add(this.label37);
			this.groupBox3.Controls.Add(this.tbdelta);
			this.groupBox3.Controls.Add(this.label38);
			this.groupBox3.Controls.Add(this.tbmin);
			this.groupBox3.Controls.Add(this.label39);
			this.groupBox3.Controls.Add(this.lblist);
			this.groupBox3.Controls.Add(this.cbgroups);
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
			this.groupBox3.Visible = ((bool)(resources.GetObject("groupBox3.Visible")));
			// 
			// lllistchange
			// 
			this.lllistchange.AccessibleDescription = resources.GetString("lllistchange.AccessibleDescription");
			this.lllistchange.AccessibleName = resources.GetString("lllistchange.AccessibleName");
			this.lllistchange.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lllistchange.Anchor")));
			this.lllistchange.AutoSize = ((bool)(resources.GetObject("lllistchange.AutoSize")));
			this.lllistchange.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lllistchange.Dock")));
			this.lllistchange.Enabled = ((bool)(resources.GetObject("lllistchange.Enabled")));
			this.lllistchange.Font = ((System.Drawing.Font)(resources.GetObject("lllistchange.Font")));
			this.lllistchange.Image = ((System.Drawing.Image)(resources.GetObject("lllistchange.Image")));
			this.lllistchange.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lllistchange.ImageAlign")));
			this.lllistchange.ImageIndex = ((int)(resources.GetObject("lllistchange.ImageIndex")));
			this.lllistchange.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lllistchange.ImeMode")));
			this.lllistchange.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lllistchange.LinkArea")));
			this.lllistchange.Location = ((System.Drawing.Point)(resources.GetObject("lllistchange.Location")));
			this.lllistchange.Name = "lllistchange";
			this.lllistchange.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lllistchange.RightToLeft")));
			this.lllistchange.Size = ((System.Drawing.Size)(resources.GetObject("lllistchange.Size")));
			this.lllistchange.TabIndex = ((int)(resources.GetObject("lllistchange.TabIndex")));
			this.lllistchange.TabStop = true;
			this.lllistchange.Text = resources.GetString("lllistchange.Text");
			this.lllistchange.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lllistchange.TextAlign")));
			this.lllistchange.Visible = ((bool)(resources.GetObject("lllistchange.Visible")));
			this.lllistchange.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ListChangeClick);
			// 
			// tblisttype
			// 
			this.tblisttype.AccessibleDescription = resources.GetString("tblisttype.AccessibleDescription");
			this.tblisttype.AccessibleName = resources.GetString("tblisttype.AccessibleName");
			this.tblisttype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblisttype.Anchor")));
			this.tblisttype.AutoSize = ((bool)(resources.GetObject("tblisttype.AutoSize")));
			this.tblisttype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblisttype.BackgroundImage")));
			this.tblisttype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblisttype.Dock")));
			this.tblisttype.Enabled = ((bool)(resources.GetObject("tblisttype.Enabled")));
			this.tblisttype.Font = ((System.Drawing.Font)(resources.GetObject("tblisttype.Font")));
			this.tblisttype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblisttype.ImeMode")));
			this.tblisttype.Location = ((System.Drawing.Point)(resources.GetObject("tblisttype.Location")));
			this.tblisttype.MaxLength = ((int)(resources.GetObject("tblisttype.MaxLength")));
			this.tblisttype.Multiline = ((bool)(resources.GetObject("tblisttype.Multiline")));
			this.tblisttype.Name = "tblisttype";
			this.tblisttype.PasswordChar = ((char)(resources.GetObject("tblisttype.PasswordChar")));
			this.tblisttype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblisttype.RightToLeft")));
			this.tblisttype.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblisttype.ScrollBars")));
			this.tblisttype.Size = ((System.Drawing.Size)(resources.GetObject("tblisttype.Size")));
			this.tblisttype.TabIndex = ((int)(resources.GetObject("tblisttype.TabIndex")));
			this.tblisttype.Text = resources.GetString("tblisttype.Text");
			this.tblisttype.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblisttype.TextAlign")));
			this.tblisttype.Visible = ((bool)(resources.GetObject("tblisttype.Visible")));
			this.tblisttype.WordWrap = ((bool)(resources.GetObject("tblisttype.WordWrap")));
			this.tblisttype.TextChanged += new System.EventHandler(this.AutoChangeMotive);
			// 
			// label37
			// 
			this.label37.AccessibleDescription = resources.GetString("label37.AccessibleDescription");
			this.label37.AccessibleName = resources.GetString("label37.AccessibleName");
			this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label37.Anchor")));
			this.label37.AutoSize = ((bool)(resources.GetObject("label37.AutoSize")));
			this.label37.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label37.Dock")));
			this.label37.Enabled = ((bool)(resources.GetObject("label37.Enabled")));
			this.label37.Font = ((System.Drawing.Font)(resources.GetObject("label37.Font")));
			this.label37.Image = ((System.Drawing.Image)(resources.GetObject("label37.Image")));
			this.label37.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label37.ImageAlign")));
			this.label37.ImageIndex = ((int)(resources.GetObject("label37.ImageIndex")));
			this.label37.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label37.ImeMode")));
			this.label37.Location = ((System.Drawing.Point)(resources.GetObject("label37.Location")));
			this.label37.Name = "label37";
			this.label37.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label37.RightToLeft")));
			this.label37.Size = ((System.Drawing.Size)(resources.GetObject("label37.Size")));
			this.label37.TabIndex = ((int)(resources.GetObject("label37.TabIndex")));
			this.label37.Text = resources.GetString("label37.Text");
			this.label37.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label37.TextAlign")));
			this.label37.Visible = ((bool)(resources.GetObject("label37.Visible")));
			// 
			// tbdelta
			// 
			this.tbdelta.AccessibleDescription = resources.GetString("tbdelta.AccessibleDescription");
			this.tbdelta.AccessibleName = resources.GetString("tbdelta.AccessibleName");
			this.tbdelta.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbdelta.Anchor")));
			this.tbdelta.AutoSize = ((bool)(resources.GetObject("tbdelta.AutoSize")));
			this.tbdelta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbdelta.BackgroundImage")));
			this.tbdelta.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbdelta.Dock")));
			this.tbdelta.Enabled = ((bool)(resources.GetObject("tbdelta.Enabled")));
			this.tbdelta.Font = ((System.Drawing.Font)(resources.GetObject("tbdelta.Font")));
			this.tbdelta.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbdelta.ImeMode")));
			this.tbdelta.Location = ((System.Drawing.Point)(resources.GetObject("tbdelta.Location")));
			this.tbdelta.MaxLength = ((int)(resources.GetObject("tbdelta.MaxLength")));
			this.tbdelta.Multiline = ((bool)(resources.GetObject("tbdelta.Multiline")));
			this.tbdelta.Name = "tbdelta";
			this.tbdelta.PasswordChar = ((char)(resources.GetObject("tbdelta.PasswordChar")));
			this.tbdelta.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbdelta.RightToLeft")));
			this.tbdelta.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbdelta.ScrollBars")));
			this.tbdelta.Size = ((System.Drawing.Size)(resources.GetObject("tbdelta.Size")));
			this.tbdelta.TabIndex = ((int)(resources.GetObject("tbdelta.TabIndex")));
			this.tbdelta.Text = resources.GetString("tbdelta.Text");
			this.tbdelta.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbdelta.TextAlign")));
			this.tbdelta.Visible = ((bool)(resources.GetObject("tbdelta.Visible")));
			this.tbdelta.WordWrap = ((bool)(resources.GetObject("tbdelta.WordWrap")));
			this.tbdelta.TextChanged += new System.EventHandler(this.AutoChangeMotive);
			// 
			// label38
			// 
			this.label38.AccessibleDescription = resources.GetString("label38.AccessibleDescription");
			this.label38.AccessibleName = resources.GetString("label38.AccessibleName");
			this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label38.Anchor")));
			this.label38.AutoSize = ((bool)(resources.GetObject("label38.AutoSize")));
			this.label38.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label38.Dock")));
			this.label38.Enabled = ((bool)(resources.GetObject("label38.Enabled")));
			this.label38.Font = ((System.Drawing.Font)(resources.GetObject("label38.Font")));
			this.label38.Image = ((System.Drawing.Image)(resources.GetObject("label38.Image")));
			this.label38.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label38.ImageAlign")));
			this.label38.ImageIndex = ((int)(resources.GetObject("label38.ImageIndex")));
			this.label38.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label38.ImeMode")));
			this.label38.Location = ((System.Drawing.Point)(resources.GetObject("label38.Location")));
			this.label38.Name = "label38";
			this.label38.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label38.RightToLeft")));
			this.label38.Size = ((System.Drawing.Size)(resources.GetObject("label38.Size")));
			this.label38.TabIndex = ((int)(resources.GetObject("label38.TabIndex")));
			this.label38.Text = resources.GetString("label38.Text");
			this.label38.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label38.TextAlign")));
			this.label38.Visible = ((bool)(resources.GetObject("label38.Visible")));
			// 
			// tbmin
			// 
			this.tbmin.AccessibleDescription = resources.GetString("tbmin.AccessibleDescription");
			this.tbmin.AccessibleName = resources.GetString("tbmin.AccessibleName");
			this.tbmin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmin.Anchor")));
			this.tbmin.AutoSize = ((bool)(resources.GetObject("tbmin.AutoSize")));
			this.tbmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmin.BackgroundImage")));
			this.tbmin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmin.Dock")));
			this.tbmin.Enabled = ((bool)(resources.GetObject("tbmin.Enabled")));
			this.tbmin.Font = ((System.Drawing.Font)(resources.GetObject("tbmin.Font")));
			this.tbmin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmin.ImeMode")));
			this.tbmin.Location = ((System.Drawing.Point)(resources.GetObject("tbmin.Location")));
			this.tbmin.MaxLength = ((int)(resources.GetObject("tbmin.MaxLength")));
			this.tbmin.Multiline = ((bool)(resources.GetObject("tbmin.Multiline")));
			this.tbmin.Name = "tbmin";
			this.tbmin.PasswordChar = ((char)(resources.GetObject("tbmin.PasswordChar")));
			this.tbmin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmin.RightToLeft")));
			this.tbmin.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmin.ScrollBars")));
			this.tbmin.Size = ((System.Drawing.Size)(resources.GetObject("tbmin.Size")));
			this.tbmin.TabIndex = ((int)(resources.GetObject("tbmin.TabIndex")));
			this.tbmin.Text = resources.GetString("tbmin.Text");
			this.tbmin.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmin.TextAlign")));
			this.tbmin.Visible = ((bool)(resources.GetObject("tbmin.Visible")));
			this.tbmin.WordWrap = ((bool)(resources.GetObject("tbmin.WordWrap")));
			this.tbmin.TextChanged += new System.EventHandler(this.AutoChangeMotive);
			// 
			// label39
			// 
			this.label39.AccessibleDescription = resources.GetString("label39.AccessibleDescription");
			this.label39.AccessibleName = resources.GetString("label39.AccessibleName");
			this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label39.Anchor")));
			this.label39.AutoSize = ((bool)(resources.GetObject("label39.AutoSize")));
			this.label39.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label39.Dock")));
			this.label39.Enabled = ((bool)(resources.GetObject("label39.Enabled")));
			this.label39.Font = ((System.Drawing.Font)(resources.GetObject("label39.Font")));
			this.label39.Image = ((System.Drawing.Image)(resources.GetObject("label39.Image")));
			this.label39.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label39.ImageAlign")));
			this.label39.ImageIndex = ((int)(resources.GetObject("label39.ImageIndex")));
			this.label39.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label39.ImeMode")));
			this.label39.Location = ((System.Drawing.Point)(resources.GetObject("label39.Location")));
			this.label39.Name = "label39";
			this.label39.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label39.RightToLeft")));
			this.label39.Size = ((System.Drawing.Size)(resources.GetObject("label39.Size")));
			this.label39.TabIndex = ((int)(resources.GetObject("label39.TabIndex")));
			this.label39.Text = resources.GetString("label39.Text");
			this.label39.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label39.TextAlign")));
			this.label39.Visible = ((bool)(resources.GetObject("label39.Visible")));
			// 
			// lblist
			// 
			this.lblist.AccessibleDescription = resources.GetString("lblist.AccessibleDescription");
			this.lblist.AccessibleName = resources.GetString("lblist.AccessibleName");
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lblist.Anchor")));
			this.lblist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblist.BackgroundImage")));
			this.lblist.ColumnWidth = ((int)(resources.GetObject("lblist.ColumnWidth")));
			this.lblist.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lblist.Dock")));
			this.lblist.Enabled = ((bool)(resources.GetObject("lblist.Enabled")));
			this.lblist.Font = ((System.Drawing.Font)(resources.GetObject("lblist.Font")));
			this.lblist.HorizontalExtent = ((int)(resources.GetObject("lblist.HorizontalExtent")));
			this.lblist.HorizontalScrollbar = ((bool)(resources.GetObject("lblist.HorizontalScrollbar")));
			this.lblist.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lblist.ImeMode")));
			this.lblist.IntegralHeight = ((bool)(resources.GetObject("lblist.IntegralHeight")));
			this.lblist.ItemHeight = ((int)(resources.GetObject("lblist.ItemHeight")));
			this.lblist.Location = ((System.Drawing.Point)(resources.GetObject("lblist.Location")));
			this.lblist.Name = "lblist";
			this.lblist.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lblist.RightToLeft")));
			this.lblist.ScrollAlwaysVisible = ((bool)(resources.GetObject("lblist.ScrollAlwaysVisible")));
			this.lblist.Size = ((System.Drawing.Size)(resources.GetObject("lblist.Size")));
			this.lblist.TabIndex = ((int)(resources.GetObject("lblist.TabIndex")));
			this.lblist.Visible = ((bool)(resources.GetObject("lblist.Visible")));
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.GroupListChanged);
			// 
			// cbgroups
			// 
			this.cbgroups.AccessibleDescription = resources.GetString("cbgroups.AccessibleDescription");
			this.cbgroups.AccessibleName = resources.GetString("cbgroups.AccessibleName");
			this.cbgroups.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbgroups.Anchor")));
			this.cbgroups.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbgroups.BackgroundImage")));
			this.cbgroups.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbgroups.Dock")));
			this.cbgroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbgroups.Enabled = ((bool)(resources.GetObject("cbgroups.Enabled")));
			this.cbgroups.Font = ((System.Drawing.Font)(resources.GetObject("cbgroups.Font")));
			this.cbgroups.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbgroups.ImeMode")));
			this.cbgroups.IntegralHeight = ((bool)(resources.GetObject("cbgroups.IntegralHeight")));
			this.cbgroups.ItemHeight = ((int)(resources.GetObject("cbgroups.ItemHeight")));
			this.cbgroups.Location = ((System.Drawing.Point)(resources.GetObject("cbgroups.Location")));
			this.cbgroups.MaxDropDownItems = ((int)(resources.GetObject("cbgroups.MaxDropDownItems")));
			this.cbgroups.MaxLength = ((int)(resources.GetObject("cbgroups.MaxLength")));
			this.cbgroups.Name = "cbgroups";
			this.cbgroups.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbgroups.RightToLeft")));
			this.cbgroups.Size = ((System.Drawing.Size)(resources.GetObject("cbgroups.Size")));
			this.cbgroups.TabIndex = ((int)(resources.GetObject("cbgroups.TabIndex")));
			this.cbgroups.Text = resources.GetString("cbgroups.Text");
			this.cbgroups.Visible = ((bool)(resources.GetObject("cbgroups.Visible")));
			this.cbgroups.SelectedIndexChanged += new System.EventHandler(this.ListSelected);
			// 
			// lldelttab
			// 
			this.lldelttab.AccessibleDescription = resources.GetString("lldelttab.AccessibleDescription");
			this.lldelttab.AccessibleName = resources.GetString("lldelttab.AccessibleName");
			this.lldelttab.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldelttab.Anchor")));
			this.lldelttab.AutoSize = ((bool)(resources.GetObject("lldelttab.AutoSize")));
			this.lldelttab.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldelttab.Dock")));
			this.lldelttab.Enabled = ((bool)(resources.GetObject("lldelttab.Enabled")));
			this.lldelttab.Font = ((System.Drawing.Font)(resources.GetObject("lldelttab.Font")));
			this.lldelttab.Image = ((System.Drawing.Image)(resources.GetObject("lldelttab.Image")));
			this.lldelttab.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelttab.ImageAlign")));
			this.lldelttab.ImageIndex = ((int)(resources.GetObject("lldelttab.ImageIndex")));
			this.lldelttab.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldelttab.ImeMode")));
			this.lldelttab.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldelttab.LinkArea")));
			this.lldelttab.Location = ((System.Drawing.Point)(resources.GetObject("lldelttab.Location")));
			this.lldelttab.Name = "lldelttab";
			this.lldelttab.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldelttab.RightToLeft")));
			this.lldelttab.Size = ((System.Drawing.Size)(resources.GetObject("lldelttab.Size")));
			this.lldelttab.TabIndex = ((int)(resources.GetObject("lldelttab.TabIndex")));
			this.lldelttab.TabStop = true;
			this.lldelttab.Text = resources.GetString("lldelttab.Text");
			this.lldelttab.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelttab.TextAlign")));
			this.lldelttab.Visible = ((bool)(resources.GetObject("lldelttab.Visible")));
			this.lldelttab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TtabItemDelete);
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
			this.button6.Visible = ((bool)(resources.GetObject("button6.Visible")));
			this.button6.Click += new System.EventHandler(this.GetTTABAction);
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
			this.button5.Visible = ((bool)(resources.GetObject("button5.Visible")));
			this.button5.Click += new System.EventHandler(this.GetTTABGuard);
			// 
			// lbaction
			// 
			this.lbaction.AccessibleDescription = resources.GetString("lbaction.AccessibleDescription");
			this.lbaction.AccessibleName = resources.GetString("lbaction.AccessibleName");
			this.lbaction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbaction.Anchor")));
			this.lbaction.AutoSize = ((bool)(resources.GetObject("lbaction.AutoSize")));
			this.lbaction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbaction.Dock")));
			this.lbaction.Enabled = ((bool)(resources.GetObject("lbaction.Enabled")));
			this.lbaction.Font = ((System.Drawing.Font)(resources.GetObject("lbaction.Font")));
			this.lbaction.Image = ((System.Drawing.Image)(resources.GetObject("lbaction.Image")));
			this.lbaction.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbaction.ImageAlign")));
			this.lbaction.ImageIndex = ((int)(resources.GetObject("lbaction.ImageIndex")));
			this.lbaction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbaction.ImeMode")));
			this.lbaction.Location = ((System.Drawing.Point)(resources.GetObject("lbaction.Location")));
			this.lbaction.Name = "lbaction";
			this.lbaction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbaction.RightToLeft")));
			this.lbaction.Size = ((System.Drawing.Size)(resources.GetObject("lbaction.Size")));
			this.lbaction.TabIndex = ((int)(resources.GetObject("lbaction.TabIndex")));
			this.lbaction.Text = resources.GetString("lbaction.Text");
			this.lbaction.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbaction.TextAlign")));
			this.lbaction.Visible = ((bool)(resources.GetObject("lbaction.Visible")));
			// 
			// lbguard
			// 
			this.lbguard.AccessibleDescription = resources.GetString("lbguard.AccessibleDescription");
			this.lbguard.AccessibleName = resources.GetString("lbguard.AccessibleName");
			this.lbguard.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbguard.Anchor")));
			this.lbguard.AutoSize = ((bool)(resources.GetObject("lbguard.AutoSize")));
			this.lbguard.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbguard.Dock")));
			this.lbguard.Enabled = ((bool)(resources.GetObject("lbguard.Enabled")));
			this.lbguard.Font = ((System.Drawing.Font)(resources.GetObject("lbguard.Font")));
			this.lbguard.Image = ((System.Drawing.Image)(resources.GetObject("lbguard.Image")));
			this.lbguard.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbguard.ImageAlign")));
			this.lbguard.ImageIndex = ((int)(resources.GetObject("lbguard.ImageIndex")));
			this.lbguard.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbguard.ImeMode")));
			this.lbguard.Location = ((System.Drawing.Point)(resources.GetObject("lbguard.Location")));
			this.lbguard.Name = "lbguard";
			this.lbguard.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbguard.RightToLeft")));
			this.lbguard.Size = ((System.Drawing.Size)(resources.GetObject("lbguard.Size")));
			this.lbguard.TabIndex = ((int)(resources.GetObject("lbguard.TabIndex")));
			this.lbguard.Text = resources.GetString("lbguard.Text");
			this.lbguard.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbguard.TextAlign")));
			this.lbguard.Visible = ((bool)(resources.GetObject("lbguard.Visible")));
			// 
			// tbver
			// 
			this.tbver.AccessibleDescription = resources.GetString("tbver.AccessibleDescription");
			this.tbver.AccessibleName = resources.GetString("tbver.AccessibleName");
			this.tbver.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbver.Anchor")));
			this.tbver.AutoSize = ((bool)(resources.GetObject("tbver.AutoSize")));
			this.tbver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbver.BackgroundImage")));
			this.tbver.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbver.Dock")));
			this.tbver.Enabled = ((bool)(resources.GetObject("tbver.Enabled")));
			this.tbver.Font = ((System.Drawing.Font)(resources.GetObject("tbver.Font")));
			this.tbver.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbver.ImeMode")));
			this.tbver.Location = ((System.Drawing.Point)(resources.GetObject("tbver.Location")));
			this.tbver.MaxLength = ((int)(resources.GetObject("tbver.MaxLength")));
			this.tbver.Multiline = ((bool)(resources.GetObject("tbver.Multiline")));
			this.tbver.Name = "tbver";
			this.tbver.PasswordChar = ((char)(resources.GetObject("tbver.PasswordChar")));
			this.tbver.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbver.RightToLeft")));
			this.tbver.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbver.ScrollBars")));
			this.tbver.Size = ((System.Drawing.Size)(resources.GetObject("tbver.Size")));
			this.tbver.TabIndex = ((int)(resources.GetObject("tbver.TabIndex")));
			this.tbver.Text = resources.GetString("tbver.Text");
			this.tbver.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbver.TextAlign")));
			this.tbver.Visible = ((bool)(resources.GetObject("tbver.Visible")));
			this.tbver.WordWrap = ((bool)(resources.GetObject("tbver.WordWrap")));
			this.tbver.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label41
			// 
			this.label41.AccessibleDescription = resources.GetString("label41.AccessibleDescription");
			this.label41.AccessibleName = resources.GetString("label41.AccessibleName");
			this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label41.Anchor")));
			this.label41.AutoSize = ((bool)(resources.GetObject("label41.AutoSize")));
			this.label41.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label41.Dock")));
			this.label41.Enabled = ((bool)(resources.GetObject("label41.Enabled")));
			this.label41.Font = ((System.Drawing.Font)(resources.GetObject("label41.Font")));
			this.label41.Image = ((System.Drawing.Image)(resources.GetObject("label41.Image")));
			this.label41.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label41.ImageAlign")));
			this.label41.ImageIndex = ((int)(resources.GetObject("label41.ImageIndex")));
			this.label41.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label41.ImeMode")));
			this.label41.Location = ((System.Drawing.Point)(resources.GetObject("label41.Location")));
			this.label41.Name = "label41";
			this.label41.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label41.RightToLeft")));
			this.label41.Size = ((System.Drawing.Size)(resources.GetObject("label41.Size")));
			this.label41.TabIndex = ((int)(resources.GetObject("label41.TabIndex")));
			this.label41.Text = resources.GetString("label41.Text");
			this.label41.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label41.TextAlign")));
			this.label41.Visible = ((bool)(resources.GetObject("label41.Visible")));
			// 
			// tbpie
			// 
			this.tbpie.AccessibleDescription = resources.GetString("tbpie.AccessibleDescription");
			this.tbpie.AccessibleName = resources.GetString("tbpie.AccessibleName");
			this.tbpie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbpie.Anchor")));
			this.tbpie.AutoSize = ((bool)(resources.GetObject("tbpie.AutoSize")));
			this.tbpie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpie.BackgroundImage")));
			this.tbpie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbpie.Dock")));
			this.tbpie.Enabled = ((bool)(resources.GetObject("tbpie.Enabled")));
			this.tbpie.Font = ((System.Drawing.Font)(resources.GetObject("tbpie.Font")));
			this.tbpie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbpie.ImeMode")));
			this.tbpie.Location = ((System.Drawing.Point)(resources.GetObject("tbpie.Location")));
			this.tbpie.MaxLength = ((int)(resources.GetObject("tbpie.MaxLength")));
			this.tbpie.Multiline = ((bool)(resources.GetObject("tbpie.Multiline")));
			this.tbpie.Name = "tbpie";
			this.tbpie.PasswordChar = ((char)(resources.GetObject("tbpie.PasswordChar")));
			this.tbpie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbpie.RightToLeft")));
			this.tbpie.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbpie.ScrollBars")));
			this.tbpie.Size = ((System.Drawing.Size)(resources.GetObject("tbpie.Size")));
			this.tbpie.TabIndex = ((int)(resources.GetObject("tbpie.TabIndex")));
			this.tbpie.Text = resources.GetString("tbpie.Text");
			this.tbpie.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbpie.TextAlign")));
			this.tbpie.Visible = ((bool)(resources.GetObject("tbpie.Visible")));
			this.tbpie.WordWrap = ((bool)(resources.GetObject("tbpie.WordWrap")));
			this.tbpie.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label40
			// 
			this.label40.AccessibleDescription = resources.GetString("label40.AccessibleDescription");
			this.label40.AccessibleName = resources.GetString("label40.AccessibleName");
			this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label40.Anchor")));
			this.label40.AutoSize = ((bool)(resources.GetObject("label40.AutoSize")));
			this.label40.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label40.Dock")));
			this.label40.Enabled = ((bool)(resources.GetObject("label40.Enabled")));
			this.label40.Font = ((System.Drawing.Font)(resources.GetObject("label40.Font")));
			this.label40.Image = ((System.Drawing.Image)(resources.GetObject("label40.Image")));
			this.label40.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label40.ImageAlign")));
			this.label40.ImageIndex = ((int)(resources.GetObject("label40.ImageIndex")));
			this.label40.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label40.ImeMode")));
			this.label40.Location = ((System.Drawing.Point)(resources.GetObject("label40.Location")));
			this.label40.Name = "label40";
			this.label40.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label40.RightToLeft")));
			this.label40.Size = ((System.Drawing.Size)(resources.GetObject("label40.Size")));
			this.label40.TabIndex = ((int)(resources.GetObject("label40.TabIndex")));
			this.label40.Text = resources.GetString("label40.Text");
			this.label40.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label40.TextAlign")));
			this.label40.Visible = ((bool)(resources.GetObject("label40.Visible")));
			// 
			// tbres8
			// 
			this.tbres8.AccessibleDescription = resources.GetString("tbres8.AccessibleDescription");
			this.tbres8.AccessibleName = resources.GetString("tbres8.AccessibleName");
			this.tbres8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres8.Anchor")));
			this.tbres8.AutoSize = ((bool)(resources.GetObject("tbres8.AutoSize")));
			this.tbres8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres8.BackgroundImage")));
			this.tbres8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres8.Dock")));
			this.tbres8.Enabled = ((bool)(resources.GetObject("tbres8.Enabled")));
			this.tbres8.Font = ((System.Drawing.Font)(resources.GetObject("tbres8.Font")));
			this.tbres8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres8.ImeMode")));
			this.tbres8.Location = ((System.Drawing.Point)(resources.GetObject("tbres8.Location")));
			this.tbres8.MaxLength = ((int)(resources.GetObject("tbres8.MaxLength")));
			this.tbres8.Multiline = ((bool)(resources.GetObject("tbres8.Multiline")));
			this.tbres8.Name = "tbres8";
			this.tbres8.PasswordChar = ((char)(resources.GetObject("tbres8.PasswordChar")));
			this.tbres8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres8.RightToLeft")));
			this.tbres8.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres8.ScrollBars")));
			this.tbres8.Size = ((System.Drawing.Size)(resources.GetObject("tbres8.Size")));
			this.tbres8.TabIndex = ((int)(resources.GetObject("tbres8.TabIndex")));
			this.tbres8.Text = resources.GetString("tbres8.Text");
			this.tbres8.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres8.TextAlign")));
			this.tbres8.Visible = ((bool)(resources.GetObject("tbres8.Visible")));
			this.tbres8.WordWrap = ((bool)(resources.GetObject("tbres8.WordWrap")));
			this.tbres8.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label33
			// 
			this.label33.AccessibleDescription = resources.GetString("label33.AccessibleDescription");
			this.label33.AccessibleName = resources.GetString("label33.AccessibleName");
			this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label33.Anchor")));
			this.label33.AutoSize = ((bool)(resources.GetObject("label33.AutoSize")));
			this.label33.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label33.Dock")));
			this.label33.Enabled = ((bool)(resources.GetObject("label33.Enabled")));
			this.label33.Font = ((System.Drawing.Font)(resources.GetObject("label33.Font")));
			this.label33.Image = ((System.Drawing.Image)(resources.GetObject("label33.Image")));
			this.label33.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label33.ImageAlign")));
			this.label33.ImageIndex = ((int)(resources.GetObject("label33.ImageIndex")));
			this.label33.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label33.ImeMode")));
			this.label33.Location = ((System.Drawing.Point)(resources.GetObject("label33.Location")));
			this.label33.Name = "label33";
			this.label33.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label33.RightToLeft")));
			this.label33.Size = ((System.Drawing.Size)(resources.GetObject("label33.Size")));
			this.label33.TabIndex = ((int)(resources.GetObject("label33.TabIndex")));
			this.label33.Text = resources.GetString("label33.Text");
			this.label33.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label33.TextAlign")));
			this.label33.Visible = ((bool)(resources.GetObject("label33.Visible")));
			// 
			// tbres7
			// 
			this.tbres7.AccessibleDescription = resources.GetString("tbres7.AccessibleDescription");
			this.tbres7.AccessibleName = resources.GetString("tbres7.AccessibleName");
			this.tbres7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres7.Anchor")));
			this.tbres7.AutoSize = ((bool)(resources.GetObject("tbres7.AutoSize")));
			this.tbres7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres7.BackgroundImage")));
			this.tbres7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres7.Dock")));
			this.tbres7.Enabled = ((bool)(resources.GetObject("tbres7.Enabled")));
			this.tbres7.Font = ((System.Drawing.Font)(resources.GetObject("tbres7.Font")));
			this.tbres7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres7.ImeMode")));
			this.tbres7.Location = ((System.Drawing.Point)(resources.GetObject("tbres7.Location")));
			this.tbres7.MaxLength = ((int)(resources.GetObject("tbres7.MaxLength")));
			this.tbres7.Multiline = ((bool)(resources.GetObject("tbres7.Multiline")));
			this.tbres7.Name = "tbres7";
			this.tbres7.PasswordChar = ((char)(resources.GetObject("tbres7.PasswordChar")));
			this.tbres7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres7.RightToLeft")));
			this.tbres7.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres7.ScrollBars")));
			this.tbres7.Size = ((System.Drawing.Size)(resources.GetObject("tbres7.Size")));
			this.tbres7.TabIndex = ((int)(resources.GetObject("tbres7.TabIndex")));
			this.tbres7.Text = resources.GetString("tbres7.Text");
			this.tbres7.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres7.TextAlign")));
			this.tbres7.Visible = ((bool)(resources.GetObject("tbres7.Visible")));
			this.tbres7.WordWrap = ((bool)(resources.GetObject("tbres7.WordWrap")));
			this.tbres7.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label34
			// 
			this.label34.AccessibleDescription = resources.GetString("label34.AccessibleDescription");
			this.label34.AccessibleName = resources.GetString("label34.AccessibleName");
			this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label34.Anchor")));
			this.label34.AutoSize = ((bool)(resources.GetObject("label34.AutoSize")));
			this.label34.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label34.Dock")));
			this.label34.Enabled = ((bool)(resources.GetObject("label34.Enabled")));
			this.label34.Font = ((System.Drawing.Font)(resources.GetObject("label34.Font")));
			this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
			this.label34.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label34.ImageAlign")));
			this.label34.ImageIndex = ((int)(resources.GetObject("label34.ImageIndex")));
			this.label34.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label34.ImeMode")));
			this.label34.Location = ((System.Drawing.Point)(resources.GetObject("label34.Location")));
			this.label34.Name = "label34";
			this.label34.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label34.RightToLeft")));
			this.label34.Size = ((System.Drawing.Size)(resources.GetObject("label34.Size")));
			this.label34.TabIndex = ((int)(resources.GetObject("label34.TabIndex")));
			this.label34.Text = resources.GetString("label34.Text");
			this.label34.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label34.TextAlign")));
			this.label34.Visible = ((bool)(resources.GetObject("label34.Visible")));
			// 
			// tbres4
			// 
			this.tbres4.AccessibleDescription = resources.GetString("tbres4.AccessibleDescription");
			this.tbres4.AccessibleName = resources.GetString("tbres4.AccessibleName");
			this.tbres4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres4.Anchor")));
			this.tbres4.AutoSize = ((bool)(resources.GetObject("tbres4.AutoSize")));
			this.tbres4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres4.BackgroundImage")));
			this.tbres4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres4.Dock")));
			this.tbres4.Enabled = ((bool)(resources.GetObject("tbres4.Enabled")));
			this.tbres4.Font = ((System.Drawing.Font)(resources.GetObject("tbres4.Font")));
			this.tbres4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres4.ImeMode")));
			this.tbres4.Location = ((System.Drawing.Point)(resources.GetObject("tbres4.Location")));
			this.tbres4.MaxLength = ((int)(resources.GetObject("tbres4.MaxLength")));
			this.tbres4.Multiline = ((bool)(resources.GetObject("tbres4.Multiline")));
			this.tbres4.Name = "tbres4";
			this.tbres4.PasswordChar = ((char)(resources.GetObject("tbres4.PasswordChar")));
			this.tbres4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres4.RightToLeft")));
			this.tbres4.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres4.ScrollBars")));
			this.tbres4.Size = ((System.Drawing.Size)(resources.GetObject("tbres4.Size")));
			this.tbres4.TabIndex = ((int)(resources.GetObject("tbres4.TabIndex")));
			this.tbres4.Text = resources.GetString("tbres4.Text");
			this.tbres4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres4.TextAlign")));
			this.tbres4.Visible = ((bool)(resources.GetObject("tbres4.Visible")));
			this.tbres4.WordWrap = ((bool)(resources.GetObject("tbres4.WordWrap")));
			this.tbres4.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label35
			// 
			this.label35.AccessibleDescription = resources.GetString("label35.AccessibleDescription");
			this.label35.AccessibleName = resources.GetString("label35.AccessibleName");
			this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label35.Anchor")));
			this.label35.AutoSize = ((bool)(resources.GetObject("label35.AutoSize")));
			this.label35.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label35.Dock")));
			this.label35.Enabled = ((bool)(resources.GetObject("label35.Enabled")));
			this.label35.Font = ((System.Drawing.Font)(resources.GetObject("label35.Font")));
			this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
			this.label35.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label35.ImageAlign")));
			this.label35.ImageIndex = ((int)(resources.GetObject("label35.ImageIndex")));
			this.label35.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label35.ImeMode")));
			this.label35.Location = ((System.Drawing.Point)(resources.GetObject("label35.Location")));
			this.label35.Name = "label35";
			this.label35.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label35.RightToLeft")));
			this.label35.Size = ((System.Drawing.Size)(resources.GetObject("label35.Size")));
			this.label35.TabIndex = ((int)(resources.GetObject("label35.TabIndex")));
			this.label35.Text = resources.GetString("label35.Text");
			this.label35.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label35.TextAlign")));
			this.label35.Visible = ((bool)(resources.GetObject("label35.Visible")));
			// 
			// tbres3
			// 
			this.tbres3.AccessibleDescription = resources.GetString("tbres3.AccessibleDescription");
			this.tbres3.AccessibleName = resources.GetString("tbres3.AccessibleName");
			this.tbres3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres3.Anchor")));
			this.tbres3.AutoSize = ((bool)(resources.GetObject("tbres3.AutoSize")));
			this.tbres3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres3.BackgroundImage")));
			this.tbres3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres3.Dock")));
			this.tbres3.Enabled = ((bool)(resources.GetObject("tbres3.Enabled")));
			this.tbres3.Font = ((System.Drawing.Font)(resources.GetObject("tbres3.Font")));
			this.tbres3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres3.ImeMode")));
			this.tbres3.Location = ((System.Drawing.Point)(resources.GetObject("tbres3.Location")));
			this.tbres3.MaxLength = ((int)(resources.GetObject("tbres3.MaxLength")));
			this.tbres3.Multiline = ((bool)(resources.GetObject("tbres3.Multiline")));
			this.tbres3.Name = "tbres3";
			this.tbres3.PasswordChar = ((char)(resources.GetObject("tbres3.PasswordChar")));
			this.tbres3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres3.RightToLeft")));
			this.tbres3.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres3.ScrollBars")));
			this.tbres3.Size = ((System.Drawing.Size)(resources.GetObject("tbres3.Size")));
			this.tbres3.TabIndex = ((int)(resources.GetObject("tbres3.TabIndex")));
			this.tbres3.Text = resources.GetString("tbres3.Text");
			this.tbres3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres3.TextAlign")));
			this.tbres3.Visible = ((bool)(resources.GetObject("tbres3.Visible")));
			this.tbres3.WordWrap = ((bool)(resources.GetObject("tbres3.WordWrap")));
			this.tbres3.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label36
			// 
			this.label36.AccessibleDescription = resources.GetString("label36.AccessibleDescription");
			this.label36.AccessibleName = resources.GetString("label36.AccessibleName");
			this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label36.Anchor")));
			this.label36.AutoSize = ((bool)(resources.GetObject("label36.AutoSize")));
			this.label36.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label36.Dock")));
			this.label36.Enabled = ((bool)(resources.GetObject("label36.Enabled")));
			this.label36.Font = ((System.Drawing.Font)(resources.GetObject("label36.Font")));
			this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
			this.label36.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label36.ImageAlign")));
			this.label36.ImageIndex = ((int)(resources.GetObject("label36.ImageIndex")));
			this.label36.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label36.ImeMode")));
			this.label36.Location = ((System.Drawing.Point)(resources.GetObject("label36.Location")));
			this.label36.Name = "label36";
			this.label36.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label36.RightToLeft")));
			this.label36.Size = ((System.Drawing.Size)(resources.GetObject("label36.Size")));
			this.label36.TabIndex = ((int)(resources.GetObject("label36.TabIndex")));
			this.label36.Text = resources.GetString("label36.Text");
			this.label36.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label36.TextAlign")));
			this.label36.Visible = ((bool)(resources.GetObject("label36.Visible")));
			// 
			// tbres6
			// 
			this.tbres6.AccessibleDescription = resources.GetString("tbres6.AccessibleDescription");
			this.tbres6.AccessibleName = resources.GetString("tbres6.AccessibleName");
			this.tbres6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres6.Anchor")));
			this.tbres6.AutoSize = ((bool)(resources.GetObject("tbres6.AutoSize")));
			this.tbres6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres6.BackgroundImage")));
			this.tbres6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres6.Dock")));
			this.tbres6.Enabled = ((bool)(resources.GetObject("tbres6.Enabled")));
			this.tbres6.Font = ((System.Drawing.Font)(resources.GetObject("tbres6.Font")));
			this.tbres6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres6.ImeMode")));
			this.tbres6.Location = ((System.Drawing.Point)(resources.GetObject("tbres6.Location")));
			this.tbres6.MaxLength = ((int)(resources.GetObject("tbres6.MaxLength")));
			this.tbres6.Multiline = ((bool)(resources.GetObject("tbres6.Multiline")));
			this.tbres6.Name = "tbres6";
			this.tbres6.PasswordChar = ((char)(resources.GetObject("tbres6.PasswordChar")));
			this.tbres6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres6.RightToLeft")));
			this.tbres6.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres6.ScrollBars")));
			this.tbres6.Size = ((System.Drawing.Size)(resources.GetObject("tbres6.Size")));
			this.tbres6.TabIndex = ((int)(resources.GetObject("tbres6.TabIndex")));
			this.tbres6.Text = resources.GetString("tbres6.Text");
			this.tbres6.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres6.TextAlign")));
			this.tbres6.Visible = ((bool)(resources.GetObject("tbres6.Visible")));
			this.tbres6.WordWrap = ((bool)(resources.GetObject("tbres6.WordWrap")));
			this.tbres6.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label29
			// 
			this.label29.AccessibleDescription = resources.GetString("label29.AccessibleDescription");
			this.label29.AccessibleName = resources.GetString("label29.AccessibleName");
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label29.Anchor")));
			this.label29.AutoSize = ((bool)(resources.GetObject("label29.AutoSize")));
			this.label29.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label29.Dock")));
			this.label29.Enabled = ((bool)(resources.GetObject("label29.Enabled")));
			this.label29.Font = ((System.Drawing.Font)(resources.GetObject("label29.Font")));
			this.label29.Image = ((System.Drawing.Image)(resources.GetObject("label29.Image")));
			this.label29.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label29.ImageAlign")));
			this.label29.ImageIndex = ((int)(resources.GetObject("label29.ImageIndex")));
			this.label29.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label29.ImeMode")));
			this.label29.Location = ((System.Drawing.Point)(resources.GetObject("label29.Location")));
			this.label29.Name = "label29";
			this.label29.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label29.RightToLeft")));
			this.label29.Size = ((System.Drawing.Size)(resources.GetObject("label29.Size")));
			this.label29.TabIndex = ((int)(resources.GetObject("label29.TabIndex")));
			this.label29.Text = resources.GetString("label29.Text");
			this.label29.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label29.TextAlign")));
			this.label29.Visible = ((bool)(resources.GetObject("label29.Visible")));
			// 
			// tbres5
			// 
			this.tbres5.AccessibleDescription = resources.GetString("tbres5.AccessibleDescription");
			this.tbres5.AccessibleName = resources.GetString("tbres5.AccessibleName");
			this.tbres5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres5.Anchor")));
			this.tbres5.AutoSize = ((bool)(resources.GetObject("tbres5.AutoSize")));
			this.tbres5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres5.BackgroundImage")));
			this.tbres5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres5.Dock")));
			this.tbres5.Enabled = ((bool)(resources.GetObject("tbres5.Enabled")));
			this.tbres5.Font = ((System.Drawing.Font)(resources.GetObject("tbres5.Font")));
			this.tbres5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres5.ImeMode")));
			this.tbres5.Location = ((System.Drawing.Point)(resources.GetObject("tbres5.Location")));
			this.tbres5.MaxLength = ((int)(resources.GetObject("tbres5.MaxLength")));
			this.tbres5.Multiline = ((bool)(resources.GetObject("tbres5.Multiline")));
			this.tbres5.Name = "tbres5";
			this.tbres5.PasswordChar = ((char)(resources.GetObject("tbres5.PasswordChar")));
			this.tbres5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres5.RightToLeft")));
			this.tbres5.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres5.ScrollBars")));
			this.tbres5.Size = ((System.Drawing.Size)(resources.GetObject("tbres5.Size")));
			this.tbres5.TabIndex = ((int)(resources.GetObject("tbres5.TabIndex")));
			this.tbres5.Text = resources.GetString("tbres5.Text");
			this.tbres5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres5.TextAlign")));
			this.tbres5.Visible = ((bool)(resources.GetObject("tbres5.Visible")));
			this.tbres5.WordWrap = ((bool)(resources.GetObject("tbres5.WordWrap")));
			this.tbres5.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label30
			// 
			this.label30.AccessibleDescription = resources.GetString("label30.AccessibleDescription");
			this.label30.AccessibleName = resources.GetString("label30.AccessibleName");
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label30.Anchor")));
			this.label30.AutoSize = ((bool)(resources.GetObject("label30.AutoSize")));
			this.label30.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label30.Dock")));
			this.label30.Enabled = ((bool)(resources.GetObject("label30.Enabled")));
			this.label30.Font = ((System.Drawing.Font)(resources.GetObject("label30.Font")));
			this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
			this.label30.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label30.ImageAlign")));
			this.label30.ImageIndex = ((int)(resources.GetObject("label30.ImageIndex")));
			this.label30.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label30.ImeMode")));
			this.label30.Location = ((System.Drawing.Point)(resources.GetObject("label30.Location")));
			this.label30.Name = "label30";
			this.label30.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label30.RightToLeft")));
			this.label30.Size = ((System.Drawing.Size)(resources.GetObject("label30.Size")));
			this.label30.TabIndex = ((int)(resources.GetObject("label30.TabIndex")));
			this.label30.Text = resources.GetString("label30.Text");
			this.label30.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label30.TextAlign")));
			this.label30.Visible = ((bool)(resources.GetObject("label30.Visible")));
			// 
			// tbres2
			// 
			this.tbres2.AccessibleDescription = resources.GetString("tbres2.AccessibleDescription");
			this.tbres2.AccessibleName = resources.GetString("tbres2.AccessibleName");
			this.tbres2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres2.Anchor")));
			this.tbres2.AutoSize = ((bool)(resources.GetObject("tbres2.AutoSize")));
			this.tbres2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres2.BackgroundImage")));
			this.tbres2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres2.Dock")));
			this.tbres2.Enabled = ((bool)(resources.GetObject("tbres2.Enabled")));
			this.tbres2.Font = ((System.Drawing.Font)(resources.GetObject("tbres2.Font")));
			this.tbres2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres2.ImeMode")));
			this.tbres2.Location = ((System.Drawing.Point)(resources.GetObject("tbres2.Location")));
			this.tbres2.MaxLength = ((int)(resources.GetObject("tbres2.MaxLength")));
			this.tbres2.Multiline = ((bool)(resources.GetObject("tbres2.Multiline")));
			this.tbres2.Name = "tbres2";
			this.tbres2.PasswordChar = ((char)(resources.GetObject("tbres2.PasswordChar")));
			this.tbres2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres2.RightToLeft")));
			this.tbres2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres2.ScrollBars")));
			this.tbres2.Size = ((System.Drawing.Size)(resources.GetObject("tbres2.Size")));
			this.tbres2.TabIndex = ((int)(resources.GetObject("tbres2.TabIndex")));
			this.tbres2.Text = resources.GetString("tbres2.Text");
			this.tbres2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres2.TextAlign")));
			this.tbres2.Visible = ((bool)(resources.GetObject("tbres2.Visible")));
			this.tbres2.WordWrap = ((bool)(resources.GetObject("tbres2.WordWrap")));
			this.tbres2.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label31
			// 
			this.label31.AccessibleDescription = resources.GetString("label31.AccessibleDescription");
			this.label31.AccessibleName = resources.GetString("label31.AccessibleName");
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label31.Anchor")));
			this.label31.AutoSize = ((bool)(resources.GetObject("label31.AutoSize")));
			this.label31.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label31.Dock")));
			this.label31.Enabled = ((bool)(resources.GetObject("label31.Enabled")));
			this.label31.Font = ((System.Drawing.Font)(resources.GetObject("label31.Font")));
			this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
			this.label31.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label31.ImageAlign")));
			this.label31.ImageIndex = ((int)(resources.GetObject("label31.ImageIndex")));
			this.label31.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label31.ImeMode")));
			this.label31.Location = ((System.Drawing.Point)(resources.GetObject("label31.Location")));
			this.label31.Name = "label31";
			this.label31.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label31.RightToLeft")));
			this.label31.Size = ((System.Drawing.Size)(resources.GetObject("label31.Size")));
			this.label31.TabIndex = ((int)(resources.GetObject("label31.TabIndex")));
			this.label31.Text = resources.GetString("label31.Text");
			this.label31.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label31.TextAlign")));
			this.label31.Visible = ((bool)(resources.GetObject("label31.Visible")));
			// 
			// tbres1
			// 
			this.tbres1.AccessibleDescription = resources.GetString("tbres1.AccessibleDescription");
			this.tbres1.AccessibleName = resources.GetString("tbres1.AccessibleName");
			this.tbres1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbres1.Anchor")));
			this.tbres1.AutoSize = ((bool)(resources.GetObject("tbres1.AutoSize")));
			this.tbres1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbres1.BackgroundImage")));
			this.tbres1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbres1.Dock")));
			this.tbres1.Enabled = ((bool)(resources.GetObject("tbres1.Enabled")));
			this.tbres1.Font = ((System.Drawing.Font)(resources.GetObject("tbres1.Font")));
			this.tbres1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbres1.ImeMode")));
			this.tbres1.Location = ((System.Drawing.Point)(resources.GetObject("tbres1.Location")));
			this.tbres1.MaxLength = ((int)(resources.GetObject("tbres1.MaxLength")));
			this.tbres1.Multiline = ((bool)(resources.GetObject("tbres1.Multiline")));
			this.tbres1.Name = "tbres1";
			this.tbres1.PasswordChar = ((char)(resources.GetObject("tbres1.PasswordChar")));
			this.tbres1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbres1.RightToLeft")));
			this.tbres1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbres1.ScrollBars")));
			this.tbres1.Size = ((System.Drawing.Size)(resources.GetObject("tbres1.Size")));
			this.tbres1.TabIndex = ((int)(resources.GetObject("tbres1.TabIndex")));
			this.tbres1.Text = resources.GetString("tbres1.Text");
			this.tbres1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbres1.TextAlign")));
			this.tbres1.Visible = ((bool)(resources.GetObject("tbres1.Visible")));
			this.tbres1.WordWrap = ((bool)(resources.GetObject("tbres1.WordWrap")));
			this.tbres1.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label32
			// 
			this.label32.AccessibleDescription = resources.GetString("label32.AccessibleDescription");
			this.label32.AccessibleName = resources.GetString("label32.AccessibleName");
			this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label32.Anchor")));
			this.label32.AutoSize = ((bool)(resources.GetObject("label32.AutoSize")));
			this.label32.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label32.Dock")));
			this.label32.Enabled = ((bool)(resources.GetObject("label32.Enabled")));
			this.label32.Font = ((System.Drawing.Font)(resources.GetObject("label32.Font")));
			this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
			this.label32.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label32.ImageAlign")));
			this.label32.ImageIndex = ((int)(resources.GetObject("label32.ImageIndex")));
			this.label32.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label32.ImeMode")));
			this.label32.Location = ((System.Drawing.Point)(resources.GetObject("label32.Location")));
			this.label32.Name = "label32";
			this.label32.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label32.RightToLeft")));
			this.label32.Size = ((System.Drawing.Size)(resources.GetObject("label32.Size")));
			this.label32.TabIndex = ((int)(resources.GetObject("label32.TabIndex")));
			this.label32.Text = resources.GetString("label32.Text");
			this.label32.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label32.TextAlign")));
			this.label32.Visible = ((bool)(resources.GetObject("label32.Visible")));
			// 
			// tbinst2
			// 
			this.tbinst2.AccessibleDescription = resources.GetString("tbinst2.AccessibleDescription");
			this.tbinst2.AccessibleName = resources.GetString("tbinst2.AccessibleName");
			this.tbinst2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinst2.Anchor")));
			this.tbinst2.AutoSize = ((bool)(resources.GetObject("tbinst2.AutoSize")));
			this.tbinst2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinst2.BackgroundImage")));
			this.tbinst2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinst2.Dock")));
			this.tbinst2.Enabled = ((bool)(resources.GetObject("tbinst2.Enabled")));
			this.tbinst2.Font = ((System.Drawing.Font)(resources.GetObject("tbinst2.Font")));
			this.tbinst2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinst2.ImeMode")));
			this.tbinst2.Location = ((System.Drawing.Point)(resources.GetObject("tbinst2.Location")));
			this.tbinst2.MaxLength = ((int)(resources.GetObject("tbinst2.MaxLength")));
			this.tbinst2.Multiline = ((bool)(resources.GetObject("tbinst2.Multiline")));
			this.tbinst2.Name = "tbinst2";
			this.tbinst2.PasswordChar = ((char)(resources.GetObject("tbinst2.PasswordChar")));
			this.tbinst2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinst2.RightToLeft")));
			this.tbinst2.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinst2.ScrollBars")));
			this.tbinst2.Size = ((System.Drawing.Size)(resources.GetObject("tbinst2.Size")));
			this.tbinst2.TabIndex = ((int)(resources.GetObject("tbinst2.TabIndex")));
			this.tbinst2.Text = resources.GetString("tbinst2.Text");
			this.tbinst2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinst2.TextAlign")));
			this.tbinst2.Visible = ((bool)(resources.GetObject("tbinst2.Visible")));
			this.tbinst2.WordWrap = ((bool)(resources.GetObject("tbinst2.WordWrap")));
			this.tbinst2.TextChanged += new System.EventHandler(this.AutoChangeInteraction);
			// 
			// label20
			// 
			this.label20.AccessibleDescription = resources.GetString("label20.AccessibleDescription");
			this.label20.AccessibleName = resources.GetString("label20.AccessibleName");
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label20.Anchor")));
			this.label20.AutoSize = ((bool)(resources.GetObject("label20.AutoSize")));
			this.label20.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label20.Dock")));
			this.label20.Enabled = ((bool)(resources.GetObject("label20.Enabled")));
			this.label20.Font = ((System.Drawing.Font)(resources.GetObject("label20.Font")));
			this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
			this.label20.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label20.ImageAlign")));
			this.label20.ImageIndex = ((int)(resources.GetObject("label20.ImageIndex")));
			this.label20.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label20.ImeMode")));
			this.label20.Location = ((System.Drawing.Point)(resources.GetObject("label20.Location")));
			this.label20.Name = "label20";
			this.label20.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label20.RightToLeft")));
			this.label20.Size = ((System.Drawing.Size)(resources.GetObject("label20.Size")));
			this.label20.TabIndex = ((int)(resources.GetObject("label20.TabIndex")));
			this.label20.Text = resources.GetString("label20.Text");
			this.label20.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label20.TextAlign")));
			this.label20.Visible = ((bool)(resources.GetObject("label20.Visible")));
			// 
			// tbinst1
			// 
			this.tbinst1.AccessibleDescription = resources.GetString("tbinst1.AccessibleDescription");
			this.tbinst1.AccessibleName = resources.GetString("tbinst1.AccessibleName");
			this.tbinst1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinst1.Anchor")));
			this.tbinst1.AutoSize = ((bool)(resources.GetObject("tbinst1.AutoSize")));
			this.tbinst1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinst1.BackgroundImage")));
			this.tbinst1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinst1.Dock")));
			this.tbinst1.Enabled = ((bool)(resources.GetObject("tbinst1.Enabled")));
			this.tbinst1.Font = ((System.Drawing.Font)(resources.GetObject("tbinst1.Font")));
			this.tbinst1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinst1.ImeMode")));
			this.tbinst1.Location = ((System.Drawing.Point)(resources.GetObject("tbinst1.Location")));
			this.tbinst1.MaxLength = ((int)(resources.GetObject("tbinst1.MaxLength")));
			this.tbinst1.Multiline = ((bool)(resources.GetObject("tbinst1.Multiline")));
			this.tbinst1.Name = "tbinst1";
			this.tbinst1.PasswordChar = ((char)(resources.GetObject("tbinst1.PasswordChar")));
			this.tbinst1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinst1.RightToLeft")));
			this.tbinst1.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinst1.ScrollBars")));
			this.tbinst1.Size = ((System.Drawing.Size)(resources.GetObject("tbinst1.Size")));
			this.tbinst1.TabIndex = ((int)(resources.GetObject("tbinst1.TabIndex")));
			this.tbinst1.Text = resources.GetString("tbinst1.Text");
			this.tbinst1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinst1.TextAlign")));
			this.tbinst1.Visible = ((bool)(resources.GetObject("tbinst1.Visible")));
			this.tbinst1.WordWrap = ((bool)(resources.GetObject("tbinst1.WordWrap")));
			this.tbinst1.TextChanged += new System.EventHandler(this.FlagTextChanged);
			// 
			// label24
			// 
			this.label24.AccessibleDescription = resources.GetString("label24.AccessibleDescription");
			this.label24.AccessibleName = resources.GetString("label24.AccessibleName");
			this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label24.Anchor")));
			this.label24.AutoSize = ((bool)(resources.GetObject("label24.AutoSize")));
			this.label24.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label24.Dock")));
			this.label24.Enabled = ((bool)(resources.GetObject("label24.Enabled")));
			this.label24.Font = ((System.Drawing.Font)(resources.GetObject("label24.Font")));
			this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
			this.label24.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label24.ImageAlign")));
			this.label24.ImageIndex = ((int)(resources.GetObject("label24.ImageIndex")));
			this.label24.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label24.ImeMode")));
			this.label24.Location = ((System.Drawing.Point)(resources.GetObject("label24.Location")));
			this.label24.Name = "label24";
			this.label24.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label24.RightToLeft")));
			this.label24.Size = ((System.Drawing.Size)(resources.GetObject("label24.Size")));
			this.label24.TabIndex = ((int)(resources.GetObject("label24.TabIndex")));
			this.label24.Text = resources.GetString("label24.Text");
			this.label24.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label24.TextAlign")));
			this.label24.Visible = ((bool)(resources.GetObject("label24.Visible")));
			// 
			// tbttabaction
			// 
			this.tbttabaction.AccessibleDescription = resources.GetString("tbttabaction.AccessibleDescription");
			this.tbttabaction.AccessibleName = resources.GetString("tbttabaction.AccessibleName");
			this.tbttabaction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbttabaction.Anchor")));
			this.tbttabaction.AutoSize = ((bool)(resources.GetObject("tbttabaction.AutoSize")));
			this.tbttabaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbttabaction.BackgroundImage")));
			this.tbttabaction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbttabaction.Dock")));
			this.tbttabaction.Enabled = ((bool)(resources.GetObject("tbttabaction.Enabled")));
			this.tbttabaction.Font = ((System.Drawing.Font)(resources.GetObject("tbttabaction.Font")));
			this.tbttabaction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbttabaction.ImeMode")));
			this.tbttabaction.Location = ((System.Drawing.Point)(resources.GetObject("tbttabaction.Location")));
			this.tbttabaction.MaxLength = ((int)(resources.GetObject("tbttabaction.MaxLength")));
			this.tbttabaction.Multiline = ((bool)(resources.GetObject("tbttabaction.Multiline")));
			this.tbttabaction.Name = "tbttabaction";
			this.tbttabaction.PasswordChar = ((char)(resources.GetObject("tbttabaction.PasswordChar")));
			this.tbttabaction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbttabaction.RightToLeft")));
			this.tbttabaction.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbttabaction.ScrollBars")));
			this.tbttabaction.Size = ((System.Drawing.Size)(resources.GetObject("tbttabaction.Size")));
			this.tbttabaction.TabIndex = ((int)(resources.GetObject("tbttabaction.TabIndex")));
			this.tbttabaction.Text = resources.GetString("tbttabaction.Text");
			this.tbttabaction.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbttabaction.TextAlign")));
			this.tbttabaction.Visible = ((bool)(resources.GetObject("tbttabaction.Visible")));
			this.tbttabaction.WordWrap = ((bool)(resources.GetObject("tbttabaction.WordWrap")));
			this.tbttabaction.TextChanged += new System.EventHandler(this.ActionOrGuardianChanged);
			// 
			// label21
			// 
			this.label21.AccessibleDescription = resources.GetString("label21.AccessibleDescription");
			this.label21.AccessibleName = resources.GetString("label21.AccessibleName");
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label21.Anchor")));
			this.label21.AutoSize = ((bool)(resources.GetObject("label21.AutoSize")));
			this.label21.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label21.Dock")));
			this.label21.Enabled = ((bool)(resources.GetObject("label21.Enabled")));
			this.label21.Font = ((System.Drawing.Font)(resources.GetObject("label21.Font")));
			this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
			this.label21.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label21.ImageAlign")));
			this.label21.ImageIndex = ((int)(resources.GetObject("label21.ImageIndex")));
			this.label21.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label21.ImeMode")));
			this.label21.Location = ((System.Drawing.Point)(resources.GetObject("label21.Location")));
			this.label21.Name = "label21";
			this.label21.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label21.RightToLeft")));
			this.label21.Size = ((System.Drawing.Size)(resources.GetObject("label21.Size")));
			this.label21.TabIndex = ((int)(resources.GetObject("label21.TabIndex")));
			this.label21.Text = resources.GetString("label21.Text");
			this.label21.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label21.TextAlign")));
			this.label21.Visible = ((bool)(resources.GetObject("label21.Visible")));
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
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddTtab);
			// 
			// llchangettab
			// 
			this.llchangettab.AccessibleDescription = resources.GetString("llchangettab.AccessibleDescription");
			this.llchangettab.AccessibleName = resources.GetString("llchangettab.AccessibleName");
			this.llchangettab.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llchangettab.Anchor")));
			this.llchangettab.AutoSize = ((bool)(resources.GetObject("llchangettab.AutoSize")));
			this.llchangettab.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llchangettab.Dock")));
			this.llchangettab.Enabled = ((bool)(resources.GetObject("llchangettab.Enabled")));
			this.llchangettab.Font = ((System.Drawing.Font)(resources.GetObject("llchangettab.Font")));
			this.llchangettab.Image = ((System.Drawing.Image)(resources.GetObject("llchangettab.Image")));
			this.llchangettab.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangettab.ImageAlign")));
			this.llchangettab.ImageIndex = ((int)(resources.GetObject("llchangettab.ImageIndex")));
			this.llchangettab.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llchangettab.ImeMode")));
			this.llchangettab.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llchangettab.LinkArea")));
			this.llchangettab.Location = ((System.Drawing.Point)(resources.GetObject("llchangettab.Location")));
			this.llchangettab.Name = "llchangettab";
			this.llchangettab.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llchangettab.RightToLeft")));
			this.llchangettab.Size = ((System.Drawing.Size)(resources.GetObject("llchangettab.Size")));
			this.llchangettab.TabIndex = ((int)(resources.GetObject("llchangettab.TabIndex")));
			this.llchangettab.TabStop = true;
			this.llchangettab.Text = resources.GetString("llchangettab.Text");
			this.llchangettab.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangettab.TextAlign")));
			this.llchangettab.Visible = ((bool)(resources.GetObject("llchangettab.Visible")));
			this.llchangettab.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TtabItemChange);
			// 
			// tbttabguard
			// 
			this.tbttabguard.AccessibleDescription = resources.GetString("tbttabguard.AccessibleDescription");
			this.tbttabguard.AccessibleName = resources.GetString("tbttabguard.AccessibleName");
			this.tbttabguard.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbttabguard.Anchor")));
			this.tbttabguard.AutoSize = ((bool)(resources.GetObject("tbttabguard.AutoSize")));
			this.tbttabguard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbttabguard.BackgroundImage")));
			this.tbttabguard.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbttabguard.Dock")));
			this.tbttabguard.Enabled = ((bool)(resources.GetObject("tbttabguard.Enabled")));
			this.tbttabguard.Font = ((System.Drawing.Font)(resources.GetObject("tbttabguard.Font")));
			this.tbttabguard.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbttabguard.ImeMode")));
			this.tbttabguard.Location = ((System.Drawing.Point)(resources.GetObject("tbttabguard.Location")));
			this.tbttabguard.MaxLength = ((int)(resources.GetObject("tbttabguard.MaxLength")));
			this.tbttabguard.Multiline = ((bool)(resources.GetObject("tbttabguard.Multiline")));
			this.tbttabguard.Name = "tbttabguard";
			this.tbttabguard.PasswordChar = ((char)(resources.GetObject("tbttabguard.PasswordChar")));
			this.tbttabguard.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbttabguard.RightToLeft")));
			this.tbttabguard.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbttabguard.ScrollBars")));
			this.tbttabguard.Size = ((System.Drawing.Size)(resources.GetObject("tbttabguard.Size")));
			this.tbttabguard.TabIndex = ((int)(resources.GetObject("tbttabguard.TabIndex")));
			this.tbttabguard.Text = resources.GetString("tbttabguard.Text");
			this.tbttabguard.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbttabguard.TextAlign")));
			this.tbttabguard.Visible = ((bool)(resources.GetObject("tbttabguard.Visible")));
			this.tbttabguard.WordWrap = ((bool)(resources.GetObject("tbttabguard.WordWrap")));
			this.tbttabguard.TextChanged += new System.EventHandler(this.ActionOrGuardianChanged);
			// 
			// label23
			// 
			this.label23.AccessibleDescription = resources.GetString("label23.AccessibleDescription");
			this.label23.AccessibleName = resources.GetString("label23.AccessibleName");
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label23.Anchor")));
			this.label23.AutoSize = ((bool)(resources.GetObject("label23.AutoSize")));
			this.label23.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label23.Dock")));
			this.label23.Enabled = ((bool)(resources.GetObject("label23.Enabled")));
			this.label23.Font = ((System.Drawing.Font)(resources.GetObject("label23.Font")));
			this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
			this.label23.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label23.ImageAlign")));
			this.label23.ImageIndex = ((int)(resources.GetObject("label23.ImageIndex")));
			this.label23.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label23.ImeMode")));
			this.label23.Location = ((System.Drawing.Point)(resources.GetObject("label23.Location")));
			this.label23.Name = "label23";
			this.label23.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label23.RightToLeft")));
			this.label23.Size = ((System.Drawing.Size)(resources.GetObject("label23.Size")));
			this.label23.TabIndex = ((int)(resources.GetObject("label23.TabIndex")));
			this.label23.Text = resources.GetString("label23.Text");
			this.label23.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label23.TextAlign")));
			this.label23.Visible = ((bool)(resources.GetObject("label23.Visible")));
			// 
			// groupBox4
			// 
			this.groupBox4.AccessibleDescription = resources.GetString("groupBox4.AccessibleDescription");
			this.groupBox4.AccessibleName = resources.GetString("groupBox4.AccessibleName");
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox4.Anchor")));
			this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
			this.groupBox4.Controls.Add(this.cbunk3);
			this.groupBox4.Controls.Add(this.cbunk4);
			this.groupBox4.Controls.Add(this.cbunk1);
			this.groupBox4.Controls.Add(this.cbunk2);
			this.groupBox4.Controls.Add(this.cbteens);
			this.groupBox4.Controls.Add(this.cbelders);
			this.groupBox4.Controls.Add(this.cbtodlers);
			this.groupBox4.Controls.Add(this.cbautofirst);
			this.groupBox4.Controls.Add(this.cbdebugmenu);
			this.groupBox4.Controls.Add(this.cbadults);
			this.groupBox4.Controls.Add(this.cbdemochild);
			this.groupBox4.Controls.Add(this.cbchildren);
			this.groupBox4.Controls.Add(this.cbconsecutive);
			this.groupBox4.Controls.Add(this.cbimmediately);
			this.groupBox4.Controls.Add(this.cbjoinable);
			this.groupBox4.Controls.Add(this.cbvisitor);
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
			this.groupBox4.Visible = ((bool)(resources.GetObject("groupBox4.Visible")));
			// 
			// cbunk3
			// 
			this.cbunk3.AccessibleDescription = resources.GetString("cbunk3.AccessibleDescription");
			this.cbunk3.AccessibleName = resources.GetString("cbunk3.AccessibleName");
			this.cbunk3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbunk3.Anchor")));
			this.cbunk3.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbunk3.Appearance")));
			this.cbunk3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbunk3.BackgroundImage")));
			this.cbunk3.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk3.CheckAlign")));
			this.cbunk3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbunk3.Dock")));
			this.cbunk3.Enabled = ((bool)(resources.GetObject("cbunk3.Enabled")));
			this.cbunk3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbunk3.FlatStyle")));
			this.cbunk3.Font = ((System.Drawing.Font)(resources.GetObject("cbunk3.Font")));
			this.cbunk3.Image = ((System.Drawing.Image)(resources.GetObject("cbunk3.Image")));
			this.cbunk3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk3.ImageAlign")));
			this.cbunk3.ImageIndex = ((int)(resources.GetObject("cbunk3.ImageIndex")));
			this.cbunk3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbunk3.ImeMode")));
			this.cbunk3.Location = ((System.Drawing.Point)(resources.GetObject("cbunk3.Location")));
			this.cbunk3.Name = "cbunk3";
			this.cbunk3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbunk3.RightToLeft")));
			this.cbunk3.Size = ((System.Drawing.Size)(resources.GetObject("cbunk3.Size")));
			this.cbunk3.TabIndex = ((int)(resources.GetObject("cbunk3.TabIndex")));
			this.cbunk3.Text = resources.GetString("cbunk3.Text");
			this.cbunk3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk3.TextAlign")));
			this.cbunk3.Visible = ((bool)(resources.GetObject("cbunk3.Visible")));
			this.cbunk3.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbunk4
			// 
			this.cbunk4.AccessibleDescription = resources.GetString("cbunk4.AccessibleDescription");
			this.cbunk4.AccessibleName = resources.GetString("cbunk4.AccessibleName");
			this.cbunk4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbunk4.Anchor")));
			this.cbunk4.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbunk4.Appearance")));
			this.cbunk4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbunk4.BackgroundImage")));
			this.cbunk4.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk4.CheckAlign")));
			this.cbunk4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbunk4.Dock")));
			this.cbunk4.Enabled = ((bool)(resources.GetObject("cbunk4.Enabled")));
			this.cbunk4.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbunk4.FlatStyle")));
			this.cbunk4.Font = ((System.Drawing.Font)(resources.GetObject("cbunk4.Font")));
			this.cbunk4.Image = ((System.Drawing.Image)(resources.GetObject("cbunk4.Image")));
			this.cbunk4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk4.ImageAlign")));
			this.cbunk4.ImageIndex = ((int)(resources.GetObject("cbunk4.ImageIndex")));
			this.cbunk4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbunk4.ImeMode")));
			this.cbunk4.Location = ((System.Drawing.Point)(resources.GetObject("cbunk4.Location")));
			this.cbunk4.Name = "cbunk4";
			this.cbunk4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbunk4.RightToLeft")));
			this.cbunk4.Size = ((System.Drawing.Size)(resources.GetObject("cbunk4.Size")));
			this.cbunk4.TabIndex = ((int)(resources.GetObject("cbunk4.TabIndex")));
			this.cbunk4.Text = resources.GetString("cbunk4.Text");
			this.cbunk4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk4.TextAlign")));
			this.cbunk4.Visible = ((bool)(resources.GetObject("cbunk4.Visible")));
			this.cbunk4.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbunk1
			// 
			this.cbunk1.AccessibleDescription = resources.GetString("cbunk1.AccessibleDescription");
			this.cbunk1.AccessibleName = resources.GetString("cbunk1.AccessibleName");
			this.cbunk1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbunk1.Anchor")));
			this.cbunk1.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbunk1.Appearance")));
			this.cbunk1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbunk1.BackgroundImage")));
			this.cbunk1.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk1.CheckAlign")));
			this.cbunk1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbunk1.Dock")));
			this.cbunk1.Enabled = ((bool)(resources.GetObject("cbunk1.Enabled")));
			this.cbunk1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbunk1.FlatStyle")));
			this.cbunk1.Font = ((System.Drawing.Font)(resources.GetObject("cbunk1.Font")));
			this.cbunk1.Image = ((System.Drawing.Image)(resources.GetObject("cbunk1.Image")));
			this.cbunk1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk1.ImageAlign")));
			this.cbunk1.ImageIndex = ((int)(resources.GetObject("cbunk1.ImageIndex")));
			this.cbunk1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbunk1.ImeMode")));
			this.cbunk1.Location = ((System.Drawing.Point)(resources.GetObject("cbunk1.Location")));
			this.cbunk1.Name = "cbunk1";
			this.cbunk1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbunk1.RightToLeft")));
			this.cbunk1.Size = ((System.Drawing.Size)(resources.GetObject("cbunk1.Size")));
			this.cbunk1.TabIndex = ((int)(resources.GetObject("cbunk1.TabIndex")));
			this.cbunk1.Text = resources.GetString("cbunk1.Text");
			this.cbunk1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk1.TextAlign")));
			this.cbunk1.Visible = ((bool)(resources.GetObject("cbunk1.Visible")));
			this.cbunk1.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbunk2
			// 
			this.cbunk2.AccessibleDescription = resources.GetString("cbunk2.AccessibleDescription");
			this.cbunk2.AccessibleName = resources.GetString("cbunk2.AccessibleName");
			this.cbunk2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbunk2.Anchor")));
			this.cbunk2.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbunk2.Appearance")));
			this.cbunk2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbunk2.BackgroundImage")));
			this.cbunk2.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk2.CheckAlign")));
			this.cbunk2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbunk2.Dock")));
			this.cbunk2.Enabled = ((bool)(resources.GetObject("cbunk2.Enabled")));
			this.cbunk2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbunk2.FlatStyle")));
			this.cbunk2.Font = ((System.Drawing.Font)(resources.GetObject("cbunk2.Font")));
			this.cbunk2.Image = ((System.Drawing.Image)(resources.GetObject("cbunk2.Image")));
			this.cbunk2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk2.ImageAlign")));
			this.cbunk2.ImageIndex = ((int)(resources.GetObject("cbunk2.ImageIndex")));
			this.cbunk2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbunk2.ImeMode")));
			this.cbunk2.Location = ((System.Drawing.Point)(resources.GetObject("cbunk2.Location")));
			this.cbunk2.Name = "cbunk2";
			this.cbunk2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbunk2.RightToLeft")));
			this.cbunk2.Size = ((System.Drawing.Size)(resources.GetObject("cbunk2.Size")));
			this.cbunk2.TabIndex = ((int)(resources.GetObject("cbunk2.TabIndex")));
			this.cbunk2.Text = resources.GetString("cbunk2.Text");
			this.cbunk2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbunk2.TextAlign")));
			this.cbunk2.Visible = ((bool)(resources.GetObject("cbunk2.Visible")));
			this.cbunk2.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbteens
			// 
			this.cbteens.AccessibleDescription = resources.GetString("cbteens.AccessibleDescription");
			this.cbteens.AccessibleName = resources.GetString("cbteens.AccessibleName");
			this.cbteens.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbteens.Anchor")));
			this.cbteens.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbteens.Appearance")));
			this.cbteens.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbteens.BackgroundImage")));
			this.cbteens.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbteens.CheckAlign")));
			this.cbteens.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbteens.Dock")));
			this.cbteens.Enabled = ((bool)(resources.GetObject("cbteens.Enabled")));
			this.cbteens.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbteens.FlatStyle")));
			this.cbteens.Font = ((System.Drawing.Font)(resources.GetObject("cbteens.Font")));
			this.cbteens.Image = ((System.Drawing.Image)(resources.GetObject("cbteens.Image")));
			this.cbteens.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbteens.ImageAlign")));
			this.cbteens.ImageIndex = ((int)(resources.GetObject("cbteens.ImageIndex")));
			this.cbteens.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbteens.ImeMode")));
			this.cbteens.Location = ((System.Drawing.Point)(resources.GetObject("cbteens.Location")));
			this.cbteens.Name = "cbteens";
			this.cbteens.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbteens.RightToLeft")));
			this.cbteens.Size = ((System.Drawing.Size)(resources.GetObject("cbteens.Size")));
			this.cbteens.TabIndex = ((int)(resources.GetObject("cbteens.TabIndex")));
			this.cbteens.Text = resources.GetString("cbteens.Text");
			this.cbteens.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbteens.TextAlign")));
			this.cbteens.Visible = ((bool)(resources.GetObject("cbteens.Visible")));
			this.cbteens.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbelders
			// 
			this.cbelders.AccessibleDescription = resources.GetString("cbelders.AccessibleDescription");
			this.cbelders.AccessibleName = resources.GetString("cbelders.AccessibleName");
			this.cbelders.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbelders.Anchor")));
			this.cbelders.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbelders.Appearance")));
			this.cbelders.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbelders.BackgroundImage")));
			this.cbelders.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbelders.CheckAlign")));
			this.cbelders.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbelders.Dock")));
			this.cbelders.Enabled = ((bool)(resources.GetObject("cbelders.Enabled")));
			this.cbelders.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbelders.FlatStyle")));
			this.cbelders.Font = ((System.Drawing.Font)(resources.GetObject("cbelders.Font")));
			this.cbelders.Image = ((System.Drawing.Image)(resources.GetObject("cbelders.Image")));
			this.cbelders.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbelders.ImageAlign")));
			this.cbelders.ImageIndex = ((int)(resources.GetObject("cbelders.ImageIndex")));
			this.cbelders.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbelders.ImeMode")));
			this.cbelders.Location = ((System.Drawing.Point)(resources.GetObject("cbelders.Location")));
			this.cbelders.Name = "cbelders";
			this.cbelders.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbelders.RightToLeft")));
			this.cbelders.Size = ((System.Drawing.Size)(resources.GetObject("cbelders.Size")));
			this.cbelders.TabIndex = ((int)(resources.GetObject("cbelders.TabIndex")));
			this.cbelders.Text = resources.GetString("cbelders.Text");
			this.cbelders.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbelders.TextAlign")));
			this.cbelders.Visible = ((bool)(resources.GetObject("cbelders.Visible")));
			this.cbelders.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbtodlers
			// 
			this.cbtodlers.AccessibleDescription = resources.GetString("cbtodlers.AccessibleDescription");
			this.cbtodlers.AccessibleName = resources.GetString("cbtodlers.AccessibleName");
			this.cbtodlers.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtodlers.Anchor")));
			this.cbtodlers.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbtodlers.Appearance")));
			this.cbtodlers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtodlers.BackgroundImage")));
			this.cbtodlers.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbtodlers.CheckAlign")));
			this.cbtodlers.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtodlers.Dock")));
			this.cbtodlers.Enabled = ((bool)(resources.GetObject("cbtodlers.Enabled")));
			this.cbtodlers.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbtodlers.FlatStyle")));
			this.cbtodlers.Font = ((System.Drawing.Font)(resources.GetObject("cbtodlers.Font")));
			this.cbtodlers.Image = ((System.Drawing.Image)(resources.GetObject("cbtodlers.Image")));
			this.cbtodlers.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbtodlers.ImageAlign")));
			this.cbtodlers.ImageIndex = ((int)(resources.GetObject("cbtodlers.ImageIndex")));
			this.cbtodlers.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtodlers.ImeMode")));
			this.cbtodlers.Location = ((System.Drawing.Point)(resources.GetObject("cbtodlers.Location")));
			this.cbtodlers.Name = "cbtodlers";
			this.cbtodlers.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtodlers.RightToLeft")));
			this.cbtodlers.Size = ((System.Drawing.Size)(resources.GetObject("cbtodlers.Size")));
			this.cbtodlers.TabIndex = ((int)(resources.GetObject("cbtodlers.TabIndex")));
			this.cbtodlers.Text = resources.GetString("cbtodlers.Text");
			this.cbtodlers.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbtodlers.TextAlign")));
			this.cbtodlers.Visible = ((bool)(resources.GetObject("cbtodlers.Visible")));
			this.cbtodlers.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbautofirst
			// 
			this.cbautofirst.AccessibleDescription = resources.GetString("cbautofirst.AccessibleDescription");
			this.cbautofirst.AccessibleName = resources.GetString("cbautofirst.AccessibleName");
			this.cbautofirst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbautofirst.Anchor")));
			this.cbautofirst.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbautofirst.Appearance")));
			this.cbautofirst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbautofirst.BackgroundImage")));
			this.cbautofirst.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautofirst.CheckAlign")));
			this.cbautofirst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbautofirst.Dock")));
			this.cbautofirst.Enabled = ((bool)(resources.GetObject("cbautofirst.Enabled")));
			this.cbautofirst.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbautofirst.FlatStyle")));
			this.cbautofirst.Font = ((System.Drawing.Font)(resources.GetObject("cbautofirst.Font")));
			this.cbautofirst.Image = ((System.Drawing.Image)(resources.GetObject("cbautofirst.Image")));
			this.cbautofirst.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautofirst.ImageAlign")));
			this.cbautofirst.ImageIndex = ((int)(resources.GetObject("cbautofirst.ImageIndex")));
			this.cbautofirst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbautofirst.ImeMode")));
			this.cbautofirst.Location = ((System.Drawing.Point)(resources.GetObject("cbautofirst.Location")));
			this.cbautofirst.Name = "cbautofirst";
			this.cbautofirst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbautofirst.RightToLeft")));
			this.cbautofirst.Size = ((System.Drawing.Size)(resources.GetObject("cbautofirst.Size")));
			this.cbautofirst.TabIndex = ((int)(resources.GetObject("cbautofirst.TabIndex")));
			this.cbautofirst.Text = resources.GetString("cbautofirst.Text");
			this.cbautofirst.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbautofirst.TextAlign")));
			this.cbautofirst.Visible = ((bool)(resources.GetObject("cbautofirst.Visible")));
			this.cbautofirst.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbdebugmenu
			// 
			this.cbdebugmenu.AccessibleDescription = resources.GetString("cbdebugmenu.AccessibleDescription");
			this.cbdebugmenu.AccessibleName = resources.GetString("cbdebugmenu.AccessibleName");
			this.cbdebugmenu.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbdebugmenu.Anchor")));
			this.cbdebugmenu.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbdebugmenu.Appearance")));
			this.cbdebugmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbdebugmenu.BackgroundImage")));
			this.cbdebugmenu.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebugmenu.CheckAlign")));
			this.cbdebugmenu.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbdebugmenu.Dock")));
			this.cbdebugmenu.Enabled = ((bool)(resources.GetObject("cbdebugmenu.Enabled")));
			this.cbdebugmenu.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbdebugmenu.FlatStyle")));
			this.cbdebugmenu.Font = ((System.Drawing.Font)(resources.GetObject("cbdebugmenu.Font")));
			this.cbdebugmenu.Image = ((System.Drawing.Image)(resources.GetObject("cbdebugmenu.Image")));
			this.cbdebugmenu.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebugmenu.ImageAlign")));
			this.cbdebugmenu.ImageIndex = ((int)(resources.GetObject("cbdebugmenu.ImageIndex")));
			this.cbdebugmenu.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbdebugmenu.ImeMode")));
			this.cbdebugmenu.Location = ((System.Drawing.Point)(resources.GetObject("cbdebugmenu.Location")));
			this.cbdebugmenu.Name = "cbdebugmenu";
			this.cbdebugmenu.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbdebugmenu.RightToLeft")));
			this.cbdebugmenu.Size = ((System.Drawing.Size)(resources.GetObject("cbdebugmenu.Size")));
			this.cbdebugmenu.TabIndex = ((int)(resources.GetObject("cbdebugmenu.TabIndex")));
			this.cbdebugmenu.Text = resources.GetString("cbdebugmenu.Text");
			this.cbdebugmenu.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdebugmenu.TextAlign")));
			this.cbdebugmenu.Visible = ((bool)(resources.GetObject("cbdebugmenu.Visible")));
			this.cbdebugmenu.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbadults
			// 
			this.cbadults.AccessibleDescription = resources.GetString("cbadults.AccessibleDescription");
			this.cbadults.AccessibleName = resources.GetString("cbadults.AccessibleName");
			this.cbadults.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbadults.Anchor")));
			this.cbadults.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbadults.Appearance")));
			this.cbadults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbadults.BackgroundImage")));
			this.cbadults.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbadults.CheckAlign")));
			this.cbadults.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbadults.Dock")));
			this.cbadults.Enabled = ((bool)(resources.GetObject("cbadults.Enabled")));
			this.cbadults.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbadults.FlatStyle")));
			this.cbadults.Font = ((System.Drawing.Font)(resources.GetObject("cbadults.Font")));
			this.cbadults.Image = ((System.Drawing.Image)(resources.GetObject("cbadults.Image")));
			this.cbadults.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbadults.ImageAlign")));
			this.cbadults.ImageIndex = ((int)(resources.GetObject("cbadults.ImageIndex")));
			this.cbadults.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbadults.ImeMode")));
			this.cbadults.Location = ((System.Drawing.Point)(resources.GetObject("cbadults.Location")));
			this.cbadults.Name = "cbadults";
			this.cbadults.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbadults.RightToLeft")));
			this.cbadults.Size = ((System.Drawing.Size)(resources.GetObject("cbadults.Size")));
			this.cbadults.TabIndex = ((int)(resources.GetObject("cbadults.TabIndex")));
			this.cbadults.Text = resources.GetString("cbadults.Text");
			this.cbadults.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbadults.TextAlign")));
			this.cbadults.Visible = ((bool)(resources.GetObject("cbadults.Visible")));
			this.cbadults.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbdemochild
			// 
			this.cbdemochild.AccessibleDescription = resources.GetString("cbdemochild.AccessibleDescription");
			this.cbdemochild.AccessibleName = resources.GetString("cbdemochild.AccessibleName");
			this.cbdemochild.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbdemochild.Anchor")));
			this.cbdemochild.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbdemochild.Appearance")));
			this.cbdemochild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbdemochild.BackgroundImage")));
			this.cbdemochild.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdemochild.CheckAlign")));
			this.cbdemochild.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbdemochild.Dock")));
			this.cbdemochild.Enabled = ((bool)(resources.GetObject("cbdemochild.Enabled")));
			this.cbdemochild.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbdemochild.FlatStyle")));
			this.cbdemochild.Font = ((System.Drawing.Font)(resources.GetObject("cbdemochild.Font")));
			this.cbdemochild.Image = ((System.Drawing.Image)(resources.GetObject("cbdemochild.Image")));
			this.cbdemochild.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdemochild.ImageAlign")));
			this.cbdemochild.ImageIndex = ((int)(resources.GetObject("cbdemochild.ImageIndex")));
			this.cbdemochild.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbdemochild.ImeMode")));
			this.cbdemochild.Location = ((System.Drawing.Point)(resources.GetObject("cbdemochild.Location")));
			this.cbdemochild.Name = "cbdemochild";
			this.cbdemochild.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbdemochild.RightToLeft")));
			this.cbdemochild.Size = ((System.Drawing.Size)(resources.GetObject("cbdemochild.Size")));
			this.cbdemochild.TabIndex = ((int)(resources.GetObject("cbdemochild.TabIndex")));
			this.cbdemochild.Text = resources.GetString("cbdemochild.Text");
			this.cbdemochild.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdemochild.TextAlign")));
			this.cbdemochild.Visible = ((bool)(resources.GetObject("cbdemochild.Visible")));
			this.cbdemochild.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbchildren
			// 
			this.cbchildren.AccessibleDescription = resources.GetString("cbchildren.AccessibleDescription");
			this.cbchildren.AccessibleName = resources.GetString("cbchildren.AccessibleName");
			this.cbchildren.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbchildren.Anchor")));
			this.cbchildren.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbchildren.Appearance")));
			this.cbchildren.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbchildren.BackgroundImage")));
			this.cbchildren.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbchildren.CheckAlign")));
			this.cbchildren.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbchildren.Dock")));
			this.cbchildren.Enabled = ((bool)(resources.GetObject("cbchildren.Enabled")));
			this.cbchildren.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbchildren.FlatStyle")));
			this.cbchildren.Font = ((System.Drawing.Font)(resources.GetObject("cbchildren.Font")));
			this.cbchildren.Image = ((System.Drawing.Image)(resources.GetObject("cbchildren.Image")));
			this.cbchildren.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbchildren.ImageAlign")));
			this.cbchildren.ImageIndex = ((int)(resources.GetObject("cbchildren.ImageIndex")));
			this.cbchildren.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbchildren.ImeMode")));
			this.cbchildren.Location = ((System.Drawing.Point)(resources.GetObject("cbchildren.Location")));
			this.cbchildren.Name = "cbchildren";
			this.cbchildren.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbchildren.RightToLeft")));
			this.cbchildren.Size = ((System.Drawing.Size)(resources.GetObject("cbchildren.Size")));
			this.cbchildren.TabIndex = ((int)(resources.GetObject("cbchildren.TabIndex")));
			this.cbchildren.Text = resources.GetString("cbchildren.Text");
			this.cbchildren.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbchildren.TextAlign")));
			this.cbchildren.Visible = ((bool)(resources.GetObject("cbchildren.Visible")));
			this.cbchildren.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbconsecutive
			// 
			this.cbconsecutive.AccessibleDescription = resources.GetString("cbconsecutive.AccessibleDescription");
			this.cbconsecutive.AccessibleName = resources.GetString("cbconsecutive.AccessibleName");
			this.cbconsecutive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbconsecutive.Anchor")));
			this.cbconsecutive.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbconsecutive.Appearance")));
			this.cbconsecutive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbconsecutive.BackgroundImage")));
			this.cbconsecutive.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbconsecutive.CheckAlign")));
			this.cbconsecutive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbconsecutive.Dock")));
			this.cbconsecutive.Enabled = ((bool)(resources.GetObject("cbconsecutive.Enabled")));
			this.cbconsecutive.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbconsecutive.FlatStyle")));
			this.cbconsecutive.Font = ((System.Drawing.Font)(resources.GetObject("cbconsecutive.Font")));
			this.cbconsecutive.Image = ((System.Drawing.Image)(resources.GetObject("cbconsecutive.Image")));
			this.cbconsecutive.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbconsecutive.ImageAlign")));
			this.cbconsecutive.ImageIndex = ((int)(resources.GetObject("cbconsecutive.ImageIndex")));
			this.cbconsecutive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbconsecutive.ImeMode")));
			this.cbconsecutive.Location = ((System.Drawing.Point)(resources.GetObject("cbconsecutive.Location")));
			this.cbconsecutive.Name = "cbconsecutive";
			this.cbconsecutive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbconsecutive.RightToLeft")));
			this.cbconsecutive.Size = ((System.Drawing.Size)(resources.GetObject("cbconsecutive.Size")));
			this.cbconsecutive.TabIndex = ((int)(resources.GetObject("cbconsecutive.TabIndex")));
			this.cbconsecutive.Text = resources.GetString("cbconsecutive.Text");
			this.cbconsecutive.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbconsecutive.TextAlign")));
			this.cbconsecutive.Visible = ((bool)(resources.GetObject("cbconsecutive.Visible")));
			this.cbconsecutive.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbimmediately
			// 
			this.cbimmediately.AccessibleDescription = resources.GetString("cbimmediately.AccessibleDescription");
			this.cbimmediately.AccessibleName = resources.GetString("cbimmediately.AccessibleName");
			this.cbimmediately.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbimmediately.Anchor")));
			this.cbimmediately.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbimmediately.Appearance")));
			this.cbimmediately.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbimmediately.BackgroundImage")));
			this.cbimmediately.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbimmediately.CheckAlign")));
			this.cbimmediately.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbimmediately.Dock")));
			this.cbimmediately.Enabled = ((bool)(resources.GetObject("cbimmediately.Enabled")));
			this.cbimmediately.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbimmediately.FlatStyle")));
			this.cbimmediately.Font = ((System.Drawing.Font)(resources.GetObject("cbimmediately.Font")));
			this.cbimmediately.Image = ((System.Drawing.Image)(resources.GetObject("cbimmediately.Image")));
			this.cbimmediately.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbimmediately.ImageAlign")));
			this.cbimmediately.ImageIndex = ((int)(resources.GetObject("cbimmediately.ImageIndex")));
			this.cbimmediately.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbimmediately.ImeMode")));
			this.cbimmediately.Location = ((System.Drawing.Point)(resources.GetObject("cbimmediately.Location")));
			this.cbimmediately.Name = "cbimmediately";
			this.cbimmediately.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbimmediately.RightToLeft")));
			this.cbimmediately.Size = ((System.Drawing.Size)(resources.GetObject("cbimmediately.Size")));
			this.cbimmediately.TabIndex = ((int)(resources.GetObject("cbimmediately.TabIndex")));
			this.cbimmediately.Text = resources.GetString("cbimmediately.Text");
			this.cbimmediately.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbimmediately.TextAlign")));
			this.cbimmediately.Visible = ((bool)(resources.GetObject("cbimmediately.Visible")));
			this.cbimmediately.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbjoinable
			// 
			this.cbjoinable.AccessibleDescription = resources.GetString("cbjoinable.AccessibleDescription");
			this.cbjoinable.AccessibleName = resources.GetString("cbjoinable.AccessibleName");
			this.cbjoinable.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbjoinable.Anchor")));
			this.cbjoinable.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbjoinable.Appearance")));
			this.cbjoinable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbjoinable.BackgroundImage")));
			this.cbjoinable.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjoinable.CheckAlign")));
			this.cbjoinable.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbjoinable.Dock")));
			this.cbjoinable.Enabled = ((bool)(resources.GetObject("cbjoinable.Enabled")));
			this.cbjoinable.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbjoinable.FlatStyle")));
			this.cbjoinable.Font = ((System.Drawing.Font)(resources.GetObject("cbjoinable.Font")));
			this.cbjoinable.Image = ((System.Drawing.Image)(resources.GetObject("cbjoinable.Image")));
			this.cbjoinable.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjoinable.ImageAlign")));
			this.cbjoinable.ImageIndex = ((int)(resources.GetObject("cbjoinable.ImageIndex")));
			this.cbjoinable.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbjoinable.ImeMode")));
			this.cbjoinable.Location = ((System.Drawing.Point)(resources.GetObject("cbjoinable.Location")));
			this.cbjoinable.Name = "cbjoinable";
			this.cbjoinable.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbjoinable.RightToLeft")));
			this.cbjoinable.Size = ((System.Drawing.Size)(resources.GetObject("cbjoinable.Size")));
			this.cbjoinable.TabIndex = ((int)(resources.GetObject("cbjoinable.TabIndex")));
			this.cbjoinable.Text = resources.GetString("cbjoinable.Text");
			this.cbjoinable.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbjoinable.TextAlign")));
			this.cbjoinable.Visible = ((bool)(resources.GetObject("cbjoinable.Visible")));
			this.cbjoinable.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cbvisitor
			// 
			this.cbvisitor.AccessibleDescription = resources.GetString("cbvisitor.AccessibleDescription");
			this.cbvisitor.AccessibleName = resources.GetString("cbvisitor.AccessibleName");
			this.cbvisitor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbvisitor.Anchor")));
			this.cbvisitor.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbvisitor.Appearance")));
			this.cbvisitor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbvisitor.BackgroundImage")));
			this.cbvisitor.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvisitor.CheckAlign")));
			this.cbvisitor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbvisitor.Dock")));
			this.cbvisitor.Enabled = ((bool)(resources.GetObject("cbvisitor.Enabled")));
			this.cbvisitor.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbvisitor.FlatStyle")));
			this.cbvisitor.Font = ((System.Drawing.Font)(resources.GetObject("cbvisitor.Font")));
			this.cbvisitor.Image = ((System.Drawing.Image)(resources.GetObject("cbvisitor.Image")));
			this.cbvisitor.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvisitor.ImageAlign")));
			this.cbvisitor.ImageIndex = ((int)(resources.GetObject("cbvisitor.ImageIndex")));
			this.cbvisitor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbvisitor.ImeMode")));
			this.cbvisitor.Location = ((System.Drawing.Point)(resources.GetObject("cbvisitor.Location")));
			this.cbvisitor.Name = "cbvisitor";
			this.cbvisitor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbvisitor.RightToLeft")));
			this.cbvisitor.Size = ((System.Drawing.Size)(resources.GetObject("cbvisitor.Size")));
			this.cbvisitor.TabIndex = ((int)(resources.GetObject("cbvisitor.TabIndex")));
			this.cbvisitor.Text = resources.GetString("cbvisitor.Text");
			this.cbvisitor.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvisitor.TextAlign")));
			this.cbvisitor.Visible = ((bool)(resources.GetObject("cbvisitor.Visible")));
			this.cbvisitor.CheckedChanged += new System.EventHandler(this.UpdateFlagsValue);
			// 
			// cmcopy
			// 
			this.cmcopy.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																				   this.menuItem1,
																				   this.menuItem2});
			this.cmcopy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cmcopy.RightToLeft")));
			// 
			// menuItem1
			// 
			this.menuItem1.Enabled = ((bool)(resources.GetObject("menuItem1.Enabled")));
			this.menuItem1.Index = 0;
			this.menuItem1.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem1.Shortcut")));
			this.menuItem1.ShowShortcut = ((bool)(resources.GetObject("menuItem1.ShowShortcut")));
			this.menuItem1.Text = resources.GetString("menuItem1.Text");
			this.menuItem1.Visible = ((bool)(resources.GetObject("menuItem1.Visible")));
			this.menuItem1.Click += new System.EventHandler(this.CopyInstruction);
			// 
			// menuItem2
			// 
			this.menuItem2.Enabled = ((bool)(resources.GetObject("menuItem2.Enabled")));
			this.menuItem2.Index = 1;
			this.menuItem2.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("menuItem2.Shortcut")));
			this.menuItem2.ShowShortcut = ((bool)(resources.GetObject("menuItem2.ShowShortcut")));
			this.menuItem2.Text = resources.GetString("menuItem2.Text");
			this.menuItem2.Visible = ((bool)(resources.GetObject("menuItem2.Visible")));
			this.menuItem2.Click += new System.EventHandler(this.InsertInstruction);
			// 
			// pnGlob
			// 
			this.pnGlob.AccessibleDescription = resources.GetString("pnGlob.AccessibleDescription");
			this.pnGlob.AccessibleName = resources.GetString("pnGlob.AccessibleName");
			this.pnGlob.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnGlob.Anchor")));
			this.pnGlob.AutoScroll = ((bool)(resources.GetObject("pnGlob.AutoScroll")));
			this.pnGlob.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnGlob.AutoScrollMargin")));
			this.pnGlob.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnGlob.AutoScrollMinSize")));
			this.pnGlob.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnGlob.BackgroundImage")));
			this.pnGlob.Controls.Add(this.tbgroup);
			this.pnGlob.Controls.Add(this.label43);
			this.pnGlob.Controls.Add(this.cbseminame);
			this.pnGlob.Controls.Add(this.label42);
			this.pnGlob.Controls.Add(this.button3);
			this.pnGlob.Controls.Add(this.panel6);
			this.pnGlob.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnGlob.Dock")));
			this.pnGlob.Enabled = ((bool)(resources.GetObject("pnGlob.Enabled")));
			this.pnGlob.Font = ((System.Drawing.Font)(resources.GetObject("pnGlob.Font")));
			this.pnGlob.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnGlob.ImeMode")));
			this.pnGlob.Location = ((System.Drawing.Point)(resources.GetObject("pnGlob.Location")));
			this.pnGlob.Name = "pnGlob";
			this.pnGlob.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnGlob.RightToLeft")));
			this.pnGlob.Size = ((System.Drawing.Size)(resources.GetObject("pnGlob.Size")));
			this.pnGlob.TabIndex = ((int)(resources.GetObject("pnGlob.TabIndex")));
			this.pnGlob.Text = resources.GetString("pnGlob.Text");
			this.pnGlob.Visible = ((bool)(resources.GetObject("pnGlob.Visible")));
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
			this.tbgroup.ReadOnly = true;
			this.tbgroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgroup.RightToLeft")));
			this.tbgroup.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgroup.ScrollBars")));
			this.tbgroup.Size = ((System.Drawing.Size)(resources.GetObject("tbgroup.Size")));
			this.tbgroup.TabIndex = ((int)(resources.GetObject("tbgroup.TabIndex")));
			this.tbgroup.Text = resources.GetString("tbgroup.Text");
			this.tbgroup.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgroup.TextAlign")));
			this.tbgroup.Visible = ((bool)(resources.GetObject("tbgroup.Visible")));
			this.tbgroup.WordWrap = ((bool)(resources.GetObject("tbgroup.WordWrap")));
			// 
			// label43
			// 
			this.label43.AccessibleDescription = resources.GetString("label43.AccessibleDescription");
			this.label43.AccessibleName = resources.GetString("label43.AccessibleName");
			this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label43.Anchor")));
			this.label43.AutoSize = ((bool)(resources.GetObject("label43.AutoSize")));
			this.label43.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label43.Dock")));
			this.label43.Enabled = ((bool)(resources.GetObject("label43.Enabled")));
			this.label43.Font = ((System.Drawing.Font)(resources.GetObject("label43.Font")));
			this.label43.Image = ((System.Drawing.Image)(resources.GetObject("label43.Image")));
			this.label43.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label43.ImageAlign")));
			this.label43.ImageIndex = ((int)(resources.GetObject("label43.ImageIndex")));
			this.label43.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label43.ImeMode")));
			this.label43.Location = ((System.Drawing.Point)(resources.GetObject("label43.Location")));
			this.label43.Name = "label43";
			this.label43.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label43.RightToLeft")));
			this.label43.Size = ((System.Drawing.Size)(resources.GetObject("label43.Size")));
			this.label43.TabIndex = ((int)(resources.GetObject("label43.TabIndex")));
			this.label43.Text = resources.GetString("label43.Text");
			this.label43.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label43.TextAlign")));
			this.label43.Visible = ((bool)(resources.GetObject("label43.Visible")));
			// 
			// cbseminame
			// 
			this.cbseminame.AccessibleDescription = resources.GetString("cbseminame.AccessibleDescription");
			this.cbseminame.AccessibleName = resources.GetString("cbseminame.AccessibleName");
			this.cbseminame.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbseminame.Anchor")));
			this.cbseminame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbseminame.BackgroundImage")));
			this.cbseminame.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbseminame.Dock")));
			this.cbseminame.Enabled = ((bool)(resources.GetObject("cbseminame.Enabled")));
			this.cbseminame.Font = ((System.Drawing.Font)(resources.GetObject("cbseminame.Font")));
			this.cbseminame.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbseminame.ImeMode")));
			this.cbseminame.IntegralHeight = ((bool)(resources.GetObject("cbseminame.IntegralHeight")));
			this.cbseminame.ItemHeight = ((int)(resources.GetObject("cbseminame.ItemHeight")));
			this.cbseminame.Location = ((System.Drawing.Point)(resources.GetObject("cbseminame.Location")));
			this.cbseminame.MaxDropDownItems = ((int)(resources.GetObject("cbseminame.MaxDropDownItems")));
			this.cbseminame.MaxLength = ((int)(resources.GetObject("cbseminame.MaxLength")));
			this.cbseminame.Name = "cbseminame";
			this.cbseminame.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbseminame.RightToLeft")));
			this.cbseminame.Size = ((System.Drawing.Size)(resources.GetObject("cbseminame.Size")));
			this.cbseminame.TabIndex = ((int)(resources.GetObject("cbseminame.TabIndex")));
			this.cbseminame.Text = resources.GetString("cbseminame.Text");
			this.cbseminame.Visible = ((bool)(resources.GetObject("cbseminame.Visible")));
			this.cbseminame.TextChanged += new System.EventHandler(this.SemiGlobalChanged);
			this.cbseminame.SelectedIndexChanged += new System.EventHandler(this.SemiGlobalChanged);
			// 
			// label42
			// 
			this.label42.AccessibleDescription = resources.GetString("label42.AccessibleDescription");
			this.label42.AccessibleName = resources.GetString("label42.AccessibleName");
			this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label42.Anchor")));
			this.label42.AutoSize = ((bool)(resources.GetObject("label42.AutoSize")));
			this.label42.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label42.Dock")));
			this.label42.Enabled = ((bool)(resources.GetObject("label42.Enabled")));
			this.label42.Font = ((System.Drawing.Font)(resources.GetObject("label42.Font")));
			this.label42.Image = ((System.Drawing.Image)(resources.GetObject("label42.Image")));
			this.label42.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label42.ImageAlign")));
			this.label42.ImageIndex = ((int)(resources.GetObject("label42.ImageIndex")));
			this.label42.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label42.ImeMode")));
			this.label42.Location = ((System.Drawing.Point)(resources.GetObject("label42.Location")));
			this.label42.Name = "label42";
			this.label42.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label42.RightToLeft")));
			this.label42.Size = ((System.Drawing.Size)(resources.GetObject("label42.Size")));
			this.label42.TabIndex = ((int)(resources.GetObject("label42.TabIndex")));
			this.label42.Text = resources.GetString("label42.Text");
			this.label42.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label42.TextAlign")));
			this.label42.Visible = ((bool)(resources.GetObject("label42.Visible")));
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
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.GlobCommit);
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
			this.panel6.Controls.Add(this.lbglobfile);
			this.panel6.Controls.Add(this.label46);
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
			this.panel6.Visible = ((bool)(resources.GetObject("panel6.Visible")));
			// 
			// lbglobfile
			// 
			this.lbglobfile.AccessibleDescription = resources.GetString("lbglobfile.AccessibleDescription");
			this.lbglobfile.AccessibleName = resources.GetString("lbglobfile.AccessibleName");
			this.lbglobfile.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbglobfile.Anchor")));
			this.lbglobfile.AutoSize = ((bool)(resources.GetObject("lbglobfile.AutoSize")));
			this.lbglobfile.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbglobfile.Dock")));
			this.lbglobfile.Enabled = ((bool)(resources.GetObject("lbglobfile.Enabled")));
			this.lbglobfile.Font = ((System.Drawing.Font)(resources.GetObject("lbglobfile.Font")));
			this.lbglobfile.Image = ((System.Drawing.Image)(resources.GetObject("lbglobfile.Image")));
			this.lbglobfile.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbglobfile.ImageAlign")));
			this.lbglobfile.ImageIndex = ((int)(resources.GetObject("lbglobfile.ImageIndex")));
			this.lbglobfile.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbglobfile.ImeMode")));
			this.lbglobfile.Location = ((System.Drawing.Point)(resources.GetObject("lbglobfile.Location")));
			this.lbglobfile.Name = "lbglobfile";
			this.lbglobfile.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbglobfile.RightToLeft")));
			this.lbglobfile.Size = ((System.Drawing.Size)(resources.GetObject("lbglobfile.Size")));
			this.lbglobfile.TabIndex = ((int)(resources.GetObject("lbglobfile.TabIndex")));
			this.lbglobfile.Text = resources.GetString("lbglobfile.Text");
			this.lbglobfile.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbglobfile.TextAlign")));
			this.lbglobfile.Visible = ((bool)(resources.GetObject("lbglobfile.Visible")));
			// 
			// label46
			// 
			this.label46.AccessibleDescription = resources.GetString("label46.AccessibleDescription");
			this.label46.AccessibleName = resources.GetString("label46.AccessibleName");
			this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label46.Anchor")));
			this.label46.AutoSize = ((bool)(resources.GetObject("label46.AutoSize")));
			this.label46.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label46.Dock")));
			this.label46.Enabled = ((bool)(resources.GetObject("label46.Enabled")));
			this.label46.Font = ((System.Drawing.Font)(resources.GetObject("label46.Font")));
			this.label46.Image = ((System.Drawing.Image)(resources.GetObject("label46.Image")));
			this.label46.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label46.ImageAlign")));
			this.label46.ImageIndex = ((int)(resources.GetObject("label46.ImageIndex")));
			this.label46.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label46.ImeMode")));
			this.label46.Location = ((System.Drawing.Point)(resources.GetObject("label46.Location")));
			this.label46.Name = "label46";
			this.label46.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label46.RightToLeft")));
			this.label46.Size = ((System.Drawing.Size)(resources.GetObject("label46.Size")));
			this.label46.TabIndex = ((int)(resources.GetObject("label46.TabIndex")));
			this.label46.Text = resources.GetString("label46.Text");
			this.label46.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label46.TextAlign")));
			this.label46.Visible = ((bool)(resources.GetObject("label46.Visible")));
			// 
			// BhavForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.wrapperPanel);
			this.Controls.Add(this.TtabPanel);
			this.Controls.Add(this.bconPanel);
			this.Controls.Add(this.pnGlob);
			this.Controls.Add(this.ObjfPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "BhavForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.wrapperPanel.ResumeLayout(false);
			this.pnflowcontainer.ResumeLayout(false);
			this.gbopcodes.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.bconPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ObjfPanel.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.TtabPanel.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.gbttab.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.pnGlob.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		/// <summary>
		/// Stores the currently active Wrapper
		/// </summary>
		internal IFileWrapperSaveExtension wrapper = null;

		#region BHAV
		private void GetOpcode(object sender, System.EventArgs e)
		{
			try 
			{
				Bhav wrp = (Bhav)wrapper;
				Bhav bhav = new Bhav(wrp.Opcodes);
				bhav.Package = wrp.Package;
				bhav.FileDescriptor = wrp.FileDescriptor;
				
				ushort opcode = WrapperFactory.BhavWizardForm.Execute(bhav, this);

				tbopcode.Text = "0x"+Helper.HexString(opcode);
			} 
			catch (Exception ex) 
			{
				
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		/// <summary>
		/// Issued when the Commit Button was clicked
		/// </summary>
		/// <param name="sender">The Button that sended the Event</param>
		/// <param name="e">Event Parameters</param>
		private void CommitClick(object sender, System.EventArgs e)
		{
			try 
			{
				if (csel>=0) CommitOpcodeClicked(null, null);
				Bhav wrp = (Bhav)wrapper;				

				/*wrp.Header.Format = Convert.ToUInt16(tbformat.Text, 16);
				wrp.Header.ArgumentCount = Convert.ToByte(tbargc.Text, 10);
				wrp.Header.LocalVarCount = Convert.ToUInt16(tblocals.Text, 10);
				wrp.Header.Type = Convert.ToByte(tbtype.Text, 16);
				wrp.Header.Flags = Convert.ToUInt16(tbflags.Text, 16);
				wrp.Header.Zero = Convert.ToUInt16(tbzero.Text, 16);

				wrp.FileName = lbbhav.Text;*/
				wrp.Instructions = InstructionItem.Instructions(flowitems);

				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}			
		}

		protected void UpdateInstructionDetails(Instruction inst)
		{
			this.tbopcode.Text = "0x"+Helper.HexString(inst.OpCode);
			this.tbres.Text = "0x"+Helper.HexString(inst.Reserved0);
			this.tba1.SelectedIndex = -1;
			this.tba1.Text = "0x"+Helper.HexString(inst.Target1);
			this.tba2.SelectedIndex = -1;
			this.tba2.Text = "0x"+Helper.HexString(inst.Target2);

			this.tbo0.Text = Helper.HexString(inst.Operands[0]);
			this.tbo1.Text = Helper.HexString(inst.Operands[1]);
			this.tbo2.Text = Helper.HexString(inst.Operands[2]);
			this.tbo3.Text = Helper.HexString(inst.Operands[3]);
			this.tbo4.Text = Helper.HexString(inst.Operands[4]);
			this.tbo5.Text = Helper.HexString(inst.Operands[5]);
			this.tbo6.Text = Helper.HexString(inst.Operands[6]);
			this.tbo7.Text = Helper.HexString(inst.Operands[7]);

			this.tbu0.Text = Helper.HexString(inst.Reserved1[0]);
			this.tbu1.Text = Helper.HexString(inst.Reserved1[1]);
			this.tbu2.Text = Helper.HexString(inst.Reserved1[2]);
			this.tbu3.Text = Helper.HexString(inst.Reserved1[3]);
			this.tbu4.Text = Helper.HexString(inst.Reserved1[4]);
			this.tbu5.Text = Helper.HexString(inst.Reserved1[5]);
			this.tbu6.Text = Helper.HexString(inst.Reserved1[6]);
			this.tbu7.Text = Helper.HexString(inst.Reserved1[7]);

			this.lbtext.Text = inst.ToString();
		}
		


		private void DeleteOpcodeClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lldel.Enabled = false;
			if (csel<0) return;
			if (csel>flowitems.Length-1) return;
			
			try 
			{
				ArrayList list = new ArrayList();

				foreach (InstructionItem item in flowitems) 
				{
					if (item.index!=csel) list.Add(item.instruction);
				}

				Instruction[] instructions = new Instruction[list.Count];
				list.CopyTo(instructions);

				if (csel>=0) 
				{
					int i = 0;
					while (i<flowitems.Length) 
					{
						if ((flowitems[i].instruction.Target1>csel) && (flowitems[i].instruction.Target1<0xfffc) && (flowitems[i].instruction.Target1!=0xfd) && (flowitems[i].instruction.Target1!=0xfe) && (flowitems[i].instruction.Target1!=0xff))
							flowitems[i].instruction.Target1 --;
						if ((flowitems[i].instruction.Target2>csel) && (flowitems[i].instruction.Target2<0xfffc) && (flowitems[i].instruction.Target2!=0xfd) && (flowitems[i].instruction.Target2!=0xfe) && (flowitems[i].instruction.Target2!=0xff))
							flowitems[i].instruction.Target2 --;

						i++;
					}
				}
				internalchg = true;
				if (csel>=instructions.Length) csel--;
				lldel.Enabled = (instructions.Length>0);
				if (csel>=0) UpdateInstructionDetails(instructions[csel]);
				CreateFlowPanel(instructions);
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				internalchg = false;
			}
		}

		private void AddOpcodeClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			csel = -1;
			CommitOpcodeClicked(sender, e);
			csel = flowitems.Length-1;
			InstructionPanelClick(flowitems[csel].lable, null);
			llcommit.Enabled = (csel>=0);
		}

		private void CommitOpcodeClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llcommit.Enabled = false;
			//creat new Instruction if none is selected
			Instruction inst = null;
			try 
			{
				if (csel <0) 
				{
					Bhav wrp = (Bhav)wrapper;
					inst = new Instruction(flowitems.Length, wrp);
				}
				else  
				{
					inst = flowitems[csel].instruction;
					llcommit.Enabled = true;
				}
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
				return;
			}
			

			try 
			{
				Bhav wrp = (Bhav)wrapper;
				wrp.Changed = true;
				inst.OpCode = Convert.ToUInt16(tbopcode.Text, 16);
				inst.Reserved0 = Convert.ToByte(this.tbres.Text, 16);
				
				if (tba1.SelectedIndex != -1) inst.Target1 = (ushort)(0xFFFC + tba1.SelectedIndex);
				else inst.Target1 = Convert.ToUInt16(tba1.Text, 16);

				if (tba2.SelectedIndex != -1) inst.Target2 = (ushort)(0xFFFC + tba2.SelectedIndex);
				else inst.Target2 = Convert.ToUInt16(tba2.Text, 16);				

				inst.Operands[0] = Convert.ToByte(tbo0.Text, 16);
				inst.Operands[1] = Convert.ToByte(tbo1.Text, 16);
				inst.Operands[2] = Convert.ToByte(tbo2.Text, 16);
				inst.Operands[3] = Convert.ToByte(tbo3.Text, 16);
				inst.Operands[4] = Convert.ToByte(tbo4.Text, 16);
				inst.Operands[5] = Convert.ToByte(tbo5.Text, 16);
				inst.Operands[6] = Convert.ToByte(tbo6.Text, 16);
				inst.Operands[7] = Convert.ToByte(tbo7.Text, 16);

				inst.Reserved1[0] = Convert.ToByte(tbu0.Text, 16);
				inst.Reserved1[1] = Convert.ToByte(tbu1.Text, 16);
				inst.Reserved1[2] = Convert.ToByte(tbu2.Text, 16);
				inst.Reserved1[3] = Convert.ToByte(tbu3.Text, 16);
				inst.Reserved1[4] = Convert.ToByte(tbu4.Text, 16);
				inst.Reserved1[5] = Convert.ToByte(tbu5.Text, 16);
				inst.Reserved1[6] = Convert.ToByte(tbu6.Text, 16);
				inst.Reserved1[7] = Convert.ToByte(tbu7.Text, 16);

				if (csel<0) 
				{					
					Instruction[] ins = new Instruction[flowitems.Length+1];
					InstructionItem.Instructions(flowitems).CopyTo(ins, 0);
					ins[ins.Length-1] = inst;
					CreateFlowPanel(ins);
					
					return;
				} 
				else 
				{
					flowitems[csel].lable.Text = csel.ToString("X")+": "+inst.ToString();
					//CreateFlowPanel(InstructionItem.Instructions(flowitems));
					this.UpdateFlowPanel((Panel)flowitems[csel].lable.Parent, inst, csel);
				}
				
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void OpenBhavClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{		
			if (llopenbhav.Tag != null) 
			{
				Bhav b = (Bhav)llopenbhav.Tag;				
				BhavUI ui = (BhavUI)b.UIHandler;
				
				ui.form.btcommit.Visible = false;
				ui.form.lladd.Visible = false;
				ui.form.lldel.Visible = false;
				ui.form.llcommit.Visible = false;
				ui.form.Text = b.FileName;				
				ui.form.Controls.Remove(ui.form.bconPanel);
				ui.form.wrapperPanel.Dock = DockStyle.Fill;

				b.UpdateUI();					
				ui.form.Show();
			}
		}
		#endregion

		#region BHAV Panel
		private void AutoChangePoiningInst(object sender, System.EventArgs e){
			if (internalchg) return;
			AutoChangeInst(sender, e);
			DrawConnectors();
		}

		private void AutoChangeInst(object sender, System.EventArgs e)
		{
			try 
			{
				this.btwiz.Enabled = BhavWizardForm.Available(Convert.ToUInt16(this.tbopcode.Text, 16));
			} 
			catch (Exception) 
			{
				btwiz.Enabled = false;
			}

			if (internalchg) return;
			if (csel>-1) CommitOpcodeClicked(null, null);
			
		}

		internal bool internalchg;
		protected void InstructionPanelClick(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			lldel.Enabled = false;
			SetReadOnly(true);
			try 
			{
				internalchg = true;
				if (csel!=-1) flowitems[csel].lable.BackColor = Color.Transparent;
				Label lb = ((Label)sender);
				csel = (int)lb.Tag;
				Instruction inst = flowitems[csel].instruction;
				UpdateInstructionDetails(inst);		
				flowitems[csel].lable.BackColor =  System.Drawing.Color.PowderBlue;
				DrawConnectors();
				llcommit.Enabled = (csel!=-1);
				lldel.Enabled = (csel!=-1);

				SetReadOnly(!lldel.Enabled);

				//load referenced Bhav
				Bhav b = null;
				if (inst.GlobalBhav) b = Instruction.LoadGlobalBHAV(inst.OpCode);
				llopenbhav.Enabled = (b!=null);
				llopenbhav.Tag = b;
				
			} 
			catch (Exception ex) 
			{
				csel = -1;
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			finally 
			{
				internalchg = false;
			}
		}

		protected int MoveItem(int index, bool up)
		{
			int sel = csel;
			if (up) 
			{
				if (sel==index) sel --;
				else if (sel==index-1) sel++;

				if (sel<0 || sel>=flowitems.Length) return csel;

				SortSwap((ushort)index, (ushort)(index-1));
			} 
			else 
			{
				if (sel==index+1) sel--;
				else if (sel==index) sel++;

				if (sel<0 || sel>=flowitems.Length) return csel;
				SortSwap((ushort)index, (ushort)(index+1));
			}

			return sel;
		}

		private void MoveItemUp(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			int ct = (int)((LinkLabel)sender).Tag;
			int sel = MoveItem(ct, true);
			CreateFlowPanel(InstructionItem.Instructions(flowitems));
			if (sel!=-1) InstructionPanelClick(flowitems[sel].lable, null);
		}

		private void MoveItemDown(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			int ct = (int)((LinkLabel)sender).Tag;
			int sel = MoveItem(ct, false);
			CreateFlowPanel(InstructionItem.Instructions(flowitems));
			if (sel!=-1) InstructionPanelClick(flowitems[sel].lable, null);
		}

		private void SelectTagItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			object o = ((LinkLabel)sender).Tag;
			if (o!=null) 
			{
				ushort t = (ushort)o;
				if ((t>=0) && (t<flowitems.Length)) 
				{
					InstructionPanelClick(flowitems[t].lable, null);
				}
			}
		}

		protected void FlipPanel()
		{			
			if (pnflow==null) 
			{
				pnflow2.Visible = false;
				pnflow=pnflow1;
			} 
			else 
			{
				if (pnflow.Name == "pnflow1") pnflow = pnflow2;
				else pnflow = pnflow1;
			}
		}

		protected void ShowActivePanel() 
		{	
			
			pnflowcontainer.AutoScroll = false;
			if (pnflow.Name == "pnflow1") 
			{
				pnflow1.Top = pnflowcontainer.AutoScrollPosition.Y;
				pnflow1.Visible = true;
				pnflow2.Visible = false;
				pnflow2.Top = 0;
			} 
			else 
			{
				pnflow2.Top = pnflowcontainer.AutoScrollPosition.Y;
				pnflow2.Visible = true;
				pnflow1.Visible = false;
				pnflow1.Top = 0;
			}
			
			pnflowcontainer.AutoScroll = true;
		}

		private void ItemQueryContinueDragTarget(object sender, QueryContinueDragEventArgs e)
		{
			if (e.KeyState==0) e.Action = DragAction.Drop;
			else e.Action = DragAction.Continue;
		}

		private void ItemDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(int))) 
			{
				e.Effect = DragDropEffects.Link;		
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}					
		}

		private void ItemDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			int sel = 0;
			sel = (int)e.Data.GetData(sel.GetType());
			ComboBox cb = ((ComboBox)sender);
			cb.SelectedIndex = -1;
			cb.Text = "0x"+Helper.HexString((ushort)sel);
		}

		
		private void ItemMouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left) 
			{
				((Label)sender).DoDragDrop(((Label)sender).Tag, DragDropEffects.Link);
			}
		}

		protected void UpdateFlowPanel(Panel pn, Instruction i, int ct) 
		{
			pn.Controls.Clear();

			LinkLabel lb = new LinkLabel();
			lb.Parent = pn;
			lb.Left = 0;
			lb.Top = 0;
			lb.Width = pn.Width - 40;
			lb.Height = pn.Height;
			lb.Text = ct.ToString("X") + ": " + i.ToString();				
			if (ct==csel) lb.BackColor = System.Drawing.Color.PowderBlue;
			lb.Visible = true;
			lb.Tag = ct;
			lb.Click += new EventHandler(InstructionPanelClick);
			lb.LinkClicked += new LinkLabelLinkClickedEventHandler(LinkInstructionPanelClick);
			lb.MouseMove += new MouseEventHandler(ItemMouseMove);

			if (ct>0) 
			{
				LinkLabel llup = new LinkLabel();
				llup.Parent = pn;								
				llup.AutoSize = true;
				llup.Text = "up";
				llup.Top = 1;
				llup.Left = pn.Width - (llup.Width + 1);		
				llup.Visible = true;
				//llup.LinkColor = Color.Yellow;
				llup.Tag = ct;

				llup.LinkClicked += new LinkLabelLinkClickedEventHandler(MoveItemUp);
				llup.Click += new EventHandler(InstructionPanelClick);	
			}

			if (ct<flowitems.Length-1) 
			{
				LinkLabel lldn = new LinkLabel();
				lldn.Parent = pn;					
				lldn.AutoSize = true;
				lldn.Text = "down";
				lldn.Left = pn.Width - (lldn.Width + 1);					
				lldn.Top = pn.Height - (lldn.Height + 1);
				lldn.Visible = true;
				//lldn.LinkColor = Color.Yellow;
				lldn.Tag = ct;

				lldn.LinkClicked += new LinkLabelLinkClickedEventHandler(MoveItemDown);
				lldn.Click += new EventHandler(InstructionPanelClick);	
			}

			LinkLabel llt = new LinkLabel();
			llt.Parent = lb;					
			llt.AutoSize = true;
			llt.Text = "true: "+i.Target1.ToString("X");
			llt.Left = lb.Left;					
			llt.Top = pn.Height - (llt.Height + 1);
			llt.Visible = true;
			//llt.LinkColor = Color.Yellow;
			llt.Tag = i.Target1;
			if (i.Target1<flowitems.Length) llt.LinkArea = new LinkArea(6, llt.Text.Length-6);
			else llt.LinkArea = new LinkArea(0, 0);
			llt.LinkClicked += new LinkLabelLinkClickedEventHandler(SelectTagItem);

			LinkLabel llf = new LinkLabel();
			llf.Parent = lb;					
			llf.AutoSize = true;
			llf.Text = "false: "+i.Target2.ToString("X");
			llf.Left = llt.Left + llt.Width + 4;
			llf.Top = pn.Height - (llf.Height + 1);
			llf.Visible = true;
			//llf.LinkColor = Color.Yellow;
			llf.Tag = i.Target2;
			if (i.Target2<flowitems.Length) llf.LinkArea = new LinkArea(7, llf.Text.Length-7);
			else llf.LinkArea = new LinkArea(0, 0);
			llf.LinkClicked += new LinkLabelLinkClickedEventHandler(SelectTagItem);

			flowitems[ct].lable = lb;
			flowitems[ct].instruction = i;
				
			Connector cnt = new Connector();
			cnt.start = ct;
			cnt.stop = i.Target1;
			cnt.lane = 1;
			cnt.truerule = true;

			Connector cnf = new Connector();
			cnf.start = ct;
			cnf.stop = i.Target2;
			cnf.lane = 1;
			cnf.truerule = false;

			flowitems[ct].index = ct;		
		}

		/// <summary>
		/// The current selected Instruction
		/// </summary>
		internal int csel = -1;
		InstructionItem[] flowitems;
		PictureBox pnflow;
		public void CreateFlowPanel(Instruction[] instructions) 
		{			
			FlipPanel();

			//csel = -1;
			int ct = 0;
			flowitems = new InstructionItem[instructions.Length];		
			//pnflow.Height = Math.Max(10, flowitems.Length * (height + 4));
			pnflow.Controls.Clear();
			foreach (Instruction i in instructions) 
			{
				flowitems[ct] = new InstructionItem();

				Panel pn = new Panel();
				pn.Parent = pnflow;
				pn.Height = InstructionItem.Height;
				pn.Top = ct*(pn.Height+4);				
				pn.Left = 0;
				pn.Width = pnflow.ClientRectangle.Width - 120;
				pn.Visible = true;
				pn.BorderStyle = BorderStyle.FixedSingle;
				pn.BackColor = System.Drawing.Color.White;
				/*pn.BackColor = System.Drawing.Color.SteelBlue;				
				pn.ForeColor = System.Drawing.SystemColors.HighlightText;*/
				//pn.ContextMenu = this.cmcopy;
				
				UpdateFlowPanel(pn, i, ct);		

				ct++;
			}

			DrawConnectors();
			ShowActivePanel();
		}


		protected void DrawConnectors()
		{			
			try 
			{
				Connector[] connectors = InstructionItem.Connectors(flowitems);			
				Connector.ResolveCollisions(connectors);

				Bitmap img = new Bitmap(pnflowcontainer.ClientRectangle.Width-24, Math.Max(10, flowitems.Length * (InstructionItem.Height + 4)));
				Graphics gr = Graphics.FromImage(img);
				gr.SmoothingMode =  System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				gr.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
				gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

				Pen tpen = new Pen(Color.YellowGreen, 1);
				Pen fpen = new Pen(Color.Maroon, 1);
				Pen tpens = new Pen(Color.LawnGreen, 2);
				Pen fpens = new Pen(Color.LightCoral, 2);
				Pen pen;

				string [] resNames = this.GetType().Assembly.GetManifestResourceNames();

				Bitmap bmpok = new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.button_ok.png"));
				Bitmap bmpcancel = new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.button_cancel.png"));
				Point[] points;
				foreach (Connector c in connectors) 
				{
					if (c==null) continue;
					if (c.truerule) pen = tpen; else pen = fpen;
					if (c.start == csel) if (c.truerule) pen = tpens; else pen = fpens;
					if (c.stop == csel) pen = new Pen(pen.Brush, 2);
					int offset = 4;
					if (c.truerule) offset+=4; 

					if (c.start >= flowitems.Length) continue;
					Control startlabel = (Control)flowitems[c.start].lable.Parent;

					if (c.stop >= flowitems.Length) 
					{
						if ( (c.stop  == 0xFFFD) || (c.stop == 0x00FF)  )
						{
							gr.DrawLine(	
								pen, 
								startlabel.Right, 
								startlabel.Top + (startlabel.Height / 2) + offset,
								img.Width-16,
								startlabel.Top + (startlabel.Height / 2) + offset
								);
							if (bmpok!=null) 
							{
								gr.DrawImageUnscaled(
									bmpok,
									img.Width-16,
									startlabel.Top + (startlabel.Height / 2) + offset - 8
									);
							}
							points = new Point[3];
							points[0] = new Point(img.Width-16, startlabel.Top + (startlabel.Height / 2) + offset);
							points[1] = new Point(points[0].X - 4, points[0].Y - 4);
							points[2] = new Point(points[0].X - 4, points[0].Y + 4);
							gr.FillPolygon(pen.Brush, points);
						} 
						else if ( (c.stop == 0xFFFC) || (c.stop == 0xFFFE) || (c.stop == 0x00FE) || (c.stop == 0x00FD))
						{
							int sub = 40;
							if ((c.stop == 0xFFFE) || (c.stop == 0x00FD)) sub = 16;
							gr.DrawLine(	
								pen, 
								startlabel.Right, 
								startlabel.Top + (startlabel.Height / 2) + offset,
								img.Width-sub,
								startlabel.Top + (startlabel.Height / 2) + offset
								);
							if (bmpcancel!=null) 
							{
								gr.DrawImageUnscaled(
									bmpcancel,
									img.Width-sub,
									startlabel.Top + (startlabel.Height / 2) + offset - 8
									);
							}
							points = new Point[3];
							points[0] = new Point(img.Width-sub, startlabel.Top + (startlabel.Height / 2) + offset);
							points[1] = new Point(points[0].X - 4, points[0].Y - 4);
							points[2] = new Point(points[0].X - 4, points[0].Y + 4);
							gr.FillPolygon(pen.Brush, points);
						} 
					
						continue;
					}
				
					Control stoplabel = (Control)flowitems[c.stop].lable.Parent;
					gr.DrawLine(	
						pen, 
						startlabel.Right, 
						startlabel.Top + (startlabel.Height / 2) + offset,
						startlabel.Right + (c.lane * 4) + offset,
						startlabel.Top + (startlabel.Height / 2) + offset
						);

					gr.DrawLine(	
						pen, 
						startlabel.Right + (c.lane * 4) + offset, 
						startlabel.Top + (startlabel.Height / 2) + offset,
						stoplabel.Right + (c.lane * 4) + offset,
						stoplabel.Top + (stoplabel.Height / 2) - offset 
						);

					gr.DrawLine(	
						pen, 
						stoplabel.Right + (c.lane * 4) + offset, 
						stoplabel.Top + (stoplabel.Height / 2) - offset,
						stoplabel.Right,
						stoplabel.Top + (stoplabel.Height / 2) - offset
						);
			
				
					points = new Point[3];
					points[0] = new Point(stoplabel.Right, stoplabel.Top + (stoplabel.Height / 2) - offset);
					points[1] = new Point(points[0].X + 4, points[0].Y - 4);
					points[2] = new Point(points[0].X + 4, points[0].Y + 4);
					gr.FillPolygon(pen.Brush, points);
				}

				pnflow.Image = img;
			} 
			catch (Exception) 
			{
			}
		}

		private void RepaintFlow(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			//DrawConnectors();
		}

		private void FlowResize(object sender, System.EventArgs e)
		{
			CreateFlowPanel(InstructionItem.Instructions(flowitems));
		}

		private void CopyInstruction(object sender, System.EventArgs e)
		{
			if (csel<0) return;
			DataObject m_data = new DataObject("Instruction", this.flowitems[csel]);
			Clipboard.SetDataObject(m_data);
		}

		private void InsertInstruction(object sender, System.EventArgs e)
		{
			try 
			{
				InstructionItem i = (InstructionItem)Clipboard.GetDataObject().GetData("Instruction") ;
				if (i==null) return;
				csel = -1;
				CommitOpcodeClicked(null, null);
				csel = flowitems.Length-1;
				InstructionPanelClick(flowitems[csel].lable, null);
				llcommit.Enabled = (csel>=0);
				flowitems[csel] = i;
			} 
			catch (Exception) {}
			
		}

		private void SortSwap(ushort a, ushort b) 
		{
			if (a>=flowitems.Length) return;
			if (b>=flowitems.Length) return;
			if (a<0) return;
			if (b<0) return;

			InstructionItem i = flowitems[a];
			flowitems[a] = flowitems[b];
			flowitems[b] = i;

			foreach (InstructionItem item in flowitems)
			{
				if (item.instruction.Target1 == a) item.instruction.Target1 = (ushort)b;
				else if (item.instruction.Target1 == b) item.instruction.Target1 = (ushort)a;

				if (item.instruction.Target2 == a) item.instruction.Target2 = (ushort)b;
				else if (item.instruction.Target2 == b) item.instruction.Target2 = (ushort)a;
			}
		}

		private void SortInstructions(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ushort last = 0;
			for (ushort i=0; i<flowitems.Length-1; i++) 
			{
				if (flowitems[i].instruction.Target1 > i+1) 
				{
					/*for (ushort k=0; k<flowitems.Length-1; k++) 
					{
						if (flowitems[k].instruction.Target2 > last) 
						{
							if (flowitems[k].instruction.Target2 < 0xfffc) SortSwap(flowitems[k].instruction.Target2, last);
							last++;
						}
					}*/

					if (flowitems[i].instruction.Target1 < 0xfffc) SortSwap(flowitems[i].instruction.Target1, (ushort)(i+1));
					else 
					{
						if (flowitems[i].instruction.Target2 > i+1) 
						{
							if (flowitems[i].instruction.Target2 < 0xfffc) SortSwap(flowitems[i].instruction.Target2, (ushort)(i+1));
						}
					}
					last = i;
				}
			}

			for (ushort i=0; i<flowitems.Length-1; i++) 
			{
				if (flowitems[i].instruction.Target2 > last) 
				{
					if (flowitems[i].instruction.Target2 < 0xfffc) SortSwap(flowitems[i].instruction.Target2, last);
					last++;
				}
			}

			csel = -1;
			this.llcommit.Enabled = false;
			this.lldel.Enabled = false;
			CreateFlowPanel(InstructionItem.Instructions(flowitems));
			wrapper.Changed = true;
		}

		private void OpenOperandWiz(object sender, System.EventArgs e)
		{
			try 
			{
				
				if (BhavWizardForm.Available(Convert.ToUInt16(this.tbopcode.Text, 16))) 
				{
					BhavWizardForm bwf = new BhavWizardForm();
					byte[] ret = new byte[0x10];

					ret[0] = Convert.ToByte(tbo0.Text, 16);
					ret[1] = Convert.ToByte(tbo1.Text, 16);
					ret[2] = Convert.ToByte(tbo2.Text, 16);
					ret[3] = Convert.ToByte(tbo3.Text, 16);
					ret[4] = Convert.ToByte(tbo4.Text, 16);
					ret[5] = Convert.ToByte(tbo5.Text, 16);
					ret[6] = Convert.ToByte(tbo6.Text, 16);
					ret[7] = Convert.ToByte(tbo7.Text, 16);

					ret[8] = Convert.ToByte(tbu0.Text, 16);
					ret[9] = Convert.ToByte(tbu1.Text, 16);
					ret[10] = Convert.ToByte(tbu2.Text, 16);
					ret[11] = Convert.ToByte(tbu3.Text, 16);
					ret[12] = Convert.ToByte(tbu4.Text, 16);
					ret[13] = Convert.ToByte(tbu5.Text, 16);
					ret[14] = Convert.ToByte(tbu6.Text, 16);
					ret[15] = Convert.ToByte(tbu7.Text, 16);

					ret = bwf.Execute(Convert.ToUInt16(this.tbopcode.Text, 16), ret);

					if (ret!=null) 
					{
						internalchg = true;
						this.tbo0.Text = Helper.HexString(ret[0]);
						this.tbo1.Text = Helper.HexString(ret[1]);
						this.tbo2.Text = Helper.HexString(ret[2]);
						this.tbo3.Text = Helper.HexString(ret[3]);
						this.tbo4.Text = Helper.HexString(ret[4]);
						this.tbo5.Text = Helper.HexString(ret[5]);
						this.tbo6.Text = Helper.HexString(ret[6]);
						this.tbo7.Text = Helper.HexString(ret[7]);

						this.tbu0.Text = Helper.HexString(ret[8]);
						this.tbu1.Text = Helper.HexString(ret[9]);
						this.tbu2.Text = Helper.HexString(ret[10]);
						this.tbu3.Text = Helper.HexString(ret[11]);
						this.tbu4.Text = Helper.HexString(ret[12]);
						this.tbu5.Text = Helper.HexString(ret[13]);
						this.tbu6.Text = Helper.HexString(ret[14]);
						this.tbu7.Text = Helper.HexString(ret[15]);

						internalchg = false;
						this.AutoChangeInst(sender, e);
					}
				}
			} 
			catch (Exception) 
			{
				btwiz.Enabled = false;
			} 
			finally 
			{
				internalchg = false;
			}
		}
		
		#endregion

		#region BCON

		private void DeleteConstantClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (constants.SelectedIndex<0) return;
			constants.Items.Remove(constants.Items[constants.SelectedIndex]);

			for(int i=0; i<constants.Items.Count; i++)
			{
				BconItem bi = (BconItem)constants.Items[i];
				bi.Index = i;
			}

			wrapper.Changed = true;
		}

		private void BconFilename(object sender, System.EventArgs e)
		{
			if (lbcon.Tag != null) return;

			try 
			{
				lbcon.Tag = true;
				Bcon wrp = (Bcon)wrapper;				

				wrp.FileName = lbcon.Text;
				wrp.Flag = Convert.ToByte(tbconstflag.Text, 16);
				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				lbcon.Tag = null;
			}
		}

		private void BConDecValueChanged(object sender, System.EventArgs e)
		{
			if (tbdec.Tag != null) return;

			try 
			{
				tbdec.Tag = true;
				tbvalue.Text = "0x"+Helper.HexString((ushort)Convert.ToInt16(tbdec.Text));
			} 
			catch (Exception) 
			{
			}
			finally
			{
				tbdec.Tag = null;
			}
		}

		private void AutoChangeConst(object sender, System.EventArgs e)
		{
			if (constants.SelectedIndex>=0) CommitConstantClicked(null, null);

			if (tbdec.Tag != null) return;
			try 
			{
				tbdec.Tag = true;
				tbdec.Text = Convert.ToInt16(tbvalue.Text, 16).ToString();
			} 
			catch (Exception) {}
			finally 
			{
				tbdec.Tag = null;
			}
		}

		private void ConstnatCommitClicked(object sender, System.EventArgs e)
		{
			try 
			{
				Bcon wrp = (Bcon)wrapper;				

				wrp.Flag = Convert.ToByte(this.tbconstflag.Text, 16);
				
				BconItem[] con = new BconItem[constants.Items.Count];
				for (int i=0; i< con.Length; i++)
				{
					con[i] = (BconItem)constants.Items[i];
				}
				wrp.Constants = con;

				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}		
		}

		private void ConstantSelected(object sender, System.EventArgs e)
		{
			llccommit.Enabled = false;
			if (constants.SelectedIndex <0) return;
			llccommit.Enabled = true;

			try 
			{
				ushort con = (ushort)constants.Items[constants.SelectedIndex];

				this.tbvalue.Text = "0x"+Helper.HexString(con);				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void AddConstantClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			constants.SelectedIndex = -1;
			CommitConstantClicked(sender, e);
			constants.SelectedIndex = constants.Items.Count-1;
			llccommit.Enabled = (constants.SelectedIndex>=0);
		}

		private void CommitConstantClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llccommit.Enabled = false;

			//creat new Constant if non is selected
			BconItem con = new BconItem(0, constants.Items.Count, (Bcon)wrapper);
			try 
			{
				if (constants.SelectedIndex >=0) 
				{
					con = (BconItem)constants.Items[constants.SelectedIndex];
					llccommit.Enabled = true;
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
				return;
			}
			

			try 
			{
				Bcon wrp = (Bcon)wrapper;
				wrp.Changed = true;
				con.Value = Convert.ToInt16(tbvalue.Text, 16);				
				constants.Update();

				this.internalchg = true;
				if (constants.SelectedIndex <0) 
				{
					constants.Items.Add(con);
				} 
				else 
				{
					constants.Items[constants.SelectedIndex] = con;
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			finally 
			{
				this.internalchg = false;
			}
		}		

		private void ConstantCHanged(object sender, System.EventArgs e)
		{
			if (this.internalchg) return;

			llccommit.Enabled = false;
			llcdel.Enabled = false;
			if (constants.SelectedIndex <0) return;
			llccommit.Enabled = true;
			llcdel.Enabled = true;

			try 
			{
				BconItem con = (BconItem)constants.Items[constants.SelectedIndex];
				this.tbvalue.Text = "0x"+Helper.HexString((ushort)con.Value);				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}
		#endregion		

		#region OBJf
		private void GetObjfGuard(object sender, System.EventArgs e)
		{
			try 
			{
				Objf wrp = (Objf)wrapper;
				Bhav bhav = new Bhav(wrp.Opcodes);
				bhav.Package = wrp.Package;
				bhav.FileDescriptor = wrp.FileDescriptor;
				
				ushort opcode = WrapperFactory.BhavWizardForm.Execute(bhav, this);

				tbguard.Text = "0x"+Helper.HexString(opcode);
			} 
			catch (Exception ex) 
			{
				
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		
		private void GetObjfAction(object sender, System.EventArgs e)
		{
			try 
			{
				Objf wrp = (Objf)wrapper;
				Bhav bhav = new Bhav(wrp.Opcodes);
				bhav.Package = wrp.Package;
				bhav.FileDescriptor = wrp.FileDescriptor;
				
				ushort opcode = WrapperFactory.BhavWizardForm.Execute(bhav, this);

				tbaction.Text = "0x"+Helper.HexString(opcode);
			} 
			catch (Exception ex) 
			{
				
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ObjfChanged(object sender, System.EventArgs e)
		{
			if (this.internalchg) return;
			this.llchangeobjf.Enabled = false;
			if (lbobjf.SelectedIndex <0) return;
			llchangeobjf.Enabled = true;

			try 
			{
				internalchg = true;
				ObjfItem item = (ObjfItem)lbobjf.Items[lbobjf.SelectedIndex];
				this.tbguard.Text = "0x"+Helper.HexString(item.Guardian);				
				this.tbaction.Text = "0x"+Helper.HexString(item.Action);
				lbname.Text = item.Name;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				internalchg = false;
			}
		}

		private void ObjfCommit(object sender, System.EventArgs e)
		{
			try 
			{
				Objf wrp = (Objf)wrapper;				

				
				ObjfItem[] items = new ObjfItem[lbobjf.Items.Count];
				for (int i=0; i< items.Length; i++)
				{
					items[i] = (ObjfItem)lbobjf.Items[i];
				}
				wrp.Items = items;

				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}		

		private void ObjfChanged(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llchangeobjf.Enabled = false;

			//creat new Item if non is selected
			
			ObjfItem item = null;
			try 
			{
				Objf wrp = (Objf)wrapper;
				item = new ObjfItem(wrp);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
				return;
			}

			try 
			{
				if (lbobjf.SelectedIndex >=0) 
				{
					item = (ObjfItem)lbobjf.Items[lbobjf.SelectedIndex];
					llchangeobjf.Enabled = true;
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
				return;
			}
			

			try 
			{
				item.Guardian = Convert.ToUInt16(tbguard.Text, 16);
				item.Action = Convert.ToUInt16(tbaction.Text, 16);
				wrapper.Changed = true;

				this.internalchg = true;
				if (lbobjf.SelectedIndex <0) 
				{
					item.LineNumber = lbobjf.Items.Count;
					lbobjf.Items.Add(item);
				} 
				else 
				{
					lbobjf.Items[lbobjf.SelectedIndex] = item;
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				this.internalchg = false;
			}
		}
		#endregion

		
		#region TTAB
		private void AutoChangeInteraction(object sender, System.EventArgs e)
		{
			if (internalchg) return;
			internalchg = true;
			try 
			{
				if (lbttab.SelectedIndex>=0) TtabItemChange(null, null);
			} 
			finally 
			{
				internalchg = false;
			}
		}

		private void TtabItemDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbttab.SelectedIndex>=0) 
			{
				lbttab.Items.Remove(lbttab.Items[lbttab.SelectedIndex]);
				wrapper.Changed = true;
			}
		}

		private void AutoChangeMotive(object sender, System.EventArgs e)
		{
			if (internalchg) return;
			internalchg = true;
			try 
			{
				if (lblist.SelectedIndex>=0) ListChangeClick(null, null);
			} 
			finally 
			{
				internalchg = false;
			}
		}

		private void GetTTABGuard(object sender, System.EventArgs e)
		{
			try 
			{
				Ttab wrp = (Ttab)wrapper;
				Bhav bhav = new Bhav(wrp.Opcodes);
				bhav.Package = wrp.Package;
				bhav.FileDescriptor = wrp.FileDescriptor;
				
				ushort opcode = WrapperFactory.BhavWizardForm.Execute(bhav, this);

				tbttabguard.Text = "0x"+Helper.HexString(opcode);
			} 
			catch (Exception ex) 
			{
				
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		
		private void GetTTABAction(object sender, System.EventArgs e)
		{
			try 
			{
				Ttab wrp = (Ttab)wrapper;
				Bhav bhav = new Bhav(wrp.Opcodes);
				bhav.Package = wrp.Package;
				bhav.FileDescriptor = wrp.FileDescriptor;
				
				ushort opcode = WrapperFactory.BhavWizardForm.Execute(bhav, this);

				tbttabaction.Text = "0x"+Helper.HexString(opcode);
			} 
			catch (Exception ex) 
			{
				
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void TtabSelect(object sender, System.EventArgs e)
		{
			if (this.internalchg) return;

			cbgroups.Items.Clear();
			lblist.Items.Clear();
			this.llchangettab.Enabled = false;
			this.lldelttab.Enabled = false;
			if (lbttab.SelectedIndex <0) return;
			llchangettab.Enabled = true;
			lldelttab.Enabled = true;

			try 
			{
				internalchg = true;
				TtabItem item = (TtabItem)lbttab.Items[lbttab.SelectedIndex];
				this.tbttabguard.Text = "0x"+Helper.HexString(item.Guardian);				
				this.tbttabaction.Text = "0x"+Helper.HexString(item.Action);

				this.tbinst1.Text = "0x"+Helper.HexString(item.Flags.Value);
				this.tbinst2.Text = "0x"+Helper.HexString(item.Flags2);
				tbpie.Text = "0x"+Helper.HexString(item.StringIndex);

				tbres1.Text = "0x"+Helper.HexString(item.AttenuationCode);
				tbres2.Text = "0x"+Helper.HexString(item.AttenuationValue);
				tbres3.Text = "0x"+Helper.HexString(item.Autonomy);
				tbres4.Text = "0x"+Helper.HexString(item.Res5);
				tbres5.Text = "0x"+Helper.HexString(item.Res6);
				tbres6.Text = item.Res7.ToString("N9");
				tbres7.Text = "0x"+Helper.HexString(item.Res8);
				tbres8.Text = "0x"+Helper.HexString(item.Res9);

				
				for(int i=0; i<item.Groups.Length; i++)  cbgroups.Items.Add((TtabMotives)i);
				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			finally 
			{
				internalchg = false;
			}
		}		

		private void GroupListChanged(object sender, System.EventArgs e)
		{
			if (internalchg) return;
			this.lllistchange.Enabled = false;
			if (lblist.SelectedIndex <0) return;
			lllistchange.Enabled = true;

			try 
			{
				internalchg = true;
				TtabListItem item = (TtabListItem)lblist.Items[lblist.SelectedIndex];

				tbmin.Text = "0x"+Helper.HexString((ushort)item.Minimum);
				tbdelta.Text = "0x"+Helper.HexString((ushort)item.Delta);
				tblisttype.Text = "0x"+Helper.HexString((ushort)item.Type);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			finally 
			{
				internalchg = false;
			}
		}
		

		private void ListSelected(object sender, System.EventArgs e)
		{
			if (cbgroups.SelectedIndex <0) return;
			if (lbttab.SelectedIndex <0) return;

			try 
			{
				TtabItem item = (TtabItem)lbttab.Items[lbttab.SelectedIndex];
				int nr = (int)cbgroups.Items[cbgroups.SelectedIndex];

				lblist.Items.Clear();
				foreach (TtabListItem li in item.Groups[nr]) 
				{
					lblist.Items.Add(li);
				}

				//while (lblist.Items.Count<0x10) lblist.Items.Add(new TtabListItem(-1, null));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}


		}		

		private void ListChangeClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lblist.SelectedIndex <0) return;
			if (cbgroups.SelectedIndex <0) return;
			if (lbttab.SelectedIndex <0) return;

			try 
			{
				Ttab wrp = (Ttab)wrapper;
				TtabListItem item = (TtabListItem)lblist.Items[lblist.SelectedIndex];				

				item.Minimum = Convert.ToInt16(tbmin.Text, 16);
				item.Delta = Convert.ToInt16(tbdelta.Text, 16);
				item.Type = Convert.ToInt16(tblisttype.Text, 16);

				wrapper.Changed = true;
				//while (lblist.Items.Count<0x10) lblist.Items.Add(new TtabListItem(-1, null));
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}


		private void TtabItemChange(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			//if (lbttab.SelectedIndex <0) return;

			try 
			{
				Ttab wrp = (Ttab)wrapper;
				TtabItem item = null;
				if (lbttab.SelectedIndex>=0) item = (TtabItem)lbttab.Items[lbttab.SelectedIndex];
				else item = new TtabItem(wrp);

				item.Guardian = Convert.ToUInt16(this.tbttabguard.Text, 16);				
				item.Action = Convert.ToUInt16(this.tbttabaction.Text, 16);

				item.Flags.Value = Convert.ToUInt16(this.tbinst1.Text, 16);
				item.Flags2 = Convert.ToUInt16(this.tbinst2.Text, 16);
				item.StringIndex = Convert.ToUInt32(tbpie.Text, 16);

				item.AttenuationCode = Convert.ToUInt32(tbres1.Text, 16);
				item.AttenuationValue = Convert.ToUInt32(tbres2.Text, 16);
				item.Autonomy = Convert.ToUInt32(tbres3.Text, 16);
				item.Res5 = Convert.ToUInt32(tbres4.Text, 16);
				item.Res6 = Convert.ToUInt32(tbres5.Text, 16);
				item.Res7 = Convert.ToSingle(tbres6.Text);
				item.Res8 = Convert.ToUInt32(tbres7.Text, 16);
				item.Res9 = Convert.ToUInt16(tbres8.Text, 16);

				this.internalchg = true;
				if (lbttab.SelectedIndex>=0) 
				{
					lbttab.Items[lbttab.SelectedIndex] = item;
				} 
				else 
				{
					lbttab.Items.Add(item);
				}
				wrapper.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				this.internalchg = false;
			}
		}
		

		private void Ttabcommit(object sender, System.EventArgs e)
		{
		
			try 
			{
				if (this.lbttab.SelectedIndex>=0) TtabItemChange(null, null);
				Ttab wrp = (Ttab)wrapper;

				TtabItem[] items = new TtabItem[lbttab.Items.Count];
				for(int i=0; i<items.Length; i++)
				{
					TtabItem item = (TtabItem)lbttab.Items[i];
					items[i] = item;
				}
				wrp.Items = items;
				wrp.SynchronizeUserData();
				
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void AddTtab(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbttab.SelectedIndex = -1;
			TtabItemChange(null, null);
			lbttab.SelectedIndex = lbttab.Items.Count -1;
		}

		private void ActionOrGuardianChanged(object sender, System.EventArgs e)
		{
			lbguard.Text = Localization.Manager.GetString("Unknown");
			lbaction.Text = Localization.Manager.GetString("Unknown");

			try 
			{
				Ttab wrp = (Ttab)wrapper;
				TtabItem item = new TtabItem(wrp);
				item.Action = Convert.ToUInt16(tbttabaction.Text, 16);
				item.Guardian = Convert.ToUInt16(tbttabguard.Text, 16);

				lbguard.Text = item.GuardianName;
				lbaction.Text = item.ActionName;
		
				this.AutoChangeInteraction(sender, e);
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
		}
		
		#endregion

		#region TTAB Flags
		private void FlagTextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				TtabFlags val = new TtabFlags(Convert.ToUInt16(this.tbinst1.Text, 16));

				this.cbvisitor.Checked = val.ByVisitors;
				this.cbautofirst.Checked = val.AutoFirstSelect;
				this.cbconsecutive.Checked = val.AvailConsecutive;
				this.cbchildren.Checked = val.ByChildren;
				this.cbdemochild.Checked = val.ByDemoChild;
				this.cbelders.Checked = val.ByElders;
				this.cbteens.Checked = val.ByTeens;
				this.cbtodlers.Checked = val.ByToddlers;
				this.cbdebugmenu.Checked = val.DebugMenu;
				this.cbjoinable.Checked = val.Joinable;
				this.cbimmediately.Checked = val.RunImmediately;
				this.cbadults.Checked = val.ByAdults;
				this.cbunk1.Checked = val.Unknown1;
				this.cbunk2.Checked = val.Unknown2;
				this.cbunk3.Checked = val.Unknown3;
				this.cbunk4.Checked = val.Unknown4;

				this.AutoChangeInteraction(sender, e);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void UpdateFlagsValue(object sender, System.EventArgs e)
		{
			try 
			{
				TtabFlags val = new TtabFlags(Convert.ToUInt16(this.tbinst1.Text, 16));

				val.ByVisitors = this.cbvisitor.Checked;
				val.AutoFirstSelect = this.cbautofirst.Checked;
				val.AvailConsecutive = this.cbconsecutive.Checked;
				val.ByChildren = this.cbchildren.Checked;
				val.ByDemoChild = this.cbdemochild.Checked;
				val.ByElders = this.cbelders.Checked;
				val.ByTeens = this.cbteens.Checked;
				val.ByToddlers = this.cbtodlers.Checked;
				val.DebugMenu = this.cbdebugmenu.Checked;
				val.Joinable = this.cbjoinable.Checked;
				val.RunImmediately = this.cbimmediately.Checked;
				val.ByAdults = this.cbadults.Checked;
				val.Unknown1 = this.cbunk1.Checked;
				val.Unknown2 = this.cbunk2.Checked;
				val.Unknown3 = this.cbunk3.Checked;
				val.Unknown4 = this.cbunk4.Checked;

				tbinst1.Text = "0x"+Helper.HexString(val.Value);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		#endregion

		#region GLOB
		private void GlobCommit(object sender, System.EventArgs e)
		{
			try {
				Glob wrp = (Glob)wrapper;

				wrp.SemiGlobalName = this.cbseminame.Text;
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void SemiGlobalChanged(object sender, System.EventArgs e)
		{
			

			if (cbseminame.SelectedIndex<0) 
			{
				this.tbgroup.Text = "0xffffffff";
				foreach (Data.SemiGlobalAlias a in cbseminame.Items) 
				{
					if (a.Name.ToLower()==cbseminame.Text.ToLower()) 
					{
						tbgroup.Text = "0x"+Helper.HexString(a.Id);
						break;
					}
				}
				
				return;
			}

			Data.SemiGlobalAlias al = (Data.SemiGlobalAlias)cbseminame.Items[cbseminame.SelectedIndex];
			tbgroup.Text = "0x"+Helper.HexString(al.Id);

			if (cbseminame.Tag == null) 
			{
				try 
				{
					Glob wrp = (Glob)wrapper;
					wrp.SemiGlobalName = this.cbseminame.Text;
					wrapper.Changed = true;
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}
			}
		}
		#endregion

		private void AutoChangeObjf(object sender, System.EventArgs e)
		{
			if (internalchg) return;
			if (lbobjf.SelectedIndex>=0) ObjfChanged(null, null);
		}

		private void AutoChangeBhav(object sender, System.EventArgs e)
		{
			if (this.internalchg) return;
			try 
			{
				this.internalchg = true;
				Bhav wrp = (Bhav)wrapper;				

				wrp.Header.Format = Convert.ToUInt16(tbformat.Text, 16);
				wrp.Header.ArgumentCount = Convert.ToByte(tbargc.Text, 10);
				wrp.Header.LocalVarCount = Convert.ToUInt16(tblocals.Text, 10);
				wrp.Header.Type = Convert.ToByte(tbtype.Text, 16);
				wrp.Header.Flags = Convert.ToUInt16(tbflags.Text, 16);
				wrp.Header.Zero = Convert.ToUInt16(tbzero.Text, 16);

				wrp.FileName = lbbhav.Text;
				wrp.Changed = true;
			} 
			catch (Exception) {}
			finally 
			{
				this.internalchg = false;
			}
		}

		private void LinkInstructionPanelClick(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.InstructionPanelClick(sender, e);
		}

		private void llmove_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				int mv = Convert.ToInt32(tbmv.Text);
				int sel = csel;
				for (int i=0; i<Math.Abs(mv); i++) 
				{
						sel = this.MoveItem(sel, (mv<0));
						csel = sel;
				}

				CreateFlowPanel(InstructionItem.Instructions(flowitems));
				if (sel!=-1) InstructionPanelClick(flowitems[sel].lable, null);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void tbmv_TextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				int mv = Convert.ToInt32(tbmv.Text);
				if (mv<0) label45.Text = "lines up";
				else label45.Text = "lines down";
			} 
			catch {}
		}

		internal void SetReadOnly(bool state) 
		{
			this.tbo0.ReadOnly = state;
			this.tbo1.ReadOnly = state;
			this.tbo2.ReadOnly = state;
			this.tbo3.ReadOnly = state;
			this.tbo4.ReadOnly = state;
			this.tbo5.ReadOnly = state;
			this.tbo6.ReadOnly = state;
			this.tbo7.ReadOnly = state;
			
			this.tbu0.ReadOnly = state;
			this.tbu1.ReadOnly = state;
			this.tbu2.ReadOnly = state;
			this.tbu3.ReadOnly = state;
			this.tbu4.ReadOnly = state;
			this.tbu5.ReadOnly = state;
			this.tbu6.ReadOnly = state;
			this.tbu7.ReadOnly = state;

			tbopcode.ReadOnly = state;
			tbres.ReadOnly = state;

			tba1.Enabled = !state;
			tba2.Enabled = !state;

			tbmv.ReadOnly = state;

			btwiz.Enabled = !state;
			button4.Enabled = !state;

			llmove.Enabled = !state;
		}
	}
}
