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
	/// Class representing an Instruction
	/// </summary>
	public class Instruction : InstructionName
	{

		/// <summary>
		/// Constructor
		/// </summary>
		public Instruction (int index, Bhav parent) : base(parent)
		{
			operands = new byte[8];
			reserved_01 = new byte[8];
			this.index = index;
		}

		int index;
		public int Index 
		{
			get {return index;}
			set {index = value;}
		}
		ushort opcode;
		public virtual ushort OpCode 
		{
			get { return opcode; }
			set { opcode = value; }
		}

		ushort addr1;
		public ushort Target1
		{
			get {return addr1;}
			set {addr1 = value;}
		}

		ushort addr2;
		public ushort Target2
		{
			get {return addr2;}
			set {addr2 = value;}
		}

		byte nodeversion;
		public byte Reserved0
		{
			get {return nodeversion;}
			set {nodeversion = value;}
		}

		byte[] operands;
		public byte[] Operands
		{
			get {return operands;}
			set {operands = value;}
		}

		byte[] reserved_01;
		public byte[] Reserved1
		{
			get {return reserved_01;}
			set {reserved_01 = value;}
		}
		public byte[] Operands2
		{
			get {return reserved_01;}
			set {reserved_01 = value;}
		}

		/// <summary>
		/// True if this instruction describes a Global Behavior File
		/// </summary>
		public bool GlobalBhav
		{
			get { return IsGlobalBhav(this.opcode); }
		}

		/// <summary>
		/// True if this instruction describes a Local Behavior File
		/// </summary>
		public bool LocalBhav
		{
			get { return IsLocalBhav(this.opcode); }
		}

		/// <summary>
		/// True if this instruction describes a Semi Global Bhav
		/// </summary>
		public bool SemiGlobalBhav
		{
			get { return IsSemiGlobalBhav(this.opcode); }
		}

		/// <summary>
		/// Reads the Data from a Stream
		/// </summary>
		/// <param name="format"></param>
		/// <param name="reader"></param>
		public void Unserialize(ushort format, BinaryReader reader) 
		{
			try 
			{
				switch (format) 
				{
					case 0x8001: 
					case 0x8002: 
					{
						opcode = reader.ReadUInt16();
						addr1 = (ushort)reader.ReadByte();
						addr2 = (ushort)reader.ReadByte();
						nodeversion = 0;
						operands = reader.ReadBytes(8);
						reserved_01 = new byte[8];
						break;
					}
					case 0x8003: 
					case 0x8004: 
					{
						opcode = reader.ReadUInt16();
						addr1 = (ushort)reader.ReadByte();
						addr2 = (ushort)reader.ReadByte();
						nodeversion = 0;
						operands = reader.ReadBytes(8);
						reserved_01 = reader.ReadBytes(8);
						break;
					}
					case 0x8006: 
					case 0x8005: 
					{
						opcode = reader.ReadUInt16();
						addr1 = (ushort)reader.ReadByte();
						addr2 = (ushort)reader.ReadByte();
						nodeversion = reader.ReadByte();
						operands = reader.ReadBytes(8);
						reserved_01 = reader.ReadBytes(8);
						break;
					}
					case 0x8009:
					case 0x8008:
					case 0x8007: 
					{
						opcode = reader.ReadUInt16();
						addr1 = reader.ReadUInt16();
						addr2 = reader.ReadUInt16();
						nodeversion = reader.ReadByte();
						operands = reader.ReadBytes(8);
						reserved_01 = reader.ReadBytes(8);
						break;
					}
					default: 
					{
						throw new Exception("Unknown BHAV Format "+format.ToString("X"));
					}
				} //switch
			} 
			catch (Exception) 
			{
				//Helper.ExceptionMessage("", ex);
			}
		}

		/// <summary>
		/// Writes the Data to a Stream
		/// </summary>
		/// <param name="format"></param>
		/// <param name="writer"></param>
		public void Serialize(ushort format, BinaryWriter writer) 
		{
			switch (format) 
			{
				case 0x8001: 
				case 0x8002: 
				{
					writer.Write(opcode);
					writer.Write((byte)addr1);
					writer.Write((byte)addr2);	
					writer.Write(operands);	
					break;
				}
				case 0x8003: 
				case 0x8004: 
				{
					writer.Write(opcode);
					writer.Write((byte)addr1);
					writer.Write((byte)addr2);			
					writer.Write(operands);
					writer.Write(reserved_01);
					break;
				}
				case 0x8006: 
				case 0x8005: 
				{
					writer.Write(opcode);
					writer.Write((byte)addr1);
					writer.Write((byte)addr2);
					writer.Write(nodeversion);
					writer.Write(operands);
					writer.Write(reserved_01);
					break;
				}
				case 0x8009: 
				case 0x8008: 
				case 0x8007: 
				{
					writer.Write(opcode);
					writer.Write(addr1);
					writer.Write(addr2);
					writer.Write(nodeversion);
					writer.Write(operands);
					writer.Write(reserved_01);
					break;
				}
				default: 
				{
					throw new Exception("Unknown BHAV Format "+format.ToString("X"));
				}
			} //switch
		}

		public override string ToString()
		{
			return this.OpcodeName(this.opcode, this.operands);
		}

	}
}
