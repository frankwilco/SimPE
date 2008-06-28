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
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace SimPe.Plugin.Tool
{
	/// <summary>
	/// Zusammenfassung für Report.
	/// </summary>
	internal class Report : System.Windows.Forms.Form
	{
		private SteepValley.Windows.Forms.XPGradientPanel xpGradientPanel1;
		private System.Windows.Forms.RichTextBox rtb;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.SaveFileDialog sfd;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Report()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			//
			// TODO: Fügen Sie den Konstruktorcode nach dem Aufruf von InitializeComponent hinzu
			//
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
			if (csv != null)
			{
				csv.Close();
				csv.Dispose();
				csv = null;
			}
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Report));
			this.xpGradientPanel1 = new SteepValley.Windows.Forms.XPGradientPanel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.xpGradientPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xpGradientPanel1
			// 
			this.xpGradientPanel1.AccessibleDescription = resources.GetString("xpGradientPanel1.AccessibleDescription");
			this.xpGradientPanel1.AccessibleName = resources.GetString("xpGradientPanel1.AccessibleName");
			this.xpGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpGradientPanel1.Anchor")));
			this.xpGradientPanel1.AutoScroll = ((bool)(resources.GetObject("xpGradientPanel1.AutoScroll")));
			this.xpGradientPanel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMargin")));
			this.xpGradientPanel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.AutoScrollMinSize")));
			this.xpGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.BackgroundImage")));
			this.xpGradientPanel1.Controls.Add(this.linkLabel1);
			this.xpGradientPanel1.Controls.Add(this.rtb);
			this.xpGradientPanel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpGradientPanel1.Dock")));
			this.xpGradientPanel1.Enabled = ((bool)(resources.GetObject("xpGradientPanel1.Enabled")));
			this.xpGradientPanel1.Font = ((System.Drawing.Font)(resources.GetObject("xpGradientPanel1.Font")));
			this.xpGradientPanel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpGradientPanel1.ImeMode")));
			this.xpGradientPanel1.Location = ((System.Drawing.Point)(resources.GetObject("xpGradientPanel1.Location")));
			this.xpGradientPanel1.Name = "xpGradientPanel1";
			this.xpGradientPanel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpGradientPanel1.RightToLeft")));
			this.xpGradientPanel1.Size = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.Size")));
			this.xpGradientPanel1.TabIndex = ((int)(resources.GetObject("xpGradientPanel1.TabIndex")));
			this.xpGradientPanel1.Text = resources.GetString("xpGradientPanel1.Text");
			this.xpGradientPanel1.Visible = ((bool)(resources.GetObject("xpGradientPanel1.Visible")));
			this.xpGradientPanel1.Watermark = ((System.Drawing.Image)(resources.GetObject("xpGradientPanel1.Watermark")));
			this.xpGradientPanel1.WatermarkSize = ((System.Drawing.Size)(resources.GetObject("xpGradientPanel1.WatermarkSize")));
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
			this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
			this.linkLabel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel1.Dock")));
			this.linkLabel1.Enabled = ((bool)(resources.GetObject("linkLabel1.Enabled")));
			this.linkLabel1.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel1.Font")));
			this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
			this.linkLabel1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.ImageAlign")));
			this.linkLabel1.ImageIndex = ((int)(resources.GetObject("linkLabel1.ImageIndex")));
			this.linkLabel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel1.ImeMode")));
			this.linkLabel1.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel1.LinkArea")));
			this.linkLabel1.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel1.Location")));
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel1.RightToLeft")));
			this.linkLabel1.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel1.Size")));
			this.linkLabel1.TabIndex = ((int)(resources.GetObject("linkLabel1.TabIndex")));
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
			this.linkLabel1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.TextAlign")));
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// rtb
			// 
			this.rtb.AccessibleDescription = resources.GetString("rtb.AccessibleDescription");
			this.rtb.AccessibleName = resources.GetString("rtb.AccessibleName");
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtb.Anchor")));
			this.rtb.AutoSize = ((bool)(resources.GetObject("rtb.AutoSize")));
			this.rtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtb.BackgroundImage")));
			this.rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb.BulletIndent = ((int)(resources.GetObject("rtb.BulletIndent")));
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
			this.rtb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtb.ImeMode")));
			this.rtb.Location = ((System.Drawing.Point)(resources.GetObject("rtb.Location")));
			this.rtb.MaxLength = ((int)(resources.GetObject("rtb.MaxLength")));
			this.rtb.Multiline = ((bool)(resources.GetObject("rtb.Multiline")));
			this.rtb.Name = "rtb";
			this.rtb.ReadOnly = true;
			this.rtb.RightMargin = ((int)(resources.GetObject("rtb.RightMargin")));
			this.rtb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtb.RightToLeft")));
			this.rtb.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtb.ScrollBars")));
			this.rtb.ShowSelectionMargin = true;
			this.rtb.Size = ((System.Drawing.Size)(resources.GetObject("rtb.Size")));
			this.rtb.TabIndex = ((int)(resources.GetObject("rtb.TabIndex")));
			this.rtb.Text = resources.GetString("rtb.Text");
			this.rtb.Visible = ((bool)(resources.GetObject("rtb.Visible")));
			this.rtb.WordWrap = ((bool)(resources.GetObject("rtb.WordWrap")));
			this.rtb.ZoomFactor = ((System.Single)(resources.GetObject("rtb.ZoomFactor")));
			// 
			// sfd
			// 
			this.sfd.Filter = resources.GetString("sfd.Filter");
			this.sfd.Title = resources.GetString("sfd.Title");
			// 
			// Report
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.xpGradientPanel1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Report";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.xpGradientPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		System.IO.StreamWriter csv;
		public void Execute(System.IO.StreamWriter csv)
		{
			csv.Flush();
			csv.BaseStream.Seek(0, SeekOrigin.Begin);
			StreamReader sr = new StreamReader(csv.BaseStream);
			sr.BaseStream.Seek(0, SeekOrigin.Begin);			

			this.csv = csv;
			this.rtb.Text = sr.ReadToEnd();
			this.ShowDialog();
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				csv.BaseStream.Seek(0, SeekOrigin.Begin);
				StreamReader sr = new StreamReader(csv.BaseStream);
				sr.BaseStream.Seek(0, SeekOrigin.Begin);

				System.IO.StreamWriter sw = System.IO.File.CreateText(sfd.FileName);
				try 
				{
					sw.Write(sr.ReadToEnd());
				} 
				finally 
				{
					sw.Close();
					sw.Dispose();
					sw = null;
					sr = null;
				}
			}
		}
	}
}
