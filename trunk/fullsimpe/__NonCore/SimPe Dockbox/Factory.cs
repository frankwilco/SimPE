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
using SimPe.Interfaces;
using SimPe.Plugin.Tool.Action;

namespace SimPe.Plugin.Tool.Dockable
{
	/// <summary>
	/// Lists all Plugins (=FileType Wrappers) available in this Package
	/// </summary>
	/// <remarks>
	/// GetWrappers() has to return a list of all Plugins provided by this Library. 
	/// If a Plugin isn't returned, SimPe won't recognize it!
	/// </remarks>
	public class DockboxFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory, SimPe.Interfaces.Plugin.IToolFactory
	{
		#region Specific Attributes / Methods
		ResourceDock rd;

		public DockboxFactory() : base ()
		{
			rd = new ResourceDock();
		}
		#endregion

		#region AbstractWrapperFactory Member
		/// <summary>
		/// Returns a List of all available Plugins in this Package
		/// </summary>
		/// <returns>A List of all provided Plugins (=FileType Wrappers)</returns>
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{
				IWrapper[] wrappers = {
										  
									  };
				return wrappers;
			}
		}

		#endregion

		#region IToolFactory Member

		public IToolPlugin[] KnownTools
		{
			get
			{				
				IToolPlugin[] tools = {
								    new PackageDockTool(rd),
									new ResourceDockTool(rd),
									new WrapperDockTool(rd),
									new HexDecConverterTool(rd),
									new ActionReloadFiletable(),
									new ActionUniqueInstance(),
									new CreateListFromPackageTool(),
									new CreateListFromSelectionTool(),
								    new HexDockTool(rd),
									new FinderDock(),
									new SaveSims2PackTool(),
									new LoadSims2PackTool()
#if DEBUG
										  , new ActionCheckFiletable()
										  , new ActionBuildPhpGuidList()
										  , new DebugDock()
#endif
				};
				return tools;
			}
		}
		#endregion
	}
}