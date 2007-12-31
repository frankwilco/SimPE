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
using System.Collections;
using SimPe.Plugin.Gmdc;
using SimPe.Geometry;

namespace SimPe.Plugin.Gmdc.Importer
{
	/// <summary>
	/// This class provides the functionality to Import Data from the .obj FileFormat
	/// </summary>	
	public class GmdcImportFromXsi : SimPe.Plugin.Gmdc.IGmdcImporter
	{		
		#region IGmdcImporter Member

		public int Version
		{
			get
			{
				return 1;
			}
		}

		public string FileExtension
		{
			get
			{
				return ".xsi";
			}
		}

		public string FileDescription
		{
			
			get {return "Softimage/3D dotXSI";}			
		}

		public string Author
		{
			get
			{
				return "Quaxi";
			}
		}

		public string ErrorMessage
		{
			get
			{
				return "";
			}
		}

		string flname;
		public string FileName
		{
			get
			{
				if (flname==null) return "";
				return flname;
			}
			set
			{
				flname = value;
			}
		}		

		ElementOrder cmp;
		public ElementOrder Component
		{
			get
			{
				if (cmp==null) cmp = new ElementOrder(Gmdc.ElementSorting.XZY);
				return cmp;
			}
			set
			{
				cmp = value;
			}
		}

		public bool Process(System.IO.Stream input, GeometryDataContainer gmdc, bool animationonly)
		{
			System.IO.StreamReader sr = new StreamReader(input);
			Ambertation.XSI.IO.AsciiFile xsi = Ambertation.XSI.IO.AsciiFile.FromStream(sr, FileName);

			GenericMeshImport gmi = new GenericMeshImport(xsi.ToScene(), gmdc, Component);
			return gmi.Run();
		}

		#endregion
	}
}
