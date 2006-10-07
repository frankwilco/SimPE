using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimPe
{


    public class ToolStripProfessionalSquareRenderer : Ambertation.Renderer.AdvancedToolStripProfessionalRenderer
    {
        public ToolStripProfessionalSquareRenderer(ProfessionalColorTable ct)
            : base(ct)
        {
            this.RoundedEdges = false;
        }

        public ToolStripProfessionalSquareRenderer()
            : base()
        {
            this.RoundedEdges = false;
        }
    }

    public class MediaPlayerRenderer : ToolStripProfessionalSquareRenderer
    {
        public MediaPlayerRenderer(ProfessionalColorTable ct)
            : base(ct)
        {

        }

        public MediaPlayerRenderer()
            : base()
        {
        }

        Color CheckedColor
        {
            get { return Color.YellowGreen; }
        }

        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            Rectangle bounds = new Rectangle(Point.Empty, new Size(e.Item.Size.Width - 1, e.Item.Size.Height - 1));
            if (e.Item is ToolStripMenuItem && e.Item.Selected && e.Item.Enabled)
            {
                SolidBrush background = new SolidBrush(Color.FromArgb(80, ColorTable.MenuItemBorder));
                e.Graphics.FillRectangle(background, bounds);
                background.Dispose();
            }
            else if (e.Item is ToolStripButton)
            {
                SolidBrush background;

                // Create background brush
                if (e.Item.Selected)
                    background = new SolidBrush(Color.FromArgb(120, ColorTable.MenuItemBorder));
                else if (e.Item.Pressed)
                    background = new SolidBrush(Color.FromArgb(80, ColorTable.MenuItemBorder));
                else if (((ToolStripButton)e.Item).Checked)
                    background = new SolidBrush(Color.FromArgb(120, CheckedColor));
                else
                {
                    background = new SolidBrush(Color.FromArgb(0, ColorTable.MenuItemBorder));
                    base.OnRenderItemBackground(e);
                    return;
                }
                e.Graphics.FillRectangle(background, bounds);
                Pen pen = new Pen(ColorTable.ButtonSelectedBorder);
                if (!((ToolStripButton)e.Item).Checked) e.Graphics.DrawRectangle(pen, bounds);
                background.Dispose();


            }
            else base.OnRenderItemBackground(e);
        }


        protected override void OnRenderToolStripBackground(ToolStripRenderEventArgs e)
        {
            Color color1, color2, color3, color4;

            if (e.ToolStrip is MenuStrip)
                base.OnRenderToolStripBackground(e);
            else
            {
                // Calculate colours used in gradient
                color1 = this.ColorTable.ToolStripGradientBegin;
                color2 = this.ColorTable.ToolStripGradientEnd;
                color3 = InterpolateColors(color1, color2, 0.4F);
                color4 = InterpolateColors(color1, color2, 0.8F);

                bool vertical = false;

                // Create linear gradient brush
                LinearGradientMode direction = vertical ? LinearGradientMode.Horizontal : LinearGradientMode.Vertical;
                using (LinearGradientBrush l = new LinearGradientBrush(e.AffectedBounds, color1, color2, direction))
                {
                    // Set colour values
                    ColorBlend cb = new ColorBlend(5);
                    cb.Colors = new Color[] { color1, color2, color2, color3, color4 };
                    cb.Positions = new float[] { 0F, 0.47F, 0.53F, 0.75F, 1F };
                    l.InterpolationColors = cb;

                    // Fill background
                    e.Graphics.FillRectangle(l, e.AffectedBounds);
                }
            }
        }
    }

    class MediaPlayerToolStripColorTable : ToolStripColorTable
    {
        public override Color ToolStripGradientBegin
        {
            get
            {
                return Color.FromArgb(0xFD, 0xFD, 0xFB);
            }
        }
        public override Color ToolStripGradientEnd
        {
            get
            {
                return Color.FromArgb(0xB9, 0xB9, 0xA3);
            }
        }

    }

    class ToolStripColorTable : ProfessionalColorTable
    {
        #region Checker
        public override Color CheckBackground
        {
            get
            {
                return Color.FromArgb(0xE1, 0xE6, 0xE8);
            }
        }

        public override Color CheckPressedBackground
        {
            get
            {
                return Color.FromArgb(0x31, 0x6A, 0xC5);
            }
        }

        public override Color CheckSelectedBackground
        {
            get
            {
                return CheckPressedBackground;
            }
        }


        #endregion

        #region Seperator
        public override Color SeparatorDark
        {
            get
            {
                return Color.FromArgb(0xC5, 0xC2, 0xB8);
            }
        }

        public override Color SeparatorLight
        {
            get
            {
                return Color.FromArgb(0xFC, 0xFC, 0xF9);
            }
        }
        #endregion

        #region MenuStrip

        public override System.Drawing.Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(0xE5, 0xE5, 0xD7);
            }
        }


        public override System.Drawing.Color MenuStripGradientEnd
        {
            get
            {
                //return Color.FromArgb(0xF3, 0xF2, 0xE7);
                return Color.White;
            }
        }

        public override Color MenuBorder
        {
            get
            {
                return Color.FromArgb(0x8A, 0x86, 0x7A);
            }
        }
        #endregion

        #region ToolStrip
        public override System.Drawing.Color ToolStripGradientBegin
        {
            get
            {
                return Color.FromArgb(0xFD, 0xFD, 0xFB);
            }
        }

        public override System.Drawing.Color ToolStripGradientMiddle
        {
            get
            {
                return Color.FromArgb(0xEC, 0xEC, 0xE5);
            }
        }

        public override System.Drawing.Color ToolStripGradientEnd
        {
            get
            {
                return Color.FromArgb(0xBE, 0xBE, 0xA7);
            }
        }

        public override Color ToolStripBorder
        {
            get
            {
                return Color.FromArgb(0xA3, 0xA3, 0x7C);
            }
        }
        #endregion

        #region Overflow
        public override Color OverflowButtonGradientBegin
        {
            get
            {
                return Color.FromArgb(0xEF, 0xEE, 0xEB);
            }
        }

        public override Color OverflowButtonGradientMiddle
        {
            get
            {
                return Color.FromArgb(0xE1, 0xE1, 0xDA);
            }
        }

        public override Color OverflowButtonGradientEnd
        {
            get
            {
                return Color.FromArgb(0x92, 0x92, 0x76);
            }
        }
        #endregion

        #region Image Margin
        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(0xFE, 0xFE, 0xFB);
            }
        }

        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(0xC4, 0xC3, 0xAC);
            }
        }

        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(0xED, 0xE9, 0xE2);
            }
        }

        public override Color ImageMarginRevealedGradientBegin
        {
            get
            {
                return ImageMarginGradientBegin;
            }
        }

        public override Color ImageMarginRevealedGradientEnd
        {
            get
            {
                return ImageMarginGradientEnd;
            }
        }

        public override Color ImageMarginRevealedGradientMiddle
        {
            get
            {
                return ImageMarginGradientMiddle;
            }
        }

        #endregion

        #region Pressed MenuItem
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(0xFB, 0xFB, 0xF9);
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(0xF7, 0xF5, 0xEF);
            }
        }

        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.FromArgb(0xF9, 0xF8, 0xF4);
            }
        }
        #endregion

        #region Selected MenuItem
        public override Color MenuItemBorder
        {
            get
            {
                return ButtonSelectedBorder;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return ButtonSelectedGradientBegin;
            }
        }

        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return ButtonSelectedGradientBegin;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return ButtonSelectedGradientBegin;
            }
        }
        #endregion

        #region Selected Button
        public override Color ButtonSelectedGradientBegin
        {
            get
            {
                return Color.FromArgb(0xC1, 0xD2, 0xEE);
            }
        }

        public override Color ButtonSelectedGradientMiddle
        {
            get
            {
                return ButtonSelectedGradientBegin;
            }
        }

        public override Color ButtonSelectedGradientEnd
        {
            get
            {
                return ButtonSelectedGradientBegin;
            }
        }

        public override Color ButtonSelectedBorder
        {
            get
            {
                return Color.FromArgb(0x31, 0x6A, 0xC5);
            }
        }
        #endregion

        #region Pressed Button
        public override Color ButtonPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(0x98, 0xB5, 0xE2);
            }
        }

        public override Color ButtonPressedGradientMiddle
        {
            get
            {
                return ButtonPressedGradientBegin;
            }
        }

        public override Color ButtonPressedGradientEnd
        {
            get
            {
                return ButtonPressedGradientBegin;
            }
        }

        public override Color ButtonPressedBorder
        {
            get
            {
                return Color.FromArgb(0x4B, 0x4B, 0x6F);
            }
        }
        #endregion

        #region Checked Button
        public override Color ButtonCheckedGradientBegin
        {
            get
            {
                return Color.FromArgb(0xE1, 0xE6, 0xE8);
            }
        }

        public override Color ButtonCheckedGradientMiddle
        {
            get
            {
                return ButtonCheckedGradientBegin;
            }
        }

        public override Color ButtonCheckedGradientEnd
        {
            get
            {
                return ButtonCheckedGradientBegin;
            }
        }

        public override Color ButtonCheckedHighlightBorder
        {
            get
            {
                return Color.FromArgb(0x4B, 0x4B, 0x6F);
            }
        }

        public override Color ButtonCheckedHighlight
        {
            get
            {
                return Color.FromArgb(0x98, 0xB5, 0xE2);
            }
        }
        #endregion

        #region ToolStripPanel
        public override Color ToolStripPanelGradientBegin
        {
            get
            {
                return MenuStripGradientBegin;
            }
        }

        public override Color ToolStripPanelGradientEnd
        {
            get
            {
                return MenuStripGradientEnd;
            }
        }
        #endregion
    }
}
