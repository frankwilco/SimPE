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

namespace SimPe.Wizards
{
	/// <summary>
	/// Zusammenfassung für FormStep1.
	/// </summary>
	public class FormStep1 : System.Windows.Forms.Form, IWizardForm
	{
		private System.Windows.Forms.Panel pnwizard;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public FormStep1()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			WizardSelector ws = new WizardSelector();

			int top = 16;
			foreach (IWizardEntry we in ws.Wizards) 
			{
				Panel pn = BuildWizardPanel(we);
				pn.Visible = true;
				pn.Top = top;

				top += pn.Height + 8;
			}

			pnwizard.Height = top;
		}

		Panel BuildWizardPanel(IWizardEntry we)
		{
			Panel pn = new Panel();
			
			pn.Parent = pnwizard;
			pn.Width = pnwizard.Width - 148;
			pn.Left = 24;
			pn.Height = 64;


			PictureBox pb = new PictureBox();
			pb.Parent = pn;
			pb.Width = 64;
			pb.Height = 64;
			pb.Left = 0;
			pb.Top = 0;
			pb.Image = we.WizardImage;
			pb.Visible = true;

			LinkLabel lb1 = new LinkLabel();
			lb1.Parent = pn;
			lb1.Left = pb.Width + 8;
			lb1.Top = 0;
			lb1.AutoSize = true;
			lb1.Text = we.WizardCaption;
			lb1.Font = new Font("Georgia", (float)10, FontStyle.Bold | FontStyle.Italic);
			lb1.LinkColor = Color.FromArgb(0xE5, 0x53, 0x00);
			lb1.Tag = we;
			lb1.LinkClicked += new LinkLabelLinkClickedEventHandler(StartWizard);
			lb1.Visible = true;
			//lb1.Enabled = we.CanContinue;

			Label lb2 = new Label();
			lb2.Parent = pn;
			lb2.AutoSize = false;
			lb2.Left = pb.Width + 8;
			lb2.Top = lb1.Top + lb1.Height;
			lb2.Width = pn.Width - lb2.Left - 16;
			lb2.Height = pn.Height - lb2.Top;
			lb2.Font = new Font("Verdana", (float)8);
			lb2.ForeColor = Color.DarkGray;
			lb2.Text = we.WizardDescription;
			lb2.Visible = true;


			return pn;
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
			this.pnwizard = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// pnwizard
			// 
			this.pnwizard.BackColor = System.Drawing.Color.White;
			this.pnwizard.Location = new System.Drawing.Point(0, 0);
			this.pnwizard.Name = "pnwizard";
			this.pnwizard.Size = new System.Drawing.Size(624, 184);
			this.pnwizard.TabIndex = 8;
			// 
			// FormStep1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(7, 16);
			this.ClientSize = new System.Drawing.Size(616, 302);
			this.Controls.Add(this.pnwizard);
			this.Font = new System.Drawing.Font("Verdana", 9.75F);
			this.MaximumSize = new System.Drawing.Size(624, 800);
			this.MinimumSize = new System.Drawing.Size(624, 0);
			this.Name = "FormStep1";
			this.Text = "FormStep1";
			this.ResumeLayout(false);

		}
		#endregion

		#region IWizardWindow Members
		public Panel WizardWindow 
		{
			get { return this.pnwizard; }
		}

		public string WizardMessage
		{
			get { return "Please select the Task you want to perform.";}
		}

		public int WizardStep 
		{
			get { return 1; }
		}

		public bool Init(ChangedContent fkt)
		{
			return true;
		}

		IWizardForm wizard;
		public IWizardForm Next
		{
			get 
			{
				return wizard;
			}
		}

		public bool CanContinue
		{
			get 
			{
				return false;
			}
		}
		#endregion

		private void StartWizard(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LinkLabel ll = (LinkLabel)sender;
			wizard = (IWizardForm)ll.Tag;

			Form1.form1.Next();
		}
	}
}
