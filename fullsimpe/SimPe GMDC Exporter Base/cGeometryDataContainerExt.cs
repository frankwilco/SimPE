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
	public class GeometryDataContainerExt  : System.IDisposable
	{
		GeometryDataContainer gmdc;
        bool joints;
        public GeometryDataContainerExt(GeometryDataContainer gmdc) : this(gmdc, true) { }
		public GeometryDataContainerExt(GeometryDataContainer gmdc, bool withjoints) 
		{
            joints = withjoints;
			this.gmdc = gmdc;
			txtrmap = new Hashtable();
			txmtmap = new Hashtable();
		}	
	
		public GeometryDataContainer Gmdc
		{
			get {return gmdc;}
		}

		Hashtable txtrmap, txmtmap;
		/// <summary>
		/// Used as a User Override for the automatically created List of TXMTs, which is used for 
		/// the Objects Textures
		/// </summary>
		/// <remarks>Keyas are the SubSet Names, the Values are <see cref="GenericRcol"/> Instances, 
		/// that hold the TXMT for that Subset</remarks>
		public Hashtable UserTxtrMap
		{
			get {return txtrmap;}
		}

		/// <summary>
		/// Used as a User Override for the automatically created List of TXTRs, which is used for 
		/// the Objects Textures
		/// </summary>
		/// <remarks>Keyas are the SubSet Names, the Values are <see cref="GenericRcol"/> Instances, 
		/// that hold the TXTR for that Subset</remarks>
		public Hashtable UserTxmtMap
		{
			get {return txmtmap;}
		}

		public Ambertation.Scenes.Scene GetScene(string absimgpath, string imgfolder, ElementOrder component)
		{
			return GetScene(gmdc.Groups, absimgpath, imgfolder, component);
		}

		public Ambertation.Scenes.Scene GetScene(string absimgpath, ElementOrder component)
		{
			return GetScene(gmdc.Groups, absimgpath, null, component);
		}

		public Ambertation.Scenes.Scene GetScene(ElementOrder component)
		{
			return GetScene(gmdc.Groups, null, null, component);
		}

		void AddJoint(Ambertation.Scenes.Joint parent, int index, Hashtable jointmap, ElementOrder component)
		{
            if (!joints) return;
			if (index<0 || index>=gmdc.Joints.Count) return;
			
			GmdcJoint j = gmdc.Joints[index];
			Ambertation.Scenes.Joint nj = parent.CreateChild(j.Name);
			jointmap[index] = nj;
			
			if (j.AssignedTransformNode != null)
			{
				Vector3f tmp =  j.AssignedTransformNode.Transformation.Translation;
				tmp = component.TransformScaled(tmp);			
				//tmp = component.ScaleMatrix * tmp;
				
				nj.Translation.X = tmp.X; nj.Translation.Y = tmp.Y; nj.Translation.Z = tmp.Z;

				Quaternion q = component.TransformRotation(j.AssignedTransformNode.Transformation.Rotation);												
				tmp = q.GetEulerAngles();

				//Console.WriteLine("        "+q.ToLinedString());
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
            if (!joints) return new Hashtable();
			IntArrayList js = new IntArrayList();
			Hashtable relationmap = gmdc.LoadJointRelationMap();            

			foreach (int k in relationmap.Keys)
				if ((int)relationmap[k]==-1)
					js.Add(k);

			Quaternion r = Quaternion.FromRotationMatrix(component.TransformMatrix);
			Vector3f tmp = r.GetEulerAngles();
			scn.RootJoint.Name = "SIMPE_ROOT_IGNORE";
			//scn.RootJoint.Rotation.X = tmp.X; scn.RootJoint.Rotation.Y = tmp.Y; scn.RootJoint.Rotation.Z = tmp.Z; 
			
			Hashtable jointmap = new Hashtable();
			foreach (int index in js)
				AddJoint(scn.RootJoint, index, jointmap, component);

			return jointmap;
		}	
	
		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups, ElementOrder component)
		{
			return GetScene(groups, null, null, component);
		}

		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups, string absimgpath, ElementOrder component)
		{
			return GetScene(groups, absimgpath, null, component);
		}

		public Ambertation.Scenes.Scene GetScene(GmdcGroups groups, string absimgpath, string imgfolder, ElementOrder component)
		{
			if (absimgpath!=null) 
			{
				if (imgfolder==null) imgfolder=absimgpath;
				imgfolder = imgfolder.Trim();
				if (imgfolder.Length>0 && !imgfolder.EndsWith(@"\")) imgfolder += @"\";

				if (!System.IO.Directory.Exists(absimgpath)) System.IO.Directory.CreateDirectory(absimgpath);
			}

			Scene scn = new Scene();

			Hashtable jointmap = new Hashtable();
			try 
			{
				jointmap = AddJointsToScene(scn, component);
			} 
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message+"\n"+ex.StackTrace);
			}
			
								
			TextureLocator tl = new TextureLocator(gmdc.Parent.Package);
			System.Collections.Hashtable txmts = tl.FindMaterials(gmdc.Parent);			
			foreach (string key in txmtmap.Keys)
			{
				object o = txmtmap[key];
				if (o!=null) txmts[key] = txmtmap[key];
			}


			Hashtable txtrs = tl.FindReferencedTXTR(txmts, null);			
			foreach (string key in txtrmap.Keys) 
			{
				object o = txtrmap[key];
				if (o!=null) txtrs[key] = o;
			}

			txtrs = tl.GetLargestImages(txtrs);
			txmts = tl.GetMaterials(txmts, scn);
			tl.Dispose();

			foreach (GmdcGroup g in groups)
			{
				
				Ambertation.Scenes.Material mat = txmts[g.Name] as Ambertation.Scenes.Material;
				if (mat == null) mat = scn.CreateMaterial("mat_"+g.Name);
				else mat.Name = "mat_"+g.Name;
				System.IO.MemoryStream s = txtrs[g.Name] as System.IO.MemoryStream;
				if (s!=null ) 
				{
					try
					{
						System.Drawing.Image img = System.Drawing.Image.FromStream(s);
						if (absimgpath!=null) img.Save(System.IO.Path.Combine(absimgpath, g.Name+".png"), System.Drawing.Imaging.ImageFormat.Png);
						mat.Texture.FileName = imgfolder+g.Name+".png";
						mat.Texture.Size = img.Size;
						mat.Texture.TextureImage = img;
					} 
					catch {}
				}
				Ambertation.Scenes.Mesh m = scn.CreateMesh(g.Name, mat);

				GmdcElement vertexe = g.Link.FindElementType(ElementIdentity.Vertex);
			//	GmdcElement vertexme = g.Link.FindElementType(ElementIdentity.MorphVertexDelta);
				GmdcElement normale = g.Link.FindElementType(ElementIdentity.Normal);
				GmdcElement texte = g.Link.FindElementType(ElementIdentity.UVCoordinate);
				GmdcElement bonee = g.Link.FindElementType(ElementIdentity.BoneAssignment);
				GmdcElement bonewighte = g.Link.FindElementType(ElementIdentity.BoneWeights);
				GmdcElement bumpnormal = g.Link.FindElementType(ElementIdentity.BumpMapNormal);

				int nr = g.Link.GetElementNr(vertexe);
			//	int mnr = g.Link.GetElementNr(vertexme);
				for (int i = 0; i < g.Link.ReferencedSize; i++)
				{
					Vector3f v = new Vector3f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1], g.Link.GetValue(nr, i).Data[2]);				
					/*Vector3f vm = new Vector3f(g.Link.GetValue(mnr, i).Data[0], g.Link.GetValue(mnr, i).Data[1], g.Link.GetValue(mnr, i).Data[2]);				
					v += vm;*/
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

				if (bumpnormal!=null)
				{
					nr = g.Link.GetElementNr(bumpnormal);
					for (int i = 0; i < g.Link.ReferencedSize; i++)
					{
						Vector3f v = new Vector3f(g.Link.GetValue(nr, i).Data[0], g.Link.GetValue(nr, i).Data[1], g.Link.GetValue(nr, i).Data[2]);				
						v = component.TransformNormal(v);						
						m.BumpMapNormalDelta.Add(v.X, v.Y, v.Z);
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
				
				AddEnvelopes(g, m, bonee, bonewighte, jointmap);
				
			}

			return scn;
		}

		void AddEnvelopes(GmdcGroup g, Ambertation.Scenes.Mesh m, GmdcElement bonee, GmdcElement bonewighte, Hashtable jointmap)
		{
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
							if (used.Contains(bnr)) continue;
								

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
				} // bonee.Values
					
			}
		}
		#region IDisposable Member

		public void Dispose()
		{
			txtrmap.Clear();
			txmtmap.Clear();
			gmdc = null;
		}

		#endregion
	}
}
