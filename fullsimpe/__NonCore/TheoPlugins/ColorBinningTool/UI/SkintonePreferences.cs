using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.UI
{
	/// <summary>
	/// Summary description for SkintonePreferences.
	/// </summary>
	public class SkintonePreferences : PreferencesPanel
	{
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Label label1;

		public SkintonePreferences()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
			this.Text = "Skintone";
		}

		protected override void OnSettingsChanged()
		{
			if (this.Settings is SkintoneSettings)
			{
				SkintoneSettings sset = (SkintoneSettings)this.Settings;
				this.numericUpDown1.Value = Convert.ToDecimal(sset.GeneticWeight);
			}
		}

		public override void OnCommitSettings()
		{
			if (this.Settings is SkintoneSettings)
			{
				SkintoneSettings sset = (SkintoneSettings)this.Settings;
				sset.GeneticWeight = Convert.ToSingle(this.numericUpDown1.Value);
			}			
		}


		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.DecimalPlaces = 2;
			this.numericUpDown1.Increment = 0.05M;
			this.numericUpDown1.Location = new System.Drawing.Point(8, 32);
			this.numericUpDown1.Maximum = 4M;
			this.numericUpDown1.InterceptArrowKeys = true;
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(96, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Genetic Weight";
			// 
			// SkintonePreferences
			// 
			this.Controls.Add(this.label1);
			this.Controls.Add(this.numericUpDown1);
			this.Name = "SkintonePreferences";
			this.Size = new System.Drawing.Size(136, 72);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	}
}
