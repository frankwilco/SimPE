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
		private TD.SandDock.DockControl dcPreview;
		private TD.SandDock.DockControl dcFilter;
		private TD.SandBar.MenuButtonItem miOpen;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private SteepValley.Windows.Forms.XPLinkedLabelIcon xpLinkedLabelIcon1;
		private System.Windows.Forms.ListView lv;
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
		private TD.SandDock.DockControl dcResource;
		private TD.SandBar.MenuButtonItem miRecent;
		private TD.SandDock.DocumentContainer dc;
		private TD.SandBar.MenuBarItem miExtra;
		private TD.SandDock.DockControl dcAction;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel2;
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel3;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.ProgressBar pb;
		private SteepValley.Windows.Forms.XPLine lnProg;
		private System.Windows.Forms.Label lbPercent;
		private System.Windows.Forms.Label lbOp;
		private SteepValley.Windows.Forms.XPGradientPanel sb;
		private System.Windows.Forms.ImageList iAnim;
		private SteepValley.Windows.Forms.XPLine lnProg2;
		private System.Windows.Forms.PictureBox pbWait;
		private SteepValley.Windows.Forms.XPLine xpLine1;
		private System.Windows.Forms.PictureBox pbimg;
		private TD.SandBar.MenuBarItem miTools;
		private TD.SandDock.DockContainer myleftSandDock;
		private TD.SandDock.DockContainer myrightSandDock;
		private TD.SandDock.DockContainer mybottomSandDock;
		private TD.SandDock.DockContainer mytopSandDock;
		private TD.SandBar.ToolBarContainer mybottomSandBarDock;
		private TD.SandBar.MenuButtonItem miNewDc;
		private TD.SandDock.DockControl dcPlugin;
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
		private System.ComponentModel.IContainer components;

		public MainForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

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

			plugger = new PluginManager(
				miTools, 
				dc, 
				package,
				tbDefaultAction,
				miAction,
				tbExtAction,
				tbPlugAction,
				tbAction,
				dcPlugin);
			plugger.ClosedToolPlugin += new ToolMenuItemExt.ExternalToolNotify(ClosedToolPlugin);
			
			resloader = new ResourceLoader(dc, package);			
			
			SetupResourceViewToolBar();
			package.UpdateRecentFileMenu(this.miRecent);

			InitThemer();
			mybottomSandDock.Height = ((this.Height * 3) /4);			
			this.Text += " (Version "+Helper.SimPeVersion.ProductVersion+")";

						
			TD.SandDock.SandDockManager sdm2 = new TD.SandDock.SandDockManager();
			sdm2.OwnerForm = this;
			FileTable.ThemeManager.AddControl(sdm2);
			this.dc.Manager = sdm2;			

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(MainForm));
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.xpCueBannerExtender1 = new SteepValley.Windows.Forms.XPCueBannerExtender(this.components);
			this.tbInst = new System.Windows.Forms.TextBox();
			this.tbGrp = new System.Windows.Forms.TextBox();
			this.sbm = new TD.SandBar.SandBarManager();
			this.leftSandBarDock = new TD.SandBar.ToolBarContainer();
			this.rightSandBarDock = new TD.SandBar.ToolBarContainer();
			this.mybottomSandBarDock = new TD.SandBar.ToolBarContainer();
			this.topSandBarDock = new TD.SandBar.ToolBarContainer();
			this.menuBar1 = new TD.SandBar.MenuBar();
			this.menuBarItem1 = new TD.SandBar.MenuBarItem();
			this.miNew = new TD.SandBar.MenuButtonItem();
			this.miOpen = new TD.SandBar.MenuButtonItem();
			this.miSave = new TD.SandBar.MenuButtonItem();
			this.miSaveAs = new TD.SandBar.MenuButtonItem();
			this.miClose = new TD.SandBar.MenuButtonItem();
			this.miRecent = new TD.SandBar.MenuButtonItem();
			this.miExit = new TD.SandBar.MenuButtonItem();
			this.miExtra = new TD.SandBar.MenuBarItem();
			this.miMetaInfo = new TD.SandBar.MenuButtonItem();
			this.miFileNames = new TD.SandBar.MenuButtonItem();
			this.miRunSims = new TD.SandBar.MenuButtonItem();
			this.miPref = new TD.SandBar.MenuButtonItem();
			this.miTools = new TD.SandBar.MenuBarItem();
			this.miWindow = new TD.SandBar.MenuBarItem();
			this.miNewDc = new TD.SandBar.MenuButtonItem();
			this.menuBarItem5 = new TD.SandBar.MenuBarItem();
			this.miUpdate = new TD.SandBar.MenuButtonItem();
			this.miTutorials = new TD.SandBar.MenuButtonItem();
			this.miAbout = new TD.SandBar.MenuButtonItem();
			this.miAction = new TD.SandBar.ContextMenuBarItem();
			this.lv = new System.Windows.Forms.ListView();
			this.clType = new System.Windows.Forms.ColumnHeader();
			this.clGroup = new System.Windows.Forms.ColumnHeader();
			this.clInstanceHigh = new System.Windows.Forms.ColumnHeader();
			this.clInstance = new System.Windows.Forms.ColumnHeader();
			this.clOffset = new System.Windows.Forms.ColumnHeader();
			this.clSize = new System.Windows.Forms.ColumnHeader();
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biNew = new TD.SandBar.ButtonItem();
			this.biOpen = new TD.SandBar.ButtonItem();
			this.biSave = new TD.SandBar.ButtonItem();
			this.biSaveAs = new TD.SandBar.ButtonItem();
			this.biClose = new TD.SandBar.ButtonItem();
			this.biNewDc = new TD.SandBar.ButtonItem();
			this.biUpdate = new TD.SandBar.ButtonItem();
			this.tbAction = new TD.SandBar.ToolBar();
			this.iAnim = new System.Windows.Forms.ImageList(this.components);
			this.sdm = new TD.SandDock.SandDockManager();
			this.myleftSandDock = new TD.SandDock.DockContainer();
			this.dcResource = new TD.SandDock.DockControl();
			this.tbResource = new TD.SandBar.ToolBar();
			this.biInstanceList = new TD.SandBar.ButtonItem();
			this.biGroupList = new TD.SandBar.ButtonItem();
			this.biTypeList = new TD.SandBar.ButtonItem();
			this.tvType = new System.Windows.Forms.TreeView();
			this.tvGroup = new System.Windows.Forms.TreeView();
			this.tvInstance = new System.Windows.Forms.TreeView();
			this.myrightSandDock = new TD.SandDock.DockContainer();
			this.dcPreview = new TD.SandDock.DockControl();
			this.xpGradientPanel3 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.dcFilter = new TD.SandDock.DockControl();
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.xpLinkedLabelIcon1 = new SteepValley.Windows.Forms.XPLinkedLabelIcon();
			this.dcAction = new TD.SandDock.DockControl();
			this.xpGradientPanel2 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.tbExtAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
			this.tbPlugAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
			this.tbDefaultAction = new SteepValley.Windows.Forms.ThemedControls.XPTaskBox();
			this.mybottomSandDock = new TD.SandDock.DockContainer();
			this.dcPlugin = new TD.SandDock.DockControl();
			this.dc = new TD.SandDock.DocumentContainer();
			this.xpGradientPanel5 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.mytopSandDock = new TD.SandDock.DockContainer();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.sb = new SteepValley.Windows.Forms.XPGradientPanel();
			this.pbimg = new System.Windows.Forms.PictureBox();
			this.xpLine1 = new SteepValley.Windows.Forms.XPLine();
			this.pbWait = new System.Windows.Forms.PictureBox();
			this.lbOp = new System.Windows.Forms.Label();
			this.lnProg2 = new SteepValley.Windows.Forms.XPLine();
			this.lbPercent = new System.Windows.Forms.Label();
			this.lnProg = new SteepValley.Windows.Forms.XPLine();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.topSandBarDock.SuspendLayout();
			this.myleftSandDock.SuspendLayout();
			this.dcResource.SuspendLayout();
			this.myrightSandDock.SuspendLayout();
			this.dcPreview.SuspendLayout();
			this.dcFilter.SuspendLayout();
			this.xpGradientPanel1.SuspendLayout();
			this.dcAction.SuspendLayout();
			this.xpGradientPanel2.SuspendLayout();
			this.mybottomSandDock.SuspendLayout();
			this.dcPlugin.SuspendLayout();
			this.sb.SuspendLayout();
			this.SuspendLayout();
			// 
			// ofd
			// 
			this.ofd.Filter = resources.GetString("ofd.Filter");
			this.ofd.Title = resources.GetString("ofd.Title");
			// 
			// tbInst
			// 
			this.tbInst.AccessibleDescription = resources.GetString("tbInst.AccessibleDescription");
			this.tbInst.AccessibleName = resources.GetString("tbInst.AccessibleName");
			this.tbInst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbInst.Anchor")));
			this.tbInst.AutoSize = ((bool)(resources.GetObject("tbInst.AutoSize")));
			this.tbInst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbInst.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbInst, "Instance Filter");
			this.tbInst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbInst.Dock")));
			this.tbInst.Enabled = ((bool)(resources.GetObject("tbInst.Enabled")));
			this.tbInst.Font = ((System.Drawing.Font)(resources.GetObject("tbInst.Font")));
			this.tbInst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbInst.ImeMode")));
			this.tbInst.Location = ((System.Drawing.Point)(resources.GetObject("tbInst.Location")));
			this.tbInst.MaxLength = ((int)(resources.GetObject("tbInst.MaxLength")));
			this.tbInst.Multiline = ((bool)(resources.GetObject("tbInst.Multiline")));
			this.tbInst.Name = "tbInst";
			this.tbInst.PasswordChar = ((char)(resources.GetObject("tbInst.PasswordChar")));
			this.tbInst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbInst.RightToLeft")));
			this.tbInst.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbInst.ScrollBars")));
			this.tbInst.Size = ((System.Drawing.Size)(resources.GetObject("tbInst.Size")));
			this.tbInst.TabIndex = ((int)(resources.GetObject("tbInst.TabIndex")));
			this.tbInst.Text = resources.GetString("tbInst.Text");
			this.tbInst.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbInst.TextAlign")));
			this.tbInst.Visible = ((bool)(resources.GetObject("tbInst.Visible")));
			this.tbInst.WordWrap = ((bool)(resources.GetObject("tbInst.WordWrap")));
			// 
			// tbGrp
			// 
			this.tbGrp.AccessibleDescription = resources.GetString("tbGrp.AccessibleDescription");
			this.tbGrp.AccessibleName = resources.GetString("tbGrp.AccessibleName");
			this.tbGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbGrp.Anchor")));
			this.tbGrp.AutoSize = ((bool)(resources.GetObject("tbGrp.AutoSize")));
			this.tbGrp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbGrp.BackgroundImage")));
			this.xpCueBannerExtender1.SetCueBannerText(this.tbGrp, "Group Filter");
			this.tbGrp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbGrp.Dock")));
			this.tbGrp.Enabled = ((bool)(resources.GetObject("tbGrp.Enabled")));
			this.tbGrp.Font = ((System.Drawing.Font)(resources.GetObject("tbGrp.Font")));
			this.tbGrp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbGrp.ImeMode")));
			this.tbGrp.Location = ((System.Drawing.Point)(resources.GetObject("tbGrp.Location")));
			this.tbGrp.MaxLength = ((int)(resources.GetObject("tbGrp.MaxLength")));
			this.tbGrp.Multiline = ((bool)(resources.GetObject("tbGrp.Multiline")));
			this.tbGrp.Name = "tbGrp";
			this.tbGrp.PasswordChar = ((char)(resources.GetObject("tbGrp.PasswordChar")));
			this.tbGrp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbGrp.RightToLeft")));
			this.tbGrp.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbGrp.ScrollBars")));
			this.tbGrp.Size = ((System.Drawing.Size)(resources.GetObject("tbGrp.Size")));
			this.tbGrp.TabIndex = ((int)(resources.GetObject("tbGrp.TabIndex")));
			this.tbGrp.Text = resources.GetString("tbGrp.Text");
			this.tbGrp.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbGrp.TextAlign")));
			this.tbGrp.Visible = ((bool)(resources.GetObject("tbGrp.Visible")));
			this.tbGrp.WordWrap = ((bool)(resources.GetObject("tbGrp.WordWrap")));
			// 
			// sbm
			// 
			this.sbm.OwnerForm = this;
			// 
			// leftSandBarDock
			// 
			this.leftSandBarDock.AccessibleDescription = resources.GetString("leftSandBarDock.AccessibleDescription");
			this.leftSandBarDock.AccessibleName = resources.GetString("leftSandBarDock.AccessibleName");
			this.leftSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("leftSandBarDock.Anchor")));
			this.leftSandBarDock.AutoScroll = ((bool)(resources.GetObject("leftSandBarDock.AutoScroll")));
			this.leftSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.AutoScrollMargin")));
			this.leftSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.AutoScrollMinSize")));
			this.leftSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftSandBarDock.BackgroundImage")));
			this.leftSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("leftSandBarDock.Dock")));
			this.leftSandBarDock.Enabled = ((bool)(resources.GetObject("leftSandBarDock.Enabled")));
			this.leftSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("leftSandBarDock.Font")));
			this.leftSandBarDock.Guid = new System.Guid("259c7353-51eb-45a8-b368-6e61813bb778");
			this.leftSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("leftSandBarDock.ImeMode")));
			this.leftSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("leftSandBarDock.Location")));
			this.leftSandBarDock.Manager = this.sbm;
			this.leftSandBarDock.Name = "leftSandBarDock";
			this.leftSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("leftSandBarDock.RightToLeft")));
			this.leftSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("leftSandBarDock.Size")));
			this.leftSandBarDock.TabIndex = ((int)(resources.GetObject("leftSandBarDock.TabIndex")));
			this.leftSandBarDock.Text = resources.GetString("leftSandBarDock.Text");
			this.leftSandBarDock.Visible = ((bool)(resources.GetObject("leftSandBarDock.Visible")));
			// 
			// rightSandBarDock
			// 
			this.rightSandBarDock.AccessibleDescription = resources.GetString("rightSandBarDock.AccessibleDescription");
			this.rightSandBarDock.AccessibleName = resources.GetString("rightSandBarDock.AccessibleName");
			this.rightSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rightSandBarDock.Anchor")));
			this.rightSandBarDock.AutoScroll = ((bool)(resources.GetObject("rightSandBarDock.AutoScroll")));
			this.rightSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.AutoScrollMargin")));
			this.rightSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.AutoScrollMinSize")));
			this.rightSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightSandBarDock.BackgroundImage")));
			this.rightSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rightSandBarDock.Dock")));
			this.rightSandBarDock.Enabled = ((bool)(resources.GetObject("rightSandBarDock.Enabled")));
			this.rightSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("rightSandBarDock.Font")));
			this.rightSandBarDock.Guid = new System.Guid("b0a914ac-a821-4755-a65a-d3ef139f161f");
			this.rightSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rightSandBarDock.ImeMode")));
			this.rightSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("rightSandBarDock.Location")));
			this.rightSandBarDock.Manager = this.sbm;
			this.rightSandBarDock.Name = "rightSandBarDock";
			this.rightSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rightSandBarDock.RightToLeft")));
			this.rightSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("rightSandBarDock.Size")));
			this.rightSandBarDock.TabIndex = ((int)(resources.GetObject("rightSandBarDock.TabIndex")));
			this.rightSandBarDock.Text = resources.GetString("rightSandBarDock.Text");
			this.rightSandBarDock.Visible = ((bool)(resources.GetObject("rightSandBarDock.Visible")));
			// 
			// mybottomSandBarDock
			// 
			this.mybottomSandBarDock.AccessibleDescription = resources.GetString("mybottomSandBarDock.AccessibleDescription");
			this.mybottomSandBarDock.AccessibleName = resources.GetString("mybottomSandBarDock.AccessibleName");
			this.mybottomSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("mybottomSandBarDock.Anchor")));
			this.mybottomSandBarDock.AutoScroll = ((bool)(resources.GetObject("mybottomSandBarDock.AutoScroll")));
			this.mybottomSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("mybottomSandBarDock.AutoScrollMargin")));
			this.mybottomSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("mybottomSandBarDock.AutoScrollMinSize")));
			this.mybottomSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mybottomSandBarDock.BackgroundImage")));
			this.mybottomSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("mybottomSandBarDock.Dock")));
			this.mybottomSandBarDock.Enabled = ((bool)(resources.GetObject("mybottomSandBarDock.Enabled")));
			this.mybottomSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("mybottomSandBarDock.Font")));
			this.mybottomSandBarDock.Guid = new System.Guid("c452d62e-8add-4aea-b568-1ab19c105d91");
			this.mybottomSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("mybottomSandBarDock.ImeMode")));
			this.mybottomSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("mybottomSandBarDock.Location")));
			this.mybottomSandBarDock.Manager = this.sbm;
			this.mybottomSandBarDock.Name = "mybottomSandBarDock";
			this.mybottomSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mybottomSandBarDock.RightToLeft")));
			this.mybottomSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("mybottomSandBarDock.Size")));
			this.mybottomSandBarDock.TabIndex = ((int)(resources.GetObject("mybottomSandBarDock.TabIndex")));
			this.mybottomSandBarDock.Text = resources.GetString("mybottomSandBarDock.Text");
			this.mybottomSandBarDock.Visible = ((bool)(resources.GetObject("mybottomSandBarDock.Visible")));
			// 
			// topSandBarDock
			// 
			this.topSandBarDock.AccessibleDescription = resources.GetString("topSandBarDock.AccessibleDescription");
			this.topSandBarDock.AccessibleName = resources.GetString("topSandBarDock.AccessibleName");
			this.topSandBarDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("topSandBarDock.Anchor")));
			this.topSandBarDock.AutoScroll = ((bool)(resources.GetObject("topSandBarDock.AutoScroll")));
			this.topSandBarDock.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.AutoScrollMargin")));
			this.topSandBarDock.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.AutoScrollMinSize")));
			this.topSandBarDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topSandBarDock.BackgroundImage")));
			this.topSandBarDock.Controls.Add(this.menuBar1);
			this.topSandBarDock.Controls.Add(this.toolBar1);
			this.topSandBarDock.Controls.Add(this.tbAction);
			this.topSandBarDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("topSandBarDock.Dock")));
			this.topSandBarDock.Enabled = ((bool)(resources.GetObject("topSandBarDock.Enabled")));
			this.topSandBarDock.Font = ((System.Drawing.Font)(resources.GetObject("topSandBarDock.Font")));
			this.topSandBarDock.Guid = new System.Guid("4e621434-1359-4257-9c51-7ad4b9ca98c9");
			this.topSandBarDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("topSandBarDock.ImeMode")));
			this.topSandBarDock.Location = ((System.Drawing.Point)(resources.GetObject("topSandBarDock.Location")));
			this.topSandBarDock.Manager = this.sbm;
			this.topSandBarDock.Name = "topSandBarDock";
			this.topSandBarDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("topSandBarDock.RightToLeft")));
			this.topSandBarDock.Size = ((System.Drawing.Size)(resources.GetObject("topSandBarDock.Size")));
			this.topSandBarDock.TabIndex = ((int)(resources.GetObject("topSandBarDock.TabIndex")));
			this.topSandBarDock.Text = resources.GetString("topSandBarDock.Text");
			this.topSandBarDock.Visible = ((bool)(resources.GetObject("topSandBarDock.Visible")));
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
			this.menuBar1.Guid = new System.Guid("df109020-5454-48c9-aae5-28b65f95af1d");
			this.menuBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuBar1.ImeMode")));
			this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.menuBarItem1,
																			  this.miExtra,
																			  this.miTools,
																			  this.miWindow,
																			  this.menuBarItem5,
																			  this.miAction});
			this.menuBar1.Location = ((System.Drawing.Point)(resources.GetObject("menuBar1.Location")));
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.OwnerForm = this;
			this.menuBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuBar1.RightToLeft")));
			this.menuBar1.Size = ((System.Drawing.Size)(resources.GetObject("menuBar1.Size")));
			this.menuBar1.TabIndex = ((int)(resources.GetObject("menuBar1.TabIndex")));
			this.menuBar1.Text = resources.GetString("menuBar1.Text");
			this.menuBar1.Visible = ((bool)(resources.GetObject("menuBar1.Visible")));
			// 
			// menuBarItem1
			// 
			this.menuBarItem1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				  this.miNew,
																				  this.miOpen,
																				  this.miSave,
																				  this.miSaveAs,
																				  this.miClose,
																				  this.miRecent,
																				  this.miExit});
			this.menuBarItem1.Text = resources.GetString("menuBarItem1.Text");
			this.menuBarItem1.ToolTipText = resources.GetString("menuBarItem1.ToolTipText");
			// 
			// miNew
			// 
			this.miNew.Image = ((System.Drawing.Image)(resources.GetObject("miNew.Image")));
			this.miNew.ItemImportance = TD.SandBar.ItemImportance.Low;
			this.miNew.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNew.Shortcut")));
			this.miNew.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNew.Shortcut2")));
			this.miNew.Text = resources.GetString("miNew.Text");
			this.miNew.ToolTipText = resources.GetString("miNew.ToolTipText");
			this.miNew.Activate += new System.EventHandler(this.Activate_miNew);
			// 
			// miOpen
			// 
			this.miOpen.Image = ((System.Drawing.Image)(resources.GetObject("miOpen.Image")));
			this.miOpen.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpen.Shortcut")));
			this.miOpen.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpen.Shortcut2")));
			this.miOpen.Text = resources.GetString("miOpen.Text");
			this.miOpen.ToolTipText = resources.GetString("miOpen.ToolTipText");
			this.miOpen.Activate += new System.EventHandler(this.Activate_miOpen);
			// 
			// miSave
			// 
			this.miSave.Image = ((System.Drawing.Image)(resources.GetObject("miSave.Image")));
			this.miSave.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miSave.Shortcut")));
			this.miSave.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miSave.Shortcut2")));
			this.miSave.Text = resources.GetString("miSave.Text");
			this.miSave.ToolTipText = resources.GetString("miSave.ToolTipText");
			this.miSave.Activate += new System.EventHandler(this.Activate_miSave);
			// 
			// miSaveAs
			// 
			this.miSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("miSaveAs.Image")));
			this.miSaveAs.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miSaveAs.Shortcut")));
			this.miSaveAs.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miSaveAs.Shortcut2")));
			this.miSaveAs.Text = resources.GetString("miSaveAs.Text");
			this.miSaveAs.ToolTipText = resources.GetString("miSaveAs.ToolTipText");
			this.miSaveAs.Activate += new System.EventHandler(this.Activate_miSaveAs);
			// 
			// miClose
			// 
			this.miClose.Image = ((System.Drawing.Image)(resources.GetObject("miClose.Image")));
			this.miClose.ItemImportance = TD.SandBar.ItemImportance.Low;
			this.miClose.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miClose.Shortcut")));
			this.miClose.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miClose.Shortcut2")));
			this.miClose.Text = resources.GetString("miClose.Text");
			this.miClose.ToolTipText = resources.GetString("miClose.ToolTipText");
			this.miClose.Activate += new System.EventHandler(this.Activate_miClose);
			// 
			// miRecent
			// 
			this.miRecent.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRecent.Shortcut")));
			this.miRecent.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRecent.Shortcut2")));
			this.miRecent.Text = resources.GetString("miRecent.Text");
			this.miRecent.ToolTipText = resources.GetString("miRecent.ToolTipText");
			// 
			// miExit
			// 
			this.miExit.BeginGroup = true;
			this.miExit.Image = ((System.Drawing.Image)(resources.GetObject("miExit.Image")));
			this.miExit.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miExit.Shortcut")));
			this.miExit.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miExit.Shortcut2")));
			this.miExit.Text = resources.GetString("miExit.Text");
			this.miExit.ToolTipText = resources.GetString("miExit.ToolTipText");
			this.miExit.Activate += new System.EventHandler(this.Activate_miExit);
			// 
			// miExtra
			// 
			this.miExtra.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			 this.miMetaInfo,
																			 this.miFileNames,
																			 this.miRunSims,
																			 this.miPref});
			this.miExtra.Text = resources.GetString("miExtra.Text");
			this.miExtra.ToolTipText = resources.GetString("miExtra.ToolTipText");
			// 
			// miMetaInfo
			// 
			this.miMetaInfo.ItemImportance = TD.SandBar.ItemImportance.Low;
			this.miMetaInfo.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miMetaInfo.Shortcut")));
			this.miMetaInfo.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miMetaInfo.Shortcut2")));
			this.miMetaInfo.Text = resources.GetString("miMetaInfo.Text");
			this.miMetaInfo.ToolTipText = resources.GetString("miMetaInfo.ToolTipText");
			this.miMetaInfo.Activate += new System.EventHandler(this.Activate_miNoMeta);
			// 
			// miFileNames
			// 
			this.miFileNames.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miFileNames.Shortcut")));
			this.miFileNames.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miFileNames.Shortcut2")));
			this.miFileNames.Text = resources.GetString("miFileNames.Text");
			this.miFileNames.ToolTipText = resources.GetString("miFileNames.ToolTipText");
			this.miFileNames.Activate += new System.EventHandler(this.Activate_miFileNames);
			// 
			// miRunSims
			// 
			this.miRunSims.Image = ((System.Drawing.Image)(resources.GetObject("miRunSims.Image")));
			this.miRunSims.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRunSims.Shortcut")));
			this.miRunSims.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRunSims.Shortcut2")));
			this.miRunSims.Text = resources.GetString("miRunSims.Text");
			this.miRunSims.ToolTipText = resources.GetString("miRunSims.ToolTipText");
			this.miRunSims.Activate += new System.EventHandler(this.Activate_miRunSims);
			// 
			// miPref
			// 
			this.miPref.BeginGroup = true;
			this.miPref.Image = ((System.Drawing.Image)(resources.GetObject("miPref.Image")));
			this.miPref.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPref.Shortcut")));
			this.miPref.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miPref.Shortcut2")));
			this.miPref.Text = resources.GetString("miPref.Text");
			this.miPref.ToolTipText = resources.GetString("miPref.ToolTipText");
			this.miPref.Activate += new System.EventHandler(this.ShowPreferences);
			// 
			// miTools
			// 
			this.miTools.Text = resources.GetString("miTools.Text");
			this.miTools.ToolTipText = resources.GetString("miTools.ToolTipText");
			// 
			// miWindow
			// 
			this.miWindow.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.miNewDc});
			this.miWindow.MdiWindowList = true;
			this.miWindow.Text = resources.GetString("miWindow.Text");
			this.miWindow.ToolTipText = resources.GetString("miWindow.ToolTipText");
			// 
			// miNewDc
			// 
			this.miNewDc.Image = ((System.Drawing.Image)(resources.GetObject("miNewDc.Image")));
			this.miNewDc.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNewDc.Shortcut")));
			this.miNewDc.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miNewDc.Shortcut2")));
			this.miNewDc.Text = resources.GetString("miNewDc.Text");
			this.miNewDc.ToolTipText = resources.GetString("miNewDc.ToolTipText");
			this.miNewDc.Activate += new System.EventHandler(this.CreateNewDocumentContainer);
			// 
			// menuBarItem5
			// 
			this.menuBarItem5.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				  this.miUpdate,
																				  this.miTutorials,
																				  this.miAbout});
			this.menuBarItem5.Text = resources.GetString("menuBarItem5.Text");
			this.menuBarItem5.ToolTipText = resources.GetString("menuBarItem5.ToolTipText");
			// 
			// miUpdate
			// 
			this.miUpdate.Image = ((System.Drawing.Image)(resources.GetObject("miUpdate.Image")));
			this.miUpdate.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miUpdate.Shortcut")));
			this.miUpdate.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miUpdate.Shortcut2")));
			this.miUpdate.Text = resources.GetString("miUpdate.Text");
			this.miUpdate.ToolTipText = resources.GetString("miUpdate.ToolTipText");
			this.miUpdate.Activate += new System.EventHandler(this.Activate_miUpdate);
			// 
			// miTutorials
			// 
			this.miTutorials.Enabled = false;
			this.miTutorials.Image = ((System.Drawing.Image)(resources.GetObject("miTutorials.Image")));
			this.miTutorials.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miTutorials.Shortcut")));
			this.miTutorials.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miTutorials.Shortcut2")));
			this.miTutorials.Text = resources.GetString("miTutorials.Text");
			this.miTutorials.ToolTipText = resources.GetString("miTutorials.ToolTipText");
			// 
			// miAbout
			// 
			this.miAbout.BeginGroup = true;
			this.miAbout.Image = ((System.Drawing.Image)(resources.GetObject("miAbout.Image")));
			this.miAbout.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAbout.Shortcut")));
			this.miAbout.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAbout.Shortcut2")));
			this.miAbout.Text = resources.GetString("miAbout.Text");
			this.miAbout.ToolTipText = resources.GetString("miAbout.ToolTipText");
			this.miAbout.Activate += new System.EventHandler(this.Activate_miAbout);
			// 
			// miAction
			// 
			this.miAction.Text = resources.GetString("miAction.Text");
			this.miAction.ToolTipText = resources.GetString("miAction.ToolTipText");
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.AllowDrop = true;
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.clType,
																				 this.clGroup,
																				 this.clInstanceHigh,
																				 this.clInstance,
																				 this.clOffset,
																				 this.clSize});
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.FullRowSelect = true;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.menuBar1.SetSandBarMenu(this.lv, this.miAction);
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyDown);
			this.lv.DoubleClick += new System.EventHandler(this.SelectResourceDBClick);
			this.lv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SelectResource);
			this.lv.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ResourceListKeyUp);
			this.lv.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropFile);
			this.lv.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterFile);
			this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortResourceListClick);
			this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectResource);
			// 
			// clType
			// 
			this.clType.Text = resources.GetString("clType.Text");
			this.clType.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clType.TextAlign")));
			this.clType.Width = ((int)(resources.GetObject("clType.Width")));
			// 
			// clGroup
			// 
			this.clGroup.Text = resources.GetString("clGroup.Text");
			this.clGroup.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clGroup.TextAlign")));
			this.clGroup.Width = ((int)(resources.GetObject("clGroup.Width")));
			// 
			// clInstanceHigh
			// 
			this.clInstanceHigh.Text = resources.GetString("clInstanceHigh.Text");
			this.clInstanceHigh.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clInstanceHigh.TextAlign")));
			this.clInstanceHigh.Width = ((int)(resources.GetObject("clInstanceHigh.Width")));
			// 
			// clInstance
			// 
			this.clInstance.Text = resources.GetString("clInstance.Text");
			this.clInstance.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clInstance.TextAlign")));
			this.clInstance.Width = ((int)(resources.GetObject("clInstance.Width")));
			// 
			// clOffset
			// 
			this.clOffset.Text = resources.GetString("clOffset.Text");
			this.clOffset.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clOffset.TextAlign")));
			this.clOffset.Width = ((int)(resources.GetObject("clOffset.Width")));
			// 
			// clSize
			// 
			this.clSize.Text = resources.GetString("clSize.Text");
			this.clSize.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("clSize.TextAlign")));
			this.clSize.Width = ((int)(resources.GetObject("clSize.Width")));
			// 
			// toolBar1
			// 
			this.toolBar1.AccessibleDescription = resources.GetString("toolBar1.AccessibleDescription");
			this.toolBar1.AccessibleName = resources.GetString("toolBar1.AccessibleName");
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar1.Anchor")));
			this.toolBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar1.BackgroundImage")));
			this.toolBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar1.Dock")));
			this.toolBar1.DockLine = 1;
			this.toolBar1.Enabled = ((bool)(resources.GetObject("toolBar1.Enabled")));
			this.toolBar1.Font = ((System.Drawing.Font)(resources.GetObject("toolBar1.Font")));
			this.toolBar1.Guid = new System.Guid("450cfa2c-067d-435a-bc20-a98c7b00b268");
			this.toolBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar1.ImeMode")));
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biNew,
																			  this.biOpen,
																			  this.biSave,
																			  this.biSaveAs,
																			  this.biClose,
																			  this.biNewDc,
																			  this.biUpdate});
			this.toolBar1.Location = ((System.Drawing.Point)(resources.GetObject("toolBar1.Location")));
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar1.RightToLeft")));
			this.toolBar1.ShowShortcutsInToolTips = true;
			this.toolBar1.Size = ((System.Drawing.Size)(resources.GetObject("toolBar1.Size")));
			this.toolBar1.TabIndex = ((int)(resources.GetObject("toolBar1.TabIndex")));
			this.toolBar1.Text = resources.GetString("toolBar1.Text");
			this.toolBar1.Visible = ((bool)(resources.GetObject("toolBar1.Visible")));
			// 
			// biNew
			// 
			this.biNew.BuddyMenu = this.miNew;
			this.biNew.Image = ((System.Drawing.Image)(resources.GetObject("biNew.Image")));
			this.biNew.ItemImportance = TD.SandBar.ItemImportance.Low;
			this.biNew.Text = resources.GetString("biNew.Text");
			this.biNew.ToolTipText = resources.GetString("biNew.ToolTipText");
			// 
			// biOpen
			// 
			this.biOpen.BuddyMenu = this.miOpen;
			this.biOpen.Image = ((System.Drawing.Image)(resources.GetObject("biOpen.Image")));
			this.biOpen.ItemImportance = TD.SandBar.ItemImportance.Highest;
			this.biOpen.Text = resources.GetString("biOpen.Text");
			this.biOpen.ToolTipText = resources.GetString("biOpen.ToolTipText");
			// 
			// biSave
			// 
			this.biSave.BuddyMenu = this.miSave;
			this.biSave.Image = ((System.Drawing.Image)(resources.GetObject("biSave.Image")));
			this.biSave.ItemImportance = TD.SandBar.ItemImportance.High;
			this.biSave.Text = resources.GetString("biSave.Text");
			this.biSave.ToolTipText = resources.GetString("biSave.ToolTipText");
			// 
			// biSaveAs
			// 
			this.biSaveAs.BuddyMenu = this.miSaveAs;
			this.biSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("biSaveAs.Image")));
			this.biSaveAs.ItemImportance = TD.SandBar.ItemImportance.Lowest;
			this.biSaveAs.Text = resources.GetString("biSaveAs.Text");
			this.biSaveAs.ToolTipText = resources.GetString("biSaveAs.ToolTipText");
			// 
			// biClose
			// 
			this.biClose.BuddyMenu = this.miClose;
			this.biClose.Image = ((System.Drawing.Image)(resources.GetObject("biClose.Image")));
			this.biClose.ItemImportance = TD.SandBar.ItemImportance.Low;
			this.biClose.Text = resources.GetString("biClose.Text");
			this.biClose.ToolTipText = resources.GetString("biClose.ToolTipText");
			// 
			// biNewDc
			// 
			this.biNewDc.BeginGroup = true;
			this.biNewDc.BuddyMenu = this.miNewDc;
			this.biNewDc.Image = ((System.Drawing.Image)(resources.GetObject("biNewDc.Image")));
			this.biNewDc.Text = resources.GetString("biNewDc.Text");
			this.biNewDc.ToolTipText = resources.GetString("biNewDc.ToolTipText");
			// 
			// biUpdate
			// 
			this.biUpdate.BuddyMenu = this.miUpdate;
			this.biUpdate.Image = ((System.Drawing.Image)(resources.GetObject("biUpdate.Image")));
			this.biUpdate.ItemImportance = TD.SandBar.ItemImportance.Lowest;
			this.biUpdate.Text = resources.GetString("biUpdate.Text");
			this.biUpdate.ToolTipText = resources.GetString("biUpdate.ToolTipText");
			this.biUpdate.Visible = false;
			// 
			// tbAction
			// 
			this.tbAction.AccessibleDescription = resources.GetString("tbAction.AccessibleDescription");
			this.tbAction.AccessibleName = resources.GetString("tbAction.AccessibleName");
			this.tbAction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbAction.Anchor")));
			this.tbAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbAction.BackgroundImage")));
			this.tbAction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbAction.Dock")));
			this.tbAction.DockLine = 1;
			this.tbAction.DockOffset = 1;
			this.tbAction.Enabled = ((bool)(resources.GetObject("tbAction.Enabled")));
			this.tbAction.Font = ((System.Drawing.Font)(resources.GetObject("tbAction.Font")));
			this.tbAction.Guid = new System.Guid("7caadbda-cf74-4748-8239-5cba76a9cfe3");
			this.tbAction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbAction.ImeMode")));
			this.tbAction.Location = ((System.Drawing.Point)(resources.GetObject("tbAction.Location")));
			this.tbAction.Name = "tbAction";
			this.tbAction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbAction.RightToLeft")));
			this.tbAction.ShowShortcutsInToolTips = true;
			this.tbAction.Size = ((System.Drawing.Size)(resources.GetObject("tbAction.Size")));
			this.tbAction.TabIndex = ((int)(resources.GetObject("tbAction.TabIndex")));
			this.tbAction.Text = resources.GetString("tbAction.Text");
			this.tbAction.Visible = ((bool)(resources.GetObject("tbAction.Visible")));
			// 
			// iAnim
			// 
			this.iAnim.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.iAnim.ImageSize = ((System.Drawing.Size)(resources.GetObject("iAnim.ImageSize")));
			this.iAnim.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iAnim.ImageStream")));
			this.iAnim.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// sdm
			// 
			this.sdm.OwnerForm = this;
			this.sdm.Renderer = new TD.SandDock.Rendering.Office2003Renderer();
			// 
			// myleftSandDock
			// 
			this.myleftSandDock.AccessibleDescription = resources.GetString("myleftSandDock.AccessibleDescription");
			this.myleftSandDock.AccessibleName = resources.GetString("myleftSandDock.AccessibleName");
			this.myleftSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("myleftSandDock.Anchor")));
			this.myleftSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myleftSandDock.BackgroundImage")));
			this.myleftSandDock.Controls.Add(this.dcResource);
			this.myleftSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("myleftSandDock.Dock")));
			this.myleftSandDock.Enabled = ((bool)(resources.GetObject("myleftSandDock.Enabled")));
			this.myleftSandDock.Font = ((System.Drawing.Font)(resources.GetObject("myleftSandDock.Font")));
			this.myleftSandDock.Guid = new System.Guid("dc0c25ed-38d2-4c6b-9420-2befdae436f2");
			this.myleftSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("myleftSandDock.ImeMode")));
			this.myleftSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											   new TD.SandDock.SplitLayoutSystem(228, 331, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																																																											   new TD.SandDock.ControlLayoutSystem(228, 331, new TD.SandDock.DockControl[] {
																																																																																															   this.dcResource}, this.dcResource)})});
			this.myleftSandDock.Location = ((System.Drawing.Point)(resources.GetObject("myleftSandDock.Location")));
			this.myleftSandDock.Manager = this.sdm;
			this.myleftSandDock.MaximumSize = 1024;
			this.myleftSandDock.MinimumSize = 200;
			this.myleftSandDock.Name = "myleftSandDock";
			this.myleftSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("myleftSandDock.RightToLeft")));
			this.myleftSandDock.Size = ((System.Drawing.Size)(resources.GetObject("myleftSandDock.Size")));
			this.myleftSandDock.TabIndex = ((int)(resources.GetObject("myleftSandDock.TabIndex")));
			this.myleftSandDock.Text = resources.GetString("myleftSandDock.Text");
			this.myleftSandDock.Visible = ((bool)(resources.GetObject("myleftSandDock.Visible")));
			// 
			// dcResource
			// 
			this.dcResource.AccessibleDescription = resources.GetString("dcResource.AccessibleDescription");
			this.dcResource.AccessibleName = resources.GetString("dcResource.AccessibleName");
			this.dcResource.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcResource.Anchor")));
			this.dcResource.AutoScroll = ((bool)(resources.GetObject("dcResource.AutoScroll")));
			this.dcResource.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcResource.AutoScrollMargin")));
			this.dcResource.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcResource.AutoScrollMinSize")));
			this.dcResource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcResource.BackgroundImage")));
			this.dcResource.Controls.Add(this.tbResource);
			this.dcResource.Controls.Add(this.tvType);
			this.dcResource.Controls.Add(this.tvGroup);
			this.dcResource.Controls.Add(this.tvInstance);
			this.dcResource.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcResource.Dock")));
			this.dcResource.Enabled = ((bool)(resources.GetObject("dcResource.Enabled")));
			this.dcResource.Font = ((System.Drawing.Font)(resources.GetObject("dcResource.Font")));
			this.dcResource.Guid = new System.Guid("4eac3301-7437-4391-81dd-743cf8e38995");
			this.dcResource.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcResource.ImeMode")));
			this.dcResource.Location = ((System.Drawing.Point)(resources.GetObject("dcResource.Location")));
			this.dcResource.Name = "dcResource";
			this.dcResource.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcResource.RightToLeft")));
			this.dcResource.Size = ((System.Drawing.Size)(resources.GetObject("dcResource.Size")));
			this.dcResource.TabImage = ((System.Drawing.Image)(resources.GetObject("dcResource.TabImage")));
			this.dcResource.TabIndex = ((int)(resources.GetObject("dcResource.TabIndex")));
			this.dcResource.TabText = resources.GetString("dcResource.TabText");
			this.dcResource.Text = resources.GetString("dcResource.Text");
			this.dcResource.ToolTipText = resources.GetString("dcResource.ToolTipText");
			this.dcResource.Visible = ((bool)(resources.GetObject("dcResource.Visible")));
			// 
			// tbResource
			// 
			this.tbResource.AccessibleDescription = resources.GetString("tbResource.AccessibleDescription");
			this.tbResource.AccessibleName = resources.GetString("tbResource.AccessibleName");
			this.tbResource.AllowRightToLeft = true;
			this.tbResource.AllowVerticalDock = false;
			this.tbResource.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbResource.Anchor")));
			this.tbResource.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbResource.BackgroundImage")));
			this.tbResource.Closable = false;
			this.tbResource.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbResource.Dock")));
			this.tbResource.DockLine = 2;
			this.tbResource.Enabled = ((bool)(resources.GetObject("tbResource.Enabled")));
			this.tbResource.Font = ((System.Drawing.Font)(resources.GetObject("tbResource.Font")));
			this.tbResource.Guid = new System.Guid("40697d0b-0bda-4ca3-b517-ef9be77b6944");
			this.tbResource.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbResource.ImeMode")));
			this.tbResource.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																				this.biInstanceList,
																				this.biGroupList,
																				this.biTypeList});
			this.tbResource.Location = ((System.Drawing.Point)(resources.GetObject("tbResource.Location")));
			this.tbResource.Movable = false;
			this.tbResource.Name = "tbResource";
			this.tbResource.Resizable = false;
			this.tbResource.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbResource.RightToLeft")));
			this.tbResource.Size = ((System.Drawing.Size)(resources.GetObject("tbResource.Size")));
			this.tbResource.TabIndex = ((int)(resources.GetObject("tbResource.TabIndex")));
			this.tbResource.Tearable = false;
			this.tbResource.Text = resources.GetString("tbResource.Text");
			this.tbResource.Visible = ((bool)(resources.GetObject("tbResource.Visible")));
			// 
			// biInstanceList
			// 
			this.biInstanceList.Image = ((System.Drawing.Image)(resources.GetObject("biInstanceList.Image")));
			this.biInstanceList.Tag = "2";
			this.biInstanceList.Text = resources.GetString("biInstanceList.Text");
			this.biInstanceList.ToolTipText = resources.GetString("biInstanceList.ToolTipText");
			this.biInstanceList.Activate += new System.EventHandler(this.SelectResourceView);
			// 
			// biGroupList
			// 
			this.biGroupList.Image = ((System.Drawing.Image)(resources.GetObject("biGroupList.Image")));
			this.biGroupList.Tag = "1";
			this.biGroupList.Text = resources.GetString("biGroupList.Text");
			this.biGroupList.ToolTipText = resources.GetString("biGroupList.ToolTipText");
			this.biGroupList.Activate += new System.EventHandler(this.SelectResourceView);
			// 
			// biTypeList
			// 
			this.biTypeList.Checked = true;
			this.biTypeList.Image = ((System.Drawing.Image)(resources.GetObject("biTypeList.Image")));
			this.biTypeList.Tag = "0";
			this.biTypeList.Text = resources.GetString("biTypeList.Text");
			this.biTypeList.ToolTipText = resources.GetString("biTypeList.ToolTipText");
			this.biTypeList.Activate += new System.EventHandler(this.SelectResourceView);
			// 
			// tvType
			// 
			this.tvType.AccessibleDescription = resources.GetString("tvType.AccessibleDescription");
			this.tvType.AccessibleName = resources.GetString("tvType.AccessibleName");
			this.tvType.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tvType.Anchor")));
			this.tvType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tvType.BackgroundImage")));
			this.tvType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tvType.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tvType.Dock")));
			this.tvType.Enabled = ((bool)(resources.GetObject("tvType.Enabled")));
			this.tvType.Font = ((System.Drawing.Font)(resources.GetObject("tvType.Font")));
			this.tvType.HideSelection = false;
			this.tvType.ImageIndex = ((int)(resources.GetObject("tvType.ImageIndex")));
			this.tvType.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tvType.ImeMode")));
			this.tvType.Indent = ((int)(resources.GetObject("tvType.Indent")));
			this.tvType.ItemHeight = ((int)(resources.GetObject("tvType.ItemHeight")));
			this.tvType.Location = ((System.Drawing.Point)(resources.GetObject("tvType.Location")));
			this.tvType.Name = "tvType";
			this.tvType.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tvType.RightToLeft")));
			this.tvType.SelectedImageIndex = ((int)(resources.GetObject("tvType.SelectedImageIndex")));
			this.tvType.Size = ((System.Drawing.Size)(resources.GetObject("tvType.Size")));
			this.tvType.Sorted = true;
			this.tvType.TabIndex = ((int)(resources.GetObject("tvType.TabIndex")));
			this.tvType.Text = resources.GetString("tvType.Text");
			this.tvType.Visible = ((bool)(resources.GetObject("tvType.Visible")));
			this.tvType.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
			// 
			// tvGroup
			// 
			this.tvGroup.AccessibleDescription = resources.GetString("tvGroup.AccessibleDescription");
			this.tvGroup.AccessibleName = resources.GetString("tvGroup.AccessibleName");
			this.tvGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tvGroup.Anchor")));
			this.tvGroup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tvGroup.BackgroundImage")));
			this.tvGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tvGroup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tvGroup.Dock")));
			this.tvGroup.Enabled = ((bool)(resources.GetObject("tvGroup.Enabled")));
			this.tvGroup.Font = ((System.Drawing.Font)(resources.GetObject("tvGroup.Font")));
			this.tvGroup.HideSelection = false;
			this.tvGroup.ImageIndex = ((int)(resources.GetObject("tvGroup.ImageIndex")));
			this.tvGroup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tvGroup.ImeMode")));
			this.tvGroup.Indent = ((int)(resources.GetObject("tvGroup.Indent")));
			this.tvGroup.ItemHeight = ((int)(resources.GetObject("tvGroup.ItemHeight")));
			this.tvGroup.Location = ((System.Drawing.Point)(resources.GetObject("tvGroup.Location")));
			this.tvGroup.Name = "tvGroup";
			this.tvGroup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tvGroup.RightToLeft")));
			this.tvGroup.SelectedImageIndex = ((int)(resources.GetObject("tvGroup.SelectedImageIndex")));
			this.tvGroup.Size = ((System.Drawing.Size)(resources.GetObject("tvGroup.Size")));
			this.tvGroup.Sorted = true;
			this.tvGroup.TabIndex = ((int)(resources.GetObject("tvGroup.TabIndex")));
			this.tvGroup.Text = resources.GetString("tvGroup.Text");
			this.tvGroup.Visible = ((bool)(resources.GetObject("tvGroup.Visible")));
			this.tvGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
			// 
			// tvInstance
			// 
			this.tvInstance.AccessibleDescription = resources.GetString("tvInstance.AccessibleDescription");
			this.tvInstance.AccessibleName = resources.GetString("tvInstance.AccessibleName");
			this.tvInstance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tvInstance.Anchor")));
			this.tvInstance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tvInstance.BackgroundImage")));
			this.tvInstance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tvInstance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tvInstance.Dock")));
			this.tvInstance.Enabled = ((bool)(resources.GetObject("tvInstance.Enabled")));
			this.tvInstance.Font = ((System.Drawing.Font)(resources.GetObject("tvInstance.Font")));
			this.tvInstance.HideSelection = false;
			this.tvInstance.ImageIndex = ((int)(resources.GetObject("tvInstance.ImageIndex")));
			this.tvInstance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tvInstance.ImeMode")));
			this.tvInstance.Indent = ((int)(resources.GetObject("tvInstance.Indent")));
			this.tvInstance.ItemHeight = ((int)(resources.GetObject("tvInstance.ItemHeight")));
			this.tvInstance.Location = ((System.Drawing.Point)(resources.GetObject("tvInstance.Location")));
			this.tvInstance.Name = "tvInstance";
			this.tvInstance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tvInstance.RightToLeft")));
			this.tvInstance.SelectedImageIndex = ((int)(resources.GetObject("tvInstance.SelectedImageIndex")));
			this.tvInstance.Size = ((System.Drawing.Size)(resources.GetObject("tvInstance.Size")));
			this.tvInstance.Sorted = true;
			this.tvInstance.TabIndex = ((int)(resources.GetObject("tvInstance.TabIndex")));
			this.tvInstance.Text = resources.GetString("tvInstance.Text");
			this.tvInstance.Visible = ((bool)(resources.GetObject("tvInstance.Visible")));
			this.tvInstance.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SelectResourceNode);
			// 
			// myrightSandDock
			// 
			this.myrightSandDock.AccessibleDescription = resources.GetString("myrightSandDock.AccessibleDescription");
			this.myrightSandDock.AccessibleName = resources.GetString("myrightSandDock.AccessibleName");
			this.myrightSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("myrightSandDock.Anchor")));
			this.myrightSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myrightSandDock.BackgroundImage")));
			this.myrightSandDock.Controls.Add(this.dcPreview);
			this.myrightSandDock.Controls.Add(this.dcFilter);
			this.myrightSandDock.Controls.Add(this.dcAction);
			this.myrightSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("myrightSandDock.Dock")));
			this.myrightSandDock.Enabled = ((bool)(resources.GetObject("myrightSandDock.Enabled")));
			this.myrightSandDock.Font = ((System.Drawing.Font)(resources.GetObject("myrightSandDock.Font")));
			this.myrightSandDock.Guid = new System.Guid("645618eb-a628-4136-9e3c-ff24b55d28ba");
			this.myrightSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("myrightSandDock.ImeMode")));
			this.myrightSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																												new TD.SandDock.ControlLayoutSystem(176, 331, new TD.SandDock.DockControl[] {
																																																																this.dcFilter,
																																																																this.dcPreview,
																																																																this.dcAction}, this.dcPreview)});
			this.myrightSandDock.Location = ((System.Drawing.Point)(resources.GetObject("myrightSandDock.Location")));
			this.myrightSandDock.Manager = this.sdm;
			this.myrightSandDock.MaximumSize = 400;
			this.myrightSandDock.MinimumSize = 144;
			this.myrightSandDock.Name = "myrightSandDock";
			this.myrightSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("myrightSandDock.RightToLeft")));
			this.myrightSandDock.Size = ((System.Drawing.Size)(resources.GetObject("myrightSandDock.Size")));
			this.myrightSandDock.TabIndex = ((int)(resources.GetObject("myrightSandDock.TabIndex")));
			this.myrightSandDock.Text = resources.GetString("myrightSandDock.Text");
			this.myrightSandDock.Visible = ((bool)(resources.GetObject("myrightSandDock.Visible")));
			// 
			// dcPreview
			// 
			this.dcPreview.AccessibleDescription = resources.GetString("dcPreview.AccessibleDescription");
			this.dcPreview.AccessibleName = resources.GetString("dcPreview.AccessibleName");
			this.dcPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcPreview.Anchor")));
			this.dcPreview.AutoScroll = ((bool)(resources.GetObject("dcPreview.AutoScroll")));
			this.dcPreview.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcPreview.AutoScrollMargin")));
			this.dcPreview.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcPreview.AutoScrollMinSize")));
			this.dcPreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcPreview.BackgroundImage")));
			this.dcPreview.Controls.Add(this.xpGradientPanel3);
			this.dcPreview.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcPreview.Dock")));
			this.dcPreview.Enabled = ((bool)(resources.GetObject("dcPreview.Enabled")));
			this.dcPreview.Font = ((System.Drawing.Font)(resources.GetObject("dcPreview.Font")));
			this.dcPreview.Guid = new System.Guid("4f8a3661-233c-42c5-95d2-4b5371815430");
			this.dcPreview.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcPreview.ImeMode")));
			this.dcPreview.Location = ((System.Drawing.Point)(resources.GetObject("dcPreview.Location")));
			this.dcPreview.Name = "dcPreview";
			this.dcPreview.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcPreview.RightToLeft")));
			this.dcPreview.Size = ((System.Drawing.Size)(resources.GetObject("dcPreview.Size")));
			this.dcPreview.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPreview.TabImage")));
			this.dcPreview.TabIndex = ((int)(resources.GetObject("dcPreview.TabIndex")));
			this.dcPreview.TabText = resources.GetString("dcPreview.TabText");
			this.dcPreview.Text = resources.GetString("dcPreview.Text");
			this.dcPreview.ToolTipText = resources.GetString("dcPreview.ToolTipText");
			this.dcPreview.Visible = ((bool)(resources.GetObject("dcPreview.Visible")));
			// 
			// xpGradientPanel3
			// 
			this.xpGradientPanel3.AccessibleDescription = resources.GetString("xpGradientPanel3.AccessibleDescription");
			this.xpGradientPanel3.AccessibleName = resources.GetString("xpGradientPanel3.AccessibleName");
			this.xpGradientPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel3.Anchor")));
			this.xpGradientPanel3.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel3.AutoScroll")));
			this.xpGradientPanel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.AutoScrollMargin")));
			this.xpGradientPanel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.AutoScrollMinSize")));
			this.xpGradientPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel3.BackgroundImage")));
			this.xpGradientPanel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel3.Dock")));
			this.xpGradientPanel3.Enabled = ((bool)(resources.GetObject("xpGradientPanel3.Enabled")));
			this.xpGradientPanel3.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel3.Font")));
			this.xpGradientPanel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel3.ImeMode")));
			this.xpGradientPanel3.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel3.Location")));
			this.xpGradientPanel3.Name = "xpGradientPanel3";
			this.xpGradientPanel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel3.RightToLeft")));
			this.xpGradientPanel3.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.Size")));
			this.xpGradientPanel3.TabIndex = ((int)(resources.GetObject("xpGradientPanel3.TabIndex")));
			this.xpGradientPanel3.Text = resources.GetString("xpGradientPanel3.Text");
			this.xpGradientPanel3.Visible = ((bool)(resources.GetObject("xpGradientPanel3.Visible")));
			this.xpGradientPanel3.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel3.Watermark")));
			this.xpGradientPanel3.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel3.WatermarkSize")));
			// 
			// dcFilter
			// 
			this.dcFilter.AccessibleDescription = resources.GetString("dcFilter.AccessibleDescription");
			this.dcFilter.AccessibleName = resources.GetString("dcFilter.AccessibleName");
			this.dcFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcFilter.Anchor")));
			this.dcFilter.AutoScroll = ((bool)(resources.GetObject("dcFilter.AutoScroll")));
			this.dcFilter.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcFilter.AutoScrollMargin")));
			this.dcFilter.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcFilter.AutoScrollMinSize")));
			this.dcFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcFilter.BackgroundImage")));
			this.dcFilter.Controls.Add(this.xpGradientPanel1);
			this.dcFilter.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcFilter.Dock")));
			this.dcFilter.Enabled = ((bool)(resources.GetObject("dcFilter.Enabled")));
			this.dcFilter.Font = ((System.Drawing.Font)(resources.GetObject("dcFilter.Font")));
			this.dcFilter.Guid = new System.Guid("c59bd96f-14b3-4922-a956-28fb5a9aec97");
			this.dcFilter.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcFilter.ImeMode")));
			this.dcFilter.Location = ((System.Drawing.Point)(resources.GetObject("dcFilter.Location")));
			this.dcFilter.Name = "dcFilter";
			this.dcFilter.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcFilter.RightToLeft")));
			this.dcFilter.Size = ((System.Drawing.Size)(resources.GetObject("dcFilter.Size")));
			this.dcFilter.TabImage = ((System.Drawing.Image)(resources.GetObject("dcFilter.TabImage")));
			this.dcFilter.TabIndex = ((int)(resources.GetObject("dcFilter.TabIndex")));
			this.dcFilter.TabText = resources.GetString("dcFilter.TabText");
			this.dcFilter.Text = resources.GetString("dcFilter.Text");
			this.dcFilter.ToolTipText = resources.GetString("dcFilter.ToolTipText");
			this.dcFilter.Visible = ((bool)(resources.GetObject("dcFilter.Visible")));
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
			this.xpGradientPanel1.Controls.Add(this.xpLinkedLabelIcon1);
			this.xpGradientPanel1.Controls.Add(this.tbInst);
			this.xpGradientPanel1.Controls.Add(this.tbGrp);
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// xpLinkedLabelIcon1
			// 
			this.xpLinkedLabelIcon1.AccessibleDescription = resources.GetString("xpLinkedLabelIcon1.AccessibleDescription");
			this.xpLinkedLabelIcon1.AccessibleName = resources.GetString("xpLinkedLabelIcon1.AccessibleName");
			this.xpLinkedLabelIcon1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpLinkedLabelIcon1.Anchor")));
			this.xpLinkedLabelIcon1.AutoScroll = ((bool)(resources.GetObject("xpLinkedLabelIcon1.AutoScroll")));
			this.xpLinkedLabelIcon1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpLinkedLabelIcon1.AutoScrollMargin")));
			this.xpLinkedLabelIcon1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpLinkedLabelIcon1.AutoScrollMinSize")));
			this.xpLinkedLabelIcon1.BackColor = System.Drawing.Color.Transparent;
			this.xpLinkedLabelIcon1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpLinkedLabelIcon1.BackgroundImage")));
			this.xpLinkedLabelIcon1.DisabledLinkColor = System.Drawing.Color.FromArgb(((System.Byte)(105)), ((System.Byte)(99)), ((System.Byte)(50)));
			this.xpLinkedLabelIcon1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpLinkedLabelIcon1.Dock")));
			this.xpLinkedLabelIcon1.Enabled = ((bool)(resources.GetObject("xpLinkedLabelIcon1.Enabled")));
			this.xpLinkedLabelIcon1.Font = ((System.Drawing.Font)(resources.GetObject("xpLinkedLabelIcon1.Font")));
			this.xpLinkedLabelIcon1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpLinkedLabelIcon1.ImeMode")));
			this.xpLinkedLabelIcon1.LinkArea = new System.Windows.Forms.LinkArea(0, 3);
			this.xpLinkedLabelIcon1.LinkColor = System.Drawing.Color.FromArgb(((System.Byte)(0)), ((System.Byte)(0)), ((System.Byte)(255)));
			this.xpLinkedLabelIcon1.Location = ((System.Drawing.Point)(resources.GetObject("xpLinkedLabelIcon1.Location")));
			this.xpLinkedLabelIcon1.Name = "xpLinkedLabelIcon1";
			this.xpLinkedLabelIcon1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpLinkedLabelIcon1.RightToLeft")));
			this.xpLinkedLabelIcon1.Size = ((System.Drawing.Size)(resources.GetObject("xpLinkedLabelIcon1.Size")));
			this.xpLinkedLabelIcon1.TabIndex = ((int)(resources.GetObject("xpLinkedLabelIcon1.TabIndex")));
			this.xpLinkedLabelIcon1.Text = resources.GetString("xpLinkedLabelIcon1.Text");
			this.xpLinkedLabelIcon1.Visible = ((bool)(resources.GetObject("xpLinkedLabelIcon1.Visible")));
			this.xpLinkedLabelIcon1.VisitedLinkColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(0)), ((System.Byte)(128)));
			this.xpLinkedLabelIcon1.LinkClicked += new System.EventHandler(this.SetFilter);
			// 
			// dcAction
			// 
			this.dcAction.AccessibleDescription = resources.GetString("dcAction.AccessibleDescription");
			this.dcAction.AccessibleName = resources.GetString("dcAction.AccessibleName");
			this.dcAction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcAction.Anchor")));
			this.dcAction.AutoScroll = ((bool)(resources.GetObject("dcAction.AutoScroll")));
			this.dcAction.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcAction.AutoScrollMargin")));
			this.dcAction.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcAction.AutoScrollMinSize")));
			this.dcAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcAction.BackgroundImage")));
			this.dcAction.Controls.Add(this.xpGradientPanel2);
			this.dcAction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcAction.Dock")));
			this.dcAction.Enabled = ((bool)(resources.GetObject("dcAction.Enabled")));
			this.dcAction.Font = ((System.Drawing.Font)(resources.GetObject("dcAction.Font")));
			this.dcAction.Guid = new System.Guid("8846d9fc-3828-4354-94b4-6a89120bbab3");
			this.dcAction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcAction.ImeMode")));
			this.dcAction.Location = ((System.Drawing.Point)(resources.GetObject("dcAction.Location")));
			this.dcAction.Name = "dcAction";
			this.dcAction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcAction.RightToLeft")));
			this.dcAction.Size = ((System.Drawing.Size)(resources.GetObject("dcAction.Size")));
			this.dcAction.TabImage = ((System.Drawing.Image)(resources.GetObject("dcAction.TabImage")));
			this.dcAction.TabIndex = ((int)(resources.GetObject("dcAction.TabIndex")));
			this.dcAction.TabText = resources.GetString("dcAction.TabText");
			this.dcAction.Text = resources.GetString("dcAction.Text");
			this.dcAction.ToolTipText = resources.GetString("dcAction.ToolTipText");
			this.dcAction.Visible = ((bool)(resources.GetObject("dcAction.Visible")));
			// 
			// xpGradientPanel2
			// 
			this.xpGradientPanel2.AccessibleDescription = resources.GetString("xpGradientPanel2.AccessibleDescription");
			this.xpGradientPanel2.AccessibleName = resources.GetString("xpGradientPanel2.AccessibleName");
			this.xpGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel2.Anchor")));
			this.xpGradientPanel2.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel2.AutoScroll")));
			this.xpGradientPanel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.AutoScrollMargin")));
			this.xpGradientPanel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.AutoScrollMinSize")));
			this.xpGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel2.BackgroundImage")));
			this.xpGradientPanel2.Controls.Add(this.tbExtAction);
			this.xpGradientPanel2.Controls.Add(this.tbPlugAction);
			this.xpGradientPanel2.Controls.Add(this.tbDefaultAction);
			this.xpGradientPanel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel2.Dock")));
			this.xpGradientPanel2.DockPadding.Left = 4;
			this.xpGradientPanel2.DockPadding.Right = 4;
			this.xpGradientPanel2.Enabled = ((bool)(resources.GetObject("xpGradientPanel2.Enabled")));
			this.xpGradientPanel2.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel2.Font")));
			this.xpGradientPanel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel2.ImeMode")));
			this.xpGradientPanel2.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel2.Location")));
			this.xpGradientPanel2.Name = "xpGradientPanel2";
			this.xpGradientPanel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel2.RightToLeft")));
			this.xpGradientPanel2.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.Size")));
			this.xpGradientPanel2.TabIndex = ((int)(resources.GetObject("xpGradientPanel2.TabIndex")));
			this.xpGradientPanel2.Text = resources.GetString("xpGradientPanel2.Text");
			this.xpGradientPanel2.Visible = ((bool)(resources.GetObject("xpGradientPanel2.Visible")));
			this.xpGradientPanel2.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel2.Watermark")));
			this.xpGradientPanel2.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel2.WatermarkSize")));
			// 
			// tbExtAction
			// 
			this.tbExtAction.AccessibleDescription = resources.GetString("tbExtAction.AccessibleDescription");
			this.tbExtAction.AccessibleName = resources.GetString("tbExtAction.AccessibleName");
			this.tbExtAction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbExtAction.Anchor")));
			this.tbExtAction.AutoScroll = ((bool)(resources.GetObject("tbExtAction.AutoScroll")));
			this.tbExtAction.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbExtAction.AutoScrollMargin")));
			this.tbExtAction.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbExtAction.AutoScrollMinSize")));
			this.tbExtAction.BackColor = System.Drawing.Color.Transparent;
			this.tbExtAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbExtAction.BackgroundImage")));
			this.tbExtAction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbExtAction.Dock")));
			this.tbExtAction.DockPadding.Bottom = 4;
			this.tbExtAction.DockPadding.Left = 4;
			this.tbExtAction.DockPadding.Right = 4;
			this.tbExtAction.DockPadding.Top = 44;
			this.tbExtAction.Enabled = ((bool)(resources.GetObject("tbExtAction.Enabled")));
			this.tbExtAction.Font = ((System.Drawing.Font)(resources.GetObject("tbExtAction.Font")));
			this.tbExtAction.HeaderText = resources.GetString("tbExtAction.HeaderText");
			this.tbExtAction.Icon = ((System.Drawing.Icon)(resources.GetObject("tbExtAction.Icon")));
			this.tbExtAction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbExtAction.ImeMode")));
			this.tbExtAction.Location = ((System.Drawing.Point)(resources.GetObject("tbExtAction.Location")));
			this.tbExtAction.Name = "tbExtAction";
			this.tbExtAction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbExtAction.RightToLeft")));
			this.tbExtAction.Size = ((System.Drawing.Size)(resources.GetObject("tbExtAction.Size")));
			this.tbExtAction.TabIndex = ((int)(resources.GetObject("tbExtAction.TabIndex")));
			this.tbExtAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbExtAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
			this.tbExtAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbExtAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
			this.tbExtAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown")));
			this.tbExtAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight")));
			this.tbExtAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp")));
			this.tbExtAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight")));
			this.tbExtAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.tbExtAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbExtAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.tbExtAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
			this.tbExtAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbExtAction.Visible = ((bool)(resources.GetObject("tbExtAction.Visible")));
			// 
			// tbPlugAction
			// 
			this.tbPlugAction.AccessibleDescription = resources.GetString("tbPlugAction.AccessibleDescription");
			this.tbPlugAction.AccessibleName = resources.GetString("tbPlugAction.AccessibleName");
			this.tbPlugAction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbPlugAction.Anchor")));
			this.tbPlugAction.AutoScroll = ((bool)(resources.GetObject("tbPlugAction.AutoScroll")));
			this.tbPlugAction.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbPlugAction.AutoScrollMargin")));
			this.tbPlugAction.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbPlugAction.AutoScrollMinSize")));
			this.tbPlugAction.BackColor = System.Drawing.Color.Transparent;
			this.tbPlugAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbPlugAction.BackgroundImage")));
			this.tbPlugAction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbPlugAction.Dock")));
			this.tbPlugAction.DockPadding.Bottom = 4;
			this.tbPlugAction.DockPadding.Left = 4;
			this.tbPlugAction.DockPadding.Right = 4;
			this.tbPlugAction.DockPadding.Top = 44;
			this.tbPlugAction.Enabled = ((bool)(resources.GetObject("tbPlugAction.Enabled")));
			this.tbPlugAction.Font = ((System.Drawing.Font)(resources.GetObject("tbPlugAction.Font")));
			this.tbPlugAction.HeaderText = resources.GetString("tbPlugAction.HeaderText");
			this.tbPlugAction.Icon = ((System.Drawing.Icon)(resources.GetObject("tbPlugAction.Icon")));
			this.tbPlugAction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbPlugAction.ImeMode")));
			this.tbPlugAction.Location = ((System.Drawing.Point)(resources.GetObject("tbPlugAction.Location")));
			this.tbPlugAction.Name = "tbPlugAction";
			this.tbPlugAction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbPlugAction.RightToLeft")));
			this.tbPlugAction.Size = ((System.Drawing.Size)(resources.GetObject("tbPlugAction.Size")));
			this.tbPlugAction.TabIndex = ((int)(resources.GetObject("tbPlugAction.TabIndex")));
			this.tbPlugAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbPlugAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
			this.tbPlugAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbPlugAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
			this.tbPlugAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown1")));
			this.tbPlugAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight1")));
			this.tbPlugAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp1")));
			this.tbPlugAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight1")));
			this.tbPlugAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.tbPlugAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbPlugAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.tbPlugAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
			this.tbPlugAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbPlugAction.Visible = ((bool)(resources.GetObject("tbPlugAction.Visible")));
			// 
			// tbDefaultAction
			// 
			this.tbDefaultAction.AccessibleDescription = resources.GetString("tbDefaultAction.AccessibleDescription");
			this.tbDefaultAction.AccessibleName = resources.GetString("tbDefaultAction.AccessibleName");
			this.tbDefaultAction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbDefaultAction.Anchor")));
			this.tbDefaultAction.AutoScroll = ((bool)(resources.GetObject("tbDefaultAction.AutoScroll")));
			this.tbDefaultAction.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbDefaultAction.AutoScrollMargin")));
			this.tbDefaultAction.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbDefaultAction.AutoScrollMinSize")));
			this.tbDefaultAction.BackColor = System.Drawing.Color.Transparent;
			this.tbDefaultAction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbDefaultAction.BackgroundImage")));
			this.tbDefaultAction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbDefaultAction.Dock")));
			this.tbDefaultAction.DockPadding.Bottom = 4;
			this.tbDefaultAction.DockPadding.Left = 4;
			this.tbDefaultAction.DockPadding.Right = 4;
			this.tbDefaultAction.DockPadding.Top = 44;
			this.tbDefaultAction.Enabled = ((bool)(resources.GetObject("tbDefaultAction.Enabled")));
			this.tbDefaultAction.Font = ((System.Drawing.Font)(resources.GetObject("tbDefaultAction.Font")));
			this.tbDefaultAction.HeaderText = resources.GetString("tbDefaultAction.HeaderText");
			this.tbDefaultAction.Icon = ((System.Drawing.Icon)(resources.GetObject("tbDefaultAction.Icon")));
			this.tbDefaultAction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbDefaultAction.ImeMode")));
			this.tbDefaultAction.Location = ((System.Drawing.Point)(resources.GetObject("tbDefaultAction.Location")));
			this.tbDefaultAction.Name = "tbDefaultAction";
			this.tbDefaultAction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbDefaultAction.RightToLeft")));
			this.tbDefaultAction.Size = ((System.Drawing.Size)(resources.GetObject("tbDefaultAction.Size")));
			this.tbDefaultAction.TabIndex = ((int)(resources.GetObject("tbDefaultAction.TabIndex")));
			this.tbDefaultAction.ThemeFormat.BodyColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbDefaultAction.ThemeFormat.BodyFont = new System.Drawing.Font("Tahoma", 8F);
			this.tbDefaultAction.ThemeFormat.BodyTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbDefaultAction.ThemeFormat.BorderColor = System.Drawing.Color.White;
			this.tbDefaultAction.ThemeFormat.ChevronDown = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDown2")));
			this.tbDefaultAction.ThemeFormat.ChevronDownHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronDownHighlight2")));
			this.tbDefaultAction.ThemeFormat.ChevronUp = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUp2")));
			this.tbDefaultAction.ThemeFormat.ChevronUpHighlight = ((System.Drawing.Bitmap)(resources.GetObject("resource.ChevronUpHighlight2")));
			this.tbDefaultAction.ThemeFormat.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.tbDefaultAction.ThemeFormat.HeaderTextColor = System.Drawing.Color.FromArgb(((System.Byte)(33)), ((System.Byte)(93)), ((System.Byte)(198)));
			this.tbDefaultAction.ThemeFormat.HeaderTextHighlightColor = System.Drawing.Color.FromArgb(((System.Byte)(66)), ((System.Byte)(142)), ((System.Byte)(255)));
			this.tbDefaultAction.ThemeFormat.LeftHeaderColor = System.Drawing.Color.White;
			this.tbDefaultAction.ThemeFormat.RightHeaderColor = System.Drawing.Color.FromArgb(((System.Byte)(197)), ((System.Byte)(210)), ((System.Byte)(240)));
			this.tbDefaultAction.Visible = ((bool)(resources.GetObject("tbDefaultAction.Visible")));
			// 
			// mybottomSandDock
			// 
			this.mybottomSandDock.AccessibleDescription = resources.GetString("mybottomSandDock.AccessibleDescription");
			this.mybottomSandDock.AccessibleName = resources.GetString("mybottomSandDock.AccessibleName");
			this.mybottomSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("mybottomSandDock.Anchor")));
			this.mybottomSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mybottomSandDock.BackgroundImage")));
			this.mybottomSandDock.Controls.Add(this.dcPlugin);
			this.mybottomSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("mybottomSandDock.Dock")));
			this.mybottomSandDock.Enabled = ((bool)(resources.GetObject("mybottomSandDock.Enabled")));
			this.mybottomSandDock.Font = ((System.Drawing.Font)(resources.GetObject("mybottomSandDock.Font")));
			this.mybottomSandDock.Guid = new System.Guid("a20dcccb-ae75-4862-815f-b88456de8319");
			this.mybottomSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("mybottomSandDock.ImeMode")));
			this.mybottomSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Vertical, new TD.SandDock.LayoutSystemBase[] {
																																											   new TD.SandDock.ControlLayoutSystem(924, 188, new TD.SandDock.DockControl[] {
																																																															   this.dcPlugin}, this.dcPlugin)});
			this.mybottomSandDock.Location = ((System.Drawing.Point)(resources.GetObject("mybottomSandDock.Location")));
			this.mybottomSandDock.Manager = this.sdm;
			this.mybottomSandDock.MaximumSize = 1024;
			this.mybottomSandDock.Name = "mybottomSandDock";
			this.mybottomSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mybottomSandDock.RightToLeft")));
			this.mybottomSandDock.Size = ((System.Drawing.Size)(resources.GetObject("mybottomSandDock.Size")));
			this.mybottomSandDock.TabIndex = ((int)(resources.GetObject("mybottomSandDock.TabIndex")));
			this.mybottomSandDock.Text = resources.GetString("mybottomSandDock.Text");
			this.mybottomSandDock.Visible = ((bool)(resources.GetObject("mybottomSandDock.Visible")));
			// 
			// dcPlugin
			// 
			this.dcPlugin.AccessibleDescription = resources.GetString("dcPlugin.AccessibleDescription");
			this.dcPlugin.AccessibleName = resources.GetString("dcPlugin.AccessibleName");
			this.dcPlugin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dcPlugin.Anchor")));
			this.dcPlugin.AutoScroll = ((bool)(resources.GetObject("dcPlugin.AutoScroll")));
			this.dcPlugin.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dcPlugin.AutoScrollMargin")));
			this.dcPlugin.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dcPlugin.AutoScrollMinSize")));
			this.dcPlugin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dcPlugin.BackgroundImage")));
			this.dcPlugin.Controls.Add(this.dc);
			this.dcPlugin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dcPlugin.Dock")));
			this.dcPlugin.Enabled = ((bool)(resources.GetObject("dcPlugin.Enabled")));
			this.dcPlugin.Font = ((System.Drawing.Font)(resources.GetObject("dcPlugin.Font")));
			this.dcPlugin.Guid = new System.Guid("1fc41585-f06c-418c-8226-523fdec0f9c4");
			this.dcPlugin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dcPlugin.ImeMode")));
			this.dcPlugin.Location = ((System.Drawing.Point)(resources.GetObject("dcPlugin.Location")));
			this.dcPlugin.Name = "dcPlugin";
			this.dcPlugin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dcPlugin.RightToLeft")));
			this.dcPlugin.Size = ((System.Drawing.Size)(resources.GetObject("dcPlugin.Size")));
			this.dcPlugin.TabImage = ((System.Drawing.Image)(resources.GetObject("dcPlugin.TabImage")));
			this.dcPlugin.TabIndex = ((int)(resources.GetObject("dcPlugin.TabIndex")));
			this.dcPlugin.TabText = resources.GetString("dcPlugin.TabText");
			this.dcPlugin.Text = resources.GetString("dcPlugin.Text");
			this.dcPlugin.ToolTipText = resources.GetString("dcPlugin.ToolTipText");
			this.dcPlugin.Visible = ((bool)(resources.GetObject("dcPlugin.Visible")));
			// 
			// dc
			// 
			this.dc.AccessibleDescription = resources.GetString("dc.AccessibleDescription");
			this.dc.AccessibleName = resources.GetString("dc.AccessibleName");
			this.dc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dc.Anchor")));
			this.dc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dc.BackgroundImage")));
			this.dc.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.dc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dc.Dock")));
			this.dc.Enabled = ((bool)(resources.GetObject("dc.Enabled")));
			this.dc.Font = ((System.Drawing.Font)(resources.GetObject("dc.Font")));
			this.dc.Guid = new System.Guid("617410aa-42d8-41b4-bf91-0e647dca118e");
			this.dc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dc.ImeMode")));
			this.dc.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.dc.Location = ((System.Drawing.Point)(resources.GetObject("dc.Location")));
			this.dc.Manager = null;
			this.dc.Name = "dc";
			this.dc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dc.RightToLeft")));
			this.dc.Size = ((System.Drawing.Size)(resources.GetObject("dc.Size")));
			this.dc.TabIndex = ((int)(resources.GetObject("dc.TabIndex")));
			this.dc.Text = resources.GetString("dc.Text");
			this.dc.Visible = ((bool)(resources.GetObject("dc.Visible")));
			this.dc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dc_MouseUp);
			// 
			// xpGradientPanel5
			// 
			this.xpGradientPanel5.AccessibleDescription = resources.GetString("xpGradientPanel5.AccessibleDescription");
			this.xpGradientPanel5.AccessibleName = resources.GetString("xpGradientPanel5.AccessibleName");
			this.xpGradientPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel5.Anchor")));
			this.xpGradientPanel5.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel5.AutoScroll")));
			this.xpGradientPanel5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel5.AutoScrollMargin")));
			this.xpGradientPanel5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel5.AutoScrollMinSize")));
			this.xpGradientPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel5.BackgroundImage")));
			this.xpGradientPanel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel5.Dock")));
			this.xpGradientPanel5.Enabled = ((bool)(resources.GetObject("xpGradientPanel5.Enabled")));
			this.xpGradientPanel5.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel5.Font")));
			this.xpGradientPanel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel5.ImeMode")));
			this.xpGradientPanel5.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel5.Location")));
			this.xpGradientPanel5.Name = "xpGradientPanel5";
			this.xpGradientPanel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel5.RightToLeft")));
			this.xpGradientPanel5.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel5.Size")));
			this.xpGradientPanel5.TabIndex = ((int)(resources.GetObject("xpGradientPanel5.TabIndex")));
			this.xpGradientPanel5.Text = resources.GetString("xpGradientPanel5.Text");
			this.xpGradientPanel5.Visible = ((bool)(resources.GetObject("xpGradientPanel5.Visible")));
			this.xpGradientPanel5.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel5.Watermark")));
			this.xpGradientPanel5.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel5.WatermarkSize")));
			// 
			// mytopSandDock
			// 
			this.mytopSandDock.AccessibleDescription = resources.GetString("mytopSandDock.AccessibleDescription");
			this.mytopSandDock.AccessibleName = resources.GetString("mytopSandDock.AccessibleName");
			this.mytopSandDock.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("mytopSandDock.Anchor")));
			this.mytopSandDock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mytopSandDock.BackgroundImage")));
			this.mytopSandDock.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("mytopSandDock.Dock")));
			this.mytopSandDock.Enabled = ((bool)(resources.GetObject("mytopSandDock.Enabled")));
			this.mytopSandDock.Font = ((System.Drawing.Font)(resources.GetObject("mytopSandDock.Font")));
			this.mytopSandDock.Guid = new System.Guid("2bf576f0-af0c-4c49-9fe9-e45fbc4e57e8");
			this.mytopSandDock.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("mytopSandDock.ImeMode")));
			this.mytopSandDock.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400);
			this.mytopSandDock.Location = ((System.Drawing.Point)(resources.GetObject("mytopSandDock.Location")));
			this.mytopSandDock.Manager = this.sdm;
			this.mytopSandDock.Name = "mytopSandDock";
			this.mytopSandDock.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("mytopSandDock.RightToLeft")));
			this.mytopSandDock.Size = ((System.Drawing.Size)(resources.GetObject("mytopSandDock.Size")));
			this.mytopSandDock.TabIndex = ((int)(resources.GetObject("mytopSandDock.TabIndex")));
			this.mytopSandDock.Text = resources.GetString("mytopSandDock.Text");
			this.mytopSandDock.Visible = ((bool)(resources.GetObject("mytopSandDock.Visible")));
			// 
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.splitter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitter1.BackgroundImage")));
			this.splitter1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitter1.Dock")));
			this.splitter1.Enabled = ((bool)(resources.GetObject("splitter1.Enabled")));
			this.splitter1.Font = ((System.Drawing.Font)(resources.GetObject("splitter1.Font")));
			this.splitter1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitter1.ImeMode")));
			this.splitter1.Location = ((System.Drawing.Point)(resources.GetObject("splitter1.Location")));
			this.splitter1.MinExtra = ((int)(resources.GetObject("splitter1.MinExtra")));
			this.splitter1.MinSize = ((int)(resources.GetObject("splitter1.MinSize")));
			this.splitter1.Name = "splitter1";
			this.splitter1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitter1.RightToLeft")));
			this.splitter1.Size = ((System.Drawing.Size)(resources.GetObject("splitter1.Size")));
			this.splitter1.TabIndex = ((int)(resources.GetObject("splitter1.TabIndex")));
			this.splitter1.TabStop = false;
			this.splitter1.Visible = ((bool)(resources.GetObject("splitter1.Visible")));
			// 
			// sb
			// 
			this.sb.AccessibleDescription = resources.GetString("sb.AccessibleDescription");
			this.sb.AccessibleName = resources.GetString("sb.AccessibleName");
			this.sb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("sb.Anchor")));
			this.sb.AutoScroll = ((bool)(resources.GetObject("sb.AutoScroll")));
			this.sb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("sb.AutoScrollMargin")));
			this.sb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("sb.AutoScrollMinSize")));
			this.sb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sb.BackgroundImage")));
			this.sb.Controls.Add(this.pbimg);
			this.sb.Controls.Add(this.xpLine1);
			this.sb.Controls.Add(this.pbWait);
			this.sb.Controls.Add(this.lbOp);
			this.sb.Controls.Add(this.lnProg2);
			this.sb.Controls.Add(this.lbPercent);
			this.sb.Controls.Add(this.lnProg);
			this.sb.Controls.Add(this.pb);
			this.sb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("sb.Dock")));
			this.sb.DockPadding.Bottom = 4;
			this.sb.DockPadding.Left = 8;
			this.sb.DockPadding.Right = 8;
			this.sb.DockPadding.Top = 4;
			this.sb.Enabled = ((bool)(resources.GetObject("sb.Enabled")));
			this.sb.Font = ((System.Drawing.Font)(resources.GetObject("sb.Font")));
			this.sb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("sb.ImeMode")));
			this.sb.Location = ((System.Drawing.Point)(resources.GetObject("sb.Location")));
			this.sb.Name = "sb";
			this.sb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("sb.RightToLeft")));
			this.sb.Size = ((System.Drawing.Size)(resources.GetObject("sb.Size")));
			this.sb.TabIndex = ((int)(resources.GetObject("sb.TabIndex")));
			this.sb.Text = resources.GetString("sb.Text");
			this.sb.Visible = ((bool)(resources.GetObject("sb.Visible")));
			this.sb.Watermark = ((System.Drawing.Image)(resources.GetObject("sb.Watermark")));
			this.sb.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("sb.WatermarkSize")));
			// 
			// pbimg
			// 
			this.pbimg.AccessibleDescription = resources.GetString("pbimg.AccessibleDescription");
			this.pbimg.AccessibleName = resources.GetString("pbimg.AccessibleName");
			this.pbimg.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbimg.Anchor")));
			this.pbimg.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.pbimg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbimg.BackgroundImage")));
			this.pbimg.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbimg.Dock")));
			this.pbimg.Enabled = ((bool)(resources.GetObject("pbimg.Enabled")));
			this.pbimg.Font = ((System.Drawing.Font)(resources.GetObject("pbimg.Font")));
			this.pbimg.Image = ((System.Drawing.Image)(resources.GetObject("pbimg.Image")));
			this.pbimg.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbimg.ImeMode")));
			this.pbimg.Location = ((System.Drawing.Point)(resources.GetObject("pbimg.Location")));
			this.pbimg.Name = "pbimg";
			this.pbimg.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbimg.RightToLeft")));
			this.pbimg.Size = ((System.Drawing.Size)(resources.GetObject("pbimg.Size")));
			this.pbimg.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbimg.SizeMode")));
			this.pbimg.TabIndex = ((int)(resources.GetObject("pbimg.TabIndex")));
			this.pbimg.TabStop = false;
			this.pbimg.Text = resources.GetString("pbimg.Text");
			this.pbimg.Visible = ((bool)(resources.GetObject("pbimg.Visible")));
			// 
			// xpLine1
			// 
			this.xpLine1.AccessibleDescription = resources.GetString("xpLine1.AccessibleDescription");
			this.xpLine1.AccessibleName = resources.GetString("xpLine1.AccessibleName");
			this.xpLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpLine1.Anchor")));
			this.xpLine1.AutoScroll = ((bool)(resources.GetObject("xpLine1.AutoScroll")));
			this.xpLine1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpLine1.AutoScrollMargin")));
			this.xpLine1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpLine1.AutoScrollMinSize")));
			this.xpLine1.BackColor = System.Drawing.Color.Transparent;
			this.xpLine1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpLine1.BackgroundImage")));
			this.xpLine1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpLine1.Dock")));
			this.xpLine1.Enabled = ((bool)(resources.GetObject("xpLine1.Enabled")));
			this.xpLine1.Font = ((System.Drawing.Font)(resources.GetObject("xpLine1.Font")));
			this.xpLine1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.xpLine1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpLine1.ImeMode")));
			this.xpLine1.LineColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpLine1.Location = ((System.Drawing.Point)(resources.GetObject("xpLine1.Location")));
			this.xpLine1.Name = "xpLine1";
			this.xpLine1.Orientation = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.xpLine1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpLine1.RightToLeft")));
			this.xpLine1.Size = ((System.Drawing.Size)(resources.GetObject("xpLine1.Size")));
			this.xpLine1.TabIndex = ((int)(resources.GetObject("xpLine1.TabIndex")));
			this.xpLine1.Visible = ((bool)(resources.GetObject("xpLine1.Visible")));
			// 
			// pbWait
			// 
			this.pbWait.AccessibleDescription = resources.GetString("pbWait.AccessibleDescription");
			this.pbWait.AccessibleName = resources.GetString("pbWait.AccessibleName");
			this.pbWait.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbWait.Anchor")));
			this.pbWait.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.pbWait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWait.BackgroundImage")));
			this.pbWait.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbWait.Dock")));
			this.pbWait.Enabled = ((bool)(resources.GetObject("pbWait.Enabled")));
			this.pbWait.Font = ((System.Drawing.Font)(resources.GetObject("pbWait.Font")));
			this.pbWait.Image = ((System.Drawing.Image)(resources.GetObject("pbWait.Image")));
			this.pbWait.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbWait.ImeMode")));
			this.pbWait.Location = ((System.Drawing.Point)(resources.GetObject("pbWait.Location")));
			this.pbWait.Name = "pbWait";
			this.pbWait.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbWait.RightToLeft")));
			this.pbWait.Size = ((System.Drawing.Size)(resources.GetObject("pbWait.Size")));
			this.pbWait.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbWait.SizeMode")));
			this.pbWait.TabIndex = ((int)(resources.GetObject("pbWait.TabIndex")));
			this.pbWait.TabStop = false;
			this.pbWait.Text = resources.GetString("pbWait.Text");
			this.pbWait.Visible = ((bool)(resources.GetObject("pbWait.Visible")));
			// 
			// lbOp
			// 
			this.lbOp.AccessibleDescription = resources.GetString("lbOp.AccessibleDescription");
			this.lbOp.AccessibleName = resources.GetString("lbOp.AccessibleName");
			this.lbOp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbOp.Anchor")));
			this.lbOp.AutoSize = ((bool)(resources.GetObject("lbOp.AutoSize")));
			this.lbOp.BackColor = System.Drawing.Color.Transparent;
			this.lbOp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbOp.Dock")));
			this.lbOp.Enabled = ((bool)(resources.GetObject("lbOp.Enabled")));
			this.lbOp.Font = ((System.Drawing.Font)(resources.GetObject("lbOp.Font")));
			this.lbOp.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbOp.Image = ((System.Drawing.Image)(resources.GetObject("lbOp.Image")));
			this.lbOp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbOp.ImageAlign")));
			this.lbOp.ImageIndex = ((int)(resources.GetObject("lbOp.ImageIndex")));
			this.lbOp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbOp.ImeMode")));
			this.lbOp.Location = ((System.Drawing.Point)(resources.GetObject("lbOp.Location")));
			this.lbOp.Name = "lbOp";
			this.lbOp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbOp.RightToLeft")));
			this.lbOp.Size = ((System.Drawing.Size)(resources.GetObject("lbOp.Size")));
			this.lbOp.TabIndex = ((int)(resources.GetObject("lbOp.TabIndex")));
			this.lbOp.Text = resources.GetString("lbOp.Text");
			this.lbOp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbOp.TextAlign")));
			this.lbOp.Visible = ((bool)(resources.GetObject("lbOp.Visible")));
			// 
			// lnProg2
			// 
			this.lnProg2.AccessibleDescription = resources.GetString("lnProg2.AccessibleDescription");
			this.lnProg2.AccessibleName = resources.GetString("lnProg2.AccessibleName");
			this.lnProg2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lnProg2.Anchor")));
			this.lnProg2.AutoScroll = ((bool)(resources.GetObject("lnProg2.AutoScroll")));
			this.lnProg2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("lnProg2.AutoScrollMargin")));
			this.lnProg2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("lnProg2.AutoScrollMinSize")));
			this.lnProg2.BackColor = System.Drawing.Color.Transparent;
			this.lnProg2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnProg2.BackgroundImage")));
			this.lnProg2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lnProg2.Dock")));
			this.lnProg2.Enabled = ((bool)(resources.GetObject("lnProg2.Enabled")));
			this.lnProg2.Font = ((System.Drawing.Font)(resources.GetObject("lnProg2.Font")));
			this.lnProg2.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lnProg2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lnProg2.ImeMode")));
			this.lnProg2.LineColor = System.Drawing.SystemColors.InactiveCaption;
			this.lnProg2.Location = ((System.Drawing.Point)(resources.GetObject("lnProg2.Location")));
			this.lnProg2.Name = "lnProg2";
			this.lnProg2.Orientation = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.lnProg2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lnProg2.RightToLeft")));
			this.lnProg2.Size = ((System.Drawing.Size)(resources.GetObject("lnProg2.Size")));
			this.lnProg2.TabIndex = ((int)(resources.GetObject("lnProg2.TabIndex")));
			this.lnProg2.Visible = ((bool)(resources.GetObject("lnProg2.Visible")));
			// 
			// lbPercent
			// 
			this.lbPercent.AccessibleDescription = resources.GetString("lbPercent.AccessibleDescription");
			this.lbPercent.AccessibleName = resources.GetString("lbPercent.AccessibleName");
			this.lbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbPercent.Anchor")));
			this.lbPercent.AutoSize = ((bool)(resources.GetObject("lbPercent.AutoSize")));
			this.lbPercent.BackColor = System.Drawing.Color.Transparent;
			this.lbPercent.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbPercent.Dock")));
			this.lbPercent.Enabled = ((bool)(resources.GetObject("lbPercent.Enabled")));
			this.lbPercent.Font = ((System.Drawing.Font)(resources.GetObject("lbPercent.Font")));
			this.lbPercent.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lbPercent.Image = ((System.Drawing.Image)(resources.GetObject("lbPercent.Image")));
			this.lbPercent.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPercent.ImageAlign")));
			this.lbPercent.ImageIndex = ((int)(resources.GetObject("lbPercent.ImageIndex")));
			this.lbPercent.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbPercent.ImeMode")));
			this.lbPercent.Location = ((System.Drawing.Point)(resources.GetObject("lbPercent.Location")));
			this.lbPercent.Name = "lbPercent";
			this.lbPercent.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbPercent.RightToLeft")));
			this.lbPercent.Size = ((System.Drawing.Size)(resources.GetObject("lbPercent.Size")));
			this.lbPercent.TabIndex = ((int)(resources.GetObject("lbPercent.TabIndex")));
			this.lbPercent.Text = resources.GetString("lbPercent.Text");
			this.lbPercent.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbPercent.TextAlign")));
			this.lbPercent.Visible = ((bool)(resources.GetObject("lbPercent.Visible")));
			// 
			// lnProg
			// 
			this.lnProg.AccessibleDescription = resources.GetString("lnProg.AccessibleDescription");
			this.lnProg.AccessibleName = resources.GetString("lnProg.AccessibleName");
			this.lnProg.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lnProg.Anchor")));
			this.lnProg.AutoScroll = ((bool)(resources.GetObject("lnProg.AutoScroll")));
			this.lnProg.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("lnProg.AutoScrollMargin")));
			this.lnProg.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("lnProg.AutoScrollMinSize")));
			this.lnProg.BackColor = System.Drawing.Color.Transparent;
			this.lnProg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lnProg.BackgroundImage")));
			this.lnProg.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lnProg.Dock")));
			this.lnProg.Enabled = ((bool)(resources.GetObject("lnProg.Enabled")));
			this.lnProg.Font = ((System.Drawing.Font)(resources.GetObject("lnProg.Font")));
			this.lnProg.ForeColor = System.Drawing.SystemColors.Highlight;
			this.lnProg.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lnProg.ImeMode")));
			this.lnProg.LineColor = System.Drawing.SystemColors.InactiveCaption;
			this.lnProg.Location = ((System.Drawing.Point)(resources.GetObject("lnProg.Location")));
			this.lnProg.Name = "lnProg";
			this.lnProg.Orientation = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
			this.lnProg.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lnProg.RightToLeft")));
			this.lnProg.Size = ((System.Drawing.Size)(resources.GetObject("lnProg.Size")));
			this.lnProg.TabIndex = ((int)(resources.GetObject("lnProg.TabIndex")));
			this.lnProg.Visible = ((bool)(resources.GetObject("lnProg.Visible")));
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.Text = resources.GetString("pb.Text");
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			// 
			// sfd
			// 
			this.sfd.Filter = resources.GetString("sfd.Filter");
			this.sfd.Title = resources.GetString("sfd.Title");
			// 
			// MainForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.lv);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.myleftSandDock);
			this.Controls.Add(this.myrightSandDock);
			this.Controls.Add(this.mybottomSandDock);
			this.Controls.Add(this.mytopSandDock);
			this.Controls.Add(this.leftSandBarDock);
			this.Controls.Add(this.rightSandBarDock);
			this.Controls.Add(this.mybottomSandBarDock);
			this.Controls.Add(this.topSandBarDock);
			this.Controls.Add(this.sb);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "MainForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Closing += new System.ComponentModel.CancelEventHandler(this.ClosingForm);
			this.Load += new System.EventHandler(this.LoadForm);
			this.topSandBarDock.ResumeLayout(false);
			this.myleftSandDock.ResumeLayout(false);
			this.dcResource.ResumeLayout(false);
			this.myrightSandDock.ResumeLayout(false);
			this.dcPreview.ResumeLayout(false);
			this.dcFilter.ResumeLayout(false);
			this.xpGradientPanel1.ResumeLayout(false);
			this.dcAction.ResumeLayout(false);
			this.xpGradientPanel2.ResumeLayout(false);
			this.mybottomSandDock.ResumeLayout(false);
			this.dcPlugin.ResumeLayout(false);
			this.sb.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		static string[] pargs;
		/// <summary>
		/// Der Haupteinstiegspunkt für die Anwendung.
		/// </summary>
		[STAThread]
		static void Main(string[] args) 
		{
			try 
			{
				pargs = args;
				//Application.EnableVisualStyles();
				Application.DoEvents();				

				Commandline.ImportOldData();				
				
				if (!Commandline.Start(args))  
				{
					Helper.WindowsRegistry.UpdateSimPEDirectory();
					Application.Run(new MainForm());
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("SimPE will shutdown due to an unhandled Exception.", ex);
			}
		}

		#region Custom Attributes
		LoadedPackage package;
		TreeBuilder treebuilder;
		ViewFilter filter;
		TreeNodeTag lastusedtnt;
		PluginManager plugger;
		ResourceLoader resloader;		
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
			ShowNewFile();
			UpdateProviders();			
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
			UpdateProviders();
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
			ShowNewFile();
		}

		/// <summary>
		/// Thsi Method displays the content of a File
		/// </summary>
		void UpdateFileInfo()
		{
			if (package.Loaded) Text = "SimPe - "+package.FileName;
			UpdateMenuItems();
		}

		/// <summary>
		/// This Method displays the content of a File
		/// </summary>
		void ShowNewFile()
		{
			plugger.ChangedGuiResourceEventHandler(this, new SimPe.Events.ResourceEventArgs(package));
			tvInstance.Nodes.Clear();
			tvGroup.Nodes.Clear();
			tvType.Nodes.Clear();
			treebuilder.ClearListView(lv);

			SetupActiveResourceView();	
			package.UpdateRecentFileMenu(this.miRecent);			

			UpdateFileInfo();
		}

		/// <summary>
		/// Update the old Provider Infrastructure
		/// </summary>
		void UpdateProviders()
		{
			if (Helper.IsNeighborhoodFile(package.FileName) && (Helper.WindowsRegistry.LoadMetaInfo))
			{
				FileTable.ProviderRegistry.SimNameProvider.BaseFolder = System.IO.Path.GetDirectoryName(package.FileName)+"\\Characters";
				FileTable.ProviderRegistry.SimFamilynameProvider.BasePackage = package.Package;
				FileTable.ProviderRegistry.SimDescriptionProvider.BasePackage = package.Package;
			} 
			else 
			{
				FileTable.ProviderRegistry.SimNameProvider.BaseFolder = "";
				FileTable.ProviderRegistry.SimFamilynameProvider.BasePackage = null;
				FileTable.ProviderRegistry.SimDescriptionProvider.BasePackage = null;
			}
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
			FileTable.ThemeManager.AddControl(this.sdm);			
			FileTable.ThemeManager.AddControl(this.sbm);
			FileTable.ThemeManager.AddControl(this.tbResource);
			FileTable.ThemeManager.AddControl(this.splitter1);
			FileTable.ThemeManager.AddControl(this.xpGradientPanel1);
			FileTable.ThemeManager.AddControl(this.xpGradientPanel2);
			FileTable.ThemeManager.AddControl(this.xpGradientPanel3);
		}

		void ChangedTheme(GuiTheme gt)
		{
			FileTable.ThemeManager.CurrentTheme = gt;
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

			Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = false;
			Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = true;
			Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = false;
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

			if (Helper.WindowsRegistry.Layout.SandBarLayout!="") sbm.SetLayout(Helper.WindowsRegistry.Layout.SandBarLayout);
			if (Helper.WindowsRegistry.Layout.SandDockLayout!="") sdm.SetLayout(Helper.WindowsRegistry.Layout.SandDockLayout);

			
			/*this.tbDefaultAction.IsExpanded = Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded;			
			this.tbPlugAction.IsExpanded = Helper.WindowsRegistry.Layout.PluginActionBoxExpanded;
			this.tbExtAction.IsExpanded = Helper.WindowsRegistry.Layout.ToolActionBoxExpanded;*/
			

			UpdateDockMenus();
		}
		#endregion

		#region Menu Handling
		/// <summary>
		/// this will create all needed Dock MenuItems to Display a hidden Dock
		/// </summary>
		void AddDockMenus()
		{
			TD.SandDock.DockControl[] ctrls = sdm.GetDockControls();
			bool first = true;
			bool firsttool = true;
			foreach (TD.SandDock.DockControl c in ctrls) 
			{
				TD.SandBar.MenuButtonItem mi = new TD.SandBar.MenuButtonItem(c.Text);
				mi.BeginGroup = first;
				mi.Image = c.TabImage;
				mi.Checked = c.IsInContainer || c.IsFloating;

				mi.Activate += new EventHandler(Activate_miWindowDocks);
				mi.Tag = c;

				if (c.Tag != null) 
				{
					mi.BeginGroup = firsttool;
					firsttool = false;
					if (c.Tag is System.Windows.Forms.Shortcut) mi.Shortcut = (System.Windows.Forms.Shortcut)c.Tag;
				}

				c.Closed += new EventHandler(CloseDockControl);
				c.Tag = mi;

				miWindow.Items.Add(mi);

				
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
					mi.Checked = c.IsInContainer || c.IsFloating;
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
						c.Open();
						mi.Checked = c.IsOpen;
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
			
			tbAction.Visible = false;
			this.dcPlugin.Open();
		}

		/// <summary>
		/// Called whenever we need to set the enabled state of a MenuItem
		/// </summary>
		void UpdateMenuItems()
		{
			this.miSave.Enabled = System.IO.File.Exists(package.FileName);
			this.miSaveAs.Enabled = package.Loaded;
			this.miClose.Enabled = package.Loaded;
		}
		#endregion

		#region ResourceView Toolbar
		/// <summary>
		/// Setup the Buttons on the ToolBar to connect to the TreeView
		/// </summary>
		void SetupResourceViewToolBar()
		{
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

			SetupActiveResourceView();
		}

		/// <summary>
		/// Display the content of the current package in the choosen TreeView
		/// </summary>
		void SetupActiveResourceView()
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
							tbl.Generate();							
							if (tbl.TreeView.Nodes.Count>0) lastusedtnt = (TreeNodeTag)tbl.TreeView.Nodes[0].Tag;							
						}
						this.SelectResourceNode(tbl.TreeView, new TreeViewEventArgs(tbl.TreeView.SelectedNode, TreeViewAction.ByMouse));
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
				for (int i=0; i<a.Length; i++) res[i] = a.GetValue(i).ToString().ToLower();
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
			dcFilter.LayoutSystem.Collapsed = true;
			dcPreview.LayoutSystem.Collapsed = true;

			if (!Helper.WindowsRegistry.HiddenMode) 
			{
				lv.Columns.RemoveAt(lv.Columns.Count-1);
				lv.Columns.RemoveAt(lv.Columns.Count-1);
			}	
		
			ReloadLayout();	
		
			if (Helper.WindowsRegistry.CheckForUpdates) About.ShowUpdate(false);

			//load Files passed on the commandline
			package.LoadOrImportFiles(pargs, true);
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
		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e">null to indicate, that his Method was called internal, and should NOT open a Resource!</param>
		private void SelectResource(object sender, System.EventArgs e)
		{			
			SelectResource(sender, false, false);
		}

		private void Activate_miUpdate(object sender, System.EventArgs e)
		{
			About.ShowUpdate(true);
		}

		private void Activate_miAbout(object sender, System.EventArgs e)
		{
			About.ShowAbout();
		}

		private void dc_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button==MouseButtons.Middle && Helper.WindowsRegistry.FirefoxTabbing && dc.ActiveDocument!=null) 
			{
				resloader.CloseDocument(dc.ActiveDocument);
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
				foreach (ListViewItem lvi in lv.Items) lvi.Selected = true;
				lv.Tag = null;
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
			for (int i=0; i<lv.SelectedItems.Count; i++)
			{
				ListViewTag lvt = (ListViewTag)lv.SelectedItems[i].Tag;
				res.Items.Add(new SimPe.Events.ResourceContainer(lvt.Resource));

				if (!fromdbl && !Helper.WindowsRegistry.SimpleResourceSelect && !frommiddle) continue;

				//only the first one get's added to the Plugin View				
				if ((lv.SelectedItems.Count==1 && !fromchg && lv.Tag==null)) resloader.AddResource(lvt.Resource, !fm);
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

			System.Drawing.Icon icon = null;
			if (miPref.Image is System.Drawing.Bitmap)
				icon = System.Drawing.Icon.FromHandle(((System.Drawing.Bitmap)miPref.Image).GetHicon());

			of.Execute(icon);
		}

		private void ClosingForm(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = !resloader.Clear();
			if (!e.Cancel) 
			{
				Ambertation.Panel3D.StopAll();
				Helper.WindowsRegistry.Layout.SandBarLayout = sbm.GetLayout(true);
				Helper.WindowsRegistry.Layout.SandDockLayout = sdm.GetLayout();
				Helper.WindowsRegistry.Layout.PluginActionBoxExpanded = this.tbPlugAction.IsExpanded;
				Helper.WindowsRegistry.Layout.DefaultActionBoxExpanded = this.tbDefaultAction.IsExpanded;
				Helper.WindowsRegistry.Layout.ToolActionBoxExpanded = this.tbExtAction.IsExpanded;
			}
		}

		

		private void ClosedToolPlugin(object sender, PackageArg pk)
		{
			try 
			{
				if (pk.Result.ChangedPackage) package.LoadFromPackage((SimPe.Packages.GeneratableFile)pk.Package);	
				if (pk.Result.ChangedFile) resloader.AddResource(new SimPe.Plugin.FileIndexItem(pk.FileDescriptor, pk.Package), true);															
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		
		private void CreateNewDocumentContainer(object sender, System.EventArgs e)
		{
			TD.SandDock.DockControl doc = new TD.SandDock.DockControl();
			doc.Text = "Plugin";
						
			doc.Manager = sdm;			
			//doc.PerformDock(dcPlugin.LayoutSystem);
			doc.Float();
			doc.Closing +=new CancelEventHandler(CloseAdditionalDocContainer);
			doc.TabImage = dcPlugin.TabImage;
			doc.Text = dcPlugin.Text;
			doc.TabText = dcPlugin.TabText;
			

			TD.SandDock.DocumentContainer dc = new TD.SandDock.DocumentContainer();
			dc.Manager = this.dc.Manager;
			dc.Text = "Plugin";
			dc.Parent = doc;
			dc.Dock = DockStyle.Fill;
			
		}

		private void CloseAdditionalDocContainer(object sender, CancelEventArgs e)
		{
			if (sender is TD.SandDock.DockControl) 
			{
				TD.SandDock.DockControl doc = (TD.SandDock.DockControl)sender;
				if (doc.Controls[0] is TD.SandDock.DocumentContainer) 
				{
					TD.SandDock.DocumentContainer dc = (TD.SandDock.DocumentContainer)doc.Controls[0];
					bool closed = true;
					for (int i=dc.Documents.Length-1; i>=0; i--) 
					{						
						TD.SandDock.DockControl d = dc.Documents[i];
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
				package.Save(sfd.FileName);
			}
		}

		private void Activate_miClose(object sender, System.EventArgs e)
		{
			if (ClosePackage())
			{
				SimPe.Packages.StreamFactory.CloseAll();
				this.ShowNewFile();
			}							
		}

		private void SelectResourceDBClick(object sender, System.EventArgs e)
		{			
			SelectResource(sender, true, false);
		}				

		
		private void SortResourceListClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if (((ListView)sender).ListViewItemSorter == null) 
			{
				ColumnSorter sorter = new ColumnSorter();
				sorter.CurrentColumn = 0;
				((ListView)sender).ListViewItemSorter = sorter;
			}

			((ColumnSorter)((ListView)sender).ListViewItemSorter).CurrentColumn = e.Column;
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
	}
			
}
