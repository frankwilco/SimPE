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

namespace SimPe.Plugin.Scanner
{
	/// <summary>
	/// Zusammenfassung für ScannerPanelForm.
	/// </summary>
	internal class ScannerPanelForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		internal System.Windows.Forms.Panel pncloth;
		private System.Windows.Forms.Label label1;
		private Skybound.VisualStyles.VisualStyleProvider visualStyleProvider1;
		private System.Windows.Forms.Label label2;		
		private System.Windows.Forms.CheckBox cbswim;
		private System.Windows.Forms.CheckBox cbact;
		private System.Windows.Forms.CheckBox cbskin;
		private System.Windows.Forms.CheckBox cbformal;
		private System.Windows.Forms.CheckBox cbpreg;
		private System.Windows.Forms.CheckBox cbundies;
		private System.Windows.Forms.CheckBox cbpj;
		private System.Windows.Forms.CheckBox cbevery;
		private System.Windows.Forms.CheckBox cbelder;
		private System.Windows.Forms.CheckBox cbadult;
		private System.Windows.Forms.CheckBox cbyoung;
		private System.Windows.Forms.CheckBox cbteen;
		private System.Windows.Forms.CheckBox cbchild;
		private System.Windows.Forms.CheckBox cbtoddler;
		private System.Windows.Forms.CheckBox cbbaby;
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		internal System.Windows.Forms.CheckBox[] cbages = new CheckBox[7];
		private Skybound.VisualStyles.VisualStyleLinkLabel llsetage;
		private Skybound.VisualStyles.VisualStyleLinkLabel llsetcat;
		private System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.Panel pnep;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel1;
		private System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabPage3;
		internal System.Windows.Forms.Panel pnskin;
		private System.Windows.Forms.Label label4;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel2;
		private System.Windows.Forms.ComboBox cbskins;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.CheckBox cbtxmt;
		private System.Windows.Forms.CheckBox cbtxtr;
		internal System.Windows.Forms.CheckBox[] cbcategories = new CheckBox[8];
		public ScannerPanelForm()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
			InitializeComponent();

			cbages[0] = cbbaby; cbbaby.Tag = Data.Ages.Baby;
			cbages[1] = cbtoddler; cbtoddler.Tag = Data.Ages.Toddler;
			cbages[2] = cbchild; cbchild.Tag = Data.Ages.Child;
			cbages[3] = cbteen; cbteen.Tag = Data.Ages.Teen;
			cbages[4] = cbyoung; cbyoung.Tag = Data.Ages.YoungAdult;
			cbages[5] = cbadult; cbadult.Tag = Data.Ages.Adult;
			cbages[6] = cbelder; cbelder.Tag = Data.Ages.Elder;
			
			cbcategories[0] = cbact; cbact.Tag = Data.SkinCategories.Activewear;
			cbcategories[1] = cbevery; cbevery.Tag = Data.SkinCategories.Everyday;
			cbcategories[2] = cbformal; cbformal.Tag = Data.SkinCategories.Formal;
			cbcategories[3] = cbpj; cbpj.Tag = Data.SkinCategories.PJ;
			cbcategories[4] = cbpreg; cbpreg.Tag = Data.SkinCategories.Pregnant;
			cbcategories[5] = cbskin; cbskin.Tag = Data.SkinCategories.Skin;
			cbcategories[6] = cbswim; cbswim.Tag = Data.SkinCategories.Swimmwear;
			cbcategories[7] = cbundies; cbundies.Tag = Data.SkinCategories.Undies;

			if (Helper.WindowsRegistry.Username.Trim()!="")
				this.tbname.Text = Helper.WindowsRegistry.Username+"-";

			this.cbskins.SelectedIndex = 0;
			sfd.InitialDirectory = Helper.WindowsRegistry.SimSavegameFolder;
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

		static ScannerPanelForm form;
		public static ScannerPanelForm Form 
		{
			get 
			{
				if (form==null) form = new ScannerPanelForm();
				return form;
			}
		}

		#region Vom Windows Form-Designer generierter Code
		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.pncloth = new System.Windows.Forms.Panel();
			this.llsetcat = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.llsetage = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.cbswim = new System.Windows.Forms.CheckBox();
			this.cbact = new System.Windows.Forms.CheckBox();
			this.cbskin = new System.Windows.Forms.CheckBox();
			this.cbformal = new System.Windows.Forms.CheckBox();
			this.cbpreg = new System.Windows.Forms.CheckBox();
			this.cbundies = new System.Windows.Forms.CheckBox();
			this.cbpj = new System.Windows.Forms.CheckBox();
			this.cbevery = new System.Windows.Forms.CheckBox();
			this.cbelder = new System.Windows.Forms.CheckBox();
			this.cbadult = new System.Windows.Forms.CheckBox();
			this.cbyoung = new System.Windows.Forms.CheckBox();
			this.cbteen = new System.Windows.Forms.CheckBox();
			this.cbchild = new System.Windows.Forms.CheckBox();
			this.cbtoddler = new System.Windows.Forms.CheckBox();
			this.cbbaby = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.pnep = new System.Windows.Forms.Panel();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.visualStyleLinkLabel1 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.pnskin = new System.Windows.Forms.Panel();
			this.cbtxtr = new System.Windows.Forms.CheckBox();
			this.cbtxmt = new System.Windows.Forms.CheckBox();
			this.cbskins = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.visualStyleLinkLabel2 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.visualStyleProvider1 = new Skybound.VisualStyles.VisualStyleProvider();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.pncloth.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.pnep.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.pnskin.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(8, 8);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(408, 176);
			this.tabControl1.TabIndex = 0;
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabControl1, true);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.pncloth);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(400, 150);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Clothes";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage1, true);
			// 
			// pncloth
			// 
			this.pncloth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pncloth.Controls.Add(this.llsetcat);
			this.pncloth.Controls.Add(this.llsetage);
			this.pncloth.Controls.Add(this.cbswim);
			this.pncloth.Controls.Add(this.cbact);
			this.pncloth.Controls.Add(this.cbskin);
			this.pncloth.Controls.Add(this.cbformal);
			this.pncloth.Controls.Add(this.cbpreg);
			this.pncloth.Controls.Add(this.cbundies);
			this.pncloth.Controls.Add(this.cbpj);
			this.pncloth.Controls.Add(this.cbevery);
			this.pncloth.Controls.Add(this.cbelder);
			this.pncloth.Controls.Add(this.cbadult);
			this.pncloth.Controls.Add(this.cbyoung);
			this.pncloth.Controls.Add(this.cbteen);
			this.pncloth.Controls.Add(this.cbchild);
			this.pncloth.Controls.Add(this.cbtoddler);
			this.pncloth.Controls.Add(this.cbbaby);
			this.pncloth.Controls.Add(this.label2);
			this.pncloth.Controls.Add(this.label1);
			this.pncloth.Location = new System.Drawing.Point(24, 8);
			this.pncloth.Name = "pncloth";
			this.pncloth.Size = new System.Drawing.Size(368, 136);
			this.pncloth.TabIndex = 0;
			this.visualStyleProvider1.SetVisualStyleSupport(this.pncloth, true);
			// 
			// llsetcat
			// 
			this.llsetcat.AutoSize = true;
			this.llsetcat.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llsetcat.Location = new System.Drawing.Point(0, 72);
			this.llsetcat.Name = "llsetcat";
			this.llsetcat.Size = new System.Drawing.Size(24, 17);
			this.llsetcat.TabIndex = 38;
			this.llsetcat.TabStop = true;
			this.llsetcat.Text = "set";
			this.llsetcat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SetCat);
			// 
			// llsetage
			// 
			this.llsetage.AutoSize = true;
			this.llsetage.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.llsetage.Location = new System.Drawing.Point(0, 8);
			this.llsetage.Name = "llsetage";
			this.llsetage.Size = new System.Drawing.Size(24, 17);
			this.llsetage.TabIndex = 37;
			this.llsetage.TabStop = true;
			this.llsetage.Text = "set";
			this.llsetage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.setAge);
			// 
			// cbswim
			// 
			this.cbswim.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbswim.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbswim.Location = new System.Drawing.Point(16, 112);
			this.cbswim.Name = "cbswim";
			this.cbswim.Size = new System.Drawing.Size(96, 24);
			this.cbswim.TabIndex = 36;
			this.cbswim.Text = "Swimmwear";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbswim, false);
			// 
			// cbact
			// 
			this.cbact.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbact.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbact.Location = new System.Drawing.Point(256, 112);
			this.cbact.Name = "cbact";
			this.cbact.Size = new System.Drawing.Size(64, 24);
			this.cbact.TabIndex = 35;
			this.cbact.Text = "Active";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbact, false);
			// 
			// cbskin
			// 
			this.cbskin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbskin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbskin.Location = new System.Drawing.Point(112, 112);
			this.cbskin.Name = "cbskin";
			this.cbskin.Size = new System.Drawing.Size(56, 24);
			this.cbskin.TabIndex = 34;
			this.cbskin.Text = "Skin";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbskin, false);
			// 
			// cbformal
			// 
			this.cbformal.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbformal.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbformal.Location = new System.Drawing.Point(176, 112);
			this.cbformal.Name = "cbformal";
			this.cbformal.Size = new System.Drawing.Size(64, 24);
			this.cbformal.TabIndex = 33;
			this.cbformal.Text = "Formal";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbformal, false);
			// 
			// cbpreg
			// 
			this.cbpreg.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbpreg.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpreg.Location = new System.Drawing.Point(256, 88);
			this.cbpreg.Name = "cbpreg";
			this.cbpreg.Size = new System.Drawing.Size(80, 24);
			this.cbpreg.TabIndex = 32;
			this.cbpreg.Text = "Pregnant";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpreg, false);
			// 
			// cbundies
			// 
			this.cbundies.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbundies.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbundies.Location = new System.Drawing.Point(176, 88);
			this.cbundies.Name = "cbundies";
			this.cbundies.Size = new System.Drawing.Size(64, 24);
			this.cbundies.TabIndex = 31;
			this.cbundies.Text = "Undies";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbundies, false);
			// 
			// cbpj
			// 
			this.cbpj.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbpj.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpj.Location = new System.Drawing.Point(112, 88);
			this.cbpj.Name = "cbpj";
			this.cbpj.Size = new System.Drawing.Size(56, 24);
			this.cbpj.TabIndex = 30;
			this.cbpj.Text = "PJ";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpj, false);
			// 
			// cbevery
			// 
			this.cbevery.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbevery.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbevery.Location = new System.Drawing.Point(16, 88);
			this.cbevery.Name = "cbevery";
			this.cbevery.Size = new System.Drawing.Size(80, 24);
			this.cbevery.TabIndex = 29;
			this.cbevery.Text = "Everyday";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbevery, false);
			// 
			// cbelder
			// 
			this.cbelder.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbelder.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbelder.Location = new System.Drawing.Point(176, 48);
			this.cbelder.Name = "cbelder";
			this.cbelder.Size = new System.Drawing.Size(64, 24);
			this.cbelder.TabIndex = 28;
			this.cbelder.Text = "Elder";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbelder, false);
			// 
			// cbadult
			// 
			this.cbadult.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbadult.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbadult.Location = new System.Drawing.Point(112, 48);
			this.cbadult.Name = "cbadult";
			this.cbadult.Size = new System.Drawing.Size(64, 24);
			this.cbadult.TabIndex = 27;
			this.cbadult.Text = "Adult";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbadult, false);
			// 
			// cbyoung
			// 
			this.cbyoung.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbyoung.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbyoung.Location = new System.Drawing.Point(16, 48);
			this.cbyoung.Name = "cbyoung";
			this.cbyoung.Size = new System.Drawing.Size(88, 24);
			this.cbyoung.TabIndex = 26;
			this.cbyoung.Text = "young Adult";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbyoung, false);
			// 
			// cbteen
			// 
			this.cbteen.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbteen.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbteen.Location = new System.Drawing.Point(256, 24);
			this.cbteen.Name = "cbteen";
			this.cbteen.Size = new System.Drawing.Size(80, 24);
			this.cbteen.TabIndex = 25;
			this.cbteen.Text = "Teenager";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbteen, false);
			// 
			// cbchild
			// 
			this.cbchild.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbchild.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbchild.Location = new System.Drawing.Point(176, 24);
			this.cbchild.Name = "cbchild";
			this.cbchild.Size = new System.Drawing.Size(64, 24);
			this.cbchild.TabIndex = 24;
			this.cbchild.Text = "Child";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbchild, false);
			// 
			// cbtoddler
			// 
			this.cbtoddler.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbtoddler.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbtoddler.Location = new System.Drawing.Point(112, 24);
			this.cbtoddler.Name = "cbtoddler";
			this.cbtoddler.Size = new System.Drawing.Size(64, 24);
			this.cbtoddler.TabIndex = 23;
			this.cbtoddler.Text = "Toddler";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbtoddler, false);
			// 
			// cbbaby
			// 
			this.cbbaby.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbbaby.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbbaby.Location = new System.Drawing.Point(16, 24);
			this.cbbaby.Name = "cbbaby";
			this.cbbaby.Size = new System.Drawing.Size(64, 24);
			this.cbbaby.TabIndex = 22;
			this.cbbaby.Text = "Baby";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbaby, false);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.Location = new System.Drawing.Point(24, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Categories:";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label2, true);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ages:";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label1, true);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.pnep);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(400, 150);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "EP-Ready?";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage2, true);
			// 
			// pnep
			// 
			this.pnep.Controls.Add(this.tbname);
			this.pnep.Controls.Add(this.label3);
			this.pnep.Controls.Add(this.visualStyleLinkLabel1);
			this.pnep.Location = new System.Drawing.Point(24, 8);
			this.pnep.Name = "pnep";
			this.pnep.Size = new System.Drawing.Size(368, 72);
			this.pnep.TabIndex = 0;
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnep, true);
			// 
			// tbname
			// 
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbname.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbname.Location = new System.Drawing.Point(16, 24);
			this.tbname.Name = "tbname";
			this.tbname.Size = new System.Drawing.Size(152, 21);
			this.tbname.TabIndex = 40;
			this.tbname.Text = "SimPE-";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbname, true);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(128, 16);
			this.label3.TabIndex = 39;
			this.label3.Text = "Name Prefix:";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label3, true);
			// 
			// visualStyleLinkLabel1
			// 
			this.visualStyleLinkLabel1.AutoSize = true;
			this.visualStyleLinkLabel1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.visualStyleLinkLabel1.Location = new System.Drawing.Point(0, 56);
			this.visualStyleLinkLabel1.Name = "visualStyleLinkLabel1";
			this.visualStyleLinkLabel1.Size = new System.Drawing.Size(152, 17);
			this.visualStyleLinkLabel1.TabIndex = 38;
			this.visualStyleLinkLabel1.TabStop = true;
			this.visualStyleLinkLabel1.Text = "make University-Ready";
			this.visualStyleLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MakeEPReady);
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.pnskin);
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(400, 150);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Skin";
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage3, true);
			// 
			// pnskin
			// 
			this.pnskin.Controls.Add(this.cbtxtr);
			this.pnskin.Controls.Add(this.cbtxmt);
			this.pnskin.Controls.Add(this.cbskins);
			this.pnskin.Controls.Add(this.label4);
			this.pnskin.Controls.Add(this.visualStyleLinkLabel2);
			this.pnskin.Location = new System.Drawing.Point(24, 8);
			this.pnskin.Name = "pnskin";
			this.pnskin.Size = new System.Drawing.Size(368, 104);
			this.pnskin.TabIndex = 1;
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnskin, true);
			// 
			// cbtxtr
			// 
			this.cbtxtr.Checked = true;
			this.cbtxtr.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbtxtr.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbtxtr.Location = new System.Drawing.Point(136, 48);
			this.cbtxtr.Name = "cbtxtr";
			this.cbtxtr.TabIndex = 42;
			this.cbtxtr.Text = "override TXTR";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbtxtr, false);
			// 
			// cbtxmt
			// 
			this.cbtxmt.Checked = true;
			this.cbtxmt.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbtxmt.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbtxmt.Location = new System.Drawing.Point(16, 48);
			this.cbtxmt.Name = "cbtxmt";
			this.cbtxmt.Size = new System.Drawing.Size(112, 24);
			this.cbtxmt.TabIndex = 41;
			this.cbtxmt.Text = "override TXMT";
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbtxmt, false);
			// 
			// cbskins
			// 
			this.cbskins.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbskins.Items.AddRange(new object[] {
														 "Light",
														 "Normal",
														 "Medium",
														 "Dark"});
			this.cbskins.Location = new System.Drawing.Point(16, 24);
			this.cbskins.Name = "cbskins";
			this.cbskins.Size = new System.Drawing.Size(256, 21);
			this.cbskins.TabIndex = 40;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 8);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(128, 16);
			this.label4.TabIndex = 39;
			this.label4.Text = "Base Skin:";
			this.visualStyleProvider1.SetVisualStyleSupport(this.label4, true);
			// 
			// visualStyleLinkLabel2
			// 
			this.visualStyleLinkLabel2.AutoSize = true;
			this.visualStyleLinkLabel2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.visualStyleLinkLabel2.Location = new System.Drawing.Point(0, 80);
			this.visualStyleLinkLabel2.Name = "visualStyleLinkLabel2";
			this.visualStyleLinkLabel2.Size = new System.Drawing.Size(182, 17);
			this.visualStyleLinkLabel2.TabIndex = 38;
			this.visualStyleLinkLabel2.TabStop = true;
			this.visualStyleLinkLabel2.Text = "create default Skin override";
			this.visualStyleLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateSkinOverride);
			// 
			// sfd
			// 
			this.sfd.Filter = "Package File (*.package)|*.package|All Files (*.*)|*.*";
			this.sfd.Title = "Skin Override";
			// 
			// ScannerPanelForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(736, 357);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Name = "ScannerPanelForm";
			this.Text = "ScannerPanelForm";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.pncloth.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.pnep.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.pnskin.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		

		private void SetCat(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ClothingScanner cs = (ClothingScanner)pncloth.Tag;
			cs.SetCategory();
		}

		private void setAge(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ClothingScanner cs = (ClothingScanner)pncloth.Tag;
			cs.SetAge();
		}

		private void MakeEPReady(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			EPReadyScanner cs = (EPReadyScanner)pnep.Tag;
			cs.Fix(this.tbname.Text);
		}

		private void CreateSkinOverride(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (!cbtxtr.Checked && !cbtxmt.Checked) 
			{
				MessageBox.Show("Please select at least one Checkbox!");
				return;
			}

			if (sfd.ShowDialog()==DialogResult.OK) 
			{
				string skintone = "0000000"+(cbskins.SelectedIndex+1).ToString()+"-0000-0000-0000-000000000000";
				SkinScanner cs = (SkinScanner)pnskin.Tag;
				cs.CreateOverride(skintone, sfd.FileName, cbtxmt.Checked, cbtxtr.Checked);
			}
		}
	}
}
