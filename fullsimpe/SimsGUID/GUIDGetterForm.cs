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
using System.Security.Cryptography;

namespace Sims.GUID
{
	/// <summary>
	/// Zusammenfassung für GUIDGetterForm.
	/// </summary>
	public class GUIDGetterForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		public System.Windows.Forms.TextBox tbusername;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.TextBox tbpassword;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbUserGUID;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.ListBox lbnames;
		private System.Windows.Forms.LinkLabel lluse;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button button2;
		public System.Windows.Forms.TextBox tbobject;
		private System.Windows.Forms.Label label3;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public GUIDGetterForm()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(GUIDGetterForm));
			this.label1 = new System.Windows.Forms.Label();
			this.tbusername = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.tbUserGUID = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tbpassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.lbnames = new System.Windows.Forms.ListBox();
			this.lluse = new System.Windows.Forms.LinkLabel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.button2 = new System.Windows.Forms.Button();
			this.tbobject = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username:";
			// 
			// tbusername
			// 
			this.tbusername.Location = new System.Drawing.Point(88, 24);
			this.tbusername.MaxLength = 200;
			this.tbusername.Name = "tbusername";
			this.tbusername.Size = new System.Drawing.Size(264, 21);
			this.tbusername.TabIndex = 1;
			this.tbusername.Text = "";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.linkLabel1);
			this.groupBox1.Controls.Add(this.tbUserGUID);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.tbpassword);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbusername);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 120);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User Data";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(5, 4);
			this.linkLabel1.Location = new System.Drawing.Point(16, 88);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(76, 17);
			this.linkLabel1.TabIndex = 7;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "User GUID:";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateGUID);
			// 
			// tbUserGUID
			// 
			this.tbUserGUID.Enabled = false;
			this.tbUserGUID.Location = new System.Drawing.Point(96, 88);
			this.tbUserGUID.MaxLength = 200;
			this.tbUserGUID.Name = "tbUserGUID";
			this.tbUserGUID.Size = new System.Drawing.Size(96, 21);
			this.tbUserGUID.TabIndex = 6;
			this.tbUserGUID.Text = "";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(224, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 4;
			this.button1.Text = "Register new User";
			this.button1.Click += new System.EventHandler(this.RegisterNewUser);
			// 
			// tbpassword
			// 
			this.tbpassword.Location = new System.Drawing.Point(88, 48);
			this.tbpassword.MaxLength = 200;
			this.tbpassword.Name = "tbpassword";
			this.tbpassword.PasswordChar = '*';
			this.tbpassword.Size = new System.Drawing.Size(264, 21);
			this.tbpassword.TabIndex = 3;
			this.tbpassword.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(16, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password:";
			// 
			// lbnames
			// 
			this.lbnames.Location = new System.Drawing.Point(8, 8);
			this.lbnames.Name = "lbnames";
			this.lbnames.Size = new System.Drawing.Size(304, 134);
			this.lbnames.TabIndex = 3;
			this.lbnames.SelectedIndexChanged += new System.EventHandler(this.SelectedObject);
			// 
			// lluse
			// 
			this.lluse.AutoSize = true;
			this.lluse.Enabled = false;
			this.lluse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lluse.Location = new System.Drawing.Point(320, 128);
			this.lluse.Name = "lluse";
			this.lluse.Size = new System.Drawing.Size(26, 17);
			this.lluse.TabIndex = 4;
			this.lluse.TabStop = true;
			this.lluse.Text = "use";
			this.lluse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UseSelection);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(8, 136);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(360, 176);
			this.tabControl1.TabIndex = 5;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.lbnames);
			this.tabPage1.Controls.Add(this.lluse);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(352, 150);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Existing Objects";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.button2);
			this.tabPage2.Controls.Add(this.tbobject);
			this.tabPage2.Controls.Add(this.label3);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(352, 150);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "New Object";
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2.Location = new System.Drawing.Point(216, 56);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "Register Object";
			this.button2.Click += new System.EventHandler(this.RegisterObject);
			// 
			// tbobject
			// 
			this.tbobject.Location = new System.Drawing.Point(24, 32);
			this.tbobject.MaxLength = 200;
			this.tbobject.Name = "tbobject";
			this.tbobject.Size = new System.Drawing.Size(320, 21);
			this.tbobject.TabIndex = 9;
			this.tbobject.Text = "";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(8, 16);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(91, 17);
			this.label3.TabIndex = 8;
			this.label3.Text = "Object Name:";
			// 
			// GUIDGetterForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(378, 320);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "GUIDGetterForm";
			this.Text = "Register Object GUID";
			this.Load += new System.EventHandler(this.GUIDGetterForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		Sims.GUID.Service.SimGUIDService service;
		uint retguid = 0;
		public static uint BuildGUID(uint userguid, uint objguid)
		{
			return (uint)(((userguid<<8)&0xffffff00) + (objguid&0x000000ff));
		}

		public uint GetNewGUID(string user, string password) 
		{
			lluse.Enabled = false;

			service = new Sims.GUID.Service.SimGUIDService();
			this.tbusername.Text = user;
			this.tbpassword.Text = password;			
						
			this.ShowDialog();

			return retguid;
		}

		private void UpdateGUID(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			
			uint userguid = 0xf000000;
			if (tbusername.Text!="") userguid = (uint)service.loginUser(tbusername.Text, tbpassword.Text);

			this.lbnames.Items.Clear();
			if (userguid!=0xf000000) 
			{
				this.tbUserGUID.Text = "0x"+userguid.ToString("X");

				string res = service.listRegistredObjects(tbusername.Text, tbpassword.Text);
				System.Collections.Hashtable ht = Ambertation.Soap.PhpSerialized.GetHashtableFromSerializedArray(res);
				

				foreach (Int32 guid in ht.Values) 
				{
					res = service.describeRegistredObjects(tbusername.Text, tbpassword.Text, guid);
					System.Collections.Hashtable data = Ambertation.Soap.PhpSerialized.GetHashtableFromSerializedArray(res);
					uint objguid = Convert.ToUInt32(data["guid"]);
					objguid = BuildGUID(userguid, objguid);
					this.lbnames.Items.Add(new ObjectListItem(objguid, data["name"].ToString()));
					Application.DoEvents();
				}
			}
			else this.tbUserGUID.Text = "0x0";


		}

		private void RegisterNewUser(object sender, System.EventArgs e)
		{
			bool res = this.service.registerUser(tbusername.Text, tbpassword.Text);
			if (!res) System.Windows.Forms.MessageBox.Show("Could not Register the specified User!\n\nPlease try another Username.");
			else MessageBox.Show("Welcome "+tbusername.Text+".");

			UpdateGUID(null, null);
		}

		private void UseSelection(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.lbnames.SelectedIndex <0) return;
			ObjectListItem obj = (ObjectListItem)lbnames.Items[lbnames.SelectedIndex];
			retguid = obj.GUID;
			Close();
		}

		private void SelectedObject(object sender, System.EventArgs e)
		{
			lluse.Enabled = false;
			if (this.lbnames.SelectedIndex <0) return;
			lluse.Enabled = true;
		}

		private void RegisterObject(object sender, System.EventArgs e)
		{
			uint userguid = 0xf000000;
			if (tbusername.Text!="") userguid = (uint)service.loginUser(tbusername.Text, tbpassword.Text);

			
			if (userguid==0xf000000) 
			{
				MessageBox.Show("Your Login Data was not accepted by the GUID Database!");
				return;
			}
			uint res = (uint)this.service.registerObject(tbusername.Text, tbpassword.Text, this.tbobject.Text, false);
			if (res == 0xf00) 
			{
				MessageBox.Show("Failed to register a new Object.\n\nMaybe you have already Regsitred 256 Objects for this User?");
				return;
			}

			this.retguid = BuildGUID(userguid, res);
			Close();
		}

		private void GUIDGetterForm_Load(object sender, System.EventArgs e)
		{
			this.BeginInvoke(new LinkLabelLinkClickedEventHandler(UpdateGUID), new object[2]);
		}
	}
}
