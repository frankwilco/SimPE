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

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// You can use this Control whenever you need to display a SimPool
	/// </summary>
	public class SimPoolControl : GraphPanel
	{
		public SimPoolControl()
		{
			this.AutoSize = true;
			this.SaveBounds = false;
			this.LockItems = true;
		}

		SimPe.Interfaces.Files.IPackageFile pkg;
		public SimPe.Interfaces.Files.IPackageFile Package
		{
			get { return pkg;}
			set 
			{
				if (pkg!=value)
				{
					if (value==null) pkg=value;
					else if (Helper.IsNeighborhoodFile(value.FileName)) pkg=value;
					else return;

					UpdateContent();
				}
			}
		}

		protected void UpdateContent()
		{
			this.BeginUpdate();
			bool run = WaitingScreen.Running;
			WaitingScreen.Wait();
			this.Clear();

			if (pkg==null) 
			{
				this.EndUpdate();
				if (!run) WaitingScreen.Stop();
				return;
			}
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			int left = 12;
			int top = 12;
			bool auto = this.AutoSize;			
			this.AutoSize = false;
			int ct=0;

			System.Collections.SortedList map = new System.Collections.SortedList();
			
			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{								
				ExtendedImagePanel eip = this.CreateItem(pfd, left, top);				
				string name = eip.Text;
				if (map.ContainsKey(name)) name += " ("+pfd.Instance.ToString()+")";
				map[name] = eip;
				
				if (ct==1) WaitingScreen.Wait();													
				WaitingScreen.UpdateMessage((ct++).ToString() + "/" + pfds.Length.ToString());
			}			

			WaitingScreen.UpdateMessage("Update Canvas");
			ct = 0;
			foreach (string k in map.Keys) 
			{

				if (ct++==map.Keys.Count-1) this.AutoSize = auto;	
				ExtendedImagePanel eip = (ExtendedImagePanel)map[k];				
				eip.SetBounds(eip.Left, top, eip.Width, eip.Height);						
				eip.EndUpdate();
				eip.Parent = this;
				if (ct==1) this.SelectedElement = eip;		
				top += eip.Height +4;
			}
			
			this.EndUpdate();
			if (!run) WaitingScreen.Stop();
		}

		internal static void CreateItem(ImagePanel eip, SDesc sdesc)
		{
			eip.ImagePanelColor = System.Drawing.Color.Black;
			eip.Fade = 0.5f;
			eip.FadeColor = System.Drawing.Color.Transparent;
			
			eip.Tag = sdesc;			
			try 
			{				
				eip.Text = sdesc.SimName+" "+sdesc.SimFamilyName;
				
				System.Drawing.Image img = sdesc.Image;
				if (img!=null)
				{
					if (Helper.WindowsRegistry.GraphQuality) img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new System.Drawing.Point(0,0), System.Drawing.Color.Magenta);
					eip.Image = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, 48, 48, Helper.WindowsRegistry.GraphQuality);
				}

				if (sdesc.Unlinked!=0) 
					eip.ImagePanelColor = System.Drawing.Color.DarkBlue;
				else if (!sdesc.AvailableCharacterData)
					eip.ImagePanelColor = System.Drawing.Color.DarkRed;
			} 
			catch {	}

			
			
			if (sdesc.CharacterDescription.Gender==Data.MetaData.Gender.Female)
				eip.PanelColor = System.Drawing.Color.LightPink;
			else
				eip.PanelColor = System.Drawing.Color.PowderBlue;
		}
		protected ExtendedImagePanel CreateItem(Interfaces.Files.IPackedFileDescriptor pfd, int left, int top)
		{
			ExtendedImagePanel eip = new ExtendedImagePanel();
			eip.BeginUpdate();
			eip.SetBounds(left, top, 216, 80);
			eip.ImagePanelColor = System.Drawing.Color.Black;
			eip.Fade = 0.5f;
			eip.FadeColor = System.Drawing.Color.Transparent;

			Wrapper.SDesc sdesc = new SDesc();
			eip.Tag = sdesc;			
			try 
			{
				sdesc.ProcessData(pfd, pkg);
				
				eip.Properties["GUID"].Value = "0x"+Helper.HexString(sdesc.SimId);
				eip.Properties["Instance"].Value = "0x"+Helper.HexString(pfd.Instance);
				eip.Properties["Household"].Value = sdesc.HouseholdName;
				/*eip.Properties["Life Stage"].Value = ((Data.LocalizedLifeSections)sdesc.CharacterDescription.LifeSection).ToString();
				eip.Properties["Career"].Value = ((Data.LocalizedCareers)sdesc.CharacterDescription.Career).ToString();
				eip.Properties["Zodiac Sign"].Value = ((Data.LocalizedZodiacSignes)sdesc.CharacterDescription.ZodiacSign).ToString();*/
				
			} 
			catch (Exception ex) 
			{
				eip.Properties["Error"].Value = ex.Message;
			}

			
			
			CreateItem(eip, sdesc);

			eip.GotFocus += new EventHandler(eip_GotFocus);
			eip.MouseDown += new System.Windows.Forms.MouseEventHandler(eip_MouseDown);
			
			return eip;
		}

		#region Events
		public delegate void SelectedSimHandler(object sender, System.Drawing.Image thumb, Wrapper.SDesc sdesc);
		public event SelectedSimHandler SelectedSimChanged;
		public event SelectedSimHandler ClickOverSim;
		#endregion

		private void eip_GotFocus(object sender, EventArgs e)
		{
			if (SelectedSimChanged!=null && (sender is ExtendedImagePanel)) 
			{
				SelectedSimChanged(this, ((Ambertation.Windows.Forms.Graph.ExtendedImagePanel)sender).Image, (Wrapper.SDesc)((Ambertation.Windows.Forms.Graph.ExtendedImagePanel)sender).Tag);
			}
		}

		private void eip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (ClickOverSim!=null && (sender is ExtendedImagePanel)) 
			{
				ClickOverSim(this, ((Ambertation.Windows.Forms.Graph.ExtendedImagePanel)sender).Image, (Wrapper.SDesc)((Ambertation.Windows.Forms.Graph.ExtendedImagePanel)sender).Tag);
			}
		}
	}
}
