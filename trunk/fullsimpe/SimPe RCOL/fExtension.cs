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
	/// Zusammenfassung für fExtension.
	/// </summary>
	public class fExtension : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tExtension;
		private System.Windows.Forms.GroupBox groupBox10;
		internal System.Windows.Forms.TextBox tb_ver;
		private System.Windows.Forms.Label label28;
		internal System.Windows.Forms.TextBox tb_type;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.TextBox tb_name;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ListBox lb_items;
		private System.Windows.Forms.GroupBox gbval;
		private System.Windows.Forms.GroupBox gbtrans;
		private System.Windows.Forms.GroupBox gbrot;
		private System.Windows.Forms.GroupBox gbbin;
		private System.Windows.Forms.GroupBox gbstr;
		private System.Windows.Forms.GroupBox gbar;
		private System.Windows.Forms.Button btedit;
		internal System.Windows.Forms.GroupBox gbIems;
		private System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel lldel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tb_itemname;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.TextBox tbstr;
		private System.Windows.Forms.TextBox tbbin;
		private System.Windows.Forms.TextBox tbtrans2;
		private System.Windows.Forms.TextBox tbtrans3;
		private System.Windows.Forms.TextBox tbtrans1;
		private System.Windows.Forms.TextBox tbrot1;
		private System.Windows.Forms.TextBox tbrot3;
		private System.Windows.Forms.TextBox tbrot2;
		private System.Windows.Forms.TextBox tbrot4;
		private System.Windows.Forms.GroupBox gbfloat;
		private System.Windows.Forms.TextBox tbfloat;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fExtension()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			HideAll();
			cbtype.Items.Add(ExtensionItem.ItemTypes.Array);
			cbtype.Items.Add(ExtensionItem.ItemTypes.Binary);
			cbtype.Items.Add(ExtensionItem.ItemTypes.Float);
			cbtype.Items.Add(ExtensionItem.ItemTypes.Rotation);
			cbtype.Items.Add(ExtensionItem.ItemTypes.String);
			cbtype.Items.Add(ExtensionItem.ItemTypes.Translation);
			cbtype.Items.Add(ExtensionItem.ItemTypes.Value);
			cbtype.SelectedIndex = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(fExtension));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tExtension = new System.Windows.Forms.TabPage();
			this.gbIems = new System.Windows.Forms.GroupBox();
			this.gbval = new System.Windows.Forms.GroupBox();
			this.tbval = new System.Windows.Forms.TextBox();
			this.tb_itemname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.gbar = new System.Windows.Forms.GroupBox();
			this.btedit = new System.Windows.Forms.Button();
			this.gbstr = new System.Windows.Forms.GroupBox();
			this.tbstr = new System.Windows.Forms.TextBox();
			this.gbbin = new System.Windows.Forms.GroupBox();
			this.tbbin = new System.Windows.Forms.TextBox();
			this.gbrot = new System.Windows.Forms.GroupBox();
			this.tbrot4 = new System.Windows.Forms.TextBox();
			this.tbrot1 = new System.Windows.Forms.TextBox();
			this.tbrot3 = new System.Windows.Forms.TextBox();
			this.tbrot2 = new System.Windows.Forms.TextBox();
			this.gbtrans = new System.Windows.Forms.GroupBox();
			this.tbtrans1 = new System.Windows.Forms.TextBox();
			this.tbtrans3 = new System.Windows.Forms.TextBox();
			this.tbtrans2 = new System.Windows.Forms.TextBox();
			this.lb_items = new System.Windows.Forms.ListBox();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.tb_name = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_type = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tb_ver = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.gbfloat = new System.Windows.Forms.GroupBox();
			this.tbfloat = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tExtension.SuspendLayout();
			this.gbIems.SuspendLayout();
			this.gbval.SuspendLayout();
			this.gbar.SuspendLayout();
			this.gbstr.SuspendLayout();
			this.gbbin.SuspendLayout();
			this.gbrot.SuspendLayout();
			this.gbtrans.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.gbfloat.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tExtension);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 328);
			this.tabControl1.TabIndex = 0;
			// 
			// tExtension
			// 
			this.tExtension.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tExtension.Controls.Add(this.gbIems);
			this.tExtension.Controls.Add(this.groupBox10);
			this.tExtension.Location = new System.Drawing.Point(4, 22);
			this.tExtension.Name = "tExtension";
			this.tExtension.Size = new System.Drawing.Size(792, 302);
			this.tExtension.TabIndex = 0;
			this.tExtension.Text = "Extension";
			// 
			// gbIems
			// 
			this.gbIems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gbIems.Controls.Add(this.gbfloat);
			this.gbIems.Controls.Add(this.gbval);
			this.gbIems.Controls.Add(this.tb_itemname);
			this.gbIems.Controls.Add(this.label3);
			this.gbIems.Controls.Add(this.lldel);
			this.gbIems.Controls.Add(this.linkLabel1);
			this.gbIems.Controls.Add(this.cbtype);
			this.gbIems.Controls.Add(this.gbar);
			this.gbIems.Controls.Add(this.gbstr);
			this.gbIems.Controls.Add(this.gbbin);
			this.gbIems.Controls.Add(this.gbrot);
			this.gbIems.Controls.Add(this.gbtrans);
			this.gbIems.Controls.Add(this.lb_items);
			this.gbIems.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbIems.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbIems.Location = new System.Drawing.Point(248, 8);
			this.gbIems.Name = "gbIems";
			this.gbIems.Size = new System.Drawing.Size(536, 288);
			this.gbIems.TabIndex = 13;
			this.gbIems.TabStop = false;
			this.gbIems.Text = "Items";
			// 
			// gbval
			// 
			this.gbval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbval.Controls.Add(this.tbval);
			this.gbval.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbval.Location = new System.Drawing.Point(160, 216);
			this.gbval.Name = "gbval";
			this.gbval.Size = new System.Drawing.Size(120, 56);
			this.gbval.TabIndex = 1;
			this.gbval.TabStop = false;
			this.gbval.Text = "Value";
			// 
			// tbval
			// 
			this.tbval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbval.Location = new System.Drawing.Point(16, 24);
			this.tbval.Name = "tbval";
			this.tbval.Size = new System.Drawing.Size(88, 21);
			this.tbval.TabIndex = 0;
			this.tbval.Text = "0x00000000";
			this.tbval.TextChanged += new System.EventHandler(this.ValChange);
			// 
			// tb_itemname
			// 
			this.tb_itemname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tb_itemname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_itemname.Location = new System.Drawing.Point(288, 40);
			this.tb_itemname.Name = "tb_itemname";
			this.tb_itemname.Size = new System.Drawing.Size(240, 21);
			this.tb_itemname.TabIndex = 11;
			this.tb_itemname.Text = "";
			this.tb_itemname.TextChanged += new System.EventHandler(this.ChangeName);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(280, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Name:";
			// 
			// lldel
			// 
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lldel.AutoSize = true;
			this.lldel.Location = new System.Drawing.Point(488, 264);
			this.lldel.Name = "lldel";
			this.lldel.Size = new System.Drawing.Size(44, 17);
			this.lldel.TabIndex = 9;
			this.lldel.TabStop = true;
			this.lldel.Text = "delete";
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteItem);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(456, 264);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(28, 17);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "add";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddItem);
			// 
			// cbtype
			// 
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbtype.Location = new System.Drawing.Point(280, 240);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(248, 21);
			this.cbtype.TabIndex = 7;
			// 
			// gbar
			// 
			this.gbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbar.Controls.Add(this.btedit);
			this.gbar.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbar.Location = new System.Drawing.Point(16, 216);
			this.gbar.Name = "gbar";
			this.gbar.Size = new System.Drawing.Size(136, 56);
			this.gbar.TabIndex = 6;
			this.gbar.TabStop = false;
			this.gbar.Text = "Array";
			// 
			// btedit
			// 
			this.btedit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btedit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btedit.Location = new System.Drawing.Point(16, 24);
			this.btedit.Name = "btedit";
			this.btedit.Size = new System.Drawing.Size(104, 23);
			this.btedit.TabIndex = 0;
			this.btedit.Text = "Edit";
			this.btedit.Click += new System.EventHandler(this.OpenArrayEditor);
			// 
			// gbstr
			// 
			this.gbstr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbstr.Controls.Add(this.tbstr);
			this.gbstr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbstr.Location = new System.Drawing.Point(280, 64);
			this.gbstr.Name = "gbstr";
			this.gbstr.Size = new System.Drawing.Size(240, 56);
			this.gbstr.TabIndex = 5;
			this.gbstr.TabStop = false;
			this.gbstr.Text = "String";
			// 
			// tbstr
			// 
			this.tbstr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbstr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbstr.Location = new System.Drawing.Point(16, 24);
			this.tbstr.Name = "tbstr";
			this.tbstr.Size = new System.Drawing.Size(216, 21);
			this.tbstr.TabIndex = 1;
			this.tbstr.Text = "";
			this.tbstr.TextChanged += new System.EventHandler(this.StrChange);
			// 
			// gbbin
			// 
			this.gbbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbbin.Controls.Add(this.tbbin);
			this.gbbin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbbin.Location = new System.Drawing.Point(16, 40);
			this.gbbin.Name = "gbbin";
			this.gbbin.Size = new System.Drawing.Size(248, 80);
			this.gbbin.TabIndex = 4;
			this.gbbin.TabStop = false;
			this.gbbin.Text = "Binary";
			// 
			// tbbin
			// 
			this.tbbin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbbin.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbbin.Location = new System.Drawing.Point(16, 26);
			this.tbbin.Multiline = true;
			this.tbbin.Name = "tbbin";
			this.tbbin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbbin.Size = new System.Drawing.Size(216, 40);
			this.tbbin.TabIndex = 2;
			this.tbbin.Text = "";
			this.tbbin.TextChanged += new System.EventHandler(this.BinChange);
			// 
			// gbrot
			// 
			this.gbrot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbrot.Controls.Add(this.tbrot4);
			this.gbrot.Controls.Add(this.tbrot1);
			this.gbrot.Controls.Add(this.tbrot3);
			this.gbrot.Controls.Add(this.tbrot2);
			this.gbrot.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbrot.Location = new System.Drawing.Point(280, 136);
			this.gbrot.Name = "gbrot";
			this.gbrot.Size = new System.Drawing.Size(224, 80);
			this.gbrot.TabIndex = 3;
			this.gbrot.TabStop = false;
			this.gbrot.Text = "Rotation";
			// 
			// tbrot4
			// 
			this.tbrot4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrot4.Location = new System.Drawing.Point(120, 48);
			this.tbrot4.Name = "tbrot4";
			this.tbrot4.Size = new System.Drawing.Size(88, 21);
			this.tbrot4.TabIndex = 7;
			this.tbrot4.Text = "0x00000000";
			this.tbrot4.TextChanged += new System.EventHandler(this.RotChange);
			// 
			// tbrot1
			// 
			this.tbrot1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrot1.Location = new System.Drawing.Point(16, 24);
			this.tbrot1.Name = "tbrot1";
			this.tbrot1.Size = new System.Drawing.Size(88, 21);
			this.tbrot1.TabIndex = 6;
			this.tbrot1.Text = "0x00000000";
			this.tbrot1.TextChanged += new System.EventHandler(this.RotChange);
			// 
			// tbrot3
			// 
			this.tbrot3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrot3.Location = new System.Drawing.Point(16, 48);
			this.tbrot3.Name = "tbrot3";
			this.tbrot3.Size = new System.Drawing.Size(88, 21);
			this.tbrot3.TabIndex = 5;
			this.tbrot3.Text = "0x00000000";
			this.tbrot3.TextChanged += new System.EventHandler(this.RotChange);
			// 
			// tbrot2
			// 
			this.tbrot2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbrot2.Location = new System.Drawing.Point(120, 24);
			this.tbrot2.Name = "tbrot2";
			this.tbrot2.Size = new System.Drawing.Size(88, 21);
			this.tbrot2.TabIndex = 4;
			this.tbrot2.Text = "0x00000000";
			this.tbrot2.TextChanged += new System.EventHandler(this.RotChange);
			// 
			// gbtrans
			// 
			this.gbtrans.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbtrans.Controls.Add(this.tbtrans1);
			this.gbtrans.Controls.Add(this.tbtrans3);
			this.gbtrans.Controls.Add(this.tbtrans2);
			this.gbtrans.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbtrans.Location = new System.Drawing.Point(16, 120);
			this.gbtrans.Name = "gbtrans";
			this.gbtrans.Size = new System.Drawing.Size(224, 80);
			this.gbtrans.TabIndex = 2;
			this.gbtrans.TabStop = false;
			this.gbtrans.Text = "Translation";
			// 
			// tbtrans1
			// 
			this.tbtrans1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbtrans1.Location = new System.Drawing.Point(16, 24);
			this.tbtrans1.Name = "tbtrans1";
			this.tbtrans1.Size = new System.Drawing.Size(88, 21);
			this.tbtrans1.TabIndex = 3;
			this.tbtrans1.Text = "0x00000000";
			this.tbtrans1.TextChanged += new System.EventHandler(this.TransChange);
			// 
			// tbtrans3
			// 
			this.tbtrans3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbtrans3.Location = new System.Drawing.Point(16, 48);
			this.tbtrans3.Name = "tbtrans3";
			this.tbtrans3.Size = new System.Drawing.Size(88, 21);
			this.tbtrans3.TabIndex = 2;
			this.tbtrans3.Text = "0x00000000";
			this.tbtrans3.TextChanged += new System.EventHandler(this.TransChange);
			// 
			// tbtrans2
			// 
			this.tbtrans2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbtrans2.Location = new System.Drawing.Point(120, 24);
			this.tbtrans2.Name = "tbtrans2";
			this.tbtrans2.Size = new System.Drawing.Size(88, 21);
			this.tbtrans2.TabIndex = 1;
			this.tbtrans2.Text = "0x00000000";
			this.tbtrans2.TextChanged += new System.EventHandler(this.TransChange);
			// 
			// lb_items
			// 
			this.lb_items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb_items.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lb_items.HorizontalScrollbar = true;
			this.lb_items.IntegralHeight = false;
			this.lb_items.Location = new System.Drawing.Point(8, 24);
			this.lb_items.Name = "lb_items";
			this.lb_items.Size = new System.Drawing.Size(264, 256);
			this.lb_items.TabIndex = 0;
			this.lb_items.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
			// 
			// groupBox10
			// 
			this.groupBox10.Controls.Add(this.tb_name);
			this.groupBox10.Controls.Add(this.label2);
			this.groupBox10.Controls.Add(this.tb_type);
			this.groupBox10.Controls.Add(this.label1);
			this.groupBox10.Controls.Add(this.tb_ver);
			this.groupBox10.Controls.Add(this.label28);
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(8, 8);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(232, 112);
			this.groupBox10.TabIndex = 12;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Settings";
			// 
			// tb_name
			// 
			this.tb_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_name.Location = new System.Drawing.Point(16, 80);
			this.tb_name.Name = "tb_name";
			this.tb_name.Size = new System.Drawing.Size(200, 21);
			this.tb_name.TabIndex = 28;
			this.tb_name.Text = "0x00";
			this.tb_name.TextChanged += new System.EventHandler(this.GNSettingsChange);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 17);
			this.label2.TabIndex = 27;
			this.label2.Text = "Name";
			// 
			// tb_type
			// 
			this.tb_type.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_type.Location = new System.Drawing.Point(128, 40);
			this.tb_type.Name = "tb_type";
			this.tb_type.Size = new System.Drawing.Size(88, 21);
			this.tb_type.TabIndex = 26;
			this.tb_type.Text = "0x00";
			this.tb_type.TextChanged += new System.EventHandler(this.GNSettingsChange);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(120, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 25;
			this.label1.Text = "Typecode:";
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
			// gbfloat
			// 
			this.gbfloat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbfloat.Controls.Add(this.tbfloat);
			this.gbfloat.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbfloat.Location = new System.Drawing.Point(416, 128);
			this.gbfloat.Name = "gbfloat";
			this.gbfloat.Size = new System.Drawing.Size(120, 56);
			this.gbfloat.TabIndex = 2;
			this.gbfloat.TabStop = false;
			this.gbfloat.Text = "Float Value";
			// 
			// tbfloat
			// 
			this.tbfloat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbfloat.Location = new System.Drawing.Point(16, 24);
			this.tbfloat.Name = "tbfloat";
			this.tbfloat.Size = new System.Drawing.Size(88, 21);
			this.tbfloat.TabIndex = 0;
			this.tbfloat.Text = "0";
			this.tbfloat.TextChanged += new System.EventHandler(this.FloatChange);
			// 
			// fExtension
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(832, 342);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fExtension";
			this.ShowInTaskbar = false;
			this.Text = "Sub Array Editor";
			this.tabControl1.ResumeLayout(false);
			this.tExtension.ResumeLayout(false);
			this.gbIems.ResumeLayout(false);
			this.gbval.ResumeLayout(false);
			this.gbar.ResumeLayout(false);
			this.gbstr.ResumeLayout(false);
			this.gbbin.ResumeLayout(false);
			this.gbrot.ResumeLayout(false);
			this.gbtrans.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.gbfloat.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void GNSettingsChange(object sender, System.EventArgs e)
		{
			if (tExtension.Tag==null) return;
			try 
			{
				Extension ext = (Extension)tExtension.Tag;

				ext.Version = Convert.ToUInt32(tb_ver.Text, 16);
				ext.VarName = tb_name.Text;
				ext.TypeCode = Convert.ToByte(tb_type.Text, 16);
				ext.Changed = true;
				lldel.Enabled = false;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		internal void HideAll()
		{
			this.gbval.Visible = false;
			this.gbar.Visible = false;
			this.gbfloat.Visible = false;
			this.gbbin.Visible = false;
			this.gbrot.Visible = false;
			this.gbstr.Visible = false;
			this.gbtrans.Visible = false;
		}

		internal void ShowGroup(GroupBox gb)
		{
			gb.Left = this.lb_items.Left + this.lb_items.Width + 8;
			gb.Top = this.tb_itemname.Top + tb_itemname.Height + 4;
			gb.Visible = true;
		}

		private void SelectItem(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			HideAll();
			if (lb_items.SelectedIndex<0) return;
			lldel.Enabled = true;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				tb_itemname.Text = ei.Name;

				switch (ei.Typecode)
				{
					case ExtensionItem.ItemTypes.Value: 
					{
						tbval.Text = "0x"+Helper.HexString((uint)ei.Value);
						ShowGroup(this.gbval);
						break;
					}
					case ExtensionItem.ItemTypes.Float: 
					{
						tbfloat.Text = ei.Single.ToString();;
						ShowGroup(this.gbfloat);
						break;
					}
					case ExtensionItem.ItemTypes.Translation: 
					{
						tbtrans1.Text = ei.Translation.X.ToString();
						tbtrans2.Text = ei.Translation.Y.ToString();
						tbtrans3.Text = ei.Translation.Z.ToString();
						ShowGroup(this.gbtrans);
						break;
					}
					case ExtensionItem.ItemTypes.String: 
					{
						tbstr.Text = ei.String;
						ShowGroup(this.gbstr);
						break;
					}
					case ExtensionItem.ItemTypes.Rotation: 
					{
						tbrot1.Text = ei.Rotation.X.ToString();
						tbrot2.Text = ei.Rotation.Y.ToString();
						tbrot3.Text = ei.Rotation.Z.ToString();
						tbrot4.Text = ei.Rotation.R.ToString();
						ShowGroup(this.gbrot);
						break;
					}
					case ExtensionItem.ItemTypes.Binary: 
					{
						tbbin.Text = Helper.BytesToHexList(ei.Data);
						ShowGroup(this.gbbin);
						break;
					}
					case ExtensionItem.ItemTypes.Array: 
					{
						ShowGroup(this.gbar);
						break;
					}
				} //switch
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void OpenArrayEditor(object sender, System.EventArgs e)
		{
			try 
			{
				fExtension fe = new fExtension();
				fe.gbIems.Parent = fe;
				fe.tabControl1.Visible = false;

				
				fe.gbIems.Left = 8;
				fe.gbIems.Top = 8;
				//fe.Width = fe.gbIems.Width + 24;
				fe.gbIems.Width = fe.Width - 24;
				fe.gbIems.Height = fe.ClientRectangle.Height - 16;
				fe.gbIems.BackColor = SystemColors.Control;

				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				fe.gbIems.Tag = ei.Items;
				foreach (ExtensionItem i in ei.Items) fe.lb_items.Items.Add(i);
			
				fe.ShowDialog();

				ei.Items = (ExtensionItem[])fe.gbIems.Tag;
				lb_items.Items[lb_items.SelectedIndex] = ei;
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void DeleteItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				ExtensionItem[] list = (ExtensionItem[])gbIems.Tag;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				
				
				list = (ExtensionItem[])Helper.Delete(list, ei);
				gbIems.Tag = list;
				lb_items.Items.Remove(ei);

				//write back to the wrapper
				if (tExtension.Tag != null) 
				{
					Extension ext = (Extension)tExtension.Tag;
					ext.Items = list;
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				ExtensionItem[] list = (ExtensionItem[])gbIems.Tag;
				ExtensionItem ei = new ExtensionItem();
				ei.Typecode = (ExtensionItem.ItemTypes)cbtype.Items[cbtype.SelectedIndex];
				
				list = (ExtensionItem[])Helper.Add(list, ei);
				gbIems.Tag = list;
				lb_items.Items.Add(ei);

				//write back to the wrapper
				if (tExtension.Tag != null) 
				{
					Extension ext = (Extension)tExtension.Tag;
					ext.Items = list;
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void ChangeName(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Name = tb_itemname.Text;

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void ValChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Value = (int)Convert.ToUInt32(tbval.Text, 16);

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void FloatChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Single = Convert.ToSingle(tbfloat.Text);

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void TransChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Translation.X = Convert.ToInt32(tbtrans1.Text);
				ei.Translation.Y = Convert.ToInt32(tbtrans2.Text);
				ei.Translation.Z = Convert.ToInt32(tbtrans3.Text);

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void RotChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Rotation.X = Convert.ToInt32(tbrot1.Text);
				ei.Rotation.Y = Convert.ToInt32(tbrot2.Text);
				ei.Rotation.Z = Convert.ToInt32(tbrot3.Text);
				ei.Rotation.R = Convert.ToInt32(tbrot4.Text);

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void StrChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.String = tbstr.Text;

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}

		private void BinChange(object sender, System.EventArgs e)
		{
			if (tb_itemname.Tag != null) return;
			if (lb_items.SelectedIndex<0) return;
			try 
			{
				tb_itemname.Tag = true;
				ExtensionItem ei = (ExtensionItem)lb_items.Items[lb_items.SelectedIndex];
				ei.Data= Helper.HexListToBytes(tbbin.Text);

				lb_items.Items[lb_items.SelectedIndex] = ei;
			}
			catch (Exception){} 
			finally 
			{
				tb_itemname.Tag = null;
			}
		}
	}
}
