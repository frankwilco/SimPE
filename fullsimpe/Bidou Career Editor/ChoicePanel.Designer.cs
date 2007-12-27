namespace SimPe.Plugin
{
    partial class ChoicePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoicePanel));
            this.flpChoice = new System.Windows.Forms.FlowLayoutPanel();
            this.lbChoice = new System.Windows.Forms.Label();
            this.lnudCooking = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudMechanical = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCharisma = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudBody = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCreativity = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudLogic = new SimPe.Plugin.LabelledNumericUpDown();
            this.lnudCleaning = new SimPe.Plugin.LabelledNumericUpDown();
            this.tbChoice = new System.Windows.Forms.TextBox();
            this.flpChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpChoice
            // 
            resources.ApplyResources(this.flpChoice, "flpChoice");
            this.flpChoice.Controls.Add(this.lbChoice);
            this.flpChoice.Controls.Add(this.tbChoice);
            this.flpChoice.Controls.Add(this.lnudCooking);
            this.flpChoice.Controls.Add(this.lnudMechanical);
            this.flpChoice.Controls.Add(this.lnudCharisma);
            this.flpChoice.Controls.Add(this.lnudBody);
            this.flpChoice.Controls.Add(this.lnudCreativity);
            this.flpChoice.Controls.Add(this.lnudLogic);
            this.flpChoice.Controls.Add(this.lnudCleaning);
            this.flpChoice.Name = "flpChoice";
            // 
            // lbChoice
            // 
            resources.ApplyResources(this.lbChoice, "lbChoice");
            this.lbChoice.Name = "lbChoice";
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
            this.lnudCleaning.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.lnudCleaning.ValueSize = new System.Drawing.Size(80, 22);
            // 
            // tbChoice
            // 
            resources.ApplyResources(this.tbChoice, "tbChoice");
            this.tbChoice.Name = "tbChoice";
            // 
            // ChoicePanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpChoice);
            this.Name = "ChoicePanel";
            this.flpChoice.ResumeLayout(false);
            this.flpChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpChoice;
        private System.Windows.Forms.Label lbChoice;
        private LabelledNumericUpDown lnudCooking;
        private LabelledNumericUpDown lnudMechanical;
        private LabelledNumericUpDown lnudCharisma;
        private LabelledNumericUpDown lnudBody;
        private LabelledNumericUpDown lnudCreativity;
        private LabelledNumericUpDown lnudLogic;
        private LabelledNumericUpDown lnudCleaning;
        private System.Windows.Forms.TextBox tbChoice;


    }
}
