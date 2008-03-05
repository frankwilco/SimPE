namespace SimPe.Plugin.Tool.Dockable.Finder
{
    partial class FindInSG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInSG));
            this.label3 = new System.Windows.Forms.Label();
            this.cbtypes = new System.Windows.Forms.ComboBox();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AccessibleDescription = null;
            this.content.AccessibleName = null;
            resources.ApplyResources(this.content, "content");
            this.content.BackgroundImage = null;
            this.content.Controls.Add(this.label3);
            this.content.Controls.Add(this.cbtypes);
            this.content.Font = null;
            this.content.Controls.SetChildIndex(this.cbtypes, 0);
            this.content.Controls.SetChildIndex(this.label3, 0);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // cbtypes
            // 
            this.cbtypes.AccessibleDescription = null;
            this.cbtypes.AccessibleName = null;
            resources.ApplyResources(this.cbtypes, "cbtypes");
            this.cbtypes.BackgroundImage = null;
            this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbtypes.Font = null;
            this.cbtypes.FormattingEnabled = true;
            this.cbtypes.Name = "cbtypes";
            // 
            // FindInSG
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.Name = "FindInSG";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbtypes;
    }
}
