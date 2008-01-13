
#region Copyright Notice
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
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using SimPe.Interfaces;
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Plugin;
using SimPe.PackedFiles.Wrapper;
using SimPe.Plugin.Properties;
using SimPe.Packages;
using SimPe.Data;
using System.Collections;
using Ambertation;
using System.Collections.Specialized;
using SimPe.Plugin.Helper;
using SimPe.Plugin.Surgery;
using System.Reflection;
using SimPe.Plugin.Wrapper;
using SimPe.Plugin.UI.Controls;


namespace SimPe.Plugin.UI
{

	public partial class SurgeryForm : Form
	{
		IPackedFileDescriptor pfd;
		IPackageFile ngbh;
		IProviderRegistry prov;

		OperationRoom surgery;

		SkinDatabase skins;
		EyeDatabase eyes;

		/*
		SkinInfo selectedSkintone;
		SkinItem selectedEyecolor;
		 */

		public IPackageFile NeighborhoodPackage
		{
			get { return this.ngbh; }
			set { this.ngbh = value; }
		}

		public IProviderRegistry ProviderRegistry
		{
			get { return this.prov; }
			set { this.prov = value; }
		}

		public SkinDatabase SkinFiles
		{
			get
			{
				if (this.skins == null)
					this.skins = new SkinDatabase();
				return this.skins; 
			}
		}

		public EyeDatabase EyeFiles
		{
			get
			{
				if (this.eyes == null)
					this.eyes = new EyeDatabase();
				return this.eyes;
			}
		}


		public SurgeryForm()
		{
			InitializeComponent();

			this.skinSelector.CreatePackageBrowser += new EventHandler<ObjectBuilderEventArgs<PackageBrowser>>(skinSelector_CreatePackageBrowser);
			this.eyeSelector.CreatePackageBrowser += new EventHandler<ObjectBuilderEventArgs<PackageBrowser>>(eyeSelector_CreatePackageBrowser);
		}

		public IToolResult Execute(ref IPackedFileDescriptor pfd, ref IPackageFile package, IProviderRegistry prov)
		{
			this.Cursor = Cursors.WaitCursor;

			this.pfd = null;
			this.prov = prov;
			this.ngbh = package;

			this.pbArchetype.Image = null;
			this.pbPatient.Image = null;

			this.surgery = new OperationRoom();
			this.surgery.NeighborhoodPackage = this.ngbh;

			this.surgery.Procedures.AddRange(this.GetSurgeryProcedures());

			this.surgery.ProcedureRun += new EventHandler(surgery_ProcedureRun);

			this.SetupOptions();
			this.UpdateState();

			this.Cursor = Cursors.Default;

			WaitingScreen.Stop(this);
			RemoteControl.ShowSubForm(this);

			if (this.pfd != null)
				pfd = this.pfd;

			return new ToolResult((this.pfd != null), false);
		}



		void SetupOptions()
		{
			foreach (IProcedure p in this.surgery.Procedures)
				this.cblOptions.Items.Add(p, p.Enabled);
		}

		List<IProcedure> GetSurgeryProcedures()
		{
			List<IProcedure> ret = new List<IProcedure>();
			Assembly a = Assembly.GetExecutingAssembly();
			Type[] types = a.GetTypes();
			foreach (Type type in types)
			{
				if (
					type.IsSubclassOf(typeof(Procedure)) &&
					type.IsPublic &&
					!type.IsAbstract
					)
				{
					try
					{
						IProcedure p = (IProcedure)type.InvokeMember("", BindingFlags.CreateInstance, null, null, null);
						ret.Add(p);
					}
					catch
					{
					}
				}
			}

			return ret;
		}

		private SDesc OpenSim()
		{
			SDesc sim = null;
			IPackedFileDescriptor pfdSim = null;
			SimBrowser simBrowser = new SimBrowser();
			simBrowser.Text = "Sims Browser";
			IToolResult result = simBrowser.Execute(ref pfdSim, ref this.ngbh, this.prov);
			if (result.ChangedFile)
			{
				sim = simBrowser.SelectedSim;
			}
			return sim;
		}

		void ShowSimDetails(ExtSDesc sim, PropertyGrid pg)
		{
			File package = File.LoadFromFile(sim.CharacterFileName);
			if (package != null)
			{
				IPackedFileDescriptor pfdAged = package.FindFile(Utility.DataType.AGED, 0, MetaData.LOCAL_GROUP, 1);
				if (pfdAged != null)
				{
					Cpf aged = new Cpf();
					aged.ProcessData(pfdAged, package, true);

					SimInfo nfo = new SimInfo(aged, System.IO.Path.GetFileName(sim.CharacterFileName), String.Format("{0} {1}", sim.SimName, sim.SimFamilyName));
					pg.SelectedObject = nfo;
				}
			}
		}

		void ShowSimDetails(File package, PropertyGrid pg)
		{
			
			IPackedFileDescriptor pfdAged = package.FindFile(Utility.DataType.AGED, 0, MetaData.LOCAL_GROUP, 1);
			if (pfdAged != null)
			{
				Cpf aged = new Cpf();
				aged.ProcessData(pfdAged, package, true);

				SimInfo nfo = new SimInfo(aged, System.IO.Path.GetFileName(package.FileName), null);
				pg.SelectedObject = nfo;
			}

		}


		public void PerformSurgery()
		{
			// TODO: get rid of ugly code
			foreach (Procedure p in this.surgery.Procedures)
			{
				if (p is CloneSkin)
					p.FileDatabase = this.SkinFiles;

				if (p is CloneEyes)
					p.FileDatabase = this.EyeFiles;
			}

			this.ssProgress.Visible = true;

			this.surgery.PerformSurgery();

			this.ssProgress.Visible = false;

			bool cont = true;

			if (this.surgery.EventLog.Count > 0)
			{
				// show the errors, and ask if we should continue;
				// maybe I shouldn't do UI code :P
				// TODO: Localize messages
				Form msg = new Form();
				msg.SuspendLayout();
				msg.FormBorderStyle = FormBorderStyle.SizableToolWindow;
				msg.Text = "Warning";
				msg.Size = new Size(380, 240);

				WarningPanel panel = new WarningPanel();
				msg.Controls.Add(panel);
				panel.Location = new Point(0, 0);
				panel.Dock = DockStyle.Fill;
				panel.Lines = this.surgery.EventLog.GetMessages(true);
				panel.Question = "Should Sim Surgery continue and save this sim, or cancel the action?";
				panel.Title = "Error while performing surgery";

				msg.ResumeLayout();

				if (msg.ShowDialog(this) == DialogResult.Cancel)
					cont = false;
			}

#if !DEBUG
			cont = false;
#endif

			if (cont)
			{
				surgery.PatientSimPackage.Save(surgery.PatientSim.CharacterFileName);
				this.prov.SimNameProvider.StoredData = null;
			}
	
		
		}


		void SetProcedureItem<T>(GenericCpfInfo item) where T : IProcedure
		{
			int i = -1;
			while (++i < this.cblOptions.Items.Count)
			{
				IProcedure p = (IProcedure)this.cblOptions.Items[i];
				if (p.GetType() == typeof(T))
				{
					this.surgery.SetCustomItem(p, item);

					// oops, seems we may run into de-syncing here :o
					// the list of procedures actually means the
					// procedures that will run, not only the items that 
					// will be copied from the archetype
					this.cblOptions.SetItemChecked(i, (item != null));

					break;
				}
			}
		}

		/// <remarks>
		/// I should really stop doing UI code :P
		/// </remarks>
		void surgery_ProcedureRun(object sender, EventArgs e)
		{
			int inc = this.ssProgress.Maximum / this.surgery.Procedures.Count;
			this.ssProgress.Increment(inc);
		}

		void UpdateState()
		{
			this.surgery.EventLog.Clear();

			bool canDo = this.surgery.CanPerform();
			this.btOK.Enabled = canDo;
			bool hasPatient = (this.surgery.PatientSimPackage != null);

			this.lnkExportPackage.Enabled = hasPatient;
			this.gbQuickChange.Enabled = hasPatient;

			bool hasArchetype = (this.surgery.ArchetypeSimPackage != null);
			this.gbOptions.Enabled = hasArchetype;

			// TODO: Localize messages
			if (canDo)
			{
				this.ssLabel.Text = "Ready";
				this.ssLabel.ToolTipText = String.Empty;
			}
			else
			{
				this.ssLabel.Text = "Check requirements";
				this.ssLabel.ToolTipText = String.Join(Environment.NewLine, this.surgery.EventLog.GetMessages(false));
			}
	

		}

		#region Event Handlers

		/*
		 * Select Patient Sim
		 */
		private void lnkSelectPatientSim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SDesc sim = this.OpenSim();
			if (sim != null)
			{
				this.surgery.PatientSim = sim;

				File package = File.LoadFromFile(sim.CharacterFileName);
				if (package != null)
					this.surgery.PatientSimPackage = package;

				this.pbPatient.Image = ImageLoader.Preview(sim.Image, this.pbPatient.Size);

				this.pfd = sim.FileDescriptor;

				if (sim is ExtSDesc)
					this.ShowSimDetails((ExtSDesc)sim, this.pgPatientDetails);

				for (int i = 0; i < this.cblOptions.Items.Count; i++)
					this.cblOptions.SetItemChecked(i, false);

				this.UpdateState();
			}

			
		}


		/*
		 * Select Archetype Sim
		 */
		private void lnkSelectArchetypeSim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SDesc sim = this.OpenSim();
			if (sim != null)
			{
				this.surgery.ArchetypeSim = sim;

				File package = File.LoadFromFile(sim.CharacterFileName);
				if (package != null)
					this.surgery.ArchetypeSimPackage = package;

				this.pbArchetype.Image = ImageLoader.Preview(sim.Image, this.pbArchetype.Size);

				if (sim is ExtSDesc)
					this.ShowSimDetails((ExtSDesc)sim, this.pgArchetypeDetails);

				for (int i = 0; i < this.cblOptions.Items.Count; i++)
					this.cblOptions.SetItemChecked(i, true);

				this.UpdateState();

			}

		}


		/*
		 * Load Archetype Package
		 */
		private void lnkLoadPackage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.dlgOpenPackage.ShowDialog();
		}
		
		private void dlgOpenPackage_FileOk(object sender, CancelEventArgs e)
		{
			File template = File.LoadFromFile(this.dlgOpenPackage.FileName);
			if (Utility.CheckArchetypeFile(template))
			{
				this.surgery.ArchetypeSimPackage = template;

				this.pbArchetype.Image = ImageLoader.Preview(Resources.MrPearhead, this.pbArchetype.Size);

				this.ShowSimDetails(template, this.pgArchetypeDetails);

				this.UpdateState();
			}
			else
			{
				// TODO: Localize message
				SimPe.Helper.ExceptionMessage("The selected template file is not valid.", new ApplicationException());
				return;
			}
		}


		/*
		 * Export Sim
		 */
		private void lnkExportPackage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			SDesc patient = this.surgery.PatientSim;
			if (patient != null)
			{
				dlgSavePackage.InitialDirectory = System.IO.Path.Combine(SimPe.Helper.WindowsRegistry.SimSavegameFolder, "SavedSims");
				dlgSavePackage.FileName = System.IO.Path.GetFileNameWithoutExtension(patient.CharacterFileName);

				dlgSavePackage.ShowDialog();
			}

		}
		
		private void dlgSavePackage_FileOk(object sender, CancelEventArgs e)
		{
			File template = this.surgery.GenerateTemplate(); //.ExportSim(this.surgery.PatientSim);
			if (template != null)
				template.Save(dlgSavePackage.FileName);
		}


		/*
		 * Select Skintone
		 */
		private void skinSelector_SelectedItemChanged(object sender, EventArgs e)
		{
			this.SetProcedureItem<CloneSkin>(this.skinSelector.SelectedItem);
			this.UpdateState();
		}

		void skinSelector_CreatePackageBrowser(object sender, ObjectBuilderEventArgs<PackageBrowser> e)
		{
			e.Object = new SkinBrowser(this.SkinFiles);
		}


		/*
		 * Select Eyecolor
		 */
		private void eyeSelector_SelectedItemChanged(object sender, EventArgs e)
		{
			this.SetProcedureItem<CloneEyes>(this.eyeSelector.SelectedItem);
			this.UpdateState();
		}

		void eyeSelector_CreatePackageBrowser(object sender, ObjectBuilderEventArgs<PackageBrowser> e)
		{
			e.Object = new EyeBrowser(this.EyeFiles);
		}


		/*
		 * Perform Surgery
		 */
		private void btOK_Click(object sender, EventArgs e)
		{
			this.PerformSurgery();
			//this.Close();
		}


		/*
		 * Cancel Surgery
		 */
		private void btCancel_Click(object sender, EventArgs e)
		{
			this.pfd = null;
			this.Close();
		}

		private void SurgeryForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.pfd = null;
		}


		/*
		 * Surgery Procedure List
		 */
		private void cblOptions_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue != e.CurrentValue)
			{
				ListBox lb = (ListBox)sender;
				IProcedure p = (IProcedure)lb.Items[e.Index];
				p.Enabled = (e.NewValue == CheckState.Checked);
			}
		}

		#endregion









	}

}