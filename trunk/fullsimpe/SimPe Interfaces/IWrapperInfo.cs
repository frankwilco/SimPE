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
	/// Contains Human Readable Information about a Wrapper
	/// </summary>
	/// <remarks>Never Implement a new Version of this Interface, 
	/// use <see cref="SimPe.Interfaces.Plugin.AbstractWrapperInfo"/> 
	/// as staring Point for a new Implementation. Otherwise the Loader 
	/// Wrapper loader won't load the Image Index correct!</remarks>
	public interface IWrapperInfo : System.IDisposable
	{
		/// <summary>
		/// The Name of this Wrapper
		/// </summary>
		string Name 
		{
			get;
	    }

		/// <summary>
		/// The Description of this Wrapper
		/// </summary>
		string Description 
		{
			get;
		}

		/// <summary>
		/// The Author of this Wrapper
		/// </summary>
		string Author 
		{
			get;
		}

		/// <summary>
		/// The Version of this Wrapper
		/// </summary>
		int Version
		{
			get;
		}

		/// <summary>
		/// Returns a Unique ID for this Wrapper
		/// </summary>
		ulong UID 
		{
			get;
		}

		/// <summary>
		/// Returns a Icon that should be presented for that resource
		/// </summary>
		System.Drawing.Image Icon
		{
			get;
		}

		/// <summary>
		/// Returns the Index of the Wrapepr icon in the ImageList of the Registry
		/// </summary>
		int IconIndex 
		{
			get;
		}
	}
}
