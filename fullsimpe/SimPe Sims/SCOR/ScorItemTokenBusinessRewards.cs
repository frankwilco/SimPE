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
    class ScorItemTokenBusinessRewards : IScorItemToken
    {
        ScoreItemBusinessRewards gui;
        public ScorItemTokenBusinessRewards()
        {
            gui = null;
        }
        public byte[] UnserializeToken(ScorItem si, System.IO.BinaryReader reader)
        {
            byte[] data = ScorItem.UnserializeDefaultToken(reader);       
            int ct = BitConverter.ToInt16(data, 0);

            gui = new ScoreItemBusinessRewards(si);
            for (int i = 0; i < ct; i++)
            {
                ScoreItemBusinessRewards.Element item = new ScoreItemBusinessRewards.Element();
                item.LoadData(reader);
                gui.AddElement(item);
            }
            
            return data;
        }

        public SCOR.AScorItem ActivatedGUI
        {
            get { return gui; }
        }
    }
}
