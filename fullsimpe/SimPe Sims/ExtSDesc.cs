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
	public class ExtSDesc : SDesc//, SimPe.Interfaces.Plugin.IMultiplePackedFileWrapper
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
				1,
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
			if (locked) return;
			base.Unserialize(reader);
			chgname = false;
			crmap.Clear();
		}


		protected override void Serialize(System.IO.BinaryWriter writer)
		{
			if (locked) return;
			base.Serialize (writer);
			if (chgname) ChangeName();
			SaveRelations();
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
			locked = true;
			foreach (ExtSrel srel in crmap.Values)
			{
				if (srel.Package!=null) srel.SynchronizeUserData();
				else 
				{
					srel.Package = this.Package;
					srel.SynchronizeUserData();					
					this.Package.Add(srel.FileDescriptor, true);					
				}

				if (!this.Equals(srel.SourceSim)) 
				{
					if (srel.SourceSim!=null) 
						if (srel.SourceSim.Changed)
							srel.SourceSim.SynchronizeUserData();
				}
			}

			crmap.Clear();
			locked = false;
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

	}
}
