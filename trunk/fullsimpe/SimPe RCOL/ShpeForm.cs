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
	/// Zusammenfassung für ShpeForm.
	/// </summary>
	public class ShpeForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox tbunk;
		internal System.Windows.Forms.ListBox lbunk;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TextBox tbitemunk4;
		private System.Windows.Forms.TextBox tbitemunk3;
		private System.Windows.Forms.TextBox tbitemunk2;
		private System.Windows.Forms.TextBox tbitemunk1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbitemflname;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.ListBox lbitem;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.ListBox lbpart;
		private System.Windows.Forms.TextBox tbparttype;
		private System.Windows.Forms.TextBox tbpartdsc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbpartdata;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TabPage tabPage4;
		internal System.Windows.Forms.TextBox tbnodeflname;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.ListBox lbnode;
		private System.Windows.Forms.TextBox tbnode1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbnode2;
		private System.Windows.Forms.TextBox tbnode3;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel8;
		private System.Windows.Forms.LinkLabel linkLabel9;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label11;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShpeForm()
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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tbunk = new System.Windows.Forms.TextBox();
			this.lbunk = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.tbitemunk4 = new System.Windows.Forms.TextBox();
			this.tbitemunk3 = new System.Windows.Forms.TextBox();
			this.tbitemunk2 = new System.Windows.Forms.TextBox();
			this.tbitemunk1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbitemflname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lbitem = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.tbpartdata = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbpartdsc = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbparttype = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbpart = new System.Windows.Forms.ListBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.linkLabel9 = new System.Windows.Forms.LinkLabel();
			this.linkLabel10 = new System.Windows.Forms.LinkLabel();
			this.tbnode3 = new System.Windows.Forms.TextBox();
			this.tbnode2 = new System.Windows.Forms.TextBox();
			this.tbnode1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lbnode = new System.Windows.Forms.ListBox();
			this.tbnodeflname = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(544, 280);
			this.tabControl1.TabIndex = 12;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.linkLabel4);
			this.tabPage1.Controls.Add(this.linkLabel3);
			this.tabPage1.Controls.Add(this.tbunk);
			this.tabPage1.Controls.Add(this.lbunk);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(536, 254);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Level of Detail Listing";
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel4.Location = new System.Drawing.Point(188, 56);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(44, 17);
			this.linkLabel4.TabIndex = 7;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "delete";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel3.Location = new System.Drawing.Point(160, 56);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(28, 17);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "add";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// tbunk
			// 
			this.tbunk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbunk.Location = new System.Drawing.Point(144, 32);
			this.tbunk.Name = "tbunk";
			this.tbunk.Size = new System.Drawing.Size(88, 21);
			this.tbunk.TabIndex = 4;
			this.tbunk.Text = "0x00000000";
			this.tbunk.TextChanged += new System.EventHandler(this.ChangeUnknown);
			// 
			// lbunk
			// 
			this.lbunk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbunk.IntegralHeight = false;
			this.lbunk.Location = new System.Drawing.Point(8, 8);
			this.lbunk.Name = "lbunk";
			this.lbunk.Size = new System.Drawing.Size(120, 104);
			this.lbunk.TabIndex = 3;
			this.lbunk.SelectedIndexChanged += new System.EventHandler(this.SelectUnknown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Value:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.linkLabel5);
			this.tabPage2.Controls.Add(this.linkLabel6);
			this.tabPage2.Controls.Add(this.tbitemunk4);
			this.tabPage2.Controls.Add(this.tbitemunk3);
			this.tabPage2.Controls.Add(this.tbitemunk2);
			this.tabPage2.Controls.Add(this.tbitemunk1);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Controls.Add(this.tbitemflname);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Controls.Add(this.lbitem);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(536, 254);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Items";
			// 
			// linkLabel5
			// 
			this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel5.Location = new System.Drawing.Point(484, 120);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(44, 17);
			this.linkLabel5.TabIndex = 19;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "delete";
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			// 
			// linkLabel6
			// 
			this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel6.AutoSize = true;
			this.linkLabel6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel6.Location = new System.Drawing.Point(456, 120);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(28, 17);
			this.linkLabel6.TabIndex = 18;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "add";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel6_LinkClicked);
			// 
			// tbitemunk4
			// 
			this.tbitemunk4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbitemunk4.Location = new System.Drawing.Point(264, 192);
			this.tbitemunk4.Name = "tbitemunk4";
			this.tbitemunk4.Size = new System.Drawing.Size(48, 21);
			this.tbitemunk4.TabIndex = 17;
			this.tbitemunk4.Text = "0x00";
			this.tbitemunk4.TextChanged += new System.EventHandler(this.ChangeItemUnknown);
			// 
			// tbitemunk3
			// 
			this.tbitemunk3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbitemunk3.Location = new System.Drawing.Point(168, 192);
			this.tbitemunk3.Name = "tbitemunk3";
			this.tbitemunk3.Size = new System.Drawing.Size(88, 21);
			this.tbitemunk3.TabIndex = 16;
			this.tbitemunk3.Text = "0x00000000";
			this.tbitemunk3.TextChanged += new System.EventHandler(this.ChangeItemUnknown);
			// 
			// tbitemunk2
			// 
			this.tbitemunk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbitemunk2.Location = new System.Drawing.Point(112, 192);
			this.tbitemunk2.Name = "tbitemunk2";
			this.tbitemunk2.Size = new System.Drawing.Size(48, 21);
			this.tbitemunk2.TabIndex = 15;
			this.tbitemunk2.Text = "0x00";
			this.tbitemunk2.TextChanged += new System.EventHandler(this.ChangeItemUnknown);
			// 
			// tbitemunk1
			// 
			this.tbitemunk1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbitemunk1.Location = new System.Drawing.Point(16, 192);
			this.tbitemunk1.Name = "tbitemunk1";
			this.tbitemunk1.Size = new System.Drawing.Size(88, 21);
			this.tbitemunk1.TabIndex = 14;
			this.tbitemunk1.Text = "0x00000000";
			this.tbitemunk1.TextChanged += new System.EventHandler(this.ChangeItemUnknown);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 13;
			this.label4.Text = "Unknown:";
			// 
			// tbitemflname
			// 
			this.tbitemflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbitemflname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbitemflname.Location = new System.Drawing.Point(16, 144);
			this.tbitemflname.Name = "tbitemflname";
			this.tbitemflname.Size = new System.Drawing.Size(512, 21);
			this.tbitemflname.TabIndex = 11;
			this.tbitemflname.Text = "";
			this.tbitemflname.TextChanged += new System.EventHandler(this.ChangedItemFilename);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Filename:";
			// 
			// lbitem
			// 
			this.lbitem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbitem.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbitem.HorizontalScrollbar = true;
			this.lbitem.IntegralHeight = false;
			this.lbitem.Location = new System.Drawing.Point(8, 8);
			this.lbitem.Name = "lbitem";
			this.lbitem.Size = new System.Drawing.Size(520, 112);
			this.lbitem.TabIndex = 10;
			this.lbitem.SelectedIndexChanged += new System.EventHandler(this.SelectItems);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.linkLabel7);
			this.tabPage3.Controls.Add(this.linkLabel8);
			this.tabPage3.Controls.Add(this.tbpartdata);
			this.tabPage3.Controls.Add(this.label7);
			this.tabPage3.Controls.Add(this.tbpartdsc);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.tbparttype);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.lbpart);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(536, 254);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Parts";
			// 
			// linkLabel7
			// 
			this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel7.AutoSize = true;
			this.linkLabel7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel7.Location = new System.Drawing.Point(484, 120);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(44, 17);
			this.linkLabel7.TabIndex = 21;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "delete";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
			// 
			// linkLabel8
			// 
			this.linkLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel8.AutoSize = true;
			this.linkLabel8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel8.Location = new System.Drawing.Point(456, 120);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(28, 17);
			this.linkLabel8.TabIndex = 20;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "add";
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
			// 
			// tbpartdata
			// 
			this.tbpartdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbpartdata.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbpartdata.Location = new System.Drawing.Point(16, 224);
			this.tbpartdata.Name = "tbpartdata";
			this.tbpartdata.Size = new System.Drawing.Size(512, 21);
			this.tbpartdata.TabIndex = 18;
			this.tbpartdata.Text = "";
			this.tbpartdata.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Data:";
			// 
			// tbpartdsc
			// 
			this.tbpartdsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbpartdsc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbpartdsc.Location = new System.Drawing.Point(16, 184);
			this.tbpartdsc.Name = "tbpartdsc";
			this.tbpartdsc.Size = new System.Drawing.Size(512, 21);
			this.tbpartdsc.TabIndex = 16;
			this.tbpartdsc.Text = "";
			this.tbpartdsc.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Material Definition File:";
			// 
			// tbparttype
			// 
			this.tbparttype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbparttype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbparttype.Location = new System.Drawing.Point(16, 144);
			this.tbparttype.Name = "tbparttype";
			this.tbparttype.Size = new System.Drawing.Size(512, 21);
			this.tbparttype.TabIndex = 14;
			this.tbparttype.Text = "";
			this.tbparttype.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Subset Name:";
			// 
			// lbpart
			// 
			this.lbpart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbpart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbpart.HorizontalScrollbar = true;
			this.lbpart.IntegralHeight = false;
			this.lbpart.Location = new System.Drawing.Point(8, 8);
			this.lbpart.Name = "lbpart";
			this.lbpart.Size = new System.Drawing.Size(520, 112);
			this.lbpart.TabIndex = 13;
			this.lbpart.SelectedIndexChanged += new System.EventHandler(this.SelectPart);
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.label11);
			this.tabPage4.Controls.Add(this.label20);
			this.tabPage4.Controls.Add(this.linkLabel9);
			this.tabPage4.Controls.Add(this.linkLabel10);
			this.tabPage4.Controls.Add(this.tbnode3);
			this.tabPage4.Controls.Add(this.tbnode2);
			this.tabPage4.Controls.Add(this.tbnode1);
			this.tabPage4.Controls.Add(this.label9);
			this.tabPage4.Controls.Add(this.lbnode);
			this.tabPage4.Controls.Add(this.tbnodeflname);
			this.tabPage4.Controls.Add(this.label8);
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(536, 254);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Graph Node";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(48, 232);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 17);
			this.label11.TabIndex = 23;
			this.label11.Text = "Index:";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(16, 208);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(78, 17);
			this.label20.TabIndex = 22;
			this.label20.Text = "Dependant:";
			// 
			// linkLabel9
			// 
			this.linkLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel9.AutoSize = true;
			this.linkLabel9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel9.Location = new System.Drawing.Point(484, 168);
			this.linkLabel9.Name = "linkLabel9";
			this.linkLabel9.Size = new System.Drawing.Size(44, 17);
			this.linkLabel9.TabIndex = 21;
			this.linkLabel9.TabStop = true;
			this.linkLabel9.Text = "delete";
			this.linkLabel9.Visible = false;
			this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel9_LinkClicked);
			// 
			// linkLabel10
			// 
			this.linkLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel10.AutoSize = true;
			this.linkLabel10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel10.Location = new System.Drawing.Point(456, 168);
			this.linkLabel10.Name = "linkLabel10";
			this.linkLabel10.Size = new System.Drawing.Size(28, 17);
			this.linkLabel10.TabIndex = 20;
			this.linkLabel10.TabStop = true;
			this.linkLabel10.Text = "add";
			this.linkLabel10.Visible = false;
			this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel10_LinkClicked);
			// 
			// tbnode3
			// 
			this.tbnode3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbnode3.Location = new System.Drawing.Point(104, 224);
			this.tbnode3.Name = "tbnode3";
			this.tbnode3.Size = new System.Drawing.Size(88, 21);
			this.tbnode3.TabIndex = 19;
			this.tbnode3.Text = "0x00000000";
			// 
			// tbnode2
			// 
			this.tbnode2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbnode2.Location = new System.Drawing.Point(104, 200);
			this.tbnode2.Name = "tbnode2";
			this.tbnode2.Size = new System.Drawing.Size(88, 21);
			this.tbnode2.TabIndex = 18;
			this.tbnode2.Text = "0x00";
			// 
			// tbnode1
			// 
			this.tbnode1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbnode1.Location = new System.Drawing.Point(104, 176);
			this.tbnode1.Name = "tbnode1";
			this.tbnode1.Size = new System.Drawing.Size(88, 21);
			this.tbnode1.TabIndex = 17;
			this.tbnode1.Text = "0x00";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(28, 184);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 17);
			this.label9.TabIndex = 16;
			this.label9.Text = "Enabled?:";
			// 
			// lbnode
			// 
			this.lbnode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbnode.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbnode.HorizontalScrollbar = true;
			this.lbnode.IntegralHeight = false;
			this.lbnode.Location = new System.Drawing.Point(8, 56);
			this.lbnode.Name = "lbnode";
			this.lbnode.Size = new System.Drawing.Size(520, 112);
			this.lbnode.TabIndex = 15;
			this.lbnode.SelectedIndexChanged += new System.EventHandler(this.SelectNode);
			// 
			// tbnodeflname
			// 
			this.tbnodeflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbnodeflname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbnodeflname.Location = new System.Drawing.Point(16, 24);
			this.tbnodeflname.Name = "tbnodeflname";
			this.tbnodeflname.Size = new System.Drawing.Size(512, 21);
			this.tbnodeflname.TabIndex = 13;
			this.tbnodeflname.Text = "";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(8, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(67, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Filename:";
			// 
			// ShpeForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(856, 398);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ShpeForm";
			this.Text = "ShpeForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		//internal Shpe wrapper;

		
		private void SelectUnknown(object sender, System.EventArgs e)
		{
			if (tbunk.Tag!=null) return;
			if (lbunk.SelectedIndex<0) return;

			try 
			{
				tbunk.Tag = true;
				tbunk.Text = "0x"+Helper.HexString((uint)lbunk.Items[lbunk.SelectedIndex]);
			}
			catch (Exception) {}
			finally 
			{
				tbunk.Tag = null;
			}
		}

		private void ChangeUnknown(object sender, System.EventArgs e)
		{
			if (tbunk.Tag!=null) return;
			if (lbunk.SelectedIndex<0) return;

			try 
			{
				tbunk.Tag = true;
				lbunk.Items[lbunk.SelectedIndex] = Convert.ToUInt32(tbunk.Text, 16);}
			catch (Exception) {}
			finally 
			{
				tbunk.Tag = null;
			}
		}

		private void SelectItems(object sender, System.EventArgs e)
		{
			if (lbitem.Tag!=null) return;
			if (lbitem.SelectedIndex<0) return;

			try 
			{
				lbitem.Tag = true;
				ShapeItem item = (ShapeItem)lbitem.Items[lbitem.SelectedIndex];
				tbitemflname.Text = item.FileName;

				tbitemunk1.Text = "0x"+Helper.HexString((uint)item.Unknown1);
				tbitemunk2.Text = "0x"+Helper.HexString(item.Unknown2);
				tbitemunk3.Text = "0x"+Helper.HexString((uint)item.Unknown3);
				tbitemunk4.Text = "0x"+Helper.HexString(item.Unknown4);
			} 
			catch (Exception){}
			finally 
			{
				lbitem.Tag = null;
			}
		}

		private void ChangedItemFilename(object sender, System.EventArgs e)
		{
			if (lbitem.Tag!=null) return;
			if (lbitem.SelectedIndex<0) return;

			try 
			{
				lbitem.Tag = true;
				ShapeItem item = (ShapeItem)lbitem.Items[lbitem.SelectedIndex];
				item.FileName = tbitemflname.Text;
				lbitem.Items[lbitem.SelectedIndex] = item;
			} 
			catch (Exception){}
			finally 
			{
				lbitem.Tag = null;
			}
		}

		private void ChangeItemUnknown(object sender, System.EventArgs e)
		{
			if (lbitem.Tag!=null) return;
			if (lbitem.SelectedIndex<0) return;

			try 
			{
				lbitem.Tag = true;
				ShapeItem item = (ShapeItem)lbitem.Items[lbitem.SelectedIndex];
				item.Unknown1 = (int)Convert.ToUInt32(tbitemunk1.Text, 16);
				item.Unknown2 = Convert.ToByte(tbitemunk2.Text, 16);
				item.Unknown3 = (int)Convert.ToUInt32(tbitemunk3.Text, 16);
				item.Unknown4 = Convert.ToByte(tbitemunk4.Text, 16);
				lbitem.Items[lbitem.SelectedIndex] = item;
			} 
			catch (Exception){}
			finally 
			{
				lbitem.Tag = null;
			}
		}

		private void SelectPart(object sender, System.EventArgs e)
		{
			if (lbpart.Tag!=null) return;
			if (lbpart.SelectedIndex<0) return;

			try 
			{
				lbpart.Tag = true;
				ShapePart item = (ShapePart)lbpart.Items[lbpart.SelectedIndex];
				tbparttype.Text = item.Subset;
				tbpartdsc.Text = item.FileName;

				string s = "";
				foreach (byte b in item.Data) s += Helper.HexString(b)+" ";
				tbpartdata.Text = s;
			} 
			catch (Exception){}
			finally 
			{
				lbpart.Tag = null;
			}
		}

		private void ChangedPart(object sender, System.EventArgs e)
		{
			if (lbpart.Tag!=null) return;
			if (lbpart.SelectedIndex<0) return;

			try 
			{
				lbpart.Tag = true;
				ShapePart item = (ShapePart)lbpart.Items[lbpart.SelectedIndex];
				item.Subset = tbparttype.Text;
				item.FileName = tbpartdsc.Text;
				
				string[] tokens = tbpartdata.Text.Trim().Split(" ".ToCharArray());
				byte[] data = new byte[tokens.Length];
				for (int i=0; i<data.Length; i++) data[i] = Convert.ToByte(tokens[i]);
				item.Data = data;

				lbpart.Items[lbpart.SelectedIndex] = item;
			} 
			catch (Exception){}
			finally 
			{
				lbpart.Tag = null;
			}
		}

		private void UpdateLists()
		{
			try 
			{
				Shape shape = (Shape)this.tabPage1.Tag;

				uint[] unknown = new uint[lbunk.Items.Count];
				for (int i=0; i<unknown.Length; i++) unknown[i] = (uint)lbunk.Items[i];
				shape.Unknwon = unknown;

				ShapeItem[] items = new ShapeItem[lbitem.Items.Count];
				for (int i=0; i<items.Length; i++) items[i] = (ShapeItem)lbitem.Items[i];
				shape.Items = items;

				ShapePart[] parts = new ShapePart[lbpart.Items.Count];
				for (int i=0; i<parts.Length; i++) parts[i] = (ShapePart)lbpart.Items[i];
				shape.Parts = parts;

				ObjectGraphNodeItem[] ogni = new ObjectGraphNodeItem[lbnode.Items.Count];				
				for (int i=0; i<ogni.Length; i++) ogni[i] = (ObjectGraphNodeItem)lbnode.Items[i];
				shape.GraphNode.Items = ogni;
			} 
			catch (Exception){}
		}

		private void Commit(object sender, System.EventArgs e)
		{
			/*try 
			{
				Shpe wrp = (Shpe)wrapper;
				UpdateLists();
				wrp.SynchronizeUserData();

				MessageBox.Show(Localization.Manager.GetString("commited"));
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}*/
		}

		private void SelectNode(object sender, System.EventArgs e)
		{
			if (lbnode.Tag!=null) return;
			if (lbnode.SelectedIndex<0) return;

			try 
			{
				lbnode.Tag = true;
				ObjectGraphNodeItem item = (ObjectGraphNodeItem)lbnode.Items[lbnode.SelectedIndex];
				tbnode1.Text = "0x"+Helper.HexString(item.Enabled);
				tbnode2.Text = "0x"+Helper.HexString(item.Dependant);
				tbnode2.Text = "0x"+Helper.HexString(item.Index);				
			} 
			catch (Exception){}
			finally 
			{
				lbitem.Tag = null;
			}
		}


		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				uint val = Convert.ToUInt32(tbunk.Text, 16);
				lbunk.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbunk.SelectedIndex < 0) return;
			lbunk.Items.RemoveAt(lbunk.SelectedIndex);
			UpdateLists();
		}

		private void linkLabel6_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				//Shpe wrp = (Shpe)wrapper;
				Shape shape = (Shape)this.tabPage2.Tag;

				ShapeItem val = new ShapeItem(shape);
				val.FileName = tbitemflname.Text;
				val.Unknown1 = Convert.ToInt32(tbitemunk1.Text, 16);
				val.Unknown2 = Convert.ToByte(tbitemunk2.Text, 16);
				val.Unknown3 = Convert.ToInt32(tbitemunk3.Text, 16);
				val.Unknown4 = Convert.ToByte(tbitemunk4.Text, 16);

				lbitem.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbitem.SelectedIndex < 0) return;
			lbitem.Items.RemoveAt(lbitem.SelectedIndex);
			UpdateLists();
		}

		private void linkLabel8_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				//Shpe wrp = (Shpe)wrapper;
				Shape shape = (Shape)this.tabPage3.Tag;

				ShapePart val = new ShapePart();
				val.Subset = tbparttype.Text;
				val.FileName = tbpartdsc.Text;
				val.Data = Helper.SetLength(Helper.HexListToBytes(tbpartdata.Text), 9);

				lbpart.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel7_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbpart.SelectedIndex < 0) return;
			lbpart.Items.RemoveAt(lbpart.SelectedIndex);
			UpdateLists();
		}

		private void linkLabel10_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				//Shpe wrp = (Shpe)wrapper;
				Shape shape = (Shape)this.tabPage3.Tag;

				ObjectGraphNodeItem val = new ObjectGraphNodeItem();
				val.Enabled = Convert.ToByte(tbnode1.Text,16);
				val.Dependant = Convert.ToByte(tbnode2.Text,16);
				val.Index = Convert.ToUInt32(tbnode3.Text,16);

				lbnode.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel9_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbnode.SelectedIndex < 0) return;
			lbnode.Items.RemoveAt(lbnode.SelectedIndex);
			UpdateLists();
		}
	}
}
