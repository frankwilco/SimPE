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

namespace SimPe.Interfaces.Plugin
{
	/// <summary>
	/// Lists all Plugins (=FileType Wrappers) available in this Package
	/// </summary>
	/// <remarks>
	/// GetWrappers() has to return a list of all Plugins provided by this Library. 
	/// If a Plugin isn't returned, SimPe won't recognize it!
	/// </remarks>
	public abstract class AbstractWrapperFactory : SimPe.Interfaces.Plugin.IWrapperFactory
	{
		/// <summary>
		/// Holds a referenc to the Registry this Plugin was last registred to (can be null!)
		/// </summary>
		private IWrapperRegistry registry;

		/// <summary>
		/// Holds a reference to available Providers (i.e. for SIm Names or Images)
		/// </summary>
		private IProviderRegistry provider;

		#region IWrapperFactory Member

		/// <summary>
		/// Returns or sets the Registry this Plugin was last registred with
		/// </summary>
		public virtual IWrapperRegistry LinkedRegistry 
		{
			get { return registry; }
			set { registry = value; }
		}

		/// <summary>
		/// Returns or sets the Provider this Plugin can use
		/// </summary>
		public virtual IProviderRegistry LinkedProvider
		{
			get { return provider; }
			set { provider = value; }
		}

		/// <summary>
		/// Returns a List of all available Plugins in this Package
		/// </summary>
		/// <returns>A List of all provided Plugins (=FileType Wrappers)</returns>
		public virtual SimPe.Interfaces.IWrapper[] KnownWrappers
		{
			get 
			{				
				IWrapper[] wrappers = {										  
									  };
				return wrappers;
			}
		}		

		public string FileName
		{
			get 
			{
				return this.GetType().Assembly.FullName;
			}
		}

		#endregion

	}
}
