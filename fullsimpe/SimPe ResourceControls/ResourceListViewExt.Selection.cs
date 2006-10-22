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
        const int WAIT_SELECT = 400;
        System.Threading.Timer seltimer;

        private void lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            //PrintStats("SelectedIndexChanged");
            SignalSelectionChanged();
        }

        private void lv_VirtualItemsSelectionRangeChanged(object sender, ListViewVirtualItemsSelectionRangeChangedEventArgs e)
        {
            //PrintStats("VirtualItemsSelectionRangeChanged");
            SignalSelectionChanged();
        }

        protected void SignalSelectionChanged()
        {
            seltimer.Change(WAIT_SELECT, System.Threading.Timeout.Infinite);
        }

        void DoSignalSelectionChanged(IntPtr handle)
        {
            Ambertation.Windows.Forms.APIHelp.SendMessage(handle, WM_USER_FIRE_SELECTION, 0, 0);
        }

        void SelectionTimerCallback(object state)
        {
            DoSignalSelectionChanged((IntPtr)state);
        }

        public ResourceViewManager.ResourceNameList SelectedItems
        {
            get
            {
                lock (names)
                {
                    ResourceViewManager.ResourceNameList ret = new ResourceViewManager.ResourceNameList();
                    foreach (int i in lv.SelectedIndices)
                        ret.Add(names[i]);

                    return ret;
                }
            }
        }

        protected virtual void OnResourceSelectionChanged()
        {
            if (SelectionChanged != null) SelectionChanged(this, new EventArgs());
            
            //PrintStats("***OnResourceSelectionChanged");
        }

        private void lv_Click(object sender, EventArgs e)
        {
            if (Helper.WindowsRegistry.SimpleResourceSelect) OnSelectResource();
        }

        private void lv_DoubleClick(object sender, EventArgs e)
        {
            if (!Helper.WindowsRegistry.SimpleResourceSelect) OnSelectResource();
        }

        bool ctrldown = false;
        private void lv_KeyDown(object sender, KeyEventArgs e)
        {
            ctrldown = e.Alt;
        }

        public event KeyEventHandler ListViewKeyUp;
        private void lv_KeyUp(object sender, KeyEventArgs e)
        {
            ctrldown = e.Alt;

            if (!ctrldown && (e.KeyCode == Keys.Up
                || e.KeyCode == Keys.Down
                || e.KeyCode == Keys.PageDown
                || e.KeyCode == Keys.PageUp
                || e.KeyCode == Keys.Home
                || e.KeyCode == Keys.End)) OnSelectResource();

            if (e.KeyCode == Keys.Enter) OnSelectResource();
            if (e.KeyCode == Keys.A && e.Control) SelectAll();

            if (ListViewKeyUp != null) ListViewKeyUp(this, e);
        }

        public void SelectAll()
        {
            lock (names)
            {
                lv.BeginUpdate();
                lv.SelectedIndices.Clear();
                for (int i = 0; i < names.Count; i++)
                    lv.SelectedIndices.Add(i);
                lv.EndUpdate();
            }
        }

        protected void OnSelectResource()
        {
            bool rctrl = ctrldown;
            if (!Helper.WindowsRegistry.FirefoxTabbing) rctrl = false;

            if (SelectedResource != null) SelectedResource(this, new SelectResourceEventArgs(rctrl));
            //System.Diagnostics.Debug.WriteLine("Selection changed " + rctrl);
        }

        public class SelectResourceEventArgs : EventArgs
        {
            bool ctrldn;
            public bool CtrlDown
            {
                get { return ctrldn; }
            }

            internal SelectResourceEventArgs(bool ctrldn)
                : base()
            {
                this.ctrldn = ctrldn;
            }
        }
        public delegate void SelectResourceHandler(ResourceListViewExt sender, SelectResourceEventArgs e);
        public event SelectResourceHandler SelectedResource;

        public SimPe.Plugin.FileIndexItem SelectedItem
        {
            get
            {
                lock (names)
                {
                    if (lv.SelectedIndices.Count == 0) return null;
                    return names[lv.SelectedIndices[0]].Resource;
                }
            }
        }

        public bool SelectResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem resource)
        {
            lock (names)
            {
                int ct = 0;
                foreach (NamedPackedFileDescriptor pfd in names)
                {
                    if (pfd.Resource.FileDescriptor.Equals(resource.FileDescriptor))
                    {
                        lv.BeginUpdate();
                        lv.SelectedIndices.Clear();
                        lv.SelectedIndices.Add(ct);
                        lv.EnsureVisible(ct);
                        lv.EndUpdate();
                        return true;
                    }
                    ct++;
                }
            }
            return false;
        }
    }
}
