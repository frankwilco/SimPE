namespace SimPe.PackedFiles.UserInterface
{
	partial class ClothingEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClothingEditor));
			this.tsCategory = new System.Windows.Forms.ToolStrip();
			this.btCatEveryday = new System.Windows.Forms.ToolStripButton();
			this.btCatFormal = new System.Windows.Forms.ToolStripButton();
			this.btCatPJ = new System.Windows.Forms.ToolStripButton();
			this.btCatUndies = new System.Windows.Forms.ToolStripButton();
			this.btCatSwimwear = new System.Windows.Forms.ToolStripButton();
			this.btCatActivewear = new System.Windows.Forms.ToolStripButton();
			this.btCatPregnant = new System.Windows.Forms.ToolStripButton();
			this.btCatUnknown = new System.Windows.Forms.ToolStripButton();
			this.pnClothing = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btSelectPackage = new System.Windows.Forms.ToolStripButton();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.pgMain = new System.Windows.Forms.PropertyGrid();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.lvTextures = new System.Windows.Forms.ListView();
			this.ilTexturePreview = new System.Windows.Forms.ImageList(this.components);
			this.tsOutfit = new System.Windows.Forms.ToolStrip();
			this.btOutfitHead = new System.Windows.Forms.ToolStripButton();
			this.btOutfitFace = new System.Windows.Forms.ToolStripButton();
			this.btOutfitBody = new System.Windows.Forms.ToolStripButton();
			this.btOutfitTop = new System.Windows.Forms.ToolStripButton();
			this.btOutfitBottom = new System.Windows.Forms.ToolStripButton();
			this.tsCategory.SuspendLayout();
			this.pnClothing.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tsOutfit.SuspendLayout();
			this.SuspendLayout();
			// 
			// tsCategory
			// 
			this.tsCategory.Dock = System.Windows.Forms.DockStyle.None;
			this.tsCategory.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsCategory.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btCatEveryday,
            this.btCatFormal,
            this.btCatPJ,
            this.btCatUndies,
            this.btCatSwimwear,
            this.btCatActivewear,
            this.btCatPregnant,
            this.btCatUnknown});
			this.tsCategory.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tsCategory.Location = new System.Drawing.Point(8, 24);
			this.tsCategory.Name = "tsCategory";
			this.tsCategory.Padding = new System.Windows.Forms.Padding(2, 0, 1, 0);
			this.tsCategory.Size = new System.Drawing.Size(311, 40);
			this.tsCategory.TabIndex = 0;
			this.tsCategory.Text = "Categories";
			// 
			// btCatEveryday
			// 
			this.btCatEveryday.CheckOnClick = true;
			this.btCatEveryday.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatEveryday.Image = ((System.Drawing.Image)(resources.GetObject("btCatEveryday.Image")));
			this.btCatEveryday.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatEveryday.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatEveryday.Name = "btCatEveryday";
			this.btCatEveryday.Padding = new System.Windows.Forms.Padding(6, 1, 4, 0);
			this.btCatEveryday.Size = new System.Drawing.Size(39, 37);
			this.btCatEveryday.Text = "Everyday";
			this.btCatEveryday.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatFormal
			// 
			this.btCatFormal.CheckOnClick = true;
			this.btCatFormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatFormal.Image = ((System.Drawing.Image)(resources.GetObject("btCatFormal.Image")));
			this.btCatFormal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatFormal.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatFormal.Name = "btCatFormal";
			this.btCatFormal.Padding = new System.Windows.Forms.Padding(1, 6, 0, 6);
			this.btCatFormal.Size = new System.Drawing.Size(39, 37);
			this.btCatFormal.Text = "Formal";
			this.btCatFormal.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatPJ
			// 
			this.btCatPJ.CheckOnClick = true;
			this.btCatPJ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatPJ.Image = ((System.Drawing.Image)(resources.GetObject("btCatPJ.Image")));
			this.btCatPJ.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatPJ.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatPJ.Name = "btCatPJ";
			this.btCatPJ.Padding = new System.Windows.Forms.Padding(5, 0, 3, 0);
			this.btCatPJ.Size = new System.Drawing.Size(39, 37);
			this.btCatPJ.Text = "PJ\'s";
			this.btCatPJ.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatUndies
			// 
			this.btCatUndies.CheckOnClick = true;
			this.btCatUndies.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatUndies.Image = ((System.Drawing.Image)(resources.GetObject("btCatUndies.Image")));
			this.btCatUndies.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatUndies.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatUndies.Name = "btCatUndies";
			this.btCatUndies.Size = new System.Drawing.Size(39, 37);
			this.btCatUndies.Text = "Undies";
			this.btCatUndies.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatSwimwear
			// 
			this.btCatSwimwear.CheckOnClick = true;
			this.btCatSwimwear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatSwimwear.Image = ((System.Drawing.Image)(resources.GetObject("btCatSwimwear.Image")));
			this.btCatSwimwear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatSwimwear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatSwimwear.Name = "btCatSwimwear";
			this.btCatSwimwear.Padding = new System.Windows.Forms.Padding(4, 0, 3, 0);
			this.btCatSwimwear.Size = new System.Drawing.Size(39, 37);
			this.btCatSwimwear.Text = "Swimwear";
			this.btCatSwimwear.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatActivewear
			// 
			this.btCatActivewear.CheckOnClick = true;
			this.btCatActivewear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatActivewear.Image = ((System.Drawing.Image)(resources.GetObject("btCatActivewear.Image")));
			this.btCatActivewear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatActivewear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatActivewear.Name = "btCatActivewear";
			this.btCatActivewear.Padding = new System.Windows.Forms.Padding(6, 1, 5, 0);
			this.btCatActivewear.Size = new System.Drawing.Size(39, 37);
			this.btCatActivewear.Text = "Sportswear";
			this.btCatActivewear.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatPregnant
			// 
			this.btCatPregnant.CheckOnClick = true;
			this.btCatPregnant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatPregnant.Image = ((System.Drawing.Image)(resources.GetObject("btCatPregnant.Image")));
			this.btCatPregnant.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatPregnant.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatPregnant.Name = "btCatPregnant";
			this.btCatPregnant.Padding = new System.Windows.Forms.Padding(0, 0, 6, 0);
			this.btCatPregnant.Size = new System.Drawing.Size(33, 37);
			this.btCatPregnant.Text = "Maternity";
			this.btCatPregnant.Click += new System.EventHandler(this.CategorySelect);
			// 
			// btCatUnknown
			// 
			this.btCatUnknown.CheckOnClick = true;
			this.btCatUnknown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btCatUnknown.Image = ((System.Drawing.Image)(resources.GetObject("btCatUnknown.Image")));
			this.btCatUnknown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btCatUnknown.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btCatUnknown.Name = "btCatUnknown";
			this.btCatUnknown.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.btCatUnknown.Size = new System.Drawing.Size(39, 37);
			this.btCatUnknown.Text = "Unknown category";
			this.btCatUnknown.Click += new System.EventHandler(this.CategorySelect);
			// 
			// pnClothing
			// 
			this.pnClothing.BackColor = System.Drawing.Color.Transparent;
			this.pnClothing.Controls.Add(this.toolStrip1);
			this.pnClothing.Controls.Add(this.label3);
			this.pnClothing.Controls.Add(this.label2);
			this.pnClothing.Controls.Add(this.splitContainer1);
			this.pnClothing.Controls.Add(this.tsOutfit);
			this.pnClothing.Controls.Add(this.tsCategory);
			this.pnClothing.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnClothing.Location = new System.Drawing.Point(0, 24);
			this.pnClothing.Name = "pnClothing";
			this.pnClothing.Padding = new System.Windows.Forms.Padding(8);
			this.pnClothing.Size = new System.Drawing.Size(507, 434);
			this.pnClothing.TabIndex = 1;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btSelectPackage});
			this.toolStrip1.Location = new System.Drawing.Point(8, 401);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(491, 25);
			this.toolStrip1.TabIndex = 8;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btSelectPackage
			// 
			this.btSelectPackage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btSelectPackage.Enabled = false;
			this.btSelectPackage.Image = ((System.Drawing.Image)(resources.GetObject("btSelectPackage.Image")));
			this.btSelectPackage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btSelectPackage.Name = "btSelectPackage";
			this.btSelectPackage.Size = new System.Drawing.Size(64, 22);
			this.btSelectPackage.Text = "Change...";
			this.btSelectPackage.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(437, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Outfit Type";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 5);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Category";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(8, 72);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.pgMain);
			this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(3);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.checkBox1);
			this.splitContainer1.Panel2.Controls.Add(this.lvTextures);
			this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(4);
			this.splitContainer1.Size = new System.Drawing.Size(491, 326);
			this.splitContainer1.SplitterDistance = 316;
			this.splitContainer1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Properties";
			// 
			// pgMain
			// 
			this.pgMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pgMain.HelpVisible = false;
			this.pgMain.Location = new System.Drawing.Point(3, 21);
			this.pgMain.Name = "pgMain";
			this.pgMain.PropertySort = System.Windows.Forms.PropertySort.Categorized;
			this.pgMain.Size = new System.Drawing.Size(310, 301);
			this.pgMain.TabIndex = 5;
			this.pgMain.ToolbarVisible = false;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(4, 2);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(105, 17);
			this.checkBox1.TabIndex = 1;
			this.checkBox1.Text = "Texture Preview";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// lvTextures
			// 
			this.lvTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lvTextures.LargeImageList = this.ilTexturePreview;
			this.lvTextures.Location = new System.Drawing.Point(4, 21);
			this.lvTextures.Name = "lvTextures";
			this.lvTextures.Size = new System.Drawing.Size(165, 301);
			this.lvTextures.TabIndex = 0;
			this.lvTextures.UseCompatibleStateImageBehavior = false;
			// 
			// ilTexturePreview
			// 
			this.ilTexturePreview.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilTexturePreview.ImageSize = new System.Drawing.Size(112, 112);
			this.ilTexturePreview.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tsOutfit
			// 
			this.tsOutfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tsOutfit.Dock = System.Windows.Forms.DockStyle.None;
			this.tsOutfit.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsOutfit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btOutfitHead,
            this.btOutfitFace,
            this.btOutfitBody,
            this.btOutfitTop,
            this.btOutfitBottom});
			this.tsOutfit.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tsOutfit.Location = new System.Drawing.Point(365, 24);
			this.tsOutfit.Name = "tsOutfit";
			this.tsOutfit.Padding = new System.Windows.Forms.Padding(3, 3, 1, 2);
			this.tsOutfit.Size = new System.Drawing.Size(134, 40);
			this.tsOutfit.TabIndex = 2;
			this.tsOutfit.Text = "Categories";
			// 
			// btOutfitHead
			// 
			this.btOutfitHead.CheckOnClick = true;
			this.btOutfitHead.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btOutfitHead.Image = ((System.Drawing.Image)(resources.GetObject("btOutfitHead.Image")));
			this.btOutfitHead.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btOutfitHead.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btOutfitHead.Name = "btOutfitHead";
			this.btOutfitHead.Padding = new System.Windows.Forms.Padding(3, 0, 2, 0);
			this.btOutfitHead.Size = new System.Drawing.Size(32, 32);
			this.btOutfitHead.Text = "Head/Hair";
			this.btOutfitHead.Click += new System.EventHandler(this.OutfitSelect);
			// 
			// btOutfitFace
			// 
			this.btOutfitFace.CheckOnClick = true;
			this.btOutfitFace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btOutfitFace.Image = ((System.Drawing.Image)(resources.GetObject("btOutfitFace.Image")));
			this.btOutfitFace.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btOutfitFace.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btOutfitFace.Name = "btOutfitFace";
			this.btOutfitFace.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.btOutfitFace.Size = new System.Drawing.Size(32, 32);
			this.btOutfitFace.Text = "Face";
			this.btOutfitFace.Visible = false;
			this.btOutfitFace.Click += new System.EventHandler(this.OutfitSelect);
			// 
			// btOutfitBody
			// 
			this.btOutfitBody.CheckOnClick = true;
			this.btOutfitBody.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btOutfitBody.Image = ((System.Drawing.Image)(resources.GetObject("btOutfitBody.Image")));
			this.btOutfitBody.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btOutfitBody.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btOutfitBody.Name = "btOutfitBody";
			this.btOutfitBody.Padding = new System.Windows.Forms.Padding(6, 1, 5, 1);
			this.btOutfitBody.Size = new System.Drawing.Size(32, 32);
			this.btOutfitBody.Text = "Full Body";
			this.btOutfitBody.Click += new System.EventHandler(this.OutfitSelect);
			// 
			// btOutfitTop
			// 
			this.btOutfitTop.CheckOnClick = true;
			this.btOutfitTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btOutfitTop.Image = ((System.Drawing.Image)(resources.GetObject("btOutfitTop.Image")));
			this.btOutfitTop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btOutfitTop.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btOutfitTop.Name = "btOutfitTop";
			this.btOutfitTop.Padding = new System.Windows.Forms.Padding(1, 4, 2, 3);
			this.btOutfitTop.Size = new System.Drawing.Size(32, 32);
			this.btOutfitTop.Text = "Top";
			this.btOutfitTop.Click += new System.EventHandler(this.OutfitSelect);
			// 
			// btOutfitBottom
			// 
			this.btOutfitBottom.CheckOnClick = true;
			this.btOutfitBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btOutfitBottom.Image = ((System.Drawing.Image)(resources.GetObject("btOutfitBottom.Image")));
			this.btOutfitBottom.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.btOutfitBottom.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btOutfitBottom.Name = "btOutfitBottom";
			this.btOutfitBottom.Padding = new System.Windows.Forms.Padding(4, 2, 3, 1);
			this.btOutfitBottom.Size = new System.Drawing.Size(32, 32);
			this.btOutfitBottom.Text = "Bottom";
			this.btOutfitBottom.Click += new System.EventHandler(this.OutfitSelect);
			// 
			// ClothingEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pnClothing);
			this.HeaderText = "Clothing Editor";
			this.MinimumSize = new System.Drawing.Size(430, 256);
			this.Name = "ClothingEditor";
			this.Size = new System.Drawing.Size(507, 458);
			this.Controls.SetChildIndex(this.pnClothing, 0);
			this.tsCategory.ResumeLayout(false);
			this.tsCategory.PerformLayout();
			this.pnClothing.ResumeLayout(false);
			this.pnClothing.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			this.splitContainer1.ResumeLayout(false);
			this.tsOutfit.ResumeLayout(false);
			this.tsOutfit.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ToolStrip tsCategory;
		private System.Windows.Forms.Panel pnClothing;
		private System.Windows.Forms.ToolStripButton btCatEveryday;
		private System.Windows.Forms.ToolStripButton btCatFormal;
		private System.Windows.Forms.ToolStripButton btCatPJ;
		private System.Windows.Forms.ToolStripButton btCatUndies;
		private System.Windows.Forms.ToolStripButton btCatSwimwear;
		private System.Windows.Forms.ToolStripButton btCatActivewear;
		private System.Windows.Forms.ToolStrip tsOutfit;
		private System.Windows.Forms.ToolStripButton btOutfitHead;
		private System.Windows.Forms.ToolStripButton btOutfitFace;
		private System.Windows.Forms.ToolStripButton btOutfitTop;
		private System.Windows.Forms.ToolStripButton btOutfitBody;
		private System.Windows.Forms.ToolStripButton btOutfitBottom;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ToolStripButton btCatPregnant;
		private System.Windows.Forms.ToolStripButton btCatUnknown;
		private System.Windows.Forms.PropertyGrid pgMain;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.ListView lvTextures;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ImageList ilTexturePreview;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btSelectPackage;
	}
}
