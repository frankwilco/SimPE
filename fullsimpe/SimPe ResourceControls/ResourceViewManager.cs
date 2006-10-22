using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public partial class ResourceViewManager : Component
    {
        

        ResourceMaps maps;
        public ResourceViewManager()
        {
            InitializeComponent();

            maps = new ResourceMaps();
        }

        ~ResourceViewManager()
        {
            this.CancelThreads();
        }

        ResourceListViewExt lv;
        public ResourceListViewExt ListView
        {
            get { return lv; }
            set {
                if (lv != value)
                {
                    if (lv != null) lv.SetManager(null);
                    lv = value;
                    if (lv != null) lv.SetManager(this);
                }
            }
        }

        ResourceTreeViewExt tv;
        public ResourceTreeViewExt TreeView
        {
            get { return tv; }
            set
            {
                if (tv != value)
                {
                    if (tv != null) tv.SetManager(null);
                    tv = value;
                    if (tv != null) tv.SetManager(this);
                }
            }
        }

        public bool Available
        {
            get { return (tv != null && lv != null); }
        }

        SimPe.Interfaces.Files.IPackageFile pkg;


        [System.ComponentModel.Browsable(false)]
        public SimPe.Interfaces.Files.IPackageFile Package
        {
            get { return pkg; }
            set {
                if (pkg != value)
                {
                    SimPe.Interfaces.Files.IPackageFile old = pkg;
                    pkg = value;
                    OnChangedPackage(old, pkg);
                }
            }
        }

        protected void OnChangedPackage(SimPe.Interfaces.Files.IPackageFile oldpkg, SimPe.Interfaces.Files.IPackageFile newpkg)
        {
            lock (maps)
            {
                if (oldpkg != null)
                {
                    oldpkg.SavedIndex -= new EventHandler(newpkg_SavedIndex);
                    oldpkg.RemovedResource -= new EventHandler(newpkg_RemovedResource);
                    oldpkg.AddedResource -= new EventHandler(newpkg_AddedResource);
                }
                maps.Clear();

                if (lv != null) lv.Clear();
                if (tv != null) tv.Clear();

                if (newpkg != null)
                {
                    if (Helper.WindowsRegistry.ShowProgressWhenPackageLoads)
                        Wait.Start(newpkg.Index.Length);
                    else Wait.Start();
                    Wait.Message = SimPe.Localization.GetString("Loading package...");
                    int ct = 0;
                    foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in newpkg.Index)
                    {
                        NamedPackedFileDescriptor npfd = new NamedPackedFileDescriptor(pfd, newpkg);
                        maps.Everything.Add(npfd);
                        AddResourceToMaps(npfd);
                        if (Helper.WindowsRegistry.ShowProgressWhenPackageLoads) Wait.Progress = ct++;
                    }
                    Wait.Stop();
                }

                if (lv != null) lv.SetResources(maps.Everything);
                if (tv != null) tv.SetResourceMaps(maps, false);

                if (newpkg != null)
                {
                    newpkg.AddedResource += new EventHandler(newpkg_AddedResource);
                    newpkg.RemovedResource += new EventHandler(newpkg_RemovedResource);
                    newpkg.SavedIndex += new EventHandler(newpkg_SavedIndex);
                }
            }
        }

        void newpkg_SavedIndex(object sender, EventArgs e)
        {
            if (lv != null) lv.Refresh();
        }

        void newpkg_RemovedResource(object sender, EventArgs e)
        {
            OnChangedPackage(pkg, pkg);
        }

        void newpkg_AddedResource(object sender, EventArgs e)
        {
            OnChangedPackage(pkg, pkg);
        }

        private void AddResourceToMaps(NamedPackedFileDescriptor npfd)
        {
            AddToTypeMap(npfd);
            AddToGroupMap(npfd);
            AddToInstMap(npfd);            
        }

        private void AddToTypeMap(NamedPackedFileDescriptor npfd)
        {
            ResourceNameList pfdlist = null;
            if (maps.ByType.ContainsKey(npfd.Descriptor.Type)) pfdlist = maps.ByType[npfd.Descriptor.Type];
            else
            {
                pfdlist = new ResourceNameList();
                maps.ByType[npfd.Descriptor.Type] = pfdlist;
            }

            pfdlist.Add(npfd);
        }

        private void AddToGroupMap(NamedPackedFileDescriptor npfd)
        {
            ResourceNameList pfdlist = null;
            if (maps.ByGroup.ContainsKey(npfd.Descriptor.Group)) pfdlist = maps.ByGroup[npfd.Descriptor.Group];
            else
            {
                pfdlist = new ResourceNameList();
                maps.ByGroup[npfd.Descriptor.Group] = pfdlist;
            }

            pfdlist.Add(npfd);
        }

        private void AddToInstMap(NamedPackedFileDescriptor npfd)
        {
            ResourceNameList pfdlist = null;
            if (maps.ByInstance.ContainsKey(npfd.Descriptor.LongInstance)) pfdlist = maps.ByInstance[npfd.Descriptor.LongInstance];
            else
            {
                pfdlist = new ResourceNameList();
                maps.ByInstance[npfd.Descriptor.LongInstance] = pfdlist;
            }

            pfdlist.Add(npfd);
        }

        internal static int GetIndexForResourceType(uint type)
        {
            if (Helper.WindowsRegistry.DecodeFilenamesState)
            {
                SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp = FileTable.WrapperRegistry.FindHandler(type);
                if (wrp != null)
                {
                    return wrp.WrapperDescription.IconIndex;
                }
            }

            return 0;
        }

        public void CancelThreads()
        {
            if (lv != null) lv.CancelThreads();
        }

        public void StoreLayout()
        {
            if (lv != null) lv.StoreLayout();
        }

        public void RestoreLayout()
        {
            if (lv != null) lv.RestoreLayout();
            if (tv != null) tv.RestoreLayout();
        }

        public bool SelectResource(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem resource)
        {
            bool res = false;
            if (lv != null) res = lv.SelectResource(resource);
            if (!res && tv!=null && lv!=null)
            {
                tv.SelectAll();
                res = lv.SelectResource(resource);
            }
            return res;
        }
    }
}
