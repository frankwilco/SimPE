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
	public class TransformNodeItem 
	{
		ushort unknown1;
		public ushort Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get { return unknown2; }
			set { unknown2= value; }
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
			return "0x"+Helper.HexString((ushort)unknown1) + " 0x" + Helper.HexString((uint)unknown2);
		}
	}

	/// <summary>
	/// Zusammenfassung für cTransformNode.
	/// </summary>
	public class TransformNode
		: AbstractRcolBlock
	{
		#region Attributes
		
		CompositionTreeNode ctn;
		ObjectGraphNode ogn;
		
		TransformNodeItem[] items;
		public TransformNodeItem[] Items 
		{
			get { return items; }
			set { items = value; }
		}

		float tx, ty, tz;
		float rx, ry, rz, rw;
		int unknown;

		public float TransformX 
		{
			get { return tx; }
			set { tx = value; }
		}
		public float TransformY 
		{
			get { return ty; }
			set { ty = value; }
		}
		public float TransformZ 
		{
			get { return tz; }
			set { tz = value; }
		}

		
		public float RotationX 
		{
			get { return rx; }
			set { rx = value; }
		}
		public float RotationY 
		{
			get { return ry; }
			set { ry = value; }
		}
		public float RotationZ 
		{
			get { return rz; }
			set { rz = value; }
		}
		public float RotationW 
		{
			get { return rw; }
			set { rw = value; }
		}

		public int Unknown 
		{
			get { return unknown; }
			set { unknown = value; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public TransformNode(Rcol parent) : base(parent)
		{
			ctn = new CompositionTreeNode(parent);
			ogn = new ObjectGraphNode(parent);

			items = new TransformNodeItem[0];


			version = 0x07;
			BlockID = 0x65246462;
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
			ctn.Unserialize(reader);
			ctn.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
			ogn.Unserialize(reader);
			ogn.BlockID = myid;

			items = new TransformNodeItem[reader.ReadUInt32()];
			for(int i=0; i<items.Length; i++)
			{
				items[i] = new TransformNodeItem();
				items[i].Unserialize(reader);
			}

			tx = reader.ReadSingle();
			ty = reader.ReadSingle();
			tz = reader.ReadSingle();

			rx = reader.ReadSingle();
			ry = reader.ReadSingle();
			rz = reader.ReadSingle();
			rw = reader.ReadSingle();

			unknown = reader.ReadInt32();
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

			writer.Write(ctn.BlockName);
			writer.Write(ctn.BlockID);
			ctn.Serialize(writer);

			writer.Write(ogn.BlockName);
			writer.Write(ogn.BlockID);
			ogn.Serialize(writer);

			writer.Write((uint)items.Length);
			for(int i=0; i<items.Length; i++)
			{
				items[i].Serialize(writer);
			}

			writer.Write(tx);
			writer.Write(ty);
			writer.Write(tz);

			writer.Write(rx);
			writer.Write(ry);
			writer.Write(rz);
			writer.Write(rw);

			writer.Write(unknown);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tTransformNode;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			
			form.lb_tn.Items.Clear();
			for(int i=0; i<this.items.Length; i++) form.lb_tn.Items.Add(items[i]);

			form.tb_tn_ver.Text = "0x"+Helper.HexString(this.version);
			form.tb_tn_ukn.Text = "0x"+Helper.HexString(this.unknown);

			form.tb_tn_tx.Text = this.tx.ToString();
			form.tb_tn_ty.Text = this.ty.ToString();
			form.tb_tn_tz.Text = this.tz.ToString();

			form.tb_tn_rx.Text = this.rx.ToString();
			form.tb_tn_ry.Text = this.ry.ToString();
			form.tb_tn_rz.Text = this.rz.ToString();
			form.tb_tn_rw.Text = this.rw.ToString();
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.ogn.AddToTabControl(tc);
		}
	}
}
