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
	/// The Basic Interface for ToolPlugins (dockable (<see cref="SimPe.Interfaces.IDockableTool"/>) or not (<see cref="SimPe.Interfaces.ITool"/>))
	/// </summary>
	public interface IToolPlugin 
	{		
		/// <remarks>
		/// This is explicit listed in the Interface description, as you should return a String (best would be Name)
		/// that identifies the Wrapper
		/// </remarks>
		/// <summary>Returns a short describing String</summary>
		/// <returns>A Describing String for the Wrapper</returns>
		string ToString();	
	}

	/// <summary>
	/// defines an Object that can be put into a Registry
	/// </summary>
	public interface ITool : IToolPlugin
	{
		/// <summary>
		/// Starts the Tool Window
		/// </summary>
		/// <param name="package">The currently opened Package</param>
		/// <param name="pfd">The currently selected File</param>
		/// <returns>true, if the package was changed</returns>
		Plugin.IToolResult ShowDialog(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package);

		/// <summary>
		/// Returns true if the Menu Item can be enabled
		/// </summary>
		/// <param name="pfd">Descriptor for the currently selected File or null if none</param>
		/// <param name="package">The opened Package or null if none</param>
		/// <returns>true if this tool is avaliable</returns>
		bool IsEnabled(Interfaces.Files.IPackedFileDescriptor pfd ,Interfaces.Files.IPackageFile package);
	}

	/// <summary>
	/// defines a Action Plugin with the new Interface
	/// </summary>
	public interface IToolPlus: IToolExt
	{
		/// <summary>
		/// This Eventhandler will be connected to the ExecuteAction Event of the Caller, you should
		/// perform the Action here. You can notify the caller of Changes when setting the apropriate 
		/// Attributes in e
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void Execute(object sender, ResourceEventArgs e);

		/// <summary>
		/// This EventHandler will be connected to the ChangeResource Event of the Caller, you can set 
		/// the Enabled State here
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		bool ChangeEnabledStateEventHandler(object sender, ResourceEventArgs e);		
	}
}
