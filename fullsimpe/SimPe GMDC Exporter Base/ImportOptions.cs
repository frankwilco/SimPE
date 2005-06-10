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
using System.Windows.Forms;

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Contains the Globla Import Options as specified by the User
	/// </summary>
	public class ImportOptions
	{
		/// <summary>
		/// Creates an Instance of the Optiosn class
		/// </summary>
		/// <param name="res">Result of the Import Dialog</param>
		/// <param name="cg">Want to clean the Groups</param>
		/// <param name="cb">Want to clean the Joints</param>
		/// <param name="uc">Want to Update the Crew, with the new Bone Hirarchy and Location</param>
		public ImportOptions(DialogResult res, bool cg, bool cb, bool uc) 
		{
			this.res = res;
			this.cleanbones = cb;
			this.cleangroups = cg;
			this.updatecres = uc;
		}

		DialogResult res;
		/// <summary>
		/// Should the Import be continued?
		/// </summary>
		public DialogResult Result 
		{
			get { return res; }
		}

		bool cleangroups;
		/// <summary>
		/// Should we clean available Groups before the Import?
		/// </summary>
		public bool CleanGroups 
		{
			get { return cleangroups; }
		}

		bool cleanbones;
		/// <summary>
		/// Should we remove unreferenced Joints after the Import?
		/// </summary>
		public bool CleanBones 
		{
			get { return cleanbones; }
		}

		bool updatecres;
		/// <summary>
		/// Writes the Bone Locationa and Hirarchy to the CRES
		/// </summary>
		public bool UpdateCres 
		{
			get {return updatecres; }
		}
	}
}
