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
	public class ShpeParts : 
		//System.Windows.Forms.UserControl
		System.Windows.Forms.TabPage
	{
		private System.Windows.Forms.Label label5;
		internal System.Windows.Forms.ListBox lbpart;
		private System.Windows.Forms.TextBox tbparttype;
		private System.Windows.Forms.TextBox tbpartdsc;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbpartdata;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.LinkLabel linkLabel7;
		private System.Windows.Forms.LinkLabel linkLabel8;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ShpeParts()
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
			this.linkLabel7 = new System.Windows.Forms.LinkLabel();
			this.linkLabel8 = new System.Windows.Forms.LinkLabel();
			this.tbpartdata = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.tbpartdsc = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbparttype = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbpart = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// tabPage3
			// 
			this.Controls.Add(this.linkLabel7);
			this.Controls.Add(this.linkLabel8);
			this.Controls.Add(this.tbpartdata);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.tbpartdsc);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.tbparttype);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbpart);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tabPage3";
			this.Size = new System.Drawing.Size(536, 254);
			this.TabIndex = 2;
			this.Text = "Parts";
			// 
			// linkLabel7
			// 
			this.linkLabel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel7.AutoSize = true;
			this.linkLabel7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel7.Location = new System.Drawing.Point(484, 120);
			this.linkLabel7.Name = "linkLabel7";
			this.linkLabel7.Size = new System.Drawing.Size(44, 17);
			this.linkLabel7.TabIndex = 21;
			this.linkLabel7.TabStop = true;
			this.linkLabel7.Text = "delete";
			this.linkLabel7.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel7_LinkClicked);
			// 
			// linkLabel8
			// 
			this.linkLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabel8.AutoSize = true;
			this.linkLabel8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel8.Location = new System.Drawing.Point(456, 120);
			this.linkLabel8.Name = "linkLabel8";
			this.linkLabel8.Size = new System.Drawing.Size(28, 17);
			this.linkLabel8.TabIndex = 20;
			this.linkLabel8.TabStop = true;
			this.linkLabel8.Text = "add";
			this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel8_LinkClicked);
			// 
			// tbpartdata
			// 
			this.tbpartdata.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbpartdata.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbpartdata.Location = new System.Drawing.Point(16, 224);
			this.tbpartdata.Name = "tbpartdata";
			this.tbpartdata.Size = new System.Drawing.Size(512, 21);
			this.tbpartdata.TabIndex = 18;
			this.tbpartdata.Text = "";
			this.tbpartdata.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(8, 208);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(38, 17);
			this.label7.TabIndex = 19;
			this.label7.Text = "Data:";
			// 
			// tbpartdsc
			// 
			this.tbpartdsc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbpartdsc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbpartdsc.Location = new System.Drawing.Point(16, 184);
			this.tbpartdsc.Name = "tbpartdsc";
			this.tbpartdsc.Size = new System.Drawing.Size(512, 21);
			this.tbpartdsc.TabIndex = 16;
			this.tbpartdsc.Text = "";
			this.tbpartdsc.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 168);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(153, 17);
			this.label6.TabIndex = 17;
			this.label6.Text = "Material Definition File:";
			// 
			// tbparttype
			// 
			this.tbparttype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbparttype.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbparttype.Location = new System.Drawing.Point(16, 144);
			this.tbparttype.Name = "tbparttype";
			this.tbparttype.Size = new System.Drawing.Size(512, 21);
			this.tbparttype.TabIndex = 14;
			this.tbparttype.Text = "";
			this.tbparttype.TextChanged += new System.EventHandler(this.ChangedPart);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 128);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "Subset Name:";
			// 
			// lbpart
			// 
			this.lbpart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbpart.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbpart.HorizontalScrollbar = true;
			this.lbpart.IntegralHeight = false;
			this.lbpart.Location = new System.Drawing.Point(8, 8);
			this.lbpart.Name = "lbpart";
			this.lbpart.Size = new System.Drawing.Size(520, 112);
			this.lbpart.TabIndex = 13;
			this.lbpart.SelectedIndexChanged += new System.EventHandler(this.SelectPart);
			// 
			// ShpeParts
			// 
			this.ResumeLayout(false);

		}
		#endregion

		//internal Shpe wrapper;		

		private void SelectPart(object sender, System.EventArgs e)
		{
			if (lbpart.Tag!=null) return;
			if (lbpart.SelectedIndex<0) return;

			try 
			{
				lbpart.Tag = true;
				ShapePart item = (ShapePart)lbpart.Items[lbpart.SelectedIndex];
				tbparttype.Text = item.Subset;
				tbpartdsc.Text = item.FileName;

				string s = "";
				foreach (byte b in item.Data) s += Helper.HexString(b)+" ";
				tbpartdata.Text = s;
			} 
			catch (Exception){}
			finally 
			{
				lbpart.Tag = null;
			}
		}

		private void ChangedPart(object sender, System.EventArgs e)
		{
			if (lbpart.Tag!=null) return;
			if (lbpart.SelectedIndex<0) return;

			try 
			{
				lbpart.Tag = true;
				ShapePart item = (ShapePart)lbpart.Items[lbpart.SelectedIndex];
				item.Subset = tbparttype.Text;
				item.FileName = tbpartdsc.Text;
				
				string[] tokens = tbpartdata.Text.Trim().Split(" ".ToCharArray());
				byte[] data = new byte[tokens.Length];
				for (int i=0; i<data.Length; i++) data[i] = Convert.ToByte(tokens[i]);
				item.Data = data;

				lbpart.Items[lbpart.SelectedIndex] = item;
			} 
			catch (Exception){}
			finally 
			{
				lbpart.Tag = null;
			}
		}

		private void UpdateLists()
		{
			try 
			{
				SimPe.Plugin.Shape shape = (SimPe.Plugin.Shape)this.Tag;				

				ShapePart[] parts = new ShapePart[lbpart.Items.Count];
				for (int i=0; i<parts.Length; i++) parts[i] = (ShapePart)lbpart.Items[i];
				shape.Parts = parts;				
			} 
			catch (Exception){}
		}

		

		private void linkLabel8_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				//Shpe wrp = (Shpe)wrapper;
				SimPe.Plugin.Shape shape = (SimPe.Plugin.Shape)this.Tag;

				ShapePart val = new ShapePart();
				val.Subset = tbparttype.Text;
				val.FileName = tbpartdsc.Text;
				val.Data = Helper.SetLength(Helper.HexListToBytes(tbpartdata.Text), 9);

				lbpart.Items.Add(val);
				UpdateLists();
			}
			catch (Exception) {}
		}

		private void linkLabel7_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbpart.SelectedIndex < 0) return;
			lbpart.Items.RemoveAt(lbpart.SelectedIndex);
			UpdateLists();
		}		
	}
}
