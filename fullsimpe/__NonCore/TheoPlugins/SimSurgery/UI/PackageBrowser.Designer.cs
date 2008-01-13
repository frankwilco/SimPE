namespace SimPe.Plugin.UI
{
	partial class PackageBrowser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackageBrowser));
			this.lvPackage = new System.Windows.Forms.ListView();
			this.ch1 = new System.Windows.Forms.ColumnHeader();
			this.ch2 = new System.Windows.Forms.ColumnHeader();
			this.ch3 = new System.Windows.Forms.ColumnHeader();
			this.ch4 = new System.Windows.Forms.ColumnHeader();
			this.cmListActions = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ilPackage = new System.Windows.Forms.ImageList(this.components);
			this.ilPackageSmall = new System.Windows.Forms.ImageList(this.components);
			this.btOK = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.dlgOpenPackage = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tscbViewMode = new System.Windows.Forms.ToolStripComboBox();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showHiddenItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cmListActions.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvPackage
			// 
			resources.ApplyResources(this.lvPackage, "lvPackage");
			this.lvPackage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lvPackage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch1,
            this.ch2,
            this.ch3,
            this.ch4});
			this.lvPackage.ContextMenuStrip = this.cmListActions;
			this.lvPackage.FullRowSelect = true;
			this.lvPackage.HideSelection = false;
			this.lvPackage.LargeImageList = this.ilPackage;
			this.lvPackage.MultiSelect = false;
			this.lvPackage.Name = "lvPackage";
			this.lvPackage.ShowItemToolTips = true;
			this.lvPackage.SmallImageList = this.ilPackageSmall;
			this.lvPackage.UseCompatibleStateImageBehavior = false;
			this.lvPackage.DoubleClick += new System.EventHandler(this.lvPackage_DoubleClick);
			this.lvPackage.SelectedIndexChanged += new System.EventHandler(this.lvPackage_SelectedIndexChanged);
			this.lvPackage.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.Handle_ListView_ColumnClick);
			this.lvPackage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvPackage_KeyPress);
			// 
			// ch1
			// 
			resources.ApplyResources(this.ch1, "ch1");
			// 
			// ch2
			// 
			resources.ApplyResources(this.ch2, "ch2");
			// 
			// ch3
			// 
			resources.ApplyResources(this.ch3, "ch3");
			// 
			// ch4
			// 
			resources.ApplyResources(this.ch4, "ch4");
			// 
			// cmListActions
			// 
			this.cmListActions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPackagesToolStripMenuItem});
			this.cmListActions.Name = "cmListActions";
			resources.ApplyResources(this.cmListActions, "cmListActions");
			// 
			// openPackagesToolStripMenuItem
			// 
			this.openPackagesToolStripMenuItem.Name = "openPackagesToolStripMenuItem";
			resources.ApplyResources(this.openPackagesToolStripMenuItem, "openPackagesToolStripMenuItem");
			this.openPackagesToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// ilPackage
			// 
			this.ilPackage.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			resources.ApplyResources(this.ilPackage, "ilPackage");
			this.ilPackage.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// ilPackageSmall
			// 
			this.ilPackageSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			resources.ApplyResources(this.ilPackageSmall, "ilPackageSmall");
			this.ilPackageSmall.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// btOK
			// 
			resources.ApplyResources(this.btOK, "btOK");
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Name = "btOK";
			this.btOK.UseVisualStyleBackColor = true;
			this.btOK.Click += new System.EventHandler(this.btOK_Click);
			// 
			// btCancel
			// 
			resources.ApplyResources(this.btCancel, "btCancel");
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Name = "btCancel";
			this.btCancel.UseVisualStyleBackColor = true;
			this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
			// 
			// dlgOpenPackage
			// 
			this.dlgOpenPackage.DefaultExt = "package";
			resources.ApplyResources(this.dlgOpenPackage, "dlgOpenPackage");
			this.dlgOpenPackage.Multiselect = true;
			this.dlgOpenPackage.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgOpenPackage_FileOk);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tscbViewMode,
            this.optionsToolStripMenuItem});
			resources.ApplyResources(this.menuStrip1, "menuStrip1");
			this.menuStrip1.Name = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// tscbViewMode
			// 
			this.tscbViewMode.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tscbViewMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.tscbViewMode.Name = "tscbViewMode";
			resources.ApplyResources(this.tscbViewMode, "tscbViewMode");
			this.tscbViewMode.SelectedIndexChanged += new System.EventHandler(this.tscbViewMode_SelectedIndexChanged);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHiddenItemsToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			resources.ApplyResources(this.optionsToolStripMenuItem, "optionsToolStripMenuItem");
			// 
			// showHiddenItemsToolStripMenuItem
			// 
			this.showHiddenItemsToolStripMenuItem.CheckOnClick = true;
			this.showHiddenItemsToolStripMenuItem.Name = "showHiddenItemsToolStripMenuItem";
			resources.ApplyResources(this.showHiddenItemsToolStripMenuItem, "showHiddenItemsToolStripMenuItem");
			this.showHiddenItemsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.showHiddenItemsToolStripMenuItem_CheckedChanged);
			// 
			// PackageBrowser
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.Controls.Add(this.lvPackage);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "PackageBrowser";
			this.cmListActions.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvPackage;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.ImageList ilPackage;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.OpenFileDialog dlgOpenPackage;
		private System.Windows.Forms.ColumnHeader ch1;
		private System.Windows.Forms.ColumnHeader ch2;
		private System.Windows.Forms.ColumnHeader ch3;
		private System.Windows.Forms.ColumnHeader ch4;
		private System.Windows.Forms.ImageList ilPackageSmall;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox tscbViewMode;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showHiddenItemsToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip cmListActions;
		private System.Windows.Forms.ToolStripMenuItem openPackagesToolStripMenuItem;
	}
}