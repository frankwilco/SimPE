using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms.Graph
{
	public enum LinkControlAnchor:byte
	{
		TopLeft = 0x0, //00 00
		TopCenter = 0x2, //00 10
		TopRight = 0x3, // 00 11
		MiddleRight = 0xb, // 10 11
		BottomRight = 0xf, // 11 11
		BottomCenter = 0xe, // 11 10
		BottomLeft = 0xc, // 11 00
		MiddleLeft = 0x8//10 00
	}

	public enum LinkControlLineMode:byte
	{
		Line = 0x0,
		Stair = 0x1,
		Bezier = 0x2
	}	

	public enum LinkControlCapType:byte
	{
		None = 0xff,
		Disk = 0x0,
		Arrow = 0x1
	}

	public enum LinkControlSnapAnchor:byte
	{
		None = 0xff,
		All = 0x0,
		NoCorners = 0x1
	}

	/// <summary>
	/// This Control draws a LinkLine between two Controls
	/// </summary>
	public class LinkGraphic : GraphPanelElement
	{
		
		
		public LinkGraphic()
		{
			this.sa = LinkControlAnchor.BottomCenter;
			this.ea = LinkControlAnchor.TopCenter;
			this.lclm = LinkControlLineMode.Bezier;
			this.psa = LinkControlCapType.Disk;
			this.pea = LinkControlCapType.Arrow;
			ssa = LinkControlSnapAnchor.NoCorners;
			esa = LinkControlSnapAnchor.All;
			txt = "";
			fnt = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			
			
			tfg = SystemColors.WindowText;
			tbg = SystemColors.Window;
			lw = 2;
		}

		public override void Dispose()
		{
			base.Dispose();			
			this.Clear();		
		}
		

		#region Public Properties
		Font fnt;
		public Font Font
		{
			get { return fnt; }
			set 
			{ 
				if (fnt!=value) 
				{
					fnt = value;  
					this.Refresh();
				}
			}
		}
	
		GraphPanelElement sc, ec;
		/// <summary>
		/// Returns /Sets the Start Control
		/// </summary>
		public GraphPanelElement StartElement
		{
			get {return sc; }
			set 
			{
				if (sc != value) 
				{
					SetupAnchor(sc, false);
					sc = value;
					SetupAnchor(sc, true);
					AlignToControl();
					MoveControl();
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		/// <summary>
		/// Returns /Sets the End Control
		/// </summary>
		public GraphPanelElement EndElement
		{
			get {return ec; }
			set 
			{
				if (ec != value) 
				{
					SetupAnchor(ec, false);
					ec = value;
					SetupAnchor(ec, true);
					AlignToControl();
					MoveControl();
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		LinkControlSnapAnchor ssa, esa;
		/// <summary>
		/// Returns / Sets whether or not the StartAnchor should auto snap to the StartElement
		/// </summary>
		public LinkControlSnapAnchor StartAnchorSnap
		{
			get { return ssa; }
			set 
			{ 
				if (ssa!=value) 
				{ 
					ssa = value;
					AlignToControl();
					MoveControl();
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		/// <summary>
		/// Returns / Sets whether or not the EndAnchor should auto snap to the EndElement
		/// </summary>
		public LinkControlSnapAnchor EndAnchorSnap
		{
			get { return esa; }
			set 
			{ 
				if (esa!=value) 
				{ 
					esa = value;	
					AlignToControl();
					MoveControl();
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		LinkControlAnchor sa, ea;
		/// <summary>
		/// Returns / Sets the start Anchor
		/// </summary>
		public LinkControlAnchor StartAnchor 
		{
			get { return sa; }
			set 
			{ 
				if (sa!=value) 
				{ 
					sa = value;					
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		/// <summary>
		/// Returns / Sets the end Anchor
		/// </summary>
		public LinkControlAnchor EndAnchor 
		{
			get { return ea; }
			set 
			{ 
				if (ea!=value) 
				{ 

					ea = value;
					
					CompleteRedraw();
					Refresh();	
				}
			}
		}
		
		int lw;
		/// <summary>
		/// The Width of the Lines this Control draws
		/// </summary>
		public int LineWidth
		{
			get { return lw; }
			set 
			{ 
				if (lw != value) 
				{
					lw = value;
					CompleteRedraw();
					Refresh();	
				}
			}
		}		

		LinkControlCapType psa, pea;
		/// <summary>
		/// Returns / Sets wether or not to draw an Error on the start of the Line
		/// </summary>
		public LinkControlCapType StartCap
		{
			get {return psa; }
			set 
			{
				if (psa != value) 
				{
					psa = value;
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		/// <summary>
		/// Returns / Sets wether or not to draw an Error on the end of the Line
		/// </summary>
		public LinkControlCapType EndCap
		{
			get {return pea; }
			set 
			{
				if (pea != value) 
				{
					pea = value;
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		LinkControlLineMode lclm;
		/// <summary>
		/// Returns / Sets the type of the Line
		/// </summary>
		public LinkControlLineMode LineMode
		{
			get {return lclm; }
			set 
			{
				if (lclm != value) 
				{
					lclm = value;
					CompleteRedraw();
					Refresh();	
				}
			}
		}

		string txt;
		public string Text
		{
			get { return txt; }
			set 
			{
				txt = value;
				this.CompleteRedraw();
				Refresh();
			}
		}

		Color tbg, tfg;
		public Color TextBackColor
		{
			get { return tbg;}
			set 
			{ 
				if (tbg!=value)
				{
					tbg = value;
					CompleteRedraw();
					Refresh();
				}
			}
		}
		
		public Color TextForeColor
		{
			get { return tfg;}
			set 
			{ 
				if (tfg!=value)
				{
					tfg = value;
					CompleteRedraw();
					Refresh();
				}
			}
		}
		#endregion

		#region Properties
		[Browsable(false)]
		public int SnapThreshhold
		{
			get {return 12;}
		}
		#endregion		

		
		#region Drawing Support Methods		
		
		protected System.Drawing.Drawing2D.CustomLineCap PaintCap(Graphics g, Pen pen, Point loc, LinkControlCapType lcct, bool start)
		{
			Size hasz = HalfArrowSize;
			Size asz = ArrowSize;
			if (lcct==LinkControlCapType.Arrow) 
			{
				if (start) pen.CustomStartCap = new System.Drawing.Drawing2D.AdjustableArrowCap(hasz.Width, hasz.Height);
				else pen.CustomEndCap = new System.Drawing.Drawing2D.AdjustableArrowCap(hasz.Width, hasz.Height);
			}
			else if (lcct== LinkControlCapType.Disk)
			{
				g.FillEllipse(new SolidBrush(this.ForeColor), loc.X-hasz.Width, loc.Y-hasz.Height, asz.Width, asz.Height);
			}

			return null;
		}

		protected void DrawNiceRoundRect(Graphics gr, int left, int top, int width, int height, int rad)
		{
			Rectangle srect = new Rectangle(left, top, width-1, height-1);

			
			Pen linepen = new Pen(this.ForeColor);
			Brush b = new SolidBrush(this.TextBackColor);
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gr, b, srect, rad);	
			b.Dispose();							
			
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gr, linepen, srect, rad);
			linepen.Dispose();
			
		}
		#endregion

		#region Placement		
		public static Size ArrowSize
		{
			get { return new Size(8, 8); }
		}
		
		public static Size HalfArrowSize
		{
			get { return new Size(ArrowSize.Width/2, ArrowSize.Height/2); }
		}

		protected Point GetAnchorLocation(LinkControlAnchor lca, GraphPanelElement c)
		{
			return GetAnchorLocation(lca, c, new Point(0,0));
		}

		protected bool SideAnchor(LinkControlAnchor lca)
		{
			int yl = ((byte)lca >> 2) & (byte)0x3;
			return (yl==0x2);
		}

		protected Point GetAnchorLocation(LinkControlAnchor lca, GraphPanelElement c, Point offset)
		{			
			int yl = ((byte)lca >> 2) & (byte)0x3;
			int xl = (byte)lca & (byte)0x3;

			int x = c.Left;
			if (xl==0x2) x = (c.Left + c.Right) / 2;
			else if (xl==0x3) x = c.Right;

			int y = c.Top;
			if (yl==0x2) y = (c.Top + c.Bottom) / 2;
			else if (yl==0x3) y = c.Bottom;

			return new Point(x-offset.X, y-offset.Y);
		}

		protected Point MinPoint(Point p1, Point p2)
		{
			return new Point(Math.Min(p1.X, p2.X), Math.Min(p1.Y, p2.Y));
		}

		protected Point MaxPoint(Point p1, Point p2)
		{
			return new Point(Math.Max(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
		}

		protected void MoveControl()
		{
			if (sc==null || ec==null) return;
			Point pstart = this.GetAnchorLocation(sa, sc);
			Point pend = this.GetAnchorLocation(ea, ec);
			Size asz = HalfArrowSize;

			Point min = MinPoint(pstart, pend);
			Point max = MaxPoint(pstart, pend);
			min.X -= asz.Width;
			min.Y -= asz.Height;
			max.X += asz.Width;
			max.Y += asz.Height;

			int wd = max.X-min.X;
			int hg = max.Y-min.Y;
			int left = min.X;
			int top = min.Y;
			
			if (Text!="") 
			{
				Bitmap b = new Bitmap(1, 1);
				Graphics g = Graphics.FromImage(b);
				SizeF sz = g.MeasureString(Text, Font);
				g.Dispose();
				b.Dispose();
				int nwd = (int)Math.Max(sz.Width+5, wd);
				int nhg = (int)Math.Max(sz.Height+5, hg);


				left -= (nwd-wd)/2;
				top -= (nhg-hg)/2;
				wd = nwd;
				hg = nhg;
			}
			this.SetBounds(left, top, wd, hg);			
		}

		protected LinkControlAnchor AlignToControl(GraphPanelElement s, GraphPanelElement e, LinkControlAnchor def, bool centers)
		{
			if (s==null || e==null) return def;
			if (centers) 
			{
				if (s.Bottom<=e.Top-SnapThreshhold && !(s.Top<=e.Top && s.Bottom>=e.Bottom)) return LinkControlAnchor.BottomCenter;				
				if (s.Top>=e.Bottom+SnapThreshhold && !(s.Top<=e.Top && s.Bottom>=e.Bottom)) return LinkControlAnchor.TopCenter;

				if (s.Right<e.Left-SnapThreshhold) return LinkControlAnchor.MiddleRight;
				else return LinkControlAnchor.MiddleLeft;
			} 
			else 
			{
				if (s.Right < e.Left-SnapThreshhold && !(s.Left<=e.Left && s.Right>=e.Right))
				{
					if (s.Bottom<e.Top-SnapThreshhold) return LinkControlAnchor.BottomRight;
					else if (s.Top>e.Bottom+SnapThreshhold) return LinkControlAnchor.TopRight;
					else return LinkControlAnchor.MiddleRight;
				} 
				else if (s.Left >e.Right+SnapThreshhold && !(s.Left<=e.Left && s.Right>=e.Right)) 
				{
					if (s.Bottom<e.Top-SnapThreshhold) return LinkControlAnchor.BottomLeft;
					else if (s.Top>e.Bottom+SnapThreshhold) return LinkControlAnchor.TopLeft;
					else return LinkControlAnchor.MiddleLeft;
				} 
				else 
				{
					if (s.Bottom<e.Top-SnapThreshhold) return LinkControlAnchor.BottomCenter;
					else if (s.Top>e.Bottom+SnapThreshhold) return LinkControlAnchor.TopCenter;			 
					
				}
			}

			return def;
		}
		
		protected void AlignToControl()
		{
			if (ssa!=LinkControlSnapAnchor.None) this.sa = AlignToControl(sc, ec, sa, ssa==LinkControlSnapAnchor.NoCorners);
			if (esa!=LinkControlSnapAnchor.None) this.ea = AlignToControl(ec, sc, ea, esa==LinkControlSnapAnchor.NoCorners);
		}
		#endregion

		#region Basic Draw Methods
		protected override void UserDraw(Graphics g)
		{
			if (sc==null || ec==null) return;
			
			Size asz = HalfArrowSize;
			Point pstart = this.GetAnchorLocation(sa, sc, this.Location);
			Point pend = this.GetAnchorLocation(ea, ec, this.Location);

			System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

			if (lclm == LinkControlLineMode.Line || (pstart.X==pend.X) ) 
			{
				path.AddLine(pstart.X, pstart.Y, pend.X, pend.Y);
			}
			else if (lclm == LinkControlLineMode.Bezier) 
			{		
				Point ctrl1 = new Point(pstart.X, pstart.Y + Height / 2);
				Point ctrl2 = new Point(pend.X, pend.Y-Height / 2);
				if (this.SideAnchor(this.StartAnchor)) 
				{
					if (pend.X<pstart.X) ctrl1 = new Point(pstart.X - Width / 2, pstart.Y);											
					else ctrl1 = new Point(pstart.X + Width / 2, pstart.Y);
				} 
				else 
				{
					if (pend.Y<pstart.Y) ctrl1 = new Point(pstart.X, pstart.Y - Height / 2);
				}
				if (this.SideAnchor(this.EndAnchor)) 
				{
					if (pend.X<pstart.X) ctrl2 = new Point(pend.X + Width / 2, pend.Y);					
					else ctrl2 = new Point(pend.X - Width / 2, pend.Y);
				} 
				else 
				{
					if (pend.Y<pstart.Y) ctrl2 = new Point(pend.X, pend.Y+Height / 2);
				}
				
				path.AddBezier(
					pstart.X, pstart.Y, ctrl1.X, ctrl1.Y,
					ctrl2.X, ctrl2.Y, pend.X, pend.Y);
			}
			else 
			{			
				if (this.SideAnchor(this.EndAnchor) && this.SideAnchor(this.StartAnchor)) 
				{
					path.AddLine(pstart.X, pstart.Y, Width/2, pstart.Y);
					path.AddLine(Width/2, pstart.Y, Width/2, pend.Y);
					path.AddLine(Width/2, pend.Y, pend.X, pend.Y);
				} 
				else 
				{
					path.AddLine(pstart.X, pstart.Y, pstart.X, Height/2);
					path.AddLine(pstart.X, Height/2, pend.X, Height/2);
					path.AddLine(pend.X, Height/2, pend.X, pend.Y);
				}
			}

			Pen pen = new Pen(this.ForeColor, lw);						
			
			PaintCap(g, pen, pstart, psa, true);
			PaintCap(g, pen, pend, pea, false);
			g.DrawPath(pen, path);
			
			if (Text!="")
			{
				SizeF sz = g.MeasureString(Text, Font);
				Rectangle trec = new Rectangle((int)((Width-sz.Width+4)/2)-4, (int)((Height-sz.Height+4)/2)-4, (int)sz.Width+5, (int)sz.Height+4);
				DrawNiceRoundRect(g, trec.X, trec.Y, trec.Width, trec.Height , (int)sz.Height/2);
				SolidBrush b = new SolidBrush(this.TextForeColor);
				g.DrawString(Text, Font, b, trec.Left+2, trec.Top+2);
				b.Dispose();
			}
						
			//Region = new Region(path);

			pen.Dispose();			
		}
		#endregion

		#region Anchor Controls
		protected void SetupAnchor(GraphPanelElement c, bool load)
		{
			if (c==null) return;
			if (load) 
			{
				c.Move += new EventHandler(c_Move);
				c.SizeChanged += new EventHandler(c_SizeChanged);
			} 
			else 
			{
				c.Move -= new EventHandler(c_Move);
				c.SizeChanged -= new EventHandler(c_SizeChanged);
			}
		}
		private void c_Move(object sender, EventArgs e)
		{
			AlignToControl();
			this.MoveControl();			
			this.CompleteRedraw();
		}
		#endregion

		private void c_SizeChanged(object sender, EventArgs e)
		{
			AlignToControl();
			this.MoveControl();
			this.CompleteRedraw();
		}	

		public override void Clear()
		{
			this.StartElement = null;
			this.EndElement = null;	
		}

	}
}
