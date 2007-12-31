/***************************************************************************
 *   Copyright (C) 2007 Peter L Jones                                      *
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

namespace SimPe.Plugin
{
    public partial class JobDescPanel : UserControl
    {
        public JobDescPanel()
        {
            InitializeComponent();
        }

        public string TitleLabel { get { return lbTitle.Text; } set { lbTitle.Text = value; } }
        public string TitleValue { get { return tbTitle.Text; } set { tbTitle.Text = value; } }

        public string DescLabel { get { return lbDesc.Text; } set { lbDesc.Text = value; } }
        public string DescValue { get { return tbDesc.Text; } set { tbDesc.Text = value; } }

        public Size DescSize
        {
            get { return tbDesc.Size; }
            set
            {
                tbDesc.Size = value;
                tbTitle.Width = tbDesc.Width;
            }
        }

        /// <summary>
        /// Raised when the Title text box value changes
        /// </summary>
        public event EventHandler TitleValueChanged;
        public virtual void OnTitleValueChanged(object sender, EventArgs e)
        {
            if (TitleValueChanged != null)
            {
                TitleValueChanged(sender, e);
            }
        }
        private void tbTitle_TextChanged(object sender, EventArgs e)
        {
            OnTitleValueChanged(sender, e);
        }

        /// <summary>
        /// Raised when the Desc text box value changes
        /// </summary>
        public event EventHandler DescValueChanged;
        public virtual void OnDescValueChanged(object sender, EventArgs e)
        {
            if (DescValueChanged != null)
            {
                DescValueChanged(sender, e);
            }
        }
        private void tbDesc_TextChanged(object sender, EventArgs e)
        {
            OnDescValueChanged(sender, e);
        }
    }
}
