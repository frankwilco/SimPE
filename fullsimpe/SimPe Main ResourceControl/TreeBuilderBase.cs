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
using System.Threading;
using Ambertation.Threading;

namespace SimPe
{
	public abstract class TreeBuilderBase 
	{
		protected TreeView tv;
		protected LoadedPackage pkg;
		protected ViewFilter filter;
		AllResourceLister arl;

		#region Node Management
		Hashtable nodemap;

		protected TreeNode GetNode(TreeNodeCollection root, object o, string name, SimPe.Interfaces.Files.IPackedFileDescriptor pfd)
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
			
			tv.Invoke(new AddNodeDelegate(AddNode), new object[] { root, node });
			//root.Add(node);
			return node;
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
			foreach (TreeNode node in nodes) 
			{

				if (node.Tag!=null)
					if (node.Tag is TreeNodeTag) 
						node.Text = node.Tag.ToString();
					
				UpdateLabels(node.Nodes);
			}
		}

		protected delegate void AddNodeDelegate(TreeNodeCollection nodes, TreeNode node);
		protected void AddNode(TreeNodeCollection nodes, TreeNode node)
		{
			nodes.Add(node);
		}

		/// <summary>
		/// Adds default treeView Properties
		/// </summary>
		/// <param name="tv"></param>
		protected virtual TreeNode OnInit() 
		{
			//tv.BeginUpdate();
			TreeNode node = new TreeNode("All Resources");
			tv.Invoke(new AddNodeDelegate(AddNode), new object[] { tv.Nodes, node });
			//tv.Nodes.Add(node);

			TreeNodeTag tag = new TreeNodeTag(node.Text, new TreeNodeTag.RefreshResourceList(RefreshAll), null, null);
			node.Tag = tag;

			return node;
		}

		protected virtual void OnFinish(TreeNode root, int ct)
		{
			root.Expand();
			if (ct<Helper.WindowsRegistry.BigPackageResourceCount) 
				tv.SelectedNode = root;
			
			nodemap.Clear();
			UpdateLabels(tv);
			
			tv.Refresh();
		}

		protected ListViewItem CreateItem(SimPe.Interfaces.Files.IPackedFileDescriptor pfd) 
		{			
			UpdatableListViewItem lvi = new UpdatableListViewItem(pfd, pkg.Package);
			return lvi;
		}

		protected void RefreshAll(ListView lv, SimPe.Interfaces.Files.IPackedFileDescriptor p, object tag)
		{
			if (!pkg.Loaded) return;
			arl.Prepare(lv, p, tag);						
			ResourceListerBase.Start(arl);	
		}		

		#endregion

		internal event System.EventHandler Finished;

		internal TreeBuilderBase(LoadedPackage pkg, ViewFilter filter, TreeView tv)
		{
			this.tv = tv;
			this.pkg = pkg;
			this.filter = filter;

			nodemap = new Hashtable();

			arl = new AllResourceLister(pkg, filter);
			arl.Finished += new EventHandler(OnFinishedThread);
			
			run = new ManualResetEvent(false);
			stop = new ManualResetEvent(false);
		}

		protected abstract void BuildNode(TreeNode root, SimPe.Interfaces.Files.IPackedFileDescriptor pfd, int ct);

		
		protected void Start()
		{
			run.Set();	
			bool startedwait = false;
			try 
			{			
				stop.Reset();	
				tv.Nodes.Clear();		
			
				if (pkg.Loaded==false) return;
				
				Wait.Message = "Loading Resource Tree...";
				TreeNode root = OnInit();
				int ct = 0;
				try 
				{
					foreach (SimPe.Interfaces.Files.IPackedFileDescriptor pfd in pkg.Package.Index) 
					{ 			
						BuildNode(root, pfd, ct++);

						if (ct==20 && !startedwait) 
						{
							Wait.SubStart();
							startedwait = true;
						}
						if (stop.WaitOne(0, false)) 
							break;
					}
				} 
				finally 
				{
					OnFinish(root, ct);
				}
			} 
			finally 
			{
				
				if (Finished!=null) Finished(this, new System.EventArgs());
				if (startedwait) Wait.SubStop();
			}
		}		

		protected virtual void OnFinishedThread(object sender, EventArgs e)
		{
			if (Finished!=null) Finished(sender, e);
		}

		ManualResetEvent run;
		protected ManualResetEvent Running
		{
			get {return run;}
		}

		ManualResetEvent stop = new ManualResetEvent(false);
		
		protected ManualResetEvent StopEvent
		{			
			get { return stop; }
		}

		#region Statics
		static TreeBuilderBase last = null;
		static Thread lastthread = null;
		
		public static void Start(TreeBuilderBase tbb)
		{
			Stop();
			
			last = tbb;							
			lastthread = new Thread(new ThreadStart(last.Start));			
			last.Running.Set();
			lastthread.Start();
		}

		public static void Stop()
		{			
			if (last!=null) 
			{		
				last.StopEvent.Set();					
				last.Running.WaitOne();
				last.Running.Reset();
					

				last = null;
				lastthread = null;
			}
		}
		#endregion
		
	}
}
