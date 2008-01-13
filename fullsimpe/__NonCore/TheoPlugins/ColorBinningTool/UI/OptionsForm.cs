using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for CategorizerOptionsForm.
	/// </summary>
	public class OptionsForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btOk;
		private System.Windows.Forms.Button btCancel;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.TabControl tabControl1;
		private bool typeSet;

		ArrayList panels = new ArrayList();

		private PackageSettings settings;

		public PackageSettings Settings
		{
			get { return this.settings; }
			set {
				this.settings = value;
				this.OnSettingsChanged();
			}
		}

		public OptionsForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			InitializeDefaultPanels();

		}


		void InitializeDefaultPanels()
		{
			this.panels.Add(new PackagePreferences());
			this.panels.Add(new OutputPreferences());
			//this.panels.Add(new ScanningPreferences(this.reg));

			foreach (PreferencesPanel p in panels)
				this.tabControl1.TabPages.Add(p);
		}

		protected void OnSettingsChanged()
		{
			if (!this.typeSet)
			{
				SimPe.Plugin.UI.PreferencesPanel customPanel = null;

				switch (this.settings.PackageType)
				{
					case RecolorType.Hairtone:
						customPanel = new SimPe.Plugin.UI.HairtonePreferences();
						ScanningPreferences sp = new ScanningPreferences();
						this.panels.Add(sp);
						this.tabControl1.TabPages.Add(sp);
						break;

					case RecolorType.Skintone:
						customPanel = new SimPe.Plugin.UI.SkintonePreferences();
						break;
/*
					case RecolorType.Skin:
						customPanel = new SimPe.Plugin.UI.ClothingPreferences();
						break;
 */
				}
		
				if (customPanel != null)
				{
					this.panels.Add(customPanel);
					this.tabControl1.TabPages.Add(customPanel);
				}

				foreach (PreferencesPanel panel in panels)
					panel.Settings = this.settings;

				this.typeSet = true;
			}


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

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(OptionsForm));
			this.btOk = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SuspendLayout();
			// 
			// btOk
			// 
			this.btOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.btOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOk.Location = ((System.Drawing.Point)(resources.GetObject("btOk.Location")));
			this.btOk.Size = ((System.Drawing.Size)(resources.GetObject("btOk.Size")));
			this.btOk.Text = resources.GetString("btOk.Text");
			this.btOk.TextAlign = ContentAlignment.MiddleCenter;
			this.btOk.Click += new System.EventHandler(this.Exit);
			// 
			// btCancel
			// 
			this.btCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = ((System.Drawing.Point)(resources.GetObject("btCancel.Location")));
			this.btCancel.Size = ((System.Drawing.Size)(resources.GetObject("btCancel.Size")));
			this.btCancel.Text = resources.GetString("btCancel.Text");
			this.btCancel.TextAlign = ContentAlignment.MiddleCenter;
			this.btCancel.Click += new System.EventHandler(this.Exit);
			// 
			// tabControl1
			// 
			this.tabControl1.Alignment = TabAlignment.Top;
			this.tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl1.Padding")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			// 
			// OptionsForm
			// 
			
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.btOk);
			
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.StartPosition = FormStartPosition.WindowsDefaultLocation;			
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.ShowInTaskbar = false;
			this.Name = "OptionsForm";			

			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Text = resources.GetString("$this.Text");
			this.ResumeLayout(false);

		}
		#endregion


		private void Exit(object sender, System.EventArgs e)
		{
			this.Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			switch (this.DialogResult)
			{
				case DialogResult.OK:
				case DialogResult.Yes:

					foreach (PreferencesPanel panel in this.panels)
						panel.OnCommitSettings();

					break;
			}

			base.OnClosing(e);
		}

	}
}
