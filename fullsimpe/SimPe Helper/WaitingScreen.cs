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
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace SimPe
{
    public class WaitingScreen
    {
        /// <summary>
        /// Display a new WaitingScreen image
        /// </summary>
        /// <param name="image">the Image to show</param>
        public static void UpdateImage(System.Drawing.Image image) { Screen.doUpdate(image); }
        /// <summary>
        /// The WaitingScreen image
        /// </summary>
        public static System.Drawing.Image Image { get { return scr == null ? null : scr.prevImage; } set { Screen.doUpdate(value); } }
        /// <summary>
        /// Display a new WaitingScreen message
        /// </summary>
        /// <param name="msg">The Message to show</param>
        public static void UpdateMessage(string msg) { Screen.doUpdate(msg); }
        /// <summary>
        /// The WaitingScreen message
        /// </summary>
        public static string Message { get { return scr == null ? "" : scr.prevMessage; } set { Screen.doUpdate(value); } }
        /// <summary>
        /// Display a new WaitingScreen image and message
        /// </summary>
        /// <param name="both">the MessageAndImage to show</param>
        public static void Update(System.Drawing.Image image, string msg) { Screen.doUpdate(image, msg); }
        /// <summary>
        /// Show the WaitingScreen
        /// </summary>
        public static void Wait() { Screen.doWait(); }
        /// <summary>
        /// Stop the WaitingScreen and focus the given Form
        /// </summary>
        /// <param name="form">The form to focus</param>
        public static void Stop(Form form) { Stop(); form.Activate(); }
        /// <summary>
        /// Stop the WaitingScreen
        /// </summary>
        public static void Stop() { if (Running) Screen.doStop(); }
        /// <summary>
        /// True if the WaitingScreen is displayed
        /// </summary>
        public static bool Running { get { return scr != null; } }
        /// <summary>
        /// Returns the Size of the Dispalyed Image
        /// </summary>
        public static System.Drawing.Size ImageSize { get { return new System.Drawing.Size(64, 64); } }


        static WaitingScreen scr;
        static object lockFrm = new object();
        static object lockScr = new object();
        static WaitingScreen Screen
        {
            get
            {
                System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.getScreen");
                lock (lockScr)
                {
                    if (scr == null)
                        scr = new WaitingScreen();
                }
                return scr;
            }
        }



        System.Drawing.Image prevImage = null;
        string prevMessage = "";
        SimPe.WaitingForm frm;

        void doUpdate(System.Drawing.Image image) { System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.doUpdate(image)"); lock (lockFrm) { prevImage = image; if (frm != null) frm.SetImage(image); } Application.DoEvents(); }
        void doUpdate(string msg) { System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.doUpdate(message): " + msg); lock (lockFrm) { prevMessage = msg; if (frm != null) frm.SetMessage(msg); } Application.DoEvents(); }
        void doUpdate(System.Drawing.Image image, string msg) { doUpdate(image); doUpdate(msg); }
        void doWait() { System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.doWait()"); Application.UseWaitCursor = true; lock (lockFrm) { if (frm != null) frm.StartSplash(); } }
        void doStop() { System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.doStop()"); Application.UseWaitCursor = false; lock (lockFrm) { if (frm != null) frm.StopSplash(); } }



        private WaitingScreen()
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen..ctor()");
            if (Helper.WindowsRegistry.WaitingScreen)
            {
                lock (lockFrm)
                {
                    frm = new SimPe.WaitingForm();
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen..ctor() - created new SimPe.WaitingForm()");
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                    prevImage = frm.Image;
                    prevMessage = frm.Message;
                    doUpdate(prevImage, prevMessage);
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen..ctor() - set frm.Image and frm.Message");
                    frm.StartSplash();
                    System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen..ctor() - returned from frm.StartSplash()");
                }
            }
        }

        void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Trace.WriteLine("SimPe.WaitingScreen.frm_FormClosed(...)");
            Application.UseWaitCursor = false;
            lock (lockFrm)
            {
                frm = null;
                lock (lockScr)
                {
                    scr = null;
                }
            }
        }
    }
}
