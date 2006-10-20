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
		private ToolStrip toolBar1;
		private ToolStripButton biEP1;
		private ToolStripButton biId;
		private ToolStripButton biRel;
		private ToolStripButton biInt;
		private ToolStripButton biChar;
		private ToolStripButton biSkill;
		private ToolStripButton biMisc;
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
		private ToolStripButton biMax;
		private System.Windows.Forms.Panel pnChar;
		internal System.Windows.Forms.ComboBox cbzodiac;
		private System.Windows.Forms.Label label47;
		private ToolStripButton biCareer;
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
		private ToolStripButton biMore;
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
		private ToolStripMenuItem mbiMax;
		private ContextMenuStrip mbiLink;
		private ToolStripMenuItem miRand;
		private ToolStripMenuItem miOpenChar;
		private ToolStripMenuItem miOpenDNA;
		private ToolStripMenuItem miOpenFamily;
		private ToolStripMenuItem miOpenCloth;
		private ToolStripMenuItem miMore;
		private ToolStripMenuItem miRelink;
		private ToolStripMenuItem miOpenWf;
		private System.Windows.Forms.Label label3;
		internal System.Windows.Forms.TextBox tbstatmot;
        private System.Windows.Forms.Panel panel3;
		private SimPe.PackedFiles.UserInterface.CommonSrel srcRel;
		private SimPe.PackedFiles.UserInterface.CommonSrel dstRel;
		private Ambertation.Windows.Forms.XPTaskBoxSimple srcTb;
        private Ambertation.Windows.Forms.XPTaskBoxSimple dstTb;
		private ContextMenuStrip miRel;
		private ToolStripMenuItem miAddRelation;
		private ToolStripMenuItem miRemRelation;
        private System.ComponentModel.IContainer components;
		private ToolStripButton biEP2;
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
		private ToolStripButton biEP3;
		private System.Windows.Forms.Panel pnEP3;
		private System.Windows.Forms.TextBox tbEp3Flag;
		private System.Windows.Forms.TextBox tbEp3Lot;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label11;
		private Ambertation.Windows.Forms.EnumComboBox cbEp3Asgn;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tbEp3Salery;
		private System.Windows.Forms.Label label14;
		private ToolStripMenuItem miOpenMem;
		private ToolStripMenuItem miOpenBadge;
		private SimPe.PackedFiles.Wrapper.SimBusinessList sblb;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.LinkLabel llep3openinfo;
		private System.Windows.Forms.PictureBox pictureBox1;
		private ToolStripMenuItem mbiMaxThisRel;
		private ToolStripMenuItem mbiMaxKnownRel;
        private SimPe.PackedFiles.Wrapper.SimRelationPoolControl lv;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem3;
        private Label label16;
        internal TextBox tbpetclass;

		
		System.Resources.ResourceManager strresources;
		public ExtSDesc()
		{
			
			strresources = new System.Resources.ResourceManager(typeof(ExtSDesc));
			Text = SimPe.Localization.GetString("Sim Description Editor");
			
			// Dieser Aufruf ist für den Windows Form-Designer erforderlich.
			InitializeComponent();	
			Initialize();

            toolBar1.Renderer = new SimPe.MediaPlayerRenderer();
             			

			ThemeManager.AddControl(this.toolBar1);			
			ThemeManager.AddControl(this.srcTb);
			ThemeManager.AddControl(this.dstTb);
			ThemeManager.AddControl(this.xpTaskBoxSimple1);
			ThemeManager.AddControl(this.xpTaskBoxSimple2);
			ThemeManager.AddControl(this.xpTaskBoxSimple3);
            ThemeManager.AddControl(this.miRel);
            ThemeManager.AddControl(this.mbiLink);
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

            intern = true;
			if (System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName=="en")
				pbLastGrade.DisplayOffset = 0;
			else
				pbLastGrade.DisplayOffset = 1;
            intern = false;

            lv.SimDetails = true;
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtSDesc));
            this.toolBar1 = new System.Windows.Forms.ToolStrip();
            this.biId = new System.Windows.Forms.ToolStripButton();
            this.biCareer = new System.Windows.Forms.ToolStripButton();
            this.biRel = new System.Windows.Forms.ToolStripButton();
            this.biInt = new System.Windows.Forms.ToolStripButton();
            this.biChar = new System.Windows.Forms.ToolStripButton();
            this.biSkill = new System.Windows.Forms.ToolStripButton();
            this.biMisc = new System.Windows.Forms.ToolStripButton();
            this.biEP1 = new System.Windows.Forms.ToolStripButton();
            this.biEP2 = new System.Windows.Forms.ToolStripButton();
            this.biEP3 = new System.Windows.Forms.ToolStripButton();
            this.biMore = new System.Windows.Forms.ToolStripButton();
            this.biMax = new System.Windows.Forms.ToolStripButton();
            this.mbiMax = new System.Windows.Forms.ToolStripMenuItem();
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
            this.pbBody = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbRomance = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbFat = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbClean = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbCreative = new Ambertation.Windows.Forms.LabeledProgressBar();
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
            this.mbiLink = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miRand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miOpenChar = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenWf = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenMem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenBadge = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenDNA = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFamily = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenCloth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miMore = new System.Windows.Forms.ToolStripMenuItem();
            this.miRelink = new System.Windows.Forms.ToolStripMenuItem();
            this.miRel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAddRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemRelation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mbiMaxThisRel = new System.Windows.Forms.ToolStripMenuItem();
            this.mbiMaxKnownRel = new System.Windows.Forms.ToolStripMenuItem();
            this.lv = new SimPe.PackedFiles.Wrapper.SimRelationPoolControl();
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
            this.label16 = new System.Windows.Forms.Label();
            this.tbpetclass = new System.Windows.Forms.TextBox();
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
            this.toolBar1.SuspendLayout();
            this.pnId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnSkill.SuspendLayout();
            this.pnChar.SuspendLayout();
            this.mbiLink.SuspendLayout();
            this.miRel.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar1
            // 
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolBar1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.toolBar1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolBar1.Name = "toolBar1";
            // 
            // biId
            // 
            resources.ApplyResources(this.biId, "biId");
            this.biId.Name = "biId";
            this.biId.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biCareer
            // 
            resources.ApplyResources(this.biCareer, "biCareer");
            this.biCareer.Name = "biCareer";
            this.biCareer.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biRel
            // 
            resources.ApplyResources(this.biRel, "biRel");
            this.biRel.Name = "biRel";
            this.biRel.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biInt
            // 
            resources.ApplyResources(this.biInt, "biInt");
            this.biInt.Name = "biInt";
            this.biInt.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biChar
            // 
            resources.ApplyResources(this.biChar, "biChar");
            this.biChar.Name = "biChar";
            this.biChar.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biSkill
            // 
            resources.ApplyResources(this.biSkill, "biSkill");
            this.biSkill.Name = "biSkill";
            this.biSkill.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biMisc
            // 
            resources.ApplyResources(this.biMisc, "biMisc");
            this.biMisc.Name = "biMisc";
            this.biMisc.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP1
            // 
            resources.ApplyResources(this.biEP1, "biEP1");
            this.biEP1.Name = "biEP1";
            this.biEP1.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP2
            // 
            resources.ApplyResources(this.biEP2, "biEP2");
            this.biEP2.Name = "biEP2";
            this.biEP2.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP3
            // 
            resources.ApplyResources(this.biEP3, "biEP3");
            this.biEP3.Name = "biEP3";
            this.biEP3.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biMore
            // 
            resources.ApplyResources(this.biMore, "biMore");
            this.biMore.Name = "biMore";
            this.biMore.Click += new System.EventHandler(this.Activate_biMore);
            // 
            // biMax
            // 
            this.biMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.biMax, "biMax");
            this.biMax.Name = "biMax";
            this.biMax.Click += new System.EventHandler(this.Activate_biMax);
            // 
            // mbiMax
            // 
            resources.ApplyResources(this.mbiMax, "mbiMax");
            this.mbiMax.Name = "mbiMax";
            this.mbiMax.Click += new System.EventHandler(this.Activate_biMax);
            // 
            // pnId
            // 
            resources.ApplyResources(this.pnId, "pnId");
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
            this.pnId.Name = "pnId";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbsimdescfamname
            // 
            resources.ApplyResources(this.tbsimdescfamname, "tbsimdescfamname");
            this.tbsimdescfamname.Name = "tbsimdescfamname";
            this.tbsimdescfamname.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // tbfaminst
            // 
            resources.ApplyResources(this.tbfaminst, "tbfaminst");
            this.tbfaminst.Name = "tbfaminst";
            this.tbfaminst.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // rbmale
            // 
            resources.ApplyResources(this.rbmale, "rbmale");
            this.rbmale.Name = "rbmale";
            this.rbmale.CheckedChanged += new System.EventHandler(this.ChangedId);
            // 
            // rbfemale
            // 
            resources.ApplyResources(this.rbfemale, "rbfemale");
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.CheckedChanged += new System.EventHandler(this.ChangedId);
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // tbsimdescname
            // 
            resources.ApplyResources(this.tbsimdescname, "tbsimdescname");
            this.tbsimdescname.Name = "tbsimdescname";
            this.tbsimdescname.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label13
            // 
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbsim
            // 
            resources.ApplyResources(this.tbsim, "tbsim");
            this.tbsim.Name = "tbsim";
            this.tbsim.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbage
            // 
            resources.ApplyResources(this.tbage, "tbage");
            this.tbage.Name = "tbage";
            this.tbage.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // cblifesection
            // 
            this.cblifesection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cblifesection, "cblifesection");
            this.cblifesection.Name = "cblifesection";
            this.cblifesection.SelectedValueChanged += new System.EventHandler(this.ChangedId);
            // 
            // pnSkill
            // 
            resources.ApplyResources(this.pnSkill, "pnSkill");
            this.pnSkill.BackColor = System.Drawing.Color.Transparent;
            this.pnSkill.Controls.Add(this.pbBody);
            this.pnSkill.Controls.Add(this.pbRomance);
            this.pnSkill.Controls.Add(this.pbFat);
            this.pnSkill.Controls.Add(this.pbClean);
            this.pnSkill.Controls.Add(this.pbCreative);
            this.pnSkill.Controls.Add(this.pbCharisma);
            this.pnSkill.Controls.Add(this.pbMech);
            this.pnSkill.Controls.Add(this.pbLogic);
            this.pnSkill.Controls.Add(this.pbCooking);
            this.pnSkill.Name = "pnSkill";
            // 
            // pbBody
            // 
            this.pbBody.BackColor = System.Drawing.Color.Transparent;
            this.pbBody.DisplayOffset = 0;
            resources.ApplyResources(this.pbBody, "pbBody");
            this.pbBody.Maximum = 1000;
            this.pbBody.Name = "pbBody";
            this.pbBody.NumberFormat = "N2";
            this.pbBody.NumberOffset = 0;
            this.pbBody.NumberScale = 0.01;
            this.pbBody.SelectedColor = System.Drawing.Color.Lime;
            this.pbBody.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbBody.TokenCount = 21;
            this.pbBody.UnselectedColor = System.Drawing.Color.Black;
            this.pbBody.Value = 500;
            this.pbBody.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbRomance
            // 
            this.pbRomance.BackColor = System.Drawing.Color.Transparent;
            this.pbRomance.DisplayOffset = 0;
            resources.ApplyResources(this.pbRomance, "pbRomance");
            this.pbRomance.Maximum = 1000;
            this.pbRomance.Name = "pbRomance";
            this.pbRomance.NumberFormat = "N1";
            this.pbRomance.NumberOffset = 0;
            this.pbRomance.NumberScale = 0.01;
            this.pbRomance.SelectedColor = System.Drawing.Color.OrangeRed;
            this.pbRomance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbRomance.TokenCount = 10;
            this.pbRomance.UnselectedColor = System.Drawing.Color.Black;
            this.pbRomance.Value = 500;
            this.pbRomance.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbFat
            // 
            this.pbFat.BackColor = System.Drawing.Color.Transparent;
            this.pbFat.DisplayOffset = 0;
            resources.ApplyResources(this.pbFat, "pbFat");
            this.pbFat.Maximum = 1000;
            this.pbFat.Name = "pbFat";
            this.pbFat.NumberFormat = "N1";
            this.pbFat.NumberOffset = 0;
            this.pbFat.NumberScale = 0.01;
            this.pbFat.SelectedColor = System.Drawing.Color.Orange;
            this.pbFat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbFat.TokenCount = 10;
            this.pbFat.UnselectedColor = System.Drawing.Color.Black;
            this.pbFat.Value = 500;
            this.pbFat.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbClean
            // 
            this.pbClean.BackColor = System.Drawing.Color.Transparent;
            this.pbClean.DisplayOffset = 0;
            resources.ApplyResources(this.pbClean, "pbClean");
            this.pbClean.Maximum = 1000;
            this.pbClean.Name = "pbClean";
            this.pbClean.NumberFormat = "N2";
            this.pbClean.NumberOffset = 0;
            this.pbClean.NumberScale = 0.01;
            this.pbClean.SelectedColor = System.Drawing.Color.Lime;
            this.pbClean.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbClean.TokenCount = 21;
            this.pbClean.UnselectedColor = System.Drawing.Color.Black;
            this.pbClean.Value = 500;
            this.pbClean.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbCreative
            // 
            this.pbCreative.BackColor = System.Drawing.Color.Transparent;
            this.pbCreative.DisplayOffset = 0;
            resources.ApplyResources(this.pbCreative, "pbCreative");
            this.pbCreative.Maximum = 1000;
            this.pbCreative.Name = "pbCreative";
            this.pbCreative.NumberFormat = "N2";
            this.pbCreative.NumberOffset = 0;
            this.pbCreative.NumberScale = 0.01;
            this.pbCreative.SelectedColor = System.Drawing.Color.Lime;
            this.pbCreative.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbCreative.TokenCount = 21;
            this.pbCreative.UnselectedColor = System.Drawing.Color.Black;
            this.pbCreative.Value = 500;
            this.pbCreative.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbCharisma
            // 
            this.pbCharisma.BackColor = System.Drawing.Color.Transparent;
            this.pbCharisma.DisplayOffset = 0;
            resources.ApplyResources(this.pbCharisma, "pbCharisma");
            this.pbCharisma.Maximum = 1000;
            this.pbCharisma.Name = "pbCharisma";
            this.pbCharisma.NumberFormat = "N2";
            this.pbCharisma.NumberOffset = 0;
            this.pbCharisma.NumberScale = 0.01;
            this.pbCharisma.SelectedColor = System.Drawing.Color.Lime;
            this.pbCharisma.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbCharisma.TokenCount = 21;
            this.pbCharisma.UnselectedColor = System.Drawing.Color.Black;
            this.pbCharisma.Value = 500;
            this.pbCharisma.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbMech
            // 
            this.pbMech.BackColor = System.Drawing.Color.Transparent;
            this.pbMech.DisplayOffset = 0;
            resources.ApplyResources(this.pbMech, "pbMech");
            this.pbMech.Maximum = 1000;
            this.pbMech.Name = "pbMech";
            this.pbMech.NumberFormat = "N2";
            this.pbMech.NumberOffset = 0;
            this.pbMech.NumberScale = 0.01;
            this.pbMech.SelectedColor = System.Drawing.Color.Lime;
            this.pbMech.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbMech.TokenCount = 21;
            this.pbMech.UnselectedColor = System.Drawing.Color.Black;
            this.pbMech.Value = 500;
            this.pbMech.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbLogic
            // 
            this.pbLogic.BackColor = System.Drawing.Color.Transparent;
            this.pbLogic.DisplayOffset = 0;
            resources.ApplyResources(this.pbLogic, "pbLogic");
            this.pbLogic.Maximum = 1000;
            this.pbLogic.Name = "pbLogic";
            this.pbLogic.NumberFormat = "N2";
            this.pbLogic.NumberOffset = 0;
            this.pbLogic.NumberScale = 0.01;
            this.pbLogic.SelectedColor = System.Drawing.Color.Lime;
            this.pbLogic.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbLogic.TokenCount = 21;
            this.pbLogic.UnselectedColor = System.Drawing.Color.Black;
            this.pbLogic.Value = 500;
            this.pbLogic.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pbCooking
            // 
            this.pbCooking.BackColor = System.Drawing.Color.Transparent;
            this.pbCooking.DisplayOffset = 0;
            resources.ApplyResources(this.pbCooking, "pbCooking");
            this.pbCooking.Maximum = 1000;
            this.pbCooking.Name = "pbCooking";
            this.pbCooking.NumberFormat = "N2";
            this.pbCooking.NumberOffset = 0;
            this.pbCooking.NumberScale = 0.01;
            this.pbCooking.SelectedColor = System.Drawing.Color.Lime;
            this.pbCooking.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbCooking.TokenCount = 21;
            this.pbCooking.UnselectedColor = System.Drawing.Color.Black;
            this.pbCooking.Value = 500;
            this.pbCooking.Changed += new System.EventHandler(this.ChangedSkill);
            // 
            // pnChar
            // 
            resources.ApplyResources(this.pnChar, "pnChar");
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
            this.pnChar.Name = "pnChar";
            // 
            // pbMan
            // 
            this.pbMan.BackColor = System.Drawing.Color.Transparent;
            this.pbMan.DisplayOffset = 0;
            resources.ApplyResources(this.pbMan, "pbMan");
            this.pbMan.Maximum = 2000;
            this.pbMan.Name = "pbMan";
            this.pbMan.NumberFormat = "N1";
            this.pbMan.NumberOffset = -1000;
            this.pbMan.NumberScale = 0.01;
            this.pbMan.SelectedColor = System.Drawing.Color.OrangeRed;
            this.pbMan.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
            this.pbMan.TokenCount = 19;
            this.pbMan.UnselectedColor = System.Drawing.Color.Black;
            this.pbMan.Value = 0;
            this.pbMan.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbWoman
            // 
            this.pbWoman.BackColor = System.Drawing.Color.Transparent;
            this.pbWoman.DisplayOffset = 0;
            resources.ApplyResources(this.pbWoman, "pbWoman");
            this.pbWoman.Maximum = 2000;
            this.pbWoman.Name = "pbWoman";
            this.pbWoman.NumberFormat = "N1";
            this.pbWoman.NumberOffset = -1000;
            this.pbWoman.NumberScale = 0.01;
            this.pbWoman.SelectedColor = System.Drawing.Color.OrangeRed;
            this.pbWoman.Style = Ambertation.Windows.Forms.ProgresBarStyle.Balance;
            this.pbWoman.TokenCount = 19;
            this.pbWoman.UnselectedColor = System.Drawing.Color.Black;
            this.pbWoman.Value = 0;
            this.pbWoman.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbGNice
            // 
            this.pbGNice.BackColor = System.Drawing.Color.Transparent;
            this.pbGNice.DisplayOffset = 0;
            resources.ApplyResources(this.pbGNice, "pbGNice");
            this.pbGNice.Maximum = 1000;
            this.pbGNice.Name = "pbGNice";
            this.pbGNice.NumberFormat = "N1";
            this.pbGNice.NumberOffset = 0;
            this.pbGNice.NumberScale = 0.01;
            this.pbGNice.SelectedColor = System.Drawing.Color.Lime;
            this.pbGNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbGNice.TokenCount = 10;
            this.pbGNice.UnselectedColor = System.Drawing.Color.Black;
            this.pbGNice.Value = 50;
            this.pbGNice.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbGPlayful
            // 
            this.pbGPlayful.BackColor = System.Drawing.Color.Transparent;
            this.pbGPlayful.DisplayOffset = 0;
            resources.ApplyResources(this.pbGPlayful, "pbGPlayful");
            this.pbGPlayful.Maximum = 1000;
            this.pbGPlayful.Name = "pbGPlayful";
            this.pbGPlayful.NumberFormat = "N1";
            this.pbGPlayful.NumberOffset = 0;
            this.pbGPlayful.NumberScale = 0.01;
            this.pbGPlayful.SelectedColor = System.Drawing.Color.Lime;
            this.pbGPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbGPlayful.TokenCount = 10;
            this.pbGPlayful.UnselectedColor = System.Drawing.Color.Black;
            this.pbGPlayful.Value = 50;
            this.pbGPlayful.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbGActive
            // 
            this.pbGActive.BackColor = System.Drawing.Color.Transparent;
            this.pbGActive.DisplayOffset = 0;
            resources.ApplyResources(this.pbGActive, "pbGActive");
            this.pbGActive.Maximum = 1000;
            this.pbGActive.Name = "pbGActive";
            this.pbGActive.NumberFormat = "N1";
            this.pbGActive.NumberOffset = 0;
            this.pbGActive.NumberScale = 0.01;
            this.pbGActive.SelectedColor = System.Drawing.Color.Lime;
            this.pbGActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbGActive.TokenCount = 10;
            this.pbGActive.UnselectedColor = System.Drawing.Color.Black;
            this.pbGActive.Value = 50;
            this.pbGActive.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbGOutgoing
            // 
            this.pbGOutgoing.BackColor = System.Drawing.Color.Transparent;
            this.pbGOutgoing.DisplayOffset = 0;
            resources.ApplyResources(this.pbGOutgoing, "pbGOutgoing");
            this.pbGOutgoing.Maximum = 1000;
            this.pbGOutgoing.Name = "pbGOutgoing";
            this.pbGOutgoing.NumberFormat = "N1";
            this.pbGOutgoing.NumberOffset = 0;
            this.pbGOutgoing.NumberScale = 0.01;
            this.pbGOutgoing.SelectedColor = System.Drawing.Color.Lime;
            this.pbGOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbGOutgoing.TokenCount = 10;
            this.pbGOutgoing.UnselectedColor = System.Drawing.Color.Black;
            this.pbGOutgoing.Value = 50;
            this.pbGOutgoing.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbGNeat
            // 
            this.pbGNeat.BackColor = System.Drawing.Color.Transparent;
            this.pbGNeat.DisplayOffset = 0;
            resources.ApplyResources(this.pbGNeat, "pbGNeat");
            this.pbGNeat.Maximum = 1000;
            this.pbGNeat.Name = "pbGNeat";
            this.pbGNeat.NumberFormat = "N1";
            this.pbGNeat.NumberOffset = 0;
            this.pbGNeat.NumberScale = 0.01;
            this.pbGNeat.SelectedColor = System.Drawing.Color.Lime;
            this.pbGNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbGNeat.TokenCount = 10;
            this.pbGNeat.UnselectedColor = System.Drawing.Color.Black;
            this.pbGNeat.Value = 50;
            this.pbGNeat.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbNice
            // 
            this.pbNice.BackColor = System.Drawing.Color.Transparent;
            this.pbNice.DisplayOffset = 0;
            resources.ApplyResources(this.pbNice, "pbNice");
            this.pbNice.Maximum = 1000;
            this.pbNice.Name = "pbNice";
            this.pbNice.NumberFormat = "N1";
            this.pbNice.NumberOffset = 0;
            this.pbNice.NumberScale = 0.01;
            this.pbNice.SelectedColor = System.Drawing.Color.Lime;
            this.pbNice.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbNice.TokenCount = 10;
            this.pbNice.UnselectedColor = System.Drawing.Color.Black;
            this.pbNice.Value = 50;
            this.pbNice.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbPlayful
            // 
            this.pbPlayful.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayful.DisplayOffset = 0;
            resources.ApplyResources(this.pbPlayful, "pbPlayful");
            this.pbPlayful.Maximum = 1000;
            this.pbPlayful.Name = "pbPlayful";
            this.pbPlayful.NumberFormat = "N1";
            this.pbPlayful.NumberOffset = 0;
            this.pbPlayful.NumberScale = 0.01;
            this.pbPlayful.SelectedColor = System.Drawing.Color.Lime;
            this.pbPlayful.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbPlayful.TokenCount = 10;
            this.pbPlayful.UnselectedColor = System.Drawing.Color.Black;
            this.pbPlayful.Value = 50;
            this.pbPlayful.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbActive
            // 
            this.pbActive.BackColor = System.Drawing.Color.Transparent;
            this.pbActive.DisplayOffset = 0;
            resources.ApplyResources(this.pbActive, "pbActive");
            this.pbActive.Maximum = 1000;
            this.pbActive.Name = "pbActive";
            this.pbActive.NumberFormat = "N1";
            this.pbActive.NumberOffset = 0;
            this.pbActive.NumberScale = 0.01;
            this.pbActive.SelectedColor = System.Drawing.Color.Lime;
            this.pbActive.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbActive.TokenCount = 10;
            this.pbActive.UnselectedColor = System.Drawing.Color.Black;
            this.pbActive.Value = 50;
            this.pbActive.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbOutgoing
            // 
            this.pbOutgoing.BackColor = System.Drawing.Color.Transparent;
            this.pbOutgoing.DisplayOffset = 0;
            resources.ApplyResources(this.pbOutgoing, "pbOutgoing");
            this.pbOutgoing.Maximum = 1000;
            this.pbOutgoing.Name = "pbOutgoing";
            this.pbOutgoing.NumberFormat = "N1";
            this.pbOutgoing.NumberOffset = 0;
            this.pbOutgoing.NumberScale = 0.01;
            this.pbOutgoing.SelectedColor = System.Drawing.Color.Lime;
            this.pbOutgoing.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbOutgoing.TokenCount = 10;
            this.pbOutgoing.UnselectedColor = System.Drawing.Color.Black;
            this.pbOutgoing.Value = 50;
            this.pbOutgoing.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // pbNeat
            // 
            this.pbNeat.BackColor = System.Drawing.Color.Transparent;
            this.pbNeat.DisplayOffset = 0;
            resources.ApplyResources(this.pbNeat, "pbNeat");
            this.pbNeat.Maximum = 1000;
            this.pbNeat.Name = "pbNeat";
            this.pbNeat.NumberFormat = "N1";
            this.pbNeat.NumberOffset = 0;
            this.pbNeat.NumberScale = 0.01;
            this.pbNeat.SelectedColor = System.Drawing.Color.Lime;
            this.pbNeat.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbNeat.TokenCount = 10;
            this.pbNeat.UnselectedColor = System.Drawing.Color.Black;
            this.pbNeat.Value = 50;
            this.pbNeat.Changed += new System.EventHandler(this.ChangedChar);
            // 
            // cbzodiac
            // 
            this.cbzodiac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbzodiac, "cbzodiac");
            this.cbzodiac.Name = "cbzodiac";
            this.cbzodiac.SelectedIndexChanged += new System.EventHandler(this.ChangedChar);
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label69
            // 
            this.label69.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.label69, "label69");
            this.label69.Name = "label69";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label70
            // 
            this.label70.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.label70, "label70");
            this.label70.Name = "label70";
            // 
            // mbiLink
            // 
            this.mbiLink.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbiMax,
            this.miRand,
            this.toolStripMenuItem1,
            this.miOpenChar,
            this.miOpenWf,
            this.miOpenMem,
            this.miOpenBadge,
            this.miOpenDNA,
            this.miOpenFamily,
            this.miOpenCloth,
            this.toolStripMenuItem2,
            this.miMore,
            this.miRelink});
            this.mbiLink.Name = "mbiLink";
            resources.ApplyResources(this.mbiLink, "mbiLink");
            // 
            // miRand
            // 
            resources.ApplyResources(this.miRand, "miRand");
            this.miRand.Name = "miRand";
            this.miRand.Click += new System.EventHandler(this.Activate_biRand);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // miOpenChar
            // 
            resources.ApplyResources(this.miOpenChar, "miOpenChar");
            this.miOpenChar.Name = "miOpenChar";
            this.miOpenChar.Click += new System.EventHandler(this.Activate_miOpenCHar);
            // 
            // miOpenWf
            // 
            resources.ApplyResources(this.miOpenWf, "miOpenWf");
            this.miOpenWf.Name = "miOpenWf";
            this.miOpenWf.Click += new System.EventHandler(this.Activate_miOpenWf);
            // 
            // miOpenMem
            // 
            resources.ApplyResources(this.miOpenMem, "miOpenMem");
            this.miOpenMem.Name = "miOpenMem";
            this.miOpenMem.Click += new System.EventHandler(this.Activate_miOpenMem);
            // 
            // miOpenBadge
            // 
            resources.ApplyResources(this.miOpenBadge, "miOpenBadge");
            this.miOpenBadge.Name = "miOpenBadge";
            this.miOpenBadge.Click += new System.EventHandler(this.Activate_miOpenBadge);
            // 
            // miOpenDNA
            // 
            resources.ApplyResources(this.miOpenDNA, "miOpenDNA");
            this.miOpenDNA.Name = "miOpenDNA";
            this.miOpenDNA.Click += new System.EventHandler(this.Activate_miOpenDNA);
            // 
            // miOpenFamily
            // 
            resources.ApplyResources(this.miOpenFamily, "miOpenFamily");
            this.miOpenFamily.Name = "miOpenFamily";
            this.miOpenFamily.Click += new System.EventHandler(this.Activate_miFamily);
            // 
            // miOpenCloth
            // 
            this.miOpenCloth.ForeColor = System.Drawing.SystemColors.WindowText;
            resources.ApplyResources(this.miOpenCloth, "miOpenCloth");
            this.miOpenCloth.Name = "miOpenCloth";
            this.miOpenCloth.Click += new System.EventHandler(this.Activate_miOpenCloth);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // miMore
            // 
            resources.ApplyResources(this.miMore, "miMore");
            this.miMore.Name = "miMore";
            this.miMore.Click += new System.EventHandler(this.Activate_miMore);
            // 
            // miRelink
            // 
            resources.ApplyResources(this.miRelink, "miRelink");
            this.miRelink.Name = "miRelink";
            this.miRelink.Click += new System.EventHandler(this.Activate_miRelink);
            // 
            // miRel
            // 
            this.miRel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddRelation,
            this.miRemRelation,
            this.toolStripMenuItem3,
            this.mbiMaxThisRel,
            this.mbiMaxKnownRel});
            this.miRel.Name = "miRel";
            resources.ApplyResources(this.miRel, "miRel");
            this.miRel.VisibleChanged += new System.EventHandler(this.miRel_BeforePopup);
            // 
            // miAddRelation
            // 
            resources.ApplyResources(this.miAddRelation, "miAddRelation");
            this.miAddRelation.Name = "miAddRelation";
            this.miAddRelation.Click += new System.EventHandler(this.Activate_miAddRelation);
            // 
            // miRemRelation
            // 
            resources.ApplyResources(this.miRemRelation, "miRemRelation");
            this.miRemRelation.Name = "miRemRelation";
            this.miRemRelation.Click += new System.EventHandler(this.Activate_miRemRelation);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // mbiMaxThisRel
            // 
            this.mbiMaxThisRel.Name = "mbiMaxThisRel";
            resources.ApplyResources(this.mbiMaxThisRel, "mbiMaxThisRel");
            this.mbiMaxThisRel.Click += new System.EventHandler(this.Activate_mbiMaxThisRel);
            // 
            // mbiMaxKnownRel
            // 
            this.mbiMaxKnownRel.Name = "mbiMaxKnownRel";
            resources.ApplyResources(this.mbiMaxKnownRel, "mbiMaxKnownRel");
            this.mbiMaxKnownRel.Click += new System.EventHandler(this.Activate_mbiMaxKnownRel);
            // 
            // lv
            // 
            this.lv.ContextMenuStrip = this.miRel;
            resources.ApplyResources(this.lv, "lv");
            this.lv.Name = "lv";
            this.lv.Package = null;
            this.lv.RightClickSelect = true;
            this.lv.SelectedElement = null;
            this.lv.SelectedSim = null;
            this.lv.ShowNotRelatedSims = false;
            this.lv.ShowRelatedSims = true;
            this.lv.Sim = null;
            this.lv.SimDetails = false;
            this.lv.TileColumns = new int[] {
        1};
            this.lv.SelectedSimChanged += new SimPe.PackedFiles.Wrapper.SimPoolControl.SelectedSimHandler(this.lv_SelectedSimChanged);
            // 
            // pnCareer
            // 
            resources.ApplyResources(this.pnCareer, "pnCareer");
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
            this.pnCareer.Name = "pnCareer";
            // 
            // pbAspBliz
            // 
            this.pbAspBliz.BackColor = System.Drawing.Color.Transparent;
            this.pbAspBliz.DisplayOffset = 0;
            resources.ApplyResources(this.pbAspBliz, "pbAspBliz");
            this.pbAspBliz.Maximum = 1200;
            this.pbAspBliz.Name = "pbAspBliz";
            this.pbAspBliz.NumberFormat = "N0";
            this.pbAspBliz.NumberOffset = 0;
            this.pbAspBliz.NumberScale = 1;
            this.pbAspBliz.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbAspBliz.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbAspBliz.TokenCount = 21;
            this.pbAspBliz.UnselectedColor = System.Drawing.Color.Black;
            this.pbAspBliz.Value = 10;
            this.pbAspBliz.Changed += new System.EventHandler(this.ChangedCareer);
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.Name = "label60";
            // 
            // cbaspiration
            // 
            this.cbaspiration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbaspiration, "cbaspiration");
            this.cbaspiration.Name = "cbaspiration";
            this.cbaspiration.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pbAspCur
            // 
            this.pbAspCur.BackColor = System.Drawing.Color.Transparent;
            this.pbAspCur.DisplayOffset = 0;
            resources.ApplyResources(this.pbAspCur, "pbAspCur");
            this.pbAspCur.Maximum = 1200;
            this.pbAspCur.Name = "pbAspCur";
            this.pbAspCur.NumberFormat = "N0";
            this.pbAspCur.NumberOffset = -600;
            this.pbAspCur.NumberScale = 1;
            this.pbAspCur.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbAspCur.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbAspCur.TokenCount = 21;
            this.pbAspCur.UnselectedColor = System.Drawing.Color.Black;
            this.pbAspCur.Value = 0;
            this.pbAspCur.Changed += new System.EventHandler(this.ChangedCareer);
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // tblifelinescore
            // 
            this.tblifelinescore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tblifelinescore, "tblifelinescore");
            this.tblifelinescore.Name = "tblifelinescore";
            this.tblifelinescore.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pbCareerPerformance
            // 
            this.pbCareerPerformance.BackColor = System.Drawing.Color.Transparent;
            this.pbCareerPerformance.DisplayOffset = 0;
            resources.ApplyResources(this.pbCareerPerformance, "pbCareerPerformance");
            this.pbCareerPerformance.Maximum = 1000;
            this.pbCareerPerformance.Name = "pbCareerPerformance";
            this.pbCareerPerformance.NumberFormat = "N0";
            this.pbCareerPerformance.NumberOffset = 0;
            this.pbCareerPerformance.NumberScale = 1;
            this.pbCareerPerformance.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbCareerPerformance.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbCareerPerformance.TokenCount = 21;
            this.pbCareerPerformance.UnselectedColor = System.Drawing.Color.Black;
            this.pbCareerPerformance.Value = 10;
            this.pbCareerPerformance.Changed += new System.EventHandler(this.ChangedCareer);
            // 
            // pbCareerLevel
            // 
            this.pbCareerLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbCareerLevel.DisplayOffset = 0;
            resources.ApplyResources(this.pbCareerLevel, "pbCareerLevel");
            this.pbCareerLevel.Maximum = 10;
            this.pbCareerLevel.Name = "pbCareerLevel";
            this.pbCareerLevel.NumberFormat = "N0";
            this.pbCareerLevel.NumberOffset = 0;
            this.pbCareerLevel.NumberScale = 1;
            this.pbCareerLevel.SelectedColor = System.Drawing.Color.YellowGreen;
            this.pbCareerLevel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbCareerLevel.TokenCount = 10;
            this.pbCareerLevel.UnselectedColor = System.Drawing.Color.Black;
            this.pbCareerLevel.Value = 10;
            this.pbCareerLevel.Changed += new System.EventHandler(this.ChangedCareer);
            // 
            // label78
            // 
            resources.ApplyResources(this.label78, "label78");
            this.label78.Name = "label78";
            // 
            // tbschooltype
            // 
            this.tbschooltype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbschooltype, "tbschooltype");
            this.tbschooltype.Name = "tbschooltype";
            this.tbschooltype.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // label77
            // 
            resources.ApplyResources(this.label77, "label77");
            this.label77.Name = "label77";
            // 
            // cbgrade
            // 
            this.cbgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbgrade, "cbgrade");
            this.cbgrade.Name = "cbgrade";
            this.cbgrade.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // cbschooltype
            // 
            this.cbschooltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbschooltype, "cbschooltype");
            this.cbschooltype.Name = "cbschooltype";
            this.cbschooltype.SelectedIndexChanged += new System.EventHandler(this.cbschooltype_SelectedIndexChanged);
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // cbcareer
            // 
            this.cbcareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbcareer, "cbcareer");
            this.cbcareer.Name = "cbcareer";
            this.cbcareer.SelectedIndexChanged += new System.EventHandler(this.cbcareer_SelectedIndexChanged);
            // 
            // tbcareervalue
            // 
            this.tbcareervalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbcareervalue, "tbcareervalue");
            this.tbcareervalue.Name = "tbcareervalue";
            this.tbcareervalue.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pnInt
            // 
            resources.ApplyResources(this.pnInt, "pnInt");
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
            this.pnInt.Name = "pnInt";
            // 
            // pbSciFi
            // 
            this.pbSciFi.BackColor = System.Drawing.Color.Transparent;
            this.pbSciFi.DisplayOffset = 0;
            resources.ApplyResources(this.pbSciFi, "pbSciFi");
            this.pbSciFi.Maximum = 1000;
            this.pbSciFi.Name = "pbSciFi";
            this.pbSciFi.NumberFormat = "N1";
            this.pbSciFi.NumberOffset = 0;
            this.pbSciFi.NumberScale = 0.01;
            this.pbSciFi.SelectedColor = System.Drawing.Color.Lime;
            this.pbSciFi.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbSciFi.TokenCount = 10;
            this.pbSciFi.UnselectedColor = System.Drawing.Color.Black;
            this.pbSciFi.Value = 500;
            this.pbSciFi.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbToys
            // 
            this.pbToys.BackColor = System.Drawing.Color.Transparent;
            this.pbToys.DisplayOffset = 0;
            resources.ApplyResources(this.pbToys, "pbToys");
            this.pbToys.Maximum = 1000;
            this.pbToys.Name = "pbToys";
            this.pbToys.NumberFormat = "N1";
            this.pbToys.NumberOffset = 0;
            this.pbToys.NumberScale = 0.01;
            this.pbToys.SelectedColor = System.Drawing.Color.Lime;
            this.pbToys.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbToys.TokenCount = 10;
            this.pbToys.UnselectedColor = System.Drawing.Color.Black;
            this.pbToys.Value = 500;
            this.pbToys.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbSchool
            // 
            this.pbSchool.BackColor = System.Drawing.Color.Transparent;
            this.pbSchool.DisplayOffset = 0;
            resources.ApplyResources(this.pbSchool, "pbSchool");
            this.pbSchool.Maximum = 1000;
            this.pbSchool.Name = "pbSchool";
            this.pbSchool.NumberFormat = "N1";
            this.pbSchool.NumberOffset = 0;
            this.pbSchool.NumberScale = 0.01;
            this.pbSchool.SelectedColor = System.Drawing.Color.Lime;
            this.pbSchool.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbSchool.TokenCount = 10;
            this.pbSchool.UnselectedColor = System.Drawing.Color.Black;
            this.pbSchool.Value = 500;
            this.pbSchool.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbAnimals
            // 
            this.pbAnimals.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimals.DisplayOffset = 0;
            resources.ApplyResources(this.pbAnimals, "pbAnimals");
            this.pbAnimals.Maximum = 1000;
            this.pbAnimals.Name = "pbAnimals";
            this.pbAnimals.NumberFormat = "N1";
            this.pbAnimals.NumberOffset = 0;
            this.pbAnimals.NumberScale = 0.01;
            this.pbAnimals.SelectedColor = System.Drawing.Color.Lime;
            this.pbAnimals.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbAnimals.TokenCount = 10;
            this.pbAnimals.UnselectedColor = System.Drawing.Color.Black;
            this.pbAnimals.Value = 500;
            this.pbAnimals.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbWeather
            // 
            this.pbWeather.BackColor = System.Drawing.Color.Transparent;
            this.pbWeather.DisplayOffset = 0;
            resources.ApplyResources(this.pbWeather, "pbWeather");
            this.pbWeather.Maximum = 1000;
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.NumberFormat = "N1";
            this.pbWeather.NumberOffset = 0;
            this.pbWeather.NumberScale = 0.01;
            this.pbWeather.SelectedColor = System.Drawing.Color.Lime;
            this.pbWeather.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbWeather.TokenCount = 10;
            this.pbWeather.UnselectedColor = System.Drawing.Color.Black;
            this.pbWeather.Value = 500;
            this.pbWeather.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbWork
            // 
            this.pbWork.BackColor = System.Drawing.Color.Transparent;
            this.pbWork.DisplayOffset = 0;
            resources.ApplyResources(this.pbWork, "pbWork");
            this.pbWork.Maximum = 1000;
            this.pbWork.Name = "pbWork";
            this.pbWork.NumberFormat = "N1";
            this.pbWork.NumberOffset = 0;
            this.pbWork.NumberScale = 0.01;
            this.pbWork.SelectedColor = System.Drawing.Color.Lime;
            this.pbWork.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbWork.TokenCount = 10;
            this.pbWork.UnselectedColor = System.Drawing.Color.Black;
            this.pbWork.Value = 500;
            this.pbWork.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbTravel
            // 
            this.pbTravel.BackColor = System.Drawing.Color.Transparent;
            this.pbTravel.DisplayOffset = 0;
            resources.ApplyResources(this.pbTravel, "pbTravel");
            this.pbTravel.Maximum = 1000;
            this.pbTravel.Name = "pbTravel";
            this.pbTravel.NumberFormat = "N1";
            this.pbTravel.NumberOffset = 0;
            this.pbTravel.NumberScale = 0.01;
            this.pbTravel.SelectedColor = System.Drawing.Color.Lime;
            this.pbTravel.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbTravel.TokenCount = 10;
            this.pbTravel.UnselectedColor = System.Drawing.Color.Black;
            this.pbTravel.Value = 500;
            this.pbTravel.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbCrime
            // 
            this.pbCrime.BackColor = System.Drawing.Color.Transparent;
            this.pbCrime.DisplayOffset = 0;
            resources.ApplyResources(this.pbCrime, "pbCrime");
            this.pbCrime.Maximum = 1000;
            this.pbCrime.Name = "pbCrime";
            this.pbCrime.NumberFormat = "N1";
            this.pbCrime.NumberOffset = 0;
            this.pbCrime.NumberScale = 0.01;
            this.pbCrime.SelectedColor = System.Drawing.Color.Lime;
            this.pbCrime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbCrime.TokenCount = 10;
            this.pbCrime.UnselectedColor = System.Drawing.Color.Black;
            this.pbCrime.Value = 500;
            this.pbCrime.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbSports
            // 
            this.pbSports.BackColor = System.Drawing.Color.Transparent;
            this.pbSports.DisplayOffset = 0;
            resources.ApplyResources(this.pbSports, "pbSports");
            this.pbSports.Maximum = 1000;
            this.pbSports.Name = "pbSports";
            this.pbSports.NumberFormat = "N1";
            this.pbSports.NumberOffset = 0;
            this.pbSports.NumberScale = 0.01;
            this.pbSports.SelectedColor = System.Drawing.Color.Lime;
            this.pbSports.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbSports.TokenCount = 10;
            this.pbSports.UnselectedColor = System.Drawing.Color.Black;
            this.pbSports.Value = 500;
            this.pbSports.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbFashion
            // 
            this.pbFashion.BackColor = System.Drawing.Color.Transparent;
            this.pbFashion.DisplayOffset = 0;
            resources.ApplyResources(this.pbFashion, "pbFashion");
            this.pbFashion.Maximum = 1000;
            this.pbFashion.Name = "pbFashion";
            this.pbFashion.NumberFormat = "N1";
            this.pbFashion.NumberOffset = 0;
            this.pbFashion.NumberScale = 0.01;
            this.pbFashion.SelectedColor = System.Drawing.Color.Lime;
            this.pbFashion.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbFashion.TokenCount = 10;
            this.pbFashion.UnselectedColor = System.Drawing.Color.Black;
            this.pbFashion.Value = 500;
            this.pbFashion.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbHealth
            // 
            this.pbHealth.BackColor = System.Drawing.Color.Transparent;
            this.pbHealth.DisplayOffset = 0;
            resources.ApplyResources(this.pbHealth, "pbHealth");
            this.pbHealth.Maximum = 1000;
            this.pbHealth.Name = "pbHealth";
            this.pbHealth.NumberFormat = "N1";
            this.pbHealth.NumberOffset = 0;
            this.pbHealth.NumberScale = 0.01;
            this.pbHealth.SelectedColor = System.Drawing.Color.Lime;
            this.pbHealth.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbHealth.TokenCount = 10;
            this.pbHealth.UnselectedColor = System.Drawing.Color.Black;
            this.pbHealth.Value = 500;
            this.pbHealth.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbFood
            // 
            this.pbFood.BackColor = System.Drawing.Color.Transparent;
            this.pbFood.DisplayOffset = 0;
            resources.ApplyResources(this.pbFood, "pbFood");
            this.pbFood.Maximum = 1000;
            this.pbFood.Name = "pbFood";
            this.pbFood.NumberFormat = "N1";
            this.pbFood.NumberOffset = 0;
            this.pbFood.NumberScale = 0.01;
            this.pbFood.SelectedColor = System.Drawing.Color.Lime;
            this.pbFood.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbFood.TokenCount = 10;
            this.pbFood.UnselectedColor = System.Drawing.Color.Black;
            this.pbFood.Value = 500;
            this.pbFood.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbPolitics
            // 
            this.pbPolitics.BackColor = System.Drawing.Color.Transparent;
            this.pbPolitics.DisplayOffset = 0;
            resources.ApplyResources(this.pbPolitics, "pbPolitics");
            this.pbPolitics.Maximum = 1000;
            this.pbPolitics.Name = "pbPolitics";
            this.pbPolitics.NumberFormat = "N1";
            this.pbPolitics.NumberOffset = 0;
            this.pbPolitics.NumberScale = 0.01;
            this.pbPolitics.SelectedColor = System.Drawing.Color.Lime;
            this.pbPolitics.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbPolitics.TokenCount = 10;
            this.pbPolitics.UnselectedColor = System.Drawing.Color.Black;
            this.pbPolitics.Value = 500;
            this.pbPolitics.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbMoney
            // 
            this.pbMoney.BackColor = System.Drawing.Color.Transparent;
            this.pbMoney.DisplayOffset = 0;
            resources.ApplyResources(this.pbMoney, "pbMoney");
            this.pbMoney.Maximum = 1000;
            this.pbMoney.Name = "pbMoney";
            this.pbMoney.NumberFormat = "N1";
            this.pbMoney.NumberOffset = 0;
            this.pbMoney.NumberScale = 0.01;
            this.pbMoney.SelectedColor = System.Drawing.Color.Lime;
            this.pbMoney.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbMoney.TokenCount = 10;
            this.pbMoney.UnselectedColor = System.Drawing.Color.Black;
            this.pbMoney.Value = 500;
            this.pbMoney.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbCulture
            // 
            this.pbCulture.BackColor = System.Drawing.Color.Transparent;
            this.pbCulture.DisplayOffset = 0;
            resources.ApplyResources(this.pbCulture, "pbCulture");
            this.pbCulture.Maximum = 1000;
            this.pbCulture.Name = "pbCulture";
            this.pbCulture.NumberFormat = "N1";
            this.pbCulture.NumberOffset = 0;
            this.pbCulture.NumberScale = 0.01;
            this.pbCulture.SelectedColor = System.Drawing.Color.Lime;
            this.pbCulture.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbCulture.TokenCount = 10;
            this.pbCulture.UnselectedColor = System.Drawing.Color.Black;
            this.pbCulture.Value = 500;
            this.pbCulture.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbEntertainment
            // 
            this.pbEntertainment.BackColor = System.Drawing.Color.Transparent;
            this.pbEntertainment.DisplayOffset = 0;
            resources.ApplyResources(this.pbEntertainment, "pbEntertainment");
            this.pbEntertainment.Maximum = 1000;
            this.pbEntertainment.Name = "pbEntertainment";
            this.pbEntertainment.NumberFormat = "N1";
            this.pbEntertainment.NumberOffset = 0;
            this.pbEntertainment.NumberScale = 0.01;
            this.pbEntertainment.SelectedColor = System.Drawing.Color.Lime;
            this.pbEntertainment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbEntertainment.TokenCount = 10;
            this.pbEntertainment.UnselectedColor = System.Drawing.Color.Black;
            this.pbEntertainment.Value = 500;
            this.pbEntertainment.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbParanormal
            // 
            this.pbParanormal.BackColor = System.Drawing.Color.Transparent;
            this.pbParanormal.DisplayOffset = 0;
            resources.ApplyResources(this.pbParanormal, "pbParanormal");
            this.pbParanormal.Maximum = 1000;
            this.pbParanormal.Name = "pbParanormal";
            this.pbParanormal.NumberFormat = "N1";
            this.pbParanormal.NumberOffset = 0;
            this.pbParanormal.NumberScale = 0.01;
            this.pbParanormal.SelectedColor = System.Drawing.Color.Lime;
            this.pbParanormal.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbParanormal.TokenCount = 10;
            this.pbParanormal.UnselectedColor = System.Drawing.Color.Black;
            this.pbParanormal.Value = 500;
            this.pbParanormal.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pbEnvironment
            // 
            this.pbEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.pbEnvironment.DisplayOffset = 0;
            resources.ApplyResources(this.pbEnvironment, "pbEnvironment");
            this.pbEnvironment.Maximum = 1000;
            this.pbEnvironment.Name = "pbEnvironment";
            this.pbEnvironment.NumberFormat = "N1";
            this.pbEnvironment.NumberOffset = 0;
            this.pbEnvironment.NumberScale = 0.01;
            this.pbEnvironment.SelectedColor = System.Drawing.Color.Lime;
            this.pbEnvironment.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbEnvironment.TokenCount = 10;
            this.pbEnvironment.UnselectedColor = System.Drawing.Color.Black;
            this.pbEnvironment.Value = 500;
            this.pbEnvironment.Changed += new System.EventHandler(this.ChangedInt);
            // 
            // pnRel
            // 
            resources.ApplyResources(this.pnRel, "pnRel");
            this.pnRel.BackColor = System.Drawing.Color.Transparent;
            this.pnRel.Controls.Add(this.lv);
            this.pnRel.Controls.Add(this.panel3);
            this.pnRel.Name = "pnRel";
            this.pnRel.VisibleChanged += new System.EventHandler(this.pnRel_VisibleChanged);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Controls.Add(this.srcTb);
            this.panel3.Controls.Add(this.dstTb);
            this.panel3.Name = "panel3";
            // 
            // srcTb
            // 
            this.srcTb.BackColor = System.Drawing.Color.Transparent;
            this.srcTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.srcTb.BorderColor = System.Drawing.SystemColors.Window;
            this.srcTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.srcTb, "srcTb");
            this.srcTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.srcTb.IconLocation = new System.Drawing.Point(4, 6);
            this.srcTb.IconSize = new System.Drawing.Size(48, 32);
            this.srcTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.srcTb.Name = "srcTb";
            this.srcTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // dstTb
            // 
            this.dstTb.BackColor = System.Drawing.Color.Transparent;
            this.dstTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dstTb.BorderColor = System.Drawing.SystemColors.Window;
            this.dstTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.dstTb, "dstTb");
            this.dstTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dstTb.IconLocation = new System.Drawing.Point(4, 6);
            this.dstTb.IconSize = new System.Drawing.Size(48, 32);
            this.dstTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.dstTb.Name = "dstTb";
            this.dstTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // pnMisc
            // 
            resources.ApplyResources(this.pnMisc, "pnMisc");
            this.pnMisc.BackColor = System.Drawing.Color.Transparent;
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple3);
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple2);
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple1);
            this.pnMisc.Name = "pnMisc";
            // 
            // xpTaskBoxSimple3
            // 
            this.xpTaskBoxSimple3.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBoxSimple3.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.xpTaskBoxSimple3.BorderColor = System.Drawing.SystemColors.Window;
            this.xpTaskBoxSimple3.Controls.Add(this.label16);
            this.xpTaskBoxSimple3.Controls.Add(this.tbpetclass);
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
            this.xpTaskBoxSimple3.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.xpTaskBoxSimple3, "xpTaskBoxSimple3");
            this.xpTaskBoxSimple3.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple3.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple3.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple3.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple3.Name = "xpTaskBoxSimple3";
            this.xpTaskBoxSimple3.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // tbpetclass
            // 
            this.tbpetclass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbpetclass, "tbpetclass");
            this.tbpetclass.Name = "tbpetclass";
            this.tbpetclass.TextChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbstatmot
            // 
            this.tbstatmot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbstatmot, "tbstatmot");
            this.tbstatmot.Name = "tbstatmot";
            this.tbstatmot.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label96
            // 
            resources.ApplyResources(this.label96, "label96");
            this.label96.Name = "label96";
            // 
            // tbunlinked
            // 
            this.tbunlinked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbunlinked, "tbunlinked");
            this.tbunlinked.Name = "tbunlinked";
            this.tbunlinked.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label95
            // 
            resources.ApplyResources(this.label95, "label95");
            this.label95.Name = "label95";
            // 
            // tbagedur
            // 
            this.tbagedur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbagedur, "tbagedur");
            this.tbagedur.Name = "tbagedur";
            this.tbagedur.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // tbprevdays
            // 
            this.tbprevdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbprevdays, "tbprevdays");
            this.tbprevdays.Name = "tbprevdays";
            this.tbprevdays.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label94
            // 
            resources.ApplyResources(this.label94, "label94");
            this.label94.Name = "label94";
            // 
            // tbvoice
            // 
            this.tbvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbvoice, "tbvoice");
            this.tbvoice.Name = "tbvoice";
            this.tbvoice.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label90
            // 
            resources.ApplyResources(this.label90, "label90");
            this.label90.Name = "label90";
            // 
            // tbnpc
            // 
            this.tbnpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbnpc, "tbnpc");
            this.tbnpc.Name = "tbnpc";
            this.tbnpc.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label87
            // 
            resources.ApplyResources(this.label87, "label87");
            this.label87.Name = "label87";
            // 
            // tbautonomy
            // 
            this.tbautonomy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbautonomy, "tbautonomy");
            this.tbautonomy.Name = "tbautonomy";
            this.tbautonomy.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label86
            // 
            resources.ApplyResources(this.label86, "label86");
            this.label86.Name = "label86";
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
            this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.xpTaskBoxSimple2, "xpTaskBoxSimple2");
            this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple2.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple2.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
            this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbfit
            // 
            resources.ApplyResources(this.cbfit, "cbfit");
            this.cbfit.Name = "cbfit";
            this.cbfit.UseVisualStyleBackColor = false;
            this.cbfit.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpreginv
            // 
            resources.ApplyResources(this.cbpreginv, "cbpreginv");
            this.cbpreginv.Name = "cbpreginv";
            this.cbpreginv.UseVisualStyleBackColor = false;
            this.cbpreginv.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpreghalf
            // 
            resources.ApplyResources(this.cbpreghalf, "cbpreghalf");
            this.cbpreghalf.Name = "cbpreghalf";
            this.cbpreghalf.UseVisualStyleBackColor = false;
            this.cbpreghalf.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpregfull
            // 
            resources.ApplyResources(this.cbpregfull, "cbpregfull");
            this.cbpregfull.Name = "cbpregfull";
            this.cbpregfull.UseVisualStyleBackColor = false;
            this.cbpregfull.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbfat
            // 
            resources.ApplyResources(this.cbfat, "cbfat");
            this.cbfat.Name = "cbfat";
            this.cbfat.UseVisualStyleBackColor = false;
            this.cbfat.CheckedChanged += new System.EventHandler(this.ChangedOther);
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
            this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            resources.ApplyResources(this.xpTaskBoxSimple1, "xpTaskBoxSimple1");
            this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple1.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple1.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
            this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbisghost
            // 
            resources.ApplyResources(this.cbisghost, "cbisghost");
            this.cbisghost.Name = "cbisghost";
            this.cbisghost.UseVisualStyleBackColor = false;
            this.cbisghost.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbignoretraversal
            // 
            resources.ApplyResources(this.cbignoretraversal, "cbignoretraversal");
            this.cbignoretraversal.Name = "cbignoretraversal";
            this.cbignoretraversal.UseVisualStyleBackColor = false;
            this.cbignoretraversal.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpasspeople
            // 
            resources.ApplyResources(this.cbpasspeople, "cbpasspeople");
            this.cbpasspeople.Name = "cbpasspeople";
            this.cbpasspeople.UseVisualStyleBackColor = false;
            this.cbpasspeople.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpasswalls
            // 
            resources.ApplyResources(this.cbpasswalls, "cbpasswalls");
            this.cbpasswalls.Name = "cbpasswalls";
            this.cbpasswalls.UseVisualStyleBackColor = false;
            this.cbpasswalls.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpassobject
            // 
            resources.ApplyResources(this.cbpassobject, "cbpassobject");
            this.cbpassobject.Name = "cbpassobject";
            this.cbpassobject.UseVisualStyleBackColor = false;
            this.cbpassobject.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // pnEP1
            // 
            resources.ApplyResources(this.pnEP1, "pnEP1");
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
            this.pnEP1.Name = "pnEP1";
            // 
            // pbLastGrade
            // 
            this.pbLastGrade.BackColor = System.Drawing.Color.Transparent;
            this.pbLastGrade.DisplayOffset = 0;
            resources.ApplyResources(this.pbLastGrade, "pbLastGrade");
            this.pbLastGrade.Maximum = 1000;
            this.pbLastGrade.Name = "pbLastGrade";
            this.pbLastGrade.NumberFormat = "N1";
            this.pbLastGrade.NumberOffset = 0;
            this.pbLastGrade.NumberScale = 0.004;
            this.pbLastGrade.SelectedColor = System.Drawing.Color.OrangeRed;
            this.pbLastGrade.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbLastGrade.TokenCount = 4;
            this.pbLastGrade.UnselectedColor = System.Drawing.Color.Black;
            this.pbLastGrade.Value = 0;
            this.pbLastGrade.Changed += new System.EventHandler(this.ChangedEP1);
            // 
            // pbUniTime
            // 
            this.pbUniTime.BackColor = System.Drawing.Color.Transparent;
            this.pbUniTime.DisplayOffset = 0;
            resources.ApplyResources(this.pbUniTime, "pbUniTime");
            this.pbUniTime.Maximum = 72;
            this.pbUniTime.Name = "pbUniTime";
            this.pbUniTime.NumberFormat = "N0";
            this.pbUniTime.NumberOffset = 0;
            this.pbUniTime.NumberScale = 1;
            this.pbUniTime.SelectedColor = System.Drawing.Color.Lime;
            this.pbUniTime.Style = Ambertation.Windows.Forms.ProgresBarStyle.Flat;
            this.pbUniTime.TokenCount = 18;
            this.pbUniTime.UnselectedColor = System.Drawing.Color.Black;
            this.pbUniTime.Value = 0;
            this.pbUniTime.Changed += new System.EventHandler(this.ChangedEP1);
            // 
            // pbEffort
            // 
            this.pbEffort.BackColor = System.Drawing.Color.Transparent;
            this.pbEffort.DisplayOffset = 0;
            resources.ApplyResources(this.pbEffort, "pbEffort");
            this.pbEffort.Maximum = 1000;
            this.pbEffort.Name = "pbEffort";
            this.pbEffort.NumberFormat = "N2";
            this.pbEffort.NumberOffset = 0;
            this.pbEffort.NumberScale = 0.01;
            this.pbEffort.SelectedColor = System.Drawing.Color.Lime;
            this.pbEffort.Style = Ambertation.Windows.Forms.ProgresBarStyle.Increase;
            this.pbEffort.TokenCount = 10;
            this.pbEffort.UnselectedColor = System.Drawing.Color.Black;
            this.pbEffort.Value = 0;
            this.pbEffort.Changed += new System.EventHandler(this.ChangedEP1);
            // 
            // tbinfluence
            // 
            resources.ApplyResources(this.tbinfluence, "tbinfluence");
            this.tbinfluence.Name = "tbinfluence";
            this.tbinfluence.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // tbsemester
            // 
            resources.ApplyResources(this.tbsemester, "tbsemester");
            this.tbsemester.Name = "tbsemester";
            this.tbsemester.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // label103
            // 
            resources.ApplyResources(this.label103, "label103");
            this.label103.Name = "label103";
            // 
            // label101
            // 
            resources.ApplyResources(this.label101, "label101");
            this.label101.Name = "label101";
            // 
            // cboncampus
            // 
            resources.ApplyResources(this.cboncampus, "cboncampus");
            this.cboncampus.Name = "cboncampus";
            this.cboncampus.UseVisualStyleBackColor = false;
            this.cboncampus.CheckedChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // cbmajor
            // 
            this.cbmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbmajor, "cbmajor");
            this.cbmajor.Name = "cbmajor";
            this.cbmajor.SelectedIndexChanged += new System.EventHandler(this.cbmajor_SelectedIndexChanged);
            // 
            // label98
            // 
            resources.ApplyResources(this.label98, "label98");
            this.label98.Name = "label98";
            // 
            // tbmajor
            // 
            this.tbmajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.tbmajor, "tbmajor");
            this.tbmajor.Name = "tbmajor";
            this.tbmajor.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // pnEP2
            // 
            resources.ApplyResources(this.pnEP2, "pnEP2");
            this.pnEP2.BackColor = System.Drawing.Color.Transparent;
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
            this.pnEP2.Name = "pnEP2";
            // 
            // tbNTLove
            // 
            resources.ApplyResources(this.tbNTLove, "tbNTLove");
            this.tbNTLove.Name = "tbNTLove";
            this.tbNTLove.TextChanged += new System.EventHandler(this.ChangedEP2);
            // 
            // tbNTPerfume
            // 
            resources.ApplyResources(this.tbNTPerfume, "tbNTPerfume");
            this.tbNTPerfume.Name = "tbNTPerfume";
            this.tbNTPerfume.TextChanged += new System.EventHandler(this.ChangedEP2);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbTurnOff
            // 
            resources.ApplyResources(this.lbTurnOff, "lbTurnOff");
            this.lbTurnOff.Name = "lbTurnOff";
            this.lbTurnOff.SelectedIndexChanged += new System.EventHandler(this.lbTurnOff_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbTurnOn
            // 
            resources.ApplyResources(this.lbTurnOn, "lbTurnOn");
            this.lbTurnOn.Name = "lbTurnOn";
            this.lbTurnOn.SelectedIndexChanged += new System.EventHandler(this.lbTurnOn_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbTraits
            // 
            resources.ApplyResources(this.lbTraits, "lbTraits");
            this.lbTraits.Name = "lbTraits";
            this.lbTraits.SelectedIndexChanged += new System.EventHandler(this.lbTraits_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pnEP3
            // 
            resources.ApplyResources(this.pnEP3, "pnEP3");
            this.pnEP3.BackColor = System.Drawing.Color.Transparent;
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
            this.pnEP3.Name = "pnEP3";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // llep3openinfo
            // 
            resources.ApplyResources(this.llep3openinfo, "llep3openinfo");
            this.llep3openinfo.Name = "llep3openinfo";
            this.llep3openinfo.TabStop = true;
            this.llep3openinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llep3openinfo_LinkClicked);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // sblb
            // 
            resources.ApplyResources(this.sblb, "sblb");
            this.sblb.Name = "sblb";
            this.sblb.SimDescription = null;
            this.sblb.SelectedBusinessChanged += new System.EventHandler(this.sblb_SelectedBusinessChanged);
            // 
            // tbEp3Salery
            // 
            resources.ApplyResources(this.tbEp3Salery, "tbEp3Salery");
            this.tbEp3Salery.Name = "tbEp3Salery";
            this.tbEp3Salery.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cbEp3Asgn
            // 
            this.cbEp3Asgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEp3Asgn.Enum = null;
            this.cbEp3Asgn.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.cbEp3Asgn, "cbEp3Asgn");
            this.cbEp3Asgn.Name = "cbEp3Asgn";
            this.cbEp3Asgn.ResourceManager = null;
            this.cbEp3Asgn.SelectedValueChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // tbEp3Flag
            // 
            resources.ApplyResources(this.tbEp3Flag, "tbEp3Flag");
            this.tbEp3Flag.Name = "tbEp3Flag";
            this.tbEp3Flag.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // tbEp3Lot
            // 
            resources.ApplyResources(this.tbEp3Lot, "tbEp3Lot");
            this.tbEp3Lot.Name = "tbEp3Lot";
            this.tbEp3Lot.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // ExtSDesc
            // 
            this.Controls.Add(this.pnMisc);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.pnRel);
            this.Controls.Add(this.pnId);
            this.Controls.Add(this.pnCareer);
            this.Controls.Add(this.pnEP1);
            this.Controls.Add(this.pnEP3);
            this.Controls.Add(this.pnInt);
            this.Controls.Add(this.pnChar);
            this.Controls.Add(this.pnSkill);
            this.Controls.Add(this.pnEP2);
            resources.ApplyResources(this, "$this");
            this.HeaderText = null;
            this.Name = "ExtSDesc";
            this.Controls.SetChildIndex(this.pnEP2, 0);
            this.Controls.SetChildIndex(this.pnSkill, 0);
            this.Controls.SetChildIndex(this.pnChar, 0);
            this.Controls.SetChildIndex(this.pnInt, 0);
            this.Controls.SetChildIndex(this.pnEP3, 0);
            this.Controls.SetChildIndex(this.pnEP1, 0);
            this.Controls.SetChildIndex(this.pnCareer, 0);
            this.Controls.SetChildIndex(this.pnId, 0);
            this.Controls.SetChildIndex(this.pnRel, 0);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.pnMisc, 0);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.pnId.ResumeLayout(false);
            this.pnId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnSkill.ResumeLayout(false);
            this.pnChar.ResumeLayout(false);
            this.mbiLink.ResumeLayout(false);
            this.miRel.ResumeLayout(false);
            this.pnCareer.ResumeLayout(false);
            this.pnCareer.PerformLayout();
            this.pnInt.ResumeLayout(false);
            this.pnRel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pnMisc.ResumeLayout(false);
            this.xpTaskBoxSimple3.ResumeLayout(false);
            this.xpTaskBoxSimple3.PerformLayout();
            this.xpTaskBoxSimple2.ResumeLayout(false);
            this.xpTaskBoxSimple1.ResumeLayout(false);
            this.pnEP1.ResumeLayout(false);
            this.pnEP1.PerformLayout();
            this.pnEP2.ResumeLayout(false);
            this.pnEP2.PerformLayout();
            this.pnEP3.ResumeLayout(false);
            this.pnEP3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}        
		#endregion


		public void SelectButton(ToolStripButton b)
		{
			for (int i=0; i<this.toolBar1.Items.Count; i++)
			{
				if (toolBar1.Items[i] is ToolStripButton ) 
				{
					ToolStripButton item = (ToolStripButton )toolBar1.Items[i];
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
			SelectButton((ToolStripButton)sender);
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
			this.cbcareer.Items.Add(new LocalizedCareers(Data.MetaData.Careers.Economy));
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
			if ((SimPe.PathProvider.Global.EPInstalled>=1) || (Helper.WindowsRegistry.HiddenMode))
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
                RefreshEP4(Sdesc);
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
            lv.Sim = Sdesc; 
            if (Sdesc == null) lv.Package = null;
            else lv.Package = Sdesc.Package;
            ResetLabel();
            loadedRel = true;
            
			/*lv.BeginUpdate();
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
			lv.Sort();*/
		}

		void UpdateRelList()
		{
            lv.Sim = Sdesc;
			/*ArrayList inst = new ArrayList();
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
			lv.Sort();*/
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
			/*this.lv.TileColumns = new int[]{1, 2, 6, 3, 4, 5};
			this.lv.SetColumnStyle(1, lv.Font, Color.Gray);
			this.lv.SetColumnStyle(2, lv.Font, Color.Gray);
			this.lv.SetColumnStyle(3, lv.Font, Color.Gray);			
			this.lv.SetColumnStyle(4, lv.Font, Color.Gray);*/

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

        void lv_SelectedSimChanged(object sender, Image thumb, SimPe.PackedFiles.Wrapper.SDesc sdesc)
        {
            SelectedSimRelationChanged(sender, null);
        }

		private void SelectedSimRelationChanged(object sender, System.EventArgs e)
		{
			if (lv.SelectedItems.Count!=1) return;

			PackedFiles.Wrapper.ExtSDesc sdesc = (PackedFiles.Wrapper.ExtSDesc)lv.SelectedItems[0].Tag;

			
			DiplayRelation(Sdesc, sdesc, srcRel);
			DiplayRelation(sdesc, Sdesc, dstRel);						
			
			
			UpdateLabel();
		}
		
		

		private void miRel_BeforePopup(object sender, System.EventArgs e)
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
				this.mbiMaxKnownRel.Enabled = true;

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
            lv.UpdateIcon();
			SelectedSimRelationChanged(lv, null);
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
            lv.UpdateIcon();
			SelectedSimRelationChanged(lv, null);
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
		
			this.SelectedSimRelationChanged(lv, null);
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

        void RefreshEP4(Wrapper.ExtSDesc sdesc)
        {
            this.tbpetclass.Enabled = (int)sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Pets;

            this.tbpetclass.Text = Helper.HexString(sdesc.Pets.PetClass);            
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

        private void ChangedEP4(object sender, System.EventArgs e)
        {
            if (intern) return;
            intern = true;
            try
            {
                if ((int)Sdesc.Version >= (int)SimPe.PackedFiles.Wrapper.SDescVersions.Pets)
                {
                    Sdesc.Pets.PetClass = Helper.StringToUInt16(this.tbpetclass.Text, Sdesc.Pets.PetClass, 16);
                    Sdesc.Changed = true;
                }
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
