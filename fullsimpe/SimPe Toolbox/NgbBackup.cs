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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbBackup.
	/// </summary>
	public class NgbBackup : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ListBox lbdirs;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NgbBackup()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbBackup));
			this.lbdirs = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbdirs
			// 
			this.lbdirs.AccessibleDescription = resources.GetString("lbdirs.AccessibleDescription");
			this.lbdirs.AccessibleName = resources.GetString("lbdirs.AccessibleName");
			this.lbdirs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbdirs.Anchor")));
			this.lbdirs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbdirs.BackgroundImage")));
			this.lbdirs.ColumnWidth = ((int)(resources.GetObject("lbdirs.ColumnWidth")));
			this.lbdirs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbdirs.Dock")));
			this.lbdirs.Enabled = ((bool)(resources.GetObject("lbdirs.Enabled")));
			this.lbdirs.Font = ((System.Drawing.Font)(resources.GetObject("lbdirs.Font")));
			this.lbdirs.HorizontalExtent = ((int)(resources.GetObject("lbdirs.HorizontalExtent")));
			this.lbdirs.HorizontalScrollbar = ((bool)(resources.GetObject("lbdirs.HorizontalScrollbar")));
			this.lbdirs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbdirs.ImeMode")));
			this.lbdirs.IntegralHeight = ((bool)(resources.GetObject("lbdirs.IntegralHeight")));
			this.lbdirs.ItemHeight = ((int)(resources.GetObject("lbdirs.ItemHeight")));
			this.lbdirs.Location = ((System.Drawing.Point)(resources.GetObject("lbdirs.Location")));
			this.lbdirs.Name = "lbdirs";
			this.lbdirs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbdirs.RightToLeft")));
			this.lbdirs.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbdirs.ScrollAlwaysVisible")));
			this.lbdirs.Size = ((System.Drawing.Size)(resources.GetObject("lbdirs.Size")));
			this.lbdirs.TabIndex = ((int)(resources.GetObject("lbdirs.TabIndex")));
			this.lbdirs.Visible = ((bool)(resources.GetObject("lbdirs.Visible")));
			this.lbdirs.SelectedIndexChanged += new System.EventHandler(this.SelectBackup);
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.Restore);
			// 
			// button2
			// 
			this.button2.AccessibleDescription = resources.GetString("button2.AccessibleDescription");
			this.button2.AccessibleName = resources.GetString("button2.AccessibleName");
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button2.Anchor")));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button2.Dock")));
			this.button2.Enabled = ((bool)(resources.GetObject("button2.Enabled")));
			this.button2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button2.FlatStyle")));
			this.button2.Font = ((System.Drawing.Font)(resources.GetObject("button2.Font")));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.ImageAlign")));
			this.button2.ImageIndex = ((int)(resources.GetObject("button2.ImageIndex")));
			this.button2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button2.ImeMode")));
			this.button2.Location = ((System.Drawing.Point)(resources.GetObject("button2.Location")));
			this.button2.Name = "button2";
			this.button2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button2.RightToLeft")));
			this.button2.Size = ((System.Drawing.Size)(resources.GetObject("button2.Size")));
			this.button2.TabIndex = ((int)(resources.GetObject("button2.TabIndex")));
			this.button2.Text = resources.GetString("button2.Text");
			this.button2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.TextAlign")));
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.Delete);
			// 
			// NgbBackup
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lbdirs);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "NgbBackup";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.ShowInTaskbar = false;
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);

		}
		#endregion

		string path;
		string backuppath;

		protected void UpdateList() 
		{
			lbdirs.Items.Clear();
			if (System.IO.Directory.Exists(backuppath)) 
			{
				string[] dirs = System.IO.Directory.GetDirectories(backuppath, "*");				
				foreach (string dir in dirs) 
				{
					lbdirs.Items.Add(System.IO.Path.GetFileName(dir));
				}
			}
		}

		SimPe.Interfaces.Files.IPackageFile package;
		Interfaces.IProviderRegistry prov;
		public void Execute(string path, SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov, string lable)
		{
			this.path = path;
			this.package = package;
			this.prov = prov;

			string name = System.IO.Path.GetFileName(path);
            if (lable != "") name = lable + "_" + name;
            long grp = PathProvider.Global.SaveGamePathProvidedByGroup(path);
            if (grp > 1) name = grp.ToString() + "_" + name;
            backuppath = System.IO.Path.Combine(PathProvider.Global.BackupFolder, name);

			UpdateList();

			
			ShowDialog();
		}

		private void SelectBackup(object sender, System.EventArgs e)
		{
			button1.Enabled = (lbdirs.SelectedIndex>=0);
			button2.Enabled = button1.Enabled;
		}

		private void Restore(object sender, System.EventArgs e)
		{
			if (lbdirs.SelectedIndex < 0) return;

			

			prov.SimDescriptionProvider.BasePackage = null;
			prov.SimFamilynameProvider.BasePackage = null;
			prov.SimNameProvider.BaseFolder = null;
			DialogResult dr = MessageBox.Show(Localization.Manager.GetString("backuprestore"), Localization.Manager.GetString("backup?"), MessageBoxButtons.YesNoCancel);
			if (dr!=DialogResult.Cancel) 
			{
				SimPe.Packages.StreamFactory.CloseAll();
				this.Cursor = Cursors.WaitCursor;
				WaitingScreen.Wait();
				
				try 
				{
					string source = System.IO.Path.Combine(backuppath, lbdirs.Items[lbdirs.SelectedIndex].ToString());

					if (dr==DialogResult.Yes) 
					{
						//create backup of current
						string newback= System.IO.Path.Combine(backuppath, "(automatic) "+DateTime.Now.ToString().Replace("\\", "-").Replace(":", "-").Replace(".", "-"));
						if (!System.IO.Directory.Exists(newback)) System.IO.Directory.CreateDirectory(newback);
						Helper.CopyDirectory(path, newback, true);
					}

					//remove the Neighborhood
					try 
					{
						SimPe.Packages.PackageMaintainer.Maintainer.RemovePackagesInPath(path);
						System.IO.Directory.Delete(path, true);
					} 
					catch (Exception) {}

					//copy the backup
					System.IO.Directory.CreateDirectory(path);
					Helper.CopyDirectory(source, path, true);

					UpdateList();
					WaitingScreen.Stop(this);
					MessageBox.Show("The backup was restored succesfully!");
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}
				finally 
				{
					WaitingScreen.Stop();
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void Delete(object sender, System.EventArgs e)
		{
			if (lbdirs.SelectedIndex < 0) return;
			string source = System.IO.Path.Combine(backuppath, lbdirs.Items[lbdirs.SelectedIndex].ToString());
			if (MessageBox.Show(Localization.Manager.GetString("backupdelete").Replace("{0}", source), Localization.Manager.GetString("delete?"), MessageBoxButtons.YesNo)==DialogResult.Yes) 
			{
				this.Cursor = Cursors.WaitCursor;
				
				if (System.IO.Directory.Exists(source)) System.IO.Directory.Delete(source, true);
				UpdateList();
				this.Cursor = Cursors.Default;
			}
		}
	}
}
