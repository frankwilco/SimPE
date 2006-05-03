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
	public class LightT : 
		System.Windows.Forms.TabPage
		//System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox14;
		private System.Windows.Forms.Label label47;
		internal System.Windows.Forms.TextBox tb_lt_ver;
		private System.Windows.Forms.Label label48;
		internal System.Windows.Forms.TextBox tb_lt_name;
		private System.ComponentModel.IContainer components;

		public LightT()
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
			this.groupBox14 = new System.Windows.Forms.GroupBox();
			this.tb_lt_name = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.tb_lt_ver = new System.Windows.Forms.TextBox();
			this.label47 = new System.Windows.Forms.Label();
			this.groupBox14.SuspendLayout();
			this.SuspendLayout();
			// 
			// tLightT
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox14);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tLightT";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 8;
			this.Text = "LightT";
			// 
			// groupBox14
			// 
			this.groupBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox14.Controls.Add(this.tb_lt_name);
			this.groupBox14.Controls.Add(this.label48);
			this.groupBox14.Controls.Add(this.tb_lt_ver);
			this.groupBox14.Controls.Add(this.label47);
			this.groupBox14.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox14.Location = new System.Drawing.Point(8, 8);
			this.groupBox14.Name = "groupBox14";
			this.groupBox14.Size = new System.Drawing.Size(776, 128);
			this.groupBox14.TabIndex = 12;
			this.groupBox14.TabStop = false;
			this.groupBox14.Text = "Settings";
			// 
			// tb_lt_name
			// 
			this.tb_lt_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_lt_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_lt_name.Location = new System.Drawing.Point(16, 88);
			this.tb_lt_name.Name = "tb_lt_name";
			this.tb_lt_name.Size = new System.Drawing.Size(752, 21);
			this.tb_lt_name.TabIndex = 26;
			this.tb_lt_name.Text = "";
			this.tb_lt_name.TextChanged += new System.EventHandler(this.LTSettingsChanged);
			// 
			// label48
			// 
			this.label48.AutoSize = true;
			this.label48.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label48.Location = new System.Drawing.Point(8, 72);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(42, 17);
			this.label48.TabIndex = 25;
			this.label48.Text = "Name:";
			// 
			// tb_lt_ver
			// 
			this.tb_lt_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_lt_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_lt_ver.Name = "tb_lt_ver";
			this.tb_lt_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_lt_ver.TabIndex = 24;
			this.tb_lt_ver.Text = "0x00000000";
			this.tb_lt_ver.TextChanged += new System.EventHandler(this.LTSettingsChanged);
			// 
			// label47
			// 
			this.label47.AutoSize = true;
			this.label47.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label47.Location = new System.Drawing.Point(8, 24);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(52, 17);
			this.label47.TabIndex = 23;
			this.label47.Text = "Version:";
			// 
			// fShapeRefNode
			// 
			this.groupBox14.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		
												

		private void LTSettingsChanged(object sender, System.EventArgs e)
		{
			if (this.Tag==null) return;
			try 
			{
				Plugin.LightT lt = (Plugin.LightT)Tag;

				lt.Version = Convert.ToUInt32(tb_lt_ver.Text, 16);
				lt.NameResource.FileName = tb_lt_name.Text;
				
				lt.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}						
	}
}
