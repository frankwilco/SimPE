using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public partial class ResourceTreeViewExt : UserControl
    {
        ResourceTreeNodesByType typebuilder;
        ResourceTreeNodesByGroup groupbuilder;
        ResourceTreeNodesByInstance instbuilder;
        ResourceViewManager manager;
        IResourceTreeNodeBuilder builder;
        public ResourceTreeViewExt()
        {
            allowselectevent = true;
            InitializeComponent();

            typebuilder = new ResourceTreeNodesByType();
            groupbuilder = new ResourceTreeNodesByGroup();
            instbuilder = new ResourceTreeNodesByInstance();

            SimPe.ThemeManager.Global.AddControl(this.toolStrip1);
            builder = typebuilder;
            tbType.Checked = true;
            last = null;
        }

        ~ResourceTreeViewExt()
        {
            SimPe.ThemeManager.Global.RemoveControl(this.toolStrip1);
        }

        internal void SetManager(ResourceViewManager manager)
        {
            last = null;
            if (this.manager != manager)
            {
                this.manager = manager;
            }
        }  

        public void Clear()
        {
            tv.Nodes.Clear();
        }

        ResourceMaps last;
        void SetResourceMaps()
        {
            tv.Nodes.Clear();
            if (last!=null) SetResourceMaps(last, true);
        }

        bool allowselectevent;
        TreeNode firstnode;
        public void SetResourceMaps(ResourceMaps maps, bool selectevent)
        {
            last = maps;
            if (FileTable.WrapperRegistry != null)
            {
                tv.ImageList = FileTable.WrapperRegistry.WrapperImageList;
                tv.StateImageList = tv.ImageList;
            }

            firstnode = builder.BuildNodes(maps);
            tv.Nodes.Add(firstnode);
            firstnode.Expand();

            allowselectevent = selectevent;
            SelectAll();            
            allowselectevent = true;
        }

        public void SelectAll()
        {
            if (firstnode!=null)
                tv.SelectedNode = firstnode;
        }


        private void tv_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!allowselectevent) return;
            if (e.Node == null) return;
            ResourceTreeNodeExt node = e.Node as ResourceTreeNodeExt;
            if (node != null)
            {
                if (this.manager != null)
                {
                    if (manager.ListView != null)
                    {
                        manager.ListView.SetResources(node.Resources);
                    }
                }
            }
        }

        private void SelectTreeBuilder(object sender, EventArgs e)
        {
            tbType.Checked = sender == tbType;
            tbGroup.Checked = sender == tbGroup;
            tbInst.Checked = sender == tbInst;

            IResourceTreeNodeBuilder old = builder;
            if (sender == tbInst) builder = instbuilder;
            else if (sender == tbGroup) builder = groupbuilder;
            else builder = typebuilder;

            if (old != builder) SetResourceMaps();
        }

        internal void RestoreLayout()
        {
            SelectTreeBuilder(tbType, null);
        }
    }
}
