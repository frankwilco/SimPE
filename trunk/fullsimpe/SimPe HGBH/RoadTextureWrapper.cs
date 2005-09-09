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
	public class RoadTexture
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper
		, System.Collections.IEnumerable
		
	{
		public enum RoadTextureType : byte 
		{
			Materials = 0x1,
			Unknown = 0x2
		}

		#region Attributes
		Hashtable values;
		string flname;

		uint uk1, uk2, uk3;		
		RoadTextureType type;

		public RoadTextureType Type
		{
			get { return type; }
			set { type = value; }
		}

		public string FileName
		{
			get { return flname; }
			set { flname = value; }
		}		

		public uint Id
		{
			get { return uk1; }
			set { uk1 = value; }
		}

		public uint Unknown2
		{
			get { return uk2; }
			set { uk2 = value; }
		}

		public uint Unknown3
		{
			get { return uk3; }
			set { uk3 = value; }
		}


		#endregion

		

		/// <summary>
		/// Constructor
		/// </summary>
		public RoadTexture() : base()
		{		
			values = new Hashtable();
			flname = "";
			type = RoadTextureType.Materials;
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
			return new RoadTextureControl();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Road Texture Wrapper",
				"Quaxi",
				"This Files describes the used Road Materials.",
				1,
				null
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			values.Clear();

			byte[] fname = reader.ReadBytes(0x40);
			flname = Helper.ToString(fname);

			uk1 = reader.ReadUInt32();
			uk2 = reader.ReadUInt32();
			uk3 = reader.ReadUInt32();

			uint ct = reader.ReadUInt32();

			long pos = reader.BaseStream.Position;
			try 
			{
				for (int i=0; i<ct; i++) 
				{
					string k = reader.ReadString();
					string v = reader.ReadString();
					values[k] = v;
				}

				type = RoadTextureType.Materials;
			} 
			catch {
				type = RoadTextureType.Unknown;
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);

				for (int i=0; i<ct; i++) 
				{
					uint k = reader.ReadUInt32();
					uint v = reader.ReadUInt32();
					values[k] = v;
				}
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
		protected override void Serialize(System.IO.BinaryWriter writer)
		{
			byte[] fname = Helper.ToBytes(flname, 0x40);
			writer.Write(fname);

			writer.Write(uk1);
			writer.Write(uk2);
			writer.Write(uk3);

			writer.Write((uint)values.Count);

			if (type == RoadTextureType.Materials)
			{
				foreach (string k in values.Keys)
				{				
					string v = (string)values[k];
					writer.Write(v);
					writer.Write(k);
				}
			} 
			else 
			{
				foreach (uint k in values.Keys)
				{				
					uint v = (uint)values[k];
					writer.Write(v);
					writer.Write(k);
				}
			}
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
								   0xACE46235   //handles the RTEX File
							   };
				return types;
			}
		}

		#endregion		

		#region IMultiplePackedFileWrapper Member

		public override object[] GetConstructorArguments()
		{
			return new object[0];
		}		

		#endregion		

		#region IEnumerable Member

		public object this[object key]
		{
			get 
			{
				return values[key];
			}
			set 
			{
				values[key] = value;
			}
		}

		public IEnumerator GetEnumerator()
		{
			return values.Keys.GetEnumerator();
		}

		#endregion
	}
}
