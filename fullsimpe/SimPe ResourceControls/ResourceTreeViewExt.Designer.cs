namespace SimPe.Windows.Forms
{
    partial class ResourceTreeViewExt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceTreeViewExt));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbInst = new System.Windows.Forms.ToolStripButton();
            this.tbGroup = new System.Windows.Forms.ToolStripButton();
            this.tbType = new System.Windows.Forms.ToolStripButton();
            this.tv = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AccessibleDescription = null;
            this.toolStrip1.AccessibleName = null;
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.BackgroundImage = null;
            this.toolStrip1.Font = null;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbInst,
            this.tbGroup,
            this.tbType});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Name = "toolStrip1";
            // 
            // tbInst
            // 
            this.tbInst.AccessibleDescription = null;
            this.tbInst.AccessibleName = null;
            this.tbInst.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.tbInst, "tbInst");
            this.tbInst.BackgroundImage = null;
            this.tbInst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbInst.Name = "tbInst";
            this.tbInst.Click += new System.EventHandler(this.SelectTreeBuilder);
            // 
            // tbGroup
            // 
            this.tbGroup.AccessibleDescription = null;
            this.tbGroup.AccessibleName = null;
            resources.ApplyResources(this.tbGroup, "tbGroup");
            this.tbGroup.BackgroundImage = null;
            this.tbGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.Click += new System.EventHandler(this.SelectTreeBuilder);
            // 
            // tbType
            // 
            this.tbType.AccessibleDescription = null;
            this.tbType.AccessibleName = null;
            resources.ApplyResources(this.tbType, "tbType");
            this.tbType.BackgroundImage = null;
            this.tbType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbType.Name = "tbType";
            this.tbType.Click += new System.EventHandler(this.SelectTreeBuilder);
            // 
            // tv
            // 
            this.tv.AccessibleDescription = null;
            this.tv.AccessibleName = null;
            resources.ApplyResources(this.tv, "tv");
            this.tv.BackgroundImage = null;
            this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tv.Font = null;
            this.tv.HideSelection = false;
            this.tv.Name = "tv";
            this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
            // 
            // ResourceTreeViewExt
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.tv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ResourceTreeViewExt";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TreeView tv;
        private System.Windows.Forms.ToolStripButton tbInst;
        private System.Windows.Forms.ToolStripButton tbGroup;
        private System.Windows.Forms.ToolStripButton tbType;
    }
}
