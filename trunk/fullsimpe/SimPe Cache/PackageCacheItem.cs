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
using System.Collections;
using SimPe;

namespace SimPe.Cache
{
	/// <summary>
	/// Type of a Package
	/// </summary>
	public enum PackageType : uint
	{
		/// <summary>
		/// This package was never scaned
		/// </summary>
		Undefined = 0x40,
		/// <summary>
		/// The Package was scanned, but the Type is unknown
		/// </summary>	
		Unknown = 0x0,
		/// <summary>
		/// The package contains a Skin
		/// </summary>
		Skin = 0x1,		
		/// <summary>
		/// The package contains a Wallpaper
		/// </summary>
		Wallpaper = 0x2,		
		/// <summary>
		/// The package contains a Floor
		/// </summary>
		Floor = 0x4,		
		/// <summary>
		/// The package contains a Clothing
		/// </summary>
		Cloth = 0x8,		
		/// <summary>
		/// The package contains a Object or Clone
		/// </summary>
		Object = 0x10,		
		/// <summary>
		/// The package contains a Recolor
		/// </summary>
		Recolor = 0x20,
		/// <summary>
		/// An Object probably created by Maxis
		/// </summary>
		MaxisObject = 0x80,
		/// <summary>
		/// A CEP Related File
		/// </summary>
		CEP = 0x100,
		/// <summary>
		/// A Sim or Sim Template
		/// </summary>
		Sim = 0x200,		
		/// <summary>
		/// Hairtones
		/// </summary>
		Hair = 0x1000,
		/// <summary>
		/// Makeup for Sims
		/// </summary>
		Makeup = 0x400,
		Accessory = 0x800,
		Eye = 0x401,
		Beard = 0x402,
		EyeBrow = 0x403,
		Lipstick = 0x404,		
		Mask = 0x405,		
		Blush = 0x406,
		EyeShadow = 0x407,
		Glasses = 0x801,
		/// <summary>
		/// Contains a Neighborhood
		/// </summary>
		Neighborhood = 0x2000,
		/// <summary>
		/// Contains a Lot
		/// </summary>
		Lot = 0x4000
	}

	/// <summary>
	/// Adds the Null State to the Bollen states
	/// </summary>
	public enum TriState :byte 
	{
		False = 0,
		True = 1,
		Null = 2
	}

	/// <summary>
	/// This class can give Informations about the State of a Package
	/// </summary>
	/// <remarks>
	/// You can save diffrent informations along with a package file, each state (like contains duplicate GUID)
	/// has it's own uid. A TriState::Null measn, that the state was not ionvestigated yet
	/// </remarks>
	public class PackageState 
	{
		uint uid;
		TriState state;
		string info;
		uint[] data;
		public PackageState(uint uid, TriState state, string info) 
		{
			this.uid = uid;
			this.state = state;
			this.info = info;
			this.data = new uint[0];
		}

		internal PackageState()
		{
			this.state = TriState.Null;
			info = "";
		}

		public TriState State 
		{
			get { return state; }
			set { state = value; }
		}

		public uint Uid 
		{
			get { return uid; }
			set { uid = value; }
		}

		public string Info 
		{
			get { return info; }
			set { info = value; }
		}

		public uint[] Data 
		{
			get { 
				if (data==null) data = new uint[0];
				return data; 
			}
			set { data = value; }
		}

		internal virtual void Load(System.IO.BinaryReader reader) 
		{
			state = (TriState)reader.ReadByte();
			uid = reader.ReadUInt32();
			info = reader.ReadString();
			byte ct = reader.ReadByte();
			data = new uint[ct];
			for (int i=0; i<data.Length; i++) data[i] = reader.ReadUInt32();
		}

		internal virtual void Save(System.IO.BinaryWriter writer) 
		{
			writer.Write((byte)state);
			writer.Write(uid);
			writer.Write(info);

			if (data==null) 
			{
				writer.Write((byte)0);
			} 
			else 
			{
				byte ct = (byte)data.Length;
				writer.Write(ct);
				for (int i=0; i<ct; i++) writer.Write(data[i]);
			}
		}
	}

	/// <summary>
	/// Typesave ArrayList for PackageState Objects
	/// </summary>
	public class PackageStates : ArrayList 
	{
		public new PackageState this[int index]
		{
			get { return ((PackageState)base[index]); }
			set { base[index] = value; }
		}

		public PackageState this[uint index]
		{
			get { return ((PackageState)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(PackageState item)
		{
			return base.Add(item);
		}

		public void Insert(int index, PackageState item)
		{
			base.Insert(index, item);
		}

		public void Remove(PackageState item)
		{
			base.Remove(item);
		}

		public bool Contains(PackageState item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			PackageStates list = new PackageStates();
			foreach (PackageState item in this) list.Add(item);

			return list;
		}
	}


	/// <summary>
	/// Contains one ObjectCacheItem
	/// </summary>
	public class PackageCacheItem : ICacheItem
	{
		/// <summary>
		/// The current Version
		/// </summary>
		public const byte VERSION = 1;

		public PackageCacheItem()
		{			
			version = VERSION;
			name = "";
			guids = new uint[0];
			type = PackageType.Undefined;
			states = new PackageStates();
		}

		protected byte version;		
		
		uint[] guids;
		public uint[] Guids
		{
			get { return guids; }
			set { guids = value; }
		}		
		
		PackageType type;
		public PackageType Type
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
		public Image Thumbnail
		{
			get { return thumb; }
			set { thumb = value; }
		}

		PackageStates states;
		public PackageStates States 
		{
			get { return states; }
			set { states = value; }
		}

		public int StateCount 
		{
			get { return states.Count; }
		}

		/// <summary>
		/// Returns a matching Item for the passed State-uid
		/// </summary>
		/// <param name="uid">the unique ID of the state</param>
		/// <param name="create">true if you want to create a new state (and add it) if it did not exist</param>
		/// <returns></returns>
		public PackageState FindState(uint uid, bool create) 
		{
			foreach (PackageState ps in states) 
			{
				if (ps.Uid == uid) return ps;
			}

			if (create) 
			{
				PackageState ps = new PackageState();
				ps.Uid = uid;

				states.Add(ps);
				return ps;
			}

			return null;
		}

		
		bool enabled;
		public bool Enabled
		{
			get { return enabled; }
			set { enabled = value; }
		}

		public override string ToString()
		{
			return "name="+Name;
		}

		#region ICacheItem Member

		public void Load(System.IO.BinaryReader reader) 
		{
			states.Clear();
			version = reader.ReadByte();
			if (version>VERSION) throw new CacheException("Unknown CacheItem Version.", null, version);
							
			name = reader.ReadString();
			type = (PackageType)reader.ReadUInt32();
			enabled = reader.ReadBoolean();
			int ct = reader.ReadByte();
			guids = new uint[ct];
			for (int i=0; i<guids.Length; i++) guids[i] = reader.ReadUInt32();	

			ct = reader.ReadByte();
			for (int i=0; i<ct; i++) 
			{
				PackageState ps = new PackageState();
				ps.Load(reader);
				states.Add(ps);
			}

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
			writer.Write((uint)type);			
			writer.Write(enabled);
			
			writer.Write((byte)guids.Length);
			for (int i=0; i<guids.Length; i++) writer.Write(guids[i]);	

			byte ct = (byte)states.Count;
			writer.Write(ct);
			for (int i=0; i<ct; i++) states[i].Save(writer);

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
