using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SimPe
{
    
    public class ResourceListView : ListView
    {
        class ItemLoader : Ambertation.Threading.StoppableThread
        {
            internal bool loaded;
            ResourceListView lv;
           

            public ItemLoader(ResourceListView lv)
            {
                this.lv = lv;
                loaded = false;
            }

            delegate void LoadItemHandler(ResourceListViewItem lvi);
            void LoadItem(ResourceListViewItem lvi)
            {
                lvi.ForceLoad();
            }

            protected override void StartThread()
            {                
                bool doloads = !loaded;
                doloads = doloads && (lv.Sorter.ForceLoad);                

                if (!doloads) return;

                
                Console.WriteLine("Sorting for " + lv.Sorter.CurrentColumn+ " "+lv.VirtualItems.Count+" items");
                
                LoadItemHandler lih = new LoadItemHandler(LoadItem);
                Wait.SubStart(lv.Items.Count);
                Wait.Message = "Sorting...";
                int ct = 0;
                bool all = true;
                try
                {

                    foreach (ResourceListViewItem lvi in lv.VirtualItems)
                    {
                        ct++;
                        if (ct%250==0) Wait.Progress = ct;
                        try
                        {
                            lvi.ForceLoad();
                            Application.DoEvents();
                            if (stop.WaitOne(0, false))
                            {
                                all = false;
                                break;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            all = false;
                            break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Wait.SubStop();

                if (all) loaded = true;
            }

            
            public void Load(){
               this.ExecuteThread(ThreadPriority.Normal, "Sorter", true, true, 100);               
               Console.WriteLine("Finished loading");                              
            }

            public void Stop(bool wait)
            {
                this.WaitForEnd();
            }
        }

        ResoureListViewItemCollection items, sel;
        ItemLoader il;
        public ResourceListView() : base()
        {            
            beginct = 0;
            this.OwnerDraw = false;
            
            il = new ItemLoader(this);

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.AutoArrange = false;

            sel = new ResoureListViewItemCollection(this);
            items = new ResoureListViewItemCollection(this);
            items.Cleared += new EventHandler(items_Cleared);
            items.Added += new EventHandler(items_Added);
            this.VirtualMode = true;

            SetupSorter();
        }

        void items_Added(object sender, EventArgs e)
        {
            this.VirtualListSize = items.Count;            
        }

        void items_Cleared(object sender, EventArgs e)
        {
            il.loaded = false;
            this.VirtualListSize = 0;
            //this.Refresh();
        }

        public ResoureListViewItemCollection VirtualItems
        {
            get { return items;}
        }
        ResourceColumnSorter sorter;
        internal ResourceColumnSorter Sorter
        {
            get { return sorter; }
        }       

        void SetupSorter()
        {
            if (sorter != null) return;

            sorter = new ResourceColumnSorter();
            sorter.CurrentColumn = -1;
            ListViewItemSorter = sorter;             
        }

        public new void Sort()
        {
            Sort(false);
        }

        delegate void InvokeRefreshHandler();
        void InvokeRefresh()
        {
            this.Refresh();
        }

        protected void Sort(bool intern){
            if (sorter.CurrentColumn < 0) return;

            this.LoadAll();
            items.Sort();
            if (!intern) this.Refresh();            
            Console.WriteLine("Done sorting");
        }

        public void LoadAll()
        {
            if (Helper.WindowsRegistry.AsynchronSort) il.Load();
        }

        public void StopLoad()
        {
            il.Stop(true);
        }

        public void UpdateContent()
        {
            il.loaded = !Helper.WindowsRegistry.AsynchronSort;            
        }

        int beginct;
        internal void InvokeBeginUpdate()
        {
            beginct++;
            if (this.InvokeRequired)
                this.Invoke(new SetUpdateHandler(SetUpdate), new object[] { true, true });
            else SetUpdate(true, true);
        }

        internal void InvokeEndUpdate()
        {
            while (beginct > 0)
            {
                beginct--;
                if (this.InvokeRequired)
                    this.Invoke(new SetUpdateHandler(SetUpdate), new object[] { false, true });
                else
                    SetUpdate(false, true);
            }

            this.VirtualListSize = this.items.Count;
        }        

        protected override void OnRetrieveVirtualItem(RetrieveVirtualItemEventArgs e)
        {
            base.OnRetrieveVirtualItem(e);

            //if (e.Item == null)
            {
                if (e.ItemIndex < items.Count)
                {
                    ResourceListViewItem lvi = items[e.ItemIndex] as ResourceListViewItem;
                    lvi.ForceLoad();
                    e.Item = lvi;
                }
            }
        }

        public new ResoureListViewItemCollection Items
        {
            get { return items; }
        }
        public new ResoureListViewItemCollection SelectedItems
        {
            get { return sel; }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            lock (SYNC)
            {
                UpdateSelectionList();

                Console.WriteLine(sel.Count + " items selected");
                base.OnSelectedIndexChanged(e);
                FireOnChange();
            }
        }

        public event System.EventHandler SyncedSelectionChanged;
        private void UpdateSelectionList()
        {
            sel.Clear();            
            foreach (int i in this.SelectedIndices)
                sel.Add(items[i]);
        }

        public static object SYNC = new object();

        protected override void OnVirtualItemsSelectionRangeChanged(ListViewVirtualItemsSelectionRangeChangedEventArgs e)
        {
            lock (SYNC)
            {
                if (e.IsSelected)
                {
                    UpdateSelectionList();
                }
                else
                {
                    for (int i = e.StartIndex; i <= e.EndIndex; i++)
                        sel.Remove(items[i]);
                }


                Console.WriteLine(e.StartIndex + " " + e.EndIndex + " " + e.IsSelected + " " + sel.Count);
                base.OnVirtualItemsSelectionRangeChanged(e);
                base.OnSelectedIndexChanged(e);
                FireOnChange();
            }
        }

        void FireOnChange()
        {
            firechange = true;
            if (!Paused)
            {
                if (SyncedSelectionChanged != null) SyncedSelectionChanged(this, new EventArgs());
            }
        }
        
        delegate void SetUpdateHandler(bool begin, bool setevent);

        bool firechange;
        bool Paused
        {
            get { return beginct > 0; }
        }

        void SetUpdate(bool begin, bool setevent)
        {
            if (setevent)
            {
                if (begin) items.Added -= new EventHandler(items_Added);
                else items.Added += new EventHandler(items_Added);
            }

            if (Helper.WindowsRegistry.ShowResourceListContentAtOnce && begin) return;

            //this.Enabled = !begin;
            if (begin)
            {
                this.BeginUpdate();
                firechange = false;
            }
            else
            {
                this.EndUpdate();
                lock (SYNC)
                {
                    if (firechange) this.FireOnChange();
                }
            }
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {

            ResourceListViewItem lvi = e.Item as ResourceListViewItem;
            if (lvi != null) lvi.ForceLoad();            

            e.DrawDefault = true;            
            base.OnDrawItem(e);
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
           e.DrawDefault = true;            
           base.OnDrawSubItem(e);
        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            e.DrawDefault = true;
            base.OnDrawColumnHeader(e);
        }      
    }
}
