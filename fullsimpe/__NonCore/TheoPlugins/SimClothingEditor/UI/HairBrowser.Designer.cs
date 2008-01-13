namespace SimPe.Plugin.UI
{
	partial class HairBrowser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HairBrowser));
			this.tsHairColor = new System.Windows.Forms.ToolStrip();
			this.btColorBlack = new System.Windows.Forms.ToolStripButton();
			this.btColorBrown = new System.Windows.Forms.ToolStripButton();
			this.btColorBlond = new System.Windows.Forms.ToolStripButton();
			this.btColorRed = new System.Windows.Forms.ToolStripButton();
			this.btColorGrey = new System.Windows.Forms.ToolStripButton();
			this.btColorCustom = new System.Windows.Forms.ToolStripButton();
			this.tsHairColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsHairColor
			// 
			this.tsHairColor.ImageScalingSize = new System.Drawing.Size(40, 40);
			this.tsHairColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btColorBlack,
            this.btColorBrown,
            this.btColorBlond,
            this.btColorRed,
            this.btColorGrey,
            this.btColorCustom});
			this.tsHairColor.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			resources.ApplyResources(this.tsHairColor, "tsHairColor");
			this.tsHairColor.Name = "tsHairColor";
			this.tsHairColor.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsHairColor_ItemClicked);
			// 
			// btColorBlack
			// 
			this.btColorBlack.CheckOnClick = true;
			this.btColorBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorBlack, "btColorBlack");
			this.btColorBlack.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorBlack.Name = "btColorBlack";
			this.btColorBlack.Tag = new System.Guid("00000001-0000-0000-0000-000000000000");
			// 
			// btColorBrown
			// 
			this.btColorBrown.CheckOnClick = true;
			this.btColorBrown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorBrown, "btColorBrown");
			this.btColorBrown.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorBrown.Name = "btColorBrown";
			this.btColorBrown.Tag = new System.Guid("00000002-0000-0000-0000-000000000000");
			// 
			// btColorBlond
			// 
			this.btColorBlond.CheckOnClick = true;
			this.btColorBlond.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorBlond, "btColorBlond");
			this.btColorBlond.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorBlond.Name = "btColorBlond";
			this.btColorBlond.Tag = new System.Guid("00000003-0000-0000-0000-000000000000");
			// 
			// btColorRed
			// 
			this.btColorRed.CheckOnClick = true;
			this.btColorRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorRed, "btColorRed");
			this.btColorRed.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorRed.Name = "btColorRed";
			this.btColorRed.Tag = new System.Guid("00000004-0000-0000-0000-000000000000");
			// 
			// btColorGrey
			// 
			this.btColorGrey.CheckOnClick = true;
			this.btColorGrey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorGrey, "btColorGrey");
			this.btColorGrey.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorGrey.Name = "btColorGrey";
			this.btColorGrey.Tag = new System.Guid("00000005-0000-0000-0000-000000000000");
			// 
			// btColorCustom
			// 
			this.btColorCustom.CheckOnClick = true;
			this.btColorCustom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			resources.ApplyResources(this.btColorCustom, "btColorCustom");
			this.btColorCustom.Margin = new System.Windows.Forms.Padding(2, 1, 10, 2);
			this.btColorCustom.Name = "btColorCustom";
			this.btColorCustom.Tag = new System.Guid("00000000-0000-0000-0000-000000000000");
			// 
			// HairBrowser
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tsHairColor);
			this.Name = "HairBrowser";
			this.Controls.SetChildIndex(this.tsHairColor, 1);
			this.tsHairColor.ResumeLayout(false);
			this.tsHairColor.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip tsHairColor;
		private System.Windows.Forms.ToolStripButton btColorBlack;
		private System.Windows.Forms.ToolStripButton btColorBrown;
		private System.Windows.Forms.ToolStripButton btColorBlond;
		private System.Windows.Forms.ToolStripButton btColorRed;
		private System.Windows.Forms.ToolStripButton btColorCustom;
		private System.Windows.Forms.ToolStripButton btColorGrey;
	}
}