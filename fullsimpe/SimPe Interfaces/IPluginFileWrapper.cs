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
using SimPe.Interfaces.Plugin.Internal;

namespace SimPe.Interfaces.Plugin
{
	/// <summary>
	/// This Interface Implements Methods that must be provided by a PackedFile Wrapper
	/// </summary>
	public interface IFileWrapper : IPackedFileWrapper
	{
		/// <summary>
		/// Returns a List of all File Types this Class can Handel
		/// </summary>
		uint[] AssignableTypes
		{
			get;
		}

		/// <summary>
		/// Some Handler identify theier Target Files not with a Type but by a PackedFile Header, when this
		/// Method does not retun an empty Array, all files starting with the passed Signature will 
		/// be passed to the Handler
		/// </summary>
		Byte[] FileSignature
		{
			get;
		}			
	}

	/// <summary>
	/// This Interface has to be implemented by Wrappers that allow multiple Instance
	/// </summary>
	public interface IMultiplePackedFileWrapper
	{
		/// <summary>
		/// Returns a new Instance of the calling Class
		/// </summary>
		/// <returns>a new Instance of the calling Type</returns>
		IFileWrapper Activate();

		/// <summary>
		/// Returns a list of Arguments that should be passed to the Constructor during <see cref="Activate"/>.
		/// </summary>
		/// <returns></returns>
		object[] GetConstructorArguments();
	}
}
