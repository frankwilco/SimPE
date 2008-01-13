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
using System.Reflection;
using System.Runtime.CompilerServices;

//
// Allgemeine Informationen über eine Assembly werden über folgende Attribute 
// gesteuert. Ändern Sie diese Attributswerte, um die Informationen zu modifizieren,
// die mit einer Assembly verknüpft sind.
//
[assembly: AssemblyTitle("SimPe - Sim Deleter Tool (by Theo)")]
[assembly: AssemblyCopyright("copyleft")]
[assembly: AssemblyVersion("0.2.0.0")]

namespace SimPe.Plugin.Tool.Action
{
	/// <summary>
	/// The ReloadFileTable Action
	/// </summary>
	public class ActionDeleteSimV2 : SimPe.Interfaces.IToolAction
	{
		bool ofbDeleteScores = true;
		bool deleteDna = false;
		bool deleteInvalidDna = false;
				
		#region IToolAction Member
		public virtual bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
		{
			if (es.Loaded && Helper.IsNeighborhoodFile(es.LoadedPackage.FileName))
				if (es.Count > 0)
				{
					int i = -1;
					while (++i < es.Count)
						if (es.Items[i].Resource.FileDescriptor.Type != Data.MetaData.SIM_DESCRIPTION_FILE)
							return false;
					return true;
				}
			return false;
		}

		public void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
		{
			if (!ChangeEnabledStateEventHandler(null, e)) return;

			if (Message.Show(@"The selected sims will be wiped out of existence! >:D

You MUST commit the changes to the neighborhood after this procedure.
Let's hope you have made a Backup, for there's no returning back past this point...			

Continue?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No) return;
			
			//ofbDeleteScores = (Message.Show("Experimental: Delete the SCOR resources for the selected sims?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
			
			deleteDna = (Message.Show("Delete the DNA of the selected sim(s)?", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);
			if (deleteDna)
				deleteInvalidDna = (Message.Show(@"Delete all orphan DNA records as well?
(Choose 'No' if unsure)", "Warning", System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes);

			int c = 0;
			for (int i = 0; i < e.Items.Count; i++)
			{
				SimPe.PackedFiles.Wrapper.ExtSDesc victim = new SimPe.PackedFiles.Wrapper.ExtSDesc();
				victim.ProcessData(e.Items[i].Resource);

				c += DeleteSim(victim);
			}
			
			if (deleteInvalidDna) {
				DeleteOrphanDna(e.LoadedPackage.Package);
			}
			
			Message.Show(
				string.Format("Done. {0} sim character file(s) deleted", c)
				, "Notice"
				, System.Windows.Forms.MessageBoxButtons.OK
				);

		}

		#endregion	

		int DeleteSim(SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			int ret = 0;
			uint inst = victim.FileDescriptor.Instance;
			uint guid = victim.SimId;
			
			DeleteSRels(inst, guid, victim.Package, victim);
			DeleteRelations(inst, guid, victim.Package, victim);
			DeleteFamilyTies(inst, guid, victim.Package, victim);
			DeleteMemories(inst, guid, victim.Package, victim);
			DeleteFamMembers(inst, guid, victim.Package, victim);
			DeleteRes(0xCD95548E, inst, guid, victim.Package, victim); //want & fear

			if (!victim.IsNPC) {

				if (deleteDna)
					DeleteRes(0xEBFEE33F, inst, guid, victim.Package, victim); //DNA

				if (ofbDeleteScores)
					DeleteRes(0x3053CF74, inst, guid, victim.Package, victim);
				
				ret = DeleteCharacterFile(inst, guid, victim.Package, victim);

				victim.FileDescriptor.MarkForDelete = true;
			}

			return ret;
		}

		int DeleteCharacterFile(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			int ret = 0;
			//do not delete for NPCs
			//if (victim.IsNPC) return;

			if (System.IO.File.Exists(victim.CharacterFileName)) 
			{				
				//if (Message.Show("SimPE can now delete the Character File \""+victim.CharacterFileName+"\" from your System. \n\nShould SimPE delete this File?", "Question", System.Windows.Forms.MessageBoxButtons.YesNo)==System.Windows.Forms.DialogResult.No) return;
				try 
				{
					SimPe.Packages.StreamItem si = SimPe.Packages.StreamFactory.UseStream(victim.CharacterFileName, System.IO.FileAccess.Read);
					si.Close();

					System.IO.File.Delete(victim.CharacterFileName);

					ret++;
					/*FileTable.ProviderRegistry.SimNameProvider.BaseFolder = null;
					FileTable.ProviderRegistry.SimNameProvider.BaseFolder = System.IO.Path.GetDirectoryName(pkg.SaveFileName);*/
				} 
				catch (Exception ex)
				{
					Helper.ExceptionMessage(ex);
				}
			}
			
			return ret;
		}
	
		void DeleteSRels(uint inst, uint guid, SimPe.Interfaces.Files.IPackageFile pkg, SimPe.PackedFiles.Wrapper.ExtSDesc victim)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.RELATION_FILE);
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{
				uint up = (pfd.Instance & 0xFFFF0000u) >> 16;
				uint low = (pfd.Instance & 0x0000FFFFFu);

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

				ArrayList slotsToRemove = new ArrayList();

				//SimPe.Plugin.Collections.NgbhSlots slots = new SimPe.Plugin.Collections.NgbhSlots(n, Data.NeighborhoodSlots.Sims);
				foreach (NgbhSlot s in n.Sims)
				{
					if (s.SlotID == inst)
						slotsToRemove.Add(s); // remove all my memories and tokens ?!
					else
					{
						// process other sims memories and tokens

						ArrayList list = new ArrayList();
						
						foreach (NgbhItem i in s.ItemsA)
							if (
								 i.SimID == guid
							|| i.SimInstance == inst
							|| i.OwnerInstance == inst
								)
								list.Add(i);

						foreach (NgbhItem i in list)
							s.ItemsA.Remove(i);


						list.Clear();

						foreach (NgbhItem i in s.ItemsB)
							if (
								 i.SimID == guid 
							|| i.SimInstance == inst
							|| i.OwnerInstance == inst
								)
								list.Add(i);

						foreach (NgbhItem i in list)
							s.ItemsB.Remove(i);

					}

					/*
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
					 */

				}

				foreach (NgbhSlot s in slotsToRemove)
					n.Sims.Remove(s); 
				//n.Sims = slots;

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
		
		
		void DeleteOrphanDna(SimPe.Interfaces.Files.IPackageFile pkg)
		{
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfdSim = pkg.FindFiles(0xAACE2EFBu); // get the existing SDSC's
			ArrayList simInstances = new ArrayList();
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pSim in pfdSim)
				simInstances.Add(pSim.Instance);
			
			
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfdDna = pkg.FindFiles(0xEBFEE33Fu); // get the existing SDNA's

			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pDna in pfdDna)
				if (!simInstances.Contains(pDna.Instance))
					pDna.MarkForDelete = true;

		}

		
		#region IToolPlugin Member
		public override string ToString()
		{
			return "Delete Sim (by Theo)";
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
