using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für CheckItem.
	/// </summary>
	[System.ComponentModel.DefaultEvent("ClickedFix")]
	public class CheckItem : System.Windows.Forms.UserControl
	{
		public delegate CheckItemState FixEventHandler(object sender, CheckItemState isok);
		private System.Windows.Forms.LinkLabel llfix;
		private System.Windows.Forms.Label lb;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.LinkLabel lldet;
		private System.Windows.Forms.Panel pnDetails;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.RichTextBox rtb;
		private System.ComponentModel.IContainer components;

		public CheckItem()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			cs = CheckItemState.Unknown;
			txt = "--";
			cf = false;		
			det = "";
			this.pnDetails.Visible = false;
			SetContent();
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CheckItem));
			this.lb = new System.Windows.Forms.Label();
			this.llfix = new System.Windows.Forms.LinkLabel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.lldet = new System.Windows.Forms.LinkLabel();
			this.pnDetails = new System.Windows.Forms.Panel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.pnDetails.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.AccessibleDescription = resources.GetString("lb.AccessibleDescription");
			this.lb.AccessibleName = resources.GetString("lb.AccessibleName");
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lb.Anchor")));
			this.lb.AutoSize = ((bool)(resources.GetObject("lb.AutoSize")));
			this.lb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lb.Dock")));
			this.lb.Enabled = ((bool)(resources.GetObject("lb.Enabled")));
			this.lb.Font = ((System.Drawing.Font)(resources.GetObject("lb.Font")));
			this.lb.Image = ((System.Drawing.Image)(resources.GetObject("lb.Image")));
			this.lb.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lb.ImageAlign")));
			this.lb.ImageIndex = ((int)(resources.GetObject("lb.ImageIndex")));
			this.lb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lb.ImeMode")));
			this.lb.Location = ((System.Drawing.Point)(resources.GetObject("lb.Location")));
			this.lb.Name = "lb";
			this.lb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lb.RightToLeft")));
			this.lb.Size = ((System.Drawing.Size)(resources.GetObject("lb.Size")));
			this.lb.TabIndex = ((int)(resources.GetObject("lb.TabIndex")));
			this.lb.Text = resources.GetString("lb.Text");
			this.lb.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lb.TextAlign")));
			this.lb.Visible = ((bool)(resources.GetObject("lb.Visible")));
			// 
			// llfix
			// 
			this.llfix.AccessibleDescription = resources.GetString("llfix.AccessibleDescription");
			this.llfix.AccessibleName = resources.GetString("llfix.AccessibleName");
			this.llfix.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llfix.Anchor")));
			this.llfix.AutoSize = ((bool)(resources.GetObject("llfix.AutoSize")));
			this.llfix.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llfix.Dock")));
			this.llfix.Enabled = ((bool)(resources.GetObject("llfix.Enabled")));
			this.llfix.Font = ((System.Drawing.Font)(resources.GetObject("llfix.Font")));
			this.llfix.Image = ((System.Drawing.Image)(resources.GetObject("llfix.Image")));
			this.llfix.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llfix.ImageAlign")));
			this.llfix.ImageIndex = ((int)(resources.GetObject("llfix.ImageIndex")));
			this.llfix.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llfix.ImeMode")));
			this.llfix.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llfix.LinkArea")));
			this.llfix.Location = ((System.Drawing.Point)(resources.GetObject("llfix.Location")));
			this.llfix.Name = "llfix";
			this.llfix.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llfix.RightToLeft")));
			this.llfix.Size = ((System.Drawing.Size)(resources.GetObject("llfix.Size")));
			this.llfix.TabIndex = ((int)(resources.GetObject("llfix.TabIndex")));
			this.llfix.TabStop = true;
			this.llfix.Text = resources.GetString("llfix.Text");
			this.llfix.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llfix.TextAlign")));
			this.llfix.Visible = ((bool)(resources.GetObject("llfix.Visible")));
			this.llfix.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llfix_LinkClicked);
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
			// lldet
			// 
			this.lldet.AccessibleDescription = resources.GetString("lldet.AccessibleDescription");
			this.lldet.AccessibleName = resources.GetString("lldet.AccessibleName");
			this.lldet.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldet.Anchor")));
			this.lldet.AutoSize = ((bool)(resources.GetObject("lldet.AutoSize")));
			this.lldet.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldet.Dock")));
			this.lldet.Enabled = ((bool)(resources.GetObject("lldet.Enabled")));
			this.lldet.Font = ((System.Drawing.Font)(resources.GetObject("lldet.Font")));
			this.lldet.Image = ((System.Drawing.Image)(resources.GetObject("lldet.Image")));
			this.lldet.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldet.ImageAlign")));
			this.lldet.ImageIndex = ((int)(resources.GetObject("lldet.ImageIndex")));
			this.lldet.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldet.ImeMode")));
			this.lldet.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldet.LinkArea")));
			this.lldet.Location = ((System.Drawing.Point)(resources.GetObject("lldet.Location")));
			this.lldet.Name = "lldet";
			this.lldet.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldet.RightToLeft")));
			this.lldet.Size = ((System.Drawing.Size)(resources.GetObject("lldet.Size")));
			this.lldet.TabIndex = ((int)(resources.GetObject("lldet.TabIndex")));
			this.lldet.TabStop = true;
			this.lldet.Text = resources.GetString("lldet.Text");
			this.lldet.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldet.TextAlign")));
			this.lldet.Visible = ((bool)(resources.GetObject("lldet.Visible")));
			this.lldet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldet_LinkClicked);
			// 
			// pnDetails
			// 
			this.pnDetails.AccessibleDescription = resources.GetString("pnDetails.AccessibleDescription");
			this.pnDetails.AccessibleName = resources.GetString("pnDetails.AccessibleName");
			this.pnDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnDetails.Anchor")));
			this.pnDetails.AutoScroll = ((bool)(resources.GetObject("pnDetails.AutoScroll")));
			this.pnDetails.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnDetails.AutoScrollMargin")));
			this.pnDetails.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnDetails.AutoScrollMinSize")));
			this.pnDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnDetails.BackgroundImage")));
			this.pnDetails.Controls.Add(this.linkLabel1);
			this.pnDetails.Controls.Add(this.rtb);
			this.pnDetails.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnDetails.Dock")));
			this.pnDetails.Enabled = ((bool)(resources.GetObject("pnDetails.Enabled")));
			this.pnDetails.Font = ((System.Drawing.Font)(resources.GetObject("pnDetails.Font")));
			this.pnDetails.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnDetails.ImeMode")));
			this.pnDetails.Location = ((System.Drawing.Point)(resources.GetObject("pnDetails.Location")));
			this.pnDetails.Name = "pnDetails";
			this.pnDetails.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnDetails.RightToLeft")));
			this.pnDetails.Size = ((System.Drawing.Size)(resources.GetObject("pnDetails.Size")));
			this.pnDetails.TabIndex = ((int)(resources.GetObject("pnDetails.TabIndex")));
			this.pnDetails.Text = resources.GetString("pnDetails.Text");
			this.pnDetails.Visible = ((bool)(resources.GetObject("pnDetails.Visible")));
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
			this.linkLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
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
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
			this.rtb.Cursor = System.Windows.Forms.Cursors.Default;
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
			this.rtb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
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
			// CheckItem
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.pnDetails);
			this.Controls.Add(this.lb);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.llfix);
			this.Controls.Add(this.lldet);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "CheckItem";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.pnDetails.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		bool cf;
		public bool CanFix
		{
			get {return cf;}
			set 
			{
				if (cf!=value)
				{
					cf = value;
					SetContent();
				}
			}
		}

		string txt;
		[System.ComponentModel.Localizable(true)]
		public string Caption
		{
			get {return  txt;}
			set 
			{
				txt = value;
				SetContent();
			}
		}

		CheckItemState cs;
		public CheckItemState CheckState
		{
			get {return cs;}
			set {
				cs = value;
				if (cs==CheckItemState.Fail) pb.Image = CheckControl.FailImage;
				else if (cs==CheckItemState.Ok) pb.Image = CheckControl.OKImage;
				else if (cs==CheckItemState.Warning) pb.Image = CheckControl.WarnImage;
				else pb.Image = CheckControl.UnknownImage;

				SetContent();
			}
		}

		string det;
		public string Details
		{
			get {return det;}
			set 
			{
				det = value;
				SetContent();
			}
		}

		protected virtual void SetContent()
		{
			this.rtb.Text = det;
			lldet.Visible = det.Trim()!="";
			lb.Text = txt;
			this.llfix.Visible = cs==CheckItemState.Fail && cf;
			this.Refresh();
		}

		protected virtual void OnFix()
		{			
		}

		public void Reset()
		{
			this.pnDetails.Visible = false;
			this.CheckState = CheckItemState.Unknown;
			det = "";
			SetContent();
		}

		public event FixEventHandler CalledCheck;
		protected virtual CheckItemState OnCheck()
		{
			return CheckItemState.Ok;
		}

		public void Check()
		{
			CheckItemState res = OnCheck();
			if (CalledCheck!=null) res = CalledCheck(this, res);
			this.CheckState = res;
		}

		public event FixEventHandler ClickedFix;
		private void llfix_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			CheckItemState res = this.CheckState;
			OnFix();
			if (ClickedFix!=null) 			
				res = ClickedFix(this, res);
			
			this.CheckState = res;
		}

		private void lldet_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.pnDetails.Visible = true;			
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.pnDetails.Visible = false;
		}
	}
}
