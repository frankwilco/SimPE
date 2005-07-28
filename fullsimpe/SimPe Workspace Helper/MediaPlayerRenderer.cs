using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace TD.SandBar
{
	public class MediaPlayerRenderer : TD.SandBar.Office2003Renderer
	{
		
		Color HighlightColor
		{
			get { return base.ActionsButtonColor2;}
		}

		Color CheckedColor
		{
			get { return Color.YellowGreen;}
		}
		public override void DrawMenuItemHighlight(Graphics graphics, MenuButtonItem item, Rectangle bounds)
		{
			if (item.Enabled)
			{				
				
				SolidBrush background = new SolidBrush(Color.FromArgb(80, HighlightColor));
				graphics.FillRectangle(background, bounds);
				background.Dispose();
			}
		}

		public override void DrawButtonHighlight(Graphics graphics, Rectangle bounds, DrawItemState state, bool dropDown)
		{
			SolidBrush background;

			if (state != DrawItemState.Default)
			{
				
				// Create background brush
				if ((state & DrawItemState.Selected) == DrawItemState.Selected)
					background = new SolidBrush(Color.FromArgb(120, HighlightColor));
				else if ((state & DrawItemState.HotLight) == DrawItemState.HotLight)
					background = new SolidBrush(Color.FromArgb(80, HighlightColor));
				else if ((state & DrawItemState.Checked) == DrawItemState.Checked)
					background = new SolidBrush(Color.FromArgb(120, CheckedColor));
				else
					background = new SolidBrush(Color.FromArgb(0, HighlightColor));
				graphics.FillRectangle(background, bounds);
				background.Dispose();
			}
		}

		public override void DrawToolBarBackground(TD.SandBar.ToolBar toolbar, System.Drawing.Graphics graphics, Rectangle bounds, bool vertical)
		{
			Color color1, color2, color3, color4;

			if (toolbar is MenuBar || toolbar is ContainerBar)
				base.DrawToolBarBackground(toolbar, graphics, bounds, vertical);
			else
			{
				// Calculate colours used in gradient
				color1 = ToolBarGradientColor1;
				color2 = ToolBarGradientColor2;
				color3 = InterpolateColors(color1, color2, 0.4F);
				color4 = InterpolateColors(color1, color2, 0.8F);

				// Create linear gradient brush
				LinearGradientMode direction = vertical ? LinearGradientMode.Horizontal : LinearGradientMode.Vertical;
				using(LinearGradientBrush l = new LinearGradientBrush(bounds, color1, color2, direction))
				{
					// Set colour values
					ColorBlend cb = new ColorBlend(5);
					cb.Colors = new Color[] { color1, color2, color2, color3, color4 };
					cb.Positions = new float[] { 0F, 0.47F, 0.53F, 0.75F, 1F };
					l.InterpolationColors = cb;

					// Fill background
					graphics.FillRectangle(l, bounds);
				}

				// Draw toolbar border if necessary
				if (toolbar.DrawActionsButton)
				{
					Pen p = new Pen(BorderColor);
					if (vertical)
						graphics.DrawLine(p, bounds.Right, bounds.Top + 3, bounds.Right, bounds.Bottom - 3);
					else
						graphics.DrawLine(p, bounds.X + 2, bounds.Bottom - 1, bounds.Right - 3, bounds.Bottom - 1);
					p.Dispose();
				}
			}
		}

	}
}
