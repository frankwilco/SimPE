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

namespace SimPe.Plugin.Tool.Action
{
	/// <summary>
	/// The ReloadFileTable Action
	/// </summary>
	public class ActionDeleteSim : SimPe.Interfaces.IToolAction
	{
		
		#region IToolAction Member

		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (es.Loaded)
				if (Helper.IsNeighborhoodFile(es.LoadedPackage.FileName))
					if (es.Count==1)
						if (es.Items[0].Resource.FileDescriptor.Type == Data.MetaData.SIM_DESCRIPTION_FILE) 
							return true;

			return false;
		}
		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;
			
			SimPe.PackedFiles.Wrapper.ExtSDesc victim = new SimPe.PackedFiles.Wrapper.ExtSDesc();
			victim.ProcessData(e.Items[0].Resource);

			if (Message.Show("Are you sure you want to remove \""+victim.SimName+" "+victim.SimFamilyName+"\" from your Neighborhood? You can not undo this, so make sure you have created a Backup!\n\nDelete the Sim?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No) return;

			uint inst = victim.FileDescriptor.Instance;
			uint guid = victim.SimId;

			DeleteSRels(inst, guid, victim.Package, victim);
			DeleteRelations(inst, guid, victim.Package, victim);
			DeleteRes(0xEBFEE33F, inst, guid, victim.Package, victim); //DNA
			DeleteRes(0xCD95548E, inst, guid, victim.Package, victim); //want & fear
			DeleteFamilyTies(inst, guid, victim.Package, victim);
			DeleteMemories(inst, guid, victim.Package, victim);
			DeleteFamMembers(inst, guid, victim.Package, victim);

			DeleteCharacterFile(inst, guid, victim.Package, victim);

			victim.FileDescriptor.MarkForDelete = true;
		}

		#endregion	

		void DeleteCharacterFile(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			//do not delete for NPCs
			if (victim.IsNPC) return;

			if (System.IO.File.Exists(victim.CharacterFileName)) 
			{				
				if (Message.Show("SimPE can now delete the Character File \""+victim.CharacterFileName+"\" from your System. \n\nShould SimPE delete this File?", "Question", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No) return;
				try 
				{
					SimPe.Packages.StreamItem si = SimPe.Packages.StreamFactory.UseStream(victim.CharacterFileName, System.IO.FileAccess.Read);
					si.Close();

					System.IO.File.Delete(victim.CharacterFileName);

					/*FileTable.ProviderRegistry.SimNameProvider.BaseFolder = null;
					FileTable.ProviderRegistry.SimNameProvider.BaseFolder = System.IO.Path.GetDirectoryName(pkg.SaveFileName);*/
				} 
				catch (Exception ex)
				{
					Helper.ExceptionMessage(ex);
				}
			}
		}
	
		void DeleteSRels(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.RELATION_FILE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				uint up = (pfd.Instance & 0xFFFF0000) >> 16;
				uint low = (pfd.Instance & 0x0000FFFFF);

				if (up==inst || low==inst) pfd.MarkForDelete = true;
			}
		}

		void DeleteRes(uint type, uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(type);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				if (pfd.Instance==inst) pfd.MarkForDelete = true;
			}
		}

		void DeleteFamilyTies(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(0x8C870743);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.PackedFiles.Wrapper.FamilyTies ft = new SimPe.PackedFiles.Wrapper.FamilyTies(null);
				ft.ProcessData(pfd, pkg);

				ArrayList sims = new ArrayList();
				foreach (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim fts in ft.Sims) 
				{
					if (fts.Instance!=inst) 
					{
						sims.Add(fts);

						ArrayList items = new ArrayList();
						foreach (SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem fti in fts.Ties)
						{
							if (fti.Instance!=inst) items.Add(fti);
						}

						fts.Ties = new SimPe.PackedFiles.Wrapper.Supporting.FamilyTieItem[items.Count];
						items.CopyTo(fts.Ties);
					}
				}

				SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim[] fsims = new SimPe.PackedFiles.Wrapper.Supporting.FamilyTieSim[sims.Count];
				sims.CopyTo(fsims);
				
				ft.Sims = fsims;
				

				ft.SynchronizeUserData();
			}
		}

		void DeleteMemories(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(0x4E474248);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.Plugin.Ngbh n = new Ngbh(null);
				n.ProcessData(pfd, pkg);

				SimPe.Plugin.Collections.NgbhSlots slots = new SimPe.Plugin.Collections.NgbhSlots(n);
				foreach (NgbhSlot s in n.Sims)
				{
					if (s.SlotID!=inst) 
					{
						slots.Add(s);
						SimPe.Plugin.Collections.NgbhItems list = new SimPe.Plugin.Collections.NgbhItems(s);
						foreach (NgbhItem i in s.ItemsA)
						{
							if (i.SimID != guid && i.SimInstance!=inst && i.OwnerInstance!=inst) list.Add(i);
						}
						s.ItemsA = list;

						list = new SimPe.Plugin.Collections.NgbhItems(s);
						foreach (NgbhItem i in s.ItemsB)
						{
							if (i.SimID != guid && i.SimInstance!=inst && i.OwnerInstance!=inst) list.Add(i);
						}

						s.ItemsB = list;						
					}
				}	
			
				n.Sims = slots;

				n.SynchronizeUserData();
			}
		}

		void DeleteFamMembers(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(0x46414D49);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				SimPe.PackedFiles.Wrapper.Fami f = new SimPe.PackedFiles.Wrapper.Fami(null);
				f.ProcessData(pfd, pkg);

				
				
				ArrayList list = new ArrayList();
				foreach (uint i in f.Members)
				{
					if (i!= guid ) list.Add(i);
				}

				f.Members= new uint[list.Count];
				list.CopyTo(f.Members);
						

				f.SynchronizeUserData();
			}
		}

		void DeleteRelations(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				if (pfd.Instance==inst) continue;

				ArrayList list = new ArrayList();
				SimPe.PackedFiles.Wrapper.ExtSDesc sdsc = new SimPe.PackedFiles.Wrapper.ExtSDesc();
				sdsc.ProcessData(pfd, pkg);

				foreach (uint i in sdsc.Relations.SimInstances)
					if (i!=inst) list.Add((ushort)i);

				if (list.Count<sdsc.Relations.SimInstances.Length) 
				{
					sdsc.Relations.SimInstances = new ushort[list.Count];
					list.CopyTo(sdsc.Relations.SimInstances);

					sdsc.SynchronizeUserData();
				}
			}
		}

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Delete Sim";
		}
		#endregion

		#region IToolExt Member
		public System.Windows.Forms.Shortcut Shortcut
		{
			get
			{
				return System.Windows.Forms.Shortcut.None;
			}
		}

		public System.Drawing.Image Icon
		{
			get
			{
				return null;
			}
		}

		public virtual bool Visible 
		{
			get {return true;}
		}

		#endregion
	}
}
