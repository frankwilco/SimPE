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
    public class MyButtonItem : ToolStripButton
    {
        static int counter = 0;

        #region Layout stuff
        public static void GetLayoutInformations(Control b)
        {
            ArrayList list = Helper.WindowsRegistry.Layout.VisibleToolbarButtons;
            GetLayoutInformations(b, list);
        }

        static void GetLayoutInformations(Control b, ArrayList list)
        {
            foreach (Control c in b.Controls)
                GetLayoutInformations(c, list);

            ToolStrip tb = b as ToolStrip;
            if (tb != null)
            {
                foreach (object o in tb.Items)
                {
                    MyButtonItem mbi = o as MyButtonItem;
                    if (mbi != null)
                        //if (!mbi.HaveDock)
                        mbi.Visible = list.Contains(mbi.Name);
                }
            }

        }

        public static void SetLayoutInformations(Control b)
        {
            ArrayList list = new ArrayList();
            SetLayoutInformations(b, list);

            Helper.WindowsRegistry.Layout.VisibleToolbarButtons = list;
        }

        static void SetLayoutInformations(Control b, ArrayList list)
        {
            foreach (Control c in b.Controls)
                SetLayoutInformations(c, list);

            ToolStrip tb = b as ToolStrip;
            if (tb != null)
            {
                foreach (object o in tb.Items)
                {
                    MyButtonItem mbi = o as MyButtonItem;
                    if (mbi != null)
                        if (mbi.Visible /*&& !mbi.HaveDock*/)
                            list.Add(mbi.Name);
                }
            }

        }
        #endregion
        static int namect = 0;
        string name;
        public new string Name
        {
            get { return name; }
        }

        bool havedock;
        public bool HaveDock
        {
            get { return havedock; }
        }

        public MyButtonItem(string name)
            : this(null, name) { }

        internal MyButtonItem(ToolStripMenuItem item)
            : this(item, null) { }

        ToolStripMenuItem refitem;
        MyButtonItem(ToolStripMenuItem item, string name)
            : base()
        {
            if (name == "")
            {
                name = "AButtonItem_" + namect;
                namect++;
            }

            refitem = item;
            if (item != null)
            {
                this.Image = item.Image;
                this.Visible = (item.Image != null);
                if (this.Image == null) this.Text = item.Text;
                this.ToolTipText = item.Text.Replace("&", "");
                this.Enabled = item.Enabled;
                this.Click += new EventHandler(MyButtonItem_Activate);
                item.CheckedChanged += new EventHandler(item_CheckedChanged);
                item.EnabledChanged += new EventHandler(item_EnabledChanged);

                this.ToolTipText = item.Text;
                this.Enabled = item.Enabled;
                this.Checked = item.Checked;

                havedock = false;
                ToolMenuItemExt tmie = item as ToolMenuItemExt;
                if (tmie != null) this.name = tmie.Name;
                else
                {
                    Ambertation.Windows.Forms.DockPanel dw = item.Tag as Ambertation.Windows.Forms.DockPanel;

                    if (dw != null)
                    {
                        this.name = dw.Name;
                        havedock = true;
                    }
                    else this.name = "Button_" + (counter++);
                }
            }
            else
            {
                havedock = false;
                this.name = name;
            }



        }

        void item_EnabledChanged(object sender, EventArgs e)
        {
            this.Enabled = ((ToolStripMenuItem)sender).Enabled;
        }

        void item_CheckedChanged(object sender, EventArgs e)
        {
            this.Checked = ((ToolStripMenuItem)sender).Checked;
        }

        void MyButtonItem_Activate(object sender, EventArgs e)
        {
            refitem.PerformClick();
        }
    }
}
