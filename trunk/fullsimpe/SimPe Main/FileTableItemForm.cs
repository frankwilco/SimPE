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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(FileTableItemForm));
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
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
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
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// button3
			// 
			this.button3.AccessibleDescription = resources.GetString("button3.AccessibleDescription");
			this.button3.AccessibleName = resources.GetString("button3.AccessibleName");
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button3.Anchor")));
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button3.Dock")));
			this.button3.Enabled = ((bool)(resources.GetObject("button3.Enabled")));
			this.button3.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button3.FlatStyle")));
			this.button3.Font = ((System.Drawing.Font)(resources.GetObject("button3.Font")));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.ImageAlign")));
			this.button3.ImageIndex = ((int)(resources.GetObject("button3.ImageIndex")));
			this.button3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button3.ImeMode")));
			this.button3.Location = ((System.Drawing.Point)(resources.GetObject("button3.Location")));
			this.button3.Name = "button3";
			this.button3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button3.RightToLeft")));
			this.button3.Size = ((System.Drawing.Size)(resources.GetObject("button3.Size")));
			this.button3.TabIndex = ((int)(resources.GetObject("button3.TabIndex")));
			this.button3.Text = resources.GetString("button3.Text");
			this.button3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button3.TextAlign")));
			this.button3.Visible = ((bool)(resources.GetObject("button3.Visible")));
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.AccessibleDescription = resources.GetString("button2.AccessibleDescription");
			this.button2.AccessibleName = resources.GetString("button2.AccessibleName");
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button2.Anchor")));
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button2.Dock")));
			this.button2.Enabled = ((bool)(resources.GetObject("button2.Enabled")));
			this.button2.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button2.FlatStyle")));
			this.button2.Font = ((System.Drawing.Font)(resources.GetObject("button2.Font")));
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.ImageAlign")));
			this.button2.ImageIndex = ((int)(resources.GetObject("button2.ImageIndex")));
			this.button2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button2.ImeMode")));
			this.button2.Location = ((System.Drawing.Point)(resources.GetObject("button2.Location")));
			this.button2.Name = "button2";
			this.button2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button2.RightToLeft")));
			this.button2.Size = ((System.Drawing.Size)(resources.GetObject("button2.Size")));
			this.button2.TabIndex = ((int)(resources.GetObject("button2.TabIndex")));
			this.button2.Text = resources.GetString("button2.Text");
			this.button2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button2.TextAlign")));
			this.button2.Visible = ((bool)(resources.GetObject("button2.Visible")));
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// cbEpVer
			// 
			this.cbEpVer.AccessibleDescription = resources.GetString("cbEpVer.AccessibleDescription");
			this.cbEpVer.AccessibleName = resources.GetString("cbEpVer.AccessibleName");
			this.cbEpVer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbEpVer.Anchor")));
			this.cbEpVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEpVer.BackgroundImage")));
			this.cbEpVer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbEpVer.Dock")));
			this.cbEpVer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEpVer.Enabled = ((bool)(resources.GetObject("cbEpVer.Enabled")));
			this.cbEpVer.Font = ((System.Drawing.Font)(resources.GetObject("cbEpVer.Font")));
			this.cbEpVer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbEpVer.ImeMode")));
			this.cbEpVer.IntegralHeight = ((bool)(resources.GetObject("cbEpVer.IntegralHeight")));
			this.cbEpVer.ItemHeight = ((int)(resources.GetObject("cbEpVer.ItemHeight")));
			this.cbEpVer.Items.AddRange(new object[] {
														 resources.GetString("cbEpVer.Items"),
														 resources.GetString("cbEpVer.Items1"),
														 resources.GetString("cbEpVer.Items2"),
														 resources.GetString("cbEpVer.Items3"),
														 resources.GetString("cbEpVer.Items4"),
														 resources.GetString("cbEpVer.Items5")});
			this.cbEpVer.Location = ((System.Drawing.Point)(resources.GetObject("cbEpVer.Location")));
			this.cbEpVer.MaxDropDownItems = ((int)(resources.GetObject("cbEpVer.MaxDropDownItems")));
			this.cbEpVer.MaxLength = ((int)(resources.GetObject("cbEpVer.MaxLength")));
			this.cbEpVer.Name = "cbEpVer";
			this.cbEpVer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbEpVer.RightToLeft")));
			this.cbEpVer.Size = ((System.Drawing.Size)(resources.GetObject("cbEpVer.Size")));
			this.cbEpVer.TabIndex = ((int)(resources.GetObject("cbEpVer.TabIndex")));
			this.cbEpVer.Text = resources.GetString("cbEpVer.Text");
			this.cbEpVer.Visible = ((bool)(resources.GetObject("cbEpVer.Visible")));
			// 
			// tbRoot
			// 
			this.tbRoot.AccessibleDescription = resources.GetString("tbRoot.AccessibleDescription");
			this.tbRoot.AccessibleName = resources.GetString("tbRoot.AccessibleName");
			this.tbRoot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbRoot.Anchor")));
			this.tbRoot.AutoSize = ((bool)(resources.GetObject("tbRoot.AutoSize")));
			this.tbRoot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbRoot.BackgroundImage")));
			this.tbRoot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbRoot.Dock")));
			this.tbRoot.Enabled = ((bool)(resources.GetObject("tbRoot.Enabled")));
			this.tbRoot.Font = ((System.Drawing.Font)(resources.GetObject("tbRoot.Font")));
			this.tbRoot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbRoot.ImeMode")));
			this.tbRoot.Location = ((System.Drawing.Point)(resources.GetObject("tbRoot.Location")));
			this.tbRoot.MaxLength = ((int)(resources.GetObject("tbRoot.MaxLength")));
			this.tbRoot.Multiline = ((bool)(resources.GetObject("tbRoot.Multiline")));
			this.tbRoot.Name = "tbRoot";
			this.tbRoot.PasswordChar = ((char)(resources.GetObject("tbRoot.PasswordChar")));
			this.tbRoot.ReadOnly = true;
			this.tbRoot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbRoot.RightToLeft")));
			this.tbRoot.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbRoot.ScrollBars")));
			this.tbRoot.Size = ((System.Drawing.Size)(resources.GetObject("tbRoot.Size")));
			this.tbRoot.TabIndex = ((int)(resources.GetObject("tbRoot.TabIndex")));
			this.tbRoot.Text = resources.GetString("tbRoot.Text");
			this.tbRoot.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbRoot.TextAlign")));
			this.tbRoot.Visible = ((bool)(resources.GetObject("tbRoot.Visible")));
			this.tbRoot.WordWrap = ((bool)(resources.GetObject("tbRoot.WordWrap")));
			// 
			// tbName
			// 
			this.tbName.AccessibleDescription = resources.GetString("tbName.AccessibleDescription");
			this.tbName.AccessibleName = resources.GetString("tbName.AccessibleName");
			this.tbName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbName.Anchor")));
			this.tbName.AutoSize = ((bool)(resources.GetObject("tbName.AutoSize")));
			this.tbName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbName.BackgroundImage")));
			this.tbName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbName.Dock")));
			this.tbName.Enabled = ((bool)(resources.GetObject("tbName.Enabled")));
			this.tbName.Font = ((System.Drawing.Font)(resources.GetObject("tbName.Font")));
			this.tbName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbName.ImeMode")));
			this.tbName.Location = ((System.Drawing.Point)(resources.GetObject("tbName.Location")));
			this.tbName.MaxLength = ((int)(resources.GetObject("tbName.MaxLength")));
			this.tbName.Multiline = ((bool)(resources.GetObject("tbName.Multiline")));
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = ((char)(resources.GetObject("tbName.PasswordChar")));
			this.tbName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbName.RightToLeft")));
			this.tbName.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbName.ScrollBars")));
			this.tbName.Size = ((System.Drawing.Size)(resources.GetObject("tbName.Size")));
			this.tbName.TabIndex = ((int)(resources.GetObject("tbName.TabIndex")));
			this.tbName.Text = resources.GetString("tbName.Text");
			this.tbName.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbName.TextAlign")));
			this.tbName.Visible = ((bool)(resources.GetObject("tbName.Visible")));
			this.tbName.WordWrap = ((bool)(resources.GetObject("tbName.WordWrap")));
			this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
			// 
			// cbRec
			// 
			this.cbRec.AccessibleDescription = resources.GetString("cbRec.AccessibleDescription");
			this.cbRec.AccessibleName = resources.GetString("cbRec.AccessibleName");
			this.cbRec.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbRec.Anchor")));
			this.cbRec.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbRec.Appearance")));
			this.cbRec.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbRec.BackgroundImage")));
			this.cbRec.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRec.CheckAlign")));
			this.cbRec.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbRec.Dock")));
			this.cbRec.Enabled = ((bool)(resources.GetObject("cbRec.Enabled")));
			this.cbRec.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbRec.FlatStyle")));
			this.cbRec.Font = ((System.Drawing.Font)(resources.GetObject("cbRec.Font")));
			this.cbRec.Image = ((System.Drawing.Image)(resources.GetObject("cbRec.Image")));
			this.cbRec.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRec.ImageAlign")));
			this.cbRec.ImageIndex = ((int)(resources.GetObject("cbRec.ImageIndex")));
			this.cbRec.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbRec.ImeMode")));
			this.cbRec.Location = ((System.Drawing.Point)(resources.GetObject("cbRec.Location")));
			this.cbRec.Name = "cbRec";
			this.cbRec.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbRec.RightToLeft")));
			this.cbRec.Size = ((System.Drawing.Size)(resources.GetObject("cbRec.Size")));
			this.cbRec.TabIndex = ((int)(resources.GetObject("cbRec.TabIndex")));
			this.cbRec.Text = resources.GetString("cbRec.Text");
			this.cbRec.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbRec.TextAlign")));
			this.cbRec.Visible = ((bool)(resources.GetObject("cbRec.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// fbd
			// 
			this.fbd.Description = resources.GetString("fbd.Description");
			this.fbd.SelectedPath = resources.GetString("fbd.SelectedPath");
			// 
			// ofd
			// 
			this.ofd.Filter = resources.GetString("ofd.Filter");
			this.ofd.Title = resources.GetString("ofd.Title");
			// 
			// FileTableItemForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.xpGradientPanel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "FileTableItemForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.xpGradientPanel1.ResumeLayout(false);
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
