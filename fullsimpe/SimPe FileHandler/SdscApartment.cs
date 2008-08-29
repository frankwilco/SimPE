using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimPe.PackedFiles.Wrapper
{
    /// <summary>
    /// Freetime specific Data
    /// </summary>
    public class SdscApartment : Serializer
    {
        internal SdscApartment(SDesc dsc)
        {
            parent = dsc;
        }

        SDesc parent;
        short reputation;
        short probabilityToAppear;
        short titlePostName;

        public short Reputation { get { return reputation; } set { reputation = value; } }
        public short ProbabilityToAppear { get { return probabilityToAppear; } set { probabilityToAppear = value; } }
        //public short TitlePostName { get { return titlePostName; } set { titlePostName = value; } }

        internal void Unserialize(BinaryReader reader)
        {
            reader.BaseStream.Seek(0x1D4, SeekOrigin.Begin);
            reputation = reader.ReadInt16();
            probabilityToAppear = reader.ReadInt16();
            titlePostName = reader.ReadInt16();
        }

        internal void Serialize(BinaryWriter writer)
        {
            writer.BaseStream.Seek(0x1D4, SeekOrigin.Begin);
            writer.Write(reputation);
            writer.Write(probabilityToAppear);
            writer.Write(titlePostName);
        }
    }
}