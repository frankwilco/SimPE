using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für InstallerForm.
	/// </summary>
	public class InstallerForm : System.Windows.Forms.Form
	{
		private SimPe.Plugin.InstallerControl installerControl1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public InstallerForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(InstallerForm));
			this.installerControl1 = new SimPe.Plugin.InstallerControl();
			this.SuspendLayout();
			// 
			// installerControl1
			// 
			this.installerControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("installerControl1.BackgroundImage")));
			this.installerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.installerControl1.Location = new System.Drawing.Point(0, 0);
			this.installerControl1.Name = "installerControl1";
			this.installerControl1.Size = new System.Drawing.Size(624, 334);
			this.installerControl1.TabIndex = 0;
			// 
			// InstallerForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(624, 334);
			this.Controls.Add(this.installerControl1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InstallerForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Content Preview";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
