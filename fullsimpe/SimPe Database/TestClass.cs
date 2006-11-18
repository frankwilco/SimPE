using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Database
{
    public class TestClass
    {
        static bool first = true;
        public static void Tests(ListBox lb)
        {
            if (first) new DatabaseFactory();
            first = false;

            TestClass t = new TestClass();
            t.RunTest(lb);
        }

        Database db;
        TestClass()
        {
            db = new Database();
        }

        void RunTest(ListBox lb)
        {
            ArrayList dirs = FileTable.DefaultFolders;
            Wait.Start();
            Wait.Message = "Sync. Database Cache...";
            foreach (SimPe.FileTableItem s in dirs)
            {
                lb.Items.Add(s);
                db.FileItemChanged(s);
            }
            DatabaseSyncThread.WaitForFinish();
            Wait.Stop();
        }
    }
}
