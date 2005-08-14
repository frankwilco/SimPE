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
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MatdForm.
	/// </summary>
	public class MatdForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MatdForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			llscan.Visible = Helper.DebugMode;
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
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.tbdsc = new System.Windows.Forms.TextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.llscan = new System.Windows.Forms.LinkLabel();
			this.lbprop = new System.Windows.Forms.ListBox();
			this.gbprop = new System.Windows.Forms.GroupBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.tbval = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tblistfile = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbfl = new System.Windows.Forms.ListBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.groupBox10 = new System.Windows.Forms.GroupBox();
			this.tb_ver = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.tGrid = new System.Windows.Forms.TabPage();
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.gbprop.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.groupBox10.SuspendLayout();
			this.tGrid.SuspendLayout();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(48, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(12, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 17);
			this.label4.TabIndex = 15;
			this.label4.Text = "Description:";
			// 
			// tbtype
			// 
			this.tbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbtype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbtype.Location = new System.Drawing.Point(88, 72);
			this.tbtype.Name = "tbtype";
			this.tbtype.Size = new System.Drawing.Size(624, 21);
			this.tbtype.TabIndex = 14;
			this.tbtype.Text = "";
			this.tbtype.TextChanged += new System.EventHandler(this.FileNameChanged);
			// 
			// tbdsc
			// 
			this.tbdsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbdsc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbdsc.Location = new System.Drawing.Point(88, 48);
			this.tbdsc.Name = "tbdsc";
			this.tbdsc.Size = new System.Drawing.Size(624, 21);
			this.tbdsc.TabIndex = 13;
			this.tbdsc.Text = "";
			this.tbdsc.TextChanged += new System.EventHandler(this.FileNameChanged);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tGrid);
			this.tabControl1.Location = new System.Drawing.Point(16, 32);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(752, 264);
			this.tabControl1.TabIndex = 21;
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TxmtChangeTab);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.White;
			this.tabPage1.Controls.Add(this.llscan);
			this.tabPage1.Controls.Add(this.lbprop);
			this.tabPage1.Controls.Add(this.gbprop);
			this.tabPage1.Controls.Add(this.linkLabel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(744, 238);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Properties";
			// 
			// llscan
			// 
			this.llscan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.llscan.Location = new System.Drawing.Point(432, 208);
			this.llscan.Name = "llscan";
			this.llscan.TabIndex = 5;
			this.llscan.TabStop = true;
			this.llscan.Text = "scan";
			this.llscan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llscan_LinkClicked);
			// 
			// lbprop
			// 
			this.lbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbprop.IntegralHeight = false;
			this.lbprop.Location = new System.Drawing.Point(8, 8);
			this.lbprop.Name = "lbprop";
			this.lbprop.Size = new System.Drawing.Size(416, 224);
			this.lbprop.TabIndex = 3;
			this.lbprop.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
			// 
			// gbprop
			// 
			this.gbprop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbprop.Controls.Add(this.lldel);
			this.gbprop.Controls.Add(this.lladd);
			this.gbprop.Controls.Add(this.tbval);
			this.gbprop.Controls.Add(this.tbname);
			this.gbprop.Controls.Add(this.label2);
			this.gbprop.Controls.Add(this.label1);
			this.gbprop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbprop.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbprop.Location = new System.Drawing.Point(432, 8);
			this.gbprop.Name = "gbprop";
			this.gbprop.Size = new System.Drawing.Size(296, 104);
			this.gbprop.TabIndex = 4;
			this.gbprop.TabStop = false;
			this.gbprop.Text = "Property";
			// 
			// lldel
			// 
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lldel.AutoSize = true;
			this.lldel.Location = new System.Drawing.Point(244, 80);
			this.lldel.Name = "lldel";
			this.lldel.Size = new System.Drawing.Size(44, 17);
			this.lldel.TabIndex = 5;
			this.lldel.TabStop = true;
			this.lldel.Text = "delete";
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletItem);
			// 
			// lladd
			// 
			this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lladd.AutoSize = true;
			this.lladd.Location = new System.Drawing.Point(208, 80);
			this.lladd.Name = "lladd";
			this.lladd.Size = new System.Drawing.Size(28, 17);
			this.lladd.TabIndex = 4;
			this.lladd.TabStop = true;
			this.lladd.Text = "add";
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddItem);
			// 
			// tbval
			// 
			this.tbval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbval.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbval.Location = new System.Drawing.Point(64, 48);
			this.tbval.Name = "tbval";
			this.tbval.Size = new System.Drawing.Size(224, 21);
			this.tbval.TabIndex = 3;
			this.tbval.Text = "";
			this.tbval.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(64, 24);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(224, 21);
			this.tbname.TabIndex = 2;
			this.tbname.Text = "";
			this.tbname.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Value:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.White;
			this.tabPage2.Controls.Add(this.linkLabel4);
			this.tabPage2.Controls.Add(this.linkLabel3);
			this.tabPage2.Controls.Add(this.tblistfile);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.lbfl);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(744, 238);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "File List";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel4.Location = new System.Drawing.Point(656, 48);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(28, 17);
			this.linkLabel4.TabIndex = 8;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "add";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Add);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel3.Location = new System.Drawing.Point(692, 48);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(44, 17);
			this.linkLabel3.TabIndex = 7;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "delete";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Delete);
			// 
			// tblistfile
			// 
			this.tblistfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tblistfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tblistfile.Location = new System.Drawing.Point(440, 24);
			this.tblistfile.Name = "tblistfile";
			this.tblistfile.Size = new System.Drawing.Size(296, 21);
			this.tblistfile.TabIndex = 6;
			this.tblistfile.Text = "";
			this.tblistfile.TextChanged += new System.EventHandler(this.ChangeListFile);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(432, 8);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(67, 17);
			this.label6.TabIndex = 5;
			this.label6.Text = "Filename:";
			// 
			// lbfl
			// 
			this.lbfl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.lbfl.HorizontalScrollbar = true;
			this.lbfl.IntegralHeight = false;
			this.lbfl.Location = new System.Drawing.Point(8, 8);
			this.lbfl.Name = "lbfl";
			this.lbfl.Size = new System.Drawing.Size(416, 224);
			this.lbfl.TabIndex = 4;
			this.lbfl.SelectedIndexChanged += new System.EventHandler(this.SelectListFile);
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.White;
			this.tabPage3.Controls.Add(this.groupBox10);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(744, 238);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "cMeterialDefinition";
			// 
			// groupBox10
			// 
			this.groupBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox10.Controls.Add(this.tb_ver);
			this.groupBox10.Controls.Add(this.label28);
			this.groupBox10.Controls.Add(this.label4);
			this.groupBox10.Controls.Add(this.tbtype);
			this.groupBox10.Controls.Add(this.tbdsc);
			this.groupBox10.Controls.Add(this.label5);
			this.groupBox10.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox10.Location = new System.Drawing.Point(8, 8);
			this.groupBox10.Name = "groupBox10";
			this.groupBox10.Size = new System.Drawing.Size(720, 104);
			this.groupBox10.TabIndex = 17;
			this.groupBox10.TabStop = false;
			this.groupBox10.Text = "Settings";
			// 
			// tb_ver
			// 
			this.tb_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_ver.Location = new System.Drawing.Point(88, 24);
			this.tb_ver.Name = "tb_ver";
			this.tb_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_ver.TabIndex = 24;
			this.tb_ver.Text = "0x00000000";
			this.tb_ver.TextChanged += new System.EventHandler(this.FileNameChanged);
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label28.Location = new System.Drawing.Point(33, 24);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(52, 17);
			this.label28.TabIndex = 23;
			this.label28.Text = "Version:";
			// 
			// tGrid
			// 
			this.tGrid.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tGrid.Controls.Add(this.pg);
			this.tGrid.Location = new System.Drawing.Point(4, 22);
			this.tGrid.Name = "tGrid";
			this.tGrid.Size = new System.Drawing.Size(744, 238);
			this.tGrid.TabIndex = 3;
			this.tGrid.Text = "Categorized Properties";
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
			this.pg.Location = new System.Drawing.Point(8, 8);
			this.pg.Name = "pg";
			this.pg.Size = new System.Drawing.Size(728, 224);
			this.pg.TabIndex = 0;
			this.pg.Text = "MaterialDefinition Properties";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.Click += new System.EventHandler(this.pg_Click);
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_PropertyValueChanged);
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(432, 184);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(50, 17);
			this.linkLabel1.TabIndex = 6;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "sort List";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// MatdForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 518);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "MatdForm";
			this.Text = "MatdForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.gbprop.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.groupBox10.ResumeLayout(false);
			this.tGrid.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.ListBox lbprop;
		internal System.Windows.Forms.GroupBox gbprop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.LinkLabel lladd;
		internal System.Windows.Forms.LinkLabel lldel;
		internal System.Windows.Forms.TextBox tbdsc;
		internal System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabControl tabControl1;
		internal System.Windows.Forms.TabPage tabPage1;
		internal System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.ListBox lbfl;
		private System.Windows.Forms.TextBox tblistfile;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.GroupBox groupBox10;
		internal System.Windows.Forms.TextBox tb_ver;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.LinkLabel llscan;
		private System.Windows.Forms.PropertyGrid pg;
		internal System.Windows.Forms.TabPage tGrid;
		private System.Windows.Forms.LinkLabel linkLabel1;
		internal System.Windows.Forms.TabPage tabPage3;


		private void SelectItem(object sender, System.EventArgs e)
		{
			lldel.Enabled = false;
			if (lbprop.SelectedIndex<0) return;
			lldel.Enabled = true;

			try 
			{
				tbname.Tag = true;
				SimPe.Plugin.MaterialDefinitionProperty prop = (SimPe.Plugin.MaterialDefinitionProperty)lbprop.Items[lbprop.SelectedIndex];
				this.tbname.Text = prop.Name;
				this.tbval.Text = prop.Value;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		protected void Change()
		{
			if (this.tabPage3.Tag==null) return;
			if (this.lbprop.SelectedIndex<0) return;
			try 
			{
				tbname.Tag = true;								
				SimPe.Plugin.MaterialDefinitionProperty prop = (SimPe.Plugin.MaterialDefinitionProperty)lbprop.Items[lbprop.SelectedIndex];

				prop.Name = tbname.Text;
				prop.Value = tbval.Text;

				lbprop.Items[lbprop.SelectedIndex] = prop;

				MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
				md.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbname.Tag!=null) return;
			if (this.lbprop.SelectedIndex>=0) Change();

		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			SimPe.Plugin.MaterialDefinitionProperty prop = new MaterialDefinitionProperty();
			lbprop.Items.Add(prop);

			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Properties = (MaterialDefinitionProperty[])Helper.Add(md.Properties, prop);

			md.Changed = true;
		}

		private void DeletItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (lbprop.SelectedIndex<0) return;

			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Properties = (MaterialDefinitionProperty[])Helper.Delete(md.Properties, lbprop.Items[lbprop.SelectedIndex]);
			md.Changed = true;
			lbprop.Items.Remove(lbprop.Items[lbprop.SelectedIndex]);

			
		}

		private void FileNameChanged(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (tbname.Tag!=null) return;
			try 
			{
				tbname.Tag = true;
				MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
				
				md.Version = Convert.ToUInt32(this.tb_ver.Text, 16);
				md.FileDescription = tbdsc.Text;
				md.MatterialType = tbtype.Text;

				md.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			}
			
			finally 
			{
				tbname.Tag = null;
			}
		}

		private void SelectListFile(object sender, System.EventArgs e)
		{
			if (tblistfile.Tag!=null) return;
			if (lbfl.SelectedIndex<0) return;
			
			try 
			{
				tblistfile.Tag = true;
				tblistfile.Text = (string)lbfl.Items[lbfl.SelectedIndex];
			} 
			catch (Exception) {}
			finally 
			{
				tblistfile.Tag = null;
			}
		}

		private void ChangeListFile(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (tblistfile.Tag!=null) return;
			if (lbfl.SelectedIndex<0) return;
			
			try 
			{
				tblistfile.Tag = true;
				lbfl.Items[lbfl.SelectedIndex] = tblistfile.Text;

				MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
				md.Listing[lbfl.SelectedIndex] = tblistfile.Text;

				md.Changed = true;
			} 
			catch (Exception) {}
			finally 
			{
				tblistfile.Tag = null;
			}
		}

		private void Delete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (lbfl.SelectedIndex<0) return;
			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Listing = (string[])Helper.Delete(md.Listing, lbfl.Items[lbfl.SelectedIndex]);

			lbfl.Items.Remove(lbfl.Items[lbfl.SelectedIndex]);

			md.Changed = true;			
		}

		private void Add(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			lbfl.Items.Add(tblistfile.Text);
			lbfl.SelectedIndex = lbfl.Items.Count-1;

			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Listing = (string[])Helper.Add(md.Listing, tblistfile.Text);

			md.Changed = true;
		}

		private void llscan_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
#if DEBUG
			FileTable.FileIndex.Load();

			System.IO.StreamWriter sw = System.IO.File.CreateText(@"G:\txmt.txt");
			Hashtable ht = new Hashtable();
			FileTable.FileIndex.AddIndexFromFolder(@":G:\EA Games\Die Sims 2\");
			try 
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.TXMT, true);
				foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
				{
					Rcol txmt = new GenericRcol(null, false);
					txmt.ProcessData(item);
					MaterialDefinition md = (MaterialDefinition)txmt.Blocks[0];
					foreach (MaterialDefinitionProperty mdp in md.Properties) 
					{
						if (!ht.ContainsKey(mdp.Name)) ht.Add(mdp.Name, "| " + mdp.Value + " | ");
						else 
						{
							string s = (string)ht[mdp.Name];
							if (s.IndexOf("| "+mdp.Value+" |")==-1) 
							{
								s += mdp.Value + " | ";
								ht[mdp.Name] = s;
							}
						}
					}
				}

				
				

				foreach (string k in ht.Keys) 
				{
					//if (!MaterialDefinition.PropertyParser.Properties.ContainsKey(k)) 
					{
						string v = (string)ht[k];
						string[] parts = v.Split("|".ToCharArray(), 3);
						sw.Write(k+"; ");
						sw.WriteLine((string)ht[k]);
						/*sw.WriteLine("    <property type=\"string\">");
						sw.WriteLine("        <name>"+k+"</name>");
						sw.WriteLine("        <help></help>");
						sw.WriteLine("        <default>"+parts[1].Trim()+"</default>");
						sw.WriteLine("    </property>");
						sw.WriteLine();*/
					}
			}
			} 
			finally 
			{
				sw.Close();
			}
#endif
		}

		Ambertation.PropertyObjectBuilderExt pob;
		internal void SetupGrid(MaterialDefinition md)
		{
			pg.SelectedObject = null;
			/*if (this.tGrid.Tag==null) return;
			MaterialDefinition md = (MaterialDefinition)this.tGrid.Tag;*/

			//Build the table for the current MMAT
			Hashtable ht = new Hashtable();

			foreach (MaterialDefinitionProperty mdp in md.Properties) 
			{
				if (MaterialDefinition.PropertyParser.Properties.ContainsKey(mdp.Name)) 
				{
					Ambertation.PropertyDescription pd = ((Ambertation.PropertyDescription)MaterialDefinition.PropertyParser.Properties[mdp.Name]).Clone();
					pd.Property = mdp.Value;
					ht[mdp.Name] = pd;
				} 
				else 
				{
					ht[mdp.Name] = mdp.Value;
				}
			}

			pob = new Ambertation.PropertyObjectBuilderExt(ht);
			pg.SelectedObject = pob.Instance;
		}

		private void pg_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			if (pob==null) return;
			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			object o = pob.Properties[e.ChangedItem.Label];
			if (o is Boolean)
			{
				if ((bool)o) md.GetProperty(e.ChangedItem.Label).Value = "1";
				else md.GetProperty(e.ChangedItem.Label).Value = "0";
			} else md.GetProperty(e.ChangedItem.Label).Value = o.ToString();

			md.Parent.Changed = true;
		}

		internal void TxmtChangeTab(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			if (tGrid.Parent==null) return;
			if (((TabControl)tGrid.Parent).SelectedTab == tGrid) 
			{
				md.Refresh();
			} 
			else if (((TabControl)tGrid.Parent).SelectedTab == this.tabPage1) 
			{
				md.Refresh();
			}
		}

		private void pg_Click(object sender, System.EventArgs e)
		{
		
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.tabPage3.Tag==null) return;
			
			MaterialDefinition md = (MaterialDefinition)this.tabPage3.Tag;
			md.Sort();
			md.Refresh();
		}
	}
}
