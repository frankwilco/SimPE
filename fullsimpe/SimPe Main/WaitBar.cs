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
		public WaitBarControl(MainForm mf)
		{
			f = mf;
		}

		delegate void SetStuff(object o);
		delegate void ShowStuff(bool visible);

		#region Visible Control
		protected void ShowMain(bool visible)
		{
			f.sb.Visible = visible;
		}

		protected void ShowAnimation(bool visible)
		{
			f.xpLine1.Visible = visible;
			f.pbWait.Visible = visible;
		}

		protected void ShowProgress(bool visible)
		{
			f.lnProg.Visible = visible;
			f.pb.Visible = visible;
			f.lbPercent.Visible = visible;
		}

		protected void ShowImage(bool visible)
		{			
			f.pbimg.Visible = visible;
			f.lnProg2.Visible = f.lbOp.Visible || f.pbimg.Visible;
		}

		protected void ShowDescription(bool visible)
		{			
			f.lbOp.Visible = visible;
			f.lnProg2.Visible = f.lbOp.Visible || f.pbimg.Visible;
		}
		#endregion

		#region Setters
		protected void SetMessage(object text)
		{
			f.lbOp.Text = text.ToString();
			//Application.DoEvents();
		}

		protected void SetImage(object img)
		{
			if (img!=null) 
			{
				f.pbimg.Image = Ambertation.Drawing.GraphicRoutines.ScaleImage((Image)img, f.pbimg.Width, f.pbimg.Height, true);
				Application.DoEvents();
			}
			else 
				f.pbimg.Image = null;
		}

		protected void SetProgress(object val)
		{
			int i = (int)val;
			if (i>=f.pb.Minimum && i<=f.pb.Maximum) 
			{
				f.pb.Value = i;
				if (f.pb.Maximum!=0) 
				{
					int p = (f.pb.Value * 100) / f.pb.Maximum;
					f.lbPercent.Text = p.ToString()+"%";
				}
				//Application.DoEvents();
			}
		}



		protected void SetMaxProgress(object val)
		{
			int i = (int)val;
			f.pb.Maximum = i;
		}

		protected void StartAnimation(bool b)
		{
			if (b) f.pbWait.Start();
			else f.pbWait.Pause();
		}
		#endregion

		public bool Running
		{
			get { return f.sb.Visible; }
		}

		public string Message
		{
			get { return f.lbOp.Text; }
			set 
			{
				if (value!=f.lbOp.Text) 
				{	
					//f.lbOp.Invoke(new SetStuff(SetMessage), new object[] { " "+value });
					f.lbOp.Text = " "+value;
				}
			}
		}

		public Image Image
		{
			get { return f.pbimg.Image; }
			set 
			{
				if (value!=f.pbimg.Image) 
				{				
					if (value!=null && !f.pbimg.Visible) ShowImage(true);
					f.pbimg.Invoke(new SetStuff(SetImage), new object[] { value });
				}
			
			}
		}

		public int Progress
		{
			get { return f.pb.Value; }
			set 
			{
				if (value!=f.pb.Value) 
				{	
					SetProgress(value);
					//f.pb.Value = value;
					//f.pb.Invoke(new SetStuff(SetProgress), new object[] { value });
				}
			}
		}

		public int MaxProgress
		{
			get { return f.pb.Maximum; }
			set 
			{
				if (value!=f.pb.Maximum)
				{
					f.Invoke(new ShowStuff(ShowProgress), new object[] {true});
					//f.pb.Invoke(new SetStuff(SetMaxProgress), new object[] { value });
					f.pb.Maximum = value;
				}
			}
		}

		protected void StartWait()
		{
			f.Invoke(new ShowStuff(ShowImage), new object[] {false});
			f.Invoke(new ShowStuff(ShowDescription), new object[] {true});
			f.Invoke(new ShowStuff(ShowAnimation), new object[] {true});

			Message = SimPe.Localization.GetString("Please Wait");
			Image = null;
			f.sb.Invoke(new ShowStuff(ShowMain), new object[] {true});			
			f.pbWait.Invoke(new ShowStuff(StartAnimation), new object[] {true});
			Application.DoEvents();
		}

		public void Wait()
		{			
			StartWait();
			f.Invoke(new ShowStuff(ShowProgress), new object[] {false});
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
				f.sb.Invoke(new ShowStuff(ShowMain), new object[] {false});			
				f.pbWait.Invoke(new ShowStuff(StartAnimation), new object[] {false});
				Application.DoEvents();
			} 
			catch {}
		}
	}
}
