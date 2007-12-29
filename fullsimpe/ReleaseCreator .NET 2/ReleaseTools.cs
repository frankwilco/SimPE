using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.ComponentModel;
using System.Windows.Forms;

namespace ReleaseCreator
{
    class ReleaseTools
    {
        long publicver, qaver;
        ArrayList listing;
        Settings set;
        Form1 frm;

        public ReleaseTools(Settings s, Form1 f)
        {
            GetCurrentOnlineVersions();
            set = s;
            frm = f;
            
            listing = new ArrayList();
        }

        /// <summary>
        /// Returns the human readable Version of the latest QA published
        /// </summary>
        /// <returns></returns>
        public String QAVersion
        {
            get
            {
                return SimPe.Helper.LongVersionToString(qaver);
            }
        }

        /// <summary>
        /// Returns the human readable Version of the latest Public release
        /// </summary>
        public String PublicVersion
        {
            get
            {
                return SimPe.Helper.LongVersionToString(publicver);
            }
        }

        /// <summary>
        /// Read the Version Numbers curently available online
        /// </summary>
        private void GetCurrentOnlineVersions()
        {
            SimPe.Helper.WindowsRegistry.WaitingScreen = false;

            SimPe.Updates.UpdateState.SetUpdatablePluginList(new System.Collections.Generic.List<SimPe.Updates.IUpdatablePlugin>());
            SimPe.Updates.WebUpdate.CheckUpdate(ref publicver, ref qaver);
        }

        char NextLetter(char letter)
        {
            return (char)((byte)letter + 1);
        }

        private void BuildArchive(bool isqa, string setupver, string releaseletter)
        {
            setupver = "SimPe_" + setupver.Replace(".", "");
            if (isqa)
            {
                if (set.AutoSelectLetter) releaseletter = ""+FindReleaseLetter(setupver, "_qa.7z");
                BuildArchive("Create SimPE QA.7z.bat", setupver + releaseletter + "_qa.7z");
            }
            else BuildArchive("Create SimPE.7z.bat", setupver + releaseletter + ".7z");
        }

        private char FindReleaseLetter(string prefix, string postfix)
        {
            string[] files = System.IO.Directory.GetFiles(set.ReleaseDir, prefix + "*" + postfix);
            char cletter = 'a';
            foreach (string file in files)
            {
                string letter = System.IO.Path.GetFileName(file).Replace(prefix, "").Replace(postfix, "").Trim();
                if (letter.Length == 0) letter = "a";

                char l = letter[0];
                //Console.Write(l + ">" + cletter);
                if (l >= cletter)
                {
                    cletter = NextLetter(l);
                    //Console.Write(": "+l+" --> " + cletter);
                }
                //Console.WriteLine();
            }
            return cletter;
        }

        private void BuildArchive(string templname, string archname)
        {
            string letter = set.ReleaseDir;
            letter = letter.Substring(0, 2);
            string outputname = System.IO.Path.Combine(set.ReleaseDir, templname);
            Hashtable map = new Hashtable();
            map["simpedrive"] = letter;
            map["simpedir"] = set.ReleaseDir;
            map["archivename"] = archname;
            CreateTemplate(templname, outputname, map);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = outputname;

            Process p = Process.Start(psi);
            p.WaitForExit();

            System.IO.File.Delete(outputname);
        }

        private void Cleanup()
        {
            string letter = set.ReleaseDir;
            letter = letter.Substring(0, 2);
            string outputname = System.IO.Path.Combine(set.ReleaseDir, "cleanup.bat");
            Hashtable map = new Hashtable();
            map["simpedrive"] = letter;
            map["simpedir"] = set.ReleaseDir;
            CreateTemplate("cleanup.bat", outputname, map);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = outputname;

            Process p = Process.Start(psi);
            p.WaitForExit();

            System.IO.File.Delete(outputname);
        }

        private void BuildSetup(string setupbasename, string setupver, string templname)
        {
            string setupname = GetVersionedSetupName(setupbasename, setupver);
            string outputname = System.IO.Path.Combine(set.ReleaseDir, templname);

            Hashtable map = new Hashtable();
            map["shortver"] = setupver;
            map["setupname"] = setupname;
            CreateTemplate(templname, outputname, map);

            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = set.InnoDir;
            psi.Arguments = outputname;

            Process p = Process.Start(psi);
            p.WaitForExit();

            System.IO.File.Delete(outputname);
        }

        private static void CreateTemplate(string templname, string outputname, Hashtable map)
        {
            System.IO.StreamReader sr = System.IO.File.OpenText(@"Data\" + templname);
            try
            {
                string setup = sr.ReadToEnd();
                System.IO.StreamWriter sw = System.IO.File.CreateText(outputname);
                try
                {
                    foreach (string key in map.Keys)
                        setup = setup.Replace("{" + key + "}", map[key].ToString());

                    sw.Write(setup);
                }
                finally
                {
                    sw.Close();
                }
            }
            finally
            {
                sr.Close();
            }
        }

        private static string GetVersionedSetupName(string setupbasename, string setupver)
        {
            string setupname = setupbasename + "-" + setupver;
            return setupname;
        }

        private void WriteValidatorData(System.Diagnostics.FileVersionInfo cver)
        {
            System.IO.StreamWriter sw = System.IO.File.CreateText(System.IO.Path.Combine(set.ReleaseDir, @"Data\release.nfo"));
            try
            {
                sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                sw.WriteLine("<simperelease version=\"" + SimPe.Helper.VersionToLong(cver) + "\">");
                foreach (FileDescriptor f in listing)
                {
                    if (f.FileName.Trim().ToLower().StartsWith("simpe-setup")) continue;
                    if (f.FileName == "validator.exe") continue;
                    sw.Write(f.ToString());
                }
                sw.WriteLine("</simperelease>");
            }
            finally
            {
                sw.Close();
            }
        }

        private void CollectFileInformations(out bool isqa, out System.Diagnostics.FileVersionInfo cver)
        {
            isqa = false;
            cver = null;
            long csize = 0;
            listing.Clear();
            frm.lv.Items.Clear();
            string[] files = System.IO.Directory.GetFiles(set.ReleaseDir, "*.dll");
            foreach (string file in files) listing.Add(new FileDescriptor(set.ReleaseDir, file));

            files = System.IO.Directory.GetFiles(set.ReleaseDir, "*.exe");
            foreach (string file in files) listing.Add(new FileDescriptor(set.ReleaseDir, file));

            files = System.IO.Directory.GetFiles(System.IO.Path.Combine(set.ReleaseDir, "Plugins"), "*.dll");
            foreach (string file in files) listing.Add(new FileDescriptor(set.ReleaseDir, file));

            foreach (FileDescriptor f in listing)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = f.FileName;
                if (f.FileName.Trim().ToLower().StartsWith("simpe-setup")) continue;

                if (f.FileName == "simpe.helper.dll")
                {
                    frm.tbVer.Text = SimPe.Helper.VersionToString(f.Version);
                    if ((f.Version.FileMinorPart % 2) == 1)
                    {
                        frm.lbQaVer.Text = SimPe.Helper.LongVersionToString(qaver) + " (" + SimPe.Helper.VersionToString(f.Version) + ")";
                        isqa = true;
                    }
                    else
                        frm.lbVer.Text = SimPe.Helper.LongVersionToString(publicver) + " (" + SimPe.Helper.VersionToString(f.Version) + ")";

                    csize = f.Size;
                    cver = f.Version;
                }
                lvi.SubItems.Add(f.Size.ToString());
                lvi.SubItems.Add(SimPe.Helper.VersionToString(f.Version));

                frm.lv.Items.Add(lvi);
            }
        }

        private void SaveFtpCommandTemplates(string ftpprev, string ftppub)
        {
            System.IO.StreamWriter sw = System.IO.File.CreateText(System.IO.Path.Combine(set.ReleaseDir, @"ftpcommands_preview.txt"));
            try
            {
                sw.WriteLine(ftpprev);
            }
            finally
            {
                sw.Close();
            }

            sw = System.IO.File.CreateText(System.IO.Path.Combine(set.ReleaseDir, @"ftpcommands_publish.txt"));
            try
            {
                sw.WriteLine(ftppub);
            }
            finally
            {
                sw.Close();
            }
        }

        private static void LoadFtpCommandTemplates(out string ftpprev, out string ftppub)
        {
            System.IO.StreamReader sr = System.IO.File.OpenText(@"Data\ftpcommands_preview.txt");
            ftpprev = sr.ReadToEnd();
            sr.Close();

            sr = System.IO.File.OpenText(@"Data\ftpcommands_publish.txt");
            ftppub = sr.ReadToEnd();
            sr.Close();
        }

        private string BuildSetupVersionString(bool isqa, System.Diagnostics.FileVersionInfo cver, bool havereleaseletter, string releaseletter)
        {
            string setupver = "";
            if (isqa)
            {
                setupver = SimPe.Helper.LongVersionToShortString(publicver);
            }
            else
            {
                long pver = SimPe.Helper.VersionToLong(cver);
                setupver = SimPe.Helper.LongVersionToShortString(pver);
            }

            if (havereleaseletter) setupver += releaseletter;
            return setupver;
        }

        private void BuildReleaseInfo(bool isqa, System.Diagnostics.FileVersionInfo cver, string setupver, ref string ftpprev, ref string ftppub, string setupbasename, string templname, string ftpid, string releaseletter)
        {
            //get Size of the primary Setup
            string setupname; string realname;
            BuildSetupName(setupver, setupbasename, out setupname, out realname);
            System.IO.Stream st = System.IO.File.OpenRead(realname);
            long csize = st.Length;
            st.Close();

            ftppub = ftppub.Replace("{" + ftpid + "setuppath}", realname);
            ftppub = ftppub.Replace("{" + ftpid + "setupname}", setupname);
            ftpprev = ftpprev.Replace("{" + ftpid + "setuppath}", realname);
            ftpprev = ftpprev.Replace("{" + ftpid + "setupname}", setupname);

            Hashtable map = new Hashtable();
            if (isqa)
            {
                map["shortver"] = SimPe.Helper.LongVersionToShortString(publicver) + releaseletter;
                map["longver"] = SimPe.Helper.LongVersionToString(publicver);
                map["releasever"] = publicver.ToString();
                map["qaver"] = SimPe.Helper.VersionToLong(cver).ToString();
            }
            else
            {
                long pver = SimPe.Helper.VersionToLong(cver);
                map["shortver"] = SimPe.Helper.LongVersionToShortString(pver) + releaseletter;
                map["longver"] = SimPe.Helper.LongVersionToString(pver);
                map["releasever"] = SimPe.Helper.VersionToLong(cver).ToString();
                map["qaver"] = qaver.ToString();
            }
            map["setupname"] = setupname;

            float f = ((csize / 1024.0f) / 1024.0f);
            map["size"] = f.ToString("N3").Replace(",", ".");

            CreateTemplate(templname, System.IO.Path.Combine(set.UpdateInfoDir, templname), map);
        }

        private void BuildSetupName(string setupver, string setupbasename, out string setupname, out string realname)
        {
            setupname = GetVersionedSetupName(setupbasename, setupver) + ".exe";
            realname = System.IO.Path.Combine(set.ReleaseDir, setupname);
            if (!System.IO.File.Exists(realname))
            {
                setupname = setupbasename + ".exe";
                realname = System.IO.Path.Combine(set.ReleaseDir, setupname);
            }
        }

        private Ambertation.Ftp.FTPFactory FtpConnect()
        {
            Ambertation.Ftp.FTPFactory f = new Ambertation.Ftp.FTPFactory();
            f.setRemoteHost(set.FtpServer);
            f.setRemoteUser(set.FtpUser);
            f.setRemotePass(set.FtpPassword);
            f.login();
            f.setBinaryMode(true);

            return f;
        }

        internal void UploadPublicPreview(string releaseletter)
        {
            bool isqa; System.Diagnostics.FileVersionInfo cver;
            CollectFileInformations(out isqa, out cver);
            WriteValidatorData(cver);
            string setupver = BuildSetupVersionString(isqa, cver, true, releaseletter);

            string srcname = GetVersionedSetupName("SimPE-Setup", setupver) + ".exe";
            string dstname = "preview_" + srcname;
            UploadFile(srcname, dstname);

            dstname = "preview_SimPE-Setup.exe";
            UploadFile(srcname, dstname);

            srcname = GetVersionedSetupName("SimPE-Setup-Light", setupver) + ".exe";
            dstname = "preview_" + srcname;
            UploadFile(srcname, dstname);
        }

        internal void UploadFile(string srcname, string dstname)
        {
            frm.Cursor = Cursors.WaitCursor;
            try
            {
                Ambertation.Ftp.FTPFactory f = FtpConnect();
                f.UploadProgress += new Ambertation.Ftp.FTPFactory.UploadProgressEventHandler(f_UploadProgress);
                f.chdir("files/");
                f.upload(System.IO.Path.Combine(set.ReleaseDir, srcname), dstname);
                f.UploadProgress -= new Ambertation.Ftp.FTPFactory.UploadProgressEventHandler(f_UploadProgress);
                frm.pb.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            frm.Cursor = Cursors.Default;
        }

        void f_UploadProgress(string filename, long size, long sent, ref bool abort)
        {
            if (size == 0) frm.pb.Value = 0;
            else
            {
                float p = (float)sent / (float)size;
                frm.pb.Value = (int)Math.Round(frm.pb.Maximum * p);
                Application.DoEvents();
            }
        }

        internal void PublishFiles(string releaseletter)
        {
            bool isqa; System.Diagnostics.FileVersionInfo cver;
            CollectFileInformations(out isqa, out cver);
            WriteValidatorData(cver);
            string setupver = BuildSetupVersionString(isqa, cver, true, releaseletter);

            string srcname = GetVersionedSetupName("SimPE-Setup", setupver) + ".exe";
            string dstname = "preview_" + srcname;
            RenameFile(srcname, dstname);

            srcname = "SimPE-Setup.exe";
            dstname = "preview_SimPE-Setup.exe";
            RenameFile(srcname, dstname);


            srcname = GetVersionedSetupName("SimPE-Setup-Light", setupver) + ".exe";
            dstname = "preview_" + srcname;
            RenameFile(srcname, dstname);

            UploadReleaseNfo("downloadnfo.txt");
            UploadReleaseNfo("downloadlightnfo.txt");
        }

        private void RenameFile(string newname, string oldname)
        {
            frm.Cursor = Cursors.WaitCursor;
            try
            {
                Ambertation.Ftp.FTPFactory f = FtpConnect();
                f.chdir("files/");
                string[] files = f.getFileList(newname);
                if (files.Length == 1)
                {
                    files = f.getFileList("old_" + newname);
                    if (files.Length == 1) f.deleteRemoteFile("old_" + newname);
                    f.renameRemoteFile(newname, "old_" + newname);
                }
                f.renameRemoteFile(oldname, newname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            frm.Cursor = Cursors.Default;
        }

        private void UploadReleaseNfo(string flname)
        {
            frm.Cursor = Cursors.WaitCursor;
            try
            {
                Ambertation.Ftp.FTPFactory f = FtpConnect();
                f.UploadProgress += new Ambertation.Ftp.FTPFactory.UploadProgressEventHandler(f_UploadProgress);
                f.chdir("/");
                f.upload(System.IO.Path.Combine(set.UpdateInfoDir, flname));
                f.UploadProgress -= new Ambertation.Ftp.FTPFactory.UploadProgressEventHandler(f_UploadProgress);
                frm.pb.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            frm.Cursor = Cursors.Default;
        }

        public void CreateRelease(bool compileSetup, string releaseletter)
        {
            bool isqa;
            Cleanup();
            System.Diagnostics.FileVersionInfo cver;
            CollectFileInformations(out isqa, out cver);
            WriteValidatorData(cver);
            string setupver = BuildSetupVersionString(isqa, cver, true, releaseletter);
            if (compileSetup)
            {
                if (!isqa)
                {
                    BuildSetup("SimPE-Setup", setupver, "setup.iss");
                    BuildSetup("SimPE-Setup-Light", setupver, "setup-light.iss");
                }

                BuildArchive(isqa, BuildSetupVersionString(false, cver, false, releaseletter), releaseletter);
            }

            string ftpprev; string ftppub;
            LoadFtpCommandTemplates(out ftpprev, out ftppub);



            BuildReleaseInfo(isqa, cver, setupver, ref ftpprev, ref ftppub, "SimPE-Setup", "downloadnfo.txt", "full", releaseletter);
            BuildReleaseInfo(isqa, cver, setupver, ref ftpprev, ref ftppub, "SimPE-Setup-Light", "downloadlightnfo.txt", "light", releaseletter);
            //if (!isqa) SaveFtpCommandTemplates(ftpprev, ftppub);
        }

    }
}
