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
using SimPe.Windows.Forms;

namespace SimPe.PackedFiles.UserInterface
{
	/// <summary>
	/// Zusammenfassung für ExtSDescUI.
	/// </summary>
	public class ExtSDesc : 
		//System.Windows.Forms.UserControl 
		SimPe.Windows.Forms.WrapperBaseControl, IPackedFileUI
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
		private System.Windows.Forms.Panel pnEP2;
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
		private TD.SandBar.MenuBar menuBar1;
		private TD.SandBar.MenuButtonItem mbiMax;
		private TD.SandBar.ContextMenuBarItem mbiLink;
		private TD.SandBar.MenuButtonItem miRand;
		private TD.SandBar.MenuButtonItem miOpenChar;
		private TD.SandBar.MenuButtonItem miOpenDNA;
		private TD.SandBar.MenuButtonItem miOpenFamily;
		private TD.SandBar.MenuButtonItem miOpenCloth;
		private TD.SandBar.MenuButtonItem miMore;
		private TD.SandBar.MenuButtonItem miRelink;
		private TD.SandBar.MenuButtonItem miOpenWf;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox tbstatmot;
		private System.Windows.Forms.Panel panel3;
		private SimPe.PackedFiles.Wrapper.SimListView lv;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private SimPe.PackedFiles.UserInterface.CommonSrel srcRel;
		private SimPe.PackedFiles.UserInterface.CommonSrel dstRel;
		private Ambertation.Windows.Forms.XPTaskBoxSimple srcTb;
		private Ambertation.Windows.Forms.XPTaskBoxSimple dstTb;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private TD.SandBar.ContextMenuBarItem miRel;
		private TD.SandBar.MenuButtonItem miAddRelation;
		private TD.SandBar.MenuButtonItem miRemRelation;
		private System.ComponentModel.IContainer components;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private TD.SandBar.ButtonItem biEP2;
		private System.Windows.Forms.CheckedListBox lbTraits;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckedListBox lbTurnOn;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.CheckedListBox lbTurnOff;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tbNTPerfume;
		private System.Windows.Forms.TextBox tbNTLove;
		private TD.SandBar.ButtonItem biEP3;
		private System.Windows.Forms.Panel pnEP3;
		private System.Windows.Forms.TextBox tbEp3Flag;
		private System.Windows.Forms.TextBox tbEp3Lot;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private Ambertation.Windows.Forms.EnumComboBox cbEp3Asgn;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbEp3Salery;
		private System.Windows.Forms.Label label14;
		private TD.SandBar.MenuButtonItem miOpenMem;
		private TD.SandBar.MenuButtonItem miOpenBadge;
		private SimPe.PackedFiles.Wrapper.SimBusinessList sblb;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.LinkLabel llep3openinfo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private TD.SandBar.MenuButtonItem mbiMaxThisRel;
		private TD.SandBar.MenuButtonItem mbiMaxKnownRel;

		
		System.Resources.ResourceManager strresources;
		public ExtSDesc()
		{
			
			strresources = new System.Resources.ResourceManager(typeof(ExtSDesc));
			Text = SimPe.Localization.GetString("Sim Description Editor");
			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();	
			Initialize();

			toolBar1.Renderer = new TD.SandBar.MediaPlayerRenderer();
			toolBar1.Overflow = TD.SandBar.ToolBarOverflow.Chevron;

			ThemeManager.AddControl(this.toolBar1);
			ThemeManager.AddControl(this.menuBar1);
			ThemeManager.AddControl(this.srcTb);
			ThemeManager.AddControl(this.dstTb);
			ThemeManager.AddControl(this.xpTaskBoxSimple1);
			ThemeManager.AddControl(this.xpTaskBoxSimple2);
			ThemeManager.AddControl(this.xpTaskBoxSimple3);
			this.biId.Tag = pnId;	
			this.biSkill.Tag = pnSkill;
			this.biChar.Tag = pnChar;
			this.biCareer.Tag = pnCareer;
			this.biEP1.Tag = pnEP1;
			this.biEP2.Tag = pnEP2;
			this.biEP3.Tag = pnEP3;
			this.biInt.Tag = pnInt;
			this.biRel.Tag = pnRel;
			this.biMisc.Tag = pnMisc;
		
			this.tbsim.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			this.miRelink.Enabled = Helper.WindowsRegistry.HiddenMode;

			
			InitDropDowns();
			SelectButton(biId);

			if (System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName=="en")
				pbLastGrade.DisplayOffset = 0;
			else
				pbLastGrade.DisplayOffset = 1;
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

		void Initialize()
		{			
			this.tbEp3Flag.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			this.tbEp3Lot.ReadOnly = !Helper.WindowsRegistry.HiddenMode;

			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExtSDesc));
			this.Commited += new System.EventHandler(this.ExtSDesc_Commited);

			this.srcRel = new SimPe.PackedFiles.UserInterface.CommonSrel();
			this.dstRel = new SimPe.PackedFiles.UserInterface.CommonSrel();

			this.srcTb.Controls.Add(this.srcRel);
			this.dstTb.Controls.Add(this.dstRel);

			// 
			// srcRel
			// 
			this.srcRel.Dock = DockStyle.Fill;
			this.srcRel.Enabled = false;
			this.srcRel.Name = "srcRel";
			this.srcRel.Srel = null;
			this.srcRel.Visible = true;

			// 
			// dstRel
			// 
			this.dstRel.Dock = DockStyle.Fill;
			this.dstRel.Enabled = false;
			this.dstRel.Name = "dstRel";
			this.dstRel.Srel = null;
			this.dstRel.Visible = true;

			this.cbEp3Asgn.ResourceManager = SimPe.Localization.Manager;
			this.cbEp3Asgn.Enum = typeof (Wrapper.JobAssignment);			
		}
		#region Vom Komponenten-Designer generierter Code
		/// <summary> 
		/// Erforderliche Methode für die Designerunterstützung. 
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ExtSDesc));
			SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup1 = new SteepValley.Windows.Forms.XPListViewGroup("Relations", 0);
			SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup2 = new SteepValley.Windows.Forms.XPListViewGroup("Unknown Relations", 2);
			SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup3 = new SteepValley.Windows.Forms.XPListViewGroup("Sim Pool", 1);
			SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup4 = new SteepValley.Windows.Forms.XPListViewGroup("NPC", 3);
			SteepValley.Windows.Forms.XPListViewGroup xpListViewGroup5 = new SteepValley.Windows.Forms.XPListViewGroup("Townie", 4);
			this.toolBar1 = new TD.SandBar.ToolBar();
			this.biId = new TD.SandBar.ButtonItem();
			this.biCareer = new TD.SandBar.ButtonItem();
			this.biRel = new TD.SandBar.ButtonItem();
			this.biInt = new TD.SandBar.ButtonItem();
			this.biChar = new TD.SandBar.ButtonItem();
			this.biSkill = new TD.SandBar.ButtonItem();
			this.biMisc = new TD.SandBar.ButtonItem();
			this.biEP1 = new TD.SandBar.ButtonItem();
			this.biEP2 = new TD.SandBar.ButtonItem();
			this.biEP3 = new TD.SandBar.ButtonItem();
			this.biMore = new TD.SandBar.ButtonItem();
			this.biMax = new TD.SandBar.ButtonItem();
			this.mbiMax = new TD.SandBar.MenuButtonItem();
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
			this.menuBar1 = new TD.SandBar.MenuBar();
			this.mbiLink = new TD.SandBar.ContextMenuBarItem();
			this.miRand = new TD.SandBar.MenuButtonItem();
			this.miOpenChar = new TD.SandBar.MenuButtonItem();
			this.miOpenWf = new TD.SandBar.MenuButtonItem();
			this.miOpenMem = new TD.SandBar.MenuButtonItem();
			this.miOpenBadge = new TD.SandBar.MenuButtonItem();
			this.miOpenDNA = new TD.SandBar.MenuButtonItem();
			this.miOpenFamily = new TD.SandBar.MenuButtonItem();
			this.miOpenCloth = new TD.SandBar.MenuButtonItem();
			this.miMore = new TD.SandBar.MenuButtonItem();
			this.miRelink = new TD.SandBar.MenuButtonItem();
			this.miRel = new TD.SandBar.ContextMenuBarItem();
			this.miAddRelation = new TD.SandBar.MenuButtonItem();
			this.miRemRelation = new TD.SandBar.MenuButtonItem();
			this.mbiMaxThisRel = new TD.SandBar.MenuButtonItem();
			this.mbiMaxKnownRel = new TD.SandBar.MenuButtonItem();
			this.lv = new SimPe.PackedFiles.Wrapper.SimListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
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
			this.panel3 = new System.Windows.Forms.Panel();
			this.srcTb = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.dstTb = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.pnMisc = new System.Windows.Forms.Panel();
			this.xpTaskBoxSimple3 = new Ambertation.Windows.Forms.XPTaskBoxSimple();
			this.label3 = new System.Windows.Forms.Label();
			this.tbstatmot = new System.Windows.Forms.TextBox();
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
			this.pnEP2 = new System.Windows.Forms.Panel();
			this.tbNTLove = new System.Windows.Forms.TextBox();
			this.tbNTPerfume = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lbTurnOff = new System.Windows.Forms.CheckedListBox();
			this.label6 = new System.Windows.Forms.Label();
			this.lbTurnOn = new System.Windows.Forms.CheckedListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.lbTraits = new System.Windows.Forms.CheckedListBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pnEP3 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.llep3openinfo = new System.Windows.Forms.LinkLabel();
			this.label15 = new System.Windows.Forms.Label();
			this.sblb = new SimPe.PackedFiles.Wrapper.SimBusinessList();
			this.tbEp3Salery = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.cbEp3Asgn = new Ambertation.Windows.Forms.EnumComboBox();
			this.tbEp3Flag = new System.Windows.Forms.TextBox();
			this.tbEp3Lot = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pnId.SuspendLayout();
			this.pnSkill.SuspendLayout();
			this.pnChar.SuspendLayout();
			this.pnCareer.SuspendLayout();
			this.pnInt.SuspendLayout();
			this.pnRel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.pnMisc.SuspendLayout();
			this.xpTaskBoxSimple3.SuspendLayout();
			this.xpTaskBoxSimple2.SuspendLayout();
			this.xpTaskBoxSimple1.SuspendLayout();
			this.pnEP1.SuspendLayout();
			this.pnEP2.SuspendLayout();
			this.pnEP3.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolBar1
			// 
			this.toolBar1.AccessibleDescription = resources.GetString("toolBar1.AccessibleDescription");
			this.toolBar1.AccessibleName = resources.GetString("toolBar1.AccessibleName");
			this.toolBar1.AddRemoveButtonsVisible = false;
			this.toolBar1.AllowVerticalDock = false;
			this.toolBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("toolBar1.Anchor")));
			this.toolBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolBar1.BackgroundImage")));
			this.toolBar1.Closable = false;
			this.toolBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("toolBar1.Dock")));
			this.toolBar1.DrawActionsButton = false;
			this.toolBar1.Enabled = ((bool)(resources.GetObject("toolBar1.Enabled")));
			this.toolBar1.FlipLastItem = true;
			this.toolBar1.Font = ((System.Drawing.Font)(resources.GetObject("toolBar1.Font")));
			this.toolBar1.Guid = new System.Guid("c26fb528-33c1-46f9-bd39-8516b25c4289");
			this.toolBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("toolBar1.ImeMode")));
			this.toolBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.biId,
																			  this.biCareer,
																			  this.biRel,
																			  this.biInt,
																			  this.biChar,
																			  this.biSkill,
																			  this.biMisc,
																			  this.biEP1,
																			  this.biEP2,
																			  this.biEP3,
																			  this.biMore,
																			  this.biMax});
			this.toolBar1.Location = ((System.Drawing.Point)(resources.GetObject("toolBar1.Location")));
			this.toolBar1.Movable = false;
			this.toolBar1.Name = "toolBar1";
			this.toolBar1.Resizable = false;
			this.toolBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("toolBar1.RightToLeft")));
			this.toolBar1.ShowShortcutsInToolTips = true;
			this.toolBar1.Size = ((System.Drawing.Size)(resources.GetObject("toolBar1.Size")));
			this.toolBar1.TabIndex = ((int)(resources.GetObject("toolBar1.TabIndex")));
			this.toolBar1.Tearable = false;
			this.toolBar1.Text = resources.GetString("toolBar1.Text");
			this.toolBar1.TextAlign = TD.SandBar.ToolBarTextAlign.Underneath;
			this.toolBar1.Visible = ((bool)(resources.GetObject("toolBar1.Visible")));
			// 
			// biId
			// 
			this.biId.Image = ((System.Drawing.Image)(resources.GetObject("biId.Image")));
			this.biId.Text = resources.GetString("biId.Text");
			this.biId.ToolTipText = resources.GetString("biId.ToolTipText");
			this.biId.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biCareer
			// 
			this.biCareer.Image = ((System.Drawing.Image)(resources.GetObject("biCareer.Image")));
			this.biCareer.Text = resources.GetString("biCareer.Text");
			this.biCareer.ToolTipText = resources.GetString("biCareer.ToolTipText");
			this.biCareer.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biRel
			// 
			this.biRel.Image = ((System.Drawing.Image)(resources.GetObject("biRel.Image")));
			this.biRel.Text = resources.GetString("biRel.Text");
			this.biRel.ToolTipText = resources.GetString("biRel.ToolTipText");
			this.biRel.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biInt
			// 
			this.biInt.Image = ((System.Drawing.Image)(resources.GetObject("biInt.Image")));
			this.biInt.Text = resources.GetString("biInt.Text");
			this.biInt.ToolTipText = resources.GetString("biInt.ToolTipText");
			this.biInt.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biChar
			// 
			this.biChar.Image = ((System.Drawing.Image)(resources.GetObject("biChar.Image")));
			this.biChar.Text = resources.GetString("biChar.Text");
			this.biChar.ToolTipText = resources.GetString("biChar.ToolTipText");
			this.biChar.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biSkill
			// 
			this.biSkill.Image = ((System.Drawing.Image)(resources.GetObject("biSkill.Image")));
			this.biSkill.Text = resources.GetString("biSkill.Text");
			this.biSkill.ToolTipText = resources.GetString("biSkill.ToolTipText");
			this.biSkill.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biMisc
			// 
			this.biMisc.Image = ((System.Drawing.Image)(resources.GetObject("biMisc.Image")));
			this.biMisc.Text = resources.GetString("biMisc.Text");
			this.biMisc.ToolTipText = resources.GetString("biMisc.ToolTipText");
			this.biMisc.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biEP1
			// 
			this.biEP1.Enabled = false;
			this.biEP1.Image = ((System.Drawing.Image)(resources.GetObject("biEP1.Image")));
			this.biEP1.Text = resources.GetString("biEP1.Text");
			this.biEP1.ToolTipText = resources.GetString("biEP1.ToolTipText");
			this.biEP1.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biEP2
			// 
			this.biEP2.Enabled = false;
			this.biEP2.Image = ((System.Drawing.Image)(resources.GetObject("biEP2.Image")));
			this.biEP2.Text = resources.GetString("biEP2.Text");
			this.biEP2.ToolTipText = resources.GetString("biEP2.ToolTipText");
			this.biEP2.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biEP3
			// 
			this.biEP3.Enabled = false;
			this.biEP3.Image = ((System.Drawing.Image)(resources.GetObject("biEP3.Image")));
			this.biEP3.Text = resources.GetString("biEP3.Text");
			this.biEP3.ToolTipText = resources.GetString("biEP3.ToolTipText");
			this.biEP3.Activate += new System.EventHandler(this.ChoosePage);
			// 
			// biMore
			// 
			this.biMore.Image = ((System.Drawing.Image)(resources.GetObject("biMore.Image")));
			this.biMore.Text = resources.GetString("biMore.Text");
			this.biMore.ToolTipText = resources.GetString("biMore.ToolTipText");
			this.biMore.Activate += new System.EventHandler(this.Activate_biMore);
			// 
			// biMax
			// 
			this.biMax.BuddyMenu = this.mbiMax;
			this.biMax.Image = ((System.Drawing.Image)(resources.GetObject("biMax.Image")));
			this.biMax.Text = resources.GetString("biMax.Text");
			this.biMax.ToolTipText = resources.GetString("biMax.ToolTipText");
			// 
			// mbiMax
			// 
			this.mbiMax.Image = ((System.Drawing.Image)(resources.GetObject("mbiMax.Image")));
			this.mbiMax.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMax.Shortcut")));
			this.mbiMax.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMax.Shortcut2")));
			this.mbiMax.Text = resources.GetString("mbiMax.Text");
			this.mbiMax.ToolTipText = resources.GetString("mbiMax.ToolTipText");
			this.mbiMax.Activate += new System.EventHandler(this.Activate_biMax);
			// 
			// pnId
			// 
			this.pnId.AccessibleDescription = resources.GetString("pnId.AccessibleDescription");
			this.pnId.AccessibleName = resources.GetString("pnId.AccessibleName");
			this.pnId.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnId.Anchor")));
			this.pnId.AutoScroll = ((bool)(resources.GetObject("pnId.AutoScroll")));
			this.pnId.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnId.AutoScrollMargin")));
			this.pnId.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnId.AutoScrollMinSize")));
			this.pnId.BackColor = System.Drawing.Color.Transparent;
			this.pnId.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnId.BackgroundImage")));
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
			this.pnId.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnId.Dock")));
			this.pnId.Enabled = ((bool)(resources.GetObject("pnId.Enabled")));
			this.pnId.Font = ((System.Drawing.Font)(resources.GetObject("pnId.Font")));
			this.pnId.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnId.ImeMode")));
			this.pnId.Location = ((System.Drawing.Point)(resources.GetObject("pnId.Location")));
			this.pnId.Name = "pnId";
			this.pnId.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnId.RightToLeft")));
			this.pnId.Size = ((System.Drawing.Size)(resources.GetObject("pnId.Size")));
			this.pnId.TabIndex = ((int)(resources.GetObject("pnId.TabIndex")));
			this.pnId.Text = resources.GetString("pnId.Text");
			this.pnId.Visible = ((bool)(resources.GetObject("pnId.Visible")));
			// 
			// label2
			// 
			this.label2.AccessibleDescription = resources.GetString("label2.AccessibleDescription");
			this.label2.AccessibleName = resources.GetString("label2.AccessibleName");
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label2.Anchor")));
			this.label2.AutoSize = ((bool)(resources.GetObject("label2.AutoSize")));
			this.label2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label2.Dock")));
			this.label2.Enabled = ((bool)(resources.GetObject("label2.Enabled")));
			this.label2.Font = ((System.Drawing.Font)(resources.GetObject("label2.Font")));
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.ImageAlign")));
			this.label2.ImageIndex = ((int)(resources.GetObject("label2.ImageIndex")));
			this.label2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label2.ImeMode")));
			this.label2.Location = ((System.Drawing.Point)(resources.GetObject("label2.Location")));
			this.label2.Name = "label2";
			this.label2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label2.RightToLeft")));
			this.label2.Size = ((System.Drawing.Size)(resources.GetObject("label2.Size")));
			this.label2.TabIndex = ((int)(resources.GetObject("label2.TabIndex")));
			this.label2.Text = resources.GetString("label2.Text");
			this.label2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label2.TextAlign")));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			// 
			// label1
			// 
			this.label1.AccessibleDescription = resources.GetString("label1.AccessibleDescription");
			this.label1.AccessibleName = resources.GetString("label1.AccessibleName");
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label1.Anchor")));
			this.label1.AutoSize = ((bool)(resources.GetObject("label1.AutoSize")));
			this.label1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label1.Dock")));
			this.label1.Enabled = ((bool)(resources.GetObject("label1.Enabled")));
			this.label1.Font = ((System.Drawing.Font)(resources.GetObject("label1.Font")));
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.ImageAlign")));
			this.label1.ImageIndex = ((int)(resources.GetObject("label1.ImageIndex")));
			this.label1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label1.ImeMode")));
			this.label1.Location = ((System.Drawing.Point)(resources.GetObject("label1.Location")));
			this.label1.Name = "label1";
			this.label1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label1.RightToLeft")));
			this.label1.Size = ((System.Drawing.Size)(resources.GetObject("label1.Size")));
			this.label1.TabIndex = ((int)(resources.GetObject("label1.TabIndex")));
			this.label1.Text = resources.GetString("label1.Text");
			this.label1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label1.TextAlign")));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			// 
			// tbsimdescfamname
			// 
			this.tbsimdescfamname.AccessibleDescription = resources.GetString("tbsimdescfamname.AccessibleDescription");
			this.tbsimdescfamname.AccessibleName = resources.GetString("tbsimdescfamname.AccessibleName");
			this.tbsimdescfamname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimdescfamname.Anchor")));
			this.tbsimdescfamname.AutoSize = ((bool)(resources.GetObject("tbsimdescfamname.AutoSize")));
			this.tbsimdescfamname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimdescfamname.BackgroundImage")));
			this.tbsimdescfamname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimdescfamname.Dock")));
			this.tbsimdescfamname.Enabled = ((bool)(resources.GetObject("tbsimdescfamname.Enabled")));
			this.tbsimdescfamname.Font = ((System.Drawing.Font)(resources.GetObject("tbsimdescfamname.Font")));
			this.tbsimdescfamname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimdescfamname.ImeMode")));
			this.tbsimdescfamname.Location = ((System.Drawing.Point)(resources.GetObject("tbsimdescfamname.Location")));
			this.tbsimdescfamname.MaxLength = ((int)(resources.GetObject("tbsimdescfamname.MaxLength")));
			this.tbsimdescfamname.Multiline = ((bool)(resources.GetObject("tbsimdescfamname.Multiline")));
			this.tbsimdescfamname.Name = "tbsimdescfamname";
			this.tbsimdescfamname.PasswordChar = ((char)(resources.GetObject("tbsimdescfamname.PasswordChar")));
			this.tbsimdescfamname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimdescfamname.RightToLeft")));
			this.tbsimdescfamname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimdescfamname.ScrollBars")));
			this.tbsimdescfamname.Size = ((System.Drawing.Size)(resources.GetObject("tbsimdescfamname.Size")));
			this.tbsimdescfamname.TabIndex = ((int)(resources.GetObject("tbsimdescfamname.TabIndex")));
			this.tbsimdescfamname.Text = resources.GetString("tbsimdescfamname.Text");
			this.tbsimdescfamname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimdescfamname.TextAlign")));
			this.tbsimdescfamname.Visible = ((bool)(resources.GetObject("tbsimdescfamname.Visible")));
			this.tbsimdescfamname.WordWrap = ((bool)(resources.GetObject("tbsimdescfamname.WordWrap")));
			this.tbsimdescfamname.TextChanged += new System.EventHandler(this.ChangedId);
			// 
			// tbfaminst
			// 
			this.tbfaminst.AccessibleDescription = resources.GetString("tbfaminst.AccessibleDescription");
			this.tbfaminst.AccessibleName = resources.GetString("tbfaminst.AccessibleName");
			this.tbfaminst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfaminst.Anchor")));
			this.tbfaminst.AutoSize = ((bool)(resources.GetObject("tbfaminst.AutoSize")));
			this.tbfaminst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfaminst.BackgroundImage")));
			this.tbfaminst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfaminst.Dock")));
			this.tbfaminst.Enabled = ((bool)(resources.GetObject("tbfaminst.Enabled")));
			this.tbfaminst.Font = ((System.Drawing.Font)(resources.GetObject("tbfaminst.Font")));
			this.tbfaminst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfaminst.ImeMode")));
			this.tbfaminst.Location = ((System.Drawing.Point)(resources.GetObject("tbfaminst.Location")));
			this.tbfaminst.MaxLength = ((int)(resources.GetObject("tbfaminst.MaxLength")));
			this.tbfaminst.Multiline = ((bool)(resources.GetObject("tbfaminst.Multiline")));
			this.tbfaminst.Name = "tbfaminst";
			this.tbfaminst.PasswordChar = ((char)(resources.GetObject("tbfaminst.PasswordChar")));
			this.tbfaminst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfaminst.RightToLeft")));
			this.tbfaminst.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfaminst.ScrollBars")));
			this.tbfaminst.Size = ((System.Drawing.Size)(resources.GetObject("tbfaminst.Size")));
			this.tbfaminst.TabIndex = ((int)(resources.GetObject("tbfaminst.TabIndex")));
			this.tbfaminst.Text = resources.GetString("tbfaminst.Text");
			this.tbfaminst.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfaminst.TextAlign")));
			this.tbfaminst.Visible = ((bool)(resources.GetObject("tbfaminst.Visible")));
			this.tbfaminst.WordWrap = ((bool)(resources.GetObject("tbfaminst.WordWrap")));
			this.tbfaminst.TextChanged += new System.EventHandler(this.ChangedId);
			// 
			// label49
			// 
			this.label49.AccessibleDescription = resources.GetString("label49.AccessibleDescription");
			this.label49.AccessibleName = resources.GetString("label49.AccessibleName");
			this.label49.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label49.Anchor")));
			this.label49.AutoSize = ((bool)(resources.GetObject("label49.AutoSize")));
			this.label49.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label49.Dock")));
			this.label49.Enabled = ((bool)(resources.GetObject("label49.Enabled")));
			this.label49.Font = ((System.Drawing.Font)(resources.GetObject("label49.Font")));
			this.label49.Image = ((System.Drawing.Image)(resources.GetObject("label49.Image")));
			this.label49.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label49.ImageAlign")));
			this.label49.ImageIndex = ((int)(resources.GetObject("label49.ImageIndex")));
			this.label49.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label49.ImeMode")));
			this.label49.Location = ((System.Drawing.Point)(resources.GetObject("label49.Location")));
			this.label49.Name = "label49";
			this.label49.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label49.RightToLeft")));
			this.label49.Size = ((System.Drawing.Size)(resources.GetObject("label49.Size")));
			this.label49.TabIndex = ((int)(resources.GetObject("label49.TabIndex")));
			this.label49.Text = resources.GetString("label49.Text");
			this.label49.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label49.TextAlign")));
			this.label49.Visible = ((bool)(resources.GetObject("label49.Visible")));
			// 
			// rbmale
			// 
			this.rbmale.AccessibleDescription = resources.GetString("rbmale.AccessibleDescription");
			this.rbmale.AccessibleName = resources.GetString("rbmale.AccessibleName");
			this.rbmale.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbmale.Anchor")));
			this.rbmale.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbmale.Appearance")));
			this.rbmale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbmale.BackgroundImage")));
			this.rbmale.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbmale.CheckAlign")));
			this.rbmale.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbmale.Dock")));
			this.rbmale.Enabled = ((bool)(resources.GetObject("rbmale.Enabled")));
			this.rbmale.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbmale.FlatStyle")));
			this.rbmale.Font = ((System.Drawing.Font)(resources.GetObject("rbmale.Font")));
			this.rbmale.Image = ((System.Drawing.Image)(resources.GetObject("rbmale.Image")));
			this.rbmale.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbmale.ImageAlign")));
			this.rbmale.ImageIndex = ((int)(resources.GetObject("rbmale.ImageIndex")));
			this.rbmale.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbmale.ImeMode")));
			this.rbmale.Location = ((System.Drawing.Point)(resources.GetObject("rbmale.Location")));
			this.rbmale.Name = "rbmale";
			this.rbmale.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbmale.RightToLeft")));
			this.rbmale.Size = ((System.Drawing.Size)(resources.GetObject("rbmale.Size")));
			this.rbmale.TabIndex = ((int)(resources.GetObject("rbmale.TabIndex")));
			this.rbmale.Text = resources.GetString("rbmale.Text");
			this.rbmale.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbmale.TextAlign")));
			this.rbmale.Visible = ((bool)(resources.GetObject("rbmale.Visible")));
			this.rbmale.CheckedChanged += new System.EventHandler(this.ChangedId);
			// 
			// rbfemale
			// 
			this.rbfemale.AccessibleDescription = resources.GetString("rbfemale.AccessibleDescription");
			this.rbfemale.AccessibleName = resources.GetString("rbfemale.AccessibleName");
			this.rbfemale.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rbfemale.Anchor")));
			this.rbfemale.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("rbfemale.Appearance")));
			this.rbfemale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rbfemale.BackgroundImage")));
			this.rbfemale.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbfemale.CheckAlign")));
			this.rbfemale.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rbfemale.Dock")));
			this.rbfemale.Enabled = ((bool)(resources.GetObject("rbfemale.Enabled")));
			this.rbfemale.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("rbfemale.FlatStyle")));
			this.rbfemale.Font = ((System.Drawing.Font)(resources.GetObject("rbfemale.Font")));
			this.rbfemale.Image = ((System.Drawing.Image)(resources.GetObject("rbfemale.Image")));
			this.rbfemale.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbfemale.ImageAlign")));
			this.rbfemale.ImageIndex = ((int)(resources.GetObject("rbfemale.ImageIndex")));
			this.rbfemale.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rbfemale.ImeMode")));
			this.rbfemale.Location = ((System.Drawing.Point)(resources.GetObject("rbfemale.Location")));
			this.rbfemale.Name = "rbfemale";
			this.rbfemale.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rbfemale.RightToLeft")));
			this.rbfemale.Size = ((System.Drawing.Size)(resources.GetObject("rbfemale.Size")));
			this.rbfemale.TabIndex = ((int)(resources.GetObject("rbfemale.TabIndex")));
			this.rbfemale.Text = resources.GetString("rbfemale.Text");
			this.rbfemale.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("rbfemale.TextAlign")));
			this.rbfemale.Visible = ((bool)(resources.GetObject("rbfemale.Visible")));
			this.rbfemale.CheckedChanged += new System.EventHandler(this.ChangedId);
			// 
			// pbImage
			// 
			this.pbImage.AccessibleDescription = resources.GetString("pbImage.AccessibleDescription");
			this.pbImage.AccessibleName = resources.GetString("pbImage.AccessibleName");
			this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbImage.Anchor")));
			this.pbImage.BackColor = System.Drawing.Color.Transparent;
			this.pbImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbImage.BackgroundImage")));
			this.pbImage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbImage.Dock")));
			this.pbImage.Enabled = ((bool)(resources.GetObject("pbImage.Enabled")));
			this.pbImage.Font = ((System.Drawing.Font)(resources.GetObject("pbImage.Font")));
			this.pbImage.Image = ((System.Drawing.Image)(resources.GetObject("pbImage.Image")));
			this.pbImage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbImage.ImeMode")));
			this.pbImage.Location = ((System.Drawing.Point)(resources.GetObject("pbImage.Location")));
			this.pbImage.Name = "pbImage";
			this.pbImage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbImage.RightToLeft")));
			this.pbImage.Size = ((System.Drawing.Size)(resources.GetObject("pbImage.Size")));
			this.pbImage.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pbImage.SizeMode")));
			this.pbImage.TabIndex = ((int)(resources.GetObject("pbImage.TabIndex")));
			this.pbImage.TabStop = false;
			this.pbImage.Text = resources.GetString("pbImage.Text");
			this.pbImage.Visible = ((bool)(resources.GetObject("pbImage.Visible")));
			// 
			// tbsimdescname
			// 
			this.tbsimdescname.AccessibleDescription = resources.GetString("tbsimdescname.AccessibleDescription");
			this.tbsimdescname.AccessibleName = resources.GetString("tbsimdescname.AccessibleName");
			this.tbsimdescname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimdescname.Anchor")));
			this.tbsimdescname.AutoSize = ((bool)(resources.GetObject("tbsimdescname.AutoSize")));
			this.tbsimdescname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimdescname.BackgroundImage")));
			this.tbsimdescname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimdescname.Dock")));
			this.tbsimdescname.Enabled = ((bool)(resources.GetObject("tbsimdescname.Enabled")));
			this.tbsimdescname.Font = ((System.Drawing.Font)(resources.GetObject("tbsimdescname.Font")));
			this.tbsimdescname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimdescname.ImeMode")));
			this.tbsimdescname.Location = ((System.Drawing.Point)(resources.GetObject("tbsimdescname.Location")));
			this.tbsimdescname.MaxLength = ((int)(resources.GetObject("tbsimdescname.MaxLength")));
			this.tbsimdescname.Multiline = ((bool)(resources.GetObject("tbsimdescname.Multiline")));
			this.tbsimdescname.Name = "tbsimdescname";
			this.tbsimdescname.PasswordChar = ((char)(resources.GetObject("tbsimdescname.PasswordChar")));
			this.tbsimdescname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimdescname.RightToLeft")));
			this.tbsimdescname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimdescname.ScrollBars")));
			this.tbsimdescname.Size = ((System.Drawing.Size)(resources.GetObject("tbsimdescname.Size")));
			this.tbsimdescname.TabIndex = ((int)(resources.GetObject("tbsimdescname.TabIndex")));
			this.tbsimdescname.Text = resources.GetString("tbsimdescname.Text");
			this.tbsimdescname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimdescname.TextAlign")));
			this.tbsimdescname.Visible = ((bool)(resources.GetObject("tbsimdescname.Visible")));
			this.tbsimdescname.WordWrap = ((bool)(resources.GetObject("tbsimdescname.WordWrap")));
			this.tbsimdescname.TextChanged += new System.EventHandler(this.ChangedId);
			// 
			// label13
			// 
			this.label13.AccessibleDescription = resources.GetString("label13.AccessibleDescription");
			this.label13.AccessibleName = resources.GetString("label13.AccessibleName");
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label13.Anchor")));
			this.label13.AutoSize = ((bool)(resources.GetObject("label13.AutoSize")));
			this.label13.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label13.Dock")));
			this.label13.Enabled = ((bool)(resources.GetObject("label13.Enabled")));
			this.label13.Font = ((System.Drawing.Font)(resources.GetObject("label13.Font")));
			this.label13.Image = ((System.Drawing.Image)(resources.GetObject("label13.Image")));
			this.label13.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label13.ImageAlign")));
			this.label13.ImageIndex = ((int)(resources.GetObject("label13.ImageIndex")));
			this.label13.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label13.ImeMode")));
			this.label13.Location = ((System.Drawing.Point)(resources.GetObject("label13.Location")));
			this.label13.Name = "label13";
			this.label13.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label13.RightToLeft")));
			this.label13.Size = ((System.Drawing.Size)(resources.GetObject("label13.Size")));
			this.label13.TabIndex = ((int)(resources.GetObject("label13.TabIndex")));
			this.label13.Text = resources.GetString("label13.Text");
			this.label13.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label13.TextAlign")));
			this.label13.Visible = ((bool)(resources.GetObject("label13.Visible")));
			// 
			// tbsim
			// 
			this.tbsim.AccessibleDescription = resources.GetString("tbsim.AccessibleDescription");
			this.tbsim.AccessibleName = resources.GetString("tbsim.AccessibleName");
			this.tbsim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsim.Anchor")));
			this.tbsim.AutoSize = ((bool)(resources.GetObject("tbsim.AutoSize")));
			this.tbsim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsim.BackgroundImage")));
			this.tbsim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsim.Dock")));
			this.tbsim.Enabled = ((bool)(resources.GetObject("tbsim.Enabled")));
			this.tbsim.Font = ((System.Drawing.Font)(resources.GetObject("tbsim.Font")));
			this.tbsim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsim.ImeMode")));
			this.tbsim.Location = ((System.Drawing.Point)(resources.GetObject("tbsim.Location")));
			this.tbsim.MaxLength = ((int)(resources.GetObject("tbsim.MaxLength")));
			this.tbsim.Multiline = ((bool)(resources.GetObject("tbsim.Multiline")));
			this.tbsim.Name = "tbsim";
			this.tbsim.PasswordChar = ((char)(resources.GetObject("tbsim.PasswordChar")));
			this.tbsim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsim.RightToLeft")));
			this.tbsim.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsim.ScrollBars")));
			this.tbsim.Size = ((System.Drawing.Size)(resources.GetObject("tbsim.Size")));
			this.tbsim.TabIndex = ((int)(resources.GetObject("tbsim.TabIndex")));
			this.tbsim.Text = resources.GetString("tbsim.Text");
			this.tbsim.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsim.TextAlign")));
			this.tbsim.Visible = ((bool)(resources.GetObject("tbsim.Visible")));
			this.tbsim.WordWrap = ((bool)(resources.GetObject("tbsim.WordWrap")));
			this.tbsim.TextChanged += new System.EventHandler(this.ChangedId);
			// 
			// label10
			// 
			this.label10.AccessibleDescription = resources.GetString("label10.AccessibleDescription");
			this.label10.AccessibleName = resources.GetString("label10.AccessibleName");
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label10.Anchor")));
			this.label10.AutoSize = ((bool)(resources.GetObject("label10.AutoSize")));
			this.label10.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label10.Dock")));
			this.label10.Enabled = ((bool)(resources.GetObject("label10.Enabled")));
			this.label10.Font = ((System.Drawing.Font)(resources.GetObject("label10.Font")));
			this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
			this.label10.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.ImageAlign")));
			this.label10.ImageIndex = ((int)(resources.GetObject("label10.ImageIndex")));
			this.label10.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label10.ImeMode")));
			this.label10.Location = ((System.Drawing.Point)(resources.GetObject("label10.Location")));
			this.label10.Name = "label10";
			this.label10.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label10.RightToLeft")));
			this.label10.Size = ((System.Drawing.Size)(resources.GetObject("label10.Size")));
			this.label10.TabIndex = ((int)(resources.GetObject("label10.TabIndex")));
			this.label10.Text = resources.GetString("label10.Text");
			this.label10.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label10.TextAlign")));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			// 
			// tbage
			// 
			this.tbage.AccessibleDescription = resources.GetString("tbage.AccessibleDescription");
			this.tbage.AccessibleName = resources.GetString("tbage.AccessibleName");
			this.tbage.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbage.Anchor")));
			this.tbage.AutoSize = ((bool)(resources.GetObject("tbage.AutoSize")));
			this.tbage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbage.BackgroundImage")));
			this.tbage.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbage.Dock")));
			this.tbage.Enabled = ((bool)(resources.GetObject("tbage.Enabled")));
			this.tbage.Font = ((System.Drawing.Font)(resources.GetObject("tbage.Font")));
			this.tbage.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbage.ImeMode")));
			this.tbage.Location = ((System.Drawing.Point)(resources.GetObject("tbage.Location")));
			this.tbage.MaxLength = ((int)(resources.GetObject("tbage.MaxLength")));
			this.tbage.Multiline = ((bool)(resources.GetObject("tbage.Multiline")));
			this.tbage.Name = "tbage";
			this.tbage.PasswordChar = ((char)(resources.GetObject("tbage.PasswordChar")));
			this.tbage.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbage.RightToLeft")));
			this.tbage.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbage.ScrollBars")));
			this.tbage.Size = ((System.Drawing.Size)(resources.GetObject("tbage.Size")));
			this.tbage.TabIndex = ((int)(resources.GetObject("tbage.TabIndex")));
			this.tbage.Text = resources.GetString("tbage.Text");
			this.tbage.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbage.TextAlign")));
			this.tbage.Visible = ((bool)(resources.GetObject("tbage.Visible")));
			this.tbage.WordWrap = ((bool)(resources.GetObject("tbage.WordWrap")));
			this.tbage.TextChanged += new System.EventHandler(this.ChangedId);
			// 
			// label48
			// 
			this.label48.AccessibleDescription = resources.GetString("label48.AccessibleDescription");
			this.label48.AccessibleName = resources.GetString("label48.AccessibleName");
			this.label48.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label48.Anchor")));
			this.label48.AutoSize = ((bool)(resources.GetObject("label48.AutoSize")));
			this.label48.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label48.Dock")));
			this.label48.Enabled = ((bool)(resources.GetObject("label48.Enabled")));
			this.label48.Font = ((System.Drawing.Font)(resources.GetObject("label48.Font")));
			this.label48.Image = ((System.Drawing.Image)(resources.GetObject("label48.Image")));
			this.label48.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label48.ImageAlign")));
			this.label48.ImageIndex = ((int)(resources.GetObject("label48.ImageIndex")));
			this.label48.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label48.ImeMode")));
			this.label48.Location = ((System.Drawing.Point)(resources.GetObject("label48.Location")));
			this.label48.Name = "label48";
			this.label48.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label48.RightToLeft")));
			this.label48.Size = ((System.Drawing.Size)(resources.GetObject("label48.Size")));
			this.label48.TabIndex = ((int)(resources.GetObject("label48.TabIndex")));
			this.label48.Text = resources.GetString("label48.Text");
			this.label48.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label48.TextAlign")));
			this.label48.Visible = ((bool)(resources.GetObject("label48.Visible")));
			// 
			// cblifesection
			// 
			this.cblifesection.AccessibleDescription = resources.GetString("cblifesection.AccessibleDescription");
			this.cblifesection.AccessibleName = resources.GetString("cblifesection.AccessibleName");
			this.cblifesection.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblifesection.Anchor")));
			this.cblifesection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblifesection.BackgroundImage")));
			this.cblifesection.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblifesection.Dock")));
			this.cblifesection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cblifesection.Enabled = ((bool)(resources.GetObject("cblifesection.Enabled")));
			this.cblifesection.Font = ((System.Drawing.Font)(resources.GetObject("cblifesection.Font")));
			this.cblifesection.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblifesection.ImeMode")));
			this.cblifesection.IntegralHeight = ((bool)(resources.GetObject("cblifesection.IntegralHeight")));
			this.cblifesection.ItemHeight = ((int)(resources.GetObject("cblifesection.ItemHeight")));
			this.cblifesection.Location = ((System.Drawing.Point)(resources.GetObject("cblifesection.Location")));
			this.cblifesection.MaxDropDownItems = ((int)(resources.GetObject("cblifesection.MaxDropDownItems")));
			this.cblifesection.MaxLength = ((int)(resources.GetObject("cblifesection.MaxLength")));
			this.cblifesection.Name = "cblifesection";
			this.cblifesection.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblifesection.RightToLeft")));
			this.cblifesection.Size = ((System.Drawing.Size)(resources.GetObject("cblifesection.Size")));
			this.cblifesection.TabIndex = ((int)(resources.GetObject("cblifesection.TabIndex")));
			this.cblifesection.Text = resources.GetString("cblifesection.Text");
			this.cblifesection.Visible = ((bool)(resources.GetObject("cblifesection.Visible")));
			this.cblifesection.SelectedValueChanged += new System.EventHandler(this.ChangedId);
			// 
			// pnSkill
			// 
			this.pnSkill.AccessibleDescription = resources.GetString("pnSkill.AccessibleDescription");
			this.pnSkill.AccessibleName = resources.GetString("pnSkill.AccessibleName");
			this.pnSkill.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnSkill.Anchor")));
			this.pnSkill.AutoScroll = ((bool)(resources.GetObject("pnSkill.AutoScroll")));
			this.pnSkill.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnSkill.AutoScrollMargin")));
			this.pnSkill.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnSkill.AutoScrollMinSize")));
			this.pnSkill.BackColor = System.Drawing.Color.Transparent;
			this.pnSkill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnSkill.BackgroundImage")));
			this.pnSkill.Controls.Add(this.pbRomance);
			this.pnSkill.Controls.Add(this.pbFat);
			this.pnSkill.Controls.Add(this.pbClean);
			this.pnSkill.Controls.Add(this.pbCreative);
			this.pnSkill.Controls.Add(this.pbBody);
			this.pnSkill.Controls.Add(this.pbCharisma);
			this.pnSkill.Controls.Add(this.pbMech);
			this.pnSkill.Controls.Add(this.pbLogic);
			this.pnSkill.Controls.Add(this.pbCooking);
			this.pnSkill.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnSkill.Dock")));
			this.pnSkill.Enabled = ((bool)(resources.GetObject("pnSkill.Enabled")));
			this.pnSkill.Font = ((System.Drawing.Font)(resources.GetObject("pnSkill.Font")));
			this.pnSkill.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnSkill.ImeMode")));
			this.pnSkill.Location = ((System.Drawing.Point)(resources.GetObject("pnSkill.Location")));
			this.pnSkill.Name = "pnSkill";
			this.pnSkill.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnSkill.RightToLeft")));
			this.pnSkill.Size = ((System.Drawing.Size)(resources.GetObject("pnSkill.Size")));
			this.pnSkill.TabIndex = ((int)(resources.GetObject("pnSkill.TabIndex")));
			this.pnSkill.Text = resources.GetString("pnSkill.Text");
			this.pnSkill.Visible = ((bool)(resources.GetObject("pnSkill.Visible")));
			// 
			// pbRomance
			// 
			this.pbRomance.AccessibleDescription = resources.GetString("pbRomance.AccessibleDescription");
			this.pbRomance.AccessibleName = resources.GetString("pbRomance.AccessibleName");
			this.pbRomance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbRomance.Anchor")));
			this.pbRomance.AutoScroll = ((bool)(resources.GetObject("pbRomance.AutoScroll")));
			this.pbRomance.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbRomance.AutoScrollMargin")));
			this.pbRomance.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbRomance.AutoScrollMinSize")));
			this.pbRomance.BackColor = System.Drawing.Color.Transparent;
			this.pbRomance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRomance.BackgroundImage")));
			this.pbRomance.DisplayOffset = 0;
			this.pbRomance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbRomance.Dock")));
			this.pbRomance.DockPadding.Bottom = 5;
			this.pbRomance.Enabled = ((bool)(resources.GetObject("pbRomance.Enabled")));
			this.pbRomance.Font = ((System.Drawing.Font)(resources.GetObject("pbRomance.Font")));
			this.pbRomance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbRomance.ImeMode")));
			this.pbRomance.LabelText = resources.GetString("pbRomance.LabelText");
			this.pbRomance.LabelWidth = ((int)(resources.GetObject("pbRomance.LabelWidth")));
			this.pbRomance.Location = ((System.Drawing.Point)(resources.GetObject("pbRomance.Location")));
			this.pbRomance.Maximum = 1000;
			this.pbRomance.Name = "pbRomance";
			this.pbRomance.NumberFormat = "N1";
			this.pbRomance.NumberOffset = 0;
			this.pbRomance.NumberScale = 0.01;
			this.pbRomance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbRomance.RightToLeft")));
			this.pbRomance.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbRomance.Size = ((System.Drawing.Size)(resources.GetObject("pbRomance.Size")));
			this.pbRomance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbRomance.TabIndex = ((int)(resources.GetObject("pbRomance.TabIndex")));
			this.pbRomance.TextboxWidth = ((int)(resources.GetObject("pbRomance.TextboxWidth")));
			this.pbRomance.TokenCount = 10;
			this.pbRomance.UnselectedColor = System.Drawing.Color.Black;
			this.pbRomance.Value = 500;
			this.pbRomance.Visible = ((bool)(resources.GetObject("pbRomance.Visible")));
			this.pbRomance.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbFat
			// 
			this.pbFat.AccessibleDescription = resources.GetString("pbFat.AccessibleDescription");
			this.pbFat.AccessibleName = resources.GetString("pbFat.AccessibleName");
			this.pbFat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbFat.Anchor")));
			this.pbFat.AutoScroll = ((bool)(resources.GetObject("pbFat.AutoScroll")));
			this.pbFat.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbFat.AutoScrollMargin")));
			this.pbFat.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbFat.AutoScrollMinSize")));
			this.pbFat.BackColor = System.Drawing.Color.Transparent;
			this.pbFat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFat.BackgroundImage")));
			this.pbFat.DisplayOffset = 0;
			this.pbFat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbFat.Dock")));
			this.pbFat.DockPadding.Bottom = 5;
			this.pbFat.Enabled = ((bool)(resources.GetObject("pbFat.Enabled")));
			this.pbFat.Font = ((System.Drawing.Font)(resources.GetObject("pbFat.Font")));
			this.pbFat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbFat.ImeMode")));
			this.pbFat.LabelText = resources.GetString("pbFat.LabelText");
			this.pbFat.LabelWidth = ((int)(resources.GetObject("pbFat.LabelWidth")));
			this.pbFat.Location = ((System.Drawing.Point)(resources.GetObject("pbFat.Location")));
			this.pbFat.Maximum = 1000;
			this.pbFat.Name = "pbFat";
			this.pbFat.NumberFormat = "N1";
			this.pbFat.NumberOffset = 0;
			this.pbFat.NumberScale = 0.01;
			this.pbFat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbFat.RightToLeft")));
			this.pbFat.SelectedColor = System.Drawing.Color.Orange;
			this.pbFat.Size = ((System.Drawing.Size)(resources.GetObject("pbFat.Size")));
			this.pbFat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFat.TabIndex = ((int)(resources.GetObject("pbFat.TabIndex")));
			this.pbFat.TextboxWidth = ((int)(resources.GetObject("pbFat.TextboxWidth")));
			this.pbFat.TokenCount = 10;
			this.pbFat.UnselectedColor = System.Drawing.Color.Black;
			this.pbFat.Value = 500;
			this.pbFat.Visible = ((bool)(resources.GetObject("pbFat.Visible")));
			this.pbFat.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbClean
			// 
			this.pbClean.AccessibleDescription = resources.GetString("pbClean.AccessibleDescription");
			this.pbClean.AccessibleName = resources.GetString("pbClean.AccessibleName");
			this.pbClean.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbClean.Anchor")));
			this.pbClean.AutoScroll = ((bool)(resources.GetObject("pbClean.AutoScroll")));
			this.pbClean.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbClean.AutoScrollMargin")));
			this.pbClean.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbClean.AutoScrollMinSize")));
			this.pbClean.BackColor = System.Drawing.Color.Transparent;
			this.pbClean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbClean.BackgroundImage")));
			this.pbClean.DisplayOffset = 0;
			this.pbClean.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbClean.Dock")));
			this.pbClean.DockPadding.Bottom = 5;
			this.pbClean.Enabled = ((bool)(resources.GetObject("pbClean.Enabled")));
			this.pbClean.Font = ((System.Drawing.Font)(resources.GetObject("pbClean.Font")));
			this.pbClean.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbClean.ImeMode")));
			this.pbClean.LabelText = resources.GetString("pbClean.LabelText");
			this.pbClean.LabelWidth = ((int)(resources.GetObject("pbClean.LabelWidth")));
			this.pbClean.Location = ((System.Drawing.Point)(resources.GetObject("pbClean.Location")));
			this.pbClean.Maximum = 1000;
			this.pbClean.Name = "pbClean";
			this.pbClean.NumberFormat = "N2";
			this.pbClean.NumberOffset = 0;
			this.pbClean.NumberScale = 0.01;
			this.pbClean.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbClean.RightToLeft")));
			this.pbClean.SelectedColor = System.Drawing.Color.Lime;
			this.pbClean.Size = ((System.Drawing.Size)(resources.GetObject("pbClean.Size")));
			this.pbClean.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbClean.TabIndex = ((int)(resources.GetObject("pbClean.TabIndex")));
			this.pbClean.TextboxWidth = ((int)(resources.GetObject("pbClean.TextboxWidth")));
			this.pbClean.TokenCount = 21;
			this.pbClean.UnselectedColor = System.Drawing.Color.Black;
			this.pbClean.Value = 500;
			this.pbClean.Visible = ((bool)(resources.GetObject("pbClean.Visible")));
			this.pbClean.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbCreative
			// 
			this.pbCreative.AccessibleDescription = resources.GetString("pbCreative.AccessibleDescription");
			this.pbCreative.AccessibleName = resources.GetString("pbCreative.AccessibleName");
			this.pbCreative.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCreative.Anchor")));
			this.pbCreative.AutoScroll = ((bool)(resources.GetObject("pbCreative.AutoScroll")));
			this.pbCreative.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCreative.AutoScrollMargin")));
			this.pbCreative.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCreative.AutoScrollMinSize")));
			this.pbCreative.BackColor = System.Drawing.Color.Transparent;
			this.pbCreative.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCreative.BackgroundImage")));
			this.pbCreative.DisplayOffset = 0;
			this.pbCreative.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCreative.Dock")));
			this.pbCreative.DockPadding.Bottom = 5;
			this.pbCreative.Enabled = ((bool)(resources.GetObject("pbCreative.Enabled")));
			this.pbCreative.Font = ((System.Drawing.Font)(resources.GetObject("pbCreative.Font")));
			this.pbCreative.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCreative.ImeMode")));
			this.pbCreative.LabelText = resources.GetString("pbCreative.LabelText");
			this.pbCreative.LabelWidth = ((int)(resources.GetObject("pbCreative.LabelWidth")));
			this.pbCreative.Location = ((System.Drawing.Point)(resources.GetObject("pbCreative.Location")));
			this.pbCreative.Maximum = 1000;
			this.pbCreative.Name = "pbCreative";
			this.pbCreative.NumberFormat = "N2";
			this.pbCreative.NumberOffset = 0;
			this.pbCreative.NumberScale = 0.01;
			this.pbCreative.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCreative.RightToLeft")));
			this.pbCreative.SelectedColor = System.Drawing.Color.Lime;
			this.pbCreative.Size = ((System.Drawing.Size)(resources.GetObject("pbCreative.Size")));
			this.pbCreative.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCreative.TabIndex = ((int)(resources.GetObject("pbCreative.TabIndex")));
			this.pbCreative.TextboxWidth = ((int)(resources.GetObject("pbCreative.TextboxWidth")));
			this.pbCreative.TokenCount = 21;
			this.pbCreative.UnselectedColor = System.Drawing.Color.Black;
			this.pbCreative.Value = 500;
			this.pbCreative.Visible = ((bool)(resources.GetObject("pbCreative.Visible")));
			this.pbCreative.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbBody
			// 
			this.pbBody.AccessibleDescription = resources.GetString("pbBody.AccessibleDescription");
			this.pbBody.AccessibleName = resources.GetString("pbBody.AccessibleName");
			this.pbBody.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbBody.Anchor")));
			this.pbBody.AutoScroll = ((bool)(resources.GetObject("pbBody.AutoScroll")));
			this.pbBody.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbBody.AutoScrollMargin")));
			this.pbBody.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbBody.AutoScrollMinSize")));
			this.pbBody.BackColor = System.Drawing.Color.Transparent;
			this.pbBody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbBody.BackgroundImage")));
			this.pbBody.DisplayOffset = 0;
			this.pbBody.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbBody.Dock")));
			this.pbBody.DockPadding.Bottom = 5;
			this.pbBody.Enabled = ((bool)(resources.GetObject("pbBody.Enabled")));
			this.pbBody.Font = ((System.Drawing.Font)(resources.GetObject("pbBody.Font")));
			this.pbBody.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbBody.ImeMode")));
			this.pbBody.LabelText = resources.GetString("pbBody.LabelText");
			this.pbBody.LabelWidth = ((int)(resources.GetObject("pbBody.LabelWidth")));
			this.pbBody.Location = ((System.Drawing.Point)(resources.GetObject("pbBody.Location")));
			this.pbBody.Maximum = 1000;
			this.pbBody.Name = "pbBody";
			this.pbBody.NumberFormat = "N2";
			this.pbBody.NumberOffset = 0;
			this.pbBody.NumberScale = 0.01;
			this.pbBody.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbBody.RightToLeft")));
			this.pbBody.SelectedColor = System.Drawing.Color.Lime;
			this.pbBody.Size = ((System.Drawing.Size)(resources.GetObject("pbBody.Size")));
			this.pbBody.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbBody.TabIndex = ((int)(resources.GetObject("pbBody.TabIndex")));
			this.pbBody.TextboxWidth = ((int)(resources.GetObject("pbBody.TextboxWidth")));
			this.pbBody.TokenCount = 21;
			this.pbBody.UnselectedColor = System.Drawing.Color.Black;
			this.pbBody.Value = 500;
			this.pbBody.Visible = ((bool)(resources.GetObject("pbBody.Visible")));
			this.pbBody.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbCharisma
			// 
			this.pbCharisma.AccessibleDescription = resources.GetString("pbCharisma.AccessibleDescription");
			this.pbCharisma.AccessibleName = resources.GetString("pbCharisma.AccessibleName");
			this.pbCharisma.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCharisma.Anchor")));
			this.pbCharisma.AutoScroll = ((bool)(resources.GetObject("pbCharisma.AutoScroll")));
			this.pbCharisma.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCharisma.AutoScrollMargin")));
			this.pbCharisma.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCharisma.AutoScrollMinSize")));
			this.pbCharisma.BackColor = System.Drawing.Color.Transparent;
			this.pbCharisma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCharisma.BackgroundImage")));
			this.pbCharisma.DisplayOffset = 0;
			this.pbCharisma.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCharisma.Dock")));
			this.pbCharisma.DockPadding.Bottom = 5;
			this.pbCharisma.Enabled = ((bool)(resources.GetObject("pbCharisma.Enabled")));
			this.pbCharisma.Font = ((System.Drawing.Font)(resources.GetObject("pbCharisma.Font")));
			this.pbCharisma.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCharisma.ImeMode")));
			this.pbCharisma.LabelText = resources.GetString("pbCharisma.LabelText");
			this.pbCharisma.LabelWidth = ((int)(resources.GetObject("pbCharisma.LabelWidth")));
			this.pbCharisma.Location = ((System.Drawing.Point)(resources.GetObject("pbCharisma.Location")));
			this.pbCharisma.Maximum = 1000;
			this.pbCharisma.Name = "pbCharisma";
			this.pbCharisma.NumberFormat = "N2";
			this.pbCharisma.NumberOffset = 0;
			this.pbCharisma.NumberScale = 0.01;
			this.pbCharisma.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCharisma.RightToLeft")));
			this.pbCharisma.SelectedColor = System.Drawing.Color.Lime;
			this.pbCharisma.Size = ((System.Drawing.Size)(resources.GetObject("pbCharisma.Size")));
			this.pbCharisma.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCharisma.TabIndex = ((int)(resources.GetObject("pbCharisma.TabIndex")));
			this.pbCharisma.TextboxWidth = ((int)(resources.GetObject("pbCharisma.TextboxWidth")));
			this.pbCharisma.TokenCount = 21;
			this.pbCharisma.UnselectedColor = System.Drawing.Color.Black;
			this.pbCharisma.Value = 500;
			this.pbCharisma.Visible = ((bool)(resources.GetObject("pbCharisma.Visible")));
			this.pbCharisma.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbMech
			// 
			this.pbMech.AccessibleDescription = resources.GetString("pbMech.AccessibleDescription");
			this.pbMech.AccessibleName = resources.GetString("pbMech.AccessibleName");
			this.pbMech.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbMech.Anchor")));
			this.pbMech.AutoScroll = ((bool)(resources.GetObject("pbMech.AutoScroll")));
			this.pbMech.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbMech.AutoScrollMargin")));
			this.pbMech.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbMech.AutoScrollMinSize")));
			this.pbMech.BackColor = System.Drawing.Color.Transparent;
			this.pbMech.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMech.BackgroundImage")));
			this.pbMech.DisplayOffset = 0;
			this.pbMech.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbMech.Dock")));
			this.pbMech.DockPadding.Bottom = 5;
			this.pbMech.Enabled = ((bool)(resources.GetObject("pbMech.Enabled")));
			this.pbMech.Font = ((System.Drawing.Font)(resources.GetObject("pbMech.Font")));
			this.pbMech.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbMech.ImeMode")));
			this.pbMech.LabelText = resources.GetString("pbMech.LabelText");
			this.pbMech.LabelWidth = ((int)(resources.GetObject("pbMech.LabelWidth")));
			this.pbMech.Location = ((System.Drawing.Point)(resources.GetObject("pbMech.Location")));
			this.pbMech.Maximum = 1000;
			this.pbMech.Name = "pbMech";
			this.pbMech.NumberFormat = "N2";
			this.pbMech.NumberOffset = 0;
			this.pbMech.NumberScale = 0.01;
			this.pbMech.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbMech.RightToLeft")));
			this.pbMech.SelectedColor = System.Drawing.Color.Lime;
			this.pbMech.Size = ((System.Drawing.Size)(resources.GetObject("pbMech.Size")));
			this.pbMech.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbMech.TabIndex = ((int)(resources.GetObject("pbMech.TabIndex")));
			this.pbMech.TextboxWidth = ((int)(resources.GetObject("pbMech.TextboxWidth")));
			this.pbMech.TokenCount = 21;
			this.pbMech.UnselectedColor = System.Drawing.Color.Black;
			this.pbMech.Value = 500;
			this.pbMech.Visible = ((bool)(resources.GetObject("pbMech.Visible")));
			this.pbMech.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbLogic
			// 
			this.pbLogic.AccessibleDescription = resources.GetString("pbLogic.AccessibleDescription");
			this.pbLogic.AccessibleName = resources.GetString("pbLogic.AccessibleName");
			this.pbLogic.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbLogic.Anchor")));
			this.pbLogic.AutoScroll = ((bool)(resources.GetObject("pbLogic.AutoScroll")));
			this.pbLogic.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbLogic.AutoScrollMargin")));
			this.pbLogic.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbLogic.AutoScrollMinSize")));
			this.pbLogic.BackColor = System.Drawing.Color.Transparent;
			this.pbLogic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogic.BackgroundImage")));
			this.pbLogic.DisplayOffset = 0;
			this.pbLogic.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbLogic.Dock")));
			this.pbLogic.DockPadding.Bottom = 5;
			this.pbLogic.Enabled = ((bool)(resources.GetObject("pbLogic.Enabled")));
			this.pbLogic.Font = ((System.Drawing.Font)(resources.GetObject("pbLogic.Font")));
			this.pbLogic.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbLogic.ImeMode")));
			this.pbLogic.LabelText = resources.GetString("pbLogic.LabelText");
			this.pbLogic.LabelWidth = ((int)(resources.GetObject("pbLogic.LabelWidth")));
			this.pbLogic.Location = ((System.Drawing.Point)(resources.GetObject("pbLogic.Location")));
			this.pbLogic.Maximum = 1000;
			this.pbLogic.Name = "pbLogic";
			this.pbLogic.NumberFormat = "N2";
			this.pbLogic.NumberOffset = 0;
			this.pbLogic.NumberScale = 0.01;
			this.pbLogic.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbLogic.RightToLeft")));
			this.pbLogic.SelectedColor = System.Drawing.Color.Lime;
			this.pbLogic.Size = ((System.Drawing.Size)(resources.GetObject("pbLogic.Size")));
			this.pbLogic.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbLogic.TabIndex = ((int)(resources.GetObject("pbLogic.TabIndex")));
			this.pbLogic.TextboxWidth = ((int)(resources.GetObject("pbLogic.TextboxWidth")));
			this.pbLogic.TokenCount = 21;
			this.pbLogic.UnselectedColor = System.Drawing.Color.Black;
			this.pbLogic.Value = 500;
			this.pbLogic.Visible = ((bool)(resources.GetObject("pbLogic.Visible")));
			this.pbLogic.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pbCooking
			// 
			this.pbCooking.AccessibleDescription = resources.GetString("pbCooking.AccessibleDescription");
			this.pbCooking.AccessibleName = resources.GetString("pbCooking.AccessibleName");
			this.pbCooking.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCooking.Anchor")));
			this.pbCooking.AutoScroll = ((bool)(resources.GetObject("pbCooking.AutoScroll")));
			this.pbCooking.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCooking.AutoScrollMargin")));
			this.pbCooking.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCooking.AutoScrollMinSize")));
			this.pbCooking.BackColor = System.Drawing.Color.Transparent;
			this.pbCooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCooking.BackgroundImage")));
			this.pbCooking.DisplayOffset = 0;
			this.pbCooking.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCooking.Dock")));
			this.pbCooking.DockPadding.Bottom = 5;
			this.pbCooking.Enabled = ((bool)(resources.GetObject("pbCooking.Enabled")));
			this.pbCooking.Font = ((System.Drawing.Font)(resources.GetObject("pbCooking.Font")));
			this.pbCooking.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCooking.ImeMode")));
			this.pbCooking.LabelText = resources.GetString("pbCooking.LabelText");
			this.pbCooking.LabelWidth = ((int)(resources.GetObject("pbCooking.LabelWidth")));
			this.pbCooking.Location = ((System.Drawing.Point)(resources.GetObject("pbCooking.Location")));
			this.pbCooking.Maximum = 1000;
			this.pbCooking.Name = "pbCooking";
			this.pbCooking.NumberFormat = "N2";
			this.pbCooking.NumberOffset = 0;
			this.pbCooking.NumberScale = 0.01;
			this.pbCooking.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCooking.RightToLeft")));
			this.pbCooking.SelectedColor = System.Drawing.Color.Lime;
			this.pbCooking.Size = ((System.Drawing.Size)(resources.GetObject("pbCooking.Size")));
			this.pbCooking.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbCooking.TabIndex = ((int)(resources.GetObject("pbCooking.TabIndex")));
			this.pbCooking.TextboxWidth = ((int)(resources.GetObject("pbCooking.TextboxWidth")));
			this.pbCooking.TokenCount = 21;
			this.pbCooking.UnselectedColor = System.Drawing.Color.Black;
			this.pbCooking.Value = 500;
			this.pbCooking.Visible = ((bool)(resources.GetObject("pbCooking.Visible")));
			this.pbCooking.Changed += new System.EventHandler(this.ChangedSkill);
			// 
			// pnChar
			// 
			this.pnChar.AccessibleDescription = resources.GetString("pnChar.AccessibleDescription");
			this.pnChar.AccessibleName = resources.GetString("pnChar.AccessibleName");
			this.pnChar.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnChar.Anchor")));
			this.pnChar.AutoScroll = ((bool)(resources.GetObject("pnChar.AutoScroll")));
			this.pnChar.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnChar.AutoScrollMargin")));
			this.pnChar.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnChar.AutoScrollMinSize")));
			this.pnChar.BackColor = System.Drawing.Color.Transparent;
			this.pnChar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnChar.BackgroundImage")));
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
			this.pnChar.Controls.Add(this.menuBar1);
			this.pnChar.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnChar.Dock")));
			this.pnChar.Enabled = ((bool)(resources.GetObject("pnChar.Enabled")));
			this.pnChar.Font = ((System.Drawing.Font)(resources.GetObject("pnChar.Font")));
			this.pnChar.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnChar.ImeMode")));
			this.pnChar.Location = ((System.Drawing.Point)(resources.GetObject("pnChar.Location")));
			this.pnChar.Name = "pnChar";
			this.pnChar.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnChar.RightToLeft")));
			this.pnChar.Size = ((System.Drawing.Size)(resources.GetObject("pnChar.Size")));
			this.pnChar.TabIndex = ((int)(resources.GetObject("pnChar.TabIndex")));
			this.pnChar.Text = resources.GetString("pnChar.Text");
			this.pnChar.Visible = ((bool)(resources.GetObject("pnChar.Visible")));
			// 
			// pbMan
			// 
			this.pbMan.AccessibleDescription = resources.GetString("pbMan.AccessibleDescription");
			this.pbMan.AccessibleName = resources.GetString("pbMan.AccessibleName");
			this.pbMan.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbMan.Anchor")));
			this.pbMan.AutoScroll = ((bool)(resources.GetObject("pbMan.AutoScroll")));
			this.pbMan.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbMan.AutoScrollMargin")));
			this.pbMan.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbMan.AutoScrollMinSize")));
			this.pbMan.BackColor = System.Drawing.Color.Transparent;
			this.pbMan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMan.BackgroundImage")));
			this.pbMan.DisplayOffset = 0;
			this.pbMan.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbMan.Dock")));
			this.pbMan.DockPadding.Bottom = 5;
			this.pbMan.Enabled = ((bool)(resources.GetObject("pbMan.Enabled")));
			this.pbMan.Font = ((System.Drawing.Font)(resources.GetObject("pbMan.Font")));
			this.pbMan.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbMan.ImeMode")));
			this.pbMan.LabelText = resources.GetString("pbMan.LabelText");
			this.pbMan.LabelWidth = ((int)(resources.GetObject("pbMan.LabelWidth")));
			this.pbMan.Location = ((System.Drawing.Point)(resources.GetObject("pbMan.Location")));
			this.pbMan.Maximum = 2000;
			this.pbMan.Name = "pbMan";
			this.pbMan.NumberFormat = "N1";
			this.pbMan.NumberOffset = -1000;
			this.pbMan.NumberScale = 0.01;
			this.pbMan.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbMan.RightToLeft")));
			this.pbMan.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbMan.Size = ((System.Drawing.Size)(resources.GetObject("pbMan.Size")));
			this.pbMan.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
			this.pbMan.TabIndex = ((int)(resources.GetObject("pbMan.TabIndex")));
			this.pbMan.TextboxWidth = ((int)(resources.GetObject("pbMan.TextboxWidth")));
			this.pbMan.TokenCount = 19;
			this.pbMan.UnselectedColor = System.Drawing.Color.Black;
			this.pbMan.Value = 0;
			this.pbMan.Visible = ((bool)(resources.GetObject("pbMan.Visible")));
			this.pbMan.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbWoman
			// 
			this.pbWoman.AccessibleDescription = resources.GetString("pbWoman.AccessibleDescription");
			this.pbWoman.AccessibleName = resources.GetString("pbWoman.AccessibleName");
			this.pbWoman.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbWoman.Anchor")));
			this.pbWoman.AutoScroll = ((bool)(resources.GetObject("pbWoman.AutoScroll")));
			this.pbWoman.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbWoman.AutoScrollMargin")));
			this.pbWoman.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbWoman.AutoScrollMinSize")));
			this.pbWoman.BackColor = System.Drawing.Color.Transparent;
			this.pbWoman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWoman.BackgroundImage")));
			this.pbWoman.DisplayOffset = 0;
			this.pbWoman.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbWoman.Dock")));
			this.pbWoman.DockPadding.Bottom = 5;
			this.pbWoman.Enabled = ((bool)(resources.GetObject("pbWoman.Enabled")));
			this.pbWoman.Font = ((System.Drawing.Font)(resources.GetObject("pbWoman.Font")));
			this.pbWoman.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbWoman.ImeMode")));
			this.pbWoman.LabelText = resources.GetString("pbWoman.LabelText");
			this.pbWoman.LabelWidth = ((int)(resources.GetObject("pbWoman.LabelWidth")));
			this.pbWoman.Location = ((System.Drawing.Point)(resources.GetObject("pbWoman.Location")));
			this.pbWoman.Maximum = 2000;
			this.pbWoman.Name = "pbWoman";
			this.pbWoman.NumberFormat = "N1";
			this.pbWoman.NumberOffset = -1000;
			this.pbWoman.NumberScale = 0.01;
			this.pbWoman.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbWoman.RightToLeft")));
			this.pbWoman.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbWoman.Size = ((System.Drawing.Size)(resources.GetObject("pbWoman.Size")));
			this.pbWoman.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
			this.pbWoman.TabIndex = ((int)(resources.GetObject("pbWoman.TabIndex")));
			this.pbWoman.TextboxWidth = ((int)(resources.GetObject("pbWoman.TextboxWidth")));
			this.pbWoman.TokenCount = 19;
			this.pbWoman.UnselectedColor = System.Drawing.Color.Black;
			this.pbWoman.Value = 0;
			this.pbWoman.Visible = ((bool)(resources.GetObject("pbWoman.Visible")));
			this.pbWoman.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbGNice
			// 
			this.pbGNice.AccessibleDescription = resources.GetString("pbGNice.AccessibleDescription");
			this.pbGNice.AccessibleName = resources.GetString("pbGNice.AccessibleName");
			this.pbGNice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbGNice.Anchor")));
			this.pbGNice.AutoScroll = ((bool)(resources.GetObject("pbGNice.AutoScroll")));
			this.pbGNice.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbGNice.AutoScrollMargin")));
			this.pbGNice.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbGNice.AutoScrollMinSize")));
			this.pbGNice.BackColor = System.Drawing.Color.Transparent;
			this.pbGNice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGNice.BackgroundImage")));
			this.pbGNice.DisplayOffset = 0;
			this.pbGNice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbGNice.Dock")));
			this.pbGNice.DockPadding.Bottom = 5;
			this.pbGNice.Enabled = ((bool)(resources.GetObject("pbGNice.Enabled")));
			this.pbGNice.Font = ((System.Drawing.Font)(resources.GetObject("pbGNice.Font")));
			this.pbGNice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbGNice.ImeMode")));
			this.pbGNice.LabelText = resources.GetString("pbGNice.LabelText");
			this.pbGNice.LabelWidth = ((int)(resources.GetObject("pbGNice.LabelWidth")));
			this.pbGNice.Location = ((System.Drawing.Point)(resources.GetObject("pbGNice.Location")));
			this.pbGNice.Maximum = 1000;
			this.pbGNice.Name = "pbGNice";
			this.pbGNice.NumberFormat = "N1";
			this.pbGNice.NumberOffset = 0;
			this.pbGNice.NumberScale = 0.01;
			this.pbGNice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbGNice.RightToLeft")));
			this.pbGNice.SelectedColor = System.Drawing.Color.Lime;
			this.pbGNice.Size = ((System.Drawing.Size)(resources.GetObject("pbGNice.Size")));
			this.pbGNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGNice.TabIndex = ((int)(resources.GetObject("pbGNice.TabIndex")));
			this.pbGNice.TextboxWidth = ((int)(resources.GetObject("pbGNice.TextboxWidth")));
			this.pbGNice.TokenCount = 10;
			this.pbGNice.UnselectedColor = System.Drawing.Color.Black;
			this.pbGNice.Value = 50;
			this.pbGNice.Visible = ((bool)(resources.GetObject("pbGNice.Visible")));
			this.pbGNice.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbGPlayful
			// 
			this.pbGPlayful.AccessibleDescription = resources.GetString("pbGPlayful.AccessibleDescription");
			this.pbGPlayful.AccessibleName = resources.GetString("pbGPlayful.AccessibleName");
			this.pbGPlayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbGPlayful.Anchor")));
			this.pbGPlayful.AutoScroll = ((bool)(resources.GetObject("pbGPlayful.AutoScroll")));
			this.pbGPlayful.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbGPlayful.AutoScrollMargin")));
			this.pbGPlayful.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbGPlayful.AutoScrollMinSize")));
			this.pbGPlayful.BackColor = System.Drawing.Color.Transparent;
			this.pbGPlayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGPlayful.BackgroundImage")));
			this.pbGPlayful.DisplayOffset = 0;
			this.pbGPlayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbGPlayful.Dock")));
			this.pbGPlayful.DockPadding.Bottom = 5;
			this.pbGPlayful.Enabled = ((bool)(resources.GetObject("pbGPlayful.Enabled")));
			this.pbGPlayful.Font = ((System.Drawing.Font)(resources.GetObject("pbGPlayful.Font")));
			this.pbGPlayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbGPlayful.ImeMode")));
			this.pbGPlayful.LabelText = resources.GetString("pbGPlayful.LabelText");
			this.pbGPlayful.LabelWidth = ((int)(resources.GetObject("pbGPlayful.LabelWidth")));
			this.pbGPlayful.Location = ((System.Drawing.Point)(resources.GetObject("pbGPlayful.Location")));
			this.pbGPlayful.Maximum = 1000;
			this.pbGPlayful.Name = "pbGPlayful";
			this.pbGPlayful.NumberFormat = "N1";
			this.pbGPlayful.NumberOffset = 0;
			this.pbGPlayful.NumberScale = 0.01;
			this.pbGPlayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbGPlayful.RightToLeft")));
			this.pbGPlayful.SelectedColor = System.Drawing.Color.Lime;
			this.pbGPlayful.Size = ((System.Drawing.Size)(resources.GetObject("pbGPlayful.Size")));
			this.pbGPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGPlayful.TabIndex = ((int)(resources.GetObject("pbGPlayful.TabIndex")));
			this.pbGPlayful.TextboxWidth = ((int)(resources.GetObject("pbGPlayful.TextboxWidth")));
			this.pbGPlayful.TokenCount = 10;
			this.pbGPlayful.UnselectedColor = System.Drawing.Color.Black;
			this.pbGPlayful.Value = 50;
			this.pbGPlayful.Visible = ((bool)(resources.GetObject("pbGPlayful.Visible")));
			this.pbGPlayful.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbGActive
			// 
			this.pbGActive.AccessibleDescription = resources.GetString("pbGActive.AccessibleDescription");
			this.pbGActive.AccessibleName = resources.GetString("pbGActive.AccessibleName");
			this.pbGActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbGActive.Anchor")));
			this.pbGActive.AutoScroll = ((bool)(resources.GetObject("pbGActive.AutoScroll")));
			this.pbGActive.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbGActive.AutoScrollMargin")));
			this.pbGActive.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbGActive.AutoScrollMinSize")));
			this.pbGActive.BackColor = System.Drawing.Color.Transparent;
			this.pbGActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGActive.BackgroundImage")));
			this.pbGActive.DisplayOffset = 0;
			this.pbGActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbGActive.Dock")));
			this.pbGActive.DockPadding.Bottom = 5;
			this.pbGActive.Enabled = ((bool)(resources.GetObject("pbGActive.Enabled")));
			this.pbGActive.Font = ((System.Drawing.Font)(resources.GetObject("pbGActive.Font")));
			this.pbGActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbGActive.ImeMode")));
			this.pbGActive.LabelText = resources.GetString("pbGActive.LabelText");
			this.pbGActive.LabelWidth = ((int)(resources.GetObject("pbGActive.LabelWidth")));
			this.pbGActive.Location = ((System.Drawing.Point)(resources.GetObject("pbGActive.Location")));
			this.pbGActive.Maximum = 1000;
			this.pbGActive.Name = "pbGActive";
			this.pbGActive.NumberFormat = "N1";
			this.pbGActive.NumberOffset = 0;
			this.pbGActive.NumberScale = 0.01;
			this.pbGActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbGActive.RightToLeft")));
			this.pbGActive.SelectedColor = System.Drawing.Color.Lime;
			this.pbGActive.Size = ((System.Drawing.Size)(resources.GetObject("pbGActive.Size")));
			this.pbGActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGActive.TabIndex = ((int)(resources.GetObject("pbGActive.TabIndex")));
			this.pbGActive.TextboxWidth = ((int)(resources.GetObject("pbGActive.TextboxWidth")));
			this.pbGActive.TokenCount = 10;
			this.pbGActive.UnselectedColor = System.Drawing.Color.Black;
			this.pbGActive.Value = 50;
			this.pbGActive.Visible = ((bool)(resources.GetObject("pbGActive.Visible")));
			this.pbGActive.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbGOutgoing
			// 
			this.pbGOutgoing.AccessibleDescription = resources.GetString("pbGOutgoing.AccessibleDescription");
			this.pbGOutgoing.AccessibleName = resources.GetString("pbGOutgoing.AccessibleName");
			this.pbGOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbGOutgoing.Anchor")));
			this.pbGOutgoing.AutoScroll = ((bool)(resources.GetObject("pbGOutgoing.AutoScroll")));
			this.pbGOutgoing.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbGOutgoing.AutoScrollMargin")));
			this.pbGOutgoing.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbGOutgoing.AutoScrollMinSize")));
			this.pbGOutgoing.BackColor = System.Drawing.Color.Transparent;
			this.pbGOutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGOutgoing.BackgroundImage")));
			this.pbGOutgoing.DisplayOffset = 0;
			this.pbGOutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbGOutgoing.Dock")));
			this.pbGOutgoing.DockPadding.Bottom = 5;
			this.pbGOutgoing.Enabled = ((bool)(resources.GetObject("pbGOutgoing.Enabled")));
			this.pbGOutgoing.Font = ((System.Drawing.Font)(resources.GetObject("pbGOutgoing.Font")));
			this.pbGOutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbGOutgoing.ImeMode")));
			this.pbGOutgoing.LabelText = resources.GetString("pbGOutgoing.LabelText");
			this.pbGOutgoing.LabelWidth = ((int)(resources.GetObject("pbGOutgoing.LabelWidth")));
			this.pbGOutgoing.Location = ((System.Drawing.Point)(resources.GetObject("pbGOutgoing.Location")));
			this.pbGOutgoing.Maximum = 1000;
			this.pbGOutgoing.Name = "pbGOutgoing";
			this.pbGOutgoing.NumberFormat = "N1";
			this.pbGOutgoing.NumberOffset = 0;
			this.pbGOutgoing.NumberScale = 0.01;
			this.pbGOutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbGOutgoing.RightToLeft")));
			this.pbGOutgoing.SelectedColor = System.Drawing.Color.Lime;
			this.pbGOutgoing.Size = ((System.Drawing.Size)(resources.GetObject("pbGOutgoing.Size")));
			this.pbGOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGOutgoing.TabIndex = ((int)(resources.GetObject("pbGOutgoing.TabIndex")));
			this.pbGOutgoing.TextboxWidth = ((int)(resources.GetObject("pbGOutgoing.TextboxWidth")));
			this.pbGOutgoing.TokenCount = 10;
			this.pbGOutgoing.UnselectedColor = System.Drawing.Color.Black;
			this.pbGOutgoing.Value = 50;
			this.pbGOutgoing.Visible = ((bool)(resources.GetObject("pbGOutgoing.Visible")));
			this.pbGOutgoing.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbGNeat
			// 
			this.pbGNeat.AccessibleDescription = resources.GetString("pbGNeat.AccessibleDescription");
			this.pbGNeat.AccessibleName = resources.GetString("pbGNeat.AccessibleName");
			this.pbGNeat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbGNeat.Anchor")));
			this.pbGNeat.AutoScroll = ((bool)(resources.GetObject("pbGNeat.AutoScroll")));
			this.pbGNeat.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbGNeat.AutoScrollMargin")));
			this.pbGNeat.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbGNeat.AutoScrollMinSize")));
			this.pbGNeat.BackColor = System.Drawing.Color.Transparent;
			this.pbGNeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbGNeat.BackgroundImage")));
			this.pbGNeat.DisplayOffset = 0;
			this.pbGNeat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbGNeat.Dock")));
			this.pbGNeat.DockPadding.Bottom = 5;
			this.pbGNeat.Enabled = ((bool)(resources.GetObject("pbGNeat.Enabled")));
			this.pbGNeat.Font = ((System.Drawing.Font)(resources.GetObject("pbGNeat.Font")));
			this.pbGNeat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbGNeat.ImeMode")));
			this.pbGNeat.LabelText = resources.GetString("pbGNeat.LabelText");
			this.pbGNeat.LabelWidth = ((int)(resources.GetObject("pbGNeat.LabelWidth")));
			this.pbGNeat.Location = ((System.Drawing.Point)(resources.GetObject("pbGNeat.Location")));
			this.pbGNeat.Maximum = 1000;
			this.pbGNeat.Name = "pbGNeat";
			this.pbGNeat.NumberFormat = "N1";
			this.pbGNeat.NumberOffset = 0;
			this.pbGNeat.NumberScale = 0.01;
			this.pbGNeat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbGNeat.RightToLeft")));
			this.pbGNeat.SelectedColor = System.Drawing.Color.Lime;
			this.pbGNeat.Size = ((System.Drawing.Size)(resources.GetObject("pbGNeat.Size")));
			this.pbGNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbGNeat.TabIndex = ((int)(resources.GetObject("pbGNeat.TabIndex")));
			this.pbGNeat.TextboxWidth = ((int)(resources.GetObject("pbGNeat.TextboxWidth")));
			this.pbGNeat.TokenCount = 10;
			this.pbGNeat.UnselectedColor = System.Drawing.Color.Black;
			this.pbGNeat.Value = 50;
			this.pbGNeat.Visible = ((bool)(resources.GetObject("pbGNeat.Visible")));
			this.pbGNeat.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbNice
			// 
			this.pbNice.AccessibleDescription = resources.GetString("pbNice.AccessibleDescription");
			this.pbNice.AccessibleName = resources.GetString("pbNice.AccessibleName");
			this.pbNice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbNice.Anchor")));
			this.pbNice.AutoScroll = ((bool)(resources.GetObject("pbNice.AutoScroll")));
			this.pbNice.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbNice.AutoScrollMargin")));
			this.pbNice.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbNice.AutoScrollMinSize")));
			this.pbNice.BackColor = System.Drawing.Color.Transparent;
			this.pbNice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNice.BackgroundImage")));
			this.pbNice.DisplayOffset = 0;
			this.pbNice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbNice.Dock")));
			this.pbNice.DockPadding.Bottom = 5;
			this.pbNice.Enabled = ((bool)(resources.GetObject("pbNice.Enabled")));
			this.pbNice.Font = ((System.Drawing.Font)(resources.GetObject("pbNice.Font")));
			this.pbNice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbNice.ImeMode")));
			this.pbNice.LabelText = resources.GetString("pbNice.LabelText");
			this.pbNice.LabelWidth = ((int)(resources.GetObject("pbNice.LabelWidth")));
			this.pbNice.Location = ((System.Drawing.Point)(resources.GetObject("pbNice.Location")));
			this.pbNice.Maximum = 1000;
			this.pbNice.Name = "pbNice";
			this.pbNice.NumberFormat = "N1";
			this.pbNice.NumberOffset = 0;
			this.pbNice.NumberScale = 0.01;
			this.pbNice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbNice.RightToLeft")));
			this.pbNice.SelectedColor = System.Drawing.Color.Lime;
			this.pbNice.Size = ((System.Drawing.Size)(resources.GetObject("pbNice.Size")));
			this.pbNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbNice.TabIndex = ((int)(resources.GetObject("pbNice.TabIndex")));
			this.pbNice.TextboxWidth = ((int)(resources.GetObject("pbNice.TextboxWidth")));
			this.pbNice.TokenCount = 10;
			this.pbNice.UnselectedColor = System.Drawing.Color.Black;
			this.pbNice.Value = 50;
			this.pbNice.Visible = ((bool)(resources.GetObject("pbNice.Visible")));
			this.pbNice.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbPlayful
			// 
			this.pbPlayful.AccessibleDescription = resources.GetString("pbPlayful.AccessibleDescription");
			this.pbPlayful.AccessibleName = resources.GetString("pbPlayful.AccessibleName");
			this.pbPlayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbPlayful.Anchor")));
			this.pbPlayful.AutoScroll = ((bool)(resources.GetObject("pbPlayful.AutoScroll")));
			this.pbPlayful.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbPlayful.AutoScrollMargin")));
			this.pbPlayful.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbPlayful.AutoScrollMinSize")));
			this.pbPlayful.BackColor = System.Drawing.Color.Transparent;
			this.pbPlayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPlayful.BackgroundImage")));
			this.pbPlayful.DisplayOffset = 0;
			this.pbPlayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbPlayful.Dock")));
			this.pbPlayful.DockPadding.Bottom = 5;
			this.pbPlayful.Enabled = ((bool)(resources.GetObject("pbPlayful.Enabled")));
			this.pbPlayful.Font = ((System.Drawing.Font)(resources.GetObject("pbPlayful.Font")));
			this.pbPlayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbPlayful.ImeMode")));
			this.pbPlayful.LabelText = resources.GetString("pbPlayful.LabelText");
			this.pbPlayful.LabelWidth = ((int)(resources.GetObject("pbPlayful.LabelWidth")));
			this.pbPlayful.Location = ((System.Drawing.Point)(resources.GetObject("pbPlayful.Location")));
			this.pbPlayful.Maximum = 1000;
			this.pbPlayful.Name = "pbPlayful";
			this.pbPlayful.NumberFormat = "N1";
			this.pbPlayful.NumberOffset = 0;
			this.pbPlayful.NumberScale = 0.01;
			this.pbPlayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbPlayful.RightToLeft")));
			this.pbPlayful.SelectedColor = System.Drawing.Color.Lime;
			this.pbPlayful.Size = ((System.Drawing.Size)(resources.GetObject("pbPlayful.Size")));
			this.pbPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbPlayful.TabIndex = ((int)(resources.GetObject("pbPlayful.TabIndex")));
			this.pbPlayful.TextboxWidth = ((int)(resources.GetObject("pbPlayful.TextboxWidth")));
			this.pbPlayful.TokenCount = 10;
			this.pbPlayful.UnselectedColor = System.Drawing.Color.Black;
			this.pbPlayful.Value = 50;
			this.pbPlayful.Visible = ((bool)(resources.GetObject("pbPlayful.Visible")));
			this.pbPlayful.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbActive
			// 
			this.pbActive.AccessibleDescription = resources.GetString("pbActive.AccessibleDescription");
			this.pbActive.AccessibleName = resources.GetString("pbActive.AccessibleName");
			this.pbActive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbActive.Anchor")));
			this.pbActive.AutoScroll = ((bool)(resources.GetObject("pbActive.AutoScroll")));
			this.pbActive.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbActive.AutoScrollMargin")));
			this.pbActive.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbActive.AutoScrollMinSize")));
			this.pbActive.BackColor = System.Drawing.Color.Transparent;
			this.pbActive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbActive.BackgroundImage")));
			this.pbActive.DisplayOffset = 0;
			this.pbActive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbActive.Dock")));
			this.pbActive.DockPadding.Bottom = 5;
			this.pbActive.Enabled = ((bool)(resources.GetObject("pbActive.Enabled")));
			this.pbActive.Font = ((System.Drawing.Font)(resources.GetObject("pbActive.Font")));
			this.pbActive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbActive.ImeMode")));
			this.pbActive.LabelText = resources.GetString("pbActive.LabelText");
			this.pbActive.LabelWidth = ((int)(resources.GetObject("pbActive.LabelWidth")));
			this.pbActive.Location = ((System.Drawing.Point)(resources.GetObject("pbActive.Location")));
			this.pbActive.Maximum = 1000;
			this.pbActive.Name = "pbActive";
			this.pbActive.NumberFormat = "N1";
			this.pbActive.NumberOffset = 0;
			this.pbActive.NumberScale = 0.01;
			this.pbActive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbActive.RightToLeft")));
			this.pbActive.SelectedColor = System.Drawing.Color.Lime;
			this.pbActive.Size = ((System.Drawing.Size)(resources.GetObject("pbActive.Size")));
			this.pbActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbActive.TabIndex = ((int)(resources.GetObject("pbActive.TabIndex")));
			this.pbActive.TextboxWidth = ((int)(resources.GetObject("pbActive.TextboxWidth")));
			this.pbActive.TokenCount = 10;
			this.pbActive.UnselectedColor = System.Drawing.Color.Black;
			this.pbActive.Value = 50;
			this.pbActive.Visible = ((bool)(resources.GetObject("pbActive.Visible")));
			this.pbActive.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbOutgoing
			// 
			this.pbOutgoing.AccessibleDescription = resources.GetString("pbOutgoing.AccessibleDescription");
			this.pbOutgoing.AccessibleName = resources.GetString("pbOutgoing.AccessibleName");
			this.pbOutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbOutgoing.Anchor")));
			this.pbOutgoing.AutoScroll = ((bool)(resources.GetObject("pbOutgoing.AutoScroll")));
			this.pbOutgoing.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbOutgoing.AutoScrollMargin")));
			this.pbOutgoing.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbOutgoing.AutoScrollMinSize")));
			this.pbOutgoing.BackColor = System.Drawing.Color.Transparent;
			this.pbOutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbOutgoing.BackgroundImage")));
			this.pbOutgoing.DisplayOffset = 0;
			this.pbOutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbOutgoing.Dock")));
			this.pbOutgoing.DockPadding.Bottom = 5;
			this.pbOutgoing.Enabled = ((bool)(resources.GetObject("pbOutgoing.Enabled")));
			this.pbOutgoing.Font = ((System.Drawing.Font)(resources.GetObject("pbOutgoing.Font")));
			this.pbOutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbOutgoing.ImeMode")));
			this.pbOutgoing.LabelText = resources.GetString("pbOutgoing.LabelText");
			this.pbOutgoing.LabelWidth = ((int)(resources.GetObject("pbOutgoing.LabelWidth")));
			this.pbOutgoing.Location = ((System.Drawing.Point)(resources.GetObject("pbOutgoing.Location")));
			this.pbOutgoing.Maximum = 1000;
			this.pbOutgoing.Name = "pbOutgoing";
			this.pbOutgoing.NumberFormat = "N1";
			this.pbOutgoing.NumberOffset = 0;
			this.pbOutgoing.NumberScale = 0.01;
			this.pbOutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbOutgoing.RightToLeft")));
			this.pbOutgoing.SelectedColor = System.Drawing.Color.Lime;
			this.pbOutgoing.Size = ((System.Drawing.Size)(resources.GetObject("pbOutgoing.Size")));
			this.pbOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbOutgoing.TabIndex = ((int)(resources.GetObject("pbOutgoing.TabIndex")));
			this.pbOutgoing.TextboxWidth = ((int)(resources.GetObject("pbOutgoing.TextboxWidth")));
			this.pbOutgoing.TokenCount = 10;
			this.pbOutgoing.UnselectedColor = System.Drawing.Color.Black;
			this.pbOutgoing.Value = 50;
			this.pbOutgoing.Visible = ((bool)(resources.GetObject("pbOutgoing.Visible")));
			this.pbOutgoing.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// pbNeat
			// 
			this.pbNeat.AccessibleDescription = resources.GetString("pbNeat.AccessibleDescription");
			this.pbNeat.AccessibleName = resources.GetString("pbNeat.AccessibleName");
			this.pbNeat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbNeat.Anchor")));
			this.pbNeat.AutoScroll = ((bool)(resources.GetObject("pbNeat.AutoScroll")));
			this.pbNeat.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbNeat.AutoScrollMargin")));
			this.pbNeat.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbNeat.AutoScrollMinSize")));
			this.pbNeat.BackColor = System.Drawing.Color.Transparent;
			this.pbNeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbNeat.BackgroundImage")));
			this.pbNeat.DisplayOffset = 0;
			this.pbNeat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbNeat.Dock")));
			this.pbNeat.DockPadding.Bottom = 5;
			this.pbNeat.Enabled = ((bool)(resources.GetObject("pbNeat.Enabled")));
			this.pbNeat.Font = ((System.Drawing.Font)(resources.GetObject("pbNeat.Font")));
			this.pbNeat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbNeat.ImeMode")));
			this.pbNeat.LabelText = resources.GetString("pbNeat.LabelText");
			this.pbNeat.LabelWidth = ((int)(resources.GetObject("pbNeat.LabelWidth")));
			this.pbNeat.Location = ((System.Drawing.Point)(resources.GetObject("pbNeat.Location")));
			this.pbNeat.Maximum = 1000;
			this.pbNeat.Name = "pbNeat";
			this.pbNeat.NumberFormat = "N1";
			this.pbNeat.NumberOffset = 0;
			this.pbNeat.NumberScale = 0.01;
			this.pbNeat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbNeat.RightToLeft")));
			this.pbNeat.SelectedColor = System.Drawing.Color.Lime;
			this.pbNeat.Size = ((System.Drawing.Size)(resources.GetObject("pbNeat.Size")));
			this.pbNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbNeat.TabIndex = ((int)(resources.GetObject("pbNeat.TabIndex")));
			this.pbNeat.TextboxWidth = ((int)(resources.GetObject("pbNeat.TextboxWidth")));
			this.pbNeat.TokenCount = 10;
			this.pbNeat.UnselectedColor = System.Drawing.Color.Black;
			this.pbNeat.Value = 50;
			this.pbNeat.Visible = ((bool)(resources.GetObject("pbNeat.Visible")));
			this.pbNeat.Changed += new System.EventHandler(this.ChangedChar);
			// 
			// cbzodiac
			// 
			this.cbzodiac.AccessibleDescription = resources.GetString("cbzodiac.AccessibleDescription");
			this.cbzodiac.AccessibleName = resources.GetString("cbzodiac.AccessibleName");
			this.cbzodiac.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbzodiac.Anchor")));
			this.cbzodiac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbzodiac.BackgroundImage")));
			this.cbzodiac.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbzodiac.Dock")));
			this.cbzodiac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbzodiac.Enabled = ((bool)(resources.GetObject("cbzodiac.Enabled")));
			this.cbzodiac.Font = ((System.Drawing.Font)(resources.GetObject("cbzodiac.Font")));
			this.cbzodiac.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbzodiac.ImeMode")));
			this.cbzodiac.IntegralHeight = ((bool)(resources.GetObject("cbzodiac.IntegralHeight")));
			this.cbzodiac.ItemHeight = ((int)(resources.GetObject("cbzodiac.ItemHeight")));
			this.cbzodiac.Location = ((System.Drawing.Point)(resources.GetObject("cbzodiac.Location")));
			this.cbzodiac.MaxDropDownItems = ((int)(resources.GetObject("cbzodiac.MaxDropDownItems")));
			this.cbzodiac.MaxLength = ((int)(resources.GetObject("cbzodiac.MaxLength")));
			this.cbzodiac.Name = "cbzodiac";
			this.cbzodiac.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbzodiac.RightToLeft")));
			this.cbzodiac.Size = ((System.Drawing.Size)(resources.GetObject("cbzodiac.Size")));
			this.cbzodiac.TabIndex = ((int)(resources.GetObject("cbzodiac.TabIndex")));
			this.cbzodiac.Text = resources.GetString("cbzodiac.Text");
			this.cbzodiac.Visible = ((bool)(resources.GetObject("cbzodiac.Visible")));
			this.cbzodiac.SelectedIndexChanged += new System.EventHandler(this.ChangedChar);
			// 
			// label47
			// 
			this.label47.AccessibleDescription = resources.GetString("label47.AccessibleDescription");
			this.label47.AccessibleName = resources.GetString("label47.AccessibleName");
			this.label47.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label47.Anchor")));
			this.label47.AutoSize = ((bool)(resources.GetObject("label47.AutoSize")));
			this.label47.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label47.Dock")));
			this.label47.Enabled = ((bool)(resources.GetObject("label47.Enabled")));
			this.label47.Font = ((System.Drawing.Font)(resources.GetObject("label47.Font")));
			this.label47.Image = ((System.Drawing.Image)(resources.GetObject("label47.Image")));
			this.label47.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label47.ImageAlign")));
			this.label47.ImageIndex = ((int)(resources.GetObject("label47.ImageIndex")));
			this.label47.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label47.ImeMode")));
			this.label47.Location = ((System.Drawing.Point)(resources.GetObject("label47.Location")));
			this.label47.Name = "label47";
			this.label47.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label47.RightToLeft")));
			this.label47.Size = ((System.Drawing.Size)(resources.GetObject("label47.Size")));
			this.label47.TabIndex = ((int)(resources.GetObject("label47.TabIndex")));
			this.label47.Text = resources.GetString("label47.Text");
			this.label47.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label47.TextAlign")));
			this.label47.Visible = ((bool)(resources.GetObject("label47.Visible")));
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			// 
			// label69
			// 
			this.label69.AccessibleDescription = resources.GetString("label69.AccessibleDescription");
			this.label69.AccessibleName = resources.GetString("label69.AccessibleName");
			this.label69.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label69.Anchor")));
			this.label69.AutoSize = ((bool)(resources.GetObject("label69.AutoSize")));
			this.label69.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label69.Dock")));
			this.label69.Enabled = ((bool)(resources.GetObject("label69.Enabled")));
			this.label69.Font = ((System.Drawing.Font)(resources.GetObject("label69.Font")));
			this.label69.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label69.Image = ((System.Drawing.Image)(resources.GetObject("label69.Image")));
			this.label69.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label69.ImageAlign")));
			this.label69.ImageIndex = ((int)(resources.GetObject("label69.ImageIndex")));
			this.label69.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label69.ImeMode")));
			this.label69.Location = ((System.Drawing.Point)(resources.GetObject("label69.Location")));
			this.label69.Name = "label69";
			this.label69.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label69.RightToLeft")));
			this.label69.Size = ((System.Drawing.Size)(resources.GetObject("label69.Size")));
			this.label69.TabIndex = ((int)(resources.GetObject("label69.TabIndex")));
			this.label69.Text = resources.GetString("label69.Text");
			this.label69.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label69.TextAlign")));
			this.label69.Visible = ((bool)(resources.GetObject("label69.Visible")));
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel1.Dock")));
			this.panel1.Enabled = ((bool)(resources.GetObject("panel1.Enabled")));
			this.panel1.Font = ((System.Drawing.Font)(resources.GetObject("panel1.Font")));
			this.panel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel1.ImeMode")));
			this.panel1.Location = ((System.Drawing.Point)(resources.GetObject("panel1.Location")));
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel1.RightToLeft")));
			this.panel1.Size = ((System.Drawing.Size)(resources.GetObject("panel1.Size")));
			this.panel1.TabIndex = ((int)(resources.GetObject("panel1.TabIndex")));
			this.panel1.Text = resources.GetString("panel1.Text");
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			// 
			// label70
			// 
			this.label70.AccessibleDescription = resources.GetString("label70.AccessibleDescription");
			this.label70.AccessibleName = resources.GetString("label70.AccessibleName");
			this.label70.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label70.Anchor")));
			this.label70.AutoSize = ((bool)(resources.GetObject("label70.AutoSize")));
			this.label70.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label70.Dock")));
			this.label70.Enabled = ((bool)(resources.GetObject("label70.Enabled")));
			this.label70.Font = ((System.Drawing.Font)(resources.GetObject("label70.Font")));
			this.label70.ForeColor = System.Drawing.SystemColors.WindowText;
			this.label70.Image = ((System.Drawing.Image)(resources.GetObject("label70.Image")));
			this.label70.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label70.ImageAlign")));
			this.label70.ImageIndex = ((int)(resources.GetObject("label70.ImageIndex")));
			this.label70.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label70.ImeMode")));
			this.label70.Location = ((System.Drawing.Point)(resources.GetObject("label70.Location")));
			this.label70.Name = "label70";
			this.label70.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label70.RightToLeft")));
			this.label70.Size = ((System.Drawing.Size)(resources.GetObject("label70.Size")));
			this.label70.TabIndex = ((int)(resources.GetObject("label70.TabIndex")));
			this.label70.Text = resources.GetString("label70.Text");
			this.label70.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label70.TextAlign")));
			this.label70.Visible = ((bool)(resources.GetObject("label70.Visible")));
			// 
			// menuBar1
			// 
			this.menuBar1.AccessibleDescription = resources.GetString("menuBar1.AccessibleDescription");
			this.menuBar1.AccessibleName = resources.GetString("menuBar1.AccessibleName");
			this.menuBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("menuBar1.Anchor")));
			this.menuBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuBar1.BackgroundImage")));
			this.menuBar1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("menuBar1.Dock")));
			this.menuBar1.Enabled = ((bool)(resources.GetObject("menuBar1.Enabled")));
			this.menuBar1.Font = ((System.Drawing.Font)(resources.GetObject("menuBar1.Font")));
			this.menuBar1.Guid = new System.Guid("3f236769-07ab-43a2-b382-15b597af92c2");
			this.menuBar1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("menuBar1.ImeMode")));
			this.menuBar1.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			  this.mbiLink,
																			  this.miRel});
			this.menuBar1.Location = ((System.Drawing.Point)(resources.GetObject("menuBar1.Location")));
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.OwnerForm = null;
			this.menuBar1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("menuBar1.RightToLeft")));
			this.menuBar1.Size = ((System.Drawing.Size)(resources.GetObject("menuBar1.Size")));
			this.menuBar1.TabIndex = ((int)(resources.GetObject("menuBar1.TabIndex")));
			this.menuBar1.Text = resources.GetString("menuBar1.Text");
			this.menuBar1.Visible = ((bool)(resources.GetObject("menuBar1.Visible")));
			// 
			// mbiLink
			// 
			this.mbiLink.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																			 this.mbiMax,
																			 this.miRand,
																			 this.miOpenChar,
																			 this.miOpenWf,
																			 this.miOpenMem,
																			 this.miOpenBadge,
																			 this.miOpenDNA,
																			 this.miOpenFamily,
																			 this.miOpenCloth,
																			 this.miMore,
																			 this.miRelink});
			this.mbiLink.Text = resources.GetString("mbiLink.Text");
			this.mbiLink.ToolTipText = resources.GetString("mbiLink.ToolTipText");
			this.mbiLink.Visible = true;
			// 
			// miRand
			// 
			this.miRand.Image = ((System.Drawing.Image)(resources.GetObject("miRand.Image")));
			this.miRand.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRand.Shortcut")));
			this.miRand.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRand.Shortcut2")));
			this.miRand.Text = resources.GetString("miRand.Text");
			this.miRand.ToolTipText = resources.GetString("miRand.ToolTipText");
			this.miRand.Activate += new System.EventHandler(this.Activate_biRand);
			// 
			// miOpenChar
			// 
			this.miOpenChar.BeginGroup = true;
			this.miOpenChar.Image = ((System.Drawing.Image)(resources.GetObject("miOpenChar.Image")));
			this.miOpenChar.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenChar.Shortcut")));
			this.miOpenChar.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenChar.Shortcut2")));
			this.miOpenChar.Text = resources.GetString("miOpenChar.Text");
			this.miOpenChar.ToolTipText = resources.GetString("miOpenChar.ToolTipText");
			this.miOpenChar.Activate += new System.EventHandler(this.Activate_miOpenCHar);
			// 
			// miOpenWf
			// 
			this.miOpenWf.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenWf.Shortcut")));
			this.miOpenWf.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenWf.Shortcut2")));
			this.miOpenWf.Text = resources.GetString("miOpenWf.Text");
			this.miOpenWf.ToolTipText = resources.GetString("miOpenWf.ToolTipText");
			this.miOpenWf.Activate += new System.EventHandler(this.Activate_miOpenWf);
			// 
			// miOpenMem
			// 
			this.miOpenMem.Image = ((System.Drawing.Image)(resources.GetObject("miOpenMem.Image")));
			this.miOpenMem.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenMem.Shortcut")));
			this.miOpenMem.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenMem.Shortcut2")));
			this.miOpenMem.Text = resources.GetString("miOpenMem.Text");
			this.miOpenMem.ToolTipText = resources.GetString("miOpenMem.ToolTipText");
			this.miOpenMem.Activate += new System.EventHandler(this.Activate_miOpenMem);
			// 
			// miOpenBadge
			// 
			this.miOpenBadge.Image = ((System.Drawing.Image)(resources.GetObject("miOpenBadge.Image")));
			this.miOpenBadge.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenBadge.Shortcut")));
			this.miOpenBadge.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenBadge.Shortcut2")));
			this.miOpenBadge.Text = resources.GetString("miOpenBadge.Text");
			this.miOpenBadge.ToolTipText = resources.GetString("miOpenBadge.ToolTipText");
			this.miOpenBadge.Activate += new System.EventHandler(this.Activate_miOpenBadge);
			// 
			// miOpenDNA
			// 
			this.miOpenDNA.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenDNA.Shortcut")));
			this.miOpenDNA.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenDNA.Shortcut2")));
			this.miOpenDNA.Text = resources.GetString("miOpenDNA.Text");
			this.miOpenDNA.ToolTipText = resources.GetString("miOpenDNA.ToolTipText");
			this.miOpenDNA.Activate += new System.EventHandler(this.Activate_miOpenDNA);
			// 
			// miOpenFamily
			// 
			this.miOpenFamily.Image = ((System.Drawing.Image)(resources.GetObject("miOpenFamily.Image")));
			this.miOpenFamily.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenFamily.Shortcut")));
			this.miOpenFamily.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenFamily.Shortcut2")));
			this.miOpenFamily.Text = resources.GetString("miOpenFamily.Text");
			this.miOpenFamily.ToolTipText = resources.GetString("miOpenFamily.ToolTipText");
			this.miOpenFamily.Activate += new System.EventHandler(this.Activate_miFamily);
			// 
			// miOpenCloth
			// 
			this.miOpenCloth.ForeColor = System.Drawing.SystemColors.WindowText;
			this.miOpenCloth.Image = ((System.Drawing.Image)(resources.GetObject("miOpenCloth.Image")));
			this.miOpenCloth.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenCloth.Shortcut")));
			this.miOpenCloth.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miOpenCloth.Shortcut2")));
			this.miOpenCloth.Text = resources.GetString("miOpenCloth.Text");
			this.miOpenCloth.ToolTipText = resources.GetString("miOpenCloth.ToolTipText");
			this.miOpenCloth.Activate += new System.EventHandler(this.Activate_miOpenCloth);
			// 
			// miMore
			// 
			this.miMore.BeginGroup = true;
			this.miMore.Image = ((System.Drawing.Image)(resources.GetObject("miMore.Image")));
			this.miMore.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miMore.Shortcut")));
			this.miMore.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miMore.Shortcut2")));
			this.miMore.Text = resources.GetString("miMore.Text");
			this.miMore.ToolTipText = resources.GetString("miMore.ToolTipText");
			this.miMore.Activate += new System.EventHandler(this.Activate_miMore);
			// 
			// miRelink
			// 
			this.miRelink.Image = ((System.Drawing.Image)(resources.GetObject("miRelink.Image")));
			this.miRelink.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRelink.Shortcut")));
			this.miRelink.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRelink.Shortcut2")));
			this.miRelink.Text = resources.GetString("miRelink.Text");
			this.miRelink.ToolTipText = resources.GetString("miRelink.ToolTipText");
			this.miRelink.Activate += new System.EventHandler(this.Activate_miRelink);
			// 
			// miRel
			// 
			this.miRel.Items.AddRange(new TD.SandBar.ToolbarItemBase[] {
																		   this.miAddRelation,
																		   this.miRemRelation,
																		   this.mbiMaxThisRel,
																		   this.mbiMaxKnownRel});
			this.miRel.Text = resources.GetString("miRel.Text");
			this.miRel.ToolTipText = resources.GetString("miRel.ToolTipText");
			this.miRel.Visible = true;
			this.miRel.BeforePopup += new TD.SandBar.MenuItemBase.BeforePopupEventHandler(this.miRel_BeforePopup);
			// 
			// miAddRelation
			// 
			this.miAddRelation.Image = ((System.Drawing.Image)(resources.GetObject("miAddRelation.Image")));
			this.miAddRelation.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAddRelation.Shortcut")));
			this.miAddRelation.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miAddRelation.Shortcut2")));
			this.miAddRelation.Text = resources.GetString("miAddRelation.Text");
			this.miAddRelation.ToolTipText = resources.GetString("miAddRelation.ToolTipText");
			this.miAddRelation.Activate += new System.EventHandler(this.Activate_miAddRelation);
			// 
			// miRemRelation
			// 
			this.miRemRelation.Image = ((System.Drawing.Image)(resources.GetObject("miRemRelation.Image")));
			this.miRemRelation.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRemRelation.Shortcut")));
			this.miRemRelation.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("miRemRelation.Shortcut2")));
			this.miRemRelation.Text = resources.GetString("miRemRelation.Text");
			this.miRemRelation.ToolTipText = resources.GetString("miRemRelation.ToolTipText");
			this.miRemRelation.Activate += new System.EventHandler(this.Activate_miRemRelation);
			// 
			// mbiMaxThisRel
			// 
			this.mbiMaxThisRel.BeginGroup = true;
			this.mbiMaxThisRel.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMaxThisRel.Shortcut")));
			this.mbiMaxThisRel.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMaxThisRel.Shortcut2")));
			this.mbiMaxThisRel.Text = resources.GetString("mbiMaxThisRel.Text");
			this.mbiMaxThisRel.ToolTipText = resources.GetString("mbiMaxThisRel.ToolTipText");
			this.mbiMaxThisRel.Activate += new System.EventHandler(this.Activate_mbiMaxThisRel);
			// 
			// mbiMaxKnownRel
			// 
			this.mbiMaxKnownRel.Shortcut = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMaxKnownRel.Shortcut")));
			this.mbiMaxKnownRel.Shortcut2 = ((System.Windows.Forms.Shortcut)(resources.GetObject("mbiMaxKnownRel.Shortcut2")));
			this.mbiMaxKnownRel.Text = resources.GetString("mbiMaxKnownRel.Text");
			this.mbiMaxKnownRel.ToolTipText = resources.GetString("mbiMaxKnownRel.ToolTipText");
			this.mbiMaxKnownRel.Activate += new System.EventHandler(this.Activate_mbiMaxKnownRel);
			// 
			// lv
			// 
			this.lv.AccessibleDescription = resources.GetString("lv.AccessibleDescription");
			this.lv.AccessibleName = resources.GetString("lv.AccessibleName");
			this.lv.Alignment = ((System.Windows.Forms.ListViewAlignment)(resources.GetObject("lv.Alignment")));
			this.lv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lv.Anchor")));
			this.lv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lv.BackgroundImage")));
			this.lv.BorderSelect = true;
			this.lv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
																				 this.columnHeader1,
																				 this.columnHeader2,
																				 this.columnHeader3,
																				 this.columnHeader4,
																				 this.columnHeader5});
			this.lv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lv.Dock")));
			this.lv.Enabled = ((bool)(resources.GetObject("lv.Enabled")));
			this.lv.Font = ((System.Drawing.Font)(resources.GetObject("lv.Font")));
			this.lv.FullRowSelect = true;
			xpListViewGroup1.GroupIndex = 0;
			xpListViewGroup1.GroupText = "Relations";
			xpListViewGroup2.GroupIndex = 2;
			xpListViewGroup2.GroupText = "Unknown Relations";
			xpListViewGroup3.GroupIndex = 1;
			xpListViewGroup3.GroupText = "Sim Pool";
			xpListViewGroup4.GroupIndex = 3;
			xpListViewGroup4.GroupText = "NPC";
			xpListViewGroup5.GroupIndex = 4;
			xpListViewGroup5.GroupText = "Townie";
			this.lv.Groups.Add(xpListViewGroup1);
			this.lv.Groups.Add(xpListViewGroup2);
			this.lv.Groups.Add(xpListViewGroup3);
			this.lv.Groups.Add(xpListViewGroup4);
			this.lv.Groups.Add(xpListViewGroup5);
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lv.HideSelection = false;
			this.lv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lv.ImeMode")));
			this.lv.LabelWrap = ((bool)(resources.GetObject("lv.LabelWrap")));
			this.lv.Location = ((System.Drawing.Point)(resources.GetObject("lv.Location")));
			this.lv.MultiSelect = false;
			this.lv.Name = "lv";
			this.lv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lv.RightToLeft")));
			this.menuBar1.SetSandBarMenu(this.lv, this.miRel);
			this.lv.ShowGroups = true;
			this.lv.Size = ((System.Drawing.Size)(resources.GetObject("lv.Size")));
			this.lv.TabIndex = ((int)(resources.GetObject("lv.TabIndex")));
			this.lv.Text = resources.GetString("lv.Text");
			this.lv.TileColumns = new int[] {
												1,
												2,
												3};
			this.lv.View = SteepValley.Windows.Forms.ExtendedView.Tile;
			this.lv.Visible = ((bool)(resources.GetObject("lv.Visible")));
			this.lv.SelectedIndexChanged += new System.EventHandler(this.lv_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = resources.GetString("columnHeader1.Text");
			this.columnHeader1.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader1.TextAlign")));
			this.columnHeader1.Width = ((int)(resources.GetObject("columnHeader1.Width")));
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = resources.GetString("columnHeader2.Text");
			this.columnHeader2.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader2.TextAlign")));
			this.columnHeader2.Width = ((int)(resources.GetObject("columnHeader2.Width")));
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = resources.GetString("columnHeader3.Text");
			this.columnHeader3.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader3.TextAlign")));
			this.columnHeader3.Width = ((int)(resources.GetObject("columnHeader3.Width")));
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = resources.GetString("columnHeader4.Text");
			this.columnHeader4.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader4.TextAlign")));
			this.columnHeader4.Width = ((int)(resources.GetObject("columnHeader4.Width")));
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = resources.GetString("columnHeader5.Text");
			this.columnHeader5.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("columnHeader5.TextAlign")));
			this.columnHeader5.Width = ((int)(resources.GetObject("columnHeader5.Width")));
			// 
			// pnCareer
			// 
			this.pnCareer.AccessibleDescription = resources.GetString("pnCareer.AccessibleDescription");
			this.pnCareer.AccessibleName = resources.GetString("pnCareer.AccessibleName");
			this.pnCareer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnCareer.Anchor")));
			this.pnCareer.AutoScroll = ((bool)(resources.GetObject("pnCareer.AutoScroll")));
			this.pnCareer.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnCareer.AutoScrollMargin")));
			this.pnCareer.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnCareer.AutoScrollMinSize")));
			this.pnCareer.BackColor = System.Drawing.Color.Transparent;
			this.pnCareer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnCareer.BackgroundImage")));
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
			this.pnCareer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnCareer.Dock")));
			this.pnCareer.Enabled = ((bool)(resources.GetObject("pnCareer.Enabled")));
			this.pnCareer.Font = ((System.Drawing.Font)(resources.GetObject("pnCareer.Font")));
			this.pnCareer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnCareer.ImeMode")));
			this.pnCareer.Location = ((System.Drawing.Point)(resources.GetObject("pnCareer.Location")));
			this.pnCareer.Name = "pnCareer";
			this.pnCareer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnCareer.RightToLeft")));
			this.pnCareer.Size = ((System.Drawing.Size)(resources.GetObject("pnCareer.Size")));
			this.pnCareer.TabIndex = ((int)(resources.GetObject("pnCareer.TabIndex")));
			this.pnCareer.Text = resources.GetString("pnCareer.Text");
			this.pnCareer.Visible = ((bool)(resources.GetObject("pnCareer.Visible")));
			// 
			// pbAspBliz
			// 
			this.pbAspBliz.AccessibleDescription = resources.GetString("pbAspBliz.AccessibleDescription");
			this.pbAspBliz.AccessibleName = resources.GetString("pbAspBliz.AccessibleName");
			this.pbAspBliz.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbAspBliz.Anchor")));
			this.pbAspBliz.AutoScroll = ((bool)(resources.GetObject("pbAspBliz.AutoScroll")));
			this.pbAspBliz.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbAspBliz.AutoScrollMargin")));
			this.pbAspBliz.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbAspBliz.AutoScrollMinSize")));
			this.pbAspBliz.BackColor = System.Drawing.Color.Transparent;
			this.pbAspBliz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAspBliz.BackgroundImage")));
			this.pbAspBliz.DisplayOffset = 0;
			this.pbAspBliz.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbAspBliz.Dock")));
			this.pbAspBliz.DockPadding.Bottom = 5;
			this.pbAspBliz.Enabled = ((bool)(resources.GetObject("pbAspBliz.Enabled")));
			this.pbAspBliz.Font = ((System.Drawing.Font)(resources.GetObject("pbAspBliz.Font")));
			this.pbAspBliz.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbAspBliz.ImeMode")));
			this.pbAspBliz.LabelText = resources.GetString("pbAspBliz.LabelText");
			this.pbAspBliz.LabelWidth = ((int)(resources.GetObject("pbAspBliz.LabelWidth")));
			this.pbAspBliz.Location = ((System.Drawing.Point)(resources.GetObject("pbAspBliz.Location")));
			this.pbAspBliz.Maximum = 1200;
			this.pbAspBliz.Name = "pbAspBliz";
			this.pbAspBliz.NumberFormat = "N0";
			this.pbAspBliz.NumberOffset = 0;
			this.pbAspBliz.NumberScale = 1;
			this.pbAspBliz.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbAspBliz.RightToLeft")));
			this.pbAspBliz.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbAspBliz.Size = ((System.Drawing.Size)(resources.GetObject("pbAspBliz.Size")));
			this.pbAspBliz.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbAspBliz.TabIndex = ((int)(resources.GetObject("pbAspBliz.TabIndex")));
			this.pbAspBliz.TextboxWidth = ((int)(resources.GetObject("pbAspBliz.TextboxWidth")));
			this.pbAspBliz.TokenCount = 21;
			this.pbAspBliz.UnselectedColor = System.Drawing.Color.Black;
			this.pbAspBliz.Value = 10;
			this.pbAspBliz.Visible = ((bool)(resources.GetObject("pbAspBliz.Visible")));
			this.pbAspBliz.Changed += new System.EventHandler(this.ChangedCareer);
			// 
			// label60
			// 
			this.label60.AccessibleDescription = resources.GetString("label60.AccessibleDescription");
			this.label60.AccessibleName = resources.GetString("label60.AccessibleName");
			this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label60.Anchor")));
			this.label60.AutoSize = ((bool)(resources.GetObject("label60.AutoSize")));
			this.label60.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label60.Dock")));
			this.label60.Enabled = ((bool)(resources.GetObject("label60.Enabled")));
			this.label60.Font = ((System.Drawing.Font)(resources.GetObject("label60.Font")));
			this.label60.Image = ((System.Drawing.Image)(resources.GetObject("label60.Image")));
			this.label60.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label60.ImageAlign")));
			this.label60.ImageIndex = ((int)(resources.GetObject("label60.ImageIndex")));
			this.label60.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label60.ImeMode")));
			this.label60.Location = ((System.Drawing.Point)(resources.GetObject("label60.Location")));
			this.label60.Name = "label60";
			this.label60.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label60.RightToLeft")));
			this.label60.Size = ((System.Drawing.Size)(resources.GetObject("label60.Size")));
			this.label60.TabIndex = ((int)(resources.GetObject("label60.TabIndex")));
			this.label60.Text = resources.GetString("label60.Text");
			this.label60.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label60.TextAlign")));
			this.label60.Visible = ((bool)(resources.GetObject("label60.Visible")));
			// 
			// cbaspiration
			// 
			this.cbaspiration.AccessibleDescription = resources.GetString("cbaspiration.AccessibleDescription");
			this.cbaspiration.AccessibleName = resources.GetString("cbaspiration.AccessibleName");
			this.cbaspiration.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbaspiration.Anchor")));
			this.cbaspiration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbaspiration.BackgroundImage")));
			this.cbaspiration.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbaspiration.Dock")));
			this.cbaspiration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbaspiration.Enabled = ((bool)(resources.GetObject("cbaspiration.Enabled")));
			this.cbaspiration.Font = ((System.Drawing.Font)(resources.GetObject("cbaspiration.Font")));
			this.cbaspiration.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbaspiration.ImeMode")));
			this.cbaspiration.IntegralHeight = ((bool)(resources.GetObject("cbaspiration.IntegralHeight")));
			this.cbaspiration.ItemHeight = ((int)(resources.GetObject("cbaspiration.ItemHeight")));
			this.cbaspiration.Location = ((System.Drawing.Point)(resources.GetObject("cbaspiration.Location")));
			this.cbaspiration.MaxDropDownItems = ((int)(resources.GetObject("cbaspiration.MaxDropDownItems")));
			this.cbaspiration.MaxLength = ((int)(resources.GetObject("cbaspiration.MaxLength")));
			this.cbaspiration.Name = "cbaspiration";
			this.cbaspiration.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbaspiration.RightToLeft")));
			this.cbaspiration.Size = ((System.Drawing.Size)(resources.GetObject("cbaspiration.Size")));
			this.cbaspiration.TabIndex = ((int)(resources.GetObject("cbaspiration.TabIndex")));
			this.cbaspiration.Text = resources.GetString("cbaspiration.Text");
			this.cbaspiration.Visible = ((bool)(resources.GetObject("cbaspiration.Visible")));
			this.cbaspiration.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
			// 
			// pbAspCur
			// 
			this.pbAspCur.AccessibleDescription = resources.GetString("pbAspCur.AccessibleDescription");
			this.pbAspCur.AccessibleName = resources.GetString("pbAspCur.AccessibleName");
			this.pbAspCur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbAspCur.Anchor")));
			this.pbAspCur.AutoScroll = ((bool)(resources.GetObject("pbAspCur.AutoScroll")));
			this.pbAspCur.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbAspCur.AutoScrollMargin")));
			this.pbAspCur.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbAspCur.AutoScrollMinSize")));
			this.pbAspCur.BackColor = System.Drawing.Color.Transparent;
			this.pbAspCur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAspCur.BackgroundImage")));
			this.pbAspCur.DisplayOffset = 0;
			this.pbAspCur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbAspCur.Dock")));
			this.pbAspCur.DockPadding.Bottom = 5;
			this.pbAspCur.Enabled = ((bool)(resources.GetObject("pbAspCur.Enabled")));
			this.pbAspCur.Font = ((System.Drawing.Font)(resources.GetObject("pbAspCur.Font")));
			this.pbAspCur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbAspCur.ImeMode")));
			this.pbAspCur.LabelText = resources.GetString("pbAspCur.LabelText");
			this.pbAspCur.LabelWidth = ((int)(resources.GetObject("pbAspCur.LabelWidth")));
			this.pbAspCur.Location = ((System.Drawing.Point)(resources.GetObject("pbAspCur.Location")));
			this.pbAspCur.Maximum = 1200;
			this.pbAspCur.Name = "pbAspCur";
			this.pbAspCur.NumberFormat = "N0";
			this.pbAspCur.NumberOffset = -600;
			this.pbAspCur.NumberScale = 1;
			this.pbAspCur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbAspCur.RightToLeft")));
			this.pbAspCur.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbAspCur.Size = ((System.Drawing.Size)(resources.GetObject("pbAspCur.Size")));
			this.pbAspCur.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbAspCur.TabIndex = ((int)(resources.GetObject("pbAspCur.TabIndex")));
			this.pbAspCur.TextboxWidth = ((int)(resources.GetObject("pbAspCur.TextboxWidth")));
			this.pbAspCur.TokenCount = 21;
			this.pbAspCur.UnselectedColor = System.Drawing.Color.Black;
			this.pbAspCur.Value = 0;
			this.pbAspCur.Visible = ((bool)(resources.GetObject("pbAspCur.Visible")));
			this.pbAspCur.Changed += new System.EventHandler(this.ChangedCareer);
			// 
			// label46
			// 
			this.label46.AccessibleDescription = resources.GetString("label46.AccessibleDescription");
			this.label46.AccessibleName = resources.GetString("label46.AccessibleName");
			this.label46.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label46.Anchor")));
			this.label46.AutoSize = ((bool)(resources.GetObject("label46.AutoSize")));
			this.label46.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label46.Dock")));
			this.label46.Enabled = ((bool)(resources.GetObject("label46.Enabled")));
			this.label46.Font = ((System.Drawing.Font)(resources.GetObject("label46.Font")));
			this.label46.Image = ((System.Drawing.Image)(resources.GetObject("label46.Image")));
			this.label46.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label46.ImageAlign")));
			this.label46.ImageIndex = ((int)(resources.GetObject("label46.ImageIndex")));
			this.label46.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label46.ImeMode")));
			this.label46.Location = ((System.Drawing.Point)(resources.GetObject("label46.Location")));
			this.label46.Name = "label46";
			this.label46.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label46.RightToLeft")));
			this.label46.Size = ((System.Drawing.Size)(resources.GetObject("label46.Size")));
			this.label46.TabIndex = ((int)(resources.GetObject("label46.TabIndex")));
			this.label46.Text = resources.GetString("label46.Text");
			this.label46.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label46.TextAlign")));
			this.label46.Visible = ((bool)(resources.GetObject("label46.Visible")));
			// 
			// tblifelinescore
			// 
			this.tblifelinescore.AccessibleDescription = resources.GetString("tblifelinescore.AccessibleDescription");
			this.tblifelinescore.AccessibleName = resources.GetString("tblifelinescore.AccessibleName");
			this.tblifelinescore.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblifelinescore.Anchor")));
			this.tblifelinescore.AutoSize = ((bool)(resources.GetObject("tblifelinescore.AutoSize")));
			this.tblifelinescore.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblifelinescore.BackgroundImage")));
			this.tblifelinescore.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tblifelinescore.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblifelinescore.Dock")));
			this.tblifelinescore.Enabled = ((bool)(resources.GetObject("tblifelinescore.Enabled")));
			this.tblifelinescore.Font = ((System.Drawing.Font)(resources.GetObject("tblifelinescore.Font")));
			this.tblifelinescore.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblifelinescore.ImeMode")));
			this.tblifelinescore.Location = ((System.Drawing.Point)(resources.GetObject("tblifelinescore.Location")));
			this.tblifelinescore.MaxLength = ((int)(resources.GetObject("tblifelinescore.MaxLength")));
			this.tblifelinescore.Multiline = ((bool)(resources.GetObject("tblifelinescore.Multiline")));
			this.tblifelinescore.Name = "tblifelinescore";
			this.tblifelinescore.PasswordChar = ((char)(resources.GetObject("tblifelinescore.PasswordChar")));
			this.tblifelinescore.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblifelinescore.RightToLeft")));
			this.tblifelinescore.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblifelinescore.ScrollBars")));
			this.tblifelinescore.Size = ((System.Drawing.Size)(resources.GetObject("tblifelinescore.Size")));
			this.tblifelinescore.TabIndex = ((int)(resources.GetObject("tblifelinescore.TabIndex")));
			this.tblifelinescore.Text = resources.GetString("tblifelinescore.Text");
			this.tblifelinescore.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblifelinescore.TextAlign")));
			this.tblifelinescore.Visible = ((bool)(resources.GetObject("tblifelinescore.Visible")));
			this.tblifelinescore.WordWrap = ((bool)(resources.GetObject("tblifelinescore.WordWrap")));
			this.tblifelinescore.TextChanged += new System.EventHandler(this.ChangedCareer);
			// 
			// pbCareerPerformance
			// 
			this.pbCareerPerformance.AccessibleDescription = resources.GetString("pbCareerPerformance.AccessibleDescription");
			this.pbCareerPerformance.AccessibleName = resources.GetString("pbCareerPerformance.AccessibleName");
			this.pbCareerPerformance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCareerPerformance.Anchor")));
			this.pbCareerPerformance.AutoScroll = ((bool)(resources.GetObject("pbCareerPerformance.AutoScroll")));
			this.pbCareerPerformance.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCareerPerformance.AutoScrollMargin")));
			this.pbCareerPerformance.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCareerPerformance.AutoScrollMinSize")));
			this.pbCareerPerformance.BackColor = System.Drawing.Color.Transparent;
			this.pbCareerPerformance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCareerPerformance.BackgroundImage")));
			this.pbCareerPerformance.DisplayOffset = 0;
			this.pbCareerPerformance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCareerPerformance.Dock")));
			this.pbCareerPerformance.DockPadding.Bottom = 5;
			this.pbCareerPerformance.Enabled = ((bool)(resources.GetObject("pbCareerPerformance.Enabled")));
			this.pbCareerPerformance.Font = ((System.Drawing.Font)(resources.GetObject("pbCareerPerformance.Font")));
			this.pbCareerPerformance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCareerPerformance.ImeMode")));
			this.pbCareerPerformance.LabelText = resources.GetString("pbCareerPerformance.LabelText");
			this.pbCareerPerformance.LabelWidth = ((int)(resources.GetObject("pbCareerPerformance.LabelWidth")));
			this.pbCareerPerformance.Location = ((System.Drawing.Point)(resources.GetObject("pbCareerPerformance.Location")));
			this.pbCareerPerformance.Maximum = 1000;
			this.pbCareerPerformance.Name = "pbCareerPerformance";
			this.pbCareerPerformance.NumberFormat = "N0";
			this.pbCareerPerformance.NumberOffset = 0;
			this.pbCareerPerformance.NumberScale = 1;
			this.pbCareerPerformance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCareerPerformance.RightToLeft")));
			this.pbCareerPerformance.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbCareerPerformance.Size = ((System.Drawing.Size)(resources.GetObject("pbCareerPerformance.Size")));
			this.pbCareerPerformance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCareerPerformance.TabIndex = ((int)(resources.GetObject("pbCareerPerformance.TabIndex")));
			this.pbCareerPerformance.TextboxWidth = ((int)(resources.GetObject("pbCareerPerformance.TextboxWidth")));
			this.pbCareerPerformance.TokenCount = 21;
			this.pbCareerPerformance.UnselectedColor = System.Drawing.Color.Black;
			this.pbCareerPerformance.Value = 10;
			this.pbCareerPerformance.Visible = ((bool)(resources.GetObject("pbCareerPerformance.Visible")));
			this.pbCareerPerformance.Changed += new System.EventHandler(this.ChangedCareer);
			// 
			// pbCareerLevel
			// 
			this.pbCareerLevel.AccessibleDescription = resources.GetString("pbCareerLevel.AccessibleDescription");
			this.pbCareerLevel.AccessibleName = resources.GetString("pbCareerLevel.AccessibleName");
			this.pbCareerLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCareerLevel.Anchor")));
			this.pbCareerLevel.AutoScroll = ((bool)(resources.GetObject("pbCareerLevel.AutoScroll")));
			this.pbCareerLevel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCareerLevel.AutoScrollMargin")));
			this.pbCareerLevel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCareerLevel.AutoScrollMinSize")));
			this.pbCareerLevel.BackColor = System.Drawing.Color.Transparent;
			this.pbCareerLevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCareerLevel.BackgroundImage")));
			this.pbCareerLevel.DisplayOffset = 0;
			this.pbCareerLevel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCareerLevel.Dock")));
			this.pbCareerLevel.DockPadding.Bottom = 5;
			this.pbCareerLevel.Enabled = ((bool)(resources.GetObject("pbCareerLevel.Enabled")));
			this.pbCareerLevel.Font = ((System.Drawing.Font)(resources.GetObject("pbCareerLevel.Font")));
			this.pbCareerLevel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCareerLevel.ImeMode")));
			this.pbCareerLevel.LabelText = resources.GetString("pbCareerLevel.LabelText");
			this.pbCareerLevel.LabelWidth = ((int)(resources.GetObject("pbCareerLevel.LabelWidth")));
			this.pbCareerLevel.Location = ((System.Drawing.Point)(resources.GetObject("pbCareerLevel.Location")));
			this.pbCareerLevel.Maximum = 10;
			this.pbCareerLevel.Name = "pbCareerLevel";
			this.pbCareerLevel.NumberFormat = "N0";
			this.pbCareerLevel.NumberOffset = 0;
			this.pbCareerLevel.NumberScale = 1;
			this.pbCareerLevel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCareerLevel.RightToLeft")));
			this.pbCareerLevel.SelectedColor = System.Drawing.Color.YellowGreen;
			this.pbCareerLevel.Size = ((System.Drawing.Size)(resources.GetObject("pbCareerLevel.Size")));
			this.pbCareerLevel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCareerLevel.TabIndex = ((int)(resources.GetObject("pbCareerLevel.TabIndex")));
			this.pbCareerLevel.TextboxWidth = ((int)(resources.GetObject("pbCareerLevel.TextboxWidth")));
			this.pbCareerLevel.TokenCount = 10;
			this.pbCareerLevel.UnselectedColor = System.Drawing.Color.Black;
			this.pbCareerLevel.Value = 10;
			this.pbCareerLevel.Visible = ((bool)(resources.GetObject("pbCareerLevel.Visible")));
			this.pbCareerLevel.Changed += new System.EventHandler(this.ChangedCareer);
			// 
			// label78
			// 
			this.label78.AccessibleDescription = resources.GetString("label78.AccessibleDescription");
			this.label78.AccessibleName = resources.GetString("label78.AccessibleName");
			this.label78.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label78.Anchor")));
			this.label78.AutoSize = ((bool)(resources.GetObject("label78.AutoSize")));
			this.label78.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label78.Dock")));
			this.label78.Enabled = ((bool)(resources.GetObject("label78.Enabled")));
			this.label78.Font = ((System.Drawing.Font)(resources.GetObject("label78.Font")));
			this.label78.Image = ((System.Drawing.Image)(resources.GetObject("label78.Image")));
			this.label78.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label78.ImageAlign")));
			this.label78.ImageIndex = ((int)(resources.GetObject("label78.ImageIndex")));
			this.label78.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label78.ImeMode")));
			this.label78.Location = ((System.Drawing.Point)(resources.GetObject("label78.Location")));
			this.label78.Name = "label78";
			this.label78.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label78.RightToLeft")));
			this.label78.Size = ((System.Drawing.Size)(resources.GetObject("label78.Size")));
			this.label78.TabIndex = ((int)(resources.GetObject("label78.TabIndex")));
			this.label78.Text = resources.GetString("label78.Text");
			this.label78.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label78.TextAlign")));
			this.label78.Visible = ((bool)(resources.GetObject("label78.Visible")));
			// 
			// tbschooltype
			// 
			this.tbschooltype.AccessibleDescription = resources.GetString("tbschooltype.AccessibleDescription");
			this.tbschooltype.AccessibleName = resources.GetString("tbschooltype.AccessibleName");
			this.tbschooltype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbschooltype.Anchor")));
			this.tbschooltype.AutoSize = ((bool)(resources.GetObject("tbschooltype.AutoSize")));
			this.tbschooltype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbschooltype.BackgroundImage")));
			this.tbschooltype.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbschooltype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbschooltype.Dock")));
			this.tbschooltype.Enabled = ((bool)(resources.GetObject("tbschooltype.Enabled")));
			this.tbschooltype.Font = ((System.Drawing.Font)(resources.GetObject("tbschooltype.Font")));
			this.tbschooltype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbschooltype.ImeMode")));
			this.tbschooltype.Location = ((System.Drawing.Point)(resources.GetObject("tbschooltype.Location")));
			this.tbschooltype.MaxLength = ((int)(resources.GetObject("tbschooltype.MaxLength")));
			this.tbschooltype.Multiline = ((bool)(resources.GetObject("tbschooltype.Multiline")));
			this.tbschooltype.Name = "tbschooltype";
			this.tbschooltype.PasswordChar = ((char)(resources.GetObject("tbschooltype.PasswordChar")));
			this.tbschooltype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbschooltype.RightToLeft")));
			this.tbschooltype.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbschooltype.ScrollBars")));
			this.tbschooltype.Size = ((System.Drawing.Size)(resources.GetObject("tbschooltype.Size")));
			this.tbschooltype.TabIndex = ((int)(resources.GetObject("tbschooltype.TabIndex")));
			this.tbschooltype.Text = resources.GetString("tbschooltype.Text");
			this.tbschooltype.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbschooltype.TextAlign")));
			this.tbschooltype.Visible = ((bool)(resources.GetObject("tbschooltype.Visible")));
			this.tbschooltype.WordWrap = ((bool)(resources.GetObject("tbschooltype.WordWrap")));
			this.tbschooltype.TextChanged += new System.EventHandler(this.ChangedCareer);
			// 
			// label77
			// 
			this.label77.AccessibleDescription = resources.GetString("label77.AccessibleDescription");
			this.label77.AccessibleName = resources.GetString("label77.AccessibleName");
			this.label77.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label77.Anchor")));
			this.label77.AutoSize = ((bool)(resources.GetObject("label77.AutoSize")));
			this.label77.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label77.Dock")));
			this.label77.Enabled = ((bool)(resources.GetObject("label77.Enabled")));
			this.label77.Font = ((System.Drawing.Font)(resources.GetObject("label77.Font")));
			this.label77.Image = ((System.Drawing.Image)(resources.GetObject("label77.Image")));
			this.label77.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label77.ImageAlign")));
			this.label77.ImageIndex = ((int)(resources.GetObject("label77.ImageIndex")));
			this.label77.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label77.ImeMode")));
			this.label77.Location = ((System.Drawing.Point)(resources.GetObject("label77.Location")));
			this.label77.Name = "label77";
			this.label77.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label77.RightToLeft")));
			this.label77.Size = ((System.Drawing.Size)(resources.GetObject("label77.Size")));
			this.label77.TabIndex = ((int)(resources.GetObject("label77.TabIndex")));
			this.label77.Text = resources.GetString("label77.Text");
			this.label77.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label77.TextAlign")));
			this.label77.Visible = ((bool)(resources.GetObject("label77.Visible")));
			// 
			// cbgrade
			// 
			this.cbgrade.AccessibleDescription = resources.GetString("cbgrade.AccessibleDescription");
			this.cbgrade.AccessibleName = resources.GetString("cbgrade.AccessibleName");
			this.cbgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbgrade.Anchor")));
			this.cbgrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbgrade.BackgroundImage")));
			this.cbgrade.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbgrade.Dock")));
			this.cbgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbgrade.Enabled = ((bool)(resources.GetObject("cbgrade.Enabled")));
			this.cbgrade.Font = ((System.Drawing.Font)(resources.GetObject("cbgrade.Font")));
			this.cbgrade.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbgrade.ImeMode")));
			this.cbgrade.IntegralHeight = ((bool)(resources.GetObject("cbgrade.IntegralHeight")));
			this.cbgrade.ItemHeight = ((int)(resources.GetObject("cbgrade.ItemHeight")));
			this.cbgrade.Location = ((System.Drawing.Point)(resources.GetObject("cbgrade.Location")));
			this.cbgrade.MaxDropDownItems = ((int)(resources.GetObject("cbgrade.MaxDropDownItems")));
			this.cbgrade.MaxLength = ((int)(resources.GetObject("cbgrade.MaxLength")));
			this.cbgrade.Name = "cbgrade";
			this.cbgrade.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbgrade.RightToLeft")));
			this.cbgrade.Size = ((System.Drawing.Size)(resources.GetObject("cbgrade.Size")));
			this.cbgrade.TabIndex = ((int)(resources.GetObject("cbgrade.TabIndex")));
			this.cbgrade.Text = resources.GetString("cbgrade.Text");
			this.cbgrade.Visible = ((bool)(resources.GetObject("cbgrade.Visible")));
			this.cbgrade.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
			// 
			// cbschooltype
			// 
			this.cbschooltype.AccessibleDescription = resources.GetString("cbschooltype.AccessibleDescription");
			this.cbschooltype.AccessibleName = resources.GetString("cbschooltype.AccessibleName");
			this.cbschooltype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbschooltype.Anchor")));
			this.cbschooltype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbschooltype.BackgroundImage")));
			this.cbschooltype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbschooltype.Dock")));
			this.cbschooltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbschooltype.Enabled = ((bool)(resources.GetObject("cbschooltype.Enabled")));
			this.cbschooltype.Font = ((System.Drawing.Font)(resources.GetObject("cbschooltype.Font")));
			this.cbschooltype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbschooltype.ImeMode")));
			this.cbschooltype.IntegralHeight = ((bool)(resources.GetObject("cbschooltype.IntegralHeight")));
			this.cbschooltype.ItemHeight = ((int)(resources.GetObject("cbschooltype.ItemHeight")));
			this.cbschooltype.Location = ((System.Drawing.Point)(resources.GetObject("cbschooltype.Location")));
			this.cbschooltype.MaxDropDownItems = ((int)(resources.GetObject("cbschooltype.MaxDropDownItems")));
			this.cbschooltype.MaxLength = ((int)(resources.GetObject("cbschooltype.MaxLength")));
			this.cbschooltype.Name = "cbschooltype";
			this.cbschooltype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbschooltype.RightToLeft")));
			this.cbschooltype.Size = ((System.Drawing.Size)(resources.GetObject("cbschooltype.Size")));
			this.cbschooltype.TabIndex = ((int)(resources.GetObject("cbschooltype.TabIndex")));
			this.cbschooltype.Text = resources.GetString("cbschooltype.Text");
			this.cbschooltype.Visible = ((bool)(resources.GetObject("cbschooltype.Visible")));
			this.cbschooltype.SelectedIndexChanged += new System.EventHandler(this.cbschooltype_SelectedIndexChanged);
			// 
			// label50
			// 
			this.label50.AccessibleDescription = resources.GetString("label50.AccessibleDescription");
			this.label50.AccessibleName = resources.GetString("label50.AccessibleName");
			this.label50.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label50.Anchor")));
			this.label50.AutoSize = ((bool)(resources.GetObject("label50.AutoSize")));
			this.label50.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label50.Dock")));
			this.label50.Enabled = ((bool)(resources.GetObject("label50.Enabled")));
			this.label50.Font = ((System.Drawing.Font)(resources.GetObject("label50.Font")));
			this.label50.Image = ((System.Drawing.Image)(resources.GetObject("label50.Image")));
			this.label50.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label50.ImageAlign")));
			this.label50.ImageIndex = ((int)(resources.GetObject("label50.ImageIndex")));
			this.label50.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label50.ImeMode")));
			this.label50.Location = ((System.Drawing.Point)(resources.GetObject("label50.Location")));
			this.label50.Name = "label50";
			this.label50.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label50.RightToLeft")));
			this.label50.Size = ((System.Drawing.Size)(resources.GetObject("label50.Size")));
			this.label50.TabIndex = ((int)(resources.GetObject("label50.TabIndex")));
			this.label50.Text = resources.GetString("label50.Text");
			this.label50.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label50.TextAlign")));
			this.label50.Visible = ((bool)(resources.GetObject("label50.Visible")));
			// 
			// cbcareer
			// 
			this.cbcareer.AccessibleDescription = resources.GetString("cbcareer.AccessibleDescription");
			this.cbcareer.AccessibleName = resources.GetString("cbcareer.AccessibleName");
			this.cbcareer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcareer.Anchor")));
			this.cbcareer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcareer.BackgroundImage")));
			this.cbcareer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcareer.Dock")));
			this.cbcareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbcareer.Enabled = ((bool)(resources.GetObject("cbcareer.Enabled")));
			this.cbcareer.Font = ((System.Drawing.Font)(resources.GetObject("cbcareer.Font")));
			this.cbcareer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcareer.ImeMode")));
			this.cbcareer.IntegralHeight = ((bool)(resources.GetObject("cbcareer.IntegralHeight")));
			this.cbcareer.ItemHeight = ((int)(resources.GetObject("cbcareer.ItemHeight")));
			this.cbcareer.Location = ((System.Drawing.Point)(resources.GetObject("cbcareer.Location")));
			this.cbcareer.MaxDropDownItems = ((int)(resources.GetObject("cbcareer.MaxDropDownItems")));
			this.cbcareer.MaxLength = ((int)(resources.GetObject("cbcareer.MaxLength")));
			this.cbcareer.Name = "cbcareer";
			this.cbcareer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcareer.RightToLeft")));
			this.cbcareer.Size = ((System.Drawing.Size)(resources.GetObject("cbcareer.Size")));
			this.cbcareer.TabIndex = ((int)(resources.GetObject("cbcareer.TabIndex")));
			this.cbcareer.Text = resources.GetString("cbcareer.Text");
			this.cbcareer.Visible = ((bool)(resources.GetObject("cbcareer.Visible")));
			this.cbcareer.SelectedIndexChanged += new System.EventHandler(this.cbcareer_SelectedIndexChanged);
			// 
			// tbcareervalue
			// 
			this.tbcareervalue.AccessibleDescription = resources.GetString("tbcareervalue.AccessibleDescription");
			this.tbcareervalue.AccessibleName = resources.GetString("tbcareervalue.AccessibleName");
			this.tbcareervalue.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcareervalue.Anchor")));
			this.tbcareervalue.AutoSize = ((bool)(resources.GetObject("tbcareervalue.AutoSize")));
			this.tbcareervalue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcareervalue.BackgroundImage")));
			this.tbcareervalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcareervalue.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcareervalue.Dock")));
			this.tbcareervalue.Enabled = ((bool)(resources.GetObject("tbcareervalue.Enabled")));
			this.tbcareervalue.Font = ((System.Drawing.Font)(resources.GetObject("tbcareervalue.Font")));
			this.tbcareervalue.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcareervalue.ImeMode")));
			this.tbcareervalue.Location = ((System.Drawing.Point)(resources.GetObject("tbcareervalue.Location")));
			this.tbcareervalue.MaxLength = ((int)(resources.GetObject("tbcareervalue.MaxLength")));
			this.tbcareervalue.Multiline = ((bool)(resources.GetObject("tbcareervalue.Multiline")));
			this.tbcareervalue.Name = "tbcareervalue";
			this.tbcareervalue.PasswordChar = ((char)(resources.GetObject("tbcareervalue.PasswordChar")));
			this.tbcareervalue.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcareervalue.RightToLeft")));
			this.tbcareervalue.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcareervalue.ScrollBars")));
			this.tbcareervalue.Size = ((System.Drawing.Size)(resources.GetObject("tbcareervalue.Size")));
			this.tbcareervalue.TabIndex = ((int)(resources.GetObject("tbcareervalue.TabIndex")));
			this.tbcareervalue.Text = resources.GetString("tbcareervalue.Text");
			this.tbcareervalue.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcareervalue.TextAlign")));
			this.tbcareervalue.Visible = ((bool)(resources.GetObject("tbcareervalue.Visible")));
			this.tbcareervalue.WordWrap = ((bool)(resources.GetObject("tbcareervalue.WordWrap")));
			this.tbcareervalue.TextChanged += new System.EventHandler(this.ChangedCareer);
			// 
			// pnInt
			// 
			this.pnInt.AccessibleDescription = resources.GetString("pnInt.AccessibleDescription");
			this.pnInt.AccessibleName = resources.GetString("pnInt.AccessibleName");
			this.pnInt.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnInt.Anchor")));
			this.pnInt.AutoScroll = ((bool)(resources.GetObject("pnInt.AutoScroll")));
			this.pnInt.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnInt.AutoScrollMargin")));
			this.pnInt.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnInt.AutoScrollMinSize")));
			this.pnInt.BackColor = System.Drawing.Color.Transparent;
			this.pnInt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnInt.BackgroundImage")));
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
			this.pnInt.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnInt.Dock")));
			this.pnInt.Enabled = ((bool)(resources.GetObject("pnInt.Enabled")));
			this.pnInt.Font = ((System.Drawing.Font)(resources.GetObject("pnInt.Font")));
			this.pnInt.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnInt.ImeMode")));
			this.pnInt.Location = ((System.Drawing.Point)(resources.GetObject("pnInt.Location")));
			this.pnInt.Name = "pnInt";
			this.pnInt.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnInt.RightToLeft")));
			this.pnInt.Size = ((System.Drawing.Size)(resources.GetObject("pnInt.Size")));
			this.pnInt.TabIndex = ((int)(resources.GetObject("pnInt.TabIndex")));
			this.pnInt.Text = resources.GetString("pnInt.Text");
			this.pnInt.Visible = ((bool)(resources.GetObject("pnInt.Visible")));
			// 
			// pbSciFi
			// 
			this.pbSciFi.AccessibleDescription = resources.GetString("pbSciFi.AccessibleDescription");
			this.pbSciFi.AccessibleName = resources.GetString("pbSciFi.AccessibleName");
			this.pbSciFi.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbSciFi.Anchor")));
			this.pbSciFi.AutoScroll = ((bool)(resources.GetObject("pbSciFi.AutoScroll")));
			this.pbSciFi.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbSciFi.AutoScrollMargin")));
			this.pbSciFi.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbSciFi.AutoScrollMinSize")));
			this.pbSciFi.BackColor = System.Drawing.Color.Transparent;
			this.pbSciFi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSciFi.BackgroundImage")));
			this.pbSciFi.DisplayOffset = 0;
			this.pbSciFi.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbSciFi.Dock")));
			this.pbSciFi.DockPadding.Bottom = 5;
			this.pbSciFi.Enabled = ((bool)(resources.GetObject("pbSciFi.Enabled")));
			this.pbSciFi.Font = ((System.Drawing.Font)(resources.GetObject("pbSciFi.Font")));
			this.pbSciFi.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbSciFi.ImeMode")));
			this.pbSciFi.LabelText = resources.GetString("pbSciFi.LabelText");
			this.pbSciFi.LabelWidth = ((int)(resources.GetObject("pbSciFi.LabelWidth")));
			this.pbSciFi.Location = ((System.Drawing.Point)(resources.GetObject("pbSciFi.Location")));
			this.pbSciFi.Maximum = 1000;
			this.pbSciFi.Name = "pbSciFi";
			this.pbSciFi.NumberFormat = "N1";
			this.pbSciFi.NumberOffset = 0;
			this.pbSciFi.NumberScale = 0.01;
			this.pbSciFi.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbSciFi.RightToLeft")));
			this.pbSciFi.SelectedColor = System.Drawing.Color.Lime;
			this.pbSciFi.Size = ((System.Drawing.Size)(resources.GetObject("pbSciFi.Size")));
			this.pbSciFi.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSciFi.TabIndex = ((int)(resources.GetObject("pbSciFi.TabIndex")));
			this.pbSciFi.TextboxWidth = ((int)(resources.GetObject("pbSciFi.TextboxWidth")));
			this.pbSciFi.TokenCount = 10;
			this.pbSciFi.UnselectedColor = System.Drawing.Color.Black;
			this.pbSciFi.Value = 500;
			this.pbSciFi.Visible = ((bool)(resources.GetObject("pbSciFi.Visible")));
			this.pbSciFi.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbToys
			// 
			this.pbToys.AccessibleDescription = resources.GetString("pbToys.AccessibleDescription");
			this.pbToys.AccessibleName = resources.GetString("pbToys.AccessibleName");
			this.pbToys.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbToys.Anchor")));
			this.pbToys.AutoScroll = ((bool)(resources.GetObject("pbToys.AutoScroll")));
			this.pbToys.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbToys.AutoScrollMargin")));
			this.pbToys.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbToys.AutoScrollMinSize")));
			this.pbToys.BackColor = System.Drawing.Color.Transparent;
			this.pbToys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbToys.BackgroundImage")));
			this.pbToys.DisplayOffset = 0;
			this.pbToys.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbToys.Dock")));
			this.pbToys.DockPadding.Bottom = 5;
			this.pbToys.Enabled = ((bool)(resources.GetObject("pbToys.Enabled")));
			this.pbToys.Font = ((System.Drawing.Font)(resources.GetObject("pbToys.Font")));
			this.pbToys.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbToys.ImeMode")));
			this.pbToys.LabelText = resources.GetString("pbToys.LabelText");
			this.pbToys.LabelWidth = ((int)(resources.GetObject("pbToys.LabelWidth")));
			this.pbToys.Location = ((System.Drawing.Point)(resources.GetObject("pbToys.Location")));
			this.pbToys.Maximum = 1000;
			this.pbToys.Name = "pbToys";
			this.pbToys.NumberFormat = "N1";
			this.pbToys.NumberOffset = 0;
			this.pbToys.NumberScale = 0.01;
			this.pbToys.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbToys.RightToLeft")));
			this.pbToys.SelectedColor = System.Drawing.Color.Lime;
			this.pbToys.Size = ((System.Drawing.Size)(resources.GetObject("pbToys.Size")));
			this.pbToys.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbToys.TabIndex = ((int)(resources.GetObject("pbToys.TabIndex")));
			this.pbToys.TextboxWidth = ((int)(resources.GetObject("pbToys.TextboxWidth")));
			this.pbToys.TokenCount = 10;
			this.pbToys.UnselectedColor = System.Drawing.Color.Black;
			this.pbToys.Value = 500;
			this.pbToys.Visible = ((bool)(resources.GetObject("pbToys.Visible")));
			this.pbToys.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbSchool
			// 
			this.pbSchool.AccessibleDescription = resources.GetString("pbSchool.AccessibleDescription");
			this.pbSchool.AccessibleName = resources.GetString("pbSchool.AccessibleName");
			this.pbSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbSchool.Anchor")));
			this.pbSchool.AutoScroll = ((bool)(resources.GetObject("pbSchool.AutoScroll")));
			this.pbSchool.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbSchool.AutoScrollMargin")));
			this.pbSchool.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbSchool.AutoScrollMinSize")));
			this.pbSchool.BackColor = System.Drawing.Color.Transparent;
			this.pbSchool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSchool.BackgroundImage")));
			this.pbSchool.DisplayOffset = 0;
			this.pbSchool.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbSchool.Dock")));
			this.pbSchool.DockPadding.Bottom = 5;
			this.pbSchool.Enabled = ((bool)(resources.GetObject("pbSchool.Enabled")));
			this.pbSchool.Font = ((System.Drawing.Font)(resources.GetObject("pbSchool.Font")));
			this.pbSchool.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbSchool.ImeMode")));
			this.pbSchool.LabelText = resources.GetString("pbSchool.LabelText");
			this.pbSchool.LabelWidth = ((int)(resources.GetObject("pbSchool.LabelWidth")));
			this.pbSchool.Location = ((System.Drawing.Point)(resources.GetObject("pbSchool.Location")));
			this.pbSchool.Maximum = 1000;
			this.pbSchool.Name = "pbSchool";
			this.pbSchool.NumberFormat = "N1";
			this.pbSchool.NumberOffset = 0;
			this.pbSchool.NumberScale = 0.01;
			this.pbSchool.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbSchool.RightToLeft")));
			this.pbSchool.SelectedColor = System.Drawing.Color.Lime;
			this.pbSchool.Size = ((System.Drawing.Size)(resources.GetObject("pbSchool.Size")));
			this.pbSchool.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSchool.TabIndex = ((int)(resources.GetObject("pbSchool.TabIndex")));
			this.pbSchool.TextboxWidth = ((int)(resources.GetObject("pbSchool.TextboxWidth")));
			this.pbSchool.TokenCount = 10;
			this.pbSchool.UnselectedColor = System.Drawing.Color.Black;
			this.pbSchool.Value = 500;
			this.pbSchool.Visible = ((bool)(resources.GetObject("pbSchool.Visible")));
			this.pbSchool.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbAnimals
			// 
			this.pbAnimals.AccessibleDescription = resources.GetString("pbAnimals.AccessibleDescription");
			this.pbAnimals.AccessibleName = resources.GetString("pbAnimals.AccessibleName");
			this.pbAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbAnimals.Anchor")));
			this.pbAnimals.AutoScroll = ((bool)(resources.GetObject("pbAnimals.AutoScroll")));
			this.pbAnimals.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbAnimals.AutoScrollMargin")));
			this.pbAnimals.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbAnimals.AutoScrollMinSize")));
			this.pbAnimals.BackColor = System.Drawing.Color.Transparent;
			this.pbAnimals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbAnimals.BackgroundImage")));
			this.pbAnimals.DisplayOffset = 0;
			this.pbAnimals.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbAnimals.Dock")));
			this.pbAnimals.DockPadding.Bottom = 5;
			this.pbAnimals.Enabled = ((bool)(resources.GetObject("pbAnimals.Enabled")));
			this.pbAnimals.Font = ((System.Drawing.Font)(resources.GetObject("pbAnimals.Font")));
			this.pbAnimals.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbAnimals.ImeMode")));
			this.pbAnimals.LabelText = resources.GetString("pbAnimals.LabelText");
			this.pbAnimals.LabelWidth = ((int)(resources.GetObject("pbAnimals.LabelWidth")));
			this.pbAnimals.Location = ((System.Drawing.Point)(resources.GetObject("pbAnimals.Location")));
			this.pbAnimals.Maximum = 1000;
			this.pbAnimals.Name = "pbAnimals";
			this.pbAnimals.NumberFormat = "N1";
			this.pbAnimals.NumberOffset = 0;
			this.pbAnimals.NumberScale = 0.01;
			this.pbAnimals.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbAnimals.RightToLeft")));
			this.pbAnimals.SelectedColor = System.Drawing.Color.Lime;
			this.pbAnimals.Size = ((System.Drawing.Size)(resources.GetObject("pbAnimals.Size")));
			this.pbAnimals.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbAnimals.TabIndex = ((int)(resources.GetObject("pbAnimals.TabIndex")));
			this.pbAnimals.TextboxWidth = ((int)(resources.GetObject("pbAnimals.TextboxWidth")));
			this.pbAnimals.TokenCount = 10;
			this.pbAnimals.UnselectedColor = System.Drawing.Color.Black;
			this.pbAnimals.Value = 500;
			this.pbAnimals.Visible = ((bool)(resources.GetObject("pbAnimals.Visible")));
			this.pbAnimals.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbWeather
			// 
			this.pbWeather.AccessibleDescription = resources.GetString("pbWeather.AccessibleDescription");
			this.pbWeather.AccessibleName = resources.GetString("pbWeather.AccessibleName");
			this.pbWeather.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbWeather.Anchor")));
			this.pbWeather.AutoScroll = ((bool)(resources.GetObject("pbWeather.AutoScroll")));
			this.pbWeather.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbWeather.AutoScrollMargin")));
			this.pbWeather.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbWeather.AutoScrollMinSize")));
			this.pbWeather.BackColor = System.Drawing.Color.Transparent;
			this.pbWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWeather.BackgroundImage")));
			this.pbWeather.DisplayOffset = 0;
			this.pbWeather.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbWeather.Dock")));
			this.pbWeather.DockPadding.Bottom = 5;
			this.pbWeather.Enabled = ((bool)(resources.GetObject("pbWeather.Enabled")));
			this.pbWeather.Font = ((System.Drawing.Font)(resources.GetObject("pbWeather.Font")));
			this.pbWeather.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbWeather.ImeMode")));
			this.pbWeather.LabelText = resources.GetString("pbWeather.LabelText");
			this.pbWeather.LabelWidth = ((int)(resources.GetObject("pbWeather.LabelWidth")));
			this.pbWeather.Location = ((System.Drawing.Point)(resources.GetObject("pbWeather.Location")));
			this.pbWeather.Maximum = 1000;
			this.pbWeather.Name = "pbWeather";
			this.pbWeather.NumberFormat = "N1";
			this.pbWeather.NumberOffset = 0;
			this.pbWeather.NumberScale = 0.01;
			this.pbWeather.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbWeather.RightToLeft")));
			this.pbWeather.SelectedColor = System.Drawing.Color.Lime;
			this.pbWeather.Size = ((System.Drawing.Size)(resources.GetObject("pbWeather.Size")));
			this.pbWeather.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbWeather.TabIndex = ((int)(resources.GetObject("pbWeather.TabIndex")));
			this.pbWeather.TextboxWidth = ((int)(resources.GetObject("pbWeather.TextboxWidth")));
			this.pbWeather.TokenCount = 10;
			this.pbWeather.UnselectedColor = System.Drawing.Color.Black;
			this.pbWeather.Value = 500;
			this.pbWeather.Visible = ((bool)(resources.GetObject("pbWeather.Visible")));
			this.pbWeather.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbWork
			// 
			this.pbWork.AccessibleDescription = resources.GetString("pbWork.AccessibleDescription");
			this.pbWork.AccessibleName = resources.GetString("pbWork.AccessibleName");
			this.pbWork.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbWork.Anchor")));
			this.pbWork.AutoScroll = ((bool)(resources.GetObject("pbWork.AutoScroll")));
			this.pbWork.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbWork.AutoScrollMargin")));
			this.pbWork.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbWork.AutoScrollMinSize")));
			this.pbWork.BackColor = System.Drawing.Color.Transparent;
			this.pbWork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWork.BackgroundImage")));
			this.pbWork.DisplayOffset = 0;
			this.pbWork.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbWork.Dock")));
			this.pbWork.DockPadding.Bottom = 5;
			this.pbWork.Enabled = ((bool)(resources.GetObject("pbWork.Enabled")));
			this.pbWork.Font = ((System.Drawing.Font)(resources.GetObject("pbWork.Font")));
			this.pbWork.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbWork.ImeMode")));
			this.pbWork.LabelText = resources.GetString("pbWork.LabelText");
			this.pbWork.LabelWidth = ((int)(resources.GetObject("pbWork.LabelWidth")));
			this.pbWork.Location = ((System.Drawing.Point)(resources.GetObject("pbWork.Location")));
			this.pbWork.Maximum = 1000;
			this.pbWork.Name = "pbWork";
			this.pbWork.NumberFormat = "N1";
			this.pbWork.NumberOffset = 0;
			this.pbWork.NumberScale = 0.01;
			this.pbWork.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbWork.RightToLeft")));
			this.pbWork.SelectedColor = System.Drawing.Color.Lime;
			this.pbWork.Size = ((System.Drawing.Size)(resources.GetObject("pbWork.Size")));
			this.pbWork.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbWork.TabIndex = ((int)(resources.GetObject("pbWork.TabIndex")));
			this.pbWork.TextboxWidth = ((int)(resources.GetObject("pbWork.TextboxWidth")));
			this.pbWork.TokenCount = 10;
			this.pbWork.UnselectedColor = System.Drawing.Color.Black;
			this.pbWork.Value = 500;
			this.pbWork.Visible = ((bool)(resources.GetObject("pbWork.Visible")));
			this.pbWork.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbTravel
			// 
			this.pbTravel.AccessibleDescription = resources.GetString("pbTravel.AccessibleDescription");
			this.pbTravel.AccessibleName = resources.GetString("pbTravel.AccessibleName");
			this.pbTravel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbTravel.Anchor")));
			this.pbTravel.AutoScroll = ((bool)(resources.GetObject("pbTravel.AutoScroll")));
			this.pbTravel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbTravel.AutoScrollMargin")));
			this.pbTravel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbTravel.AutoScrollMinSize")));
			this.pbTravel.BackColor = System.Drawing.Color.Transparent;
			this.pbTravel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbTravel.BackgroundImage")));
			this.pbTravel.DisplayOffset = 0;
			this.pbTravel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbTravel.Dock")));
			this.pbTravel.DockPadding.Bottom = 5;
			this.pbTravel.Enabled = ((bool)(resources.GetObject("pbTravel.Enabled")));
			this.pbTravel.Font = ((System.Drawing.Font)(resources.GetObject("pbTravel.Font")));
			this.pbTravel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbTravel.ImeMode")));
			this.pbTravel.LabelText = resources.GetString("pbTravel.LabelText");
			this.pbTravel.LabelWidth = ((int)(resources.GetObject("pbTravel.LabelWidth")));
			this.pbTravel.Location = ((System.Drawing.Point)(resources.GetObject("pbTravel.Location")));
			this.pbTravel.Maximum = 1000;
			this.pbTravel.Name = "pbTravel";
			this.pbTravel.NumberFormat = "N1";
			this.pbTravel.NumberOffset = 0;
			this.pbTravel.NumberScale = 0.01;
			this.pbTravel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbTravel.RightToLeft")));
			this.pbTravel.SelectedColor = System.Drawing.Color.Lime;
			this.pbTravel.Size = ((System.Drawing.Size)(resources.GetObject("pbTravel.Size")));
			this.pbTravel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbTravel.TabIndex = ((int)(resources.GetObject("pbTravel.TabIndex")));
			this.pbTravel.TextboxWidth = ((int)(resources.GetObject("pbTravel.TextboxWidth")));
			this.pbTravel.TokenCount = 10;
			this.pbTravel.UnselectedColor = System.Drawing.Color.Black;
			this.pbTravel.Value = 500;
			this.pbTravel.Visible = ((bool)(resources.GetObject("pbTravel.Visible")));
			this.pbTravel.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbCrime
			// 
			this.pbCrime.AccessibleDescription = resources.GetString("pbCrime.AccessibleDescription");
			this.pbCrime.AccessibleName = resources.GetString("pbCrime.AccessibleName");
			this.pbCrime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCrime.Anchor")));
			this.pbCrime.AutoScroll = ((bool)(resources.GetObject("pbCrime.AutoScroll")));
			this.pbCrime.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCrime.AutoScrollMargin")));
			this.pbCrime.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCrime.AutoScrollMinSize")));
			this.pbCrime.BackColor = System.Drawing.Color.Transparent;
			this.pbCrime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCrime.BackgroundImage")));
			this.pbCrime.DisplayOffset = 0;
			this.pbCrime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCrime.Dock")));
			this.pbCrime.DockPadding.Bottom = 5;
			this.pbCrime.Enabled = ((bool)(resources.GetObject("pbCrime.Enabled")));
			this.pbCrime.Font = ((System.Drawing.Font)(resources.GetObject("pbCrime.Font")));
			this.pbCrime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCrime.ImeMode")));
			this.pbCrime.LabelText = resources.GetString("pbCrime.LabelText");
			this.pbCrime.LabelWidth = ((int)(resources.GetObject("pbCrime.LabelWidth")));
			this.pbCrime.Location = ((System.Drawing.Point)(resources.GetObject("pbCrime.Location")));
			this.pbCrime.Maximum = 1000;
			this.pbCrime.Name = "pbCrime";
			this.pbCrime.NumberFormat = "N1";
			this.pbCrime.NumberOffset = 0;
			this.pbCrime.NumberScale = 0.01;
			this.pbCrime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCrime.RightToLeft")));
			this.pbCrime.SelectedColor = System.Drawing.Color.Lime;
			this.pbCrime.Size = ((System.Drawing.Size)(resources.GetObject("pbCrime.Size")));
			this.pbCrime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCrime.TabIndex = ((int)(resources.GetObject("pbCrime.TabIndex")));
			this.pbCrime.TextboxWidth = ((int)(resources.GetObject("pbCrime.TextboxWidth")));
			this.pbCrime.TokenCount = 10;
			this.pbCrime.UnselectedColor = System.Drawing.Color.Black;
			this.pbCrime.Value = 500;
			this.pbCrime.Visible = ((bool)(resources.GetObject("pbCrime.Visible")));
			this.pbCrime.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbSports
			// 
			this.pbSports.AccessibleDescription = resources.GetString("pbSports.AccessibleDescription");
			this.pbSports.AccessibleName = resources.GetString("pbSports.AccessibleName");
			this.pbSports.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbSports.Anchor")));
			this.pbSports.AutoScroll = ((bool)(resources.GetObject("pbSports.AutoScroll")));
			this.pbSports.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbSports.AutoScrollMargin")));
			this.pbSports.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbSports.AutoScrollMinSize")));
			this.pbSports.BackColor = System.Drawing.Color.Transparent;
			this.pbSports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbSports.BackgroundImage")));
			this.pbSports.DisplayOffset = 0;
			this.pbSports.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbSports.Dock")));
			this.pbSports.DockPadding.Bottom = 5;
			this.pbSports.Enabled = ((bool)(resources.GetObject("pbSports.Enabled")));
			this.pbSports.Font = ((System.Drawing.Font)(resources.GetObject("pbSports.Font")));
			this.pbSports.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbSports.ImeMode")));
			this.pbSports.LabelText = resources.GetString("pbSports.LabelText");
			this.pbSports.LabelWidth = ((int)(resources.GetObject("pbSports.LabelWidth")));
			this.pbSports.Location = ((System.Drawing.Point)(resources.GetObject("pbSports.Location")));
			this.pbSports.Maximum = 1000;
			this.pbSports.Name = "pbSports";
			this.pbSports.NumberFormat = "N1";
			this.pbSports.NumberOffset = 0;
			this.pbSports.NumberScale = 0.01;
			this.pbSports.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbSports.RightToLeft")));
			this.pbSports.SelectedColor = System.Drawing.Color.Lime;
			this.pbSports.Size = ((System.Drawing.Size)(resources.GetObject("pbSports.Size")));
			this.pbSports.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbSports.TabIndex = ((int)(resources.GetObject("pbSports.TabIndex")));
			this.pbSports.TextboxWidth = ((int)(resources.GetObject("pbSports.TextboxWidth")));
			this.pbSports.TokenCount = 10;
			this.pbSports.UnselectedColor = System.Drawing.Color.Black;
			this.pbSports.Value = 500;
			this.pbSports.Visible = ((bool)(resources.GetObject("pbSports.Visible")));
			this.pbSports.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbFashion
			// 
			this.pbFashion.AccessibleDescription = resources.GetString("pbFashion.AccessibleDescription");
			this.pbFashion.AccessibleName = resources.GetString("pbFashion.AccessibleName");
			this.pbFashion.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbFashion.Anchor")));
			this.pbFashion.AutoScroll = ((bool)(resources.GetObject("pbFashion.AutoScroll")));
			this.pbFashion.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbFashion.AutoScrollMargin")));
			this.pbFashion.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbFashion.AutoScrollMinSize")));
			this.pbFashion.BackColor = System.Drawing.Color.Transparent;
			this.pbFashion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFashion.BackgroundImage")));
			this.pbFashion.DisplayOffset = 0;
			this.pbFashion.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbFashion.Dock")));
			this.pbFashion.DockPadding.Bottom = 5;
			this.pbFashion.Enabled = ((bool)(resources.GetObject("pbFashion.Enabled")));
			this.pbFashion.Font = ((System.Drawing.Font)(resources.GetObject("pbFashion.Font")));
			this.pbFashion.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbFashion.ImeMode")));
			this.pbFashion.LabelText = resources.GetString("pbFashion.LabelText");
			this.pbFashion.LabelWidth = ((int)(resources.GetObject("pbFashion.LabelWidth")));
			this.pbFashion.Location = ((System.Drawing.Point)(resources.GetObject("pbFashion.Location")));
			this.pbFashion.Maximum = 1000;
			this.pbFashion.Name = "pbFashion";
			this.pbFashion.NumberFormat = "N1";
			this.pbFashion.NumberOffset = 0;
			this.pbFashion.NumberScale = 0.01;
			this.pbFashion.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbFashion.RightToLeft")));
			this.pbFashion.SelectedColor = System.Drawing.Color.Lime;
			this.pbFashion.Size = ((System.Drawing.Size)(resources.GetObject("pbFashion.Size")));
			this.pbFashion.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFashion.TabIndex = ((int)(resources.GetObject("pbFashion.TabIndex")));
			this.pbFashion.TextboxWidth = ((int)(resources.GetObject("pbFashion.TextboxWidth")));
			this.pbFashion.TokenCount = 10;
			this.pbFashion.UnselectedColor = System.Drawing.Color.Black;
			this.pbFashion.Value = 500;
			this.pbFashion.Visible = ((bool)(resources.GetObject("pbFashion.Visible")));
			this.pbFashion.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbHealth
			// 
			this.pbHealth.AccessibleDescription = resources.GetString("pbHealth.AccessibleDescription");
			this.pbHealth.AccessibleName = resources.GetString("pbHealth.AccessibleName");
			this.pbHealth.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbHealth.Anchor")));
			this.pbHealth.AutoScroll = ((bool)(resources.GetObject("pbHealth.AutoScroll")));
			this.pbHealth.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbHealth.AutoScrollMargin")));
			this.pbHealth.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbHealth.AutoScrollMinSize")));
			this.pbHealth.BackColor = System.Drawing.Color.Transparent;
			this.pbHealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbHealth.BackgroundImage")));
			this.pbHealth.DisplayOffset = 0;
			this.pbHealth.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbHealth.Dock")));
			this.pbHealth.DockPadding.Bottom = 5;
			this.pbHealth.Enabled = ((bool)(resources.GetObject("pbHealth.Enabled")));
			this.pbHealth.Font = ((System.Drawing.Font)(resources.GetObject("pbHealth.Font")));
			this.pbHealth.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbHealth.ImeMode")));
			this.pbHealth.LabelText = resources.GetString("pbHealth.LabelText");
			this.pbHealth.LabelWidth = ((int)(resources.GetObject("pbHealth.LabelWidth")));
			this.pbHealth.Location = ((System.Drawing.Point)(resources.GetObject("pbHealth.Location")));
			this.pbHealth.Maximum = 1000;
			this.pbHealth.Name = "pbHealth";
			this.pbHealth.NumberFormat = "N1";
			this.pbHealth.NumberOffset = 0;
			this.pbHealth.NumberScale = 0.01;
			this.pbHealth.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbHealth.RightToLeft")));
			this.pbHealth.SelectedColor = System.Drawing.Color.Lime;
			this.pbHealth.Size = ((System.Drawing.Size)(resources.GetObject("pbHealth.Size")));
			this.pbHealth.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbHealth.TabIndex = ((int)(resources.GetObject("pbHealth.TabIndex")));
			this.pbHealth.TextboxWidth = ((int)(resources.GetObject("pbHealth.TextboxWidth")));
			this.pbHealth.TokenCount = 10;
			this.pbHealth.UnselectedColor = System.Drawing.Color.Black;
			this.pbHealth.Value = 500;
			this.pbHealth.Visible = ((bool)(resources.GetObject("pbHealth.Visible")));
			this.pbHealth.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbFood
			// 
			this.pbFood.AccessibleDescription = resources.GetString("pbFood.AccessibleDescription");
			this.pbFood.AccessibleName = resources.GetString("pbFood.AccessibleName");
			this.pbFood.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbFood.Anchor")));
			this.pbFood.AutoScroll = ((bool)(resources.GetObject("pbFood.AutoScroll")));
			this.pbFood.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbFood.AutoScrollMargin")));
			this.pbFood.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbFood.AutoScrollMinSize")));
			this.pbFood.BackColor = System.Drawing.Color.Transparent;
			this.pbFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbFood.BackgroundImage")));
			this.pbFood.DisplayOffset = 0;
			this.pbFood.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbFood.Dock")));
			this.pbFood.DockPadding.Bottom = 5;
			this.pbFood.Enabled = ((bool)(resources.GetObject("pbFood.Enabled")));
			this.pbFood.Font = ((System.Drawing.Font)(resources.GetObject("pbFood.Font")));
			this.pbFood.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbFood.ImeMode")));
			this.pbFood.LabelText = resources.GetString("pbFood.LabelText");
			this.pbFood.LabelWidth = ((int)(resources.GetObject("pbFood.LabelWidth")));
			this.pbFood.Location = ((System.Drawing.Point)(resources.GetObject("pbFood.Location")));
			this.pbFood.Maximum = 1000;
			this.pbFood.Name = "pbFood";
			this.pbFood.NumberFormat = "N1";
			this.pbFood.NumberOffset = 0;
			this.pbFood.NumberScale = 0.01;
			this.pbFood.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbFood.RightToLeft")));
			this.pbFood.SelectedColor = System.Drawing.Color.Lime;
			this.pbFood.Size = ((System.Drawing.Size)(resources.GetObject("pbFood.Size")));
			this.pbFood.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbFood.TabIndex = ((int)(resources.GetObject("pbFood.TabIndex")));
			this.pbFood.TextboxWidth = ((int)(resources.GetObject("pbFood.TextboxWidth")));
			this.pbFood.TokenCount = 10;
			this.pbFood.UnselectedColor = System.Drawing.Color.Black;
			this.pbFood.Value = 500;
			this.pbFood.Visible = ((bool)(resources.GetObject("pbFood.Visible")));
			this.pbFood.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbPolitics
			// 
			this.pbPolitics.AccessibleDescription = resources.GetString("pbPolitics.AccessibleDescription");
			this.pbPolitics.AccessibleName = resources.GetString("pbPolitics.AccessibleName");
			this.pbPolitics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbPolitics.Anchor")));
			this.pbPolitics.AutoScroll = ((bool)(resources.GetObject("pbPolitics.AutoScroll")));
			this.pbPolitics.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbPolitics.AutoScrollMargin")));
			this.pbPolitics.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbPolitics.AutoScrollMinSize")));
			this.pbPolitics.BackColor = System.Drawing.Color.Transparent;
			this.pbPolitics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbPolitics.BackgroundImage")));
			this.pbPolitics.DisplayOffset = 0;
			this.pbPolitics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbPolitics.Dock")));
			this.pbPolitics.DockPadding.Bottom = 5;
			this.pbPolitics.Enabled = ((bool)(resources.GetObject("pbPolitics.Enabled")));
			this.pbPolitics.Font = ((System.Drawing.Font)(resources.GetObject("pbPolitics.Font")));
			this.pbPolitics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbPolitics.ImeMode")));
			this.pbPolitics.LabelText = resources.GetString("pbPolitics.LabelText");
			this.pbPolitics.LabelWidth = ((int)(resources.GetObject("pbPolitics.LabelWidth")));
			this.pbPolitics.Location = ((System.Drawing.Point)(resources.GetObject("pbPolitics.Location")));
			this.pbPolitics.Maximum = 1000;
			this.pbPolitics.Name = "pbPolitics";
			this.pbPolitics.NumberFormat = "N1";
			this.pbPolitics.NumberOffset = 0;
			this.pbPolitics.NumberScale = 0.01;
			this.pbPolitics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbPolitics.RightToLeft")));
			this.pbPolitics.SelectedColor = System.Drawing.Color.Lime;
			this.pbPolitics.Size = ((System.Drawing.Size)(resources.GetObject("pbPolitics.Size")));
			this.pbPolitics.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbPolitics.TabIndex = ((int)(resources.GetObject("pbPolitics.TabIndex")));
			this.pbPolitics.TextboxWidth = ((int)(resources.GetObject("pbPolitics.TextboxWidth")));
			this.pbPolitics.TokenCount = 10;
			this.pbPolitics.UnselectedColor = System.Drawing.Color.Black;
			this.pbPolitics.Value = 500;
			this.pbPolitics.Visible = ((bool)(resources.GetObject("pbPolitics.Visible")));
			this.pbPolitics.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbMoney
			// 
			this.pbMoney.AccessibleDescription = resources.GetString("pbMoney.AccessibleDescription");
			this.pbMoney.AccessibleName = resources.GetString("pbMoney.AccessibleName");
			this.pbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbMoney.Anchor")));
			this.pbMoney.AutoScroll = ((bool)(resources.GetObject("pbMoney.AutoScroll")));
			this.pbMoney.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbMoney.AutoScrollMargin")));
			this.pbMoney.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbMoney.AutoScrollMinSize")));
			this.pbMoney.BackColor = System.Drawing.Color.Transparent;
			this.pbMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMoney.BackgroundImage")));
			this.pbMoney.DisplayOffset = 0;
			this.pbMoney.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbMoney.Dock")));
			this.pbMoney.DockPadding.Bottom = 5;
			this.pbMoney.Enabled = ((bool)(resources.GetObject("pbMoney.Enabled")));
			this.pbMoney.Font = ((System.Drawing.Font)(resources.GetObject("pbMoney.Font")));
			this.pbMoney.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbMoney.ImeMode")));
			this.pbMoney.LabelText = resources.GetString("pbMoney.LabelText");
			this.pbMoney.LabelWidth = ((int)(resources.GetObject("pbMoney.LabelWidth")));
			this.pbMoney.Location = ((System.Drawing.Point)(resources.GetObject("pbMoney.Location")));
			this.pbMoney.Maximum = 1000;
			this.pbMoney.Name = "pbMoney";
			this.pbMoney.NumberFormat = "N1";
			this.pbMoney.NumberOffset = 0;
			this.pbMoney.NumberScale = 0.01;
			this.pbMoney.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbMoney.RightToLeft")));
			this.pbMoney.SelectedColor = System.Drawing.Color.Lime;
			this.pbMoney.Size = ((System.Drawing.Size)(resources.GetObject("pbMoney.Size")));
			this.pbMoney.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbMoney.TabIndex = ((int)(resources.GetObject("pbMoney.TabIndex")));
			this.pbMoney.TextboxWidth = ((int)(resources.GetObject("pbMoney.TextboxWidth")));
			this.pbMoney.TokenCount = 10;
			this.pbMoney.UnselectedColor = System.Drawing.Color.Black;
			this.pbMoney.Value = 500;
			this.pbMoney.Visible = ((bool)(resources.GetObject("pbMoney.Visible")));
			this.pbMoney.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbCulture
			// 
			this.pbCulture.AccessibleDescription = resources.GetString("pbCulture.AccessibleDescription");
			this.pbCulture.AccessibleName = resources.GetString("pbCulture.AccessibleName");
			this.pbCulture.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbCulture.Anchor")));
			this.pbCulture.AutoScroll = ((bool)(resources.GetObject("pbCulture.AutoScroll")));
			this.pbCulture.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbCulture.AutoScrollMargin")));
			this.pbCulture.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbCulture.AutoScrollMinSize")));
			this.pbCulture.BackColor = System.Drawing.Color.Transparent;
			this.pbCulture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbCulture.BackgroundImage")));
			this.pbCulture.DisplayOffset = 0;
			this.pbCulture.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbCulture.Dock")));
			this.pbCulture.DockPadding.Bottom = 5;
			this.pbCulture.Enabled = ((bool)(resources.GetObject("pbCulture.Enabled")));
			this.pbCulture.Font = ((System.Drawing.Font)(resources.GetObject("pbCulture.Font")));
			this.pbCulture.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbCulture.ImeMode")));
			this.pbCulture.LabelText = resources.GetString("pbCulture.LabelText");
			this.pbCulture.LabelWidth = ((int)(resources.GetObject("pbCulture.LabelWidth")));
			this.pbCulture.Location = ((System.Drawing.Point)(resources.GetObject("pbCulture.Location")));
			this.pbCulture.Maximum = 1000;
			this.pbCulture.Name = "pbCulture";
			this.pbCulture.NumberFormat = "N1";
			this.pbCulture.NumberOffset = 0;
			this.pbCulture.NumberScale = 0.01;
			this.pbCulture.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbCulture.RightToLeft")));
			this.pbCulture.SelectedColor = System.Drawing.Color.Lime;
			this.pbCulture.Size = ((System.Drawing.Size)(resources.GetObject("pbCulture.Size")));
			this.pbCulture.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbCulture.TabIndex = ((int)(resources.GetObject("pbCulture.TabIndex")));
			this.pbCulture.TextboxWidth = ((int)(resources.GetObject("pbCulture.TextboxWidth")));
			this.pbCulture.TokenCount = 10;
			this.pbCulture.UnselectedColor = System.Drawing.Color.Black;
			this.pbCulture.Value = 500;
			this.pbCulture.Visible = ((bool)(resources.GetObject("pbCulture.Visible")));
			this.pbCulture.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbEntertainment
			// 
			this.pbEntertainment.AccessibleDescription = resources.GetString("pbEntertainment.AccessibleDescription");
			this.pbEntertainment.AccessibleName = resources.GetString("pbEntertainment.AccessibleName");
			this.pbEntertainment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbEntertainment.Anchor")));
			this.pbEntertainment.AutoScroll = ((bool)(resources.GetObject("pbEntertainment.AutoScroll")));
			this.pbEntertainment.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbEntertainment.AutoScrollMargin")));
			this.pbEntertainment.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbEntertainment.AutoScrollMinSize")));
			this.pbEntertainment.BackColor = System.Drawing.Color.Transparent;
			this.pbEntertainment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEntertainment.BackgroundImage")));
			this.pbEntertainment.DisplayOffset = 0;
			this.pbEntertainment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbEntertainment.Dock")));
			this.pbEntertainment.DockPadding.Bottom = 5;
			this.pbEntertainment.Enabled = ((bool)(resources.GetObject("pbEntertainment.Enabled")));
			this.pbEntertainment.Font = ((System.Drawing.Font)(resources.GetObject("pbEntertainment.Font")));
			this.pbEntertainment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbEntertainment.ImeMode")));
			this.pbEntertainment.LabelText = resources.GetString("pbEntertainment.LabelText");
			this.pbEntertainment.LabelWidth = ((int)(resources.GetObject("pbEntertainment.LabelWidth")));
			this.pbEntertainment.Location = ((System.Drawing.Point)(resources.GetObject("pbEntertainment.Location")));
			this.pbEntertainment.Maximum = 1000;
			this.pbEntertainment.Name = "pbEntertainment";
			this.pbEntertainment.NumberFormat = "N1";
			this.pbEntertainment.NumberOffset = 0;
			this.pbEntertainment.NumberScale = 0.01;
			this.pbEntertainment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbEntertainment.RightToLeft")));
			this.pbEntertainment.SelectedColor = System.Drawing.Color.Lime;
			this.pbEntertainment.Size = ((System.Drawing.Size)(resources.GetObject("pbEntertainment.Size")));
			this.pbEntertainment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEntertainment.TabIndex = ((int)(resources.GetObject("pbEntertainment.TabIndex")));
			this.pbEntertainment.TextboxWidth = ((int)(resources.GetObject("pbEntertainment.TextboxWidth")));
			this.pbEntertainment.TokenCount = 10;
			this.pbEntertainment.UnselectedColor = System.Drawing.Color.Black;
			this.pbEntertainment.Value = 500;
			this.pbEntertainment.Visible = ((bool)(resources.GetObject("pbEntertainment.Visible")));
			this.pbEntertainment.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbParanormal
			// 
			this.pbParanormal.AccessibleDescription = resources.GetString("pbParanormal.AccessibleDescription");
			this.pbParanormal.AccessibleName = resources.GetString("pbParanormal.AccessibleName");
			this.pbParanormal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbParanormal.Anchor")));
			this.pbParanormal.AutoScroll = ((bool)(resources.GetObject("pbParanormal.AutoScroll")));
			this.pbParanormal.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbParanormal.AutoScrollMargin")));
			this.pbParanormal.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbParanormal.AutoScrollMinSize")));
			this.pbParanormal.BackColor = System.Drawing.Color.Transparent;
			this.pbParanormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbParanormal.BackgroundImage")));
			this.pbParanormal.DisplayOffset = 0;
			this.pbParanormal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbParanormal.Dock")));
			this.pbParanormal.DockPadding.Bottom = 5;
			this.pbParanormal.Enabled = ((bool)(resources.GetObject("pbParanormal.Enabled")));
			this.pbParanormal.Font = ((System.Drawing.Font)(resources.GetObject("pbParanormal.Font")));
			this.pbParanormal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbParanormal.ImeMode")));
			this.pbParanormal.LabelText = resources.GetString("pbParanormal.LabelText");
			this.pbParanormal.LabelWidth = ((int)(resources.GetObject("pbParanormal.LabelWidth")));
			this.pbParanormal.Location = ((System.Drawing.Point)(resources.GetObject("pbParanormal.Location")));
			this.pbParanormal.Maximum = 1000;
			this.pbParanormal.Name = "pbParanormal";
			this.pbParanormal.NumberFormat = "N1";
			this.pbParanormal.NumberOffset = 0;
			this.pbParanormal.NumberScale = 0.01;
			this.pbParanormal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbParanormal.RightToLeft")));
			this.pbParanormal.SelectedColor = System.Drawing.Color.Lime;
			this.pbParanormal.Size = ((System.Drawing.Size)(resources.GetObject("pbParanormal.Size")));
			this.pbParanormal.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbParanormal.TabIndex = ((int)(resources.GetObject("pbParanormal.TabIndex")));
			this.pbParanormal.TextboxWidth = ((int)(resources.GetObject("pbParanormal.TextboxWidth")));
			this.pbParanormal.TokenCount = 10;
			this.pbParanormal.UnselectedColor = System.Drawing.Color.Black;
			this.pbParanormal.Value = 500;
			this.pbParanormal.Visible = ((bool)(resources.GetObject("pbParanormal.Visible")));
			this.pbParanormal.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pbEnvironment
			// 
			this.pbEnvironment.AccessibleDescription = resources.GetString("pbEnvironment.AccessibleDescription");
			this.pbEnvironment.AccessibleName = resources.GetString("pbEnvironment.AccessibleName");
			this.pbEnvironment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbEnvironment.Anchor")));
			this.pbEnvironment.AutoScroll = ((bool)(resources.GetObject("pbEnvironment.AutoScroll")));
			this.pbEnvironment.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbEnvironment.AutoScrollMargin")));
			this.pbEnvironment.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbEnvironment.AutoScrollMinSize")));
			this.pbEnvironment.BackColor = System.Drawing.Color.Transparent;
			this.pbEnvironment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEnvironment.BackgroundImage")));
			this.pbEnvironment.DisplayOffset = 0;
			this.pbEnvironment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbEnvironment.Dock")));
			this.pbEnvironment.DockPadding.Bottom = 5;
			this.pbEnvironment.Enabled = ((bool)(resources.GetObject("pbEnvironment.Enabled")));
			this.pbEnvironment.Font = ((System.Drawing.Font)(resources.GetObject("pbEnvironment.Font")));
			this.pbEnvironment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbEnvironment.ImeMode")));
			this.pbEnvironment.LabelText = resources.GetString("pbEnvironment.LabelText");
			this.pbEnvironment.LabelWidth = ((int)(resources.GetObject("pbEnvironment.LabelWidth")));
			this.pbEnvironment.Location = ((System.Drawing.Point)(resources.GetObject("pbEnvironment.Location")));
			this.pbEnvironment.Maximum = 1000;
			this.pbEnvironment.Name = "pbEnvironment";
			this.pbEnvironment.NumberFormat = "N1";
			this.pbEnvironment.NumberOffset = 0;
			this.pbEnvironment.NumberScale = 0.01;
			this.pbEnvironment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbEnvironment.RightToLeft")));
			this.pbEnvironment.SelectedColor = System.Drawing.Color.Lime;
			this.pbEnvironment.Size = ((System.Drawing.Size)(resources.GetObject("pbEnvironment.Size")));
			this.pbEnvironment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEnvironment.TabIndex = ((int)(resources.GetObject("pbEnvironment.TabIndex")));
			this.pbEnvironment.TextboxWidth = ((int)(resources.GetObject("pbEnvironment.TextboxWidth")));
			this.pbEnvironment.TokenCount = 10;
			this.pbEnvironment.UnselectedColor = System.Drawing.Color.Black;
			this.pbEnvironment.Value = 500;
			this.pbEnvironment.Visible = ((bool)(resources.GetObject("pbEnvironment.Visible")));
			this.pbEnvironment.Changed += new System.EventHandler(this.ChangedInt);
			// 
			// pnRel
			// 
			this.pnRel.AccessibleDescription = resources.GetString("pnRel.AccessibleDescription");
			this.pnRel.AccessibleName = resources.GetString("pnRel.AccessibleName");
			this.pnRel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnRel.Anchor")));
			this.pnRel.AutoScroll = ((bool)(resources.GetObject("pnRel.AutoScroll")));
			this.pnRel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnRel.AutoScrollMargin")));
			this.pnRel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnRel.AutoScrollMinSize")));
			this.pnRel.BackColor = System.Drawing.Color.Transparent;
			this.pnRel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnRel.BackgroundImage")));
			this.pnRel.Controls.Add(this.lv);
			this.pnRel.Controls.Add(this.panel3);
			this.pnRel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnRel.Dock")));
			this.pnRel.Enabled = ((bool)(resources.GetObject("pnRel.Enabled")));
			this.pnRel.Font = ((System.Drawing.Font)(resources.GetObject("pnRel.Font")));
			this.pnRel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnRel.ImeMode")));
			this.pnRel.Location = ((System.Drawing.Point)(resources.GetObject("pnRel.Location")));
			this.pnRel.Name = "pnRel";
			this.pnRel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnRel.RightToLeft")));
			this.pnRel.Size = ((System.Drawing.Size)(resources.GetObject("pnRel.Size")));
			this.pnRel.TabIndex = ((int)(resources.GetObject("pnRel.TabIndex")));
			this.pnRel.Text = resources.GetString("pnRel.Text");
			this.pnRel.Visible = ((bool)(resources.GetObject("pnRel.Visible")));
			this.pnRel.VisibleChanged += new System.EventHandler(this.pnRel_VisibleChanged);
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.srcTb);
			this.panel3.Controls.Add(this.dstTb);
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			// 
			// srcTb
			// 
			this.srcTb.AccessibleDescription = resources.GetString("srcTb.AccessibleDescription");
			this.srcTb.AccessibleName = resources.GetString("srcTb.AccessibleName");
			this.srcTb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("srcTb.Anchor")));
			this.srcTb.AutoScroll = ((bool)(resources.GetObject("srcTb.AutoScroll")));
			this.srcTb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("srcTb.AutoScrollMargin")));
			this.srcTb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("srcTb.AutoScrollMinSize")));
			this.srcTb.BackColor = System.Drawing.Color.Transparent;
			this.srcTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("srcTb.BackgroundImage")));
			this.srcTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.srcTb.BorderColor = System.Drawing.SystemColors.Window;
			this.srcTb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("srcTb.Dock")));
			this.srcTb.DockPadding.Bottom = 4;
			this.srcTb.DockPadding.Left = 4;
			this.srcTb.DockPadding.Right = 4;
			this.srcTb.DockPadding.Top = 44;
			this.srcTb.Enabled = ((bool)(resources.GetObject("srcTb.Enabled")));
			this.srcTb.Font = ((System.Drawing.Font)(resources.GetObject("srcTb.Font")));
			this.srcTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.srcTb.HeaderText = resources.GetString("srcTb.HeaderText");
			this.srcTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.srcTb.Icon = ((System.Drawing.Image)(resources.GetObject("srcTb.Icon")));
			this.srcTb.IconLocation = new System.Drawing.Point(4, 6);
			this.srcTb.IconSize = new System.Drawing.Size(48, 32);
			this.srcTb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("srcTb.ImeMode")));
			this.srcTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.srcTb.Location = ((System.Drawing.Point)(resources.GetObject("srcTb.Location")));
			this.srcTb.Name = "srcTb";
			this.srcTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.srcTb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("srcTb.RightToLeft")));
			this.srcTb.Size = ((System.Drawing.Size)(resources.GetObject("srcTb.Size")));
			this.srcTb.TabIndex = ((int)(resources.GetObject("srcTb.TabIndex")));
			this.srcTb.Text = resources.GetString("srcTb.Text");
			this.srcTb.Visible = ((bool)(resources.GetObject("srcTb.Visible")));
			// 
			// dstTb
			// 
			this.dstTb.AccessibleDescription = resources.GetString("dstTb.AccessibleDescription");
			this.dstTb.AccessibleName = resources.GetString("dstTb.AccessibleName");
			this.dstTb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("dstTb.Anchor")));
			this.dstTb.AutoScroll = ((bool)(resources.GetObject("dstTb.AutoScroll")));
			this.dstTb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("dstTb.AutoScrollMargin")));
			this.dstTb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("dstTb.AutoScrollMinSize")));
			this.dstTb.BackColor = System.Drawing.Color.Transparent;
			this.dstTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dstTb.BackgroundImage")));
			this.dstTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.dstTb.BorderColor = System.Drawing.SystemColors.Window;
			this.dstTb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("dstTb.Dock")));
			this.dstTb.DockPadding.Bottom = 4;
			this.dstTb.DockPadding.Left = 4;
			this.dstTb.DockPadding.Right = 4;
			this.dstTb.DockPadding.Top = 44;
			this.dstTb.Enabled = ((bool)(resources.GetObject("dstTb.Enabled")));
			this.dstTb.Font = ((System.Drawing.Font)(resources.GetObject("dstTb.Font")));
			this.dstTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.dstTb.HeaderText = resources.GetString("dstTb.HeaderText");
			this.dstTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dstTb.Icon = ((System.Drawing.Image)(resources.GetObject("dstTb.Icon")));
			this.dstTb.IconLocation = new System.Drawing.Point(4, 6);
			this.dstTb.IconSize = new System.Drawing.Size(48, 32);
			this.dstTb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("dstTb.ImeMode")));
			this.dstTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.dstTb.Location = ((System.Drawing.Point)(resources.GetObject("dstTb.Location")));
			this.dstTb.Name = "dstTb";
			this.dstTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.dstTb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("dstTb.RightToLeft")));
			this.dstTb.Size = ((System.Drawing.Size)(resources.GetObject("dstTb.Size")));
			this.dstTb.TabIndex = ((int)(resources.GetObject("dstTb.TabIndex")));
			this.dstTb.Text = resources.GetString("dstTb.Text");
			this.dstTb.Visible = ((bool)(resources.GetObject("dstTb.Visible")));
			// 
			// pnMisc
			// 
			this.pnMisc.AccessibleDescription = resources.GetString("pnMisc.AccessibleDescription");
			this.pnMisc.AccessibleName = resources.GetString("pnMisc.AccessibleName");
			this.pnMisc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnMisc.Anchor")));
			this.pnMisc.AutoScroll = ((bool)(resources.GetObject("pnMisc.AutoScroll")));
			this.pnMisc.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnMisc.AutoScrollMargin")));
			this.pnMisc.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnMisc.AutoScrollMinSize")));
			this.pnMisc.BackColor = System.Drawing.Color.Transparent;
			this.pnMisc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnMisc.BackgroundImage")));
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple3);
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple2);
			this.pnMisc.Controls.Add(this.xpTaskBoxSimple1);
			this.pnMisc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnMisc.Dock")));
			this.pnMisc.Enabled = ((bool)(resources.GetObject("pnMisc.Enabled")));
			this.pnMisc.Font = ((System.Drawing.Font)(resources.GetObject("pnMisc.Font")));
			this.pnMisc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnMisc.ImeMode")));
			this.pnMisc.Location = ((System.Drawing.Point)(resources.GetObject("pnMisc.Location")));
			this.pnMisc.Name = "pnMisc";
			this.pnMisc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnMisc.RightToLeft")));
			this.pnMisc.Size = ((System.Drawing.Size)(resources.GetObject("pnMisc.Size")));
			this.pnMisc.TabIndex = ((int)(resources.GetObject("pnMisc.TabIndex")));
			this.pnMisc.Text = resources.GetString("pnMisc.Text");
			this.pnMisc.Visible = ((bool)(resources.GetObject("pnMisc.Visible")));
			// 
			// xpTaskBoxSimple3
			// 
			this.xpTaskBoxSimple3.AccessibleDescription = resources.GetString("xpTaskBoxSimple3.AccessibleDescription");
			this.xpTaskBoxSimple3.AccessibleName = resources.GetString("xpTaskBoxSimple3.AccessibleName");
			this.xpTaskBoxSimple3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpTaskBoxSimple3.Anchor")));
			this.xpTaskBoxSimple3.AutoScroll = ((bool)(resources.GetObject("xpTaskBoxSimple3.AutoScroll")));
			this.xpTaskBoxSimple3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple3.AutoScrollMargin")));
			this.xpTaskBoxSimple3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple3.AutoScrollMinSize")));
			this.xpTaskBoxSimple3.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple3.BackgroundImage")));
			this.xpTaskBoxSimple3.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple3.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple3.Controls.Add(this.label3);
			this.xpTaskBoxSimple3.Controls.Add(this.tbstatmot);
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
			this.xpTaskBoxSimple3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpTaskBoxSimple3.Dock")));
			this.xpTaskBoxSimple3.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple3.DockPadding.Left = 4;
			this.xpTaskBoxSimple3.DockPadding.Right = 4;
			this.xpTaskBoxSimple3.DockPadding.Top = 44;
			this.xpTaskBoxSimple3.Enabled = ((bool)(resources.GetObject("xpTaskBoxSimple3.Enabled")));
			this.xpTaskBoxSimple3.Font = ((System.Drawing.Font)(resources.GetObject("xpTaskBoxSimple3.Font")));
			this.xpTaskBoxSimple3.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple3.HeaderText = resources.GetString("xpTaskBoxSimple3.HeaderText");
			this.xpTaskBoxSimple3.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple3.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple3.Icon")));
			this.xpTaskBoxSimple3.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple3.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpTaskBoxSimple3.ImeMode")));
			this.xpTaskBoxSimple3.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple3.Location = ((System.Drawing.Point)(resources.GetObject("xpTaskBoxSimple3.Location")));
			this.xpTaskBoxSimple3.Name = "xpTaskBoxSimple3";
			this.xpTaskBoxSimple3.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpTaskBoxSimple3.RightToLeft")));
			this.xpTaskBoxSimple3.Size = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple3.Size")));
			this.xpTaskBoxSimple3.TabIndex = ((int)(resources.GetObject("xpTaskBoxSimple3.TabIndex")));
			this.xpTaskBoxSimple3.Text = resources.GetString("xpTaskBoxSimple3.Text");
			this.xpTaskBoxSimple3.Visible = ((bool)(resources.GetObject("xpTaskBoxSimple3.Visible")));
			// 
			// label3
			// 
			this.label3.AccessibleDescription = resources.GetString("label3.AccessibleDescription");
			this.label3.AccessibleName = resources.GetString("label3.AccessibleName");
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label3.Anchor")));
			this.label3.AutoSize = ((bool)(resources.GetObject("label3.AutoSize")));
			this.label3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label3.Dock")));
			this.label3.Enabled = ((bool)(resources.GetObject("label3.Enabled")));
			this.label3.Font = ((System.Drawing.Font)(resources.GetObject("label3.Font")));
			this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
			this.label3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.ImageAlign")));
			this.label3.ImageIndex = ((int)(resources.GetObject("label3.ImageIndex")));
			this.label3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label3.ImeMode")));
			this.label3.Location = ((System.Drawing.Point)(resources.GetObject("label3.Location")));
			this.label3.Name = "label3";
			this.label3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label3.RightToLeft")));
			this.label3.Size = ((System.Drawing.Size)(resources.GetObject("label3.Size")));
			this.label3.TabIndex = ((int)(resources.GetObject("label3.TabIndex")));
			this.label3.Text = resources.GetString("label3.Text");
			this.label3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label3.TextAlign")));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			// 
			// tbstatmot
			// 
			this.tbstatmot.AccessibleDescription = resources.GetString("tbstatmot.AccessibleDescription");
			this.tbstatmot.AccessibleName = resources.GetString("tbstatmot.AccessibleName");
			this.tbstatmot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbstatmot.Anchor")));
			this.tbstatmot.AutoSize = ((bool)(resources.GetObject("tbstatmot.AutoSize")));
			this.tbstatmot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbstatmot.BackgroundImage")));
			this.tbstatmot.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbstatmot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbstatmot.Dock")));
			this.tbstatmot.Enabled = ((bool)(resources.GetObject("tbstatmot.Enabled")));
			this.tbstatmot.Font = ((System.Drawing.Font)(resources.GetObject("tbstatmot.Font")));
			this.tbstatmot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbstatmot.ImeMode")));
			this.tbstatmot.Location = ((System.Drawing.Point)(resources.GetObject("tbstatmot.Location")));
			this.tbstatmot.MaxLength = ((int)(resources.GetObject("tbstatmot.MaxLength")));
			this.tbstatmot.Multiline = ((bool)(resources.GetObject("tbstatmot.Multiline")));
			this.tbstatmot.Name = "tbstatmot";
			this.tbstatmot.PasswordChar = ((char)(resources.GetObject("tbstatmot.PasswordChar")));
			this.tbstatmot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbstatmot.RightToLeft")));
			this.tbstatmot.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbstatmot.ScrollBars")));
			this.tbstatmot.Size = ((System.Drawing.Size)(resources.GetObject("tbstatmot.Size")));
			this.tbstatmot.TabIndex = ((int)(resources.GetObject("tbstatmot.TabIndex")));
			this.tbstatmot.Text = resources.GetString("tbstatmot.Text");
			this.tbstatmot.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbstatmot.TextAlign")));
			this.tbstatmot.Visible = ((bool)(resources.GetObject("tbstatmot.Visible")));
			this.tbstatmot.WordWrap = ((bool)(resources.GetObject("tbstatmot.WordWrap")));
			this.tbstatmot.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label96
			// 
			this.label96.AccessibleDescription = resources.GetString("label96.AccessibleDescription");
			this.label96.AccessibleName = resources.GetString("label96.AccessibleName");
			this.label96.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label96.Anchor")));
			this.label96.AutoSize = ((bool)(resources.GetObject("label96.AutoSize")));
			this.label96.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label96.Dock")));
			this.label96.Enabled = ((bool)(resources.GetObject("label96.Enabled")));
			this.label96.Font = ((System.Drawing.Font)(resources.GetObject("label96.Font")));
			this.label96.Image = ((System.Drawing.Image)(resources.GetObject("label96.Image")));
			this.label96.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label96.ImageAlign")));
			this.label96.ImageIndex = ((int)(resources.GetObject("label96.ImageIndex")));
			this.label96.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label96.ImeMode")));
			this.label96.Location = ((System.Drawing.Point)(resources.GetObject("label96.Location")));
			this.label96.Name = "label96";
			this.label96.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label96.RightToLeft")));
			this.label96.Size = ((System.Drawing.Size)(resources.GetObject("label96.Size")));
			this.label96.TabIndex = ((int)(resources.GetObject("label96.TabIndex")));
			this.label96.Text = resources.GetString("label96.Text");
			this.label96.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label96.TextAlign")));
			this.label96.Visible = ((bool)(resources.GetObject("label96.Visible")));
			// 
			// tbunlinked
			// 
			this.tbunlinked.AccessibleDescription = resources.GetString("tbunlinked.AccessibleDescription");
			this.tbunlinked.AccessibleName = resources.GetString("tbunlinked.AccessibleName");
			this.tbunlinked.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbunlinked.Anchor")));
			this.tbunlinked.AutoSize = ((bool)(resources.GetObject("tbunlinked.AutoSize")));
			this.tbunlinked.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbunlinked.BackgroundImage")));
			this.tbunlinked.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbunlinked.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbunlinked.Dock")));
			this.tbunlinked.Enabled = ((bool)(resources.GetObject("tbunlinked.Enabled")));
			this.tbunlinked.Font = ((System.Drawing.Font)(resources.GetObject("tbunlinked.Font")));
			this.tbunlinked.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbunlinked.ImeMode")));
			this.tbunlinked.Location = ((System.Drawing.Point)(resources.GetObject("tbunlinked.Location")));
			this.tbunlinked.MaxLength = ((int)(resources.GetObject("tbunlinked.MaxLength")));
			this.tbunlinked.Multiline = ((bool)(resources.GetObject("tbunlinked.Multiline")));
			this.tbunlinked.Name = "tbunlinked";
			this.tbunlinked.PasswordChar = ((char)(resources.GetObject("tbunlinked.PasswordChar")));
			this.tbunlinked.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbunlinked.RightToLeft")));
			this.tbunlinked.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbunlinked.ScrollBars")));
			this.tbunlinked.Size = ((System.Drawing.Size)(resources.GetObject("tbunlinked.Size")));
			this.tbunlinked.TabIndex = ((int)(resources.GetObject("tbunlinked.TabIndex")));
			this.tbunlinked.Text = resources.GetString("tbunlinked.Text");
			this.tbunlinked.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbunlinked.TextAlign")));
			this.tbunlinked.Visible = ((bool)(resources.GetObject("tbunlinked.Visible")));
			this.tbunlinked.WordWrap = ((bool)(resources.GetObject("tbunlinked.WordWrap")));
			this.tbunlinked.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label95
			// 
			this.label95.AccessibleDescription = resources.GetString("label95.AccessibleDescription");
			this.label95.AccessibleName = resources.GetString("label95.AccessibleName");
			this.label95.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label95.Anchor")));
			this.label95.AutoSize = ((bool)(resources.GetObject("label95.AutoSize")));
			this.label95.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label95.Dock")));
			this.label95.Enabled = ((bool)(resources.GetObject("label95.Enabled")));
			this.label95.Font = ((System.Drawing.Font)(resources.GetObject("label95.Font")));
			this.label95.Image = ((System.Drawing.Image)(resources.GetObject("label95.Image")));
			this.label95.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label95.ImageAlign")));
			this.label95.ImageIndex = ((int)(resources.GetObject("label95.ImageIndex")));
			this.label95.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label95.ImeMode")));
			this.label95.Location = ((System.Drawing.Point)(resources.GetObject("label95.Location")));
			this.label95.Name = "label95";
			this.label95.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label95.RightToLeft")));
			this.label95.Size = ((System.Drawing.Size)(resources.GetObject("label95.Size")));
			this.label95.TabIndex = ((int)(resources.GetObject("label95.TabIndex")));
			this.label95.Text = resources.GetString("label95.Text");
			this.label95.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label95.TextAlign")));
			this.label95.Visible = ((bool)(resources.GetObject("label95.Visible")));
			// 
			// tbagedur
			// 
			this.tbagedur.AccessibleDescription = resources.GetString("tbagedur.AccessibleDescription");
			this.tbagedur.AccessibleName = resources.GetString("tbagedur.AccessibleName");
			this.tbagedur.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbagedur.Anchor")));
			this.tbagedur.AutoSize = ((bool)(resources.GetObject("tbagedur.AutoSize")));
			this.tbagedur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbagedur.BackgroundImage")));
			this.tbagedur.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbagedur.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbagedur.Dock")));
			this.tbagedur.Enabled = ((bool)(resources.GetObject("tbagedur.Enabled")));
			this.tbagedur.Font = ((System.Drawing.Font)(resources.GetObject("tbagedur.Font")));
			this.tbagedur.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbagedur.ImeMode")));
			this.tbagedur.Location = ((System.Drawing.Point)(resources.GetObject("tbagedur.Location")));
			this.tbagedur.MaxLength = ((int)(resources.GetObject("tbagedur.MaxLength")));
			this.tbagedur.Multiline = ((bool)(resources.GetObject("tbagedur.Multiline")));
			this.tbagedur.Name = "tbagedur";
			this.tbagedur.PasswordChar = ((char)(resources.GetObject("tbagedur.PasswordChar")));
			this.tbagedur.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbagedur.RightToLeft")));
			this.tbagedur.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbagedur.ScrollBars")));
			this.tbagedur.Size = ((System.Drawing.Size)(resources.GetObject("tbagedur.Size")));
			this.tbagedur.TabIndex = ((int)(resources.GetObject("tbagedur.TabIndex")));
			this.tbagedur.Text = resources.GetString("tbagedur.Text");
			this.tbagedur.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbagedur.TextAlign")));
			this.tbagedur.Visible = ((bool)(resources.GetObject("tbagedur.Visible")));
			this.tbagedur.WordWrap = ((bool)(resources.GetObject("tbagedur.WordWrap")));
			this.tbagedur.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// tbprevdays
			// 
			this.tbprevdays.AccessibleDescription = resources.GetString("tbprevdays.AccessibleDescription");
			this.tbprevdays.AccessibleName = resources.GetString("tbprevdays.AccessibleName");
			this.tbprevdays.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbprevdays.Anchor")));
			this.tbprevdays.AutoSize = ((bool)(resources.GetObject("tbprevdays.AutoSize")));
			this.tbprevdays.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbprevdays.BackgroundImage")));
			this.tbprevdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbprevdays.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbprevdays.Dock")));
			this.tbprevdays.Enabled = ((bool)(resources.GetObject("tbprevdays.Enabled")));
			this.tbprevdays.Font = ((System.Drawing.Font)(resources.GetObject("tbprevdays.Font")));
			this.tbprevdays.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbprevdays.ImeMode")));
			this.tbprevdays.Location = ((System.Drawing.Point)(resources.GetObject("tbprevdays.Location")));
			this.tbprevdays.MaxLength = ((int)(resources.GetObject("tbprevdays.MaxLength")));
			this.tbprevdays.Multiline = ((bool)(resources.GetObject("tbprevdays.Multiline")));
			this.tbprevdays.Name = "tbprevdays";
			this.tbprevdays.PasswordChar = ((char)(resources.GetObject("tbprevdays.PasswordChar")));
			this.tbprevdays.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbprevdays.RightToLeft")));
			this.tbprevdays.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbprevdays.ScrollBars")));
			this.tbprevdays.Size = ((System.Drawing.Size)(resources.GetObject("tbprevdays.Size")));
			this.tbprevdays.TabIndex = ((int)(resources.GetObject("tbprevdays.TabIndex")));
			this.tbprevdays.Text = resources.GetString("tbprevdays.Text");
			this.tbprevdays.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbprevdays.TextAlign")));
			this.tbprevdays.Visible = ((bool)(resources.GetObject("tbprevdays.Visible")));
			this.tbprevdays.WordWrap = ((bool)(resources.GetObject("tbprevdays.WordWrap")));
			this.tbprevdays.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label94
			// 
			this.label94.AccessibleDescription = resources.GetString("label94.AccessibleDescription");
			this.label94.AccessibleName = resources.GetString("label94.AccessibleName");
			this.label94.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label94.Anchor")));
			this.label94.AutoSize = ((bool)(resources.GetObject("label94.AutoSize")));
			this.label94.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label94.Dock")));
			this.label94.Enabled = ((bool)(resources.GetObject("label94.Enabled")));
			this.label94.Font = ((System.Drawing.Font)(resources.GetObject("label94.Font")));
			this.label94.Image = ((System.Drawing.Image)(resources.GetObject("label94.Image")));
			this.label94.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label94.ImageAlign")));
			this.label94.ImageIndex = ((int)(resources.GetObject("label94.ImageIndex")));
			this.label94.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label94.ImeMode")));
			this.label94.Location = ((System.Drawing.Point)(resources.GetObject("label94.Location")));
			this.label94.Name = "label94";
			this.label94.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label94.RightToLeft")));
			this.label94.Size = ((System.Drawing.Size)(resources.GetObject("label94.Size")));
			this.label94.TabIndex = ((int)(resources.GetObject("label94.TabIndex")));
			this.label94.Text = resources.GetString("label94.Text");
			this.label94.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label94.TextAlign")));
			this.label94.Visible = ((bool)(resources.GetObject("label94.Visible")));
			// 
			// tbvoice
			// 
			this.tbvoice.AccessibleDescription = resources.GetString("tbvoice.AccessibleDescription");
			this.tbvoice.AccessibleName = resources.GetString("tbvoice.AccessibleName");
			this.tbvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbvoice.Anchor")));
			this.tbvoice.AutoSize = ((bool)(resources.GetObject("tbvoice.AutoSize")));
			this.tbvoice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbvoice.BackgroundImage")));
			this.tbvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbvoice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbvoice.Dock")));
			this.tbvoice.Enabled = ((bool)(resources.GetObject("tbvoice.Enabled")));
			this.tbvoice.Font = ((System.Drawing.Font)(resources.GetObject("tbvoice.Font")));
			this.tbvoice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbvoice.ImeMode")));
			this.tbvoice.Location = ((System.Drawing.Point)(resources.GetObject("tbvoice.Location")));
			this.tbvoice.MaxLength = ((int)(resources.GetObject("tbvoice.MaxLength")));
			this.tbvoice.Multiline = ((bool)(resources.GetObject("tbvoice.Multiline")));
			this.tbvoice.Name = "tbvoice";
			this.tbvoice.PasswordChar = ((char)(resources.GetObject("tbvoice.PasswordChar")));
			this.tbvoice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbvoice.RightToLeft")));
			this.tbvoice.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbvoice.ScrollBars")));
			this.tbvoice.Size = ((System.Drawing.Size)(resources.GetObject("tbvoice.Size")));
			this.tbvoice.TabIndex = ((int)(resources.GetObject("tbvoice.TabIndex")));
			this.tbvoice.Text = resources.GetString("tbvoice.Text");
			this.tbvoice.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbvoice.TextAlign")));
			this.tbvoice.Visible = ((bool)(resources.GetObject("tbvoice.Visible")));
			this.tbvoice.WordWrap = ((bool)(resources.GetObject("tbvoice.WordWrap")));
			this.tbvoice.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label90
			// 
			this.label90.AccessibleDescription = resources.GetString("label90.AccessibleDescription");
			this.label90.AccessibleName = resources.GetString("label90.AccessibleName");
			this.label90.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label90.Anchor")));
			this.label90.AutoSize = ((bool)(resources.GetObject("label90.AutoSize")));
			this.label90.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label90.Dock")));
			this.label90.Enabled = ((bool)(resources.GetObject("label90.Enabled")));
			this.label90.Font = ((System.Drawing.Font)(resources.GetObject("label90.Font")));
			this.label90.Image = ((System.Drawing.Image)(resources.GetObject("label90.Image")));
			this.label90.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label90.ImageAlign")));
			this.label90.ImageIndex = ((int)(resources.GetObject("label90.ImageIndex")));
			this.label90.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label90.ImeMode")));
			this.label90.Location = ((System.Drawing.Point)(resources.GetObject("label90.Location")));
			this.label90.Name = "label90";
			this.label90.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label90.RightToLeft")));
			this.label90.Size = ((System.Drawing.Size)(resources.GetObject("label90.Size")));
			this.label90.TabIndex = ((int)(resources.GetObject("label90.TabIndex")));
			this.label90.Text = resources.GetString("label90.Text");
			this.label90.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label90.TextAlign")));
			this.label90.Visible = ((bool)(resources.GetObject("label90.Visible")));
			// 
			// tbnpc
			// 
			this.tbnpc.AccessibleDescription = resources.GetString("tbnpc.AccessibleDescription");
			this.tbnpc.AccessibleName = resources.GetString("tbnpc.AccessibleName");
			this.tbnpc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbnpc.Anchor")));
			this.tbnpc.AutoSize = ((bool)(resources.GetObject("tbnpc.AutoSize")));
			this.tbnpc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbnpc.BackgroundImage")));
			this.tbnpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbnpc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbnpc.Dock")));
			this.tbnpc.Enabled = ((bool)(resources.GetObject("tbnpc.Enabled")));
			this.tbnpc.Font = ((System.Drawing.Font)(resources.GetObject("tbnpc.Font")));
			this.tbnpc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbnpc.ImeMode")));
			this.tbnpc.Location = ((System.Drawing.Point)(resources.GetObject("tbnpc.Location")));
			this.tbnpc.MaxLength = ((int)(resources.GetObject("tbnpc.MaxLength")));
			this.tbnpc.Multiline = ((bool)(resources.GetObject("tbnpc.Multiline")));
			this.tbnpc.Name = "tbnpc";
			this.tbnpc.PasswordChar = ((char)(resources.GetObject("tbnpc.PasswordChar")));
			this.tbnpc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbnpc.RightToLeft")));
			this.tbnpc.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbnpc.ScrollBars")));
			this.tbnpc.Size = ((System.Drawing.Size)(resources.GetObject("tbnpc.Size")));
			this.tbnpc.TabIndex = ((int)(resources.GetObject("tbnpc.TabIndex")));
			this.tbnpc.Text = resources.GetString("tbnpc.Text");
			this.tbnpc.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbnpc.TextAlign")));
			this.tbnpc.Visible = ((bool)(resources.GetObject("tbnpc.Visible")));
			this.tbnpc.WordWrap = ((bool)(resources.GetObject("tbnpc.WordWrap")));
			this.tbnpc.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label87
			// 
			this.label87.AccessibleDescription = resources.GetString("label87.AccessibleDescription");
			this.label87.AccessibleName = resources.GetString("label87.AccessibleName");
			this.label87.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label87.Anchor")));
			this.label87.AutoSize = ((bool)(resources.GetObject("label87.AutoSize")));
			this.label87.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label87.Dock")));
			this.label87.Enabled = ((bool)(resources.GetObject("label87.Enabled")));
			this.label87.Font = ((System.Drawing.Font)(resources.GetObject("label87.Font")));
			this.label87.Image = ((System.Drawing.Image)(resources.GetObject("label87.Image")));
			this.label87.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label87.ImageAlign")));
			this.label87.ImageIndex = ((int)(resources.GetObject("label87.ImageIndex")));
			this.label87.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label87.ImeMode")));
			this.label87.Location = ((System.Drawing.Point)(resources.GetObject("label87.Location")));
			this.label87.Name = "label87";
			this.label87.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label87.RightToLeft")));
			this.label87.Size = ((System.Drawing.Size)(resources.GetObject("label87.Size")));
			this.label87.TabIndex = ((int)(resources.GetObject("label87.TabIndex")));
			this.label87.Text = resources.GetString("label87.Text");
			this.label87.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label87.TextAlign")));
			this.label87.Visible = ((bool)(resources.GetObject("label87.Visible")));
			// 
			// tbautonomy
			// 
			this.tbautonomy.AccessibleDescription = resources.GetString("tbautonomy.AccessibleDescription");
			this.tbautonomy.AccessibleName = resources.GetString("tbautonomy.AccessibleName");
			this.tbautonomy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbautonomy.Anchor")));
			this.tbautonomy.AutoSize = ((bool)(resources.GetObject("tbautonomy.AutoSize")));
			this.tbautonomy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbautonomy.BackgroundImage")));
			this.tbautonomy.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbautonomy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbautonomy.Dock")));
			this.tbautonomy.Enabled = ((bool)(resources.GetObject("tbautonomy.Enabled")));
			this.tbautonomy.Font = ((System.Drawing.Font)(resources.GetObject("tbautonomy.Font")));
			this.tbautonomy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbautonomy.ImeMode")));
			this.tbautonomy.Location = ((System.Drawing.Point)(resources.GetObject("tbautonomy.Location")));
			this.tbautonomy.MaxLength = ((int)(resources.GetObject("tbautonomy.MaxLength")));
			this.tbautonomy.Multiline = ((bool)(resources.GetObject("tbautonomy.Multiline")));
			this.tbautonomy.Name = "tbautonomy";
			this.tbautonomy.PasswordChar = ((char)(resources.GetObject("tbautonomy.PasswordChar")));
			this.tbautonomy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbautonomy.RightToLeft")));
			this.tbautonomy.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbautonomy.ScrollBars")));
			this.tbautonomy.Size = ((System.Drawing.Size)(resources.GetObject("tbautonomy.Size")));
			this.tbautonomy.TabIndex = ((int)(resources.GetObject("tbautonomy.TabIndex")));
			this.tbautonomy.Text = resources.GetString("tbautonomy.Text");
			this.tbautonomy.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbautonomy.TextAlign")));
			this.tbautonomy.Visible = ((bool)(resources.GetObject("tbautonomy.Visible")));
			this.tbautonomy.WordWrap = ((bool)(resources.GetObject("tbautonomy.WordWrap")));
			this.tbautonomy.TextChanged += new System.EventHandler(this.ChangedOther);
			// 
			// label86
			// 
			this.label86.AccessibleDescription = resources.GetString("label86.AccessibleDescription");
			this.label86.AccessibleName = resources.GetString("label86.AccessibleName");
			this.label86.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label86.Anchor")));
			this.label86.AutoSize = ((bool)(resources.GetObject("label86.AutoSize")));
			this.label86.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label86.Dock")));
			this.label86.Enabled = ((bool)(resources.GetObject("label86.Enabled")));
			this.label86.Font = ((System.Drawing.Font)(resources.GetObject("label86.Font")));
			this.label86.Image = ((System.Drawing.Image)(resources.GetObject("label86.Image")));
			this.label86.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label86.ImageAlign")));
			this.label86.ImageIndex = ((int)(resources.GetObject("label86.ImageIndex")));
			this.label86.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label86.ImeMode")));
			this.label86.Location = ((System.Drawing.Point)(resources.GetObject("label86.Location")));
			this.label86.Name = "label86";
			this.label86.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label86.RightToLeft")));
			this.label86.Size = ((System.Drawing.Size)(resources.GetObject("label86.Size")));
			this.label86.TabIndex = ((int)(resources.GetObject("label86.TabIndex")));
			this.label86.Text = resources.GetString("label86.Text");
			this.label86.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label86.TextAlign")));
			this.label86.Visible = ((bool)(resources.GetObject("label86.Visible")));
			// 
			// xpTaskBoxSimple2
			// 
			this.xpTaskBoxSimple2.AccessibleDescription = resources.GetString("xpTaskBoxSimple2.AccessibleDescription");
			this.xpTaskBoxSimple2.AccessibleName = resources.GetString("xpTaskBoxSimple2.AccessibleName");
			this.xpTaskBoxSimple2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpTaskBoxSimple2.Anchor")));
			this.xpTaskBoxSimple2.AutoScroll = ((bool)(resources.GetObject("xpTaskBoxSimple2.AutoScroll")));
			this.xpTaskBoxSimple2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.AutoScrollMargin")));
			this.xpTaskBoxSimple2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.AutoScrollMinSize")));
			this.xpTaskBoxSimple2.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple2.BackgroundImage")));
			this.xpTaskBoxSimple2.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple2.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple2.Controls.Add(this.cbfit);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpreginv);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpreghalf);
			this.xpTaskBoxSimple2.Controls.Add(this.cbpregfull);
			this.xpTaskBoxSimple2.Controls.Add(this.cbfat);
			this.xpTaskBoxSimple2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpTaskBoxSimple2.Dock")));
			this.xpTaskBoxSimple2.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple2.DockPadding.Left = 4;
			this.xpTaskBoxSimple2.DockPadding.Right = 4;
			this.xpTaskBoxSimple2.DockPadding.Top = 44;
			this.xpTaskBoxSimple2.Enabled = ((bool)(resources.GetObject("xpTaskBoxSimple2.Enabled")));
			this.xpTaskBoxSimple2.Font = ((System.Drawing.Font)(resources.GetObject("xpTaskBoxSimple2.Font")));
			this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple2.HeaderText = resources.GetString("xpTaskBoxSimple2.HeaderText");
			this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple2.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple2.Icon")));
			this.xpTaskBoxSimple2.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple2.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpTaskBoxSimple2.ImeMode")));
			this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple2.Location = ((System.Drawing.Point)(resources.GetObject("xpTaskBoxSimple2.Location")));
			this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
			this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpTaskBoxSimple2.RightToLeft")));
			this.xpTaskBoxSimple2.Size = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple2.Size")));
			this.xpTaskBoxSimple2.TabIndex = ((int)(resources.GetObject("xpTaskBoxSimple2.TabIndex")));
			this.xpTaskBoxSimple2.Text = resources.GetString("xpTaskBoxSimple2.Text");
			this.xpTaskBoxSimple2.Visible = ((bool)(resources.GetObject("xpTaskBoxSimple2.Visible")));
			// 
			// cbfit
			// 
			this.cbfit.AccessibleDescription = resources.GetString("cbfit.AccessibleDescription");
			this.cbfit.AccessibleName = resources.GetString("cbfit.AccessibleName");
			this.cbfit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfit.Anchor")));
			this.cbfit.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfit.Appearance")));
			this.cbfit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfit.BackgroundImage")));
			this.cbfit.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfit.CheckAlign")));
			this.cbfit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfit.Dock")));
			this.cbfit.Enabled = ((bool)(resources.GetObject("cbfit.Enabled")));
			this.cbfit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfit.FlatStyle")));
			this.cbfit.Font = ((System.Drawing.Font)(resources.GetObject("cbfit.Font")));
			this.cbfit.Image = ((System.Drawing.Image)(resources.GetObject("cbfit.Image")));
			this.cbfit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfit.ImageAlign")));
			this.cbfit.ImageIndex = ((int)(resources.GetObject("cbfit.ImageIndex")));
			this.cbfit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfit.ImeMode")));
			this.cbfit.Location = ((System.Drawing.Point)(resources.GetObject("cbfit.Location")));
			this.cbfit.Name = "cbfit";
			this.cbfit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfit.RightToLeft")));
			this.cbfit.Size = ((System.Drawing.Size)(resources.GetObject("cbfit.Size")));
			this.cbfit.TabIndex = ((int)(resources.GetObject("cbfit.TabIndex")));
			this.cbfit.Text = resources.GetString("cbfit.Text");
			this.cbfit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfit.TextAlign")));
			this.cbfit.Visible = ((bool)(resources.GetObject("cbfit.Visible")));
			this.cbfit.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpreginv
			// 
			this.cbpreginv.AccessibleDescription = resources.GetString("cbpreginv.AccessibleDescription");
			this.cbpreginv.AccessibleName = resources.GetString("cbpreginv.AccessibleName");
			this.cbpreginv.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpreginv.Anchor")));
			this.cbpreginv.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpreginv.Appearance")));
			this.cbpreginv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpreginv.BackgroundImage")));
			this.cbpreginv.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreginv.CheckAlign")));
			this.cbpreginv.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpreginv.Dock")));
			this.cbpreginv.Enabled = ((bool)(resources.GetObject("cbpreginv.Enabled")));
			this.cbpreginv.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpreginv.FlatStyle")));
			this.cbpreginv.Font = ((System.Drawing.Font)(resources.GetObject("cbpreginv.Font")));
			this.cbpreginv.Image = ((System.Drawing.Image)(resources.GetObject("cbpreginv.Image")));
			this.cbpreginv.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreginv.ImageAlign")));
			this.cbpreginv.ImageIndex = ((int)(resources.GetObject("cbpreginv.ImageIndex")));
			this.cbpreginv.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpreginv.ImeMode")));
			this.cbpreginv.Location = ((System.Drawing.Point)(resources.GetObject("cbpreginv.Location")));
			this.cbpreginv.Name = "cbpreginv";
			this.cbpreginv.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpreginv.RightToLeft")));
			this.cbpreginv.Size = ((System.Drawing.Size)(resources.GetObject("cbpreginv.Size")));
			this.cbpreginv.TabIndex = ((int)(resources.GetObject("cbpreginv.TabIndex")));
			this.cbpreginv.Text = resources.GetString("cbpreginv.Text");
			this.cbpreginv.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreginv.TextAlign")));
			this.cbpreginv.Visible = ((bool)(resources.GetObject("cbpreginv.Visible")));
			this.cbpreginv.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpreghalf
			// 
			this.cbpreghalf.AccessibleDescription = resources.GetString("cbpreghalf.AccessibleDescription");
			this.cbpreghalf.AccessibleName = resources.GetString("cbpreghalf.AccessibleName");
			this.cbpreghalf.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpreghalf.Anchor")));
			this.cbpreghalf.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpreghalf.Appearance")));
			this.cbpreghalf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpreghalf.BackgroundImage")));
			this.cbpreghalf.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreghalf.CheckAlign")));
			this.cbpreghalf.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpreghalf.Dock")));
			this.cbpreghalf.Enabled = ((bool)(resources.GetObject("cbpreghalf.Enabled")));
			this.cbpreghalf.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpreghalf.FlatStyle")));
			this.cbpreghalf.Font = ((System.Drawing.Font)(resources.GetObject("cbpreghalf.Font")));
			this.cbpreghalf.Image = ((System.Drawing.Image)(resources.GetObject("cbpreghalf.Image")));
			this.cbpreghalf.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreghalf.ImageAlign")));
			this.cbpreghalf.ImageIndex = ((int)(resources.GetObject("cbpreghalf.ImageIndex")));
			this.cbpreghalf.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpreghalf.ImeMode")));
			this.cbpreghalf.Location = ((System.Drawing.Point)(resources.GetObject("cbpreghalf.Location")));
			this.cbpreghalf.Name = "cbpreghalf";
			this.cbpreghalf.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpreghalf.RightToLeft")));
			this.cbpreghalf.Size = ((System.Drawing.Size)(resources.GetObject("cbpreghalf.Size")));
			this.cbpreghalf.TabIndex = ((int)(resources.GetObject("cbpreghalf.TabIndex")));
			this.cbpreghalf.Text = resources.GetString("cbpreghalf.Text");
			this.cbpreghalf.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpreghalf.TextAlign")));
			this.cbpreghalf.Visible = ((bool)(resources.GetObject("cbpreghalf.Visible")));
			this.cbpreghalf.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpregfull
			// 
			this.cbpregfull.AccessibleDescription = resources.GetString("cbpregfull.AccessibleDescription");
			this.cbpregfull.AccessibleName = resources.GetString("cbpregfull.AccessibleName");
			this.cbpregfull.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpregfull.Anchor")));
			this.cbpregfull.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpregfull.Appearance")));
			this.cbpregfull.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpregfull.BackgroundImage")));
			this.cbpregfull.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpregfull.CheckAlign")));
			this.cbpregfull.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpregfull.Dock")));
			this.cbpregfull.Enabled = ((bool)(resources.GetObject("cbpregfull.Enabled")));
			this.cbpregfull.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpregfull.FlatStyle")));
			this.cbpregfull.Font = ((System.Drawing.Font)(resources.GetObject("cbpregfull.Font")));
			this.cbpregfull.Image = ((System.Drawing.Image)(resources.GetObject("cbpregfull.Image")));
			this.cbpregfull.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpregfull.ImageAlign")));
			this.cbpregfull.ImageIndex = ((int)(resources.GetObject("cbpregfull.ImageIndex")));
			this.cbpregfull.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpregfull.ImeMode")));
			this.cbpregfull.Location = ((System.Drawing.Point)(resources.GetObject("cbpregfull.Location")));
			this.cbpregfull.Name = "cbpregfull";
			this.cbpregfull.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpregfull.RightToLeft")));
			this.cbpregfull.Size = ((System.Drawing.Size)(resources.GetObject("cbpregfull.Size")));
			this.cbpregfull.TabIndex = ((int)(resources.GetObject("cbpregfull.TabIndex")));
			this.cbpregfull.Text = resources.GetString("cbpregfull.Text");
			this.cbpregfull.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpregfull.TextAlign")));
			this.cbpregfull.Visible = ((bool)(resources.GetObject("cbpregfull.Visible")));
			this.cbpregfull.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbfat
			// 
			this.cbfat.AccessibleDescription = resources.GetString("cbfat.AccessibleDescription");
			this.cbfat.AccessibleName = resources.GetString("cbfat.AccessibleName");
			this.cbfat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfat.Anchor")));
			this.cbfat.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfat.Appearance")));
			this.cbfat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfat.BackgroundImage")));
			this.cbfat.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfat.CheckAlign")));
			this.cbfat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfat.Dock")));
			this.cbfat.Enabled = ((bool)(resources.GetObject("cbfat.Enabled")));
			this.cbfat.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfat.FlatStyle")));
			this.cbfat.Font = ((System.Drawing.Font)(resources.GetObject("cbfat.Font")));
			this.cbfat.Image = ((System.Drawing.Image)(resources.GetObject("cbfat.Image")));
			this.cbfat.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfat.ImageAlign")));
			this.cbfat.ImageIndex = ((int)(resources.GetObject("cbfat.ImageIndex")));
			this.cbfat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfat.ImeMode")));
			this.cbfat.Location = ((System.Drawing.Point)(resources.GetObject("cbfat.Location")));
			this.cbfat.Name = "cbfat";
			this.cbfat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfat.RightToLeft")));
			this.cbfat.Size = ((System.Drawing.Size)(resources.GetObject("cbfat.Size")));
			this.cbfat.TabIndex = ((int)(resources.GetObject("cbfat.TabIndex")));
			this.cbfat.Text = resources.GetString("cbfat.Text");
			this.cbfat.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfat.TextAlign")));
			this.cbfat.Visible = ((bool)(resources.GetObject("cbfat.Visible")));
			this.cbfat.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// xpTaskBoxSimple1
			// 
			this.xpTaskBoxSimple1.AccessibleDescription = resources.GetString("xpTaskBoxSimple1.AccessibleDescription");
			this.xpTaskBoxSimple1.AccessibleName = resources.GetString("xpTaskBoxSimple1.AccessibleName");
			this.xpTaskBoxSimple1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xpTaskBoxSimple1.Anchor")));
			this.xpTaskBoxSimple1.AutoScroll = ((bool)(resources.GetObject("xpTaskBoxSimple1.AutoScroll")));
			this.xpTaskBoxSimple1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.AutoScrollMargin")));
			this.xpTaskBoxSimple1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.AutoScrollMinSize")));
			this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
			this.xpTaskBoxSimple1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple1.BackgroundImage")));
			this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
			this.xpTaskBoxSimple1.Controls.Add(this.cbisghost);
			this.xpTaskBoxSimple1.Controls.Add(this.cbignoretraversal);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpasspeople);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpasswalls);
			this.xpTaskBoxSimple1.Controls.Add(this.cbpassobject);
			this.xpTaskBoxSimple1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xpTaskBoxSimple1.Dock")));
			this.xpTaskBoxSimple1.DockPadding.Bottom = 4;
			this.xpTaskBoxSimple1.DockPadding.Left = 4;
			this.xpTaskBoxSimple1.DockPadding.Right = 4;
			this.xpTaskBoxSimple1.DockPadding.Top = 44;
			this.xpTaskBoxSimple1.Enabled = ((bool)(resources.GetObject("xpTaskBoxSimple1.Enabled")));
			this.xpTaskBoxSimple1.Font = ((System.Drawing.Font)(resources.GetObject("xpTaskBoxSimple1.Font")));
			this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
			this.xpTaskBoxSimple1.HeaderText = resources.GetString("xpTaskBoxSimple1.HeaderText");
			this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.xpTaskBoxSimple1.Icon = ((System.Drawing.Image)(resources.GetObject("xpTaskBoxSimple1.Icon")));
			this.xpTaskBoxSimple1.IconLocation = new System.Drawing.Point(4, 12);
			this.xpTaskBoxSimple1.IconSize = new System.Drawing.Size(32, 32);
			this.xpTaskBoxSimple1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xpTaskBoxSimple1.ImeMode")));
			this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
			this.xpTaskBoxSimple1.Location = ((System.Drawing.Point)(resources.GetObject("xpTaskBoxSimple1.Location")));
			this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
			this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
			this.xpTaskBoxSimple1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xpTaskBoxSimple1.RightToLeft")));
			this.xpTaskBoxSimple1.Size = ((System.Drawing.Size)(resources.GetObject("xpTaskBoxSimple1.Size")));
			this.xpTaskBoxSimple1.TabIndex = ((int)(resources.GetObject("xpTaskBoxSimple1.TabIndex")));
			this.xpTaskBoxSimple1.Text = resources.GetString("xpTaskBoxSimple1.Text");
			this.xpTaskBoxSimple1.Visible = ((bool)(resources.GetObject("xpTaskBoxSimple1.Visible")));
			// 
			// cbisghost
			// 
			this.cbisghost.AccessibleDescription = resources.GetString("cbisghost.AccessibleDescription");
			this.cbisghost.AccessibleName = resources.GetString("cbisghost.AccessibleName");
			this.cbisghost.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbisghost.Anchor")));
			this.cbisghost.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbisghost.Appearance")));
			this.cbisghost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbisghost.BackgroundImage")));
			this.cbisghost.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbisghost.CheckAlign")));
			this.cbisghost.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbisghost.Dock")));
			this.cbisghost.Enabled = ((bool)(resources.GetObject("cbisghost.Enabled")));
			this.cbisghost.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbisghost.FlatStyle")));
			this.cbisghost.Font = ((System.Drawing.Font)(resources.GetObject("cbisghost.Font")));
			this.cbisghost.Image = ((System.Drawing.Image)(resources.GetObject("cbisghost.Image")));
			this.cbisghost.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbisghost.ImageAlign")));
			this.cbisghost.ImageIndex = ((int)(resources.GetObject("cbisghost.ImageIndex")));
			this.cbisghost.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbisghost.ImeMode")));
			this.cbisghost.Location = ((System.Drawing.Point)(resources.GetObject("cbisghost.Location")));
			this.cbisghost.Name = "cbisghost";
			this.cbisghost.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbisghost.RightToLeft")));
			this.cbisghost.Size = ((System.Drawing.Size)(resources.GetObject("cbisghost.Size")));
			this.cbisghost.TabIndex = ((int)(resources.GetObject("cbisghost.TabIndex")));
			this.cbisghost.Text = resources.GetString("cbisghost.Text");
			this.cbisghost.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbisghost.TextAlign")));
			this.cbisghost.Visible = ((bool)(resources.GetObject("cbisghost.Visible")));
			this.cbisghost.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbignoretraversal
			// 
			this.cbignoretraversal.AccessibleDescription = resources.GetString("cbignoretraversal.AccessibleDescription");
			this.cbignoretraversal.AccessibleName = resources.GetString("cbignoretraversal.AccessibleName");
			this.cbignoretraversal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbignoretraversal.Anchor")));
			this.cbignoretraversal.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbignoretraversal.Appearance")));
			this.cbignoretraversal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbignoretraversal.BackgroundImage")));
			this.cbignoretraversal.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbignoretraversal.CheckAlign")));
			this.cbignoretraversal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbignoretraversal.Dock")));
			this.cbignoretraversal.Enabled = ((bool)(resources.GetObject("cbignoretraversal.Enabled")));
			this.cbignoretraversal.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbignoretraversal.FlatStyle")));
			this.cbignoretraversal.Font = ((System.Drawing.Font)(resources.GetObject("cbignoretraversal.Font")));
			this.cbignoretraversal.Image = ((System.Drawing.Image)(resources.GetObject("cbignoretraversal.Image")));
			this.cbignoretraversal.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbignoretraversal.ImageAlign")));
			this.cbignoretraversal.ImageIndex = ((int)(resources.GetObject("cbignoretraversal.ImageIndex")));
			this.cbignoretraversal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbignoretraversal.ImeMode")));
			this.cbignoretraversal.Location = ((System.Drawing.Point)(resources.GetObject("cbignoretraversal.Location")));
			this.cbignoretraversal.Name = "cbignoretraversal";
			this.cbignoretraversal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbignoretraversal.RightToLeft")));
			this.cbignoretraversal.Size = ((System.Drawing.Size)(resources.GetObject("cbignoretraversal.Size")));
			this.cbignoretraversal.TabIndex = ((int)(resources.GetObject("cbignoretraversal.TabIndex")));
			this.cbignoretraversal.Text = resources.GetString("cbignoretraversal.Text");
			this.cbignoretraversal.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbignoretraversal.TextAlign")));
			this.cbignoretraversal.Visible = ((bool)(resources.GetObject("cbignoretraversal.Visible")));
			this.cbignoretraversal.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpasspeople
			// 
			this.cbpasspeople.AccessibleDescription = resources.GetString("cbpasspeople.AccessibleDescription");
			this.cbpasspeople.AccessibleName = resources.GetString("cbpasspeople.AccessibleName");
			this.cbpasspeople.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpasspeople.Anchor")));
			this.cbpasspeople.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpasspeople.Appearance")));
			this.cbpasspeople.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpasspeople.BackgroundImage")));
			this.cbpasspeople.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasspeople.CheckAlign")));
			this.cbpasspeople.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpasspeople.Dock")));
			this.cbpasspeople.Enabled = ((bool)(resources.GetObject("cbpasspeople.Enabled")));
			this.cbpasspeople.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpasspeople.FlatStyle")));
			this.cbpasspeople.Font = ((System.Drawing.Font)(resources.GetObject("cbpasspeople.Font")));
			this.cbpasspeople.Image = ((System.Drawing.Image)(resources.GetObject("cbpasspeople.Image")));
			this.cbpasspeople.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasspeople.ImageAlign")));
			this.cbpasspeople.ImageIndex = ((int)(resources.GetObject("cbpasspeople.ImageIndex")));
			this.cbpasspeople.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpasspeople.ImeMode")));
			this.cbpasspeople.Location = ((System.Drawing.Point)(resources.GetObject("cbpasspeople.Location")));
			this.cbpasspeople.Name = "cbpasspeople";
			this.cbpasspeople.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpasspeople.RightToLeft")));
			this.cbpasspeople.Size = ((System.Drawing.Size)(resources.GetObject("cbpasspeople.Size")));
			this.cbpasspeople.TabIndex = ((int)(resources.GetObject("cbpasspeople.TabIndex")));
			this.cbpasspeople.Text = resources.GetString("cbpasspeople.Text");
			this.cbpasspeople.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasspeople.TextAlign")));
			this.cbpasspeople.Visible = ((bool)(resources.GetObject("cbpasspeople.Visible")));
			this.cbpasspeople.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpasswalls
			// 
			this.cbpasswalls.AccessibleDescription = resources.GetString("cbpasswalls.AccessibleDescription");
			this.cbpasswalls.AccessibleName = resources.GetString("cbpasswalls.AccessibleName");
			this.cbpasswalls.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpasswalls.Anchor")));
			this.cbpasswalls.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpasswalls.Appearance")));
			this.cbpasswalls.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpasswalls.BackgroundImage")));
			this.cbpasswalls.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasswalls.CheckAlign")));
			this.cbpasswalls.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpasswalls.Dock")));
			this.cbpasswalls.Enabled = ((bool)(resources.GetObject("cbpasswalls.Enabled")));
			this.cbpasswalls.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpasswalls.FlatStyle")));
			this.cbpasswalls.Font = ((System.Drawing.Font)(resources.GetObject("cbpasswalls.Font")));
			this.cbpasswalls.Image = ((System.Drawing.Image)(resources.GetObject("cbpasswalls.Image")));
			this.cbpasswalls.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasswalls.ImageAlign")));
			this.cbpasswalls.ImageIndex = ((int)(resources.GetObject("cbpasswalls.ImageIndex")));
			this.cbpasswalls.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpasswalls.ImeMode")));
			this.cbpasswalls.Location = ((System.Drawing.Point)(resources.GetObject("cbpasswalls.Location")));
			this.cbpasswalls.Name = "cbpasswalls";
			this.cbpasswalls.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpasswalls.RightToLeft")));
			this.cbpasswalls.Size = ((System.Drawing.Size)(resources.GetObject("cbpasswalls.Size")));
			this.cbpasswalls.TabIndex = ((int)(resources.GetObject("cbpasswalls.TabIndex")));
			this.cbpasswalls.Text = resources.GetString("cbpasswalls.Text");
			this.cbpasswalls.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpasswalls.TextAlign")));
			this.cbpasswalls.Visible = ((bool)(resources.GetObject("cbpasswalls.Visible")));
			this.cbpasswalls.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// cbpassobject
			// 
			this.cbpassobject.AccessibleDescription = resources.GetString("cbpassobject.AccessibleDescription");
			this.cbpassobject.AccessibleName = resources.GetString("cbpassobject.AccessibleName");
			this.cbpassobject.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbpassobject.Anchor")));
			this.cbpassobject.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbpassobject.Appearance")));
			this.cbpassobject.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbpassobject.BackgroundImage")));
			this.cbpassobject.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpassobject.CheckAlign")));
			this.cbpassobject.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbpassobject.Dock")));
			this.cbpassobject.Enabled = ((bool)(resources.GetObject("cbpassobject.Enabled")));
			this.cbpassobject.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbpassobject.FlatStyle")));
			this.cbpassobject.Font = ((System.Drawing.Font)(resources.GetObject("cbpassobject.Font")));
			this.cbpassobject.Image = ((System.Drawing.Image)(resources.GetObject("cbpassobject.Image")));
			this.cbpassobject.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpassobject.ImageAlign")));
			this.cbpassobject.ImageIndex = ((int)(resources.GetObject("cbpassobject.ImageIndex")));
			this.cbpassobject.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbpassobject.ImeMode")));
			this.cbpassobject.Location = ((System.Drawing.Point)(resources.GetObject("cbpassobject.Location")));
			this.cbpassobject.Name = "cbpassobject";
			this.cbpassobject.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbpassobject.RightToLeft")));
			this.cbpassobject.Size = ((System.Drawing.Size)(resources.GetObject("cbpassobject.Size")));
			this.cbpassobject.TabIndex = ((int)(resources.GetObject("cbpassobject.TabIndex")));
			this.cbpassobject.Text = resources.GetString("cbpassobject.Text");
			this.cbpassobject.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbpassobject.TextAlign")));
			this.cbpassobject.Visible = ((bool)(resources.GetObject("cbpassobject.Visible")));
			this.cbpassobject.CheckedChanged += new System.EventHandler(this.ChangedOther);
			// 
			// pnEP1
			// 
			this.pnEP1.AccessibleDescription = resources.GetString("pnEP1.AccessibleDescription");
			this.pnEP1.AccessibleName = resources.GetString("pnEP1.AccessibleName");
			this.pnEP1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnEP1.Anchor")));
			this.pnEP1.AutoScroll = ((bool)(resources.GetObject("pnEP1.AutoScroll")));
			this.pnEP1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnEP1.AutoScrollMargin")));
			this.pnEP1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnEP1.AutoScrollMinSize")));
			this.pnEP1.BackColor = System.Drawing.Color.Transparent;
			this.pnEP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEP1.BackgroundImage")));
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
			this.pnEP1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnEP1.Dock")));
			this.pnEP1.Enabled = ((bool)(resources.GetObject("pnEP1.Enabled")));
			this.pnEP1.Font = ((System.Drawing.Font)(resources.GetObject("pnEP1.Font")));
			this.pnEP1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnEP1.ImeMode")));
			this.pnEP1.Location = ((System.Drawing.Point)(resources.GetObject("pnEP1.Location")));
			this.pnEP1.Name = "pnEP1";
			this.pnEP1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnEP1.RightToLeft")));
			this.pnEP1.Size = ((System.Drawing.Size)(resources.GetObject("pnEP1.Size")));
			this.pnEP1.TabIndex = ((int)(resources.GetObject("pnEP1.TabIndex")));
			this.pnEP1.Text = resources.GetString("pnEP1.Text");
			this.pnEP1.Visible = ((bool)(resources.GetObject("pnEP1.Visible")));
			// 
			// pbLastGrade
			// 
			this.pbLastGrade.AccessibleDescription = resources.GetString("pbLastGrade.AccessibleDescription");
			this.pbLastGrade.AccessibleName = resources.GetString("pbLastGrade.AccessibleName");
			this.pbLastGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbLastGrade.Anchor")));
			this.pbLastGrade.AutoScroll = ((bool)(resources.GetObject("pbLastGrade.AutoScroll")));
			this.pbLastGrade.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbLastGrade.AutoScrollMargin")));
			this.pbLastGrade.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbLastGrade.AutoScrollMinSize")));
			this.pbLastGrade.BackColor = System.Drawing.Color.Transparent;
			this.pbLastGrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLastGrade.BackgroundImage")));
			this.pbLastGrade.DisplayOffset = 0;
			this.pbLastGrade.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbLastGrade.Dock")));
			this.pbLastGrade.DockPadding.Bottom = 5;
			this.pbLastGrade.Enabled = ((bool)(resources.GetObject("pbLastGrade.Enabled")));
			this.pbLastGrade.Font = ((System.Drawing.Font)(resources.GetObject("pbLastGrade.Font")));
			this.pbLastGrade.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbLastGrade.ImeMode")));
			this.pbLastGrade.LabelText = resources.GetString("pbLastGrade.LabelText");
			this.pbLastGrade.LabelWidth = ((int)(resources.GetObject("pbLastGrade.LabelWidth")));
			this.pbLastGrade.Location = ((System.Drawing.Point)(resources.GetObject("pbLastGrade.Location")));
			this.pbLastGrade.Maximum = 1000;
			this.pbLastGrade.Name = "pbLastGrade";
			this.pbLastGrade.NumberFormat = "N1";
			this.pbLastGrade.NumberOffset = 0;
			this.pbLastGrade.NumberScale = 0.004;
			this.pbLastGrade.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbLastGrade.RightToLeft")));
			this.pbLastGrade.SelectedColor = System.Drawing.Color.OrangeRed;
			this.pbLastGrade.Size = ((System.Drawing.Size)(resources.GetObject("pbLastGrade.Size")));
			this.pbLastGrade.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbLastGrade.TabIndex = ((int)(resources.GetObject("pbLastGrade.TabIndex")));
			this.pbLastGrade.TextboxWidth = ((int)(resources.GetObject("pbLastGrade.TextboxWidth")));
			this.pbLastGrade.TokenCount = 4;
			this.pbLastGrade.UnselectedColor = System.Drawing.Color.Black;
			this.pbLastGrade.Value = 0;
			this.pbLastGrade.Visible = ((bool)(resources.GetObject("pbLastGrade.Visible")));
			this.pbLastGrade.Changed += new System.EventHandler(this.ChangedEP1);
			// 
			// pbUniTime
			// 
			this.pbUniTime.AccessibleDescription = resources.GetString("pbUniTime.AccessibleDescription");
			this.pbUniTime.AccessibleName = resources.GetString("pbUniTime.AccessibleName");
			this.pbUniTime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbUniTime.Anchor")));
			this.pbUniTime.AutoScroll = ((bool)(resources.GetObject("pbUniTime.AutoScroll")));
			this.pbUniTime.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbUniTime.AutoScrollMargin")));
			this.pbUniTime.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbUniTime.AutoScrollMinSize")));
			this.pbUniTime.BackColor = System.Drawing.Color.Transparent;
			this.pbUniTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUniTime.BackgroundImage")));
			this.pbUniTime.DisplayOffset = 0;
			this.pbUniTime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbUniTime.Dock")));
			this.pbUniTime.DockPadding.Bottom = 5;
			this.pbUniTime.Enabled = ((bool)(resources.GetObject("pbUniTime.Enabled")));
			this.pbUniTime.Font = ((System.Drawing.Font)(resources.GetObject("pbUniTime.Font")));
			this.pbUniTime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbUniTime.ImeMode")));
			this.pbUniTime.LabelText = resources.GetString("pbUniTime.LabelText");
			this.pbUniTime.LabelWidth = ((int)(resources.GetObject("pbUniTime.LabelWidth")));
			this.pbUniTime.Location = ((System.Drawing.Point)(resources.GetObject("pbUniTime.Location")));
			this.pbUniTime.Maximum = 72;
			this.pbUniTime.Name = "pbUniTime";
			this.pbUniTime.NumberFormat = "N0";
			this.pbUniTime.NumberOffset = 0;
			this.pbUniTime.NumberScale = 1;
			this.pbUniTime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbUniTime.RightToLeft")));
			this.pbUniTime.SelectedColor = System.Drawing.Color.Lime;
			this.pbUniTime.Size = ((System.Drawing.Size)(resources.GetObject("pbUniTime.Size")));
			this.pbUniTime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
			this.pbUniTime.TabIndex = ((int)(resources.GetObject("pbUniTime.TabIndex")));
			this.pbUniTime.TextboxWidth = ((int)(resources.GetObject("pbUniTime.TextboxWidth")));
			this.pbUniTime.TokenCount = 18;
			this.pbUniTime.UnselectedColor = System.Drawing.Color.Black;
			this.pbUniTime.Value = 0;
			this.pbUniTime.Visible = ((bool)(resources.GetObject("pbUniTime.Visible")));
			this.pbUniTime.Changed += new System.EventHandler(this.ChangedEP1);
			// 
			// pbEffort
			// 
			this.pbEffort.AccessibleDescription = resources.GetString("pbEffort.AccessibleDescription");
			this.pbEffort.AccessibleName = resources.GetString("pbEffort.AccessibleName");
			this.pbEffort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbEffort.Anchor")));
			this.pbEffort.AutoScroll = ((bool)(resources.GetObject("pbEffort.AutoScroll")));
			this.pbEffort.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pbEffort.AutoScrollMargin")));
			this.pbEffort.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pbEffort.AutoScrollMinSize")));
			this.pbEffort.BackColor = System.Drawing.Color.Transparent;
			this.pbEffort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEffort.BackgroundImage")));
			this.pbEffort.DisplayOffset = 0;
			this.pbEffort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbEffort.Dock")));
			this.pbEffort.DockPadding.Bottom = 5;
			this.pbEffort.Enabled = ((bool)(resources.GetObject("pbEffort.Enabled")));
			this.pbEffort.Font = ((System.Drawing.Font)(resources.GetObject("pbEffort.Font")));
			this.pbEffort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbEffort.ImeMode")));
			this.pbEffort.LabelText = resources.GetString("pbEffort.LabelText");
			this.pbEffort.LabelWidth = ((int)(resources.GetObject("pbEffort.LabelWidth")));
			this.pbEffort.Location = ((System.Drawing.Point)(resources.GetObject("pbEffort.Location")));
			this.pbEffort.Maximum = 1000;
			this.pbEffort.Name = "pbEffort";
			this.pbEffort.NumberFormat = "N2";
			this.pbEffort.NumberOffset = 0;
			this.pbEffort.NumberScale = 0.01;
			this.pbEffort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbEffort.RightToLeft")));
			this.pbEffort.SelectedColor = System.Drawing.Color.Lime;
			this.pbEffort.Size = ((System.Drawing.Size)(resources.GetObject("pbEffort.Size")));
			this.pbEffort.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
			this.pbEffort.TabIndex = ((int)(resources.GetObject("pbEffort.TabIndex")));
			this.pbEffort.TextboxWidth = ((int)(resources.GetObject("pbEffort.TextboxWidth")));
			this.pbEffort.TokenCount = 10;
			this.pbEffort.UnselectedColor = System.Drawing.Color.Black;
			this.pbEffort.Value = 0;
			this.pbEffort.Visible = ((bool)(resources.GetObject("pbEffort.Visible")));
			this.pbEffort.Changed += new System.EventHandler(this.ChangedEP1);
			// 
			// tbinfluence
			// 
			this.tbinfluence.AccessibleDescription = resources.GetString("tbinfluence.AccessibleDescription");
			this.tbinfluence.AccessibleName = resources.GetString("tbinfluence.AccessibleName");
			this.tbinfluence.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinfluence.Anchor")));
			this.tbinfluence.AutoSize = ((bool)(resources.GetObject("tbinfluence.AutoSize")));
			this.tbinfluence.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinfluence.BackgroundImage")));
			this.tbinfluence.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinfluence.Dock")));
			this.tbinfluence.Enabled = ((bool)(resources.GetObject("tbinfluence.Enabled")));
			this.tbinfluence.Font = ((System.Drawing.Font)(resources.GetObject("tbinfluence.Font")));
			this.tbinfluence.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinfluence.ImeMode")));
			this.tbinfluence.Location = ((System.Drawing.Point)(resources.GetObject("tbinfluence.Location")));
			this.tbinfluence.MaxLength = ((int)(resources.GetObject("tbinfluence.MaxLength")));
			this.tbinfluence.Multiline = ((bool)(resources.GetObject("tbinfluence.Multiline")));
			this.tbinfluence.Name = "tbinfluence";
			this.tbinfluence.PasswordChar = ((char)(resources.GetObject("tbinfluence.PasswordChar")));
			this.tbinfluence.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinfluence.RightToLeft")));
			this.tbinfluence.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinfluence.ScrollBars")));
			this.tbinfluence.Size = ((System.Drawing.Size)(resources.GetObject("tbinfluence.Size")));
			this.tbinfluence.TabIndex = ((int)(resources.GetObject("tbinfluence.TabIndex")));
			this.tbinfluence.Text = resources.GetString("tbinfluence.Text");
			this.tbinfluence.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinfluence.TextAlign")));
			this.tbinfluence.Visible = ((bool)(resources.GetObject("tbinfluence.Visible")));
			this.tbinfluence.WordWrap = ((bool)(resources.GetObject("tbinfluence.WordWrap")));
			this.tbinfluence.TextChanged += new System.EventHandler(this.ChangedEP1);
			// 
			// tbsemester
			// 
			this.tbsemester.AccessibleDescription = resources.GetString("tbsemester.AccessibleDescription");
			this.tbsemester.AccessibleName = resources.GetString("tbsemester.AccessibleName");
			this.tbsemester.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsemester.Anchor")));
			this.tbsemester.AutoSize = ((bool)(resources.GetObject("tbsemester.AutoSize")));
			this.tbsemester.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsemester.BackgroundImage")));
			this.tbsemester.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsemester.Dock")));
			this.tbsemester.Enabled = ((bool)(resources.GetObject("tbsemester.Enabled")));
			this.tbsemester.Font = ((System.Drawing.Font)(resources.GetObject("tbsemester.Font")));
			this.tbsemester.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsemester.ImeMode")));
			this.tbsemester.Location = ((System.Drawing.Point)(resources.GetObject("tbsemester.Location")));
			this.tbsemester.MaxLength = ((int)(resources.GetObject("tbsemester.MaxLength")));
			this.tbsemester.Multiline = ((bool)(resources.GetObject("tbsemester.Multiline")));
			this.tbsemester.Name = "tbsemester";
			this.tbsemester.PasswordChar = ((char)(resources.GetObject("tbsemester.PasswordChar")));
			this.tbsemester.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsemester.RightToLeft")));
			this.tbsemester.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsemester.ScrollBars")));
			this.tbsemester.Size = ((System.Drawing.Size)(resources.GetObject("tbsemester.Size")));
			this.tbsemester.TabIndex = ((int)(resources.GetObject("tbsemester.TabIndex")));
			this.tbsemester.Text = resources.GetString("tbsemester.Text");
			this.tbsemester.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsemester.TextAlign")));
			this.tbsemester.Visible = ((bool)(resources.GetObject("tbsemester.Visible")));
			this.tbsemester.WordWrap = ((bool)(resources.GetObject("tbsemester.WordWrap")));
			this.tbsemester.TextChanged += new System.EventHandler(this.ChangedEP1);
			// 
			// label103
			// 
			this.label103.AccessibleDescription = resources.GetString("label103.AccessibleDescription");
			this.label103.AccessibleName = resources.GetString("label103.AccessibleName");
			this.label103.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label103.Anchor")));
			this.label103.AutoSize = ((bool)(resources.GetObject("label103.AutoSize")));
			this.label103.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label103.Dock")));
			this.label103.Enabled = ((bool)(resources.GetObject("label103.Enabled")));
			this.label103.Font = ((System.Drawing.Font)(resources.GetObject("label103.Font")));
			this.label103.Image = ((System.Drawing.Image)(resources.GetObject("label103.Image")));
			this.label103.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label103.ImageAlign")));
			this.label103.ImageIndex = ((int)(resources.GetObject("label103.ImageIndex")));
			this.label103.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label103.ImeMode")));
			this.label103.Location = ((System.Drawing.Point)(resources.GetObject("label103.Location")));
			this.label103.Name = "label103";
			this.label103.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label103.RightToLeft")));
			this.label103.Size = ((System.Drawing.Size)(resources.GetObject("label103.Size")));
			this.label103.TabIndex = ((int)(resources.GetObject("label103.TabIndex")));
			this.label103.Text = resources.GetString("label103.Text");
			this.label103.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label103.TextAlign")));
			this.label103.Visible = ((bool)(resources.GetObject("label103.Visible")));
			// 
			// label101
			// 
			this.label101.AccessibleDescription = resources.GetString("label101.AccessibleDescription");
			this.label101.AccessibleName = resources.GetString("label101.AccessibleName");
			this.label101.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label101.Anchor")));
			this.label101.AutoSize = ((bool)(resources.GetObject("label101.AutoSize")));
			this.label101.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label101.Dock")));
			this.label101.Enabled = ((bool)(resources.GetObject("label101.Enabled")));
			this.label101.Font = ((System.Drawing.Font)(resources.GetObject("label101.Font")));
			this.label101.Image = ((System.Drawing.Image)(resources.GetObject("label101.Image")));
			this.label101.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label101.ImageAlign")));
			this.label101.ImageIndex = ((int)(resources.GetObject("label101.ImageIndex")));
			this.label101.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label101.ImeMode")));
			this.label101.Location = ((System.Drawing.Point)(resources.GetObject("label101.Location")));
			this.label101.Name = "label101";
			this.label101.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label101.RightToLeft")));
			this.label101.Size = ((System.Drawing.Size)(resources.GetObject("label101.Size")));
			this.label101.TabIndex = ((int)(resources.GetObject("label101.TabIndex")));
			this.label101.Text = resources.GetString("label101.Text");
			this.label101.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label101.TextAlign")));
			this.label101.Visible = ((bool)(resources.GetObject("label101.Visible")));
			// 
			// cboncampus
			// 
			this.cboncampus.AccessibleDescription = resources.GetString("cboncampus.AccessibleDescription");
			this.cboncampus.AccessibleName = resources.GetString("cboncampus.AccessibleName");
			this.cboncampus.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboncampus.Anchor")));
			this.cboncampus.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboncampus.Appearance")));
			this.cboncampus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboncampus.BackgroundImage")));
			this.cboncampus.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboncampus.CheckAlign")));
			this.cboncampus.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboncampus.Dock")));
			this.cboncampus.Enabled = ((bool)(resources.GetObject("cboncampus.Enabled")));
			this.cboncampus.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboncampus.FlatStyle")));
			this.cboncampus.Font = ((System.Drawing.Font)(resources.GetObject("cboncampus.Font")));
			this.cboncampus.Image = ((System.Drawing.Image)(resources.GetObject("cboncampus.Image")));
			this.cboncampus.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboncampus.ImageAlign")));
			this.cboncampus.ImageIndex = ((int)(resources.GetObject("cboncampus.ImageIndex")));
			this.cboncampus.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboncampus.ImeMode")));
			this.cboncampus.Location = ((System.Drawing.Point)(resources.GetObject("cboncampus.Location")));
			this.cboncampus.Name = "cboncampus";
			this.cboncampus.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboncampus.RightToLeft")));
			this.cboncampus.Size = ((System.Drawing.Size)(resources.GetObject("cboncampus.Size")));
			this.cboncampus.TabIndex = ((int)(resources.GetObject("cboncampus.TabIndex")));
			this.cboncampus.Text = resources.GetString("cboncampus.Text");
			this.cboncampus.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboncampus.TextAlign")));
			this.cboncampus.Visible = ((bool)(resources.GetObject("cboncampus.Visible")));
			this.cboncampus.CheckedChanged += new System.EventHandler(this.ChangedEP1);
			// 
			// cbmajor
			// 
			this.cbmajor.AccessibleDescription = resources.GetString("cbmajor.AccessibleDescription");
			this.cbmajor.AccessibleName = resources.GetString("cbmajor.AccessibleName");
			this.cbmajor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbmajor.Anchor")));
			this.cbmajor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmajor.BackgroundImage")));
			this.cbmajor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbmajor.Dock")));
			this.cbmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbmajor.Enabled = ((bool)(resources.GetObject("cbmajor.Enabled")));
			this.cbmajor.Font = ((System.Drawing.Font)(resources.GetObject("cbmajor.Font")));
			this.cbmajor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbmajor.ImeMode")));
			this.cbmajor.IntegralHeight = ((bool)(resources.GetObject("cbmajor.IntegralHeight")));
			this.cbmajor.ItemHeight = ((int)(resources.GetObject("cbmajor.ItemHeight")));
			this.cbmajor.Location = ((System.Drawing.Point)(resources.GetObject("cbmajor.Location")));
			this.cbmajor.MaxDropDownItems = ((int)(resources.GetObject("cbmajor.MaxDropDownItems")));
			this.cbmajor.MaxLength = ((int)(resources.GetObject("cbmajor.MaxLength")));
			this.cbmajor.Name = "cbmajor";
			this.cbmajor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbmajor.RightToLeft")));
			this.cbmajor.Size = ((System.Drawing.Size)(resources.GetObject("cbmajor.Size")));
			this.cbmajor.TabIndex = ((int)(resources.GetObject("cbmajor.TabIndex")));
			this.cbmajor.Text = resources.GetString("cbmajor.Text");
			this.cbmajor.Visible = ((bool)(resources.GetObject("cbmajor.Visible")));
			this.cbmajor.SelectedIndexChanged += new System.EventHandler(this.cbmajor_SelectedIndexChanged);
			// 
			// label98
			// 
			this.label98.AccessibleDescription = resources.GetString("label98.AccessibleDescription");
			this.label98.AccessibleName = resources.GetString("label98.AccessibleName");
			this.label98.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label98.Anchor")));
			this.label98.AutoSize = ((bool)(resources.GetObject("label98.AutoSize")));
			this.label98.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label98.Dock")));
			this.label98.Enabled = ((bool)(resources.GetObject("label98.Enabled")));
			this.label98.Font = ((System.Drawing.Font)(resources.GetObject("label98.Font")));
			this.label98.Image = ((System.Drawing.Image)(resources.GetObject("label98.Image")));
			this.label98.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label98.ImageAlign")));
			this.label98.ImageIndex = ((int)(resources.GetObject("label98.ImageIndex")));
			this.label98.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label98.ImeMode")));
			this.label98.Location = ((System.Drawing.Point)(resources.GetObject("label98.Location")));
			this.label98.Name = "label98";
			this.label98.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label98.RightToLeft")));
			this.label98.Size = ((System.Drawing.Size)(resources.GetObject("label98.Size")));
			this.label98.TabIndex = ((int)(resources.GetObject("label98.TabIndex")));
			this.label98.Text = resources.GetString("label98.Text");
			this.label98.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label98.TextAlign")));
			this.label98.Visible = ((bool)(resources.GetObject("label98.Visible")));
			// 
			// tbmajor
			// 
			this.tbmajor.AccessibleDescription = resources.GetString("tbmajor.AccessibleDescription");
			this.tbmajor.AccessibleName = resources.GetString("tbmajor.AccessibleName");
			this.tbmajor.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmajor.Anchor")));
			this.tbmajor.AutoSize = ((bool)(resources.GetObject("tbmajor.AutoSize")));
			this.tbmajor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmajor.BackgroundImage")));
			this.tbmajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbmajor.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmajor.Dock")));
			this.tbmajor.Enabled = ((bool)(resources.GetObject("tbmajor.Enabled")));
			this.tbmajor.Font = ((System.Drawing.Font)(resources.GetObject("tbmajor.Font")));
			this.tbmajor.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmajor.ImeMode")));
			this.tbmajor.Location = ((System.Drawing.Point)(resources.GetObject("tbmajor.Location")));
			this.tbmajor.MaxLength = ((int)(resources.GetObject("tbmajor.MaxLength")));
			this.tbmajor.Multiline = ((bool)(resources.GetObject("tbmajor.Multiline")));
			this.tbmajor.Name = "tbmajor";
			this.tbmajor.PasswordChar = ((char)(resources.GetObject("tbmajor.PasswordChar")));
			this.tbmajor.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmajor.RightToLeft")));
			this.tbmajor.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmajor.ScrollBars")));
			this.tbmajor.Size = ((System.Drawing.Size)(resources.GetObject("tbmajor.Size")));
			this.tbmajor.TabIndex = ((int)(resources.GetObject("tbmajor.TabIndex")));
			this.tbmajor.Text = resources.GetString("tbmajor.Text");
			this.tbmajor.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmajor.TextAlign")));
			this.tbmajor.Visible = ((bool)(resources.GetObject("tbmajor.Visible")));
			this.tbmajor.WordWrap = ((bool)(resources.GetObject("tbmajor.WordWrap")));
			this.tbmajor.TextChanged += new System.EventHandler(this.ChangedEP1);
			// 
			// pnEP2
			// 
			this.pnEP2.AccessibleDescription = resources.GetString("pnEP2.AccessibleDescription");
			this.pnEP2.AccessibleName = resources.GetString("pnEP2.AccessibleName");
			this.pnEP2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnEP2.Anchor")));
			this.pnEP2.AutoScroll = ((bool)(resources.GetObject("pnEP2.AutoScroll")));
			this.pnEP2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnEP2.AutoScrollMargin")));
			this.pnEP2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnEP2.AutoScrollMinSize")));
			this.pnEP2.BackColor = System.Drawing.Color.Transparent;
			this.pnEP2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEP2.BackgroundImage")));
			this.pnEP2.Controls.Add(this.tbNTLove);
			this.pnEP2.Controls.Add(this.tbNTPerfume);
			this.pnEP2.Controls.Add(this.label8);
			this.pnEP2.Controls.Add(this.label7);
			this.pnEP2.Controls.Add(this.lbTurnOff);
			this.pnEP2.Controls.Add(this.label6);
			this.pnEP2.Controls.Add(this.lbTurnOn);
			this.pnEP2.Controls.Add(this.label5);
			this.pnEP2.Controls.Add(this.lbTraits);
			this.pnEP2.Controls.Add(this.label4);
			this.pnEP2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnEP2.Dock")));
			this.pnEP2.Enabled = ((bool)(resources.GetObject("pnEP2.Enabled")));
			this.pnEP2.Font = ((System.Drawing.Font)(resources.GetObject("pnEP2.Font")));
			this.pnEP2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnEP2.ImeMode")));
			this.pnEP2.Location = ((System.Drawing.Point)(resources.GetObject("pnEP2.Location")));
			this.pnEP2.Name = "pnEP2";
			this.pnEP2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnEP2.RightToLeft")));
			this.pnEP2.Size = ((System.Drawing.Size)(resources.GetObject("pnEP2.Size")));
			this.pnEP2.TabIndex = ((int)(resources.GetObject("pnEP2.TabIndex")));
			this.pnEP2.Text = resources.GetString("pnEP2.Text");
			this.pnEP2.Visible = ((bool)(resources.GetObject("pnEP2.Visible")));
			// 
			// tbNTLove
			// 
			this.tbNTLove.AccessibleDescription = resources.GetString("tbNTLove.AccessibleDescription");
			this.tbNTLove.AccessibleName = resources.GetString("tbNTLove.AccessibleName");
			this.tbNTLove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbNTLove.Anchor")));
			this.tbNTLove.AutoSize = ((bool)(resources.GetObject("tbNTLove.AutoSize")));
			this.tbNTLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbNTLove.BackgroundImage")));
			this.tbNTLove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbNTLove.Dock")));
			this.tbNTLove.Enabled = ((bool)(resources.GetObject("tbNTLove.Enabled")));
			this.tbNTLove.Font = ((System.Drawing.Font)(resources.GetObject("tbNTLove.Font")));
			this.tbNTLove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbNTLove.ImeMode")));
			this.tbNTLove.Location = ((System.Drawing.Point)(resources.GetObject("tbNTLove.Location")));
			this.tbNTLove.MaxLength = ((int)(resources.GetObject("tbNTLove.MaxLength")));
			this.tbNTLove.Multiline = ((bool)(resources.GetObject("tbNTLove.Multiline")));
			this.tbNTLove.Name = "tbNTLove";
			this.tbNTLove.PasswordChar = ((char)(resources.GetObject("tbNTLove.PasswordChar")));
			this.tbNTLove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbNTLove.RightToLeft")));
			this.tbNTLove.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbNTLove.ScrollBars")));
			this.tbNTLove.Size = ((System.Drawing.Size)(resources.GetObject("tbNTLove.Size")));
			this.tbNTLove.TabIndex = ((int)(resources.GetObject("tbNTLove.TabIndex")));
			this.tbNTLove.Text = resources.GetString("tbNTLove.Text");
			this.tbNTLove.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbNTLove.TextAlign")));
			this.tbNTLove.Visible = ((bool)(resources.GetObject("tbNTLove.Visible")));
			this.tbNTLove.WordWrap = ((bool)(resources.GetObject("tbNTLove.WordWrap")));
			this.tbNTLove.TextChanged += new System.EventHandler(this.ChangedEP2);
			// 
			// tbNTPerfume
			// 
			this.tbNTPerfume.AccessibleDescription = resources.GetString("tbNTPerfume.AccessibleDescription");
			this.tbNTPerfume.AccessibleName = resources.GetString("tbNTPerfume.AccessibleName");
			this.tbNTPerfume.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbNTPerfume.Anchor")));
			this.tbNTPerfume.AutoSize = ((bool)(resources.GetObject("tbNTPerfume.AutoSize")));
			this.tbNTPerfume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbNTPerfume.BackgroundImage")));
			this.tbNTPerfume.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbNTPerfume.Dock")));
			this.tbNTPerfume.Enabled = ((bool)(resources.GetObject("tbNTPerfume.Enabled")));
			this.tbNTPerfume.Font = ((System.Drawing.Font)(resources.GetObject("tbNTPerfume.Font")));
			this.tbNTPerfume.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbNTPerfume.ImeMode")));
			this.tbNTPerfume.Location = ((System.Drawing.Point)(resources.GetObject("tbNTPerfume.Location")));
			this.tbNTPerfume.MaxLength = ((int)(resources.GetObject("tbNTPerfume.MaxLength")));
			this.tbNTPerfume.Multiline = ((bool)(resources.GetObject("tbNTPerfume.Multiline")));
			this.tbNTPerfume.Name = "tbNTPerfume";
			this.tbNTPerfume.PasswordChar = ((char)(resources.GetObject("tbNTPerfume.PasswordChar")));
			this.tbNTPerfume.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbNTPerfume.RightToLeft")));
			this.tbNTPerfume.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbNTPerfume.ScrollBars")));
			this.tbNTPerfume.Size = ((System.Drawing.Size)(resources.GetObject("tbNTPerfume.Size")));
			this.tbNTPerfume.TabIndex = ((int)(resources.GetObject("tbNTPerfume.TabIndex")));
			this.tbNTPerfume.Text = resources.GetString("tbNTPerfume.Text");
			this.tbNTPerfume.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbNTPerfume.TextAlign")));
			this.tbNTPerfume.Visible = ((bool)(resources.GetObject("tbNTPerfume.Visible")));
			this.tbNTPerfume.WordWrap = ((bool)(resources.GetObject("tbNTPerfume.WordWrap")));
			this.tbNTPerfume.TextChanged += new System.EventHandler(this.ChangedEP2);
			// 
			// label8
			// 
			this.label8.AccessibleDescription = resources.GetString("label8.AccessibleDescription");
			this.label8.AccessibleName = resources.GetString("label8.AccessibleName");
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label8.Anchor")));
			this.label8.AutoSize = ((bool)(resources.GetObject("label8.AutoSize")));
			this.label8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label8.Dock")));
			this.label8.Enabled = ((bool)(resources.GetObject("label8.Enabled")));
			this.label8.Font = ((System.Drawing.Font)(resources.GetObject("label8.Font")));
			this.label8.Image = ((System.Drawing.Image)(resources.GetObject("label8.Image")));
			this.label8.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.ImageAlign")));
			this.label8.ImageIndex = ((int)(resources.GetObject("label8.ImageIndex")));
			this.label8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label8.ImeMode")));
			this.label8.Location = ((System.Drawing.Point)(resources.GetObject("label8.Location")));
			this.label8.Name = "label8";
			this.label8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label8.RightToLeft")));
			this.label8.Size = ((System.Drawing.Size)(resources.GetObject("label8.Size")));
			this.label8.TabIndex = ((int)(resources.GetObject("label8.TabIndex")));
			this.label8.Text = resources.GetString("label8.Text");
			this.label8.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label8.TextAlign")));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			// 
			// label7
			// 
			this.label7.AccessibleDescription = resources.GetString("label7.AccessibleDescription");
			this.label7.AccessibleName = resources.GetString("label7.AccessibleName");
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label7.Anchor")));
			this.label7.AutoSize = ((bool)(resources.GetObject("label7.AutoSize")));
			this.label7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label7.Dock")));
			this.label7.Enabled = ((bool)(resources.GetObject("label7.Enabled")));
			this.label7.Font = ((System.Drawing.Font)(resources.GetObject("label7.Font")));
			this.label7.Image = ((System.Drawing.Image)(resources.GetObject("label7.Image")));
			this.label7.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.ImageAlign")));
			this.label7.ImageIndex = ((int)(resources.GetObject("label7.ImageIndex")));
			this.label7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label7.ImeMode")));
			this.label7.Location = ((System.Drawing.Point)(resources.GetObject("label7.Location")));
			this.label7.Name = "label7";
			this.label7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label7.RightToLeft")));
			this.label7.Size = ((System.Drawing.Size)(resources.GetObject("label7.Size")));
			this.label7.TabIndex = ((int)(resources.GetObject("label7.TabIndex")));
			this.label7.Text = resources.GetString("label7.Text");
			this.label7.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label7.TextAlign")));
			this.label7.Visible = ((bool)(resources.GetObject("label7.Visible")));
			// 
			// lbTurnOff
			// 
			this.lbTurnOff.AccessibleDescription = resources.GetString("lbTurnOff.AccessibleDescription");
			this.lbTurnOff.AccessibleName = resources.GetString("lbTurnOff.AccessibleName");
			this.lbTurnOff.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbTurnOff.Anchor")));
			this.lbTurnOff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbTurnOff.BackgroundImage")));
			this.lbTurnOff.ColumnWidth = ((int)(resources.GetObject("lbTurnOff.ColumnWidth")));
			this.lbTurnOff.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbTurnOff.Dock")));
			this.lbTurnOff.Enabled = ((bool)(resources.GetObject("lbTurnOff.Enabled")));
			this.lbTurnOff.Font = ((System.Drawing.Font)(resources.GetObject("lbTurnOff.Font")));
			this.lbTurnOff.HorizontalExtent = ((int)(resources.GetObject("lbTurnOff.HorizontalExtent")));
			this.lbTurnOff.HorizontalScrollbar = ((bool)(resources.GetObject("lbTurnOff.HorizontalScrollbar")));
			this.lbTurnOff.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbTurnOff.ImeMode")));
			this.lbTurnOff.IntegralHeight = ((bool)(resources.GetObject("lbTurnOff.IntegralHeight")));
			this.lbTurnOff.Location = ((System.Drawing.Point)(resources.GetObject("lbTurnOff.Location")));
			this.lbTurnOff.Name = "lbTurnOff";
			this.lbTurnOff.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbTurnOff.RightToLeft")));
			this.lbTurnOff.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbTurnOff.ScrollAlwaysVisible")));
			this.lbTurnOff.Size = ((System.Drawing.Size)(resources.GetObject("lbTurnOff.Size")));
			this.lbTurnOff.TabIndex = ((int)(resources.GetObject("lbTurnOff.TabIndex")));
			this.lbTurnOff.Visible = ((bool)(resources.GetObject("lbTurnOff.Visible")));
			this.lbTurnOff.SelectedIndexChanged += new System.EventHandler(this.lbTurnOff_SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.AccessibleDescription = resources.GetString("label6.AccessibleDescription");
			this.label6.AccessibleName = resources.GetString("label6.AccessibleName");
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label6.Anchor")));
			this.label6.AutoSize = ((bool)(resources.GetObject("label6.AutoSize")));
			this.label6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label6.Dock")));
			this.label6.Enabled = ((bool)(resources.GetObject("label6.Enabled")));
			this.label6.Font = ((System.Drawing.Font)(resources.GetObject("label6.Font")));
			this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
			this.label6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.ImageAlign")));
			this.label6.ImageIndex = ((int)(resources.GetObject("label6.ImageIndex")));
			this.label6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label6.ImeMode")));
			this.label6.Location = ((System.Drawing.Point)(resources.GetObject("label6.Location")));
			this.label6.Name = "label6";
			this.label6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label6.RightToLeft")));
			this.label6.Size = ((System.Drawing.Size)(resources.GetObject("label6.Size")));
			this.label6.TabIndex = ((int)(resources.GetObject("label6.TabIndex")));
			this.label6.Text = resources.GetString("label6.Text");
			this.label6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label6.TextAlign")));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			// 
			// lbTurnOn
			// 
			this.lbTurnOn.AccessibleDescription = resources.GetString("lbTurnOn.AccessibleDescription");
			this.lbTurnOn.AccessibleName = resources.GetString("lbTurnOn.AccessibleName");
			this.lbTurnOn.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbTurnOn.Anchor")));
			this.lbTurnOn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbTurnOn.BackgroundImage")));
			this.lbTurnOn.ColumnWidth = ((int)(resources.GetObject("lbTurnOn.ColumnWidth")));
			this.lbTurnOn.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbTurnOn.Dock")));
			this.lbTurnOn.Enabled = ((bool)(resources.GetObject("lbTurnOn.Enabled")));
			this.lbTurnOn.Font = ((System.Drawing.Font)(resources.GetObject("lbTurnOn.Font")));
			this.lbTurnOn.HorizontalExtent = ((int)(resources.GetObject("lbTurnOn.HorizontalExtent")));
			this.lbTurnOn.HorizontalScrollbar = ((bool)(resources.GetObject("lbTurnOn.HorizontalScrollbar")));
			this.lbTurnOn.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbTurnOn.ImeMode")));
			this.lbTurnOn.IntegralHeight = ((bool)(resources.GetObject("lbTurnOn.IntegralHeight")));
			this.lbTurnOn.Location = ((System.Drawing.Point)(resources.GetObject("lbTurnOn.Location")));
			this.lbTurnOn.Name = "lbTurnOn";
			this.lbTurnOn.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbTurnOn.RightToLeft")));
			this.lbTurnOn.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbTurnOn.ScrollAlwaysVisible")));
			this.lbTurnOn.Size = ((System.Drawing.Size)(resources.GetObject("lbTurnOn.Size")));
			this.lbTurnOn.TabIndex = ((int)(resources.GetObject("lbTurnOn.TabIndex")));
			this.lbTurnOn.Visible = ((bool)(resources.GetObject("lbTurnOn.Visible")));
			this.lbTurnOn.SelectedIndexChanged += new System.EventHandler(this.lbTurnOn_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AccessibleDescription = resources.GetString("label5.AccessibleDescription");
			this.label5.AccessibleName = resources.GetString("label5.AccessibleName");
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label5.Anchor")));
			this.label5.AutoSize = ((bool)(resources.GetObject("label5.AutoSize")));
			this.label5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label5.Dock")));
			this.label5.Enabled = ((bool)(resources.GetObject("label5.Enabled")));
			this.label5.Font = ((System.Drawing.Font)(resources.GetObject("label5.Font")));
			this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
			this.label5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.ImageAlign")));
			this.label5.ImageIndex = ((int)(resources.GetObject("label5.ImageIndex")));
			this.label5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label5.ImeMode")));
			this.label5.Location = ((System.Drawing.Point)(resources.GetObject("label5.Location")));
			this.label5.Name = "label5";
			this.label5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label5.RightToLeft")));
			this.label5.Size = ((System.Drawing.Size)(resources.GetObject("label5.Size")));
			this.label5.TabIndex = ((int)(resources.GetObject("label5.TabIndex")));
			this.label5.Text = resources.GetString("label5.Text");
			this.label5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label5.TextAlign")));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			// 
			// lbTraits
			// 
			this.lbTraits.AccessibleDescription = resources.GetString("lbTraits.AccessibleDescription");
			this.lbTraits.AccessibleName = resources.GetString("lbTraits.AccessibleName");
			this.lbTraits.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbTraits.Anchor")));
			this.lbTraits.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbTraits.BackgroundImage")));
			this.lbTraits.ColumnWidth = ((int)(resources.GetObject("lbTraits.ColumnWidth")));
			this.lbTraits.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbTraits.Dock")));
			this.lbTraits.Enabled = ((bool)(resources.GetObject("lbTraits.Enabled")));
			this.lbTraits.Font = ((System.Drawing.Font)(resources.GetObject("lbTraits.Font")));
			this.lbTraits.HorizontalExtent = ((int)(resources.GetObject("lbTraits.HorizontalExtent")));
			this.lbTraits.HorizontalScrollbar = ((bool)(resources.GetObject("lbTraits.HorizontalScrollbar")));
			this.lbTraits.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbTraits.ImeMode")));
			this.lbTraits.IntegralHeight = ((bool)(resources.GetObject("lbTraits.IntegralHeight")));
			this.lbTraits.Location = ((System.Drawing.Point)(resources.GetObject("lbTraits.Location")));
			this.lbTraits.Name = "lbTraits";
			this.lbTraits.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbTraits.RightToLeft")));
			this.lbTraits.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbTraits.ScrollAlwaysVisible")));
			this.lbTraits.Size = ((System.Drawing.Size)(resources.GetObject("lbTraits.Size")));
			this.lbTraits.TabIndex = ((int)(resources.GetObject("lbTraits.TabIndex")));
			this.lbTraits.Visible = ((bool)(resources.GetObject("lbTraits.Visible")));
			this.lbTraits.SelectedIndexChanged += new System.EventHandler(this.lbTraits_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AccessibleDescription = resources.GetString("label4.AccessibleDescription");
			this.label4.AccessibleName = resources.GetString("label4.AccessibleName");
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label4.Anchor")));
			this.label4.AutoSize = ((bool)(resources.GetObject("label4.AutoSize")));
			this.label4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label4.Dock")));
			this.label4.Enabled = ((bool)(resources.GetObject("label4.Enabled")));
			this.label4.Font = ((System.Drawing.Font)(resources.GetObject("label4.Font")));
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.ImageAlign")));
			this.label4.ImageIndex = ((int)(resources.GetObject("label4.ImageIndex")));
			this.label4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label4.ImeMode")));
			this.label4.Location = ((System.Drawing.Point)(resources.GetObject("label4.Location")));
			this.label4.Name = "label4";
			this.label4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label4.RightToLeft")));
			this.label4.Size = ((System.Drawing.Size)(resources.GetObject("label4.Size")));
			this.label4.TabIndex = ((int)(resources.GetObject("label4.TabIndex")));
			this.label4.Text = resources.GetString("label4.Text");
			this.label4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label4.TextAlign")));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			// 
			// pnEP3
			// 
			this.pnEP3.AccessibleDescription = resources.GetString("pnEP3.AccessibleDescription");
			this.pnEP3.AccessibleName = resources.GetString("pnEP3.AccessibleName");
			this.pnEP3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnEP3.Anchor")));
			this.pnEP3.AutoScroll = ((bool)(resources.GetObject("pnEP3.AutoScroll")));
			this.pnEP3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnEP3.AutoScrollMargin")));
			this.pnEP3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnEP3.AutoScrollMinSize")));
			this.pnEP3.BackColor = System.Drawing.Color.Transparent;
			this.pnEP3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnEP3.BackgroundImage")));
			this.pnEP3.Controls.Add(this.pictureBox1);
			this.pnEP3.Controls.Add(this.llep3openinfo);
			this.pnEP3.Controls.Add(this.label15);
			this.pnEP3.Controls.Add(this.sblb);
			this.pnEP3.Controls.Add(this.tbEp3Salery);
			this.pnEP3.Controls.Add(this.label14);
			this.pnEP3.Controls.Add(this.label12);
			this.pnEP3.Controls.Add(this.cbEp3Asgn);
			this.pnEP3.Controls.Add(this.tbEp3Flag);
			this.pnEP3.Controls.Add(this.tbEp3Lot);
			this.pnEP3.Controls.Add(this.label9);
			this.pnEP3.Controls.Add(this.label11);
			this.pnEP3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnEP3.Dock")));
			this.pnEP3.Enabled = ((bool)(resources.GetObject("pnEP3.Enabled")));
			this.pnEP3.Font = ((System.Drawing.Font)(resources.GetObject("pnEP3.Font")));
			this.pnEP3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnEP3.ImeMode")));
			this.pnEP3.Location = ((System.Drawing.Point)(resources.GetObject("pnEP3.Location")));
			this.pnEP3.Name = "pnEP3";
			this.pnEP3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnEP3.RightToLeft")));
			this.pnEP3.Size = ((System.Drawing.Size)(resources.GetObject("pnEP3.Size")));
			this.pnEP3.TabIndex = ((int)(resources.GetObject("pnEP3.TabIndex")));
			this.pnEP3.Text = resources.GetString("pnEP3.Text");
			this.pnEP3.Visible = ((bool)(resources.GetObject("pnEP3.Visible")));
			// 
			// pictureBox1
			// 
			this.pictureBox1.AccessibleDescription = resources.GetString("pictureBox1.AccessibleDescription");
			this.pictureBox1.AccessibleName = resources.GetString("pictureBox1.AccessibleName");
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pictureBox1.Anchor")));
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pictureBox1.Dock")));
			this.pictureBox1.Enabled = ((bool)(resources.GetObject("pictureBox1.Enabled")));
			this.pictureBox1.Font = ((System.Drawing.Font)(resources.GetObject("pictureBox1.Font")));
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pictureBox1.ImeMode")));
			this.pictureBox1.Location = ((System.Drawing.Point)(resources.GetObject("pictureBox1.Location")));
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pictureBox1.RightToLeft")));
			this.pictureBox1.Size = ((System.Drawing.Size)(resources.GetObject("pictureBox1.Size")));
			this.pictureBox1.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pictureBox1.SizeMode")));
			this.pictureBox1.TabIndex = ((int)(resources.GetObject("pictureBox1.TabIndex")));
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Text = resources.GetString("pictureBox1.Text");
			this.pictureBox1.Visible = ((bool)(resources.GetObject("pictureBox1.Visible")));
			// 
			// llep3openinfo
			// 
			this.llep3openinfo.AccessibleDescription = resources.GetString("llep3openinfo.AccessibleDescription");
			this.llep3openinfo.AccessibleName = resources.GetString("llep3openinfo.AccessibleName");
			this.llep3openinfo.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llep3openinfo.Anchor")));
			this.llep3openinfo.AutoSize = ((bool)(resources.GetObject("llep3openinfo.AutoSize")));
			this.llep3openinfo.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llep3openinfo.Dock")));
			this.llep3openinfo.Enabled = ((bool)(resources.GetObject("llep3openinfo.Enabled")));
			this.llep3openinfo.Font = ((System.Drawing.Font)(resources.GetObject("llep3openinfo.Font")));
			this.llep3openinfo.Image = ((System.Drawing.Image)(resources.GetObject("llep3openinfo.Image")));
			this.llep3openinfo.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llep3openinfo.ImageAlign")));
			this.llep3openinfo.ImageIndex = ((int)(resources.GetObject("llep3openinfo.ImageIndex")));
			this.llep3openinfo.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llep3openinfo.ImeMode")));
			this.llep3openinfo.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llep3openinfo.LinkArea")));
			this.llep3openinfo.Location = ((System.Drawing.Point)(resources.GetObject("llep3openinfo.Location")));
			this.llep3openinfo.Name = "llep3openinfo";
			this.llep3openinfo.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llep3openinfo.RightToLeft")));
			this.llep3openinfo.Size = ((System.Drawing.Size)(resources.GetObject("llep3openinfo.Size")));
			this.llep3openinfo.TabIndex = ((int)(resources.GetObject("llep3openinfo.TabIndex")));
			this.llep3openinfo.TabStop = true;
			this.llep3openinfo.Text = resources.GetString("llep3openinfo.Text");
			this.llep3openinfo.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llep3openinfo.TextAlign")));
			this.llep3openinfo.Visible = ((bool)(resources.GetObject("llep3openinfo.Visible")));
			this.llep3openinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llep3openinfo_LinkClicked);
			// 
			// label15
			// 
			this.label15.AccessibleDescription = resources.GetString("label15.AccessibleDescription");
			this.label15.AccessibleName = resources.GetString("label15.AccessibleName");
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label15.Anchor")));
			this.label15.AutoSize = ((bool)(resources.GetObject("label15.AutoSize")));
			this.label15.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label15.Dock")));
			this.label15.Enabled = ((bool)(resources.GetObject("label15.Enabled")));
			this.label15.Font = ((System.Drawing.Font)(resources.GetObject("label15.Font")));
			this.label15.Image = ((System.Drawing.Image)(resources.GetObject("label15.Image")));
			this.label15.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label15.ImageAlign")));
			this.label15.ImageIndex = ((int)(resources.GetObject("label15.ImageIndex")));
			this.label15.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label15.ImeMode")));
			this.label15.Location = ((System.Drawing.Point)(resources.GetObject("label15.Location")));
			this.label15.Name = "label15";
			this.label15.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label15.RightToLeft")));
			this.label15.Size = ((System.Drawing.Size)(resources.GetObject("label15.Size")));
			this.label15.TabIndex = ((int)(resources.GetObject("label15.TabIndex")));
			this.label15.Text = resources.GetString("label15.Text");
			this.label15.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label15.TextAlign")));
			this.label15.Visible = ((bool)(resources.GetObject("label15.Visible")));
			// 
			// sblb
			// 
			this.sblb.AccessibleDescription = resources.GetString("sblb.AccessibleDescription");
			this.sblb.AccessibleName = resources.GetString("sblb.AccessibleName");
			this.sblb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("sblb.Anchor")));
			this.sblb.AutoScroll = ((bool)(resources.GetObject("sblb.AutoScroll")));
			this.sblb.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("sblb.AutoScrollMargin")));
			this.sblb.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("sblb.AutoScrollMinSize")));
			this.sblb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sblb.BackgroundImage")));
			this.sblb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("sblb.Dock")));
			this.sblb.Enabled = ((bool)(resources.GetObject("sblb.Enabled")));
			this.sblb.Font = ((System.Drawing.Font)(resources.GetObject("sblb.Font")));
			this.sblb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("sblb.ImeMode")));
			this.sblb.Location = ((System.Drawing.Point)(resources.GetObject("sblb.Location")));
			this.sblb.Name = "sblb";
			this.sblb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("sblb.RightToLeft")));
			this.sblb.SimDescription = null;
			this.sblb.Size = ((System.Drawing.Size)(resources.GetObject("sblb.Size")));
			this.sblb.TabIndex = ((int)(resources.GetObject("sblb.TabIndex")));
			this.sblb.Visible = ((bool)(resources.GetObject("sblb.Visible")));
			this.sblb.SelectedBusinessChanged += new System.EventHandler(this.sblb_SelectedBusinessChanged);
			// 
			// tbEp3Salery
			// 
			this.tbEp3Salery.AccessibleDescription = resources.GetString("tbEp3Salery.AccessibleDescription");
			this.tbEp3Salery.AccessibleName = resources.GetString("tbEp3Salery.AccessibleName");
			this.tbEp3Salery.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbEp3Salery.Anchor")));
			this.tbEp3Salery.AutoSize = ((bool)(resources.GetObject("tbEp3Salery.AutoSize")));
			this.tbEp3Salery.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEp3Salery.BackgroundImage")));
			this.tbEp3Salery.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbEp3Salery.Dock")));
			this.tbEp3Salery.Enabled = ((bool)(resources.GetObject("tbEp3Salery.Enabled")));
			this.tbEp3Salery.Font = ((System.Drawing.Font)(resources.GetObject("tbEp3Salery.Font")));
			this.tbEp3Salery.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbEp3Salery.ImeMode")));
			this.tbEp3Salery.Location = ((System.Drawing.Point)(resources.GetObject("tbEp3Salery.Location")));
			this.tbEp3Salery.MaxLength = ((int)(resources.GetObject("tbEp3Salery.MaxLength")));
			this.tbEp3Salery.Multiline = ((bool)(resources.GetObject("tbEp3Salery.Multiline")));
			this.tbEp3Salery.Name = "tbEp3Salery";
			this.tbEp3Salery.PasswordChar = ((char)(resources.GetObject("tbEp3Salery.PasswordChar")));
			this.tbEp3Salery.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbEp3Salery.RightToLeft")));
			this.tbEp3Salery.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbEp3Salery.ScrollBars")));
			this.tbEp3Salery.Size = ((System.Drawing.Size)(resources.GetObject("tbEp3Salery.Size")));
			this.tbEp3Salery.TabIndex = ((int)(resources.GetObject("tbEp3Salery.TabIndex")));
			this.tbEp3Salery.Text = resources.GetString("tbEp3Salery.Text");
			this.tbEp3Salery.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbEp3Salery.TextAlign")));
			this.tbEp3Salery.Visible = ((bool)(resources.GetObject("tbEp3Salery.Visible")));
			this.tbEp3Salery.WordWrap = ((bool)(resources.GetObject("tbEp3Salery.WordWrap")));
			this.tbEp3Salery.TextChanged += new System.EventHandler(this.ChangedEP3);
			// 
			// label14
			// 
			this.label14.AccessibleDescription = resources.GetString("label14.AccessibleDescription");
			this.label14.AccessibleName = resources.GetString("label14.AccessibleName");
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label14.Anchor")));
			this.label14.AutoSize = ((bool)(resources.GetObject("label14.AutoSize")));
			this.label14.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label14.Dock")));
			this.label14.Enabled = ((bool)(resources.GetObject("label14.Enabled")));
			this.label14.Font = ((System.Drawing.Font)(resources.GetObject("label14.Font")));
			this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
			this.label14.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.ImageAlign")));
			this.label14.ImageIndex = ((int)(resources.GetObject("label14.ImageIndex")));
			this.label14.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label14.ImeMode")));
			this.label14.Location = ((System.Drawing.Point)(resources.GetObject("label14.Location")));
			this.label14.Name = "label14";
			this.label14.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label14.RightToLeft")));
			this.label14.Size = ((System.Drawing.Size)(resources.GetObject("label14.Size")));
			this.label14.TabIndex = ((int)(resources.GetObject("label14.TabIndex")));
			this.label14.Text = resources.GetString("label14.Text");
			this.label14.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label14.TextAlign")));
			this.label14.Visible = ((bool)(resources.GetObject("label14.Visible")));
			// 
			// label12
			// 
			this.label12.AccessibleDescription = resources.GetString("label12.AccessibleDescription");
			this.label12.AccessibleName = resources.GetString("label12.AccessibleName");
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label12.Anchor")));
			this.label12.AutoSize = ((bool)(resources.GetObject("label12.AutoSize")));
			this.label12.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label12.Dock")));
			this.label12.Enabled = ((bool)(resources.GetObject("label12.Enabled")));
			this.label12.Font = ((System.Drawing.Font)(resources.GetObject("label12.Font")));
			this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
			this.label12.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.ImageAlign")));
			this.label12.ImageIndex = ((int)(resources.GetObject("label12.ImageIndex")));
			this.label12.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label12.ImeMode")));
			this.label12.Location = ((System.Drawing.Point)(resources.GetObject("label12.Location")));
			this.label12.Name = "label12";
			this.label12.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label12.RightToLeft")));
			this.label12.Size = ((System.Drawing.Size)(resources.GetObject("label12.Size")));
			this.label12.TabIndex = ((int)(resources.GetObject("label12.TabIndex")));
			this.label12.Text = resources.GetString("label12.Text");
			this.label12.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label12.TextAlign")));
			this.label12.Visible = ((bool)(resources.GetObject("label12.Visible")));
			// 
			// cbEp3Asgn
			// 
			this.cbEp3Asgn.AccessibleDescription = resources.GetString("cbEp3Asgn.AccessibleDescription");
			this.cbEp3Asgn.AccessibleName = resources.GetString("cbEp3Asgn.AccessibleName");
			this.cbEp3Asgn.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbEp3Asgn.Anchor")));
			this.cbEp3Asgn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbEp3Asgn.BackgroundImage")));
			this.cbEp3Asgn.DefaultText = resources.GetString("cbEp3Asgn.DefaultText");
			this.cbEp3Asgn.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbEp3Asgn.Dock")));
			this.cbEp3Asgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEp3Asgn.Enabled = ((bool)(resources.GetObject("cbEp3Asgn.Enabled")));
			this.cbEp3Asgn.Enum = null;
			this.cbEp3Asgn.Font = ((System.Drawing.Font)(resources.GetObject("cbEp3Asgn.Font")));
			this.cbEp3Asgn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cbEp3Asgn.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbEp3Asgn.ImeMode")));
			this.cbEp3Asgn.IntegralHeight = ((bool)(resources.GetObject("cbEp3Asgn.IntegralHeight")));
			this.cbEp3Asgn.ItemHeight = ((int)(resources.GetObject("cbEp3Asgn.ItemHeight")));
			this.cbEp3Asgn.Location = ((System.Drawing.Point)(resources.GetObject("cbEp3Asgn.Location")));
			this.cbEp3Asgn.MaxDropDownItems = ((int)(resources.GetObject("cbEp3Asgn.MaxDropDownItems")));
			this.cbEp3Asgn.MaxLength = ((int)(resources.GetObject("cbEp3Asgn.MaxLength")));
			this.cbEp3Asgn.Name = "cbEp3Asgn";
			this.cbEp3Asgn.ResourceManager = null;
			this.cbEp3Asgn.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbEp3Asgn.RightToLeft")));
			this.cbEp3Asgn.Size = ((System.Drawing.Size)(resources.GetObject("cbEp3Asgn.Size")));
			this.cbEp3Asgn.TabIndex = ((int)(resources.GetObject("cbEp3Asgn.TabIndex")));
			this.cbEp3Asgn.Text = resources.GetString("cbEp3Asgn.Text");
			this.cbEp3Asgn.Visible = ((bool)(resources.GetObject("cbEp3Asgn.Visible")));
			this.cbEp3Asgn.SelectedValueChanged += new System.EventHandler(this.ChangedEP3);
			// 
			// tbEp3Flag
			// 
			this.tbEp3Flag.AccessibleDescription = resources.GetString("tbEp3Flag.AccessibleDescription");
			this.tbEp3Flag.AccessibleName = resources.GetString("tbEp3Flag.AccessibleName");
			this.tbEp3Flag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbEp3Flag.Anchor")));
			this.tbEp3Flag.AutoSize = ((bool)(resources.GetObject("tbEp3Flag.AutoSize")));
			this.tbEp3Flag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEp3Flag.BackgroundImage")));
			this.tbEp3Flag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbEp3Flag.Dock")));
			this.tbEp3Flag.Enabled = ((bool)(resources.GetObject("tbEp3Flag.Enabled")));
			this.tbEp3Flag.Font = ((System.Drawing.Font)(resources.GetObject("tbEp3Flag.Font")));
			this.tbEp3Flag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbEp3Flag.ImeMode")));
			this.tbEp3Flag.Location = ((System.Drawing.Point)(resources.GetObject("tbEp3Flag.Location")));
			this.tbEp3Flag.MaxLength = ((int)(resources.GetObject("tbEp3Flag.MaxLength")));
			this.tbEp3Flag.Multiline = ((bool)(resources.GetObject("tbEp3Flag.Multiline")));
			this.tbEp3Flag.Name = "tbEp3Flag";
			this.tbEp3Flag.PasswordChar = ((char)(resources.GetObject("tbEp3Flag.PasswordChar")));
			this.tbEp3Flag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbEp3Flag.RightToLeft")));
			this.tbEp3Flag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbEp3Flag.ScrollBars")));
			this.tbEp3Flag.Size = ((System.Drawing.Size)(resources.GetObject("tbEp3Flag.Size")));
			this.tbEp3Flag.TabIndex = ((int)(resources.GetObject("tbEp3Flag.TabIndex")));
			this.tbEp3Flag.Text = resources.GetString("tbEp3Flag.Text");
			this.tbEp3Flag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbEp3Flag.TextAlign")));
			this.tbEp3Flag.Visible = ((bool)(resources.GetObject("tbEp3Flag.Visible")));
			this.tbEp3Flag.WordWrap = ((bool)(resources.GetObject("tbEp3Flag.WordWrap")));
			this.tbEp3Flag.TextChanged += new System.EventHandler(this.ChangedEP3);
			// 
			// tbEp3Lot
			// 
			this.tbEp3Lot.AccessibleDescription = resources.GetString("tbEp3Lot.AccessibleDescription");
			this.tbEp3Lot.AccessibleName = resources.GetString("tbEp3Lot.AccessibleName");
			this.tbEp3Lot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbEp3Lot.Anchor")));
			this.tbEp3Lot.AutoSize = ((bool)(resources.GetObject("tbEp3Lot.AutoSize")));
			this.tbEp3Lot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbEp3Lot.BackgroundImage")));
			this.tbEp3Lot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbEp3Lot.Dock")));
			this.tbEp3Lot.Enabled = ((bool)(resources.GetObject("tbEp3Lot.Enabled")));
			this.tbEp3Lot.Font = ((System.Drawing.Font)(resources.GetObject("tbEp3Lot.Font")));
			this.tbEp3Lot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbEp3Lot.ImeMode")));
			this.tbEp3Lot.Location = ((System.Drawing.Point)(resources.GetObject("tbEp3Lot.Location")));
			this.tbEp3Lot.MaxLength = ((int)(resources.GetObject("tbEp3Lot.MaxLength")));
			this.tbEp3Lot.Multiline = ((bool)(resources.GetObject("tbEp3Lot.Multiline")));
			this.tbEp3Lot.Name = "tbEp3Lot";
			this.tbEp3Lot.PasswordChar = ((char)(resources.GetObject("tbEp3Lot.PasswordChar")));
			this.tbEp3Lot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbEp3Lot.RightToLeft")));
			this.tbEp3Lot.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbEp3Lot.ScrollBars")));
			this.tbEp3Lot.Size = ((System.Drawing.Size)(resources.GetObject("tbEp3Lot.Size")));
			this.tbEp3Lot.TabIndex = ((int)(resources.GetObject("tbEp3Lot.TabIndex")));
			this.tbEp3Lot.Text = resources.GetString("tbEp3Lot.Text");
			this.tbEp3Lot.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbEp3Lot.TextAlign")));
			this.tbEp3Lot.Visible = ((bool)(resources.GetObject("tbEp3Lot.Visible")));
			this.tbEp3Lot.WordWrap = ((bool)(resources.GetObject("tbEp3Lot.WordWrap")));
			this.tbEp3Lot.TextChanged += new System.EventHandler(this.ChangedEP3);
			// 
			// label9
			// 
			this.label9.AccessibleDescription = resources.GetString("label9.AccessibleDescription");
			this.label9.AccessibleName = resources.GetString("label9.AccessibleName");
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label9.Anchor")));
			this.label9.AutoSize = ((bool)(resources.GetObject("label9.AutoSize")));
			this.label9.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label9.Dock")));
			this.label9.Enabled = ((bool)(resources.GetObject("label9.Enabled")));
			this.label9.Font = ((System.Drawing.Font)(resources.GetObject("label9.Font")));
			this.label9.Image = ((System.Drawing.Image)(resources.GetObject("label9.Image")));
			this.label9.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.ImageAlign")));
			this.label9.ImageIndex = ((int)(resources.GetObject("label9.ImageIndex")));
			this.label9.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label9.ImeMode")));
			this.label9.Location = ((System.Drawing.Point)(resources.GetObject("label9.Location")));
			this.label9.Name = "label9";
			this.label9.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label9.RightToLeft")));
			this.label9.Size = ((System.Drawing.Size)(resources.GetObject("label9.Size")));
			this.label9.TabIndex = ((int)(resources.GetObject("label9.TabIndex")));
			this.label9.Text = resources.GetString("label9.Text");
			this.label9.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label9.TextAlign")));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
			// 
			// label11
			// 
			this.label11.AccessibleDescription = resources.GetString("label11.AccessibleDescription");
			this.label11.AccessibleName = resources.GetString("label11.AccessibleName");
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label11.Anchor")));
			this.label11.AutoSize = ((bool)(resources.GetObject("label11.AutoSize")));
			this.label11.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label11.Dock")));
			this.label11.Enabled = ((bool)(resources.GetObject("label11.Enabled")));
			this.label11.Font = ((System.Drawing.Font)(resources.GetObject("label11.Font")));
			this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
			this.label11.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label11.ImageAlign")));
			this.label11.ImageIndex = ((int)(resources.GetObject("label11.ImageIndex")));
			this.label11.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label11.ImeMode")));
			this.label11.Location = ((System.Drawing.Point)(resources.GetObject("label11.Location")));
			this.label11.Name = "label11";
			this.label11.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label11.RightToLeft")));
			this.label11.Size = ((System.Drawing.Size)(resources.GetObject("label11.Size")));
			this.label11.TabIndex = ((int)(resources.GetObject("label11.TabIndex")));
			this.label11.Text = resources.GetString("label11.Text");
			this.label11.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label11.TextAlign")));
			this.label11.Visible = ((bool)(resources.GetObject("label11.Visible")));
			// 
			// ExtSDesc
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.Controls.Add(this.toolBar1);
			this.Controls.Add(this.pnChar);
			this.Controls.Add(this.pnSkill);
			this.Controls.Add(this.pnEP2);
			this.Controls.Add(this.pnRel);
			this.Controls.Add(this.pnId);
			this.Controls.Add(this.pnCareer);
			this.Controls.Add(this.pnEP1);
			this.Controls.Add(this.pnMisc);
			this.Controls.Add(this.pnEP3);
			this.Controls.Add(this.pnInt);
			this.DockPadding.Top = 24;
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.HeaderText = resources.GetString("$this.HeaderText");
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.Name = "ExtSDesc";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.Size = ((System.Drawing.Size)(resources.GetObject("$this.Size")));
			this.Controls.SetChildIndex(this.pnInt, 0);
			this.Controls.SetChildIndex(this.pnEP3, 0);
			this.Controls.SetChildIndex(this.pnMisc, 0);
			this.Controls.SetChildIndex(this.pnEP1, 0);
			this.Controls.SetChildIndex(this.pnCareer, 0);
			this.Controls.SetChildIndex(this.pnId, 0);
			this.Controls.SetChildIndex(this.pnRel, 0);
			this.Controls.SetChildIndex(this.pnEP2, 0);
			this.Controls.SetChildIndex(this.pnSkill, 0);
			this.Controls.SetChildIndex(this.pnChar, 0);
			this.Controls.SetChildIndex(this.toolBar1, 0);
			this.pnId.ResumeLayout(false);
			this.pnSkill.ResumeLayout(false);
			this.pnChar.ResumeLayout(false);
			this.pnCareer.ResumeLayout(false);
			this.pnInt.ResumeLayout(false);
			this.pnRel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.pnMisc.ResumeLayout(false);
			this.xpTaskBoxSimple3.ResumeLayout(false);
			this.xpTaskBoxSimple2.ResumeLayout(false);
			this.xpTaskBoxSimple1.ResumeLayout(false);
			this.pnEP1.ResumeLayout(false);
			this.pnEP2.ResumeLayout(false);
			this.pnEP3.ResumeLayout(false);
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

			mbiMax.Enabled = pnSkill.Visible || pnChar.Visible || pnInt.Visible || pnRel.Visible;
			this.miRand.Enabled = mbiMax.Enabled;
		}
		
		private void ChoosePage(object sender, System.EventArgs e)
		{
			SelectButton((TD.SandBar.ButtonItem)sender);
		}

		void InitDropDowns()
		{
			this.cbaspiration.Items.Clear();
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Nothing));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Fortune));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Family));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Knowledge));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Reputation));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Romance));
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Growup));			
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Fun));			
			this.cbaspiration.Items.Add(new LocalizedAspirationTypes(Data.MetaData.AspirationTypes.Chees));

			
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
			loadedRel = false;
			this.intern = true;
			try 
			{
				base.RefreshGUI ();
		
				miOpenChar.Enabled = System.IO.File.Exists(Sdesc.CharacterFileName) && !Sdesc.IsNPC;
				miOpenCloth.Enabled = miOpenChar.Enabled;
				miRelink.Enabled = /*miOpenChar.Enabled &&*/ Helper.WindowsRegistry.HiddenMode;

				if (System.IO.File.Exists(Sdesc.CharacterFileName))
					miOpenChar.Text = strresources.GetString("miOpenChar.Text")+" ("+System.IO.Path.GetFileNameWithoutExtension(Sdesc.CharacterFileName)+")";
				else
					miOpenChar.Text = strresources.GetString("miOpenChar.Text");

				this.tbsimdescname.ReadOnly = Sdesc.IsNPC;
				this.tbsimdescfamname.ReadOnly = this.tbsimdescname.ReadOnly;

				RefreshSkills(Sdesc);
				RefreshId(Sdesc);
				RefreshCareer(Sdesc);
				RefreshCharcter(Sdesc);
				RefreshInterests(Sdesc);
				RefreshMisc(Sdesc);

				pnRel_VisibleChanged(null, null);

				this.biEP1.Enabled = (int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.University;
				this.biEP2.Enabled = (int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Nightlife;
				this.biEP3.Enabled = (int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Business;
				if (pnEP1.Visible && !biEP1.Enabled) this.SelectButton(biId);
				if (pnEP2.Visible && !biEP2.Enabled) this.SelectButton(biId);
				if (pnEP3.Visible && !biEP3.Enabled) this.SelectButton(biId);

				if (biEP1.Enabled) RefreshEP1(Sdesc);
				if (biEP2.Enabled) RefreshEP2(Sdesc);
				if (biEP3.Enabled) RefreshEP3(Sdesc);
			} 
			finally 
			{
				this.intern = false;
			}
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

			//misc
			this.tbprevdays.Text = sdesc.CharacterDescription.PrevAgeDays.ToString();
			this.tbagedur.Text = sdesc.CharacterDescription.AgeDuration.ToString();
			this.tbunlinked.Text = "0x"+Helper.HexString(sdesc.Unlinked);
			this.tbvoice.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.VoiceType);
			this.tbautonomy.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.AutonomyLevel);
			this.tbnpc.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.NPCType);
			tbstatmot.Text = "0x"+Helper.HexString(sdesc.CharacterDescription.MotivesStatic);
		}

		void RefreshId(Wrapper.ExtSDesc sdesc)
		{
			this.tbage.Text = sdesc.CharacterDescription.Age.ToString();
			this.tbsimdescname.Text = sdesc.SimName;
			this.tbsimdescfamname.Text = sdesc.SimFamilyName;
			this.tbsim.Text = "0x"+Helper.HexString(sdesc.SimId);
			this.tbsim.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
			this.tbfaminst.Text = "0x"+Helper.HexString(sdesc.FamilyInstance);
			
			Image img = null;
			
			if (sdesc.Image!=null) 
				if (sdesc.Image.Width>5) 
					img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(sdesc.Image, new Point(0,0), Color.Magenta);

			if (img == null)
				img = Image.FromStream(this.GetType().Assembly.GetManifestResourceStream("SimPe.PackedFiles.Wrapper.noone.png"));

			img = Ambertation.Windows.Forms.Graph.ImagePanel.CreateThumbnail(img, pbImage.Size, 12, Color.FromArgb(90, Color.Black), SimPe.PackedFiles.Wrapper.SimPoolControl.GetImagePanelColor(Sdesc), Color.White, Color.FromArgb(80, Color.White), true, 4, 0);
			this.pbImage.Image = img;

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

			pbWoman.Value = sdesc.Interests.FemalePreference;
			pbMan.Value = sdesc.Interests.MalePreference;
		}

		#endregion

		private void Activate_biMax(object sender, System.EventArgs e)
		{			
			if (this.pnSkill.Visible) 
			{
				intern = true;
				foreach (Control c in pnSkill.Controls)
				{
					if (c == this.pbFat) 
					{
						((LabeledProgressBar)c).Value = 0;
					} 
					else if (c is LabeledProgressBar)
					{
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum-1;
					}
				}
				intern = false;	this.ChangedSkill(null, null);
			} 
			else if(this.pnChar.Visible) 
			{
				intern = true;
				foreach (Control c in pnChar.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
				intern = false;	this.ChangedChar(null, null);
			}
			else if(this.pnInt.Visible) 
			{
				intern = true;
				foreach (Control c in pnInt.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = ((LabeledProgressBar)c).Maximum;
				intern = false;	this.ChangedInt(null, null);
			} 
			else if (this.pnRel.Visible)
			{
				int index = -1;
				if (lv.SelectedIndices.Count>0)
					index = lv.SelectedIndices[0];
				foreach (SteepValley.Windows.Forms.XPListViewItem lvi in lv.Items)
				{
					
					if (lvi.GroupIndex!=1) 
					{
						lvi.Selected = true;
						if (this.srcRel.Srel!=null) 
						{
							srcRel.Srel.Longterm = 100;
							srcRel.Srel.Shortterm = 100;
							srcRel.Srel.Changed = true;
						}

						if (this.dstRel.Srel!=null) 
						{
							dstRel.Srel.Longterm = 100;
							dstRel.Srel.Shortterm = 100;
							dstRel.Srel.Changed = true;
						}
					}
				}
				if (index>=0) lv.Items[index].Selected = true;
				else if (lv.Items.Count>0) lv.Items[0].Selected= true;
			}
		}

		private void Activate_biRand(object sender, System.EventArgs e)
		{			
			Random rnd = new Random();
			if (this.pnSkill.Visible) 
			{
				intern = true;
				foreach (Control c in pnSkill.Controls)				
					if (c is LabeledProgressBar)					
						((LabeledProgressBar)c).Value = rnd.Next(((LabeledProgressBar)c).Maximum);					
				
				intern = false;	this.ChangedSkill(null, null);
			} 
			else if(this.pnChar.Visible) 
			{
				intern = true;
				foreach (Control c in pnChar.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = rnd.Next(((LabeledProgressBar)c).Maximum);
				intern = false;	this.ChangedSkill(null, null);
			}
			else if(this.pnInt.Visible) 
			{
				intern = true;
				foreach (Control c in pnInt.Controls)
					if (c is LabeledProgressBar)
						((LabeledProgressBar)c).Value = rnd.Next(((LabeledProgressBar)c).Maximum);
				intern = false;	this.ChangedSkill(null, null);
			}
			else if (this.pnRel.Visible)
			{
				foreach (SteepValley.Windows.Forms.XPListViewItem lvi in lv.Items)
				{
					
					if (lvi.GroupIndex!=1) 
					{
						lvi.Selected = true;
						int baseval = rnd.Next(200)-100;
						if (this.srcRel.Srel!=null) 
						{
							srcRel.Srel.Longterm = Math.Max(-100, Math.Min(100, baseval + rnd.Next(40)-20));
							srcRel.Srel.Shortterm = Math.Max(-100, Math.Min(100, baseval + rnd.Next(40)-20));
							srcRel.Srel.Changed = true;
						}

						if (this.dstRel.Srel!=null) 
						{
							dstRel.Srel.Longterm = Math.Max(-100, Math.Min(100, baseval + rnd.Next(40)-20));
							dstRel.Srel.Shortterm = Math.Max(-100, Math.Min(100, baseval + rnd.Next(40)-20));
							dstRel.Srel.Changed = true;
						}
					}
				}
				if (lv.Items.Count>0) lv.Items[0].Selected= true;
			}
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

		#region Changing Data
		bool intern;
		protected bool InternalChange
		{
			get {return intern;}
			set {intern = value;}
		}

		private void ChangedId(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				Sdesc.SimId = Helper.StringToUInt32(this.tbsim.Text, Sdesc.SimId, 16);
				Sdesc.FamilyInstance = Helper.StringToUInt16(this.tbfaminst.Text, Sdesc.FamilyInstance, 16);

				Sdesc.CharacterDescription.Age = Helper.StringToUInt16(this.tbage.Text, Sdesc.CharacterDescription.Age, 10);
				if (Sdesc.SimName!=tbsimdescname.Text) Sdesc.SimName = this.tbsimdescname.Text;
				if (Sdesc.SimFamilyName!=tbsimdescfamname.Text) Sdesc.SimFamilyName = this.tbsimdescfamname.Text;
				
				this.tbsim.ReadOnly = !Helper.WindowsRegistry.HiddenMode;
				
			
				
				//Lifesection
				Sdesc.CharacterDescription.LifeSection = (Data.LocalizedLifeSections)this.cblifesection.SelectedItem;
				

				if (this.rbfemale.Checked) Sdesc.CharacterDescription.Gender = Data.MetaData.Gender.Female;
				else Sdesc.CharacterDescription.Gender = Data.MetaData.Gender.Male;

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedRel(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedInt(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				Sdesc.Interests.Animals = (ushort)this.pbAnimals.Value;
				Sdesc.Interests.Crime = (ushort)this.pbCrime.Value;
				Sdesc.Interests.Culture = (ushort)this.pbCulture.Value;
				Sdesc.Interests.Entertainment = (ushort)this.pbEntertainment.Value;
				Sdesc.Interests.Environment = (ushort)this.pbEnvironment.Value; 
				Sdesc.Interests.Fashion = (ushort)this.pbFashion.Value;
				Sdesc.Interests.Food = (ushort)this.pbFood.Value;
				Sdesc.Interests.Health = (ushort)this.pbHealth.Value;
				Sdesc.Interests.Money = (ushort)this.pbMoney.Value;
				Sdesc.Interests.Paranormal = (ushort)this.pbParanormal.Value;
				Sdesc.Interests.Politics = (ushort)this.pbPolitics.Value;
				Sdesc.Interests.School = (ushort)this.pbSchool.Value;
				Sdesc.Interests.Scifi = (ushort)this.pbSciFi.Value;
				Sdesc.Interests.Sports = (ushort)this.pbSports.Value;
				Sdesc.Interests.Toys = (ushort)this.pbToys.Value;
				Sdesc.Interests.Travel = (ushort)this.pbTravel.Value;
				Sdesc.Interests.Weather = (ushort)this.pbWeather.Value;
				Sdesc.Interests.Work = (ushort)this.pbWork.Value;	

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedCareer(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				Sdesc.CharacterDescription.CareerLevel = (ushort)this.pbCareerLevel.Value;
				Sdesc.CharacterDescription.CareerPerformance = (short)this.pbCareerPerformance.Value;

				//Career
				Sdesc.CharacterDescription.Career = (SimPe.Data.MetaData.Careers)Helper.StringToUInt32(this.tbcareervalue.Text, (uint)Sdesc.CharacterDescription.Career, 16);
				
				//school
				Sdesc.CharacterDescription.SchoolType = (SimPe.Data.MetaData.SchoolTypes)Helper.StringToUInt32(this.tbschooltype.Text, (uint)Sdesc.CharacterDescription.SchoolType, 16);

				//grades and school
				Sdesc.CharacterDescription.Grade = (Data.LocalizedGrades)cbgrade.SelectedItem;
				

				//Aspiration
				Sdesc.CharacterDescription.BlizLifelinePoints = (ushort)this.pbAspBliz.Value;
				Sdesc.CharacterDescription.LifelinePoints = (short)this.pbAspCur.Value;

			
				Sdesc.CharacterDescription.Aspiration = (LocalizedAspirationTypes)this.cbaspiration.SelectedItem;				
				Sdesc.CharacterDescription.LifelineScore = Helper.StringToUInt32(this.tblifelinescore.Text, (uint)Sdesc.CharacterDescription.LifelineScore, 10);

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedChar(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				Sdesc.CharacterDescription.ZodiacSign = (Data.MetaData.ZodiacSignes)(this.cbzodiac.SelectedIndex+1);

				//Character
				Sdesc.Character.Neat = (ushort)this.pbNeat.Value;
				Sdesc.Character.Outgoing = (ushort)this.pbOutgoing.Value;
				Sdesc.Character.Active = (ushort)this.pbActive.Value;
				Sdesc.Character.Playful = (ushort)this.pbPlayful.Value;
				Sdesc.Character.Nice = (ushort)this.pbNice.Value;

				//Genetic Character
				Sdesc.GeneticCharacter.Neat = (ushort)this.pbGNeat.Value;
				Sdesc.GeneticCharacter.Outgoing = (ushort)this.pbGOutgoing.Value;
				Sdesc.GeneticCharacter.Active = (ushort)this.pbGActive.Value;
				Sdesc.GeneticCharacter.Playful = (ushort)this.pbGPlayful.Value;
				Sdesc.GeneticCharacter.Nice = (ushort)this.pbGNice.Value;

				Sdesc.Interests.FemalePreference = (short)pbWoman.Value;
				Sdesc.Interests.MalePreference = (short)pbMan.Value;

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedSkill(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				Sdesc.Skills.Body = (ushort)this.pbBody.Value;
				Sdesc.Skills.Charisma = (ushort)this.pbCharisma.Value;
				Sdesc.Skills.Cleaning = (ushort)this.pbClean.Value;
				Sdesc.Skills.Cooking = (ushort)this.pbCooking.Value;
				Sdesc.Skills.Creativity = (ushort)this.pbCreative.Value;
				Sdesc.Skills.Fatness = (ushort)this.pbFat.Value;
				Sdesc.Skills.Logic = (ushort)this.pbLogic.Value;
				Sdesc.Skills.Mechanical = (ushort)this.pbMech.Value;
				Sdesc.Skills.Romance = (ushort)this.pbRomance.Value;
				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedOther(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{
				//ghostflags
				Sdesc.CharacterDescription.GhostFlag.IsGhost = this.cbisghost.Checked;
				Sdesc.CharacterDescription.GhostFlag.CanPassThroughObjects = this.cbpassobject.Checked;
				Sdesc.CharacterDescription.GhostFlag.CanPassThroughWalls = this.cbpasswalls.Checked;
				Sdesc.CharacterDescription.GhostFlag.CanPassThroughPeople = this.cbpasspeople.Checked;
				Sdesc.CharacterDescription.GhostFlag.IgnoreTraversalCosts = this.cbignoretraversal.Checked;

				//body flags
				Sdesc.CharacterDescription.BodyFlag.Fit = this.cbfit.Checked;
				Sdesc.CharacterDescription.BodyFlag.Fat = this.cbfat.Checked;
				Sdesc.CharacterDescription.BodyFlag.PregnantFull = this.cbpregfull.Checked;
				Sdesc.CharacterDescription.BodyFlag.PregnantHalf = this.cbpreghalf.Checked;
				Sdesc.CharacterDescription.BodyFlag.PregnantHidden = this.cbpreginv.Checked;

				//misc
				Sdesc.CharacterDescription.PrevAgeDays = Helper.StringToUInt16(this.tbprevdays.Text, Sdesc.CharacterDescription.PrevAgeDays, 10);
				Sdesc.CharacterDescription.AgeDuration = Helper.StringToUInt16(this.tbagedur.Text, Sdesc.CharacterDescription.AgeDuration, 10);
				Sdesc.Unlinked = Helper.StringToUInt16(this.tbunlinked.Text, Sdesc.Unlinked, 16);
				Sdesc.CharacterDescription.VoiceType = Helper.StringToUInt16(this.tbvoice.Text, Sdesc.CharacterDescription.VoiceType, 16);
				Sdesc.CharacterDescription.AutonomyLevel = Helper.StringToUInt16(this.tbautonomy.Text, Sdesc.CharacterDescription.AutonomyLevel, 16);
				Sdesc.CharacterDescription.NPCType = Helper.StringToUInt16(this.tbnpc.Text, Sdesc.CharacterDescription.NPCType, 16);
				Sdesc.CharacterDescription.MotivesStatic = Helper.StringToUInt16(this.tbstatmot.Text, Sdesc.CharacterDescription.MotivesStatic, 16);

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedEP1(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{				
				Sdesc.University.Major = (Data.Majors)Helper.StringToUInt32(this.tbmajor.Text, (uint)Sdesc.University.Major, 16);						
				
				if (this.cboncampus.Checked) Sdesc.University.OnCampus=0x1;
				else Sdesc.University.OnCampus=0x0;

				Sdesc.University.Effort = (ushort)this.pbEffort.Value;
				Sdesc.University.Grade = (ushort)this.pbLastGrade.Value;

				Sdesc.University.Time = (ushort)this.pbUniTime.Value;
				Sdesc.University.Influence = Helper.StringToUInt16(this.tbinfluence.Text, Sdesc.University.Influence, 10);
				Sdesc.University.Semester = Helper.StringToUInt16(this.tbsemester.Text, Sdesc.University.Semester, 10);

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		#endregion
	

		#region More Menu
		private void Activate_miMore(object sender, System.EventArgs e)
		{
			SdscExtendedForm.Execute(this.Sdesc);
		}

		private void Activate_biMore(object sender, System.EventArgs e)
		{
			if (biMore.Text=="More")
				mbiLink.Show(this.toolBar1, new Point(443, toolBar1.Height-2));
			else mbiLink.Show(this.toolBar1, new Point(507, toolBar1.Height-2));
		}

		private void Activate_miRelink(object sender, System.EventArgs e)
		{
			this.tbsim.Text = "0x"+Helper.HexString(SimRelinkForm.Execute(Sdesc));
		}

		private void Activate_miOpenCHar(object sender, System.EventArgs e)
		{
			try 
			{
				SimPe.RemoteControl.OpenPackage(Sdesc.CharacterFileName);
			}
			catch (Exception ex)
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miOpenCloth(object sender, System.EventArgs e)
		{
			try 
			{				
				if (System.IO.File.Exists(Sdesc.CharacterFileName)) 
				{
					uint inst = Convert.ToUInt32(this.tbfaminst.Text, 16);					
					SimPe.Packages.GeneratableFile fl = SimPe.Packages.GeneratableFile.LoadFromFile(Sdesc.CharacterFileName);

					Interfaces.Files.IPackedFileDescriptor[] pfds = fl.FindFile(0xAC506764, 0, 0x1);
					if (pfds.Length>0) 
					{
						SimPe.RemoteControl.OpenPackage(Sdesc.CharacterFileName);						
						SimPe.RemoteControl.OpenPackedFile(pfds[0], fl);
					}
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miFamily(object sender, System.EventArgs e)
		{
			try 
			{
				uint inst = Convert.ToUInt32(this.tbfaminst.Text, 16);
				

				Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0x46414D49, Sdesc.FileDescriptor.SubType, Sdesc.FileDescriptor.Group, inst); //try a Fami File
				pfd = Sdesc.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miOpenWf(object sender, System.EventArgs e)
		{
			try 
			{
				//Open File
				Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0xCD95548E, Sdesc.FileDescriptor.SubType, Sdesc.FileDescriptor.Group, Sdesc.FileDescriptor.Instance); //try a W&f File
				pfd = Sdesc.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miOpenMem(object sender, System.EventArgs e)
		{
			try 
			{
				//Open File
				Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0x4E474248, 0, Data.MetaData.LOCAL_GROUP, 1); //try the memory Resource
				pfd = Sdesc.Package.FindFile(pfd);				
				SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);				

				object[] data = new object[] {Sdesc.FileDescriptor.Instance, Data.NeighborhoodSlots.Sims}; 
				SimPe.RemoteControl.AddMessage(this, new SimPe.RemoteControl.ControlEventArgs(0x4E474248, data));
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miOpenBadge(object sender, System.EventArgs e)
		{
			try 
			{
				//Open File
				Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0x4E474248, 0, Data.MetaData.LOCAL_GROUP, 1); //try the memory Resource
				pfd = Sdesc.Package.FindFile(pfd);				
				SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);				

				object[] data = new object[] {Sdesc.FileDescriptor.Instance, Data.NeighborhoodSlots.SimsIntern}; 
				SimPe.RemoteControl.AddMessage(this, new SimPe.RemoteControl.ControlEventArgs(0x4E474248, data));
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}

		private void Activate_miOpenDNA(object sender, System.EventArgs e)
		{
			try 
			{
				Interfaces.Files.IPackedFileDescriptor pfd = Sdesc.Package.NewDescriptor(0xEBFEE33F, Sdesc.FileDescriptor.SubType, Sdesc.FileDescriptor.Group, Sdesc.FileDescriptor.Instance); //try a DNA File
				pfd = Sdesc.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd, Sdesc.Package);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(ex);
			}
		}
		#endregion

		#region Relations
		bool loadedRel;
		SimPe.Interfaces.Files.IPackageFile lastpkg;
		private void pnRel_VisibleChanged(object sender, System.EventArgs e)
		{
			if (pnRel.Visible) 
			{
				if (lastpkg==null) LoadRelList();
				else if (!lastpkg.Equals(Sdesc.Package)) LoadRelList();
				else if (!loadedRel) UpdateRelList();
				
				lastpkg = Sdesc.Package;
			}
		}	
	
		void LoadRelList()
		{
			lv.BeginUpdate();
			Wait.SubStart(FileTable.ProviderRegistry.SimDescriptionProvider.SimGuidMap.Count);
			Wait.Message = "Loading Relations";
			lv.Clear();	
			int ct = 0;
			ArrayList inst = new ArrayList();
			foreach (PackedFiles.Wrapper.ExtSDesc sdesc in FileTable.ProviderRegistry.SimDescriptionProvider.SimGuidMap.Values)
			{				
				inst.Add((ushort)sdesc.FileDescriptor.Instance);
				SteepValley.Windows.Forms.XPListViewItem lvi = lv.Add(sdesc);
				if (Sdesc.HasRelationWith(sdesc)) lvi.GroupIndex=0;
				else if (sdesc.IsNPC) lvi.GroupIndex=3;
				else if (sdesc.IsTownie) lvi.GroupIndex=4;
				else lvi.GroupIndex=1;

				lvi.Tag = sdesc;
				Wait.Progress = ct++;					
			}

			AddUnknownToRelList(inst);

			
								
			
			lv.EndUpdate();
			Wait.SubStop();	

			ResetLabel();
			loadedRel = true;
			lv.Sort();
		}

		void UpdateRelList()
		{
			ArrayList inst = new ArrayList();
			for (int i=lv.Items.Count-1; i>=0; i--)
			{
				SteepValley.Windows.Forms.XPListViewItem lvi = lv.Items[i];
				PackedFiles.Wrapper.ExtSDesc sdesc = (PackedFiles.Wrapper.ExtSDesc)lvi.Tag;
				if (lvi.GroupIndex==2) 
				{
					lv.Items.Remove(lvi);
					continue;
				}
				
				inst.Add((ushort)sdesc.FileDescriptor.Instance);
				if (Sdesc.HasRelationWith(sdesc)) lvi.GroupIndex=0;
				else if (sdesc.IsNPC) lvi.GroupIndex=3;
				else if (sdesc.IsTownie) lvi.GroupIndex=4;
				else lvi.GroupIndex=1;
			}

			AddUnknownToRelList(inst);
			ResetLabel();
			loadedRel = true;
			lv.Sort();
		}
		
		void AddUnknownToRelList(ArrayList insts)
		{
			foreach (ushort inst in Sdesc.Relations.SimInstances)
			{
				if (!insts.Contains(inst))
				{
					PackedFiles.Wrapper.ExtSDesc sdesc = new SimPe.PackedFiles.Wrapper.ExtSDesc();
					sdesc.FileDescriptor = Sdesc.Package.NewDescriptor(Data.MetaData.SIM_DESCRIPTION_FILE, 0, Sdesc.FileDescriptor.Group, inst);
					sdesc.Package = Sdesc.Package;
					SteepValley.Windows.Forms.XPListViewItem lvi = lv.Add(sdesc);
					lvi.GroupIndex=2;					

					lvi.Tag = sdesc;					
				}
			}
		}

		void ResetLabel()
		{
			this.lv.TileColumns = new int[]{1, 2, 6, 3, 4, 5};
			this.lv.SetColumnStyle(1, lv.Font, Color.Gray);
			this.lv.SetColumnStyle(2, lv.Font, Color.Gray);
			this.lv.SetColumnStyle(3, lv.Font, Color.Gray);			
			this.lv.SetColumnStyle(4, lv.Font, Color.Gray);

			this.dstRel.Srel = null;
			this.srcRel.Srel = null;
			UpdateLabel();
		}

		void UpdateLabel()
		{
			Image img = null;
			srcTb.HeaderText = srcRel.SourceSimName + " " + SimPe.Localization.GetString("towards") +" " +srcRel.TargetSimName;
			if (srcRel.TargetSim==null)img  = null;
			else  img = (Image)srcRel.Image;
			if (img!=null) 
			{
				//img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new Point(0,0), Color.Magenta);
				img = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, srcTb.IconSize.Width, srcTb.IconSize.Height, true);
			}
			srcTb.Icon = img;
			

			dstTb.HeaderText = dstRel.SourceSimName + " " + SimPe.Localization.GetString("towards") +" " +dstRel.TargetSimName;
			if (dstRel.TargetSim==null) img = null;
			else img = (Image)dstRel.Image.Clone();
			if (img!=null) 
			{
				//img = Ambertation.Drawing.GraphicRoutines.KnockoutImage(img, new Point(0,0), Color.Magenta);
				img = Ambertation.Drawing.GraphicRoutines.ScaleImage(img, srcTb.IconSize.Width, srcTb.IconSize.Height, true);
			}
			dstTb.Icon = img;
		}

		SimPe.PackedFiles.Wrapper.ExtSrel FindRelation(PackedFiles.Wrapper.ExtSDesc src, PackedFiles.Wrapper.ExtSDesc dst)
		{
			return SimPe.PackedFiles.Wrapper.ExtSDesc.FindRelation(Sdesc, src, dst);
		}

		void DiplayRelation(PackedFiles.Wrapper.ExtSDesc src, PackedFiles.Wrapper.ExtSDesc dst, CommonSrel c)
		{
			if (src.Equals(dst) && (c==dstRel || !Helper.WindowsRegistry.HiddenMode)) 
			{
				c.Srel = null;
			} 
			else 
			{
				SimPe.PackedFiles.Wrapper.ExtSrel srel = FindRelation(src, dst);			
				c.Srel = srel;
				Sdesc.AddRelationToCache(srel);
			}
		}

		private void lv_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;

			PackedFiles.Wrapper.ExtSDesc sdesc = (PackedFiles.Wrapper.ExtSDesc)lv.SelectedItems[0].Tag;

			
			DiplayRelation(Sdesc, sdesc, srcRel);
			DiplayRelation(sdesc, Sdesc, dstRel);						
			
			
			UpdateLabel();
		}
		
		

		private void miRel_BeforePopup(object sender, TD.SandBar.MenuPopupEventArgs e)
		{
			if (lv.SelectedItems.Count==1) 
			{
				if (Helper.WindowsRegistry.HiddenMode)
					this.miAddRelation.Enabled = ((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex==1;
				else
					this.miAddRelation.Enabled = ((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex==1 && !Sdesc.Equals(lv.SelectedItems[0].Tag);

				this.miRemRelation.Enabled = ((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex!=1;
			
				string name = SimPe.Localization.GetString("AddRelationCaption").Replace("{name}", lv.SelectedItems[0].Text);
				this.miAddRelation.Text = name;

				name = SimPe.Localization.GetString("RemoveRelationCaption").Replace("{name}", lv.SelectedItems[0].Text);
				this.miRemRelation.Text = name;

				name = SimPe.Localization.GetString("Max Relation to this Sim").Replace("{name}", lv.SelectedItems[0].Text);
				this.mbiMaxThisRel.Text = name;
				this.mbiMaxThisRel.Enabled = this.miRemRelation.Enabled;

				this.mbiMaxKnownRel.Enabled = true;
			} 
			else 
			{
				this.miAddRelation.Enabled = false;
				this.miRemRelation.Enabled = false;
				this.mbiMaxThisRel.Enabled = false;
				this.mbiMaxKnownRel.Enabled = false;

				string name = SimPe.Localization.GetString("AddRelationCaption").Replace("{name}", SimPe.Localization.GetString("Unknown"));
				this.miAddRelation.Text = name;

				name = SimPe.Localization.GetString("RemoveRelationCaption").Replace("{name}", SimPe.Localization.GetString("Unknown"));
				this.miRemRelation.Text = name;
			}
		}

		private void Activate_miAddRelation(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;
			PackedFiles.Wrapper.ExtSDesc sdesc = (PackedFiles.Wrapper.ExtSDesc)lv.SelectedItems[0].Tag;

			SimPe.PackedFiles.Wrapper.ExtSrel srel = FindRelation(Sdesc, sdesc);
			if (srel==null) srel = Sdesc.CreateRelation(sdesc);
			Sdesc.AddRelationToCache(srel);
			Sdesc.AddRelation(sdesc);

			srel = FindRelation(sdesc, Sdesc);
			if (srel==null) srel = sdesc.CreateRelation(Sdesc);
			Sdesc.AddRelationToCache(srel);
			sdesc.AddRelation(Sdesc);

			((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex=0;
			lv.EnsureVisible(lv.SelectedItems[0].Index);
			lv_SelectedIndexChanged(lv, null);
		}

		private void Activate_miRemRelation(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;
			PackedFiles.Wrapper.ExtSDesc sdesc = (PackedFiles.Wrapper.ExtSDesc)lv.SelectedItems[0].Tag;

			SimPe.PackedFiles.Wrapper.ExtSrel srel = FindRelation(Sdesc, sdesc);
			if (srel!=null) Sdesc.RemoveRelationFromCache(srel);				
			Sdesc.RemoveRelation(sdesc);
			

			srel = FindRelation(sdesc, Sdesc);
			if (srel!=null) Sdesc.RemoveRelationFromCache(srel);
			sdesc.RemoveRelation(Sdesc);
			

			if (((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex==2)
				lv.Items.Remove((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]);
			else 			
				((SteepValley.Windows.Forms.XPListViewItem)lv.SelectedItems[0]).GroupIndex=1;
			
			lv.EnsureVisible(lv.SelectedItems[0].Index);
			lv_SelectedIndexChanged(lv, null);
		}

		private void Activate_mbiMaxThisRel(object sender, System.EventArgs e)
		{
			foreach (SteepValley.Windows.Forms.XPListViewItem lvi in lv.SelectedItems)
			{					
				if (lvi.GroupIndex!=1) 
				{
					if (this.srcRel.Srel!=null) 
					{
						srcRel.Srel.Longterm = 100;
						srcRel.Srel.Shortterm = 100;
						srcRel.Srel.Changed = true;						
					}

					if (this.dstRel.Srel!=null) 
					{						
						dstRel.Srel.Longterm = 100;
						dstRel.Srel.Shortterm = 100;
						dstRel.Srel.Changed = true;					
					}
				}
			}	
		
			this.lv_SelectedIndexChanged(lv, null);
		}

		private void Activate_mbiMaxKnownRel(object sender, System.EventArgs e)
		{
			int index = -1;
			if (lv.SelectedIndices.Count>0)
				index = lv.SelectedIndices[0];
			foreach (SteepValley.Windows.Forms.XPListViewItem lvi in lv.Items)
			{					
				if (lvi.GroupIndex!=1) 
				{
					lvi.Selected = true;
					if (this.srcRel.Srel!=null) 
					{
						if (srcRel.Srel.RelationState.IsKnown) 
						{
							srcRel.Srel.Longterm = 100;
							srcRel.Srel.Shortterm = 100;
							srcRel.Srel.Changed = true;
						}
					}

					if (this.dstRel.Srel!=null) 
					{
						if (dstRel.Srel.RelationState.IsKnown) 
						{
							dstRel.Srel.Longterm = 100;
							dstRel.Srel.Shortterm = 100;
							dstRel.Srel.Changed = true;
						}
					}
				}
			}

			if (index>=0) lv.Items[index].Selected = true;
		}
		#endregion

		#region Nightlife
		void FillNightlifeListBox(System.Windows.Forms.CheckedListBox clb) 
		{
			if (clb.Items.Count>0) return;

			SimPe.Interfaces.IAlias[] al = FileTable.ProviderRegistry.SimDescriptionProvider.GetAllTurnOns();
			foreach (SimPe.Interfaces.IAlias a in al)
				clb.Items.Add(a);
		}

		void SelectNightlifeItems(System.Windows.Forms.CheckedListBox clb, ushort v1, ushort v2)
		{
			FillNightlifeListBox(clb);

			uint cur = FileTable.ProviderRegistry.SimDescriptionProvider.BuildTurnOnIndex(v1, v2);
			for (int i=0; i<clb.Items.Count; i++)
			{
				uint val = ((SimPe.Interfaces.IAlias)clb.Items[i]).Id;
				clb.SetItemChecked(i, ((cur&val)==val));
			}
		}

		uint SumSelection(System.Windows.Forms.CheckedListBox clb)
		{
			uint val = 0;
			for (int i=0; i<clb.Items.Count; i++)
				if (clb.GetItemChecked(i))
					val += ((SimPe.Interfaces.IAlias)clb.Items[i]).Id;

			return val;
		}

		void RefreshEP2(Wrapper.ExtSDesc sdesc)
		{
			SelectNightlifeItems(this.lbTraits, sdesc.Nightlife.AttractionTraits1, sdesc.Nightlife.AttractionTraits2);
			SelectNightlifeItems(this.lbTurnOn, sdesc.Nightlife.AttractionTurnOns1, sdesc.Nightlife.AttractionTurnOns2);
			SelectNightlifeItems(this.lbTurnOff, sdesc.Nightlife.AttractionTurnOffs1, sdesc.Nightlife.AttractionTurnOffs2);

			this.tbNTPerfume.Text = sdesc.Nightlife.PerfumeDuration.ToString();
			this.tbNTLove.Text = sdesc.Nightlife.LovePotionDuration.ToString();
		}

		void RefreshEP3(Wrapper.ExtSDesc sdesc)
		{
			this.tbEp3Flag.Text = Helper.MinStrLength(Convert.ToString(sdesc.Business.Flags, 2), 16);
			this.tbEp3Lot.Text = Helper.HexString(sdesc.Business.LotID);
			this.tbEp3Salery.Text = sdesc.Business.Salary.ToString();

			this.cbEp3Asgn.SelectedValue = sdesc.Business.Assignment;
			this.sblb.SimDescription = sdesc;
		}
		

		private void lbTraits_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			ushort[] v = FileTable.ProviderRegistry.SimDescriptionProvider.GetFromTurnOnIndex(SumSelection(this.lbTraits));
			Sdesc.Nightlife.AttractionTraits1 = v[0];
			Sdesc.Nightlife.AttractionTraits2 = v[1];
		}

		private void lbTurnOn_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			ushort[] v = FileTable.ProviderRegistry.SimDescriptionProvider.GetFromTurnOnIndex(SumSelection(this.lbTurnOn));
			Sdesc.Nightlife.AttractionTurnOns1 = v[0];
			Sdesc.Nightlife.AttractionTurnOns2 = v[1];
		}

		private void lbTurnOff_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (intern) return;
			ushort[] v = FileTable.ProviderRegistry.SimDescriptionProvider.GetFromTurnOnIndex(SumSelection(this.lbTurnOff));
			Sdesc.Nightlife.AttractionTurnOffs1 = v[0];
			Sdesc.Nightlife.AttractionTurnOffs2 = v[1];
		}

		private void ChangedEP2(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{								
				Sdesc.Nightlife.PerfumeDuration = Helper.StringToUInt16(this.tbNTPerfume.Text, Sdesc.Nightlife.PerfumeDuration, 10);
				Sdesc.Nightlife.LovePotionDuration = Helper.StringToUInt16(this.tbNTLove.Text, Sdesc.Nightlife.LovePotionDuration, 10);

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		private void ChangedEP3(object sender, System.EventArgs e)
		{
			if (intern) return;
			intern = true;
			try 
			{								
				Sdesc.Business.Salary = Helper.StringToUInt16(this.tbEp3Salery.Text, Sdesc.Business.Salary, 10);
				Sdesc.Business.LotID = Helper.StringToUInt16(this.tbEp3Lot.Text, Sdesc.Business.LotID, 16);
				Sdesc.Business.Flags = Helper.StringToUInt16(this.tbEp3Flag.Text, Sdesc.Business.Flags, 2);
				Sdesc.Business.Assignment = (Wrapper.JobAssignment)this.cbEp3Asgn.SelectedValue;

				Sdesc.Changed = true;
			} 
			finally 
			{
				intern = false;
			}
		}

		#endregion

		private void sblb_SelectedBusinessChanged(object sender, System.EventArgs e)
		{
			this.llep3openinfo.Enabled = (sblb.SelectedBusiness!=null);
			if (sblb.SelectedBusiness!=null)
			{
				if (sblb.SelectedBusiness.BnfoFileIndexItem==null) llep3openinfo.Enabled = false;
			}
		}


		private void llep3openinfo_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (sblb.SelectedBusiness==null) return;
			
			SimPe.RemoteControl.OpenPackedFile(sblb.SelectedBusiness.BnfoFileIndexItem);
		}

		

		

		

		
	}
}
