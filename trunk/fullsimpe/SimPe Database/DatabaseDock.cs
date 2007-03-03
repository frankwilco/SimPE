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
using System.Text;
using System.Windows.Forms;

namespace SimPe.Database
{
    public partial class DatabaseDock : Ambertation.Windows.Forms.DockPanel, SimPe.Interfaces.IDockableTool
    {
        Database db;
        public DatabaseDock()
        {
            InitializeComponent();
            db = new Database();
        }       

        #region IDockableTool Member

        public Ambertation.Windows.Forms.DockPanel GetDockableControl()
        {
            return this;
        }

        public void RefreshDock(object sender, SimPe.Events.ResourceEventArgs e)
        {
            
        }

        public event SimPe.Events.ChangedResourceEvent ShowNewResource;

        #endregion

        #region IToolExt Member

        public Image Icon
        {
            get { return this.TabImage; }
        }

        public Shortcut Shortcut
        {
            get { return Shortcut.None; }
        }

        #endregion

        void Init()
        {
            ArrayList dirs = FileTable.DefaultFolders;
            Wait.Start();
            Wait.Message = "Sync. Database Cache...";
            foreach (SimPe.FileTableItem s in dirs)
            {
                //lb.Items.Add(s);
                //db.FileItemChanged(s);
            }
            //DatabaseSyncThread.WaitForFinish();
            Wait.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Init();
        }
    }
}
