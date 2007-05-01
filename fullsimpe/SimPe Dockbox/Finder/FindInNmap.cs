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

namespace SimPe.Plugin.Tool.Dockable.Finder
{
    public partial class FindInNmap : FindInStr
    {
        public FindInNmap(SimPe.Interfaces.IFinderResultGui rgui)
            :base(rgui)
        {
            InitializeComponent();
        }

        public FindInNmap() : this(null) { }

        public override bool ProcessParalell
        {
            get
            {
                return false;
            }
        }

        public override void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
        {
            if (pfd.Type != Data.MetaData.NAME_MAP) return;
            SimPe.Plugin.Nmap nmap = new Nmap(FileTable.ProviderRegistry);
            nmap.ProcessData(pfd, pkg);

            //check all stored nMap entries for a match
            foreach (SimPe.Interfaces.Files.IPackedFileDescriptor mypfd in nmap.Items)
            {
                bool found = false;
                string n = mypfd.Filename.Trim().ToLower();
                if (compareType == CompareType.Equal)
                {
                    found = n == name;
                }
                else if (compareType == CompareType.Start)
                {
                    found = n.StartsWith(name);
                }
                else if (compareType == CompareType.End)
                {
                    found = n.EndsWith(name);
                }
                else if (compareType == CompareType.Contain)
                {
                    found = n.IndexOf(name) > -1;
                }
                else if (compareType == CompareType.RegExp && reg != null)
                {
                    found = reg.IsMatch(n);
                }

                //we have a match, so add the result item
                if (found)
                {
                    SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem[] rfiis =
                        FileTable.FileIndex.FindFileDiscardingHighInstance(
                        pfd.Instance,
                        mypfd.Group,
                        mypfd.Instance,
                        null);

                    foreach (SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem rfii in rfiis)                    
                        ResultGui.AddResult(rfii.Package, rfii.FileDescriptor);                    
                }
            }


         
        }
    
    }
}
