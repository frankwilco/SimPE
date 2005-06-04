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
using SimPe.Geometry;
using System.Collections;

namespace SimPe.Plugin
{	

	/// <summary>
	/// Zusammenfassung für cProcessDeformationsBuilder.
	/// </summary>
	public class ProcessDeformationsBuilder
		: AbstractRcolBlock
	{
		#region Attributes
		GeometryBuilder gb;
		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		short u1;						
		public short Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}

		int u2;						
		public int Unknown2 
		{
			get { return u2; }
			set { u2 = value; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public ProcessDeformationsBuilder(Rcol parent) : base(parent)
		{
			gb = new GeometryBuilder(null);			
			BlockID = 0x5ce7e026;

			pfd = new SimPe.Packages.PackedFileDescriptor();
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
			gb.Unserialize(reader);
			gb.BlockID = myid;

			pfd.Group = reader.ReadUInt32();
			pfd.Instance = reader.ReadUInt32();
			if (Parent.Type==0xffff0001) pfd.SubType = reader.ReadUInt32();
			pfd.Type = reader.ReadUInt32();

			u1 = reader.ReadInt16();
			u2 = reader.ReadInt32();
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

			writer.Write(gb.BlockName);
			writer.Write(gb.BlockID);
			gb.Serialize(writer);

			writer.Write(pfd.Group);
			writer.Write(pfd.Instance);
			if (Parent.Type==0xffff0001) writer.Write(pfd.SubType);
			writer.Write(pfd.Type);

			writer.Write(u1);
			writer.Write(u2);
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
			this.gb.AddToTabControl(tc);
		}

	}
}
