using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    partial class ResourceListViewExt
    {
        
        ResourceViewManager.SortColumn sc;
        bool asc;
        int sortticket;
        ResoureNameSorter sortingthread;

        public ResourceViewManager.SortColumn SortedColumn
        {
            get { return sc; }
            set
            {
                //if (sc != value)
                {
                    sc = value;
                    lock (names)
                    {
                        SortResources();
                        Refresh();
                    }
                }
            }
        }

        void SortResources()
        {
            sortticket++;
            CancelThreads();

            if (sc == ResourceViewManager.SortColumn.Name)
            {
                SimPe.Wait.SubStart(names.Count);
                SimPe.Wait.Message = SimPe.Localization.GetString("Loading embedded resource names...");
                sortingthread = new ResoureNameSorter(this, names, sortticket);
            }
            else
            {
                SignalFinishedSort(sortticket);
            }
        }

        public void CancelThreads()
        {
            if (sortingthread != null)
            {
                sortingthread.Cancel();
                sortingthread = null;
            }
        }

        internal void SignalFinishedSort(int ticket)
        {
            SignalFinishedSort(Handle, ticket);
        }

        internal void SignalFinishedSort(IntPtr handle, int ticket)
        {
            Ambertation.Windows.Forms.APIHelp.SendMessage(handle, WM_USER_SORTED_RESOURCES, ticket, 0);
        }

        void DoTheSorting()
        {
            lv.BeginUpdate();
            names.SortByColumn(sc, asc);
            lv.EndUpdate();
        }

        private void lv_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ResourceViewManager.SortColumn tmp = (ResourceViewManager.SortColumn)e.Column;
            if (tmp == SortedColumn) asc = !asc;
            SortedColumn = tmp;
        }

    }
}
