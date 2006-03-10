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
	public enum SimMemoryType : byte 
	{
		Memory,	Gossip,	Skill, Inventory, GossipInventory, ValueToken, Token, Object, Badge, Aspiration
	}

	public class NgbhItemFlags : FlagBase
	{
		public NgbhItemFlags(ushort flags) : base(flags) {}
		public NgbhItemFlags() : base(0) {}

		public bool IsVisible
		{
			get { return GetBit(0); }
			set { SetBit(0, value); }
		}

		public bool IsControler
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
		internal const int ICON_SIZE = 24; 
		Ngbh parent;
		NgbhSlotList parentslot;
		internal NgbhItem(NgbhSlotList parentslot) : this (parentslot, SimMemoryType.Memory) {}
		internal NgbhItem(NgbhSlotList parentslot, SimMemoryType type)
		{
			this.parentslot = parentslot;
			this.parent = parentslot.Parent;
			data = new ushort[0];
			flags = new NgbhItemFlags();
			objd = null;

			if (type == SimMemoryType.Aspiration || type == SimMemoryType.Skill || type == SimMemoryType.ValueToken || type == SimMemoryType.Badge)
			{
				Flags.IsVisible = false;
				Flags.IsControler = true;
				data = new ushort[2];
			} 
			else if (type == SimMemoryType.Token)
			{
				Flags.IsVisible = false;
				Flags.IsControler = true;
			}
			else if (type == SimMemoryType.Object) 
			{
				Flags.IsVisible = false;
				Flags.IsControler = true;
				data = new ushort[3];
			}
			else if (type == SimMemoryType.Gossip || type == SimMemoryType.Memory)
			{
				PutValue(0x01, 0x07CD);
				PutValue(0x02, 0x0006);
				PutValue(0x0B, 0);
				Flags.IsVisible = true;
				Flags.IsControler = false;
				if (type == SimMemoryType.Gossip) this.SimInstance = 1;
			}
			else if (type == SimMemoryType.GossipInventory || type == SimMemoryType.Inventory) 
			{
				Flags.IsVisible = true;
				Flags.IsControler = true;				
			
				if (type == SimMemoryType.GossipInventory)
				{
					data = new ushort[8];
					PutValue(0x01, 0x0);
				}		
		
				this.InventoryNumber = this.ParentSlot.GetNextInventoryNumber();
			}

			//SetGuidForType(type);
		}

		public void SetInitialGuid(SimMemoryType type)
		{
			SetGuidForType(type);
		}

		void SetGuidForType(SimMemoryType type)
		{			
			foreach (SimPe.Cache.MemoryCacheItem mci in SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.List)
			{
				if (type==	SimMemoryType.Inventory || type==SimMemoryType.GossipInventory || type==SimMemoryType.Object) 
				{
					if (mci.IsInventory && !mci.IsToken)
					{
						Guid = mci.Guid;
						return;
					}
				}
				else if ( type == SimMemoryType.Memory || type == SimMemoryType.Gossip)
				{
					if (!mci.IsInventory && !mci.IsToken && mci.IsMemory)
					{
						Guid = mci.Guid;
						return;
					}		
				} 
				else 
				{
					if (!mci.IsInventory && mci.IsToken)
					{
						Guid = mci.Guid;
						return;
					}
				}
			}
		}

		uint guid;
		NgbhItemFlags flags;
		uint flags2;
		ushort[] data;

		uint unknown;
		public uint InventoryNumber
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
				if (guid!=value) 
				{
					guid = value;
					objd = null;
					mci = null;
				}
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

				SimPe.Cache.MemoryCacheItem mci = SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.FindItem(guid);
				if (mci!=null) 
				{
					objd.Type = mci.ObjectType;
					objd.Guid = mci.Guid;
					objd.FileName = Localization.Manager.GetString("unknown");
				}

				
				return this.objd;
			}
		}

		
		SimPe.Cache.MemoryCacheItem mci;
		public SimPe.Cache.MemoryCacheItem  MemoryCacheItem
		{
			get 
			{
				try 
				{
					if (mci==null) mci = SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.FindItem(guid);					
				} 
				catch (Exception) {}

				if (mci==null) mci = new SimPe.Cache.MemoryCacheItem();
				return mci;
			}
		}

		public System.Drawing.Image Icon
		{
			get 
			{
				return Ambertation.Drawing.GraphicRoutines.ScaleImage(MemoryCacheItem.Image, ICON_SIZE, ICON_SIZE, true);
			}
		}

		public bool IsInventory
		{
			get {return this.InventoryNumber!=0;}
		}
		public  bool IsGossip
		{
			get 
			{
				if (ParentSlot is NgbhSlot)
					if (this.OwnerInstance != ((NgbhSlot)ParentSlot).SlotID && this.OwnerInstance!=0) return true;

				return false;
			}
		}

		public SimMemoryType MemoryType
		{
			get 
			{			
				bool gossip = IsGossip;									

				if (IsInventory) 
				{
					if (gossip) return SimMemoryType.GossipInventory;
					return SimMemoryType.Inventory;
				}

				if (this.Flags.IsControler) 
				{
					if (this.MemoryCacheItem.IsBadge)
						return SimMemoryType.Badge;
					if (this.MemoryCacheItem.IsSkill)
						return SimMemoryType.Skill;
					if (this.MemoryCacheItem.IsAspiration)
						return SimMemoryType.Aspiration;
					if (this.Data.Length<2)
						return SimMemoryType.Token;	
					if (this.Data.Length<3)
						return SimMemoryType.ValueToken;	

					return SimMemoryType.Object;
				}

				if (gossip) return SimMemoryType.Gossip;

				return SimMemoryType.Memory;
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
				//flags.IsGossip = this.IsGossip;
			}
		}

		public uint SubjectGuid
		{
			get { return SimID; }
			set { SimID = value; }
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
		/// Returns/Sets the value that is possible a Guid to a referenced Object
		/// </summary>
		/// <remarks>
		/// This is only valid if <see cref="MemoryType"/> is set to <see cref="SimMemoryType.Object"/>
		/// </remarks>
		public uint ReferencedObjectGuid 
		{
			get 
			{
				if (MemoryType!=SimMemoryType.Object) return 0;
				int sid = (this.GetValue(0x02) << 16) + this.GetValue(0x01);
				return (uint)sid;
			}

			set 
			{
				if (MemoryType!=SimMemoryType.Object) return;
				this.PutValue(0x01, (ushort)(value & 0x0000ffff));
				this.PutValue(0x02, (ushort)((value >> 16) & 0x0000ffff));
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

		public bool IsSimSubject
		{
			get {return this.SimInstance>0;}
		}		

		public void SetSubject(ushort inst, uint guid)
		{
			if (inst!=0)
				SimInstance = inst;
			else 
			{
				if (data.Length == 0xD)
				{
					ushort[] nd = new ushort[data.Length-1];
					for (int i=0; i<nd.Length; i++)
						nd[i] = data[i];
					data = nd;
				}
					
			}
			SimID = guid;
		}

		public void SetSubject(uint guid)
		{
			SimPe.Interfaces.Wrapper.ISDesc sdsc = FileTable.ProviderRegistry.SimDescriptionProvider.SimGuidMap[guid] as SimPe.Interfaces.Wrapper.ISDesc;
			if (sdsc!=null) SetSubject(sdsc.Instance, guid);
			else SetSubject(0, guid);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			Guid = reader.ReadUInt32();
						
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
		/// Assignes a Value to the given Slot
		/// </summary>
		/// <param name="slot">Slot Number</param>
		/// <param name="val">new Value</param>
		public void SetValue(int slot, ushort val) 
		{
			if (data.Length>slot) 
				data[slot] = val;			
		}

		/// <summary>
		/// Returns the Value of teh Slot
		/// </summary>
		/// <param name="slot">Slotnumber</param>
		/// <returns>the stored Value</returns>
		internal ushort GetValue(int slot) 
		{
			if (data.Length>slot) return data[slot];
			else return 0;	
		}

		protected string GetSubjectName()
		{

			string ext = " (0x"+Helper.HexString(this.SimID)+")";
			string n = SimPe.Localization.GetString("Unknown")+ext;
			if (parent.Provider.SimNameProvider.StoredData.ContainsKey(this.SimID))
				n = parent.Provider.SimNameProvider.FindName(this.SimID).ToString();
			else
			{
				SimPe.Cache.MemoryCacheItem mci = SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.FindItem(this.SimID);
				if (mci!=null) n = mci.Name + ext;
			}

			return n;
		}

		public override string ToString()
		{
			string name = this.MemoryCacheItem.Name.Replace("$Subject", GetSubjectName());
			if (name.Trim()=="") name = "---";

			if (!this.Flags.IsVisible) name = "[invisible] "+name;

			try 
			{
				if (OwnerInstance != this.ParentSlot.SlotID) 
				{
					uint sid = parent.Provider.SimDescriptionProvider.FindSim(OwnerInstance).SimId;
				
					name += " ("+SimPe.Localization.GetString("Gossip about")+" ";
					name += parent.Provider.SimNameProvider.FindName(sid);
					name += ")";
				}				
			} 
			catch (Exception)  {}

			if (MemoryType== SimMemoryType.Object) 
			{
				name += " {";
				SimPe.Cache.MemoryCacheItem mci = SimPe.PackedFiles.Wrapper.ObjectComboBox.ObjectCache.FindItem(this.ReferencedObjectGuid);
				if (mci!=null) name += mci.Name;
				name += "}";
			}

			return /*data.Length.ToString()+" "+*/name;
		}		

		/// <summary>
		/// removes this Item from its parent
		/// </summary>
		public void RemoveFromParentB()
		{
			parentslot.ItemsB.Remove(this);// = NgbhSlot.Remove(parentslot.ItemsB, this);
		}

		/// <summary>
		/// Adds this Item to the assignd Parent Slot
		/// </summary>
		public void AddToParentB()
		{
			parentslot.ItemsB.Add(this);// = NgbhSlot.Add(parentslot.ItemsB, this);
		}

		/// <summary>
		/// removes this Item from its parent
		/// </summary>
		public void RemoveFromParentA()
		{
			parentslot.ItemsA.Remove(this);// = NgbhSlot.Remove(parentslot.ItemsA, this);
		}

		/// <summary>
		/// Adds this Item to the assignd Parent Slot
		/// </summary>
		public void AddToParentA()
		{
			parentslot.ItemsA.Add(this);// = NgbhSlot.Add(parentslot.ItemsA, this);
		}
	}
}
