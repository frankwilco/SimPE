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
	/// <summary>
	/// Zusammenfassung für cGeometryNode.
	/// </summary>
	public class ViewerRefNodeRecursive
		: AbstractRcolBlock
	{
		#region Attributes
		ViewerRefNodeBase vrnb;
		RenderableNode rn;
		BoundedNode bn;
		TransformNode tn;

		short unknown1;
		public short Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		string[] names;
		public string[] Names
		{
			get { return names; }
			set { names = value; }
		}

		int unknown2;
		public int Unknown2 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		short unknown3;
		public short Unknown3 
		{
			get { return unknown3; }
			set { unknown3 = value; }
		}

		string unknown4;
		public string Unknown4 
		{
			get { return unknown4; }
			set { unknown4 = value; }
		}

		byte[] unknown5;
		public byte[] Unknown5 
		{
			get { return unknown5; }
			set { unknown5 = value; }
		}

		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public ViewerRefNodeRecursive(Interfaces.IProviderRegistry provider, Rcol parent) : base(provider, parent)
		{
			vrnb = new ViewerRefNodeBase(provider, null);
			rn = new RenderableNode(provider, null);
			bn = new BoundedNode(provider, null);
			tn = new TransformNode(provider, null);

			names = new string[0];
			unknown4 = "";
			unknown5 = new byte[64];

			version = 0x01;
			BlockID = 0x0c152b8e;
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
			vrnb.Unserialize(reader);
			vrnb.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
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
			names = new string[reader.ReadInt32()];
			for (int i=0; i<names.Length; i++) names[i] = reader.ReadString();

			unknown2 = reader.ReadInt32();
			unknown3 = reader.ReadInt16();
			unknown4 = reader.ReadString();
			unknown5 = reader.ReadBytes(64);
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

			writer.Write(vrnb.BlockName);
			writer.Write(vrnb.BlockID);
			vrnb.Serialize(writer);

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
			writer.Write((int)names.Length);
			for (int i=0; i<names.Length; i++) writer.Write(names[i]);

			writer.Write(unknown2);
			writer.Write(unknown3);
			writer.Write(unknown4);
			writer.Write(unknown5);
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
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.vrnb.AddToTabControl(tc);
			this.rn.AddToTabControl(tc);
			this.bn.AddToTabControl(tc);
			this.tn.AddToTabControl(tc);
		}
	}
}
