using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    

    public partial class ResourceListViewExt : UserControl
    {
        const uint WM_USER_SORTED_RESOURCES = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0001;
        const uint WM_USER_FIRE_SELECTION = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0002;

        
        
        ResourceViewManager.ResourceNameList names;
        ResourceViewManager manager;
        IntPtr myhandle;
        SimPe.Windows.Forms.IResourceViewFilter curfilter;
        ResourceViewManager.ResourceNameList lastresources;

        
        public ResourceListViewExt()
        {
            noselectevent = 0;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            cache = new Dictionary<int, ResourceListItemExt>();
        
            lastresources = null;
            seltimer = new System.Threading.Timer(new System.Threading.TimerCallback(SelectionTimerCallback), Handle, System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            sortticket = 0;
            sc = ResourceViewManager.SortColumn.Offset;
            asc = true;
            InitializeComponent();
            names = new ResourceViewManager.ResourceNameList();
            myhandle = Handle;
            
            if (!Helper.WindowsRegistry.ResourceListShowExtensions) lv.Columns.Remove(clTName);
            if (!Helper.WindowsRegistry.HiddenMode)
            {
                lv.Columns.Remove(clSize);
                lv.Columns.Remove(clOffset);
            }
            
        }

        public void BeginUpdate()
        {
            noselectevent++;
            selresea = null;
            resselchgea = null;
            lv.BeginUpdate();
        }

        public void EndUpdate()
        {
            EndUpdate(true);
        }
        

        public void EndUpdate(bool fireevents)
        {            
            noselectevent--;
            noselectevent = Math.Max(0, noselectevent);
            if (noselectevent <= 0)
            {

                if (fireevents)
                {
                    if (resselchgea != null) SelectionChanged(this, resselchgea);
                    if (selresea != null) SelectedResource(this, selresea);
                }
                resselchgea = null; selresea = null;                
            }
            lv.EndUpdate();
        }

        public SimPe.Windows.Forms.IResourceViewFilter Filter
        {
            get { return curfilter; }
            set {
                if (curfilter != value)
                {
                    if (curfilter != null) curfilter.ChangedFilter -= new EventHandler(curfilter_ChangedFilter);
                    curfilter = value;
                    if (curfilter != null) curfilter.ChangedFilter += new EventHandler(curfilter_ChangedFilter);
                }
            }
        }

        void curfilter_ChangedFilter(object sender, EventArgs e)
        {
            ReplaySetResources();
        }

        public void SetResources(ResourceViewManager.ResourceList resources, SimPe.Interfaces.Files.IPackageFile pkg)
        {
            ResourceViewManager.ResourceNameList nn = new ResourceViewManager.ResourceNameList();
            foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in resources)
                nn .Add(new NamedPackedFileDescriptor(pfd, pkg));

            SetResources(nn);

        }

        protected void ReplaySetResources()
        {
            if (lastresources != null) SetResources(lastresources);
        }

        
        internal void SetResources(ResourceViewManager.ResourceNameList resources)
        {
            this.Clear();
            seltimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
            this.CancelThreads();
            lock (names)
            {
                
                foreach (NamedPackedFileDescriptor pfd in names)
                {
                    pfd.Descriptor.ChangedUserData -= new SimPe.Events.PackedFileChanged(Descriptor_ChangedUserData);
                    pfd.Descriptor.DescriptionChanged -= new EventHandler(Descriptor_DescriptionChanged);
                    pfd.Descriptor.ChangedData -= new SimPe.Events.PackedFileChanged(Descriptor_ChangedData);
                }

                names.Clear();
                
                if (FileTable.WrapperRegistry!=null) lv.SmallImageList = FileTable.WrapperRegistry.WrapperImageList;
                //if (resources != this.resources)
                {                    
                    this.Clear();
                    
                    foreach (NamedPackedFileDescriptor pfd in resources)
                    {
                        bool add = true;
                        if (curfilter != null)
                            if (curfilter.Active)
                                add = !curfilter.IsFiltered(pfd.Descriptor);

                        if (add)
                        {
                            names.Add(pfd);
                            pfd.Descriptor.ChangedData += new SimPe.Events.PackedFileChanged(Descriptor_ChangedData);
                            pfd.Descriptor.DescriptionChanged += new EventHandler(Descriptor_DescriptionChanged);
                            pfd.Descriptor.ChangedUserData += new SimPe.Events.PackedFileChanged(Descriptor_ChangedUserData);
                        }
                    }

                    try
                    {
                        lv.VirtualListSize = 0;
                        lv.VirtualListSize = names.Count;
                    }
                    catch //this hack is required because whidbey (.NET 2) has a bug
                    {
                        System.Diagnostics.Debug.WriteLine("Suppressed VirtualListSize exception.");
                    }



                    
                    SortResources();
                }
                lastresources = resources;
                DoSignalSelectionChanged(Handle);
            }
        }

        public new void Refresh()
        {
            //Console.WriteLine("refreshing...");
            //lv.Refresh();
            lv.Update();
            base.Refresh();
        }

        void Descriptor_ChangedData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
        {
            System.Diagnostics.Debug.WriteLine("ChangedData: " + sender.ToString());
            UpdateResourceItem(sender);
            this.Refresh();
            
        }        

        void Descriptor_ChangedUserData(SimPe.Interfaces.Files.IPackedFileDescriptor sender)
        {
            System.Diagnostics.Debug.WriteLine("ChangedUserData: " + sender.ToString());
            UpdateResourceItem(sender);
            this.Refresh();
        }

        void Descriptor_DescriptionChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("DescriptionChanged: " + sender.ToString());
            
            if (UpdateResourceItem(sender))
            {
                if (manager != null && Helper.WindowsRegistry.UpdateResourceListWhenTGIChanges)                
                    manager.UpdateTree();                
            }
            this.Refresh();
        }

        private bool UpdateResourceItem(object sender)
        {
            if (manager != null)
            {

                foreach (NamedPackedFileDescriptor pfd in manager.Everything)
                {
                    //if (pfd.Descriptor.Equals(sender))
                    if (sender == pfd.Descriptor) // must be the exact same object
                    {                        
                        pfd.ResetRealName();
                        return true;
                    }
                }
            }

            return false;
        }

        public event EventHandler SelectionChanged;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.HWnd == Handle)
            {
                if (m.Msg == WM_USER_SORTED_RESOURCES )
                {
                    if ((int)m.WParam == sortticket)
                    {
                        sortingthread = null;
                        DoTheSorting();
                        Refresh();

                        if (Helper.WindowsRegistry.AsynchronSort )
                            Wait.SubStop();
                    
                    }
                }
                else if (m.Msg == WM_USER_FIRE_SELECTION)
                {
                    OnResourceSelectionChanged();
                }
            }

            base.WndProc(ref m);
        }

        

        

        internal void SetManager(ResourceViewManager manager)
        {
            
            if (this.manager != manager)
            {
                this.manager = manager;                
            }
        }       

        public void Clear()
        {
            lv.SelectedIndices.Clear();
            lv.FocusedItem = null;
            lv.Items.Clear();

            foreach (ResourceListItemExt lvi in cache.Values)            
                lvi.FreeResources();
            
            cache.Clear();
            try
            {
                lv.VirtualListSize = 0;
            }
            catch  //this hack is required because whidbey (.NET 2) has a bug
            {
                System.Diagnostics.Debug.WriteLine("Suppressed VirtualListSize exception.");
            }                    
        }

       

        void PrintStats(string name)
        {
            System.Diagnostics.Debug.WriteLine(name + "----------------------");
            System.Diagnostics.Debug.Write("    Selection: ");
            foreach (int i in lv.SelectedIndices)
                System.Diagnostics.Debug.Write(i + " ");

            System.Diagnostics.Debug.WriteLine("");            
        }

        

        CacheVirtualItemsEventArgs lastcache;
        Dictionary<int, ResourceListItemExt> cache;
        private void lv_CacheVirtualItems(object sender, CacheVirtualItemsEventArgs e)
        {            
            lastcache = e;
            /*for (int i = e.StartIndex; i <= e.EndIndex; i++)            
                CreateItem(i);*/
            
            /*PrintStats("CacheVirtualItems");
            System.Diagnostics.Debug.WriteLine("    "+e.StartIndex + " - " + e.EndIndex);*/
        }

        private void lv_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            
            if (e.Item == null)
            {
                //System.Diagnostics.Debug.WriteLine("Reading " + e.ItemIndex);
                lock (names)
                {
                    e.Item = CreateItem(e.ItemIndex);
                }
            }
        }

        private ResourceListItemExt CreateItem(int index)
        {
            ResourceListItemExt ret = null;
            if (index >= 0 && index < names.Count)
            {
                bool vis = false;
                if (lastcache != null) vis = index >= lastcache.StartIndex && index <= lastcache.EndIndex;

                if (cache.ContainsKey(index))                
                    ret = cache[index];

                if (ret == null)
                {
                    NamedPackedFileDescriptor pfd = names[index];
                    ret = new ResourceListItemExt(pfd, manager, vis);
                    //cache.Add(index, ret);
                }
                else ret.Visible = vis;
            }

            return ret;
        }

        private void lv_SearchForVirtualItem(object sender, SearchForVirtualItemEventArgs e)
        {
            PrintStats("SearchForVirtualItem");
        }

        public new ContextMenuStrip ContextMenuStrip
        {
            get { return lv.ContextMenuStrip; }
            set { lv.ContextMenuStrip = value; }
        }

        public void StoreLayout()
        {
            Helper.WindowsRegistry.Layout.TypeColumnWidth = clType.Width;
            Helper.WindowsRegistry.Layout.GroupColumnWidth = clGroup.Width;
            Helper.WindowsRegistry.Layout.InstanceHighColumnWidth = clInstHi.Width;
            Helper.WindowsRegistry.Layout.InstanceColumnWidth = clInst.Width;

            Helper.WindowsRegistry.Layout.OffsetColumnWidth = clOffset.Width;
            Helper.WindowsRegistry.Layout.SizeColumnWidth = clSize.Width;
        }

        public void RestoreLayout()
        {
            clType.Width = Helper.WindowsRegistry.Layout.TypeColumnWidth;
            clGroup.Width = Helper.WindowsRegistry.Layout.GroupColumnWidth;
            clInstHi.Width = Helper.WindowsRegistry.Layout.InstanceHighColumnWidth;
            clInst.Width = Helper.WindowsRegistry.Layout.InstanceColumnWidth;

            clOffset.Width = Helper.WindowsRegistry.Layout.OffsetColumnWidth;
            clSize.Width = Helper.WindowsRegistry.Layout.SizeColumnWidth;
        }

        

        
    }
}
