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

namespace SimPe.Interfaces
{
	/// <summary>
	/// Zusammenfassung für IWrapperRegistry.
	/// </summary>
	public interface IWrapperRegistry
	{		
		/// <summary>
		/// Registers a Wrapper to the Registry
		/// </summary>
		/// <param name="wrapper">The wrapper to register</param>
		/// <remarks>The wrapper must only be added if the Registry doesnt already contain it</remarks>
		void Register(IWrapper wrapper);	
	
		/// <summary>
		/// Registers all listed Wrappers with this Registry
		/// </summary>
		/// <param name="wrappers">The Wrappers to register</param>
		/// <remarks>The wrapper must only be added if the Registry doesnt already contain it</remarks>
		void Register(IWrapper[] wrappers);

		/// <summary>
		/// Registers all Wrappers supported by the Factory
		/// </summary>
		/// <param name="factory">The Factory Elements you want to register</param>
		/// <remarks>The wrapper must only be added if the Registry doesnt already contain it</remarks>
		void Register(Plugin.IWrapperFactory factory);

		/// <summary>
		/// Returns the List of Known Wrappers (without Wrappers having a Priority < 0!)
		/// </summary>
		/// <remarks>The Wrappers should be Returned in Order of Priority starting with the lowest!</remarks>
		IWrapper[] Wrappers 
		{
			get;
		}

		/// <summary>
		/// Returns the List of all Known Wrappers including Wrappers with Priority < 0
		/// </summary>
		/// <remarks>The Wrappers should be Returned in Order of Priority starting with the lowest!</remarks>
		IWrapper[] AllWrappers 
		{
			get;
		}

		/// <summary>
		/// Returns the first Handler capable of processing a File of the given Type
		/// </summary>
		/// <param name="type">The Type of the PackedFile</param>
		/// <returns>The assigned Handler or null if none was found</returns>
		Plugin.Internal.IPackedFileWrapper FindHandler(uint type);

		/// <summary>
		/// Returns the first Handler capable of processing a File
		/// </summary>
		/// <param name="data">The Data of the PackedFile</param>
		/// <returns>The assigned Handler or null if none was found</returns>
		/// <remarks>
		/// A handler is assigned if the first bytes of the Data are equal 
		/// to the signature provided by the Handler
		/// </remarks>
		SimPe.Interfaces.Plugin.IFileWrapper FindHandler(Byte[] data);

		/// <summary>
		/// Contains a Listing of all available Wrapper Icons
		/// </summary>
		System.Windows.Forms.ImageList WrapperImageList
		{
			get;
		}		
	}
}
