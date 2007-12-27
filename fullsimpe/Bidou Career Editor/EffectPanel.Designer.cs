namespace SimPe.Plugin
{
    partial class EffectPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EffectPanel));
            this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flpEffect = new System.Windows.Forms.FlowLayoutPanel();
            this.lbEffect = new System.Windows.Forms.Label();
            this.lnudCooking = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudMechanical = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCharisma = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudBody = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCreativity = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudLogic = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCleaning = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudMoney = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudJobLevels = new SimPe.Plugin.LabelledNumericUpDown();
            this.flpText = new System.Windows.Forms.FlowLayoutPanel();
            this.flpMale = new System.Windows.Forms.FlowLayoutPanel();
            this.lbMale = new System.Windows.Forms.Label();
            this.tbMale = new System.Windows.Forms.TextBox();
            this.llCopy = new System.Windows.Forms.LinkLabel();
            this.flpFemale = new System.Windows.Forms.FlowLayoutPanel();
            this.lbFemale = new System.Windows.Forms.Label();
            this.tbFemale = new System.Windows.Forms.TextBox();
            this.flpMain.SuspendLayout();
            this.flpEffect.SuspendLayout();
            this.flpText.SuspendLayout();
            this.flpMale.SuspendLayout();
            this.flpFemale.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpMain
            // 
            resources.ApplyResources(this.flpMain, "flpMain");
            this.flpMain.Controls.Add(this.flpEffect);
            this.flpMain.Controls.Add(this.flpText);
            this.flpMain.Name = "flpMain";
            // 
            // flpEffect
            // 
            resources.ApplyResources(this.flpEffect, "flpEffect");
            this.flpEffect.Controls.Add(this.lbEffect);
            this.flpEffect.Controls.Add(this.lnudCooking);
            this.flpEffect.Controls.Add(this.lnudMechanical);
            this.flpEffect.Controls.Add(this.lnudCharisma);
            this.flpEffect.Controls.Add(this.lnudBody);
            this.flpEffect.Controls.Add(this.lnudCreativity);
            this.flpEffect.Controls.Add(this.lnudLogic);
            this.flpEffect.Controls.Add(this.lnudCleaning);
            this.flpEffect.Controls.Add(this.lnudMoney);
            this.flpEffect.Controls.Add(this.lnudJobLevels);
            this.flpEffect.Name = "flpEffect";
            // 
            // lbEffect
            // 
            resources.ApplyResources(this.lbEffect, "lbEffect");
            this.lbEffect.Name = "lbEffect";
            // 
            // lnudCooking
            // 
            resources.ApplyResources(this.lnudCooking, "lnudCooking");
            this.lnudCooking.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudCooking.Label = "Cooking";
            this.lnudCooking.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudCooking.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudCooking.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudCooking.Name = "lnudCooking";
            this.lnudCooking.NoLabel = false;
            this.lnudCooking.ReadOnly = false;
            this.lnudCooking.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudCooking.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudMechanical
            // 
            resources.ApplyResources(this.lnudMechanical, "lnudMechanical");
            this.lnudMechanical.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudMechanical.Label = "Mechanical";
            this.lnudMechanical.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudMechanical.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudMechanical.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudMechanical.Name = "lnudMechanical";
            this.lnudMechanical.NoLabel = false;
            this.lnudMechanical.ReadOnly = false;
            this.lnudMechanical.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudMechanical.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudCharisma
            // 
            resources.ApplyResources(this.lnudCharisma, "lnudCharisma");
            this.lnudCharisma.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudCharisma.Label = "Charisma";
            this.lnudCharisma.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudCharisma.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudCharisma.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudCharisma.Name = "lnudCharisma";
            this.lnudCharisma.NoLabel = false;
            this.lnudCharisma.ReadOnly = false;
            this.lnudCharisma.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudCharisma.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudBody
            // 
            resources.ApplyResources(this.lnudBody, "lnudBody");
            this.lnudBody.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudBody.Label = "Body";
            this.lnudBody.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudBody.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudBody.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudBody.Name = "lnudBody";
            this.lnudBody.NoLabel = false;
            this.lnudBody.ReadOnly = false;
            this.lnudBody.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudBody.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudCreativity
            // 
            resources.ApplyResources(this.lnudCreativity, "lnudCreativity");
            this.lnudCreativity.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudCreativity.Label = "Creativity";
            this.lnudCreativity.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudCreativity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudCreativity.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudCreativity.Name = "lnudCreativity";
            this.lnudCreativity.NoLabel = false;
            this.lnudCreativity.ReadOnly = false;
            this.lnudCreativity.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudCreativity.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudLogic
            // 
            resources.ApplyResources(this.lnudLogic, "lnudLogic");
            this.lnudLogic.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudLogic.Label = "Logic";
            this.lnudLogic.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudLogic.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudLogic.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudLogic.Name = "lnudLogic";
            this.lnudLogic.NoLabel = false;
            this.lnudLogic.ReadOnly = false;
            this.lnudLogic.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudLogic.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudCleaning
            // 
            resources.ApplyResources(this.lnudCleaning, "lnudCleaning");
            this.lnudCleaning.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudCleaning.Label = "Cleaning";
            this.lnudCleaning.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudCleaning.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lnudCleaning.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.lnudCleaning.Name = "lnudCleaning";
            this.lnudCleaning.NoLabel = false;
            this.lnudCleaning.ReadOnly = false;
            this.lnudCleaning.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudCleaning.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudMoney
            // 
            resources.ApplyResources(this.lnudMoney, "lnudMoney");
            this.lnudMoney.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudMoney.Label = "Money";
            this.lnudMoney.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudMoney.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.lnudMoney.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.lnudMoney.Name = "lnudMoney";
            this.lnudMoney.NoLabel = false;
            this.lnudMoney.ReadOnly = false;
            this.lnudMoney.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudMoney.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // lnudJobLevels
            // 
            resources.ApplyResources(this.lnudJobLevels, "lnudJobLevels");
            this.lnudJobLevels.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.lnudJobLevels.Label = "Job Levels";
            this.lnudJobLevels.LabelAnchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnudJobLevels.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.lnudJobLevels.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.lnudJobLevels.Name = "lnudJobLevels";
            this.lnudJobLevels.NoLabel = false;
            this.lnudJobLevels.ReadOnly = false;
            this.lnudJobLevels.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudJobLevels.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // flpText
            // 
            resources.ApplyResources(this.flpText, "flpText");
            this.flpText.Controls.Add(this.flpMale);
            this.flpText.Controls.Add(this.llCopy);
            this.flpText.Controls.Add(this.flpFemale);
            this.flpText.Name = "flpText";
            // 
            // flpMale
            // 
            resources.ApplyResources(this.flpMale, "flpMale");
            this.flpMale.Controls.Add(this.lbMale);
            this.flpMale.Controls.Add(this.tbMale);
            this.flpMale.Name = "flpMale";
            // 
            // lbMale
            // 
            resources.ApplyResources(this.lbMale, "lbMale");
            this.lbMale.Name = "lbMale";
            // 
            // tbMale
            // 
            resources.ApplyResources(this.tbMale, "tbMale");
            this.tbMale.Name = "tbMale";
            // 
            // llCopy
            // 
            resources.ApplyResources(this.llCopy, "llCopy");
            this.llCopy.Name = "llCopy";
            this.llCopy.TabStop = true;
            this.llCopy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCopy_LinkClicked);
            // 
            // flpFemale
            // 
            resources.ApplyResources(this.flpFemale, "flpFemale");
            this.flpFemale.Controls.Add(this.lbFemale);
            this.flpFemale.Controls.Add(this.tbFemale);
            this.flpFemale.Name = "flpFemale";
            // 
            // lbFemale
            // 
            resources.ApplyResources(this.lbFemale, "lbFemale");
            this.lbFemale.Name = "lbFemale";
            // 
            // tbFemale
            // 
            resources.ApplyResources(this.tbFemale, "tbFemale");
            this.tbFemale.Name = "tbFemale";
            // 
            // EffectPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpMain);
            this.MinimumSize = new System.Drawing.Size(824, 131);
            this.Name = "EffectPanel";
            this.flpMain.ResumeLayout(false);
            this.flpMain.PerformLayout();
            this.flpEffect.ResumeLayout(false);
            this.flpEffect.PerformLayout();
            this.flpText.ResumeLayout(false);
            this.flpText.PerformLayout();
            this.flpMale.ResumeLayout(false);
            this.flpMale.PerformLayout();
            this.flpFemale.ResumeLayout(false);
            this.flpFemale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpMain;
        private System.Windows.Forms.FlowLayoutPanel flpEffect;
        private System.Windows.Forms.Label lbEffect;
        private LabelledNumericUpDown lnudCooking;
        private LabelledNumericUpDown lnudMechanical;
        private LabelledNumericUpDown lnudCharisma;
        private LabelledNumericUpDown lnudBody;
        private LabelledNumericUpDown lnudCreativity;
        private LabelledNumericUpDown lnudLogic;
        private LabelledNumericUpDown lnudCleaning;
        private LabelledNumericUpDown lnudMoney;
        private LabelledNumericUpDown lnudJobLevels;
        private System.Windows.Forms.FlowLayoutPanel flpText;
        private System.Windows.Forms.FlowLayoutPanel flpMale;
        private System.Windows.Forms.Label lbMale;
        private System.Windows.Forms.TextBox tbMale;
        private System.Windows.Forms.LinkLabel llCopy;
        private System.Windows.Forms.FlowLayoutPanel flpFemale;
        private System.Windows.Forms.Label lbFemale;
        private System.Windows.Forms.TextBox tbFemale;

    }
}
