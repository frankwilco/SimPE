using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using Ambertation.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public partial class HelpForm : TransparentForm //Ambertation.Windows.Forms.LayeredForm
    {
        
        static Image top, bottom, center;
        Rectangle headerrect;

        public HelpForm()
            : base()//Color.Transparent, new Size(781, 475))
        {            
            this.MinimumSize = new Size(781, 475);
            this.MaximumSize = new Size(781, 2048);
            
            InitializeComponent();            
        }

        protected override void OnCreateBitmap(Graphics g, Bitmap b)
        {
            //base.OnCreateBitmap(g, b);

            if (top == null)
            {

                top = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.top.png"));
                center = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.center.png"));
                bottom = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.bottom.png"));
                headerrect = new Rectangle(0, 0, top.Width, top.Height);
            }

            g.DrawImage(top, new Point(0, 0));
            int y = top.Height;
            int my = b.Height - bottom.Height;
            while (y < my)
            {
                g.DrawImage(center, new Point(0, y));
                y += center.Height;
            }
            g.DrawImage(bottom, new Point(0, my));

            g.Dispose();
        }

        protected override Rectangle HeaderRect
        {
            get
            {
                return headerrect;
            }
        }
    }
}