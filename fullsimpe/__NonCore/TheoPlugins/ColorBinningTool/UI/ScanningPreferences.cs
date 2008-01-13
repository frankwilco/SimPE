using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;

using SimPe.Plugin;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for ScanningPreferences.
	/// </summary>
	public class ScanningPreferences : PreferencesPanel
	{
		private System.Windows.Forms.CheckBox cbScanNeighborhood;
		private System.Windows.Forms.ListView lvNeighborhood;


		public ScanningPreferences()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.Text = "Neighborhood";

			this.BuildNeighborhoodList();
			
		}


		protected override void OnSettingsChanged()
		{
			foreach (ListViewItem item in this.lvNeighborhood.Items)
			{
				string filename = Convert.ToString(item.Tag);
				if (this.Settings.ScanNGBHFiles.Contains(filename))
					item.Checked = true;
			}
			this.cbScanNeighborhood.Checked = !Utility.IsNullOrEmpty(this.Settings.ScanNGBHFiles);
			this.lvNeighborhood.Enabled = this.cbScanNeighborhood.Checked;
		}

		public override void OnCommitSettings()
		{
			this.Settings.ScanNGBHFiles.Clear();
			if (this.cbScanNeighborhood.Checked)
				foreach (ListViewItem item in this.lvNeighborhood.Items)
					if (item.Checked)
						this.Settings.ScanNGBHFiles.Add(Convert.ToString(item.Tag));
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbScanNeighborhood = new System.Windows.Forms.CheckBox();
			this.lvNeighborhood = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// cbScanNeighborhood
			// 
			this.cbScanNeighborhood.Location = new System.Drawing.Point(8, 8);
			this.cbScanNeighborhood.Name = "cbScanNeighborhood";
			this.cbScanNeighborhood.Size = new System.Drawing.Size(112, 24);
			this.cbScanNeighborhood.TabIndex = 0;
			this.cbScanNeighborhood.Text = "Fix Missing DNA";
			this.cbScanNeighborhood.CheckedChanged += new EventHandler(cbScanNeighborhood_CheckedChanged);
			// 
			// lvNeighborhood
			// 
			this.lvNeighborhood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
				| System.Windows.Forms.AnchorStyles.Left)
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lvNeighborhood.CheckBoxes = true;
			this.lvNeighborhood.Location = new System.Drawing.Point(8, 32);
			this.lvNeighborhood.Name = "lvNeighborhood";
			this.lvNeighborhood.Size = new System.Drawing.Size(352, 120);
			this.lvNeighborhood.TabIndex = 1;
			this.lvNeighborhood.View = System.Windows.Forms.View.List;
			// 
			// ScanningPreferences
			// 
			this.Controls.Add(this.lvNeighborhood);
			this.Controls.Add(this.cbScanNeighborhood);
			this.Name = "ScanningPreferences";
			this.Size = new System.Drawing.Size(376, 168);
			this.ResumeLayout(false);

		}


		#endregion

		void BuildNeighborhoodList()
		{
			if (Directory.Exists(SimPe.PathProvider.Global.NeighborhoodFolder))
			{
				string sourcepath = SimPe.PathProvider.Global.NeighborhoodFolder;
				WaitingScreen.Wait();
				this.lvNeighborhood.Items.Clear();
				string[] dirs = Directory.GetDirectories(sourcepath, "N*");
				for (int i = 0; i < dirs.Length; i++)
				{
					string text1 = dirs[i];
					this.AddNeighborhood(text1);
				}
				WaitingScreen.Stop();

			}

		}

		protected void AddNeighborhood(string path)
		{
			this.AddNeighborhood(path, "_Neighborhood.package");
		}

		protected void AddNeighborhood(string path, string filename)
		{
			string filePath = Path.Combine(Path.GetDirectoryName(path), Path.Combine(Path.GetFileName(path), Path.GetFileName(path) + filename));
			if (!File.Exists(filePath))
				return;

			filePath = Path.Combine(path, filePath);
			string label = filePath;
			if (File.Exists(filePath))
			{
				try
				{
					SimPe.Packages.File package = SimPe.Packages.File.LoadFromFile(filePath);
					IPackedFileDescriptor pfd = package.FindFile(0x43545353, 0, uint.MaxValue, 1);
					if (pfd != null)
					{
						using (Str str1 = new Str())
						{
							str1.ProcessData(pfd, package);
							label = str1.LanguageItems(new StrLanguage(1))[0].Title;
						}
					}
				}
				catch (Exception)
				{
				}
			}
			ListViewItem item1 = new ListViewItem();
			item1.Text = label;
			item1.Tag = filePath;
			this.lvNeighborhood.Items.Add(item1);
		}



		void cbScanNeighborhood_CheckedChanged(object sender, EventArgs e)
		{
			this.lvNeighborhood.Enabled = this.cbScanNeighborhood.Checked;
		}

	}

}
