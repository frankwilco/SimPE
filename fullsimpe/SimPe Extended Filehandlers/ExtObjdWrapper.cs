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

namespace SimPe.PackedFiles.Wrapper
{
	#region Room Sort
	public class ObjRoomSort : FlagBase 
	{
		public ObjRoomSort(short flags) : base((ushort)flags) {}

		public bool InBathroom
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Bathroom); }
			set { SetBit((byte)Data.ObjRoomSortBits.Bathroom, value); }
		}

		public bool InBedroom
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Bedroom); }
			set { SetBit((byte)Data.ObjRoomSortBits.Bedroom, value); }
		}

		public bool InDiningRoom
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.DiningRoom); }
			set { SetBit((byte)Data.ObjRoomSortBits.DiningRoom, value); }
		}

		public bool InKitchen
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Kitchen); }
			set { SetBit((byte)Data.ObjRoomSortBits.Kitchen, value); }
		}

		public bool InLivingRoom
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.LivingRoom); }
			set { SetBit((byte)Data.ObjRoomSortBits.LivingRoom, value); }
		}

		public bool InMisc
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Misc); }
			set { SetBit((byte)Data.ObjRoomSortBits.Misc, value); }
		}

		public bool InOutside
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Outside); }
			set { SetBit((byte)Data.ObjRoomSortBits.Outside, value); }
		}

		public bool InStudy
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Study); }
			set { SetBit((byte)Data.ObjRoomSortBits.Study, value); }
		}

		public bool InKids
		{
			get { return GetBit((byte)Data.ObjRoomSortBits.Kids); }
			set { SetBit((byte)Data.ObjRoomSortBits.Kids, value); }
		}
	}
	#endregion

	#region Function Sort
	public class ObjFunctionSort : FlagBase 
	{
		public ObjFunctionSort(short flags) : base((ushort)flags) {}

		public bool InAppliances
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Appliances); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Appliances, value); }
		}

		public bool InDecorative
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Decorative); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Decorative, value); }
		}

		public bool InElectronics
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Electronics); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Electronics, value); }
		}

		public bool InGeneral
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.General); }
			set { SetBit((byte)Data.ObjFunctionSortBits.General, value); }
		}

		public bool InLighting
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Lighting); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Lighting, value); }
		}

		public bool InPlumbing
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Plumbing); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Plumbing, value); }
		}

		public bool InSeating
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Seating); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Seating, value); }
		}

		public bool InSurfaces
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Surfaces); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Surfaces, value); }
		}

		public bool InHobbies
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.Hobbies); }
			set { SetBit((byte)Data.ObjFunctionSortBits.Hobbies, value); }
		}

		public bool InAspirationRewards
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.AspirationRewards); }
			set { SetBit((byte)Data.ObjFunctionSortBits.AspirationRewards, value); }
		}

		public bool InCareerRewards
		{
			get { return GetBit((byte)Data.ObjFunctionSortBits.CareerRewards); }
			set { SetBit((byte)Data.ObjFunctionSortBits.CareerRewards, value); }
		}
	}
	#endregion

	/// <summary>
	/// Represents a PackedFile in SDsc Format
	/// </summary>
	public class ExtObjd : AbstractWrapper, SimPe.Interfaces.Plugin.IFileWrapper, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension
	{
		#region Attributes
		/// <summary>
		///the stored Filename		
		/// </summary>
        private byte[] filename;

		/// <summary>
		/// The Type of this File
		/// </summary>
		private short[] data; 

		

		/// <summary>
		/// Returns/Sets the Name of a Sim
		/// </summary>
		public string FileName
		{
			get 
			{
				return Helper.ToString(filename);
			}		
			set 
			{
				filename = Helper.SetLength(Helper.ToBytes(value, 64), 64);
			}
		}

		/// <summary>
		/// Returs / Sets the stored Data
		/// </summary>
		public short[] Data
		{
			get { return data; }
			set { data = value; }
		}

		uint guid, proxyguid, originalguid;

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint Guid
		{
			get { return guid; }
			set { guid = value; }
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint ProxyGuid
		{
			get { return proxyguid; }
			set { proxyguid = value; }
		}

		/// <summary>
		/// Returns the GUID of the Object
		/// </summary>
		public uint OriginalGuid
		{
			get { return originalguid; }
			set { originalguid = value; }
		}
		

		/// <summary>
		/// returns the Instance of the assigned Catalog Description
		/// </summary>
		public ushort CTSSInstance 
		{
			get 
			{ 
				if (data.Length>0x29) return (ushort)data[0x29]; 
				return 0;
			}
			set 
			{ 
				if (data.Length>0x29) data[0x29] = (short)value; 
			}
		}

		/// <summary>
		/// Retursn / Sets the Type of an Object
		/// </summary>
		public SimPe.Data.ObjectTypes Type 
		{
			get { 
				if (data.Length>0x09) return (SimPe.Data.ObjectTypes)data[0x09]; 
				return SimPe.Data.ObjectTypes.Normal;
			}
			set { 
				if (data.Length>0x09) data[0x09] = (short)value; 
			}
		}

		ObjRoomSort rsort;
		/// <summary>
		/// Returns the Room Sort Flags
		/// </summary>
		public ObjRoomSort RoomSort
		{
			get { return rsort; }
			set { rsort = value; }
		}

		ObjFunctionSort fsort;
		/// <summary>
		/// Returns the Function Sort Flags
		/// </summary>
		public ObjFunctionSort FunctionSort
		{
			get { return fsort; }
			set { fsort = value; }
		}
		#endregion

		/// <summary>
		/// Returns the Length of the File
		/// </summary>
		protected int Length
		{
			get { return (int)(data.Length*2 + 0x40); }
		}


		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Extended OBJD Wrapper",
				"Quaxi",
				"---",
				2
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.ExtObjdUI();
		}

		Interfaces.Providers.IOpcodeProvider opcodes;
		/// <summary>
		/// Null or an Opcode Provider
		/// </summary>
		public Interfaces.Providers.IOpcodeProvider Opcodes
		{
			get { return opcodes; }
		}

		public ExtObjd(Interfaces.Providers.IOpcodeProvider opcodes) : base()
		{			
			filename = new byte[0x40];
			data = new short[0x06];
			this.opcodes = opcodes;
			Type = SimPe.Data.ObjectTypes.Normal;
			rsort = new ObjRoomSort(0);
			fsort = new ObjFunctionSort(0);
		}

		protected override void Unserialize(System.IO.BinaryReader reader)
		{						
			filename = reader.ReadBytes(0x40);				
			int count = (int)((reader.BaseStream.Length - 0x40) / 2);
			data = new short[count];
			for (int i=0; i<count; i++) data[i] = reader.ReadInt16();

			//read some special Data
			if (Length>0x5c+4)
			{				
				reader.BaseStream.Seek(0x5c, System.IO.SeekOrigin.Begin);
				guid = reader.ReadUInt32();
			}

			if (Length>0x7a+4)
			{				
				reader.BaseStream.Seek(0x7a, System.IO.SeekOrigin.Begin);
				proxyguid = reader.ReadUInt32();
			}

			if (Length>0xcc+4)
			{
				reader.BaseStream.Seek(0xcc, System.IO.SeekOrigin.Begin);
				originalguid = reader.ReadUInt32();
			}

			if (data.Length>0x28)
			{
				this.rsort = new ObjRoomSort(data[0x27]);
				this.fsort = new ObjFunctionSort(data[0x28]);
			}
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			if (data.Length>0x27)
			{
				data[0x27] = (short)this.rsort.Value;
				data[0x28] = (short)this.fsort.Value;
			}

			writer.Write(filename);
			foreach (short s in data) writer.Write(s);
			
			//write some special Fields
			if (Length>0x5c+4)
			{
				writer.BaseStream.Seek(0x5c, System.IO.SeekOrigin.Begin);
				writer.Write(guid);
			}

			if (Length>0x7a+4) 
			{
				writer.BaseStream.Seek(0x7a, System.IO.SeekOrigin.Begin);
				writer.Write(proxyguid);
			}

			if (Length>0xcc+4)
			{
				writer.BaseStream.Seek(0xcc, System.IO.SeekOrigin.Begin);
				writer.Write(originalguid);
			}
		}
		#endregion

		#region IPackedFileWrapper Member
		public override string Description
		{
			get
			{
				return "FileName="+this.FileName+",GUID=0x"+Helper.HexString(this.Guid);
			}
		}

		public uint[] AssignableTypes
		{
			get 
			{
				uint[] Types = {
								   0x4F424A44
							   };
				return Types;
			}
		}


		public Byte[] FileSignature
		{
			get 
			{
				Byte[] sig = {					 
							 };
				return sig;
			}
		}		

		

		#endregion
	}
}
