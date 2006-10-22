using System;
namespace SimPe.Windows.Forms
{
    public interface IResourceViewFilter
    {
        bool Active { get; }
        bool IsFiltered(SimPe.Interfaces.Files.IPackedFileDescriptor pfd);
        event EventHandler ChangedFilter;
    }
}
