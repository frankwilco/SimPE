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

namespace SimPe.Wizards
{
	/// <summary>
	/// This calass can be used to interface the StatusBar of the Main GUI, which will display 
	/// something like the WaitingScreen
	/// </summary>
	internal class WaitBarControl : IWaitingBarControl
	{
		Form1 f;
		public WaitBarControl(Form1 mf)
		{
			f = mf;
		}

		delegate void SetStuff(object o);
		delegate void ShowStuff(bool visible);

		#region Visible Control
		protected void ShowMain(bool visible)
		{
			f.pnP.Visible = visible;
		}
		

		protected void ShowProgress(bool visible)
		{
			f.pbP.Visible = visible;			
		}
		

		protected void ShowDescription(bool visible)
		{			
			f.lbPmsg.Visible = visible;
		}
		#endregion

		#region Setters
		protected void SetMessage(object text)
		{
			f.lbPmsg.Text = text.ToString();
			//Application.DoEvents();
		}
		

		protected void SetProgress(object val)
		{
			int i = (int)val;
			f.pbP.Value = i;			
		}



		protected void SetMaxProgress(object val)
		{
			int i = (int)val;
			f.pbP.Maximum = i;
		}

		
		#endregion

		public bool Running
		{
			get { return f.pnP.Visible; }
		}

		public string Message
		{
			get { return f.lbPmsg.Text; }
			set 
			{
				if (value!=f.lbPmsg.Text) 
				{	
					//f.lbOp.Invoke(new SetStuff(SetMessage), new object[] { " "+value });
					f.lbPmsg.Text = " "+value;
				}
			}
		}

		public Image Image
		{
			get { return null; }
			set 
			{				
			
			}
		}

		public int Progress
		{
			get { return f.pbP.Value; }
			set 
			{
				if (value!=f.pbP.Value) 
				{	
					SetProgress(value);
					//f.pb.Value = value;
					//f.pb.Invoke(new SetStuff(SetProgress), new object[] { value });
				}
			}
		}

		public int MaxProgress
		{
			get { return f.pbP.Maximum; }
			set 
			{
				if (value!=f.pbP.Maximum)
				{
					f.Invoke(new ShowStuff(ShowProgress), new object[] {true});
					//f.pb.Invoke(new SetStuff(SetMaxProgress), new object[] { value });
					f.pbP.Maximum = value;
				}
			}
		}

		protected void StartWait()
		{
			f.Invoke(new ShowStuff(ShowDescription), new object[] {true});			

			Message = SimPe.Localization.GetString("Please Wait");
			Image = null;
			f.pnP.Invoke(new ShowStuff(ShowMain), new object[] {true});						
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
				f.pnP.Invoke(new ShowStuff(ShowMain), new object[] {false});							
				f.Invoke(new ShowStuff(ShowProgress), new object[] {false});
				Application.DoEvents();
			} 
			catch {}
		}
	}
}
