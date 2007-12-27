namespace SimPe.Plugin
{
    partial class LabelledNumericUpDown
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
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.lbLabel = new System.Windows.Forms.Label();
            this.nudValue = new System.Windows.Forms.NumericUpDown();
            this.flpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMain.Controls.Add(this.lbLabel);
            this.flpMain.Controls.Add(this.nudValue);
            this.flpMain.Location = new System.Drawing.Point(0, 0);
            this.flpMain.Margin = new System.Windows.Forms.Padding(0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(130, 28);
            this.flpMain.TabIndex = 0;
            this.flpMain.WrapContents = false;
            // 
            // lbLabel
            // 
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(3, 6);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(38, 17);
            this.lbLabel.TabIndex = 1;
            this.lbLabel.Text = "label";
            // 
            // nudValue
            // 
            this.nudValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nudValue.Location = new System.Drawing.Point(47, 3);
            this.nudValue.Name = "nudValue";
            this.nudValue.Size = new System.Drawing.Size(80, 22);
            this.nudValue.TabIndex = 2;
            this.nudValue.ValueChanged += new System.EventHandler(this.nudValue_ValueChanged);
            // 
            // LabelledNumericUpDown
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flpMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "LabelledNumericUpDown";
            this.Size = new System.Drawing.Size(130, 28);
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.NumericUpDown nudValue;
    }
}
