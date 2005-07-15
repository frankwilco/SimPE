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
using System.Drawing.Drawing2D;
using System.Data;
using System.Windows.Forms;
using Ambertation.Collections;

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This is the basic classed that should be inherited by all <see cref="GraphPanel"/> Items.
	/// </summary>
	public abstract class GraphItemBase : DragPanel
	{
		
		public GraphItemBase() : base()
		{
			childs = new GraphItems();
			childs.ItemsChanged += new GraphItemsChanged(childs_ItemsChanged);

			parents = new GraphItems();
			parents.ItemsChanged +=new GraphItemsChanged(parents_ItemsChanged);
			
			
			alcol = Color.DarkOrange;

			lcol = Color.Silver;
			ainlcol = Color.DimGray;
			tofront = true;

			lm = Ambertation.Windows.Forms.Graph.LinkControlLineMode.Bezier;

			lcmap = new Hashtable();
		}		
		

		public override void Dispose()
		{
			tag = null;
			base.Dispose ();
		}

		#region public Properties
		protected DockPoint[] docks;
		public DockPoint[] Docks
		{
			get { 
				if (docks==null) this.SetupDocks();				
				return docks; 
			}
		}

		object tag;
		public object Tag
		{
			get {return tag;}
			set {tag = value;}
		}

		Ambertation.Windows.Forms.Graph.LinkControlLineMode lm;
		public Ambertation.Windows.Forms.Graph.LinkControlLineMode LineMode
		{
			get {return lm; }
			set 
			{				
				lm = value;
				this.SetLinkLineMode();
			}
		}

		public override bool Quality
		{
			get { return base.Quality; }
			set 
			{
				base.Quality = value;
				this.SetLinkQuality();
			}
		}
		Color lcol;
		public Color LinkColor 
		{
			get {return lcol;}
			set 
			{
				if (lcol!=value)
				{
					lcol=value;
					Refresh();
				}
			}
		}

		
		Color alcol;
		public Color ActiveOutgoingLinkColor 
		{
			get {return alcol;}
			set 
			{
				if (alcol!=value)
				{
					alcol=value;
					Refresh();
				}
			}
		}
		Color ainlcol;
		public Color ActiveIncomingLinkColor 
		{
			get {return ainlcol;}
			set 
			{
				if (ainlcol!=value)
				{
					ainlcol=value;
					Refresh();
				}
			}
		}

		bool tofront;
		public bool AutoBringToFront
		{
			get { return tofront; }
			set { tofront = value; }
		}
		
		#endregion

		#region Properties
		GraphItems childs;
		[Browsable(false)]
		public GraphItems ChildItems 
		{
			get {return childs;}
		}

		GraphItems parents;		
		[Browsable(false)]
		public GraphItems ParentItems 
		{
			get {return parents;}
		}
		#endregion


		

		#region Event Override
		internal override void OnGotFocus(System.EventArgs e)
		{			
			if (this.AutoBringToFront)
			{
				SendAllParentLinksToFront();			
				SendAllParentsToFront();
				SendAllLinksToFront();
				SendAllChildsToFront();
			}

			base.OnGotFocus(e);
			SetLinkColors(this.ActiveOutgoingLinkColor);
			SetParentLinkColors(this.ActiveIncomingLinkColor);
		}

		internal override void OnLostFocus(System.EventArgs e)
		{
			base.OnLostFocus(e);
			SetLinkColors(this.LinkColor);
			SetParentLinkColors(LinkColor);
		}
		#endregion

		#region Basic Draw Methods						
		
		#endregion

		#region LinkGraphic Control
		void SetLinkLineMode()
		{
			foreach (LinkGraphic lc in lcmap.Values) lc.LineMode = lm;
		}

		void SetLinkQuality()
		{
			foreach (LinkGraphic lc in lcmap.Values) lc.Quality = this.Quality;
		}

		Hashtable lcmap;
		void SetLinkColors(Color cl)
		{
			foreach (LinkGraphic lc in lcmap.Values) 
			{
				lc.ForeColor = cl;
			}
		}

		void SendAllLinksToFront()
		{
			foreach (LinkGraphic lc in lcmap.Values) lc.SendToFront();
		}

		void SendAllParentLinksToFront()
		{
			foreach (GraphItemBase gi in this.parents) gi.SendAllChildLinksToFront(this);
		}

		protected void SendAllChildLinksToFront(GraphItemBase sender)
		{
			foreach (GraphItemBase lg in this.childs) 
				if (lg==sender) 
				{
					LinkGraphic lc = (LinkGraphic)lcmap[lg];
					if (lc!=null) lc.SendToFront();
				}
		}

		void SendAllChildsToFront()
		{
			foreach (GraphItemBase gi in this.childs) gi.SendToFront();
		}

		void SendAllParentsToFront()
		{
			foreach (GraphItemBase gi in this.parents) gi.SendToFront();
		}

		protected void SetChildLinkColor(GraphItemBase sender, Color cl)
		{
			foreach (GraphItemBase lg in this.childs) 
				if (lg==sender) 
				{
					LinkGraphic lc = (LinkGraphic)lcmap[lg];
					if (lc!=null) lc.ForeColor = cl;
				}
		}

		protected void SetParentLinkColors(Color cl)
		{
			foreach (GraphItemBase lg in this.parents) 
				lg.SetChildLinkColor(this, cl);
		}

		Color CurrentLinkColor
		{
			get 
			{
				if (Focused) return this.ActiveOutgoingLinkColor;
				return this.LinkColor;
			}
		}
		#endregion

		protected virtual void InitDocks()
		{
			if (docks==null) 
			{
				docks = new DockPoint[8];								
				
				docks[0] = new DockPoint(0, 0, LinkControlType.MiddleLeft);				
				docks[1] = new DockPoint(0, 0, LinkControlType.MiddleRight);
				docks[2] = new DockPoint(0, 0, LinkControlType.TopCenter);
				docks[3] = new DockPoint(0, 0, LinkControlType.TopLeft);				
				docks[4] = new DockPoint(0, 0, LinkControlType.TopRight);				
				docks[5] = new DockPoint(0, 0, LinkControlType.BottomCenter);
				docks[6] = new DockPoint(0, 0, LinkControlType.BottomLeft);
				docks[7] = new DockPoint(0, 0, LinkControlType.BottomRight);
			}
		}
		protected virtual void SetupDocks()
		{	
			if (docks==null) InitDocks();
			docks[0].X = Left;  docks[0].Y = Top+Height/2;
			docks[1].X = Left+Width;  docks[1].Y = Top+Height/2;
			docks[2].X = Left+Width/2;  docks[2].Y = Top;
			docks[3].X = Left;  docks[3].Y = Top;			
			docks[4].X = Left+Width;  docks[4].Y = Top;
			docks[5].X = Left+Width/2;  docks[5].Y = Top+Height;
			docks[6].X = Left;  docks[6].Y = Top+Height;			
			docks[7].X = Left+Width;  docks[7].Y = Top+Height;
		}

		private void childs_ItemsChanged(GraphItems sender, GraphItemChangedEventArgs e)
		{
			if (e.Added && sender.Count==1) Refresh();
			if (e.Removed && sender.Count==0) Refresh();

			if (e.Added) 
			{
				LinkGraphic lc = new LinkGraphic();
				lc.Text = e.Text;
				lc.ForeColor = this.CurrentLinkColor;
				lc.Parent = (GraphPanel)Parent;
				lc.StartElement = this;
				lc.EndElement = e.GraphItem;
				lc.StartAnchorSnap = LinkControlSnapAnchor.OnlyCenter;
				lc.EndAnchorSnap = LinkControlSnapAnchor.OnlyCenter;
				lc.LineMode = this.LineMode;
				lc.Quality = this.Quality;
				
				
				lc.SendToBack();
				lcmap.Add(e.GraphItem, lc);				
			}

			if (e.Removed) 
			{
				LinkGraphic lc = (LinkGraphic)lcmap[e.GraphItem];
				if (lc!=null)
				{
					lcmap.Remove(lc);
					lc.Parent = null;
					lc.Dispose();
				}
			}
			if (e.Internal) return;
			if (e.Added) e.GraphItem.ParentItems.SilentAdd(this, e.Text, true);
			if (e.Removed) e.GraphItem.ParentItems.SilentRemove(this, true);
		}

		private void parents_ItemsChanged(GraphItems sender, GraphItemChangedEventArgs e)
		{
			if (e.Added && sender.Count==1) Refresh();
			if (e.Removed && sender.Count==0) Refresh();

			if (e.Internal) return;
			if (e.Added) e.GraphItem.ChildItems.SilentAdd(this, e.Text, true);
			if (e.Removed) e.GraphItem.ChildItems.SilentRemove(this, true);
		}

		internal override void ChangedParent()
		{
			base.ChangedParent();
			if (Parent!=null) LineMode = Parent.LineMode;

			foreach (LinkGraphic lc in lcmap.Values) 
				lc.Parent = this.Parent;
		}

		public LinkGraphic[] GetChildLinks()
		{
			LinkGraphic[] ret = new LinkGraphic[lcmap.Count];
			int ct=0;
			foreach (LinkGraphic lg in lcmap.Values) ret[ct++] = lg;
			return ret;
		}

		public LinkGraphic GetChildLink(GraphItemBase child)
		{
			return (LinkGraphic)lcmap[child];
		}

		public override void Clear()
		{
			foreach (LinkGraphic lc in lcmap.Values) 
			{
				lc.Parent = null;
				lc.Dispose();
			}
			lcmap.Clear();
			
			GraphItemBase[] gibs = new GraphItemBase[childs.Length];
			childs.CopyTo(gibs);
			foreach (GraphItemBase gib in gibs) 			
				gib.ParentItems.Remove(this);

			gibs = new GraphItemBase[parents.Length];
			parents.CopyTo(gibs);
			foreach (GraphItemBase gib in gibs)
				gib.ChildItems.Remove(this);

			//foreach (GraphItemBase gib in childs) gib.Dispose();
			childs.Clear();

			//foreach (GraphItemBase gib in parents) gib.Dispose();
			parents.Clear();
		}

		protected override void OnSizeChanged()
		{
			base.OnSizeChanged ();
			SetupDocks();
		}

		protected override void OnMove()
		{
			base.OnMove ();
			SetupDocks();
		}

		

		protected override void RemoveFromParent()
		{
			LinkGraphic[] lgs = GetChildLinks();
			foreach (LinkGraphic lg in lgs)
				lg.Parent = null;						

			GraphItemBase[] gibs = new GraphItemBase[parents.Length];
			parents.CopyTo(gibs);
			foreach (GraphItemBase gib in gibs) 			
				gib.ChildItems.Remove(this);

			base.RemoveFromParent();
		}

		protected override void AddToParent()
		{
			LinkGraphic[] lgs = GetChildLinks();
			foreach (LinkGraphic lg in lgs)
				this.Parent.LinkItems.Add(lg);

			base.AddToParent();
		}



		/// <summary>
		/// Returns the best fitting Docks
		/// </summary>
		/// <param name="d1">The available Docks for the first Control</param>
		/// <param name="lsa1">The Link Mode for the first Control</param>
		/// <param name="l1">The currently used Dock for the first Controls</param>
		/// <param name="d2">The available Docks for the second Control</param>
		/// <param name="lsa2">The Link Mode for the second Control</param>
		/// <param name="l2">The currently used Dock for the second Controls</param>
		/// <returns>X=Index for the first Control, Y=index for the second Control</returns>
		public static Point FindBestDocks(DockPoint[] d1, LinkControlSnapAnchor lsa1, int l1, DockPoint[] d2, LinkControlSnapAnchor lsa2, int l2)
		{
			int i1 = l1;
			int i2 = l2;
			double odist = d1[l1].Distance(d2[l2]);
			double mindelta = -odist * 0.15;
			double dist = odist;
			if ((lsa1 == LinkControlSnapAnchor.OnlyCenter && !d1[l1].IsCenterDock)
				||(lsa2 == LinkControlSnapAnchor.OnlyCenter && !d2[l2].IsCenterDock)) 
			{
				dist = double.MaxValue;
			}

			for (int i=0; i<d1.Length; i++) 
			{
				if (lsa1 == LinkControlSnapAnchor.OnlyCenter && !d1[i].IsCenterDock) continue;
				for (int j=d2.Length-1; j>=0; j--)
				{
					if (d1[i].IsSideDock != d2[j].IsSideDock) continue;
					if (lsa2 == LinkControlSnapAnchor.OnlyCenter && !d2[j].IsCenterDock) continue;
					double len =  d1[i].Distance(d2[j]);
					if (len-dist<=mindelta)
					{
						dist = len;
						i1 = i; 
						i2 = j;
					}
				}
			}

			return new Point(i1, i2);
		}		
	}
}
