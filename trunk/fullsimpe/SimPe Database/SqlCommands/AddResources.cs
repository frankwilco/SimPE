using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database.SqlCommands
{
    class AddResources
    {
        SQLiteCommand command;
        SQLiteTransaction trans;
        SQLiteDataAdapter adp;
        SQLiteConnection sql;
        DbCommandBuilder bld;
        SQLiteFactory fact;
        DataTable tbl;
        public AddResources(SQLiteConnection sql)
        {
            fact = new SQLiteFactory();
            
            command = sql.CreateCommand();
            this.sql = sql;
        }

        public void PrepareLoop(long fid){
            adp = new SQLiteDataAdapter();
            trans = sql.BeginTransaction();

            command.Transaction = trans;
            command.CommandText = "SELECT * FROM tgi WHERE 1 = 2";
            bld = fact.CreateCommandBuilder();
            bld.DataAdapter = adp;
            adp.SelectCommand = command;
           
            adp.InsertCommand = (SQLiteCommand)((ICloneable)bld.GetInsertCommand()).Clone();
            bld.DataAdapter = null;
            tbl = new DataTable("tgi");
            adp.Fill(tbl);
            
        }

        public void AddResourceLoop(long fid, SimPe.Packages.PackedFileDescriptor pfd, SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp)
        {
            DataRow row = tbl.NewRow();

            row[1] = pfd.Type;
            row[2] = pfd.Group;
            row[3] = pfd.SubType;
            row[4] = pfd.Instance;
            if (wrp != null) row[5] = wrp.ResourceName;
            else row[5] = "";
            row[6] = 1;

            tbl.Rows.Add(row);
        }

        public void FinishLoop()
        {
            adp.Update(tbl);
            lock (sql)
            {
                trans.Commit();
            }
        }
    }
}
