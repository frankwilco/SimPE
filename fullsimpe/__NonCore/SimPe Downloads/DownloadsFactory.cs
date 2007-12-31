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

namespace SimPe.Plugin
{
	/// <summary>
	/// Lists all Plugins (=FileType Wrappers) available in this Package
	/// </summary>
	/// <remarks>
	/// GetWrappers() has to return a list of all Plugins provided by this Library. 
	/// If a Plugin isn't returned, SimPe won't recognize it!
	/// </remarks>
	public class DownloadsToolFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory, SimPe.Interfaces.Plugin.IToolFactory, SimPe.Interfaces.Plugin.ISettingsFactory
	{
		static SimPe.Interfaces.Scenegraph.IScenegraphFileIndex fii, tfii;
		internal static SimPe.Interfaces.Scenegraph.IScenegraphFileIndex FileIndex
		{
			get 
			{
				if (fii==null) fii = FileTable.FileIndex.AddNewChild();
				return fii;
			}
		}
		internal static SimPe.Interfaces.Scenegraph.IScenegraphFileIndex TeleportFileIndex
		{
			get 
			{
				if (tfii==null) tfii = FileIndex.AddNewChild();
				return tfii;
			}
		}

		public DownloadsToolFactory()
		{
			SimPe.Packages.StreamFactory.CleanupTeleport();
			
		}
		~DownloadsToolFactory()
		{
			SimPe.Packages.StreamFactory.CleanupTeleport();
		}

		#region AbstractWrapperFactory Member
		/// <summary>
		/// Returns a List of all available Plugins in this Package
		/// </summary>
		/// <returns>A List of all provided Plugins (=FileType Wrappers)</returns>
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{
				// TODO:  You can add more Wrappers here
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
				
				return new IToolPlugin[]{
											new SimPe.Plugin.Tool.Window.InstallerTool()
										};
			}
		}
		#endregion

		#region ISettingsFactory Member
		static SimPe.Plugin.Downloads.DownloadsSettings settings;
		public static SimPe.Plugin.Downloads.DownloadsSettings Settings
		{
			get 
			{
				if (settings==null) settings = new SimPe.Plugin.Downloads.DownloadsSettings();
				return settings;
			}
		}

		public ISettings[] KnownSettings
		{
			get
			{
				return new ISettings[] {
										   Settings
									   };
			}
		}

		#endregion
	}
}