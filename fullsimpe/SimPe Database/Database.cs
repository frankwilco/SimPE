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
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database
{
    class Database
    {
        SQLiteConnection sql;
        System.IO.StreamWriter sw;


        public string DatabaseName
        {
            get
            {
                return System.IO.Path.Combine(Helper.SimPeDataPath, "cache.db3");
            }
        }

        Dictionary<uint, Performance> odict;
        List<Performance> olist;
        public Database()
        {
            sql = new SQLiteConnection("Data Source=" + DatabaseName);
            odict = new Dictionary<uint, Performance>();
            olist = new List<Performance>();
            sw = new System.IO.StreamWriter(System.IO.Path.Combine(SimPe.Helper.SimPeDataPath, "log.txt"), false);

            sql.Open();
            PrepareDatabase();
        }


        ~Database()
        {
            sql.Close();
            sw.Close();
        }
        #region Commands
        SqlCommands.CreateTable ctable;
        SqlCommands.CreateTable CreateTableCmd
        {
            get
            {
                if (ctable == null) ctable = new SimPe.Database.SqlCommands.CreateTable(sql);
                return ctable;
            }
        }
        #endregion



        #region Creat Tables
        protected bool TableExists(string name)
        {
            CreateTableCmd.TableName = name;
            SQLiteDataReader dr = CreateTableCmd.Command.ExecuteReader(CommandBehavior.SingleResult);
            bool has = dr.HasRows;
            dr.Close();
            return has;
        }

        void PrepareDatabase()
        {
            if (!TableExists("files")) CreateFilesTable();
            if (!TableExists("tgi")) CreateTGITable();
            if (!TableExists("guid")) CreateGuidTable();
            if (!TableExists("thumb")) CreateThumbTable();
            if (!TableExists("outlink")) CreateOutLinkTable();
        }

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
                CreateTable("tgi", "'rid' INTEGER PRIMARY KEY NOT NULL, 't' INTEGER  NOT NULL, 'g' INTEGER  NOT NULL, 'ihi' INTEGER  NOT NULL, 'ilo' INTEGER  NOT NULL, 'name' VARCHAR(255)  NULL, 'fid' INTEGER  NOT NULL");
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
                CreateTable("guid", "'rid' INTEGER  NOT NULL PRIMARY KEY, 'guid' INTEGER  NOT NULL");
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        void CreateOutLinkTable()
        {
            try
            {
                CreateTable("outlink", "'rid' INTEGER  NOT NULL PRIMARY KEY, 'linkedrid' INTEGER  NOT NULL");
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }

        void CreateThumbTable()
        {
            try
            {
                CreateTable("thumb", "'rid' INTEGER  UNIQUE NOT NULL PRIMARY KEY, 'img' BLOB  NULL");
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
        }
        #endregion
        public class FileList : List<string> { }
        public void LoadUpdateableFiles(FileList list, SimPe.FileTableItem fti)
        {
            if (!fti.IsUseable || fti.Ignore || !fti.IsAvail) return;
            if (fti.IsFile) list.Add(fti.Name);
            else LoadDirectory(list, fti.Name, fti.IsRecursive); 

        }

        

        /// <summary>
        /// Addsall .package files in the given directory to the cache
        /// </summary>
        /// <param name="dir">Complete name of the directory</param>
        /// <param name="rec">true, if you want to include subfolders</param>
        /// <returns>true, if some contents had to be added</returns>
        public void LoadDirectory(FileList list, string dir, bool rec)
        {
            //return false;
            string[] files = System.IO.Directory.GetFiles(dir, "*.package");
            
            foreach (string file in files)
            {
                list.Add(file);
            }

            if (rec)
            {
                files = System.IO.Directory.GetDirectories(dir);
                foreach (string d in files)
                    LoadDirectory(list, dir, true);
            }
        }

        class PerformanceTotalCompare : IComparer<Performance>
        {
            #region IComparer<Performance> Members

            public int Compare(Performance x, Performance y)
            {
                if (x.Total() > y.Total()) return 1;
                if (x.Total() < y.Total()) return -1;
                return 0;
            }

            #endregion
        }

        class PerformanceAvgCompare : IComparer<Performance>
        {
            #region IComparer<Performance> Members

            public int Compare(Performance x, Performance y)
            {
                if (x.Avarage() > y.Avarage()) return 1;
                if (x.Avarage() < y.Avarage()) return -1;
                return 0;
            }

            #endregion
        }


        class Performance : IComparable<Performance>
        {
            List<TimeSpan> spans;
            uint t;
            public Performance(uint type)
            {
                spans = new List<TimeSpan>();
                t = type;
            }

            public void Add(TimeSpan ts)
            {
                spans.Add(ts);
            }

            public TimeSpan Total()
            {
                TimeSpan ts = new TimeSpan(0);
                foreach (TimeSpan t in spans)
                    ts += t;

                return ts;
            }

            public TimeSpan Avarage()
            {
                return new TimeSpan(Total().Ticks / Count());
            }

            public int Count()
            {
                return spans.Count;
            }

            public override string ToString()
            {
                SimPe.Data.TypeAlias ta = Data.MetaData.FindTypeAlias(t);
                return ta.shortname + ": Calls= " + Count() + ", Overall= " + Total().ToString() + ", Avg= " + Avarage().ToString();
            }



            #region IComparable<Performance> Members

            public int CompareTo(Performance other)
            {
                if (Total() > other.Total()) return 1;
                if (Total() < other.Total()) return -1;
                return 0;
            }

            #endregion
        }



        /// <summary>
        /// Adds the given .package file to the cache
        /// </summary>
        /// <param name="flname">Complete name of the .package file</param>
        /// <returns>true, if the contents had to get updated</returns>
        public bool AddPackageFile(string flname)
        {
            if (!System.IO.File.Exists(flname)) return false;
            DateTime filemod = System.IO.File.GetLastWriteTime(flname);
            bool mod = false;

            SqlCommands.LoadFileRow lfr = new SimPe.Database.SqlCommands.LoadFileRow(sql);
            lfr.FileName = flname;

            SQLiteDataReader dr = AddPackageWhenNew(ref filemod, ref mod, lfr);
            long fid = UpdatePackageModDate(flname, ref filemod, ref mod, lfr, dr);

            if (mod)
            {
                SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(flname);
                SqlCommands.AddResources ar = new SimPe.Database.SqlCommands.AddResources(sql);
                ar.PrepareLoop(fid);
                Dictionary<uint, Performance> dict = new Dictionary<uint, Performance>();
                List<Performance> list = new List<Performance>();

                foreach (SimPe.Packages.PackedFileDescriptor pfd in pkg.Index)
                {
                    Performance p, op;
                    if (!dict.ContainsKey(pfd.Type))
                    {
                        p = new Performance(pfd.Type);
                        list.Add(p);
                        dict[pfd.Type] = p;
                    }
                    else p = dict[pfd.Type];

                    if (!odict.ContainsKey(pfd.Type))
                    {
                        op = new Performance(pfd.Type);
                        olist.Add(op);
                        odict[pfd.Type] = op;
                    }
                    else op = odict[pfd.Type];
                    DateTime start = DateTime.Now;

                    SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp;
                    if (pfd.Type == Data.MetaData.LIFO || pfd.Type == 0x4E524546 /*NREF*/ || pfd.Type == Data.MetaData.GMDC || pfd.Type == Data.MetaData.ANIM)
                        wrp = null;
                    else if (pfd.Type == Data.MetaData.LIFO || pfd.Type == Data.MetaData.GMDC)
                        wrp = new SimPe.Plugin.GenericRcol(null, true);
                    else
                        wrp = SimPe.FileTable.WrapperRegistry.FindHandler(pfd.Type);

                    if (wrp != null)
                    {
                        lock (wrp)
                        {
                            wrp.ProcessData(pfd, pkg, true);
                            ar.AddResourceLoop(fid, pfd, wrp);

                            wrp.Dispose();
                        }
                        wrp = null;
                    }
                    else ar.AddResourceLoop(fid, pfd, null);

                    TimeSpan runtime = DateTime.Now - start;
                    p.Add(runtime);
                    op.Add(runtime);
                }
                ShowPerformance(list);
                list.Clear();
                list = null;

                dict.Clear();
                dict = null;

                ar.FinishLoop();
                pkg.Close();
            }

            lfr = null;
            return mod;
        }

        public void Result()
        {
            sw.WriteLine(); sw.WriteLine(); sw.WriteLine();
            sw.WriteLine("---------------------------------------OVERALL---------------------------------------");
            ShowPerformance(olist);
        }

        private void ShowPerformance(List<Performance> list)
        {
            TimeSpan total = new TimeSpan(0);
            PerformanceTotalCompare ptc = new PerformanceTotalCompare();
            list.Sort(ptc);
            foreach (Performance p in list)
                sw.WriteLine(p.ToString());

            sw.WriteLine("------------------------------------------------------");
            PerformanceAvgCompare pac = new PerformanceAvgCompare();
            list.Sort(pac);
            foreach (Performance p in list)
            {
                sw.WriteLine(p.ToString());
                total += p.Total();
            }
            sw.WriteLine();
            sw.WriteLine("Total: " + total.ToString());
            Console.WriteLine("    Total: " + total.ToString());

           

            sw.Flush();
        }

        private long UpdatePackageModDate(string flname, ref DateTime filemod, ref bool mod, SqlCommands.LoadFileRow lfr, SQLiteDataReader dr)
        {
            if (dr.HasRows)
            {
                dr.Read();
                Console.WriteLine(dr[2]);
                long fid = (long)dr[0];
                DateTime modified = (DateTime)dr[2];


                //if (filemod > modified)
                {
                    sw.WriteLine(); sw.WriteLine();
                    sw.WriteLine("--> " + flname + " ---------------------------------------------------------------");
                    Console.WriteLine("--> " + flname + " ---------------------------------------------------------------");
                    mod = true;

                    SqlCommands.UpdateFileModDate ufmd = new SimPe.Database.SqlCommands.UpdateFileModDate(sql);
                    ufmd.FileName = lfr.FileName;
                    ufmd.Modified = filemod;
                    //ufmd.Command.ExecuteNonQuery();

                    SqlCommands.RemoveResources rr = new SimPe.Database.SqlCommands.RemoveResources(sql);
                    rr.FileId = fid;
                    rr.CleanupPackageResources();
                }

                dr.Close();
                return fid;
            }

            dr.Close();
            return 0;
        }

        private SQLiteDataReader AddPackageWhenNew(ref DateTime filemod, ref bool mod, SqlCommands.LoadFileRow lfr)
        {
            SQLiteDataReader dr = lfr.Command.ExecuteReader(CommandBehavior.SingleResult);
            if (!dr.HasRows)
            {
                dr.Close();

                SqlCommands.AddFileRow afr = new SimPe.Database.SqlCommands.AddFileRow(sql);
                afr.FileName = lfr.FileName;
                afr.Modified = filemod;
                afr.Command.ExecuteNonQuery();
                dr = lfr.Command.ExecuteReader(CommandBehavior.SingleResult);
                mod = true;
            }
            return dr;
        }

        public static string ToTimeStamp(DateTime tm)
        {
            return tm.ToString("s", System.Globalization.DateTimeFormatInfo.InvariantInfo);
        }

        public static string Now()
        {
            return ToTimeStamp(DateTime.Now);
        }


    }
}
