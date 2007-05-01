using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    interface IScorItemToken
    {
        byte[] UnserializeToken(ScorItem si, System.IO.BinaryReader reader);

        SCOR.AScorItem ActivatedGUI { get; }
    }
}
