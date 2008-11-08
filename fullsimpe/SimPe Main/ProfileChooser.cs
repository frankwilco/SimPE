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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SimPe
{
    public partial class ProfileChooser : Form
    {
        public ProfileChooser()
        {
            InitializeComponent();
        }

        public string Value
        {
            get
            {
                return cbProfiles.Text;
            }
        }

        private void ProfileChooser_Activated(object sender, EventArgs e)
        {
            cbProfiles.BeginUpdate();
            cbProfiles.Items.Clear();
            foreach (string s in Directory.GetDirectories(SimPe.Helper.DataFolder.Profiles))
                cbProfiles.Items.Add(Path.GetFileName(s));
            cbProfiles.EndUpdate();
        }

        private void ProfileChooser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.UserClosing && e.CloseReason != CloseReason.None) return;
            if (this.DialogResult != DialogResult.OK) return;

            string path = Path.Combine(Helper.DataFolder.Profiles, cbProfiles.Text);
            if (!Directory.Exists(path))
            {/* // Removed at Inge's request
                if (MessageBox.Show(
                    Localization.GetString("spOKCancelCreate")
                    , Localization.GetString("spCreate")
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK) e.Cancel = true;
                else
              */
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Localization.GetString("spCreate"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (MessageBox.Show(
                Localization.GetString("spOKCancelExists")
                , Localization.GetString("spExists")
                , MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.OK) e.Cancel = true;
        }
    }
}