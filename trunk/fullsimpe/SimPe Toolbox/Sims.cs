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
	/// Zusammenfassung für Sims.
	/// </summary>
	public class Sims : System.Windows.Forms.Form
	{
		private System.Windows.Forms.ImageList ilist;
		private System.Windows.Forms.ListView lv;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ImageList iListSmall;
		private System.Windows.Forms.CheckBox cbdetail;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.ComponentModel.IContainer components;

		public Sims()
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
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Sims));
			this.ilist = new System.Windows.Forms.ImageList(this.components);
			this.lv = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.iListSmall = new System.Windows.Forms.ImageList(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cbdetail = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// ilist
			// 
			this.ilist.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.ilist.ImageSize = ((System.Drawing.Size)(resources.GetObject("ilist.ImageSize")));
			this.ilist.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.columnHeader1,
																				 this.columnHeader2,
																				 this.columnHeader3,
																				 this.columnHeader4,
																				 this.columnHeader5});
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.FullRowSelect = true;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.LargeImageList = this.ilist;
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.SmallImageList = this.iListSmall;
			this.lv.StateImageList = this.iListSmall;
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.toolTip1.SetToolTip(this.lv, resources.GetString("lv.ToolTip"));
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.DoubleClick += new System.EventHandler(this.Open);
			this.lv.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.SortList);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = resources.GetString("columnHeader1.Text");
			this.columnHeader1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader1.TextAlign")));
			this.columnHeader1.Width = ((int)(resources.GetObject("columnHeader1.Width")));
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = resources.GetString("columnHeader2.Text");
			this.columnHeader2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader2.TextAlign")));
			this.columnHeader2.Width = ((int)(resources.GetObject("columnHeader2.Width")));
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = resources.GetString("columnHeader3.Text");
			this.columnHeader3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader3.TextAlign")));
			this.columnHeader3.Width = ((int)(resources.GetObject("columnHeader3.Width")));
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = resources.GetString("columnHeader4.Text");
			this.columnHeader4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader4.TextAlign")));
			this.columnHeader4.Width = ((int)(resources.GetObject("columnHeader4.Width")));
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = resources.GetString("columnHeader5.Text");
			this.columnHeader5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader5.TextAlign")));
			this.columnHeader5.Width = ((int)(resources.GetObject("columnHeader5.Width")));
			// 
			// iListSmall
			// 
			this.iListSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.iListSmall.ImageSize = ((System.Drawing.Size)(resources.GetObject("iListSmall.ImageSize")));
			this.iListSmall.TransparentColor = System.Drawing.Color.Transparent;
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
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.button1.Click += new System.EventHandler(this.Open);
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.Color.SteelBlue;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
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
			this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
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
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.Color.LightCoral;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
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
			this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// cbdetail
			// 
			this.cbdetail.AccessibleDescription = resources.GetString("cbdetail.AccessibleDescription");
			this.cbdetail.AccessibleName = resources.GetString("cbdetail.AccessibleName");
			this.cbdetail.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbdetail.Anchor")));
			this.cbdetail.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbdetail.Appearance")));
			this.cbdetail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbdetail.BackgroundImage")));
			this.cbdetail.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdetail.CheckAlign")));
			this.cbdetail.Checked = true;
			this.cbdetail.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbdetail.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbdetail.Dock")));
			this.cbdetail.Enabled = ((bool)(resources.GetObject("cbdetail.Enabled")));
			this.cbdetail.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbdetail.FlatStyle")));
			this.cbdetail.Font = ((System.Drawing.Font)(resources.GetObject("cbdetail.Font")));
			this.cbdetail.Image = ((System.Drawing.Image)(resources.GetObject("cbdetail.Image")));
			this.cbdetail.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdetail.ImageAlign")));
			this.cbdetail.ImageIndex = ((int)(resources.GetObject("cbdetail.ImageIndex")));
			this.cbdetail.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbdetail.ImeMode")));
			this.cbdetail.Location = ((System.Drawing.Point)(resources.GetObject("cbdetail.Location")));
			this.cbdetail.Name = "cbdetail";
			this.cbdetail.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbdetail.RightToLeft")));
			this.cbdetail.Size = ((System.Drawing.Size)(resources.GetObject("cbdetail.Size")));
			this.cbdetail.TabIndex = ((int)(resources.GetObject("cbdetail.TabIndex")));
			this.cbdetail.Text = resources.GetString("cbdetail.Text");
			this.cbdetail.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbdetail.TextAlign")));
			this.toolTip1.SetToolTip(this.cbdetail, resources.GetString("cbdetail.ToolTip"));
			this.cbdetail.Visible = ((bool)(resources.GetObject("cbdetail.Visible")));
			this.cbdetail.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Sims
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lv);
			this.Controls.Add(this.cbdetail);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Sims";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.ShowInTaskbar = false;
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
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
					this.iListSmall.Images.Add(ImageLoader.Preview(img, iListSmall.ImageSize));
				} 				
				else 
				{
					this.ilist.Images.Add(sdesc.Image);
					this.iListSmall.Images.Add(ImageLoader.Preview(sdesc.Image, iListSmall.ImageSize));
				}
			} 
			else 
			{
				this.ilist.Images.Add(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")));
				this.iListSmall.Images.Add(ImageLoader.Preview(new Bitmap(this.GetType().Assembly.GetManifestResourceStream("SimPe.Plugin.Network.png")), iListSmall.ImageSize));
			}
		}

		protected void AddSim(SimPe.PackedFiles.Wrapper.SDesc sdesc) 
		{
			if (!sdesc.HasImage) return;

			AddImage(sdesc);
			ListViewItem lvi = new ListViewItem();
			lvi.Text = sdesc.SimName +" "+sdesc.SimFamilyName;
			lvi.ImageIndex = ilist.Images.Count -1;
			lvi.Tag = sdesc;

			lvi.SubItems.Add(sdesc.HouseholdName);
			lvi.SubItems.Add(new Data.LocalizedLifeSections(sdesc.CharacterDescription.LifeSection).ToString());
			if (sdesc.University.OnCampus==0x1) lvi.SubItems.Add(Localization.Manager.GetString("yes")); else lvi.SubItems.Add(Localization.Manager.GetString("no"));
			lvi.SubItems.Add("0x"+Helper.HexString(sdesc.FileDescriptor.Instance));
		
			
			//toolTip1.SetToolTip(lvi, sdesc.CharacterFileName);
			lv.Items.Add(lvi);
		}

		SimPe.Interfaces.Files.IPackedFileDescriptor pfd;
		public Interfaces.Plugin.IToolResult Execute(ref SimPe.Interfaces.Files.IPackedFileDescriptor pfd, ref SimPe.Interfaces.Files.IPackageFile package, Interfaces.IProviderRegistry prov) 
		{
			sorter = new ColumnSorter();
			this.Cursor = Cursors.WaitCursor;
			
			this.pfd = null;
			ilist.Images.Clear();
			lv.Items.Clear();
			lv.Sorting = SortOrder.Ascending;			

			Interfaces.Files.IPackedFileDescriptor[] pfds = package.FindFiles(Data.MetaData.SIM_DESCRIPTION_FILE);
			foreach(Interfaces.Files.IPackedFileDescriptor spfd in pfds) 
			{
				WaitingScreen.Wait();
				PackedFiles.Wrapper.SDesc sdesc = new SimPe.PackedFiles.Wrapper.SDesc(prov.SimNameProvider, prov.SimFamilynameProvider, null);
				sdesc.ProcessData(spfd, package);
				
				//WaitingScreen.UpdateImage(ImageLoader.Preview(sdesc.Image, new Size(64, 64)));
				AddSim(sdesc);
			}

			lv.Sort();
			this.Cursor = Cursors.Default;
			WaitingScreen.Stop(this);
			ShowDialog();

			if (this.pfd!=null) pfd = this.pfd;
			return new Plugin.ToolResult((this.pfd!=null), false);
		}

		private void Open(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count<1) return;
			
			pfd = (SimPe.Interfaces.Files.IPackedFileDescriptor)((PackedFiles.Wrapper.SDesc)lv.SelectedItems[0].Tag).FileDescriptor;
			Close();
		}

		private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
		{
			if (cbdetail.Checked) lv.View = View.Details;
			else lv.View = View.LargeIcon;
		}

		ColumnSorter sorter;
		private void SortList(object sender, System.Windows.Forms.ColumnClickEventArgs e)
		{
			if (sorter.CurrentColumn == e.Column) 
			{				
				if (lv.Sorting == SortOrder.Ascending) lv.Sorting = SortOrder.Descending;
				else lv.Sorting = SortOrder.Ascending;
			} 
			else 
			{
				sorter.CurrentColumn = e.Column;
				lv.ListViewItemSorter = sorter;
			}
			sorter.Sorting = lv.Sorting;
			lv.Sort();
		}
	}
}
