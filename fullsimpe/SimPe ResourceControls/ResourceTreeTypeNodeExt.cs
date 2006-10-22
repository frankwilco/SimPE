using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public class ResourceTreeTypeNodeExt : ResourceTreeNodeExt
    {
        uint type;
        public ResourceTreeTypeNodeExt(ResourceViewManager.ResourceNameList list, uint type)
            : base(list, "")
        {
            this.type = type;
            this.ImageIndex = ResourceViewManager.GetIndexForResourceType(type);
            this.SelectedImageIndex = this.ImageIndex;
            this.Text = Data.MetaData.FindTypeAlias(type).Name + " (" + list.Count + ")";
        }       

        public uint Type
        {
            get { return type; }
        }


        #region IComparable<ResResourceTreeNodeExt> Member

        public int CompareTo(ResourceTreeNodeExt other)
        {
            return this.Text.CompareTo(other.Text);
        }

        #endregion
    }
}
