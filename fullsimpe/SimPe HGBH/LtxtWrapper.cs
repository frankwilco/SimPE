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
			Secret = 0x04,
			Unknown = 0xff
		}

		#region Attributes
		byte[] header;
		LotType type;
		public LotType Type 
		{
			get { return type; }
			set { type = value; }
		}

		byte lotinst;
		public byte LotInstance 
		{
			get { return lotinst; }
			set { lotinst = value; }
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
		
		byte[] unknown_1;
		public byte[] Unknown 
		{
			get { return unknown_1; }
			set { unknown_1 = value; }
		}

		string name;
		public string Name 
		{
			get { return name; }
			set { name = value; }
		}

		byte[] followup;
		#endregion

		Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Ltxt(Interfaces.IProviderRegistry provider) : base()
		{
			this.provider = provider;

			byte [] header = 
			{
				0x0D, 0x00, 0x06, 0x00,
				0x03, 0x00, 0x00, 0x00,
				0x03, 0x00, 0x00, 0x00
			};
			this.header = header;
			lotname = "";
			housename = "";
			this.unknown_1 = new byte[0x51];
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
				"---",
				3
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			header = reader.ReadBytes(0x0c);
			type = (LotType)reader.ReadByte();
			lotinst = reader.ReadByte();
			houseinst = reader.ReadByte();
			unknown_0 = reader.ReadUInt32();

			int len = reader.ReadInt32();
			lotname = Helper.ToString(reader.ReadBytes(len));

			len = reader.ReadInt32();
			housename = Helper.ToString(reader.ReadBytes(len));

			len = reader.ReadInt32();
			unknown_1 = reader.ReadBytes(len*4 + 0x11);

			len = reader.ReadInt32();
			name = Helper.ToString(reader.ReadBytes(len));

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
			writer.Write(header);
			writer.Write((byte)type);
			writer.Write(lotinst);
			writer.Write(houseinst);
			writer.Write(unknown_0);

			writer.Write((int)lotname.Length);
			writer.Write(Helper.ToBytes(lotname, (int)lotname.Length));

			writer.Write((int)housename.Length);
			writer.Write(Helper.ToBytes(housename, (int)housename.Length));

			writer.Write((int)((unknown_1.Length - 0x11) / 4));
			writer.Write(unknown_1);

			writer.Write((int)name.Length);
			writer.Write(Helper.ToBytes(name, (int)name.Length));

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
	}
}
