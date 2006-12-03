using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    partial class ScoreItemLearnedBehaviour
    {
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScoreItemLearnedBehaviour));
            this.cb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pbVal = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.cbGuid = new SimPe.PackedFiles.Wrapper.SCOR.LearnedBahaviourComboBox();
            this.llAdd = new System.Windows.Forms.LinkLabel();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // cb
            // 
            resources.ApplyResources(this.cb, "cb");
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FormattingEnabled = true;
            this.cb.Name = "cb";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            // 
            // pbVal
            // 
            this.pbVal.BackColor = System.Drawing.Color.Transparent;
            this.pbVal.DisplayOffset = 0;
            resources.ApplyResources(this.pbVal, "pbVal");
            this.pbVal.Maximum = 1000;
            this.pbVal.Name = "pbVal";
            this.pbVal.NumberFormat = "N0";
            this.pbVal.NumberOffset = 0;
            this.pbVal.NumberScale = 1;
            this.pbVal.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbVal.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbVal.TokenCount = 10;
            this.pbVal.UnselectedColor = System.Drawing.Color.Black;
            this.pbVal.Value = 0;
            this.pbVal.ChangedValue += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // cbGuid
            // 
            resources.ApplyResources(this.cbGuid, "cbGuid");
            this.cbGuid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuid.FormattingEnabled = true;
            this.cbGuid.Name = "cbGuid";
            this.cbGuid.SelectedIndexChanged += new System.EventHandler(this.cbGuid_SelectedIndexChanged);
            // 
            // llAdd
            // 
            resources.ApplyResources(this.llAdd, "llAdd");
            this.llAdd.Name = "llAdd";
            this.llAdd.TabStop = true;
            this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
            // 
            // llRemove
            // 
            resources.ApplyResources(this.llRemove, "llRemove");
            this.llRemove.Name = "llRemove";
            this.llRemove.TabStop = true;
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // ScoreItemLearnedBehaviour
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.llAdd);
            this.Controls.Add(this.cbGuid);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pbVal);
            this.Controls.Add(this.cb);
            this.Name = "ScoreItemLearnedBehaviour";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private LearnedBahaviourComboBox cbGuid;
        private System.Windows.Forms.LinkLabel llAdd;
        private System.Windows.Forms.LinkLabel llRemove;
        Ambertation.Windows.Forms.LabeledProgressBar pbVal;
    }
}
