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

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für MyPackedFileForm.
	/// </summary>
	public class RefFileForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel wrapperPanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.ListBox lblist;
		private System.Windows.Forms.GroupBox gbtypes;
		private System.Windows.Forms.Panel pntypes;
		internal System.Windows.Forms.TextBox tbsubtype;
		internal System.Windows.Forms.TextBox tbinstance;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbgroup;
		internal System.Windows.Forms.ComboBox cbtypes;
		internal System.Windows.Forms.LinkLabel llcommit;
		internal System.Windows.Forms.LinkLabel lldelete;
		internal System.Windows.Forms.LinkLabel lladd;
		private System.Windows.Forms.Button button1;
		internal System.Windows.Forms.Button btup;
		internal System.Windows.Forms.Button btdown;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem miAdd;
		internal System.Windows.Forms.MenuItem miRem;
		private System.ComponentModel.IContainer components;

		public RefFileForm()
		{
			components = null;
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
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

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.wrapperPanel = new System.Windows.Forms.Panel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.btdown = new System.Windows.Forms.Button();
			this.btup = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.gbtypes = new System.Windows.Forms.GroupBox();
			this.pntypes = new System.Windows.Forms.Panel();
			this.lladd = new System.Windows.Forms.LinkLabel();
			this.lldelete = new System.Windows.Forms.LinkLabel();
			this.tbsubtype = new System.Windows.Forms.TextBox();
			this.tbinstance = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tbgroup = new System.Windows.Forms.TextBox();
			this.cbtypes = new System.Windows.Forms.ComboBox();
			this.llcommit = new System.Windows.Forms.LinkLabel();
			this.lblist = new System.Windows.Forms.ListBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.miAdd = new System.Windows.Forms.MenuItem();
			this.miRem = new System.Windows.Forms.MenuItem();
			this.wrapperPanel.SuspendLayout();
			this.gbtypes.SuspendLayout();
			this.pntypes.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// wrapperPanel
			// 
			this.wrapperPanel.AutoScroll = true;
			this.wrapperPanel.Controls.Add(this.pb);
			this.wrapperPanel.Controls.Add(this.button2);
			this.wrapperPanel.Controls.Add(this.button4);
			this.wrapperPanel.Controls.Add(this.btdown);
			this.wrapperPanel.Controls.Add(this.btup);
			this.wrapperPanel.Controls.Add(this.button1);
			this.wrapperPanel.Controls.Add(this.gbtypes);
			this.wrapperPanel.Controls.Add(this.lblist);
			this.wrapperPanel.Controls.Add(this.panel3);
			this.wrapperPanel.Location = new System.Drawing.Point(8, 8);
			this.wrapperPanel.Name = "wrapperPanel";
			this.wrapperPanel.Size = new System.Drawing.Size(664, 328);
			this.wrapperPanel.TabIndex = 3;
			// 
			// pb
			// 
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pb.Location = new System.Drawing.Point(240, 168);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(160, 152);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb.TabIndex = 43;
			this.pb.TabStop = false;
			this.pb.SizeChanged += new System.EventHandler(this.pb_SizeChanged);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button2.Location = new System.Drawing.Point(320, 28);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(72, 21);
			this.button2.TabIndex = 42;
			this.button2.Text = "Package";
			this.button2.Click += new System.EventHandler(this.ShowPackageSelector);
			// 
			// button4
			// 
			this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button4.Location = new System.Drawing.Point(288, 28);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(21, 21);
			this.button4.TabIndex = 41;
			this.button4.Text = "u";
			this.button4.Click += new System.EventHandler(this.ChooseFile);
			// 
			// btdown
			// 
			this.btdown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btdown.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btdown.Location = new System.Drawing.Point(176, 192);
			this.btdown.Name = "btdown";
			this.btdown.Size = new System.Drawing.Size(48, 23);
			this.btdown.TabIndex = 22;
			this.btdown.Text = "down";
			this.btdown.Click += new System.EventHandler(this.MoveDown);
			// 
			// btup
			// 
			this.btup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btup.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btup.Location = new System.Drawing.Point(176, 168);
			this.btup.Name = "btup";
			this.btup.Size = new System.Drawing.Size(48, 23);
			this.btup.TabIndex = 21;
			this.btup.Text = "up";
			this.btup.Click += new System.EventHandler(this.MoveUp);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.button1.Location = new System.Drawing.Point(176, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 23);
			this.button1.TabIndex = 20;
			this.button1.Text = "Commit";
			this.button1.Click += new System.EventHandler(this.CommitAll);
			// 
			// gbtypes
			// 
			this.gbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.gbtypes.Controls.Add(this.pntypes);
			this.gbtypes.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbtypes.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.gbtypes.Location = new System.Drawing.Point(176, 32);
			this.gbtypes.Name = "gbtypes";
			this.gbtypes.Size = new System.Drawing.Size(480, 128);
			this.gbtypes.TabIndex = 19;
			this.gbtypes.TabStop = false;
			this.gbtypes.Text = "File Properties";
			// 
			// pntypes
			// 
			this.pntypes.Controls.Add(this.lladd);
			this.pntypes.Controls.Add(this.lldelete);
			this.pntypes.Controls.Add(this.tbsubtype);
			this.pntypes.Controls.Add(this.tbinstance);
			this.pntypes.Controls.Add(this.label11);
			this.pntypes.Controls.Add(this.tbtype);
			this.pntypes.Controls.Add(this.label8);
			this.pntypes.Controls.Add(this.label9);
			this.pntypes.Controls.Add(this.label10);
			this.pntypes.Controls.Add(this.tbgroup);
			this.pntypes.Controls.Add(this.cbtypes);
			this.pntypes.Controls.Add(this.llcommit);
			this.pntypes.Location = new System.Drawing.Point(8, 24);
			this.pntypes.Name = "pntypes";
			this.pntypes.Size = new System.Drawing.Size(464, 96);
			this.pntypes.TabIndex = 19;
			// 
			// lladd
			// 
			this.lladd.AutoSize = true;
			this.lladd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.lladd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lladd.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
			this.lladd.Location = new System.Drawing.Point(384, 80);
			this.lladd.Name = "lladd";
			this.lladd.Size = new System.Drawing.Size(28, 17);
			this.lladd.TabIndex = 19;
			this.lladd.TabStop = true;
			this.lladd.Text = "add";
			this.lladd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddFile);
			// 
			// lldelete
			// 
			this.lldelete.AutoSize = true;
			this.lldelete.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.lldelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.lldelete.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
			this.lldelete.Location = new System.Drawing.Point(416, 80);
			this.lldelete.Name = "lldelete";
			this.lldelete.Size = new System.Drawing.Size(44, 17);
			this.lldelete.TabIndex = 18;
			this.lldelete.TabStop = true;
			this.lldelete.Text = "delete";
			this.lldelete.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DeleteFile);
			// 
			// tbsubtype
			// 
			this.tbsubtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbsubtype.Location = new System.Drawing.Point(120, 24);
			this.tbsubtype.Name = "tbsubtype";
			this.tbsubtype.TabIndex = 12;
			this.tbsubtype.Text = "";
			this.tbsubtype.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// tbinstance
			// 
			this.tbinstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbinstance.Location = new System.Drawing.Point(120, 72);
			this.tbinstance.Name = "tbinstance";
			this.tbinstance.TabIndex = 14;
			this.tbinstance.Text = "";
			this.tbinstance.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label11.Location = new System.Drawing.Point(0, 72);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(112, 17);
			this.label11.TabIndex = 10;
			this.label11.Text = "Instance:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbtype
			// 
			this.tbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbtype.Location = new System.Drawing.Point(120, 0);
			this.tbtype.Name = "tbtype";
			this.tbtype.TabIndex = 11;
			this.tbtype.Text = "";
			this.tbtype.TextChanged += new System.EventHandler(this.tbtype_TextChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 17);
			this.label8.TabIndex = 7;
			this.label8.Text = "File Type:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new System.Drawing.Point(0, 24);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(112, 17);
			this.label9.TabIndex = 8;
			this.label9.Text = "SubType/Class ID:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new System.Drawing.Point(0, 48);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 17);
			this.label10.TabIndex = 9;
			this.label10.Text = "Group:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// tbgroup
			// 
			this.tbgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbgroup.Location = new System.Drawing.Point(120, 48);
			this.tbgroup.Name = "tbgroup";
			this.tbgroup.TabIndex = 13;
			this.tbgroup.Text = "";
			this.tbgroup.TextChanged += new System.EventHandler(this.AutoChange);
			// 
			// cbtypes
			// 
			this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cbtypes.ItemHeight = 13;
			this.cbtypes.Location = new System.Drawing.Point(224, 0);
			this.cbtypes.Name = "cbtypes";
			this.cbtypes.Size = new System.Drawing.Size(240, 21);
			this.cbtypes.Sorted = true;
			this.cbtypes.TabIndex = 16;
			this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.SelectType);
			// 
			// llcommit
			// 
			this.llcommit.AutoSize = true;
			this.llcommit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.llcommit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.llcommit.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
			this.llcommit.Location = new System.Drawing.Point(328, 80);
			this.llcommit.Name = "llcommit";
			this.llcommit.Size = new System.Drawing.Size(50, 17);
			this.llcommit.TabIndex = 17;
			this.llcommit.TabStop = true;
			this.llcommit.Text = "change";
			this.llcommit.Visible = false;
			this.llcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangeFile);
			// 
			// lblist
			// 
			this.lblist.AllowDrop = true;
			this.lblist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lblist.ContextMenu = this.contextMenu1;
			this.lblist.HorizontalScrollbar = true;
			this.lblist.IntegralHeight = false;
			this.lblist.Location = new System.Drawing.Point(8, 32);
			this.lblist.Name = "lblist";
			this.lblist.Size = new System.Drawing.Size(160, 288);
			this.lblist.TabIndex = 1;
			this.lblist.DragDrop += new System.Windows.Forms.DragEventHandler(this.PackageItemDrop);
			this.lblist.DragEnter += new System.Windows.Forms.DragEventHandler(this.PackageItemDragEnter);
			this.lblist.SelectedIndexChanged += new System.EventHandler(this.SelectFile);
			// 
			// panel3
			// 
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.Controls.Add(this.label1);
			this.panel3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(664, 24);
			this.panel3.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(0, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(201, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "3D Referencing File Editor";
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.miAdd,
																						 this.miRem});
			// 
			// miAdd
			// 
			this.miAdd.Index = 0;
			this.miAdd.Text = "&Add";
			this.miAdd.Click += new System.EventHandler(this.miAdd_Click);
			// 
			// miRem
			// 
			this.miRem.Index = 1;
			this.miRem.Text = "&Delete";
			this.miRem.Click += new System.EventHandler(this.menuItem1_Click);
			// 
			// RefFileForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(856, 350);
			this.Controls.Add(this.wrapperPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "RefFileForm";
			this.Text = "MyPackedFileForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.wrapperPanel.ResumeLayout(false);
			this.gbtypes.ResumeLayout(false);
			this.pntypes.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		
		/// <summary>
		/// Stores the currently active Wrapper
		/// </summary>
		internal IFileWrapperSaveExtension wrapper = null;

		private void SelectType(object sender, System.EventArgs e)
		{
			if (cbtypes.Tag != null) return;
			tbtype.Text = "0x"+Helper.HexString(((SimPe.Data.TypeAlias)cbtypes.Items[cbtypes.SelectedIndex]).Id);
		}

		private void tbtype_TextChanged(object sender, System.EventArgs e)
		{
			cbtypes.Tag = true;
			Data.TypeAlias a = Data.MetaData.FindTypeAlias(Helper.HexStringToUInt(tbtype.Text));

			this.AutoChange(sender, e);
			int ct=0;
			foreach(Data.TypeAlias i in cbtypes.Items) 
			{								
				if (i==a) 
				{
					cbtypes.SelectedIndex = ct;
					cbtypes.Tag = null;
					return;
				}
				ct++;
			}

			cbtypes.SelectedIndex = -1;
			cbtypes.Tag = null;
		}

		private void SelectFile(object sender, System.EventArgs e)
		{
			llcommit.Enabled = false;
			lldelete.Enabled = false;
			btup.Enabled = false;
			btdown.Enabled = false;
			miAdd.Enabled = false;
			miRem.Enabled = lldelete.Enabled;
			if (lblist.SelectedIndex<0) return;
			llcommit.Enabled = true;
			lldelete.Enabled = true;
			btup.Enabled = true;
			btdown.Enabled = true;
			miAdd.Enabled = true;
			miRem.Enabled = lldelete.Enabled;

			if (tbtype.Tag!=null) return;
			try 
			{
				tbtype.Tag = true;
				Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
				this.tbgroup.Text = "0x"+Helper.HexString(pfd.Group);
				this.tbinstance.Text = "0x"+Helper.HexString(pfd.Instance);
				this.tbsubtype.Text = "0x"+Helper.HexString(pfd.SubType);
				this.tbtype.Text = "0x"+Helper.HexString(pfd.Type);

				//get Texture
				if (pfd.GetType()==typeof(RefFileItem)) 
				{
					RefFile wrp = (RefFile)wrapper;
					SkinChain sc = ((RefFileItem)pfd).Skin;
					SimPe.Plugin.GenericRcol txtr = null;
					if (sc!=null) txtr = sc.TXTR;
					
					//show the Image
					if (txtr==null) 
					{
						pb.Image = null;
					} 
					else 
					{
						MipMap mm = ((ImageData)txtr.Blocks[0]).GetLargestTexture(pb.Size);
						if (mm!=null) pb.Image = mm.Texture;
						else pb.Image = null;
					}
				} 
				else 
				{
					pb.Image = null;
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			} 
			finally 
			{
				tbtype.Tag = null;
			}
		}

		private void ChangeFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				Packages.PackedFileDescriptor pfd = null;
				if (lblist.SelectedIndex>=0) pfd = (Packages.PackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
				else pfd = new Packages.PackedFileDescriptor();

				pfd.Group = Convert.ToUInt32(this.tbgroup.Text, 16);
				pfd.Instance = Convert.ToUInt32(this.tbinstance.Text, 16);
				pfd.SubType = Convert.ToUInt32(this.tbsubtype.Text, 16);
				pfd.Type = Convert.ToUInt32(this.tbtype.Text, 16);

				if (lblist.SelectedIndex>=0) 
				{
					lblist.Items[lblist.SelectedIndex] = pfd;
					try 
					{
						RefFileItem rfi = (RefFileItem)pfd;
						rfi.Skin = null;
					} 
					catch {}
				}
				else lblist.Items.Add(pfd);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		private void DeleteFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			llcommit.Enabled = false;
			lldelete.Enabled = false;
			btup.Enabled = false;
			btdown.Enabled = false;
			miRem.Enabled = lldelete.Enabled;
			if (lblist.SelectedIndex<0) return;
			llcommit.Enabled = true;
			lldelete.Enabled = true;
			btup.Enabled = true;
			btdown.Enabled = true;
			miRem.Enabled = lldelete.Enabled;

			lblist.Items.Remove(lblist.Items[lblist.SelectedIndex]);
		}

		private void AddFile(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			lblist.SelectedIndex = -1;
			ChangeFile(null, null);
			lblist.SelectedIndex = lblist.Items.Count - 1;
		}

		private void CommitAll(object sender, System.EventArgs e)
		{
			try 
			{
				RefFile wrp = (RefFile)wrapper;				

				Interfaces.Files.IPackedFileDescriptor[] pfds = new Interfaces.Files.IPackedFileDescriptor[lblist.Items.Count];
				for (int i=0; i<pfds.Length; i++) 
				{
					pfds[i] = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[i];
				}

				wrp.Items = pfds;
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}	
		}

		private void MoveUp(object sender, System.EventArgs e)
		{
			if (lblist.SelectedIndex<1) return;
			
			Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
			lblist.Items[lblist.SelectedIndex] = lblist.Items[lblist.SelectedIndex-1];
			lblist.Items[lblist.SelectedIndex-1] = pfd;
			lblist.SelectedIndex--;
		}

		private void MoveDown(object sender, System.EventArgs e)
		{
			if (lblist.SelectedIndex<0) return;
			if (lblist.SelectedIndex>lblist.Items.Count-2) return;
			
			Interfaces.Files.IPackedFileDescriptor pfd = (Interfaces.Files.IPackedFileDescriptor)lblist.Items[lblist.SelectedIndex];
			lblist.Items[lblist.SelectedIndex] = lblist.Items[lblist.SelectedIndex+1];
			lblist.Items[lblist.SelectedIndex+1] = pfd;
			lblist.SelectedIndex++;
		}

		private void AutoChange(object sender, System.EventArgs e)
		{
			if (tbtype.Tag != null) return;

			tbtype.Tag = true;
			if (lblist.SelectedIndex>=0) ChangeFile(null, null);
			tbtype.Tag = null;
		}

		private void ChooseFile(object sender, System.EventArgs e)
		{
			try 
			{
				RefFile wrp = (RefFile)wrapper;
				//FileSelect fs = new FileSelect(wrp.Provider);
				Interfaces.Files.IPackedFileDescriptor pfd = FileSelect.Execute();
				if (pfd!=null) 
				{
					tbtype.Tag = true;
					this.tbgroup.Text = "0x"+Helper.HexString(pfd.Group);
					this.tbinstance.Text = "0x"+Helper.HexString(pfd.Instance);
					this.tbsubtype.Text = "0x"+Helper.HexString(pfd.SubType);
					this.tbtype.Text = "0x"+Helper.HexString(pfd.Type);
					tbtype.Tag = null;
					this.AutoChange(sender, e);
				}
			} 
			catch (Exception) {} 
			finally 
			{
				tbtype.Tag = null;
			}
		}

		#region Package Selector
		private void ShowPackageSelector(object sender, System.EventArgs e)
		{
			SimPe.PackageSelectorForm form = new SimPe.PackageSelectorForm();
			form.Execute(((RefFile)wrapper).Package);
		}

		private void PackageItemDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(SimPe.Packages.PackedFileDescriptor))) 
			{				
				e.Effect = DragDropEffects.Copy;	
			}
			else 
			{
				e.Effect = DragDropEffects.None;
			}					
		}

		private void PackageItemDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = null;
				pfd = (Interfaces.Files.IPackedFileDescriptor)e.Data.GetData(typeof(SimPe.Packages.PackedFileDescriptor));				
				lblist.Items.Add(pfd);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}
		#endregion

		private void pb_SizeChanged(object sender, System.EventArgs e)
		{
			pb.Width = pb.Height;
		}

		private void miAdd_Click(object sender, System.EventArgs e)
		{
			AddFile(null, null);
		}

		private void menuItem1_Click(object sender, System.EventArgs e)
		{
			DeleteFile(null, null);
		}
	}
}
