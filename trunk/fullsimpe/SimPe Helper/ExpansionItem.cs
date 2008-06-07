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

            public bool FullObjectsPackage
            {
                get { return !this.GetBit(5); }
            }

            public bool HasNgbhProfiles { get { return this.GetBit(6); } }
        }

        string name;
        string sname;
        string objfolder;
        int version;
        int runtimeversion;
        Expansions exp;
        Microsoft.Win32.RegistryKey rk;
        string exe;
        Flags flag;
        string censor;
        Ambertation.CaseInvariantArrayList simnamedeep;
        Ambertation.CaseInvariantArrayList savegames;

        Ambertation.CaseInvariantArrayList preobjectfiltablefolders;
        Ambertation.CaseInvariantArrayList filtablefolders;
        IList<long> groups;
        int group;

        string shortname;
        string shortername;
        string longname;
        string namelistnr;
        string installsuffix;

        void SetDefaultFileTableFolders()
        {
            if (preobjectfiltablefolders.Count == 0)
            {
                if (Flag.Class == ExpansionItem.Classes.BaseGame) AddFileTableFolder("!TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Catalog" + Helper.PATH_SEP + "Bins");
            }

            if (filtablefolders.Count == 0)
            {
                if (Flag.Class == ExpansionItem.Classes.BaseGame) AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Sims3D");
                else AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "3D");

                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Catalog" + Helper.PATH_SEP + "Materials");
                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Catalog" + Helper.PATH_SEP + "Skins");
                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Catalog" + Helper.PATH_SEP + "Patterns");
                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Catalog" + Helper.PATH_SEP + "CANHObjects");
                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Wants");
                AddFileTableFolder("TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "UI");
            }
        }

        /// <summary>
        /// Adds a Folder to the list of FileTable Folders
        /// </summary>
        /// <param name="fodler">The folder to add</param>
        /// <remarks>Use <code>!</code> to specifiy a folder that has to be included before the objects.packages, 
        /// use <code>&lt;</code> to insert a folder at the beginning of the specific list</remarks>
        /// <param name="folder"></param>
        void AddFileTableFolder(string folder)
        {
            if (folder.StartsWith("!"))
            {
                AddFileTableFolder(preobjectfiltablefolders, folder.Substring(1));
            }
            else if (!filtablefolders.Contains(folder))
            {
                AddFileTableFolder(filtablefolders, folder);
            }
        }

        /// <summary>
        /// Adds a Folder to the list of FileTable Folders
        /// </summary>
        /// <param name="list">List to add to</param>
        /// <param name="fodler">The folder to add</param>
        /// <remarks>Use <code>&lt;</code> to insert a folder at the beginning of the specific list</remarks>
        /// <param name="folder"></param>
        void AddFileTableFolder(Ambertation.CaseInvariantArrayList list, string folder)
        {
            bool begin = false;
            if (folder.StartsWith("<"))
            {
                folder = folder.Substring(1);
                begin = true;
            }

            if (!list.Contains(folder))
            {
                if (begin) list.Insert(0, folder);
                else list.Add(folder);
            }
        }

        internal ExpansionItem(XmlRegistryKey key)
        {
            filtablefolders = new Ambertation.CaseInvariantArrayList();
            preobjectfiltablefolders = new Ambertation.CaseInvariantArrayList();


            shortname = "Unk.";
            shortername = "Unknown";
            longname = "The Sims 2 - Unknown";
            namelistnr = "0";
            if (key != null)
            {
                name = key.Name;
                ;
                XmlRegistryKey lang = key.OpenSubKey(System.Threading.Thread.CurrentThread.CurrentUICulture.Name.ToLower(), false);
                if (lang == null) lang = key.OpenSubKey(System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName.ToLower(), false);
                

                version = (int)key.GetValue("Version", 0);
                runtimeversion = (int)key.GetValue("PreferedRuntimeVersion", version);
                exp = (Expansions)(Math.Pow(2, version));

                int isnum = -1;
                object o = key.GetValue("RegKey", null);
                if (o is string)
                    rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey((string)o, false);
                else if (o is Ambertation.CaseInvariantArrayList)
                    foreach (string s in (Ambertation.CaseInvariantArrayList)o)
                    {
                        isnum++;
                        rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(s, false);
                        if (rk != null)
                            break;
                    }
                if (rk == null) isnum = -1;
                o = key.GetValue("InstallSuffix", null);
                if (o is string)
                    installsuffix = (string)o;
                else if (o is Ambertation.CaseInvariantArrayList && isnum >= 0 && isnum < ((Ambertation.CaseInvariantArrayList)o).Count)
                    installsuffix = (string)((Ambertation.CaseInvariantArrayList)o)[isnum];

                exe = (string)key.GetValue("ExeName", "Sims2.exe");
                flag = new Flags((int)key.GetValue("Flag", 0));
                censor = (string)key.GetValue("Censor", "");
                group = (int)key.GetValue("Group", 1);
                objfolder = (string)key.GetValue("ObjectsFolder", "TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Objects");

                simnamedeep = (Ambertation.CaseInvariantArrayList)key.GetValue("SimNameDeepSearch", new Ambertation.CaseInvariantArrayList());
                savegames = (Ambertation.CaseInvariantArrayList)key.GetValue("SaveGameLocationsForGroup", new Ambertation.CaseInvariantArrayList());
                if (savegames.Count==0) savegames.Add(PathProvider.SimSavegameFolder);

                Ambertation.CaseInvariantArrayList ftf = (Ambertation.CaseInvariantArrayList)key.GetValue("FileTableFolders", new Ambertation.CaseInvariantArrayList());
                if (ftf.Count == 0) SetDefaultFileTableFolders();
                else foreach (string folder in ftf) AddFileTableFolder(folder);

                ftf = (Ambertation.CaseInvariantArrayList)key.GetValue("AdditionalFileTableFolders", new Ambertation.CaseInvariantArrayList());
                foreach (string folder in ftf) AddFileTableFolder(folder);

                System.Diagnostics.Debug.WriteLine(this.ToString());

                namelistnr = (string)key.GetValue("namelistnr", "0");
                string dname = name;
                if (lang != null)
                {
                    shortname = (string)lang.GetValue("short", name);
                    shortername = (string)lang.GetValue("name", shortname);
                    if (rk != null) dname = (string)rk.GetValue("DisplayName", shortername);
                    longname = (string)lang.GetValue("long", dname);
                }
                else //1. check the resource files, then try default language, then set to defaults
                {
                    if (lang == null) lang = key.OpenSubKey("en", false);
                    shortname = SimPe.Localization.GetString("EP SNAME " + version);
                    shortername = shortname;

                    if (shortname == "EP SNAME " + version && lang != null)
                    {
                        shortname = (string)lang.GetValue("short", name);
                        shortername = (string)lang.GetValue("name", shortname);
                    }
                    if (shortname == "EP SNAME " + version) shortname = name;

                    if (rk != null) dname = (string)rk.GetValue("DisplayName", shortername);

                    longname = SimPe.Localization.GetString("EP NAME " + version);
                    if (longname == "EP NAME " + version && lang!=null) longname = (string)lang.GetValue("long", dname);
                    if (longname == "EP NAME " + version) longname = dname;
                    
                }
            }
            else
            {
                name = "NULL";
                flag = new Flags(0);
                censor = "";
                exe = "";
                exp = (Expansions)0;
                version = -1;
                runtimeversion = -1;
                simnamedeep = new Ambertation.CaseInvariantArrayList();
                savegames = new Ambertation.CaseInvariantArrayList();
                savegames.Add(PathProvider.SimSavegameFolder);


                SetDefaultFileTableFolders();
                objfolder = "TSData" + Helper.PATH_SEP + "Res" + Helper.PATH_SEP + "Objects";
                group = 0;

            }



            BuildGroupList();
            sname = GetShortName();
        }

        private void BuildGroupList()
        {
            List<long> mylist = new List<long>();
            
            for (int i = 0; i < PathProvider.GROUP_COUNT; i++)
            {
                long grp = (long)Math.Pow(2, i);
                if (this.ShareOneGroup(grp)) mylist.Add(grp);
            }

            groups = mylist.AsReadOnly();
        }

        #region Neighborhood Path
        private IniRegistry profilesini = null;
        public class NeighborhoodPaths : List<NeighborhoodPath> { }
        public class NeighborhoodPath
        {
            string name;
            string path;
            ExpansionItem ei;
            bool def;
            internal NeighborhoodPath(string name, string path, ExpansionItem ei, bool def)
            {
                this.name = name;
                this.path = path;
                this.ei = ei;
                this.def = def;
            }

            public string Lable { get { return name; } }
            public string Path { get { return path; } }
            public ExpansionItem Expansion { get { return ei; } }
            public bool Default { get { return def; } }

            public override int GetHashCode()
            {
                if (ei == null) return 0;
                return ei.Version;
            }
            public override bool Equals(object obj)
            {
                if (obj.GetType() == typeof(NeighborhoodPath))
                {
                    NeighborhoodPath np = (NeighborhoodPath)obj;
                    return Helper.CompareableFileName(np.Path) == Helper.CompareableFileName(Path);
                }
                return base.Equals(obj);
            }
        }

        internal void AddNeighborhoodPaths(NeighborhoodPaths hoods)
        {
            foreach (string s in savegames)
            {
                string pt = System.IO.Path.Combine(GetRealPath(s), "Neighborhoods");

                if (System.IO.Directory.Exists(pt))
                {
                    if (flag.HasNgbhProfiles)
                    {
                        string profiles = System.IO.Path.Combine(pt, "Profiles.ini");
                        try
                        {
                            if (System.IO.File.Exists(profiles))
                            {
                                profilesini = new IniRegistry(profiles, true);
                                string defaulthood = profilesini.GetValue("State", "LastSaved", "");
                                defaulthood = defaulthood.ToUpper().Trim();

                                IniRegistry.SectionContent sec = profilesini.Section("Profiles");
                                foreach (string k in sec)
                                {
                                    string hood = sec.GetValue(k);
                                    if (hood == null) continue;
                                    hood = hood.ToUpper().Trim();
                                    string path = System.IO.Path.Combine(pt, hood.Replace("0X", ""));
                                    if (System.IO.Directory.Exists(path))
                                    {
                                        NeighborhoodPath np = new NeighborhoodPath(k, path, this, hood == defaulthood);
                                        if (!hoods.Contains(np)) hoods.Add(np);
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            if (Helper.DebugMode) Helper.ExceptionMessage(ex);
                        }
                    }
                    else
                    {
                        NeighborhoodPath np = new NeighborhoodPath("", pt, this, true);
                        if (!hoods.Contains(np)) hoods.Add(np);
                    }
                }
            }
        }
        #endregion

        internal void AddSaveGamePaths(Ambertation.CaseInvariantArrayList realsavegames)
        {
            foreach (string s in savegames)
            {
                string pt = GetRealPath(s);
                if (System.IO.Directory.Exists(pt)) realsavegames.Add(pt);
            }
        }

        private string GetRealPath(string pt)
        {
            pt = pt.Replace("{MyDocuments}", PathProvider.PersonalFolder);
            pt = pt.Replace("{DisplayName}", DisplayName);
            pt = pt.Replace("{UserSaveGame}", PathProvider.SimSavegameFolder);
            return pt;
        }

        public string DisplayName
        {
            get { 
                return PathProvider.GetDisplayedNameForExpansion(this); 
            }
        }

        public Ambertation.CaseInvariantArrayList SimNameDeepSearch
        {
            get { return simnamedeep; }
        }

        public string Name
        {
            get {
                return longname;
                //string res = SimPe.Localization.GetString("EP NAME " + version);
                //return res;
            }
        }

        public Ambertation.CaseInvariantArrayList FileTableFolders
        {
            get { return filtablefolders; }
        }

        public Ambertation.CaseInvariantArrayList PreObjectFileTableFolders
        {
            get { return preobjectfiltablefolders; }
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

        public int PreferedRuntimeVersion
        {
            get { return runtimeversion; }
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


        public  IList<long> Groups
        {
            get { return groups; }
        }

        public int Group
        {
            get { return group; }
        }

        public bool ShareOneGroup(ExpansionItem ei)
        {
            return (ei.Group & Group) != 0;
        }

        public bool ShareOneGroup(long grp)
        {
            return (grp & Group) != 0;
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

        /// <summary>
        /// Folder where the objects.package is located
        /// </summary>
        public string ObjectsSubFolder
        {
            get
            {
                return objfolder;
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

        public string NameShort
        {
            get
            {
                return shortname;
                //string res = SimPe.Localization.GetString("EP SNAME " + version);
                //return res;
            }
        }

        public string NameSortNumber
        {
            get
            {
                return namelistnr;
            }
        }

        public string NameShorter
        {
            get
            {
                return shortername;
            }
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
