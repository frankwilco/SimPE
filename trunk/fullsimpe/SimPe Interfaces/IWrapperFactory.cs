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

namespace SimPe.Interfaces.Plugin
{
	/// <summary>
	/// If you create a Plugin for SimPe your .dll must implement this interface 
	/// give the calling main Application a reference to your Plugin Objects
	/// </summary>
	/// <remarks>
	/// When SimPe tries to load the Wrappers stored here, it will create a new Instance of
	/// the Factory. After taht it will set LinkedRegistry/LinkedProvider to the registry the Objects going 
	/// to be linked with.
	/// Last it wil load the list of KnownWrappers.
	/// </remarks>
	public interface IWrapperFactory
	{		
		/// <summary>
		/// Returns all Wrappers the Factory knows
		/// </summary>
		IWrapper[] KnownWrappers 
		{
			get;
		}

		/// <summary>
		/// Returns or sets the Registry this Plugin was last registred with
		/// </summary>
		IWrapperRegistry LinkedRegistry 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns or sets the Provider this Plugin can use
		/// </summary>
		IProviderRegistry LinkedProvider
		{
			get;
			set;
		}
	}
}
