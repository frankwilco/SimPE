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

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    public partial class ScoreItemBusinessRewards : AScorItem
    {
        
        public ScoreItemBusinessRewards(ScorItem si)
            : base(si)
        {
            InitializeComponent();          
        }

        internal void AddElement(ScoreItemBusinessRewards.Element e)
        {
            if (e==null) return;
            lb.Items.Add(e);
        }

        protected void RemoveElement(ScoreItemBusinessRewards.Element e)
        {
            if (e == null) return;
            int i = lb.SelectedIndex;
            lb.Items.Remove(e);

            if (i < lb.Items.Count) lb.SelectedIndex = i;
            else if (i-1<lb.Items.Count && i>0) lb.SelectedIndex = i-1;
        }

        protected override void DoSetData(string name, System.IO.BinaryReader reader)
        {
            throw new Exception("SetData should not get called for a Business Reward!");
        }

        internal override void Serialize(System.IO.BinaryWriter writer, bool last)
        {
            base.Serialize(writer, last);
            writer.Write((Int16)lb.Items.Count);
            writer.Write((byte)0);
            ScorItem.SerializeDefaultToken(writer, last && lb.Items.Count == 0);
            for (int i=0; i<lb.Items.Count; i++)
            {
                ScoreItemBusinessRewards.Element e = lb.Items[i] as ScoreItemBusinessRewards.Element;
                e.SaveData(writer, last && i == lb.Items.Count - 1);             
            }
        }

        private void lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            llRemove.Enabled = lb.SelectedItem != null;
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RemoveElement(lb.SelectedItem as ScoreItemBusinessRewards.Element);
        }
    }
}
