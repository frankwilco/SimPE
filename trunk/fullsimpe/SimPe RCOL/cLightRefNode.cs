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
using System.ComponentModel;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für cBoundedNode.
	/// </summary>
	public class LightRefNode
		: AbstractCresChildren
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

		string[] items;
		public string[] Strings 
		{
			get { return items; }
			set { items = value; }
		}

		byte[] unknown2;
		public byte[] Unknown2 
		{
			get { return unknown2; }
			//set { unknown2 = value; }
		}

		[BrowsableAttribute(false)]
		public override TransformNode StoredTransformNode
		{
			get { return tn; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public LightRefNode(Rcol parent) : base(parent)
		{
			version = 0xa;
			BlockID = 0x253d2018;

			rn = new RenderableNode(null);
			bn = new BoundedNode(null);
			tn= new TransformNode(null);

			items = new string[0];
			unknown2 = new byte[13];
		}

		#region AbstractCresChildren Member
		public override string GetName()
		{
			return tn.ObjectGraphNode.FileName;
		}

		/// <summary>
		/// Returns a List of all Child Blocks referenced by this Element
		/// </summary>
		[BrowsableAttribute(false)]
		public override IntArrayList ChildBlocks 
		{
			get 
			{
				return tn.ChildBlocks;
			}
		}	

		[BrowsableAttribute(false)]
		public override int ImageIndex 
		{
			get 
			{ 
				return 2;  //light
			}
		}
		#endregion
		
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
			items = new string[reader.ReadUInt32()];
			for (int i=0; i<items.Length; i++) 
			{
				items[i] = reader.ReadString();
			}

			unknown2 = reader.ReadBytes(13);
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
			writer.Write((uint)items.Length);
			for (int i=0; i<items.Length; i++) 
			{
				writer.Write(items[i]);
			}

			writer.Write(unknown2);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tGenericRcol;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 
			form.tb_ver.Text = "0x"+Helper.HexString(this.version);
			form.gen_pg.SelectedObject = this;
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.rn.AddToTabControl(tc);
			this.bn.AddToTabControl(tc);
			this.tn.AddToTabControl(tc);
		}

		public override string ToString()
		{
			return this.tn.ObjectGraphNode.FileName + " ("+base.ToString ()+")";
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}
}
