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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für SimDNAUI.
	/// </summary>
	public class ScorUI : 
		//System.Windows.Forms.UserControl 
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbunk1;
		private System.Windows.Forms.TextBox tbunk2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lb;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ScorUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.Text = "Sim Scores";
			this.Commited += new EventHandler(ScorUI_Commited);
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
			this.tbunk1 = new System.Windows.Forms.TextBox();
			this.tbunk2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(80, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unknown 1:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbunk1
			// 
			this.tbunk1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbunk1.Location = new System.Drawing.Point(96, 40);
			this.tbunk1.Name = "tbunk1";
			this.tbunk1.ReadOnly = true;
			this.tbunk1.Size = new System.Drawing.Size(184, 21);
			this.tbunk1.TabIndex = 1;
			this.tbunk1.Text = "";
			// 
			// tbunk2
			// 
			this.tbunk2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbunk2.Location = new System.Drawing.Point(96, 64);
			this.tbunk2.Name = "tbunk2";
			this.tbunk2.ReadOnly = true;
			this.tbunk2.Size = new System.Drawing.Size(184, 21);
			this.tbunk2.TabIndex = 3;
			this.tbunk2.Text = "";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Unknown 2:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lb.IntegralHeight = false;
			this.lb.Location = new System.Drawing.Point(8, 96);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(272, 172);
			this.lb.TabIndex = 4;
			// 
			// ScorUI
			// 
			this.Controls.Add(this.lb);
			this.Controls.Add(this.tbunk2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbunk1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ScorUI";
			this.Size = new System.Drawing.Size(288, 272);
			this.ResumeLayout(false);

		}
		#endregion

		#region IPackedFileUI Member

		
		public Wrapper.Scor Scor
		{
			get { return (SimPe.PackedFiles.Wrapper.Scor)Wrapper; }
		}
		

		protected override void RefreshGUI()
		{
			this.tbunk1.Text = Helper.HexString(Scor.Unknown1);
			this.tbunk2.Text = Helper.HexString(Scor.Unknown2);

			lb.Items.Clear();
			foreach (Wrapper.ScorItem si in Scor.Items)
				lb.Items.Add(si);
		}		

		#endregion

		private void ScorUI_Commited(object sender, EventArgs e)
		{
			Scor.SynchronizeUserData();			
		}
	}
}
