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
using System.Collections;
using SimPe.Packages;
using SimPe.Interfaces.Files;

namespace SimPe.Plugin
{
	/// <summary>
	/// Set of old and new Guid
	/// </summary>
	public class GuidSet 
	{
		public uint oldguid;
		public uint guid;
	}

	/// <summary>
	/// This class can Fix the Integrity of cloned Objects
	/// </summary>
	public class FixGuid
	{
		/// <summary>
		/// The Base Package
		/// </summary>
		protected IPackageFile package;

		/// <summary>
		/// Creates a new Instance of this class
		/// </summary>
		/// <param name="package">The package you want to fix the Integrity in</param>
		public FixGuid(IPackageFile package)
		{
			this.package = package;
		}

		/// <summary>
		/// Changes all guids (Depends on the passed Replacement Map)
		/// </summary>
		/// <param name="guids">List of GuidSet Objects</param>
		public void FixGuids(ArrayList guids) 
		{
			Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.MMAT);	

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
				mmat.ProcessData(pfd, package);


				if (guids!=null) 
				{
					foreach (GuidSet sget in guids) 
					{
						if (mmat.GetSaveItem("objectGUID").UIntegerValue == sget.oldguid) 
						{
							mmat.GetSaveItem("objectGUID").UIntegerValue = sget.guid;
							mmat.SynchronizeUserData();
						}
					}
				}
			}
		}

		/// <summary>
		/// Changes all guids (ignore the current GUID)
		/// </summary>
		/// <param name="newguid">The new GUID</param>
		public void FixGuids(uint newguid) 
		{
			Interfaces.Files.IPackedFileDescriptor[] mpfds = package.FindFiles(Data.MetaData.MMAT);

			foreach (Interfaces.Files.IPackedFileDescriptor pfd in mpfds) 
			{
				SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();
				mmat.ProcessData(pfd, package);

				mmat.GetSaveItem("objectGUID").UIntegerValue = newguid;
				mmat.SynchronizeUserData();
			}
		}
	}
}
