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
using SimPe.Interfaces.Files;
using SimPe.Interfaces.Wrapper;
using SimPe.Data;
using SimPe.PackedFiles.Wrapper;
using SimPe.Interfaces.Plugin;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Summary description for BconForm.
	/// </summary>
	public class StrForm : System.Windows.Forms.Form, IPackedFileUI
	{
		#region Form elements
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btcommit;
		private System.Windows.Forms.ComboBox cblanguage;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox gbstr;
		private System.Windows.Forms.LinkLabel lldelall;
		private System.Windows.Forms.LinkLabel lldelete;
		private System.Windows.Forms.LinkLabel llchangeall;
		private System.Windows.Forms.LinkLabel lladdall;
		private System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.LinkLabel llcommit;
		private System.Windows.Forms.RichTextBox rtbdesc;
		private System.Windows.Forms.RichTextBox rtbvalue;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListBox lbtexts;
		private System.Windows.Forms.TextBox tbformat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbstr;
		private System.Windows.Forms.Label banner;
		private System.Windows.Forms.LinkLabel llcreate;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Panel strPanel;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		#endregion

		public StrForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

#if DEBUG
			this.llcreate.Visible = true;
#else
			this.llcreate.Visible = false;
#endif
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


		#region Str
		internal Str wrapper;
		#endregion

		#region IPackedFileUI Member
		/// <summary>
		/// Returns the Panel that will be displayed within SimPe
		/// </summary>
		public System.Windows.Forms.Control GUIHandle
		{
			get
			{
				return strPanel;
			}
		}

		/// <summary>
		/// Is called by SimPe (through the Wrapper) when the Panel is going to be displayed, so
		/// you should updatet the Data displayed by the Panel with the Attributes stored in the
		/// passed Wrapper.
		/// </summary>
		/// <remarks>this.Tag is used to let TextChanged event handlers know the change is being
		/// made internally rather than by the users.</remarks>
		/// <param name="wrp">The Attributes of this Wrapper have to be displayed</param>
		public void UpdateGUI(IFileWrapper wrp)
		{
			wrapper = (Str)wrp;
			Tag = true;

			lbstr.Text = wrapper.FileName;
			tbformat.Text = "0x"+Helper.HexString((ushort)wrapper.Format);

			lbtexts.Items.Clear();			

			llcommit.Enabled = false;
			llchangeall.Enabled = false;

			rtbvalue.Text = "";
			rtbdesc.Text = "";
			gbstr.Text = "";

			cblanguage.Items.Clear();
			cblanguage.Sorted = false;
			
			foreach (StrLanguage s in wrapper.Languages)
				cblanguage.Items.Add(s);

			cblanguage.Sorted = true;
			if (cblanguage.Items.Count > 0)
				cblanguage.SelectedIndex = 0;

			Tag = null;
		}		
		#endregion

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(StrForm));
			this.strPanel = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.btcommit = new System.Windows.Forms.Button();
			this.cblanguage = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.gbstr = new System.Windows.Forms.GroupBox();
			this.lldelall = new System.Windows.Forms.LinkLabel();
			this.lldelete = new System.Windows.Forms.LinkLabel();
			this.llchangeall = new System.Windows.Forms.LinkLabel();
			this.lladdall = new System.Windows.Forms.LinkLabel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.llcommit = new System.Windows.Forms.LinkLabel();
			this.rtbdesc = new System.Windows.Forms.RichTextBox();
			this.rtbvalue = new System.Windows.Forms.RichTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbtexts = new System.Windows.Forms.ListBox();
			this.tbformat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lbstr = new System.Windows.Forms.Label();
			this.banner = new System.Windows.Forms.Label();
			this.llcreate = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.strPanel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbstr.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// strPanel
			// 
			this.strPanel.AccessibleDescription = resources.GetString("strPanel.AccessibleDescription");
			this.strPanel.AccessibleName = resources.GetString("strPanel.AccessibleName");
			this.strPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("strPanel.Anchor")));
			this.strPanel.AutoScroll = ((bool)(resources.GetObject("strPanel.AutoScroll")));
			this.strPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("strPanel.AutoScrollMargin")));
			this.strPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("strPanel.AutoScrollMinSize")));
			this.strPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("strPanel.BackgroundImage")));
			this.strPanel.Controls.Add(this.button1);
			this.strPanel.Controls.Add(this.btcommit);
			this.strPanel.Controls.Add(this.cblanguage);
			this.strPanel.Controls.Add(this.label4);
			this.strPanel.Controls.Add(this.groupBox1);
			this.strPanel.Controls.Add(this.tbformat);
			this.strPanel.Controls.Add(this.label1);
			this.strPanel.Controls.Add(this.panel2);
			this.strPanel.Controls.Add(this.llcreate);
			this.strPanel.Controls.Add(this.linkLabel1);
			this.strPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("strPanel.Dock")));
			this.strPanel.Enabled = ((bool)(resources.GetObject("strPanel.Enabled")));
			this.strPanel.Font = ((System.Drawing.Font)(resources.GetObject("strPanel.Font")));
			this.strPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("strPanel.ImeMode")));
			this.strPanel.Location = ((System.Drawing.Point)(resources.GetObject("strPanel.Location")));
			this.strPanel.Name = "strPanel";
			this.strPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("strPanel.RightToLeft")));
			this.strPanel.Size = ((System.Drawing.Size)(resources.GetObject("strPanel.Size")));
			this.strPanel.TabIndex = ((int)(resources.GetObject("strPanel.TabIndex")));
			this.strPanel.Text = resources.GetString("strPanel.Text");
			this.strPanel.Visible = ((bool)(resources.GetObject("strPanel.Visible")));
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
			this.button1.Click += new System.EventHandler(this.ClearStr);
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
			this.btcommit.Click += new System.EventHandler(this.CommitStr);
			// 
			// cblanguage
			// 
			this.cblanguage.AccessibleDescription = resources.GetString("cblanguage.AccessibleDescription");
			this.cblanguage.AccessibleName = resources.GetString("cblanguage.AccessibleName");
			this.cblanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblanguage.Anchor")));
			this.cblanguage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblanguage.BackgroundImage")));
			this.cblanguage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblanguage.Dock")));
			this.cblanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cblanguage.Enabled = ((bool)(resources.GetObject("cblanguage.Enabled")));
			this.cblanguage.Font = ((System.Drawing.Font)(resources.GetObject("cblanguage.Font")));
			this.cblanguage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblanguage.ImeMode")));
			this.cblanguage.IntegralHeight = ((bool)(resources.GetObject("cblanguage.IntegralHeight")));
			this.cblanguage.ItemHeight = ((int)(resources.GetObject("cblanguage.ItemHeight")));
			this.cblanguage.Location = ((System.Drawing.Point)(resources.GetObject("cblanguage.Location")));
			this.cblanguage.MaxDropDownItems = ((int)(resources.GetObject("cblanguage.MaxDropDownItems")));
			this.cblanguage.MaxLength = ((int)(resources.GetObject("cblanguage.MaxLength")));
			this.cblanguage.Name = "cblanguage";
			this.cblanguage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblanguage.RightToLeft")));
			this.cblanguage.Size = ((System.Drawing.Size)(resources.GetObject("cblanguage.Size")));
			this.cblanguage.TabIndex = ((int)(resources.GetObject("cblanguage.TabIndex")));
			this.cblanguage.Text = resources.GetString("cblanguage.Text");
			this.cblanguage.Visible = ((bool)(resources.GetObject("cblanguage.Visible")));
			this.cblanguage.SelectedIndexChanged += new System.EventHandler(this.LanguageChanged);
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
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.gbstr);
			this.groupBox1.Controls.Add(this.splitter1);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			// 
			// gbstr
			// 
			this.gbstr.AccessibleDescription = resources.GetString("gbstr.AccessibleDescription");
			this.gbstr.AccessibleName = resources.GetString("gbstr.AccessibleName");
			this.gbstr.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbstr.Anchor")));
			this.gbstr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbstr.BackgroundImage")));
			this.gbstr.Controls.Add(this.lldelall);
			this.gbstr.Controls.Add(this.lldelete);
			this.gbstr.Controls.Add(this.llchangeall);
			this.gbstr.Controls.Add(this.lladdall);
			this.gbstr.Controls.Add(this.lladd);
			this.gbstr.Controls.Add(this.llcommit);
			this.gbstr.Controls.Add(this.rtbdesc);
			this.gbstr.Controls.Add(this.rtbvalue);
			this.gbstr.Controls.Add(this.label3);
			this.gbstr.Controls.Add(this.label2);
			this.gbstr.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbstr.Dock")));
			this.gbstr.Enabled = ((bool)(resources.GetObject("gbstr.Enabled")));
			this.gbstr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbstr.Font = ((System.Drawing.Font)(resources.GetObject("gbstr.Font")));
			this.gbstr.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbstr.ImeMode")));
			this.gbstr.Location = ((System.Drawing.Point)(resources.GetObject("gbstr.Location")));
			this.gbstr.Name = "gbstr";
			this.gbstr.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbstr.RightToLeft")));
			this.gbstr.Size = ((System.Drawing.Size)(resources.GetObject("gbstr.Size")));
			this.gbstr.TabIndex = ((int)(resources.GetObject("gbstr.TabIndex")));
			this.gbstr.TabStop = false;
			this.gbstr.Text = resources.GetString("gbstr.Text");
			this.gbstr.Visible = ((bool)(resources.GetObject("gbstr.Visible")));
			// 
			// lldelall
			// 
			this.lldelall.AccessibleDescription = resources.GetString("lldelall.AccessibleDescription");
			this.lldelall.AccessibleName = resources.GetString("lldelall.AccessibleName");
			this.lldelall.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldelall.Anchor")));
			this.lldelall.AutoSize = ((bool)(resources.GetObject("lldelall.AutoSize")));
			this.lldelall.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldelall.Dock")));
			this.lldelall.Enabled = ((bool)(resources.GetObject("lldelall.Enabled")));
			this.lldelall.Font = ((System.Drawing.Font)(resources.GetObject("lldelall.Font")));
			this.lldelall.Image = ((System.Drawing.Image)(resources.GetObject("lldelall.Image")));
			this.lldelall.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelall.ImageAlign")));
			this.lldelall.ImageIndex = ((int)(resources.GetObject("lldelall.ImageIndex")));
			this.lldelall.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldelall.ImeMode")));
			this.lldelall.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldelall.LinkArea")));
			this.lldelall.Location = ((System.Drawing.Point)(resources.GetObject("lldelall.Location")));
			this.lldelall.Name = "lldelall";
			this.lldelall.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldelall.RightToLeft")));
			this.lldelall.Size = ((System.Drawing.Size)(resources.GetObject("lldelall.Size")));
			this.lldelall.TabIndex = ((int)(resources.GetObject("lldelall.TabIndex")));
			this.lldelall.TabStop = true;
			this.lldelall.Text = resources.GetString("lldelall.Text");
			this.lldelall.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelall.TextAlign")));
			this.lldelall.Visible = ((bool)(resources.GetObject("lldelall.Visible")));
			this.lldelall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DelInAll);
			// 
			// lldelete
			// 
			this.lldelete.AccessibleDescription = resources.GetString("lldelete.AccessibleDescription");
			this.lldelete.AccessibleName = resources.GetString("lldelete.AccessibleName");
			this.lldelete.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldelete.Anchor")));
			this.lldelete.AutoSize = ((bool)(resources.GetObject("lldelete.AutoSize")));
			this.lldelete.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldelete.Dock")));
			this.lldelete.Enabled = ((bool)(resources.GetObject("lldelete.Enabled")));
			this.lldelete.Font = ((System.Drawing.Font)(resources.GetObject("lldelete.Font")));
			this.lldelete.Image = ((System.Drawing.Image)(resources.GetObject("lldelete.Image")));
			this.lldelete.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelete.ImageAlign")));
			this.lldelete.ImageIndex = ((int)(resources.GetObject("lldelete.ImageIndex")));
			this.lldelete.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldelete.ImeMode")));
			this.lldelete.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldelete.LinkArea")));
			this.lldelete.Location = ((System.Drawing.Point)(resources.GetObject("lldelete.Location")));
			this.lldelete.Name = "lldelete";
			this.lldelete.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldelete.RightToLeft")));
			this.lldelete.Size = ((System.Drawing.Size)(resources.GetObject("lldelete.Size")));
			this.lldelete.TabIndex = ((int)(resources.GetObject("lldelete.TabIndex")));
			this.lldelete.TabStop = true;
			this.lldelete.Text = resources.GetString("lldelete.Text");
			this.lldelete.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldelete.TextAlign")));
			this.lldelete.Visible = ((bool)(resources.GetObject("lldelete.Visible")));
			this.lldelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StrDelete);
			// 
			// llchangeall
			// 
			this.llchangeall.AccessibleDescription = resources.GetString("llchangeall.AccessibleDescription");
			this.llchangeall.AccessibleName = resources.GetString("llchangeall.AccessibleName");
			this.llchangeall.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llchangeall.Anchor")));
			this.llchangeall.AutoSize = ((bool)(resources.GetObject("llchangeall.AutoSize")));
			this.llchangeall.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llchangeall.Dock")));
			this.llchangeall.Enabled = ((bool)(resources.GetObject("llchangeall.Enabled")));
			this.llchangeall.Font = ((System.Drawing.Font)(resources.GetObject("llchangeall.Font")));
			this.llchangeall.Image = ((System.Drawing.Image)(resources.GetObject("llchangeall.Image")));
			this.llchangeall.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangeall.ImageAlign")));
			this.llchangeall.ImageIndex = ((int)(resources.GetObject("llchangeall.ImageIndex")));
			this.llchangeall.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llchangeall.ImeMode")));
			this.llchangeall.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llchangeall.LinkArea")));
			this.llchangeall.Location = ((System.Drawing.Point)(resources.GetObject("llchangeall.Location")));
			this.llchangeall.Name = "llchangeall";
			this.llchangeall.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llchangeall.RightToLeft")));
			this.llchangeall.Size = ((System.Drawing.Size)(resources.GetObject("llchangeall.Size")));
			this.llchangeall.TabIndex = ((int)(resources.GetObject("llchangeall.TabIndex")));
			this.llchangeall.TabStop = true;
			this.llchangeall.Text = resources.GetString("llchangeall.Text");
			this.llchangeall.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llchangeall.TextAlign")));
			this.llchangeall.Visible = ((bool)(resources.GetObject("llchangeall.Visible")));
			this.llchangeall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeInAllLanguages);
			// 
			// lladdall
			// 
			this.lladdall.AccessibleDescription = resources.GetString("lladdall.AccessibleDescription");
			this.lladdall.AccessibleName = resources.GetString("lladdall.AccessibleName");
			this.lladdall.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lladdall.Anchor")));
			this.lladdall.AutoSize = ((bool)(resources.GetObject("lladdall.AutoSize")));
			this.lladdall.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lladdall.Dock")));
			this.lladdall.Enabled = ((bool)(resources.GetObject("lladdall.Enabled")));
			this.lladdall.Font = ((System.Drawing.Font)(resources.GetObject("lladdall.Font")));
			this.lladdall.Image = ((System.Drawing.Image)(resources.GetObject("lladdall.Image")));
			this.lladdall.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladdall.ImageAlign")));
			this.lladdall.ImageIndex = ((int)(resources.GetObject("lladdall.ImageIndex")));
			this.lladdall.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lladdall.ImeMode")));
			this.lladdall.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lladdall.LinkArea")));
			this.lladdall.Location = ((System.Drawing.Point)(resources.GetObject("lladdall.Location")));
			this.lladdall.Name = "lladdall";
			this.lladdall.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lladdall.RightToLeft")));
			this.lladdall.Size = ((System.Drawing.Size)(resources.GetObject("lladdall.Size")));
			this.lladdall.TabIndex = ((int)(resources.GetObject("lladdall.TabIndex")));
			this.lladdall.TabStop = true;
			this.lladdall.Text = resources.GetString("lladdall.Text");
			this.lladdall.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lladdall.TextAlign")));
			this.lladdall.Visible = ((bool)(resources.GetObject("lladdall.Visible")));
			this.lladdall.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddToAll);
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
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StrAdd);
			// 
			// llcommit
			// 
			this.llcommit.AccessibleDescription = resources.GetString("llcommit.AccessibleDescription");
			this.llcommit.AccessibleName = resources.GetString("llcommit.AccessibleName");
			this.llcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommit.Anchor")));
			this.llcommit.AutoSize = ((bool)(resources.GetObject("llcommit.AutoSize")));
			this.llcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommit.Dock")));
			this.llcommit.Enabled = ((bool)(resources.GetObject("llcommit.Enabled")));
			this.llcommit.Font = ((System.Drawing.Font)(resources.GetObject("llcommit.Font")));
			this.llcommit.Image = ((System.Drawing.Image)(resources.GetObject("llcommit.Image")));
			this.llcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.ImageAlign")));
			this.llcommit.ImageIndex = ((int)(resources.GetObject("llcommit.ImageIndex")));
			this.llcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommit.ImeMode")));
			this.llcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommit.LinkArea")));
			this.llcommit.Location = ((System.Drawing.Point)(resources.GetObject("llcommit.Location")));
			this.llcommit.Name = "llcommit";
			this.llcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommit.RightToLeft")));
			this.llcommit.Size = ((System.Drawing.Size)(resources.GetObject("llcommit.Size")));
			this.llcommit.TabIndex = ((int)(resources.GetObject("llcommit.TabIndex")));
			this.llcommit.TabStop = true;
			this.llcommit.Text = resources.GetString("llcommit.Text");
			this.llcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommit.TextAlign")));
			this.llcommit.Visible = ((bool)(resources.GetObject("llcommit.Visible")));
			this.llcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitChanges);
			// 
			// rtbdesc
			// 
			this.rtbdesc.AccessibleDescription = resources.GetString("rtbdesc.AccessibleDescription");
			this.rtbdesc.AccessibleName = resources.GetString("rtbdesc.AccessibleName");
			this.rtbdesc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtbdesc.Anchor")));
			this.rtbdesc.AutoSize = ((bool)(resources.GetObject("rtbdesc.AutoSize")));
			this.rtbdesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtbdesc.BackgroundImage")));
			this.rtbdesc.BulletIndent = ((int)(resources.GetObject("rtbdesc.BulletIndent")));
			this.rtbdesc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtbdesc.Dock")));
			this.rtbdesc.Enabled = ((bool)(resources.GetObject("rtbdesc.Enabled")));
			this.rtbdesc.Font = ((System.Drawing.Font)(resources.GetObject("rtbdesc.Font")));
			this.rtbdesc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtbdesc.ImeMode")));
			this.rtbdesc.Location = ((System.Drawing.Point)(resources.GetObject("rtbdesc.Location")));
			this.rtbdesc.MaxLength = ((int)(resources.GetObject("rtbdesc.MaxLength")));
			this.rtbdesc.Multiline = ((bool)(resources.GetObject("rtbdesc.Multiline")));
			this.rtbdesc.Name = "rtbdesc";
			this.rtbdesc.RightMargin = ((int)(resources.GetObject("rtbdesc.RightMargin")));
			this.rtbdesc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtbdesc.RightToLeft")));
			this.rtbdesc.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtbdesc.ScrollBars")));
			this.rtbdesc.Size = ((System.Drawing.Size)(resources.GetObject("rtbdesc.Size")));
			this.rtbdesc.TabIndex = ((int)(resources.GetObject("rtbdesc.TabIndex")));
			this.rtbdesc.Text = resources.GetString("rtbdesc.Text");
			this.rtbdesc.Visible = ((bool)(resources.GetObject("rtbdesc.Visible")));
			this.rtbdesc.WordWrap = ((bool)(resources.GetObject("rtbdesc.WordWrap")));
			this.rtbdesc.ZoomFactor = ((System.Single)(resources.GetObject("rtbdesc.ZoomFactor")));
			this.rtbdesc.TextChanged += new System.EventHandler(this.ChangeText);
			// 
			// rtbvalue
			// 
			this.rtbvalue.AccessibleDescription = resources.GetString("rtbvalue.AccessibleDescription");
			this.rtbvalue.AccessibleName = resources.GetString("rtbvalue.AccessibleName");
			this.rtbvalue.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtbvalue.Anchor")));
			this.rtbvalue.AutoSize = ((bool)(resources.GetObject("rtbvalue.AutoSize")));
			this.rtbvalue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtbvalue.BackgroundImage")));
			this.rtbvalue.BulletIndent = ((int)(resources.GetObject("rtbvalue.BulletIndent")));
			this.rtbvalue.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtbvalue.Dock")));
			this.rtbvalue.Enabled = ((bool)(resources.GetObject("rtbvalue.Enabled")));
			this.rtbvalue.Font = ((System.Drawing.Font)(resources.GetObject("rtbvalue.Font")));
			this.rtbvalue.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtbvalue.ImeMode")));
			this.rtbvalue.Location = ((System.Drawing.Point)(resources.GetObject("rtbvalue.Location")));
			this.rtbvalue.MaxLength = ((int)(resources.GetObject("rtbvalue.MaxLength")));
			this.rtbvalue.Multiline = ((bool)(resources.GetObject("rtbvalue.Multiline")));
			this.rtbvalue.Name = "rtbvalue";
			this.rtbvalue.RightMargin = ((int)(resources.GetObject("rtbvalue.RightMargin")));
			this.rtbvalue.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtbvalue.RightToLeft")));
			this.rtbvalue.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtbvalue.ScrollBars")));
			this.rtbvalue.Size = ((System.Drawing.Size)(resources.GetObject("rtbvalue.Size")));
			this.rtbvalue.TabIndex = ((int)(resources.GetObject("rtbvalue.TabIndex")));
			this.rtbvalue.Text = resources.GetString("rtbvalue.Text");
			this.rtbvalue.Visible = ((bool)(resources.GetObject("rtbvalue.Visible")));
			this.rtbvalue.WordWrap = ((bool)(resources.GetObject("rtbvalue.WordWrap")));
			this.rtbvalue.ZoomFactor = ((System.Single)(resources.GetObject("rtbvalue.ZoomFactor")));
			this.rtbvalue.TextChanged += new System.EventHandler(this.ChangeText);
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
			// splitter1
			// 
			this.splitter1.AccessibleDescription = resources.GetString("splitter1.AccessibleDescription");
			this.splitter1.AccessibleName = resources.GetString("splitter1.AccessibleName");
			this.splitter1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("splitter1.Anchor")));
			this.splitter1.BackColor = System.Drawing.SystemColors.Control;
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
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Controls.Add(this.lbtexts);
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
			// lbtexts
			// 
			this.lbtexts.AccessibleDescription = resources.GetString("lbtexts.AccessibleDescription");
			this.lbtexts.AccessibleName = resources.GetString("lbtexts.AccessibleName");
			this.lbtexts.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbtexts.Anchor")));
			this.lbtexts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbtexts.BackgroundImage")));
			this.lbtexts.ColumnWidth = ((int)(resources.GetObject("lbtexts.ColumnWidth")));
			this.lbtexts.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbtexts.Dock")));
			this.lbtexts.Enabled = ((bool)(resources.GetObject("lbtexts.Enabled")));
			this.lbtexts.Font = ((System.Drawing.Font)(resources.GetObject("lbtexts.Font")));
			this.lbtexts.HorizontalExtent = ((int)(resources.GetObject("lbtexts.HorizontalExtent")));
			this.lbtexts.HorizontalScrollbar = ((bool)(resources.GetObject("lbtexts.HorizontalScrollbar")));
			this.lbtexts.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbtexts.ImeMode")));
			this.lbtexts.IntegralHeight = ((bool)(resources.GetObject("lbtexts.IntegralHeight")));
			this.lbtexts.ItemHeight = ((int)(resources.GetObject("lbtexts.ItemHeight")));
			this.lbtexts.Location = ((System.Drawing.Point)(resources.GetObject("lbtexts.Location")));
			this.lbtexts.Name = "lbtexts";
			this.lbtexts.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbtexts.RightToLeft")));
			this.lbtexts.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbtexts.ScrollAlwaysVisible")));
			this.lbtexts.Size = ((System.Drawing.Size)(resources.GetObject("lbtexts.Size")));
			this.lbtexts.TabIndex = ((int)(resources.GetObject("lbtexts.TabIndex")));
			this.lbtexts.Visible = ((bool)(resources.GetObject("lbtexts.Visible")));
			this.lbtexts.SelectedIndexChanged += new System.EventHandler(this.StringSelected);
			// 
			// tbformat
			// 
			this.tbformat.AccessibleDescription = resources.GetString("tbformat.AccessibleDescription");
			this.tbformat.AccessibleName = resources.GetString("tbformat.AccessibleName");
			this.tbformat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbformat.Anchor")));
			this.tbformat.AutoSize = ((bool)(resources.GetObject("tbformat.AutoSize")));
			this.tbformat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbformat.BackgroundImage")));
			this.tbformat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbformat.Dock")));
			this.tbformat.Enabled = ((bool)(resources.GetObject("tbformat.Enabled")));
			this.tbformat.Font = ((System.Drawing.Font)(resources.GetObject("tbformat.Font")));
			this.tbformat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbformat.ImeMode")));
			this.tbformat.Location = ((System.Drawing.Point)(resources.GetObject("tbformat.Location")));
			this.tbformat.MaxLength = ((int)(resources.GetObject("tbformat.MaxLength")));
			this.tbformat.Multiline = ((bool)(resources.GetObject("tbformat.Multiline")));
			this.tbformat.Name = "tbformat";
			this.tbformat.PasswordChar = ((char)(resources.GetObject("tbformat.PasswordChar")));
			this.tbformat.ReadOnly = true;
			this.tbformat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbformat.RightToLeft")));
			this.tbformat.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbformat.ScrollBars")));
			this.tbformat.Size = ((System.Drawing.Size)(resources.GetObject("tbformat.Size")));
			this.tbformat.TabIndex = ((int)(resources.GetObject("tbformat.TabIndex")));
			this.tbformat.Text = resources.GetString("tbformat.Text");
			this.tbformat.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbformat.TextAlign")));
			this.tbformat.Visible = ((bool)(resources.GetObject("tbformat.Visible")));
			this.tbformat.WordWrap = ((bool)(resources.GetObject("tbformat.WordWrap")));
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
			this.panel2.Controls.Add(this.lbstr);
			this.panel2.Controls.Add(this.banner);
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
			// lbstr
			// 
			this.lbstr.AccessibleDescription = resources.GetString("lbstr.AccessibleDescription");
			this.lbstr.AccessibleName = resources.GetString("lbstr.AccessibleName");
			this.lbstr.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbstr.Anchor")));
			this.lbstr.AutoSize = ((bool)(resources.GetObject("lbstr.AutoSize")));
			this.lbstr.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbstr.Dock")));
			this.lbstr.Enabled = ((bool)(resources.GetObject("lbstr.Enabled")));
			this.lbstr.Font = ((System.Drawing.Font)(resources.GetObject("lbstr.Font")));
			this.lbstr.Image = ((System.Drawing.Image)(resources.GetObject("lbstr.Image")));
			this.lbstr.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbstr.ImageAlign")));
			this.lbstr.ImageIndex = ((int)(resources.GetObject("lbstr.ImageIndex")));
			this.lbstr.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbstr.ImeMode")));
			this.lbstr.Location = ((System.Drawing.Point)(resources.GetObject("lbstr.Location")));
			this.lbstr.Name = "lbstr";
			this.lbstr.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbstr.RightToLeft")));
			this.lbstr.Size = ((System.Drawing.Size)(resources.GetObject("lbstr.Size")));
			this.lbstr.TabIndex = ((int)(resources.GetObject("lbstr.TabIndex")));
			this.lbstr.Text = resources.GetString("lbstr.Text");
			this.lbstr.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbstr.TextAlign")));
			this.lbstr.Visible = ((bool)(resources.GetObject("lbstr.Visible")));
			// 
			// banner
			// 
			this.banner.AccessibleDescription = resources.GetString("banner.AccessibleDescription");
			this.banner.AccessibleName = resources.GetString("banner.AccessibleName");
			this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("banner.Anchor")));
			this.banner.AutoSize = ((bool)(resources.GetObject("banner.AutoSize")));
			this.banner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("banner.Dock")));
			this.banner.Enabled = ((bool)(resources.GetObject("banner.Enabled")));
			this.banner.Font = ((System.Drawing.Font)(resources.GetObject("banner.Font")));
			this.banner.Image = ((System.Drawing.Image)(resources.GetObject("banner.Image")));
			this.banner.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.ImageAlign")));
			this.banner.ImageIndex = ((int)(resources.GetObject("banner.ImageIndex")));
			this.banner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("banner.ImeMode")));
			this.banner.Location = ((System.Drawing.Point)(resources.GetObject("banner.Location")));
			this.banner.Name = "banner";
			this.banner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("banner.RightToLeft")));
			this.banner.Size = ((System.Drawing.Size)(resources.GetObject("banner.Size")));
			this.banner.TabIndex = ((int)(resources.GetObject("banner.TabIndex")));
			this.banner.Text = resources.GetString("banner.Text");
			this.banner.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.TextAlign")));
			this.banner.Visible = ((bool)(resources.GetObject("banner.Visible")));
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
			this.llcreate.Visible = ((bool)(resources.GetObject("llcreate.Visible")));
			this.llcreate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTextFile);
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
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// StrForm
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.strPanel);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "StrForm";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.strPanel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbstr.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}


		private void StrDelete(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbtexts.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;
				StrToken item = (StrToken)lbtexts.Items[lbtexts.SelectedIndex];				
				wrp.Remove(item);

				lbtexts.Items.Remove(item);
				LanguageChanged(null, null);

				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void DelInAll(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (lbtexts.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;
				
				foreach (StrItemList list in wrp.Lines.Values) 
				{
					if (list.Count>lbtexts.SelectedIndex)
						list.RemoveAt(lbtexts.SelectedIndex);
				}

				lbtexts.Items.Remove(lbtexts.Items[lbtexts.SelectedIndex]);
				LanguageChanged(null, null);
				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void CreateTextFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				string list = "";
				for (int i=0; i < lbtexts.Items.Count; i++)
				{
					StrToken item = (StrToken)this.lbtexts.Items[i];
					list += "0x" + i.ToString("X") +": " + item.Title + " ("+item.Description+")"+Helper.lbr;
				}

				Clipboard.SetDataObject(list, true);
			} 
			catch (Exception) { }
		}

		private void ClearStr(object sender, System.EventArgs e)
		{

			try 
			{
				Str wrp = (Str)wrapper;	
				wrp.Items = new StrItemList();
				this.cblanguage.Items.Clear();

				StrLanguageList lngs = new StrLanguageList();
				for (int i=1; i<45; i++) 
				{
					StrLanguage lng = new StrLanguage((byte)i);
					cblanguage.Items.Add(lng);
					lngs.Add(lng);
				}
				wrp.Languages = lngs;
				this.cblanguage.SelectedIndex = 0;
				LanguageChanged(null, null);
			} 
			catch (Exception) { }
		}

		private void LanguageChanged(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			lbtexts.Items.Clear();
			if (this.cblanguage.SelectedIndex<0) return;

			try 
			{
				Str wrp = (Str)wrapper;	
				foreach (StrToken s in wrp.LanguageItems((StrLanguage)cblanguage.Items[cblanguage.SelectedIndex])) lbtexts.Items.Add(s);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}  			
			
		}

		private void StringSelected(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;			
			llcommit.Enabled = false;
			llchangeall.Enabled = false;
			lldelete.Enabled = false;
			lldelall.Enabled = false;
			if (lbtexts.SelectedIndex<0) return;

			this.Tag = true;
			try 
			{
				StrToken s = (StrToken)lbtexts.Items[lbtexts.SelectedIndex];

				rtbvalue.Text = s.Title;
				rtbdesc.Text = s.Description;
				llcommit.Enabled = true;
				llchangeall.Enabled = true;
				lldelete.Enabled = true;
				lldelall.Enabled = true;

				gbstr.Text = "0x"+Helper.HexString((ushort)lbtexts.SelectedIndex);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}  
			finally
			{
				this.Tag = null;
			}
		}

		private void StrAdd(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lbtexts.SelectedIndex = -1;
			CommitChanges(null, null);
			lbtexts.SelectedIndex = lbtexts.Items.Count -1;
		}

		private void CommitChanges(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.Tag!=null) return;

			
			llcommit.Enabled = (lbtexts.SelectedIndex<0);
			if (this.cblanguage.SelectedIndex<0) return;

			this.Tag = true;
			try 
			{				
				Str wrp = (Str)wrapper;

				if (lbtexts.SelectedIndex < 0)
				{
					StrToken s = new StrToken(lbtexts.Items.Count, (StrLanguage)cblanguage.Items[cblanguage.SelectedIndex]
						,rtbvalue.Text
						,rtbdesc.Text
						);
					wrp.Add(s);
					lbtexts.Items.Add(s);
				}
				else
				{
					StrToken s = (StrToken)lbtexts.Items[lbtexts.SelectedIndex];
					s.Title = rtbvalue.Text;
					s.Description = rtbdesc.Text;
					lbtexts.Items[lbtexts.SelectedIndex] = s;	// is that needed?
				}

				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		private void CommitStr(object sender, System.EventArgs e)
		{
			try 
			{
				if (this.lbtexts.SelectedIndex>=0) CommitChanges(null, null);
				Str wrp = (Str)wrapper;	
				//foreach (StrItem s in wrp.LanguageItems((StrLanguage)cblanguage.Items[cblanguage.SelectedIndex])) lbtexts.Items.Add(s);
				wrp.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}  
		} 

		private void ChangeInAllLanguages(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			int curIndex = lbtexts.SelectedIndex;			// The current language string index
			if (curIndex < 0) return;
			try 
			{
				Str wrp = (Str)wrapper;
				StrToken s = (StrToken)lbtexts.Items[curIndex];	// The StrItem in the current language (lbtexts.Items)
			
				s.Title = rtbvalue.Text;
				s.Description = rtbdesc.Text;

				foreach (StrLanguage lng in wrp.Languages)
				{
					if (lng == null) continue;

					// Add empty StrItem entries to pad to the string index we want to change, if needed
					while (wrp.LanguageItems(lng).Length <= curIndex)
						wrp.Add(new StrToken(wrp.LanguageItems(lng).Length, lng, "", ""));

					StrItemList sis = wrp.LanguageItems(lng);
					sis[curIndex].Title = s.Title;
					sis[curIndex].Description = s.Description;
				}

				LanguageChanged(null, null);
				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void AddToAll(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{				
				Str wrp = (Str)wrapper;
				
				//find longest String List
				int count = 0;
				foreach (StrLanguage lng in wrp.Languages) count = Math.Max(count, wrp.LanguageItems(lng).Length);
				
				foreach (StrLanguage lng in wrp.Languages) 
				{
					if (lng == null) continue;
					while (wrp.LanguageItems(lng).Length < count) 
						wrp.Add(new StrToken(wrp.LanguageItems(lng).Length, lng, "", ""));

					wrp.Add(new StrToken(wrp.LanguageItems(lng).Length, lng, rtbvalue.Text, rtbdesc.Text));
				}

				LanguageChanged(null, null);
				wrp.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}		
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			StrLanguageList ls = new StrLanguageList();
			this.cblanguage.Items.Clear();
			this.cblanguage.Sorted = false;
			for (byte i=1; i<45; i++) 
			{
				ls.Add(new StrLanguage(i));
				this.cblanguage.Items.Add(ls[ls.Count-1]);
			}

			Str wrp = (Str)wrapper;
			wrp.Languages = ls;
			wrp.Changed = true;

			this.cblanguage.Sorted = true;
			if (this.cblanguage.Items.Count>0) this.cblanguage.SelectedIndex = 0;			
		}

		private void ChangeText(object sender, System.EventArgs e)
		{
			if (lbtexts.SelectedIndex<0) return;
			CommitChanges(null, null);
		}
		#endregion
	}
}
