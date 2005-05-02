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
	public class Trcn
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
			set { filename = Helper.ToBytes(value, 0x40); }
		}

		uint header;
		uint unknown_0;
		uint unknown_1;

		/// <summary>
		/// Contains all available Constants 
		/// </summary>		
		private TrcnItem[] labels;

		/// <summary>
		/// Returns/Sets the Constants
		/// </summary>
		public TrcnItem[] Labels
		{
			get { return labels; }			
			set { labels = value; }
		}
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public Trcn() : base()
		{
			labels = new TrcnItem[0];			
			filename = new byte[0x40];
			header = 0x5452434E;
			unknown_0 = 0x4E;
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
			return new UserInterface.TrcnForm();
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
				"TRCN Wrapper",
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
			header = reader.ReadUInt32();
			unknown_0 = reader.ReadUInt32();
			unknown_1 = reader.ReadUInt32();
			labels = new TrcnItem[reader.ReadUInt32()];				
 
			for (int i=0; i < labels.Length; i++) 
			{
				labels[i] = new TrcnItem(this);
				labels[i].Unserialize(reader);
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
			writer.Write(unknown_0);
			writer.Write(unknown_1);
			writer.Write((uint)labels.Length);
 
			for (int i=0; i < labels.Length; i++) labels[i].Serialize(writer);
			
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
				uint[] types = {0x5452434E}; //handles the TRCN File
				return types;
			}
		}

		#endregion		
	}
}
