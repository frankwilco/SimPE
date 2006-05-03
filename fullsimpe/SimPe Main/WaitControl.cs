using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe
{   
    public partial class WaitControl : UserControl
    {      

        public WaitControl()
        {
            InitializeComponent();

            Message = "";
            Maximum = 0;
            Waiting = false;            
            ShowProgress = false;
            ShowAnimation = true;
            ShowText = true;

            System.Reflection.Assembly a = this.GetType().Assembly;
            for (int i = 1; i <= 8; i++)
            {
                System.IO.Stream s = a.GetManifestResourceStream("SimPe." + i.ToString() + ".png");
                if (s != null)
                    this.tbWait.Images.Add(Image.FromStream(s));
            }
        }

        string msg;
        public string Message
        {
            get { return msg; }
            set
            {
                msg = value;
                this.tbInfo.Text = " "+msg;
            }
        }

        int max;
        public int Maximum
        {
            get { return max; }
            set
            {
                max = value;
                this.pb.Value = this.pb.Minimum;
                this.pb.Maximum = value;
            }
        }

        int val;
        public int Value
        {
            get { return val; }
            set
            {
                val = Math.Min(pb.Maximum, value);
                this.pb.Value = val;

                tbPercent.Text = (((float)val / (float)pb.Maximum) * 100).ToString("N1") + "%";
                this.statusStrip1.Refresh();
            }
        }

        bool wait;        
        public bool Waiting
        {
            get { return wait; }
            set
            {
                wait = value;
                if (wait)
                {
                    this.Visible = true;
                    this.tbWait.Start();
                }
                else
                {
                    if (!this.DesignMode) this.Visible = false;
                    this.tbWait.Stop();
                }
            }
        }

        bool spb;
        public bool ShowProgress
        {
            get { return spb; }
            set
            {
                spb = value;
                pb.Visible = spb;
                tbPercent.Visible = spb;
                if (spb)
                    tbInfo.BorderSides = ToolStripStatusLabelBorderSides.Left;
                else
                    tbInfo.BorderSides = ToolStripStatusLabelBorderSides.None;
            }
        }

        bool sanim;
        public bool ShowAnimation
        {
            get { return sanim; }
            set
            {
                sanim = value;
                tbWait.Visible = sanim;
            }
        }

        bool stxt;
        public bool ShowText
        {
            get { return stxt; }
            set
            {
                stxt = value;
                this.tbInfo.Visible = stxt;
            }
        }
    }
}
