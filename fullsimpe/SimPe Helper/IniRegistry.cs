/***************************************************************************
 *   Copyright (C) 2007 by Ambertation                                     *
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
using System.IO;
using System.Text;

namespace SimPe
{
    
    /// <summary>
    /// Simple "[section name]", "key name=value" ini file reader/writer.
    /// Any comments and blank lines read are lost if the file is written.
    /// </summary>
    public class IniRegistry : IEnumerable<String>, IEnumerable<IniRegistry.SectionContent>
    {
        class Sectionlist : Dictionary<String, SectionContent> {}
        

        bool fileIsReadonly = true;
        string iniFile = null;
        Sectionlist reg = null;
        public IniRegistry(String inifile, bool ro) : this(inifile) { fileIsReadonly = ro; }
        public IniRegistry(String inifile) : this(new StreamReader(inifile)) { this.iniFile = inifile; }
        public IniRegistry(StreamReader sr)
        {
            reg = new Sectionlist();
            string keyBase = "";
            string keyName = "";
            string keyValue = "";
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().Trim();
                if (line.Length == 0 || line.StartsWith(";")) continue;

                //remove comment
                int pos = line.IndexOf(';');
                if (pos > 0) line = line.Substring(0, pos).Trim(); ;
                
                if (line.StartsWith("["))
                {
                    if (line.EndsWith("]"))
                    {
                        keyBase = line.Substring(1, line.Length - 2).Trim();
                        reg[keyBase] = new SectionContent();
                        continue;
                    }
                    // fall through!
                }
                else if (line.Contains("="))
                {
                    string[] a = line.Split(new char[] { '=' }, 2);
                    keyName = a[0].Trim().ToLower();
                    keyValue = a[1].Trim().ToLower();
                    reg[keyBase].SetValue(keyName, keyValue, true);
                    continue;
                }
                throw new Exception("Invalid inifile line: " + line);
            }
        }

        public String IniFile { get { return iniFile; } set { iniFile = value; } }

        public bool Flush()
        {
            if (fileIsReadonly) return false;
            if (iniFile.Length.Equals(0)) return false;
            if (!File.Exists(iniFile)) return false;

            try
            {
                StreamWriter sw = new StreamWriter(iniFile);
                bool wantBlank = false;
                foreach (string section in reg.Keys)
                {
                    if (wantBlank) sw.WriteLine("");
                    sw.WriteLine("[" + section + "]");
                    wantBlank = true;
                    foreach (string key in reg[section].Keys)
                        sw.WriteLine(key + "=" + reg[section].GetValue(key));
                }
                sw.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        static bool KeyCompare(string k1, string k2)
        {
            return k1.Trim().ToLower() == k2.Trim().ToLower();
        }

        #region Sections
        public SectionContent CreateSection(string section)
        {
            return Section(section, true);
        }

        public SectionContent Section(string section)
        {
            return Section(section, true);
        }

        public SectionContent Section(string section, bool create)
        {
            foreach (string k in reg.Keys)
            {
                if (KeyCompare(section, k))
                {
                    return reg[k];
                }
            }

            if (!create) return null;

            SectionContent kl = new SectionContent();
            reg.Add(section, kl);

            return kl;
        }

        public bool ContainsSection(string section)
        {
            SectionContent kl = Section(section, false);
            return kl != null;
        }

        public bool RemoveSection(string section)
        {
            string rm = null;
            foreach (string s in reg.Keys)
            {
                if (KeyCompare(s, section))
                {
                    rm = s;
                    break;
                }
            }
            if (rm != null)
            {
                reg.Remove(rm);
                return true;
            }
            return false;
        }

        public void ClearSection(string section)
        {
            SectionContent kl = Section(section, false);
            if (kl != null) kl.Clear();
        }

        public Sectionlist.KeyCollection Sections
        {
            get { return reg.Keys; }
        }

        public SectionContent this [string section] {
            get { return Section(section, false); }
        }
        public string this[string section, string key]
        {
            get { return GetValue(section, key); }
            set { SetValue(section, key, value, true); }
        }
        #endregion

        #region keys
        public class SectionContent : IEnumerable<String>{
            class List : Dictionary<String, String> {}
            
            List list;
            internal SectionContent() { list = new List(); }

            public void CreateKey(string key) { SetValue(key, ""); }
            public void SetValue(string key, string value)
            {
                SetValue(key, value, true);
            }

            public void SetValue(string key, string value, bool create)
            {
                if (!ContainsKey(key)) list.Add(key, value);
                else if (create)
                {
                    string kv = null;
                    foreach (string s in list.Keys)
                    {
                        if (KeyCompare(s, key))
                        {
                            kv = s;
                            break;
                        }
                    }

                    if (kv != null) list[kv] = value;
                }
            }

            public List.KeyCollection Keys
            {
                get { return list.Keys; }
            }

            public string GetValue(string key)
            {
                return GetValue(key, null);
            }

            public string GetValue(string key, string def)
            {
                foreach (string lk in list.Keys)
                {
                    if (KeyCompare(lk, key))
                    {
                       return list[lk];
                    }
                }
                return def;
            }

            public bool ContainsKey(string key)
            {
                foreach (string lk in list.Keys)
                {
                    if (KeyCompare(lk, key))
                    {
                        return true;
                    }
                }

                return false;
            }

            public bool RemoveKey(string key)
            {
                string rm = null;
                foreach(string s in list.Keys)
                {
                    if (KeyCompare(s, key))
                    {
                        rm = s;
                    }
                }

                if (rm != null)
                {
                    list.Remove(rm);
                    return true;
                }
                return false;
            }

            public void Clear()
            {
                list.Clear();
            }



            public string this[string key]
            {
                get { return GetValue(key); }
                set { SetValue(key, value, true); }
            }

            #region IEnumerable<string> Member

            public IEnumerator<string> GetEnumerator()
            {
                return list.Keys.GetEnumerator();
            }

            #endregion

            #region IEnumerable Member

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return list.GetEnumerator();
            }

            #endregion

         

            #region IDisposable Member

            public void Dispose()
            {
                list.Clear();
            }

            #endregion
        }
        #endregion

        #region direct key access
        public string GetValue(string section, string key)
        {
            return GetValue(section, key, null);
        }

        public string GetValue(string section, string key, string def)
        {
            SectionContent kl = Section(section, false);
            if (kl != null)
            {
                return kl.GetValue(key, def);
            }
            return def;
        }

        public void SetValue(string section, string key, string value)
        {
            SetValue(section, key, value, true);
        }

        public void SetValue(string section, string key, string value, bool create)
        {
            SectionContent kl = Section(section, true);
            if (kl != null)
            {
                kl.SetValue(key, value, create);
            }
        }
        #endregion

        #region IEnumerable<string> Member

        public IEnumerator<string> GetEnumerator()
        {
            return reg.Keys.GetEnumerator();
        }

        #endregion

        #region IEnumerable Member

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return reg.GetEnumerator();
        }

        #endregion

        #region IEnumerable<Keylist> Member

        IEnumerator<IniRegistry.SectionContent> IEnumerable<IniRegistry.SectionContent>.GetEnumerator()
        {
            return reg.Values.GetEnumerator();
        }

        #endregion
    }
}
