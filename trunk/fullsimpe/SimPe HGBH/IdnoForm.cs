using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für IdnoForm.
	/// </summary>
	public class IdnoForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public IdnoForm()
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
			this.pnidno = new System.Windows.Forms.Panel();
			this.llunique = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.label5 = new System.Windows.Forms.Label();
			this.tbversion = new System.Windows.Forms.TextBox();
			this.tbsubname = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.tbid = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.visualStyleProvider1 = new Skybound.VisualStyles.VisualStyleProvider();
			this.lbVer = new System.Windows.Forms.Label();
			this.pnidno.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnidno
			// 
			this.pnidno.AutoScroll = true;
			this.pnidno.Controls.Add(this.lbVer);
			this.pnidno.Controls.Add(this.llunique);
			this.pnidno.Controls.Add(this.label5);
			this.pnidno.Controls.Add(this.tbversion);
			this.pnidno.Controls.Add(this.tbsubname);
			this.pnidno.Controls.Add(this.tbname);
			this.pnidno.Controls.Add(this.tbid);
			this.pnidno.Controls.Add(this.label4);
			this.pnidno.Controls.Add(this.label3);
			this.pnidno.Controls.Add(this.label2);
			this.pnidno.Controls.Add(this.tbtype);
			this.pnidno.Controls.Add(this.cbtype);
			this.pnidno.Controls.Add(this.label1);
			this.pnidno.Controls.Add(this.button1);
			this.pnidno.Controls.Add(this.panel2);
			this.pnidno.Location = new System.Drawing.Point(6, 20);
			this.pnidno.Name = "pnidno";
			this.pnidno.Size = new System.Drawing.Size(652, 232);
			this.pnidno.TabIndex = 21;
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnidno, true);
			// 
			// llunique
			// 
			this.llunique.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llunique.Location = new System.Drawing.Point(208, 88);
			this.llunique.Name = "llunique";
			this.llunique.Size = new System.Drawing.Size(88, 23);
			this.llunique.TabIndex = 28;
			this.llunique.TabStop = true;
			this.llunique.Text = "make unique";
			this.llunique.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.llunique.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MakeUnique);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(16, 112);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(133, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "(parent) Name:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label5, true);
			// 
			// tbversion
			// 
			this.tbversion.Location = new System.Drawing.Point(160, 40);
			this.tbversion.Name = "tbversion";
			this.tbversion.ReadOnly = true;
			this.tbversion.Size = new System.Drawing.Size(88, 21);
			this.tbversion.TabIndex = 26;
			this.tbversion.Text = "0x00000000";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbversion, true);
			// 
			// tbsubname
			// 
			this.tbsubname.Location = new System.Drawing.Point(160, 168);
			this.tbsubname.Name = "tbsubname";
			this.tbsubname.Size = new System.Drawing.Size(88, 21);
			this.tbsubname.TabIndex = 25;
			this.tbsubname.Text = "U000";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsubname, true);
			this.tbsubname.TextChanged += new System.EventHandler(this.Change);
			// 
			// tbname
			// 
			this.tbname.Location = new System.Drawing.Point(160, 112);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(88, 21);
			this.tbname.TabIndex = 23;
			this.tbname.Text = "N000";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbname, true);
			this.tbname.TextChanged += new System.EventHandler(this.Change);
			// 
			// tbid
			// 
			this.tbid.Location = new System.Drawing.Point(160, 88);
			this.tbid.Name = "tbid";
			this.tbid.Size = new System.Drawing.Size(40, 21);
			this.tbid.TabIndex = 22;
			this.tbid.Text = "0";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbid, true);
			this.tbid.TextChanged += new System.EventHandler(this.Change);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(64, 176);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(88, 17);
			this.label4.TabIndex = 21;
			this.label4.Text = "Subname:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label4, true);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(16, 96);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(133, 17);
			this.label3.TabIndex = 20;
			this.label3.Text = "UID:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label3, true);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 17);
			this.label2.TabIndex = 19;
			this.label2.Text = "Version:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label2, true);
			// 
			// tbtype
			// 
			this.tbtype.Location = new System.Drawing.Point(360, 144);
			this.tbtype.Name = "tbtype";
			this.tbtype.ReadOnly = true;
			this.tbtype.Size = new System.Drawing.Size(88, 21);
			this.tbtype.TabIndex = 18;
			this.tbtype.Text = "0x00000000";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbtype, true);
			// 
			// cbtype
			// 
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Location = new System.Drawing.Point(160, 144);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(192, 21);
			this.cbtype.TabIndex = 17;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.SelectType);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Neighborhood Type:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.visualStyleProvider1.SetVisualStyleSupport(this.label1, true);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(565, 199);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Commit";
			this.visualStyleProvider1.SetVisualStyleSupport(this.button1, false);
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.label27);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(652, 24);
			this.panel2.TabIndex = 0;
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel2, true);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(184, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Neighborhood ID Editor";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label27, true);
			// 
			// lbVer
			// 
			this.lbVer.Location = new System.Drawing.Point(256, 40);
			this.lbVer.Name = "lbVer";
			this.lbVer.Size = new System.Drawing.Size(176, 23);
			this.lbVer.TabIndex = 29;
			this.lbVer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.visualStyleProvider1.SetVisualStyleSupport(this.lbVer, true);
			// 
			// IdnoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(664, 273);
			this.Controls.Add(this.pnidno);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "IdnoForm";
			this.Text = "IdnoForm";
			this.pnidno.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.Panel pnidno;
		internal System.Windows.Forms.TextBox tbtype;
		internal System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private Skybound.VisualStyles.VisualStyleProvider visualStyleProvider1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		internal System.Windows.Forms.TextBox tbid;
		internal System.Windows.Forms.TextBox tbname;
		internal System.Windows.Forms.TextBox tbsubname;
		internal System.Windows.Forms.TextBox tbversion;
		private System.Windows.Forms.Label label5;
		private Skybound.VisualStyles.VisualStyleLinkLabel llunique;
		internal System.Windows.Forms.Label lbVer;

		internal Idno wrapper;

		private void SelectType(object sender, System.EventArgs e)
		{
			if (cbtype.SelectedIndex<0) return;

			NeighborhoodType nt = (NeighborhoodType)cbtype.Items[cbtype.SelectedIndex];
			if (nt!=NeighborhoodType.Unknown) this.tbtype.Text = "0x"+Helper.HexString((uint)nt);

			tbsubname.Enabled = (nt==NeighborhoodType.University);

			if (this.Tag!=null) return;
			wrapper.Type = nt;
			wrapper.Changed = true;
		}

		private void MakeUnique(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				wrapper.MakeUnique();
				this.tbid.Text = wrapper.Uid.ToString();
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Change(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			try 
			{
				wrapper.OwnerName = tbname.Text;
				wrapper.SubName = tbsubname.Text;
				wrapper.Changed = true;
				wrapper.Uid = Convert.ToUInt32(tbid.Text);
			} 
			catch  (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			wrapper.SynchronizeUserData();
		}				
	}
}
