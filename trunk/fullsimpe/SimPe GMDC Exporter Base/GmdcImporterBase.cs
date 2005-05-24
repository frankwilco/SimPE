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
	/// Implement this abstract class to create a new Gmdc Importer Plugin.
	/// </summary>
	public abstract class GmdcImporterBase : AbstractGmdcImporter
	{		
		/// <summary>
		/// default Constructor
		/// </summary>		
		public GmdcImporterBase() : base() {}

		#region AbstractGmdcImporter Implementation	

		/// <summary>
		/// This Method is called during the Import to process the input Data and 
		/// generate a vaild Groups ArrayList.
		/// </summary>
		/// <returns>A List of all available Groups</returns>
		/// <remarks>You can use the Input and Gmdc Member to acces the Stream and 
		/// the Gmdc File that should be changed</remarks>
		protected override ImportedGroups LoadGroups()
		{
			ImportedGroups grps = new ImportedGroups();
			LoadLists();
			ProcessLists(grps);
			return grps;
		}
		#endregion

		/// <summary>
		/// stores the List of parsed Vertices (as SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat)
		/// </summary>		
		protected ArrayList vertices;
		/// <summary>
		/// stores the List of parsed Normals (as SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat)
		/// </summary>
		protected ArrayList normals;
		/// <summary>
		/// stores the List of parsed UVCoordinates (as SimPe.Plugin.Gmdc.GmdcElementValueTwoFloat)
		/// </summary>
		protected ArrayList uvmaps;

		/// <summary>
		/// Keys=GroupNames, values = faces List
		/// </summary>
		protected Hashtable groups;
		/// <summary>
		/// Contains the Faces List for the current Group (as SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat)
		/// </summary>
		protected ArrayList faces;

		/// <summary>
		/// Use the Members, that wer initialized with LoadLists() to create
		/// the Imported Group Data
		/// </summary>
		/// <param name="grps">The List that should receive the Group Data</param>
		void ProcessLists(ImportedGroups grps)
		{
			foreach (string k in groups.Keys) 
			{
				faces = (ArrayList)groups[k];

				//ignore empty groups
				if (faces.Count==0) continue;

				ImportedGroup g = PrepareGroup();								
				g.Group.Name = k;
				BuildGroup(g);

				grps.Add(g);
			}
		}
		
		/// <summary>
		/// Add a new Value to the element with the given Index
		/// </summary>
		/// <param name="g">The current Group</param>
		/// <param name="index">Index of the Element</param>
		/// <param name="val">the Value you want to add</param>
		void AddElement(ImportedGroup g, int index, object val) 
		{
			if (g.Scale==1) g.Elements[index].Values.Add(val);
			else 
			{
				GmdcElementValueBase nval = ((GmdcElementValueBase)val).Clone();
				for (int i=0; i<nval.Data.Length; i++) nval.Data[i] *= g.Scale;
				g.Elements[index].Values.Add(nval);
			}
			
		}

		/// <summary>
		/// Build a Single Group from the Member Data generated with LoadLists()
		/// </summary>
		/// <param name="g"></param>
		/// <remarks>At this point, the faces Member contains the face List for 
		/// the current Group</remarks>
		void BuildGroup(ImportedGroup g)
		{
			//Whenever a new Index is added, we store the index it wil get in the Elements Section
			//since the Faces could have diffrent indices for normals and uvcoords, we need three maps
			Hashtable valias = new Hashtable();
			Hashtable vnalias = new Hashtable();
			Hashtable vtalias = new Hashtable();

			for (int x=0; x<faces.Count; x++)
			{
				GmdcElementValueThreeFloat f = (GmdcElementValueThreeFloat)faces[x];
				int v = (int)f.Data[0];
				int vt = (int)f.Data[1];
				int vn = (int)f.Data[2];
				bool newv = false;
				bool newvn = false;
				bool newvt = false;

				if (v<=0) throw new Exception("Zero Vertex Index Found!");
				try 
				{
					//new Element, so add it to the Map and the List
					if (!valias.ContainsKey(v)) 
					{
						ArrayList l = new ArrayList();
						l.Add(g.Elements[0].Values.Count);
						valias[v] = l;
						AddElement(g, 0, vertices[v-1]);
						newv = true;
					}
				

					if (vn>0) 
					{
						//new Element, so add it to the Map and the List
						if (!vnalias.ContainsKey(vn)) 
						{
							ArrayList l = new ArrayList();
							l.Add(g.Elements[1].Values.Count);
							vnalias[vn] = l;
							AddElement(g, 1, normals[vn-1]);
							newvn = true;
						}
					}
				

					if (vt>0)
					{
						//new Element, so add it to the Map and the List
						if (!vtalias.ContainsKey(vt)) 
						{
							ArrayList l = new ArrayList();
							l.Add(g.Elements[2].Values.Count);
							vtalias[vt] = l;
							AddElement(g, 2, uvmaps[vt-1]);	
							newvt = true;
						}
					} 
			
					//Now get a List of all position where we can find an instance of the wanted FaceItem
					ArrayList lv = (ArrayList)valias[v];
					if (lv==null) 
					{
						lv = new ArrayList();
						lv.Add(-1);
					}
					ArrayList lvn = (ArrayList)vnalias[vn];
					if (lvn==null) 
					{
						lvn = new ArrayList();
						lvn.Add(-1);
					}
					ArrayList lvt = (ArrayList)vtalias[vt];
					if (lvt==null) 
					{
						lvt = new ArrayList();
						lvt.Add(-1);
					}
		
					//We need something where als stored Indices are the same, so look for that
					bool found = false;
					for (int i=0; i<lv.Count; i++)
						for (int j=0; j<lvn.Count; j++)
							for (int k=0; k<lvt.Count; k++) 
							{
								if (
									((int)lv[i]==(int)lvn[j] || (int)lv[i]==-1 || (int)lvn[j]==-1) && 
									((int)lv[i]==(int)lvt[k] || (int)lv[i]==-1 || (int)lvt[k]==-1) && 
									((int)lvn[j]==(int)lvt[k] || (int)lvt[k]==-1 || (int)lvn[j]==-1)
									) 
								{
									int val = (int)lv[i];
									if (val==-1) val = (int)lvn[j];
									if (val==-1) val = (int)lvt[k];
									if (val!=-1) 
									{
										g.Group.Faces.Add(val);
										found = true;
									}
								}
							}
				
					//unfortunatley we did not find matching pairs, so add new Elements
					if (!found) 
					{
						if (!newv && v>0) 
						{
							lv.Add(g.Elements[0].Values.Count);
							AddElement(g, 0, vertices[v-1]);
						}

						if (!newvn && vn>0)
						{
							lvn.Add(g.Elements[1].Values.Count);
							AddElement(g, 1, normals[vn-1]);
						}

						if (!newvt && vt>0) 
						{
							lvt.Add(g.Elements[2].Values.Count);
							AddElement(g, 2, uvmaps[vt-1]);
						}	
					
						if (g.Elements[0].Values.Count!=g.Elements[1].Values.Count || g.Elements[0].Values.Count!=g.Elements[2].Values.Count)
							throw new Exception("Element Lists are out of Sync");

						g.Group.Faces.Add(g.Elements[0].Values.Count-1);
					}
				}
				catch (Exception ex)
				{
					Exception nex = new Exception("Error while creating Group List", new Exception(this.ErrorMessage, ex));
					this.error = "";
					throw nex;
				}
			}

			/*int size = int.MaxValue;
			//if we have an empty map, we will not add that section to the Link Element!
			if (g.Elements[0].Values.Count>0) 
			{
				g.Link.ReferencedElement.Add(0);
				size = Math.Min(size, g.Elements[0].Values.Count);
			}
			if (g.Elements[1].Values.Count>0) 
			{
				g.Link.ReferencedElement.Add(1);				
				size = Math.Min(size, g.Elements[1].Values.Count);
			}
			if (g.Elements[2].Values.Count>0) 
			{
				g.Link.ReferencedElement.Add(2);
				size = Math.Min(size, g.Elements[2].Values.Count);	
			}

			if (size==int.MaxValue) size=0;
			g.Link.ReferencedSize = size;
			g.Link.ActiveElements = g.Link.ReferencedElement.Count;

			g.Elements[0].Number = g.Elements[0].Values.Count;
			g.Elements[1].Number = g.Elements[1].Values.Count;
			g.Elements[2].Number = g.Elements[2].Values.Count;
			*/
		}

		/// <summary>
		/// Initializes the <see cref="groups"/>, <see cref="vertices"/>, <see cref="normals"/> and <see cref="uvmaps"/> Lists
		/// </summary>
		/// <remarks>The <see cref="vertices"/> (SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat), 
		/// <see cref="normals"/> (SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat) and 
		/// <see cref="uvmaps"/> (SimPe.Plugin.Gmdc.GmdcElementValueTwoFloat) Lists contain 
		/// the actual Coordinates for the vertices, normals and uvcoordinates.
		/// 
		/// The <see cref="groups"/> Hashtable (key=name of a Meshgroup, 
		/// value = <see cref="faces"/> (SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat) List) contains 
		/// the Listing of all available faces in a Group.
		/// 
		/// The SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat Members of the faces List 
		/// enumerate the Vertex (data[0]), Normal (data[2]) and UVCoordinate (data[1])
		/// Indices in the corresponding Lists.
		/// </remarks>
		protected abstract void LoadLists();		
	}
}
