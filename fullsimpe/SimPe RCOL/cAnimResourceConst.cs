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
	/// contains an Animation Ressource
	/// </summary>
	public class AnimResourceConst
		: AbstractRcolBlock
	{
		#region Attributes

		byte[] data;
		internal byte[] Data 
		{
			get { return data; }
			set { data = value; }
		}

		short unknown1;
		public short Unknown1 
		{
			get { return unknown1; }
		}
		
		public Ambertation.BaseChangeShort B_Unknown1
		{
			get { return new Ambertation.BaseChangeShort(unknown1); }
		}
		byte[] headerb;
		public byte[] HeaderBytes
		{
			get { return headerb; }
		}

		uint[] headeri;
		public uint[] HeaderInts 
		{
			get { return headeri; }
		}

		float[] headerf;		
		public float[] HeaderFloats 
		{
			get { return headerf; }
		}
		
		string objname;		
		public string ObjName 
		{
			get { return objname; }
		}
		string objmod;		
		public string ObjMod 
		{
			get { return objmod; }
		}

		AnimBlock1[] ab1;
		AnimBlock6[] ab6;
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
			ab6 = new AnimBlock6[0];
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

		/// <summary>
		/// Make sure the String Data is alligned
		/// </summary>
		/// <param name="reader">The reader you want to align</param>
		/// <param name="ct">Number of Characters that were read (including terminating 0)</param>
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
			for (int i=0;i<headerf.Length; i++) headerf[i] = reader.ReadSingle();
			
			objname = Helper.ToString(reader.ReadBytes(headerb[5]));
			reader.ReadByte(); //read the terminating 0
			objmod = Helper.ToString(reader.ReadBytes(headerb[0]));
			reader.ReadByte(); //read the terminating 0

			int ct = headerb[0] + headerb[5];
			AlignReader(reader, ct+2);
			
			//--- part1 ---
			ab1 = new AnimBlock1[ct1];
			int len = 0;	
			for (int i=0; i<ab1.Length; i++) 
			{
				ab1[i] = new AnimBlock1();
				ab1[i].UnserializeData(reader);
			}
			for (int i=0; i<ab1.Length; i++) len += ab1[i].UnserializeName(reader);
			AlignReader(reader, len);

			//--- part2 ---
			len = 0;
			for (int i=0; i<ab1.Length; i++) ab1[i].UnserializePart2Data(reader);
			for (int i=0; i<ab1.Length; i++) len += ab1[i].UnserializePart2Name(reader);						
			AlignReader(reader, len);

			//--- part3 ---
			for (int i=0; i<ab1.Length; i++) ab1[i].UnserializePart3Data(reader);
			for (int i=0; i<ab1.Length; i++) ab1[i].UnserializePart3AddonData(reader);

			//--- part4 ---
			for (int i=0; i<ab1.Length; i++) ab1[i].UnserializePart4Data(reader);
			
			//--- part5 ---
			for (int i=0; i<ab1.Length; i++) ab1[i].UnserializePart5Data(reader);

			//--- part6 ---
			ab6 = new AnimBlock6[ct2];
			len = 0;
			for (int i=0; i<ab6.Length; i++) 
			{
				ab6[i] = new AnimBlock6();
				ab6[i].UnserializeData(reader);
			}
			for (int i=0; i<ab6.Length; i++) len += ab6[i].UnserializeName(reader);	
		
			//data = reader.ReadBytes((int)(reader.BaseStream.Length - reader.BaseStream.Position));
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


		fAnimResourceConst form = null;
		[BrowsableAttribute(false)]
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fAnimResourceConst(); 
				return form.tAnimResourceConst;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fAnimResourceConst(); 
			
			form.tv.Nodes.Clear();
			System.Windows.Forms.TreeNode btn = new System.Windows.Forms.TreeNode("Header");
			btn.Tag = this;
			form.tv.Nodes.Add(btn);

			foreach (AnimBlock1 ab in this.ab1) 
			{
				System.Windows.Forms.TreeNode tn = new System.Windows.Forms.TreeNode(ab.ToString());
				tn.Tag = ab;
				form.tv.Nodes.Add(tn);
				
				foreach (AnimBlock2 ab2 in ab.Part2) 
				{
					System.Windows.Forms.TreeNode tn2 = new System.Windows.Forms.TreeNode(ab2.ToString());
					tn2.Tag = ab2;
					tn.Nodes.Add(tn2);
					foreach (AnimBlock3 ab3 in ab2.Part3) 
					{
						System.Windows.Forms.TreeNode tn3 = new System.Windows.Forms.TreeNode(ab3.ToString());
						tn3.Tag = ab3;
						tn2.Nodes.Add(tn3);
					}
				}

				foreach (AnimBlock4 ab4 in ab.Part4) 
				{
					System.Windows.Forms.TreeNode tn4 = new System.Windows.Forms.TreeNode(ab4.ToString());
					tn4.Tag = ab4;
					tn.Nodes.Add(tn4);
					foreach (AnimBlock5 ab5 in ab4.Part5) 
					{
						System.Windows.Forms.TreeNode tn5 = new System.Windows.Forms.TreeNode(ab5.ToString());
						tn5.Tag = ab5;
						tn4.Nodes.Add(tn5);
					}
				}
			}

			foreach (AnimBlock6 ab in this.ab6) 
			{
				System.Windows.Forms.TreeNode tn = new System.Windows.Forms.TreeNode(ab.ToString());
				tn.Tag = ab;
				form.tv.Nodes.Add(tn);
			}

			form.tb_arc_ver.Tag = true;
			form.tb_arc_ver.Text = "0x"+Helper.HexString(this.version);			
			form.tb_arc_ver.Tag = null;
		}
	}

}
