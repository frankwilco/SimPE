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
	/// Zusammenfassung für LtxtForm.
	/// </summary>
	public class LtxtForm : System.Windows.Forms.Form
	{
		internal System.Windows.Forms.Panel ltxtPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		internal System.Windows.Forms.TextBox tblotname;
		internal System.Windows.Forms.TextBox tbhousename;
		internal System.Windows.Forms.TextBox tbname;
		internal System.Windows.Forms.TextBox tblotinst;
		internal System.Windows.Forms.ComboBox cbtype;
		internal System.Windows.Forms.TextBox tbhouseinst;
		internal System.Windows.Forms.TextBox tbtype;
		internal System.Windows.Forms.TextBox tbver;
		private System.Windows.Forms.Label label10;
		internal System.Windows.Forms.TextBox tbunk1;
		private System.Windows.Forms.Label label11;
		internal System.Windows.Forms.TextBox tbhg;
		internal System.Windows.Forms.TextBox tbwd;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		internal System.Windows.Forms.TextBox tbtop;
		internal System.Windows.Forms.TextBox tbleft;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		internal Ambertation.Windows.Forms.EnumComboBox cborient;
		internal System.Windows.Forms.TextBox tbinst;
		private System.Windows.Forms.Label label15;
		internal System.Windows.Forms.TextBox tbowner;
		private System.Windows.Forms.Label label17;
		internal System.Windows.Forms.TextBox tbu4;
		private System.Windows.Forms.Label label18;
		internal System.Windows.Forms.ListBox lb;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		internal System.Windows.Forms.TextBox tbz;
		internal System.Windows.Forms.TextBox tbData;
		internal System.Windows.Forms.TextBox tbu0;
		private System.Windows.Forms.Label label21;
		internal System.Windows.Forms.PictureBox pb;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public LtxtForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			wrapper = null;
			this.cborient.Enum = typeof(Plugin.LotOrientation);
			this.cborient.ResourceManager = SimPe.Localization.Manager;
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
			this.ltxtPanel = new System.Windows.Forms.Panel();
			this.tbu0 = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.tbData = new System.Windows.Forms.TextBox();
			this.tbz = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.lb = new System.Windows.Forms.ListBox();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.tbu4 = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.tbowner = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.tbinst = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cborient = new Ambertation.Windows.Forms.EnumComboBox();
			this.label14 = new System.Windows.Forms.Label();
			this.tbtop = new System.Windows.Forms.TextBox();
			this.tbleft = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.tbhg = new System.Windows.Forms.TextBox();
			this.tbwd = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tbunk1 = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.tbver = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.tbhouseinst = new System.Windows.Forms.TextBox();
			this.tblotinst = new System.Windows.Forms.TextBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.tbhousename = new System.Windows.Forms.TextBox();
			this.tblotname = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label27 = new System.Windows.Forms.Label();
			this.pb = new System.Windows.Forms.PictureBox();
			this.ltxtPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// ltxtPanel
			// 
			this.ltxtPanel.AutoScroll = true;
			this.ltxtPanel.Controls.Add(this.tbu0);
			this.ltxtPanel.Controls.Add(this.label21);
			this.ltxtPanel.Controls.Add(this.tbData);
			this.ltxtPanel.Controls.Add(this.tbz);
			this.ltxtPanel.Controls.Add(this.label20);
			this.ltxtPanel.Controls.Add(this.label19);
			this.ltxtPanel.Controls.Add(this.lb);
			this.ltxtPanel.Controls.Add(this.cbtype);
			this.ltxtPanel.Controls.Add(this.tbu4);
			this.ltxtPanel.Controls.Add(this.label18);
			this.ltxtPanel.Controls.Add(this.tbowner);
			this.ltxtPanel.Controls.Add(this.label17);
			this.ltxtPanel.Controls.Add(this.tbinst);
			this.ltxtPanel.Controls.Add(this.label15);
			this.ltxtPanel.Controls.Add(this.cborient);
			this.ltxtPanel.Controls.Add(this.label14);
			this.ltxtPanel.Controls.Add(this.tbtop);
			this.ltxtPanel.Controls.Add(this.tbleft);
			this.ltxtPanel.Controls.Add(this.label12);
			this.ltxtPanel.Controls.Add(this.label13);
			this.ltxtPanel.Controls.Add(this.tbhg);
			this.ltxtPanel.Controls.Add(this.tbwd);
			this.ltxtPanel.Controls.Add(this.label9);
			this.ltxtPanel.Controls.Add(this.label8);
			this.ltxtPanel.Controls.Add(this.tbunk1);
			this.ltxtPanel.Controls.Add(this.label11);
			this.ltxtPanel.Controls.Add(this.tbver);
			this.ltxtPanel.Controls.Add(this.label10);
			this.ltxtPanel.Controls.Add(this.tbtype);
			this.ltxtPanel.Controls.Add(this.tbhouseinst);
			this.ltxtPanel.Controls.Add(this.tblotinst);
			this.ltxtPanel.Controls.Add(this.tbname);
			this.ltxtPanel.Controls.Add(this.tbhousename);
			this.ltxtPanel.Controls.Add(this.tblotname);
			this.ltxtPanel.Controls.Add(this.label7);
			this.ltxtPanel.Controls.Add(this.label6);
			this.ltxtPanel.Controls.Add(this.label5);
			this.ltxtPanel.Controls.Add(this.label4);
			this.ltxtPanel.Controls.Add(this.label3);
			this.ltxtPanel.Controls.Add(this.label2);
			this.ltxtPanel.Controls.Add(this.label1);
			this.ltxtPanel.Controls.Add(this.button1);
			this.ltxtPanel.Controls.Add(this.panel2);
			this.ltxtPanel.Controls.Add(this.pb);
			this.ltxtPanel.Location = new System.Drawing.Point(16, 8);
			this.ltxtPanel.Name = "ltxtPanel";
			this.ltxtPanel.Size = new System.Drawing.Size(848, 296);
			this.ltxtPanel.TabIndex = 20;
			// 
			// tbu0
			// 
			this.tbu0.Location = new System.Drawing.Point(568, 32);
			this.tbu0.Name = "tbu0";
			this.tbu0.Size = new System.Drawing.Size(104, 21);
			this.tbu0.TabIndex = 51;
			this.tbu0.Text = "0x00000000";
			this.tbu0.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label21.Location = new System.Drawing.Point(536, 40);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(26, 17);
			this.label21.TabIndex = 50;
			this.label21.Text = "U0:";
			// 
			// tbData
			// 
			this.tbData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbData.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbData.Location = new System.Drawing.Point(368, 184);
			this.tbData.Name = "tbData";
			this.tbData.Size = new System.Drawing.Size(464, 22);
			this.tbData.TabIndex = 49;
			this.tbData.Text = "";
			this.tbData.TextChanged += new System.EventHandler(this.ChangeData);
			// 
			// tbz
			// 
			this.tbz.Location = new System.Drawing.Point(256, 136);
			this.tbz.Name = "tbz";
			this.tbz.Size = new System.Drawing.Size(64, 21);
			this.tbz.TabIndex = 48;
			this.tbz.Text = "0x0000";
			this.tbz.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label20.Location = new System.Drawing.Point(232, 144);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(17, 17);
			this.label20.TabIndex = 47;
			this.label20.Text = "Z:";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label19.Location = new System.Drawing.Point(360, 168);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(102, 17);
			this.label19.TabIndex = 46;
			this.label19.Text = "Unknown Data:";
			// 
			// lb
			// 
			this.lb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.lb.ColumnWidth = 100;
			this.lb.Location = new System.Drawing.Point(368, 80);
			this.lb.MultiColumn = true;
			this.lb.Name = "lb";
			this.lb.Size = new System.Drawing.Size(464, 82);
			this.lb.TabIndex = 45;
			// 
			// cbtype
			// 
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Location = new System.Drawing.Point(192, 80);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(112, 21);
			this.cbtype.TabIndex = 17;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.SelectType);
			// 
			// tbu4
			// 
			this.tbu4.Location = new System.Drawing.Point(480, 32);
			this.tbu4.Name = "tbu4";
			this.tbu4.Size = new System.Drawing.Size(48, 21);
			this.tbu4.TabIndex = 44;
			this.tbu4.Text = "0x00";
			this.tbu4.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label18.Location = new System.Drawing.Point(448, 40);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(26, 17);
			this.label18.TabIndex = 43;
			this.label18.Text = "U4:";
			this.label18.Click += new System.EventHandler(this.label18_Click);
			// 
			// tbowner
			// 
			this.tbowner.Location = new System.Drawing.Point(192, 104);
			this.tbowner.Name = "tbowner";
			this.tbowner.Size = new System.Drawing.Size(96, 21);
			this.tbowner.TabIndex = 42;
			this.tbowner.Text = "0x00000000";
			this.tbowner.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label17.Location = new System.Drawing.Point(136, 112);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(51, 17);
			this.label17.TabIndex = 41;
			this.label17.Text = "Owner:";
			// 
			// tbinst
			// 
			this.tbinst.Location = new System.Drawing.Point(192, 56);
			this.tbinst.Name = "tbinst";
			this.tbinst.Size = new System.Drawing.Size(96, 21);
			this.tbinst.TabIndex = 38;
			this.tbinst.Text = "0x00000000";
			this.tbinst.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label15.Location = new System.Drawing.Point(120, 64);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(65, 17);
			this.label15.TabIndex = 37;
			this.label15.Text = "Instance:";
			// 
			// cborient
			// 
			this.cborient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cborient.Enum = null;
			this.cborient.Location = new System.Drawing.Point(104, 184);
			this.cborient.Name = "cborient";
			this.cborient.ResourceManager = null;
			this.cborient.Size = new System.Drawing.Size(120, 21);
			this.cborient.TabIndex = 36;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label14.Location = new System.Drawing.Point(16, 192);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(81, 17);
			this.label14.TabIndex = 35;
			this.label14.Text = "Orientation:";
			// 
			// tbtop
			// 
			this.tbtop.Location = new System.Drawing.Point(176, 160);
			this.tbtop.Name = "tbtop";
			this.tbtop.Size = new System.Drawing.Size(48, 21);
			this.tbtop.TabIndex = 34;
			this.tbtop.Text = "0x00";
			this.tbtop.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbleft
			// 
			this.tbleft.Location = new System.Drawing.Point(176, 136);
			this.tbleft.Name = "tbleft";
			this.tbleft.Size = new System.Drawing.Size(48, 21);
			this.tbleft.TabIndex = 33;
			this.tbleft.Text = "0x00";
			this.tbleft.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label12.Location = new System.Drawing.Point(136, 168);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(32, 17);
			this.label12.TabIndex = 32;
			this.label12.Text = "Top:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.Location = new System.Drawing.Point(136, 144);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(33, 17);
			this.label13.TabIndex = 31;
			this.label13.Text = "Left:";
			// 
			// tbhg
			// 
			this.tbhg.Location = new System.Drawing.Point(72, 160);
			this.tbhg.Name = "tbhg";
			this.tbhg.Size = new System.Drawing.Size(48, 21);
			this.tbhg.TabIndex = 30;
			this.tbhg.Text = "0x00";
			this.tbhg.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbwd
			// 
			this.tbwd.Location = new System.Drawing.Point(72, 136);
			this.tbwd.Name = "tbwd";
			this.tbwd.Size = new System.Drawing.Size(48, 21);
			this.tbwd.TabIndex = 29;
			this.tbwd.Text = "0x00";
			this.tbwd.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label9.Location = new System.Drawing.Point(16, 168);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(51, 17);
			this.label9.TabIndex = 28;
			this.label9.Text = "Height:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.Location = new System.Drawing.Point(16, 144);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(47, 17);
			this.label8.TabIndex = 27;
			this.label8.Text = "Width:";
			// 
			// tbunk1
			// 
			this.tbunk1.Location = new System.Drawing.Point(392, 32);
			this.tbunk1.Name = "tbunk1";
			this.tbunk1.Size = new System.Drawing.Size(48, 21);
			this.tbunk1.TabIndex = 26;
			this.tbunk1.Text = "0x00";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label11.Location = new System.Drawing.Point(360, 40);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(26, 17);
			this.label11.TabIndex = 25;
			this.label11.Text = "U1:";
			// 
			// tbver
			// 
			this.tbver.Location = new System.Drawing.Point(192, 32);
			this.tbver.Name = "tbver";
			this.tbver.ReadOnly = true;
			this.tbver.Size = new System.Drawing.Size(96, 21);
			this.tbver.TabIndex = 24;
			this.tbver.Text = "0x00";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.Location = new System.Drawing.Point(128, 40);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 17);
			this.label10.TabIndex = 23;
			this.label10.Text = "Version:";
			// 
			// tbtype
			// 
			this.tbtype.Location = new System.Drawing.Point(304, 80);
			this.tbtype.Name = "tbtype";
			this.tbtype.ReadOnly = true;
			this.tbtype.Size = new System.Drawing.Size(48, 21);
			this.tbtype.TabIndex = 18;
			this.tbtype.Text = "0x00";
			// 
			// tbhouseinst
			// 
			this.tbhouseinst.Location = new System.Drawing.Point(720, 56);
			this.tbhouseinst.Name = "tbhouseinst";
			this.tbhouseinst.Size = new System.Drawing.Size(48, 21);
			this.tbhouseinst.TabIndex = 16;
			this.tbhouseinst.Text = "0x00";
			this.tbhouseinst.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tblotinst
			// 
			this.tblotinst.Location = new System.Drawing.Point(720, 32);
			this.tblotinst.Name = "tblotinst";
			this.tblotinst.Size = new System.Drawing.Size(48, 21);
			this.tblotinst.TabIndex = 15;
			this.tblotinst.Text = "0x00";
			this.tblotinst.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Location = new System.Drawing.Point(160, 264);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(344, 21);
			this.tbname.TabIndex = 13;
			this.tbname.Text = "";
			this.tbname.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tbhousename
			// 
			this.tbhousename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbhousename.Location = new System.Drawing.Point(160, 240);
			this.tbhousename.Name = "tbhousename";
			this.tbhousename.Size = new System.Drawing.Size(676, 21);
			this.tbhousename.TabIndex = 12;
			this.tbhousename.Text = "";
			this.tbhousename.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// tblotname
			// 
			this.tblotname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tblotname.Location = new System.Drawing.Point(160, 216);
			this.tblotname.Name = "tblotname";
			this.tblotname.Size = new System.Drawing.Size(676, 21);
			this.tblotname.TabIndex = 11;
			this.tblotname.Text = "";
			this.tblotname.TextChanged += new System.EventHandler(this.CommonChange);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label7.Location = new System.Drawing.Point(360, 64);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(95, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Unknown List:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label6.Location = new System.Drawing.Point(48, 272);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(109, 17);
			this.label6.TabIndex = 9;
			this.label6.Text = "Unknown Name:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(64, 248);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "House Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 224);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(137, 17);
			this.label4.TabIndex = 7;
			this.label4.Text = "Lot Name (Address):";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(680, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(34, 17);
			this.label3.TabIndex = 6;
			this.label3.Text = "U11:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(680, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "U10:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(120, 88);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Lot Type:";
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1.Location = new System.Drawing.Point(761, 268);
			this.button1.Name = "button1";
			this.button1.TabIndex = 3;
			this.button1.Text = "Commit";
			this.button1.Click += new System.EventHandler(this.Commit);
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.Controls.Add(this.label27);
			this.panel2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(848, 24);
			this.panel2.TabIndex = 0;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label27.Location = new System.Drawing.Point(0, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(169, 19);
			this.label27.TabIndex = 0;
			this.label27.Text = "Lot Description Editor";
			// 
			// pb
			// 
			this.pb.Location = new System.Drawing.Point(8, 32);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(104, 88);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb.TabIndex = 52;
			this.pb.TabStop = false;
			// 
			// LtxtForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(864, 318);
			this.Controls.Add(this.ltxtPanel);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "LtxtForm";
			this.Text = "LtxtForm";
			this.ltxtPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		internal Ltxt wrapper;

		private void SelectType(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			if (cbtype.SelectedIndex>0) tbtype.Text = "0x"+Helper.HexString((byte)((Ltxt.LotType)cbtype.Items[cbtype.SelectedIndex]));
			try 
			{
				wrapper.Type = (Ltxt.LotType)Convert.ToByte(tbtype.Text, 16);
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Commit(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.SynchronizeUserData();
				MessageBox.Show(Localization.Manager.GetString("commited"));
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("errwritingfile"), ex);
			}
		}

		private void CommonChange(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.LotID = Convert.ToByte(this.tblotinst.Text, 16);
				wrapper.HouseInstance = Convert.ToByte(this.tbhouseinst.Text, 16);

				wrapper.LotName = tblotname.Text;
				wrapper.HouseName = tbhousename.Text;
				wrapper.Name = tbname.Text;

				wrapper.LotSize = new Size(
					Helper.StringToInt32(tbwd.Text, wrapper.LotSize.Width, 10), 
					Helper.StringToInt32(tbhg.Text, wrapper.LotSize.Height, 10));

				wrapper.LotPosition = new Point(
					Helper.StringToInt32(tbleft.Text, wrapper.LotPosition.X, 10), 
					Helper.StringToInt32(tbtop.Text, wrapper.LotPosition.Y, 10));
				wrapper.Unknown2 = Helper.StringToUInt16(tbunk1.Text, wrapper.Unknown2, 16);
				wrapper.Orientation = (Plugin.LotOrientation)cborient.SelectedValue;

				wrapper.LotInstance = Helper.StringToUInt32(tbinst.Text, wrapper.LotInstance, 16);
				wrapper.Unknown0 = Helper.StringToUInt32(tbu0.Text, wrapper.Unknown0, 16);
				wrapper.Unknown4 = (byte)Helper.StringToUInt16(tbu4.Text, wrapper.Unknown4, 16);
				wrapper.OwnerInstance = Helper.StringToUInt32(tbowner.Text, wrapper.OwnerInstance, 16);
				wrapper.GroundLevel = Helper.StringToFloat(tbz.Text, wrapper.GroundLevel);

				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void ChangeData(object sender, System.EventArgs e)
		{
			if (wrapper==null) return;
			try 
			{
				wrapper.Followup = Helper.SetLength(Helper.HexListToBytes(this.tbData.Text), 0x55);
				
				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void label18_Click(object sender, System.EventArgs e)
		{
		
		}
	}
}
