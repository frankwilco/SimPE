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

		GmdcBones subsets;
		/// <summary>
		/// Returns a List of stored Subsets
		/// </summary>
		public GmdcBones Bones 
		{
			get { return subsets; }
			set { subsets = value; }
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

			subsets = new GmdcBones();		
		}
		
		#region IRcolBlock Member

		/// <summary>
		/// Unserializes a BinaryStream into the Attributes of this Instance
		/// </summary>
		/// <param name="reader">The Stream that contains the FileData</param>
		public override void Unserialize(System.IO.BinaryReader reader)
		{
			version = reader.ReadUInt32();

			string name = reader.ReadString();
			uint myid = reader.ReadUInt32();		
			sgres.Unserialize(reader);
			sgres.BlockID = myid;

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
			subsets.Clear();
			for (int i=0; i<count; i++)
			{
				GmdcBone s = new GmdcBone(this);
				s.Unserialize(reader);
				subsets.Add(s);
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
			
			writer.Write((int)subsets.Length);
			for (int i=0; i<subsets.Length; i++) 
			{
				subsets[i].Parent = this;
				subsets[i].Serialize(writer);			
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
				if (Helper.WindowsRegistry.HiddenMode) 
				{				
					return form.tDebug;
				} 
				else 
				{
					return form.tMesh;
				}
			}
		}
		#endregion

		/// <summary>
		/// Refresh the Display
		/// </summary>
		internal void Refresh() 
		{
			InitTabPage(); 
		}

		/// <summary>
		/// You can use this to setop the Controls on a TabPage befor it is dispplayed
		/// </summary>
		protected override void InitTabPage() 
		{
			if (form==null) form = new fGeometryDataContainer(); 
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

				form.label_subsets.Text = "Subsets: "+subsets.Length.ToString();
				form.list_subsets.Items.Clear();
				foreach(GmdcBone s in subsets) SimPe.CountedListItem.Add(form.list_subsets, s);
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
				foreach (GmdcBone i in this.subsets) SimPe.CountedListItem.Add(form.lb_subsets, i);

				form.lb_model_faces.Items.Clear();
				foreach (Vector3i i in this.model.Bone.Vertices) SimPe.CountedListItem.Add(form.lb_model_faces, i);
				form.lb_model_items.Items.Clear();
				foreach (int i in this.model.Bone.Items) SimPe.CountedListItem.Add(form.lb_model_items, i);
				form.lb_model_names.Items.Clear();
				foreach (GmdcNamePair i in this.model.BlendGroupDefinition) SimPe.CountedListItem.Add(form.lb_model_names, i);
				form.lb_model_rots.Items.Clear();
				foreach (Vector4f i in this.model.Rotations) SimPe.CountedListItem.Add(form.lb_model_rots, i);
				form.lb_model_trans.Items.Clear();
				foreach (Vector3f i in this.model.Transformations) SimPe.CountedListItem.Add(form.lb_model_trans, i);
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
			if (Helper.WindowsRegistry.HiddenMode) 
			{
				form.tMesh.Tag = this;
				tc.TabPages.Add(form.tMesh);
			}

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
			GmdcGroup g = groups[index];
			int n = g.LinkIndex;
			g.LinkIndex = -1;
			RemoveLink(n);

			groups.RemoveAt(index);
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
	}
}
