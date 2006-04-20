using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für ExceptionForm.
	/// </summary>
	public class ExceptionForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lberr;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel lldetail;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbdetail;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.TextBox tbsup;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExceptionForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExceptionForm));
			this.lberr = new System.Windows.Forms.Label();
			this.gbdetail = new System.Windows.Forms.GroupBox();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lldetail = new System.Windows.Forms.LinkLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.tbsup = new System.Windows.Forms.TextBox();
			this.gbdetail.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lberr
			// 
			this.lberr.AccessibleDescription = resources.GetString("lberr.AccessibleDescription");
			this.lberr.AccessibleName = resources.GetString("lberr.AccessibleName");
			this.lberr.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lberr.Anchor")));
			this.lberr.AutoSize = ((bool)(resources.GetObject("lberr.AutoSize")));
			this.lberr.BackColor = System.Drawing.Color.Transparent;
			this.lberr.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lberr.Dock")));
			this.lberr.Enabled = ((bool)(resources.GetObject("lberr.Enabled")));
			this.lberr.Font = ((System.Drawing.Font)(resources.GetObject("lberr.Font")));
			this.lberr.ForeColor = System.Drawing.Color.Black;
			this.lberr.Image = ((System.Drawing.Image)(resources.GetObject("lberr.Image")));
			this.lberr.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lberr.ImageAlign")));
			this.lberr.ImageIndex = ((int)(resources.GetObject("lberr.ImageIndex")));
			this.lberr.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lberr.ImeMode")));
			this.lberr.Location = ((System.Drawing.Point)(resources.GetObject("lberr.Location")));
			this.lberr.Name = "lberr";
			this.lberr.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lberr.RightToLeft")));
			this.lberr.Size = ((System.Drawing.Size)(resources.GetObject("lberr.Size")));
			this.lberr.TabIndex = ((int)(resources.GetObject("lberr.TabIndex")));
			this.lberr.Text = resources.GetString("lberr.Text");
			this.lberr.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lberr.TextAlign")));
			this.lberr.Visible = ((bool)(resources.GetObject("lberr.Visible")));
			// 
			// gbdetail
			// 
			this.gbdetail.AccessibleDescription = resources.GetString("gbdetail.AccessibleDescription");
			this.gbdetail.AccessibleName = resources.GetString("gbdetail.AccessibleName");
			this.gbdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbdetail.Anchor")));
			this.gbdetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbdetail.BackgroundImage")));
			this.gbdetail.Controls.Add(this.rtb);
			this.gbdetail.Controls.Add(this.linkLabel1);
			this.gbdetail.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbdetail.Dock")));
			this.gbdetail.Enabled = ((bool)(resources.GetObject("gbdetail.Enabled")));
			this.gbdetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbdetail.Font = ((System.Drawing.Font)(resources.GetObject("gbdetail.Font")));
			this.gbdetail.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbdetail.ImeMode")));
			this.gbdetail.Location = ((System.Drawing.Point)(resources.GetObject("gbdetail.Location")));
			this.gbdetail.Name = "gbdetail";
			this.gbdetail.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbdetail.RightToLeft")));
			this.gbdetail.Size = ((System.Drawing.Size)(resources.GetObject("gbdetail.Size")));
			this.gbdetail.TabIndex = ((int)(resources.GetObject("gbdetail.TabIndex")));
			this.gbdetail.TabStop = false;
			this.gbdetail.Text = resources.GetString("gbdetail.Text");
			this.gbdetail.Visible = ((bool)(resources.GetObject("gbdetail.Visible")));
			// 
			// rtb
			// 
			this.rtb.AccessibleDescription = resources.GetString("rtb.AccessibleDescription");
			this.rtb.AccessibleName = resources.GetString("rtb.AccessibleName");
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtb.Anchor")));
			this.rtb.AutoSize = ((bool)(resources.GetObject("rtb.AutoSize")));
			this.rtb.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.rtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtb.BackgroundImage")));
			this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb.BulletIndent = ((int)(resources.GetObject("rtb.BulletIndent")));
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
			this.rtb.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.rtb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtb.ImeMode")));
			this.rtb.Location = ((System.Drawing.Point)(resources.GetObject("rtb.Location")));
			this.rtb.MaxLength = ((int)(resources.GetObject("rtb.MaxLength")));
			this.rtb.Multiline = ((bool)(resources.GetObject("rtb.Multiline")));
			this.rtb.Name = "rtb";
			this.rtb.ReadOnly = true;
			this.rtb.RightMargin = ((int)(resources.GetObject("rtb.RightMargin")));
			this.rtb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtb.RightToLeft")));
			this.rtb.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtb.ScrollBars")));
			this.rtb.Size = ((System.Drawing.Size)(resources.GetObject("rtb.Size")));
			this.rtb.TabIndex = ((int)(resources.GetObject("rtb.TabIndex")));
			this.rtb.Text = resources.GetString("rtb.Text");
			this.rtb.Visible = ((bool)(resources.GetObject("rtb.Visible")));
			this.rtb.WordWrap = ((bool)(resources.GetObject("rtb.WordWrap")));
			this.rtb.ZoomFactor = ((System.Single)(resources.GetObject("rtb.ZoomFactor")));
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
			this.linkLabel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel1.Dock")));
			this.linkLabel1.Enabled = ((bool)(resources.GetObject("linkLabel1.Enabled")));
			this.linkLabel1.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel1.Font")));
			this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
			this.linkLabel1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.ImageAlign")));
			this.linkLabel1.ImageIndex = ((int)(resources.GetObject("linkLabel1.ImageIndex")));
			this.linkLabel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel1.ImeMode")));
			this.linkLabel1.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel1.LinkArea")));
			this.linkLabel1.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel1.Location")));
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel1.RightToLeft")));
			this.linkLabel1.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel1.Size")));
			this.linkLabel1.TabIndex = ((int)(resources.GetObject("linkLabel1.TabIndex")));
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
			this.linkLabel1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.TextAlign")));
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyToClipboard);
			// 
			// pictureBox1
			// 
			this.pictureBox1.AccessibleDescription = resources.GetString("pictureBox1.AccessibleDescription");
			this.pictureBox1.AccessibleName = resources.GetString("pictureBox1.AccessibleName");
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pictureBox1.Anchor")));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pictureBox1.Dock")));
			this.pictureBox1.Enabled = ((bool)(resources.GetObject("pictureBox1.Enabled")));
			this.pictureBox1.Font = ((System.Drawing.Font)(resources.GetObject("pictureBox1.Font")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pictureBox1.ImeMode")));
			this.pictureBox1.Location = ((System.Drawing.Point)(resources.GetObject("pictureBox1.Location")));
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pictureBox1.RightToLeft")));
			this.pictureBox1.Size = ((System.Drawing.Size)(resources.GetObject("pictureBox1.Size")));
			this.pictureBox1.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pictureBox1.SizeMode")));
			this.pictureBox1.TabIndex = ((int)(resources.GetObject("pictureBox1.TabIndex")));
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Text = resources.GetString("pictureBox1.Text");
			this.pictureBox1.Visible = ((bool)(resources.GetObject("pictureBox1.Visible")));
			// 
			// lldetail
			// 
			this.lldetail.AccessibleDescription = resources.GetString("lldetail.AccessibleDescription");
			this.lldetail.AccessibleName = resources.GetString("lldetail.AccessibleName");
			this.lldetail.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldetail.Anchor")));
			this.lldetail.AutoSize = ((bool)(resources.GetObject("lldetail.AutoSize")));
			this.lldetail.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldetail.Dock")));
			this.lldetail.Enabled = ((bool)(resources.GetObject("lldetail.Enabled")));
			this.lldetail.Font = ((System.Drawing.Font)(resources.GetObject("lldetail.Font")));
			this.lldetail.Image = ((System.Drawing.Image)(resources.GetObject("lldetail.Image")));
			this.lldetail.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldetail.ImageAlign")));
			this.lldetail.ImageIndex = ((int)(resources.GetObject("lldetail.ImageIndex")));
			this.lldetail.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldetail.ImeMode")));
			this.lldetail.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldetail.LinkArea")));
			this.lldetail.Location = ((System.Drawing.Point)(resources.GetObject("lldetail.Location")));
			this.lldetail.Name = "lldetail";
			this.lldetail.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldetail.RightToLeft")));
			this.lldetail.Size = ((System.Drawing.Size)(resources.GetObject("lldetail.Size")));
			this.lldetail.TabIndex = ((int)(resources.GetObject("lldetail.TabIndex")));
			this.lldetail.TabStop = true;
			this.lldetail.Text = resources.GetString("lldetail.Text");
			this.lldetail.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldetail.TextAlign")));
			this.lldetail.Visible = ((bool)(resources.GetObject("lldetail.Visible")));
			this.lldetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowDetail);
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.lberr);
			this.panel1.Controls.Add(this.lldetail);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.linkLabel2);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.tbsup);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// linkLabel2
			// 
			this.linkLabel2.AccessibleDescription = resources.GetString("linkLabel2.AccessibleDescription");
			this.linkLabel2.AccessibleName = resources.GetString("linkLabel2.AccessibleName");
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel2.Anchor")));
			this.linkLabel2.AutoSize = ((bool)(resources.GetObject("linkLabel2.AutoSize")));
			this.linkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel2.Dock")));
			this.linkLabel2.Enabled = ((bool)(resources.GetObject("linkLabel2.Enabled")));
			this.linkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel2.Font")));
			this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
			this.linkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.ImageAlign")));
			this.linkLabel2.ImageIndex = ((int)(resources.GetObject("linkLabel2.ImageIndex")));
			this.linkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel2.ImeMode")));
			this.linkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel2.LinkArea")));
			this.linkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel2.Location")));
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel2.RightToLeft")));
			this.linkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel2.Size")));
			this.linkLabel2.TabIndex = ((int)(resources.GetObject("linkLabel2.TabIndex")));
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = resources.GetString("linkLabel2.Text");
			this.linkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.TextAlign")));
			this.linkLabel2.Visible = ((bool)(resources.GetObject("linkLabel2.Visible")));
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Support);
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
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
			// tbsup
			// 
			this.tbsup.AccessibleDescription = resources.GetString("tbsup.AccessibleDescription");
			this.tbsup.AccessibleName = resources.GetString("tbsup.AccessibleName");
			this.tbsup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsup.Anchor")));
			this.tbsup.AutoSize = ((bool)(resources.GetObject("tbsup.AutoSize")));
			this.tbsup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsup.BackgroundImage")));
			this.tbsup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsup.Dock")));
			this.tbsup.Enabled = ((bool)(resources.GetObject("tbsup.Enabled")));
			this.tbsup.Font = ((System.Drawing.Font)(resources.GetObject("tbsup.Font")));
			this.tbsup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsup.ImeMode")));
			this.tbsup.Location = ((System.Drawing.Point)(resources.GetObject("tbsup.Location")));
			this.tbsup.MaxLength = ((int)(resources.GetObject("tbsup.MaxLength")));
			this.tbsup.Multiline = ((bool)(resources.GetObject("tbsup.Multiline")));
			this.tbsup.Name = "tbsup";
			this.tbsup.PasswordChar = ((char)(resources.GetObject("tbsup.PasswordChar")));
			this.tbsup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsup.RightToLeft")));
			this.tbsup.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsup.ScrollBars")));
			this.tbsup.Size = ((System.Drawing.Size)(resources.GetObject("tbsup.Size")));
			this.tbsup.TabIndex = ((int)(resources.GetObject("tbsup.TabIndex")));
			this.tbsup.Text = resources.GetString("tbsup.Text");
			this.tbsup.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsup.TextAlign")));
			this.tbsup.Visible = ((bool)(resources.GetObject("tbsup.Visible")));
			this.tbsup.WordWrap = ((bool)(resources.GetObject("tbsup.WordWrap")));
			// 
			// ExceptionForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.gbdetail);
			this.DockPadding.All = 8;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "ExceptionForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.gbdetail.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Show an Exception Message
		/// </summary>
		/// <param name="ex">The Exception that as thrown</param>
		public static void Execute(Exception ex) 
		{
			Execute(ex.Message, ex);
		}

		private void Support(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				System.Windows.Forms.Help.ShowHelp(this, this.tbsup.Text);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void CopyToClipboard(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
#if MAC
#else
			Clipboard.SetDataObject("[error]"+rtb.Text+"[/error]", true);
#endif
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ShowDetail(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lldetail.Visible = false;
			gbdetail.Visible = true;
			Height += gbdetail.Height;
		}

		/// <summary>
		/// Show an Exception Message
		/// </summary>
		/// <param name="message">The Message you want to display</param>
		/// <param name="ex">The Exception that as thrown</param>
		public static void Execute(string message, Exception ex) 
		{
			if (message==null) message = "";
			if (message.Trim()=="") message = ex.Message;

			Exception myex = ex;
			string extrace = "";
			while (myex!=null) 
			{
				extrace += myex.ToString()/*+": "+myex.Message*/+Helper.lbr;
				myex = myex.InnerException;
			}
#if MAC
			MessageBox.Show(message+"\n\n"+extrace+"\n\n"+myex);
			return;
#endif

			ExceptionForm frm = new ExceptionForm();

			frm.lberr.Text= message.Trim();

			string text = "";
			text += @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fswiss\fprq2\fcharset0 Verdana;}}";
			text += @"{\colortbl ;\red90\green90\blue90;}";
			if (ex.GetType()==typeof(Warning)) 
			{
				frm.Text = "Warning";
				frm.lberr.Text = "Warning: "+frm.lberr.Text;
				frm.linkLabel2.Visible = false;
				text += @"\viewkind4\uc1\pard\cf1\b\f0\fs16 This is just a Warning. It is supposed to keep you informed about a Problem. Most of the time this is not a Bug!\b0\par";				
				text += @"\pard\par";
				text += @"\pard\li284 "+((Warning)ex).Details.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par" ;
			} 
#if DEBUG
#else		
			else 
#endif
			{				
				text += @"\viewkind4\uc1\pard\cf1\b\f0\fs16 Message:\b0\par";
				text += @"\pard\li284 "+message.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par" ;
			

				try 
				{
					text += @"\pard\par";
					text += @"\b SimPE Version:\par";
					text += @"\pard\li284\b0 "+Helper.StartedGui.ToString()+" ("+Helper.SimPeVersion.ProductMajorPart.ToString()+"."+Helper.SimPeVersion.ProductMinorPart.ToString()+"."+Helper.SimPeVersion.ProductBuildPart.ToString()+"."+Helper.SimPeVersion.ProductPrivatePart.ToString()+")."+@"\par";
				} 
				catch {}

				text += @"\pard\par";
				text += @"\b Exception Stack:\par";
				text += @"\pard\li284\b0 "+extrace.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
		

				if (ex.Source!=null) 
				{
					text += @"\pard\par";
					text += @"\b Source:\par";
					text += @"\pard\li284\b0 "+ex.Source.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
				}
			
				if (ex.StackTrace!=null) 
				{
					text += @"\pard\par";
					text += @"\b Execution Stack:\par";
					text += @"\pard\li284\b0 "+ex.StackTrace.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
				}
			}

			text += @"}";

			text = text.Replace("\n", @"\par\pard");
#if MAC
#else
			frm.rtb.Rtf = text;
#endif

			if ((Helper.WindowsRegistry.HiddenMode) || (Helper.DebugMode))
			{
				frm.lldetail.Visible = false;
			} 
			else 
			{
				frm.gbdetail.Visible = false;
				frm.Height -= frm.gbdetail.Height;
			}

			
			frm.ShowDialog();
		}
	}
}
