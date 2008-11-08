/***************************************************************************
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   peter@users.sf.net                                                    *
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
using System.Text;

namespace SimPe.Actions.Default
{
    class ActionGroupFilter : AbstractActionDefault
    {
        private SimPe.Windows.Forms.ResourceListViewExt lv = null;
        private ViewFilter Filter { get { return (ViewFilter)((lv == null) ? null : lv.Filter); } }
        public ActionGroupFilter(SimPe.Windows.Forms.ResourceListViewExt value) { lv = value; }

        public override bool ChangeEnabledStateEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
        {
            bool res = base.ChangeEnabledStateEventHandler(sender, es);
            return (Filter != null && Filter.FilterGroup) || (res && es.Count == 1);
        }

        public override void ExecuteEventHandler(object sender, SimPe.Events.ResourceEventArgs es)
        {
            if (!ChangeEnabledStateEventHandler(sender, es)) return;

            if (Filter != null && Filter.FilterGroup)
            {
                Filter.FilterGroup = false;
            }
            else
            {
                Filter.Group = es.GetDescriptors()[0].Group;
                Filter.FilterGroup = true;
            }
        }

        public override string ToString()
        {
            return Localization.GetString("GroupFilterSet");
        }

        /*public override System.Drawing.Image Icon
        {
            get
            {
                return System.Drawing.Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("[.png"));
            }
        }*/

        public override System.Windows.Forms.Shortcut Shortcut
        {
            get
            {
                return System.Windows.Forms.Shortcut.CtrlT; // for "Toggle"...
            }
        }
    }
}
