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
	public class TransformNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.LinkLabel ll_tn_add;
		private System.Windows.Forms.TextBox tb_tn_2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox tb_tn_1;
		private System.Windows.Forms.Label label17;
		internal System.Windows.Forms.ListBox lb_tn;
		private System.Windows.Forms.LinkLabel ll_tn_delete;
		private System.Windows.Forms.GroupBox groupBox7;
		internal System.Windows.Forms.TextBox tb_tn_ver;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.GroupBox groupBox15;
		private System.Windows.Forms.GroupBox groupBox16;
		internal System.Windows.Forms.TextBox tb_tn_ukn;
		private System.Windows.Forms.Label label19;
		internal System.Windows.Forms.TextBox tb_tn_tx;
		private System.Windows.Forms.Label label49;
		internal System.Windows.Forms.TextBox tb_tn_ty;
		private System.Windows.Forms.Label label50;
		internal System.Windows.Forms.TextBox tb_tn_tz;
		private System.Windows.Forms.Label label51;
		internal System.Windows.Forms.TextBox tb_tn_rz;
		private System.Windows.Forms.Label label52;
		internal System.Windows.Forms.TextBox tb_tn_ry;
		private System.Windows.Forms.Label label53;
		internal System.Windows.Forms.TextBox tb_tn_rx;
		private System.Windows.Forms.Label label54;
		internal System.Windows.Forms.TextBox tb_tn_rw;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.GroupBox groupBox12;
		internal System.Windows.Forms.TextBox tb_tn_a;
		private System.Windows.Forms.Label label30;
		internal System.Windows.Forms.TextBox tb_tn_az;
		private System.Windows.Forms.Label label31;
		internal System.Windows.Forms.TextBox tb_tn_ay;
		private System.Windows.Forms.Label label56;
		internal System.Windows.Forms.TextBox tb_tn_ax;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.GroupBox groupBox18;
		internal System.Windows.Forms.TextBox tb_tn_er;
		private System.Windows.Forms.Label label60;
		internal System.Windows.Forms.TextBox tb_tn_ep;
		private System.Windows.Forms.Label label61;
		internal System.Windows.Forms.TextBox tb_tn_ey;
		private System.Windows.Forms.Label label62;
		private System.ComponentModel.IContainer components;

		public TransformNode()
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
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.tb_tn_ukn = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.tb_tn_ver = new System.Windows.Forms.TextBox();
			this.label26 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.ll_tn_add = new System.Windows.Forms.LinkLabel();
			this.tb_tn_2 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.tb_tn_1 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.lb_tn = new System.Windows.Forms.ListBox();
			this.ll_tn_delete = new System.Windows.Forms.LinkLabel();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.tb_tn_tz = new System.Windows.Forms.TextBox();
			this.label51 = new System.Windows.Forms.Label();
			this.tb_tn_ty = new System.Windows.Forms.TextBox();
			this.label50 = new System.Windows.Forms.Label();
			this.tb_tn_tx = new System.Windows.Forms.TextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.tb_tn_rw = new System.Windows.Forms.TextBox();
			this.label55 = new System.Windows.Forms.Label();
			this.tb_tn_rz = new System.Windows.Forms.TextBox();
			this.label52 = new System.Windows.Forms.Label();
			this.tb_tn_ry = new System.Windows.Forms.TextBox();
			this.label53 = new System.Windows.Forms.Label();
			this.tb_tn_rx = new System.Windows.Forms.TextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.tb_tn_a = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.tb_tn_az = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.tb_tn_ay = new System.Windows.Forms.TextBox();
			this.label56 = new System.Windows.Forms.Label();
			this.tb_tn_ax = new System.Windows.Forms.TextBox();
			this.label57 = new System.Windows.Forms.Label();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.tb_tn_er = new System.Windows.Forms.TextBox();
			this.label60 = new System.Windows.Forms.Label();
			this.tb_tn_ep = new System.Windows.Forms.TextBox();
			this.label61 = new System.Windows.Forms.Label();
			this.tb_tn_ey = new System.Windows.Forms.TextBox();
			this.label62 = new System.Windows.Forms.Label();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.SuspendLayout();
			// 
			// tTransformNode
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.groupBox15);
			this.Controls.Add(this.groupBox16);
			this.Controls.Add(this.groupBox12);
			this.Controls.Add(this.groupBox18);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tTransformNode";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 2;
			this.Text = "TransformNode";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.tb_tn_ukn);
			this.groupBox7.Controls.Add(this.label19);
			this.groupBox7.Controls.Add(this.tb_tn_ver);
			this.groupBox7.Controls.Add(this.label26);
			this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(8, 7);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(296, 73);
			this.groupBox7.TabIndex = 8;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Settings";
			// 
			// tb_tn_ukn
			// 
			this.tb_tn_ukn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ukn.Location = new System.Drawing.Point(136, 40);
			this.tb_tn_ukn.Name = "tb_tn_ukn";
			this.tb_tn_ukn.Size = new System.Drawing.Size(88, 21);
			this.tb_tn_ukn.TabIndex = 26;
			this.tb_tn_ukn.Text = "0x00000000";
			this.tb_tn_ukn.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(128, 24);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(109, 17);
			this.label19.TabIndex = 25;
			this.label19.Text = "GMDC joint index:";
			// 
			// tb_tn_ver
			// 
			this.tb_tn_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_tn_ver.Name = "tb_tn_ver";
			this.tb_tn_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_tn_ver.TabIndex = 24;
			this.tb_tn_ver.Text = "0x00000000";
			this.tb_tn_ver.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label26.Location = new System.Drawing.Point(8, 24);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(52, 17);
			this.label26.TabIndex = 23;
			this.label26.Text = "Version:";
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox6.Controls.Add(this.ll_tn_add);
			this.groupBox6.Controls.Add(this.tb_tn_2);
			this.groupBox6.Controls.Add(this.label16);
			this.groupBox6.Controls.Add(this.tb_tn_1);
			this.groupBox6.Controls.Add(this.label17);
			this.groupBox6.Controls.Add(this.lb_tn);
			this.groupBox6.Controls.Add(this.ll_tn_delete);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(504, 8);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(256, 248);
			this.groupBox6.TabIndex = 6;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Child Nodes:";
			// 
			// ll_tn_add
			// 
			this.ll_tn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_tn_add.AutoSize = true;
			this.ll_tn_add.Location = new System.Drawing.Point(176, 96);
			this.ll_tn_add.Name = "ll_tn_add";
			this.ll_tn_add.Size = new System.Drawing.Size(28, 17);
			this.ll_tn_add.TabIndex = 6;
			this.ll_tn_add.TabStop = true;
			this.ll_tn_add.Text = "add";
			this.ll_tn_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TNItemsAdd);
			// 
			// tb_tn_2
			// 
			this.tb_tn_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_2.Location = new System.Drawing.Point(160, 72);
			this.tb_tn_2.Name = "tb_tn_2";
			this.tb_tn_2.Size = new System.Drawing.Size(88, 21);
			this.tb_tn_2.TabIndex = 4;
			this.tb_tn_2.Text = "0x00000000";
			this.tb_tn_2.TextChanged += new System.EventHandler(this.TNChangedItems);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(152, 56);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(74, 17);
			this.label16.TabIndex = 3;
			this.label16.Text = "Child Index:";
			// 
			// tb_tn_1
			// 
			this.tb_tn_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_1.Location = new System.Drawing.Point(160, 32);
			this.tb_tn_1.Name = "tb_tn_1";
			this.tb_tn_1.Size = new System.Drawing.Size(88, 21);
			this.tb_tn_1.TabIndex = 2;
			this.tb_tn_1.Text = "0x0000";
			this.tb_tn_1.TextChanged += new System.EventHandler(this.TNChangedItems);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(152, 16);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(73, 17);
			this.label17.TabIndex = 1;
			this.label17.Text = "Unknown 1:";
			// 
			// lb_tn
			// 
			this.lb_tn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_tn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_tn.IntegralHeight = false;
			this.lb_tn.Location = new System.Drawing.Point(8, 24);
			this.lb_tn.Name = "lb_tn";
			this.lb_tn.Size = new System.Drawing.Size(136, 216);
			this.lb_tn.TabIndex = 0;
			this.lb_tn.SelectedIndexChanged += new System.EventHandler(this.TNSelect);
			// 
			// ll_tn_delete
			// 
			this.ll_tn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_tn_delete.AutoSize = true;
			this.ll_tn_delete.Location = new System.Drawing.Point(204, 96);
			this.ll_tn_delete.Name = "ll_tn_delete";
			this.ll_tn_delete.Size = new System.Drawing.Size(44, 17);
			this.ll_tn_delete.TabIndex = 5;
			this.ll_tn_delete.TabStop = true;
			this.ll_tn_delete.Text = "delete";
			this.ll_tn_delete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TNItemsDelete);
			// 
			// groupBox15
			// 
			this.groupBox15.Controls.Add(this.tb_tn_tz);
			this.groupBox15.Controls.Add(this.label51);
			this.groupBox15.Controls.Add(this.tb_tn_ty);
			this.groupBox15.Controls.Add(this.label50);
			this.groupBox15.Controls.Add(this.tb_tn_tx);
			this.groupBox15.Controls.Add(this.label49);
			this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox15.Location = new System.Drawing.Point(8, 128);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(120, 104);
			this.groupBox15.TabIndex = 25;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Translation:";
			// 
			// tb_tn_tz
			// 
			this.tb_tn_tz.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_tz.Location = new System.Drawing.Point(40, 72);
			this.tb_tn_tz.Name = "tb_tn_tz";
			this.tb_tn_tz.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_tz.TabIndex = 32;
			this.tb_tn_tz.Text = "0x00000000";
			this.tb_tn_tz.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label51
			// 
			this.label51.AutoSize = true;
			this.label51.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label51.Location = new System.Drawing.Point(16, 80);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(17, 17);
			this.label51.TabIndex = 31;
			this.label51.Text = "Z:";
			// 
			// tb_tn_ty
			// 
			this.tb_tn_ty.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ty.Location = new System.Drawing.Point(40, 48);
			this.tb_tn_ty.Name = "tb_tn_ty";
			this.tb_tn_ty.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_ty.TabIndex = 30;
			this.tb_tn_ty.Text = "0x00000000";
			this.tb_tn_ty.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label50
			// 
			this.label50.AutoSize = true;
			this.label50.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label50.Location = new System.Drawing.Point(16, 56);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(16, 17);
			this.label50.TabIndex = 29;
			this.label50.Text = "Y:";
			// 
			// tb_tn_tx
			// 
			this.tb_tn_tx.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_tx.Location = new System.Drawing.Point(40, 24);
			this.tb_tn_tx.Name = "tb_tn_tx";
			this.tb_tn_tx.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_tx.TabIndex = 28;
			this.tb_tn_tx.Text = "0x00000000";
			this.tb_tn_tx.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label49
			// 
			this.label49.AutoSize = true;
			this.label49.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label49.Location = new System.Drawing.Point(16, 32);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(17, 17);
			this.label49.TabIndex = 27;
			this.label49.Text = "X:";
			// 
			// groupBox16
			// 
			this.groupBox16.Controls.Add(this.tb_tn_rw);
			this.groupBox16.Controls.Add(this.label55);
			this.groupBox16.Controls.Add(this.tb_tn_rz);
			this.groupBox16.Controls.Add(this.label52);
			this.groupBox16.Controls.Add(this.tb_tn_ry);
			this.groupBox16.Controls.Add(this.label53);
			this.groupBox16.Controls.Add(this.tb_tn_rx);
			this.groupBox16.Controls.Add(this.label54);
			this.groupBox16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox16.Location = new System.Drawing.Point(136, 104);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(120, 128);
			this.groupBox16.TabIndex = 26;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Quaternion:";
			// 
			// tb_tn_rw
			// 
			this.tb_tn_rw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_rw.Location = new System.Drawing.Point(40, 96);
			this.tb_tn_rw.Name = "tb_tn_rw";
			this.tb_tn_rw.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_rw.TabIndex = 40;
			this.tb_tn_rw.Text = "0x00000000";
			this.tb_tn_rw.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label55
			// 
			this.label55.AutoSize = true;
			this.label55.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label55.Location = new System.Drawing.Point(16, 104);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(21, 17);
			this.label55.TabIndex = 39;
			this.label55.Text = "W:";
			// 
			// tb_tn_rz
			// 
			this.tb_tn_rz.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_rz.Location = new System.Drawing.Point(40, 72);
			this.tb_tn_rz.Name = "tb_tn_rz";
			this.tb_tn_rz.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_rz.TabIndex = 38;
			this.tb_tn_rz.Text = "0x00000000";
			this.tb_tn_rz.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label52
			// 
			this.label52.AutoSize = true;
			this.label52.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label52.Location = new System.Drawing.Point(16, 80);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(17, 17);
			this.label52.TabIndex = 37;
			this.label52.Text = "Z:";
			// 
			// tb_tn_ry
			// 
			this.tb_tn_ry.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ry.Location = new System.Drawing.Point(40, 48);
			this.tb_tn_ry.Name = "tb_tn_ry";
			this.tb_tn_ry.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_ry.TabIndex = 36;
			this.tb_tn_ry.Text = "0x00000000";
			this.tb_tn_ry.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label53
			// 
			this.label53.AutoSize = true;
			this.label53.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label53.Location = new System.Drawing.Point(16, 56);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(16, 17);
			this.label53.TabIndex = 35;
			this.label53.Text = "Y:";
			// 
			// tb_tn_rx
			// 
			this.tb_tn_rx.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_rx.Location = new System.Drawing.Point(40, 24);
			this.tb_tn_rx.Name = "tb_tn_rx";
			this.tb_tn_rx.Size = new System.Drawing.Size(72, 21);
			this.tb_tn_rx.TabIndex = 34;
			this.tb_tn_rx.Text = "0x00000000";
			this.tb_tn_rx.TextChanged += new System.EventHandler(this.TNChangeSettings);
			// 
			// label54
			// 
			this.label54.AutoSize = true;
			this.label54.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label54.Location = new System.Drawing.Point(16, 32);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(17, 17);
			this.label54.TabIndex = 33;
			this.label54.Text = "X:";
			// 
			// groupBox12
			// 
			this.groupBox12.Controls.Add(this.tb_tn_a);
			this.groupBox12.Controls.Add(this.label30);
			this.groupBox12.Controls.Add(this.tb_tn_az);
			this.groupBox12.Controls.Add(this.label31);
			this.groupBox12.Controls.Add(this.tb_tn_ay);
			this.groupBox12.Controls.Add(this.label56);
			this.groupBox12.Controls.Add(this.tb_tn_ax);
			this.groupBox12.Controls.Add(this.label57);
			this.groupBox12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(264, 104);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(112, 128);
			this.groupBox12.TabIndex = 41;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Rotation:";
			// 
			// tb_tn_a
			// 
			this.tb_tn_a.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_a.Location = new System.Drawing.Point(64, 96);
			this.tb_tn_a.Name = "tb_tn_a";
			this.tb_tn_a.Size = new System.Drawing.Size(40, 21);
			this.tb_tn_a.TabIndex = 40;
			this.tb_tn_a.Text = "0";
			this.tb_tn_a.TextChanged += new System.EventHandler(this.TNChangedQuaternion);
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label30.Location = new System.Drawing.Point(16, 104);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(41, 17);
			this.label30.TabIndex = 39;
			this.label30.Text = "Angle:";
			// 
			// tb_tn_az
			// 
			this.tb_tn_az.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_az.Location = new System.Drawing.Point(40, 72);
			this.tb_tn_az.Name = "tb_tn_az";
			this.tb_tn_az.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_az.TabIndex = 38;
			this.tb_tn_az.Text = "0";
			this.tb_tn_az.TextChanged += new System.EventHandler(this.TNChangedQuaternion);
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label31.Location = new System.Drawing.Point(16, 80);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(17, 17);
			this.label31.TabIndex = 37;
			this.label31.Text = "Z:";
			// 
			// tb_tn_ay
			// 
			this.tb_tn_ay.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ay.Location = new System.Drawing.Point(40, 48);
			this.tb_tn_ay.Name = "tb_tn_ay";
			this.tb_tn_ay.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_ay.TabIndex = 36;
			this.tb_tn_ay.Text = "0";
			this.tb_tn_ay.TextChanged += new System.EventHandler(this.TNChangedQuaternion);
			// 
			// label56
			// 
			this.label56.AutoSize = true;
			this.label56.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label56.Location = new System.Drawing.Point(16, 56);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(16, 17);
			this.label56.TabIndex = 35;
			this.label56.Text = "Y:";
			// 
			// tb_tn_ax
			// 
			this.tb_tn_ax.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ax.Location = new System.Drawing.Point(40, 24);
			this.tb_tn_ax.Name = "tb_tn_ax";
			this.tb_tn_ax.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_ax.TabIndex = 34;
			this.tb_tn_ax.Text = "0";
			this.tb_tn_ax.TextChanged += new System.EventHandler(this.TNChangedQuaternion);
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label57.Location = new System.Drawing.Point(16, 32);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(17, 17);
			this.label57.TabIndex = 33;
			this.label57.Text = "X:";
			// 
			// groupBox18
			// 
			this.groupBox18.Controls.Add(this.tb_tn_er);
			this.groupBox18.Controls.Add(this.label60);
			this.groupBox18.Controls.Add(this.tb_tn_ep);
			this.groupBox18.Controls.Add(this.label61);
			this.groupBox18.Controls.Add(this.tb_tn_ey);
			this.groupBox18.Controls.Add(this.label62);
			this.groupBox18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(384, 128);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(112, 104);
			this.groupBox18.TabIndex = 42;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Euler Rotation:";
			// 
			// tb_tn_er
			// 
			this.tb_tn_er.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_er.Location = new System.Drawing.Point(40, 72);
			this.tb_tn_er.Name = "tb_tn_er";
			this.tb_tn_er.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_er.TabIndex = 38;
			this.tb_tn_er.Text = "0";
			this.tb_tn_er.TextChanged += new System.EventHandler(this.TNChangedEulerQuaternion);
			// 
			// label60
			// 
			this.label60.AutoSize = true;
			this.label60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label60.Location = new System.Drawing.Point(16, 80);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(17, 17);
			this.label60.TabIndex = 37;
			this.label60.Text = "R:";
			// 
			// tb_tn_ep
			// 
			this.tb_tn_ep.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ep.Location = new System.Drawing.Point(40, 48);
			this.tb_tn_ep.Name = "tb_tn_ep";
			this.tb_tn_ep.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_ep.TabIndex = 36;
			this.tb_tn_ep.Text = "0";
			this.tb_tn_ep.TextChanged += new System.EventHandler(this.TNChangedEulerQuaternion);
			// 
			// label61
			// 
			this.label61.AutoSize = true;
			this.label61.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label61.Location = new System.Drawing.Point(16, 56);
			this.label61.Name = "label61";
			this.label61.Size = new System.Drawing.Size(16, 17);
			this.label61.TabIndex = 35;
			this.label61.Text = "P:";
			// 
			// tb_tn_ey
			// 
			this.tb_tn_ey.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_ey.Location = new System.Drawing.Point(40, 24);
			this.tb_tn_ey.Name = "tb_tn_ey";
			this.tb_tn_ey.Size = new System.Drawing.Size(64, 21);
			this.tb_tn_ey.TabIndex = 34;
			this.tb_tn_ey.Text = "0";
			this.tb_tn_ey.TextChanged += new System.EventHandler(this.TNChangedEulerQuaternion);
			// 
			// label62
			// 
			this.label62.AutoSize = true;
			this.label62.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label62.Location = new System.Drawing.Point(16, 32);
			this.label62.Name = "label62";
			this.label62.Size = new System.Drawing.Size(16, 17);
			this.label62.TabIndex = 33;
			this.label62.Text = "Y:";
			// 
			// fShapeRefNode
			// 			
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		
		

		private void TNChangeSettings(object sender, System.EventArgs e)
		{
			if (this.tb_tn_a.Tag!=null) return;
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;

				tn.Version = Convert.ToUInt32(tb_tn_ver.Text, 16);
				tn.JointReference = Convert.ToInt32(tb_tn_ukn.Text, 16);

				tn.TransformX = Convert.ToSingle(tb_tn_tx.Text);
				tn.TransformY = Convert.ToSingle(tb_tn_ty.Text);
				tn.TransformZ = Convert.ToSingle(tb_tn_tz.Text);

				tn.RotationX = Convert.ToSingle(tb_tn_rx.Text);
				tn.RotationY = Convert.ToSingle(tb_tn_ry.Text);
				tn.RotationZ = Convert.ToSingle(tb_tn_rz.Text);
				tn.RotationW = Convert.ToSingle(tb_tn_rw.Text);
				

				//set Angles
				  
				
				SimPe.Geometry.Quaternion q = tn.Rotation;
				TNUpdateTextValues(q, false, true, true);
				
				tn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		private void TNChangedQuaternion(object sender, System.EventArgs e)
		{
			if (this.tb_tn_a.Tag!=null) return;
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				SimPe.Geometry.Quaternion q = SimPe.Geometry.Quaternion.FromAxisAngle(					
					new SimPe.Geometry.Vector3f(
					Convert.ToSingle(tb_tn_ax.Text),
					Convert.ToSingle(tb_tn_ay.Text),
					Convert.ToSingle(tb_tn_az.Text)), 
					SimPe.Geometry.Quaternion.DegToRad(Convert.ToSingle(tb_tn_a.Text)));
			
				tn.Rotation = q;

				TNUpdateTextValues(q, true, false, true);			
			} 
			catch {}
			finally 
			{
				this.tb_tn_a.Tag = null;
			}
		}

		internal void TNUpdateTextValues(SimPe.Geometry.Quaternion q, bool quat, bool axis, bool euler)
		{
			//set Angles
			try 
			{
				this.tb_tn_a.Tag = true;
				if (quat) 
				{
					this.tb_tn_rx.Text = q.X.ToString("N6");
					this.tb_tn_ry.Text = q.Y.ToString("N6");
					this.tb_tn_rz.Text = q.Z.ToString("N6");
					this.tb_tn_rw.Text = q.W.ToString("N6");
				}

				if (axis)
				{
					this.tb_tn_ax.Text = q.Axis.X.ToString("N6");
					this.tb_tn_ay.Text = q.Axis.Y.ToString("N6");
					this.tb_tn_az.Text = q.Axis.Z.ToString("N6");
					this.tb_tn_a.Text = SimPe.Geometry.Quaternion.RadToDeg(q.Angle).ToString("N6");
				}

				if (euler)
				{
					SimPe.Geometry.Vector3f ea = q.GetEulerAngles();
					this.tb_tn_ey.Text = SimPe.Geometry.Quaternion.RadToDeg(ea.Y).ToString("N6");
					this.tb_tn_ep.Text = SimPe.Geometry.Quaternion.RadToDeg(ea.X).ToString("N6");
					this.tb_tn_er.Text = SimPe.Geometry.Quaternion.RadToDeg(ea.Z).ToString("N6");
				}
			} 
			finally 
			{
				this.tb_tn_a.Tag = null;
			}
		}


		private void TNChangedEulerQuaternion(object sender, System.EventArgs e)
		{
			if (this.tb_tn_a.Tag!=null) return;
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				SimPe.Geometry.Quaternion q = SimPe.Geometry.Quaternion.FromEulerAngles(										
					SimPe.Geometry.Quaternion.DegToRad(Convert.ToSingle(tb_tn_ey.Text)),
					SimPe.Geometry.Quaternion.DegToRad(Convert.ToSingle(tb_tn_ep.Text)),
					SimPe.Geometry.Quaternion.DegToRad(Convert.ToSingle(tb_tn_er.Text)) 
					);			
				tn.Rotation = q;

				TNUpdateTextValues(q, true, true, false);			
			} 
			catch {}
			finally 
			{
				this.tb_tn_a.Tag = null;
			}
		}



		#region Select TN Items 
		private void TNSelect(object sender, System.EventArgs e)
		{
			if (lb_tn.Tag != null) return;
			if (this.lb_tn.SelectedIndex<0) return;

			try 
			{
				lb_tn.Tag = true;
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				tb_tn_1.Text = "0x"+Helper.HexString((ushort)b.Unknown1);
				tb_tn_2.Text = "0x"+Helper.HexString((uint)b.ChildNode);
				tn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_tn.Tag = null;
			}
		}

		private void TNChangedItems(object sender, System.EventArgs e)
		{
			if (lb_tn.Tag != null) return;
			if (this.lb_tn.SelectedIndex<0) return;

			try 
			{
				lb_tn.Tag = true;
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				b.Unknown1 = Convert.ToUInt16(tb_tn_1.Text, 16);
				b.ChildNode = (int)Convert.ToUInt32(tb_tn_2.Text, 16);

				lb_tn.Items[lb_tn.SelectedIndex] = b;
				tn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_tn.Tag = null;
			}
		}

		private void TNItemsAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				lb_tn.Tag = true;
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				TransformNodeItem b = new TransformNodeItem();

				b.Unknown1 = Convert.ToUInt16(tb_tn_1.Text, 16);
				b.ChildNode = (int)Convert.ToUInt32(tb_tn_2.Text, 16);

				tn.Items.Add(b);//= (TransformNodeItem[])Helper.Add(tn.Items, b);
				lb_tn.Items.Add(b);
				tn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_tn.Tag = null;
			}
		}

		private void TNItemsDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (Tag==null) return;
			if (lb_tn.SelectedIndex<0) return;
			try 
			{
				lb_tn.Tag = true;
				SimPe.Plugin.TransformNode tn = (SimPe.Plugin.TransformNode)Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				tn.Items.Remove(b);// = (TransformNodeItem[])Helper.Delete(tn.Items, b);
				lb_tn.Items.Remove(b);
				tn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_tn.Tag = null;
			}
		}
		#endregion		
						

		/*private void LSettingsChanged(object sender, System.EventArgs e)
		{
			if (this.tDirectionalLight.Tag==null) return;
			try 
			{
				DirectionalLight dl = (DirectionalLight)tDirectionalLight.Tag;

				dl.Version = Convert.ToUInt32(tb_l_ver.Text, 16);
				dl.Name = tb_l_name.Text;
				dl.Val1 = Convert.ToSingle(tb_l_1.Text);
				dl.Val2 = Convert.ToSingle(tb_l_2.Text);
				dl.Red = Convert.ToSingle(tb_l_3.Text);
				dl.Green = Convert.ToSingle(tb_l_4.Text);
				dl.Blue = Convert.ToSingle(tb_l_5.Text);

				if (tDirectionalLight.Tag.GetType() == typeof(PointLight)) 
				{
					PointLight pl = (PointLight)tDirectionalLight.Tag;

					pl.Val6 = Convert.ToSingle(tb_l_6.Text);
					pl.Val7 = Convert.ToSingle(tb_l_7.Text);
				}

				if (tDirectionalLight.Tag.GetType() == typeof(SpotLight)) 
				{
					SpotLight sl = (SpotLight)tDirectionalLight.Tag;

					sl.Val6 = Convert.ToSingle(tb_l_6.Text);
					sl.Val7 = Convert.ToSingle(tb_l_7.Text);
					sl.Val8 = Convert.ToSingle(tb_l_8.Text);
					sl.Val9 = Convert.ToSingle(tb_l_9.Text);
				}
				
				dl.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		private void LTSettingsChanged(object sender, System.EventArgs e)
		{
			if (this.tLightT.Tag==null) return;
			try 
			{
				LightT lt = (LightT)tLightT.Tag;

				lt.Version = Convert.ToUInt32(tb_lt_ver.Text, 16);
				lt.NameResource.FileName = tb_lt_name.Text;
				
				lt.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

				
		

		internal void ClearControlTags()
		{
			if (this.Controls==null) return;
			foreach (Control c in this.Controls)
				c.Tag = null;
		}*/
	}
}
