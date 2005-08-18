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
	public enum RcolCacheItemType : byte
	{
		Wallmask = 0,
		Unknown = 0xff
	};
	/// <summary>
	/// Contains one RcolCacheItem
	/// </summary>
	public class RcolCacheItem : ICacheItem
	{
		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;

		public RcolCacheItem()
		{			
			version = VERSION;
			resourcename = "";
			modelname = "";	
			rtp = RcolCacheItemType.Unknown;
	
			pfd = new Packages.PackedFileDescriptor();
		}

		byte version;
		string modelname;
		string resourcename;
		RcolCacheItemType type;
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

		RcolCacheItemType rtp;
		public RcolCacheItemType RcolType
		{
			get { return rtp; }
			set { rtp = value; }
		}

		/// <summary>
		/// Returns the Type Field of the Object
		/// </summary>
		public string ResourceName
		{
			get { return resourcename; }
			set { resourcename = value; }
		}				

		/// <summary>
		/// Returns the ModeName for this Object
		/// </summary>
		public string ModelName
		{
			get { return modelname; }
			set { modelname = value; }
		}
		

		public override string ToString()
		{
			return "modelname="+ModelName+", type="+RcolType+", name="+ResourceName;
		}


		#region ICacheItem Member

		public void Load(System.IO.BinaryReader reader) 
		{
			version = reader.ReadByte();
			if (version>VERSION) throw new CacheException("Unknown CacheItem Version.", null, version);
										
			resourcename = reader.ReadString();
			rtp = (RcolCacheItemType)reader.ReadByte();
			pfd = new Packages.PackedFileDescriptor();
			pfd.Type = reader.ReadUInt32();
			pfd.Group = reader.ReadUInt32();
			pfd.LongInstance = reader.ReadUInt64();			
		}

		public void Save(System.IO.BinaryWriter writer) 
		{
			version = VERSION;
			writer.Write(version);
			writer.Write(resourcename);
			writer.Write((byte)rtp);
			writer.Write(pfd.Type);
			writer.Write(pfd.Group);
			writer.Write(pfd.LongInstance);			
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
