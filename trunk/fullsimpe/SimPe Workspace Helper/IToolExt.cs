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

namespace SimPe.Interfaces
{
	/// <summary>
	/// Defines extended properties for the <see cref="ITool"/> Interface.
	/// </summary>
	public interface IToolExt : IToolPlugin 
	{
		/// <summary>
		/// Returns null or the Icon that should be dispalyed for this Menu Item (can be null)
		/// </summary>
		/// <returns></returns>
		System.Drawing.Image Icon
		{
			get;
		}

		/// <summary>
		/// Returns the wanted Shortcut
		/// </summary>
		System.Windows.Forms.Shortcut Shortcut
		{
			get;
		}

		/// <summary>
		/// Returns true if the Tool is curently visible on the GUI
		/// </summary>
		bool Visible{
			get;
		}
	}
}
