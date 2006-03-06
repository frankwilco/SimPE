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

namespace SimPe.Plugin
{
	public class NgbhItemFlags : FlagBase
	{
		public NgbhItemFlags(ushort flags) : base(flags) {}
		public NgbhItemFlags() : base(0) {}

		public bool IsVisible
		{
			get { return GetBit(0); }
			set { SetBit(0, value); }
		}

		public bool IsAction
		{
			get { return !GetBit(1); }
			set { SetBit(1, !value); }
		}
	}

	/// <summary>
	/// Contains an Item in a NghbSlot
	/// </summary>
	public class NgbhItem
	{
		Ngbh parent;
		NgbhSlotList parentslot;
		public NgbhItem(Ngbh parent, NgbhSlotList parentslot)
		{
			this.parentslot = parentslot;
			this.parent = parent;
			data = new ushort[0];
			flags = new NgbhItemFlags();
			objd = null;
		}

		uint guid;
		NgbhItemFlags flags;
		uint flags2;
		ushort[] data;

		uint unknown;
		public uint Unknown
		{
			get {return unknown; }
			set { unknown = value; }
		}

		protected SimPe.PackedFiles.Wrapper.ExtObjd objd = null;

		/// <summary>
		/// Returns the Slot that owns this Item
		/// </summary>
		public NgbhSlotList ParentSlot
		{
			get { return parentslot; }
		}

		/// <summary>
		/// Return the Guid for this Item
		/// </summary>
		public uint Guid 
		{
			get { return guid; }
			set 
			{
				guid = value;
				objd = null;
			}
		}

		/// <summary>
		/// Yet unknown, probably a Flag
		/// </summary>
		public NgbhItemFlags Flags
		{
			get { return flags; }
			set { flags = value; }
		}

		/// <summary>
		/// Returns / Sets the storeed Data
		/// </summary>
		public ushort[] Data 
		{
			get { return data; }
			set { data = value; }
		}

		/// <summary>
		/// Returns the ObjectData for this Item
		/// </summary>
		public SimPe.PackedFiles.Wrapper.ExtObjd ObjectDataFile
		{
			get 
			{
				if (objd!=null) return objd;

				this.objd = new SimPe.PackedFiles.Wrapper.ExtObjd(null);

				SimPe.Cache.MemoryCacheItem mci = NgbhUI.ObjectCache.FindItem(guid);
				if (mci!=null) 
				{
					objd.Type = mci.ObjectType;
					objd.Guid = mci.Guid;
					objd.FileName = Localization.Manager.GetString("unknown");
				}

				
				return this.objd;
			}
		}

		public string Text
		{
			get 
			{
				
				try 
				{
					SimPe.Cache.MemoryCacheItem mci = NgbhUI.ObjectCache.FindItem(guid);
					if (mci!=null) return mci.Name;
				} 
				catch (Exception) {}

				return ObjectDataFile.FileName;
									
			}
		}

		/// <summary>
		/// Returns the Image associated with that Item
		/// </summary>
		public System.Drawing.Image Image 
		{
			get 
			{
				try 
				{
					SimPe.Cache.MemoryCacheItem mci = NgbhUI.ObjectCache.FindItem(guid);
					if (mci!=null) return mci.Icon;
				} 
				catch (Exception) {}
				return new System.Drawing.Bitmap(1, 1);
			}
		}

		/// <summary>
		/// True if this Item can be processed as a Memory
		/// </summary>
		public bool IsMemory 
		{
			get 
			{
				return ((SimPe.Data.ObjectTypes)this.ObjectDataFile.Type == SimPe.Data.ObjectTypes.Memory);
			}
		}

		/// <summary>
		/// Returns/Sets the Instance of the Sim that owns the Event (not the Memory!)
		/// </summary>
		public ushort Value 
		{
			get 
			{
				return this.GetValue(0x00);
			}

			set 
			{
				this.PutValue(0x00, value);
			}
		}

		/// <summary>
		/// Returns/Sets the Instance of the Sim that owns the Event (not the Memory!)
		/// </summary>
		public ushort OwnerInstance 
		{
			get 
			{
				return this.GetValue(0x04);
			}

			set 
			{
				this.PutValue(0x04, value);
			}
		}

		/// <summary>
		/// Returns/Sets the value that is possible the SimID (of a Memory)
		/// </summary>
		public uint SimID 
		{
			get 
			{
				int sid = (this.GetValue(0x06) << 16) + this.GetValue(0x05);
				return (uint)sid;
			}

			set 
			{
				this.PutValue(0x05, (ushort)(value & 0x0000ffff));
				this.PutValue(0x06, (ushort)((value >> 16) & 0x0000ffff));
			}
		}

		/// <summary>
		/// Returns/Sets the value that is possible the Instance of a Sim
		/// </summary>
		public ushort SimInstance 
		{
			get 
			{
				return this.GetValue(0x0C);
			}

			set 
			{
				this.PutValue(0x0C, value);
			}
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			guid = reader.ReadUInt32();
						
			flags = new NgbhItemFlags(reader.ReadUInt16());
			if ((uint)parent.Version>=(uint)NgbhVersion.Business)
				flags2 = new NgbhItemFlags(reader.ReadUInt16());
			if ((uint)parent.Version>=(uint)NgbhVersion.Nightlife) unknown = reader.ReadUInt32();
			data = new ushort[reader.ReadInt32()];
			for (int i=0; i<data.Length; i++) 
			{
				data[i] = reader.ReadUInt16();
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
		internal void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(guid);
			writer.Write(flags.Value); 
			if ((uint)parent.Version>=(uint)NgbhVersion.Business) 
				writer.Write((ushort)flags2);
			if ((uint)parent.Version>=(uint)NgbhVersion.Nightlife) writer.Write(unknown);
			writer.Write((int)data.Length);
			for (int i=0; i<data.Length; i++) 
			{
				writer.Write(data[i]);
			}
		}

		/// <summary>
		/// Assignes a Value to the given Slot
		/// </summary>
		/// <param name="slot">Slot Number</param>
		/// <param name="val">new Value</param>
		public void PutValue(int slot, ushort val) 
		{
			if (data.Length<=slot) 
			{
				ushort[] tmp = new ushort[slot+1];
				data.CopyTo(tmp, 0);
				data = tmp;
			} 
			data[slot] = val;			
		}

		/// <summary>
		/// Returns the Value of teh Slot
		/// </summary>
		/// <param name="slot">Slotnumber</param>
		/// <returns>the stored Value</returns>
		protected ushort GetValue(int slot) 
		{
			if (data.Length>slot) return data[slot];
			else return 0;	
		}

		public override string ToString()
		{
			string name = Text.Replace("$Subject", parent.Provider.SimNameProvider.FindName(this.SimID).ToString());
			if (name.Trim()=="") name = "---";

			if (!this.Flags.IsVisible) name = "[invisible] "+name;

			try 
			{
				if (OwnerInstance != this.ParentSlot.SlotID) 
				{
					uint sid = parent.Provider.SimDescriptionProvider.FindSim(OwnerInstance).SimId;
				
					name += " (owned by ";
					name += parent.Provider.SimNameProvider.FindName(sid);
					name += ")";
				}
			} 
			catch (Exception)  {}
			return name;
		}

		/// <summary>
		/// removes this Item from its parent
		/// </summary>
		public void RemoveFromParentB()
		{
			parentslot.ItemsB = NgbhSlot.Remove(parentslot.ItemsB, this);
		}

		/// <summary>
		/// Adds this Item to the assignd Parent Slot
		/// </summary>
		public void AddToParentB()
		{
			parentslot.ItemsB = NgbhSlot.Add(parentslot.ItemsB, this);
		}

		/// <summary>
		/// removes this Item from its parent
		/// </summary>
		public void RemoveFromParentA()
		{
			parentslot.ItemsA = NgbhSlot.Remove(parentslot.ItemsA, this);
		}

		/// <summary>
		/// Adds this Item to the assignd Parent Slot
		/// </summary>
		public void AddToParentA()
		{
			parentslot.ItemsA = NgbhSlot.Add(parentslot.ItemsA, this);
		}
	}
}
