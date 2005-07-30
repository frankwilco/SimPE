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
	/// This is a Rounded Panel
	/// </summary>
	public abstract class RoundedPanel : GraphItemBase
	{
		
		public RoundedPanel() :base ()
		{
			/*SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);*/
			
			base.BackColor = Color.Transparent;
			bg = Color.DarkOrange;
			gradcl = Color.White;
			bdcl = Color.FromArgb(90, Color.Black);
			fadecl = Color.FromArgb(80, Color.White);
			fade = 0.9f;
			
		}		

		#region public Properties
		

		Color bg;
		public Color PanelColor
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
					Invalidate();
				}
			}
		}

		float fade;
		public float Fade
		{
			get {return fade;}
			set {
				if (fade != value) 
				{
					fade = value;
					Invalidate();
				}
			}
		}

		Color fadecl;
		public Color FadeColor
		{
			get {return fadecl;}
			set 
			{
				if (fadecl != value) 
				{
					fadecl = value;
					Invalidate();
				}
			}
		}

		Color gradcl;
		public Color GradientColor
		{
			get {return gradcl;}
			set 
			{
				if (gradcl != value) 
				{
					gradcl = value;
					Invalidate();
				}
			}
		}

		Color bdcl;
		public Color BorderColor
		{
			get {return bdcl;}
			set 
			{
				if (bdcl != value) 
				{
					bdcl = value;
					Invalidate();
				}
			}
		}
		#endregion

		#region Properties
			
		#endregion


		

		#region Event Override		
		protected override void OnPaint(Graphics g, Image canvas, Rectangle dst, Rectangle src)
		{			
			if (!Focused && fade<1)
			{
				System.Drawing.Imaging.ImageAttributes imgAttributes = SetupImageAttr(fade);
				g.DrawImage(canvas, dst, src.Left, src.Top, src.Width, src.Height, System.Drawing.GraphicsUnit.Pixel, imgAttributes);
			} 
			else 
			{
				g.DrawImage(canvas, dst, src, System.Drawing.GraphicsUnit.Pixel);
			}			
		}		

		internal override void OnLostFocus(EventArgs e)
		{
			base.OnLostFocus (e);	
			this.CompleteRedraw();
			Refresh();	
		}

		internal override void OnGotFocus(EventArgs e)
		{
			//this.SendToFront();
			base.OnGotFocus (e);	
			this.CompleteRedraw();
			Refresh();	
		}		
		
		#endregion

		#region Basic Draw Methods
		static System.Drawing.Imaging.ImageAttributes SetupImageAttr(float alpha)
		{
			float[][] ptsArray ={ 
									new float[] {1, 0, 0, 0, 0},
									new float[] {0, 1, 0, 0, 0},
									new float[] {0, 0, 1, 0, 0},
									new float[] {0, 0, 0, alpha, 0}, 
									new float[] {0, 0, 0, 0, 1}}; 
			System.Drawing.Imaging.ColorMatrix clrMatrix = new System.Drawing.Imaging.ColorMatrix(ptsArray);
			System.Drawing.Imaging.ImageAttributes imgAttributes = new System.Drawing.Imaging.ImageAttributes();
			imgAttributes.SetColorMatrix(clrMatrix,
				System.Drawing.Imaging.ColorMatrixFlag.Default,
				System.Drawing.Imaging.ColorAdjustType.Bitmap);

			return imgAttributes;
		}

		protected void DrawNiceRoundRect(Graphics gr, int left, int top, int width, int height)
		{
			int rad = Math.Min(Math.Min(20, height/2), width/2);
			DrawNiceRoundRect(gr, left, top, width, height, rad, PanelColor);
		}

		protected void DrawNiceRoundRect(Graphics gr, int left, int top, int width, int height, int rad, Color panelColor)
		{			
			DrawNiceRoundRectStart(gr, left, top, width, height, rad, panelColor, BorderColor, GradientColor, FadeColor, Focused);
			this.DrawText(gr);
			DrawNiceRoundRectEnd(gr, left, top, width, height, rad, panelColor, BorderColor, GradientColor, FadeColor, Focused);
		}

		protected static void DrawNiceRoundRectStart(Graphics gr, int left, int top, int width, int height, int rad, Color bg, Color borderColor, Color gradientColor, Color fadeColor, bool focused)
		{
			Rectangle srect = new Rectangle(left, top, width-1, height-1);

			
			Pen linepen = new Pen(borderColor);
			if (focused) 
			{
				
				LinearGradientBrush linGrBrush = new LinearGradientBrush(
					new Point(left, top+height),
					new Point(left, top),					
					bg,
					gradientColor); 


				float[] relativeIntensities = {0.0f, 0.05f, 0.3f};
				float[] relativePositions   = {0.0f, 0.65f, 1.0f};

				//Create a Blend object and assign it to linGrBrush.
				Blend blend = new Blend();
				blend.Factors = relativeIntensities;
				blend.Positions = relativePositions;
				linGrBrush.Blend = blend;							
				
				Ambertation.Drawing.GraphicRoutines.FillRoundRect(gr, linGrBrush, srect, rad);			
				linGrBrush.Dispose();
			} 
			else 
			{
				Brush b = new SolidBrush(bg);
				Ambertation.Drawing.GraphicRoutines.FillRoundRect(gr, b, srect, rad);	
				b.Dispose();				
			}

			linepen.Dispose();
		}

		protected static void DrawNiceRoundRectEnd(Graphics gr, int left, int top, int width, int height, int rad, Color bg, Color borderColor, Color gradientColor, Color fadeColor, bool focused)
		{
			Rectangle srect = new Rectangle(left, top, width-1, height-1);
			Pen linepen = new Pen(borderColor);
			Ambertation.Drawing.GraphicRoutines.DrawRoundRect(gr, linepen, srect, rad);
			linepen.Dispose();

			if (!focused)
			{
				Brush b = new SolidBrush(fadeColor);
				Ambertation.Drawing.GraphicRoutines.FillRoundRect(gr, b, srect, rad);	
				b.Dispose();
			}
		}

		
		

		protected override void UserDraw(Graphics gr)
		{
			
			DrawNiceRoundRect(gr, 0, 0, Width, Height);		
		}

		protected virtual void DrawText(Graphics gr)
		{
		}
		#endregion
	}
}
