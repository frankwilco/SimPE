using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for OutputPreferences.
	/// </summary>
	public class OutputPreferences : PreferencesPanel
	{
		bool previousSetting = false;
		bool suppressEvents = false;
		private System.Windows.Forms.CheckBox cbCompressTextures;
		private System.Windows.Forms.CheckBox cbMotokiMode;
		private System.Windows.Forms.CheckBox cbDisableOriginal;
		private System.Windows.Forms.CheckBox cbOutputSingle;
		private System.Windows.Forms.CheckBox cbRenameFiles;
		//private System.Windows.Forms.CheckBox cbReusePackages;


		public OutputPreferences()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.Text = "Output";
		}

		protected override void OnSettingsChanged()
		{
			this.cbMotokiMode.Checked = !this.Settings.KeepDisabledItems;
			this.cbOutputSingle.Checked = this.Settings.GenerateSinglePackage;
			this.cbDisableOriginal.Checked = this.Settings.DisableOriginalPackages;
			this.cbCompressTextures.Checked = this.Settings.CompressTextures;
			this.cbRenameFiles.Checked = this.Settings.RenameFiles;
			this.previousSetting = this.Settings.DisableOriginalPackages;
			//this.cbReusePackages.Checked = this.Settings.ReusePackages;
		}

		public override void OnCommitSettings()
		{
			this.Settings.DisableOriginalPackages = this.cbDisableOriginal.Checked;
			this.Settings.GenerateSinglePackage = this.cbOutputSingle.Checked;
			this.Settings.KeepDisabledItems = !this.cbMotokiMode.Checked;
			this.Settings.CompressTextures = this.cbCompressTextures.Checked;
			this.Settings.RenameFiles = this.cbRenameFiles.Checked;
			//this.Settings.ReusePackages = this.cbReusePackages.Checked;

		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbCompressTextures = new System.Windows.Forms.CheckBox();
			this.cbMotokiMode = new System.Windows.Forms.CheckBox();
			this.cbDisableOriginal = new System.Windows.Forms.CheckBox();
			this.cbOutputSingle = new System.Windows.Forms.CheckBox();
			this.cbRenameFiles = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// cbCompressTextures
			// 
			this.cbCompressTextures.AutoSize = true;
			this.cbCompressTextures.Location = new System.Drawing.Point(192, 56);
			this.cbCompressTextures.Name = "cbCompressTextures";
			this.cbCompressTextures.Size = new System.Drawing.Size(116, 17);
			this.cbCompressTextures.TabIndex = 15;
			this.cbCompressTextures.Text = "Compress Textures";
			// 
			// cbMotokiMode
			// 
			this.cbMotokiMode.AutoSize = true;
			this.cbMotokiMode.Location = new System.Drawing.Point(8, 56);
			this.cbMotokiMode.Name = "cbMotokiMode";
			this.cbMotokiMode.Size = new System.Drawing.Size(170, 17);
			this.cbMotokiMode.TabIndex = 14;
			this.cbMotokiMode.Text = "Remove Unchecked Recolors";
			// 
			// cbDisableOriginal
			// 
			this.cbDisableOriginal.AutoSize = true;
			this.cbDisableOriginal.Location = new System.Drawing.Point(8, 16);
			this.cbDisableOriginal.Name = "cbDisableOriginal";
			this.cbDisableOriginal.Size = new System.Drawing.Size(148, 17);
			this.cbDisableOriginal.TabIndex = 12;
			this.cbDisableOriginal.Text = "Create Backup Packages";
			this.cbDisableOriginal.CheckedChanged += new System.EventHandler(this.ChangeRenamingSettings);
			// 
			// cbOutputSingle
			// 
			this.cbOutputSingle.AutoSize = true;
			this.cbOutputSingle.Location = new System.Drawing.Point(192, 16);
			this.cbOutputSingle.Name = "cbOutputSingle";
			this.cbOutputSingle.Size = new System.Drawing.Size(148, 17);
			this.cbOutputSingle.TabIndex = 13;
			this.cbOutputSingle.Text = "Generate Single Package";
			// 
			// cbRenameFiles
			// 
			this.cbRenameFiles.AutoSize = true;
			this.cbRenameFiles.Location = new System.Drawing.Point(8, 96);
			this.cbRenameFiles.Name = "cbRenameFiles";
			this.cbRenameFiles.Size = new System.Drawing.Size(90, 17);
			this.cbRenameFiles.TabIndex = 14;
			this.cbRenameFiles.Text = "Rename Files";
			this.cbRenameFiles.CheckedChanged += new System.EventHandler(this.ChangeRenamingSettings);
			// 
			// OutputPreferences
			// 
			this.Controls.Add(this.cbRenameFiles);
			this.Controls.Add(this.cbCompressTextures);
			this.Controls.Add(this.cbMotokiMode);
			this.Controls.Add(this.cbDisableOriginal);
			this.Controls.Add(this.cbOutputSingle);
			this.Name = "OutputPreferences";
			this.Size = new System.Drawing.Size(356, 129);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		void ChangeRenamingSettings(object sender, EventArgs e)
		{
			if (this.suppressEvents)
				return;

			if (!this.cbRenameFiles.Checked)
			{
				this.suppressEvents = true;
				this.previousSetting = this.cbDisableOriginal.Checked;
				this.cbDisableOriginal.Checked = false;
				this.cbDisableOriginal.Enabled = false;
				this.suppressEvents = false;
			}
			else
			{
				this.cbDisableOriginal.Enabled = true;
				if (this.cbRenameFiles.Equals(sender))
				{
					this.suppressEvents = true;
					this.cbDisableOriginal.Checked = this.previousSetting;
					this.suppressEvents = false;
				}
			}
			
		}
		#endregion
	}
}
