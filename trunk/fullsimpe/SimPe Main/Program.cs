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
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using SimPe.Events;
using Ambertation.Windows.Forms;

namespace SimPe
{
    partial class MainForm
    {
        public static MainForm Global;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (System.Environment.Version.Major < 2)
            {
                Message.Show(SimPe.Localization.GetString("NoDotNet").Replace("{VERSION}", System.Environment.Version.ToString()));
                return;
            }

            List<string> argv = new List<string>(args);
            if (Commandline.PreSplash(argv)) return;

            Commandline.CheckFiles();
            //if (!Commandline.ImportOldData()) return;

            try
            {
                SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Starting SimPE..."));

                Application.DoEvents();
                Application.Idle += new EventHandler(Application_Idle);

                Helper.WindowsRegistry.UpdateSimPEDirectory();
                Global = new MainForm();
                if (!Commandline.FullEnvStart(argv))
                {
                    //load Files passed on the commandline
                    SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Load or Import Files"));
                    Global.package.LoadOrImportFiles(argv.ToArray(), true);
                    Application.Run(Global);
                }


                Helper.WindowsRegistry.Flush();
                Helper.WindowsRegistry.Layout.Flush();
                //ExpansionLoader.Global.Flush(); SimPE should not edit this File!

            }
#if !DEBUG
            catch (Exception ex)
            {
                try
                {
                    SimPe.Splash.Screen.Stop();
                    Helper.ExceptionMessage("SimPE will shutdown due to an unhandled Exception.", ex);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show("SimPE will shutdown due to an unhandled Exception.\n\nMessage: " + ex2.Message);
                }
            }
#endif
            finally
            {
                if (SimPe.Splash.Running) SimPe.Splash.Screen.ShutDown();
            }

            try
            {
                SimPe.Packages.StreamFactory.UnlockAll();
                SimPe.Packages.StreamFactory.CloseAll(true);
                SimPe.Packages.StreamFactory.CleanupTeleport();
            }
            catch { }
        }
    }
}
