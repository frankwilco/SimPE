/***************************************************************************
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
using System.Resources;
using System.Globalization;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;

namespace SimPe.Custom
{
    public class Settings : GlobalizedObject, ISettings
    {
        static ResourceManager rm = new ResourceManager(typeof(SimPe.Localization));

        private static Settings settings;
        static Settings() { settings = new Settings(); }
        public static bool Persistent { get { return settings.KeepFilesOpen; } }
        //public static bool SimNames { get { return !settings.HackerMode && settings.AddSimNames; } }


        public Settings() : base(rm) { }

        const string BASENAME = "Settings";
        SimPe.XmlRegistryKey xrk = SimPe.Helper.WindowsRegistry.RegistryKey;

        [System.ComponentModel.Category("SimPe")]
        public bool KeepFilesOpen
        {
            get
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                object o = rkf.GetValue("keepFilesOpen", true);
                return Convert.ToBoolean(o);
            }

            set
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                rkf.SetValue("keepFilesOpen", value);
            }
        }

        /*
        [System.ComponentModel.Category("SimPe")]
        public bool AddSimNames
        {
            get
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                object o = rkf.GetValue("addSimNames", false);
                return Convert.ToBoolean(o);
            }

            set
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                rkf.SetValue("addSimNames", value);
            }
        }

        [System.ComponentModel.Category("SimPe")]
        public bool HackerMode
        {
            get
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                object o = rkf.GetValue("hackerMode", false);
                return Convert.ToBoolean(o);
            }

            set
            {
                SimPe.XmlRegistryKey rkf = xrk.CreateSubKey(BASENAME);
                rkf.SetValue("hackerMode", value);
            }
        }
        */

        #region ISettings Members

        public override string ToString() { return "SimPe"; }

        [System.ComponentModel.Browsable(false)]
        public System.Drawing.Image Icon { get { return null; } }

        object ISettings.GetSettingsObject() { return this; }

        #endregion
    }

    public class SettingsFactory : AbstractWrapperFactory, ISettingsFactory
    {
        #region ISettingsFactory Members

        public ISettings[] KnownSettings { get { return new ISettings[] { new Settings() }; } }

        #endregion

    }
}
