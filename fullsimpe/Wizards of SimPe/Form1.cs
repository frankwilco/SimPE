/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox pbtop;
		private System.Windows.Forms.PictureBox pbbottom;
		private System.Windows.Forms.Panel pndrop;
		private System.Windows.Forms.PictureBox pbstretch;
		private System.Windows.Forms.Label lbmsg;
		private System.Windows.Forms.Label lbstep;
		private System.Windows.Forms.LinkLabel llnext;
		private System.Windows.Forms.LinkLabel llback;
		private System.Windows.Forms.Panel panel2;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.LinkLabel llopt;

		FormStep1 step1;
		public Form1()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			this.lbstep.ForeColor = Color.FromArgb(0x40, this.lbstep.ForeColor);
			this.lbmsg.ForeColor = Color.FromArgb(0xb0, this.lbmsg.ForeColor);

			step1 = new FormStep1();
			prevsteps.Push(step1);
			ShowStep(step1, true);

			if ((!Option.HaveObjects) || (!Option.HaveSavefolder))
			{
				MessageBox.Show("Your Path settings are invalid. Wizards of SimPE will direct you to the Options Page.\n\nYou can just click on the 'Suggest' Buttons there, to get the default Paths. If the 'Suggest' Button disapears, your Path is set correct.", "Warning");
				this.ShowOptions(null, null);
			}
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.pbtop = new System.Windows.Forms.PictureBox();
			this.pbbottom = new System.Windows.Forms.PictureBox();
			this.pndrop = new System.Windows.Forms.Panel();
			this.llopt = new System.Windows.Forms.LinkLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.llback = new System.Windows.Forms.LinkLabel();
			this.llnext = new System.Windows.Forms.LinkLabel();
			this.pbstretch = new System.Windows.Forms.PictureBox();
			this.lbmsg = new System.Windows.Forms.Label();
			this.lbstep = new System.Windows.Forms.Label();
			this.pndrop.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbtop
			// 
			this.pbtop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbtop.BackgroundImage")));
			this.pbtop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pbtop.Location = new System.Drawing.Point(0, 0);
			this.pbtop.Name = "pbtop";
			this.pbtop.Size = new System.Drawing.Size(612, 153);
			this.pbtop.TabIndex = 0;
			this.pbtop.TabStop = false;
			// 
			// pbbottom
			// 
			this.pbbottom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbbottom.BackgroundImage")));
			this.pbbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pbbottom.Location = new System.Drawing.Point(0, 480);
			this.pbbottom.Name = "pbbottom";
			this.pbbottom.Size = new System.Drawing.Size(612, 24);
			this.pbbottom.TabIndex = 1;
			this.pbbottom.TabStop = false;
			// 
			// pndrop
			// 
			this.pndrop.Controls.Add(this.llopt);
			this.pndrop.Controls.Add(this.panel2);
			this.pndrop.Controls.Add(this.llback);
			this.pndrop.Controls.Add(this.llnext);
			this.pndrop.Controls.Add(this.pbstretch);
			this.pndrop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pndrop.Location = new System.Drawing.Point(0, 153);
			this.pndrop.Name = "pndrop";
			this.pndrop.Size = new System.Drawing.Size(612, 327);
			this.pndrop.TabIndex = 4;
			// 
			// llopt
			// 
			this.llopt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.llopt.AutoSize = true;
			this.llopt.BackColor = System.Drawing.Color.White;
			this.llopt.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llopt.LinkColor = System.Drawing.Color.Red;
			this.llopt.Location = new System.Drawing.Point(24, 312);
			this.llopt.Name = "llopt";
			this.llopt.Size = new System.Drawing.Size(63, 19);
			this.llopt.TabIndex = 16;
			this.llopt.TabStop = true;
			this.llopt.Text = "Options";
			this.llopt.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.llopt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ShowOptions);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.LightGray;
			this.panel2.Location = new System.Drawing.Point(338, 309);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(232, 1);
			this.panel2.TabIndex = 15;
			// 
			// llback
			// 
			this.llback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.llback.AutoSize = true;
			this.llback.BackColor = System.Drawing.Color.White;
			this.llback.Enabled = false;
			this.llback.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llback.LinkColor = System.Drawing.Color.Red;
			this.llback.Location = new System.Drawing.Point(458, 311);
			this.llback.Name = "llback";
			this.llback.Size = new System.Drawing.Size(57, 19);
			this.llback.TabIndex = 13;
			this.llback.TabStop = true;
			this.llback.Text = "< Back";
			this.llback.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.llback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Back);
			// 
			// llnext
			// 
			this.llnext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.llnext.AutoSize = true;
			this.llnext.BackColor = System.Drawing.Color.White;
			this.llnext.Enabled = false;
			this.llnext.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llnext.LinkColor = System.Drawing.Color.Red;
			this.llnext.Location = new System.Drawing.Point(522, 311);
			this.llnext.Name = "llnext";
			this.llnext.Size = new System.Drawing.Size(56, 19);
			this.llnext.TabIndex = 12;
			this.llnext.TabStop = true;
			this.llnext.Text = "Next >";
			this.llnext.VisitedLinkColor = System.Drawing.Color.Maroon;
			this.llnext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Next);
			// 
			// pbstretch
			// 
			this.pbstretch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbstretch.BackgroundImage")));
			this.pbstretch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbstretch.Location = new System.Drawing.Point(0, 0);
			this.pbstretch.Name = "pbstretch";
			this.pbstretch.Size = new System.Drawing.Size(612, 327);
			this.pbstretch.TabIndex = 5;
			this.pbstretch.TabStop = false;
			// 
			// lbmsg
			// 
			this.lbmsg.BackColor = System.Drawing.Color.Transparent;
			this.lbmsg.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbmsg.ForeColor = System.Drawing.Color.FromArgb(((System.Byte)(64)), ((System.Byte)(64)), ((System.Byte)(64)));
			this.lbmsg.Location = new System.Drawing.Point(248, 8);
			this.lbmsg.Name = "lbmsg";
			this.lbmsg.Size = new System.Drawing.Size(264, 80);
			this.lbmsg.TabIndex = 11;
			this.lbmsg.Text = "Description";
			this.lbmsg.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lbstep
			// 
			this.lbstep.AutoSize = true;
			this.lbstep.BackColor = System.Drawing.Color.Transparent;
			this.lbstep.Font = new System.Drawing.Font("Georgia", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lbstep.ForeColor = System.Drawing.Color.White;
			this.lbstep.Location = new System.Drawing.Point(512, 4);
			this.lbstep.Name = "lbstep";
			this.lbstep.Size = new System.Drawing.Size(102, 113);
			this.lbstep.TabIndex = 10;
			this.lbstep.Text = "0";
			this.lbstep.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(102)), ((System.Byte)(153)));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(612, 504);
			this.Controls.Add(this.lbmsg);
			this.Controls.Add(this.lbstep);
			this.Controls.Add(this.pndrop);
			this.Controls.Add(this.pbtop);
			this.Controls.Add(this.pbbottom);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(618, 800);
			this.MinimumSize = new System.Drawing.Size(618, 216);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wizards of SimPE";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.Close);
			this.pndrop.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal static Form1 form1;

		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]			
		static void Main() 
		{
			form1 = new Form1();
			Application.Run(form1);
		}

		private void ExitClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Close();
		}

		#region Step Management

		Stack prevsteps = new Stack();

		/// <summary>
		/// Called upon changes in a Step Form
		/// </summary>
		/// <param name="sender">the current Wizard Step</param>
		/// <param name="autonext">true if the page wanted to go to the next Wizard Step NOW</param>
		void ContentChanged(IWizardForm sender, bool autonext) 
		{
			llnext.Enabled = sender.CanContinue;
			if (autonext) this.Next();
		}

		/// <summary>
		/// Show the Prev Step
		/// </summary>
		internal void Prev()
		{
			IWizardForm now = prevsteps.Pop();
			if (now==null) return;
			now.WizardWindow.Visible = false;

			now = prevsteps.Tail();
			if (now==null) return;

			ShowStep(now, false);
		}

		/// <summary>
		/// Show the Next Step
		/// </summary>
		internal void Next()
		{
			IWizardForm now = prevsteps.Tail();
			if (now==null) return;

			if (now.GetType().GetInterface("IWizardFinish", false) == typeof(IWizardFinish)) 
			{
				IWizardFinish wf = (IWizardFinish)now;
				wf.Finit();

				prevsteps = new Stack();
				prevsteps.Push(step1);
				ShowStep(step1, true);
			} 
			else
			{
				
				now.WizardWindow.Visible = false;

				now = now.Next;
				if (now==null) return;

				prevsteps.Push(now);
				ShowStep(now, true);
			}
		}

		Option op = new Option();
		private void ShowOptions(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{						
			op.form1 = this;
			op.Location = pndrop.Location;
			op.Size = pndrop.Size;
			op.pnopt.Parent = this;
			
			op.tbsims.Text = Helper.WindowsRegistry.SimsPath;
			op.tbsave.Text = Helper.WindowsRegistry.SimSavegameFolder;
			op.tbdds.Text = Helper.WindowsRegistry.NvidiaDDSPath;

			op.pnopt.Visible = true;
			pndrop.Visible = false;
		}

		internal void HideOptions(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{						
			pndrop.Visible = true;
			op.pnopt.Visible = false;
			
		}

		private void Close(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if ((prevsteps.Count>1)) 
			{
				e.Cancel = (MessageBox.Show("This Wizard is not finished yet.\n\nDo you want to quit anyway?", "Information", MessageBoxButtons.YesNo)!=DialogResult.Yes);
			}
		}

		/// <summary>
		/// Display a new Step
		/// </summary>
		/// <param name="step">The Step you want to Show</param>
		void ShowStep(IWizardForm step, bool init)
		{
			Panel pn = step.WizardWindow;
			//this.Height = pn.Height + 320;

			pn.Visible = false;
			pn.Parent = this.pndrop;
			pn.Dock = DockStyle.None;
			pn.Anchor = ((System.Windows.Forms.AnchorStyles)(AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom));			
			pn.BackColor = Color.White;
			pn.Left = 16;
			pn.Top = 0;
			pn.Width = pndrop.Width - 2*pn.Left;
			pn.Height = pndrop.Height - (pn.Top + llnext.Height);

			lbmsg.Text = step.WizardMessage;
			lbstep.Text = step.WizardStep.ToString();
			//lbmsg.Left = lbstep.Left - lbmsg.Width;
			lbmsg.Width = lbstep.Left - lbmsg.Left + 2;			
			
			llback.Enabled = (prevsteps.Count>1);
			if (step.GetType().GetInterface("IWizardFinish", false) == typeof(IWizardFinish)) 
			{
				llnext.Text = "Finish";
				llnext.Enabled = true;
			} 
			else 
			{
				llnext.Text = "Next >";
				llnext.Enabled = (step.Next!=null);
			}

			llnext.Enabled = llnext.Enabled & step.CanContinue;			
			llopt.Visible = (prevsteps.Count<=1);

			bool show = true;
			if (init) show = step.Init(new ChangedContent(this.ContentChanged));
			pn.Visible = show;

			lbmsg.SendToBack();
			lbstep.SendToBack();
			pbtop.SendToBack();
			pbstretch.SendToBack();
		}
		#endregion

		private void Back(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Prev();
		}

		private void Next(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Next();
		}

	}
}
