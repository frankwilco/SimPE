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

namespace SimPe.Plugin.Gmdc.Exporter
{
	/// <summary>
	/// This class provides the functionality to Export Data to the .txt FileFormat
	/// </summary>
	public class GmdcExportToMilkShapeAscii : AbstractGmdcExporter
	{
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="gmdc">The Gmdc File the Export is based on</param>
		/// <param name="groups">The list of Groups you want to export</param>
		/// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .txt File</remarks>
		public GmdcExportToMilkShapeAscii(GeometryDataContainer gmdc, GmdcGroups groups) : base(gmdc, groups) {}
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="gmdc">The Gmdc File the Export is based on</param>
		/// <remarks><see cref="AbstractGmdcExporter.FileContent"/> will contain the Exported .txt File</remarks>
		public GmdcExportToMilkShapeAscii(GeometryDataContainer gmdc) : base(gmdc) {}
		/// <summary>
		/// Default Constructor
		/// </summary>
		/// <remarks>The export has to be started Manual through a call to <see cref="AbstractGmdcExporter.Process"/></remarks>
		public GmdcExportToMilkShapeAscii() : base() {}

		int modelnr, vertexoffset;

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
			
			//When we have a Animation, we need to Set the Frame Count
			if (this.Gmdc.LinkedAnimation!=null) 
			{
				int maxframe = 1;
				//foreach (AnimBlock2 ab2 in Gmdc.LinkedAnimation.Part2)
				//	foreach (AnimationFrame af in ab2.Frames)
				maxframe = Math.Max(maxframe, Gmdc.LinkedAnimation.Animation.TotalTime);				

				writer.WriteLine("Frames: "+maxframe.ToString());
				writer.WriteLine("Frame: 1");
			}

			writer.WriteLine("Meshes: "+this.Groups.Count.ToString());
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
			//Find the BoneAssignment
			GmdcElement boneelement = this.Link.FindElementType(ElementIdentity.BoneAssignment);
			//List of ordered Joints
			IntArrayList js = Gmdc.SortJoints();
							

			writer.WriteLine("\""+Group.Name+"\" 0 -1");

					
			//first, write the availabel Vertices
			int vertexcount = 0;
			int nr = Link.GetElementNr(VertexElement);
			int nnr = -1;
			if (this.UVCoordinateElement!=null) nnr = Link.GetElementNr(UVCoordinateElement);
			writer.WriteLine(Link.ReferencedSize.ToString());

			for (int i = 0; i < Link.ReferencedSize; i++)
			{	
				//Make sure we transform to the desired Coordinate-System
				Vector3f v = new Vector3f(Link.GetValue(nr, i).Data[0], Link.GetValue(nr, i).Data[1], Link.GetValue(nr, i).Data[2]);
				v = Component.TransformScaled(v);

				writer.Write("0 " + 
					v.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " "+
					v.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " "+
					v.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " ");

				if (nnr!=-1) 
				{
					writer.Write(
						(Link.GetValue(nnr, i).Data[0]).ToString("N6", AbstractGmdcExporter.DefaultCulture) + " "+
						(Link.GetValue(nnr, i).Data[1]).ToString("N6", AbstractGmdcExporter.DefaultCulture )+ " ");
				} 
				else 
				{
					writer.Write(" 0.000000 0.000000");
				}


				if (boneelement==null) 
				{
					writer.WriteLine("-1");
				} 
				else 
				{
					int bnr = Link.GetRealIndex(nr, i);
					if (bnr==-1) writer.WriteLine("-1");
					else 
					{
						bnr = ((SimPe.Plugin.Gmdc.GmdcElementValueOneInt)boneelement.Values[bnr]).Value;
						if (bnr == -1) writer.WriteLine("-1");
						else 
						{
							bnr = bnr&0xff;
							bnr = Group.UsedJoints[bnr];
							for (int ij=0; ij<js.Count; ij++)
								if (js[ij]==bnr) { bnr=ij; break; }
							writer.WriteLine(bnr.ToString());
						}
					}
						
				}
			}			
			
			//Add a MeshNormal Section if available
			if (this.NormalElement!=null) 
			{				
				nr = Link.GetElementNr(NormalElement);
				writer.WriteLine(Link.ReferencedSize.ToString());
				for (int i = 0; i < Link.ReferencedSize; i++)
				{
					Vector3f v = new Vector3f(Link.GetValue(nr, i).Data[0], Link.GetValue(nr, i).Data[1], Link.GetValue(nr, i).Data[2]);
					v = Component.TransformNormal(v);
					writer.WriteLine( 
						v.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " "+
						v.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " "+
						v.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture));
				}				
			} 
			else 
			{
				writer.WriteLine("0");
			}
						
			
			//Export Faces
			writer.WriteLine(Group.FaceCount.ToString());
			for (int i = 0; i < Group.Faces.Count; i +=3)
			{
				writer.WriteLine("0 " + 
					Group.Faces[i+0].ToString() + " " +
					Group.Faces[i+1].ToString() + " " +
					Group.Faces[i+2].ToString() + " " +
					Group.Faces[i+0].ToString() + " " +
					Group.Faces[i+1].ToString() + " " +
					Group.Faces[i+2].ToString() + " 1");
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
			writer.WriteLine("Materials: 0");
			
			Hashtable relationmap = Gmdc.LoadJointRelationMap();
			IntArrayList js = Gmdc.SortJoints(relationmap);
			

			//Export Bones
			writer.WriteLine("Bones: "+js.Count.ToString());
			foreach (int i in js)
			{
				if (i>=Gmdc.Model.Transformations.Length) break;
	
				writer.WriteLine("\""+Gmdc.Joints[i].Name+"\"");

				if (relationmap.ContainsKey(i)) 
				{
					int parent = (int)relationmap[i];
					if (parent!=-1) writer.WriteLine("\""+Gmdc.Joints[parent].Name+"\"");
					else writer.WriteLine("\"\"");
				} 
				else writer.WriteLine("\"\"");

				
	
				if (Gmdc.Joints[i].AssignedTransformNode!=null) 
				{		

					Vector3f t = Component.Transform(Gmdc.Joints[i].AssignedTransformNode.Translation);
					Vector3f r = Component.Transform(Gmdc.Joints[i].AssignedTransformNode.Rotation.GetEulerAngles());
						
/*					t = Gmdc.Model.Transformations[i].Translation;
					r = Gmdc.Model.Transformations[i].Rotation.GetEulerAngles();*/

					t = Component.Scale(t);
					writer.WriteLine("8 " + 
						t.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
						t.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
						t.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
						r.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
						r.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
						r.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture));
				} 
				else writer.WriteLine("8 0 0 0 0 0 0");

				
				
				

				if (Gmdc.LinkedAnimation!=null) 
				{
					AnimBlock2 ab = Gmdc.LinkedAnimation.GetJointTransformation(Gmdc.Joints[i].Name, FrameType.Translation);
					if (ab!=null) 
					{
						writer.WriteLine(ab.FrameCount.ToString());
						foreach (AnimationFrame af in ab.InterpolateMissingFrames())
						{
							Vector3f v = af.Vector;
							v = Component.TransformScaled(v);

							writer.WriteLine(af.TimeCode.ToString()+" " + 
								v.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
								v.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
								v.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture));
						}
					} 
					else writer.WriteLine("0");
					
					ab = Gmdc.LinkedAnimation.GetJointTransformation(Gmdc.Joints[i].Name, FrameType.Rotation);
					if (ab!=null) 
					{
						writer.WriteLine(ab.FrameCount.ToString());
						foreach (AnimationFrame af in ab.InterpolateMissingFrames())
						{
							Vector3f v = af.Vector;
							v = Component.Transform(v);
						
							writer.WriteLine(af.TimeCode.ToString()+" " + 
								v.X.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
								v.Y.ToString("N12", AbstractGmdcExporter.DefaultCulture) + " " +
								v.Z.ToString("N12", AbstractGmdcExporter.DefaultCulture));
						}
					} 
					else writer.WriteLine("0");
				} 
				else 
				{
					writer.WriteLine("0");
					writer.WriteLine("0");				
				}
			}

			//Write Footer
			writer.WriteLine("GroupComments: 0");
			writer.WriteLine("MaterialComments: 0");
			writer.WriteLine("BoneComments: 0");
			writer.WriteLine("ModelComment: 0");
		}
	}
}
