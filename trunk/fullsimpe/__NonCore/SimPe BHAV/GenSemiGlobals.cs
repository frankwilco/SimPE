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
using System.Collections.Generic;
using System.Text;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
    class GenSemiGlobals : ICommandLine
    {
        #region ICommandLine Members

        public bool Parse(List<string> argv)
        {
            if (!argv.Remove("-gensemiglob")) return false;

            System.Collections.Generic.List<uint> added = new System.Collections.Generic.List<uint>();
            Splash.Screen.SetMessage("Loading FileTable...");
            SimPe.FileTable.FileIndex.Load();
            Splash.Screen.SetMessage("Looking for GLOB Resources...");
            SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] resources = SimPe.FileTable.FileIndex.FindFile(SimPe.Data.MetaData.GLOB_FILE, true);

            Splash.Screen.SetMessage("Found " + resources.Length + " GLOB Resources");
            string fl = Helper.SimPeSemiGlobalFile;
//            Console.WriteLine("Opening " + fl);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fl, false);
            sw.WriteLine("<semiglobals>");

            int ct = 0;
            int unq = 0;
            foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in resources)
            {
                if (ct % 23 == 0) Splash.Screen.SetMessage("Wrote " + ct + " (" + unq + " unique) entries");
                ct++;

                SimPe.Plugin.Glob glb = new SimPe.Plugin.Glob();
                glb.ProcessData(item);

                if (!added.Contains(glb.SemiGlobalGroup))
                {
                    sw.WriteLine("  <semiglobal>");
                    sw.WriteLine("    <known />");
                    sw.WriteLine("    <group>" + Helper.HexString(glb.SemiGlobalGroup) + "</group>");
                    sw.WriteLine("    <name>" + glb.SemiGlobalName + "</name>");
                    sw.WriteLine("  </semiglobal>");
                    added.Add(glb.SemiGlobalGroup);
                    unq++;
                }
            }
//            Console.WriteLine("Wrote " + ct + " (" + unq + " unique) entries");
            sw.WriteLine("</semiglobals>");
//            Console.WriteLine("Finished writing to " + fl);
            sw.Close();
            sw.Dispose();
            sw = null;
//            Console.WriteLine("Closed File");
            Splash.Screen.SetMessage("");

            return true;
        }

        public string[] Help()
        {
            return new string[] { "-gensemiglob", null };
        }

        #endregion
    }
}
