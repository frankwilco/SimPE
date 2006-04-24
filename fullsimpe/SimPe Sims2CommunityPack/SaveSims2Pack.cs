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
	/// Zusammenfassung für SaveSims2CommunityPack.
	/// </summary>
	internal class SaveSims2Pack : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lblist;
		private System.Windows.Forms.GroupBox gbsettings;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbdesc;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.TextBox tbflname;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Button btdelete;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button btadd;
		private System.Windows.Forms.Button btbrowse;
		private System.Windows.Forms.Button btsave;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbgameguid;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SaveSims2Pack()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SaveSims2Pack));
			this.lblist = new System.Windows.Forms.ListBox();
			this.gbsettings = new System.Windows.Forms.GroupBox();
			this.tbgameguid = new System.Windows.Forms.TextBox();
			this.tbdesc = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btadd = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.label6 = new System.Windows.Forms.Label();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.btbrowse = new System.Windows.Forms.Button();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.btdelete = new System.Windows.Forms.Button();
			this.btsave = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.gbsettings.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblist
			// 
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblist.IntegralHeight = false;
			this.lblist.Location = new System.Drawing.Point(8, 40);
			this.lblist.Name = "lblist";
			this.lblist.Size = new System.Drawing.Size(560, 80);
			this.lblist.TabIndex = 2;
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.Select);
			// 
			// gbsettings
			// 
			this.gbsettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.gbsettings.Controls.Add(this.tbgameguid);
			this.gbsettings.Controls.Add(this.tbdesc);
			this.gbsettings.Controls.Add(this.label5);
			this.gbsettings.Controls.Add(this.label9);
			this.gbsettings.Enabled = false;
			this.gbsettings.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.gbsettings.Location = new System.Drawing.Point(8, 144);
			this.gbsettings.Name = "gbsettings";
			this.gbsettings.Size = new System.Drawing.Size(560, 176);
			this.gbsettings.TabIndex = 1;
			this.gbsettings.TabStop = false;
			this.gbsettings.Text = "Settings";
			// 
			// tbgameguid
			// 
			this.tbgameguid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbgameguid.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbgameguid.Location = new System.Drawing.Point(16, 144);
			this.tbgameguid.Name = "tbgameguid";
			this.tbgameguid.ReadOnly = true;
			this.tbgameguid.Size = new System.Drawing.Size(144, 21);
			this.tbgameguid.TabIndex = 11;
			this.tbgameguid.Text = "";
			// 
			// tbdesc
			// 
			this.tbdesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbdesc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbdesc.Location = new System.Drawing.Point(16, 40);
			this.tbdesc.Multiline = true;
			this.tbdesc.Name = "tbdesc";
			this.tbdesc.Size = new System.Drawing.Size(528, 78);
			this.tbdesc.TabIndex = 14;
			this.tbdesc.Text = "";
			this.tbdesc.TextChanged += new System.EventHandler(this.ChangeText);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(8, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(73, 17);
			this.label5.TabIndex = 4;
			this.label5.Text = "Description:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(8, 128);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 17);
			this.label9.TabIndex = 15;
			this.label9.Text = "GameGUIDs:";
			// 
			// btadd
			// 
			this.btadd.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btadd.Location = new System.Drawing.Point(496, 122);
			this.btadd.Name = "btadd";
			this.btadd.Size = new System.Drawing.Size(72, 23);
			this.btadd.TabIndex = 4;
			this.btadd.Text = "Add...";
			this.btadd.Click += new System.EventHandler(this.AddPackage);
			// 
			// ofd
			// 
			this.ofd.Filter = "Sims 2 Package (*.package)|*.package|All Files (*.*)|*.*";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(8, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 17);
			this.label6.TabIndex = 3;
			this.label6.Text = "FileName:";
			// 
			// tbflname
			// 
			this.tbflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbflname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbflname.Location = new System.Drawing.Point(80, 8);
			this.tbflname.Name = "tbflname";
			this.tbflname.Size = new System.Drawing.Size(400, 21);
			this.tbflname.TabIndex = 0;
			this.tbflname.Text = "";
			// 
			// btbrowse
			// 
			this.btbrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btbrowse.Location = new System.Drawing.Point(493, 8);
			this.btbrowse.Name = "btbrowse";
			this.btbrowse.TabIndex = 1;
			this.btbrowse.Text = "Browse...";
			this.btbrowse.Click += new System.EventHandler(this.S2CPFilename);
			// 
			// btdelete
			// 
			this.btdelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btdelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btdelete.Location = new System.Drawing.Point(416, 122);
			this.btdelete.Name = "btdelete";
			this.btdelete.TabIndex = 3;
			this.btdelete.Text = "Remove...";
			this.btdelete.Click += new System.EventHandler(this.DeletePackage);
			// 
			// btsave
			// 
			this.btsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btsave.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btsave.Location = new System.Drawing.Point(400, 330);
			this.btsave.Name = "btsave";
			this.btsave.TabIndex = 16;
			this.btsave.Text = "Save";
			this.btsave.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button4.Location = new System.Drawing.Point(480, 330);
			this.button4.Name = "button4";
			this.button4.TabIndex = 17;
			this.button4.Text = "Cancel";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// SaveSims2Pack
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(576, 360);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.btsave);
			this.Controls.Add(this.btdelete);
			this.Controls.Add(this.btbrowse);
			this.Controls.Add(this.tbflname);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btadd);
			this.Controls.Add(this.gbsettings);
			this.Controls.Add(this.lblist);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SaveSims2Pack";
			this.ShowInTaskbar = false;
			this.Text = "Sims 2 Pack File Browser";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.AllowClose);
			this.Load += new System.EventHandler(this.SaveSims2CommunityPack_Load);
			this.gbsettings.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// true if the communit Extensions should be used
		/// </summary>
		bool extension;

		/// <summary>
		/// true if the File should be saved
		/// </summary>
		bool ok;

		/// <summary>
		/// Shows the Save Dialog
		/// </summary>
		/// <param name="files">all packages that should be initially in the File</param>
		/// <param name="extension">true if you want to add the Community Extension, otherwise 
		/// a normal Sims2Pack File will be generated</param>
		/// <returns>A list of all packages this File should contain</returns>
		public S2CPDescriptor[] Execute(SimPe.Packages.GeneratableFile[] files, ref bool extension)
		{
			this.extension = extension;
			ok = false;

			S2CPDescriptor[] s2cps = new S2CPDescriptor[files.Length];
			for (int i=0; i<files.Length; i++) 
			{
				s2cps[i] = new S2CPDescriptor(files[i], "", "", "", "", Sims2CommunityPack.DEFAULT_COMPRESSION_STRENGTH, new S2CPDescriptorBase[0], extension);
				lblist.Items.Add(s2cps[i]);
			}

			btadd.Visible = true;
			btdelete.Visible = true;
			btbrowse.Enabled = true;
			btsave.Text = "Save";

			this.lblist.SelectionMode = SelectionMode.One;

			if (lblist.Items.Count>0) lblist.SelectedIndex=0;
			btdelete.Enabled = (lblist.SelectedIndex>=0);
			
			this.ShowDialog();

			extension = false;
			if (ok) 
			{
				s2cps = new S2CPDescriptor[lblist.Items.Count];
				for (int i=0; i<s2cps.Length; i++) 
				{
					s2cps[i] = (S2CPDescriptor)lblist.Items[i];
					//s2cps[i].Update();
				}

				return s2cps;
			}

			return null;
		}

		/// <summary>
		/// Shows the Load Dialog
		/// </summary>
		/// <param name="files">All Descriptors within the S2CP File</param>
		/// <param name="selmode">Selection Mode for the Listbox</param>
		/// <returns>All the Packages the user has selected</returns>
		public S2CPDescriptor[] Execute(S2CPDescriptor[] files, SelectionMode selmode)
		{
			this.extension = false;
			ok = false;

			for (int i=0; i<files.Length; i++) lblist.Items.Add(files[i]);

			this.tbflname.ReadOnly = true;
			this.tbdesc.ReadOnly = true;
			btadd.Visible = false;
			btdelete.Visible = false;
			btbrowse.Enabled = false;
			btsave.Text = "Open";		

			this.lblist.SelectionMode = selmode;

			if (lblist.Items.Count>0) lblist.SelectedIndex=0;
			btdelete.Enabled = (lblist.SelectedIndex>=0);

			this.ShowDialog();

			if (ok) 
			{
				S2CPDescriptor[] fls = new S2CPDescriptor[lblist.SelectedItems.Count];
				for (int i=0; i<fls.Length; i++) 
				{
					fls[i] = (S2CPDescriptor)lblist.SelectedItems[i];
				}

				return fls;
			}

			return null;
		}

		/// <summary>
		/// Select a List Item
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Select(object sender, System.EventArgs e)
		{
			if (lblist.Tag!=null) return;
			gbsettings.Enabled = false;
			btdelete.Enabled = false;
			if (lblist.SelectedIndex<0) return;
			gbsettings.Enabled = true;			
			btdelete.Enabled = true;

			lblist.Tag = true;
			try 
			{
				SimPe.Packages.S2CPDescriptor s2cp = (SimPe.Packages.S2CPDescriptor )lblist.Items[lblist.SelectedIndex];

				tbdesc.Text = s2cp.Description;
				tbgameguid.Text = s2cp.GameGuid;
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lblist.Tag = null;
			}
		}

		private void ChangeText(object sender, System.EventArgs e)
		{
			if (lblist.Tag!=null) return;
			if (lblist.SelectedIndex<0) return;

			lblist.Tag = true;
			try 
			{
				SimPe.Packages.S2CPDescriptor s2cp = (SimPe.Packages.S2CPDescriptor )lblist.Items[lblist.SelectedIndex];

				s2cp.Description = tbdesc.Text;

				lblist.Items[lblist.SelectedIndex] = s2cp;
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				lblist.Tag = null;
			}
		}

		private void AddPackage(object sender, System.EventArgs e)
		{
			ofd.Filter = "Sims 2 Package (*.package)|*.package|All Files (*.*)|*.*";
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				SimPe.Packages.GeneratableFile package = GeneratableFile.LoadFromFile(ofd.FileName);
				S2CPDescriptor s2cp = new S2CPDescriptor(package, "", "", "", "", Sims2CommunityPack.DEFAULT_COMPRESSION_STRENGTH, new S2CPDescriptorBase[0], extension);
				lblist.Items.Add(s2cp);
				lblist.SelectedIndex = lblist.Items.Count-1;
			}
		}

		private void DeletePackage(object sender, System.EventArgs e)
		{
			if (lblist.SelectedIndex<0) return;

			lblist.Items.RemoveAt(lblist.SelectedIndex);
		}

		private void S2CPFilename(object sender, System.EventArgs e)
		{
			sfd.Filter = "Sims 2 Package (*.sims2pack)|*.sims2pack|All Files (*.*)|*.*";
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				tbflname.Text = sfd.FileName;
			}
		}

		private void AllowClose(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (tbflname.ReadOnly) 
			{
				if ((lblist.SelectedItems.Count==0) && (ok))
				{
					MessageBox.Show("You have to select at Least one Package");
					btadd.Select();
					e.Cancel = true;
				}
			} 
			else 
			{
				if ((tbflname.Text.Trim()=="") && (ok))
				{
					MessageBox.Show("You have to specify a Filename for the Sims2Community Pack File.");
					this.tbflname.Select();
					e.Cancel = true;
				}

				if ((lblist.Items.Count==0) && (ok))
				{
					MessageBox.Show("You have to add at least one Package.");
					btadd.Select();
					e.Cancel = true;
				}
			}
		}

		

		private void button4_Click(object sender, System.EventArgs e)
		{
			ok = false;
			Close();
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}

		

		private void SaveSims2CommunityPack_Load(object sender, System.EventArgs e)
		{
		
		}

		
	}
}
