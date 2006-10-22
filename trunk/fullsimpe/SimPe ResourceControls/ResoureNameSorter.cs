using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    class ResoureNameSorter
    {         
        Stack<NamedPackedFileDescriptor> names;
        int started;
        int counter;
        ResourceListViewExt parent;
        IntPtr handle;
        int ticket;
        public ResoureNameSorter(ResourceListViewExt parent, ResourceViewManager.ResourceNameList names, int ticket)
        {
            int numberofthreads = Helper.WindowsRegistry.SortProcessCount;
            handle = parent.Handle;
            this.parent = parent;
            this.ticket = ticket;
            this.names = new Stack<NamedPackedFileDescriptor>();
            foreach (NamedPackedFileDescriptor pfd in names)
                this.names.Push(pfd);
            

            counter = 0;
            if (Helper.WindowsRegistry.AsynchronSort)
            {
                started = numberofthreads;                
                for (int i = 0; i < numberofthreads; i++)
                {
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ReadNames));
                    t.Name = "Resource Sorting Thread " + i + "." + Helper.HexString(ticket);
                    t.Start();
                   
                }
            }
            else
            {
                started = 1;
                ReadNames();
            }
        }

        public void Cancel()
        {
            lock (names)
            {
                names.Clear();
                started = 0;
            }
        }

        void ReadNames()
        {
            while (names.Count > 0)
            {
                NamedPackedFileDescriptor pfd = null;
                lock (names)
                {
                    if (names.Count == 0) break;
                    pfd = names.Pop();
                    SimPe.Wait.Progress = counter++;
                }
                pfd.GetRealName();
            }

            lock (names)
            {
                started--;
                if (started == 0)
                {
                    parent.SignalFinishedSort(handle, ticket);
                }
            }
            
        }
    }
}
