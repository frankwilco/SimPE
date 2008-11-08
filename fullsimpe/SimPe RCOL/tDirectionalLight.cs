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
	public class DirectionalLight : 
		System.Windows.Forms.TabPage
		//System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.GroupBox groupBox13;
		internal System.Windows.Forms.TextBox tb_l_ver;
		private System.Windows.Forms.Label label32;
		internal System.Windows.Forms.TextBox tb_l_name;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label38;
		internal System.Windows.Forms.TextBox tb_l_1;
		internal System.Windows.Forms.TextBox tb_l_6;
		internal System.Windows.Forms.Label label39;
		internal System.Windows.Forms.TextBox tb_l_2;
		private System.Windows.Forms.Label label40;
		internal System.Windows.Forms.TextBox tb_l_3;
		private System.Windows.Forms.Label label41;
		internal System.Windows.Forms.TextBox tb_l_4;
		private System.Windows.Forms.Label label42;
		internal System.Windows.Forms.TextBox tb_l_5;
		private System.Windows.Forms.Label label43;
		internal System.Windows.Forms.TextBox tb_l_7;
		internal System.Windows.Forms.Label label44;
		internal System.Windows.Forms.TextBox tb_l_8;
		internal System.Windows.Forms.Label label45;
		internal System.Windows.Forms.TextBox tb_l_9;
		internal System.Windows.Forms.Label label46;
		//private System.ComponentModel.IContainer components;

		public DirectionalLight()
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
			this.groupBox13 = new System.Windows.Forms.GroupBox();
			this.tb_l_9 = new System.Windows.Forms.TextBox();
			this.label46 = new System.Windows.Forms.Label();
			this.tb_l_8 = new System.Windows.Forms.TextBox();
			this.label45 = new System.Windows.Forms.Label();
			this.tb_l_7 = new System.Windows.Forms.TextBox();
			this.label44 = new System.Windows.Forms.Label();
			this.tb_l_5 = new System.Windows.Forms.TextBox();
			this.label43 = new System.Windows.Forms.Label();
			this.tb_l_4 = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.tb_l_3 = new System.Windows.Forms.TextBox();
			this.label41 = new System.Windows.Forms.Label();
			this.tb_l_2 = new System.Windows.Forms.TextBox();
			this.label40 = new System.Windows.Forms.Label();
			this.tb_l_6 = new System.Windows.Forms.TextBox();
			this.label39 = new System.Windows.Forms.Label();
			this.tb_l_1 = new System.Windows.Forms.TextBox();
			this.label38 = new System.Windows.Forms.Label();
			this.tb_l_name = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.tb_l_ver = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();			
			this.groupBox13.SuspendLayout();
			this.SuspendLayout();
			// 
			// tDirectionalLight
			// 
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.groupBox13);
			this.Location = new System.Drawing.Point(4, 22);
			this.Name = "tDirectionalLight";
			this.Size = new System.Drawing.Size(792, 262);
			this.TabIndex = 7;
			this.Text = "DirectionalLight";
			// 
			// groupBox13
			// 
			this.groupBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox13.Controls.Add(this.tb_l_9);
			this.groupBox13.Controls.Add(this.label46);
			this.groupBox13.Controls.Add(this.tb_l_8);
			this.groupBox13.Controls.Add(this.label45);
			this.groupBox13.Controls.Add(this.tb_l_7);
			this.groupBox13.Controls.Add(this.label44);
			this.groupBox13.Controls.Add(this.tb_l_5);
			this.groupBox13.Controls.Add(this.label43);
			this.groupBox13.Controls.Add(this.tb_l_4);
			this.groupBox13.Controls.Add(this.label42);
			this.groupBox13.Controls.Add(this.tb_l_3);
			this.groupBox13.Controls.Add(this.label41);
			this.groupBox13.Controls.Add(this.tb_l_2);
			this.groupBox13.Controls.Add(this.label40);
			this.groupBox13.Controls.Add(this.tb_l_6);
			this.groupBox13.Controls.Add(this.label39);
			this.groupBox13.Controls.Add(this.tb_l_1);
			this.groupBox13.Controls.Add(this.label38);
			this.groupBox13.Controls.Add(this.tb_l_name);
			this.groupBox13.Controls.Add(this.label34);
			this.groupBox13.Controls.Add(this.tb_l_ver);
			this.groupBox13.Controls.Add(this.label32);
			this.groupBox13.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox13.Location = new System.Drawing.Point(8, 8);
			this.groupBox13.Name = "groupBox13";
			this.groupBox13.Size = new System.Drawing.Size(776, 208);
			this.groupBox13.TabIndex = 12;
			this.groupBox13.TabStop = false;
			this.groupBox13.Text = "Settings";
			// 
			// tb_l_9
			// 
			this.tb_l_9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_9.Location = new System.Drawing.Point(168, 168);
			this.tb_l_9.Name = "tb_l_9";
			this.tb_l_9.Size = new System.Drawing.Size(66, 21);
			this.tb_l_9.TabIndex = 44;
			this.tb_l_9.Text = "0";
			this.tb_l_9.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label46.Location = new System.Drawing.Point(128, 176);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(34, 17);
			this.label46.TabIndex = 43;
			this.label46.Text = "Val9:";
			// 
			// tb_l_8
			// 
			this.tb_l_8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_8.Location = new System.Drawing.Point(48, 168);
			this.tb_l_8.Name = "tb_l_8";
			this.tb_l_8.Size = new System.Drawing.Size(66, 21);
			this.tb_l_8.TabIndex = 42;
			this.tb_l_8.Text = "0";
			this.tb_l_8.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label45.Location = new System.Drawing.Point(8, 176);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(34, 17);
			this.label45.TabIndex = 41;
			this.label45.Text = "Val8:";
			// 
			// tb_l_7
			// 
			this.tb_l_7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_7.Location = new System.Drawing.Point(168, 144);
			this.tb_l_7.Name = "tb_l_7";
			this.tb_l_7.Size = new System.Drawing.Size(66, 21);
			this.tb_l_7.TabIndex = 40;
			this.tb_l_7.Text = "0";
			this.tb_l_7.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label44
			// 
			this.label44.AutoSize = true;
			this.label44.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label44.Location = new System.Drawing.Point(128, 152);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(34, 17);
			this.label44.TabIndex = 39;
			this.label44.Text = "Val7:";
			// 
			// tb_l_5
			// 
			this.tb_l_5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_5.Location = new System.Drawing.Point(312, 168);
			this.tb_l_5.Name = "tb_l_5";
			this.tb_l_5.Size = new System.Drawing.Size(66, 21);
			this.tb_l_5.TabIndex = 38;
			this.tb_l_5.Text = "0";
			this.tb_l_5.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label43.Location = new System.Drawing.Point(256, 176);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(48, 17);
			this.label43.TabIndex = 37;
			this.label43.Text = "Blue:";
			this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tb_l_4
			// 
			this.tb_l_4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_4.Location = new System.Drawing.Point(312, 144);
			this.tb_l_4.Name = "tb_l_4";
			this.tb_l_4.Size = new System.Drawing.Size(66, 21);
			this.tb_l_4.TabIndex = 36;
			this.tb_l_4.Text = "0";
			this.tb_l_4.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label42.Location = new System.Drawing.Point(256, 152);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(48, 17);
			this.label42.TabIndex = 35;
			this.label42.Text = "Green:";
			this.label42.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tb_l_3
			// 
			this.tb_l_3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_3.Location = new System.Drawing.Point(312, 120);
			this.tb_l_3.Name = "tb_l_3";
			this.tb_l_3.Size = new System.Drawing.Size(66, 21);
			this.tb_l_3.TabIndex = 34;
			this.tb_l_3.Text = "0";
			this.tb_l_3.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label41.Location = new System.Drawing.Point(256, 128);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(48, 17);
			this.label41.TabIndex = 33;
			this.label41.Text = "Red:";
			this.label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tb_l_2
			// 
			this.tb_l_2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_2.Location = new System.Drawing.Point(168, 120);
			this.tb_l_2.Name = "tb_l_2";
			this.tb_l_2.Size = new System.Drawing.Size(66, 21);
			this.tb_l_2.TabIndex = 32;
			this.tb_l_2.Text = "0";
			this.tb_l_2.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label40.Location = new System.Drawing.Point(128, 128);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(34, 17);
			this.label40.TabIndex = 31;
			this.label40.Text = "Val2:";
			// 
			// tb_l_6
			// 
			this.tb_l_6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_6.Location = new System.Drawing.Point(48, 144);
			this.tb_l_6.Name = "tb_l_6";
			this.tb_l_6.Size = new System.Drawing.Size(66, 21);
			this.tb_l_6.TabIndex = 30;
			this.tb_l_6.Text = "0";
			this.tb_l_6.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label39.Location = new System.Drawing.Point(8, 152);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(34, 17);
			this.label39.TabIndex = 29;
			this.label39.Text = "Val6:";
			// 
			// tb_l_1
			// 
			this.tb_l_1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_1.Location = new System.Drawing.Point(48, 120);
			this.tb_l_1.Name = "tb_l_1";
			this.tb_l_1.Size = new System.Drawing.Size(66, 21);
			this.tb_l_1.TabIndex = 28;
			this.tb_l_1.Text = "0";
			this.tb_l_1.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label38.Location = new System.Drawing.Point(8, 128);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(34, 17);
			this.label38.TabIndex = 27;
			this.label38.Text = "Val1:";
			// 
			// tb_l_name
			// 
			this.tb_l_name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tb_l_name.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_name.Location = new System.Drawing.Point(16, 88);
			this.tb_l_name.Name = "tb_l_name";
			this.tb_l_name.Size = new System.Drawing.Size(752, 21);
			this.tb_l_name.TabIndex = 26;
			this.tb_l_name.Text = "";
			this.tb_l_name.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label34.Location = new System.Drawing.Point(8, 72);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(42, 17);
			this.label34.TabIndex = 25;
			this.label34.Text = "Name:";
			// 
			// tb_l_ver
			// 
			this.tb_l_ver.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb_l_ver.Location = new System.Drawing.Point(16, 40);
			this.tb_l_ver.Name = "tb_l_ver";
			this.tb_l_ver.Size = new System.Drawing.Size(88, 21);
			this.tb_l_ver.TabIndex = 24;
			this.tb_l_ver.Text = "0x00000000";
			this.tb_l_ver.TextChanged += new System.EventHandler(this.LSettingsChanged);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label32.Location = new System.Drawing.Point(8, 24);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(52, 17);
			this.label32.TabIndex = 23;
			this.label32.Text = "Version:";
			// 
			// fShapeRefNode
			// 
			this.groupBox13.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion		
		

		
						

		private void LSettingsChanged(object sender, System.EventArgs e)
		{
			if (this.Tag==null) return;
			try 
			{
				SimPe.Plugin.DirectionalLight dl = (SimPe.Plugin.DirectionalLight)Tag;

				dl.Version = Convert.ToUInt32(tb_l_ver.Text, 16);
				dl.Name = tb_l_name.Text;
				dl.Val1 = Convert.ToSingle(tb_l_1.Text);
				dl.Val2 = Convert.ToSingle(tb_l_2.Text);
				dl.Red = Convert.ToSingle(tb_l_3.Text);
				dl.Green = Convert.ToSingle(tb_l_4.Text);
				dl.Blue = Convert.ToSingle(tb_l_5.Text);

				if (Tag.GetType() == typeof(PointLight)) 
				{
					PointLight pl = (PointLight)Tag;

					pl.Val6 = Convert.ToSingle(tb_l_6.Text);
					pl.Val7 = Convert.ToSingle(tb_l_7.Text);
				}

				if (Tag.GetType() == typeof(SpotLight)) 
				{
					SpotLight sl = (SpotLight)Tag;

					sl.Val6 = Convert.ToSingle(tb_l_6.Text);
					sl.Val7 = Convert.ToSingle(tb_l_7.Text);
					sl.Val8 = Convert.ToSingle(tb_l_8.Text);
					sl.Val9 = Convert.ToSingle(tb_l_9.Text);
				}
				
				dl.Changed = true;
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}		
	}
}
