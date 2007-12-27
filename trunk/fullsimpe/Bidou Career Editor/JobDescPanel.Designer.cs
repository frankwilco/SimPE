namespace SimPe.Plugin
{
    partial class JobDescPanel
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.ColumnCount = 2;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.Controls.Add(this.tbDesc, 1, 1);
            this.tlpMain.Controls.Add(this.lbDesc, 0, 1);
            this.tlpMain.Controls.Add(this.lbTitle, 0, 0);
            this.tlpMain.Controls.Add(this.tbTitle, 1, 0);
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.Size = new System.Drawing.Size(367, 192);
            this.tlpMain.TabIndex = 0;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(56, 31);
            this.tbDesc.Multiline = true;
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(308, 158);
            this.tbDesc.TabIndex = 4;
            this.tbDesc.Text = "Desc X";
            this.tbDesc.TextChanged += new System.EventHandler(this.tbDesc_TextChanged);
            // 
            // lbDesc
            // 
            this.lbDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(0, 31);
            this.lbDesc.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(53, 17);
            this.lbDesc.TabIndex = 3;
            this.lbDesc.Text = "Desc X";
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(5, 3);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(48, 17);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title X";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(56, 3);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(308, 22);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.Text = "Title X";
            this.tbTitle.TextChanged += new System.EventHandler(this.tbTitle_TextChanged);
            // 
            // JobDescPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpMain);
            this.Name = "JobDescPanel";
            this.Size = new System.Drawing.Size(367, 192);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox tbTitle;

    }
}
