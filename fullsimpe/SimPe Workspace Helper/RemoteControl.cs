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

namespace SimPe
{
	/// <summary>
	/// This calss can be used to control SimPE from a Plugin.
	/// </summary>
	public class RemoteControl
	{
		/// <summary>
		/// Delegate you have to implement for the remote Package opener
		/// </summary>
		public delegate bool OpenPackageDelegate(string filename);

		/// <summary>
		/// Delegate you have to implement for the remote Package opener
		/// </summary>
		public delegate bool OpenMemPackageDelegate(SimPe.Interfaces.Files.IPackageFile pkg);

		/// <summary>
		/// Delegate you have to implement for the Remote PackedFile Opener
		/// </summary>
		public delegate bool OpenPackedFileDelegate(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii);

		/// <summary>
		/// Used to show/hide a Dock
		/// </summary>
		public delegate void ShowDockDelegate(TD.SandDock.DockControl doc, bool hide);

		static ShowDockDelegate sdd;
		/// <summary>
		/// Returns/Sets the ShowDock Delegate
		/// </summary>
		public static ShowDockDelegate ShowDockFkt
		{
			get { return sdd; }
			set { sdd = value; }
		}

		static OpenPackedFileDelegate opf;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenPackedFileDelegate OpenPackedFileFkt
		{
			get { return opf; }
			set { opf = value; }
		}

		static OpenPackageDelegate op;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenPackageDelegate OpenPackageFkt
		{
			get { return op; }
			set { op = value; }
		}

		/// <summary>
		/// Show/Hide a given Dock
		/// </summary>
		/// <param name="doc"></param>
		/// <param name="hide"></param>
		public static void ShowDock(TD.SandDock.DockControl doc, bool hide)
		{
			if (sdd==null) return;
			sdd(doc, hide);
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="filename">The Filename of the package</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackage(string filename) 
		{
			if (op==null) return false;

			try 
			{
				return op(filename);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to open a Package in the SimPE GUI. (file="+filename+")", ex);
			}
			return false;
		}

		static OpenMemPackageDelegate omp;
		/// <summary>
		/// Returns/Sets the Function that should be called if you want to open a PackedFile
		/// </summary>
		public static OpenMemPackageDelegate OpenMemoryPackageFkt
		{
			get { return omp; }
			set { omp = value; }
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="filename">The Filename of the package</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenMemoryPackage(SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			if (omp==null) return false;

			try 
			{
				return omp(pkg);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to open a Package in the SimPE GUI. (package="+pkg.ToString()+")", ex);
			}
			return false;
		}

		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <param name="pkg">The package the descriptor is in</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackedFile(SimPe.Interfaces.Files.IPackedFileDescriptor pfd, SimPe.Interfaces.Files.IPackageFile pkg) 
		{
			return OpenPackedFile(FileTable.FileIndex.CreateFileIndexItem(pfd, pkg));
		}


		/// <summary>
		/// Open a Package in the main SimPE Gui
		/// </summary>
		/// <param name="pfd">The FileDescriptor</param>
		/// <returns>true, if the package was opened</returns>
		public static bool OpenPackedFile(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii) 
		{
			if (opf==null) return false;

			try 
			{
				return opf(fii);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("Unable to open a Packaed File in the SimPE GUI. ("+fii.ToString()+")", ex);
			}
			return false;
		}
	}
}
