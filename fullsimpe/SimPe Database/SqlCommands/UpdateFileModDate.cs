using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database.SqlCommands
{
    class UpdateFileModDate : CommandBase
    {
        public UpdateFileModDate(SQLiteConnection sql)
            : base(sql, "UPDATE files SET modified=@modified WHERE filename=@fileName;")
        {
        }

        SQLiteParameter fileName;
        public string FileName
        {
            get { return fileName.Value.ToString(); }
            set { fileName.Value = value.Trim().ToLower(); }
        }

        SQLiteParameter modified;
        public DateTime Modified
        {
            get { return (DateTime)modified.Value; }
            set { modified.Value = Database.ToTimeStamp(value); }
        }

        protected override void CreatParameters()
        {
            fileName = Command.Parameters.AddWithValue("@fileName", "");
            modified = Command.Parameters.AddWithValue("@modified", Database.Now());
        }
    }
}
