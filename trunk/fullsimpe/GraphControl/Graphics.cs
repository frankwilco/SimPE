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
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Collections;
using System.Runtime.InteropServices;

namespace Ambertation.Drawing
{
	/// <summary>
	/// Fills a bitmap using a non-recursive flood-fill.
	/// </summary>
	public class MapFill
	{
		public MapFill()
		{
		}

		static Stack stack=new Stack();

		/// <summary>
		/// Checks to make sure a pixel is in an image.
		/// </summary>
		/// <param name="pos">The position to check</param>
		/// <param name="bmd">The BitmapData from which the bounds are
		///determined</param>
		/// <returns>True if the point is in the image</returns>
		private static bool CheckPixel(Point pos, BitmapData bmd)
		{
			return (pos.X>-1) && (pos.Y>-1) && (pos.X<bmd.Width) &&
				(pos.Y<bmd.Height);
		}

		/// <summary>
		/// Returns the color at a specific pixel
		/// </summary>
		/// <param name="pos">The position of the pixel</param>
		/// <param name="bmd">The locked bitmap data</param>
		/// <returns>The color of the pixel under the nominated point</returns>
		private static Color GetPixel(Point pos, BitmapData bmd)
		{
			if (CheckPixel(pos, bmd))
			{
				//always assumes 32 bit per pixels
				int offset=pos.Y*bmd.Stride+(4*pos.X);
				return Color.FromArgb(
					Marshal.ReadByte(bmd.Scan0,offset+2),
					Marshal.ReadByte(bmd.Scan0,offset+1),
					Marshal.ReadByte(bmd.Scan0,offset));
			}
			else
				return Color.FromArgb(0,0,0,0);
		}

		/// <summary>
		/// Sets a pixel at a nominated point to a specified color
		/// </summary>
		/// <param name="pos">The coordinate of the pixel to set</param>
		/// <param name="bmd">The locked bitmap data</param>
		/// <param name="c">The color to set</param>
		private static void SetPixel(Point pos, BitmapData bmd, Color c)
		{
			if (CheckPixel(pos,bmd))
			{
				//always assumes 32 bit per pixels
				int offset=pos.Y*bmd.Stride+(4*pos.X);
				Marshal.WriteByte(bmd.Scan0,offset+2,c.R);
				Marshal.WriteByte(bmd.Scan0,offset+1,c.G);
				Marshal.WriteByte(bmd.Scan0,offset,c.B);
				Marshal.WriteByte(bmd.Scan0,offset+3,255);
			}
		}

		static bool Compare(Point pos, BitmapData bmd, Color c2, int toler)
		{						
			if (!CheckPixel(pos, bmd))  return false;
			Color c1 = GetPixel(pos, bmd);
			if (c1==c2) return true;
			if (Math.Abs(c1.R-c2.R)<toler && Math.Abs(c1.G-c2.G)<toler && Math.Abs(c1.R-c2.R)<toler) return true;
			return false;
		}

		/// <summary>
		/// Fills a pixel and its un-filled neigbors with a specified color
		/// </summary>
		/// <param name="pos">The position at which to begin</param>
		/// <param name="bmd">The locked bitmap data</param>
		/// <param name="c">The color with which to fill the area</param>
		/// <param name="org">The original colour of the point. Filling stops when
		///all connected pixels of this color are exhausted</param>
		private static void FillPixel(Point pos, BitmapData bmd, Color c, Color
			org)
		{			
			stack.Push(pos);
			Point currpos=new Point(0,0);
			stack.Push(pos);
			int toler = (int)Math.Floor(0xff*0.05f);
			ArrayList ran = new ArrayList();
			do
			{
				currpos=(Point)stack.Pop();
				if (ran.Contains(currpos)) 
					continue;
				ran.Add(currpos);
				SetPixel(currpos,bmd,c);
				if (Compare(new Point(currpos.X+1,currpos.Y), bmd, org, toler))
					stack.Push(new Point(currpos.X+1,currpos.Y));
				if (Compare(new Point(currpos.X,currpos.Y-1), bmd, org, toler))
					stack.Push(new Point(currpos.X,currpos.Y-1));
				if (Compare(new Point(currpos.X-1,currpos.Y), bmd, org, toler))
					stack.Push(new Point(currpos.X-1,currpos.Y));
				if (Compare(new Point(currpos.X,currpos.Y+1), bmd, org, toler))
					stack.Push(new Point(currpos.X,currpos.Y+1));
			} while (stack.Count>0);		
		}

		/// <summary>
		/// Fills a bitmap with color.
		/// </summary>
		/// <remarks>If a non 32-bit image is passed to this routine and only 32
		/// bit image will be created, the original image will be copied to the new
		/// image and filling will take place on the new image which will be handed back
		///when complete. </remarks>
		/// <param name="img">The image to fill</param>
		/// <param name="pos">The position to begin filling at</param>
		/// <param name="color">The color to fill</param>
		/// <returns>A Bitmap object with the filled area.</returns>
		public static Bitmap Fill(Image img, Point pos, Color color)
		{
			//Ensure the bitmap is in the right format
			Bitmap bm=(Bitmap)img;
			if (img.PixelFormat!=PixelFormat.Format32bppArgb)
			{
				//if it isn't, convert it.
				bm=new Bitmap(img.Width,img.Height,PixelFormat.Format32bppArgb);
				Graphics g=Graphics.FromImage(bm);
				g.InterpolationMode=InterpolationMode.NearestNeighbor;
				g.DrawImage(img,new
					Rectangle(0,0,bm.Width,bm.Height),0,0,img.Width,img.Height,GraphicsUnit.Pixel);
				g.Dispose();
			}

			//Lock the bitmap data
			BitmapData bmd=bm.LockBits(new
				Rectangle(0,0,bm.Width,bm.Height),ImageLockMode.ReadWrite,bm.PixelFormat);

			//get the color under the point. This is the original.
			Color org=GetPixel(pos,bmd);

			//Fill the first pixel and recursively fill all it's neighbors
			FillPixel(pos,bmd,color,org);

			//unlock the bitmap
			bm.UnlockBits(bmd);

			return bm;
		}
	}
	/// <summary>
	/// Thgis extends the basic Graohics class with usefull Methods
	/// </summary>
	public class GraphicRoutines
	{
		#region RoundRect Routines
		public static void DrawRoundRect(Graphics g,Pen p, Rectangle rect, int radius)
		{
			DrawRoundRect(g, p, rect.X, rect.Y, rect.Width, rect.Height, radius);
		}

		public static void FillRoundRect(Graphics g, Brush b, Rectangle rect, int radius)
		{
			FillRoundRect(g, b, rect.X, rect.Y, rect.Width, rect.Height, radius);
		}

		public static void DrawRoundRect(Graphics g, Pen p, int x, int y, int width, int height, int radius)
		{			
			g.DrawPath(p, RoundRectPath(x, y, width, height, radius));
		}

		public static void FillRoundRect(Graphics g, Brush b, int x, int y, int width, int height, int radius)
		{			
			g.FillPath(b, RoundRectPath(x, y, width, height, radius));
		}

		public static GraphicsPath GethRoundRectPath(Rectangle rect, int radius)
		{
			return RoundRectPath(rect.X, rect.Y, rect.Width, rect.Height, radius);
		}

		public static GraphicsPath GethRoundRectPath(int x, int y, int width, int height, int radius)
		{
			return RoundRectPath(x, y, width, height, radius);
		}
		static GraphicsPath RoundRectPath(int x, int y, int width, int height, int radius)
		{
			GraphicsPath gp = new GraphicsPath();
			if (radius>1) 
			{
				gp.AddLine(x + radius, y, x + width - radius, y);
				gp.AddArc(x + width - radius, y, radius, radius, 270, 90);
				gp.AddLine(x + width, y + radius, x + width, y + height - radius);
				gp.AddArc(x + width - radius, y + height - radius, radius, radius, 0, 90);
				gp.AddLine(x + width - radius, y + height, x + radius, y + height);
				gp.AddArc(x, y + height - radius, radius, radius, 90, 90);
				gp.AddLine(x, y + height - radius, x, y + radius);
				gp.AddArc(x, y, radius, radius, 180, 90);
				gp.CloseFigure();
			} 
			else 
			{
				gp.AddRectangle(new Rectangle(x, y, width, height));
			}

			return gp;
		}
		#endregion

		public static ColorMap[] CloseColors(Color cl, float tolerance, Color target)
		{
			int sub = (int)Math.Floor(0xff*tolerance);
			int minr = Math.Max(0, Math.Min(0xff, cl.R - sub));
			int maxr = Math.Max(0, Math.Min(0xff, cl.R + sub));

			int ming = Math.Max(0, Math.Min(0xff, cl.G - sub));
			int maxg = Math.Max(0, Math.Min(0xff, cl.G + sub));

			int minb = Math.Max(0, Math.Min(0xff, cl.B - sub));
			int maxb = Math.Max(0, Math.Min(0xff, cl.B + sub));

			ArrayList cmap = new ArrayList();

			for (int r=minr; r<maxr; r++)
				for (int g=ming; g<maxg; g++)
					for (int b=minb; b<maxb; b++) 
					{
						ColorMap c = new ColorMap();
						c.NewColor = target;
						c.OldColor = Color.FromArgb(r, g, b);
						cmap.Add(c);
					}
			

			ColorMap[] res = new ColorMap[cmap.Count];
			cmap.CopyTo(res);

			return res;
		}

		public static ArrayList CloseColors(Color cl, float tolerance)
		{
			int sub = (int)Math.Floor(0xff*tolerance);
			int minr = Math.Max(0, Math.Min(0xff, cl.R - sub));
			int maxr = Math.Max(0, Math.Min(0xff, cl.R + sub));

			int ming = Math.Max(0, Math.Min(0xff, cl.G - sub));
			int maxg = Math.Max(0, Math.Min(0xff, cl.G + sub));

			int minb = Math.Max(0, Math.Min(0xff, cl.B - sub));
			int maxb = Math.Max(0, Math.Min(0xff, cl.B + sub));

			ArrayList cmap = new ArrayList();

			for (int r=minr; r<maxr; r++)
				for (int g=ming; g<maxg; g++)
					for (int b=minb; b<maxb; b++) 
					{
						cmap.Add(Color.FromArgb(r, g, b));
					}
			

			return cmap;
		}


		public static Image MakeTransparent(Image img, Color cl, bool quality)
		{
			return MakeTransparent(img, cl, 0.05f, quality);
		}

		public static Image MakeTransparent(Image img, Color cl, float tolerance, bool quality)
		{
			Bitmap bm = new Bitmap(img.Width, img.Height);
			
			// Set the image attribute's color mappings
			ColorMap[] colorMap = CloseColors(cl, tolerance, Color.Transparent);

			ImageAttributes attr = new ImageAttributes();
			attr.SetRemapTable(colorMap);	 
 
			Graphics g = Graphics.FromImage(bm);
			Ambertation.Windows.Forms.Graph.GraphPanelElement.SetGraphicsMode(g, !quality);
			Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
			g.DrawImage(img, rect, rect.Left, rect.Top, rect.Width, rect.Height, GraphicsUnit.Pixel, attr);
			g.Dispose();

			return bm;
		}

#if MAC

#else
		[DllImport("gdi32")] 
		public static extern int ExtFloodFill(IntPtr hDC, int x, int y, int crColor, int wFillType);
		
		[DllImport("gdi32")]
		static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

		[DllImport("gdi32")] 
		static extern int DeleteObject(IntPtr hObject);

		[DllImport("gdi32")]
		static extern IntPtr CreateSolidBrush(int crColor);

		public static void FloodFill(Image img, Point pos, Color backColor, Color limitColor)
		{
			Graphics g = Graphics.FromImage(img);
			FloodFill(g, pos, backColor, limitColor);
			g.Dispose();
		}
		public static void FloodFill(Graphics g, Point pos, Color backColor, Color limitColor)
		{
			// g.DrawRectangle(pens.Black,20,20,50,50);
			IntPtr p = g.GetHdc();
			IntPtr hb = CreateSolidBrush(ColorTranslator.ToWin32(backColor));
			SelectObject(p, hb);
			ExtFloodFill(p, pos.X, pos.Y, ColorTranslator.ToWin32(limitColor), 1);
			DeleteObject(hb);
			g.ReleaseHdc(p);
		}
#endif	

		public static Image KnockoutImage(Image img, Point pos, Color fillcl)
		{
			

			Bitmap bm = new Bitmap(img.Width, img.Height);
			Graphics g = Graphics.FromImage(bm);						
			//Ambertation.Windows.Forms.Graph.GraphPanelElement.SetGraphicsMode(g, !quality);
			g.DrawImageUnscaled(img, 0, 0);
			g.Dispose();

			FloodFiller ff = new FloodFiller();
			ff.FillColor = fillcl;			
			ff.FloodFill(bm, pos);
			((Bitmap)img).MakeTransparent(fillcl);

			return bm;
		}

		public static Image ScaleImage(Image img, int width, int height, bool quality)
		{
			Bitmap bm = new Bitmap(width, height);
			
			Graphics g = Graphics.FromImage(bm);						
			Ambertation.Windows.Forms.Graph.GraphPanelElement.SetGraphicsMode(g, !quality);
			g.DrawImage(img, new Rectangle(0, 0, width, height), new Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel);
			g.Dispose();

			
			return bm;
		}		
	}
}
