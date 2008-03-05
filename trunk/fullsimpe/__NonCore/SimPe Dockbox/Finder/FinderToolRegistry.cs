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

namespace SimPe.Plugin.Tool.Dockable.Finder
{
    public sealed class FinderToolRegistry
    {
        
        static FinderToolRegistry glb = null;
        public static FinderToolRegistry Global
        {
            get
            {
                if (glb == null) glb = new FinderToolRegistry();
                return glb;
            }
        }

        List<Type> list;
        private FinderToolRegistry()
        {
            list = new List<Type>();
            map = new Dictionary<SimPe.Interfaces.IFinderResultGui, SimPe.Interfaces.AFinderTool[]>();

            Add(typeof(FindObj));
            Add(typeof(FindInNmap));
            Add(typeof(FindInStr));
            Add(typeof(FindInCpf));
            Add(typeof(FindTGI));
            Add(typeof(FindInNref));
            Add(typeof(FindInSG));
        }

        public void Add(Type tool)
        {
            list.Add(tool);
        }

        Dictionary<SimPe.Interfaces.IFinderResultGui, SimPe.Interfaces.AFinderTool[]> map;
        public SimPe.Interfaces.AFinderTool[] CreateToolInstances(SimPe.Interfaces.IFinderResultGui gui)
        {
            if (map.ContainsKey(gui)) return map[gui];

            SimPe.Interfaces.AFinderTool[] ret = new SimPe.Interfaces.AFinderTool[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                ret[i] = System.Activator.CreateInstance(list[i], new object[] { gui }) as SimPe.Interfaces.AFinderTool;  
            }

            map[gui] = ret;
            return ret;
        }
    }
}
