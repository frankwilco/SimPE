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
			isz = new Size(120, eip.BestSize(48, 48).Height);
			eip.Dispose();
		}

		ImagePanel baseip;
		/// <summary>
		/// returns the <see cref="ImagePanel"/> for the Sim that was used to build th Graph
		/// </summary>
		public ImagePanel MainSimElement
		{
			get { return baseip;}
		}

		public void UpdateGraph(Wrapper.SDesc sdsc, Wrapper.ExtFamilyTies famt)
		{
			this.BeginUpdate();
			if (Parent!=null) 
			{
				this.Width = Parent.ClientRectangle.Width;
				this.Height = Parent.ClientRectangle.Height;
			}
			bool run = WaitingScreen.Running;
			WaitingScreen.Wait();
            try
            {
                this.SaveBounds = false;
                this.AutoSize = true;
                this.Clear();
                baseip = null;

                if (famt == null || sdsc == null)
                {
                    this.EndUpdate();
                    if (!run) WaitingScreen.Stop();
                    return;
                }

                FamilyTieSim tie = famt.FindTies(sdsc);
                Wrapper.SDesc[] parents = famt.ParentSims(sdsc);
                Wrapper.SDesc[] siblings = famt.SiblingSims(sdsc);
                Wrapper.SDesc[] childs = famt.ChildSims(sdsc);

                int maxct = parents.Length + siblings.Length + childs.Length;
                if (maxct < 4)
                {
                    this.LinearUpdateGraph(sdsc, famt);
                    if (!run) WaitingScreen.Stop();
                    return;
                }

                double r = GraphPanel.GetPinCircleRadius(this.ItemSize, this.ItemSize, maxct);
                Point center = new Point(
                    Math.Max(Width / 2, (int)r + 16 + ItemSize.Width / 2),
                    Math.Max(Height / 2, (int)r + ItemSize.Height / 2)
                    );

                baseip = CreateItem(sdsc, 0, 0);
                baseip.Location = GraphPanel.GetCenterLocationOnPinCircle(center, r, ItemSize);
                baseip.Parent = this;
                this.SelectedElement = baseip;
                baseip.PanelColor = Color.Black;
                baseip.ForeColor = Color.White;
                baseip.EndUpdate();

                int ct = 0;

                if (tie != null)
                {
                    foreach (SDesc s in childs)
                    {
                        ImagePanel ip = AddTieToGraph(s, 0, 0, tie.FindTie(s).Type, false);
                        ip.Location = GraphPanel.GetItemLocationOnPinCricle(center, r, ct++, maxct, ItemSize);
                        ip.EndUpdate();
                    }

                    foreach (SDesc s in siblings)
                    {
                        ImagePanel ip = AddTieToGraph(s, 0, 0, tie.FindTie(s).Type, false);
                        ip.Location = GraphPanel.GetItemLocationOnPinCricle(center, r, ct++, maxct, ItemSize);
                        ip.EndUpdate();
                    }

                    foreach (SDesc s in parents)
                    {
                        ImagePanel ip = AddTieToGraph(s, 0, 0, tie.FindTie(s).Type, false);
                        ip.Location = GraphPanel.GetItemLocationOnPinCricle(center, r, ct++, maxct, ItemSize);
                        ip.EndUpdate();
                    }
                }


                this.EndUpdate();
            }
            finally { if (!run) WaitingScreen.Stop(); }
		}

		public void LinearUpdateGraph(Wrapper.SDesc sdsc, Wrapper.ExtFamilyTies famt)
		{
			this.BeginUpdate();
			
			this.Clear();
			baseip = null;

			if (famt==null || sdsc==null) 
			{
				this.EndUpdate();				
				return;
			}
			
			FamilyTieSim tie = famt.FindTies(sdsc);
			

			Wrapper.SDesc[] parents = famt.ParentSims(sdsc);
			Wrapper.SDesc[] siblings = famt.SiblingSims(sdsc);
			Wrapper.SDesc[] childs = famt.ChildSims(sdsc);

			Size prect = new Size((parents.Length-1)*(ItemSize.Width+8), ItemSize.Height+60);
			Size srect = new Size(siblings.Length*(ItemSize.Width+24)+140, ItemSize.Height+60 + ((siblings.Length/2)-1) * 4 + 24);
			Size crect = new Size((childs.Length-1)*(ItemSize.Width+8), ItemSize.Height);
			int maxw = Math.Max(Math.Max(prect.Width, srect.Width), crect.Width);
			int top = prect.Height + (srect.Height-ItemSize.Height) /2;
			int left = (maxw - ItemSize.Width)/2+32;
			

			baseip = CreateItem(sdsc, left, top);
			baseip.Parent = this;
			this.SelectedElement = baseip;
			baseip.PanelColor = Color.Black;
			baseip.ForeColor = Color.White;
			baseip.EndUpdate();

			if (tie!=null) 
			{
				left = (maxw -prect.Width)/2+16;
				top = 0;
				foreach (SDesc s in parents) 
				{
					ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type, true);
					left += ip.Width+8;
				}

				left = (maxw - srect.Width)/2+16;
				int ct = 0;
				top =  prect.Height;
				foreach (SDesc s in siblings) 
				{
					ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type, true);
					left += ip.Width+24;
				
					ct++;
					if (ct==siblings.Length/2 || siblings.Length==1) 
					{
						left += 70;
						baseip.SetBounds(left, top+24, baseip.Width, baseip.Height);
						left += ip.Width+94;				
					}
					else if (ct>siblings.Length/2) top -= 4;
					else top += 4;
				}

				left = (maxw - crect.Width)/2+16;
				top =  prect.Height +srect.Height;
				foreach (SDesc s in childs) 
				{
					ImagePanel ip = AddTieToGraph(s, left, top, tie.FindTie(s).Type, true);
					left += ip.Width+8;
				}
			}

			
			this.EndUpdate();			
		}

		public ImagePanel AddTieToGraph(SDesc sdsc, int left, int top, Data.MetaData.FamilyTieTypes type) 
		{
			return AddTieToGraph(sdsc, left, top, type, true);
		}

		ImagePanel AddTieToGraph(SDesc sdsc, int left, int top, Data.MetaData.FamilyTieTypes type, bool isextern)
		{
			if (baseip==null) return null;

			ImagePanel ip = CreateItem(sdsc, left, top);
			
			string name = ((Data.LocalizedFamilyTieTypes)type).ToString();
			ip.ParentItems.Add(baseip, name);
			ip.Parent = this;
			if (isextern) ip.EndUpdate();

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
			eip.DoubleClick += new EventHandler(eip_DoubleClick);
			
			return eip;
		}

		#region Events
		public event SimPoolControl.SelectedSimHandler SelectedSimChanged;
		public event SimPoolControl.SelectedSimHandler ClickOverSim;
		public event SimPoolControl.SelectedSimHandler DoubleClickSim;
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

		private void eip_DoubleClick(object sender, EventArgs e)
		{
			if (DoubleClickSim!=null && (sender is ImagePanel)) 
			{
				DoubleClickSim(this, ((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Image, (Wrapper.SDesc)((Ambertation.Windows.Forms.Graph.ImagePanel)sender).Tag);
			}
		}

		/// <summary>
		/// Returns the <see cref="ImagePanel"/> that contains the passed Sim
		/// </summary>
		/// <param name="sdsc"></param>
		/// <returns></returns>
		public ImagePanel FindItem(Wrapper.SDesc sdsc)
		{
			foreach (GraphPanelElement gpe in this.Items)
			{
				if (gpe is ImagePanel)
				{
					if (sdsc.Equals(((ImagePanel)gpe).Tag)) return (ImagePanel)gpe;
				}
			}

			return null;
		}

		public static Data.MetaData.FamilyTieTypes GetAntiTie(Wrapper.SDesc sdsc, Data.MetaData.FamilyTieTypes t)
		{
			if (t == Data.MetaData.FamilyTieTypes.MyMotherIs || t == Data.MetaData.FamilyTieTypes.MyFatherIs) return Data.MetaData.FamilyTieTypes.MyChildIs;
			if (t == Data.MetaData.FamilyTieTypes.MyChildIs) 
			{
				if (sdsc==null)	return Data.MetaData.FamilyTieTypes.MyMotherIs;
				if (sdsc.CharacterDescription.Gender == SimPe.Data.MetaData.Gender.Female) return Data.MetaData.FamilyTieTypes.MyMotherIs;
				return Data.MetaData.FamilyTieTypes.MyFatherIs;
			}			

			return t;
		}
	}
}
