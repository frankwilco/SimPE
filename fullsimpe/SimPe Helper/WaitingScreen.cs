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

namespace SimPe
{
	/// <summary>
	/// Use this class to show a Waiting Screen.
	/// </summary>
	public class WaitingScreen
	{
		static System.Threading.Thread thread;
		static WaitingForm wf;
		static bool waitend;
		static bool startup;
		
		static bool run;
		/// <summary>
		/// True if the WaitingScreen is available at the Moment
		/// </summary>
		public static bool Running
		{
			get {return run;}
		}

		/// <summary>
		/// Show the Waitingscreen
		/// </summary>
		public static void Wait()
		{
			Monitor.Enter(run);
			if ((waitend) || (startup))
			{
				Monitor.Exit(run);
				return;
			}

			Monitor.Enter(waitend);			
			if ((!run) && (Helper.WindowsRegistry.WaitingScreen)) 
			{	
				if (thread!=null) 
				{
					try 
					{
						thread.Abort();
					}
					catch {}
					finally { thread=null; }
				}
				thread = new System.Threading.Thread(new System.Threading.ThreadStart(WaitingScreen.Start));
				thread.Priority = System.Threading.ThreadPriority.Normal;

				startup = true;
				thread.Start();	

				DateTime start = DateTime.Now;
				TimeSpan waittime = new TimeSpan(0,0,0,60,0);
				while (startup) {
					if (DateTime.Now.Subtract(start) > waittime) break;
				}										
			} 

			Monitor.Exit(run);
			Monitor.Exit(waitend);
		}

		
		/// <summary>
		/// Internal Method to start the Thread
		/// </summary>
		protected static void Start()
		{		
			Monitor.Enter(startup);
			run = true;
			Monitor.Enter(run);
			if (wf==null) wf = new WaitingForm();		
			wf.TopLevel = true;
			wf.timer1.Enabled = true;
			
			try 
			{
				if (!wf.Visible) wf.Show();
			} 
			catch (Exception ex)
			{
				if (Helper.DebugMode) Helper.ExceptionMessage("", ex);
			}
			
			Monitor.Exit(run);

			startup = false;
			Monitor.Exit(startup);
			StartUpdates();
			
			Monitor.Enter(waitend);
			try 
			{
				wf.timer1.Enabled = false;
				thread.Priority = System.Threading.ThreadPriority.Highest;
				wf.Focus();
				wf.Close();
				wf = null;
			} 
			catch (Exception ex)
			{
				if (Helper.DebugMode) Helper.ExceptionMessage("", ex);
			}
			finally 
			{
				wf = null;
				waitend = false;				
			}
			Monitor.Exit(waitend);
		}

		/// <summary>
		/// Updates to indicate activity are triggered by an additional Thread started where
		/// </summary>
		protected static void StartUpdates()
		{
			while (run) {				
				if (run) 
				{
					Monitor.Enter(waitend);
					Monitor.Enter(run);		
					if (wf!=null) 
					{
						wf.timer1_Tick(null, null);
						wf.Update();	
					}
					Monitor.Exit(run);
					Monitor.Exit(waitend);

					if (thread!=null) thread.Join(new TimeSpan(0, 0, 0, 0, 100));										
				}
			}
		}

		/// <summary>
		/// Show another Image
		/// </summary>
		/// <param name="image">the image to show</param>
		public static void UpdateImage(System.Drawing.Image image)
		{
			Monitor.Enter(run);
			Monitor.Enter(waitend);
			Monitor.Enter(startup);
			if ((run) && (wf!=null))
			{				
				wf.ChangeImage(image);
				wf.Update();
			}
			Monitor.Exit(startup);
			Monitor.Exit(waitend);
			Monitor.Exit(run);
		}

		/// <summary>
		/// Show another Image
		/// </summary>
		/// <param name="image">the image to show</param>
		public static void Update(System.Drawing.Image image, string message)
		{
			Monitor.Enter(run);
			Monitor.Enter(waitend);
			Monitor.Enter(startup);
			if ((run) && (wf!=null))
			{				
				if (message!=null) wf.ChangeMessage(message);
				wf.ChangeImage(image);
				wf.Update();
			}
			Monitor.Exit(startup);
			Monitor.Exit(waitend);
			Monitor.Exit(run);
		}

		/// <summary>
		/// Show a short Message about the current State
		/// </summary>
		/// <param name="msg">The Message you want to show</param>
		public static void UpdateMessage(string msg)
		{
			Monitor.Enter(run);
			Monitor.Enter(waitend);
			Monitor.Enter(startup);
			if ((run) && (wf!=null))
			{				
				wf.ChangeMessage(msg);
				wf.Update();
			}
			Monitor.Exit(startup);
			Monitor.Exit(waitend);
			Monitor.Exit(run);
		}

		/// <summary>
		/// Stop the Waiting Thread
		/// </summary>
		public static void Stop()
		{
			//if (!run) return;	
			Monitor.Enter(startup);
			Monitor.Enter(run);	
			Monitor.Exit(startup);
			if (run) waitend = true;
			run = false;
			if (wf!=null)
			{
				wf.timer1.Enabled = false;
				

				DateTime start = DateTime.Now;
				TimeSpan waittime = new TimeSpan(0,0,0,10,0);
				TimeSpan waittime2 = new TimeSpan(0,0,0,59,0);
				while (waitend) {
					if ((run) && (DateTime.Now.Subtract(start) > waittime)) 
					{
						run=false;
						Monitor.Exit(run);
						run=false;
						Monitor.Enter(run);
						run=false;
					}
					if (DateTime.Now.Subtract(start) > waittime2) 
					{
						break;
					}
				}
			}
			
			Monitor.Exit(run);
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
