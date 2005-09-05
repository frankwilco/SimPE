using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Component to display Details about a passed Object
	/// </summary>
	public class ObjectPreview : System.Windows.Forms.UserControl
	{
		/// <summary>
		/// Known Expansions
		/// </summary>
		public enum Expansion : ushort
		{
			Unknown = 0xFF,			
			Original = 0x02,
			University = 0x04,
			Nightlife = 0x08,
			Custom = 0x01
		}

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbPrice;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Label lbAbout;
		private TD.SandBar.FlatComboBox cbCat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbExpansion;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ObjectPreview()
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
			loadimg = true;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ObjectPreview));
			this.pb = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.lbPrice = new System.Windows.Forms.Label();
			this.lbAbout = new System.Windows.Forms.Label();
			this.cbCat = new TD.SandBar.FlatComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbExpansion = new System.Windows.Forms.Label();
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
			// lbPrice
			// 
			this.lbPrice.AccessibleDescription = resources.GetString("lbPrice.AccessibleDescription");
			this.lbPrice.AccessibleName = resources.GetString("lbPrice.AccessibleName");
			this.lbPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbPrice.Anchor")));
			this.lbPrice.AutoSize = ((bool)(resources.GetObject("lbPrice.AutoSize")));
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
			// cbCat
			// 
			this.cbCat.AccessibleDescription = resources.GetString("cbCat.AccessibleDescription");
			this.cbCat.AccessibleName = resources.GetString("cbCat.AccessibleName");
			this.cbCat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbCat.Anchor")));
			this.cbCat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbCat.BackgroundImage")));
			this.cbCat.DefaultText = resources.GetString("cbCat.DefaultText");
			this.cbCat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbCat.Dock")));
			this.cbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCat.Enabled = ((bool)(resources.GetObject("cbCat.Enabled")));
			this.cbCat.Font = ((System.Drawing.Font)(resources.GetObject("cbCat.Font")));
			this.cbCat.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbCat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbCat.ImeMode")));
			this.cbCat.IntegralHeight = ((bool)(resources.GetObject("cbCat.IntegralHeight")));
			this.cbCat.ItemHeight = ((int)(resources.GetObject("cbCat.ItemHeight")));
			this.cbCat.Location = ((System.Drawing.Point)(resources.GetObject("cbCat.Location")));
			this.cbCat.MaxDropDownItems = ((int)(resources.GetObject("cbCat.MaxDropDownItems")));
			this.cbCat.MaxLength = ((int)(resources.GetObject("cbCat.MaxLength")));
			this.cbCat.Name = "cbCat";
			this.cbCat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbCat.RightToLeft")));
			this.cbCat.Size = ((System.Drawing.Size)(resources.GetObject("cbCat.Size")));
			this.cbCat.TabIndex = ((int)(resources.GetObject("cbCat.TabIndex")));
			this.cbCat.Text = resources.GetString("cbCat.Text");
			this.cbCat.Visible = ((bool)(resources.GetObject("cbCat.Visible")));
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
			// lbExpansion
			// 
			this.lbExpansion.AccessibleDescription = resources.GetString("lbExpansion.AccessibleDescription");
			this.lbExpansion.AccessibleName = resources.GetString("lbExpansion.AccessibleName");
			this.lbExpansion.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbExpansion.Anchor")));
			this.lbExpansion.AutoSize = ((bool)(resources.GetObject("lbExpansion.AutoSize")));
			this.lbExpansion.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbExpansion.Dock")));
			this.lbExpansion.Enabled = ((bool)(resources.GetObject("lbExpansion.Enabled")));
			this.lbExpansion.Font = ((System.Drawing.Font)(resources.GetObject("lbExpansion.Font")));
			this.lbExpansion.Image = ((System.Drawing.Image)(resources.GetObject("lbExpansion.Image")));
			this.lbExpansion.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbExpansion.ImageAlign")));
			this.lbExpansion.ImageIndex = ((int)(resources.GetObject("lbExpansion.ImageIndex")));
			this.lbExpansion.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbExpansion.ImeMode")));
			this.lbExpansion.Location = ((System.Drawing.Point)(resources.GetObject("lbExpansion.Location")));
			this.lbExpansion.Name = "lbExpansion";
			this.lbExpansion.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbExpansion.RightToLeft")));
			this.lbExpansion.Size = ((System.Drawing.Size)(resources.GetObject("lbExpansion.Size")));
			this.lbExpansion.TabIndex = ((int)(resources.GetObject("lbExpansion.TabIndex")));
			this.lbExpansion.Text = resources.GetString("lbExpansion.Text");
			this.lbExpansion.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbExpansion.TextAlign")));
			this.lbExpansion.Visible = ((bool)(resources.GetObject("lbExpansion.Visible")));
			// 
			// ObjectPreview
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.lbExpansion);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbCat);
			this.Controls.Add(this.lbAbout);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.lbPrice);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ObjectPreview";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Properties
		SimPe.PackedFiles.Wrapper.ExtObjd objd;
		[Browsable(false)]
		public SimPe.PackedFiles.Wrapper.ExtObjd SelectedObject 
		{
			get { return objd; }
			set 
			{
				if (objd!=value)
				{
					objd = value;
					UpdateScreen();
				}
			}
		}	
	
		bool loadimg;
		public bool LoadCustomImage
		{
			get { return loadimg; }
			set {loadimg = value;}
		}

		[Browsable(false)]
		public bool Loaded
		{
			get { return objd!=null; }
		}
		#endregion

		#region Thumbnails
		/// <summary>
		/// Returns the Instance Number for the assigned Thumbnail
		/// </summary>
		/// <param name="group">The Group of the Object</param>
		/// <param name="modelname">The Name of teh Model (inst 0x86)</param>
		/// <returns>Instance of the Thumbnail</returns>
		public static uint ThumbnailHash(uint group, string modelname) 
		{
			string name = group.ToString()+modelname;
			return (uint)Hashes.ToLong(Hashes.Crc32.ComputeHash(Helper.ToBytes(name.Trim().ToLower())));
		}

		static SimPe.Packages.File thumbs = null;

		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname) 
		{
			return GetThumbnail(group, modelname, null);
		}
		
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message) 
		{
			
			if (thumbs==null) 
			{
				thumbs = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Thumbnails\\ObjectThumbnails.package"));
				thumbs.Persistent = true;
			}

			Image img = GetThumbnail(group, modelname, message, thumbs);
			if (img==null) 
			{
				SimPe.Packages.File pkg =  SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Thumbnails\\BuildModeThumbnails.package"));
				img = GetThumbnail(group, modelname, message, pkg);
			}
			return img;
		}
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(uint group, string modelname, string message, SimPe.Packages.File thumbs) 
		{
			uint inst = ThumbnailHash(group, modelname);
			Image img = GetThumbnail(message, inst, thumbs);
 
			if (img==null) img = GetThumbnail(message, Hashes.GetCrc32(Hashes.StripHashFromName(modelname.Trim().ToLower())), thumbs);

			return img;
		}
		/// <summary>
		/// Returns the Thumbnail of an Object
		/// </summary>
		/// <param name="group"></param>
		/// <param name="modelname"></param>
		/// <returns>The Thumbnail</returns>
		public static Image GetThumbnail(string message, uint inst, SimPe.Packages.File thumbs) 
		{
			ArrayList types = new ArrayList();
			types.Add(0xAC2950C1); // Objects
			types.Add(0xEC3126C4); // Terrain
			/*types.Add(0xCC48C51F); //chimney
			types.Add(0x2C30E040); //fence Arch
			types.Add(0xCC30CDF8); //fences
			types.Add(0x8C311262); //floors
			types.Add(0x2C43CBD4); //foundtaion / pools
			types.Add(0xCC44B5EC); //modular Stairs
			types.Add(0xCC489E46); //roof
			types.Add(0x8C31125E); //wall*/

			foreach (uint type in types)
			{
				//0x6C2A22C3
				Interfaces.Files.IPackedFileDescriptor[] pfds = thumbs.FindFile(type, 0, inst);
				if (pfds.Length>0) 
				{
					Interfaces.Files.IPackedFileDescriptor pfd = pfds[0];
					try 
					{
						SimPe.PackedFiles.Wrapper.Picture pic = new SimPe.PackedFiles.Wrapper.Picture();
						pic.ProcessData(pfd, thumbs);
						Bitmap bm = (Bitmap)ImageLoader.Preview(pic.Image, WaitingScreen.ImageSize);
						WaitingScreen.Update(bm, message);
						return pic.Image;
					}
					catch(Exception){}
				}
			}
			return null;
		}
		#endregion

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="flname">The Filename</param>
		/// <returns>The expansion which madkes this File available (<see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansion FileFrom(string flname)
		{
			if (flname==null) flname = "";
			else flname = flname.Trim().ToLower();

			if (flname.StartsWith(Helper.WindowsRegistry.SimsPath.Trim().ToLower())) return Expansion.Original;
			if (flname.StartsWith(Helper.WindowsRegistry.SimsEP1Path.Trim().ToLower())) return Expansion.University;
			if (flname.StartsWith(System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Donwloads"))) return Expansion.Custom;
			return Expansion.Unknown;
		}

		/// <summary>
		/// Returns the Game package the File is associated with
		/// </summary>
		/// <param name="pfd">Resource Descriptor</param>
		/// <returns>The expansion which madkes this File available (according to the FileTable, <see cref="Expansion.Custom"/> marks a Custom File from the Downloads Folder)</returns>
		public static Expansion FileFrom(SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fiis = FileTable.FileIndex.FindFile(pfd, null);
			ushort min = (ushort)(Expansion.Unknown);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in fiis) 
			{
				try 
				{
					min = Math.Min((ushort)FileFrom(fii.Package.FileName), min);
				} 
				catch {}
			}
			

			return (Expansion)min;
		}

		protected void SetupCategories(string[][] catss)
		{
			cbCat.Items.Clear();
			foreach(string[] cats in catss) 
			{
				string res = "";
				foreach (string cat in cats)
				{
					if (res!="") res += " / ";
					res += cat.Trim();
				}

				if (res!="") this.cbCat.Items.Add(res);
			}

			cbCat.SelectedIndex = cbCat.Items.Count-1;
		}

		public static Image GenerateImage(Size sz, Image img, bool knockout)
		{
			if (img==null) return null;
			if (knockout) 
			{
				img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new Point(0,0), Color.Magenta);
				return Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(img, sz, 8, Color.FromArgb(90, Color.Black), Color.FromArgb(10, 10, 40), Color.White, Color.FromArgb(80, Color.White), true, 3, 3);
			} 
			else 
			{
				return Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(img, sz, 8, Color.FromArgb(90, Color.Black), SimPe.ThemeManager.Global.ThemeColorDark, Color.White, Color.FromArgb(80, Color.White), true, 3, 3);
			}
		}

		public void SetFromObjectCacheItem(SimPe.Cache.ObjectCacheItem oci)
		{
			if (oci==null) 
			{
				objd = null;
				ClearScreen();
				return;
			}

			if (oci.Tag is SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem) 
			{
				objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				if (oci.Class == SimPe.Cache.ObjectClass.Object) 
					objd.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);
				else 
				{
					SimPe.PackedFiles.Wrapper.Cpf cpf = new SimPe.PackedFiles.Wrapper.Cpf();
					cpf.ProcessData((SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem)oci.Tag);
					
					objd.FileDescriptor = cpf.FileDescriptor.Clone();
					objd.FileDescriptor.Type = 0xffffffff;
					objd.FileDescriptor.Group = cpf.GetSaveItem("stringsetgroupid").UIntegerValue;;
					objd.Package = cpf.Package;
					objd.Guid = cpf.GetSaveItem("guid").UIntegerValue;
					objd.Price = (short)cpf.GetSaveItem("cost").UIntegerValue;
					objd.FunctionSubSort = (SimPe.Data.ObjFunctionSubSort)oci.ObjectFunctionSort;
					objd.CTSSInstance = (ushort)cpf.GetSaveItem("stringsetrestypeid").UIntegerValue;
				}
			} 
			else objd = null;
		

			UpdateScreen();			
			if (oci.Thumbnail == null) pb.Image = defimg;
			else pb.Image = GenerateImage(pb.Size, oci.Thumbnail, true);
			lbName.Text = oci.Name;					
		}

		public void SetFromPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			
			if (pkg==null) 
			{
				objd = null;
				ClearScreen();
				return;
			}

			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFile(Data.MetaData.OBJD_FILE, 0, 0x41A7);
			if (pfds.Length>0) 
			{
				objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);
				objd.ProcessData(pfds[0], pkg);				
			} 

			UpdateScreen();
		}

		protected void ClearScreen()
		{
			pb.Image = defimg;
			this.lbAbout.Text = "";
			this.lbName.Text = "";
			this.lbPrice.Text = "";
			this.cbCat.Items.Clear();
		}

		public void UpdateScreen()
		{
			ClearScreen();
			if (objd==null) return;
			
			this.lbExpansion.Text = SimPe.Localization.GetString(FileFrom(objd.FileDescriptor).ToString());
			
			string[] mn = GetModelnames();			
			if (mn.Length>0) 
			{
				uint grp = objd.FileDescriptor.Group;
				/*if (grp==0xffffffff && objd.Package!=null && loadimg) 
					if (objd.Package.FileName!=null)
					{
						FileTable.FileIndex.Load();						
						SimPe.Interfaces.Wrapper.IGroupCacheItem gci = FileTable.GroupCache.GetItem(objd.Package.FileName);
						if (gci!=null) grp = gci.LocalGroup;
					}*/
				pb.Image =  GenerateImage(pb.Size, GetThumbnail(objd.FileDescriptor.Group, mn[0]), true);
			}
			else pb.Image = null;
			if (objd.FileDescriptor.Type!=0xffffffff) 
				SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, objd.FunctionSubSort, objd.Type, SimPe.Cache.ObjectClass.Object));
			else
				SetupCategories(SimPe.Cache.ObjectCacheItem.GetCategory(SimPe.Cache.ObjectCacheItemVersions.DockableOW, objd.FunctionSubSort, objd.Type, SimPe.Cache.ObjectClass.XObject));

			SimPe.PackedFiles.Wrapper.StrItemList strs = GetCtssItems();
			if (strs!=null) 
			{
				if (strs.Count>0) this.lbName.Text = strs[0].Title;
				if (strs.Count>1) this.lbAbout.Text = strs[1].Title;
			} 
			else this.lbName.Text = objd.FileName;
			
			this.lbPrice.Text = objd.Price.ToString()+" $";

			if (pb.Image == null) pb.Image = defimg;
		}

		protected string[] GetModelnames()
		{
			if (objd==null) return new string[0];
			if (objd.Package == null) return new string[0];

			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = objd.Package.FindFile(Data.MetaData.STRING_FILE, 0, objd.FileDescriptor.Group, 0x85);
			ArrayList list = new ArrayList();
			if (pfd!=null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(pfd, objd.Package);
				SimPe.PackedFiles.Wrapper.StrItemList items = str.LanguageItems(1);
				for (int i=1; i<items.Length; i++) list.Add(items[i].Title);
				
			}
			string[] refname = new string[list.Count];
			list.CopyTo(refname);

			return refname;
		}

		protected SimPe.PackedFiles.Wrapper.StrItemList GetCtssItems()
		{
			if (objd==null) return null;
			if (objd.Package == null) return null;
			if (objd.FileDescriptor == null) return null;

			//Get the Name of the Object
			Interfaces.Files.IPackedFileDescriptor ctss = objd.Package.FindFile(Data.MetaData.CTSS_FILE, 0, objd.FileDescriptor.Group, objd.CTSSInstance);
			if (ctss==null) ctss = objd.Package.FindFile(Data.MetaData.STRING_FILE, 0, objd.FileDescriptor.Group, objd.CTSSInstance);
			if (ctss!= null) 
			{
				SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
				str.ProcessData(ctss, objd.Package);

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
