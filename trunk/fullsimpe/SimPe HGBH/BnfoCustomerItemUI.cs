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

			try 
			{
				tb.Visible = Helper.WindowsRegistry.HiddenMode;
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(BnfoCustomerItemUI));
			this.tb = new System.Windows.Forms.TextBox();
			this.pb = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.SuspendLayout();
			// 
			// tb
			// 
			this.tb.AccessibleDescription = resources.GetString("tb.AccessibleDescription");
			this.tb.AccessibleName = resources.GetString("tb.AccessibleName");
			this.tb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tb.Anchor")));
			this.tb.AutoSize = ((bool)(resources.GetObject("tb.AutoSize")));
			this.tb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tb.BackgroundImage")));
			this.tb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tb.Dock")));
			this.tb.Enabled = ((bool)(resources.GetObject("tb.Enabled")));
			this.tb.Font = ((System.Drawing.Font)(resources.GetObject("tb.Font")));
			this.tb.HideSelection = false;
			this.tb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tb.ImeMode")));
			this.tb.Location = ((System.Drawing.Point)(resources.GetObject("tb.Location")));
			this.tb.MaxLength = ((int)(resources.GetObject("tb.MaxLength")));
			this.tb.Multiline = ((bool)(resources.GetObject("tb.Multiline")));
			this.tb.Name = "tb";
			this.tb.PasswordChar = ((char)(resources.GetObject("tb.PasswordChar")));
			this.tb.ReadOnly = true;
			this.tb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tb.RightToLeft")));
			this.tb.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tb.ScrollBars")));
			this.tb.Size = ((System.Drawing.Size)(resources.GetObject("tb.Size")));
			this.tb.TabIndex = ((int)(resources.GetObject("tb.TabIndex")));
			this.tb.Text = resources.GetString("tb.Text");
			this.tb.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tb.TextAlign")));
			this.tb.Visible = ((bool)(resources.GetObject("tb.Visible")));
			this.tb.WordWrap = ((bool)(resources.GetObject("tb.WordWrap")));
			this.tb.TextChanged += new System.EventHandler(this.tb_TextChanged);
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.AutoScroll = ((bool)(resources.GetObject("pb.AutoScroll")));
			this.pb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pb.AutoScrollMargin")));
			this.pb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pb.AutoScrollMinSize")));
			this.pb.BackColor = System.Drawing.Color.Transparent;
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.DisplayOffset = 0;
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.DockPadding.Bottom = 5;
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.LabelText = resources.GetString("pb.LabelText");
			this.pb.LabelWidth = ((int)(resources.GetObject("pb.LabelWidth")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Maximum = 2000;
			this.pb.Name = "pb";
			this.pb.NumberFormat = "N0";
			this.pb.NumberOffset = -1000;
			this.pb.NumberScale = 0.005;
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.SelectedColor = System.Drawing.Color.Gold;
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TextboxWidth = ((int)(resources.GetObject("pb.TextboxWidth")));
			this.pb.TokenCount = 11;
			this.pb.UnselectedColor = System.Drawing.Color.Black;
			this.pb.Value = 1000;
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			this.pb.ChangedValue += new System.EventHandler(this.pb_Changed);
			// 
			// BnfoCustomerItemUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.pb);
			this.Controls.Add(this.tb);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "BnfoCustomerItemUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.ResumeLayout(false);

		}
		#endregion

		BnfoCustomerItem item;
		private System.Windows.Forms.TextBox tb;
	
		[System.ComponentModel.Browsable(false)]
		public BnfoCustomerItem Item
		{
			get {return item;}
			set 
			{
				/*if (item!=null) 
				{
					item.LoyaltyScore = pb.Value;
				}*/
				item = value;
				SetContent();
			}
		}

		BnfoCustomerItemsUI ui;
		private Ambertation.Windows.Forms.LabeledProgressBar pb;
	
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
				pb.Value = item.LoyaltyScore;				
				pb.Enabled = true;
			} 
			else 
			{
				tb.Text = "";
				pb.Value = 0;
				pb.Enabled = false;
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

		private void pb_Changed(object sender, System.EventArgs e)
		{
			if (intern) return;
			if (item==null) return;
			if (pb.Value<0 && pb.SelectedColor!=Color.Coral) 
			{
				pb.SelectedColor = Color.Coral;
				pb.CompleteRedraw();
			}
			else if (pb.Value>=0 && pb.SelectedColor!=Color.Gold) 
			{
				pb.SelectedColor = Color.Gold;
				pb.CompleteRedraw();
			}

			item.LoyaltyScore = pb.Value;
		}
	}
}
