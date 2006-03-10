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
			this.lv = new SimPe.Plugin.NgbhSlotListView();
			this.cb = new Ambertation.Windows.Forms.EnumComboBox();
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lv.DockPadding.All = 1;
			this.lv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lv.Location = new System.Drawing.Point(0, 24);
			this.lv.Name = "lv";
			this.lv.NgbhResource = null;
			this.lv.Size = new System.Drawing.Size(424, 176);
			this.lv.Slot = null;
			this.lv.Slots = null;
			this.lv.SlotType = SimPe.Data.NeighborhoodSlots.LotsIntern;
			this.lv.TabIndex = 0;
			this.lv.SelectedSlotChanged += new System.EventHandler(this.lv_SelectedSlotChanged);
			// 
			// cb
			// 
			this.cb.Dock = System.Windows.Forms.DockStyle.Top;
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Enum = null;
			this.cb.Location = new System.Drawing.Point(0, 0);
			this.cb.Name = "cb";
			this.cb.ResourceManager = null;
			this.cb.Size = new System.Drawing.Size(424, 21);
			this.cb.TabIndex = 1;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// NgbhSlotSelection
			// 
			this.Controls.Add(this.cb);
			this.Controls.Add(this.lv);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "NgbhSlotSelection";
			this.Size = new System.Drawing.Size(424, 200);
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
