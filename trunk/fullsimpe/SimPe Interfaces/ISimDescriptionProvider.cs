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

namespace SimPe.Interfaces.Providers
{
	/// <summary>
	/// Interface to obtain all SimDescriptions available in a Package
	/// </summary>
	public interface ISimDescriptions : ICommonPackage
	{
		/// <summary>
		/// Find the Description of a Sim using the Instance Number
		/// </summary>
		/// <param name="instance">The Instance Id of the sim</param>
		/// <returns>null or a ISDesc Object</returns>
		Wrapper.ISDesc FindSim(ushort instance);

		/// <summary>
		/// Find the Description of a Sim using the Sim ID
		/// </summary>
		/// <param name="simid">The Sim ID</param>
		/// <returns>null or a ISDesc Object</returns>
		Wrapper.ISDesc FindSim(uint simid);

		/// <summary>
		/// returns the Instance Id for the given Sim
		/// </summary>
		/// <param name="simid">ID of the Sim</param>
		/// <returns>0xffff or a valid Instance Number</returns>
		ushort GetInstance(uint simid);

		/// <summary>
		/// returns the Sim Id for the given Sim
		/// </summary>
		/// <param name="instance">Instance Number of the Sim</param>
		/// <returns>0xffffffff or a valid Sim ID</returns>
		uint GetSimId(ushort instance);
	}
}
