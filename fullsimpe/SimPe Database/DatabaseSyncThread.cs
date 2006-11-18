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
    class DatabaseSyncThread : Ambertation.Threading.StoppableThread
    {
        internal static int Running = 0;
        public static void WaitForFinish()
        {
            while (DatabaseSyncThread.Running > 0)
                System.Threading.Thread.CurrentThread.Join(100);     
        }

        Database db;
        int fid;
        string flname;
        System.IO.FileInfo fi;
        public DatabaseSyncThread(Database parent, int fid, string flname, System.IO.FileInfo fi)
        {
            db = parent;
            this.fid = fid;
            this.flname = flname;
            this.fi = fi;


            this.ExecuteThread(System.Threading.ThreadPriority.Normal, "sync " + flname, true);
            
        }

        protected override void StartThread()
        {
            while (Running > 4) System.Threading.Thread.CurrentThread.Join(100);

            Console.WriteLine("Started sync Thread for " + flname);
            Running++;
            SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(flname);
            using (SQLiteTransaction transaction = db.BeginTransaction())
            {
                db.CleanupFileTgi(fid);


                Wait.SubStart(pkg.Index.Length);
                Wait.Message = flname;
                int ct = 0;
                bool done = true;

                using (SQLiteCommand cmd = db.CreateStorePfdCommand())
                {
                    cmd.Prepare();
                    using (SQLiteCommand cmdguid = db.CreateStoreGuidCommand())
                    {
                        cmdguid.Prepare();
                        foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index)
                        {
                            string name = null;
                            object guid = null;
                            ct++;
                            if (!Database.CachedTypes.Contains(pfd.Type)) continue;


                            if (pfd.Type == Data.MetaData.OBJD_FILE)
                            {
                                SimPe.PackedFiles.Wrapper.ExtObjd objd = new SimPe.PackedFiles.Wrapper.ExtObjd();
                                objd.ProcessData(pfd, pkg);

                                guid = objd.Guid;
                                name = objd.FileName;
                            }
                            else if (SimPe.Data.MetaData.RcolList.Contains(pfd.Type))
                            {
                                SimPe.Plugin.GenericRcol rcol = new SimPe.Plugin.GenericRcol(SimPe.FileTable.ProviderRegistry, true);
                                rcol.ProcessData(pfd, pkg);

                                name = rcol.ResourceName;
                            }


                            db.StorePfd(cmd, fid, pfd, name);                            
                            int id = db.Last();
                            if (guid != null) db.StoreGuid(cmdguid, id, (uint)guid);


                            Wait.Progress = ct;
                            if (this.HaveToStop)
                            {
                                done = false;
                                break;
                            }
                        }
                    }
                }
                Wait.SubStop();
                pkg.Close();

                if (done)
                {
                    db.QueryNr("UPDATE files SET modified=" + SQLiteClient.Quote(Database.ToTimeStamp(fi.LastWriteTime)) + " WHERE fid=" + fid);
                    transaction.Commit();
                }
                else
                {
                    transaction.Rollback();
                }
            }
            Running--;
            Console.WriteLine("Stopped sync Thread for " + flname);
        }

    }
}