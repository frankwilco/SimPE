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
	/// Zusammenfassung für ShpeForm.
	/// </summary>
	public class ShpeGraphNode : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
		internal System.Windows.Forms.TextBox tbnodeflname;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.ListBox lbnode;
		private System.Windows.Forms.TextBox tbnode1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbnode2;
		private System.Windows.Forms.TextBox tbnode3;
		private System.Windows.Forms.LinkLabel linkLabel9;
		private System.Windows.Forms.LinkLabel linkLabel10;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label11;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShpeGraphNode()
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
			this.SuspendLayout();
			// 
			// tabPage4
			// 
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label20);
			this.Controls.Add(this.linkLabel9);
			this.Controls.Add(this.linkLabel10);
			this.Controls.Add(this.tbnode3);
			this.Controls.Add(this.tbnode2);
			this.Controls.Add(this.tbnode1);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lbnode);
			this.Controls.Add(this.tbnodeflname);
			this.Controls.Add(this.label8);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tabPage4";
			this.Size = new System.Drawing.Size(536, 254);
			this.TabIndex = 3;
			this.Text = "Graph Node";
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
			this.ResumeLayout(false);

		}
		#endregion

		//internal Shpe wrapper;		

		

		private void UpdateLists()
		{
			try 
			{
				SimPe.Plugin.Shape shape = (SimPe.Plugin.Shape)this.Tag;				

				ObjectGraphNodeItem[] ogni = new ObjectGraphNodeItem[lbnode.Items.Count];				
				for (int i=0; i<ogni.Length; i++) ogni[i] = (ObjectGraphNodeItem)lbnode.Items[i];
				shape.GraphNode.Items = ogni;
			} 
			catch (Exception){}
		}

		private void Commit(object sender, System.EventArgs e)
		{			
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
				lbnode.Tag = null;
			}
		}						

		private void linkLabel10_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				//Shpe wrp = (Shpe)wrapper;
				Shape shape = (Shape)this.Tag;

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
