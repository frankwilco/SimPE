using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    class ResourceTreeNodesByGroup : IResourceTreeNodeBuilder
    {
        #region IResourceTreeNodeBuilder Member

        public virtual ResourceTreeNodeExt BuildNodes(ResourceMaps maps)
        {
            ResourceTreeNodeExt tn = new ResourceTreeNodeExt(maps.Everything, SimPe.Localization.GetString("All"));

            AddGroups(maps.ByGroup, tn, true, true);

            tn.ImageIndex = 0;
            return tn;
        }      
        #endregion

        public static void AddGroups(ResourceMaps.IntMap map, ResourceTreeNodeExt tn, bool type, bool inst)
        {
            List<ResourceTreeNodeExt> nodelist = new List<ResourceTreeNodeExt>();
            foreach (uint group in map.Keys)
            {
                ResourceViewManager.ResourceNameList list = map[group];
                ResourceTreeNodeExt node = new ResourceTreeNodeExt(list, "0x" + Helper.HexString(group));
                if (type)
                {
                    ResourceTreeNodeExt typenode = new ResourceTreeNodeExt(list, "Types");
                    AddSubNodesForTypes(typenode, list);
                    node.Nodes.Add(typenode);
                }

                if (inst)
                {
                    ResourceTreeNodeExt instnode = new ResourceTreeNodeExt(list, "Instances");
                    AddSubNodesForInstances(instnode, list);
                    node.Nodes.Add(instnode);
                }

                nodelist.Add(node);
            }

            nodelist.Sort();
            foreach (ResourceTreeNodeExt node in nodelist)
                tn.Nodes.Add(node);
        }

        public static void AddSubNodesForTypes(ResourceTreeNodeExt node, ResourceViewManager.ResourceNameList resources)
        {
            ResourceMaps.IntMap map = new ResourceMaps.IntMap();
            foreach (NamedPackedFileDescriptor pfd in resources)
            {
                ResourceViewManager.ResourceNameList list;
                if (!map.ContainsKey(pfd.Descriptor.Type))
                {
                    list = new ResourceViewManager.ResourceNameList();
                    map.Add(pfd.Descriptor.Type, list);
                }
                else list = map[pfd.Descriptor.Type];

                list.Add(pfd);
            }

            ResourceTreeNodesByType.AddType(map, node);
        }

        public static void AddSubNodesForInstances(ResourceTreeNodeExt node, ResourceViewManager.ResourceNameList resources)
        {
            ResourceMaps.LongMap map = new ResourceMaps.LongMap();
            foreach (NamedPackedFileDescriptor pfd in resources)
            {
                ResourceViewManager.ResourceNameList list;
                if (!map.ContainsKey(pfd.Descriptor.LongInstance))
                {
                    list = new ResourceViewManager.ResourceNameList();
                    map.Add(pfd.Descriptor.LongInstance, list);
                }
                else list = map[pfd.Descriptor.LongInstance];

                list.Add(pfd);
            }

            ResourceTreeNodesByInstance.AddInstances(map, node, false, false);
        }
    }
}
