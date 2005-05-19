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

namespace SimPe.Plugin
{
	/// <summary>
	/// Base Class for common structures in the diffrent AnimBlock Formats
	/// </summary>
	public class AnimBlock 
	{
		protected string name;

		[DescriptionAttribute("Name of the selected Item")]
		public string Name 
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

		public override string ToString()
		{
			return name;
		}

	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock1 : AnimBlock
	{		
		#region Attributes
		AnimBlock2[] ab2;
		[BrowsableAttribute(false)]
		public AnimBlock2[] Part2 
		{
			get { return ab2; }
		}
		[DescriptionAttribute("Number of loaded AnimBlock2 Items"), CategoryAttribute("Information")]
		public int Part2Count 
		{
			get { return ab2.Length; }
		}

				
		AnimBlock4[] ab4;
		[BrowsableAttribute(false)]
		public AnimBlock4[] Part4 
		{
			get { return ab4; }
		}
		[DescriptionAttribute("Number of loaded AnimBlock4 Items"), CategoryAttribute("Information")]
		public int Part4Count 
		{
			get { return ab4.Length; }
		}

		uint[] datai;
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown5 
		{
			get { return datai[4]; }
			set { datai[4] = value; }
		}

		short[] datas;
		public short SUnknown1 
		{
			get { return datas[0]; }
			set { datas[0] = value; }
		}

		[DescriptionAttribute("Number of assigned AnimBlock2 Items")]
		public short SUnknown2 
		{
			get { return datas[1]; }
		}
		
		[DescriptionAttribute("Lower 6 Bits(?) are reserved for the Number of assigned AnimBlock4 Items")]
		public short SUnknown3 
		{
			get { return datas[2]; }
			set { datas[2] = value; }
		}
		public short SUnknown4 
		{
			get { return datas[3]; }
			set { datas[3] = value; }
		}
		#endregion

		internal AnimBlock1() 
		{
			datai = new uint[6];
			datas = new short[4];
			ab2 = new AnimBlock2[0];
			ab4 = new AnimBlock4[0];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();

			datas[0] = reader.ReadInt16();
			datas[1] = reader.ReadInt16();	//number of ab2 Items
			datas[2] = reader.ReadInt16();  //number of ab4 Items (and some unknown Bits)
			datas[3] = reader.ReadInt16();			

			datai[2] = reader.ReadUInt32();
			datai[3] = reader.ReadUInt32();
			datai[4] = reader.ReadUInt32();
		}	

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart2Data(System.IO.BinaryReader reader)
		{
			ab2 = new AnimBlock2[GetPart2Count()];
			for (int i=0; i<ab2.Length; i++) 
			{
				ab2[i] = new AnimBlock2();
				ab2[i].UnserializeData(reader);
			}
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal int UnserializePart2Name(System.IO.BinaryReader reader)
		{
			int len = 0;
			for (int i=0; i<ab2.Length; i++) len += ab2[i].UnserializeName(reader);
			return len;
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart3Data(System.IO.BinaryReader reader)
		{			
			for (int i=0; i<ab2.Length; i++) ab2[i].UnserializePart3Data(reader);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart3AddonData(System.IO.BinaryReader reader)
		{						
			for (int i=0; i<ab2.Length; i++) ab2[i].UnserializePart3AddonData(reader);
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart4Data(System.IO.BinaryReader reader)
		{					
			ab4 = new AnimBlock4[GetPart4Count()];
			for (int i=0; i<ab4.Length; i++) 
			{
				ab4[i] = new AnimBlock4();
				ab4[i].UnserializeData(reader);
			}
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart5Data(System.IO.BinaryReader reader)
		{			
			for (int i=0; i<ab4.Length; i++) ab4[i].UnserializePart5Data(reader);
		}
	
		/// <summary>
		/// Returns the Number of Items for Part 2 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart2Count()
		{
			return (datas[1]);
		}
		
		/// <summary>
		/// Returns the Number of Items for Part 4 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart4Count()
		{
			return (datas[2] & 0x3f);
		}
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock2 : AnimBlock
	{
		
		#region Attributes
		AnimBlock3[] ab3;
		[BrowsableAttribute(false)]
		public AnimBlock3[] Part3 
		{
			get { return ab3; }
		}
		[DescriptionAttribute("Number of loaded AnimBlock3 Items"), CategoryAttribute("Information")]
		public int Part3Count 
		{
			get { return ab3.Length; }
		}

		uint[] datai;
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]		
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}
		[DescriptionAttribute("Highest 3 Bits contain the Number of assigned AnimBlock3 Items")]
		public uint Unknown5 
		{
			get { return datai[4]; }
			set { datai[4] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown6 
		{
			get { return datai[5]; }
			set { datai[5] = value; }
		}
		#endregion

		internal AnimBlock2() 
		{
			datai = new uint[6];	
			ab3 = new AnimBlock3[0];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();			
			datai[2] = reader.ReadUInt32(); // unknown Data
			datai[3] = reader.ReadUInt32();
			datai[4] = reader.ReadUInt32(); // contains the part3 count and unknown data
			datai[5] = reader.ReadUInt32();			
		}	
	
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart3Data(System.IO.BinaryReader reader)
		{			
			ab3 = new AnimBlock3[GetPart3Count()];
			for (int i=0; i<ab3.Length; i++) 
			{
				ab3[i] = new AnimBlock3();
				ab3[i].UnserializeData(reader);
			}
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializePart3AddonData(System.IO.BinaryReader reader)
		{
			for (int i=0; i<ab3.Length; i++) ab3[i].UnserializeAddonData(reader);	
		}

		/// <summary>
		/// Returns the Number of Items for Part 3 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart3Count()
		{
			//using highest 3-Bits xxx00000000000000000000000000000
			return ((int)datai[4] >> 0x1D) & 0x7;
		}
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock3
	{
		#region Attributes
		uint[] datai;
		[DescriptionAttribute("Lower 16 Bits contain the count, Bit 16-18 contain the size of the assigned AddonData.")]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}		

		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}	
		short[] datas;
		public short[] AddonData 
		{
			get { return datas; }
		}
		#endregion

		internal AnimBlock3() 
		{
			datai = new uint[2];
			datas = new short[0];
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();	
		}	

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal void UnserializeAddonData(System.IO.BinaryReader reader)
		{
			datas = new short[GetCount()];
			for (int i=0; i<datas.Length; i++) datas[i] = reader.ReadInt16();
		}	
	
		public override string ToString()
		{
			return Helper.HexString(datai[0]) + " ("+datas.Length.ToString()+")";
		}

		/// <summary>
		/// Return the number of Additional Word Values
		/// </summary>
		/// <returns>number of additional words to read</returns>
		int GetCount()
		{	
			short dum = (short)((int)datai[0] >> 0x10);
			short count = (short)(datai[0] & 0xffff);
			int size = dum&3;

			if (size==0) size=1;
			else if (size==1) size=3;
			else size=4;
						
			return (count * size);
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
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}	
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
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
		/// Returns the Number of Items for Part 5 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart5Count()
		{
			return (data[2]);
		}
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock5
	{		
		#region Attributes
		uint[] datai;
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]				
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
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
			if (reader.BaseStream.Length-pos < 4+4+data.Length) return;

			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();	
			data = reader.ReadBytes(data.Length);

			if (datai[0]!=0X11BA05F0 || datai[1]!=0X11BA05F0) 
			{	
				reader.BaseStream.Seek(pos, System.IO.SeekOrigin.Begin);
				return;
			}
		}		
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock6 : AnimBlock
	{		
		#region Attributes
		uint[] datai;	
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]						
		public uint Unknown1 
		{
			get { return datai[0]; }
			set { datai[0] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0X11BA05F0)]						
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
	}

}
