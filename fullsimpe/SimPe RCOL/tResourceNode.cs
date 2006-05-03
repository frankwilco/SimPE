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
	public class ResourceNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
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
		internal System.Windows.Forms.TextBox tb_rn_ver;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.ToolTip toolTip1;		
		private System.ComponentModel.IContainer components;

		public ResourceNode()
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
				this.Tag = null;
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tResourceNode
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tResourceNode";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 1;
			this.Text = "ResourceNode";
			this.Visible = false;
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
			this.groupBox5.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
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
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
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
			// fShapeRefNode
			// 
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		

		private void RNChangeSettings(object sender, System.EventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)Tag;

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
				SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)Tag;
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
				SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)Tag;
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
			if (Tag==null) return;
			try 
			{
				lb_rn.Tag = true;
				SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)Tag;
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
			if (Tag==null) return;
			if (lb_rn.SelectedIndex<0) return;
			try 
			{
				lb_rn.Tag = true;
				SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)Tag;
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
	}
}
