using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    public partial class ScoreItemDefault : AScorItem
    {

        public ScoreItemDefault(ScorItem si)
            : base(si)
        {
            InitializeComponent();
            data = new byte[0];
        }

        internal override void SetData(string name, System.IO.BinaryReader reader)
        {
            textBox1.Text = name;
            base.SetData(name, reader);
            data = reader.ReadBytes((int)reader.BaseStream.Length);

            tb.Text = Helper.BytesToHexList(data, 4);
        }

        byte[] data;
        internal override void Serialize(System.IO.BinaryWriter writer)
        {
            base.Serialize(writer);
            writer.Write(data);
        }
    }
}
