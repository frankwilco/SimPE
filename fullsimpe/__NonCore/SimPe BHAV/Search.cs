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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für Search.
	/// </summary>
	public class Search : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.ListBox lblist;
		private System.Windows.Forms.Button btopen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbOpcode;
		private System.Windows.Forms.LinkLabel llsearch;
		private System.Windows.Forms.ProgressBar pb;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.TextBox tbflname;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbsimname;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.TextBox tbpropname;
		private System.Windows.Forms.TextBox tbbhavgroup;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RadioButton rbfull;
		private System.Windows.Forms.RadioButton rbstart;
		private System.Windows.Forms.RadioButton rbend;
		private System.Windows.Forms.RadioButton rbcont;
		private System.Windows.Forms.CheckBox cbusefileindex;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.TextBox tbguid;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbpropval;
		private System.Windows.Forms.Label label7;
		private System.ComponentModel.IContainer components;

		public Search()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			prov = null;
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tbbhavgroup = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.llsearch = new System.Windows.Forms.LinkLabel();
			this.tbOpcode = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.cbusefileindex = new System.Windows.Forms.CheckBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.tbsimname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tbpropval = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.rbcont = new System.Windows.Forms.RadioButton();
			this.rbend = new System.Windows.Forms.RadioButton();
			this.rbstart = new System.Windows.Forms.RadioButton();
			this.rbfull = new System.Windows.Forms.RadioButton();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tbpropname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.tbguid = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lblist = new System.Windows.Forms.ListBox();
			this.btopen = new System.Windows.Forms.Button();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(560, 88);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tbbhavgroup);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.llsearch);
			this.tabPage1.Controls.Add(this.tbOpcode);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(552, 62);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "BHAV";
			// 
			// tbbhavgroup
			// 
			this.tbbhavgroup.Location = new System.Drawing.Point(136, 32);
			this.tbbhavgroup.Name = "tbbhavgroup";
			this.tbbhavgroup.TabIndex = 4;
			this.tbbhavgroup.Text = "";
			this.toolTip1.SetToolTip(this.tbbhavgroup, "leave empty to search in all Groups");
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(84, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 17);
			this.label5.TabIndex = 3;
			this.label5.Text = "Group:";
			// 
			// llsearch
			// 
			this.llsearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.llsearch.AutoSize = true;
			this.llsearch.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.llsearch.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llsearch.Location = new System.Drawing.Point(496, 40);
			this.llsearch.Name = "llsearch";
			this.llsearch.Size = new System.Drawing.Size(46, 17);
			this.llsearch.TabIndex = 2;
			this.llsearch.TabStop = true;
			this.llsearch.Text = "search";
			this.llsearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BhavSearch);
			// 
			// tbOpcode
			// 
			this.tbOpcode.Location = new System.Drawing.Point(136, 8);
			this.tbOpcode.Name = "tbOpcode";
			this.tbOpcode.TabIndex = 1;
			this.tbOpcode.Text = "0x0000";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Contains Opcode:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.cbusefileindex);
			this.tabPage2.Controls.Add(this.linkLabel1);
			this.tabPage2.Controls.Add(this.tbflname);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(552, 62);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "RCOL";
			// 
			// cbusefileindex
			// 
			this.cbusefileindex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbusefileindex.Location = new System.Drawing.Point(80, 32);
			this.cbusefileindex.Name = "cbusefileindex";
			this.cbusefileindex.Size = new System.Drawing.Size(120, 24);
			this.cbusefileindex.TabIndex = 6;
			this.cbusefileindex.Text = "scan in all Files";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(496, 40);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(46, 17);
			this.linkLabel1.TabIndex = 5;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "search";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RcolSearch);
			// 
			// tbflname
			// 
			this.tbflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbflname.Location = new System.Drawing.Point(80, 8);
			this.tbflname.Name = "tbflname";
			this.tbflname.Size = new System.Drawing.Size(408, 21);
			this.tbflname.TabIndex = 4;
			this.tbflname.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Filename:";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.linkLabel2);
			this.tabPage3.Controls.Add(this.tbsimname);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(552, 62);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Sims";
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.linkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(496, 40);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(46, 17);
			this.linkLabel2.TabIndex = 8;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "search";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FindSim);
			// 
			// tbsimname
			// 
			this.tbsimname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbsimname.Location = new System.Drawing.Point(88, 8);
			this.tbsimname.Name = "tbsimname";
			this.tbsimname.Size = new System.Drawing.Size(400, 21);
			this.tbsimname.TabIndex = 8;
			this.tbsimname.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sim Name:";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.tbpropval);
			this.tabPage4.Controls.Add(this.label7);
			this.tabPage4.Controls.Add(this.rbcont);
			this.tabPage4.Controls.Add(this.rbend);
			this.tabPage4.Controls.Add(this.rbstart);
			this.tabPage4.Controls.Add(this.rbfull);
			this.tabPage4.Controls.Add(this.linkLabel3);
			this.tabPage4.Controls.Add(this.tbpropname);
			this.tabPage4.Controls.Add(this.label4);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(552, 62);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Property Set";
			// 
			// tbpropval
			// 
			this.tbpropval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbpropval.Location = new System.Drawing.Point(288, 8);
			this.tbpropval.Name = "tbpropval";
			this.tbpropval.Size = new System.Drawing.Size(256, 21);
			this.tbpropval.TabIndex = 16;
			this.tbpropval.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(240, 16);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "Value:";
			// 
			// rbcont
			// 
			this.rbcont.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbcont.Location = new System.Drawing.Point(296, 32);
			this.rbcont.Name = "rbcont";
			this.rbcont.Size = new System.Drawing.Size(72, 24);
			this.rbcont.TabIndex = 14;
			this.rbcont.Text = "contains";
			// 
			// rbend
			// 
			this.rbend.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbend.Location = new System.Drawing.Point(232, 32);
			this.rbend.Name = "rbend";
			this.rbend.Size = new System.Drawing.Size(48, 24);
			this.rbend.TabIndex = 13;
			this.rbend.Text = "end";
			// 
			// rbstart
			// 
			this.rbstart.Checked = true;
			this.rbstart.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbstart.Location = new System.Drawing.Point(160, 32);
			this.rbstart.Name = "rbstart";
			this.rbstart.Size = new System.Drawing.Size(56, 24);
			this.rbstart.TabIndex = 12;
			this.rbstart.TabStop = true;
			this.rbstart.Text = "start";
			// 
			// rbfull
			// 
			this.rbfull.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rbfull.Location = new System.Drawing.Point(88, 32);
			this.rbfull.Name = "rbfull";
			this.rbfull.Size = new System.Drawing.Size(56, 24);
			this.rbfull.TabIndex = 11;
			this.rbfull.Text = "match";
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.linkLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel3.Location = new System.Drawing.Point(496, 40);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(46, 17);
			this.linkLabel3.TabIndex = 10;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "search";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GzpsSearch);
			// 
			// tbpropname
			// 
			this.tbpropname.Location = new System.Drawing.Point(88, 8);
			this.tbpropname.Name = "tbpropname";
			this.tbpropname.Size = new System.Drawing.Size(128, 21);
			this.tbpropname.TabIndex = 9;
			this.tbpropname.Text = "name";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(41, 12);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Name:";
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.linkLabel4);
			this.tabPage5.Controls.Add(this.tbguid);
			this.tabPage5.Controls.Add(this.label6);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(552, 62);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "GUID";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.linkLabel4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel4.Location = new System.Drawing.Point(495, 39);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(46, 17);
			this.linkLabel4.TabIndex = 11;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "search";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GuidSearch);
			// 
			// tbguid
			// 
			this.tbguid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbguid.Location = new System.Drawing.Point(87, 7);
			this.tbguid.Name = "tbguid";
			this.tbguid.Size = new System.Drawing.Size(97, 21);
			this.tbguid.TabIndex = 10;
			this.tbguid.Text = "0x00000000";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(40, 11);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(43, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "GUID:";
			// 
			// lblist
			// 
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblist.HorizontalScrollbar = true;
			this.lblist.IntegralHeight = false;
			this.lblist.Location = new System.Drawing.Point(8, 104);
			this.lblist.Name = "lblist";
			this.lblist.Size = new System.Drawing.Size(560, 192);
			this.lblist.TabIndex = 1;
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.SelectFile);
			// 
			// btopen
			// 
			this.btopen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btopen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btopen.Location = new System.Drawing.Point(493, 304);
			this.btopen.Name = "btopen";
			this.btopen.TabIndex = 2;
			this.btopen.Text = "Open";
			this.btopen.Click += new System.EventHandler(this.Open);
			// 
			// pb
			// 
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pb.Location = new System.Drawing.Point(8, 304);
			this.pb.Maximum = 1000;
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(480, 16);
			this.pb.TabIndex = 3;
			// 
			// Search
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(576, 334);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.btopen);
			this.Controls.Add(this.lblist);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "Search";
			this.ShowInTaskbar = false;
			this.Text = "Search";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Seeker Infrastructure
		/// <summary>
		/// Delegate for Search Functions
		/// </summary>
		public delegate SearchItem SeekerFunction(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov);

		protected void StartSearch(SeekerFunction fkt, Interfaces.Files.IPackedFileDescriptor[] pfds)
		{
			try 
			{
				pb.Value = 0;
				btopen.Tag = null;
				lblist.Items.Clear();
				//lblist.BeginUpdate();
				this.btopen.Enabled = false;
				Cursor = Cursors.WaitCursor;

				int count = 0;
				foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
				{
					pb.Value = (count++ * pb.Maximum) / pfds.Length;
					SearchItem si = fkt(pfd, package, prov);
					if (si!=null) lblist.Items.Add(si);
				}

				lblist.Sorted = true;
				if (lblist.Items.Count==0) MessageBox.Show("No Files were found");
				else lblist.SelectedIndex = 0;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				Cursor = Cursors.Default;
				pb.Value = 0;
				//lblist.EndUpdate();
			}
		}
		#endregion
		
		#region Seekers
		/// <summary>
		/// Searches BHAV Files
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		/// <param name="prov"></param>
		/// <returns>Null if no match or a valid SearchItem Object</returns>
		public SearchItem BhavSearch(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{ 
			ushort opcode = Convert.ToUInt16(this.tbOpcode.Text, 16);
			
			//group Filter
			if (tbbhavgroup.Text.Trim()!="") 
			{
				uint group = Convert.ToUInt32(this.tbbhavgroup.Text, 16);
				if (pfd.Group!=group) return null;
			}

			Bhav bhav = new Bhav(prov.OpcodeProvider);
			bhav.ProcessData(pfd, package);

			foreach (Instruction i in bhav)
			{
				if (i.OpCode == opcode) 
				{
					return new SearchItem(bhav.FileName, pfd);
				}
			}

			return null;
		}

		/// <summary>
		/// Searches RCOL Files
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		/// <param name="prov"></param>
		/// <returns>Null if no match or a valid SearchItem Object</returns>
		public SearchItem RcolSearch(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{ 
			string flname = Hashes.StripHashFromName(tbflname.Text);
			uint inst = Hashes.InstanceHash(flname);
			uint st = Hashes.SubTypeHash(flname);

			if ( (pfd.Instance == inst) && ((pfd.SubType == st) || pfd.SubType==0))
			{
				SimPe.Plugin.Rcol rcol = new GenericRcol(prov, false);
				rcol.ProcessData(pfd, package);
				return new SearchItem(rcol.FileName, pfd);
			}
			

			return null;
		}		

		/// <summary>
		/// Searches Sims
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		/// <param name="prov"></param>
		/// <returns>Null if no match or a valid SearchItem Object</returns>
		public SearchItem SdscSearch(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{ 
			string name = tbsimname.Text.Trim().ToLower();
			
			SimPe.PackedFiles.Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(prov.SimNameProvider, prov.SimFamilynameProvider, prov.SimDescriptionProvider);
			sdesc.ProcessData(pfd, package);

			string ext = "";
			if (sdesc.Unlinked!=0x00) ext += "unlinked";
			if (!sdesc.AvailableCharacterData) 
			{
				if (ext.Trim()!="") ext += ", no Character Data"; 
			}

			if (ext.Trim()!="") ext = " ("+ext+")";

			string simname = sdesc.SimName + " " + sdesc.SimFamilyName;
			simname = simname.Trim().ToLower();
			if (simname==name) return new SearchItem(simname+ext, pfd);

			simname = sdesc.SimName + " " + sdesc.HouseholdName;
			simname = simname.Trim().ToLower();
			if (simname==name) return new SearchItem(simname+ext, pfd);
			

			return null;
		}

		/// <summary>
		/// Searches BHAV Files
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		/// <param name="prov"></param>
		/// <returns>Null if no match or a valid SearchItem Object</returns>
		public SearchItem GzpsSearch(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{ 
			ushort opcode = Convert.ToUInt16(this.tbOpcode.Text, 16);
			SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
			cpf.ProcessData(pfd, package);


			//foreach (SimPe.PackedFiles.Wrapper.CpfItem i in cpf.Items)
			{
				bool check = false;
				string s1 = cpf.GetSaveItem(tbpropname.Text).StringValue.Trim().ToLower();//i.StringValue.Trim().ToLower();
				string s2 = tbpropval.Text.Trim().ToLower();
				if (rbfull.Checked) check = (s1==s2);
				if (rbstart.Checked) check = (s1.StartsWith(s2));
				if (rbend.Checked) check = (s1.EndsWith(s2));
				if (rbcont.Checked) check = (s1.IndexOf(s2)!=-1);
				if (check) 
				{
					return new SearchItem(cpf.FileDescriptor.ToString(), pfd);
				}
			}

			return null;
		}

		/// <summary>
		/// Searches Sims
		/// </summary>
		/// <param name="pfd"></param>
		/// <param name="package"></param>
		/// <param name="prov"></param>
		/// <returns>Null if no match or a valid SearchItem Object</returns>
		public SearchItem GuidSearch(Interfaces.Files.IPackedFileDescriptor pfd, Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{ 
			uint guid = Convert.ToUInt32(tbguid.Text, 16);
			
			SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd();
			objd.ProcessData(pfd, package);

			if (objd.Guid == guid) return new SearchItem(objd.FileName, pfd);
			return null;
		}
		#endregion

		private void FindSim(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.StartSearch(new SeekerFunction(this.SdscSearch), package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE));
			
		}

		Interfaces.Files.IPackageFile package;
		Interfaces.Files.IPackedFileDescriptor pfd;
		internal Interfaces.IProviderRegistry prov;

		internal Interfaces.Files.IPackedFileDescriptor Execute(Interfaces.Files.IPackageFile package) 
		{
			this.package = package;
			this.pfd = null;
			RemoteControl.ShowSubForm(this);

			return pfd;
		}

		internal void Reset()
		{
			lblist.Items.Clear();
			this.btopen.Enabled = false;
		}

		private void BhavSearch(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.StartSearch(new SeekerFunction(this.BhavSearch), package.FindFiles(Data.MetaData.BHAV_FILE));
		}

		private void Open(object sender, System.EventArgs e)
		{
			if (lblist.SelectedIndex<0) return;
			try 
			{
				SearchItem si = (SearchItem)lblist.Items[lblist.SelectedIndex];
				pfd = si.Descriptor;
				Close();
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void SelectFile(object sender, System.EventArgs e)
		{
			this.btopen.Enabled = false;
			if (lblist.SelectedIndex<0) return;
			this.btopen.Enabled = (btopen.Tag==null);
		}

		private void GzpsSearch(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = (Interfaces.Files.IPackedFileDescriptor[])Helper.Merge(package.FindFiles(0xEBCF3E27), package.FindFiles(0x4C697E5A), typeof(Interfaces.Files.IPackedFileDescriptor)); 
			this.StartSearch(new SeekerFunction(this.GzpsSearch), pfds);
		}

		private void GuidSearch(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.OBJD_FILE);
			this.StartSearch(new SeekerFunction(this.GuidSearch), pfds);
		}

		private void RcolSearch(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (cbusefileindex.Checked) 
			{
				WaitingScreen.Wait();
                try { SimPe.FileTable.FileIndex.Load(); }
                finally { WaitingScreen.Stop(this); }

				lblist.Items.Clear();
				SimPe.Packages.PackedFileDescriptor pfd = new SimPe.Packages.PackedFileDescriptor();
				pfd.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(tbflname.Text));
				pfd.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(tbflname.Text));

				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFileByInstance(pfd.LongInstance);

				//short Index
				if (items.Length==0) 
				{
					pfd.SubType = 0;
					items = FileTable.FileIndex.FindFileByInstance(pfd.LongInstance);
				}

				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
				{
					lblist.Items.Add(item.Package.FileName);
				}

				btopen.Tag = true;
			} 
			else 
			{
				
				this.StartSearch(new SeekerFunction(this.RcolSearch), package.FindFile(Hashes.StripHashFromName(tbflname.Text)));
			}
		}
	}
}
