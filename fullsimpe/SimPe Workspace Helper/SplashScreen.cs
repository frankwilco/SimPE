using System;
using System.Collections.Generic;
using System.Text;

namespace SimPe
{
    public class Splash
    {
        static Splash scr;
        public static Splash Screen
        {
            get
            {
                if (scr == null) scr = new Splash();
                return scr;
            }
        }

        SimPe.Windows.Forms.SplashForm frm;
        bool running;
        bool show;
        private Splash()
        {
            mmsg = "";
            running = true;
            show = false;

            if (Helper.WindowsRegistry.ShowStartupSplash)
            {
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(StartThread));
                t.Start();
            }
        }

        protected void StartThread()
        {
            frm = new SimPe.Windows.Forms.SplashForm();
            if (show) Start();
            SetMessage(mmsg);
        }

        string mmsg;
        public void SetMessage(string msg)
        {
            mmsg = msg;
            if (frm!=null)frm.Message = msg;
        }

        public void Start()
        {
            show = true;
            if (frm!=null) frm.StartSplash();
        }

        public void Stop()
        {
            show = false;
            if (frm!=null) frm.StopSplash();
        }

        public void ShutDown()
        {
            Stop();
            running = false;
        }
    }
}
