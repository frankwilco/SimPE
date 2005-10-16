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
using System.Windows.Forms;
using System.Drawing;
using SimPe.Events;

namespace SimPe.Interfaces
{
	/// <summary>
	/// defines a Listener
	/// </summary>
	public interface IListener : IToolPlugin
	{
		/// <summary>
		/// This EventHandler will be connected to the ChangeResource Event of the Caller, you can set 
		/// the Enabled State here
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		/// <returns>
		/// Should allways return true for listeners. 
		/// Tools displayed in a Menu or ActionList, should only return true, when they are
		/// enabled for the passed Selection and package
		/// </returns>
		void SelectionChangedHandler(object sender, SimPe.Events.ResourceEventArgs e);				
	}
}

namespace SimPe.Collections 
{
	public class Listeners : System.Collections.IEnumerable
	{
		protected System.Collections.ArrayList list;
		protected Listeners()
		{
			list = new System.Collections.ArrayList();
		}		

		public bool Contains(SimPe.Interfaces.IListener lst)
		{
			return list.Contains(lst);
		}

		/// <summary>
		/// Integer Indexer
		/// </summary>
		public SimPe.Interfaces.IListener this[int index]
		{
			get { return ((SimPe.Interfaces.IListener)list[index]); }
			set { list[index] = value; }
		}

		/// <summary>
		/// unsigned Integer Indexer
		/// </summary>
		public SimPe.Interfaces.IListener this[uint index]
		{
			get { return ((SimPe.Interfaces.IListener)list[(int)index]); }
			set { list[(int)index] = value; }
		}		

		#region IEnumerable Member

		public System.Collections.IEnumerator GetEnumerator()
		{
			return list.GetEnumerator();
		}

		#endregion
	}
}
