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
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;

namespace Ambertation.Windows.Forms
{

	/// <summary>
	/// Implements a CHeckBox that can use a Transparent Background
	/// </summary>
	/// <remarks>
	/// This Code was created by "The Man from U.N.C.L.E.". 
	/// (http://www.thecodeproject.com/cs/miscctrl/customcheckbox.asp)
	/// </remarks>
	[ToolboxBitmapAttribute(typeof(CheckBox))]
	public class TransparentCheckBox : CheckBox
	{
		private FlatStyle _FlatStyle = FlatStyle.System;
	
		[DefaultValueAttribute(typeof(FlatStyle), "System")]
		public new FlatStyle FlatStyle 
		{
			get 
			{
				return this._FlatStyle;
			}
			set 
			{
				if (this._FlatStyle.Equals(value)) 
				{
					return;
				}
				this._FlatStyle = value;
				if (this._FlatStyle.Equals(FlatStyle.System)) 
				{
					base.FlatStyle = FlatStyle.Standard;
				} 
				else 
				{
					base.FlatStyle = value;
				}
			}
		}
	
		[DefaultValueAttribute(typeof(System.Drawing.Color), "Transparent")]
		public override System.Drawing.Color BackColor 
		{
			get 
			{
				return base.BackColor;
			}
			set 
			{
				base.BackColor = value;
			}
		}
	
		public TransparentCheckBox() : base()
		{
			this.SetDefaultControlStyles();
			this.customInitialisation();
		}
	
		private void SetDefaultControlStyles()
		{
			this.SetStyle(ControlStyles.DoubleBuffer, true);
			this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			this.SetStyle(ControlStyles.ResizeRedraw, true);
			this.SetStyle(ControlStyles.UserPaint, true);
			this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
		}
	
		private void customInitialisation()
		{
			this.SuspendLayout();
			this._FlatStyle = FlatStyle.System;
			this.BackColor = Color.Transparent;
			this.ResumeLayout(false);
		}
	
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			if (this._FlatStyle.Equals(FlatStyle.System)) 
			{
				DrawingHelper.DrawCheckBox(e.Graphics, this.GetCheckBoxRectangle(), false, this.CheckState);
			}
		}
	
		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			if (this._FlatStyle.Equals(FlatStyle.System)) 
			{
				Graphics graph = this.CreateGraphics();
				DrawingHelper.DrawCheckBox(graph, this.GetCheckBoxRectangle(), false, this.CheckState);
				graph.Dispose();
			}
		}
	
		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			if (this._FlatStyle.Equals(FlatStyle.System)) 
			{
				Graphics graph = this.CreateGraphics();
				DrawingHelper.DrawCheckBox(graph, this.GetCheckBoxRectangle(), true, this.CheckState);
				graph.Dispose();
			}
		}
	
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			if (this._FlatStyle.Equals(FlatStyle.System)) 
			{
				Graphics graph = this.CreateGraphics();
				DrawingHelper.DrawCheckBox(graph, this.GetCheckBoxRectangle(), true, this.CheckState);
				graph.Dispose();
			}
		}
	
		protected Rectangle GetCheckBoxRectangle()
		{
			int x = 0;
			int y = 2;
			int w = 12;
			if (this.CheckAlign ==  ContentAlignment.BottomCenter) 
			{
				x = DrawingHelper.ToInt32((this.Width - w) / 2) - 1;
				y = this.Height - w - 2;
			} 
			else if (this.CheckAlign == ContentAlignment.BottomLeft) 
			{
				y = this.Height - w - 2;
			} 
			else if (this.CheckAlign == ContentAlignment.BottomRight) 
			{
				x = this.Width - w - 2;
				y = this.Height - w - 2;
			} 
			else if (this.CheckAlign == ContentAlignment.MiddleCenter) 
			{
				x = DrawingHelper.ToInt32((this.Width - w) / 2) - 1;
				y = DrawingHelper.ToInt32((this.Height - w) / 2) - 1;
			} 
			else if (this.CheckAlign == ContentAlignment.MiddleLeft) 
			{
				y = DrawingHelper.ToInt32((this.Height - w) / 2) - 1;
			} 
			else if (this.CheckAlign == ContentAlignment.MiddleRight) 
			{
				x = this.Width - w - 2;
				y = DrawingHelper.ToInt32((this.Height - w) / 2) - 1;
			} 
			else if (this.CheckAlign == ContentAlignment.TopCenter) 
			{
				x = DrawingHelper.ToInt32((this.Width - w) / 2) - 1;
			} 
			else if (this.CheckAlign == ContentAlignment.TopLeft) 
			{
			} 
			else if (this.CheckAlign == ContentAlignment.TopRight) 
			{
				x = this.Width - w - 2;
			}
			return new Rectangle(x, y, w, w);
		}
	}

	/// <remarks>
	/// This Code was created by "The Man from U.N.C.L.E.". 
	/// (http://www.thecodeproject.com/cs/miscctrl/customcheckbox.asp)
	/// </remarks>
	internal class DrawingHelper
	{
	
		public static void DrawCheckBox(Graphics graph, Rectangle rect, bool hot, CheckState state)
		{
			DrawCheckBackground(graph, rect);
			if (hot.Equals(true)) 
			{
				DrawCheckHot(graph, rect);
			}
			DrawCheckState(graph, rect, state);
		}
	
		private static void DrawCheckBackground(Graphics graph, Rectangle rect)
		{
			LinearGradientBrush fillBrush;
			fillBrush = new LinearGradientBrush(rect, SystemColors.ControlLightLight, SystemColors.ControlDark, LinearGradientMode.ForwardDiagonal);
			fillBrush.SetSigmaBellShape(0F, 0.5F);
			Pen borderPen;
			borderPen = new Pen(CustomColors.CheckBoxBorder, 1);
			graph.FillRectangle(fillBrush, rect);
			graph.DrawRectangle(borderPen, rect);
			fillBrush.Dispose();
			borderPen.Dispose();
		}
	
		private static void DrawCheckHot(Graphics graph, Rectangle rect)
		{
			LinearGradientBrush fillBrush;
			Pen hotPen;
			fillBrush = new LinearGradientBrush(rect, CustomColors.CheckBoxHoverLight, CustomColors.CheckBoxHoverDark, LinearGradientMode.ForwardDiagonal);
			float[] relativeIntensities = {0F, 0.7F, 1F};
			float[] relativePositions = {0F, 0.5F, 1F};
			Blend blend = new Blend();
			blend.Factors = relativeIntensities;
			blend.Positions = relativePositions;
			fillBrush.Blend = blend;
			hotPen = new Pen(fillBrush, 1);
			Rectangle rect1 = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
			Rectangle rect2 = new Rectangle(rect.X + 2, rect.Y + 2, rect.Width - 4, rect.Height - 4);
			graph.DrawRectangles(hotPen, new Rectangle[]{rect1, rect2});
			fillBrush.Dispose();
			hotPen.Dispose();
		}
	
		private static void DrawCheckState(Graphics graph, Rectangle rect, CheckState state)
		{
			if (state == CheckState.Checked) 
			{
				Pen checkPen;
				checkPen = new Pen(CustomColors.CheckBoxCheck, 1);
				System.Drawing.PointF[] points;
				points = new System.Drawing.PointF[]{new System.Drawing.PointF(rect.X + 3, rect.Y + 5), new System.Drawing.PointF(rect.X + 5, rect.Y + 7), new System.Drawing.PointF(rect.X + 9, rect.Y + 3), new System.Drawing.PointF(rect.X + 9, rect.Y + 4), new System.Drawing.PointF(rect.X + 5, rect.Y + 8), new System.Drawing.PointF(rect.X + 3, rect.Y + 6), new System.Drawing.PointF(rect.X + 3, rect.Y + 7), new System.Drawing.PointF(rect.X + 5, rect.Y + 9), new System.Drawing.PointF(rect.X + 9, rect.Y + 5)};
				graph.DrawLines(checkPen, points);
				checkPen.Dispose();
			} 
			else if (state == CheckState.Indeterminate) 
			{
				Brush checkBrush;
				checkBrush = new SolidBrush(CustomColors.CheckBoxCheck);
				Rectangle rect1 = new Rectangle(rect.X + 3, rect.Y + 3, rect.Width - 5, rect.Height - 5);
				graph.FillRectangle(checkBrush, rect1);
				checkBrush.Dispose();
			} 
			else if (state == CheckState.Unchecked) 
			{
			}
		}
	
		public static int ToInt32(double value)
		{
			decimal decValue = new decimal( value );
			return Decimal.ToInt32(Decimal.Floor(decValue));
		}
	
	}

	internal class CustomColors
	{
		public const int NoTheme = 1;
		public const int NormalColor = 1;
		public const int HomeStead = 2;
		public const int Metallic = 3;
		private static Color[] _ExplorerBarHeaderFont = {Color.FromArgb(33, 93, 198), Color.FromArgb(86, 102, 45), Color.FromArgb(63, 61, 61)};
		private static Color[] _CheckBoxHoverLight = {Color.FromArgb(255, 240, 207), Color.FromArgb(255, 240, 207), Color.FromArgb(255, 240, 207)};
		private static Color[] _CheckBoxHoverDark = {Color.FromArgb(249, 179, 48), Color.FromArgb(249, 179, 48), Color.FromArgb(249, 179, 48)};
		private static Color[] _CheckBoxCheck = {Color.FromArgb(33, 161, 33), Color.FromArgb(33, 161, 33), Color.FromArgb(33, 161, 33)};
	
		public static Color CheckBoxHoverLight 
		{
			get 
			{
				return _CheckBoxHoverLight[CurrentThemeIndex - 1];
			}
		}
	
		public static Color CheckBoxHoverDark 
		{
			get 
			{
				return _CheckBoxHoverDark[CurrentThemeIndex - 1];
			}
		}
	
		public static Color CheckBoxBorder 
		{
			get 
			{
				return _ExplorerBarHeaderFont[CurrentThemeIndex - 1];
			}
		}
	
		public static Color CheckBoxCheck 
		{
			get 
			{
				return _CheckBoxCheck[CurrentThemeIndex - 1];
			}
		}
	
		private static int CurrentThemeIndex 
		{
			get 
			{
				int index = CustomColors.NoTheme;
				if (CustomColors.ThemesSupported.Equals(true)) 
				{
					try 
					{
						index = CustomColors.CurrentThemeIndexInternal;
					} 
					catch 
					{
						index = CustomColors.NoTheme;
					} 
					finally 
					{
					}
				}
				return index;
			}
		}
	
		private static int CurrentThemeIndexInternal 
		{
			get 
			{
				try 
				{
					System.Text.StringBuilder sbFile = new System.Text.StringBuilder(255);
					System.Text.StringBuilder sbColor = new System.Text.StringBuilder(255);
					UnsafeNativeMethods.GetCurrentThemeName(sbFile, sbFile.Capacity, sbColor, sbColor.Capacity, null, 0);
					if (sbColor.ToString().ToUpper().Trim() == "NORMALCOLOR") 
					{
						return CustomColors.NormalColor;
					} 
					else if (sbColor.ToString().ToUpper().Trim() == "HOMESTEAD") 
					{
						return CustomColors.HomeStead;
					} 
					else if (sbColor.ToString().ToUpper().Trim() == "METALLIC") 
					{
						return CustomColors.Metallic;
					}
					return CustomColors.Metallic;
				} 
				catch 
				{
					return CustomColors.NoTheme;
				}
			}
		}
	
		public static bool ThemesSupported 
		{
			get 
			{
				if ((System.Environment.OSVersion.Version.Major > 4) && (System.Environment.OSVersion.Version.Minor > 0)) 
				{
					return true;
				} 
				else 
				{
					return false;
				}
			}
		}
	
		private CustomColors()
		{
		}
		[SuppressUnmanagedCodeSecurityAttribute()]
			private class UnsafeNativeMethods
		{
	
			[System.Runtime.InteropServices.DllImportAttribute("uxtheme.dll", CharSet=System.Runtime.InteropServices.CharSet.Unicode)]
			public static extern void GetCurrentThemeName(System.Text.StringBuilder sbThemeFileName, int maxNameChars, System.Text.StringBuilder sbColorScheme, int maxColorChars, System.Text.StringBuilder sbSizeName, int maxSizeChars);
		}
	}
}
