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
	/// Zusammenfassung für Hash.
	/// </summary>
	public class Hash : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbtext;
		private System.Windows.Forms.TextBox tbseed;
		private System.Windows.Forms.TextBox tbpoly;
		private System.Windows.Forms.TextBox tbhash;
		private System.Windows.Forms.RadioButton rb24;
		private System.Windows.Forms.RadioButton rb32;
		private System.Windows.Forms.RadioButton radioButton1;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Hash()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			tbseed.Text = "0x"+Helper.HexString(Hashes.CRC24Seed);
			tbpoly.Text = "0x"+Helper.HexString(Hashes.CRC24Poly);
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Hash));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbtext = new System.Windows.Forms.TextBox();
			this.tbseed = new System.Windows.Forms.TextBox();
			this.tbpoly = new System.Windows.Forms.TextBox();
			this.tbhash = new System.Windows.Forms.TextBox();
			this.rb24 = new System.Windows.Forms.RadioButton();
			this.rb32 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "String:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(56, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seed:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(60, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Poly:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 120);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 17);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hash Value:";
			// 
			// tbtext
			// 
			this.tbtext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbtext.Location = new System.Drawing.Point(104, 16);
			this.tbtext.Name = "tbtext";
			this.tbtext.Size = new System.Drawing.Size(372, 21);
			this.tbtext.TabIndex = 4;
			this.tbtext.Text = "";
			this.tbtext.TextChanged += new System.EventHandler(this.tbtext_TextChanged);
			// 
			// tbseed
			// 
			this.tbseed.Location = new System.Drawing.Point(104, 48);
			this.tbseed.Name = "tbseed";
			this.tbseed.Size = new System.Drawing.Size(88, 21);
			this.tbseed.TabIndex = 5;
			this.tbseed.Text = "0x00000000";
			this.tbseed.TextChanged += new System.EventHandler(this.tbtext_TextChanged);
			// 
			// tbpoly
			// 
			this.tbpoly.Location = new System.Drawing.Point(104, 72);
			this.tbpoly.Name = "tbpoly";
			this.tbpoly.Size = new System.Drawing.Size(88, 21);
			this.tbpoly.TabIndex = 6;
			this.tbpoly.Text = "0x00000000";
			this.tbpoly.TextChanged += new System.EventHandler(this.tbtext_TextChanged);
			// 
			// tbhash
			// 
			this.tbhash.Location = new System.Drawing.Point(104, 112);
			this.tbhash.Name = "tbhash";
			this.tbhash.ReadOnly = true;
			this.tbhash.Size = new System.Drawing.Size(368, 21);
			this.tbhash.TabIndex = 7;
			this.tbhash.Text = "0x00000000";
			// 
			// rb24
			// 
			this.rb24.Checked = true;
			this.rb24.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rb24.Location = new System.Drawing.Point(256, 40);
			this.rb24.Name = "rb24";
			this.rb24.Size = new System.Drawing.Size(72, 24);
			this.rb24.TabIndex = 8;
			this.rb24.TabStop = true;
			this.rb24.Text = "CRC 24";
			this.rb24.Click += new System.EventHandler(this.tbtext_TextChanged);
			this.rb24.CheckedChanged += new System.EventHandler(this.rb14_CheckedChanged);
			// 
			// rb32
			// 
			this.rb32.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.rb32.Location = new System.Drawing.Point(336, 40);
			this.rb32.Name = "rb32";
			this.rb32.Size = new System.Drawing.Size(72, 24);
			this.rb32.TabIndex = 9;
			this.rb32.Text = "CRC 32";
			this.rb32.Click += new System.EventHandler(this.tbtext_TextChanged);
			this.rb32.CheckedChanged += new System.EventHandler(this.rb32_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.radioButton1.Location = new System.Drawing.Point(416, 40);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(56, 24);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.Text = "GUID";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.guid_CheckedChanged);
			// 
			// Hash
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(494, 144);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.rb32);
			this.Controls.Add(this.rb24);
			this.Controls.Add(this.tbhash);
			this.Controls.Add(this.tbpoly);
			this.Controls.Add(this.tbseed);
			this.Controls.Add(this.tbtext);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Hash";
			this.Text = "Hash Generator";
			this.ResumeLayout(false);

		}
		#endregion

		public void Execute(Interfaces.Files.IPackageFile package) 
		{
			if (package!=null)
				this.tbtext.Text = System.IO.Path.GetFileNameWithoutExtension(package.FileName).ToLower();

			this.Show();
		}

		private void tbtext_TextChanged(object sender, System.EventArgs e)
		{
			try 
			{
				uint seed = Convert.ToUInt32(tbseed.Text, 16);
				uint poly = Convert.ToUInt32(tbpoly.Text, 16); 

				//long hash = Hashes.CRC24(seed, poly, tbtext.Text.ToCharArray());

				ulong hash = 0;
				if (rb24.Checked) hash = Hashes.ToLong(Hashes.Crc24.ComputeHash(Helper.ToBytes(tbtext.Text.ToLower())));
				else hash = Hashes.ToLong(Hashes.Crc32.ComputeHash(Helper.ToBytes(tbtext.Text.ToLower())));
				tbhash.Text = "0x"+Helper.HexString((uint)hash);
			} 
			catch (Exception) 
			{
			}
		}

		private void rb32_CheckedChanged(object sender, System.EventArgs e)
		{
			tbseed.Text = "0xffffffff";
			tbpoly.Text = "0x04C11DB7";

			tbseed.Enabled = true;
			tbpoly.Enabled = tbseed.Enabled;
			tbtext.Enabled = tbseed.Enabled;
		}

		private void guid_CheckedChanged(object sender, System.EventArgs e)
		{
			tbseed.Enabled = false;
			tbpoly.Enabled = tbseed.Enabled;
			tbtext.Enabled = tbseed.Enabled;

			tbhash.Text = System.Guid.NewGuid().ToString();
		}

		private void rb14_CheckedChanged(object sender, System.EventArgs e)
		{
			tbseed.Text = "0x00B704CE";
			tbpoly.Text = "0x01864CFB";

			tbseed.Enabled = true;
			tbpoly.Enabled = tbseed.Enabled;
			tbtext.Enabled = tbseed.Enabled;
		}
	}
}
