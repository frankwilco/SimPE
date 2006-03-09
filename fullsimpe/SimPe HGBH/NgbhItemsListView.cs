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
		private ListView lv;

		public NgbhItemsListView()
		{
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
			this.lv = new System.Windows.Forms.ListView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.cbadd = new TD.SandBar.FlatComboBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(0, 0);
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(136, 150);
			this.lv.TabIndex = 0;
			this.lv.View = System.Windows.Forms.View.List;
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged_1);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lldel);
			this.panel1.Controls.Add(this.lladd);
			this.panel1.Controls.Add(this.cbadd);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(136, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(136, 150);
			this.panel1.TabIndex = 1;
			// 
			// lldel
			// 
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lldel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lldel.Location = new System.Drawing.Point(8, 120);
			this.lldel.Name = "lldel";
			this.lldel.TabIndex = 2;
			this.lldel.TabStop = true;
			this.lldel.Text = "Remove";
			this.lldel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldel_LinkClicked);
			// 
			// lladd
			// 
			this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lladd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lladd.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
			this.lladd.Location = new System.Drawing.Point(8, 72);
			this.lladd.Name = "lladd";
			this.lladd.TabIndex = 1;
			this.lladd.TabStop = true;
			this.lladd.Text = "Create new";
			this.lladd.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lladd_LinkClicked);
			// 
			// cbadd
			// 
			this.cbadd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbadd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbadd.Location = new System.Drawing.Point(24, 96);
			this.cbadd.Name = "cbadd";
			this.cbadd.Size = new System.Drawing.Size(104, 21);
			this.cbadd.TabIndex = 0;
			this.cbadd.SelectedIndexChanged += new System.EventHandler(this.cbadd_SelectedIndexChanged);
			// 
			// NgbhItemsListView
			// 
			this.Controls.Add(this.lv);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NgbhItemsListView";
			this.Size = new System.Drawing.Size(272, 150);
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
		}

		private void lladd_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (items==null || cbadd.SelectedIndex<0) return;

			Data.Alias a = cbadd.SelectedItem as Data.Alias;
			SimMemoryType smt = (SimMemoryType)a.Id;

			AddItemToList(items.AddNew(smt));
			
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
	}
}
