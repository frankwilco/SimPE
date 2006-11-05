using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    partial class ScoreItemDefault
    {
        private System.Windows.Forms.TextBox textBox1;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ScoreItemDefault
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.textBox1);
            this.Name = "ScoreItemDefault";
            this.Size = new System.Drawing.Size(261, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }   

    }
}
