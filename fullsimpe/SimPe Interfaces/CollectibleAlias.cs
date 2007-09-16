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
using System.Collections.Generic;
using System.Text;

namespace SimPe.Providers
{
    public class CollectibleAlias
    {
        private string name;
        public string Name
        {
            get { return name; }
        }

        private ulong id;
        public ulong Id
        {
            get { return id; }
        }

        private int nr;
        public int Nr
        {
            get { return nr; }
        }

        private System.Drawing.Image img;
        public System.Drawing.Image Image
        {
            get { return img; }
        }


        public CollectibleAlias(ulong id, int nr, string name, System.Drawing.Image img)
        {
            this.id = id;
            this.nr = nr;
            this.name = name;
            if (img == null)
            {
                img = new System.Drawing.Bitmap(32, 32);
            }
            this.img = img;
        }

        public override string ToString()
        {
#if DEBUG
            return name + " (0x" + Helper.HexString(id) + ", " + nr + ")";
#else
            return name;
#endif
        }
    }
}
