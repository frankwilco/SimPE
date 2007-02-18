using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe
{
    public class ExpansionItem : IComparable
    {
        public enum Classes {
            BaseGame, ExpansionPack, StuffPack, Story
        }
       
        public class Flags : FlagBase
        {
            internal Flags(int val)
                : base((ushort)val)
            {
            }

            protected bool BaseGame
            {
                get { return !StuffPack && !RegularExpansion; }
            }

            protected bool StuffPack
            {
                get { return this.GetBit(1);  }
            }

            protected bool RegularExpansion
            {
                get { return this.GetBit(0);; }
            }

            public Classes Class
            {
                get
                {
                    if (SimStory) return Classes.Story;
                    if (RegularExpansion) return Classes.ExpansionPack;
                    if (BaseGame) return Classes.BaseGame;
                    return Classes.StuffPack;
                }
            }

            public bool LuaFolders
            {
                get { return this.GetBit(2); }
            }

            public bool LoadWantText
            {
                get { return this.GetBit(3); }
            }

            public bool SimStory
            {
                get { return this.GetBit(4); }
            }
        }

        string name;
        string sname;
        int version;
        Expansions exp;
        Microsoft.Win32.RegistryKey rk;
        string exe;
        Flags flag;
        string censor;
        Ambertation.CaseInvariantArrayList simnamedeep;

        

        internal ExpansionItem(XmlRegistryKey key)
        {
            if (key != null)
            {
                name = key.Name;

                version = (int)key.GetValue("Version", 0);
                exp = (Expansions)(Math.Pow(2, version));
                rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey((string)key.GetValue("RegKey", "Software"), false);
                exe = (string)key.GetValue("ExeName", "Sims2.exe");
                flag = new Flags((int)key.GetValue("Flag", 0));
                censor = (string)key.GetValue("Censor", "");

                simnamedeep = (Ambertation.CaseInvariantArrayList)key.GetValue("SimNameDeepSearch", new Ambertation.CaseInvariantArrayList());
                System.Diagnostics.Debug.WriteLine(this.ToString());
            }
            else
            {
                name = "NULL";
                flag = new Flags(0);
                censor = "";
                exe = "";
                exp = (Expansions)0;
                version = -1;
                simnamedeep = new Ambertation.CaseInvariantArrayList();
            }

            sname = GetShortName();
        }

        public Ambertation.CaseInvariantArrayList SimNameDeepSearch
        {
            get { return simnamedeep; }
        }

        public string Name
        {
            get { return SimPe.Localization.GetString("EP NAME " + version); }
        }

        

        internal string CensorFile{
            get { return System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Config\\"+censor); }
        }

        internal string CensorFileName
        {
            get { return censor; }
        }

        public bool Exists
        {
            get { return rk != null; }
        }

        public int Version
        {
            get { return version;  }
        }

        public Expansions Expansion
        {
            get { return exp;}
        }

        public Microsoft.Win32.RegistryKey Registry
        {
            get { return rk; }
        }

        public string ExeName
        {
            get { return exe; }
        }

        /// <summary>
        /// Name of the Sims Application
        /// </summary>
        public string ApplicationPath
        {
            get
            {
                try
                {
                    return System.IO.Path.Combine(InstallFolder, "TSBin\\" + ExeName);
                }
                catch (Exception)
                {
                    return "";
                }
            }

        }

        public string IdKey
        {
            get
            {
                return System.IO.Path.GetFileNameWithoutExtension(ExeName);
            }
        }

        protected string GetShortName()
        {
            string ret = IdKey.Trim().ToUpper().Replace("SIMS2", "");
            if (ret == "") return "Game";
            return ret;

        }

        public string ShortId
        {
            get { return sname;  }
        }

        public string NameShort {
            get { return SimPe.Localization.GetString("EP SNAME " + version); }
    }

        public Flags Flag {
            get { return flag; }
        }

        public string RealInstallFolder
        {
            get
            {
                if (!Exists) return "";
                try
                {
                    object o = rk.GetValue("Install Dir");
                    if (o == null) return "";
                    else return Helper.ToLongPathName(o.ToString());
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// Name of the Sims Application
        /// </summary>
        public string InstallFolder
        {
            get
            {
                try
                {
                    XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                    object o = rkf.GetValue(IdKey+"Path");
                    if (o == null) return this.RealInstallFolder;
                    else
                    {
                        string fl = o.ToString();

                        if (!System.IO.Directory.Exists(fl)) return this.RealInstallFolder;
                        return fl;
                    }
                }
                catch (Exception)
                {
                    return this.RealInstallFolder;
                }
            }
            set
            {
                XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                rkf.SetValue(IdKey+"Path", value);
            }
        }

        public override string ToString()
        {
            string s = name + ": " + version + "=" + exp + ", " + exe + ", " + flag + ", "+Flag.Class;
            if (rk != null) s += ", " + rk.Name;
            return s;

        }

        #region IComparable Member

        public int CompareTo(object obj)
        {
            ExpansionItem a = obj as ExpansionItem;

            if (a == null) return 0;
            else return Version.CompareTo(a.Version);
        }

        #endregion
    }
}
