using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace SimPe
{

    public class ResoureListViewItemCollection : IEnumerable, IDisposable
    {
        List<ResourceListViewItem> list;

        ResourceListView parent;
        internal ResoureListViewItemCollection(ResourceListView parent)
        {
            list = new List<ResourceListViewItem>();
            
            this.parent = parent;
        }

        public event System.EventHandler Added;
        public void Add(ResourceListViewItem lvi)
        {
            list.Add(lvi);
            if (Added != null) Added(this, new EventArgs());
        }

        public event System.EventHandler Removed;
        internal void Remove(ResourceListViewItem lvi)
        {
            list.Remove(lvi);
            if (Removed != null) Removed(this, new EventArgs());
        }

        public event System.EventHandler Cleared;
        public void Clear()
        {
            list.Clear();
            if (Cleared != null) Cleared(this, new EventArgs());
        }

        public ResourceListViewItem this[int index]
        {
            get { 
                return list[Math.Min(list.Count-1, index)] as ResourceListViewItem; 
            }
            set {
                list[Math.Min(list.Count - 1, index)] = value; 
            }
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Sort()
        {
            list.Sort(parent.Sorter);
        }


        #region IEnumerable Member

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion



        #region IDisposable Member

        public void Dispose()
        {
            this.parent = null;
            if (list!=null) list.Clear();
            list = null;
        }

        #endregion
    }
}
