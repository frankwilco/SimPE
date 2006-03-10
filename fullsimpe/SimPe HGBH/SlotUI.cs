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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für SlotUI.
	/// </summary>
	public class NgbhSlotUI : System.Windows.Forms.UserControl
	{
		private TD.SandDock.TabControl tabControl1;
		private TD.SandDock.TabPage tabPage1;
		private TD.SandDock.TabPage tabPage2;
		private NgbhItemsListView lv;
		private SimPe.Plugin.NgbhItemsListView lvint;
		private System.Windows.Forms.Splitter splitter1;
		private SimPe.Plugin.MemoryProperties memprop;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NgbhSlotUI()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			SlotType = Data.NeighborhoodSlots.Sims;
			tabPage2_VisibleChanged(null, null);
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
			this.tabControl1 = new TD.SandDock.TabControl();
			this.tabPage1 = new TD.SandDock.TabPage();
			this.lv = new SimPe.Plugin.NgbhItemsListView();
			this.tabPage2 = new TD.SandDock.TabPage();
			this.lvint = new SimPe.Plugin.NgbhItemsListView();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.memprop = new SimPe.Plugin.MemoryProperties();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											new TD.SandDock.DocumentLayoutSystem(504, 165, new TD.SandDock.DockControl[] {
																																																															 this.tabPage1,
																																																															 this.tabPage2}, this.tabPage1)});
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Size = new System.Drawing.Size(504, 165);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Transparent;
			this.tabPage1.Controls.Add(this.lv);
			this.tabPage1.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage1.Guid = new System.Guid("951f2dbf-63ee-4eb5-8342-1e80d72570b8");
			this.tabPage1.Location = new System.Drawing.Point(2, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(500, 141);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.TabText = "Memories";
			this.tabPage1.Text = "Memories";
			// 
			// lv
			// 
			this.lv.BackColor = System.Drawing.Color.Transparent;
			this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.lv.Location = new System.Drawing.Point(0, 0);
			this.lv.Name = "lv";
			this.lv.NgbhItems = null;
			this.lv.Size = new System.Drawing.Size(500, 141);
			this.lv.Slot = null;
			this.lv.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
			this.lv.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Transparent;
			this.tabPage2.Controls.Add(this.lvint);
			this.tabPage2.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage2.Guid = new System.Guid("88419e31-43c9-4409-8d97-7ef80e549ee5");
			this.tabPage2.Location = new System.Drawing.Point(2, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(500, 117);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.TabText = "Tokens (Skills, Badges...)";
			this.tabPage2.Text = "Tokens (Skills, Badges...)";
			this.tabPage2.Visible = false;
			this.tabPage2.VisibleChanged += new System.EventHandler(this.tabPage2_VisibleChanged);
			// 
			// lvint
			// 
			this.lvint.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvint.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.lvint.Location = new System.Drawing.Point(0, 0);
			this.lvint.Name = "lvint";
			this.lvint.NgbhItems = null;
			this.lvint.Size = new System.Drawing.Size(500, 117);
			this.lvint.Slot = null;
			this.lvint.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
			this.lvint.TabIndex = 1;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 165);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(504, 3);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// memprop
			// 
			this.memprop.BackColor = System.Drawing.Color.Transparent;
			this.memprop.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.memprop.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.memprop.Item = null;
			this.memprop.Location = new System.Drawing.Point(0, 168);
			this.memprop.Name = "memprop";
			this.memprop.NgbhItemsListView = null;
			this.memprop.Size = new System.Drawing.Size(504, 192);
			this.memprop.TabIndex = 4;
			// 
			// NgbhSlotUI
			// 
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.memprop);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NgbhSlotUI";
			this.Size = new System.Drawing.Size(504, 360);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Properties		
		Data.NeighborhoodSlots st;
		public Data.NeighborhoodSlots SlotType 
		{
			get {return st;}
			set 
			{
				st = value;
				lv.NgbhItems = null;
				lvint.NgbhItems = null;
				if (st== SimPe.Data.NeighborhoodSlots.Sims || st==SimPe.Data.NeighborhoodSlots.SimsIntern) 
				{
					this.tabPage1.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.Sims");
					this.tabPage2.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.SimsIntern");
					
					lv.SlotType = SimPe.Data.NeighborhoodSlots.Sims;
					lvint.SlotType = SimPe.Data.NeighborhoodSlots.SimsIntern;
				} 
				else if (st== SimPe.Data.NeighborhoodSlots.Families || st==SimPe.Data.NeighborhoodSlots.FamiliesIntern) 
				{
					this.tabPage1.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.Families");
					this.tabPage2.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.FamiliesIntern");
					
					lv.SlotType = SimPe.Data.NeighborhoodSlots.Families;
					lvint.SlotType = SimPe.Data.NeighborhoodSlots.FamiliesIntern;
				}
				else 
				{
					this.tabPage1.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.Lots");
					this.tabPage2.Text = SimPe.Localization.GetString("SimPe.Data.NeighborhoodSlots.LotsIntern");
					
					lv.SlotType = SimPe.Data.NeighborhoodSlots.Lots;
					lvint.SlotType = SimPe.Data.NeighborhoodSlots.LotsIntern;
				}
				this.tabPage1.TabText = this.tabPage1.Text;
				this.tabPage2.TabText = this.tabPage2.Text;

				SetContent();
			}			
		}

		NgbhSlot slot;
		[System.ComponentModel.Browsable(false)]
		public NgbhSlot Slot
		{
			get {return slot;}
			set 
			{
				slot = value;
				SetContent();				
			}
		}

		Ngbh ngbh;
		[System.ComponentModel.Browsable(false)]
		public Ngbh NgbhResource
		{
			get {return ngbh;}
			set 
			{
				ngbh = value;
				SetContent();
				pc_SelectedSimChanged(pc, null, null);
			}
		}

		SimPe.PackedFiles.Wrapper.SimPoolControl pc;
		public SimPe.PackedFiles.Wrapper.SimPoolControl SimPoolControl
		{
			get {return pc;}
			set {
				if (pc!=null) pc.SelectedSimChanged -= new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(pc_SelectedSimChanged);
				pc = value;
				if (pc!=null) 
				{
					pc.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(pc_SelectedSimChanged);
					pc_SelectedSimChanged(pc, null, null);
				}
			}
		}
		#endregion

		void SetContent()
		{
			lv.Slot = slot;
			lvint.Slot = slot;			
		}

		public new void Refresh()
		{
			lv.Refresh();
			lvint.Refresh();
			base.Refresh();
		}

		private void pc_SelectedSimChanged(object sender, Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
		{
			
			if (ngbh!=null && pc!=null) 
			{
				if (pc.SelectedSim!=null)
					this.Slot = ngbh.GetSlots(st).GetInstanceSlot(pc.SelectedSim.FileDescriptor.Instance);	
				else
					this.Slot = null;
			}
		}			

		private void tabPage2_VisibleChanged(object sender, System.EventArgs e)
		{
			if (tabControl1.SelectedPage == this.tabPage1)
				memprop.NgbhItemsListView = lv;
			else
				memprop.NgbhItemsListView = lvint;
		}
	}
}
