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
	[System.ComponentModel.DefaultEvent("SelectedSimChanged")]
	public class SimPoolControl : System.Windows.Forms.UserControl
	{
		public SimPoolControl()
		{
            details = false;
            rightclicksel = false;
			InitializeComponent();
            
		}

		protected SimListView gp;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader chHouse;
        protected Ambertation.Windows.Forms.FlatComboBox cbhousehold;
        private System.ComponentModel.IContainer components;

		public SimPe.PackedFiles.Wrapper.SDesc SelectedElement
		{
			get { 
				if (gp.SelectedItems.Count<1) return null;
				return (SimPe.PackedFiles.Wrapper.ExtSDesc)gp.SelectedItems[0].Tag;
			}
			set { FindItem(value); }
		}

		public SimPe.PackedFiles.Wrapper.ExtSDesc SelectedSim
		{
			get 
			{ 
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
			this.cbhousehold.Items.Clear();
			this.cbhousehold.Items.Add(SimPe.Localization.GetString("[All Households]"));						
			gp.Items.Clear();
			lastsel = null;

			if (pkg==null) 
			{
				cbhousehold.SelectedIndex = 0;		
				return;
			}

			string chouse;
			ArrayList names = FileTable.ProviderRegistry.SimDescriptionProvider.GetHouseholdNames(out chouse);
			int index = 0;
			foreach (string name in names) 
			{
				if (name==chouse) index = cbhousehold.Items.Count;
				this.cbhousehold.Items.Add(name);				
			}
			
			cbhousehold.SelectedIndex = index;
		}

        bool details;
        public bool SimDetails
        {
            get { return details; }
            set
            {
                if (details != value)
                {
                    details = value;
                    this.SetViewMode();
                }
            }
        }
        public class AddSimToPoolEventArgs : System.EventArgs
        {
            SimPe.PackedFiles.Wrapper.ExtSDesc sdsc;
            public SimPe.PackedFiles.Wrapper.ExtSDesc SimDescription
            {
                get { return sdsc; }
            }

            string name;
            public string Name
            {
                get { return name; }
            }

            string household;
            public string Household
            {
                get { return household; }
            }

            bool cancel;
            public bool Cancel
            {
                get { return cancel; }
                set { cancel = value; }
            }

            System.Drawing.Image img;
            public System.Drawing.Image Image
            {
                get { return img; }                
            }

            int grpid;
            public int GroupIndex
            {
                get { return grpid; }
                set { grpid = value; }
            }

            internal AddSimToPoolEventArgs(SimPe.PackedFiles.Wrapper.ExtSDesc sdsc, string name, string household, System.Drawing.Image img, int groupindex)
            {
                this.sdsc = sdsc;
                this.name = name;
                this.img = img;
                this.household = household;
                this.grpid = groupindex;
                

                cancel = false;
            }

            public override string ToString()
            {
                return Name;
            }
        }

        public delegate void AddSimToPoolEvent(object sender, AddSimToPoolEventArgs e);
        public event AddSimToPoolEvent AddSimToPool;

       
        protected virtual void OnAddSimToPool(AddSimToPoolEventArgs e)
        {            
        }

        AddSimToPoolEventArgs DoAddSimToPool(SimPe.PackedFiles.Wrapper.ExtSDesc sdsc, string name, string household, System.Drawing.Image img)
        {
            AddSimToPoolEventArgs e = new AddSimToPoolEventArgs(sdsc, name, household, img, 0);
            OnAddSimToPool(e);
            if (AddSimToPool != null) AddSimToPool(this, e);             
            return e;
        }

        protected virtual System.Drawing.Color GetBackgroundColor(SimPe.PackedFiles.Wrapper.ExtSDesc sdsc)
        {
            return GetImagePanelColor(sdsc);
        }

		void UpdateSimList(string household)
		{
			gp.BeginUpdate();
			gp.Clear();
			Hashtable ht = FileTable.ProviderRegistry.SimDescriptionProvider.SimInstance;
			Wait.SubStart(ht.Count);						
			int ct=0;

			System.Collections.SortedList map = new System.Collections.SortedList();
			
			foreach(SimPe.PackedFiles.Wrapper.ExtSDesc sdsc in ht.Values)
			{	
				if (household != null)
					if (household != sdsc.HouseholdName)
						continue;

				string name = sdsc.SimName+" "+sdsc.SimFamilyName;
                System.Drawing.Image simimg = gp.GetSimIcon(sdsc, GetBackgroundColor(sdsc));
                AddSimToPoolEventArgs ret = DoAddSimToPool(sdsc, name, household, simimg);

                if (!ret.Cancel)
                {
                    SteepValley.Windows.Forms.XPListViewItem eip = gp.Add(sdsc, simimg);
                    eip.Tag = sdsc;
                    eip.GroupIndex = ret.GroupIndex;


                    if (map.ContainsKey(name)) name += " (" + sdsc.FileDescriptor.Instance.ToString() + ")";
                    map[name] = eip;
                    Wait.Message = eip.Text;	
                }
				
				Wait.Progress = ct++;
							
			}

            SetViewMode();
            

			if (gp.Items.Count>0) 
			{
				gp.Items[0].Selected=true;
                try
                {
                    if (SelectedSimChanged!=null)
                        SelectedSimChanged(this, ((SimPe.PackedFiles.Wrapper.ExtSDesc)gp.Items[0].Tag).Image, (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)gp.Items[0].Tag));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
			}
			
			gp.EndUpdate();
			Wait.SubStop();
		}

        private void SetViewMode()
        {
            gp.TileSize = new System.Drawing.Size(00, 00);

            gp.TileColumns = new int[] { 1, 2, 6, 3, 4, 5 };
            gp.SetColumnStyle(1, gp.Font, System.Drawing.Color.Gray);
            gp.SetColumnStyle(2, gp.Font, System.Drawing.Color.Gray);
            gp.SetColumnStyle(3, gp.Font, System.Drawing.Color.Gray);
            gp.SetColumnStyle(4, gp.Font, System.Drawing.Color.Gray);

            if (details)
            {
                gp.View = SteepValley.Windows.Forms.ExtendedView.Tile;
            }
            else
            {
                gp.View = SteepValley.Windows.Forms.ExtendedView.LargeIcon;
            }
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
        bool rightclicksel;
        public bool RightClickSelect
        {
            get { return rightclicksel; }
            set { rightclicksel = value; }
        }

		private void gp_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			SteepValley.Windows.Forms.XPListViewItem item = (SteepValley.Windows.Forms.XPListViewItem)gp.GetItemAt(e.X, e.Y);
			if (ClickOverSim!=null && item!=null) 
			{
				ClickOverSim(this, ((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag).Image, (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag));
			}

            if (SelectedSimChanged != null && item != null && (e.Button == System.Windows.Forms.MouseButtons.Left || (e.Button == System.Windows.Forms.MouseButtons.Right && rightclicksel))) 
			{
				gp.SelectedItems.Clear();
				item.Selected = true;
				lastsel = item;
				SelectedSimChanged(this, ((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag).Image, (Wrapper.SDesc)((SimPe.PackedFiles.Wrapper.ExtSDesc)item.Tag));				
			} 
			//if (lastsel!=null && e.Button!=System.Windows.Forms.MouseButtons.Left) lastsel.Selected = true;
		}
		

		#region Designer
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimPoolControl));
            SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup1 = new SteepValley.Windows.Forms.XPListViewGroup("Unrelated", 0);
            SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup2 = new SteepValley.Windows.Forms.XPListViewGroup("Related", 1);
            this.cbhousehold = new Ambertation.Windows.Forms.FlatComboBox();
            this.gp = new SimPe.PackedFiles.Wrapper.SimListView();
            this.chHouse = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // cbhousehold
            // 
            resources.ApplyResources(this.cbhousehold, "cbhousehold");
            this.cbhousehold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhousehold.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbhousehold.Name = "cbhousehold";
            this.cbhousehold.SelectedIndexChanged += new System.EventHandler(this.cbhousehold_SelectedIndexChanged);
            // 
            // gp
            // 
            this.gp.BackColor = System.Drawing.SystemColors.Info;
            this.gp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.chHouse,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            resources.ApplyResources(this.gp, "gp");
            this.gp.FullRowSelect = true;
            xpListViewGroup1.GroupIndex = 0;
            xpListViewGroup1.GroupText = "Unrelated";
            xpListViewGroup2.GroupIndex = 1;
            xpListViewGroup2.GroupText = "Related";
            this.gp.Groups.Add(xpListViewGroup1);
            this.gp.Groups.Add(xpListViewGroup2);
            this.gp.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.gp.HideSelection = false;
            this.gp.MultiSelect = false;
            this.gp.Name = "gp";
            this.gp.TileColumns = new int[] {
        1};
            this.gp.UseCompatibleStateImageBehavior = false;
            this.gp.DoubleClick += new System.EventHandler(this.gp_DoubleClick);
            this.gp.SelectedIndexChanged += new System.EventHandler(this.gp_SelectedIndexChanged);
            this.gp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gp_MouseDown);
            // 
            // chHouse
            // 
            resources.ApplyResources(this.chHouse, "chHouse");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // SimPoolControl
            // 
            this.Controls.Add(this.gp);
            this.Controls.Add(this.cbhousehold);
            resources.ApplyResources(this, "$this");
            this.Name = "SimPoolControl";
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
			if (sdsc==null) 
			{
				gp.SelectedItems.Clear();
				return;
			}

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

        /// <summary>
        /// Refresh the LIst of displayed Sims
        /// </summary>
        public void UpdateSimList()
        {
            if (this.cbhousehold.SelectedIndex > 0)
                this.UpdateSimList(this.cbhousehold.Text);
            else
                this.UpdateSimList(null);
        }

		private void cbhousehold_SelectedIndexChanged(object sender, System.EventArgs e)
		{
            UpdateSimList();
		}

		
		public void SelectHousehold(string name)
		{
			int index=0;
			for (int i=1; i<this.cbhousehold.Items.Count; i++)
			{
				if (this.cbhousehold.Items[i].ToString()==name) 
				{
					index=i;
					break;
				}
			}
			this.cbhousehold.SelectedIndex = index;
		}
		
		public new void Refresh()
		{
			Refresh(true);
		}

		public void Refresh(bool full)
		{
			if (full) this.UpdateContent();
			base.Refresh();
		}

        internal SteepValley.Windows.Forms.XPListViewItemCollection Items
        {
            get { return this.gp.Items; }
        }

        internal System.Windows.Forms.ListView.SelectedIndexCollection SelectedIndices
        {
            get { return gp.SelectedIndices; }
        }

        internal System.Windows.Forms.ListView.SelectedListViewItemCollection SelectedItems
        {
            get { return gp.SelectedItems; }
        }

        internal void Sort()
        {
        }

        internal SteepValley.Windows.Forms.XPListViewItem Add(PackedFiles.Wrapper.ExtSDesc o)
        {
            return gp.Add(o);
        }

        public void SetColumnStyle(int column, System.Drawing.Font font, System.Drawing.Color cl)
        {
            gp.SetColumnStyle(column, font, cl);
        }

        public int[] TileColumns
        {
            get { return gp.TileColumns; }
            set { gp.TileColumns = value; }
        }

        public void EnsureVisible(int index)
        {
            gp.EnsureVisible(index);
        }
	}
}
