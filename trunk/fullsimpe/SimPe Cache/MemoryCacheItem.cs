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
		public const byte VERSION = 3;
		internal const byte DISCARD_VERSIONS_SMALLER_THAN = 3;

		public MemoryCacheItem()
		{			
			version = VERSION;
			name = "";
			pfd = new Packages.PackedFileDescriptor();
			valuenames = new string[0];
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

		string[] valuenames;
		public string[] ValueNames
		{
			get {return valuenames;}
			set {
				valuenames = value;
				if (valuenames==null) valuenames = new string[0];
			}
		}

		string objdname;
		public string ObjdName
		{
			get { 
				if (objdname==null) return Name;
				return objdname; 
			}
			set { objdname = value; }
		}

		Image thumb;
		static Image emptyimg;
		/// <summary>
		/// Returns the loaded Icon, or an Empty Image if no Icon was found
		/// </summary>
		public Image Image
		{
			get { 
				if (Icon==null) 
				{
					if (emptyimg==null) emptyimg = new Bitmap(1, 1);
					return emptyimg;
				}
				return Icon; 
			}
			set { Icon = value; }
		}

		/// <summary>
		/// Returns the loaded Icon, this can be null!
		/// </summary>
		public Image Icon
		{
			get { return thumb; }
			set { thumb = value; }
		}

		public bool IsToken
		{
			get { return IsAspiration || (ObjdName.Trim().ToLower().StartsWith("token") && (this.ObjectType == Data.ObjectTypes.Normal || this.ObjectType == Data.ObjectTypes.Memory));}
		}

		public bool IsJobData
		{
			get { return ObjdName.Trim().ToLower().StartsWith("jobdata") && this.ObjectType == Data.ObjectTypes.Normal;}
		}

		public bool IsMemory
		{
			get { return IsToken || this.ObjectType == Data.ObjectTypes.Memory; }
		}
		

		public bool IsBadge
		{
			get { return ObjdName.ToLower().Trim().StartsWith("token - badge") && this.ObjectType == Data.ObjectTypes.Normal && IsToken;}
		}

		public bool IsSkill
		{
			get { return (ObjdName.ToLower().Trim().IndexOf("skill")>=0) && this.ObjectType == Data.ObjectTypes.Normal && IsToken;}
		}

		public bool IsAspiration
		{
			get { return ObjdName.Trim().ToLower().StartsWith("aspiration") && this.ObjectType == Data.ObjectTypes.Normal;}
		}

		public bool IsInventory
		{
			get { return !IsAspiration && !IsToken && !IsJobData && !IsMemory && this.ObjectType == Data.ObjectTypes.Normal; }
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
			if (version>=2) objdname = reader.ReadString();
			else objdname = null;
			if (version>=3)
			{
				int ct = reader.ReadUInt16();
				valuenames = new string[ct];
				for (int i=0; i<ct; i++)
					valuenames[i] = reader.ReadString();
			} 
			else 
			{
				valuenames = new string[0];
			}

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
			writer.Write(objdname);
			writer.Write((ushort)valuenames.Length);
			foreach (string s in valuenames) writer.Write(s);
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
