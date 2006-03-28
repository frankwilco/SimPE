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
	/// this is basicall te same as StandardLightBase
	/// </summary>
	public class LightT : StandardLightBase , System.IDisposable
	{
		#region Attributes

		#endregion
		

		/// <summary>
		/// Constructor
		/// </summary>
		public LightT(Rcol parent) : base(parent)
		{
			version = 11;
			BlockID = 0;

			sgres = new SGResource(null);
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();

			sgres.BlockName = reader.ReadString();
			sgres.BlockID = reader.ReadUInt32();			
			sgres.Unserialize(reader);
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
		}

		TabPage.LightT tLightT;
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{
				if (tLightT==null) tLightT = new SimPe.Plugin.TabPage.LightT();
				return tLightT;
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (tLightT==null) tLightT = new SimPe.Plugin.TabPage.LightT();
			tLightT.tb_lt_ver.Text = "0x"+Helper.HexString(this.version);
			tLightT.tb_lt_name.Text = sgres.FileName;
		}

		#region IDisposable Member

		public override void Dispose()
		{
			if (tLightT!=null) tLightT.Dispose();
			tLightT = null;
		}

		#endregion
	}
}
