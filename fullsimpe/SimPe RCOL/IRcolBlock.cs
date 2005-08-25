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
using System.Windows.Forms;
using SimPe.Plugin;

namespace SimPe.Interfaces.Scenegraph
{
	/// <summary>
	/// You need to implement is to provide a new RCOL Block
	/// </summary>
	public interface IRcolBlock : System.IDisposable
	{
		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		void Unserialize(System.IO.BinaryReader reader);

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		void Serialize(System.IO.BinaryWriter writer);

		/// <summary>
		/// Creates a new Instance
		/// </summary>
		IRcolBlock Create(uint id);

		/// <summary>
		/// Creates a new Instance with the default Block ID
		/// </summary>
		IRcolBlock Create();

		/// <summary>
		/// Registers the Object in the given Hashtable
		/// </summary>
		/// <param name="listing"></param>
		/// <returns>The Name of the Class Type</returns>
		string Register(Hashtable listing);

		/// <summary>
		/// Name of the Block containing the Object
		/// </summary>
		string BlockName 
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the ID used for this Block
		/// </summary>
		uint BlockID
		{
			get;
			set;
		}

		/// <summary>
		/// Returns / Sets the cSGResource of this Block, or null if none is avilable
		/// </summary>
		SGResource NameResource
		{
			get;
			set;
		}

		/// <summary>
		/// Returns a tabPage that contains a GUI for this Element
		/// </summary>
		TabPage TabPage 
		{
			get;
		}

		/// <summary>
		/// Returns a tabPage that contains a GUI for the first Block in a RCOL Resource
		/// </summary>
		TabPage ResourceTabPage 
		{
			get;
		}

		/// <summary>
		/// Update the displayed Data
		/// </summary>
		void Refresh();

		/// <summary>
		/// Adds more TabPages (which are needed to process the Class) to the Control
		/// </summary>
		/// <param name="tc">The TabControl the Pages will be added to</param>
		void ExtendTabControl(TabControl tc);

		/// <summary>
		/// Data was changed
		/// </summary>
		bool Changed 
		{
			get;
			set;
		}
		/// <summary>
		/// Returns the RCOL which lists this Resource in it's ReferencedFiles Attribute
		/// </summary>
		/// <param name="type">the Type of the ressource youar looking for</param>
		/// <returns>null or the RCOl Ressource</returns>
		Rcol FindReferencingParent(uint type);

	}
}
