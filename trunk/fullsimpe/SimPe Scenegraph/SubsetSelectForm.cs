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
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für SubsetSelectForm.
	/// </summary>
	public class SubsetSelectForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Panel pnselect;
		public System.Windows.Forms.Button button1;
		public System.Windows.Forms.CheckBox cbauto;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		internal SubsetSelectForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(SubsetSelectForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbauto = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pnselect = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.cbauto);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pnselect);
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(536, 440);
			this.panel1.TabIndex = 0;
			// 
			// cbauto
			// 
			this.cbauto.Checked = true;
			this.cbauto.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbauto.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbauto.Location = new System.Drawing.Point(8, 408);
			this.cbauto.Name = "cbauto";
			this.cbauto.Size = new System.Drawing.Size(240, 24);
			this.cbauto.TabIndex = 3;
			this.cbauto.Text = "Autoselect matching Textures";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(456, 416);
			this.button1.Name = "button1";
			this.button1.TabIndex = 2;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pnselect
			// 
			this.pnselect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnselect.AutoScroll = true;
			this.pnselect.Location = new System.Drawing.Point(0, 0);
			this.pnselect.Name = "pnselect";
			this.pnselect.Size = new System.Drawing.Size(536, 408);
			this.pnselect.TabIndex = 1;
			// 
			// SubsetSelectForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(544, 446);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SubsetSelectForm";
			this.Text = "Subset Selection";
			this.Closing += new System.ComponentModel.CancelEventHandler(this.DoClosing);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		ArrayList listviews;
		/// <summary>
		/// Returns a list of all availabel ListViews
		/// </summary>
		public ArrayList ListViews
		{
			get {return listviews;}
		}

		public static Size ImageSize = new Size(128, 128);

		/// <summary>
		/// Add a new Selection for a Subset
		/// </summary>
		/// <param name="ssf">The for you want to add the Selection to</param>
		/// <param name="subset">The name of the Subset</param>
		/// <param name="top">the top coordinate for the Selection Panel</param>
		/// <returns>the ListView you can use to add Items to</returns>
		protected ListView AddSelection(SubsetSelectForm ssf, string subset, ref int top) 
		{
			Panel pn = new Panel();
			pn.Parent = ssf.pnselect;
			pn.Top = top;
			pn.Left = 8;
			pn.Width = ssf.pnselect.Width-16;
			pn.Height = ImageSize.Height + 64;
			pn.Visible = false;
			pn.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

			CheckBox cb = new CheckBox();
			cb.Parent = pn;
			cb.Top = 0;
			cb.Left = 0;
			cb.Checked = true;
			cb.Width = pn.Width;
			cb.Text = subset;
			cb.Anchor = pn.Anchor;
			cb.CheckedChanged += new EventHandler(CheckedChanged);

			ListView lv = new ListView();
			lv.Parent = pn;
			lv.Tag = subset;
			lv.Left = 8;
			lv.Top = cb.Height + cb.Top;
			lv.Width = pn.Width - lv.Left;
			lv.Height = pn.Height - lv.Top;
			lv.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
			lv.HideSelection = false;
			lv.MultiSelect = false;
			lv.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);
			cb.Tag = lv;

			ImageList il = new ImageList();
			il.ImageSize = ImageSize;
			il.ColorDepth = ColorDepth.Depth32Bit;
			lv.LargeImageList = il;
			
			top += pn.Height + 8;
			pn.Visible = true;

			listviews.Add(lv);
			return lv;
		}

		/// <summary>
		/// Return the Thumbnail for the mmat with the passed Index
		/// </summary>
		/// <param name="index"></param>
		/// <param name="mmats"></param>
		/// <param name="sz">Size of the Thumbnail</param>
		/// <returns>a valid Image</returns>
		protected Image GetItemThumb(int index, ArrayList mmats, Size sz)
		{
			if ((index<0) || (index>=mmats.Count)) return new Bitmap(sz.Width, sz.Height);

			SimPe.Plugin.MmatWrapper mmat = (SimPe.Plugin.MmatWrapper)mmats[index];
			GenericRcol txtr = mmat.TXTR;
			if (txtr!=null) 
			{
				ImageData id = (ImageData)txtr.Blocks[0];
				MipMap mm = id.LargestTexture;

				if (mm!=null) 
					return ImageLoader.Preview(mm.Texture, sz);					
			}

			return new Bitmap(sz.Width, sz.Height);
		}

		/// <summary>
		/// Creates a Thumbnail for the current Texture
		/// </summary>
		/// <param name="il">The ImageList that will hold the Thumbnail</param>
		/// <param name="lvi">The ListView Item that will get the Thumbnail Image</param>
		/// <param name="mmats">The Materials</param>
		protected void MakePreview(ImageList il, ListViewItem lvi, ArrayList mmats) 
		{
			if (mmats.Count == 1) 
			{
				Image img = GetItemThumb(0, mmats, il.ImageSize);
				lvi.ImageIndex = il.Images.Count;
				il.Images.Add(img);				
			} 
			else if (mmats.Count>1) 
			{				
				Image img1 = GetItemThumb(0, mmats, il.ImageSize);
				Image img2 = GetItemThumb(1, mmats, il.ImageSize);

				Bitmap bm = new Bitmap(il.ImageSize.Width, il.ImageSize.Height);
				Graphics gr = Graphics.FromImage(bm);
				gr.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
				gr.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

				Rectangle source = new Rectangle(0, 0, il.ImageSize.Width / 2, il.ImageSize.Height);
				gr.DrawImage(img1, source, source, GraphicsUnit.Pixel);

				source = new Rectangle(il.ImageSize.Width / 2, 0, il.ImageSize.Width / 2, il.ImageSize.Height);
				gr.DrawImage(img2, source, source, GraphicsUnit.Pixel);

				gr.DrawLine(new Pen(Color.Orange, 2), il.ImageSize.Width / 2, 0, il.ImageSize.Width / 2, il.ImageSize.Height);

				gr.FillEllipse(new Pen(Color.Orange, 1).Brush, (ImageSize.Width-24)/2, 4, 24, 24);
				Font ft = new Font("Verdana", 16.0f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Pixel);
				
				gr.DrawString(mmats.Count.ToString(), ft, new Pen(Color.White).Brush, new RectangleF((ImageSize.Width-24)/2+2, 6, 20, 20));

				lvi.ImageIndex = il.Images.Count;
				il.Images.Add(bm);	
			}
		}

		Hashtable txmtnames;
		/// <summary>
		/// Add a New Item to the ListView
		/// </summary>
		/// <param name="lv">the list view you want to add the items to</param>
		/// <param name="mmats">an array of MmatWraper Objects having all possible states</param>
		protected void AddItem(ListView lv, ArrayList mmats) 
		{
			if (mmats.Count==0) return;
				

			ListViewItem lvi = new ListViewItem();
			GenericRcol txtr = ((SimPe.Plugin.MmatWrapper)mmats[0]).TXTR;
			GenericRcol txmt = ((SimPe.Plugin.MmatWrapper)mmats[0]).TXMT;
			if (txmt!=null) 
			{
				string txmtname = Hashes.StripHashFromName(txmt.FileName.Trim().ToLower());
				if (!txmtnames.ContainsKey(txmtname)) 
				{
					if (txtr!=null) 
					{										
						lvi.Text = txtr.FileName;
						lvi.Tag = mmats;

						MakePreview(lv.LargeImageList, lvi, mmats);

						lv.Items.Add(lvi);	
					} 
					else 
					{
						lvi.Text = txmt.FileName;
						lvi.Tag = mmats;
						lv.Items.Add(lvi);
					}

					txmtnames.Add(txmtname, lvi);
				} //txmtnames
				else 
				{
					ListViewItem l = (ListViewItem)txmtnames[txmtname];
					ArrayList ls = (ArrayList)l.Tag;
					ls.AddRange(mmats);
				}
			}
		}

		/// <summary>
		/// Setup the Form
		/// </summary>
		/// <param name="map">The subset map</param>
		/// <param name="subsets">the subsets you want to present</param>
		/// <returns>Returns a New Instance of the selection Form</returns>
		public static SubsetSelectForm Prepare(Hashtable map, ArrayList subsets) 
		{
			SubsetSelectForm ssf = new SubsetSelectForm();
			ssf.listviews = new ArrayList();
			ssf.txmtnames = new Hashtable();
			WaitingScreen.Wait();
			try 
			{
				WaitingScreen.UpdateMessage("Show Subset Selection");
				ssf.button1.Enabled = false;

				int top = 0;
				foreach (string subset in map.Keys) 
				{
					if (!subsets.Contains(subset)) continue;

					ListView lv = ssf.AddSelection(ssf, subset, ref top);
					Hashtable families = (Hashtable)map[subset];
					foreach (string family in families.Keys) 
					{
						ArrayList mmats = (ArrayList)families[family];
						mmats.Sort(new MmatListCompare());
						ssf.AddItem(lv, mmats);
					}	
				
					if (lv.Items.Count>0) lv.Items[0].Selected = true;
				}
				
				
			}
			finally 
			{
				WaitingScreen.Stop();
			}
			
			return ssf;
		}

		/// <summary>
		/// Builds a new Hashtable based on the Users Selection
		/// </summary>
		/// <param name="ssf">The Form that was used</param>
		/// <returns>The new Hashtable</returns>
		public static Hashtable Finish(SubsetSelectForm ssf) 
		{
			//now rebuild the Hashtable with the stored Infos
			Hashtable ret = new Hashtable();
			foreach (ListView lv in ssf.listviews) 
			{
				if (!lv.Enabled) continue;

				if (lv.SelectedItems.Count>0) 
				{
					Hashtable sub = new Hashtable();
					sub["user-selection"] = lv.SelectedItems[0].Tag;
					ret[(string)lv.Tag] =  sub;
				}
			}

			return ret;
		}

		/// <summary>
		/// Show the Selection Form
		/// </summary>
		/// <param name="map">The subset map</param>
		/// <param name="package">the opened source package</param>
		/// <param name="subsets">List of all Subsets you want to present</param>
		/// <returns>the map with all the selected Items</returns>
		public static Hashtable Execute(Hashtable map, ArrayList subsets) 
		{			
			SubsetSelectForm ssf = Prepare(map, subsets);			
			ssf.ShowDialog();
			return Finish(ssf);
			
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// true, if a SubSet is selected in each ListView
		/// </summary>
		private bool CanContinue
		{
			get 
			{
				if (listviews.Count==0) return true;

				foreach (ListView lv in listviews) 
				{
					if ((lv.SelectedItems.Count==0) && lv.Enabled && lv.Items.Count!=0) return false;
				}

				return true;
			}
		}

		private void CheckedChanged(object sender, EventArgs e)
		{
			CheckBox cb = (CheckBox)sender;
			ListView lv = (ListView)cb.Tag;

			lv.Enabled = cb.Checked;
			button1.Enabled = CanContinue;
		}

		bool internalupdate = false;
		private void SelectedIndexChanged(object sender, EventArgs e)
		{
			if (internalupdate) return;

			internalupdate = true;
			try 
			{
				ListView lv = (ListView)sender;
			
				//autoselect matching Textures
				if ((cbauto.Checked) && (lv.SelectedItems.Count>0))
				{
					string name = lv.SelectedItems[0].Text;
					foreach (ListView lv2 in listviews) 
					{
						if (lv2==lv) continue;

						foreach (ListViewItem lvi in lv2.Items) 
						{
							if (lvi.Text == name) lvi.Selected = true;
						}
					}
				}

				button1.Enabled = CanContinue;
			} 
			finally 
			{
				internalupdate = false;
			}
		}

		private void DoClosing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!CanContinue) 
			{
				System.Windows.Forms.MessageBox.Show("Please select a Texture in each Subset!", "Warning");
				e.Cancel = true;
			}
		}

	}
}
