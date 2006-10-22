using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public class ResourceTreeNodeExt : TreeNode, IComparable<ResourceTreeNodeExt>
    {
        ResourceViewManager.ResourceNameList list;             
        public ResourceTreeNodeExt(ResourceViewManager.ResourceNameList list, string text)
            : base()
        {
            this.list = list;

            this.ImageIndex = 0;
            this.Text = text + " ("+list.Count+")";
            this.SelectedImageIndex = this.ImageIndex;
        }

        public ResourceViewManager.ResourceNameList Resources
        {
            get { return list; }
        }


        #region IComparable<ResResourceTreeNodeExt> Member

        public int CompareTo(ResourceTreeNodeExt other)
        {
            return this.Text.CompareTo(other.Text);
        }

        #endregion
    }
}
