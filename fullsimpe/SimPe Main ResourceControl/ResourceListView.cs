using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe
{
    
    public class ResourceListView : ListView
    {
        class ItemLoader : Ambertation.Threading.StoppableThread
        {
            ResourceListView lv;
            bool dostop;
            public ItemLoader(ResourceListView lv)
            {
                this.lv = lv;
            }

            delegate void LoadItemHandler(UpdatableListViewItem lvi);
            void LoadItem(UpdatableListViewItem lvi)
            {
                lvi.ForceLoad();
            }

            protected override void StartThread()
            {
                //lv.InvokeBeginUpdate();
                LoadItemHandler lih = new LoadItemHandler(LoadItem);
                Wait.SubStart(lv.Items.Count);
                Wait.Message = "Sorting...";
                int ct = 0;
                try
                {
                    foreach (UpdatableListViewItem lvi in lv.Items)
                    {
                        Wait.Progress = ct++;
                        try
                        {
                            lvi.ForceLoad();                           
                            Application.DoEvents();
                            if (dostop) return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex);
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                Wait.SubStop();
                //lv.InvokeEndUpdate();
            }

            
            public void Load(){
                dostop = false;
               StartThread();
            }

            public void Stop()
            {
                dostop = true;
                //WaitForEnd();
            }
        }        


        ItemLoader il;
        public ResourceListView() : base()
        {
            beginct = 0;
            this.OwnerDraw = true;
            
            il = new ItemLoader(this);

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.AutoArrange = false;
        }

        public void LoadAll()
        {
            il.Load();
        }

        public void StopLoad()
        {
            il.Stop();
        }

        int beginct;
        internal void InvokeBeginUpdate()
        {
            beginct++;
            if (this.InvokeRequired)
                this.Invoke(new SetUpdateHandler(SetUpdate), new object[] { true });
            else SetUpdate(true);
        }

        internal void InvokeEndUpdate()
        {
            while (beginct > 0)
            {
                beginct--;
                if (this.InvokeRequired)
                    this.Invoke(new SetUpdateHandler(SetUpdate), new object[] { false });
                else
                    SetUpdate(false);
            }
        }

        delegate void SetUpdateHandler(bool begin);
        void SetUpdate(bool begin)
        {                        
            if (begin) this.BeginUpdate();
            else this.EndUpdate();
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            UpdatableListViewItem lvi = e.Item as UpdatableListViewItem;
            if (lvi != null)
            {
                lvi.ForceLoad();
                //Console.WriteLine("Load "+this.Items.Count+" "+e.ItemIndex);
            }

            e.DrawDefault = true;            
            base.OnDrawItem(e);
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            UpdatableListViewItem lvi = e.Item as UpdatableListViewItem;
            if (lvi != null)
            {
            }
            
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
