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
	public class AnimBlock 
	{
		protected string name;
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

	public class AnimBlock1 : AnimBlock
	{
		uint[] datai;		
		short[] datas;
		#region Attributes
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
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}
		public uint Unknown5 
		{
			get { return datai[4]; }
			set { datai[4] = value; }
		}
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
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal int UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();

			datas[0] = reader.ReadInt16();
			datas[1] = reader.ReadInt16();
			datas[2] = reader.ReadInt16();
			datas[3] = reader.ReadInt16();			

			datai[2] = reader.ReadUInt32();
			datai[3] = reader.ReadUInt32();
			datai[4] = reader.ReadUInt32();

			return datas[1];
		}		
	}

	public class AnimBlock2 : AnimBlock
	{
		uint[] datai;
		#region Attributes
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
		public uint Unknown3 
		{
			get { return datai[2]; }
			set { datai[2] = value; }
		}
		public uint Unknown4 
		{
			get { return datai[3]; }
			set { datai[3] = value; }
		}
		public uint Unknown5 
		{
			get { return datai[4]; }
			set { datai[4] = value; }
		}
		public uint Unknown6 
		{
			get { return datai[5]; }
			set { datai[5] = value; }
		}
		#endregion

		internal AnimBlock2() 
		{
			datai = new uint[6];			
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		internal int UnserializeData(System.IO.BinaryReader reader)
		{
			datai[0] = reader.ReadUInt32();
			datai[1] = reader.ReadUInt32();			
			datai[2] = reader.ReadUInt32();
			datai[3] = reader.ReadUInt32();
			datai[4] = reader.ReadUInt32();
			datai[5] = reader.ReadUInt32();

			//returning highest 3-Bits xxx00000000000000000000000000000
			return ((int)datai[4] >> 0x1D) & 0x7;
		}		
	}

	public class AnimBlock3
	{
		uint[] datai;
		#region Attributes
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
		#endregion

		internal AnimBlock3() 
		{
			datai = new uint[2];			
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
	
		public override string ToString()
		{
			return Helper.HexString(datai[0]);
		}

	}

	/// <summary>
	/// Zusammenfassung für cAnimResourceConst.
	/// </summary>
	public class AnimResourceConst
		: AbstractRcolBlock
	{
		#region Attributes

		byte[] data;
		public byte[] Data 
		{
			get { return data; }
			set { data = value; }
		}

		short unknown1;
		byte[] headerb;
		uint[] headeri;
		float[] headerf;

		string objname;
		string objmod;

		AnimBlock1[] ab1;
		AnimBlock2[] ab2;
		AnimBlock3[] ab3;
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public AnimResourceConst(Interfaces.IProviderRegistry provider, Rcol parent) : base(provider, parent)
		{
			sgres = new SGResource(provider, null);
			data = new byte[0];
			BlockID = 0xfb00791e;

			headerb = new byte[6];
			headeri = new uint[4];
			headerf = new float[9];

			objname = "";
			objmod = "";

			ab1 = new AnimBlock1[0];
			ab2 = new AnimBlock2[0];
			ab3 = new AnimBlock3[0];
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();

			string name = reader.ReadString();
			uint myid = reader.ReadUInt32();		
			sgres.Unserialize(reader);
			sgres.BlockID = myid;

			int len = reader.ReadInt32();
			data = reader.ReadBytes(len);

			//now read the Data
			System.IO.BinaryReader br = new System.IO.BinaryReader(new System.IO.MemoryStream(data));
			UnserializeData(br);
		}

		static void AlignReader(System.IO.BinaryReader reader, int ct)
		{
			int add = 0;
			if (ct%2==0) //even
			{
				add = (ct%4);
			} 
			else //uneven
			{
				add = ct%2;
				if (((add+ct)%4)==0) add += 2;
			}
			
			while (add-->0) reader.ReadByte();
		}

		public void UnserializeData(System.IO.BinaryReader reader)
		{
			unknown1 = reader.ReadInt16();
			short ct1 = reader.ReadInt16();
			short ct2 = reader.ReadInt16();

			headerb = reader.ReadBytes(headerb.Length);
			for (int i=0;i<headeri.Length; i++) headeri[i] = reader.ReadUInt32();
			for (int i=0;i<headerf.Length; i++) headerf[i] = reader.ReadUInt32();
			
			objname = Helper.ToString(reader.ReadBytes(headerb[5]));
			reader.ReadByte(); //read the terminating 0
			objmod = Helper.ToString(reader.ReadBytes(headerb[0]));
			reader.ReadByte(); //read the terminating 0
			//align reader
			int ct = headerb[0] + headerb[5];
			AlignReader(reader, ct+2);
			
			//--- part1 ---
			ab1 = new AnimBlock1[ct1];
			int len = 0;
			int ct3 = 0;
			for (int i=0; i<ab1.Length; i++) 
			{
				ab1[i] = new AnimBlock1();
				ct3 += ab1[i].UnserializeData(reader);
			}
			for (int i=0; i<ab1.Length; i++) len += ab1[i].UnserializeName(reader);
			ab1[0].Unknown1 = (uint)len;
			ab1[0].Unknown2 = (uint)(len%4);
			ab1[0].Unknown3 = (uint)(len%2);
			AlignReader(reader, len);

			//--- part2 ---
			ab2 = new AnimBlock2[ct3];
			len = 0;
			int ct4 = 0;
			for (int i=0; i<ab2.Length; i++) 
			{
				ab2[i] = new AnimBlock2();
				ct4 += ab2[i].UnserializeData(reader);
			}
			for (int i=0; i<ab2.Length; i++) len += ab2[i].UnserializeName(reader);
			AlignReader(reader, len);

			//--- part3 ---
			ab3 = new AnimBlock3[ct4];
			for (int i=0; i<ab3.Length; i++) 
			{
				ab3[i] = new AnimBlock3();
				ab3[i].UnserializeData(reader);
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
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);

			writer.Write(sgres.BlockName);
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);

			writer.Write((int)data.Length);
			writer.Write(data);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tAnimResourceConst;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			form.tb_arc_ver.Text = "0x"+Helper.HexString(this.version);
#if DEBUG
			form.tb_arc_data.Text = "---Debugging Session, do not Save!!!---";
#else
			form.tb_arc_data.Text = Helper.BytesToHexList(this.data);
#endif

			form.tb_arc_lb1.Items.Clear();
			form.tb_arc_lb2.Items.Clear();

			foreach (AnimBlock1 ab in this.ab1) form.tb_arc_lb1.Items.Add(ab);
			foreach (AnimBlock2 ab in this.ab2) form.tb_arc_lb2.Items.Add(ab);
			foreach (AnimBlock3 ab in this.ab3) form.tb_arc_lb3.Items.Add(ab);
		}
	}
}
