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
		
			

			this.CanCommit = Helper.WindowsRegistry.HiddenMode;
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
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
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
			// pg
			// 
			this.pg.AccessibleDescription = resources.GetString("pg.AccessibleDescription");
			this.pg.AccessibleName = resources.GetString("pg.AccessibleName");
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pg.Anchor")));
			this.pg.BackColor = System.Drawing.SystemColors.Control;
			this.pg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pg.BackgroundImage")));
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pg.Dock")));
			this.pg.Enabled = ((bool)(resources.GetObject("pg.Enabled")));
			this.pg.Font = ((System.Drawing.Font)(resources.GetObject("pg.Font")));
			this.pg.HelpVisible = ((bool)(resources.GetObject("pg.HelpVisible")));
			this.pg.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pg.ImeMode")));
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = ((System.Drawing.Point)(resources.GetObject("pg.Location")));
			this.pg.Name = "pg";
			this.pg.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pg.RightToLeft")));
			this.pg.Size = ((System.Drawing.Size)(resources.GetObject("pg.Size")));
			this.pg.TabIndex = ((int)(resources.GetObject("pg.TabIndex")));
			this.pg.Text = resources.GetString("pg.Text");
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.Visible = ((bool)(resources.GetObject("pg.Visible")));
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
			this.panel1.Controls.Add(this.cb);
			this.panel1.Controls.Add(this.lb);
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
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.Color.Transparent;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.tb);
			this.panel2.Controls.Add(this.pg);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitter1.BackgroundImage")));
			this.splitter1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("splitter1.Dock")));
			this.splitter1.Enabled = ((bool)(resources.GetObject("splitter1.Enabled")));
			this.splitter1.Font = ((System.Drawing.Font)(resources.GetObject("splitter1.Font")));
			this.splitter1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("splitter1.ImeMode")));
			this.splitter1.Location = ((System.Drawing.Point)(resources.GetObject("splitter1.Location")));
			this.splitter1.MinExtra = ((int)(resources.GetObject("splitter1.MinExtra")));
			this.splitter1.MinSize = ((int)(resources.GetObject("splitter1.MinSize")));
			this.splitter1.Name = "splitter1";
			this.splitter1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("splitter1.RightToLeft")));
			this.splitter1.Size = ((System.Drawing.Size)(resources.GetObject("splitter1.Size")));
			this.splitter1.TabIndex = ((int)(resources.GetObject("splitter1.TabIndex")));
			this.splitter1.TabStop = false;
			this.splitter1.Visible = ((bool)(resources.GetObject("splitter1.Visible")));
			// 
			// NhtrUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.panel1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "NhtrUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.panel1, 0);
			this.Controls.SetChildIndex(this.splitter1, 0);
			this.Controls.SetChildIndex(this.panel2, 0);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.ComboBox cb;
		private System.Windows.Forms.PropertyGrid pg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Splitter splitter1;

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
				foreach (NhtrList list in Nhtr.Items)				
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
			if (lb.SelectedItem==null) 
			{
				tb.Text = "";
				pg.SelectedObject = null;
			}
			else 
			{
				tb.Text = ((lb.SelectedItem as CountedListItem ).Object as NhtrItem).ToLongString();
				pg.SelectedObject = ((lb.SelectedItem as CountedListItem ).Object as NhtrItem);
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			lb.Items.Clear();
			if (cb.SelectedItem==null) return;
			
			NhtrList list = (cb.SelectedItem as CountedListItem).Object as NhtrList;
			foreach (NhtrItem i in list)				
				SimPe.CountedListItem.Add(lb, i);
		}		
								
	}
}
