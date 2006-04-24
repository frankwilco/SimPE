using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SimPe
{
    class ToolStripProfessionalSquareRenderer : ToolStripProfessionalRenderer
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

    class ToolStripColorTable : ProfessionalColorTable
    {
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
    }
}
