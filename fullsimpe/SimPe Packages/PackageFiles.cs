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
	/// Zusammenfassung für PackageSelectorForm.
	/// </summary>
	public class PackageSelectorForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbfile;
		private System.Windows.Forms.ListBox lbfiles;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PackageSelectorForm()
		{
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PackageSelectorForm));
			this.label1 = new System.Windows.Forms.Label();
			this.lbfile = new System.Windows.Forms.Label();
			this.lbfiles = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(8, 286);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(576, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "You can use this Helper to Drag && Drop the Files from the current Package to to " +
				"any Reference List. The Item will be added to the List.";
			// 
			// lbfile
			// 
			this.lbfile.AutoSize = true;
			this.lbfile.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbfile.Location = new System.Drawing.Point(16, 16);
			this.lbfile.Name = "lbfile";
			this.lbfile.Size = new System.Drawing.Size(67, 17);
			this.lbfile.TabIndex = 1;
			this.lbfile.Text = "Filename:";
			// 
			// lbfiles
			// 
			this.lbfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbfiles.Location = new System.Drawing.Point(24, 32);
			this.lbfiles.Name = "lbfiles";
			this.lbfiles.Size = new System.Drawing.Size(552, 238);
			this.lbfiles.TabIndex = 2;
			this.lbfiles.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StartDrop);
			// 
			// PackageSelectorForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(592, 324);
			this.Controls.Add(this.lbfiles);
			this.Controls.Add(this.lbfile);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(440, 232);
			this.Name = "PackageSelectorForm";
			this.Text = "PackageSelectorForm";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Displays the Tool with the content of the passed Package
		/// </summary>
		/// <param name="package">The package you want to list</param>
		public void Execute(SimPe.Interfaces.Files.IPackageFile package) 
		{
			this.lbfiles.Sorted = false;
			this.lbfiles.Items.Clear();
			this.lbfile.Text = package.FileName;

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in package.Index) lbfiles.Items.Add(pfd);
			this.lbfiles.Sorted = true;
			this.Show();
		}

		private void StartDrop(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (lbfiles.SelectedIndex<0) return;

			if (e.Button == MouseButtons.Left) 
			{
				lbfiles.DoDragDrop((Interfaces.Files.IPackedFileDescriptor)lbfiles.Items[lbfiles.SelectedIndex], DragDropEffects.Copy | DragDropEffects.Link);

			}
		}
	}
}
