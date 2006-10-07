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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using SimPe.Events;

namespace SimPe
{
    partial class MainForm 
    {
        private System.Windows.Forms.ToolStripContainer tbContainer;
        private System.Windows.Forms.OpenFileDialog ofd;
        private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;        
        private MenuStrip menuBar1;
        private ToolStripMenuItem menuBarItem1;
        private ToolStripMenuItem menuBarItem5;
        private ToolStrip toolBar1;
        private TD.SandDock.DockableWindow dcFilter;
        private ToolStripMenuItem miOpen;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
        private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon1;
        private ResourceListView lv;
        private System.Windows.Forms.TreeView tvInstance;
        private System.Windows.Forms.ColumnHeader clType;
        private System.Windows.Forms.ColumnHeader clGroup;
        private System.Windows.Forms.ColumnHeader clInstance;
        private System.Windows.Forms.ColumnHeader clInstanceHigh;
        private System.Windows.Forms.TreeView tvGroup;
        private System.Windows.Forms.TreeView tvType;
        private ToolStripButton biOpen;
        private System.Windows.Forms.TextBox tbInst;
        private System.Windows.Forms.TextBox tbGrp;
        
        private TD.SandDock.SandDockManager sdm;
        private ToolStripButton biTypeList;
        private ToolStripButton biGroupList;
        private ToolStripButton biInstanceList;
        private ToolStrip tbResource;
        private TD.SandDock.DockableWindow dcResource;
        private ToolStripMenuItem miRecent;
        private ToolStripMenuItem miExtra;
        private TD.SandDock.DockableWindow dcAction;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
        private System.Windows.Forms.ImageList iAnim;
        private ToolStripMenuItem miTools;
        private TD.SandDock.DockContainer myrightSandDock;
        private TD.SandDock.DockContainer mybottomSandDock;
        private ToolStripMenuItem miNewDc;
        private TD.SandDock.DockableWindow dcPlugin;
        private ToolStripMenuItem miMetaInfo;
        private ToolStripMenuItem miFileNames;
        private ToolStripMenuItem miExit;
        private System.Windows.Forms.ColumnHeader clOffset;
        private System.Windows.Forms.ColumnHeader clSize;
        private ToolStripMenuItem miRunSims;
        private ToolStripMenuItem miWindow;
        private ToolStripMenuItem miSave;
        private System.Windows.Forms.SaveFileDialog sfd;
        private ToolStripMenuItem miSaveAs;
        private ToolStripMenuItem miClose;
        private ToolStripButton biSave;
        private ToolStripButton biClose;
        private ToolStripButton biSaveAs;
        private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbDefaultAction;
        private ContextMenuStrip miAction;
        private ToolStrip tbAction;
        private ToolStripButton biNewDc;
        private ToolStripMenuItem miPref;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel5;
        private ToolStripMenuItem miNew;
        private ToolStripButton biNew;
        private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbExtAction;
        private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbPlugAction;
        private ToolStripMenuItem miAbout;
        private ToolStripMenuItem miUpdate;
        private ToolStripMenuItem miTutorials;
        private ToolStripButton biUpdate;
        private ToolStripMenuItem miOpenIn;
        private ToolStripMenuItem miOpenSimsRes;
        private ToolStripMenuItem miOpenDownloads;
        private System.Windows.Forms.TextBox tbRcolName;
        private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon2;
        private ToolStrip tbTools;
        private ToolStrip tbWindow;
        private TD.SandBar.FlatComboBox cbsemig;
        private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon3;
        private TD.SandDock.TabControl dc;
        private TD.SandDock.DockContainer dockContainer1;
        private System.Windows.Forms.Timer resourceSelectionTimer;
        private ToolStripMenuItem miSaveCopyAs;
        private ToolStripButton biReset;
        private ToolStripMenuItem mbiTopics;
        internal WaitControl waitControl1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Die verwendeten Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code
        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbContainer = new System.Windows.Forms.ToolStripContainer();
            this.lv = new SimPe.ResourceListView();
            this.clType = new System.Windows.Forms.ColumnHeader();
            this.clGroup = new System.Windows.Forms.ColumnHeader();
            this.clInstanceHigh = new System.Windows.Forms.ColumnHeader();
            this.clInstance = new System.Windows.Forms.ColumnHeader();
            this.clOffset = new System.Windows.Forms.ColumnHeader();
            this.clSize = new System.Windows.Forms.ColumnHeader();
            this.miAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dockContainer1 = new TD.SandDock.DockContainer();
            this.dcResource = new TD.SandDock.DockableWindow();
            this.tbResource = new System.Windows.Forms.ToolStrip();
            this.biInstanceList = new System.Windows.Forms.ToolStripButton();
            this.biGroupList = new System.Windows.Forms.ToolStripButton();
            this.biTypeList = new System.Windows.Forms.ToolStripButton();
            this.tvType = new System.Windows.Forms.TreeView();
            this.tvGroup = new System.Windows.Forms.TreeView();
            this.tvInstance = new System.Windows.Forms.TreeView();
            this.sdm = new TD.SandDock.SandDockManager();
            this.mybottomSandDock = new TD.SandDock.DockContainer();
            this.dcPlugin = new TD.SandDock.DockableWindow();
            this.dc = new TD.SandDock.TabControl();
            this.tbWindow = new System.Windows.Forms.ToolStrip();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biNew = new System.Windows.Forms.ToolStripButton();
            this.biOpen = new System.Windows.Forms.ToolStripButton();
            this.biSave = new System.Windows.Forms.ToolStripButton();
            this.biSaveAs = new System.Windows.Forms.ToolStripButton();
            this.biClose = new System.Windows.Forms.ToolStripButton();
            this.biNewDc = new System.Windows.Forms.ToolStripButton();
            this.biUpdate = new System.Windows.Forms.ToolStripButton();
            this.biReset = new System.Windows.Forms.ToolStripButton();
            this.tbTools = new System.Windows.Forms.ToolStrip();
            this.tbAction = new System.Windows.Forms.ToolStrip();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
            this.tbInst = new System.Windows.Forms.TextBox();
            this.tbGrp = new System.Windows.Forms.TextBox();
            this.tbRcolName = new System.Windows.Forms.TextBox();
            this.cbsemig = new TD.SandBar.FlatComboBox();
            this.miNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDc = new System.Windows.Forms.ToolStripMenuItem();
            this.miUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar1 = new System.Windows.Forms.MenuStrip();
            this.menuBarItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenIn = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenSimsRes = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenDownloads = new System.Windows.Forms.ToolStripMenuItem();
            this.miSaveCopyAs = new System.Windows.Forms.ToolStripMenuItem();
            this.miRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miTools = new System.Windows.Forms.ToolStripMenuItem();
            this.miExtra = new System.Windows.Forms.ToolStripMenuItem();
            this.miMetaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNames = new System.Windows.Forms.ToolStripMenuItem();
            this.miRunSims = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miPref = new System.Windows.Forms.ToolStripMenuItem();
            this.miWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.miTutorials = new System.Windows.Forms.ToolStripMenuItem();
            this.mbiTopics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.iAnim = new System.Windows.Forms.ImageList(this.components);
            this.myrightSandDock = new TD.SandDock.DockContainer();
            this.dcFilter = new TD.SandDock.DockableWindow();
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.xpLinkedLabelIcon3 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.xpLinkedLabelIcon2 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.xpLinkedLabelIcon1 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.dcAction = new TD.SandDock.DockableWindow();
            this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.tbExtAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.tbPlugAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.tbDefaultAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.xpGradientPanel5 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.resourceSelectionTimer = new System.Windows.Forms.Timer(this.components);
            this.waitControl1 = new SimPe.WaitControl();
            this.tbContainer.ContentPanel.SuspendLayout();
            this.tbContainer.TopToolStripPanel.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.dockContainer1.SuspendLayout();
            this.dcResource.SuspendLayout();
            this.tbResource.SuspendLayout();
            this.mybottomSandDock.SuspendLayout();
            this.dcPlugin.SuspendLayout();
            this.toolBar1.SuspendLayout();
            this.menuBar1.SuspendLayout();
            this.myrightSandDock.SuspendLayout();
            this.dcFilter.SuspendLayout();
            this.xpGradientPanel1.SuspendLayout();
            this.dcAction.SuspendLayout();
            this.xpGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContainer
            // 
            // 
            // tbContainer.ContentPanel
            // 
            this.tbContainer.ContentPanel.Controls.Add(this.lv);
            this.tbContainer.ContentPanel.Controls.Add(this.dockContainer1);
            this.tbContainer.ContentPanel.Controls.Add(this.mybottomSandDock);
            resources.ApplyResources(this.tbContainer.ContentPanel, "tbContainer.ContentPanel");
            resources.ApplyResources(this.tbContainer, "tbContainer");
            this.tbContainer.Name = "tbContainer";
            // 
            // tbContainer.TopToolStripPanel
            // 
            this.tbContainer.TopToolStripPanel.Controls.Add(this.toolBar1);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbAction);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbWindow);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbTools);
            // 
            // lv
            // 
            this.lv.AllowDrop = true;
            this.lv.AutoArrange = false;
            this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clType,
            this.clGroup,
            this.clInstanceHigh,
            this.clInstance,
            this.clOffset,
            this.clSize});
            this.lv.ContextMenuStrip = this.miAction;
            resources.ApplyResources(this.lv, "lv");
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.Name = "lv";
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.VirtualMode = true;
            this.lv.SyncedSelectionChanged += new System.EventHandler(this.SelectResource);
            this.lv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            this.lv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.lv.DoubleClick += new System.EventHandler(this.SelectResourceDBClick);
            this.lv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectResource);
            this.lv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyDown);
            this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortResourceListClick);
            this.lv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyUp);
            // 
            // clType
            // 
            resources.ApplyResources(this.clType, "clType");
            // 
            // clGroup
            // 
            resources.ApplyResources(this.clGroup, "clGroup");
            // 
            // clInstanceHigh
            // 
            resources.ApplyResources(this.clInstanceHigh, "clInstanceHigh");
            // 
            // clInstance
            // 
            resources.ApplyResources(this.clInstance, "clInstance");
            // 
            // clOffset
            // 
            resources.ApplyResources(this.clOffset, "clOffset");
            // 
            // clSize
            // 
            resources.ApplyResources(this.clSize, "clSize");
            // 
            // miAction
            // 
            this.miAction.Name = "miAction";
            resources.ApplyResources(this.miAction, "miAction");
            // 
            // dockContainer1
            // 
            this.dockContainer1.Controls.Add(this.dcResource);
            resources.ApplyResources(this.dockContainer1, "dockContainer1");
            this.dockContainer1.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(100, 423, new TD.SandDock.DockControl[] {
                        ((TD.SandDock.DockControl)(this.dcResource))}, this.dcResource, false)))});
            this.dockContainer1.Manager = this.sdm;
            this.dockContainer1.Name = "dockContainer1";
            // 
            // dcResource
            // 
            this.dcResource.AllowFloat = false;
            this.dcResource.Controls.Add(this.tbResource);
            this.dcResource.Controls.Add(this.tvType);
            this.dcResource.Controls.Add(this.tvGroup);
            this.dcResource.Controls.Add(this.tvInstance);
            this.dcResource.Guid = new System.Guid("4eac3301-7437-4391-81dd-743cf8e38995");
            resources.ApplyResources(this.dcResource, "dcResource");
            this.dcResource.Name = "dcResource";
            this.dcResource.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResource.TabImage")));
            // 
            // tbResource
            // 
            this.tbResource.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biInstanceList,
            this.biGroupList,
            this.biTypeList});
            resources.ApplyResources(this.tbResource, "tbResource");
            this.tbResource.Name = "tbResource";
            // 
            // biInstanceList
            // 
            resources.ApplyResources(this.biInstanceList, "biInstanceList");
            this.biInstanceList.Name = "biInstanceList";
            this.biInstanceList.Tag = "2";
            this.biInstanceList.Click += new System.EventHandler(this.SelectResourceView);
            // 
            // biGroupList
            // 
            resources.ApplyResources(this.biGroupList, "biGroupList");
            this.biGroupList.Name = "biGroupList";
            this.biGroupList.Tag = "1";
            this.biGroupList.Click += new System.EventHandler(this.SelectResourceView);
            // 
            // biTypeList
            // 
            this.biTypeList.Checked = true;
            this.biTypeList.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.biTypeList, "biTypeList");
            this.biTypeList.Name = "biTypeList";
            this.biTypeList.Tag = "0";
            this.biTypeList.Click += new System.EventHandler(this.SelectResourceView);
            // 
            // tvType
            // 
            this.tvType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvType.HideSelection = false;
            resources.ApplyResources(this.tvType, "tvType");
            this.tvType.ItemHeight = 18;
            this.tvType.Name = "tvType";
            this.tvType.Sorted = true;
            this.tvType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
            // 
            // tvGroup
            // 
            this.tvGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvGroup.HideSelection = false;
            resources.ApplyResources(this.tvGroup, "tvGroup");
            this.tvGroup.ItemHeight = 16;
            this.tvGroup.Name = "tvGroup";
            this.tvGroup.Sorted = true;
            this.tvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
            // 
            // tvInstance
            // 
            this.tvInstance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvInstance.HideSelection = false;
            resources.ApplyResources(this.tvInstance, "tvInstance");
            this.tvInstance.ItemHeight = 16;
            this.tvInstance.Name = "tvInstance";
            this.tvInstance.Sorted = true;
            this.tvInstance.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
            // 
            // sdm
            // 
            this.sdm.DockSystemContainer = this.tbContainer.ContentPanel;
            this.sdm.OwnerForm = this;
            this.sdm.Renderer = new TD.SandDock.Rendering.Office2003Renderer();
            this.sdm.DockControlActivated += new TD.SandDock.DockControlEventHandler(this.sdm_DockControlActivated);
            // 
            // mybottomSandDock
            // 
            this.mybottomSandDock.Controls.Add(this.dcPlugin);
            resources.ApplyResources(this.mybottomSandDock, "mybottomSandDock");
            this.mybottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Vertical, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(924, 100, new TD.SandDock.DockControl[] {
                        ((TD.SandDock.DockControl)(this.dcPlugin))}, this.dcPlugin, false)))});
            this.mybottomSandDock.Manager = this.sdm;
            this.mybottomSandDock.Name = "mybottomSandDock";
            // 
            // dcPlugin
            // 
            this.dcPlugin.AllowClose = false;
            this.dcPlugin.AllowDockCenter = true;
            resources.ApplyResources(this.dcPlugin, "dcPlugin");
            this.dcPlugin.Controls.Add(this.dc);
            this.dcPlugin.FloatingSize = new System.Drawing.Size(800, 400);
            this.dcPlugin.Guid = new System.Guid("1fc41585-f06c-418c-8226-523fdec0f9c4");
            this.dcPlugin.Name = "dcPlugin";
            this.dcPlugin.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPlugin.TabImage")));
            // 
            // dc
            // 
            resources.ApplyResources(this.dc, "dc");
            this.dc.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.DocumentLayoutSystem(905, 373, new TD.SandDock.DockControl[0], null)))});
            this.dc.Name = "dc";
            this.dc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dc_MouseUp);
            // 
            // tbWindow
            // 
            resources.ApplyResources(this.tbWindow, "tbWindow");
            this.tbWindow.Name = "tbWindow";
            // 
            // toolBar1
            // 
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biNew,
            this.biOpen,
            this.biSave,
            this.biSaveAs,
            this.biClose,
            this.biNewDc,
            this.biUpdate,
            this.biReset});
            this.toolBar1.Name = "toolBar1";
            // 
            // biNew
            // 
            resources.ApplyResources(this.biNew, "biNew");
            this.biNew.Name = "biNew";
            this.biNew.Click += new System.EventHandler(this.Activate_miNew);
            // 
            // biOpen
            // 
            resources.ApplyResources(this.biOpen, "biOpen");
            this.biOpen.Name = "biOpen";
            this.biOpen.Click += new System.EventHandler(this.Activate_miOpen);
            // 
            // biSave
            // 
            resources.ApplyResources(this.biSave, "biSave");
            this.biSave.Name = "biSave";
            this.biSave.Click += new System.EventHandler(this.Activate_miSave);
            // 
            // biSaveAs
            // 
            resources.ApplyResources(this.biSaveAs, "biSaveAs");
            this.biSaveAs.Name = "biSaveAs";
            this.biSaveAs.Click += new System.EventHandler(this.Activate_miSaveAs);
            // 
            // biClose
            // 
            resources.ApplyResources(this.biClose, "biClose");
            this.biClose.Name = "biClose";
            this.biClose.Click += new System.EventHandler(this.Activate_miClose);
            // 
            // biNewDc
            // 
            resources.ApplyResources(this.biNewDc, "biNewDc");
            this.biNewDc.Name = "biNewDc";
            this.biNewDc.Click += new System.EventHandler(this.CreateNewDocumentContainer);
            // 
            // biUpdate
            // 
            resources.ApplyResources(this.biUpdate, "biUpdate");
            this.biUpdate.Name = "biUpdate";
            this.biUpdate.Click += new System.EventHandler(this.Activate_miUpdate);
            // 
            // biReset
            // 
            resources.ApplyResources(this.biReset, "biReset");
            this.biReset.Name = "biReset";
            this.biReset.Click += new System.EventHandler(this.Activate_biReset);
            // 
            // tbTools
            // 
            resources.ApplyResources(this.tbTools, "tbTools");
            this.tbTools.Name = "tbTools";
            // 
            // tbAction
            // 
            resources.ApplyResources(this.tbAction, "tbAction");
            this.tbAction.Name = "tbAction";
            // 
            // ofd
            // 
            resources.ApplyResources(this.ofd, "ofd");
            // 
            // tbInst
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbInst, "Instance Filter");
            resources.ApplyResources(this.tbInst, "tbInst");
            this.tbInst.Name = "tbInst";
            // 
            // tbGrp
            // 
            this.xpCueBannerExtender1.SetCueBannerText(this.tbGrp, "Group Filter");
            resources.ApplyResources(this.tbGrp, "tbGrp");
            this.tbGrp.Name = "tbGrp";
            // 
            // tbRcolName
            // 
            resources.ApplyResources(this.tbRcolName, "tbRcolName");
            this.xpCueBannerExtender1.SetCueBannerText(this.tbRcolName, "RCOL Filename");
            this.tbRcolName.Name = "tbRcolName";
            this.tbRcolName.SizeChanged += new System.EventHandler(this.tbRcolName_SizeChanged);
            // 
            // cbsemig
            // 
            resources.ApplyResources(this.cbsemig, "cbsemig");
            this.xpCueBannerExtender1.SetCueBannerText(this.cbsemig, "Semiglobal Group");
            this.cbsemig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbsemig.Name = "cbsemig";
            // 
            // miNew
            // 
            resources.ApplyResources(this.miNew, "miNew");
            this.miNew.Name = "miNew";
            this.miNew.Click += new System.EventHandler(this.Activate_miNew);
            // 
            // miOpen
            // 
            resources.ApplyResources(this.miOpen, "miOpen");
            this.miOpen.Name = "miOpen";
            this.miOpen.Click += new System.EventHandler(this.Activate_miOpen);
            // 
            // miSave
            // 
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Name = "miSave";
            this.miSave.Click += new System.EventHandler(this.Activate_miSave);
            // 
            // miSaveAs
            // 
            resources.ApplyResources(this.miSaveAs, "miSaveAs");
            this.miSaveAs.Name = "miSaveAs";
            this.miSaveAs.Click += new System.EventHandler(this.Activate_miSaveAs);
            // 
            // miClose
            // 
            resources.ApplyResources(this.miClose, "miClose");
            this.miClose.Name = "miClose";
            this.miClose.Click += new System.EventHandler(this.Activate_miClose);
            // 
            // miNewDc
            // 
            resources.ApplyResources(this.miNewDc, "miNewDc");
            this.miNewDc.Name = "miNewDc";
            this.miNewDc.Click += new System.EventHandler(this.CreateNewDocumentContainer);
            // 
            // miUpdate
            // 
            resources.ApplyResources(this.miUpdate, "miUpdate");
            this.miUpdate.Name = "miUpdate";
            this.miUpdate.Click += new System.EventHandler(this.Activate_miUpdate);
            // 
            // menuBar1
            // 
            this.menuBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarItem1,
            this.miTools,
            this.miExtra,
            this.miWindow,
            this.menuBarItem5});
            resources.ApplyResources(this.menuBar1, "menuBar1");
            this.menuBar1.Name = "menuBar1";
            // 
            // menuBarItem1
            // 
            this.menuBarItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNew,
            this.miOpen,
            this.miOpenIn,
            this.miSave,
            this.miSaveAs,
            this.miSaveCopyAs,
            this.miClose,
            this.miRecent,
            this.toolStripMenuItem1,
            this.miExit});
            this.menuBarItem1.Name = "menuBarItem1";
            resources.ApplyResources(this.menuBarItem1, "menuBarItem1");
            // 
            // miOpenIn
            // 
            this.miOpenIn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpenSimsRes,
            this.miOpenDownloads});
            this.miOpenIn.Name = "miOpenIn";
            resources.ApplyResources(this.miOpenIn, "miOpenIn");
            // 
            // miOpenSimsRes
            // 
            this.miOpenSimsRes.Name = "miOpenSimsRes";
            resources.ApplyResources(this.miOpenSimsRes, "miOpenSimsRes");
            this.miOpenSimsRes.Click += new System.EventHandler(this.Activate_miOpenSimsRes);
            // 
            // miOpenDownloads
            // 
            this.miOpenDownloads.Name = "miOpenDownloads";
            resources.ApplyResources(this.miOpenDownloads, "miOpenDownloads");
            this.miOpenDownloads.Click += new System.EventHandler(this.Activate_miOpenDownloads);
            // 
            // miSaveCopyAs
            // 
            this.miSaveCopyAs.Name = "miSaveCopyAs";
            resources.ApplyResources(this.miSaveCopyAs, "miSaveCopyAs");
            this.miSaveCopyAs.Click += new System.EventHandler(this.Activate_miSaveCopyAs);
            // 
            // miRecent
            // 
            this.miRecent.Name = "miRecent";
            resources.ApplyResources(this.miRecent, "miRecent");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // miExit
            // 
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Name = "miExit";
            this.miExit.Click += new System.EventHandler(this.Activate_miExit);
            // 
            // miTools
            // 
            this.miTools.Name = "miTools";
            resources.ApplyResources(this.miTools, "miTools");
            // 
            // miExtra
            // 
            this.miExtra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMetaInfo,
            this.miFileNames,
            this.miRunSims,
            this.toolStripMenuItem2,
            this.miPref});
            this.miExtra.Name = "miExtra";
            resources.ApplyResources(this.miExtra, "miExtra");
            // 
            // miMetaInfo
            // 
            this.miMetaInfo.Name = "miMetaInfo";
            resources.ApplyResources(this.miMetaInfo, "miMetaInfo");
            this.miMetaInfo.Click += new System.EventHandler(this.Activate_miNoMeta);
            // 
            // miFileNames
            // 
            this.miFileNames.Checked = true;
            this.miFileNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.miFileNames.Name = "miFileNames";
            resources.ApplyResources(this.miFileNames, "miFileNames");
            this.miFileNames.Click += new System.EventHandler(this.Activate_miFileNames);
            // 
            // miRunSims
            // 
            resources.ApplyResources(this.miRunSims, "miRunSims");
            this.miRunSims.Name = "miRunSims";
            this.miRunSims.Click += new System.EventHandler(this.Activate_miRunSims);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // miPref
            // 
            resources.ApplyResources(this.miPref, "miPref");
            this.miPref.Name = "miPref";
            this.miPref.Click += new System.EventHandler(this.ShowPreferences);
            // 
            // miWindow
            // 
            this.miWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewDc});
            this.miWindow.Name = "miWindow";
            resources.ApplyResources(this.miWindow, "miWindow");
            // 
            // menuBarItem5
            // 
            this.menuBarItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUpdate,
            this.miTutorials,
            this.mbiTopics,
            this.toolStripMenuItem3,
            this.miAbout});
            this.menuBarItem5.Name = "menuBarItem5";
            resources.ApplyResources(this.menuBarItem5, "menuBarItem5");
            this.menuBarItem5.VisibleChanged += new System.EventHandler(this.menuBarItem5_VisibleChanged);
            // 
            // miTutorials
            // 
            resources.ApplyResources(this.miTutorials, "miTutorials");
            this.miTutorials.Name = "miTutorials";
            this.miTutorials.Click += new System.EventHandler(this.Activate_miTutorials);
            // 
            // mbiTopics
            // 
            resources.ApplyResources(this.mbiTopics, "mbiTopics");
            this.mbiTopics.Name = "mbiTopics";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // miAbout
            // 
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Name = "miAbout";
            this.miAbout.Click += new System.EventHandler(this.Activate_miAbout);
            // 
            // iAnim
            // 
            this.iAnim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iAnim.ImageStream")));
            this.iAnim.TransparentColor = System.Drawing.Color.Transparent;
            this.iAnim.Images.SetKeyName(0, "");
            this.iAnim.Images.SetKeyName(1, "");
            this.iAnim.Images.SetKeyName(2, "");
            this.iAnim.Images.SetKeyName(3, "");
            this.iAnim.Images.SetKeyName(4, "");
            this.iAnim.Images.SetKeyName(5, "");
            this.iAnim.Images.SetKeyName(6, "");
            this.iAnim.Images.SetKeyName(7, "");
            this.iAnim.Images.SetKeyName(8, "");
            // 
            // myrightSandDock
            // 
            this.myrightSandDock.Controls.Add(this.dcFilter);
            this.myrightSandDock.Controls.Add(this.dcAction);
            resources.ApplyResources(this.myrightSandDock, "myrightSandDock");
            this.myrightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(100, 525, new TD.SandDock.DockControl[] {
                        ((TD.SandDock.DockControl)(this.dcFilter)),
                        ((TD.SandDock.DockControl)(this.dcAction))}, this.dcFilter, false)))});
            this.myrightSandDock.Manager = this.sdm;
            this.myrightSandDock.Name = "myrightSandDock";
            // 
            // dcFilter
            // 
            this.dcFilter.Controls.Add(this.xpGradientPanel1);
            this.dcFilter.Guid = new System.Guid("c59bd96f-14b3-4922-a956-28fb5a9aec97");
            resources.ApplyResources(this.dcFilter, "dcFilter");
            this.dcFilter.Name = "dcFilter";
            this.dcFilter.TabImage = ((System.Drawing.Image)(resources.GetObject("dcFilter.TabImage")));
            this.dcFilter.SizeChanged += new System.EventHandler(this.dcFilter_SizeChanged);
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon3);
            this.xpGradientPanel1.Controls.Add(this.cbsemig);
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon2);
            this.xpGradientPanel1.Controls.Add(this.tbRcolName);
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon1);
            this.xpGradientPanel1.Controls.Add(this.tbInst);
            this.xpGradientPanel1.Controls.Add(this.tbGrp);
            resources.ApplyResources(this.xpGradientPanel1, "xpGradientPanel1");
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            // 
            // xpLinkedLabelIcon3
            // 
            resources.ApplyResources(this.xpLinkedLabelIcon3, "xpLinkedLabelIcon3");
            this.xpLinkedLabelIcon3.BackColor = System.Drawing.Color.Transparent;
            this.xpLinkedLabelIcon3.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.xpLinkedLabelIcon3.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.xpLinkedLabelIcon3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.xpLinkedLabelIcon3.Name = "xpLinkedLabelIcon3";
            this.xpLinkedLabelIcon3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.xpLinkedLabelIcon3.LinkClicked += new System.EventHandler(this.SetSemiGlobalFilter);
            // 
            // xpLinkedLabelIcon2
            // 
            resources.ApplyResources(this.xpLinkedLabelIcon2, "xpLinkedLabelIcon2");
            this.xpLinkedLabelIcon2.BackColor = System.Drawing.Color.Transparent;
            this.xpLinkedLabelIcon2.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.xpLinkedLabelIcon2.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.xpLinkedLabelIcon2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.xpLinkedLabelIcon2.Name = "xpLinkedLabelIcon2";
            this.xpLinkedLabelIcon2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.xpLinkedLabelIcon2.LinkClicked += new System.EventHandler(this.SetRcolNameFilter);
            // 
            // xpLinkedLabelIcon1
            // 
            this.xpLinkedLabelIcon1.BackColor = System.Drawing.Color.Transparent;
            this.xpLinkedLabelIcon1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.xpLinkedLabelIcon1, "xpLinkedLabelIcon1");
            this.xpLinkedLabelIcon1.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
            this.xpLinkedLabelIcon1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.xpLinkedLabelIcon1.Name = "xpLinkedLabelIcon1";
            this.xpLinkedLabelIcon1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.xpLinkedLabelIcon1.LinkClicked += new System.EventHandler(this.SetFilter);
            // 
            // dcAction
            // 
            this.dcAction.Controls.Add(this.xpGradientPanel2);
            this.dcAction.Guid = new System.Guid("8846d9fc-3828-4354-94b4-6a89120bbab3");
            resources.ApplyResources(this.dcAction, "dcAction");
            this.dcAction.Name = "dcAction";
            this.dcAction.TabImage = ((System.Drawing.Image)(resources.GetObject("dcAction.TabImage")));
            // 
            // xpGradientPanel2
            // 
            resources.ApplyResources(this.xpGradientPanel2, "xpGradientPanel2");
            this.xpGradientPanel2.Controls.Add(this.tbExtAction);
            this.xpGradientPanel2.Controls.Add(this.tbPlugAction);
            this.xpGradientPanel2.Controls.Add(this.tbDefaultAction);
            this.xpGradientPanel2.Name = "xpGradientPanel2";
            // 
            // tbExtAction
            // 
            this.tbExtAction.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tbExtAction, "tbExtAction");
            this.tbExtAction.Name = "tbExtAction";
            this.tbExtAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.tbExtAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
            this.tbExtAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbExtAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
            this.tbExtAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown")));
            this.tbExtAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight")));
            this.tbExtAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp")));
            this.tbExtAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight")));
            this.tbExtAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tbExtAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbExtAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.tbExtAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
            this.tbExtAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            // 
            // tbPlugAction
            // 
            this.tbPlugAction.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tbPlugAction, "tbPlugAction");
            this.tbPlugAction.Name = "tbPlugAction";
            this.tbPlugAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.tbPlugAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
            this.tbPlugAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbPlugAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
            this.tbPlugAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown1")));
            this.tbPlugAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight1")));
            this.tbPlugAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp1")));
            this.tbPlugAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight1")));
            this.tbPlugAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tbPlugAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbPlugAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.tbPlugAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
            this.tbPlugAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            // 
            // tbDefaultAction
            // 
            this.tbDefaultAction.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tbDefaultAction, "tbDefaultAction");
            this.tbDefaultAction.Name = "tbDefaultAction";
            this.tbDefaultAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            this.tbDefaultAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
            this.tbDefaultAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbDefaultAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
            this.tbDefaultAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown2")));
            this.tbDefaultAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight2")));
            this.tbDefaultAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp2")));
            this.tbDefaultAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight2")));
            this.tbDefaultAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.tbDefaultAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
            this.tbDefaultAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
            this.tbDefaultAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
            this.tbDefaultAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(210)))), ((int)(((byte)(240)))));
            // 
            // xpGradientPanel3
            // 
            resources.ApplyResources(this.xpGradientPanel3, "xpGradientPanel3");
            this.xpGradientPanel3.Name = "xpGradientPanel3";
            // 
            // xpGradientPanel5
            // 
            resources.ApplyResources(this.xpGradientPanel5, "xpGradientPanel5");
            this.xpGradientPanel5.Name = "xpGradientPanel5";
            // 
            // sfd
            // 
            resources.ApplyResources(this.sfd, "sfd");
            // 
            // resourceSelectionTimer
            // 
            this.resourceSelectionTimer.Interval = 75;
            this.resourceSelectionTimer.Tick += new System.EventHandler(this.resourceSelectionTimer_Tick);
            // 
            // waitControl1
            // 
            resources.ApplyResources(this.waitControl1, "waitControl1");
            this.waitControl1.Maximum = 1000;
            this.waitControl1.Message = "Hello";
            this.waitControl1.Name = "waitControl1";
            this.waitControl1.ShowAnimation = true;
            this.waitControl1.ShowProgress = true;
            this.waitControl1.ShowText = true;
            this.waitControl1.Value = 50;
            this.waitControl1.Waiting = false;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.tbContainer);
            this.Controls.Add(this.waitControl1);
            this.Controls.Add(this.menuBar1);
            this.MainMenuStrip = this.menuBar1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.LoadForm);
            this.tbContainer.ContentPanel.ResumeLayout(false);
            this.tbContainer.TopToolStripPanel.ResumeLayout(false);
            this.tbContainer.TopToolStripPanel.PerformLayout();
            this.tbContainer.ResumeLayout(false);
            this.tbContainer.PerformLayout();
            this.dockContainer1.ResumeLayout(false);
            this.dcResource.ResumeLayout(false);
            this.dcResource.PerformLayout();
            this.tbResource.ResumeLayout(false);
            this.tbResource.PerformLayout();
            this.mybottomSandDock.ResumeLayout(false);
            this.dcPlugin.ResumeLayout(false);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.menuBar1.ResumeLayout(false);
            this.menuBar1.PerformLayout();
            this.myrightSandDock.ResumeLayout(false);
            this.dcFilter.ResumeLayout(false);
            this.xpGradientPanel1.ResumeLayout(false);
            this.xpGradientPanel1.PerformLayout();
            this.dcAction.ResumeLayout(false);
            this.xpGradientPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
    }
}
