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
	/// <summary>
	/// Zusammenfassung für MainForm.
	/// </summary>
	public class MainForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.OpenFileDialog ofd;
		private SteepValley.Windows.Forms.XPCueBannerExtender xpCueBannerExtender1;
		private TD.SandBar.ToolBarContainer leftSandBarDock;
		private TD.SandBar.ToolBarContainer rightSandBarDock;	
		private TD.SandBar.ToolBarContainer topSandBarDock;
		private TD.SandBar.MenuBar menuBar1;
		private TD.SandBar.MenuBarItem menuBarItem1;
		private TD.SandBar.MenuBarItem menuBarItem5;
		private TD.SandBar.ToolBar toolBar1;
		private TD.SandDock.DockableWindow dcFilter;
		private TD.SandBar.MenuButtonItem miOpen;
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
		private TD.SandBar.ButtonItem biOpen;
		private System.Windows.Forms.TextBox tbInst;
		private System.Windows.Forms.TextBox tbGrp;
		private TD.SandBar.SandBarManager sbm;
		private TD.SandDock.SandDockManager sdm;
		private TD.SandBar.ButtonItem biTypeList;
		private TD.SandBar.ButtonItem biGroupList;
		private TD.SandBar.ButtonItem biInstanceList;
		private TD.SandBar.ToolBar tbResource;
		private TD.SandDock.DockableWindow dcResource;
		private TD.SandBar.MenuButtonItem miRecent;
		private TD.SandBar.MenuBarItem miExtra;
		private TD.SandDock.DockableWindow dcAction;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
        private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
        private System.Windows.Forms.ImageList iAnim;
		private TD.SandBar.MenuBarItem miTools;
		private TD.SandDock.DockContainer myrightSandDock;
		private TD.SandDock.DockContainer mybottomSandDock;
		private TD.SandBar.ToolBarContainer mybottomSandBarDock;
		private TD.SandBar.MenuButtonItem miNewDc;
		private TD.SandDock.DockableWindow dcPlugin;
		private TD.SandBar.MenuButtonItem miMetaInfo;
		private TD.SandBar.MenuButtonItem miFileNames;
		private TD.SandBar.MenuButtonItem miExit;
		private System.Windows.Forms.ColumnHeader clOffset;
		private System.Windows.Forms.ColumnHeader clSize;
		private TD.SandBar.MenuButtonItem miRunSims;
		private TD.SandBar.MenuBarItem miWindow;
		private TD.SandBar.MenuButtonItem miSave;
		private System.Windows.Forms.SaveFileDialog sfd;
		private TD.SandBar.MenuButtonItem miSaveAs;
		private TD.SandBar.MenuButtonItem miClose;
		private TD.SandBar.ButtonItem biSave;
		private TD.SandBar.ButtonItem biClose;
		private TD.SandBar.ButtonItem biSaveAs;
		private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbDefaultAction;
		private TD.SandBar.ContextMenuBarItem miAction;
		private TD.SandBar.ToolBar tbAction;
		private TD.SandBar.ButtonItem biNewDc;
		private TD.SandBar.MenuButtonItem miPref;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel5;
		private TD.SandBar.MenuButtonItem miNew;
		private TD.SandBar.ButtonItem biNew;
		private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbExtAction;
		private SteepValley.Windows.Forms.ThemedControls.XPTaskBox tbPlugAction;
		private TD.SandBar.MenuButtonItem miAbout;
		private TD.SandBar.MenuButtonItem miUpdate;
		private TD.SandBar.MenuButtonItem miTutorials;
		private TD.SandBar.ButtonItem biUpdate;
		private TD.SandBar.MenuButtonItem miOpenIn;
		private TD.SandBar.MenuButtonItem miOpenSimsRes;
		private TD.SandBar.MenuButtonItem miOpenUniRes;
		private TD.SandBar.MenuButtonItem miOpenDownloads;
		private System.Windows.Forms.TextBox tbRcolName;
		private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon2;
		private TD.SandBar.ToolBar tbTools;
		private TD.SandBar.ToolBar tbWindow;
		private TD.SandBar.FlatComboBox cbsemig;
		private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon3;
		private TD.SandDock.TabControl dc;
		private TD.SandDock.DockContainer dockContainer1;
		private System.Windows.Forms.Timer resourceSelectionTimer;
		private TD.SandBar.MenuButtonItem miSaveCopyAs;
		private TD.SandBar.MenuButtonItem miOpenNightlifeRes;
		private TD.SandBar.ButtonItem biReset;
		private TD.SandBar.MenuButtonItem miOpenBusinessRes;
		private TD.SandBar.MenuButtonItem mbiTopics;
		private TD.SandBar.MenuButtonItem miOpenFamilyFunRes;
        internal WaitControl waitControl1;
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();
            
			WaitBarControl wbc = new WaitBarControl(this);
			Wait.Bar = wbc;

			package = new LoadedPackage();			
			package.BeforeFileLoad += new PackageFileLoadEvent(BeforeFileLoad);
			package.AfterFileLoad += new PackageFileLoadedEvent(AfterFileLoad);
			package.BeforeFileSave += new PackageFileSaveEvent(BeforeFileSave);
			package.AfterFileSave += new PackageFileSavedEvent(AfterFileSave);
			package.IndexChanged += new EventHandler(ChangedActiveIndex);
			package.AddedResource += new EventHandler(AddedRemovedIndexResource);
			package.RemovedResource += new EventHandler(AddedRemovedIndexResource);
			
			filter = new ViewFilter();
			treebuilder = new TreeBuilder(package, filter);
            resloader = new ResourceLoader(dc, package);
            remote = new RemoteHandler(this, package, resloader, miWindow);

			plugger = new PluginManager(
				miTools, 
				tbTools,
				dc, 
				package,
				tbDefaultAction,
				miAction,
				tbExtAction,
				tbPlugAction,
				tbAction,
				dcPlugin,
				this.mbiTopics);
			plugger.ClosedToolPlugin += new ToolMenuItemExt.ExternalToolNotify(ClosedToolPlugin);
            remote.SetPlugger(plugger);

						
			remote.LoadedResource += new ChangedResourceEvent(rh_LoadedResource);
			
			SetupResourceViewToolBar();
			package.UpdateRecentFileMenu(this.miRecent);

			InitThemer();
			mybottomSandDock.Height = ((this.Height * 3) /4);			
			this.Text += " (Version "+Helper.SimPeVersion.ProductVersion+")";

			sdm.MaximumDockContainerSize = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
			TD.SandDock.SandDockManager sdm2 = new TD.SandDock.SandDockManager();
			sdm2.OwnerForm = this;
			ThemeManager.Global.AddControl(sdm2);			
			this.dc.Manager = sdm2;	
		
			lv.SmallImageList = FileTable.WrapperRegistry.WrapperImageList;
			this.tvType.ImageList = FileTable.WrapperRegistry.WrapperImageList;

			InitMenuItems();
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
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
            this.sbm = new TD.SandBar.SandBarManager();
            this.mybottomSandDock = new TD.SandDock.DockContainer();
            this.dcPlugin = new TD.SandDock.DockableWindow();
            this.dc = new TD.SandDock.TabControl();
            this.sdm = new TD.SandDock.SandDockManager();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
            this.tbInst = new System.Windows.Forms.TextBox();
            this.tbGrp = new System.Windows.Forms.TextBox();
            this.tbRcolName = new System.Windows.Forms.TextBox();
            this.cbsemig = new TD.SandBar.FlatComboBox();
            this.leftSandBarDock = new TD.SandBar.ToolBarContainer();
            this.rightSandBarDock = new TD.SandBar.ToolBarContainer();
            this.mybottomSandBarDock = new TD.SandBar.ToolBarContainer();
            this.topSandBarDock = new TD.SandBar.ToolBarContainer();
            this.toolBar1 = new TD.SandBar.ToolBar();
            this.biNew = new TD.SandBar.ButtonItem();
            this.miNew = new TD.SandBar.MenuButtonItem();
            this.biOpen = new TD.SandBar.ButtonItem();
            this.miOpen = new TD.SandBar.MenuButtonItem();
            this.biSave = new TD.SandBar.ButtonItem();
            this.miSave = new TD.SandBar.MenuButtonItem();
            this.biSaveAs = new TD.SandBar.ButtonItem();
            this.miSaveAs = new TD.SandBar.MenuButtonItem();
            this.biClose = new TD.SandBar.ButtonItem();
            this.miClose = new TD.SandBar.MenuButtonItem();
            this.biNewDc = new TD.SandBar.ButtonItem();
            this.miNewDc = new TD.SandBar.MenuButtonItem();
            this.biUpdate = new TD.SandBar.ButtonItem();
            this.miUpdate = new TD.SandBar.MenuButtonItem();
            this.biReset = new TD.SandBar.ButtonItem();
            this.tbAction = new TD.SandBar.ToolBar();
            this.tbTools = new TD.SandBar.ToolBar();
            this.tbWindow = new TD.SandBar.ToolBar();
            this.menuBar1 = new TD.SandBar.MenuBar();
            this.menuBarItem1 = new TD.SandBar.MenuBarItem();
            this.miOpenIn = new TD.SandBar.MenuButtonItem();
            this.miOpenSimsRes = new TD.SandBar.MenuButtonItem();
            this.miOpenUniRes = new TD.SandBar.MenuButtonItem();
            this.miOpenNightlifeRes = new TD.SandBar.MenuButtonItem();
            this.miOpenBusinessRes = new TD.SandBar.MenuButtonItem();
            this.miOpenFamilyFunRes = new TD.SandBar.MenuButtonItem();
            this.miOpenDownloads = new TD.SandBar.MenuButtonItem();
            this.miSaveCopyAs = new TD.SandBar.MenuButtonItem();
            this.miRecent = new TD.SandBar.MenuButtonItem();
            this.miExit = new TD.SandBar.MenuButtonItem();
            this.miTools = new TD.SandBar.MenuBarItem();
            this.miExtra = new TD.SandBar.MenuBarItem();
            this.miMetaInfo = new TD.SandBar.MenuButtonItem();
            this.miFileNames = new TD.SandBar.MenuButtonItem();
            this.miRunSims = new TD.SandBar.MenuButtonItem();
            this.miPref = new TD.SandBar.MenuButtonItem();
            this.miWindow = new TD.SandBar.MenuBarItem();
            this.menuBarItem5 = new TD.SandBar.MenuBarItem();
            this.miTutorials = new TD.SandBar.MenuButtonItem();
            this.mbiTopics = new TD.SandBar.MenuButtonItem();
            this.miAbout = new TD.SandBar.MenuButtonItem();
            this.miAction = new TD.SandBar.ContextMenuBarItem();
            this.lv = new SimPe.ResourceListView();
            this.clType = new System.Windows.Forms.ColumnHeader();
            this.clGroup = new System.Windows.Forms.ColumnHeader();
            this.clInstanceHigh = new System.Windows.Forms.ColumnHeader();
            this.clInstance = new System.Windows.Forms.ColumnHeader();
            this.clOffset = new System.Windows.Forms.ColumnHeader();
            this.clSize = new System.Windows.Forms.ColumnHeader();
            this.iAnim = new System.Windows.Forms.ImageList(this.components);
            this.dcResource = new TD.SandDock.DockableWindow();
            this.tbResource = new TD.SandBar.ToolBar();
            this.biInstanceList = new TD.SandBar.ButtonItem();
            this.biGroupList = new TD.SandBar.ButtonItem();
            this.biTypeList = new TD.SandBar.ButtonItem();
            this.tvType = new System.Windows.Forms.TreeView();
            this.tvGroup = new System.Windows.Forms.TreeView();
            this.tvInstance = new System.Windows.Forms.TreeView();
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
            this.dockContainer1 = new TD.SandDock.DockContainer();
            this.resourceSelectionTimer = new System.Windows.Forms.Timer(this.components);
            this.waitControl1 = new SimPe.WaitControl();
            this.mybottomSandDock.SuspendLayout();
            this.dcPlugin.SuspendLayout();
            this.topSandBarDock.SuspendLayout();
            this.dcResource.SuspendLayout();
            this.myrightSandDock.SuspendLayout();
            this.dcFilter.SuspendLayout();
            this.xpGradientPanel1.SuspendLayout();
            this.dcAction.SuspendLayout();
            this.xpGradientPanel2.SuspendLayout();
            this.dockContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbm
            // 
            this.sbm.OwnerForm = this;
            // 
            // mybottomSandDock
            // 
            this.mybottomSandDock.Controls.Add(this.dcPlugin);
            resources.ApplyResources(this.mybottomSandDock, "mybottomSandDock");
            this.mybottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Vertical, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(820, 100, new TD.SandDock.DockControl[] {
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
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.DocumentLayoutSystem(801, 373, new TD.SandDock.DockControl[0], null)))});
            this.dc.Name = "dc";
            this.dc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dc_MouseUp);
            // 
            // sdm
            // 
            this.sdm.DockSystemContainer = this;
            this.sdm.OwnerForm = this;
            this.sdm.Renderer = new TD.SandDock.Rendering.Office2003Renderer();
            this.sdm.DockControlActivated += new TD.SandDock.DockControlEventHandler(this.sdm_DockControlActivated);
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
            // leftSandBarDock
            // 
            resources.ApplyResources(this.leftSandBarDock, "leftSandBarDock");
            this.leftSandBarDock.Guid = new System.Guid("259c7353-51eb-45a8-b368-6e61813bb778");
            this.leftSandBarDock.Manager = this.sbm;
            this.leftSandBarDock.Name = "leftSandBarDock";
            // 
            // rightSandBarDock
            // 
            resources.ApplyResources(this.rightSandBarDock, "rightSandBarDock");
            this.rightSandBarDock.Guid = new System.Guid("b0a914ac-a821-4755-a65a-d3ef139f161f");
            this.rightSandBarDock.Manager = this.sbm;
            this.rightSandBarDock.Name = "rightSandBarDock";
            // 
            // mybottomSandBarDock
            // 
            resources.ApplyResources(this.mybottomSandBarDock, "mybottomSandBarDock");
            this.mybottomSandBarDock.Guid = new System.Guid("c452d62e-8add-4aea-b568-1ab19c105d91");
            this.mybottomSandBarDock.Manager = this.sbm;
            this.mybottomSandBarDock.Name = "mybottomSandBarDock";
            // 
            // topSandBarDock
            // 
            this.topSandBarDock.Controls.Add(this.toolBar1);
            this.topSandBarDock.Controls.Add(this.tbAction);
            this.topSandBarDock.Controls.Add(this.tbTools);
            this.topSandBarDock.Controls.Add(this.tbWindow);
            this.topSandBarDock.Controls.Add(this.menuBar1);
            resources.ApplyResources(this.topSandBarDock, "topSandBarDock");
            this.topSandBarDock.Guid = new System.Guid("4e621434-1359-4257-9c51-7ad4b9ca98c9");
            this.topSandBarDock.Manager = this.sbm;
            this.topSandBarDock.Name = "topSandBarDock";
            // 
            // toolBar1
            // 
            this.toolBar1.DockLine = 1;
            this.toolBar1.Guid = new System.Guid("450cfa2c-067d-435a-bc20-a98c7b00b268");
            this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.biNew,
            this.biOpen,
            this.biSave,
            this.biSaveAs,
            this.biClose,
            this.biNewDc,
            this.biUpdate,
            this.biReset});
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowShortcutsInToolTips = true;
            // 
            // biNew
            // 
            this.biNew.BuddyMenu = this.miNew;
            this.biNew.Image = ((System.Drawing.Image)(resources.GetObject("biNew.Image")));
            this.biNew.ItemImportance = TD.SandBar.ItemImportance.Low;
            resources.ApplyResources(this.biNew, "biNew");
            // 
            // miNew
            // 
            this.miNew.Image = ((System.Drawing.Image)(resources.GetObject("miNew.Image")));
            resources.ApplyResources(this.miNew, "miNew");
            this.miNew.Activate += new System.EventHandler(this.Activate_miNew);
            // 
            // biOpen
            // 
            this.biOpen.BuddyMenu = this.miOpen;
            this.biOpen.Image = ((System.Drawing.Image)(resources.GetObject("biOpen.Image")));
            this.biOpen.ItemImportance = TD.SandBar.ItemImportance.Highest;
            resources.ApplyResources(this.biOpen, "biOpen");
            // 
            // miOpen
            // 
            this.miOpen.Image = ((System.Drawing.Image)(resources.GetObject("miOpen.Image")));
            resources.ApplyResources(this.miOpen, "miOpen");
            this.miOpen.Activate += new System.EventHandler(this.Activate_miOpen);
            // 
            // biSave
            // 
            this.biSave.BuddyMenu = this.miSave;
            this.biSave.Image = ((System.Drawing.Image)(resources.GetObject("biSave.Image")));
            this.biSave.ItemImportance = TD.SandBar.ItemImportance.High;
            resources.ApplyResources(this.biSave, "biSave");
            // 
            // miSave
            // 
            this.miSave.Image = ((System.Drawing.Image)(resources.GetObject("miSave.Image")));
            resources.ApplyResources(this.miSave, "miSave");
            this.miSave.Activate += new System.EventHandler(this.Activate_miSave);
            // 
            // biSaveAs
            // 
            this.biSaveAs.BuddyMenu = this.miSaveAs;
            this.biSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("biSaveAs.Image")));
            this.biSaveAs.ItemImportance = TD.SandBar.ItemImportance.Lowest;
            resources.ApplyResources(this.biSaveAs, "biSaveAs");
            // 
            // miSaveAs
            // 
            this.miSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("miSaveAs.Image")));
            resources.ApplyResources(this.miSaveAs, "miSaveAs");
            this.miSaveAs.Activate += new System.EventHandler(this.Activate_miSaveAs);
            // 
            // biClose
            // 
            this.biClose.BuddyMenu = this.miClose;
            this.biClose.Image = ((System.Drawing.Image)(resources.GetObject("biClose.Image")));
            this.biClose.ItemImportance = TD.SandBar.ItemImportance.Low;
            resources.ApplyResources(this.biClose, "biClose");
            // 
            // miClose
            // 
            this.miClose.Image = ((System.Drawing.Image)(resources.GetObject("miClose.Image")));
            resources.ApplyResources(this.miClose, "miClose");
            this.miClose.Activate += new System.EventHandler(this.Activate_miClose);
            // 
            // biNewDc
            // 
            this.biNewDc.BeginGroup = true;
            this.biNewDc.BuddyMenu = this.miNewDc;
            this.biNewDc.Image = ((System.Drawing.Image)(resources.GetObject("biNewDc.Image")));
            resources.ApplyResources(this.biNewDc, "biNewDc");
            // 
            // miNewDc
            // 
            this.miNewDc.Image = ((System.Drawing.Image)(resources.GetObject("miNewDc.Image")));
            resources.ApplyResources(this.miNewDc, "miNewDc");
            this.miNewDc.Activate += new System.EventHandler(this.CreateNewDocumentContainer);
            // 
            // biUpdate
            // 
            this.biUpdate.BuddyMenu = this.miUpdate;
            this.biUpdate.Image = ((System.Drawing.Image)(resources.GetObject("biUpdate.Image")));
            this.biUpdate.ItemImportance = TD.SandBar.ItemImportance.Lowest;
            resources.ApplyResources(this.biUpdate, "biUpdate");
            this.biUpdate.Visible = false;
            // 
            // miUpdate
            // 
            this.miUpdate.Image = ((System.Drawing.Image)(resources.GetObject("miUpdate.Image")));
            resources.ApplyResources(this.miUpdate, "miUpdate");
            this.miUpdate.Activate += new System.EventHandler(this.Activate_miUpdate);
            // 
            // biReset
            // 
            this.biReset.Image = ((System.Drawing.Image)(resources.GetObject("biReset.Image")));
            resources.ApplyResources(this.biReset, "biReset");
            this.biReset.Activate += new System.EventHandler(this.Activate_biReset);
            // 
            // tbAction
            // 
            this.tbAction.DockLine = 1;
            this.tbAction.DockOffset = 1;
            this.tbAction.Guid = new System.Guid("7caadbda-cf74-4748-8239-5cba76a9cfe3");
            resources.ApplyResources(this.tbAction, "tbAction");
            this.tbAction.Name = "tbAction";
            this.tbAction.ShowShortcutsInToolTips = true;
            // 
            // tbTools
            // 
            this.tbTools.DockLine = 1;
            this.tbTools.DockOffset = 2;
            this.tbTools.Guid = new System.Guid("078e55cf-63d2-4821-a167-a8ccb6446322");
            resources.ApplyResources(this.tbTools, "tbTools");
            this.tbTools.Name = "tbTools";
            this.tbTools.ShowShortcutsInToolTips = true;
            // 
            // tbWindow
            // 
            this.tbWindow.DockLine = 1;
            this.tbWindow.DockOffset = 3;
            this.tbWindow.Guid = new System.Guid("6c37bb3a-a49a-4467-b812-34eb2c2a85ef");
            resources.ApplyResources(this.tbWindow, "tbWindow");
            this.tbWindow.Name = "tbWindow";
            this.tbWindow.ShowShortcutsInToolTips = true;
            // 
            // menuBar1
            // 
            this.menuBar1.Guid = new System.Guid("df109020-5454-48c9-aae5-28b65f95af1d");
            this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.menuBarItem1,
            this.miTools,
            this.miExtra,
            this.miWindow,
            this.menuBarItem5,
            this.miAction});
            resources.ApplyResources(this.menuBar1, "menuBar1");
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.OwnerForm = this;
            // 
            // menuBarItem1
            // 
            this.menuBarItem1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.miNew,
            this.miOpen,
            this.miOpenIn,
            this.miSave,
            this.miSaveAs,
            this.miSaveCopyAs,
            this.miClose,
            this.miRecent,
            this.miExit});
            resources.ApplyResources(this.menuBarItem1, "menuBarItem1");
            // 
            // miOpenIn
            // 
            this.miOpenIn.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.miOpenSimsRes,
            this.miOpenUniRes,
            this.miOpenNightlifeRes,
            this.miOpenBusinessRes,
            this.miOpenFamilyFunRes,
            this.miOpenDownloads});
            resources.ApplyResources(this.miOpenIn, "miOpenIn");
            this.miOpenIn.ToolTipText = null;
            // 
            // miOpenSimsRes
            // 
            resources.ApplyResources(this.miOpenSimsRes, "miOpenSimsRes");
            this.miOpenSimsRes.ToolTipText = null;
            this.miOpenSimsRes.Activate += new System.EventHandler(this.Activate_miOpenSimsRes);
            // 
            // miOpenUniRes
            // 
            resources.ApplyResources(this.miOpenUniRes, "miOpenUniRes");
            this.miOpenUniRes.ToolTipText = null;
            this.miOpenUniRes.Activate += new System.EventHandler(this.Activate_miOpenUniRes);
            // 
            // miOpenNightlifeRes
            // 
            resources.ApplyResources(this.miOpenNightlifeRes, "miOpenNightlifeRes");
            this.miOpenNightlifeRes.Activate += new System.EventHandler(this.Activate_miOpenNightlifeRes);
            // 
            // miOpenBusinessRes
            // 
            resources.ApplyResources(this.miOpenBusinessRes, "miOpenBusinessRes");
            this.miOpenBusinessRes.Activate += new System.EventHandler(this.Activate_miOpenBusinessRes);
            // 
            // miOpenFamilyFunRes
            // 
            resources.ApplyResources(this.miOpenFamilyFunRes, "miOpenFamilyFunRes");
            this.miOpenFamilyFunRes.Activate += new System.EventHandler(this.Activate_miOpenFamilyFunRes);
            // 
            // miOpenDownloads
            // 
            resources.ApplyResources(this.miOpenDownloads, "miOpenDownloads");
            this.miOpenDownloads.Activate += new System.EventHandler(this.Activate_miOpenDownloads);
            // 
            // miSaveCopyAs
            // 
            resources.ApplyResources(this.miSaveCopyAs, "miSaveCopyAs");
            this.miSaveCopyAs.Activate += new System.EventHandler(this.Activate_miSaveCopyAs);
            // 
            // miRecent
            // 
            resources.ApplyResources(this.miRecent, "miRecent");
            // 
            // miExit
            // 
            this.miExit.BeginGroup = true;
            this.miExit.Image = ((System.Drawing.Image)(resources.GetObject("miExit.Image")));
            resources.ApplyResources(this.miExit, "miExit");
            this.miExit.Activate += new System.EventHandler(this.Activate_miExit);
            // 
            // miTools
            // 
            resources.ApplyResources(this.miTools, "miTools");
            // 
            // miExtra
            // 
            this.miExtra.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.miMetaInfo,
            this.miFileNames,
            this.miRunSims,
            this.miPref});
            resources.ApplyResources(this.miExtra, "miExtra");
            // 
            // miMetaInfo
            // 
            this.miMetaInfo.ItemImportance = TD.SandBar.ItemImportance.Low;
            resources.ApplyResources(this.miMetaInfo, "miMetaInfo");
            this.miMetaInfo.Activate += new System.EventHandler(this.Activate_miNoMeta);
            // 
            // miFileNames
            // 
            this.miFileNames.Checked = true;
            resources.ApplyResources(this.miFileNames, "miFileNames");
            this.miFileNames.Activate += new System.EventHandler(this.Activate_miFileNames);
            // 
            // miRunSims
            // 
            this.miRunSims.Image = ((System.Drawing.Image)(resources.GetObject("miRunSims.Image")));
            resources.ApplyResources(this.miRunSims, "miRunSims");
            this.miRunSims.Activate += new System.EventHandler(this.Activate_miRunSims);
            // 
            // miPref
            // 
            this.miPref.BeginGroup = true;
            this.miPref.Image = ((System.Drawing.Image)(resources.GetObject("miPref.Image")));
            resources.ApplyResources(this.miPref, "miPref");
            this.miPref.Activate += new System.EventHandler(this.ShowPreferences);
            // 
            // miWindow
            // 
            this.miWindow.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.miNewDc});
            this.miWindow.MdiWindowList = true;
            resources.ApplyResources(this.miWindow, "miWindow");
            // 
            // menuBarItem5
            // 
            this.menuBarItem5.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.miUpdate,
            this.miTutorials,
            this.mbiTopics,
            this.miAbout});
            resources.ApplyResources(this.menuBarItem5, "menuBarItem5");
            this.menuBarItem5.BeforePopup += new TD.SandBar.MenuItemBase.BeforePopupEventHandler(this.menuBarItem5_BeforePopup);
            // 
            // miTutorials
            // 
            this.miTutorials.Image = ((System.Drawing.Image)(resources.GetObject("miTutorials.Image")));
            resources.ApplyResources(this.miTutorials, "miTutorials");
            this.miTutorials.Activate += new System.EventHandler(this.Activate_miTutorials);
            // 
            // mbiTopics
            // 
            this.mbiTopics.Image = ((System.Drawing.Image)(resources.GetObject("mbiTopics.Image")));
            resources.ApplyResources(this.mbiTopics, "mbiTopics");
            // 
            // miAbout
            // 
            this.miAbout.BeginGroup = true;
            this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
            resources.ApplyResources(this.miAbout, "miAbout");
            this.miAbout.Activate += new System.EventHandler(this.Activate_miAbout);
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
            resources.ApplyResources(this.lv, "lv");
            this.lv.FullRowSelect = true;
            this.lv.HideSelection = false;
            this.lv.Name = "lv";
            this.lv.OwnerDraw = true;
            this.menuBar1.SetSandBarMenu(this.lv, this.miAction);
            this.lv.UseCompatibleStateImageBehavior = false;
            this.lv.View = System.Windows.Forms.View.Details;
            this.lv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
            this.lv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
            this.lv.DoubleClick += new System.EventHandler(this.SelectResourceDBClick);
            this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectResource);
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
            this.tbResource.AllowRightToLeft = true;
            this.tbResource.AllowVerticalDock = false;
            this.tbResource.Closable = false;
            this.tbResource.DockLine = 2;
            this.tbResource.Guid = new System.Guid("40697d0b-0bda-4ca3-b517-ef9be77b6944");
            this.tbResource.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
            this.biInstanceList,
            this.biGroupList,
            this.biTypeList});
            resources.ApplyResources(this.tbResource, "tbResource");
            this.tbResource.Movable = false;
            this.tbResource.Name = "tbResource";
            this.tbResource.Resizable = false;
            this.tbResource.Tearable = false;
            // 
            // biInstanceList
            // 
            this.biInstanceList.Image = ((System.Drawing.Image)(resources.GetObject("biInstanceList.Image")));
            this.biInstanceList.Tag = "2";
            this.biInstanceList.Activate += new System.EventHandler(this.SelectResourceView);
            // 
            // biGroupList
            // 
            this.biGroupList.Image = ((System.Drawing.Image)(resources.GetObject("biGroupList.Image")));
            this.biGroupList.Tag = "1";
            this.biGroupList.Activate += new System.EventHandler(this.SelectResourceView);
            // 
            // biTypeList
            // 
            this.biTypeList.Checked = true;
            this.biTypeList.Image = ((System.Drawing.Image)(resources.GetObject("biTypeList.Image")));
            this.biTypeList.Tag = "0";
            this.biTypeList.Activate += new System.EventHandler(this.SelectResourceView);
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
            // dockContainer1
            // 
            this.dockContainer1.Controls.Add(this.dcResource);
            resources.ApplyResources(this.dockContainer1, "dockContainer1");
            this.dockContainer1.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
            ((TD.SandDock.LayoutSystemBase)(new TD.SandDock.ControlLayoutSystem(100, 421, new TD.SandDock.DockControl[] {
                        ((TD.SandDock.DockControl)(this.dcResource))}, this.dcResource, false)))});
            this.dockContainer1.Manager = this.sdm;
            this.dockContainer1.Name = "dockContainer1";
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
            this.Controls.Add(this.lv);
            this.Controls.Add(this.dockContainer1);
            this.Controls.Add(this.mybottomSandDock);
            this.Controls.Add(this.leftSandBarDock);
            this.Controls.Add(this.rightSandBarDock);
            this.Controls.Add(this.mybottomSandBarDock);
            this.Controls.Add(this.myrightSandDock);
            this.Controls.Add(this.topSandBarDock);
            this.Controls.Add(this.waitControl1);
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ClosingForm);
            this.Load += new System.EventHandler(this.LoadForm);
            this.mybottomSandDock.ResumeLayout(false);
            this.dcPlugin.ResumeLayout(false);
            this.topSandBarDock.ResumeLayout(false);
            this.dcResource.ResumeLayout(false);
            this.myrightSandDock.ResumeLayout(false);
            this.dcFilter.ResumeLayout(false);
            this.xpGradientPanel1.ResumeLayout(false);
            this.xpGradientPanel1.PerformLayout();
            this.dcAction.ResumeLayout(false);
            this.xpGradientPanel2.ResumeLayout(false);
            this.dockContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		static string[] pargs;
		public static MainForm Global;
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			try 
			{			
				Commandline.CheckFiles();
			
				//do the real Startup
				pargs = args;
				//Application.EnableVisualStyles();
				Application.DoEvents();		
				Application.Idle += new EventHandler(Application_Idle);				

				if (!Commandline.ImportOldData()) return;

				if (!Commandline.Start(args))  
				{
					Helper.WindowsRegistry.UpdateSimPEDirectory();
					Global = new MainForm();
					Application.Run(Global);

                    
					Helper.WindowsRegistry.Flush();
					Helper.WindowsRegistry.Layout.Flush();
				}
			} 
			catch (Exception ex) 
			{
				try 
				{
					Helper.ExceptionMessage("SimPE will shutdown due to an unhandled Exception.", ex);
				} 
				catch (Exception ex2) 
				{
					
					MessageBox.Show("SimPE will shutdown due to an unhandled Exception.\n\nMessage: "+ex2.Message);
				}
			}

			try 
			{
				SimPe.Packages.StreamFactory.UnlockAll();
				SimPe.Packages.StreamFactory.CloseAll(true);
				SimPe.Packages.StreamFactory.CleanupTeleport();
			} 
			catch{}
		}

		private void ClosingForm(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = !this.ClosePackage();
			if (!e.Cancel) 
			{
				TreeBuilder.StopAll();
				Wait.Stop(); Wait.Bar = null;

				Helper.WindowsRegistry.Layout.SandBarLayout = sbm.GetLayout(true);
				Helper.WindowsRegistry.Layout.SandDockLayout = sdm.GetLayout();
                MyButtonItem.SetLayoutInformations(this);

				Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = this.tbPlugAction.IsExpanded;
				Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = this.tbDefaultAction.IsExpanded;
				Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = this.tbExtAction.IsExpanded;

				Helper.WindowsRegistry.Layout.TypeColumnWidth = this.lv.Columns[0].Width;
				Helper.WindowsRegistry.Layout.GroupColumnWidth = this.lv.Columns[1].Width;
				Helper.WindowsRegistry.Layout.InstanceHighColumnWidth = this.lv.Columns[2].Width;
				Helper.WindowsRegistry.Layout.InstanceColumnWidth = this.lv.Columns[3].Width;

				if (lv.Columns.Count>4)
				{
					Helper.WindowsRegistry.Layout.OffsetColumnWidth = this.lv.Columns[4].Width;
					Helper.WindowsRegistry.Layout.SizeColumnWidth = this.lv.Columns[5].Width;
				}
			}
		}


		#region Custom Attributes
		LoadedPackage package;
		TreeBuilder treebuilder;
		ViewFilter filter;
		TreeNodeTag lastusedtnt;
		TreeView lasttreeview;
		PluginManager plugger;
		ResourceLoader resloader;
		RemoteHandler remote;
		#endregion

		#region File Handling
		/// <summary>
		/// Commands called before a File is loaded
		/// </summary>
		void BeforeFileLoad(LoadedPackage sender, FileNameEventArg e)
		{
			if (!ClosePackage()) e.Cancel=true;
		}

		/// <summary>
		/// Commands that are called after the load
		/// </summary>
		/// <param name="sender"></param>
		void AfterFileLoad(LoadedPackage sender)
		{
			sender.UpdateProviders();	
			ShowNewFile(true);		
		}	
	
		/// <summary>
		/// Cammans needed before a File is saved
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BeforeFileSave(LoadedPackage sender, FileNameEventArg e)
		{
			if (!resloader.Flush()) e.Cancel=true;
		}

		/// <summary>
		/// Commands neede after a File Save
		/// </summary>
		/// <param name="sender"></param>
		private void AfterFileSave(LoadedPackage sender)
		{
			UpdateFileInfo();
			package.UpdateProviders();

			if (lasttreeview!=null) 
			{
				System.Windows.Forms.TreeViewEventArgs tvea = new TreeViewEventArgs(this.lasttreeview.SelectedNode, TreeViewAction.ByMouse);
				SelectResourceNode(this.lasttreeview, tvea);
			}
		}

		/// <summary>
		/// Called, whenever the Index of a Package was changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ChangedActiveIndex(object sender, EventArgs e)
		{
			//ShowNewFile();
			SelectResource(this.lv, false, true);
		}

		/// <summary>
		/// Called, whenever the Index of a Package was changed
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddedRemovedIndexResource(object sender, EventArgs e)
		{			
			UpdateFileIndex();
		}

		/// <summary>
		/// This Method displays the content of a File
		/// </summary>
		void UpdateFileInfo()
		{
			if (package.Loaded) Text = "SimPe - "+package.FileName;
			UpdateMenuItems();
		}

		/// <summary>
		/// Selects the <see cref="TreeNode"/> that has the same Name as the passed <see cref="TreeNodeTag"/>
		/// </summary>
		/// <param name="nodes">List of TreeNode Object</param>
		/// <param name="tnt"><see cref="TreeNodeTag"/> that should be used to find the matching TreeNode</param>
		/// <returns>true if a selection was made</returns>
		/// <remarks>also sets <see cref="lastusedtnt"/> to the selected Node</remarks>
		bool ReSelectTreeNode(TreeNodeCollection nodes, TreeNodeTag tnt)
		{
			if (this.lasttreeview==null || tnt==null || nodes==null) return false;

			foreach (TreeNode node in nodes)	
			{		
				if (node.Tag is TreeNodeTag)				
					if (((TreeNodeTag)node.Tag).Name == tnt.Name) 
					{
						node.TreeView.SelectedNode = node;
						this.lastusedtnt = (TreeNodeTag)node.Tag;
						return true;
					}

				if (ReSelectTreeNode(node.Nodes, tnt)) return true;
			}
			
			return false;
		}

        delegate bool ReSelectTreeNodeHandler(TreeNodeCollection nodes, TreeNodeTag tnt);
		
        void InvokeReSelectTreeNode(TreeNodeTag tnt)
        {
            if (this.lasttreeview.InvokeRequired)
                this.lasttreeview.Invoke(new ReSelectTreeNodeHandler(ReSelectTreeNode), new object[] { lasttreeview.Nodes, tnt });
            else
                ReSelectTreeNode(this.lasttreeview.Nodes, tnt);
        }

		TreeNodeTag reselecttnt;
		SimPe.Collections.PackedFileDescriptors reselectlist;
		private void TreeBuilder_Finished(object sender, EventArgs e)
		{
			if (sender == null) return;

			if (sender is TreeBuilderBase)
			{
				if (reselecttnt!=null && lasttreeview!=null) 
				{
					reselecttnt.Refresh(lv);
                    InvokeReSelectTreeNode(reselecttnt);				
				}
				
				reselecttnt = null;
			} 
			else if (sender is ResourceListerBase)
			{
				if (reselectlist!=null) 
				{
					lock (lv)
					{
						foreach (ListViewItem lvi in lv.Items) 
						{
							if (lvi==null) continue;
							if (lvi.Tag == null) continue;
							ListViewTag lvt = (ListViewTag)lvi.Tag;
							if (reselectlist.Contains(lvt.Resource.FileDescriptor)) lvi.Selected = true;
						}

						reselectlist.Clear();
					}
				}
			}

		}

		/// <summary>
		/// When adding removing a Resource, the ResourceList and ResourceTree need to be Updated.
		/// That is done in this Method
		/// </summary>
		void UpdateFileIndex()
		{			
			if (reselectlist==null) reselectlist = new SimPe.Collections.PackedFileDescriptors();
			foreach (ListViewItem lvi in lv.Items) 
			{
				ListViewTag lvt = (ListViewTag)lvi.Tag;
				if (lvi.Selected)
					reselectlist.Add(lvt.Resource.FileDescriptor);									
			}

			 //the TreeBuilder_Finished Event Handler is going to be called when ShowNewFile() finishes.
			reselecttnt = lastusedtnt;			
			ShowNewFile(false);							

			
			
		}



		/// <summary>
		/// This Method displays the content of a File
		/// </summary>
		void ShowNewFile(bool autoselect)
		{
			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
			tvInstance.Nodes.Clear();
			tvGroup.Nodes.Clear();
			tvType.Nodes.Clear();

			if (!Helper.WindowsRegistry.AsynchronLoad) lv.BeginUpdate();
			TreeBuilder.ClearListView(lv);

			
			SetupActiveResourceView(autoselect);	
			package.UpdateRecentFileMenu(this.miRecent);			

			UpdateFileInfo();
			if (!Helper.WindowsRegistry.AsynchronLoad) lv.EndUpdate();
		}

		

		/// <summary>
		/// Close the currently opened File
		/// </summary>
		/// <returns>true, if the File was closed</returns>
		bool ClosePackage()
		{
			if (!resloader.Clear()) return false;
			if (!package.Close()) return false;

			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
			return true;
		}
		#endregion

		#region Themes
		void InitThemer()
		{
			//setup the Theme Manager
			ThemeManager.Global.AddControl(this.sdm);			
			ThemeManager.Global.AddControl(this.sbm);
			ThemeManager.Global.AddControl(this.tbResource);			
			ThemeManager.Global.AddControl(this.xpGradientPanel1);
			ThemeManager.Global.AddControl(this.xpGradientPanel2);
			ThemeManager.Global.AddControl(this.xpGradientPanel3);
		}

		void ChangedTheme(GuiTheme gt)
		{
			ThemeManager.Global.CurrentTheme = gt;
		}

		string sdmdef, sbmdef;
		/// <summary>
		/// Wrapper needed to call the Layout Change through an Event
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ResetLayout(object sender, EventArgs e) 
		{			
			Helper.WindowsRegistry.Layout.SandBarLayout = sbmdef;
			Helper.WindowsRegistry.Layout.SandDockLayout = sdmdef;
			Commandline.ForceModernLayout();            

			Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = false;
			Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = true;
			Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = false;

			Helper.WindowsRegistry.Layout.TypeColumnWidth = 204;
			Helper.WindowsRegistry.Layout.GroupColumnWidth = 100;
			Helper.WindowsRegistry.Layout.InstanceHighColumnWidth = 100;
			Helper.WindowsRegistry.Layout.InstanceColumnWidth = 100;
			Helper.WindowsRegistry.Layout.OffsetColumnWidth = 100;
			Helper.WindowsRegistry.Layout.SizeColumnWidth = 100;
				
			ReloadLayout();
		}

		
		/// <summary>
		/// Reload the Layout from the Registry
		/// </summary>
		void ReloadLayout()
		{
			//store defaults
			if (sdmdef==null) sdmdef = sdm.GetLayout();
			if (sbmdef==null) sbmdef = sbm.GetLayout(true);

            try
            {
                if (Helper.WindowsRegistry.Layout.SandBarLayout != "") sbm.SetLayout(Helper.WindowsRegistry.Layout.SandBarLayout);
                if (Helper.WindowsRegistry.Layout.SandDockLayout != "") sdm.SetLayout(Helper.WindowsRegistry.Layout.SandDockLayout);
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage(ex);
            }
            
			/*this.tbDefaultAction.IsExpanded = Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded;			
			this.tbPlugAction.IsExpanded = Helper.WindowsRegistry.Layout.PluginActionBoxExpanded;
			this.tbExtAction.IsExpanded = Helper.WindowsRegistry.Layout.ToolActionBoxExpanded;*/
			

			this.lv.Columns[0].Width = Helper.WindowsRegistry.Layout.TypeColumnWidth;
			this.lv.Columns[1].Width = Helper.WindowsRegistry.Layout.GroupColumnWidth;
			this.lv.Columns[2].Width = Helper.WindowsRegistry.Layout.InstanceHighColumnWidth;
			this.lv.Columns[3].Width = Helper.WindowsRegistry.Layout.InstanceColumnWidth;

			if (this.lv.Columns.Count>4) 
			{
				this.lv.Columns[4].Width = Helper.WindowsRegistry.Layout.OffsetColumnWidth;
				this.lv.Columns[5].Width = Helper.WindowsRegistry.Layout.SizeColumnWidth;
			}

			UpdateDockMenus();
            MyButtonItem.GetLayoutInformations(this);
		}
		#endregion

		#region Menu Handling
		/// <summary>
		/// Add one Dock to the List
		/// </summary>
		/// <param name="c"></param>
		/// <param name="first"></param>
		void AddDockItem(TD.SandDock.DockControl c, bool first)
		{
			TD.SandBar.MenuButtonItem mi = new TD.SandBar.MenuButtonItem(c.Text);
			mi.BeginGroup = first;
			mi.Image = c.TabImage;
			mi.Checked = c.IsDocked || c.IsFloating;

			mi.Activate += new EventHandler(Activate_miWindowDocks);
			mi.Tag = c;
			mi.BeginGroup = first;

			if (c.Tag != null) 
				if (c.Tag is System.Windows.Forms.Shortcut) 
					mi.Shortcut = (System.Windows.Forms.Shortcut)c.Tag;
			

			c.Closed += new EventHandler(CloseDockControl);
			c.Tag = mi;

			miWindow.Items.Add(mi);
		}

		/// <summary>
		/// this will create all needed Dock MenuItems to Display a hidden Dock
		/// </summary>
		void AddDockMenus()
		{
			TD.SandDock.DockControl[] ctrls = sdm.GetDockControls();

			bool first = true;			
			foreach (TD.SandDock.DockControl c in ctrls) 
			{
				if (c.Tag!=null) continue;
				AddDockItem(c, first);				
				first = false;
			}

			first = true;
			foreach (TD.SandDock.DockControl c in ctrls) 
			{
				if (c.Tag==null) continue;
				if (c.Tag is TD.SandBar.MenuButtonItem) continue;
				AddDockItem(c, first);				
				first = false;
			}
		}

		/// <summary>
		/// this will update the Checked State of a Dock menu Item
		/// </summary>
		void UpdateDockMenus()
		{
			foreach (TD.SandBar.MenuButtonItem mi in miWindow.Items) 
			{
				if (mi.Tag is TD.SandDock.DockControl) 
				{
					TD.SandDock.DockControl c = (TD.SandDock.DockControl)mi.Tag;
					mi.Checked = c.IsDocked || c.IsFloating;
				}				
			}
		}

		/// <summary>
		/// Called when a close Event was sent to a DockControl
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CloseDockControl(object sender, EventArgs e)
		{
			if (sender is TD.SandDock.DockControl) 
			{
				TD.SandDock.DockControl c = (TD.SandDock.DockControl)sender;
				if (c.Tag is TD.SandBar.MenuButtonItem) 
				{
					TD.SandBar.MenuButtonItem mi = (TD.SandBar.MenuButtonItem)c.Tag;
					mi.Checked = false;
				}
			}
		}

		/// <summary>
		/// Called when a MenuItem that represents a Dock is clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Activate_miWindowDocks(object sender, EventArgs e)
		{
			if (sender is TD.SandBar.MenuButtonItem) 
			{
				TD.SandBar.MenuButtonItem mi = (TD.SandBar.MenuButtonItem)sender;
				
				if (mi.Tag is TD.SandDock.DockControl) 
				{
					TD.SandDock.DockControl c = (TD.SandDock.DockControl)mi.Tag;					
					if (mi.Checked) c.Close();
					else 
					{
                        c.OpenFloating();
						mi.Checked = c.IsOpen;
						plugger.ChangedGuiResourceEventHandler();
					}
				}
			}
		}

		/// <summary>
		/// Called when we need to set up the MenuItems (checked state)
		/// </summary>
		void InitMenuItems()
		{
			this.miMetaInfo.Checked = !Helper.WindowsRegistry.LoadMetaInfo;
			this.miFileNames.Checked = Helper.WindowsRegistry.DecodeFilenamesState;
			
			AddDockMenus();
			UpdateMenuItems();
			
			tbAction.Visible = true;
			tbTools.Visible = true;
			tbWindow.Visible = false;

			ArrayList exclude = new ArrayList();
			exclude.Add(this.miNewDc);
			SimPe.LoadFileWrappersExt.BuildToolBar(tbWindow, miWindow.Items, exclude);
			this.dcPlugin.Open();
		}

		/// <summary>
		/// Called whenever we need to set the enabled state of a MenuItem
		/// </summary>
		void UpdateMenuItems()
		{
			this.miSave.Enabled = System.IO.File.Exists(package.FileName);
			this.miSaveCopyAs.Enabled = this.miSave.Enabled;
			this.miSaveAs.Enabled = package.Loaded;
			this.miClose.Enabled = package.Loaded;

			this.miOpenUniRes.Enabled = Helper.WindowsRegistry.EPInstalled>=1;
			this.miOpenNightlifeRes.Enabled = Helper.WindowsRegistry.EPInstalled>=2;
			this.miOpenBusinessRes.Enabled = Helper.WindowsRegistry.EPInstalled>=3;
			this.miOpenFamilyFunRes.Enabled = Helper.WindowsRegistry.SPInstalled>=1;
		}
		#endregion

		#region ResourceView Toolbar
		/// <summary>
		/// Setup the Buttons on the ToolBar to connect to the TreeView
		/// </summary>
		void SetupResourceViewToolBar()
		{
			TreeBuilderList.TreeBuilder = this.treebuilder;
			TreeBuilderList.TreeBuilder.Finished += new EventHandler(TreeBuilder_Finished);
			this.biGroupList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.GroupView), tvGroup);
			this.biInstanceList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.InstanceView), tvInstance);
			this.biTypeList.Tag = new TreeBuilderList(new TreeBuilderList.GenerateView(treebuilder.TypeView), tvType);			

			foreach (TD.SandBar.ToolbarItemBase c in tbResource.Items) 
			{
				if (c is TD.SandBar.ButtonItem) 
				{
					TD.SandBar.ButtonItem bi = (TD.SandBar.ButtonItem)c;					
					TreeBuilderList tbl = (TreeBuilderList)bi.Tag;

					tbl.TreeView.Visible = bi.Checked;
					tbl.TreeView.BorderStyle = BorderStyle.None;
					tbl.TreeView.Top = this.tbResource.Height;
					tbl.TreeView.Left = 0;
					tbl.TreeView.Width = dcResource.ClientRectangle.Width;
					tbl.TreeView.Height = dcResource.ClientRectangle.Height - tbl.TreeView.Top;

					tbl.TreeView.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
				}
			}
		}

		/// <summary>
		/// Choose one special View
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		internal void SelectResourceView(object sender, System.EventArgs e)
		{				
			if (sender is TD.SandBar.ButtonItem) 
			{
				TD.SandBar.ButtonItem setbi = (TD.SandBar.ButtonItem)sender;
				setbi.Checked = true;
			}

			foreach (TD.SandBar.ToolbarItemBase c in tbResource.Items) 
			{
				if ((c is TD.SandBar.ButtonItem) && (c!=sender))
				{
					TD.SandBar.ButtonItem bi = (TD.SandBar.ButtonItem)c;
					bi.Checked = false;
				}
			}

			SetupActiveResourceView(true);
		}

		/// <summary>
		/// Display the content of the current package in the choosen TreeView
		/// </summary>
		void SetupActiveResourceView(bool autoselect)
		{
			foreach (TD.SandBar.ToolbarItemBase c in tbResource.Items) 
			{
				if (c is TD.SandBar.ButtonItem) 
				{
					TD.SandBar.ButtonItem bi = (TD.SandBar.ButtonItem)c;					
					TreeBuilderList tbl = (TreeBuilderList)bi.Tag;

					tbl.TreeView.Visible = bi.Checked;
					if (bi.Checked) 
					{
						if (tbl.TreeView.Nodes.Count==0)
						{							
							tbl.Generate(autoselect);							
							if (tbl.TreeView.Nodes.Count>0) lastusedtnt = (TreeNodeTag)tbl.TreeView.Nodes[0].Tag;							
						}

						this.SelectResourceNode(tbl.TreeView, new TreeViewEventArgs(tbl.TreeView.SelectedNode, TreeViewAction.ByMouse));
						//special Treatment for Neighborhood Files
						if (Helper.IsNeighborhoodFile(package.FileName) && tbl.TreeView.Nodes.Count>0) tvType.SelectedNode = tbl.TreeView.Nodes[0];
					}
				}
			}
		}
		#endregion

		#region Drag&Drop

		/// <summary>
		/// Returns the Names of the Dropped Files
		/// </summary>
		/// <param name="e"></param>
		/// <returns></returns>
		string[] DragDropNames(System.Windows.Forms.DragEventArgs e) 
		{
			Array a = (Array)e.Data.GetData(DataFormats.FileDrop);

			if ( a != null )
			{
				string[] res = new string[a.Length];				
				for (int i=0; i<a.Length; i++) res[i] = a.GetValue(i).ToString();
				return res;
			}

			return new string[0];
		}

		/// <summary>
		/// Returns the Effect that should be displayed based on the Files
		/// </summary>
		/// <param name="flname"></param>
		/// <returns></returns>
		DragDropEffects DragDropEffect(string[] names)
		{
			if (names.Length==0) return DragDropEffects.None;

			ExtensionType et = ExtensionProvider.GetExtension(names[0]);
			if (names.Length==1) 
			{
				if (et == ExtensionType.Package || et == ExtensionType.DisabledPackage || et == ExtensionType.ExtrackedPackageDescriptor) 
					return DragDropEffects.Move;
				else if (et == ExtensionType.ExtractedFile || et == ExtensionType.ExtractedFileDescriptor)
					return DragDropEffects.Copy;
			} 
				
			return DragDropEffects.Copy;								
		}

		/// <summary>
		/// Someone tries to throw a File
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragEnterFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop)) 
			{
				try
				{
					e.Effect = DragDropEffect(DragDropNames(e));					
				} 
				catch (Exception)
				{
				}
				
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}
		}

		/// <summary>
		/// A File has been dropped
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void DragDropFile(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try
			{
				package.LoadOrImportFiles(DragDropNames(e), true);				
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}

		}
		#endregion

		
		void LoadForm(object sender, System.EventArgs e)
		{					
			if (Helper.WindowsRegistry.PreviousVersion==0) About.ShowWelcome();

			dcFilter.LayoutSystem.Collapsed = true;

			if (!Helper.WindowsRegistry.HiddenMode) 
			{
				lv.Columns.RemoveAt(lv.Columns.Count-1);
				lv.Columns.RemoveAt(lv.Columns.Count-1);
			}	
			
			cbsemig.Items.Add("[Group Filter]");
			cbsemig.Items.Add(new SimPe.Data.SemiGlobalAlias(true, 0x7FD46CD0, "Globals"));
			cbsemig.Items.Add(new SimPe.Data.SemiGlobalAlias(true, 0x7FE59FD0, "Behaviour"));
			foreach (Data.SemiGlobalAlias sga in Data.MetaData.SemiGlobals)
				if (sga.Known) this.cbsemig.Items.Add(sga);
			if (cbsemig.Items.Count>0) cbsemig.SelectedIndex = 0;
		
			ReloadLayout();	
			
			if (Helper.WindowsRegistry.CheckForUpdates) 
				About.ShowUpdate();

			//load Files passed on the commandline
			package.LoadOrImportFiles(pargs, true);

			//Set the Lock State of the Docks
			MakeFloatable(!Helper.WindowsRegistry.LockDocks);
		}

		void Activate_miOpen(object sender, System.EventArgs e)
		{
			ofd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				package.LoadFromFile(ofd.FileName);
			}
		}

		void SelectResourceNode(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			lastusedtnt = null;
			if(sender==null) return;
			lasttreeview = (TreeView)sender;
			
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;
			if (!(e.Node.Tag is TreeNodeTag)) return;

			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));			
			lastusedtnt = (TreeNodeTag)e.Node.Tag;
			lastusedtnt.Refresh(lv);		
		}

		private void SetFilter(object sender, System.EventArgs e)
		{
			try 
			{
				filter.Instance = Convert.ToUInt32(tbInst.Text, 16);
				filter.FilterInstance = (tbInst.Text.Trim()!="");
			} 
			catch 
			{
				filter.FilterInstance = false;
			}

			try 
			{
				filter.Group = Convert.ToUInt32(tbGrp.Text, 16);
				filter.FilterGroup = (tbGrp.Text.Trim()!="");
			} 
			catch 
			{
				filter.FilterGroup = false;
			}
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);
		}				
		
		
		//int ct = 0;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e">null to indicate, that his Method was called internal, and should NOT open a Resource!</param>
		private void SelectResource(object sender, System.EventArgs e)
		{		
			
			//ct++; this.Text=(ct/2).ToString();	//was used to test for a Bug related to opened Docks
			if (lv.SelectedItems.Count<=2) SelectResource(sender, false, false);
			else DereferedResourceSelect();
		}

		private void Activate_miUpdate(object sender, System.EventArgs e)
		{
			About.ShowUpdate(true);
		}

		private void Activate_miAbout(object sender, System.EventArgs e)
		{
			About.ShowAbout();
		}

		private void Activate_miTutorials(object sender, System.EventArgs e)
		{
			About.ShowTutorials();
		}

		private void dc_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Middle && Helper.WindowsRegistry.FirefoxTabbing && dc.SelectedPage!=null) 
			{
				resloader.CloseDocument(dc.SelectedPage);
			}
		}		

		bool pressedalt;
		private void ResourceListKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			pressedalt = e.Alt;
		}

		private void ResourceListKeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			pressedalt = false;
			if (e.KeyCode==Keys.A && e.Control) 
			{
				lv.Tag = true;
				lv.BeginUpdate();
				foreach (ListViewItem lvi in lv.Items) lvi.Selected = true;
				lv.EndUpdate();
				lv.Tag = null;
			}

			if (e.KeyCode==Keys.H && e.Control && e.Alt && e.Shift) 
			{
				Hidden f = new Hidden();
				f.ShowDialog();
			}
		}

		private void Activate_miNew(object sender, System.EventArgs e)
		{
			if (this.ClosePackage()) 
			{
				package.LoadFromPackage(SimPe.Packages.GeneratableFile.CreateNew());
			}
		}

		bool frommiddle = false;
		
		/// <summary>
		/// Selected Resource did change
		/// </summary>
		/// <param name="sender">The ListView</param>
		/// <param name="fromdbl">Select was issued by a doubleClick</param>
		/// <param name="fromchg">Select was issued by an internal Change of a pfd Resource</param>
		/// <remarks>Uses the frommiddle field to determin if the middle Button was clicked</remarks>
		private void SelectResource(object sender, bool fromdbl, bool fromchg)
		{			
			bool fm = frommiddle;
			if (!Helper.WindowsRegistry.FirefoxTabbing) fm=true;

			ListView lv = (ListView)sender;
			

			if (lv.SelectedItems.Count==0) 
			{
				plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
				return;
			}
			
			SimPe.Events.ResourceEventArgs res = new SimPe.Events.ResourceEventArgs(package);
			bool goon = (!fromdbl && !Helper.WindowsRegistry.SimpleResourceSelect && !frommiddle) || (lv.SelectedItems.Count>1);
			foreach (ListViewItem lvi in lv.SelectedItems) 
			{
				ListViewTag lvt = (ListViewTag)lvi.Tag;

				res.Items.Add(new SimPe.Events.ResourceContainer(lvt.Resource));

				if (goon) continue;

				//only the first one get's added to the Plugin View				
				if ((lv.SelectedItems.Count==1 && !fromchg && lv.Tag==null)) 				
					resloader.AddResource(lvt.Resource, !fm);	
			}

			//notify the Action Tools that the selection was changed
			plugger.ChangedGuiResourceEventHandler(this, res);
			lv.Focus();
		}

		private void ShowPreferences(object sender, System.EventArgs e)
		{
			OptionForm of = new OptionForm();
			of.NewTheme +=new ChangedThemeEvent(ChangedTheme);
			of.ResetLayout += new EventHandler(ResetLayout);
			of.UnlockDocks += new EventHandler(UnLockDocks);
			of.LockDocks += new EventHandler(LockDocks);

			System.Drawing.Icon icon = null;
			if (miPref.Image is System.Drawing.Bitmap)
				icon = System.Drawing.Icon.FromHandle(((System.Drawing.Bitmap)miPref.Image).GetHicon());

			of.Execute(icon);	
			package.UpdateRecentFileMenu(this.miRecent);
		}

		
		

		private void ClosedToolPlugin(object sender, PackageArg pk)
		{
			try 
			{
				if (pk.Result.ChangedPackage) package.LoadFromPackage((SimPe.Packages.GeneratableFile)pk.Package);	
				if (pk.Result.ChangedFile) 
				{
					SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii = new SimPe.Plugin.FileIndexItem(pk.FileDescriptor, pk.Package);
					resloader.AddResource(fii, true);															
					remote.FireLoadEvent(fii);
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		
		private void CreateNewDocumentContainer(object sender, System.EventArgs e)
		{
			TD.SandDock.DockControl doc = new TD.SandDock.DockableWindow();
			doc.Text = "Plugin";
						
			doc.Manager = sdm;			
			//doc.PerformDock(dcPlugin.LayoutSystem);
			doc.OpenFloating();
			doc.Closing += new TD.SandDock.DockControlClosingEventHandler(CloseAdditionalDocContainer);
			doc.TabImage = dcPlugin.TabImage;
			doc.Text = dcPlugin.Text;
			doc.TabText = dcPlugin.TabText;
			doc.AutoScrollMinSize = dcPlugin.AutoScrollMinSize;
			

			TD.SandDock.TabControl dc = new TD.SandDock.TabControl();
			dc.Manager = this.dc.Manager;
			dc.Text = "Plugin";
			dc.Parent = doc;
			dc.Dock = DockStyle.Fill;
			
		}

		private void CloseAdditionalDocContainer(object sender, TD.SandDock.DockControlClosingEventArgs e)
		{
			if (sender is TD.SandDock.DockControl) 
			{
				TD.SandDock.DockControl doc = (TD.SandDock.DockControl)sender;
				if (doc.Controls[0] is TD.SandDock.TabControl) 
				{
					TD.SandDock.TabControl dc = (TD.SandDock.TabControl)doc.Controls[0];
					bool closed = true;
					for (int i=dc.TabPages.Count-1; i>=0; i--) 
					{						
						TD.SandDock.DockControl d = dc.TabPages[i];
						if (!resloader.CloseDocument(d)) closed = false;;
					}

					e.Cancel = !closed;
				}
			}

		}

		private void Activate_miNoMeta(object sender, System.EventArgs e)
		{
			TD.SandBar.MenuButtonItem mi = (TD.SandBar.MenuButtonItem)sender;
			mi.Checked = !mi.Checked;

			Helper.WindowsRegistry.LoadMetaInfo = !mi.Checked;
		}

		private void Activate_miFileNames(object sender, System.EventArgs e)
		{
			TD.SandBar.MenuButtonItem mi = (TD.SandBar.MenuButtonItem)sender;
			mi.Checked = !mi.Checked;

			Helper.WindowsRegistry.DecodeFilenamesState = mi.Checked;
		}

		private void Activate_miExit(object sender, System.EventArgs e)
		{
			Close();
		}

		private void Activate_miRunSims(object sender, System.EventArgs e)
		{
			
			if (!System.IO.File.Exists(Helper.WindowsRegistry.SimsApplication)) return;

			System.Diagnostics.Process p = new System.Diagnostics.Process();
			p.StartInfo.FileName = Helper.WindowsRegistry.SimsApplication;
			if (Helper.WindowsRegistry.EnableSound) 
			{
				p.StartInfo.Arguments = "-w -r800x600 -skipintro -skipverify";
			} 
			else 
			{
				p.StartInfo.Arguments = "-w -r800x600 -nosound -skipintro -skipverify";
			}
			p.Start();
		}

		private void Activate_miSave(object sender, System.EventArgs e)
		{
			package.Save();
		}

		private void Activate_miSaveAs(object sender, System.EventArgs e)
		{
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);
			sfd.FileName = package.FileName;
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				package.Save(sfd.FileName, false);
				package.UpdateRecentFileMenu(this.miRecent);
			}
		}

		private void Activate_miClose(object sender, System.EventArgs e)
		{
			if (ClosePackage())
			{
				SimPe.Packages.StreamFactory.CloseAll(false);
				this.ShowNewFile(true);
			}							
		}

		private void SelectResourceDBClick(object sender, System.EventArgs e)
		{			
			SelectResource(sender, true, false);
		}				

		
		private void SortResourceListClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
            ResourceColumnSorter sorter = ((ListView)sender).ListViewItemSorter as ResourceColumnSorter;
			if (sorter == null) 
			{
                sorter = new ResourceColumnSorter();
				sorter.CurrentColumn = 0;
				((ListView)sender).ListViewItemSorter = sorter;
			} 
            if (sorter.CurrentColumn == e.Column)
                sorter.Asc=!sorter.Asc;
            else
                sorter.Asc = true;

            sorter.CurrentColumn = e.Column;
            ((ResourceListView)sender).LoadAll();
			((ListView)sender).Sort();
		}

		private void SelectResource(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((e.Button == MouseButtons.Middle) || (e.Button == MouseButtons.Left && pressedalt))
			{
				ListViewItem lvi = lv.GetItemAt(e.X, e.Y);
				if (lvi!=null) 
				{
					lv.BeginUpdate();
					for (int i=lv.SelectedItems.Count-1; i>=0; i--)  lv.SelectedItems[i].Selected=false;

					frommiddle = true;
					lvi.Selected = true;
					lv.EndUpdate();
					frommiddle = false;
				}
			}
		}

		private void rh_LoadedResource(object sender, ResourceEventArgs es)
		{
			treebuilder.DeselectAll(lv);
			foreach (SimPe.Events.ResourceContainer e in es) 
			{
				if (e.HasResource) treebuilder.SelectResource(lv, e.Resource);	
			}
		}

		private void Activate_miOpenSimsRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimsPath, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenUniRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP1Path, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenNightlifeRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP2Path, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenBusinessRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimsEP3Path, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenFamilyFunRes(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimsSP1Path, "TSData\\Res");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void Activate_miOpenDownloads(object sender, System.EventArgs e)
		{
			ofd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");
			ofd.FileName = "";
			this.Activate_miOpen(sender, e);
		}

		private void SetRcolNameFilter(object sender, System.EventArgs e)
		{
			filter.FilterGroup = false;
			try 
			{
				string name = Hashes.StripHashFromName(tbRcolName.Text);
				filter.Instance = Hashes.InstanceHash(name);
				//filter.Group = Hashes.GroupHash(this.tbRcolName.Text);
				filter.FilterInstance = (name.Trim()!="");
				//filter.FilterGroup = filter.FilterInstance;
			} 
			catch 
			{
				filter.FilterInstance = false;				
			}
			
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);
		}

		private void tbRcolName_SizeChanged(object sender, System.EventArgs e)
		{
			if (tbRcolName.Right+8 > tbRcolName.Parent.Width) 
			{
				tbRcolName.Width = tbRcolName.Parent.Width - tbRcolName.Left - 8;
				this.cbsemig.Width = tbRcolName.Width;

				xpLinkedLabelIcon2.Left = tbRcolName.Right - xpLinkedLabelIcon2.Width;
				xpLinkedLabelIcon3.Left = xpLinkedLabelIcon2.Left;
			}
		}

		private void SetSemiGlobalFilter(object sender, System.EventArgs e)
		{
			filter.FilterInstance = false;
			try 
			{
				if (this.cbsemig.SelectedItem is Data.SemiGlobalAlias) 
				{
					Data.SemiGlobalAlias sga = (Data.SemiGlobalAlias)this.cbsemig.SelectedItem;
					if (sga!=null) 
					{
						string name = Hashes.StripHashFromName(tbRcolName.Text);
						filter.Group = sga.Id;					
						filter.FilterGroup = (cbsemig.Text.Trim()!="");					
					}
				} 
				else filter.FilterGroup = false;
			} 
			catch 
			{
				filter.FilterGroup = false;				
			}
			
			if (lastusedtnt!=null) lastusedtnt.Refresh(lv);		
		}

		private void sdm_DockControlActivated(object sender, TD.SandDock.DockControlEventArgs e)
		{
			if (!e.DockControl.Collapsed) lv.BringToFront();
		}

		#region Idle Actions
		static DateTime lastgc = DateTime.Now;
		static TimeSpan waitgc = new TimeSpan(0, 0, 15, 0, 0);
		static DateTime lastfi = DateTime.Now;
		static TimeSpan waitfi = new TimeSpan(0, 2, 10, 0, 0);
		private static void Application_Idle(object sender, EventArgs e)
		{
			/*DateTime now = DateTime.Now;
			if (now.Subtract(lastgc) > waitgc) 
			{
				GC.Collect();
				lastgc = now;
			}

			if (now.Subtract(lastfi) > waitfi) 
			{
				try 
				{
					FileTable.FileIndex.Load();
				} 
				catch {}
				lastfi = now;
			}*/
		}
		#endregion

		#region Dereffered ResourceSelection
		byte rst = 0;
		void DereferedResourceSelect()
		{
			rst = 0;
			resourceSelectionTimer.Enabled = true;
		}

		private void resourceSelectionTimer_Tick(object sender, System.EventArgs e)
		{
			rst++;
			if (rst==2) 
			{
				this.resourceSelectionTimer.Enabled = false;
				SelectResource(lv, false, false);
			}
		}
		#endregion

		private void Activate_miSaveCopyAs(object sender, System.EventArgs e)
		{
			sfd.Filter = ExtensionProvider.BuildFilterString(
				new SimPe.ExtensionType[] {
											  SimPe.ExtensionType.Package,
											  SimPe.ExtensionType.DisabledPackage,
											  SimPe.ExtensionType.AllFiles
										  }
				);

			sfd.FileName = package.FileName;
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				SimPe.Packages.GeneratableFile gf = (SimPe.Packages.GeneratableFile)package.Package.Clone();
				gf.Save(sfd.FileName);	
				//package.UpdateRecentFileMenu(this.miRecent);
			}
		}

		private void Activate_biReset(object sender, System.EventArgs e)
		{
			ResetLayout(null, null);
			
		}

		void MakeFloatable(TD.SandDock.DockableWindow dw, bool fl)
		{
			dw.AllowFloat = fl;
			dw.AllowDockBottom = fl;
			dw.AllowDockLeft = fl;
			dw.AllowDockRight = fl;
			dw.AllowDockTop = fl;
			dw.AllowDockCenter = fl;

			dw.AllowClose = fl;			
		}

		void MakeFloatable(bool fl)
		{
			foreach (TD.SandBar.MenuItemBase mi in this.miWindow.Items)
			{
				if (mi.Tag==null) continue;
				TD.SandDock.DockableWindow dw = mi.Tag as TD.SandDock.DockableWindow;

				MakeFloatable(dw, fl);
			}

			MakeFloatable(this.dcFilter, fl);
			MakeFloatable(this.dcResource, fl);
			MakeFloatable(this.dcPlugin, fl);

			this.dcPlugin.AllowClose = false;
		}

		private void UnLockDocks(object sender, EventArgs e)
		{
			MakeFloatable(true);
		}

		private void LockDocks(object sender, EventArgs e)
		{
			MakeFloatable(false);
		}

		private void menuBarItem5_BeforePopup(object sender, TD.SandBar.MenuPopupEventArgs e)
		{
			this.mbiTopics.Visible = mbiTopics.Items.Count>0;
		}

		
	}
			
}
