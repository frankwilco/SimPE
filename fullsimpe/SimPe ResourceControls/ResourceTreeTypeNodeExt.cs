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
            : base(type, list, "")
        {
            this.type = type;
            this.ImageIndex = ResourceViewManager.GetIndexForResourceType(type);
            this.SelectedImageIndex = this.ImageIndex;
            SimPe.Data.TypeAlias ta = Data.MetaData.FindTypeAlias(type);
            this.Text = ta.Name + " ("+ta.shortname+") (" + list.Count + ")";
        }       

        public uint Type
        {
            get { return type; }
        }

       


        #region IComparable<ResResourceTreeNodeExt> Member

        public new int CompareTo(ResourceTreeNodeExt other)
        {
            return this.Text.CompareTo(other.Text);
        }

        #endregion
    }
}
