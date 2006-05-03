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
	public class ShpeLod : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
		private System.Windows.Forms.TextBox tbunk;
		internal System.Windows.Forms.ListBox lbunk;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShpeLod()
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
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tbunk = new System.Windows.Forms.TextBox();
			this.lbunk = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();			
			this.SuspendLayout();
			// 
			// tShpeLod
			// 
			this.Controls.Add(this.linkLabel4);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.tbunk);
			this.Controls.Add(this.lbunk);
			this.Controls.Add(this.label1);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tShpeLod";
			this.Size = new System.Drawing.Size(536, 254);
			this.TabIndex = 0;
			this.Text = "Level of Detail Listing";
			// 
			// linkLabel4
			// 
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel4.Location = new System.Drawing.Point(188, 56);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(44, 17);
			this.linkLabel4.TabIndex = 7;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "delete";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel4_LinkClicked);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel3.Location = new System.Drawing.Point(160, 56);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(28, 17);
			this.linkLabel3.TabIndex = 6;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "add";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
			// 
			// tbunk
			// 
			this.tbunk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbunk.Location = new System.Drawing.Point(144, 32);
			this.tbunk.Name = "tbunk";
			this.tbunk.Size = new System.Drawing.Size(88, 21);
			this.tbunk.TabIndex = 4;
			this.tbunk.Text = "0x00000000";
			this.tbunk.TextChanged += new System.EventHandler(this.ChangeUnknown);
			// 
			// lbunk
			// 
			this.lbunk.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbunk.IntegralHeight = false;
			this.lbunk.Location = new System.Drawing.Point(8, 8);
			this.lbunk.Name = "lbunk";
			this.lbunk.Size = new System.Drawing.Size(120, 104);
			this.lbunk.TabIndex = 3;
			this.lbunk.SelectedIndexChanged += new System.EventHandler(this.SelectUnknown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(136, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Value:";
			// 
			// ShpeForm
			// 
			
			this.ResumeLayout(false);

		}
		#endregion		

		private void UpdateLists()
		{
			try 
			{
				SimPe.Plugin.Shape shape = (SimPe.Plugin.Shape)this.Tag;

				uint[] unknown = new uint[lbunk.Items.Count];
				for (int i=0; i<unknown.Length; i++) unknown[i] = (uint)lbunk.Items[i];
				shape.Unknwon = unknown;				
			} 
			catch (Exception){}
		}

		private void SelectUnknown(object sender, System.EventArgs e)
		{
			if (tbunk.Tag!=null) return;
			if (lbunk.SelectedIndex<0) return;

			try 
			{
				tbunk.Tag = true;
				tbunk.Text = "0x"+Helper.HexString((uint)lbunk.Items[lbunk.SelectedIndex]);
			}
			catch (Exception) {}
			finally 
			{
				tbunk.Tag = null;
			}
		}

		private void ChangeUnknown(object sender, System.EventArgs e)
		{
			if (tbunk.Tag!=null) return;
			if (lbunk.SelectedIndex<0) return;

			try 
			{
				tbunk.Tag = true;
				lbunk.Items[lbunk.SelectedIndex] = Convert.ToUInt32(tbunk.Text, 16);}
			catch (Exception) {}
			finally 
			{
				tbunk.Tag = null;
			}
		}

		private void linkLabel3_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				uint val = Convert.ToUInt32(tbunk.Text, 16);
				lbunk.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel4_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbunk.SelectedIndex < 0) return;
			lbunk.Items.RemoveAt(lbunk.SelectedIndex);
			UpdateLists();
		}
	}
}
