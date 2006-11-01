using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimPe.Windows.Forms
{
    public partial class HelpForm : Form //Ambertation.Windows.Forms.LayeredForm
    {
        
        static Image top, bottom, center;
        static Rectangle headerrect;

        public HelpForm()
            : base()//Color.Transparent, new Size(781, 475))
        {            
            this.MinimumSize = new Size(781, 475);
            this.MaximumSize = new Size(781, 2048);


            InitializeComponent();
        }

        protected void OnCreateBitmap(Graphics g, Bitmap bmp)
        {
            
            if (top == null)
            {
               
                top = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.top.png"));
                center = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.center.png"));
                bottom = Image.FromStream(typeof(HelpForm).Assembly.GetManifestResourceStream("SimPe.Windows.Forms.img.bottom.png"));
                headerrect = new Rectangle(0, 0, top.Width, top.Height);
            }

            if (this.DesignMode) return;
            g.DrawImage(top, new Point(0,0));
            int y = top.Height;
            int my = bmp.Height - bottom.Height;
            while (y < my)
            {
                g.DrawImage(center, new Point(0, y));
                y += center.Height;
            }
            g.DrawImage(bottom, new Point(0, my));
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Ambertation.Windows.Forms.APIHelp.WM_NCHITTEST)
            {
                int lparam = m.LParam.ToInt32();
                Point screenPoint = new Point(lparam & 0xFFFF, lparam >> 16);
                Point pt = PointToClient(screenPoint);
                if (headerrect.Contains(pt))
                {
                    m.Result = new IntPtr(Ambertation.Windows.Forms.APIHelp.HTCAPTION);
                    return;
                }
            }
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            
        }
    }
}