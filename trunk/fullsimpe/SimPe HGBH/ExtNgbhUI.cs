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
		private System.Windows.Forms.Panel pnSims;
		SimPe.PackedFiles.Wrapper.SimPoolControl spc = null;
		private System.Windows.Forms.Panel pnDebug;
		private SimPe.Plugin.NgbhSlotSelection nssel;
		private SimPe.Plugin.NgbhSlotUI nsui;
		private TD.SandBar.ToolBar toolBar1;
		private System.Windows.Forms.Panel pnBadge;
		private TD.SandBar.ButtonItem biSim;
		private TD.SandBar.ButtonItem biBadge;
		private TD.SandBar.ButtonItem biDebug;
		private SimPe.Plugin.NgbhSkillHelper shelper;
		private TD.SandBar.MenuBar menuBar1;
		private TD.SandBar.ContextMenuBarItem menu;
		private TD.SandBar.MenuButtonItem miNuke;
		private TD.SandBar.MenuButtonItem miFix;
		SimPe.Plugin.NgbhSlotUI simslot = null;		

		public ExtNgbhUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			toolBar1.Renderer = new TD.SandBar.MediaPlayerRenderer();
			toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Chevron;

			ThemeManager.AddControl(this.toolBar1);

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
			this.pnSims = new System.Windows.Forms.Panel();
			this.menuBar1 = new TD.SandBar.MenuBar();
			this.spc = new SimPe.PackedFiles.Wrapper.SimPoolControl();
			this.menu = new TD.SandBar.ContextMenuBarItem();
			this.miNuke = new TD.SandBar.MenuButtonItem();
			this.miFix = new TD.SandBar.MenuButtonItem();
			this.simslot = new SimPe.Plugin.NgbhSlotUI();
			this.pnDebug = new System.Windows.Forms.Panel();
			this.nsui = new SimPe.Plugin.NgbhSlotUI();
			this.nssel = new SimPe.Plugin.NgbhSlotSelection();
			this.pnBadge = new System.Windows.Forms.Panel();
			this.shelper = new SimPe.Plugin.NgbhSkillHelper();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biSim = new TD.SandBar.ButtonItem();
			this.biBadge = new TD.SandBar.ButtonItem();
			this.biDebug = new TD.SandBar.ButtonItem();
			this.pnSims.SuspendLayout();
			this.pnDebug.SuspendLayout();
			this.pnBadge.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnSims
			// 
			this.pnSims.AccessibleDescription = resources.GetString("pnSims.AccessibleDescription");
			this.pnSims.AccessibleName = resources.GetString("pnSims.AccessibleName");
			this.pnSims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSims.Anchor")));
			this.pnSims.AutoScroll = ((bool)(resources.GetObject("pnSims.AutoScroll")));
			this.pnSims.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSims.AutoScrollMargin")));
			this.pnSims.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSims.AutoScrollMinSize")));
			this.pnSims.BackColor = System.Drawing.Color.Transparent;
			this.pnSims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSims.BackgroundImage")));
			this.pnSims.Controls.Add(this.menuBar1);
			this.pnSims.Controls.Add(this.spc);
			this.pnSims.Controls.Add(this.simslot);
			this.pnSims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSims.Dock")));
			this.pnSims.Enabled = ((bool)(resources.GetObject("pnSims.Enabled")));
			this.pnSims.Font = ((System.Drawing.Font)(resources.GetObject("pnSims.Font")));
			this.pnSims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSims.ImeMode")));
			this.pnSims.Location = ((System.Drawing.Point)(resources.GetObject("pnSims.Location")));
			this.pnSims.Name = "pnSims";
			this.pnSims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSims.RightToLeft")));
			this.pnSims.Size = ((System.Drawing.Size)(resources.GetObject("pnSims.Size")));
			this.pnSims.TabIndex = ((int)(resources.GetObject("pnSims.TabIndex")));
			this.pnSims.Text = resources.GetString("pnSims.Text");
			this.pnSims.Visible = ((bool)(resources.GetObject("pnSims.Visible")));
			// 
			// menuBar1
			// 
			this.menuBar1.AccessibleDescription = resources.GetString("menuBar1.AccessibleDescription");
			this.menuBar1.AccessibleName = resources.GetString("menuBar1.AccessibleName");
			this.menuBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("menuBar1.Anchor")));
			this.menuBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBar1.BackgroundImage")));
			this.menuBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("menuBar1.Dock")));
			this.menuBar1.Enabled = ((bool)(resources.GetObject("menuBar1.Enabled")));
			this.menuBar1.Font = ((System.Drawing.Font)(resources.GetObject("menuBar1.Font")));
			this.menuBar1.Guid = new System.Guid("8f2975d2-7ee6-4ad8-a586-fde678c08339");
			this.menuBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuBar1.ImeMode")));
			this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.menu});
			this.menuBar1.Location = ((System.Drawing.Point)(resources.GetObject("menuBar1.Location")));
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.OwnerForm = null;
			this.menuBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuBar1.RightToLeft")));
			this.menuBar1.Size = ((System.Drawing.Size)(resources.GetObject("menuBar1.Size")));
			this.menuBar1.TabIndex = ((int)(resources.GetObject("menuBar1.TabIndex")));
			this.menuBar1.Text = resources.GetString("menuBar1.Text");
			this.menuBar1.Visible = ((bool)(resources.GetObject("menuBar1.Visible")));
			// 
			// spc
			// 
			this.spc.AccessibleDescription = resources.GetString("spc.AccessibleDescription");
			this.spc.AccessibleName = resources.GetString("spc.AccessibleName");
			this.spc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("spc.Anchor")));
			this.spc.AutoScroll = ((bool)(resources.GetObject("spc.AutoScroll")));
			this.spc.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("spc.AutoScrollMargin")));
			this.spc.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("spc.AutoScrollMinSize")));
			this.spc.BackColor = System.Drawing.Color.White;
			this.spc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("spc.BackgroundImage")));
			this.spc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("spc.Dock")));
			this.spc.DockPadding.All = 1;
			this.spc.Enabled = ((bool)(resources.GetObject("spc.Enabled")));
			this.spc.Font = ((System.Drawing.Font)(resources.GetObject("spc.Font")));
			this.spc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("spc.ImeMode")));
			this.spc.Location = ((System.Drawing.Point)(resources.GetObject("spc.Location")));
			this.spc.Name = "spc";
			this.spc.Package = null;
			this.spc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("spc.RightToLeft")));
			this.menuBar1.SetSandBarMenu(this.spc, this.menu);
			this.spc.SelectedElement = null;
			this.spc.SelectedSim = null;
			this.spc.Size = ((System.Drawing.Size)(resources.GetObject("spc.Size")));
			this.spc.TabIndex = ((int)(resources.GetObject("spc.TabIndex")));
			this.spc.Visible = ((bool)(resources.GetObject("spc.Visible")));
			this.spc.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.spc_SelectedSimChanged);
			// 
			// menu
			// 
			this.menu.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																		  this.miNuke,
																		  this.miFix});
			this.menu.Text = resources.GetString("menu.Text");
			this.menu.ToolTipText = resources.GetString("menu.ToolTipText");
			this.menu.BeforePopup += new TD.SandBar.MenuItemBase.BeforePopupEventHandler(this.menu_BeforePopup);
			// 
			// miNuke
			// 
			this.miNuke.Image = ((System.Drawing.Image)(resources.GetObject("miNuke.Image")));
			this.miNuke.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNuke.Shortcut")));
			this.miNuke.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNuke.Shortcut2")));
			this.miNuke.Text = resources.GetString("miNuke.Text");
			this.miNuke.ToolTipText = resources.GetString("miNuke.ToolTipText");
			this.miNuke.Activate += new System.EventHandler(this.miNuke_Activate);
			// 
			// miFix
			// 
			this.miFix.Image = ((System.Drawing.Image)(resources.GetObject("miFix.Image")));
			this.miFix.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miFix.Shortcut")));
			this.miFix.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miFix.Shortcut2")));
			this.miFix.Text = resources.GetString("miFix.Text");
			this.miFix.ToolTipText = resources.GetString("miFix.ToolTipText");
			this.miFix.Activate += new System.EventHandler(this.miFix_Activate);
			// 
			// simslot
			// 
			this.simslot.AccessibleDescription = resources.GetString("simslot.AccessibleDescription");
			this.simslot.AccessibleName = resources.GetString("simslot.AccessibleName");
			this.simslot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("simslot.Anchor")));
			this.simslot.AutoScroll = ((bool)(resources.GetObject("simslot.AutoScroll")));
			this.simslot.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("simslot.AutoScrollMargin")));
			this.simslot.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("simslot.AutoScrollMinSize")));
			this.simslot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simslot.BackgroundImage")));
			this.simslot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("simslot.Dock")));
			this.simslot.Enabled = ((bool)(resources.GetObject("simslot.Enabled")));
			this.simslot.Font = ((System.Drawing.Font)(resources.GetObject("simslot.Font")));
			this.simslot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("simslot.ImeMode")));
			this.simslot.Location = ((System.Drawing.Point)(resources.GetObject("simslot.Location")));
			this.simslot.Name = "simslot";
			this.simslot.NgbhResource = null;
			this.simslot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("simslot.RightToLeft")));
			this.simslot.SimPoolControl = this.spc;
			this.simslot.Size = ((System.Drawing.Size)(resources.GetObject("simslot.Size")));
			this.simslot.Slot = null;
			this.simslot.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
			this.simslot.TabIndex = ((int)(resources.GetObject("simslot.TabIndex")));
			this.simslot.Visible = ((bool)(resources.GetObject("simslot.Visible")));
			// 
			// pnDebug
			// 
			this.pnDebug.AccessibleDescription = resources.GetString("pnDebug.AccessibleDescription");
			this.pnDebug.AccessibleName = resources.GetString("pnDebug.AccessibleName");
			this.pnDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnDebug.Anchor")));
			this.pnDebug.AutoScroll = ((bool)(resources.GetObject("pnDebug.AutoScroll")));
			this.pnDebug.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnDebug.AutoScrollMargin")));
			this.pnDebug.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnDebug.AutoScrollMinSize")));
			this.pnDebug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnDebug.BackgroundImage")));
			this.pnDebug.Controls.Add(this.nsui);
			this.pnDebug.Controls.Add(this.nssel);
			this.pnDebug.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnDebug.Dock")));
			this.pnDebug.Enabled = ((bool)(resources.GetObject("pnDebug.Enabled")));
			this.pnDebug.Font = ((System.Drawing.Font)(resources.GetObject("pnDebug.Font")));
			this.pnDebug.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnDebug.ImeMode")));
			this.pnDebug.Location = ((System.Drawing.Point)(resources.GetObject("pnDebug.Location")));
			this.pnDebug.Name = "pnDebug";
			this.pnDebug.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnDebug.RightToLeft")));
			this.pnDebug.Size = ((System.Drawing.Size)(resources.GetObject("pnDebug.Size")));
			this.pnDebug.TabIndex = ((int)(resources.GetObject("pnDebug.TabIndex")));
			this.pnDebug.Text = resources.GetString("pnDebug.Text");
			this.pnDebug.Visible = ((bool)(resources.GetObject("pnDebug.Visible")));
			// 
			// nsui
			// 
			this.nsui.AccessibleDescription = resources.GetString("nsui.AccessibleDescription");
			this.nsui.AccessibleName = resources.GetString("nsui.AccessibleName");
			this.nsui.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("nsui.Anchor")));
			this.nsui.AutoScroll = ((bool)(resources.GetObject("nsui.AutoScroll")));
			this.nsui.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("nsui.AutoScrollMargin")));
			this.nsui.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("nsui.AutoScrollMinSize")));
			this.nsui.BackColor = System.Drawing.Color.Transparent;
			this.nsui.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nsui.BackgroundImage")));
			this.nsui.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("nsui.Dock")));
			this.nsui.Enabled = ((bool)(resources.GetObject("nsui.Enabled")));
			this.nsui.Font = ((System.Drawing.Font)(resources.GetObject("nsui.Font")));
			this.nsui.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("nsui.ImeMode")));
			this.nsui.Location = ((System.Drawing.Point)(resources.GetObject("nsui.Location")));
			this.nsui.Name = "nsui";
			this.nsui.NgbhResource = null;
			this.nsui.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("nsui.RightToLeft")));
			this.nsui.SimPoolControl = null;
			this.nsui.Size = ((System.Drawing.Size)(resources.GetObject("nsui.Size")));
			this.nsui.Slot = null;
			this.nsui.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
			this.nsui.TabIndex = ((int)(resources.GetObject("nsui.TabIndex")));
			this.nsui.Visible = ((bool)(resources.GetObject("nsui.Visible")));
			// 
			// nssel
			// 
			this.nssel.AccessibleDescription = resources.GetString("nssel.AccessibleDescription");
			this.nssel.AccessibleName = resources.GetString("nssel.AccessibleName");
			this.nssel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("nssel.Anchor")));
			this.nssel.AutoScroll = ((bool)(resources.GetObject("nssel.AutoScroll")));
			this.nssel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("nssel.AutoScrollMargin")));
			this.nssel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("nssel.AutoScrollMinSize")));
			this.nssel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nssel.BackgroundImage")));
			this.nssel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("nssel.Dock")));
			this.nssel.Enabled = ((bool)(resources.GetObject("nssel.Enabled")));
			this.nssel.Font = ((System.Drawing.Font)(resources.GetObject("nssel.Font")));
			this.nssel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("nssel.ImeMode")));
			this.nssel.Location = ((System.Drawing.Point)(resources.GetObject("nssel.Location")));
			this.nssel.Name = "nssel";
			this.nssel.NgbhResource = null;
			this.nssel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("nssel.RightToLeft")));
			this.nssel.Size = ((System.Drawing.Size)(resources.GetObject("nssel.Size")));
			this.nssel.TabIndex = ((int)(resources.GetObject("nssel.TabIndex")));
			this.nssel.Visible = ((bool)(resources.GetObject("nssel.Visible")));
			this.nssel.SelectedSlotChanged += new System.EventHandler(this.nssel_SelectedSlotChanged);
			// 
			// pnBadge
			// 
			this.pnBadge.AccessibleDescription = resources.GetString("pnBadge.AccessibleDescription");
			this.pnBadge.AccessibleName = resources.GetString("pnBadge.AccessibleName");
			this.pnBadge.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnBadge.Anchor")));
			this.pnBadge.AutoScroll = ((bool)(resources.GetObject("pnBadge.AutoScroll")));
			this.pnBadge.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnBadge.AutoScrollMargin")));
			this.pnBadge.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnBadge.AutoScrollMinSize")));
			this.pnBadge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBadge.BackgroundImage")));
			this.pnBadge.Controls.Add(this.shelper);
			this.pnBadge.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnBadge.Dock")));
			this.pnBadge.Enabled = ((bool)(resources.GetObject("pnBadge.Enabled")));
			this.pnBadge.Font = ((System.Drawing.Font)(resources.GetObject("pnBadge.Font")));
			this.pnBadge.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnBadge.ImeMode")));
			this.pnBadge.Location = ((System.Drawing.Point)(resources.GetObject("pnBadge.Location")));
			this.pnBadge.Name = "pnBadge";
			this.pnBadge.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnBadge.RightToLeft")));
			this.pnBadge.Size = ((System.Drawing.Size)(resources.GetObject("pnBadge.Size")));
			this.pnBadge.TabIndex = ((int)(resources.GetObject("pnBadge.TabIndex")));
			this.pnBadge.Text = resources.GetString("pnBadge.Text");
			this.pnBadge.Visible = ((bool)(resources.GetObject("pnBadge.Visible")));
			this.pnBadge.VisibleChanged += new System.EventHandler(this.pnBadge_VisibleChanged);
			// 
			// shelper
			// 
			this.shelper.AccessibleDescription = resources.GetString("shelper.AccessibleDescription");
			this.shelper.AccessibleName = resources.GetString("shelper.AccessibleName");
			this.shelper.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("shelper.Anchor")));
			this.shelper.AutoScroll = ((bool)(resources.GetObject("shelper.AutoScroll")));
			this.shelper.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("shelper.AutoScrollMargin")));
			this.shelper.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("shelper.AutoScrollMinSize")));
			this.shelper.BackColor = System.Drawing.Color.Transparent;
			this.shelper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("shelper.BackgroundImage")));
			this.shelper.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("shelper.Dock")));
			this.shelper.DockPadding.All = 8;
			this.shelper.Enabled = ((bool)(resources.GetObject("shelper.Enabled")));
			this.shelper.Font = ((System.Drawing.Font)(resources.GetObject("shelper.Font")));
			this.shelper.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("shelper.ImeMode")));
			this.shelper.Location = ((System.Drawing.Point)(resources.GetObject("shelper.Location")));
			this.shelper.Name = "shelper";
			this.shelper.NgbhResource = null;
			this.shelper.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("shelper.RightToLeft")));
			this.shelper.SimPoolControl = this.spc;
			this.shelper.Size = ((System.Drawing.Size)(resources.GetObject("shelper.Size")));
			this.shelper.Slot = null;
			this.shelper.TabIndex = ((int)(resources.GetObject("shelper.TabIndex")));
			this.shelper.Visible = ((bool)(resources.GetObject("shelper.Visible")));
			this.shelper.AddedNewItem += new System.EventHandler(this.shelper_AddedNewItem);
			this.shelper.ChangedItem += new System.EventHandler(this.shelper_ChangedItem);
			// 
			// toolBar1
			// 
			this.toolBar1.AccessibleDescription = resources.GetString("toolBar1.AccessibleDescription");
			this.toolBar1.AccessibleName = resources.GetString("toolBar1.AccessibleName");
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar1.Anchor")));
			this.toolBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar1.BackgroundImage")));
			this.toolBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar1.Dock")));
			this.toolBar1.Enabled = ((bool)(resources.GetObject("toolBar1.Enabled")));
			this.toolBar1.Font = ((System.Drawing.Font)(resources.GetObject("toolBar1.Font")));
			this.toolBar1.Guid = new System.Guid("571f7c2a-739c-4423-94a3-9604a9983841");
			this.toolBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar1.ImeMode")));
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biSim,
																			  this.biBadge,
																			  this.biDebug});
			this.toolBar1.Location = ((System.Drawing.Point)(resources.GetObject("toolBar1.Location")));
			this.toolBar1.Movable = false;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Resizable = false;
			this.toolBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar1.RightToLeft")));
			this.toolBar1.Size = ((System.Drawing.Size)(resources.GetObject("toolBar1.Size")));
			this.toolBar1.TabIndex = ((int)(resources.GetObject("toolBar1.TabIndex")));
			this.toolBar1.Tearable = false;
			this.toolBar1.Text = resources.GetString("toolBar1.Text");
			this.toolBar1.TextAlign = TD.SandBar.ToolBarTextAlign.Underneath;
			this.toolBar1.Visible = ((bool)(resources.GetObject("toolBar1.Visible")));
			// 
			// biSim
			// 
			this.biSim.Image = ((System.Drawing.Image)(resources.GetObject("biSim.Image")));
			this.biSim.MinimumSize = 50;
			this.biSim.Text = resources.GetString("biSim.Text");
			this.biSim.ToolTipText = resources.GetString("biSim.ToolTipText");
			this.biSim.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biBadge
			// 
			this.biBadge.Image = ((System.Drawing.Image)(resources.GetObject("biBadge.Image")));
			this.biBadge.MinimumSize = 50;
			this.biBadge.Text = resources.GetString("biBadge.Text");
			this.biBadge.ToolTipText = resources.GetString("biBadge.ToolTipText");
			this.biBadge.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biDebug
			// 
			this.biDebug.Image = ((System.Drawing.Image)(resources.GetObject("biDebug.Image")));
			this.biDebug.MinimumSize = 50;
			this.biDebug.Text = resources.GetString("biDebug.Text");
			this.biDebug.ToolTipText = resources.GetString("biDebug.ToolTipText");
			this.biDebug.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// ExtNgbhUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.pnSims);			
			this.Controls.Add(this.pnBadge);
			this.Controls.Add(this.pnDebug);
			this.Controls.Add(this.toolBar1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ExtNgbhUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.Controls.SetChildIndex(this.pnDebug, 0);
			this.Controls.SetChildIndex(this.pnBadge, 0);
			this.Controls.SetChildIndex(this.pnSims, 0);
			this.pnSims.ResumeLayout(false);
			this.pnDebug.ResumeLayout(false);
			this.pnBadge.ResumeLayout(false);
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
			this.nssel.NgbhResource = Ngbh;
			this.shelper.NgbhResource = Ngbh;
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
		private void menu_BeforePopup(object sender, TD.SandBar.MenuPopupEventArgs e)
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
