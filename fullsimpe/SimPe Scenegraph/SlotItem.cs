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
	/// Known Types for Slot Items
	/// </summary>
	public enum SlotItemType : ushort
	{
		Container = 0,
		Location = 1,
		Routing = 2,
		Target = 3
	}

	/// <summary>
	/// contains a Slot Item
	/// </summary>
	public class SlotItem 
	{
		#region Attributes
		SlotItemType type;
		public SlotItemType Type 
		{
			get { return type; }
			set { type = value; }
		}

		#endregion
		Slot parent;
		public Slot Parent 
		{
			get { return parent; }
		}

		float unknownf1;		
		public float UnknownFloat1
		{
			get { return unknownf1; }
			set { unknownf1 = value; }
		}

		float unknownf2;		
		public float UnknownFloat2
		{
			get { return unknownf2; }
			set { unknownf2 = value; }
		}

		float unknownf3;		
		public float UnknownFloat3
		{
			get { return unknownf3; }
			set { unknownf3 = value; }
		}

		float unknownf4;		
		public float UnknownFloat4
		{
			get { return unknownf4; }
			set { unknownf4 = value; }
		}

		float unknownf5;		
		public float UnknownFloat5
		{
			get { return unknownf5; }
			set { unknownf5 = value; }
		}

		float unknownf6;		
		public float UnknownFloat6
		{
			get { return unknownf6; }
			set { unknownf6 = value; }
		}

		float unknownf7;		
		public float UnknownFloat7
		{
			get { return unknownf7; }
			set { unknownf7 = value; }
		}

		float unknownf8;		
		public float UnknownFloat8
		{
			get { return unknownf8; }
			set { unknownf8 = value; }
		}


		int unknowni1;		
		public int UnknownInt1
		{
			get { return unknowni1; }
			set { unknowni1 = value; }
		}

		int unknowni2;		
		public int UnknownInt2
		{
			get { return unknowni2; }
			set { unknowni2 = value; }
		}

		int unknowni3;		
		public int UnknownInt3
		{
			get { return unknowni3; }
			set { unknowni3 = value; }
		}

		int unknowni4;		
		public int UnknownInt4
		{
			get { return unknowni4; }
			set { unknowni4 = value; }
		}

		int unknowni5;		
		public int UnknownInt5
		{
			get { return unknowni5; }
			set { unknowni5 = value; }
		}

		int unknowni6;		
		public int UnknownInt6
		{
			get { return unknowni6; }
			set { unknowni6 = value; }
		}

		int unknowni7;		
		public int UnknownInt7
		{
			get { return unknowni7; }
			set { unknowni7 = value; }
		}

		int unknowni8;		
		public int UnknownInt8
		{
			get { return unknowni8; }
			set { unknowni8 = value; }
		}

		int unknowni9;		
		public int UnknownInt9
		{
			get { return unknowni9; }
			set { unknowni9 = value; }
		}

		int unknowni10;		
		public int UnknownInt10
		{
			get { return unknowni10; }
			set { unknowni10 = value; }
		}


		short unknowns1;		
		public short UnknownShort1
		{
			get { return unknowns1; }
			set { unknowns1 = value; }
		}

		short unknowns2;		
		public short UnknownShort2
		{
			get { return unknowns2; }
			set { unknowns2 = value; }
		}


		public SlotItem(Slot parent) 
		{
			this.parent = parent;
		}
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void Unserialize(System.IO.BinaryReader reader)
		{
			type = (SlotItemType)reader.ReadUInt16();

			unknownf1 = reader.ReadSingle();
			unknownf2 = reader.ReadSingle();
			unknownf3 = reader.ReadSingle();

			unknowni1 = reader.ReadInt32();
			unknowni2 = reader.ReadInt32();
			unknowni3 = reader.ReadInt32();
			unknowni4 = reader.ReadInt32();
			unknowni5 = reader.ReadInt32();

			if (parent.Version>=5) 
			{
				unknownf4 = reader.ReadSingle();
				unknownf5 = reader.ReadSingle();
				unknownf6 = reader.ReadSingle();

				unknowni6 = reader.ReadInt32();
			}

			if (parent.Version>=6) 
			{
				unknowns1 = reader.ReadInt16();
				unknowns2 = reader.ReadInt16();
			}

			if (parent.Version>=7) unknownf7 = reader.ReadSingle();
			if (parent.Version>=8) unknowni7 = reader.ReadInt32();
			if (parent.Version>=9) unknowni8 = reader.ReadInt32();
			if (parent.Version>=0x10) unknownf8 = reader.ReadSingle();

			if (parent.Version>=0x40) 
			{
				unknowni9 = reader.ReadInt32();
				unknowni10 = reader.ReadInt32();
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
		internal void Serialize(System.IO.BinaryWriter writer, Slot parent)
		{	
			this.parent = parent;
			writer.Write((ushort)type);

			writer.Write(unknownf1);
			writer.Write(unknownf2);
			writer.Write(unknownf3);

			writer.Write(unknowni1);
			writer.Write(unknowni2);
			writer.Write(unknowni3);
			writer.Write(unknowni4);
			writer.Write(unknowni5);

			if (parent.Version>=5) 
			{
				writer.Write(unknownf4);
				writer.Write(unknownf5);
				writer.Write(unknownf6);

				writer.Write(unknowni6);
			}

			if (parent.Version>=6) 
			{
				writer.Write(unknowns1);
				writer.Write(unknowns2);
			}

			if (parent.Version>=7) writer.Write(unknownf7);
			if (parent.Version>=8) writer.Write(unknowni7);
			if (parent.Version>=9) writer.Write(unknowni8);
			if (parent.Version>=0x10) writer.Write(unknownf8);

			if (parent.Version>=0x40) 
			{
				writer.Write(unknowni9);
				writer.Write(unknowni10);
			}
		}

		public override string ToString()
		{
			return Type.ToString();
		}

	}

	/// <summary>
	/// Typesave ArrayList for StrIte Objects
	/// </summary>
	public class SlotItems : ArrayList 
	{
		public new SlotItem this[int index]
		{
			get { return ((SlotItem)base[index]); }
			set { base[index] = value; }
		}

		public SlotItem this[uint index]
		{
			get { return ((SlotItem)base[(int)index]); }
			set { base[(int)index] = value; }
		}

		public int Add(SlotItem item)
		{
			return base.Add(item);
		}

		public void Insert(int index, SlotItem item)
		{
			base.Insert(index, item);
		}

		public void Remove(SlotItem item)
		{
			base.Remove(item);
		}

		public bool Contains(SlotItem item)
		{
			return base.Contains(item);
		}		

		public int Length 
		{
			get { return this.Count; }
		}

		public override object Clone()
		{
			SlotItems list = new SlotItems();
			foreach (SlotItem item in this) list.Add(item);

			return list;
		}

	}
}
