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

namespace SimPe.Database
{
    class Database 
    {        
        SQLiteClient sql;
        internal static List<uint> CachedTypes = SimPe.Data.MetaData.CachedFileTypes;
        public Database()
        {
            sql = new SQLite.NET.SQLiteClient(System.IO.Path.Combine(Helper.SimPeDataPath, "cache.db"));
            PrepareDatabase();

            
        }

        ~Database()
        {
            sql.Close();
        }

        void PrepareDatabase()
        {
            ArrayList tables = sql.GetColumn("SELECT name FROM sqlite_master WHERE type = 'table'");

            if (!tables.Contains("files")) CreateFilesTable();
            if (!tables.Contains("tgi")) CreateTGITable();
            if (!tables.Contains("guid")) CreateGuidTable();
            if (!tables.Contains("thumbs")) CreateThumbsTable();
        }

        #region Creat Tables
        void CreateFilesTable()
        {
            try
            {
                SQLiteResultSet res = QueryNr("CREATE TABLE 'files' ('fid' INTEGER NOT NULL PRIMARY KEY, 'filename' VARCHAR(255)  NOT NULL, 'modified' TIMESTAMP  NOT NULL)");
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
                SQLiteResultSet res = QueryNr("CREATE TABLE 'tgi' ('id' INTEGER PRIMARY KEY NOT NULL, 't' INTEGER  NOT NULL, 'g' INTEGER  NOT NULL, 'ihi' INTEGER  NOT NULL, 'ilo' INTEGER  NOT NULL, 'name' VARCHAR(255)  NULL, 'fid' INTEGER  NOT NULL)");                
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
                SQLiteResultSet res = QueryNr("CREATE TABLE 'guid' ('id' INTEGER  NOT NULL PRIMARY KEY, 'guid' INTEGER  NOT NULL)");
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
                SQLiteResultSet res = QueryNr("CREATE TABLE 'thumbs' ('id' INTEGER  UNIQUE NOT NULL PRIMARY KEY, 'img' BLOB  NULL)");
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

        public List<Hashtable> Query(string s)
        {
            return GetResultTable(QueryNr(s));
        }

        public SQLiteResultSet QueryNr(string s)
        {
            Console.WriteLine(s);
            try
            {
                lock (sql)
                {
                    SQLiteResultSet res = sql.Execute(s);
                    return res;
                }
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }

            return null;
        }

        List<Hashtable> GetResultTable(SQLiteResultSet res)
        {
            List<Hashtable> list = new List<Hashtable>();
            if (res != null)
            {
                for (int i = 0; i < res.Rows.Count; i++)
                    list.Add(res.GetRowHash());
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

            List<Hashtable> tables = Query("SELECT * FROM files WHERE filename = " + SQLiteClient.Quote(flname));

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
            return sql.LastInsertID();
        }

        void SyncFileContent(int fid, string flname, System.IO.FileInfo fi)
        {
            DatabaseSyncThread dst = new DatabaseSyncThread(this, fid, flname, fi);                   
        }

        internal void CleanupFileTgi(int fid){
            QueryNr("DELETE FROM tgi WHERE fid=" + fid);
        }
        
        internal void StorePfd(int fid, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, string name)
        {
            string q = "INSERT INTO tgi (t, g, ihi, ilo, name, fid) VALUES(";
            q += pfd.Type + ", ";
            q += pfd.Group + ", ";
            q += pfd.SubType + ", ";
            q += pfd.Instance + ", ";
            if (name == null) q += "NULL, ";
            else q += SQLiteClient.Quote(name) + ", ";
            q += fid + " ";
            q += ");\n";
                        
            QueryNr(q);
        }

        public void BeginTransaction()
        {
            QueryNr("BEGIN TRANSACTION mytrans");
        }

        public void EndTransaction()
        {
            QueryNr("END TRANSACTION mytrans");
        }

        public void CommitTransaction()
        {
            QueryNr("COMMIT TRANSACTION mytrans");          
        }

        public void RollbackTransaction()
        {
            QueryNr("ROLLBACK TRANSACTION mytrans");
        }

        public List<Hashtable> GetFileContent(int fid){
            List<Hashtable> res = Query("SELECT * FROM tgi WHERE fid=" + fid);
            return res;
        }

        public List<Hashtable> GetFileContent(int fid, uint type)
        {
            
            List<Hashtable> res = Query("SELECT * FROM tgi WHERE fid=" + fid+" AND t="+type);
            return res;
        }

        internal void StoreGuid(int id, uint guid)
        {
            QueryNr("DELETE FROM guid WHERE id=" + id);
            QueryNr("INSERT INTO guid (id, guid) VALUES (" + id + ", " + guid + ")");            
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
            return sql.LastInsertID();
        }
    }
}
