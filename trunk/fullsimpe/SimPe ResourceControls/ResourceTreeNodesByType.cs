using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    class ResourceTreeNodesByType : IResourceTreeNodeBuilder
    {
        #region IResourceTreeNodeBuilder Member

        public ResourceTreeNodeExt BuildNodes(ResourceMaps maps)
        {
            ResourceTreeNodeExt tn = new ResourceTreeNodeExt(maps.Everything, SimPe.Localization.GetString("All"));

            AddType(maps.ByType, tn);

            tn.ImageIndex = 0;
            return tn;
        }        

        #endregion

        public static void AddType(ResourceMaps.IntMap map, ResourceTreeNodeExt tn)
        {
            List<ResourceTreeNodeExt> nodelist = new List<ResourceTreeNodeExt>();
            foreach (uint type in map.Keys)
            {
                ResourceViewManager.ResourceNameList list = map[type];
                ResourceTreeNodeExt node = new ResourceTreeTypeNodeExt(list, type);
                nodelist.Add(node);
            }

            nodelist.Sort();
            foreach (ResourceTreeNodeExt node in nodelist)
                tn.Nodes.Add(node);
        }
    }
}
