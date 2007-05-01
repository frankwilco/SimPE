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
    partial class ScoreItemBusinessRewards
    {
        public class Element
        {
            string name;
            byte[] data;

            public Element()
            {
                name = "";
                data = BitConverter.GetBytes((int)0x00000103);
            }

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            internal byte[] Data
            {
                get { return data; }
            }

            public void LoadData(System.IO.BinaryReader reader)
            {
                name = StreamHelper.ReadString(reader);
                data = ScorItem.UnserializeDefaultToken(reader);
            }

            public void SaveData(System.IO.BinaryWriter writer, bool last)
            {
                StreamHelper.WriteString(writer, name);
                writer.Write(data);
                ScorItem.SerializeDefaultToken(writer, last);
            }

            public override string ToString()
            {
                string s = name + ": " + Helper.BytesToHexList(data);
                return s;
            }
        }
    }
}
