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
		private Ambertation.Graphics.DirectXPanel dx;
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

			dx = new Ambertation.Graphics.DirectXPanel();
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
				
		void AddJoint(ListedMeshBlocks lmb, SimPe.Interfaces.Scenegraph.ICresChildren bl, Ambertation.Graphics.MeshList parent, System.Windows.Forms.TreeNodeCollection nodes)
		{
			SimPe.Plugin.TransformNode tn = bl.StoredTransformNode;						
			
			
			if (tn!=null)
			{
				Ambertation.Graphics.MeshBox mb = new Ambertation.Graphics.MeshBox(
					Microsoft.DirectX.Direct3D.Mesh.Sphere(dx.Device, 0.02f, 12, 24),
					1,
					Ambertation.Graphics.DirectXPanel.GetMaterial(Color.Wheat)
					);
				mb.Wire = false;

				Ambertation.Scenes.Transformation trans = new Ambertation.Scenes.Transformation();
				trans.Rotation.X = tn.Rotation.GetEulerAngles().X;
				trans.Rotation.Y = tn.Rotation.GetEulerAngles().Y;
				trans.Rotation.Z = tn.Rotation.GetEulerAngles().Z;
				
				trans.Translation.X = tn.TransformX;
				trans.Translation.Y = tn.TransformY;
				trans.Translation.Z = tn.TransformZ;

				mb.Transform = Ambertation.Scenes.Converter.ToDx(trans);

				TreeNode tnode = new TreeNode(tn.ToString());
				tnode.Tag = mb;
				nodes.Add(tnode);
				jointmap[bl.GetName()] = mb;	

				parent.Add(mb);

				foreach (SimPe.Interfaces.Scenegraph.ICresChildren cld in bl)
					AddJoint(lmb, cld, mb, tnode.Nodes);
				
			} 		
			else 
			{
				foreach (SimPe.Interfaces.Scenegraph.ICresChildren cld in bl)
					AddJoint(lmb, cld, parent, nodes);
			}
	
			
		}

		

		private void dx_ResetDevice(object sender, EventArgs e)
		{			
			

			if (!inter) 
			{
				dx.Meshes.Clear(true);
				inter = true;
				lb_SelectedIndexChanged(null, null);
				inter = false;
			} 
			else 
			{
				dx.Meshes.Clear(false);
			}
		
			if (root!=null) 
			{
				foreach (Ambertation.Graphics.MeshBox mb in root)
					dx.Meshes.Add(mb);
			}			
		}

		Ambertation.Graphics.MeshList root;
		Hashtable jointmap = new Hashtable();
		bool inter;
		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lb.SelectedItem==null) return;
			jointmap.Clear();

			ListedMeshBlocks lmb = (ListedMeshBlocks)lb.SelectedItem;
			if (lmb.CRES==null || lmb.GMDC==null) return;

			SimPe.Plugin.ResourceNode rn = (SimPe.Plugin.ResourceNode)lmb.CRES.Blocks[0];
						
			if (root!=null) root.Dispose();
			root = new Ambertation.Graphics.MeshList();
			

			AddJoint(lmb, rn, root, tv.Nodes);

			animdata.Clear();			
			foreach (SimPe.Plugin.Anim.AnimationFrameBlock afb in lmb.ANIMBlock.Part2)
			{
				SimPe.Plugin.Anim.AnimationFrameBlock afb2 = afb.CloneBase(true);
				object o = jointmap[afb.Name];
				if (o==null) continue;
				Ambertation.Graphics.MeshBox mb = (Ambertation.Graphics.MeshBox)o;
				
				animdata.Add(new AnimationData(afb2, mb, lmb.ANIMBlock.Animation.TotalTime));
			}

			if (inter) return;
			inter = true;
			//dx.Reset();
			dx.ResetViewport(new Microsoft.DirectX.Vector3(-2, -2, -2), new Microsoft.DirectX.Vector3(2, 2, 2));
			dx.Render();
			inter = false;
		}

		//Ambertation.Graphics.MeshBox lastmb;
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;

			/*if (lastmb!=null) lastmb.Material = mat;
			Teichion.Graphics.MeshBox mb = (Teichion.Graphics.MeshBox)e.Node.Tag;
			mb.Material = smat;

			Microsoft.DirectX.Vector3 v = new Microsoft.DirectX.Vector3(0, 0, 0);
			v.TransformCoordinate(mb.GetEffectiveTransform());
			label1.Text = v.ToString();

			dx.Render();

			lastmb = mb;*/
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
