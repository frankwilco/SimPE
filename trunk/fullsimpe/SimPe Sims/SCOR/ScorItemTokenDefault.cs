using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    class ScorItemTokenDefault : IScorItemToken
    {
        public byte[] UnserializeToken(ScorItem si, System.IO.BinaryReader reader)
        {
            return ScorItem.UnserializeDefaultToken(reader);
        }

        public SCOR.AScorItem ActivatedGUI
        {
            get { return null; }
        }
    }
}
