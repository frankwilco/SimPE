/***************************************************************************
 *   Copyright (C) 2005 by Ambertation                                     *
 *   quaxi@ambertation.de                                                  *
 *   Copyright (C) 2008 by Peter L Jones                                   *
 *   pljones@users.sf.net                                                  *
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
using System.Collections;
using System.Xml;
using SimPe.Interfaces.Wrapper;

namespace SimPe
{

	/// <summary>
	/// use this Class to access the FileIndex
	/// </summary>
	public class FileTable : FileTableBase
	{
		static SimPe.Interfaces.IToolRegistry treg;
		/// <summary>
		/// Returns/Sets a ToolRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IToolRegistry ToolRegistry
		{
			get { return treg; }
			set { 
				treg = value;
			}
		}

		static SimPe.Interfaces.IHelpRegistry hreg;
		/// <summary>
		/// Returns/Sets a HelpTopicRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.IHelpRegistry HelpTopicRegistry
		{
			get { return hreg; }
			set { hreg = value;}
		}
		

		static SimPe.Interfaces.ISettingsRegistry sreg;
		/// <summary>
		/// Returns/Sets a SettingsRegistry (can be null)
		/// </summary>
		public static SimPe.Interfaces.ISettingsRegistry SettingsRegistry
		{
			get { return sreg; }
			set { sreg = value;}
		}

        static SimPe.Interfaces.ICommandLineRegistry clreg;
        public static SimPe.Interfaces.ICommandLineRegistry CommandLineRegistry { get { return clreg; } set { clreg = value; } }

		public static void Reload()
		{
			FileTable.FileIndex.BaseFolders.Clear();			
			FileTable.FileIndex.BaseFolders = FileTable.DefaultFolders;
			FileTable.FileIndex.ForceReload();
		}
    }
}
