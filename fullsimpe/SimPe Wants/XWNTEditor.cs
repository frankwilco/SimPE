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
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;

namespace SimPe.Wants
{
    public partial class XWNTEditor : Form, IPackedFileUI
    {
        public XWNTEditor()
        {
            InitializeComponent();
            cbVersion.Items.AddRange(XWNTWrapper.ValidVersions.ToArray());
            cbProperty.Items.AddRange(XWNTItem.ValidKeys.ToArray());
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (setHandler && wrapper != null)
            {
                //wrapper.FileDescriptor.DescriptionChanged -= new EventHandler(FileDescriptor_DescriptionChanged);
                wrapper.WrapperChanged -= new System.EventHandler(this.WrapperChanged);
                setHandler = false;
            }
            wrapper = null;
        }

        #region XWNTEditor
        private XWNTWrapper wrapper = null;
        private bool setHandler = false;
        private bool internalchg;

        private void setCbValue(List<string> validValues, string value)
        {
            cbValue.Items.Clear();
            cbValue.Items.AddRange(validValues.ToArray());
            cbValue.SelectedIndex = validValues.IndexOf(value);
            cbValue.Visible = true;
            tbValue.Visible = false;
        }

        private void setTbValue(string value)
        {
            tbValue.Text = value;
            tbValue.Visible = true;
            cbValue.Visible = false;
        }

        private void setEdit(XWNTItem xi)
        {
            internalchg = true;
            try
            {
                cbProperty.SelectedIndex = XWNTItem.ValidKeys.IndexOf(xi.Key);
                switch (xi.Key)
                {
                    case "integerOperator": setCbValue(XWNTItem.ValidIntegerOperators, xi.Value); break;
                    case "integerType": setCbValue(XWNTItem.ValidIntegerTypes, xi.Value); break;
                    case "level": setCbValue(XWNTItem.ValidLevels, xi.Value); break;
                    case "objectType": setCbValue(XWNTItem.ValidObjectTypes, xi.Value); break;
                    default:
                        switch (xi.Stype)
                        {
                            case "AnyBoolean": setCbValue(new List<string>(new string[] { Boolean.FalseString, Boolean.TrueString, }), xi.Value); break;
                            default: setTbValue(xi.Value); break;
                        }
                        break;
                }
            }
            finally { internalchg = false; }
        }

        private void setLbWant()
        {
            string s = "";
            if (wrapper["folder"] != null) s += (s.Length > 0 ? " " : "") + wrapper["folder"].Value;
            if (wrapper["nodeText"] != null) s += (s.Length > 0 ? " / " : "") + wrapper["nodeText"].Value;
            if (wrapper["objectType"] != null) s += (s.Length > 0 ? " " : "") + "(" + wrapper["objectType"].Value + ")";
            lbWant.Text = s;
        }
        #endregion

        #region IPackedFileUI Members

        public Control GUIHandle { get { return pnXWNTEditor; } }

        public void UpdateGUI(IFileWrapper wrp)
        {
            wrapper = (XWNTWrapper)wrp;
            WrapperChanged(wrapper, null);

            internalchg = true;

            lbWant.Text = wrapper["folder"].Value + " / " + wrapper["nodeText"].Value + " (" + wrapper["objectType"].Value + ")";
            cbVersion.SelectedIndex = XWNTWrapper.ValidVersions.IndexOf(wrapper.Version);

            lvWants.Items.Clear();
            foreach (XWNTItem xi in wrapper)
                if (!xi.Key.StartsWith("<")) lvWants.Items.Add(new ListViewItem(new string[] { xi.Key, xi.Stype, xi.Value, }));

            internalchg = false;

            if (lvWants.Items.Count > 0)
                lvWants.Items[0].Selected = true;
            else
                lvWants_SelectedIndexChanged(null, null);

            if (!setHandler)
            {
                wrapper.WrapperChanged += new System.EventHandler(this.WrapperChanged);
                setHandler = true;
            }
        }

        private void WrapperChanged(object sender, System.EventArgs e)
        {
            this.btnCommit.Enabled = wrapper.Changed;

            if (internalchg) return;
            internalchg = true;
            try
            {
                if (sender.Equals(wrapper))
                {
                }
                else
                {
                    List<string> keys = new List<string>(new string[]{"folder","nodeText","objectType",});
                    XWNTItem xi = (XWNTItem)sender;
                    if (keys.Contains(xi.Key))
                        setLbWant();
                }
            }
            finally { internalchg = false; }
        }
        #endregion

        private void btnCommit_Click(object sender, EventArgs e)
        {
            wrapper.SynchronizeUserData();
            btnCommit.Enabled = wrapper.Changed;
        }

        private void cbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            wrapper.Version = XWNTWrapper.ValidVersions[cbVersion.SelectedIndex];
        }

        private void lvWants_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            internalchg = true;
            try
            {
                if (lvWants.SelectedItems.Count == 0)
                {
                    tbValue.Visible = cbProperty.Enabled = tbValue.Enabled = cbValue.Enabled = btnDelete.Enabled = false;
                    cbValue.Visible = true;
                    cbValue.SelectedIndex = cbProperty.SelectedIndex = -1;
                }
                else
                {
                    cbProperty.Enabled = tbValue.Enabled = cbValue.Enabled = btnDelete.Enabled = true;
                    setEdit(wrapper[lvWants.SelectedItems[0].Text]);
                }
            }
            finally { internalchg = false; }
        }

        private void cbProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (cbProperty.SelectedIndex == -1) return;

            XWNTItem xi = wrapper[lvWants.SelectedItems[0].Text];
            string key = XWNTItem.ValidKeys[cbProperty.SelectedIndex];

            // Disallow duplicate keys
            if (wrapper[key] != null)
            {
                internalchg = true;
                cbProperty.SelectedIndex = XWNTItem.ValidKeys.IndexOf(xi.Key);
                internalchg = false;
                return;
            }

            lvWants.SelectedItems[0].Text = xi.Key = key;

            // Initialise value to a sane value for this key
            switch (key)
            {
                case "integerOperator": setCbValue(XWNTItem.ValidIntegerOperators, XWNTItem.ValidIntegerOperators[0]); break;
                case "integerType": setCbValue(XWNTItem.ValidIntegerTypes, XWNTItem.ValidIntegerTypes[0]); break;
                case "level": setCbValue(XWNTItem.ValidLevels, XWNTItem.ValidLevels[0]); break;
                case "objectType": setCbValue(XWNTItem.ValidObjectTypes, XWNTItem.ValidObjectTypes[0]); break;
                default:
                    switch (XWNTItem.StypeForKey(XWNTItem.ValidKeys[cbProperty.SelectedIndex]))
                    {
                        case "AnyBoolean": setCbValue(new List<string>(new string[] { Boolean.FalseString, Boolean.TrueString, }), Boolean.FalseString); break;
                        case "AnyString": setTbValue(""); break;
                        default: setTbValue(XWNTItem.IsUint32Long(XWNTItem.ValidKeys[cbProperty.SelectedIndex]) ? "0x00000000" : "0"); break;
                    }
                    break;
            }
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            if (cbValue.SelectedIndex == -1) return;

            lvWants.SelectedItems[0].SubItems[2].Text = wrapper[lvWants.SelectedItems[0].Text].Value = cbValue.SelectedItem.ToString();
            lbWant.Text = wrapper["folder"].Value + " / " + wrapper["nodeText"].Value + " (" + wrapper["objectType"].Value + ")";
        }

        private void tbValue_TextChanged(object sender, EventArgs e)
        {
            if (internalchg) return;
            internalchg = true;
            XWNTItem xi = wrapper[lvWants.SelectedItems[0].Text];
            try
            {
                switch (xi.Stype)
                {
                    case "AnySint32":
                        try
                        {
                            int sint = Convert.ToInt32(tbValue.Text, tbValue.Text.Trim().ToLower().StartsWith("0x") ? 16 : 10);
                            xi.Value = sint.ToString();
                        }
                        catch { tbValue.Text = xi.Value; tbValue.SelectAll(); }
                        break;
                    case "AnyUint32":
                        try
                        {
                            uint u = Convert.ToUInt32(tbValue.Text, tbValue.Text.Trim().ToLower().StartsWith("0x") || XWNTItem.IsUint32Long(xi.Key) ? 16 : 10);
                            if (XWNTItem.IsUint32Long(xi.Key))
                                xi.Value = "0x" + u.ToString("x").PadLeft(8, '0');
                            else
                                xi.Value = u.ToString();
                        }
                        catch { tbValue.Text = xi.Value; tbValue.SelectAll(); }
                        break;
                    default:
                        xi.Value = tbValue.Text;
                        break;
                }
            }
            finally { lvWants.SelectedItems[0].SubItems[2].Text = xi.Value; internalchg = false; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int i = wrapper.Count;
            if (internalchg) return;
            internalchg = true;
            try
            {
                wrapper.Add(new XWNTItem(wrapper, XWNTItem.ValidKeys[0], ""));
                lvWants.Items.Add(new ListViewItem(new string[] { wrapper[i].Key, wrapper[i].Stype, wrapper[i].Value, }));
            }
            finally { internalchg = false; }
            lvWants.Items[i].Selected = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lvWants.SelectedIndices[0];
            if (internalchg) return;
            internalchg = true;
            try
            {
                wrapper.RemoveAt(i);
                lvWants.Items.RemoveAt(i);
            }
            finally { internalchg = false; }
            i--;
            if (i < 0 && wrapper.Count > 0) i = 0;
            lvWants.Items[i].Selected = true;
        }
    }
}