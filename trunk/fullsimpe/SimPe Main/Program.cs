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
using SimPe.Events;
using Ambertation.Windows.Forms;

namespace SimPe
{
    partial class MainForm 
    {
        static string[] pargs;
        public static MainForm Global;
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            
#if !DEBUG
            try
            {
#endif
                if (System.Environment.Version.Major < 2)
                {
                    Message.Show(SimPe.Localization.GetString("NoDotNet").Replace("{VERSION}",System.Environment.Version.ToString()));
                    return;
                }
                foreach (string arg in args)
                    if (arg == "--nosplash") Helper.WindowsRegistry.ShowStartupSplash = false;
                    else if (arg == "--splash") Helper.WindowsRegistry.ShowStartupSplash = true;

                SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Starting SimPE..."));
                SimPe.Splash.Screen.Start();
                /*Console.WriteLine(ExpansionLoader.Global.EPInstalled+" "+ExpansionLoader.Global.SPInstalled+" "+ExpansionLoader.Global.GameVersion);
                 return;*/

                Commandline.CheckFiles();

                //do the real Startup
                pargs = args;
                //Application.EnableVisualStyles();
                Application.DoEvents();
                Application.Idle += new EventHandler(Application_Idle);

                if (!Commandline.ImportOldData())
                {
                    SimPe.Splash.Screen.ShutDown();
                    return;
                }

                if (!Commandline.Start(args))
                {
                    Helper.WindowsRegistry.UpdateSimPEDirectory();
                    Global = new MainForm();
                    if (!Commandline.FullEnvStart(args)) Application.Run(Global);
                    

                    Helper.WindowsRegistry.Flush();
                    Helper.WindowsRegistry.Layout.Flush();
                    //ExpansionLoader.Global.Flush(); SimPE should not edit this File!

                }

#if !DEBUG
            }
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
            finally
            {
#endif
                SimPe.Splash.Screen.ShutDown();
#if !DEBUG
            }
#endif

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
