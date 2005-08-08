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
	/// Zusammenfassung für DownloadScan.
	/// </summary>
	public class DownloadScan : System.Windows.Forms.Form
	{
		const string STR_NOT_EP = "either original Maxis or not EP Ready";
		const string STR_COMP_DIR = "Compressed Dir incomplete";
		const string STR_COMP_SIZE = "Corrupted compressed Size";
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.GroupBox lbdir;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.TextBox tbfilename;
		private System.Windows.Forms.LinkLabel llopen;
		private System.Windows.Forms.LinkLabel lldis;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ProgressBar pb;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbcompress;
		private System.Windows.Forms.CheckBox cbguid;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.LinkLabel llfix;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.CheckBox cbready;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.LinkLabel llskin;
		private System.Windows.Forms.CheckBox cbbaby;
		private System.Windows.Forms.CheckBox cbtoddler;
		private System.Windows.Forms.CheckBox cbchild;
		private System.Windows.Forms.CheckBox cbteen;
		private System.Windows.Forms.CheckBox cbyoung;
		private System.Windows.Forms.CheckBox cbadult;
		private System.Windows.Forms.CheckBox cbelder;
		private System.Windows.Forms.GroupBox gbskin;
		private System.Windows.Forms.ImageList iList;
		private System.Windows.Forms.CheckBox cbprev;
		private System.Windows.Forms.PictureBox pbprev;
		private System.Windows.Forms.CheckBox cbact;
		private System.Windows.Forms.CheckBox cbskin;
		private System.Windows.Forms.CheckBox cbformal;
		private System.Windows.Forms.CheckBox cbpreg;
		private System.Windows.Forms.CheckBox cbundies;
		private System.Windows.Forms.CheckBox cbpj;
		private System.Windows.Forms.CheckBox cbevery;
		private System.Windows.Forms.CheckBox cbswim;
		private System.Windows.Forms.LinkLabel llcomp;

		internal Interfaces.IProviderRegistry prov;
		public DownloadScan()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			this.comboBox1.SelectedIndex = 0;
			Select(null, null);

			sorter = new ColumnSorter();

			if (Helper.WindowsRegistry.Username.Trim()!="")
				this.tbname.Text = Helper.WindowsRegistry.Username+"-";
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.lbdir = new System.Windows.Forms.GroupBox();
			this.llcomp = new System.Windows.Forms.LinkLabel();
			this.pbprev = new System.Windows.Forms.PictureBox();
			this.gbskin = new System.Windows.Forms.GroupBox();
			this.cbswim = new System.Windows.Forms.CheckBox();
			this.cbact = new System.Windows.Forms.CheckBox();
			this.cbskin = new System.Windows.Forms.CheckBox();
			this.cbformal = new System.Windows.Forms.CheckBox();
			this.cbpreg = new System.Windows.Forms.CheckBox();
			this.cbundies = new System.Windows.Forms.CheckBox();
			this.cbpj = new System.Windows.Forms.CheckBox();
			this.cbevery = new System.Windows.Forms.CheckBox();
			this.cbelder = new System.Windows.Forms.CheckBox();
			this.cbadult = new System.Windows.Forms.CheckBox();
			this.cbyoung = new System.Windows.Forms.CheckBox();
			this.cbteen = new System.Windows.Forms.CheckBox();
			this.cbchild = new System.Windows.Forms.CheckBox();
			this.cbtoddler = new System.Windows.Forms.CheckBox();
			this.cbbaby = new System.Windows.Forms.CheckBox();
			this.llskin = new System.Windows.Forms.LinkLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.llfix = new System.Windows.Forms.LinkLabel();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lldis = new System.Windows.Forms.LinkLabel();
			this.llopen = new System.Windows.Forms.LinkLabel();
			this.tbfilename = new System.Windows.Forms.TextBox();
			this.lv = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbprev = new System.Windows.Forms.CheckBox();
			this.cbready = new System.Windows.Forms.CheckBox();
			this.cbguid = new System.Windows.Forms.CheckBox();
			this.cbcompress = new System.Windows.Forms.CheckBox();
			this.iList = new System.Windows.Forms.ImageList(this.components);
			this.lbdir.SuspendLayout();
			this.gbskin.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Items.AddRange(new object[] {
														   "Download Folder",
														   "Teleport Folder",
														   "..."});
			this.comboBox1.Location = new System.Drawing.Point(8, 8);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(776, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.Select);
			// 
			// lbdir
			// 
			this.lbdir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbdir.Controls.Add(this.llcomp);
			this.lbdir.Controls.Add(this.pbprev);
			this.lbdir.Controls.Add(this.gbskin);
			this.lbdir.Controls.Add(this.groupBox2);
			this.lbdir.Controls.Add(this.lldis);
			this.lbdir.Controls.Add(this.llopen);
			this.lbdir.Controls.Add(this.tbfilename);
			this.lbdir.Controls.Add(this.lv);
			this.lbdir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbdir.Location = new System.Drawing.Point(8, 104);
			this.lbdir.Name = "lbdir";
			this.lbdir.Size = new System.Drawing.Size(776, 452);
			this.lbdir.TabIndex = 1;
			this.lbdir.TabStop = false;
			this.lbdir.Text = "---";
			// 
			// llcomp
			// 
			this.llcomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llcomp.AutoSize = true;
			this.llcomp.Enabled = false;
			this.llcomp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llcomp.Location = new System.Drawing.Point(584, 80);
			this.llcomp.Name = "llcomp";
			this.llcomp.Size = new System.Drawing.Size(106, 17);
			this.llcomp.TabIndex = 11;
			this.llcomp.TabStop = true;
			this.llcomp.Text = "fix Compression";
			this.llcomp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FixCompression);
			// 
			// pbprev
			// 
			this.pbprev.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pbprev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbprev.Location = new System.Drawing.Point(584, 408);
			this.pbprev.Name = "pbprev";
			this.pbprev.Size = new System.Drawing.Size(184, 40);
			this.pbprev.TabIndex = 10;
			this.pbprev.TabStop = false;
			// 
			// gbskin
			// 
			this.gbskin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbskin.Controls.Add(this.cbswim);
			this.gbskin.Controls.Add(this.cbact);
			this.gbskin.Controls.Add(this.cbskin);
			this.gbskin.Controls.Add(this.cbformal);
			this.gbskin.Controls.Add(this.cbpreg);
			this.gbskin.Controls.Add(this.cbundies);
			this.gbskin.Controls.Add(this.cbpj);
			this.gbskin.Controls.Add(this.cbevery);
			this.gbskin.Controls.Add(this.cbelder);
			this.gbskin.Controls.Add(this.cbadult);
			this.gbskin.Controls.Add(this.cbyoung);
			this.gbskin.Controls.Add(this.cbteen);
			this.gbskin.Controls.Add(this.cbchild);
			this.gbskin.Controls.Add(this.cbtoddler);
			this.gbskin.Controls.Add(this.cbbaby);
			this.gbskin.Controls.Add(this.llskin);
			this.gbskin.Enabled = false;
			this.gbskin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbskin.Location = new System.Drawing.Point(584, 192);
			this.gbskin.Name = "gbskin";
			this.gbskin.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.gbskin.Size = new System.Drawing.Size(184, 208);
			this.gbskin.TabIndex = 9;
			this.gbskin.TabStop = false;
			// 
			// cbswim
			// 
			this.cbswim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbswim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbswim.Location = new System.Drawing.Point(96, 120);
			this.cbswim.Name = "cbswim";
			this.cbswim.Size = new System.Drawing.Size(80, 24);
			this.cbswim.TabIndex = 21;
			this.cbswim.Text = "Swim.";
			// 
			// cbact
			// 
			this.cbact.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbact.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbact.Location = new System.Drawing.Point(96, 180);
			this.cbact.Name = "cbact";
			this.cbact.Size = new System.Drawing.Size(64, 24);
			this.cbact.TabIndex = 20;
			this.cbact.Text = "Active";
			// 
			// cbskin
			// 
			this.cbskin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbskin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbskin.Location = new System.Drawing.Point(96, 160);
			this.cbskin.Name = "cbskin";
			this.cbskin.Size = new System.Drawing.Size(64, 24);
			this.cbskin.TabIndex = 19;
			this.cbskin.Text = "Skin";
			// 
			// cbformal
			// 
			this.cbformal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbformal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbformal.Location = new System.Drawing.Point(96, 140);
			this.cbformal.Name = "cbformal";
			this.cbformal.Size = new System.Drawing.Size(80, 24);
			this.cbformal.TabIndex = 18;
			this.cbformal.Text = "Formal";
			// 
			// cbpreg
			// 
			this.cbpreg.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbpreg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpreg.Location = new System.Drawing.Point(16, 180);
			this.cbpreg.Name = "cbpreg";
			this.cbpreg.Size = new System.Drawing.Size(64, 24);
			this.cbpreg.TabIndex = 17;
			this.cbpreg.Text = "Preg.";
			// 
			// cbundies
			// 
			this.cbundies.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbundies.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbundies.Location = new System.Drawing.Point(16, 160);
			this.cbundies.Name = "cbundies";
			this.cbundies.Size = new System.Drawing.Size(64, 24);
			this.cbundies.TabIndex = 16;
			this.cbundies.Text = "Undies";
			// 
			// cbpj
			// 
			this.cbpj.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpj.Location = new System.Drawing.Point(16, 140);
			this.cbpj.Name = "cbpj";
			this.cbpj.Size = new System.Drawing.Size(64, 24);
			this.cbpj.TabIndex = 15;
			this.cbpj.Text = "PJ";
			// 
			// cbevery
			// 
			this.cbevery.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbevery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbevery.Location = new System.Drawing.Point(16, 120);
			this.cbevery.Name = "cbevery";
			this.cbevery.Size = new System.Drawing.Size(80, 24);
			this.cbevery.TabIndex = 14;
			this.cbevery.Text = "Everyday";
			// 
			// cbelder
			// 
			this.cbelder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbelder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbelder.Location = new System.Drawing.Point(96, 84);
			this.cbelder.Name = "cbelder";
			this.cbelder.Size = new System.Drawing.Size(64, 24);
			this.cbelder.TabIndex = 13;
			this.cbelder.Text = "Elder";
			// 
			// cbadult
			// 
			this.cbadult.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbadult.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbadult.Location = new System.Drawing.Point(96, 64);
			this.cbadult.Name = "cbadult";
			this.cbadult.Size = new System.Drawing.Size(64, 24);
			this.cbadult.TabIndex = 12;
			this.cbadult.Text = "Adult";
			// 
			// cbyoung
			// 
			this.cbyoung.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbyoung.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbyoung.Location = new System.Drawing.Point(96, 24);
			this.cbyoung.Name = "cbyoung";
			this.cbyoung.Size = new System.Drawing.Size(64, 32);
			this.cbyoung.TabIndex = 11;
			this.cbyoung.Text = "young Adult";
			// 
			// cbteen
			// 
			this.cbteen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbteen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbteen.Location = new System.Drawing.Point(16, 84);
			this.cbteen.Name = "cbteen";
			this.cbteen.Size = new System.Drawing.Size(64, 24);
			this.cbteen.TabIndex = 10;
			this.cbteen.Text = "teen";
			// 
			// cbchild
			// 
			this.cbchild.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbchild.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbchild.Location = new System.Drawing.Point(16, 64);
			this.cbchild.Name = "cbchild";
			this.cbchild.Size = new System.Drawing.Size(64, 24);
			this.cbchild.TabIndex = 9;
			this.cbchild.Text = "child";
			// 
			// cbtoddler
			// 
			this.cbtoddler.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbtoddler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbtoddler.Location = new System.Drawing.Point(16, 44);
			this.cbtoddler.Name = "cbtoddler";
			this.cbtoddler.Size = new System.Drawing.Size(64, 24);
			this.cbtoddler.TabIndex = 8;
			this.cbtoddler.Text = "toddler";
			// 
			// cbbaby
			// 
			this.cbbaby.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbbaby.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbbaby.Location = new System.Drawing.Point(16, 24);
			this.cbbaby.Name = "cbbaby";
			this.cbbaby.Size = new System.Drawing.Size(64, 24);
			this.cbbaby.TabIndex = 7;
			this.cbbaby.Text = "baby";
			// 
			// llskin
			// 
			this.llskin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llskin.AutoSize = true;
			this.llskin.Enabled = false;
			this.llskin.Location = new System.Drawing.Point(8, 0);
			this.llskin.Name = "llskin";
			this.llskin.Size = new System.Drawing.Size(55, 17);
			this.llskin.TabIndex = 6;
			this.llskin.TabStop = true;
			this.llskin.Text = "set Skin";
			this.llskin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetSkinAge);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.llfix);
			this.groupBox2.Controls.Add(this.tbname);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Location = new System.Drawing.Point(584, 104);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(184, 72);
			this.groupBox2.TabIndex = 8;
			this.groupBox2.TabStop = false;
			// 
			// llfix
			// 
			this.llfix.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llfix.AutoSize = true;
			this.llfix.Enabled = false;
			this.llfix.Location = new System.Drawing.Point(8, 0);
			this.llfix.Name = "llfix";
			this.llfix.Size = new System.Drawing.Size(102, 17);
			this.llfix.TabIndex = 5;
			this.llfix.TabStop = true;
			this.llfix.Text = "make EP Ready";
			this.llfix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Fix);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(24, 45);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(152, 21);
			this.tbname.TabIndex = 7;
			this.tbname.Text = "SimPE-";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(128, 16);
			this.label1.TabIndex = 6;
			this.label1.Text = "using Modelname";
			// 
			// lldis
			// 
			this.lldis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lldis.AutoSize = true;
			this.lldis.Enabled = false;
			this.lldis.Location = new System.Drawing.Point(584, 64);
			this.lldis.Name = "lldis";
			this.lldis.Size = new System.Drawing.Size(50, 17);
			this.lldis.TabIndex = 4;
			this.lldis.TabStop = true;
			this.lldis.Text = "disable";
			this.lldis.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Disable);
			// 
			// llopen
			// 
			this.llopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llopen.AutoSize = true;
			this.llopen.Enabled = false;
			this.llopen.Location = new System.Drawing.Point(584, 48);
			this.llopen.Name = "llopen";
			this.llopen.Size = new System.Drawing.Size(35, 17);
			this.llopen.TabIndex = 3;
			this.llopen.TabStop = true;
			this.llopen.Text = "open";
			this.llopen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Openpackage);
			// 
			// tbfilename
			// 
			this.tbfilename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbfilename.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbfilename.Location = new System.Drawing.Point(584, 24);
			this.tbfilename.Name = "tbfilename";
			this.tbfilename.ReadOnly = true;
			this.tbfilename.Size = new System.Drawing.Size(184, 21);
			this.tbfilename.TabIndex = 2;
			this.tbfilename.Text = "";
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.columnHeader1,
																				 this.columnHeader2,
																				 this.columnHeader5,
																				 this.columnHeader4,
																				 this.columnHeader3});
			this.lv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lv.FullRowSelect = true;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 24);
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(568, 420);
			this.lv.TabIndex = 1;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Sort);
			this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectPackage);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Package File";
			this.columnHeader1.Width = 192;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Content";
			this.columnHeader2.Width = 146;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "GUID";
			this.columnHeader5.Width = 75;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Enabled";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "State";
			this.columnHeader3.Width = 89;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(752, 32);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(33, 17);
			this.linkLabel1.TabIndex = 0;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "scan";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Scan);
			// 
			// pb
			// 
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pb.Location = new System.Drawing.Point(0, 556);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(792, 16);
			this.pb.Step = 1;
			this.pb.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbprev);
			this.groupBox1.Controls.Add(this.cbready);
			this.groupBox1.Controls.Add(this.cbguid);
			this.groupBox1.Controls.Add(this.cbcompress);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(272, 64);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Options";
			// 
			// cbprev
			// 
			this.cbprev.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbprev.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbprev.Location = new System.Drawing.Point(168, 36);
			this.cbprev.Name = "cbprev";
			this.cbprev.Size = new System.Drawing.Size(96, 24);
			this.cbprev.TabIndex = 3;
			this.cbprev.Text = "Preview";
			// 
			// cbready
			// 
			this.cbready.Checked = true;
			this.cbready.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbready.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbready.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbready.Location = new System.Drawing.Point(168, 16);
			this.cbready.Name = "cbready";
			this.cbready.Size = new System.Drawing.Size(96, 24);
			this.cbready.TabIndex = 2;
			this.cbready.Text = "EP Ready?";
			// 
			// cbguid
			// 
			this.cbguid.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbguid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbguid.Location = new System.Drawing.Point(16, 36);
			this.cbguid.Name = "cbguid";
			this.cbguid.Size = new System.Drawing.Size(96, 24);
			this.cbguid.TabIndex = 1;
			this.cbguid.Text = "Guid check";
			// 
			// cbcompress
			// 
			this.cbcompress.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbcompress.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbcompress.Location = new System.Drawing.Point(16, 16);
			this.cbcompress.Name = "cbcompress";
			this.cbcompress.Size = new System.Drawing.Size(136, 24);
			this.cbcompress.TabIndex = 0;
			this.cbcompress.Text = "Compression check";
			// 
			// iList
			// 
			this.iList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.iList.ImageSize = new System.Drawing.Size(48, 48);
			this.iList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// DownloadScan
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 574);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.lbdir);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.linkLabel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "DownloadScan";
			this.ShowInTaskbar = false;
			this.Text = "Scan Folders";
			this.lbdir.ResumeLayout(false);
			this.gbskin.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		string filename = null;
		public string FileName 
		{
			get { return filename; }
		}

		private void Select(object sender, System.EventArgs e)
		{
			if (comboBox1.SelectedIndex==2) 
			{
				if (fbd.ShowDialog()==DialogResult.OK) lbdir.Text = fbd.SelectedPath;
			} 
			else if (comboBox1.SelectedIndex==1) 
			{
				lbdir.Text = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Teleport");
			} 
			else 
			{
				lbdir.Text = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");
			}
		}

		/// <summary>
		/// returns true if the packages Compressed Directory is ok
		/// </summary>
		/// <param name="package"></param>
		/// <returns>0 if everything is ok, -1 if the List is incorrect, -2 if the uncompressed Sizes are wrong</returns>
		private int CheckCompressed(SimPe.Packages.File package)
		{
			bool incomplete = false;
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in package.Index) 
			{
				Interfaces.Files.IPackedFile file = package.Read(pfd);

				int nr = -1;
				if (package.FileListFile!=null) nr = package.FileListFile.FindFile(pfd);
				bool inlist = (nr!=-1);

				if (inlist) 
				{
					byte[] uncdata = file.UncompressedData;
					if (package.FileListFile.Items[nr].UncompressedSize != uncdata.Length) return -2;
				}
				
				if (inlist != file.IsCompressed) incomplete = true;
				
			}

			if (incomplete) return -1;
			return 0;
		}

		/// <summary>
		/// returns the Guid of this Object (if found)
		/// </summary>
		/// <param name="package"></param>
		/// <returns>0 or a Guid</returns>
		private uint[] CheckGuid(SimPe.Packages.File package)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			uint[] res = new uint[pfds.Length];

			for (int i=0; i<res.Length; i++) 
			{
				SimPe.PackedFiles.Wrapper.Objd objd = new SimPe.PackedFiles.Wrapper.Objd(null);
				objd.ProcessData(pfds[i], package);
				res[i] = objd.SimId;
			}
			return res;
		}

		protected void AddFiles(string[] files, string note, int count, int offset) 
		{			
			ArrayList guids = new ArrayList();
			ArrayList aguids = new ArrayList();
			if ((this.cbguid.Checked) && (this.prov!=null))
			{				
				foreach(uint g in prov.OpcodeProvider.StoredMemories.Keys) 
				{
					if (aguids.Contains(g)) guids.Add(g);
					else aguids.Add(g);
				}
			}
			
			foreach (string file in files)
			{
				int val = (offset++  * pb.Maximum) / count;
				if (val>pb.Value) pb.PerformStep();
				if (val>pb.Value) pb.Value = val;
				string name = System.IO.Path.GetFileNameWithoutExtension(file);
				string desc = SimPe.Localization.Manager.GetString("Unknown");
				string state = "OK";
				uint[] guid = new uint[0];
				Image img = null;

				try 
				{					
					SimPe.Packages.File package = SimPe.Packages.File.LoadFromFile(file);					

					//find Texture
					Interfaces.Files.IPackedFileDescriptor[] pfds = null;
					try 
					{
						if (cbprev.Checked) 
						{
							pfds = package.FindFiles(Data.MetaData.TXTR);
							if (pfds.Length>0) 
							{
								SimPe.Plugin.Txtr txtr = new Txtr(null, false);
								txtr.ProcessData(pfds[0], package);

								SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)txtr.Blocks[0];
								MipMap mm = id.GetLargestTexture(iList.ImageSize);
								if (mm!=null) 
								{
									img = ImageLoader.Preview(mm.Texture, iList.ImageSize);
								}
							}	
						}//if
					} 
					catch {}
					
					//find Name
					pfds = package.FindFiles(Data.MetaData.CTSS_FILE);
					if (pfds.Length==0) pfds = package.FindFiles(Data.MetaData.STRING_FILE);				
					if (pfds.Length>0) 
					{
						SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
						str.ProcessData(pfds[0], package);
						SimPe.PackedFiles.Wrapper.StrItemList items = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);
						if (items!=null) if (items.Length>0) desc = items[0].Title;
					} 
					else 
					{
						//check if Recolor
						pfds = package.FindFiles(0x1C4A276C);	//TXTR
						if (pfds.Length>0) 
						{
							pfds = package.FindFiles(0x49596978);	//TXMT
							if (pfds.Length>0) 
							{
								pfds = package.FindFiles(0x4C697E5A);	//MMAT
								if (pfds.Length>0) 
								{
									SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
									mmat.ProcessData(pfds[0], package);
									desc = "[recolor] "+mmat.GetSaveItem("modelName").StringValue;
								}
							}
						}
					}

					bool isskin = false;
					pfds = package.FindFiles(Data.MetaData.GZPS);
					foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds)
					{
						SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
						cpf.ProcessData(pfd, package);

						desc = "["+cpf.GetSaveItem("type").StringValue+"] " + desc;
						isskin = true;
					}

					if (this.cbcompress.Checked) 
					{
						int ret = this.CheckCompressed(package);
						if (ret==-1) state = STR_COMP_DIR;
						if (ret==-2) state = STR_COMP_SIZE;
						//if (ret==-3) state = "Corrupted Compressed Dir";
					}

					if ((this.cbready.Checked) && (!isskin))
					{
						if ((System.IO.Path.GetFileName(package.FileName).Trim().ToLower()!= System.IO.Path.GetFileName(ScenegraphHelper.MMAT_PACKAGE).Trim().ToLower()) && (System.IO.Path.GetFileName(package.FileName).Trim().ToLower()!= System.IO.Path.GetFileName(ScenegraphHelper.GMND_PACKAGE).Trim().ToLower()) && (package.FindFilesByGroup(Data.MetaData.CUSTOM_GROUP).Length==0))
						{
							pfds = package.FindFiles(0x1C4A276C);	//TXTR
							if (pfds.Length>0) 
							{
								state = STR_NOT_EP;
							}
						}
					}

					if (this.cbguid.Checked) 
					{
						guid = this.CheckGuid(package);
						foreach (uint g in guid) 
						{
							if (g!=0) 
							{
								if (guids.Contains(g))
								{
									if (state=="OK") state = "Duplicate GUID";
									else state = "Duplicate GUID, "+state;
								} 
								else 
								{
									guids.Add(g);
								}
							}
						}//foreach
					
						//package.Reader.Close();
					}
				}
				catch (Exception ex)
				{
					state = "Not loaded, "+ex.Message;
				}

				ListViewItem lvi = new ListViewItem();
				lvi.Text = name;
				lvi.SubItems.Add(desc);
				lvi.Tag = file;
				if (guid.Length>0) 
				{
					string s = "";
					for (int i=0; i<guid.Length; i++) 
					{
						if (i!=0) s+= ", ";
						s += "0x"+Helper.HexString(guid[i]);
					}
					lvi.SubItems.Add(s);
				} else lvi.SubItems.Add("");
				lvi.SubItems.Add(note);
				lvi.SubItems.Add(state);

				if (img!=null) 
				{
					iList.Images.Add(img);
					lvi.ImageIndex = iList.Images.Count-1;					
				}

				lv.Items.Add(lvi);
				Application.DoEvents();
			}
		}

		private void Scan(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lv.Items.Clear();
			iList.Images.Clear();
			lv.SmallImageList = null;
			if (cbprev.Checked) iList.ImageSize = new Size(48, 48);
			else iList.ImageSize = new Size(16, 16);
			lv.SmallImageList = iList;

			lv.ListViewItemSorter = null;
			tbfilename.Text = "";
			pb.Value = 0;
			if (!System.IO.Directory.Exists(lbdir.Text)) return;

			this.Cursor = Cursors.WaitCursor;
			string[] files = System.IO.Directory.GetFiles(lbdir.Text, "*.package");
			string[] dis_files = System.IO.Directory.GetFiles(lbdir.Text, "*.simpedis");

			

			this.AddFiles(files, "yes", files.Length + dis_files.Length, 0);
			this.AddFiles(dis_files, "no", files.Length + dis_files.Length, files.Length);
			this.Cursor = Cursors.Default;

			lv.ListViewItemSorter = sorter;
			pb.Value = 0;
		}

		private ColumnSorter sorter;
		private void Sort(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{	
			if (((ListView)sender).ListViewItemSorter == null) return;
			sorter.CurrentColumn = e.Column;
			((ListView)sender).Sort();
		}

		void SetSkinBoxes(CheckBox cb, uint age, uint cmp)
		{
			if ((age & cmp) == cmp) 
			{				
				if (cb.CheckState == CheckState.Unchecked) cb.CheckState = CheckState.Checked;
			} 
			else 
			{
				if (cb.CheckState == CheckState.Checked) cb.CheckState = CheckState.Indeterminate;
			}
		}

		void SetSkinBoxes(SimPe.PackedFiles.Wrapper.Cpf cpf) 
		{
			uint age = cpf.GetSaveItem("age").UIntegerValue;
			uint cat = cpf.GetSaveItem("category").UIntegerValue;

			SetSkinBoxes(cbbaby, age, (uint)Data.Ages.Baby);
			SetSkinBoxes(cbtoddler, age, (uint)Data.Ages.Toddler);
			SetSkinBoxes(cbchild, age, (uint)Data.Ages.Child);
			SetSkinBoxes(cbteen, age, (uint)Data.Ages.Teen);
			SetSkinBoxes(cbyoung, age, (uint)Data.Ages.YoungAdult);
			SetSkinBoxes(cbadult, age, (uint)Data.Ages.Adult);
			SetSkinBoxes(cbelder, age, (uint)Data.Ages.Elder);

			SetSkinBoxes(cbact, cat, (uint)Data.SkinCategories.Activewear);
			SetSkinBoxes(cbevery, cat, (uint)Data.SkinCategories.Everyday);
			SetSkinBoxes(cbformal, cat, (uint)Data.SkinCategories.Formal);
			SetSkinBoxes(cbpj, cat, (uint)Data.SkinCategories.PJ);
			SetSkinBoxes(cbpreg, cat, (uint)Data.SkinCategories.Pregnant);
			SetSkinBoxes(cbskin, cat, (uint)Data.SkinCategories.Skin);
			SetSkinBoxes(cbswim, cat, (uint)Data.SkinCategories.Swimmwear);
			SetSkinBoxes(cbundies, cat, (uint)Data.SkinCategories.Undies);
		}

		void SetSkinBoxes(ListViewItem lvi)
		{
			if (lvi==null) 
			{
				this.cbbaby.CheckState = CheckState.Unchecked;
				this.cbtoddler.CheckState = CheckState.Unchecked;
				this.cbchild.CheckState = CheckState.Unchecked;
				this.cbteen.CheckState = CheckState.Unchecked;
				this.cbyoung.CheckState = CheckState.Unchecked;
				this.cbadult.CheckState = CheckState.Unchecked;
				this.cbelder.CheckState = CheckState.Unchecked;

				cbact.CheckState = CheckState.Unchecked;
			    cbevery.CheckState = CheckState.Unchecked;
			    cbformal.CheckState = CheckState.Unchecked;
			    cbpj.CheckState = CheckState.Unchecked;
			    cbpreg.CheckState = CheckState.Unchecked;
			    cbskin.CheckState = CheckState.Unchecked;
			    cbswim.CheckState = CheckState.Unchecked;
			    cbundies.CheckState = CheckState.Unchecked;
			} 
			else 
			{
				SimPe.Packages.File skin = SimPe.Packages.File.LoadFromFile((string)lvi.Tag);
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = skin.FindFiles(Data.MetaData.GZPS);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData(pfd, skin);

					if (cpf.GetSaveItem("type").StringValue == "skin") SetSkinBoxes(cpf);
				}
			}
		}

		delegate void ShowTextureDelegate(ListViewItem lvi);
		void ShowTexture(ListViewItem lvi)
		{
			if ((lvi==null) || (!cbprev.Checked))
			{
				pbprev.Image = null;
			} 
			else 
			{
				SimPe.Packages.File skin = SimPe.Packages.File.LoadFromFile((string)lvi.Tag);
				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = skin.FindFiles(Data.MetaData.TXTR);
				foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					SimPe.Plugin.Txtr txtr = new Txtr(null, false);
					txtr.ProcessData(pfd, skin);
					SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)txtr.Blocks[0];

					MipMap mm = id.GetLargestTexture(pb.Size);
					if (mm!=null) 
					{
						Image img = ImageLoader.Preview(mm.Texture, pbprev.Size);
						pbprev.Image = img;
					}
					break;
				}
			}
		}

		private void SelectPackage(object sender, System.EventArgs e)
		{
			tbfilename.Text = "";
			llopen.Enabled = false;
			lldis.Enabled = false;
			llfix.Enabled = false;
			llskin.Enabled = false;
			gbskin.Enabled = false;
			llcomp.Enabled = false;
			SetSkinBoxes((ListViewItem)null);

			if (lv.SelectedItems.Count==0) return;
			llopen.Enabled = lv.SelectedItems.Count==1;
			lldis.Enabled = true;

			foreach (ListViewItem lvi in lv.SelectedItems) 
			{
				if (lvi.SubItems[4].Text == STR_NOT_EP) 
				{
					llfix.Enabled = true;
				}	
				
				if ((lvi.SubItems[4].Text.IndexOf(STR_COMP_DIR)!=-1) || (lvi.SubItems[4].Text.IndexOf(STR_COMP_SIZE)!=-1)) 
				{
					llcomp.Enabled = true;
				}
			}

			if (Helper.WindowsRegistry.HiddenMode) llfix.Enabled = true;
		


			bool oner = (lv.SelectedItems.Count==1);
			foreach (ListViewItem lvi in lv.SelectedItems) 
			{
				if (lvi.SubItems[1].Text.StartsWith("[skin]")) 
				{					
					gbskin.Enabled = true;
					llskin.Enabled = true;
					SetSkinBoxes(lvi);
				}

				if ((lvi.SubItems[1].Text.StartsWith("[skin]")) || (lvi.SubItems[1].Text.StartsWith("[recolor]")))
				{									
					if (oner) 
					{
						object[] os = new object[1];
						os[0] = lvi;
						this.BeginInvoke(new ShowTextureDelegate(ShowTexture), os );
					}
				}					
			}

			tbfilename.Text = lv.SelectedItems[0].Text;

			if (System.IO.File.Exists(System.IO.Path.Combine(lbdir.Text, lv.SelectedItems[0].Text+".package"))) lldis.Text = "disable";
			else lldis.Text = "enable";
		}

		private void Openpackage(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;
			this.filename = System.IO.Path.Combine(lbdir.Text, lv.SelectedItems[0].Text+".package");
			if (!System.IO.File.Exists(filename)) filename = System.IO.Path.Combine(lbdir.Text, lv.SelectedItems[0].Text+".simpedis");
			
			if (!System.IO.File.Exists(filename)) filename = null;
			else Close();
		}

		private void Disable(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;

			foreach (ListViewItem lvi in lv.SelectedItems) 
			{
				string filename = System.IO.Path.Combine(lbdir.Text, lvi.Text+".package");
				string target = System.IO.Path.Combine(lbdir.Text, lvi.Text+".simpedis");

				SimPe.Packages.StreamItem si = SimPe.Packages.StreamFactory.GetStreamItem(filename, false);
				if (si!=null) si.Close();				
				si = SimPe.Packages.StreamFactory.GetStreamItem(target, false);
				if (si!=null) si.Close();
				try 
				{
					if (System.IO.File.Exists(filename)) 
					{
						System.IO.File.Move(filename, target);
						lvi.SubItems[3].Text = "no";
					}
					else 
					{
						System.IO.File.Move(target, filename);
						lvi.SubItems[3].Text = "yes";
					}
				} 
				catch (Exception ex){
					Helper.ExceptionMessage("", ex);
				}
				
			}

			SelectPackage(null, null);
		}

		private void Fix(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;

			string mname = tbname.Text;
			DateTime now = DateTime.Now;
			mname += now.Date.ToShortDateString();
			mname += "-"+now.Hour.ToString("x");
			mname += now.Minute.ToString("x");
			mname += now.Second.ToString("x");
			mname += now.Millisecond.ToString("x");
			//mname += "_"+System.DateTime.Now.Ticks.ToString();
			WaitingScreen.Wait();
			try 
			{
				int count = lv.Items.Count;
				int pos = 0;
				foreach (ListViewItem lvi in lv.SelectedItems) 
				{
					//only non EP Ready packages
					if ((!Helper.WindowsRegistry.HiddenMode) && (lvi.SubItems[4].Text != STR_NOT_EP)) continue;

					string filename = System.IO.Path.Combine(lbdir.Text, lvi.Text+".package");
					pb.Value = (pos++ * pb.Maximum) / count;
					Application.DoEvents();

					try 
					{
						SimPe.Commandline.FixPackage(filename, mname, FixVersion.UniversityReady2);
					} 
					catch (Exception ex)
					{
						Helper.ExceptionMessage("", ex);
					}
				
				}
				pb.Value = 0;
			} 
			finally 
			{
				WaitingScreen.Stop();
			}
			SelectPackage(null, null);
		}

		void SetSkinAge(CheckBox cb, ref uint age, uint cmp) 
		{
			if (cb.CheckState==CheckState.Indeterminate) return;

			age |= cmp;
			if (cb.CheckState==CheckState.Unchecked) age ^= cmp;
		}

		private void FixCompression(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count<1) return;

			for (int i=0; i<lv.SelectedItems.Count; i++) 
			{
				pb.Value = i * pb.Maximum / lv.SelectedItems.Count;
				Application.DoEvents();
				ListViewItem lvi = lv.SelectedItems[i];
				if ((lvi.SubItems[4].Text.IndexOf(STR_COMP_DIR)!=-1) || (lvi.SubItems[4].Text.IndexOf(STR_COMP_SIZE)!=-1)) 
				{
					this.filename = System.IO.Path.Combine(lbdir.Text, lvi.Text+".package");
					if (!System.IO.File.Exists(filename)) filename = System.IO.Path.Combine(lbdir.Text, lvi.Text+".simpedis");

					if (System.IO.File.Exists(filename)) 
					{
						SimPe.Packages.GeneratableFile pkg = SimPe.Packages.GeneratableFile.LoadFromFile(filename);
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
						{
							SimPe.Interfaces.Files.IPackedFile file = pkg.Read(pfd);
							pfd.UserData = file.UncompressedData;

							pfd.MarkForReCompress = (file.IsCompressed || Data.MetaData.CompressionCandidates.Contains(pfd.Type));							
						}

						pkg.Save();
					}
				}
			
			}
			pb.Value = 0;
		}

		void AddUniversityFields(SimPe.PackedFiles.Wrapper.Cpf cpf)
		{
			if (cpf.GetItem("product") == null) 
			{
				SimPe.PackedFiles.Wrapper.CpfItem i = new SimPe.PackedFiles.Wrapper.CpfItem();
				i.Name = "product";
				i.UIntegerValue = 1;
				cpf.AddItem(i);
			}

			if (cpf.GetItem("version") == null) 
			{
				SimPe.PackedFiles.Wrapper.CpfItem i = new SimPe.PackedFiles.Wrapper.CpfItem();
				i.Name = "version";
				i.UIntegerValue = 2;
				cpf.AddItem(i);
			}
		}

		bool hinted = false;
		private void SetSkinAge(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;

			uint age = 0;
			uint cat = 0;
			
			try 
			{
				int count = lv.SelectedItems.Count;
				int pos = 0;
				foreach (ListViewItem lvi in lv.SelectedItems) 
				{
					this.pb.Value = (pos++ * pb.Maximum) / count;
					Application.DoEvents();

					if (lvi.SubItems[1].Text.StartsWith("[skin]"))
					{
						string name = (string)lvi.Tag;
						SimPe.Packages.GeneratableFile skin = SimPe.Packages.GeneratableFile.LoadFromFile(name);

						SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = skin.FindFiles(Data.MetaData.GZPS);
						foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
						{
							SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
							cpf.ProcessData(pfd, skin);

							if (cpf.GetSaveItem("type").StringValue == "skin") 
							{
								age = cpf.GetSaveItem("age").UIntegerValue;
								cat = cpf.GetSaveItem("category").UIntegerValue;

								SetSkinAge(cbbaby, ref age, (uint)Data.Ages.Baby);
								SetSkinAge(cbtoddler, ref age, (uint)Data.Ages.Toddler);
								SetSkinAge(cbchild, ref age, (uint)Data.Ages.Child);
								SetSkinAge(cbteen, ref age, (uint)Data.Ages.Teen);
								SetSkinAge(cbyoung, ref age, (uint)((uint)Data.Ages.YoungAdult));
								if (cbyoung.Checked) AddUniversityFields(cpf);
								SetSkinAge(cbadult, ref age, (uint)Data.Ages.Adult);
								SetSkinAge(cbelder, ref age, (uint)Data.Ages.Elder);

								SetSkinAge(cbact, ref cat, (uint)Data.SkinCategories.Activewear);
								SetSkinAge(cbevery, ref cat, (uint)Data.SkinCategories.Everyday);
								SetSkinAge(cbformal, ref cat, (uint)Data.SkinCategories.Formal);
								SetSkinAge(cbpj, ref cat, (uint)Data.SkinCategories.PJ);
								SetSkinAge(cbpreg, ref cat, (uint)Data.SkinCategories.Pregnant);
								SetSkinAge(cbskin, ref cat, (uint)Data.SkinCategories.Skin);
								SetSkinAge(cbswim, ref cat, (uint)Data.SkinCategories.Swimmwear);
								SetSkinAge(cbundies, ref cat, (uint)Data.SkinCategories.Undies);

								cpf.GetSaveItem("age").UIntegerValue = age;	
								cpf.GetSaveItem("category").UIntegerValue = cat;
					
								cpf.SynchronizeUserData();
							}
						}

						skin.Save();
					}
				
				}
				pb.Value = 0;
			} 
			finally 
			{
				WaitingScreen.Stop();
			}

			if (!hinted) 
			{
				hinted = true;
				MessageBox.Show("If your Game should crash after converting a Skin, pleas scan the Folder again with the 'check Compression' Option checked.\nIf it reports any Errors, please fix them using 'fix Compression'");
			}
			SelectPackage(null, null);
		}
	}
}
