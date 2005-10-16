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
	public class SimPoolControl : System.Windows.Forms.UserControl
	{
		public SimPoolControl()
		{
			InitializeComponent();			
		}

		private SimListView gp;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader chHouse;

		public SimPe.PackedFiles.Wrapper.SDesc SelectedElement
		{
			get { 
				if (gp.SelectedItems.Count<1) return null;
				return (SimPe.PackedFiles.Wrapper.ExtSDesc)gp.SelectedItems[0].Tag;
			}
			set { FindItem(value); }
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
			gp.BeginUpdate();			
			gp.Items.Clear();
			lastsel = null;

			if (pkg==null) 
			{
				gp.EndUpdate();				
				return;
			}
			SimPe.Interfaces.Files.IPackedFileDescriptor[] pfds = pkg.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			Wait.SubStart(pfds.Length);						
			int ct=0;

			System.Collections.SortedList map = new System.Collections.SortedList();
			
			foreach(Interfaces.Files.IPackedFileDescriptor pfd in pfds)
			{			
				SimPe.PackedFiles.Wrapper.ExtSDesc sdsc = new SimPe.PackedFiles.Wrapper.ExtSDesc();
				sdsc.ProcessData(pfd, pkg);				
				string name = sdsc.SimName+" "+sdsc.SimFamilyName;

				SteepValley.Windows.Forms.XPListViewItem eip = gp.Add(sdsc);
				eip.Tag = sdsc;
				

				if (map.ContainsKey(name)) name += " ("+pfd.Instance.ToString()+")";
				map[name] = eip;
				
				//if (ct==1) WaitingScreen.Wait();													
				//WaitingScreen.UpdateMessage((ct++).ToString() + "/" + pfds.Length.ToString());
				Wait.Progress = ct++;
				Wait.Message = eip.Text;
			}			

			gp.TileColumns = new int[]{1, 2, 6, 3, 4, 5};
			gp.SetColumnStyle(1, gp.Font, System.Drawing.Color.Gray);
			gp.SetColumnStyle(2, gp.Font, System.Drawing.Color.Gray);
			gp.SetColumnStyle(3, gp.Font, System.Drawing.Color.Gray);			
			gp.SetColumnStyle(4, gp.Font, System.Drawing.Color.Gray);
			
			gp.EndUpdate();
			Wait.SubStop();
		}

		public static System.Drawing.Color GetImagePanelColor(SDesc sdesc)
		{
			if (sdesc.Unlinked!=0) 
				return System.Drawing.Color.DarkBlue;
			else if (!sdesc.AvailableCharacterData)
				return System.Drawing.Color.DarkRed;
			return System.Drawing.SystemColors.ControlDarkDark;//System.Drawing.Color.Black;
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
				if (img.Width<8) img=null;
				if (img==null) img = System.Drawing.Image.FromStream(typeof(SimPoolControl).Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png"));
				else if (Helper.WindowsRegistry.GraphQuality) img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new System.Drawing.Point(0,0), System.Drawing.Color.Magenta);					
				
				eip.Image = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, 48, 48, Helper.WindowsRegistry.GraphQuality);

				eip.ImagePanelColor = GetImagePanelColor(sdesc);				
			} 
			catch {	}

			
			
			if (sdesc.CharacterDescription.Gender==Data.MetaData.Gender.Female)
				eip.PanelColor = System.Drawing.Color.LightPink;
			else
				eip.PanelColor = System.Drawing.Color.PowderBlue;
		}

		public static ExtendedImagePanel CreateItem(Wrapper.SDesc sdesc)
		{
			ExtendedImagePanel eip = new ExtendedImagePanel();
			eip.SetBounds(0, 0, 216, 80);
			eip.BeginUpdate();
			PrepareItem(eip, sdesc);
			eip.EndUpdate();

			return eip;
		}

		static void PrepareItem(ExtendedImagePanel eip, Wrapper.SDesc sdesc)
		{
			eip.ImagePanelColor = System.Drawing.Color.Black;
			eip.Fade = 0.5f;
			eip.FadeColor = System.Drawing.Color.Transparent;
			
			eip.Tag = sdesc;			
			try 
			{
				eip.Properties["GUID"].Value = "0x"+Helper.HexString(sdesc.SimId);
				eip.Properties["Instance"].Value = "0x"+Helper.HexString(sdesc.FileDescriptor.Instance);
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
		}

		protected ExtendedImagePanel CreateItem(Interfaces.Files.IPackedFileDescriptor pfd, int left, int top)
		{
			ExtendedImagePanel eip = new ExtendedImagePanel();
			eip.BeginUpdate();
			eip.SetBounds(left, top, 216, 80);
			

			Wrapper.SDesc sdesc = new SDesc();			
			try 
			{
				sdesc.ProcessData(pfd, pkg);
				
				PrepareItem(eip, sdesc);
			} 
			catch (Exception ex) 
			{
				eip.Properties["Error"].Value = ex.Message;
			}

			//eip.GotFocus += new EventHandler(eip_GotFocus);
			//eip.MouseDown += new System.Windows.Forms.MouseEventHandler(eip_MouseDown);
			//eip.DoubleClick += new EventHandler(eip_DoubleClick);
			
			return eip;
		}

		#region Events
		public delegate void SelectedSimHandler(object sender, System.Drawing.Image thumb, Wrapper.SDesc sdesc);
		public event SelectedSimHandler SelectedSimChanged;
		public event SelectedSimHandler ClickOverSim;
		public event SelectedSimHandler DoubleClickSim;
		#endregion

		private void gp_SelectedIndexChanged(object sender, System.EventArgs e)
		{			
			if (SelectedSimChanged!=null && gp.SelectedItems.Count>0) 
			{
				//SelectedSimChanged(this, gp.LargeImageList.Images[gp.SelectedItems[0].ImageIndex], (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)gp.SelectedItems[0].Tag));
			}
		}

		private void gp_DoubleClick(object sender, System.EventArgs e)
		{
			if (DoubleClickSim!=null && gp.SelectedItems.Count>0) 
			{
				DoubleClickSim(this, gp.LargeImageList.Images[gp.SelectedItems[0].ImageIndex], (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)gp.SelectedItems[0].Tag));
			}
		}

		SteepValley.Windows.Forms.XPListViewItem lastsel;

		private void gp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			SteepValley.Windows.Forms.XPListViewItem item = (SteepValley.Windows.Forms.XPListViewItem)gp.GetItemAt(e.X, e.Y);
			if (ClickOverSim!=null && item!=null) 
			{
				ClickOverSim(this, ((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag).Image, (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag));
			}

			if (SelectedSimChanged!=null && item!=null && e.Button==System.Windows.Forms.MouseButtons.Left) 
			{
				lastsel = item;
				SelectedSimChanged(this, ((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag).Image, (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag));				
			} 
			//if (lastsel!=null && e.Button!=System.Windows.Forms.MouseButtons.Left) lastsel.Selected = true;
		}
		

		#region Designer
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SimPoolControl));
			this.gp = new SimPe.PackedFiles.Wrapper.SimListView();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.chHouse = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.SuspendLayout();
			// 
			// gp
			// 
			this.gp.AccessibleDescription = resources.GetString("gp.AccessibleDescription");
			this.gp.AccessibleName = resources.GetString("gp.AccessibleName");
			this.gp.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("gp.Alignment")));
			this.gp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gp.Anchor")));
			this.gp.AutoGroupColumn = this.chHouse;
			this.gp.AutoGroupMode = true;
			this.gp.BackColor = System.Drawing.SystemColors.Info;
			this.gp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gp.BackgroundImage")));
			this.gp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.gp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.columnHeader1,
																				 this.chHouse,
																				 this.columnHeader2,
																				 this.columnHeader3,
																				 this.columnHeader4});
			this.gp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gp.Dock")));
			this.gp.Enabled = ((bool)(resources.GetObject("gp.Enabled")));
			this.gp.Font = ((System.Drawing.Font)(resources.GetObject("gp.Font")));
			this.gp.FullRowSelect = true;
			this.gp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.gp.HideSelection = false;
			this.gp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gp.ImeMode")));
			this.gp.LabelWrap = ((bool)(resources.GetObject("gp.LabelWrap")));
			this.gp.Location = ((System.Drawing.Point)(resources.GetObject("gp.Location")));
			this.gp.MultiSelect = false;
			this.gp.Name = "gp";
			this.gp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gp.RightToLeft")));
			this.gp.ShowGroups = true;
			this.gp.Size = ((System.Drawing.Size)(resources.GetObject("gp.Size")));
			this.gp.TabIndex = ((int)(resources.GetObject("gp.TabIndex")));
			this.gp.Text = resources.GetString("gp.Text");
			this.gp.TileColumns = new int[] {
												1};
			this.gp.View = SteepValley.Windows.Forms.ExtendedView.Tile;
			this.gp.Visible = ((bool)(resources.GetObject("gp.Visible")));
			this.gp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gp_MouseDown);
			this.gp.DoubleClick += new System.EventHandler(this.gp_DoubleClick);
			this.gp.SelectedIndexChanged += new System.EventHandler(this.gp_SelectedIndexChanged);
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = resources.GetString("columnHeader2.Text");
			this.columnHeader2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader2.TextAlign")));
			this.columnHeader2.Width = ((int)(resources.GetObject("columnHeader2.Width")));
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = resources.GetString("columnHeader1.Text");
			this.columnHeader1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader1.TextAlign")));
			this.columnHeader1.Width = ((int)(resources.GetObject("columnHeader1.Width")));
			// 
			// chHouse
			// 
			this.chHouse.Text = resources.GetString("chHouse.Text");
			this.chHouse.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("chHouse.TextAlign")));
			this.chHouse.Width = ((int)(resources.GetObject("chHouse.Width")));
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = resources.GetString("columnHeader3.Text");
			this.columnHeader3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader3.TextAlign")));
			this.columnHeader3.Width = ((int)(resources.GetObject("columnHeader3.Width")));
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = resources.GetString("columnHeader4.Text");
			this.columnHeader4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader4.TextAlign")));
			this.columnHeader4.Width = ((int)(resources.GetObject("columnHeader4.Width")));
			// 
			// SimPoolControl
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.gp);
			this.DockPadding.All = 1;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "SimPoolControl";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// Returns the <see cref="ImagePanel"/> that contains the passed Sim
		/// </summary>
		/// <param name="sdsc"></param>
		/// <returns></returns>
		public void FindItem(Wrapper.SDesc sdsc)
		{
			foreach (SteepValley.Windows.Forms.XPListViewItem gpe in gp.Items)
			{
				if (gpe.Tag is Wrapper.SDesc)
				{
					if (sdsc.Equals((Wrapper.SDesc)gpe.Tag)) 
					{
						gpe.Selected = true;
						gpe.EnsureVisible();
						SelectedSimChanged(this, ((Wrapper.SDesc)gpe.Tag).Image, ((Wrapper.SDesc)gpe.Tag));
					}
					else
						gpe.Selected = false;
				}
			}
		}

		

		

		
	}
}
