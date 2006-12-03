using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    partial class ScoreItemLearnedBehaviour
    {
        class Element
        {
            public Element()
            {
                unk1 = 1;
                unk3 = 1;
            }

            byte unk1;
            public byte Unknown1
            {
                get { return unk1; }
                set { unk1 = value; }
            }

            uint guid;
            public uint Guid
            {
                get { return guid; }
                set { guid = value; }
            }

            uint val;
            public uint Value
            {
                get { return val; }
                set { val = value; }
            }

            byte unk3;
            public byte Unknown3
            {
                get { return unk3; }
                set { unk3 = value; }
            }

            public void LoadData(System.IO.BinaryReader reader)
            {
                unk1 = reader.ReadByte();
                guid = reader.ReadUInt32();
                
                unk3 = reader.ReadByte();
                val = reader.ReadUInt32();
            }

            public void SaveData(System.IO.BinaryWriter writer)
            {
                writer.Write(unk1);
                writer.Write(guid);
                writer.Write(unk3);
                writer.Write(val);
            }

            public override string ToString()
            {
                string s = "0x"+Helper.HexString(guid);;
                foreach (ExtObjd objd in LearnedBahaviourComboBox.BehaviourObjds)
                    if (objd.Guid == guid) s = objd.FileName;
                s += "(" + Helper.HexString(unk1) + " " + Helper.HexString(val) + " " + Helper.HexString(unk3) + ")";
                return s;
            }
        }
    }
}
