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
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace SimPe
{
	/// <summary>
	/// This calass can be used to interface the StatusBar of the Main GUI, which will display 
	/// something like the WaitingScreen
	/// </summary>
	public class Wait
	{
		static IWaitingBarControl bar;
        static Stack<SessionData> mystack = new Stack<SessionData>();		
		public const int TIMEOUT = 10000; 


		public static IWaitingBarControl Bar
		{
			set 
			{ 
				bar = value; 				
			}
		}

		public static bool Running
		{
			get 
			{ 
				if (bar!=null) return bar.Running;
				return false;
			}
		}

	
        public static string Message
		{
			get 
			{
                if (bar != null) return bar.Message;
                return "";				
			} 
			set 
			{
				if (bar!=null) bar.Message = value;								
			}
		}

		public static Image Image
		{
			get 
			{ 
				if (bar!=null) return bar.Image; 
				return null;
			} 
			set 
			{
				//lock (sync) 
				{
					//if (bar!=null) bar.Image = value;
				}
			}
		}

		
        public static int Progress
		{
			get 
			{
                if (bar != null) return bar.Progress;
                return 0;
				/*if (bar!=null) return bar.Progress; 
				return IntMaxProgress;*/
				
			} 
			set 
			{
                if (bar!=null) bar.Progress = value;								
			}
		}

		public static int MaxProgress
		{
			get 
			{
                if (bar != null) return bar.MaxProgress;
                return 1;
			} 	
			set 
			{
                if (bar!=null) bar.MaxProgress = value;		
			}
		}

        

        public static void SubStart()
        {
            if (bar != null)
            {
                CommonStart();
                if (!bar.Running) bar.Wait();
            }
        }

        public static void SubStart(int max)
        {
            Start(max);
        }

        public static void SubStop()
        {
            Stop();
        }

		
		public static void Start()
		{
			if (bar!=null) 
			{
                CommonStart();
                bar.ShowProgress = false;
                if (!bar.Running) bar.Wait();
				
			}
			
		}		

		public static void Start(int max)
		{
			
			if (bar!=null) 
			{
                CommonStart();
                if (!bar.Running) bar.Wait(max);
                else bar.MaxProgress = max;
			}
			
		}
        public static void Stop()
        {
            Stop(false);
        }

		public static void Stop(bool force)
		{
            SessionData sd;
            lock (mystack)
            {
                if (mystack.Count == 0)
                {
                    if (bar != null) bar.Stop();
                    return;
                }



                sd = mystack.Pop();


                if (mystack.Count == 0)
                    if (bar != null) bar.Stop();

                
            }

            if (force)
                if (bar != null) bar.Stop();
			ReloadSession(sd);

            if (bar != null)
            {
                if (!bar.Running) bar.ShowProgress = false;
            }
		}

        static void CommonStart()
        {
            //bar.Message = SimPe.Localization.GetString("Please wait");
            lock (mystack) { mystack.Push(BuildSessionData()); }
        }

        class SessionData
        {
            public string Message;
            public int Progress;
            public int MaxProgress;
        }
		

        private static SessionData BuildSessionData()
        {
            SessionData sd = new SessionData();
            sd.Message = Message;
            sd.Progress = Progress;
            sd.MaxProgress = MaxProgress;
            return sd;
        }
		
        private static void ReloadSession(SessionData sd)
        {
            try
            {
                if (sd != null)
                {
                    Message = sd.Message;
                    MaxProgress = sd.MaxProgress;
                    Progress = sd.Progress;
                }
            }
            catch (Exception ex)
            {
                if (Helper.DebugMode) Console.WriteLine(ex);
            }
        }
	}
}
