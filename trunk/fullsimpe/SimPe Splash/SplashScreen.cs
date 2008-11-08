/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   peter@users.sf.net                                                    *
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
using System.Text;

namespace SimPe
{
    public class Splash
    {
        /// <summary>
        /// Event1: StartThread has created frm and sent SetMessage
        /// </summary>
        static System.Threading.ManualResetEvent ev1 = new System.Threading.ManualResetEvent(false);

        static Splash scr;
        static object lockObj = new object();
        public static Splash Screen
        {
            get
            {
                lock (lockObj)
                {
                    if (scr == null)
                    {
                        ev1.Reset();
                        scr = new Splash();
                        ev1.WaitOne();
                    }
                }
                return scr;
            }
        }

        public static bool Running { get { return scr != null; } }

        System.Threading.Thread t = null;
        private Splash()
        {
            mmsg = "";

            if (Helper.WindowsRegistry.ShowStartupSplash)
            {
                t = new System.Threading.Thread(new System.Threading.ThreadStart(StartThread));
                t.Start();
            }
            else
                ev1.Set();
        }

        SimPe.Windows.Forms.SplashForm frm = null;
        protected void StartThread()
        {
            frm = new SimPe.Windows.Forms.SplashForm();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frm_FormClosed);
            SetMessage(mmsg);
            ev1.Set();
            frm.StartSplash();
        }

        void frm_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            lock (lockObj)
            {
                t = null;
                frm = null;
                scr = null;
            }
        }

        string mmsg;
        public void SetMessage(string msg)
        {
            mmsg = msg;
            if (frm != null) frm.Message = msg;
        }

        public void Stop()
        {
            if (frm != null) frm.StopSplash();
        }

        public void ShutDown()
        {
            Stop();
            if (t != null) t.Join();
        }
    }
}
