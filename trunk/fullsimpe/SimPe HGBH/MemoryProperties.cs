using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Cache;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MemoryProperties.
	/// </summary>
	public class MemoryProperties : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public MemoryProperties()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

			try 
			{
				this.cbtype.Enum = typeof(SimMemoryType);
				this.cbtype.ResourceManager = SimPe.Localization.Manager;

				foreach (MemoryCacheItem mci in NgbhUI.ObjectCache.List) 
				{
					Data.Alias a = new SimPe.Data.Alias(mci.Guid, mci.Name);
					a.Tag = new object[] {mci};
					if (mci.IsToken ) cbToks.Items.Add(a);
					else if (mci.IsMemory) cbMems.Items.Add(a);
					else if (mci.IsInventory) cbObjs.Items.Add(a);
				}

				cbToks.Sorted = true;
				cbMems.Sorted = true;
				cbObjs.Sorted = true;

				SetContent();
			} 
			catch {}
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
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.tabControl2 = new TD.SandDock.TabControl();
			this.tabPage3 = new TD.SandDock.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.cbToks = new TD.SandBar.FlatComboBox();
			this.cbMems = new TD.SandBar.FlatComboBox();
			this.lbtype = new System.Windows.Forms.Label();
			this.cbtype = new Ambertation.Windows.Forms.EnumComboBox();
			this.tabPage4 = new TD.SandDock.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.llSetRawLength = new System.Windows.Forms.LinkLabel();
			this.tbRawLength = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cbObjs = new TD.SandBar.FlatComboBox();
			this.pb = new System.Windows.Forms.PictureBox();
			this.tabControl2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pg
			// 
			this.pg.CommandsBackColor = System.Drawing.SystemColors.ControlLight;
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(0, 0);
			this.pg.Name = "pg";
			this.pg.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pg.Size = new System.Drawing.Size(460, 272);
			this.pg.TabIndex = 0;
			this.pg.Text = "pg";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pg_PropertyValueChanged);
			// 
			// tabControl2
			// 
			this.tabControl2.BorderStyle = TD.SandDock.Rendering.BorderStyle.None;
			this.tabControl2.Controls.Add(this.tabPage3);
			this.tabControl2.Controls.Add(this.tabPage4);
			this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl2.LayoutSystem = new TD.SandDock.SplitLayoutSystem(250, 400, System.Windows.Forms.Orientation.Horizontal, new TD.SandDock.LayoutSystemBase[] {
																																											new TD.SandDock.DocumentLayoutSystem(464, 328, new TD.SandDock.DockControl[] {
																																																															 this.tabPage3,
																																																															 this.tabPage4}, this.tabPage4)});
			this.tabControl2.Location = new System.Drawing.Point(0, 0);
			this.tabControl2.Name = "tabControl2";
			this.tabControl2.Size = new System.Drawing.Size(464, 328);
			this.tabControl2.TabIndex = 3;
			// 
			// tabPage3
			// 
			this.tabPage3.AutoScroll = true;
			this.tabPage3.Controls.Add(this.pb);
			this.tabPage3.Controls.Add(this.label2);
			this.tabPage3.Controls.Add(this.lbtype);
			this.tabPage3.Controls.Add(this.cbtype);
			this.tabPage3.Controls.Add(this.cbToks);
			this.tabPage3.Controls.Add(this.cbMems);
			this.tabPage3.Controls.Add(this.cbObjs);
			this.tabPage3.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage3.Guid = new System.Guid("4e851d66-304f-4d0f-9896-8d73154946f3");
			this.tabPage3.Location = new System.Drawing.Point(2, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(460, 304);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.TabText = "Properties";
			this.tabPage3.Text = "Properties";
			this.tabPage3.VisibleChanged += new System.EventHandler(this.tabPage3_VisibleChanged);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 23);
			this.label2.TabIndex = 11;
			this.label2.Text = "Name:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbToks
			// 
			this.cbToks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbToks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbToks.Location = new System.Drawing.Point(72, 32);
			this.cbToks.Name = "cbToks";
			this.cbToks.Size = new System.Drawing.Size(320, 21);
			this.cbToks.TabIndex = 10;
			this.cbToks.SelectedIndexChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// cbMems
			// 
			this.cbMems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbMems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbMems.Location = new System.Drawing.Point(72, 32);
			this.cbMems.Name = "cbMems";
			this.cbMems.Size = new System.Drawing.Size(320, 21);
			this.cbMems.TabIndex = 9;
			this.cbMems.SelectedIndexChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// lbtype
			// 
			this.lbtype.Location = new System.Drawing.Point(8, 8);
			this.lbtype.Name = "lbtype";
			this.lbtype.Size = new System.Drawing.Size(56, 23);
			this.lbtype.TabIndex = 8;
			this.lbtype.Text = "Type:";
			this.lbtype.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbtype
			// 
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = false;
			this.cbtype.Enum = null;
			this.cbtype.Location = new System.Drawing.Point(72, 8);
			this.cbtype.Name = "cbtype";
			this.cbtype.ResourceManager = null;
			this.cbtype.Size = new System.Drawing.Size(320, 21);
			this.cbtype.TabIndex = 0;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.tabPage4.Controls.Add(this.pg);
			this.tabPage4.Controls.Add(this.panel1);
			this.tabPage4.FloatingSize = new System.Drawing.Size(550, 400);
			this.tabPage4.Guid = new System.Guid("3b0d25ef-e354-4693-8339-f171a2b4f000");
			this.tabPage4.Location = new System.Drawing.Point(2, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(460, 304);
			this.tabPage4.TabIndex = 1;
			this.tabPage4.TabText = "Raw Data";
			this.tabPage4.Text = "Raw Data";
			this.tabPage4.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.llSetRawLength);
			this.panel1.Controls.Add(this.tbRawLength);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 272);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(460, 32);
			this.panel1.TabIndex = 9;
			// 
			// llSetRawLength
			// 
			this.llSetRawLength.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llSetRawLength.Location = new System.Drawing.Point(168, 8);
			this.llSetRawLength.Name = "llSetRawLength";
			this.llSetRawLength.Size = new System.Drawing.Size(48, 23);
			this.llSetRawLength.TabIndex = 9;
			this.llSetRawLength.TabStop = true;
			this.llSetRawLength.Text = "Set";
			this.llSetRawLength.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			this.llSetRawLength.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llSetRawLength_LinkClicked);
			// 
			// tbRawLength
			// 
			this.tbRawLength.Location = new System.Drawing.Point(64, 8);
			this.tbRawLength.Name = "tbRawLength";
			this.tbRawLength.TabIndex = 8;
			this.tbRawLength.Text = "0";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Length:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbObjs
			// 
			this.cbObjs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbObjs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbObjs.Location = new System.Drawing.Point(72, 32);
			this.cbObjs.Name = "cbObjs";
			this.cbObjs.Size = new System.Drawing.Size(320, 21);
			this.cbObjs.TabIndex = 12;
			this.cbObjs.SelectedIndexChanged += new System.EventHandler(this.ChangeGuid);
			// 
			// pb
			// 
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pb.Location = new System.Drawing.Point(400, 0);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(64, 64);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pb.TabIndex = 13;
			this.pb.TabStop = false;
			// 
			// MemoryProperties
			// 
			this.Controls.Add(this.tabControl2);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "MemoryProperties";
			this.Size = new System.Drawing.Size(464, 328);
			this.tabControl2.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		NgbhItem item;
		private System.Windows.Forms.PropertyGrid pg;
		private TD.SandDock.TabControl tabControl2;
		private TD.SandDock.TabPage tabPage3;
		private TD.SandDock.TabPage tabPage4;
		private System.Windows.Forms.TextBox tbRawLength;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel llSetRawLength;
		private System.Windows.Forms.Label lbtype;
		private Ambertation.Windows.Forms.EnumComboBox cbtype;
		private TD.SandBar.FlatComboBox cbMems;
		private TD.SandBar.FlatComboBox cbToks;
		private System.Windows.Forms.Label label2;
		private TD.SandBar.FlatComboBox cbObjs;
		private System.Windows.Forms.PictureBox pb;
	
		[System.ComponentModel.Browsable(false)]
		public NgbhItem Item
		{
			get {return item;}
			set 
			{
				item = value;
				SetContent();
			}
		}

		Plugin.NgbhItemsListView nilv;
		public Plugin.NgbhItemsListView NgbhItemsListView
		{
			get {return nilv;}
			set 
			{
				if (nilv!=null) nilv.SelectedIndexChanged -= new EventHandler(nilv_SelectedIndexChanged);
				nilv = value;
				if (nilv!=null) nilv.SelectedIndexChanged += new EventHandler(nilv_SelectedIndexChanged);

				nilv_SelectedIndexChanged(null, null);
			}
		}

		public event EventHandler ChangedItem;
		protected void UpdateNgbhItemsListView()
		{
			if (nilv!=null) nilv.UpdateSelected(item);
		}
		protected void FireChangeEvent()
		{			
			UpdateNgbhItemsListView();
			if (ChangedItem!=null) ChangedItem(this, new EventArgs());
		}

		bool inter;
		bool chgraw;
		void SetContent()
		{
			if (inter) return;	inter = true;
			chgraw = false;
			pg.SelectedObject = null;
			pb.Image = null;
			if (item!=null)
			{
				this.Enabled = true;
				Hashtable ht = new Hashtable();
				byte ct=0;
				foreach (string v in item.MemoryCacheItem.ValueNames)
					ht[Helper.HexString(ct)+": "+v] = new Ambertation.BaseChangeableNumber(item.GetValue(ct++));

				while (ct<item.Data.Length) 				
					ht[Helper.HexString(ct)+":"] = new Ambertation.BaseChangeableNumber(item.GetValue(ct++));				

				Ambertation.PropertyObjectBuilderExt pob = new Ambertation.PropertyObjectBuilderExt(ht);
				
				pg.SelectedObject = pob.Instance;

				this.tbRawLength.Text = item.Data.Length.ToString();
				this.cbtype.SelectedValue = item.MemoryType;

				UpdateSelectedItem();

				pb.Image = item.MemoryCacheItem.Image;
			} 
			else 
			{
				this.Enabled = false;
			}
			inter = false;
		}

		void UpdateSelectedItem()
		{
			this.cbMems.Visible = (!item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory);
			this.cbToks.Visible = (item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory);
			this.cbObjs.Visible = (!item.MemoryCacheItem.IsToken && item.MemoryCacheItem.IsInventory);

			if ((!item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory)) SelectNgbhItem(cbMems, item);
			if ((item.MemoryCacheItem.IsToken && !item.MemoryCacheItem.IsInventory)) SelectNgbhItem(cbToks, item);
			if ((!item.MemoryCacheItem.IsToken && item.MemoryCacheItem.IsInventory)) SelectNgbhItem(cbObjs, item);
		}

		void SelectNgbhItem(TD.SandBar.FlatComboBox cb, NgbhItem item)
		{
			for (int i=0; i<cb.Items.Count; i++)
			{
				SimPe.Interfaces.IAlias a = cb.Items[i] as SimPe.Interfaces.IAlias;
				if (a.Id == item.Guid) 
				{
					cb.SelectedIndex = i;
					return;
				}
			}
			cb.SelectedIndex = -1;
			cb.Refresh();
		}

		private void nilv_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (nilv!=null) 
			{
				Plugin.NgbhItemsListViewItem lvi = nilv.SelectedItem;
				if (lvi!=null)
					Item = lvi.Item;
				else 
					Item = null;
			} 
			else 
				Item = null;
		}

		private void llSetRawLength_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.item!=null)
			{
				ushort[] ndata = new ushort[Helper.StringToInt32(this.tbRawLength.Text, item.Data.Length, 10)];
				for (int i=0; i<ndata.Length; i++)
					if (i<item.Data.Length) ndata[i] = item.Data[i];
					else ndata[i] = 0;
				item.Data = ndata;
				SetContent();
			}
		}

		private void ChangeGuid(object sender, System.EventArgs e)
		{
			if (inter) return;
			if (item==null) return;
			TD.SandBar.FlatComboBox cb = sender as TD.SandBar.FlatComboBox;
			SimPe.Interfaces.IAlias a = cb.SelectedItem as SimPe.Interfaces.IAlias;
			if (a!=null)
			{
				item.Guid = a.Id;
				SetContent();
				this.FireChangeEvent();				
			}
		}

		private void pg_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			if (item==null) return;
			string[] n = e.ChangedItem.Label.Split(new char[] {':'}, 2);
			if (n.Length>0)
			{
				int v = Helper.StringToInt32(n[0], -1, 16);
				if (v>=0) 
				{
					item.PutValue(v, (ushort)((Ambertation.BaseChangeableNumber)e.ChangedItem.Value).Value);
					chgraw = true;
					UpdateNgbhItemsListView();
				}
			}
		}

		private void tabPage3_VisibleChanged(object sender, System.EventArgs e)
		{
			if (this.tabPage3.Visible && chgraw) 
			{
				SetContent();				
			}
		}
	}
}
