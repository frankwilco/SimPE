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
using System.Collections.Generic;
using System.Text;

namespace SimPe.Interfaces
{
    /// <summary>
    /// Implement this interface to get called with the SimPe command line
    /// </summary>
    public interface ICommandLine
    {
        /// <summary>
        /// Parse() should check the first argument to see if it's recognised.
        /// If not, simply return false.  Else process the remaining arguments until satisfied.
        /// All arguments consumed should be removed.
        /// </summary>
        /// <param name="args"></param>
        /// <returns>False if SimPe should start; True if SimPe should exit</returns>
        bool Parse(List<string> argv);

        /// <summary>
        /// Called to determine what the "-help" option will display.
        /// The option name should be language-invariant.
        /// The help text can be language-specific.
        /// </summary>
        /// <returns>The command line option name (in string[0]) and help text (in string[1]).</returns>
        string[] Help();
    }
}
