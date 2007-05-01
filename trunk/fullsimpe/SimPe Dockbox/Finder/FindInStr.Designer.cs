namespace SimPe.Plugin.Tool.Dockable.Finder
{
    partial class FindInStr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindInStr));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.tbMatch = new System.Windows.Forms.TextBox();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AccessibleDescription = null;
            this.content.AccessibleName = null;
            resources.ApplyResources(this.content, "content");
            this.content.BackgroundImage = null;
            this.content.Controls.Add(this.tbMatch);
            this.content.Controls.Add(this.cbType);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.label1);
            this.content.Font = null;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // cbType
            // 
            this.cbType.AccessibleDescription = null;
            this.cbType.AccessibleName = null;
            resources.ApplyResources(this.cbType, "cbType");
            this.cbType.BackgroundImage = null;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.Font = null;
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            resources.GetString("cbType.Items"),
            resources.GetString("cbType.Items1"),
            resources.GetString("cbType.Items2"),
            resources.GetString("cbType.Items3"),
            resources.GetString("cbType.Items4")});
            this.cbType.Name = "cbType";
            // 
            // tbMatch
            // 
            this.tbMatch.AccessibleDescription = null;
            this.tbMatch.AccessibleName = null;
            resources.ApplyResources(this.tbMatch, "tbMatch");
            this.tbMatch.BackgroundImage = null;
            this.tbMatch.Font = null;
            this.tbMatch.Name = "tbMatch";
            // 
            // FindInStr
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.Name = "FindInStr";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbMatch;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
