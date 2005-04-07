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
	public class WantCacheItem : ICacheItem
	{
		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;

		public WantCacheItem()
		{			
			version = VERSION;
			name = "";
			type = "";
			folder = "";
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

		string folder;
		public string Folder
		{
			get { return folder; }
			set { folder = value; }
		}

		int score;
		public int Score
		{
			get { return score; }
			set { score = value; }
		}

		int influence;
		public int Influence
		{
			get { return influence; }
			set { influence = value; }
		}

		string type;
		public string ObjectType
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
			type = reader.ReadString();
			pfd = new Packages.PackedFileDescriptor();
			pfd.Type = reader.ReadUInt32();
			pfd.Group = reader.ReadUInt32();			
			pfd.LongInstance = reader.ReadUInt64();
			influence = reader.ReadInt32();
			score = reader.ReadInt32();
			guid = reader.ReadUInt32();
			folder = reader.ReadString();
			

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
			writer.Write(type);			
			writer.Write(pfd.Type);
			writer.Write(pfd.Group);
			writer.Write(pfd.LongInstance);
			writer.Write(influence);
			writer.Write(score);
			writer.Write(guid);
			writer.Write(folder);

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
	}
}
