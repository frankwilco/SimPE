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
using System.IO;
using System.Globalization;
using SimPe.Plugin.Gmdc;
using SimPe.Geometry;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für fGeometryDataContainer.
	/// </summary>
	internal class fGeometryDataContainer : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.GroupBox groupBox10;
		internal System.Windows.Forms.TextBox tb_ver;
		private System.Windows.Forms.Label label28;
		internal System.Windows.Forms.TabPage tGeometryDataContainer;
		private System.Windows.Forms.GroupBox groupBox3;
		internal System.Windows.Forms.TextBox tb_uk5;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.TextBox tb_uk1;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.ListBox lb_itemsa;
		internal System.Windows.Forms.TextBox tb_mod2;
		internal System.Windows.Forms.TextBox tb_mod1;
		internal System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.GroupBox groupBox1;
		internal System.Windows.Forms.ListBox lb_itemsa2;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox tb_itemsa2;
		internal System.Windows.Forms.TabPage tGeometryDataContainer2;
		internal System.Windows.Forms.TabPage tGeometryDataContainer3;
		private System.Windows.Forms.GroupBox groupBox2;
		internal System.Windows.Forms.ListBox lb_itemsc;
		internal System.Windows.Forms.TextBox tb_itemsc_name;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tb_opacity;
		private System.Windows.Forms.Label label13;
		internal System.Windows.Forms.TextBox tb_uk3;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox tb_uk2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.ListBox lb_itemsc2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label9;
		internal System.Windows.Forms.ListBox lb_itemsc3;
		internal System.Windows.Forms.TextBox tb_itemsc2;
		internal System.Windows.Forms.TextBox tb_itemsc3;
		private System.Windows.Forms.GroupBox groupBox6;
		internal System.Windows.Forms.TextBox tb_itemsb2;
		private System.Windows.Forms.Label label14;
		internal System.Windows.Forms.ListBox lb_itemsb2;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label label16;
		internal System.Windows.Forms.ListBox lb_itemsb;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.GroupBox groupBox8;
		internal System.Windows.Forms.TextBox tb_itemsb3;
		private System.Windows.Forms.Label label19;
		internal System.Windows.Forms.ListBox lb_itemsb3;
		private System.Windows.Forms.GroupBox groupBox9;
		internal System.Windows.Forms.TextBox tb_itemsb4;
		private System.Windows.Forms.Label label15;
		internal System.Windows.Forms.ListBox lb_itemsb4;
		private System.Windows.Forms.GroupBox groupBox11;
		internal System.Windows.Forms.TextBox tb_itemsb5;
		private System.Windows.Forms.Label label17;
		internal System.Windows.Forms.ListBox lb_itemsb5;
		internal System.Windows.Forms.TextBox tb_uk4;
		internal System.Windows.Forms.TextBox tb_uk6;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Panel pnprev;
		private System.Windows.Forms.Button button3;
		internal System.Windows.Forms.CheckedListBox lbmodel;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ColorDialog cd;
		internal System.Windows.Forms.TabPage tMesh;
		internal System.Windows.Forms.TabPage tDebug;
		private System.Windows.Forms.PropertyGrid pg;
		internal System.Windows.Forms.Label label_elements;
		internal System.Windows.Forms.ListBox list_elements;
		internal System.Windows.Forms.ListBox list_links;
		internal System.Windows.Forms.Label label_links;
		internal System.Windows.Forms.ListBox list_groups;
		internal System.Windows.Forms.Label label_groups;
		internal System.Windows.Forms.ListBox list_subsets;
		internal System.Windows.Forms.Label label_subsets;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.ComboBox cbblock;
		private System.Windows.Forms.ComboBox cbset;
		private System.Windows.Forms.ComboBox cbid;
		private System.Windows.Forms.GroupBox groupBox12;
		internal System.Windows.Forms.ListBox lb_itemsa1;
		internal System.Windows.Forms.TabPage tSubset;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.GroupBox groupBox15;
		internal System.Windows.Forms.ListBox lb_subsets;
		internal System.Windows.Forms.ListBox lb_sub_items;
		internal System.Windows.Forms.ListBox lb_sub_faces;
		internal System.Windows.Forms.TabPage tModel;
		private System.Windows.Forms.GroupBox groupBox16;
		private System.Windows.Forms.GroupBox groupBox17;
		private System.Windows.Forms.GroupBox groupBox18;
		private System.Windows.Forms.GroupBox groupBox19;
		internal System.Windows.Forms.ListBox lb_model_trans;
		internal System.Windows.Forms.ListBox lb_model_names;
		internal System.Windows.Forms.ListBox lb_model_faces;
		internal System.Windows.Forms.ListBox lb_model_items;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		internal System.Windows.Forms.Label lb_models;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.LinkLabel lljointprev;
		private System.Windows.Forms.LinkLabel linkLabel5;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbaxis;
		private System.Windows.Forms.LinkLabel linkLabel6;
		private System.Windows.Forms.LinkLabel linkLabel7;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		internal fGeometryDataContainer()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();		

			Gmdc.BlockFormat[] bls = (Gmdc.BlockFormat[])System.Enum.GetValues(typeof(Gmdc.BlockFormat));
			foreach (Gmdc.BlockFormat b in bls) this.cbblock.Items.Add(b);

			Gmdc.SetFormat[] sets = (Gmdc.SetFormat[])System.Enum.GetValues(typeof(Gmdc.SetFormat));
			foreach (Gmdc.SetFormat s in sets) this.cbset.Items.Add(s);

			Gmdc.ElementIdentity[] eis = (Gmdc.ElementIdentity[])System.Enum.GetValues(typeof(Gmdc.ElementIdentity));
			foreach (Gmdc.ElementIdentity e in eis) this.cbid.Items.Add(e);

#if DEBUG
			this.linkLabel3.Visible = true;
#else
			this.linkLabel3.Visible = false;
#endif
			lljointprev.Visible = Helper.WindowsRegistry.HiddenMode;


			SimPe.Plugin.Gmdc.ElementSorting[] vs = (SimPe.Plugin.Gmdc.ElementSorting[])System.Enum.GetValues(typeof(SimPe.Plugin.Gmdc.ElementSorting));
			foreach (SimPe.Plugin.Gmdc.ElementSorting es in vs) {
				cbaxis.Items.Add(es);
				if (es == ElementSorting.XZY) cbaxis.SelectedIndex = cbaxis.Items.Count-1;
			}

			if (this.DefaultSelectedAxisIndex>=0 && this.DefaultSelectedAxisIndex<cbaxis.Items.Count) cbaxis.SelectedIndex = DefaultSelectedAxisIndex;
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
			this.tGeometryDataContainer = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.tb_itemsa2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_itemsa2 = new System.Windows.Forms.ListBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbid = new System.Windows.Forms.ComboBox();
			this.cbset = new System.Windows.Forms.ComboBox();
			this.cbblock = new System.Windows.Forms.ComboBox();
			this.lb_itemsa = new System.Windows.Forms.ListBox();
			this.tb_uk5 = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tb_mod2 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tb_mod1 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_id = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_uk1 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.tb_ver = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.groupBox12 = new System.Windows.Forms.GroupBox();
			this.lb_itemsa1 = new System.Windows.Forms.ListBox();
			this.tMesh = new System.Windows.Forms.TabPage();
			this.cbaxis = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.lbmodel = new System.Windows.Forms.CheckedListBox();
			this.lb_models = new System.Windows.Forms.Label();
			this.pnprev = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.tGeometryDataContainer3 = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.tb_itemsc2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lb_itemsc2 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.tb_opacity = new System.Windows.Forms.TextBox();
			this.tb_uk2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tb_uk3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb_itemsc = new System.Windows.Forms.ListBox();
			this.tb_itemsc_name = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.tb_itemsc3 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lb_itemsc3 = new System.Windows.Forms.ListBox();
			this.tDebug = new System.Windows.Forms.TabPage();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.list_subsets = new System.Windows.Forms.ListBox();
			this.label_subsets = new System.Windows.Forms.Label();
			this.list_groups = new System.Windows.Forms.ListBox();
			this.label_groups = new System.Windows.Forms.Label();
			this.list_links = new System.Windows.Forms.ListBox();
			this.label_links = new System.Windows.Forms.Label();
			this.list_elements = new System.Windows.Forms.ListBox();
			this.label_elements = new System.Windows.Forms.Label();
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.tModel = new System.Windows.Forms.TabPage();
			this.groupBox19 = new System.Windows.Forms.GroupBox();
			this.lb_model_items = new System.Windows.Forms.ListBox();
			this.groupBox18 = new System.Windows.Forms.GroupBox();
			this.lb_model_faces = new System.Windows.Forms.ListBox();
			this.groupBox17 = new System.Windows.Forms.GroupBox();
			this.lb_model_names = new System.Windows.Forms.ListBox();
			this.groupBox16 = new System.Windows.Forms.GroupBox();
			this.linkLabel6 = new System.Windows.Forms.LinkLabel();
			this.lb_model_trans = new System.Windows.Forms.ListBox();
			this.tGeometryDataContainer2 = new System.Windows.Forms.TabPage();
			this.groupBox9 = new System.Windows.Forms.GroupBox();
			this.tb_itemsb4 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.lb_itemsb4 = new System.Windows.Forms.ListBox();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.tb_itemsb5 = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.lb_itemsb5 = new System.Windows.Forms.ListBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.tb_itemsb2 = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.lb_itemsb2 = new System.Windows.Forms.ListBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.tb_uk4 = new System.Windows.Forms.TextBox();
			this.tb_uk6 = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.lb_itemsb = new System.Windows.Forms.ListBox();
			this.label18 = new System.Windows.Forms.Label();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.tb_itemsb3 = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.lb_itemsb3 = new System.Windows.Forms.ListBox();
			this.tSubset = new System.Windows.Forms.TabPage();
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.lb_sub_items = new System.Windows.Forms.ListBox();
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.lb_sub_faces = new System.Windows.Forms.ListBox();
			this.groupBox15 = new System.Windows.Forms.GroupBox();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.lljointprev = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.lb_subsets = new System.Windows.Forms.ListBox();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.cd = new System.Windows.Forms.ColorDialog();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.tabControl1.SuspendLayout();
			this.tGeometryDataContainer.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.groupBox12.SuspendLayout();
			this.tMesh.SuspendLayout();
			this.tGeometryDataContainer3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.tDebug.SuspendLayout();
			this.tModel.SuspendLayout();
			this.groupBox19.SuspendLayout();
			this.groupBox18.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.groupBox16.SuspendLayout();
			this.tGeometryDataContainer2.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.groupBox11.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.tSubset.SuspendLayout();
			this.groupBox13.SuspendLayout();
			this.groupBox14.SuspendLayout();
			this.groupBox15.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tGeometryDataContainer);
			this.tabControl1.Controls.Add(this.tMesh);
			this.tabControl1.Controls.Add(this.tGeometryDataContainer3);
			this.tabControl1.Controls.Add(this.tDebug);
			this.tabControl1.Controls.Add(this.tModel);
			this.tabControl1.Controls.Add(this.tGeometryDataContainer2);
			this.tabControl1.Controls.Add(this.tSubset);
			this.tabControl1.Location = new System.Drawing.Point(36, -1);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(892, 328);
			this.tabControl1.TabIndex = 1;
			// 
			// tGeometryDataContainer
			// 
			this.tGeometryDataContainer.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGeometryDataContainer.Controls.Add(this.groupBox1);
			this.tGeometryDataContainer.Controls.Add(this.groupBox3);
			this.tGeometryDataContainer.Controls.Add(this.groupBox10);
			this.tGeometryDataContainer.Controls.Add(this.groupBox12);
			this.tGeometryDataContainer.Location = new System.Drawing.Point(4, 22);
			this.tGeometryDataContainer.Name = "tGeometryDataContainer";
			this.tGeometryDataContainer.Size = new System.Drawing.Size(884, 302);
			this.tGeometryDataContainer.TabIndex = 0;
			this.tGeometryDataContainer.Text = "Elements";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.tb_itemsa2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lb_itemsa2);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(612, 152);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(264, 136);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Element Section - Items";
			// 
			// tb_itemsa2
			// 
			this.tb_itemsa2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsa2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsa2.Location = new System.Drawing.Point(56, 104);
			this.tb_itemsa2.Name = "tb_itemsa2";
			this.tb_itemsa2.ReadOnly = true;
			this.tb_itemsa2.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsa2.TabIndex = 24;
			this.tb_itemsa2.Text = "0x00000000";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 112);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 17);
			this.label1.TabIndex = 23;
			this.label1.Text = "Value:";
			// 
			// lb_itemsa2
			// 
			this.lb_itemsa2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsa2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsa2.HorizontalScrollbar = true;
			this.lb_itemsa2.IntegralHeight = false;
			this.lb_itemsa2.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsa2.Name = "lb_itemsa2";
			this.lb_itemsa2.Size = new System.Drawing.Size(248, 72);
			this.lb_itemsa2.TabIndex = 22;
			this.lb_itemsa2.SelectedIndexChanged += new System.EventHandler(this.SelectItemsA2);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.cbid);
			this.groupBox3.Controls.Add(this.cbset);
			this.groupBox3.Controls.Add(this.cbblock);
			this.groupBox3.Controls.Add(this.lb_itemsa);
			this.groupBox3.Controls.Add(this.tb_uk5);
			this.groupBox3.Controls.Add(this.label10);
			this.groupBox3.Controls.Add(this.tb_mod2);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.tb_mod1);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.tb_id);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.tb_uk1);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(8, 88);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(596, 200);
			this.groupBox3.TabIndex = 13;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Element Section";
			// 
			// cbid
			// 
			this.cbid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbid.Enabled = false;
			this.cbid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbid.Location = new System.Drawing.Point(364, 80);
			this.cbid.Name = "cbid";
			this.cbid.Size = new System.Drawing.Size(224, 21);
			this.cbid.TabIndex = 24;
			// 
			// cbset
			// 
			this.cbset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbset.Enabled = false;
			this.cbset.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbset.Location = new System.Drawing.Point(364, 160);
			this.cbset.Name = "cbset";
			this.cbset.Size = new System.Drawing.Size(224, 21);
			this.cbset.TabIndex = 23;
			// 
			// cbblock
			// 
			this.cbblock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbblock.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbblock.Enabled = false;
			this.cbblock.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbblock.Location = new System.Drawing.Point(364, 120);
			this.cbblock.Name = "cbblock";
			this.cbblock.Size = new System.Drawing.Size(224, 21);
			this.cbblock.TabIndex = 22;
			// 
			// lb_itemsa
			// 
			this.lb_itemsa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsa.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsa.HorizontalScrollbar = true;
			this.lb_itemsa.IntegralHeight = false;
			this.lb_itemsa.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsa.Name = "lb_itemsa";
			this.lb_itemsa.Size = new System.Drawing.Size(244, 168);
			this.lb_itemsa.TabIndex = 21;
			this.lb_itemsa.SelectedIndexChanged += new System.EventHandler(this.SelectItemsA);
			// 
			// tb_uk5
			// 
			this.tb_uk5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk5.Location = new System.Drawing.Point(372, 40);
			this.tb_uk5.Name = "tb_uk5";
			this.tb_uk5.ReadOnly = true;
			this.tb_uk5.Size = new System.Drawing.Size(88, 21);
			this.tb_uk5.TabIndex = 14;
			this.tb_uk5.Text = "0x00000000";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(364, 24);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(70, 17);
			this.label10.TabIndex = 13;
			this.label10.Text = "Group UID:";
			// 
			// tb_mod2
			// 
			this.tb_mod2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_mod2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_mod2.Location = new System.Drawing.Point(268, 160);
			this.tb_mod2.Name = "tb_mod2";
			this.tb_mod2.ReadOnly = true;
			this.tb_mod2.Size = new System.Drawing.Size(88, 21);
			this.tb_mod2.TabIndex = 12;
			this.tb_mod2.Text = "0x00";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(260, 144);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(73, 17);
			this.label7.TabIndex = 11;
			this.label7.Text = "Set Format:";
			// 
			// tb_mod1
			// 
			this.tb_mod1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_mod1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_mod1.Location = new System.Drawing.Point(268, 120);
			this.tb_mod1.Name = "tb_mod1";
			this.tb_mod1.ReadOnly = true;
			this.tb_mod1.Size = new System.Drawing.Size(88, 21);
			this.tb_mod1.TabIndex = 10;
			this.tb_mod1.Text = "0x00000000";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(260, 104);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(84, 17);
			this.label8.TabIndex = 9;
			this.label8.Text = "Block Format:";
			// 
			// tb_id
			// 
			this.tb_id.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_id.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_id.Location = new System.Drawing.Point(268, 80);
			this.tb_id.Name = "tb_id";
			this.tb_id.ReadOnly = true;
			this.tb_id.Size = new System.Drawing.Size(88, 21);
			this.tb_id.TabIndex = 8;
			this.tb_id.Text = "0x00000000";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(260, 64);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(54, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "Identity:";
			// 
			// tb_uk1
			// 
			this.tb_uk1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk1.Location = new System.Drawing.Point(268, 40);
			this.tb_uk1.Name = "tb_uk1";
			this.tb_uk1.ReadOnly = true;
			this.tb_uk1.Size = new System.Drawing.Size(88, 21);
			this.tb_uk1.TabIndex = 6;
			this.tb_uk1.Text = "0x0000";
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(260, 24);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Number:";
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.tb_ver);
			this.groupBox10.Controls.Add(this.label28);
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(8, 8);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(120, 72);
			this.groupBox10.TabIndex = 12;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Settings";
			// 
			// tb_ver
			// 
			this.tb_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_ver.Name = "tb_ver";
			this.tb_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_ver.TabIndex = 24;
			this.tb_ver.Text = "0x00000000";
			this.tb_ver.TextChanged += new System.EventHandler(this.SettingsChange);
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
			// groupBox12
			// 
			this.groupBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox12.Controls.Add(this.lb_itemsa1);
			this.groupBox12.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox12.Location = new System.Drawing.Point(612, 8);
			this.groupBox12.Name = "groupBox12";
			this.groupBox12.Size = new System.Drawing.Size(264, 136);
			this.groupBox12.TabIndex = 25;
			this.groupBox12.TabStop = false;
			this.groupBox12.Text = "Element Section - Values";
			// 
			// lb_itemsa1
			// 
			this.lb_itemsa1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsa1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsa1.HorizontalScrollbar = true;
			this.lb_itemsa1.IntegralHeight = false;
			this.lb_itemsa1.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsa1.Name = "lb_itemsa1";
			this.lb_itemsa1.Size = new System.Drawing.Size(248, 104);
			this.lb_itemsa1.TabIndex = 22;
			// 
			// tMesh
			// 
			this.tMesh.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tMesh.Controls.Add(this.cbaxis);
			this.tMesh.Controls.Add(this.label12);
			this.tMesh.Controls.Add(this.button1);
			this.tMesh.Controls.Add(this.button5);
			this.tMesh.Controls.Add(this.label20);
			this.tMesh.Controls.Add(this.lbmodel);
			this.tMesh.Controls.Add(this.lb_models);
			this.tMesh.Controls.Add(this.pnprev);
			this.tMesh.Controls.Add(this.button3);
			this.tMesh.Controls.Add(this.button4);
			this.tMesh.Location = new System.Drawing.Point(4, 22);
			this.tMesh.Name = "tMesh";
			this.tMesh.Size = new System.Drawing.Size(884, 302);
			this.tMesh.TabIndex = 4;
			this.tMesh.Text = "3D Mesh";
			// 
			// cbaxis
			// 
			this.cbaxis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbaxis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaxis.Location = new System.Drawing.Point(232, 240);
			this.cbaxis.Name = "cbaxis";
			this.cbaxis.Size = new System.Drawing.Size(96, 21);
			this.cbaxis.TabIndex = 30;
			this.cbaxis.SelectedIndexChanged += new System.EventHandler(this.ChangedAxis);
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(176, 240);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(48, 23);
			this.label12.TabIndex = 29;
			this.label12.Text = "Order:";
			this.label12.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(96, 240);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(72, 23);
			this.button1.TabIndex = 28;
			this.button1.Text = "Import...";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button5.Location = new System.Drawing.Point(16, 240);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(72, 23);
			this.button5.TabIndex = 27;
			this.button5.Text = "Export...";
			this.button5.Click += new System.EventHandler(this.Export);
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.label20.Location = new System.Drawing.Point(644, 8);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(232, 288);
			this.label20.TabIndex = 25;
			this.label20.Text = @"Camera Control:

 Translate Y: left Button + move vertical
 Translate X: left Button + move horizontal
 Scale: middle Button + move vertical
 Rotate Z: middle Button + move horizontal
 Rotate X: right Button + move vertical
 Rotate Y: right Button + move horizontal";
			this.label20.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lbmodel
			// 
			this.lbmodel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lbmodel.CheckOnClick = true;
			this.lbmodel.HorizontalScrollbar = true;
			this.lbmodel.Location = new System.Drawing.Point(16, 24);
			this.lbmodel.Name = "lbmodel";
			this.lbmodel.Size = new System.Drawing.Size(312, 214);
			this.lbmodel.TabIndex = 24;
			// 
			// lb_models
			// 
			this.lb_models.AutoSize = true;
			this.lb_models.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_models.Location = new System.Drawing.Point(8, 8);
			this.lb_models.Name = "lb_models";
			this.lb_models.Size = new System.Drawing.Size(45, 16);
			this.lb_models.TabIndex = 23;
			this.lb_models.Text = "Models:";
			// 
			// pnprev
			// 
			this.pnprev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnprev.Location = new System.Drawing.Point(336, 8);
			this.pnprev.Name = "pnprev";
			this.pnprev.Size = new System.Drawing.Size(296, 288);
			this.pnprev.TabIndex = 3;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3.Location = new System.Drawing.Point(16, 272);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(152, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Preview";
			this.button3.Click += new System.EventHandler(this.Preview);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(184, 272);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(32, 23);
			this.button4.TabIndex = 26;
			this.button4.Text = "BG";
			this.button4.Click += new System.EventHandler(this.PickColor);
			// 
			// tGeometryDataContainer3
			// 
			this.tGeometryDataContainer3.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGeometryDataContainer3.Controls.Add(this.groupBox4);
			this.tGeometryDataContainer3.Controls.Add(this.groupBox2);
			this.tGeometryDataContainer3.Controls.Add(this.groupBox5);
			this.tGeometryDataContainer3.Location = new System.Drawing.Point(4, 22);
			this.tGeometryDataContainer3.Name = "tGeometryDataContainer3";
			this.tGeometryDataContainer3.Size = new System.Drawing.Size(884, 302);
			this.tGeometryDataContainer3.TabIndex = 2;
			this.tGeometryDataContainer3.Text = "Groups";
			// 
			// groupBox4
			// 
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox4.Controls.Add(this.tb_itemsc2);
			this.groupBox4.Controls.Add(this.label4);
			this.groupBox4.Controls.Add(this.lb_itemsc2);
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(612, 8);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(264, 136);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Group Section - Faces";
			// 
			// tb_itemsc2
			// 
			this.tb_itemsc2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsc2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsc2.Location = new System.Drawing.Point(56, 104);
			this.tb_itemsc2.Name = "tb_itemsc2";
			this.tb_itemsc2.ReadOnly = true;
			this.tb_itemsc2.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsc2.TabIndex = 24;
			this.tb_itemsc2.Text = "0x00000000";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 17);
			this.label4.TabIndex = 23;
			this.label4.Text = "Value:";
			// 
			// lb_itemsc2
			// 
			this.lb_itemsc2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsc2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsc2.HorizontalScrollbar = true;
			this.lb_itemsc2.IntegralHeight = false;
			this.lb_itemsc2.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsc2.Name = "lb_itemsc2";
			this.lb_itemsc2.Size = new System.Drawing.Size(248, 72);
			this.lb_itemsc2.TabIndex = 22;
			this.lb_itemsc2.SelectedIndexChanged += new System.EventHandler(this.SelectItemsC2);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.linkLabel2);
			this.groupBox2.Controls.Add(this.tb_opacity);
			this.groupBox2.Controls.Add(this.tb_uk2);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.tb_uk3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.lb_itemsc);
			this.groupBox2.Controls.Add(this.tb_itemsc_name);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(8, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(596, 288);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Group Section";
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel2.Location = new System.Drawing.Point(268, 112);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(48, 23);
			this.linkLabel2.TabIndex = 26;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Delete";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// tb_opacity
			// 
			this.tb_opacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_opacity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_opacity.Location = new System.Drawing.Point(492, 40);
			this.tb_opacity.Name = "tb_opacity";
			this.tb_opacity.Size = new System.Drawing.Size(88, 21);
			this.tb_opacity.TabIndex = 6;
			this.tb_opacity.Text = "0x00000000";
			this.tb_opacity.TextChanged += new System.EventHandler(this.ChangeItemsC);
			// 
			// tb_uk2
			// 
			this.tb_uk2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk2.Location = new System.Drawing.Point(268, 40);
			this.tb_uk2.Name = "tb_uk2";
			this.tb_uk2.Size = new System.Drawing.Size(88, 21);
			this.tb_uk2.TabIndex = 25;
			this.tb_uk2.Text = "0x00000000";
			this.tb_uk2.TextChanged += new System.EventHandler(this.ChangeItemsC);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(484, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 24;
			this.label3.Text = "Opacity:";
			// 
			// tb_uk3
			// 
			this.tb_uk3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk3.Location = new System.Drawing.Point(380, 40);
			this.tb_uk3.Name = "tb_uk3";
			this.tb_uk3.Size = new System.Drawing.Size(88, 21);
			this.tb_uk3.TabIndex = 23;
			this.tb_uk3.Text = "0x00000000";
			this.tb_uk3.TextChanged += new System.EventHandler(this.ChangeItemsC);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(372, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(93, 17);
			this.label2.TabIndex = 22;
			this.label2.Text = "Link Reference:";
			// 
			// lb_itemsc
			// 
			this.lb_itemsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsc.HorizontalScrollbar = true;
			this.lb_itemsc.IntegralHeight = false;
			this.lb_itemsc.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsc.Name = "lb_itemsc";
			this.lb_itemsc.Size = new System.Drawing.Size(244, 256);
			this.lb_itemsc.TabIndex = 21;
			this.lb_itemsc.SelectedIndexChanged += new System.EventHandler(this.SelectItemsC);
			// 
			// tb_itemsc_name
			// 
			this.tb_itemsc_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_itemsc_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsc_name.Location = new System.Drawing.Point(268, 80);
			this.tb_itemsc_name.Name = "tb_itemsc_name";
			this.tb_itemsc_name.Size = new System.Drawing.Size(312, 21);
			this.tb_itemsc_name.TabIndex = 8;
			this.tb_itemsc_name.Text = "";
			this.tb_itemsc_name.TextChanged += new System.EventHandler(this.ChangeItemsC);
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(260, 64);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 17);
			this.label11.TabIndex = 7;
			this.label11.Text = "Name:";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(260, 24);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(71, 17);
			this.label13.TabIndex = 5;
			this.label13.Text = "Prim. Type:";
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.tb_itemsc3);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.lb_itemsc3);
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(612, 152);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(264, 144);
			this.groupBox5.TabIndex = 25;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Group Section - Used Joints";
			// 
			// tb_itemsc3
			// 
			this.tb_itemsc3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsc3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsc3.Location = new System.Drawing.Point(56, 112);
			this.tb_itemsc3.Name = "tb_itemsc3";
			this.tb_itemsc3.ReadOnly = true;
			this.tb_itemsc3.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsc3.TabIndex = 24;
			this.tb_itemsc3.Text = "0x00000000";
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 120);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 17);
			this.label9.TabIndex = 23;
			this.label9.Text = "Value:";
			// 
			// lb_itemsc3
			// 
			this.lb_itemsc3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsc3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsc3.HorizontalScrollbar = true;
			this.lb_itemsc3.IntegralHeight = false;
			this.lb_itemsc3.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsc3.Name = "lb_itemsc3";
			this.lb_itemsc3.Size = new System.Drawing.Size(248, 80);
			this.lb_itemsc3.TabIndex = 22;
			this.lb_itemsc3.SelectedIndexChanged += new System.EventHandler(this.SelectItemsC3);
			// 
			// tDebug
			// 
			this.tDebug.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tDebug.Controls.Add(this.linkLabel3);
			this.tDebug.Controls.Add(this.linkLabel1);
			this.tDebug.Controls.Add(this.list_subsets);
			this.tDebug.Controls.Add(this.label_subsets);
			this.tDebug.Controls.Add(this.list_groups);
			this.tDebug.Controls.Add(this.label_groups);
			this.tDebug.Controls.Add(this.list_links);
			this.tDebug.Controls.Add(this.label_links);
			this.tDebug.Controls.Add(this.list_elements);
			this.tDebug.Controls.Add(this.label_elements);
			this.tDebug.Controls.Add(this.pg);
			this.tDebug.Location = new System.Drawing.Point(4, 22);
			this.tDebug.Name = "tDebug";
			this.tDebug.Size = new System.Drawing.Size(884, 302);
			this.tDebug.TabIndex = 5;
			this.tDebug.Text = "Debug";
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(296, 152);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(30, 16);
			this.linkLabel3.TabIndex = 10;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Scan";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Location = new System.Drawing.Point(296, 128);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(40, 16);
			this.linkLabel1.TabIndex = 9;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Model";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SeletDebugObject);
			// 
			// list_subsets
			// 
			this.list_subsets.Location = new System.Drawing.Point(296, 24);
			this.list_subsets.Name = "list_subsets";
			this.list_subsets.Size = new System.Drawing.Size(264, 95);
			this.list_subsets.TabIndex = 8;
			this.list_subsets.SelectedIndexChanged += new System.EventHandler(this.SeletDebugObject);
			// 
			// label_subsets
			// 
			this.label_subsets.AutoSize = true;
			this.label_subsets.Location = new System.Drawing.Point(288, 8);
			this.label_subsets.Name = "label_subsets";
			this.label_subsets.Size = new System.Drawing.Size(48, 16);
			this.label_subsets.TabIndex = 7;
			this.label_subsets.Text = "Subsets:";
			// 
			// list_groups
			// 
			this.list_groups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.list_groups.Location = new System.Drawing.Point(16, 224);
			this.list_groups.Name = "list_groups";
			this.list_groups.Size = new System.Drawing.Size(264, 69);
			this.list_groups.TabIndex = 6;
			this.list_groups.SelectedIndexChanged += new System.EventHandler(this.SeletDebugObject);
			// 
			// label_groups
			// 
			this.label_groups.AutoSize = true;
			this.label_groups.Location = new System.Drawing.Point(8, 208);
			this.label_groups.Name = "label_groups";
			this.label_groups.Size = new System.Drawing.Size(44, 16);
			this.label_groups.TabIndex = 5;
			this.label_groups.Text = "Groups:";
			// 
			// list_links
			// 
			this.list_links.Location = new System.Drawing.Point(16, 136);
			this.list_links.Name = "list_links";
			this.list_links.Size = new System.Drawing.Size(264, 69);
			this.list_links.TabIndex = 4;
			this.list_links.SelectedIndexChanged += new System.EventHandler(this.SeletDebugObject);
			// 
			// label_links
			// 
			this.label_links.AutoSize = true;
			this.label_links.Location = new System.Drawing.Point(8, 120);
			this.label_links.Name = "label_links";
			this.label_links.Size = new System.Drawing.Size(34, 16);
			this.label_links.TabIndex = 3;
			this.label_links.Text = "Links:";
			// 
			// list_elements
			// 
			this.list_elements.Location = new System.Drawing.Point(16, 24);
			this.list_elements.Name = "list_elements";
			this.list_elements.Size = new System.Drawing.Size(264, 95);
			this.list_elements.TabIndex = 2;
			this.list_elements.SelectedIndexChanged += new System.EventHandler(this.SeletDebugObject);
			// 
			// label_elements
			// 
			this.label_elements.AutoSize = true;
			this.label_elements.Location = new System.Drawing.Point(8, 8);
			this.label_elements.Name = "label_elements";
			this.label_elements.Size = new System.Drawing.Size(55, 16);
			this.label_elements.TabIndex = 1;
			this.label_elements.Text = "Elements:";
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(560, 8);
			this.pg.Name = "pg";
			this.pg.Size = new System.Drawing.Size(316, 288);
			this.pg.TabIndex = 0;
			this.pg.Text = "propertyGrid1";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// tModel
			// 
			this.tModel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tModel.Controls.Add(this.groupBox19);
			this.tModel.Controls.Add(this.groupBox18);
			this.tModel.Controls.Add(this.groupBox17);
			this.tModel.Controls.Add(this.groupBox16);
			this.tModel.Location = new System.Drawing.Point(4, 22);
			this.tModel.Name = "tModel";
			this.tModel.Size = new System.Drawing.Size(884, 302);
			this.tModel.TabIndex = 7;
			this.tModel.Text = "Model";
			// 
			// groupBox19
			// 
			this.groupBox19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox19.Controls.Add(this.lb_model_items);
			this.groupBox19.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox19.Location = new System.Drawing.Point(676, 160);
			this.groupBox19.Name = "groupBox19";
			this.groupBox19.Size = new System.Drawing.Size(200, 136);
			this.groupBox19.TabIndex = 35;
			this.groupBox19.TabStop = false;
			this.groupBox19.Text = "Model Section - Items";
			// 
			// lb_model_items
			// 
			this.lb_model_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_model_items.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_model_items.HorizontalScrollbar = true;
			this.lb_model_items.IntegralHeight = false;
			this.lb_model_items.Location = new System.Drawing.Point(8, 24);
			this.lb_model_items.Name = "lb_model_items";
			this.lb_model_items.Size = new System.Drawing.Size(184, 104);
			this.lb_model_items.TabIndex = 22;
			// 
			// groupBox18
			// 
			this.groupBox18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox18.Controls.Add(this.lb_model_faces);
			this.groupBox18.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox18.Location = new System.Drawing.Point(584, 8);
			this.groupBox18.Name = "groupBox18";
			this.groupBox18.Size = new System.Drawing.Size(292, 144);
			this.groupBox18.TabIndex = 34;
			this.groupBox18.TabStop = false;
			this.groupBox18.Text = "Model Section - Faces";
			// 
			// lb_model_faces
			// 
			this.lb_model_faces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_model_faces.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_model_faces.HorizontalScrollbar = true;
			this.lb_model_faces.IntegralHeight = false;
			this.lb_model_faces.Location = new System.Drawing.Point(8, 24);
			this.lb_model_faces.Name = "lb_model_faces";
			this.lb_model_faces.Size = new System.Drawing.Size(276, 112);
			this.lb_model_faces.TabIndex = 22;
			// 
			// groupBox17
			// 
			this.groupBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox17.Controls.Add(this.lb_model_names);
			this.groupBox17.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox17.Location = new System.Drawing.Point(8, 160);
			this.groupBox17.Name = "groupBox17";
			this.groupBox17.Size = new System.Drawing.Size(660, 136);
			this.groupBox17.TabIndex = 33;
			this.groupBox17.TabStop = false;
			this.groupBox17.Text = "Model Section - Names";
			// 
			// lb_model_names
			// 
			this.lb_model_names.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_model_names.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_model_names.HorizontalScrollbar = true;
			this.lb_model_names.IntegralHeight = false;
			this.lb_model_names.Location = new System.Drawing.Point(8, 24);
			this.lb_model_names.Name = "lb_model_names";
			this.lb_model_names.Size = new System.Drawing.Size(644, 104);
			this.lb_model_names.TabIndex = 22;
			// 
			// groupBox16
			// 
			this.groupBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox16.Controls.Add(this.linkLabel6);
			this.groupBox16.Controls.Add(this.lb_model_trans);
			this.groupBox16.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox16.Location = new System.Drawing.Point(8, 8);
			this.groupBox16.Name = "groupBox16";
			this.groupBox16.Size = new System.Drawing.Size(568, 144);
			this.groupBox16.TabIndex = 32;
			this.groupBox16.TabStop = false;
			this.groupBox16.Text = "Model Section - Transformations";
			// 
			// linkLabel6
			// 
			this.linkLabel6.AutoSize = true;
			this.linkLabel6.Location = new System.Drawing.Point(232, 0);
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.Size = new System.Drawing.Size(52, 17);
			this.linkLabel6.TabIndex = 23;
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = "Rebuild";
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RebuildAbsTransform);
			// 
			// lb_model_trans
			// 
			this.lb_model_trans.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lb_model_trans.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_model_trans.HorizontalScrollbar = true;
			this.lb_model_trans.IntegralHeight = false;
			this.lb_model_trans.Location = new System.Drawing.Point(8, 24);
			this.lb_model_trans.Name = "lb_model_trans";
			this.lb_model_trans.Size = new System.Drawing.Size(552, 112);
			this.lb_model_trans.TabIndex = 22;
			// 
			// tGeometryDataContainer2
			// 
			this.tGeometryDataContainer2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGeometryDataContainer2.Controls.Add(this.groupBox9);
			this.tGeometryDataContainer2.Controls.Add(this.groupBox11);
			this.tGeometryDataContainer2.Controls.Add(this.groupBox6);
			this.tGeometryDataContainer2.Controls.Add(this.groupBox7);
			this.tGeometryDataContainer2.Controls.Add(this.groupBox8);
			this.tGeometryDataContainer2.Location = new System.Drawing.Point(4, 22);
			this.tGeometryDataContainer2.Name = "tGeometryDataContainer2";
			this.tGeometryDataContainer2.Size = new System.Drawing.Size(884, 302);
			this.tGeometryDataContainer2.TabIndex = 1;
			this.tGeometryDataContainer2.Text = "Links";
			// 
			// groupBox9
			// 
			this.groupBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox9.Controls.Add(this.tb_itemsb4);
			this.groupBox9.Controls.Add(this.label15);
			this.groupBox9.Controls.Add(this.lb_itemsb4);
			this.groupBox9.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox9.Location = new System.Drawing.Point(644, 8);
			this.groupBox9.Name = "groupBox9";
			this.groupBox9.Size = new System.Drawing.Size(232, 136);
			this.groupBox9.TabIndex = 29;
			this.groupBox9.TabStop = false;
			this.groupBox9.Text = "Link Section - Normal Alias";
			// 
			// tb_itemsb4
			// 
			this.tb_itemsb4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsb4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsb4.Location = new System.Drawing.Point(56, 104);
			this.tb_itemsb4.Name = "tb_itemsb4";
			this.tb_itemsb4.ReadOnly = true;
			this.tb_itemsb4.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsb4.TabIndex = 24;
			this.tb_itemsb4.Text = "0x00000000";
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(8, 112);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(41, 17);
			this.label15.TabIndex = 23;
			this.label15.Text = "Value:";
			// 
			// lb_itemsb4
			// 
			this.lb_itemsb4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsb4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsb4.HorizontalScrollbar = true;
			this.lb_itemsb4.IntegralHeight = false;
			this.lb_itemsb4.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsb4.Name = "lb_itemsb4";
			this.lb_itemsb4.Size = new System.Drawing.Size(216, 72);
			this.lb_itemsb4.TabIndex = 22;
			this.lb_itemsb4.SelectedIndexChanged += new System.EventHandler(this.SelectItemsB4);
			// 
			// groupBox11
			// 
			this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox11.Controls.Add(this.tb_itemsb5);
			this.groupBox11.Controls.Add(this.label17);
			this.groupBox11.Controls.Add(this.lb_itemsb5);
			this.groupBox11.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox11.Location = new System.Drawing.Point(644, 152);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(232, 144);
			this.groupBox11.TabIndex = 30;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Link Section - UVCoord. Alias";
			// 
			// tb_itemsb5
			// 
			this.tb_itemsb5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsb5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsb5.Location = new System.Drawing.Point(56, 112);
			this.tb_itemsb5.Name = "tb_itemsb5";
			this.tb_itemsb5.ReadOnly = true;
			this.tb_itemsb5.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsb5.TabIndex = 24;
			this.tb_itemsb5.Text = "0x00000000";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(8, 120);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(41, 17);
			this.label17.TabIndex = 23;
			this.label17.Text = "Value:";
			// 
			// lb_itemsb5
			// 
			this.lb_itemsb5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsb5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsb5.HorizontalScrollbar = true;
			this.lb_itemsb5.IntegralHeight = false;
			this.lb_itemsb5.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsb5.Name = "lb_itemsb5";
			this.lb_itemsb5.Size = new System.Drawing.Size(216, 80);
			this.lb_itemsb5.TabIndex = 22;
			this.lb_itemsb5.SelectedIndexChanged += new System.EventHandler(this.SelectItemsB5);
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.tb_itemsb2);
			this.groupBox6.Controls.Add(this.label14);
			this.groupBox6.Controls.Add(this.lb_itemsb2);
			this.groupBox6.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(404, 8);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(232, 136);
			this.groupBox6.TabIndex = 27;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Link Section - Elements Ref.";
			// 
			// tb_itemsb2
			// 
			this.tb_itemsb2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsb2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsb2.Location = new System.Drawing.Point(56, 104);
			this.tb_itemsb2.Name = "tb_itemsb2";
			this.tb_itemsb2.ReadOnly = true;
			this.tb_itemsb2.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsb2.TabIndex = 24;
			this.tb_itemsb2.Text = "0x00000000";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(8, 112);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(41, 17);
			this.label14.TabIndex = 23;
			this.label14.Text = "Value:";
			// 
			// lb_itemsb2
			// 
			this.lb_itemsb2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsb2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsb2.HorizontalScrollbar = true;
			this.lb_itemsb2.IntegralHeight = false;
			this.lb_itemsb2.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsb2.Name = "lb_itemsb2";
			this.lb_itemsb2.Size = new System.Drawing.Size(216, 72);
			this.lb_itemsb2.TabIndex = 22;
			this.lb_itemsb2.SelectedIndexChanged += new System.EventHandler(this.SelectItemsB2);
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.linkLabel7);
			this.groupBox7.Controls.Add(this.tb_uk4);
			this.groupBox7.Controls.Add(this.tb_uk6);
			this.groupBox7.Controls.Add(this.label16);
			this.groupBox7.Controls.Add(this.lb_itemsb);
			this.groupBox7.Controls.Add(this.label18);
			this.groupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(8, 7);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(388, 288);
			this.groupBox7.TabIndex = 26;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Link Section";
			// 
			// linkLabel7
			// 
			this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel7.Location = new System.Drawing.Point(272, 120);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.TabIndex = 26;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "Flatten";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FlattenAliasMap);
			// 
			// tb_uk4
			// 
			this.tb_uk4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk4.Location = new System.Drawing.Point(276, 40);
			this.tb_uk4.Name = "tb_uk4";
			this.tb_uk4.ReadOnly = true;
			this.tb_uk4.Size = new System.Drawing.Size(88, 21);
			this.tb_uk4.TabIndex = 25;
			this.tb_uk4.Text = "0x00000000";
			// 
			// tb_uk6
			// 
			this.tb_uk6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_uk6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_uk6.Location = new System.Drawing.Point(276, 80);
			this.tb_uk6.Name = "tb_uk6";
			this.tb_uk6.ReadOnly = true;
			this.tb_uk6.Size = new System.Drawing.Size(88, 21);
			this.tb_uk6.TabIndex = 23;
			this.tb_uk6.Text = "0x00000000";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label16.Location = new System.Drawing.Point(268, 64);
			this.label16.Name = "label16";
			this.label16.TabIndex = 22;
			this.label16.Text = "Active Elements:";
			// 
			// lb_itemsb
			// 
			this.lb_itemsb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsb.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsb.HorizontalScrollbar = true;
			this.lb_itemsb.IntegralHeight = false;
			this.lb_itemsb.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsb.Name = "lb_itemsb";
			this.lb_itemsb.Size = new System.Drawing.Size(252, 256);
			this.lb_itemsb.TabIndex = 21;
			this.lb_itemsb.SelectedIndexChanged += new System.EventHandler(this.SelectItemsB);
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(268, 24);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(101, 17);
			this.label18.TabIndex = 5;
			this.label18.Text = "Referenced Size:";
			// 
			// groupBox8
			// 
			this.groupBox8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox8.Controls.Add(this.tb_itemsb3);
			this.groupBox8.Controls.Add(this.label19);
			this.groupBox8.Controls.Add(this.lb_itemsb3);
			this.groupBox8.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox8.Location = new System.Drawing.Point(404, 152);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(232, 144);
			this.groupBox8.TabIndex = 28;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Link Section - Vertex Alias";
			// 
			// tb_itemsb3
			// 
			this.tb_itemsb3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tb_itemsb3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemsb3.Location = new System.Drawing.Point(56, 112);
			this.tb_itemsb3.Name = "tb_itemsb3";
			this.tb_itemsb3.ReadOnly = true;
			this.tb_itemsb3.Size = new System.Drawing.Size(88, 21);
			this.tb_itemsb3.TabIndex = 24;
			this.tb_itemsb3.Text = "0x00000000";
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(8, 120);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(41, 17);
			this.label19.TabIndex = 23;
			this.label19.Text = "Value:";
			// 
			// lb_itemsb3
			// 
			this.lb_itemsb3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_itemsb3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_itemsb3.HorizontalScrollbar = true;
			this.lb_itemsb3.IntegralHeight = false;
			this.lb_itemsb3.Location = new System.Drawing.Point(8, 24);
			this.lb_itemsb3.Name = "lb_itemsb3";
			this.lb_itemsb3.Size = new System.Drawing.Size(216, 80);
			this.lb_itemsb3.TabIndex = 22;
			this.lb_itemsb3.SelectedIndexChanged += new System.EventHandler(this.SelectItemsB3);
			// 
			// tSubset
			// 
			this.tSubset.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tSubset.Controls.Add(this.groupBox13);
			this.tSubset.Controls.Add(this.groupBox14);
			this.tSubset.Controls.Add(this.groupBox15);
			this.tSubset.Location = new System.Drawing.Point(4, 22);
			this.tSubset.Name = "tSubset";
			this.tSubset.Size = new System.Drawing.Size(884, 302);
			this.tSubset.TabIndex = 6;
			this.tSubset.Text = "Joints";
			// 
			// groupBox13
			// 
			this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox13.Controls.Add(this.lb_sub_items);
			this.groupBox13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox13.Location = new System.Drawing.Point(604, 160);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(272, 136);
			this.groupBox13.TabIndex = 32;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Joints Section - Items";
			// 
			// lb_sub_items
			// 
			this.lb_sub_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_sub_items.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_sub_items.HorizontalScrollbar = true;
			this.lb_sub_items.IntegralHeight = false;
			this.lb_sub_items.Location = new System.Drawing.Point(8, 24);
			this.lb_sub_items.Name = "lb_sub_items";
			this.lb_sub_items.Size = new System.Drawing.Size(256, 96);
			this.lb_sub_items.TabIndex = 22;
			this.lb_sub_items.SelectedIndexChanged += new System.EventHandler(this.lb_sub_item_SelectedIndexChanged);
			// 
			// groupBox14
			// 
			this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox14.Controls.Add(this.lb_sub_faces);
			this.groupBox14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox14.Location = new System.Drawing.Point(604, 8);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(272, 144);
			this.groupBox14.TabIndex = 31;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Joints Section - Vertices";
			// 
			// lb_sub_faces
			// 
			this.lb_sub_faces.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_sub_faces.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_sub_faces.HorizontalScrollbar = true;
			this.lb_sub_faces.IntegralHeight = false;
			this.lb_sub_faces.Location = new System.Drawing.Point(8, 24);
			this.lb_sub_faces.Name = "lb_sub_faces";
			this.lb_sub_faces.Size = new System.Drawing.Size(256, 112);
			this.lb_sub_faces.TabIndex = 22;
			// 
			// groupBox15
			// 
			this.groupBox15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox15.Controls.Add(this.linkLabel5);
			this.groupBox15.Controls.Add(this.lljointprev);
			this.groupBox15.Controls.Add(this.linkLabel4);
			this.groupBox15.Controls.Add(this.lb_subsets);
			this.groupBox15.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox15.Location = new System.Drawing.Point(8, 7);
			this.groupBox15.Name = "groupBox15";
			this.groupBox15.Size = new System.Drawing.Size(588, 288);
			this.groupBox15.TabIndex = 30;
			this.groupBox15.TabStop = false;
			this.groupBox15.Text = "Joints Section";
			// 
			// linkLabel5
			// 
			this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel5.Location = new System.Drawing.Point(528, 208);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(56, 23);
			this.linkLabel5.TabIndex = 29;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "Rebuild";
			this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RebuildJointVertices);
			// 
			// lljointprev
			// 
			this.lljointprev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lljointprev.Location = new System.Drawing.Point(528, 232);
			this.lljointprev.Name = "lljointprev";
			this.lljointprev.Size = new System.Drawing.Size(56, 23);
			this.lljointprev.TabIndex = 28;
			this.lljointprev.TabStop = true;
			this.lljointprev.Text = "Preview";
			this.lljointprev.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lljointprev.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviewJoint);
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.Location = new System.Drawing.Point(528, 256);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(48, 23);
			this.linkLabel4.TabIndex = 27;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Delete";
			this.linkLabel4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteJoint);
			// 
			// lb_subsets
			// 
			this.lb_subsets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_subsets.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_subsets.HorizontalScrollbar = true;
			this.lb_subsets.IntegralHeight = false;
			this.lb_subsets.Location = new System.Drawing.Point(8, 24);
			this.lb_subsets.Name = "lb_subsets";
			this.lb_subsets.Size = new System.Drawing.Size(512, 256);
			this.lb_subsets.TabIndex = 21;
			this.lb_subsets.SelectedIndexChanged += new System.EventHandler(this.lb_subsets_SelectedIndexChanged);
			// 
			// sfd
			// 
			this.sfd.Title = "Export Mesh";
			// 
			// cd
			// 
			this.cd.Color = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(255)));
			// 
			// ofd
			// 
			this.ofd.Title = "Import Mesh";
			// 
			// fGeometryDataContainer
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(936, 334);
			this.Controls.Add(this.tabControl1);
			this.Name = "fGeometryDataContainer";
			this.Text = "fGeometryDataContainer";
			this.Load += new System.EventHandler(this.fGeometryDataContainer_Load);
			this.tabControl1.ResumeLayout(false);
			this.tGeometryDataContainer.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.groupBox12.ResumeLayout(false);
			this.tMesh.ResumeLayout(false);
			this.tGeometryDataContainer3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.tDebug.ResumeLayout(false);
			this.tModel.ResumeLayout(false);
			this.groupBox19.ResumeLayout(false);
			this.groupBox18.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.groupBox16.ResumeLayout(false);
			this.tGeometryDataContainer2.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.groupBox11.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox8.ResumeLayout(false);
			this.tSubset.ResumeLayout(false);
			this.groupBox13.ResumeLayout(false);
			this.groupBox14.ResumeLayout(false);
			this.groupBox15.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void SettingsChange(object sender, System.EventArgs e)
		{
			if (tMesh.Tag==null) return;
			try 
			{
				GeometryDataContainer gdc = (GeometryDataContainer)tMesh.Tag;

				gdc.Version = Convert.ToUInt32(tb_ver.Text, 16);

				gdc.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		private void SelectItemsA(object sender, System.EventArgs e)
		{
			if (lb_itemsa.Tag != null) return;
			if (lb_itemsa.SelectedIndex<0) return;
			try 
			{
				lb_itemsa.Tag = true;				
				GmdcElement item = (GmdcElement)((CountedListItem)lb_itemsa.Items[lb_itemsa.SelectedIndex]).Object;

				this.tb_id.Text = "0x"+Helper.HexString((uint)item.Identity);
				this.tb_uk1.Text = item.Number.ToString();
				this.tb_mod1.Text = "0x"+Helper.HexString((uint)item.BlockFormat);
				this.tb_mod2.Text = "0x"+Helper.HexString((uint)item.SetFormat);
				this.tb_uk5.Text = "0x"+Helper.HexString(item.GroupId);

				cbid.SelectedIndex=0;
				for (int i=0; i<this.cbid.Items.Count; i++) 
				{
					Gmdc.ElementIdentity b = (ElementIdentity)this.cbid.Items[i];
					if (b==item.Identity) cbid.SelectedIndex=i;
				}

				cbblock.SelectedIndex=cbblock.Items.Count-1;
				for (int i=0; i<this.cbblock.Items.Count; i++) 
				{
					Gmdc.BlockFormat b = (BlockFormat)this.cbblock.Items[i];
					if (b==item.BlockFormat) cbblock.SelectedIndex=i;
				}

				cbset.SelectedIndex=cbset.Items.Count-1;
				for (int i=0; i<this.cbset.Items.Count; i++) 
				{
					Gmdc.SetFormat b = (SetFormat)this.cbset.Items[i];
					if (b==item.SetFormat) cbset.SelectedIndex=i;
				}

				lb_itemsa1.Items.Clear();
				foreach (GmdcElementValueBase i in item.Values) SimPe.CountedListItem.Add(lb_itemsa1, i);

				lb_itemsa2.Items.Clear();
				foreach (int i in item.Items) lb_itemsa2.Items.Add(i);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsa.Tag = null;
			}
		}

		private void SelectItemsA2(object sender, System.EventArgs e)
		{
			if (lb_itemsa.Tag != null) return;
			if (lb_itemsa.SelectedIndex<0) return;
			if (lb_itemsa2.SelectedIndex<0) return;
			try 
			{
				lb_itemsa.Tag = true;
				GmdcElement item = (GmdcElement)((SimPe.CountedListItem)lb_itemsa.Items[lb_itemsa.SelectedIndex]).Object;
				
				this.tb_itemsa2.Text = "0x"+Helper.HexString(item.Items[lb_itemsa2.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsa.Tag = null;
			}
		}

		private void SelectItemsB(object sender, System.EventArgs e)
		{
			if (lb_itemsb.Tag != null) return;
			if (lb_itemsb.SelectedIndex<0) return;
			try 
			{
				lb_itemsb.Tag = true;
				GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;

				this.tb_uk4.Text = item.ReferencedSize.ToString();
				this.tb_uk6.Text = item.ActiveElements.ToString();

				lb_itemsb2.Items.Clear();
				foreach (int i in item.ReferencedElement) lb_itemsb2.Items.Add(i);

				lb_itemsb3.Items.Clear();
				foreach (int i in item.AliasValues[0]) lb_itemsb3.Items.Add(i);

				lb_itemsb4.Items.Clear();
				foreach (int i in item.AliasValues[1]) lb_itemsb4.Items.Add(i);

				lb_itemsb5.Items.Clear();
				foreach (int i in item.AliasValues[2]) lb_itemsb5.Items.Add(i);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}
		}

		private void SelectItemsB2(object sender, System.EventArgs e)
		{
			if (lb_itemsb.Tag != null) return;
			if (lb_itemsb.SelectedIndex<0) return;
			if (lb_itemsb2.SelectedIndex<0) return;
			try 
			{
				lb_itemsb.Tag = true;
				GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;
				this.tb_itemsb2.Text = "0x"+Helper.HexString(item.ReferencedElement[lb_itemsb2.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}
		}

		private void SelectItemsB3(object sender, System.EventArgs e)
		{
			if (lb_itemsb.Tag != null) return;
			if (lb_itemsb.SelectedIndex<0) return;
			if (lb_itemsb3.SelectedIndex<0) return;
			try 
			{
				lb_itemsb.Tag = true;
				GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;
				this.tb_itemsb3.Text = "0x"+Helper.HexString(item.AliasValues[0][lb_itemsb3.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}
		}

		private void SelectItemsB4(object sender, System.EventArgs e)
		{
			if (lb_itemsb.Tag != null) return;
			if (lb_itemsb.SelectedIndex<0) return;
			if (lb_itemsb4.SelectedIndex<0) return;
			try 
			{
				lb_itemsb.Tag = true;
				GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;
				this.tb_itemsb4.Text = "0x"+Helper.HexString(item.AliasValues[1][lb_itemsb4.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}
		}

		private void SelectItemsB5(object sender, System.EventArgs e)
		{
			if (lb_itemsb.Tag != null) return;
			if (lb_itemsb.SelectedIndex<0) return;
			if (lb_itemsb5.SelectedIndex<0) return;
			try 
			{
				lb_itemsb.Tag = true;
				GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;
				this.tb_itemsb5.Text = "0x"+Helper.HexString(item.AliasValues[2][lb_itemsb5.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}
		}

		private void SelectItemsC(object sender, System.EventArgs e)
		{
			if (lb_itemsc.Tag != null) return;
			if (lb_itemsc.SelectedIndex<0) return;
			try 
			{
				lb_itemsc.Tag = true;
				GmdcGroup item = (GmdcGroup)lb_itemsc.Items[lb_itemsc.SelectedIndex];

				this.tb_uk2.Text = "0x"+Helper.HexString((uint)item.PrimitiveType);
				this.tb_uk3.Text = "0x"+Helper.HexString(item.LinkIndex);
				this.tb_opacity.Text = "0x"+Helper.HexString(item.Opacity);
				this.tb_itemsc_name.Text = item.Name;

				lb_itemsc2.Items.Clear();
				foreach (int i in item.Faces) lb_itemsc2.Items.Add(i);

				lb_itemsc3.Items.Clear();
				foreach (int i in item.UsedJoints) lb_itemsc3.Items.Add(i);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsc.Tag = null;
			}
		}

		private void SelectItemsC2(object sender, System.EventArgs e)
		{
			if (lb_itemsc.Tag != null) return;
			if (lb_itemsc.SelectedIndex<0) return;
			if (lb_itemsc2.SelectedIndex<0) return;
			try 
			{
				lb_itemsc.Tag = true;
				GmdcGroup item = (GmdcGroup)lb_itemsc.Items[lb_itemsc.SelectedIndex];				

				this.tb_itemsc2.Text = "0x"+Helper.HexString(item.Faces[lb_itemsc2.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsc.Tag = null;
			}
		}

		private void SelectItemsC3(object sender, System.EventArgs e)
		{
			if (lb_itemsc.Tag != null) return;
			if (lb_itemsc.SelectedIndex<0) return;
			if (lb_itemsc3.SelectedIndex<0) return;
			try 
			{
				lb_itemsc.Tag = true;
				GmdcGroup item = (GmdcGroup)lb_itemsc.Items[lb_itemsc.SelectedIndex];	

				this.tb_itemsc3.Text = "0x"+Helper.HexString(item.UsedJoints[lb_itemsc3.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsc.Tag = null;
			}
		}

		private void ChangeItemsC(object sender, System.EventArgs e)
		{
			if (lb_itemsc.Tag != null) return;
			if (lb_itemsc.SelectedIndex<0) return;
			try 
			{
				lb_itemsc.Tag = true;
				GmdcGroup item = (GmdcGroup)lb_itemsc.Items[lb_itemsc.SelectedIndex];

				item.PrimitiveType = (PrimitiveType)Convert.ToUInt32(this.tb_uk2.Text, 16);
				item.LinkIndex = (int)Convert.ToUInt32(this.tb_uk3.Text, 16);
				item.Opacity = Convert.ToUInt32(this.tb_opacity.Text, 16);
				item.Name = this.tb_itemsc_name.Text;

				lb_itemsc.Items[lb_itemsc.SelectedIndex] = item;

				GeometryDataContainer gdc = (GeometryDataContainer)tMesh.Tag;
				gdc.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsc.Tag = null;
			}
		}

		Ambertation.Panel3D curpn = null;
		private void Preview(object sender, System.EventArgs e)
		{
			
			if (this.tMesh.Tag != null)
			{
				WaitingScreen.Wait();
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;
				
				
				Stream xfile = gmdc.GenerateX(GetModelsExt());				
				try 
				{
					//stop all running Previews
					Ambertation.Panel3D.StopAll();

					TextureLocator tl = new TextureLocator(gmdc.Parent.Package);
					System.Collections.Hashtable txtrs = tl.GetLargestImages(tl.FindTextures(gmdc.Parent));

					Ambertation.ViewportSetting vp = null;
					if (curpn!=null) vp = curpn.ViewportSetting;
					curpn = new Ambertation.Panel3D(this.pnprev, new Point(0, 0), new Size(Math.Min(pnprev.Width, pnprev.Height), Math.Min(pnprev.Width, pnprev.Height)), xfile, txtrs, vp);
				} 
				catch (System.IO.FileNotFoundException)
				{
					WaitingScreen.Stop();
					if (MessageBox.Show("The Microsoft Managed DirectX Extensions were not found on your System. Without them, the Preview is not available.\n\nYou can install them manually, by extracting the content of the DirectX\\ManagedDX.CAB on your Sims 2 Installation CD #1. If you double click on the extracted msi File, all needed Files will be installed.\n\nYou can also let SimPE install it automatically. SimPE will download the needed Files (3.5MB) from the SimPE Homepage and install them. Do you want SimPE to download and install the Files?", "Warning", MessageBoxButtons.YesNo)==DialogResult.Yes)
					{
						if (WebUpdate.InstallMDX()) MessageBox.Show("Managed DirectX Extension were installed succesfully!");
					}
					
					return;
				}
				catch (Exception ex)
				{
					WaitingScreen.Stop();
					Helper.ExceptionMessage("", ex);
					return;
				}
				curpn.BackColor = cd.Color;
				curpn.BorderStyle = BorderStyle.FixedSingle;
				WaitingScreen.Stop();
				
			}		
		}

		/// <summary>
		/// Get all Selected Models
		/// </summary>
		/// <returns></returns>
		System.Collections.ArrayList GetModels()
		{
			System.Collections.ArrayList list = new ArrayList();
			for (int i=0; i<lbmodel.CheckedItems.Count; i++)
			{
				list.Add(lbmodel.CheckedItems[i]);
			}

			return list;
		}

		/// <summary>
		/// Get all Selected Models
		/// </summary>
		/// <returns></returns>
		GmdcGroups GetModelsExt()
		{
			GmdcGroups list = new GmdcGroups();
			for (int i=0; i<lbmodel.CheckedItems.Count; i++)
			{
				list.Add(lbmodel.CheckedItems[i]);
			}

			return list;
		}

		private void PickColor(object sender, System.EventArgs e)
		{
			if (curpn!=null) cd.Color = curpn.BackColor;
			if (cd.ShowDialog()==DialogResult.OK)
			{
				if (curpn!=null) curpn.BackColor = cd.Color;
			}
		}

		private void SeletDebugObject(object sender, System.EventArgs e)
		{
			ListBox lb = (ListBox)sender;
			if (lb.SelectedIndex>=0) 
			{
				pg.SelectedObject = ((SimPe.CountedListItem)lb.Items[lb.SelectedIndex]).Object;
				pg.Refresh();
			}
		}

		public int DefaultSelectedAxisIndex
		{
			get 
			{
				XmlRegistryKey  rkf = Helper.WindowsRegistry.PluginRegistryKey.CreateSubKey("SceneGraph");
				object o = rkf.GetValue("DefaultAxis", 1);
				return Convert.ToInt32(o);
			}
			set
			{
				XmlRegistryKey rkf = Helper.WindowsRegistry.PluginRegistryKey.CreateSubKey("SceneGraph");
				rkf.SetValue("DefaultAxis", value);
			}
		}

		private void ChangedAxis(object sender, System.EventArgs e)
		{
			if (this.tMesh.Tag == null) return;
			ComboBox cb = (ComboBox)sender;
			DefaultSelectedAxisIndex = cb.SelectedIndex;
		}

		private void FlattenAliasMap(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lb_itemsb.SelectedIndex<0) return;
			GmdcLink item = (GmdcLink)((CountedListItem)lb_itemsb.Items[lb_itemsb.SelectedIndex]).Object;
			item.Flatten();
			item.Parent.Changed = true;
			item.Parent.Refresh();
		}

		private void RebuildAbsTransform(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{				
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;
				//VectorTransformations old = (VectorTransformations)gmdc.Model.Transformations.Clone();

				try 
				{
					if (this.lb_model_trans.SelectedIndex<0) 
					{
						for (int i=0; i<gmdc.Model.Transformations.Count; i++) 
						{
							TransformNode tn = gmdc.Joints[i].AssignedTransformNode;

							if (tn!=null) 
								gmdc.Model.Transformations[i] = tn.GetEffectiveTransformation();
						}
					} 
					else 
					{
						TransformNode tn = gmdc.Joints[lb_model_trans.SelectedIndex].AssignedTransformNode;

						if (tn!=null) 
							gmdc.Model.Transformations[lb_model_trans.SelectedIndex] = tn.GetEffectiveTransformation();
					}
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}

				gmdc.Changed = true;

				/*string res = "";
				for (int i=0; i<old.Count; i++) 
				{
					if (Math.Abs((float)old[i].Translation.Y-(float)gmdc.Model.Transformations[i].Translation.Y) > 0.01) res += Helper.lbr+i.ToString();
					else if (Math.Abs((float)old[i].Translation.X-(float)gmdc.Model.Transformations[i].Translation.X) > 0.01) res += Helper.lbr+i.ToString();
					else if (Math.Abs((float)old[i].Translation.Z-(float)gmdc.Model.Transformations[i].Translation.Z) > 0.01) res += Helper.lbr+i.ToString();
				}*/

				gmdc.Refresh();
			}
		}

		private void fGeometryDataContainer_Load(object sender, System.EventArgs e)
		{
		
		}

		private void RebuildJointVertices(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;

				if (lb_subsets.SelectedIndex<0) return;
				GmdcJoint joint = gmdc.Joints[lb_subsets.SelectedIndex];				
				joint.CollectVertices();
				gmdc.Refresh();
			}
		}

		private void PreviewJoint(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs ea)
		{
			if (this.tMesh.Tag != null)
			{
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;

				if (lb_subsets.SelectedIndex<0) return;
				GmdcJoint join = gmdc.Joints[lb_subsets.SelectedIndex];
				
				gmdc = new GeometryDataContainer(null);
				GmdcGroup g = new GmdcGroup(gmdc);
				g.LinkIndex = 0;				
				GmdcLink l = new GmdcLink(gmdc);
				GmdcElement e = new GmdcElement(gmdc);
				e.Identity = ElementIdentity.Vertex;
				e.SetFormat = SetFormat.Main;
				e.BlockFormat = BlockFormat.ThreeFloat;
				l.ReferencedElement.Add(0);

				GmdcElement en = new GmdcElement(gmdc);
				en.Identity = ElementIdentity.Normal;
				en.SetFormat = SetFormat.Normals;
				en.BlockFormat = BlockFormat.ThreeFloat;
				l.ReferencedElement.Add(1);

				foreach (Vector3f v in join.Vertices)  
				{
					e.Values.Add(new SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat((float)v.X, (float)v.Y, (float)v.Z));
					en.Values.Add(new SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat(0, 0, 0));
				}
				foreach (int i in join.Items) g.Faces.Add(i);


				l.ReferencedSize = e.Values.Length;
				l.ActiveElements = 2;
				gmdc.Elements.Add(e);
				gmdc.Elements.Add(en);
				gmdc.Links.Add(l);
				gmdc.Groups.Add(g);

				Stream xfile = gmdc.GenerateX(gmdc.Groups);				
				try 
				{
					//stop all running Previews
					Ambertation.Panel3D.StopAll();

					System.Collections.Hashtable txtrs = new Hashtable();

					Ambertation.ViewportSetting vp = null;
					if (curpn!=null) vp = curpn.ViewportSetting;
					curpn = new Ambertation.Panel3D(this.pnprev, new Point(0, 0), new Size(Math.Min(pnprev.Width, pnprev.Height), Math.Min(pnprev.Width, pnprev.Height)), xfile, txtrs, vp);
				} 
				catch (Exception ex)
				{
					WaitingScreen.Stop();
					Helper.ExceptionMessage("", ex);
					return;
				}
				curpn.BackColor = cd.Color;
				curpn.BorderStyle = BorderStyle.FixedSingle;
				WaitingScreen.Stop();
				
				//this.tabControl1.SelectedIndex = 1;
				((TabControl)tMesh.Parent).SelectedTab = tMesh;
				//this.tabControl1.SelectedTab = tMesh;
				
			}
		}

		private void DeleteJoint(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;

				if (lb_subsets.SelectedIndex<0) return;
				gmdc.RemoveBone(lb_subsets.SelectedIndex);
				gmdc.Refresh();
				gmdc.Changed = true;
			}
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{							
				SimPe.Interfaces.Files.IPackageFile pkg =((GeometryDataContainer)this.tMesh.Tag).Parent.Package;

				SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.GMDC);
				int min = int.MaxValue;
				int max = 0;
				int av = 0;
				int ct = 0;

				int vmin = int.MaxValue;
				int vmax = 0;
				int vav = 0;
				int vct = 0;
				foreach(SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
				{
					GenericRcol rcol = new GenericRcol(null, false);
					rcol.ProcessData(pfd, pkg);

					GeometryDataContainer gmdc = (GeometryDataContainer)rcol.Blocks[0];

					foreach (GmdcGroup g in gmdc.Groups) 
					{
						if (g.Faces.Length>max) max = g.Faces.Length;
						if (g.Faces.Length<min) min = g.Faces.Length;	
						av += g.Faces.Length;
						ct ++;
					}					

					foreach (GmdcLink l in gmdc.Links) 
					{
						if (l.AliasValues[0].Count + l.AliasValues[1].Count + l.AliasValues[2].Count > 0 && l.ReferencedElement.Length>2)
						{
							if (MessageBox.Show(l.ReferencedElement.Count.ToString()+" "+pfd.Instance.ToString("X")+"\n\nContinue?", "alt. Links", MessageBoxButtons.YesNo)==DialogResult.No) return;
						}

						if (l.ReferencedSize>vmax) vmax = l.ReferencedSize;
						if (l.ReferencedSize<vmin) vmin = l.ReferencedSize;
						vav += l.ReferencedSize;
						vct ++;

						ct = -1;
						foreach (int k in l.ReferencedElement)
						{
							if (ct!=-1) 
							{
								if (gmdc.Elements[k].Values.Length!=ct) 
								{
									//MessageBox.Show(pfd.Instance.ToString("X"));
								}
							}

							ct = gmdc.Elements[k].Values.Length;
						}
					}
				}

				//MessageBox.Show(min.ToString()+" - ("+(av/ct).ToString()+")"+max.ToString()+" Faces\n"+vmin.ToString()+" - ("+(vav/vct).ToString()+")"+vmax.ToString()+" Vertices");
			}
		}

		private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{
				GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;

				if (lb_itemsc.SelectedIndex<0) return;
				gmdc.RemoveGroup(lb_itemsc.SelectedIndex);
				gmdc.Refresh();
				gmdc.Changed = true;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			try
			{
				if (this.tMesh.Tag != null)
				{
					GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;
					
					//Assemble a List of available Import Modules
					string f = "";
					foreach (IGmdcImporter ex in ExporterLoader.Importers) 
					{
						if (f!="") f += "|";
						f += ex.FileDescription+" Importer ";
						if ((ex.Author!="") && (ex.Author!="Quaxi") && (ex.Author!="Emily")) f += "by "+ex.Author+" ";
						f += "(*"+ex.FileExtension+")|*"+ex.FileExtension;
					}		
	
					if (f=="") {
						Helper.ExceptionMessage("", new Exception("There are no Importer Plugins available!"));
						return;
					}
					ofd.Filter = f;
					//Make .obj the Default Extension
					ofd.FilterIndex = ExporterLoader.FindFirstImporterIndexByExtension(".obj")+1;

					ofd.AddExtension = true;												
					ofd.FileName = Hashes.StripHashFromName(gmdc.Parent.FileName).Trim().ToLower();					
					if (ofd.ShowDialog() == DialogResult.OK) 
					{
						//Now perpare the Import
						IGmdcImporter importer = ExporterLoader.Importers[ofd.FilterIndex-1];	
						importer.Component.Sorting = (ElementSorting)cbaxis.Items[cbaxis.SelectedIndex];
						System.IO.FileStream meshreader = File.OpenRead(ofd.FileName);

						try 
						{
							importer.Process(meshreader, gmdc);	
							gmdc.Refresh();
							gmdc.Changed = true;
							
							if (importer.ErrorMessage!="") Helper.ExceptionMessage("", new Warning("Problems while parsing the File.", importer.ErrorMessage));
						} 
						finally 
						{
							meshreader.Close();
						}
					}
				}				
			}
			catch (Exception exception1)
			{
				Helper.ExceptionMessage("", exception1);
				return;
			}
		}

		



		private void lb_sub_item_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			/*if (lb_sub_items.Tag != null) return;
			if (lb_sub_items.SelectedIndex<0) return;
			if (lb_subsets.SelectedIndex<0) return;
			try 
			{
				lb_sub_items.Tag = true;
				GmdcJoint item = (GmdcJoint)((CountedListItem)lb_subsets.Items[lb_subsets.SelectedIndex]).Object;
				this.tb_sub_item.Text = "0x"+Helper.HexString(item.Items[lb_sub_items.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_itemsb.Tag = null;
			}*/
		}

		private void lb_subsets_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (this.lb_subsets.Tag != null) return;
			if (lb_subsets.SelectedIndex<0) return;
			try 
			{
				lb_subsets.Tag = true;
				GmdcJoint item = (GmdcJoint)((CountedListItem)lb_subsets.Items[lb_subsets.SelectedIndex]).Object;

				lb_sub_faces.Items.Clear();
				foreach (Vector3f i in item.Vertices) SimPe.CountedListItem.Add(lb_sub_faces, i);

				lb_sub_items.Items.Clear();
				foreach (int i in item.Items) SimPe.CountedListItem.Add(lb_sub_items, i);				
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lb_subsets.Tag = null;
			}
		}

		private void Export(object sender, System.EventArgs e)
		{
			try
			{
				if (this.tMesh.Tag != null)
				{
					GeometryDataContainer gmdc = (GeometryDataContainer) this.tMesh.Tag;
					
					//Assemble a List of available Export Modules
					string f = "";
					foreach (IGmdcExporter ex in ExporterLoader.Exporters) 
					{
						if (f!="") f += "|";
						f += ex.FileDescription+" Exporter ";
						if ((ex.Author!="") && (ex.Author!="Quaxi") && (ex.Author!="Emily")) f += "by "+ex.Author+" ";
						f += "(*"+ex.FileExtension+")|*"+ex.FileExtension;
					}				
			
					if (f=="") 
					{
						Helper.ExceptionMessage("", new Exception("There are no Exporter Plugins available!"));
						return;
					}
					sfd.Filter = f;
					//Make .obj the Default Extension
					sfd.FilterIndex = ExporterLoader.FindFirstIndexByExtension(".obj")+1;

					sfd.AddExtension = true;												
					sfd.FileName = Hashes.StripHashFromName(gmdc.Parent.FileName).Trim().ToLower();					
					if (sfd.ShowDialog() == DialogResult.OK) 
					{
						//Now perfor the Export
						IGmdcExporter exporter = ExporterLoader.Exporters[sfd.FilterIndex-1];
						exporter.Component.Sorting = (ElementSorting)cbaxis.Items[cbaxis.SelectedIndex];
						if (!sfd.FileName.Trim().ToLower().EndsWith(exporter.FileExtension.Trim().ToLower())) sfd.FileName += exporter.FileExtension;

						Stream s = exporter.Process(gmdc, GetModelsExt());		
						StreamReader sr = new StreamReader(s);
						
						System.IO.StreamWriter meshwriter = File.CreateText(sfd.FileName);						
						meshwriter.Write(sr.ReadToEnd());
						meshwriter.Close();
					}
				}				
			}
			catch (Exception exception1)
			{
				Helper.ExceptionMessage("", exception1);
				return;
			}
		}

		

		private void SeletDebugObject(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tMesh.Tag != null)
			{
				GeometryDataContainer ext1 = (GeometryDataContainer) this.tMesh.Tag;
				pg.SelectedObject = ext1.Model;
			}
		}
	}
}
