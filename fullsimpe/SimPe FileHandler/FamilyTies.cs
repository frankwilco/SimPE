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
using System.Drawing;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// handles Packed XmlFiles
	/// </summary>
	public class FamilyTies : UIBase, IPackedFileUI
	{
		protected void ResetPanel(Wrapper.FamilyTies famt)
		{
			form.cballtieablesims.Items.Clear();			
			form.cballtieablesims.Sorted = false;
			Interfaces.Files.IPackedFileDescriptor[] pfds = famt.Package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(famt.NameProvider, null, null);
			foreach (Interfaces.Files.IPackedFileDescriptor pfd in pfds) 
			{
				Wrapper.Supporting.FamilyTieSim fts = new FamilyTieSim((ushort)pfd.Instance, null, famt);
				form.cballtieablesims.Items.Add(fts);
			}
			
			form.cballtieablesims.Sorted = true;

			form.cbtietype.Items.Clear();
			form.cbtietype.Items.Add(new LocalizedFamilyTieTypes(Data.MetaData.FamilyTieTypes.MyMotherIs));
			form.cbtietype.Items.Add(new LocalizedFamilyTieTypes(Data.MetaData.FamilyTieTypes.MyFatherIs));
			form.cbtietype.Items.Add(new LocalizedFamilyTieTypes(Data.MetaData.FamilyTieTypes.ImMarriedTo));
			form.cbtietype.Items.Add(new LocalizedFamilyTieTypes(Data.MetaData.FamilyTieTypes.MySiblingIs));
			form.cbtietype.Items.Add(new LocalizedFamilyTieTypes(Data.MetaData.FamilyTieTypes.MyChildIs));
			form.cbtietype.SelectedIndex = 2;

			form.btaddtie.Enabled = false;
			form.btdeletetie.Enabled = false;
			form.btnewtie.Enabled = false;

			form.lbties.Items.Clear();
		}

		#region IPackedFileHandler Member

		public Control GUIHandle
		{
			get 
			{
				return form.familytiePanel;
			}
		}

		public void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper)
		{
			Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
			form.wrapper = famt;
			ResetPanel(famt);
			
			FamilyTieSim[] sims = famt.Sims;
			form.cbtiesims.Items.Clear();
			//form.cbtiesims.Sorted = false;
			foreach(FamilyTieSim sim in sims) 
			{
				form.cbtiesims.Items.Add(sim);
			}
			//form.cbtiesims.Sorted = true;
		}

		
		#endregion		
	}
}
