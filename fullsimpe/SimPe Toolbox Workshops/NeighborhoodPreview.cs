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
			// NeighborhoodPreview
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.pb);
			this.Controls.Add(this.lbAbout);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
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
		#endregion

		
		

		protected void ClearScreen()
		{
			pb.Image = defimg;
			this.lbAbout.Text = "";
			this.lbName.Text = "";
		}

		public void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			loaded = false;
			ClearScreen();
			if (pkg==null) return;
			if (!Helper.IsNeighborhoodFile(pkg.FileName)) return;
			loaded = true;
			
			
			
			
			SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems(pkg);
			if (strs!=null) 
			{
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
		}		

		protected SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			//Get the Name of the Object
			Interfaces.Files.IPackedFileDescriptor ctss = pkg.FindFile(Data.MetaData.CTSS_FILE, 0, Data.MetaData.LOCAL_GROUP, 1);
			if (ctss!= null) 
			{
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
	}
}
