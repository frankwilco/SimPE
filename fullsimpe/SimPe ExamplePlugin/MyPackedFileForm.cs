using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MyPackedFileForm.
	/// </summary>
	public class MyPackedFileForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel wrapperPanel;
		internal System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btcommit;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MyPackedFileForm()
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
			this.wrapperPanel = new System.Windows.Forms.Panel();
			this.btcommit = new System.Windows.Forms.Button();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.wrapperPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// wrapperPanel
			// 
			this.wrapperPanel.Controls.Add(this.btcommit);
			this.wrapperPanel.Controls.Add(this.rtb);
			this.wrapperPanel.Controls.Add(this.panel3);
			this.wrapperPanel.Location = new System.Drawing.Point(8, 8);
			this.wrapperPanel.Name = "wrapperPanel";
			this.wrapperPanel.Size = new System.Drawing.Size(464, 248);
			this.wrapperPanel.TabIndex = 3;
			// 
			// btcommit
			// 
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btcommit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btcommit.Location = new System.Drawing.Point(376, 216);
			this.btcommit.Name = "btcommit";
			this.btcommit.TabIndex = 2;
			this.btcommit.Text = "Commit";
			this.btcommit.Click += new System.EventHandler(this.CommitClick);
			// 
			// rtb
			// 
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.rtb.Location = new System.Drawing.Point(8, 32);
			this.rtb.Name = "rtb";
			this.rtb.Size = new System.Drawing.Size(448, 184);
			this.rtb.TabIndex = 1;
			this.rtb.Text = "";
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(464, 24);
			this.panel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(121, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Example Plugin";
			// 
			// MyPackedFileForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(480, 286);
			this.Controls.Add(this.wrapperPanel);
			this.Name = "MyPackedFileForm";
			this.Text = "MyPackedFileForm";
			this.wrapperPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Commit Handling
		/// <summary>
		/// Stores the currently active Wrapper
		/// </summary>
		internal IFileWrapperSaveExtension wrapper = null;

		/// <summary>
		/// Issued when the Commit Button was clicked
		/// </summary>
		/// <param name="sender">The Button that sended the Event</param>
		/// <param name="e">Event Parameters</param>
		private void CommitClick(object sender, System.EventArgs e)
		{
			MyPackedFileWrapper mpfw = (MyPackedFileWrapper)wrapper;
			mpfw.Data = rtb.Text;

			//this call is maed in order to commit the Data stored in the Attributes to the FIlestream
			wrapper.SynchronizeUserData();

			MessageBox.Show("Not Implemented yet!");
		}
		#endregion
	}
}
