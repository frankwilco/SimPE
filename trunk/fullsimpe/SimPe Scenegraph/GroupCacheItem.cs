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
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Wrapper;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	public class GroupCacheItem : IGroupCacheItem		
	{
		#region Attributes
		string flname;
		/// <summary>
		/// Returns the FileName for this Item
		/// </summary>
		public string FileName 
		{
			get { return flname.Trim().ToLower(); }
			set { flname = value.Trim().ToLower(); }
		}

		uint unknown1;
		uint localgroup;
		/// <summary>
		/// Returns the Group that was assigned by the Game
		/// </summary>
		public uint LocalGroup 
		{
			get { return localgroup; }
			set {localgroup = value; }
		}
		uint[] unknown2;		
		#endregion

		/// <summary>
		/// Constructor
		/// </summary>
		public GroupCacheItem() : base()
		{		
			flname = "";
			unknown2 = new uint[0];
		}		
		
		#region AbstractWrapper Member		
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			int ct = reader.ReadInt32();
			flname = "";
			/*char[] cs = reader.ReadChars(ct);
			for (int i=0; i<cs.Length; i++) flname += cs[i];		*/
			byte[] bs = reader.ReadBytes(ct);
			flname = Helper.ToString(bs);
			unknown1 = reader.ReadUInt32();
			localgroup = reader.ReadUInt32();			
			unknown2 = new uint[reader.ReadUInt32()];
			for (int i=0; i<unknown2.Length; i++) unknown2[i]=reader.ReadUInt32();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		internal void Serialize(System.IO.BinaryWriter writer)
		{		
			int ct = flname.Length;			
			byte[] bs = Helper.ToBytes(flname, 0);
			writer.Write((int)bs.Length);
			writer.Write(bs);
			writer.Write(unknown1);
			writer.Write(localgroup);
			for (int i=0; i<unknown2.Length; i++) writer.Write(unknown2[i]);			
		}
		#endregion

		public override string ToString()
		{
			string n = this.FileName;
			n += " => 0x";
			n += Helper.HexString(unknown1) + ":0x" + Helper.HexString(this.LocalGroup);
			n += " (";
			for (int i=0; i<unknown2.Length; i++) 
			{
				if (i!=0) n+=", ";
				n+=  Helper.HexString(unknown2[i]);
			}
			n += " )";
			return n;
		}

	}

	/// <summary>
	/// Typesave ArrayList for StrIte Objects
	/// </summary>
	public class GroupCacheItems : ArrayList 
	{
		public new GroupCacheItem this[int index]
		{
			get { return ((GroupCacheItem)base[index]); }
			set { base[index] = value; }
		}

		public GroupCacheItem this[uint index]
		{
			get { return ((GroupCacheItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(GroupCacheItem item)
		{
			return base.Add(item);
		}

		public void Insert(int index, GroupCacheItem item)
		{
			base.Insert(index, item);
		}

		public void Remove(GroupCacheItem item)
		{
			base.Remove(item);
		}

		public bool Contains(GroupCacheItem item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			GroupCacheItems list = new GroupCacheItems();
			foreach (GroupCacheItem item in this) list.Add(item);

			return list;
		}

	}
}
