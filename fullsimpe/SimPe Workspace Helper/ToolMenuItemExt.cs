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
using System.Reflection;
using System.Collections;
using System.IO;
using SimPe.Interfaces;
using SimPe.Interfaces.Plugin;
using SimPe.Events;
using System.Windows.Forms;

namespace SimPe
{
    public class ToolMenuItemExt : ToolStripMenuItem
    {
        /// <summary>
        /// Those delegates can be called when a Tool want's to notify the Host Application
        /// </summary>
        public delegate void ExternalToolNotify(object sender, PackageArg pk);
        IToolPlugin tool;


        /// <summary>
        /// Return null, or the stored extended Tool
        /// </summary>
        public IToolExt ToolExt
        {
            get
            {
                //if (tool.GetType().GetInterface("SimPe.Interfaces.IToolExt", true) == typeof(SimPe.Interfaces.IToolExt)) return (SimPe.Interfaces.IToolExt)tool;
                if (tool is SimPe.Interfaces.IToolExt) return (SimPe.Interfaces.IToolExt)tool;
                else return null;
            }
        }

        /// <summary>
        /// Return null, or the stored  Tool
        /// </summary>
        public ITool Tool
        {
            get
            {
                if (tool is SimPe.Interfaces.ITool) return (SimPe.Interfaces.ITool)tool;
                else return null;
            }
        }

        /// <summary>
        /// Return null, or the stored ToolPlus Item
        /// </summary>
        public IToolPlus ToolPlus
        {
            get
            {
                if (tool is SimPe.Interfaces.IToolPlus) return (SimPe.Interfaces.IToolPlus)tool;
                else return null;
            }
        }
        Interfaces.Files.IPackedFileDescriptor pfd;
        Interfaces.Files.IPackageFile package;
        /// <summary>
        /// null or a Function to call when the Pacakge was changed by a Tool Plugin
        /// </summary>
        ExternalToolNotify chghandler;

        ExternalToolNotify ChangeHandler
        {
            get { return chghandler; }
            set { chghandler = value; }
        }

        string name;
        public string Name
        {
            get { return name; }
        }
        public ToolMenuItemExt(IToolPlus tool, ExternalToolNotify chghnd)
            : this(tool.ToString(), tool, chghnd)
        {
        }

        public ToolMenuItemExt(string text, IToolPlugin tool, ExternalToolNotify chghnd)
        {
            this.tool = tool;
            this.Text = text;
            this.ToolTipText = text;
            Checked = false;
            Click += new EventHandler(LinkClicked);
            Click += new EventHandler(ClickItem);
            chghandler = chghnd;

            name = tool.GetType().Namespace + "." + tool.GetType().Name;
        }

        private void ClickItem(object sender, System.EventArgs e)
        {
            if (Tool == null) return;
            try
            {
                if (Tool.IsEnabled(pfd, package))
                {
                    SimPe.Interfaces.Plugin.IToolResult tr = Tool.ShowDialog(ref pfd, ref package);
                    WaitingScreen.Stop();
                    if (tr.ChangedAny)
                    {
                        PackageArg p = new PackageArg();
                        p.Package = package;
                        p.FileDescriptor = pfd;
                        p.Result = tr;
                        if (chghandler != null) chghandler(this, p);
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("Unable to Start ToolPlugin.", ex);
            }
        }

        #region Event Handler
        SimPe.Events.ResourceEventArgs lasteventarg;

        /// <summary>
        /// Fired when a Resource was changed by a ToolPlugin and the Enabled state needs to be changed
        /// </summary>
        internal void ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs e)
        {
            this.Package = AbstractToolPlus.ExtractPackage(e);
            this.FileDescriptor = AbstractToolPlus.ExtractFileDescriptor(e);

            if (Tool != null)
            {
                UpdateEnabledState();
            }
            else if (ToolPlus != null)
            {
                lasteventarg = e;
                this.Enabled = ToolPlus.ChangeEnabledStateEventHandler(sender, e);
            }
        }

        /// <summary>
        /// Fired when a Link is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LinkClicked(object sender, EventArgs e)
        {
            if (ToolPlus == null) return;
            if (lasteventarg.LoadedPackage != null) lasteventarg.LoadedPackage.PauseIndexChangedEvents();
            ToolPlus.Execute(sender, lasteventarg);
            if (lasteventarg.LoadedPackage != null) lasteventarg.LoadedPackage.RestartIndexChangedEvents();
        }
        #endregion

        public override string ToString()
        {
            try
            {
                return tool.ToString();
            }
            catch (Exception ex)
            {
                Helper.ExceptionMessage("Unable to Load ToolPlugin.", ex);
            }

            return "Plugin Error";
        }

        public Interfaces.Files.IPackedFileDescriptor FileDescriptor
        {
            get { return pfd; }
            set { pfd = value; }
        }

        public Interfaces.Files.IPackageFile Package
        {
            get { return package; }
            set { package = value; }
        }

        void UpdateEnabledState()
        {
            try
            {
                Enabled = Tool.IsEnabled(pfd, package);
            }
            catch (Exception)
            {
                Enabled = false;
            }
        }
    }
}
