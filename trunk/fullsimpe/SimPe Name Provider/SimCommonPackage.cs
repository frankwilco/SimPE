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
using SimPe.Interfaces.Providers;
using SimPe.Interfaces.Files;

namespace SimPe.Providers
{
	/// <summary>
	/// Zusammenfassung für SimCommonPackage.
	/// </summary>
	public abstract class SimCommonPackage : ICommonPackage
	{
		/// <summary>
		/// The Package currently opened
		/// </summary>
		IPackageFile package;

		/// <summary>
		/// Creates the List for the specific Folder
		/// </summary>
		/// <param name="folder">The Folder with the Character Files</param>
		public SimCommonPackage(IPackageFile package)
		{			
			BasePackage = package;
		}

		/// <summary>
		/// Returns or sets the Folder where the Character Files are stored
		/// </summary>
		/// <remarks>Sets the names List to null</remarks>
		public IPackageFile BasePackage
		{
			get 
			{
				return package;
			}
			set 
			{
				if (package != value) BasePackageChanged();
				package = value;
				
			}
		}

		/// <summary>
		/// Called if the BaseBackae was changed
		/// </summary>
		protected abstract void BasePackageChanged();
	}
}
