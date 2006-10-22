namespace SimPe
{    
    partial class WaitControl
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pb = new System.Windows.Forms.ToolStripProgressBar();
            this.tbPercent = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbWait = new Ambertation.Windows.Forms.AnimatedToolstripItem();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pb,
            this.tbPercent,
            this.tbInfo,
            this.tbWait});
            this.statusStrip1.Location = new System.Drawing.Point(0, -1);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(610, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pb
            // 
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(400, 16);
            // 
            // tbPercent
            // 
            this.tbPercent.BackColor = System.Drawing.Color.Transparent;
            this.tbPercent.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(24, 17);
            this.tbPercent.Text = "0%";
            this.tbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbInfo
            // 
            this.tbInfo.BackColor = System.Drawing.Color.Transparent;
            this.tbInfo.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tbInfo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbInfo.Name = "tbInfo";
            this.tbInfo.Size = new System.Drawing.Size(118, 17);
            this.tbInfo.Spring = true;
            this.tbInfo.Text = "---";
            this.tbInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbWait
            // 
            this.tbWait.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbWait.AutoSize = false;
            this.tbWait.BackColor = System.Drawing.Color.Transparent;
            this.tbWait.CurrentIndex = 0;
            this.tbWait.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbWait.DoEvents = false;
            this.tbWait.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbWait.Name = "tbWait";
            this.tbWait.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tbWait.Size = new System.Drawing.Size(20, 20);
            this.tbWait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tbWait.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbWait.TimeOut = 40;
            // 
            // WaitControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Name = "WaitControl";
            this.Size = new System.Drawing.Size(610, 21);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar pb;
        private System.Windows.Forms.ToolStripStatusLabel tbPercent;
        private System.Windows.Forms.ToolStripStatusLabel tbInfo;
        private Ambertation.Windows.Forms.AnimatedToolstripItem tbWait;
    }
}
