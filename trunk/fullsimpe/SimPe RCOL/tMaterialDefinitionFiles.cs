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

namespace SimPe.Plugin.TabPage
{
	/// <summary>
	/// Zusammenfassung für MatdForm.
	/// </summary>
	public class MaterialDefinitionFiles : 
		System.Windows.Forms.TabPage
		//System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public MaterialDefinitionFiles()
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
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tblistfile = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbfl = new System.Windows.Forms.ListBox();			
			this.SuspendLayout();
			// 
			// tMaterialDefinitionFiles
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.linkLabel4);
			this.Controls.Add(this.linkLabel3);
			this.Controls.Add(this.tblistfile);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lbfl);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tMaterialDefinitionFiles";
			this.Size = new System.Drawing.Size(744, 238);
			this.TabIndex = 1;
			this.Text = "File List";
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
			// MatdForm
			// 			
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.ListBox lbfl;
		private System.Windows.Forms.TextBox tblistfile;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;		
				

		

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
			if (this.Tag==null) return;
			if (tblistfile.Tag!=null) return;
			if (lbfl.SelectedIndex<0) return;
			
			try 
			{
				tblistfile.Tag = true;
				lbfl.Items[lbfl.SelectedIndex] = tblistfile.Text;

				SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
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
			if (this.Tag==null) return;
			if (lbfl.SelectedIndex<0) return;
			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			md.Listing = (string[])Helper.Delete(md.Listing, lbfl.Items[lbfl.SelectedIndex]);

			lbfl.Items.Remove(lbfl.Items[lbfl.SelectedIndex]);

			md.Changed = true;			
		}

		private void Add(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.Tag==null) return;
			lbfl.Items.Add(tblistfile.Text);
			lbfl.SelectedIndex = lbfl.Items.Count-1;

			SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)this.Tag;
			md.Listing = (string[])Helper.Add(md.Listing, tblistfile.Text);

			md.Changed = true;
		}				
	}
}
