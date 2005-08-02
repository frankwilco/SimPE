using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Zusammenfassung für ObjectPreview.
	/// </summary>
	public class NeighborhoodPreview : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Label lbAbout;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbPop;
		private System.Windows.Forms.LinkLabel llEdit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbUni;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbVer;
		private System.Windows.Forms.Label lbType;
		private System.Windows.Forms.Label label6;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NeighborhoodPreview()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			BackColor = Color.Transparent;
			loaded = false;			

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			BuildDefaultImage();
			ClearScreen();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NeighborhoodPreview));
			this.pb = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbAbout = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lbPop = new System.Windows.Forms.Label();
			this.llEdit = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.lbUni = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbVer = new System.Windows.Forms.Label();
			this.lbType = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackColor = System.Drawing.Color.Transparent;
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
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
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
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
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
			// lbName
			// 
			this.lbName.AccessibleDescription = resources.GetString("lbName.AccessibleDescription");
			this.lbName.AccessibleName = resources.GetString("lbName.AccessibleName");
			this.lbName.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbName.Anchor")));
			this.lbName.AutoSize = ((bool)(resources.GetObject("lbName.AutoSize")));
			this.lbName.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbName.Dock")));
			this.lbName.Enabled = ((bool)(resources.GetObject("lbName.Enabled")));
			this.lbName.Font = ((System.Drawing.Font)(resources.GetObject("lbName.Font")));
			this.lbName.Image = ((System.Drawing.Image)(resources.GetObject("lbName.Image")));
			this.lbName.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbName.ImageAlign")));
			this.lbName.ImageIndex = ((int)(resources.GetObject("lbName.ImageIndex")));
			this.lbName.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbName.ImeMode")));
			this.lbName.Location = ((System.Drawing.Point)(resources.GetObject("lbName.Location")));
			this.lbName.Name = "lbName";
			this.lbName.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbName.RightToLeft")));
			this.lbName.Size = ((System.Drawing.Size)(resources.GetObject("lbName.Size")));
			this.lbName.TabIndex = ((int)(resources.GetObject("lbName.TabIndex")));
			this.lbName.Text = resources.GetString("lbName.Text");
			this.lbName.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbName.TextAlign")));
			this.lbName.Visible = ((bool)(resources.GetObject("lbName.Visible")));
			// 
			// lbAbout
			// 
			this.lbAbout.AccessibleDescription = resources.GetString("lbAbout.AccessibleDescription");
			this.lbAbout.AccessibleName = resources.GetString("lbAbout.AccessibleName");
			this.lbAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbAbout.Anchor")));
			this.lbAbout.AutoSize = ((bool)(resources.GetObject("lbAbout.AutoSize")));
			this.lbAbout.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbAbout.Dock")));
			this.lbAbout.Enabled = ((bool)(resources.GetObject("lbAbout.Enabled")));
			this.lbAbout.Font = ((System.Drawing.Font)(resources.GetObject("lbAbout.Font")));
			this.lbAbout.Image = ((System.Drawing.Image)(resources.GetObject("lbAbout.Image")));
			this.lbAbout.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbAbout.ImageAlign")));
			this.lbAbout.ImageIndex = ((int)(resources.GetObject("lbAbout.ImageIndex")));
			this.lbAbout.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbAbout.ImeMode")));
			this.lbAbout.Location = ((System.Drawing.Point)(resources.GetObject("lbAbout.Location")));
			this.lbAbout.Name = "lbAbout";
			this.lbAbout.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbAbout.RightToLeft")));
			this.lbAbout.Size = ((System.Drawing.Size)(resources.GetObject("lbAbout.Size")));
			this.lbAbout.TabIndex = ((int)(resources.GetObject("lbAbout.TabIndex")));
			this.lbAbout.Text = resources.GetString("lbAbout.Text");
			this.lbAbout.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbAbout.TextAlign")));
			this.lbAbout.Visible = ((bool)(resources.GetObject("lbAbout.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
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
			// lbPop
			// 
			this.lbPop.AccessibleDescription = resources.GetString("lbPop.AccessibleDescription");
			this.lbPop.AccessibleName = resources.GetString("lbPop.AccessibleName");
			this.lbPop.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbPop.Anchor")));
			this.lbPop.AutoSize = ((bool)(resources.GetObject("lbPop.AutoSize")));
			this.lbPop.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbPop.Dock")));
			this.lbPop.Enabled = ((bool)(resources.GetObject("lbPop.Enabled")));
			this.lbPop.Font = ((System.Drawing.Font)(resources.GetObject("lbPop.Font")));
			this.lbPop.Image = ((System.Drawing.Image)(resources.GetObject("lbPop.Image")));
			this.lbPop.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPop.ImageAlign")));
			this.lbPop.ImageIndex = ((int)(resources.GetObject("lbPop.ImageIndex")));
			this.lbPop.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbPop.ImeMode")));
			this.lbPop.Location = ((System.Drawing.Point)(resources.GetObject("lbPop.Location")));
			this.lbPop.Name = "lbPop";
			this.lbPop.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbPop.RightToLeft")));
			this.lbPop.Size = ((System.Drawing.Size)(resources.GetObject("lbPop.Size")));
			this.lbPop.TabIndex = ((int)(resources.GetObject("lbPop.TabIndex")));
			this.lbPop.Text = resources.GetString("lbPop.Text");
			this.lbPop.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPop.TextAlign")));
			this.lbPop.Visible = ((bool)(resources.GetObject("lbPop.Visible")));
			// 
			// llEdit
			// 
			this.llEdit.AccessibleDescription = resources.GetString("llEdit.AccessibleDescription");
			this.llEdit.AccessibleName = resources.GetString("llEdit.AccessibleName");
			this.llEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llEdit.Anchor")));
			this.llEdit.AutoSize = ((bool)(resources.GetObject("llEdit.AutoSize")));
			this.llEdit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llEdit.Dock")));
			this.llEdit.Enabled = ((bool)(resources.GetObject("llEdit.Enabled")));
			this.llEdit.Font = ((System.Drawing.Font)(resources.GetObject("llEdit.Font")));
			this.llEdit.Image = ((System.Drawing.Image)(resources.GetObject("llEdit.Image")));
			this.llEdit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llEdit.ImageAlign")));
			this.llEdit.ImageIndex = ((int)(resources.GetObject("llEdit.ImageIndex")));
			this.llEdit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llEdit.ImeMode")));
			this.llEdit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llEdit.LinkArea")));
			this.llEdit.Location = ((System.Drawing.Point)(resources.GetObject("llEdit.Location")));
			this.llEdit.Name = "llEdit";
			this.llEdit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llEdit.RightToLeft")));
			this.llEdit.Size = ((System.Drawing.Size)(resources.GetObject("llEdit.Size")));
			this.llEdit.TabIndex = ((int)(resources.GetObject("llEdit.TabIndex")));
			this.llEdit.TabStop = true;
			this.llEdit.Text = resources.GetString("llEdit.Text");
			this.llEdit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llEdit.TextAlign")));
			this.llEdit.Visible = ((bool)(resources.GetObject("llEdit.Visible")));
			this.llEdit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llEdit_LinkClicked);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
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
			// lbUni
			// 
			this.lbUni.AccessibleDescription = resources.GetString("lbUni.AccessibleDescription");
			this.lbUni.AccessibleName = resources.GetString("lbUni.AccessibleName");
			this.lbUni.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbUni.Anchor")));
			this.lbUni.AutoSize = ((bool)(resources.GetObject("lbUni.AutoSize")));
			this.lbUni.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbUni.Dock")));
			this.lbUni.Enabled = ((bool)(resources.GetObject("lbUni.Enabled")));
			this.lbUni.Font = ((System.Drawing.Font)(resources.GetObject("lbUni.Font")));
			this.lbUni.Image = ((System.Drawing.Image)(resources.GetObject("lbUni.Image")));
			this.lbUni.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbUni.ImageAlign")));
			this.lbUni.ImageIndex = ((int)(resources.GetObject("lbUni.ImageIndex")));
			this.lbUni.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbUni.ImeMode")));
			this.lbUni.Location = ((System.Drawing.Point)(resources.GetObject("lbUni.Location")));
			this.lbUni.Name = "lbUni";
			this.lbUni.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbUni.RightToLeft")));
			this.lbUni.Size = ((System.Drawing.Size)(resources.GetObject("lbUni.Size")));
			this.lbUni.TabIndex = ((int)(resources.GetObject("lbUni.TabIndex")));
			this.lbUni.Text = resources.GetString("lbUni.Text");
			this.lbUni.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbUni.TextAlign")));
			this.lbUni.Visible = ((bool)(resources.GetObject("lbUni.Visible")));
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
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
			// lbVer
			// 
			this.lbVer.AccessibleDescription = resources.GetString("lbVer.AccessibleDescription");
			this.lbVer.AccessibleName = resources.GetString("lbVer.AccessibleName");
			this.lbVer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbVer.Anchor")));
			this.lbVer.AutoSize = ((bool)(resources.GetObject("lbVer.AutoSize")));
			this.lbVer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbVer.Dock")));
			this.lbVer.Enabled = ((bool)(resources.GetObject("lbVer.Enabled")));
			this.lbVer.Font = ((System.Drawing.Font)(resources.GetObject("lbVer.Font")));
			this.lbVer.Image = ((System.Drawing.Image)(resources.GetObject("lbVer.Image")));
			this.lbVer.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVer.ImageAlign")));
			this.lbVer.ImageIndex = ((int)(resources.GetObject("lbVer.ImageIndex")));
			this.lbVer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbVer.ImeMode")));
			this.lbVer.Location = ((System.Drawing.Point)(resources.GetObject("lbVer.Location")));
			this.lbVer.Name = "lbVer";
			this.lbVer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbVer.RightToLeft")));
			this.lbVer.Size = ((System.Drawing.Size)(resources.GetObject("lbVer.Size")));
			this.lbVer.TabIndex = ((int)(resources.GetObject("lbVer.TabIndex")));
			this.lbVer.Text = resources.GetString("lbVer.Text");
			this.lbVer.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbVer.TextAlign")));
			this.lbVer.Visible = ((bool)(resources.GetObject("lbVer.Visible")));
			// 
			// lbType
			// 
			this.lbType.AccessibleDescription = resources.GetString("lbType.AccessibleDescription");
			this.lbType.AccessibleName = resources.GetString("lbType.AccessibleName");
			this.lbType.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbType.Anchor")));
			this.lbType.AutoSize = ((bool)(resources.GetObject("lbType.AutoSize")));
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
			// NeighborhoodPreview
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.lbVer);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lbUni);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.llEdit);
			this.Controls.Add(this.lbPop);
			this.Controls.Add(this.lbAbout);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NeighborhoodPreview";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Properties		

		bool loaded;
		[Browsable(false)]
		public bool Loaded
		{
			get { return loaded; }
		}

		SimPe.Interfaces.Files.IPackageFile pkg;
		[Browsable(false)]
		public SimPe.Interfaces.Files.IPackageFile Package
		{
			get { return pkg; }
		}
		#endregion

		
		

		protected void ClearScreen()
		{
			label5.Visible = Helper.WindowsRegistry.HiddenMode;
			lbVer.Visible = Helper.WindowsRegistry.HiddenMode;
			if (this.CatalogDescription!=null) 
			{
				ctss.ChangedData -= new SimPe.Events.PackedFileChanged(ctss_ChangedUserData);
				ctss = null;
			}
			pb.Image = defimg;
			this.lbAbout.Text = "";
			this.lbName.Text = "";
			this.lbPop.Text = "???";
			this.lbUni.Text = "???";
			this.llEdit.Enabled = false;
		}

		public void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{			
			loaded = false;
			ClearScreen();
			this.pkg = pkg;
			if (pkg==null) return;
			if (!Helper.IsNeighborhoodFile(pkg.FileName)) return;
			loaded = true;
			
			
			
			try 
			{
				SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
				if (strs!=null) 
				{				
					this.llEdit.Enabled = true;
					if (strs.Count>0) this.lbName.Text = strs[0].Title;
					if (strs.Count>1) this.lbAbout.Text = strs[1].Title;
				} 
			

				string tname = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(pkg.FileName), System.IO.Path.GetFileNameWithoutExtension(pkg.FileName)+".png");
				pb.Image = null;
				if (System.IO.File.Exists(tname)) 
				{
					try 
					{
						pb.Image = ObjectPreview.GenerateImage(pb.Size, Image.FromFile(tname), false);
					} 
					catch {}
				}

				if (pb.Image == null) pb.Image = defimg;
				lbPop.Text = pkg.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE).Length.ToString();
				if (pkg.FileName!=null) 
				{
					lbUni.Text = System.IO.Directory.GetFiles(System.IO.Path.GetDirectoryName(pkg.FileName), "N*_University*.package").Length.ToString();
				}
				else lbUni.Text = "0";

				ShowVersion();
			} 
			catch (Exception ex)
			{
				this.lbAbout.Text = ex.Message;
			}
		}		

		Interfaces.Files.IPackedFileDescriptor ctss;
		protected Interfaces.Files.IPackedFileDescriptor CatalogDescription
		{
			get 
			{
				if (pkg==null) return null;
				if (ctss==null) ctss = pkg.FindFile(Data.MetaData.CTSS_FILE, 0, Data.MetaData.LOCAL_GROUP, 1);
				return ctss;
			}
		}

		protected void ShowVersion()
		{
			SimPe.Plugin.Idno idno = SimPe.Plugin.Idno.FromPackage(pkg);
			if (idno!=null) 
			{
				this.lbVer.Text = idno.Version.ToString().Replace("_", " ");
				this.lbType.Text = idno.Type.ToString().Replace("_", " ");
			} 
			else 
			{
				this.lbVer.Text = SimPe.Plugin.NeighborhoodVersion.Unknown.ToString();
				this.lbType.Text = SimPe.Plugin.NeighborhoodType.Unknown.ToString();
			}
		}
		protected SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
		{
			//Get the Name of the Object
			Interfaces.Files.IPackedFileDescriptor ctss = CatalogDescription;
			if (ctss!= null) 
			{
				ctss.ChangedData += new SimPe.Events.PackedFileChanged(ctss_ChangedUserData);
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(ctss, pkg);

				return str.LanguageItems(Helper.WindowsRegistry.LanguageCode);
				
			} 
			return null;
		}

		Image defimg;
		protected void BuildDefaultImage()
		{
			defimg = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Tool.Dockable.demo.png"));
		}

		private void llEdit_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Interfaces.Files.IPackedFileDescriptor ctss = CatalogDescription;
			if (ctss!= null) 			
				SimPe.RemoteControl.OpenPackedFile(ctss, pkg);			
		}

		private void ctss_ChangedUserData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
		{
			SetFromPackage(this.pkg);
		}
	}
}
