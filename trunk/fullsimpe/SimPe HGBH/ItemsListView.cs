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
using System.Windows.Forms;
using System.Drawing;
using SimPe;
using SimPe.Cache;

namespace SimPe.Plugin
{
	public class NgbhItemsListViewItem : ListViewItem, System.IDisposable
	{				
		NgbhItemsListView parent;
		NgbhItem item;
		public NgbhItem Item
		{
			get {return item;}
		}
		public NgbhItemsListViewItem(NgbhItemsListView parent, NgbhItem item) : base()
		{
			this.item = item;
			this.parent = parent;
			//mci = NgbhUI.ObjectCache.FindItem(item.Guid);
						
						
			
			Update();
			parent.Items.Add(this);
		}

		internal void Update()
		{
			this.Text = item.ToString();			
			if (!item.Flags.IsVisible) this.ForeColor = Color.SteelBlue;
			if (item.Flags.IsAction) this.ForeColor = Color.Gray;
			if (item.IsInventory) this.ForeColor = Color.MediumSeaGreen;
			if (item.IsGossip) this.Font = new Font(this.Font.FontFamily, this.Font.Size, FontStyle.Italic, this.Font.Unit);

			if (parent.SmallImageList!=null) 
			{
				Image i = item.Icon;
				if (i!=null) 
				{
					if (this.ImageIndex>=0)
						parent.SmallImageList.Images[this.ImageIndex] = i;
					else 
					{
						parent.SmallImageList.Images.Add(i);					
						this.ImageIndex = parent.SmallImageList.Images.Count-1;
					}
				}
			}
		}

		#region IDisposable Member

		public void Dispose()
		{
			item = null;
			parent = null;
		}

		#endregion
	}
	/// <summary>
	/// Zusammenfassung für ItemsListView.
	/// </summary>
	public class NgbhItemsListView : ListView
	{
		

		public NgbhItemsListView() : base()
		{
			this.BorderStyle = BorderStyle.None;
			this.SmallImageList = new ImageList();
			this.SmallImageList.ImageSize = new Size(NgbhItem.ICON_SIZE, NgbhItem.ICON_SIZE);
			this.SmallImageList.ColorDepth = ColorDepth.Depth32Bit;
			
			this.View = View.List;
			this.MultiSelect = false;
			this.HideSelection = false;
			
			SlotType = Data.NeighborhoodSlots.Sims;
		}
	

		SimPe.Data.NeighborhoodSlots st;
		public SimPe.Data.NeighborhoodSlots SlotType 
		{
			get {return st;}
			set {
				if (st!=value) 
				{
					st = value;
					SetContent();
				}
			}
		}

		public NgbhSlotList Slot
		{
			get 
			{
				if (NgbhItems==null) return null;
				else return NgbhItems.Parent;
			}
			set 
			{				
				if (value!=null)
					NgbhItems = value.GetItems(this.SlotType);
				else
					NgbhItems = null;				
			}
		}

		Collections.NgbhItems items;
		[System.ComponentModel.Browsable(false)]
		public Collections.NgbhItems NgbhItems 
		{
			get {return items;}
			set {
				//if (value!=items)
				{
					items = value;
					SetContent();
				}
			}
		}

		void SetContent()
		{
			this.Clear();

			if (items!=null)
			{
				this.BeginUpdate();
				foreach (NgbhItem i in items)	
				{								
					NgbhItemsListViewItem lvi = new NgbhItemsListViewItem(this, i); 				
				}
				this.EndUpdate();
			}
		}

		public new void Clear()
		{
			base.Clear();
			if (this.SmallImageList!=null)
				this.SmallImageList.Images.Clear();
		}


		public NgbhItemsListViewItem SelectedItem
		{
			get 
			{
				if (this.SelectedItems.Count==0) return null;
				else return SelectedItems[0] as NgbhItemsListViewItem;
			}
		}

		internal void UpdateSelected(NgbhItem item)
		{
			if (item==null) return;
			if (SelectedItem==null) return;

			SelectedItem.Update();
			this.Refresh();
		}
	}
}
