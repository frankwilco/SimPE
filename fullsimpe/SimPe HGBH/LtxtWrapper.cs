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
using System.Drawing;
using SimPe.Interfaces.Plugin;

namespace SimPe.Plugin
{
	public enum LtxtVersion: ushort 
	{		
		Original = 0x000D,
		Business = 0x000E
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
			Unknown = 0xff
		}

		#region Attributes
		LotType type;
		Size sz;
		Point loc;
		byte orient;
		ushort unknown_2;
		byte unknown_4;
		ushort ver;
		short groundlevel;
		uint inst, owner;

		public SimPe.Interfaces.Providers.ILotItem LotDescription
		{
			get 
			{
				return SimPe.FileTable.ProviderRegistry.LotProvider.FindLot(this.LotInstance);
			}
		}

		internal ushort Unknown2 
		{
			get {return  unknown_2;}
			set {unknown_2 = value;}
		}

		internal byte Unknown4 
		{
			get {return  unknown_4;}
			set {unknown_4 = value;}
		}

		internal uint Unknown0
		{
			get {return  unknown_0;}
			set {unknown_0 = value;}
		}

		public uint OwnerInstance
		{
			get {return owner;}
			set {owner = value;}
		}

		public LtxtVersion Version 
		{
			get {return (LtxtVersion)ver;}
			set { ver = (ushort)value;}
		}

		public LotOrientation Orientation 
		{
			get {return (LotOrientation)orient;}
			set { orient = (byte)value;}
		}

		public Size LotSize
		{
			get {return sz;}
			set {sz = value;}
		}

		public Point LotPosition
		{
			get {return loc;}
			set {loc = value;}
		}

		public short GroundLevel
		{
			get {return groundlevel;}
			set {groundlevel = value;}
		}

		public LotType Type 
		{
			get { return type; }
			set { type = value; }
		}

		byte lotinst;
		public byte LotID 
		{
			get { return lotinst; }
			set { lotinst = value; }
		}

		public uint LotInstance 
		{
			get { return inst; }
			set { inst = value; }
		}

		byte houseinst;
		public byte HouseInstance 
		{
			get { return houseinst; }
			set { houseinst = value; }
		}

		uint unknown_0;
		string lotname;
		public string LotName 
		{
			get { return lotname; }
			set { lotname = value; }
		}

		string housename;
		public string HouseName 
		{
			get { return housename; }
			set { housename = value; }
		}
		internal ushort Unknown1
		{
			get {return unknown_1;}
			set { unknown_1 = value;}
		}
		ushort unknown_1;
		public byte[] Followup 
		{
			get { return followup; }
			set { followup = value; }
		}

		string name;
		public string Name 
		{
			get { return name; }
			set { name = value; }
		}

		byte[] followup;

		SimPe.IntArrayList unknown_3;
		internal SimPe.IntArrayList Unknown3
		{
			get {return unknown_3;}
		}
		#endregion

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

			unknown_3 = new IntArrayList();
			unknown_2 = 0;
			this.ver = (ushort)LtxtVersion.Original;
			orient = (byte)LotOrientation.Below;
			sz = new Size(1, 1);
			lotname = "";
			housename = "";
			groundlevel = 0x439D;
			
			name = "";
			this.followup = new byte[1];
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
				4,
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
			unknown_2 = reader.ReadUInt16();
			sz.Width = reader.ReadInt32();
			sz.Height = reader.ReadInt32();			
			type = (LotType)reader.ReadByte();
			

			lotinst = reader.ReadByte();
			houseinst = reader.ReadByte();			
			unknown_0 = reader.ReadUInt32();

						
			lotname = StreamHelper.ReadString(reader);			
			housename = StreamHelper.ReadString(reader);		

			this.unknown_3.Clear();
			int len = reader.ReadInt32();			
			for (int i=0; i<len; i++) 			
				this.unknown_3.Add(reader.ReadInt32());			

			int y = reader.ReadInt32();
			int x = reader.ReadInt32();
			loc = new Point(x, y);			
			unknown_1 = reader.ReadUInt16();
			groundlevel = reader.ReadInt16();
			inst = reader.ReadUInt32();
			orient = reader.ReadByte();

			name = StreamHelper.ReadString(reader);		

			unknown_4 = reader.ReadByte();
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
			writer.Write((ushort)ver);
			writer.Write((ushort)this.unknown_2);
			writer.Write((int)sz.Width);
			writer.Write((int)sz.Height);			
			writer.Write((byte)type);
			
			writer.Write(lotinst);
			writer.Write(houseinst);			
			writer.Write(unknown_0);

			StreamHelper.WriteString(writer, lotname);
			StreamHelper.WriteString(writer, housename);			

			writer.Write((int)unknown_3.Count);
			foreach (int i in unknown_3)
				writer.Write(i);

			writer.Write((int)loc.Y);
			writer.Write((int)loc.X);			
			writer.Write(unknown_1);
			writer.Write(groundlevel);
			writer.Write(inst);
			writer.Write((byte)orient);

			StreamHelper.WriteString(writer, name);		

			writer.Write(unknown_4);
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
