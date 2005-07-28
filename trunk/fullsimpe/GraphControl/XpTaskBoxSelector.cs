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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Ambertation.Windows.Forms
{
	

	/// <summary>
	/// This is an c#-Version of a Control created by www.steepvalley.net. 
	/// I translated it to remove the Expand/Collapse feature
	/// </summary>
	[DesignTimeVisible(true), ToolboxBitmapAttribute(typeof(TabControl))]
	public class XPTaskBoxSelector : Panel
	{		

		// Methods
		public XPTaskBoxSelector()
		{
			this.InitializeComponent();
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
			this.SetStyle(ControlStyles.ContainerControl, true);
			base.BackColor = Color.Transparent;

			this.bc = SystemColors.Window;
			this.lhc = SystemColors.InactiveCaption;
			this.rhc = SystemColors.Highlight;
			this.bodc = SystemColors.InactiveCaptionText;
			this.htc = SystemColors.ActiveCaptionText;

			this.font = new Font(base.Font.Name, base.Font.Size+2, FontStyle.Bold, base.Font.Unit);			
			pages = new ArrayList();

			pages.Add(new SelectorItem(this, "Hello"));
			pages.Add(new SelectorItem(this, "Test"));
			pages.Add(new SelectorItem(this, "Frank"));
			pages.Add(new SelectorItem(this, "Bauer"));	
		
			DrawComplete();
		}

		ArrayList pages ;
		
		#region Public Properties
		int selid;
		public int SelectedIndex
		{
			get {return selid;}
			set 
			{
				if (value!=selid)
				{					
					if (value>=0 && value<pages.Count) 
					{
						this.mousesel = ((SelectorItem)pages[value]).BoundingRectangle.Location;
						DrawComplete();
						Invalidate(SelectionRect, false);
					}
				}
			}
		}
		Color lhc, rhc, bc, bodc, htc;
		public Color LeftHeaderColor 
		{
			get {return lhc; }
			set 
			{
				if (lhc != value) 
				{
					lhc=value;
					DrawComplete();
					this.Invalidate();
				}
			}
		}

		public Color RightHeaderColor 
		{
			get {return rhc; }
			set 
			{
				if (rhc != value) 
				{
					rhc=value;
					DrawComplete();
					this.Invalidate();
				}
			}
		}

		public Color BorderColor 
		{
			get {return bc; }
			set 
			{
				if (bc != value) 
				{
					bc=value;
					DrawComplete();
					this.Invalidate();
				}
			}
		}

		public Color HeaderTextColor 
		{
			get {return htc; }
			set 
			{
				if (htc != value) 
				{
					htc=value;
					DrawComplete();
					Invalidate(SelectionRect, false);
				}
			}
		}

		public Color BodyColor 
		{
			get {return bodc; }
			set 
			{
				if (bodc != value) 
				{
					bodc=value;
					DrawComplete();
					this.Invalidate();
				}
			}
		}

		Font font;
		public Font HeaderFont
		{
			get {return font; }
			set 
			{
				if (font != value) 
				{
					font=value;
					DrawComplete();
					Invalidate(SelectionRect, false);
				}
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && (this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}
		#endregion

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new Container();
			
			Size size1 = new Size(0x10, 0x10);
			
			this.DockPadding.Bottom = 4;
			this.DockPadding.Left = 4;
			this.DockPadding.Right = 4;
			this.DockPadding.Top = 0x2c;
			this.Name = "XPTaskBoxSimple";
		}

		private void mThemeFormat_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			this.Invalidate();
		}

		protected Rectangle SelectionRect
		{
			get 
			{ 
				return new Rectangle(0, (this.Height - 25), this.Width-1, 22);
			}
		}

		protected void DrawSelection(Graphics g, Rectangle ef3)
		{
			int minleft = ef3.Right;
			for (int i=0; i<pages.Count; i++)
			{
				minleft -= ((SelectorItem)pages[i]).MinWidth;
				minleft -= ef3.Height;
			}

			selid = -1;
			for (int i=0; i<pages.Count; i++)
			{
				SelectorItem item = ((SelectorItem)pages[i]);				
				Rectangle rec = new Rectangle(minleft, ef3.Top, item.MinWidth+ef3.Height, ef3.Height);
				item.DrawButton(g, rec, i==pages.Count-1, rec.Contains(mouseloc), rec.Contains(mousesel));
				if (rec.Contains(mousesel)) selid = i;
				minleft += rec.Width;
			}
		}

		internal void UpdateSelection(SelectorItem sender)
		{
			DrawComplete();
			Invalidate(SelectionRect, false);
		}

		Bitmap cachedimg;
		protected override void OnPaint(PaintEventArgs e) 
		{
			//base.OnPaint(e);
			
			e.Graphics.DrawImage(cachedimg, e.ClipRectangle, e.ClipRectangle, GraphicsUnit.Pixel);			
		}

		protected virtual void DrawComplete()
		{		
			if (cachedimg!=null) cachedimg.Dispose();

			cachedimg = new Bitmap(Width, Height);
			Graphics g = Graphics.FromImage(cachedimg);
			Ambertation.Windows.Forms.Graph.GraphPanelElement.SetGraphicsMode(g, false);
			
			Rectangle ef3 = this.SelectionRect;
			Rectangle ef3b = new Rectangle(3, 3, this.Width-7, this.Height-ef3.Height-6);
			Rectangle ef2 = new Rectangle(0, 24, this.Width-1, (this.Height - 25));
			Rectangle ef1 = new Rectangle(0, 0, this.Width-1,(this.Height - 1));
			GraphicsPath path = new GraphicsPath();
			LinearGradientBrush brush1 = new LinearGradientBrush(ef3, LeftHeaderColor, RightHeaderColor, LinearGradientMode.Horizontal);
			Pen borderpen = new Pen(BorderColor, 1f);
			StringFormat format1 = new StringFormat();
			format1.Alignment = StringAlignment.Near;
			format1.LineAlignment = StringAlignment.Center;
			format1.Trimming = StringTrimming.EllipsisCharacter;
			format1.FormatFlags = StringFormatFlags.NoWrap;
			borderpen.Alignment = PenAlignment.Inset;
			
			
			path = Ambertation.Drawing.GraphicRoutines.GethRoundRectPath(ef1, 7);
			g.FillPath(brush1, path);
			
			DrawSelection(g, ef3);

			path = Ambertation.Drawing.GraphicRoutines.GethRoundRectPath(ef3b, 7);			
			g.FillPath(new SolidBrush(BodyColor), path);

			

			path = Ambertation.Drawing.GraphicRoutines.GethRoundRectPath(ef1, 7);			
			g.DrawPath(borderpen, path);
			
			path.Dispose();
			brush1.Dispose();
			borderpen.Dispose();
			format1.Dispose();

			Ambertation.Windows.Forms.Graph.GraphPanelElement.SetGraphicsMode(g, true);
			
			g.Dispose();
		}		

		

				

		

		[Browsable(false), Description("returns the usable region as Rectangle")]
		internal Rectangle WorkspaceRect
		{
			get
			{
				return new Rectangle(3, 3, this.Width - 7, (this.Height - 22) - 4);
			}
		}


		// Fields
		private IContainer components;

		Point mouseloc;
		Point mousesel;
		bool hadhover;
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove (e);
			Point pt = new Point(e.X, e.Y);
			for (int i=0; i<pages.Count; i++)
			{
				SelectorItem item = ((SelectorItem)pages[i]);				
				if (item.BoundingRectangle.Contains(pt)) 
				{
					hadhover = true;
					mouseloc = pt;
					DrawComplete();
					Invalidate(SelectionRect, false);
					return;
				}
			}	
			mouseloc = pt;
			if (hadhover) 
			{
				DrawComplete();
				Invalidate(SelectionRect, false);
			}
			hadhover = false;
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown (e);
			if (e.Button==MouseButtons.Left) 
			{
				Point pt = new Point(e.X, e.Y);
				for (int i=0; i<pages.Count; i++)
				{
					SelectorItem item = ((SelectorItem)pages[i]);				
					if (item.BoundingRectangle.Contains(pt)) 
					{
						mousesel = pt;
						DrawComplete();
						Invalidate(SelectionRect, false);
						return;
					}
				}
			}
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave (e);
			mouseloc = new Point(0,0);
			DrawComplete();
			Invalidate(SelectionRect, false);
		}

		protected override void OnResize(EventArgs e)
		{
			DrawComplete();
			base.OnResize (e);
		}


	}
}
