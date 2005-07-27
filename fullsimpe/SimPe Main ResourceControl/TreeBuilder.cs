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
using System.Windows.Forms;
using System.Collections;

namespace SimPe
{
	
	
	/// <summary>
	/// This classed is used to associate a TreeView with a certain Generator Function
	/// </summary>
	public class TreeBuilderList 
	{
		/// <summary>
		/// All Generator Functions (=Functions that build a TreeView) must implement this delegate
		/// </summary>
		public delegate void GenerateView(TreeView tv);
		TreeView tv;
		GenerateView fkt;

		/// <summary>
		/// Create a new Instance
		/// </summary>
		/// <param name="fkt">The Generater function you want to use</param>
		/// <param name="tv">the TreeView that is associated with this function</param>
		public TreeBuilderList(GenerateView fkt, TreeView tv)
		{
			this.tv = tv;
			this.fkt = fkt;
		}
		

		/// <summary>
		/// Returns the stored TreeView
		/// </summary>
		public TreeView TreeView
		{
			get {return tv;}
		}

		/// <summary>
		/// Build the TreeView
		/// </summary>
		public void Generate()
		{
			fkt(tv);
		}
	}


	/// <summary>
	/// ZUsed to present a Package in various TreeLists
	/// </summary>
	public class TreeBuilder : ITreeBuilder
	{
		
		LoadedPackage pkg;
		ViewFilter filter;

		#region ListView Update
		public static void ClearListView(ListView lv) 
		{
			foreach (object o in lv.Items) 
			
				if (o is UpdatableListViewItem) 
				{
					UpdatableListViewItem lvi = (UpdatableListViewItem)o;
					lvi.Dispose();				
				}

			lv.Items.Clear();			
		}

		/// <summary>
		/// Deselects all items in te ListView
		/// </summary>
		/// <param name="lv"></param>
		public void DeselectAll(ListView lv)
		{
			foreach (ListViewItem lvi in lv.Items)
				lvi.Selected = false;
		}

		/// <summary>
		/// Selects the passed Resource in the ListView
		/// </summary>
		/// <param name="lv"></param>
		/// <param name="fii"></param>
		public void SelectResource(ListView lv, SimPe.Interfaces.Scenegraph.IScenegraphFileIndexItem fii)
		{
			foreach (ListViewItem lvi in lv.Items)
			{
				if (lvi.Tag is ListViewTag) 
				{
					ListViewTag lvt = (ListViewTag)lvi.Tag;
					if (lvt.Resource.Equals(fii)) 
					{
						lvi.Selected = true;
						lv.EnsureVisible(lvi.Index);
					}
				}
			}
		}

		ListViewItem CreateItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd) 
		{			
			UpdatableListViewItem lvi = new UpdatableListViewItem(pfd, pkg.Package);
			return lvi;
		}

		void RefreshAll(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
			{
				if (filter.Active)
					if (filter.IsFiltered(pfd)) continue;
				lv.Items.Add(CreateItem(pfd));
			}
		}

		void RefreshType(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
			{
				if (pfd.Type!=p.Type) continue;
				if (filter.Active)
					if (filter.IsFiltered(pfd)) continue;

				lv.Items.Add(CreateItem(pfd));
			}
		}

		void RefreshInstance(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
			{
				if (pfd.LongInstance!=p.LongInstance) continue;
				if (filter.Active)
					if (filter.IsFiltered(pfd)) continue;

				lv.Items.Add(CreateItem(pfd));
			}
		}

		void RefreshGroup(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
			{
				if (pfd.Group!=p.Group) continue;
				if (filter.Active)
					if (filter.IsFiltered(pfd)) continue;

				lv.Items.Add(CreateItem(pfd));
			}
		}

		void RefreshGroupInstance(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
			{
				if (pfd.Group!=p.Group) continue;
				if (pfd.LongInstance!=p.LongInstance) continue;
				if (filter.Active)
					if (filter.IsFiltered(pfd)) continue;

				lv.Items.Add(CreateItem(pfd));
			}
		}
		#endregion

		/// <summary>
		/// Create a new instance
		/// </summary>
		/// <param name="lp">The LoadPackage Instance that is containing the package Data</param>
		/// <param name="vf">The used Filter</param>
		public TreeBuilder(LoadedPackage lp, ViewFilter vf)
		{
			pkg = lp;
			filter = vf;
			nodemap = new Hashtable();

			lp.BeforeFileLoad += new SimPe.Events.PackageFileLoadEvent(lp_BeforeFileLoadSave);
			lp.BeforeFileSave += new SimPe.Events.PackageFileSaveEvent(lp_BeforeFileLoadSave);
			lp.BeforeFileClose += new SimPe.Events.PackageFileCloseEvent(lp_BeforeFileLoadSave);
		}

		#region Node Management
		Hashtable nodemap;

		TreeNode GetNode(TreeNodeCollection root, object o, string name, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
		{
			if (nodemap.ContainsKey(o)) return (TreeNode)nodemap[o];

			TreeNode node = new TreeNode(name);
			nodemap[o] = node;

			if (pfd!=null) 
			{
				SimPe.Interfaces.Plugin.Internal.IPackedFileWrapper wrp = FileTable.WrapperRegistry.FindHandler(pfd.Type);
				if (wrp!=null) node.ImageIndex = wrp.WrapperDescription.IconIndex;
				else node.ImageIndex = 0;
				node.SelectedImageIndex = node.ImageIndex;
			}
			
			root.Add(node);
			return node;
		}
		#endregion

		/// <summary>
		/// Adds default treeView Properties
		/// </summary>
		/// <param name="tv"></param>
		TreeNode DefaultTree(TreeView tv) 
		{
			tv.BeginUpdate();
			TreeNode node = new TreeNode("All Resources");
			tv.Nodes.Add(node);

			TreeNodeTag tag = new TreeNodeTag(node.Text, new TreeNodeTag.RefreshResourceList(RefreshAll), null, null);
			node.Tag = tag;

			return node;
		}

		void DefaultTreeFinish(TreeView tv, TreeNode root, int ct)
		{
			root.Expand();
			if (ct<Helper.WindowsRegistry.BigPackageResourceCount) tv.SelectedNode = root;
			
			nodemap.Clear();
			if (ct<Helper.WindowsRegistry.BigPackageResourceCount) UpdateLabels(tv);
			else 
				if (root.Tag!=null)
					if (root.Tag is TreeNodeTag) 
						root.Text = root.Tag.ToString();
			tv.EndUpdate();
		}

		/// <summary>
		/// Updates the Labels of the TreeNodes
		/// </summary>
		/// <param name="tv"></param>
		public void UpdateLabels(TreeView tv) 
		{
			UpdateLabels(tv.Nodes);
		}

		void UpdateLabels(TreeNodeCollection nodes) 
		{
			foreach (TreeNode node in nodes) {

				if (node.Tag!=null)
					if (node.Tag is TreeNodeTag) 
						node.Text = node.Tag.ToString();
					
				UpdateLabels(node.Nodes);
			}
		}

		/// <summary>
		/// Build a TreeView based on the Instance Values
		/// </summary>
		/// <param name="tv"></param>
		public void InstanceView(TreeView tv)
		{
			InstanceTreeBuilder instb = new InstanceTreeBuilder(pkg, filter, tv);
			instb.Finished += new EventHandler(typetb_Finished);
			TreeBuilderBase.Start(instb);		
		}

		/// <summary>
		/// Build a TreeView based on the Group Values
		/// </summary>
		/// <param name="tv"></param>
		public void GroupView(TreeView tv)
		{
			GroupTreeBuilder grptb = new GroupTreeBuilder(pkg, filter, tv);
			grptb.Finished += new EventHandler(typetb_Finished);
			TreeBuilderBase.Start(grptb);				
		}

		/// <summary>
		/// trigered whenever the Update Threads get Finished
		/// </summary>
		public event System.EventHandler Finished;

		/// <summary>
		/// Build a TreeView based on the Group Values
		/// </summary>
		/// <param name="tv"></param>
		public void TypeView(TreeView tv)
		{
			TypeTreeBuilder typetb = new TypeTreeBuilder(pkg, filter, tv);
			typetb.Finished += new EventHandler(typetb_Finished);
			TreeBuilderBase.Start(typetb);			
		}

		private void typetb_Finished(object sender, EventArgs e)
		{			
			if (Finished!=null) Finished(sender, e);
		}

		public void StopAll()
		{
			TreeBuilderBase.Stop();
			ResourceListerBase.Stop();
			Wait.Stop();
		}

		private void lp_BeforeFileLoadSave(LoadedPackage sender, SimPe.Events.FileNameEventArg e)
		{
			StopAll();
		}
	}

	
}
