using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für DemoWizardForm.
	/// </summary>
	public class DemoWizardForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.Panel pnwizard1;
		internal System.Windows.Forms.Panel pnwizard2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Windows.Forms.Panel pnwizard3;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.CheckBox cbstep2;
		private System.Windows.Forms.TabPage tabPage4;
		internal System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.CheckBox cbwait;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DemoWizardForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DemoWizardForm));
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pnwizard1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pnwizard2 = new System.Windows.Forms.Panel();
			this.cbstep2 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.pnwizard3 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.pb = new System.Windows.Forms.PictureBox();
			this.cbwait = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.pnwizard1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.pnwizard2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.pnwizard3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(632, 214);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pnwizard1);
			this.tabPage1.Location = new System.Drawing.Point(4, 23);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(624, 187);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Step 1";
			// 
			// pnwizard1
			// 
			this.pnwizard1.BackColor = System.Drawing.Color.DimGray;
			this.pnwizard1.Controls.Add(this.label1);
			this.pnwizard1.Location = new System.Drawing.Point(0, 0);
			this.pnwizard1.Name = "pnwizard1";
			this.pnwizard1.Size = new System.Drawing.Size(624, 136);
			this.pnwizard1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(488, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "label";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pnwizard2);
			this.tabPage2.Location = new System.Drawing.Point(4, 23);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(624, 187);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Step 2";
			// 
			// pnwizard2
			// 
			this.pnwizard2.BackColor = System.Drawing.Color.White;
			this.pnwizard2.Controls.Add(this.cbwait);
			this.pnwizard2.Controls.Add(this.cbstep2);
			this.pnwizard2.Controls.Add(this.label2);
			this.pnwizard2.Location = new System.Drawing.Point(0, 2);
			this.pnwizard2.Name = "pnwizard2";
			this.pnwizard2.Size = new System.Drawing.Size(624, 184);
			this.pnwizard2.TabIndex = 10;
			// 
			// cbstep2
			// 
			this.cbstep2.Location = new System.Drawing.Point(8, 40);
			this.cbstep2.Name = "cbstep2";
			this.cbstep2.TabIndex = 1;
			this.cbstep2.Text = "Accept";
			this.cbstep2.CheckedChanged += new System.EventHandler(this.cbstep2_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 32);
			this.label2.TabIndex = 0;
			this.label2.Text = "label2";
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.pnwizard3);
			this.tabPage3.Location = new System.Drawing.Point(4, 23);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(624, 187);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Step3";
			// 
			// pnwizard3
			// 
			this.pnwizard3.BackColor = System.Drawing.Color.White;
			this.pnwizard3.Controls.Add(this.label3);
			this.pnwizard3.Location = new System.Drawing.Point(0, 1);
			this.pnwizard3.Name = "pnwizard3";
			this.pnwizard3.Size = new System.Drawing.Size(624, 184);
			this.pnwizard3.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(8, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 32);
			this.label3.TabIndex = 0;
			this.label3.Text = "label3";
			// 
			// tabPage4
			// 
			this.tabPage4.Controls.Add(this.pb);
			this.tabPage4.Location = new System.Drawing.Point(4, 23);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(624, 187);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Misc";
			// 
			// pb
			// 
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.Location = new System.Drawing.Point(8, 8);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(64, 89);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pb.TabIndex = 0;
			this.pb.TabStop = false;
			// 
			// cbwait
			// 
			this.cbwait.Location = new System.Drawing.Point(8, 64);
			this.cbwait.Name = "cbwait";
			this.cbwait.TabIndex = 2;
			this.cbwait.Text = "wait";
			this.cbwait.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// DemoWizardForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 15);
			this.ClientSize = new System.Drawing.Size(648, 230);
			this.Controls.Add(this.tabControl1);
			this.DockPadding.All = 8;
			this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "DemoWizardForm";
			this.Text = "DemoWizardForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.pnwizard1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.pnwizard2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.pnwizard3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new DemoWizardForm());
		}

		internal Step2 step2;

		private void cbstep2_CheckedChanged(object sender, System.EventArgs e)
		{
			step2.Update();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbwait.Checked) SimPe.WaitingScreen.Wait();
			else SimPe.WaitingScreen.Stop();
														
		}
	}
}
