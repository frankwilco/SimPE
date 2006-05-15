using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace SimPe
{
    /// <summary>
    /// ListView Column Sorter
    /// </summary>
    public class ResourceColumnSorter : IComparer<ResourceListViewItem>, IComparer
    {
        public ResourceColumnSorter()
        {
            cc = -1;
            so = SortOrder.Ascending;
        }
        int cc;
        SortOrder so;
        /// <summary>
        /// The Currently active Column
        /// </summary>
        public int CurrentColumn
        {
            get { return cc; }
            set
            {
                if (cc != value)
                {
                    cc = value;
                    if (Changed != null) Changed(this, new EventArgs());
                }
            }
        }

        public bool Asc
        {
            get
            {
                return (Sorting == SortOrder.Ascending);
            }
            set
            {
                if (value) Sorting = SortOrder.Ascending;
                else Sorting = SortOrder.Descending;
            }
        }


        /// <summary>
        /// The Sort Order
        /// </summary>
        public SortOrder Sorting
        {
            get { return so; }
            set
            {
                if (so != value)
                {
                    so = value;
                    if (Changed != null) Changed(this, new EventArgs());
                }
            }
        }

        /// <summary>
        /// True if we need to have everything loaded before we can sort
        /// </summary>
        public bool ForceLoad
        {
            get { return cc == 0; }
        }

        public event EventHandler Changed;       

        #region IComparer<ResourceListViewItem> Member

        /// <summary>
        /// The Compare Function to use
        /// </summary>
        /// <param name="rowA">fisrt ListViewItem</param>
        /// <param name="rowB">second ListViewItem</param>
        /// <returns>0 if the ListViewItem match</returns>
        public int Compare(ResourceListViewItem rowA, ResourceListViewItem rowB)
        {
            if (cc < 0) return 0;

            if (so == SortOrder.Ascending)
            {
                return String.Compare(rowA.Content[cc], rowB.Content[cc]);
            }
            else
            {
                return String.Compare(rowB.Content[cc], rowA.Content[cc]);
            }
        }

        #endregion

        #region IComparer Member

        public int Compare(object x, object y)
        {
            if (cc < 0) return 0;
            ResourceListViewItem rowA = x as ResourceListViewItem;
            ResourceListViewItem rowB = y as ResourceListViewItem;

            if (so == SortOrder.Ascending)
            {
                return String.Compare(rowA.Content[cc], rowB.Content[cc]);
            }
            else
            {
                return String.Compare(rowB.Content[cc], rowA.Content[cc]);
            }
        }

        #endregion
    }
}
