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


namespace SimPe.PackedFiles.Wrapper
{
	public class RelationshipFlags : FlagBase 
	{
		public RelationshipFlags(ushort flags) : base(flags) {}

		public bool IsEnemy
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Enemy); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Enemy, value); }
		}

		public bool IsFriend
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Friends); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Friends, value); }
		}

		public bool IsBuddie
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Buddies); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Buddies, value); }
		}

		public bool HasCrush
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Crush); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Crush, value); }
		}

		public bool InLove
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Love); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Love, value); }
		}

		public bool GoSteady
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Steady); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Steady, value); }
		}

		public bool IsEngaged
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Engaged); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Engaged, value); }
		}

		public bool IsMarried
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Married); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Married, value); }
		}

		public bool IsFamilyMember
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Family); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Family, value); }
		}

		public bool IsKnown
		{
			get { return GetBit((byte)Data.MetaData.RelationshipStateBits.Known); }
			set { SetBit((byte)Data.MetaData.RelationshipStateBits.Known, value); }
		}
	}
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class SRel
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attribute
		/// <summary>
		/// Sores the Relationship Values
		/// </summary>
		private int[] values;

		/// <summary>
		/// Returns the Shortterm Relationship
		/// </summary>
		public int Shortterm 
		{
			get { return GetValue(0); }
			set { PutValue(0, value); }
		}

		/// <summary>
		/// Returns the Shortterm Relationship
		/// </summary>
		public int Longterm 
		{
			get { return GetValue(2); }
			set { PutValue(2, value); }
		}

		RelationshipFlags flags;

		/// <summary>
		/// Returns the Relationship Values.
		/// </summary>
		/// <remarks>The Meaning of the Bits is stored in MataData.RelationshipStateBits</remarks>
		public RelationshipFlags RelationState
		{
			get { return flags; }
			set { flags = value; }
		}

		/// <summary>
		/// The Type of Family Relationship the Sim has to another
		/// </summary>
		public Data.MetaData.RelationshipTypes FamilyRelation 
		{
			get { return (Data.MetaData.RelationshipTypes)GetValue(3); }
			set { PutValue(3, (int)value); }
		}

		/// <summary>
		/// some unknown values
		/// </summary>
		uint[] reserved;
		#endregion

		/// <summary>
		/// Assignes a Value to the given Slot
		/// </summary>
		/// <param name="slot">Slot Number</param>
		/// <param name="val">new Value</param>
		protected void PutValue(int slot, int val) 
		{
			if (values.Length<=slot) 
			{
				int[] tmp = new int[slot+1];
				values.CopyTo(tmp, 0);
				values = tmp;
			} 
			values[slot] = val;			
		}

		/// <summary>
		/// Returns the Value of teh Slot
		/// </summary>
		/// <param name="slot">Slotnumber</param>
		/// <returns>the stored Value</returns>
		protected int GetValue(int slot) 
		{
			if (values.Length>slot) return values[slot];
			else return 0;	
		}


		/// <summary>
		/// Constructor
		/// </summary>
		public SRel() : base()
		{
			reserved = new uint[3];
			values = new int[4];

			flags = new RelationshipFlags(0);
			flags.IsKnown = true;

			reserved[0] = 0x00000002;
			
		}		
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.SRel();
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			if (reader.BaseStream.Length<=0) return;

			reserved[0] = reader.ReadUInt32();			//unknown
			uint stored = reader.ReadUInt32();
			values = new int[Math.Max(3, stored)];		
			for (int i=0; i<stored; i++) values[i] = reader.ReadInt32();
			
			//set some special Attributes
			flags.Value = (ushort)values[1];
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
			//set some special Attributes
			values[1] = (int)(flags.Value | 0xffff0000);

			//write to file
			writer.Write(reserved[0]);
			writer.Write((uint)values.Length);
			for (int i=0; i<values.Length; i++) writer.Write(values[i]);
		}
		#endregion

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Sim Relation Wrapper",
				"Quaxi",
				"This File Contians the Relationship states for two Sims.",
				5,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Handlers.srel.png"))
				); 
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
				/// 
				/// TODO:  Add the Signature Array if needed
				/// 
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
				///
				/// TODO: Change or Remove the Filetypes
				/// 

				uint[] types = {
								   Data.MetaData.RELATION_FILE
							   }; //handles the Version Information File
				return types;
			}
		}

		#endregion		
	}
}
