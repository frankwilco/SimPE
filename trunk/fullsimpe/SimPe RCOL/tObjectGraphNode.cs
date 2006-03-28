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
	public class ObjectGraphNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
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
		internal System.Windows.Forms.TextBox tb_ogn_ver;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.ComponentModel.IContainer components;

		public ObjectGraphNode()
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
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);						
			this.groupBox8.SuspendLayout();
			this.groupBox9.SuspendLayout();
			this.SuspendLayout();
			// 
			// tObjectGraphNode
			// 
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.groupBox8);
			this.Controls.Add(this.groupBox9);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tObjectGraphNode";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 3;
			this.Text = "ObjectGraphNode";
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
			// fShapeRefNode
			// 
			this.groupBox8.ResumeLayout(false);
			this.groupBox9.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		

		private void OGNChangeSettings(object sender, System.EventArgs e)
		{
			if (Tag==null) return;
			try 
			{
				SimPe.Plugin.ObjectGraphNode ogn = (SimPe.Plugin.ObjectGraphNode)Tag;

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
			if (Tag != null) return;
			if (this.lb_ogn.SelectedIndex<0) return;

			try 
			{
				lb_ogn.Tag = true;
				SimPe.Plugin.ObjectGraphNode ogn = (SimPe.Plugin.ObjectGraphNode)Tag;
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
			if (Tag != null) return;
			if (this.lb_ogn.SelectedIndex<0) return;

			try 
			{
				lb_ogn.Tag = true;
				SimPe.Plugin.ObjectGraphNode ogn = (SimPe.Plugin.ObjectGraphNode)Tag;
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
			if (Tag==null) return;
			try 
			{
				lb_ogn.Tag = true;
				SimPe.Plugin.ObjectGraphNode ogn = (SimPe.Plugin.ObjectGraphNode)Tag;
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
			if (Tag==null) return;
			if (lb_ogn.SelectedIndex<0) return;
			try 
			{
				lb_ogn.Tag = true;
				SimPe.Plugin.ObjectGraphNode ogn = (SimPe.Plugin.ObjectGraphNode)Tag;
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
	}
}
