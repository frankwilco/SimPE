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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für RcolForm.
	/// </summary>
	public class RcolForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel RcolPanel;
		private System.Windows.Forms.LinkLabel llfix;
		private System.Windows.Forms.LinkLabel llhash;
		private System.Windows.Forms.TextBox tbflname;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ComboBox cbitem;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Button btcommit;
		internal System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.ListBox lbref;
		private System.Windows.Forms.TabControl childtc;
		private System.Windows.Forms.GroupBox gbtypes;
		private System.Windows.Forms.Panel pntypes;
		internal System.Windows.Forms.LinkLabel lladd;
		internal System.Windows.Forms.LinkLabel lldelete;
		internal System.Windows.Forms.TextBox tbsubtype;
		internal System.Windows.Forms.TextBox tbinstance;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbgroup;
		internal System.Windows.Forms.ComboBox cbtypes;
		private System.Windows.Forms.Button btref;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ListBox lbblocks;
		private System.Windows.Forms.Button btup;
		private System.Windows.Forms.Button btdown;
		private System.Windows.Forms.Button btadd;
		private System.Windows.Forms.Button btdel;
		private System.Windows.Forms.ComboBox cbblocks;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TabPage tpref;
		internal System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbrefgroup;
		private System.Windows.Forms.TextBox tbrefinst;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbfile;
		private System.Windows.Forms.LinkLabel linkLabel1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RcolForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			foreach (Interfaces.IAlias alias in Data.MetaData.FileTypes) cbtypes.Items.Add(alias);
#if DEBUG
#else
			//this.btcommit.Enabled = false;
#endif
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
			this.RcolPanel = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label1 = new System.Windows.Forms.Label();
			this.childtc = new System.Windows.Forms.TabControl();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbitem = new System.Windows.Forms.ComboBox();
			this.llfix = new System.Windows.Forms.LinkLabel();
			this.llhash = new System.Windows.Forms.LinkLabel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btref = new System.Windows.Forms.Button();
			this.gbtypes = new System.Windows.Forms.GroupBox();
			this.pntypes = new System.Windows.Forms.Panel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.lldelete = new System.Windows.Forms.LinkLabel();
			this.tbsubtype = new System.Windows.Forms.TextBox();
			this.tbinstance = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbgroup = new System.Windows.Forms.TextBox();
			this.cbtypes = new System.Windows.Forms.ComboBox();
			this.lbref = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.cbblocks = new System.Windows.Forms.ComboBox();
			this.btdel = new System.Windows.Forms.Button();
			this.btadd = new System.Windows.Forms.Button();
			this.btdown = new System.Windows.Forms.Button();
			this.btup = new System.Windows.Forms.Button();
			this.lbblocks = new System.Windows.Forms.ListBox();
			this.tpref = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbfile = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbrefinst = new System.Windows.Forms.TextBox();
			this.tbrefgroup = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tv = new System.Windows.Forms.TreeView();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.btcommit = new System.Windows.Forms.Button();
			this.RcolPanel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gbtypes.SuspendLayout();
			this.pntypes.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tpref.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// RcolPanel
			// 
			this.RcolPanel.Controls.Add(this.tabControl1);
			this.RcolPanel.Controls.Add(this.panel2);
			this.RcolPanel.Location = new System.Drawing.Point(40, 35);
			this.RcolPanel.Name = "RcolPanel";
			this.RcolPanel.Size = new System.Drawing.Size(768, 301);
			this.RcolPanel.TabIndex = 20;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tpref);
			this.tabControl1.Location = new System.Drawing.Point(8, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(752, 261);
			this.tabControl1.TabIndex = 20;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.childtc);
			this.tabPage1.Controls.Add(this.tbflname);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.cbitem);
			this.tabPage1.Controls.Add(this.llfix);
			this.tabPage1.Controls.Add(this.llhash);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(744, 235);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Content";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 17);
			this.label1.TabIndex = 21;
			this.label1.Text = "Filename:";
			// 
			// childtc
			// 
			this.childtc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.childtc.Location = new System.Drawing.Point(16, 56);
			this.childtc.Multiline = true;
			this.childtc.Name = "childtc";
			this.childtc.SelectedIndex = 0;
			this.childtc.Size = new System.Drawing.Size(720, 176);
			this.childtc.TabIndex = 20;
			// 
			// tbflname
			// 
			this.tbflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbflname.Location = new System.Drawing.Point(88, 32);
			this.tbflname.Name = "tbflname";
			this.tbflname.Size = new System.Drawing.Size(504, 21);
			this.tbflname.TabIndex = 9;
			this.tbflname.Text = "";
			this.tbflname.TextChanged += new System.EventHandler(this.ChangeFileName);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(20, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Blocklist:";
			// 
			// cbitem
			// 
			this.cbitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbitem.Location = new System.Drawing.Point(88, 8);
			this.cbitem.Name = "cbitem";
			this.cbitem.Size = new System.Drawing.Size(648, 21);
			this.cbitem.TabIndex = 7;
			this.cbitem.SelectedIndexChanged += new System.EventHandler(this.SelectRcolItem);
			// 
			// llfix
			// 
			this.llfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llfix.AutoSize = true;
			this.llfix.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llfix.Location = new System.Drawing.Point(600, 40);
			this.llfix.Name = "llfix";
			this.llfix.Size = new System.Drawing.Size(47, 17);
			this.llfix.TabIndex = 19;
			this.llfix.TabStop = true;
			this.llfix.Text = "fix TGI";
			this.llfix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FixTGI);
			// 
			// llhash
			// 
			this.llhash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llhash.AutoSize = true;
			this.llhash.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llhash.Location = new System.Drawing.Point(656, 40);
			this.llhash.Name = "llhash";
			this.llhash.Size = new System.Drawing.Size(81, 17);
			this.llhash.TabIndex = 18;
			this.llhash.TabStop = true;
			this.llhash.Text = "assign Hash";
			this.llhash.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BuildFilename);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btref);
			this.tabPage2.Controls.Add(this.gbtypes);
			this.tabPage2.Controls.Add(this.lbref);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(744, 235);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Reference";
			// 
			// btref
			// 
			this.btref.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btref.Font = new System.Drawing.Font("Wingdings 3", 8.25F, System.Drawing.FontStyle.Bold);
			this.btref.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btref.Location = new System.Drawing.Point(368, 4);
			this.btref.Name = "btref";
			this.btref.Size = new System.Drawing.Size(21, 21);
			this.btref.TabIndex = 42;
			this.btref.Text = "u";
			this.btref.Click += new System.EventHandler(this.ShowPackageSelector);
			// 
			// gbtypes
			// 
			this.gbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbtypes.Controls.Add(this.pntypes);
			this.gbtypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbtypes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.gbtypes.Location = new System.Drawing.Point(296, 8);
			this.gbtypes.Name = "gbtypes";
			this.gbtypes.Size = new System.Drawing.Size(440, 128);
			this.gbtypes.TabIndex = 20;
			this.gbtypes.TabStop = false;
			this.gbtypes.Text = "Settings";
			// 
			// pntypes
			// 
			this.pntypes.Controls.Add(this.lladd);
			this.pntypes.Controls.Add(this.lldelete);
			this.pntypes.Controls.Add(this.tbsubtype);
			this.pntypes.Controls.Add(this.tbinstance);
			this.pntypes.Controls.Add(this.label11);
			this.pntypes.Controls.Add(this.tbtype);
			this.pntypes.Controls.Add(this.label8);
			this.pntypes.Controls.Add(this.label9);
			this.pntypes.Controls.Add(this.label10);
			this.pntypes.Controls.Add(this.tbgroup);
			this.pntypes.Controls.Add(this.cbtypes);
			this.pntypes.Location = new System.Drawing.Point(8, 24);
			this.pntypes.Name = "pntypes";
			this.pntypes.Size = new System.Drawing.Size(424, 96);
			this.pntypes.TabIndex = 19;
			// 
			// lladd
			// 
			this.lladd.AutoSize = true;
			this.lladd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.lladd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lladd.LinkArea = new System.Windows.Forms.LinkArea(0, 9);
			this.lladd.Location = new System.Drawing.Point(344, 80);
			this.lladd.Name = "lladd";
			this.lladd.Size = new System.Drawing.Size(28, 17);
			this.lladd.TabIndex = 19;
			this.lladd.TabStop = true;
			this.lladd.Text = "add";
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsAAdd);
			// 
			// lldelete
			// 
			this.lldelete.AutoSize = true;
			this.lldelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.lldelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lldelete.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
			this.lldelete.Location = new System.Drawing.Point(372, 80);
			this.lldelete.Name = "lldelete";
			this.lldelete.Size = new System.Drawing.Size(44, 17);
			this.lldelete.TabIndex = 18;
			this.lldelete.TabStop = true;
			this.lldelete.Text = "delete";
			this.lldelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsADelete);
			// 
			// tbsubtype
			// 
			this.tbsubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbsubtype.Location = new System.Drawing.Point(72, 24);
			this.tbsubtype.Name = "tbsubtype";
			this.tbsubtype.TabIndex = 12;
			this.tbsubtype.Text = "";
			this.tbsubtype.TextChanged += new System.EventHandler(this.AutoChangeReference);
			// 
			// tbinstance
			// 
			this.tbinstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbinstance.Location = new System.Drawing.Point(72, 72);
			this.tbinstance.Name = "tbinstance";
			this.tbinstance.TabIndex = 14;
			this.tbinstance.Text = "";
			this.tbinstance.TextChanged += new System.EventHandler(this.AutoChangeReference);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new System.Drawing.Point(10, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(58, 17);
			this.label11.TabIndex = 10;
			this.label11.Text = "Instance:";
			// 
			// tbtype
			// 
			this.tbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbtype.Location = new System.Drawing.Point(72, 0);
			this.tbtype.Name = "tbtype";
			this.tbtype.TabIndex = 11;
			this.tbtype.Text = "";
			this.tbtype.TextChanged += new System.EventHandler(this.tbtype_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "File Type:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new System.Drawing.Point(24, 56);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "Group:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new System.Drawing.Point(12, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 17);
			this.label10.TabIndex = 9;
			this.label10.Text = "Sub Typ:";
			// 
			// tbgroup
			// 
			this.tbgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbgroup.Location = new System.Drawing.Point(72, 48);
			this.tbgroup.Name = "tbgroup";
			this.tbgroup.TabIndex = 13;
			this.tbgroup.Text = "";
			this.tbgroup.TextChanged += new System.EventHandler(this.AutoChangeReference);
			// 
			// cbtypes
			// 
			this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cbtypes.ItemHeight = 13;
			this.cbtypes.Location = new System.Drawing.Point(176, 0);
			this.cbtypes.Name = "cbtypes";
			this.cbtypes.Size = new System.Drawing.Size(240, 21);
			this.cbtypes.Sorted = true;
			this.cbtypes.TabIndex = 16;
			this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.SelectType);
			// 
			// lbref
			// 
			this.lbref.AllowDrop = true;
			this.lbref.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbref.IntegralHeight = false;
			this.lbref.Location = new System.Drawing.Point(8, 8);
			this.lbref.Name = "lbref";
			this.lbref.Size = new System.Drawing.Size(280, 221);
			this.lbref.TabIndex = 0;
			this.lbref.DragDrop += new System.Windows.Forms.DragEventHandler(this.PackageItemDrop);
			this.lbref.DragEnter += new System.Windows.Forms.DragEventHandler(this.PackageItemDragEnter);
			this.lbref.SelectedIndexChanged += new System.EventHandler(this.SelectReference);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.cbblocks);
			this.tabPage3.Controls.Add(this.btdel);
			this.tabPage3.Controls.Add(this.btadd);
			this.tabPage3.Controls.Add(this.btdown);
			this.tabPage3.Controls.Add(this.btup);
			this.tabPage3.Controls.Add(this.lbblocks);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(744, 235);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Edit Blocks";
			// 
			// cbblocks
			// 
			this.cbblocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbblocks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbblocks.Location = new System.Drawing.Point(384, 88);
			this.cbblocks.Name = "cbblocks";
			this.cbblocks.Size = new System.Drawing.Size(352, 21);
			this.cbblocks.Sorted = true;
			this.cbblocks.TabIndex = 5;
			// 
			// btdel
			// 
			this.btdel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btdel.Location = new System.Drawing.Point(384, 136);
			this.btdel.Name = "btdel";
			this.btdel.Size = new System.Drawing.Size(72, 23);
			this.btdel.TabIndex = 4;
			this.btdel.Text = "Delete";
			this.btdel.Click += new System.EventHandler(this.btdel_Click);
			// 
			// btadd
			// 
			this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btadd.Location = new System.Drawing.Point(384, 112);
			this.btadd.Name = "btadd";
			this.btadd.Size = new System.Drawing.Size(72, 23);
			this.btadd.TabIndex = 3;
			this.btadd.Text = "Add";
			this.btadd.Click += new System.EventHandler(this.btadd_Click);
			// 
			// btdown
			// 
			this.btdown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btdown.Location = new System.Drawing.Point(384, 40);
			this.btdown.Name = "btdown";
			this.btdown.Size = new System.Drawing.Size(48, 23);
			this.btdown.TabIndex = 2;
			this.btdown.Text = "Down";
			this.btdown.Click += new System.EventHandler(this.btdown_Click);
			// 
			// btup
			// 
			this.btup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btup.Location = new System.Drawing.Point(384, 16);
			this.btup.Name = "btup";
			this.btup.Size = new System.Drawing.Size(48, 23);
			this.btup.TabIndex = 1;
			this.btup.Text = "Up";
			this.btup.Click += new System.EventHandler(this.btup_Click);
			// 
			// lbblocks
			// 
			this.lbblocks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lbblocks.HorizontalScrollbar = true;
			this.lbblocks.IntegralHeight = false;
			this.lbblocks.Location = new System.Drawing.Point(8, 9);
			this.lbblocks.Name = "lbblocks";
			this.lbblocks.Size = new System.Drawing.Size(368, 216);
			this.lbblocks.TabIndex = 0;
			this.lbblocks.SelectedIndexChanged += new System.EventHandler(this.lbblocks_SelectedIndexChanged);
			// 
			// tpref
			// 
			this.tpref.Controls.Add(this.groupBox1);
			this.tpref.Controls.Add(this.tv);
			this.tpref.Location = new System.Drawing.Point(4, 22);
			this.tpref.Name = "tpref";
			this.tpref.Size = new System.Drawing.Size(744, 235);
			this.tpref.TabIndex = 3;
			this.tpref.Text = "All References";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tbfile);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.tbrefinst);
			this.groupBox1.Controls.Add(this.tbrefgroup);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(560, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 128);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Values";
			// 
			// tbfile
			// 
			this.tbfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbfile.Location = new System.Drawing.Point(16, 96);
			this.tbfile.Name = "tbfile";
			this.tbfile.ReadOnly = true;
			this.tbfile.Size = new System.Drawing.Size(152, 21);
			this.tbfile.TabIndex = 4;
			this.tbfile.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 80);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 17);
			this.label5.TabIndex = 5;
			this.label5.Text = "File:";
			// 
			// tbrefinst
			// 
			this.tbrefinst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrefinst.Location = new System.Drawing.Point(80, 50);
			this.tbrefinst.Name = "tbrefinst";
			this.tbrefinst.ReadOnly = true;
			this.tbrefinst.Size = new System.Drawing.Size(88, 21);
			this.tbrefinst.TabIndex = 3;
			this.tbrefinst.Text = "0x00000000";
			// 
			// tbrefgroup
			// 
			this.tbrefgroup.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrefgroup.Location = new System.Drawing.Point(80, 24);
			this.tbrefgroup.Name = "tbrefgroup";
			this.tbrefgroup.ReadOnly = true;
			this.tbrefgroup.Size = new System.Drawing.Size(88, 21);
			this.tbrefgroup.TabIndex = 2;
			this.tbrefgroup.Text = "0x00000000";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 17);
			this.label4.TabIndex = 1;
			this.label4.Text = "Instance:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(30, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Group:";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(40, 80);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(44, 17);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "reload";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// tv
			// 
			this.tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tv.HideSelection = false;
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(8, 8);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(544, 216);
			this.tv.TabIndex = 0;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectRefItem);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.label27);
			this.panel2.Controls.Add(this.btcommit);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 24);
			this.panel2.TabIndex = 0;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(148, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Generic Rcol Editor";
			// 
			// btcommit
			// 
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btcommit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btcommit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btcommit.Location = new System.Drawing.Point(688, 0);
			this.btcommit.Name = "btcommit";
			this.btcommit.TabIndex = 6;
			this.btcommit.Text = "Commit";
			this.btcommit.Click += new System.EventHandler(this.Commit);
			// 
			// RcolForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(848, 358);
			this.Controls.Add(this.RcolPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "RcolForm";
			this.Text = "RcolForm";
			this.RcolPanel.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.gbtypes.ResumeLayout(false);
			this.pntypes.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tpref.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Rcol wrapper = null;

		internal void BuildChildTabControl(AbstractRcolBlock rb)
		{
			childtc.TabPages.Clear();

			if (rb==null) return;
			if (rb.TabPage!=null) rb.AddToTabControl(childtc);
		}

		private void SelectRcolItem(object sender, System.EventArgs e)
		{
			if (cbitem.Tag!=null) return;
			if (cbitem.SelectedIndex<0) return;
			try 
			{
				cbitem.Tag = true;
				AbstractRcolBlock rb = (AbstractRcolBlock)cbitem.Items[cbitem.SelectedIndex];
				tbflname.Enabled = (rb.NameResource!=null);
				llhash.Enabled = tbflname.Enabled;
				llfix.Enabled = tbflname.Enabled;

				if (rb.NameResource!=null) tbflname.Text = rb.NameResource.FileName;
				else tbflname.Text = "";

				BuildChildTabControl(rb);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally
			{
				cbitem.Tag = null;
			}
		}

		private void ChangeFileName(object sender, System.EventArgs e)
		{
			if (cbitem.Tag!=null) return;
			if (cbitem.SelectedIndex<0) return;
			try 
			{
				cbitem.Tag = true;
				AbstractRcolBlock rb = (AbstractRcolBlock)cbitem.Items[cbitem.SelectedIndex];
				if (rb.NameResource!=null) 
				{
					rb.NameResource.FileName = tbflname.Text;
					cbitem.Items[cbitem.SelectedIndex] = rb;
					cbitem.Text = rb.ToString();
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			}
			
			finally 
			{
				cbitem.Tag = null;
			}
		}

		private void BuildFilename(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string fl = Hashes.StripHashFromName(this.tbflname.Text);
			this.tbflname.Text = Hashes.AssembleHashedFileName(wrapper.Package.FileGroupHash, fl);
		}

		private void FixTGI(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string fl = Hashes.StripHashFromName(this.tbflname.Text);
			wrapper.FileDescriptor.Instance = Hashes.InstanceHash(fl);
			wrapper.FileDescriptor.SubType = Hashes.SubTypeHash(fl);
		}

		private void Commit(object sender, System.EventArgs e)
		{
			try 
			{
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void SelectType(object sender, System.EventArgs e)
		{
			if (cbtypes.Tag != null) return;
			tbtype.Text = "0x"+Helper.HexString(((SimPe.Data.TypeAlias)cbtypes.Items[cbtypes.SelectedIndex]).Id);
		}

		protected void Change() 
		{
			if (lbref.Tag!=null) return;
			if (lbref.SelectedIndex<0) return;
			try 
			{
				lbref.Tag = true;
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)this.lbref.Items[lbref.SelectedIndex];

				pfd.Type = Convert.ToUInt32(this.tbtype.Text, 16);
				pfd.SubType = Convert.ToUInt32(this.tbsubtype.Text, 16);
				pfd.Group = Convert.ToUInt32(this.tbgroup.Text, 16);
				pfd.Instance = Convert.ToUInt32(this.tbinstance.Text, 16);

				lbref.Items[lbref.SelectedIndex] = pfd;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lbref.Tag = null;
			}
		}

		private void tbtype_TextChanged(object sender, System.EventArgs e)
		{
			Change();

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

		private void SelectReference(object sender, System.EventArgs e)
		{
			if (lbref.Tag!=null) return;
			if (lbref.SelectedIndex<0) return;
			try 
			{
				lbref.Tag = true;
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)this.lbref.Items[lbref.SelectedIndex];
				this.tbtype.Text = "0x"+Helper.HexString(pfd.Type);
				this.tbsubtype.Text = "0x"+Helper.HexString(pfd.SubType);
				this.tbgroup.Text = "0x"+Helper.HexString(pfd.Group);
				this.tbinstance.Text = "0x"+Helper.HexString(pfd.Instance);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lbref.Tag = null;
			}
		}

		private void AutoChangeReference(object sender, System.EventArgs e)
		{
			Change();
		}

		private void SRNItemsAAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();

				pfd.Type = Convert.ToUInt32(this.tbtype.Text, 16);
				pfd.SubType = Convert.ToUInt32(this.tbsubtype.Text, 16);
				pfd.Group = Convert.ToUInt32(this.tbgroup.Text, 16);
				pfd.Instance = Convert.ToUInt32(this.tbinstance.Text, 16);

				wrapper.ReferencedFiles = (Interfaces.Files.IPackedFileDescriptor[])Helper.Add(wrapper.ReferencedFiles, pfd);
				this.lbref.Items.Add(pfd);

				wrapper.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void SRNItemsADelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbref.SelectedIndex<0) return;
			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)this.lbref.Items[lbref.SelectedIndex];
				
				wrapper.ReferencedFiles = (Interfaces.Files.IPackedFileDescriptor[])Helper.Delete(wrapper.ReferencedFiles, pfd);
				lbref.Items.Remove(pfd);

				wrapper.Changed = true;

				btup.Enabled = false;
				btdown.Enabled = false;
				btdel.Enabled = false;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		#region Package Selector
		private void ShowPackageSelector(object sender, System.EventArgs e)
		{
			SimPe.PackageSelectorForm form = new SimPe.PackageSelectorForm();
			form.Execute(wrapper.Package);
		}

		private void ItemQueryContinueDragTarget(object sender, QueryContinueDragEventArgs e)
		{
			if (e.KeyState==0) e.Action = DragAction.Drop;
			else e.Action = DragAction.Continue;
		}

		private void PackageItemDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(SimPe.Packages.PackedFileDescriptor))) 
			{				
				e.Effect = DragDropEffects.Copy;	
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}					
		}

		private void PackageItemDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try 
			{
				lbref.Tag = true;
				Interfaces.Files.IPackedFileDescriptor pfd = null;
				pfd = (Interfaces.Files.IPackedFileDescriptor)e.Data.GetData(typeof(SimPe.Packages.PackedFileDescriptor));
				
				wrapper.ReferencedFiles = (Interfaces.Files.IPackedFileDescriptor[])Helper.Add(wrapper.ReferencedFiles, pfd);
				this.lbref.Items.Add(pfd);

				wrapper.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lbref.Tag = null;
			}
		}
		#endregion

		protected void UpdateComboBox()
		{
			this.cbitem.Items.Clear();

			this.tbflname.Text = "";
			this.childtc.TabPages.Clear();
			foreach (object o in this.lbblocks.Items) cbitem.Items.Add(o);

			if (cbitem.Items.Count>0) cbitem.SelectedIndex = 0;
		}

		private void tabControl1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			//Display the Block Editor
			if (tabControl1.TabPages[tabControl1.SelectedIndex] == this.tabPage3) 
			{
				this.lbblocks.Items.Clear();
				foreach(IRcolBlock irb in wrapper.Blocks) lbblocks.Items.Add(irb);

				this.cbblocks.Items.Clear();
				foreach (string s in wrapper.Tokens.Keys)
				{
					try 
					{					
						IRcolBlock irb = (IRcolBlock)wrapper.Tokens[s];
						cbblocks.Items.Add(irb);
					}
					catch (Exception ex) 
					{
						Helper.ExceptionMessage("Error in Block "+s, ex);
					}
				} //foreach
				if (cbblocks.Items.Count>0) cbblocks.SelectedIndex = 0;
			}
		}

		private void btup_Click(object sender, System.EventArgs e)
		{
			if (lbblocks.SelectedIndex<1) return;
			try 
			{
				object o = lbblocks.Items[lbblocks.SelectedIndex-1];
				lbblocks.Items[lbblocks.SelectedIndex-1] = lbblocks.Items[lbblocks.SelectedIndex];
				lbblocks.Items[lbblocks.SelectedIndex] = o;

				wrapper.Blocks[lbblocks.SelectedIndex] = (AbstractRcolBlock)lbblocks.Items[lbblocks.SelectedIndex];
				wrapper.Blocks[lbblocks.SelectedIndex-1] = (AbstractRcolBlock)lbblocks.Items[lbblocks.SelectedIndex-1];
				lbblocks.SelectedIndex--;

				UpdateComboBox();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void btdown_Click(object sender, System.EventArgs e)
		{
			if (lbblocks.SelectedIndex<0) return;
			if (lbblocks.SelectedIndex>lbblocks.Items.Count-2) return;
			try 
			{
				object o = lbblocks.Items[lbblocks.SelectedIndex+1];
				lbblocks.Items[lbblocks.SelectedIndex+1] = lbblocks.Items[lbblocks.SelectedIndex];
				lbblocks.Items[lbblocks.SelectedIndex] = o;
				wrapper.Blocks[lbblocks.SelectedIndex] = (AbstractRcolBlock)lbblocks.Items[lbblocks.SelectedIndex];
				wrapper.Blocks[lbblocks.SelectedIndex+1] = (AbstractRcolBlock)lbblocks.Items[lbblocks.SelectedIndex+1];
				lbblocks.SelectedIndex++;

				UpdateComboBox();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void btadd_Click(object sender, System.EventArgs e)
		{
			try 
			{
				IRcolBlock irb = ((IRcolBlock)cbblocks.Items[cbblocks.SelectedIndex]).Create();
				this.lbblocks.Items.Add(irb);
				wrapper.Blocks = (IRcolBlock[])Helper.Add(wrapper.Blocks, irb, typeof(IRcolBlock));
				UpdateComboBox();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void lbblocks_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			btup.Enabled = false;
			btdown.Enabled = false;
			if (lbblocks.SelectedIndex<0) return;
			btup.Enabled = true;
			btdown.Enabled = true;
		}

		private void btdel_Click(object sender, System.EventArgs e)
		{
			if (lbblocks.SelectedIndex<0) return;
			try 
			{
				IRcolBlock irb = ((IRcolBlock)lbblocks.Items[lbblocks.SelectedIndex]);
				this.lbblocks.Items.Remove(irb);
				wrapper.Blocks = (IRcolBlock[])Helper.Delete(wrapper.Blocks, irb, typeof(IRcolBlock));

				UpdateComboBox();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void SelectRefItem(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e.Node.Tag!=null) 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)e.Node.Tag;
				tbrefgroup.Text = "0x"+Helper.HexString(pfd.Group);
				tbrefinst.Text = "0x"+Helper.HexString(pfd.Instance);

				SimPe.FileTable.FileIndex.Load();
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(pfd);
				if (items.Length>0) 
				{
					tbfile.Text = items[0].Package.FileName;
				} 
				else 
				{
					tbfile.Text = "[unreferenced]";
				}
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			WaitingScreen.Wait();
			SimPe.FileTable.FileIndex.ForceReload();
			WaitingScreen.Stop();
		}

		/*private void childtc_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lbblocks.SelectedIndex<0) return;
			try 
			{
				IRcolBlock irb = (IRcolBlock)lbblocks.Items[lbblocks.SelectedIndex];
				this.lbblocks.Items.Remove(irb);
				wrapper.Blocks = (IRcolBlock[])Helper.Delete(wrapper.Blocks, irb, typeof(IRcolBlock));

				UpdateComboBox();
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}*/
	}
}
