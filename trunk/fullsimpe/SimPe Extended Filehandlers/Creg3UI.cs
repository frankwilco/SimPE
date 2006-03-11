using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für Creg3UI.
	/// </summary>
	internal class Creg3UI : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Creg3UI()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			// TODO: Initialisierungen nach dem Aufruf von InitializeComponent hinzufügen

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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbGuid = new System.Windows.Forms.TextBox();
			this.tbCrc = new System.Windows.Forms.TextBox();
			this.tbVer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.TabIndex = 0;
			this.label1.Text = "GUID:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(8, 40);
			this.label2.Name = "label2";
			this.label2.TabIndex = 1;
			this.label2.Text = "CRC:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 72);
			this.label3.Name = "label3";
			this.label3.TabIndex = 2;
			this.label3.Text = "Version:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbGuid
			// 
			this.tbGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbGuid.Location = new System.Drawing.Point(112, 8);
			this.tbGuid.Name = "tbGuid";
			this.tbGuid.ReadOnly = true;
			this.tbGuid.Size = new System.Drawing.Size(288, 21);
			this.tbGuid.TabIndex = 3;
			this.tbGuid.Text = "";
			this.tbGuid.TextChanged += new System.EventHandler(this.tbGuid_TextChanged);
			// 
			// tbCrc
			// 
			this.tbCrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbCrc.Location = new System.Drawing.Point(112, 40);
			this.tbCrc.Name = "tbCrc";
			this.tbCrc.ReadOnly = true;
			this.tbCrc.Size = new System.Drawing.Size(288, 21);
			this.tbCrc.TabIndex = 4;
			this.tbCrc.Text = "";
			this.tbCrc.TextChanged += new System.EventHandler(this.tbCrc_TextChanged);
			// 
			// tbVer
			// 
			this.tbVer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbVer.Location = new System.Drawing.Point(112, 72);
			this.tbVer.Name = "tbVer";
			this.tbVer.Size = new System.Drawing.Size(288, 21);
			this.tbVer.TabIndex = 5;
			this.tbVer.Text = "";
			this.tbVer.TextChanged += new System.EventHandler(this.tbVer_TextChanged);
			// 
			// Creg3UI
			// 
			this.Controls.Add(this.tbVer);
			this.Controls.Add(this.tbCrc);
			this.Controls.Add(this.tbGuid);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "Creg3UI";
			this.Size = new System.Drawing.Size(408, 104);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbGuid;
		private System.Windows.Forms.TextBox tbCrc;
		private System.Windows.Forms.TextBox tbVer;

		Creg3 creg;
		public Creg3 Creg
		{
			get {return  creg;}
			set 
			{
				creg = value;
				SetContent();
			}
		}

		bool intern;
		void SetContent()
		{
			if (intern) return;
			intern = true;
			if (creg==null)
			{
				tbGuid.Text = "";
				tbCrc.Text = "";
				tbVer.Text = "";
			} 
			else 
			{
				tbGuid.Text = creg.Guid.ToString();
				tbCrc.Text = creg.Crc.ToString();
				tbVer.Text = creg.Version.ToString();
			}
			intern = false;
		}

		private void tbCrc_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (creg==null) return;

			creg.Guid = new System.Guid(tbGuid.Text);
		}

		private void tbGuid_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (creg==null) return;
		
			creg.Crc = new System.Guid(tbCrc.Text);
		}

		private void tbVer_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (creg==null) return;

			creg.Version = Helper.StringToInt32(tbVer.Text, creg.Version, 10);
		}
	}
}
