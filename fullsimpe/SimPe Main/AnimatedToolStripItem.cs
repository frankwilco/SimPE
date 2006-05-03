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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using Ambertation.Collections;
using System.Threading;

namespace Ambertation.Windows.Forms
{
    class ThreadTimer : Ambertation.Threading.StoppableThread
    {
        Control ctrl;
        int timeout;
        RefreshHandler rh;

        public Control InvokeControl
        {
            get { return ctrl; }
            set { ctrl = value; }
        }

        public int Interval
        {
            get { return timeout; }
            set { timeout = value; }
        }

        public ThreadTimer()
            : this(null)
        {
        }
        
        public ThreadTimer(Control ctrl)
        {
            timeout = 40;
            rh = new RefreshHandler(InvokeRefresh);
            this.ctrl = ctrl;
            running = false;
        }

        public event System.EventHandler Elapsed;

        delegate void RefreshHandler();
        void InvokeRefresh()
        {
            if (Elapsed != null) Elapsed(this, new EventArgs());
        }

        void DoInvokeRefresh()
        {
            if (ctrl!=null) 
                if (ctrl.InvokeRequired)
                {
                    ctrl.Invoke(rh);
                    return;
                }

            InvokeRefresh();
        }

        bool running;
        protected override void StartThread()
        {
            DoInvokeRefresh();

            while (running)
            {
                System.Threading.Thread.CurrentThread.Join(timeout);
                DoInvokeRefresh();
                System.Windows.Forms.Application.DoEvents();
            }

            DoInvokeRefresh();
        }

        public bool Enabled
        {
            get { return running; }
            set
            {
                if (value) Start();
                else Stop();
            }
        }

        public void Start()
        {
            if (running) return;

            running = true;
            this.ExecuteThread(System.Threading.ThreadPriority.Normal, "ThreadTimer");
        }

        public void Stop()
        {
            running = false;
        }
    }

    [ToolboxBitmapAttribute(typeof(ImageList))]
    public class AnimatedToolstripItem : System.Windows.Forms.ToolStripStatusLabel
    {

        System.Timers.Timer timer;
        System.Timers.ElapsedEventHandler ih;
        bool init;
        public AnimatedToolstripItem()
            : base()
        {
            init = true;
            index = 0;
            timer = new System.Timers.Timer(40);
            timer.Enabled = false;
            TimeOut = 1000 / 15;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            ih = new System.Timers.ElapsedEventHandler(InvokeTimerElapsed);

            doevents = false;


            list = new Images();
            init = false;
        }

        void InvokeTimerElapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (index < 0) index = 0;
            else if (index >= list.Count - 1) index = 0;
            else index++;

            this.Image = this.list[index];
            this.Parent.Refresh();
            if (doevents) Application.DoEvents();
            
        }
       
        
        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (init) return;
            lock (timer)
            {
                if (this.Parent != null)
                {
                    if (this.Parent.Visible)
                    {
                        this.Parent.Invoke(ih, new object[] { sender, e });
                        //InvokeTimerElapsed(sender, e);
                    }
                }
                if (doevents) Application.DoEvents();
            }
        }


        #region public Properties

        bool doevents;
        public bool DoEvents
        {
            get { return doevents; }
            set { doevents = value; }
        }

        int timeout;
        public int TimeOut
        {
            get { return timeout; }
            set
            {
                timeout = value;
                timer.Interval = value;
            }
        }

        int index;
        public int CurrentIndex
        {
            get { return index; }
            set
            {
                if (index != value)
                {
                    index = Math.Min(list.Count - 1, value);
                    index = Math.Max(0, value);
                    this.Invalidate();
                }
            }
        }

        Images list;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Images Images
        {
            get { return list; }
            set { list = value; }
        }
        #endregion

        [Browsable(false)]
        public bool Running
        {
            get { return timer.Enabled; }
        }

        public void Start()
        {
            timer.Enabled = true;
            //timer.InvokeControl = this.Parent;
        }

        public void Pause()
        {
            timer.Enabled = false;
        }

        public void Stop()
        {
            Pause();
            index = 0;
        }
    }
}
