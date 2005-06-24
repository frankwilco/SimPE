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

namespace SimPe.Plugin
{
	/// <summary>
	/// What type of Information is stored in the Token
	/// </summary>
	public enum AnimationTokenType  :byte
	{
		/// <summary>
		/// Uniform Scaling factors
		/// </summary>
		UniformScale = 0,
		/// <summary>
		/// Translations
		/// </summary>
		Translation = 1,
		/// <summary>
		/// Rotations
		/// </summary>
		Rotation = 2
	}

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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			writer.Write(datai[0]);
			writer.Write(datai[1]);

			writer.Write(datas[0]);
			writer.Write(datas[1]);
			writer.Write(datas[2]);
			writer.Write(datas[3]);

			writer.Write(datai[2]);
			writer.Write(datai[3]);
			writer.Write(datai[4]);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart2Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab2.Length; i++) ab2[i].SerializeData(writer);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal int SerializePart2Name(System.IO.BinaryWriter writer)
		{
			int len = 0;
			for (int i=0; i<ab2.Length; i++) len += ab2[i].SerializeName(writer);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart3Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab2.Length; i++) ab2[i].SerializePart3Data(writer);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart3AddonData(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab2.Length; i++) ab2[i].SerializePart3AddonData(writer);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart4Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab4.Length; i++) ab4[i].SerializeData(writer);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart5Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab4.Length; i++) ab4[i].SerializePart5Data(writer);
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
		/// Set the count for Part 5 Items
		/// </summary>
		/// <param name="ct">The New Count</param>
		void SetPart2Count(int ct) 
		{
			datas[1] = (short)ct;
		}
		
		/// <summary>
		/// Returns the Number of Items for Part 4 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart4Count()
		{
			return (datas[2] & 0x3f);
		}

		/// <summary>
		/// Set the count for Part 5 Items
		/// </summary>
		/// <param name="ct">The New Count</param>
		void SetPart4Count(int ct) 
		{
			if (ct>0x3f) ct = 0x3f;
			ct = ct & 0x3f;

			datas[2] = (short)((int)datas[2] & 0x0000FFC0);
			datas[2] = (short)((ushort)datas[2] | (ushort)ct);
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

		[DescriptionAttribute("Unknown additional Data"), CategoryAttribute("Information")]
		public string Unknown7 
		{
			get { return Helper.HexString((int)datai[4] & 0x1fffffff); }
		}
		[DescriptionAttribute("Unknown7 as Float"), CategoryAttribute("Information")]
		public float Unknown7Float
		{
			get { return BitConverter.ToSingle(BitConverter.GetBytes((int)datai[4] & 0x1fffffff), 0); }
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			this.SetPart3Count(ab3.Length);

			writer.Write(datai[0]);
			writer.Write(datai[1]);
			writer.Write(datai[2]);
			writer.Write(datai[3]);
			writer.Write(datai[4]);
			writer.Write(datai[5]);
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart3Data(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab3.Length; i++) ab3[i].SerializeData(writer);			
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializePart3AddonData(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<ab3.Length; i++) ab3[i].SerializeAddonData(writer);	
		}


		/// <summary>
		/// Returns the Number of Items for Part 3 assigned to this Object
		/// </summary>
		/// <returns>Number of Items</returns>
		int GetPart3Count()
		{
			//using highest 3-Bits xxx0 0000 0000 0000 0000 0000 0000 0000
			return ((int)datai[4] >> 0x1D) & 0x7;
		}

		/// <summary>
		/// Set the count for Part 5 Items
		/// </summary>
		/// <param name="ct">The New Count</param>
		void SetPart3Count(int ct) 
		{
			if (ct>7) ct=7;
			ct = ct & 0x00000007;
			ct = ct << 0x1D;
			datai[4] = datai[4] & 0x1FFFFFFF;

			datai[4] = (uint)((ulong)datai[4] | (uint)ct);
		}
	}


	/// <summary>
	/// Data is unknown
	/// </summary>
	public class AnimBlock3
	{
		#region Attributes
		uint[] datai;
		[DescriptionAttribute("Lower 16 Bits contain the count, Bit 16-18 contain the type of the assigned AddonData.")]				
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
		[DescriptionAttribute("Contains the Values of this Node"), CategoryAttribute("Data"), DefaultValueAttribute(0X11BA05F0)]	
		public short[] AddonData 
		{
			get { return datas; }
		}

		[DescriptionAttribute("AddonData interpreted as Float"), CategoryAttribute("Data"), DefaultValueAttribute(0X11BA05F0)]	
		public float[] AddonDataFloat
		{
			get { 
				float[] f = new float[datas.Length];
				for (int i=0; i<f.Length; i++) 
				{
					f[i] = (float)datas[i]/(float)short.MaxValue;
				}
				return f; 
			}
		}

		[DescriptionAttribute("AddonData interpreted as Quaternions (only if Rotation!)"), CategoryAttribute("Data"), DefaultValueAttribute(0X11BA05F0)]	
		public Quaternions AddonDataQuaternions
		{
			get 
			{ 
				Quaternions qs = new Quaternions();
				if (type==2) 
				{
					float[] f = AddonDataFloat;
					for (int i=0; i<f.Length; i+=4) 
					{
						Quaternion q = new Quaternion(SimPe.Geometry.QuaternionParameterType.ImaginaryReal, f[i+0], f[i+1], f[i+2], f[i+3]);						
						//q.MakeUnitQuaternion();
						qs.Add(q);
					}
				}
				return qs; 
			}
		}

		[DescriptionAttribute("AddonData interpreted as Vectors (only if Translation!)"), CategoryAttribute("Data"), DefaultValueAttribute(0X11BA05F0)]	
		public Vectors3f AddonDataVectors
		{
			get 
			{ 
				Vectors3f vs = new Vectors3f();
				if (type==1) 
				{
					float[] f = AddonDataFloat;
					for (int i=0; i<f.Length; i+=3) 
					{
						Vector3f v = new Vector3f(f[i+0], f[i+1], f[i+2]);						
						vs.Add(v);
					}
				}
				return vs; 
			}
		}

		byte type;
		[DescriptionAttribute("Propbably some sort of Type Identifier"), CategoryAttribute("Information")]				
		public AnimationTokenType AddonTokenType 
		{
			get { return (AnimationTokenType)type; }
		}

		[DescriptionAttribute("Size (in Bytes) of one Addon Token"), CategoryAttribute("Information")]				
		public byte AddonTokenSize 
		{
			get 
			{
				byte size = 0;

				if (type==0) size=1;
				else if (type==1) size=3;
				else size=4;

				return size;
			}
		}

		[DescriptionAttribute("Remaining Information stored in Unknown1"), CategoryAttribute("Information")]				
		public uint AddonTokenUnknown 
		{
			get 
			{				
				return Unknown1 >> 0x13;
			}
		}

		[DescriptionAttribute("Number of Tokens stored in the Addon Data"), CategoryAttribute("Information")]				
		public int AddonTokenCount 
		{
			get { return this.datas.Length / AddonTokenSize; }
		}
		#endregion

		float ReadFloat(System.IO.BinaryReader reader) 
		{
			byte[] tmp = reader.ReadBytes(2);
			byte[] res = new byte[4];
			res[0] = tmp[1];
			res[1] = tmp[0];
			res[2] = 0;
			res[3] = 0;
			float f = BitConverter.ToSingle(res, 0);

			return f;
		}
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
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeData(System.IO.BinaryWriter writer)
		{
			this.SetCount(datas.Length);
			writer.Write(datai[0]);
			writer.Write(datai[1]);
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

		/// <summary>
		/// Serializes to a BinaryStream from the Attributes of this Instance
		/// </summary>
		/// <param name="writer">The Stream that receives the Data</param>
		internal void SerializeAddonData(System.IO.BinaryWriter writer)
		{
			for (int i=0; i<datas.Length; i++) writer.Write(datas[i]);
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
			type = (byte)(dum&3);
			int size = AddonTokenSize;			
						
			return (count * size);
		}

		/// <summary>
		/// Set the count for Part 5 Items
		/// </summary>
		/// <param name="ct">The New Count</param>
		void SetCount(int ct) 
		{
			int size = AddonTokenSize;
			int count = ct / size;

			count = (type << 0x10) | count;

			datai[0] = (uint)(((ulong)datai[0] & 0xFFFC0000) | ((ulong)count & 0x0007FFFF));		
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
			for (int i=0; i<ab5.Length; i++) ab5[i] = new AnimBlock5();				
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
