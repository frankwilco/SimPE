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

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für Hidden.
	/// </summary>
	public class Hidden : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbComp;
		private System.Windows.Forms.TextBox tbBig;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Hidden()
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Hidden));
			this.label1 = new System.Windows.Forms.Label();
			this.tbComp = new System.Windows.Forms.TextBox();
			this.tbBig = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Compression Strength:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbComp
			// 
			this.tbComp.Location = new System.Drawing.Point(200, 24);
			this.tbComp.Name = "tbComp";
			this.tbComp.Size = new System.Drawing.Size(104, 21);
			this.tbComp.TabIndex = 1;
			this.tbComp.Text = "";
			// 
			// tbBig
			// 
			this.tbBig.Location = new System.Drawing.Point(200, 48);
			this.tbBig.Name = "tbBig";
			this.tbBig.Size = new System.Drawing.Size(104, 21);
			this.tbBig.TabIndex = 3;
			this.tbBig.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(176, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Big Package Resource Count:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// Hidden
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(458, 96);
			this.Controls.Add(this.tbBig);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbComp);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Hidden";
			this.Opacity = 0.8;
			this.Text = "Hidden";
			this.Load += new System.EventHandler(this.Hidden_Load);
			this.Closed += new System.EventHandler(this.Hidden_Closed);
			this.ResumeLayout(false);

		}
		#endregion

		private void Hidden_Load(object sender, System.EventArgs e)
		{
			this.tbComp.Text = SimPe.Packages.PackedFile.CompressionStrength.ToString();
			tbBig.Text = Helper.WindowsRegistry.BigPackageResourceCount.ToString();
		}

		private void Hidden_Closed(object sender, System.EventArgs e)
		{
			try 
			{
				SimPe.Packages.PackedFile.CompressionStrength = Convert.ToInt32(this.tbComp.Text);
				Helper.WindowsRegistry.BigPackageResourceCount = Convert.ToInt32(tbBig.Text);
			} 
			catch {}
		}
	}
}
