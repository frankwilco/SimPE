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
using System.ComponentModel;
using SimPe.Geometry;

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// What type of Information is stored in the Token
	/// </summary>
	public enum AnimationTokenType  :byte
	{
		/// <summary>
		/// One Short Value (0=transform parameter)
		/// </summary>
		TwoByte = 0,
		/// <summary>
		/// three Short Values (0=timecode, 1=transform parameter, 2=???)
		/// </summary>
		SixByte = 1,
		/// <summary>
		/// four short Values (0=timecode, 1=transform parameter, 2=???, 3=???)
		/// </summary>
		EightByte = 2
	}

	/// <summary>
	/// What type of Information is stored in a Frame
	/// </summary>
	public enum FrameType  :byte
	{
		/// <summary>
		/// Translations
		/// </summary>
		Translation = 0x10,
		/// <summary>
		/// Rotations
		/// </summary>
		Rotation = 0x0C,
		/// <summary>
		/// Unknown Type
		/// </summary>
		Unknown = 0xFF
	}	

	/// <summary>
	/// Base Class for common structures in the diffrent AnimBlock Formats
	/// </summary>
	public class AnimBlock 
	{
		protected string name;

		[DescriptionAttribute("Name of the selected Item")]
		public virtual string Name 
		{
			get { return name; }
			set { name = value; }
		}

		internal AnimBlock() 
		{
			name = "";
		}		

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal int UnserializeName(System.IO.BinaryReader reader)
		{
			name = "";
			while (true)
			{
				char ch = reader.ReadChar();
				if (ch==0) break;
				name += ch;
			}

			return name.Length+1;
		}

		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal int SerializeName(System.IO.BinaryWriter writer)
		{
			foreach (char c in name) writer.Write(c);
			writer.Write((byte)0);

			return name.Length+1;
		}

		public override string ToString()
		{
			return name;
		}

	}


	





	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock4
	{			
		#region Attributes		
		AnimBlock5[] ab5;
		[BrowsableAttribute(false)]
		public AnimBlock5[] Part5 
		{
			get { return ab5; }
		}
		[DescriptionAttribute("Number of loaded AnimBlock4 Items"), CategoryAttribute("Information")]
		public int Part5Count 
		{
			get { return ab5.Length; }
		}

		uint[] datai;
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}	
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}	

		byte[] data;
		[DescriptionAttribute("On Index 2 the Number of assigned AnimBlock5 Items is stored")]
		public byte[] AddonData 
		{
			get { return data; }
		}
		#endregion

		internal AnimBlock4() 
		{
			datai = new uint[3];
			data = new byte[0x3A];
			ab5 = new AnimBlock5[0];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			long pos = reader.BaseStream.Position;
			if (reader.BaseStream.Length-pos < 4+4+data.Length+4) return;

			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();	
			data = reader.ReadBytes(data.Length);
			datai[2] = reader.ReadUInt32();

			if (datai[2]!=datai[1]) 
			{	
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
				return;
			}
		}	
	
		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			this.SetPart5Count(ab5.Length);

			writer.Write(datai[0]);
			writer.Write(datai[1]);	
			writer.Write(data);
			writer.Write(datai[2]);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart5Data(System.IO.BinaryReader reader)
		{
			ab5 = new AnimBlock5[GetPart5Count()];
			for (int i=0; i<ab5.Length; i++) 
			{
				ab5[i] = new AnimBlock5();
				ab5[i].UnserializeData(reader);
			}
		}		

		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart5Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab5.Length; i++) ab5[i].SerializeData(writer);		
		}

		/// <summary>
		/// Returns the Number of Items for Part 5 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart5Count()
		{
			return (data[2]);
		}

		/// <summary>
		/// Set the count for Part 5 Items
		/// </summary>
		/// <param name="ct">The New Count</param>
		void SetPart5Count(int ct) 
		{
			if (ct>0xff) ct=0xff;
			data[2] = (byte)(ct & 0xff);
		}

		public override string ToString()
		{
			return "AnimBlock4: "+this.Part5Count.ToString()+" "+this.AddonData.Length.ToString();
		}

	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock5
	{		
		#region Attributes
		uint[] datai;
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
						
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}	

		public string Unknown2Binary
		{
			get 
			{ 
				string s = Convert.ToString(Unknown2, 2); 
				s = Helper.MinStrLength(s, 14);
				int p=s.Length-4;
				while (p>=0) 
				{
					s = s.Insert(p, " ");
					p-=4;
				}
				return s.Trim();
			}
			
		}

		public string Unknown2Hex
		{
			get { return "0x"+Helper.HexString(Unknown2); }
			
		}

		byte[] data;
		public byte[] AddonData 
		{
			get { return data; }
		}
		#endregion

		internal AnimBlock5() 
		{
			datai = new uint[2];
			data = new byte[0x23];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		/// <remarks>This is only a DEBUG Implementation!</remarks>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			long pos = reader.BaseStream.Position;
			/*if (reader.BaseStream.Length-pos < 4+4+data.Length) 
                return;*/

			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();	
			data = reader.ReadBytes(data.Length);

			/*if (datai[0]!=0x11BA05F0 || datai[1]!=0x11BA05F0) 
			{	
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
				return;
			}*/
		}
		
		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			writer.Write(datai[0]);
			writer.Write(datai[1]);	
			writer.Write(data);
		}

		public override string ToString()
		{
			return "0x"+Helper.HexString(Unknown2)+" "+this.AddonData.Length.ToString();
		}
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock6 : AnimBlock
	{		
		#region Attributes
		uint[] datai;	
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]						
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]						
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}		

		short[] datas;
		public short SUnknown1 
		{
			get { return datas[0]; }
			set { datas[0] = value; }
		}
		public short SUnknown2 
		{
			get { return datas[1]; }
			set { datas[1] = value; }
		}
		public short SUnknown3 
		{
			get { return datas[2]; }
			set { datas[2] = value; }
		}		
		#endregion

		internal AnimBlock6() 
		{
			datai = new uint[2];
			datas = new short[3];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();			

			datas[0] = reader.ReadInt16();
			datas[1] = reader.ReadInt16();
			datas[2] = reader.ReadInt16();
		
			datai[1] = reader.ReadUInt32();
		}
		
		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			writer.Write(datai[0]);

			writer.Write(datas[0]);
			writer.Write(datas[1]);
			writer.Write(datas[2]);
		
			writer.Write(datai[1]);
		}

		

	}

	
}
