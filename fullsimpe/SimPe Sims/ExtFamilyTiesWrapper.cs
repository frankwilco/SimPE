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
using SimPe.Interfaces.Plugin;
using System.Collections;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für ExtFamilyTiesWrapper.
	/// </summary>
	public class ExtFamilyTies : FamilyTies
	{
		public ExtFamilyTies():base(FileTable.ProviderRegistry.SimNameProvider)
		{
			//
			// TODO: Fügen Sie hier die Konstruktorlogik hinzu
			//
		}

		#region IWrapper Member
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Extended Family Ties Wrapper",
				"Quaxi",
				"Contains all Familyties that are stored in a Neighborhood.",
				2,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.familyties.png"))
				); 
		}
		#endregion

		#region AbstractWrapper Member
		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.ExtFamilyTies();
		}
		#endregion

		/// <summary>
		/// returns a List of Parent Sims
		/// </summary>
		/// <param name="sdsc"></param>
		/// <returns></returns>
		public Wrapper.SDesc[] ParentSims(Wrapper.SDesc sdsc)
		{
			ArrayList list = new ArrayList();
			SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = this.FindTies(sdsc);
			if (fts!=null) 
				foreach (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti in fts.Ties)
				{
					if (fti.SimDescription==null) continue;
					if (fti.Type == Data.MetaData.FamilyTieTypes.MyMotherIs || fti.Type == Data.MetaData.FamilyTieTypes.MyFatherIs) list.Add(fti.SimDescription);
				}

			Wrapper.SDesc[] ret = new SDesc[list.Count];
			list.CopyTo(ret);
			return ret;
		}

		/// <summary>
		/// returns a List of Parent Sims
		/// </summary>
		/// <param name="sdsc"></param>
		/// <returns></returns>
		public Wrapper.SDesc[] SiblingSims(Wrapper.SDesc sdsc)
		{
			ArrayList list = new ArrayList();
			SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = this.FindTies(sdsc);

			if (fts!=null) 
				foreach (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti in fts.Ties)
				{
					if (fti.SimDescription==null) continue;
					if (fti.Type == Data.MetaData.FamilyTieTypes.ImMarriedTo || fti.Type == Data.MetaData.FamilyTieTypes.MySiblingIs) list.Add(fti.SimDescription);
				}

			Wrapper.SDesc[] ret = new SDesc[list.Count];
			list.CopyTo(ret);
			return ret;
		}

		/// <summary>
		/// returns a List of Parent Sims
		/// </summary>
		/// <param name="sdsc"></param>
		/// <returns></returns>
		public Wrapper.SDesc[] ChildSims(Wrapper.SDesc sdsc)
		{
			ArrayList list = new ArrayList();
			SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts = this.FindTies(sdsc);

			if (fts!=null) 
				foreach (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti in fts.Ties)
				{
					if (fti.SimDescription==null) continue;
					if (fti.Type == Data.MetaData.FamilyTieTypes.MyChildIs ) list.Add(fti.SimDescription);
				}
			

			Wrapper.SDesc[] ret = new SDesc[list.Count];
			list.CopyTo(ret);
			return ret;
		}
	}
}
