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
	/// The  Interface for a Help Topic
	/// </summary>
	public interface IHelp
	{		
		/// <remarks>
		/// This is explicit listed in the Interface description, as you should return a String (best would be Name)
		/// that identifies the Topic. This will resemble the Menuname
		/// </remarks>
		/// <summary>Returns a short describing String</summary>
		/// <returns>A Describing String for the Wrapper</returns>
		string ToString();	

		/// <summary>
		/// a 16x16 Image, that is displayed as an Icon for the Help Topic (by defualt this is a questionmark)
		/// </summary>
		/// <returns>null for the derfault, or a custom Image</returns>
		System.Drawing.Image Icon
		{
			get;
		}

		/// <summary>
		/// Executed, when the User decided to show the Help
		/// </summary>
		/// <param name="e">Currently, this does not provide any data</param>
		void ShowHelp(ShowHelpEventArgs e);
	}

	
}
