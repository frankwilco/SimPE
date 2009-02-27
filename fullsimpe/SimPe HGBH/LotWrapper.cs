/***************************************************************************
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
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Lot
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
        byte[] filename = null;
		ushort subver = 0;
		Size sz;
		Ltxt.LotType type = Ltxt.LotType.Residential;
        Boolset roads = (byte)0x00; //noRoads = 0x00, atLeft = 0x01, atTop = 0x02, atRight = 0x04, atBottom = 0x08
        Ltxt.Rotation rotation = Ltxt.Rotation.toLeft;
        UInt32 unknown_0 = 0;
        string lotname = ""; //7bitstr
        string description = ""; //7bitstr
        // DWORD length
        List<UInt32> unknown_1;
        float unknown_2 = 0f; // if ver == 7 or 8
        UInt32 unknown_3 = 0; // if ver == 8
		#endregion

        #region Accessor methods
        public string FileName { get { return Helper.ToString(filename); } set { filename = Helper.ToBytes(value, 0x40); } }
        public LtxtSubVersion SubVersion { get { return (LtxtSubVersion)subver; } set { subver = (ushort)value; } }
        public Size LotSize { get { return sz; } set { sz = value; } }
        public Ltxt.LotType Type { get { return type; } set { type = value; } }
        public Boolset LotRoads { get { return roads; } set { roads = value; } }
        public byte LotRotation { get { return (byte)rotation; } set { rotation = (Ltxt.Rotation)value; } }
        internal UInt32 Unknown0 { get { return unknown_0; } set { unknown_0 = value; } }
        public string LotName { get { return lotname; } set { lotname = value; } }
        public string LotDesc { get { return description; } set { description = value; } }
        internal List<UInt32> Unknown1 { get { return unknown_1; } }
        internal float Unknown2 { get { return unknown_2; } }
        internal UInt32 Unknown3 { get { return unknown_3; } }
        #endregion

        /// <summary>
		/// Constructor
		/// </summary>
        public Lot()
            : base()
		{
            filename = new byte[64];
            sz = new Size(1, 1);
            unknown_1 = new List<UInt32>();
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
			return null;
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Lot Wrapper",
				"Peter L Jones",
				"Lot package lot descriptor.",
				1,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.ltxt.png"))
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
            filename = reader.ReadBytes(0x40);
			subver = reader.ReadUInt16();
			sz.Width = reader.ReadInt32();
			sz.Height = reader.ReadInt32();
            type = (Ltxt.LotType)reader.ReadByte();

			roads = reader.ReadByte();
            rotation = (Ltxt.Rotation)reader.ReadByte();			
			unknown_0 = reader.ReadUInt32();

            lotname = reader.ReadString();
            description = reader.ReadString();

            unknown_1 = new List<UInt32>();
			int len = reader.ReadInt32();
            for (int i = 0; i < len; i++) this.unknown_1.Add(reader.ReadUInt32());

            if (subver >= (UInt16)LtxtSubVersion.Voyage) unknown_2 = reader.ReadSingle(); else unknown_2 = 0;
            if (subver >= (UInt16)LtxtSubVersion.Freetime) unknown_3 = reader.ReadUInt32(); else unknown_3 = 0;
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
            writer.Write(filename);
            writer.Write(subver);
            writer.Write(sz.Width);
            writer.Write(sz.Height);
            writer.Write((byte)type);

            writer.Write((byte)roads);
            writer.Write((byte)rotation);
            writer.Write(unknown_0);

            writer.Write(lotname);
            writer.Write(description);

            writer.Write(unknown_1.Count);
            foreach (UInt32 i in unknown_1) writer.Write(i);

            if (subver >= (UInt16)LtxtSubVersion.Voyage) writer.Write(unknown_2);
            if (subver >= (UInt16)LtxtSubVersion.Freetime) writer.Write(unknown_3);
        }
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

        public const uint Lottype = 0x6C589723;
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
        public uint[] AssignableTypes { get { return new uint[] { Lottype, }; } }

		#endregion		

		protected override string GetResourceName(SimPe.Data.TypeAlias ta)
		{
			if (!this.Processed) ProcessData(FileDescriptor, Package);
			return LotName;
		}

	}
}
