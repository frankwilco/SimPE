using SimPe.PackedFiles.UserInterface;

namespace SimPe.Plugin.UI
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.clothingEditor1 = new SimPe.PackedFiles.UserInterface.ClothingEditor();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// clothingEditor1
			// 
			this.clothingEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
									| System.Windows.Forms.AnchorStyles.Left)
									| System.Windows.Forms.AnchorStyles.Right)));
			this.clothingEditor1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.clothingEditor1.CanCommit = true;
			this.clothingEditor1.Font = new System.Drawing.Font("Tahoma", 7.071428F);
			this.clothingEditor1.Gradient = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.clothingEditor1.GradientColor = System.Drawing.SystemColors.InactiveCaption;
			this.clothingEditor1.HeadBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.clothingEditor1.HeaderText = "Clothing Editor";
			this.clothingEditor1.HeadFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.clothingEditor1.HeadForeColor = System.Drawing.Color.White;
			this.clothingEditor1.Location = new System.Drawing.Point(0, 0);
			this.clothingEditor1.Margin = new System.Windows.Forms.Padding(0);
			this.clothingEditor1.MinimumSize = new System.Drawing.Size(430, 256);
			this.clothingEditor1.Name = "clothingEditor1";
			this.clothingEditor1.Padding = new System.Windows.Forms.Padding(0, 24, 0, 0);
			this.clothingEditor1.SimPackage = null;
			this.clothingEditor1.Size = new System.Drawing.Size(506, 340);
			this.clothingEditor1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.button1.Location = new System.Drawing.Point(12, 343);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Open Sim...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(506, 377);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.clothingEditor1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.Text = "Sim Clothing Editor";
			this.ResumeLayout(false);

		}

		#endregion

		private ClothingEditor clothingEditor1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
	}
}

