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
	/// Zusammenfassung für fShapeRefNode.
	/// </summary>
	public class fShapeRefNode : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tShapeRefNode;
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
		internal System.Windows.Forms.TabPage tResourceNode;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.LinkLabel ll_rn_add;
		private System.Windows.Forms.TextBox tb_rn_2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tb_rn_1;
		private System.Windows.Forms.Label label14;
		internal System.Windows.Forms.ListBox lb_rn;
		private System.Windows.Forms.LinkLabel ll_rn_delete;
		private System.Windows.Forms.GroupBox groupBox5;
		internal System.Windows.Forms.TextBox tb_rn_uk1;
		private System.Windows.Forms.Label label22;
		internal System.Windows.Forms.TextBox tb_rn_uk2;
		private System.Windows.Forms.Label label15;
		internal System.Windows.Forms.TabPage tTransformNode;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.LinkLabel ll_tn_add;
		private System.Windows.Forms.TextBox tb_tn_2;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox tb_tn_1;
		private System.Windows.Forms.Label label17;
		internal System.Windows.Forms.ListBox lb_tn;
		private System.Windows.Forms.LinkLabel ll_tn_delete;
		private System.Windows.Forms.GroupBox groupBox7;
		internal System.Windows.Forms.TabPage tObjectGraphNode;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.LinkLabel ll_ogn_add;
		private System.Windows.Forms.TextBox tb_ogn_2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox tb_ogn_1;
		private System.Windows.Forms.Label label21;
		internal System.Windows.Forms.ListBox lb_ogn;
		private System.Windows.Forms.LinkLabel ll_ogn_delete;
		private System.Windows.Forms.TextBox tb_ogn_3;
		private System.Windows.Forms.Label label23;
		internal System.Windows.Forms.TextBox tb_ogn_file;
		private System.Windows.Forms.Label label18;
		internal System.Windows.Forms.TextBox tb_srn_ver;
		private System.Windows.Forms.Label label24;
		internal System.Windows.Forms.TextBox tb_rn_ver;
		private System.Windows.Forms.Label label25;
		internal System.Windows.Forms.TextBox tb_tn_ver;
		private System.Windows.Forms.Label label26;
		internal System.Windows.Forms.TextBox tb_ogn_ver;
		private System.Windows.Forms.Label label27;
		internal System.Windows.Forms.TabPage tGenericRcol;
		private System.Windows.Forms.GroupBox groupBox10;
		internal System.Windows.Forms.TextBox tb_ver;
		private System.Windows.Forms.Label label28;
		internal System.Windows.Forms.TabPage tGeometryNode;
		private System.Windows.Forms.GroupBox groupBox11;
		internal System.Windows.Forms.TextBox tb_gn_ver;
		private System.Windows.Forms.Label label29;
		internal System.Windows.Forms.TextBox tb_gn_uk3;
		private System.Windows.Forms.Label label33;
		internal System.Windows.Forms.TextBox tb_gn_uk2;
		private System.Windows.Forms.Label label35;
		internal System.Windows.Forms.TextBox tb_gn_count;
		private System.Windows.Forms.Label label36;
		internal System.Windows.Forms.TextBox tb_gn_uk1;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.ToolTip toolTip1;
		internal System.Windows.Forms.TabPage tDirectionalLight;
		private System.Windows.Forms.GroupBox groupBox13;
		internal System.Windows.Forms.TextBox tb_l_ver;
		private System.Windows.Forms.Label label32;
		internal System.Windows.Forms.TextBox tb_l_name;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label38;
		internal System.Windows.Forms.TextBox tb_l_1;
		internal System.Windows.Forms.TextBox tb_l_6;
		internal System.Windows.Forms.Label label39;
		internal System.Windows.Forms.TextBox tb_l_2;
		private System.Windows.Forms.Label label40;
		internal System.Windows.Forms.TextBox tb_l_3;
		private System.Windows.Forms.Label label41;
		internal System.Windows.Forms.TextBox tb_l_4;
		private System.Windows.Forms.Label label42;
		internal System.Windows.Forms.TextBox tb_l_5;
		private System.Windows.Forms.Label label43;
		internal System.Windows.Forms.TextBox tb_l_7;
		internal System.Windows.Forms.Label label44;
		internal System.Windows.Forms.TextBox tb_l_8;
		internal System.Windows.Forms.Label label45;
		internal System.Windows.Forms.TextBox tb_l_9;
		internal System.Windows.Forms.Label label46;
		internal System.Windows.Forms.TabPage tLightT;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Label label47;
		internal System.Windows.Forms.TextBox tb_lt_ver;
		private System.Windows.Forms.Label label48;
		internal System.Windows.Forms.TextBox tb_lt_name;
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
		internal System.Windows.Forms.TabPage tCres;
		internal System.Windows.Forms.TreeView cres_tv;
		internal System.Windows.Forms.PropertyGrid gen_pg;
		private System.Windows.Forms.GroupBox groupBox17;
		internal System.Windows.Forms.ComboBox cb_gn_list;
		internal System.Windows.Forms.TabControl tc_gn;
		private System.Windows.Forms.ImageList iCres;
		private System.ComponentModel.IContainer components;

		public fShapeRefNode()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			this.gen_pg.Enabled = Helper.WindowsRegistry.HiddenMode;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(fShapeRefNode));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tGenericRcol = new System.Windows.Forms.TabPage();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.gen_pg = new System.Windows.Forms.PropertyGrid();
			this.tb_ver = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.tResourceNode = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tb_rn_ver = new System.Windows.Forms.TextBox();
			this.label25 = new System.Windows.Forms.Label();
			this.tb_rn_uk2 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.tb_rn_uk1 = new System.Windows.Forms.TextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.ll_rn_add = new System.Windows.Forms.LinkLabel();
			this.tb_rn_2 = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tb_rn_1 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.lb_rn = new System.Windows.Forms.ListBox();
			this.ll_rn_delete = new System.Windows.Forms.LinkLabel();
			this.tShapeRefNode = new System.Windows.Forms.TabPage();
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
			this.tGeometryNode = new System.Windows.Forms.TabPage();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.tb_gn_ver = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.tb_gn_uk3 = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.tb_gn_uk2 = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.tb_gn_count = new System.Windows.Forms.TextBox();
			this.label36 = new System.Windows.Forms.Label();
			this.tb_gn_uk1 = new System.Windows.Forms.TextBox();
			this.label37 = new System.Windows.Forms.Label();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.tc_gn = new System.Windows.Forms.TabControl();
			this.cb_gn_list = new System.Windows.Forms.ComboBox();
			this.tTransformNode = new System.Windows.Forms.TabPage();
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
			this.tObjectGraphNode = new System.Windows.Forms.TabPage();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.tb_ogn_ver = new System.Windows.Forms.TextBox();
			this.label27 = new System.Windows.Forms.Label();
			this.tb_ogn_file = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.tb_ogn_3 = new System.Windows.Forms.TextBox();
			this.label23 = new System.Windows.Forms.Label();
			this.ll_ogn_add = new System.Windows.Forms.LinkLabel();
			this.tb_ogn_2 = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.tb_ogn_1 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.lb_ogn = new System.Windows.Forms.ListBox();
			this.ll_ogn_delete = new System.Windows.Forms.LinkLabel();
			this.tDirectionalLight = new System.Windows.Forms.TabPage();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.tb_l_9 = new System.Windows.Forms.TextBox();
			this.label46 = new System.Windows.Forms.Label();
			this.tb_l_8 = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.tb_l_7 = new System.Windows.Forms.TextBox();
			this.label44 = new System.Windows.Forms.Label();
			this.tb_l_5 = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.tb_l_4 = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.tb_l_3 = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.tb_l_2 = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.tb_l_6 = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.tb_l_1 = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.tb_l_name = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.tb_l_ver = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.tLightT = new System.Windows.Forms.TabPage();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.tb_lt_name = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.tb_lt_ver = new System.Windows.Forms.TextBox();
			this.label47 = new System.Windows.Forms.Label();
			this.tCres = new System.Windows.Forms.TabPage();
			this.cres_tv = new System.Windows.Forms.TreeView();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.iCres = new System.Windows.Forms.ImageList(this.components);
			this.tabControl1.SuspendLayout();
			this.tGenericRcol.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.tResourceNode.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.tShapeRefNode.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tGeometryNode.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.tTransformNode.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.tObjectGraphNode.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.tDirectionalLight.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.tLightT.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.tCres.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tGenericRcol);
			this.tabControl1.Controls.Add(this.tResourceNode);
			this.tabControl1.Controls.Add(this.tShapeRefNode);
			this.tabControl1.Controls.Add(this.tGeometryNode);
			this.tabControl1.Controls.Add(this.tTransformNode);
			this.tabControl1.Controls.Add(this.tObjectGraphNode);
			this.tabControl1.Controls.Add(this.tDirectionalLight);
			this.tabControl1.Controls.Add(this.tLightT);
			this.tabControl1.Controls.Add(this.tCres);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 288);
			this.tabControl1.TabIndex = 1;
			// 
			// tGenericRcol
			// 
			this.tGenericRcol.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGenericRcol.Controls.Add(this.groupBox10);
			this.tGenericRcol.Location = new System.Drawing.Point(4, 40);
			this.tGenericRcol.Name = "tGenericRcol";
			this.tGenericRcol.Size = new System.Drawing.Size(792, 244);
			this.tGenericRcol.TabIndex = 4;
			this.tGenericRcol.Text = "GenericRcol";
			// 
			// groupBox10
			// 
			this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox10.Controls.Add(this.gen_pg);
			this.groupBox10.Controls.Add(this.tb_ver);
			this.groupBox10.Controls.Add(this.label28);
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(8, 8);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(776, 232);
			this.groupBox10.TabIndex = 11;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Settings";
			// 
			// gen_pg
			// 
			this.gen_pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gen_pg.CommandsBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.gen_pg.CommandsVisibleIfAvailable = true;
			this.gen_pg.HelpVisible = false;
			this.gen_pg.LargeButtons = false;
			this.gen_pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.gen_pg.Location = new System.Drawing.Point(112, 24);
			this.gen_pg.Name = "gen_pg";
			this.gen_pg.Size = new System.Drawing.Size(656, 200);
			this.gen_pg.TabIndex = 25;
			this.gen_pg.Text = "Generic Properties";
			this.gen_pg.ToolbarVisible = false;
			this.gen_pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.gen_pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// tb_ver
			// 
			this.tb_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_ver.Name = "tb_ver";
			this.tb_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_ver.TabIndex = 24;
			this.tb_ver.Text = "0x00000000";
			this.tb_ver.TextChanged += new System.EventHandler(this.GNSettingsChange);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(8, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(52, 17);
			this.label28.TabIndex = 23;
			this.label28.Text = "Version:";
			// 
			// tResourceNode
			// 
			this.tResourceNode.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tResourceNode.Controls.Add(this.groupBox5);
			this.tResourceNode.Controls.Add(this.groupBox4);
			this.tResourceNode.Location = new System.Drawing.Point(4, 22);
			this.tResourceNode.Name = "tResourceNode";
			this.tResourceNode.Size = new System.Drawing.Size(792, 262);
			this.tResourceNode.TabIndex = 1;
			this.tResourceNode.Text = "ResourceNode";
			this.tResourceNode.Visible = false;
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox5.Controls.Add(this.tb_rn_ver);
			this.groupBox5.Controls.Add(this.label25);
			this.groupBox5.Controls.Add(this.tb_rn_uk2);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.tb_rn_uk1);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(8, 8);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(120, 248);
			this.groupBox5.TabIndex = 7;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Settings";
			// 
			// tb_rn_ver
			// 
			this.tb_rn_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_rn_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_rn_ver.Name = "tb_rn_ver";
			this.tb_rn_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_rn_ver.TabIndex = 24;
			this.tb_rn_ver.Text = "0x00000000";
			this.tb_rn_ver.TextChanged += new System.EventHandler(this.RNChangeSettings);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label25.Location = new System.Drawing.Point(8, 24);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(52, 17);
			this.label25.TabIndex = 23;
			this.label25.Text = "Version:";
			// 
			// tb_rn_uk2
			// 
			this.tb_rn_uk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_rn_uk2.Location = new System.Drawing.Point(16, 120);
			this.tb_rn_uk2.Name = "tb_rn_uk2";
			this.tb_rn_uk2.Size = new System.Drawing.Size(88, 21);
			this.tb_rn_uk2.TabIndex = 8;
			this.tb_rn_uk2.Text = "0x00000000";
			this.tb_rn_uk2.TextChanged += new System.EventHandler(this.RNChangeSettings);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(8, 104);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(73, 17);
			this.label15.TabIndex = 7;
			this.label15.Text = "Unknown 2:";
			// 
			// tb_rn_uk1
			// 
			this.tb_rn_uk1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_rn_uk1.Location = new System.Drawing.Point(16, 80);
			this.tb_rn_uk1.Name = "tb_rn_uk1";
			this.tb_rn_uk1.Size = new System.Drawing.Size(88, 21);
			this.tb_rn_uk1.TabIndex = 6;
			this.tb_rn_uk1.Text = "0x00000000";
			this.tb_rn_uk1.TextChanged += new System.EventHandler(this.RNChangeSettings);
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.Location = new System.Drawing.Point(8, 64);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(73, 17);
			this.label22.TabIndex = 5;
			this.label22.Text = "Unknown 1:";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox4.Controls.Add(this.ll_rn_add);
			this.groupBox4.Controls.Add(this.tb_rn_2);
			this.groupBox4.Controls.Add(this.label13);
			this.groupBox4.Controls.Add(this.tb_rn_1);
			this.groupBox4.Controls.Add(this.label14);
			this.groupBox4.Controls.Add(this.lb_rn);
			this.groupBox4.Controls.Add(this.ll_rn_delete);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(136, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(256, 248);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Child Nodes:";
			// 
			// ll_rn_add
			// 
			this.ll_rn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_rn_add.AutoSize = true;
			this.ll_rn_add.Location = new System.Drawing.Point(176, 96);
			this.ll_rn_add.Name = "ll_rn_add";
			this.ll_rn_add.Size = new System.Drawing.Size(28, 17);
			this.ll_rn_add.TabIndex = 6;
			this.ll_rn_add.TabStop = true;
			this.ll_rn_add.Text = "add";
			this.ll_rn_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RNItemsAdd);
			// 
			// tb_rn_2
			// 
			this.tb_rn_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_rn_2.Location = new System.Drawing.Point(160, 72);
			this.tb_rn_2.Name = "tb_rn_2";
			this.tb_rn_2.Size = new System.Drawing.Size(88, 21);
			this.tb_rn_2.TabIndex = 4;
			this.tb_rn_2.Text = "0x00000000";
			this.tb_rn_2.TextChanged += new System.EventHandler(this.RNChangedItems);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(152, 56);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(73, 17);
			this.label13.TabIndex = 3;
			this.label13.Text = "Unknown 2:";
			// 
			// tb_rn_1
			// 
			this.tb_rn_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_rn_1.Location = new System.Drawing.Point(160, 32);
			this.tb_rn_1.Name = "tb_rn_1";
			this.tb_rn_1.Size = new System.Drawing.Size(88, 21);
			this.tb_rn_1.TabIndex = 2;
			this.tb_rn_1.Text = "0x0000";
			this.tb_rn_1.TextChanged += new System.EventHandler(this.RNChangedItems);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(152, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(73, 17);
			this.label14.TabIndex = 1;
			this.label14.Text = "Unknown 1:";
			// 
			// lb_rn
			// 
			this.lb_rn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_rn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_rn.IntegralHeight = false;
			this.lb_rn.Location = new System.Drawing.Point(8, 24);
			this.lb_rn.Name = "lb_rn";
			this.lb_rn.Size = new System.Drawing.Size(136, 216);
			this.lb_rn.TabIndex = 0;
			this.lb_rn.SelectedIndexChanged += new System.EventHandler(this.RNSelect);
			// 
			// ll_rn_delete
			// 
			this.ll_rn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_rn_delete.AutoSize = true;
			this.ll_rn_delete.Location = new System.Drawing.Point(204, 96);
			this.ll_rn_delete.Name = "ll_rn_delete";
			this.ll_rn_delete.Size = new System.Drawing.Size(44, 17);
			this.ll_rn_delete.TabIndex = 5;
			this.ll_rn_delete.TabStop = true;
			this.ll_rn_delete.Text = "delete";
			this.ll_rn_delete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RNItemsDelete);
			// 
			// tShapeRefNode
			// 
			this.tShapeRefNode.BackColor = System.Drawing.Color.White;
			this.tShapeRefNode.Controls.Add(this.groupBox3);
			this.tShapeRefNode.Controls.Add(this.groupBox2);
			this.tShapeRefNode.Controls.Add(this.groupBox1);
			this.tShapeRefNode.Location = new System.Drawing.Point(4, 22);
			this.tShapeRefNode.Name = "tShapeRefNode";
			this.tShapeRefNode.Size = new System.Drawing.Size(792, 262);
			this.tShapeRefNode.TabIndex = 0;
			this.tShapeRefNode.Text = "ShapeRefNode";
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
			// tGeometryNode
			// 
			this.tGeometryNode.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGeometryNode.Controls.Add(this.groupBox11);
			this.tGeometryNode.Controls.Add(this.groupBox17);
			this.tGeometryNode.Location = new System.Drawing.Point(4, 22);
			this.tGeometryNode.Name = "tGeometryNode";
			this.tGeometryNode.Size = new System.Drawing.Size(792, 262);
			this.tGeometryNode.TabIndex = 5;
			this.tGeometryNode.Text = "GeometryNode";
			// 
			// groupBox11
			// 
			this.groupBox11.Controls.Add(this.tb_gn_ver);
			this.groupBox11.Controls.Add(this.label29);
			this.groupBox11.Controls.Add(this.tb_gn_uk3);
			this.groupBox11.Controls.Add(this.label33);
			this.groupBox11.Controls.Add(this.tb_gn_uk2);
			this.groupBox11.Controls.Add(this.label35);
			this.groupBox11.Controls.Add(this.tb_gn_count);
			this.groupBox11.Controls.Add(this.label36);
			this.groupBox11.Controls.Add(this.tb_gn_uk1);
			this.groupBox11.Controls.Add(this.label37);
			this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox11.Location = new System.Drawing.Point(8, 8);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(224, 152);
			this.groupBox11.TabIndex = 7;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Settings";
			// 
			// tb_gn_ver
			// 
			this.tb_gn_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_gn_ver.Location = new System.Drawing.Point(16, 32);
			this.tb_gn_ver.Name = "tb_gn_ver";
			this.tb_gn_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_gn_ver.TabIndex = 22;
			this.tb_gn_ver.Text = "0x00000000";
			this.tb_gn_ver.TextChanged += new System.EventHandler(this.GrNSettingsChange);
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label29.Location = new System.Drawing.Point(8, 16);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(52, 17);
			this.label29.TabIndex = 21;
			this.label29.Text = "Version:";
			// 
			// tb_gn_uk3
			// 
			this.tb_gn_uk3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_gn_uk3.Location = new System.Drawing.Point(128, 120);
			this.tb_gn_uk3.Name = "tb_gn_uk3";
			this.tb_gn_uk3.Size = new System.Drawing.Size(88, 21);
			this.tb_gn_uk3.TabIndex = 14;
			this.tb_gn_uk3.Text = "0x00";
			this.tb_gn_uk3.TextChanged += new System.EventHandler(this.GrNSettingsChange);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label33.Location = new System.Drawing.Point(120, 104);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(73, 17);
			this.label33.TabIndex = 13;
			this.label33.Text = "Unknown 3:";
			// 
			// tb_gn_uk2
			// 
			this.tb_gn_uk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_gn_uk2.Location = new System.Drawing.Point(128, 72);
			this.tb_gn_uk2.Name = "tb_gn_uk2";
			this.tb_gn_uk2.Size = new System.Drawing.Size(88, 21);
			this.tb_gn_uk2.TabIndex = 10;
			this.tb_gn_uk2.Text = "0x0000";
			this.tb_gn_uk2.TextChanged += new System.EventHandler(this.GrNSettingsChange);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label35.Location = new System.Drawing.Point(120, 56);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(73, 17);
			this.label35.TabIndex = 9;
			this.label35.Text = "Unknown 2:";
			// 
			// tb_gn_count
			// 
			this.tb_gn_count.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_gn_count.Location = new System.Drawing.Point(16, 120);
			this.tb_gn_count.Name = "tb_gn_count";
			this.tb_gn_count.ReadOnly = true;
			this.tb_gn_count.Size = new System.Drawing.Size(88, 21);
			this.tb_gn_count.TabIndex = 8;
			this.tb_gn_count.Text = "0x00000000";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label36.Location = new System.Drawing.Point(8, 104);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(43, 17);
			this.label36.TabIndex = 7;
			this.label36.Text = "Count:";
			// 
			// tb_gn_uk1
			// 
			this.tb_gn_uk1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_gn_uk1.Location = new System.Drawing.Point(16, 72);
			this.tb_gn_uk1.Name = "tb_gn_uk1";
			this.tb_gn_uk1.Size = new System.Drawing.Size(88, 21);
			this.tb_gn_uk1.TabIndex = 6;
			this.tb_gn_uk1.Text = "0x0000";
			this.tb_gn_uk1.TextChanged += new System.EventHandler(this.GrNSettingsChange);
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label37.Location = new System.Drawing.Point(8, 56);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(73, 17);
			this.label37.TabIndex = 5;
			this.label37.Text = "Unknown 1:";
			// 
			// groupBox17
			// 
			this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox17.Controls.Add(this.tc_gn);
			this.groupBox17.Controls.Add(this.cb_gn_list);
			this.groupBox17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox17.Location = new System.Drawing.Point(240, 8);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(544, 250);
			this.groupBox17.TabIndex = 23;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Embedded Blocks:";
			// 
			// tc_gn
			// 
			this.tc_gn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tc_gn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tc_gn.Location = new System.Drawing.Point(8, 56);
			this.tc_gn.Name = "tc_gn";
			this.tc_gn.SelectedIndex = 0;
			this.tc_gn.Size = new System.Drawing.Size(528, 186);
			this.tc_gn.TabIndex = 10;
			// 
			// cb_gn_list
			// 
			this.cb_gn_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cb_gn_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_gn_list.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cb_gn_list.Location = new System.Drawing.Point(8, 24);
			this.cb_gn_list.Name = "cb_gn_list";
			this.cb_gn_list.Size = new System.Drawing.Size(528, 21);
			this.cb_gn_list.TabIndex = 9;
			this.cb_gn_list.SelectedIndexChanged += new System.EventHandler(this.SelectGmndChildBlock);
			// 
			// tTransformNode
			// 
			this.tTransformNode.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tTransformNode.Controls.Add(this.groupBox7);
			this.tTransformNode.Controls.Add(this.groupBox6);
			this.tTransformNode.Controls.Add(this.groupBox15);
			this.tTransformNode.Controls.Add(this.groupBox16);
			this.tTransformNode.Controls.Add(this.groupBox12);
			this.tTransformNode.Location = new System.Drawing.Point(4, 22);
			this.tTransformNode.Name = "tTransformNode";
			this.tTransformNode.Size = new System.Drawing.Size(792, 262);
			this.tTransformNode.TabIndex = 2;
			this.tTransformNode.Text = "TransformNode";
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
			this.groupBox6.Location = new System.Drawing.Point(464, 8);
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
			this.groupBox15.Location = new System.Drawing.Point(8, 88);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(144, 104);
			this.groupBox15.TabIndex = 25;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Translation:";
			// 
			// tb_tn_tz
			// 
			this.tb_tn_tz.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_tz.Location = new System.Drawing.Point(40, 72);
			this.tb_tn_tz.Name = "tb_tn_tz";
			this.tb_tn_tz.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_ty.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_tx.Size = new System.Drawing.Size(88, 21);
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
			this.groupBox16.Location = new System.Drawing.Point(160, 88);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(144, 128);
			this.groupBox16.TabIndex = 26;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Quaternion:";
			// 
			// tb_tn_rw
			// 
			this.tb_tn_rw.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_rw.Location = new System.Drawing.Point(40, 96);
			this.tb_tn_rw.Name = "tb_tn_rw";
			this.tb_tn_rw.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_rz.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_ry.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_rx.Size = new System.Drawing.Size(88, 21);
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
			this.groupBox12.Location = new System.Drawing.Point(312, 88);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(144, 128);
			this.groupBox12.TabIndex = 41;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Rotation:";
			// 
			// tb_tn_a
			// 
			this.tb_tn_a.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_tn_a.Location = new System.Drawing.Point(64, 96);
			this.tb_tn_a.Name = "tb_tn_a";
			this.tb_tn_a.Size = new System.Drawing.Size(64, 21);
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
			this.tb_tn_az.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_ay.Size = new System.Drawing.Size(88, 21);
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
			this.tb_tn_ax.Size = new System.Drawing.Size(88, 21);
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
			// tObjectGraphNode
			// 
			this.tObjectGraphNode.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tObjectGraphNode.Controls.Add(this.groupBox8);
			this.tObjectGraphNode.Controls.Add(this.groupBox9);
			this.tObjectGraphNode.Location = new System.Drawing.Point(4, 22);
			this.tObjectGraphNode.Name = "tObjectGraphNode";
			this.tObjectGraphNode.Size = new System.Drawing.Size(792, 262);
			this.tObjectGraphNode.TabIndex = 3;
			this.tObjectGraphNode.Text = "ObjectGraphNode";
			// 
			// groupBox8
			// 
			this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox8.Controls.Add(this.tb_ogn_ver);
			this.groupBox8.Controls.Add(this.label27);
			this.groupBox8.Controls.Add(this.tb_ogn_file);
			this.groupBox8.Controls.Add(this.label18);
			this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox8.Location = new System.Drawing.Point(8, 7);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(512, 113);
			this.groupBox8.TabIndex = 10;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Settings";
			// 
			// tb_ogn_ver
			// 
			this.tb_ogn_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ogn_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_ogn_ver.Name = "tb_ogn_ver";
			this.tb_ogn_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_ogn_ver.TabIndex = 24;
			this.tb_ogn_ver.Text = "0x00000000";
			this.tb_ogn_ver.TextChanged += new System.EventHandler(this.OGNChangeSettings);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label27.Location = new System.Drawing.Point(8, 24);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(52, 17);
			this.label27.TabIndex = 23;
			this.label27.Text = "Version:";
			// 
			// tb_ogn_file
			// 
			this.tb_ogn_file.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_ogn_file.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ogn_file.Location = new System.Drawing.Point(16, 80);
			this.tb_ogn_file.Name = "tb_ogn_file";
			this.tb_ogn_file.Size = new System.Drawing.Size(480, 21);
			this.tb_ogn_file.TabIndex = 20;
			this.tb_ogn_file.Text = "0x0000";
			this.tb_ogn_file.TextChanged += new System.EventHandler(this.OGNChangeSettings);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(8, 64);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(61, 17);
			this.label18.TabIndex = 19;
			this.label18.Text = "Filename:";
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.tb_ogn_3);
			this.groupBox9.Controls.Add(this.label23);
			this.groupBox9.Controls.Add(this.ll_ogn_add);
			this.groupBox9.Controls.Add(this.tb_ogn_2);
			this.groupBox9.Controls.Add(this.label20);
			this.groupBox9.Controls.Add(this.tb_ogn_1);
			this.groupBox9.Controls.Add(this.label21);
			this.groupBox9.Controls.Add(this.lb_ogn);
			this.groupBox9.Controls.Add(this.ll_ogn_delete);
			this.groupBox9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox9.Location = new System.Drawing.Point(528, 8);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(256, 248);
			this.groupBox9.TabIndex = 9;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Datalist Extension Reference";
			// 
			// tb_ogn_3
			// 
			this.tb_ogn_3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ogn_3.Location = new System.Drawing.Point(160, 112);
			this.tb_ogn_3.Name = "tb_ogn_3";
			this.tb_ogn_3.Size = new System.Drawing.Size(88, 21);
			this.tb_ogn_3.TabIndex = 8;
			this.tb_ogn_3.Text = "0x00000000";
			this.toolTip1.SetToolTip(this.tb_ogn_3, "Index of the DataList Extenion in the current Blocklist");
			this.tb_ogn_3.TextChanged += new System.EventHandler(this.OGNChangedItems);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label23.Location = new System.Drawing.Point(152, 96);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(42, 17);
			this.label23.TabIndex = 7;
			this.label23.Text = "Index:";
			// 
			// ll_ogn_add
			// 
			this.ll_ogn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_ogn_add.AutoSize = true;
			this.ll_ogn_add.Location = new System.Drawing.Point(176, 136);
			this.ll_ogn_add.Name = "ll_ogn_add";
			this.ll_ogn_add.Size = new System.Drawing.Size(28, 17);
			this.ll_ogn_add.TabIndex = 6;
			this.ll_ogn_add.TabStop = true;
			this.ll_ogn_add.Text = "add";
			this.ll_ogn_add.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OGNItemsAdd);
			// 
			// tb_ogn_2
			// 
			this.tb_ogn_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ogn_2.Location = new System.Drawing.Point(160, 72);
			this.tb_ogn_2.Name = "tb_ogn_2";
			this.tb_ogn_2.Size = new System.Drawing.Size(88, 21);
			this.tb_ogn_2.TabIndex = 4;
			this.tb_ogn_2.Text = "0x00";
			this.toolTip1.SetToolTip(this.tb_ogn_2, "0x00=Independant DatListExtension, 0x01=DataListExtension depends on anthoer RCOL" +
				"");
			this.tb_ogn_2.TextChanged += new System.EventHandler(this.OGNChangedItems);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(152, 56);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(71, 17);
			this.label20.TabIndex = 3;
			this.label20.Text = "Dependant:";
			// 
			// tb_ogn_1
			// 
			this.tb_ogn_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ogn_1.Location = new System.Drawing.Point(160, 32);
			this.tb_ogn_1.Name = "tb_ogn_1";
			this.tb_ogn_1.Size = new System.Drawing.Size(88, 21);
			this.tb_ogn_1.TabIndex = 2;
			this.tb_ogn_1.Text = "0x00";
			this.toolTip1.SetToolTip(this.tb_ogn_1, "0x01=Enabled");
			this.tb_ogn_1.TextChanged += new System.EventHandler(this.OGNChangedItems);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(152, 16);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(54, 17);
			this.label21.TabIndex = 1;
			this.label21.Text = "Enabled:";
			// 
			// lb_ogn
			// 
			this.lb_ogn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_ogn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_ogn.IntegralHeight = false;
			this.lb_ogn.Location = new System.Drawing.Point(8, 24);
			this.lb_ogn.Name = "lb_ogn";
			this.lb_ogn.Size = new System.Drawing.Size(136, 216);
			this.lb_ogn.TabIndex = 0;
			this.lb_ogn.SelectedIndexChanged += new System.EventHandler(this.OGNSelect);
			// 
			// ll_ogn_delete
			// 
			this.ll_ogn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ll_ogn_delete.AutoSize = true;
			this.ll_ogn_delete.Location = new System.Drawing.Point(204, 136);
			this.ll_ogn_delete.Name = "ll_ogn_delete";
			this.ll_ogn_delete.Size = new System.Drawing.Size(44, 17);
			this.ll_ogn_delete.TabIndex = 5;
			this.ll_ogn_delete.TabStop = true;
			this.ll_ogn_delete.Text = "delete";
			this.ll_ogn_delete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OGNItemsDelete);
			// 
			// tDirectionalLight
			// 
			this.tDirectionalLight.BackColor = System.Drawing.Color.White;
			this.tDirectionalLight.Controls.Add(this.groupBox13);
			this.tDirectionalLight.Location = new System.Drawing.Point(4, 22);
			this.tDirectionalLight.Name = "tDirectionalLight";
			this.tDirectionalLight.Size = new System.Drawing.Size(792, 262);
			this.tDirectionalLight.TabIndex = 7;
			this.tDirectionalLight.Text = "DirectionalLight";
			// 
			// groupBox13
			// 
			this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox13.Controls.Add(this.tb_l_9);
			this.groupBox13.Controls.Add(this.label46);
			this.groupBox13.Controls.Add(this.tb_l_8);
			this.groupBox13.Controls.Add(this.label45);
			this.groupBox13.Controls.Add(this.tb_l_7);
			this.groupBox13.Controls.Add(this.label44);
			this.groupBox13.Controls.Add(this.tb_l_5);
			this.groupBox13.Controls.Add(this.label43);
			this.groupBox13.Controls.Add(this.tb_l_4);
			this.groupBox13.Controls.Add(this.label42);
			this.groupBox13.Controls.Add(this.tb_l_3);
			this.groupBox13.Controls.Add(this.label41);
			this.groupBox13.Controls.Add(this.tb_l_2);
			this.groupBox13.Controls.Add(this.label40);
			this.groupBox13.Controls.Add(this.tb_l_6);
			this.groupBox13.Controls.Add(this.label39);
			this.groupBox13.Controls.Add(this.tb_l_1);
			this.groupBox13.Controls.Add(this.label38);
			this.groupBox13.Controls.Add(this.tb_l_name);
			this.groupBox13.Controls.Add(this.label34);
			this.groupBox13.Controls.Add(this.tb_l_ver);
			this.groupBox13.Controls.Add(this.label32);
			this.groupBox13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox13.Location = new System.Drawing.Point(8, 8);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(776, 176);
			this.groupBox13.TabIndex = 12;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Settings";
			// 
			// tb_l_9
			// 
			this.tb_l_9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_9.Location = new System.Drawing.Point(528, 144);
			this.tb_l_9.Name = "tb_l_9";
			this.tb_l_9.Size = new System.Drawing.Size(66, 21);
			this.tb_l_9.TabIndex = 44;
			this.tb_l_9.Text = "0";
			this.tb_l_9.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label46.Location = new System.Drawing.Point(488, 152);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(34, 17);
			this.label46.TabIndex = 43;
			this.label46.Text = "Val9:";
			// 
			// tb_l_8
			// 
			this.tb_l_8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_8.Location = new System.Drawing.Point(408, 144);
			this.tb_l_8.Name = "tb_l_8";
			this.tb_l_8.Size = new System.Drawing.Size(66, 21);
			this.tb_l_8.TabIndex = 42;
			this.tb_l_8.Text = "0";
			this.tb_l_8.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label45.Location = new System.Drawing.Point(368, 152);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(34, 17);
			this.label45.TabIndex = 41;
			this.label45.Text = "Val8:";
			// 
			// tb_l_7
			// 
			this.tb_l_7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_7.Location = new System.Drawing.Point(168, 144);
			this.tb_l_7.Name = "tb_l_7";
			this.tb_l_7.Size = new System.Drawing.Size(66, 21);
			this.tb_l_7.TabIndex = 40;
			this.tb_l_7.Text = "0";
			this.tb_l_7.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label44.Location = new System.Drawing.Point(128, 152);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(34, 17);
			this.label44.TabIndex = 39;
			this.label44.Text = "Val7:";
			// 
			// tb_l_5
			// 
			this.tb_l_5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_5.Location = new System.Drawing.Point(528, 120);
			this.tb_l_5.Name = "tb_l_5";
			this.tb_l_5.Size = new System.Drawing.Size(66, 21);
			this.tb_l_5.TabIndex = 38;
			this.tb_l_5.Text = "0";
			this.tb_l_5.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label43.Location = new System.Drawing.Point(488, 128);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(34, 17);
			this.label43.TabIndex = 37;
			this.label43.Text = "Val5:";
			// 
			// tb_l_4
			// 
			this.tb_l_4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_4.Location = new System.Drawing.Point(408, 120);
			this.tb_l_4.Name = "tb_l_4";
			this.tb_l_4.Size = new System.Drawing.Size(66, 21);
			this.tb_l_4.TabIndex = 36;
			this.tb_l_4.Text = "0";
			this.tb_l_4.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label42.Location = new System.Drawing.Point(368, 128);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(34, 17);
			this.label42.TabIndex = 35;
			this.label42.Text = "Val4:";
			// 
			// tb_l_3
			// 
			this.tb_l_3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_3.Location = new System.Drawing.Point(288, 120);
			this.tb_l_3.Name = "tb_l_3";
			this.tb_l_3.Size = new System.Drawing.Size(66, 21);
			this.tb_l_3.TabIndex = 34;
			this.tb_l_3.Text = "0";
			this.tb_l_3.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label41.Location = new System.Drawing.Point(248, 128);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(34, 17);
			this.label41.TabIndex = 33;
			this.label41.Text = "Val3:";
			// 
			// tb_l_2
			// 
			this.tb_l_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_2.Location = new System.Drawing.Point(168, 120);
			this.tb_l_2.Name = "tb_l_2";
			this.tb_l_2.Size = new System.Drawing.Size(66, 21);
			this.tb_l_2.TabIndex = 32;
			this.tb_l_2.Text = "0";
			this.tb_l_2.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label40.Location = new System.Drawing.Point(128, 128);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(34, 17);
			this.label40.TabIndex = 31;
			this.label40.Text = "Val2:";
			// 
			// tb_l_6
			// 
			this.tb_l_6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_6.Location = new System.Drawing.Point(48, 144);
			this.tb_l_6.Name = "tb_l_6";
			this.tb_l_6.Size = new System.Drawing.Size(66, 21);
			this.tb_l_6.TabIndex = 30;
			this.tb_l_6.Text = "0";
			this.tb_l_6.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label39.Location = new System.Drawing.Point(8, 152);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(34, 17);
			this.label39.TabIndex = 29;
			this.label39.Text = "Val6:";
			// 
			// tb_l_1
			// 
			this.tb_l_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_1.Location = new System.Drawing.Point(48, 120);
			this.tb_l_1.Name = "tb_l_1";
			this.tb_l_1.Size = new System.Drawing.Size(66, 21);
			this.tb_l_1.TabIndex = 28;
			this.tb_l_1.Text = "0";
			this.tb_l_1.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label38.Location = new System.Drawing.Point(8, 128);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(34, 17);
			this.label38.TabIndex = 27;
			this.label38.Text = "Val1:";
			// 
			// tb_l_name
			// 
			this.tb_l_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_l_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_name.Location = new System.Drawing.Point(16, 88);
			this.tb_l_name.Name = "tb_l_name";
			this.tb_l_name.Size = new System.Drawing.Size(752, 21);
			this.tb_l_name.TabIndex = 26;
			this.tb_l_name.Text = "";
			this.tb_l_name.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.Location = new System.Drawing.Point(8, 72);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(42, 17);
			this.label34.TabIndex = 25;
			this.label34.Text = "Name:";
			// 
			// tb_l_ver
			// 
			this.tb_l_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_l_ver.Name = "tb_l_ver";
			this.tb_l_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_l_ver.TabIndex = 24;
			this.tb_l_ver.Text = "0x00000000";
			this.tb_l_ver.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.Location = new System.Drawing.Point(8, 24);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(52, 17);
			this.label32.TabIndex = 23;
			this.label32.Text = "Version:";
			// 
			// tLightT
			// 
			this.tLightT.BackColor = System.Drawing.Color.White;
			this.tLightT.Controls.Add(this.groupBox14);
			this.tLightT.Location = new System.Drawing.Point(4, 22);
			this.tLightT.Name = "tLightT";
			this.tLightT.Size = new System.Drawing.Size(792, 262);
			this.tLightT.TabIndex = 8;
			this.tLightT.Text = "LightT";
			// 
			// groupBox14
			// 
			this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox14.Controls.Add(this.tb_lt_name);
			this.groupBox14.Controls.Add(this.label48);
			this.groupBox14.Controls.Add(this.tb_lt_ver);
			this.groupBox14.Controls.Add(this.label47);
			this.groupBox14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox14.Location = new System.Drawing.Point(8, 8);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(776, 128);
			this.groupBox14.TabIndex = 12;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Settings";
			// 
			// tb_lt_name
			// 
			this.tb_lt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_lt_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_lt_name.Location = new System.Drawing.Point(16, 88);
			this.tb_lt_name.Name = "tb_lt_name";
			this.tb_lt_name.Size = new System.Drawing.Size(752, 21);
			this.tb_lt_name.TabIndex = 26;
			this.tb_lt_name.Text = "";
			this.tb_lt_name.TextChanged += new System.EventHandler(this.LTSettingsChanged);
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label48.Location = new System.Drawing.Point(8, 72);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(42, 17);
			this.label48.TabIndex = 25;
			this.label48.Text = "Name:";
			// 
			// tb_lt_ver
			// 
			this.tb_lt_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_lt_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_lt_ver.Name = "tb_lt_ver";
			this.tb_lt_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_lt_ver.TabIndex = 24;
			this.tb_lt_ver.Text = "0x00000000";
			this.tb_lt_ver.TextChanged += new System.EventHandler(this.LTSettingsChanged);
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label47.Location = new System.Drawing.Point(8, 24);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(52, 17);
			this.label47.TabIndex = 23;
			this.label47.Text = "Version:";
			// 
			// tCres
			// 
			this.tCres.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tCres.Controls.Add(this.cres_tv);
			this.tCres.Location = new System.Drawing.Point(4, 40);
			this.tCres.Name = "tCres";
			this.tCres.Size = new System.Drawing.Size(792, 244);
			this.tCres.TabIndex = 9;
			this.tCres.Text = "CRES Hirachy";
			// 
			// cres_tv
			// 
			this.cres_tv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cres_tv.FullRowSelect = true;
			this.cres_tv.HideSelection = false;
			this.cres_tv.ImageList = this.iCres;
			this.cres_tv.Location = new System.Drawing.Point(8, 8);
			this.cres_tv.Name = "cres_tv";
			this.cres_tv.Size = new System.Drawing.Size(776, 232);
			this.cres_tv.TabIndex = 0;
			this.cres_tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectCresTv);
			// 
			// iCres
			// 
			this.iCres.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.iCres.ImageSize = new System.Drawing.Size(16, 16);
			this.iCres.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iCres.ImageStream")));
			this.iCres.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// fShapeRefNode
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(848, 302);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "fShapeRefNode";
			this.Text = "fShapeRefNode";
			this.tabControl1.ResumeLayout(false);
			this.tGenericRcol.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.tResourceNode.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.tShapeRefNode.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tGeometryNode.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.tTransformNode.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.tObjectGraphNode.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.tDirectionalLight.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.tLightT.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.tCres.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SRNChangeSettings(object sender, System.EventArgs e)
		{
			if (tShapeRefNode.Tag==null) return;
			try 
			{
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;

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

				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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

				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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
			if (tShapeRefNode.Tag==null) return;
			try 
			{
				lb_srn_a.Tag = true;
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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
			if (tShapeRefNode.Tag==null) return;
			if (lb_srn_a.SelectedIndex<0) return;
			try 
			{
				lb_srn_a.Tag = true;
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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

				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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
			if (tShapeRefNode.Tag==null) return;
			try 
			{
				lb_srn_b.Tag = true;
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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
			if (tShapeRefNode.Tag==null) return;
			if (lb_srn_b.SelectedIndex<0) return;
			try 
			{
				lb_srn_b.Tag = true;
				ShapeRefNode srn = (ShapeRefNode)tShapeRefNode.Tag;
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

		private void RNChangeSettings(object sender, System.EventArgs e)
		{
			if (tResourceNode.Tag==null) return;
			try 
			{
				ResourceNode rn = (ResourceNode)tResourceNode.Tag;

				rn.Unknown1 = (int)Convert.ToInt32(this.tb_rn_uk1.Text, 16);
				rn.Unknown2 = (int)Convert.ToInt32(this.tb_rn_uk2.Text, 16);
				rn.Version = Convert.ToUInt32(tb_rn_ver.Text, 16);

				rn.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		#region Select RN Items 
		private void RNSelect(object sender, System.EventArgs e)
		{
			if (lb_rn.Tag != null) return;
			if (this.lb_rn.SelectedIndex<0) return;

			try 
			{
				lb_rn.Tag = true;
				ResourceNode rn = (ResourceNode)tResourceNode.Tag;
				ResourceNodeItem b = (ResourceNodeItem)lb_rn.Items[lb_rn.SelectedIndex];

				tb_rn_1.Text = "0x"+Helper.HexString((ushort)b.Unknown1);
				tb_rn_2.Text = "0x"+Helper.HexString((uint)b.Unknown2);
				rn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_rn.Tag = null;
			}
		}

		private void RNChangedItems(object sender, System.EventArgs e)
		{
			if (lb_rn.Tag != null) return;
			if (this.lb_rn.SelectedIndex<0) return;

			try 
			{
				lb_rn.Tag = true;
				ResourceNode rn = (ResourceNode)tResourceNode.Tag;
				ResourceNodeItem b = (ResourceNodeItem)lb_rn.Items[lb_rn.SelectedIndex];

				b.Unknown1 = (short)Convert.ToUInt16(tb_rn_1.Text, 16);
				b.Unknown2 = (int)Convert.ToUInt32(tb_rn_2.Text, 16);

				lb_rn.Items[lb_rn.SelectedIndex] = b;
				rn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_rn.Tag = null;
			}
		}

		private void RNItemsAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tResourceNode.Tag==null) return;
			try 
			{
				lb_rn.Tag = true;
				ResourceNode rn = (ResourceNode)tResourceNode.Tag;
				ResourceNodeItem b = new ResourceNodeItem();

				b.Unknown1 = (short)Convert.ToUInt16(tb_rn_1.Text, 16);
				b.Unknown2 = (int)Convert.ToUInt32(tb_rn_2.Text, 16);

				rn.Items = (ResourceNodeItem[])Helper.Add(rn.Items, b);
				lb_rn.Items.Add(b);
				rn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_rn.Tag = null;
			}
		}

		private void RNItemsDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tResourceNode.Tag==null) return;
			if (lb_rn.SelectedIndex<0) return;
			try 
			{
				lb_rn.Tag = true;
				ResourceNode rn = (ResourceNode)tResourceNode.Tag;
				ResourceNodeItem b = (ResourceNodeItem)lb_rn.Items[lb_rn.SelectedIndex];

				rn.Items = (ResourceNodeItem[])Helper.Delete(rn.Items, b);
				lb_rn.Items.Remove(b);
				rn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_rn.Tag = null;
			}
		}
		#endregion

		private void TNChangeSettings(object sender, System.EventArgs e)
		{
			if (this.tb_tn_a.Tag!=null) return;
			if (tTransformNode.Tag==null) return;
			try 
			{
				TransformNode tn = (TransformNode)tTransformNode.Tag;

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
				this.tb_tn_a.Tag = true;
				try 
				{
					this.tb_tn_ax.Text = q.Axis.X.ToString("N6");
					this.tb_tn_ay.Text = q.Axis.Y.ToString("N6");
					this.tb_tn_az.Text = q.Axis.Z.ToString("N6");
					this.tb_tn_a.Text = SimPe.Geometry.Quaternion.RadToDeg(q.Angle).ToString("N6");
				} 
				finally 
				{
					this.tb_tn_a.Tag = null;
				}
				
				tn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
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
				TransformNode tn = (TransformNode)tTransformNode.Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				tb_tn_1.Text = "0x"+Helper.HexString((ushort)b.Unknown1);
				tb_tn_2.Text = "0x"+Helper.HexString((uint)b.Unknown2);
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
				TransformNode tn = (TransformNode)tTransformNode.Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				b.Unknown1 = Convert.ToUInt16(tb_tn_1.Text, 16);
				b.Unknown2 = (int)Convert.ToUInt32(tb_tn_2.Text, 16);

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
			if (tTransformNode.Tag==null) return;
			try 
			{
				lb_tn.Tag = true;
				TransformNode tn = (TransformNode)tTransformNode.Tag;
				TransformNodeItem b = new TransformNodeItem();

				b.Unknown1 = Convert.ToUInt16(tb_tn_1.Text, 16);
				b.Unknown2 = (int)Convert.ToUInt32(tb_tn_2.Text, 16);

				tn.Items = (TransformNodeItem[])Helper.Add(tn.Items, b);
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
			if (tTransformNode.Tag==null) return;
			if (lb_tn.SelectedIndex<0) return;
			try 
			{
				lb_tn.Tag = true;
				TransformNode tn = (TransformNode)tTransformNode.Tag;
				TransformNodeItem b = (TransformNodeItem)lb_tn.Items[lb_tn.SelectedIndex];

				tn.Items = (TransformNodeItem[])Helper.Delete(tn.Items, b);
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

		private void OGNChangeSettings(object sender, System.EventArgs e)
		{
			if (tObjectGraphNode.Tag==null) return;
			try 
			{
				ObjectGraphNode ogn = (ObjectGraphNode)tObjectGraphNode.Tag;

				ogn.FileName = tb_ogn_file.Text;
				ogn.Version = Convert.ToUInt32(tb_ogn_ver.Text, 16);
				ogn.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		#region Select OGN Items 
		private void OGNSelect(object sender, System.EventArgs e)
		{
			if (lb_ogn.Tag != null) return;
			if (this.lb_ogn.SelectedIndex<0) return;

			try 
			{
				lb_ogn.Tag = true;
				ObjectGraphNode ogn = (ObjectGraphNode)tObjectGraphNode.Tag;
				ObjectGraphNodeItem b = (ObjectGraphNodeItem)lb_ogn.Items[lb_ogn.SelectedIndex];

				tb_ogn_1.Text = "0x"+Helper.HexString(b.Enabled);
				tb_ogn_2.Text = "0x"+Helper.HexString(b.Dependant);
				tb_ogn_3.Text = "0x"+Helper.HexString(b.Index);
				ogn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_ogn.Tag = null;
			}
		}

		private void OGNChangedItems(object sender, System.EventArgs e)
		{
			if (lb_ogn.Tag != null) return;
			if (this.lb_ogn.SelectedIndex<0) return;

			try 
			{
				lb_ogn.Tag = true;
				ObjectGraphNode ogn = (ObjectGraphNode)tObjectGraphNode.Tag;
				ObjectGraphNodeItem b = (ObjectGraphNodeItem)lb_ogn.Items[lb_ogn.SelectedIndex];

				b.Enabled = Convert.ToByte(tb_ogn_1.Text, 16);
				b.Dependant = Convert.ToByte(tb_ogn_2.Text, 16);
				b.Index = Convert.ToUInt32(tb_ogn_3.Text, 16);

				lb_ogn.Items[lb_ogn.SelectedIndex] = b;
				ogn.Changed = true;
			}
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_ogn.Tag = null;
			}
		}

		private void OGNItemsAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tObjectGraphNode.Tag==null) return;
			try 
			{
				lb_ogn.Tag = true;
				ObjectGraphNode ogn = (ObjectGraphNode)tObjectGraphNode.Tag;
				ObjectGraphNodeItem b = new ObjectGraphNodeItem();

				tb_ogn_1.Text = "0x"+Helper.HexString(b.Enabled);
				tb_ogn_2.Text = "0x"+Helper.HexString(b.Dependant);
				tb_ogn_3.Text = "0x"+Helper.HexString(b.Index);

				ogn.Items = (ObjectGraphNodeItem[])Helper.Add(ogn.Items, b);
				lb_ogn.Items.Add(b);
				ogn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_ogn.Tag = null;
			}
		}

		private void OGNItemsDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tObjectGraphNode.Tag==null) return;
			if (lb_ogn.SelectedIndex<0) return;
			try 
			{
				lb_ogn.Tag = true;
				ObjectGraphNode ogn = (ObjectGraphNode)tObjectGraphNode.Tag;
				ObjectGraphNodeItem b = (ObjectGraphNodeItem)lb_ogn.Items[lb_ogn.SelectedIndex];

				ogn.Items = (ObjectGraphNodeItem[])Helper.Delete(ogn.Items, b);
				lb_ogn.Items.Remove(b);
				ogn.Changed = true;
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				lb_ogn.Tag = null;
			}
		}
		#endregion

		private void GNSettingsChange(object sender, System.EventArgs e)
		{
			if (this.tGenericRcol.Tag==null) return;
			try 
			{
				AbstractRcolBlock arb = (AbstractRcolBlock)tGenericRcol.Tag;

				arb.Version = Convert.ToUInt32(tb_ver.Text, 16);
				arb.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		private void GrNSettingsChange(object sender, System.EventArgs e)
		{
			if (this.tGeometryNode.Tag==null) return;
			try 
			{
				GeometryNode arb = (GeometryNode)tGeometryNode.Tag;

				arb.Version = Convert.ToUInt32(tb_gn_ver.Text, 16);
				arb.Unknown1 = (short)Convert.ToUInt16(tb_gn_uk1.Text, 16);
				arb.Unknown2 = (short)Convert.ToUInt16(tb_gn_uk2.Text, 16);
				arb.Unknown3 = Convert.ToByte(tb_gn_uk3.Text, 16);

				arb.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}		

		private void LSettingsChanged(object sender, System.EventArgs e)
		{
			if (this.tDirectionalLight.Tag==null) return;
			try 
			{
				DirectionalLight dl = (DirectionalLight)tDirectionalLight.Tag;

				dl.Version = Convert.ToUInt32(tb_l_ver.Text, 16);
				dl.Name = tb_l_name.Text;
				dl.Val1 = Convert.ToSingle(tb_l_1.Text);
				dl.Val2 = Convert.ToSingle(tb_l_2.Text);
				dl.Val3 = Convert.ToSingle(tb_l_3.Text);
				dl.Val4 = Convert.ToSingle(tb_l_4.Text);
				dl.Val5 = Convert.ToSingle(tb_l_5.Text);

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

		private void TNChangedQuaternion(object sender, System.EventArgs e)
		{
			if (this.tb_tn_a.Tag!=null) return;
			if (tTransformNode.Tag==null) return;
			try 
			{
				TransformNode tn = (TransformNode)tTransformNode.Tag;
				SimPe.Geometry.Quaternion q = new SimPe.Geometry.Quaternion(
					SimPe.Geometry.QuaternionParameterType.UnitAxisAngle, 
					new SimPe.Geometry.Vector3f(
					    Convert.ToSingle(tb_tn_ax.Text),
					    Convert.ToSingle(tb_tn_ay.Text),
					    Convert.ToSingle(tb_tn_az.Text)), 
					SimPe.Geometry.Quaternion.DegToRad(Convert.ToSingle(tb_tn_a.Text)));
			
				tn.Rotation = q;

				//set Angles
				this.tb_tn_a.Tag = true;
				this.tb_tn_rx.Text = q.X.ToString("N6");
				this.tb_tn_ry.Text = q.Y.ToString("N6");
				this.tb_tn_rz.Text = q.Z.ToString("N6");
				this.tb_tn_rw.Text = q.W.ToString("N6");
			} 
			catch {}
			finally 
			{
				this.tb_tn_a.Tag = null;
			}
		}

		private void SelectCresTv(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;

			int index = (int)e.Node.Tag;
			if (index<0) return;

			ComboBox cb = (ComboBox)(((TabControl)tCres.Parent).Tag);
			cb.SelectedIndex = index;
			((TabControl)tCres.Parent).SelectedIndex = 0;
		}

		internal void BuildChildTabControl(AbstractRcolBlock rb)
		{
			this.tc_gn.TabPages.Clear();

			if (rb==null) return;
			if (rb.TabPage!=null) rb.AddToTabControl(tc_gn);
		}

		private void SelectGmndChildBlock(object sender, System.EventArgs e)
		{
			
			if (this.cb_gn_list.Tag!=null) return;
			if (cb_gn_list.SelectedIndex<0) return;
			try 
			{
				cb_gn_list.Tag = true;
				SimPe.CountedListItem cli = (SimPe.CountedListItem)cb_gn_list.Items[cb_gn_list.SelectedIndex];
				AbstractRcolBlock rb = (AbstractRcolBlock)cli.Object;
				
				
				BuildChildTabControl(rb);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally
			{
				cb_gn_list.Tag = null;
			}
		}
		


	}
}
