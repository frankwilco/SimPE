using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database.SqlCommands
{
    class RemoveResources : CommandBase
    {
        class RemoveResource : CommandBase
        {
            public RemoveResource(SQLiteConnection sql, string table)
            : base(sql, "DELETE FROM "+table+" WHERE rid=@rid;")
            {
            }

            SQLiteParameter rid;
            public long ResourceId
            {
                get { return (long)rid.Value; }
                set { rid.Value = value; }
            }

            protected override void CreatParameters()
            {
                rid = Command.Parameters.AddWithValue("@rid", 0);
            }
        }

        RemoveResource rr_tgi;
        public RemoveResources(SQLiteConnection sql)
            : base(sql, "SELECT rid FROM tgi WHERE fid=@fid;")
        {
            rr_tgi = new RemoveResource(sql, "tgi");
        }

        SQLiteParameter fid;
        public long FileId
        {
            get { return (long)fid.Value; }
            set { fid.Value = value; }
        }

        protected override void CreatParameters()
        {
            fid = Command.Parameters.AddWithValue("@fid", 0);
        }

        public void CleanupPackageResources()
        {
            SQLiteDataReader dr = Command.ExecuteReader();
            while (dr.Read())
            {
                rr_tgi.ResourceId = (long)dr[0];
                rr_tgi.Command.ExecuteNonQuery();
            }
        }
    }
}
