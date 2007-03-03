using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace SimPe.Database.SqlCommands
{
    public abstract class CommandBase
    {
        SQLiteCommand command;
        protected CommandBase(SQLiteConnection sql, string cmd)
        {
            command = sql.CreateCommand();
            command.CommandText = cmd;
            CreatParameters();
        }

        protected abstract void CreatParameters();

        public SQLiteCommand Command
        {
            get { return command; }
        }
    }
}
