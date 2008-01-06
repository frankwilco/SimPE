/***************************************************************************
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   pljones@users.sf.net                                                  *
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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
    public partial class GUIDChooser : UserControl
    {
        public GUIDChooser()
        {
            InitializeComponent();
            internalchg = true;
            cbKnownObjects.SelectedIndex = -1;
            cbKnownObjects.Enabled = false;
            tbGUID.Text = "0x00000000";
            internalchg = false;
        }

        private bool hex32_IsValid(object sender)
        {
            try { Convert.ToUInt32(((TextBox)sender).Text, 16); }
            catch (Exception) { return false; }
            return true;
        }

        bool internalchg = false;
        UInt32 currentValue = 0;
        List<String> knownObjects = null;
        List<UInt32> knownGUIDs = null;

        public int DropDownHeight { get { return cbKnownObjects.DropDownHeight; } set { cbKnownObjects.DropDownHeight = value; } }
        public int DropDownWidth { get { return cbKnownObjects.DropDownWidth; } set { cbKnownObjects.DropDownWidth = value; } }
        public int ComboBoxWidth { get { return cbKnownObjects.Width; } set { cbKnownObjects.Width = value; } }
        public string Label { get { return lbLabel.Text; } set { lbLabel.Text = value; } }
        public UInt32 Value
        {
            get
            {
                return currentValue;
            }
            set
            {
                if (currentValue == value) return;
                setValue(value, true, true);
            }
        }

        private void setValue(UInt32 value, bool cb, bool tb)
        {
            currentValue = value;

            bool origstate = internalchg;
            internalchg = true;

            if (value == 0)
            {
                // "None"
                if (cb) cbKnownObjects.SelectedIndex = 0;
                if (tb) tbGUID.Text = "0x00000000";
            }
            else if (knownGUIDs != null && knownGUIDs.IndexOf(value) >= 0)
            {
                // Known
                if (cb) cbKnownObjects.SelectedIndex = 2 + knownGUIDs.IndexOf(value);
                if (tb) tbGUID.Text = "0x" + SimPe.Helper.HexString(value);
            }
            else
            {
                // Unknown
                if (cb) cbKnownObjects.SelectedIndex = (knownGUIDs == null) ? -1 : 1;
                if (tb) tbGUID.Text = "0x" + SimPe.Helper.HexString(value);
            }

            internalchg = origstate;

            OnGUIDChooserValueChanged(this, new EventArgs());
        }

        public object[] KnownObjects
        {
            //get { }
            set
            {
                knownObjects = new List<String>((List<String>)value[0]);
                knownObjects.Insert(0, " --None--");
                knownObjects.Insert(1, "  *Other*");
                cbKnownObjects.DataSource = knownObjects;
                cbKnownObjects.Enabled = true;
                knownGUIDs = new List<UInt32>((List<UInt32>)value[1]);
            }
        }

        public event EventHandler GUIDChooserValueChanged;
        internal virtual void OnGUIDChooserValueChanged(object sender, EventArgs e)
        {
            if (GUIDChooserValueChanged != null)
            {
                GUIDChooserValueChanged(sender, e);
            }
        }

        private void cbKnownObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;

            if (cbKnownObjects.SelectedIndex == 0) // None
                setValue(0, false, true);
            else if (cbKnownObjects.SelectedIndex > 1) // not Other
                setValue(knownGUIDs[cbKnownObjects.SelectedIndex - 2], false, true);
        }

        private void tbGUID_TextChanged(object sender, EventArgs e)
        {
            if (internalchg || !hex32_IsValid(sender)) return;

            setValue(Convert.ToUInt32(((TextBox)sender).Text, 16), true, false);
        }

        private void hex32_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (hex32_IsValid(sender)) return;

            e.Cancel = true;

            bool origstate = internalchg;
            internalchg = true;
            ((TextBox)sender).Text = "0x" + SimPe.Helper.HexString(Value);
            ((TextBox)sender).SelectAll();
            internalchg = origstate;
        }

        private void hex32_Validated(object sender, System.EventArgs e)
        {
            bool origstate = internalchg;
            internalchg = true;
            ((TextBox)sender).Text = "0x" + SimPe.Helper.HexString(Value);
            ((TextBox)sender).SelectAll();
            internalchg = origstate;
        }
    }
}
