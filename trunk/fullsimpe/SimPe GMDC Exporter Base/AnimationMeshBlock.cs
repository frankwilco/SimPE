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
	/// Data is unknown
	/// </summary>
	public class AnimationMeshBlock : AnimBlock
	{		
		#region Attributes
		Rcol parent;
		public Rcol Parent
		{
			get { return parent; }
		}

		public AnimResourceConst Animation
		{
			get 
			{
				return (AnimResourceConst)parent.Blocks[0];
			}
		}
		AnimationFrameBlock[] ab2;
		[BrowsableAttribute(false)]
		public AnimationFrameBlock[] Part2 
		{
			get { return ab2; }
			set { ab2 = value; }
		}
		[DescriptionAttribute("Number of loaded AnimationFrameBlock Items"), CategoryAttribute("Information")]
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

		[DescriptionAttribute("Number of assigned AnimationFrameBlock Items")]
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

		internal AnimationMeshBlock(Rcol parent) 
		{
			datai = new uint[6];
			datas = new short[4];
			ab2 = new AnimationFrameBlock[0];
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
			this.SetPart2Count(this.Part2Count);
			this.SetPart4Count(this.Part4Count);

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
			ab2 = new AnimationFrameBlock[GetPart2Count()];
			for (int i=0; i<ab2.Length; i++) 
			{
				ab2[i] = new AnimationFrameBlock();
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
				
				if (icc!=null)
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

		/// <summary>
		/// Returns the first transformation for the given name and type
		/// </summary>
		/// <param name="name"></param>
		/// <param name="type"></param>
		/// <returns>null or the matching Block</returns>
		public AnimationFrameBlock GetJointTransformation(string name, FrameType type)
		{
			foreach (AnimationFrameBlock ab in this.Part2)			
				if (ab.Name == name && ab.TransformationType == type && ab.AxisCount==3) 
					return ab;
			
			return null;
		}
	}

}
