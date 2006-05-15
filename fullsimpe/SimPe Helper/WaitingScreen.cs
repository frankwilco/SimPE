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
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace SimPe
{
	/// <summary>
	/// Determins the Kind of Update the USer has Requested
	/// </summary>
	enum WSUpdate : byte 
	{
		Nothing = 0x0,
		Image = 0x01,
		Message = 0x02,
		Both = 0x03
	}

	/// <summary>
	/// Determins the current State of the WaitingScreen
	/// </summary>
	public enum WSState : byte
	{
		Inactive = 0x00,
		Initializing = 0x01,
		Running = 0x02,
		Updating = 0x03,
		WaitFinalizing = 0x04,
		Finalized = 0x05
	}

	/// <summary>
	/// Describes one Event that the user had requested
	/// </summary>
	class WSEvent 
	{
		internal WSEvent()
		{
			kind = WSUpdate.Nothing;
		}

		WSUpdate kind;
		internal WSUpdate Kind 
		{
			get { return kind; }
			set {kind = value; }
		}

		string msg;
		internal string Message
		{
			get { return msg; }
			set {msg = value; }
		}

		Image img;
		internal Image Image
		{
			get { return img; }
			set {img = value; }
		}
	}
	/// <summary>
	/// Use this class to show a Waiting Screen.
	/// </summary>
	public class WaitingScreen
	{
		static System.Threading.Thread thread = null;
		static WSState state = WSState.Inactive;
		static WSEvent nextevent = new WSEvent();
		static TimeSpan ts = new TimeSpan(0, 0, 0, 0, 100);

        static System.Threading.ManualResetEvent wait = new ManualResetEvent(true);
        static System.Threading.ManualResetEvent ended = new ManualResetEvent(true);        
        static  System.Threading.ManualResetEvent stop = new ManualResetEvent(false);        

		/// <summary>
		/// True if the WaitingScreen is available at the Moment
		/// </summary>
		public static bool Running
		{
			get {return ((state == WSState.Running) || (state == WSState.Updating) || (state == WSState.Initializing));}
		}

		/// <summary>
		/// Returns the current State of the WaitingScreen
		/// </summary>
		public static WSState State 
		{
			get { return state; }
		}

		/// <summary>
		/// Show the Waitingscreen
		/// </summary>
        public static void Wait()
        {
            if (!Helper.WindowsRegistry.WaitingScreen) return;
            Console.WriteLine("starting...");
            lock (wait)
            {
                if (!Running)
                {
                    state = WSState.Initializing;

                    thread = new Thread(new ThreadStart(Start));
                    thread.IsBackground = true;
                    thread.SetApartmentState(ApartmentState.STA);
                    thread.Start();
                    Console.WriteLine("Started thread");
                }
                
            }
        }
        

		/// <summary>
		/// Stop the WaitingScreen ad focus the given Form
		/// </summary>
		/// <param name="form">The form you want to focus</param>
		public static void Stop(Form form) 
		{
			form.Activate();	
			Stop();
		}

		/// <summary>
		/// Stop the Waiting Thread
		/// </summary>
        public static void Stop()
        {
            Console.WriteLine("stopping...");
            lock (wait)
            {
                stop.Set();
                ended.WaitOne(5000, false);
                ended.Set();
                Application.DoEvents();



                thread = null;
                state = WSState.Inactive;
                Console.WriteLine("Stopped thread");                             
            }
        }
		
		/// <summary>
		/// Internal Method to start the Thread
		/// </summary>
        internal static void Start()
        {
            if (stop.WaitOne(1, false))
            {
                ended.Set();
                return;
            }

            stop.Reset();
            WaitingForm wf = new WaitingForm();
            lock (wait)
            {
                Console.WriteLine("In Thread");
                ended.Reset();

                Console.WriteLine("Init...");
                state = WSState.Running;                
                
                wf.timer1.Enabled = true;
                lock (nextevent)
                {
                    nextevent.Message = "";
                    nextevent.Image = wf.pbsimpe.Image;
                    nextevent.Kind = WSUpdate.Both;
                }

                wf.Visible = true;
                wf.Update();
                System.Windows.Forms.Application.DoEvents();
            }
            ended.Set();
            StartUpdates(wf);

            state = WSState.Finalized;
            if (wf != null) wf.Visible = false;
            wf = null;

            ended.Set();
        }

		/// <summary>
		/// Updates to indicate activity are triggered by an additional Thread started where
		/// </summary>
        internal static void StartUpdates(WaitingForm wf)
        {
            Console.WriteLine("Launched");
            while (true)
            {
                ended.Reset();
                
                if (state != WSState.Running) return;                

                state = WSState.Updating;


                lock (nextevent)
                {
                    if (((byte)nextevent.Kind & (byte)WSUpdate.Image) != 0) wf.ChangeImage(nextevent.Image);
                    if (((byte)nextevent.Kind & (byte)WSUpdate.Message) != 0) wf.ChangeMessage(nextevent.Message);
                    nextevent.Kind = WSUpdate.Nothing;
                }

                wf.Update();
                System.Windows.Forms.Application.DoEvents();


                if (state == WSState.Updating) state = WSState.Running;
                else return;

                if (stop.WaitOne(ts, false))
                {
                    Console.WriteLine("Stopped");
                    return;
                }
            }
        }

		
		/// <summary>
		/// Show another Image
		/// </summary>
		/// <param name="image">the image to show</param>
		public static void UpdateImage(System.Drawing.Image image)
		{
			nextevent.Image = image;
			nextevent.Kind = (WSUpdate)((byte)nextevent.Kind | (byte)WSUpdate.Image);
		}

		/// <summary>
		/// Show another Image
		/// </summary>
		/// <param name="image">the image to show</param>
		public static void Update(System.Drawing.Image image, string message)
		{
			nextevent.Message = message;
			nextevent.Image = image;
			nextevent.Kind = WSUpdate.Both;
		}

		/// <summary>
		/// Show a short Message about the current State
		/// </summary>
		/// <param name="msg">The Message you want to show</param>
		public static void UpdateMessage(string msg)
		{
			nextevent.Message = msg;
			nextevent.Kind = (WSUpdate)((byte)nextevent.Kind | (byte)WSUpdate.Message);
		}

		

		/// <summary>
		/// Returns the Size of the Dispalyed Image
		/// </summary>
		public static System.Drawing.Size ImageSize
		{
			get { return new System.Drawing.Size(64, 64); }
		}
	}
}