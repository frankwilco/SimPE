namespace SimPe.Plugin.UI
{
	partial class SurgeryForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SurgeryForm));
			this.gbQuickChange = new System.Windows.Forms.GroupBox();
			this.tcQuickPick = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.skinSelector = new SimPe.Plugin.UI.Controls.PackageSelector();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.eyeSelector = new SimPe.Plugin.UI.Controls.PackageSelector();
			this.gbOptions = new System.Windows.Forms.GroupBox();
			this.cblOptions = new System.Windows.Forms.CheckedListBox();
			this.gbArchetype = new System.Windows.Forms.GroupBox();
			this.pgArchetypeDetails = new System.Windows.Forms.PropertyGrid();
			this.lnkSelectArchetypeSim = new System.Windows.Forms.LinkLabel();
			this.lnkLoadPackage = new System.Windows.Forms.LinkLabel();
			this.pbArchetype = new System.Windows.Forms.PictureBox();
			this.gbPatient = new System.Windows.Forms.GroupBox();
			this.lnkSelectPatientSim = new System.Windows.Forms.LinkLabel();
			this.lnkExportPackage = new System.Windows.Forms.LinkLabel();
			this.pbPatient = new System.Windows.Forms.PictureBox();
			this.pgPatientDetails = new System.Windows.Forms.PropertyGrid();
			this.dlgSavePackage = new System.Windows.Forms.SaveFileDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.dlgOpenPackage = new System.Windows.Forms.OpenFileDialog();
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.ssMessages = new System.Windows.Forms.StatusStrip();
			this.ssLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.ssProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.gbQuickChange.SuspendLayout();
			this.tcQuickPick.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.gbOptions.SuspendLayout();
			this.gbArchetype.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbArchetype)).BeginInit();
			this.gbPatient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPatient)).BeginInit();
			this.ssMessages.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbQuickChange
			// 
			resources.ApplyResources(this.gbQuickChange, "gbQuickChange");
			this.gbQuickChange.Controls.Add(this.tcQuickPick);
			this.gbQuickChange.Name = "gbQuickChange";
			this.gbQuickChange.TabStop = false;
			// 
			// tcQuickPick
			// 
			this.tcQuickPick.Controls.Add(this.tabPage1);
			this.tcQuickPick.Controls.Add(this.tabPage2);
			resources.ApplyResources(this.tcQuickPick, "tcQuickPick");
			this.tcQuickPick.Name = "tcQuickPick";
			this.tcQuickPick.SelectedIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.skinSelector);
			resources.ApplyResources(this.tabPage1, "tabPage1");
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// skinSelector
			// 
			resources.ApplyResources(this.skinSelector, "skinSelector");
			this.skinSelector.FileDatabase = null;
			this.skinSelector.Name = "skinSelector";
			this.skinSelector.SelectedItemChanged += new System.EventHandler(this.skinSelector_SelectedItemChanged);
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.eyeSelector);
			resources.ApplyResources(this.tabPage2, "tabPage2");
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// eyeSelector
			// 
			resources.ApplyResources(this.eyeSelector, "eyeSelector");
			this.eyeSelector.FileDatabase = null;
			this.eyeSelector.Name = "eyeSelector";
			this.eyeSelector.SelectedItemChanged += new System.EventHandler(this.eyeSelector_SelectedItemChanged);
			// 
			// gbOptions
			// 
			resources.ApplyResources(this.gbOptions, "gbOptions");
			this.gbOptions.Controls.Add(this.cblOptions);
			this.gbOptions.Name = "gbOptions";
			this.gbOptions.TabStop = false;
			this.toolTip1.SetToolTip(this.gbOptions, resources.GetString("gbOptions.ToolTip"));
			// 
			// cblOptions
			// 
			this.cblOptions.BackColor = System.Drawing.SystemColors.Control;
			this.cblOptions.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.cblOptions.CheckOnClick = true;
			resources.ApplyResources(this.cblOptions, "cblOptions");
			this.cblOptions.Name = "cblOptions";
			this.cblOptions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblOptions_ItemCheck);
			// 
			// gbArchetype
			// 
			resources.ApplyResources(this.gbArchetype, "gbArchetype");
			this.gbArchetype.Controls.Add(this.pgArchetypeDetails);
			this.gbArchetype.Controls.Add(this.lnkSelectArchetypeSim);
			this.gbArchetype.Controls.Add(this.lnkLoadPackage);
			this.gbArchetype.Controls.Add(this.pbArchetype);
			this.gbArchetype.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbArchetype.Name = "gbArchetype";
			this.gbArchetype.TabStop = false;
			// 
			// pgArchetypeDetails
			// 
			resources.ApplyResources(this.pgArchetypeDetails, "pgArchetypeDetails");
			this.pgArchetypeDetails.Name = "pgArchetypeDetails";
			this.pgArchetypeDetails.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.pgArchetypeDetails.ToolbarVisible = false;
			// 
			// lnkSelectArchetypeSim
			// 
			resources.ApplyResources(this.lnkSelectArchetypeSim, "lnkSelectArchetypeSim");
			this.lnkSelectArchetypeSim.Name = "lnkSelectArchetypeSim";
			this.lnkSelectArchetypeSim.TabStop = true;
			this.toolTip1.SetToolTip(this.lnkSelectArchetypeSim, resources.GetString("lnkSelectArchetypeSim.ToolTip"));
			this.lnkSelectArchetypeSim.UseCompatibleTextRendering = true;
			this.lnkSelectArchetypeSim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectArchetypeSim_LinkClicked);
			// 
			// lnkLoadPackage
			// 
			this.lnkLoadPackage.AutoEllipsis = true;
			resources.ApplyResources(this.lnkLoadPackage, "lnkLoadPackage");
			this.lnkLoadPackage.Name = "lnkLoadPackage";
			this.lnkLoadPackage.TabStop = true;
			this.toolTip1.SetToolTip(this.lnkLoadPackage, resources.GetString("lnkLoadPackage.ToolTip"));
			this.lnkLoadPackage.UseCompatibleTextRendering = true;
			this.lnkLoadPackage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLoadPackage_LinkClicked);
			// 
			// pbArchetype
			// 
			this.pbArchetype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.pbArchetype, "pbArchetype");
			this.pbArchetype.Name = "pbArchetype";
			this.pbArchetype.TabStop = false;
			// 
			// gbPatient
			// 
			resources.ApplyResources(this.gbPatient, "gbPatient");
			this.gbPatient.Controls.Add(this.lnkSelectPatientSim);
			this.gbPatient.Controls.Add(this.lnkExportPackage);
			this.gbPatient.Controls.Add(this.pbPatient);
			this.gbPatient.Controls.Add(this.pgPatientDetails);
			this.gbPatient.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbPatient.Name = "gbPatient";
			this.gbPatient.TabStop = false;
			// 
			// lnkSelectPatientSim
			// 
			resources.ApplyResources(this.lnkSelectPatientSim, "lnkSelectPatientSim");
			this.lnkSelectPatientSim.Name = "lnkSelectPatientSim";
			this.lnkSelectPatientSim.TabStop = true;
			this.toolTip1.SetToolTip(this.lnkSelectPatientSim, resources.GetString("lnkSelectPatientSim.ToolTip"));
			this.lnkSelectPatientSim.UseCompatibleTextRendering = true;
			this.lnkSelectPatientSim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectPatientSim_LinkClicked);
			// 
			// lnkExportPackage
			// 
			resources.ApplyResources(this.lnkExportPackage, "lnkExportPackage");
			this.lnkExportPackage.Name = "lnkExportPackage";
			this.lnkExportPackage.TabStop = true;
			this.toolTip1.SetToolTip(this.lnkExportPackage, resources.GetString("lnkExportPackage.ToolTip"));
			this.lnkExportPackage.UseCompatibleTextRendering = true;
			this.lnkExportPackage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExportPackage_LinkClicked);
			// 
			// pbPatient
			// 
			this.pbPatient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.pbPatient, "pbPatient");
			this.pbPatient.Name = "pbPatient";
			this.pbPatient.TabStop = false;
			// 
			// pgPatientDetails
			// 
			resources.ApplyResources(this.pgPatientDetails, "pgPatientDetails");
			this.pgPatientDetails.Name = "pgPatientDetails";
			this.pgPatientDetails.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.pgPatientDetails.ToolbarVisible = false;
			// 
			// dlgSavePackage
			// 
			resources.ApplyResources(this.dlgSavePackage, "dlgSavePackage");
			this.dlgSavePackage.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSavePackage_FileOk);
			// 
			// toolTip1
			// 
			resources.ApplyResources(this.toolTip1, "toolTip1");
			// 
			// dlgOpenPackage
			// 
			this.dlgOpenPackage.DefaultExt = "package";
			resources.ApplyResources(this.dlgOpenPackage, "dlgOpenPackage");
			this.dlgOpenPackage.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenPackage_FileOk);
			// 
			// btOK
			// 
			resources.ApplyResources(this.btOK, "btOK");
			this.btOK.Name = "btOK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btCancel
			// 
			resources.ApplyResources(this.btCancel, "btCancel");
			this.btCancel.Name = "btCancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// ssMessages
			// 
			resources.ApplyResources(this.ssMessages, "ssMessages");
			this.ssMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLabel,
            this.ssProgress});
			this.ssMessages.Name = "ssMessages";
			this.ssMessages.ShowItemToolTips = true;
			this.ssMessages.SizingGrip = false;
			// 
			// ssLabel
			// 
			resources.ApplyResources(this.ssLabel, "ssLabel");
			this.ssLabel.AutoToolTip = true;
			this.ssLabel.Name = "ssLabel";
			this.ssLabel.Spring = true;
			// 
			// ssProgress
			// 
			this.ssProgress.Name = "ssProgress";
			resources.ApplyResources(this.ssProgress, "ssProgress");
			// 
			// SurgeryForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ssMessages);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.gbQuickChange);
			this.Controls.Add(this.gbOptions);
			this.Controls.Add(this.gbArchetype);
			this.Controls.Add(this.gbPatient);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SurgeryForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SurgeryForm_FormClosing);
			this.gbQuickChange.ResumeLayout(false);
			this.tcQuickPick.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.gbOptions.ResumeLayout(false);
			this.gbArchetype.ResumeLayout(false);
			this.gbArchetype.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbArchetype)).EndInit();
			this.gbPatient.ResumeLayout(false);
			this.gbPatient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbPatient)).EndInit();
			this.ssMessages.ResumeLayout(false);
			this.ssMessages.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbPatient;
		private System.Windows.Forms.GroupBox gbArchetype;
		private System.Windows.Forms.GroupBox gbQuickChange;
		private System.Windows.Forms.GroupBox gbOptions;
		private System.Windows.Forms.LinkLabel lnkSelectPatientSim;
		private System.Windows.Forms.LinkLabel lnkSelectArchetypeSim;
		private System.Windows.Forms.LinkLabel lnkExportPackage;
		private System.Windows.Forms.LinkLabel lnkLoadPackage;
		
		private System.Windows.Forms.PictureBox pbArchetype;
		private System.Windows.Forms.PictureBox pbPatient;

		private System.Windows.Forms.SaveFileDialog dlgSavePackage;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.OpenFileDialog dlgOpenPackage;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.Button btCancel;

		private System.Windows.Forms.PropertyGrid pgPatientDetails;
		private System.Windows.Forms.PropertyGrid pgArchetypeDetails;
		private System.Windows.Forms.TabControl tcQuickPick;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.StatusStrip ssMessages;
		private System.Windows.Forms.ToolStripStatusLabel ssLabel;
		private System.Windows.Forms.ToolStripProgressBar ssProgress;
		private System.Windows.Forms.CheckedListBox cblOptions;
		private SimPe.Plugin.UI.Controls.PackageSelector skinSelector;
		private SimPe.Plugin.UI.Controls.PackageSelector eyeSelector;

	}
}