namespace SimPe.Plugin.UI
{
	partial class FilePackageView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilePackageView));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lvPackages = new System.Windows.Forms.ListView();
			this.lvPropertySet = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lvPackages);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lvPropertySet);
			this.splitContainer1.Size = new System.Drawing.Size(357, 228);
			this.splitContainer1.SplitterDistance = 119;
			this.splitContainer1.TabIndex = 0;
			// 
			// lvPackages
			// 
			this.lvPackages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPackages.Location = new System.Drawing.Point(0, 0);
			this.lvPackages.Name = "lvPackages";
			this.lvPackages.Size = new System.Drawing.Size(119, 228);
			this.lvPackages.SmallImageList = this.imageList1;
			this.lvPackages.TabIndex = 0;
			this.lvPackages.UseCompatibleStateImageBehavior = false;
			this.lvPackages.View = System.Windows.Forms.View.List;
			// 
			// lvPropertySet
			// 
			this.lvPropertySet.CheckBoxes = true;
			this.lvPropertySet.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvPropertySet.Location = new System.Drawing.Point(0, 0);
			this.lvPropertySet.Name = "lvPropertySet";
			this.lvPropertySet.Size = new System.Drawing.Size(234, 228);
			this.lvPropertySet.TabIndex = 0;
			this.lvPropertySet.UseCompatibleStateImageBehavior = false;
			this.lvPropertySet.View = System.Windows.Forms.View.Details;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "kthememgr.png");
			this.imageList1.Images.SetKeyName(1, "kmenuedit.png");
			// 
			// FilePackageView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "FilePackageView";
			this.Size = new System.Drawing.Size(357, 228);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ListView lvPackages;
		private System.Windows.Forms.ListView lvPropertySet;
		private System.Windows.Forms.ImageList imageList1;
	}
}
