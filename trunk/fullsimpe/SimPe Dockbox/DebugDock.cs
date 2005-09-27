using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Summary description for DebugDock.
	/// </summary>
	public class DebugDock : TD.SandDock.UserDockableWindow, SimPe.Interfaces.IDockableTool
	{
		SimPe.ThemeManager tm;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbMem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox lbft;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DebugDock()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);

			
			this.Guid = new System.Guid("23e35c0c-6364-4d00-9e60-3e9315e8d74c");
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				tm.RemoveControl(this.xpGradientPanel1);
				tm = null;
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DebugDock));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.lbft = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbMem = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.lbft);
			this.xpGradientPanel1.Controls.Add(this.label2);
			this.xpGradientPanel1.Controls.Add(this.lbMem);
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xpGradientPanel1.Location = new System.Drawing.Point(0, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(250, 400);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// lbft
			// 
			this.lbft.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbft.Location = new System.Drawing.Point(16, 72);
			this.lbft.Name = "lbft";
			this.lbft.Size = new System.Drawing.Size(224, 316);
			this.lbft.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(128, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "FileTable Content:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// lbMem
			// 
			this.lbMem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lbMem.BackColor = System.Drawing.Color.Transparent;
			this.lbMem.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbMem.Location = new System.Drawing.Point(16, 24);
			this.lbMem.Name = "lbMem";
			this.lbMem.Size = new System.Drawing.Size(224, 23);
			this.lbMem.TabIndex = 1;
			this.lbMem.Text = "0";
			this.lbMem.Click += new System.EventHandler(this.lbMem_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "Memory Usage:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// DebugDock
			// 
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "DebugDock";
			this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
			this.TabText = "Debug";
			this.Text = "Debug Dock";
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public TD.SandDock.DockControl GetDockableControl()
		{
			return this;
		}

		public event SimPe.Events.ChangedResourceEvent ShowNewResource;

		public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs es)
		{
			lbMem.Text = GC.GetTotalMemory(false).ToString("N0") + " Byte";			
		}


		#region IToolPlugin Member

		public override string ToString()
		{
			return this.Text;
		}

		#endregion

		private void lbMem_Click(object sender, System.EventArgs e)
		{
			RefreshDock(null, null);			
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
#if DEBUG
			lbft.Items.Clear();

			SimPe.Plugin.FileIndex fi = (SimPe.Plugin.FileIndex)FileTable.FileIndex;
			ArrayList l = fi.StoredFiles;
			foreach (string s in l)
				lbft.Items.Add(s);
#endif
		}

		private void label1_Click(object sender, System.EventArgs e)
		{		
			System.IO.StreamWriter sw = System.IO.File.CreateText(@"i:\replicated.txt");			
			string objname = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, @"TSData\Res\Objects\objects.package").Trim().ToLower();
			sw.WriteLine(System.IO.Path.GetFileName(objname)+"----------------------------------------");
			SimPe.Interfaces.Files.IPackageFile pkg = SimPe.Packages.File.LoadFromFile(objname);
			FileTable.FileIndex.Load();
			lbft.Items.Clear();

			int[] ct = new int[3];
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index) 
			{
				SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(pfd, null);
			
				bool copy = false;
				if ((items.Length-1)<4) ct[(items.Length-1)]++;
				foreach(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items) 
				{
					if (item.Package.FileName.Trim().ToLower()!=objname)
						copy = true;
				}

				if (!copy) 
				{
					lbft.Items.Add(items.Length.ToString()+": "+pfd.ToString());
					sw.WriteLine(items.Length.ToString()+": "+pfd.ToString());
				}
			}
				
			lbft.Items.Add(" m: "+pkg.Index.Length.ToString());
			lbft.Items.Add(" 1: "+ct[0].ToString());
			lbft.Items.Add(" 2: "+ct[1].ToString());
			lbft.Items.Add(" 3: "+ct[2].ToString());

			sw.Close();
		}

		#region IToolExt Member

		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return this.TabImage;
			}
		}	

		public virtual bool Visible 
		{
			get { return this.IsDocked ||  this.IsFloating; }
		}

		#endregion
	}
}
