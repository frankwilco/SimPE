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
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;
using SimPe.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ExtNgbhUI.
	/// </summary>
	public class ExtNgbhUI : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private TD.SandBar.ButtonItem biSim;
		private System.Windows.Forms.Panel pnSims;
		private TD.SandBar.ToolBar toolBar1 = null;
		SimPe.PackedFiles.Wrapper.SimPoolControl spc = null;
		SimPe.Plugin.NgbhSlotUI simslot = null;		

		public ExtNgbhUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			toolBar1.Renderer = new TD.SandBar.MediaPlayerRenderer();
			toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Chevron;

			ThemeManager.AddControl(this.toolBar1);

			biSim.Tag = pnSims;

			this.SelectButton(biSim);

			SimPe.RemoteControl.HookToMessageQueue(0x4E474248, new SimPe.RemoteControl.ControlEvent(ControlEvent));
		}

		protected void ControlEvent(object sender, SimPe.RemoteControl.ControlEventArgs e)
		{			
			object[] os = e.Items as object[];
			if (os!=null) 
			{
				Data.NeighborhoodSlots st = (Data.NeighborhoodSlots)os[1];
				uint inst = (uint)os[0];
				PackedFiles.Wrapper.ExtSDesc sdesc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim((ushort)inst) as PackedFiles.Wrapper.ExtSDesc;
				bool found = SelectSimByInstance(sdesc);
				
				if (!found && sdesc!=null) 
				{
					spc.SelectHousehold(sdesc.HouseholdName);
					SelectSimByInstance(sdesc);
				}

				spc.Refresh();
			}			
		}

		protected bool SelectSimByInstance(PackedFiles.Wrapper.SDesc sdesc)
		{
			bool ret = false;
			if (sdesc!=null) 
			{
				spc.SelectedElement = sdesc;
				if (spc.SelectedElement!=null) return true;
			}
			/*foreach (ListViewItem lvi in this.spc.Items)
			{					
				PackedFiles.Wrapper.SDesc sdesc = lvi.Tag as PackedFiles.Wrapper.SDesc;
				if (sdesc.FileDescriptor.Instance == inst) 
				{
					ret = true;
					lvi.Selected = true;
					lvi.EnsureVisible();						
				} 
				else lvi.Selected = false;
			}*/

			return ret;
		}


		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExtNgbhUI));
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biSim = new TD.SandBar.ButtonItem();
			this.pnSims = new System.Windows.Forms.Panel();
			this.spc = new SimPe.PackedFiles.Wrapper.SimPoolControl();
			this.simslot = new SimPe.Plugin.NgbhSlotUI();
			this.pnSims.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.Guid = new System.Guid("b44e0b10-4a13-4d0c-bf2f-c2861b6b05ce");
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biSim});
			this.toolBar1.Location = new System.Drawing.Point(0, 24);
			this.toolBar1.Movable = false;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Resizable = false;
			this.toolBar1.Size = new System.Drawing.Size(680, 54);
			this.toolBar1.TabIndex = 0;
			this.toolBar1.Tearable = false;
			this.toolBar1.TextAlign = TD.SandBar.ToolBarTextAlign.Underneath;
			// 
			// biSim
			// 
			this.biSim.Image = ((System.Drawing.Image)(resources.GetObject("biSim.Image")));
			this.biSim.MinimumSize = 50;
			this.biSim.Text = "Sims";
			this.biSim.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// pnSims
			// 
			this.pnSims.BackColor = System.Drawing.Color.Transparent;
			this.pnSims.Controls.Add(this.spc);
			this.pnSims.Controls.Add(this.simslot);
			this.pnSims.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnSims.Location = new System.Drawing.Point(0, 78);
			this.pnSims.Name = "pnSims";
			this.pnSims.Size = new System.Drawing.Size(680, 290);
			this.pnSims.TabIndex = 1;
			this.pnSims.Visible = false;
			// 
			// spc
			// 
			this.spc.BackColor = System.Drawing.Color.White;
			this.spc.Dock = System.Windows.Forms.DockStyle.Left;
			this.spc.DockPadding.All = 1;
			this.spc.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.spc.Location = new System.Drawing.Point(0, 0);
			this.spc.Name = "spc";
			this.spc.Package = null;
			this.spc.SelectedElement = null;
			this.spc.SelectedSim = null;
			this.spc.Size = new System.Drawing.Size(264, 290);
			this.spc.TabIndex = 0;
			this.spc.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.spc_SelectedSimChanged);
			// 
			// simslot
			// 
			this.simslot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.simslot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.simslot.Location = new System.Drawing.Point(264, 0);
			this.simslot.Name = "simslot";
			this.simslot.NgbhResource = null;
			this.simslot.SimPoolControl = this.spc;
			this.simslot.Size = new System.Drawing.Size(416, 288);
			this.simslot.Slot = null;
			this.simslot.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
			this.simslot.TabIndex = 2;
			// 
			// ExtNgbhUI
			// 
			this.Controls.Add(this.pnSims);
			this.Controls.Add(this.toolBar1);
			this.DockPadding.Top = 24;
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.HeaderText = "Neighborhood and Sim Memory Editor";
			this.Name = "ExtNgbhUI";
			this.Size = new System.Drawing.Size(680, 368);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.pnSims, 0);
			this.pnSims.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public ExtNgbh Ngbh
		{
			get { return (ExtNgbh)Wrapper; }
		}

		protected override void RefreshGUI()
		{
			simslot.NgbhResource = Ngbh;
			spc_SelectedSimChanged(spc, null, null);
			spc.Package = Ngbh.Package;				
		}

		public override void OnCommit()
		{
			Ngbh.SynchronizeUserData(true, false);
		}

		public void SelectButton(TD.SandBar.ButtonItem b)
		{
			for (int i=0; i<this.toolBar1.Items.Count; i++)
			{
				if (toolBar1.Items[i] is TD.SandBar.ButtonItem ) 
				{
					TD.SandBar.ButtonItem item = (TD.SandBar.ButtonItem )toolBar1.Items[i];
					item.Checked = (item==b);
					
					if (item.Tag!=null) 
					{
						Panel pn = (Panel)item.Tag;
						pn.Visible = item.Checked;
					}
				}
			}

			UpdateEnabledState();
		}

		void UpdateEnabledState()
		{
		}
		
		private void ChoosePage(object sender, System.EventArgs e)
		{
			SelectButton((TD.SandBar.ButtonItem)sender);
		}

		private void spc_SelectedSimChanged(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
/*			if (sdesc!=null)
				lbName.Text = sdesc.SimName+" "+sdesc.SimFamilyName;
			else
				lbName.Text = SimPe.Localization.GetString("Unknown");*/
		}
	}
}
