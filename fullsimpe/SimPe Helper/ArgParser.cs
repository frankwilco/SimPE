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
using System.Text;

namespace SimPe
{
    public class ArgParser
    {
        public static bool Parse(List<string> argv, int index, string parm, ref string result)
        {
            int i = argv.IndexOf(parm);
            if (i == index && argv.Count > i + 1)
            {
                argv.RemoveAt(i);
                result = argv[i];
                argv.RemoveAt(i);
                return true;
            }
            return false;
        }

        public static int Parse(List<string> argv, int index, List<string> parm)
        {
            if (argv.Count <= index) return -1;
            int i = parm.IndexOf(argv[index]);
            if (i > 0) argv.RemoveAt(index);
            return i;
        }

        public static int Parse(List<string> argv, string parm)
        {
            int i = argv.IndexOf(parm);
            if (i >= 0) argv.RemoveAt(i);
            return i;
        }
    }
}
