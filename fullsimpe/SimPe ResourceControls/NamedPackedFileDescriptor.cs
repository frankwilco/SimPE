using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.Windows.Forms
{
    public class NamedPackedFileDescriptor
    {
        SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
        SimPe.Interfaces.Files.IPackageFile pkg;
        SimPe.Plugin.FileIndexItem fii;
        string realname;
        public NamedPackedFileDescriptor(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg)
        {
            this.pfd = pfd;
            this.pkg = pkg;
            this.fii = new SimPe.Plugin.FileIndexItem(pfd, pkg);
            realname = null;
        }

        public SimPe.Plugin.FileIndexItem Resource
        {
            get { return fii; }
        }

        public SimPe.Interfaces.Files.IPackedFileDescriptor Descriptor
        {
            get { return pfd; }
        }

        public bool RealNameLoaded
        {
            get { return realname != null; }
        }

        public void ResetRealName()
        {
            realname = null;
        }

        public string GetRealName()
        {
            if (realname == null)
            {
                if (Helper.WindowsRegistry.DecodeFilenamesState)
                {                    
                    SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp = FileTable.WrapperRegistry.FindHandler(pfd.Type);
                    if (wrp != null)
                    {      
                        lock (wrp)
                        {
                            //System.Diagnostics.Debug.WriteLine("Processing " + pfd.Type.ToString("X")+" "+pfd.Offset.ToString("X"));
                            SimPe.Interfaces.Files.IPackedFileDescriptor bakpfd = null;
                            SimPe.Interfaces.Files.IPackageFile bakpkg = null;
                            if (wrp is SimPe.Interfaces.Plugin.AbstractWrapper)
                            {
                                SimPe.Interfaces.Plugin.AbstractWrapper awrp = (SimPe.Interfaces.Plugin.AbstractWrapper)wrp;
                                if (!awrp.AllowMultipleInstances)
                                {
                                    bakpfd = awrp.FileDescriptor;
                                    bakpkg = awrp.Package;
                                }

                                awrp.FileDescriptor = pfd;
                                awrp.Package = pkg;
                            }
                            try
                            {
                                realname = wrp.ResourceName;
                            }
#if DEBUG
                            catch (Exception ex)
                            {
                                realname = ex.Message;
                            }
#else
					catch{ realname = pfd.ToString();}
#endif
                            finally
                            {
                                if (bakpfd != null || bakpkg != null)
                                    if (wrp is SimPe.Interfaces.Plugin.AbstractWrapper)
                                    {
                                        SimPe.Interfaces.Plugin.AbstractWrapper awrp = (SimPe.Interfaces.Plugin.AbstractWrapper)wrp;
                                        if (!awrp.AllowMultipleInstances)
                                        {
                                            awrp.FileDescriptor = bakpfd;
                                            awrp.Package = bakpkg;
                                        }
                                    }
                            }
                        } //lock
                    }

                }
                if (realname == null) realname = pfd.ToString();
            }

            return realname;
        }
    }
}
