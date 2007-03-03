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
using System.Threading;

namespace SimPe.Database
{
    class DatabaseSyncThread
    {
        int Running = 0;
        public void WaitForFinish()
        {
            while (Running > 0)
            {
                Thread.CurrentThread.Join(1000);
                System.Windows.Forms.Application.DoEvents();
            }

        }

        public void Stop()
        {
            lock (list)
            {
                list.Clear();
            }
            WaitForFinish();

        }

        Database db;
        Database.FileList list;
        Thread[] threads;
        public DatabaseSyncThread(Database db, Database.FileList list)
        {
            this.db = db;
            this.list = list;

            threads = new Thread[Math.Max(1, SimPe.Helper.WindowsRegistry.SortProcessCount / 4)];
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(StartThread));
                threads[i].Name = "Sync " + i;
                threads[i].Start();
            }
            while (Running==0)
                Thread.CurrentThread.Join(100);
        }

        protected void StartThread()
        {
            Running++;
            do
            {
                string flname;
                lock (list)
                {
                    if (list.Count == 0) break;
                    flname = list[0];
                    list.RemoveAt(0);
                }

                db.AddPackageFile(flname);
            } while (true);
            Running--;
        }

    }
}