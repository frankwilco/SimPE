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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für ExtNgbhUI.
	/// </summary>
	public class BnfoUI : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		private SimPe.Plugin.BnfoCustomerItemsUI lv;
		private SimPe.Plugin.BnfoCustomerItemUI bnfoCustomerItemUI1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblot;
		private ToolStrip toolBar1;
		private System.Windows.Forms.Panel panel1;
		private ToolStripButton biMax;
		private ToolStripButton biReward;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbCur;
		private System.Windows.Forms.TextBox tbMax;
		
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public BnfoUI()
		{			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

            toolBar1.Renderer = new SimPe.MediaPlayerRenderer();			

			ThemeManager.AddControl(this.toolBar1);
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BnfoUI));
            this.lv = new SimPe.Plugin.BnfoCustomerItemsUI();
            this.bnfoCustomerItemUI1 = new SimPe.Plugin.BnfoCustomerItemUI();
            this.label1 = new System.Windows.Forms.Label();
            this.lblot = new System.Windows.Forms.Label();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biMax = new System.Windows.Forms.ToolStripButton();
            this.biReward = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.tbCur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolBar1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lv.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lv.Items = null;
            this.lv.Location = new System.Drawing.Point(8, 32);
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(328, 201);
            this.lv.TabIndex = 1;
            // 
            // bnfoCustomerItemUI1
            // 
            this.bnfoCustomerItemUI1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bnfoCustomerItemUI1.BackColor = System.Drawing.Color.Transparent;
            this.bnfoCustomerItemUI1.BnfoCustomerItemsUI = this.lv;
            this.bnfoCustomerItemUI1.Item = null;
            this.bnfoCustomerItemUI1.Location = new System.Drawing.Point(344, 8);
            this.bnfoCustomerItemUI1.Name = "bnfoCustomerItemUI1";
            this.bnfoCustomerItemUI1.Size = new System.Drawing.Size(344, 233);
            this.bnfoCustomerItemUI1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Lot:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblot
            // 
            this.lblot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblot.BackColor = System.Drawing.Color.Transparent;
            this.lblot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblot.Location = new System.Drawing.Point(48, 8);
            this.lblot.Name = "lblot";
            this.lblot.Size = new System.Drawing.Size(288, 23);
            this.lblot.TabIndex = 6;
            this.lblot.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // toolBar1
            // 
            this.toolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biMax,
            this.biReward});
            this.toolBar1.Location = new System.Drawing.Point(0, 24);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(696, 52);
            this.toolBar1.TabIndex = 7;
            this.toolBar1.Text = "toolBar1";
            // 
            // biMax
            // 
            this.biMax.Image = ((System.Drawing.Image)(resources.GetObject("biMax.Image")));
            this.biMax.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.biMax.Name = "biMax";
            this.biMax.Size = new System.Drawing.Size(54, 49);
            this.biMax.Text = "Maximize";
            this.biMax.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.biMax.Click += new System.EventHandler(this.biMax_Activate);
            // 
            // biReward
            // 
            this.biReward.Image = ((System.Drawing.Image)(resources.GetObject("biReward.Image")));
            this.biReward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.biReward.Name = "biReward";
            this.biReward.Size = new System.Drawing.Size(77, 49);
            this.biReward.Text = "Reward again";
            this.biReward.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.biReward.Click += new System.EventHandler(this.biReward_Activate);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.tbMax);
            this.panel1.Controls.Add(this.tbCur);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lv);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bnfoCustomerItemUI1);
            this.panel1.Controls.Add(this.lblot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 292);
            this.panel1.TabIndex = 8;
            // 
            // tbMax
            // 
            this.tbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMax.Location = new System.Drawing.Point(120, 265);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 21);
            this.tbMax.TabIndex = 10;
            this.tbMax.TextChanged += new System.EventHandler(this.tbMax_TextChanged);
            // 
            // tbCur
            // 
            this.tbCur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbCur.Location = new System.Drawing.Point(120, 241);
            this.tbCur.Name = "tbCur";
            this.tbCur.Size = new System.Drawing.Size(100, 21);
            this.tbCur.TabIndex = 9;
            this.tbCur.TextChanged += new System.EventHandler(this.tbCur_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(8, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rewarded Level:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Current Level:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // BnfoUI
            // 
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.HeaderText = "Business Info";
            this.Name = "BnfoUI";
            this.Size = new System.Drawing.Size(696, 368);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		public Bnfo Bnfo
		{
			get { return (Bnfo)Wrapper; }
		}

		bool intern;
		protected override void RefreshGUI()
		{			
			if (intern) return;
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BnfoUI));
			this.HeaderText = resources.GetString("$this.HeaderText");
			intern = true;
			if (Bnfo!=null) 
			{
				lv.Items = Bnfo.CustomerItems;
				biMax.Enabled = true;
				biReward.Enabled = true;

				SimPe.Interfaces.Providers.ILotItem ili = FileTable.ProviderRegistry.LotProvider.FindLot(Bnfo.FileDescriptor.Instance);
				if (ili!=null)
					this.lblot.Text = ili.LotName;
				else
					this.lblot.Text = SimPe.Localization.GetString("Unknown");

				tbCur.Text = Bnfo.CurrentBusinessState.ToString();
				tbMax.Text = Bnfo.MaxSeenBusinessState.ToString();

				this.HeaderText += ": " + lblot.Text;
			} 
			else 
			{
				lv.Items = null;
				this.lblot.Text = "";
				
				biMax.Enabled = false;
				biReward.Enabled = false;				
			}

			tbMax.Enabled = biMax.Enabled;
			tbCur.Enabled = biMax.Enabled;
			intern=false;
		}

		public override void OnCommit()
		{
			Bnfo.SynchronizeUserData(true, false);
		}


		private void biMax_Activate(object sender, System.EventArgs e)
		{
			if (lv.Items==null) return;
			foreach (BnfoCustomerItem item in lv.Items)			
				item.LoyaltyScore = 1000;
						
			lv.Refresh();
		}

		private void biReward_Activate(object sender, System.EventArgs e)
		{
			if (Bnfo==null) return;
			Bnfo.CurrentBusinessState = 0;
			Bnfo.MaxSeenBusinessState = 0;
			RefreshGUI();
		}

		private void tbCur_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (Bnfo==null) return;
			Bnfo.CurrentBusinessState = Helper.StringToUInt32(tbCur.Text, Bnfo.CurrentBusinessState, 10);
		}

		private void tbMax_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (Bnfo==null) return;
			Bnfo.MaxSeenBusinessState = Helper.StringToUInt32(tbMax.Text, Bnfo.MaxSeenBusinessState, 10);
		}

								
	}
}
