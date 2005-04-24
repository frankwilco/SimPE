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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// An Item stored in an TRCN
	/// </summary>
	public class TrcnItem
	{
		int nr;
		public int LineNumber 
		{
			get {return nr; }
			set {nr = value;}
		}

		string name;
		public string Name 
		{
			get { return name; }
			set { name = value; }
		}

		uint version;
		public uint Version
		{
			get {return version; }
			set {version = value;}
		}

		uint zero;
		ushort unknown;

		Trcn parent;
		public TrcnItem(Trcn parent)
		{
			this.parent = parent;
			version = 1;
			unknown = 0x64;
			name = "";
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			bool useshort = false;
			long pos = reader.BaseStream.Position;
			try 
			{
				version = reader.ReadUInt32();
				nr = reader.ReadInt32();
				byte len = reader.ReadByte();
				name = Helper.ToString(reader.ReadBytes(len));
				zero = reader.ReadUInt32();
				unknown = reader.ReadUInt16();

				if (unknown!=0x64) useshort = true;
			} 
			catch (Exception) 
			{
				useshort = true;
			}


			if (useshort) 
			{
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
				version = reader.ReadUInt32();
				nr = reader.ReadInt16();
				System.IO.MemoryStream ms = new System.IO.MemoryStream();
				while (reader.PeekChar()!=0) 
				{
					ms.WriteByte(reader.ReadByte());
				}
				ms.Seek(0, System.IO.SeekOrigin.Begin);
				System.IO.BinaryReader br = new System.IO.BinaryReader(ms);
				name = Helper.ToString(br.ReadBytes((int)ms.Length));
				zero = reader.ReadUInt32();
				unknown = reader.ReadUInt16();
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
		internal void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);
			writer.Write(nr);
			writer.Write((byte)name.Length);
			writer.Write(Helper.ToBytes(name, (byte)name.Length));
			writer.Write(zero);
			writer.Write(unknown);	
		}

		public override string ToString()
		{
			string name = "0x"+Helper.HexString((uint)(nr-1))+": "+Name;
			return name;
		}

	}
}
