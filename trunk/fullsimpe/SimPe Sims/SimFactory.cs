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
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;

namespace SimPe.PackedFiles.Wrapper.Factory
{

	/// <summary>
	/// The Wrapper Factory for Default Wrappers that ship with SimPe
	/// </summary>
	public class SimFactory : AbstractWrapperFactory
	{
		#region AbstractWrapperFactory Member
		public override SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{				
				if (Helper.StartedGui == Executable.Classic) 
				{
					return new IWrapper[0];
				} 
				else 
				{
					IWrapper[] wrappers = {
											  new SimPe.PackedFiles.Wrapper.ExtFamilyTies()									  
										  };
					return wrappers;
				}
			}
		}

		#endregion

	}
}
