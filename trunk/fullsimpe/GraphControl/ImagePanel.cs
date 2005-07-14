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

namespace Ambertation.Windows.Forms.Graph
{
	/// <summary>
	/// This is a Image Panel
	/// </summary>
	public class ImagePanel : RoundedPanel
	{
		
		public ImagePanel() :base ()
		{						
			tborder = 2;
			txt = "";

			bg = Color.Gray;
		}		

		#region public Properties		
		Color bg;
		public Color ImagePanelColor
		{
			get
			{
				return bg;
			}
			set
			{
				if (bg != value) 
				{
					bg = value;
					this.Invalidate();
				}
			}
		}
		Image thumb;
		public Image Image
		{
			get { return thumb; }
			set 
			{
				thumb = value;
				this.Invalidate();
			}
		}

		string txt;
		public string Text
		{
			get { return txt; }
			set 
			{
				txt = value;
				this.Invalidate();
			}
		}

		int tborder;
		public int ImageBorderWidth
		{
			get { return tborder; }
			set 
			{
				tborder = value;
				this.Invalidate();
			}
		}
		#endregion

		#region Properties
			
		#endregion


		

		#region Event Override		
		
		
		#endregion

		#region Basic Draw Methods				

		protected void DrawThumbnail(Graphics gr, Rectangle trec, int rad)
		{
			Rectangle srect = new Rectangle(trec.Left-tborder, trec.Top-tborder, trec.Width+2*tborder, trec.Height+2*tborder);
			DrawNiceRoundRect(gr, srect.X, srect.Y, srect.Width, srect.Height, rad, this.ImagePanelColor);
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gr, new Pen(this.BorderColor), srect.X-2, srect.Y-2, srect.Width+3, srect.Height+3, rad);
				
			if (thumb!=null) gr.DrawImage(thumb, trec, new Rectangle(0, 0, thumb.Width, thumb.Height), GraphicsUnit.Pixel);
			
		}

		protected void DrawCaption(Graphics gr, Rectangle r, Font f, bool center)
		{
			StringFormat sf = new StringFormat();
			sf.FormatFlags = StringFormatFlags.NoWrap;

			string tx = Text;
			SizeF sz = gr.MeasureString(tx, Font);
			if (sz.Width>Width-8 && Text.Length>4) 
			{
				int len = Text.Length-4;				
				while ((sz.Width>r.Width-8) && Text.Length>len && len>0) 
				{
					tx = Text.Substring(0, len)+"...";
					sz = gr.MeasureString(tx, Font);
					len--;
				}
			}
			int shift = (int)((r.Height-sz.Height)/2);
			int lshift = (int)((r.Width-8-sz.Width)/2);
			if (!center) lshift=0;
			gr.DrawString(
				tx, 
				f, 
				new Pen(this.ForeColor).Brush, 
				new RectangleF(
				new PointF(r.Left+4+lshift, r.Top+shift+1), 
				new SizeF(Math.Min(r.Width-8, r.Width-8-2*lshift), Math.Min(r.Height, r.Height-2*shift))), 
				sf);	
		}

		protected override void UserDraw(Graphics gr)
		{
			int tw = Width-4-2*tborder;
			int th = Height-24-2*tborder;
			if (thumb!=null) 
			{
				tw = thumb.Width;
				th = thumb.Height;
			}
			int rad = Math.Min(Math.Min(8, th/2), tw/2);
			Rectangle trec = new Rectangle(
				(Width - tw)/2,
				(Height- 16 - th) / 2,
				tw,
				th);

			DrawThumbnail(gr, trec, rad);	
			

			
			DrawNiceRoundRect(gr, 0, Height-16, Width, 16, 8, this.PanelColor);	
			DrawCaption(gr, new Rectangle(0, Height-16, Width, 16), Font, true);
			
		}
		
		#endregion

		public Size BestSize(Size imgsize)
		{
			return BestSize(imgsize.Width, imgsize.Height);
		}

		public Size BestSize(int imgwidth, int imgheight)
		{
			return new Size(
				imgwidth + 2*this.tborder + 5, 
				imgheight + 2*this.tborder + 5 + 19
				);
		}
	}
}
