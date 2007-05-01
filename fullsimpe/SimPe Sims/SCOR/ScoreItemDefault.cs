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
using System.Text;

namespace SimPe.PackedFiles.Wrapper.SCOR
{
    public partial class ScoreItemDefault : AScorItem
    {

        public ScoreItemDefault(ScorItem si)
            : base(si)
        {
            InitializeComponent();
            data = new byte[0];
        }

        protected override void DoSetData(string name, System.IO.BinaryReader reader)
        {
            textBox1.Text = name;
            data = reader.ReadBytes((int)reader.BaseStream.Length);

            tb.Text = Helper.BytesToHexList(data, 4);
        }

        byte[] data;
        internal override void Serialize(System.IO.BinaryWriter writer, bool last)
        {
            base.Serialize(writer, last);
            writer.Write(data);
        }
    }
}
