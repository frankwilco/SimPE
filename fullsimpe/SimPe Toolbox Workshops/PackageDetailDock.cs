using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Summary description for DockableWindow1.
	/// </summary>
	public class dcPackageDetails : TD.SandDock.UserDockableWindow
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		protected SimPe.Plugin.Tool.Dockable.NeighborhoodPreview np;
		private SimPe.Plugin.Tool.Dockable.ObjectPreview op;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public dcPackageDetails()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);

			this.Guid = new System.Guid("272cf68e-3128-415b-a1c3-ca8f1c75a0ec");
		}

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(dcPackageDetails));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.np = new SimPe.Plugin.Tool.Dockable.NeighborhoodPreview();
			this.op = new SimPe.Plugin.Tool.Dockable.ObjectPreview();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
			this.xpGradientPanel1.Controls.Add(this.np);
			this.xpGradientPanel1.Controls.Add(this.op);
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// np
			// 
			this.np.AccessibleDescription = resources.GetString("np.AccessibleDescription");
			this.np.AccessibleName = resources.GetString("np.AccessibleName");
			this.np.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("np.Anchor")));
			this.np.AutoScroll = ((bool)(resources.GetObject("np.AutoScroll")));
			this.np.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("np.AutoScrollMargin")));
			this.np.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("np.AutoScrollMinSize")));
			this.np.BackColor = System.Drawing.Color.Transparent;
			this.np.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("np.BackgroundImage")));
			this.np.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("np.Dock")));
			this.np.Enabled = ((bool)(resources.GetObject("np.Enabled")));
			this.np.Font = ((System.Drawing.Font)(resources.GetObject("np.Font")));
			this.np.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("np.ImeMode")));
			this.np.Location = ((System.Drawing.Point)(resources.GetObject("np.Location")));
			this.np.Name = "np";
			this.np.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("np.RightToLeft")));
			this.np.Size = ((System.Drawing.Size)(resources.GetObject("np.Size")));
			this.np.TabIndex = ((int)(resources.GetObject("np.TabIndex")));
			this.np.Visible = ((bool)(resources.GetObject("np.Visible")));
			// 
			// op
			// 
			this.op.AccessibleDescription = resources.GetString("op.AccessibleDescription");
			this.op.AccessibleName = resources.GetString("op.AccessibleName");
			this.op.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("op.Anchor")));
			this.op.AutoScroll = ((bool)(resources.GetObject("op.AutoScroll")));
			this.op.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("op.AutoScrollMargin")));
			this.op.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("op.AutoScrollMinSize")));
			this.op.BackColor = System.Drawing.Color.Transparent;
			this.op.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("op.BackgroundImage")));
			this.op.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("op.Dock")));
			this.op.Enabled = ((bool)(resources.GetObject("op.Enabled")));
			this.op.Font = ((System.Drawing.Font)(resources.GetObject("op.Font")));
			this.op.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("op.ImeMode")));
			this.op.LoadCustomImage = true;
			this.op.Location = ((System.Drawing.Point)(resources.GetObject("op.Location")));
			this.op.Name = "op";
			this.op.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("op.RightToLeft")));
			this.op.SelectedObject = null;
			this.op.Size = ((System.Drawing.Size)(resources.GetObject("op.Size")));
			this.op.TabIndex = ((int)(resources.GetObject("op.TabIndex")));
			this.op.Visible = ((bool)(resources.GetObject("op.Visible")));
			// 
			// dcPackageDetails
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.xpGradientPanel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.FloatingSize = new System.Drawing.Size(280, 400);
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "dcPackageDetails";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
			this.TabText = resources.GetString("$this.TabText");
			this.Text = resources.GetString("$this.Text");
			this.ToolTipText = resources.GetString("$this.ToolTipText");
			this.VisibleChanged += new System.EventHandler(this.dcPackageDetails_VisibleChanged);
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void dcPackageDetails_VisibleChanged(object sender, System.EventArgs e)
		{
			this.op.LoadCustomImage = this.Visible;
		}

		internal void SetPackage(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			this.op.SetFromPackage(pkg);
			this.np.SetFromPackage(pkg);

			op.Visible = op.Loaded;
			np.Visible = np.Loaded;
		}
	}
}
