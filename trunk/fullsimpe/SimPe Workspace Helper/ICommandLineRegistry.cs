/***************************************************************************
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   peter@users.sf.net                                                    *
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
	/// Zusammenfassung für ICommandLineRegistry.
	/// </summary>
	public interface ICommandLineRegistry
	{		
		/// <summary>
		/// Registers a CommandLine to the Registry
		/// </summary>
		/// <param name="CommandLine">The CommandLine to register</param>
		/// <remarks>The CommandLine must only be added if the Registry doesnt already contain it</remarks>
        void RegisterCommandLines(ICommandLine CommandLine);	
	
		/// <summary>
		/// Registers all listed CommandLines with this Registry
		/// </summary>
		/// <param name="CommandLines">The CommandLines to register</param>
		/// <remarks>The CommandLine must only be added if the Registry doesnt already contain it</remarks>
        void RegisterCommandLines(ICommandLine[] CommandLines);

		/// <summary>
		/// Registers all CommandLines supported by the Factory
		/// </summary>
		/// <param name="factory">The Factory Elements you want to register</param>
		/// <remarks>The CommandLine must only be added if the Registry doesnt already contain it</remarks>
		void Register(Plugin.ICommandLineFactory factory);

		/// <summary>
		/// Returns the List of Known CommandLines
		/// </summary>
		/// <remarks>The CommandLines should be Returned in Order of Priority starting with the lowest!</remarks>
		ICommandLine[] CommandLines 
		{
			get;
		}
	}
}
