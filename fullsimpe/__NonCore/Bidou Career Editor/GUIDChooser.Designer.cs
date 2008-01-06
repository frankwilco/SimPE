namespace SimPe.Plugin
{
    partial class GUIDChooser
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
            this.cbKnownObjects = new System.Windows.Forms.ComboBox();
            this.tbGUID = new System.Windows.Forms.TextBox();
            this.flpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            this.flpMain.AutoSize = true;
            this.flpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpMain.Controls.Add(this.lbLabel);
            this.flpMain.Controls.Add(this.cbKnownObjects);
            this.flpMain.Controls.Add(this.tbGUID);
            this.flpMain.Location = new System.Drawing.Point(3, 3);
            this.flpMain.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.flpMain.Name = "flpMain";
            this.flpMain.Size = new System.Drawing.Size(272, 24);
            this.flpMain.TabIndex = 1;
            // 
            // lbLabel
            // 
            this.lbLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbLabel.AutoSize = true;
            this.lbLabel.Location = new System.Drawing.Point(0, 3);
            this.lbLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lbLabel.Name = "lbLabel";
            this.lbLabel.Size = new System.Drawing.Size(43, 17);
            this.lbLabel.TabIndex = 1;
            this.lbLabel.Text = "Label";
            // 
            // cbKnownObjects
            // 
            this.cbKnownObjects.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbKnownObjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKnownObjects.FormattingEnabled = true;
            this.cbKnownObjects.Location = new System.Drawing.Point(43, 0);
            this.cbKnownObjects.Margin = new System.Windows.Forms.Padding(0);
            this.cbKnownObjects.Name = "cbKnownObjects";
            this.cbKnownObjects.Size = new System.Drawing.Size(121, 24);
            this.cbKnownObjects.TabIndex = 2;
            this.cbKnownObjects.SelectedIndexChanged += new System.EventHandler(this.cbKnownObjects_SelectedIndexChanged);
            // 
            // tbGUID
            // 
            this.tbGUID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbGUID.Location = new System.Drawing.Point(170, 1);
            this.tbGUID.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tbGUID.MaxLength = 10;
            this.tbGUID.Name = "tbGUID";
            this.tbGUID.Size = new System.Drawing.Size(102, 22);
            this.tbGUID.TabIndex = 3;
            this.tbGUID.Text = "0xDDDDDDDD";
            this.tbGUID.TextChanged += new System.EventHandler(this.tbGUID_TextChanged);
            this.tbGUID.Validated += new System.EventHandler(this.hex32_Validated);
            this.tbGUID.Validating += new System.ComponentModel.CancelEventHandler(this.hex32_Validating);
            // 
            // GUIDChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.flpMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GUIDChooser";
            this.Size = new System.Drawing.Size(276, 27);
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.Label lbLabel;
        private System.Windows.Forms.ComboBox cbKnownObjects;
        private System.Windows.Forms.TextBox tbGUID;
    }
}
