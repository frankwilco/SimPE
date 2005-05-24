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
	public class ShapeRefNodeItem_A 
	{
		public ShapeRefNodeItem_A () 
		{
			unknown1 = 0x101;
		}
		ushort unknown1;
		public ushort Unknown1 
		{
			get {return unknown1; }
			set {unknown1 = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get {return unknown2; }
			set {unknown2 = value; }
		}

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public void Unserialize(System.IO.BinaryReader reader)
		{
			unknown1 = reader.ReadUInt16();
			unknown2 = reader.ReadInt32();
		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(unknown1);
			writer.Write(unknown2);
		}

		public override string ToString()
		{
			return "0x"+Helper.HexString(unknown1)+" 0x"+Helper.HexString((uint)unknown2);
		}

	}

	public class ShapeRefNodeItem_B 
	{
		int unknown1;
		public int Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		string data;
		public string Name
		{
			get { return data; }
			set { data = value; }
		}

		public ShapeRefNodeItem_B()
		{
			data = "";
		}

		public override string ToString()
		{
			return "0x"+Helper.HexString((uint)unknown1)+": "+Name;
		}

	}
	/// <summary>
	/// Zusammenfassung für cShapeRefNode.
	/// </summary>
	public class ShapeRefNode
		: AbstractRcolBlock
	{
		#region Attributes
		RenderableNode rn;
		BoundedNode bn;
		TransformNode tn;

		short unknown1;
		public short Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		int unknown3;
		public int Unknown3 
		{
			get { return unknown3; }
			set { unknown3 = value; }
		}

		byte unknown4;
		public byte Unknown4 
		{
			get { return unknown4; }
			set { unknown4 = value; }
		}

		ShapeRefNodeItem_A[] itemsa;
		public ShapeRefNodeItem_A[] ItemsA
		{
			get { return itemsa; }
			set { itemsa = value; }
		}

		int unknown5;
		public int Unknown5 
		{
			get { return unknown5; }
			set { unknown5 = value; }
		}

		ShapeRefNodeItem_B[] itemsb;
		public ShapeRefNodeItem_B[] ItemsB
		{
			get { return itemsb; }
			set { itemsb = value; }
		}

		byte[] data;
		public byte[] Data
		{
			get { return data; }
			set { data = value; }
		}

		int unknown6;
		public int Unknown6 
		{
			get { return unknown6; }
			set { unknown6 = value; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public ShapeRefNode(Rcol parent) : base(parent)
		{
			rn = new RenderableNode(null);
			bn = new BoundedNode(null);
			tn = new TransformNode(null);

			itemsa = new ShapeRefNodeItem_A[0];
			itemsb = new ShapeRefNodeItem_B[0];

			data = new byte[0];

			version = 0x15;
			unknown1 = 1;
			unknown2 = 1;
			unknown4 = 1;
			unknown5 = 0x10;
			unknown6 = -1;
			name = "Practical";
			BlockID = 0x65245517;
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
			rn.Unserialize(reader);
			rn.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
			bn.Unserialize(reader);
			bn.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
			tn.Unserialize(reader);
			tn.BlockID = myid;

			unknown1 = reader.ReadInt16();
			unknown2 = reader.ReadInt32();
			this.name = reader.ReadString();
			unknown3 = reader.ReadInt32();
			unknown4 = reader.ReadByte();

			itemsa = new ShapeRefNodeItem_A[reader.ReadUInt32()];
			for(int i=0; i<itemsa.Length; i++)
			{
				itemsa[i] = new ShapeRefNodeItem_A();
				itemsa[i].Unserialize(reader);
			}
			unknown5 = reader.ReadInt32();

			itemsb = new ShapeRefNodeItem_B[reader.ReadUInt32()];
			for(int i=0; i<itemsb.Length; i++)
			{
				itemsb[i] = new ShapeRefNodeItem_B();
				itemsb[i].Unknown1 = reader.ReadInt32();
			}

			int len = 0;
			if (version == 0x15) 
			{
				for(int i=0; i<itemsb.Length; i++)
				{
					itemsb[i].Name = reader.ReadString();
				}
			}

			len = reader.ReadInt32();
			data = reader.ReadBytes(len);
			unknown6 = reader.ReadInt32();
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

			writer.Write(rn.BlockName);
			writer.Write(rn.BlockID);
			rn.Serialize(writer);

			writer.Write(bn.BlockName);
			writer.Write(bn.BlockID);
			bn.Serialize(writer);

			writer.Write(tn.BlockName);
			writer.Write(tn.BlockID);
			tn.Serialize(writer);

			writer.Write(unknown1);
			writer.Write(unknown2);
			writer.Write(name);
			writer.Write(unknown3);
			writer.Write(unknown4);

			writer.Write((uint)itemsa.Length);
			for(int i=0; i<itemsa.Length; i++) itemsa[i].Serialize(writer);
			writer.Write(unknown5);

			writer.Write((uint)itemsb.Length);
			for(int i=0; i<itemsb.Length; i++)
			{
				writer.Write(itemsb[i].Unknown1);
			}

			if (version == 0x15) 
			{
				for(int i=0; i<itemsb.Length; i++)
				{
					writer.Write(itemsb[i].Name);
				}
			}

			writer.Write((int)data.Length);
			writer.Write(data);
			writer.Write(unknown6);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tShapeRefNode;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			
			form.lb_srn_a.Items.Clear();
			for(int i=0; i<this.itemsa.Length; i++) form.lb_srn_a.Items.Add(itemsa[i]);

			form.lb_srn_b.Items.Clear();
			for(int i=0; i<this.itemsb.Length; i++) form.lb_srn_b.Items.Add(itemsb[i]);

			form.tb_srn_uk1.Text = "0x"+Helper.HexString((ushort)this.unknown1);
			form.tb_srn_uk2.Text = "0x"+Helper.HexString((uint)this.unknown2);
			form.tb_srn_uk3.Text = "0x"+Helper.HexString((uint)this.unknown3);
			form.tb_srn_uk4.Text = "0x"+Helper.HexString(this.unknown4);
			form.tb_srn_uk5.Text = "0x"+Helper.HexString((uint)this.unknown5);
			form.tb_srn_uk6.Text = "0x"+Helper.HexString((uint)this.unknown6);

			form.tb_srn_kind.Text = this.name;
			form.tb_srn_data.Text = Helper.BytesToHexList(this.data);

			form.tb_srn_ver.Text = "0x"+Helper.HexString(this.version);
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.rn.AddToTabControl(tc);
			this.bn.AddToTabControl(tc);
			this.tn.AddToTabControl(tc);
		}

	}
}
