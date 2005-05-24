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

namespace SimPe.Plugin.Gmdc.Importer
{
	/// <summary>
	/// This class provides the functionality to Import Data from the MilkShape AscII Formats
	/// </summary>	
	public class GmdcImportFromMilkShapeAscii : AbstractGmdcImporter
	{		
		/// <summary>
		/// default Constructor
		/// </summary>		
		public GmdcImportFromMilkShapeAscii() : base() {}

		#region AbstractGmdcImporter Implementation
		/// <summary>
		/// Returns the suggested File Extension (including the . like .obj or .3ds)
		/// </summary>
		public override string FileExtension
		{
			get {return ".txt";}
		}

		/// <summary>
		/// Returns the File Description (the Name of the exported FileType)
		/// </summary>
		public override string FileDescription
		{
			get {return "Milkshape ASCII File";}
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
			LineParser(grps);
			return grps;
		}
		#endregion

		int linect;
		string lastline, lineerror;

		/// <summary>
		/// Prepare one input Line for parsing
		/// </summary>
		/// <returns></returns>
		string[] GetTokens()
		{
			if (lineerror!=null) error += "Line "+linect.ToString()+": "+lineerror+" ("+lastline+")"+Helper.lbr;
			lineerror = null;
			if (Input.Peek()==-1) return null;


			linect++;
			string line = Input.ReadLine();
			lastline = line;

			//cut off comments
			int pos = line.IndexOf("//");
			if (pos>=0) line = line.Substring(0, pos);
			line = line.Trim().ToLower();
			while (line.IndexOf("  ")!=-1) line = line.Replace("  ", " ");
							
			if (line.Trim()=="") return new string[0];
			string[] linetoks = line.Split(" ".ToCharArray());			
			return linetoks;
		}

		/// <summary>
		/// Prepare one input Line for parsing (will read until it finds a Line with content)
		/// </summary>
		/// <returns></returns>
		string[] GetNonEmptyTokens()
		{
			string[] linetoks = GetTokens();
			if (linetoks==null) return new string[0];
			while (linetoks.Length==0) 
			{
				linetoks = GetTokens();
				if (linetoks==null) return new string[0];
			}

			return linetoks;
		}
		/// <summary>
		/// Start the Parsing of A File
		/// </summary>
		/// <param name="grps"></param>
		void LineParser(ImportedGroups grps) 
		{					
			linect = 0;
			error = "";	
			lastline = "";
			lineerror = null;
			string[] linetoks = GetTokens();
			while (linetoks!=null)
			{				
				if (linetoks.Length>0) 
				{
					//Now this is our queue :)
					if (linetoks[0].ToLower() == "meshes:") 
					{
						try 
						{
							int ct = Convert.ToInt32(linetoks[1]);
							ParseMeshSection(grps, ct);
						} 
						catch 
						{
							lineerror = "Unable to Convert to Number";
						}
					}

					//Now this is our queue :)
					if (linetoks[0].ToLower() == "bones:") 
					{
						try 
						{
							int ct = Convert.ToInt32(linetoks[1]);
							ParseBonesSection(grps, ct);
						} 
						catch 
						{
							lineerror = "Unable to Convert to Number";
						}
					}
				}

				linetoks = GetTokens();
			}
		}

		/// <summary>
		/// Reads a Single Integer
		/// </summary>
		/// <returns></returns>
		int ReadCount()
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<1) 
			{
				lineerror = "Unable to read Count.";
				return 0;
			}

			try 
			{
				int ct = Convert.ToInt32(linetoks[0]);
				return ct;
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
			
			return 0;
		}

		#region Meshes Section
		/// <summary>
		/// Parses the complete Mesh Section
		/// </summary>
		/// <param name="grps"></param>
		/// <param name="ct"></param>
		void ParseMeshSection(ImportedGroups grps, int ct) 
		{
			for (int i=0; i<ct; i++)
			{
				ImportedGroup g = this.PrepareGroup();
				

				//BoneLinks-----
				GmdcElement e = new GmdcElement(Gmdc);
				g.Elements.Add(e);
				e.Identity = ElementIdentity.BoneAssignment;
				e.BlockFormat = BlockFormat.OneDword;
				e.SetFormat = SetFormat.Secondary;				

				//BoneWeights-----
				e = new GmdcElement(Gmdc);
				g.Elements.Add(e);
				e.Identity = ElementIdentity.BoneWeights;
				e.BlockFormat = BlockFormat.OneDword;
				e.SetFormat = SetFormat.Secondary;

				//Read the Mesh Data
				ReadMeshDescription(g);	
				int vertcount = ReadCount();
				for (int k=0; k<vertcount; k++) ReadVertexData(g);

				int vertnormcount = ReadCount();
				for (int k=0; k<vertnormcount; k++) ReadVertexNormalData(g);

				int facecount = ReadCount();
				for (int k=0; k<facecount; k++) ReadFaceData(g);

				
				
				grps.Add(g);
			}
		}

		void ReadMeshDescription(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<3) 
			{
				lineerror = "Unable to read Mesh Description.";
				return;
			}

			linetoks[0] = linetoks[0].Replace("\"", "");
			g.Group.Name = linetoks[0];
		}		

		void ReadVertexData(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<7) 
			{
				lineerror = "Unable to read Vertex Line.";
				return;
			}

			try 
			{
				float x = Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture);
				float y = Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture);
				float z = Convert.ToSingle(linetoks[3], AbstractGmdcImporter.DefaultCulture);
				float u = Convert.ToSingle(linetoks[4], AbstractGmdcImporter.DefaultCulture);
				float v = Convert.ToSingle(linetoks[5], AbstractGmdcImporter.DefaultCulture);
				int b = Convert.ToInt32(linetoks[6]);
				if (b!=-1) 
				{
					b += Gmdc.Bones.Count;
					if (!g.Group.UsedBones.Contains(b)) g.Group.UsedBones.Add(b);
				}

				b = b&0xFF;
				b = (int)((uint)b|0xFFFFFF00);
				
				g.Elements[0].Values.Add(new Gmdc.GmdcElementValueThreeFloat(x, y, z));
				g.Elements[2].Values.Add(new Gmdc.GmdcElementValueTwoFloat(u, v));	
				g.Elements[3].Values.Add(new Gmdc.GmdcElementValueOneInt(b));
				g.Elements[4].Values.Add(new Gmdc.GmdcElementValueOneFloat((float)1.0));			
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}

		void ReadVertexNormalData(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<3) 
			{
				lineerror = "Unable to read Normal Line.";
				return;
			}

			try 
			{
				float x = Convert.ToSingle(linetoks[0], AbstractGmdcImporter.DefaultCulture);
				float y = Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture);
				float z = Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture);
				
				g.Elements[1].Values.Add(new Gmdc.GmdcElementValueThreeFloat(x, y, z));
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}

		void ReadFaceData(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<7) 
			{
				lineerror = "Unable to read Face Line.";
				return;
			}

			try 
			{
				int x = Convert.ToInt32(linetoks[1]);
				int y = Convert.ToInt32(linetoks[2]);
				int z = Convert.ToInt32(linetoks[3]);
				int xn = Convert.ToInt32(linetoks[4]);
				int yn = Convert.ToInt32(linetoks[5]);
				int zn = Convert.ToInt32(linetoks[6]);				
				
				g.Link.AliasValues[0].Add(x);
				g.Link.AliasValues[1].Add(xn);
				g.Link.AliasValues[2].Add(x);
				g.Group.Faces.Add(g.Link.AliasValues[0].Count-1);

				g.Link.AliasValues[0].Add(y);
				g.Link.AliasValues[1].Add(yn);
				g.Link.AliasValues[2].Add(y);
				g.Group.Faces.Add(g.Link.AliasValues[1].Count-1);

				g.Link.AliasValues[0].Add(z);
				g.Link.AliasValues[1].Add(zn);
				g.Link.AliasValues[2].Add(z);
				g.Group.Faces.Add(g.Link.AliasValues[2].Count-1);
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}
		#endregion

		#region Bones Section
		/// <summary>
		/// Parses the complete Mesh Section
		/// </summary>
		/// <param name="grps"></param>
		/// <param name="ct"></param>
		void ParseBonesSection(ImportedGroups grps, int ct) 
		{
			for (int i=0; i<ct; i++)
			{
				ImportedGroup g = new ImportedGroup(Gmdc);
				//Read the Bones Data
				ReadJointDescription(g);
				ReadJointData(g);

				int poscount = ReadCount();
				for (int k=0; k<poscount; k++) ReadJointPosPhase(g);

				int rotcount = ReadCount();
				for (int k=0; k<rotcount; k++) ReadJointRotPhase(g);
			}
		}

		void ReadJointDescription(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<1) 
			{
				lineerror = "Unable to read Joint Description.";
				return;
			}
			linetoks[0] = linetoks[0].Replace("\"", "");

			linetoks = GetNonEmptyTokens();
			if (linetoks.Length<1) 
			{
				lineerror = "Unable to read Joint Description.";
				return;
			}
		}	

		void ReadJointData(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<7) 
			{
				lineerror = "Unable to read Joint Line.";
				return;
			}

			try 
			{
				float x = Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture);
				float y = Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture);
				float z = Convert.ToSingle(linetoks[3], AbstractGmdcImporter.DefaultCulture);
				float rx = Convert.ToSingle(linetoks[4], AbstractGmdcImporter.DefaultCulture);
				float ry = Convert.ToSingle(linetoks[5], AbstractGmdcImporter.DefaultCulture);
				float rz = Convert.ToSingle(linetoks[6], AbstractGmdcImporter.DefaultCulture);	
				
				Gmdc.Model.Rotations.Add(new Vector4f(rx, ry, rz, (float)1.0));
				Gmdc.Model.Transformations.Add(new Vector3f(x, y, z));
				Gmdc.Bones.Add(new GmdcBone(Gmdc));
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}

		void ReadJointPosPhase(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<4) 
			{
				lineerror = "Unable to read JointPosition Line.";
				return;
			}

			try 
			{
				float t = Convert.ToSingle(linetoks[0], AbstractGmdcImporter.DefaultCulture);
				float x = Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture);
				float y = Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture);
				float z = Convert.ToSingle(linetoks[3], AbstractGmdcImporter.DefaultCulture);									
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}

		void ReadJointRotPhase(ImportedGroup g)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<4) 
			{
				lineerror = "Unable to read JointRotation Line.";
				return;
			}

			try 
			{
				float t = Convert.ToSingle(linetoks[0], AbstractGmdcImporter.DefaultCulture);
				float x = Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture);
				float y = Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture);
				float z = Convert.ToSingle(linetoks[3], AbstractGmdcImporter.DefaultCulture);									
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number";
			}
		}
		#endregion
	}
}
