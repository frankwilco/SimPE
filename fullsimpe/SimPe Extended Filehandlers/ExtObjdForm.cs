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
using SimPe.PackedFiles.Wrapper;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtObjdForm.
	/// </summary>
	internal class ExtObjdForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ExtObjdForm()
		{
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
			this.pnobjd = new System.Windows.Forms.Panel();
			this.tc = new System.Windows.Forms.TabControl();
			this.tpcatalogsort = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbaspiration = new System.Windows.Forms.CheckBox();
			this.cbhobby = new System.Windows.Forms.CheckBox();
			this.cbappliances = new System.Windows.Forms.CheckBox();
			this.cbdecorative = new System.Windows.Forms.CheckBox();
			this.cbelectronics = new System.Windows.Forms.CheckBox();
			this.cbgeneral = new System.Windows.Forms.CheckBox();
			this.cblightning = new System.Windows.Forms.CheckBox();
			this.cbplumbing = new System.Windows.Forms.CheckBox();
			this.cbseating = new System.Windows.Forms.CheckBox();
			this.cbsurfaces = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbkids = new System.Windows.Forms.CheckBox();
			this.cbbathroom = new System.Windows.Forms.CheckBox();
			this.cbbedroom = new System.Windows.Forms.CheckBox();
			this.cbdinigroom = new System.Windows.Forms.CheckBox();
			this.cbkitchen = new System.Windows.Forms.CheckBox();
			this.cbmisc = new System.Windows.Forms.CheckBox();
			this.cboutside = new System.Windows.Forms.CheckBox();
			this.cblivingroom = new System.Windows.Forms.CheckBox();
			this.cbstudy = new System.Windows.Forms.CheckBox();
			this.tpraw = new System.Windows.Forms.TabPage();
			this.rbhex = new System.Windows.Forms.RadioButton();
			this.rbdec = new System.Windows.Forms.RadioButton();
			this.pg = new System.Windows.Forms.PropertyGrid();
			this.rbbin = new System.Windows.Forms.RadioButton();
			this.tbtype = new System.Windows.Forms.TextBox();
			this.cbtype = new System.Windows.Forms.ComboBox();
			this.label63 = new System.Windows.Forms.Label();
			this.tbproxguid = new System.Windows.Forms.TextBox();
			this.label97 = new System.Windows.Forms.Label();
			this.tborgguid = new System.Windows.Forms.TextBox();
			this.llgetGUID = new System.Windows.Forms.LinkLabel();
			this.llcommitobjd = new System.Windows.Forms.LinkLabel();
			this.label65 = new System.Windows.Forms.Label();
			this.tbflname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbguid = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.cbcareer = new System.Windows.Forms.CheckBox();
			this.cball = new System.Windows.Forms.CheckBox();
			this.pnobjd.SuspendLayout();
			this.tc.SuspendLayout();
			this.tpcatalogsort.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tpraw.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnobjd
			// 
			this.pnobjd.AutoScroll = true;
			this.pnobjd.Controls.Add(this.cball);
			this.pnobjd.Controls.Add(this.tc);
			this.pnobjd.Controls.Add(this.tbtype);
			this.pnobjd.Controls.Add(this.cbtype);
			this.pnobjd.Controls.Add(this.label63);
			this.pnobjd.Controls.Add(this.tbproxguid);
			this.pnobjd.Controls.Add(this.label97);
			this.pnobjd.Controls.Add(this.tborgguid);
			this.pnobjd.Controls.Add(this.llgetGUID);
			this.pnobjd.Controls.Add(this.llcommitobjd);
			this.pnobjd.Controls.Add(this.label65);
			this.pnobjd.Controls.Add(this.tbflname);
			this.pnobjd.Controls.Add(this.label9);
			this.pnobjd.Controls.Add(this.tbguid);
			this.pnobjd.Controls.Add(this.label8);
			this.pnobjd.Controls.Add(this.panel6);
			this.pnobjd.Controls.Add(this.linkLabel1);
			this.pnobjd.Location = new System.Drawing.Point(8, 8);
			this.pnobjd.Name = "pnobjd";
			this.pnobjd.Size = new System.Drawing.Size(736, 328);
			this.pnobjd.TabIndex = 6;
			// 
			// tc
			// 
			this.tc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tc.Controls.Add(this.tpcatalogsort);
			this.tc.Controls.Add(this.tpraw);
			this.tc.Location = new System.Drawing.Point(8, 136);
			this.tc.Name = "tc";
			this.tc.SelectedIndex = 0;
			this.tc.Size = new System.Drawing.Size(720, 160);
			this.tc.TabIndex = 26;
			this.tc.SelectedIndexChanged += new System.EventHandler(this.CangedTab);
			// 
			// tpcatalogsort
			// 
			this.tpcatalogsort.Controls.Add(this.groupBox2);
			this.tpcatalogsort.Controls.Add(this.groupBox1);
			this.tpcatalogsort.Location = new System.Drawing.Point(4, 22);
			this.tpcatalogsort.Name = "tpcatalogsort";
			this.tpcatalogsort.Size = new System.Drawing.Size(712, 134);
			this.tpcatalogsort.TabIndex = 0;
			this.tpcatalogsort.Text = "Catalog Sort";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbaspiration);
			this.groupBox2.Controls.Add(this.cbhobby);
			this.groupBox2.Controls.Add(this.cbappliances);
			this.groupBox2.Controls.Add(this.cbdecorative);
			this.groupBox2.Controls.Add(this.cbelectronics);
			this.groupBox2.Controls.Add(this.cbgeneral);
			this.groupBox2.Controls.Add(this.cblightning);
			this.groupBox2.Controls.Add(this.cbplumbing);
			this.groupBox2.Controls.Add(this.cbseating);
			this.groupBox2.Controls.Add(this.cbsurfaces);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(352, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(336, 112);
			this.groupBox2.TabIndex = 17;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Function Sort";
			// 
			// cbaspiration
			// 
			this.cbaspiration.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbaspiration.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbaspiration.Location = new System.Drawing.Point(224, 44);
			this.cbaspiration.Name = "cbaspiration";
			this.cbaspiration.TabIndex = 17;
			this.cbaspiration.Text = "Aspiration";
			this.cbaspiration.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbhobby
			// 
			this.cbhobby.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbhobby.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbhobby.Location = new System.Drawing.Point(224, 24);
			this.cbhobby.Name = "cbhobby";
			this.cbhobby.TabIndex = 16;
			this.cbhobby.Text = "Hobbies";
			this.cbhobby.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbappliances
			// 
			this.cbappliances.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbappliances.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbappliances.Location = new System.Drawing.Point(16, 24);
			this.cbappliances.Name = "cbappliances";
			this.cbappliances.TabIndex = 8;
			this.cbappliances.Text = "Appliances";
			this.cbappliances.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbdecorative
			// 
			this.cbdecorative.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbdecorative.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbdecorative.Location = new System.Drawing.Point(16, 44);
			this.cbdecorative.Name = "cbdecorative";
			this.cbdecorative.TabIndex = 9;
			this.cbdecorative.Text = "Decorative";
			this.cbdecorative.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbelectronics
			// 
			this.cbelectronics.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbelectronics.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbelectronics.Location = new System.Drawing.Point(16, 64);
			this.cbelectronics.Name = "cbelectronics";
			this.cbelectronics.TabIndex = 10;
			this.cbelectronics.Text = "Electronics";
			this.cbelectronics.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbgeneral
			// 
			this.cbgeneral.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbgeneral.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbgeneral.Location = new System.Drawing.Point(16, 84);
			this.cbgeneral.Name = "cbgeneral";
			this.cbgeneral.TabIndex = 11;
			this.cbgeneral.Text = "General";
			this.cbgeneral.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cblightning
			// 
			this.cblightning.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cblightning.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cblightning.Location = new System.Drawing.Point(120, 24);
			this.cblightning.Name = "cblightning";
			this.cblightning.TabIndex = 12;
			this.cblightning.Text = "Lights";
			this.cblightning.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbplumbing
			// 
			this.cbplumbing.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbplumbing.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbplumbing.Location = new System.Drawing.Point(120, 44);
			this.cbplumbing.Name = "cbplumbing";
			this.cbplumbing.TabIndex = 13;
			this.cbplumbing.Text = "Plumbing";
			this.cbplumbing.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbseating
			// 
			this.cbseating.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbseating.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbseating.Location = new System.Drawing.Point(120, 64);
			this.cbseating.Name = "cbseating";
			this.cbseating.TabIndex = 14;
			this.cbseating.Text = "Seating";
			this.cbseating.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cbsurfaces
			// 
			this.cbsurfaces.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbsurfaces.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbsurfaces.Location = new System.Drawing.Point(120, 84);
			this.cbsurfaces.Name = "cbsurfaces";
			this.cbsurfaces.TabIndex = 15;
			this.cbsurfaces.Text = "Surfaces";
			this.cbsurfaces.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbkids);
			this.groupBox1.Controls.Add(this.cbbathroom);
			this.groupBox1.Controls.Add(this.cbbedroom);
			this.groupBox1.Controls.Add(this.cbdinigroom);
			this.groupBox1.Controls.Add(this.cbkitchen);
			this.groupBox1.Controls.Add(this.cbmisc);
			this.groupBox1.Controls.Add(this.cboutside);
			this.groupBox1.Controls.Add(this.cblivingroom);
			this.groupBox1.Controls.Add(this.cbstudy);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(8, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(328, 112);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Room Sort";
			// 
			// cbkids
			// 
			this.cbkids.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbkids.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbkids.Location = new System.Drawing.Point(232, 24);
			this.cbkids.Name = "cbkids";
			this.cbkids.Size = new System.Drawing.Size(88, 24);
			this.cbkids.TabIndex = 8;
			this.cbkids.Text = "Kids";
			this.cbkids.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbbathroom
			// 
			this.cbbathroom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbbathroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbbathroom.Location = new System.Drawing.Point(16, 24);
			this.cbbathroom.Name = "cbbathroom";
			this.cbbathroom.TabIndex = 0;
			this.cbbathroom.Text = "Bathroom";
			this.cbbathroom.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbbedroom
			// 
			this.cbbedroom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbbedroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbbedroom.Location = new System.Drawing.Point(16, 44);
			this.cbbedroom.Name = "cbbedroom";
			this.cbbedroom.TabIndex = 1;
			this.cbbedroom.Text = "Bedroom";
			this.cbbedroom.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbdinigroom
			// 
			this.cbdinigroom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbdinigroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbdinigroom.Location = new System.Drawing.Point(16, 64);
			this.cbdinigroom.Name = "cbdinigroom";
			this.cbdinigroom.TabIndex = 2;
			this.cbdinigroom.Text = "Dinigroom";
			this.cbdinigroom.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbkitchen
			// 
			this.cbkitchen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbkitchen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbkitchen.Location = new System.Drawing.Point(16, 84);
			this.cbkitchen.Name = "cbkitchen";
			this.cbkitchen.TabIndex = 3;
			this.cbkitchen.Text = "Kitchen";
			this.cbkitchen.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbmisc
			// 
			this.cbmisc.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbmisc.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbmisc.Location = new System.Drawing.Point(120, 44);
			this.cbmisc.Name = "cbmisc";
			this.cbmisc.TabIndex = 4;
			this.cbmisc.Text = "Misc.";
			this.cbmisc.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cboutside
			// 
			this.cboutside.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cboutside.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboutside.Location = new System.Drawing.Point(120, 64);
			this.cboutside.Name = "cboutside";
			this.cboutside.TabIndex = 5;
			this.cboutside.Text = "Outside";
			this.cboutside.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cblivingroom
			// 
			this.cblivingroom.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cblivingroom.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cblivingroom.Location = new System.Drawing.Point(120, 24);
			this.cblivingroom.Name = "cblivingroom";
			this.cblivingroom.TabIndex = 6;
			this.cblivingroom.Text = "Livingroom";
			this.cblivingroom.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// cbstudy
			// 
			this.cbstudy.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbstudy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbstudy.Location = new System.Drawing.Point(120, 84);
			this.cbstudy.Name = "cbstudy";
			this.cbstudy.TabIndex = 7;
			this.cbstudy.Text = "Study";
			this.cbstudy.CheckedChanged += new System.EventHandler(this.SetRoomFlags);
			// 
			// tpraw
			// 
			this.tpraw.Controls.Add(this.rbhex);
			this.tpraw.Controls.Add(this.rbdec);
			this.tpraw.Controls.Add(this.pg);
			this.tpraw.Controls.Add(this.rbbin);
			this.tpraw.Location = new System.Drawing.Point(4, 22);
			this.tpraw.Name = "tpraw";
			this.tpraw.Size = new System.Drawing.Size(712, 134);
			this.tpraw.TabIndex = 1;
			this.tpraw.Text = "RAW Data";
			// 
			// rbhex
			// 
			this.rbhex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbhex.Location = new System.Drawing.Point(600, 0);
			this.rbhex.Name = "rbhex";
			this.rbhex.TabIndex = 3;
			this.rbhex.Text = "Hexadecimal";
			this.rbhex.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// rbdec
			// 
			this.rbdec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbdec.Location = new System.Drawing.Point(520, 0);
			this.rbdec.Name = "rbdec";
			this.rbdec.Size = new System.Drawing.Size(72, 24);
			this.rbdec.TabIndex = 2;
			this.rbdec.Text = "Decimal";
			this.rbdec.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// pg
			// 
			this.pg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pg.CommandsVisibleIfAvailable = true;
			this.pg.HelpVisible = false;
			this.pg.LargeButtons = false;
			this.pg.LineColor = System.Drawing.SystemColors.ScrollBar;
			this.pg.Location = new System.Drawing.Point(8, 24);
			this.pg.Name = "pg";
			this.pg.PropertySort = System.Windows.Forms.PropertySort.Alphabetical;
			this.pg.Size = new System.Drawing.Size(696, 104);
			this.pg.TabIndex = 0;
			this.pg.Text = "RAW Items";
			this.pg.ToolbarVisible = false;
			this.pg.ViewBackColor = System.Drawing.SystemColors.Window;
			this.pg.ViewForeColor = System.Drawing.SystemColors.WindowText;
			this.pg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.PropChanged);
			// 
			// rbbin
			// 
			this.rbbin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.rbbin.Location = new System.Drawing.Point(448, 0);
			this.rbbin.Name = "rbbin";
			this.rbbin.Size = new System.Drawing.Size(64, 24);
			this.rbbin.TabIndex = 1;
			this.rbbin.Text = "Binary";
			this.rbbin.CheckedChanged += new System.EventHandler(this.DigitChanged);
			// 
			// tbtype
			// 
			this.tbtype.Location = new System.Drawing.Point(304, 104);
			this.tbtype.Name = "tbtype";
			this.tbtype.ReadOnly = true;
			this.tbtype.Size = new System.Drawing.Size(72, 21);
			this.tbtype.TabIndex = 25;
			this.tbtype.Text = "";
			// 
			// cbtype
			// 
			this.cbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtype.Location = new System.Drawing.Point(88, 104);
			this.cbtype.Name = "cbtype";
			this.cbtype.Size = new System.Drawing.Size(208, 21);
			this.cbtype.TabIndex = 24;
			this.cbtype.SelectedIndexChanged += new System.EventHandler(this.ChangeType);
			// 
			// label63
			// 
			this.label63.AutoSize = true;
			this.label63.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.label63.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label63.Location = new System.Drawing.Point(352, 40);
			this.label63.Name = "label63";
			this.label63.Size = new System.Drawing.Size(78, 17);
			this.label63.TabIndex = 22;
			this.label63.Text = "Orig. GUID:";
			// 
			// tbproxguid
			// 
			this.tbproxguid.Location = new System.Drawing.Point(640, 32);
			this.tbproxguid.Name = "tbproxguid";
			this.tbproxguid.Size = new System.Drawing.Size(88, 21);
			this.tbproxguid.TabIndex = 21;
			this.tbproxguid.Text = "";
			this.tbproxguid.TextChanged += new System.EventHandler(this.SetGuid);
			// 
			// label97
			// 
			this.label97.AutoSize = true;
			this.label97.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.label97.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label97.Location = new System.Drawing.Point(536, 40);
			this.label97.Name = "label97";
			this.label97.Size = new System.Drawing.Size(99, 17);
			this.label97.TabIndex = 20;
			this.label97.Text = "Fallback GUID:";
			// 
			// tborgguid
			// 
			this.tborgguid.Location = new System.Drawing.Point(432, 32);
			this.tborgguid.Name = "tborgguid";
			this.tborgguid.Size = new System.Drawing.Size(88, 21);
			this.tborgguid.TabIndex = 19;
			this.tborgguid.Text = "";
			this.tborgguid.TextChanged += new System.EventHandler(this.SetGuid);
			// 
			// llgetGUID
			// 
			this.llgetGUID.AutoSize = true;
			this.llgetGUID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llgetGUID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.llgetGUID.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
			this.llgetGUID.Location = new System.Drawing.Point(184, 41);
			this.llgetGUID.Name = "llgetGUID";
			this.llgetGUID.Size = new System.Drawing.Size(63, 17);
			this.llgetGUID.TabIndex = 16;
			this.llgetGUID.TabStop = true;
			this.llgetGUID.Text = "get GUID";
			this.llgetGUID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetGuid);
			// 
			// llcommitobjd
			// 
			this.llcommitobjd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.llcommitobjd.AutoSize = true;
			this.llcommitobjd.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llcommitobjd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.llcommitobjd.LinkArea = new System.Windows.Forms.LinkArea(0, 10);
			this.llcommitobjd.Location = new System.Drawing.Point(675, 304);
			this.llcommitobjd.Name = "llcommitobjd";
			this.llcommitobjd.Size = new System.Drawing.Size(53, 17);
			this.llcommitobjd.TabIndex = 14;
			this.llcommitobjd.TabStop = true;
			this.llcommitobjd.Text = "Commit";
			this.llcommitobjd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Commit);
			// 
			// label65
			// 
			this.label65.AutoSize = true;
			this.label65.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.label65.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label65.Location = new System.Drawing.Point(14, 112);
			this.label65.Name = "label65";
			this.label65.Size = new System.Drawing.Size(69, 17);
			this.label65.TabIndex = 12;
			this.label65.Text = "Obj. Type:";
			// 
			// tbflname
			// 
			this.tbflname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.tbflname.Location = new System.Drawing.Point(88, 80);
			this.tbflname.Name = "tbflname";
			this.tbflname.Size = new System.Drawing.Size(640, 21);
			this.tbflname.TabIndex = 11;
			this.tbflname.Text = "";
			this.tbflname.TextChanged += new System.EventHandler(this.SetFlName);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label9.Location = new System.Drawing.Point(16, 88);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(67, 17);
			this.label9.TabIndex = 10;
			this.label9.Text = "Filename:";
			// 
			// tbguid
			// 
			this.tbguid.Location = new System.Drawing.Point(88, 37);
			this.tbguid.Name = "tbguid";
			this.tbguid.Size = new System.Drawing.Size(88, 21);
			this.tbguid.TabIndex = 9;
			this.tbguid.Text = "";
			this.tbguid.TextChanged += new System.EventHandler(this.SetGuid);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold);
			this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label8.Location = new System.Drawing.Point(40, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(43, 17);
			this.label8.TabIndex = 8;
			this.label8.Text = "GUID:";
			// 
			// panel6
			// 
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel6.Controls.Add(this.label12);
			this.panel6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold);
			this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel6.Location = new System.Drawing.Point(0, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(736, 24);
			this.panel6.TabIndex = 0;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label12.Location = new System.Drawing.Point(0, 4);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(180, 19);
			this.label12.TabIndex = 0;
			this.label12.Text = "Objekt Beschreibungen";
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.linkLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 6);
			this.linkLabel1.Location = new System.Drawing.Point(88, 60);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(177, 17);
			this.linkLabel1.TabIndex = 27;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Update MMATs and commit";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateMMAT);
			// 
			// cbcareer
			// 
			this.cbcareer.Location = new System.Drawing.Point(0, 0);
			this.cbcareer.Name = "cbcareer";
			this.cbcareer.TabIndex = 0;
			this.cbcareer.CheckedChanged += new System.EventHandler(this.SetFunctionFlags);
			// 
			// cball
			// 
			this.cball.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cball.Location = new System.Drawing.Point(280, 56);
			this.cball.Name = "cball";
			this.cball.Size = new System.Drawing.Size(120, 24);
			this.cball.TabIndex = 28;
			this.cball.Text = "update all MMATs";
			// 
			// ExtObjdForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(888, 350);
			this.Controls.Add(this.pnobjd);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ExtObjdForm";
			this.Text = "ExtObjdForm";
			this.pnobjd.ResumeLayout(false);
			this.tc.ResumeLayout(false);
			this.tpcatalogsort.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.tpraw.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private System.Windows.Forms.Label label63;
		internal System.Windows.Forms.TextBox tbproxguid;
		private System.Windows.Forms.Label label97;
		internal System.Windows.Forms.TextBox tborgguid;
		private System.Windows.Forms.LinkLabel llgetGUID;
		private System.Windows.Forms.LinkLabel llcommitobjd;
		private System.Windows.Forms.Label label65;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label12;
		internal System.Windows.Forms.TextBox tbflname;
		internal System.Windows.Forms.TextBox tbguid;
		internal System.Windows.Forms.ComboBox cbtype;
		internal System.Windows.Forms.TextBox tbtype;
		internal System.Windows.Forms.Panel pnobjd;
		internal System.Windows.Forms.CheckBox cbbathroom;
		internal System.Windows.Forms.CheckBox cbbedroom;
		internal System.Windows.Forms.CheckBox cbdinigroom;
		internal System.Windows.Forms.CheckBox cbkitchen;
		internal System.Windows.Forms.CheckBox cbstudy;
		internal System.Windows.Forms.CheckBox cblivingroom;
		internal System.Windows.Forms.CheckBox cboutside;
		internal System.Windows.Forms.CheckBox cbmisc;
		internal System.Windows.Forms.CheckBox cbgeneral;
		internal System.Windows.Forms.CheckBox cbelectronics;
		internal System.Windows.Forms.CheckBox cbdecorative;
		internal System.Windows.Forms.CheckBox cbappliances;
		internal System.Windows.Forms.CheckBox cbsurfaces;
		internal System.Windows.Forms.CheckBox cbseating;
		internal System.Windows.Forms.CheckBox cbplumbing;
		internal System.Windows.Forms.CheckBox cblightning;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;

		internal ExtObjd wrapper;
		private System.Windows.Forms.LinkLabel linkLabel1;
		internal System.Windows.Forms.PropertyGrid pg;
		internal System.Windows.Forms.TabControl tc;
		internal System.Windows.Forms.TabPage tpcatalogsort;
		private System.Windows.Forms.TabPage tpraw;
		internal System.Windows.Forms.CheckBox cbhobby;
		internal System.Windows.Forms.CheckBox cbaspiration;
		internal System.Windows.Forms.CheckBox cbcareer;
		internal System.Windows.Forms.CheckBox cbkids;
		private System.Windows.Forms.RadioButton rbbin;
		private System.Windows.Forms.RadioButton rbdec;
		private System.Windows.Forms.RadioButton rbhex;
		private System.Windows.Forms.CheckBox cball;
		internal uint initialguid;

		private void GetGuid(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Sims.GUID.GUIDGetterForm form = new Sims.GUID.GUIDGetterForm();
			Registry reg = new Registry();

			try 
			{
				uint guid = form.GetNewGUID(reg.Username, reg.Password);

				reg.Username = form.tbusername.Text;
				reg.Password = form.tbpassword.Text;
				this.tbguid.Text = "0x"+Helper.HexString(guid);				
			} 
			catch (Exception) {}
		}

		private void ChangeType(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			this.Tag = true;

			try 
			{
				if (cbtype.SelectedIndex<0) return;
				Data.ObjectTypes ot = (Data.ObjectTypes)cbtype.Items[cbtype.SelectedIndex];
				tbtype.Text = "0x"+Helper.HexString((ushort)ot);

				wrapper.Type = ot;
				wrapper.Changed = true;

				if (this.pg.SelectedObject!=null) 
				{
					UpdateData();
					ShowData();
				}
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		private void SetRoomFlags(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			this.Tag = true;

			try 
			{
				wrapper.RoomSort.InBathroom = cbbathroom.Checked;
				wrapper.RoomSort.InBedroom = cbbedroom.Checked;
				wrapper.RoomSort.InDiningRoom = cbdinigroom.Checked;
				wrapper.RoomSort.InKitchen = cbkitchen.Checked;
				wrapper.RoomSort.InLivingRoom = cblivingroom.Checked;
				wrapper.RoomSort.InMisc = cbmisc.Checked;
				wrapper.RoomSort.InOutside = cboutside.Checked;
				wrapper.RoomSort.InStudy = cbstudy.Checked;
				wrapper.RoomSort.InKids = cbkids.Checked;

				wrapper.Changed = true;				
			}
			finally 
			{
				this.Tag = null;
			}
		}

		private void SetFunctionFlags(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			this.Tag = true;

			try 
			{
				wrapper.FunctionSort.InAppliances = this.cbappliances.Checked;
				wrapper.FunctionSort.InDecorative = this.cbdecorative.Checked;
				wrapper.FunctionSort.InElectronics = this.cbelectronics.Checked;
				wrapper.FunctionSort.InGeneral = this.cbgeneral.Checked;
				wrapper.FunctionSort.InLighting = this.cblightning.Checked;
				wrapper.FunctionSort.InPlumbing = this.cbplumbing.Checked;
				wrapper.FunctionSort.InSeating = this.cbseating.Checked;
				wrapper.FunctionSort.InSurfaces = this.cbsurfaces.Checked;
				wrapper.FunctionSort.InHobbies = this.cbhobby.Checked;
				wrapper.FunctionSort.InAspirationRewards = this.cbaspiration.Checked;
				wrapper.FunctionSort.InCareerRewards = this.cbcareer.Checked;

				wrapper.Changed = true;
			} 
			finally 
			{
				this.Tag = null;
			}
		}

		private void SetGuid(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			this.Tag = true;

			try 
			{
				wrapper.Guid = Convert.ToUInt32(tbguid.Text, 16);
				wrapper.ProxyGuid = Convert.ToUInt32(this.tbproxguid.Text, 16);
				wrapper.OriginalGuid = Convert.ToUInt32(this.tborgguid.Text, 16);
				wrapper.Changed = true;
			} 
			catch (Exception){}
			finally 
			{
				this.Tag = null;
			}
		}

		private void Commit(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{	
			if (this.pg.SelectedObject!=null) UpdateData();
			wrapper.SynchronizeUserData();
		}

		private void UpdateMMAT(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper.Guid!=initialguid)
			{
				SimPe.Plugin.FixGuid fg = new SimPe.Plugin.FixGuid(wrapper.Package);
				if (cball.Checked) 
				{
					fg.FixGuids(wrapper.Guid);
				} 
				else 
				{
					ArrayList al = new ArrayList();
					SimPe.Plugin.GuidSet gs = new SimPe.Plugin.GuidSet();
					gs.oldguid = initialguid;
					gs.guid = wrapper.Guid;
					al.Add(gs);

					fg.FixGuids(al);
				}
				initialguid = wrapper.Guid;
			}

			wrapper.SynchronizeUserData();
		}

		Ambertation.PropertyObjectBuilder pob;
		ArrayList names;
		bool propchanged;
		void ShowData()
		{
			propchanged = false;
			this.pg.SelectedObject = null;
			
			names = new ArrayList();
			names = wrapper.Opcodes.OBJDDescription((ushort)wrapper.Type);

			Hashtable ht = new Hashtable();
			for (int i=0; i<Math.Min(names.Count, wrapper.Data.Length); i++)
			{
				string name = "0x"+Helper.HexString((ushort)i) + ": ";
				name += (string)names[i];
				if (name.Trim()=="") name = "Unknwon";
				if (!ht.Contains(name)) ht.Add(name, wrapper.Data[i]);
			}

			pob = new Ambertation.PropertyObjectBuilder(ht);
			this.pg.SelectedObject = pob.Instance;
		}

		void UpdateData()
		{
			if (!propchanged) return;
			propchanged = false;

			try 
			{
				Hashtable ht = pob.Properties;

				for (int i=0; i<Math.Min(names.Count, wrapper.Data.Length); i++)
				{
					string name = (string)names[i];
					if (name.Trim()=="") name = "Unknwon 0x"+Helper.HexString(i);
					if (ht.Contains(name)) wrapper.Data[i] = (short)ht[name];
				}

				wrapper.Changed = true;
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}

		}

		private void CangedTab(object sender, System.EventArgs e)
		{
			if (tc.SelectedTab == tpraw)
			{
				rbhex.Checked = (Ambertation.BaseChangeShort.DigitBase==16);
				rbbin.Checked = (Ambertation.BaseChangeShort.DigitBase==2);
				rbdec.Checked = (!rbhex.Checked && !rbbin.Checked);

				if (this.pg.SelectedObject==null) ShowData();
			} 
			else 
			{
				if (this.pg.SelectedObject!=null) UpdateData();
				this.pg.SelectedObject = null;
			}
		}

		private void PropChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			propchanged = true;
		}

		private void SetFlName(object sender, System.EventArgs e)
		{
			if (this.Tag!=null) return;
			wrapper.FileName = tbflname.Text;
			wrapper.Changed = true;
		}

		private void DigitChanged(object sender, System.EventArgs e)
		{
			if (rbhex.Checked) Ambertation.BaseChangeShort.DigitBase = 16;
			else if (rbbin.Checked) Ambertation.BaseChangeShort.DigitBase = 2;			
			else Ambertation.BaseChangeShort.DigitBase = 10;

			this.pg.Refresh();		
		}
	}
}
