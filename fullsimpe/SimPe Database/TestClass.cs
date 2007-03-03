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
            Database.FileList list = new Database.FileList();
            DateTime start = DateTime.Now;
            foreach (SimPe.FileTableItem s in dirs)
            {
                db.LoadUpdateableFiles(list, s);
                Application.DoEvents();
            }


            DatabaseSyncThread dst = new DatabaseSyncThread(db, list);
            dst.WaitForFinish();
            TimeSpan runtime = DateTime.Now - start;
            
            //db.AddPackageFile(@"F:\Die Sims 2\TSData\Res\Sims3D\Objects08.package");
            db.Result();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Total Runtime: " + runtime.ToString());
            Wait.Stop();
        }
    }
}
