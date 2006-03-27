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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;
using SimPe.Windows.Forms;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NhtrUI.
	/// </summary>
	public class NhtrUI : 
		//System.Windows.Forms.UserControl
		SimPe.Windows.Forms.WrapperBaseControl, SimPe.Interfaces.Plugin.IPackedFileUI
	{
		
		
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		

		public NhtrUI()
		{			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();	
		
			

			this.CanCommit = false;
			//ThemeManager.AddControl(this.toolBar1);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NhtrUI));
			this.lb = new System.Windows.Forms.ListBox();
			this.tb = new System.Windows.Forms.TextBox();
			this.cb = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lb
			// 
			this.lb.AccessibleDescription = resources.GetString("lb.AccessibleDescription");
			this.lb.AccessibleName = resources.GetString("lb.AccessibleName");
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lb.Anchor")));
			this.lb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lb.BackgroundImage")));
			this.lb.ColumnWidth = ((int)(resources.GetObject("lb.ColumnWidth")));
			this.lb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lb.Dock")));
			this.lb.Enabled = ((bool)(resources.GetObject("lb.Enabled")));
			this.lb.Font = ((System.Drawing.Font)(resources.GetObject("lb.Font")));
			this.lb.HorizontalExtent = ((int)(resources.GetObject("lb.HorizontalExtent")));
			this.lb.HorizontalScrollbar = ((bool)(resources.GetObject("lb.HorizontalScrollbar")));
			this.lb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lb.ImeMode")));
			this.lb.IntegralHeight = ((bool)(resources.GetObject("lb.IntegralHeight")));
			this.lb.ItemHeight = ((int)(resources.GetObject("lb.ItemHeight")));
			this.lb.Location = ((System.Drawing.Point)(resources.GetObject("lb.Location")));
			this.lb.Name = "lb";
			this.lb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lb.RightToLeft")));
			this.lb.ScrollAlwaysVisible = ((bool)(resources.GetObject("lb.ScrollAlwaysVisible")));
			this.lb.Size = ((System.Drawing.Size)(resources.GetObject("lb.Size")));
			this.lb.TabIndex = ((int)(resources.GetObject("lb.TabIndex")));
			this.lb.Visible = ((bool)(resources.GetObject("lb.Visible")));
			this.lb.SelectedIndexChanged += new System.EventHandler(this.lb_SelectedIndexChanged);
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
			this.cb.Font = ((System.Drawing.Font)(resources.GetObject("cb.Font")));
			this.cb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cb.ImeMode")));
			this.cb.IntegralHeight = ((bool)(resources.GetObject("cb.IntegralHeight")));
			this.cb.ItemHeight = ((int)(resources.GetObject("cb.ItemHeight")));
			this.cb.Location = ((System.Drawing.Point)(resources.GetObject("cb.Location")));
			this.cb.MaxDropDownItems = ((int)(resources.GetObject("cb.MaxDropDownItems")));
			this.cb.MaxLength = ((int)(resources.GetObject("cb.MaxLength")));
			this.cb.Name = "cb";
			this.cb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cb.RightToLeft")));
			this.cb.Size = ((System.Drawing.Size)(resources.GetObject("cb.Size")));
			this.cb.TabIndex = ((int)(resources.GetObject("cb.TabIndex")));
			this.cb.Text = resources.GetString("cb.Text");
			this.cb.Visible = ((bool)(resources.GetObject("cb.Visible")));
			this.cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// NhtrUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.cb);
			this.Controls.Add(this.tb);
			this.Controls.Add(this.lb);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NhtrUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.lb, 0);
			this.Controls.SetChildIndex(this.tb, 0);
			this.Controls.SetChildIndex(this.cb, 0);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.ComboBox cb;

		public Nhtr Nhtr
		{
			get { return (Nhtr)Wrapper; }
		}

		bool intern;
		protected override void RefreshGUI()
		{			
			if (intern) return;
			
			intern = true;
			lb.Items.Clear();
			cb.Items.Clear();
			if (Nhtr!=null) 
			{				
				foreach (ArrayList list in Nhtr.Items)				
					SimPe.CountedListItem.Add(cb, list);	
				
				if (cb.Items.Count>0) cb.SelectedIndex = 0;

				lb.Enabled = true;
				this.Enabled = true;
			} 
			else 
			{
				
			}

			intern=false;
		}

		public override void OnCommit()
		{
			Nhtr.SynchronizeUserData(true, false);
		}

		private void lb_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lb.SelectedItem==null) tb.Text = "";
			else tb.Text = Helper.BytesToHexList(((lb.SelectedItem as CountedListItem ).Object as NhtrItem).Data, 8);
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			lb.Items.Clear();
			if (cb.SelectedItem==null) return;
			
			ArrayList list = (cb.SelectedItem as CountedListItem).Object as ArrayList;
			foreach (NhtrItem i in list)				
				SimPe.CountedListItem.Add(lb, i);
		}		
								
	}
}
