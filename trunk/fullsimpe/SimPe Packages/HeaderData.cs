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

namespace SimPe.Packages
{
	/// <summary>
	/// Structural Data of a .package Header
	/// </summary>
	public class HeaderData : Interfaces.Files.IPackageHeader
	{
		/// <summary>
		/// Constructor for the class
		/// </summary>
		internal HeaderData ()
		{
			index = new HeaderIndex();
			hole = new HeaderHole();
			id = new char[4];
			reserved_00 = new Int32[3];
			reserved_02 = new Int32[8];

			id[0] = 'D';
			id[1] = 'B';
			id[2] = 'P';
			id[3] = 'F';

			majorversion = 1;
			minorversion = 1;
			index.Type = 7;

			indextype = Data.MetaData.IndexTypes.ptLongFileIndex;
		}

		/// <summary>
		/// Identifier of the File
		/// </summary>
		internal char[] id;

		/// <summary>
		/// Returns the Identifier of the File
		/// </summary>
		/// <remarks>This value should be DBPF</remarks>
		public string Identifier
		{
			get 
			{
				string ret = "";
				foreach (char c in id) ret += c;
				return ret;
			}
		}
		


		/// <summary>
		/// The Major Version (part before the .) of the Package File Format
		/// </summary>
		internal Int32 majorversion;

		/// <summary>
		/// Returns the Major Version of The Packages FileFormat
		/// </summary>
		/// <remarks>This value should be 1</remarks>
		public Int32 MajorVersion
		{
			get
			{
				return majorversion;
			}
		}



		/// <summary>
		/// The Minor Version (part after the .) of the Package File Format
		/// </summary>
		internal Int32 minorversion;

		/// <summary>
		/// Returns the Minor Version of The Packages FileFormat 
		/// </summary>
		/// <remarks>This value should be 0 or 1</remarks>
		public Int32 MinorVersion
		{
			get
			{
				return minorversion;
			}
		}


		/// <summary>
		/// 3 dwords of reserved Data
		/// </summary>
#if DEBUG
		public Int32[] reserved_00;
#else
		internal Int32[] reserved_00;
#endif


		/// <summary>
		/// Createion Date of the File
		/// </summary>
#if DEBUG
		public Int32 created;
#else
		internal Int32 created;
#endif

		/// <summary>
		/// Modification Date of the File
		/// </summary>
#if DEBUG
		public Int32 modified;
#else
		internal Int32 modified;
#endif


		/// <summary>
		/// holds Index Informations stored in the Header
		/// </summary>
		internal HeaderIndex index;		

		/// <summary>
		/// Returns Index Informations stored in the Header
		/// </summary>
		public SimPe.Interfaces.Files.IPackageHeaderIndex Index
		{
			get 
			{
				return index;
			}
		}

		/// <summary>
		/// Holds Hole Index Informations stored in the Header
		/// </summary>
		internal HeaderHole hole;

		/// <summary>
		/// Returns Hole Index Informations stored in the Header
		/// </summary>
		public SimPe.Interfaces.Files.IPackageHeaderHoleIndex HoleIndex
		{
			get
			{
				return hole;
			}
		}


		/// <summary>
		/// Only available for versions >= 1.1
		/// </summary>
		private Data.MetaData.IndexTypes indextype;

		/// <summary>
		/// Returns or Sets the Type of the Package
		/// </summary>
		public Data.MetaData.IndexTypes IndexType
		{
			get 
			{
				return (Data.MetaData.IndexTypes)indextype;
			}
			set 
			{
				indextype = value;
			}
		}

		/// <summary>
		/// 8 dwords of reserved Data
		/// </summary>
#if DEBUG
		public Int32[] reserved_02;
#else
		internal Int32[] reserved_02;
#endif


		/// <summary>
		/// true if the version is greater or equal than 1.1
		/// </summary>
		public bool IsVersion0101
		{
			get 
			{
				return ((majorversion>1) || ((majorversion==1) && (minorversion>=1)));
			}
		}


		#region File Processing Methods
		/// <summary>
		/// Initializes the Structure from a BinaryReader
		/// </summary>
		/// <param name="reader">The Reader representing the Package File</param>
		/// <remarks>Reader must be on the correct Position since no Positioning is performed</remarks>
		internal void Load(BinaryReader reader)
		{
			//this.id = new char[4];
			for (uint i=0; i<this.id.Length; i++) this.id[i] = reader.ReadChar();
			
			this.majorversion = reader.ReadInt32();
			this.minorversion = reader.ReadInt32();

			//this.reserved_00 = new Int32[3];
			for (uint i=0; i<this.reserved_00.Length; i++) this.reserved_00[i] = reader.ReadInt32();

			this.created = reader.ReadInt32();
			this.modified = reader.ReadInt32();

			this.index.type = reader.ReadInt32();
			this.index.count = reader.ReadInt32();
			this.index.offset = reader.ReadUInt32();
			this.index.size = reader.ReadInt32();

			this.hole.count = reader.ReadInt32();
			this.hole.offset = reader.ReadUInt32();
			this.hole.size = reader.ReadInt32();

			if (IsVersion0101) this.indextype = (Data.MetaData.IndexTypes)reader.ReadUInt32();

			//this.reserved_02 = new Int32[8];
			for (uint i=0; i<this.reserved_02.Length; i++) this.reserved_02[i] = reader.ReadInt32();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="writer"></param>
		/// <remarks>Writer must be on the correct Position since no Positioning is performed</remarks>
		internal void Save(BinaryWriter writer) 
		{
			for (uint i=0; i<this.id.Length; i++) writer.Write(this.id[i]);
			
			writer.Write(this.majorversion);
			writer.Write(this.minorversion);

			for (uint i=0; i<this.reserved_00.Length; i++) writer.Write(this.reserved_00[i]);

			writer.Write(this.created );
			writer.Write(this.modified);

			writer.Write(this.index.type);
			writer.Write(this.index.count);
			writer.Write(this.index.offset);
			writer.Write(this.index.size);

			writer.Write(this.hole.count);
			writer.Write(this.hole.offset);
			writer.Write(this.hole.size);

			if (IsVersion0101) writer.Write((uint)this.IndexType);

			for (uint i=0; i<this.reserved_02.Length; i++) writer.Write(this.reserved_02[i]);
		}
		#endregion
	}
}
