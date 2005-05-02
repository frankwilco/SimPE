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


namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Class containing a BHAV Header
	/// </summary>
	public class BhavHeader
	{
		#region Attributes
		ushort format;
		uint count;
		byte reserved_00;
		byte type;
		byte argc;
		ushort locals;
		ushort flags;
		ushort zero;
		#endregion

		#region Accessor methods
		public ushort Format 
		{
			get { return format; }
			set {format = value; }
		}

		public uint InstructionCount
		{
			get { return count; }
			set {count = value; }
		}

		public byte Type 
		{
			get { return type; }
			set {type = value; }
		}

		public byte ArgumentCount 
		{
			get { return argc; }
			set {argc = value; }
		}

		public ushort LocalVarCount 
		{
			get { return locals; }
			set {locals = value; }
		}

		public ushort Flags 
		{
			get { return flags; }
			set {flags = value; }
		}

		public ushort Zero 
		{
			get { return zero; }
			set {zero = value; }
		}
		#endregion

		public BhavHeader()
		{
			format = 0;
			count = 0;
			reserved_00 = 0;
			type = 0;
			argc = 0;
			locals = 0;
			flags = 0;
			zero = 0;
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
				case 0x8000:
				case 0x8001:
				case 0x8002:
				case 0x8004:
				case 0x8005:
				case 0x8006:
				case 0x8007: 
				{					
					count = (uint)reader.ReadUInt16();
					type = reader.ReadByte();
					argc = reader.ReadByte();
					locals = reader.ReadByte();
					reserved_00 = reader.ReadByte();
					flags = reader.ReadUInt16();
					zero = reader.ReadUInt16();
					break;
				}
				case 0x8003: 				
				{
					type = reader.ReadByte();
					argc = reader.ReadByte();
					locals = (ushort) reader.ReadByte();
					zero = reader.ReadByte();
					flags = reader.ReadUInt16();					
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
				case 0x8000:
				case 0x8001:
				case 0x8002:
				case 0x8004:
				case 0x8005:
				case 0x8006:
				case 0x8007:
				{					
					writer.Write((ushort)count);
					writer.Write(type);
					writer.Write(argc);
					writer.Write((byte)locals);
					writer.Write((byte)reserved_00);
					writer.Write(flags);
					writer.Write(zero);
					break;
				}
				case 0x8003: 				
				{
					writer.Write((byte)type);
					writer.Write(argc);
					writer.Write((byte)locals);
					writer.Write((byte)zero);
					writer.Write(flags);					
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
