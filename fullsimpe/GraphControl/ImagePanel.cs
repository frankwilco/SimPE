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
					this.Refresh();
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
				this.CompleteRedraw();
				Refresh();
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

		int tborder;
		#endregion

		#region Properties
			
		#endregion


		

		#region Event Override		
		
		
		#endregion

		#region Basic Draw Methods				

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

				
			Rectangle srect = new Rectangle(trec.Left-tborder, trec.Top-tborder, trec.Width+2*tborder, trec.Height+2*tborder);
			DrawNiceRoundRect(gr, srect.X, srect.Y, srect.Width, srect.Height, rad, this.ImagePanelColor);
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gr, new Pen(this.BorderColor), srect.X-2, srect.Y-2, srect.Width+3, srect.Height+3, rad);
				
			if (thumb!=null) gr.DrawImage(thumb, trec, new Rectangle(0, 0, thumb.Width, thumb.Height), GraphicsUnit.Pixel);
			

			
			DrawNiceRoundRect(gr, 0, Height-16, Width, 16, 8, this.PanelColor);	

			StringFormat sf = new StringFormat();
			sf.FormatFlags = StringFormatFlags.NoWrap;

			string tx = Text;
			SizeF sz = gr.MeasureString(tx, Font);
			if (sz.Width>Width-8 && Text.Length>4) 
			{
				int len = Text.Length-4;				
				while ((sz.Width>Width-8) && Text.Length>len) 
				{
					tx = Text.Substring(0, len)+"...";
					sz = gr.MeasureString(tx, Font);
					len--;
				}
			}
			int shift = (int)((16-sz.Height)/2);
			int lshift = (int)((Width-8-sz.Width)/2);
			gr.DrawString(
				tx, 
				Font, 
				new Pen(this.ForeColor).Brush, 
				new RectangleF(
					new PointF(4+lshift, Height-16+shift+1), 
					new SizeF(Math.Min(Width-8, Width-8-2*lshift), Math.Min(16, 16-2*shift))), 
				sf);	
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
