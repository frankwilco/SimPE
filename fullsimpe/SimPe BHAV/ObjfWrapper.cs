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
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Objf
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
		/// Returns the Filename
		/// </summary>
		public string FileName 
		{
			get { return Helper.ToString(filename); }
		}

		/// <summary>
		/// Header of the File
		/// </summary>
		byte[] header = {
							0, 0, 0, 0, 
							0, 0, 0, 0,
							(byte)'f', (byte)'J', (byte)'B', (byte)'O'
						};

		/// <summary>
		/// Items stored in the File
		/// </summary>
		ObjfItem[] items;

		/// <summary>
		/// Returns /Sets the Items
		/// </summary>
		public ObjfItem[] Items 
		{
			get { return items;	}			
			set { items = value; }
		}		
		#endregion

		/// <summary>
		/// Contains an Opcode Provider
		/// </summary>
		SimPe.Interfaces.Providers.IOpcodeProvider opcodes;

		/// <summary>
		/// Opcode Provider
		/// </summary>
		public SimPe.Interfaces.Providers.IOpcodeProvider Opcodes 
		{
			get { return opcodes; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Objf(SimPe.Interfaces.Providers.IOpcodeProvider opcodes) : base()
		{
			this.opcodes = opcodes;
			ObjfItem.OpcodeProvider = opcodes;
			items = new ObjfItem[0];			
			filename = new byte[64];
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
			return new UserInterface.ObjfUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			///
			/// TODO: Change the Description passed here
			/// 
			return new AbstractWrapperInfo(
				"OBJf Wrapper",
				"Quaxi",
				"---",
				4
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			ObjfItem.Package = Package;

			filename = reader.ReadBytes(64);
			header = reader.ReadBytes(12);
			items = new ObjfItem[reader.ReadUInt32()];
						
 
			for (int i=0; i < items.Length; i++) 
			{
				items[i] = new ObjfItem(this);
				items[i].LineNumber = i;
				items[i].Guardian = reader.ReadUInt16();
				items[i].Action = reader.ReadUInt16();
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
			writer.Write(filename);
			writer.Write(header);
			writer.Write((uint)items.Length);
						
 
			for (int i=0; i < items.Length; i++) 
			{				
				writer.Write(items[i].Guardian);
				writer.Write(items[i].Action);
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
				uint[] types = {0x4F424A66}; //handles the OBJf File
				return types;
			}
		}

		#endregion		
	}
}
