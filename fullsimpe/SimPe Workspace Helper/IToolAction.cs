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
	/// defines a Action Plugin
	/// </summary>
	public interface IToolAction : IToolPlugin, IToolExt
	{
		/// <summary>
		/// This Eventhandler will be connected to the ExecuteAction Event of the Caller, you should
		/// perform the Action here. You can notify the caller of Changes when setting the apropriate 
		/// Attributes in e
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ExecuteEventHandler(object sender, ResourceEventArgs e);

		/// <summary>
		/// This EventHandler will be connected to the ChangeResource Event of the Caller, you can set 
		/// the Enabled State here
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		bool ChangeEnabledStateEventHandler(object sender, ResourceEventArgs e);		
	}
}
