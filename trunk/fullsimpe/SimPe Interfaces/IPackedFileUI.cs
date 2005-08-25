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
using System.Windows.Forms;


namespace SimPe.Interfaces.Plugin
{
	/// <summary>
	/// Interface for PackeFile handlers
	/// </summary>
	/// <remarks>
	/// Packed File handlers Provide a GUI to present the Data stored in a Packed File.<br />
	/// To Export your GUI, you have to put everything into one Panel. The referenc to this
	/// Panel will be used by the Main Application to Display The Data.<br />
	/// Currently the Size of the Client Window is 880x246 Pixel. Your Panel will be resized to 
	/// those measurements. If your output is bigger, you might want to consider the Use of the 
	/// AutoScroll Attribute!
	/// </remarks>
	public interface IPackedFileUI : System.IDisposable
	{
		/// <summary>
		/// Passes the Panel that should present the Data
		/// </summary>
		/// <returns>The Panel Displaying the PackedFile Data</returns>
		Control GUIHandle
		{
			get;
		}

		/// <summary>
		/// Processes the Data and displays it within the GUI
		/// </summary>		
		/// <param name="wrapper">The Calling Wrapper</param>
		/// <remarks>
		/// The passed dats is definetley uncompressed and represents 
		/// the Plain Packed File Data
		/// 
		/// A UI class can allow Multiple instances, by Implementing 
		/// <see cref="IMultiplePackedFileUI"/>.
		/// 
		/// When Multiple Files are allowed , this Mtehod should only Refresh 
		/// the GUI Contents, and not create an entire new one.
		/// </remarks>
		void UpdateGUI(SimPe.Interfaces.Plugin.IFileWrapper wrapper);				
	}

	/// <summary>
	/// Interface for PackeFile handlers
	/// </summary>
	/// <remarks>
	/// Packed File handlers Provide a GUI to present the Data stored in a Packed File.<br />
	/// To Export your GUI, you have to put everything into one Panel. The referenc to this
	/// Panel will be used by the Main Application to Display The Data.<br />
	/// Currently the Size of the Client Window is 880x246 Pixel. Your Panel will be resized to 
	/// those measurements. If your output is bigger, you might want to consider the Use of the 
	/// AutoScroll Attribute!
	/// </remarks>
	public interface IPackedFileUIExt
	{
		/// <summary>
		/// Passes the Control that should present the Data
		/// </summary>
		/// <returns>The Panel Displaying the PackedFile Data</returns>
		Control GuiControl
		{
			get;
		}
	}
}
