namespace SimPe.Plugin.UI.Controls
{
	partial class WarningPanel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pbIcon = new System.Windows.Forms.PictureBox();
			this.btCancel = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.btOK = new System.Windows.Forms.Button();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.lbQuestion = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbIcon
			// 
			this.pbIcon.Image = global::SimPe.Plugin.Properties.Resources.WarningIcon;
			this.pbIcon.Location = new System.Drawing.Point(3, 32);
			this.pbIcon.Name = "pbIcon";
			this.pbIcon.Size = new System.Drawing.Size(62, 54);
			this.pbIcon.TabIndex = 0;
			this.pbIcon.TabStop = false;
			// 
			// btCancel
			// 
			this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btCancel.AutoSize = true;
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Location = new System.Drawing.Point(186, 198);
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size(87, 24);
			this.btCancel.TabIndex = 1;
			this.btCancel.Text = "Cancel";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.tbDescription);
			this.panel1.Location = new System.Drawing.Point(71, 27);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(305, 135);
			this.panel1.TabIndex = 2;
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(70, 8);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(306, 16);
			this.lbTitle.TabIndex = 3;
			this.lbTitle.Text = "Warning!";
			// 
			// btOK
			// 
			this.btOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btOK.Location = new System.Drawing.Point(106, 198);
			this.btOK.Name = "btOK";
			this.btOK.Size = new System.Drawing.Size(75, 24);
			this.btOK.TabIndex = 4;
			this.btOK.Text = "OK";
			this.btOK.UseVisualStyleBackColor = true;
			// 
			// tbDescription
			// 
			this.tbDescription.BackColor = System.Drawing.SystemColors.Window;
			this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbDescription.Location = new System.Drawing.Point(0, 0);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.ReadOnly = true;
			this.tbDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDescription.Size = new System.Drawing.Size(305, 135);
			this.tbDescription.TabIndex = 0;
			this.tbDescription.WordWrap = false;
			// 
			// lbQuestion
			// 
			this.lbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.lbQuestion.Location = new System.Drawing.Point(68, 165);
			this.lbQuestion.Name = "lbQuestion";
			this.lbQuestion.Size = new System.Drawing.Size(308, 30);
			this.lbQuestion.TabIndex = 5;
			// 
			// WarningPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.lbQuestion);
			this.Controls.Add(this.btOK);
			this.Controls.Add(this.lbTitle);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btCancel);
			this.Controls.Add(this.pbIcon);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "WarningPanel";
			this.Size = new System.Drawing.Size(379, 227);
			((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbIcon;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Button btOK;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label lbQuestion;
	}
}
