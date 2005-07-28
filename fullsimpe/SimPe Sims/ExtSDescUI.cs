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
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using SimPe.Interfaces.Plugin;
using SimPe.Interfaces;
using SimPe.PackedFiles.Wrapper.Supporting;
using SimPe.Data;
using Ambertation.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtSDescUI.
	/// </summary>
	public class ExtSDesc : SimPe.Windows.Forms.WrapperBaseControl, IPackedFileUI
	{
		private TD.SandBar.ToolBar toolBar1;
		private TD.SandBar.ButtonItem biEP1;
		private TD.SandBar.ButtonItem biId;
		private TD.SandBar.ButtonItem biRel;
		private TD.SandBar.ButtonItem biInt;
		private TD.SandBar.ButtonItem biChar;
		private TD.SandBar.ButtonItem biSkill;
		private TD.SandBar.ButtonItem biMisc;
		private System.Windows.Forms.Panel pnId;
		internal System.Windows.Forms.TextBox tbsimdescfamname;
		internal System.Windows.Forms.TextBox tbfaminst;
		private System.Windows.Forms.Label label49;
		internal System.Windows.Forms.RadioButton rbmale;
		internal System.Windows.Forms.RadioButton rbfemale;
		private System.Windows.Forms.Label label48;
		internal System.Windows.Forms.ComboBox cblifesection;
		internal System.Windows.Forms.PictureBox pbImage;
		internal System.Windows.Forms.TextBox tbsimdescname;
		private System.Windows.Forms.Label label13;
		internal System.Windows.Forms.TextBox tbsim;
		internal System.Windows.Forms.TextBox tbage;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel pnSkill;
		private Ambertation.Windows.Forms.LabeledProgressBar pbRomance;
		private Ambertation.Windows.Forms.LabeledProgressBar pbFat;
		private Ambertation.Windows.Forms.LabeledProgressBar pbClean;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCreative;
		private Ambertation.Windows.Forms.LabeledProgressBar pbBody;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCharisma;
		private Ambertation.Windows.Forms.LabeledProgressBar pbMech;
		private Ambertation.Windows.Forms.LabeledProgressBar pbLogic;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCooking;
		private TD.SandBar.ButtonItem biMax;
		private System.Windows.Forms.Panel pnChar;
		internal System.Windows.Forms.ComboBox cbzodiac;
		private System.Windows.Forms.Label label47;
		private TD.SandBar.ButtonItem biCareer;
		private System.Windows.Forms.Panel pnCareer;
		internal System.Windows.Forms.TextBox tbschooltype;
		private System.Windows.Forms.Label label77;
		internal System.Windows.Forms.ComboBox cbgrade;
		internal System.Windows.Forms.ComboBox cbschooltype;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.Label label50;
		internal System.Windows.Forms.ComboBox cbcareer;
		internal System.Windows.Forms.TextBox tbcareervalue;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCareerLevel;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCareerPerformance;
		private Ambertation.Windows.Forms.LabeledProgressBar pbAspBliz;
		private System.Windows.Forms.Label label60;
		internal System.Windows.Forms.ComboBox cbaspiration;
		private Ambertation.Windows.Forms.LabeledProgressBar pbAspCur;
		private System.Windows.Forms.Label label46;
		internal System.Windows.Forms.TextBox tblifelinescore;
		private System.Windows.Forms.Panel pnInt;
		private System.Windows.Forms.Panel pnRel;
		private System.Windows.Forms.Panel pnMisc;
		private System.Windows.Forms.Panel pnEP1;
		private Ambertation.Windows.Forms.LabeledProgressBar pbPolitics;
		private Ambertation.Windows.Forms.LabeledProgressBar pbMoney;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCulture;
		private Ambertation.Windows.Forms.LabeledProgressBar pbEntertainment;
		private Ambertation.Windows.Forms.LabeledProgressBar pbEnvironment;
		private Ambertation.Windows.Forms.LabeledProgressBar pbFashion;
		private Ambertation.Windows.Forms.LabeledProgressBar pbFood;
		private Ambertation.Windows.Forms.LabeledProgressBar pbTravel;
		private Ambertation.Windows.Forms.LabeledProgressBar pbCrime;
		private Ambertation.Windows.Forms.LabeledProgressBar pbSports;
		private Ambertation.Windows.Forms.LabeledProgressBar pbAnimals;
		private Ambertation.Windows.Forms.LabeledProgressBar pbWeather;
		private Ambertation.Windows.Forms.LabeledProgressBar pbWork;
		private Ambertation.Windows.Forms.LabeledProgressBar pbSciFi;
		private Ambertation.Windows.Forms.LabeledProgressBar pbToys;
		private Ambertation.Windows.Forms.LabeledProgressBar pbSchool;
		private Ambertation.Windows.Forms.LabeledProgressBar pbHealth;
		private Ambertation.Windows.Forms.LabeledProgressBar pbParanormal;
		private Ambertation.Windows.Forms.LabeledProgressBar pbGNice;
		private Ambertation.Windows.Forms.LabeledProgressBar pbGPlayful;
		private Ambertation.Windows.Forms.LabeledProgressBar pbGActive;
		private Ambertation.Windows.Forms.LabeledProgressBar pbGOutgoing;
		private Ambertation.Windows.Forms.LabeledProgressBar pbGNeat;
		private Ambertation.Windows.Forms.LabeledProgressBar pbNice;
		private Ambertation.Windows.Forms.LabeledProgressBar pbPlayful;
		private Ambertation.Windows.Forms.LabeledProgressBar pbActive;
		private Ambertation.Windows.Forms.LabeledProgressBar pbOutgoing;
		private Ambertation.Windows.Forms.LabeledProgressBar pbNeat;
		private Ambertation.Windows.Forms.LabeledProgressBar pbWoman;
		private Ambertation.Windows.Forms.LabeledProgressBar pbMan;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Ambertation.Windows.Forms.TransparentCheckBox cbignoretraversal;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpasspeople;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpasswalls;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpassobject;
		private Ambertation.Windows.Forms.TransparentCheckBox cbisghost;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple1;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfit;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpreginv;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpreghalf;
		private Ambertation.Windows.Forms.TransparentCheckBox cbpregfull;
		private Ambertation.Windows.Forms.TransparentCheckBox cbfat;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple2;
		private Ambertation.Windows.Forms.XPTaskBoxSimple xpTaskBoxSimple3;
		private System.Windows.Forms.Label label96;
		internal System.Windows.Forms.TextBox tbunlinked;
		private System.Windows.Forms.Label label95;
		internal System.Windows.Forms.TextBox tbagedur;
		internal System.Windows.Forms.TextBox tbprevdays;
		private System.Windows.Forms.Label label94;
		internal System.Windows.Forms.TextBox tbvoice;
		private System.Windows.Forms.Label label90;
		internal System.Windows.Forms.TextBox tbnpc;
		private System.Windows.Forms.Label label87;
		internal System.Windows.Forms.TextBox tbautonomy;
		private System.Windows.Forms.Label label86;
		private TD.SandBar.ButtonItem biMore;
		internal System.Windows.Forms.TextBox tbinfluence;
		internal System.Windows.Forms.TextBox tbsemester;
		internal System.Windows.Forms.Label label103;
		internal System.Windows.Forms.Label label101;
		internal Ambertation.Windows.Forms.TransparentCheckBox cboncampus;
		internal System.Windows.Forms.ComboBox cbmajor;
		internal System.Windows.Forms.Label label98;
		internal System.Windows.Forms.TextBox tbmajor;
		private Ambertation.Windows.Forms.LabeledProgressBar pbLastGrade;
		private Ambertation.Windows.Forms.LabeledProgressBar pbEffort;
		private Ambertation.Windows.Forms.LabeledProgressBar pbUniTime;
		/// <summary> 
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		
		public ExtSDesc()
		{
			Text = SimPe.Localization.GetString("Sim Description Editor");
			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();	
		
			ThemeManager.AddControl(this.toolBar1);
			//ThemeManager.AddControl(this.pnId);
			this.biId.Tag = pnId;	
			this.biSkill.Tag = pnSkill;
			this.biChar.Tag = pnChar;
			this.biCareer.Tag = pnCareer;
			this.biEP1.Tag = pnEP1;
			this.biInt.Tag = pnInt;
			this.biRel.Tag = pnRel;
			this.biMisc.Tag = pnMisc;
		
			InitDropDowns();
			SelectButton(biId);
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

		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExtSDesc));
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biId = new TD.SandBar.ButtonItem();
			this.biCareer = new TD.SandBar.ButtonItem();
			this.biRel = new TD.SandBar.ButtonItem();
			this.biInt = new TD.SandBar.ButtonItem();
			this.biChar = new TD.SandBar.ButtonItem();
			this.biSkill = new TD.SandBar.ButtonItem();
			this.biMisc = new TD.SandBar.ButtonItem();
			this.biEP1 = new TD.SandBar.ButtonItem();
			this.biMore = new TD.SandBar.ButtonItem();
			this.biMax = new TD.SandBar.ButtonItem();
			this.pnId = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tbsimdescfamname = new System.Windows.Forms.TextBox();
			this.tbfaminst = new System.Windows.Forms.TextBox();
			this.label49 = new System.Windows.Forms.Label();
			this.rbmale = new System.Windows.Forms.RadioButton();
			this.rbfemale = new System.Windows.Forms.RadioButton();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.tbsimdescname = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tbsim = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.tbage = new System.Windows.Forms.TextBox();
			this.label48 = new System.Windows.Forms.Label();
			this.cblifesection = new System.Windows.Forms.ComboBox();
			this.pnSkill = new System.Windows.Forms.Panel();
			this.pbRomance = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbFat = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbClean = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCreative = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbBody = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCharisma = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbMech = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbLogic = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCooking = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pnChar = new System.Windows.Forms.Panel();
			this.pbMan = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbWoman = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbGNice = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbGPlayful = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbGActive = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbGOutgoing = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbGNeat = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbNice = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbPlayful = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbActive = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbOutgoing = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbNeat = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.cbzodiac = new System.Windows.Forms.ComboBox();
			this.label47 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label69 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label70 = new System.Windows.Forms.Label();
			this.pnCareer = new System.Windows.Forms.Panel();
			this.pbAspBliz = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.label60 = new System.Windows.Forms.Label();
			this.cbaspiration = new System.Windows.Forms.ComboBox();
			this.pbAspCur = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.label46 = new System.Windows.Forms.Label();
			this.tblifelinescore = new System.Windows.Forms.TextBox();
			this.pbCareerPerformance = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCareerLevel = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.label78 = new System.Windows.Forms.Label();
			this.tbschooltype = new System.Windows.Forms.TextBox();
			this.label77 = new System.Windows.Forms.Label();
			this.cbgrade = new System.Windows.Forms.ComboBox();
			this.cbschooltype = new System.Windows.Forms.ComboBox();
			this.label50 = new System.Windows.Forms.Label();
			this.cbcareer = new System.Windows.Forms.ComboBox();
			this.tbcareervalue = new System.Windows.Forms.TextBox();
			this.pnInt = new System.Windows.Forms.Panel();
			this.pbSciFi = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbToys = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbSchool = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbAnimals = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbWeather = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbWork = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbTravel = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCrime = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbSports = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbFashion = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbHealth = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbFood = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbPolitics = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbMoney = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbCulture = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbEntertainment = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbParanormal = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbEnvironment = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pnRel = new System.Windows.Forms.Panel();
			this.pnMisc = new System.Windows.Forms.Panel();
			this.xpTaskBoxSimple3 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.label96 = new System.Windows.Forms.Label();
			this.tbunlinked = new System.Windows.Forms.TextBox();
			this.label95 = new System.Windows.Forms.Label();
			this.tbagedur = new System.Windows.Forms.TextBox();
			this.tbprevdays = new System.Windows.Forms.TextBox();
			this.label94 = new System.Windows.Forms.Label();
			this.tbvoice = new System.Windows.Forms.TextBox();
			this.label90 = new System.Windows.Forms.Label();
			this.tbnpc = new System.Windows.Forms.TextBox();
			this.label87 = new System.Windows.Forms.Label();
			this.tbautonomy = new System.Windows.Forms.TextBox();
			this.label86 = new System.Windows.Forms.Label();
			this.xpTaskBoxSimple2 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.cbfit = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpreginv = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpreghalf = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpregfull = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbfat = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.xpTaskBoxSimple1 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.cbisghost = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbignoretraversal = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpasspeople = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpasswalls = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbpassobject = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.pnEP1 = new System.Windows.Forms.Panel();
			this.pbLastGrade = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbUniTime = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.pbEffort = new Ambertation.Windows.Forms.LabeledProgressBar();
			this.tbinfluence = new System.Windows.Forms.TextBox();
			this.tbsemester = new System.Windows.Forms.TextBox();
			this.label103 = new System.Windows.Forms.Label();
			this.label101 = new System.Windows.Forms.Label();
			this.cboncampus = new Ambertation.Windows.Forms.TransparentCheckBox();
			this.cbmajor = new System.Windows.Forms.ComboBox();
			this.label98 = new System.Windows.Forms.Label();
			this.tbmajor = new System.Windows.Forms.TextBox();
			this.pnId.SuspendLayout();
			this.pnSkill.SuspendLayout();
			this.pnChar.SuspendLayout();
			this.pnCareer.SuspendLayout();
			this.pnInt.SuspendLayout();
			this.pnMisc.SuspendLayout();
			this.xpTaskBoxSimple3.SuspendLayout();
			this.xpTaskBoxSimple2.SuspendLayout();
			this.xpTaskBoxSimple1.SuspendLayout();
			this.pnEP1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.FlipLastItem = true;
			this.toolBar1.Guid = new System.Guid("c26fb528-33c1-46f9-bd39-8516b25c4289");
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biId,
																			  this.biCareer,
																			  this.biRel,
																			  this.biInt,
																			  this.biChar,
																			  this.biSkill,
																			  this.biMisc,
																			  this.biEP1,
																			  this.biMore,
																			  this.biMax});
			this.toolBar1.Location = new System.Drawing.Point(0, 24);
			this.toolBar1.Movable = false;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Resizable = false;
			this.toolBar1.Size = new System.Drawing.Size(696, 54);
			this.toolBar1.TabIndex = 1;
			this.toolBar1.Tearable = false;
			this.toolBar1.Text = "toolBar1";
			this.toolBar1.TextAlign = TD.SandBar.ToolBarTextAlign.Underneath;
			this.toolBar1.Renderer = new TD.SandBar.MediaPlayerRenderer();
			// 
			// biId
			// 
			this.biId.Image = ((System.Drawing.Image)(resources.GetObject("biId.Image")));
			this.biId.Text = "Overview";
			this.biId.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biCareer
			// 
			this.biCareer.Image = ((System.Drawing.Image)(resources.GetObject("biCareer.Image")));
			this.biCareer.Text = "Career";
			this.biCareer.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biRel
			// 
			this.biRel.Image = ((System.Drawing.Image)(resources.GetObject("biRel.Image")));
			this.biRel.Text = "Relations";
			this.biRel.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biInt
			// 
			this.biInt.Image = ((System.Drawing.Image)(resources.GetObject("biInt.Image")));
			this.biInt.Text = "Interests";
			this.biInt.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biChar
			// 
			this.biChar.Image = ((System.Drawing.Image)(resources.GetObject("biChar.Image")));
			this.biChar.Text = "Character";
			this.biChar.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biSkill
			// 
			this.biSkill.Image = ((System.Drawing.Image)(resources.GetObject("biSkill.Image")));
			this.biSkill.Text = "Skills";
			this.biSkill.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biMisc
			// 
			this.biMisc.Image = ((System.Drawing.Image)(resources.GetObject("biMisc.Image")));
			this.biMisc.Text = "Other";
			this.biMisc.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biEP1
			// 
			this.biEP1.Enabled = false;
			this.biEP1.Image = ((System.Drawing.Image)(resources.GetObject("biEP1.Image")));
			this.biEP1.Text = "University";
			this.biEP1.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biMore
			// 
			this.biMore.Image = ((System.Drawing.Image)(resources.GetObject("biMore.Image")));
			this.biMore.Text = "More";
			this.biMore.Activate += new System.EventHandler(this.Activate_biMore);
			// 
			// biMax
			// 
			this.biMax.Image = ((System.Drawing.Image)(resources.GetObject("biMax.Image")));
			this.biMax.Text = "Maximize";
			this.biMax.ToolTipText = "Maximize all displayed Values";
			this.biMax.Activate += new System.EventHandler(this.Activate_biMax);
			// 
			// pnId
			// 
			this.pnId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnId.BackColor = System.Drawing.Color.Transparent;
			this.pnId.Controls.Add(this.label2);
			this.pnId.Controls.Add(this.label1);
			this.pnId.Controls.Add(this.tbsimdescfamname);
			this.pnId.Controls.Add(this.tbfaminst);
			this.pnId.Controls.Add(this.label49);
			this.pnId.Controls.Add(this.rbmale);
			this.pnId.Controls.Add(this.rbfemale);
			this.pnId.Controls.Add(this.pbImage);
			this.pnId.Controls.Add(this.tbsimdescname);
			this.pnId.Controls.Add(this.label13);
			this.pnId.Controls.Add(this.tbsim);
			this.pnId.Controls.Add(this.label10);
			this.pnId.Controls.Add(this.tbage);
			this.pnId.Controls.Add(this.label48);
			this.pnId.Controls.Add(this.cblifesection);
			this.pnId.Location = new System.Drawing.Point(0, 80);
			this.pnId.Name = "pnId";
			this.pnId.Size = new System.Drawing.Size(696, 264);
			this.pnId.TabIndex = 2;
			this.pnId.Visible = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label2.Location = new System.Drawing.Point(120, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(96, 17);
			this.label2.TabIndex = 54;
			this.label2.Text = "Sim ID:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label1.Location = new System.Drawing.Point(112, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 17);
			this.label1.TabIndex = 53;
			this.label1.Text = "Failiy Instance:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbsimdescfamname
			// 
			this.tbsimdescfamname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbsimdescfamname.Location = new System.Drawing.Point(448, 40);
			this.tbsimdescfamname.Name = "tbsimdescfamname";
			this.tbsimdescfamname.Size = new System.Drawing.Size(216, 21);
			this.tbsimdescfamname.TabIndex = 52;
			this.tbsimdescfamname.Text = "";
			// 
			// tbfaminst
			// 
			this.tbfaminst.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbfaminst.Location = new System.Drawing.Point(224, 64);
			this.tbfaminst.Name = "tbfaminst";
			this.tbfaminst.Size = new System.Drawing.Size(56, 21);
			this.tbfaminst.TabIndex = 51;
			this.tbfaminst.Text = "";
			// 
			// label49
			// 
			this.label49.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label49.Location = new System.Drawing.Point(144, 96);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(72, 17);
			this.label49.TabIndex = 49;
			this.label49.Text = "Treat as:";
			this.label49.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// rbmale
			// 
			this.rbmale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbmale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbmale.Location = new System.Drawing.Point(296, 96);
			this.rbmale.Name = "rbmale";
			this.rbmale.Size = new System.Drawing.Size(48, 16);
			this.rbmale.TabIndex = 48;
			this.rbmale.Text = "Male";
			// 
			// rbfemale
			// 
			this.rbfemale.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.rbfemale.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.rbfemale.Location = new System.Drawing.Point(224, 96);
			this.rbfemale.Name = "rbfemale";
			this.rbfemale.Size = new System.Drawing.Size(64, 16);
			this.rbfemale.TabIndex = 47;
			this.rbfemale.Text = "Female";
			// 
			// pbImage
			// 
			this.pbImage.BackColor = System.Drawing.Color.Transparent;
			this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
			this.pbImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.pbImage.Location = new System.Drawing.Point(8, 8);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(104, 96);
			this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbImage.TabIndex = 41;
			this.pbImage.TabStop = false;
			// 
			// tbsimdescname
			// 
			this.tbsimdescname.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbsimdescname.Location = new System.Drawing.Point(224, 40);
			this.tbsimdescname.Name = "tbsimdescname";
			this.tbsimdescname.Size = new System.Drawing.Size(216, 21);
			this.tbsimdescname.TabIndex = 40;
			this.tbsimdescname.Text = "";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label13.Location = new System.Drawing.Point(120, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(96, 17);
			this.label13.TabIndex = 39;
			this.label13.Text = "Name:";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbsim
			// 
			this.tbsim.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbsim.Location = new System.Drawing.Point(224, 16);
			this.tbsim.Name = "tbsim";
			this.tbsim.Size = new System.Drawing.Size(104, 21);
			this.tbsim.TabIndex = 38;
			this.tbsim.Text = "";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label10.Location = new System.Drawing.Point(8, 168);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(112, 17);
			this.label10.TabIndex = 36;
			this.label10.Text = "Remaining Days:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbage
			// 
			this.tbage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbage.Location = new System.Drawing.Point(128, 160);
			this.tbage.Name = "tbage";
			this.tbage.Size = new System.Drawing.Size(56, 21);
			this.tbage.TabIndex = 37;
			this.tbage.Text = "";
			// 
			// label48
			// 
			this.label48.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label48.Location = new System.Drawing.Point(8, 144);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(112, 17);
			this.label48.TabIndex = 46;
			this.label48.Text = "Life Section:";
			this.label48.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cblifesection
			// 
			this.cblifesection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cblifesection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cblifesection.ItemHeight = 13;
			this.cblifesection.Location = new System.Drawing.Point(128, 136);
			this.cblifesection.Name = "cblifesection";
			this.cblifesection.Size = new System.Drawing.Size(160, 21);
			this.cblifesection.TabIndex = 45;
			// 
			// pnSkill
			// 
			this.pnSkill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnSkill.BackColor = System.Drawing.Color.Transparent;
			this.pnSkill.Controls.Add(this.pbRomance);
			this.pnSkill.Controls.Add(this.pbFat);
			this.pnSkill.Controls.Add(this.pbClean);
			this.pnSkill.Controls.Add(this.pbCreative);
			this.pnSkill.Controls.Add(this.pbBody);
			this.pnSkill.Controls.Add(this.pbCharisma);
			this.pnSkill.Controls.Add(this.pbMech);
			this.pnSkill.Controls.Add(this.pbLogic);
			this.pnSkill.Controls.Add(this.pbCooking);
			this.pnSkill.Location = new System.Drawing.Point(0, 80);
			this.pnSkill.Name = "pnSkill";
			this.pnSkill.Size = new System.Drawing.Size(696, 264);
			this.pnSkill.TabIndex = 3;
			this.pnSkill.Visible = false;
			// 
			// pbRomance
			// 
			this.pbRomance.BackColor = System.Drawing.Color.Transparent;
			this.pbRomance.DisplayOffset = 0;
			this.pbRomance.DockPadding.Bottom = 5;
			this.pbRomance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbRomance.LabelText = "Romance:";
			this.pbRomance.LabelWidth = 80;
			this.pbRomance.Location = new System.Drawing.Point(8, 168);
			this.pbRomance.Maximum = 1000;
			this.pbRomance.Name = "pbRomance";
			this.pbRomance.NumberFormat = "N1";
			this.pbRomance.NumberOffset = 0;
			this.pbRomance.NumberScale = 0.01;
			this.pbRomance.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbRomance.Size = new System.Drawing.Size(328, 32);
			this.pbRomance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbRomance.TabIndex = 8;
			this.pbRomance.TextboxWidth = 40;
			this.pbRomance.TokenCount = 10;
			this.pbRomance.UnselectedColor = System.Drawing.Color.Black;
			this.pbRomance.Value = 500;
			// 
			// pbFat
			// 
			this.pbFat.BackColor = System.Drawing.Color.Transparent;
			this.pbFat.DisplayOffset = 0;
			this.pbFat.DockPadding.Bottom = 5;
			this.pbFat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbFat.LabelText = "Fatness:";
			this.pbFat.LabelWidth = 80;
			this.pbFat.Location = new System.Drawing.Point(352, 168);
			this.pbFat.Maximum = 1000;
			this.pbFat.Name = "pbFat";
			this.pbFat.NumberFormat = "N1";
			this.pbFat.NumberOffset = 0;
			this.pbFat.NumberScale = 0.01;
			this.pbFat.SelectedColor = System.Drawing.Color.Orange;
			this.pbFat.Size = new System.Drawing.Size(328, 32);
			this.pbFat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFat.TabIndex = 7;
			this.pbFat.TextboxWidth = 40;
			this.pbFat.TokenCount = 10;
			this.pbFat.UnselectedColor = System.Drawing.Color.Black;
			this.pbFat.Value = 500;
			// 
			// pbClean
			// 
			this.pbClean.BackColor = System.Drawing.Color.Transparent;
			this.pbClean.DisplayOffset = 0;
			this.pbClean.DockPadding.Bottom = 5;
			this.pbClean.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbClean.LabelText = "Cleaning:";
			this.pbClean.LabelWidth = 80;
			this.pbClean.Location = new System.Drawing.Point(352, 80);
			this.pbClean.Maximum = 1000;
			this.pbClean.Name = "pbClean";
			this.pbClean.NumberFormat = "N2";
			this.pbClean.NumberOffset = 0;
			this.pbClean.NumberScale = 0.01;
			this.pbClean.SelectedColor = System.Drawing.Color.Lime;
			this.pbClean.Size = new System.Drawing.Size(328, 24);
			this.pbClean.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbClean.TabIndex = 6;
			this.pbClean.TextboxWidth = 40;
			this.pbClean.TokenCount = 21;
			this.pbClean.UnselectedColor = System.Drawing.Color.Black;
			this.pbClean.Value = 500;
			// 
			// pbCreative
			// 
			this.pbCreative.BackColor = System.Drawing.Color.Transparent;
			this.pbCreative.DisplayOffset = 0;
			this.pbCreative.DockPadding.Bottom = 5;
			this.pbCreative.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCreative.LabelText = "Creativity:";
			this.pbCreative.LabelWidth = 80;
			this.pbCreative.Location = new System.Drawing.Point(352, 48);
			this.pbCreative.Maximum = 1000;
			this.pbCreative.Name = "pbCreative";
			this.pbCreative.NumberFormat = "N2";
			this.pbCreative.NumberOffset = 0;
			this.pbCreative.NumberScale = 0.01;
			this.pbCreative.SelectedColor = System.Drawing.Color.Lime;
			this.pbCreative.Size = new System.Drawing.Size(328, 24);
			this.pbCreative.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCreative.TabIndex = 5;
			this.pbCreative.TextboxWidth = 40;
			this.pbCreative.TokenCount = 21;
			this.pbCreative.UnselectedColor = System.Drawing.Color.Black;
			this.pbCreative.Value = 500;
			// 
			// pbBody
			// 
			this.pbBody.BackColor = System.Drawing.Color.Transparent;
			this.pbBody.DisplayOffset = 0;
			this.pbBody.DockPadding.Bottom = 5;
			this.pbBody.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbBody.LabelText = "Body:";
			this.pbBody.LabelWidth = 80;
			this.pbBody.Location = new System.Drawing.Point(8, 112);
			this.pbBody.Maximum = 1000;
			this.pbBody.Name = "pbBody";
			this.pbBody.NumberFormat = "N2";
			this.pbBody.NumberOffset = 0;
			this.pbBody.NumberScale = 0.01;
			this.pbBody.SelectedColor = System.Drawing.Color.Lime;
			this.pbBody.Size = new System.Drawing.Size(328, 24);
			this.pbBody.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbBody.TabIndex = 4;
			this.pbBody.TextboxWidth = 40;
			this.pbBody.TokenCount = 21;
			this.pbBody.UnselectedColor = System.Drawing.Color.Black;
			this.pbBody.Value = 500;
			// 
			// pbCharisma
			// 
			this.pbCharisma.BackColor = System.Drawing.Color.Transparent;
			this.pbCharisma.DisplayOffset = 0;
			this.pbCharisma.DockPadding.Bottom = 5;
			this.pbCharisma.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCharisma.LabelText = "Charisma:";
			this.pbCharisma.LabelWidth = 80;
			this.pbCharisma.Location = new System.Drawing.Point(8, 80);
			this.pbCharisma.Maximum = 1000;
			this.pbCharisma.Name = "pbCharisma";
			this.pbCharisma.NumberFormat = "N2";
			this.pbCharisma.NumberOffset = 0;
			this.pbCharisma.NumberScale = 0.01;
			this.pbCharisma.SelectedColor = System.Drawing.Color.Lime;
			this.pbCharisma.Size = new System.Drawing.Size(328, 24);
			this.pbCharisma.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCharisma.TabIndex = 3;
			this.pbCharisma.TextboxWidth = 40;
			this.pbCharisma.TokenCount = 21;
			this.pbCharisma.UnselectedColor = System.Drawing.Color.Black;
			this.pbCharisma.Value = 500;
			// 
			// pbMech
			// 
			this.pbMech.BackColor = System.Drawing.Color.Transparent;
			this.pbMech.DisplayOffset = 0;
			this.pbMech.DockPadding.Bottom = 5;
			this.pbMech.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbMech.LabelText = "Mechanical:";
			this.pbMech.LabelWidth = 80;
			this.pbMech.Location = new System.Drawing.Point(8, 48);
			this.pbMech.Maximum = 1000;
			this.pbMech.Name = "pbMech";
			this.pbMech.NumberFormat = "N2";
			this.pbMech.NumberOffset = 0;
			this.pbMech.NumberScale = 0.01;
			this.pbMech.SelectedColor = System.Drawing.Color.Lime;
			this.pbMech.Size = new System.Drawing.Size(328, 24);
			this.pbMech.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbMech.TabIndex = 2;
			this.pbMech.TextboxWidth = 40;
			this.pbMech.TokenCount = 21;
			this.pbMech.UnselectedColor = System.Drawing.Color.Black;
			this.pbMech.Value = 500;
			// 
			// pbLogic
			// 
			this.pbLogic.BackColor = System.Drawing.Color.Transparent;
			this.pbLogic.DisplayOffset = 0;
			this.pbLogic.DockPadding.Bottom = 5;
			this.pbLogic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbLogic.LabelText = "Logic:";
			this.pbLogic.LabelWidth = 80;
			this.pbLogic.Location = new System.Drawing.Point(352, 16);
			this.pbLogic.Maximum = 1000;
			this.pbLogic.Name = "pbLogic";
			this.pbLogic.NumberFormat = "N2";
			this.pbLogic.NumberOffset = 0;
			this.pbLogic.NumberScale = 0.01;
			this.pbLogic.SelectedColor = System.Drawing.Color.Lime;
			this.pbLogic.Size = new System.Drawing.Size(328, 24);
			this.pbLogic.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbLogic.TabIndex = 1;
			this.pbLogic.TextboxWidth = 40;
			this.pbLogic.TokenCount = 21;
			this.pbLogic.UnselectedColor = System.Drawing.Color.Black;
			this.pbLogic.Value = 500;
			// 
			// pbCooking
			// 
			this.pbCooking.BackColor = System.Drawing.Color.Transparent;
			this.pbCooking.DisplayOffset = 0;
			this.pbCooking.DockPadding.Bottom = 5;
			this.pbCooking.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCooking.LabelText = "Cooking:";
			this.pbCooking.LabelWidth = 80;
			this.pbCooking.Location = new System.Drawing.Point(8, 16);
			this.pbCooking.Maximum = 1000;
			this.pbCooking.Name = "pbCooking";
			this.pbCooking.NumberFormat = "N2";
			this.pbCooking.NumberOffset = 0;
			this.pbCooking.NumberScale = 0.01;
			this.pbCooking.SelectedColor = System.Drawing.Color.Lime;
			this.pbCooking.Size = new System.Drawing.Size(328, 24);
			this.pbCooking.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCooking.TabIndex = 0;
			this.pbCooking.TextboxWidth = 40;
			this.pbCooking.TokenCount = 21;
			this.pbCooking.UnselectedColor = System.Drawing.Color.Black;
			this.pbCooking.Value = 500;
			// 
			// pnChar
			// 
			this.pnChar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnChar.BackColor = System.Drawing.Color.Transparent;
			this.pnChar.Controls.Add(this.pbMan);
			this.pnChar.Controls.Add(this.pbWoman);
			this.pnChar.Controls.Add(this.pbGNice);
			this.pnChar.Controls.Add(this.pbGPlayful);
			this.pnChar.Controls.Add(this.pbGActive);
			this.pnChar.Controls.Add(this.pbGOutgoing);
			this.pnChar.Controls.Add(this.pbGNeat);
			this.pnChar.Controls.Add(this.pbNice);
			this.pnChar.Controls.Add(this.pbPlayful);
			this.pnChar.Controls.Add(this.pbActive);
			this.pnChar.Controls.Add(this.pbOutgoing);
			this.pnChar.Controls.Add(this.pbNeat);
			this.pnChar.Controls.Add(this.cbzodiac);
			this.pnChar.Controls.Add(this.label47);
			this.pnChar.Controls.Add(this.panel2);
			this.pnChar.Controls.Add(this.label69);
			this.pnChar.Controls.Add(this.panel1);
			this.pnChar.Controls.Add(this.label70);
			this.pnChar.Location = new System.Drawing.Point(0, 80);
			this.pnChar.Name = "pnChar";
			this.pnChar.Size = new System.Drawing.Size(696, 264);
			this.pnChar.TabIndex = 4;
			this.pnChar.Visible = false;
			// 
			// pbMan
			// 
			this.pbMan.BackColor = System.Drawing.Color.Transparent;
			this.pbMan.DisplayOffset = 0;
			this.pbMan.DockPadding.Bottom = 5;
			this.pbMan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbMan.LabelText = "Man:";
			this.pbMan.LabelWidth = 80;
			this.pbMan.Location = new System.Drawing.Point(8, 208);
			this.pbMan.Maximum = 2000;
			this.pbMan.Name = "pbMan";
			this.pbMan.NumberFormat = "N1";
			this.pbMan.NumberOffset = -1000;
			this.pbMan.NumberScale = 0.01;
			this.pbMan.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbMan.Size = new System.Drawing.Size(536, 24);
			this.pbMan.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
			this.pbMan.TabIndex = 74;
			this.pbMan.TextboxWidth = 40;
			this.pbMan.TokenCount = 19;
			this.pbMan.UnselectedColor = System.Drawing.Color.Black;
			this.pbMan.Value = 0;
			// 
			// pbWoman
			// 
			this.pbWoman.BackColor = System.Drawing.Color.Transparent;
			this.pbWoman.DisplayOffset = 0;
			this.pbWoman.DockPadding.Bottom = 5;
			this.pbWoman.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbWoman.LabelText = "Woman:";
			this.pbWoman.LabelWidth = 80;
			this.pbWoman.Location = new System.Drawing.Point(8, 184);
			this.pbWoman.Maximum = 2000;
			this.pbWoman.Name = "pbWoman";
			this.pbWoman.NumberFormat = "N1";
			this.pbWoman.NumberOffset = -1000;
			this.pbWoman.NumberScale = 0.01;
			this.pbWoman.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbWoman.Size = new System.Drawing.Size(536, 24);
			this.pbWoman.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
			this.pbWoman.TabIndex = 73;
			this.pbWoman.TextboxWidth = 40;
			this.pbWoman.TokenCount = 19;
			this.pbWoman.UnselectedColor = System.Drawing.Color.Black;
			this.pbWoman.Value = 0;
			// 
			// pbGNice
			// 
			this.pbGNice.BackColor = System.Drawing.Color.Transparent;
			this.pbGNice.DisplayOffset = 0;
			this.pbGNice.DockPadding.Bottom = 5;
			this.pbGNice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbGNice.LabelText = "Genetic Nice:";
			this.pbGNice.LabelWidth = 110;
			this.pbGNice.Location = new System.Drawing.Point(272, 152);
			this.pbGNice.Maximum = 1000;
			this.pbGNice.Name = "pbGNice";
			this.pbGNice.NumberFormat = "N1";
			this.pbGNice.NumberOffset = 0;
			this.pbGNice.NumberScale = 0.01;
			this.pbGNice.SelectedColor = System.Drawing.Color.Lime;
			this.pbGNice.Size = new System.Drawing.Size(272, 20);
			this.pbGNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGNice.TabIndex = 72;
			this.pbGNice.TextboxWidth = 40;
			this.pbGNice.TokenCount = 10;
			this.pbGNice.UnselectedColor = System.Drawing.Color.Black;
			this.pbGNice.Value = 50;
			// 
			// pbGPlayful
			// 
			this.pbGPlayful.BackColor = System.Drawing.Color.Transparent;
			this.pbGPlayful.DisplayOffset = 0;
			this.pbGPlayful.DockPadding.Bottom = 5;
			this.pbGPlayful.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbGPlayful.LabelText = "Genetic Playful:";
			this.pbGPlayful.LabelWidth = 110;
			this.pbGPlayful.Location = new System.Drawing.Point(272, 128);
			this.pbGPlayful.Maximum = 1000;
			this.pbGPlayful.Name = "pbGPlayful";
			this.pbGPlayful.NumberFormat = "N1";
			this.pbGPlayful.NumberOffset = 0;
			this.pbGPlayful.NumberScale = 0.01;
			this.pbGPlayful.SelectedColor = System.Drawing.Color.Lime;
			this.pbGPlayful.Size = new System.Drawing.Size(272, 20);
			this.pbGPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGPlayful.TabIndex = 71;
			this.pbGPlayful.TextboxWidth = 40;
			this.pbGPlayful.TokenCount = 10;
			this.pbGPlayful.UnselectedColor = System.Drawing.Color.Black;
			this.pbGPlayful.Value = 50;
			// 
			// pbGActive
			// 
			this.pbGActive.BackColor = System.Drawing.Color.Transparent;
			this.pbGActive.DisplayOffset = 0;
			this.pbGActive.DockPadding.Bottom = 5;
			this.pbGActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbGActive.LabelText = "Genetic Active:";
			this.pbGActive.LabelWidth = 110;
			this.pbGActive.Location = new System.Drawing.Point(272, 104);
			this.pbGActive.Maximum = 1000;
			this.pbGActive.Name = "pbGActive";
			this.pbGActive.NumberFormat = "N1";
			this.pbGActive.NumberOffset = 0;
			this.pbGActive.NumberScale = 0.01;
			this.pbGActive.SelectedColor = System.Drawing.Color.Lime;
			this.pbGActive.Size = new System.Drawing.Size(272, 20);
			this.pbGActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGActive.TabIndex = 70;
			this.pbGActive.TextboxWidth = 40;
			this.pbGActive.TokenCount = 10;
			this.pbGActive.UnselectedColor = System.Drawing.Color.Black;
			this.pbGActive.Value = 50;
			// 
			// pbGOutgoing
			// 
			this.pbGOutgoing.BackColor = System.Drawing.Color.Transparent;
			this.pbGOutgoing.DisplayOffset = 0;
			this.pbGOutgoing.DockPadding.Bottom = 5;
			this.pbGOutgoing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbGOutgoing.LabelText = "Genetic Outgoing:";
			this.pbGOutgoing.LabelWidth = 110;
			this.pbGOutgoing.Location = new System.Drawing.Point(272, 80);
			this.pbGOutgoing.Maximum = 1000;
			this.pbGOutgoing.Name = "pbGOutgoing";
			this.pbGOutgoing.NumberFormat = "N1";
			this.pbGOutgoing.NumberOffset = 0;
			this.pbGOutgoing.NumberScale = 0.01;
			this.pbGOutgoing.SelectedColor = System.Drawing.Color.Lime;
			this.pbGOutgoing.Size = new System.Drawing.Size(272, 20);
			this.pbGOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGOutgoing.TabIndex = 69;
			this.pbGOutgoing.TextboxWidth = 40;
			this.pbGOutgoing.TokenCount = 10;
			this.pbGOutgoing.UnselectedColor = System.Drawing.Color.Black;
			this.pbGOutgoing.Value = 50;
			// 
			// pbGNeat
			// 
			this.pbGNeat.BackColor = System.Drawing.Color.Transparent;
			this.pbGNeat.DisplayOffset = 0;
			this.pbGNeat.DockPadding.Bottom = 5;
			this.pbGNeat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbGNeat.LabelText = "Genetic Neat:";
			this.pbGNeat.LabelWidth = 110;
			this.pbGNeat.Location = new System.Drawing.Point(272, 56);
			this.pbGNeat.Maximum = 1000;
			this.pbGNeat.Name = "pbGNeat";
			this.pbGNeat.NumberFormat = "N1";
			this.pbGNeat.NumberOffset = 0;
			this.pbGNeat.NumberScale = 0.01;
			this.pbGNeat.SelectedColor = System.Drawing.Color.Lime;
			this.pbGNeat.Size = new System.Drawing.Size(272, 20);
			this.pbGNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGNeat.TabIndex = 68;
			this.pbGNeat.TextboxWidth = 40;
			this.pbGNeat.TokenCount = 10;
			this.pbGNeat.UnselectedColor = System.Drawing.Color.Black;
			this.pbGNeat.Value = 50;
			// 
			// pbNice
			// 
			this.pbNice.BackColor = System.Drawing.Color.Transparent;
			this.pbNice.DisplayOffset = 0;
			this.pbNice.DockPadding.Bottom = 5;
			this.pbNice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbNice.LabelText = "Nice:";
			this.pbNice.LabelWidth = 80;
			this.pbNice.Location = new System.Drawing.Point(8, 152);
			this.pbNice.Maximum = 1000;
			this.pbNice.Name = "pbNice";
			this.pbNice.NumberFormat = "N1";
			this.pbNice.NumberOffset = 0;
			this.pbNice.NumberScale = 0.01;
			this.pbNice.SelectedColor = System.Drawing.Color.Lime;
			this.pbNice.Size = new System.Drawing.Size(240, 20);
			this.pbNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbNice.TabIndex = 67;
			this.pbNice.TextboxWidth = 40;
			this.pbNice.TokenCount = 10;
			this.pbNice.UnselectedColor = System.Drawing.Color.Black;
			this.pbNice.Value = 50;
			// 
			// pbPlayful
			// 
			this.pbPlayful.BackColor = System.Drawing.Color.Transparent;
			this.pbPlayful.DisplayOffset = 0;
			this.pbPlayful.DockPadding.Bottom = 5;
			this.pbPlayful.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbPlayful.LabelText = "Playful:";
			this.pbPlayful.LabelWidth = 80;
			this.pbPlayful.Location = new System.Drawing.Point(8, 128);
			this.pbPlayful.Maximum = 1000;
			this.pbPlayful.Name = "pbPlayful";
			this.pbPlayful.NumberFormat = "N1";
			this.pbPlayful.NumberOffset = 0;
			this.pbPlayful.NumberScale = 0.01;
			this.pbPlayful.SelectedColor = System.Drawing.Color.Lime;
			this.pbPlayful.Size = new System.Drawing.Size(240, 20);
			this.pbPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbPlayful.TabIndex = 66;
			this.pbPlayful.TextboxWidth = 40;
			this.pbPlayful.TokenCount = 10;
			this.pbPlayful.UnselectedColor = System.Drawing.Color.Black;
			this.pbPlayful.Value = 50;
			// 
			// pbActive
			// 
			this.pbActive.BackColor = System.Drawing.Color.Transparent;
			this.pbActive.DisplayOffset = 0;
			this.pbActive.DockPadding.Bottom = 5;
			this.pbActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbActive.LabelText = "Active:";
			this.pbActive.LabelWidth = 80;
			this.pbActive.Location = new System.Drawing.Point(8, 104);
			this.pbActive.Maximum = 1000;
			this.pbActive.Name = "pbActive";
			this.pbActive.NumberFormat = "N1";
			this.pbActive.NumberOffset = 0;
			this.pbActive.NumberScale = 0.01;
			this.pbActive.SelectedColor = System.Drawing.Color.Lime;
			this.pbActive.Size = new System.Drawing.Size(240, 20);
			this.pbActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbActive.TabIndex = 65;
			this.pbActive.TextboxWidth = 40;
			this.pbActive.TokenCount = 10;
			this.pbActive.UnselectedColor = System.Drawing.Color.Black;
			this.pbActive.Value = 50;
			// 
			// pbOutgoing
			// 
			this.pbOutgoing.BackColor = System.Drawing.Color.Transparent;
			this.pbOutgoing.DisplayOffset = 0;
			this.pbOutgoing.DockPadding.Bottom = 5;
			this.pbOutgoing.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbOutgoing.LabelText = "Outgoing:";
			this.pbOutgoing.LabelWidth = 80;
			this.pbOutgoing.Location = new System.Drawing.Point(8, 80);
			this.pbOutgoing.Maximum = 1000;
			this.pbOutgoing.Name = "pbOutgoing";
			this.pbOutgoing.NumberFormat = "N1";
			this.pbOutgoing.NumberOffset = 0;
			this.pbOutgoing.NumberScale = 0.01;
			this.pbOutgoing.SelectedColor = System.Drawing.Color.Lime;
			this.pbOutgoing.Size = new System.Drawing.Size(240, 20);
			this.pbOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbOutgoing.TabIndex = 64;
			this.pbOutgoing.TextboxWidth = 40;
			this.pbOutgoing.TokenCount = 10;
			this.pbOutgoing.UnselectedColor = System.Drawing.Color.Black;
			this.pbOutgoing.Value = 50;
			// 
			// pbNeat
			// 
			this.pbNeat.BackColor = System.Drawing.Color.Transparent;
			this.pbNeat.DisplayOffset = 0;
			this.pbNeat.DockPadding.Bottom = 5;
			this.pbNeat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbNeat.LabelText = "Neat:";
			this.pbNeat.LabelWidth = 80;
			this.pbNeat.Location = new System.Drawing.Point(8, 56);
			this.pbNeat.Maximum = 1000;
			this.pbNeat.Name = "pbNeat";
			this.pbNeat.NumberFormat = "N1";
			this.pbNeat.NumberOffset = 0;
			this.pbNeat.NumberScale = 0.01;
			this.pbNeat.SelectedColor = System.Drawing.Color.Lime;
			this.pbNeat.Size = new System.Drawing.Size(240, 20);
			this.pbNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbNeat.TabIndex = 63;
			this.pbNeat.TextboxWidth = 40;
			this.pbNeat.TokenCount = 10;
			this.pbNeat.UnselectedColor = System.Drawing.Color.Black;
			this.pbNeat.Value = 50;
			// 
			// cbzodiac
			// 
			this.cbzodiac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbzodiac.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbzodiac.ItemHeight = 13;
			this.cbzodiac.Location = new System.Drawing.Point(96, 16);
			this.cbzodiac.Name = "cbzodiac";
			this.cbzodiac.Size = new System.Drawing.Size(160, 21);
			this.cbzodiac.TabIndex = 62;
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label47.Location = new System.Drawing.Point(8, 24);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(80, 17);
			this.label47.TabIndex = 61;
			this.label47.Text = "Zodiac Sign:";
			this.label47.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
			this.panel2.Location = new System.Drawing.Point(494, 176);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1, 70);
			this.panel2.TabIndex = 78;
			// 
			// label69
			// 
			this.label69.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label69.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label69.Location = new System.Drawing.Point(439, 232);
			this.label69.Name = "label69";
			this.label69.Size = new System.Drawing.Size(56, 16);
			this.label69.TabIndex = 75;
			this.label69.Text = "attracted";
			this.label69.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
			this.panel1.Location = new System.Drawing.Point(96, 176);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1, 70);
			this.panel1.TabIndex = 77;
			// 
			// label70
			// 
			this.label70.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label70.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label70.Location = new System.Drawing.Point(95, 232);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(53, 16);
			this.label70.TabIndex = 76;
			this.label70.Text = "disgusted";
			// 
			// pnCareer
			// 
			this.pnCareer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnCareer.BackColor = System.Drawing.Color.Transparent;
			this.pnCareer.Controls.Add(this.pbAspBliz);
			this.pnCareer.Controls.Add(this.label60);
			this.pnCareer.Controls.Add(this.cbaspiration);
			this.pnCareer.Controls.Add(this.pbAspCur);
			this.pnCareer.Controls.Add(this.label46);
			this.pnCareer.Controls.Add(this.tblifelinescore);
			this.pnCareer.Controls.Add(this.pbCareerPerformance);
			this.pnCareer.Controls.Add(this.pbCareerLevel);
			this.pnCareer.Controls.Add(this.label78);
			this.pnCareer.Controls.Add(this.tbschooltype);
			this.pnCareer.Controls.Add(this.label77);
			this.pnCareer.Controls.Add(this.cbgrade);
			this.pnCareer.Controls.Add(this.cbschooltype);
			this.pnCareer.Controls.Add(this.label50);
			this.pnCareer.Controls.Add(this.cbcareer);
			this.pnCareer.Controls.Add(this.tbcareervalue);
			this.pnCareer.Location = new System.Drawing.Point(0, 80);
			this.pnCareer.Name = "pnCareer";
			this.pnCareer.Size = new System.Drawing.Size(696, 264);
			this.pnCareer.TabIndex = 5;
			this.pnCareer.Visible = false;
			// 
			// pbAspBliz
			// 
			this.pbAspBliz.BackColor = System.Drawing.Color.Transparent;
			this.pbAspBliz.DisplayOffset = 0;
			this.pbAspBliz.DockPadding.Bottom = 5;
			this.pbAspBliz.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbAspBliz.LabelText = "Blized:";
			this.pbAspBliz.LabelWidth = 112;
			this.pbAspBliz.Location = new System.Drawing.Point(352, 48);
			this.pbAspBliz.Maximum = 1200;
			this.pbAspBliz.Name = "pbAspBliz";
			this.pbAspBliz.NumberFormat = "N0";
			this.pbAspBliz.NumberOffset = 0;
			this.pbAspBliz.NumberScale = 1;
			this.pbAspBliz.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbAspBliz.Size = new System.Drawing.Size(328, 20);
			this.pbAspBliz.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbAspBliz.TabIndex = 69;
			this.pbAspBliz.TextboxWidth = 40;
			this.pbAspBliz.TokenCount = 27;
			this.pbAspBliz.UnselectedColor = System.Drawing.Color.Black;
			this.pbAspBliz.Value = 10;
			// 
			// label60
			// 
			this.label60.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label60.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label60.Location = new System.Drawing.Point(344, 96);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(120, 17);
			this.label60.TabIndex = 64;
			this.label60.Text = "Score:";
			this.label60.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cbaspiration
			// 
			this.cbaspiration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaspiration.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbaspiration.ItemHeight = 13;
			this.cbaspiration.Location = new System.Drawing.Point(472, 16);
			this.cbaspiration.Name = "cbaspiration";
			this.cbaspiration.Size = new System.Drawing.Size(208, 21);
			this.cbaspiration.TabIndex = 67;
			// 
			// pbAspCur
			// 
			this.pbAspCur.BackColor = System.Drawing.Color.Transparent;
			this.pbAspCur.DisplayOffset = 0;
			this.pbAspCur.DockPadding.Bottom = 5;
			this.pbAspCur.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbAspCur.LabelText = "Current:";
			this.pbAspCur.LabelWidth = 112;
			this.pbAspCur.Location = new System.Drawing.Point(352, 72);
			this.pbAspCur.Maximum = 1200;
			this.pbAspCur.Name = "pbAspCur";
			this.pbAspCur.NumberFormat = "N0";
			this.pbAspCur.NumberOffset = -600;
			this.pbAspCur.NumberScale = 1;
			this.pbAspCur.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbAspCur.Size = new System.Drawing.Size(328, 20);
			this.pbAspCur.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbAspCur.TabIndex = 68;
			this.pbAspCur.TextboxWidth = 40;
			this.pbAspCur.TokenCount = 27;
			this.pbAspCur.UnselectedColor = System.Drawing.Color.Black;
			this.pbAspCur.Value = 0;
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label46.Location = new System.Drawing.Point(392, 24);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(72, 17);
			this.label46.TabIndex = 66;
			this.label46.Text = "Aspiration:";
			this.label46.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tblifelinescore
			// 
			this.tblifelinescore.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tblifelinescore.Location = new System.Drawing.Point(472, 96);
			this.tblifelinescore.Name = "tblifelinescore";
			this.tblifelinescore.Size = new System.Drawing.Size(96, 14);
			this.tblifelinescore.TabIndex = 65;
			this.tblifelinescore.Text = "";
			// 
			// pbCareerPerformance
			// 
			this.pbCareerPerformance.BackColor = System.Drawing.Color.Transparent;
			this.pbCareerPerformance.DisplayOffset = 0;
			this.pbCareerPerformance.DockPadding.Bottom = 5;
			this.pbCareerPerformance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCareerPerformance.LabelText = "Preformance:";
			this.pbCareerPerformance.LabelWidth = 88;
			this.pbCareerPerformance.Location = new System.Drawing.Point(8, 168);
			this.pbCareerPerformance.Maximum = 1000;
			this.pbCareerPerformance.Name = "pbCareerPerformance";
			this.pbCareerPerformance.NumberFormat = "N0";
			this.pbCareerPerformance.NumberOffset = 0;
			this.pbCareerPerformance.NumberScale = 1;
			this.pbCareerPerformance.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbCareerPerformance.Size = new System.Drawing.Size(313, 32);
			this.pbCareerPerformance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCareerPerformance.TabIndex = 56;
			this.pbCareerPerformance.TextboxWidth = 40;
			this.pbCareerPerformance.TokenCount = 21;
			this.pbCareerPerformance.UnselectedColor = System.Drawing.Color.Black;
			this.pbCareerPerformance.Value = 10;
			// 
			// pbCareerLevel
			// 
			this.pbCareerLevel.BackColor = System.Drawing.Color.Transparent;
			this.pbCareerLevel.DisplayOffset = 0;
			this.pbCareerLevel.DockPadding.Bottom = 5;
			this.pbCareerLevel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCareerLevel.LabelText = "Career Level:";
			this.pbCareerLevel.LabelWidth = 88;
			this.pbCareerLevel.Location = new System.Drawing.Point(8, 136);
			this.pbCareerLevel.Maximum = 10;
			this.pbCareerLevel.Name = "pbCareerLevel";
			this.pbCareerLevel.NumberFormat = "N0";
			this.pbCareerLevel.NumberOffset = 0;
			this.pbCareerLevel.NumberScale = 1;
			this.pbCareerLevel.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbCareerLevel.Size = new System.Drawing.Size(313, 32);
			this.pbCareerLevel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCareerLevel.TabIndex = 55;
			this.pbCareerLevel.TextboxWidth = 40;
			this.pbCareerLevel.TokenCount = 10;
			this.pbCareerLevel.UnselectedColor = System.Drawing.Color.Black;
			this.pbCareerLevel.Value = 10;
			// 
			// label78
			// 
			this.label78.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label78.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label78.Location = new System.Drawing.Point(8, 24);
			this.label78.Name = "label78";
			this.label78.Size = new System.Drawing.Size(88, 17);
			this.label78.TabIndex = 31;
			this.label78.Text = "School Type:";
			this.label78.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbschooltype
			// 
			this.tbschooltype.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbschooltype.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbschooltype.Location = new System.Drawing.Point(240, 24);
			this.tbschooltype.Name = "tbschooltype";
			this.tbschooltype.Size = new System.Drawing.Size(80, 14);
			this.tbschooltype.TabIndex = 34;
			this.tbschooltype.Text = "";
			// 
			// label77
			// 
			this.label77.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label77.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label77.Location = new System.Drawing.Point(32, 48);
			this.label77.Name = "label77";
			this.label77.Size = new System.Drawing.Size(64, 17);
			this.label77.TabIndex = 35;
			this.label77.Text = "Grade:";
			this.label77.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cbgrade
			// 
			this.cbgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbgrade.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.cbgrade.ItemHeight = 13;
			this.cbgrade.Location = new System.Drawing.Point(104, 40);
			this.cbgrade.Name = "cbgrade";
			this.cbgrade.Size = new System.Drawing.Size(88, 21);
			this.cbgrade.TabIndex = 36;
			// 
			// cbschooltype
			// 
			this.cbschooltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbschooltype.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.cbschooltype.ItemHeight = 13;
			this.cbschooltype.Location = new System.Drawing.Point(104, 16);
			this.cbschooltype.Name = "cbschooltype";
			this.cbschooltype.Size = new System.Drawing.Size(128, 21);
			this.cbschooltype.TabIndex = 37;
			this.cbschooltype.SelectedIndexChanged += new System.EventHandler(this.cbschooltype_SelectedIndexChanged);
			// 
			// label50
			// 
			this.label50.AutoSize = true;
			this.label50.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label50.Location = new System.Drawing.Point(48, 112);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(46, 17);
			this.label50.TabIndex = 31;
			this.label50.Text = "Career:";
			this.label50.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// cbcareer
			// 
			this.cbcareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbcareer.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.cbcareer.ItemHeight = 13;
			this.cbcareer.Location = new System.Drawing.Point(104, 104);
			this.cbcareer.Name = "cbcareer";
			this.cbcareer.Size = new System.Drawing.Size(128, 21);
			this.cbcareer.TabIndex = 33;
			this.cbcareer.SelectedIndexChanged += new System.EventHandler(this.cbcareer_SelectedIndexChanged);
			// 
			// tbcareervalue
			// 
			this.tbcareervalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcareervalue.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbcareervalue.Location = new System.Drawing.Point(240, 112);
			this.tbcareervalue.Name = "tbcareervalue";
			this.tbcareervalue.Size = new System.Drawing.Size(80, 14);
			this.tbcareervalue.TabIndex = 34;
			this.tbcareervalue.Text = "0x00000000";
			// 
			// pnInt
			// 
			this.pnInt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnInt.BackColor = System.Drawing.Color.Transparent;
			this.pnInt.Controls.Add(this.pbSciFi);
			this.pnInt.Controls.Add(this.pbToys);
			this.pnInt.Controls.Add(this.pbSchool);
			this.pnInt.Controls.Add(this.pbAnimals);
			this.pnInt.Controls.Add(this.pbWeather);
			this.pnInt.Controls.Add(this.pbWork);
			this.pnInt.Controls.Add(this.pbTravel);
			this.pnInt.Controls.Add(this.pbCrime);
			this.pnInt.Controls.Add(this.pbSports);
			this.pnInt.Controls.Add(this.pbFashion);
			this.pnInt.Controls.Add(this.pbHealth);
			this.pnInt.Controls.Add(this.pbFood);
			this.pnInt.Controls.Add(this.pbPolitics);
			this.pnInt.Controls.Add(this.pbMoney);
			this.pnInt.Controls.Add(this.pbCulture);
			this.pnInt.Controls.Add(this.pbEntertainment);
			this.pnInt.Controls.Add(this.pbParanormal);
			this.pnInt.Controls.Add(this.pbEnvironment);
			this.pnInt.Location = new System.Drawing.Point(0, 80);
			this.pnInt.Name = "pnInt";
			this.pnInt.Size = new System.Drawing.Size(696, 264);
			this.pnInt.TabIndex = 6;
			this.pnInt.Visible = false;
			// 
			// pbSciFi
			// 
			this.pbSciFi.BackColor = System.Drawing.Color.Transparent;
			this.pbSciFi.DisplayOffset = 0;
			this.pbSciFi.DockPadding.Bottom = 5;
			this.pbSciFi.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbSciFi.LabelText = "ScienceFiction:";
			this.pbSciFi.LabelWidth = 100;
			this.pbSciFi.Location = new System.Drawing.Point(272, 208);
			this.pbSciFi.Maximum = 1000;
			this.pbSciFi.Name = "pbSciFi";
			this.pbSciFi.NumberFormat = "N1";
			this.pbSciFi.NumberOffset = 0;
			this.pbSciFi.NumberScale = 0.01;
			this.pbSciFi.SelectedColor = System.Drawing.Color.Lime;
			this.pbSciFi.Size = new System.Drawing.Size(240, 20);
			this.pbSciFi.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSciFi.TabIndex = 81;
			this.pbSciFi.TextboxWidth = 40;
			this.pbSciFi.TokenCount = 10;
			this.pbSciFi.UnselectedColor = System.Drawing.Color.Black;
			this.pbSciFi.Value = 500;
			// 
			// pbToys
			// 
			this.pbToys.BackColor = System.Drawing.Color.Transparent;
			this.pbToys.DisplayOffset = 0;
			this.pbToys.DockPadding.Bottom = 5;
			this.pbToys.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbToys.LabelText = "Toys:";
			this.pbToys.LabelWidth = 100;
			this.pbToys.Location = new System.Drawing.Point(272, 184);
			this.pbToys.Maximum = 1000;
			this.pbToys.Name = "pbToys";
			this.pbToys.NumberFormat = "N1";
			this.pbToys.NumberOffset = 0;
			this.pbToys.NumberScale = 0.01;
			this.pbToys.SelectedColor = System.Drawing.Color.Lime;
			this.pbToys.Size = new System.Drawing.Size(240, 20);
			this.pbToys.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbToys.TabIndex = 80;
			this.pbToys.TextboxWidth = 40;
			this.pbToys.TokenCount = 10;
			this.pbToys.UnselectedColor = System.Drawing.Color.Black;
			this.pbToys.Value = 500;
			// 
			// pbSchool
			// 
			this.pbSchool.BackColor = System.Drawing.Color.Transparent;
			this.pbSchool.DisplayOffset = 0;
			this.pbSchool.DockPadding.Bottom = 5;
			this.pbSchool.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbSchool.LabelText = "School:";
			this.pbSchool.LabelWidth = 100;
			this.pbSchool.Location = new System.Drawing.Point(272, 160);
			this.pbSchool.Maximum = 1000;
			this.pbSchool.Name = "pbSchool";
			this.pbSchool.NumberFormat = "N1";
			this.pbSchool.NumberOffset = 0;
			this.pbSchool.NumberScale = 0.01;
			this.pbSchool.SelectedColor = System.Drawing.Color.Lime;
			this.pbSchool.Size = new System.Drawing.Size(240, 20);
			this.pbSchool.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSchool.TabIndex = 79;
			this.pbSchool.TextboxWidth = 40;
			this.pbSchool.TokenCount = 10;
			this.pbSchool.UnselectedColor = System.Drawing.Color.Black;
			this.pbSchool.Value = 500;
			// 
			// pbAnimals
			// 
			this.pbAnimals.BackColor = System.Drawing.Color.Transparent;
			this.pbAnimals.DisplayOffset = 0;
			this.pbAnimals.DockPadding.Bottom = 5;
			this.pbAnimals.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbAnimals.LabelText = "Animals:";
			this.pbAnimals.LabelWidth = 100;
			this.pbAnimals.Location = new System.Drawing.Point(272, 112);
			this.pbAnimals.Maximum = 1000;
			this.pbAnimals.Name = "pbAnimals";
			this.pbAnimals.NumberFormat = "N1";
			this.pbAnimals.NumberOffset = 0;
			this.pbAnimals.NumberScale = 0.01;
			this.pbAnimals.SelectedColor = System.Drawing.Color.Lime;
			this.pbAnimals.Size = new System.Drawing.Size(240, 20);
			this.pbAnimals.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbAnimals.TabIndex = 78;
			this.pbAnimals.TextboxWidth = 40;
			this.pbAnimals.TokenCount = 10;
			this.pbAnimals.UnselectedColor = System.Drawing.Color.Black;
			this.pbAnimals.Value = 500;
			// 
			// pbWeather
			// 
			this.pbWeather.BackColor = System.Drawing.Color.Transparent;
			this.pbWeather.DisplayOffset = 0;
			this.pbWeather.DockPadding.Bottom = 5;
			this.pbWeather.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbWeather.LabelText = "Weather:";
			this.pbWeather.LabelWidth = 100;
			this.pbWeather.Location = new System.Drawing.Point(8, 64);
			this.pbWeather.Maximum = 1000;
			this.pbWeather.Name = "pbWeather";
			this.pbWeather.NumberFormat = "N1";
			this.pbWeather.NumberOffset = 0;
			this.pbWeather.NumberScale = 0.01;
			this.pbWeather.SelectedColor = System.Drawing.Color.Lime;
			this.pbWeather.Size = new System.Drawing.Size(240, 20);
			this.pbWeather.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbWeather.TabIndex = 77;
			this.pbWeather.TextboxWidth = 40;
			this.pbWeather.TokenCount = 10;
			this.pbWeather.UnselectedColor = System.Drawing.Color.Black;
			this.pbWeather.Value = 500;
			// 
			// pbWork
			// 
			this.pbWork.BackColor = System.Drawing.Color.Transparent;
			this.pbWork.DisplayOffset = 0;
			this.pbWork.DockPadding.Bottom = 5;
			this.pbWork.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbWork.LabelText = "Work:";
			this.pbWork.LabelWidth = 100;
			this.pbWork.Location = new System.Drawing.Point(272, 136);
			this.pbWork.Maximum = 1000;
			this.pbWork.Name = "pbWork";
			this.pbWork.NumberFormat = "N1";
			this.pbWork.NumberOffset = 0;
			this.pbWork.NumberScale = 0.01;
			this.pbWork.SelectedColor = System.Drawing.Color.Lime;
			this.pbWork.Size = new System.Drawing.Size(240, 20);
			this.pbWork.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbWork.TabIndex = 76;
			this.pbWork.TextboxWidth = 40;
			this.pbWork.TokenCount = 10;
			this.pbWork.UnselectedColor = System.Drawing.Color.Black;
			this.pbWork.Value = 500;
			// 
			// pbTravel
			// 
			this.pbTravel.BackColor = System.Drawing.Color.Transparent;
			this.pbTravel.DisplayOffset = 0;
			this.pbTravel.DockPadding.Bottom = 5;
			this.pbTravel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbTravel.LabelText = "Travel:";
			this.pbTravel.LabelWidth = 100;
			this.pbTravel.Location = new System.Drawing.Point(272, 16);
			this.pbTravel.Maximum = 1000;
			this.pbTravel.Name = "pbTravel";
			this.pbTravel.NumberFormat = "N1";
			this.pbTravel.NumberOffset = 0;
			this.pbTravel.NumberScale = 0.01;
			this.pbTravel.SelectedColor = System.Drawing.Color.Lime;
			this.pbTravel.Size = new System.Drawing.Size(240, 20);
			this.pbTravel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbTravel.TabIndex = 75;
			this.pbTravel.TextboxWidth = 40;
			this.pbTravel.TokenCount = 10;
			this.pbTravel.UnselectedColor = System.Drawing.Color.Black;
			this.pbTravel.Value = 500;
			// 
			// pbCrime
			// 
			this.pbCrime.BackColor = System.Drawing.Color.Transparent;
			this.pbCrime.DisplayOffset = 0;
			this.pbCrime.DockPadding.Bottom = 5;
			this.pbCrime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCrime.LabelText = "Crime:";
			this.pbCrime.LabelWidth = 100;
			this.pbCrime.Location = new System.Drawing.Point(272, 40);
			this.pbCrime.Maximum = 1000;
			this.pbCrime.Name = "pbCrime";
			this.pbCrime.NumberFormat = "N1";
			this.pbCrime.NumberOffset = 0;
			this.pbCrime.NumberScale = 0.01;
			this.pbCrime.SelectedColor = System.Drawing.Color.Lime;
			this.pbCrime.Size = new System.Drawing.Size(240, 20);
			this.pbCrime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCrime.TabIndex = 74;
			this.pbCrime.TextboxWidth = 40;
			this.pbCrime.TokenCount = 10;
			this.pbCrime.UnselectedColor = System.Drawing.Color.Black;
			this.pbCrime.Value = 500;
			// 
			// pbSports
			// 
			this.pbSports.BackColor = System.Drawing.Color.Transparent;
			this.pbSports.DisplayOffset = 0;
			this.pbSports.DockPadding.Bottom = 5;
			this.pbSports.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbSports.LabelText = "Sports:";
			this.pbSports.LabelWidth = 100;
			this.pbSports.Location = new System.Drawing.Point(272, 64);
			this.pbSports.Maximum = 1000;
			this.pbSports.Name = "pbSports";
			this.pbSports.NumberFormat = "N1";
			this.pbSports.NumberOffset = 0;
			this.pbSports.NumberScale = 0.01;
			this.pbSports.SelectedColor = System.Drawing.Color.Lime;
			this.pbSports.Size = new System.Drawing.Size(240, 20);
			this.pbSports.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSports.TabIndex = 73;
			this.pbSports.TextboxWidth = 40;
			this.pbSports.TokenCount = 10;
			this.pbSports.UnselectedColor = System.Drawing.Color.Black;
			this.pbSports.Value = 500;
			// 
			// pbFashion
			// 
			this.pbFashion.BackColor = System.Drawing.Color.Transparent;
			this.pbFashion.DisplayOffset = 0;
			this.pbFashion.DockPadding.Bottom = 5;
			this.pbFashion.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbFashion.LabelText = "Fashion:";
			this.pbFashion.LabelWidth = 100;
			this.pbFashion.Location = new System.Drawing.Point(8, 208);
			this.pbFashion.Maximum = 1000;
			this.pbFashion.Name = "pbFashion";
			this.pbFashion.NumberFormat = "N1";
			this.pbFashion.NumberOffset = 0;
			this.pbFashion.NumberScale = 0.01;
			this.pbFashion.SelectedColor = System.Drawing.Color.Lime;
			this.pbFashion.Size = new System.Drawing.Size(240, 20);
			this.pbFashion.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFashion.TabIndex = 72;
			this.pbFashion.TextboxWidth = 40;
			this.pbFashion.TokenCount = 10;
			this.pbFashion.UnselectedColor = System.Drawing.Color.Black;
			this.pbFashion.Value = 500;
			// 
			// pbHealth
			// 
			this.pbHealth.BackColor = System.Drawing.Color.Transparent;
			this.pbHealth.DisplayOffset = 0;
			this.pbHealth.DockPadding.Bottom = 5;
			this.pbHealth.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbHealth.LabelText = "Health:";
			this.pbHealth.LabelWidth = 100;
			this.pbHealth.Location = new System.Drawing.Point(8, 184);
			this.pbHealth.Maximum = 1000;
			this.pbHealth.Name = "pbHealth";
			this.pbHealth.NumberFormat = "N1";
			this.pbHealth.NumberOffset = 0;
			this.pbHealth.NumberScale = 0.01;
			this.pbHealth.SelectedColor = System.Drawing.Color.Lime;
			this.pbHealth.Size = new System.Drawing.Size(240, 20);
			this.pbHealth.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbHealth.TabIndex = 71;
			this.pbHealth.TextboxWidth = 40;
			this.pbHealth.TokenCount = 10;
			this.pbHealth.UnselectedColor = System.Drawing.Color.Black;
			this.pbHealth.Value = 500;
			// 
			// pbFood
			// 
			this.pbFood.BackColor = System.Drawing.Color.Transparent;
			this.pbFood.DisplayOffset = 0;
			this.pbFood.DockPadding.Bottom = 5;
			this.pbFood.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbFood.LabelText = "Food:";
			this.pbFood.LabelWidth = 100;
			this.pbFood.Location = new System.Drawing.Point(8, 40);
			this.pbFood.Maximum = 1000;
			this.pbFood.Name = "pbFood";
			this.pbFood.NumberFormat = "N1";
			this.pbFood.NumberOffset = 0;
			this.pbFood.NumberScale = 0.01;
			this.pbFood.SelectedColor = System.Drawing.Color.Lime;
			this.pbFood.Size = new System.Drawing.Size(240, 20);
			this.pbFood.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFood.TabIndex = 70;
			this.pbFood.TextboxWidth = 40;
			this.pbFood.TokenCount = 10;
			this.pbFood.UnselectedColor = System.Drawing.Color.Black;
			this.pbFood.Value = 500;
			// 
			// pbPolitics
			// 
			this.pbPolitics.BackColor = System.Drawing.Color.Transparent;
			this.pbPolitics.DisplayOffset = 0;
			this.pbPolitics.DockPadding.Bottom = 5;
			this.pbPolitics.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbPolitics.LabelText = "Politics:";
			this.pbPolitics.LabelWidth = 100;
			this.pbPolitics.Location = new System.Drawing.Point(8, 136);
			this.pbPolitics.Maximum = 1000;
			this.pbPolitics.Name = "pbPolitics";
			this.pbPolitics.NumberFormat = "N1";
			this.pbPolitics.NumberOffset = 0;
			this.pbPolitics.NumberScale = 0.01;
			this.pbPolitics.SelectedColor = System.Drawing.Color.Lime;
			this.pbPolitics.Size = new System.Drawing.Size(240, 20);
			this.pbPolitics.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbPolitics.TabIndex = 69;
			this.pbPolitics.TextboxWidth = 40;
			this.pbPolitics.TokenCount = 10;
			this.pbPolitics.UnselectedColor = System.Drawing.Color.Black;
			this.pbPolitics.Value = 500;
			// 
			// pbMoney
			// 
			this.pbMoney.BackColor = System.Drawing.Color.Transparent;
			this.pbMoney.DisplayOffset = 0;
			this.pbMoney.DockPadding.Bottom = 5;
			this.pbMoney.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbMoney.LabelText = "Money:";
			this.pbMoney.LabelWidth = 100;
			this.pbMoney.Location = new System.Drawing.Point(8, 112);
			this.pbMoney.Maximum = 1000;
			this.pbMoney.Name = "pbMoney";
			this.pbMoney.NumberFormat = "N1";
			this.pbMoney.NumberOffset = 0;
			this.pbMoney.NumberScale = 0.01;
			this.pbMoney.SelectedColor = System.Drawing.Color.Lime;
			this.pbMoney.Size = new System.Drawing.Size(240, 20);
			this.pbMoney.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbMoney.TabIndex = 68;
			this.pbMoney.TextboxWidth = 40;
			this.pbMoney.TokenCount = 10;
			this.pbMoney.UnselectedColor = System.Drawing.Color.Black;
			this.pbMoney.Value = 500;
			// 
			// pbCulture
			// 
			this.pbCulture.BackColor = System.Drawing.Color.Transparent;
			this.pbCulture.DisplayOffset = 0;
			this.pbCulture.DockPadding.Bottom = 5;
			this.pbCulture.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbCulture.LabelText = "Culture:";
			this.pbCulture.LabelWidth = 100;
			this.pbCulture.Location = new System.Drawing.Point(8, 88);
			this.pbCulture.Maximum = 1000;
			this.pbCulture.Name = "pbCulture";
			this.pbCulture.NumberFormat = "N1";
			this.pbCulture.NumberOffset = 0;
			this.pbCulture.NumberScale = 0.01;
			this.pbCulture.SelectedColor = System.Drawing.Color.Lime;
			this.pbCulture.Size = new System.Drawing.Size(240, 20);
			this.pbCulture.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCulture.TabIndex = 67;
			this.pbCulture.TextboxWidth = 40;
			this.pbCulture.TokenCount = 10;
			this.pbCulture.UnselectedColor = System.Drawing.Color.Black;
			this.pbCulture.Value = 500;
			// 
			// pbEntertainment
			// 
			this.pbEntertainment.BackColor = System.Drawing.Color.Transparent;
			this.pbEntertainment.DisplayOffset = 0;
			this.pbEntertainment.DockPadding.Bottom = 5;
			this.pbEntertainment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbEntertainment.LabelText = "Entertainment:";
			this.pbEntertainment.LabelWidth = 100;
			this.pbEntertainment.Location = new System.Drawing.Point(272, 88);
			this.pbEntertainment.Maximum = 1000;
			this.pbEntertainment.Name = "pbEntertainment";
			this.pbEntertainment.NumberFormat = "N1";
			this.pbEntertainment.NumberOffset = 0;
			this.pbEntertainment.NumberScale = 0.01;
			this.pbEntertainment.SelectedColor = System.Drawing.Color.Lime;
			this.pbEntertainment.Size = new System.Drawing.Size(240, 20);
			this.pbEntertainment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEntertainment.TabIndex = 66;
			this.pbEntertainment.TextboxWidth = 40;
			this.pbEntertainment.TokenCount = 10;
			this.pbEntertainment.UnselectedColor = System.Drawing.Color.Black;
			this.pbEntertainment.Value = 500;
			// 
			// pbParanormal
			// 
			this.pbParanormal.BackColor = System.Drawing.Color.Transparent;
			this.pbParanormal.DisplayOffset = 0;
			this.pbParanormal.DockPadding.Bottom = 5;
			this.pbParanormal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbParanormal.LabelText = "Paranormal:";
			this.pbParanormal.LabelWidth = 100;
			this.pbParanormal.Location = new System.Drawing.Point(8, 160);
			this.pbParanormal.Maximum = 1000;
			this.pbParanormal.Name = "pbParanormal";
			this.pbParanormal.NumberFormat = "N1";
			this.pbParanormal.NumberOffset = 0;
			this.pbParanormal.NumberScale = 0.01;
			this.pbParanormal.SelectedColor = System.Drawing.Color.Lime;
			this.pbParanormal.Size = new System.Drawing.Size(240, 20);
			this.pbParanormal.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbParanormal.TabIndex = 65;
			this.pbParanormal.TextboxWidth = 40;
			this.pbParanormal.TokenCount = 10;
			this.pbParanormal.UnselectedColor = System.Drawing.Color.Black;
			this.pbParanormal.Value = 500;
			// 
			// pbEnvironment
			// 
			this.pbEnvironment.BackColor = System.Drawing.Color.Transparent;
			this.pbEnvironment.DisplayOffset = 0;
			this.pbEnvironment.DockPadding.Bottom = 5;
			this.pbEnvironment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbEnvironment.LabelText = "Environment:";
			this.pbEnvironment.LabelWidth = 100;
			this.pbEnvironment.Location = new System.Drawing.Point(8, 16);
			this.pbEnvironment.Maximum = 1000;
			this.pbEnvironment.Name = "pbEnvironment";
			this.pbEnvironment.NumberFormat = "N1";
			this.pbEnvironment.NumberOffset = 0;
			this.pbEnvironment.NumberScale = 0.01;
			this.pbEnvironment.SelectedColor = System.Drawing.Color.Lime;
			this.pbEnvironment.Size = new System.Drawing.Size(240, 20);
			this.pbEnvironment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEnvironment.TabIndex = 64;
			this.pbEnvironment.TextboxWidth = 40;
			this.pbEnvironment.TokenCount = 10;
			this.pbEnvironment.UnselectedColor = System.Drawing.Color.Black;
			this.pbEnvironment.Value = 500;
			// 
			// pnRel
			// 
			this.pnRel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnRel.BackColor = System.Drawing.Color.Transparent;
			this.pnRel.Location = new System.Drawing.Point(0, 80);
			this.pnRel.Name = "pnRel";
			this.pnRel.Size = new System.Drawing.Size(696, 264);
			this.pnRel.TabIndex = 7;
			this.pnRel.Visible = false;
			// 
			// pnMisc
			// 
			this.pnMisc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnMisc.BackColor = System.Drawing.Color.Transparent;
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple3);
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple2);
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple1);
			this.pnMisc.Location = new System.Drawing.Point(0, 80);
			this.pnMisc.Name = "pnMisc";
			this.pnMisc.Size = new System.Drawing.Size(696, 264);
			this.pnMisc.TabIndex = 8;
			this.pnMisc.Visible = false;
			// 
			// xpTaskBoxSimple3
			// 
			this.xpTaskBoxSimple3.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple3.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple3.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple3.Controls.Add(this.label96);
			this.xpTaskBoxSimple3.Controls.Add(this.tbunlinked);
			this.xpTaskBoxSimple3.Controls.Add(this.label95);
			this.xpTaskBoxSimple3.Controls.Add(this.tbagedur);
			this.xpTaskBoxSimple3.Controls.Add(this.tbprevdays);
			this.xpTaskBoxSimple3.Controls.Add(this.label94);
			this.xpTaskBoxSimple3.Controls.Add(this.tbvoice);
			this.xpTaskBoxSimple3.Controls.Add(this.label90);
			this.xpTaskBoxSimple3.Controls.Add(this.tbnpc);
			this.xpTaskBoxSimple3.Controls.Add(this.label87);
			this.xpTaskBoxSimple3.Controls.Add(this.tbautonomy);
			this.xpTaskBoxSimple3.Controls.Add(this.label86);
			this.xpTaskBoxSimple3.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple3.DockPadding.Left = 4;
			this.xpTaskBoxSimple3.DockPadding.Right = 4;
			this.xpTaskBoxSimple3.DockPadding.Top = 44;
			this.xpTaskBoxSimple3.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple3.HeaderText = "Misc";
			this.xpTaskBoxSimple3.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple3.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple3.Location = new System.Drawing.Point(352, 0);
			this.xpTaskBoxSimple3.Name = "xpTaskBoxSimple3";
			this.xpTaskBoxSimple3.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple3.Size = new System.Drawing.Size(216, 152);
			this.xpTaskBoxSimple3.TabIndex = 17;
			// 
			// label96
			// 
			this.label96.AutoSize = true;
			this.label96.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label96.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label96.Location = new System.Drawing.Point(64, 128);
			this.label96.Name = "label96";
			this.label96.Size = new System.Drawing.Size(55, 17);
			this.label96.TabIndex = 42;
			this.label96.Text = "Unlinked";
			// 
			// tbunlinked
			// 
			this.tbunlinked.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbunlinked.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbunlinked.Location = new System.Drawing.Point(120, 128);
			this.tbunlinked.Name = "tbunlinked";
			this.tbunlinked.Size = new System.Drawing.Size(80, 14);
			this.tbunlinked.TabIndex = 41;
			this.tbunlinked.Text = "";
			// 
			// label95
			// 
			this.label95.AutoSize = true;
			this.label95.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label95.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label95.Location = new System.Drawing.Point(40, 112);
			this.label95.Name = "label95";
			this.label95.Size = new System.Drawing.Size(78, 17);
			this.label95.TabIndex = 40;
			this.label95.Text = "Age duration";
			// 
			// tbagedur
			// 
			this.tbagedur.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbagedur.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbagedur.Location = new System.Drawing.Point(120, 112);
			this.tbagedur.Name = "tbagedur";
			this.tbagedur.Size = new System.Drawing.Size(80, 14);
			this.tbagedur.TabIndex = 39;
			this.tbagedur.Text = "";
			// 
			// tbprevdays
			// 
			this.tbprevdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbprevdays.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbprevdays.Location = new System.Drawing.Point(120, 96);
			this.tbprevdays.Name = "tbprevdays";
			this.tbprevdays.Size = new System.Drawing.Size(80, 14);
			this.tbprevdays.TabIndex = 38;
			this.tbprevdays.Text = "";
			// 
			// label94
			// 
			this.label94.AutoSize = true;
			this.label94.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label94.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label94.Location = new System.Drawing.Point(8, 96);
			this.label94.Name = "label94";
			this.label94.Size = new System.Drawing.Size(103, 17);
			this.label94.TabIndex = 37;
			this.label94.Text = "Days in prev. Age";
			// 
			// tbvoice
			// 
			this.tbvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbvoice.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbvoice.Location = new System.Drawing.Point(120, 80);
			this.tbvoice.Name = "tbvoice";
			this.tbvoice.Size = new System.Drawing.Size(80, 14);
			this.tbvoice.TabIndex = 36;
			this.tbvoice.Text = "";
			// 
			// label90
			// 
			this.label90.AutoSize = true;
			this.label90.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label90.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label90.Location = new System.Drawing.Point(48, 80);
			this.label90.Name = "label90";
			this.label90.Size = new System.Drawing.Size(66, 17);
			this.label90.TabIndex = 35;
			this.label90.Text = "Voice Type";
			// 
			// tbnpc
			// 
			this.tbnpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbnpc.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbnpc.Location = new System.Drawing.Point(120, 64);
			this.tbnpc.Name = "tbnpc";
			this.tbnpc.Size = new System.Drawing.Size(80, 14);
			this.tbnpc.TabIndex = 34;
			this.tbnpc.Text = "";
			// 
			// label87
			// 
			this.label87.AutoSize = true;
			this.label87.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label87.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label87.Location = new System.Drawing.Point(56, 64);
			this.label87.Name = "label87";
			this.label87.Size = new System.Drawing.Size(59, 17);
			this.label87.TabIndex = 33;
			this.label87.Text = "NPC Type";
			// 
			// tbautonomy
			// 
			this.tbautonomy.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbautonomy.Font = new System.Drawing.Font("Verdana", 8.25F);
			this.tbautonomy.Location = new System.Drawing.Point(120, 48);
			this.tbautonomy.Name = "tbautonomy";
			this.tbautonomy.Size = new System.Drawing.Size(80, 14);
			this.tbautonomy.TabIndex = 32;
			this.tbautonomy.Text = "";
			// 
			// label86
			// 
			this.label86.AutoSize = true;
			this.label86.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label86.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label86.Location = new System.Drawing.Point(16, 48);
			this.label86.Name = "label86";
			this.label86.Size = new System.Drawing.Size(96, 17);
			this.label86.TabIndex = 31;
			this.label86.Text = "Autonomy Level";
			// 
			// xpTaskBoxSimple2
			// 
			this.xpTaskBoxSimple2.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple2.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple2.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple2.Controls.Add(this.cbfit);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpreginv);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpreghalf);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpregfull);
			this.xpTaskBoxSimple2.Controls.Add(this.cbfat);
			this.xpTaskBoxSimple2.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple2.DockPadding.Left = 4;
			this.xpTaskBoxSimple2.DockPadding.Right = 4;
			this.xpTaskBoxSimple2.DockPadding.Top = 44;
			this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple2.HeaderText = "Body Flags";
			this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple2.Location = new System.Drawing.Point(200, 0);
			this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
			this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple2.Size = new System.Drawing.Size(144, 176);
			this.xpTaskBoxSimple2.TabIndex = 16;
			// 
			// cbfit
			// 
			this.cbfit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbfit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbfit.Location = new System.Drawing.Point(16, 144);
			this.cbfit.Name = "cbfit";
			this.cbfit.Size = new System.Drawing.Size(120, 24);
			this.cbfit.TabIndex = 15;
			this.cbfit.Text = "Fit";
			// 
			// cbpreginv
			// 
			this.cbpreginv.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpreginv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpreginv.Location = new System.Drawing.Point(16, 120);
			this.cbpreginv.Name = "cbpreginv";
			this.cbpreginv.Size = new System.Drawing.Size(120, 24);
			this.cbpreginv.TabIndex = 14;
			this.cbpreginv.Text = "Pregnant (invisible)";
			// 
			// cbpreghalf
			// 
			this.cbpreghalf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpreghalf.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpreghalf.Location = new System.Drawing.Point(16, 96);
			this.cbpreghalf.Name = "cbpreghalf";
			this.cbpreghalf.Size = new System.Drawing.Size(112, 24);
			this.cbpreghalf.TabIndex = 13;
			this.cbpreghalf.Text = "Pregnant (Half)";
			// 
			// cbpregfull
			// 
			this.cbpregfull.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpregfull.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpregfull.Location = new System.Drawing.Point(16, 72);
			this.cbpregfull.Name = "cbpregfull";
			this.cbpregfull.Size = new System.Drawing.Size(120, 24);
			this.cbpregfull.TabIndex = 12;
			this.cbpregfull.Text = "Pregnant (Full)";
			// 
			// cbfat
			// 
			this.cbfat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbfat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbfat.Location = new System.Drawing.Point(16, 48);
			this.cbfat.Name = "cbfat";
			this.cbfat.Size = new System.Drawing.Size(112, 24);
			this.cbfat.TabIndex = 11;
			this.cbfat.Text = "Fat";
			// 
			// xpTaskBoxSimple1
			// 
			this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple1.Controls.Add(this.cbisghost);
			this.xpTaskBoxSimple1.Controls.Add(this.cbignoretraversal);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpasspeople);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpasswalls);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpassobject);
			this.xpTaskBoxSimple1.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple1.DockPadding.Left = 4;
			this.xpTaskBoxSimple1.DockPadding.Right = 4;
			this.xpTaskBoxSimple1.DockPadding.Top = 44;
			this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple1.HeaderText = "Ghost Flags";
			this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple1.Location = new System.Drawing.Point(8, 0);
			this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
			this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple1.Size = new System.Drawing.Size(184, 176);
			this.xpTaskBoxSimple1.TabIndex = 10;
			// 
			// cbisghost
			// 
			this.cbisghost.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbisghost.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbisghost.Location = new System.Drawing.Point(16, 48);
			this.cbisghost.Name = "cbisghost";
			this.cbisghost.Size = new System.Drawing.Size(152, 24);
			this.cbisghost.TabIndex = 5;
			this.cbisghost.Text = "Is Ghost";
			// 
			// cbignoretraversal
			// 
			this.cbignoretraversal.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbignoretraversal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbignoretraversal.Location = new System.Drawing.Point(16, 144);
			this.cbignoretraversal.Name = "cbignoretraversal";
			this.cbignoretraversal.Size = new System.Drawing.Size(152, 24);
			this.cbignoretraversal.TabIndex = 9;
			this.cbignoretraversal.Text = "Ignore Traversal Costs";
			// 
			// cbpasspeople
			// 
			this.cbpasspeople.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpasspeople.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpasspeople.Location = new System.Drawing.Point(16, 120);
			this.cbpasspeople.Name = "cbpasspeople";
			this.cbpasspeople.Size = new System.Drawing.Size(160, 24);
			this.cbpasspeople.TabIndex = 8;
			this.cbpasspeople.Text = "Can Pass Through People";
			// 
			// cbpasswalls
			// 
			this.cbpasswalls.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpasswalls.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpasswalls.Location = new System.Drawing.Point(16, 96);
			this.cbpasswalls.Name = "cbpasswalls";
			this.cbpasswalls.Size = new System.Drawing.Size(152, 24);
			this.cbpasswalls.TabIndex = 7;
			this.cbpasswalls.Text = "Can Pass Through Walls";
			// 
			// cbpassobject
			// 
			this.cbpassobject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbpassobject.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbpassobject.Location = new System.Drawing.Point(16, 72);
			this.cbpassobject.Name = "cbpassobject";
			this.cbpassobject.Size = new System.Drawing.Size(160, 24);
			this.cbpassobject.TabIndex = 6;
			this.cbpassobject.Text = "Can Pass Through Objects";
			// 
			// pnEP1
			// 
			this.pnEP1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.pnEP1.BackColor = System.Drawing.Color.Transparent;
			this.pnEP1.Controls.Add(this.pbLastGrade);
			this.pnEP1.Controls.Add(this.pbUniTime);
			this.pnEP1.Controls.Add(this.pbEffort);
			this.pnEP1.Controls.Add(this.tbinfluence);
			this.pnEP1.Controls.Add(this.tbsemester);
			this.pnEP1.Controls.Add(this.label103);
			this.pnEP1.Controls.Add(this.label101);
			this.pnEP1.Controls.Add(this.cboncampus);
			this.pnEP1.Controls.Add(this.cbmajor);
			this.pnEP1.Controls.Add(this.label98);
			this.pnEP1.Controls.Add(this.tbmajor);
			this.pnEP1.Location = new System.Drawing.Point(0, 80);
			this.pnEP1.Name = "pnEP1";
			this.pnEP1.Size = new System.Drawing.Size(696, 264);
			this.pnEP1.TabIndex = 9;
			this.pnEP1.Visible = false;
			// 
			// pbLastGrade
			// 
			this.pbLastGrade.BackColor = System.Drawing.Color.Transparent;
			this.pbLastGrade.DisplayOffset = 1;
			this.pbLastGrade.DockPadding.Bottom = 5;
			this.pbLastGrade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbLastGrade.LabelText = "Last Grade:";
			this.pbLastGrade.LabelWidth = 104;
			this.pbLastGrade.Location = new System.Drawing.Point(8, 104);
			this.pbLastGrade.Maximum = 1000;
			this.pbLastGrade.Name = "pbLastGrade";
			this.pbLastGrade.NumberFormat = "N1";
			this.pbLastGrade.NumberOffset = 0;
			this.pbLastGrade.NumberScale = 0.004;
			this.pbLastGrade.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbLastGrade.Size = new System.Drawing.Size(320, 20);
			this.pbLastGrade.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbLastGrade.TabIndex = 67;
			this.pbLastGrade.TextboxWidth = 40;
			this.pbLastGrade.TokenCount = 4;
			this.pbLastGrade.UnselectedColor = System.Drawing.Color.Black;
			this.pbLastGrade.Value = 0;
			// 
			// pbUniTime
			// 
			this.pbUniTime.BackColor = System.Drawing.Color.Transparent;
			this.pbUniTime.DisplayOffset = 0;
			this.pbUniTime.DockPadding.Bottom = 5;
			this.pbUniTime.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbUniTime.LabelText = "Remaining Time:";
			this.pbUniTime.LabelWidth = 104;
			this.pbUniTime.Location = new System.Drawing.Point(8, 200);
			this.pbUniTime.Maximum = 72;
			this.pbUniTime.Name = "pbUniTime";
			this.pbUniTime.NumberFormat = "N0";
			this.pbUniTime.NumberOffset = 0;
			this.pbUniTime.NumberScale = 1;
			this.pbUniTime.SelectedColor = System.Drawing.Color.Lime;
			this.pbUniTime.Size = new System.Drawing.Size(320, 20);
			this.pbUniTime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbUniTime.TabIndex = 66;
			this.pbUniTime.TextboxWidth = 40;
			this.pbUniTime.TokenCount = 18;
			this.pbUniTime.UnselectedColor = System.Drawing.Color.Black;
			this.pbUniTime.Value = 0;
			// 
			// pbEffort
			// 
			this.pbEffort.BackColor = System.Drawing.Color.Transparent;
			this.pbEffort.DisplayOffset = 0;
			this.pbEffort.DockPadding.Bottom = 5;
			this.pbEffort.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.pbEffort.LabelText = "Effort:";
			this.pbEffort.LabelWidth = 104;
			this.pbEffort.Location = new System.Drawing.Point(8, 80);
			this.pbEffort.Maximum = 1000;
			this.pbEffort.Name = "pbEffort";
			this.pbEffort.NumberFormat = "N2";
			this.pbEffort.NumberOffset = 0;
			this.pbEffort.NumberScale = 0.01;
			this.pbEffort.SelectedColor = System.Drawing.Color.Lime;
			this.pbEffort.Size = new System.Drawing.Size(320, 20);
			this.pbEffort.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEffort.TabIndex = 65;
			this.pbEffort.TextboxWidth = 40;
			this.pbEffort.TokenCount = 10;
			this.pbEffort.UnselectedColor = System.Drawing.Color.Black;
			this.pbEffort.Value = 0;
			// 
			// tbinfluence
			// 
			this.tbinfluence.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbinfluence.Location = new System.Drawing.Point(120, 136);
			this.tbinfluence.Name = "tbinfluence";
			this.tbinfluence.Size = new System.Drawing.Size(96, 21);
			this.tbinfluence.TabIndex = 64;
			this.tbinfluence.Text = "";
			// 
			// tbsemester
			// 
			this.tbsemester.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbsemester.Location = new System.Drawing.Point(120, 168);
			this.tbsemester.Name = "tbsemester";
			this.tbsemester.Size = new System.Drawing.Size(40, 21);
			this.tbsemester.TabIndex = 63;
			this.tbsemester.Text = "";
			// 
			// label103
			// 
			this.label103.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label103.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label103.Location = new System.Drawing.Point(8, 176);
			this.label103.Name = "label103";
			this.label103.Size = new System.Drawing.Size(104, 17);
			this.label103.TabIndex = 62;
			this.label103.Text = "Semester:";
			this.label103.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label101
			// 
			this.label101.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label101.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label101.Location = new System.Drawing.Point(8, 136);
			this.label101.Name = "label101";
			this.label101.Size = new System.Drawing.Size(104, 24);
			this.label101.TabIndex = 61;
			this.label101.Text = "Influence:";
			this.label101.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cboncampus
			// 
			this.cboncampus.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cboncampus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cboncampus.Location = new System.Drawing.Point(16, 16);
			this.cboncampus.Name = "cboncampus";
			this.cboncampus.Size = new System.Drawing.Size(200, 24);
			this.cboncampus.TabIndex = 60;
			this.cboncampus.Text = "On Campus (Is young Adult)";
			// 
			// cbmajor
			// 
			this.cbmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmajor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.cbmajor.ItemHeight = 13;
			this.cbmajor.Location = new System.Drawing.Point(120, 48);
			this.cbmajor.Name = "cbmajor";
			this.cbmajor.Size = new System.Drawing.Size(120, 21);
			this.cbmajor.TabIndex = 58;
			this.cbmajor.SelectedIndexChanged += new System.EventHandler(this.cbmajor_SelectedIndexChanged);
			// 
			// label98
			// 
			this.label98.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label98.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label98.Location = new System.Drawing.Point(8, 56);
			this.label98.Name = "label98";
			this.label98.Size = new System.Drawing.Size(104, 17);
			this.label98.TabIndex = 57;
			this.label98.Text = "Major:";
			this.label98.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// tbmajor
			// 
			this.tbmajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbmajor.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.tbmajor.Location = new System.Drawing.Point(248, 56);
			this.tbmajor.Name = "tbmajor";
			this.tbmajor.Size = new System.Drawing.Size(80, 14);
			this.tbmajor.TabIndex = 59;
			this.tbmajor.Text = "";
			this.tbmajor.Visible = false;
			// 
			// ExtSDesc
			// 
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.pnCareer);
			this.Controls.Add(this.pnEP1);
			this.Controls.Add(this.pnMisc);
			this.Controls.Add(this.pnRel);
			this.Controls.Add(this.pnInt);
			this.Controls.Add(this.pnChar);
			this.Controls.Add(this.pnId);
			this.Controls.Add(this.pnSkill);
			this.DockPadding.Top = 24;
			this.Name = "ExtSDesc";
			this.Size = new System.Drawing.Size(696, 344);
			this.Commited += new System.EventHandler(this.ExtSDesc_Commited);
			this.Controls.SetChildIndex(this.pnSkill, 0);
			this.Controls.SetChildIndex(this.pnId, 0);
			this.Controls.SetChildIndex(this.pnChar, 0);
			this.Controls.SetChildIndex(this.pnInt, 0);
			this.Controls.SetChildIndex(this.pnRel, 0);
			this.Controls.SetChildIndex(this.pnMisc, 0);
			this.Controls.SetChildIndex(this.pnEP1, 0);
			this.Controls.SetChildIndex(this.pnCareer, 0);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.pnId.ResumeLayout(false);
			this.pnSkill.ResumeLayout(false);
			this.pnChar.ResumeLayout(false);
			this.pnCareer.ResumeLayout(false);
			this.pnInt.ResumeLayout(false);
			this.pnMisc.ResumeLayout(false);
			this.xpTaskBoxSimple3.ResumeLayout(false);
			this.xpTaskBoxSimple2.ResumeLayout(false);
			this.xpTaskBoxSimple1.ResumeLayout(false);
			this.pnEP1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		public void SelectButton(TD.SandBar.ButtonItem b)
		{
			for (int i=0; i<this.toolBar1.Items.Count; i++)
			{
				if (toolBar1.Items[i] is TD.SandBar.ButtonItem ) 
				{
					TD.SandBar.ButtonItem item = (TD.SandBar.ButtonItem )toolBar1.Items[i];
					item.Checked = (item==b);
					
					if (item.Tag!=null) 
					{
						Panel pn = (Panel)item.Tag;
						pn.Visible = item.Checked;
					}
				}
			}

			biMax.Enabled = pnSkill.Visible || pnChar.Visible || pnInt.Visible;
		}
		
		private void ChoosePage(object sender, System.EventArgs e)
		{
			SelectButton((TD.SandBar.ButtonItem)sender);
		}

		void InitDropDowns()
		{
			/*this.cboutfamtype.Items.Clear();
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Unset_Unknown));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Aunt));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Child));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Cousin));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Grandchild));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Gradparent));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Nice_Nephew));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Parent));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Sibling));
			this.cboutfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Spouses));

			this.cbinfamtype.Items.Clear();
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Unset_Unknown));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Aunt));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Child));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Cousin));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Grandchild));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Gradparent));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Nice_Nephew));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Parent));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Sibling));
			this.cbinfamtype.Items.Add(new LocalizedRelationshipTypes(Data.MetaData.RelationshipTypes.Spouses));*/

			this.cbaspiration.Items.Clear();
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Nothing));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Fortune));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Family));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Knowledge));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Reputation));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Romance));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Growup));

			
			this.cblifesection.Items.Clear();
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Unknown));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Baby));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Toddler));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Child));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Teen));
			//this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.YoungAdult));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Adult));
			this.cblifesection.Items.Add(new LocalizedLifeSections(Data.MetaData.LifeSections.Elder));

			this.cbcareer.Items.Clear();
			foreach (SimPe.Interfaces.IAlias a in SimPe.PackedFiles.Wrapper.SDesc.AddonCarrers) this.cbcareer.Items.Add(a);
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Unknown));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Unemployed));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Science));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Medical));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Politics));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Athletic));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.LawEnforcement));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Culinary));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Business));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Slacker));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Criminal));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Military));
			
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderAthletic));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderBusiness));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderCriminal));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderCulinary));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderLawEnforcement));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderMedical));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderMilitary));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderPolitics));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderScience));
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.TeenElderSlacker));			
			if ((Helper.WindowsRegistry.EPInstalled>=1) || (Helper.WindowsRegistry.HiddenMode))
			{
				this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Paranormal));
				this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.NaturalScientist));
				this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.ShowBiz));
				this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Artist));
			}

			this.cbgrade.Items.Clear();
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.Unknown));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.APlus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.A));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.AMinus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.BPlus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.B));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.BMinus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.CPlus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.C));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.CMinus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.DPlus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.D));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.DMinus));
			this.cbgrade.Items.Add(new LocalizedGrades(Data.MetaData.Grades.F));			

			this.cbmajor.Items.Clear();
			
			foreach (SimPe.Interfaces.IAlias a in SimPe.PackedFiles.Wrapper.SDesc.AddonMajors) this.cbmajor.Items.Add(a);
			System.Array majors = System.Enum.GetValues(typeof(Data.Majors));
			foreach (Data.Majors c in majors) this.cbmajor.Items.Add(c);

			this.cbschooltype.Items.Clear();
			System.Array schools = System.Enum.GetValues(typeof(Data.MetaData.SchoolTypes));
			foreach (Data.MetaData.SchoolTypes c in schools) this.cbschooltype.Items.Add(new LocalizedSchoolType(c));
			foreach (SimPe.Interfaces.IAlias a in SimPe.PackedFiles.Wrapper.SDesc.AddonSchools) this.cbschooltype.Items.Add(a);

			this.cbzodiac.Items.Clear();
			for (ushort i=0x01; i<=0x0C; i++) this.cbzodiac.Items.Add(new LocalizedZodiacSignes((Data.MetaData.ZodiacSignes)i));
		}

		#region IPackedFileUI Member

		
		public Wrapper.ExtSDesc Sdesc
		{
			get { return (SimPe.PackedFiles.Wrapper.ExtSDesc)Wrapper; }
		}
		

		protected override void RefreshGUI()
		{
			base.RefreshGUI ();
		
			RefreshSkills(Sdesc);
			RefreshId(Sdesc);
			RefreshCareer(Sdesc);
			RefreshCharcter(Sdesc);
			RefreshInterests(Sdesc);
			RefreshMisc(Sdesc);

			this.biEP1.Enabled = Sdesc.Version == SimPe.PackedFiles.Wrapper.SDescVersions.University;
			if (pnEP1.Visible && !biEP1.Enabled) this.SelectButton(biId);

			if (biEP1.Enabled) RefreshEP1(Sdesc);
		}

		void RefreshEP1(Wrapper.ExtSDesc sdesc)
		{
			this.cbmajor.SelectedIndex = 0;
			this.tbmajor.Text = "0x"+Helper.HexString((uint)sdesc.University.Major);		
			this.tbmajor.Visible = Helper.WindowsRegistry.HiddenMode;
			this.cbmajor.SelectedIndex = this.cbmajor.Items.Count -1;
			for (int i=0;i<this.cbmajor.Items.Count;i++)
			{					 
				object o = this.cbmajor.Items[i];
				Data.Majors at;
				if (o.GetType()==typeof(Alias)) at = (Data.Majors)((uint)((Alias)o).Id);
				else at = (Data.Majors)o;
					
				if (at==sdesc.University.Major) 
				{
					this.cbmajor.SelectedIndex = i;
					break;
				}
			}

			this.cboncampus.Checked = (sdesc.University.OnCampus==0x1);
			this.pbEffort.Value = sdesc.University.Effort;
			this.pbLastGrade.Value = sdesc.University.Grade;

			this.pbUniTime.Value = sdesc.University.Time;
			this.tbinfluence.Text = sdesc.University.Influence.ToString();
			this.tbsemester.Text = sdesc.University.Semester.ToString();
		}

		void RefreshSkills(Wrapper.ExtSDesc sdesc)
		{
			this.pbBody.Value = sdesc.Skills.Body;
			this.pbCharisma.Value = sdesc.Skills.Charisma;
			this.pbClean.Value = sdesc.Skills.Cleaning;
			this.pbCooking.Value = sdesc.Skills.Cooking;
			this.pbCreative.Value = sdesc.Skills.Creativity;
			this.pbFat.Value = sdesc.Skills.Fatness;
			this.pbLogic.Value = sdesc.Skills.Logic;
			this.pbMech.Value = sdesc.Skills.Mechanical;
			this.pbRomance.Value = sdesc.Skills.Romance;
		}

		void RefreshMisc(Wrapper.ExtSDesc sdesc)
		{
			//ghostflags
			this.cbisghost.Checked = sdesc.CharacterDescription.GhostFlag.IsGhost;
			this.cbpassobject.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughObjects;
			this.cbpasswalls.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughWalls;
			this.cbpasspeople.Checked = sdesc.CharacterDescription.GhostFlag.CanPassThroughPeople;
			this.cbignoretraversal.Checked = sdesc.CharacterDescription.GhostFlag.IgnoreTraversalCosts;

			//body flags
			this.cbfit.Checked = sdesc.CharacterDescription.BodyFlag.Fit;
			this.cbfat.Checked = sdesc.CharacterDescription.BodyFlag.Fat;
			this.cbpregfull.Checked = sdesc.CharacterDescription.BodyFlag.PregnantFull;
			this.cbpreghalf.Checked = sdesc.CharacterDescription.BodyFlag.PregnantHalf;
			this.cbpreginv.Checked = sdesc.CharacterDescription.BodyFlag.PregnantHidden;
		}

		void RefreshId(Wrapper.ExtSDesc sdesc)
		{
			this.tbage.Text = sdesc.CharacterDescription.Age.ToString();
			this.tbsimdescname.Text = sdesc.SimName;
			this.tbsimdescfamname.Text = sdesc.SimFamilyName;
			this.tbsim.Text = "0x"+Helper.HexString(sdesc.SimId);
			this.tbsim.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			this.tbfaminst.Text = "0x"+Helper.HexString(sdesc.FamilyInstance);
			//this.tbprevdays.Text = sdesc.CharacterDescription.PrevAgeDays.ToString();
			//this.tbagedur.Text = sdesc.CharacterDescription.AgeDuration.ToString();
			//this.tbunlinked.Text = "0x"+this.HexString(sdesc.Unlinked);
			if (sdesc.Image!=null) 
				if (sdesc.Image.Width>5) this.pbImage.Image = sdesc.Image;

			//Lifesection
			this.cblifesection.SelectedIndex = 0;
			for (int i=0;i<this.cblifesection.Items.Count;i++)
			{
				Data.MetaData.LifeSections at = (LocalizedLifeSections)this.cblifesection.Items[i];
				if (at==sdesc.CharacterDescription.LifeSection) 
				{
					this.cblifesection.SelectedIndex = i;
					break;
				}
			}

			this.rbfemale.Checked = (sdesc.CharacterDescription.Gender == Data.MetaData.Gender.Female);
			this.rbmale.Checked = (sdesc.CharacterDescription.Gender == Data.MetaData.Gender.Male);
		}

		void RefreshCareer(Wrapper.ExtSDesc sdesc)
		{
			this.pbCareerLevel.Value = sdesc.CharacterDescription.CareerLevel;
			this.pbCareerPerformance.Value = sdesc.CharacterDescription.CareerPerformance;

			//Career
			this.tbcareervalue.Text = "0x"+Helper.HexString((uint)sdesc.CharacterDescription.Career);
			this.cbcareer.SelectedIndex = 0;
			for (int i=0;i<this.cbcareer.Items.Count;i++)
			{
				object o = this.cbcareer.Items[i];
				Data.MetaData.Careers at;
				if (o.GetType()==typeof(Alias)) at = (Data.LocalizedCareers)((uint)((Alias)o).Id); 
				else at = (Data.LocalizedCareers)o;
				
				if (at==sdesc.CharacterDescription.Career) 
				{
					this.cbcareer.SelectedIndex = i;
					break;
				}
			}

			//school
			this.cbschooltype.SelectedIndex = 0;
			this.tbschooltype.Visible = true;
			this.tbschooltype.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			for(int i=0; i<this.cbschooltype.Items.Count; i++)
			{
				Data.LocalizedSchoolType type;
				object o = this.cbschooltype.Items[i];
				if (o.GetType()==typeof(Alias)) type = (Data.LocalizedSchoolType)((uint)((Alias)o).Id); 
				else type = (Data.LocalizedSchoolType)o;
				
				if (sdesc.CharacterDescription.SchoolType == (Data.MetaData.SchoolTypes)type) 
				{
					this.cbschooltype.SelectedIndex = i;
					break;
				}
			}

			this.tbschooltype.Text = "0x"+Helper.HexString((uint)sdesc.CharacterDescription.SchoolType);

			//grades and school
			this.cbgrade.SelectedIndex = 0;
			for(int i=0; i<this.cbgrade.Items.Count; i++)
			{
				Data.MetaData.Grades grade;
				object o = this.cbgrade.Items[i];
				if (o.GetType()==typeof(Alias)) grade = (Data.LocalizedGrades)((uint)((Alias)o).Id); 
				else grade = (Data.LocalizedGrades)o;
				if (sdesc.CharacterDescription.Grade == (Data.MetaData.Grades)grade) 
				{
					this.cbgrade.SelectedIndex = i;
					break;
				}
			}

			//Aspiration
			this.pbAspBliz.Value = sdesc.CharacterDescription.BlizLifelinePoints;
			this.pbAspCur.Value = sdesc.CharacterDescription.LifelinePoints;

			
			this.cbaspiration.SelectedIndex = 0;
			for (int i=0;i<this.cbaspiration.Items.Count;i++)
			{
				Data.MetaData.AspirationTypes at = (LocalizedAspirationTypes)this.cbaspiration.Items[i];
				if (at==sdesc.CharacterDescription.Aspiration) 
				{
					this.cbaspiration.SelectedIndex = i;
					break;
				}
			}			
			this.tblifelinescore.Text = sdesc.CharacterDescription.LifelineScore.ToString();
		}

		void RefreshInterests(Wrapper.ExtSDesc sdesc)
		{
			this.pbAnimals.Value = sdesc.Interests.Animals;
			this.pbCrime.Value = sdesc.Interests.Crime;
			this.pbCulture.Value = sdesc.Interests.Culture;
			this.pbEntertainment.Value = sdesc.Interests.Entertainment;
			this.pbEnvironment.Value = sdesc.Interests.Environment; 
			this.pbFashion.Value = sdesc.Interests.Fashion;
			this.pbFood.Value = sdesc.Interests.Food;
			this.pbHealth.Value = sdesc.Interests.Health;
			this.pbMoney.Value = sdesc.Interests.Money;
			this.pbParanormal.Value = sdesc.Interests.Paranormal;
			this.pbPolitics.Value = sdesc.Interests.Politics;
			this.pbSchool.Value = sdesc.Interests.School;
			this.pbSciFi.Value = sdesc.Interests.Scifi;
			this.pbSports.Value = sdesc.Interests.Sports ;
			this.pbToys.Value = sdesc.Interests.Toys;
			this.pbTravel.Value = sdesc.Interests.Travel;
			this.pbWeather.Value = sdesc.Interests.Weather;
			this.pbWork.Value = sdesc.Interests.Work;			
		}

		void RefreshCharcter(Wrapper.ExtSDesc sdesc)
		{
			
			this.cbzodiac.SelectedIndex = ((ushort)sdesc.CharacterDescription.ZodiacSign-1);

			//Character
			this.pbNeat.Value = sdesc.Character.Neat;
			this.pbOutgoing.Value = sdesc.Character.Outgoing;
			this.pbActive.Value = sdesc.Character.Active;
			this.pbPlayful.Value = sdesc.Character.Playful;
			this.pbNice.Value = sdesc.Character.Nice;

			//Genetic Character
			this.pbGNeat.Value = sdesc.GeneticCharacter.Neat;
			this.pbGOutgoing.Value = sdesc.GeneticCharacter.Outgoing;
			this.pbGActive.Value = sdesc.GeneticCharacter.Active;
			this.pbGPlayful.Value = sdesc.GeneticCharacter.Playful;
			this.pbGNice.Value = sdesc.GeneticCharacter.Nice;

			pbWoman.Value = sdesc.Interests.Woman;
			pbMan.Value = sdesc.Interests.Man;
		}

		#endregion

		private void Activate_biMax(object sender, System.EventArgs e)
		{
			if (this.pnSkill.Visible) 
			{
				foreach (Control c in pnSkill.Controls)
				{
					if (c == this.pbFat) 
					{
						((LabeledProgressBar)c).Value = 0;
					} 
					else if (c is LabeledProgressBar)
					{
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
					}
				}
			} 
			else if(this.pnChar.Visible) 
			{
				foreach (Control c in pnChar.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
			}
			else if(this.pnInt.Visible) 
			{
				foreach (Control c in pnInt.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
			}
		}

		private void Activate_biMore(object sender, System.EventArgs e)
		{
			
			SdscExtendedForm.Execute(this.Sdesc);
		}

		private void ExtSDesc_Commited(object sender, System.EventArgs e)
		{
			Sdesc.SynchronizeUserData();
		}

		private void cbmajor_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbmajor.SelectedIndex<0) return;
			object o = cbmajor.Items[cbmajor.SelectedIndex];
			Data.Majors v;
			if (o.GetType()==typeof(Data.Alias)) v = (Data.Majors)((Data.Alias)o).Id; 
			else v = (Data.Majors)o;
			
			if ( v == Data.Majors.Unknown) return;

			tbmajor.Text = "0x"+Helper.HexString((uint)v);
		}

		private void cbcareer_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbcareer.SelectedIndex<0) return;
			object o = cbcareer.Items[cbcareer.SelectedIndex];
			if (o.GetType()!=typeof(Data.Alias)) 
			{
				Data.MetaData.Careers career = (Data.LocalizedCareers)o;
				if (career != Data.MetaData.Careers.Unknown) 
				{
					tbcareervalue.Text = "0x"+Helper.HexString((uint)career);
				}
			} 
			else 
			{
				Data.Alias a = (Data.Alias)o;
				tbcareervalue.Text = "0x"+Helper.HexString((uint)a.Id);
			}
		}

		private void cbschooltype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (cbschooltype.SelectedIndex<0) return;
			object o = cbschooltype.Items[cbschooltype.SelectedIndex];
			if (o.GetType()!=typeof(Data.Alias)) 
			{
				Data.MetaData.SchoolTypes st = (Data.LocalizedSchoolType)o;
				if (st != Data.MetaData.SchoolTypes.Unknown) 
				{
					tbschooltype.Text = "0x"+Helper.HexString((uint)st);
				}
			} 
			else 
			{
				Data.Alias a = (Data.Alias)o;
				tbschooltype.Text = "0x"+Helper.HexString((uint)a.Id);
			}
		}


		
	}
}
