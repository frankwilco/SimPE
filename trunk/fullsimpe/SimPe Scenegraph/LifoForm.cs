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
using SimPe.Interfaces.Scenegraph;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für LifoForm.
	/// </summary>
	public class LifoForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LifoForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(LifoForm));
			this.LifoPanel = new System.Windows.Forms.Panel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.tbz = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.tbheight = new System.Windows.Forms.TextBox();
			this.tbwidth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbformats = new System.Windows.Forms.ComboBox();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbitem = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.contextMenu1 = new System.Windows.Forms.ContextMenu();
			this.menuItem1 = new System.Windows.Forms.MenuItem();
			this.menuItem4 = new System.Windows.Forms.MenuItem();
			this.menuItem3 = new System.Windows.Forms.MenuItem();
			this.menuItem2 = new System.Windows.Forms.MenuItem();
			this.menuItem5 = new System.Windows.Forms.MenuItem();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btex = new System.Windows.Forms.Button();
			this.btim = new System.Windows.Forms.Button();
			this.label27 = new System.Windows.Forms.Label();
			this.btcommit = new System.Windows.Forms.Button();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.LifoPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// LifoPanel
			// 
			this.LifoPanel.Controls.Add(this.linkLabel2);
			this.LifoPanel.Controls.Add(this.linkLabel1);
			this.LifoPanel.Controls.Add(this.label1);
			this.LifoPanel.Controls.Add(this.tbz);
			this.LifoPanel.Controls.Add(this.label5);
			this.LifoPanel.Controls.Add(this.tbheight);
			this.LifoPanel.Controls.Add(this.tbwidth);
			this.LifoPanel.Controls.Add(this.label4);
			this.LifoPanel.Controls.Add(this.label3);
			this.LifoPanel.Controls.Add(this.cbformats);
			this.LifoPanel.Controls.Add(this.tbflname);
			this.LifoPanel.Controls.Add(this.label2);
			this.LifoPanel.Controls.Add(this.cbitem);
			this.LifoPanel.Controls.Add(this.panel1);
			this.LifoPanel.Controls.Add(this.panel2);
			this.LifoPanel.Location = new System.Drawing.Point(8, 8);
			this.LifoPanel.Name = "LifoPanel";
			this.LifoPanel.Size = new System.Drawing.Size(768, 288);
			this.LifoPanel.TabIndex = 19;
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(288, 80);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(47, 17);
			this.linkLabel2.TabIndex = 19;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "fix TGI";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.FixTGI);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.Location = new System.Drawing.Point(343, 80);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(81, 17);
			this.linkLabel1.TabIndex = 18;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "assign Hash";
			this.linkLabel1.Visible = false;
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BuildFilename);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(248, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "Z-Level:";
			// 
			// tbz
			// 
			this.tbz.Location = new System.Drawing.Point(304, 128);
			this.tbz.Name = "tbz";
			this.tbz.Size = new System.Drawing.Size(56, 21);
			this.tbz.TabIndex = 16;
			this.tbz.Text = "";
			this.tbz.TextChanged += new System.EventHandler(this.ChangeZLevel);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(141, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(12, 17);
			this.label5.TabIndex = 15;
			this.label5.Text = "x";
			// 
			// tbheight
			// 
			this.tbheight.Location = new System.Drawing.Point(160, 128);
			this.tbheight.Name = "tbheight";
			this.tbheight.ReadOnly = true;
			this.tbheight.Size = new System.Drawing.Size(56, 21);
			this.tbheight.TabIndex = 14;
			this.tbheight.Text = "";
			// 
			// tbwidth
			// 
			this.tbwidth.Location = new System.Drawing.Point(80, 128);
			this.tbwidth.Name = "tbwidth";
			this.tbwidth.ReadOnly = true;
			this.tbwidth.Size = new System.Drawing.Size(56, 21);
			this.tbwidth.TabIndex = 13;
			this.tbwidth.Text = "";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(43, 136);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 17);
			this.label4.TabIndex = 12;
			this.label4.Text = "Size:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(24, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 17);
			this.label3.TabIndex = 11;
			this.label3.Text = "Format:";
			// 
			// cbformats
			// 
			this.cbformats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbformats.Location = new System.Drawing.Point(80, 104);
			this.cbformats.Name = "cbformats";
			this.cbformats.Size = new System.Drawing.Size(344, 21);
			this.cbformats.TabIndex = 10;
			this.cbformats.SelectedIndexChanged += new System.EventHandler(this.ChangeFormat);
			// 
			// tbflname
			// 
			this.tbflname.Location = new System.Drawing.Point(80, 56);
			this.tbflname.Name = "tbflname";
			this.tbflname.Size = new System.Drawing.Size(344, 21);
			this.tbflname.TabIndex = 9;
			this.tbflname.Text = "";
			this.tbflname.TextChanged += new System.EventHandler(this.FileNameChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(11, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Filename:";
			// 
			// cbitem
			// 
			this.cbitem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbitem.Location = new System.Drawing.Point(80, 32);
			this.cbitem.Name = "cbitem";
			this.cbitem.Size = new System.Drawing.Size(344, 21);
			this.cbitem.TabIndex = 7;
			this.cbitem.SelectedIndexChanged += new System.EventHandler(this.SelectItem);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.pb);
			this.panel1.Location = new System.Drawing.Point(432, 32);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(328, 248);
			this.panel1.TabIndex = 4;
			// 
			// pb
			// 
			this.pb.BackColor = System.Drawing.SystemColors.Control;
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.ContextMenu = this.contextMenu1;
			this.pb.Location = new System.Drawing.Point(0, 0);
			this.pb.Name = "pb";
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pb.TabIndex = 5;
			this.pb.TabStop = false;
			// 
			// contextMenu1
			// 
			this.contextMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																						 this.menuItem1,
																						 this.menuItem4,
																						 this.menuItem3,
																						 this.menuItem2,
																						 this.menuItem5});
			// 
			// menuItem1
			// 
			this.menuItem1.Index = 0;
			this.menuItem1.Text = "&Import...";
			this.menuItem1.Click += new System.EventHandler(this.btim_Click);
			// 
			// menuItem4
			// 
			this.menuItem4.Index = 1;
			this.menuItem4.Text = "Import &Alpha Channel...";
			this.menuItem4.Click += new System.EventHandler(this.ImportAlpha);
			// 
			// menuItem3
			// 
			this.menuItem3.Index = 2;
			this.menuItem3.Text = "-";
			// 
			// menuItem2
			// 
			this.menuItem2.Index = 3;
			this.menuItem2.Text = "&Export...";
			this.menuItem2.Click += new System.EventHandler(this.btex_Click);
			// 
			// menuItem5
			// 
			this.menuItem5.Index = 4;
			this.menuItem5.Text = "Export Alpha &Channel...";
			this.menuItem5.Click += new System.EventHandler(this.ExportAlpha);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.btex);
			this.panel2.Controls.Add(this.btim);
			this.panel2.Controls.Add(this.label27);
			this.panel2.Controls.Add(this.btcommit);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(768, 24);
			this.panel2.TabIndex = 0;
			// 
			// btex
			// 
			this.btex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btex.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btex.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btex.Location = new System.Drawing.Point(584, 0);
			this.btex.Name = "btex";
			this.btex.Size = new System.Drawing.Size(80, 23);
			this.btex.TabIndex = 8;
			this.btex.Text = "Export...";
			this.btex.Click += new System.EventHandler(this.btex_Click);
			// 
			// btim
			// 
			this.btim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btim.Location = new System.Drawing.Point(504, 0);
			this.btim.Name = "btim";
			this.btim.TabIndex = 7;
			this.btim.Text = "Import...";
			this.btim.Click += new System.EventHandler(this.btim_Click);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(82, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Lifo Editor";
			// 
			// btcommit
			// 
			this.btcommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btcommit.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btcommit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btcommit.Location = new System.Drawing.Point(688, 0);
			this.btcommit.Name = "btcommit";
			this.btcommit.TabIndex = 6;
			this.btcommit.Text = "Save";
			this.btcommit.Click += new System.EventHandler(this.btcommit_Click);
			// 
			// sfd
			// 
			this.sfd.Filter = "Png (*.png)|*.png|Bitmap (*.bmp)|*.bmp|Gif (*.gif)|*.gif|JPEG File (*.jpg)|*.jpg|" +
				"All Files (*.*)|*.*";
			this.sfd.Title = "Export Image";
			// 
			// ofd
			// 
			this.ofd.Filter = "Alle Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|Bitmap (*.bmp)" +
				"|*.bmp|Gif (*.gif)|*.gif|JPEG File (*.jpg)|*.jpg|Png (*.png)|*.png|All Files (*." +
				"*)|*.*";
			this.ofd.FilterIndex = 5;
			// 
			// LifoForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(792, 310);
			this.Controls.Add(this.LifoPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LifoForm";
			this.Text = "LifoForm";
			this.LifoPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal System.Windows.Forms.Panel LifoPanel;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.Button btcommit;
		private System.Windows.Forms.Button btim;
		internal System.Windows.Forms.Button btex;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.OpenFileDialog ofd;
		internal System.Windows.Forms.ComboBox cbitem;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbflname;
		internal System.Windows.Forms.ComboBox cbformats;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbwidth;
		private System.Windows.Forms.TextBox tbheight;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbz;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ContextMenu contextMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem menuItem5;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;

		internal Lifo wrapper = null;

		

		private void btcommit_Click(object sender, System.EventArgs e)
		{
			try 
			{
				Lifo wrp = (Lifo)wrapper;
				wrp.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void btex_Click(object sender, System.EventArgs e)
		{
			if (pb.Image == null) return;

			sfd.FileName = this.tbflname.Text+"_"+this.tbwidth.Text+"x"+this.tbheight.Text+".png";
			if (sfd.ShowDialog() == DialogResult.OK) 
			{
				try 
				{
					pb.Image.Save(sfd.FileName);
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
				}
			}
		}

		private void btim_Click(object sender, System.EventArgs e)
		{
			
			if (ofd.ShowDialog() == DialogResult.OK) 
			{
				try 
				{
					LevelInfo id = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
					Image img = Image.FromFile(ofd.FileName);
					img = this.CropImage(id, img);
					if (img==null) return;

					id.Texture = img;
					pb.Image = img;
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
				}
				
			}
		}

		private void SelectItem(object sender, System.EventArgs e)
		{
			if (cbitem.Tag!=null) return;
			if (cbitem.SelectedIndex<0) return;
			try 
			{
				cbitem.Tag = true;
				LevelInfo selecteditem = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
				
				this.tbflname.Text = selecteditem.NameResource.FileName;
				this.tbwidth.Text = selecteditem.TextureSize.Width.ToString();
				this.tbheight.Text = selecteditem.TextureSize.Height.ToString();
				this.tbz.Text = selecteditem.ZLevel.ToString();

				this.cbformats.SelectedIndex = 0;
				for (int i=0; i<cbformats.Items.Count; i++)
				{
					ImageLoader.TxtrFormats f = (ImageLoader.TxtrFormats)cbformats.Items[i];
					if (f==selecteditem.Format) 
					{
						cbformats.SelectedIndex = i;
						break;
					}
				}

				pb.Image = selecteditem.Texture;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			} 
			finally 
			{
				cbitem.Tag = null;
			}
		}

		private void FileNameChanged(object sender, System.EventArgs e)
		{
			if (cbitem.Tag!=null) return;
			if (cbitem.SelectedIndex<0) return;
			try 
			{
				cbitem.Tag = true;
				LevelInfo selecteditem = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
				selecteditem.NameResource.FileName = tbflname.Text;
				cbitem.Items[cbitem.SelectedIndex] = selecteditem;
				cbitem.Text = tbflname.Text;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			}
			
			finally 
			{
				cbitem.Tag = null;
			}
		}

		private void ChangeFormat(object sender, System.EventArgs e)
		{
			if (cbitem.Tag!=null) return;
			if (cbitem.SelectedIndex<0) return;
			if (cbformats.SelectedIndex<1) return;
			try 
			{
				cbitem.Tag = true;
				LevelInfo selecteditem = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
				selecteditem.Format = (ImageLoader.TxtrFormats)cbformats.Items[cbformats.SelectedIndex];
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
			}
			
			finally 
			{
				cbitem.Tag = null;
			}
		}


		protected LevelInfo SelectedLevelInfo()
		{
			//add a MipMapBlock if it doesnt already exist
			LevelInfo li = null;
			if (cbitem.SelectedIndex<0) 
			{
				Lifo wrp = (Lifo)wrapper;
				li = new LevelInfo(wrp);
				li.NameResource.FileName = "Unknown";

				IRcolBlock[] irc = new IRcolBlock[wrp.Blocks.Length+1];
				wrp.Blocks.CopyTo(irc, 0);
				irc[irc.Length-1] = li;
				wrp.Blocks = irc;
				cbitem.Items.Add(li);
				cbitem.SelectedIndex = cbitem.Items.Count-1;
			} 
			else 
			{
				li = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
			}

			return li;
		}

		private void ChangeZLevel(object sender, System.EventArgs e)
		{
			try 
			{
				LevelInfo li = this.SelectedLevelInfo();
				li.ZLevel = Convert.ToInt32(this.tbz.Text);
			} 
			catch (Exception ex)
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errconvert"), ex);
			}
		}

		protected Image GetAlpha(Image img)
		{
			Bitmap bm = new Bitmap(pb.Image.Size.Width, pb.Image.Size.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
					
			Bitmap src = (Bitmap)img;
			for (int y=0; y<bm.Size.Height; y++) 
			{
				for (int x=0; x<bm.Size.Width; x++) 
				{
					byte a = src.GetPixel(x, y).A;
					bm.SetPixel(x, y, Color.FromArgb(a, a, a)); 
				} // for x
			} //for y

			return bm;
		}

		protected Image ChangeAlpha(Image img, Image alpha)
		{
			Bitmap bm = new Bitmap(pb.Image.Size.Width, pb.Image.Size.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
					
			Bitmap src = (Bitmap)img;
			Bitmap asrc = (Bitmap)alpha;
			for (int y=0; y<bm.Size.Height; y++) 
			{
				for (int x=0; x<bm.Size.Width; x++) 
				{
					byte a = asrc.GetPixel(x, y).R;
					Color cl = src.GetPixel(x, y);
					bm.SetPixel(x, y, Color.FromArgb(a, cl)); 
				} // for x
			} //for y

			return bm;
		}

		protected Image CropImage(LevelInfo id, Image img)
		{
			double ratio = (double)id.TextureSize.Width / (double)id.TextureSize.Height;
			double newratio = (double)img.Width / (double)img.Height;

			if (ratio != newratio) 
			{
				if (MessageBox.Show("The File you want to import does not have the correct aspect Ration!\n\nDo you want SimPe to crop the Image?", "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes) 
				{
					int w = Convert.ToInt32(img.Height * ratio);
					int h = img.Height;
					if (w>img.Width) 
					{
						w = img.Width;
						h = Convert.ToInt32(img.Width / ratio);
					}

					Image img2 = new Bitmap(w, h);
					Graphics gr = Graphics.FromImage(img2);

					gr.DrawImageUnscaled(img, 0, 0);
					img = img2;
				} 
				else 
				{
					return null;
				}
						
			}

			return img;
		}

		private void ExportAlpha(object sender, System.EventArgs e)
		{
			if (pb.Image == null) return;

			sfd.FileName = this.tbflname.Text+"_alpha_"+pb.Image.Size.Width.ToString()+"x"+pb.Image.Size.Height.ToString()+".png";
			if (sfd.ShowDialog() == DialogResult.OK) 
			{
				try 
				{
					Image bm = GetAlpha(pb.Image);
					bm.Save(sfd.FileName);
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
				}
			}
		}

		private void ImportAlpha(object sender, System.EventArgs e)
		{
			
			if (ofd.ShowDialog() == DialogResult.OK) 
			{
				try 
				{
					LevelInfo id = (LevelInfo)cbitem.Items[cbitem.SelectedIndex];
					Image img = Image.FromFile(ofd.FileName);
					img = this.CropImage(id, img);
					if (img==null) return;

					id.Texture = this.ChangeAlpha(id.Texture, img);;
					pb.Image = id.Texture;
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("erropenfile"), ex);
				}
				
			}
		}

		private void BuildFilename(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string fl = Hashes.StripHashFromName(this.tbflname.Text);
			this.tbflname.Text = Hashes.AssembleHashedFileName(wrapper.Package.FileGroupHash, fl);
		}

		private void FixTGI(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			string fl = Hashes.StripHashFromName(this.tbflname.Text);
			wrapper.FileDescriptor.Instance = Hashes.InstanceHash(fl);
			wrapper.FileDescriptor.SubType = Hashes.SubTypeHash(fl);
		}

	}
}
