/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   pljones@users.sf.net                                                  *
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

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für WaitingForm.
	/// </summary>
	internal class WaitingForm : Form
	{
        #region Form variables
        private Panel panel1;
        private PictureBox pb;
        private Label lbwait;
		private Label lbmsg;
        private PictureBox pbsimpe;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        #endregion

		public WaitingForm()
		{
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm..ctor()");
            //
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
			//this.TopMost = Helper.WindowsRegistry.WaitingScreenTopMost;
            myhandle = Handle;
            image = pbsimpe.Image;
            message = lbmsg.Text;

			//defimg = true;
			//cycles = 20;
			//alpha = 0xff;
			//timer1.Enabled = true;
		}

        /// <summary>
        /// Die verwendeten Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        IntPtr myhandle;
        System.Drawing.Image image = null;
        string message = "";

        const uint WM_CHANGE_MESSAGE = Ambertation.Windows.Forms.APIHelp.WM_APP + 0x0003;
        const uint WM_CHANGE_IMAGE = Ambertation.Windows.Forms.APIHelp.WM_APP + 0x0004;
        const uint WM_SHOW_HIDE = Ambertation.Windows.Forms.APIHelp.WM_APP + 0x0005;

        object lockObj = new object();

        public void SetImage(System.Drawing.Image image)
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.SetImage()");
            lock (lockObj)
            {
                if (this.image == image) return;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_CHANGE_IMAGE, 0, 0);
            }
        }

        public System.Drawing.Image Image { get { return image; } }

        public void SetMessage(string message)
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.SetMessage(): " + message);
            lock (lockObj)
            {
                if (this.message == message) return;
                this.message = message;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_CHANGE_MESSAGE, 0, 0);
            }
        }

        public string Message { get { return message; } }

        protected override void WndProc(ref Message m)
        {
            if (m.HWnd == Handle)
            {
                if (m.Msg == WM_CHANGE_MESSAGE)
                {
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.WndProc() - WM_CHANGE_MESSAGE: " + message);
                    lbmsg.Text = message;
                }
                else if (m.Msg == WM_CHANGE_IMAGE)
                {
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.WndProc() - WM_CHANGE_IMAGE");
                    pb.Image = image;
                    pb.Visible = (image != null);
                    pbsimpe.Visible = (image == null);
                }
                else if (m.Msg == WM_SHOW_HIDE)
                {
                    int i = m.WParam.ToInt32();
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.WndProc() - WM_SHOW_HIDE: " + i);
                    if (i == 1) { this.Show(); this.Focus(); }
                    else this.Hide();
                }
            }
            base.WndProc(ref m);
        }

        public void StartSplash()
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.StartSplash()");
            Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_SHOW_HIDE, 1, 0);
        }

        public void StopSplash()
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingForm.StopSplash()");
            Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_SHOW_HIDE, 0, 0);
        }


		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaitingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbmsg = new System.Windows.Forms.Label();
            this.lbwait = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.PictureBox();
            this.pbsimpe = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsimpe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbmsg);
            this.panel1.Controls.Add(this.lbwait);
            this.panel1.Controls.Add(this.pb);
            this.panel1.Controls.Add(this.pbsimpe);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // lbmsg
            // 
            this.lbmsg.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.lbmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            resources.ApplyResources(this.lbmsg, "lbmsg");
            this.lbmsg.Name = "lbmsg";
            // 
            // lbwait
            // 
            this.lbwait.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            resources.ApplyResources(this.lbwait, "lbwait");
            this.lbwait.ForeColor = System.Drawing.Color.Gray;
            this.lbwait.Name = "lbwait";
            // 
            // pb
            // 
            this.pb.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            resources.ApplyResources(this.pb, "pb");
            this.pb.Name = "pb";
            this.pb.TabStop = false;
            // 
            // pbsimpe
            // 
            this.pbsimpe.AccessibleRole = System.Windows.Forms.AccessibleRole.Graphic;
            resources.ApplyResources(this.pbsimpe, "pbsimpe");
            this.pbsimpe.Name = "pbsimpe";
            this.pbsimpe.TabStop = false;
            // 
            // WaitingForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.CausesValidation = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitingForm";
            this.ShowInTaskbar = false;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbsimpe)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

    }
}
