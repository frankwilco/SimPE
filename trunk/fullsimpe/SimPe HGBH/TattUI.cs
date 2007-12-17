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
using SimPe.Interfaces.Plugin;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace SimPe.Plugin 
{
	/// <summary>
	/// Zusammenfassung für TattUI.
	/// </summary>
	public class TattUI : 
		SimPe.Windows.Forms.WrapperBaseControl
		//System.Windows.Forms.UserControl
	{
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbVer;
		private System.Windows.Forms.TextBox tbRes;
		private System.Windows.Forms.TextBox tbFlname;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox lb;
		private System.ComponentModel.IContainer components;

		public TattUI()
		{
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TattUI));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbVer = new System.Windows.Forms.TextBox();
			this.tbRes = new System.Windows.Forms.TextBox();
			this.tbFlname = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// tbVer
			// 
			this.tbVer.AccessibleDescription = resources.GetString("tbVer.AccessibleDescription");
			this.tbVer.AccessibleName = resources.GetString("tbVer.AccessibleName");
			this.tbVer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbVer.Anchor")));
			this.tbVer.AutoSize = ((bool)(resources.GetObject("tbVer.AutoSize")));
			this.tbVer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbVer.BackgroundImage")));
			this.tbVer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbVer.Dock")));
			this.tbVer.Enabled = ((bool)(resources.GetObject("tbVer.Enabled")));
			this.tbVer.Font = ((System.Drawing.Font)(resources.GetObject("tbVer.Font")));
			this.tbVer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbVer.ImeMode")));
			this.tbVer.Location = ((System.Drawing.Point)(resources.GetObject("tbVer.Location")));
			this.tbVer.MaxLength = ((int)(resources.GetObject("tbVer.MaxLength")));
			this.tbVer.Multiline = ((bool)(resources.GetObject("tbVer.Multiline")));
			this.tbVer.Name = "tbVer";
			this.tbVer.PasswordChar = ((char)(resources.GetObject("tbVer.PasswordChar")));
			this.tbVer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbVer.RightToLeft")));
			this.tbVer.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbVer.ScrollBars")));
			this.tbVer.Size = ((System.Drawing.Size)(resources.GetObject("tbVer.Size")));
			this.tbVer.TabIndex = ((int)(resources.GetObject("tbVer.TabIndex")));
			this.tbVer.Text = resources.GetString("tbVer.Text");
			this.tbVer.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbVer.TextAlign")));
			this.tbVer.Visible = ((bool)(resources.GetObject("tbVer.Visible")));
			this.tbVer.WordWrap = ((bool)(resources.GetObject("tbVer.WordWrap")));
			// 
			// tbRes
			// 
			this.tbRes.AccessibleDescription = resources.GetString("tbRes.AccessibleDescription");
			this.tbRes.AccessibleName = resources.GetString("tbRes.AccessibleName");
			this.tbRes.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbRes.Anchor")));
			this.tbRes.AutoSize = ((bool)(resources.GetObject("tbRes.AutoSize")));
			this.tbRes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbRes.BackgroundImage")));
			this.tbRes.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbRes.Dock")));
			this.tbRes.Enabled = ((bool)(resources.GetObject("tbRes.Enabled")));
			this.tbRes.Font = ((System.Drawing.Font)(resources.GetObject("tbRes.Font")));
			this.tbRes.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbRes.ImeMode")));
			this.tbRes.Location = ((System.Drawing.Point)(resources.GetObject("tbRes.Location")));
			this.tbRes.MaxLength = ((int)(resources.GetObject("tbRes.MaxLength")));
			this.tbRes.Multiline = ((bool)(resources.GetObject("tbRes.Multiline")));
			this.tbRes.Name = "tbRes";
			this.tbRes.PasswordChar = ((char)(resources.GetObject("tbRes.PasswordChar")));
			this.tbRes.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbRes.RightToLeft")));
			this.tbRes.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbRes.ScrollBars")));
			this.tbRes.Size = ((System.Drawing.Size)(resources.GetObject("tbRes.Size")));
			this.tbRes.TabIndex = ((int)(resources.GetObject("tbRes.TabIndex")));
			this.tbRes.Text = resources.GetString("tbRes.Text");
			this.tbRes.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbRes.TextAlign")));
			this.tbRes.Visible = ((bool)(resources.GetObject("tbRes.Visible")));
			this.tbRes.WordWrap = ((bool)(resources.GetObject("tbRes.WordWrap")));
			// 
			// tbFlname
			// 
			this.tbFlname.AccessibleDescription = resources.GetString("tbFlname.AccessibleDescription");
			this.tbFlname.AccessibleName = resources.GetString("tbFlname.AccessibleName");
			this.tbFlname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbFlname.Anchor")));
			this.tbFlname.AutoSize = ((bool)(resources.GetObject("tbFlname.AutoSize")));
			this.tbFlname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFlname.BackgroundImage")));
			this.tbFlname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbFlname.Dock")));
			this.tbFlname.Enabled = ((bool)(resources.GetObject("tbFlname.Enabled")));
			this.tbFlname.Font = ((System.Drawing.Font)(resources.GetObject("tbFlname.Font")));
			this.tbFlname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbFlname.ImeMode")));
			this.tbFlname.Location = ((System.Drawing.Point)(resources.GetObject("tbFlname.Location")));
			this.tbFlname.MaxLength = ((int)(resources.GetObject("tbFlname.MaxLength")));
			this.tbFlname.Multiline = ((bool)(resources.GetObject("tbFlname.Multiline")));
			this.tbFlname.Name = "tbFlname";
			this.tbFlname.PasswordChar = ((char)(resources.GetObject("tbFlname.PasswordChar")));
			this.tbFlname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbFlname.RightToLeft")));
			this.tbFlname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbFlname.ScrollBars")));
			this.tbFlname.Size = ((System.Drawing.Size)(resources.GetObject("tbFlname.Size")));
			this.tbFlname.TabIndex = ((int)(resources.GetObject("tbFlname.TabIndex")));
			this.tbFlname.Text = resources.GetString("tbFlname.Text");
			this.tbFlname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbFlname.TextAlign")));
			this.tbFlname.Visible = ((bool)(resources.GetObject("tbFlname.Visible")));
			this.tbFlname.WordWrap = ((bool)(resources.GetObject("tbFlname.WordWrap")));
			this.tbFlname.TextChanged += new System.EventHandler(this.tbFlname_TextChanged);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
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
			// 
			// TattUI
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.lb);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbFlname);
			this.Controls.Add(this.tbRes);
			this.Controls.Add(this.tbVer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "TattUI";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Commited += new System.EventHandler(this.TattUI_Commited);
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.tbVer, 0);
			this.Controls.SetChildIndex(this.tbRes, 0);
			this.Controls.SetChildIndex(this.tbFlname, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.lb, 0);
			this.ResumeLayout(false);

		}
		#endregion

		public Tatt Tatt 
		{
			get { return (Tatt)Wrapper ; }
		}

		//bool inter;
		protected override void RefreshGUI()
		{
			base.RefreshGUI ();

			//inter =true;
			this.tbFlname.Text =  Tatt.FileName;
			this.tbRes.Text = "0x"+Helper.HexString(Tatt.Reserved);
			this.tbVer.Text = "0x"+Helper.HexString(Tatt.Version);

			this.lb.Items.Clear();
			foreach (TattItem ti in Tatt)
				lb.Items.Add(ti);

			//inter = false;
		}

		private void TattUI_Commited(object sender, System.EventArgs e)
		{
			Tatt.SynchronizeUserData();
		}

		private void tbFlname_TextChanged(object sender, System.EventArgs e)
		{
			Tatt.FileName = tbFlname.Text;
			Tatt.Reserved = Helper.StringToUInt32(tbRes.Text, Tatt.Reserved, 16);
			Tatt.Version = Helper.StringToUInt32(tbVer.Text, Tatt.Version, 16);

			Tatt.Changed = true;
		}

	}
}
