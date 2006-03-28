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
	/// Zusammenfassung für cBoundingVolumeBuilder.
	/// </summary>
	public class BoundingVolumeBuilder
		: AbstractRcolBlock
	{
		#region Attributes
		GeometryBuilder gb;
		
		
		byte[] u1;
		public byte[] Unknown1 
		{
			get { return u1; }
			set { u1 = value; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public BoundingVolumeBuilder(Rcol parent) : base(parent)
		{
			gb = new GeometryBuilder(null);			
			BlockID = 0x1cfeceb8;

			u1 = new byte[5];
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

		
			if (version>=0x2) u1 = reader.ReadBytes(u1.Length);
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

			if (version>=0x2) writer.Write(u1);
		}

		//fShapeRefNode form = null;
		TabPage.GenericRcol tGenericRcol;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (tGenericRcol==null) tGenericRcol = new SimPe.Plugin.TabPage.GenericRcol();
				return tGenericRcol;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (tGenericRcol==null) tGenericRcol = new SimPe.Plugin.TabPage.GenericRcol();
			tGenericRcol.tb_ver.Text = "0x"+Helper.HexString(this.version);
			tGenericRcol.gen_pg.SelectedObject = this;
		}

		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			base.ExtendTabControl (tc);
			this.gb.AddToTabControl(tc);
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.tGenericRcol!=null) this.tGenericRcol.Dispose();
			tGenericRcol = null;
		}

		#endregion
	}

}
