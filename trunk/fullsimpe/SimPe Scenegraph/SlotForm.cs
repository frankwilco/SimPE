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

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für SlotForm.
	/// </summary>
	public class SlotForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel pnslot;
		private System.Windows.Forms.Panel panel4;
		internal System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbf1;
		private System.Windows.Forms.TextBox tbf2;
		private System.Windows.Forms.TextBox tbf3;
		private System.Windows.Forms.TextBox tbi1;
		private System.Windows.Forms.TextBox tbi2;
		private System.Windows.Forms.TextBox tbi3;
		private System.Windows.Forms.TextBox tbi4;
		private System.Windows.Forms.TextBox tbi5;
		private System.Windows.Forms.Label label9;
		internal System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TabPage tabPage7;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox tbf6;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbf5;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbf4;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox tbi6;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox tbs2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox tbs1;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbf7;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox tbf8;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.TextBox tbi7;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox tbi8;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox tbi10;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox tbi9;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label23;
		internal System.Windows.Forms.TextBox tbver;
		private System.Windows.Forms.Label label24;
		internal System.Windows.Forms.TextBox tbname;
		internal System.Windows.Forms.ListView lv;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcommit;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel1;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel2;
		private Skybound.VisualStyles.VisualStyleProvider visualStyleProvider1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SlotForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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
			this.pnslot = new System.Windows.Forms.Panel();
			this.lv = new System.Windows.Forms.ListView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.tbver = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.tbi6 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbf6 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbf5 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tbf4 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.label15 = new System.Windows.Forms.Label();
			this.tbs2 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tbs1 = new System.Windows.Forms.TextBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.label17 = new System.Windows.Forms.Label();
			this.tbf7 = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label19 = new System.Windows.Forms.Label();
			this.tbi7 = new System.Windows.Forms.TextBox();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label20 = new System.Windows.Forms.Label();
			this.tbi8 = new System.Windows.Forms.TextBox();
			this.tabPage6 = new System.Windows.Forms.TabPage();
			this.label18 = new System.Windows.Forms.Label();
			this.tbf8 = new System.Windows.Forms.TextBox();
			this.tabPage7 = new System.Windows.Forms.TabPage();
			this.label21 = new System.Windows.Forms.Label();
			this.tbi10 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tbi9 = new System.Windows.Forms.TextBox();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbi5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbi4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbi3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbi2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbi1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tbf3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbf2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbf1 = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.llcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.visualStyleLinkLabel1 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.visualStyleLinkLabel2 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.visualStyleProvider1 = new Skybound.VisualStyles.VisualStyleProvider();
			this.pnslot.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.tabPage6.SuspendLayout();
			this.tabPage7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnslot
			// 
			this.pnslot.Controls.Add(this.visualStyleLinkLabel2);
			this.pnslot.Controls.Add(this.visualStyleLinkLabel1);
			this.pnslot.Controls.Add(this.lv);
			this.pnslot.Controls.Add(this.groupBox1);
			this.pnslot.Controls.Add(this.tabControl1);
			this.pnslot.Controls.Add(this.cbtype);
			this.pnslot.Controls.Add(this.label9);
			this.pnslot.Controls.Add(this.label8);
			this.pnslot.Controls.Add(this.tbi5);
			this.pnslot.Controls.Add(this.label7);
			this.pnslot.Controls.Add(this.tbi4);
			this.pnslot.Controls.Add(this.label6);
			this.pnslot.Controls.Add(this.tbi3);
			this.pnslot.Controls.Add(this.label5);
			this.pnslot.Controls.Add(this.tbi2);
			this.pnslot.Controls.Add(this.label4);
			this.pnslot.Controls.Add(this.tbi1);
			this.pnslot.Controls.Add(this.label3);
			this.pnslot.Controls.Add(this.tbf3);
			this.pnslot.Controls.Add(this.label2);
			this.pnslot.Controls.Add(this.tbf2);
			this.pnslot.Controls.Add(this.label1);
			this.pnslot.Controls.Add(this.tbf1);
			this.pnslot.Controls.Add(this.panel4);
			this.pnslot.Controls.Add(this.llcommit);
			this.pnslot.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.pnslot.Location = new System.Drawing.Point(14, 29);
			this.pnslot.Name = "pnslot";
			this.pnslot.Size = new System.Drawing.Size(730, 315);
			this.pnslot.TabIndex = 9;
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnslot, true);
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.FullRowSelect = true;
			this.lv.GridLines = true;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(8, 120);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(304, 168);
			this.lv.TabIndex = 24;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.Select);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tbname);
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.label23);
			this.groupBox1.Controls.Add(this.tbver);
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 32);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(304, 80);
			this.groupBox1.TabIndex = 23;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File Settings:";
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox1, true);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(72, 48);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(224, 21);
			this.tbname.TabIndex = 9;
			this.tbname.Text = "";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbname, true);
			this.tbname.TextChanged += new System.EventHandler(this.ChangeWrp);
			// 
			// label24
			// 
			this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(8, 48);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 23);
			this.label24.TabIndex = 8;
			this.label24.Text = "Name:";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label24, true);
			// 
			// label23
			// 
			this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(8, 24);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(56, 23);
			this.label23.TabIndex = 7;
			this.label23.Text = "Version:";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label23, true);
			// 
			// tbver
			// 
			this.tbver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbver.Location = new System.Drawing.Point(72, 24);
			this.tbver.Name = "tbver";
			this.tbver.Size = new System.Drawing.Size(88, 21);
			this.tbver.TabIndex = 6;
			this.tbver.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbver, true);
			this.tbver.TextChanged += new System.EventHandler(this.ChangeWrp);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Controls.Add(this.tabPage6);
			this.tabControl1.Controls.Add(this.tabPage7);
			this.tabControl1.Location = new System.Drawing.Point(320, 144);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(400, 144);
			this.tabControl1.TabIndex = 22;
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabControl1, true);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.tbi6);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.tbf6);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.tbf5);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.tbf4);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(392, 118);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Version 0x05+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage1, true);
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.Location = new System.Drawing.Point(136, 8);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(56, 23);
			this.label14.TabIndex = 17;
			this.label14.Text = "Int 6:";
			this.label14.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label14, true);
			// 
			// tbi6
			// 
			this.tbi6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi6.Location = new System.Drawing.Point(200, 8);
			this.tbi6.Name = "tbi6";
			this.tbi6.Size = new System.Drawing.Size(64, 21);
			this.tbi6.TabIndex = 16;
			this.tbi6.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi6, true);
			this.tbi6.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.Location = new System.Drawing.Point(8, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 23);
			this.label10.TabIndex = 15;
			this.label10.Text = "Float 6:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label10, true);
			// 
			// tbf6
			// 
			this.tbf6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf6.Location = new System.Drawing.Point(72, 56);
			this.tbf6.Name = "tbf6";
			this.tbf6.Size = new System.Drawing.Size(64, 21);
			this.tbf6.TabIndex = 14;
			this.tbf6.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf6, true);
			this.tbf6.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.Location = new System.Drawing.Point(8, 32);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(56, 23);
			this.label11.TabIndex = 13;
			this.label11.Text = "Float 5:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label11, true);
			// 
			// tbf5
			// 
			this.tbf5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf5.Location = new System.Drawing.Point(72, 32);
			this.tbf5.Name = "tbf5";
			this.tbf5.Size = new System.Drawing.Size(64, 21);
			this.tbf5.TabIndex = 12;
			this.tbf5.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf5, true);
			this.tbf5.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.Location = new System.Drawing.Point(8, 8);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 23);
			this.label13.TabIndex = 11;
			this.label13.Text = "Float 4:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label13, true);
			// 
			// tbf4
			// 
			this.tbf4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf4.Location = new System.Drawing.Point(72, 8);
			this.tbf4.Name = "tbf4";
			this.tbf4.Size = new System.Drawing.Size(64, 21);
			this.tbf4.TabIndex = 10;
			this.tbf4.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf4, true);
			this.tbf4.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.tbs2);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.tbs1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(392, 118);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "0x06+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage2, true);
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.Location = new System.Drawing.Point(8, 32);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(56, 23);
			this.label15.TabIndex = 17;
			this.label15.Text = "Short 2:";
			this.label15.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label15, true);
			// 
			// tbs2
			// 
			this.tbs2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbs2.Location = new System.Drawing.Point(72, 32);
			this.tbs2.Name = "tbs2";
			this.tbs2.Size = new System.Drawing.Size(64, 21);
			this.tbs2.TabIndex = 16;
			this.tbs2.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbs2, true);
			this.tbs2.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.Location = new System.Drawing.Point(8, 8);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(56, 23);
			this.label16.TabIndex = 15;
			this.label16.Text = "Short 1:";
			this.label16.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label16, true);
			// 
			// tbs1
			// 
			this.tbs1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbs1.Location = new System.Drawing.Point(72, 8);
			this.tbs1.Name = "tbs1";
			this.tbs1.Size = new System.Drawing.Size(64, 21);
			this.tbs1.TabIndex = 14;
			this.tbs1.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbs1, true);
			this.tbs1.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.label17);
			this.tabPage3.Controls.Add(this.tbf7);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(392, 118);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "0x07+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage3, true);
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.Location = new System.Drawing.Point(8, 8);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(56, 23);
			this.label17.TabIndex = 7;
			this.label17.Text = "Float 7:";
			this.label17.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label17, true);
			// 
			// tbf7
			// 
			this.tbf7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf7.Location = new System.Drawing.Point(72, 8);
			this.tbf7.Name = "tbf7";
			this.tbf7.Size = new System.Drawing.Size(64, 21);
			this.tbf7.TabIndex = 6;
			this.tbf7.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf7, true);
			this.tbf7.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label19);
			this.tabPage4.Controls.Add(this.tbi7);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(392, 118);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "0x08+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage4, true);
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.Location = new System.Drawing.Point(8, 8);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 23);
			this.label19.TabIndex = 13;
			this.label19.Text = "Int 7:";
			this.label19.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label19, true);
			// 
			// tbi7
			// 
			this.tbi7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi7.Location = new System.Drawing.Point(72, 8);
			this.tbi7.Name = "tbi7";
			this.tbi7.Size = new System.Drawing.Size(64, 21);
			this.tbi7.TabIndex = 12;
			this.tbi7.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi7, true);
			this.tbi7.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.label20);
			this.tabPage5.Controls.Add(this.tbi8);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(392, 118);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "0x09+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage5, true);
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.Location = new System.Drawing.Point(8, 8);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(56, 23);
			this.label20.TabIndex = 13;
			this.label20.Text = "Int 8:";
			this.label20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label20, true);
			// 
			// tbi8
			// 
			this.tbi8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi8.Location = new System.Drawing.Point(72, 8);
			this.tbi8.Name = "tbi8";
			this.tbi8.Size = new System.Drawing.Size(64, 21);
			this.tbi8.TabIndex = 12;
			this.tbi8.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi8, true);
			this.tbi8.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage6
			// 
			this.tabPage6.Controls.Add(this.label18);
			this.tabPage6.Controls.Add(this.tbf8);
			this.tabPage6.Location = new System.Drawing.Point(4, 22);
			this.tabPage6.Name = "tabPage6";
			this.tabPage6.Size = new System.Drawing.Size(392, 118);
			this.tabPage6.TabIndex = 5;
			this.tabPage6.Text = "0x10+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage6, true);
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.Location = new System.Drawing.Point(8, 8);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(56, 23);
			this.label18.TabIndex = 7;
			this.label18.Text = "Float 8:";
			this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label18, true);
			// 
			// tbf8
			// 
			this.tbf8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf8.Location = new System.Drawing.Point(72, 8);
			this.tbf8.Name = "tbf8";
			this.tbf8.Size = new System.Drawing.Size(64, 21);
			this.tbf8.TabIndex = 6;
			this.tbf8.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf8, true);
			this.tbf8.TextChanged += new System.EventHandler(this.Changed);
			// 
			// tabPage7
			// 
			this.tabPage7.Controls.Add(this.label21);
			this.tabPage7.Controls.Add(this.tbi10);
			this.tabPage7.Controls.Add(this.label22);
			this.tabPage7.Controls.Add(this.tbi9);
			this.tabPage7.Location = new System.Drawing.Point(4, 22);
			this.tabPage7.Name = "tabPage7";
			this.tabPage7.Size = new System.Drawing.Size(392, 118);
			this.tabPage7.TabIndex = 6;
			this.tabPage7.Text = "0x40+";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage7, true);
			// 
			// label21
			// 
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label21.Location = new System.Drawing.Point(8, 32);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(56, 23);
			this.label21.TabIndex = 23;
			this.label21.Text = "Int 10:";
			this.label21.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label21, true);
			// 
			// tbi10
			// 
			this.tbi10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi10.Location = new System.Drawing.Point(72, 32);
			this.tbi10.Name = "tbi10";
			this.tbi10.Size = new System.Drawing.Size(64, 21);
			this.tbi10.TabIndex = 22;
			this.tbi10.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi10, true);
			this.tbi10.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label22
			// 
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label22.Location = new System.Drawing.Point(8, 8);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(56, 23);
			this.label22.TabIndex = 21;
			this.label22.Text = "Int 9:";
			this.label22.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label22, true);
			// 
			// tbi9
			// 
			this.tbi9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi9.Location = new System.Drawing.Point(72, 8);
			this.tbi9.Name = "tbi9";
			this.tbi9.Size = new System.Drawing.Size(64, 21);
			this.tbi9.TabIndex = 20;
			this.tbi9.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi9, true);
			this.tbi9.TextChanged += new System.EventHandler(this.Changed);
			// 
			// cbtype
			// 
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Location = new System.Drawing.Point(392, 32);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(136, 21);
			this.cbtype.TabIndex = 21;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.Changed);
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.Location = new System.Drawing.Point(328, 32);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(56, 23);
			this.label9.TabIndex = 20;
			this.label9.Text = "Type:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label9, true);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.Location = new System.Drawing.Point(584, 88);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 19;
			this.label8.Text = "Int 5:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label8, true);
			// 
			// tbi5
			// 
			this.tbi5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi5.Location = new System.Drawing.Point(648, 88);
			this.tbi5.Name = "tbi5";
			this.tbi5.Size = new System.Drawing.Size(64, 21);
			this.tbi5.TabIndex = 18;
			this.tbi5.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi5, true);
			this.tbi5.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.Location = new System.Drawing.Point(584, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 23);
			this.label7.TabIndex = 17;
			this.label7.Text = "Int 4:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label7, true);
			// 
			// tbi4
			// 
			this.tbi4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi4.Location = new System.Drawing.Point(648, 64);
			this.tbi4.Name = "tbi4";
			this.tbi4.Size = new System.Drawing.Size(64, 21);
			this.tbi4.TabIndex = 16;
			this.tbi4.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi4, true);
			this.tbi4.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.Location = new System.Drawing.Point(456, 112);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 23);
			this.label6.TabIndex = 15;
			this.label6.Text = "Int 3:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label6, true);
			// 
			// tbi3
			// 
			this.tbi3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi3.Location = new System.Drawing.Point(520, 112);
			this.tbi3.Name = "tbi3";
			this.tbi3.Size = new System.Drawing.Size(64, 21);
			this.tbi3.TabIndex = 14;
			this.tbi3.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi3, true);
			this.tbi3.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.Location = new System.Drawing.Point(456, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 23);
			this.label5.TabIndex = 13;
			this.label5.Text = "Int 2:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label5, true);
			// 
			// tbi2
			// 
			this.tbi2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi2.Location = new System.Drawing.Point(520, 88);
			this.tbi2.Name = "tbi2";
			this.tbi2.Size = new System.Drawing.Size(64, 21);
			this.tbi2.TabIndex = 12;
			this.tbi2.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi2, true);
			this.tbi2.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Location = new System.Drawing.Point(456, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 23);
			this.label4.TabIndex = 11;
			this.label4.Text = "Int 1:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label4, true);
			// 
			// tbi1
			// 
			this.tbi1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbi1.Location = new System.Drawing.Point(520, 64);
			this.tbi1.Name = "tbi1";
			this.tbi1.Size = new System.Drawing.Size(64, 21);
			this.tbi1.TabIndex = 10;
			this.tbi1.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbi1, true);
			this.tbi1.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Location = new System.Drawing.Point(328, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Float 3:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label3, true);
			// 
			// tbf3
			// 
			this.tbf3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf3.Location = new System.Drawing.Point(392, 112);
			this.tbf3.Name = "tbf3";
			this.tbf3.Size = new System.Drawing.Size(64, 21);
			this.tbf3.TabIndex = 8;
			this.tbf3.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf3, true);
			this.tbf3.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Location = new System.Drawing.Point(328, 88);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 7;
			this.label2.Text = "Float 2:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label2, true);
			// 
			// tbf2
			// 
			this.tbf2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf2.Location = new System.Drawing.Point(392, 88);
			this.tbf2.Name = "tbf2";
			this.tbf2.Size = new System.Drawing.Size(64, 21);
			this.tbf2.TabIndex = 6;
			this.tbf2.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf2, true);
			this.tbf2.TextChanged += new System.EventHandler(this.Changed);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Location = new System.Drawing.Point(328, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Float 1:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label1, true);
			// 
			// tbf1
			// 
			this.tbf1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbf1.Location = new System.Drawing.Point(392, 64);
			this.tbf1.Name = "tbf1";
			this.tbf1.Size = new System.Drawing.Size(64, 21);
			this.tbf1.TabIndex = 4;
			this.tbf1.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbf1, true);
			this.tbf1.TextChanged += new System.EventHandler(this.Changed);
			// 
			// panel4
			// 
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel4.Controls.Add(this.label12);
			this.panel4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.Location = new System.Drawing.Point(0, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(730, 24);
			this.panel4.TabIndex = 0;
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel4, true);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label12.Location = new System.Drawing.Point(0, 4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(84, 19);
			this.label12.TabIndex = 0;
			this.label12.Text = "Slot Editor";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label12, true);
			// 
			// llcommit
			// 
			this.llcommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.llcommit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llcommit.Location = new System.Drawing.Point(620, 288);
			this.llcommit.Name = "llcommit";
			this.llcommit.TabIndex = 25;
			this.llcommit.TabStop = true;
			this.llcommit.Text = "Commit";
			this.llcommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.llcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llcommit_LinkClicked);
			// 
			// visualStyleLinkLabel1
			// 
			this.visualStyleLinkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.visualStyleLinkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.visualStyleLinkLabel1.Location = new System.Drawing.Point(280, 288);
			this.visualStyleLinkLabel1.Name = "visualStyleLinkLabel1";
			this.visualStyleLinkLabel1.Size = new System.Drawing.Size(32, 23);
			this.visualStyleLinkLabel1.TabIndex = 26;
			this.visualStyleLinkLabel1.TabStop = true;
			this.visualStyleLinkLabel1.Text = "Add";
			this.visualStyleLinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.visualStyleLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Add);
			// 
			// visualStyleLinkLabel2
			// 
			this.visualStyleLinkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.visualStyleLinkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.visualStyleLinkLabel2.Location = new System.Drawing.Point(208, 288);
			this.visualStyleLinkLabel2.Name = "visualStyleLinkLabel2";
			this.visualStyleLinkLabel2.Size = new System.Drawing.Size(64, 23);
			this.visualStyleLinkLabel2.TabIndex = 27;
			this.visualStyleLinkLabel2.TabStop = true;
			this.visualStyleLinkLabel2.Text = "Delete";
			this.visualStyleLinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.visualStyleLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Delete);
			// 
			// SlotForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(920, 406);
			this.Controls.Add(this.pnslot);
			this.Name = "SlotForm";
			this.Text = "SlotForm";
			this.pnslot.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage6.ResumeLayout(false);
			this.tabPage7.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Slot wrapper;

		internal void ShowItem(SlotItem si) 
		{
			ListViewItem lvi = new ListViewItem();
			ShowItem(si, lvi);
			lv.Items.Add(lvi);
		}

		void ShowItem(SlotItem si, ListViewItem lvi) 
		{			
			lvi.Tag = si;
			lvi.SubItems.Clear();

			lvi.Text = si.Type.ToString();
			
			lvi.SubItems.Add(si.UnknownFloat1.ToString());
			lvi.SubItems.Add(si.UnknownFloat2.ToString());
			lvi.SubItems.Add(si.UnknownFloat3.ToString());

			lvi.SubItems.Add(si.UnknownInt1.ToString());
			lvi.SubItems.Add(si.UnknownInt2.ToString());
			lvi.SubItems.Add(si.UnknownInt3.ToString());
			lvi.SubItems.Add(si.UnknownInt4.ToString());
			lvi.SubItems.Add(si.UnknownInt5.ToString());

			if (wrapper.Version>=5) 
			{
				lvi.SubItems.Add(si.UnknownFloat4.ToString());
				lvi.SubItems.Add(si.UnknownFloat5.ToString());
				lvi.SubItems.Add(si.UnknownFloat6.ToString());

				lvi.SubItems.Add(si.UnknownInt6.ToString());
			}

			if (wrapper.Version>=6) 
			{
				lvi.SubItems.Add(si.UnknownShort1.ToString());
				lvi.SubItems.Add(si.UnknownShort2.ToString());
			}

			if (wrapper.Version>=7) lvi.SubItems.Add(si.UnknownFloat7.ToString());
			if (wrapper.Version>=8) lvi.SubItems.Add(si.UnknownInt7.ToString());
			if (wrapper.Version>=9) lvi.SubItems.Add(si.UnknownInt8.ToString());
			if (wrapper.Version>=0x10) lvi.SubItems.Add(si.UnknownFloat8.ToString());

			if (wrapper.Version>=0x40) 
			{
				lvi.SubItems.Add(si.UnknownInt9.ToString());
				lvi.SubItems.Add(si.UnknownInt10.ToString());;
			}			
		}
		
		private void Select(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;
			this.Tag = true;
			try 
			{
				SimPe.PackedFiles.Wrapper.SlotItem si = (SimPe.PackedFiles.Wrapper.SlotItem)lv.SelectedItems[0].Tag;

				int ct = 0;
				foreach (SimPe.PackedFiles.Wrapper.SlotItemType sti in cbtype.Items) 
				{
					if (sti==si.Type) cbtype.SelectedIndex = ct;
					ct++;
				}

				tbf1.Text = si.UnknownFloat1.ToString();
				tbf2.Text = si.UnknownFloat2.ToString();
				tbf3.Text = si.UnknownFloat3.ToString();
				tbf4.Text = si.UnknownFloat4.ToString();
				tbf5.Text = si.UnknownFloat5.ToString();
				tbf6.Text = si.UnknownFloat6.ToString();
				tbf7.Text = si.UnknownFloat7.ToString();
				tbf8.Text = si.UnknownFloat8.ToString();


				tbi1.Text = si.UnknownInt1.ToString();
				tbi2.Text = si.UnknownInt2.ToString();
				tbi3.Text = si.UnknownInt3.ToString();
				tbi4.Text = si.UnknownInt4.ToString();
				tbi5.Text = si.UnknownInt5.ToString();
				tbi6.Text = si.UnknownInt6.ToString();
				tbi7.Text = si.UnknownInt7.ToString();
				tbi8.Text = si.UnknownInt8.ToString();
				tbi9.Text = si.UnknownInt9.ToString();
				tbi10.Text = si.UnknownInt10.ToString();

				tbs1.Text = si.UnknownShort1.ToString();
				tbs2.Text = si.UnknownShort2.ToString();
			}
			finally 
			{
				this.Tag = null;
			}
		}

		private void Changed(object sender, System.EventArgs e)
		{
			if (Tag!=null) return;
			if (lv.SelectedItems.Count==0) return;
			try 
			{
				SimPe.PackedFiles.Wrapper.SlotItem si = (SimPe.PackedFiles.Wrapper.SlotItem)lv.SelectedItems[0].Tag;

				if (cbtype.SelectedIndex>=0) si.Type = (SlotItemType)cbtype.Items[cbtype.SelectedIndex];

				si.UnknownFloat1 = Convert.ToSingle(tbf1.Text);
				si.UnknownFloat2 = Convert.ToSingle(tbf2.Text);
				si.UnknownFloat3 = Convert.ToSingle(tbf3.Text);
				si.UnknownFloat4 = Convert.ToSingle(tbf4.Text);
				si.UnknownFloat5 = Convert.ToSingle(tbf5.Text);
				si.UnknownFloat6 = Convert.ToSingle(tbf6.Text);
				si.UnknownFloat7 = Convert.ToSingle(tbf7.Text);
				si.UnknownFloat8 = Convert.ToSingle(tbf8.Text);

				si.UnknownInt1 = Convert.ToInt32(tbi1.Text);
				si.UnknownInt2 = Convert.ToInt32(tbi2.Text);
				si.UnknownInt3 = Convert.ToInt32(tbi3.Text);
				si.UnknownInt4 = Convert.ToInt32(tbi4.Text);
				si.UnknownInt5 = Convert.ToInt32(tbi5.Text);
				si.UnknownInt6 = Convert.ToInt32(tbi6.Text);
				si.UnknownInt7 = Convert.ToInt32(tbi7.Text);
				si.UnknownInt8 = Convert.ToInt32(tbi8.Text);
				si.UnknownInt9 = Convert.ToInt32(tbi9.Text);
				si.UnknownInt10 = Convert.ToInt32(tbi10.Text);

				si.UnknownShort1 = Convert.ToInt16(tbs1.Text);
				si.UnknownShort2 = Convert.ToInt16(tbs2.Text);

				wrapper.Changed = true;

				ShowItem(si, lv.SelectedItems[0]);
			} 
			catch {}
		}

		private void ChangeWrp(object sender, System.EventArgs e)
		{
			if (Tag!=null) return;
			wrapper.FileName = tbname.Text;
			wrapper.Changed = true;
		}

		private void llcommit_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			wrapper.SynchronizeUserData();
		}

		private void Add(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			SlotItem si = new SlotItem(wrapper);
			wrapper.Items.Add(si);
			ShowItem(si);			
			wrapper.Changed = true;
		}

		private void Delete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;
			try 
			{
				SimPe.PackedFiles.Wrapper.SlotItem si = (SimPe.PackedFiles.Wrapper.SlotItem)lv.SelectedItems[0].Tag;
				
				wrapper.Items.Remove(si);
				lv.Items.Remove(lv.SelectedItems[0]);
				wrapper.Changed = true;
			} 
			catch {}
		}
	}
}
