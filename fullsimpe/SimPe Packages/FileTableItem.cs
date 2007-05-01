using System;
using System.Collections;
using System.Xml;
using SimPe.Interfaces.Wrapper;

namespace SimPe
{
    

    /// <summary>
    /// The type and location of a Folder/file
    /// </summary>
    public class FileTableItem
    {
        bool recursive;
        bool file;
        bool ignore;
        int ver;
        string relpath;
        string path;
        FileTableItemType type;

        public FileTableItem(string path)
        {
            recursive = false;
            file = false;
            if (path.StartsWith(":"))
            {
                path = path.Substring(1, path.Length - 1);
                recursive = true;
            }
            else if (path.StartsWith("*"))
            {
                path = path.Substring(1, path.Length - 1);
                file = true;
            }

            this.path = path;
            this.relpath = path;
            this.ver = -1;
            this.type = FileTablePaths.Absolute;
            this.ignore = false;
        }

        public bool Ignore
        {
            get { return ignore; }
            set { ignore = value; }
        }

        public FileTableItem(string path, bool rec, bool fl)
            : this(path, rec, fl, -1, false)
        {
        }
        public FileTableItem(string path, bool rec, bool fl, int ver)
            : this(path, rec, fl, ver, false)
        {
        }

        public FileTableItem(string path, bool rec, bool fl, int ver, bool ign)
            : this(path, FileTablePaths.Absolute, rec, fl, ver, ign)
        {
        }

        public FileTableItem(string relpath, FileTableItemType type, bool rec, bool fl, int ver, bool ign)
        {
            this.recursive = rec;
            this.file = fl;
            this.ver = ver;
            this.type = type;
            this.SetName(relpath);
            this.ignore = ign;
        }

        internal void SetRecursive(bool state)
        {
            this.recursive = state;
        }

        internal void SetFile(bool state)
        {
            this.file = state;
        }


        public static string GetRoot(FileTableItemType type)
        {
            string ret = null;
            ret = type.GetRoot();

            if (ret != null)
                if (!ret.EndsWith(Helper.PATH_SEP)) ret += Helper.PATH_SEP;

            if (ret == Helper.PATH_SEP) ret = null;
            return ret;
        }

        public static int GetEPVersion(FileTableItemType type)
        {
            return type.GetEPVersion();
        }

        bool CutName(string name, FileTableItemType type)
        {
            try
            {

                if (System.IO.Directory.Exists(name))
                    if (!Helper.IsAbsolutePath(name)) return false;
            }
#if DEBUG
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }

#else
			catch {}
#endif

            string root = GetRoot(type);
            if (root == null || root == "" || root == Helper.PATH_SEP) return false;


            root = Helper.CompareableFileName(Helper.ToLongPathName(root));
            if (!root.EndsWith(Helper.PATH_SEP)) root += Helper.PATH_SEP;

            string ename = Helper.CompareableFileName(name);
            name = name.Trim();
            if (!ename.EndsWith(Helper.PATH_SEP))
            {
                ename += Helper.PATH_SEP;
                name += Helper.PATH_SEP;
            }

            if (ename.StartsWith(root))
            {

                this.path = name.Substring(root.Length);//ename.Replace(root, "");
                if (!this.IsFile)
                    if (this.path.StartsWith(Helper.PATH_SEP)) path = path.Substring(1);
                this.Type = type;
                return true;
            }

            return false;
        }

        internal void SetName(string name)
        {
            string n = name;

            foreach (ExpansionItem ei in PathProvider.Global.Expansions)
            {
                if (CutName(n, ei.Expansion)) return;
            }
            
            if (CutName(n, FileTablePaths.SaveGameFolder)) return;
            if (CutName(n, FileTablePaths.SimPEDataFolder)) return;
            if (CutName(n, FileTablePaths.SimPEFolder)) return;
            if (CutName(n, FileTablePaths.SimPEPluginFolder)) return;

            //if (Helper.IsAbsolutePath(name)) name = Helper.CompareableFileName(Helper.ToLongPathName(name));
            this.path = name;
        }

        public FileTableItemType Type
        {
            get { return type; }
            set { this.type = value; }
        }

        /// <summary>
        /// Check this to determin if this item should be used in the FileTable
        /// </summary>
        public bool Use
        {
            get { return IsAvail && !Ignore && IsUseable; }
        }

        public bool IsRecursive
        {
            get { return recursive; }
            set { recursive = value; }
        }

        public bool IsFile
        {
            get { return file; }
            set { file = value; }
        }

        public bool IsUseable
        {
            get { return ver == -1 || ver == PathProvider.Global.GameVersion; }
        }

        public int EpVersion
        {
            get { return ver; }
            set { ver = value; }
        }

        public bool IsAvail
        {
            get
            {
                if (!IsUseable) return false;
                return Exists;
            }
        }

        public bool Exists
        {
            get
            {
                if (IsFile) return System.IO.File.Exists(Name);
                else return System.IO.Directory.Exists(Name);
            }
        }

        public string Name
        {
            get
            {
                string r = GetRoot(this.type);

                if (r == null) return path;

                string p = path.Trim();
                if (p.StartsWith(Helper.PATH_SEP)) p = path.Substring(1);
                string ret = System.IO.Path.Combine(r, p);

                if (this.IsFile)
                    if (ret.EndsWith(Helper.PATH_SEP)) ret = ret.Substring(0, ret.Length - 1);
                return ret;
            }
            set { SetName(value); }
        }

        public string RelativePath
        {
            get
            {
                if (this.IsFile)
                    if (path.EndsWith(Helper.PATH_SEP)) path = path.Substring(0, path.Length - 1);
                return path;
            }
        }

        public string[] GetFiles()
        {
            string[] files;

            if (!IsUseable || !IsAvail)
            {
                files = new string[0];
            }
            else if (IsFile)
            {
                files = new string[1];
                files[0] = this.Name;
            }
            else
            {
                string n = this.Name;
                if (System.IO.Directory.Exists(n))
                    files = System.IO.Directory.GetFiles(n, "*.package");
                else files = new string[0];
            }

            return files;
        }

        public override string ToString()
        {
            string n = "";
            if (IsFile) n += "File: ";
            else if (IsRecursive) n += "RecursiveFolder: ";
            else n += "Folder: ";

            if (!IsUseable) n = "(Unused) " + n;
            else if (!IsAvail) n = "(Missing) " + n;
            n += "{" + type.ToString() + "}" + path;

            if (ver != -1) n += " (Only when GameVersion=" + ver.ToString() + ")";
            return n;
        }

    }

}
