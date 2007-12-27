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
    public partial class LabelledNumericUpDown : UserControl
    {
        public LabelledNumericUpDown()
        {
            InitializeComponent();
            lbLabel.Visible = !noLabel;
        }

        public FlowDirection FlowDirection
        {
            get { return flpMain.FlowDirection; }
            set { flpMain.FlowDirection = value; }
        }

        /// <summary>
        /// Hides the label
        /// </summary>
        private bool noLabel = false;
        public bool NoLabel
        {
            get { return noLabel; }
            set
            {
                if (noLabel != value)
                {
                    noLabel = value;
                    if (noLabel)
                        flpMain.Controls.Remove(lbLabel);
                    else
                    {
                        flpMain.Controls.Add(lbLabel);
                        flpMain.Controls.SetChildIndex(lbLabel, 0);
                    }
                }
            }
        }

        public String Label
        {
            get { return lbLabel.Text; }
            set { lbLabel.Text = value; }
        }

        public AnchorStyles LabelAnchor
        {
            get { return lbLabel.Anchor; }
            set { lbLabel.Anchor = value; }
        }

        public decimal Value
        {
            get { return nudValue.Value; }
            set { nudValue.Value = value; }
        }

        public Size ValueSize
        {
            get { return nudValue.Size; }
            set { nudValue.Size = value; }
        }

        public bool ReadOnly { get { return nudValue.ReadOnly; } set { nudValue.ReadOnly = value; } }

        public decimal Maximum
        {
            get { return nudValue.Maximum; }
            set { nudValue.Maximum = value; }
        }

        public decimal Minimum
        {
            get { return nudValue.Minimum; }
            set { nudValue.Minimum = value; }
        }

        /// <summary>
        /// Raised when the Value changes
        /// </summary>
        public event EventHandler ValueChanged;
        public virtual void OnValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(sender, e);
            }
        }
        private void nudValue_ValueChanged(object sender, EventArgs e)
        {
            OnValueChanged(this, e);
        }
    }
}
