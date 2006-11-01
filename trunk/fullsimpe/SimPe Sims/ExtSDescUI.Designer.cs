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
    partial class ExtSDesc
    {

        /// <summary> 
        /// Die verwendeten Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
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
            this.label16 = new System.Windows.Forms.Label();
            this.cbSpecies = new Ambertation.Windows.Forms.EnumComboBox();
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
            this.pnPetChar = new System.Windows.Forms.Panel();
            this.ptPigpen = new SimPe.PackedFiles.Wrapper.PetTraitSelect();
            this.ptAggres = new SimPe.PackedFiles.Wrapper.PetTraitSelect();
            this.ptIndep = new SimPe.PackedFiles.Wrapper.PetTraitSelect();
            this.ptHyper = new SimPe.PackedFiles.Wrapper.PetTraitSelect();
            this.ptGifted = new SimPe.PackedFiles.Wrapper.PetTraitSelect();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pnHumanChar = new System.Windows.Forms.Panel();
            this.pbNeat = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbOutgoing = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbActive = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbPlayful = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbGNice = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbNice = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbGPlayful = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbGNeat = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbGActive = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbGOutgoing = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbMan = new Ambertation.Windows.Forms.LabeledProgressBar();
            this.pbWoman = new Ambertation.Windows.Forms.LabeledProgressBar();
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
            this.lv = new SimPe.PackedFiles.Wrapper.SimRelationPoolControl();
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
            this.toolBar1.SuspendLayout();
            this.pnId.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.pnSkill.SuspendLayout();
            this.pnChar.SuspendLayout();
            this.pnPetChar.SuspendLayout();
            this.pnHumanChar.SuspendLayout();
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
            this.toolBar1.AccessibleDescription = null;
            this.toolBar1.AccessibleName = null;
            resources.ApplyResources(this.toolBar1, "toolBar1");
            this.toolBar1.BackgroundImage = null;
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
            this.biId.AccessibleDescription = null;
            this.biId.AccessibleName = null;
            resources.ApplyResources(this.biId, "biId");
            this.biId.BackgroundImage = null;
            this.biId.Name = "biId";
            this.biId.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biCareer
            // 
            this.biCareer.AccessibleDescription = null;
            this.biCareer.AccessibleName = null;
            resources.ApplyResources(this.biCareer, "biCareer");
            this.biCareer.BackgroundImage = null;
            this.biCareer.Name = "biCareer";
            this.biCareer.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biRel
            // 
            this.biRel.AccessibleDescription = null;
            this.biRel.AccessibleName = null;
            resources.ApplyResources(this.biRel, "biRel");
            this.biRel.BackgroundImage = null;
            this.biRel.Name = "biRel";
            this.biRel.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biInt
            // 
            this.biInt.AccessibleDescription = null;
            this.biInt.AccessibleName = null;
            resources.ApplyResources(this.biInt, "biInt");
            this.biInt.BackgroundImage = null;
            this.biInt.Name = "biInt";
            this.biInt.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biChar
            // 
            this.biChar.AccessibleDescription = null;
            this.biChar.AccessibleName = null;
            resources.ApplyResources(this.biChar, "biChar");
            this.biChar.BackgroundImage = null;
            this.biChar.Name = "biChar";
            this.biChar.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biSkill
            // 
            this.biSkill.AccessibleDescription = null;
            this.biSkill.AccessibleName = null;
            resources.ApplyResources(this.biSkill, "biSkill");
            this.biSkill.BackgroundImage = null;
            this.biSkill.Name = "biSkill";
            this.biSkill.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biMisc
            // 
            this.biMisc.AccessibleDescription = null;
            this.biMisc.AccessibleName = null;
            resources.ApplyResources(this.biMisc, "biMisc");
            this.biMisc.BackgroundImage = null;
            this.biMisc.Name = "biMisc";
            this.biMisc.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP1
            // 
            this.biEP1.AccessibleDescription = null;
            this.biEP1.AccessibleName = null;
            resources.ApplyResources(this.biEP1, "biEP1");
            this.biEP1.BackgroundImage = null;
            this.biEP1.Name = "biEP1";
            this.biEP1.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP2
            // 
            this.biEP2.AccessibleDescription = null;
            this.biEP2.AccessibleName = null;
            resources.ApplyResources(this.biEP2, "biEP2");
            this.biEP2.BackgroundImage = null;
            this.biEP2.Name = "biEP2";
            this.biEP2.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biEP3
            // 
            this.biEP3.AccessibleDescription = null;
            this.biEP3.AccessibleName = null;
            resources.ApplyResources(this.biEP3, "biEP3");
            this.biEP3.BackgroundImage = null;
            this.biEP3.Name = "biEP3";
            this.biEP3.Click += new System.EventHandler(this.ChoosePage);
            // 
            // biMore
            // 
            this.biMore.AccessibleDescription = null;
            this.biMore.AccessibleName = null;
            resources.ApplyResources(this.biMore, "biMore");
            this.biMore.BackgroundImage = null;
            this.biMore.Name = "biMore";
            this.biMore.Click += new System.EventHandler(this.Activate_biMore);
            // 
            // biMax
            // 
            this.biMax.AccessibleDescription = null;
            this.biMax.AccessibleName = null;
            this.biMax.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            resources.ApplyResources(this.biMax, "biMax");
            this.biMax.BackgroundImage = null;
            this.biMax.Name = "biMax";
            this.biMax.Click += new System.EventHandler(this.Activate_biMax);
            // 
            // mbiMax
            // 
            this.mbiMax.AccessibleDescription = null;
            this.mbiMax.AccessibleName = null;
            resources.ApplyResources(this.mbiMax, "mbiMax");
            this.mbiMax.BackgroundImage = null;
            this.mbiMax.Name = "mbiMax";
            this.mbiMax.ShortcutKeyDisplayString = null;
            this.mbiMax.Click += new System.EventHandler(this.Activate_biMax);
            // 
            // pnId
            // 
            this.pnId.AccessibleDescription = null;
            this.pnId.AccessibleName = null;
            resources.ApplyResources(this.pnId, "pnId");
            this.pnId.BackColor = System.Drawing.Color.Transparent;
            this.pnId.BackgroundImage = null;
            this.pnId.Controls.Add(this.label16);
            this.pnId.Controls.Add(this.cbSpecies);
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
            this.pnId.Font = null;
            this.pnId.Name = "pnId";
            // 
            // label16
            // 
            this.label16.AccessibleDescription = null;
            this.label16.AccessibleName = null;
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // cbSpecies
            // 
            this.cbSpecies.AccessibleDescription = null;
            this.cbSpecies.AccessibleName = null;
            resources.ApplyResources(this.cbSpecies, "cbSpecies");
            this.cbSpecies.BackgroundImage = null;
            this.cbSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpecies.Enum = null;
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.ResourceManager = null;
            this.cbSpecies.SelectionChangeCommitted += new System.EventHandler(this.ChangedEP2);
            // 
            // label2
            // 
            this.label2.AccessibleDescription = null;
            this.label2.AccessibleName = null;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.AccessibleDescription = null;
            this.label1.AccessibleName = null;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbsimdescfamname
            // 
            this.tbsimdescfamname.AccessibleDescription = null;
            this.tbsimdescfamname.AccessibleName = null;
            resources.ApplyResources(this.tbsimdescfamname, "tbsimdescfamname");
            this.tbsimdescfamname.BackgroundImage = null;
            this.tbsimdescfamname.Name = "tbsimdescfamname";
            this.tbsimdescfamname.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // tbfaminst
            // 
            this.tbfaminst.AccessibleDescription = null;
            this.tbfaminst.AccessibleName = null;
            resources.ApplyResources(this.tbfaminst, "tbfaminst");
            this.tbfaminst.BackgroundImage = null;
            this.tbfaminst.Name = "tbfaminst";
            this.tbfaminst.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label49
            // 
            this.label49.AccessibleDescription = null;
            this.label49.AccessibleName = null;
            resources.ApplyResources(this.label49, "label49");
            this.label49.Name = "label49";
            // 
            // rbmale
            // 
            this.rbmale.AccessibleDescription = null;
            this.rbmale.AccessibleName = null;
            resources.ApplyResources(this.rbmale, "rbmale");
            this.rbmale.BackgroundImage = null;
            this.rbmale.Name = "rbmale";
            this.rbmale.CheckedChanged += new System.EventHandler(this.ChangedId);
            // 
            // rbfemale
            // 
            this.rbfemale.AccessibleDescription = null;
            this.rbfemale.AccessibleName = null;
            resources.ApplyResources(this.rbfemale, "rbfemale");
            this.rbfemale.BackgroundImage = null;
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.CheckedChanged += new System.EventHandler(this.ChangedId);
            // 
            // pbImage
            // 
            this.pbImage.AccessibleDescription = null;
            this.pbImage.AccessibleName = null;
            resources.ApplyResources(this.pbImage, "pbImage");
            this.pbImage.BackColor = System.Drawing.Color.Transparent;
            this.pbImage.BackgroundImage = null;
            this.pbImage.Font = null;
            this.pbImage.ImageLocation = null;
            this.pbImage.Name = "pbImage";
            this.pbImage.TabStop = false;
            // 
            // tbsimdescname
            // 
            this.tbsimdescname.AccessibleDescription = null;
            this.tbsimdescname.AccessibleName = null;
            resources.ApplyResources(this.tbsimdescname, "tbsimdescname");
            this.tbsimdescname.BackgroundImage = null;
            this.tbsimdescname.Name = "tbsimdescname";
            this.tbsimdescname.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label13
            // 
            this.label13.AccessibleDescription = null;
            this.label13.AccessibleName = null;
            resources.ApplyResources(this.label13, "label13");
            this.label13.Name = "label13";
            // 
            // tbsim
            // 
            this.tbsim.AccessibleDescription = null;
            this.tbsim.AccessibleName = null;
            resources.ApplyResources(this.tbsim, "tbsim");
            this.tbsim.BackgroundImage = null;
            this.tbsim.Name = "tbsim";
            this.tbsim.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label10
            // 
            this.label10.AccessibleDescription = null;
            this.label10.AccessibleName = null;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbage
            // 
            this.tbage.AccessibleDescription = null;
            this.tbage.AccessibleName = null;
            resources.ApplyResources(this.tbage, "tbage");
            this.tbage.BackgroundImage = null;
            this.tbage.Name = "tbage";
            this.tbage.TextChanged += new System.EventHandler(this.ChangedId);
            // 
            // label48
            // 
            this.label48.AccessibleDescription = null;
            this.label48.AccessibleName = null;
            resources.ApplyResources(this.label48, "label48");
            this.label48.Name = "label48";
            // 
            // cblifesection
            // 
            this.cblifesection.AccessibleDescription = null;
            this.cblifesection.AccessibleName = null;
            resources.ApplyResources(this.cblifesection, "cblifesection");
            this.cblifesection.BackgroundImage = null;
            this.cblifesection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cblifesection.Name = "cblifesection";
            this.cblifesection.SelectedValueChanged += new System.EventHandler(this.ChangedId);
            // 
            // pnSkill
            // 
            this.pnSkill.AccessibleDescription = null;
            this.pnSkill.AccessibleName = null;
            resources.ApplyResources(this.pnSkill, "pnSkill");
            this.pnSkill.BackColor = System.Drawing.Color.Transparent;
            this.pnSkill.BackgroundImage = null;
            this.pnSkill.Controls.Add(this.pbBody);
            this.pnSkill.Controls.Add(this.pbRomance);
            this.pnSkill.Controls.Add(this.pbFat);
            this.pnSkill.Controls.Add(this.pbClean);
            this.pnSkill.Controls.Add(this.pbCreative);
            this.pnSkill.Controls.Add(this.pbCharisma);
            this.pnSkill.Controls.Add(this.pbMech);
            this.pnSkill.Controls.Add(this.pbLogic);
            this.pnSkill.Controls.Add(this.pbCooking);
            this.pnSkill.Font = null;
            this.pnSkill.Name = "pnSkill";
            // 
            // pbBody
            // 
            this.pbBody.AccessibleDescription = null;
            this.pbBody.AccessibleName = null;
            resources.ApplyResources(this.pbBody, "pbBody");
            this.pbBody.BackColor = System.Drawing.Color.Transparent;
            this.pbBody.BackgroundImage = null;
            this.pbBody.DisplayOffset = 0;
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
            this.pbRomance.AccessibleDescription = null;
            this.pbRomance.AccessibleName = null;
            resources.ApplyResources(this.pbRomance, "pbRomance");
            this.pbRomance.BackColor = System.Drawing.Color.Transparent;
            this.pbRomance.BackgroundImage = null;
            this.pbRomance.DisplayOffset = 0;
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
            this.pbFat.AccessibleDescription = null;
            this.pbFat.AccessibleName = null;
            resources.ApplyResources(this.pbFat, "pbFat");
            this.pbFat.BackColor = System.Drawing.Color.Transparent;
            this.pbFat.BackgroundImage = null;
            this.pbFat.DisplayOffset = 0;
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
            this.pbClean.AccessibleDescription = null;
            this.pbClean.AccessibleName = null;
            resources.ApplyResources(this.pbClean, "pbClean");
            this.pbClean.BackColor = System.Drawing.Color.Transparent;
            this.pbClean.BackgroundImage = null;
            this.pbClean.DisplayOffset = 0;
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
            this.pbCreative.AccessibleDescription = null;
            this.pbCreative.AccessibleName = null;
            resources.ApplyResources(this.pbCreative, "pbCreative");
            this.pbCreative.BackColor = System.Drawing.Color.Transparent;
            this.pbCreative.BackgroundImage = null;
            this.pbCreative.DisplayOffset = 0;
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
            this.pbCharisma.AccessibleDescription = null;
            this.pbCharisma.AccessibleName = null;
            resources.ApplyResources(this.pbCharisma, "pbCharisma");
            this.pbCharisma.BackColor = System.Drawing.Color.Transparent;
            this.pbCharisma.BackgroundImage = null;
            this.pbCharisma.DisplayOffset = 0;
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
            this.pbMech.AccessibleDescription = null;
            this.pbMech.AccessibleName = null;
            resources.ApplyResources(this.pbMech, "pbMech");
            this.pbMech.BackColor = System.Drawing.Color.Transparent;
            this.pbMech.BackgroundImage = null;
            this.pbMech.DisplayOffset = 0;
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
            this.pbLogic.AccessibleDescription = null;
            this.pbLogic.AccessibleName = null;
            resources.ApplyResources(this.pbLogic, "pbLogic");
            this.pbLogic.BackColor = System.Drawing.Color.Transparent;
            this.pbLogic.BackgroundImage = null;
            this.pbLogic.DisplayOffset = 0;
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
            this.pbCooking.AccessibleDescription = null;
            this.pbCooking.AccessibleName = null;
            resources.ApplyResources(this.pbCooking, "pbCooking");
            this.pbCooking.BackColor = System.Drawing.Color.Transparent;
            this.pbCooking.BackgroundImage = null;
            this.pbCooking.DisplayOffset = 0;
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
            this.pnChar.AccessibleDescription = null;
            this.pnChar.AccessibleName = null;
            resources.ApplyResources(this.pnChar, "pnChar");
            this.pnChar.BackColor = System.Drawing.Color.Transparent;
            this.pnChar.BackgroundImage = null;
            this.pnChar.Controls.Add(this.pnPetChar);
            this.pnChar.Controls.Add(this.pnHumanChar);
            this.pnChar.Controls.Add(this.pbMan);
            this.pnChar.Controls.Add(this.pbWoman);
            this.pnChar.Controls.Add(this.cbzodiac);
            this.pnChar.Controls.Add(this.label47);
            this.pnChar.Controls.Add(this.panel2);
            this.pnChar.Controls.Add(this.label69);
            this.pnChar.Controls.Add(this.panel1);
            this.pnChar.Controls.Add(this.label70);
            this.pnChar.Font = null;
            this.pnChar.Name = "pnChar";
            // 
            // pnPetChar
            // 
            this.pnPetChar.AccessibleDescription = null;
            this.pnPetChar.AccessibleName = null;
            resources.ApplyResources(this.pnPetChar, "pnPetChar");
            this.pnPetChar.BackColor = System.Drawing.Color.Transparent;
            this.pnPetChar.BackgroundImage = null;
            this.pnPetChar.Controls.Add(this.ptPigpen);
            this.pnPetChar.Controls.Add(this.ptAggres);
            this.pnPetChar.Controls.Add(this.ptIndep);
            this.pnPetChar.Controls.Add(this.ptHyper);
            this.pnPetChar.Controls.Add(this.ptGifted);
            this.pnPetChar.Controls.Add(this.label21);
            this.pnPetChar.Controls.Add(this.label20);
            this.pnPetChar.Controls.Add(this.label19);
            this.pnPetChar.Controls.Add(this.label18);
            this.pnPetChar.Controls.Add(this.label17);
            this.pnPetChar.Font = null;
            this.pnPetChar.Name = "pnPetChar";
            // 
            // ptPigpen
            // 
            this.ptPigpen.AccessibleDescription = null;
            this.ptPigpen.AccessibleName = null;
            resources.ApplyResources(this.ptPigpen, "ptPigpen");
            this.ptPigpen.BackgroundImage = null;
            this.ptPigpen.Font = null;
            this.ptPigpen.Level = SimPe.PackedFiles.Wrapper.PetTraitSelect.Levels.Normal;
            this.ptPigpen.Name = "ptPigpen";
            this.ptPigpen.LevelChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // ptAggres
            // 
            this.ptAggres.AccessibleDescription = null;
            this.ptAggres.AccessibleName = null;
            resources.ApplyResources(this.ptAggres, "ptAggres");
            this.ptAggres.BackgroundImage = null;
            this.ptAggres.Font = null;
            this.ptAggres.Level = SimPe.PackedFiles.Wrapper.PetTraitSelect.Levels.Normal;
            this.ptAggres.Name = "ptAggres";
            this.ptAggres.LevelChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // ptIndep
            // 
            this.ptIndep.AccessibleDescription = null;
            this.ptIndep.AccessibleName = null;
            resources.ApplyResources(this.ptIndep, "ptIndep");
            this.ptIndep.BackgroundImage = null;
            this.ptIndep.Font = null;
            this.ptIndep.Level = SimPe.PackedFiles.Wrapper.PetTraitSelect.Levels.Normal;
            this.ptIndep.Name = "ptIndep";
            this.ptIndep.LevelChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // ptHyper
            // 
            this.ptHyper.AccessibleDescription = null;
            this.ptHyper.AccessibleName = null;
            resources.ApplyResources(this.ptHyper, "ptHyper");
            this.ptHyper.BackgroundImage = null;
            this.ptHyper.Font = null;
            this.ptHyper.Level = SimPe.PackedFiles.Wrapper.PetTraitSelect.Levels.Normal;
            this.ptHyper.Name = "ptHyper";
            this.ptHyper.LevelChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // ptGifted
            // 
            this.ptGifted.AccessibleDescription = null;
            this.ptGifted.AccessibleName = null;
            resources.ApplyResources(this.ptGifted, "ptGifted");
            this.ptGifted.BackgroundImage = null;
            this.ptGifted.Font = null;
            this.ptGifted.Level = SimPe.PackedFiles.Wrapper.PetTraitSelect.Levels.Normal;
            this.ptGifted.Name = "ptGifted";
            this.ptGifted.LevelChanged += new System.EventHandler(this.ChangedEP4);
            // 
            // label21
            // 
            this.label21.AccessibleDescription = null;
            this.label21.AccessibleName = null;
            resources.ApplyResources(this.label21, "label21");
            this.label21.Name = "label21";
            // 
            // label20
            // 
            this.label20.AccessibleDescription = null;
            this.label20.AccessibleName = null;
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // label19
            // 
            this.label19.AccessibleDescription = null;
            this.label19.AccessibleName = null;
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // label18
            // 
            this.label18.AccessibleDescription = null;
            this.label18.AccessibleName = null;
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // label17
            // 
            this.label17.AccessibleDescription = null;
            this.label17.AccessibleName = null;
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // pnHumanChar
            // 
            this.pnHumanChar.AccessibleDescription = null;
            this.pnHumanChar.AccessibleName = null;
            resources.ApplyResources(this.pnHumanChar, "pnHumanChar");
            this.pnHumanChar.BackgroundImage = null;
            this.pnHumanChar.Controls.Add(this.pbNeat);
            this.pnHumanChar.Controls.Add(this.pbOutgoing);
            this.pnHumanChar.Controls.Add(this.pbActive);
            this.pnHumanChar.Controls.Add(this.pbPlayful);
            this.pnHumanChar.Controls.Add(this.pbGNice);
            this.pnHumanChar.Controls.Add(this.pbNice);
            this.pnHumanChar.Controls.Add(this.pbGPlayful);
            this.pnHumanChar.Controls.Add(this.pbGNeat);
            this.pnHumanChar.Controls.Add(this.pbGActive);
            this.pnHumanChar.Controls.Add(this.pbGOutgoing);
            this.pnHumanChar.Font = null;
            this.pnHumanChar.Name = "pnHumanChar";
            // 
            // pbNeat
            // 
            this.pbNeat.AccessibleDescription = null;
            this.pbNeat.AccessibleName = null;
            resources.ApplyResources(this.pbNeat, "pbNeat");
            this.pbNeat.BackColor = System.Drawing.Color.Transparent;
            this.pbNeat.BackgroundImage = null;
            this.pbNeat.DisplayOffset = 0;
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
            // pbOutgoing
            // 
            this.pbOutgoing.AccessibleDescription = null;
            this.pbOutgoing.AccessibleName = null;
            resources.ApplyResources(this.pbOutgoing, "pbOutgoing");
            this.pbOutgoing.BackColor = System.Drawing.Color.Transparent;
            this.pbOutgoing.BackgroundImage = null;
            this.pbOutgoing.DisplayOffset = 0;
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
            // pbActive
            // 
            this.pbActive.AccessibleDescription = null;
            this.pbActive.AccessibleName = null;
            resources.ApplyResources(this.pbActive, "pbActive");
            this.pbActive.BackColor = System.Drawing.Color.Transparent;
            this.pbActive.BackgroundImage = null;
            this.pbActive.DisplayOffset = 0;
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
            // pbPlayful
            // 
            this.pbPlayful.AccessibleDescription = null;
            this.pbPlayful.AccessibleName = null;
            resources.ApplyResources(this.pbPlayful, "pbPlayful");
            this.pbPlayful.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayful.BackgroundImage = null;
            this.pbPlayful.DisplayOffset = 0;
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
            // pbGNice
            // 
            this.pbGNice.AccessibleDescription = null;
            this.pbGNice.AccessibleName = null;
            resources.ApplyResources(this.pbGNice, "pbGNice");
            this.pbGNice.BackColor = System.Drawing.Color.Transparent;
            this.pbGNice.BackgroundImage = null;
            this.pbGNice.DisplayOffset = 0;
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
            // pbNice
            // 
            this.pbNice.AccessibleDescription = null;
            this.pbNice.AccessibleName = null;
            resources.ApplyResources(this.pbNice, "pbNice");
            this.pbNice.BackColor = System.Drawing.Color.Transparent;
            this.pbNice.BackgroundImage = null;
            this.pbNice.DisplayOffset = 0;
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
            // pbGPlayful
            // 
            this.pbGPlayful.AccessibleDescription = null;
            this.pbGPlayful.AccessibleName = null;
            resources.ApplyResources(this.pbGPlayful, "pbGPlayful");
            this.pbGPlayful.BackColor = System.Drawing.Color.Transparent;
            this.pbGPlayful.BackgroundImage = null;
            this.pbGPlayful.DisplayOffset = 0;
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
            // pbGNeat
            // 
            this.pbGNeat.AccessibleDescription = null;
            this.pbGNeat.AccessibleName = null;
            resources.ApplyResources(this.pbGNeat, "pbGNeat");
            this.pbGNeat.BackColor = System.Drawing.Color.Transparent;
            this.pbGNeat.BackgroundImage = null;
            this.pbGNeat.DisplayOffset = 0;
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
            // pbGActive
            // 
            this.pbGActive.AccessibleDescription = null;
            this.pbGActive.AccessibleName = null;
            resources.ApplyResources(this.pbGActive, "pbGActive");
            this.pbGActive.BackColor = System.Drawing.Color.Transparent;
            this.pbGActive.BackgroundImage = null;
            this.pbGActive.DisplayOffset = 0;
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
            this.pbGOutgoing.AccessibleDescription = null;
            this.pbGOutgoing.AccessibleName = null;
            resources.ApplyResources(this.pbGOutgoing, "pbGOutgoing");
            this.pbGOutgoing.BackColor = System.Drawing.Color.Transparent;
            this.pbGOutgoing.BackgroundImage = null;
            this.pbGOutgoing.DisplayOffset = 0;
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
            // pbMan
            // 
            this.pbMan.AccessibleDescription = null;
            this.pbMan.AccessibleName = null;
            resources.ApplyResources(this.pbMan, "pbMan");
            this.pbMan.BackColor = System.Drawing.Color.Transparent;
            this.pbMan.BackgroundImage = null;
            this.pbMan.DisplayOffset = 0;
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
            this.pbWoman.AccessibleDescription = null;
            this.pbWoman.AccessibleName = null;
            resources.ApplyResources(this.pbWoman, "pbWoman");
            this.pbWoman.BackColor = System.Drawing.Color.Transparent;
            this.pbWoman.BackgroundImage = null;
            this.pbWoman.DisplayOffset = 0;
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
            // cbzodiac
            // 
            this.cbzodiac.AccessibleDescription = null;
            this.cbzodiac.AccessibleName = null;
            resources.ApplyResources(this.cbzodiac, "cbzodiac");
            this.cbzodiac.BackgroundImage = null;
            this.cbzodiac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbzodiac.Name = "cbzodiac";
            this.cbzodiac.SelectedIndexChanged += new System.EventHandler(this.ChangedChar);
            // 
            // label47
            // 
            this.label47.AccessibleDescription = null;
            this.label47.AccessibleName = null;
            resources.ApplyResources(this.label47, "label47");
            this.label47.Name = "label47";
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = null;
            this.panel2.AccessibleName = null;
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.BackgroundImage = null;
            this.panel2.Font = null;
            this.panel2.Name = "panel2";
            // 
            // label69
            // 
            this.label69.AccessibleDescription = null;
            this.label69.AccessibleName = null;
            resources.ApplyResources(this.label69, "label69");
            this.label69.Font = null;
            this.label69.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label69.Name = "label69";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = null;
            this.panel1.AccessibleName = null;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.BackgroundImage = null;
            this.panel1.Font = null;
            this.panel1.Name = "panel1";
            // 
            // label70
            // 
            this.label70.AccessibleDescription = null;
            this.label70.AccessibleName = null;
            resources.ApplyResources(this.label70, "label70");
            this.label70.Font = null;
            this.label70.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label70.Name = "label70";
            // 
            // mbiLink
            // 
            this.mbiLink.AccessibleDescription = null;
            this.mbiLink.AccessibleName = null;
            resources.ApplyResources(this.mbiLink, "mbiLink");
            this.mbiLink.BackgroundImage = null;
            this.mbiLink.Font = null;
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
            // 
            // miRand
            // 
            this.miRand.AccessibleDescription = null;
            this.miRand.AccessibleName = null;
            resources.ApplyResources(this.miRand, "miRand");
            this.miRand.BackgroundImage = null;
            this.miRand.Name = "miRand";
            this.miRand.ShortcutKeyDisplayString = null;
            this.miRand.Click += new System.EventHandler(this.Activate_biRand);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AccessibleDescription = null;
            this.toolStripMenuItem1.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // miOpenChar
            // 
            this.miOpenChar.AccessibleDescription = null;
            this.miOpenChar.AccessibleName = null;
            resources.ApplyResources(this.miOpenChar, "miOpenChar");
            this.miOpenChar.BackgroundImage = null;
            this.miOpenChar.Name = "miOpenChar";
            this.miOpenChar.ShortcutKeyDisplayString = null;
            this.miOpenChar.Click += new System.EventHandler(this.Activate_miOpenCHar);
            // 
            // miOpenWf
            // 
            this.miOpenWf.AccessibleDescription = null;
            this.miOpenWf.AccessibleName = null;
            resources.ApplyResources(this.miOpenWf, "miOpenWf");
            this.miOpenWf.BackgroundImage = null;
            this.miOpenWf.Name = "miOpenWf";
            this.miOpenWf.ShortcutKeyDisplayString = null;
            this.miOpenWf.Click += new System.EventHandler(this.Activate_miOpenWf);
            // 
            // miOpenMem
            // 
            this.miOpenMem.AccessibleDescription = null;
            this.miOpenMem.AccessibleName = null;
            resources.ApplyResources(this.miOpenMem, "miOpenMem");
            this.miOpenMem.BackgroundImage = null;
            this.miOpenMem.Name = "miOpenMem";
            this.miOpenMem.ShortcutKeyDisplayString = null;
            this.miOpenMem.Click += new System.EventHandler(this.Activate_miOpenMem);
            // 
            // miOpenBadge
            // 
            this.miOpenBadge.AccessibleDescription = null;
            this.miOpenBadge.AccessibleName = null;
            resources.ApplyResources(this.miOpenBadge, "miOpenBadge");
            this.miOpenBadge.BackgroundImage = null;
            this.miOpenBadge.Name = "miOpenBadge";
            this.miOpenBadge.ShortcutKeyDisplayString = null;
            this.miOpenBadge.Click += new System.EventHandler(this.Activate_miOpenBadge);
            // 
            // miOpenDNA
            // 
            this.miOpenDNA.AccessibleDescription = null;
            this.miOpenDNA.AccessibleName = null;
            resources.ApplyResources(this.miOpenDNA, "miOpenDNA");
            this.miOpenDNA.BackgroundImage = null;
            this.miOpenDNA.Name = "miOpenDNA";
            this.miOpenDNA.ShortcutKeyDisplayString = null;
            this.miOpenDNA.Click += new System.EventHandler(this.Activate_miOpenDNA);
            // 
            // miOpenFamily
            // 
            this.miOpenFamily.AccessibleDescription = null;
            this.miOpenFamily.AccessibleName = null;
            resources.ApplyResources(this.miOpenFamily, "miOpenFamily");
            this.miOpenFamily.BackgroundImage = null;
            this.miOpenFamily.Name = "miOpenFamily";
            this.miOpenFamily.ShortcutKeyDisplayString = null;
            this.miOpenFamily.Click += new System.EventHandler(this.Activate_miFamily);
            // 
            // miOpenCloth
            // 
            this.miOpenCloth.AccessibleDescription = null;
            this.miOpenCloth.AccessibleName = null;
            resources.ApplyResources(this.miOpenCloth, "miOpenCloth");
            this.miOpenCloth.BackgroundImage = null;
            this.miOpenCloth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.miOpenCloth.Name = "miOpenCloth";
            this.miOpenCloth.ShortcutKeyDisplayString = null;
            this.miOpenCloth.Click += new System.EventHandler(this.Activate_miOpenCloth);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AccessibleDescription = null;
            this.toolStripMenuItem2.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // miMore
            // 
            this.miMore.AccessibleDescription = null;
            this.miMore.AccessibleName = null;
            resources.ApplyResources(this.miMore, "miMore");
            this.miMore.BackgroundImage = null;
            this.miMore.Name = "miMore";
            this.miMore.ShortcutKeyDisplayString = null;
            this.miMore.Click += new System.EventHandler(this.Activate_miMore);
            // 
            // miRelink
            // 
            this.miRelink.AccessibleDescription = null;
            this.miRelink.AccessibleName = null;
            resources.ApplyResources(this.miRelink, "miRelink");
            this.miRelink.BackgroundImage = null;
            this.miRelink.Name = "miRelink";
            this.miRelink.ShortcutKeyDisplayString = null;
            this.miRelink.Click += new System.EventHandler(this.Activate_miRelink);
            // 
            // miRel
            // 
            this.miRel.AccessibleDescription = null;
            this.miRel.AccessibleName = null;
            resources.ApplyResources(this.miRel, "miRel");
            this.miRel.BackgroundImage = null;
            this.miRel.Font = null;
            this.miRel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAddRelation,
            this.miRemRelation,
            this.toolStripMenuItem3,
            this.mbiMaxThisRel,
            this.mbiMaxKnownRel});
            this.miRel.Name = "miRel";
            this.miRel.VisibleChanged += new System.EventHandler(this.miRel_BeforePopup);
            // 
            // miAddRelation
            // 
            this.miAddRelation.AccessibleDescription = null;
            this.miAddRelation.AccessibleName = null;
            resources.ApplyResources(this.miAddRelation, "miAddRelation");
            this.miAddRelation.BackgroundImage = null;
            this.miAddRelation.Name = "miAddRelation";
            this.miAddRelation.ShortcutKeyDisplayString = null;
            this.miAddRelation.Click += new System.EventHandler(this.Activate_miAddRelation);
            // 
            // miRemRelation
            // 
            this.miRemRelation.AccessibleDescription = null;
            this.miRemRelation.AccessibleName = null;
            resources.ApplyResources(this.miRemRelation, "miRemRelation");
            this.miRemRelation.BackgroundImage = null;
            this.miRemRelation.Name = "miRemRelation";
            this.miRemRelation.ShortcutKeyDisplayString = null;
            this.miRemRelation.Click += new System.EventHandler(this.Activate_miRemRelation);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.AccessibleDescription = null;
            this.toolStripMenuItem3.AccessibleName = null;
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            // 
            // mbiMaxThisRel
            // 
            this.mbiMaxThisRel.AccessibleDescription = null;
            this.mbiMaxThisRel.AccessibleName = null;
            resources.ApplyResources(this.mbiMaxThisRel, "mbiMaxThisRel");
            this.mbiMaxThisRel.BackgroundImage = null;
            this.mbiMaxThisRel.Name = "mbiMaxThisRel";
            this.mbiMaxThisRel.ShortcutKeyDisplayString = null;
            this.mbiMaxThisRel.Click += new System.EventHandler(this.Activate_mbiMaxThisRel);
            // 
            // mbiMaxKnownRel
            // 
            this.mbiMaxKnownRel.AccessibleDescription = null;
            this.mbiMaxKnownRel.AccessibleName = null;
            resources.ApplyResources(this.mbiMaxKnownRel, "mbiMaxKnownRel");
            this.mbiMaxKnownRel.BackgroundImage = null;
            this.mbiMaxKnownRel.Name = "mbiMaxKnownRel";
            this.mbiMaxKnownRel.ShortcutKeyDisplayString = null;
            this.mbiMaxKnownRel.Click += new System.EventHandler(this.Activate_mbiMaxKnownRel);
            // 
            // pnCareer
            // 
            this.pnCareer.AccessibleDescription = null;
            this.pnCareer.AccessibleName = null;
            resources.ApplyResources(this.pnCareer, "pnCareer");
            this.pnCareer.BackColor = System.Drawing.Color.Transparent;
            this.pnCareer.BackgroundImage = null;
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
            this.pnCareer.Font = null;
            this.pnCareer.Name = "pnCareer";
            // 
            // pbAspBliz
            // 
            this.pbAspBliz.AccessibleDescription = null;
            this.pbAspBliz.AccessibleName = null;
            resources.ApplyResources(this.pbAspBliz, "pbAspBliz");
            this.pbAspBliz.BackColor = System.Drawing.Color.Transparent;
            this.pbAspBliz.BackgroundImage = null;
            this.pbAspBliz.DisplayOffset = 0;
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
            this.label60.AccessibleDescription = null;
            this.label60.AccessibleName = null;
            resources.ApplyResources(this.label60, "label60");
            this.label60.Name = "label60";
            // 
            // cbaspiration
            // 
            this.cbaspiration.AccessibleDescription = null;
            this.cbaspiration.AccessibleName = null;
            resources.ApplyResources(this.cbaspiration, "cbaspiration");
            this.cbaspiration.BackgroundImage = null;
            this.cbaspiration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbaspiration.Name = "cbaspiration";
            this.cbaspiration.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pbAspCur
            // 
            this.pbAspCur.AccessibleDescription = null;
            this.pbAspCur.AccessibleName = null;
            resources.ApplyResources(this.pbAspCur, "pbAspCur");
            this.pbAspCur.BackColor = System.Drawing.Color.Transparent;
            this.pbAspCur.BackgroundImage = null;
            this.pbAspCur.DisplayOffset = 0;
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
            this.label46.AccessibleDescription = null;
            this.label46.AccessibleName = null;
            resources.ApplyResources(this.label46, "label46");
            this.label46.Name = "label46";
            // 
            // tblifelinescore
            // 
            this.tblifelinescore.AccessibleDescription = null;
            this.tblifelinescore.AccessibleName = null;
            resources.ApplyResources(this.tblifelinescore, "tblifelinescore");
            this.tblifelinescore.BackgroundImage = null;
            this.tblifelinescore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tblifelinescore.Font = null;
            this.tblifelinescore.Name = "tblifelinescore";
            this.tblifelinescore.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pbCareerPerformance
            // 
            this.pbCareerPerformance.AccessibleDescription = null;
            this.pbCareerPerformance.AccessibleName = null;
            resources.ApplyResources(this.pbCareerPerformance, "pbCareerPerformance");
            this.pbCareerPerformance.BackColor = System.Drawing.Color.Transparent;
            this.pbCareerPerformance.BackgroundImage = null;
            this.pbCareerPerformance.DisplayOffset = 0;
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
            this.pbCareerLevel.AccessibleDescription = null;
            this.pbCareerLevel.AccessibleName = null;
            resources.ApplyResources(this.pbCareerLevel, "pbCareerLevel");
            this.pbCareerLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbCareerLevel.BackgroundImage = null;
            this.pbCareerLevel.DisplayOffset = 0;
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
            this.label78.AccessibleDescription = null;
            this.label78.AccessibleName = null;
            resources.ApplyResources(this.label78, "label78");
            this.label78.Name = "label78";
            // 
            // tbschooltype
            // 
            this.tbschooltype.AccessibleDescription = null;
            this.tbschooltype.AccessibleName = null;
            resources.ApplyResources(this.tbschooltype, "tbschooltype");
            this.tbschooltype.BackgroundImage = null;
            this.tbschooltype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbschooltype.Name = "tbschooltype";
            this.tbschooltype.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // label77
            // 
            this.label77.AccessibleDescription = null;
            this.label77.AccessibleName = null;
            resources.ApplyResources(this.label77, "label77");
            this.label77.Name = "label77";
            // 
            // cbgrade
            // 
            this.cbgrade.AccessibleDescription = null;
            this.cbgrade.AccessibleName = null;
            resources.ApplyResources(this.cbgrade, "cbgrade");
            this.cbgrade.BackgroundImage = null;
            this.cbgrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbgrade.Name = "cbgrade";
            this.cbgrade.SelectedValueChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // cbschooltype
            // 
            this.cbschooltype.AccessibleDescription = null;
            this.cbschooltype.AccessibleName = null;
            resources.ApplyResources(this.cbschooltype, "cbschooltype");
            this.cbschooltype.BackgroundImage = null;
            this.cbschooltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbschooltype.Name = "cbschooltype";
            this.cbschooltype.SelectedIndexChanged += new System.EventHandler(this.cbschooltype_SelectedIndexChanged);
            // 
            // label50
            // 
            this.label50.AccessibleDescription = null;
            this.label50.AccessibleName = null;
            resources.ApplyResources(this.label50, "label50");
            this.label50.Name = "label50";
            // 
            // cbcareer
            // 
            this.cbcareer.AccessibleDescription = null;
            this.cbcareer.AccessibleName = null;
            resources.ApplyResources(this.cbcareer, "cbcareer");
            this.cbcareer.BackgroundImage = null;
            this.cbcareer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcareer.Name = "cbcareer";
            this.cbcareer.SelectedIndexChanged += new System.EventHandler(this.cbcareer_SelectedIndexChanged);
            // 
            // tbcareervalue
            // 
            this.tbcareervalue.AccessibleDescription = null;
            this.tbcareervalue.AccessibleName = null;
            resources.ApplyResources(this.tbcareervalue, "tbcareervalue");
            this.tbcareervalue.BackgroundImage = null;
            this.tbcareervalue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbcareervalue.Name = "tbcareervalue";
            this.tbcareervalue.TextChanged += new System.EventHandler(this.ChangedCareer);
            // 
            // pnInt
            // 
            this.pnInt.AccessibleDescription = null;
            this.pnInt.AccessibleName = null;
            resources.ApplyResources(this.pnInt, "pnInt");
            this.pnInt.BackColor = System.Drawing.Color.Transparent;
            this.pnInt.BackgroundImage = null;
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
            this.pnInt.Font = null;
            this.pnInt.Name = "pnInt";
            // 
            // pbSciFi
            // 
            this.pbSciFi.AccessibleDescription = null;
            this.pbSciFi.AccessibleName = null;
            resources.ApplyResources(this.pbSciFi, "pbSciFi");
            this.pbSciFi.BackColor = System.Drawing.Color.Transparent;
            this.pbSciFi.BackgroundImage = null;
            this.pbSciFi.DisplayOffset = 0;
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
            this.pbToys.AccessibleDescription = null;
            this.pbToys.AccessibleName = null;
            resources.ApplyResources(this.pbToys, "pbToys");
            this.pbToys.BackColor = System.Drawing.Color.Transparent;
            this.pbToys.BackgroundImage = null;
            this.pbToys.DisplayOffset = 0;
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
            this.pbSchool.AccessibleDescription = null;
            this.pbSchool.AccessibleName = null;
            resources.ApplyResources(this.pbSchool, "pbSchool");
            this.pbSchool.BackColor = System.Drawing.Color.Transparent;
            this.pbSchool.BackgroundImage = null;
            this.pbSchool.DisplayOffset = 0;
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
            this.pbAnimals.AccessibleDescription = null;
            this.pbAnimals.AccessibleName = null;
            resources.ApplyResources(this.pbAnimals, "pbAnimals");
            this.pbAnimals.BackColor = System.Drawing.Color.Transparent;
            this.pbAnimals.BackgroundImage = null;
            this.pbAnimals.DisplayOffset = 0;
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
            this.pbWeather.AccessibleDescription = null;
            this.pbWeather.AccessibleName = null;
            resources.ApplyResources(this.pbWeather, "pbWeather");
            this.pbWeather.BackColor = System.Drawing.Color.Transparent;
            this.pbWeather.BackgroundImage = null;
            this.pbWeather.DisplayOffset = 0;
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
            this.pbWork.AccessibleDescription = null;
            this.pbWork.AccessibleName = null;
            resources.ApplyResources(this.pbWork, "pbWork");
            this.pbWork.BackColor = System.Drawing.Color.Transparent;
            this.pbWork.BackgroundImage = null;
            this.pbWork.DisplayOffset = 0;
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
            this.pbTravel.AccessibleDescription = null;
            this.pbTravel.AccessibleName = null;
            resources.ApplyResources(this.pbTravel, "pbTravel");
            this.pbTravel.BackColor = System.Drawing.Color.Transparent;
            this.pbTravel.BackgroundImage = null;
            this.pbTravel.DisplayOffset = 0;
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
            this.pbCrime.AccessibleDescription = null;
            this.pbCrime.AccessibleName = null;
            resources.ApplyResources(this.pbCrime, "pbCrime");
            this.pbCrime.BackColor = System.Drawing.Color.Transparent;
            this.pbCrime.BackgroundImage = null;
            this.pbCrime.DisplayOffset = 0;
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
            this.pbSports.AccessibleDescription = null;
            this.pbSports.AccessibleName = null;
            resources.ApplyResources(this.pbSports, "pbSports");
            this.pbSports.BackColor = System.Drawing.Color.Transparent;
            this.pbSports.BackgroundImage = null;
            this.pbSports.DisplayOffset = 0;
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
            this.pbFashion.AccessibleDescription = null;
            this.pbFashion.AccessibleName = null;
            resources.ApplyResources(this.pbFashion, "pbFashion");
            this.pbFashion.BackColor = System.Drawing.Color.Transparent;
            this.pbFashion.BackgroundImage = null;
            this.pbFashion.DisplayOffset = 0;
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
            this.pbHealth.AccessibleDescription = null;
            this.pbHealth.AccessibleName = null;
            resources.ApplyResources(this.pbHealth, "pbHealth");
            this.pbHealth.BackColor = System.Drawing.Color.Transparent;
            this.pbHealth.BackgroundImage = null;
            this.pbHealth.DisplayOffset = 0;
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
            this.pbFood.AccessibleDescription = null;
            this.pbFood.AccessibleName = null;
            resources.ApplyResources(this.pbFood, "pbFood");
            this.pbFood.BackColor = System.Drawing.Color.Transparent;
            this.pbFood.BackgroundImage = null;
            this.pbFood.DisplayOffset = 0;
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
            this.pbPolitics.AccessibleDescription = null;
            this.pbPolitics.AccessibleName = null;
            resources.ApplyResources(this.pbPolitics, "pbPolitics");
            this.pbPolitics.BackColor = System.Drawing.Color.Transparent;
            this.pbPolitics.BackgroundImage = null;
            this.pbPolitics.DisplayOffset = 0;
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
            this.pbMoney.AccessibleDescription = null;
            this.pbMoney.AccessibleName = null;
            resources.ApplyResources(this.pbMoney, "pbMoney");
            this.pbMoney.BackColor = System.Drawing.Color.Transparent;
            this.pbMoney.BackgroundImage = null;
            this.pbMoney.DisplayOffset = 0;
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
            this.pbCulture.AccessibleDescription = null;
            this.pbCulture.AccessibleName = null;
            resources.ApplyResources(this.pbCulture, "pbCulture");
            this.pbCulture.BackColor = System.Drawing.Color.Transparent;
            this.pbCulture.BackgroundImage = null;
            this.pbCulture.DisplayOffset = 0;
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
            this.pbEntertainment.AccessibleDescription = null;
            this.pbEntertainment.AccessibleName = null;
            resources.ApplyResources(this.pbEntertainment, "pbEntertainment");
            this.pbEntertainment.BackColor = System.Drawing.Color.Transparent;
            this.pbEntertainment.BackgroundImage = null;
            this.pbEntertainment.DisplayOffset = 0;
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
            this.pbParanormal.AccessibleDescription = null;
            this.pbParanormal.AccessibleName = null;
            resources.ApplyResources(this.pbParanormal, "pbParanormal");
            this.pbParanormal.BackColor = System.Drawing.Color.Transparent;
            this.pbParanormal.BackgroundImage = null;
            this.pbParanormal.DisplayOffset = 0;
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
            this.pbEnvironment.AccessibleDescription = null;
            this.pbEnvironment.AccessibleName = null;
            resources.ApplyResources(this.pbEnvironment, "pbEnvironment");
            this.pbEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.pbEnvironment.BackgroundImage = null;
            this.pbEnvironment.DisplayOffset = 0;
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
            this.pnRel.AccessibleDescription = null;
            this.pnRel.AccessibleName = null;
            resources.ApplyResources(this.pnRel, "pnRel");
            this.pnRel.BackColor = System.Drawing.Color.Transparent;
            this.pnRel.BackgroundImage = null;
            this.pnRel.Controls.Add(this.lv);
            this.pnRel.Controls.Add(this.panel3);
            this.pnRel.Name = "pnRel";
            this.pnRel.VisibleChanged += new System.EventHandler(this.pnRel_VisibleChanged);
            // 
            // lv
            // 
            this.lv.AccessibleDescription = null;
            this.lv.AccessibleName = null;
            resources.ApplyResources(this.lv, "lv");
            this.lv.BackgroundImage = null;
            this.lv.ContextMenuStrip = this.miRel;
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
            // panel3
            // 
            this.panel3.AccessibleDescription = null;
            this.panel3.AccessibleName = null;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackgroundImage = null;
            this.panel3.Controls.Add(this.srcTb);
            this.panel3.Controls.Add(this.dstTb);
            this.panel3.Font = null;
            this.panel3.Name = "panel3";
            // 
            // srcTb
            // 
            this.srcTb.AccessibleDescription = null;
            this.srcTb.AccessibleName = null;
            resources.ApplyResources(this.srcTb, "srcTb");
            this.srcTb.BackColor = System.Drawing.Color.Transparent;
            this.srcTb.BackgroundImage = null;
            this.srcTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.srcTb.BorderColor = System.Drawing.SystemColors.Window;
            this.srcTb.Font = null;
            this.srcTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.srcTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.srcTb.Icon = null;
            this.srcTb.IconLocation = new System.Drawing.Point(4, 6);
            this.srcTb.IconSize = new System.Drawing.Size(48, 32);
            this.srcTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.srcTb.Name = "srcTb";
            this.srcTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // dstTb
            // 
            this.dstTb.AccessibleDescription = null;
            this.dstTb.AccessibleName = null;
            resources.ApplyResources(this.dstTb, "dstTb");
            this.dstTb.BackColor = System.Drawing.Color.Transparent;
            this.dstTb.BackgroundImage = null;
            this.dstTb.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dstTb.BorderColor = System.Drawing.SystemColors.Window;
            this.dstTb.Font = null;
            this.dstTb.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.dstTb.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dstTb.Icon = null;
            this.dstTb.IconLocation = new System.Drawing.Point(4, 6);
            this.dstTb.IconSize = new System.Drawing.Size(48, 32);
            this.dstTb.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.dstTb.Name = "dstTb";
            this.dstTb.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // pnMisc
            // 
            this.pnMisc.AccessibleDescription = null;
            this.pnMisc.AccessibleName = null;
            resources.ApplyResources(this.pnMisc, "pnMisc");
            this.pnMisc.BackColor = System.Drawing.Color.Transparent;
            this.pnMisc.BackgroundImage = null;
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple3);
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple2);
            this.pnMisc.Controls.Add(this.xpTaskBoxSimple1);
            this.pnMisc.Font = null;
            this.pnMisc.Name = "pnMisc";
            // 
            // xpTaskBoxSimple3
            // 
            this.xpTaskBoxSimple3.AccessibleDescription = null;
            this.xpTaskBoxSimple3.AccessibleName = null;
            resources.ApplyResources(this.xpTaskBoxSimple3, "xpTaskBoxSimple3");
            this.xpTaskBoxSimple3.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBoxSimple3.BackgroundImage = null;
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
            this.xpTaskBoxSimple3.Font = null;
            this.xpTaskBoxSimple3.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.xpTaskBoxSimple3.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple3.Icon = null;
            this.xpTaskBoxSimple3.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple3.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple3.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple3.Name = "xpTaskBoxSimple3";
            this.xpTaskBoxSimple3.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // label3
            // 
            this.label3.AccessibleDescription = null;
            this.label3.AccessibleName = null;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tbstatmot
            // 
            this.tbstatmot.AccessibleDescription = null;
            this.tbstatmot.AccessibleName = null;
            resources.ApplyResources(this.tbstatmot, "tbstatmot");
            this.tbstatmot.BackgroundImage = null;
            this.tbstatmot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbstatmot.Name = "tbstatmot";
            this.tbstatmot.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label96
            // 
            this.label96.AccessibleDescription = null;
            this.label96.AccessibleName = null;
            resources.ApplyResources(this.label96, "label96");
            this.label96.Name = "label96";
            // 
            // tbunlinked
            // 
            this.tbunlinked.AccessibleDescription = null;
            this.tbunlinked.AccessibleName = null;
            resources.ApplyResources(this.tbunlinked, "tbunlinked");
            this.tbunlinked.BackgroundImage = null;
            this.tbunlinked.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbunlinked.Name = "tbunlinked";
            this.tbunlinked.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label95
            // 
            this.label95.AccessibleDescription = null;
            this.label95.AccessibleName = null;
            resources.ApplyResources(this.label95, "label95");
            this.label95.Name = "label95";
            // 
            // tbagedur
            // 
            this.tbagedur.AccessibleDescription = null;
            this.tbagedur.AccessibleName = null;
            resources.ApplyResources(this.tbagedur, "tbagedur");
            this.tbagedur.BackgroundImage = null;
            this.tbagedur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbagedur.Name = "tbagedur";
            this.tbagedur.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // tbprevdays
            // 
            this.tbprevdays.AccessibleDescription = null;
            this.tbprevdays.AccessibleName = null;
            resources.ApplyResources(this.tbprevdays, "tbprevdays");
            this.tbprevdays.BackgroundImage = null;
            this.tbprevdays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbprevdays.Name = "tbprevdays";
            this.tbprevdays.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label94
            // 
            this.label94.AccessibleDescription = null;
            this.label94.AccessibleName = null;
            resources.ApplyResources(this.label94, "label94");
            this.label94.Name = "label94";
            // 
            // tbvoice
            // 
            this.tbvoice.AccessibleDescription = null;
            this.tbvoice.AccessibleName = null;
            resources.ApplyResources(this.tbvoice, "tbvoice");
            this.tbvoice.BackgroundImage = null;
            this.tbvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbvoice.Name = "tbvoice";
            this.tbvoice.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label90
            // 
            this.label90.AccessibleDescription = null;
            this.label90.AccessibleName = null;
            resources.ApplyResources(this.label90, "label90");
            this.label90.Name = "label90";
            // 
            // tbnpc
            // 
            this.tbnpc.AccessibleDescription = null;
            this.tbnpc.AccessibleName = null;
            resources.ApplyResources(this.tbnpc, "tbnpc");
            this.tbnpc.BackgroundImage = null;
            this.tbnpc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbnpc.Name = "tbnpc";
            this.tbnpc.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label87
            // 
            this.label87.AccessibleDescription = null;
            this.label87.AccessibleName = null;
            resources.ApplyResources(this.label87, "label87");
            this.label87.Name = "label87";
            // 
            // tbautonomy
            // 
            this.tbautonomy.AccessibleDescription = null;
            this.tbautonomy.AccessibleName = null;
            resources.ApplyResources(this.tbautonomy, "tbautonomy");
            this.tbautonomy.BackgroundImage = null;
            this.tbautonomy.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbautonomy.Name = "tbautonomy";
            this.tbautonomy.TextChanged += new System.EventHandler(this.ChangedOther);
            // 
            // label86
            // 
            this.label86.AccessibleDescription = null;
            this.label86.AccessibleName = null;
            resources.ApplyResources(this.label86, "label86");
            this.label86.Name = "label86";
            // 
            // xpTaskBoxSimple2
            // 
            this.xpTaskBoxSimple2.AccessibleDescription = null;
            this.xpTaskBoxSimple2.AccessibleName = null;
            resources.ApplyResources(this.xpTaskBoxSimple2, "xpTaskBoxSimple2");
            this.xpTaskBoxSimple2.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBoxSimple2.BackgroundImage = null;
            this.xpTaskBoxSimple2.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.xpTaskBoxSimple2.BorderColor = System.Drawing.SystemColors.Window;
            this.xpTaskBoxSimple2.Controls.Add(this.cbfit);
            this.xpTaskBoxSimple2.Controls.Add(this.cbpreginv);
            this.xpTaskBoxSimple2.Controls.Add(this.cbpreghalf);
            this.xpTaskBoxSimple2.Controls.Add(this.cbpregfull);
            this.xpTaskBoxSimple2.Controls.Add(this.cbfat);
            this.xpTaskBoxSimple2.Font = null;
            this.xpTaskBoxSimple2.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.xpTaskBoxSimple2.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple2.Icon = null;
            this.xpTaskBoxSimple2.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple2.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple2.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple2.Name = "xpTaskBoxSimple2";
            this.xpTaskBoxSimple2.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbfit
            // 
            this.cbfit.AccessibleDescription = null;
            this.cbfit.AccessibleName = null;
            resources.ApplyResources(this.cbfit, "cbfit");
            this.cbfit.BackgroundImage = null;
            this.cbfit.Name = "cbfit";
            this.cbfit.UseVisualStyleBackColor = false;
            this.cbfit.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpreginv
            // 
            this.cbpreginv.AccessibleDescription = null;
            this.cbpreginv.AccessibleName = null;
            resources.ApplyResources(this.cbpreginv, "cbpreginv");
            this.cbpreginv.BackgroundImage = null;
            this.cbpreginv.Name = "cbpreginv";
            this.cbpreginv.UseVisualStyleBackColor = false;
            this.cbpreginv.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpreghalf
            // 
            this.cbpreghalf.AccessibleDescription = null;
            this.cbpreghalf.AccessibleName = null;
            resources.ApplyResources(this.cbpreghalf, "cbpreghalf");
            this.cbpreghalf.BackgroundImage = null;
            this.cbpreghalf.Name = "cbpreghalf";
            this.cbpreghalf.UseVisualStyleBackColor = false;
            this.cbpreghalf.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpregfull
            // 
            this.cbpregfull.AccessibleDescription = null;
            this.cbpregfull.AccessibleName = null;
            resources.ApplyResources(this.cbpregfull, "cbpregfull");
            this.cbpregfull.BackgroundImage = null;
            this.cbpregfull.Name = "cbpregfull";
            this.cbpregfull.UseVisualStyleBackColor = false;
            this.cbpregfull.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbfat
            // 
            this.cbfat.AccessibleDescription = null;
            this.cbfat.AccessibleName = null;
            resources.ApplyResources(this.cbfat, "cbfat");
            this.cbfat.BackgroundImage = null;
            this.cbfat.Name = "cbfat";
            this.cbfat.UseVisualStyleBackColor = false;
            this.cbfat.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // xpTaskBoxSimple1
            // 
            this.xpTaskBoxSimple1.AccessibleDescription = null;
            this.xpTaskBoxSimple1.AccessibleName = null;
            resources.ApplyResources(this.xpTaskBoxSimple1, "xpTaskBoxSimple1");
            this.xpTaskBoxSimple1.BackColor = System.Drawing.Color.Transparent;
            this.xpTaskBoxSimple1.BackgroundImage = null;
            this.xpTaskBoxSimple1.BodyColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.xpTaskBoxSimple1.BorderColor = System.Drawing.SystemColors.Window;
            this.xpTaskBoxSimple1.Controls.Add(this.cbisghost);
            this.xpTaskBoxSimple1.Controls.Add(this.cbignoretraversal);
            this.xpTaskBoxSimple1.Controls.Add(this.cbpasspeople);
            this.xpTaskBoxSimple1.Controls.Add(this.cbpasswalls);
            this.xpTaskBoxSimple1.Controls.Add(this.cbpassobject);
            this.xpTaskBoxSimple1.Font = null;
            this.xpTaskBoxSimple1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.xpTaskBoxSimple1.HeaderTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.xpTaskBoxSimple1.Icon = null;
            this.xpTaskBoxSimple1.IconLocation = new System.Drawing.Point(4, 12);
            this.xpTaskBoxSimple1.IconSize = new System.Drawing.Size(32, 32);
            this.xpTaskBoxSimple1.LeftHeaderColor = System.Drawing.SystemColors.InactiveCaption;
            this.xpTaskBoxSimple1.Name = "xpTaskBoxSimple1";
            this.xpTaskBoxSimple1.RightHeaderColor = System.Drawing.SystemColors.Highlight;
            // 
            // cbisghost
            // 
            this.cbisghost.AccessibleDescription = null;
            this.cbisghost.AccessibleName = null;
            resources.ApplyResources(this.cbisghost, "cbisghost");
            this.cbisghost.BackgroundImage = null;
            this.cbisghost.Name = "cbisghost";
            this.cbisghost.UseVisualStyleBackColor = false;
            this.cbisghost.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbignoretraversal
            // 
            this.cbignoretraversal.AccessibleDescription = null;
            this.cbignoretraversal.AccessibleName = null;
            resources.ApplyResources(this.cbignoretraversal, "cbignoretraversal");
            this.cbignoretraversal.BackgroundImage = null;
            this.cbignoretraversal.Name = "cbignoretraversal";
            this.cbignoretraversal.UseVisualStyleBackColor = false;
            this.cbignoretraversal.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpasspeople
            // 
            this.cbpasspeople.AccessibleDescription = null;
            this.cbpasspeople.AccessibleName = null;
            resources.ApplyResources(this.cbpasspeople, "cbpasspeople");
            this.cbpasspeople.BackgroundImage = null;
            this.cbpasspeople.Name = "cbpasspeople";
            this.cbpasspeople.UseVisualStyleBackColor = false;
            this.cbpasspeople.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpasswalls
            // 
            this.cbpasswalls.AccessibleDescription = null;
            this.cbpasswalls.AccessibleName = null;
            resources.ApplyResources(this.cbpasswalls, "cbpasswalls");
            this.cbpasswalls.BackgroundImage = null;
            this.cbpasswalls.Name = "cbpasswalls";
            this.cbpasswalls.UseVisualStyleBackColor = false;
            this.cbpasswalls.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // cbpassobject
            // 
            this.cbpassobject.AccessibleDescription = null;
            this.cbpassobject.AccessibleName = null;
            resources.ApplyResources(this.cbpassobject, "cbpassobject");
            this.cbpassobject.BackgroundImage = null;
            this.cbpassobject.Name = "cbpassobject";
            this.cbpassobject.UseVisualStyleBackColor = false;
            this.cbpassobject.CheckedChanged += new System.EventHandler(this.ChangedOther);
            // 
            // pnEP1
            // 
            this.pnEP1.AccessibleDescription = null;
            this.pnEP1.AccessibleName = null;
            resources.ApplyResources(this.pnEP1, "pnEP1");
            this.pnEP1.BackColor = System.Drawing.Color.Transparent;
            this.pnEP1.BackgroundImage = null;
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
            this.pnEP1.Font = null;
            this.pnEP1.Name = "pnEP1";
            // 
            // pbLastGrade
            // 
            this.pbLastGrade.AccessibleDescription = null;
            this.pbLastGrade.AccessibleName = null;
            resources.ApplyResources(this.pbLastGrade, "pbLastGrade");
            this.pbLastGrade.BackColor = System.Drawing.Color.Transparent;
            this.pbLastGrade.BackgroundImage = null;
            this.pbLastGrade.DisplayOffset = 0;
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
            this.pbUniTime.AccessibleDescription = null;
            this.pbUniTime.AccessibleName = null;
            resources.ApplyResources(this.pbUniTime, "pbUniTime");
            this.pbUniTime.BackColor = System.Drawing.Color.Transparent;
            this.pbUniTime.BackgroundImage = null;
            this.pbUniTime.DisplayOffset = 0;
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
            this.pbEffort.AccessibleDescription = null;
            this.pbEffort.AccessibleName = null;
            resources.ApplyResources(this.pbEffort, "pbEffort");
            this.pbEffort.BackColor = System.Drawing.Color.Transparent;
            this.pbEffort.BackgroundImage = null;
            this.pbEffort.DisplayOffset = 0;
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
            this.tbinfluence.AccessibleDescription = null;
            this.tbinfluence.AccessibleName = null;
            resources.ApplyResources(this.tbinfluence, "tbinfluence");
            this.tbinfluence.BackgroundImage = null;
            this.tbinfluence.Name = "tbinfluence";
            this.tbinfluence.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // tbsemester
            // 
            this.tbsemester.AccessibleDescription = null;
            this.tbsemester.AccessibleName = null;
            resources.ApplyResources(this.tbsemester, "tbsemester");
            this.tbsemester.BackgroundImage = null;
            this.tbsemester.Name = "tbsemester";
            this.tbsemester.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // label103
            // 
            this.label103.AccessibleDescription = null;
            this.label103.AccessibleName = null;
            resources.ApplyResources(this.label103, "label103");
            this.label103.Name = "label103";
            // 
            // label101
            // 
            this.label101.AccessibleDescription = null;
            this.label101.AccessibleName = null;
            resources.ApplyResources(this.label101, "label101");
            this.label101.Name = "label101";
            // 
            // cboncampus
            // 
            this.cboncampus.AccessibleDescription = null;
            this.cboncampus.AccessibleName = null;
            resources.ApplyResources(this.cboncampus, "cboncampus");
            this.cboncampus.BackgroundImage = null;
            this.cboncampus.Name = "cboncampus";
            this.cboncampus.UseVisualStyleBackColor = false;
            this.cboncampus.CheckedChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // cbmajor
            // 
            this.cbmajor.AccessibleDescription = null;
            this.cbmajor.AccessibleName = null;
            resources.ApplyResources(this.cbmajor, "cbmajor");
            this.cbmajor.BackgroundImage = null;
            this.cbmajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbmajor.Name = "cbmajor";
            this.cbmajor.SelectedIndexChanged += new System.EventHandler(this.cbmajor_SelectedIndexChanged);
            // 
            // label98
            // 
            this.label98.AccessibleDescription = null;
            this.label98.AccessibleName = null;
            resources.ApplyResources(this.label98, "label98");
            this.label98.Name = "label98";
            // 
            // tbmajor
            // 
            this.tbmajor.AccessibleDescription = null;
            this.tbmajor.AccessibleName = null;
            resources.ApplyResources(this.tbmajor, "tbmajor");
            this.tbmajor.BackgroundImage = null;
            this.tbmajor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbmajor.Name = "tbmajor";
            this.tbmajor.TextChanged += new System.EventHandler(this.ChangedEP1);
            // 
            // pnEP2
            // 
            this.pnEP2.AccessibleDescription = null;
            this.pnEP2.AccessibleName = null;
            resources.ApplyResources(this.pnEP2, "pnEP2");
            this.pnEP2.BackColor = System.Drawing.Color.Transparent;
            this.pnEP2.BackgroundImage = null;
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
            this.tbNTLove.AccessibleDescription = null;
            this.tbNTLove.AccessibleName = null;
            resources.ApplyResources(this.tbNTLove, "tbNTLove");
            this.tbNTLove.BackgroundImage = null;
            this.tbNTLove.Font = null;
            this.tbNTLove.Name = "tbNTLove";
            this.tbNTLove.TextChanged += new System.EventHandler(this.ChangedEP2);
            // 
            // tbNTPerfume
            // 
            this.tbNTPerfume.AccessibleDescription = null;
            this.tbNTPerfume.AccessibleName = null;
            resources.ApplyResources(this.tbNTPerfume, "tbNTPerfume");
            this.tbNTPerfume.BackgroundImage = null;
            this.tbNTPerfume.Font = null;
            this.tbNTPerfume.Name = "tbNTPerfume";
            this.tbNTPerfume.TextChanged += new System.EventHandler(this.ChangedEP2);
            // 
            // label8
            // 
            this.label8.AccessibleDescription = null;
            this.label8.AccessibleName = null;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // label7
            // 
            this.label7.AccessibleDescription = null;
            this.label7.AccessibleName = null;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lbTurnOff
            // 
            this.lbTurnOff.AccessibleDescription = null;
            this.lbTurnOff.AccessibleName = null;
            resources.ApplyResources(this.lbTurnOff, "lbTurnOff");
            this.lbTurnOff.BackgroundImage = null;
            this.lbTurnOff.Name = "lbTurnOff";
            this.lbTurnOff.SelectedIndexChanged += new System.EventHandler(this.lbTurnOff_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AccessibleDescription = null;
            this.label6.AccessibleName = null;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lbTurnOn
            // 
            this.lbTurnOn.AccessibleDescription = null;
            this.lbTurnOn.AccessibleName = null;
            resources.ApplyResources(this.lbTurnOn, "lbTurnOn");
            this.lbTurnOn.BackgroundImage = null;
            this.lbTurnOn.Name = "lbTurnOn";
            this.lbTurnOn.SelectedIndexChanged += new System.EventHandler(this.lbTurnOn_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AccessibleDescription = null;
            this.label5.AccessibleName = null;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lbTraits
            // 
            this.lbTraits.AccessibleDescription = null;
            this.lbTraits.AccessibleName = null;
            resources.ApplyResources(this.lbTraits, "lbTraits");
            this.lbTraits.BackgroundImage = null;
            this.lbTraits.Name = "lbTraits";
            this.lbTraits.SelectedIndexChanged += new System.EventHandler(this.lbTraits_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AccessibleDescription = null;
            this.label4.AccessibleName = null;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pnEP3
            // 
            this.pnEP3.AccessibleDescription = null;
            this.pnEP3.AccessibleName = null;
            resources.ApplyResources(this.pnEP3, "pnEP3");
            this.pnEP3.BackColor = System.Drawing.Color.Transparent;
            this.pnEP3.BackgroundImage = null;
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
            this.pictureBox1.AccessibleDescription = null;
            this.pictureBox1.AccessibleName = null;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackgroundImage = null;
            this.pictureBox1.Font = null;
            this.pictureBox1.ImageLocation = null;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // llep3openinfo
            // 
            this.llep3openinfo.AccessibleDescription = null;
            this.llep3openinfo.AccessibleName = null;
            resources.ApplyResources(this.llep3openinfo, "llep3openinfo");
            this.llep3openinfo.Name = "llep3openinfo";
            this.llep3openinfo.TabStop = true;
            this.llep3openinfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llep3openinfo_LinkClicked);
            // 
            // label15
            // 
            this.label15.AccessibleDescription = null;
            this.label15.AccessibleName = null;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // sblb
            // 
            this.sblb.AccessibleDescription = null;
            this.sblb.AccessibleName = null;
            resources.ApplyResources(this.sblb, "sblb");
            this.sblb.BackgroundImage = null;
            this.sblb.Name = "sblb";
            this.sblb.SimDescription = null;
            this.sblb.SelectedBusinessChanged += new System.EventHandler(this.sblb_SelectedBusinessChanged);
            // 
            // tbEp3Salery
            // 
            this.tbEp3Salery.AccessibleDescription = null;
            this.tbEp3Salery.AccessibleName = null;
            resources.ApplyResources(this.tbEp3Salery, "tbEp3Salery");
            this.tbEp3Salery.BackgroundImage = null;
            this.tbEp3Salery.Font = null;
            this.tbEp3Salery.Name = "tbEp3Salery";
            this.tbEp3Salery.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // label14
            // 
            this.label14.AccessibleDescription = null;
            this.label14.AccessibleName = null;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // label12
            // 
            this.label12.AccessibleDescription = null;
            this.label12.AccessibleName = null;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // cbEp3Asgn
            // 
            this.cbEp3Asgn.AccessibleDescription = null;
            this.cbEp3Asgn.AccessibleName = null;
            resources.ApplyResources(this.cbEp3Asgn, "cbEp3Asgn");
            this.cbEp3Asgn.BackgroundImage = null;
            this.cbEp3Asgn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEp3Asgn.Enum = null;
            this.cbEp3Asgn.Font = null;
            this.cbEp3Asgn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbEp3Asgn.Name = "cbEp3Asgn";
            this.cbEp3Asgn.ResourceManager = null;
            this.cbEp3Asgn.SelectedValueChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // tbEp3Flag
            // 
            this.tbEp3Flag.AccessibleDescription = null;
            this.tbEp3Flag.AccessibleName = null;
            resources.ApplyResources(this.tbEp3Flag, "tbEp3Flag");
            this.tbEp3Flag.BackgroundImage = null;
            this.tbEp3Flag.Font = null;
            this.tbEp3Flag.Name = "tbEp3Flag";
            this.tbEp3Flag.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // tbEp3Lot
            // 
            this.tbEp3Lot.AccessibleDescription = null;
            this.tbEp3Lot.AccessibleName = null;
            resources.ApplyResources(this.tbEp3Lot, "tbEp3Lot");
            this.tbEp3Lot.BackgroundImage = null;
            this.tbEp3Lot.Font = null;
            this.tbEp3Lot.Name = "tbEp3Lot";
            this.tbEp3Lot.TextChanged += new System.EventHandler(this.ChangedEP3);
            // 
            // label9
            // 
            this.label9.AccessibleDescription = null;
            this.label9.AccessibleName = null;
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label11
            // 
            this.label11.AccessibleDescription = null;
            this.label11.AccessibleName = null;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // ExtSDesc
            // 
            this.AccessibleDescription = null;
            this.AccessibleName = null;
            resources.ApplyResources(this, "$this");
            this.BackgroundImage = null;
            this.Controls.Add(this.pnChar);
            this.Controls.Add(this.pnId);
            this.Controls.Add(this.pnMisc);
            this.Controls.Add(this.toolBar1);
            this.Controls.Add(this.pnRel);
            this.Controls.Add(this.pnCareer);
            this.Controls.Add(this.pnEP1);
            this.Controls.Add(this.pnEP3);
            this.Controls.Add(this.pnInt);
            this.Controls.Add(this.pnSkill);
            this.Controls.Add(this.pnEP2);
            this.HeaderText = null;
            this.Name = "ExtSDesc";
            this.Controls.SetChildIndex(this.pnEP2, 0);
            this.Controls.SetChildIndex(this.pnSkill, 0);
            this.Controls.SetChildIndex(this.pnInt, 0);
            this.Controls.SetChildIndex(this.pnEP3, 0);
            this.Controls.SetChildIndex(this.pnEP1, 0);
            this.Controls.SetChildIndex(this.pnCareer, 0);
            this.Controls.SetChildIndex(this.pnRel, 0);
            this.Controls.SetChildIndex(this.toolBar1, 0);
            this.Controls.SetChildIndex(this.pnMisc, 0);
            this.Controls.SetChildIndex(this.pnId, 0);
            this.Controls.SetChildIndex(this.pnChar, 0);
            this.toolBar1.ResumeLayout(false);
            this.toolBar1.PerformLayout();
            this.pnId.ResumeLayout(false);
            this.pnId.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.pnSkill.ResumeLayout(false);
            this.pnChar.ResumeLayout(false);
            this.pnPetChar.ResumeLayout(false);
            this.pnHumanChar.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnPetChar;
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
        internal EnumComboBox cbSpecies;
        private Label label21;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Panel pnHumanChar;
        private SimPe.PackedFiles.Wrapper.PetTraitSelect ptPigpen;
        private SimPe.PackedFiles.Wrapper.PetTraitSelect ptAggres;
        private SimPe.PackedFiles.Wrapper.PetTraitSelect ptIndep;
        private SimPe.PackedFiles.Wrapper.PetTraitSelect ptHyper;
        private SimPe.PackedFiles.Wrapper.PetTraitSelect ptGifted;
    }
}
