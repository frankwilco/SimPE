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
	/// This class provides the functionality to Export Data to the .obj FileFormat
	/// </summary>
	public class GmdcImportFromObj : AbstractGmdcImporter
	{		
		public GmdcImportFromObj() : base() {}

		#region AbstractGmdcImporter Implementation
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
			get {return "Quaxi";}
		}

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

		ArrayList vertices;
		ArrayList normals;
		ArrayList uvmaps;
		ArrayList faces;
		Hashtable groups;
		string lineerror;	
		string groupname;

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

				ImportedGroup g = new ImportedGroup(Gmdc);
				
				//Vertex Element-----
				GmdcElement e = new GmdcElement(Gmdc);
				g.Elements.Add(e);
				e.Identity = ElementIdentity.Vertex;
				e.BlockFormat = BlockFormat.ThreeFloat;
				e.SetFormat = SetFormat.Secondary;

				//Normal Element-----
				e = new GmdcElement(Gmdc);
				g.Elements.Add(e);
				e.Identity = ElementIdentity.Normal;
				e.BlockFormat = BlockFormat.ThreeFloat;
				e.SetFormat = SetFormat.Secondary;

				//UVCoord Element-----
				e = new GmdcElement(Gmdc);
				g.Elements.Add(e);
				e.Identity = ElementIdentity.UVCoordinate;
				e.BlockFormat = BlockFormat.TwoFloat;
				e.SetFormat = SetFormat.Secondary;				
				
				g.Group.Name = k;
				g.Group.PrimitiveType = 0x2;
				BuildGroup(g);

				grps.Add(g);
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
						g.Elements[0].Values.Add(vertices[v-1]);
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
							g.Elements[1].Values.Add(normals[vn-1]);
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
							g.Elements[2].Values.Add(uvmaps[vt-1]);	
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
							g.Elements[0].Values.Add(vertices[v-1]);
						}

						if (!newvn && vn>0)
						{
							lvn.Add(g.Elements[1].Values.Count);
							g.Elements[1].Values.Add(normals[vn-1]);
						}

						if (!newvt && vt>0) 
						{
							lvt.Add(g.Elements[2].Values.Count);
							g.Elements[2].Values.Add(uvmaps[vt-1]);
						}	
					
						if (g.Elements[0].Values.Count!=g.Elements[1].Values.Count || g.Elements[0].Values.Count!=g.Elements[2].Values.Count)
							throw new Exception("Element Lists are out of Sync");

						g.Group.Faces.Add(g.Elements[0].Values.Count-1);
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			int size = int.MaxValue;
			//if we have an empty map, we will not add that section to the Link Element!
			if (valias.Keys.Count>0) 
			{
				g.Link.Items1.Add(0);
				size = Math.Min(size, valias.Count);
			}
			if (vnalias.Keys.Count>0) 
			{
				g.Link.Items1.Add(1);				
				size = Math.Min(size, vnalias.Count);
			}
			if (vtalias.Keys.Count>0) 
			{
				g.Link.Items1.Add(2);
				size = Math.Min(size, vtalias.Count);	
			}

			if (size==int.MaxValue) size=0;
			g.Link.ReferencedSize = size;
			g.Link.ActiveElements = g.Link.Items1.Count;

			g.Elements[0].Number = g.Elements[0].Values.Count;
			g.Elements[1].Number = g.Elements[1].Values.Count;
			g.Elements[2].Number = g.Elements[2].Values.Count;
		}

		/// <summary>
		/// Initializes the Group, face, vertex, normals and uv Lists
		/// </summary>
		void LoadLists()
		{
			error = "";			
			vertices = new ArrayList();
			normals = new ArrayList();
			uvmaps = new ArrayList();

			//Begin with a global Group
			groups = new Hashtable();
			StartGroup("SimPEGlobal");
			
			int linect = 0;

			while (Input.Peek()!=-1) 
			{
				linect++;
				string line = Input.ReadLine();
				string oline = line;

				//cut off comments
				int pos = line.IndexOf("#");
				if (pos>=0) line = line.Substring(0, pos);
				line = line.Trim().ToLower();
				
				pos = line.IndexOf(" ");
				string content = "";
				if (pos!=-1) 
				{
					content = line.Substring(pos+1).Trim();
					line = line.Substring(0, pos).Trim();
				}

				if (content.Trim()=="") continue;

				//remove double whitespaces
				while (content.IndexOf("  ")!=-1) content = content.Replace("  ", " ");

				lineerror = null;
				
				if (line == "v") ParseTriplets(vertices, content); //Vertex
				else if (line == "vn") ParseTriplets(normals, content); //Vertex Normal
				else if (line == "vt") ParsePair(uvmaps, content); // Vertex Texture
				else if (line == "g") StartGroup(content);  // new Group
				else if (line == "f") ProcessFaceList(content); // Face
				else if (Helper.WindowsRegistry.HiddenMode) lineerror = "Unknown token.";


				if (lineerror!=null) 
				{
					error += "Line "+linect.ToString()+": "+lineerror+" ("+oline+")"+Helper.lbr;
				}
			}
		}

		/// <summary>
		/// Pares a Line containing three Float Values and add them to the given List
		/// </summary>
		/// <param name="list"></param>
		/// <param name="line"></param>
		void ParseTriplets(ArrayList list, string line)
		{
			string[] tokens = line.Split(" ".ToCharArray());
			if (tokens.Length==3) 
			{
				float[] data = new float[3];
				try 
				{
					for (int i=0; i<3; i++) 
						data[i] = Convert.ToSingle(tokens[i], AbstractGmdcImporter.DefaultCulture);

					SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat v = new GmdcElementValueThreeFloat(data[0], data[1], data[2]);
					list.Add(v);
				} 
				catch 
				{				
					lineerror = "Unable to pares float Value.";
					return;
				}
			} 
			else 
			{
				lineerror = "No FloatTriplet line";
			}
		}

		/// <summary>
		/// Pares a Line containing three Float Values and add them to the given List
		/// </summary>
		/// <param name="list"></param>
		/// <param name="line"></param>
		void ParsePair(ArrayList list, string line)
		{
			string[] tokens = line.Split(" ".ToCharArray());
			if (tokens.Length==2) 
			{
				float[] data = new float[2];
				try 
				{
					for (int i=0; i<2; i++) data[i] = Convert.ToSingle(tokens[i], AbstractGmdcImporter.DefaultCulture);

					SimPe.Plugin.Gmdc.GmdcElementValueTwoFloat v = new GmdcElementValueTwoFloat(data[0], data[1]);
					list.Add(v);
				} 
				catch
				{
					lineerror = "Unable to pares float Value.";
					return;
				}
			} 
			else 
			{
				lineerror = "No FloatPair line";
			}
		}

		/// <summary>
		/// Start a new Group
		/// </summary>
		/// <param name="name"></param>
		void StartGroup(string name) 
		{			
			//make the name unique
			if (groups.Contains(name))
			{
				int i=1;
				while (groups.Contains(name+"_"+i.ToString())) { i++; }
				lineerror = "Duplicate Groupname. Changed "+name+" to ";
				name += "_"+i.ToString();
				lineerror += name;
			}

			groupname = name;
			faces = new ArrayList();
			groups[groupname] = faces;
		}

		/// <summary>
		/// Pares a Face Line
		/// </summary>
		/// <param name="content"></param>
		void ProcessFaceList(string content)
		{
			string[] tokens = content.Split(" ".ToCharArray());
			if (tokens.Length==3) 
			{
				
				try 
				{
					for (int i=0; i<3; i++) 
					{
						float[] data = new float[3];
						data[0] = 0; data[1] = 0; data[2] = 0;

						string[] items = tokens[i].Split("/".ToCharArray());
						for (int j=0; j<Math.Min(items.Length, 3); j++) 
						{
							if (items[j].Trim()=="") items[j] = "0";
							data[j] = Convert.ToInt32(items[j]);
						}
						SimPe.Plugin.Gmdc.GmdcElementValueThreeFloat v = new GmdcElementValueThreeFloat(data[0], data[1], data[2]);
						faces.Add(v);
					}					
				} 
				catch 
				{
					lineerror = "Unable to pares index Value.";
					return;
				}
			} 
			else 
			{
				lineerror = "No Face List line";
			}
		}
	}
}
