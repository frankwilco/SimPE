using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Window
{
	/// <summary>
	/// Zusammenfassung für PackageRepairForm.
	/// </summary>
	class PackageRepairForm : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		ThemeManager tm;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbPkg;
		private System.Windows.Forms.Button btBrowse;
		private Ambertation.Windows.Forms.XPTaskBoxSimple tbs;
		private System.Windows.Forms.LinkLabel llRepair;
		internal System.Windows.Forms.PropertyGrid pg;
		private System.Windows.Forms.LinkLabel llOpen;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public PackageRepairForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			tm = ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);

			Setup(null);
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
					tm.Clear();
					tm.Parent = null;
				}
				tm = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PackageRepairForm));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.tbs = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.llOpen = new System.Windows.Forms.LinkLabel();
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.llRepair = new System.Windows.Forms.LinkLabel();
			this.btBrowse = new System.Windows.Forms.Button();
			this.tbPkg = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.xpGradientPanel1.SuspendLayout();
			this.tbs.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.tbs);
			this.xpGradientPanel1.Controls.Add(this.btBrowse);
			this.xpGradientPanel1.Controls.Add(this.tbPkg);
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(506, 256);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// tbs
			// 
			this.tbs.BackColor = System.Drawing.Color.Transparent;
			this.tbs.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.tbs.BorderColor = System.Drawing.SystemColors.Window;
			this.tbs.Controls.Add(this.llOpen);
			this.tbs.Controls.Add(this.pg);
			this.tbs.Controls.Add(this.llRepair);
			this.tbs.DockPadding.Bottom = 4;
			this.tbs.DockPadding.Left = 4;
			this.tbs.DockPadding.Right = 4;
			this.tbs.DockPadding.Top = 44;
			this.tbs.HeaderFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbs.HeaderText = "";
			this.tbs.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.tbs.Icon = ((System.Drawing.Image)(resources.GetObject("tbs.Icon")));
			this.tbs.IconLocation = new System.Drawing.Point(4, 12);
			this.tbs.IconSize = new System.Drawing.Size(32, 32);
			this.tbs.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.tbs.Location = new System.Drawing.Point(8, 40);
			this.tbs.Name = "tbs";
			this.tbs.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.tbs.Size = new System.Drawing.Size(488, 208);
			this.tbs.TabIndex = 3;
			// 
			// llOpen
			// 
			this.llOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llOpen.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.llOpen.Location = new System.Drawing.Point(440, 16);
			this.llOpen.Name = "llOpen";
			this.llOpen.Size = new System.Drawing.Size(40, 23);
			this.llOpen.TabIndex = 2;
			this.llOpen.TabStop = true;
			this.llOpen.Text = "Open";
			this.llOpen.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llOpen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOpen_LinkClicked);
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.pg.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pg.CommandsBackColor = System.Drawing.SystemColors.InactiveCaption;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(8, 56);
			this.pg.Name = "pg";
			this.pg.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pg.Size = new System.Drawing.Size(472, 144);
			this.pg.TabIndex = 1;
			this.pg.Text = "Header Information";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			// 
			// llRepair
			// 
			this.llRepair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llRepair.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(192)), ((System.Byte)(255)));
			this.llRepair.Location = new System.Drawing.Point(392, 16);
			this.llRepair.Name = "llRepair";
			this.llRepair.Size = new System.Drawing.Size(48, 23);
			this.llRepair.TabIndex = 0;
			this.llRepair.TabStop = true;
			this.llRepair.Text = "Repair";
			this.llRepair.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			this.llRepair.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRepair_LinkClicked);
			// 
			// btBrowse
			// 
			this.btBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btBrowse.Location = new System.Drawing.Point(424, 16);
			this.btBrowse.Name = "btBrowse";
			this.btBrowse.TabIndex = 2;
			this.btBrowse.Text = "Browse...";
			this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
			// 
			// tbPkg
			// 
			this.tbPkg.Location = new System.Drawing.Point(80, 16);
			this.tbPkg.Name = "tbPkg";
			this.tbPkg.ReadOnly = true;
			this.tbPkg.Size = new System.Drawing.Size(336, 21);
			this.tbPkg.TabIndex = 1;
			this.tbPkg.Text = "";
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Package:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// PackageRepairForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(506, 256);
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "PackageRepairForm";
			this.Text = "Package Repair";
			this.xpGradientPanel1.ResumeLayout(false);
			this.tbs.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		SimPe.Packages.StreamItem si;
		SimPe.Packages.PackageRepair pr;
		public void Setup(string pkgname)
		{
			if (pkgname==null) pkgname="";

			this.tbPkg.Text = pkgname;
			tbs.HeaderText = System.IO.Path.GetFileNameWithoutExtension(pkgname);

			si = null;
			pr = null;
			pg.SelectedObject = null;
			llOpen.Enabled = false;
			try 
			{
				if (System.IO.File.Exists(pkgname))
					si = SimPe.Packages.StreamFactory.UseStream(pkgname, System.IO.FileAccess.ReadWrite, false);

				if (!si.FileStream.CanWrite || !si.FileStream.CanRead) 
					si= null;

				if (si!=null)
				{
					pr = new SimPe.Packages.PackageRepair(SimPe.Packages.GeneratableFile.LoadFromFile(pkgname));

					pg.SelectedObject = pr.IndexDetailsAdvanced;
					llOpen.Enabled = (pr.Package!=null);
				}
			} 
			catch {}

			llRepair.Enabled = (si!=null);
		}

		private void btBrowse_Click(object sender, System.EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = SimPe.ExtensionProvider.BuildFilterString(new SimPe.ExtensionType[] { SimPe.ExtensionType.Package, SimPe.ExtensionType.AllFiles});
			if (ofd.ShowDialog()==DialogResult.OK)
				Setup(ofd.FileName);
		}

		private void llRepair_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{					
			try 
			{
				pr.UseIndexData(pr.FindIndexOffset());
				Message.Show(SimPe.Localization.GetString("FinishedPackageRepair"));
			
				pg.SelectedObject = pr.IndexDetailsAdvanced;		
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void llOpen_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				SimPe.RemoteControl.OpenMemoryPackageFkt(pr.Package);
				Close();
			} 
			catch (Exception x)
			{
				Helper.ExceptionMessage(x);
			}
		}
	}
}
