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
	public class ScenegraphWrapperFactory : SimPe.Interfaces.Plugin.AbstractWrapperFactory
	{
		static bool inited = false;
		/// <summary>
		/// Add all other default RCol Extensions
		/// </summary>
		public static void InitRcolBlocks()
		{
			if (!inited) 
			{
				Rcol.TokenAssemblies.Add(typeof(SimPe.Plugin.GeometryDataContainer).Assembly);
				inited = true;
			}
		}

		/// <summary>
		/// Loads the GroupCache
		/// </summary>
		public static void LoadGroupCache()
		{
			if (FileTable.GroupCache!=null) return;


			SimPe.PackedFiles.Wrapper.GroupCache gc = new SimPe.PackedFiles.Wrapper.GroupCache();
			try 
			{
                string name = System.IO.Path.Combine(PathProvider.SimSavegameFolder, "Groups.cache");

				if (System.IO.File.Exists(name))
				{
					SimPe.Packages.File pkg = SimPe.Packages.File.LoadFromFile(name);
					SimPe.Interfaces.Files.IPackedFileDescriptor pfd = pkg.FindFile(0x54535053, 0, 1, 1);
					if (pfd!=null) gc.ProcessData(pfd, pkg, false);				
				}
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(new Warning("Unable to load groups.cache", ex.Message, ex));
			}

			FileTable.GroupCache = gc;
		}

		/// <summary>
		/// Creates the Class
		/// </summary>
		public ScenegraphWrapperFactory() : base() 
		{
			//prepare the FileIndex
			FileTable.FileIndex = new FileIndex();	
			SimPe.Packages.PackageMaintainer.Maintainer.FileIndex = FileTable.FileIndex.AddNewChild();
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
				InitRcolBlocks();
				IWrapper[] wrappers = {
										  new RefFile(),
										  new Plugin.Txtr(this.LinkedProvider, false),
										  //new Plugin.Matd(this.LinkedProvider, false),
										  new Plugin.Lifo(this.LinkedProvider, false),
										  //new Plugin.Shpe(this.LinkedProvider),
						                  new Plugin.GenericRcol(this.LinkedProvider, false),
										  new Plugin.MmatWrapper(),					
										  new SimPe.PackedFiles.Wrapper.GroupCache(),
										  new SimPe.PackedFiles.Wrapper.Slot()
									  };
				return wrappers;
			}
		}

		#endregion

	}
}
