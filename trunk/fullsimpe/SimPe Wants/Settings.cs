/***************************************************************************
 *   Copyright (C) 2005-2008 by Peter L Jones                              *
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
using System.Collections;
using System.Resources;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.ComponentModel;

namespace SimPe.Wants
{
    class Settings : SimPe.GlobalizedObject
    {
        const string BASENAME = "PJSE\\Wants";
        SimPe.XmlRegistryKey xrk = SimPe.Helper.WindowsRegistry.PluginRegistryKey;
        SimPe.XmlRegistryKey rkf = SimPe.Helper.WindowsRegistry.PluginRegistryKey.CreateSubKey(BASENAME);
        public Settings() : base(new ResourceManager(typeof(Settings))) { }

        private static Settings settings = new Settings();

        public static int[] SWAFColumns
        {
            get
            {
                object o = settings.rkf.GetValue("SWAFColumns", null);
                if (o == null || o as string == null) return null;
                try
                {
                    string[] cols = ((string)o).Split(new char[] { ',' }, 11);
                    if (cols.Length != 11) return null;
                    List<int> li = new List<int>();
                    foreach (string s in cols)
                        li.Add(Convert.ToInt32(s));
                    return li.ToArray();
                }
                catch { return null; }
            }

            set
            {
                if (value.Length != 11) throw new ArgumentOutOfRangeException();
                bool nc = true;
                int[] old = SWAFColumns;
                if (old == null) nc = false;
                else for (int i = 0; i < value.Length && nc; i++) nc = value[i] == old[i];
                if (nc) return;

                string s = value[0].ToString();
                for (int i = 1; i < value.Length; i++) s += "," + value[i].ToString();

                settings.rkf.SetValue("SWAFColumns", s);
            }
        }

        public static bool[] SWAFItemTypes
        {
            get
            {
                bool[] def = new bool[] { true, true, true, true, };
                object o = settings.rkf.GetValue("SWAFItemTypes", null);
                if (o == null || o as string == null) return def;
                try
                {
                    string[] ckbs = ((string)o).Split(new char[] { ',' }, 4);
                    if (ckbs.Length != 4) return def;
                    List<bool> li = new List<bool>();
                    foreach (string s in ckbs)
                        li.Add(Convert.ToBoolean(s));
                    return li.ToArray();
                }
                catch { return def; }
            }

            set
            {
                if (value.Length != 4) throw new ArgumentOutOfRangeException();
                bool nc = true;
                bool[] old = SWAFItemTypes;
                if (old == null) nc = false;
                else for (int i = 0; i < value.Length && nc; i++) nc = value[i] == old[i];
                if (nc) return;

                string s = value[0].ToString();
                for (int i = 1; i < value.Length; i++) s += "," + value[i].ToString();

                settings.rkf.SetValue("SWAFItemTypes", s);
            }
        }

        public static int SWAFSplitterDistance
        {
            get
            {
                try { return (int)settings.rkf.GetValue("SWAFSplitterDistance", -1); }
                catch { return -1; }
            }

            set
            {
                settings.rkf.SetValue("SWAFSplitterDistance", value);
            }
        }

        public static int SWAFSortColumn
        {
            get
            {
                try { return (int)settings.rkf.GetValue("SWAFSortColumn", 2); }
                catch { return 2; }
            }

            set
            {
                settings.rkf.SetValue("SWAFSortColumn", value);
            }
        }
    }
}
