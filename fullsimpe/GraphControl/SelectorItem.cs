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
	/// Zusammenfassung für SelectorItem.
	/// </summary>
	public class SelectorItem
	{
		XPTaskBoxSelector parent;
		Panel pn;
		Rectangle lastrect;

		internal SelectorItem(XPTaskBoxSelector parent, string txt)
		{
			this.parent = parent;

			pn = new Panel();
			pn.Parent = parent;
			pn.Visible = false;
			pn.Dock = DockStyle.Fill;
			pn.BackColor = parent.BodyColor;
			pn.CausesValidation = false;

			wd = 0;
			lastrect = new Rectangle(0, 0, 0, 0);
			Text = txt;			
		}

		string txt;
		int wd;
		public string Text
		{
			get {return txt;}
			set 
			{
				if (txt!=value) 
				{
					txt = value;
					parent.UpdateSelection(this);

					Graphics g = Graphics.FromImage(new Bitmap(1, 1));
					SizeF sz = g.MeasureString(Text, parent.HeaderFont);
					g.Dispose();
					wd = (int)Math.Ceiling(sz.Width);
				}
			}
		}

		public int MinWidth 
		{
			get { return wd;}
		}

		public Rectangle BoundingRectangle
		{
			get { return lastrect; }
		}

		void AddBezier(GraphicsPath path, int left, int top, int height)
		{
			path.AddBezier(
				left, top, 
				left - Math.Abs(height/3), top + height/2,
				left -  Math.Abs(height/3), top + height/2,
				left, top+height
				);
		}

		internal virtual Rectangle DrawButton(Graphics g, Rectangle rect, bool last, bool hover, bool selected)
		{
			pn.Visible = selected;
			lastrect = rect;
			SizeF sz = g.MeasureString(Text, parent.HeaderFont);
			GraphicsPath path = new GraphicsPath();
			AddBezier(path, rect.Left, rect.Top, rect.Height);
			path.AddLine(rect.Left, rect.Bottom, rect.Right, rect.Bottom);
			if (last) path.AddLine(rect.Right, rect.Bottom, rect.Right, rect.Top);			
			else AddBezier(path, rect.Right, rect.Bottom, -rect.Height);
			path.CloseFigure();

			if (selected) g.FillPath(new SolidBrush(Color.Black), path);	
			if (hover) g.FillPath(new SolidBrush(Color.FromArgb(100, Color.YellowGreen)), path);	
			Rectangle grec = new Rectangle(rect.Left-rect.Height/3, rect.Top, rect.Width+rect.Height/3+2, rect.Height);
			LinearGradientBrush lgb = new LinearGradientBrush(
				grec,
				Color.FromArgb(70, Color.White),
				Color.Transparent,
				LinearGradientMode.ForwardDiagonal
				);
			g.FillPath(lgb, path);		

			/*path = new GraphicsPath();
			AddBezier(path, rect.Left, rect.Top, rect.Height);
			AddBezier(path, rect.Left, rect.Bottom, -rect.Height);
			g.DrawPath(new Pen(Color.FromArgb(100,Color.White)), path);*/

			path = new GraphicsPath();
			AddBezier(path, rect.Left+2, rect.Top, rect.Height);
			AddBezier(path, rect.Left+2, rect.Bottom, -rect.Height);
			g.DrawPath(new Pen(Color.FromArgb(20, Color.White)), path);

			path = new GraphicsPath();
			AddBezier(path, rect.Left+1, rect.Top, rect.Height);
			AddBezier(path, rect.Left+1, rect.Bottom, -rect.Height);
			g.DrawPath(new Pen(Color.FromArgb(40, Color.White)), path);
			

			path = new GraphicsPath();
			AddBezier(path, rect.Left, rect.Top, rect.Height);
			AddBezier(path, rect.Left, rect.Bottom, -rect.Height);
			g.DrawPath(new Pen(Color.FromArgb(150,Color.Black), 1), path);

			path = new GraphicsPath();
			AddBezier(path, rect.Left-1, rect.Top, rect.Height);
			AddBezier(path, rect.Left-1, rect.Bottom, -rect.Height);
			g.DrawPath(new Pen(Color.FromArgb(40,Color.Black), 1), path);
			

			g.DrawString(
				Text, 
				parent.HeaderFont, 
				new SolidBrush(parent.HeaderTextColor),
				rect.Left+4,
				(rect.Height - sz.Height)/2+rect.Top);

			return rect;
		}
	}
}
