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
        private IContainer components;
		private System.Windows.Forms.Panel pnSims;
		SimPe.PackedFiles.Wrapper.SimPoolControl spc = null;
		private System.Windows.Forms.Panel pnDebug;
		private SimPe.Plugin.NgbhSlotSelection nssel;
		private SimPe.Plugin.NgbhSlotUI nsui;
		private ToolStrip toolBar1;
		private System.Windows.Forms.Panel pnBadge;
		private ToolStripButton biSim;
		private ToolStripButton biBadge;
		private ToolStripButton biDebug;
		private SimPe.Plugin.NgbhSkillHelper shelper;
		private MenuStrip menuBar1;
		private ContextMenuStrip menu;
		private ToolStripMenuItem miNuke;
		private ToolStripMenuItem miFix;
		SimPe.Plugin.NgbhSlotUI simslot = null;		

		public ExtNgbhUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

            toolBar1.Renderer = new SimPe.MediaPlayerRenderer();			

			ThemeManager.AddControl(this.toolBar1);
            ThemeManager.AddControl(this.menu);

			biSim.Tag = pnSims;
			biDebug.Tag = pnDebug;
			biBadge.Tag = pnBadge;
			
			
			biDebug.Visible = Helper.WindowsRegistry.HiddenMode;
			this.SelectButton(biSim);

			biBadge.Enabled = Helper.WindowsRegistry.EPInstalled>=3;

			SimPe.RemoteControl.HookToMessageQueue(0x4E474248, new SimPe.RemoteControl.ControlEvent(ControlEvent));
		}

		protected void ControlEvent(object sender, SimPe.RemoteControl.ControlEventArgs e)
		{			
			object[] os = e.Items as object[];
			if (os!=null) 
			{
				Data.NeighborhoodSlots st = (Data.NeighborhoodSlots)os[1];				
				uint inst = (uint)os[0];

				if (st== Data.NeighborhoodSlots.SimsIntern && biBadge.Enabled) this.ChoosePage(biBadge, null);
				else this.ChoosePage(biSim, null);

				PackedFiles.Wrapper.ExtSDesc sdesc = FileTable.ProviderRegistry.SimDescriptionProvider.FindSim((ushort)inst) as PackedFiles.Wrapper.ExtSDesc;
				bool found = SelectSimByInstance(sdesc);
				
				if (!found && sdesc!=null) 
				{
					spc.SelectHousehold(sdesc.HouseholdName);
					SelectSimByInstance(sdesc);
				}

				spc.Refresh(false);
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtNgbhUI));
            this.pnSims = new System.Windows.Forms.Panel();
            this.menuBar1 = new System.Windows.Forms.MenuStrip();
            this.spc = new SimPe.PackedFiles.Wrapper.SimPoolControl();
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miNuke = new System.Windows.Forms.ToolStripMenuItem();
            this.miFix = new System.Windows.Forms.ToolStripMenuItem();
            this.simslot = new SimPe.Plugin.NgbhSlotUI();
            this.pnDebug = new System.Windows.Forms.Panel();
            this.nsui = new SimPe.Plugin.NgbhSlotUI();
            this.nssel = new SimPe.Plugin.NgbhSlotSelection();
            this.pnBadge = new System.Windows.Forms.Panel();
            this.shelper = new SimPe.Plugin.NgbhSkillHelper();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biSim = new System.Windows.Forms.ToolStripButton();
            this.biBadge = new System.Windows.Forms.ToolStripButton();
            this.biDebug = new System.Windows.Forms.ToolStripButton();
            this.pnSims.SuspendLayout();
            this.menu.SuspendLayout();
            this.pnDebug.SuspendLayout();
            this.pnBadge.SuspendLayout();
            this.toolBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSims
            // 
            this.pnSims.BackColor = System.Drawing.Color.Transparent;
            this.pnSims.Controls.Add(this.menuBar1);
            this.pnSims.Controls.Add(this.spc);
            this.pnSims.Controls.Add(this.simslot);
            this.pnSims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSims.Location = new System.Drawing.Point(0, 76);
            this.pnSims.Name = "pnSims";
            this.pnSims.Size = new System.Drawing.Size(680, 292);
            this.pnSims.TabIndex = 1;
            this.pnSims.Visible = false;
            // 
            // menuBar1
            // 
            this.menuBar1.Location = new System.Drawing.Point(264, 0);
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(416, 21);
            this.menuBar1.TabIndex = 5;
            this.menuBar1.Text = "menuBar1";
            this.menuBar1.Visible = false;
            // 
            // spc
            // 
            this.spc.BackColor = System.Drawing.Color.White;
            this.spc.ContextMenuStrip = this.menu;
            this.spc.Dock = System.Windows.Forms.DockStyle.Left;
            this.spc.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.spc.Location = new System.Drawing.Point(0, 0);
            this.spc.Name = "spc";
            this.spc.Package = null;
            this.spc.Padding = new System.Windows.Forms.Padding(1);
            this.spc.RightClickSelect = false;
            this.spc.SelectedElement = null;
            this.spc.SelectedSim = null;
            this.spc.SimDetails = false;
            this.spc.Size = new System.Drawing.Size(264, 292);
            this.spc.TabIndex = 0;
            this.spc.TileColumns = new int[] {
        1};
            this.spc.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.spc_SelectedSimChanged);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNuke,
            this.miFix});
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(158, 48);
            this.menu.Text = "(context menu)";
            this.menu.VisibleChanged += new System.EventHandler(this.menu_VisibleChanged);
            // 
            // miNuke
            // 
            this.miNuke.Image = ((System.Drawing.Image)(resources.GetObject("miNuke.Image")));
            this.miNuke.Name = "miNuke";
            this.miNuke.Size = new System.Drawing.Size(157, 22);
            this.miNuke.Text = "Nuke Memories";
            this.miNuke.Click += new System.EventHandler(this.miNuke_Activate);
            // 
            // miFix
            // 
            this.miFix.Image = ((System.Drawing.Image)(resources.GetObject("miFix.Image")));
            this.miFix.Name = "miFix";
            this.miFix.Size = new System.Drawing.Size(157, 22);
            this.miFix.Text = "Fix Memories";
            this.miFix.Click += new System.EventHandler(this.miFix_Activate);
            // 
            // simslot
            // 
            this.simslot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.simslot.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.simslot.Location = new System.Drawing.Point(264, 0);
            this.simslot.Name = "simslot";
            this.simslot.NgbhResource = null;
            this.simslot.SimPoolControl = this.spc;
            this.simslot.Size = new System.Drawing.Size(416, 290);
            this.simslot.Slot = null;
            this.simslot.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
            this.simslot.TabIndex = 2;
            // 
            // pnDebug
            // 
            this.pnDebug.Controls.Add(this.nsui);
            this.pnDebug.Controls.Add(this.nssel);
            this.pnDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDebug.Location = new System.Drawing.Point(0, 76);
            this.pnDebug.Name = "pnDebug";
            this.pnDebug.Size = new System.Drawing.Size(680, 292);
            this.pnDebug.TabIndex = 3;
            this.pnDebug.Visible = false;
            // 
            // nsui
            // 
            this.nsui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.nsui.BackColor = System.Drawing.Color.Transparent;
            this.nsui.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.nsui.Location = new System.Drawing.Point(280, 8);
            this.nsui.Name = "nsui";
            this.nsui.NgbhResource = null;
            this.nsui.SimPoolControl = null;
            this.nsui.Size = new System.Drawing.Size(392, 276);
            this.nsui.Slot = null;
            this.nsui.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
            this.nsui.TabIndex = 1;
            // 
            // nssel
            // 
            this.nssel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.nssel.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.nssel.Location = new System.Drawing.Point(8, 8);
            this.nssel.Name = "nssel";
            this.nssel.NgbhResource = null;
            this.nssel.Size = new System.Drawing.Size(264, 276);
            this.nssel.TabIndex = 0;
            this.nssel.SelectedSlotChanged += new System.EventHandler(this.nssel_SelectedSlotChanged);
            // 
            // pnBadge
            // 
            this.pnBadge.Controls.Add(this.shelper);
            this.pnBadge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBadge.Location = new System.Drawing.Point(0, 76);
            this.pnBadge.Name = "pnBadge";
            this.pnBadge.Size = new System.Drawing.Size(680, 292);
            this.pnBadge.TabIndex = 1;
            this.pnBadge.VisibleChanged += new System.EventHandler(this.pnBadge_VisibleChanged);
            // 
            // shelper
            // 
            this.shelper.BackColor = System.Drawing.Color.Transparent;
            this.shelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shelper.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.shelper.Location = new System.Drawing.Point(0, 0);
            this.shelper.Name = "shelper";
            this.shelper.NgbhResource = null;
            this.shelper.Padding = new System.Windows.Forms.Padding(8);
            this.shelper.SimPoolControl = this.spc;
            this.shelper.Size = new System.Drawing.Size(680, 292);
            this.shelper.Slot = null;
            this.shelper.TabIndex = 0;
            this.shelper.ChangedItem += new System.EventHandler(this.shelper_ChangedItem);
            this.shelper.AddedNewItem += new System.EventHandler(this.shelper_AddedNewItem);
            // 
            // toolBar1
            // 
            this.toolBar1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biSim,
            this.biBadge,
            this.biDebug});
            this.toolBar1.Location = new System.Drawing.Point(0, 24);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(680, 52);
            this.toolBar1.TabIndex = 4;
            this.toolBar1.Text = "toolBar1";
            // 
            // biSim
            // 
            this.biSim.Image = ((System.Drawing.Image)(resources.GetObject("biSim.Image")));
            this.biSim.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.biSim.Name = "biSim";
            this.biSim.Size = new System.Drawing.Size(56, 49);
            this.biSim.Text = "Memories";
            this.biSim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.biSim.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biBadge
            // 
            this.biBadge.Image = ((System.Drawing.Image)(resources.GetObject("biBadge.Image")));
            this.biBadge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.biBadge.Name = "biBadge";
            this.biBadge.Size = new System.Drawing.Size(46, 49);
            this.biBadge.Text = "Badges";
            this.biBadge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.biBadge.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biDebug
            // 
            this.biDebug.Image = ((System.Drawing.Image)(resources.GetObject("biDebug.Image")));
            this.biDebug.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.biDebug.Name = "biDebug";
            this.biDebug.Size = new System.Drawing.Size(42, 49);
            this.biDebug.Text = "Debug";
            this.biDebug.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.biDebug.Click += new System.EventHandler(this.ChoosePage);
            // 
            // ExtNgbhUI
            // 
            this.Controls.Add(this.pnSims);
            this.Controls.Add(this.pnBadge);
            this.Controls.Add(this.pnDebug);
            this.Controls.Add(this.toolBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HeaderText = "Neighborhood and Sim Memory Editor";
            this.Name = "ExtNgbhUI";
            this.Size = new System.Drawing.Size(680, 368);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.pnDebug, 0);
            this.Controls.SetChildIndex(this.pnBadge, 0);
            this.Controls.SetChildIndex(this.pnSims, 0);
            this.pnSims.ResumeLayout(false);
            this.pnSims.PerformLayout();
            this.menu.ResumeLayout(false);
            this.pnDebug.ResumeLayout(false);
            this.pnBadge.ResumeLayout(false);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
			this.nssel.NgbhResource = Ngbh;
			this.shelper.NgbhResource = Ngbh;
		}

		public override void OnCommit()
		{
			Ngbh.SynchronizeUserData(true, false);
		}

		public void SelectButton(ToolStripButton b)
		{
			for (int i=0; i<this.toolBar1.Items.Count; i++)
			{
				if (toolBar1.Items[i] is ToolStripButton ) 
				{
					ToolStripButton item = (ToolStripButton )toolBar1.Items[i];
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
			SelectButton((ToolStripButton)sender);

			if (pnSims.Visible) pnSims.Controls.Add(this.spc);
			else if (pnBadge.Visible) pnBadge.Controls.Add(this.spc);
		}

		private void spc_SelectedSimChanged(object sender, System.Drawing.Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
/*			if (sdesc!=null)
				lbName.Text = sdesc.SimName+" "+sdesc.SimFamilyName;
			else
				lbName.Text = SimPe.Localization.GetString("Unknown");*/
		}

		private void nssel_SelectedSlotChanged(object sender, System.EventArgs e)
		{
			nsui.Slot = nssel.SelectedSlot;
		}

		bool updateitems;
		private void shelper_AddedNewItem(object sender, System.EventArgs e)
		{
			updateitems = true;
		}
		private void shelper_ChangedItem(object sender, System.EventArgs e)
		{
			updateitems = true;
		}

		protected void RefreshContent()
		{
			nsui.Refresh();
			simslot.Refresh();
		}

		private void pnBadge_VisibleChanged(object sender, System.EventArgs e)
		{
			if (pnBadge.Visible == true) updateitems=false;
			else if (updateitems)				
				RefreshContent();			
			
		}

		#region Extensions by Theo
        void menu_VisibleChanged(object sender, EventArgs e)
        {
            miFix.Enabled = (this.Ngbh != null) && Helper.WindowsRegistry.HiddenMode;
            miNuke.Enabled = (spc.SelectedSim != null);	
        }

		private void miNuke_Activate(object sender, System.EventArgs e)
		{
			if (spc.SelectedSim != null) 
			{
				Collections.NgbhSlots slots = this.Ngbh.GetSlots(Data.NeighborhoodSlots.Sims);
				if (slots!=null) 
				{
					NgbhSlot slot = slots.GetInstanceSlot(spc.SelectedSim.Instance);
					if (slot!=null)
					{
						slot.RemoveMyMemories();
						int deletedCount = slot.RemoveMemoriesAboutMe();

						if (deletedCount > 0)					
							Message.Show(String.Format("Deleted {0} memories from the sim pool", deletedCount));
					
						spc.Refresh();
					}
				}
			}
		}		

		private void miFix_Activate(object sender, System.EventArgs e)
		{
			EnhancedNgbh ngbh = this.Ngbh as EnhancedNgbh;
			if (ngbh!=null) 
			{
				ngbh.FixNeighborhoodMemories();
				this.RefreshGUI();
			}
		}
		#endregion				
	}
}
