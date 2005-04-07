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
	/// <summary>
	/// Meanings of the Want Bits
	/// </summary>
	public enum WantFlagValues : byte 
	{
		Locked = 0
	}

	/// <summary>
	/// All known Want Flags
	/// </summary>
	public class WantFlags : SimPe.FlagBase
	{
		internal WantFlags(ushort val):base(val){}

		public bool Locked
		{
			get { return GetBit((byte)WantFlagValues.Locked); }
			set { SetBit((byte)WantFlagValues.Locked, value); }
		}
	}

	/// <summary>
	/// A Want item stored in a Want File
	/// </summary>
	public class WantItem
	{
		#region Attributes
		uint version;
		public uint Version
		{
			get { return version; }
			set {version = value; }
		}

		ushort siminst;
		public ushort SimInstance
		{
			get { return siminst; }
			set {siminst = value; }
		}

		uint guid;
		public uint Guid
		{
			get { return guid; }
			set {guid = value; }
		}

		
		WantType type;
		public WantType Type
		{
			get { return type; }
			set {type = value; }
		}

		
		uint data;
		public uint Value
		{
			get { return data; }
			set {data = value; }
		}

		
		ushort property;
		public ushort Property
		{
			get { return property; }
			set {property = value; }
		}

		
		uint counter;
		public uint Index
		{
			get { return counter; }
			set {counter = value; }
		}

		
		int score;
		public int Score
		{
			get { return score; }
			set {score = value; }
		}

		
		WantFlags flag;
		public WantFlags Flag
		{
			get { return flag; }
			set {flag = value; }
		}

		
		int influence;
		public int Influence
		{
			get { return influence; }
			set {influence = value; }
		}

		

		Interfaces.IProviderRegistry provider;
		public Interfaces.IProviderRegistry Provider 
		{
			get { return provider; }
		}

		/// <summary>
		/// Returns Informations about the Selected want
		/// </summary>
		public WantInformation Information 
		{
			get 
			{
				return WantInformation.LoadWant(guid);
			}
		}
		#endregion

		public WantItem(Interfaces.IProviderRegistry provider)
		{
			version = 8;
			this.provider = provider;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public  void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			siminst = reader.ReadUInt16();
			guid = reader.ReadUInt32();
			type = (WantType)reader.ReadByte();

			if (type == WantType.Skill) data = reader.ReadUInt16();
			else if (type == WantType.Sim) 
			{
				if (version>=8) data = reader.ReadUInt16();
				else data = 0;
			} 
			else if ((byte)type>1) data = reader.ReadUInt32();
			else data = 0;

			property = reader.ReadUInt16();
			counter = reader.ReadUInt32();
			score = reader.ReadInt32();			

			if (version>=9) influence = reader.ReadInt32();

			flag = new WantFlags(reader.ReadByte());
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public  void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);
			writer.Write(siminst);
			writer.Write(guid);
			writer.Write((byte)type);

			if (type == WantType.Skill) writer.Write((ushort)data);
			else if (type == WantType.Sim) 
			{
				if (version>=8) writer.Write((ushort)data);
				else data = 0;
			} 
			else if ((byte)type>1) writer.Write((uint)data);
			else data = 0;

			writer.Write(property);
			writer.Write(counter);
			writer.Write(score);			

			if (version>=9) writer.Write(influence);

			writer.Write((byte)flag.Value);
		}

		public override string ToString()
		{		
			string n = Information.Name;
			n = n.Replace("$Value", this.Property.ToString());
			n = n.Replace("$Money", this.Property.ToString());
			string c = WantLoader.WantNameLoader.FindName(Type, this.Value);

			if (this.Type==WantType.Career) 
			{				
				if (c!=null) n = n.Replace("$JobTitle", c);
				if (c!=null) n = n.Replace("$CareerTrack", c);
			} 
			else if (this.Type==WantType.Skill) 
			{
				if (c!=null) n = n.Replace("$Skill", c);
			} 
			else if (this.Type==WantType.Category) 
			{				  
				if (c!=null) n = n.Replace("$ObjectType", c);
			} 
			else if (this.Type==WantType.Object) 
			{				
				if (c!=null) n = n.Replace("$Object", c);
			}  
			else if (this.Type==WantType.Sim)
			{
				if (c!=null) n = n.Replace("$Neighbor", c);
			} 

			return n;
		}

	}
}
