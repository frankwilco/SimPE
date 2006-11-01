using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    public abstract class AResourceTreeNodeBuilder : IResourceTreeNodeBuilder
    {
        ulong last;
        public AResourceTreeNodeBuilder()
        {
            last = 0;
        }
        #region IResourceTreeNodeBuilder Member

        public abstract ResourceTreeNodeExt BuildNodes(ResourceMaps maps);

        public ulong LastSelectedId
        {
            get
            {
                return last;
            }
            set
            {
                last = value;
            }
        }

        #endregion
    }
}
