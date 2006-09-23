using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für FileTableItemForm.
	/// </summary>
	public class FileTableItemForm : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private Ambertation.Windows.Forms.TransparentCheckBox cbRec;
		private System.Windows.Forms.TextBox tbName;
		private System.Windows.Forms.TextBox tbRoot;
		private System.Windows.Forms.ComboBox cbEpVer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.OpenFileDialog ofd;

		SimPe.ThemeManager tm;
		public FileTableItemForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);

			ofd.Filter = SimPe.ExtensionProvider.BuildFilterString(new SimPe.ExtensionType[] {SimPe.ExtensionType.Package, SimPe.ExtensionType.AllFiles});
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (tm!=null) 
				{
					tm.Parent = null;
					tm.Clear();
					tm = null;
				}
				if(components != null)
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTableItemForm));
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbEpVer = new System.Windows.Forms.ComboBox();
            this.tbRoot = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbRec = new Ambertation.Windows.Forms.TransparentCheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.xpGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.AccessibleDescription = null;
            this.xpGradientPanel1.AccessibleName = null;
            resources.ApplyResources(this.xpGradientPanel1, "xpGradientPanel1");
            this.xpGradientPanel1.BackgroundImage = null;
            this.xpGradientPanel1.Controls.Add(this.button3);
            this.xpGradientPanel1.Controls.Add(this.button2);
            this.xpGradientPanel1.Controls.Add(this.button1);
            this.xpGradientPanel1.Controls.Add(this.cbEpVer);
            this.xpGradientPanel1.Controls.Add(this.tbRoot);
            this.xpGradientPanel1.Controls.Add(this.tbName);
            this.xpGradientPanel1.Controls.Add(this.cbRec);
            this.xpGradientPanel1.Controls.Add(this.label3);
            this.xpGradientPanel1.Controls.Add(this.label2);
            this.xpGradientPanel1.Controls.Add(this.label1);
            this.xpGradientPanel1.Font = null;
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            this.xpGradientPanel1.Watermark = null;
            // 
            // button3
            // 
            this.button3.AccessibleDescription = null;
            this.button3.AccessibleName = null;
            resources.ApplyResources(this.button3, "button3");
            this.button3.BackgroundImage = null;
            this.button3.Font = null;
            this.button3.Name = "button3";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.AccessibleDescription = null;
            this.button2.AccessibleName = null;
            resources.ApplyResources(this.button2, "button2");
            this.button2.BackgroundImage = null;
            this.button2.Font = null;
            this.button2.Name = "button2";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = null;
            this.button1.AccessibleName = null;
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = null;
            this.button1.Font = null;
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbEpVer
            // 
            this.cbEpVer.AccessibleDescription = null;
            this.cbEpVer.AccessibleName = null;
            resources.ApplyResources(this.cbEpVer, "cbEpVer");
            this.cbEpVer.BackgroundImage = null;
            this.cbEpVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEpVer.Font = null;
            this.cbEpVer.Items.AddRange(new object[] {
            resources.GetString("cbEpVer.Items"),
            resources.GetString("cbEpVer.Items1"),
            resources.GetString("cbEpVer.Items2"),
            resources.GetString("cbEpVer.Items3"),
            resources.GetString("cbEpVer.Items4"),
            resources.GetString("cbEpVer.Items5"),
            resources.GetString("cbEpVer.Items6")});
            this.cbEpVer.Name = "cbEpVer";
            // 
            // tbRoot
            // 
            this.tbRoot.AccessibleDescription = null;
            this.tbRoot.AccessibleName = null;
            resources.ApplyResources(this.tbRoot, "tbRoot");
            this.tbRoot.BackgroundImage = null;
            this.tbRoot.Font = null;
            this.tbRoot.Name = "tbRoot";
            this.tbRoot.ReadOnly = true;
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
            // cbRec
            // 
            this.cbRec.AccessibleDescription = null;
            this.cbRec.AccessibleName = null;
            resources.ApplyResources(this.cbRec, "cbRec");
            this.cbRec.BackgroundImage = null;
            this.cbRec.Name = "cbRec";
            this.cbRec.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // fbd
            // 
            resources.ApplyResources(this.fbd, "fbd");
            // 
            // ofd
            // 
            resources.ApplyResources(this.ofd, "ofd");
            // 
            // FileTableItemForm
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.xpGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FileTableItemForm";
            this.xpGradientPanel1.ResumeLayout(false);
            this.xpGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		bool ok;
		bool file;
		public static FileTableItem Execute()
		{
			FileTableItem fti = new FileTableItem("", false, false);
			
			if (Execute(fti)) return fti;
			else return null;
		}

		public static bool Execute(FileTableItem fti)
		{
			FileTableItemForm f = new FileTableItemForm();
			f.tbName.Text = fti.Name;
			f.tbRoot.Text = fti.Type.ToString();
			f.cbEpVer.SelectedIndex = fti.EpVersion+1;
			f.cbRec.Checked = fti.IsRecursive;
			f.ok = false;
			f.file = fti.IsFile;
			f.UpdateRec();

			f.ShowDialog();

			if (f.ok) 
			{
				fti.Type = FileTableItemType.Absolute;
				fti.Name = f.tbName.Text;
				fti.IsRecursive = f.cbRec.Checked;
				fti.EpVersion = f.cbEpVer.SelectedIndex-1;
				fti.IsFile = f.file;

				return true;
			}

			return false;
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			ok = true;
			Close();
		}

		void UpdateType()
		{
			FileTableItem fti = new FileTableItem(tbName.Text, false, file);
			fti.Name = tbName.Text;

			this.tbRoot.Text = fti.Type.ToString();			
		}

		void UpdateRec()
		{
			this.cbRec.Enabled = !file;
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (fbd.ShowDialog()==DialogResult.OK) 
			{
				file = false;
				tbName.Text = fbd.SelectedPath;		
		
				UpdateType();
				UpdateRec();
			}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				file = true;
				tbName.Text = ofd.FileName;			
		
				UpdateType();	
				UpdateRec();
			}
		}

		private void tbName_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
