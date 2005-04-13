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
	public class AnimBlock1 
	{
		uint[] datai;
		short[] datas;
		string name;

		internal AnimBlock1() 
		{
			datai = new uint[5];
			datas = new short[4];
			name = "";
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

			return name.Length;
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
			int add = (ct%4);
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
			objmod = Helper.ToString(reader.ReadBytes(headerb[0]));

			//align reader
			int ct = headerb[0] + headerb[5];
			AlignReader(reader, ct);
			
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
			AlignReader(reader, len);
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
			form.tb_arc_data.Text = Helper.BytesToHexList(this.data);
		}
	}
}
