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

namespace SimPe
{
	/// <summary>
	/// Zusammenfassung für AddExtTool.
	/// </summary>
	public class AddExtTool : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.TextBox tbfile;
		private System.Windows.Forms.TextBox tbattr;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.TextBox tbtype;
		private System.Windows.Forms.ComboBox cbtypes;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AddExtTool()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			foreach (SimPe.Data.TypeAlias a in SimPe.Helper.TGILoader.FileTypes) 
			{
				if (a.Id==0xffffffff) 
				{
					SimPe.Data.TypeAlias an = new SimPe.Data.TypeAlias(false, "ALL", 0xffffffff, "---  All Types ---", true);
					cbtypes.Items.Add(an);
				} else  cbtypes.Items.Add(a);
			}
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tbname = new System.Windows.Forms.TextBox();
			this.tbfile = new System.Windows.Forms.TextBox();
			this.tbattr = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.cbtypes = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(61, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(67, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Type:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "FileName:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(24, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(82, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Parameters:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(472, 112);
			this.button1.Name = "button1";
			this.button1.TabIndex = 4;
			this.button1.Text = "OK";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Location = new System.Drawing.Point(112, 8);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(432, 21);
			this.tbname.TabIndex = 5;
			this.tbname.Text = "";
			// 
			// tbfile
			// 
			this.tbfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbfile.Location = new System.Drawing.Point(112, 56);
			this.tbfile.Name = "tbfile";
			this.tbfile.Size = new System.Drawing.Size(352, 21);
			this.tbfile.TabIndex = 6;
			this.tbfile.Text = "";
			// 
			// tbattr
			// 
			this.tbattr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbattr.Location = new System.Drawing.Point(112, 80);
			this.tbattr.Name = "tbattr";
			this.tbattr.Size = new System.Drawing.Size(432, 21);
			this.tbattr.TabIndex = 7;
			this.tbattr.Text = "";
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(472, 56);
			this.button2.Name = "button2";
			this.button2.TabIndex = 8;
			this.button2.Text = "Browse...";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// ofd
			// 
			this.ofd.Filter = "Application (*.exe;*.bat;*.com;*.cmd)|*.exe;*.bat;*.com;*.cmd|All Files (*.*)|*.*" +
				"";
			// 
			// tbtype
			// 
			this.tbtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.tbtype.Location = new System.Drawing.Point(112, 32);
			this.tbtype.Name = "tbtype";
			this.tbtype.TabIndex = 17;
			this.tbtype.Text = "";
			this.tbtype.TextChanged += new System.EventHandler(this.SelectTypeByNameClick);
			// 
			// cbtypes
			// 
			this.cbtypes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.cbtypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.cbtypes.ItemHeight = 13;
			this.cbtypes.Location = new System.Drawing.Point(216, 32);
			this.cbtypes.Name = "cbtypes";
			this.cbtypes.Size = new System.Drawing.Size(248, 21);
			this.cbtypes.TabIndex = 18;
			this.cbtypes.SelectedIndexChanged += new System.EventHandler(this.TypeSelectClick);
			// 
			// AddExtTool
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(554, 142);
			this.Controls.Add(this.tbtype);
			this.Controls.Add(this.cbtypes);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.tbattr);
			this.Controls.Add(this.tbfile);
			this.Controls.Add(this.tbname);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddExtTool";
			this.ShowInTaskbar = false;
			this.Text = "Add External Tool";
			this.ResumeLayout(false);

		}
		#endregion

		ToolLoaderItem tli;
		public ToolLoaderItem Execute() 
		{
			tli = null;

			this.tbname.Text = Localization.Manager.GetString("Unknown");
			this.tbtype.Text = "0xffffffff";
			this.tbattr.Text = "{tempfile}";
			this.tbfile.Text = "";
			
			ShowDialog();
			return tli;
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			ofd.FileName = tbfile.Text;
			if (ofd.ShowDialog()==DialogResult.OK) tbfile.Text = ofd.FileName;
		}

		private void TypeSelectClick(object sender, System.EventArgs e)
		{
			if (cbtypes.Tag != null) return;
			tbtype.Text = "0x"+Helper.HexString(((SimPe.Data.TypeAlias)cbtypes.Items[cbtypes.SelectedIndex]).Id);
		}

		private void SelectTypeByNameClick(object sender, System.EventArgs e)
		{
			cbtypes.Tag = true;
			Data.TypeAlias a = Data.MetaData.FindTypeAlias(Helper.HexStringToUInt(tbtype.Text));

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

		private void button1_Click(object sender, System.EventArgs e)
		{
			tli = new ToolLoaderItem(tbname.Text);
			tli.Attributes = tbattr.Text;
			tli.FileName = tbfile.Text;
			try 
			{
				tli.Type = Convert.ToUInt32(tbtype.Text);
			}
			catch (Exception) 
			{
				tli.Type = 0xffffffff;
			}

			Close();
		}
	}
}
