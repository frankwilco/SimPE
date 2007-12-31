/***************************************************************************
 *   Copyright (C) 2007 by Ambertation                                     *
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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Interfaces
{
    public partial class AFinderTool : UserControl
    {
        IFinderResultGui rgui;
        SimPe.ThemeManager tm;
        public AFinderTool() : this(null) { }

        protected AFinderTool(IFinderResultGui rgui) : base()
        {
            this.rgui = rgui;
            InitializeComponent();
            tm = ThemeManager.Global.CreateChild();
            tm.AddControl(this.grp);
            
            btStart.Enabled = rgui!=null;
        }

        protected SimPe.ThemeManager ThemeManager
        {
            get { return tm; }
        }

        

        /// <summary>
        /// The Title of this Control
        /// </summary>
        [System.ComponentModel.Localizable(true)]
        public string Title{
            get { return grp.HeaderText; }
            set { grp.HeaderText = value; }
        }


        /// <summary>
        /// This provides acces to the result GUI, enabeling you to start a search, or add a result to the result list
        /// </summary>
        protected IFinderResultGui ResultGui
        {
            get { return rgui; }            
        }

        internal void SetResultGui(IFinderResultGui gui)
        {
            rgui = gui;
            btStart.Enabled = rgui != null;
        }

        /// <summary>
        /// The control returned here should contain all parameters that control the search.
        /// </summary>
        public System.Windows.Forms.Control SearchGui { 
            get { return this; }            
        }


            

        /// <summary>
        /// This is the search routine
        /// </summary>
        /// <param name="pkg">The package that is going to get searched</param>
        public void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg)
        {
            foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Index)
            {
                if (ResultGui.ForcedStop) return;
                SearchPackage(pkg, pfd);
            }
        }

        /// <summary>
        /// This is the search routine
        /// </summary>
        /// <param name="fiis">List of resources to search</param>
        public void SearchPackage(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] fiis)
        {
            foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii in fiis)
            {
                if (ResultGui.ForcedStop) return;
                SearchPackage(fii.Package, fii.FileDescriptor);
            }
        }

        /// <summary>
        /// This is the search routine
        /// </summary>
        /// <param name="fii">Resources to search</param>
        public void SearchPackage(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
        {
            SearchPackage(fii.Package, fii.FileDescriptor);
        }

        /// <summary>
        /// True if multiple packages can be searched at once
        /// </summary>
        public virtual bool ProcessParalell { get { return true; } }    

        /// <summary>
        /// This is the search routine you have to implement
        /// </summary>
        /// <param name="pkg">The package that is going to get searched</param>
        /// <param name="pfd">The resource within the package that is to be searched</param>
        public virtual void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd){
        }

        protected virtual bool OnPrepareStart() { return true;  }

        private void btStart_Click(object sender, EventArgs e)
        {
            if (!ResultGui.Searching)
            {
                if (OnPrepareStart())
                {
                    btStart.Text = SimPe.Localization.GetString("Stop");
                    btStart.Tag = true;
                    ResultGui.StartSearch(this);
                }
            }
            else ResultGui.StopSearch();
        }

        public override string ToString()
        {
            return Title;
        }

        internal void NotifyFinishedSearch(){
            btStart.Text = SimPe.Localization.GetString("Start");
            btStart.Tag = null;

            System.Diagnostics.Debug.WriteLine("Notified search finish");
        }
    }
    
}
