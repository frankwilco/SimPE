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

namespace SimPe.Plugin.TabPage
{
	/// <summary>
	/// Zusammenfassung für fShapeRefNode.
	/// </summary>
	public class ShapeRefNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
		internal System.Windows.Forms.ListBox lb_srn_b;
		internal System.Windows.Forms.ListBox lb_srn_a;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.LinkLabel ll_srn_dela;
		private System.Windows.Forms.LinkLabel ll_srn_delb;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		internal System.Windows.Forms.TextBox tb_srn_uk2;
		internal System.Windows.Forms.TextBox tb_srn_uk1;
		internal System.Windows.Forms.TextBox tb_srn_uk4;
		internal System.Windows.Forms.TextBox tb_srn_uk3;
		internal System.Windows.Forms.TextBox tb_srn_uk6;
		internal System.Windows.Forms.TextBox tb_srn_uk5;
		internal System.Windows.Forms.TextBox tb_srn_kind;
		internal System.Windows.Forms.TextBox tb_srn_data;
		private System.Windows.Forms.TextBox tb_srn_b_name;
		private System.Windows.Forms.TextBox tb_srn_b_1;
		private System.Windows.Forms.TextBox tb_srn_a_2;
		private System.Windows.Forms.TextBox tb_srn_a_1;
		internal System.Windows.Forms.TextBox tb_srn_ver;
		private System.Windows.Forms.Label label24;				
		private System.ComponentModel.IContainer components;

		public ShapeRefNode()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
            InitializeComponent();

            this.UseVisualStyleBackColor = true;		
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{				
				Tag = null;
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.tb_srn_ver = new System.Windows.Forms.TextBox();
			this.label24 = new System.Windows.Forms.Label();
			this.tb_srn_data = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_srn_kind = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tb_srn_uk6 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_srn_uk5 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_srn_uk4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_srn_uk3 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_srn_uk2 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_srn_uk1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.tb_srn_b_name = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tb_srn_b_1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lb_srn_b = new System.Windows.Forms.ListBox();
			this.ll_srn_delb = new System.Windows.Forms.LinkLabel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tb_srn_a_2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_srn_a_1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_srn_a = new System.Windows.Forms.ListBox();
			this.ll_srn_dela = new System.Windows.Forms.LinkLabel();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tShapeRefNode
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tShapeRefNode";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 0;
			this.Text = "ShapeRefNode";
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox3.Controls.Add(this.tb_srn_ver);
			this.groupBox3.Controls.Add(this.label24);
			this.groupBox3.Controls.Add(this.tb_srn_data);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.tb_srn_kind);
			this.groupBox3.Controls.Add(this.label11);
			this.groupBox3.Controls.Add(this.tb_srn_uk6);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.tb_srn_uk5);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.tb_srn_uk4);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.tb_srn_uk3);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.tb_srn_uk2);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.tb_srn_uk1);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(8, 8);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(344, 248);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Settings";
			// 
			// tb_srn_ver
			// 
			this.tb_srn_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_ver.Location = new System.Drawing.Point(16, 32);
			this.tb_srn_ver.Name = "tb_srn_ver";
			this.tb_srn_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_ver.TabIndex = 22;
			this.tb_srn_ver.Text = "0x00000000";
			this.tb_srn_ver.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label24.Location = new System.Drawing.Point(8, 16);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(52, 17);
			this.label24.TabIndex = 21;
			this.label24.Text = "Version:";
			// 
			// tb_srn_data
			// 
			this.tb_srn_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_srn_data.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_data.Location = new System.Drawing.Point(16, 192);
			this.tb_srn_data.Multiline = true;
			this.tb_srn_data.Name = "tb_srn_data";
			this.tb_srn_data.Size = new System.Drawing.Size(312, 48);
			this.tb_srn_data.TabIndex = 20;
			this.tb_srn_data.Text = "";
			this.tb_srn_data.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label12
			// 
			this.label12.AccessibleDescription = "d";
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(8, 176);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(36, 17);
			this.label12.TabIndex = 19;
			this.label12.Text = "Data:";
			// 
			// tb_srn_kind
			// 
			this.tb_srn_kind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_srn_kind.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_kind.Location = new System.Drawing.Point(16, 152);
			this.tb_srn_kind.Name = "tb_srn_kind";
			this.tb_srn_kind.Size = new System.Drawing.Size(312, 21);
			this.tb_srn_kind.TabIndex = 18;
			this.tb_srn_kind.Text = "0x0000";
			this.tb_srn_kind.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(8, 136);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 17);
			this.label11.TabIndex = 17;
			this.label11.Text = "Kind:";
			// 
			// tb_srn_uk6
			// 
			this.tb_srn_uk6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk6.Location = new System.Drawing.Point(240, 112);
			this.tb_srn_uk6.Name = "tb_srn_uk6";
			this.tb_srn_uk6.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk6.TabIndex = 16;
			this.tb_srn_uk6.Text = "0x00000000";
			this.tb_srn_uk6.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(232, 96);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(73, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "Unknown 6:";
			// 
			// tb_srn_uk5
			// 
			this.tb_srn_uk5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk5.Location = new System.Drawing.Point(240, 72);
			this.tb_srn_uk5.Name = "tb_srn_uk5";
			this.tb_srn_uk5.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk5.TabIndex = 14;
			this.tb_srn_uk5.Text = "0x00000000";
			this.tb_srn_uk5.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(232, 56);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(73, 17);
			this.label10.TabIndex = 13;
			this.label10.Text = "Unknown 5:";
			// 
			// tb_srn_uk4
			// 
			this.tb_srn_uk4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk4.Location = new System.Drawing.Point(128, 112);
			this.tb_srn_uk4.Name = "tb_srn_uk4";
			this.tb_srn_uk4.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk4.TabIndex = 12;
			this.tb_srn_uk4.Text = "0x00";
			this.tb_srn_uk4.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(120, 96);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "Unknown 4:";
			// 
			// tb_srn_uk3
			// 
			this.tb_srn_uk3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk3.Location = new System.Drawing.Point(128, 72);
			this.tb_srn_uk3.Name = "tb_srn_uk3";
			this.tb_srn_uk3.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk3.TabIndex = 10;
			this.tb_srn_uk3.Text = "0x00000000";
			this.tb_srn_uk3.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(120, 56);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "Unknown 3:";
			// 
			// tb_srn_uk2
			// 
			this.tb_srn_uk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk2.Location = new System.Drawing.Point(16, 112);
			this.tb_srn_uk2.Name = "tb_srn_uk2";
			this.tb_srn_uk2.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk2.TabIndex = 8;
			this.tb_srn_uk2.Text = "0x00000000";
			this.tb_srn_uk2.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Unknown 2:";
			// 
			// tb_srn_uk1
			// 
			this.tb_srn_uk1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_uk1.Location = new System.Drawing.Point(16, 72);
			this.tb_srn_uk1.Name = "tb_srn_uk1";
			this.tb_srn_uk1.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_uk1.TabIndex = 6;
			this.tb_srn_uk1.Text = "0x0000";
			this.tb_srn_uk1.TextChanged += new System.EventHandler(this.SRNChangeSettings);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(73, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Unknown 1:";
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.linkLabel4);
			this.groupBox2.Controls.Add(this.tb_srn_b_name);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.tb_srn_b_1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.lb_srn_b);
			this.groupBox2.Controls.Add(this.ll_srn_delb);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(360, 136);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(424, 120);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Unknown List B:";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Location = new System.Drawing.Point(344, 96);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(28, 17);
			this.linkLabel4.TabIndex = 8;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "add";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsBAdd);
			// 
			// tb_srn_b_name
			// 
			this.tb_srn_b_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_srn_b_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_b_name.Location = new System.Drawing.Point(160, 72);
			this.tb_srn_b_name.Multiline = true;
			this.tb_srn_b_name.Name = "tb_srn_b_name";
			this.tb_srn_b_name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tb_srn_b_name.Size = new System.Drawing.Size(256, 24);
			this.tb_srn_b_name.TabIndex = 6;
			this.tb_srn_b_name.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(152, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "Name:";
			// 
			// tb_srn_b_1
			// 
			this.tb_srn_b_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_b_1.Location = new System.Drawing.Point(160, 32);
			this.tb_srn_b_1.Name = "tb_srn_b_1";
			this.tb_srn_b_1.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_b_1.TabIndex = 4;
			this.tb_srn_b_1.Text = "0x00000000";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(152, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "Unknown 1:";
			// 
			// lb_srn_b
			// 
			this.lb_srn_b.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_srn_b.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_srn_b.IntegralHeight = false;
			this.lb_srn_b.Location = new System.Drawing.Point(8, 24);
			this.lb_srn_b.Name = "lb_srn_b";
			this.lb_srn_b.Size = new System.Drawing.Size(136, 88);
			this.lb_srn_b.TabIndex = 2;
			// 
			// ll_srn_delb
			// 
			this.ll_srn_delb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_srn_delb.AutoSize = true;
			this.ll_srn_delb.Location = new System.Drawing.Point(372, 96);
			this.ll_srn_delb.Name = "ll_srn_delb";
			this.ll_srn_delb.Size = new System.Drawing.Size(44, 17);
			this.ll_srn_delb.TabIndex = 7;
			this.ll_srn_delb.TabStop = true;
			this.ll_srn_delb.Text = "delete";
			this.ll_srn_delb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsBDelete);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel3);
			this.groupBox1.Controls.Add(this.tb_srn_a_2);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tb_srn_a_1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lb_srn_a);
			this.groupBox1.Controls.Add(this.ll_srn_dela);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(360, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(256, 120);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Shape Reference Index:";
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(176, 96);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(28, 17);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "add";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsAAdd);
			// 
			// tb_srn_a_2
			// 
			this.tb_srn_a_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_a_2.Location = new System.Drawing.Point(160, 72);
			this.tb_srn_a_2.Name = "tb_srn_a_2";
			this.tb_srn_a_2.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_a_2.TabIndex = 4;
			this.tb_srn_a_2.Text = "0x00000000";
			this.tb_srn_a_2.TextChanged += new System.EventHandler(this.SRNChangedItemsA);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(152, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Child Index:";
			// 
			// tb_srn_a_1
			// 
			this.tb_srn_a_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_srn_a_1.Location = new System.Drawing.Point(160, 32);
			this.tb_srn_a_1.Name = "tb_srn_a_1";
			this.tb_srn_a_1.Size = new System.Drawing.Size(88, 21);
			this.tb_srn_a_1.TabIndex = 2;
			this.tb_srn_a_1.Text = "0x0000";
			this.tb_srn_a_1.TextChanged += new System.EventHandler(this.SRNChangedItemsA);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(152, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Unknown 1:";
			// 
			// lb_srn_a
			// 
			this.lb_srn_a.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_srn_a.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_srn_a.IntegralHeight = false;
			this.lb_srn_a.Location = new System.Drawing.Point(8, 24);
			this.lb_srn_a.Name = "lb_srn_a";
			this.lb_srn_a.Size = new System.Drawing.Size(136, 88);
			this.lb_srn_a.TabIndex = 0;
			this.lb_srn_a.SelectedIndexChanged += new System.EventHandler(this.SRNSelectA);
			// 
			// ll_srn_dela
			// 
			this.ll_srn_dela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_srn_dela.AutoSize = true;
			this.ll_srn_dela.Location = new System.Drawing.Point(204, 96);
			this.ll_srn_dela.Name = "ll_srn_dela";
			this.ll_srn_dela.Size = new System.Drawing.Size(44, 17);
			this.ll_srn_dela.TabIndex = 5;
			this.ll_srn_dela.TabStop = true;
			this.ll_srn_dela.Text = "delete";
			this.ll_srn_dela.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SRNItemsADelete);
			// 
			// fShapeRefNode
			// 			
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SRNChangeSettings(object sender, System.EventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;

				srn.Unknown1 = Convert.ToInt16(this.tb_srn_uk1.Text, 16);
				srn.Unknown2 = Convert.ToInt32(this.tb_srn_uk2.Text, 16);
				srn.Unknown3 = Convert.ToInt32(this.tb_srn_uk3.Text, 16);
				srn.Unknown4 = Convert.ToByte(this.tb_srn_uk4.Text, 16);
				srn.Unknown5 = Convert.ToInt32(this.tb_srn_uk5.Text, 16);
				srn.Unknown6 = Convert.ToInt32(this.tb_srn_uk6.Text, 16);

				srn.Name = this.tb_srn_kind.Text;
				srn.Data = Helper.HexListToBytes(tb_srn_data.Text);

				srn.Version = Convert.ToUInt32(tb_srn_ver.Text, 16);

				srn.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		#region Select SRN Items A
		private void SRNSelectA(object sender, System.EventArgs e)
		{
			if (lb_srn_a.Tag != null) return;
			if (this.lb_srn_a.SelectedIndex<0) return;

			try 
			{
				lb_srn_a.Tag = true;
				ShapeRefNodeItem_A a = (ShapeRefNodeItem_A)lb_srn_a.Items[lb_srn_a.SelectedIndex];

				tb_srn_a_1.Text = "0x"+Helper.HexString(a.Unknown1);
				tb_srn_a_2.Text = "0x"+Helper.HexString((uint)a.Unknown2);

				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				srn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_a.Tag = null;
			}
		}

		private void SRNChangedItemsA(object sender, System.EventArgs e)
		{
			if (lb_srn_a.Tag != null) return;
			if (this.lb_srn_a.SelectedIndex<0) return;

			try 
			{
				lb_srn_a.Tag = true;
				ShapeRefNodeItem_A a = (ShapeRefNodeItem_A)lb_srn_a.Items[lb_srn_a.SelectedIndex];

				a.Unknown1 = Convert.ToUInt16(tb_srn_a_1.Text, 16);
				a.Unknown2 = (int)Convert.ToUInt32(tb_srn_a_2.Text, 16);

				lb_srn_a.Items[lb_srn_a.SelectedIndex] = a;

				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				srn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_a.Tag = null;
			}
		}

		private void SRNItemsAAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				lb_srn_a.Tag = true;
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				ShapeRefNodeItem_A a = new ShapeRefNodeItem_A();

				tb_srn_a_1.Text = "0x"+Helper.HexString(a.Unknown1);
				tb_srn_a_2.Text = "0x"+Helper.HexString((uint)a.Unknown2);

				srn.ItemsA = (ShapeRefNodeItem_A[])Helper.Add(srn.ItemsA, a);
				lb_srn_a.Items.Add(a);

				srn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_a.Tag = null;
			}
		}

		private void SRNItemsADelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			if (lb_srn_a.SelectedIndex<0) return;
			try 
			{
				lb_srn_a.Tag = true;
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				ShapeRefNodeItem_A a = (ShapeRefNodeItem_A)lb_srn_a.Items[lb_srn_a.SelectedIndex];

				srn.ItemsA = (ShapeRefNodeItem_A[])Helper.Delete(srn.ItemsA, a);
				lb_srn_a.Items.Remove(a);

				srn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_a.Tag = null;
			}
		}
		#endregion

		#region Select SRN Items B
		private void SRNSelectB(object sender, System.EventArgs e)
		{
			if (lb_srn_b.Tag != null) return;
			if (this.lb_srn_b.SelectedIndex<0) return;

			try 
			{
				lb_srn_b.Tag = true;
				ShapeRefNodeItem_B b = (ShapeRefNodeItem_B)lb_srn_b.Items[lb_srn_b.SelectedIndex];

				tb_srn_b_1.Text = "0x"+Helper.HexString((uint)b.Unknown1);
				tb_srn_b_name.Text = b.Name;

				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				srn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_b.Tag = null;
			}
		}

		private void SRNChangedItemsB(object sender, System.EventArgs e)
		{
			if (lb_srn_b.Tag != null) return;
			if (this.lb_srn_b.SelectedIndex<0) return;

			try 
			{
				lb_srn_b.Tag = true;
				ShapeRefNodeItem_B b = (ShapeRefNodeItem_B)lb_srn_b.Items[lb_srn_b.SelectedIndex];

				b.Unknown1 = (int)Convert.ToUInt32(tb_srn_b_1.Text, 16);
				b.Name= tb_srn_b_name.Text;

				lb_srn_b.Items[lb_srn_b.SelectedIndex] = b;
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				srn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_b.Tag = null;
			}
		}

		private void SRNItemsBAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				lb_srn_b.Tag = true;
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				ShapeRefNodeItem_B b = new ShapeRefNodeItem_B();

				b.Unknown1 = (int)Convert.ToUInt32(tb_srn_b_1.Text, 16);
				b.Name= tb_srn_b_name.Text;

				srn.ItemsB = (ShapeRefNodeItem_B[])Helper.Add(srn.ItemsB, b);
				lb_srn_b.Items.Add(b);
				srn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_b.Tag = null;
			}
		}

		private void SRNItemsBDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			if (lb_srn_b.SelectedIndex<0) return;
			try 
			{
				lb_srn_b.Tag = true;
				SimPe.Plugin.ShapeRefNode srn = (SimPe.Plugin.ShapeRefNode)Tag;
				ShapeRefNodeItem_B b = (ShapeRefNodeItem_B)lb_srn_b.Items[lb_srn_b.SelectedIndex];

				srn.ItemsB = (ShapeRefNodeItem_B[])Helper.Delete(srn.ItemsB, b);
				lb_srn_b.Items.Remove(b);

				srn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_srn_b.Tag = null;
			}
		}
		#endregion
				
	}
}
