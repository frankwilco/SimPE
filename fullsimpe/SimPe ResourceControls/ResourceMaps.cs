using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    public class ResourceMaps
    {
        public class IntMap : Dictionary<uint, ResourceViewManager.ResourceNameList> { }
        public class LongMap : Dictionary<ulong, ResourceViewManager.ResourceNameList> { }

        public ResourceMaps()
        {
            all = new ResourceViewManager.ResourceNameList();
            typemap = new IntMap();
            groupmap = new IntMap();
            instmap = new LongMap();
        }

        IntMap typemap, groupmap;
        private LongMap instmap;
        private ResourceViewManager.ResourceNameList all;

        public ResourceViewManager.ResourceNameList Everything
        {
            get { return all; }
        }

        internal IntMap ByGroup
        {
            get { return groupmap; }
        }
        internal IntMap ByType
        {
            get { return typemap; }
        }

        public LongMap ByInstance
        {
            get { return instmap; }
        }

        public void Clear()
        {
            typemap.Clear();
            groupmap.Clear();
            instmap.Clear();
            all.Clear();
        }
    }
}
