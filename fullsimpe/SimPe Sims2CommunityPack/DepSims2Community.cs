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

namespace SimPe.Packages
{
	/// <summary>
	/// Zusammenfassung für DepSims2Community.
	/// </summary>
	internal class DepSims2Community : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lblist;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.Button btdelete;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btadd;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DepSims2Community()
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
			this.btadd = new System.Windows.Forms.Button();
			this.lblist = new System.Windows.Forms.ListBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.btdelete = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btadd
			// 
			this.btadd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btadd.Location = new System.Drawing.Point(216, 90);
			this.btadd.Name = "btadd";
			this.btadd.TabIndex = 4;
			this.btadd.Text = "Add...";
			this.btadd.Click += new System.EventHandler(this.AddPackage);
			// 
			// lblist
			// 
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblist.IntegralHeight = false;
			this.lblist.Location = new System.Drawing.Point(8, 8);
			this.lblist.Name = "lblist";
			this.lblist.Size = new System.Drawing.Size(376, 80);
			this.lblist.TabIndex = 3;
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.Select);
			// 
			// btdelete
			// 
			this.btdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btdelete.Location = new System.Drawing.Point(136, 90);
			this.btdelete.Name = "btdelete";
			this.btdelete.TabIndex = 5;
			this.btdelete.Text = "Delete...";
			this.btdelete.Click += new System.EventHandler(this.DeletePackage);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(312, 90);
			this.button2.Name = "button2";
			this.button2.TabIndex = 6;
			this.button2.Text = "OK";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// DepSims2Community
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(394, 120);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btdelete);
			this.Controls.Add(this.btadd);
			this.Controls.Add(this.lblist);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "DepSims2Community";
			this.Text = "Dependencies";
			this.ResumeLayout(false);

		}
		#endregion
		bool ok;

		public void Execute(SimPe.Packages.S2CPDescriptor s2cp, bool ronly) 
		{
			lblist.Items.Clear();

			this.btdelete.Visible = !ronly;
			this.btadd.Visible = !ronly;

			foreach (S2CPDescriptorBase s2cpb in s2cp.Dependency) 
			{
				lblist.Items.Add(s2cpb);
			}

			if (lblist.Items.Count>0) lblist.SelectedIndex=0;
			btdelete.Enabled = (lblist.SelectedIndex>=0);

			this.ShowDialog();

			if (ok) 
			{
				S2CPDescriptorBase[] s2cpbs = new S2CPDescriptorBase[lblist.Items.Count];
				for (int i=0; i<s2cpbs.Length; i++) 
				{
					s2cpbs[i] = (S2CPDescriptorBase)lblist.Items[i];
				}

				s2cp.Dependency = s2cpbs;
			}
		}


		private void AddPackage(object sender, System.EventArgs e)
		{
			ofd.Filter = "Sims 2 Package (*.package)|*.package|All Files (*.*)|*.*";
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				SimPe.Packages.GeneratableFile package = new GeneratableFile(ofd.FileName);
				S2CPDescriptorBase s2cpb = new S2CPDescriptorBase(package);
				if (s2cpb.Guid==null) MessageBox.Show("This Package does not contain a valid GlobalGUID.\nYou can create on by including this File in a diffren Sims2Community Package or by adding a 'Sims2Comunity Identifier' to the Package.");
				else lblist.Items.Add(s2cpb);
			}
		}

		private void DeletePackage(object sender, System.EventArgs e)
		{
			if (lblist.SelectedIndex<0) return;

			lblist.Items.RemoveAt(lblist.SelectedIndex);
		}

		private void Select(object sender, System.EventArgs e)
		{
			btdelete.Enabled = false;
			if (lblist.SelectedIndex<0) return;
			btdelete.Enabled = true;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}
	}
}
