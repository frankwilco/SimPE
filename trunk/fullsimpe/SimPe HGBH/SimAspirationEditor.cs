using System;
using System.Collections.Generic;
using System.Text;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
    class SimAspirationEditor : IAspirationEditor
    {

        public SimPe.Data.MetaData.AspirationTypes[] LoadAspirations(SDesc sim)
        {
            if (sim == null) return null;
            SimPe.Data.MetaData.AspirationTypes[] res = new SimPe.Data.MetaData.AspirationTypes[] { SimPe.Data.MetaData.AspirationTypes.Nothing, SimPe.Data.MetaData.AspirationTypes.Nothing };
            Array arr = Enum.GetValues(typeof(SimPe.Data.MetaData.AspirationTypes));
            ushort a = (ushort)sim.CharacterDescription.Aspiration;

            foreach (ushort i in arr)
            {
                if ((a & i) == i)
                {
                    if (res[0] == SimPe.Data.MetaData.AspirationTypes.Nothing) res[0] = (SimPe.Data.MetaData.AspirationTypes)i;
                    else res[1] = (SimPe.Data.MetaData.AspirationTypes)i;
                }
            }

            return res;
        }

        public void StoreAspirations(SimPe.Data.MetaData.AspirationTypes[] asps, SDesc sim)
        {
            if (sim==null) return;
            if (asps == null) return;
            if (asps.Length<2) return;

            ushort a = 0;
            for (int i = 0; i < 2; i++)
            {
                a |= (ushort)asps[i];
            }

            sim.CharacterDescription.Aspiration = (SimPe.Data.MetaData.AspirationTypes)a;
        }
    }
}
