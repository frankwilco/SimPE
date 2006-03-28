using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für BnfoCustomerItemsUI.
	/// </summary>
	[System.ComponentModel.DefaultEvent("SelectedItemChanged")]
	public class BnfoCustomerItemsUI : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BnfoCustomerItemsUI()
		{
			/*SetStyle(
				ControlStyles.SupportsTransparentBackColor |
				ControlStyles.AllPaintingInWmPaint |
				//ControlStyles.Opaque |
				ControlStyles.UserPaint |
				ControlStyles.ResizeRedraw 
				| ControlStyles.DoubleBuffer
				,true);*/

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
			this.lb = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.lb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lb.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lb.HorizontalScrollbar = true;
			this.lb.IntegralHeight = false;
			this.lb.Location = new System.Drawing.Point(0, 0);
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(304, 104);
			this.lb.TabIndex = 0;
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
			// 
			// BnfoCustomerItemsUI
			// 
			this.Controls.Add(this.lb);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "BnfoCustomerItemsUI";
			this.Size = new System.Drawing.Size(304, 104);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ListBox lb;

		Collections.BnfoCustomerItems items;
		[System.ComponentModel.Browsable(false)]
		public Collections.BnfoCustomerItems Items
		{
			get {return items;}
			set 
			{
				items = value;
				SetContent();
			}
		}

		void SetContent()
		{
			lb.Items.Clear();
			if (items!=null)
			{				
				foreach (Plugin.BnfoCustomerItem item in items)
					lb.Items.Add(item);				
			}
			lb_SelectedIndexChanged(lb, new EventArgs());
		}

		public BnfoCustomerItem SelectedItem
		{
			get 
			{
				return lb.SelectedItem as BnfoCustomerItem;
			}
		}

		public new void Refresh()
		{
			SetContent();
			base.Refresh();
		}

		public event System.EventHandler SelectedItemChanged;
		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (SelectedItemChanged!=null) SelectedItemChanged(this, new EventArgs());
		}
	}
}
