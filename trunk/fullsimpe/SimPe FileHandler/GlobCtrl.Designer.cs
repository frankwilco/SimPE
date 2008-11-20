namespace SimPe.Plugin
{
    partial class GlobCtrl
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
            this.tbgroup = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.cbseminame = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbglobfile = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbgroup
            // 
            this.tbgroup.Location = new System.Drawing.Point(57, 54);
            this.tbgroup.Name = "tbgroup";
            this.tbgroup.ReadOnly = true;
            this.tbgroup.Size = new System.Drawing.Size(100, 20);
            this.tbgroup.TabIndex = 16;
            this.tbgroup.Text = "0x0";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(9, 62);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(47, 13);
            this.label43.TabIndex = 15;
            this.label43.Text = "Group:";
            // 
            // cbseminame
            // 
            this.cbseminame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbseminame.ItemHeight = 13;
            this.cbseminame.Location = new System.Drawing.Point(57, 30);
            this.cbseminame.Name = "cbseminame";
            this.cbseminame.Size = new System.Drawing.Size(190, 21);
            this.cbseminame.TabIndex = 14;
            this.cbseminame.SelectedIndexChanged += new System.EventHandler(this.SemiGlobalChanged);
            this.cbseminame.TextUpdate += new System.EventHandler(this.SemiGlobalChanged);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(9, 38);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(45, 13);
            this.label42.TabIndex = 12;
            this.label42.Text = "Name:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(167, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Commit";
            this.button3.Click += new System.EventHandler(this.GlobCommit);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel6.Controls.Add(this.lbglobfile);
            this.panel6.Controls.Add(this.label46);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
            this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(277, 24);
            this.panel6.TabIndex = 0;
            // 
            // lbglobfile
            // 
            this.lbglobfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbglobfile.AutoSize = true;
            this.lbglobfile.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.lbglobfile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbglobfile.Location = new System.Drawing.Point(144, 8);
            this.lbglobfile.Name = "lbglobfile";
            this.lbglobfile.Size = new System.Drawing.Size(44, 13);
            this.lbglobfile.TabIndex = 3;
            this.lbglobfile.Text = "no File";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label46.Location = new System.Drawing.Point(0, 4);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(138, 16);
            this.label46.TabIndex = 0;
            this.label46.Text = "Global Data Editor";
            // 
            // GlobCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbgroup);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.cbseminame);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.button3);
            this.Name = "GlobCtrl";
            this.Size = new System.Drawing.Size(277, 141);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox tbgroup;
        private System.Windows.Forms.Label label43;
        internal System.Windows.Forms.ComboBox cbseminame;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel6;
        internal System.Windows.Forms.Label lbglobfile;
        private System.Windows.Forms.Label label46;
    }
}
