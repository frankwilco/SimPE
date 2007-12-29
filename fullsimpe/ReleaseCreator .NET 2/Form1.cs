using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace ReleaseCreator
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        ReleaseTools rt;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private SteepValley.Windows.Forms.XPLine xpLine1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.Label lbQaVer;
        internal System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.TextBox tbVer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox tbRelLetter;
        private CheckBox cbCompile;
        private Label label7;
        private Button button3;
        private Button button2;
        internal ProgressBar pb;
        private Label lbInfo;
        private Label lbRelease;
        private Label lbInno;
		internal System.Windows.Forms.Label lbVer;
	
		public Form1()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

            Settings s = new Settings(System.IO.Path.Combine((Application.StartupPath), @"Data\release_setup.xml"));
            rt = new ReleaseTools(s, this);
            this.lbQaVer.Text = rt.QAVersion;
            this.lbVer.Text = rt.PublicVersion;

            this.lbRelease.Text = s.ReleaseDir;
            this.lbInfo.Text = s.UpdateInfoDir;
            this.lbInno.Text = s.InnoDir;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbCompile = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRelLetter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lv = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lbVer = new System.Windows.Forms.Label();
            this.lbQaVer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xpLine1 = new SteepValley.Windows.Forms.XPLine();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRelease = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.lbInno = new System.Windows.Forms.Label();
            this.xpGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.Controls.Add(this.lbInno);
            this.xpGradientPanel1.Controls.Add(this.lbInfo);
            this.xpGradientPanel1.Controls.Add(this.lbRelease);
            this.xpGradientPanel1.Controls.Add(this.pb);
            this.xpGradientPanel1.Controls.Add(this.button3);
            this.xpGradientPanel1.Controls.Add(this.button2);
            this.xpGradientPanel1.Controls.Add(this.cbCompile);
            this.xpGradientPanel1.Controls.Add(this.label7);
            this.xpGradientPanel1.Controls.Add(this.tbRelLetter);
            this.xpGradientPanel1.Controls.Add(this.label6);
            this.xpGradientPanel1.Controls.Add(this.tbVer);
            this.xpGradientPanel1.Controls.Add(this.label5);
            this.xpGradientPanel1.Controls.Add(this.lv);
            this.xpGradientPanel1.Controls.Add(this.lbVer);
            this.xpGradientPanel1.Controls.Add(this.lbQaVer);
            this.xpGradientPanel1.Controls.Add(this.label4);
            this.xpGradientPanel1.Controls.Add(this.label3);
            this.xpGradientPanel1.Controls.Add(this.xpLine1);
            this.xpGradientPanel1.Controls.Add(this.button1);
            this.xpGradientPanel1.Controls.Add(this.label2);
            this.xpGradientPanel1.Controls.Add(this.label1);
            this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            this.xpGradientPanel1.Size = new System.Drawing.Size(560, 455);
            this.xpGradientPanel1.TabIndex = 0;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pb.Location = new System.Drawing.Point(0, 442);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(560, 13);
            this.pb.TabIndex = 20;
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Location = new System.Drawing.Point(336, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Publish";
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Location = new System.Drawing.Point(230, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Upload Preview";
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbCompile
            // 
            this.cbCompile.AutoSize = true;
            this.cbCompile.BackColor = System.Drawing.Color.Transparent;
            this.cbCompile.Checked = true;
            this.cbCompile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCompile.Location = new System.Drawing.Point(400, 76);
            this.cbCompile.Name = "cbCompile";
            this.cbCompile.Size = new System.Drawing.Size(152, 17);
            this.cbCompile.TabIndex = 17;
            this.cbCompile.Text = "Compile Release Packages";
            this.cbCompile.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Inno Setup:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbRelLetter
            // 
            this.tbRelLetter.Location = new System.Drawing.Point(136, 104);
            this.tbRelLetter.Name = "tbRelLetter";
            this.tbRelLetter.Size = new System.Drawing.Size(88, 21);
            this.tbRelLetter.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Release Letter:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(400, 176);
            this.tbVer.Name = "tbVer";
            this.tbVer.ReadOnly = true;
            this.tbVer.Size = new System.Drawing.Size(144, 21);
            this.tbVer.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fileset:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(64, 234);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(488, 202);
            this.lv.TabIndex = 10;
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Filename";
            this.columnHeader1.Width = 149;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filesize";
            this.columnHeader2.Width = 95;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Fileversion";
            this.columnHeader3.Width = 154;
            // 
            // lbVer
            // 
            this.lbVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbVer.BackColor = System.Drawing.Color.Transparent;
            this.lbVer.Location = new System.Drawing.Point(104, 176);
            this.lbVer.Name = "lbVer";
            this.lbVer.Size = new System.Drawing.Size(288, 23);
            this.lbVer.TabIndex = 9;
            this.lbVer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbQaVer
            // 
            this.lbQaVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbQaVer.BackColor = System.Drawing.Color.Transparent;
            this.lbQaVer.Location = new System.Drawing.Point(104, 152);
            this.lbQaVer.Name = "lbQaVer";
            this.lbQaVer.Size = new System.Drawing.Size(440, 23);
            this.lbQaVer.TabIndex = 8;
            this.lbQaVer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Public Version:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "QA Version:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // xpLine1
            // 
            this.xpLine1.BackColor = System.Drawing.Color.Transparent;
            this.xpLine1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.xpLine1.LineColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpLine1.Location = new System.Drawing.Point(8, 136);
            this.xpLine1.Name = "xpLine1";
            this.xpLine1.ShadowColor = System.Drawing.SystemColors.ActiveCaption;
            this.xpLine1.Size = new System.Drawing.Size(544, 8);
            this.xpLine1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(472, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Web Directory:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Release Directory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbRelease
            // 
            this.lbRelease.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRelease.BackColor = System.Drawing.Color.Transparent;
            this.lbRelease.Location = new System.Drawing.Point(133, 24);
            this.lbRelease.Name = "lbRelease";
            this.lbRelease.Size = new System.Drawing.Size(414, 13);
            this.lbRelease.TabIndex = 21;
            this.lbRelease.Text = "c:\\";
            // 
            // lbInfo
            // 
            this.lbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Location = new System.Drawing.Point(134, 50);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(414, 13);
            this.lbInfo.TabIndex = 22;
            this.lbInfo.Text = "c:\\";
            // 
            // lbInno
            // 
            this.lbInno.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInno.BackColor = System.Drawing.Color.Transparent;
            this.lbInno.Location = new System.Drawing.Point(134, 76);
            this.lbInno.Name = "lbInno";
            this.lbInno.Size = new System.Drawing.Size(258, 13);
            this.lbInno.TabIndex = 23;
            this.lbInno.Text = "c:\\";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
            this.ClientSize = new System.Drawing.Size(560, 455);
            this.Controls.Add(this.xpGradientPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Release Creator";
            this.xpGradientPanel1.ResumeLayout(false);
            this.xpGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
            rt.CreateRelease(cbCompile.Checked, this.tbRelLetter.Text.Trim());
		}

        

        private void button2_Click(object sender, EventArgs e)
        {
            rt.UploadPublicPreview(this.tbRelLetter.Text.Trim());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rt.PublishFiles(this.tbRelLetter.Text.Trim());
        }
	}
}
