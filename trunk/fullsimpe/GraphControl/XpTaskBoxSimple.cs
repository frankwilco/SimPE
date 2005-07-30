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
	[DesignTimeVisible(true), ToolboxBitmapAttribute(typeof(GroupBox))]
	public class XPTaskBoxSimple : Panel
	{		

		// Methods
		public XPTaskBoxSimple()
		{
			this.mstrHeaderText = "";
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

			icsz = new Size(32, 32);
			icpt = new Point(4, 12);
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
					this.Invalidate();
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
					this.Invalidate();
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

		Size icsz;
		public Size IconSize
		{
			get { return icsz; }
			set 
			{
				if (icsz!=value) 
				{
					icsz = value;
					Invalidate();
				}
			}
		}

		Point icpt;
		public Point IconLocation
		{
			get { return icpt; }
			set 
			{
				if (icpt!=value) 
				{
					icpt = value;
					Invalidate();
				}
			}
		}
		
		protected override void OnPaint(PaintEventArgs e)
		{
			Rectangle ef4;
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			Rectangle ef3 = new Rectangle(0, 16, this.Width-1, 22);
			Rectangle ef3b = new Rectangle(3, ef3.Bottom, this.Width-7, this.Height-ef3.Bottom-4);
			Rectangle ef2 = new Rectangle(0, 40, this.Width-1, (this.Height - 41));
			Rectangle ef1 = new Rectangle(0, 16, this.Width-1,(this.Height - 0x11));
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
			e.Graphics.FillPath(brush1, path);
			

			path = Ambertation.Drawing.GraphicRoutines.GethRoundRectPath(ef3b, 7);			
			e.Graphics.FillPath(new SolidBrush(BodyColor), path);

			path = Ambertation.Drawing.GraphicRoutines.GethRoundRectPath(ef1, 7);			
			e.Graphics.DrawPath(borderpen, path);
			if (this.mIcon != null)
			{
				Size size1 = mIcon.Size;
				Rectangle rectangle1 = new Rectangle(IconLocation, size1);
				e.Graphics.DrawImage(
					//Ambertation.Drawing.GraphicRoutines.ScaleImage(mIcon, size1.Width, size1.Height, true)					
					mIcon
					, rectangle1,
					new Rectangle(0, 0, mIcon.Width, mIcon.Height), 
					GraphicsUnit.Pixel);
				ef4 = new Rectangle(8+size1.Width+IconLocation.X, 16, (this.Width - (size1.Width+IconLocation.X)), 22);
			}
			else
			{
				ef4 = new Rectangle(8, 16, (this.Width - 0x18), 22);
			}
			e.Graphics.DrawString(this.mstrHeaderText, this.HeaderFont, new SolidBrush(this.HeaderTextColor), ef4, format1);
			
			path.Dispose();
			brush1.Dispose();
			borderpen.Dispose();
			format1.Dispose();
			base.OnPaint(e);
		}

		

		// Properties
		[Category("Appearance"), DefaultValue("Title"), Localizable(true), Browsable(true), Description("Caption text.")]
		public string HeaderText
		{
			get
			{
				return this.mstrHeaderText;
			}
			set
			{
				this.mstrHeaderText = value;
				this.Invalidate();
			}
		}

		

		[Localizable(true), Description("Icon"), Category("Appearance"), DefaultValue(typeof(System.Drawing.Icon), "")]
		public System.Drawing.Image Icon
		{
			get
			{
				return this.mIcon;
			}
			set
			{
				this.mIcon = value;
				this.Invalidate();
			}
		}

		
		

		

		[Browsable(false), Description("returns the usable region as Rectangle")]
		internal Rectangle WorkspaceRect
		{
			get
			{
				return new Rectangle(3, 0x29, this.Width - 7, (this.Height - 40) - 4);
			}
		}


		// Fields
		private IContainer components;
		private System.Drawing.Image mIcon;
		private string mstrHeaderText;
	}
}
