using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimPe
{
    public enum Expansions : uint
    {
        None = 0x0,
        BaseGame = 0x1,
        University = 0x2,
        Nightlife = 0x4,
        Business = 0x8,
        FamilyFun = 0x10,
        Glamour = 0x20,
        Pets = 0x40,
        HappyHoliday = 0x80,
        Seasons = 0x100,
        LifeStories = 0x00100000,
        Custom = 0x80000000
    }


    public class PathProvider : IEnumerable<string>
    {
        static ExpansionItem nil = new ExpansionItem(null);
        public static ExpansionItem Nil {
            get { return nil; }
        }

        XmlRegistry reg;
        XmlRegistryKey xrk;
        List<ExpansionItem> exps;
        List<string> paths;
        public List<ExpansionItem> Expansions
        {
            get { return exps; }
        }

        Dictionary<Expansions, ExpansionItem> map;
        int spver, epver, stver;
        ExpansionItem latest;
        List<string> censorfiles;
        Expansions lastknown;

        public static string ExpansionFile
        {
            get { return System.IO.Path.Combine(Helper.SimPeDataPath, "expansions.xreg"); }
        }

        static PathProvider glb;
        public static PathProvider Global{
            get
            {
                if (glb == null) glb = new PathProvider();
                return glb;
            }
        }

        private PathProvider()
        {
            reg = new XmlRegistry(ExpansionFile, true);
            xrk = reg.CurrentUser.CreateSubKey("Expansions");
            exps = new List<ExpansionItem>();
            map = new Dictionary<Expansions, ExpansionItem>();
            censorfiles = new List<string>();

            Load();
        }


        void Load()
        {
            censorfiles.Add(System.IO.Path.Combine(SimSavegameFolder, @"Downloads\quaxi_nl_censor_v1.package"));
            censorfiles.Add(System.IO.Path.Combine(SimSavegameFolder, @"Downloads\quaxi_nl_censor.package"));
            string[] names = xrk.GetSubKeyNames();
            int ver = -1;
            foreach (string name in names)
            {
                ExpansionItem i = new ExpansionItem(xrk.OpenSubKey(name, false));
                exps.Add(i);
                map[i.Expansion] = i;

                if (i.Flag.SimStory) continue;

                if (i.CensorFile != ""){
                    string fl = System.IO.Path.Combine(SimSavegameFolder, @"Downloads\" + i.CensorFileName);
                    if (!censorfiles.Contains(fl)) censorfiles.Add(fl);
                    fl = System.IO.Path.Combine(SimSavegameFolder, @"Config\" + i.CensorFileName);
                    if (!censorfiles.Contains(fl)) censorfiles.Add(fl);  
                }
                if (i.Version > ver )
                {
                    ver = i.Version;
                    lastknown = i.Expansion;
                }
            }

            spver = GetMaxVersion(ExpansionItem.Classes.StuffPack);
            epver = GetMaxVersion(ExpansionItem.Classes.ExpansionPack);
            stver = GetMaxVersion(ExpansionItem.Classes.Story);
            latest = this.GetLatestExpansion();

            exps.Sort();

            paths = new List<string>();
            foreach (ExpansionItem ei in exps)
                if (ei.Exists)
                    if (System.IO.Directory.Exists(ei.InstallFolder))
                        paths.Add(ei.InstallFolder);        
        }



        protected int GetMaxVersion(ExpansionItem.Classes sp)
        {
            int ret = 0;
            foreach (ExpansionItem i in exps)
            {
                if (i.Exists)
                {
                    if (sp ==i.Flag.Class)
                    {
                        if (i.Version > ret) ret = i.Version;
                    }
                }
            }

            return ret;
        }

        public Expansions LastKnown
        {
            get { return lastknown; }
        }

        public int GameVersion
        {
            get { return Math.Max(epver, spver); }
        }

        public int EPInstalled
        {
            get { return epver; }
        }

        public int SPInstalled
        {
            get { return spver; }
        }

        /// <summary>
        /// Name of the Sims Application
        /// </summary>
        public string SimsApplication
        {
            get { return Latest.ApplicationPath; }

        }

        public void SetDefaultPaths()
        {
            foreach (ExpansionItem i in exps)
            {
                i.InstallFolder = i.RealInstallFolder;
            }
            SimSavegameFolder = RealSavegamePath;
        }

        /// <summary>
        /// Returns the object describing the highest Expansion available on the System
        /// </summary>
        public ExpansionItem Latest
        {
            get { return latest; }
        }


        protected ExpansionItem GetLatestExpansion()
        {
            return GetExpansion(GameVersion);
        }

        /// <summary>
        /// Returns the object describing the Expansion associated with that Version, or Nil
        /// </summary>
        /// <param name="version"></param>
        /// <returns>null will be returned, if the passed Expansion is not yet defined. If it is just not installed on
        /// the users Nil, a valid object will be returned, but the <see cref="ExoansionItem.Exists"/> property 
        /// returns false.</returns>
        public ExpansionItem GetExpansion(int version)
        {
            Expansions exp = (Expansions)Math.Pow(2, version);
            return GetExpansion(exp);
        }

        /// <summary>
        /// Returns the object describing the passed Expansion, or Nil if it is not known
        /// </summary>
        /// <param name="exp"></param>
        /// <returns>Nil will be returned, if the passed Expansion is not yet defined. If it is just not installed on
        /// the users System, a valid object will be returned, but the <see cref="ExoansionItem.Exists"/> property 
        /// returns false.</returns>
        public ExpansionItem GetExpansion(Expansions exp)
        {
            if (!map.ContainsKey(exp)) return Nil;
            return map[exp];
        }

        public ExpansionItem this[Expansions ep]{
            get {return GetExpansion(ep); }
        }

        public ExpansionItem this[int ver]
        {
            get { return GetExpansion(ver); }
        }

        #region Censor Patch
        /// <summary>
        /// Returns true if the Game will start in Debug Mode
        /// </summary>
        internal bool BlurNudity
        {
            get
            {
                if (latest.CensorFile=="") return BlurNudityPreEP2;
                else return BlurNudityPostEP2;
            }
            set
            {
                if (latest.CensorFile == "")
                {
                    BlurNudityPostEP2 = false;
                    BlurNudityPreEP2 = value;
                }
                else {
                    BlurNudityPostEP2 = value;
                }
            }
        }

        

        protected bool BlurNudityPostEP2
        {
            get { return GetBlurNudity(); }
            set { SetBlurNudity(value, latest.CensorFile, false); }
        }

        internal void BlurNudityUpdate()
        {
            if (EPInstalled >= 3 && !GetBlurNudity())
            {
                SetBlurNudity(true, latest.CensorFile, true);
                SetBlurNudity(false, latest.CensorFile, true);
            }
        }

        bool GetBlurNudity()
        {
            foreach (string fl in censorfiles)
                if (System.IO.File.Exists(fl)) return false;

            return true;
        }

        void SetBlurNudity(bool value, string resname, bool silent)
        {
            if (!value)
            {
                string fl = latest.CensorFile;
                string folder = System.IO.Path.GetDirectoryName(fl);

                if (System.IO.File.Exists(fl)) return;

                if (!silent)
                    if (System.Windows.Forms.MessageBox.Show(SimPe.Localization.GetString("Censor_Install_Warn").Replace("{filename}", fl), SimPe.Localization.GetString("Warning"), System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                        return;

                try
                {
                    if (!System.IO.Directory.Exists(folder))
                        System.IO.Directory.CreateDirectory(folder);

                    string[] names = typeof(Helper).Assembly.GetManifestResourceNames();
                    System.IO.Stream s = null;
                    foreach (string name in names)
                    {
                        if (name.Trim().ToLower().EndsWith(latest.CensorFileName.Trim().ToLower()))
                        s = typeof(Helper).Assembly.GetManifestResourceStream(name);
                    }

                    System.IO.BinaryReader br = new BinaryReader(s);
                    try
                    {
                        System.IO.BinaryWriter bw = new BinaryWriter(System.IO.File.Create(fl));
                        try
                        {

                            bw.Write(br.ReadBytes((int)br.BaseStream.Length));
                        }
                        finally
                        {
                            bw.Close();
                        }
                    }
                    finally
                    {
                        br.Close();
                    }
                }
                catch (Exception ex)
                {
                    Helper.ExceptionMessage(ex);
                }
            }
            else
            {
                foreach (string fl in censorfiles)
                    if (System.IO.File.Exists(fl))
                    {
                        try
                        {
                            if (!silent)
                                if (System.Windows.Forms.MessageBox.Show(SimPe.Localization.GetString("Censor_UnInstall_Warn").Replace("{filename}", fl), SimPe.Localization.GetString("Warning"), System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                                    return;
                            System.IO.File.Delete(fl);
                        }
                        catch (Exception ex)
                        {
                            Helper.ExceptionMessage(ex);
                        }
                    }
            }
        }

        protected bool BlurNudityPreEP2
        {
            get
            {
                if (!System.IO.File.Exists(StartupCheatFile)) return true;

                try
                {
                    System.IO.TextReader fs = System.IO.File.OpenText(StartupCheatFile);
                    string cont = fs.ReadToEnd();
                    fs.Close();
                    string[] lines = cont.Split("\n".ToCharArray());

                    foreach (string line in lines)
                    {
                        string pline = line.ToLower().Trim();
                        while (pline.IndexOf("  ") != -1) pline = pline.Replace("  ", " ");
                        string[] tokens = pline.Split(" ".ToCharArray());

                        if (tokens.Length == 3)
                        {
                            if ((tokens[0] == "intprop") &&
                                (tokens[1] == "censorgridsize")
                                ) return (Convert.ToInt32(tokens[2]) != 0);
                        }
                    }
                }
                catch (Exception) { }

                return true;
            }

            set
            {
                if (!System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(StartupCheatFile))) return;

                try
                {
                    string newcont = "";
                    bool found = false;
                    if (System.IO.File.Exists(StartupCheatFile))
                    {
                        System.IO.TextReader fs = System.IO.File.OpenText(StartupCheatFile);
                        string cont = fs.ReadToEnd();
                        fs.Close();

                        string[] lines = cont.Split("\n".ToCharArray());


                        foreach (string line in lines)
                        {
                            string pline = line.ToLower().Trim();
                            while (pline.IndexOf("  ") != -1) pline = pline.Replace("  ", " ");
                            string[] tokens = pline.Split(" ".ToCharArray());

                            if (tokens.Length == 3)
                            {
                                if ((tokens[0] == "intprop") &&
                                    (tokens[1] == "censorgridsize")
                                    )
                                {
                                    if (!found)
                                    {
                                        if (!value)
                                        {
                                            newcont += "intprop censorgridsize 0";
                                            newcont += Helper.lbr;
                                        }
                                        found = true;
                                    }
                                    continue;
                                }
                            }
                            newcont += line.Trim();
                            newcont += Helper.lbr;
                        }

                        System.IO.File.Delete(StartupCheatFile);
                    }

                    if (!found)
                    {
                        if (!value)
                        {
                            newcont += "intprop censorgridsize 0";
                            newcont += Helper.lbr;
                        }
                    }

                    System.IO.TextWriter fw = System.IO.File.CreateText(StartupCheatFile);
                    fw.Write(newcont.Trim());
                    fw.Close();
                }
                catch (Exception) { }
            }
        }
        #endregion

        #region Paths 
        public static string RealSavegamePath
        {
            get
            {
                try
                {
                    string path = System.IO.Path.Combine(PersonalFolder, "EA Games");
                    path = System.IO.Path.Combine(path, DisplayedName);
                    return Helper.ToLongPathName(path);
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// This Folder contains al Sims User Data
        /// </summary>
        public static string SimSavegameFolder
        {
            get
            {
                try
                {
                    XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                    object o = rkf.GetValue("SavegamePath");
                    if (o == null)
                    {
                        return RealSavegamePath;
                    }
                    else
                    {
                        string fl = o.ToString();
                        if (!System.IO.Directory.Exists(fl)) return RealSavegamePath;
                        return fl;
                    }
                }
                catch (Exception)
                {
                    return RealSavegamePath;
                }
            }
            set
            {
                XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                rkf.SetValue("SavegamePath", value);
            }
        }

        /// <summary>
        /// Returns the Displayed Sims 2 name
        /// </summary>
        protected static string DisplayedName
        {
            get
            {
                try
                {
#if MAC
					return "The Sims 2";
#else
                    Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"Software\EA Games\The Sims 2");
                    object o = rk.GetValue("DisplayName");
                    if (o == null) return "The Sims 2";
                    else return o.ToString();
#endif
                }
                catch (Exception)
                {
                    return "The Sims 2";
                }
            }
        }

        /// <summary>
        /// Returns the Location of the Personal Folder
        /// </summary>
        protected static string PersonalFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            }
        }

        /// <summary>
        /// Name of the Nvidia DDS Path
        /// </summary>
        public string NvidiaDDSPath
        {
            get
            {
                try
                {
                    XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                    object o = rkf.GetValue("NvidiaDDS");
                    if (o == null) return "";
                    return o.ToString();
                }
                catch (Exception)
                {
                    return "";
                }
            }
            set
            {
                XmlRegistryKey rkf = Helper.WindowsRegistry.RegistryKey.CreateSubKey("Settings");
                rkf.SetValue("NvidiaDDS", value);
            }
        }

        /// <summary>
        /// The location of theNvidia Tool
        /// </summary>
        public string NvidiaDDSTool
        {
            get
            {
                return System.IO.Path.Combine(NvidiaDDSPath, "nvdxt.exe");
            }
        }

        /// <summary>
        /// Returns the Name of the Startup Cheat File
        /// </summary>
        public string StartupCheatFile
        {
            get
            {
                return System.IO.Path.Combine(SimSavegameFolder, "Config\\userStartup.cheat");
            }
        }
        /// <summary>
        /// returns the Fodler where the users Neighborhood is stored
        /// </summary>
        public string NeighborhoodFolder
        {
            get
            {
                try
                {
                    return System.IO.Path.Combine(SimSavegameFolder, "Neighborhoods");
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// returns the Fodler where the Backups are stored
        /// </summary>
        public string BackupFolder
        {
            get
            {
                try
                {
                    return System.IO.Path.Combine(System.IO.Path.Combine(PersonalFolder, "EA Games"), "SimPE Backup");
                }
                catch (Exception)
                {
                    return "";
                }
            }
        }
        #endregion 

        /// <summary>
        /// Write Changes
        /// </summary>
        internal void Flush()
        {
            reg.Flush();
        }

        #region IEnumerator<string> Member

        public string Current
        {
            get { throw new Exception("The method or operation is not implemented."); }
        }

        #endregion

        #region IDisposable Member

        public void Dispose()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion



        #region IEnumerable<string> Member

        public IEnumerator<string> GetEnumerator()
        {
            return paths.GetEnumerator();
        }

        #endregion

        #region IEnumerable Member

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return paths.GetEnumerator();
        }

        #endregion
    }
}
