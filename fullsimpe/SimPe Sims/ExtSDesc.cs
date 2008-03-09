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
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using System.Collections;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für ExtSDesc.
	/// </summary>
	public class ExtSDesc : SDesc/*, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper*/
	{
		public ExtSDesc() : base()
		{
			crmap = new Hashtable();
			locked = false;
		}

		
		protected override IWrapperInfo CreateWrapperInfo()
		{
			return new AbstractWrapperInfo(
				"Extended Sim Description Wrapper",
				"Quaxi",
				"This File contains Settings (like interests, friendships, money, age, gender...) for one Sim.",
				7,
				System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.sdsc.png"))				
				); 
		}

		protected override IPackedFileUI CreateDefaultUIHandler()
		{
			return new SimPe.PackedFiles.UserInterface.ExtSDesc();
		}

		/// <summary>
		/// Returns the Name of the File the Character is stored in
		/// </summary>
		/// <remarks>null, if no File was found</remarks>
		public bool IsNPC
		{
			get 
			{
				if (FileTable.ProviderRegistry.SimNameProvider!=null) 
				{
					object o = FileTable.ProviderRegistry.SimNameProvider.FindName(SimId).Tag;
					if (o!=null) 
					{
						object[] tags = (object[])o;
						return tags[4]!=null;
					}
				} 
				return false;
			}
		}

		/// <summary>
		/// Returns the Name of the File the Character is stored in
		/// </summary>
		/// <remarks>null, if no File was found</remarks>
		public bool IsTownie
		{
			get 
			{
				return (((this.FamilyInstance & 0x7f00) == 0x7f00) || this.FamilyInstance==0) && !IsNPC;
			}
		}
		
		public override string CharacterFileName
		{
			get
			{
				if (IsNPC)
				{
					object o = FileTable.ProviderRegistry.SimNameProvider.FindName(SimId).Tag;
					if (o!=null) 
					{
						object[] tags = (object[])o;
						return tags[4].ToString();
					}
				}
				return base.CharacterFileName;
			}
		}


		bool chgname;
		string sname, sfname;
		public override string SimFamilyName
		{
			get
			{
				if (sfname==null) return base.SimFamilyName;
				return sfname;
			}
			set
			{
				chgname = true;
				sfname = value;
			}
		}

		public override string SimName
		{
			get
			{
				if (sname==null) return base.SimName;
				return sname;
			}
			set 
			{
				chgname = true;
				sname = value;
			}
		}

		bool locked;
		protected override void Unserialize(System.IO.BinaryReader reader)
		{
            
            lock (SimPe.Helper.WindowsRegistry)
            {
                //if (locked) { Console.WriteLine("uLock problem for " + this.SimName); return; }
                base.Unserialize(reader);
                chgname = false;
                crmap.Clear();
                }
            
		}


		protected override void Serialize(System.IO.BinaryWriter writer)
		{

            lock (SimPe.Helper.WindowsRegistry)
            {
                //if (locked) { Console.WriteLine("sLock problem for " + this.SimName); return; }
                base.Serialize(writer);
                if (chgname) ChangeName();
                SaveRelations();
            }
            
		}

		

		protected virtual void ChangeName()
		{
			if (!this.IsNPC) 
				if (ChangeNames(SimName, SimFamilyName)) 
					chgname = false;

			if (!chgname) 
			{
				sname = null;
				sfname = null;
			}
		}

		public bool HasRelationWith(ExtSDesc sdsc)
		{
			
			foreach (uint inst in this.Relations.SimInstances) 
				if (sdsc.FileDescriptor.Instance==inst) 
					return true;
			return false;
		}

		#region Changed Relations
		public void AddRelation(ExtSDesc sdesc)
		{
			foreach (ushort inst in Relations.SimInstances)
				if (inst == (ushort)sdesc.FileDescriptor.Instance) return;

			Relations.SimInstances = (ushort[])Helper.Add(Relations.SimInstances, (ushort)sdesc.FileDescriptor.Instance);
			this.Changed = true;
		}

		public void RemoveRelation(ExtSDesc sdesc)
		{
			Relations.SimInstances = (ushort[])Helper.Delete(Relations.SimInstances, (ushort)sdesc.FileDescriptor.Instance);
			this.Changed = true;
		}

		public override bool Changed
		{
			get
			{
				foreach (ExtSrel srel in crmap.Values)
					if (srel.Changed) return true;

				return base.Changed;
			}
			set
			{
				base.Changed = value;

				foreach (ExtSrel srel in crmap.Values)
					srel.Changed = value;
			}
		}

		Hashtable crmap;
        void SaveRelations()
        {
            SimPe.Collections.PackedFileDescriptors pfds = new SimPe.Collections.PackedFileDescriptors();
            //locked = true;


            foreach (ExtSrel srel in crmap.Values)
            {
                if (srel.Package != null) srel.SynchronizeUserData();
                else
                {
                    srel.Package = this.Package;
                    srel.SynchronizeUserData();
                    pfds.Add(srel.FileDescriptor);
                }

                if (!this.Equals(srel.SourceSim))
                {
                    if (srel.SourceSim != null)
                        if (srel.SourceSim.Changed)
                            srel.SourceSim.SynchronizeUserData();
                }
            }

            crmap.Clear();

            locked = false;

            this.Package.BeginUpdate();
            for (int i = pfds.Count - 1; i >= 0; i--)
            {
                if (i == 0) this.Package.ForgetUpdate();
                this.Package.Add(pfds[i], true);
            }
            this.Package.EndUpdate();
        }

		internal ExtSrel GetCachedRelation(uint inst)
		{
			if (crmap.ContainsKey(inst)) return (ExtSrel)crmap[inst];
			return null;
		}

		internal ExtSrel GetCachedRelation(ExtSDesc sdesc)
		{
			return this.GetCachedRelation(GetRelationInstance(sdesc));
		}

		internal void AddRelationToCache(ExtSrel srel)
		{
			if (srel==null) return;
			if (srel.FileDescriptor==null) return;

			if (!crmap.ContainsKey(srel.FileDescriptor.Instance)) crmap[srel.FileDescriptor.Instance] = srel;
		}

		internal void RemoveRelationFromCache(ExtSrel srel)
		{
			if (srel==null) return;
			if (srel.FileDescriptor==null) return;

			if (crmap.ContainsKey(srel.FileDescriptor.Instance)) 
				crmap.Remove(srel.FileDescriptor.Instance);
		}

		public static ExtSrel FindRelation(ExtSDesc src, ExtSDesc dst)
		{
			return FindRelation(src, src, dst);
		}

		public static ExtSrel FindRelation(ExtSDesc cache, ExtSDesc src, ExtSDesc dst)
		{
			uint sinst = src.GetRelationInstance(dst);	
			SimPe.PackedFiles.Wrapper.ExtSrel srel = cache.GetCachedRelation(sinst);
			if (srel==null) 
			{
				SimPe.Interfaces.Files.IPackedFileDescriptor spfd = cache.Package.FindFile(Data.MetaData.RELATION_FILE, 0, cache.FileDescriptor.Group, sinst);
				
				if (spfd!=null) 
				{
					srel = new SimPe.PackedFiles.Wrapper.ExtSrel();
					srel.ProcessData(spfd, cache.Package);
				} 
			}

			return srel;
		}

		public ExtSrel FindRelation(ExtSDesc sdesc)
		{
			return FindRelation(this, sdesc);
		}

		public uint GetRelationInstance(ExtSDesc sdesc)
		{
			return ((this.FileDescriptor.Instance & 0xffff) << 16) | (sdesc.FileDescriptor.Instance & 0xffff);
		}

		public ExtSrel CreateRelation(ExtSDesc sdesc)
		{
			ExtSrel srel = new ExtSrel();
			uint inst = GetRelationInstance(sdesc);
			srel.FileDescriptor = package.NewDescriptor(Data.MetaData.RELATION_FILE, 0, this.FileDescriptor.Group, inst);
			srel.RelationState.IsKnown = true;

			return srel;
		}
		#endregion

		public override int GetHashCode()
		{
			return (int)this.SimId;
		}

		public override bool Equals(object obj)
		{
			if (obj==null) return false;
			if (obj is SDesc) 
			{
				SDesc s = (SDesc)obj;
				return (s.SimId==SimId);
			}
			return base.Equals (obj);
		}

		

		public override string DescriptionHeader
		{
			get
			{
				ArrayList list = new ArrayList();
				list.Add("GUID");
				list.Add("Filename");
				list.Add("Name");
				list.Add("Household ");
				list.Add("isNPC");
				list.Add("isTownie");
				list.Add(SimPe.Serializer.SerializeTypeHeader(this.CharacterDescription));
				list.Add(SimPe.Serializer.SerializeTypeHeader(this.Character));
				list.Add("Genetic"+SimPe.Serializer.SerializeTypeHeader(this.GeneticCharacter));
				list.Add(SimPe.Serializer.SerializeTypeHeader(this.Interests));
				list.Add(SimPe.Serializer.SerializeTypeHeader(this.Skills));
				list.Add("Version");

				if ((int)this.Version >= (int)SDescVersions.University)
					list.Add(SimPe.Serializer.SerializeTypeHeader(this.University));

				if ((int)this.Version >= (int)SDescVersions.Nightlife)
					list.Add(SimPe.Serializer.SerializeTypeHeader(this.Nightlife));				
				

				return Serializer.ConcatHeader(Serializer.ConvertArrayList(list));
			}
		}


		public override string Description
		{
			get
			{
				/** still Missing:
				 *		DNA
				 *		Lifetime Want
				 *		Alive/Dead
				 *		Traits, turnon, turnoff
				 *		Personality, Skills, User Character File, Mother, Father, Children, Best Friends, Household Wealth, Household Funds 
				**/

				ArrayList list = new ArrayList();
				list.Add(Serializer.Property("GUID", "0x"+Helper.HexString(this.SimId)));
				list.Add(Serializer.Property("Filename", this.CharacterFileName));
				list.Add(Serializer.Property("Name", this.SimName+" "+this.SimFamilyName));
				list.Add(Serializer.Property("Household ", this.HouseholdName));
				list.Add(Serializer.Property("isNPC" ,this.IsNPC.ToString()));
				list.Add(Serializer.Property("isTownie" , this.IsTownie.ToString()));
				list.Add(this.CharacterDescription.ToString());
				list.Add(this.Character.ToString());
				list.Add(this.GeneticCharacter.ToString());
				list.Add(this.Interests.ToString());
				list.Add(this.Skills.ToString());
				
				list.Add(Serializer.Property("Version", this.Version.ToString()));

				if ((int)this.Version >= (int)SDescVersions.University)
					list.Add(this.University.ToString());

				if ((int)this.Version >= (int)SDescVersions.Nightlife)
					list.Add(this.Nightlife.ToString());				
				
				return Serializer.Concat(Serializer.ConvertArrayList(list));
			}
		}

	}

	public class LinkedSDesc : ExtSDesc
	{
		public LinkedSDesc() : base()
		{			
		}

		protected override void Unserialize(System.IO.BinaryReader reader)
		{
			base.Unserialize(reader);

			sdna = null;
		}

		SimPe.PackedFiles.Wrapper.SimDNA sdna;
		public SimPe.PackedFiles.Wrapper.SimDNA SimDNA
		{
			get 
			{
				if (sdna==null) 
				{
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = package.FindFile(Data.MetaData.SDNA, 0, Data.MetaData.LOCAL_GROUP, this.FileDescriptor.Instance);
					if (pfd!=null) 
					{
						sdna = new SimDNA();
						sdna.ProcessData(pfd, this.package, true);
					}

				}

				return sdna;
			}
		}

		public SimPe.Interfaces.Providers.ILotItem[] BusinessList
		{
			get 
			{
				if ((uint)this.Version < (uint)SDescVersions.Business) return new SimPe.Interfaces.Providers.ILotItem[0];

				return FileTable.ProviderRegistry.LotProvider.FindLotsOwnedBySim(this.Instance);
			}
		}

		public override string DescriptionHeader
		{
			get
			{				
				ArrayList list = new ArrayList();
				list.Add(base.DescriptionHeader);
				if (this.SimDNA!=null)
					list.Add(this.SimDNA.DescriptionHeader);

				if ((int)this.Version >= (int)SDescVersions.Business)
					list.Add(SimPe.Serializer.SerializeTypeHeader(this.Business));

                if ((int)this.Version >= (int)SDescVersions.Pets)
                    list.Add(SimPe.Serializer.SerializeTypeHeader(this.Pets));

                if ((int)this.Version >= (int)SDescVersions.Voyage)
                    list.Add(SimPe.Serializer.SerializeTypeHeader(this.Voyage));

				return Serializer.ConcatHeader(Serializer.ConvertArrayList(list));
			}
		}

		public override string Description
		{
			get
			{				
				ArrayList list = new ArrayList();
				list.Add(base.Description);
				if (this.SimDNA!=null)
					list.Add(Serializer.SubProperty("DNA", this.SimDNA.Description));

				if ((int)this.Version >= (int)SDescVersions.Business)
					list.Add(this.Business.ToString());

                if ((int)this.Version >= (int)SDescVersions.Pets)
                    list.Add(this.Pets.ToString());

                if ((int)this.Version >= (int)SDescVersions.Voyage)
                    list.Add(this.Voyage.ToString());
				
                return Serializer.Concat(Serializer.ConvertArrayList(list));
			}
		}

	}
}
