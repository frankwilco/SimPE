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
using Ambertation.Windows.Forms.Graph;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	/// This is a Dragable Panel
	/// </summary>
	public class GraphPanel : System.Windows.Forms.Panel
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		Ambertation.Collections.GraphElements li;
		internal Ambertation.Collections.GraphElements LinkItems
		{
			get { return li;}
		}

		protected Ambertation.Collections.GraphElements Items
		{
			get { return li;}
		}
		
		public GraphPanel()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);
			li = new Ambertation.Collections.GraphElements();
			li.ItemsChanged += new EventHandler(li_ItemsChanged);
			this.BackColor = SystemColors.ControlLightLight;
			lm = LinkControlLineMode.Bezier;
			quality = true;
			savebound = true;
			minwd = 0;
			minhg = 0;
			lk = false;
			update = false;

			autosz = false;
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

				if (li!=null) 
				{
					while (li.Count>0) 
					{
						GraphPanelElement l = li[0];
						li.RemoveAt(0);
						l.Dispose();
					}
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
			components = new System.ComponentModel.Container();
		}
		#endregion

		#region Properties
		public new Control Parent
		{
			get {return base.Parent;}
			set 
			{
				if (base.Parent!=value)
				{
					if (Parent!=null) Parent.SizeChanged -= new EventHandler(Parent_SizeChanged);
					base.Parent = value;
					if (Parent!=null)
					{
						MinWidth = Parent.ClientRectangle.Width;
						MinHeight = Parent.ClientRectangle.Height;
						Parent.SizeChanged += new EventHandler(Parent_SizeChanged);
					}
				}
			}
		}
		bool lk;
		public bool LockItems
		{
			get {return lk;}
			set { 
				if (lk!=value)
				{
					lk = value;
					SetLocked();
				}
			}
		}
		bool savebound;
		public virtual bool SaveBounds
		{
			get { return savebound; }
			set { savebound = value; }
		}

		bool autosz;
		public bool AutoSize
		{
			get {return autosz;}
			set 
			{
				autosz = value;
				this.li_ItemsChanged(li, null);
				if (autosz) Dock = DockStyle.None;
			}
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

		bool quality;
		public bool Quality
		{
			get { return quality; }
			set 
			{
				quality = value;
				this.SetLinkQuality();
			}
		}
		int minwd, minhg;
		public int MinWidth
		{
			get { return minwd; }
			set 
			{
				minwd = value;
				Width = Math.Max(Width, minwd);
			}
		}

		
		public int MinHeight
		{
			get { return minhg; }
			set 
			{
				minhg = value;
				Height = Math.Max(Height, minhg);
			}
		}

		[Browsable(false)]
		public override bool AutoScroll
		{
			get
			{
				return base.AutoScroll;
			}
			set
			{				
			}
		}

		[Browsable(false)]
		public GraphPanelElement SelectedElement
		{
			get 
			{
				foreach (GraphPanelElement gpe in li) 
					if ( gpe is DragPanel) 					
						if (((DragPanel)gpe).Focused)
							return gpe;					

				return null;
			}
			set 
			{
				if (value==null) return;
				if (!(value is DragPanel)) return;

				if (li.Contains(value))
				{
					GraphPanelElement[] elements = new GraphPanelElement[li.Count];
					li.CopyTo(elements);
					foreach (GraphPanelElement gpe in elements) 
						if ( gpe is DragPanel)
						{
							((DragPanel)gpe).SetFocus(gpe==value);					
							/*if (gpe==value)
							{
								Label lb = new Label();
								lb.Location = gpe.Location;
								lb.Visible = true;
								lb.Parent = this;
								
								this.ScrollControlIntoView(lb);
								lb.Parent = null;
								lb.Dispose();
							}*/
						}
				}
			}
		}
		#endregion

		

		#region Event Override		
		protected override void OnPaintBackground(PaintEventArgs e)
		{					
			base.OnPaintBackground (e);											
		}

		
		protected override void OnPaint(PaintEventArgs e)
		{									
			if (update) return;
			base.OnPaint(e);
			GraphPanelElement.SetGraphicsMode(e.Graphics, true);
			foreach (GraphPanelElement c in li) c.OnPaint(e);	
		}		

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown (e);
			bool hit = false;
			GraphPanelElement[] elements = new GraphPanelElement[li.Count];
			li.CopyTo(elements);
			for (int i=elements.Length-1; i>=0; i--){
				GraphPanelElement c = elements[i]; 
			
				if (c is DragPanel) 
				{	
					if (!hit) 
						if (((DragPanel)c).OnMouseDown(e)) 
						{	
							if (e.Button==System.Windows.Forms.MouseButtons.Left) 
							{
								hit = true;
								((DragPanel)c).SetFocus(true);
								continue;
							}
						}
					
					if (e.Button==System.Windows.Forms.MouseButtons.Left) ((DragPanel)c).SetFocus(false);
					
				}
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove (e);
			for (int i=li.Count-1; i>=0; i--)
			{
				GraphPanelElement c = li[i]; 
			
				if (c is DragPanel)  
				{					
					if (((DragPanel)c).OnMouseMove(e)) break;
				}
			}
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp (e);
			for (int i=li.Count-1; i>=0; i--)
			{
				GraphPanelElement c = li[i]; 
			
				if (c is DragPanel) 
				{					
					if (((DragPanel)c).OnMouseUp(e)) break;
				}
			}
		}

		protected override void AdjustFormScrollbars(bool displayScrollbars)
		{
			base.AdjustFormScrollbars (displayScrollbars);			
		}


		#endregion

		void SetLinkLineMode()
		{
			foreach (GraphPanelElement gpe in li) gpe.ChangedParent();
		}

		void SetLinkQuality()
		{
			foreach (GraphPanelElement gpe in li) gpe.ChangedParent();
		}

		void SetSaveBound()
		{
			foreach (GraphPanelElement gpe in li) gpe.SaveBounds = this.SaveBounds;
		}

		void SetLocked()
		{
			foreach (GraphPanelElement gpe in li) 
			{
				if (gpe is DragPanel)
					((DragPanel)gpe).Movable = !this.LockItems;
			}
		}

		private void li_ItemsChanged(object sender, EventArgs e)
		{
			if (!autosz) return;
			int mx = 0;
			int my = 0;
			foreach (GraphPanelElement gpe in li)
			{
				mx = Math.Max(mx, gpe.Right);
				my = Math.Max(my, gpe.Bottom);
			}

			this.Width = Math.Max(mx, MinWidth);
			this.Height = Math.Max(my, MinHeight);
		}

		private void Parent_SizeChanged(object sender, EventArgs e)
		{
			MinWidth = Parent.ClientRectangle.Width;
			MinHeight = Parent.ClientRectangle.Height;
		}

		bool update;
		public void BeginUpdate()
		{
			update = true;
		}

		public void EndUpdate()
		{
			update=false;
			Refresh();
		}

		public void Clear()
		{
			while (li.Count>0) 
			{
				GraphPanelElement l = li[0];
				li.RemoveAt(0);
				l.Clear();
				l.Parent = null;
			}
		
			this.Refresh();
		}

		/// <summary>
		/// Calculate the Radius of a Circle you can use to place Items on
		/// </summary>
		/// <param name="centersize">The Size of the Item that should be presented in the center of the Cricle</param>
		/// <param name="itemsize">The size of the Items that should sourrpund the circle</param>
		/// <param name="itemcount">The number of items that should surround the Center</param>
		/// <returns>The calculated Radius</returns>
		public static double GetPinCircleRadius(Size centersize, Size itemsize, int itemcount)
		{
			double alpha = Math.Max(0.01, Math.Min(Math.PI/2, 2*Math.PI / itemcount));
			double l = Math.Max(itemsize.Width, itemsize.Height) * Math.Sqrt(2);
			double minl = Math.Max(centersize.Width, centersize.Height) * Math.Sqrt(0.5) + l/2;

			return Math.Max(l/(2*Math.Sin(alpha)), minl);
		}

		/// <summary>
		/// Calculate sthe location of an Item on a Circle
		/// </summary>
		/// <param name="center">The centner of the Circle</param>
		/// <param name="r">The radius (as caluclated in <see cref="GetPinCircleRadius"/>)</param>
		/// <param name="nr">The number of the item on the circle</param>
		/// <param name="itemcount">Maximum Number of Items on the circle</param>
		/// <param name="itemsize">The Size of the Item</param>
		/// <returns>the point for the given Location</returns>
		public static Point GetItemLocationOnPinCricle(Point center, double r, int nr, int itemcount, Size itemsize)
		{
			double alpha = (2*Math.PI / itemcount) * nr;

			return new Point(center.X+(int)(Math.Cos(alpha)*r)-itemsize.Width/2, center.Y+(int)(Math.Sin(alpha)*r)-itemsize.Height/2);
		}

		public static Point GetCenterLocationOnPinCircle(Point center, double r, Size itemsize)
		{
			return new Point(center.X-itemsize.Width/2, center.Y-itemsize.Height/2);
		}
	}
}
