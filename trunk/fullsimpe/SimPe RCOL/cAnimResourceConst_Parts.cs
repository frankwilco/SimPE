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
	/// What type of Information is stored in a Frame
	/// </summary>
	public enum FrameType  :byte
	{
		/// <summary>
		/// Translations
		/// </summary>
		Translation = 0x0,
		/// <summary>
		/// Rotations
		/// </summary>
		Rotation = 0xC
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
		Rcol parent;
		public Rcol Parent
		{
			get { return parent; }
		}
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
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]		
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]		
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
		public short AnimatedBoneCount 
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

		internal AnimBlock1(Rcol parent) 
		{
			datai = new uint[6];
			datas = new short[4];
			ab2 = new AnimBlock2[0];
			ab4 = new AnimBlock4[0];
			this.parent = parent;
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

		protected GenericRcol FindDefiningCRES(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg)
		{
			GenericRcol rcol = new GenericRcol();
			rcol.ProcessData(pfd, pkg);

			ResourceNode rn = (ResourceNode)rcol.Blocks[0];
			foreach (int i in rn.ChildBlocks) 
			{
				SimPe.Interfaces.Scenegraph.ICresChildren icc = rn.GetBlock(i);
				
				if (icc.StoredTransformNode!=null) 				
					if (icc.StoredTransformNode.ObjectGraphNode.FileName == this.Name) return rcol;				
			}
			return null;
		}

		public GenericRcol FindDefiningCRES()
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = Parent.Package.FindFiles(Data.MetaData.CRES);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				GenericRcol rcol = FindDefiningCRES(pfd, Parent.Package);
				if (rcol!=null) 
					return rcol;
			} 

			FileTable.FileIndex.Load();
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = FileTable.FileIndex.FindFile(Data.MetaData.CRES, true);
			foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item in items)
			{
				GenericRcol rcol = FindDefiningCRES(item.FileDescriptor, item.Package);
				if (rcol!=null) 
					return rcol;
			} 
			return null;
		}

		public GenericRcol FindUsedGMDC(GenericRcol cres)
		{
			if (cres==null) return null;

			SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem item = cres.FindReferencedType(Data.MetaData.SHPE);
			if (item!=null)
			{
				GenericRcol rcol = new GenericRcol();
				rcol.ProcessData(item);

				item = rcol.FindReferencedType(Data.MetaData.GMND);
				if (item!=null)
				{
					rcol.ProcessData(item);
					item = rcol.FindReferencedType(Data.MetaData.GMDC);
					if (item!=null)
					{
						rcol.ProcessData(item);
						return rcol;
					}
				}
			}
			return null;
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
		

		internal int MaxPart3FrameCount 
		{
			get {  
				int ct=0;
				foreach (AnimBlock3 ab in ab3)
					ct = Math.Max(ct, ab.AddonTokenCount);

				return ct;
			}
		}

		[DescriptionAttribute("Number of loaded AnimBlock3 Items"), CategoryAttribute("Information")]
		public int FrameCount
		{
			get {return Frames.Length; }
		}

		[DescriptionAttribute("Available Frames"), CategoryAttribute("Information")]
		public AnimationFrame[] Frames
		{
			get 
			{  
				ArrayList tclist = new ArrayList();
				Hashtable ht = new Hashtable();
				ArrayList list = new ArrayList();

				
				//get a List of all TimeCodes
				for (int i=0; i<MaxPart3FrameCount; i++)														
					foreach (AnimBlock3 ab in ab3)	
						foreach (int tc in ab.TimeCodes)
							if (!tclist.Contains((short)tc)) 
							{
								tclist.Add((short)tc);
								ht[(short)tc] = new AnimationFrame((short)tc, this.TransformationType);								
							}

				tclist.Sort();				
				for(int part=0; part<ab3.Length; part++)
				{
					AnimBlock3 ab = ab3[part];
					for (int i=0; i<ab.AddonTokenCount; i++)
					{
						AnimationFrame af = (AnimationFrame)ht[ab.GetTimeCode(i)];
						if (part==0) af.SetXBlock(ab, (short)i);
						else if (part==1) af.SetYBlock(ab, (short)i);
						else if (part==2) af.SetZBlock(ab, (short)i);						
					}				
				}

				//build ordered List
				foreach (short tc in tclist) list.Add(ht[tc]);
				

				AnimationFrame[] afs = new AnimationFrame[list.Count];
				list.CopyTo(afs);
				return afs;
			}
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
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}

		public string Unknown3Binary
		{
			get 
			{ 
				string s = Convert.ToString(Unknown3, 2); 
				s = Helper.MinStrLength(s, 32);
				int p=s.Length-4;
				while (p>=0) 
				{
					s = s.Insert(p, " ");
					p-=4;
				}
				return s.Trim();;
			}
			
		}

		public string Unknown3Hex
		{
			get { return "0x"+Helper.HexString(Unknown3); }
			
		}

		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]		
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}

		[DescriptionAttribute("What kind of Transformation is performed."), CategoryAttribute("Information")]
		public FrameType TransformationType
		{
			get 
			{
				uint i = Unknown5 & 0x00F00000;
				i = i >> 20;
				return (FrameType)((byte)i);
			}
			set 
			{
				uint i = (uint)value;
				i = i << 20;
				i = i & 0x00F00000;
				Unknown5 = (uint)((Unknown5 & 0xFF0FFFFF) | i);
			}
		}

		[DescriptionAttribute("Highest 3 Bits (Bit 31-29) contain the Number of assigned AnimBlock3 Items, Bits 23-16 describe the Transformation Type (0=Translation, C=Rotation).")]
		public uint Unknown5 
		{
			get { return datai[4]; }
			set { datai[4] = value; }
		}

		[DescriptionAttribute("Highest 3 Bits contain the Number of assigned AnimBlock3 Items")]
		public string Unknown5Binary
		{
			get { 
				string s = Convert.ToString(Unknown5, 2); 
				s = Helper.MinStrLength(s, 32);
				int p=s.Length-4;
				while (p>=0) 
				{
					s = s.Insert(p, " ");
					p-=4;
				}
				return s.Trim();
			}
			
		}

		[DescriptionAttribute("Highest 3 Bits contain the Number of assigned AnimBlock3 Items")]
		public string Unknown5Hex
		{
			get { return "0x"+Helper.HexString(Unknown5); }
			
		}
		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
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

		[DescriptionAttribute("Reserved"), CategoryAttribute("Reserved"), DefaultValueAttribute(0x11BA05F0)]				
		public uint Unknown2 
		{
			get { return datai[1]; }
			set { datai[1] = value; }
		}	
		short[] datas;
		[DescriptionAttribute("Contains the Values of this Node"), CategoryAttribute("Data"), DefaultValueAttribute(0x11BA05F0)]	
		public short[] AddonData 
		{
			get { return datas; }
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="data"></param>
		/// <exception cref="Exception">Thrown when the Length of the passed Array does not mathc the <see cref="AddonTokenSize"/>.</exception>
		public void AddData(short[] data)
		{
			if (data.Length!=this.AddonTokenSize) throw new Exception("Invalid Data Size");

			foreach (short s in data)			
				datas = (short[])Helper.Add(datas, s);
			
		}
		

		[DescriptionAttribute("AddonData interpreted as Float"), CategoryAttribute("Data"), DefaultValueAttribute(0x11BA05F0)]	
		public float[] AddonDataFloat
		{
			get { 
				float[] f = new float[datas.Length];
				for (int i=0; i<f.Length; i++) 
				{
					f[i] = AnimationFrame.GetCompressedFloat(datas[i]);
				}
				return f; 
			}
		}
		

		byte type;
		[DescriptionAttribute("Propbably some sort of Type Identifier"), CategoryAttribute("Information")]				
		public AnimationTokenType AddonTokenType 
		{
			get { return (AnimationTokenType)type; }
			set { type = (byte)value; }
		}

		[DescriptionAttribute("The First TimeCode for this Transformation Element"), CategoryAttribute("Information")]				
		public short FirstTimeCode 
		{
			get { 
				if (datas.Length>0) return datas[0]; 
				else return 0;
			}
			
		}

		[DescriptionAttribute("The First TimeCode for this Transformation Element"), CategoryAttribute("Information")]				
		public IntArrayList TimeCodes
		{
			get 
			{ 
				IntArrayList list = new IntArrayList();
				int o = 0;
				while (o<datas.Length)
				{
					list.Add(datas[o]);
					o += this.AddonTokenSize;
				}

				return list;
			}
			
		}

		/// <summary>
		/// Returns the Data for the indexth Frame
		/// </summary>
		/// <param name="index">The Frame Index</param>
		/// <param name="part">The In this Frame</param>
		/// <returns></returns>
		public short GetPart(int index, int part)
		{
			int o = index*this.AddonTokenSize+part;
			if (o<datas.Length) return datas[o];
			return 0;
		}

		/// <summary>
		/// Sets the Data for the indexth Frame
		/// </summary>
		/// <param name="index">The Frame Index</param>
		/// <param name="part">The In this Frame</param>
		/// <returns></returns>
		public void SetPart(int index, int part, short val)
		{
			int o = index*this.AddonTokenSize+part;
			if (o<datas.Length) datas[o] = val;
		}

		/// <summary>
		/// Returns the TimeCode for the indexth Frame
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public short GetTimeCode(int index)
		{
			return GetPart(index, 0);
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
			int i = 0;
			for (i=0; i<datas.Length; i++) writer.Write(datas[i]);			
		}
	
		public override string ToString()
		{
			string n = this.AddonTokenType.ToString();
			if (n.Length>3) n = n.Substring(0, 3);
			return n + ": " + Helper.HexString(datai[0]) + " ("+datas.Length.ToString()+")";
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

			if (datai[0]!=0x11BA05F0 || datai[1]!=0x11BA05F0) 
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


	/// <summary>
	/// Assembles the Data Read from the ANIM Resource in a Frame
	/// </summary>
	internal class AnimationFrameAssembler
	{
		AnimBlock2 baseblock;
		int nr;
		public AnimationFrameAssembler(AnimBlock2 baseblock, int number)
		{
			this.baseblock = baseblock;
			nr = number;
		}

		short GetFrameAddonData(int part, int subpart)
		{
			
			if (baseblock.Part3.Length>=part) 
			{
				int mnr = nr;
				/*if (subpart>0 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.UniformScale) return -1;
				if (subpart>2 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.Translation) return -1;
				if (subpart>3 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.Rotation) return -1;*/
				int o = mnr*baseblock.Part3[part].AddonTokenSize+subpart;
				while (o>=baseblock.Part3[part].AddonData.Length)
				{
					mnr--;
					o = mnr*baseblock.Part3[part].AddonTokenSize+subpart;
				}
				
				if (o>=0) return baseblock.Part3[part].AddonData[o];
				return -1;
			}
			else 
				return -2;
		}

		float GetFloatFrameAddonData(int part, int subpart)
		{
			
			if (baseblock.Part3.Length>=part) 
			{
				int mnr = nr;
				/*if (subpart>0 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.UniformScale) return -1;
				if (subpart>2 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.Translation) return -1;
				if (subpart>3 && baseblock.Part3[part].AddonTokenType == AnimationTokenType.Rotation) return -1;*/
				int o = mnr*baseblock.Part3[part].AddonTokenSize+subpart;
				while (o>=baseblock.Part3[part].AddonDataFloat.Length)
				{
					mnr--;
					o = mnr*baseblock.Part3[part].AddonTokenSize+subpart;
				}
				
				if (o>=0) return baseblock.Part3[part].AddonDataFloat[o];
				return -1;
			}
			else 
				return -2;
		}

		void SetFrameAddonData(int part, int subpart, short val)
		{
			if (baseblock.Part3.Length>=part)
				baseblock.Part3[part].AddonData[nr*baseblock.Part3[1].AddonTokenSize+subpart] = val;			
		}

		[DescriptionAttribute("The X Value for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public short X
		{
			get 
			{
				return GetFrameAddonData(0, 1);
			}
			set
			{
				SetFrameAddonData(0, 1, value);
			}
		}

		[DescriptionAttribute("The Y Value for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public short Y
		{
			get 
			{
				return GetFrameAddonData(1, 1);
			}
			set
			{
				SetFrameAddonData(1, 1, value);
			}
		}

		[DescriptionAttribute("The Z Value for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public short Z
		{
			get 
			{
				return GetFrameAddonData(2, 1);
			}
			set
			{
				SetFrameAddonData(2, 1, value);
			}
		}	
	
		[DescriptionAttribute("The X Value (as Floating Point) for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public float Float_X
		{
			get 
			{
				return GetFloatFrameAddonData(0, 1);
			}
		}

		[DescriptionAttribute("The Y Value (as Floating Point) for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public float Float_Y
		{
			get 
			{
				return GetFloatFrameAddonData(1, 1);
			}
		}

		[DescriptionAttribute("The Z Value (as Floating Point) for this Transformation"), CategoryAttribute("Transformation"), DefaultValueAttribute(0)]
		public float Float_Z
		{
			get 
			{
				return GetFloatFrameAddonData(2, 1);
			}
		}		

		[DescriptionAttribute("The TimeCode the X Transformation should be finished"), CategoryAttribute("Time"), DefaultValueAttribute(0)]
		public short TimeCodeX
		{
			get 
			{
				return GetFrameAddonData(0, 0);
			}
			set
			{
				SetFrameAddonData(0, 0, value);
			}
		}

		[DescriptionAttribute("The TimeCode the Y Transformation should be finished"), CategoryAttribute("Time"), DefaultValueAttribute(0)]
		public short TimeCodeY
		{
			get 
			{
				return GetFrameAddonData(1, 0);
			}
			set
			{
				SetFrameAddonData(1, 0, value);
			}
		}

		[DescriptionAttribute("The TimeCode the Z Transformation should be finished"), CategoryAttribute("Time"), DefaultValueAttribute(0)]
		public short TimeCodeZ
		{
			get 
			{
				return GetFrameAddonData(2, 0);
			}
			set
			{
				SetFrameAddonData(2, 0, value);
			}
		}	



		public short Unknown1_X
		{
			get 
			{
				return GetFrameAddonData(0, 2);
			}
			set
			{
				SetFrameAddonData(0, 2, value);
			}
		}

		public short Unknown1_Y
		{
			get 
			{
				return GetFrameAddonData(1, 2);
			}
			set
			{
				SetFrameAddonData(1, 2, value);
			}
		}

		public short Unknown1_Z
		{
			get 
			{
				return GetFrameAddonData(2, 2);
			}
			set
			{
				SetFrameAddonData(2, 2, value);
			}
		}	

		public short Unknown2_X
		{
			get 
			{
				return GetFrameAddonData(0, 3);
			}
			set
			{
				SetFrameAddonData(0, 3, value);
			}
		}

		public short Unknown2_Y
		{
			get 
			{
				return GetFrameAddonData(1, 3);
			}
			set
			{
				SetFrameAddonData(1, 3, value);
			}
		}

		public short Unknown2_Z
		{
			get 
			{
				return GetFrameAddonData(2, 3);
			}
			set
			{
				SetFrameAddonData(2, 3, value);
			}
		}	
	
		public override string ToString()
		{
			return nr.ToString();
		}

		/*[DescriptionAttribute("AddonData interpreted as Quaternions (only if Rotation!)"), CategoryAttribute("Data"), DefaultValueAttribute(0x11BA05F0)]	
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
		}*/

		[DescriptionAttribute("Data interpreted as Vector"), CategoryAttribute("Data"), DefaultValueAttribute(0x11BA05F0)]	
		public Vector3f Vector
		{
			get 
			{ 
				return new Vector3f(this.Float_X, this.Float_Y, this.Float_Z);											
			}
		}

		[DescriptionAttribute("What kind of Transformation is performed."), CategoryAttribute("Information")]
		public FrameType Type
		{
			get 
			{
				return baseblock.TransformationType;
			}
		}
	}

	/// <summary>
	/// Assembles the Data Read from the ANIM Resource in a Frame
	/// </summary>
	public class AnimationFrame
	{
		const float SCALE = 8;
		public static float GetCompressedFloat(short v)
		{
			return ((float)v/(float)short.MaxValue) * SCALE;
		}

		public static short FromCompressedFloat(float v)
		{
			return (short)((v * (float)short.MaxValue) / SCALE);
		}

		AnimBlock3 xblock, yblock, zblock;
		short tc, xnr, ynr, znr;
		public AnimationFrame(short tc, FrameType tp)
		{
			this.tc = tc;			
			this.tp = tp;
			xblock = null;
			yblock = null;
			zblock = null;
		}
		
		public void SetXBlock(AnimBlock3 bl, short nr)
		{
			xnr = nr;
			xblock = bl;
		}

		public void SetYBlock(AnimBlock3 bl, short nr)
		{
			ynr = nr;
			yblock = bl;
		}

		public void SetZBlock(AnimBlock3 bl, short nr)
		{
			znr = nr;
			zblock = bl;
		}

		short GetFrameAddonData(int part, int subpart)
		{
			AnimBlock3 b = null;
			int nr = 0;
			if (part==1) { b=yblock; nr = ynr; }
			else if (part==2) { b=zblock; nr = znr; }
			else if (part==0) {	b=xblock; nr = xnr;	}

			if (b==null) return -1;
			return b.GetPart(nr, subpart);
		}		

		void SetFrameAddonData(int part, int subpart, short val)
		{
			AnimBlock3 b = null;
			int nr = 0;
			if (part==1) { b=yblock; nr = ynr; }
			else if (part==2) { b=zblock; nr = znr; }
			else if (part==0) {	b=xblock; nr = xnr;	}

			if (b==null) return;
			b.SetPart(nr, subpart, val);
		}

		[DescriptionAttribute("The X Value for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public short X
		{
			get 
			{
				return GetFrameAddonData(0, 1);
			}
			set
			{
				SetFrameAddonData(0, 1, value);
			}
		}

		[DescriptionAttribute("The Y Value for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public short Y
		{
			get 
			{
				return GetFrameAddonData(1, 1);
			}
			set
			{
				SetFrameAddonData(1, 1, value);
			}
		}

		[DescriptionAttribute("The Z Value for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public short Z
		{
			get 
			{
				return GetFrameAddonData(2, 1);
			}
			set
			{
				SetFrameAddonData(2, 1, value);
			}
		}	
	
		[DescriptionAttribute("The X Value (as Floating Point) for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public float Float_X
		{
			get { return GetCompressedFloat(X);	}
			set { X = FromCompressedFloat(value); }
		}

		[DescriptionAttribute("The Y Value (as Floating Point) for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public float Float_Y
		{
			get { return GetCompressedFloat(Y);	}
			set { Y = FromCompressedFloat(value); }
		}

		[DescriptionAttribute("The Z Value (as Floating Point) for this Transformation"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public float Float_Z
		{
			get { return GetCompressedFloat(Z);	}
			set { Z = FromCompressedFloat(value); }
		}		

		[DescriptionAttribute("The TimeCode the X Transformation should be finished"), CategoryAttribute("Data"), DefaultValueAttribute(0)]
		public short TimeCode
		{
			get 
			{
				return tc;
			}
			set
			{
				if (tc!=value) 
				{
					tc = value;
					if (xblock!=null) xblock.SetPart(xnr, 0, value);
					if (yblock!=null) yblock.SetPart(ynr, 0, value);
					if (zblock!=null) zblock.SetPart(znr, 0, value);
				}
			}
		}
		



		public short Unknown1_X
		{
			get 
			{
				return GetFrameAddonData(0, 2);
			}
			set
			{
				SetFrameAddonData(0, 2, value);
			}
		}

		public short Unknown1_Y
		{
			get 
			{
				return GetFrameAddonData(1, 2);
			}
			set
			{
				SetFrameAddonData(1, 2, value);
			}
		}

		public short Unknown1_Z
		{
			get 
			{
				return GetFrameAddonData(2, 2);
			}
			set
			{
				SetFrameAddonData(2, 2, value);
			}
		}	

		public short Unknown2_X
		{
			get 
			{
				return GetFrameAddonData(0, 3);
			}
			set
			{
				SetFrameAddonData(0, 3, value);
			}
		}

		public short Unknown2_Y
		{
			get 
			{
				return GetFrameAddonData(1, 3);
			}
			set
			{
				SetFrameAddonData(1, 3, value);
			}
		}

		public short Unknown2_Z
		{
			get 
			{
				return GetFrameAddonData(2, 3);
			}
			set
			{
				SetFrameAddonData(2, 3, value);
			}
		}	
	
		public override string ToString()
		{
			return tc.ToString();
		}

		/*[DescriptionAttribute("AddonData interpreted as Quaternions (only if Rotation!)"), CategoryAttribute("Data"), DefaultValueAttribute(0x11BA05F0)]	
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
		}*/

		[DescriptionAttribute("Data interpreted as Vector"), CategoryAttribute("Information"), DefaultValueAttribute(0x11BA05F0)]	
		public Vector3f Vector
		{
			get 
			{ 
				return new Vector3f(this.Float_X, this.Float_Y, this.Float_Z);											
			}
		}

		FrameType tp;
		[DescriptionAttribute("What kind of Transformation is performed. You can changes this in the Parent Node!"), CategoryAttribute("Information")]
		public FrameType Type
		{
			get 
			{
				return tp;
			}
		}
	}
}
