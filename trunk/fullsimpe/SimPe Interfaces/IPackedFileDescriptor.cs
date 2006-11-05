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
using SimPe.Events;

namespace SimPe.Interfaces.Files
{
	/// <summary>
	/// Interface for PackedFile Descriptors
	/// </summary>
	public interface IPackedFileDescriptor : IPackedFileDescriptorBasic
	{
		/// <summary>
		/// Creates a clone of this Object
		/// </summary>
		/// <returns>The Cloned Object</returns>
		IPackedFileDescriptor Clone();		

		/// <summary>
		/// Same as <see cref="UserData"/>, but you can decide 
		/// if the <see cref="ChangedUserData"/> Event get's fired 
		/// </summary>
		/// <param name="data">the new UserData</param>
		/// <param name="fire">true if you want to fire a <see cref="ChangedUserData"/> Event.</param>
		/// <remarks>
		/// In Most scenarios you probably want to use <see cref="UserData"/> directly instead of this Method.
		/// It is basically only called intern by FileWrappers
		/// </remarks>
		void SetUserData(byte[] data, bool fire);
		

		/// <summary>
		/// Called whenever the content represented by this descripotr was changed
		/// </summary>
		/// <remarks>
		/// This is the public Change Listener. Developers can control in 
		/// <see cref="SetUserData"/>if this Event is fired. This Event will not fire if <see cref="SimPe.Interfaces.Plugin.Internal.SynchronizeUserData"/>
		/// is called (which changes the UserData).
		/// </remarks>
		event PackedFileChanged ChangedUserData;

		/// <summary>
		/// Called whenever the content represented by this descripotr was changed
		/// </summary>
		/// <remarks>
		/// This is the public Change Listener. Unlike <see cref="ChangedUserData"/>, this event allways fires when the USerData Changes
		/// </remarks>
		event PackedFileChanged ChangedData;
		

		/// <summary>
		/// Called whenever the Desciptor get's invalid
		/// </summary>
		event PackedFileChanged Closed;

		/// <summary>
		/// Triggered whenever the Content of the Descriptor was changed
		/// </summary>
		event System.EventHandler DescriptionChanged;

		/// <summary>
		/// Triggered whenever the Descriptor get's AMrked for Deletion
		/// </summary>
		event System.EventHandler Deleted;

        /// <summary>
        /// Returns the default string displayed in the ResourceList
        /// </summary>
        /// <returns></returns>
        string ToResListString();
		
	}
}
