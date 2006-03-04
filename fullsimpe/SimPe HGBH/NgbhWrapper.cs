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
using System.Collections;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	public enum NgbhVersion : uint
	{
		University = 0x70,
		Nightlife = 0xbe,
		Business = 0xc2
	}

	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Ngbh
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		
		#region Attributes
		uint version;
		public NgbhVersion Version
		{
			get {return (NgbhVersion)version; }
			set { version = (uint)value; }
		}

		byte[] id;
		byte[] header;
		byte[] zonename;
		byte[] zero;

		
		NgbhSlotList[] preitems;
		NgbhSlot[] slota;
		NgbhSlot[] slotb;
		NgbhSlot[] slotc;

		/// <summary>
		/// Returns / Sets a Slot
		/// </summary>
		public NgbhSlotList[] PreItems
		{
			get { return preitems;	}			
			set { preitems = value; }
		}

		/// <summary>
		/// Returns / Sets a Slot
		/// </summary>
		public NgbhSlot[] SlotsA 
		{
			get { return slota;	}			
			set { slota = value; }
		}

		/// <summary>
		/// Returns / Sets a Slot
		/// </summary>
		public NgbhSlot[] SlotsB 
		{
			get { return slotb;	}			
			set { slotb = value; }
		}

		/// <summary>
		/// Returns / Sets a Slot
		/// </summary>
		public NgbhSlot[] SlotsC 
		{
			get { return slotc;	}			
			set { slotc = value; }
		}

		#endregion

		Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		/// <summary>
		/// Returns a List of all items stored for a Sim in the gven Slot
		/// </summary>
		/// <param name="slots">The Slots of a sertain Block</param>
		/// <param name="instance">Instance Number of a Sim</param>
		/// <returns>the Slot for the given Sim or null</returns>
		public NgbhSlot GetSlot(NgbhSlot[] slots, uint instance)
		{
			foreach (NgbhSlot s in slots) if (s.SlotID == instance) return s;

			return null;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Ngbh(Interfaces.IProviderRegistry provider) : base()
		{
			
			this.provider = provider;


			this.id = new byte [] 
			{
				(byte)'H',
				(byte)'B',
				(byte)'G',
				(byte)'N'				
			};

			this.Version = NgbhVersion.University;

			this.header = new byte [] 
			{				
				0, 0, 0, 0,
				0x80, 0x00, 0x00, 0x00,
				0x80, 0x00, 0x00, 0x00
			};
			zonename = Helper.ToBytes("temperate", 9);
			zero = new byte[0x10];
			preitems = new NgbhSlotList[0x02];
			for (int i=0; i<preitems.Length; i++) preitems[i] = new NgbhSlotList(this);
			
			slota = new NgbhSlot[0];
			slotb = new NgbhSlot[0];
			slotc = new NgbhSlot[0];
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			if ( (version==0012) //0.10
				|| (version==0013) //0.12
				) 
			{
				return true;
			}

			return false;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new NgbhUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Neighborhood/Memory Wrapper",
				"Quaxi",
				"This File contains the Memories and Inventories of all Sims and Lots that Live in this Neighborhood.",
				9,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ngbh.png"))
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			ArrayList list = new ArrayList();

			id = reader.ReadBytes(id.Length);
			version = reader.ReadUInt32();
			header = reader.ReadBytes(header.Length);

			int textlen = reader.ReadInt32();
			zonename = reader.ReadBytes(textlen);			
			if (version>=(uint)NgbhVersion.Nightlife) zero = reader.ReadBytes(0x14);
			else zero = reader.ReadBytes(0x18);

			//read preitems
			for (int i=0; i<preitems.Length; i++) preitems[i].Unserialize(reader);
			

			int blocklen = reader.ReadInt32();
			slota = new NgbhSlot[blocklen];
			for (int i=0; i<slota.Length; i++) 
			{
				slota[i] = new NgbhSlot(this);
				slota[i].Unserialize(reader);
			}

			blocklen = reader.ReadInt32();
			slotb = new NgbhSlot[blocklen];
			for (int i=0; i<slotb.Length; i++) 
			{
				slotb[i] = new NgbhSlot(this);
				slotb[i].Unserialize(reader);
			}

			blocklen = reader.ReadInt32();
			slotc = new NgbhSlot[blocklen];
			for (int i=0; i<slotc.Length; i++) 
			{
				slotc[i] = new NgbhSlot(this);
				slotc[i].Unserialize(reader);
			}
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
			ArrayList list = new ArrayList();

			writer.Write(id);
			writer.Write(version);
			writer.Write(header);

			writer.Write((int)zonename.Length);
			writer.Write(zonename);			

			if (version>=(uint)NgbhVersion.Nightlife) zero = Helper.SetLength(zero, 0x14);
			else zero = Helper.SetLength(zero, 0x018);
			writer.Write(zero);

			//write preitems
			for (int i=0; i<preitems.Length; i++)  preitems[i].Serialize(writer);

			writer.Write((int)slota.Length);
			for (int i=0; i<slota.Length; i++) slota[i].Serialize(writer);

			writer.Write((int)slotb.Length);
			for (int i=0; i<slotb.Length; i++) slotb[i].Serialize(writer);

			writer.Write((int)slotc.Length);
			for (int i=0; i<slotc.Length; i++) slotc[i].Serialize(writer);

			/*writer.Write((int)0);
			writer.Write((int)writer.BaseStream.Position);*/
			writer.Write((byte)0);
			writer.Write((byte)1);
			writer.Write((byte)0);
			writer.Write((byte)0);
			writer.Write((byte)0);
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
								   0x4E474248   //handles the NGBH File
							   };
				return types;
			}
		}

		#endregion		
	}
}
