/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
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
using System.Collections.Generic;
using System.Text;
using SQLite.NET;
using System.Data.SQLite;

namespace SimPe.Database
{
    class Database 
    {        
        System.Data.SQLite.SQLiteConnection sql;
        internal static List<uint> CachedTypes = SimPe.Data.MetaData.CachedFileTypes;
        public Database()
        {
            System.Data.SQLite.SQLiteConnectionStringBuilder sb = new System.Data.SQLite.SQLiteConnectionStringBuilder();
            sb.DataSource = System.IO.Path.Combine(SimPe.Helper.SimPeDataPath, "cache.db");
            sql = new System.Data.SQLite.SQLiteConnection(sb.ConnectionString);

            lastrowid = 0;
            PrepareDatabase();

            sql.Update += new SQLiteUpdateEventHandler(sql_Update);
        }

        long lastrowid;
        void sql_Update(object sender, UpdateEventArgs e)
        {
            lastrowid = e.RowId;
        }

        ~Database()
        {
            sql.Update -= new SQLiteUpdateEventHandler(sql_Update);
            sql.Close();
        }

        void PrepareDatabase()
        {
            sql.Open();
            ArrayList tables = new ArrayList();
            using (SQLiteCommand mycommand = new SQLiteCommand(sql))
            {
                mycommand.CommandText = String.Format("SELECT name FROM sqlite_master WHERE type = 'table'");
                SQLiteDataReader res = mycommand.ExecuteReader();
                while (res.Read())
                {
                    tables.Add(res["name"].ToString());
                }
            }

            
            if (!tables.Contains("files")) CreateFilesTable();
            if (!tables.Contains("tgi")) CreateTGITable();
            if (!tables.Contains("guid")) CreateGuidTable();
            if (!tables.Contains("thumbs")) CreateThumbsTable();
        }

        #region Creat Tables
        void CreateTable(string name, string s)
        {
            using (SQLiteCommand mycommand = new SQLiteCommand(sql))
            {
                mycommand.CommandText = String.Format("CREATE TABLE '" + name + "' (" + s + ")");
                mycommand.ExecuteNonQuery();                
            }
        }
        void CreateFilesTable()
        {
            try
            {
                CreateTable("files", "'fid' INTEGER NOT NULL PRIMARY KEY, 'filename' VARCHAR(255)  NOT NULL, 'modified' TIMESTAMP  NOT NULL");                
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        void CreateTGITable()
        {
            try
            {
                CreateTable("tgi", "'id' INTEGER PRIMARY KEY NOT NULL, 't' INTEGER  NOT NULL, 'g' INTEGER  NOT NULL, 'ihi' INTEGER  NOT NULL, 'ilo' INTEGER  NOT NULL, 'name' VARCHAR(255)  NULL, 'fid' INTEGER  NOT NULL");                
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        void CreateGuidTable()
        {
            try
            {
                CreateTable("guid", "'id' INTEGER  NOT NULL PRIMARY KEY, 'guid' INTEGER  NOT NULL");
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        void CreateThumbsTable()
        {
            try
            {
                CreateTable("thumbs", "'id' INTEGER  UNIQUE NOT NULL PRIMARY KEY, 'img' BLOB  NULL");                
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }
        #endregion

        public static string ToTimeStamp(DateTime tm)
        {
            return tm.ToString("u");
        }

        public static string Now()
        {
            return ToTimeStamp(DateTime.Now);
        }

        public SQLiteCommand CreateCommand(string cmd, List<SQLiteParameter>param)
        {
            SQLiteCommand mycommand = new SQLiteCommand(sql);
            
            mycommand.CommandText = cmd;
            foreach (SQLiteParameter p in param)
                mycommand.Parameters.Add(p);

            return mycommand;
        }

        public List<Dictionary<string, object>> Query(string s)
        {
            return GetResultTable(QueryNr(s));
        }

        public SQLiteDataReader QueryNr(string s)
        {
            //Console.WriteLine(s);
            try
            {
                lock (sql)
                {
                    SQLiteCommand mycommand = new SQLiteCommand(sql);
                    mycommand.CommandText = s;
                    return mycommand.ExecuteReader();                    
                }
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }

            return null;
        }

        List<Dictionary<string, object>> GetResultTable(SQLiteDataReader res)
        {
            List<Dictionary<string, object>> list = new List<Dictionary<string, object>>();
            if (res != null)
            {
                List<string> names = new List<string>();
                for (int i=0; i<res.FieldCount; i++)
                    names.Add(res.GetName(i));
                while (res.Read())
                {
                    Dictionary<string, object> map = new Dictionary<string,object>();
                    for (int i = 0; i < res.FieldCount; i++)
                        map[names[i]] = res.GetValue(i);
                    list.Add(map);
                }
            }

            return list;
        }

        public bool FileItemChanged(SimPe.FileTableItem f)
        {
            if (!f.IsUseable || !f.IsAvail || f.Ignore) return false;
            if (f.IsFile) return FileChanged(f.Name);
            else return FolderChanged(f.Name, f.IsRecursive);
            
        }

        public bool FolderChanged(string dir, bool rec)
        {
            bool res = false;
            string[] files = System.IO.Directory.GetFiles(dir, "*.package");
            foreach (string file in files)            
                res |= FileChanged(file);

            if (rec)
            {
                files = System.IO.Directory.GetDirectories(dir);
                foreach (string file in files)
                    res |= FolderChanged(file, true);
            }

            return res;
        }

        public bool FileChanged(string flname)
        {
            System.IO.FileInfo fi = new System.IO.FileInfo(flname);
            flname = Helper.CompareableFileName(flname);

            List<Dictionary<string, object>> tables = Query("SELECT * FROM files WHERE filename = " + SQLiteClient.Quote(flname));

            int fid = -1;
            if (tables.Count == 0)
            {
                fid = AddFile(flname);                
            }
            else
            {
                DateTime tm = DateTime.Parse(tables[0]["modified"].ToString());
                if (tm < fi.LastWriteTime) fid = Convert.ToInt32(tables[0]["fid"]);
            }
           
            if (fid > 0)
            {
                SyncFileContent(fid, flname, fi);
                return true;
            }

            return false;
        }

        int AddFile(string flname)
        {
            QueryNr("INSERT INTO files (filename, modified) VALUES (" + SQLiteClient.Quote(flname) + ", " + SQLiteClient.Quote("1970-01-01 00:00:00") + ")");
            return Last();  
        }

        void SyncFileContent(int fid, string flname, System.IO.FileInfo fi)
        {
            DatabaseSyncThread dst = new DatabaseSyncThread(this, fid, flname, fi);                   
        }

        internal void CleanupFileTgi(int fid){
            QueryNr("DELETE FROM tgi WHERE fid=" + fid);
        }

        internal SQLiteCommand CreateStorePfdCommand()
        {
            List<SQLiteParameter> pars = new List<SQLiteParameter>();
            pars.Add(new SQLiteParameter("t"));
            pars.Add(new SQLiteParameter("g"));
            pars.Add(new SQLiteParameter("ihi"));
            pars.Add(new SQLiteParameter("ilo"));
            pars.Add(new SQLiteParameter("name"));
            pars.Add(new SQLiteParameter("fid"));

            return CreateCommand("INSERT INTO tgi (t, g, ihi, ilo, name, fid) VALUES(?, ?, ?, ?, ?, ?);", pars);
        }

        internal void StorePfd(SQLiteCommand cmd, int fid, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, string name)
        {
            cmd.Parameters[0].Value = (Int32)pfd.Type;
            cmd.Parameters[1].Value = (Int32)pfd.Group;
            cmd.Parameters[2].Value = (Int32)pfd.SubType;
            cmd.Parameters[3].Value = (Int32)pfd.Instance;
            cmd.Parameters[4].Value = name;
            cmd.Parameters[5].Value = fid;
            
            cmd.ExecuteNonQuery();
            
        }

        public SQLiteTransaction BeginTransaction()
        {
            return sql.BeginTransaction();            
        }

        public List<Dictionary<string, object>> GetFileContent(int fid)
        {
            List<Dictionary<string, object>> res = Query("SELECT * FROM tgi WHERE fid=" + fid);
            return res;
        }

        public List<Dictionary<string, object>> GetFileContent(int fid, uint type)
        {

            List<Dictionary<string, object>> res = Query("SELECT * FROM tgi WHERE fid=" + fid + " AND t=" + type);
            return res;
        }

        internal SQLiteCommand CreateStoreGuidCommand()
        {
            List<SQLiteParameter> pars = new List<SQLiteParameter>();
            pars.Add(new SQLiteParameter("id1"));
            pars.Add(new SQLiteParameter("id2"));
            pars.Add(new SQLiteParameter("guid"));

            return CreateCommand("DELETE FROM guid WHERE id=?; INSERT INTO guid (id, guid) VALUES (?, ?)", pars);
        }

        internal void StoreGuid(SQLiteCommand cmd, int id, uint guid)
        {
            cmd.Parameters[0].Value = id;
            cmd.Parameters[1].Value = id;
            cmd.Parameters[2].Value = (Int32)guid;

            cmd.ExecuteNonQuery();
        }

        internal SimPe.Interfaces.Files.IPackedFileDescriptor LoadPfd(SimPe.Interfaces.Files.IPackageFile pkg, Hashtable ht)
        {
            SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(
                Convert.ToUInt32(ht["t"]),
                Convert.ToUInt32(ht["g"]),
                Convert.ToUInt32(ht["ihi"]),
                Convert.ToUInt32(ht["ilo"])
            );

            return pfd;
        }

        internal int Last()
        {

            return  (int)lastrowid;
        }
    }
}
