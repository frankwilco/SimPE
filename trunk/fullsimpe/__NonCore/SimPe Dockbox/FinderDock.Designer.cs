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
using Ambertation.Windows.Forms;

namespace SimPe.Plugin.Tool.Dockable
{
    partial class FinderDock
    {
        
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Ambertation.Windows.Forms.FlatComboBox cbTask;
        private System.Windows.Forms.Label label1;
        private Ambertation.Windows.Forms.XPTaskBoxSimple tbResult;
        private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;
        private SteepValley.Windows.Forms.XPListView lv;
        private ToolStrip toolBar1;
        private ToolStripButton biList;
        private ToolStripButton biTile;
        private ToolStripButton biDetail;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.IContainer components;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {            
            if (disposing)
            {                
                if (tm != null) tm.Clear();
                tm = null;

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinderDock));
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.tbResult = new Ambertation.Windows.Forms.XPTaskBoxSimple();
            this.lv = new SteepValley.Windows.Forms.XPListView(this.components);
            this.pnContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTask = new Ambertation.Windows.Forms.FlatComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biList = new System.Windows.Forms.ToolStripButton();
            this.biTile = new System.Windows.Forms.ToolStripButton();
            this.biDetail = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
            this.pnErr = new System.Windows.Forms.Label();
            this.xpGradientPanel1.SuspendLayout();
            this.tbResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.Controls.Add(this.tbResult);
            this.xpGradientPanel1.Controls.Add(this.pnContainer);
            this.xpGradientPanel1.Controls.Add(this.panel1);
            this.xpGradientPanel1.Controls.Add(this.pnErr);
            this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xpGradientPanel1.Location = new System.Drawing.Point(0, 25);
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            this.xpGradientPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.xpGradientPanel1.Size = new System.Drawing.Size(254, 451);
            this.xpGradientPanel1.TabIndex = 0;
            // 
            // tbResult
            // 
            this.tbResult.BackColor = System.Drawing.Color.Transparent;
            this.tbResult.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbResult.BorderColor = System.Drawing.SystemColors.Window;
            this.tbResult.Controls.Add(this.lv);
            this.tbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResult.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.tbResult.HeaderText = "Results";
            this.tbResult.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbResult.Icon = ((System.Drawing.Image)(resources.GetObject("tbResult.Icon")));
            this.tbResult.IconLocation = new System.Drawing.Point(4, 12);
            this.tbResult.IconSize = new System.Drawing.Size(32, 32);
            this.tbResult.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbResult.Location = new System.Drawing.Point(8, 159);
            this.tbResult.Name = "tbResult";
            this.tbResult.Padding = new System.Windows.Forms.Padding(4, 44, 4, 4);
            this.tbResult.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            this.tbResult.Size = new System.Drawing.Size(238, 284);
            this.tbResult.TabIndex = 4;
            // 
            // lv
            // 
            this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv.HideSelection = false;
            this.lv.Location = new System.Drawing.Point(8, 48);
            this.lv.MultiSelect = false;
            this.lv.Name = "lv";
            this.lv.Size = new System.Drawing.Size(222, 229);
            this.lv.TabIndex = 0;
            this.lv.TileColumns = new int[] {
        1};
            this.lv.TileSize = new System.Drawing.Size(350, 90);
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.DoubleClick += new System.EventHandler(this.lv_DoubleClick);
            this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
            this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lv_ColumnClick);
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainer.Location = new System.Drawing.Point(8, 65);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(238, 94);
            this.pnContainer.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbTask);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 24);
            this.panel1.TabIndex = 3;
            // 
            // cbTask
            // 
            this.cbTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xpCueBannerExtender1.SetCueBannerText(this.cbTask, "");
            this.cbTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTask.Location = new System.Drawing.Point(48, 0);
            this.cbTask.Name = "cbTask";
            this.cbTask.Size = new System.Drawing.Size(190, 21);
            this.cbTask.TabIndex = 3;
            this.cbTask.SelectedIndexChanged += new System.EventHandler(this.cbTask_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // toolBar1
            // 
            this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biList,
            this.biTile,
            this.biDetail});
            this.toolBar1.Location = new System.Drawing.Point(0, 0);
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.Size = new System.Drawing.Size(254, 25);
            this.toolBar1.TabIndex = 1;
            this.toolBar1.Text = "toolBar1";
            // 
            // biList
            // 
            this.biList.Image = ((System.Drawing.Image)(resources.GetObject("biList.Image")));
            this.biList.Name = "biList";
            this.biList.Size = new System.Drawing.Size(23, 22);
            this.biList.ToolTipText = "List View";
            this.biList.Click += new System.EventHandler(this.Activate_biList);
            // 
            // biTile
            // 
            this.biTile.Image = ((System.Drawing.Image)(resources.GetObject("biTile.Image")));
            this.biTile.Name = "biTile";
            this.biTile.Size = new System.Drawing.Size(23, 22);
            this.biTile.ToolTipText = "Tiled View";
            this.biTile.Click += new System.EventHandler(this.Activate_biTile);
            // 
            // biDetail
            // 
            this.biDetail.Checked = true;
            this.biDetail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.biDetail.Image = ((System.Drawing.Image)(resources.GetObject("biDetail.Image")));
            this.biDetail.Name = "biDetail";
            this.biDetail.Size = new System.Drawing.Size(23, 22);
            this.biDetail.ToolTipText = "Detailed View";
            this.biDetail.Click += new System.EventHandler(this.Activate_biDetails);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 402);
            this.panel2.TabIndex = 5;
            // 
            // pnErr
            // 
            this.pnErr.BackColor = System.Drawing.Color.Transparent;
            this.pnErr.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnErr.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnErr.ForeColor = System.Drawing.Color.Maroon;
            this.pnErr.Location = new System.Drawing.Point(8, 8);
            this.pnErr.Name = "pnErr";
            this.pnErr.Size = new System.Drawing.Size(238, 33);
            this.pnErr.TabIndex = 6;
            this.pnErr.Text = "Only the first {nr} Results are displayed below.";
            this.pnErr.Visible = false;
            // 
            // FinderDock
            // 
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(208, 288);
            this.ButtonText = "Finder";
            this.CaptionText = "Scenegraph Resource Finder";
            this.Controls.Add(this.xpGradientPanel1);
            this.Controls.Add(this.toolBar1);
            this.FloatingSize = new System.Drawing.Size(266, 502);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Image = ((System.Drawing.Image)(resources.GetObject("$this.Image")));
            this.Name = "FinderDock";
            this.Size = new System.Drawing.Size(254, 476);
            this.TabImage = ((System.Drawing.Image)(resources.GetObject("$this.TabImage")));
            this.TabText = "Finder";
            this.xpGradientPanel1.ResumeLayout(false);
            this.tbResult.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private Label pnErr;
    }
}
