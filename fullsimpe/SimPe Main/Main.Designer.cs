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
using Ambertation.Windows.Forms;

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
        private ToolStripMenuItem miOpen;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
        private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon1;
        private ToolStripButton biOpen;
        private System.Windows.Forms.TextBox tbInst;
        private System.Windows.Forms.TextBox tbGrp;
        private ToolStripMenuItem miRecent;
        private ToolStripMenuItem miExtra;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
        private System.Windows.Forms.ImageList iAnim;
        private ToolStripMenuItem miTools;
        
        private ToolStripMenuItem miNewDc;
        private ToolStripMenuItem miMetaInfo;
        private ToolStripMenuItem miFileNames;
        private ToolStripMenuItem miExit;
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
        private ComboBox cbsemig;
        private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon3;
        private TD.SandDock.TabControl dc;
        private ToolStripMenuItem miSaveCopyAs;
        private ToolStripButton biReset;
        private ToolStripMenuItem mbiTopics;
        internal WaitControl waitControl1;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private DockManager manager;
        private DockPanel dcPlugin;
        private DockPanel dcAction;
        private DockPanel dcFilter;
        private DockPanel dcResource;
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
            Ambertation.Windows.Forms.WhidbeyRenderer whidbeyRenderer1 = new Ambertation.Windows.Forms.WhidbeyRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tbContainer = new System.Windows.Forms.ToolStripContainer();
            this.manager = new Ambertation.Windows.Forms.DockManager();
            this.dcResourceList = new Ambertation.Windows.Forms.DockPanel();
            this.lv = new SimPe.Windows.Forms.ResourceListViewExt();
            this.miAction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dockLeft = new Ambertation.Windows.Forms.DockContainer();
            this.dcResource = new Ambertation.Windows.Forms.DockPanel();
            this.tv = new SimPe.Windows.Forms.ResourceTreeViewExt();
            this.dockRight = new Ambertation.Windows.Forms.DockContainer();
            this.dcAction = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.tbExtAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.tbPlugAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.tbDefaultAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
            this.dcFilter = new Ambertation.Windows.Forms.DockPanel();
            this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbsemig = new System.Windows.Forms.ComboBox();
            this.tbRcolName = new System.Windows.Forms.TextBox();
            this.tbInst = new System.Windows.Forms.TextBox();
            this.tbGrp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xpLinkedLabelIcon3 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.xpLinkedLabelIcon2 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.xpLinkedLabelIcon1 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
            this.dockBottom = new Ambertation.Windows.Forms.DockContainer();
            this.dcPlugin = new Ambertation.Windows.Forms.DockPanel();
            this.dc = new TD.SandDock.TabControl();
            this.tbTools = new System.Windows.Forms.ToolStrip();
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biNew = new System.Windows.Forms.ToolStripButton();
            this.biOpen = new System.Windows.Forms.ToolStripButton();
            this.biSave = new System.Windows.Forms.ToolStripButton();
            this.biSaveAs = new System.Windows.Forms.ToolStripButton();
            this.biClose = new System.Windows.Forms.ToolStripButton();
            this.biNewDc = new System.Windows.Forms.ToolStripButton();
            this.biUpdate = new System.Windows.Forms.ToolStripButton();
            this.biReset = new System.Windows.Forms.ToolStripButton();
            this.tbAction = new System.Windows.Forms.ToolStrip();
            this.tbWindow = new System.Windows.Forms.ToolStrip();
            this.dockCenter = new Ambertation.Windows.Forms.DockContainer();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
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
            this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.xpGradientPanel5 = new SteepValley.Windows.Forms.XPGradientPanel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.waitControl1 = new SimPe.WaitControl();
            this.resourceViewManager1 = new SimPe.Windows.Forms.ResourceViewManager();
            this.tbContainer.ContentPanel.SuspendLayout();
            this.tbContainer.TopToolStripPanel.SuspendLayout();
            this.tbContainer.SuspendLayout();
            this.manager.SuspendLayout();
            this.dcResourceList.SuspendLayout();
            this.dockLeft.SuspendLayout();
            this.dcResource.SuspendLayout();
            this.dockRight.SuspendLayout();
            this.dcAction.SuspendLayout();
            this.xpGradientPanel2.SuspendLayout();
            this.dcFilter.SuspendLayout();
            this.xpGradientPanel1.SuspendLayout();
            this.dockBottom.SuspendLayout();
            this.dcPlugin.SuspendLayout();
            this.toolBar1.SuspendLayout();
            this.menuBar1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbContainer
            // 
            // 
            // tbContainer.ContentPanel
            // 
            this.tbContainer.ContentPanel.Controls.Add(this.manager);
            resources.ApplyResources(this.tbContainer.ContentPanel, "tbContainer.ContentPanel");
            resources.ApplyResources(this.tbContainer, "tbContainer");
            this.tbContainer.Name = "tbContainer";
            // 
            // tbContainer.TopToolStripPanel
            // 
            this.tbContainer.TopToolStripPanel.Controls.Add(this.toolBar1);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbAction);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbTools);
            this.tbContainer.TopToolStripPanel.Controls.Add(this.tbWindow);
            // 
            // manager
            // 
            this.manager.Controls.Add(this.dcResourceList);
            this.manager.Controls.Add(this.dockLeft);
            this.manager.Controls.Add(this.dockRight);
            this.manager.Controls.Add(this.dockBottom);
            this.manager.DefaultSize = new System.Drawing.Size(100, 100);
            resources.ApplyResources(this.manager, "manager");
            this.manager.DragBorder = true;
            this.manager.Manager = this.manager;
            this.manager.MinimumSize = new System.Drawing.Size(150, 150);
            this.manager.Name = "manager";
            this.manager.NoCleanup = true;
            this.manager.Renderer = whidbeyRenderer1;
            this.manager.TabImage = null;
            this.manager.TabText = "";
            // 
            // dcResourceList
            // 
            this.dcResourceList.AllowClose = true;
            this.dcResourceList.AllowCollapse = true;
            this.dcResourceList.AllowDockBottom = true;
            this.dcResourceList.AllowDockCenter = true;
            this.dcResourceList.AllowDockLeft = true;
            this.dcResourceList.AllowDockRight = true;
            this.dcResourceList.AllowDockTop = true;
            this.dcResourceList.AllowFloat = true;
            resources.ApplyResources(this.dcResourceList, "dcResourceList");
            this.dcResourceList.CanResize = true;
            this.dcResourceList.CanUndock = true;
            this.dcResourceList.Controls.Add(this.lv);
            this.dcResourceList.DockContainer = this.manager;
            this.dcResourceList.DragBorder = false;
            this.dcResourceList.FloatingSize = new System.Drawing.Size(434, 377);
            this.dcResourceList.Image = ((System.Drawing.Image)(resources.GetObject("dcResourceList.Image")));
            this.dcResourceList.Manager = this.manager;
            this.dcResourceList.Name = "dcResourceList";
            this.dcResourceList.ShowCloseButton = true;
            this.dcResourceList.ShowCollapseButton = true;
            this.dcResourceList.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResourceList.TabImage")));
            this.dcResourceList.TabText = "List";
            this.dcResourceList.UndockByCaptionThreshold = 150;
            // 
            // lv
            // 
            this.lv.AllowDrop = true;
            this.lv.ContextMenuStrip = this.miAction;
            resources.ApplyResources(this.lv, "lv");
            this.lv.Filter = null;
            this.lv.Name = "lv";
            this.lv.SortedColumn = SimPe.Windows.Forms.ResourceViewManager.SortColumn.Offset;
            this.lv.ListViewKeyUp += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyUp);
            this.lv.SelectionChanged += new System.EventHandler(this.lv_SelectionChanged);
            this.lv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.lv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            this.lv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyUp);
            this.lv.SelectedResource += new SimPe.Windows.Forms.ResourceListViewExt.SelectResourceHandler(this.lv_SelectResource);
            // 
            // miAction
            // 
            this.miAction.Name = "miAction";
            resources.ApplyResources(this.miAction, "miAction");
            // 
            // dockLeft
            // 
            this.dockLeft.Controls.Add(this.dcResource);
            resources.ApplyResources(this.dockLeft, "dockLeft");
            this.dockLeft.DragBorder = true;
            this.dockLeft.Manager = this.manager;
            this.dockLeft.MinimumSize = new System.Drawing.Size(150, 150);
            this.dockLeft.Name = "dockLeft";
            this.dockLeft.NoCleanup = false;
            this.dockLeft.TabImage = null;
            this.dockLeft.TabText = "";
            // 
            // dcResource
            // 
            this.dcResource.AllowClose = true;
            this.dcResource.AllowCollapse = true;
            this.dcResource.AllowDockBottom = true;
            this.dcResource.AllowDockCenter = true;
            this.dcResource.AllowDockLeft = true;
            this.dcResource.AllowDockRight = true;
            this.dcResource.AllowDockTop = true;
            this.dcResource.AllowFloat = true;
            resources.ApplyResources(this.dcResource, "dcResource");
            this.dcResource.CanResize = true;
            this.dcResource.CanUndock = true;
            this.dcResource.Controls.Add(this.tv);
            this.dcResource.DockContainer = this.dockLeft;
            this.dcResource.DragBorder = false;
            this.dcResource.FloatingSize = new System.Drawing.Size(236, 377);
            this.dcResource.Image = ((System.Drawing.Image)(resources.GetObject("dcResource.Image")));
            this.dcResource.Manager = this.manager;
            this.dcResource.Name = "dcResource";
            this.dcResource.ShowCloseButton = true;
            this.dcResource.ShowCollapseButton = true;
            this.dcResource.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResource.TabImage")));
            this.dcResource.TabText = "Resource Tree";
            this.dcResource.UndockByCaptionThreshold = 150;
            // 
            // tv
            // 
            this.tv.AllowDrop = true;
            resources.ApplyResources(this.tv, "tv");
            this.tv.Name = "tv";
            this.tv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.tv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            // 
            // dockRight
            // 
            this.dockRight.Controls.Add(this.dcAction);
            this.dockRight.Controls.Add(this.dcFilter);
            resources.ApplyResources(this.dockRight, "dockRight");
            this.dockRight.DragBorder = true;
            this.dockRight.Manager = this.manager;
            this.dockRight.MinimumSize = new System.Drawing.Size(150, 150);
            this.dockRight.Name = "dockRight";
            this.dockRight.NoCleanup = false;
            this.dockRight.TabImage = null;
            this.dockRight.TabText = "";
            // 
            // dcAction
            // 
            this.dcAction.AllowClose = true;
            this.dcAction.AllowCollapse = true;
            this.dcAction.AllowDockBottom = true;
            this.dcAction.AllowDockCenter = true;
            this.dcAction.AllowDockLeft = true;
            this.dcAction.AllowDockRight = true;
            this.dcAction.AllowDockTop = true;
            this.dcAction.AllowFloat = true;
            resources.ApplyResources(this.dcAction, "dcAction");
            this.dcAction.CanResize = true;
            this.dcAction.CanUndock = true;
            this.dcAction.Controls.Add(this.xpGradientPanel2);
            this.dcAction.DockContainer = this.dockRight;
            this.dcAction.DragBorder = false;
            this.dcAction.FloatingSize = new System.Drawing.Size(246, 327);
            this.dcAction.Image = ((System.Drawing.Image)(resources.GetObject("dcAction.Image")));
            this.dcAction.Manager = this.manager;
            this.dcAction.Name = "dcAction";
            this.dcAction.ShowCloseButton = true;
            this.dcAction.ShowCollapseButton = true;
            this.dcAction.TabImage = ((System.Drawing.Image)(resources.GetObject("dcAction.TabImage")));
            this.dcAction.TabText = "Resource Actions";
            this.dcAction.UndockByCaptionThreshold = 150;
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
            // dcFilter
            // 
            this.dcFilter.AllowClose = true;
            this.dcFilter.AllowCollapse = true;
            this.dcFilter.AllowDockBottom = true;
            this.dcFilter.AllowDockCenter = true;
            this.dcFilter.AllowDockLeft = true;
            this.dcFilter.AllowDockRight = true;
            this.dcFilter.AllowDockTop = true;
            this.dcFilter.AllowFloat = true;
            resources.ApplyResources(this.dcFilter, "dcFilter");
            this.dcFilter.CanResize = true;
            this.dcFilter.CanUndock = true;
            this.dcFilter.Controls.Add(this.xpGradientPanel1);
            this.dcFilter.DockContainer = this.dockRight;
            this.dcFilter.DragBorder = false;
            this.dcFilter.FloatingSize = new System.Drawing.Size(246, 377);
            this.dcFilter.Image = ((System.Drawing.Image)(resources.GetObject("dcFilter.Image")));
            this.dcFilter.Manager = this.manager;
            this.dcFilter.Name = "dcFilter";
            this.dcFilter.ShowCloseButton = true;
            this.dcFilter.ShowCollapseButton = true;
            this.dcFilter.TabImage = ((System.Drawing.Image)(resources.GetObject("dcFilter.TabImage")));
            this.dcFilter.TabText = "Filter Resources";
            this.dcFilter.UndockByCaptionThreshold = 150;
            this.dcFilter.SizeChanged += new System.EventHandler(this.dcFilter_SizeChanged);
            // 
            // xpGradientPanel1
            // 
            this.xpGradientPanel1.Controls.Add(this.label1);
            this.xpGradientPanel1.Controls.Add(this.label5);
            this.xpGradientPanel1.Controls.Add(this.cbsemig);
            this.xpGradientPanel1.Controls.Add(this.tbRcolName);
            this.xpGradientPanel1.Controls.Add(this.tbInst);
            this.xpGradientPanel1.Controls.Add(this.tbGrp);
            this.xpGradientPanel1.Controls.Add(this.label3);
            this.xpGradientPanel1.Controls.Add(this.label2);
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon3);
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon2);
            this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon1);
            resources.ApplyResources(this.xpGradientPanel1, "xpGradientPanel1");
            this.xpGradientPanel1.Name = "xpGradientPanel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Name = "label5";
            // 
            // cbsemig
            // 
            resources.ApplyResources(this.cbsemig, "cbsemig");
            this.xpCueBannerExtender1.SetCueBannerText(this.cbsemig, "Semiglobal Group");
            this.cbsemig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsemig.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbsemig.Name = "cbsemig";
            // 
            // tbRcolName
            // 
            resources.ApplyResources(this.tbRcolName, "tbRcolName");
            this.xpCueBannerExtender1.SetCueBannerText(this.tbRcolName, "RCOL Filename");
            this.tbRcolName.Name = "tbRcolName";
            this.tbRcolName.SizeChanged += new System.EventHandler(this.tbRcolName_SizeChanged);
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
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Name = "label2";
            // 
            // xpLinkedLabelIcon3
            // 
            resources.ApplyResources(this.xpLinkedLabelIcon3, "xpLinkedLabelIcon3");
            this.xpLinkedLabelIcon3.BackColor = System.Drawing.Color.Transparent;
            this.xpLinkedLabelIcon3.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.xpLinkedLabelIcon3.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
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
            this.xpLinkedLabelIcon2.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
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
            this.xpLinkedLabelIcon1.LinkArea = new System.Windows.Forms.LinkArea(0, 7);
            this.xpLinkedLabelIcon1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.xpLinkedLabelIcon1.Name = "xpLinkedLabelIcon1";
            this.xpLinkedLabelIcon1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
            this.xpLinkedLabelIcon1.LinkClicked += new System.EventHandler(this.SetFilter);
            // 
            // dockBottom
            // 
            this.dockBottom.Controls.Add(this.dcPlugin);
            resources.ApplyResources(this.dockBottom, "dockBottom");
            this.dockBottom.DragBorder = true;
            this.dockBottom.Manager = this.manager;
            this.dockBottom.MinimumSize = new System.Drawing.Size(150, 150);
            this.dockBottom.Name = "dockBottom";
            this.dockBottom.NoCleanup = false;
            this.dockBottom.TabImage = null;
            this.dockBottom.TabText = "";
            // 
            // dcPlugin
            // 
            this.dcPlugin.AllowClose = true;
            this.dcPlugin.AllowCollapse = true;
            this.dcPlugin.AllowDockBottom = true;
            this.dcPlugin.AllowDockCenter = true;
            this.dcPlugin.AllowDockLeft = true;
            this.dcPlugin.AllowDockRight = true;
            this.dcPlugin.AllowDockTop = true;
            this.dcPlugin.AllowFloat = true;
            resources.ApplyResources(this.dcPlugin, "dcPlugin");
            this.dcPlugin.CanResize = true;
            this.dcPlugin.CanUndock = true;
            this.dcPlugin.Controls.Add(this.dc);
            this.dcPlugin.DockContainer = this.dockBottom;
            this.dcPlugin.DragBorder = false;
            this.dcPlugin.FloatingSize = new System.Drawing.Size(924, 146);
            this.dcPlugin.Image = ((System.Drawing.Image)(resources.GetObject("dcPlugin.Image")));
            this.dcPlugin.Manager = this.manager;
            this.dcPlugin.Name = "dcPlugin";
            this.dcPlugin.ShowCloseButton = true;
            this.dcPlugin.ShowCollapseButton = true;
            this.dcPlugin.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPlugin.TabImage")));
            this.dcPlugin.TabText = "Plugin View";
            this.dcPlugin.UndockByCaptionThreshold = 150;
            // 
            // dc
            // 
            resources.ApplyResources(this.dc, "dc");
            this.dc.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.DocumentLayoutSystem(903, 373, new TD.SandDock.DockControl[0], null)))});
            this.dc.Name = "dc";
            this.dc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dc_MouseUp);
            // 
            // tbTools
            // 
            resources.ApplyResources(this.tbTools, "tbTools");
            this.tbTools.Name = "tbTools";
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
            // tbAction
            // 
            resources.ApplyResources(this.tbAction, "tbAction");
            this.tbAction.Name = "tbAction";
            // 
            // tbWindow
            // 
            resources.ApplyResources(this.tbWindow, "tbWindow");
            this.tbWindow.Name = "tbWindow";
            // 
            // dockCenter
            // 
            resources.ApplyResources(this.dockCenter, "dockCenter");
            this.dockCenter.DragBorder = true;
            this.dockCenter.Manager = this.manager;
            this.dockCenter.MinimumSize = new System.Drawing.Size(150, 150);
            this.dockCenter.Name = "dockCenter";
            this.dockCenter.NoCleanup = false;
            this.dockCenter.TabImage = null;
            this.dockCenter.TabText = "";
            // 
            // ofd
            // 
            resources.ApplyResources(this.ofd, "ofd");
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
            // waitControl1
            // 
            resources.ApplyResources(this.waitControl1, "waitControl1");
            this.waitControl1.Image = null;
            this.waitControl1.MaxProgress = 1000;
            this.waitControl1.Message = "";
            this.waitControl1.Name = "waitControl1";
            this.waitControl1.Progress = 0;
            this.waitControl1.ShowAnimation = true;
            this.waitControl1.ShowProgress = false;
            this.waitControl1.ShowText = true;
            this.waitControl1.Waiting = false;
            // 
            // resourceViewManager1
            // 
            this.resourceViewManager1.ListView = this.lv;
            this.resourceViewManager1.Package = null;
            this.resourceViewManager1.TreeView = this.tv;
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
            this.manager.ResumeLayout(false);
            this.dcResourceList.ResumeLayout(false);
            this.dockLeft.ResumeLayout(false);
            this.dcResource.ResumeLayout(false);
            this.dockRight.ResumeLayout(false);
            this.dcAction.ResumeLayout(false);
            this.xpGradientPanel2.ResumeLayout(false);
            this.dcFilter.ResumeLayout(false);
            this.xpGradientPanel1.ResumeLayout(false);
            this.xpGradientPanel1.PerformLayout();
            this.dockBottom.ResumeLayout(false);
            this.dcPlugin.ResumeLayout(false);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.menuBar1.ResumeLayout(false);
            this.menuBar1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private DockContainer dockLeft;
        private DockContainer dockRight;
        private DockContainer dockBottom;
        private DockContainer dockCenter;
        private DockPanel dcResourceList;
        private SimPe.Windows.Forms.ResourceListViewExt lv;
        private SimPe.Windows.Forms.ResourceTreeViewExt tv;
        private SimPe.Windows.Forms.ResourceViewManager resourceViewManager1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;

    }
}
