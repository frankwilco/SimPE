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
using System.Globalization;
using SimPe.Plugin.Gmdc;
using SimPe.Geometry;

namespace SimPe.Plugin.Gmdc.Exporter
{
	/// <summary>
	/// This class provides the functionality to Export Data to the .x (DirectX) FileFormat
	/// </summary>
	public class GmdcExportToXSI : AbstractGmdcExporter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="gmdc">The Gmdc File the Export is based on</param>
		/// <param name="groups">The list of Groups you want to export</param>
		/// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .x File</remarks>
		public GmdcExportToXSI(GeometryDataContainer gmdc, GmdcGroups groups) : base(gmdc, groups) {}
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="gmdc">The Gmdc File the Export is based on</param>
		/// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .x File</remarks>
		public GmdcExportToXSI(GeometryDataContainer gmdc) : base(gmdc) {}
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <remarks>The export has to be started Manual through a call to <see cref="AbstractGmdcExporter.Process"/></remarks>
		public GmdcExportToXSI() : base()  {}

		//System.Collections.ArrayList modelnames;
		/// <summary>
		/// Returns a unique Modelname
		/// </summary>
		/// <param name="name">The name of the Model</param>
		/// <returns>the unique Name</returns>
		string GetUniqueGroupName(string name) 
		{			
			return name;			
		}

		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		public override string FileExtension
		{
			get {return ".xsi";}
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		public override string FileDescription
		{
			get {return "Softimage/3D dotXSI";}
		}		

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		public override string Author
		{
			get {return "Quaxi";}
		}

		/// <summary>
		/// Called when a new File is started
		/// </summary>
		/// <remarks>
		/// you should use this to write Header Informations. 
		/// Use the writer member to write to the File
		/// </remarks>
		protected override void InitFile()
		{			
			string name = System.IO.Path.GetFileNameWithoutExtension(this.FileName);
			string path = System.IO.Path.GetDirectoryName(this.FileName);
			path = System.IO.Path.Combine(path, name+".IMG");
			

			GeometryDataContainerExt gext = new GeometryDataContainerExt(Gmdc);
			Ambertation.Scenes.Scene scn = gext.GetScene(this.Groups, path, name+".IMG", this.Component);

			Ambertation.XSI.IO.AsciiFile xsi = Ambertation.XSI.IO.AsciiFile.FromScene(scn, FileName);
			xsi.SaveToStream(this.writer);
		}

		/// <summary>
		/// This is called whenever a Group (=subSet) needs to processed
		/// </summary>
		/// <remarks>
		/// You can use the UVCoordinateElement, NormalElement, 
		/// VertexElement, Group and Link Members in this Method. 
		/// 
		/// This Method is only called, when the Group, Link and 
		/// Vertex Members are set (not null). The other still can 
		/// be Null!
		/// 
		/// Use the writer member to write to the File.
		/// </remarks>
		protected override void ProcessGroup()
		{			
			
		}

		/// <summary>
		/// Called when the export was finished
		/// </summary>
		/// <remarks>you should use this to write Footer Informations. 
		/// Use the writer member to write to the File</remarks>
		protected override void FinishFile()
		{
			
		}
	}
}
