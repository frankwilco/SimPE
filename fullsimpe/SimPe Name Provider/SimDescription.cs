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
		/// Returns availabl SDSC Files by SimGUID
		/// </summary>
		public Hashtable SimGuidMap
		{
			get 
			{
				if (bysimid==null) LoadDescriptions();
				return bysimid;
			}
		}

		/// <summary>
		/// Holds all Descriptions by Instance
		/// </summary>
		Hashtable byinstance;
		/// <summary>
		/// Returns availabl SDSC Files by Instance
		/// </summary>
		public Hashtable SimInstance
		{
			get 
			{
				if (byinstance==null) LoadDescriptions();
				return byinstance;
			}
		}

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
				//SDesc sdesc = new SDesc(this.names, this.famnames, this);
				ExtSDesc sdesc = new ExtSDesc();
				sdesc.ProcessData(pfd, BasePackage);

				if (bysimid.ContainsKey((uint)sdesc.SimId) || byinstance.ContainsKey((ushort)sdesc.Instance))
					Helper.ExceptionMessage(new Warning("A Sim was found Twice!", "The Sim with GUID 0x"+Helper.HexString(sdesc.SimId)+" (inst=0x"+Helper.HexString(sdesc.Instance)+") exists more than once. This could result in  Problems during the Gameplay!"));
				
				bysimid[(uint)sdesc.SimId] = sdesc;
				byinstance[(ushort)sdesc.Instance] = sdesc;
			}
		}
		public ArrayList GetHouseholdNames()
		{
			string fc;
			return GetHouseholdNames(out fc);
		}

		public ArrayList GetHouseholdNames(out string firstcustum)
		{
			Hashtable ht = SimPe.FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance;
			ArrayList list = new ArrayList();
			firstcustum = null;
			foreach (SimPe.PackedFiles.Wrapper.ExtSDesc sdesc in ht.Values)
			{
				string n = sdesc.HouseholdName;
				if (n==null) n=SimPe.Localization.GetString("Unknown");
				if (!list.Contains(n)) 
				{
					list.Add(n);
					if (firstcustum==null && !sdesc.IsNPC && !sdesc.IsTownie) firstcustum = n;
				}				
			}

			if (firstcustum==null) 
			{
				if (list.Count>0) firstcustum = (string)list[0];
				else firstcustum = SimPe.Localization.GetString("Unknown");
			}

			list.Sort();
			return list;
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


		#region Nightlife Turn On/Off Extension
		Hashtable turnons;
		void LoadTurnOns()
		{
			if (turnons!=null) return;
			turnons = new Hashtable();

			if (Helper.WindowsRegistry.EPInstalled<2) return;

			SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP2Path, @"TSData\Res\Text\UIText.package"));
			SimPe.PackedFiles.Wrapper.Str str = new Str();
			SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(Data.MetaData.STRING_FILE, 0 , Data.MetaData.LOCAL_GROUP, 0xe1);

			if (pfd!=null) 
			{
				str.ProcessData(pfd, pkg);
				SimPe.PackedFiles.Wrapper.StrItemList strs = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);

				for (int i=0; i<strs.Count; i++)
					turnons[i] = strs[i].Title;
			}
		}

		public SimPe.Interfaces.IAlias[] GetAllTurnOns()
		{
			if (turnons==null) LoadTurnOns();
			SimPe.Interfaces.IAlias[] a = new SimPe.Interfaces.IAlias[turnons.Count];

			int ct = 0;
			foreach (int k in turnons.Keys)
			{
				string s = (string)turnons[k];
				int e = k;
				//if (e>=0xE) e+=2;
#if DEBUG
				a[ct++] = new SimPe.Data.Alias((uint)Math.Pow(2, e), s);
#else
				a[ct++] = new SimPe.Data.Alias((uint)Math.Pow(2, e), s, "{name}");
#endif
			}

			return a;
		}

		public uint BuildTurnOnIndex(ushort val1, ushort val2)
		{
			return (uint)((val2 << 14) + val1);
		}

		public ushort[] GetFromTurnOnIndex(uint index)
		{
			ushort[] ret = new ushort[2];
			ret[1] = (ushort)(index >> 14);
			ret[0] = (ushort)(index & 0x3FFF);
			
			return ret;
		}
		

		public string GetTurnOnName(ushort val1, ushort val2)
		{
			if (turnons==null) LoadTurnOns();

			uint v = BuildTurnOnIndex(val1, val2);
			string ret = "";			
			int ct = 0;
			while (v>0) 
			{
				uint s = v&1;
				if (s==1) 
				{
					object o = turnons[ct];
					if (o==null) return SimPe.Localization.GetString("Unknown");
					if (ret!="") ret+= ", ";
					ret += o.ToString();
				}

				v = v>>1;
			}

			return ret;
		}
		#endregion

		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected override void OnChangedPackage() 
		{
			bysimid = null;
			byinstance = null;
			names = null;
			famnames = null;
		}
	}
}
