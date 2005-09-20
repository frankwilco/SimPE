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
using System.IO;


namespace SimPe.Plugin
{
	/// <summary>
	/// Class containing a BHAV Header
	/// </summary>
	public class BhavHeader
	{
		public BhavHeader()
		{
			format = 0x8007;
		}

		ushort format;
		public ushort Format 
		{
			get { return format; }
			set {format = value; }
		}

		uint count;
		public uint InstructionCount
		{
			get { return count; }
			set {count = value; }
		}

		byte headerflag;
		byte cacheflags; //name by pljones

		byte type;
		public byte Type 
		{
			get { return type; }
			set {type = value; }
		}

		byte argc;
		public byte ArgumentCount 
		{
			get { return argc; }
			set {argc = value; }
		}

		ushort locals;
		public ushort LocalVarCount 
		{
			get { return locals; }
			set {locals = value; }
		}

		ushort treeversion;
		public ushort TreeVersion 
		{
			get { return treeversion; }
			set {treeversion = value; }
		}

		ushort zero;
		public ushort Zero 
		{
			get { return zero; }
			set {zero = value; }
		}


		/// <summary>
		/// Reads the Data from a Stream
		/// </summary>
		/// <param name="reader"></param>
		public void Unserialize(BinaryReader reader) 
		{
			format = reader.ReadUInt16();
			switch (format) 
			{				
				case 0x8009: 
				{					
					count = (uint)reader.ReadUInt16();
					type = reader.ReadByte();
					argc = reader.ReadByte();
					locals = reader.ReadByte();
					headerflag = reader.ReadByte();
					treeversion = reader.ReadUInt16();
					zero = reader.ReadUInt16();
					cacheflags = reader.ReadByte();
					break;
				}
                case 0x8000:
				case 0x8001: 
				case 0x8002: 
				case 0x8004:
				case 0x8006: 
				case 0x8005: 
				case 0x8007:
				case 0x8008: 
				{					
					count = (uint)reader.ReadUInt16();
					type = reader.ReadByte();
					argc = reader.ReadByte();
					locals = reader.ReadByte();
					headerflag = reader.ReadByte();
					treeversion = reader.ReadUInt16();
					zero = reader.ReadUInt16();
					break;
				}
				case 0x8003: 				
				{
					type = reader.ReadByte();
					argc = reader.ReadByte();
					locals = (ushort) reader.ReadByte();
					zero = reader.ReadByte();
					treeversion = reader.ReadUInt16();					
					count = reader.ReadUInt32();
					break;
				}
				default: 
				{
					throw new Exception("Unknown BHAV Format "+format.ToString("X"));
				}
			} //switch
		}

		/// <summary>
		/// Writes the Data to a Stream
		/// </summary>
		/// <param name="writer"></param>
		public void Serialize(BinaryWriter writer) 
		{
			writer.Write(format);
			switch (format) 
			{
				case 0x8009:
				{					
					writer.Write((ushort)count);
					writer.Write(type);
					writer.Write(argc);
					writer.Write((byte)locals);
					writer.Write((byte)headerflag);
					writer.Write(treeversion);
					writer.Write(zero);					
					writer.Write((byte)cacheflags);
					break;
				}
				case 0x8000:
				case 0x8001: 
				case 0x8002: 
				case 0x8004:
				case 0x8006: 
				case 0x8005: 
				case 0x8007: 
				{					
					writer.Write((ushort)count);
					writer.Write(type);
					writer.Write(argc);
					writer.Write((byte)locals);
					writer.Write((byte)headerflag);
					writer.Write(treeversion);
					writer.Write(zero);
					break;
				}
				case 0x8003: 				
				{
					writer.Write((byte)type);
					writer.Write(argc);
					writer.Write((byte)locals);
					writer.Write((byte)zero);
					writer.Write(treeversion);					
					writer.Write(count);
					break;
				}
				default: 
				{
					throw new Exception("Unknown BHAV Format "+format.ToString("X"));
				}
			} //switch
		}
	}
}
