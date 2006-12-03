using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    public partial class ScoreItemLearnedBehaviour : AScorItem
    {        
        public ScoreItemLearnedBehaviour(ScorItem si)
            : base(si)
        {
            InitializeComponent();
            llRemove.Enabled = false;

        }

        

        internal override void SetData(string name, System.IO.BinaryReader reader)
        {
            base.SetData(name, reader);
            cb.Items.Clear();
            if (reader.BaseStream.Length == 0)
                return;

            int ct = reader.ReadInt32();
            
            for (int i = 0; i < ct; i++)
            {
                Element e = new Element();
                e.LoadData(reader);
                cb.Items.Add(e);
            }

            if (cb.Items.Count>0) cb.SelectedIndex = 0;
        }

        internal override void Serialize(System.IO.BinaryWriter writer)
        {
            base.Serialize(writer);
            writer.Write(cb.Items.Count);
            foreach (Element e in cb.Items)
            {
                e.SaveData(writer);
            }
        }

        bool intern;
        private void cb_SelectedIndexChanged(object sender, EventArgs ea)
        {
            intern = true;
            Element e = cb.SelectedItem as Element;
            llRemove.Enabled = e != null;
            if (e != null)
            {
                textBox1.Text = "0x" + Helper.HexString(e.Unknown1);
                textBox2.Text = "0x" + Helper.HexString(e.Guid);
                textBox3.Text = "0x" + Helper.HexString(e.Value);
                textBox4.Text = "0x" + Helper.HexString(e.Unknown3);

                textBox5.Text = BitConverter.ToSingle(BitConverter.GetBytes(e.Value), 0).ToString();
                pbVal.Value = (int)e.Value;                
                cbGuid.SelectedGuid = e.Guid;
            }
            intern = false;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs ea)
        {
            if (intern) return;
            Element e = cb.SelectedItem as Element;
            if (e != null)
            {
                e.Unknown1 = (byte)Helper.StringToInt16(textBox1.Text, e.Unknown1, 16);
                e.Unknown3 = (byte)Helper.StringToInt16(textBox4.Text, e.Unknown3, 16);
                e.Guid = Helper.StringToUInt32(textBox2.Text, e.Guid, 16);
                e.Value = (uint)pbVal.Value;                
                Changed = true;

                cb.Items[cb.SelectedIndex] = e;
                cb.Refresh();
            }
        }

        private void cbGuid_SelectedIndexChanged(object sender, EventArgs es)
        {
            Element e = cb.SelectedItem as Element;
            
            if (e != null)
            {
                textBox2.Text = "0x" + Helper.HexString(cbGuid.SelectedGuid);                
            }
        }

        private void linkLabel2_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs es)
        {
            Element e = cb.SelectedItem as Element;

            if (e != null)
            {
                int index = Math.Max(0, cb.SelectedIndex);
                cb.Items.Remove(e);
                index = Math.Min(cb.Items.Count - 1, index);
                cb.SelectedIndex = index;
                if (ParentItem != null)
                    if (ParentItem.Parent != null)
                        ParentItem.Parent.Changed = true;
            }
        }

        void llAdd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs es)
        {
            Element e = new Element();
            cb.Items.Add(e);
            cb.SelectedIndex = cb.Items.Count - 1;
            if (ParentItem != null)
                if (ParentItem.Parent != null)
                    ParentItem.Parent.Changed = true;
        }
    }
}
