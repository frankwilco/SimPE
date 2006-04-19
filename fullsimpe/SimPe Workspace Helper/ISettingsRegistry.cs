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
	/// Zusammenfassung für ISettingsRegistry.
	/// </summary>
	public interface ISettingsRegistry
	{		
		/// <summary>
		/// Registers Settings to the Registry
		/// </summary>
		/// <param name="settings">The Topic to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void RegisterSettings(SimPe.Interfaces.ISettings settings);	
	
		/// <summary>
		/// Registers all listed Settings with this Registry
		/// </summary>
		/// <param name="settings">The Topics to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void RegisterSettings(SimPe.Interfaces.ISettings[] settings);

		/// <summary>
		/// Registers all  Settings provided by a factory with this Registry
		/// </summary>
		/// <param name="factory">The providing Factory to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void Register(Plugin.ISettingsFactory factory);

		
		/// <summary>
		/// Returns the List of Known Settings
		/// </summary>
		ISettings[] Settings
		{
			get;
		}		
	}
}
