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
    public partial class FindInStr : SimPe.Interfaces.AFinderTool
    {
        public enum CompareType { Unknown = -1, Equal = 0, Start = 1, End = 2, Contain = 3, RegExp = 4 }
        public FindInStr(SimPe.Interfaces.IFinderResultGui rgui)
            :base(rgui)
        {
            InitializeComponent();

            cbType.SelectedIndex = 3;
            reg = null;
            name = "";
            compareType = CompareType.Unknown;
        }

        public FindInStr() : this(null) {}

        protected System.Text.RegularExpressions.Regex reg;
        protected string name;
        protected CompareType compareType;
        protected override bool OnPrepareStart()
        {
            compareType = (CompareType)cbType.SelectedIndex;
            name = this.tbMatch.Text.Trim().ToLower();
            reg = null;

            if (compareType == CompareType.Unknown || name == "") return false;
            
            try
            {
                reg = new System.Text.RegularExpressions.Regex(this.tbMatch.Text, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            }
            catch (Exception ex)
            {
                if (this.cbType.SelectedIndex == 4)
                    Helper.ExceptionMessage(ex);
            }

            return true;
        }

        public override void SearchPackage(SimPe.Interfaces.Files.IPackageFile pkg, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
        {
            if (pfd.Type != Data.MetaData.STRING_FILE && pfd.Type!=Data.MetaData.CTSS_FILE) return;            

            SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();            
            str.ProcessData(pfd, pkg);

            SimPe.PackedFiles.Wrapper.StrItemList sitems = str.Items;
            //check all stored nMap entries for a match
            foreach (SimPe.PackedFiles.Wrapper.StrToken item in sitems)
            {
                bool found = false;
                string n = item.Title.Trim().ToLower();
                if (compareType == CompareType.Equal)
                {
                    found = n == name;
                }
                else if (compareType ==  CompareType.Start)
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
                    ResultGui.AddResult(pkg, pfd);
                    break;
                }
            }		
        }
    }
}
