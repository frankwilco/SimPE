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
using SimPe.Interfaces.Providers;
using SimPe.Interfaces;

namespace SimPe.Plugin
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class RefFile
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
		/// <summary>
		/// ID of the File
		/// </summary>
		uint id;

		/// <summary>
		/// Type of the File
		/// </summary>
		Data.MetaData.IndexTypes type;

		/// <summary>
		/// Stores the Header
		/// </summary>
		private Interfaces.Files.IPackedFileDescriptor[] items;

		/// <summary>
		/// Returns / Sets the Header
		/// </summary>
		public Interfaces.Files.IPackedFileDescriptor[] Items 
		{
			get { return items;	}			
			set { items = value; }
		}

		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public RefFile() : base()
		{
			items = new Interfaces.Files.IPackedFileDescriptor[0];
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			if ( (version==0009) //0.00
				|| (version==0010) //0.10
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
			return new RefFileUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"3D Reference File Wrapper",
				"Quaxi",
				"---",
				5
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			id = reader.ReadUInt32();
			type = (Data.MetaData.IndexTypes)reader.ReadUInt32();

			items = new Interfaces.Files.IPackedFileDescriptor[reader.ReadUInt32()];

			for (int i=0; i<items.Length; i++) 
			{
				RefFileItem pfd = new RefFileItem(this);
				
				pfd.Type = reader.ReadUInt32();
				pfd.Group = reader.ReadUInt32();
				pfd.Instance = reader.ReadUInt32();
				if(type==Data.MetaData.IndexTypes.ptLongFileIndex) pfd.SubType = reader.ReadUInt32();

				Interfaces.Files.IPackedFileDescriptor ppfd = Package.FindFile(pfd.Type, pfd.SubType, pfd.Group, pfd.Instance);
				if (ppfd!=null) items[i]=ppfd;					
				else items[i] = pfd;
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
			writer.Write(id);
			writer.Write((uint)type);
			writer.Write((uint)items.Length);
			
			for (int i=0; i<items.Length; i++) 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = items[i];
				
				writer.Write(pfd.Type);
				writer.Write(pfd.Group);
				writer.Write(pfd.Instance);
				if(type==Data.MetaData.IndexTypes.ptLongFileIndex) writer.Write(pfd.SubType);
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
								   0xAC506764   //handles the 3IDR File
							   };
				return types;
			}
		}

		#endregion		
	}
}
