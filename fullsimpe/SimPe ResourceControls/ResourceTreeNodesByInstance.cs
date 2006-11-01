using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    class ResourceTreeNodesByInstance : AResourceTreeNodeBuilder
    {
        #region IResourceTreeNodeBuilder Member

        public override ResourceTreeNodeExt BuildNodes(ResourceMaps maps)
        {
            ResourceTreeNodeExt tn = new ResourceTreeNodeExt(0, maps.Everything, SimPe.Localization.GetString("AllRes"));

            AddInstances(maps.ByInstance, tn, true, true);

            tn.ImageIndex = 0;
            return tn;
        }      
        #endregion

        public static void AddInstances(ResourceMaps.LongMap map, ResourceTreeNodeExt tn, bool group, bool type)
        {
            List<ResourceTreeNodeExt> nodelist = new List<ResourceTreeNodeExt>();
            foreach (ulong inst in map.Keys)
            {
                ResourceViewManager.ResourceNameList list = map[inst];
                ResourceTreeNodeExt node = new ResourceTreeNodeExt(inst, list, "0x" + Helper.HexString(inst));
                if (group)
                {
                    ResourceTreeNodeExt groupnode = new ResourceTreeNodeExt(inst, list, "Groups");
                    AddSubNodesForGroups(groupnode, list);
                    node.Nodes.Add(groupnode);
                }
                if (type)
                {
                    ResourceTreeNodeExt typenode = new ResourceTreeNodeExt(inst, list, "Types");
                    ResourceTreeNodesByGroup.AddSubNodesForTypes(typenode, list);
                    node.Nodes.Add(typenode);
                }

                nodelist.Add(node);
            }

            nodelist.Sort();
            foreach (ResourceTreeNodeExt node in nodelist)
                tn.Nodes.Add(node);
        }

        static void AddSubNodesForGroups(ResourceTreeNodeExt node, ResourceViewManager.ResourceNameList resources)
        {
            ResourceMaps.IntMap map = new ResourceMaps.IntMap();
            foreach (NamedPackedFileDescriptor pfd in resources)
            {
                ResourceViewManager.ResourceNameList list;
                if (!map.ContainsKey(pfd.Descriptor.Group))
                {
                    list = new ResourceViewManager.ResourceNameList();
                    map.Add(pfd.Descriptor.Group, list);
                }
                else list = map[pfd.Descriptor.Group];

                list.Add(pfd);
            }

            ResourceTreeNodesByGroup.AddGroups(map, node, false, false);
        }        
    }
}
