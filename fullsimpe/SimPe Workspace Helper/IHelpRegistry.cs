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
	public interface IHelpRegistry
	{		
		/// <summary>
		/// Registers a Help Topic to the Registry
		/// </summary>
		/// <param name="topic">The Topic to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void RegisterHelpTopic(SimPe.Interfaces.IHelp topic);	
	
		/// <summary>
		/// Registers all listed Help Topics with this Registry
		/// </summary>
		/// <param name="topics">The Topics to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void RegisterHelpTopic(SimPe.Interfaces.IHelp[] topics);

		/// <summary>
		/// Registers all  Help Topics provided by a factory with this Registry
		/// </summary>
		/// <param name="factory">The providing Factory to register</param>
		/// <remarks>The tool must only be added if the Registry doesnt already contain it</remarks>
		void Register(Plugin.IHelpFactory factory);

		
		/// <summary>
		/// Returns the List of Known Help Topics
		/// </summary>
		IHelp[] HelpTopics
		{
			get;
		}		
	}
}
