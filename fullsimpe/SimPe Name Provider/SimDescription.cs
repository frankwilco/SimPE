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
using SimPe.Interfaces.Providers;
using SimPe.Interfaces.Files;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Providers
{
	/// <summary>
	/// Zusammenfassung für SimDescription.
	/// </summary>
	public class SimDescriptions : SimCommonPackage, ISimDescriptions	 
	{
		/// <summary>
		/// Holds all Descriptions by SimId
		/// </summary>
		Hashtable bysimid;

		/// <summary>
		/// Holds all Descriptions by Instance
		/// </summary>
		Hashtable byinstance;

		/// <summary>
		/// Null or a Nameprovider
		/// </summary>
		ISimNames names;

		/// <summary>
		/// Nullor a FamilyName Provider
		/// </summary>
		ISimFamilyNames famnames;
			
		/// <summary>
		/// Creates the List for the specific Package
		/// </summary>
		/// <param name="folder">The Base Package</param>
		/// <param name="names">null or a valid SimNames Provider</param>
		/// <param name="famnames">nullr or a valid SimFamilyNames Provider</param>
		public SimDescriptions(IPackageFile package, ISimNames names, ISimFamilyNames famnames) : base(package) 
		{
			this.names = names;
			this.famnames = famnames;
		}

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="names">null or a valid SimNames Provider</param>
		/// <param name="famnames">nullr or a valid SimFamilyNames Provider</param>
		internal SimDescriptions(ISimNames names, ISimFamilyNames famnames) : base(null) 
		{
			this.names = names;
			this.famnames = famnames;
		}


		/// <summary>
		/// Loads all Available Description Files in the Package
		/// </summary>
		protected void LoadDescriptions() 
		{
			bysimid = new Hashtable();
			byinstance = new Hashtable();
			if (BasePackage == null) return;

			IPackedFileDescriptor[] files = BasePackage.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);

			foreach (IPackedFileDescriptor pfd in files) 
			{
				SDesc sdesc = new SDesc(this.names, this.famnames, this);
				sdesc.ProcessData(pfd, BasePackage);

				bysimid.Add((uint)sdesc.SimId, sdesc);
				byinstance.Add((ushort)sdesc.Instance, sdesc);
			}
		}
		
		#region ISimDescription Member

		public SimPe.Interfaces.Wrapper.ISDesc FindSim(uint simid)
		{
			if (bysimid==null) LoadDescriptions();
			return (SimPe.Interfaces.Wrapper.ISDesc)bysimid[simid];
		}

		SimPe.Interfaces.Wrapper.ISDesc SimPe.Interfaces.Providers.ISimDescriptions.FindSim(ushort instance)
		{
			if (byinstance==null) LoadDescriptions();
			return (SimPe.Interfaces.Wrapper.ISDesc)byinstance[instance];
		}

		public ushort GetInstance(uint simid) 
		{			
			SimPe.Interfaces.Wrapper.ISDesc d = FindSim(simid);
			if (d!=null) return d.Instance;
			else return 0xffff;
		}

		public uint GetSimId(ushort instance) 
		{
			SimPe.Interfaces.Wrapper.ISDesc d = FindSim(instance);
			if (d!=null) return d.SimId;
			else return 0xffffffff;
		}

		#endregion


		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected override void BasePackageChanged() 
		{
			bysimid = null;
			byinstance = null;
			names = null;
			famnames = null;
		}
	}
}
