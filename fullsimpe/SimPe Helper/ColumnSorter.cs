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
using System.Collections;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// ListView Column Sorter
	/// </summary>
	public class  ColumnSorter : IComparer
	{
		/// <summary>
		/// The Currently active Column
		/// </summary>
		public int CurrentColumn = 0;

		/// <summary>
		/// The Sort Order
		/// </summary>
		public SortOrder Sorting = SortOrder.Ascending;

		/// <summary>
		/// The Compare Function to use
		/// </summary>
		/// <param name="x">fisrt ListViewItem</param>
		/// <param name="y">second ListViewItem</param>
		/// <returns>0 if the ListViewItem match</returns>
		public int Compare(object x, object y)
		{
			ListViewItem rowA = (ListViewItem)x;
			ListViewItem rowB = (ListViewItem)y;

			if (Sorting==SortOrder.Ascending) 
			{
				return String.Compare(rowA.SubItems[CurrentColumn].Text,
					rowB.SubItems[CurrentColumn].Text);
			} 
			else 
			{
				return String.Compare(rowB.SubItems[CurrentColumn].Text,
					rowA.SubItems[CurrentColumn].Text);
			}

		}


		

	}
}
