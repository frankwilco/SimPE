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
	public class GeometryNode
		: AbstractRcolBlock
	{
		#region Attributes
		ObjectGraphNode ogn;

		public ObjectGraphNode ObjectGraphNode 
		{
			get { return ogn; }
			set { ogn = value; }
		}

		short unknown1;
		public short Unknown1 
		{
			get { return unknown1; }
			set { unknown1 = value; }
		}

		short unknown2;
		public short Unknown2 
		{
			get { return unknown2; }
			set { unknown2 = value; }
		}

		byte unknown3;
		public byte Unknown3 
		{
			get { return unknown3; }
			set { unknown3 = value; }
		}

		int count;
		public int Count 
		{
			get { return count; }
			set { count = value; }
		}
		
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public GeometryNode(Interfaces.IProviderRegistry provider, Rcol parent) : base(provider, parent)
		{
			ogn = new ObjectGraphNode(provider, null);
			this.sgres = new SGResource(provider, null);

			version = 0x0c;
			BlockID = 0x7BA3838C;
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
			ogn.Unserialize(reader);
			ogn.BlockID = myid;

			name = reader.ReadString();
			myid = reader.ReadUInt32();		
			sgres.Unserialize(reader);
			sgres.BlockID = myid;

			if (version==0x0b) 
			{
				unknown1 = reader.ReadInt16();
			}

			if ((version==0x0b) || (version==0x0c))
			{
				unknown2 = reader.ReadInt16();
				unknown3 = reader.ReadByte();
			}

			count = reader.ReadInt32();
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

			writer.Write(ogn.BlockName);
			writer.Write(ogn.BlockID);
			ogn.Serialize(writer);

			writer.Write(sgres.BlockName);
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);

			if (version==0x0b) 
			{
				writer.Write(unknown1);
			}

			if ((version==0x0b) || (version==0x0c))
			{
				writer.Write(unknown2);
				writer.Write(unknown3);
			}

			writer.Write(count);
		}

		fShapeRefNode form = null;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (form==null) form = new fShapeRefNode(); 
				return form.tGeometryNode;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fShapeRefNode(); 

			form.tb_gn_ver.Text = "0x"+Helper.HexString(this.version);

			form.tb_gn_uk1.Text = "0x"+Helper.HexString((ushort)this.unknown1);
			form.tb_gn_uk2.Text = "0x"+Helper.HexString((ushort)this.unknown2);
			form.tb_gn_uk3.Text = "0x"+Helper.HexString(this.unknown3);

			form.tb_gn_count.Text = this.count.ToString();
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.ogn.AddToTabControl(tc);
		}


	}
}
