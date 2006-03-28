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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	
	/// <summary>
	/// This is the actual FileWrapper
	/// </summary>
	/// <remarks>
	/// The wrapper is used to (un)serialize the Data of a file into it's Attributes. So Basically it reads 
	/// a BinaryStream and translates the data into some userdefine Attributes.
	/// </remarks>
	public class DataListExtension
		: AbstractRcolBlock, IScenegraphBlock
	{
		#region Attributes
		Extension ext;
		public Extension Extension
		{
			get { return ext; }
		}

		#endregion
		

		

		/// <summary>
		/// Constructor
		/// </summary>
		public DataListExtension(Rcol parent) : base(parent)
		{
			ext = new Extension(null);
			version = 0x01;
			BlockID = 0x6a836d56;
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();
			string fldsc = reader.ReadString();
			uint myid = reader.ReadUInt32();
			
			ext.Unserialize(reader, version);
			ext.BlockID = myid;
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

			string name = ext.Register(null);
			writer.Write(name);
			writer.Write(ext.BlockID);
			ext.Serialize(writer, version);
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
			this.ext.AddToTabControl(tc);
			tc.SelectedIndex = tc.TabPages.Count-1;
		}

		public override string ToString()
		{
			return ext.VarName + " ("+base.ToString ()+")";
		}

		#region IScenegraphItem Member
		
		public void ReferencedItems(Hashtable refmap, uint parentgroup)
		{
			if (this.Extension.VarName.Trim().ToLower() == "tsmaterialsmeshname")
			{
				ArrayList list = new ArrayList();
				foreach (ExtensionItem ei in this.Extension.Items) 
				{
					string name = ei.String.Trim();
					if (!name.ToLower().EndsWith("_cres")) name += "_cres";

					list.Add(SimPe.Plugin.ScenegraphHelper.BuildPfd(name, SimPe.Plugin.ScenegraphHelper.CRES, parentgroup));
				}

				refmap["tsMaterialsMeshName"] = list;
			}
		}

		#endregion

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.tGenericRcol!=null) this.tGenericRcol.Dispose();
			tGenericRcol = null;
		}

		#endregion
	}
}
