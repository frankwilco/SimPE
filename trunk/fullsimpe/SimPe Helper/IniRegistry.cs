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
    public class IniRegistry : IDictionary<String, Dictionary<String, String>>
    {
        bool fileIsReadonly = true;
        string iniFile = null;
        Dictionary<String, Dictionary<String, String>> reg = null;
        public IniRegistry(String inifile, bool ro) : this(inifile) { fileIsReadonly = ro; }
        public IniRegistry(String inifile) : this(new StreamReader(inifile)) { this.iniFile = inifile; }
        public IniRegistry(StreamReader sr)
        {
            string keyBase = "";
            string keyName = "";
            string keyValue = "";
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine().Trim();
                if (line.Length == 0 || line.StartsWith(";")) continue;
                if (line.StartsWith("["))
                {
                    if (line.EndsWith("]"))
                    {
                        keyBase = line.Substring(2, line.Length - 2);
                        reg[keyBase] = new Dictionary<string, string>();
                        continue;
                    }
                    // fall through!
                }
                else if (line.Contains("="))
                {
                    string[] a = line.Split(new char[] { '=' }, 2);
                    keyName = a[0].Trim();
                    keyValue = a[1].Trim();
                    reg[keyBase].Add(keyName, keyValue);
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
                        sw.WriteLine(key + "=" + reg[section][key]);
                }
                sw.Close();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public void Add(string section, string key, string value)
        {
            if (!reg.ContainsKey(section)) reg.Add(section, new Dictionary<string, string>());
            if (reg[section].ContainsKey(key)) reg[section][key] = value;
            else reg[section].Add(key, value);
        }
        public bool ContainsKey(string section, string key) { return reg.ContainsKey(section) && reg[section].ContainsKey(key); }
        public Dictionary<string, string>.KeyCollection SectionKeys(string section) { return reg.ContainsKey(section) ? null : reg[section].Keys; }
        public bool Remove(string section, string key) { return reg.ContainsKey(section) ? false : reg[section].Remove(key); }
        public bool TryGetValue(string section, string key, out string value)
        {
            if (!reg.ContainsKey(section)) reg.Add(section, new Dictionary<string, string>());
            return reg[section].TryGetValue(key, out value);
        }
        public Dictionary<string, string>.ValueCollection SectionValues(string section) { return reg.ContainsKey(section) ? null : reg[section].Values; }
        public string this[string section, string key]
        {
            get { return reg.ContainsKey(section) ? null : reg[section][key]; }
            set
            {
                if (!reg.ContainsKey(section)) reg.Add(section, new Dictionary<string, string>());
                reg[section][key] = value;
            }
        }
        public Dictionary<string, string>.Enumerator GetEnumerator(string section)
        {
            if (!reg.ContainsKey(section)) throw new ArgumentOutOfRangeException("section", "not found in inifile");
            return reg[section].GetEnumerator();
        }

        #region IDictionary<string,Dictionary<string,string>> Members

        public void Add(string key, Dictionary<string, string> value) { reg.Add(key, value); }
        public bool ContainsKey(string key) { return reg.ContainsKey(key); }
        ICollection<string> IDictionary<string, Dictionary<string, string>>.Keys { get { return reg.Keys; } }
        public bool Remove(string key) { return reg.Remove(key); }
        public bool TryGetValue(string key, out Dictionary<string, string> value) { return reg.TryGetValue(key, out value); }
        ICollection<Dictionary<string, string>> IDictionary<string, Dictionary<string, string>>.Values { get { return reg.Values; } }
        public Dictionary<string, string> this[string key] { get { return reg[key]; } set { reg[key] = value; } }

        #endregion

        #region ICollection<KeyValuePair<string,Dictionary<string,string>>> Members

        public void Add(KeyValuePair<string, Dictionary<string, string>> item) { reg.Add(item.Key, item.Value); }
        public void Clear() { reg.Clear(); }
        public bool Contains(KeyValuePair<string, Dictionary<string, string>> item) { return reg.ContainsKey(item.Key) && reg[item.Key].Equals(item.Value); }
        public void CopyTo(KeyValuePair<string, Dictionary<string, string>>[] array, int arrayIndex)
        {
            int i = 0;
            foreach (string key in reg.Keys)
            {
                array[arrayIndex + i] = new KeyValuePair<string, Dictionary<string, string>>(key, reg[key]);
                i++;
            }
        }
        public int Count { get { return reg.Count; } }
        public bool IsReadOnly { get { return false; } }
        public bool Remove(KeyValuePair<string, Dictionary<string, string>> item)
        {
            if (!reg.ContainsKey(item.Key) || !reg[item.Key].Equals(item.Value)) return false;
            return reg.Remove(item.Key);
        }

        #endregion

        #region IEnumerable<KeyValuePair<string,Dictionary<string,string>>> Members

        public IEnumerator<KeyValuePair<string, Dictionary<string, string>>> GetEnumerator() { return reg.GetEnumerator(); }

        #endregion

        #region IEnumerable Members

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { return reg.GetEnumerator(); }

        #endregion
    }
}
