using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    public interface IResourceTreeNodeBuilder
    {
        ResourceTreeNodeExt BuildNodes(ResourceMaps maps);
        ulong LastSelectedId { get; set; }
    }
}
