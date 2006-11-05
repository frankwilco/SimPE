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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ambertation.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public partial class SplashForm : TransparentForm
    {
        static Image bg;
        const uint WM_CHANGE_MESSAGE = Ambertation.Windows.Forms.APIHelp.WM_APP + 0x0001;
        const uint WM_SHOW_HIDE = Ambertation.Windows.Forms.APIHelp.WM_APP + 0x0002;
        IntPtr myhandle;

        public SplashForm()
        {
            msg = "";            
            InitializeComponent();
            this.MinimumSize = new Size(461, 212);
            this.MaximumSize = new Size(461, 212);
            myhandle = Handle;
            this.StartPosition = FormStartPosition.CenterScreen;
            lbtxt.Text = msg;
            lbver.Text = SimPe.Helper.SimPeVersion.FileMajorPart + "." + SimPe.Helper.SimPeVersion.FileMinorPart + "." + SimPe.Helper.SimPeVersion.FileBuildPart;
            
            if (Helper.DebugMode && Helper.QARelease) lbver.Text +=" [Debug, QA]";
            else if (Helper.DebugMode) lbver.Text += " [Debug]";           
            else if (Helper.QARelease) lbver.Text += " [QA]";
            
        }

        protected override void OnCreateBitmap(Graphics g, Bitmap b)
        {
            //base.OnCreateBitmap(g, b);

            if (bg == null)
            {
                bg = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.splash.png"));                
            }

            g.DrawImage(bg, new Point(0, 0));            
            g.Dispose();
        }

        string msg;
        public string Message
        {
            get { return msg; }
            set
            {
                lock (msg)
                {
                    if (msg != value)
                    {
                        if (value == null) msg = "";
                        else msg = value;                        

                        SendMessageChangeSignal();
                    }
                }
            }
        }

        protected void SendMessageChangeSignal()
        {
            Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_CHANGE_MESSAGE, 0, 0);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.HWnd == Handle)
            {
                if (m.Msg == WM_CHANGE_MESSAGE)
                {
                    this.lbtxt.Text = Message;
                }
                else if (m.Msg == WM_SHOW_HIDE)
                {
                    int i = m.WParam.ToInt32();
                    if (i == 1) this.ShowDialog();
                    else this.Close();
                }
            }
            base.WndProc(ref m);
        }

        public void StartSplash()
        {
            Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_SHOW_HIDE, 1, 0);
        }

        public void StopSplash()
        {
            Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_SHOW_HIDE, 0, 0);
        }
    }
}