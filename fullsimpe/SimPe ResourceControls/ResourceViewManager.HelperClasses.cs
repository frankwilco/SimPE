using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    partial class ResourceViewManager
    {
        

        public enum SortColumn
        {
            Name = 0,            
            Group = 1,
            InstanceHi = 2,
            InstanceLo = 3,
            Offset = 4,
            Size = 5,
            Type = 6,
            Instance = 7,
            Extension = 8,
        }

        public class ResourceList : List<SimPe.Interfaces.Files.IPackedFileDescriptor> { }
        public class ResourceNameList : List<NamedPackedFileDescriptor>
        {
            DescriptorSort sorter;
            public ResourceNameList()
                : base()
            {
                sorter = new DescriptorSort();

            }


            class DescriptorSort : IComparer<NamedPackedFileDescriptor>
            {
                SortColumn sc;
                bool asc;


                public DescriptorSort()
                {
                    sc = SortColumn.Offset;
                    asc = true;
                }

                public SortColumn Column
                {
                    get { return sc; }
                    set { sc = value; }
                }

                public bool Asc
                {
                    get { return asc; }
                    set { asc = value; }
                }

                #region IComparer<NamedPackedFileDescriptor> Member

                public int Compare(NamedPackedFileDescriptor x, NamedPackedFileDescriptor y)
                {
                    if (asc)
                    {
                        if (sc == SortColumn.Name) return x.GetRealName().CompareTo(y.GetRealName());
                        if (sc == SortColumn.Type || sc == SortColumn.Extension) return x.Descriptor.Type.CompareTo(y.Descriptor.Type);
                        if (sc == SortColumn.Group) return x.Descriptor.Group.CompareTo(y.Descriptor.Group);
                        if (sc == SortColumn.InstanceHi) return x.Descriptor.SubType.CompareTo(y.Descriptor.SubType);
                        if (sc == SortColumn.InstanceLo) return x.Descriptor.Instance.CompareTo(y.Descriptor.Instance);
                        if (sc == SortColumn.Instance) return x.Descriptor.LongInstance.CompareTo(y.Descriptor.LongInstance);
                        if (sc == SortColumn.Offset) return x.Descriptor.Offset.CompareTo(y.Descriptor.Offset);
                        if (sc == SortColumn.Size) return x.Descriptor.Size.CompareTo(y.Descriptor.Size);
                    }
                    else
                    {
                        if (sc == SortColumn.Name) return y.GetRealName().CompareTo(x.GetRealName());
                        if (sc == SortColumn.Type || sc == SortColumn.Extension) return y.Descriptor.Type.CompareTo(x.Descriptor.Type);
                        if (sc == SortColumn.Group) return y.Descriptor.Group.CompareTo(x.Descriptor.Group);
                        if (sc == SortColumn.InstanceHi) return y.Descriptor.SubType.CompareTo(x.Descriptor.SubType);
                        if (sc == SortColumn.InstanceLo) return y.Descriptor.Instance.CompareTo(x.Descriptor.Instance);
                        if (sc == SortColumn.Instance) return y.Descriptor.LongInstance.CompareTo(x.Descriptor.LongInstance);
                        if (sc == SortColumn.Offset) return y.Descriptor.Offset.CompareTo(x.Descriptor.Offset);
                        if (sc == SortColumn.Size) return y.Descriptor.Size.CompareTo(x.Descriptor.Size);
                    }
                    return 0;
                }

                #endregion
            }

            public void SortByColumn(SortColumn col, bool asc)
            {
                sorter.Column = col;
                sorter.Asc = asc;
                this.Sort(sorter);
            }
        }
    }
}
