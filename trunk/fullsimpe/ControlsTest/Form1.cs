using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlsTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int count = 50;
            DateTime start = DateTime.Now;
            for (int i = 0; i < count; i++)
            {
                Ambertation.Windows.Forms.ExtProgressBar epb = new Ambertation.Windows.Forms.ExtProgressBar();                
                epb.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
                epb.TokenCount = 10;
                epb.Parent = this;
                epb.Visible = true;
                epb.Width = 200;
                epb.Height = 50;
            }

            TimeSpan run = DateTime.Now - start;
            Console.WriteLine("Init Time for "+count+" items: " + run);
        }
    }
}