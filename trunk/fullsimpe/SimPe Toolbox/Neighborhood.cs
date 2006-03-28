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
using System.Data;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NeighborhoodForm.
	/// </summary>
	public class NeighborhoodForm : System.Windows.Forms.Form
	{
		
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.ComponentModel.IContainer components;

		public NeighborhoodForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NeighborhoodForm));
			this.lv = new System.Windows.Forms.ListView();
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.DoubleClick += new System.EventHandler(this.NgbOpen);
			this.lv.SelectedIndexChanged += new System.EventHandler(this.NgbSelect);
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
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
			this.button1.Click += new System.EventHandler(this.NgbOpen);
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
			this.button2.Click += new System.EventHandler(this.NgbBackup);
			// 
			// button3
			// 
			this.button3.AccessibleDescription = resources.GetString("button3.AccessibleDescription");
			this.button3.AccessibleName = resources.GetString("button3.AccessibleName");
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button3.Anchor")));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button3.Dock")));
			this.button3.Enabled = ((bool)(resources.GetObject("button3.Enabled")));
			this.button3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button3.FlatStyle")));
			this.button3.Font = ((System.Drawing.Font)(resources.GetObject("button3.Font")));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.ImageAlign")));
			this.button3.ImageIndex = ((int)(resources.GetObject("button3.ImageIndex")));
			this.button3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button3.ImeMode")));
			this.button3.Location = ((System.Drawing.Point)(resources.GetObject("button3.Location")));
			this.button3.Name = "button3";
			this.button3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button3.RightToLeft")));
			this.button3.Size = ((System.Drawing.Size)(resources.GetObject("button3.Size")));
			this.button3.TabIndex = ((int)(resources.GetObject("button3.TabIndex")));
			this.button3.Text = resources.GetString("button3.Text");
			this.button3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.TextAlign")));
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.NgbRestoreBackup);
			// 
			// NeighborhoodForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lv);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimizeBox = false;
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "NeighborhoodForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);

		}
		#endregion

		SimPe.Packages.GeneratableFile package;
		SimPe.Packages.File source_package;
		Interfaces.IProviderRegistry prov;
		bool changed;

		protected void AddImage(string path) 
		{
			string name = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), System.IO.Path.GetFileNameWithoutExtension(path)+".png");
			//name = System.IO.Path.Combine(path, name);
			if (System.IO.File.Exists(name)) 
			{
				System.IO.Stream st = System.IO.File.OpenRead(name);
				Image img = Image.FromStream(st);
				st.Close();
				WaitingScreen.UpdateImage(ImageLoader.Preview(img, WaitingScreen.ImageSize));	
				this.ilist.Images.Add(img);
			} 
			else 
			{
				this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")));
			}
		}

		protected void AddNeighborhood(string path) 
		{
			AddNeighborhood(path, "_Neighborhood.package");
			/*int i=1;
			while (AddNeighborhood(path, "_University"+Helper.MinStrLength(i.ToString(), 3)+".package")) 
			{
				i++;
			}*/
		}

		protected bool AddNeighborhood(string path, string filename) 
		{
			string flname = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(path), System.IO.Path.Combine(System.IO.Path.GetFileName(path), System.IO.Path.GetFileName(path)+filename));
			if (!System.IO.File.Exists(flname)) return false;

			AddImage(flname);
			flname = System.IO.Path.Combine(path, flname);
			string name = flname;
			string actime = "";
			bool ret = false;
			if (System.IO.File.Exists(name)) 
			{
				actime = " ("+System.IO.File.GetLastWriteTime(name).ToString()+")";
				ret = true;
				try 
				{
					SimPe.Packages.File pk = SimPe.Packages.File.LoadFromFile(name);
					try 
					{
						SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pk.FindFile(0x43545353, 0, 0xffffffff, 1);
						if (pfd!=null) 
						{
							SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
							str.ProcessData(pfd, pk);
							name = str.LanguageItems(new SimPe.PackedFiles.Wrapper.StrLanguage((byte)Data.MetaData.Languages.English))[0].Title;
						}
						//pk.Reader.Close();
					} 
					finally 
					{
						//pk.Reader.Close();
					}
				} 
				catch (Exception) {}
				
			} 

			ListViewItem lvi = new ListViewItem();
			lvi.Text = name+actime;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.SubItems.Add(flname);
			lvi.SubItems.Add(name);

			lv.Items.Add(lvi);

			return ret;
		}

		protected void UpdateList()
		{
			WaitingScreen.Wait();
				
			lv.Items.Clear();
			ilist.Images.Clear();
			string[] dirs = System.IO.Directory.GetDirectories(sourcepath, "N*");
			foreach (string dir in dirs) 
			{				
				AddNeighborhood(dir);
			}
			WaitingScreen.Stop(this);				
		}

		string sourcepath;
		public IToolResult Execute(string path, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{
			this.Cursor = Cursors.WaitCursor;
			this.package = null;
			this.prov = prov;
			source_package = (SimPe.Packages.File)package;
			sourcepath = path;
			changed = false;
			UpdateList();
			this.Cursor = Cursors.Default;

			
			RemoteControl.ShowSubForm(this);
			if (this.package!=null) package=this.package;
			return new Plugin.ToolResult(false, ((this.package!=null) || (changed)));
		}

		private void NgbSelect(object sender, System.EventArgs e)
		{
			button1.Enabled = (lv.SelectedItems.Count>0);
			button2.Enabled = button1.Enabled;
			button3.Enabled = button1.Enabled;
		}

		private void NgbOpen(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<=0) return;

			package = SimPe.Packages.GeneratableFile.LoadFromFile(lv.SelectedItems[0].SubItems[1].Text);
			Close();
		}

		protected void CloseIfOpened(string path)
		{
			if (source_package!=null)
			{
				if (source_package.SaveFileName.Trim().ToLower().StartsWith(path.ToLower()))
				{
					if(source_package.Reader != null)				
					{
						changed = true;
						//source_package.Reader.Close();
					}
				}
			}
		}


		private void NgbBackup(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<=0) return;

			SimPe.Packages.StreamFactory.CloseAll();
			string path = System.IO.Path.GetDirectoryName(lv.SelectedItems[0].SubItems[1].Text).Trim();
			
			//if a File in the current Neighborhood is opened - close it!
			CloseIfOpened(path);

			this.Cursor = Cursors.WaitCursor;
			WaitingScreen.Wait();
			try 
			{
				//create a Backup Folder
				string name = System.IO.Path.GetFileName(path);
			
				string backuppath = System.IO.Path.Combine(NeighborhoodTool.WindowsRegistry.BackupFolder, name);
				string subname = DateTime.Now.ToString();
				backuppath = System.IO.Path.Combine(backuppath, subname.Replace("\\", "-").Replace("/", "-").Replace(":", "-"));
				if (!System.IO.Directory.Exists(backuppath)) System.IO.Directory.CreateDirectory(backuppath);

				Helper.CopyDirectory(path, backuppath, true);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				WaitingScreen.Stop(this);
				this.Cursor = Cursors.Default;
			}
		}

		private void NgbRestoreBackup(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<=0) return;

			string path = System.IO.Path.GetDirectoryName(lv.SelectedItems[0].SubItems[1].Text).Trim();
			
			//if a File in the current Neighborhood is opened - close it!
			CloseIfOpened(path);

			

			NgbBackup nb = new NgbBackup();
			nb.Text += " ("+lv.SelectedItems[0].SubItems[2].Text.Trim()+")";
			nb.Execute(path, package, prov);

			
			UpdateList();
		}
	}
}
