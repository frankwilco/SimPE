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

namespace SimPe.Updates
{
    /// <summary>
    /// Update availability state
    /// </summary>
    public enum UpdateStates : byte
    {
        Nothing = 0,
        NewRelease = 1,
        NewQARelease = 2,
        BothNew = 3
    }

    public class UpdateState : IEnumerable<UpdateInfo>
    {
        static List<IUpdatablePlugin> ulist;
        public static void SetUpdatablePluginList(List<IUpdatablePlugin> list)
        {
            ulist = list;
        }

        UpdateInfoList list;
        UpdateStates state;
        public UpdateStates SimPeState
        {
            get { return state; }
        }
       

        internal UpdateState(UpdateStates t)
        {
            state = t;
            list = new UpdateInfoList();
        }

        internal void AddSimPeState(UpdateStates t)
        {
            state |= t;
        }

        public void Discard()
        {
            state = UpdateStates.Nothing;
        }

        internal void CheckPluginUpdates(string content)
        {
            list.Clear();
            if (ulist==null) return;
            foreach (IUpdatablePlugin up in ulist)
            {
                UpdateInfo ui = up.GetUpdateInformation();
                list.Add(ui);
            }
        }

        

        #region IEnumerable<UpdateInfo> Member

        public IEnumerator<UpdateInfo> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion

        #region IEnumerable Member

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        #endregion
    }
}
