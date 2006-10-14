using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Plugin
{
    partial class MyDockPlugin
    {
        private System.Windows.Forms.Label label1;

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 494);
            this.label1.TabIndex = 1;
            this.label1.Text = "This is an Example GUI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyDockPlugin
            // 
            this.Controls.Add(this.label1);
            this.FloatingSize = new System.Drawing.Size(331, 520);
            this.Name = "MyDockPlugin";
            this.Size = new System.Drawing.Size(319, 494);
            this.ResumeLayout(false);

        }
    }
}
