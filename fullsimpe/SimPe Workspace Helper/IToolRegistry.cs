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

namespace SimPe.Interfaces
{
	/// <summary>
	/// Zusammenfassung für IToolRegistry.
	/// </summary>
	public interface IToolRegistry
	{		
		/// <summary>
		/// Registers a Tool to the Registry
		/// </summary>
		/// <param name="tool">The Tool to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void Register(IToolPlugin tool);	
	
		/// <summary>
		/// Registers all listed Tools with this Registry
		/// </summary>
		/// <param name="tools">The Tools to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void Register(IToolPlugin[] tools);

		/// <summary>
		/// Registers all Tools supported by the Factory
		/// </summary>
		/// <param name="factory">The Factory Elements you want to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void Register(Plugin.IToolFactory factory);

		/// <summary>
		/// Return a Collection of loaded Listeners
		/// </summary>
		SimPe.Collections.Listeners Listeners 
		{
			get;
		}

		/// <summary>
		/// Returns the List of Known Tools
		/// </summary>
		/// <remarks>The Tools should be Returned in Order of Priority starting with the lowest!</remarks>
		ITool[] Tools 
		{
			get;
		}

		/// <summary>
		/// Returns the List of Known Tools
		/// </summary>
		/// <remarks>The Tools should be Returned in Order of Priority starting with the lowest!</remarks>
		IToolPlus[] ToolsPlus 
		{
			get;
		}


		/// <summary>
		/// Returns a List of Know Doackable Tools
		/// </summary>
		IDockableTool[] Docks 
		{
			get;
		}

		/// <summary>
		/// Returns a List of Know Action Tool
		/// </summary>
		IToolAction[] Actions
		{
			get;
		}
	}
}
