using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This Control draws a LinkLine between two Controls
	/// </summary>
	public abstract class GraphPanelElement : IDisposable
	{				
		public GraphPanelElement()
		{
			this.bg = Color.Transparent;
			this.fg = Color.Black;

			quality = true;	
			savebound = true;
			CompleteRedraw();
		}

		public virtual void Dispose()
		{
			this.Parent = null;			

			if (this.cachedimage!=null) this.cachedimage.Dispose();
		}
		

		#region Public Properties
		Color bg, fg;
		public Color BackColor
		{
			get { return bg;}
			set 
			{ 
				if (bg!=value)
				{
					bg = value;
					CompleteRedraw();
					Refresh();
				}
			}
		}

		public Color ForeColor
		{
			get { return fg;}
			set 
			{ 
				if (fg!=value)
				{
					fg = value;
					CompleteRedraw();
					Refresh();
				}
			}
		}

		int left, top, width, height;
		public int Left 
		{
			get { return left;}
		}

		public int Top 
		{
			get { return top;}
		}

		public int Width 
		{
			get { return width;}
		}

		public int Height 
		{
			get { return height;}
		}

		public int Right 
		{
			get { return this.BoundingRectangle.Right; }
		}

		public int Bottom 
		{
			get { return this.BoundingRectangle.Bottom; }
		}
		public Point Location
		{
			get 
			{
				return new Point(Left, Top);
			}
			set 
			{
				this.SetBounds(value.X, value.Y, Width, Height);
			}
		}

		public Size Size
		{
			get 
			{
				return new Size(Width, Height);
			}
			set 
			{
				this.SetBounds(Left, Top, value.Width, value.Height);
			}
		}

		public Rectangle BoundingRectangle
		{
			get 
			{
				return new Rectangle(left, top, width, height);
			}
		}

		GraphPanel parent;
		public GraphPanel Parent 
		{
			get {return parent;}
			set {
				if (parent!=value)
				{
					if (parent!=null) 
					{
						parent.LinkItems.Remove(this);
					}
					parent = value;
					if (parent!=null) 
					{
						parent.LinkItems.Add(this);											
					}
					ChangedParent();
					this.Refresh();
				}
			}
		}
		bool quality;
		/// <summary>
		/// true if you want to draw higher Quality Lines
		/// </summary>
		public virtual bool Quality
		{
			get { return quality; }
			set 
			{ 
				if (quality != value) 
				{
					quality = value;
					CompleteRedraw();
					Refresh();	
				}
			}
		}		

		bool savebound;
		public virtual bool SaveBounds
		{
			get { return savebound; }
			set { savebound = value; }
		}	
		#endregion

		#region Properties
		
		#endregion

		#region Event Override
		internal virtual void OnLostFocus(EventArgs e)
		{
			if (LostFocus!=null) LostFocus(this, e);
		}

		internal virtual void OnGotFocus(EventArgs e)
		{
			if (GotFocus!=null) GotFocus(this, e);
		}
		internal void OnPaint(PaintEventArgs e) 
		{				
			
			Rectangle irect = Rectangle.Intersect(this.BoundingRectangle, e.ClipRectangle);
			//if (irect==null) return;
			if (irect.Width==0 || irect.Height==0) return;

			SetGraphicsMode(e.Graphics, true);	
			Rectangle src = new Rectangle(e.ClipRectangle.Left-Left, e.ClipRectangle.Top-Top, e.ClipRectangle.Width, e.ClipRectangle.Height);									
			Rectangle dst = new Rectangle(e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width, e.ClipRectangle.Height);
			
			OnPaint(e.Graphics, cachedimage, dst, src);	
		}

		protected virtual void OnPaint(Graphics g, Image canvas, Rectangle dst, Rectangle src)
		{
			g.DrawImage(canvas, dst, src, System.Drawing.GraphicsUnit.Pixel);	
		}

		public void Refresh()
		{
			if (parent!=null) 
				parent.Invalidate(this.BoundingRectangle);
		}

		public void Invalidate()
		{
			this.CompleteRedraw();
			this.Refresh();
		}

		public void SetBounds(int x, int y, int wd, int hg)
		{
			Rectangle src = new Rectangle(x, y, wd, hg);
			Rectangle dst = this.BoundingRectangle;

			Rectangle r = Rectangle.Union(src, dst);
			
			left = x;
			top = y; 
			width = wd;
			height = hg;						

			if (parent!=null && this.SaveBounds)
			{
				
				if (Right>parent.Width) left = parent.Width - width;
				if (Bottom>parent.Height) top = parent.Height - height;
				if (left<0) left=0;
				if (top<0) top=0;

				src = new Rectangle(left, top, width, height);
			}
			
			if (src.Width!=dst.Width || src.Height!=dst.Height) 
			{
				this.CompleteRedraw();
				if (SizeChanged!=null) SizeChanged(this, new System.EventArgs());
			}
			if ((src.X!=dst.X || src.Y!=dst.Y) && Move!=null) Move(this, new System.EventArgs());

			if (parent!=null) parent.Invalidate(r);
			//Refresh();
		}
		#endregion

		
		#region Drawing Support Methods
		internal static void SetGraphicsMode(Graphics g, bool fast)
		{
			if (fast) 
			{
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
				g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
			} 
			else 
			{
				g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
			}
		}	
				
		#endregion

		#region Basic Draw Methods
		

		Image cachedimage;
		protected void CompleteRedraw()
		{
			if (Width==0) return;
			if (Height==0) return;										
			if (cachedimage!=null) cachedimage.Dispose();			

			cachedimage = new Bitmap(Width, Height);
			Graphics g = Graphics.FromImage(cachedimage);
			CompleteRedraw(g);
			g.Dispose();
		}

		protected void CompleteRedraw(Graphics g)
		{
			SetGraphicsMode(g, true);						
			g.FillRectangle(new SolidBrush(this.BackColor), 0, 0, Width, Height);
			SetGraphicsMode(g, !quality);						
			UserDraw(g);
		}

		protected abstract void UserDraw(Graphics g);

		public event System.EventHandler Move;
		public event System.EventHandler SizeChanged;
		#endregion		

		public void SendToBack()
		{
			if (parent==null) return;
			parent.LinkItems.Remove(this);
			parent.LinkItems.Insert(0, this);
			Refresh();
		}

		public void SendToFront()
		{
			if (parent==null) return;
			parent.LinkItems.Remove(this);
			parent.LinkItems.Add(this);
			Refresh();
		}

		internal virtual void ChangedParent()
		{
			if (parent!=null) 
			{
				this.Quality = parent.Quality;
				this.SaveBounds = parent.SaveBounds;
			}
		}

		
		public abstract void Clear();

		#region Events
		public event System.EventHandler GotFocus;
		public event System.EventHandler LostFocus;
		#endregion
	}
}
