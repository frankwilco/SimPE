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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für AnimPreview.
	/// </summary>
	public class AnimPreview : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.Panel panel1;
		private Teichion.Graphics.DirectXPanel dx;
		private SimPe.ThemeManager tm;
		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.Button btPlay;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.ProgressBar pb;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components;

		AnimPreview()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			tm = SimPe.ThemeManager.Global.CreateChild();
			tm.AddControl(this.xpGradientPanel1);

			dx = new Teichion.Graphics.DirectXPanel();
			dx.Parent = this.panel1;
			dx.Dock = DockStyle.Fill;

			dx.ResetDevice += new EventHandler(dx_ResetDevice);
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (tm!=null)
				{
					tm.Clear();
					tm = null;
				}

				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AnimPreview));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.pb = new System.Windows.Forms.ProgressBar();
			this.btPlay = new System.Windows.Forms.Button();
			this.tv = new System.Windows.Forms.TreeView();
			this.lb = new System.Windows.Forms.ListBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.Controls.Add(this.label1);
			this.xpGradientPanel1.Controls.Add(this.pb);
			this.xpGradientPanel1.Controls.Add(this.btPlay);
			this.xpGradientPanel1.Controls.Add(this.tv);
			this.xpGradientPanel1.Controls.Add(this.lb);
			this.xpGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.xpGradientPanel1.Location = new System.Drawing.Point(496, 0);
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.Size = new System.Drawing.Size(280, 454);
			this.xpGradientPanel1.TabIndex = 0;
			// 
			// pb
			// 
			this.pb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pb.Location = new System.Drawing.Point(0, 438);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(280, 16);
			this.pb.TabIndex = 3;
			// 
			// btPlay
			// 
			this.btPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btPlay.Location = new System.Drawing.Point(200, 408);
			this.btPlay.Name = "btPlay";
			this.btPlay.TabIndex = 2;
			this.btPlay.Text = "Play";
			this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
			// 
			// tv
			// 
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(8, 80);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(264, 272);
			this.tv.TabIndex = 1;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// lb
			// 
			this.lb.Location = new System.Drawing.Point(8, 8);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(264, 69);
			this.lb.TabIndex = 0;
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(496, 454);
			this.panel1.TabIndex = 1;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(8, 360);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(264, 48);
			this.label1.TabIndex = 4;
			this.label1.Text = "label1";
			// 
			// AnimPreview
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 14);
			this.ClientSize = new System.Drawing.Size(776, 454);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.xpGradientPanel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AnimPreview";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Animation Preview";
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		public static void Execute(SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem animitem)
		{
			SimPe.Plugin.GenericRcol rcol = new GenericRcol();
			rcol.ProcessData(animitem);

			Execute(rcol);
		}		

		public static void Execute(SimPe.Plugin.Rcol anim)
		{
			if (anim.Blocks.Length>0)
				if (anim.Blocks[0] is SimPe.Plugin.Anim.AnimResourceConst)
					Execute((SimPe.Plugin.Anim.AnimResourceConst)anim.Blocks[0]);
		}

		public static void Execute(SimPe.Plugin.Anim.AnimResourceConst anim)
		{
			AnimPreview f = new AnimPreview();

			WaitingScreen.Wait();
			WaitingScreen.UpdateMessage(SimPe.Localization.GetString("Loading Meshes"));
			int ct = 0;
			Wait.SubStart(anim.MeshBlock.Length);
			foreach (SimPe.Plugin.Anim.AnimationMeshBlock amb in anim.MeshBlock)
			{
				f.lb.Items.Add(new ListedMeshBlocks(amb));
				Wait.Progress = ct++;
			}
			Wait.SubStop();
			WaitingScreen.Stop();
			
			f.ShowDialog();

			f.timer1.Enabled = false;
		}

		SimPe.Plugin.Gmdc.ElementOrder eo = new SimPe.Plugin.Gmdc.ElementOrder(SimPe.Plugin.Gmdc.ElementSorting.XYZ);
		Microsoft.DirectX.Direct3D.Material mat = new Microsoft.DirectX.Direct3D.Material();
		Microsoft.DirectX.Direct3D.Material smat = new Microsoft.DirectX.Direct3D.Material();

		void CreateMesh(ListedMeshBlocks lmb, Teichion.Graphics.NodeBox joint, int index)
		{
			SimPe.Plugin.GeometryDataContainer gmdc = (SimPe.Plugin.GeometryDataContainer)lmb.GMDC.Blocks[0];								

			ArrayList list = new ArrayList();
			SimPe.Geometry.Vectors3i facelist = new SimPe.Geometry.Vectors3i();
			Hashtable map = new Hashtable();
			Microsoft.DirectX.Matrix m = joint.GetEffectiveTransform();
			m.Invert();
			foreach (SimPe.Plugin.Gmdc.GmdcGroup grp in gmdc.Groups)
			{
				list.Clear();
				facelist.Clear();
				map.Clear();

				SimPe.Geometry.Vectors3i faces = grp.GetFaces();
				SimPe.Geometry.Vectors4f bones = grp.GetBones();
				SimPe.Geometry.Vectors4f vertices = grp.GetVertices();
				SimPe.Geometry.Vectors4f normals = grp.GetNormals();
				SimPe.Geometry.Vectors4f uvs = grp.GetUV();

				for (int i=0; i<vertices.Count; i++)
				{
					if ((int)bones[i].X==index)
					{
						map[i] = (short)list.Count;
						SimPe.Geometry.Vector3f v = eo.Transform(vertices[i]);
						Microsoft.DirectX.Vector3 mv = new Microsoft.DirectX.Vector3((float)v.X, (float)v.Y, (float)v.Z);
						mv.TransformCoordinate(m);

						list.Add(new Microsoft.DirectX.Direct3D.CustomVertex.PositionNormal(
							mv.X, mv.Y, mv.Z,
							(float)normals[i].X, (float)normals[i].Y, (float)normals[i].Z
							)
							);

						SimPe.Geometry.Vectors3i ufaces = SimPe.Plugin.Gmdc.GmdcGroup.GetUsingFaces(faces, i);

						foreach (SimPe.Geometry.Vector3i f in ufaces)
							if (!facelist.Contains(f)) facelist.Add(f);
					}					
				}

				if (facelist.Count==0) return;

				short[] fcs = new short[facelist.Count * 3];
				int ct = 0;
				foreach (SimPe.Geometry.Vector3i f in facelist)
				{
					try 
					{
						short c1 = (short)map[f.X];
						short c2 = (short)map[f.Y];
						short c3 = (short)map[f.Z];
						fcs[ct++] = c1; fcs[ct++] = c2; fcs[ct++] = c3;
					} 
					catch {}
				}

				Microsoft.DirectX.Direct3D.CustomVertex.PositionNormal[] vcs = new Microsoft.DirectX.Direct3D.CustomVertex.PositionNormal[list.Count];
				list.CopyTo(vcs);

				Microsoft.DirectX.Direct3D.Mesh mesh = new Microsoft.DirectX.Direct3D.Mesh(
					fcs.Length/3,    
					vcs.Length,
					0,								 
					Microsoft.DirectX.Direct3D.VertexFormats.PositionNormal,   
					dx.Device
					); 

				Microsoft.DirectX.Direct3D.Material mat = new Microsoft.DirectX.Direct3D.Material();
				mat.Diffuse = Color.LightSteelBlue;
				mesh.SetVertexBufferData(vcs, Microsoft.DirectX.Direct3D.LockFlags.None); 
				mesh.SetIndexBufferData(fcs, Microsoft.DirectX.Direct3D.LockFlags.None); 

				int[] adjacency = new int[mesh.NumberFaces * 3];
				mesh.GenerateAdjacency(0.01F, adjacency); 
				mesh.OptimizeInPlace(Microsoft.DirectX.Direct3D.MeshFlags.OptimizeVertexCache, adjacency); 

				Teichion.Graphics.MeshBox mb = new Teichion.Graphics.MeshBox("Mesh", mesh, 1, mat);
				mb.Wire = true;
				
				joint.AddChild(mb);
			}
		}


		void AddJoint(ListedMeshBlocks lmb, SimPe.Interfaces.Scenegraph.ICresChildren bl, Teichion.Graphics.NodeBox parent, System.Windows.Forms.TreeNodeCollection nodes)
		{
			SimPe.Plugin.TransformNode tn = bl.StoredTransformNode;			
			Teichion.Graphics.MeshBox node;

			Microsoft.DirectX.Direct3D.Mesh mesh = Microsoft.DirectX.Direct3D.Mesh.Box(dx.Device, 0.01f, 0.01f, 0.01f);
			mat.Diffuse = Color.FromArgb(10, Color.Yellow);
			mat.Ambient = Color.FromArgb(10, Color.DarkGray);
			mat.Specular = Color.FromArgb(10, Color.LightYellow);
			smat.Diffuse = Color.Red;
			if (tn!=null)
			{
				SimPe.Geometry.Vector3f rot = tn.Rotation.GetEulerAngles();
				Microsoft.DirectX.Quaternion q = new Microsoft.DirectX.Quaternion((float)tn.Rotation.X, (float)tn.Rotation.Y, (float)tn.Rotation.Z, (float)tn.Rotation.W);
				Teichion.Graphics.MeshTransform mt 
					= new Teichion.Graphics.MeshTransform(tn.TransformX, tn.TransformY, tn.TransformZ, 
					rot.X, rot.Y, rot.Z);
				mt.SetRotation(q);
				node = new Teichion.Graphics.MeshBox(bl.ToString(), mesh, 1, mat, mt);
				
			} else
				node = new Teichion.Graphics.MeshBox(bl.ToString(), mesh, 1, mat);
			
			node.Wire = false;
			parent.AddChild(node);
			TreeNode tnode = new TreeNode(node.ToString());
			tnode.Tag = node;
			nodes.Add(tnode);
			
			jointmap[bl.GetName()] = node;

			if (bl.StoredTransformNode!=null)
				CreateMesh(lmb, node, bl.StoredTransformNode.JointReference);

			foreach (SimPe.Interfaces.Scenegraph.ICresChildren cld in bl)
				AddJoint(lmb, cld, node, tnode.Nodes);
		}

		

		private void dx_ResetDevice(object sender, EventArgs e)
		{			
			dx.Meshes.Clear();
			dx.AddAxisMesh();
		
			dx.Meshes.Add(root);	
		}

		Teichion.Graphics.NodeBox root;
		Hashtable jointmap = new Hashtable();
		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lb.SelectedItem==null) return;
			jointmap.Clear();

			ListedMeshBlocks lmb = (ListedMeshBlocks)lb.SelectedItem;
			if (lmb.CRES==null || lmb.GMDC==null) return;

			SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)lmb.CRES.Blocks[0];
						
			root = new Teichion.Graphics.NodeBox("---");

			AddJoint(lmb, rn, root, tv.Nodes);

			animdata.Clear();			
			foreach (SimPe.Plugin.Anim.AnimationFrameBlock afb in lmb.ANIMBlock.Part2)
			{
				SimPe.Plugin.Anim.AnimationFrameBlock afb2 = afb.CloneBase(true);
				object o = jointmap[afb.Name];
				if (o==null) continue;
				Teichion.Graphics.NodeBox nb = (Teichion.Graphics.NodeBox)o;

				animdata.Add(new AnimationData(afb2, nb, lmb.ANIMBlock.Animation.TotalTime));
			}

			dx.Reset();
			dx.ResetDefaultViewport();
			dx.Render();
		}

		Teichion.Graphics.MeshBox lastmb;
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;

			if (lastmb!=null) lastmb.Material = mat;
			Teichion.Graphics.MeshBox mb = (Teichion.Graphics.MeshBox)e.Node.Tag;
			mb.Material = smat;

			Microsoft.DirectX.Vector3 v = new Microsoft.DirectX.Vector3(0, 0, 0);
			v.TransformCoordinate(mb.GetEffectiveTransform());
			label1.Text = v.ToString();

			dx.Render();

			lastmb = mb;
		}

		ArrayList animdata = new ArrayList();
		private void btPlay_Click(object sender, System.EventArgs e)
		{
			if (lb.SelectedItem==null) return;	
			ListedMeshBlocks lmb = (ListedMeshBlocks)lb.SelectedItem;

			timer1.Interval = 1000/25;			
			timecode = 0;
			pb.Value = 0;
			pb.Maximum = lmb.ANIMBlock.Animation.TotalTime;

			timer1.Enabled = true;
		}

		int timecode;
		private void timer1_Tick(object sender, System.EventArgs e)
		{
			if (lb.SelectedItem==null) 
			{
				timer1.Enabled = false;
				return;			
			}

			ListedMeshBlocks lmb = (ListedMeshBlocks)lb.SelectedItem;
			if (timecode>lmb.ANIMBlock.Animation.TotalTime) 
			{
				timer1.Enabled = false;
				return;
			}

			
			pb.Value = timecode;						

			foreach (AnimationData ad in animdata)	
				ad.SetFrame(timecode);
			

			dx.Render();
			//Application.DoEvents();

			timecode += 40;
		}
	}
}
