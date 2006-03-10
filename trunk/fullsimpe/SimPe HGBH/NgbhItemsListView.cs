using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhItemsListViewItem.
	/// </summary>
	public class NgbhItemsListView : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Panel panel1;
		private TD.SandBar.FlatComboBox cbadd;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.LinkLabel lldel;
		private Button btUp;
		private Button btDown;
		private ListView lv;

		public NgbhItemsListView()
		{
			SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();
			
			SmallImageList = new ImageList();
			SmallImageList.ImageSize = new Size(NgbhItem.ICON_SIZE, NgbhItem.ICON_SIZE);
			SmallImageList.ColorDepth = ColorDepth.Depth32Bit;				

			lv.SelectedIndexChanged += new EventHandler(lv_SelectedIndexChanged);
			
			SlotType = Data.NeighborhoodSlots.Sims;
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhItemsListView));
			this.lv = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.cbadd = new TD.SandBar.FlatComboBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.btUp = new System.Windows.Forms.Button();
			this.btDown = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.View = System.Windows.Forms.View.List;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged_1);
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.lladd);
			this.panel1.Controls.Add(this.cbadd);
			this.panel1.Controls.Add(this.lldel);
			this.panel1.Controls.Add(this.btUp);
			this.panel1.Controls.Add(this.btDown);
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// lladd
			// 
			this.lladd.AccessibleDescription = resources.GetString("lladd.AccessibleDescription");
			this.lladd.AccessibleName = resources.GetString("lladd.AccessibleName");
			this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lladd.Anchor")));
			this.lladd.AutoSize = ((bool)(resources.GetObject("lladd.AutoSize")));
			this.lladd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lladd.Dock")));
			this.lladd.Enabled = ((bool)(resources.GetObject("lladd.Enabled")));
			this.lladd.Font = ((System.Drawing.Font)(resources.GetObject("lladd.Font")));
			this.lladd.Image = ((System.Drawing.Image)(resources.GetObject("lladd.Image")));
			this.lladd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.ImageAlign")));
			this.lladd.ImageIndex = ((int)(resources.GetObject("lladd.ImageIndex")));
			this.lladd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lladd.ImeMode")));
			this.lladd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lladd.LinkArea")));
			this.lladd.Location = ((System.Drawing.Point)(resources.GetObject("lladd.Location")));
			this.lladd.Name = "lladd";
			this.lladd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lladd.RightToLeft")));
			this.lladd.Size = ((System.Drawing.Size)(resources.GetObject("lladd.Size")));
			this.lladd.TabIndex = ((int)(resources.GetObject("lladd.TabIndex")));
			this.lladd.TabStop = true;
			this.lladd.Text = resources.GetString("lladd.Text");
			this.lladd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.TextAlign")));
			this.lladd.Visible = ((bool)(resources.GetObject("lladd.Visible")));
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
			// 
			// cbadd
			// 
			this.cbadd.AccessibleDescription = resources.GetString("cbadd.AccessibleDescription");
			this.cbadd.AccessibleName = resources.GetString("cbadd.AccessibleName");
			this.cbadd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbadd.Anchor")));
			this.cbadd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbadd.BackgroundImage")));
			this.cbadd.DefaultText = resources.GetString("cbadd.DefaultText");
			this.cbadd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbadd.Dock")));
			this.cbadd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbadd.Enabled = ((bool)(resources.GetObject("cbadd.Enabled")));
			this.cbadd.Font = ((System.Drawing.Font)(resources.GetObject("cbadd.Font")));
			this.cbadd.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbadd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbadd.ImeMode")));
			this.cbadd.IntegralHeight = ((bool)(resources.GetObject("cbadd.IntegralHeight")));
			this.cbadd.ItemHeight = ((int)(resources.GetObject("cbadd.ItemHeight")));
			this.cbadd.Location = ((System.Drawing.Point)(resources.GetObject("cbadd.Location")));
			this.cbadd.MaxDropDownItems = ((int)(resources.GetObject("cbadd.MaxDropDownItems")));
			this.cbadd.MaxLength = ((int)(resources.GetObject("cbadd.MaxLength")));
			this.cbadd.Name = "cbadd";
			this.cbadd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbadd.RightToLeft")));
			this.cbadd.Size = ((System.Drawing.Size)(resources.GetObject("cbadd.Size")));
			this.cbadd.TabIndex = ((int)(resources.GetObject("cbadd.TabIndex")));
			this.cbadd.Text = resources.GetString("cbadd.Text");
			this.cbadd.Visible = ((bool)(resources.GetObject("cbadd.Visible")));
			this.cbadd.SelectedIndexChanged += new System.EventHandler(this.cbadd_SelectedIndexChanged);
			// 
			// lldel
			// 
			this.lldel.AccessibleDescription = resources.GetString("lldel.AccessibleDescription");
			this.lldel.AccessibleName = resources.GetString("lldel.AccessibleName");
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldel.Anchor")));
			this.lldel.AutoSize = ((bool)(resources.GetObject("lldel.AutoSize")));
			this.lldel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldel.Dock")));
			this.lldel.Enabled = ((bool)(resources.GetObject("lldel.Enabled")));
			this.lldel.Font = ((System.Drawing.Font)(resources.GetObject("lldel.Font")));
			this.lldel.Image = ((System.Drawing.Image)(resources.GetObject("lldel.Image")));
			this.lldel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.ImageAlign")));
			this.lldel.ImageIndex = ((int)(resources.GetObject("lldel.ImageIndex")));
			this.lldel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldel.ImeMode")));
			this.lldel.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldel.LinkArea")));
			this.lldel.Location = ((System.Drawing.Point)(resources.GetObject("lldel.Location")));
			this.lldel.Name = "lldel";
			this.lldel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldel.RightToLeft")));
			this.lldel.Size = ((System.Drawing.Size)(resources.GetObject("lldel.Size")));
			this.lldel.TabIndex = ((int)(resources.GetObject("lldel.TabIndex")));
			this.lldel.TabStop = true;
			this.lldel.Text = resources.GetString("lldel.Text");
			this.lldel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.TextAlign")));
			this.lldel.Visible = ((bool)(resources.GetObject("lldel.Visible")));
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
			// 
			// btUp
			// 
			this.btUp.AccessibleDescription = resources.GetString("btUp.AccessibleDescription");
			this.btUp.AccessibleName = resources.GetString("btUp.AccessibleName");
			this.btUp.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btUp.Anchor")));
			this.btUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btUp.BackgroundImage")));
			this.btUp.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btUp.Dock")));
			this.btUp.Enabled = ((bool)(resources.GetObject("btUp.Enabled")));
			this.btUp.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btUp.FlatStyle")));
			this.btUp.Font = ((System.Drawing.Font)(resources.GetObject("btUp.Font")));
			this.btUp.Image = ((System.Drawing.Image)(resources.GetObject("btUp.Image")));
			this.btUp.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btUp.ImageAlign")));
			this.btUp.ImageIndex = ((int)(resources.GetObject("btUp.ImageIndex")));
			this.btUp.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btUp.ImeMode")));
			this.btUp.Location = ((System.Drawing.Point)(resources.GetObject("btUp.Location")));
			this.btUp.Name = "btUp";
			this.btUp.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btUp.RightToLeft")));
			this.btUp.Size = ((System.Drawing.Size)(resources.GetObject("btUp.Size")));
			this.btUp.TabIndex = ((int)(resources.GetObject("btUp.TabIndex")));
			this.btUp.Text = resources.GetString("btUp.Text");
			this.btUp.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btUp.TextAlign")));
			this.btUp.Visible = ((bool)(resources.GetObject("btUp.Visible")));
			this.btUp.Click += new System.EventHandler(this.btUp_Click);
			// 
			// btDown
			// 
			this.btDown.AccessibleDescription = resources.GetString("btDown.AccessibleDescription");
			this.btDown.AccessibleName = resources.GetString("btDown.AccessibleName");
			this.btDown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btDown.Anchor")));
			this.btDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btDown.BackgroundImage")));
			this.btDown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btDown.Dock")));
			this.btDown.Enabled = ((bool)(resources.GetObject("btDown.Enabled")));
			this.btDown.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btDown.FlatStyle")));
			this.btDown.Font = ((System.Drawing.Font)(resources.GetObject("btDown.Font")));
			this.btDown.Image = ((System.Drawing.Image)(resources.GetObject("btDown.Image")));
			this.btDown.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btDown.ImageAlign")));
			this.btDown.ImageIndex = ((int)(resources.GetObject("btDown.ImageIndex")));
			this.btDown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btDown.ImeMode")));
			this.btDown.Location = ((System.Drawing.Point)(resources.GetObject("btDown.Location")));
			this.btDown.Name = "btDown";
			this.btDown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btDown.RightToLeft")));
			this.btDown.Size = ((System.Drawing.Size)(resources.GetObject("btDown.Size")));
			this.btDown.TabIndex = ((int)(resources.GetObject("btDown.TabIndex")));
			this.btDown.Text = resources.GetString("btDown.Text");
			this.btDown.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btDown.TextAlign")));
			this.btDown.Visible = ((bool)(resources.GetObject("btDown.Visible")));
			this.btDown.Click += new System.EventHandler(this.btDown_Click);
			// 
			// NgbhItemsListView
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.lv);
			this.Controls.Add(this.panel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NgbhItemsListView";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		SimPe.Data.NeighborhoodSlots st;
		public SimPe.Data.NeighborhoodSlots SlotType 
		{
			get {return st;}
			set 
			{
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
			set 
			{
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
			this.cbadd.Items.Clear();

			if (items!=null)
			{
				lv.BeginUpdate();
				foreach (NgbhItem i in items)								
					AddItemToList(i);								
				lv.EndUpdate();

				SetAvailableAddTypes();
			}
		}

		public new void Refresh()
		{
			SetContent();
			base.Refresh();
		}

		void AddItemToList(NgbhItem item)
		{
			NgbhItemsListViewItem lvi = new NgbhItemsListViewItem(this, item); 
		}

		void SetAvailableAddTypes()
		{
			string prefix = typeof(SimMemoryType).Namespace+"."+typeof(SimMemoryType).Name+".";
			SimMemoryType[] sts = Ngbh.AllowedMemoryTypes(st);
			foreach (SimMemoryType mst in sts)				
				cbadd.Items.Add(new Data.Alias((uint)mst, SimPe.Localization.GetString(prefix+ mst.ToString()), "{name}"));
			if (cbadd.Items.Count>0) cbadd.SelectedIndex = 0;
		}

		public void Clear()
		{
			lv.Clear();
			if (lv.SmallImageList!=null)
				lv.SmallImageList.Images.Clear();
		}


		public NgbhItemsListViewItem SelectedItem
		{
			get 
			{
				if (lv.SelectedItems.Count==0) return null;
				else return lv.SelectedItems[0] as NgbhItemsListViewItem;
			}
		}

		internal void UpdateSelected(NgbhItem item)
		{
			if (item==null) return;
			if (SelectedItem==null) return;

			SelectedItem.Update();
			this.Refresh();

			
		}

		public ListView.ListViewItemCollection Items
		{
			get { return lv.Items;}
		}

		ImageList sil;
		public ImageList SmallImageList
		{
			get { return sil;}
			set { 
				lv.SmallImageList = value;
				sil = value;
			}
		}

		public event EventHandler SelectedIndexChanged;

		private void lv_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SelectedIndexChanged!=null) SelectedIndexChanged(this, e);
		}

		private void cbadd_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			lladd.Enabled = cbadd.SelectedIndex>=0 && items!=null;
		}

		private void lv_SelectedIndexChanged_1(object sender, System.EventArgs e)
		{
			lldel.Enabled = (lv.SelectedItems.Count>0 && items!=null);
			if (lv.Items.Count==0 || lv.SelectedItems.Count!=1 || items==null)
			{
				btUp.Enabled = false;
				btDown.Enabled = false;
			} 
			else 
			{
				btUp.Enabled = lldel.Enabled && !lv.Items[0].Selected;
				btDown.Enabled = lldel.Enabled && !lv.Items[lv.Items.Count-1].Selected;
			}
		}

		private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (items==null || cbadd.SelectedIndex<0) return;

			Data.Alias a = cbadd.SelectedItem as Data.Alias;
			SimMemoryType smt = (SimMemoryType)a.Id;

			NgbhItem item = items.AddNew(smt);
			item.SetInitialGuid(smt);
			AddItemToList(item);
			
			lv.Items[lv.Items.Count-1].Selected = true;
			lv.Items[lv.Items.Count-1].EnsureVisible();
		}

		private void lldel_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0 ||items==null) return;
			NgbhItemsListViewItem item = this.SelectedItem;
			lv.Items.Remove(item);
			items.Remove(item.Item);
		}

		void SwapListViewItem(int i1, int i2)
		{
			if (i1<0 || i2<0 || i1>=lv.Items.Count || i2>=lv.Items.Count) return;
			ListViewItem o1 = lv.Items[i1];
			ListViewItem o2 = lv.Items[i2];
			
			lv.Items[i1] = new ListViewItem();
			lv.Items[i2] = o1;
			lv.Items[i1] = o2;
		}

		int SelectedIndex
		{
			get 
			{
				if (lv.SelectedIndices.Count==0) return -1;
				return lv.SelectedIndices[0];
			}
		}

		private void btUp_Click(object sender, System.EventArgs e)
		{
			int index = SelectedIndex;
			items.Swap(index, index-1);
			SwapListViewItem(index, index-1);
		}

		private void btDown_Click(object sender, System.EventArgs e)
		{
			int index = SelectedIndex;
			items.Swap(index, index+1);
			SwapListViewItem(index, index+1);
		}

		
	}
}
