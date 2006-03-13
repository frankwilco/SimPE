using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für BnfoCustomerItemUI.
	/// </summary>
	public class BnfoCustomerItemUI : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BnfoCustomerItemUI()
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

			SetContent();
		}

		/// <summary> 
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				BnfoCustomerItemsUI = null;
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
			this.tb = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbap = new System.Windows.Forms.TextBox();
			this.tbloy = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// tb
			// 
			this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left)));
			this.tb.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tb.HideSelection = false;
			this.tb.Location = new System.Drawing.Point(8, 64);
			this.tb.Multiline = true;
			this.tb.Name = "tb";
			this.tb.ReadOnly = true;
			this.tb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb.Size = new System.Drawing.Size(400, 144);
			this.tb.TabIndex = 0;
			this.tb.Text = "00 00 00 00  00 00 00 00  00 00 00 00  00 00 00 00  00 00 00 00";
			this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Appraisal:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Loyalty:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbap
			// 
			this.tbap.Location = new System.Drawing.Point(80, 8);
			this.tbap.Name = "tbap";
			this.tbap.TabIndex = 3;
			this.tbap.Text = "";
			this.tbap.TextChanged += new System.EventHandler(this.tbap_TextChanged);
			// 
			// tbloy
			// 
			this.tbloy.Location = new System.Drawing.Point(80, 32);
			this.tbloy.Name = "tbloy";
			this.tbloy.TabIndex = 4;
			this.tbloy.Text = "";
			this.tbloy.TextChanged += new System.EventHandler(this.tbloy_TextChanged);
			// 
			// BnfoCustomerItemUI
			// 
			this.Controls.Add(this.tbloy);
			this.Controls.Add(this.tbap);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tb);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "BnfoCustomerItemUI";
			this.Size = new System.Drawing.Size(472, 216);
			this.ResumeLayout(false);

		}
		#endregion

		BnfoCustomerItem item;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbap;
		private System.Windows.Forms.TextBox tbloy;
	
		[System.ComponentModel.Browsable(false)]
		public BnfoCustomerItem Item
		{
			get {return item;}
			set 
			{
				item = value;
				SetContent();
			}
		}

		BnfoCustomerItemsUI ui;
		public BnfoCustomerItemsUI BnfoCustomerItemsUI
		{
			get {return ui;}
			set 
			{
				if (ui!=null) ui.SelectedItemChanged -= new EventHandler(ui_SelectedItemChanged);
				ui = value;
				if (ui!=null) 
				{
					ui.SelectedItemChanged += new EventHandler(ui_SelectedItemChanged);
					ui_SelectedItemChanged(ui, null);
				}
			}
		}

		bool intern;
		void SetContent()
		{
			if (intern) return;
			intern = true;
			if (item!=null) 
			{
				tb.Text = Helper.BytesToHexList(item.Data);
				tbap.Text = item.LoyaltyScore.ToString();
				this.tbloy.Text = item.DisplayedLoyalty.ToString();
			} 
			else 
			{
				tb.Text = "";
			}
			intern = false;
		}

		private void ui_SelectedItemChanged(object sender, EventArgs e)
		{
			Item = ui.SelectedItem;
		}

		private void tb_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void tbloy_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (item==null) return;

			item.DisplayedLoyalty = Helper.StringToInt32(tbloy.Text, item.DisplayedLoyalty, 10);
		}

		private void tbap_TextChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (item==null) return;

			item.LoyaltyScore = Helper.StringToInt32(tbap.Text, item.LoyaltyScore, 10);
		}
	}
}
