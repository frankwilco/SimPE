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
using System.Collections;
using SimPe.Geometry;
using SimPe.Plugin.Anim;
using Ambertation.Collections;
using Ambertation.Scenes;
using Ambertation.Scenes.Collections;

namespace SimPe.Plugin
{
	/// <summary>
	/// This class contains the Geometric Data of an Object
	/// </summary>
	public class GeometryDataContainerExt 
	{
		GeometryDataContainer gmdc;
		public GeometryDataContainerExt(GeometryDataContainer gmdc) 
		{
			this.gmdc = gmdc;
		}		

		public Ambertation.Scenes.Scene GetScene(string absimgpath, string imgfolder)
		{
			return GetScene(gmdc.Groups, absimgpath, imgfolder);
		}

		public Ambertation.Scenes.Scene GetScene(string absimgpath)
		{
			return GetScene(gmdc.Groups, absimgpath, null);
		}

		public Ambertation.Scenes.Scene GetScene()
		{
			return GetScene(gmdc.Groups, null, null);
		}

		void AddJoint(Ambertation.Scenes.Joint parent, int index, Hashtable jointmap, ElementOrder component)
		{
			GmdcJoint j = gmdc.Joints[index];
			Ambertation.Scenes.Joint nj = parent.CreateChild(j.Name);
			jointmap[index] = nj;
			
			if (j.AssignedTransformNode != null)
			{
				Vector3f tmp =  j.AssignedTransformNode.Transformation.Translation;
				tmp = component.TransformScaled(tmp);			
				
				nj.Translation.X = tmp.X; nj.Translation.Y = tmp.Y; nj.Translation.Z = tmp.Z;

				Quaternion q = j.AssignedTransformNode.Transformation.Rotation;
				/*Matrixd m = component.TransformMatrix*q.Matrix.To33Matrix();
				q = Quaternion.FromRotationMatrix(m);*/
				Vector3f r = q.Axis;
				r = component.Transform(r);
				q = Quaternion.FromAxisAngle(r, q.Angle);	
				tmp = q.GetEulerAngles();
				nj.Rotation.X = tmp.X; nj.Rotation.Y = tmp.Y; nj.Rotation.Z = tmp.Z;

				IntArrayList li = j.AssignedTransformNode.ChildBlocks;
				foreach (int i in li)
				{
					SimPe.Interfaces.Scenegraph.ICresChildren cld = j.AssignedTransformNode.GetBlock(i);
					if (cld is TransformNode)
					{
						TransformNode tn = cld as TransformNode;
						if (tn.JointReference!=TransformNode.NO_JOINT)						
							AddJoint(nj, tn.JointReference, jointmap, component);						
					}
				}
			}
		}

		Hashtable AddJointsToScene(Scene scn, ElementOrder component)
		{
			IntArrayList js = new IntArrayList();
			Hashtable relationmap = gmdc.LoadJointRelationMap();
			foreach (int k in relationmap.Keys)
				if ((int)relationmap[k]==-1)
					js.Add(k);
			
			Hashtable jointmap = new Hashtable();
			foreach (int index in js)
				AddJoint(scn.RootJoint, index, jointmap, component);

			return jointmap;
		}	
	
		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups)
		{
			return GetScene(groups, null, null);
		}

		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups, string absimgpath)
		{
			return GetScene(groups, absimgpath, null);
		}

		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups, string absimgpath, string imgfolder)
		{
			if (absimgpath!=null) 
			{
				if (imgfolder==null) imgfolder=absimgpath;
				imgfolder = imgfolder.Trim();
				if (imgfolder.Length>0 && !imgfolder.EndsWith(@"\")) imgfolder += @"\";

				if (!System.IO.Directory.Exists(absimgpath)) System.IO.Directory.CreateDirectory(absimgpath);
			}

			ElementOrder component = new ElementOrder(ElementSorting.XZY);
			Scene scn = new Scene();

			Hashtable jointmap = AddJointsToScene(scn, component);
			
						
			TextureLocator tl = new TextureLocator(gmdc.Parent.Package);
			System.Collections.Hashtable txtrs = tl.GetLargestImages(tl.FindTextures(gmdc.Parent));

			foreach (GmdcGroup g in groups)
			{
				
				Ambertation.Scenes.Material mat = scn.CreateMaterial("mat_"+g.Name);
				System.IO.MemoryStream s = txtrs[g.Name] as System.IO.MemoryStream;
				if (s!=null && absimgpath!=null) 
				{
					try
					{
						System.Drawing.Image img = System.Drawing.Image.FromStream(s);
						img.Save(System.IO.Path.Combine(absimgpath, g.Name+".png"), System.Drawing.Imaging.ImageFormat.Png);
						mat.Texture.FileName = imgfolder+g.Name+".png";
						mat.Texture.ImageSize = img.Size;
					} 
					catch {}
				}
				Ambertation.Scenes.Mesh m = scn.CreateMesh(g.Name, mat);

				GmdcElement vertexe = g.Link.FindElementType(ElementIdentity.Vertex);
				GmdcElement normale = g.Link.FindElementType(ElementIdentity.Normal);
				GmdcElement texte = g.Link.FindElementType(ElementIdentity.UVCoordinate);
				GmdcElement bonee = g.Link.FindElementType(ElementIdentity.BoneAssignment);
				GmdcElement bonewighte = g.Link.FindElementType(ElementIdentity.BoneWeights);

				int nr = g.Link.GetElementNr(vertexe);
				for (int i = 0; i < g.Link.ReferencedSize; i++)
				{
					Vector3f v = new Vector3f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1], g.Link.GetValue(nr, i).Data[2]);				
					v = component.TransformScaled(v);
					
					m.Vertices.Add(v.X, v.Y, v.Z);
				}

				if (normale!=null)
				{
					nr = g.Link.GetElementNr(normale);
					for (int i = 0; i < g.Link.ReferencedSize; i++)
					{
						Vector3f v = new Vector3f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1], g.Link.GetValue(nr, i).Data[2]);				
						v = component.TransformNormal(v);						
						m.Normals.Add(v.X, v.Y, v.Z);
					}
				}

				if (texte!=null)
				{
					nr = g.Link.GetElementNr(texte);
					for (int i = 0; i < g.Link.ReferencedSize; i++)
					{
						Vector2f v = new Vector2f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1]);				
						m.TextureCoordinates.Add(v.X, 1-v.Y);
					}
				}
					
				for (int i = 0; i < g.Faces.Count-2; i+=3)				
					m.FaceIndices.Add(g.Faces[i], g.Faces[i+1], g.Faces[i+2]);
				
				if (bonee!=null && true)
				{
					int pos = 0;
					foreach (SimPe.Plugin.Gmdc.GmdcElementValueOneInt vi in bonee.Values)
					{
						byte[] data = vi.Bytes;
						IntArrayList used = new IntArrayList();
						
						for (int datapos=0; datapos<3; datapos++) //we can only store 3 bone weights
						{
							byte b = data[datapos];
							if (b!=0xff && b< g.UsedJoints.Count)
							{
								
								int bnr = g.UsedJoints[b];
								if (used.Contains(bnr))
									Console.WriteLine("...");

								used.Add(bnr);
								Ambertation.Scenes.Joint nj = jointmap[bnr] as Ambertation.Scenes.Joint;
								if (nj!=null)
								{
									double w = 1;
									if (bonewighte!=null)
										if (bonewighte.Values.Count>pos) 
										{
											SimPe.Plugin.Gmdc.GmdcElementValueBase v = bonewighte.Values[pos];
											if (datapos< v.Data.Length)
											{
												w = v.Data[datapos];
											}
										}

									//if there is no envelope for nj, make sure we get a new one
									//with pos 0-Weights inserted
									Ambertation.Scenes.Envelope e = m.GetJointEnvelope(nj, pos);
									e.Weights.Add(w);
									//added = true;
								}
							}
						}
						
						pos ++;
						m.SyncEnvelopeLenghts(pos); //fill all unset EnvelopeWeights with 0

						if (m.Envelopes[0].Weights.Count!=pos)
							Console.WriteLine("out of sync");
						
					} // bonee.Values
					
				}
				
			}

			return scn;
		}
	}
}
