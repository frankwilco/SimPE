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
	/// This is a Rounded Panel
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
		

		#region public Properties
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

		private void childs_ItemsChanged(GraphItems sender, GraphItemChangedEventArgs e)
		{
			if (e.Added && sender.Count==1) Refresh();
			if (e.Removed && sender.Count==0) Refresh();

			if (e.Added) 
			{
				LinkGraphic lc = new LinkGraphic();
				lc.ForeColor = this.CurrentLinkColor;
				lc.Parent = (GraphPanel)Parent;
				lc.StartElement = this;
				lc.EndElement = e.GraphItem;
				lc.StartAnchorSnap = LinkControlSnapAnchor.NoCorners;
				lc.EndAnchorSnap = LinkControlSnapAnchor.NoCorners;
				lc.LineMode = this.LineMode;
				lc.Quality = this.Quality;
				lc.Text = e.Text;
				
				lc.SendToBack();
				lcmap.Add(e.GraphItem, lc);				
			}

			if (e.Removed) 
			{
				LinkGraphic lc = (LinkGraphic)lcmap[e.GraphItem];
				if (lc!=null)
				{
					lcmap.Remove(lc);
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
			foreach (LinkGraphic lc in lcmap.Values) lc.Dispose();
			lcmap.Clear();
			
			foreach (GraphItemBase gib in childs) gib.Dispose();
			childs.Clear();

			foreach (GraphItemBase gib in parents) gib.Dispose();
			parents.Clear();
		}
	}
}
