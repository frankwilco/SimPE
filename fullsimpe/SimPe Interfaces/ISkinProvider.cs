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
using SimPe.Interfaces.Files;

namespace SimPe.Interfaces.Providers
{
	/// <summary>
	/// Interface to obtain Skin Files from the Game Installation
	/// </summary>
	public interface ISkinProvider : ICommonPackage
	{
		void LoadPackage();

		/// <summary>
		/// Returns the roperty Set of a Skin
		/// </summary>
		/// <param name="spfd">The File Description of the File you are looking for</param>
		/// <returns>null or the Property Set File</returns>
		object FindSet(Interfaces.Files.IPackedFileDescriptor spfd);

		/// <summary>
		/// Returns a list of all known memories
		/// </summary>
		ArrayList StoredSkins
		{
			get;		
		}

		string FindTxtrName(Interfaces.Files.IPackedFileDescriptor spfd);
		string FindTxtrName(string matdname);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ocpf">The MMAT or Property Set describing the Model</param>
		/// <returns>The Texture or null</returns>
		object FindTxtrName(object ocpf);

		object FindTxtr(string name);
		object FindUserTxtr(string name);
	}
}
