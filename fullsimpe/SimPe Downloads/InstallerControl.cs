using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Plugin.Downloads;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für InstallerControl.
	/// </summary>
	public class InstallerControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Panel pndrop;
		private System.Windows.Forms.PictureBox pb;
        Ambertation.Windows.Forms.XPTaskBoxSimple tbs;
        private ComboBox cb;
        private RichTextBox rtb;
        private Label lbCat;
        private Label label1;
        private Label lbFace;
        private Label label7;
        private Label lbVert;
        private Label label5;
        private Label lbPrice;
        private Label label3;
		private System.Windows.Forms.Label lbGuid;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.LinkLabel llOptions;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InstallerControl()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

            Clear();
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(InstallerControl));
			this.pndrop = new System.Windows.Forms.Panel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.tbs = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.lbType = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lbGuid = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbVert = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbCat = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.cb = new System.Windows.Forms.ComboBox();
			this.lbPrice = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbFace = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.llOptions = new System.Windows.Forms.LinkLabel();
			this.pndrop.SuspendLayout();
			this.tbs.SuspendLayout();
			this.SuspendLayout();
			// 
			// pndrop
			// 
			this.pndrop.AccessibleDescription = resources.GetString("pndrop.AccessibleDescription");
			this.pndrop.AccessibleName = resources.GetString("pndrop.AccessibleName");
			this.pndrop.AllowDrop = true;
			this.pndrop.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pndrop.Anchor")));
			this.pndrop.AutoScroll = ((bool)(resources.GetObject("pndrop.AutoScroll")));
			this.pndrop.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pndrop.AutoScrollMargin")));
			this.pndrop.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pndrop.AutoScrollMinSize")));
			this.pndrop.BackColor = System.Drawing.Color.Transparent;
			this.pndrop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pndrop.BackgroundImage")));
			this.pndrop.Controls.Add(this.pb);
			this.pndrop.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pndrop.Dock")));
			this.pndrop.Enabled = ((bool)(resources.GetObject("pndrop.Enabled")));
			this.pndrop.Font = ((System.Drawing.Font)(resources.GetObject("pndrop.Font")));
			this.pndrop.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pndrop.ImeMode")));
			this.pndrop.Location = ((System.Drawing.Point)(resources.GetObject("pndrop.Location")));
			this.pndrop.Name = "pndrop";
			this.pndrop.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pndrop.RightToLeft")));
			this.pndrop.Size = ((System.Drawing.Size)(resources.GetObject("pndrop.Size")));
			this.pndrop.TabIndex = ((int)(resources.GetObject("pndrop.TabIndex")));
			this.pndrop.Text = resources.GetString("pndrop.Text");
			this.pndrop.Visible = ((bool)(resources.GetObject("pndrop.Visible")));
			this.pndrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
			this.pndrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pb.SizeMode")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TabStop = false;
			this.pb.Text = resources.GetString("pb.Text");
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			// 
			// tbs
			// 
			this.tbs.AccessibleDescription = resources.GetString("tbs.AccessibleDescription");
			this.tbs.AccessibleName = resources.GetString("tbs.AccessibleName");
			this.tbs.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbs.Anchor")));
			this.tbs.AutoScroll = ((bool)(resources.GetObject("tbs.AutoScroll")));
			this.tbs.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbs.AutoScrollMargin")));
			this.tbs.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbs.AutoScrollMinSize")));
			this.tbs.BackColor = System.Drawing.Color.Transparent;
			this.tbs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbs.BackgroundImage")));
			this.tbs.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbs.BorderColor = System.Drawing.SystemColors.Window;
			this.tbs.Controls.Add(this.lbType);
			this.tbs.Controls.Add(this.label6);
			this.tbs.Controls.Add(this.lbGuid);
			this.tbs.Controls.Add(this.label4);
			this.tbs.Controls.Add(this.lbVert);
			this.tbs.Controls.Add(this.label5);
			this.tbs.Controls.Add(this.lbCat);
			this.tbs.Controls.Add(this.label1);
			this.tbs.Controls.Add(this.rtb);
			this.tbs.Controls.Add(this.cb);
			this.tbs.Controls.Add(this.lbPrice);
			this.tbs.Controls.Add(this.label3);
			this.tbs.Controls.Add(this.lbFace);
			this.tbs.Controls.Add(this.label7);
			this.tbs.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbs.Dock")));
			this.tbs.DockPadding.Bottom = 4;
			this.tbs.DockPadding.Left = 4;
			this.tbs.DockPadding.Right = 4;
			this.tbs.DockPadding.Top = 44;
			this.tbs.Enabled = ((bool)(resources.GetObject("tbs.Enabled")));
			this.tbs.Font = ((System.Drawing.Font)(resources.GetObject("tbs.Font")));
			this.tbs.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.tbs.HeaderHeight = ((int)(resources.GetObject("tbs.HeaderHeight")));
			this.tbs.HeaderText = resources.GetString("tbs.HeaderText");
			this.tbs.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tbs.Icon = ((System.Drawing.Image)(resources.GetObject("tbs.Icon")));
			this.tbs.IconLocation = new System.Drawing.Point(4, 12);
			this.tbs.IconSize = new System.Drawing.Size(32, 32);
			this.tbs.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbs.ImeMode")));
			this.tbs.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbs.Location = ((System.Drawing.Point)(resources.GetObject("tbs.Location")));
			this.tbs.Name = "tbs";
			this.tbs.RightHeaderColor = System.Drawing.Color.Transparent;
			this.tbs.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbs.RightToLeft")));
			this.tbs.Size = ((System.Drawing.Size)(resources.GetObject("tbs.Size")));
			this.tbs.TabIndex = ((int)(resources.GetObject("tbs.TabIndex")));
			this.tbs.Text = resources.GetString("tbs.Text");
			this.tbs.Visible = ((bool)(resources.GetObject("tbs.Visible")));
			// 
			// lbType
			// 
			this.lbType.AccessibleDescription = resources.GetString("lbType.AccessibleDescription");
			this.lbType.AccessibleName = resources.GetString("lbType.AccessibleName");
			this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbType.Anchor")));
			this.lbType.AutoSize = ((bool)(resources.GetObject("lbType.AutoSize")));
			this.lbType.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbType.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbType.Dock")));
			this.lbType.Enabled = ((bool)(resources.GetObject("lbType.Enabled")));
			this.lbType.Font = ((System.Drawing.Font)(resources.GetObject("lbType.Font")));
			this.lbType.Image = ((System.Drawing.Image)(resources.GetObject("lbType.Image")));
			this.lbType.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbType.ImageAlign")));
			this.lbType.ImageIndex = ((int)(resources.GetObject("lbType.ImageIndex")));
			this.lbType.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbType.ImeMode")));
			this.lbType.Location = ((System.Drawing.Point)(resources.GetObject("lbType.Location")));
			this.lbType.Name = "lbType";
			this.lbType.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbType.RightToLeft")));
			this.lbType.Size = ((System.Drawing.Size)(resources.GetObject("lbType.Size")));
			this.lbType.TabIndex = ((int)(resources.GetObject("lbType.TabIndex")));
			this.lbType.Text = resources.GetString("lbType.Text");
			this.lbType.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbType.TextAlign")));
			this.lbType.Visible = ((bool)(resources.GetObject("lbType.Visible")));
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Enabled = ((bool)(resources.GetObject("label6.Enabled")));
			this.label6.Font = ((System.Drawing.Font)(resources.GetObject("label6.Font")));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			// 
			// lbGuid
			// 
			this.lbGuid.AccessibleDescription = resources.GetString("lbGuid.AccessibleDescription");
			this.lbGuid.AccessibleName = resources.GetString("lbGuid.AccessibleName");
			this.lbGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbGuid.Anchor")));
			this.lbGuid.AutoSize = ((bool)(resources.GetObject("lbGuid.AutoSize")));
			this.lbGuid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbGuid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbGuid.Dock")));
			this.lbGuid.Enabled = ((bool)(resources.GetObject("lbGuid.Enabled")));
			this.lbGuid.Font = ((System.Drawing.Font)(resources.GetObject("lbGuid.Font")));
			this.lbGuid.Image = ((System.Drawing.Image)(resources.GetObject("lbGuid.Image")));
			this.lbGuid.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbGuid.ImageAlign")));
			this.lbGuid.ImageIndex = ((int)(resources.GetObject("lbGuid.ImageIndex")));
			this.lbGuid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbGuid.ImeMode")));
			this.lbGuid.Location = ((System.Drawing.Point)(resources.GetObject("lbGuid.Location")));
			this.lbGuid.Name = "lbGuid";
			this.lbGuid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbGuid.RightToLeft")));
			this.lbGuid.Size = ((System.Drawing.Size)(resources.GetObject("lbGuid.Size")));
			this.lbGuid.TabIndex = ((int)(resources.GetObject("lbGuid.TabIndex")));
			this.lbGuid.Text = resources.GetString("lbGuid.Text");
			this.lbGuid.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbGuid.TextAlign")));
			this.lbGuid.Visible = ((bool)(resources.GetObject("lbGuid.Visible")));
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// lbVert
			// 
			this.lbVert.AccessibleDescription = resources.GetString("lbVert.AccessibleDescription");
			this.lbVert.AccessibleName = resources.GetString("lbVert.AccessibleName");
			this.lbVert.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbVert.Anchor")));
			this.lbVert.AutoSize = ((bool)(resources.GetObject("lbVert.AutoSize")));
			this.lbVert.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbVert.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbVert.Dock")));
			this.lbVert.Enabled = ((bool)(resources.GetObject("lbVert.Enabled")));
			this.lbVert.Font = ((System.Drawing.Font)(resources.GetObject("lbVert.Font")));
			this.lbVert.Image = ((System.Drawing.Image)(resources.GetObject("lbVert.Image")));
			this.lbVert.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVert.ImageAlign")));
			this.lbVert.ImageIndex = ((int)(resources.GetObject("lbVert.ImageIndex")));
			this.lbVert.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbVert.ImeMode")));
			this.lbVert.Location = ((System.Drawing.Point)(resources.GetObject("lbVert.Location")));
			this.lbVert.Name = "lbVert";
			this.lbVert.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbVert.RightToLeft")));
			this.lbVert.Size = ((System.Drawing.Size)(resources.GetObject("lbVert.Size")));
			this.lbVert.TabIndex = ((int)(resources.GetObject("lbVert.TabIndex")));
			this.lbVert.Text = resources.GetString("lbVert.Text");
			this.lbVert.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVert.TextAlign")));
			this.lbVert.Visible = ((bool)(resources.GetObject("lbVert.Visible")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// lbCat
			// 
			this.lbCat.AccessibleDescription = resources.GetString("lbCat.AccessibleDescription");
			this.lbCat.AccessibleName = resources.GetString("lbCat.AccessibleName");
			this.lbCat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbCat.Anchor")));
			this.lbCat.AutoSize = ((bool)(resources.GetObject("lbCat.AutoSize")));
			this.lbCat.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbCat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbCat.Dock")));
			this.lbCat.Enabled = ((bool)(resources.GetObject("lbCat.Enabled")));
			this.lbCat.Font = ((System.Drawing.Font)(resources.GetObject("lbCat.Font")));
			this.lbCat.Image = ((System.Drawing.Image)(resources.GetObject("lbCat.Image")));
			this.lbCat.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbCat.ImageAlign")));
			this.lbCat.ImageIndex = ((int)(resources.GetObject("lbCat.ImageIndex")));
			this.lbCat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbCat.ImeMode")));
			this.lbCat.Location = ((System.Drawing.Point)(resources.GetObject("lbCat.Location")));
			this.lbCat.Name = "lbCat";
			this.lbCat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbCat.RightToLeft")));
			this.lbCat.Size = ((System.Drawing.Size)(resources.GetObject("lbCat.Size")));
			this.lbCat.TabIndex = ((int)(resources.GetObject("lbCat.TabIndex")));
			this.lbCat.Text = resources.GetString("lbCat.Text");
			this.lbCat.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbCat.TextAlign")));
			this.lbCat.Visible = ((bool)(resources.GetObject("lbCat.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
			// rtb
			// 
			this.rtb.AccessibleDescription = resources.GetString("rtb.AccessibleDescription");
			this.rtb.AccessibleName = resources.GetString("rtb.AccessibleName");
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtb.Anchor")));
			this.rtb.AutoSize = ((bool)(resources.GetObject("rtb.AutoSize")));
			this.rtb.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.rtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtb.BackgroundImage")));
			this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb.BulletIndent = ((int)(resources.GetObject("rtb.BulletIndent")));
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
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
			// cb
			// 
			this.cb.AccessibleDescription = resources.GetString("cb.AccessibleDescription");
			this.cb.AccessibleName = resources.GetString("cb.AccessibleName");
			this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cb.Anchor")));
			this.cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cb.BackgroundImage")));
			this.cb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cb.Dock")));
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Enabled = ((bool)(resources.GetObject("cb.Enabled")));
			this.cb.Font = ((System.Drawing.Font)(resources.GetObject("cb.Font")));
			this.cb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cb.ImeMode")));
			this.cb.IntegralHeight = ((bool)(resources.GetObject("cb.IntegralHeight")));
			this.cb.ItemHeight = ((int)(resources.GetObject("cb.ItemHeight")));
			this.cb.Location = ((System.Drawing.Point)(resources.GetObject("cb.Location")));
			this.cb.MaxDropDownItems = ((int)(resources.GetObject("cb.MaxDropDownItems")));
			this.cb.MaxLength = ((int)(resources.GetObject("cb.MaxLength")));
			this.cb.Name = "cb";
			this.cb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cb.RightToLeft")));
			this.cb.Size = ((System.Drawing.Size)(resources.GetObject("cb.Size")));
			this.cb.TabIndex = ((int)(resources.GetObject("cb.TabIndex")));
			this.cb.Text = resources.GetString("cb.Text");
			this.cb.Visible = ((bool)(resources.GetObject("cb.Visible")));
			this.cb.SelectedIndexChanged += new System.EventHandler(this.SelectedInfo);
			// 
			// lbPrice
			// 
			this.lbPrice.AccessibleDescription = resources.GetString("lbPrice.AccessibleDescription");
			this.lbPrice.AccessibleName = resources.GetString("lbPrice.AccessibleName");
			this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbPrice.Anchor")));
			this.lbPrice.AutoSize = ((bool)(resources.GetObject("lbPrice.AutoSize")));
			this.lbPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbPrice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbPrice.Dock")));
			this.lbPrice.Enabled = ((bool)(resources.GetObject("lbPrice.Enabled")));
			this.lbPrice.Font = ((System.Drawing.Font)(resources.GetObject("lbPrice.Font")));
			this.lbPrice.Image = ((System.Drawing.Image)(resources.GetObject("lbPrice.Image")));
			this.lbPrice.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPrice.ImageAlign")));
			this.lbPrice.ImageIndex = ((int)(resources.GetObject("lbPrice.ImageIndex")));
			this.lbPrice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbPrice.ImeMode")));
			this.lbPrice.Location = ((System.Drawing.Point)(resources.GetObject("lbPrice.Location")));
			this.lbPrice.Name = "lbPrice";
			this.lbPrice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbPrice.RightToLeft")));
			this.lbPrice.Size = ((System.Drawing.Size)(resources.GetObject("lbPrice.Size")));
			this.lbPrice.TabIndex = ((int)(resources.GetObject("lbPrice.TabIndex")));
			this.lbPrice.Text = resources.GetString("lbPrice.Text");
			this.lbPrice.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPrice.TextAlign")));
			this.lbPrice.Visible = ((bool)(resources.GetObject("lbPrice.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
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
			// lbFace
			// 
			this.lbFace.AccessibleDescription = resources.GetString("lbFace.AccessibleDescription");
			this.lbFace.AccessibleName = resources.GetString("lbFace.AccessibleName");
			this.lbFace.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbFace.Anchor")));
			this.lbFace.AutoSize = ((bool)(resources.GetObject("lbFace.AutoSize")));
			this.lbFace.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lbFace.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbFace.Dock")));
			this.lbFace.Enabled = ((bool)(resources.GetObject("lbFace.Enabled")));
			this.lbFace.Font = ((System.Drawing.Font)(resources.GetObject("lbFace.Font")));
			this.lbFace.Image = ((System.Drawing.Image)(resources.GetObject("lbFace.Image")));
			this.lbFace.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbFace.ImageAlign")));
			this.lbFace.ImageIndex = ((int)(resources.GetObject("lbFace.ImageIndex")));
			this.lbFace.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbFace.ImeMode")));
			this.lbFace.Location = ((System.Drawing.Point)(resources.GetObject("lbFace.Location")));
			this.lbFace.Name = "lbFace";
			this.lbFace.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbFace.RightToLeft")));
			this.lbFace.Size = ((System.Drawing.Size)(resources.GetObject("lbFace.Size")));
			this.lbFace.TabIndex = ((int)(resources.GetObject("lbFace.TabIndex")));
			this.lbFace.Text = resources.GetString("lbFace.Text");
			this.lbFace.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbFace.TextAlign")));
			this.lbFace.Visible = ((bool)(resources.GetObject("lbFace.Visible")));
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
			// 
			// llOptions
			// 
			this.llOptions.AccessibleDescription = resources.GetString("llOptions.AccessibleDescription");
			this.llOptions.AccessibleName = resources.GetString("llOptions.AccessibleName");
			this.llOptions.ActiveLinkColor = System.Drawing.Color.LightCoral;
			this.llOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llOptions.Anchor")));
			this.llOptions.AutoSize = ((bool)(resources.GetObject("llOptions.AutoSize")));
			this.llOptions.BackColor = System.Drawing.Color.Transparent;
			this.llOptions.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llOptions.Dock")));
			this.llOptions.Enabled = ((bool)(resources.GetObject("llOptions.Enabled")));
			this.llOptions.Font = ((System.Drawing.Font)(resources.GetObject("llOptions.Font")));
			this.llOptions.Image = ((System.Drawing.Image)(resources.GetObject("llOptions.Image")));
			this.llOptions.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llOptions.ImageAlign")));
			this.llOptions.ImageIndex = ((int)(resources.GetObject("llOptions.ImageIndex")));
			this.llOptions.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llOptions.ImeMode")));
			this.llOptions.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llOptions.LinkArea")));
			this.llOptions.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(224)), ((System.Byte)(224)), ((System.Byte)(224)));
			this.llOptions.Location = ((System.Drawing.Point)(resources.GetObject("llOptions.Location")));
			this.llOptions.Name = "llOptions";
			this.llOptions.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llOptions.RightToLeft")));
			this.llOptions.Size = ((System.Drawing.Size)(resources.GetObject("llOptions.Size")));
			this.llOptions.TabIndex = ((int)(resources.GetObject("llOptions.TabIndex")));
			this.llOptions.TabStop = true;
			this.llOptions.Text = resources.GetString("llOptions.Text");
			this.llOptions.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llOptions.TextAlign")));
			this.llOptions.Visible = ((bool)(resources.GetObject("llOptions.Visible")));
			this.llOptions.VisitedLinkColor = System.Drawing.Color.Silver;
			this.llOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowOptions);
			// 
			// InstallerControl
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.llOptions);
			this.Controls.Add(this.pndrop);
			this.Controls.Add(this.tbs);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "InstallerControl";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.pndrop.ResumeLayout(false);
			this.tbs.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public static void Cleanup()
		{
			SimPe.Plugin.DownloadsToolFactory.TeleportFileIndex.CloseAssignedPackages();
			SimPe.Packages.StreamFactory.CleanupTeleport();
		}

        public void LoadFiles(string[] files)
        {			
			Wait.Start(files.Length);
            foreach (Downloads.IPackageInfo nfo in cb.Items)
                nfo.Dispose();
            this.cb.Items.Clear();
			Cleanup();
			

			int ct = 0;
            foreach (string file in files)
            {
				Wait.Progress = ct++;
                Downloads.IPackageHandler hnd = Downloads.HandlerRegistry.Global.LoadFileHandler(file);
                if (hnd != null)
                {
                    foreach (Downloads.IPackageInfo nfo in hnd.Objects)
                        cb.Items.Add(nfo);
                }
				hnd.FreeResources();                
            }
			if (cb.Items.Count > 0) cb.SelectedIndex = 0;

			Wait.Stop();			
        }

		#region Drag&Drop

		/// <summary>
		/// Returns the Names of the Dropped Files
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		string[] DragDropNames(System.Windows.Forms.DragEventArgs e) 
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

			if ( a != null )
			{
				string[] res = new string[a.Length];				
				for (int i=0; i<a.Length; i++) res[i] = a.GetValue(i).ToString();
				return res;
			}

			return new string[0];
		}

		/// <summary>
		/// Returns the Effect that should be displayed based on the Files
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		DragDropEffects DragDropEffect(string[] names)
		{
            foreach (string name in names)			
			{
				if (Downloads.HandlerRegistry.Global.HasFileHandler(name))
					return DragDropEffects.Copy;
			}
			
			return DragDropEffects.None;		
		}

		/// <summary>
		/// Someone tries to throw a File
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragEnterFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
			{
				try
				{
					e.Effect = DragDropEffect(DragDropNames(e));					
				} 
				catch (Exception)
				{
				}
				
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// <summary>
		/// A File has been dropped
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragDropFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				string[] files = DragDropNames(e);
                LoadFiles(files);
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}

		}
		#endregion

        protected void Clear()
        {
            pb.Image = null;
            this.tbs.HeaderText = "";
            this.rtb.Text = "";
            lbCat.Text = "";
            lbPrice.Text = "";
            lbVert.Text = "0";
            lbFace.Text = "0";
			lbGuid.Text = "";
			lbType.Text = "";
        }

        protected Downloads.IPackageInfo SelectedPackageInfo
        {
            get { return cb.SelectedItem as Downloads.IPackageInfo; }
        }
        private void SelectedInfo(object sender, EventArgs e)
        {
            SelectedInfo(SelectedPackageInfo);
        }

		private void ShowOptions(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			SimPe.RemoteControl.ShowCustomSettings(SimPe.Plugin.DownloadsToolFactory.Settings);
		}

        protected void SelectedInfo(Downloads.IPackageInfo nfo)
        {
            Clear();
            if (nfo != null)
            {
				nfo.CreatePostponed3DPreview();
                if (nfo.Image!=null) pb.Image = nfo.GetThumbnail();
				else pb.Image = PackageInfo.DefaultImage;
                tbs.HeaderText = nfo.Name;
                rtb.Text = nfo.Description;
                lbCat.Text = nfo.Category;
                lbPrice.Text = nfo.Price.ToString() + " $";
                lbVert.Text = nfo.VertexCount.ToString();
                lbFace.Text = nfo.FaceCount.ToString();
				lbGuid.Text = "";
				lbType.Text = nfo.Type.ToString();
				foreach (uint guid in nfo.Guids)
					lbGuid.Text += "0x"+Helper.HexString(guid)+" ";

				lbVert.ForeColor = Color.Black;
				if (nfo.HighVertexCount) lbVert.ForeColor = Color.Red;

				lbFace.ForeColor = Color.Black;
				if (nfo.HighFaceCount) lbFace.ForeColor = Color.Red;
            }
        }
	}
}
