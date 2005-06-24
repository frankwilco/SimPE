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
		System.Windows.Forms.Control GetDockableControl();

		/// <summary>
		/// Called, when the DockPanel needs to be Refreshed (i.e. new content)
		/// </summary>
		/// <param name="guipackage">Represents the package currently opened in the 
		/// GUI, you can use the included Methods to open a new Package in the Main GUI</param>
		/// <param name="item">The opened Resource Item (can be null)</param>
		void RefreshDock(LoadedPackage guipackage, SimPe.Interfaces.Scenegraph.IScenegraphFileIndex item);

		/// <summary>
		/// Returns true if the Menu Item can be enabled
		/// </summary>
		/// <param name="item">The opened Resource Item (can be null)</param>
		/// <returns>true if this tool is avaliable</returns>
		bool IsEnabled(SimPe.Interfaces.Scenegraph.IScenegraphFileIndex item);			
	}
}
