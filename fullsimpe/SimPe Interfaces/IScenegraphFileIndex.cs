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

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// This is a Index over all Files found in all Packages
	/// </summary>
	public interface IScenegraphFileIndex
	{
		// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Clone</returns>
		IScenegraphFileIndex Clone();

		/// <summary>
		/// Forces a Reload of the FileIndex
		/// </summary>
		/// <remarks>
		/// Use Load() if you want to make sure that the FileIndex is available, 
		/// use ForceReload() if you want to reload the FileIndex (for example, 
		/// becuase the Files changed)
		/// </remarks>
		void ForceReload();

		/// <summary>
		/// Load the FileIndex if it is not available yet
		/// </summary>
		/// <remarks>
		/// Use Load() if you want to make sure that the FileIndex is available, 
		/// use ForceReload() if you want to reload the FileIndex (for example, 
		/// becuase the Files changed)
		/// </remarks>
		void Load();

		/// <summary>
		/// Add all Files stored in all the packages found in the passed Folder
		/// </summary>
		/// <param name="path">The Folder you want to scan</param>
		void AddIndexFromFolder(string path);

		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="file">Name of the package File</param>
		/// <remarks>Updates the WaitingScreen Message</remarks>
		void AddIndexFromPackage(string file);

		/// <summary>
		/// Add all Files stored in the passed package
		/// </summary>
		/// <param name="package">The package File</param>
		void AddIndexFromPackage(SimPe.Interfaces.Files.IPackageFile package);

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package);

		/// <summary>
		/// Add a Filedescriptor to the Index
		/// </summary>
		/// <param name="pfd">The Descriptor</param>
		/// <param name="package">The File</param>
		/// <param name="localgroup">use this groupa as replacement for 0xffffffff</param>
		void AddIndexFromPfd(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile package, uint localgroup);

		/// <summary>
		/// Return all matching FileIndexItems
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFile(Interfaces.Files.IPackedFileDescriptor pfd);

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="nolocal">true, if you don't want to get local Files (group=0xffffffff) returned</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFile(uint type, bool nolocal);

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFile(uint type, uint group);

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="group">the Group of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFile(uint type, uint group, ulong instance);

		/// <summary>
		/// Returns all matching FileIndexItems while Ignoring the Group
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFileDiscardingGroup(Interfaces.Files.IPackedFileDescriptor pfd);

		/// <summary>
		/// Returns all matching FileIndexItems for the passed type
		/// </summary>
		/// <param name="type">the Type of the Files</param>
		/// <param name="instance">Instance Number of the File</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFileDiscardingGroup(uint type, ulong instance);

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="pfd">The File you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFileByInstance(ulong instance);

		/// <summary>
		/// Return all matching FileIndexItems (by Instance)
		/// </summary>
		/// <param name="group">The Group you are looking for</param>
		/// <returns>all FileIndexItems</returns>
		IScenegraphFileIndexItem[] FindFileByGroup(uint group);
		
		/// <summary>
		/// Looks for a File based on the Filename
		/// </summary>
		/// <param name="filename">The name of the File (applies only to Scenegraüh Resources)</param>
		/// <param name="type">The Type of the File you are looking for</param>
		/// <param name="defgroup">If the Filename has no group Hash, use this one</param>
		/// <param name="betolerant">
		/// set true if you want to enable a 
		/// fallback Algorithm in case of the precice Search failing
		/// </param>
		/// <returns>The first matching File or null if none</returns>
		IScenegraphFileIndexItem FindFileByName(string filename, uint type, uint defgroup, bool betolerant);

		/// <summary>
		/// Looks for a File based on the Filename
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <param name="betolerant">
		/// set true if you want to enable a 
		/// fallback Algorithm in case of the precice Search failing
		/// </param>
		/// <returns>The first matching File or null if none</returns>
		IScenegraphFileIndexItem FindSingleFile(Interfaces.Files.IPackedFileDescriptor pfd, bool betolerant);
	
		/// <summary>
		/// Sort the Files in this type ascending by instance value
		/// </summary>
		/// <param name="files">The Files you want to sort</param>
		IScenegraphFileIndexItem[] Sort(IScenegraphFileIndexItem[] files);
	}
}
