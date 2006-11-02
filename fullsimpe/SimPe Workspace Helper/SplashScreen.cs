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
        private Splash()
        {
            running = true;
            System.Threading.Thread t = new System.Threading.Thread(System.Threading.ThreadStart(StartThread));            
        }

        protected void StartThread()
        {
            frm = new SimPe.Windows.Forms.SplashForm();
        }

        public void SetMessage(string msg)
        {
            frm.Message = msg;
        }

        public void Start()
        {
            frm.StartSplash();
        }

        public void Stop()
        {
            frm.StopSplash();
        }

        public void ShutDown()
        {
            Stop();
            running = false;
        }
    }
}
