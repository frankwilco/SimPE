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
using System.Diagnostics;

namespace SimPe.Plugin
{
	/// <summary>
	/// Zusammenfassung für DDSTool.
	/// </summary>
	public class DDSTool : System.Windows.Forms.Form
	{
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox cbfilter;
		private System.Windows.Forms.TextBox tblevel;
		private System.Windows.Forms.TextBox tbwidth;
		private System.Windows.Forms.TextBox tbheight;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbformat;
		private System.Windows.Forms.ComboBox cbsharpen;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public DDSTool()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			cbformat.Items.Clear();
			cbformat.Items.Add(ImageLoader.TxtrFormats.DXT1Format);
			cbformat.Items.Add(ImageLoader.TxtrFormats.DXT3Format);
			cbformat.Items.Add(ImageLoader.TxtrFormats.DXT5Format);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(DDSTool));
			this.pb = new System.Windows.Forms.PictureBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cbsharpen = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.cbfilter = new System.Windows.Forms.CheckedListBox();
			this.tblevel = new System.Windows.Forms.TextBox();
			this.tbwidth = new System.Windows.Forms.TextBox();
			this.tbheight = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbformat = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pb
			// 
			this.pb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pb.Location = new System.Drawing.Point(16, 24);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(128, 120);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb.TabIndex = 0;
			this.pb.TabStop = false;
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 4);
			this.linkLabel1.Location = new System.Drawing.Point(48, 152);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(93, 17);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "open Image...";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// ofd
			// 
			this.ofd.Filter = "Alle Image Files (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png|Bitmap (*.bmp)" +
				"|*.bmp|Gif (*.gif)|*.gif|JPEG File (*.jpg)|*.jpg|Png (*.png)|*.png|All Files (*." +
				"*)|*.*";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbformat);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.tbheight);
			this.groupBox1.Controls.Add(this.tbwidth);
			this.groupBox1.Controls.Add(this.tblevel);
			this.groupBox1.Controls.Add(this.cbfilter);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.cbsharpen);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(160, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(312, 208);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(397, 224);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Build";
			this.button1.Click += new System.EventHandler(this.Build);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(28, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Levels:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(40, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Size:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(23, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Format:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 96);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sharpen:";
			// 
			// cbsharpen
			// 
			this.cbsharpen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsharpen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbsharpen.Items.AddRange(new object[] {
														   "None",
														   "Negative",
														   "Lighter",
														   "Darker",
														   "ContrastMore",
														   "ContrastLess",
														   "Smoothen",
														   "SharpenSoft",
														   "SharpenMedium",
														   "SharpenStrong",
														   "FindEdges",
														   "Contour",
														   "EdgeDetect",
														   "EdgeDetectSoft",
														   "Emboss",
														   "MeanRemoval"});
			this.cbsharpen.Location = new System.Drawing.Point(80, 88);
			this.cbsharpen.Name = "cbsharpen";
			this.cbsharpen.Size = new System.Drawing.Size(224, 21);
			this.cbsharpen.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(35, 120);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Filter:";
			// 
			// cbfilter
			// 
			this.cbfilter.CheckOnClick = true;
			this.cbfilter.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbfilter.IntegralHeight = false;
			this.cbfilter.Items.AddRange(new object[] {
														  "dither",
														  "Point",
														  "Box",
														  "Triangle",
														  "Quadratic",
														  "Cubic",
														  "Catrom",
														  "Mitchell",
														  "Gaussian",
														  "Sinc",
														  "Bessel",
														  "Hanning",
														  "Hamming",
														  "Blackman",
														  "Kaiser"});
			this.cbfilter.Location = new System.Drawing.Point(80, 120);
			this.cbfilter.Name = "cbfilter";
			this.cbfilter.Size = new System.Drawing.Size(224, 80);
			this.cbfilter.TabIndex = 7;
			// 
			// tblevel
			// 
			this.tblevel.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tblevel.Location = new System.Drawing.Point(80, 16);
			this.tblevel.Name = "tblevel";
			this.tblevel.Size = new System.Drawing.Size(80, 21);
			this.tblevel.TabIndex = 8;
			this.tblevel.Text = "0";
			// 
			// tbwidth
			// 
			this.tbwidth.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbwidth.Location = new System.Drawing.Point(80, 40);
			this.tbwidth.Name = "tbwidth";
			this.tbwidth.ReadOnly = true;
			this.tbwidth.Size = new System.Drawing.Size(48, 21);
			this.tbwidth.TabIndex = 9;
			this.tbwidth.Text = "0";
			// 
			// tbheight
			// 
			this.tbheight.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbheight.Location = new System.Drawing.Point(152, 40);
			this.tbheight.Name = "tbheight";
			this.tbheight.ReadOnly = true;
			this.tbheight.Size = new System.Drawing.Size(48, 21);
			this.tbheight.TabIndex = 10;
			this.tbheight.Text = "0";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(136, 48);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(11, 17);
			this.label6.TabIndex = 11;
			this.label6.Text = "x";
			// 
			// cbformat
			// 
			this.cbformat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbformat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbformat.Items.AddRange(new object[] {
														  "None",
														  "Negative",
														  "Lighter",
														  "Darker",
														  "ContrastMore",
														  "ContrastLess",
														  "Smoothen",
														  "SharpenSoft",
														  "SharpenMedium",
														  "SharpenStrong",
														  "FindEdges",
														  "Contour",
														  "EdgeDetect",
														  "EdgeDetectSoft",
														  "Emboss",
														  "MeanRemoval"});
			this.cbformat.Location = new System.Drawing.Point(80, 64);
			this.cbformat.Name = "cbformat";
			this.cbformat.Size = new System.Drawing.Size(224, 21);
			this.cbformat.TabIndex = 12;
			// 
			// DDSTool
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(480, 254);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.pb);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DDSTool";
			this.Text = "DDS Builder";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		Image img;
		string imgname;
		DDSData[] dds;
		public DDSData[] Execute(int level, Size size, ImageLoader.TxtrFormats format) 
		{
			pb.Image = null;
			img = null;
			dds = null;

			this.cbsharpen.SelectedIndex = 6;
			this.tblevel.Text = level.ToString();
			this.tbwidth.Text = size.Width.ToString();
			this.tbheight.Text = size.Height.ToString();

			cbformat.SelectedIndex = 2;
			for(int i=0; i<cbformat.Items.Count; i++)  
			{
				ImageLoader.TxtrFormats fr = (ImageLoader.TxtrFormats)cbformat.Items[i];
				if (fr==format) 
				{
					cbformat.SelectedIndex=i;
					break;
				}
			}

			this.button1.Enabled = false;
			ShowDialog();

			return dds;
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (ofd.ShowDialog() == DialogResult.OK) 
			{
				img = Image.FromFile(ofd.FileName);
				imgname = ofd.FileName;
				pb.Image = ImageLoader.Preview(img, pb.Size);

				tbwidth.Text = img.Width.ToString();
				tbheight.Text = img.Height.ToString();
				this.button1.Enabled = (img!=null);
			}
		}

		public static DDSData[] BuildDDS(Image img, int levels, ImageLoader.TxtrFormats format, string parameters) 
		{
			string imgname = System.IO.Path.GetTempFileName()+".png";
			img.Save(imgname, System.Drawing.Imaging.ImageFormat.Png);

			try 
			{
				return BuildDDS(imgname, levels, format, parameters);
			}
			finally 
			{
				if (System.IO.File.Exists(imgname)) System.IO.File.Delete(imgname);
			}
		}

		public static DDSData[] BuildDDS(string imgname, int levels, ImageLoader.TxtrFormats format, string parameters) 
		{
			
			string ddsfile = System.IO.Path.GetTempFileName()+".dds";

			
			//img.Save(imgname);

			string arg = "-file \""+imgname+"\" ";
			arg += "-output \""+ddsfile+"\" ";

			if (format == ImageLoader.TxtrFormats.DXT1Format) arg += " -dxt1c";
			else if (format == ImageLoader.TxtrFormats.DXT5Format) arg += "-dxt5";
			else arg += "-dxt3";

			arg += " -nmips "+levels.ToString();
			arg += " "+parameters;

			string flname = Helper.WindowsRegistry.NvidiaDDSTool;

			if (!System.IO.File.Exists(flname)) return new DDSData[0];

			try 
			{
				Process p = new Process();
				p.StartInfo.FileName = flname;
				p.StartInfo.Arguments = arg;

				p.Start();

				p.WaitForExit();
				p.Close();

				DDSData[] ret = ImageLoader.ParesDDS(ddsfile);
				if (System.IO.File.Exists(ddsfile)) System.IO.File.Delete(ddsfile);
				return ret;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			} 
			finally 
			{
				if (System.IO.File.Exists(ddsfile)) System.IO.File.Delete(ddsfile);
			}
		
			

			return new DDSData[0];
		}

		public static void AddDDsData(ImageData id, DDSData[] data) 
		{
			id.TextureSize = data[0].ParentSize;
			id.Format = data[0].Format;
			id.MipMapLevels = (uint)data.Length;

			id.MipMapBlocks[0].AddDDSData(data);			
		}

		private void Build(object sender, System.EventArgs e)
		{
			string arg = "-sharpenMethod "+cbsharpen.Text+" ";
			foreach (string name in cbfilter.CheckedItems) 
			{
				arg +="-"+name+" ";
			}

			try 
			{
				dds = BuildDDS(img, Convert.ToInt32(tblevel.Text), (ImageLoader.TxtrFormats)cbformat.Items[cbformat.SelectedIndex], arg);
				Close();
			} catch (Exception) {}

		}
	}
}
