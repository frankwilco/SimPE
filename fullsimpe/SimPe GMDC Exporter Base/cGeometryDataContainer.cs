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

namespace SimPe.Plugin
{
	/// <summary>
	/// This class contains the Geometric Data of an Object
	/// </summary>
	public class GeometryDataContainer
		: AbstractRcolBlock
	{
		#region Attributes

		GmdcElements elements;
		/// <summary>
		/// Returns a List of stored Elements
		/// </summary>
		public GmdcElements Elements 
		{
			get { return elements; }
			set { elements = value; }
		}

		GmdcLinks links;
		/// <summary>
		/// Returns a List of stored Links
		/// </summary>
		public GmdcLinks Links 
		{
			get { return links; }
			set { links = value; }
		}

		GmdcGroups groups;
		/// <summary>
		/// Returns a List of stored Groups
		/// </summary>
		public GmdcGroups Groups 
		{
			get { return groups; }
			set { groups = value; }
		}

		GmdcModel model;
		/// <summary>
		/// Returns the stored Model
		/// </summary>
		public GmdcModel Model 
		{
			get { return model; }
			set { model = value; }
		}

		GmdcJoints joints;
		/// <summary>
		/// Returns a List of stored Joints
		/// </summary>
		public GmdcJoints Joints 
		{
			get { return joints; }
			set { joints = value; }
		}
		#endregion
				
		/// <summary>
		/// Constructor
		/// </summary>
		public GeometryDataContainer(Rcol parent) : base(parent)
		{
			sgres = new SGResource(null);			

			version = 0x04;
			BlockID = 0xAC4F8687;

			elements = new GmdcElements();
			links = new GmdcLinks();
			groups = new GmdcGroups();

			model = new GmdcModel(this);

			joints = new GmdcJoints();
            tried = false;
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
            tried = false;
			version = reader.ReadUInt32();

			string name = reader.ReadString();
			uint myid = reader.ReadUInt32();		
			sgres.Unserialize(reader);
			sgres.BlockID = myid;

            if (Parent.Fast)
            {
                elements.Clear();
                links.Clear();
                groups.Clear();
                joints.Clear();
                return;
            }

			int count = reader.ReadInt32();
			elements.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcElement e = new GmdcElement(this);
				e.Unserialize(reader);
				elements.Add(e);
			}

			count = reader.ReadInt32();
			links.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcLink l = new GmdcLink(this);
				l.Unserialize(reader);
				links.Add(l);
			}

			count = reader.ReadInt32();
			groups.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcGroup g = new GmdcGroup(this);
				g.Unserialize(reader);
				groups.Add(g);
			}

			model.Unserialize(reader);
			
			count = reader.ReadInt32();
			joints.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcJoint s = new GmdcJoint(this);
				s.Unserialize(reader);
				joints.Add(s);
			}

		}

		/// <summary>
		/// Serializes a the Attributes stored in this Instance to the BinaryStream
		/// </summary>
		/// <param name="writer">The Stream the Data should be stored to</param>
		/// <remarks>
		/// Be sure that the Position of the stream is Proper on 
		/// return (i.e. must point to the first Byte after your actual File)
		/// </remarks>
		public override void Serialize(System.IO.BinaryWriter writer)
		{
			writer.Write(version);

			writer.Write(sgres.BlockName);
			writer.Write(sgres.BlockID);
			sgres.Serialize(writer);
			
			writer.Write((int)elements.Length);
			for (int i=0; i<elements.Length; i++) 
			{
				elements[i].Parent = this;
				elements[i].Serialize(writer);
			}

			writer.Write((int)links.Length);
			for (int i=0; i<links.Length; i++) 
			{
				links[i].Parent = this;
				links[i].Serialize(writer);
			}
			
			writer.Write((int)groups.Length);
			for (int i=0; i<groups.Length; i++) 
			{
				groups[i].Parent = this;
				groups[i].Serialize(writer);
			}

			model.Parent = this;
			model.Serialize(writer);
			
			writer.Write((int)joints.Length);
			for (int i=0; i<joints.Length; i++) 
			{
				joints[i].Parent = this;
				joints[i].Serialize(writer);			
			}
		}

		fGeometryDataContainer form = null;
		/// <summary>
		/// Returns null or the Instance of a <see cref="System.Windows.Forms.TabPage"/> that 
		/// should be displayed as Primary Interface
		/// </summary>
		public override System.Windows.Forms.TabPage TabPage
		{
			get
			{			
				if (form==null) form = new fGeometryDataContainer();
				return form.tMesh;				
			}
		}
		#endregion

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fGeometryDataContainer(); 
			form.ResetPreview();
			form.tb_ver.Text = "0x"+Helper.HexString(this.version);

			if (Helper.WindowsRegistry.HiddenMode) 
			{
				form.label_elements.Text = "Elements: "+elements.Length.ToString();
				form.list_elements.Items.Clear();
				foreach(GmdcElement e in elements) SimPe.CountedListItem.Add(form.list_elements, e);

				form.label_links.Text = "Links: "+links.Length.ToString();
				form.list_links.Items.Clear();
				foreach(GmdcLink l in links) SimPe.CountedListItem.Add(form.list_links, l);

				form.label_groups.Text = "Groups: "+groups.Length.ToString();
				form.list_groups.Items.Clear();
				foreach(GmdcGroup g in groups) SimPe.CountedListItem.Add(form.list_groups, g);

				form.label_subsets.Text = "Joints: "+joints.Length.ToString();
				form.list_subsets.Items.Clear();
				foreach(GmdcJoint s in joints) SimPe.CountedListItem.Add(form.list_subsets, s);
			}

			try 
			{
				form.lb_models.Text = "Models (Faces="+this.TotalFaceCount.ToString()+", Vertices="+this.TotalUsedVertices.ToString()+"):";
				form.lb_itemsc2.Items.Clear();
				form.lb_itemsc3.Items.Clear();
				form.lb_itemsc.Items.Clear();
				form.lbmodel.Items.Clear();
				foreach (GmdcGroup g in groups) 
				{
					form.lbmodel.Items.Add(g, g.Opacity>=0x10);
					form.lb_itemsc.Items.Add(g); 
				}

				form.lb_itemsa2.Items.Clear();
				form.lb_itemsa.Items.Clear();
				foreach (GmdcElement i in this.elements) SimPe.CountedListItem.Add(form.lb_itemsa, i);

				form.lb_itemsb2.Items.Clear();
				form.lb_itemsb3.Items.Clear();
				form.lb_itemsb4.Items.Clear();
				form.lb_itemsb5.Items.Clear();
				form.lb_itemsb.Items.Clear();
				foreach (GmdcLink i in this.links) SimPe.CountedListItem.Add(form.lb_itemsb, i);

				form.lb_subsets.Items.Clear();
				form.lb_sub_faces.Items.Clear();
				form.lb_sub_items.Items.Clear();
				form.cbGroupJoint.Items.Clear();
				foreach (GmdcJoint i in this.joints) 
				{
					SimPe.CountedListItem.Add(form.lb_subsets, i);
					SimPe.CountedListItem.Add(form.cbGroupJoint, i);
				}

				form.lb_model_faces.Items.Clear();
				foreach (Vector3f i in this.model.BoundingMesh.Vertices) SimPe.CountedListItem.Add(form.lb_model_faces, i);
				form.lb_model_items.Items.Clear();
				foreach (int i in this.model.BoundingMesh.Items) SimPe.CountedListItem.Add(form.lb_model_items, i);
				form.lb_model_names.Items.Clear();
				foreach (GmdcNamePair i in this.model.BlendGroupDefinition) SimPe.CountedListItem.Add(form.lb_model_names, i);
				form.lb_model_trans.Items.Clear();
				foreach (VectorTransformation i in this.model.Transformations) SimPe.CountedListItem.Add(form.lb_model_trans, i);
				
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		/// <summary>
		/// Add Additional <see cref="System.Windows.Forms.TabPage"/> to show more Informations
		/// </summary>
		/// <param name="tc">The TabPage will be added here.</param>
		public override void ExtendTabControl(System.Windows.Forms.TabControl tc)
		{
			

			form.tGeometryDataContainer.Tag = this;
			tc.TabPages.Add(form.tGeometryDataContainer);

			form.tGeometryDataContainer2.Tag = this;
			tc.TabPages.Add(form.tGeometryDataContainer2);

			form.tGeometryDataContainer3.Tag = this;
			tc.TabPages.Add(form.tGeometryDataContainer3);

			form.tModel.Tag = this;
			tc.TabPages.Add(form.tModel);

			form.tSubset.Tag = this;
			tc.TabPages.Add(form.tSubset);

			if (Helper.WindowsRegistry.HiddenMode) 
			{
				form.tDebug.Tag = this;
				tc.TabPages.Add(form.tDebug);
			}
		}

		#region .x-Files
		/// <summary>
		/// Creates a .x File for all Models stored in the GMDC
		/// </summary>
		/// <param name="models">List of all P3Models you want to export</param>
		/// <returns>The content of the x File</returns>
		public MemoryStream GenerateX(GmdcGroups models)
		{
			IGmdcExporter exporter = ExporterLoader.FindExporterByExtension(".x");			
			if (exporter==null) throw new Exception("No valid Direct X Exporter plugin was found!");

			exporter.Component.Sorting = ElementSorting.Preview;
			exporter.Process(this, models);
			return (MemoryStream)exporter.FileContent.BaseStream;
		}
		#endregion


		/// <summary>
		/// Remove the Group with the given Index from the File
		/// </summary>
		/// <param name="index">The index of the Element</param>
		public void RemoveGroup(int index)
		{
			if (index<groups.Count) 
			{
				GmdcGroup g = groups[index];
				int n = g.LinkIndex;
				g.LinkIndex = -1;
				RemoveLink(n);

				groups.RemoveAt(index);
			}
		}
		
		/// <summary>
		/// Remove the Link with the given Index from the File
		/// </summary>
		/// <param name="index">The index of the Element</param>
		/// <returns>true if the link was removed</returns>
		/// <remarks>
		/// A Link will not be removed, if it is still referenced 
		/// in one or more Groups!
		/// </remarks>
		public bool RemoveLink(int index)
		{
			foreach(GmdcGroup g in groups) if (g.LinkIndex==index) return false;
			
			GmdcLink l = links[index];
			foreach(GmdcGroup g in groups) if (g.LinkIndex>index) g.LinkIndex--;

			for (int i=0; i<l.ReferencedElement.Count; i++)
			{
				int n = l.ReferencedElement[i];
				l.ReferencedElement[i] = -1; //make sure the reference is removed first
				RemoveElement(n);
			}
			links.RemoveAt(index);
			return true;
		}

		/// <summary>
		/// Remove the Element with the given Index from the File
		/// </summary>
		/// <param name="index">The index of the Element</param>
		/// <returns>true if the element was removed</returns>
		/// <remarks>
		/// A Element will not be removed, if it is still referenced 
		/// in one or more Links!
		/// </remarks>
		public bool RemoveElement(int index)
		{
			//Can we remove this Element?
			foreach (GmdcLink l in links) 
			{
				foreach (int i in l.ReferencedElement) if (i==index) return false;
			}

			//Adjust the References
			foreach (GmdcLink l in links) 
			{
				for (int i=0; i<l.ReferencedElement.Count; i++) if (l.ReferencedElement[i]>index) l.ReferencedElement[i]--;
			}

			elements.RemoveAt(index);
			return true;
		}

		/// <summary>
		/// Returns the total Face Count for this Mesh
		/// </summary>
		public int TotalFaceCount 
		{
			get 
			{
				int ct = 0;
				foreach (GmdcGroup g in groups) ct += g.FaceCount;

				return ct;
			}
		}

		/// <summary>
		/// Returns the number of used Vertices in this Mshe
		/// </summary>
		public int TotalUsedVertices
		{
			get 
			{
				int ct = 0;
				foreach (GmdcGroup g in groups) ct += g.UsedVertexCount;

				return ct;
			}
		}

		/// <summary>
		/// Returns the number of referenced Vertices in this Mesh
		/// </summary>
		public int TotalReferencedVertices
		{
			get 
			{
				int ct = 0;
				foreach (GmdcGroup g in groups) ct += g.ReferencedVertexCount;

				return ct;
			}
		}

		/// <summary>
		/// Call this Method to remove all unreferenced Joints
		/// </summary>
		public void CleanupBones()
		{
			ArrayList usebones = new ArrayList();

			///Assemble a List of used Joints
			foreach (GmdcElement e in elements) 
			{
				if (e.Identity == ElementIdentity.BoneAssignment) 
					foreach (GmdcElementValueOneInt v in e.Values) 
					{
						if (!usebones.Contains(v.Value&0xff)) usebones.Add(v.Value&0xff);
					}
			}

			for (int i=joints.Length-1; i>=0; i--)
			{
				if (!usebones.Contains(i)) RemoveBone(i);
			}
		}

		/// <summary>
		/// Removes a Bone from this File
		/// </summary>
		/// <remarks>Vertices referencing this Bone will be unassigned! </remarks>
		/// <param name="index"></param>
		public void RemoveBone(int index) 
		{
			//Update the Assignments 
			foreach (GmdcElement e in elements) 
			{
				if (e.Identity == ElementIdentity.BoneAssignment) 
					foreach (GmdcElementValueOneInt v in e.Values) 
					{						
						if ((int)v.Bytes[0]==index) 
						{
							byte[]b = v.Bytes;
							b[0] = 0xff;
							v.Bytes = b;
						}
						/*else if ((int)v.Bytes[0]>index) 
						{
							byte[]b = v.Bytes;
							b[0]--;
							v.Bytes = b;
						}*/
					}
			}

			//Update the Bone List in the Groups Section
			foreach (GmdcGroup g in groups) 
			{
				for (int i=g.UsedJoints.Count-1; i>=0; i--)
				{
					if (g.UsedJoints[i]==index) g.UsedJoints.RemoveAt(i);
					else if (g.UsedJoints[i]>index) g.UsedJoints[i]--;
				}
			}

			model.Transformations.RemoveAt(index);
			joints.RemoveAt(index);
		}

		/// <summary>
		/// Returns the Index of the Group in <see cref="Groups"/>.
		/// </summary>
		/// <param name="name">The name of the Group</param>
		/// <returns>-1 if the Grou is not foudn or the Index in <see cref="Groups"/></returns>
		public int FindGroupByName(string name) 
		{
			name = name.Trim().ToLower();
			for (int i=0; i<Groups.Count; i++)
			{
				if (Groups[i].Name.Trim().ToLower() == name) return i;				
			}

			return -1;
		}

		/// <summary>
		/// Returns the Index of the Joint in <see cref="Joints"/>.
		/// </summary>
		/// <param name="name">The name of the Joint</param>
		/// <returns>-1 if the Joint is not found or the Index in <see cref="Joints"/></returns>
		public int FindJointByName(string name) 
		{
			name = name.Trim().ToLower();
			for (int i=0; i<Joints.Count; i++)
			{
				if (Joints[i].Name.Trim().ToLower() == name) return i;				
			}

			return -1;
		}

		#region LinkedCRES

		Rcol cres;
        bool tried;
        public bool TriedToLoadParentResourceNode
        {
            get { return tried; }
            set { tried = value; }
        }

		/// <summary>
		/// Get the attached ResourceNode
		/// </summary>
		public  ResourceNode ParentResourceNode 
		{
			get {
                if (!tried)
                {
                    if (cres == null) cres = FindReferencingCRES();
                    tried = true;                                        
                }

                if (cres == null) return null;
				return (ResourceNode) cres.Blocks[0]; 
			}
		}

		/// <summary>
		/// Returns the RCOL which lists this Resource in it's ReferencedFiles Attribute
		/// </summary>
		/// <returns>null or the RCOl Ressource</returns>
		public Rcol FindReferencingCRES()
		{		
			WaitingScreen.Wait();	
			SimPe.Interfaces.Scenegraph.IScenegraphFileIndex nfi = FileTable.FileIndex.AddNewChild();
			nfi.AddIndexFromPackage(this.Parent.Package);					
			Rcol cres = FindReferencingCRES_Int();
			FileTable.FileIndex.RemoveChild(nfi);
			nfi.Clear();	

			if (cres==null && !FileTable.FileIndex.Loaded) 
			{
				FileTable.FileIndex.Load();
				cres = FindReferencingCRES_Int();
			}
			

			WaitingScreen.Stop();
			return cres;
		}
		/// <summary>
		/// Returns the RCOL which lists this Resource in it's ReferencedFiles Attribute
		/// </summary>
		/// <returns>null or the RCOl Ressource</returns>
		Rcol FindReferencingCRES_Int()
		{		
			WaitingScreen.UpdateMessage("Loading Geometry Node");
			Rcol step = FindReferencingParent_NoLoad(Data.MetaData.GMND);
			if (step==null) return null;
			

			WaitingScreen.UpdateMessage("Loading Shape");
			
			step = ((GeometryNode)step.Blocks[0]).FindReferencingSHPE_NoLoad();
			if (step==null) return null;			
			
			WaitingScreen.UpdateMessage("Loading ResourceNode");
			step = ((AbstractRcolBlock)step.Blocks[0]).FindReferencingParent_NoLoad(Data.MetaData.CRES);
			if (step==null) return null;									
			
			return step;
		}

		/// <summary>
		/// Build the Parent Map
		/// </summary>
		/// <param name="parentmap">Hasttable that will contain the Child (key) -> Parent (value) Relation</param>
		/// <param name="parent">the current Parent id (-1=none)</param>
		/// <param name="c">the current Block we process</param>
		protected void LoadJointRelationRec(System.Collections.Hashtable parentmap, int parent, SimPe.Interfaces.Scenegraph.ICresChildren c)
		{
			if (c==null) return;

			if (c.GetType()==typeof(TransformNode))
			{
				TransformNode tn = (TransformNode)c;
				if (tn.JointReference!=TransformNode.NO_JOINT) 
				{
					parentmap[tn.JointReference] = parent;
					parent = tn.JointReference;
				}
			}

			//process the childs of this Block
			foreach (int i in c.ChildBlocks)
			{
				SimPe.Interfaces.Scenegraph.ICresChildren cl = c.GetBlock(i);
				LoadJointRelationRec(parentmap, parent, cl);
			}
			
		}

		/// <summary>
		/// Creates a Map, that contains a mapping from each Joint to it's parent
		/// </summary>
		/// <returns>The JointRelation Map</returns>
		/// <remarks>key=ChildJoint ID, value=ParentJoint ID (-1=top Level Joint)</remarks>
		public virtual System.Collections.Hashtable LoadJointRelationMap()
		{
			//Get the Cres for the Bone Hirarchy
			ResourceNode rn = this.ParentResourceNode;

			System.Collections.Hashtable parentmap = new System.Collections.Hashtable();
            if (rn == null)
            {
                Message.Show(SimPe.Localization.GetString("NO_CRES_FOUND"), SimPe.Localization.GetString("Information"), System.Windows.Forms.MessageBoxButtons.OK);
                return parentmap;
            }
            else LoadJointRelationRec(parentmap, -1, rn);

			//make sure Bones not defined in the CRES are listed here too
			for (int i=0; i<Joints.Count; i++)
				if (parentmap[i]==null) parentmap[i] = -1;

			return parentmap;
		}		

		/// <summary>
		/// Recusrivley add all SubJoints
		/// </summary>
		/// <param name="start"></param>
		/// <param name="relmap"></param>
		/// <param name="l"></param>
		static void SortJointsRec(int start, System.Collections.Hashtable relmap, IntArrayList l)
		{
			if (start==-1) return;
			if (l.Contains(start)) return;
			l.Add(start);

			foreach (int k in relmap.Keys)
				if ((int)relmap[k]==start) SortJointsRec(k, relmap, l);
		}

		/// <summary>
		/// Sort the passed list of Joints so that parent joints allways come first
		/// </summary>
		/// <param name="joints"><see cref="Joints"/></param>
		/// <param name="relmap"><see cref="LoadJointRelationMap"/></param>
		/// <returns></returns>
		public static IntArrayList SortJoints(GmdcJoints joints, System.Collections.Hashtable relmap)
		{
			int start = -1;
			foreach (int k in relmap.Keys)
				if ((int)relmap[k]==-1) 
				{
					start = k;
					break;
				}

			if (start!=-1) 
			{
				IntArrayList l = new IntArrayList();
				SortJointsRec(start, relmap, l);

				//check if there are some Joint's that were not added so far
				System.Collections.Hashtable nrelmap = (System.Collections.Hashtable)relmap.Clone();
				foreach (int v in l)
					if (nrelmap.ContainsKey(v)) 
						nrelmap.Remove(v);

				//recursivley process remaing joints
				if (nrelmap.Count>0) 
				{
					IntArrayList l2 = SortJoints(joints, nrelmap);
					foreach (int i in l2) l.Add(i);
				}

				return l;
			}

			IntArrayList ls = new IntArrayList();
			foreach (GmdcJoint j in joints)
				ls.Add(j.Index);

			return ls;
		}

		/// <summary>
		/// Sort the passed list of Joints so that parent joints allways come first
		/// </summary>		
		/// <returns></returns>
		public IntArrayList SortJoints()
		{
			return SortJoints(this.Joints, this.LoadJointRelationMap());
		}

		/// <summary>
		/// Sort the passed list of Joints so that parent joints allways come first
		/// </summary>		
		/// <param name="relmap"></param>
		/// <returns></returns>
		public IntArrayList SortJoints(System.Collections.Hashtable relmap)
		{
			return SortJoints(this.Joints, relmap);
		}
		#endregion

		AnimationMeshBlock la;
		public AnimationMeshBlock LinkedAnimation
		{
			get { return la; }
			set { la = value; }
		}

		

		#region IDisposable Member

		public override void Dispose()
		{
			if (this.form!=null) this.form.Dispose();
		}

		#endregion
	}
}
