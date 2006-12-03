/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *                                                                         *
 *   This program is free software; you can redistribute it and/or modify  *
 *   it under the terms of the GNU General Public License as published by  *
 *   the Free Software Foundation; either version 2 of the License, or     *
 *   (at your option) any later version.                                   *
 *                                                                         *
 *   This program is distributed in the hope that it will be useful,       *
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of        *
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the         *
 *   GNU General Public License for more details.                          *
 *                                                                         *
 *   You should have received a copy of the GNU General Public License     *
 *   along with this program; if not, write to the                         *
 *   Free Software Foundation, Inc.,                                       *
 *   59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.             *
 ***************************************************************************/
using System;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using System.Collections;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für ScorWrapper.
	/// </summary>
	public class Scor
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		, IMultiplePackedFileWrapper
        , System.Collections.Generic.IEnumerable<ScorItem>
	{		

		#region Attributes
		ScorItems items;
		protected ScorItems Items
		{
			get {return items;}
		}
		uint version;
		/// <summary>
		/// Returns the Version of this File
		/// </summary>
		public uint Version 
		{
			get { return version; }
		}		

		uint unk1, unk2;

		public uint Unknown1
		{
			get {return unk1;}
		}

		public uint Unknown2
		{
			get {return unk2;}
		}
		#endregion
				
		/// <summary>
		/// Constructor
		/// </summary>
		public Scor() : base()
		{
			version = 0;
			items = new ScorItems();
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			return true;
		}
		#endregion

        protected override string GetResourceName(TypeAlias ta)
        {
            ExtSDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim((ushort)this.FileDescriptor.Instance) as ExtSDesc;
            if (sdsc == null)
                return base.GetResourceName(ta);
            else
                return sdsc.SimName + " " + sdsc.SimFamilyName + " (Scores)";
        }
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new UserInterface.ScorUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Sim Score Wrapper",
				"Quaxi",
				"Seems to contain some sort of Scores for a specific Sim",
				2,
				null
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			unk1 = reader.ReadUInt32();
			unk2 = reader.ReadUInt32();

			items.Clear();
			while (reader.BaseStream.Position<reader.BaseStream.Length) 
			{
				ScorItem si = new ScorItem(this);
				si.Unserialize(reader);

				items.Add(si);
			}

            if (LoadedNewResource != null) LoadedNewResource(this, new EventArgs());
		}

        

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		protected override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);
			writer.Write(unk1);
			writer.Write(unk2);

			for (int i=0; i<items.Count; i++) 
			{
				ScorItem si = items[i];
				si.Serialize(writer, (i==items.Count-1));
			}
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		/// <summary>
		/// Returns the Signature that can be used to identify Files processable with this Plugin
		/// </summary>
		public byte[] FileSignature
		{
			get
			{
				return new byte[0];
			}
		}

		/// <summary>
		/// Returns a list of File Type this Plugin can process
		/// </summary>
		public uint[] AssignableTypes
		{
			get
			{
				uint[] types = {
								  0x3053CF74
							   };
				return types;
			}
		}

		#endregion		

        public class ChangedListEventArgs : EventArgs{
            ScorItem si;
            public ChangedListEventArgs(ScorItem si)
            {
                this.si = si;
            }

            public ScorItem Item
            {
                get { return si; }
            }
        }
        public delegate void ChangedListHandler(Scor sender, ChangedListEventArgs e);
        public event ChangedListHandler AddedItem;
        public event ChangedListHandler RemovedItem;
        public event System.EventHandler LoadedNewResource;

        public void Add(string name)
        {
            ChangedListEventArgs e = new ChangedListEventArgs(new ScorItem(name, this));
            this.Items.Add(e.Item);
            if (AddedItem != null) AddedItem(this, e);
            this.Changed = true;
        }

        public void Remove(ScorItem si)
        {
            if (si == null) return;
            items.Remove(si);
            ChangedListEventArgs e = new ChangedListEventArgs(si);
            if (RemovedItem != null) RemovedItem(this, e);
            this.Changed = true;
        }

        public ScorItem this[int index]
        {
            get { return items[index]; }
        }


        public int Count
        {
            get { return items.Count; }
        }

        #region IEnumerable Members

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        #endregion

        #region IEnumerable<ScorItem> Members

        System.Collections.Generic.IEnumerator<ScorItem> System.Collections.Generic.IEnumerable<ScorItem>.GetEnumerator()
        {
            return items.GetScorItemEnumerator();
        }

        #endregion
    }
}
