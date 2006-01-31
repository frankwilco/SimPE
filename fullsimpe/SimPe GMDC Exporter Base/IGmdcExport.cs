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
using System.IO;

namespace SimPe.Plugin.Gmdc
{	
	/// <summary>
	/// This Interface must be implemented by Exporter Plugins
	/// </summary>
	/// <remarks>
	/// It is probably a good Idea, to not implement this Interface 
	/// direct, but reuse the AbstractGmdcExporter class.
	/// </remarks>
	public interface IGmdcExporter
	{
		/// <summary>
		/// Create the export for all available Groups
		/// </summary>
		/// <param name="gmdc"></param>
		/// <returns>The created Stream</returns>
		System.IO.Stream Process(GeometryDataContainer gmdc);

		/// <summary>
		/// Create the export for the given Groups
		/// </summary>
		/// <param name="gmdc"></param>
		/// <param name="groups"></param>
		/// <returns>The created Stream</returns>
		System.IO.Stream Process(GeometryDataContainer gmdc, GmdcGroups groups);
		
		/// <summary>
		/// Retunrs or sets the FileName that is used to create the File
		/// </summary>
		string FileName
		{
			get;
			set;
		}

		/// <summary>
		/// Returns the Content of the File base on the last loaded GroupSet
		/// </summary>
		System.IO.StreamWriter FileContent 
		{
			get;
		}

		/// <summary>
		/// Returns a Version Number for the used Interface
		/// </summary>
		int Version 
		{
			get;
		}

		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		string FileExtension
		{
			get;
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		string FileDescription
		{
			get;
		}

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		string Author
		{
			get;
		}

		/// <summary>
		/// Which Order is used for the Components (determins the Transformation that should be applied on export)
		/// </summary>
		ElementOrder Component 
		{
			get;
			set;
		}

		/// <summary>
		/// true, if you want SimPe to correct the Joint definitions, moving all rotations to the _root node, 
		/// and all translations to the _trans node of a Joint pair.
		/// </summary>
		bool CorrectJointSetup
		{
			get;
			set;
		}
	}
}
