namespace SimPe.Windows.Forms
{
    partial class SplashForm
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.lbtxt = new System.Windows.Forms.Label();
            this.lbver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbtxt
            // 
            this.lbtxt.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lbtxt, "lbtxt");
            this.lbtxt.Name = "lbtxt";
            // 
            // lbver
            // 
            resources.ApplyResources(this.lbver, "lbver");
            this.lbver.BackColor = System.Drawing.Color.White;
            this.lbver.ForeColor = System.Drawing.Color.DimGray;
            this.lbver.Name = "lbver";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Name = "label2";
            // 
            // SplashForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbver);
            this.Controls.Add(this.lbtxt);
            this.Name = "SplashForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbtxt;
        private System.Windows.Forms.Label lbver;
        private System.Windows.Forms.Label label2;

    }
}