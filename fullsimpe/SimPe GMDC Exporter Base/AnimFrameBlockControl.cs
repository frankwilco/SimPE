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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin.Anim
{
	/// <summary>
	/// Zusammenfassung für AnimFrameBlockControl.
	/// </summary>
	public class AnimFrameBlockControl : System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.TreeView tv;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel2;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn1;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn2;
		private SimPe.Plugin.Anim.AnimAxisTransformControl pn3;
		private System.Windows.Forms.Panel pnSplit1;
		private System.Windows.Forms.Panel pnSplit2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.LinkLabel llClear;
		private System.Windows.Forms.LinkLabel llAdd;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.TextBox tbTimeCode;
		private System.Windows.Forms.Label lbTimeCode;
		private System.Windows.Forms.LinkLabel llRefresh;
		private System.Windows.Forms.LinkLabel llClone;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem2;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AnimFrameBlockControl()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);

			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			SimPe.ThemeManager tm = SimPe.ThemeManager.Global.CreateChild();

			tm.AddControl(splitter1);
			panel1.BackColor = splitter1.BackColor;
			panel3.BackColor = splitter1.BackColor;
			panel6.BackColor = splitter1.BackColor;
			Clear();
		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tv = new System.Windows.Forms.TreeView();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pn3 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.pnSplit2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.pn2 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.pnSplit1 = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pn1 = new SimPe.Plugin.Anim.AnimAxisTransformControl();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.llClone = new System.Windows.Forms.LinkLabel();
			this.llRefresh = new System.Windows.Forms.LinkLabel();
			this.lbTimeCode = new System.Windows.Forms.Label();
			this.tbTimeCode = new System.Windows.Forms.TextBox();
			this.llAdd = new System.Windows.Forms.LinkLabel();
			this.llClear = new System.Windows.Forms.LinkLabel();
			this.panel2.SuspendLayout();
			this.pnSplit2.SuspendLayout();
			this.pnSplit1.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.SuspendLayout();
			// 
			// tv
			// 
			this.tv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tv.ContextMenu = this.contextMenu1;
			this.tv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tv.HideSelection = false;
			this.tv.ImageIndex = -1;
			this.tv.Location = new System.Drawing.Point(0, 0);
			this.tv.Name = "tv";
			this.tv.SelectedImageIndex = -1;
			this.tv.Size = new System.Drawing.Size(261, 416);
			this.tv.TabIndex = 0;
			this.tv.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_AfterSelect);
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem2});
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 0;
			this.menuItem2.Text = "&Expand Subnodes";
			this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
			// 
			// splitter1
			// 
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.splitter1.Location = new System.Drawing.Point(261, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 416);
			this.splitter1.TabIndex = 3;
			this.splitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.AutoScroll = true;
			this.panel2.AutoScrollMinSize = new System.Drawing.Size(448, 368);
			this.panel2.Controls.Add(this.pn3);
			this.panel2.Controls.Add(this.pnSplit2);
			this.panel2.Controls.Add(this.pn2);
			this.panel2.Controls.Add(this.pnSplit1);
			this.panel2.Controls.Add(this.pn1);
			this.panel2.Controls.Add(this.panel5);
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.DockPadding.Left = 8;
			this.panel2.DockPadding.Right = 8;
			this.panel2.Location = new System.Drawing.Point(264, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(480, 416);
			this.panel2.TabIndex = 4;
			// 
			// pn3
			// 
			this.pn3.AxisTransform = null;
			this.pn3.CanCreate = false;
			this.pn3.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn3.Location = new System.Drawing.Point(8, 288);
			this.pn3.Name = "pn3";
			this.pn3.Size = new System.Drawing.Size(464, 108);
			this.pn3.TabIndex = 8;
			this.pn3.Visible = false;
			this.pn3.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn3.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn3.VisibleChanged += new System.EventHandler(this.pn3_VisibleChanged);
			this.pn3.CreateClicked += new System.EventHandler(this.pn3_CreateClicked);
			// 
			// pnSplit2
			// 
			this.pnSplit2.Controls.Add(this.panel3);
			this.pnSplit2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnSplit2.Location = new System.Drawing.Point(8, 276);
			this.pnSplit2.Name = "pnSplit2";
			this.pnSplit2.Size = new System.Drawing.Size(464, 12);
			this.pnSplit2.TabIndex = 10;
			this.pnSplit2.Visible = false;
			// 
			// panel3
			// 
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(464, 3);
			this.panel3.TabIndex = 11;
			// 
			// pn2
			// 
			this.pn2.AxisTransform = null;
			this.pn2.CanCreate = false;
			this.pn2.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn2.Location = new System.Drawing.Point(8, 164);
			this.pn2.Name = "pn2";
			this.pn2.Size = new System.Drawing.Size(464, 112);
			this.pn2.TabIndex = 7;
			this.pn2.Visible = false;
			this.pn2.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn2.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn2.VisibleChanged += new System.EventHandler(this.pn2_VisibleChanged);
			this.pn2.CreateClicked += new System.EventHandler(this.pn2_CreateClicked);
			// 
			// pnSplit1
			// 
			this.pnSplit1.Controls.Add(this.panel1);
			this.pnSplit1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnSplit1.Location = new System.Drawing.Point(8, 152);
			this.pnSplit1.Name = "pnSplit1";
			this.pnSplit1.Size = new System.Drawing.Size(464, 12);
			this.pnSplit1.TabIndex = 9;
			this.pnSplit1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(464, 3);
			this.panel1.TabIndex = 10;
			// 
			// pn1
			// 
			this.pn1.AxisTransform = null;
			this.pn1.CanCreate = false;
			this.pn1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn1.Location = new System.Drawing.Point(8, 40);
			this.pn1.Name = "pn1";
			this.pn1.Size = new System.Drawing.Size(464, 112);
			this.pn1.TabIndex = 6;
			this.pn1.Deleted += new System.EventHandler(this.pn1_Deleted);
			this.pn1.Changed += new System.EventHandler(this.pn1_Changed);
			this.pn1.CreateClicked += new System.EventHandler(this.pn1_CreateClicked);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.panel6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(8, 32);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(464, 8);
			this.panel5.TabIndex = 12;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(464, 3);
			this.panel6.TabIndex = 10;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.llClone);
			this.panel4.Controls.Add(this.llRefresh);
			this.panel4.Controls.Add(this.lbTimeCode);
			this.panel4.Controls.Add(this.tbTimeCode);
			this.panel4.Controls.Add(this.llAdd);
			this.panel4.Controls.Add(this.llClear);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(8, 0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(464, 32);
			this.panel4.TabIndex = 11;
			// 
			// llClone
			// 
			this.llClone.Location = new System.Drawing.Point(80, 8);
			this.llClone.Name = "llClone";
			this.llClone.Size = new System.Drawing.Size(35, 23);
			this.llClone.TabIndex = 5;
			this.llClone.TabStop = true;
			this.llClone.Text = "Clone";
			this.llClone.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.llClone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClone_LinkClicked);
			// 
			// llRefresh
			// 
			this.llRefresh.Location = new System.Drawing.Point(160, 8);
			this.llRefresh.Name = "llRefresh";
			this.llRefresh.Size = new System.Drawing.Size(80, 23);
			this.llRefresh.TabIndex = 4;
			this.llRefresh.TabStop = true;
			this.llRefresh.Text = "Refresh View";
			this.llRefresh.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.llRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRefresh_LinkClicked);
			// 
			// lbTimeCode
			// 
			this.lbTimeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTimeCode.Location = new System.Drawing.Point(256, 5);
			this.lbTimeCode.Name = "lbTimeCode";
			this.lbTimeCode.TabIndex = 3;
			this.lbTimeCode.Text = "TimeCode:";
			this.lbTimeCode.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbTimeCode
			// 
			this.tbTimeCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTimeCode.Location = new System.Drawing.Point(360, 8);
			this.tbTimeCode.Name = "tbTimeCode";
			this.tbTimeCode.TabIndex = 2;
			this.tbTimeCode.Text = "0";
			this.tbTimeCode.TextChanged += new System.EventHandler(this.tbTimeCode_TextChanged_1);
			this.tbTimeCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbTimeCode_KeyUp);
			// 
			// llAdd
			// 
			this.llAdd.Location = new System.Drawing.Point(0, 8);
			this.llAdd.Name = "llAdd";
			this.llAdd.Size = new System.Drawing.Size(32, 23);
			this.llAdd.TabIndex = 1;
			this.llAdd.TabStop = true;
			this.llAdd.Text = "Add";
			this.llAdd.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.llAdd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llAdd_LinkClicked);
			// 
			// llClear
			// 
			this.llClear.Location = new System.Drawing.Point(40, 8);
			this.llClear.Name = "llClear";
			this.llClear.Size = new System.Drawing.Size(32, 23);
			this.llClear.TabIndex = 0;
			this.llClear.TabStop = true;
			this.llClear.Text = "Clear";
			this.llClear.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.llClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llClear_LinkClicked);
			// 
			// AnimFrameBlockControl
			// 
			this.Controls.Add(this.tv);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel2);
			this.Name = "AnimFrameBlockControl";
			this.Size = new System.Drawing.Size(744, 416);
			this.panel2.ResumeLayout(false);
			this.pnSplit2.ResumeLayout(false);
			this.pnSplit1.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		#region Public Properties
		AnimationFrameBlock afb;
		public AnimationFrameBlock FrameBlock
		{
			get { return afb; }
			set { 
				afb = value; 
				RefreshData();
			}
		}
		#endregion

		public void Clear()
		{
			intern = true;
			this.tv.Nodes.Clear();
			llClone.Enabled = false;
			llAdd.Enabled = false;
			llClear.Enabled = false;

			this.tbTimeCode.Enabled = false;
			this.lbTimeCode.Enabled = tbTimeCode.Enabled;

			intern = false;
		}

		public void RefreshData()
		{
			Clear();

			if (afb!=null)
			{
				llAdd.Enabled = true;
				llClear.Enabled = true;

				

				AddFrames(afb.Frames, "");
			}
		}

		protected void AddFrames(AnimationFrame[] fr, string prefix)
		{
			foreach (AnimationFrame af in fr)			
				AddFrames(af, prefix);			
		}

		protected void AddFrames(AnimationFrame af, string prefix)
		{
			int ct = 0;
			foreach (AnimationAxisTransform aat in af.Blocks) 
				if (aat!=null) 
					ct++;

			TreeNode tn = new TreeNode(prefix+"tc="+af.TimeCode.ToString()+", comp="+ct+", "+af.Type.ToString());
			tn.Tag = af;

			AddFrame(tn, af.XBlock, "X: ");
			AddFrame(tn, af.YBlock, "Y: ");
			AddFrame(tn, af.ZBlock, "Z: ");

			tv.Nodes.Add(tn);
		}

		protected void AddFrame(TreeNode parent, AnimationAxisTransform aat, string prefix)
		{
			if (parent==null) return;
			if (aat==null) return;

			TreeNode tn = new TreeNode(prefix+aat.ToString());
			tn.Tag = aat;

			parent.Nodes.Add(tn);
		}

		bool intern;
		private void tv_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
		{
			pn1.AxisTransform = null;
			pn2.Visible=false;
			pn3.Visible=false;
			pn2.AxisTransform = null;
			pn3.AxisTransform = null;
			panel2.AutoScroll = false;
			pn1.CanCreate = false;
			this.tbTimeCode.Enabled = false;
			this.lbTimeCode.Enabled = tbTimeCode.Enabled;
			llClone.Enabled = false;
			if (e==null) return;
			if (e.Node==null) return;
			if (e.Node.Tag==null) return;


			if (e.Node.Tag is AnimationAxisTransform)
			{				
				pn1.AxisTransform = (AnimationAxisTransform)e.Node.Tag;
				
				pn1.Tag = e.Node;
			} 
			else if (e.Node.Tag is AnimationFrame)
			{
				
				llClone.Enabled = true;
				pn3.Visible=true;
				pn2.Visible=true;

				
				panel2.AutoScroll = true;
				pn1.CanCreate = true;
				pn2.CanCreate = true;
				pn3.CanCreate = true;

				AnimAxisTransformControl[] aatcs = new AnimAxisTransformControl[3];
				aatcs[0] = pn1; aatcs[1] = pn2; aatcs[2] = pn3;
				
				foreach (TreeNode n in e.Node.Nodes) 
				{
					int ct = 0;
					if (n.Text[0]=='X') ct = 0;
					else if (n.Text[0]=='Y') ct = 1;
					else if (n.Text[0]=='Z') ct = 2;
					else continue;

					aatcs[ct].AxisTransform = (AnimationAxisTransform)n.Tag;
					aatcs[ct].Tag = n;

					if (!tbTimeCode.Enabled) 
					{
						intern = true;
						this.tbTimeCode.Enabled = true;
						this.lbTimeCode.Enabled = tbTimeCode.Enabled;
						tbTimeCode.Text = aatcs[ct].AxisTransform.TimeCode.ToString();
						intern = false;
					}
				}
				
			}
		}

		private void pn3_VisibleChanged(object sender, System.EventArgs e)
		{
			pnSplit2.Visible = pn3.Visible;
		}

		private void pn2_VisibleChanged(object sender, System.EventArgs e)
		{
			pnSplit1.Visible = pn2.Visible;
		}

		private void pn1_Deleted(object sender, System.EventArgs e)
		{
			if (!(sender is AnimAxisTransformControl)) return;
			AnimAxisTransformControl s = (AnimAxisTransformControl)sender;
			TreeNode n = (TreeNode)s.Tag;

			n.Parent.Nodes.Remove(n);
			if (Changed!=null) Changed(this, new System.EventArgs());
		}

		private void pn1_Changed(object sender, System.EventArgs e)
		{
			if (!(sender is AnimAxisTransformControl)) return;
			AnimAxisTransformControl s = (AnimAxisTransformControl)sender;
			TreeNode n = (TreeNode)s.Tag;

			n.Text = n.Text.Substring(0, 3)+s.AxisTransform.ToString();
			if (Changed!=null) Changed(this, new System.EventArgs());			
		}

		private void llClear_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			afb.ClearFrames();
			tv.Nodes.Clear();

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void llAdd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			afb.AddFrame((short)(afb.GetDuration()+1), 0, 0, 0, false);
			AddFrames(afb.Frames[afb.FrameCount-1], "");

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void pn1_CreateClicked(object sender, System.EventArgs e)
		{			
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<1) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[0].Add(af.TimeCode, 0, 0, 0, af.Flag);
			af.XBlock = afb.AxisSet[0].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "X: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));
		}

		private void pn2_CreateClicked(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<2) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[1].Add(af.TimeCode, 0, 0, 0, af.Flag);
			af.YBlock = afb.AxisSet[1].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "Y: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));
		}

		private void pn3_CreateClicked(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
			while (afb.AxisSet.Length<3) afb.AddNewAxis();
			
			AnimationAxisTransform aat = afb.AxisSet[2].Add(af.TimeCode, 0, 0, 0, af.Flag);
			af.ZBlock = afb.AxisSet[2].GetLast();
			this.AddFrame(tv.SelectedNode, aat, "Z: ");

			this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));		
		}

		private void tbTimeCode_TextChanged(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			if (intern) return;
			intern = true;
			try 
			{
				short val = Helper.StringToInt16(this.tbTimeCode.Text, 0, 10);

				AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
				if (af.XBlock!=null) af.XBlock.TimeCode = val;
				if (af.YBlock!=null) af.YBlock.TimeCode = val;
				if (af.ZBlock!=null) af.ZBlock.TimeCode = val;

				this.tv_AfterSelect(tv, new TreeViewEventArgs(tv.SelectedNode, TreeViewAction.ByMouse));	
				this.pn1_Changed(pn1, null);
				this.pn1_Changed(pn2, null);
				this.pn1_Changed(pn3, null);
			}
			finally 
			{
				intern = false;
			}
		}

		private void tbTimeCode_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) tbTimeCode_TextChanged(sender, null);
		}

		private void llRefresh_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			this.RefreshData();
		}

		private void llClone_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;

			AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;			
			afb.AddFrame((short)(afb.GetDuration()+1), af.X, af.Y, af.Z, af.Flag);
			AddFrames(afb.Frames[afb.FrameCount-1], "");

			if (Changed!=null) Changed(this, new System.EventArgs());	
		}

		private void tbTimeCode_TextChanged_1(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode==null) return;
			if (!(tv.SelectedNode.Tag is AnimationFrame)) return;
			if (intern) return;
			intern = true;
			try 
			{
				short val = Helper.StringToInt16(this.tbTimeCode.Text, 0, 10);

				AnimationFrame af = (AnimationFrame)tv.SelectedNode.Tag;
				if (af.XBlock!=null) af.XBlock.TimeCode = val;
				if (af.YBlock!=null) af.YBlock.TimeCode = val;
				if (af.ZBlock!=null) af.ZBlock.TimeCode = val;
				
				this.pn1_Changed(pn1, null);
				this.pn1_Changed(pn2, null);
				this.pn1_Changed(pn3, null);
			}
			finally 
			{
				intern = false;
			}
		}

		private void menuItem2_Click(object sender, System.EventArgs e)
		{
			if (tv.SelectedNode!=null)
				tv.SelectedNode.ExpandAll();	
		}

		

		
		

	


		#region Events
		public event System.EventHandler Changed;
		#endregion
	}
}
