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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.Wrapper.Supporting
{
	/// <summary>
	/// Zusammenfassung für SimRelations.
	/// </summary>
	public class SimRelations
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="rels">(2 Items) inbound and outbound Relationship</param>
		internal SimRelations (SRel[] rels) 
		{
			this.rels = rels;
		}
		

		/// <summary>
		/// This string will be dieplayed whe ToString is called
		/// </summary>
		private string nametag = null;

		/// <summary>
		/// Returns/Sets the nametag
		/// </summary>
		public string NameTag 
		{
			get { return nametag; }
			set { nametag = value; }
		}

		/// <summary>
		/// Returns the nametag if available
		/// </summary>
		/// <returns>A String Describing the Object</returns>
		public override string ToString()
		{
			if (nametag!=null) return nametag;

			return base.ToString ();
		}


		/// <summary>
		/// inbound(1) and outbound(0) relationshios
		/// </summary>
		SRel[] rels;

		/// <summary>
		/// The relation of your Sim zo another
		/// </summary>
		public SRel OutboundRelation 
		{
			get { return rels[0]; }
		}

		/// <summary>
		/// The relation of another Sim to your Sim
		/// </summary>
		public SRel InboundRelation
		{
			get { return rels[1]; }
		}

		/// <summary>
		/// Commits the Data
		/// </summary>
		public void SynchronizeUserData()
		{
			if (rels!=null) 
			{
				if (rels[0]!=null) rels[0].SynchronizeUserData();
				if (rels[1]!=null) rels[1].SynchronizeUserData();
			}
		}

	}
}
