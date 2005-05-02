/***************************************************************************
 *   Copyright (C) 2005 by Peter L Jones                                   *
 *   peter@drealm.info                                                     *
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
using SimPe.Interfaces.Plugin;
using SimPe.Plugin;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für TrcnForm.
	/// </summary>
	public class TrcnForm : System.Windows.Forms.Form, IPackedFileUI
	{
		#region Form variables
		private System.Windows.Forms.ListBox lbprop;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbTrcn;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.GroupBox gbprop;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.LinkLabel lldel;
		private System.Windows.Forms.Button btcommit;
		private System.Windows.Forms.Panel trcnPanel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public TrcnForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
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


		#region Trcn
		private Trcn wrapper;
		private void Change()
		{
			try 
			{
				tbname.Tag = true;
				TrcnItem prop;
				if (this.lbprop.SelectedIndex<0) prop = new TrcnItem((Trcn)wrapper);
				else prop = (TrcnItem)lbprop.Items[lbprop.SelectedIndex];

				prop.Name = tbname.Text;
				prop.LineNumber = Convert.ToInt32(tbval.Text, 16)+1;

				if (this.lbprop.SelectedIndex<0) lbprop.Items.Add(prop);
				else lbprop.Items[lbprop.SelectedIndex] = prop;

				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		#endregion

		#region IPackedFileUI Member
		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Panel GUIHandle
		{
			get
			{
				return trcnPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <remarks>attr.Tag is used to let TextChanged event handlers know the change is being
		/// made internally rather than by the users.</remarks>
		/// <param name="wrp">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrp)
		{
			wrapper = (Trcn)wrp;

			lbTrcn.Text = wrapper.FileName;
			tbname.Text = "";
			tbval.Text = "";
			lldel.Enabled = false;

			lbprop.Items.Clear();
			lbprop.Sorted = false;
			foreach (TrcnItem item in wrapper.Labels) lbprop.Items.Add(item);
			lbprop.Sorted = true;
		}		

		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(TrcnForm));
			this.btcommit = new System.Windows.Forms.Button();
			this.gbprop = new System.Windows.Forms.GroupBox();
			this.lldel = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.tbval = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.lbprop = new System.Windows.Forms.ListBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbTrcn = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.trcnPanel = new System.Windows.Forms.Panel();
			this.trcnPanel.SuspendLayout();
			this.gbprop.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btcommit
			// 
			this.btcommit.AccessibleDescription = resources.GetString("btcommit.AccessibleDescription");
			this.btcommit.AccessibleName = resources.GetString("btcommit.AccessibleName");
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btcommit.Anchor")));
			this.btcommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btcommit.BackgroundImage")));
			this.btcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btcommit.Dock")));
			this.btcommit.Enabled = ((bool)(resources.GetObject("btcommit.Enabled")));
			this.btcommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btcommit.FlatStyle")));
			this.btcommit.Font = ((System.Drawing.Font)(resources.GetObject("btcommit.Font")));
			this.btcommit.Image = ((System.Drawing.Image)(resources.GetObject("btcommit.Image")));
			this.btcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommit.ImageAlign")));
			this.btcommit.ImageIndex = ((int)(resources.GetObject("btcommit.ImageIndex")));
			this.btcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btcommit.ImeMode")));
			this.btcommit.Location = ((System.Drawing.Point)(resources.GetObject("btcommit.Location")));
			this.btcommit.Name = "btcommit";
			this.btcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btcommit.RightToLeft")));
			this.btcommit.Size = ((System.Drawing.Size)(resources.GetObject("btcommit.Size")));
			this.btcommit.TabIndex = ((int)(resources.GetObject("btcommit.TabIndex")));
			this.btcommit.Text = resources.GetString("btcommit.Text");
			this.btcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btcommit.TextAlign")));
			this.btcommit.Visible = ((bool)(resources.GetObject("btcommit.Visible")));
			this.btcommit.Click += new System.EventHandler(this.Commit);
			// 
			// gbprop
			// 
			this.gbprop.AccessibleDescription = resources.GetString("gbprop.AccessibleDescription");
			this.gbprop.AccessibleName = resources.GetString("gbprop.AccessibleName");
			this.gbprop.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbprop.Anchor")));
			this.gbprop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbprop.BackgroundImage")));
			this.gbprop.Controls.Add(this.lldel);
			this.gbprop.Controls.Add(this.lladd);
			this.gbprop.Controls.Add(this.tbval);
			this.gbprop.Controls.Add(this.tbname);
			this.gbprop.Controls.Add(this.label2);
			this.gbprop.Controls.Add(this.label1);
			this.gbprop.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbprop.Dock")));
			this.gbprop.Enabled = ((bool)(resources.GetObject("gbprop.Enabled")));
			this.gbprop.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbprop.Font = ((System.Drawing.Font)(resources.GetObject("gbprop.Font")));
			this.gbprop.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbprop.ImeMode")));
			this.gbprop.Location = ((System.Drawing.Point)(resources.GetObject("gbprop.Location")));
			this.gbprop.Name = "gbprop";
			this.gbprop.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbprop.RightToLeft")));
			this.gbprop.Size = ((System.Drawing.Size)(resources.GetObject("gbprop.Size")));
			this.gbprop.TabIndex = ((int)(resources.GetObject("gbprop.TabIndex")));
			this.gbprop.TabStop = false;
			this.gbprop.Text = resources.GetString("gbprop.Text");
			this.gbprop.Visible = ((bool)(resources.GetObject("gbprop.Visible")));
			// 
			// lldel
			// 
			this.lldel.AccessibleDescription = resources.GetString("lldel.AccessibleDescription");
			this.lldel.AccessibleName = resources.GetString("lldel.AccessibleName");
			this.lldel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldel.Anchor")));
			this.lldel.AutoSize = ((bool)(resources.GetObject("lldel.AutoSize")));
			this.lldel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldel.Dock")));
			this.lldel.Enabled = ((bool)(resources.GetObject("lldel.Enabled")));
			this.lldel.Font = ((System.Drawing.Font)(resources.GetObject("lldel.Font")));
			this.lldel.Image = ((System.Drawing.Image)(resources.GetObject("lldel.Image")));
			this.lldel.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.ImageAlign")));
			this.lldel.ImageIndex = ((int)(resources.GetObject("lldel.ImageIndex")));
			this.lldel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldel.ImeMode")));
			this.lldel.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldel.LinkArea")));
			this.lldel.Location = ((System.Drawing.Point)(resources.GetObject("lldel.Location")));
			this.lldel.Name = "lldel";
			this.lldel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldel.RightToLeft")));
			this.lldel.Size = ((System.Drawing.Size)(resources.GetObject("lldel.Size")));
			this.lldel.TabIndex = ((int)(resources.GetObject("lldel.TabIndex")));
			this.lldel.TabStop = true;
			this.lldel.Text = resources.GetString("lldel.Text");
			this.lldel.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldel.TextAlign")));
			this.lldel.Visible = ((bool)(resources.GetObject("lldel.Visible")));
			this.lldel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeletItem);
			// 
			// lladd
			// 
			this.lladd.AccessibleDescription = resources.GetString("lladd.AccessibleDescription");
			this.lladd.AccessibleName = resources.GetString("lladd.AccessibleName");
			this.lladd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lladd.Anchor")));
			this.lladd.AutoSize = ((bool)(resources.GetObject("lladd.AutoSize")));
			this.lladd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lladd.Dock")));
			this.lladd.Enabled = ((bool)(resources.GetObject("lladd.Enabled")));
			this.lladd.Font = ((System.Drawing.Font)(resources.GetObject("lladd.Font")));
			this.lladd.Image = ((System.Drawing.Image)(resources.GetObject("lladd.Image")));
			this.lladd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.ImageAlign")));
			this.lladd.ImageIndex = ((int)(resources.GetObject("lladd.ImageIndex")));
			this.lladd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lladd.ImeMode")));
			this.lladd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lladd.LinkArea")));
			this.lladd.Location = ((System.Drawing.Point)(resources.GetObject("lladd.Location")));
			this.lladd.Name = "lladd";
			this.lladd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lladd.RightToLeft")));
			this.lladd.Size = ((System.Drawing.Size)(resources.GetObject("lladd.Size")));
			this.lladd.TabIndex = ((int)(resources.GetObject("lladd.TabIndex")));
			this.lladd.TabStop = true;
			this.lladd.Text = resources.GetString("lladd.Text");
			this.lladd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladd.TextAlign")));
			this.lladd.Visible = ((bool)(resources.GetObject("lladd.Visible")));
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddItem);
			// 
			// tbval
			// 
			this.tbval.AccessibleDescription = resources.GetString("tbval.AccessibleDescription");
			this.tbval.AccessibleName = resources.GetString("tbval.AccessibleName");
			this.tbval.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbval.Anchor")));
			this.tbval.AutoSize = ((bool)(resources.GetObject("tbval.AutoSize")));
			this.tbval.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbval.BackgroundImage")));
			this.tbval.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbval.Dock")));
			this.tbval.Enabled = ((bool)(resources.GetObject("tbval.Enabled")));
			this.tbval.Font = ((System.Drawing.Font)(resources.GetObject("tbval.Font")));
			this.tbval.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbval.ImeMode")));
			this.tbval.Location = ((System.Drawing.Point)(resources.GetObject("tbval.Location")));
			this.tbval.MaxLength = ((int)(resources.GetObject("tbval.MaxLength")));
			this.tbval.Multiline = ((bool)(resources.GetObject("tbval.Multiline")));
			this.tbval.Name = "tbval";
			this.tbval.PasswordChar = ((char)(resources.GetObject("tbval.PasswordChar")));
			this.tbval.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbval.RightToLeft")));
			this.tbval.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbval.ScrollBars")));
			this.tbval.Size = ((System.Drawing.Size)(resources.GetObject("tbval.Size")));
			this.tbval.TabIndex = ((int)(resources.GetObject("tbval.TabIndex")));
			this.tbval.Text = resources.GetString("tbval.Text");
			this.tbval.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbval.TextAlign")));
			this.tbval.Visible = ((bool)(resources.GetObject("tbval.Visible")));
			this.tbval.WordWrap = ((bool)(resources.GetObject("tbval.WordWrap")));
			this.tbval.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// tbname
			// 
			this.tbname.AccessibleDescription = resources.GetString("tbname.AccessibleDescription");
			this.tbname.AccessibleName = resources.GetString("tbname.AccessibleName");
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbname.Anchor")));
			this.tbname.AutoSize = ((bool)(resources.GetObject("tbname.AutoSize")));
			this.tbname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbname.BackgroundImage")));
			this.tbname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbname.Dock")));
			this.tbname.Enabled = ((bool)(resources.GetObject("tbname.Enabled")));
			this.tbname.Font = ((System.Drawing.Font)(resources.GetObject("tbname.Font")));
			this.tbname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbname.ImeMode")));
			this.tbname.Location = ((System.Drawing.Point)(resources.GetObject("tbname.Location")));
			this.tbname.MaxLength = ((int)(resources.GetObject("tbname.MaxLength")));
			this.tbname.Multiline = ((bool)(resources.GetObject("tbname.Multiline")));
			this.tbname.Name = "tbname";
			this.tbname.PasswordChar = ((char)(resources.GetObject("tbname.PasswordChar")));
			this.tbname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbname.RightToLeft")));
			this.tbname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbname.ScrollBars")));
			this.tbname.Size = ((System.Drawing.Size)(resources.GetObject("tbname.Size")));
			this.tbname.TabIndex = ((int)(resources.GetObject("tbname.TabIndex")));
			this.tbname.Text = resources.GetString("tbname.Text");
			this.tbname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbname.TextAlign")));
			this.tbname.Visible = ((bool)(resources.GetObject("tbname.Visible")));
			this.tbname.WordWrap = ((bool)(resources.GetObject("tbname.WordWrap")));
			this.tbname.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
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
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
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
			// lbprop
			// 
			this.lbprop.AccessibleDescription = resources.GetString("lbprop.AccessibleDescription");
			this.lbprop.AccessibleName = resources.GetString("lbprop.AccessibleName");
			this.lbprop.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbprop.Anchor")));
			this.lbprop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbprop.BackgroundImage")));
			this.lbprop.ColumnWidth = ((int)(resources.GetObject("lbprop.ColumnWidth")));
			this.lbprop.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbprop.Dock")));
			this.lbprop.Enabled = ((bool)(resources.GetObject("lbprop.Enabled")));
			this.lbprop.Font = ((System.Drawing.Font)(resources.GetObject("lbprop.Font")));
			this.lbprop.HorizontalExtent = ((int)(resources.GetObject("lbprop.HorizontalExtent")));
			this.lbprop.HorizontalScrollbar = ((bool)(resources.GetObject("lbprop.HorizontalScrollbar")));
			this.lbprop.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbprop.ImeMode")));
			this.lbprop.IntegralHeight = ((bool)(resources.GetObject("lbprop.IntegralHeight")));
			this.lbprop.ItemHeight = ((int)(resources.GetObject("lbprop.ItemHeight")));
			this.lbprop.Location = ((System.Drawing.Point)(resources.GetObject("lbprop.Location")));
			this.lbprop.Name = "lbprop";
			this.lbprop.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbprop.RightToLeft")));
			this.lbprop.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbprop.ScrollAlwaysVisible")));
			this.lbprop.Size = ((System.Drawing.Size)(resources.GetObject("lbprop.Size")));
			this.lbprop.TabIndex = ((int)(resources.GetObject("lbprop.TabIndex")));
			this.lbprop.Visible = ((bool)(resources.GetObject("lbprop.Visible")));
			this.lbprop.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.lbTrcn);
			this.panel2.Controls.Add(this.label27);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// lbTrcn
			// 
			this.lbTrcn.AccessibleDescription = resources.GetString("lbTrcn.AccessibleDescription");
			this.lbTrcn.AccessibleName = resources.GetString("lbTrcn.AccessibleName");
			this.lbTrcn.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbTrcn.Anchor")));
			this.lbTrcn.AutoSize = ((bool)(resources.GetObject("lbTrcn.AutoSize")));
			this.lbTrcn.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbTrcn.Dock")));
			this.lbTrcn.Enabled = ((bool)(resources.GetObject("lbTrcn.Enabled")));
			this.lbTrcn.Font = ((System.Drawing.Font)(resources.GetObject("lbTrcn.Font")));
			this.lbTrcn.Image = ((System.Drawing.Image)(resources.GetObject("lbTrcn.Image")));
			this.lbTrcn.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbTrcn.ImageAlign")));
			this.lbTrcn.ImageIndex = ((int)(resources.GetObject("lbTrcn.ImageIndex")));
			this.lbTrcn.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbTrcn.ImeMode")));
			this.lbTrcn.Location = ((System.Drawing.Point)(resources.GetObject("lbTrcn.Location")));
			this.lbTrcn.Name = "lbTrcn";
			this.lbTrcn.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbTrcn.RightToLeft")));
			this.lbTrcn.Size = ((System.Drawing.Size)(resources.GetObject("lbTrcn.Size")));
			this.lbTrcn.TabIndex = ((int)(resources.GetObject("lbTrcn.TabIndex")));
			this.lbTrcn.Text = resources.GetString("lbTrcn.Text");
			this.lbTrcn.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbTrcn.TextAlign")));
			this.lbTrcn.Visible = ((bool)(resources.GetObject("lbTrcn.Visible")));
			// 
			// label27
			// 
			this.label27.AccessibleDescription = resources.GetString("label27.AccessibleDescription");
			this.label27.AccessibleName = resources.GetString("label27.AccessibleName");
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label27.Anchor")));
			this.label27.AutoSize = ((bool)(resources.GetObject("label27.AutoSize")));
			this.label27.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label27.Dock")));
			this.label27.Enabled = ((bool)(resources.GetObject("label27.Enabled")));
			this.label27.Font = ((System.Drawing.Font)(resources.GetObject("label27.Font")));
			this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
			this.label27.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.ImageAlign")));
			this.label27.ImageIndex = ((int)(resources.GetObject("label27.ImageIndex")));
			this.label27.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label27.ImeMode")));
			this.label27.Location = ((System.Drawing.Point)(resources.GetObject("label27.Location")));
			this.label27.Name = "label27";
			this.label27.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label27.RightToLeft")));
			this.label27.Size = ((System.Drawing.Size)(resources.GetObject("label27.Size")));
			this.label27.TabIndex = ((int)(resources.GetObject("label27.TabIndex")));
			this.label27.Text = resources.GetString("label27.Text");
			this.label27.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.TextAlign")));
			this.label27.Visible = ((bool)(resources.GetObject("label27.Visible")));
			// 
			// trcnPanel
			// 
			this.trcnPanel.AccessibleDescription = resources.GetString("trcnPanel.AccessibleDescription");
			this.trcnPanel.AccessibleName = resources.GetString("trcnPanel.AccessibleName");
			this.trcnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("trcnPanel.Anchor")));
			this.trcnPanel.AutoScroll = ((bool)(resources.GetObject("trcnPanel.AutoScroll")));
			this.trcnPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("trcnPanel.AutoScrollMargin")));
			this.trcnPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("trcnPanel.AutoScrollMinSize")));
			this.trcnPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("trcnPanel.BackgroundImage")));
			this.trcnPanel.Controls.Add(this.btcommit);
			this.trcnPanel.Controls.Add(this.gbprop);
			this.trcnPanel.Controls.Add(this.lbprop);
			this.trcnPanel.Controls.Add(this.panel2);
			this.trcnPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("trcnPanel.Dock")));
			this.trcnPanel.Enabled = ((bool)(resources.GetObject("trcnPanel.Enabled")));
			this.trcnPanel.Font = ((System.Drawing.Font)(resources.GetObject("trcnPanel.Font")));
			this.trcnPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("trcnPanel.ImeMode")));
			this.trcnPanel.Location = ((System.Drawing.Point)(resources.GetObject("trcnPanel.Location")));
			this.trcnPanel.Name = "trcnPanel";
			this.trcnPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("trcnPanel.RightToLeft")));
			this.trcnPanel.Size = ((System.Drawing.Size)(resources.GetObject("trcnPanel.Size")));
			this.trcnPanel.TabIndex = ((int)(resources.GetObject("trcnPanel.TabIndex")));
			this.trcnPanel.Text = resources.GetString("trcnPanel.Text");
			this.trcnPanel.Visible = ((bool)(resources.GetObject("trcnPanel.Visible")));
			// 
			// TrcnForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.trcnPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "TrcnForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.trcnPanel.ResumeLayout(false);
			this.gbprop.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		private void SelectItem(object sender, System.EventArgs e)
		{
			lldel.Enabled = false;
			if (lbprop.SelectedIndex<0) return;
			lldel.Enabled = true;

			try 
			{
				tbname.Tag = true;
				TrcnItem prop = (TrcnItem)lbprop.Items[lbprop.SelectedIndex];
				this.tbname.Text = prop.Name;
				this.tbval.Text = "0x"+Helper.HexString((uint)(prop.LineNumber-1));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbname.Tag = null;
			}
		}

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbname.Tag!=null) return;
			if (this.lbprop.SelectedIndex>=0) Change();

		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbprop.SelectedIndex = -1;
			Change();
			lbprop.SelectedIndex = lbprop.Items.Count-1;
		}

		private void DeletItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbprop.SelectedIndex<0) return;
			lbprop.Items.Remove(lbprop.Items[lbprop.SelectedIndex]);
			wrapper.Changed = true;
		}

		private void Commit(object sender, System.EventArgs e)
		{
			try 
			{
				Trcn wrp = (Trcn)wrapper;
				TrcnItem[] items = new TrcnItem[lbprop.Items.Count];

				for (int i=0; i<items.Length; i++)
				{
					items[i] = (TrcnItem)lbprop.Items[i];
				}

				wrp.Labels = items;
				wrp.SynchronizeUserData();

				MessageBox.Show(Localization.Manager.GetString("commited"));
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}
		#endregion
	}
}
