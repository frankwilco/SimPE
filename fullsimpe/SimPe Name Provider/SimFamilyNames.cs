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
using System.IO;
using System.Collections;
using SimPe.Data;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces.Plugin.Internal;
using SimPe.Interfaces;
using SimPe.Interfaces.Files;

namespace SimPe.Providers
{
	/// <summary>
	/// Provides an Alias Matching a SimID with it's Name
	/// </summary>
	public class SimFamilyNames : SimCommonPackage, SimPe.Interfaces.Providers.ISimFamilyNames
	{
		/// <summary>
		/// List of known Aliases (can be null)
		/// </summary>
		private Hashtable names;		

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		/// <param name="folder">The Base Package</param>
		public SimFamilyNames(IPackageFile package) : base(package) {}

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		public SimFamilyNames() : base(null) {}


		

		/// <summary>
		/// Loads all package Files in the directory and scans them for Name Informations
		/// </summary>
		public void LoadSimsFromFolder() 
		{
			names = new Hashtable();
			if (BasePackage==null) return;

			SimPe.PackedFiles.Wrapper.Fami fami = new SimPe.PackedFiles.Wrapper.Fami(null);
			//ArrayList al = new ArrayList();
			foreach (uint type in fami.AssignableTypes) 
			{
				IPackedFileDescriptor[] list = BasePackage.FindFiles(type);

				foreach(IPackedFileDescriptor pfd in list )
				{
					fami.ProcessData(pfd, BasePackage);
					foreach(uint simid in fami.Members) 
					{
						Alias a = new Alias(simid, fami.Name);
						if (!names.Contains(simid))	names.Add(simid, a);
					}
				}				
			}//foreach
			

			/*names = new Alias[al.Count];
			al.CopyTo(names);*/
		}

		/// <summary>
		/// Returns the the Alias with the specified Type
		/// </summary>
		/// <param name="id">The id of a Sim</param>
		/// <returns>The Alias of the Sim</returns>
		public SimPe.Interfaces.IAlias FindName(uint id) 
		{
			if (names==null) LoadSimsFromFolder();
			
			object o = names[id];
			if (o!=null) return (IAlias)o;
			else return new Alias(id, "Unknown");			
		}		

		/// <summary>
		/// Returns a List of All SimID's found in the Package
		/// </summary>
		/// <returns>The List of found SimID's</returns>
		public ArrayList GetAllSimIDs() 
		{
			if (BasePackage==null) new ArrayList();

			//load a list of all avail SimID's
			ArrayList simids = new ArrayList();
			IPackedFileDescriptor[] pfds = BasePackage.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);

			SimPe.PackedFiles.Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(null, null, null);
			foreach(IPackedFileDescriptor pfd in pfds) 
			{
				sdesc.ProcessData(pfd, BasePackage);
				simids.Add(sdesc.SimId);
			}

			return simids;
		}

		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected override void BasePackageChanged() 
		{
			names = null;
		}
	}
}
