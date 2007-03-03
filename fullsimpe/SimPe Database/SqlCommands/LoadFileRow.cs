using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database.SqlCommands
{
    class LoadFileRow : CommandBase
    {
        public LoadFileRow(SQLiteConnection sql)
            : base(sql, "SELECT fid, filename, modified FROM files WHERE filename=@fileName;")
        {
        }

        SQLiteParameter fileName;
        public string FileName
        {
            get { return fileName.Value.ToString(); }
            set { fileName.Value = value.Trim().ToLower(); }
        }

        protected override void CreatParameters()
        {
            fileName = Command.Parameters.AddWithValue("@fileName", "");
        }
    }
}
