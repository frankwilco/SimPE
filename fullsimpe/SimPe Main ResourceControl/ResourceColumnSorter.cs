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
    public class ResourceColumnSorter : IComparer
    {
        public ResourceColumnSorter()
        {
            cc = 0;
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

        public event EventHandler Changed;

        /// <summary>
        /// The Compare Function to use
        /// </summary>
        /// <param name="x">fisrt ListViewItem</param>
        /// <param name="y">second ListViewItem</param>
        /// <returns>0 if the ListViewItem match</returns>
        public int Compare(object x, object y)
        {
            UpdatableListViewItem rowA = (UpdatableListViewItem)x;
            UpdatableListViewItem rowB = (UpdatableListViewItem)y;            

            if (Sorting == SortOrder.Ascending)
            {
                return String.Compare(rowA.SubItems[CurrentColumn].Text,
                    rowB.SubItems[CurrentColumn].Text);
            }
            else
            {
                return String.Compare(rowB.SubItems[CurrentColumn].Text,
                    rowA.SubItems[CurrentColumn].Text);
            }

        }
    }
}
