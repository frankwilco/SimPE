using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper
{
    public interface IAspirationEditor
    {
        SimPe.Data.MetaData.AspirationTypes[] LoadAspirations(SDesc sim);
        void StoreAspirations(SimPe.Data.MetaData.AspirationTypes[] asps, SDesc sim);
    }
}
