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
	public class Nmap
		: AbstractWrapper				//Implements some of the default Behaviur of a Handler, you can Implement yourself if you want more flexibility!
		, IFileWrapper					//This Interface is used when loading a File
		, IFileWrapperSaveExtension		//This Interface (if available) will be used to store a File
		//,IPackedFileProperties		//This Interface can be used by thirdparties to retrive the FIleproperties, however you don't have to implement it!
	{
		#region Attributes
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

		IProviderRegistry provider;
		public IProviderRegistry Provider 
		{
			get {return provider; }
		}

		/// <summary>
		/// Constructor
		/// </summary>
		public Nmap(IProviderRegistry provider) : base()
		{
			this.provider = provider;
			items = new Interfaces.Files.IPackedFileDescriptor[0];
		}

		/// <summary>
		/// Returns all Filedescriptors for Files starting with the given Value
		/// </summary>
		/// <param name="start">The string the FIlename starts with</param>
		/// <returns>A List of File Descriptors</returns>
		public Interfaces.Files.IPackedFileDescriptor[] FindFiles(string start) 
		{
			start = start.Trim().ToLower();
			System.Collections.ArrayList a = new System.Collections.ArrayList();
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in items) 
			{
				if (pfd.Filename.Trim().ToLower().StartsWith(start)) a.Add(pfd);
			}

			Interfaces.Files.IPackedFileDescriptor[] pfds = new Interfaces.Files.IPackedFileDescriptor[a.Count];
			a.CopyTo(pfds);
			return pfds;
		}

		#region IWrapper member
		public override bool CheckVersion(uint version) 
		{
			return true;
		}
		#endregion
		
		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new NmapUI();
		}

		/// <summary>
		/// Returns a Human Readable Description of this Wrapper
		/// </summary>
		/// <returns>Human Readable Description</returns>
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Name Map Wrapper",
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
			items = new Interfaces.Files.IPackedFileDescriptor[reader.ReadUInt32()];

			for (int i=0; i<items.Length; i++)
			{
				NmapItem pfd = new NmapItem(this);
				pfd.Group = reader.ReadUInt32();
				pfd.Instance = reader.ReadUInt32();

				uint len = reader.ReadUInt32();
				pfd.Filename = Helper.ToString(reader.ReadBytes((int)len));

				items[i] = pfd;
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
			writer.Write((uint)items.Length);

			for (int i=0; i<items.Length; i++)
			{
				Interfaces.Files.IPackedFileDescriptor pfd = items[i];
				writer.Write(pfd.Group);
				writer.Write(pfd.Instance);

				writer.Write((uint)pfd.Filename.Length);
				writer.Write(Helper.ToBytes(pfd.Filename, 0));
			}
		}
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
								   Data.MetaData.NAME_MAP   //handles the NMAP File
							   };
				return types;
			}
		}

		#endregion		
	}
}
