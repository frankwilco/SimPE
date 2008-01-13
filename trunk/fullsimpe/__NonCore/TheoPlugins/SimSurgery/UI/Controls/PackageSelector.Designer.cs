namespace SimPe.Plugin.UI.Controls
{
	partial class PackageSelector
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.pbPackageIcon = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.pbPackageIcon)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbPackageIcon
			// 
			this.pbPackageIcon.BackColor = System.Drawing.Color.Transparent;
			this.pbPackageIcon.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbPackageIcon.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pbPackageIcon.Location = new System.Drawing.Point(29, 13);
			this.pbPackageIcon.Name = "pbPackageIcon";
			this.pbPackageIcon.Size = new System.Drawing.Size(64, 64);
			this.pbPackageIcon.TabIndex = 2;
			this.pbPackageIcon.TabStop = false;
			this.pbPackageIcon.Click += new System.EventHandler(this.pbPackage_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
			this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
			this.toolStrip1.Location = new System.Drawing.Point(0, 90);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(123, 23);
			this.toolStrip1.TabIndex = 6;
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = global::SimPe.Plugin.Properties.Resources.IconFind;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton1.Text = "Select...";
			this.toolStripButton1.Click += new System.EventHandler(this.SelectPackage);
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = global::SimPe.Plugin.Properties.Resources.IconClear;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 20);
			this.toolStripButton2.Text = "Clear";
			this.toolStripButton2.Click += new System.EventHandler(this.RemovePackage);
			// 
			// PackageSelector
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pbPackageIcon);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "PackageSelector";
			this.Size = new System.Drawing.Size(123, 113);
			((System.ComponentModel.ISupportInitialize)(this.pbPackageIcon)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbPackageIcon;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}
