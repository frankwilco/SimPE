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
using SimPe.Data;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// An Item stored in a CPF File
	/// </summary>
	public class ClstItem 
	{
		
		Data.MetaData.IndexTypes format;

		/// <summary>
		/// Constructor
		/// </summary>
		public ClstItem (Data.MetaData.IndexTypes format) : this(null, format)
		{			
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public ClstItem (SimPe.Interfaces.Files.IPackedFileDescriptor pfd, Data.MetaData.IndexTypes format)
		{
			this.format = format;
			if (pfd!=null)
			{
				this.Type = pfd.Type;
				this.Instance = pfd.Instance;
				this.SubType = pfd.SubType;
				this.Group = pfd.Group;
			}
		}

		uint type;
		/// <summary>
		/// Returns the Type of the referenced File
		/// </summary>
		public uint Type
		{
			get { return type; }
			set { type = value; }
		}

		/// <summary>
		/// Returns the Name of the represented Type
		/// </summary>
		public Data.TypeAlias TypeName 
		{
			get 
			{
				return Data.MetaData.FindTypeAlias(Type);
			}
		}

		uint group;
		/// <summary>
		/// Returns the Group the referenced file is assigned to
		/// </summary>
		public uint Group
		{
			get { return group; }
			set { group =value; }
		}

		uint instance;
		/// <summary>
		/// Returns the Instance Data
		/// </summary>
		public uint Instance
		{
			get { return instance; }
			set { instance =value; }
		}

		uint subtype;
		/// <summary>
		/// Returns an yet unknown Type
		/// </summary>		
		/// <remarks>Only in Version 1.1 of package Files</remarks>
		public uint SubType
		{
			get { return subtype; }
			set { subtype = value; }
		}

		uint uncsize;
		/// <summary>
		/// Returns the (real) uncompressed Size of the File
		/// </summary>
		public uint UncompressedSize 
		{
			get { return uncsize; }
			set { uncsize =value; }
		}

		public override int GetHashCode()
		{
			return (int)(this.Type|this.Instance)-(int)(this.Type&this.Instance) ;
		}

		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (obj is ClstItem)
			{
				ClstItem ci = (ClstItem)obj;
				return (ci.Group == Group && ci.Instance == Instance && ci.Type == type && (ci.SubType==SubType || ci.format == Data.MetaData.IndexTypes.ptShortFileIndex || format == Data.MetaData.IndexTypes.ptShortFileIndex));
			} 
			else if (obj is SimPe.Interfaces.Files.IPackedFileDescriptor)
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor ci = (SimPe.Interfaces.Files.IPackedFileDescriptor)obj;
				return (ci.Group == Group && ci.Instance == Instance && ci.Type == type && (ci.SubType==SubType || format == Data.MetaData.IndexTypes.ptShortFileIndex));
			} else return base.Equals (obj);
		}



		public override string ToString()
		{
			string name = this.TypeName + ": 0x" + Helper.HexString(this.Type);
			if (format == Data.MetaData.IndexTypes.ptLongFileIndex) name += " - 0x" + Helper.HexString(this.SubType);
			name += " - 0x" + Helper.HexString(this.Group) + " - 0x" + Helper.HexString(this.Instance) ;

			name += " = 0x"+Helper.HexString(UncompressedSize)+" byte";
			return name;
		}

		

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			type = reader.ReadUInt32();
			group = reader.ReadUInt32();
			instance = reader.ReadUInt32();
			if (format == Data.MetaData.IndexTypes.ptLongFileIndex) subtype = reader.ReadUInt32();
			else subtype = 0;
			uncsize = reader.ReadUInt32();
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Serialize(System.IO.BinaryWriter writer, Data.MetaData.IndexTypes format)
		{
			this.format = format;

			writer.Write(type);
			writer.Write(group);
			writer.Write(instance);
			if (format == Data.MetaData.IndexTypes.ptLongFileIndex) writer.Write(subtype);
			writer.Write(uncsize);
		}
	}
}
