using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SimPe
{
    public partial class WaitControl : UserControl, IWaitingBarControl
    {
        const uint WM_USER_CHANGED_MESSAGE = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0001;
        const uint WM_USER_CHANGED_MAXPROGRESS = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0002;
        const uint WM_USER_CHANGED_PROGRESS = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0003;
        const uint WM_USER_SHOW_HIDE = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0004;
        const uint WM_USER_SHOW_HIDE_PROGRESS = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0005;
        const uint WM_USER_SHOW_HIDE_ANIMATION = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0006;
        const uint WM_USER_SHOW_HIDE_TEXT = Ambertation.Windows.Forms.APIHelp.WM_APP | 0x0007;
        IntPtr myhandle;

        public WaitControl()
        {
            msg = "";
            InitializeComponent();
            myhandle = Handle;

            Message = "";
            MaxProgress = 0;
            Waiting = false;            
            ShowProgress = false;
            ShowAnimation = true;
            ShowText = true;
            nowp = -1;

            System.Reflection.Assembly a = this.GetType().Assembly;
            for (int i = 1; i <= 8; i++)
            {
                System.IO.Stream s = a.GetManifestResourceStream("SimPe." + i.ToString() + ".png");
                if (s != null)
                    this.tbWait.Images.Add(Image.FromStream(s));
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.HWnd == Handle)
            {
                if (m.Msg == WM_USER_SHOW_HIDE)
                {
                    if (m.WParam.ToInt32() == 1) SetWaiting(true);
                    else SetWaiting(false);
                }
                else if (m.Msg == WM_USER_CHANGED_MESSAGE)
                {
                    this.tbInfo.Text = Message;
                }
                else if (m.Msg == WM_USER_CHANGED_MAXPROGRESS)
                {
                    this.pb.Value = this.pb.Minimum;
                    this.pb.Maximum = Math.Max(Math.Max(1, pb.Minimum), m.WParam.ToInt32());
                }
                else if (m.Msg == WM_USER_CHANGED_PROGRESS)
                {
                    SetProgress(m.WParam.ToInt32());
                }
                else if (m.Msg == WM_USER_SHOW_HIDE_PROGRESS)
                {
                    if (m.WParam.ToInt32() == 1) DoShowProgress(true);
                    else DoShowProgress(false);
                }
                else if (m.Msg == WM_USER_SHOW_HIDE_ANIMATION)
                {
                    if (m.WParam.ToInt32() == 1) DoShowAnimation(true);
                    else DoShowAnimation(false);
                }
                else if (m.Msg == WM_USER_SHOW_HIDE_TEXT)
                {
                    if (m.WParam.ToInt32() == 1) DoShowText(true);
                    else DoShowText(false);
                }
            }
            base.WndProc(ref m);
        }

        string msg;
        public string Message
        {
            get {
                lock (msg)
                {
                    return msg;
                }
            }
            set
            {
                lock (msg)
                {
                    msg = value;
                }
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_CHANGED_MESSAGE, 0, 0);
            }
        }

        int max;
        public int MaxProgress
        {
            get { lock (pb) { return max; } }
            set
            {
                lock (pb)
                {
                    max = value;
                }
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_CHANGED_MAXPROGRESS, value, 0);                
            }
        }

        int val;
        int nowp;
        public int Progress
        {
            get { return val; }
            set
            {
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_CHANGED_PROGRESS, value, 0);          
            }
        }

        private void SetProgress(int value)
        {
            val = Math.Min(pb.Maximum, value);
            this.pb.Value = val;

            //float perc = (((float)val / (float)pb.Maximum) * 100);

            int perc = (val * 100) / pb.Maximum;
            int diff = Math.Abs(nowp - perc);
            if (diff > 0)
            {
                tbPercent.Text = perc.ToString("N0") + "%";
            }

            if (diff >= 10)
            {            
    
                this.statusStrip1.Refresh();
                nowp = perc;
            }
            
        }

        bool wait;        
        public bool Waiting
        {
            get { return wait; }
            set
            {
                int val = 0;
                if (value) val = 1;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_SHOW_HIDE, val, 0);   
            }
        }

        private void SetWaiting(bool value)
        {
            wait = value;
            if (wait)
            {
                this.Visible = true;
                this.tbWait.Start();
            }
            else
            {
                if (!this.DesignMode && !Helper.WindowsRegistry.ShowWaitBarPermanent) this.Visible = false;
                this.Message = "";
                this.Progress = 0;
                this.ShowProgress = false;
                this.tbWait.Stop();
            }
        }

        bool spb;
        public bool ShowProgress
        {
            get { return spb; }
            set
            {
                int val = 0;
                if (value) val = 1;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_SHOW_HIDE_PROGRESS, val, 0); 
            }
        }

        void DoShowProgress(bool value)
        {
            spb = value;
            pb.Visible = spb;
            tbPercent.Visible = spb;
            if (spb)
                tbInfo.BorderSides = ToolStripStatusLabelBorderSides.Left;
            else
                tbInfo.BorderSides = ToolStripStatusLabelBorderSides.None;
        }

        bool sanim;
        public bool ShowAnimation
        {
            get { return sanim; }
            set
            {
                int val = 0;
                if (value) val = 1;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_SHOW_HIDE_ANIMATION, val, 0);

            }
        }

        private void DoShowAnimation(bool value)
        {
            sanim = value;
            tbWait.Visible = sanim;
        }

        bool stxt;
        public bool ShowText
        {
            get { return stxt; }
            set
            {
                int val = 0;
                if (value) val = 1;
                Ambertation.Windows.Forms.APIHelp.SendMessage(myhandle, WM_USER_SHOW_HIDE_TEXT, val, 0);
            }
        }

        private void DoShowText(bool value)
        {
            stxt = value;
            this.tbInfo.Visible = stxt;
        }

        #region IWaitingBarControl Member

        public bool Running
        {
            get { return Waiting; }
        }

        public Image Image
        {
            get
            {
                return null;
            }
            set
            {
                
            }
        }       

        public void Wait()
        {
            Message = SimPe.Localization.GetString("Please Wait");
            Image = null;
            Waiting = true;
        }

        public void Wait(int max)
        {
            ShowProgress = true;
            Message = SimPe.Localization.GetString("Please Wait");
            Image = null;
            MaxProgress = max;
            Waiting = true;
        }

        public void Stop()
        {
            ShowProgress = false;
            Waiting = false;
        }

        #endregion
    }
}
