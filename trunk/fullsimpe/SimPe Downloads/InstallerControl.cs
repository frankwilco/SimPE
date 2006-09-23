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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstallerControl));
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
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.tbs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pndrop
            // 
            this.pndrop.AllowDrop = true;
            this.pndrop.BackColor = System.Drawing.Color.Transparent;
            this.pndrop.Controls.Add(this.pb);
            resources.ApplyResources(this.pndrop, "pndrop");
            this.pndrop.Name = "pndrop";
            this.pndrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.pndrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // pb
            // 
            resources.ApplyResources(this.pb, "pb");
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // tbs
            // 
            resources.ApplyResources(this.tbs, "tbs");
            this.tbs.BackColor = System.Drawing.Color.Transparent;
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
            this.tbs.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbs.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbs.IconLocation = new System.Drawing.Point(4, 12);
            this.tbs.IconSize = new System.Drawing.Size(32, 32);
            this.tbs.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbs.Name = "tbs";
            this.tbs.RightHeaderColor = System.Drawing.Color.Transparent;
            // 
            // lbType
            // 
            this.lbType.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbType, "lbType");
            this.lbType.Name = "lbType";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbGuid
            // 
            this.lbGuid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbGuid, "lbGuid");
            this.lbGuid.Name = "lbGuid";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lbVert
            // 
            this.lbVert.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbVert, "lbVert");
            this.lbVert.Name = "lbVert";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbCat
            // 
            this.lbCat.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbCat, "lbCat");
            this.lbCat.Name = "lbCat";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // rtb
            // 
            resources.ApplyResources(this.rtb, "rtb");
            this.rtb.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            // 
            // cb
            // 
            resources.ApplyResources(this.cb, "cb");
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.Name = "cb";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.SelectedInfo);
            // 
            // lbPrice
            // 
            this.lbPrice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbPrice, "lbPrice");
            this.lbPrice.Name = "lbPrice";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lbFace
            // 
            this.lbFace.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.lbFace, "lbFace");
            this.lbFace.Name = "lbFace";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // llOptions
            // 
            this.llOptions.ActiveLinkColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.llOptions, "llOptions");
            this.llOptions.BackColor = System.Drawing.Color.Transparent;
            this.llOptions.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.llOptions.Name = "llOptions";
            this.llOptions.TabStop = true;
            this.llOptions.VisitedLinkColor = System.Drawing.Color.Silver;
            this.llOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowOptions);
            // 
            // InstallerControl
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.llOptions);
            this.Controls.Add(this.pndrop);
            this.Controls.Add(this.tbs);
            this.Name = "InstallerControl";
            this.pndrop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
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
