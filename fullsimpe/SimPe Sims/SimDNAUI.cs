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
	public class SimDNAUI : 
		//System.Windows.Forms.UserControl 
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PropertyGrid pbDom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PropertyGrid pbRec;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimDNAUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.Text = "Sim DNA";
			this.Commited += new EventHandler(SimDNAUI_Commited);
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
			this.pbDom = new System.Windows.Forms.PropertyGrid();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pbRec = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// pbDom
			// 
			this.pbDom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pbDom.CommandsVisibleIfAvailable = true;
			this.pbDom.HelpVisible = false;
			this.pbDom.LargeButtons = false;
			this.pbDom.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pbDom.Location = new System.Drawing.Point(16, 48);
			this.pbDom.Name = "pbDom";
			this.pbDom.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pbDom.Size = new System.Drawing.Size(264, 96);
			this.pbDom.TabIndex = 0;
			this.pbDom.Text = "Dominant Gene";
			this.pbDom.ToolbarVisible = false;
			this.pbDom.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pbDom.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Dominant Gene:";
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Recessive Gene:";
			// 
			// pbRec
			// 
			this.pbRec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pbRec.CommandsVisibleIfAvailable = true;
			this.pbRec.HelpVisible = false;
			this.pbRec.LargeButtons = false;
			this.pbRec.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pbRec.Location = new System.Drawing.Point(16, 168);
			this.pbRec.Name = "pbRec";
			this.pbRec.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pbRec.Size = new System.Drawing.Size(264, 96);
			this.pbRec.TabIndex = 2;
			this.pbRec.Text = "Recessive Gene";
			this.pbRec.ToolbarVisible = false;
			this.pbRec.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pbRec.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// SimDNAUI
			// 
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pbRec);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbDom);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "SimDNAUI";
			this.Size = new System.Drawing.Size(288, 272);
			this.ResumeLayout(false);

		}
		#endregion

		#region IPackedFileUI Member

		
		public Wrapper.SimDNA Sdna
		{
			get { return (SimPe.PackedFiles.Wrapper.SimDNA)Wrapper; }
		}
		

		protected override void RefreshGUI()
		{
			this.pbDom.SelectedObject = Sdna.Dominant;
			this.pbRec.SelectedObject = Sdna.Recessive;			
		}		

		#endregion

		private void SimDNAUI_Commited(object sender, EventArgs e)
		{
			Sdna.SynchronizeUserData();			
		}
	}
}
