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

namespace SimPe.Plugin.Gmdc
{
	/// <summary>
	/// Implement this abstract class to create a new Gmdc Exporter Plugin
	/// </summary>
	public abstract class AbstractGmdcExporter : IGmdcExporter
	{

		static CultureInfo expcult;
		/// <summary>
		/// Returns the Culture that should be used during the Export
		/// </summary>
		/// <remarks>The Culure is needed whenever you write floatingpoint 
		/// Values to a Text File</remarks>
		public static CultureInfo DefaultCulture 
		{			
			get 
			{
				if (expcult==null) 
				{
					expcult = (CultureInfo)CultureInfo.InvariantCulture.Clone();					
				}

				return expcult;
			}
		}

		GeometryDataContainer gmdc;
		/// <summary>
		/// Returns the assigned Gmdc File
		/// </summary>
		protected GeometryDataContainer Gmdc
		{
			get {return gmdc; }
		}

		GmdcGroups groups;
		/// <summary>
		/// Returns the MeshGroups that should be processed
		/// </summary>
		protected GmdcGroups Groups 
		{
			get {return groups; }
		}

		GmdcElement vertex;
		/// <summary>
		/// Returns null or the Element that contains the Vertex Data
		/// </summary>
		protected GmdcElement VertexElement 
		{
			get { return vertex; }
		}

		GmdcElement normal;
		/// <summary>
		/// Returns null or the Element that contains the Vertex Data 
		/// </summary>
		protected GmdcElement NormalElement 
		{
			get { return normal; }
		}

		GmdcElement uvmap;
		/// <summary>
		/// Returns null or the Element that contains the UVMap Data 
		/// </summary>
		protected GmdcElement UVCoordinateElement 
		{
			get { return uvmap; }
		}

		GmdcLink link;
		/// <summary>
		/// Returns the Link that is used for the current Group (can be null)
		/// </summary> 
		protected GmdcLink Link 
		{
			get { return link; }
		}

		GmdcGroup group;
		/// <summary>
		/// Returns the curent group (can be null)
		/// </summary>
		protected GmdcGroup Group 
		{
			get { return group; }
		}

		ElementOrder order;
		/// <summary>
		/// Which Order is used for the Components
		/// </summary>
		public ElementOrder Component 
		{
			get { return order; }
			set { order = value; }
		}

		bool cjs;
		/// <summary>
		/// true, if you want SimPe to correct the Joint definitions, moving all rotations to the _root node, 
		/// and all translations to the _trans node of a Joint pair.
		/// </summary>
		public bool CorrectJointSetup
		{
			get { return cjs; }
			set { cjs = value; }
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="gmdc">The gmdc File you want to use</param>
		/// <param name="groups"></param>
		public AbstractGmdcExporter(GeometryDataContainer gmdc, GmdcGroups groups) : this()
		{
			this.gmdc = gmdc;
			LoadGroups(groups);			
		}

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="gmdc">The gmdc File you want to use</param>
		public AbstractGmdcExporter(GeometryDataContainer gmdc) : this(gmdc, gmdc.Groups)
		{
		}

		/// <summary>
		/// Create a New Instace
		/// </summary>
		public AbstractGmdcExporter()
		{
			this.gmdc = null;
			this.order = new ElementOrder(ElementSorting.XZY);
			this.cjs = false;
		}

		/// <summary>
		/// Create the export for all available Groups
		/// </summary>
		/// <param name="gmdc"></param>
		/// <returns>The created Stream</returns>
		public System.IO.Stream Process(GeometryDataContainer gmdc)
		{
			return Process(gmdc, gmdc.Groups);
		}

		/// <summary>
		/// Create the export for the given Groups
		/// </summary>
		/// <param name="gmdc"></param>
		/// <param name="groups"></param>
		/// <returns>The created Stream</returns>
		public System.IO.Stream Process(GeometryDataContainer gmdc, GmdcGroups groups)
		{
			this.gmdc = gmdc;
			LoadGroups(groups);

			return this.FileContent.BaseStream;
		}

		/// <summary>
		/// Load the given Group Set
		/// </summary>
		/// <param name="groups"></param>
		void LoadGroups(GmdcGroups groups)
		{
			writer = new StreamWriter(new MemoryStream());
			this.groups = groups;
			LoadSpecialElements(null);
			InitFile();


			foreach (GmdcGroup g in groups) 
			{
				LoadSpecialElements(g);

				if (group!=null && vertex!=null && link!=null) ProcessGroup();
			}

			FinishFile();
			writer.Flush();
			writer.BaseStream.Seek(0, SeekOrigin.Begin);
		}	
	
		/// <summary>
		/// Load Data into the Vertex, Normal an UVCoordinateElement members
		/// </summary>
		/// <param name="group"></param>
		void LoadSpecialElements(GmdcGroup group)
		{
			vertex = null;
			normal = null;
			uvmap = null;
			link = null;
			this.group = group;

			if (group==null) return;
			if (gmdc==null) return;

			if (group.LinkIndex<Gmdc.Links.Length) 
			{
				link = Gmdc.Links[group.LinkIndex];
				foreach (int i in link.ReferencedElement) 
				{
					if (i<Gmdc.Elements.Length) 
					{
						GmdcElement e = Gmdc.Elements[i];
						if (e.Identity == ElementIdentity.Vertex) vertex = e;
						else if (e.Identity == ElementIdentity.Normal) normal = e;
						else if (e.Identity == ElementIdentity.UVCoordinate) uvmap = e;
					}
				} //foreach
			}
		}

		/// <summary>
		/// internal Attribute
		/// </summary>
		protected System.IO.StreamWriter writer;

		/// <summary>
		/// Returns the Content of the File base on the last loaded GroupSet
		/// </summary>
		public System.IO.StreamWriter FileContent 
		{
			get { return writer; }
		}

		/// <summary>
		/// Returns a Version Number for the used Interface
		/// </summary>
		public int Version 
		{
			get {return 1;}
		}		

		#region Abstract Methods
		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		public abstract string FileExtension
		{
			get;
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		public abstract string FileDescription
		{
			get;
		}

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		public abstract string Author
		{
			get;
		}

		/// <summary>
		/// Called when a new File is started
		/// </summary>
		/// <remarks>
		/// you should use this to write Header Informations. 
		/// Use the <see cref="writer"/> member to write to the File
		/// </remarks>
		protected abstract void InitFile();

		/// <summary>
		/// This is called whenever a Group (=subSet) needs to processed
		/// </summary>
		/// <remarks>
		/// You can use the <see cref="UVCoordinateElement"/>,  <see cref="NormalElement"/>, 
		///  <see cref="VertexElement"/>,  <see cref="Group"/> and  <see cref="Link"/> Members in this Method. 
		/// 
		/// This Method is only called, when the <see cref="Group"/>, <see cref="Link"/> and 
		/// Vertex Members are set (not null). The other still can 
		/// be Null!
		/// 
		/// Use the <see cref="writer"/> member to write to the File.
		/// </remarks>
		protected abstract void ProcessGroup();

		/// <summary>
		/// Called when the export was finished
		/// </summary>
		/// <remarks>you should use this to write Footer Informations. 
		/// Use the <see cref="writer"/> member to write to the File</remarks>
		protected abstract void FinishFile();
		#endregion

		string flname;
		public string FileName
		{
			get {
				if (flname==null) flname= "";
				return flname;
			}
			set {flname=value;}
		}
	}
}
