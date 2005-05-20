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

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// This class provides the functionality to Export Data to the .obj FileFormat
	/// </summary>
	public class GmdcExportToObj : AbstractGmdcExporter
	{
		public GmdcExportToObj(GeometryDataContainer gmdc, GmdcGroups groups) : base(gmdc, groups) {}
		public GmdcExportToObj(GeometryDataContainer gmdc) : base(gmdc) {}
		public GmdcExportToObj() : base() {}

		int modelnr, vertexoffset;

		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		public override string FileExtension
		{
			get {return ".obj";}
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		public override string FileDescription
		{
			get {return "Maya Object File";}
		}		

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		public override string Author
		{
			get {return "Delphy";}
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
			modelnr = 0;
			vertexoffset = 0;
			writer.WriteLine("# File based on the GMDC plugin by Delphy");
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
			//Find the Vertex Reference Number
			int vertref = modelnr;
			for (int i=0; i<Gmdc.Elements.Count; i++) 
			{
				if (Gmdc.Elements[i]==VertexElement) 
				{
					vertref = i;
					break;
				}
			}			

			writer.WriteLine("# Object number: " + modelnr);
			writer.WriteLine("# VertexList ref: " + vertref);
			writer.WriteLine("g " + Group.Name);

					
			//first, write the availabel Vertices
			int vertexcount = 0;
			for (int i = 0; i < VertexElement.Values.Length; i++)
			{
				vertexcount++;					
				writer.WriteLine("v " + 
					VertexElement.Values[i].Data[0].ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
					VertexElement.Values[i].Data[1].ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
					VertexElement.Values[i].Data[2].ToString("N6", AbstractGmdcExporter.DefaultCulture) );
			}			
			
			//Add a MeshNormal Section if available
			if (this.NormalElement!=null) 
			{				
				for (int i = 0; i < NormalElement.Values.Length; i++)
				{
					writer.WriteLine("vn " + 
						VertexElement.Values[i].Data[0].ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
						VertexElement.Values[i].Data[1].ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
						VertexElement.Values[i].Data[2].ToString("N6", AbstractGmdcExporter.DefaultCulture));
				}				
			}
			
			

			//now the Texture Cords //iv available
			if (this.UVCoordinateElement!=null) 
			{								
				for (int i = 0; i < UVCoordinateElement.Values.Length; i++)
				{
					writer.WriteLine("vt " + 
						VertexElement.Values[i].Data[0].ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
						(-VertexElement.Values[i].Data[1]).ToString("N6", AbstractGmdcExporter.DefaultCulture));
				}
			}
			

			writer.WriteLine("# number of polygons: " + (Group.Faces.Count / 3));
			if (modelnr > 0) writer.WriteLine("# vertsSoFar: " + ((vertexoffset+vertexcount) - 2).ToString());
			else writer.WriteLine("# vertsSoFar: 0");			
			writer.WriteLine("# totalVertices: " + (vertexoffset+vertexcount));
			writer.WriteLine("# vertGroupStart: " + vertexoffset);

			for (int i = 0; i < Group.Faces.Count; i++)
			{
				int vertexnr = Group.Faces[i] + 1 + vertexoffset;
				if (i%3 == 0)
				{
					writer.Write("f " +
						vertexnr.ToString() +  "/" + 
						vertexnr.ToString() +  "/" + 
						vertexnr.ToString());
				} 
				else if (i%3 == 1)
				{
					writer.Write(" " + vertexnr.ToString() +  "/" + 
						vertexnr.ToString() +  "/" + 
						vertexnr.ToString());
				} 
				else 
				{
					writer.WriteLine(" " + vertexnr.ToString() +  "/" + 
						vertexnr.ToString() +  "/" + 
						vertexnr.ToString());
				}
			}			
			
			vertexoffset += vertexcount;
			modelnr++;
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
