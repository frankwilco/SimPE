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
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Ambertation.Windows.Forms
{
	/// <summary>
	///Wrapper for UXTheme Methods
	/// </summary>
	public class UxTheme
	{
		#region Structures
		[StructLayout(LayoutKind.Sequential)]
		internal struct RECT
		{
			public int left;
			public int top;
			public int right;
			public int bottom;

			public RECT(Rectangle r) : this(r.Left, r.Top, r.Right, r.Bottom) {}

			public RECT(int left, int top, int right, int bottom)
			{
				this.left = left;
				this.top = top;
				this.right = right;
				this.bottom = bottom;
			}

			public override string ToString()
			{
				Rectangle rectangle1 = Rectangle.FromLTRB(left, top, right, bottom);
				return rectangle1.ToString();

			}
		}

		[StructLayout(LayoutKind.Sequential)]
		private struct VER
		{
			public int Size;
			public int Major;
			public int Minor;
			public int Build;
			public int Private;
		}
		#endregion

		#region Imports
		[DllImport("uxtheme.dll", CharSet=CharSet.Unicode)]
		private static extern bool CloseThemeData(IntPtr hTheme);
 
		[DllImport("uxtheme.dll", CharSet=CharSet.Unicode)]
		internal static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hDC, int iPartId, int iStateId, ref RECT pRect, ref RECT pClipRect);
		
		[DllImport("uxtheme", ExactSpelling=true, CharSet=CharSet.Unicode)]
		internal extern static Int32 DrawThemeParentBackground(IntPtr hWnd, IntPtr hdc, ref RECT pRect);

		[DllImport("uxtheme.dll", CharSet=CharSet.Unicode)]
		private static extern int GetThemeColor(IntPtr hTheme, int partId, int stateId, int propId, out int color);
 
		[DllImport("uxtheme.dll", CharSet=CharSet.Unicode)]
		private static extern IntPtr OpenThemeData(IntPtr hwnd, string pszClassList);

		[DllImport("uxtheme.dll")]
		private static extern bool IsAppThemed();

		[DllImport("uxtheme.dll")]
		private static extern bool IsThemeActive();

		[DllImport("comctl32.dll")]
		private static extern int DllGetVersion(ref VER dvi);
 

		[ DllImport("uxTheme.dll", CharSet=System.Runtime.InteropServices.CharSet.Unicode) ]
		internal static extern bool GetTextColor(string name, string part, string state, out int r, out int g, out int b);
		#endregion


		static Version ver;
		private static bool themed;
 
		static UxTheme()
		{
			try
			{
				VER myver;
				themed = OSFeature.Feature.IsPresent(OSFeature.Themes);
				myver = new VER();
				myver.Size = Marshal.SizeOf(typeof(VER));
				if (DllGetVersion(ref myver) == 0)				
					ver = new Version(myver.Major, myver.Minor, myver.Build);				
			}
			catch (Exception)
			{
				ver = new Version();
			}
		}


		public static Version ControlVersion
		{
			get { return ver; }
		}

		public static bool Themed
		{
			get{ return themed;	}
		}
 
		public static bool VisualStylesEnabled
		{
			get
			{
				if (!Themed)
				{
					return false;
				}
				if (!IsAppThemed())
				{
					return false;
				}
				/*if (ThemeInformation.CommonControlVersion.Major < 6)
				{
					return (x672ea9c0e87317b9.x6dcfe56a50b94ea4 > 0);
				}*/
				return true;
			}
		}
 



		public static void Draw(Graphics g, Control ctl, string themeClass, int themePart, int themeState, Rectangle bounds, Rectangle clipRect)
		{
			if (Themed)
			{
				IntPtr p = OpenThemeData(ctl.Handle, themeClass);
				if (p != IntPtr.Zero)
				{
					IntPtr ptr2 = IntPtr.Zero;
					try
					{
						ptr2 = g.GetHdc();
						RECT bound = new RECT(bounds);
						RECT clip = new RECT(clipRect);
						DrawThemeBackground(p, ptr2, themePart, themeState, ref bound, ref clip);
					}
					finally
					{
						if (ptr2 != IntPtr.Zero) g.ReleaseHdc(ptr2);						
						CloseThemeData(p);
					}
				}
			}
		}
 
		public static void DrawBackground(Graphics g, Control ctl, Rectangle clipRect)
		{
			DrawBackground(g, ctl, clipRect, false);
		}
 
		public static void DrawBackground(Graphics g, Control ctl, Rectangle clipRect, bool ignoreBackColor)
		{
			if (Themed && (ignoreBackColor || (ctl.BackColor.ToKnownColor() == KnownColor.Control)))
			{
				IntPtr p = IntPtr.Zero;
				try
				{
					p = g.GetHdc();
					RECT rect = new RECT(clipRect);
					DrawThemeParentBackground(ctl.Handle, p, ref rect);
				}
				finally
				{
					if (p != IntPtr.Zero) g.ReleaseHdc(p);					
				}
			}
			else
			{
				using (Brush brush1 = new SolidBrush(ctl.BackColor))
				{
					g.FillRectangle(brush1, clipRect);
				}
			}
		}
	}
}
