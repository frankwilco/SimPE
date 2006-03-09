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
using SimPe.Interfaces.Plugin;
using SimPe.PackedFiles.Wrapper;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für NgbhForm.
	/// </summary>
	public class NgbhForm : System.Windows.Forms.Form
	{
		private System.ComponentModel.IContainer components;
		

		public NgbhForm()
		{
			InitializeComponent();

			this.cbtype.SelectedIndex = cbtype.Items.Count-1;

#if DEBUG
#else
			/*this.lbdata.Visible = false;
			this.tbFlag.Enabled = false;
			this.tbguid.Visible = false;
			this.tbsub.Visible = false;
			this.tbsubid.Visible = false;
			this.tbown.Visible = false;*/
#endif

			SimPe.RemoteControl.HookToMessageQueue(0x4E474248, new SimPe.RemoteControl.ControlEvent(ControlEvent));
		}

		protected void ControlEvent(object sender, SimPe.RemoteControl.ControlEventArgs e)
		{			
			object[] os = e.Items as object[];
			if (os!=null) 
			{
				this.cbtype.SelectedIndex = (int)((Data.NeighborhoodSlots)os[1]);
				uint inst = (uint)os[0];
				foreach (ListViewItem lvi in this.lv.Items)
				{
					
					PackedFiles.Wrapper.SDesc sdesc = lvi.Tag as PackedFiles.Wrapper.SDesc;
					if (sdesc.FileDescriptor.Instance == inst) 
					{
						lvi.Selected = true;
						lvi.EnsureVisible();						
					} else lvi.Selected = false;
				}

				lv.Refresh();
			}			
		}

		/// <summary>
		/// Die verwendeten Ressourcen bereinigen.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				SimPe.RemoteControl.UnhookFromMessageQueue(0x4E474248, new SimPe.RemoteControl.ControlEvent(ControlEvent));
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(NgbhForm));
			this.ngbhPanel = new System.Windows.Forms.Panel();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.lbname = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.gbmem = new System.Windows.Forms.GroupBox();
			this.cbown = new System.Windows.Forms.ComboBox();
			this.tbval = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbUnk = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btdown = new System.Windows.Forms.Button();
			this.btup = new System.Windows.Forms.Button();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.lbmem = new System.Windows.Forms.ListView();
			this.memilist = new System.Windows.Forms.ImageList(this.components);
			this.tbown = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbsubid = new System.Windows.Forms.TextBox();
			this.cbsub = new System.Windows.Forms.ComboBox();
			this.tbsub = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbguid = new System.Windows.Forms.ComboBox();
			this.tbguid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbaction = new System.Windows.Forms.CheckBox();
			this.cbvis = new System.Windows.Forms.CheckBox();
			this.tbFlag = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.PictureBox();
			this.lbdata = new System.Windows.Forms.TextBox();
			this.lv = new System.Windows.Forms.ListView();
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.ngbhPanel.SuspendLayout();
			this.gbmem.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ngbhPanel
			// 
			this.ngbhPanel.AccessibleDescription = resources.GetString("ngbhPanel.AccessibleDescription");
			this.ngbhPanel.AccessibleName = resources.GetString("ngbhPanel.AccessibleName");
			this.ngbhPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("ngbhPanel.Anchor")));
			this.ngbhPanel.AutoScroll = ((bool)(resources.GetObject("ngbhPanel.AutoScroll")));
			this.ngbhPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("ngbhPanel.AutoScrollMargin")));
			this.ngbhPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("ngbhPanel.AutoScrollMinSize")));
			this.ngbhPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ngbhPanel.BackgroundImage")));
			this.ngbhPanel.Controls.Add(this.cbtype);
			this.ngbhPanel.Controls.Add(this.lbname);
			this.ngbhPanel.Controls.Add(this.button1);
			this.ngbhPanel.Controls.Add(this.gbmem);
			this.ngbhPanel.Controls.Add(this.lv);
			this.ngbhPanel.Controls.Add(this.panel2);
			this.ngbhPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("ngbhPanel.Dock")));
			this.ngbhPanel.Enabled = ((bool)(resources.GetObject("ngbhPanel.Enabled")));
			this.ngbhPanel.Font = ((System.Drawing.Font)(resources.GetObject("ngbhPanel.Font")));
			this.ngbhPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("ngbhPanel.ImeMode")));
			this.ngbhPanel.Location = ((System.Drawing.Point)(resources.GetObject("ngbhPanel.Location")));
			this.ngbhPanel.Name = "ngbhPanel";
			this.ngbhPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("ngbhPanel.RightToLeft")));
			this.ngbhPanel.Size = ((System.Drawing.Size)(resources.GetObject("ngbhPanel.Size")));
			this.ngbhPanel.TabIndex = ((int)(resources.GetObject("ngbhPanel.TabIndex")));
			this.ngbhPanel.Text = resources.GetString("ngbhPanel.Text");
			this.ngbhPanel.Visible = ((bool)(resources.GetObject("ngbhPanel.Visible")));
			// 
			// cbtype
			// 
			this.cbtype.AccessibleDescription = resources.GetString("cbtype.AccessibleDescription");
			this.cbtype.AccessibleName = resources.GetString("cbtype.AccessibleName");
			this.cbtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtype.Anchor")));
			this.cbtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtype.BackgroundImage")));
			this.cbtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtype.Dock")));
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Enabled = ((bool)(resources.GetObject("cbtype.Enabled")));
			this.cbtype.Font = ((System.Drawing.Font)(resources.GetObject("cbtype.Font")));
			this.cbtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtype.ImeMode")));
			this.cbtype.IntegralHeight = ((bool)(resources.GetObject("cbtype.IntegralHeight")));
			this.cbtype.ItemHeight = ((int)(resources.GetObject("cbtype.ItemHeight")));
			this.cbtype.Items.AddRange(new object[] {
														resources.GetString("cbtype.Items"),
														resources.GetString("cbtype.Items1"),
														resources.GetString("cbtype.Items2"),
														resources.GetString("cbtype.Items3"),
														resources.GetString("cbtype.Items4"),
														resources.GetString("cbtype.Items5")});
			this.cbtype.Location = ((System.Drawing.Point)(resources.GetObject("cbtype.Location")));
			this.cbtype.MaxDropDownItems = ((int)(resources.GetObject("cbtype.MaxDropDownItems")));
			this.cbtype.MaxLength = ((int)(resources.GetObject("cbtype.MaxLength")));
			this.cbtype.Name = "cbtype";
			this.cbtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtype.RightToLeft")));
			this.cbtype.Size = ((System.Drawing.Size)(resources.GetObject("cbtype.Size")));
			this.cbtype.TabIndex = ((int)(resources.GetObject("cbtype.TabIndex")));
			this.cbtype.Text = resources.GetString("cbtype.Text");
			this.cbtype.Visible = ((bool)(resources.GetObject("cbtype.Visible")));
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.SelectSim);
			// 
			// lbname
			// 
			this.lbname.AccessibleDescription = resources.GetString("lbname.AccessibleDescription");
			this.lbname.AccessibleName = resources.GetString("lbname.AccessibleName");
			this.lbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbname.Anchor")));
			this.lbname.AutoSize = ((bool)(resources.GetObject("lbname.AutoSize")));
			this.lbname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbname.Dock")));
			this.lbname.Enabled = ((bool)(resources.GetObject("lbname.Enabled")));
			this.lbname.Font = ((System.Drawing.Font)(resources.GetObject("lbname.Font")));
			this.lbname.Image = ((System.Drawing.Image)(resources.GetObject("lbname.Image")));
			this.lbname.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbname.ImageAlign")));
			this.lbname.ImageIndex = ((int)(resources.GetObject("lbname.ImageIndex")));
			this.lbname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbname.ImeMode")));
			this.lbname.Location = ((System.Drawing.Point)(resources.GetObject("lbname.Location")));
			this.lbname.Name = "lbname";
			this.lbname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbname.RightToLeft")));
			this.lbname.Size = ((System.Drawing.Size)(resources.GetObject("lbname.Size")));
			this.lbname.TabIndex = ((int)(resources.GetObject("lbname.TabIndex")));
			this.lbname.Text = resources.GetString("lbname.Text");
			this.lbname.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbname.TextAlign")));
			this.lbname.Visible = ((bool)(resources.GetObject("lbname.Visible")));
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.Commit);
			// 
			// gbmem
			// 
			this.gbmem.AccessibleDescription = resources.GetString("gbmem.AccessibleDescription");
			this.gbmem.AccessibleName = resources.GetString("gbmem.AccessibleName");
			this.gbmem.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbmem.Anchor")));
			this.gbmem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbmem.BackgroundImage")));
			this.gbmem.Controls.Add(this.cbown);
			this.gbmem.Controls.Add(this.tbval);
			this.gbmem.Controls.Add(this.label6);
			this.gbmem.Controls.Add(this.tbUnk);
			this.gbmem.Controls.Add(this.label5);
			this.gbmem.Controls.Add(this.btdown);
			this.gbmem.Controls.Add(this.btup);
			this.gbmem.Controls.Add(this.linkLabel2);
			this.gbmem.Controls.Add(this.lbmem);
			this.gbmem.Controls.Add(this.tbown);
			this.gbmem.Controls.Add(this.label4);
			this.gbmem.Controls.Add(this.lladd);
			this.gbmem.Controls.Add(this.linkLabel1);
			this.gbmem.Controls.Add(this.tbsubid);
			this.gbmem.Controls.Add(this.cbsub);
			this.gbmem.Controls.Add(this.tbsub);
			this.gbmem.Controls.Add(this.label3);
			this.gbmem.Controls.Add(this.cbguid);
			this.gbmem.Controls.Add(this.tbguid);
			this.gbmem.Controls.Add(this.label2);
			this.gbmem.Controls.Add(this.cbaction);
			this.gbmem.Controls.Add(this.cbvis);
			this.gbmem.Controls.Add(this.tbFlag);
			this.gbmem.Controls.Add(this.label1);
			this.gbmem.Controls.Add(this.pb);
			this.gbmem.Controls.Add(this.lbdata);
			this.gbmem.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbmem.Dock")));
			this.gbmem.Enabled = ((bool)(resources.GetObject("gbmem.Enabled")));
			this.gbmem.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbmem.Font = ((System.Drawing.Font)(resources.GetObject("gbmem.Font")));
			this.gbmem.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbmem.ImeMode")));
			this.gbmem.Location = ((System.Drawing.Point)(resources.GetObject("gbmem.Location")));
			this.gbmem.Name = "gbmem";
			this.gbmem.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbmem.RightToLeft")));
			this.gbmem.Size = ((System.Drawing.Size)(resources.GetObject("gbmem.Size")));
			this.gbmem.TabIndex = ((int)(resources.GetObject("gbmem.TabIndex")));
			this.gbmem.TabStop = false;
			this.gbmem.Text = resources.GetString("gbmem.Text");
			this.gbmem.Visible = ((bool)(resources.GetObject("gbmem.Visible")));
			// 
			// cbown
			// 
			this.cbown.AccessibleDescription = resources.GetString("cbown.AccessibleDescription");
			this.cbown.AccessibleName = resources.GetString("cbown.AccessibleName");
			this.cbown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbown.Anchor")));
			this.cbown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbown.BackgroundImage")));
			this.cbown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbown.Dock")));
			this.cbown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbown.Enabled = ((bool)(resources.GetObject("cbown.Enabled")));
			this.cbown.Font = ((System.Drawing.Font)(resources.GetObject("cbown.Font")));
			this.cbown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbown.ImeMode")));
			this.cbown.IntegralHeight = ((bool)(resources.GetObject("cbown.IntegralHeight")));
			this.cbown.ItemHeight = ((int)(resources.GetObject("cbown.ItemHeight")));
			this.cbown.Location = ((System.Drawing.Point)(resources.GetObject("cbown.Location")));
			this.cbown.MaxDropDownItems = ((int)(resources.GetObject("cbown.MaxDropDownItems")));
			this.cbown.MaxLength = ((int)(resources.GetObject("cbown.MaxLength")));
			this.cbown.Name = "cbown";
			this.cbown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbown.RightToLeft")));
			this.cbown.Size = ((System.Drawing.Size)(resources.GetObject("cbown.Size")));
			this.cbown.TabIndex = ((int)(resources.GetObject("cbown.TabIndex")));
			this.cbown.Text = resources.GetString("cbown.Text");
			this.cbown.Visible = ((bool)(resources.GetObject("cbown.Visible")));
			this.cbown.SelectedIndexChanged += new System.EventHandler(this.ChgOwnerItem);
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
			this.tbval.TextChanged += new System.EventHandler(this.tbval_TextChanged);
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Enabled = ((bool)(resources.GetObject("label6.Enabled")));
			this.label6.Font = ((System.Drawing.Font)(resources.GetObject("label6.Font")));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			// 
			// tbUnk
			// 
			this.tbUnk.AccessibleDescription = resources.GetString("tbUnk.AccessibleDescription");
			this.tbUnk.AccessibleName = resources.GetString("tbUnk.AccessibleName");
			this.tbUnk.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbUnk.Anchor")));
			this.tbUnk.AutoSize = ((bool)(resources.GetObject("tbUnk.AutoSize")));
			this.tbUnk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbUnk.BackgroundImage")));
			this.tbUnk.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbUnk.Dock")));
			this.tbUnk.Enabled = ((bool)(resources.GetObject("tbUnk.Enabled")));
			this.tbUnk.Font = ((System.Drawing.Font)(resources.GetObject("tbUnk.Font")));
			this.tbUnk.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbUnk.ImeMode")));
			this.tbUnk.Location = ((System.Drawing.Point)(resources.GetObject("tbUnk.Location")));
			this.tbUnk.MaxLength = ((int)(resources.GetObject("tbUnk.MaxLength")));
			this.tbUnk.Multiline = ((bool)(resources.GetObject("tbUnk.Multiline")));
			this.tbUnk.Name = "tbUnk";
			this.tbUnk.PasswordChar = ((char)(resources.GetObject("tbUnk.PasswordChar")));
			this.tbUnk.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbUnk.RightToLeft")));
			this.tbUnk.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbUnk.ScrollBars")));
			this.tbUnk.Size = ((System.Drawing.Size)(resources.GetObject("tbUnk.Size")));
			this.tbUnk.TabIndex = ((int)(resources.GetObject("tbUnk.TabIndex")));
			this.tbUnk.Text = resources.GetString("tbUnk.Text");
			this.tbUnk.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbUnk.TextAlign")));
			this.tbUnk.Visible = ((bool)(resources.GetObject("tbUnk.Visible")));
			this.tbUnk.WordWrap = ((bool)(resources.GetObject("tbUnk.WordWrap")));
			this.tbUnk.TextChanged += new System.EventHandler(this.tbUnk_TextChanged);
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// btdown
			// 
			this.btdown.AccessibleDescription = resources.GetString("btdown.AccessibleDescription");
			this.btdown.AccessibleName = resources.GetString("btdown.AccessibleName");
			this.btdown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btdown.Anchor")));
			this.btdown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdown.BackgroundImage")));
			this.btdown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btdown.Dock")));
			this.btdown.Enabled = ((bool)(resources.GetObject("btdown.Enabled")));
			this.btdown.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btdown.FlatStyle")));
			this.btdown.Font = ((System.Drawing.Font)(resources.GetObject("btdown.Font")));
			this.btdown.Image = ((System.Drawing.Image)(resources.GetObject("btdown.Image")));
			this.btdown.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdown.ImageAlign")));
			this.btdown.ImageIndex = ((int)(resources.GetObject("btdown.ImageIndex")));
			this.btdown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btdown.ImeMode")));
			this.btdown.Location = ((System.Drawing.Point)(resources.GetObject("btdown.Location")));
			this.btdown.Name = "btdown";
			this.btdown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btdown.RightToLeft")));
			this.btdown.Size = ((System.Drawing.Size)(resources.GetObject("btdown.Size")));
			this.btdown.TabIndex = ((int)(resources.GetObject("btdown.TabIndex")));
			this.btdown.Text = resources.GetString("btdown.Text");
			this.btdown.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdown.TextAlign")));
			this.btdown.Visible = ((bool)(resources.GetObject("btdown.Visible")));
			this.btdown.Click += new System.EventHandler(this.ItemDown);
			// 
			// btup
			// 
			this.btup.AccessibleDescription = resources.GetString("btup.AccessibleDescription");
			this.btup.AccessibleName = resources.GetString("btup.AccessibleName");
			this.btup.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btup.Anchor")));
			this.btup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btup.BackgroundImage")));
			this.btup.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btup.Dock")));
			this.btup.Enabled = ((bool)(resources.GetObject("btup.Enabled")));
			this.btup.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btup.FlatStyle")));
			this.btup.Font = ((System.Drawing.Font)(resources.GetObject("btup.Font")));
			this.btup.Image = ((System.Drawing.Image)(resources.GetObject("btup.Image")));
			this.btup.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btup.ImageAlign")));
			this.btup.ImageIndex = ((int)(resources.GetObject("btup.ImageIndex")));
			this.btup.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btup.ImeMode")));
			this.btup.Location = ((System.Drawing.Point)(resources.GetObject("btup.Location")));
			this.btup.Name = "btup";
			this.btup.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btup.RightToLeft")));
			this.btup.Size = ((System.Drawing.Size)(resources.GetObject("btup.Size")));
			this.btup.TabIndex = ((int)(resources.GetObject("btup.TabIndex")));
			this.btup.Text = resources.GetString("btup.Text");
			this.btup.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btup.TextAlign")));
			this.btup.Visible = ((bool)(resources.GetObject("btup.Visible")));
			this.btup.Click += new System.EventHandler(this.ItemUp);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AccessibleDescription = resources.GetString("linkLabel2.AccessibleDescription");
			this.linkLabel2.AccessibleName = resources.GetString("linkLabel2.AccessibleName");
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel2.Anchor")));
			this.linkLabel2.AutoSize = ((bool)(resources.GetObject("linkLabel2.AutoSize")));
			this.linkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel2.Dock")));
			this.linkLabel2.Enabled = ((bool)(resources.GetObject("linkLabel2.Enabled")));
			this.linkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel2.Font")));
			this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
			this.linkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.ImageAlign")));
			this.linkLabel2.ImageIndex = ((int)(resources.GetObject("linkLabel2.ImageIndex")));
			this.linkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel2.ImeMode")));
			this.linkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel2.LinkArea")));
			this.linkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel2.Location")));
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel2.RightToLeft")));
			this.linkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel2.Size")));
			this.linkLabel2.TabIndex = ((int)(resources.GetObject("linkLabel2.TabIndex")));
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = resources.GetString("linkLabel2.Text");
			this.linkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.TextAlign")));
			this.linkLabel2.Visible = ((bool)(resources.GetObject("linkLabel2.Visible")));
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IOwn);
			// 
			// lbmem
			// 
			this.lbmem.AccessibleDescription = resources.GetString("lbmem.AccessibleDescription");
			this.lbmem.AccessibleName = resources.GetString("lbmem.AccessibleName");
			this.lbmem.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lbmem.Alignment")));
			this.lbmem.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbmem.Anchor")));
			this.lbmem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbmem.BackgroundImage")));
			this.lbmem.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbmem.Dock")));
			this.lbmem.Enabled = ((bool)(resources.GetObject("lbmem.Enabled")));
			this.lbmem.Font = ((System.Drawing.Font)(resources.GetObject("lbmem.Font")));
			this.lbmem.HideSelection = false;
			this.lbmem.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbmem.ImeMode")));
			this.lbmem.LabelWrap = ((bool)(resources.GetObject("lbmem.LabelWrap")));
			this.lbmem.LargeImageList = this.memilist;
			this.lbmem.Location = ((System.Drawing.Point)(resources.GetObject("lbmem.Location")));
			this.lbmem.MultiSelect = false;
			this.lbmem.Name = "lbmem";
			this.lbmem.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbmem.RightToLeft")));
			this.lbmem.Size = ((System.Drawing.Size)(resources.GetObject("lbmem.Size")));
			this.lbmem.SmallImageList = this.memilist;
			this.lbmem.StateImageList = this.memilist;
			this.lbmem.TabIndex = ((int)(resources.GetObject("lbmem.TabIndex")));
			this.lbmem.Text = resources.GetString("lbmem.Text");
			this.lbmem.View = System.Windows.Forms.View.List;
			this.lbmem.Visible = ((bool)(resources.GetObject("lbmem.Visible")));
			this.lbmem.SelectedIndexChanged += new System.EventHandler(this.SelectMemory);
			// 
			// memilist
			// 
			this.memilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.memilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("memilist.ImageSize")));
			this.memilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tbown
			// 
			this.tbown.AccessibleDescription = resources.GetString("tbown.AccessibleDescription");
			this.tbown.AccessibleName = resources.GetString("tbown.AccessibleName");
			this.tbown.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbown.Anchor")));
			this.tbown.AutoSize = ((bool)(resources.GetObject("tbown.AutoSize")));
			this.tbown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbown.BackgroundImage")));
			this.tbown.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbown.Dock")));
			this.tbown.Enabled = ((bool)(resources.GetObject("tbown.Enabled")));
			this.tbown.Font = ((System.Drawing.Font)(resources.GetObject("tbown.Font")));
			this.tbown.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbown.ImeMode")));
			this.tbown.Location = ((System.Drawing.Point)(resources.GetObject("tbown.Location")));
			this.tbown.MaxLength = ((int)(resources.GetObject("tbown.MaxLength")));
			this.tbown.Multiline = ((bool)(resources.GetObject("tbown.Multiline")));
			this.tbown.Name = "tbown";
			this.tbown.PasswordChar = ((char)(resources.GetObject("tbown.PasswordChar")));
			this.tbown.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbown.RightToLeft")));
			this.tbown.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbown.ScrollBars")));
			this.tbown.Size = ((System.Drawing.Size)(resources.GetObject("tbown.Size")));
			this.tbown.TabIndex = ((int)(resources.GetObject("tbown.TabIndex")));
			this.tbown.Text = resources.GetString("tbown.Text");
			this.tbown.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbown.TextAlign")));
			this.tbown.Visible = ((bool)(resources.GetObject("tbown.Visible")));
			this.tbown.WordWrap = ((bool)(resources.GetObject("tbown.WordWrap")));
			this.tbown.TextChanged += new System.EventHandler(this.ChgOwner);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
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
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
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
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteItem);
			// 
			// tbsubid
			// 
			this.tbsubid.AccessibleDescription = resources.GetString("tbsubid.AccessibleDescription");
			this.tbsubid.AccessibleName = resources.GetString("tbsubid.AccessibleName");
			this.tbsubid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsubid.Anchor")));
			this.tbsubid.AutoSize = ((bool)(resources.GetObject("tbsubid.AutoSize")));
			this.tbsubid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsubid.BackgroundImage")));
			this.tbsubid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsubid.Dock")));
			this.tbsubid.Enabled = ((bool)(resources.GetObject("tbsubid.Enabled")));
			this.tbsubid.Font = ((System.Drawing.Font)(resources.GetObject("tbsubid.Font")));
			this.tbsubid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsubid.ImeMode")));
			this.tbsubid.Location = ((System.Drawing.Point)(resources.GetObject("tbsubid.Location")));
			this.tbsubid.MaxLength = ((int)(resources.GetObject("tbsubid.MaxLength")));
			this.tbsubid.Multiline = ((bool)(resources.GetObject("tbsubid.Multiline")));
			this.tbsubid.Name = "tbsubid";
			this.tbsubid.PasswordChar = ((char)(resources.GetObject("tbsubid.PasswordChar")));
			this.tbsubid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsubid.RightToLeft")));
			this.tbsubid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsubid.ScrollBars")));
			this.tbsubid.Size = ((System.Drawing.Size)(resources.GetObject("tbsubid.Size")));
			this.tbsubid.TabIndex = ((int)(resources.GetObject("tbsubid.TabIndex")));
			this.tbsubid.Text = resources.GetString("tbsubid.Text");
			this.tbsubid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsubid.TextAlign")));
			this.tbsubid.Visible = ((bool)(resources.GetObject("tbsubid.Visible")));
			this.tbsubid.WordWrap = ((bool)(resources.GetObject("tbsubid.WordWrap")));
			this.tbsubid.TextChanged += new System.EventHandler(this.ChgSubjectID);
			// 
			// cbsub
			// 
			this.cbsub.AccessibleDescription = resources.GetString("cbsub.AccessibleDescription");
			this.cbsub.AccessibleName = resources.GetString("cbsub.AccessibleName");
			this.cbsub.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsub.Anchor")));
			this.cbsub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsub.BackgroundImage")));
			this.cbsub.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsub.Dock")));
			this.cbsub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsub.Enabled = ((bool)(resources.GetObject("cbsub.Enabled")));
			this.cbsub.Font = ((System.Drawing.Font)(resources.GetObject("cbsub.Font")));
			this.cbsub.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsub.ImeMode")));
			this.cbsub.IntegralHeight = ((bool)(resources.GetObject("cbsub.IntegralHeight")));
			this.cbsub.ItemHeight = ((int)(resources.GetObject("cbsub.ItemHeight")));
			this.cbsub.Location = ((System.Drawing.Point)(resources.GetObject("cbsub.Location")));
			this.cbsub.MaxDropDownItems = ((int)(resources.GetObject("cbsub.MaxDropDownItems")));
			this.cbsub.MaxLength = ((int)(resources.GetObject("cbsub.MaxLength")));
			this.cbsub.Name = "cbsub";
			this.cbsub.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsub.RightToLeft")));
			this.cbsub.Size = ((System.Drawing.Size)(resources.GetObject("cbsub.Size")));
			this.cbsub.TabIndex = ((int)(resources.GetObject("cbsub.TabIndex")));
			this.cbsub.Text = resources.GetString("cbsub.Text");
			this.cbsub.Visible = ((bool)(resources.GetObject("cbsub.Visible")));
			this.cbsub.SelectedIndexChanged += new System.EventHandler(this.ChgSubjectItem);
			// 
			// tbsub
			// 
			this.tbsub.AccessibleDescription = resources.GetString("tbsub.AccessibleDescription");
			this.tbsub.AccessibleName = resources.GetString("tbsub.AccessibleName");
			this.tbsub.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsub.Anchor")));
			this.tbsub.AutoSize = ((bool)(resources.GetObject("tbsub.AutoSize")));
			this.tbsub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsub.BackgroundImage")));
			this.tbsub.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsub.Dock")));
			this.tbsub.Enabled = ((bool)(resources.GetObject("tbsub.Enabled")));
			this.tbsub.Font = ((System.Drawing.Font)(resources.GetObject("tbsub.Font")));
			this.tbsub.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsub.ImeMode")));
			this.tbsub.Location = ((System.Drawing.Point)(resources.GetObject("tbsub.Location")));
			this.tbsub.MaxLength = ((int)(resources.GetObject("tbsub.MaxLength")));
			this.tbsub.Multiline = ((bool)(resources.GetObject("tbsub.Multiline")));
			this.tbsub.Name = "tbsub";
			this.tbsub.PasswordChar = ((char)(resources.GetObject("tbsub.PasswordChar")));
			this.tbsub.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsub.RightToLeft")));
			this.tbsub.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsub.ScrollBars")));
			this.tbsub.Size = ((System.Drawing.Size)(resources.GetObject("tbsub.Size")));
			this.tbsub.TabIndex = ((int)(resources.GetObject("tbsub.TabIndex")));
			this.tbsub.Text = resources.GetString("tbsub.Text");
			this.tbsub.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsub.TextAlign")));
			this.tbsub.Visible = ((bool)(resources.GetObject("tbsub.Visible")));
			this.tbsub.WordWrap = ((bool)(resources.GetObject("tbsub.WordWrap")));
			this.tbsub.TextChanged += new System.EventHandler(this.ChgSubject);
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
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
			// cbguid
			// 
			this.cbguid.AccessibleDescription = resources.GetString("cbguid.AccessibleDescription");
			this.cbguid.AccessibleName = resources.GetString("cbguid.AccessibleName");
			this.cbguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbguid.Anchor")));
			this.cbguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbguid.BackgroundImage")));
			this.cbguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbguid.Dock")));
			this.cbguid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbguid.Enabled = ((bool)(resources.GetObject("cbguid.Enabled")));
			this.cbguid.Font = ((System.Drawing.Font)(resources.GetObject("cbguid.Font")));
			this.cbguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbguid.ImeMode")));
			this.cbguid.IntegralHeight = ((bool)(resources.GetObject("cbguid.IntegralHeight")));
			this.cbguid.ItemHeight = ((int)(resources.GetObject("cbguid.ItemHeight")));
			this.cbguid.Location = ((System.Drawing.Point)(resources.GetObject("cbguid.Location")));
			this.cbguid.MaxDropDownItems = ((int)(resources.GetObject("cbguid.MaxDropDownItems")));
			this.cbguid.MaxLength = ((int)(resources.GetObject("cbguid.MaxLength")));
			this.cbguid.Name = "cbguid";
			this.cbguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbguid.RightToLeft")));
			this.cbguid.Size = ((System.Drawing.Size)(resources.GetObject("cbguid.Size")));
			this.cbguid.TabIndex = ((int)(resources.GetObject("cbguid.TabIndex")));
			this.cbguid.Text = resources.GetString("cbguid.Text");
			this.cbguid.Visible = ((bool)(resources.GetObject("cbguid.Visible")));
			this.cbguid.SelectedIndexChanged += new System.EventHandler(this.ChgGuidItem);
			// 
			// tbguid
			// 
			this.tbguid.AccessibleDescription = resources.GetString("tbguid.AccessibleDescription");
			this.tbguid.AccessibleName = resources.GetString("tbguid.AccessibleName");
			this.tbguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbguid.Anchor")));
			this.tbguid.AutoSize = ((bool)(resources.GetObject("tbguid.AutoSize")));
			this.tbguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbguid.BackgroundImage")));
			this.tbguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbguid.Dock")));
			this.tbguid.Enabled = ((bool)(resources.GetObject("tbguid.Enabled")));
			this.tbguid.Font = ((System.Drawing.Font)(resources.GetObject("tbguid.Font")));
			this.tbguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbguid.ImeMode")));
			this.tbguid.Location = ((System.Drawing.Point)(resources.GetObject("tbguid.Location")));
			this.tbguid.MaxLength = ((int)(resources.GetObject("tbguid.MaxLength")));
			this.tbguid.Multiline = ((bool)(resources.GetObject("tbguid.Multiline")));
			this.tbguid.Name = "tbguid";
			this.tbguid.PasswordChar = ((char)(resources.GetObject("tbguid.PasswordChar")));
			this.tbguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbguid.RightToLeft")));
			this.tbguid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbguid.ScrollBars")));
			this.tbguid.Size = ((System.Drawing.Size)(resources.GetObject("tbguid.Size")));
			this.tbguid.TabIndex = ((int)(resources.GetObject("tbguid.TabIndex")));
			this.tbguid.Text = resources.GetString("tbguid.Text");
			this.tbguid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbguid.TextAlign")));
			this.tbguid.Visible = ((bool)(resources.GetObject("tbguid.Visible")));
			this.tbguid.WordWrap = ((bool)(resources.GetObject("tbguid.WordWrap")));
			this.tbguid.TextChanged += new System.EventHandler(this.ChgGuid);
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
			// cbaction
			// 
			this.cbaction.AccessibleDescription = resources.GetString("cbaction.AccessibleDescription");
			this.cbaction.AccessibleName = resources.GetString("cbaction.AccessibleName");
			this.cbaction.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbaction.Anchor")));
			this.cbaction.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbaction.Appearance")));
			this.cbaction.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbaction.BackgroundImage")));
			this.cbaction.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbaction.CheckAlign")));
			this.cbaction.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbaction.Dock")));
			this.cbaction.Enabled = ((bool)(resources.GetObject("cbaction.Enabled")));
			this.cbaction.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbaction.FlatStyle")));
			this.cbaction.Font = ((System.Drawing.Font)(resources.GetObject("cbaction.Font")));
			this.cbaction.Image = ((System.Drawing.Image)(resources.GetObject("cbaction.Image")));
			this.cbaction.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbaction.ImageAlign")));
			this.cbaction.ImageIndex = ((int)(resources.GetObject("cbaction.ImageIndex")));
			this.cbaction.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbaction.ImeMode")));
			this.cbaction.Location = ((System.Drawing.Point)(resources.GetObject("cbaction.Location")));
			this.cbaction.Name = "cbaction";
			this.cbaction.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbaction.RightToLeft")));
			this.cbaction.Size = ((System.Drawing.Size)(resources.GetObject("cbaction.Size")));
			this.cbaction.TabIndex = ((int)(resources.GetObject("cbaction.TabIndex")));
			this.cbaction.Text = resources.GetString("cbaction.Text");
			this.cbaction.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbaction.TextAlign")));
			this.cbaction.Visible = ((bool)(resources.GetObject("cbaction.Visible")));
			this.cbaction.CheckedChanged += new System.EventHandler(this.ChgFlags);
			// 
			// cbvis
			// 
			this.cbvis.AccessibleDescription = resources.GetString("cbvis.AccessibleDescription");
			this.cbvis.AccessibleName = resources.GetString("cbvis.AccessibleName");
			this.cbvis.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbvis.Anchor")));
			this.cbvis.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbvis.Appearance")));
			this.cbvis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbvis.BackgroundImage")));
			this.cbvis.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvis.CheckAlign")));
			this.cbvis.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbvis.Dock")));
			this.cbvis.Enabled = ((bool)(resources.GetObject("cbvis.Enabled")));
			this.cbvis.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbvis.FlatStyle")));
			this.cbvis.Font = ((System.Drawing.Font)(resources.GetObject("cbvis.Font")));
			this.cbvis.Image = ((System.Drawing.Image)(resources.GetObject("cbvis.Image")));
			this.cbvis.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvis.ImageAlign")));
			this.cbvis.ImageIndex = ((int)(resources.GetObject("cbvis.ImageIndex")));
			this.cbvis.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbvis.ImeMode")));
			this.cbvis.Location = ((System.Drawing.Point)(resources.GetObject("cbvis.Location")));
			this.cbvis.Name = "cbvis";
			this.cbvis.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbvis.RightToLeft")));
			this.cbvis.Size = ((System.Drawing.Size)(resources.GetObject("cbvis.Size")));
			this.cbvis.TabIndex = ((int)(resources.GetObject("cbvis.TabIndex")));
			this.cbvis.Text = resources.GetString("cbvis.Text");
			this.cbvis.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbvis.TextAlign")));
			this.cbvis.Visible = ((bool)(resources.GetObject("cbvis.Visible")));
			this.cbvis.CheckedChanged += new System.EventHandler(this.ChgFlags);
			// 
			// tbFlag
			// 
			this.tbFlag.AccessibleDescription = resources.GetString("tbFlag.AccessibleDescription");
			this.tbFlag.AccessibleName = resources.GetString("tbFlag.AccessibleName");
			this.tbFlag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbFlag.Anchor")));
			this.tbFlag.AutoSize = ((bool)(resources.GetObject("tbFlag.AutoSize")));
			this.tbFlag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbFlag.BackgroundImage")));
			this.tbFlag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbFlag.Dock")));
			this.tbFlag.Enabled = ((bool)(resources.GetObject("tbFlag.Enabled")));
			this.tbFlag.Font = ((System.Drawing.Font)(resources.GetObject("tbFlag.Font")));
			this.tbFlag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbFlag.ImeMode")));
			this.tbFlag.Location = ((System.Drawing.Point)(resources.GetObject("tbFlag.Location")));
			this.tbFlag.MaxLength = ((int)(resources.GetObject("tbFlag.MaxLength")));
			this.tbFlag.Multiline = ((bool)(resources.GetObject("tbFlag.Multiline")));
			this.tbFlag.Name = "tbFlag";
			this.tbFlag.PasswordChar = ((char)(resources.GetObject("tbFlag.PasswordChar")));
			this.tbFlag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbFlag.RightToLeft")));
			this.tbFlag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbFlag.ScrollBars")));
			this.tbFlag.Size = ((System.Drawing.Size)(resources.GetObject("tbFlag.Size")));
			this.tbFlag.TabIndex = ((int)(resources.GetObject("tbFlag.TabIndex")));
			this.tbFlag.Text = resources.GetString("tbFlag.Text");
			this.tbFlag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbFlag.TextAlign")));
			this.tbFlag.Visible = ((bool)(resources.GetObject("tbFlag.Visible")));
			this.tbFlag.WordWrap = ((bool)(resources.GetObject("tbFlag.WordWrap")));
			this.tbFlag.TextChanged += new System.EventHandler(this.ChgFlag);
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
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pb.SizeMode")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TabStop = false;
			this.pb.Text = resources.GetString("pb.Text");
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			// 
			// lbdata
			// 
			this.lbdata.AccessibleDescription = resources.GetString("lbdata.AccessibleDescription");
			this.lbdata.AccessibleName = resources.GetString("lbdata.AccessibleName");
			this.lbdata.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbdata.Anchor")));
			this.lbdata.AutoSize = ((bool)(resources.GetObject("lbdata.AutoSize")));
			this.lbdata.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbdata.BackgroundImage")));
			this.lbdata.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbdata.Dock")));
			this.lbdata.Enabled = ((bool)(resources.GetObject("lbdata.Enabled")));
			this.lbdata.Font = ((System.Drawing.Font)(resources.GetObject("lbdata.Font")));
			this.lbdata.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbdata.ImeMode")));
			this.lbdata.Location = ((System.Drawing.Point)(resources.GetObject("lbdata.Location")));
			this.lbdata.MaxLength = ((int)(resources.GetObject("lbdata.MaxLength")));
			this.lbdata.Multiline = ((bool)(resources.GetObject("lbdata.Multiline")));
			this.lbdata.Name = "lbdata";
			this.lbdata.PasswordChar = ((char)(resources.GetObject("lbdata.PasswordChar")));
			this.lbdata.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbdata.RightToLeft")));
			this.lbdata.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("lbdata.ScrollBars")));
			this.lbdata.Size = ((System.Drawing.Size)(resources.GetObject("lbdata.Size")));
			this.lbdata.TabIndex = ((int)(resources.GetObject("lbdata.TabIndex")));
			this.lbdata.Text = resources.GetString("lbdata.Text");
			this.lbdata.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("lbdata.TextAlign")));
			this.lbdata.Visible = ((bool)(resources.GetObject("lbdata.Visible")));
			this.lbdata.WordWrap = ((bool)(resources.GetObject("lbdata.WordWrap")));
			this.lbdata.TextChanged += new System.EventHandler(this.ChgData);
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedIndexChanged += new System.EventHandler(this.SelectSim);
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
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
			// NgbhForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.ngbhPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "NgbhForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.ngbhPanel.ResumeLayout(false);
			this.gbmem.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		internal System.Windows.Forms.Panel ngbhPanel;
		internal System.Windows.Forms.ListView lv;
		internal System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbFlag;
		private System.Windows.Forms.CheckBox cbvis;
		private System.Windows.Forms.CheckBox cbaction;
		private System.Windows.Forms.TextBox tbguid;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.ComboBox cbguid;
		internal System.Windows.Forms.ComboBox cbsub;
		private System.Windows.Forms.TextBox tbsub;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox lbdata;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbsubid;
		internal System.Windows.Forms.GroupBox gbmem;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.PictureBox pb;
		internal System.Windows.Forms.ComboBox cbown;
		private System.Windows.Forms.TextBox tbown;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.ImageList memilist;
		internal System.Windows.Forms.ListView lbmem;
		private System.Windows.Forms.LinkLabel linkLabel2;
		internal System.Windows.Forms.Button btdown;
		internal System.Windows.Forms.Button btup;
		internal System.Windows.Forms.ComboBox cbtype;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbUnk;
		private System.Windows.Forms.TextBox tbval;
		private System.Windows.Forms.Label label6;

		internal IFileWrapperSaveExtension wrapper;

		protected void AddItem(NgbhItem item)
		{
			if (item==null) return;
			ListViewItem lvi = new ListViewItem();
			lvi.Text = item.ToString();
			lvi.Tag = item;

			if (item.MemoryCacheItem.Icon!=null) 
			{
				lvi.ImageIndex = memilist.Images.Count;

				memilist.Images.Add(item.MemoryCacheItem.Icon);
			}

			lbmem.Items.Add(lvi);
		}

		private void tbval_TextChanged(object sender, System.EventArgs e)
		{
			if (tbFlag.Tag!=null) return;
			try 
			{
				if (Helper.WindowsRegistry.HiddenMode)
					GetSelectedItem().Value = Helper.StringToUInt16(tbval.Text, GetSelectedItem().Value, 16);
				else
					GetSelectedItem().Value = Helper.StringToUInt16(tbval.Text, GetSelectedItem().Value, 10);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void tbUnk_TextChanged(object sender, System.EventArgs e)
		{
			if (tbFlag.Tag!=null) return;
			try 
			{
				GetSelectedItem().InventoryNumber = Helper.StringToUInt32(tbUnk.Text, GetSelectedItem().InventoryNumber, 16);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ItemUp(object sender, System.EventArgs e)
		{
			if (lbmem.SelectedItems.Count==0) return;
			int SelectedIndex = lbmem.SelectedItems[0].Index;
			if (SelectedIndex<1) return;

			ListViewItem lvi = (ListViewItem)lbmem.Items[SelectedIndex];
			
			lbmem.Items[SelectedIndex] = (ListViewItem)lbmem.Items[SelectedIndex-1].Clone();
			lbmem.Items[SelectedIndex-1] = (ListViewItem)lvi.Clone();
			lbmem.Items[SelectedIndex-1].Selected = true;


			try 
			{
				//change also in the Items List
				Ngbh wrp = (Ngbh)wrapper;
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
				NgbhSlot slot = wrp.Sims.GetInstanceSlot(sdesc.Instance);
				NgbhItem i = slot.ItemsB[SelectedIndex- 1];
				slot.ItemsB[SelectedIndex-1] = slot.ItemsB[SelectedIndex];
				slot.ItemsB[SelectedIndex] = i;
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ItemDown(object sender, System.EventArgs e)
		{
			if (lbmem.SelectedItems.Count==0) return;
			int SelectedIndex = lbmem.SelectedItems[0].Index;
			if (SelectedIndex<0) return;
			if (SelectedIndex>lbmem.Items.Count-2) return;

			ListViewItem lvi = (ListViewItem)lbmem.Items[SelectedIndex];
			lbmem.Items[SelectedIndex] = (ListViewItem)lbmem.Items[SelectedIndex+1].Clone();
			lbmem.Items[SelectedIndex+1] = (ListViewItem)lvi.Clone();
			lbmem.Items[SelectedIndex+1].Selected = true;

			try 
			{
				//change also in the Items List
				Ngbh wrp = (Ngbh)wrapper;
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
				NgbhSlot slot = wrp.Sims.GetInstanceSlot(sdesc.Instance);
				NgbhItem i = slot.ItemsB[SelectedIndex + 1];
				slot.ItemsB[SelectedIndex + 1] = slot.ItemsB[SelectedIndex];
				slot.ItemsB[SelectedIndex] = i;
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		protected void UpdateMemItem(NgbhItem item)
		{
			if (lbmem.SelectedItems.Count>0) 
			{
				lbmem.SelectedItems[0].Text = item.ToString();

				if ((item.MemoryCacheItem.Icon!=null) && (lbmem.SelectedItems[0].ImageIndex>=0)) 
				{
					int id = lbmem.SelectedItems[0].ImageIndex;
					lbmem.SelectedItems[0].ImageIndex = -1;
					System.Drawing.Image simg = item.MemoryCacheItem.Icon;
					Bitmap img = new Bitmap(memilist.ImageSize.Width, memilist.ImageSize.Height);
					Graphics gr = Graphics.FromImage(img);
					gr.DrawImage(
						simg, 
						0,
						0,
						memilist.ImageSize.Width, 
						memilist.ImageSize.Height
						);


					memilist.Images[id] = img;
					pb.Image = simg;
					lbmem.SelectedItems[0].ImageIndex = id;
				}
			}
		}

		private void IOwn(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count==0) return;
			try 
			{
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;

				cbown.SelectedIndex = 0;
				for(int i=0; i<cbown.Items.Count; i++)
				{
					Interfaces.IAlias a = (Interfaces.IAlias)cbown.Items[i];
					if (a.Tag==null) continue;
					ushort inst = (ushort)a.Tag[0];
					if (inst == sdesc.Instance) 
					{
						cbown.SelectedIndex = i;
						break;
					}
				}
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void SelectSim(object sender, System.EventArgs e)
		{
			gbmem.Enabled = false;
			memilist.Images.Clear();
			if (lv.SelectedItems.Count < 1) return;
			gbmem.Enabled = true;

			this.Cursor = Cursors.WaitCursor;
			try 
			{
				lbname.Text = lv.SelectedItems[0].Text;
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
				lbmem.Items.Clear();
			
				Ngbh wrp = (Ngbh)wrapper;
				Collections.NgbhItems items = wrp.GetItems((Data.NeighborhoodSlots)cbtype.SelectedIndex, sdesc.Instance);							
				
				if (items!=null)
					foreach (NgbhItem item in items) this.AddItem(item);				

				if (lbmem.Items.Count>0) lbmem.Items[0].Selected = true;
			} 
			catch (Exception ex) 
			{
				this.Cursor = Cursors.Default;
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			this.Cursor = Cursors.Default;
		}

		protected NgbhItem GetSelectedItem()
		{
			if (this.lbmem.SelectedItems.Count==0) return new NgbhItem(new NgbhSlot((Ngbh)wrapper));
			return (NgbhItem)lbmem.SelectedItems[0].Tag;
		}

		

		private void SelectMemory(object sender, System.EventArgs e)
		{
			tbFlag.Tag = true;
			this.cbvis.Checked = GetSelectedItem().Flags.IsVisible;
			this.cbaction.Checked = GetSelectedItem().Flags.IsControler;
			this.tbFlag.Text = "0x"+Helper.HexString(GetSelectedItem().Flags.Value);

			this.tbUnk.Enabled = (uint)GetSelectedItem().ParentSlot.Version >= (uint)NgbhVersion.Nightlife;
			this.tbUnk.Text = "0x"+Helper.HexString(GetSelectedItem().InventoryNumber);
			if (Helper.WindowsRegistry.HiddenMode)
				this.tbval.Text = "0x"+Helper.HexString(GetSelectedItem().Value);
			else
				this.tbval.Text = GetSelectedItem().Value.ToString();

			tbFlag.Tag = null;

			tbguid.Tag = true;
			tbguid.Text = "0x"+Helper.HexString(GetSelectedItem().Guid);
			cbguid.SelectedIndex = 0;
			for(int i=0; i<cbguid.Items.Count; i++)
			{
				Interfaces.IAlias a = (Interfaces.IAlias)cbguid.Items[i];
				if (a.Id == GetSelectedItem().Guid) 
				{
					cbguid.SelectedIndex = i;
					break;
				}
			}
			tbguid.Tag = null;

			tbsub.Tag = true;
			tbsub.Text = "0x"+Helper.HexString(GetSelectedItem().SimInstance);
			tbsubid.Text = "0x"+Helper.HexString(GetSelectedItem().SimID);
			cbsub.SelectedIndex = 0;
			for(int i=0; i<cbsub.Items.Count; i++)
			{
				Interfaces.IAlias a = (Interfaces.IAlias)cbsub.Items[i];
				if (a.Id == GetSelectedItem().SimID) 
				{
					cbsub.SelectedIndex = i;
					break;
				}
			}
			tbsub.Tag = null;

			tbown.Tag = true;
			tbown.Text = "0x"+Helper.HexString(GetSelectedItem().OwnerInstance);
			cbown.SelectedIndex = 0;
			for(int i=0; i<cbown.Items.Count; i++)
			{
				Interfaces.IAlias a = (Interfaces.IAlias)cbown.Items[i];
				if (a.Tag==null) continue;
				ushort inst = (ushort)a.Tag[0];
				if (inst == GetSelectedItem().OwnerInstance) 
				{
					cbown.SelectedIndex = i;
					break;
				}
			}
			tbown.Tag = null;

			lbdata.Tag = true;
			lbdata.Text = "";
			foreach (ushort s in GetSelectedItem().Data) lbdata.Text += Helper.HexString(s) + " ";
			lbdata.Tag = null;

			pb.Image = GetSelectedItem().MemoryCacheItem.Icon;
		}

		private void ChgFlags(object sender, System.EventArgs e)
		{
			if (tbFlag.Tag!=null) return;
			tbFlag.Tag = true;
			GetSelectedItem().Flags.IsVisible = this.cbvis.Checked;
			GetSelectedItem().Flags.IsControler = this.cbaction.Checked;
			this.tbFlag.Text = "0x"+Helper.HexString(GetSelectedItem().Flags.Value);
			this.UpdateMemItem(GetSelectedItem());
			tbFlag.Tag = null;
		}

		private void ChgFlag(object sender, System.EventArgs e)
		{
			if (tbFlag.Tag!=null) return;
			try 
			{
				GetSelectedItem().Flags.Value = Convert.ToUInt16(tbFlag.Text, 16);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ChgGuidItem(object sender, System.EventArgs e)
		{
			if (tbguid.Tag != null) return;
			
			if (cbguid.SelectedIndex<1) return;
			Interfaces.IAlias a = (Interfaces.IAlias)cbguid.Items[cbguid.SelectedIndex];
			tbguid.Text = "0x"+Helper.HexString(a.Id);
		}

		private void ChgGuid(object sender, System.EventArgs e)
		{
			if (tbguid.Tag!=null) return;

			try 
			{
				GetSelectedItem().Guid = Convert.ToUInt32(tbguid.Text, 16);
				this.UpdateMemItem(GetSelectedItem());
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ChgSubjectItem(object sender, System.EventArgs e)
		{
			if (tbsub.Tag != null) return;
			
			if (cbsub.SelectedIndex<1) return;
			Interfaces.IAlias a = (Interfaces.IAlias)cbsub.Items[cbsub.SelectedIndex];
			tbsubid.Text = "0x"+Helper.HexString(a.Id);
			if (a.Tag!=null)
				tbsub.Text = "0x"+Helper.HexString((ushort)a.Tag[0]);
			else
				tbsub.Text = "0x0000";
		}

		private void ChgSubject(object sender, System.EventArgs e)
		{
			if (tbsub.Tag!=null) return;

			try 
			{
				GetSelectedItem().SimInstance = Convert.ToUInt16(tbsub.Text, 16);
				this.UpdateMemItem(GetSelectedItem());
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ChgSubjectID(object sender, System.EventArgs e)
		{
			if (tbsub.Tag!=null) return;

			try 
			{
				GetSelectedItem().SimID = Convert.ToUInt32(tbsubid.Text, 16);
				this.UpdateMemItem(GetSelectedItem());
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void ChgOwnerItem(object sender, System.EventArgs e)
		{
			if (tbown.Tag != null) return;
			
			if (cbown.SelectedIndex<1) return;
			Interfaces.IAlias a = (Interfaces.IAlias)cbown.Items[cbown.SelectedIndex];
			if (a.Tag!=null)
				tbown.Text = "0x"+Helper.HexString((ushort)a.Tag[0]);
			else
				tbown.Text = "0x0000";
		}

		private void ChgOwner(object sender, System.EventArgs e)
		{
			if (tbown.Tag!=null) return;

			try 
			{
				GetSelectedItem().OwnerInstance = Convert.ToUInt16(tbown.Text, 16);
				this.UpdateMemItem(GetSelectedItem());
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}


		private void ChgData(object sender, System.EventArgs e)
		{
			if (lbdata.Tag != null) return;

			string[] tokens = lbdata.Text.Split(" ".ToCharArray());
			ushort[] data = new ushort[tokens.Length];

			try 
			{
				for(int i=0; i<tokens.Length; i++)
				{
					if (tokens[i].Trim()!="")
						data[i] = Convert.ToUInt16(tokens[i], 16);
					else
						data[i] = 0;
				}

				this.GetSelectedItem().Data = data;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void Commit(object sender, System.EventArgs e)
		{
			try 
			{
				Ngbh wrp = (Ngbh)wrapper;
				wrp.SynchronizeUserData();MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void DeleteItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbmem.SelectedItems.Count==0) return;
			if (cbtype.SelectedIndex%2==1)
				GetSelectedItem().RemoveFromParentB();
			else
				GetSelectedItem().RemoveFromParentA();

			lbmem.Items.Remove(lbmem.SelectedItems[0]);
		}

		private void AddItem(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lv.SelectedItems.Count<=0) return;

			this.Cursor = Cursors.WaitCursor;
			try 
			{
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
			
				Ngbh wrp = (Ngbh)wrapper;
				NgbhSlot slot = wrp.GetSlots((Data.NeighborhoodSlots)cbtype.SelectedIndex).GetInstanceSlot(sdesc.Instance, true);
				if (slot!=null) 
				{
					NgbhItem item = slot.GetItems((Data.NeighborhoodSlots)cbtype.SelectedIndex).AddNew();
				 
					item.PutValue(0x01, 0x07CD);
					item.PutValue(0x02, 0x0007);
					item.PutValue(0x0B, 0);
					item.Flags.IsVisible = true;
					item.Flags.IsControler = false;
					this.AddItem(item);
					lbmem.Items[lbmem.Items.Count-1].Selected = true;
				}
			} 
			catch (Exception ex) 
			{
				this.Cursor = Cursors.Default;
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
			this.Cursor = Cursors.Default;

		}

		
	}
}
