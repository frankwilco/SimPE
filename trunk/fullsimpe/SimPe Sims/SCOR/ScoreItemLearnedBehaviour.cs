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
        }

        #region Behaviours
        static List<ExtObjd> objds;
        protected static List<ExtObjd> BehaviourObjds
        {
            get
            {
                if (objds == null) GetPetBehaviours();
                return objds;
            }
        }

        private static void GetPetBehaviours()
        {
            if (objds != null) return;
            objds = new List<ExtObjd>();

            FileTable.FileIndex.Load();
            SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] globs = FileTable.FileIndex.FindFile(Data.MetaData.GLOB_FILE, true);
            foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in globs)
            {
                SimPe.Plugin.Glob glb = new SimPe.Plugin.Glob();
                glb.ProcessData(fii);
                if (glb.SemiGlobalGroup == 0x7FD90EDB)
                {
                    SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] objs = FileTable.FileIndex.FindFile(Data.MetaData.OBJD_FILE, fii.FileDescriptor.Group);
                    foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem ofii in objs)
                    {
                        ExtObjd obj = new ExtObjd();
                        obj.ProcessData(ofii);
                        if (obj.FileName.StartsWith("Learned Behavior"))
                        {
                            objds.Add(obj);
                            Console.WriteLine(obj.ResourceName);
                        }
                    }
                }
            }
        }
        #endregion

        internal override void SetData(string name, System.IO.BinaryReader reader)
        {
            base.SetData(name, reader);
            int ct = reader.ReadInt32();
            cb.Items.Clear();
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
            if (e != null)
            {
                textBox1.Text = "0x" + Helper.HexString(e.Unknown1);
                textBox2.Text = "0x" + Helper.HexString(e.Guid);
                textBox3.Text = "0x" + Helper.HexString(e.Value);
                textBox4.Text = "0x" + Helper.HexString(e.Unknown3);

                textBox5.Text = BitConverter.ToSingle(BitConverter.GetBytes(e.Value), 0).ToString();
                textBox6.Text = e.Value.ToString();
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
                e.Value = Helper.StringToUInt32(textBox6.Text, e.Value, 10);
                Changed = true;
            }
        }
    }
}
