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
using Ambertation.Windows.Forms;

namespace SimPe.Interfaces
{	
	/// <summary>
	/// defines an Object that can be put into Dock of the Main Form
	/// </summary>
	public interface IDockableTool : IToolPlugin, IToolExt
	{
		/// <summary>
		/// Fired, when a new Resource should be displayed
		/// </summary>
		event ChangedResourceEvent ShowNewResource;

		/// <summary>
		/// Starts the Tool Window
		/// </summary>
		/// <param name="package">The currently opened Package</param>
		/// <param name="pfd">The currently selected File</param>
		/// <returns>true, if the package was changed</returns>
		DockPanel GetDockableControl();

		/// <summary>
		/// This EventHandler will be connected to the ChangeResource Event of the Caller, you can set 
		/// the Enabled State here
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void RefreshDock(object sender, ResourceEventArgs e);				
	}
}
