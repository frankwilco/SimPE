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
using SimPe.Interfaces.Plugin;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für RoadTextureControl.
	/// </summary>
	public class RoadTextureControl : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl
	{
		
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.Label label5;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbFlname;
		private System.Windows.Forms.TextBox tbUk1;
		private System.Windows.Forms.TextBox tbUk2;
		private System.Windows.Forms.TextBox tbUk3;
		private System.Windows.Forms.TextBox tbId;
		private System.Windows.Forms.TextBox tbTxmt;
		private System.Windows.Forms.Label label7;
		private Ambertation.Windows.Forms.EnumComboBox cbType;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public RoadTextureControl() : base()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.ThemeManager.AddControl(this.xpTaskBoxSimple1);
			cbType.Enum = typeof(RoadTexture.RoadTextureType);
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.ListBox();
			this.tbFlname = new System.Windows.Forms.TextBox();
			this.tbUk1 = new System.Windows.Forms.TextBox();
			this.tbUk2 = new System.Windows.Forms.TextBox();
			this.tbUk3 = new System.Windows.Forms.TextBox();
			this.tbId = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.xpTaskBoxSimple1 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.tbTxmt = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbType = new Ambertation.Windows.Forms.EnumComboBox();
			this.xpTaskBoxSimple1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 64);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Resource ID:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(368, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(72, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Unknown2:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(528, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Unknown3:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label4
			// 
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(8, 32);
			this.label4.Name = "label4";
			this.label4.TabIndex = 3;
			this.label4.Text = "Resourcename:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.HorizontalScrollbar = true;
			this.lb.IntegralHeight = false;
			this.lb.Location = new System.Drawing.Point(8, 96);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(376, 192);
			this.lb.TabIndex = 4;
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
			// 
			// tbFlname
			// 
			this.tbFlname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbFlname.Location = new System.Drawing.Point(120, 32);
			this.tbFlname.Name = "tbFlname";
			this.tbFlname.Size = new System.Drawing.Size(560, 21);
			this.tbFlname.TabIndex = 5;
			this.tbFlname.Text = "textBox1";
			// 
			// tbUk1
			// 
			this.tbUk1.Location = new System.Drawing.Point(120, 64);
			this.tbUk1.Name = "tbUk1";
			this.tbUk1.ReadOnly = true;
			this.tbUk1.Size = new System.Drawing.Size(72, 21);
			this.tbUk1.TabIndex = 6;
			this.tbUk1.Text = "0x00000000";
			// 
			// tbUk2
			// 
			this.tbUk2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUk2.Location = new System.Drawing.Point(448, 64);
			this.tbUk2.Name = "tbUk2";
			this.tbUk2.Size = new System.Drawing.Size(72, 21);
			this.tbUk2.TabIndex = 7;
			this.tbUk2.Text = "0x00000000";
			// 
			// tbUk3
			// 
			this.tbUk3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbUk3.Location = new System.Drawing.Point(608, 64);
			this.tbUk3.Name = "tbUk3";
			this.tbUk3.Size = new System.Drawing.Size(72, 21);
			this.tbUk3.TabIndex = 8;
			this.tbUk3.Text = "0x00000000";
			// 
			// tbId
			// 
			this.tbId.Location = new System.Drawing.Point(64, 48);
			this.tbId.Name = "tbId";
			this.tbId.Size = new System.Drawing.Size(192, 21);
			this.tbId.TabIndex = 10;
			this.tbId.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = "ID:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// xpTaskBoxSimple1
			// 
			this.xpTaskBoxSimple1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple1.Controls.Add(this.tbTxmt);
			this.xpTaskBoxSimple1.Controls.Add(this.label6);
			this.xpTaskBoxSimple1.Controls.Add(this.tbId);
			this.xpTaskBoxSimple1.Controls.Add(this.label5);
			this.xpTaskBoxSimple1.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple1.DockPadding.Left = 4;
			this.xpTaskBoxSimple1.DockPadding.Right = 4;
			this.xpTaskBoxSimple1.DockPadding.Top = 44;
			this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple1.HeaderText = "Properties";
			this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple1.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple1.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple1.Location = new System.Drawing.Point(392, 88);
			this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
			this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple1.Size = new System.Drawing.Size(288, 100);
			this.xpTaskBoxSimple1.TabIndex = 11;
			// 
			// tbTxmt
			// 
			this.tbTxmt.Location = new System.Drawing.Point(64, 72);
			this.tbTxmt.Name = "tbTxmt";
			this.tbTxmt.Size = new System.Drawing.Size(192, 21);
			this.tbTxmt.TabIndex = 12;
			this.tbTxmt.Text = "";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "Name:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(200, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(40, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "Type:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbType
			// 
			this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbType.Enabled = false;
			this.cbType.Enum = null;
			this.cbType.Location = new System.Drawing.Point(240, 64);
			this.cbType.Name = "cbType";
			this.cbType.ResourceManager = null;
			this.cbType.Size = new System.Drawing.Size(120, 21);
			this.cbType.TabIndex = 13;
			this.cbType.Text = "enumComboBox1";
			// 
			// RoadTextureControl
			// 
			this.Controls.Add(this.cbType);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.xpTaskBoxSimple1);
			this.Controls.Add(this.tbUk3);
			this.Controls.Add(this.tbUk2);
			this.Controls.Add(this.tbUk1);
			this.Controls.Add(this.tbFlname);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "RoadTextureControl";
			this.Size = new System.Drawing.Size(688, 296);
			this.xpTaskBoxSimple1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region IPackedFileUI Member

		public RoadTexture RoadTextureWrapper
		{
			get {return (RoadTexture)this.Wrapper; }
		}

		protected override void RefreshGUI()
		{
			base.RefreshGUI ();

			this.tbId.Text = "";
			this.tbTxmt.Text = "";

			this.tbFlname.Text = RoadTextureWrapper.FileName;
			this.tbUk1.Text = "0x"+Helper.HexString(RoadTextureWrapper.Id);
			this.tbUk2.Text = "0x"+Helper.HexString(RoadTextureWrapper.Unknown2);
			this.tbUk3.Text = "0x"+Helper.HexString(RoadTextureWrapper.Unknown3);

			cbType.SelectedValue = RoadTextureWrapper.Type;

			this.lb.Items.Clear();
			foreach (object o in RoadTextureWrapper)
				lb.Items.Add(o);

			if (lb.Items.Count>0) lb.SelectedIndex = 0;
		}
			

		#endregion

		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lb.SelectedIndex<0) return;
			if (RoadTextureWrapper==null) return;

			if (lb.SelectedItem is uint) 
			{
				this.tbId.Text = "0x"+Helper.HexString((uint)lb.SelectedItem);
				this.tbTxmt.Text = "0x"+Helper.HexString((uint)RoadTextureWrapper[lb.SelectedItem]);
			} 
			else 
			{
				this.tbId.Text = lb.SelectedItem.ToString();
				this.tbTxmt.Text = RoadTextureWrapper[lb.SelectedItem].ToString();
			}
		}
	}
}
