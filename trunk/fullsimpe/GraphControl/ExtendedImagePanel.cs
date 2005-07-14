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
	/// This is a Image Panel
	/// </summary>
	public class ExtendedImagePanel : ImagePanel
	{
		
		public ExtendedImagePanel() :this (new PropertyItems())
		{									
		}		

		public ExtendedImagePanel(PropertyItems properties) :base ()
		{
			this.properties = properties;	
		}

		#region public Properties		
		PropertyItems properties;		
		public PropertyItems Properties 
		{
			get { return properties;}
			set 
			{
				if (value != properties)
				{
					properties = value;
					Invalidate();
				}
			}
		}
		#endregion

		#region Properties
			
		#endregion


		

		#region Event Override		
		
		
		#endregion

		#region Basic Draw Methods				

		protected override void UserDraw(Graphics gr)
		{
			Rectangle prec = new Rectangle(10+ImageBorderWidth, 10+ImageBorderWidth, Width -10-ImageBorderWidth, Height-10-ImageBorderWidth);
			int rad = Math.Min(Math.Min(8, prec.Height/2), prec.Width/2);
			DrawNiceRoundRect(gr, prec.Left, prec.Top, prec.Width, prec.Height, rad, this.PanelColor);	
			int tw = 48;
			int th = 48;
			if (this.Image!=null) 
			{
				tw = this.Image.Width;
				th = this.Image.Height;
			}
			rad = Math.Min(Math.Min(8, th/2), tw/2);
			Rectangle trec = new Rectangle(
				2+ImageBorderWidth,
				2+ImageBorderWidth,
				tw,
				th);

			DrawText(gr, prec, trec);
			DrawThumbnail(gr, trec, rad);	
		}

		protected void DrawText(Graphics gr, Rectangle prec, Rectangle trec)
		{
			if (this.properties==null) return;
			LinkGraphic.SetGraphicsMode(gr, !Quality);

			Font ftb = new Font(Font.FontFamily, Font.Size, FontStyle.Bold, Font.Unit);
			this.DrawCaption(gr, new Rectangle(trec.Right+2, prec.Top, prec.Width - (trec.Right-prec.Left) - 4-this.ImageBorderWidth, 16), ftb, false);
			Pen linepen = new Pen(Color.FromArgb(90, Color.Black));
			gr.DrawLine(linepen, new Point(prec.Left, prec.Top+16), new Point(prec.Right, prec.Top+16));
			linepen.Dispose();

	
			StringFormat sf = new StringFormat();
			sf.FormatFlags = StringFormatFlags.NoWrap;			
			int top = prec.Top+24;
			Size indent = new Size(trec.Right+6, trec.Bottom - prec.Top + 7 + 2*this.ImageBorderWidth);			
				
			//Hashtable ht = new Hashtable();
			foreach (string k in properties.Keys) 
			{
				PropertyItem o = properties[k];
				if (o==null) continue;				
				string val = "";				
				val = (string)o.Value;				
					
				if (val!=null) 
				{
					int indentx = prec.Left+6;
					if (top<indent.Height) indentx = indent.Width;
					Font ft = new Font(Font.FontFamily, Font.Size, FontStyle.Italic, Font.Unit);
					

					gr.DrawString(
						k+":", 
						ft, 
						new Pen(Color.FromArgb(160, this.ForeColor)).Brush, 
						new RectangleF(new PointF(indentx, top), new SizeF(prec.Width-indentx, top+16)), 
						sf);
					SizeF sz = gr.MeasureString(
						k+":", 
						ft);

					gr.DrawString(
						val, 
						Font, 
						new Pen(Color.FromArgb(140, this.ForeColor)).Brush, 
						new RectangleF(new PointF(indentx+sz.Width, top), new SizeF(prec.Width-indentx-sz.Width, top+16)), 
						sf);
					SizeF sz2 = gr.MeasureString(
						val, 
						Font);
						
					Rectangle rect = new Rectangle(new Point((int)(indentx+sz.Width), top), new Size((int)(prec.Width-indentx-sz.Width), top+16));					

					top += (int)Math.Max(sz.Height, sz2.Height);
					ft.Dispose();
					
				}
			}

			//LinkGraphic.SetGraphicsMode(gr, true);
			//properties = ht;
		}
		
		#endregion		
	}
}
