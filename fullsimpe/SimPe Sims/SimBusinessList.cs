using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.PackedFiles.Wrapper
{
	/// <summary>
	/// Zusammenfassung für SimBusinessList.
	/// </summary>
	public class SimBusinessList : System.Windows.Forms.UserControl
	{
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public SimBusinessList()
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

            if (!DesignMode) SetContent();
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
			this.cb = new TD.SandBar.FlatComboBox();
			this.SuspendLayout();
			// 
			// cb
			// 
			this.cb.Dock = System.Windows.Forms.DockStyle.Top;
			this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb.Location = new System.Drawing.Point(0, 0);
			this.cb.Name = "cb";
			this.cb.Size = new System.Drawing.Size(150, 21);
			this.cb.TabIndex = 0;
			this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
			// 
			// SimBusinessList
			// 
			this.Controls.Add(this.cb);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "SimBusinessList";
			this.Size = new System.Drawing.Size(150, 24);
			this.ResumeLayout(false);

		}
		#endregion

		private TD.SandBar.FlatComboBox cb;

		bool loaded;
		LinkedSDesc sdsc;
		public SimPe.Interfaces.Wrapper.ISDesc SimDescription
		{
			get { return sdsc;}
			set 
			{
				sdsc = value as LinkedSDesc;
				SetContent();
			}
		}

		void SetContent()
		{
			loaded = Visible;
			if (!loaded) return;
			cb.Items.Clear();
			if (sdsc!=null) 
			{
				SimPe.Interfaces.Providers.ILotItem[] items = sdsc.BusinessList;
				foreach (SimPe.Interfaces.Providers.ILotItem item in items)				
					cb.Items.Add(item);
				
				if (cb.Items.Count>0) cb.SelectedIndex = 0;
				else if (SelectedBusinessChanged!=null) SelectedBusinessChanged(this, new EventArgs());
			}
		}

		public event System.EventHandler SelectedBusinessChanged;

		public SimPe.Interfaces.Providers.ILotItem SelectedBusiness
		{
			get {return cb.SelectedItem as SimPe.Interfaces.Providers.ILotItem;}			
		}

		private void cb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (SelectedBusinessChanged!=null) SelectedBusinessChanged(this, new EventArgs());
		}

		protected override void OnVisibleChanged(EventArgs e)
		{
			if (!loaded) SetContent();
		}
	
	}
}
