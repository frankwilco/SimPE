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
            
            try
            {
                if (System.Environment.Version.Major < 2)
                {
                    Message.Show(SimPe.Localization.GetString("NoDotNet").Replace("{VERSION}",System.Environment.Version.ToString()));
                    return;
                }

                /*
                bool stop = false;
                System.IO.FileStream fs = null;
                while (!stop)
                {
                    try
                    {
                        string exe = SimPe.PathProvider.Global.Latest.ApplicationPath;
                        fs = new System.IO.FileStream(exe, System.IO.FileMode.Append, System.IO.FileAccess.Write);
                        stop = true;
                    }
                    catch (System.IO.IOException)
                    {
                        DialogResult dr = MessageBox.Show("SimPe cannot start yet as The Sims2(tm) is still running.",
                            "SimPe", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
                        switch (dr)
                        {
                            case DialogResult.Abort: return;
                            case DialogResult.Retry: break;
                            case DialogResult.Ignore: stop = true; break;
                        }
                    }
                    finally
                    {
                        if (fs != null)
                            fs.Close();
                        fs = null;
                    }
                }
                */

                if (Commandline.Splash(ref args, "--nosplash")) Helper.WindowsRegistry.ShowStartupSplash = false;
                if (Commandline.Splash(ref args, "--splash")) Helper.WindowsRegistry.ShowStartupSplash = true;

                SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Starting SimPE..."));
                SimPe.Splash.Screen.Start();
                /*Console.WriteLine(ExpansionLoader.Global.EPInstalled+" "+ExpansionLoader.Global.SPInstalled+" "+ExpansionLoader.Global.GameVersion);
                 return;*/

                Commandline.CheckFiles();

                //do the real Startup
                //Application.EnableVisualStyles();
                Application.DoEvents();
                Application.Idle += new EventHandler(Application_Idle);

                if (!Commandline.ImportOldData())
                {
                    SimPe.Splash.Screen.ShutDown();
                    return;
                }

                if (!Commandline.Start(ref args))
                {
                    Helper.WindowsRegistry.UpdateSimPEDirectory();
                    Global = new MainForm();
                    if (!Commandline.FullEnvStart(ref args))
                    {
                        pargs = args;
                        Application.Run(Global);
                    }
                    

                    Helper.WindowsRegistry.Flush();
                    Helper.WindowsRegistry.Layout.Flush();
                    //ExpansionLoader.Global.Flush(); SimPE should not edit this File!

                }

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
                SimPe.Splash.Screen.ShutDown();
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
