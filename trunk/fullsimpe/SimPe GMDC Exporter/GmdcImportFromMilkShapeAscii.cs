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
using SimPe.Plugin.Anim;

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
			get {return "Milkshape 3D ASCII";}
		}		

		/// <summary>
		/// Returns the name of the Author
		/// </summary>
		public override string Author
		{
			get {return "Emily";}
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
			bones = new ImportedBones();
			LineParser(grps);
			return grps;
		}

		ImportedBones bones;
		/// <summary>
		/// This Method is called during the Import to process the input Data and 
		/// showl generate a List of all Bones that should be Imported.
		/// </summary>
		/// <returns>A List of all available Bones</returns>
		/// <remarks>You can use the <see cref="Input"/> and <see cref="Gmdc"/> Member to acces the Stream and 
		/// the Gmdc File that should be changed</remarks>
		protected override ImportedBones LoadBones() 
		{
			return bones;
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
						int ct = 0;
						try 
						{
							ct = Convert.ToInt32(linetoks[1]);							
						} 
						catch 
						{
							lineerror = "Unable to Convert to Number (LineParser:meshes)";
							return ;
						}

						try 
						{
							ParseMeshSection(grps, ct);
						}
						catch(Exception ex) 
						{
							lineerror = ex.Message;
						}
					}

					//Now this is our queue :)
					if (linetoks[0].ToLower() == "bones:") 
					{
						int ct = 0;
						try 
						{
							ct = Convert.ToInt32(linetoks[1]);
							
						} 
						catch 
						{
							lineerror = "Unable to Convert to Number (LineParser:bones)";
							return;
						}

						try 
						{
							ParseBonesSection(grps, ct);
						} 
						catch(Exception ex) 
						{
							lineerror = ex.Message;
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
				lineerror = "Unable to Convert to Number (ReadCount)";
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
				e.BlockFormat = BlockFormat.OneFloat;
				e.SetFormat = SetFormat.Secondary;

				//Read the Mesh Data
				ReadMeshDescription(g);	
				int vertcount = ReadCount();
				for (int k=0; k<vertcount; k++) ReadVertexData(g);

				int vertnormcount = ReadCount();
				for (int k=0; k<vertnormcount; k++) ReadVertexNormalData(g);

				int facecount = ReadCount();
				for (int k=0; k<facecount; k++) ReadFaceData(g);
				
				RemoveDuplicates(g);
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
				Vector3f coord = new Vector3f(
						Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture),
						Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture),
						Convert.ToSingle(linetoks[3], AbstractGmdcImporter.DefaultCulture)
					);
				coord = Component.InverseTransformScaled(coord);

				float u = Convert.ToSingle(linetoks[4], AbstractGmdcImporter.DefaultCulture);
				float v = Convert.ToSingle(linetoks[5], AbstractGmdcImporter.DefaultCulture);
				int b = Convert.ToInt32(linetoks[6]);
				if (b!=-1) 
				{					
					if (!g.Group.UsedJoints.Contains(b)) 
					{
						g.Group.UsedJoints.Add(b);
						//get real Bone Index
						b = g.Group.UsedJoints.Length-1;
					} 
					else 
					{
						//get real Bone Index
						for (int i=0; i< g.Group.UsedJoints.Length; i++)
							if (g.Group.UsedJoints[i] == b) 
							{
								b = i;
								break;
							}
					}
				}

				b = b&0xFF;
				b = (int)((uint)b|0xFFFFFF00);
				
				g.Elements[0].Values.Add(new Gmdc.GmdcElementValueThreeFloat((float)coord.X, (float)coord.Y, (float)coord.Z));
				g.Elements[2].Values.Add(new Gmdc.GmdcElementValueTwoFloat(u, v));	
				g.Elements[3].Values.Add(new Gmdc.GmdcElementValueOneInt(b));
				g.Elements[4].Values.Add(new Gmdc.GmdcElementValueOneFloat((float)1.0));			
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number (ReadVertexData)";
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
				Vector3f coord = new Vector3f(
					Convert.ToSingle(linetoks[0], AbstractGmdcImporter.DefaultCulture),
					Convert.ToSingle(linetoks[1], AbstractGmdcImporter.DefaultCulture),
					Convert.ToSingle(linetoks[2], AbstractGmdcImporter.DefaultCulture)
					);
				coord = Component.InverseTransformNormal(coord);
				
				g.Elements[1].Values.Add(new Gmdc.GmdcElementValueThreeFloat((float)coord.X, (float)coord.Y, (float)coord.Z));
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number (ReadVertexNormalData)";
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
				lineerror = "Unable to Convert to Number (ReadFaceData)";
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
			SimPe.IntArrayList sort = Gmdc.SortJoints();
			for (int i=0; i<ct; i++)
			{
				ImportedBone b = new ImportedBone(Gmdc);
				b.TargetIndex = sort[i];
				b.Action = GmdcImporterAction.Replace;

				//Read the Bones Data
				ReadJointDescription(b);

				ReadJointData(b);

				int poscount = ReadCount();
				for (int k=0; k<poscount; k++) ReadJointPosPhase(b, k, poscount);

				int rotcount = ReadCount();
				for (int k=0; k<rotcount; k++) ReadJointRotPhase(b, k, rotcount);

				bones.Add(b);
			}
		}

		SimPe.Plugin.Anim.AnimationFrameBlock curtransblock, currotblock;
		void ReadJointDescription(ImportedBone b)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<1) 
			{
				lineerror = "Unable to read Joint Description.";
				return;
			}
			linetoks[0] = linetoks[0].Replace("\"", "");
			b.ImportedName = linetoks[0];

			linetoks = GetNonEmptyTokens();
			if (linetoks.Length<1) 
			{
				lineerror = "Unable to read Joint Description.";
				return;
			}
			linetoks[0] = linetoks[0].Replace("\"", "");
			b.ParentName = linetoks[0];

			//Animations
			if (this.AnimationBlocks!=null && Gmdc.LinkedAnimation!=null) 
			{
				curtransblock = null; currotblock = null;

				ImportedFrameBlock ifb = new ImportedFrameBlock(new AnimationFrameBlock(Gmdc.LinkedAnimation));
				
				
				ifb.FrameBlock.Name = b.ImportedName;
				ifb.FindTarget(Gmdc.LinkedAnimation);
				if (ifb.Target!=null) 	
				{			
					ifb.FrameBlock.TransformationType = ifb.Target.TransformationType;					

					if (ifb.FrameBlock.TransformationType==FrameType.Translation) curtransblock = ifb.FrameBlock;
					else currotblock = ifb.FrameBlock;
				}
				else 
				{
					ifb.FrameBlock.TransformationType = FrameType.Rotation;
					if (b.ImportedName.EndsWith("_rot")) 
					{
						ifb.FrameBlock.TransformationType = FrameType.Rotation;
						currotblock = ifb.FrameBlock;
					}
					else if (b.ImportedName.EndsWith("_trans")) 
					{
						ifb.FrameBlock.TransformationType = FrameType.Translation;
						curtransblock = ifb.FrameBlock;
					} 
					else 
					{
						currotblock = ifb.FrameBlock;
						ifb.FrameBlock.CreateBaseAxisSet(AnimationTokenType.SixByte);
						this.AnimationBlocks.Add(ifb);	

						ifb = new ImportedFrameBlock(new AnimationFrameBlock(Gmdc.LinkedAnimation));
						ifb.FrameBlock.TransformationType = FrameType.Translation;
						ifb.FrameBlock.Name = b.ImportedName;
						curtransblock = ifb.FrameBlock;
					}					
				}
				
				ifb.FrameBlock.CreateBaseAxisSet(AnimationTokenType.SixByte);

				

				this.AnimationBlocks.Add(ifb);						
			}

			//if (curanimblock==null) curanimblock = new SimPe.Plugin.AnimBlock2();
		}	

		void ReadJointData(ImportedBone b)
		{
			string[] linetoks = GetNonEmptyTokens();
			if (linetoks.Length<7) 
			{
				lineerror = "Unable to read Joint Line.";
				return;
			}

			try 
			{
				Vector3f trans = new Vector3f(
					ToDouble(linetoks[1]),
					ToDouble(linetoks[2]),
					ToDouble(linetoks[3])
					);
				trans = Component.InverseTransformScaled(trans);
				
				Vector3f rot = new Vector3f(
					ToDouble(linetoks[4]),
					ToDouble(linetoks[5]),
					ToDouble(linetoks[6])
					);
				Quaternion q = Quaternion.FromEulerAngles(rot);
				rot = Component.InverseTransform(q.Axis);
				
				
							
				//Quaternion from Euler Angles
				b.Transformation.Translation = trans;
				b.Transformation.Rotation = SimPe.Geometry.Quaternion.FromAxisAngle(rot, q.Angle);	
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number(ReadJointData)";
			}
		}

		
		void ReadJointPosPhase(ImportedBone b, int index, int count)
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
				bool isscaled = (t==-1);
				t = Math.Max(0, t - 1);
				Vector3f trans = new Vector3f(
					ToDouble(linetoks[1]),
					ToDouble(linetoks[2]),
					ToDouble(linetoks[3])
					);

				trans = Component.InverseTransformScaled(trans);				

				if (curtransblock!=null)
				{
					
					//Brand this Block as Translation (ignoring all rotations!)
					if (curtransblock.TransformationType==FrameType.Unknown) 							
						curtransblock.TransformationType=FrameType.Translation;						
										

					//only process if the Block Type is Translation
					if (curtransblock.TransformationType==FrameType.Translation) 
					{
						if (isscaled && index==0) 
							for (int i=0; i<curtransblock.AxisCount; i++)
								curtransblock.AxisSet[i].Locked = true;

						curtransblock.AddFrame((short)t, trans, false);			
					}
				}
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number (ReadJointPosPhase)";
			}
		}

		void ReadJointRotPhase(ImportedBone b, int index, int count)
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
				bool isscaled = (t==-1);
				t = Math.Max(0, t - 1);
				Vector3f rot = new Vector3f(
					ToDouble(linetoks[1]),
					ToDouble(linetoks[2]),
					ToDouble(linetoks[3])
					);
				
				Quaternion q = Quaternion.FromEulerAngles(rot);
				rot = q.Axis;
				rot = Component.InverseTransform(rot);
				q = Quaternion.FromAxisAngle(rot, q.Angle);
				rot = q.GetEulerAngles();

				if (currotblock!=null)
				{
					//Brand this Block as Rotation (ignoring all Translation!)
					if (currotblock.TransformationType==FrameType.Unknown) 					
						currotblock.TransformationType=FrameType.Rotation;						
					
					

					//only process if the Block Type is Rotation
					if (currotblock.TransformationType==FrameType.Rotation) 
					{
						if (isscaled && index==0) 
							for (int i=0; i<currotblock.AxisCount; i++)
								currotblock.AxisSet[i].Locked = true;

						currotblock.AddFrame((short)t, rot, false);
					}
					
				}
			} 
			catch 
			{
				lineerror = "Unable to Convert to Number (ReadJointRotPhase)";
			}
		}
		#endregion

		#region Optimize
		/// <summary>
		/// True if the values stored in the three AliasMaps at 
		/// the passed indices are the same
		/// </summary>
		/// <param name="g">The Group</param>
		/// <param name="i1">first Index</param>
		/// <param name="i2">second Index</param>
		/// <returns>true if they are the same</returns>
		bool EqualIndices(ImportedGroup g, int i1, int i2)
		{
			for (int i=0; i<g.Link.AliasValues.Length; i++)
				if (g.Link.AliasValues[i][i1]!=g.Link.AliasValues[i][i2]) return false;

			return true;
		}

		/// <summary>
		/// Checks if we have to use the Alias Table
		/// </summary>
		/// <param name="g"></param>
		/// <returns>true, if we need it</returns>
		bool UseAliasTables(ImportedGroup g)
		{
			for (int k=1; k<g.Link.AliasValues.Length; k++) 			
				for (int i=0; i<g.Link.AliasValues[0].Length; i++) 
					if (g.Link.AliasValues[k-1][i]!=g.Link.AliasValues[k][i]) return true;
								
			return false;
		}

		/// <summary>
		/// Removes the AliasTables and replaces them with direct Indexing
		/// </summary>
		/// <param name="g"></param>
		void RemoveAliasTables(ImportedGroup g) 
		{
			for (int i=0; i<g.Group.Faces.Length; i++)
			{
				int k = g.Group.Faces[i];
				k = g.Link.AliasValues[0][k];

				g.Group.Faces[i] = k;
			}

			for (int k=0; k<g.Link.AliasValues.Length; k++) 
				g.Link.AliasValues[k].Clear();
		}

		/// <summary>
		/// This will reduce the Vertex Count
		/// </summary>
		/// <param name="g"></param>
		void RemoveDuplicates(ImportedGroup g)
		{			
			//list the old index an the new one
			Hashtable map = new Hashtable();

			//contains a List of all location where equal coords are stored
			Hashtable eqmap = new Hashtable();
			//keeps the real indices for the new List
			Hashtable offsetmap = new Hashtable();

			//stores a list of all Indices that should be removed
			ArrayList remove = new ArrayList();

			int offset = 0;
			for (int i=0; i<g.Link.AliasValues[0].Length; i++)
			{
				int v = g.Link.AliasValues[0][i];
				int vn = g.Link.AliasValues[1][i];
				int vt = g.Link.AliasValues[2][i];

				ulong hash = ( (((uint)v & 0x3FFFFF) << 21) | ((uint)vn & 0x3FFFFF) << 21) | ((uint)vt & 0x3FFFFF);

				ArrayList list = null;
				bool found = false;
				if (!eqmap.ContainsKey(hash)) 
				{
					list = new ArrayList();
					eqmap.Add(hash, list);
				}
				else 
				{
					list = (ArrayList)eqmap[hash];

					foreach(int k in list) 
					{
						if (EqualIndices(g, i, k)) 
						{
							remove.Add(i);							
							map[i] = k+(int)offsetmap[k];
							//make sure each entry is only added once
							found = true;
							//keep following indices in sync.
							offset--;
						}
					}
				}
			
				if (!found) 
				{
					list.Add(i);
					if (offset!=0) map[i] = i+offset;
					offsetmap[i] = offset;
				}


			}

			//remove the unused references
			for (int k=0; k<g.Link.AliasValues.Length; k++) 
			{
				for (int j=remove.Count-1; j>=0; j--)
				{				
					int i = (int)remove[j];
					g.Link.AliasValues[k].RemoveAt(i);
				}
			}



			//Adjust the face List
			for (int i=0; i<g.Group.Faces.Count; i++) 
			{
				if (map.ContainsKey((int)g.Group.Faces[i])) 
				{
					int v = (int)map[(int)g.Group.Faces[i]];
					g.Group.Faces[i] = v;
				}
			}	
			
			//Check if we can remove the Alias Tables
			if (!UseAliasTables(g)) 
			{
				RemoveAliasTables(g);
			}
		}
		#endregion
	}
}
