using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhSlotSelection.
	/// </summary>
	[System.ComponentModel.DefaultEvent("SelectedSlotChanged")]
	public class NgbhSlotSelection : System.Windows.Forms.UserControl
	{
		private SimPe.Plugin.NgbhSlotListView lv;
		private Ambertation.Windows.Forms.EnumComboBox cb;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public NgbhSlotSelection()
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

			cb.Enum = typeof(Data.NeighborhoodSlots);
			cb.ResourceManager = SimPe.Localization.Manager;
			cb.SelectedIndex = 0;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhSlotSelection));
			this.lv = new SimPe.Plugin.NgbhSlotListView();
			this.cb = new Ambertation.Windows.Forms.EnumComboBox();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.AutoScroll = ((bool)(resources.GetObject("lv.AutoScroll")));
			this.lv.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("lv.AutoScrollMargin")));
			this.lv.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("lv.AutoScrollMinSize")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.DockPadding.All = 1;
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.NgbhResource = null;
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.Slot = null;
			this.lv.Slots = null;
			this.lv.SlotType = SimPe.Data.NeighborhoodSlots.LotsIntern;
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedSlotChanged += new System.EventHandler(this.lv_SelectedSlotChanged);
			// 
			// cb
			// 
			this.cb.AccessibleDescription = resources.GetString("cb.AccessibleDescription");
			this.cb.AccessibleName = resources.GetString("cb.AccessibleName");
			this.cb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cb.Anchor")));
			this.cb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cb.BackgroundImage")));			
			this.cb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cb.Dock")));
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Enabled = ((bool)(resources.GetObject("cb.Enabled")));
			this.cb.Enum = null;
			this.cb.Font = ((System.Drawing.Font)(resources.GetObject("cb.Font")));
			this.cb.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cb.ImeMode")));
			this.cb.IntegralHeight = ((bool)(resources.GetObject("cb.IntegralHeight")));
			this.cb.ItemHeight = ((int)(resources.GetObject("cb.ItemHeight")));
			this.cb.Location = ((System.Drawing.Point)(resources.GetObject("cb.Location")));
			this.cb.MaxDropDownItems = ((int)(resources.GetObject("cb.MaxDropDownItems")));
			this.cb.MaxLength = ((int)(resources.GetObject("cb.MaxLength")));
			this.cb.Name = "cb";
			this.cb.ResourceManager = null;
			this.cb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cb.RightToLeft")));
			this.cb.Size = ((System.Drawing.Size)(resources.GetObject("cb.Size")));
			this.cb.TabIndex = ((int)(resources.GetObject("cb.TabIndex")));
			this.cb.Text = resources.GetString("cb.Text");
			this.cb.Visible = ((bool)(resources.GetObject("cb.Visible")));
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// NgbhSlotSelection
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.cb);
			this.Controls.Add(this.lv);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NgbhSlotSelection";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		private void cb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cb.SelectedIndex>=0)
			{
				lv.SlotType = SlotType;
				SetContent();
			}
		}

		Ngbh ngbh;
		[System.ComponentModel.Browsable(false)]
		public Ngbh NgbhResource
		{
			get {return ngbh;}
			set 
			{
				ngbh = value;
				lv.NgbhResource = ngbh;			
			}
		}

		void SetContent()
		{			
			lv.SlotType = SlotType;
		}

		private void lv_SelectedSlotChanged(object sender, System.EventArgs e)
		{
			if (SelectedSlotChanged!=null) SelectedSlotChanged(this, e);
		}

					

		public NgbhSlot SelectedSlot
		{
			get 
			{
				return lv.SelectedSlot;
			}
		}

		public Data.NeighborhoodSlots SlotType 
		{
			get {
				if (cb.SelectedIndex<0) return Data.NeighborhoodSlots.Lots;
				return (Data.NeighborhoodSlots)cb.SelectedValue;
			}
		}

		public event EventHandler SelectedSlotChanged;

		
	}
}
