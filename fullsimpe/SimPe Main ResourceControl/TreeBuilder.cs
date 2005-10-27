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
		public delegate void GenerateView(TreeView tv, bool autoselect);
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
		public void Generate(bool autoselect)
		{
			fkt(tv, autoselect);
		}
	}


	/// <summary>
	/// ZUsed to present a Package in various TreeLists
	/// </summary>
	public class TreeBuilder 
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
			//lv.ListViewItemSorter = null; This is now done in the ResourceLister
		}

		/// <summary>
		/// Deselects all items in te ListView
		/// </summary>
		/// <param name="lv"></param>
		public void DeselectAll(ListView lv)
		{
			lv.BeginUpdate();
			foreach (ListViewItem lvi in lv.Items)
				lvi.Selected = false;
			lv.EndUpdate();
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

			lp.BeforeFileLoad += new SimPe.Events.PackageFileLoadEvent(lp_BeforeFileLoadSave);
			lp.BeforeFileSave += new SimPe.Events.PackageFileSaveEvent(lp_BeforeFileLoadSave);
			lp.BeforeFileClose += new SimPe.Events.PackageFileCloseEvent(lp_BeforeFileLoadSave);

			lp.AfterFileLoad += new SimPe.Events.PackageFileLoadedEvent(lp_AfterFileLoad);
		}		

		/// <summary>
		/// Build a TreeView based on the Instance Values
		/// </summary>
		/// <param name="tv"></param>
		public void InstanceView(TreeView tv, bool autoselect)
		{
			InstanceTreeBuilder instb = new InstanceTreeBuilder(pkg, filter, tv);
			instb.AutoSelect = autoselect;
			instb.Finished += new EventHandler(typetb_Finished);
			TreeBuilderBase.Start(instb);		
		}

		/// <summary>
		/// Build a TreeView based on the Group Values
		/// </summary>
		/// <param name="tv"></param>
		public void GroupView(TreeView tv, bool autoselect)
		{
			GroupTreeBuilder grptb = new GroupTreeBuilder(pkg, filter, tv);
			grptb.AutoSelect = autoselect;
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
		public void TypeView(TreeView tv, bool autoselect)
		{
			TypeTreeBuilder typetb = new TypeTreeBuilder(pkg, filter, tv);
			typetb.AutoSelect = autoselect;
			typetb.Finished += new EventHandler(typetb_Finished);
			TreeBuilderBase.Start(typetb);			
		}

		private void typetb_Finished(object sender, EventArgs e)
		{			
			if (Finished!=null) Finished(sender, e);
		}

		public static void StopAll()
		{
			TreeBuilderBase.Stop();
			ResourceListerBase.Stop();
			Wait.Stop();
		}

		private void lp_BeforeFileLoadSave(LoadedPackage sender, SimPe.Events.FileNameEventArg e)
		{
			StopAll();
		}

		private void lp_AfterFileLoad(LoadedPackage sender)
		{			
		}
	}

	
}
