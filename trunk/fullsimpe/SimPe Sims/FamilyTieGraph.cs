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
using Ambertation.Collections;
using Ambertation.Windows.Forms;
using Ambertation.Windows.Forms.Graph;
using Ambertation.Drawing;
using System.Collections;
using System.Drawing;
using SimPe.PackedFiles.Wrapper.Supporting;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// This Can be used whenever you need to show the FamilyTie Graoh of a Sim
	/// </summary>
	public class FamilyTieGraph : GraphPanel
	{
		public FamilyTieGraph()
		{
			this.AutoSize = true;
			this.SaveBounds = true;
			this.LockItems = false;

			ImagePanel eip = new ImagePanel();
			isz = new Size(150, eip.BestSize(48, 48).Height);
			eip.Dispose();
		}

		ImagePanel baseip;

		public void UpdateGraph(Wrapper.SDesc sdsc, Wrapper.ExtFamilyTies famt)
		{
			this.BeginUpdate();
			bool run = WaitingScreen.Running;
			WaitingScreen.Wait();
			this.Clear();
			baseip = null;

			if (famt==null || sdsc==null) 
			{
				this.EndUpdate();
				if (!run) WaitingScreen.Stop();
				return;
			}
			
			FamilyTieSim tie = famt.FindTies(sdsc);
			Wrapper.SDesc[] parents = famt.ParentSims(sdsc);
			Wrapper.SDesc[] siblings = famt.SiblingSims(sdsc);
			Wrapper.SDesc[] childs = famt.ChildSims(sdsc);

			Size prect = new Size(parents.Length*(ItemSize.Width+8), ItemSize.Height+60);
			Size srect = new Size((1+siblings.Length)*(ItemSize.Width+100), ItemSize.Height+60 + ((siblings.Length/2)-1) * 4 + 24);
			Size crect = new Size(childs.Length*(ItemSize.Width+8), ItemSize.Height);
			int maxw = Math.Max(Math.Max(prect.Width, srect.Width), crect.Width);
			int top = prect.Height + (srect.Height-ItemSize.Height) /2;
			int left = (maxw - ItemSize.Width)/2+32;
			

			baseip = CreateItem(sdsc, left, top);
			baseip.Parent = this;
			this.SelectedElement = baseip;
			baseip.EndUpdate();

			left = (maxw -prect.Width)/2+16;
			top = 0;
			foreach (SDesc s in parents) 
			{
				ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type);/*CreateItem(s, left, top);
				
				string name = ((Data.LocalizedFamilyTieTypes)tie.FindTie(s).Type).ToString();
				ip.ParentItems.Add(baseip, name);
				ip.Parent = this;
				ip.EndUpdate();*/
				left += ip.Width+8;
			}

			left = (maxw - srect.Width)/2+16;
			int ct = 0;
			top =  prect.Height;
			foreach (SDesc s in siblings) 
			{
				ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type);/*CreateItem(s, left, top);
				
				string name = ((Data.LocalizedFamilyTieTypes)tie.FindTie(s).Type).ToString();
				ip.ParentItems.Add(baseip, name);
				ip.Parent = this;
				
				ip.EndUpdate();*/
				left += ip.Width+100;
				
				ct++;
				if (ct==siblings.Length/2) 
				{
					baseip.SetBounds(left, top+24, baseip.Width, baseip.Height);
					left += ip.Width+100;				
				}
				else if (ct>siblings.Length/2) top -= 4;
				else top += 4;
			}

			left = (maxw - crect.Width)/2+16;
			top =  prect.Height +srect.Height;
			foreach (SDesc s in childs) 
			{
				ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type);/* CreateItem(s, left, top);
				
				string name = ((Data.LocalizedFamilyTieTypes)tie.FindTie(s).Type).ToString();
				ip.ParentItems.Add(baseip, name);
				ip.Parent = this;
				ip.EndUpdate();*/
				left += ip.Width+8;
			}

			
			this.EndUpdate();
			if (!run) WaitingScreen.Stop();
		}

		public ImagePanel AddTieToGraph(SDesc sdsc, int left, int top, Data.MetaData.FamilyTieTypes type)
		{
			if (baseip==null) return null;

			ImagePanel ip = CreateItem(sdsc, left, top);
			
			string name = ((Data.LocalizedFamilyTieTypes)type).ToString();
			ip.ParentItems.Add(baseip, name);
			ip.Parent = this;
			ip.EndUpdate();

			return ip;
		}

		Size isz;
		protected Size ItemSize 
		{
			get {return isz;}
		}

		protected ImagePanel CreateItem(Wrapper.SDesc sdesc, int left, int top)
		{
			ImagePanel eip = new ImagePanel();
			eip.BeginUpdate();
			eip.SetBounds(left, top, this.ItemSize.Width, this.ItemSize.Height);
			SimPoolControl.CreateItem(eip, sdesc);

			eip.GotFocus += new EventHandler(eip_GotFocus);
			eip.LostFocus += new EventHandler(eip_LostFocus);
			eip.MouseDown += new System.Windows.Forms.MouseEventHandler(eip_MouseDown);
			
			return eip;
		}

		#region Events
		public event SimPoolControl.SelectedSimHandler SelectedSimChanged;
		public event SimPoolControl.SelectedSimHandler ClickOverSim;
		#endregion

		private void eip_GotFocus(object sender, EventArgs e)
		{
			if (SelectedSimChanged!=null && (sender is ImagePanel)) 
			{
				SelectedSimChanged(this, ((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Image, (Wrapper.SDesc)((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Tag);
			}			
		}

		private void eip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (ClickOverSim!=null && (sender is ImagePanel)) 
			{
				ClickOverSim(this, ((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Image, (Wrapper.SDesc)((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Tag);
			}
		}

		private void eip_LostFocus(object sender, EventArgs e)
		{
			if (SelectedSimChanged!=null && (sender is ImagePanel)) 
			{
				SelectedSimChanged(this, ((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Image, null);
			}
		}
	}
}
