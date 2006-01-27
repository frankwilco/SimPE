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
using System.Drawing;
using System.IO;
using SimPe;

namespace SimPe.Cache
{
	/// <summary>
	/// Contains one ObjectCacheItem
	/// </summary>
	public class MemoryCacheItem : ICacheItem, System.IDisposable
	{
		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;

		public MemoryCacheItem()
		{			
			version = VERSION;
			name = "";
			pfd = new Packages.PackedFileDescriptor();
		}

		byte version;		
		Interfaces.Files.IPackedFileDescriptor pfd;
		

		/// <summary>
		/// Returns an (unitialized) FileDescriptor
		/// </summary>
		public Interfaces.Files.IPackedFileDescriptor FileDescriptor
		{
			get { 
				pfd.Tag = this;
				return pfd; 
			}
			set { pfd = value; }
		}

		uint guid;
		public uint Guid
		{
			get { return guid; }
			set { guid = value; }
		}		
		
		SimPe.Data.ObjectTypes type;
		public SimPe.Data.ObjectTypes ObjectType
		{
			get { return type; }
			set { type = value; }
		}

		string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		Image thumb;
		public Image Icon
		{
			get { return thumb; }
			set { thumb = value; }
		}

		SimPe.Cache.CacheContainer cc;
		public CacheContainer ParentCacheContainer
		{
			get { return cc; }
			set { cc = value; }
		}


		public override string ToString()
		{
			return "name="+Name;
		}

		#region ICacheItem Member

		public void Load(System.IO.BinaryReader reader) 
		{
			version = reader.ReadByte();
			if (version>VERSION) throw new CacheException("Unknown CacheItem Version.", null, version);
							
			name = reader.ReadString();
			type = (SimPe.Data.ObjectTypes)reader.ReadUInt16();
			pfd = new Packages.PackedFileDescriptor();
			pfd.Type = reader.ReadUInt32();
			pfd.Group = reader.ReadUInt32();			
			pfd.LongInstance = reader.ReadUInt64();			
			guid = reader.ReadUInt32();
			

			int size = reader.ReadInt32();
			if (size==0) 
			{
				thumb = null;
			} 
			else 
			{
				byte[] data = reader.ReadBytes(size);
				MemoryStream ms = new MemoryStream(data);

				thumb = Image.FromStream(ms);				
			}
		}

		public void Save(System.IO.BinaryWriter writer) 
		{
			version = VERSION;
			writer.Write(version);
			writer.Write(name);
			writer.Write((ushort)type);			
			writer.Write(pfd.Type);
			writer.Write(pfd.Group);
			writer.Write(pfd.LongInstance);
			writer.Write(guid);

			if (thumb==null) 
			{
				writer.Write((int)0);
			} 
			else 
			{
				MemoryStream ms = new MemoryStream();
				thumb.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
				byte[] data = ms.ToArray();
				writer.Write(data.Length);
				writer.Write(data);
			}
		}

		public byte Version
		{
			get
			{
				return version;
			}
		}

		#endregion

		#region IDisposable Member

		public void Dispose()
		{
			thumb = null;
			pfd = null;
			name = null;
		}

		#endregion
	}
}
