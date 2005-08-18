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
using SimPe;

namespace SimPe.Cache
{
	/// <summary>
	/// What type have the items stored in the container
	/// </summary>
	public enum ContainerType :byte
	{
		None = 0x00,
		Object = 0x01,
		MaterialOverride = 0x02,		
		Want = 0x03,
		Memory = 0x04,
		Package = 0x05,
		Rcol = 0x06
	};

	/// <summary>
	/// Detailed Information about the Valid State of the Container 
	/// </summary>
	public enum ContainerValid : byte
	{
		Yes = 0x04,
		FileNotFound = 0x01,
		Modified = 0x02,
		UnknownVersion = 0x03
	}

	/// <summary>
	/// Contains one or more CacheItems
	/// </summary>
	public class CacheContainer : System.IDisposable
	{
		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;

		/// <summary>
		/// Create a new Instance
		/// </summary>
		public CacheContainer(ContainerType type)
		{
			version = VERSION;
			this.type = type;
			added = DateTime.Now;
			filename = "";
			valid = ContainerValid.Yes;

			items = new CacheItems();
		}		

		byte version;
		ContainerType type;
		ContainerValid valid;
		
		DateTime added;
		string filename;

		/// <summary>
		/// Returns the Version of the File
		/// </summary>
		public byte Version 
		{
			get { return version; }
		}

		/// <summary>
		/// Returns the Version of the File
		/// </summary>
		public DateTime Added 
		{
			get { return added; }
			set { added = value; }
		}
		
		CacheItems items;
		/// <summary>
		/// Return all available Items
		/// </summary>
		public CacheItems Items
		{
			get { return items; }
		}

		/// <summary>
		/// Returns the Type of this Container
		/// </summary>
		public ContainerType Type
		{
			get { return type; }
		}

		/// <summary>
		/// True if this Container is still valid
		/// </summary>
		public bool Valid 
		{
			get { return (valid==ContainerValid.Yes); }
		}

		public ContainerValid ValidState 
		{
			get {return valid; }
		}

		/// <summary>
		/// Return the Name of the File this Container was used for
		/// </summary>
		public string FileName
		{
			get { return filename; }
			set { filename = value.Trim().ToLower(); }
		}

		/// <summary>
		/// Load the Container from the Stream
		/// </summary>
		/// <param name="reader">the Stream Reader</param>
		internal void Load(System.IO.BinaryReader reader) 
		{
			valid = ContainerValid.FileNotFound;
			items.Clear();
			int offset = reader.ReadInt32();
			version = reader.ReadByte();
			type = (ContainerType)reader.ReadByte();
			int count = reader.ReadInt32();

			long pos = reader.BaseStream.Position;
			try 
			{
				if (version<=VERSION) 
				{
					reader.BaseStream.Seek(offset, System.IO.SeekOrigin.Begin);
					added = DateTime.FromFileTime(reader.ReadInt64());
					filename = reader.ReadString();

					if (System.IO.File.Exists(filename)) 
					{
						DateTime mod = System.IO.File.GetLastWriteTime(filename);
						if (mod<=added) valid = ContainerValid.Yes;
						else valid = ContainerValid.Modified;
					}

					if (valid == ContainerValid.Yes) 
					{
						switch (type) 
						{
							case ContainerType.Object:
							{	
								for (int i=0; i<count; i++) 
								{
									ObjectCacheItem oci = new ObjectCacheItem();
									oci.Load(reader);
									items.Add(oci);
								}
							
								break;
							}
							case ContainerType.MaterialOverride:
							{														
								for (int i=0; i<count; i++) 
								{
									MMATCacheItem oci = new MMATCacheItem();
									oci.Load(reader);
									items.Add(oci);
								}
							
								break;
							}	
							case ContainerType.Rcol:
							{														
								for (int i=0; i<count; i++) 
								{
									RcolCacheItem oci = new RcolCacheItem();
									oci.Load(reader);
									items.Add(oci);
								}
							
								break;
							}								
							case ContainerType.Want:
							{														
								for (int i=0; i<count; i++) 
								{
									WantCacheItem oci = new WantCacheItem();
									oci.Load(reader);
									items.Add(oci);
								}
							
								break;
							}	
							case ContainerType.Memory:
							{														
								for (int i=0; i<count; i++) 
								{
									MemoryCacheItem oci = new MemoryCacheItem();
									oci.Load(reader);
									oci.ParentCacheContainer = this;
									items.Add(oci);
								}
							
								break;
							}	
							case ContainerType.Package:
							{														
								for (int i=0; i<count; i++) 
								{
									PackageCacheItem oci = new PackageCacheItem();
									oci.Load(reader);
									items.Add(oci);
								}
							
								break;
							}	
						} //switch
					} // if valid
				} //if VERSION
				else 
				{
					valid = ContainerValid.UnknownVersion;
				}
			} 
			finally 
			{
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
			}
		}

		/// <summary>
		/// Save the Container to the Stream
		/// </summary>
		/// <param name="writer">the Stream Writer</param>
		internal void Save(System.IO.BinaryWriter writer, int offset) 
		{			
			writer.Write(offset);
			
			//prewrite Phase
			if (offset==-1) 
			{				
				version = VERSION;
				writer.Write(version);			
				writer.Write((byte)type);
				writer.Write((int)items.Count);											
			} 
			else //Item writing Phase
			{
				writer.Seek(offset, System.IO.SeekOrigin.Begin);
				writer.Write(added.ToFileTime());
				writer.Write(filename);
				
				for (int i=0; i<items.Count; i++) items[i].Save(writer);				
			}
		}

		#region IDisposable Member

		public virtual void Dispose()
		{
			if (items!=null)
				items.Clear();
		}

		#endregion
	}
}
