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
	public class GeometryNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
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
		private System.Windows.Forms.GroupBox groupBox17;
		internal System.Windows.Forms.ComboBox cb_gn_list;
		internal System.Windows.Forms.TabControl tc_gn;
		//private System.ComponentModel.IContainer components;

		public GeometryNode()
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
				/*if(components != null)
				{
					components.Dispose();
				}*/
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
			this.groupBox11.SuspendLayout();
			this.groupBox17.SuspendLayout();
			this.SuspendLayout();
			
			// 
			// tGeometryNode
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.groupBox11);
			this.Controls.Add(this.groupBox17);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tGeometryNode";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 5;
			this.Text = "GeometryNode";
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
			// fShapeRefNode
			// 
			
			this.groupBox11.ResumeLayout(false);
			this.groupBox17.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		
		

		private void GrNSettingsChange(object sender, System.EventArgs e)
		{
			if (this.Tag==null) return;
			try 
			{
				SimPe.Plugin.GeometryNode arb = (SimPe.Plugin.GeometryNode)Tag;

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

		internal void BuildChildTabControl(AbstractRcolBlock rb)
		{
			this.tc_gn.TabPages.Clear();

			if (rb==null) return;
			if (rb.TabPage!=null) rb.AddToTabControl(tc_gn);
		}		
	}
}
