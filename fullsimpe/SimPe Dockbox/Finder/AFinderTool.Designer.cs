namespace SimPe.Interfaces
{
    partial class AFinderTool
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
            if (tm != null) tm.Clear();
            tm= null;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AFinderTool));
            this.grp = new Ambertation.Windows.Forms.XPTaskBoxSimple();
            this.content = new System.Windows.Forms.Panel();
            this.btStart = new System.Windows.Forms.Button();
            this.grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp
            // 
            this.grp.AccessibleDescription = null;
            this.grp.AccessibleName = null;
            resources.ApplyResources(this.grp, "grp");
            this.grp.BackColor = System.Drawing.Color.Transparent;
            this.grp.BackgroundImage = null;
            this.grp.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.grp.BorderColor = System.Drawing.SystemColors.Window;
            this.grp.Controls.Add(this.content);
            this.grp.Controls.Add(this.btStart);
            this.grp.Font = null;
            this.grp.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.grp.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grp.IconLocation = new System.Drawing.Point(4, 12);
            this.grp.IconSize = new System.Drawing.Size(32, 32);
            this.grp.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.grp.Name = "grp";
            this.grp.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // content
            // 
            this.content.AccessibleDescription = null;
            this.content.AccessibleName = null;
            resources.ApplyResources(this.content, "content");
            this.content.BackgroundImage = null;
            this.content.Font = null;
            this.content.Name = "content";
            // 
            // btStart
            // 
            this.btStart.AccessibleDescription = null;
            this.btStart.AccessibleName = null;
            resources.ApplyResources(this.btStart, "btStart");
            this.btStart.BackgroundImage = null;
            this.btStart.Font = null;
            this.btStart.Name = "btStart";
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // AFinderTool
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Controls.Add(this.grp);
            this.Font = null;
            this.Name = "AFinderTool";
            this.grp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btStart;
        protected System.Windows.Forms.Panel content;
        private Ambertation.Windows.Forms.XPTaskBoxSimple grp;
    }
}
