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

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This calss describes one possible Dock Point for a Controls
	/// </summary>
	public class DockPoint 
	{
		public DockPoint(int x, int y, LinkControlType type)
		{
			this.x = x;
			this.y = y;
			this.lct = type;
		}

		int x;
		int y;
		public int X 
		{
			get {return x;}
			set {x = value;}
		}
		public int Y 
		{
			get {return y;}
			set {y = value;}
		}

		LinkControlType lct;
		public LinkControlType Type
		{
			get {return lct;}
		}

		public double Distance(DockPoint d)
		{
			return Math.Sqrt(Math.Pow(X-d.X, 2) + Math.Pow(Y-d.Y, 2));
		}

		public bool IsSideDock
		{
			get 
			{
				int yl = ((byte)lct >> 2) & (byte)0x3;
				return (yl==0x2);
			}
		}

		public bool IsCenterDock
		{
			get 
			{
				int xl = (byte)lct & (byte)0x3;
				int yl = ((byte)lct >> 2) & (byte)0x3;
				return (yl==0x2 || xl==0x2);
			}
		}
	}
	public enum LinkControlType:byte
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
		Normal = 0x0,
		OnlyCenter = 0x1
	}

	/// <summary>
	/// This Control draws a LinkLine between two Controls
	/// </summary>
	public class LinkGraphic : GraphPanelElement
	{
		
		
		public LinkGraphic()
		{
			this.sa = 0;
			this.ea = 0;
			this.lclm = LinkControlLineMode.Bezier;
			this.psa = LinkControlCapType.Disk;
			this.pea = LinkControlCapType.Arrow;
			ssa = LinkControlSnapAnchor.OnlyCenter;
			esa = LinkControlSnapAnchor.Normal;
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
	
		GraphItemBase sc, ec;
		/// <summary>
		/// Returns /Sets the Start Control
		/// </summary>
		public GraphItemBase StartElement
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
		public GraphItemBase EndElement
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

		byte sa, ea;
		/// <summary>
		/// Returns / Sets the start Anchor
		/// </summary>
		public byte StartAnchor 
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
		public byte EndAnchor 
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
				this.SetBounds(Left, Top, Width, Height);
				this.Invalidate();
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

		protected Point GetAnchorLocation(byte lca, GraphItemBase c)
		{
			return GetAnchorLocation(lca, c, new Point(0,0));
		}		

		protected Point GetAnchorLocation(byte lca, GraphItemBase c, Point offset)
		{						
			return new Point(c.Docks[lca].X-offset.X, c.Docks[lca].Y-offset.Y);			
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

		protected void AlignToControl()
		{
			if (sc==null||ec==null || (ssa== LinkControlSnapAnchor.None && this.esa==LinkControlSnapAnchor.None)) return;
			Point b = GraphItemBase.FindBestDocks(sc.Docks, ssa, sa, ec.Docks, esa, ea);
			this.sa = (byte)b.X;
			ea = (byte)b.Y;
		}
		#endregion

		#region Basic Draw Methods
		protected void AddBezierPath(System.Drawing.Drawing2D.GraphicsPath path, Point pstart, Point pend, bool sside, bool eside)
		{
			Point ctrl1 = new Point(pstart.X, pstart.Y + Height / 2);
			Point ctrl2 = new Point(pend.X, pend.Y-Height / 2);
			if (sside) 
			{
				if (pend.X<pstart.X) ctrl1 = new Point(pstart.X - Width / 2, pstart.Y);											
				else ctrl1 = new Point(pstart.X + Width / 2, pstart.Y);
			} 
			else 
			{
				if (pend.Y<pstart.Y) ctrl1 = new Point(pstart.X, pstart.Y - Height / 2);
			}
			if (this.EndElement.Docks[this.EndAnchor].IsSideDock) 
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
				if (Text!="" && this.EndElement.Docks[this.EndAnchor].IsSideDock != this.StartElement.Docks[this.StartAnchor].IsSideDock) 
				{
					Point pmid = new Point((pstart.X+pend.X)/2, (pstart.Y+pend.Y)/2);
					this.AddBezierPath(path, pstart, pmid, this.StartElement.Docks[this.StartAnchor].IsSideDock, this.StartElement.Docks[this.StartAnchor].IsSideDock);
					this.AddBezierPath(path, pmid, pend, this.EndElement.Docks[this.EndAnchor].IsSideDock, this.EndElement.Docks[this.EndAnchor].IsSideDock);				
				}
				else 
				{
					this.AddBezierPath(path, pstart, pend, this.StartElement.Docks[this.StartAnchor].IsSideDock, this.EndElement.Docks[this.EndAnchor].IsSideDock);									
				}
			}
			else 
			{			
				if (this.EndElement.Docks[this.EndAnchor].IsSideDock && this.StartElement.Docks[this.StartAnchor].IsSideDock) 
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
			this.SetBounds(0, 0, 1, 1);
		}

	}
}
