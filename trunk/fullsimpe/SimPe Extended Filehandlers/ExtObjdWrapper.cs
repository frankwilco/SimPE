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
	/// <summary>
	/// This is used to determin the Health of a OBJd File
	/// </summary>
	public enum ObjdHealth : byte 
	{
		Ok, 
		Unreadable,
		UnmatchingFilenames,
		OverLength
	}
	#region Room Sort
	public class ObjRoomSort : FlagBase 
	{
		public ObjRoomSort(short flags) : base((ushort)flags) {}
		public ObjRoomSort(object o) : base(o) {}

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
		public ObjFunctionSort(object o) : base(o) {}

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
	public class ExtObjd : AbstractWrapper, SimPe.Interfaces.Plugin.IFileWrapper, SimPe.Interfaces.Plugin.IFileWrapperSaveExtension, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper
	{
		#region Attributes
		/// <summary>
		///the stored Filename		
		/// </summary>
        private byte[] filename, filename2;

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

		public Data.ObjFunctionSubSort FunctionSubSort
		{
			get 
			{
				uint val = (uint)((data[0x5e]&0xff) | ((fsort.Value&0xfff)<<8));
				return (Data.ObjFunctionSubSort)val;
			}
			set 
			{
				uint val = (uint)value;
				fsort.Value = (ushort)((val >> 8) & 0xfff);
				data[0x5e] = (short)(val & 0xff);
			}
		}

		public short Price 
		{
			get {return data[0x12];}
			set {data[0x12] = value; }
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
				"This File is used to Set up the Basic Catalog Properties of an Object. It also contains the unique ID for the Objeect or a Part of the Object.",
				3,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Handlers.objd.png"))
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
			filename2 = new byte[0];
			data = new short[0xdc];
			this.opcodes = opcodes;
			Type = SimPe.Data.ObjectTypes.Normal;
			rsort = new ObjRoomSort(0);
			fsort = new ObjFunctionSort(0);
		}

		public void UpdateFlags()
		{
			if (data.Length>0x28)
			{
				this.rsort = new ObjRoomSort(data[0x27]);
				this.fsort = new ObjFunctionSort(data[0x28]);
			}
		}

		ObjdHealth ok;
		public ObjdHealth Ok
		{
			get {return ok; }
		}
		protected override void Unserialize(System.IO.BinaryReader reader)
		{	
			ok = ObjdHealth.Ok;		
			try 
			{
				UnserializeNew(reader);
			} 
			catch {
				ok = ObjdHealth.Unreadable;
				reader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
				UnserializeOld(reader);
			}

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

			
			UpdateFlags();
		}

		protected void UnserializeNew(System.IO.BinaryReader reader)
		{						
			filename = reader.ReadBytes(0x40);				
			int count = (int)((reader.BaseStream.Length - 0x40) / 2);
			count = 0x6c;
			data = new short[count];
			for (int i=0; i<count; i++) data[i] = reader.ReadInt16();

			int sz = reader.ReadInt32();
			filename2 = reader.ReadBytes(sz);
			
			if (Helper.ToString(filename2) != this.FileName) 
				ok = ObjdHealth.UnmatchingFilenames;

			if (reader.BaseStream.Position != reader.BaseStream.Length)
				ok = ObjdHealth.OverLength;
		}

		protected void UnserializeOld(System.IO.BinaryReader reader)
		{						
			filename = reader.ReadBytes(0x40);				
			int count = (int)((reader.BaseStream.Length - 0x40) / 2);
			data = new short[count];
			for (int i=0; i<count; i++) 
			{
				try 
				{
					data[i] = reader.ReadInt16();			
				} 
				catch (System.IO.EndOfStreamException ex)
				{
					throw new System.IO.EndOfStreamException("Reading Error in OBJd at "+i.ToString()+".", ex);
				}
			}
		}

		protected override void Serialize(System.IO.BinaryWriter writer) 
		{		
			const int MAX_VALUES = 0x6c;
			if (data.Length>0x27)
			{
				data[0x27] = (short)this.rsort.Value;
				data[0x28] = (short)this.fsort.Value;
			}

			writer.Write(filename);
			int ct =0;			
			foreach (short s in data) 
			{
				writer.Write(s);
				ct++;
				if (ct>=MAX_VALUES) break;
			}

			while (ct<MAX_VALUES) writer.Write((short)0);

			string flname = this.FileName;
			byte[] name = Helper.ToBytes(flname, 0);
			writer.Write((uint)name.Length);
			writer.Write(name);
			
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


			
			//if (free>0) writer.Write(new byte[free]);
		}
		#endregion

		#region IPackedFileWrapper Member
		public override string Description
		{
			get
			{
				return "FileName="+this.FileName+",GUID=0x"+Helper.HexString(this.Guid)+",Type="+this.Type.ToString();
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

		#region Property Grid
		static SimPe.PackedFiles.Wrapper.ObjdPropertyParser tpp;

		/// <summary>
		/// Return a PropertyParser, that enumerates all known Properties as <see cref="Ambertation.PropertyDescription"/> Objects
		/// </summary>
		public static SimPe.PackedFiles.Wrapper.ObjdPropertyParser PropertyParser
		{
			get 
			{
				if (tpp==null) 
					tpp = new SimPe.PackedFiles.Wrapper.ObjdPropertyParser(System.IO.Path.Combine(Helper.SimPeDataPath, "objddefinition.xml"));
				return tpp;
			}
		}

		#endregion

		#region IMultiplePackedFileWrapper Member

		public override object[] GetConstructorArguments()
		{
			
			return new object[] {this.opcodes};
		}		

		#endregion
	}
}
