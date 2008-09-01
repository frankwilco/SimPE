using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für ExceptionForm.
	/// </summary>
	public class ExceptionForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Label lberr;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.LinkLabel lldetail;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbdetail;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.TextBox tbsup;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExceptionForm()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExceptionForm));
            this.lberr = new System.Windows.Forms.Label();
            this.gbdetail = new System.Windows.Forms.GroupBox();
            this.rtb = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lldetail = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tbsup = new System.Windows.Forms.TextBox();
            this.gbdetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lberr
            // 
            resources.ApplyResources(this.lberr, "lberr");
            this.lberr.BackColor = System.Drawing.Color.Transparent;
            this.lberr.ForeColor = System.Drawing.Color.Black;
            this.lberr.Name = "lberr";
            // 
            // gbdetail
            // 
            resources.ApplyResources(this.gbdetail, "gbdetail");
            this.gbdetail.Controls.Add(this.rtb);
            this.gbdetail.Controls.Add(this.linkLabel1);
            this.gbdetail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbdetail.Name = "gbdetail";
            this.gbdetail.TabStop = false;
            // 
            // rtb
            // 
            resources.ApplyResources(this.rtb, "rtb");
            this.rtb.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rtb.Name = "rtb";
            this.rtb.ReadOnly = true;
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CopyToClipboard);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // lldetail
            // 
            resources.ApplyResources(this.lldetail, "lldetail");
            this.lldetail.Name = "lldetail";
            this.lldetail.TabStop = true;
            this.lldetail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowDetail);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lberr);
            this.panel1.Controls.Add(this.lldetail);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabel2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.tbsup);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // linkLabel2
            // 
            resources.ApplyResources(this.linkLabel2, "linkLabel2");
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.TabStop = true;
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Support);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbsup
            // 
            resources.ApplyResources(this.tbsup, "tbsup");
            this.tbsup.Name = "tbsup";
            // 
            // ExceptionForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbdetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ExceptionForm";
            this.gbdetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Show an Exception Message
		/// </summary>
		/// <param name="ex">The Exception that as thrown</param>
		public static void Execute(Exception ex) 
		{
			Execute(ex.Message, ex);
		}

		private void Support(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				System.Windows.Forms.Help.ShowHelp(this, this.tbsup.Text);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

        [STAThread]
		private void CopyToClipboard(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
#if MAC
#else            
			Clipboard.SetDataObject(rtb.Text, true);            
#endif
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		private void ShowDetail(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lldetail.Visible = false;
			gbdetail.Visible = true;
			Height += gbdetail.Height;
		}

		/// <summary>
		/// Show an Exception Message
		/// </summary>
		/// <param name="message">The Message you want to display</param>
		/// <param name="ex">The Exception that as thrown</param>
		public static void Execute(string message, Exception ex) 
		{
            if (Helper.NoErrors) return;

			if (message==null) message = "";
			if (message.Trim()=="") message = ex.Message;

            if (message.Contains("Microsoft.DirectX"))
            {
                ex = new Warning("You need to installe MANAGED DirectX", "In order to perfrom some Operations, you need to install Managed DirectX (which is an additional set of libraries for the DirectX you installed with The Sims 2).\n\nPlease read http://ambertation.de/simpeforum/sims2/I-have-an-Error-mentioning-Direct3D,-what-should-I-do for more Details.", ex);
                message = ex.Message;
            }

			Exception myex = ex;
			string extrace = "";
			while (myex!=null) 
			{
				extrace += myex.ToString()/*+": "+myex.Message*/+Helper.lbr;
				myex = myex.InnerException;
			}
#if MAC
			MessageBox.Show(message+"\n\n"+extrace+"\n\n"+myex);
			return;
#endif

			ExceptionForm frm = new ExceptionForm();

			frm.lberr.Text= message.Trim();

			string text = "";
			text += @"{\rtf1\ansi\ansicpg1252\deff0\deflang1031{\fonttbl{\f0\fswiss\fprq2\fcharset0 Verdana;}}";
			text += @"{\colortbl ;\red90\green90\blue90;}";
			if (ex.GetType()==typeof(Warning)) 
			{
				frm.Text = "Warning";
				frm.lberr.Text = "Warning: "+frm.lberr.Text;
				frm.linkLabel2.Visible = false;
				text += @"\viewkind4\uc1\pard\cf1\b\f0\fs16 This is just a Warning. It is supposed to keep you informed about a Problem. Most of the time this is not a Bug!\b0\par";				
				text += @"\pard\par";
				text += @"\pard\li284 "+((Warning)ex).Details.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par" ;
			} 
#if DEBUG
#else		
			else 
#endif
			{				
				text += @"\viewkind4\uc1\pard\cf1\b\f0\fs16 Message:\b0\par";
				text += @"\pard\li284 "+message.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par" ;
			

				try 
				{
					text += @"\pard\par";
					text += @"\b SimPE Version:\par";
					text += @"\pard\li284\b0 "+Helper.StartedGui.ToString()+" ("+Helper.SimPeVersion.ProductMajorPart.ToString()+"."+Helper.SimPeVersion.ProductMinorPart.ToString()+"."+Helper.SimPeVersion.ProductBuildPart.ToString()+"."+Helper.SimPeVersion.ProductPrivatePart.ToString()+")."+@"\par";
				} 
				catch {}

				text += @"\pard\par";
				text += @"\b Exception Stack:\par";
				text += @"\pard\li284\b0 "+extrace.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
		

				if (ex.Source!=null) 
				{
					text += @"\pard\par";
					text += @"\b Source:\par";
					text += @"\pard\li284\b0 "+ex.Source.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
				}
			
				if (ex.StackTrace!=null) 
				{
					text += @"\pard\par";
					text += @"\b Execution Stack:\par";
					text += @"\pard\li284\b0 "+ex.StackTrace.Trim().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284")+@"\par";
				}
			}

            try
            {
                text += @"\pard\par";
                text += @"\b Windows Version:\par";
                text += @"\pard\li284\b0 " + Ambertation.Windows.Forms.APIHelp.GetVersionEx() + @"\par";
            }
            catch { }

            try
            {
                text += @"\pard\par";
                text += @"\b .NET Version:\par";
                text += @"\pard\li284\b0 " + System.Environment.Version.ToString().Replace("\\", "\\\\").Replace("\n", @"\par\pard\li284") + @"\par";
            }
            catch { }

           

			text += @"}";

			text = text.Replace("\n", @"\par\pard");
#if MAC
#else
			frm.rtb.Rtf = text;
#endif

			if ((Helper.WindowsRegistry.HiddenMode) || (Helper.DebugMode))
			{
				frm.lldetail.Visible = false;
			} 
			else 
			{
				frm.gbdetail.Visible = false;
				frm.Height -= frm.gbdetail.Height;
			}

			
			frm.ShowDialog();
		}
	}
}
