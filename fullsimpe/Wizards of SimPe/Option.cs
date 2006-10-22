using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Option.
	/// </summary>
	public class Option : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pbtop;
		private System.Windows.Forms.PictureBox pbbottom;
		internal System.Windows.Forms.Panel pnopt;
		private System.Windows.Forms.PictureBox pbstretch;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Label lbmsg;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.TextBox tbsims;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		internal System.Windows.Forms.TextBox tbsave;
		private System.Windows.Forms.LinkLabel linkLabel4;
		internal System.Windows.Forms.TextBox tbdds;
		internal System.Windows.Forms.LinkLabel llsims;
		internal System.Windows.Forms.LinkLabel llsave;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.Label lldds;
		private System.Windows.Forms.LinkLabel lldds2;
		private System.Windows.Forms.OpenFileDialog ofd;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

#if MAC
		const string FONT_FAMILY = "Arial";
		const string FONT_FAMILY_SERIF = "Arial";
#else
		const string FONT_FAMILY = "Verdana";		
		const string FONT_FAMILY_SERIF = "Georgia";
#endif

        private System.Windows.Forms.LinkLabel linkLabel5;
		public Option()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Option));
			this.pbtop = new System.Windows.Forms.PictureBox();
			this.pbbottom = new System.Windows.Forms.PictureBox();
			this.pnopt = new System.Windows.Forms.Panel();
			this.lldds2 = new System.Windows.Forms.LinkLabel();
			this.lldds = new System.Windows.Forms.Label();
			this.llsave = new System.Windows.Forms.LinkLabel();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.tbdds = new System.Windows.Forms.TextBox();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.tbsave = new System.Windows.Forms.TextBox();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.tbsims = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbmsg = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.llsims = new System.Windows.Forms.LinkLabel();
			this.pbstretch = new System.Windows.Forms.PictureBox();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.linkLabel5 = new System.Windows.Forms.LinkLabel();
			this.pnopt.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbtop
			// 
			this.pbtop.BackColor = System.Drawing.Color.White;
			this.pbtop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbtop.Image = ((System.Drawing.Image)(resources.GetObject("pbtop.Image")));
			this.pbtop.Location = new System.Drawing.Point(0, 0);
			this.pbtop.Name = "pbtop";
			this.pbtop.Size = new System.Drawing.Size(610, 153);
			this.pbtop.TabIndex = 1;
			this.pbtop.TabStop = false;
			// 
			// pbbottom
			// 
			this.pbbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pbbottom.Image = ((System.Drawing.Image)(resources.GetObject("pbbottom.Image")));
			this.pbbottom.Location = new System.Drawing.Point(0, 478);
			this.pbbottom.Name = "pbbottom";
			this.pbbottom.Size = new System.Drawing.Size(610, 24);
			this.pbbottom.TabIndex = 2;
			this.pbbottom.TabStop = false;
			// 
			// pnopt
			// 
			this.pnopt.Controls.Add(this.linkLabel5);
			this.pnopt.Controls.Add(this.lldds2);
			this.pnopt.Controls.Add(this.lldds);
			this.pnopt.Controls.Add(this.llsave);
			this.pnopt.Controls.Add(this.linkLabel4);
			this.pnopt.Controls.Add(this.tbdds);
			this.pnopt.Controls.Add(this.linkLabel3);
			this.pnopt.Controls.Add(this.tbsave);
			this.pnopt.Controls.Add(this.linkLabel2);
			this.pnopt.Controls.Add(this.tbsims);
			this.pnopt.Controls.Add(this.label2);
			this.pnopt.Controls.Add(this.label1);
			this.pnopt.Controls.Add(this.lbmsg);
			this.pnopt.Controls.Add(this.linkLabel1);
			this.pnopt.Controls.Add(this.llsims);
			this.pnopt.Controls.Add(this.pbstretch);
			this.pnopt.Location = new System.Drawing.Point(0, 152);
			this.pnopt.Name = "pnopt";
			this.pnopt.Size = new System.Drawing.Size(616, 328);
			this.pnopt.TabIndex = 3;
			// 
			// lldds2
			// 
			this.lldds2.BackColor = System.Drawing.Color.White;
			this.lldds2.ForeColor = System.Drawing.Color.Gray;
			this.lldds2.LinkArea = new System.Windows.Forms.LinkArea(22, 4);
			this.lldds2.LinkColor = System.Drawing.Color.Red;
			this.lldds2.Location = new System.Drawing.Point(64, 232);
			this.lldds2.Name = "lldds2";
			this.lldds2.Size = new System.Drawing.Size(152, 23);
			this.lldds2.TabIndex = 30;
			this.lldds2.TabStop = true;
			this.lldds2.Text = "You can download them here";
			this.lldds2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkDDS);
			// 
			// lldds
			// 
			this.lldds.BackColor = System.Drawing.Color.White;
			this.lldds.ForeColor = System.Drawing.Color.Gray;
			this.lldds.Location = new System.Drawing.Point(64, 200);
			this.lldds.Name = "lldds";
			this.lldds.Size = new System.Drawing.Size(424, 32);
			this.lldds.TabIndex = 29;
			this.lldds.Text = "The Nvidia DDS Utilities were not found. You should install them in order to get " +
				"a higher quality for you recolors.";
			// 
			// llsave
			// 
			this.llsave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.llsave.AutoSize = true;
			this.llsave.BackColor = System.Drawing.Color.White;
			this.llsave.LinkColor = System.Drawing.Color.Red;
			this.llsave.Location = new System.Drawing.Point(168, 88);
			this.llsave.Name = "llsave";
			this.llsave.Size = new System.Drawing.Size(44, 16);
			this.llsave.TabIndex = 28;
			this.llsave.TabStop = true;
			this.llsave.Text = "suggest";
			this.llsave.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.llsave.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SugSave);
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.BackColor = System.Drawing.Color.White;
			this.linkLabel4.LinkColor = System.Drawing.Color.Red;
			this.linkLabel4.Location = new System.Drawing.Point(504, 177);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(42, 16);
			this.linkLabel4.TabIndex = 26;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "Browse";
			this.linkLabel4.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FldDds);
			// 
			// tbdds
			// 
			this.tbdds.Location = new System.Drawing.Point(64, 176);
			this.tbdds.Name = "tbdds";
			this.tbdds.Size = new System.Drawing.Size(432, 20);
			this.tbdds.TabIndex = 25;
			this.tbdds.Text = "";
			this.tbdds.TextChanged += new System.EventHandler(this.Change);
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.BackColor = System.Drawing.Color.White;
			this.linkLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.linkLabel3.LinkColor = System.Drawing.Color.Red;
			this.linkLabel3.Location = new System.Drawing.Point(504, 113);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(42, 16);
			this.linkLabel3.TabIndex = 24;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Browse";
			this.linkLabel3.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FldSave);
			// 
			// tbsave
			// 
			this.tbsave.Location = new System.Drawing.Point(64, 112);
			this.tbsave.Name = "tbsave";
			this.tbsave.Size = new System.Drawing.Size(432, 20);
			this.tbsave.TabIndex = 23;
			this.tbsave.Text = "";
			this.tbsave.TextChanged += new System.EventHandler(this.Change);
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = System.Drawing.Color.White;
			this.linkLabel2.LinkColor = System.Drawing.Color.Red;
			this.linkLabel2.Location = new System.Drawing.Point(504, 49);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(42, 16);
			this.linkLabel2.TabIndex = 22;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Browse";
			this.linkLabel2.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FldSims);
			// 
			// tbsims
			// 
			this.tbsims.Location = new System.Drawing.Point(64, 48);
			this.tbsims.Name = "tbsims";
			this.tbsims.Size = new System.Drawing.Size(432, 20);
			this.tbsims.TabIndex = 21;
			this.tbsims.Text = "";
			this.tbsims.TextChanged += new System.EventHandler(this.Change);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label2.Location = new System.Drawing.Point(32, 152);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Nvidia DDS Utilities:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.label1.Location = new System.Drawing.Point(32, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(134, 16);
			this.label1.TabIndex = 19;
			this.label1.Text = "Sims 2 Savegame Folder:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lbmsg
			// 
			this.lbmsg.AutoSize = true;
			this.lbmsg.BackColor = System.Drawing.Color.White;
			this.lbmsg.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.lbmsg.Location = new System.Drawing.Point(32, 24);
			this.lbmsg.Name = "lbmsg";
			this.lbmsg.Size = new System.Drawing.Size(134, 16);
			this.lbmsg.TabIndex = 18;
			this.lbmsg.Text = "Sims 2 Installation Folder:";
			this.lbmsg.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = System.Drawing.Color.White;
			this.linkLabel1.LinkColor = System.Drawing.Color.Red;
			this.linkLabel1.Location = new System.Drawing.Point(24, 313);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(33, 16);
			this.linkLabel1.TabIndex = 17;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Close";
			this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Hide);
			// 
			// llsims
			// 
			this.llsims.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.llsims.AutoSize = true;
			this.llsims.BackColor = System.Drawing.Color.White;
			this.llsims.LinkColor = System.Drawing.Color.Red;
			this.llsims.Location = new System.Drawing.Point(168, 24);
			this.llsims.Name = "llsims";
			this.llsims.Size = new System.Drawing.Size(44, 16);
			this.llsims.TabIndex = 27;
			this.llsims.TabStop = true;
			this.llsims.Text = "suggest";
			this.llsims.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.llsims.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SugSims);
			// 
			// pbstretch
			// 
			this.pbstretch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbstretch.BackgroundImage")));
			this.pbstretch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbstretch.Location = new System.Drawing.Point(0, 0);
			this.pbstretch.Name = "pbstretch";
			this.pbstretch.Size = new System.Drawing.Size(616, 328);
			this.pbstretch.TabIndex = 8;
			this.pbstretch.TabStop = false;
			// 
			// ofd
			// 
			this.ofd.Filter = "DDS Utilities (nvdxt.exe)|nvdxt.exe";
			this.ofd.Title = "Locate Nvidia DDS Tools";
			// 
			// linkLabel5
			// 
			this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel5.AutoSize = true;
			this.linkLabel5.BackColor = System.Drawing.Color.White;
			this.linkLabel5.LinkColor = System.Drawing.Color.Red;
			this.linkLabel5.Location = new System.Drawing.Point(72, 312);
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.Size = new System.Drawing.Size(67, 16);
			this.linkLabel5.TabIndex = 31;
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = "System Test";
			this.linkLabel5.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel5_LinkClicked);
			// 
			// Option
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(610, 502);
			this.Controls.Add(this.pnopt);
			this.Controls.Add(this.pbbottom);
			this.Controls.Add(this.pbtop);
			this.MaximumSize = new System.Drawing.Size(618, 800);
			this.MinimumSize = new System.Drawing.Size(618, 216);
			this.Name = "Option";
			this.Text = "Option";
			this.pnopt.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Form1 form1;
		private void Hide(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            PathProvider.SimSavegameFolder = tbsave.Text;
            PathProvider.Global[Expansions.BaseGame].InstallFolder = tbsims.Text;
            PathProvider.Global.NvidiaDDSPath = tbdds.Text;
			form1.HideOptions(sender, e);
		}

		public static bool HaveObjects
		{
            get { return System.IO.File.Exists(System.IO.Path.Combine(PathProvider.Global[Expansions.BaseGame].InstallFolder, "TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Objects" + Helper.PATH_SEP + "objects.package")); }
		}

		public static bool HaveSavefolder
		{
            get { return System.IO.Directory.Exists(System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Downloads")); }
		}

		public static bool HaveDDS
		{
            get { return System.IO.File.Exists(PathProvider.Global.NvidiaDDSTool); }
		}

		private void Change(object sender, System.EventArgs e)
		{
			llsims.Visible = !System.IO.File.Exists(System.IO.Path.Combine(tbsims.Text, "TSData"+Helper.PATH_SEP+"Res"+Helper.PATH_SEP+"Objects"+Helper.PATH_SEP+"objects.package"));;
			llsave.Visible = !System.IO.Directory.Exists(System.IO.Path.Combine(tbsave.Text, "Downloads"));	
			lldds.Visible = !System.IO.File.Exists(System.IO.Path.Combine(tbdds.Text, "nvdxt.exe"));
			lldds2.Visible = lldds.Visible;
		}

		private void SugSims(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            tbsims.Text = PathProvider.Global[Expansions.BaseGame].RealInstallFolder;
		}

		private void SugSave(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            tbsave.Text = PathProvider.RealSavegamePath;
		}

		private void FldSims(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            if (System.IO.Directory.Exists(PathProvider.Global[Expansions.BaseGame].RealInstallFolder)) fbd.SelectedPath = PathProvider.Global[Expansions.BaseGame].RealInstallFolder;
			if (fbd.ShowDialog()==DialogResult.OK) tbsims.Text = fbd.SelectedPath;
		}

		private void FldSave(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
            if (System.IO.Directory.Exists(PathProvider.RealSavegamePath)) fbd.SelectedPath = PathProvider.RealSavegamePath;
			if (fbd.ShowDialog()==DialogResult.OK) tbsave.Text = fbd.SelectedPath;
		}

		private void LinkDDS(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Help.ShowHelp(this, "http://developer.nvidia.com/object/nv_texture_tools.html");
		}

		private void FldDds(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (System.IO.File.Exists(@"C:\Program Files\NVIDIA Corporation\DDS Utilities\nvdxt.exe")) ofd.FileName = @"C:\Program Files\NVIDIA Corporation\DDS Utilities\nvdxt.exe";
			if (ofd.ShowDialog()==DialogResult.OK) tbdds.Text = System.IO.Path.GetDirectoryName(ofd.FileName);
		}

		private void linkLabel5_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			CheckForm f = new CheckForm();
			f.ShowDialog();
		}
	}
}
