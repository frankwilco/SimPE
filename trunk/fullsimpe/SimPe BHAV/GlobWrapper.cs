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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class Glob
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		, IPackedFileProperties			//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
		/// <summary>
		/// Contains the Filename
		/// </summary>
		byte[] filename;	
		/// <summary>
		/// Just A Flag
		/// </summary>
		byte[] semiglobal;
		#endregion
	
		#region Accessor methods
		/// <summary>
		/// Returns the Filename
		/// </summary>
		public string FileName
		{
			get { return Helper.ToString(filename); }
		}

		/// <summary>
		/// Returns /Sets the Flag
		/// </summary>
		public string SemiGlobalName
		{
			get { return Helper.ToString(semiglobal);	}			
			set { 
				semiglobal = Helper.ToBytes(value, 0); 
				attributes["SemiGlobalName"] = value;
				attributes["SemiGlobalGroup"] = this.SemiGlobalGroup;
			}
		}

		/// <summary>
		/// Retursn the Group for the current SemiGlobal Name
		/// </summary>
		public uint SemiGlobalGroup
		{
			get { 
				uint grp = Hashes.GroupHash(SemiGlobalName);				
				return grp;
			}
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public Glob() : base()
		{
			items = new IPackedFileProperties[0];
			attributes = new Hashtable();
			semiglobal = new byte[0];
			filename = new byte[64];
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
			return new UserInterface.GlobForm();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Global Data Wrapper",
				"Quaxi",
				"---",
				3
				); 
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			filename = reader.ReadBytes(64);
			byte len = reader.ReadByte();							
			semiglobal = reader.ReadBytes(len);
			attributes = new Hashtable();

			attributes["SemiGlobalName"] = this.SemiGlobalName;
			attributes["SemiGlobalGroup"] = this.SemiGlobalGroup;
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
			writer.Write((byte)Math.Min(0xff, semiglobal.Length));
			writer.Write(semiglobal);
		}
		#endregion

		#region IFileWrapperSaveExtension Member		
		//all covered by Serialize()
		#endregion

		#region IFileWrapper Member

		public override string Description
		{
			get
			{
				return "SemiGlobalName="+this.SemiGlobalName+", Group=0x"+Helper.HexString(SemiGlobalGroup);
			}
		}
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
				uint[] types = {0x474C4F42}; //handles the GLOB File
				return types;
			}
		}

		#endregion		

		#region IPackedFileProperties Member
		IPackedFileProperties[] items;
		Hashtable attributes;

		/// <summary>
		/// Returns all Attributes tored in the File.
		/// </summary>
		/// <remarks>Each Attribute is unique!</remarks>
		public Hashtable Attributes
		{
			get
			{
				return attributes;
			}
		}

		/// <summary>
		/// Returns all Items stored in the File (can be null)
		/// </summary>
		/// <remarks>
		/// All Items returned here have the same structure, 
		/// however each Item can have SubItmes of it's own.
		/// 
		/// If null is returned, no Items are provided by this File
		/// </remarks>
		public IPackedFileProperties[] Items 
		{
			get
			{
				return items;
			}
		}
		#endregion
	}

	/// <summary>
	/// Named Glob File
	/// </summary>
	public class NamedGlob : Glob 
	{
		public override string ToString()
		{
			return this.SemiGlobalName;
		}
	}
}
