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
        
        /// <summary>
        /// Add one Dock to the List
        /// </summary>
        /// <param name="c"></param>
        /// <param name="first"></param>
        void AddDockItem(Ambertation.Windows.Forms.DockPanel c, bool first)
        {
            ToolStripMenuItem mi = new ToolStripMenuItem(c.Text);
            if (first) miWindow.DropDownItems.Add("-");
            mi.Image = c.TabImage;            

            mi.Click += new EventHandler(Activate_miWindowDocks);
            mi.Tag = c;
            mi.Checked = c.IsOpen;

            if (c.Tag != null)
                if (c.Tag is System.Windows.Forms.Shortcut)
                    mi.ShortcutKeys = Helper.ToKeys((System.Windows.Forms.Shortcut)c.Tag);

            c.VisibleChanged += new EventHandler(CloseDockControl);
            c.Closed += new EventHandler(CloseDockControl);
            c.Tag = mi;

            miWindow.DropDownItems.Add(mi);
        }

        /// <summary>
        /// this will create all needed Dock MenuItems to Display a hidden Dock
        /// </summary>
        void AddDockMenus()
        {
            System.Collections.Generic.List<Ambertation.Windows.Forms.DockPanel> ctrls = manager.GetPanels();

            bool first = true;
            foreach (Ambertation.Windows.Forms.DockPanel c in ctrls)
            {
                if (c.Tag != null) continue;
                System.Diagnostics.Debug.WriteLine("##1# "+c.ButtonText);
                AddDockItem(c, first);
                first = false;
            }

            first = true;
            foreach (Ambertation.Windows.Forms.DockPanel c in ctrls)
            {
                if (c.Tag == null) continue;
                if (c.Tag is ToolStripMenuItem) continue;
                System.Diagnostics.Debug.WriteLine("##2# " + c.ButtonText);
                AddDockItem(c, first);
                first = false;
            }
        }

        /// <summary>
        /// this will update the Checked State of a Dock menu Item
        /// </summary>
        void UpdateDockMenus()
        {
            foreach (object o in miWindow.DropDownItems)
            {
                ToolStripMenuItem mi = o as ToolStripMenuItem;
                if (mi == null) continue;
                if (mi.Tag is Ambertation.Windows.Forms.DockPanel)
                {
                    Ambertation.Windows.Forms.DockPanel c = (Ambertation.Windows.Forms.DockPanel)mi.Tag;
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
            if (sender is Ambertation.Windows.Forms.DockPanel)
            {
                Ambertation.Windows.Forms.DockPanel c = (Ambertation.Windows.Forms.DockPanel)sender;
                if (c.Tag is ToolStripMenuItem)
                {
                    ToolStripMenuItem mi = (ToolStripMenuItem)c.Tag;
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
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem mi = (ToolStripMenuItem)sender;

                if (mi.Tag is Ambertation.Windows.Forms.DockPanel)
                {
                    Ambertation.Windows.Forms.DockPanel c = (Ambertation.Windows.Forms.DockPanel)mi.Tag;
                    if (mi.Checked)
                    {
                        c.Close();
                        mi.Checked = c.IsOpen;
                    }
                    else
                    {
                        c.Open();
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
            SimPe.LoadFileWrappersExt.BuildToolBar(tbWindow, miWindow.DropDownItems, exclude);
            this.dcPlugin.Open();
        }

        bool createdmenus;
        /// <summary>
        /// Called whenever we need to set the enabled state of a MenuItem
        /// </summary>
        void UpdateMenuItems()
        {
            this.miSave.Enabled = System.IO.File.Exists(package.FileName);
            this.miSaveCopyAs.Enabled = this.miSave.Enabled;
            this.miSaveAs.Enabled = package.Loaded;
            this.miClose.Enabled = package.Loaded;

            if (!createdmenus)
            {
                foreach (ExpansionItem ei in PathProvider.Global.Expansions)
                {
                    if (ei.Flag.Class != ExpansionItem.Classes.BaseGame)
                    {
                        ToolStripMenuItem mi = new ToolStripMenuItem();
                        mi.Text = SimPe.Localization.GetString("OpenInCaption").Replace("{where}", ei.Expansion.ToString());
                        mi.Tag = ei;
                        mi.Click += new EventHandler(this.Activate_miOpenInEp);
                        mi.Enabled = ei.Exists;

                        this.miOpenIn.DropDownItems.Insert(miOpenIn.DropDownItems.Count - 1, mi);
                    }
                }
                createdmenus = true;
            }
        }
    }
}
