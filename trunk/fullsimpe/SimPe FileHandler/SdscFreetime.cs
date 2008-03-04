using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SimPe.PackedFiles.Wrapper
{
    /// <summary>
    /// Freetime specific Data
    /// </summary>
    public class SdscFreetime : Serializer
    {
        static IAspirationEditor aspeditor;
        public static void RegisterAsAspirationEditor(IAspirationEditor ed)
        {
            aspeditor = ed;
        }

        internal SdscFreetime(SDesc dsc)
        {
            parent = dsc;
            enthusiasm = new List<ushort>();
            decays = new List<ushort>();

            for (int i = 0; i < 11; i++) enthusiasm.Add(0);
            for (int i = 0; i < 7; i++) decays.Add(0);

            predestined = 0;
            ltasp = 0;
            unlockpts = 0;
            unlocksspent = 0;
            bugcollection = 0;

            LoadMemoryResource();
        }

        SDesc parent;
        List<ushort> enthusiasm;
        ushort predestined;
        ushort ltasp;
        ushort unlockpts;
        ushort unlocksspent;
        List<ushort> decays;
        uint bugcollection;

        public List<ushort> HobbyEnthusiasm
        {
            get { return enthusiasm; }
        }

        public static ushort HobbiesToIndex(Hobbies hb)
        {
            return (ushort)(((ushort)hb) - 0xcc);
        }

        public static Hobbies IndexToHobbies(int us)
        {
            return IndexToHobbies((ushort)us);
        }

        public static Hobbies IndexToHobbies(ushort us)
        {
            return (Hobbies)(us + 0xcc);
        }

        public Hobbies HobbyPredistined
        {
            get { return (Hobbies)predestined; }
            set { predestined = (ushort)value; }
        }

        public ushort LongtermAspiration
        {
            get { return ltasp; }
            set { ltasp = value; }
        }

        public ushort LongtermAspirationUnlockPoints
        {
            get { return unlockpts; }
            set { unlockpts = value; }
        }

        public ushort LongtermAspirationUnlocksSpent
        {
            get { return unlocksspent; }
            set { unlocksspent = value; }
        }



        public ushort HungerDecayModifier
        {
            get { return decays[0]; }
            set { decays[0] = value; }
        }

        public ushort ComfortDecayModifier
        {
            get { return decays[1]; }
            set { decays[1] = value; }
        }

        public ushort BladderDecayModifier
        {
            get { return decays[2]; }
            set { decays[2] = value; }
        }

        public ushort EnergyDecayModifier
        {
            get { return decays[3]; }
            set { decays[3] = value; }
        }

        public ushort HygieneDecayModifier
        {
            get { return decays[4]; }
            set { decays[4] = value; }
        }

        public ushort FunDecayModifier
        {
            get { return decays[5]; }
            set { decays[5] = value; }
        }

        public ushort SocialPublicDecayModifier
        {
            get { return decays[6]; }
            set { decays[6] = value; }
        }



        public uint BugCollection
        {
            get { return bugcollection; }
            set { bugcollection = value; }
        }



        internal void Unserialize(BinaryReader reader)
        {
            reader.BaseStream.Seek(0x1A4, SeekOrigin.Begin);
            for (int i = 0; i < enthusiasm.Count; i++)
            {
                enthusiasm[i] = reader.ReadUInt16();
            }

            predestined = reader.ReadUInt16();
            ltasp = reader.ReadUInt16();
            unlockpts = reader.ReadUInt16();
            unlocksspent = reader.ReadUInt16();

            for (int i = 0; i < decays.Count; i++)
            {
                decays[i] = reader.ReadUInt16();
            }

            bugcollection = reader.ReadUInt32();

            LoadAspirations();
        }

        internal void Serialize(BinaryWriter writer)
        {
            writer.BaseStream.Seek(0x1A4, SeekOrigin.Begin);

            for (int i = 0; i < enthusiasm.Count; i++)
            {
                writer.Write((ushort)enthusiasm[i]);
            }

            writer.Write((ushort)predestined);
            writer.Write((ushort)ltasp);
            writer.Write((ushort)unlockpts);
            writer.Write((ushort)unlocksspent);

            for (int i = 0; i < decays.Count; i++)
            {
                writer.Write((ushort)decays[i]);
            }

            writer.Write((uint)bugcollection);

            StoreAspirations();
        }

        SimPe.Interfaces.Files.IPackedFileDescriptor mempfd = null;
        protected void LoadMemoryResource()
        {
            mempfd = null;
            if (parent==null) return;
            if (parent.Package == null) return;

            SimPe.Interfaces.Plugin.IFileWrapper wrapper =
                (SimPe.Interfaces.Plugin.IFileWrapper)FileTable.WrapperRegistry.FindHandler(SimPe.Data.MetaData.MEMORIES);

            if (wrapper == null) return;

            SimPe.Interfaces.Files.IPackedFileDescriptor[] mems = parent.Package.FindFiles(SimPe.Data.MetaData.MEMORIES);
            foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in mems)
            {
                mempfd = pfd;
                return;
            }
        }

        SimPe.Data.MetaData.AspirationTypes pa, sa;
        protected void LoadAspirations()
        {
            pa = SimPe.Data.MetaData.AspirationTypes.Nothing;
            sa = SimPe.Data.MetaData.AspirationTypes.Nothing;
            if (parent == null) return;
            pa = parent.CharacterDescription.Aspiration;

            if (aspeditor == null) return;
            SimPe.Data.MetaData.AspirationTypes[] asps = aspeditor.LoadAspirations(this.parent);

            if (asps == null) return;
            if (asps.Length > 0) pa = asps[0];
            if (asps.Length > 1) sa = asps[1];
        }

        protected void StoreAspirations()
        {
            if (parent==null) return;
            if (aspeditor==null) return;
            SimPe.Data.MetaData.AspirationTypes[] asps = new SimPe.Data.MetaData.AspirationTypes[]{pa, sa};
            aspeditor.StoreAspirations(asps, parent);
        }


        /// <remarks>
        /// The return value of this attribute is always valid, 
        /// no matter which version the loaded SDSC was
        /// </remarks>
        public SimPe.Data.MetaData.AspirationTypes PrimaryAspiration
        {
            get {
                if (parent == null) return pa;
                if ((int)parent.Version >= (int)SDescVersions.Freetime) return pa;
                else return parent.CharacterDescription.Aspiration;
            }
            set {
                if ((int)parent.Version >= (int)SDescVersions.Freetime) pa = value;
                else parent.CharacterDescription.Aspiration = value;
            }
        }

        public SimPe.Data.MetaData.AspirationTypes SecondaryAspiration
        {
            get
            {
                return sa;
            }
            set
            {
                sa = value;
            }
        }
    }
}
