namespace SimPe.Plugin.Tool.Dockable.Finder
{
    partial class FindTGI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindTGI));
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInstLo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbInstHi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.content.SuspendLayout();
            this.SuspendLayout();
            // 
            // content
            // 
            this.content.AccessibleDescription = null;
            this.content.AccessibleName = null;
            resources.ApplyResources(this.content, "content");
            this.content.BackgroundImage = null;
            this.content.Controls.Add(this.tbName);
            this.content.Controls.Add(this.label5);
            this.content.Controls.Add(this.tbInstHi);
            this.content.Controls.Add(this.label4);
            this.content.Controls.Add(this.tbInstLo);
            this.content.Controls.Add(this.label3);
            this.content.Controls.Add(this.tbGroup);
            this.content.Controls.Add(this.label2);
            this.content.Controls.Add(this.tbType);
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
            // tbType
            // 
            this.tbType.AccessibleDescription = null;
            this.tbType.AccessibleName = null;
            resources.ApplyResources(this.tbType, "tbType");
            this.tbType.BackgroundImage = null;
            this.tbType.Font = null;
            this.tbType.Name = "tbType";
            // 
            // tbGroup
            // 
            this.tbGroup.AccessibleDescription = null;
            this.tbGroup.AccessibleName = null;
            resources.ApplyResources(this.tbGroup, "tbGroup");
            this.tbGroup.BackgroundImage = null;
            this.tbGroup.Font = null;
            this.tbGroup.Name = "tbGroup";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tbInstLo
            // 
            this.tbInstLo.AccessibleDescription = null;
            this.tbInstLo.AccessibleName = null;
            resources.ApplyResources(this.tbInstLo, "tbInstLo");
            this.tbInstLo.BackgroundImage = null;
            this.tbInstLo.Font = null;
            this.tbInstLo.Name = "tbInstLo";
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbInstHi
            // 
            this.tbInstHi.AccessibleDescription = null;
            this.tbInstHi.AccessibleName = null;
            resources.ApplyResources(this.tbInstHi, "tbInstHi");
            this.tbInstHi.BackgroundImage = null;
            this.tbInstHi.Font = null;
            this.tbInstHi.Name = "tbInstHi";
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // tbName
            // 
            this.tbName.AccessibleDescription = null;
            this.tbName.AccessibleName = null;
            resources.ApplyResources(this.tbName, "tbName");
            this.tbName.BackgroundImage = null;
            this.tbName.Font = null;
            this.tbName.Name = "tbName";
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // FindTGI
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = null;
            this.Font = null;
            this.Name = "FindTGI";
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbInstHi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbInstLo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.Label label1;
    }
}
