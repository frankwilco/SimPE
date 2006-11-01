using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace SimPe.Windows.Forms
{
    public class TransparentButton : UserControl
    {
        public TransparentButton()
            : base()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;             
        }

        Image img;
        public Image Image
        {
            get { return img; }
            set
            {
                img = value;
                this.Refresh();
            }
        }
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);
            if (img!=null) pevent.Graphics.DrawImage(img, 0, 0);
        }
    }
}
