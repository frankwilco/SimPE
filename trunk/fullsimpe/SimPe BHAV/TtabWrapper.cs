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
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Names for the Ttab Motive Groups
	/// </summary>
	enum TtabMotives : int
	{
		Toddler = 0x00,
		Child = 0x01,
		Teen = 0x02,
		Adult = 0x03,
		Elder = 0x04,
		Unknown = 0x05,
		Animals = 0x06
	}
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Ttab
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
		/// <summary>
		/// Contains the Filename
		/// </summary>
		byte[] filename;
	
		/// <summary>
		/// Unknown Data following the TTAB
		/// </summary>
		byte[] footer;
	
		/// <summary>
		/// Returns the Filename
		/// </summary>
		public string FileName 
		{
			get { return Helper.ToString(filename); }
		}

		/// <summary>
		/// Header of the File
		/// </summary>
		uint[] header;

		/// <summary>
		/// Returns /Sets the Format this File is in
		/// </summary>
		public uint Format 
		{
			get {return header[1]; }
			set {header[1] = value; }
		}

		/// <summary>
		/// Items stored in the File
		/// </summary>
		TtabItem[] items;

		/// <summary>
		/// Returns /Sets the Items
		/// </summary>
		public TtabItem[] Items 
		{
			get { return items;	}			
			set { items = value; }
		}		
		#endregion

		/// <summary>
		/// Stored the Opcode Provider
		/// </summary>
		SimPe.Interfaces.Providers.IOpcodeProvider opcodes;

		/// <summary>
		/// Constructor
		/// </summary>
		public Ttab(SimPe.Interfaces.Providers.IOpcodeProvider opcodes) : base()
		{
			this.opcodes = opcodes;
			items = new TtabItem[0];
			header = new uint[3];
			filename = new byte[64];
			footer = new byte[4];
		}

		/// <summary>
		/// Returns the used Opcode Provider
		/// </summary>
		internal SimPe.Interfaces.Providers.IOpcodeProvider Opcodes 
		{
			get {return opcodes; }
		}

		/// <summary>
		/// Contains a valid String Resource that describes the Function Entries
		/// </summary>
		PackedFiles.Wrapper.Str strres = null;

		/// <summary>
		/// Returns the describing String Resource
		/// </summary>
		internal PackedFiles.Wrapper.Str StringResource
		{
			get 
			{
				if (strres==null) 
				{
					strres = new PackedFiles.Wrapper.Str();
					if ((Package!=null) && (FileDescriptor!=null)) 
					{
						Interfaces.Files.IPackedFileDescriptor pfd = Package.FindFile(
							Data.MetaData.PIE_STRING_FILE, //Pie String File
							0, 
							FileDescriptor.Group,
							FileDescriptor.Instance
							);

						if (pfd!=null) 
						{
							strres.ProcessData(pfd, Package);
						}
					} 
					else 
					{
						return null;
					}		
				}

				return strres;
			}
		}
		

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			if ( (version==0012) //0.00
				|| (version==0013) //0.10
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
			return new UserInterface.TtabUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Experimental TTAB Wrapper",
				"Quaxi",
				"---",
				6
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			header = new uint[3];
			strres = null;
			filename = reader.ReadBytes(0x40);
			header[0] = reader.ReadUInt32();
			if (header[0] != 0xffffffff) 
			{
				items = new TtabItem[0];
				return;
			}

			header[1] = reader.ReadUInt32();
			header[2] = reader.ReadUInt32();

			
			items = new TtabItem[reader.ReadUInt16()];
			for (int i=0; i<items.Length; i++) 
			{
				items[i] = new TtabItem(this);
				items[i].Unserialize(reader);
				items[i].LineNumber = i;
			}

			footer = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
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
			writer.Write(header[0]);

			writer.Write(header[1]);
			writer.Write(header[2]);

			writer.Write((ushort)items.Length);
			for (int i=0; i<items.Length; i++) 
			{
				items[i].Serialize(writer);
			}	

			writer.Write(footer);
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
				uint[] types = {0x54544142}; //handles the TTAB File
				return types;
			}
		}

		#endregion		
	}
}
