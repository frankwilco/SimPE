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

namespace SimPe.Plugin
{

	/// <summary>
	/// A Slot contains a number of NgbhItem Objects
	/// </summary>
	public class NgbhSlotList
	{
		uint version;
		public NgbhVersion Version
		{
			get {return (NgbhVersion)version; }
			set { version = (uint)value; }
		}

		Ngbh parent;
		public Ngbh Parent
		{
			get {return parent;}
		}
		public NgbhSlotList(Ngbh parent)
		{
			if (parent!=null) 
				this.Version = parent.Version;
			else 
				this.Version = NgbhVersion.University;
			this.parent = parent;
			itemsa = new SimPe.Plugin.Collections.NgbhItems(this);
			itemsb = new SimPe.Plugin.Collections.NgbhItems(this);
		}

		/// <summary>
		/// Id of a Slot
		/// </summary>
		uint slotid;

		/// <summary>
		/// Returns / Sets the ID of this Slot
		/// </summary>
		public uint SlotID
		{
			get { return slotid; }
			set { slotid = value; }
		}

		/// <summary>
		/// stored items
		/// </summary>
		Collections.NgbhItems itemsa;

		/// <summary>
		/// Returns / Sets the stored NgbhItem
		/// </summary>
		public Collections.NgbhItems ItemsA 
		{
			get { return itemsa; }
			set { itemsa = value; }
		}

		/// <summary>
		/// stored items
		/// </summary>
		Collections.NgbhItems itemsb;

		/// <summary>
		/// Returns / Sets the stored NgbhItem
		/// </summary>
		public Collections.NgbhItems ItemsB 
		{
			get { return itemsb; }
			set { itemsb = value; }
		}	
	
		public Collections.NgbhItems GetItems(Data.NeighborhoodSlots id)
		{
			if (id==Data.NeighborhoodSlots.Families || id==Data.NeighborhoodSlots.Lots || id==Data.NeighborhoodSlots.Sims)
				return ItemsB;			

			return ItemsA;
		}	
		

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal virtual void Unserialize(System.IO.BinaryReader reader)
		{
			if ((uint)parent.Version>=(uint)NgbhVersion.Nightlife) version = reader.ReadUInt32();
			uint ct = reader.ReadUInt32();
			itemsa.Clear();			
			for (int j=0; j<ct; j++) 
			{
				NgbhItem item = itemsa.AddNew();
				item.Unserialize(reader);				
			}

			

			ct = reader.ReadUInt32();
			itemsb.Clear();
			for (int j=0; j<ct; j++) 
			{
				NgbhItem item = itemsb.AddNew();
				item.Unserialize(reader);
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
		internal virtual void Serialize(System.IO.BinaryWriter writer)
		{
			if ((uint)parent.Version>=(uint)NgbhVersion.Nightlife) writer.Write(version);

			writer.Write((uint)itemsa.Length);
			for (int j=0; j<itemsa.Length; j++) itemsa[j].Serialize(writer);
			
			writer.Write((uint)itemsb.Length);
			for (int j=0; j<itemsb.Length; j++) itemsb[j].Serialize(writer);
		}
	}

	/// <summary>
	/// A Slot contains a number of NgbhItem Objects
	/// </summary>
	public class NgbhSlot : NgbhSlotList
	{
		public NgbhSlot(Ngbh parent) : base(parent)
		{
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal override void Unserialize(System.IO.BinaryReader reader)
		{
			this.SlotID = reader.ReadUInt32();
			

			base.Unserialize(reader);
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		internal override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(this.SlotID);

			base.Serialize(writer);
		}
	}
}
