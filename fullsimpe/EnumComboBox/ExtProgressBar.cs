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

namespace Ambertation.Windows.Forms
{
	public enum ProgresBarStyle
	{
		Simple = 0x10,
		Flat = 0x20,
		Increase = 0x30,
		Decrease = 0x40,
		Balance = 0x50
	}
	
	/// <summary>
	/// Zusammenfassung für LabledProgressBar.
	/// </summary>
	[ToolboxBitmapAttribute(typeof(ProgressBar))]
	public class ExtProgressBar : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExtProgressBar()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);			

			BackColor = Color.Transparent;

			min = 0;
			max = 100;
			val = 0;
			tw = 6;			
			quality=true;

			style = ProgresBarStyle.Flat;
			startgradcol = Color.White;
			endgradcol = Color.Black;
			bgcol = SystemColors.Window;
			bcol = Color.FromArgb(100, Color.Black);
			col = Color.Black;
			selcol = Color.YellowGreen;
			this.mGradient = LinearGradientMode.ForwardDiagonal;


			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			this.OnResize(null);
			CompleteRedraw();			
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
			}
			base.Dispose( disposing );
		}

		#region public Properties
		ProgresBarStyle style;
		//[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public ProgresBarStyle Style
		{
			get {return style; }
			set
			{
				if (value!=style) 
				{
					style = value;

					if (style==ProgresBarStyle.Simple) 
					{
						this.mGradient = LinearGradientMode.Vertical;
					} 
					else 
					{
						this.mGradient = LinearGradientMode.ForwardDiagonal;
					}
					CompleteRedraw();
					Invalidate();					
				}
			}
		}
		int min, max, val;
		public int Minimum 
		{
			get { return min; }
			set
			{
				if (value!=min) 
				{
					min = Math.Min(value, Maximum);
					Refresh();
					if (Changed!=null) Changed(this, new EventArgs());
				}
			}
		}
		public int Maximum 
		{
			get { return max; }
			set
			{
				if (value!=max) 
				{
					max = Math.Max(Minimum, Math.Max(1, value));
					Refresh();
					if (Changed!=null) Changed(this, new EventArgs());
				}
			}
		}

		public int Value 
		{
			get { return val; }
			set
			{
				if (value!=val) 
				{
					val = Math.Max(Minimum, Math.Min(Maximum, value));
					Refresh();
					if (Changed!=null) Changed(this, new EventArgs());
				}
			}
		}

		bool quality;
		public bool Quality 
		{
			get { return quality; }
			set
			{
				if (value!=quality) 
				{
					quality = value;
					Invalidate();					
				}
			}
		}

		

		Color col, selcol, bcol;
		public Color UnselectedColor
		{
			get { return col; }
			set 
			{
				if (value!=col)
				{
					col = value;
					this.Invalidate();
				}
			}
		}
		public Color SelectedColor
		{
			get { return selcol; }
			set 
			{
				if (value!=selcol)
				{
					selcol = value;
					this.Invalidate();
				}
			}
		}

		public Color BorderColor
		{
			get { return bcol; }
			set 
			{
				if (value!=bcol)
				{
					bcol = value;
					this.Invalidate();
				}
			}
		}

		Color startgradcol, endgradcol;		
		Color bgcol;
	
		public Color ProgressBackColor
		{
			get { return bgcol; }
			set 
			{
				if (value!=bgcol)
				{
					bgcol = value;
					this.Invalidate();
				}
			}
		}

		LinearGradientMode mGradient;	
	
		public Color GradientStartColor
		{
			get { return startgradcol; }
			set 
			{
				if (value!=startgradcol)
				{
					startgradcol = value;
					this.Invalidate();
				}
			}
		}

		public Color GradientEndColor
		{
			get { return endgradcol; }
			set 
			{
				if (value!=endgradcol)
				{
					endgradcol = value;
					this.Invalidate();
				}
			}
		}

		public LinearGradientMode Gradient
		{
			get
			{
				return this.mGradient;
			}
			set
			{
				this.mGradient = value;
			}
		}
		#endregion

		#region Events
		public event EventHandler Changed;

		#endregion

		#region Overrides
		

		public new void Invalidate()
		{
			if (this.DesignMode) CompleteRedraw();
			base.Invalidate();
		}

		protected override void OnResize(EventArgs e)
		{			
			SetTokenCount(this.TokenCount);
			CompleteRedraw();
		
			base.OnResize (e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			double p = (float)(this.Value-this.Minimum) / (this.Maximum-this.Minimum);
			int wd = (int)((this.SensitiveWidth) * p)+1;
			if (p==0) wd=0;
			Rectangle selrect = new Rectangle(0, 0, wd, Height);
			Rectangle rect = new Rectangle(wd, 0, (Width)-wd, Height);

			SetGraphicsMode(e.Graphics, true);
			e.Graphics.DrawImage(cachedimg, rect, rect, GraphicsUnit.Pixel);
			e.Graphics.DrawImage(cachedimgsel, selrect, selrect, GraphicsUnit.Pixel);
		}

		#endregion

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// ExtProgressBar
			// 
			this.Name = "ExtProgressBar";
			this.Size = new System.Drawing.Size(150, 16);

		}
		#endregion

		#region Background Graphics
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

		Bitmap cachedimgsel;
		Bitmap cachedimg;

		void CompleteRedraw()
		{			
			if (Width<=8) return;
			if (Height<=8) return;		
			if (cachedimg!=null) cachedimg.Dispose();			
			if (cachedimgsel!=null) cachedimgsel.Dispose();

			try 
			{
				cachedimg = new Bitmap(Width, Height);
				cachedimgsel = new Bitmap(Width, Height);
			}
			catch 
			{
				cachedimg = new Bitmap(1, 1);
				cachedimgsel = new Bitmap(1, 1);
				return;
			}
			try 
			{
				Graphics g = Graphics.FromImage(cachedimg);
				Graphics gsel = Graphics.FromImage(cachedimgsel);
				CompleteRedraw(g, gsel);
				g.Dispose();
				gsel.Dispose();
			} 
			catch {}
		}

		void CompleteRedraw(Graphics g, Graphics gsel)
		{
			SetGraphicsMode(g, true);						
			SetGraphicsMode(gsel, true);		
			g.FillRectangle(new SolidBrush(base.BackColor), 0, 0, Width, Height);
			SetGraphicsMode(g, !quality);	
			SetGraphicsMode(gsel, !quality);
			
			if (style == ProgresBarStyle.Flat) UserDrawFlat(g, gsel);
			else if (style == ProgresBarStyle.Simple) UserDrawSimple(g, gsel);
			else if (style == ProgresBarStyle.Increase) UserDrawIncrease(g, gsel);
			else if (style == ProgresBarStyle.Decrease) UserDrawDecrease(g, gsel);
			else if (style == ProgresBarStyle.Balance) UserDrawBalance(g, gsel);
		}

		protected virtual void DrawTokens(Graphics g, Graphics gsel, int left, int top, int width, int height)
		{
			
			int rad = 2;

			Ambertation.Drawing.GraphicRoutines.FillRoundRect(g, new SolidBrush(this.UnselectedColor), left, top, width, height, rad);
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gsel, new SolidBrush(this.SelectedColor), left, top, width, height, rad);

			//if ((this.TokenWidth>8 || this.Height>16)) 
			{
				SetGraphicsMode(g, true);						
				SetGraphicsMode(gsel, true);
				LinearGradientBrush b 
					= new LinearGradientBrush(
					new Rectangle(left, top, width, height), 
					Color.FromArgb(80, this.GradientStartColor), 
					Color.FromArgb(50, this.GradientEndColor), 
					LinearGradientMode.ForwardDiagonal
					);				
			
				Ambertation.Drawing.GraphicRoutines.FillRoundRect(g, b, left, top, width, height, rad);			
				b.Dispose();
	
			
				CreateGlossyGradient(gsel, left, top, width, height, rad);	

				SetGraphicsMode(g, !quality);	
				SetGraphicsMode(gsel, !quality);
			}
		
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(g, new Pen(this.BorderColor), left, top, width, height, rad);
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gsel, new Pen(this.BorderColor), left, top, width, height, rad);
		}	
			
		protected virtual void DrawTokenline(Graphics g, Graphics gsel, int left, int top, int width, int height)
		{
			int rad = 2;
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gsel, new SolidBrush(this.SelectedColor), left+1, top+1, width-1, height-1, rad);
			CreateGlossyGradient(gsel, left, top, width, height, 3);	
			
		}


		void CreateGlossyGradient(Graphics g,int left, int top, int width, int height, int rad)
		{
			LinearGradientBrush b 
				= new LinearGradientBrush(
				new Rectangle(left, top+1, width, height-2), 
				this.GradientStartColor, 
				Color.Transparent, 
				this.Gradient
				);	

			float[] relativeIntensities = {0.2f, 0.7f, 1f, 1f};
			float[] relativePositions   = {0.0f, 0.1f, 0.5f, 1.0f};

			//Create a Blend object and assign it to linGrBrush.
			Blend blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
						
			b.Blend = blend;	

			Ambertation.Drawing.GraphicRoutines.FillRoundRect(g, b, left, top+1, width, height-2, rad);
			b.Dispose();

			b 
				= new LinearGradientBrush(
				new Rectangle(left, top, width, height), 
				this.GradientEndColor, 
				Color.Transparent, 
				this.Gradient
				);	

			relativeIntensities = new float[]{1f, 1f, 0.7f, 0.5f};
			relativePositions   = new float[]{0.0f, 0.5f, 0.7f, 1.0f};

			//Create a Blend object and assign it to linGrBrush.
			blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
						
			b.Blend = blend;	

			Ambertation.Drawing.GraphicRoutines.FillRoundRect(g, b, left, top+1, width, height-1, rad);
			b.Dispose();
		}

		protected virtual void UserDrawBackground(Graphics g, Graphics gsel)
		{	
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gsel, new SolidBrush(this.ProgressBackColor), 0, 0, Width-2, Height-1, 3);
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gsel, new SolidBrush(Color.FromArgb(150, this.BorderColor)), 0, 0, Width-2, Height-1, 3);
			Ambertation.Drawing.GraphicRoutines.FillRoundRect(gsel, new SolidBrush(this.ProgressBackColor), 1, 1, Width-3, Height-2, 3);
			
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gsel, new Pen(Color.FromArgb(200, this.BorderColor)), 0, 0, Width-2, Height-1, 3);

			g.DrawImageUnscaled(this.cachedimgsel, 0, 0);
		}
		#endregion

		#region Styles
		
		protected virtual void UserDrawSimple(Graphics g, Graphics gsel)
		{	
			UserDrawBackground(g, gsel);

			DrawTokenline(g, gsel, 2, 2, Width-7, Height-5);
		}

		protected virtual void UserDrawFlat(Graphics g, Graphics gsel)
		{			
			for (int i=0; i<this.TokenCount; i++)
			{
				int left = this.TokenOffset(i);
				
				DrawTokens(g, gsel, left, 0, TokenWidth, Height-1);
			}
		}

		protected virtual void UserDrawIncrease(Graphics g, Graphics gsel)
		{
			double minhg = (Height-1) / 4.0;
			double step = ((Height-1) - minhg) / (this.TokenCount-1);
			for (int i=0; i<this.TokenCount; i++)
			{
				int left = this.TokenOffset(i);
				int height = (int)Math.Floor(minhg + i*step);
				int top = (Height-1)-height;

				DrawTokens(g, gsel, left, top, TokenWidth, height);
			}

		}

		protected virtual void UserDrawDecrease(Graphics g, Graphics gsel)
		{
			double minhg = (Height-1) / 4.0;
			double step = ((Height-1) - minhg) / (this.TokenCount-1);
			for (int i=0; i<this.TokenCount; i++)
			{
				int left = this.TokenOffset(i);
				int height = (int)Math.Floor(minhg + (this.TokenCount-1-i)*step);
				int top = (Height-1)-height;

				DrawTokens(g, gsel, left, top, TokenWidth, height);
			}
		}

		protected virtual void UserDrawBalance(Graphics g, Graphics gsel)
		{
			double minhg = (Height-1) / 4.0;
			int mid = ((this.TokenCount-1) / 2);
			double step = ((Height-1) - minhg) / mid;
			for (int i=0; i<this.TokenCount; i++)
			{
				int left = this.TokenOffset(i);
				int height = 0;
				if (i>mid) height = (int)Math.Floor(minhg + (i-mid)*step);
				else height = (int)Math.Floor(minhg + (mid-i)*step);
				int top = (Height-1)-height;

				DrawTokens(g, gsel, left, top, TokenWidth, height);
			}
		}

		
		#endregion

		#region Properties
		public int SensitiveWidth 
		{
			get { return TokenOffset(this.TokenCount-1)+TokenWidth; }
		}
		public int TokenOffset(int nr)
		{
			return (int)Math.Floor(nr * (TokenWidth+Math.Floor(TokenMinSpacing)));
		}

		int tw;
		void SetTokenWidth(int val)
		{
			if (tw==val) return;
			tw = Math.Max(4, val);
			tc =  Math.Max(2, (int)Math.Floor((Width-1) / (tw+2))); 	
			CompleteRedraw();	
			Invalidate();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int TokenWidth
		{
			get { return tw; }
			set
			{
				SetTokenWidth(value);									
			}
		}

		int tc;
		void SetTokenCount(int val)
		{
			if (tc==val) return;				
			tc = Math.Max(2, val);					

			tw =  Math.Max(4, ((Width-1) / tc)-2);
 			CompleteRedraw();		
			Invalidate();						
		}
		public virtual int TokenCount
		{
			get { 				
				if (style==ProgresBarStyle.Balance && (tc%2)==0) return tc-1;
				return tc;
			}
			set 
			{
				SetTokenCount(value);							
			}
		}

		public double TokenMinSpacing
		{
			get { return ((Width-1)-(TokenCount*TokenWidth)) / ((float)TokenCount - 1); }
		}
		#endregion
	}

	internal class SubExtProgressBar : ExtProgressBar 
	{
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public override int TokenCount
		{
			get
			{
				return base.TokenCount;
			}
			set
			{
				base.TokenCount = value;
			}
		}

	}
}
