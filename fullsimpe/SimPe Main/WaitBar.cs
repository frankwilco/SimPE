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

namespace SimPe
{
	/// <summary>
	/// This calass can be used to interface the StatusBar of the Main GUI, which will display 
	/// something like the WaitingScreen
	/// </summary>
	internal class WaitBarControl : IWaitingBarControl
	{
		MainForm f;
        WaitControl wc;
		public WaitBarControl(MainForm mf)
		{
			f = mf;
            wc = f.waitControl1;
			ShowProgress(false);
		}

		delegate void SetStuff(object o);
		delegate void ShowStuff(bool visible);

		#region Visible Control
		protected void ShowMain(bool visible)
		{
            wc.Waiting = visible;
            Application.DoEvents();
		}

		protected void ShowAnimation(bool visible)
		{
            wc.ShowAnimation = visible;
            Application.DoEvents();
		}

		protected void ShowProgress(bool visible)
		{
            wc.ShowProgress = visible;
            Application.DoEvents();
		}

		protected void ShowImage(bool visible)
		{			
			
		}

		protected void ShowDescription(bool visible)
		{
            wc.ShowText = visible;
            Application.DoEvents();
		}
		#endregion

		#region Setters
		protected void SetMessage(object text)
		{
            string t = "";
            if (text != null) t = text.ToString();
            wc.Message = t;		
		}

		protected void SetImage(object img)
		{
			
		}

		protected void SetProgress(object val)
		{
			int i = (int)val;
            wc.Value = i;
		}



		protected void SetMaxProgress(object val)
		{
			int i = (int)val;
            wc.Maximum = i;
		}

		protected void StartAnimation(bool b)
		{
			
		}
		#endregion

		public bool Running
		{
			get { return wc.Waiting; }
		}

		public string Message
		{
			get { return wc.Message; }
			set 
			{
				wc.BeginInvoke(new SetStuff(SetMessage), new object[] { " "+value });									
			}
		}

		public Image Image
		{
			get { return null; }
			set { }
		}

		public int Progress
		{
			get { return wc.Value; }
			set 
			{
				wc.BeginInvoke(new SetStuff(SetProgress), new object[] { value });				
			}
		}

		public int MaxProgress
		{
			get { return wc.Maximum; }
			set 
			{
				wc.Invoke(new ShowStuff(ShowProgress), new object[] {true});
				wc.Invoke(new SetStuff(SetMaxProgress), new object[] { value });									
			}
		}

		protected void StartWait()
		{
			//wc.Invoke(new ShowStuff(ShowImage), new object[] {false});
			wc.Invoke(new ShowStuff(ShowDescription), new object[] {true});
			wc.Invoke(new ShowStuff(ShowAnimation), new object[] {true});

			Message = SimPe.Localization.GetString("Please Wait");
			Image = null;
			wc.Invoke(new ShowStuff(ShowMain), new object[] {true});			
			//wc.Invoke(new ShowStuff(StartAnimation), new object[] {true});
			Application.DoEvents();
		}

		public void Wait()
		{			
			StartWait();			
		}

		public void Wait(int max)
		{			
			Progress=0;
			StartWait();
			MaxProgress = max;
		}

		public void Stop()
		{	
			try  
			{ 		
				wc.Invoke(new ShowStuff(ShowMain), new object[] {false});			
				//wc.Invoke(new ShowStuff(StartAnimation), new object[] {false});
				wc.Invoke(new ShowStuff(ShowProgress), new object[] {false});
				//Application.DoEvents();
			} 
			catch {}
		}
	}
}
