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
            
            
            InitializeComponent();

            this.MinimumSize = new Size(781, 475);
            this.MaximumSize = new Size(781, 2048);
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