
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tcMain = new System.Windows.Forms.TabControl();
			this.dlgOpenPackageFile = new System.Windows.Forms.OpenFileDialog();
			this.pbTexturePreview = new System.Windows.Forms.PictureBox();
			this.menuPackage = new System.Windows.Forms.MainMenu(this.components);
			this.miPackage = new System.Windows.Forms.MenuItem();
			this.miNewSession = new System.Windows.Forms.MenuItem();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.miPackageOpen = new System.Windows.Forms.MenuItem();
			this.miPackageSave = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.miOptions = new System.Windows.Forms.MenuItem();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.box = new SimPe.Plugin.GeneticCategorizer(this.components);
			this.meshTable = new SimPe.Plugin.MeshTable(this.components);
			this.dlgSavePackageFile = new System.Windows.Forms.SaveFileDialog();
			this.cmListActions = new System.Windows.Forms.ContextMenu();
			this.miOpenPackage = new System.Windows.Forms.MenuItem();
			this.miMoveTo = new System.Windows.Forms.MenuItem();
			this.miClear = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.miLoadMesh = new System.Windows.Forms.MenuItem();
			this.miApplyMesh = new System.Windows.Forms.MenuItem();
			this.cbEnablePreview = new System.Windows.Forms.CheckBox();
			this.lvTxmt = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.lvCresShpe = new System.Windows.Forms.ListView();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.cmTxmtListActions = new System.Windows.Forms.ContextMenu();
			this.miMatUseBaseTxtr = new System.Windows.Forms.MenuItem();
			this.miMatCopyTxtrRef = new System.Windows.Forms.MenuItem();
			this.miMatUseTxtrRef = new System.Windows.Forms.MenuItem();
			this.cmMeshListActions = new System.Windows.Forms.ContextMenu();
			this.miCresAddToMeshList = new System.Windows.Forms.MenuItem();
			this.matPanel = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tcProperties = new System.Windows.Forms.TabControl();
			this.tpMaterials = new System.Windows.Forms.TabPage();
			this.tpMeshes = new System.Windows.Forms.TabPage();
			this.tpClothing = new SimPe.Plugin.UI.ClothingPreferences();
			this.panel1 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.mainPanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pbTexturePreview)).BeginInit();
			this.matPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tcProperties.SuspendLayout();
			this.tpMaterials.SuspendLayout();
			this.tpMeshes.SuspendLayout();
			this.panel1.SuspendLayout();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcMain
			// 
			this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcMain.Location = new System.Drawing.Point(0, 0);
			this.tcMain.Multiline = true;
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(544, 226);
			this.tcMain.TabIndex = 0;
			this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_Selected);
			// 
			// dlgOpenPackageFile
			// 
			this.dlgOpenPackageFile.DefaultExt = "*";
			this.dlgOpenPackageFile.Filter = "Package files (*.package)|*.package|Disabled package files (*.packagedisabled)|*." +
					"packagedisabled|All files (*.*)|*.*";
			this.dlgOpenPackageFile.FilterIndex = 3;
			this.dlgOpenPackageFile.Title = "Open package";
			this.dlgOpenPackageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenPackageFile_FileOk);
			// 
			// pbTexturePreview
			// 
			this.pbTexturePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pbTexturePreview.BackColor = System.Drawing.SystemColors.Control;
			this.pbTexturePreview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbTexturePreview.Location = new System.Drawing.Point(10, 17);
			this.pbTexturePreview.Name = "pbTexturePreview";
			this.pbTexturePreview.Size = new System.Drawing.Size(144, 129);
			this.pbTexturePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbTexturePreview.TabIndex = 2;
			this.pbTexturePreview.TabStop = false;
			// 
			// menuPackage
			// 
			this.menuPackage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miPackage});
			// 
			// miPackage
			// 
			this.miPackage.Index = 0;
			this.miPackage.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miNewSession,
            this.menuItem1,
            this.miPackageOpen,
            this.miPackageSave,
            this.menuItem2,
            this.miOptions});
			this.miPackage.Text = "Package";
			// 
			// miNewSession
			// 
			this.miNewSession.Index = 0;
			this.miNewSession.Text = "New Session";
			this.miNewSession.Click += new System.EventHandler(this.Handle_ResetSession_Command);
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 1;
			this.menuItem1.Text = "-";
			// 
			// miPackageOpen
			// 
			this.miPackageOpen.Index = 2;
			this.miPackageOpen.Text = "Open...";
			this.miPackageOpen.Click += new System.EventHandler(this.Handle_OpenPackage_Command);
			// 
			// miPackageSave
			// 
			this.miPackageSave.Index = 3;
			this.miPackageSave.Text = "Save As...";
			this.miPackageSave.Click += new System.EventHandler(this.Handle_SavePackage_Command);
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 4;
			this.menuItem2.Text = "-";
			// 
			// miOptions
			// 
			this.miOptions.Index = 5;
			this.miOptions.Text = "Options...";
			this.miOptions.Click += new System.EventHandler(this.miOptions_Click);
			// 
			// box
			// 
			this.box.Settings = null;
			// 
			// dlgSavePackageFile
			// 
			this.dlgSavePackageFile.DefaultExt = "package";
			this.dlgSavePackageFile.Filter = "Package files (*.package)|*.package|All files (*.*)|*.*";
			this.dlgSavePackageFile.Title = "Save package";
			this.dlgSavePackageFile.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgSavePackage_FileOk);
			// 
			// cmListActions
			// 
			this.cmListActions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miOpenPackage,
            this.miMoveTo,
            this.miClear,
            this.menuItem3,
            this.miLoadMesh,
            this.miApplyMesh});
			// 
			// miOpenPackage
			// 
			this.miOpenPackage.Index = 0;
			this.miOpenPackage.Text = "Open Package...";
			this.miOpenPackage.Click += new System.EventHandler(this.Handle_OpenPackage_Command);
			// 
			// miMoveTo
			// 
			this.miMoveTo.Index = 1;
			this.miMoveTo.Text = "Move To";
			// 
			// miClear
			// 
			this.miClear.Index = 2;
			this.miClear.Text = "Clear";
			this.miClear.Click += new System.EventHandler(this.Handle_ClearPackage_Command);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 3;
			this.menuItem3.Text = "-";
			// 
			// miLoadMesh
			// 
			this.miLoadMesh.Index = 4;
			this.miLoadMesh.Text = "Load Mesh...";
			this.miLoadMesh.Click += new System.EventHandler(this.miLoadMesh_Click);
			// 
			// miApplyMesh
			// 
			this.miApplyMesh.Index = 5;
			this.miApplyMesh.Text = "Apply Mesh";
			this.miApplyMesh.Visible = false;
			// 
			// cbEnablePreview
			// 
			this.cbEnablePreview.Checked = true;
			this.cbEnablePreview.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbEnablePreview.Location = new System.Drawing.Point(10, 0);
			this.cbEnablePreview.Name = "cbEnablePreview";
			this.cbEnablePreview.Size = new System.Drawing.Size(124, 17);
			this.cbEnablePreview.TabIndex = 5;
			this.cbEnablePreview.Text = "Texture Preview";
			this.cbEnablePreview.CheckedChanged += new System.EventHandler(this.cbEnablePreview_CheckedChanged);
			// 
			// lvTxmt
			// 
			this.lvTxmt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
			this.lvTxmt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvTxmt.FullRowSelect = true;
			this.lvTxmt.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvTxmt.HideSelection = false;
			this.lvTxmt.Location = new System.Drawing.Point(0, 0);
			this.lvTxmt.Name = "lvTxmt";
			this.lvTxmt.Size = new System.Drawing.Size(375, 121);
			this.lvTxmt.TabIndex = 6;
			this.lvTxmt.UseCompatibleStateImageBehavior = false;
			this.lvTxmt.View = System.Windows.Forms.View.Details;
			this.lvTxmt.SelectedIndexChanged += new System.EventHandler(this.lvTxmt_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Name";
			this.columnHeader1.Width = 200;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Texture Ref";
			this.columnHeader2.Width = 140;
			// 
			// lvCresShpe
			// 
			this.lvCresShpe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lvCresShpe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvCresShpe.FullRowSelect = true;
			this.lvCresShpe.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvCresShpe.Location = new System.Drawing.Point(0, 0);
			this.lvCresShpe.Name = "lvCresShpe";
			this.lvCresShpe.Size = new System.Drawing.Size(375, 122);
			this.lvCresShpe.TabIndex = 7;
			this.lvCresShpe.UseCompatibleStateImageBehavior = false;
			this.lvCresShpe.View = System.Windows.Forms.View.Details;
			this.lvCresShpe.SelectedIndexChanged += new System.EventHandler(this.lvCresShpe_SelectedIndexChanged);
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Name";
			this.columnHeader3.Width = 188;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Group";
			this.columnHeader4.Width = 72;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Instance";
			this.columnHeader5.Width = 112;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "File";
			this.columnHeader6.Width = 188;
			// 
			// cmTxmtListActions
			// 
			this.cmTxmtListActions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miMatUseBaseTxtr,
            this.miMatCopyTxtrRef,
            this.miMatUseTxtrRef});
			// 
			// miMatUseBaseTxtr
			// 
			this.miMatUseBaseTxtr.Index = 0;
			this.miMatUseBaseTxtr.Text = "Use base texture";
			this.miMatUseBaseTxtr.Click += new System.EventHandler(this.miMatUseBaseTxtr_Click);
			// 
			// miMatCopyTxtrRef
			// 
			this.miMatCopyTxtrRef.Enabled = false;
			this.miMatCopyTxtrRef.Index = 1;
			this.miMatCopyTxtrRef.Text = "Copy texture reference";
			this.miMatCopyTxtrRef.Click += new System.EventHandler(this.miMatCopyTxtrRef_Click);
			// 
			// miMatUseTxtrRef
			// 
			this.miMatUseTxtrRef.Enabled = false;
			this.miMatUseTxtrRef.Index = 2;
			this.miMatUseTxtrRef.Text = "Use texture reference";
			this.miMatUseTxtrRef.Click += new System.EventHandler(this.miMatUseTxtrRef_Click);
			// 
			// cmMeshListActions
			// 
			this.cmMeshListActions.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.miCresAddToMeshList});
			// 
			// miCresAddToMeshList
			// 
			this.miCresAddToMeshList.Index = 0;
			this.miCresAddToMeshList.Text = "Add To Mesh List";
			this.miCresAddToMeshList.Click += new System.EventHandler(this.miCresAddToMeshList_Click);
			// 
			// matPanel
			// 
			this.matPanel.Controls.Add(this.splitter2);
			this.matPanel.Controls.Add(this.panel2);
			this.matPanel.Controls.Add(this.panel1);
			this.matPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.matPanel.Location = new System.Drawing.Point(0, 230);
			this.matPanel.Name = "matPanel";
			this.matPanel.Size = new System.Drawing.Size(544, 163);
			this.matPanel.TabIndex = 8;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(156, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(5, 163);
			this.splitter2.TabIndex = 10;
			this.splitter2.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tcProperties);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(156, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(388, 163);
			this.panel2.TabIndex = 9;
			// 
			// tcProperties
			// 
			this.tcProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.tcProperties.Controls.Add(this.tpMaterials);
			this.tcProperties.Controls.Add(this.tpMeshes);
			this.tcProperties.Controls.Add(this.tpClothing);
			this.tcProperties.Location = new System.Drawing.Point(5, 0);
			this.tcProperties.Name = "tcProperties";
			this.tcProperties.SelectedIndex = 0;
			this.tcProperties.Size = new System.Drawing.Size(383, 148);
			this.tcProperties.TabIndex = 0;
			// 
			// tpMaterials
			// 
			this.tpMaterials.Controls.Add(this.lvTxmt);
			this.tpMaterials.Location = new System.Drawing.Point(4, 23);
			this.tpMaterials.Name = "tpMaterials";
			this.tpMaterials.Size = new System.Drawing.Size(375, 121);
			this.tpMaterials.TabIndex = 0;
			this.tpMaterials.Text = "Materials";
			// 
			// tpMeshes
			// 
			this.tpMeshes.Controls.Add(this.lvCresShpe);
			this.tpMeshes.Location = new System.Drawing.Point(4, 22);
			this.tpMeshes.Name = "tpMeshes";
			this.tpMeshes.Size = new System.Drawing.Size(375, 122);
			this.tpMeshes.TabIndex = 1;
			this.tpMeshes.Text = "Meshes";
			// 
			// tpClothing
			// 
			this.tpClothing.Enabled = false;
			this.tpClothing.Location = new System.Drawing.Point(4, 22);
			this.tpClothing.Name = "tpClothing";
			this.tpClothing.Settings = null;
			this.tpClothing.Size = new System.Drawing.Size(375, 122);
			this.tpClothing.TabIndex = 2;
			this.tpClothing.Text = "Properties";
			this.tpClothing.SettingsChanged += new System.EventHandler(this.Handle_PropertiesTab_SettingsChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbEnablePreview);
			this.panel1.Controls.Add(this.pbTexturePreview);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(156, 163);
			this.panel1.TabIndex = 8;
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 226);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(544, 4);
			this.splitter1.TabIndex = 9;
			this.splitter1.TabStop = false;
			// 
			// mainPanel
			// 
			this.mainPanel.Controls.Add(this.tcMain);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(544, 226);
			this.mainPanel.TabIndex = 10;
			// 
			// MainForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
			this.ClientSize = new System.Drawing.Size(544, 393);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.matPanel);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.menuPackage;
			this.Name = "MainForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Color Binning Tool";
			this.Closed += new System.EventHandler(this.Handle_ResetSession_Command);
			((System.ComponentModel.ISupportInitialize)(this.pbTexturePreview)).EndInit();
			this.matPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.tcProperties.ResumeLayout(false);
			this.tpMaterials.ResumeLayout(false);
			this.tpMeshes.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.mainPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		private System.Windows.Forms.ListView lvTxmt;
		private System.Windows.Forms.ListView lvCresShpe;
		private System.Windows.Forms.ContextMenu cmTxmtListActions;
		private System.Windows.Forms.ContextMenu cmMeshListActions;
		private System.Windows.Forms.MenuItem miMoveTo;
		private System.Windows.Forms.MenuItem miMatUseBaseTxtr;
		private System.Windows.Forms.MenuItem miMatCopyTxtrRef;
		private System.Windows.Forms.MenuItem miMatUseTxtrRef;
		private System.Windows.Forms.MenuItem miCresAddToMeshList;

		private System.Windows.Forms.Panel matPanel;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.MainMenu menuPackage;
		private System.Windows.Forms.MenuItem miPackage;
		private System.Windows.Forms.MenuItem miNewSession;
		private System.Windows.Forms.MenuItem miOptions;
		private System.Windows.Forms.MenuItem miOpenPackage;
		private System.Windows.Forms.MenuItem miClear;
		private System.Windows.Forms.MenuItem miPackageOpen;
		private System.Windows.Forms.MenuItem miPackageSave;
		private System.Windows.Forms.MenuItem miLoadMesh;
		private System.Windows.Forms.MenuItem miApplyMesh;
		private System.Windows.Forms.TabControl tcProperties;
		private System.Windows.Forms.TabPage tpMaterials;
		private System.Windows.Forms.TabPage tpMeshes;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private ColumnHeader columnHeader5;
		private ColumnHeader columnHeader6;

		#endregion

	}

}