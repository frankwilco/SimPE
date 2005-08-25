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
	/// Zusammenfassung für cTagExtension.
	/// </summary>
	public class TagExtension
		: AbstractRcolBlock
	{
		#region Attributes
		string en;
		uint eid;
		uint ever;

		string s1;
		public string Name 
		{
			get { return s1; }
			set { s1 = value; }
		}
		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public TagExtension(Rcol parent) : base(parent)
		{
			en = "cExtension";
			eid = 0;
			ever = 3;
			BlockID = 0x9a809646;
			s1 = "";
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();

			en = reader.ReadString();
			eid = reader.ReadUInt32();		
			ever = reader.ReadUInt32();
			s1 = reader.ReadString();
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

			writer.Write(en);
			writer.Write(eid);
			writer.Write(ever);
			writer.Write(s1);
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


		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}


}
