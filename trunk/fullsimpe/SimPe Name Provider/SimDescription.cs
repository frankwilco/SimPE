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
using System.Xml;

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
            bool didwarndoubleguid = false;
			if (BasePackage == null) return;

			IPackedFileDescriptor[] files = BasePackage.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);

			foreach (IPackedFileDescriptor pfd in files) 
			{
				//SDesc sdesc = new SDesc(this.names, this.famnames, this);
				LinkedSDesc sdesc = new LinkedSDesc();
				sdesc.ProcessData(pfd, BasePackage);

				if (bysimid.ContainsKey((uint)sdesc.SimId) || byinstance.ContainsKey((ushort)sdesc.Instance))
                    if (!didwarndoubleguid)
                    {
                        Helper.ExceptionMessage(new Warning("A Sim was found Twice!", "The Sim with GUID 0x" + Helper.HexString(sdesc.SimId) + " (inst=0x" + Helper.HexString(sdesc.Instance) + ") exists more than once. This could result in  Problems during the Gameplay!"));
                        didwarndoubleguid = true;
                    }
				
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
			foreach (SimPe.PackedFiles.Wrapper.LinkedSDesc sdesc in ht.Values)
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
		System.Collections.Generic.Dictionary<int, string> turnons;
		void LoadTurnOns()
		{
			if (turnons!=null) return;
            turnons = new System.Collections.Generic.Dictionary<int, string>();

            if (SimPe.PathProvider.Global.EPInstalled < 2) return;

            SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.Global.Latest.InstallFolder, @"TSData\Res\Text\UIText.package"));
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

        public TraitAlias[] GetAllTurnOns()
		{
			if (turnons==null) LoadTurnOns();
            TraitAlias[] a = new TraitAlias[turnons.Count];

			int ct = 0;
			foreach (int k in turnons.Keys)
			{
				string s = turnons[k];
				int e = k;
				if (e>0xD) e+=2;
				a[ct++] = new TraitAlias((ulong)Math.Pow(2, e), s);
            }

			return a;
		}

		public ulong BuildTurnOnIndex(ushort val1, ushort val2, ushort val3)
		{
			return (ulong)( ((uint)(val3 << 16)) | ((uint)(val2 << 16)) | ((uint)(val1 & 0x3FFF)) ); //14
		}

		public ushort[] GetFromTurnOnIndex(ulong index)
		{
			ushort[] ret = new ushort[3];
            ret[2] = (ushort)((index >> 32) & 0x0007);
			ret[1] = (ushort)((index >> 16) & 0xFFFF); //14
			ret[0] = (ushort)(index & 0x3FFF); //0x3FFF
			
			return ret;
		}
		

		public string GetTurnOnName(ushort val1, ushort val2, ushort val3)
		{
			if (turnons==null) LoadTurnOns();

			ulong v = BuildTurnOnIndex(val1, val2, val3);
			string ret = "";			
			int ct = 0;
			while (v>0) 
			{
				ulong s = v&1;
				if (s==1) 
				{
					string o = turnons[ct];
					if (o==null) return SimPe.Localization.GetString("Unknown");
					if (ret!="") ret+= ", ";
					ret += o;
				}

				v = v>>1;
			}

			return ret;
		}
		#endregion

        #region Voyage Vacation Collectibles
        System.Collections.Generic.Dictionary<int, CollectibleAlias> collectibles;
        void LoadCollectibles()
        {
            if (collectibles != null) return;
            collectibles = new System.Collections.Generic.Dictionary<int, CollectibleAlias>();
            if (SimPe.PathProvider.Global.EPInstalled < 11) return;
            
            SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.Global.Latest.InstallFolder, @"TSData\Res\Text\UIText.package"));
            SimPe.PackedFiles.Wrapper.Str str = new Str();
            SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(Data.MetaData.STRING_FILE, 0, Data.MetaData.LOCAL_GROUP, 0xb7);
            if (pfd != null)
            {
                str.ProcessData(pfd, pkg);
                SimPe.PackedFiles.Wrapper.StrItemList strs = str.FallbackedLanguageItems(Helper.WindowsRegistry.LanguageCode);

                
                    
                pkg = SimPe.Packages.File.LoadFromFile(System.IO.Path.Combine(PathProvider.Global.Latest.InstallFolder, @"TSData\Res\UI\ui.package"));
                pfd = pkg.FindFile(0, 0, 0xA99D8A11, 0xACDC6300);
                if (pfd != null)
                {
                    try
                    {
                        SimPe.PackedFiles.Wrapper.Xml xml = new SimPe.PackedFiles.Wrapper.Xml();
                        xml.ProcessData(pfd, pkg);


                        string[] lines = xml.Text.Split(new char[] { '\r' });
                        SimPe.PackedFiles.Wrapper.Picture pic = new Picture();
                        SimPe.FileTable.FileIndex.Load();
                        foreach (string fulline in lines)
                        {
                            string line = fulline.ToLower().Trim();
                            if (line.StartsWith("<legacy") && line.IndexOf("enabled\"") > 0 && line.IndexOf("tipres=") >= 0)
                            {
                                line = line.Replace("<legacy", "").Replace(">", "").Trim();
                                string tipres = GetUIListAttribute(line, "tipres");
                                int index = Helper.StringToInt32(tipres.Split(new char[] { ',' })[1], 0, 16) & 0xFFFF;
                                int testnr = (int)((Helper.StringToInt32(tipres.Split(new char[] { ',' })[1], 0, 16) & 0xFFFF0000) >> 16);

                                if (index > 0 && testnr == 0xb7)
                                {
                                    index = CreateCollectibleAlias(strs, pic, line, index);
                                }
                            }
                        }

                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine("ERROR during Voyage Collectible Image Parsing:\n" + e.ToString());
                        if (Helper.DebugMode) Helper.ExceptionMessage(e);
                    }
                }
            }
        }

        private int CreateCollectibleAlias(SimPe.PackedFiles.Wrapper.StrItemList strs, SimPe.PackedFiles.Wrapper.Picture pic, string line, int index)
        {
            index--;
            string image = GetUIListAttribute(line, "image");
            string id = GetUIAttribute(line, "id");
            int nr = Helper.StringToInt32(id, 0, 16) / 2 - 1;
            string[] stgi = image.Split(new char[] { ',' });
            UInt32 g = Helper.StringToUInt32(stgi[0], 0, 16);
            UInt32 i = Helper.StringToUInt32(stgi[1], 0, 16);
            string name = GetUITextAttribute(line, "tiptext");
            if (index < strs.Count) name = strs[index].Title;

            System.Drawing.Image img = null;

            img = LoadCollectibleIcon(pic, g, i);

            collectibles[nr] = new CollectibleAlias((ulong)Math.Pow(2, nr), nr, name, img);
            return index;
        }

        private static System.Drawing.Image LoadCollectibleIcon(SimPe.PackedFiles.Wrapper.Picture pic, UInt32 g, UInt32 i)
        {
            SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] items = SimPe.FileTable.FileIndex.FindFileByGroupAndInstance(g, i);
            if (items.Length > 0)
            {
                pic.ProcessData(items[0]);
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(pic.Image.Width / 4, pic.Image.Height);
                System.Drawing.Graphics gr = System.Drawing.Graphics.FromImage(bmp);
                gr.DrawImage(pic.Image, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height), System.Drawing.GraphicsUnit.Pixel);
                gr.Dispose();
                return bmp;
            }
            return null;
        }

        private static string GetUIListAttribute(string line, string name)
        {
            line = " " + line+" ";
            int p = line.IndexOf(" "+name+"={");
            string tipres = line.Substring(p+(" "+name+"={").Length);
            p = tipres.IndexOf("} ");
            tipres = tipres.Substring(0, p);

            return tipres;
        }

        private static string GetUIAttribute(string line, string name)
        {
            line = " " + line + " ";
            int p = line.IndexOf(" "+name + "=");
            string tipres = line.Substring(p + (" "+name + "=").Length);
            p = tipres.IndexOf(' ');
            tipres = tipres.Substring(0, p);

            return tipres;
        }

        private static string GetUITextAttribute(string line, string name)
        {
            line = " " + line + " ";
            int p = line.IndexOf(" "+name + "=\"");
            string tipres = line.Substring(p + (" "+name + "=\"").Length);
            p = tipres.IndexOf("\" ");
            tipres = tipres.Substring(0, p);

            return tipres;
        }

        



        public SimPe.Providers.CollectibleAlias[] GetAllCollectibles()
        {
            if (collectibles == null) LoadCollectibles();
            SimPe.Providers.CollectibleAlias[] a = new SimPe.Providers.CollectibleAlias[collectibles.Count];

            int ct = 0;
            foreach (int k in collectibles.Keys)
            {
                a[ct++] = collectibles[k];
            }

            return a;
        }

        public ulong BuildCollectibleIndex(ushort val1, ushort val2, ushort val3, ushort val4)
        {
            return (uint)(((((val4 << 16) + val3) << 16) + val2) << 16) +val1;
        }

        public ushort[] GetFromCollectibleIndex(ulong index)
        {
            ushort[] ret = new ushort[2];
            ret[3] = (ushort)((index >> 48) & 0xFFFF);
            ret[2] = (ushort)((index >> 32) & 0xFFFF);
            ret[1] = (ushort)((index >> 16) & 0xFFFF);
            ret[0] = (ushort)((index & 0xFFFF));

            return ret;
        }


        public string GetCollectibleName(ushort val1, ushort val2, ushort val3, ushort val4)
        {
            if (collectibles == null) LoadCollectibles();

            ulong v = BuildCollectibleIndex(val1, val2, val3, val4);
            string ret = "";
            int ct = 0;
            while (v > 0)
            {
                ulong s = v & 1;
                if (s == 1)
                {
                    object o = collectibles[ct];
                    if (o == null) return SimPe.Localization.GetString("Unknown");
                    if (ret != "") ret += ", ";
                    ret += o.ToString();
                }

                v = v >> 1;
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
