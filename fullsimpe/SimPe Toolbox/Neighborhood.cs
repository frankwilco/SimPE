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
        private Ambertation.Windows.Forms.XPTaskBoxSimple pnBackup;
        private Ambertation.Windows.Forms.XPTaskBoxSimple pnOptions;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
        private ComboBox cbtypes;
        private Label label1;
		private System.ComponentModel.IContainer components;
        ThemeManager tm;

		public NeighborhoodForm()
		{
			InitializeComponent();

            tm = ThemeManager.Global.CreateChild();
            tm.AddControl(pnBackup);
            tm.AddControl(pnOptions);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
                if (tm != null)
                {
                    tm.Clear();
                    tm.Parent = null;
                    tm = null;
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NeighborhoodForm));
            this.lv = new System.Windows.Forms.ListView();
            this.ilist = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnBackup = new Ambertation.Windows.Forms.XPTaskBoxSimple();
            this.pnOptions = new Ambertation.Windows.Forms.XPTaskBoxSimple();
            this.cbtypes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBackup.SuspendLayout();
            this.pnOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.AccessibleDescription = null;
            this.lv.AccessibleName = null;
            resources.ApplyResources(this.lv, "lv");
            this.lv.BackgroundImage = null;
            this.lv.Font = null;
            this.lv.HideSelection = false;
            this.lv.LargeImageList = this.ilist;
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.DoubleClick += new System.EventHandler(this.NgbOpen);
            this.lv.SelectedIndexChanged += new System.EventHandler(this.NgbSelect);
            // 
            // ilist
            // 
            this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            resources.ApplyResources(this.ilist, "ilist");
            this.ilist.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = null;
            this.button1.AccessibleName = null;
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = null;
            this.button1.Font = null;
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.NgbOpen);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = null;
            this.button2.AccessibleName = null;
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = null;
            this.button2.Font = null;
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.NgbBackup);
            // 
            // button3
            // 
            this.button3.AccessibleDescription = null;
            this.button3.AccessibleName = null;
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackgroundImage = null;
            this.button3.Font = null;
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.NgbRestoreBackup);
            // 
            // pnBackup
            // 
            this.pnBackup.AccessibleDescription = null;
            this.pnBackup.AccessibleName = null;
            resources.ApplyResources(this.pnBackup, "pnBackup");
            this.pnBackup.BackColor = System.Drawing.Color.Transparent;
            this.pnBackup.BackgroundImage = null;
            this.pnBackup.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnBackup.BorderColor = System.Drawing.SystemColors.Window;
            this.pnBackup.Controls.Add(this.button3);
            this.pnBackup.Controls.Add(this.button2);
            this.pnBackup.Font = null;
            this.pnBackup.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.pnBackup.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnBackup.IconLocation = new System.Drawing.Point(4, 12);
            this.pnBackup.IconSize = new System.Drawing.Size(32, 32);
            this.pnBackup.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnBackup.Name = "pnBackup";
            this.pnBackup.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // pnOptions
            // 
            this.pnOptions.AccessibleDescription = null;
            this.pnOptions.AccessibleName = null;
            resources.ApplyResources(this.pnOptions, "pnOptions");
            this.pnOptions.BackColor = System.Drawing.Color.Transparent;
            this.pnOptions.BackgroundImage = null;
            this.pnOptions.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pnOptions.BorderColor = System.Drawing.SystemColors.Window;
            this.pnOptions.Controls.Add(this.cbtypes);
            this.pnOptions.Controls.Add(this.label1);
            this.pnOptions.Font = null;
            this.pnOptions.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.pnOptions.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnOptions.IconLocation = new System.Drawing.Point(4, 12);
            this.pnOptions.IconSize = new System.Drawing.Size(32, 32);
            this.pnOptions.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnOptions.Name = "pnOptions";
            this.pnOptions.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbtypes
            // 
            this.cbtypes.AccessibleDescription = null;
            this.cbtypes.AccessibleName = null;
            resources.ApplyResources(this.cbtypes, "cbtypes");
            this.cbtypes.BackgroundImage = null;
            this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtypes.Font = null;
            this.cbtypes.FormattingEnabled = true;
            this.cbtypes.Name = "cbtypes";
            this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.cbtypes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NeighborhoodForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.pnOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv);
            this.Controls.Add(this.pnBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NeighborhoodForm";
            this.pnBackup.ResumeLayout(false);
            this.pnOptions.ResumeLayout(false);
            this.pnOptions.PerformLayout();
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

		protected void AddNeighborhood(ExpansionItem.NeighborhoodPath np, string path) 
		{
			AddNeighborhood(np, path, "_Neighborhood.package");
			/*int i=1;
			while (AddNeighborhood(path, "_University"+Helper.MinStrLength(i.ToString(), 3)+".package")) 
			{
				i++;
			}*/
        }

        protected string NeighborhoodIdentifier(string flname)
        {
            return System.IO.Path.GetFileNameWithoutExtension(flname).Replace("_Neighborhood", "");
        }

		protected bool AddNeighborhood(ExpansionItem.NeighborhoodPath np, string path, string filename) 
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
                actime = " (" + System.IO.File.GetLastWriteTime(name).ToString();
                if (Helper.WindowsRegistry.HiddenMode) actime += ", " + NeighborhoodIdentifier(flname);
                actime += ")";
				ret = true;
				try 
				{
					SimPe.Packages.File pk = SimPe.Packages.File.LoadFromFile(name);
                    NeighborhoodType t;
                    name = LoadLabel(pk, out t);
				} 
				catch (Exception) {}
				
			} 

			ListViewItem lvi = new ListViewItem();
			lvi.Text = name+actime;
            if (np.Lable != "") lvi.Text = np.Lable + ": " + lvi.Text;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.SubItems.Add(flname);
			lvi.SubItems.Add(name);
            lvi.SubItems.Add(np.Lable);
            if (Helper.WindowsRegistry.HiddenMode) 
                lvi.ToolTipText = flname;

			lv.Items.Add(lvi);

			return ret;
		}

        private static string LoadLabel(SimPe.Packages.File pk, out NeighborhoodType type)
        {
            string name = SimPe.Localization.GetString("Unknown");
            type = NeighborhoodType.Unknown;
            try
            {
                SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pk.FindFile(0x43545353, 0, 0xffffffff, 1);
                if (pfd != null)
                {
                    SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
                    str.ProcessData(pfd, pk);
                    name = str.LanguageItems(new SimPe.PackedFiles.Wrapper.StrLanguage((byte)Data.MetaData.Languages.English))[0].Title;
                }

                pfd = pk.FindFile(0xAC8A7A2E, 0, 0xffffffff, 1);
                if (pfd != null)
                {
                    SimPe.Plugin.Idno idno = new Idno();
                    idno.ProcessData(pfd, pk);
                    type = idno.Type;
                }
                //pk.Reader.Close();
            }
            finally
            {
                //pk.Reader.Close();
            }
            return name;
        }

		protected void UpdateList()
		{
			WaitingScreen.Wait();
				
			lv.Items.Clear();
			ilist.Images.Clear();

            ExpansionItem.NeighborhoodPaths paths = PathProvider.Global.GetNeighborhoodsForGroup();
            foreach (ExpansionItem.NeighborhoodPath path in paths)
            {
                string sourcepath = path.Path;
                string[] dirs = System.IO.Directory.GetDirectories(sourcepath, "N*");
                foreach (string dir in dirs)
                    AddNeighborhood(path, dir);

                dirs = System.IO.Directory.GetDirectories(sourcepath, "G*");
                foreach (string dir in dirs)
                    AddNeighborhood(path, dir);

                dirs = System.IO.Directory.GetDirectories(sourcepath, "F*");
                foreach (string dir in dirs)
                    AddNeighborhood(path, dir);
            }
			WaitingScreen.Stop(this);				
		}

		
		public IToolResult Execute(ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov)
		{
			this.Cursor = Cursors.WaitCursor;
			this.package = null;
			this.prov = prov;
			source_package = (SimPe.Packages.File)package;
			changed = false;
			UpdateList();
			this.Cursor = Cursors.Default;

			
			RemoteControl.ShowSubForm(this);
			if (this.package!=null) package=this.package;
			return new Plugin.ToolResult(false, ((this.package!=null) || (changed)));
		}

        class NgbhType
        {
            string name, file; NeighborhoodType type;

            public string FileName
            {
                get { return file; }
            } 
            public NgbhType(string file, string name, NeighborhoodType type)
            {
                this.name = name;
                this.type = type;
                this.file = file;
            }

            public override string ToString()
            {
                return type.ToString() + ": " + name;
            }
        }

		private void NgbSelect(object sender, System.EventArgs e)
		{
			//button1.Enabled = (lv.SelectedItems.Count>0);
            button2.Enabled = (lv.SelectedItems.Count > 0);
			button3.Enabled = button2.Enabled;

            cbtypes.Items.Clear();
            if (lv.SelectedItems.Count > 0)
            {
                string path = System.IO.Path.GetDirectoryName(lv.SelectedItems[0].SubItems[1].Text);
                string[] files = System.IO.Directory.GetFiles(path, "*.package");

                foreach (string file in files)
                {
                    SimPe.Packages.File pk = SimPe.Packages.File.LoadFromFile(file);
                    NeighborhoodType type;
                    string name = LoadLabel(pk, out type);
                    NgbhType nt = new NgbhType(file, name, type);

                    cbtypes.Items.Add(nt);
                    if (Helper.EqualFileName(file, lv.SelectedItems[0].SubItems[1].Text))
                        cbtypes.SelectedIndex = cbtypes.Items.Count - 1;
                }
                if (cbtypes.SelectedIndex < 0 && cbtypes.Items.Count > 0)
                    cbtypes.SelectedIndex = 0;
            }
        }

		private void NgbOpen(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<=0) return;

            NgbhType t = cbtypes.SelectedItem as NgbhType;
            if (t != null)
            {
                package = SimPe.Packages.GeneratableFile.LoadFromFile(t.FileName);
                Close();
            }
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
            string lable = lv.SelectedItems[0].SubItems[3].Text;
			
			//if a File in the current Neighborhood is opened - close it!
			CloseIfOpened(path);

			this.Cursor = Cursors.WaitCursor;
			WaitingScreen.Wait();
			try 
			{
				//create a Backup Folder
				string name = System.IO.Path.GetFileName(path);
                if (lable != "") name = lable + "_" + name;
                long grp = PathProvider.Global.SaveGamePathProvidedByGroup(path);
                if (grp > 1) name = grp.ToString() + "_" + name;

                string backuppath = System.IO.Path.Combine(PathProvider.Global.BackupFolder, name);
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
            nb.Text += " (";
            if (lv.SelectedItems[0].SubItems[3].Text != "") nb.Text += lv.SelectedItems[0].SubItems[3].Text + ": ";
            nb.Text += lv.SelectedItems[0].SubItems[2].Text.Trim();
            if (Helper.WindowsRegistry.HiddenMode) nb.Text += ", " + NeighborhoodIdentifier(path);
            nb.Text += ")";
            nb.Execute(path, package, prov, lv.SelectedItems[0].SubItems[3].Text);

			
			UpdateList();
		}

        private void cbtypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = cbtypes.SelectedItem != null;
        }
	}
}
