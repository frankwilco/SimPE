/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 Peter L Jones                                      *
 *   pljones@users.sf.net                                                  *
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
using System.Collections.Generic;
using System.Drawing;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	public enum LtxtVersion: ushort 
	{		
		Original = 0x000D,
		Business = 0x000E,
        Apartment = 0x0012
	}

    public enum LtxtSubVersion : ushort
    {
        Original = 0x0006,
        Voyage = 0x0007,
        Freetime = 0x0008,
        Apartment = 0x000B
    }

	public enum LotOrientation : byte
	{
		Below = 0,
		Left = 1,
		Above = 2,
		Right = 3,
	}
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Ltxt
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		public enum LotType:byte 
		{
			Residential = 0x00,
			Community = 0x01,
			Dorm = 0x02,
			Greek = 0x03,
			Secret = 0x04,
            Hotel = 0x05,
            Unknown6 = 0x06,
            Unknown7 = 0x07,
            Condo = 0x08,
            Apartment = 0x09,
            Unknown = 0xff
		}
        public class Roads { public static byte noRoads = 0x00, atLeft = 0x01, atTop = 0x02, atRight = 0x04, atBottom = 0x08; }
        public enum Rotation { toLeft = 0x00, toTop, toRight, toBottom, };

		#region Attributes
		ushort ver;
		ushort subver;
		Size sz;
		LotType type;
        Boolset roads = Roads.noRoads;
        Rotation rotation;
        uint unknown_0;
        // DWORD length
        string lotname;
        // DWORD length
        string description;
        // DWORD length
        List<float> unknown_1;
        Single unknown_3;   //If subver >= Voyage 
        uint unknown_4;     //If subver >= Freetime 
        byte[] unknown_5;   //if subver >= Apartment Life
        Point loc;
		float elevation;
		uint lotInstance; // "DWORD unk"
        LotOrientation orient;
        // DWORD length
        string texture;
        byte unknown_2;
        uint owner;
        byte[] followup;
		#endregion

        #region Accessor methods
        public LtxtVersion Version { get { return (LtxtVersion)ver; } set { ver = (ushort)value; } }
        internal LtxtSubVersion SubVersion { get { return (LtxtSubVersion)subver; } set { subver = (ushort)value; } }
        public Size LotSize { get { return sz; } set { sz = value; } }
        public LotType Type { get { return type; } set { type = value; } }
        public Boolset LotRoads { get { return roads; } set { roads = value; } }
        public byte LotRotation { get { return (byte)rotation; } set { rotation = (Rotation)value; } }
        internal uint Unknown0 { get { return unknown_0; } set { unknown_0 = value; } }
        public string LotName { get { return lotname; } set { lotname = value; } }
        public string LotDesc { get { return description; } set { description = value; } }
        internal List<float> Unknown1 { get { return unknown_1; } }
        internal Single Unknown3 { get { return unknown_3; } set { unknown_3 = value; } }
        internal uint Unknown4 { get { return unknown_4; } set { unknown_4 = value; } }
        internal byte[] Unknown5
        {
            get { return unknown_5; }
            set
            {
                unknown_5 = new byte[14];
                for (int i = 0; i < value.Length && i < unknown_5.Length; i++) unknown_5[i] = value[i];
            }
        }
            public Point LotPosition { get { return loc; } set { loc = value; } }
        public float LotElevation { get { return elevation; } set { elevation = value; } }
        public uint LotInstance { get { return lotInstance; } set { lotInstance = value; } }
        public LotOrientation Orientation { get { return orient; } set { orient = value; } }
        public string Texture { get { return texture; } set { texture = value; } }
        internal byte Unknown2 { get { return unknown_2; } set { unknown_2 = value; } }
        public uint OwnerInstance { get { return owner; } set { owner = value; } }
        internal byte[] Followup { get { return followup; } set { followup = value; } }
        #endregion

        public SimPe.Interfaces.Providers.ILotItem LotDescription
		{
			get 
			{
				return SimPe.FileTable.ProviderRegistry.LotProvider.FindLot(this.LotInstance);
			}
		}

        Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		public Ltxt() : this(FileTable.ProviderRegistry) {}
		/// <summary>
		/// Constructor
		/// </summary>
		public Ltxt(Interfaces.IProviderRegistry provider) : base()
		{
			this.provider = provider;

			unknown_1 = new List<float>();
			sz = new Size(1, 1);
			elevation = 0x439D;
			
			this.followup = new byte[0];
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			return true;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new LtxtUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Lot Description Wrapper",
				"Quaxi",
				"This File contains the Description for a Lot.",
				7,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ltxt.png"))
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{			
            
			ver = reader.ReadUInt16();
			subver = reader.ReadUInt16();
			sz.Width = reader.ReadInt32();
			sz.Height = reader.ReadInt32();			
			type = (LotType)reader.ReadByte();

			roads = reader.ReadByte();
			rotation = (Rotation)reader.ReadByte();			
			unknown_0 = reader.ReadUInt32();

			lotname = StreamHelper.ReadString(reader);			
			description = StreamHelper.ReadString(reader);

            unknown_1 = new List<float>();
			int len = reader.ReadInt32();
            for (int i = 0; i < len; i++) this.unknown_1.Add(reader.ReadSingle());

            if (subver >= (UInt16)LtxtSubVersion.Voyage) unknown_3 = reader.ReadSingle(); else unknown_3 = 0;
            if (subver >= (UInt16)LtxtSubVersion.Freetime) unknown_4 = reader.ReadUInt32(); else unknown_4 = 0;

            if (ver >= (UInt16)LtxtVersion.Apartment || subver >= (UInt16)LtxtSubVersion.Apartment)
            {
                unknown_5 = reader.ReadBytes(14);
            }
            else
            {
                unknown_5 = new byte[0];
            }

			int y = reader.ReadInt32();
			int x = reader.ReadInt32();
			loc = new Point(x, y);
            
			elevation = reader.ReadSingle();
			lotInstance = reader.ReadUInt32();
            orient = (LotOrientation)reader.ReadByte();

            texture = StreamHelper.ReadString(reader);

			unknown_2 = reader.ReadByte();

            if (ver>=(int)LtxtVersion.Business) owner = reader.ReadUInt32();
			else owner = 0;

			followup = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));			
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
			writer.Write(ver);
			writer.Write(this.subver);
			writer.Write(sz.Width);
			writer.Write(sz.Height);			
			writer.Write((byte)type);
			
			writer.Write((byte)roads);
			writer.Write((byte)rotation);			
			writer.Write(unknown_0);

			StreamHelper.WriteString(writer, lotname);
			StreamHelper.WriteString(writer, description);			

			writer.Write(unknown_1.Count);
			foreach (int i in unknown_1) writer.Write(i);

            if (subver >= (UInt16)LtxtSubVersion.Voyage) writer.Write(unknown_3);
            if (subver >= (UInt16)LtxtSubVersion.Freetime) writer.Write(unknown_4);
            if (ver >= (UInt16)LtxtVersion.Apartment || subver >= (UInt16)LtxtSubVersion.Apartment)
            {
                writer.Write(unknown_5);
            }

            
            writer.Write((int)loc.Y);
			writer.Write((int)loc.X);
            
			writer.Write(elevation);
			writer.Write(lotInstance);
			writer.Write((byte)orient);

			StreamHelper.WriteString(writer, texture);	

			writer.Write(unknown_2);

            if (ver>=(int)LtxtVersion.Business) writer.Write(owner);

            writer.Write(followup);
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
								   0x0BF999E7   //handles the LTXT File
							   };
				return types;
			}
		}

		#endregion		

		protected override string GetResourceName(SimPe.Data.TypeAlias ta)
		{
			if (!this.Processed) ProcessData(FileDescriptor, Package);
			return LotName;
		}

	}
}
