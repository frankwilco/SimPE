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
        private void SetupMainForm()
        {
            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Creating GUI"));
            if (Helper.DebugMode)
            {
                ToolStripButton tbDebug = new ToolStripButton();
                tbDebug.Text = "Debug docks";
                toolBar1.Items.Add(tbDebug);
                tbDebug.Click += new EventHandler(tbDebug_Click);
            }
            manager.Visible = false;
            tbContainer.Visible = false;
            createdmenus = false;
            
            Wait.Bar = this.waitControl1;

            
            package = new LoadedPackage();
            package.BeforeFileLoad += new PackageFileLoadEvent(BeforeFileLoad);
            package.AfterFileLoad += new PackageFileLoadedEvent(AfterFileLoad);
            package.BeforeFileSave += new PackageFileSaveEvent(BeforeFileSave);
            package.AfterFileSave += new PackageFileSavedEvent(AfterFileSave);
            package.IndexChanged += new EventHandler(ChangedActiveIndex);
            //package.AddedResource += new EventHandler(AddedRemovedIndexResource);
            //package.RemovedResource += new EventHandler(AddedRemovedIndexResource);

            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Building View Filter"));
            filter = new ViewFilter();
            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Starting Resource Loader"));
            resloader = new ResourceLoader(dc, package);
            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Enabling RemoteControl"));
            remote = new RemoteHandler(this, package, resloader, miWindow);

            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Loading Plugins..."));
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
                dockBottom,
                this.mbiTopics,
                lv
            );
            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Loaded Plugins"));
            plugger.ClosedToolPlugin += new ToolMenuItemExt.ExternalToolNotify(ClosedToolPlugin);
            remote.SetPlugger(plugger);

            remote.LoadedResource += new ChangedResourceEvent(rh_LoadedResource);
            
            package.UpdateRecentFileMenu(this.miRecent);

            InitTheme();

            dockBottom.Height = ((this.Height * 3) / 4);
            this.Text += " (Version " + Helper.SimPeVersion.ProductVersion + ")";
            
            TD.SandDock.SandDockManager sdm2 = new TD.SandDock.SandDockManager();
            sdm2.OwnerForm = this;
            ThemeManager.Global.AddControl(sdm2);

            this.dc.Manager = sdm2;            


            InitMenuItems();
            this.dcPlugin.Open();
            Ambertation.Windows.Forms.ToolStripRuntimeDesigner.Add(tbContainer);
            Ambertation.Windows.Forms.ToolStripRuntimeDesigner.LineUpToolBars(tbContainer);
            this.menuBar1.ContextMenuStrip = tbContainer.TopToolStripPanel.ContextMenuStrip;

            Ambertation.Windows.Forms.Serializer.Global.Register(tbContainer);
            Ambertation.Windows.Forms.Serializer.Global.Register(manager);

            manager.NoCleanup = false;
            manager.ForceCleanUp();
            //this.dcResource.BringToFront();
            //this.dcResourceList.BringToFront();
            lv.Filter = filter;

            waitControl1.ShowProgress = false;
            waitControl1.Progress = 0;
            waitControl1.Message = "";
            waitControl1.Visible = Helper.WindowsRegistry.ShowWaitBarPermanent;
        }        

        void LoadForm(object sender, System.EventArgs e)
        {
            SimPe.Splash.Screen.SetMessage(SimPe.Localization.GetString("Starting Main Form"));

            this.SuspendLayout();

            dcFilter.Collapse(false);

            cbsemig.Items.Add("[Group Filter]");
            cbsemig.Items.Add(new SimPe.Data.SemiGlobalAlias(true, 0x7FD46CD0, "Globals"));
            cbsemig.Items.Add(new SimPe.Data.SemiGlobalAlias(true, 0x7FE59FD0, "Behaviour"));
            foreach (Data.SemiGlobalAlias sga in Data.MetaData.SemiGlobals)
                if (sga.Known) this.cbsemig.Items.Add(sga);
            if (cbsemig.Items.Count > 0) cbsemig.SelectedIndex = 0;

            if (!System.IO.File.Exists(SimPe.Helper.DataFolder.SimPeLayout))
                ResetLayout(this, null);
            else
                ReloadLayout();

            //Set the Lock State of the Docks
            MakeFloatable(!Helper.WindowsRegistry.LockDocks);

            manager.Visible = true;
            tbContainer.Visible = true;

            this.ResumeLayout();

            SimPe.Splash.Screen.Stop();

            if (Helper.WindowsRegistry.PreviousVersion == 0)
                About.ShowWelcome();

            if (Helper.WindowsRegistry.CheckForUpdates)
                About.ShowUpdate();
        }
    }
}
