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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für PhotoStudio.
	/// </summary>
	public class PhotoStudio : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Button btopen;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.Label lbname;
		private System.Windows.Forms.Label lbsize;
		private System.Windows.Forms.LinkLabel llcreate;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbquality;
		private System.Windows.Forms.ListView lvbase;
		private System.Windows.Forms.ImageList ibase;
		private System.Windows.Forms.PictureBox pbpreview;
		private System.Windows.Forms.CheckBox cbprev;
		private System.Windows.Forms.CheckBox cbflip;
		private System.ComponentModel.IContainer components;

		public PhotoStudio()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			
			//load all additional Package Templates
			string[] files = System.IO.Directory.GetFiles(Helper.SimPeDataPath, "*.template");

			if (files.Length==0) 
			{
				SimPe.WaitingScreen.Stop();
				if (MessageBox.Show("SimPE didn't find a PhotoStudio Template in the Data Folder. It can download and install the needed Files from the SimPE Homepage (1.9MB).\n\nDo you want SimPE to download and install the Templates?", "Information", MessageBoxButtons.YesNo)==DialogResult.Yes)
				{
					SimPe.WebUpdate.InstallTemplates();
					files = System.IO.Directory.GetFiles(Helper.SimPeDataPath, "*.template");
					SimPe.WaitingScreen.Wait();
				}
			} 
			else 
			{
				SimPe.WaitingScreen.Wait();
			}

			//cbbase.Items.Clear();
			
			foreach (string file in files)
			{
				SimPe.Packages.File pkg = new SimPe.Packages.File(file);
				PhotoStudioTemplate pst = new PhotoStudioTemplate(pkg);

				ListViewItem lvi = new ListViewItem(pst.ToString());
				lvi.ImageIndex = ibase.Images.Count;
				lvi.Tag = pst;

				Image img = new Bitmap(ibase.ImageSize.Width, ibase.ImageSize.Height);
				img = ImageLoader.Preview(pst.Texture, img.Size);
				SimPe.WaitingScreen.UpdateImage(img);
				ibase.Images.Add(img);
				lvbase.Items.Add(lvi);

				//cbbase.Items.Add(pst);
			}
			if (lvbase.Items.Count>0) lvbase.Items[0].Selected = true;

			sfd.InitialDirectory = System.IO.Path.Combine(Helper.WindowsRegistry.SimSavegameFolder, "Downloads");

			cbquality.SelectedIndex = 0;
			if (System.IO.File.Exists(Helper.WindowsRegistry.NvidiaDDSTool)) 
			{
				cbquality.Items.Add("Use Nvidia DDS Tools");
				cbquality.SelectedIndex = cbquality.Items.Count-1;
			}
			SimPe.WaitingScreen.Stop();
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(PhotoStudio));
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.lbsize = new System.Windows.Forms.Label();
			this.lbname = new System.Windows.Forms.Label();
			this.btopen = new System.Windows.Forms.Button();
			this.pb = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.lv = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.llcreate = new System.Windows.Forms.LinkLabel();
			this.label2 = new System.Windows.Forms.Label();
			this.cbquality = new System.Windows.Forms.ComboBox();
			this.lvbase = new System.Windows.Forms.ListView();
			this.ibase = new System.Windows.Forms.ImageList(this.components);
			this.pbpreview = new System.Windows.Forms.PictureBox();
			this.cbprev = new System.Windows.Forms.CheckBox();
			this.cbflip = new System.Windows.Forms.CheckBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = resources.GetString("tabControl1.AccessibleDescription");
			this.tabControl1.AccessibleName = resources.GetString("tabControl1.AccessibleName");
			this.tabControl1.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl1.Alignment")));
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl1.Anchor")));
			this.tabControl1.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl1.Appearance")));
			this.tabControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl1.BackgroundImage")));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl1.Dock")));
			this.tabControl1.Enabled = ((bool)(resources.GetObject("tabControl1.Enabled")));
			this.tabControl1.Font = ((System.Drawing.Font)(resources.GetObject("tabControl1.Font")));
			this.tabControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl1.ImeMode")));
			this.tabControl1.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControl1.ItemSize")));
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl1.Padding")));
			this.tabControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl1.RightToLeft")));
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = ((bool)(resources.GetObject("tabControl1.ShowToolTips")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			this.tabControl1.TabIndex = ((int)(resources.GetObject("tabControl1.TabIndex")));
			this.tabControl1.Text = resources.GetString("tabControl1.Text");
			this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
			this.tabControl1.Visible = ((bool)(resources.GetObject("tabControl1.Visible")));
			this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.lvbase_SelectedIndexChanged);
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleDescription = resources.GetString("tabPage1.AccessibleDescription");
			this.tabPage1.AccessibleName = resources.GetString("tabPage1.AccessibleName");
			this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
			this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
			this.tabPage1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMargin")));
			this.tabPage1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMinSize")));
			this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
			this.tabPage1.Controls.Add(this.lbsize);
			this.tabPage1.Controls.Add(this.lbname);
			this.tabPage1.Controls.Add(this.btopen);
			this.tabPage1.Controls.Add(this.pb);
			this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
			this.tabPage1.Enabled = ((bool)(resources.GetObject("tabPage1.Enabled")));
			this.tabPage1.Font = ((System.Drawing.Font)(resources.GetObject("tabPage1.Font")));
			this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
			this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
			this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
			this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
			this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
			this.tabPage1.Text = resources.GetString("tabPage1.Text");
			this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
			this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
			this.tabPage1.Visible = ((bool)(resources.GetObject("tabPage1.Visible")));
			// 
			// lbsize
			// 
			this.lbsize.AccessibleDescription = resources.GetString("lbsize.AccessibleDescription");
			this.lbsize.AccessibleName = resources.GetString("lbsize.AccessibleName");
			this.lbsize.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbsize.Anchor")));
			this.lbsize.AutoSize = ((bool)(resources.GetObject("lbsize.AutoSize")));
			this.lbsize.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbsize.Dock")));
			this.lbsize.Enabled = ((bool)(resources.GetObject("lbsize.Enabled")));
			this.lbsize.Font = ((System.Drawing.Font)(resources.GetObject("lbsize.Font")));
			this.lbsize.Image = ((System.Drawing.Image)(resources.GetObject("lbsize.Image")));
			this.lbsize.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbsize.ImageAlign")));
			this.lbsize.ImageIndex = ((int)(resources.GetObject("lbsize.ImageIndex")));
			this.lbsize.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbsize.ImeMode")));
			this.lbsize.Location = ((System.Drawing.Point)(resources.GetObject("lbsize.Location")));
			this.lbsize.Name = "lbsize";
			this.lbsize.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbsize.RightToLeft")));
			this.lbsize.Size = ((System.Drawing.Size)(resources.GetObject("lbsize.Size")));
			this.lbsize.TabIndex = ((int)(resources.GetObject("lbsize.TabIndex")));
			this.lbsize.Text = resources.GetString("lbsize.Text");
			this.lbsize.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbsize.TextAlign")));
			this.toolTip1.SetToolTip(this.lbsize, resources.GetString("lbsize.ToolTip"));
			this.lbsize.Visible = ((bool)(resources.GetObject("lbsize.Visible")));
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
			this.toolTip1.SetToolTip(this.lbname, resources.GetString("lbname.ToolTip"));
			this.lbname.Visible = ((bool)(resources.GetObject("lbname.Visible")));
			// 
			// btopen
			// 
			this.btopen.AccessibleDescription = resources.GetString("btopen.AccessibleDescription");
			this.btopen.AccessibleName = resources.GetString("btopen.AccessibleName");
			this.btopen.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btopen.Anchor")));
			this.btopen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btopen.BackgroundImage")));
			this.btopen.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btopen.Dock")));
			this.btopen.Enabled = ((bool)(resources.GetObject("btopen.Enabled")));
			this.btopen.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btopen.FlatStyle")));
			this.btopen.Font = ((System.Drawing.Font)(resources.GetObject("btopen.Font")));
			this.btopen.Image = ((System.Drawing.Image)(resources.GetObject("btopen.Image")));
			this.btopen.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btopen.ImageAlign")));
			this.btopen.ImageIndex = ((int)(resources.GetObject("btopen.ImageIndex")));
			this.btopen.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btopen.ImeMode")));
			this.btopen.Location = ((System.Drawing.Point)(resources.GetObject("btopen.Location")));
			this.btopen.Name = "btopen";
			this.btopen.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btopen.RightToLeft")));
			this.btopen.Size = ((System.Drawing.Size)(resources.GetObject("btopen.Size")));
			this.btopen.TabIndex = ((int)(resources.GetObject("btopen.TabIndex")));
			this.btopen.Text = resources.GetString("btopen.Text");
			this.btopen.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btopen.TextAlign")));
			this.toolTip1.SetToolTip(this.btopen, resources.GetString("btopen.ToolTip"));
			this.btopen.Visible = ((bool)(resources.GetObject("btopen.Visible")));
			this.btopen.Click += new System.EventHandler(this.OpenImage);
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.toolTip1.SetToolTip(this.pb, resources.GetString("pb.ToolTip"));
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			// 
			// tabPage2
			// 
			this.tabPage2.AccessibleDescription = resources.GetString("tabPage2.AccessibleDescription");
			this.tabPage2.AccessibleName = resources.GetString("tabPage2.AccessibleName");
			this.tabPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage2.Anchor")));
			this.tabPage2.AutoScroll = ((bool)(resources.GetObject("tabPage2.AutoScroll")));
			this.tabPage2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMargin")));
			this.tabPage2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMinSize")));
			this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
			this.tabPage2.Controls.Add(this.lv);
			this.tabPage2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage2.Dock")));
			this.tabPage2.Enabled = ((bool)(resources.GetObject("tabPage2.Enabled")));
			this.tabPage2.Font = ((System.Drawing.Font)(resources.GetObject("tabPage2.Font")));
			this.tabPage2.ImageIndex = ((int)(resources.GetObject("tabPage2.ImageIndex")));
			this.tabPage2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage2.ImeMode")));
			this.tabPage2.Location = ((System.Drawing.Point)(resources.GetObject("tabPage2.Location")));
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage2.RightToLeft")));
			this.tabPage2.Size = ((System.Drawing.Size)(resources.GetObject("tabPage2.Size")));
			this.tabPage2.TabIndex = ((int)(resources.GetObject("tabPage2.TabIndex")));
			this.tabPage2.Text = resources.GetString("tabPage2.Text");
			this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
			this.tabPage2.ToolTipText = resources.GetString("tabPage2.ToolTipText");
			this.tabPage2.Visible = ((bool)(resources.GetObject("tabPage2.Visible")));
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.toolTip1.SetToolTip(this.lv, resources.GetString("lv.ToolTip"));
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lvbase_SelectedIndexChanged);
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
			this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// llcreate
			// 
			this.llcreate.AccessibleDescription = resources.GetString("llcreate.AccessibleDescription");
			this.llcreate.AccessibleName = resources.GetString("llcreate.AccessibleName");
			this.llcreate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcreate.Anchor")));
			this.llcreate.AutoSize = ((bool)(resources.GetObject("llcreate.AutoSize")));
			this.llcreate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcreate.Dock")));
			this.llcreate.Enabled = ((bool)(resources.GetObject("llcreate.Enabled")));
			this.llcreate.Font = ((System.Drawing.Font)(resources.GetObject("llcreate.Font")));
			this.llcreate.Image = ((System.Drawing.Image)(resources.GetObject("llcreate.Image")));
			this.llcreate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcreate.ImageAlign")));
			this.llcreate.ImageIndex = ((int)(resources.GetObject("llcreate.ImageIndex")));
			this.llcreate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcreate.ImeMode")));
			this.llcreate.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcreate.LinkArea")));
			this.llcreate.Location = ((System.Drawing.Point)(resources.GetObject("llcreate.Location")));
			this.llcreate.Name = "llcreate";
			this.llcreate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcreate.RightToLeft")));
			this.llcreate.Size = ((System.Drawing.Size)(resources.GetObject("llcreate.Size")));
			this.llcreate.TabIndex = ((int)(resources.GetObject("llcreate.TabIndex")));
			this.llcreate.TabStop = true;
			this.llcreate.Text = resources.GetString("llcreate.Text");
			this.llcreate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcreate.TextAlign")));
			this.toolTip1.SetToolTip(this.llcreate, resources.GetString("llcreate.ToolTip"));
			this.llcreate.Visible = ((bool)(resources.GetObject("llcreate.Visible")));
			this.llcreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateImage);
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
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// cbquality
			// 
			this.cbquality.AccessibleDescription = resources.GetString("cbquality.AccessibleDescription");
			this.cbquality.AccessibleName = resources.GetString("cbquality.AccessibleName");
			this.cbquality.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbquality.Anchor")));
			this.cbquality.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbquality.BackgroundImage")));
			this.cbquality.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbquality.Dock")));
			this.cbquality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbquality.Enabled = ((bool)(resources.GetObject("cbquality.Enabled")));
			this.cbquality.Font = ((System.Drawing.Font)(resources.GetObject("cbquality.Font")));
			this.cbquality.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbquality.ImeMode")));
			this.cbquality.IntegralHeight = ((bool)(resources.GetObject("cbquality.IntegralHeight")));
			this.cbquality.ItemHeight = ((int)(resources.GetObject("cbquality.ItemHeight")));
			this.cbquality.Items.AddRange(new object[] {
														   resources.GetString("cbquality.Items"),
														   resources.GetString("cbquality.Items1")});
			this.cbquality.Location = ((System.Drawing.Point)(resources.GetObject("cbquality.Location")));
			this.cbquality.MaxDropDownItems = ((int)(resources.GetObject("cbquality.MaxDropDownItems")));
			this.cbquality.MaxLength = ((int)(resources.GetObject("cbquality.MaxLength")));
			this.cbquality.Name = "cbquality";
			this.cbquality.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbquality.RightToLeft")));
			this.cbquality.Size = ((System.Drawing.Size)(resources.GetObject("cbquality.Size")));
			this.cbquality.TabIndex = ((int)(resources.GetObject("cbquality.TabIndex")));
			this.cbquality.Text = resources.GetString("cbquality.Text");
			this.toolTip1.SetToolTip(this.cbquality, resources.GetString("cbquality.ToolTip"));
			this.cbquality.Visible = ((bool)(resources.GetObject("cbquality.Visible")));
			// 
			// lvbase
			// 
			this.lvbase.AccessibleDescription = resources.GetString("lvbase.AccessibleDescription");
			this.lvbase.AccessibleName = resources.GetString("lvbase.AccessibleName");
			this.lvbase.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lvbase.Alignment")));
			this.lvbase.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lvbase.Anchor")));
			this.lvbase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvbase.BackgroundImage")));
			this.lvbase.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lvbase.Dock")));
			this.lvbase.Enabled = ((bool)(resources.GetObject("lvbase.Enabled")));
			this.lvbase.Font = ((System.Drawing.Font)(resources.GetObject("lvbase.Font")));
			this.lvbase.HideSelection = false;
			this.lvbase.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lvbase.ImeMode")));
			this.lvbase.LabelWrap = ((bool)(resources.GetObject("lvbase.LabelWrap")));
			this.lvbase.LargeImageList = this.ibase;
			this.lvbase.Location = ((System.Drawing.Point)(resources.GetObject("lvbase.Location")));
			this.lvbase.MultiSelect = false;
			this.lvbase.Name = "lvbase";
			this.lvbase.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lvbase.RightToLeft")));
			this.lvbase.Size = ((System.Drawing.Size)(resources.GetObject("lvbase.Size")));
			this.lvbase.TabIndex = ((int)(resources.GetObject("lvbase.TabIndex")));
			this.lvbase.Text = resources.GetString("lvbase.Text");
			this.toolTip1.SetToolTip(this.lvbase, resources.GetString("lvbase.ToolTip"));
			this.lvbase.Visible = ((bool)(resources.GetObject("lvbase.Visible")));
			this.lvbase.SelectedIndexChanged += new System.EventHandler(this.lvbase_SelectedIndexChanged);
			// 
			// ibase
			// 
			this.ibase.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ibase.ImageSize = ((System.Drawing.Size)(resources.GetObject("ibase.ImageSize")));
			this.ibase.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pbpreview
			// 
			this.pbpreview.AccessibleDescription = resources.GetString("pbpreview.AccessibleDescription");
			this.pbpreview.AccessibleName = resources.GetString("pbpreview.AccessibleName");
			this.pbpreview.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbpreview.Anchor")));
			this.pbpreview.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbpreview.BackgroundImage")));
			this.pbpreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbpreview.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pbpreview.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbpreview.Dock")));
			this.pbpreview.Enabled = ((bool)(resources.GetObject("pbpreview.Enabled")));
			this.pbpreview.Font = ((System.Drawing.Font)(resources.GetObject("pbpreview.Font")));
			this.pbpreview.Image = ((System.Drawing.Image)(resources.GetObject("pbpreview.Image")));
			this.pbpreview.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbpreview.ImeMode")));
			this.pbpreview.Location = ((System.Drawing.Point)(resources.GetObject("pbpreview.Location")));
			this.pbpreview.Name = "pbpreview";
			this.pbpreview.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbpreview.RightToLeft")));
			this.pbpreview.Size = ((System.Drawing.Size)(resources.GetObject("pbpreview.Size")));
			this.pbpreview.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbpreview.SizeMode")));
			this.pbpreview.TabIndex = ((int)(resources.GetObject("pbpreview.TabIndex")));
			this.pbpreview.TabStop = false;
			this.pbpreview.Text = resources.GetString("pbpreview.Text");
			this.toolTip1.SetToolTip(this.pbpreview, resources.GetString("pbpreview.ToolTip"));
			this.pbpreview.Visible = ((bool)(resources.GetObject("pbpreview.Visible")));
			this.pbpreview.Click += new System.EventHandler(this.pbpreview_Click);
			// 
			// cbprev
			// 
			this.cbprev.AccessibleDescription = resources.GetString("cbprev.AccessibleDescription");
			this.cbprev.AccessibleName = resources.GetString("cbprev.AccessibleName");
			this.cbprev.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbprev.Anchor")));
			this.cbprev.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbprev.Appearance")));
			this.cbprev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbprev.BackgroundImage")));
			this.cbprev.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbprev.CheckAlign")));
			this.cbprev.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbprev.Dock")));
			this.cbprev.Enabled = ((bool)(resources.GetObject("cbprev.Enabled")));
			this.cbprev.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbprev.FlatStyle")));
			this.cbprev.Font = ((System.Drawing.Font)(resources.GetObject("cbprev.Font")));
			this.cbprev.Image = ((System.Drawing.Image)(resources.GetObject("cbprev.Image")));
			this.cbprev.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbprev.ImageAlign")));
			this.cbprev.ImageIndex = ((int)(resources.GetObject("cbprev.ImageIndex")));
			this.cbprev.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbprev.ImeMode")));
			this.cbprev.Location = ((System.Drawing.Point)(resources.GetObject("cbprev.Location")));
			this.cbprev.Name = "cbprev";
			this.cbprev.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbprev.RightToLeft")));
			this.cbprev.Size = ((System.Drawing.Size)(resources.GetObject("cbprev.Size")));
			this.cbprev.TabIndex = ((int)(resources.GetObject("cbprev.TabIndex")));
			this.cbprev.Text = resources.GetString("cbprev.Text");
			this.cbprev.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbprev.TextAlign")));
			this.toolTip1.SetToolTip(this.cbprev, resources.GetString("cbprev.ToolTip"));
			this.cbprev.Visible = ((bool)(resources.GetObject("cbprev.Visible")));
			this.cbprev.CheckedChanged += new System.EventHandler(this.lvbase_SelectedIndexChanged);
			// 
			// cbflip
			// 
			this.cbflip.AccessibleDescription = resources.GetString("cbflip.AccessibleDescription");
			this.cbflip.AccessibleName = resources.GetString("cbflip.AccessibleName");
			this.cbflip.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbflip.Anchor")));
			this.cbflip.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbflip.Appearance")));
			this.cbflip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbflip.BackgroundImage")));
			this.cbflip.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbflip.CheckAlign")));
			this.cbflip.Checked = true;
			this.cbflip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbflip.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbflip.Dock")));
			this.cbflip.Enabled = ((bool)(resources.GetObject("cbflip.Enabled")));
			this.cbflip.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbflip.FlatStyle")));
			this.cbflip.Font = ((System.Drawing.Font)(resources.GetObject("cbflip.Font")));
			this.cbflip.Image = ((System.Drawing.Image)(resources.GetObject("cbflip.Image")));
			this.cbflip.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbflip.ImageAlign")));
			this.cbflip.ImageIndex = ((int)(resources.GetObject("cbflip.ImageIndex")));
			this.cbflip.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbflip.ImeMode")));
			this.cbflip.Location = ((System.Drawing.Point)(resources.GetObject("cbflip.Location")));
			this.cbflip.Name = "cbflip";
			this.cbflip.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbflip.RightToLeft")));
			this.cbflip.Size = ((System.Drawing.Size)(resources.GetObject("cbflip.Size")));
			this.cbflip.TabIndex = ((int)(resources.GetObject("cbflip.TabIndex")));
			this.cbflip.Text = resources.GetString("cbflip.Text");
			this.cbflip.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbflip.TextAlign")));
			this.toolTip1.SetToolTip(this.cbflip, resources.GetString("cbflip.ToolTip"));
			this.cbflip.Visible = ((bool)(resources.GetObject("cbflip.Visible")));
			this.cbflip.CheckedChanged += new System.EventHandler(this.lvbase_SelectedIndexChanged);
			// 
			// ofd
			// 
			this.ofd.Filter = resources.GetString("ofd.Filter");
			this.ofd.Title = resources.GetString("ofd.Title");
			// 
			// sfd
			// 
			this.sfd.Filter = resources.GetString("sfd.Filter");
			this.sfd.Title = resources.GetString("sfd.Title");
			// 
			// PhotoStudio
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.pbpreview);
			this.Controls.Add(this.lvbase);
			this.Controls.Add(this.cbquality);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.llcreate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.cbprev);
			this.Controls.Add(this.cbflip);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximizeBox = false;
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "PhotoStudio";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.ShowInTaskbar = false;
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected void AddImage(SimPe.PackedFiles.Wrapper.SDesc sdesc) 
		{
			if (sdesc.Image!=null) 
			{
				if ((sdesc.Unlinked!=0x00) || (!sdesc.AvailableCharacterData))
				{
					Image img = (Image)sdesc.Image.Clone();
					System.Drawing.Graphics g = Graphics.FromImage(img);
					g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
					g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;

					Pen pen = new Pen(Data.MetaData.SpecialSimColor, 3);

					g.FillRectangle(pen.Brush, 0, 0, img.Width, img.Height);

					int pos = 2;
					if (sdesc.Unlinked!=0x00) 
					{
						g.FillRectangle(new Pen(Data.MetaData.UnlinkedSim, 1).Brush, pos, 2, 25, 25);
						pos += 28;
					}
					if (!sdesc.AvailableCharacterData) 
					{
						g.FillRectangle(new Pen(Data.MetaData.InactiveSim, 1).Brush, pos, 2, 25, 25);
						pos += 28;
					}

					this.ilist.Images.Add(img);
				} 				
				else 
				{
					this.ilist.Images.Add(sdesc.Image);
				}
			} 
			else 
			{
				this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")));
			}
		}

		protected void AddSim(SimPe.PackedFiles.Wrapper.SDesc sdesc) 
		{
			if (!sdesc.HasImage) return;
			if (!sdesc.AvailableCharacterData) return;

			AddImage(sdesc);
			ListViewItem lvi = new ListViewItem();
			lvi.Text = sdesc.SimName +" "+sdesc.SimFamilyName;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.Tag = sdesc;
		
			
			lv.Items.Add(lvi);
		}

		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		SimPe.Interfaces.Files.IPackageFile package;
		public Interfaces.Plugin.IToolResult Execute(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov) 
		{
			this.Cursor = Cursors.WaitCursor;
			
			this.pfd = null;
			this.package = null;

			ilist.Images.Clear();
			lv.Items.Clear();

			if (package!=null) 
			{
				Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
				if (pfds.Length>0) WaitingScreen.Wait();
				foreach(Interfaces.Files.IPackedFileDescriptor spfd in pfds) 
				{
					PackedFiles.Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(prov.SimNameProvider, prov.SimFamilynameProvider, null);
					sdesc.ProcessData(spfd, package);
				
					WaitingScreen.UpdateImage(SimPe.Plugin.ImageLoader.Preview(sdesc.Image, new Size(64, 64)));
					AddSim(sdesc);
				} //foreach
				WaitingScreen.Stop();
			}

			this.Cursor = Cursors.Default;
			ShowDialog();

			if (this.pfd!=null) pfd = this.pfd;
			if (this.package!=null) package = this.package;
			return new Plugin.ToolResult((this.pfd!=null), (this.package!=null));
		}

		/// <summary>
		/// Returns the selected Format
		/// </summary>
		/// <returns></returns>
		ImageLoader.TxtrFormats SelectedFormat() 
		{
			ImageLoader.TxtrFormats format = ImageLoader.TxtrFormats.Raw32Bit;
			if (cbquality.SelectedIndex==1) format = ImageLoader.TxtrFormats.DXT1Format;
			else if (cbquality.SelectedIndex==2) format = ImageLoader.TxtrFormats.DXT1Format;

			return format;
		}

		/// <summary>
		/// builds a preview Image
		/// </summary>
		/// <param name="img">The Image you want to use for the build process</param>
		/// <returns>Preview Image </returns>
		Image ShowPreview(Image img)
		{
			if ((!cbprev.Checked) || (img==null) || (lvbase.SelectedItems.Count==0)) return new Bitmap(1, 1);

			
			SimPe.Interfaces.Files.IPackageFile pkg = BuildPicture("dummy.package", img, (PhotoStudioTemplate)lvbase.SelectedItems[0].Tag, ImageLoader.TxtrFormats.Raw32Bit, false, false, cbflip.Checked);
			try 
			{
				SimPe.Plugin.Txtr txtr = new Txtr(null, false);

				//load TXTR
				Interfaces.Files.IPackedFileDescriptor[] pfd = pkg.FindFile(((PhotoStudioTemplate)lvbase.SelectedItems[0].Tag).TxtrFile+"_txtr", 0x1C4A276C);
				if (pfd.Length>0) 
				{
					txtr.ProcessData(pfd[0], pkg);
				}

				SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)txtr.Blocks[0];
				return id.MipMapBlocks[0].MipMaps[id.MipMapBlocks[0].MipMaps.Length-1].Texture;
			} 
			catch (Exception) 
			{
				//((SimPe.Packages.GeneratableFile)pkg).Save("c:\\dummy.package");
				return new Bitmap(1, 1);
			}		

		}

		Image loadimg = null;
		private void OpenImage(object sender, System.EventArgs e)
		{
			if (ofd.ShowDialog()==DialogResult.OK) 
			{
				try 
				{
					loadimg = Image.FromFile(ofd.FileName);
					lbname.Text = System.IO.Path.GetFileName(ofd.FileName);
					lbsize.Text = loadimg.Width.ToString() + "x" + loadimg.Height.ToString();
					pb.Image = SimPe.Plugin.ImageLoader.Preview(loadimg, pb.Size);					
					preview = this.ShowPreview(loadimg);
					pbpreview.Image = SimPe.Plugin.ImageLoader.Preview(preview, pbpreview.Size);
				} 
				catch (Exception) 
				{
					pb.Image = null;
				}
			}
		}

		static string BuildName(string name, string unique)
		{
			name = Hashes.StripHashFromName(name);
			name = RenameForm.ReplaceOldUnique(name, unique, true);

			return name;
		}

		/// <summary>
		/// Creates a new Picture using the passed Template and the passed Image
		/// </summary>
		/// <param name="filename">FileName for the new package</param>
		/// <param name="img">The Image you want to use</param>
		/// <param name="template">The Template to use</param>
		/// <param name="format">The Format to save the Imag ein</param>
		/// <param name="ddstool">true if you want to use the DDS Tools (if available)</param>
		/// <param name="rename">true, if the Texture should be renamed</param>
		/// <param name="flip">true if the Image should be flipped</param>
		/// <returns>The package with the Recolor</returns>
		protected static SimPe.Packages.GeneratableFile BuildPicture(string filename, Image img, PhotoStudioTemplate template, ImageLoader.TxtrFormats format, bool ddstool, bool rename, bool flip) 
		{
			WaitingScreen.Wait();
			SimPe.Plugin.Txtr txtr = new Txtr(null, false);
			SimPe.Plugin.Rcol matd = new GenericRcol(null, false);
			SimPe.PackedFiles.Wrapper.Cpf mmat = new SimPe.PackedFiles.Wrapper.Cpf();

			SimPe.Packages.GeneratableFile pkg = new SimPe.Packages.GeneratableFile((System.IO.BinaryReader)null);
			pkg.FileName = filename;

			string family = System.Guid.NewGuid().ToString();
			string unique = RenameForm.GetUniqueName();

			SimPe.Packages.GeneratableFile tpkg = new SimPe.Packages.GeneratableFile(template.Package.FileName);

			//load MMAT
			WaitingScreen.UpdateMessage("Loading Material Override");
			Interfaces.Files.IPackedFileDescriptor pfd = tpkg.FindFile(0x4C697E5A, 0x0, 0xffffffff, template.MmatInstance);
			if (pfd!=null) 
			{
				mmat.ProcessData(pfd, tpkg);
				mmat.GetSaveItem("family").StringValue = family;
				if (rename) mmat.GetSaveItem("name").StringValue = "##0x1c050000!"+BuildName(template.MatdFile, unique);

				mmat.SynchronizeUserData();
				pkg.Add(mmat.FileDescriptor);
			}

			//load MATD
			WaitingScreen.UpdateMessage("Loading Material Definition");
			pfd = tpkg.FindFile(0x49596978, Hashes.SubTypeHash(Hashes.StripHashFromName(template.MatdFile+"_txmt")), 0x1c050000, Hashes.InstanceHash(Hashes.StripHashFromName(template.MatdFile+"_txmt")));
			if (pfd==null) pfd = tpkg.FindFile(0x49596978, Hashes.SubTypeHash(Hashes.StripHashFromName(template.MatdFile+"_txmt")), 0xffffffff, Hashes.InstanceHash(Hashes.StripHashFromName(template.MatdFile+"_txmt")));
			if (pfd!=null) 
			{
				matd.ProcessData(pfd, tpkg);
				if (rename) matd.FileName = "##0x1c050000!"+BuildName(template.MatdFile, unique)+"_txmt";
				SimPe.Plugin.MaterialDefinition md = (SimPe.Plugin.MaterialDefinition)matd.Blocks[0];
				if (rename) md.GetProperty("stdMatBaseTextureName").Value = "##0x1c050000!"+BuildName(template.TxtrFile, unique);
				if (rename) md.Listing[0] = md.GetProperty("stdMatBaseTextureName").Value;

				matd.FileDescriptor = new Packages.PackedFileDescriptor();
				matd.FileDescriptor.Type = 0x49596978; //TXMT
				matd.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(matd.FileName));
				matd.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(matd.FileName));
				matd.FileDescriptor.Group = 0x1c050000;
				matd.SynchronizeUserData();
				pkg.Add(matd.FileDescriptor);
			}

			//load TXTR
			WaitingScreen.UpdateMessage("Loading Texture Image");
			pfd = tpkg.FindFile(0x1C4A276C, Hashes.SubTypeHash(Hashes.StripHashFromName(template.TxtrFile+"_txtr")), 0x1c050000, Hashes.InstanceHash(Hashes.StripHashFromName(template.TxtrFile+"_txtr")));
			if (pfd==null) pfd = tpkg.FindFile(0x1C4A276C, Hashes.SubTypeHash(Hashes.StripHashFromName(template.TxtrFile+"_txtr")), 0xffffffff, Hashes.InstanceHash(Hashes.StripHashFromName(template.TxtrFile+"_txtr")));
			if (pfd!=null) 
			{
				txtr.ProcessData(pfd, tpkg);
				if (rename) txtr.FileName = "##0x1c050000!"+BuildName(template.TxtrFile, unique)+"_txtr";

				SimPe.Plugin.ImageData id = (SimPe.Plugin.ImageData)txtr.Blocks[0];
				SimPe.Plugin.MipMapBlock mmp = id.MipMapBlocks[0];
				SimPe.Plugin.MipMap mm = mmp.MipMaps[mmp.MipMaps.Length-1];
				//mm.Data = null;

				WaitingScreen.UpdateMessage("Updating Image");
				Rectangle rect = new Rectangle(0, 0, img.Width, img.Height);
				Image mmimg = (Image)img.Clone();
				if (flip) mmimg.RotateFlip(System.Drawing.RotateFlipType.RotateNoneFlipX);
				System.Drawing.Graphics g = Graphics.FromImage(mm.Texture);
				g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
				g.DrawImage(mmimg, template.TargetRectangle, rect, System.Drawing.GraphicsUnit.Pixel);
				

				if ((System.IO.File.Exists(Helper.WindowsRegistry.NvidiaDDSTool)) && (ddstool) && ((format==ImageLoader.TxtrFormats.DXT1Format) || (format==ImageLoader.TxtrFormats.DXT3Format) || (format==ImageLoader.TxtrFormats.DXT5Format)) )
				{
					DDSTool.AddDDsData(id, DDSTool.BuildDDS(mm.Texture, (int)id.MipMapLevels, format, "-sharpenMethod Smoothen"));
				} 
				else 
				{
					for (int i=mmp.MipMaps.Length-2; i>=0; i--) 
					{
						SimPe.Plugin.MipMap newmm = mmp.MipMaps[i];
						Image newimg = new Bitmap(newmm.Texture.Width, newmm.Texture.Height);
						g = Graphics.FromImage(newimg);
						g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
						g.DrawImage(mm.Texture, new Rectangle(0, 0, newimg.Width, newimg.Height), new Rectangle(0, 0, mm.Texture.Width, mm.Texture.Height), System.Drawing.GraphicsUnit.Pixel);
						
						newmm.Texture = newimg;
					}
					id.Format = format;
				}
				
				txtr.FileDescriptor = new Packages.PackedFileDescriptor();
				txtr.FileDescriptor.Type = 0x1C4A276C; //TXTR
				txtr.FileDescriptor.SubType = Hashes.SubTypeHash(Hashes.StripHashFromName(txtr.FileName));
				txtr.FileDescriptor.Instance = Hashes.InstanceHash(Hashes.StripHashFromName(txtr.FileName));
				txtr.FileDescriptor.Group = 0x1c050000;
				txtr.SynchronizeUserData();
				pkg.Add(txtr.FileDescriptor);
			}

			WaitingScreen.Stop();
			return pkg;
		}

		private void CreateImage(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lvbase.SelectedItems.Count==0) return;
			Image img = null;

			//get the Image depending on the Active Tab
			if (tabControl1.SelectedIndex==0) 
			{
				img = loadimg;
			} 
			else if (tabControl1.SelectedIndex==1) 
			{
				if (lv.SelectedItems.Count<1) return;
			
				PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
				img = sdesc.Image;				
			}

			if (img == null) return;
			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					this.package = BuildPicture(sfd.FileName, img, (PhotoStudioTemplate)lvbase.SelectedItems[0].Tag, SelectedFormat(), (cbquality.SelectedIndex==2), true, cbflip.Checked);
					((SimPe.Packages.GeneratableFile)this.package).Save();
					this.Cursor = Cursors.Default;
					Close();
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("", ex);
				}
			}
		}

		Image preview;
		private void lvbase_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			if (tabControl1.SelectedIndex==0) 
			{
				preview = this.ShowPreview(loadimg);
			} 
			else 
			{
				if (lv.SelectedItems.Count>0)
				{
					PackedFiles.Wrapper.SDesc sdesc = (PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag;
					preview = this.ShowPreview(sdesc.Image);
				} 
				else 
				{
					preview = null;
				}
			}
			
			
			pbpreview.Image = SimPe.Plugin.ImageLoader.Preview(preview, pbpreview.Size);
			this.Cursor = Cursors.Default;
		}

		private void pbpreview_Click(object sender, System.EventArgs e)
		{
			if (preview==null) return;

			Form form = new Form();
			form.Width = preview.Width;
			form.Height = preview.Height;

			PictureBox pb = new PictureBox();
			pb.Size = new Size(preview.Width, preview.Height);
			pb.Parent = form;
			pb.Left = 0;
			pb.Top = 0;
			pb.Image = preview;
			
			form.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			form.Text = "Preview";

			form.ShowDialog();

		}
	}
}
