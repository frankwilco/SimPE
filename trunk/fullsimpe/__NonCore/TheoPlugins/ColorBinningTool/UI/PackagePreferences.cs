using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for PackagePreferences.
	/// </summary>
	public class PackagePreferences : PreferencesPanel
	{
		private System.Windows.Forms.CheckBox cbGlobalHide;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox tbFamGuid;
		private System.Windows.Forms.LinkLabel llGuid;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label label2;

		private Guid familyGuid;

		public PackagePreferences()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.Text = "Package";
		}

		protected override void OnSettingsChanged()
		{
			if (this.Settings.FamilyGuid != Guid.Empty)
			{
				this.familyGuid = this.Settings.FamilyGuid;
				this.tbFamGuid.Text = this.familyGuid.ToString();
			}

			this.tbDescription.Text = this.Settings.Description;
			this.cbGlobalHide.Checked = this.Settings.HideFromCatalog;

		}

		public override void OnCommitSettings()
		{
			this.Settings.Description = this.tbDescription.Text;
			this.Settings.HideFromCatalog = this.cbGlobalHide.Checked;
			this.Settings.FamilyGuid = this.familyGuid;
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbGlobalHide = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tbFamGuid = new System.Windows.Forms.TextBox();
			this.llGuid = new System.Windows.Forms.LinkLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// cbGlobalHide
			// 
			this.cbGlobalHide.Location = new System.Drawing.Point(48, 96);
			this.cbGlobalHide.Name = "cbGlobalHide";
			this.cbGlobalHide.Size = new System.Drawing.Size(120, 24);
			this.cbGlobalHide.TabIndex = 15;
			this.cbGlobalHide.Text = "Hide from catalog";
			this.ToolTipControl.SetToolTip(
				this.cbGlobalHide,
				"When checked, the output packages will be flagged so that they won\'t show in the game catalog."
				);

			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tbFamGuid);
			this.panel1.Controls.Add(this.llGuid);
			this.panel1.Location = new System.Drawing.Point(8, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(360, 24);
			this.panel1.TabIndex = 13;
			// 
			// tbFamGuid
			// 
			this.tbFamGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbFamGuid.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.tbFamGuid.Location = new System.Drawing.Point(40, 0);
			this.tbFamGuid.MaxLength = 36;
			this.tbFamGuid.Name = "tbFamGuid";
			this.tbFamGuid.Size = new System.Drawing.Size(312, 20);
			this.tbFamGuid.TabIndex = 1;
			this.tbFamGuid.Text = "";
			this.tbFamGuid.Validated += new EventHandler(this.tbFamGuid_Validating);
			this.ToolTipControl.SetToolTip(this.tbFamGuid, "This will be the new family GUID on each resulting package.");
			// 
			// llGuid
			// 
			this.llGuid.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llGuid.Location = new System.Drawing.Point(0, 0);
			this.llGuid.Name = "llGuid";
			this.llGuid.Size = new System.Drawing.Size(40, 23);
			this.llGuid.TabIndex = 3;
			this.llGuid.TabStop = true;
			this.llGuid.Text = "Guid";
			this.llGuid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.llGuid.LinkClicked += new LinkLabelLinkClickedEventHandler(this.GenerateGuid);
			this.ToolTipControl.SetToolTip(this.llGuid, "Click to generate a new GUID");
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbDescription);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(8, 48);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(360, 24);
			this.panel2.TabIndex = 14;
			// 
			// tbDescription
			// 
			this.tbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbDescription.Location = new System.Drawing.Point(40, 0);
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(312, 20);
			this.tbDescription.TabIndex = 1;
			this.tbDescription.Text = "";
			this.ToolTipControl.SetToolTip(this.tbDescription, "A small title for the package that will appear in te catalog tooltip.");
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(0, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Text";
			// 
			// PackagePreferences
			// 
			this.Controls.Add(this.cbGlobalHide);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Name = "PackagePreferences";
			this.Size = new System.Drawing.Size(376, 136);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void GenerateGuid(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.familyGuid = Guid.NewGuid();
			this.tbFamGuid.Text = this.familyGuid.ToString();
		}

		private void tbFamGuid_Validating(object sender, EventArgs e)
		{
			try 
			{
				this.familyGuid = new Guid(this.tbFamGuid.Text);
				this.tbFamGuid.ForeColor = Color.Black;
			}
			catch
			{
				this.tbFamGuid.ForeColor = Color.Red;
			}

		}


	}
}
