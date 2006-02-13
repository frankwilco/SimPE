using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin.Gmdc
{

	class MeshListViewItemExt : MeshListViewItem
	{
		public MeshListViewItemExt(ListViewEx lv, Ambertation.Scenes.Mesh mesh, GenericMeshImport gmi, ActionChangedEvent fkt)
			: base(lv, mesh, gmi, fkt)
		{
		}

		#region Build Elements		
		GmdcElement BuildVertexElement()
		{
			if (mesh.Vertices.Count==0) return null;
			GmdcElement e = new GmdcElement(gmi.Gmdc);
			e.SetFormat = SetFormat.Secondary;
			e.BlockFormat = BlockFormat.ThreeFloat;
			e.Identity = ElementIdentity.Vertex;
			e.GroupId = 0;

			e.Number = mesh.Vertices.Count;
			
			foreach (Ambertation.Geometry.Vector3 v in mesh.Vertices) 
			{
				Ambertation.Geometry.Vector3 vt = gmi.Component.InverseTransformScaled(v);
				e.Values.Add(new GmdcElementValueThreeFloat((float)vt.X, (float)vt.Y, (float)vt.Z));
			}

			return e;
		}

		

		GmdcElement BuildNormalElement()
		{
			if (mesh.Normals.Count==0) return null;
			GmdcElement e = new GmdcElement(gmi.Gmdc);
			e.SetFormat = SetFormat.Secondary;
			e.BlockFormat = BlockFormat.ThreeFloat;
			e.Identity = ElementIdentity.Normal;
			e.GroupId = 0;

			e.Number = mesh.Normals.Count;
			
			foreach (Ambertation.Geometry.Vector3 v in mesh.Normals) 
			{
				Ambertation.Geometry.Vector3 vt = gmi.Component.InverseTransformNormal(v);
				e.Values.Add(new GmdcElementValueThreeFloat((float)vt.X, (float)vt.Y, (float)vt.Z));
			}

			return e;
		}

		GmdcElement BuildTextureElement()
		{
			if (mesh.TextureCoordinates.Count==0) return null;
			GmdcElement e = new GmdcElement(gmi.Gmdc);
			e.SetFormat = SetFormat.Secondary;
			e.BlockFormat = BlockFormat.TwoFloat;
			e.Identity = ElementIdentity.UVCoordinate;
			e.GroupId = 0;

			e.Number = mesh.Normals.Count;
			
			foreach (Ambertation.Geometry.Vector2 v in mesh.TextureCoordinates)
				e.Values.Add(new GmdcElementValueTwoFloat((float)v.X, (float)(1-v.Y)));

			return e;
		}

		GmdcElement BuildBoneElement()
		{
			if (mesh.Envelopes.Count==0) return null;
			GmdcElement e = new GmdcElement(gmi.Gmdc);
			e.SetFormat = SetFormat.Secondary;
			e.BlockFormat = BlockFormat.OneDword;
			e.Identity = ElementIdentity.BoneAssignment;
			e.GroupId = 0;

			e.Number = mesh.Vertices.Count;
			
			for (int i=0; i<mesh.Vertices.Count; i++)
				e.Values.Add(new GmdcElementValueOneInt(-1));

			return e;
		}

		GmdcElement BuildWeightElement()
		{
			if (mesh.Envelopes.Count==0) return null;
			GmdcElement e = new GmdcElement(gmi.Gmdc);
			e.SetFormat = SetFormat.Secondary;
			e.BlockFormat = BlockFormat.ThreeFloat;
			e.Identity = ElementIdentity.BoneWeights;
			e.GroupId = 0;

			e.Number = mesh.Vertices.Count;
			
			for (int i=0; i<mesh.Vertices.Count; i++)
				e.Values.Add(new GmdcElementValueThreeFloat(0, 0, 0));

			return e;
		}

		void AddElement(GmdcElement e, GmdcGroup g, bool update)
		{
			if (e==null) return;

			if (update) 
			{
				GmdcElement eo = g.Link.FindElementType(e.Identity);
				if (eo!=null) 
				{					
					int index = g.Link.GetElementNr(eo);
					index = g.Link.ReferencedElement[index];
					gmi.Gmdc.Elements[index] = eo;

					return;
				}				
			}

			gmi.Gmdc.Elements.Add(e);
			g.Link.ReferencedElement.Add(gmi.Gmdc.Elements.Count-1);
			g.Link.ReferencedSize = g.Link.GetReferencedSize();
			g.Link.ActiveElements = g.Link.ReferencedElement.Count;	
		}

		void SetFaces(GmdcGroup g)
		{
			g.Faces.Clear();
			foreach (Ambertation.Geometry.Vector3i v in mesh.FaceIndices)	
			{		
				g.Faces.Add(v.X); g.Faces.Add(v.Y); g.Faces.Add(v.Z);		
			}
		}

		void SetBones(Ambertation.Scenes.Envelope e, int index, GmdcElement be, GmdcElement bw)
		{
			for (int i=0; i<e.Weights.Count; i++)
			{
				if (e.Weights[i]==0) continue;
				GmdcElementValueOneInt a = be.Values[i] as GmdcElementValueOneInt;
				GmdcElementValueThreeFloat w = bw.Values[i] as GmdcElementValueThreeFloat;

				int k = -1;
				for (int j=0; j< 3; j++)
					if (a.Bytes[j]==0xff) { k=j; break; }

				if (k!=-1)
				{
					a.SetByte(k, (byte)index);
					w.Data[k] = (float)e.Weights[i];
				}
			}
		}
		
		void SetUsedJoints(GmdcGroup g)
		{
			g.UsedJoints.Clear();
			GmdcElement be = this.BuildBoneElement();
			GmdcElement bw = this.BuildWeightElement();
			AddElement(be, g, Action==GenericMeshImport.ImportAction.Update);
			AddElement(bw, g, Action==GenericMeshImport.ImportAction.Update);
			if (be!=null && bw!=null) 
			{
				foreach(Ambertation.Scenes.Envelope e in mesh.Envelopes)
					if (e.Joint.Tag!=null)
						if ((int)e.Joint.Tag>=0)
						{
							g.UsedJoints.Add((int)e.Joint.Tag);	
							SetBones(e, g.UsedJoints.Count-1, be, bw);
						}
			}
		}
		#endregion
	
		public void BuildGroup()
		{						
			if (this.Group==null && this.Action == GenericMeshImport.ImportAction.Replace) this.Action = GenericMeshImport.ImportAction.Add;
			if (this.Group==null && this.Action == GenericMeshImport.ImportAction.Update) this.Action = GenericMeshImport.ImportAction.Add;
			if (Action == GenericMeshImport.ImportAction.Ignore) return;

			GmdcGroup g;
			if (Action == GenericMeshImport.ImportAction.Update) 			
				g = Group;			
			else if  (Action == GenericMeshImport.ImportAction.Replace) 
			{
				int gindex = gmi.Gmdc.FindGroupByName(Group.Name);				
				gmi.Gmdc.RemoveGroup(gindex);

				g = new GmdcGroup(gmi.Gmdc);
				gmi.Gmdc.Groups.Add(g);	
			}
			else 
			{
				g = new GmdcGroup(gmi.Gmdc);
				gmi.Gmdc.Groups.Add(g);								
			}

			//make sure the Group references a Link
			if (g.Link ==null) 
			{
				GmdcLink l = new GmdcLink(gmi.Gmdc);
				gmi.Gmdc.Links.Add(l);
				g.LinkIndex = gmi.Gmdc.Links.Count-1;
			}

			g.Name = mesh.Name;
			if (Shadow) g.Opacity = 0x10;
			else g.Opacity = 0xffffffff;
			g.PrimitiveType = PrimitiveType.Triangle;

			mesh.Tag = new object[] {this, g};

			AddElement(this.BuildVertexElement(), g, Action==GenericMeshImport.ImportAction.Update);
			AddElement(this.BuildNormalElement(), g, Action==GenericMeshImport.ImportAction.Update);
			AddElement(this.BuildTextureElement(), g, Action==GenericMeshImport.ImportAction.Update);		
	
			SetFaces(g);
			if (this.ImportEnvelope)
				SetUsedJoints(g);
		}

		#region IDisposable Member

		public override void Dispose()
		{
			base.Dispose();
		}

		#endregion

	}

}
