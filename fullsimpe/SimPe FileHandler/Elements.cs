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
using SimPe.PackedFiles.Wrapper.Supporting;

namespace SimPe.PackedFiles.UserInterface 
{
	/// <summary>
	/// Zusammenfassung für Elements.
	/// </summary>
	internal class Elements : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label banner;
		internal System.Windows.Forms.PictureBox pb;
		internal System.Windows.Forms.Panel JpegPanel;
		internal System.Windows.Forms.Panel xmlPanel;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		internal System.Windows.Forms.RichTextBox rtb;
		private System.ComponentModel.IContainer components;
		private Skybound.VisualStyles.VisualStyleLinkLabel visualStyleLinkLabel2;
		internal System.Windows.Forms.TextBox tbsimid;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label12;
		internal System.Windows.Forms.Panel objdPanel;
		internal System.Windows.Forms.TextBox tbsimname;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		internal System.Windows.Forms.Panel famiPanel;
		internal System.Windows.Forms.TextBox tblotinst;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button llFamiDeleteSim;
		private System.Windows.Forms.Button llFamiAddSim;
		private System.Windows.Forms.Button button1;
		internal System.Windows.Forms.ComboBox cbsims;
		internal System.Windows.Forms.ListBox lbmembers;
		internal System.Windows.Forms.TextBox tbname;
		private System.Windows.Forms.Label label6;
		internal System.Windows.Forms.TextBox tbfamily;
		internal System.Windows.Forms.TextBox tbmoney;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label label2;
		internal System.Windows.Forms.Panel sdescPanel;
		internal System.Windows.Forms.TextBox tbsimdescname;
		private System.Windows.Forms.Label label13;
		internal System.Windows.Forms.TextBox tbsim;
		internal System.Windows.Forms.TextBox tbage;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button llsdesccommit;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		internal System.Windows.Forms.ProgressBar pboutgoing;
		internal System.Windows.Forms.ProgressBar pbactive;
		internal System.Windows.Forms.ProgressBar pbplayful;
		internal System.Windows.Forms.ProgressBar pbnice;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		internal System.Windows.Forms.ProgressBar pbenvironment;
		internal System.Windows.Forms.ProgressBar pbfood;
		internal System.Windows.Forms.ProgressBar pbwork;
		internal System.Windows.Forms.ProgressBar pbparanormal;
		internal System.Windows.Forms.ProgressBar pbentertainment;
		internal System.Windows.Forms.ProgressBar pbculture;
		internal System.Windows.Forms.ProgressBar pbpolitics;
		internal System.Windows.Forms.ProgressBar pbhealth;
		internal System.Windows.Forms.ProgressBar pbfashion;
		internal System.Windows.Forms.ProgressBar pbsports;
		internal System.Windows.Forms.ProgressBar pbcrime;
		internal System.Windows.Forms.ProgressBar pbtravel;
		internal System.Windows.Forms.ProgressBar pbweather;
		internal System.Windows.Forms.ProgressBar pbanimals;
		internal System.Windows.Forms.ProgressBar pbschool;
		internal System.Windows.Forms.ProgressBar pbtoys;
		internal System.Windows.Forms.ProgressBar pbscifi;
		internal System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Label label46;
		internal System.Windows.Forms.ComboBox cbaspiration;
		private System.Windows.Forms.TextBox tbneat;
		private System.Windows.Forms.TextBox tboutgoing;
		private System.Windows.Forms.TextBox tbactive;
		private System.Windows.Forms.TextBox tbplayful;
		private System.Windows.Forms.TextBox tbnice;
		internal System.Windows.Forms.ProgressBar pbneat;
		private System.Windows.Forms.TextBox tbscifi;
		private System.Windows.Forms.TextBox tbtoys;
		private System.Windows.Forms.TextBox tbschool;
		private System.Windows.Forms.TextBox tbanimals;
		private System.Windows.Forms.TextBox tbwork;
		private System.Windows.Forms.TextBox tbtravel;
		private System.Windows.Forms.TextBox tbcrime;
		private System.Windows.Forms.TextBox tbsports;
		private System.Windows.Forms.TextBox tbfashion;
		private System.Windows.Forms.TextBox tbhealth;
		private System.Windows.Forms.TextBox tbfood;
		private System.Windows.Forms.TextBox tbpolitics;
		private System.Windows.Forms.TextBox tbmonei;
		private System.Windows.Forms.TextBox tbculture;
		private System.Windows.Forms.TextBox tbentertainment;
		private System.Windows.Forms.TextBox tbparanormal;
		internal System.Windows.Forms.ProgressBar pbmonei;
		private System.Windows.Forms.TextBox tbweather;
		private System.Windows.Forms.TextBox tbenvironment;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		internal System.Windows.Forms.ComboBox cblifesection;
		internal System.Windows.Forms.RadioButton rbfemale;
		internal System.Windows.Forms.RadioButton rbmale;
		private System.Windows.Forms.Label label49;
		internal System.Windows.Forms.Label lbfilename;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel1;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel3;
		internal System.Windows.Forms.TabControl tcsdesc;
		private System.Windows.Forms.TabPage tpinterests;
		private System.Windows.Forms.TabPage tbcharacter;
		private System.Windows.Forms.GroupBox gbcharacter;
		private System.Windows.Forms.TabPage tbrelations;
		internal System.Windows.Forms.ListBox lbrelations;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.Label label55;
		internal System.Windows.Forms.TextBox tboutrelshort;
		internal System.Windows.Forms.TextBox tboutrellong;
		internal System.Windows.Forms.TextBox tbinrellong;
		internal System.Windows.Forms.TextBox tbinrelshort;
		internal System.Windows.Forms.Panel realPanel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label56;
		internal System.Windows.Forms.TextBox tblongterm;
		internal System.Windows.Forms.TextBox tbshortterm;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Label label58;
		private Skybound.VisualStyles.VisualStyleLinkLabel llrelcommit;
		internal Skybound.VisualStyles.VisualStyleLinkLabel llsimrelcommit;
		internal System.Windows.Forms.ComboBox cbzodiac;
		private System.Windows.Forms.CheckBox cboutenemy;
		private System.Windows.Forms.CheckBox cboutfriend;
		private System.Windows.Forms.CheckBox cboutbuddie;
		private System.Windows.Forms.CheckBox cboutcrush;
		private System.Windows.Forms.CheckBox cboutlove;
		private System.Windows.Forms.CheckBox cboutsteady;
		private System.Windows.Forms.CheckBox cboutengaged;
		private System.Windows.Forms.CheckBox cboutmarried;
		internal System.Windows.Forms.GroupBox gbout;
		internal System.Windows.Forms.GroupBox gbin;
		private System.Windows.Forms.CheckBox cbinmarried;
		private System.Windows.Forms.CheckBox cbinengaged;
		private System.Windows.Forms.CheckBox cbinsteady;
		private System.Windows.Forms.CheckBox cbinlove;
		private System.Windows.Forms.CheckBox cbincrush;
		private System.Windows.Forms.CheckBox cbinbuddie;
		private System.Windows.Forms.CheckBox cbinenemy;
		private System.Windows.Forms.GroupBox gbrelation;
		internal System.Windows.Forms.CheckBox cbmarried;
		internal System.Windows.Forms.CheckBox cbengaged;
		internal System.Windows.Forms.CheckBox cbsteady;
		internal System.Windows.Forms.CheckBox cblove;
		internal System.Windows.Forms.CheckBox cbcrush;
		internal System.Windows.Forms.CheckBox cbenemy;
		private System.Windows.Forms.CheckBox cbinfriend;
		internal System.Windows.Forms.CheckBox cbbuddie;
		internal System.Windows.Forms.CheckBox cbfriend;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.GroupBox gblifeline;
		private System.Windows.Forms.Label label60;
		internal System.Windows.Forms.TextBox tblifelinescore;
		private System.Windows.Forms.GroupBox gbcareer;
		private System.Windows.Forms.Label label50;
		internal System.Windows.Forms.ComboBox cbcareer;
		internal System.Windows.Forms.TextBox tbcareervalue;
		private System.Windows.Forms.Label label61;
		internal System.Windows.Forms.ProgressBar pbcarrerlevel;
		internal System.Windows.Forms.TextBox tbcarrerlevel;
		internal System.Windows.Forms.ProgressBar pbblizlifelinepoints;
		internal System.Windows.Forms.TextBox tbblizlifelinepoints;
		internal System.Windows.Forms.ProgressBar pblifelinepoints;
		private System.Windows.Forms.Label label62;
		internal System.Windows.Forms.TextBox tblifelinepoints;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.Label label64;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label68;
		internal System.Windows.Forms.Panel familytiePanel;
		private System.Windows.Forms.Button bttiecommit;
		internal System.Windows.Forms.ComboBox cbtiesims;
		private System.Windows.Forms.GroupBox gbties;
		internal System.Windows.Forms.ComboBox cbtietype;
		internal System.Windows.Forms.Button btdeletetie;
		internal System.Windows.Forms.Button btaddtie;
		internal System.Windows.Forms.ListBox lbties;
		internal System.Windows.Forms.ComboBox cballtieablesims;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcommitties;
		internal System.Windows.Forms.Button btnewtie;
		internal System.Windows.Forms.ComboBox cballrelsims;
		internal System.Windows.Forms.GroupBox gb;
		private System.Windows.Forms.Button btaddrelation;
		private System.Windows.Forms.Button btdeleterelation;
		private System.Windows.Forms.Label label14;
		internal System.Windows.Forms.TextBox tblottype;
		private System.Windows.Forms.Label label65;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcommitobjd;
		private System.Windows.Forms.Label label66;
		internal System.Windows.Forms.ProgressBar pbman;
		private System.Windows.Forms.TextBox tbman;
		private System.Windows.Forms.Label label67;
		internal System.Windows.Forms.ProgressBar pbwoman;
		private System.Windows.Forms.TextBox tbwoman;
		private System.Windows.Forms.Label label69;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox gbelements;
		internal System.Windows.Forms.Panel pnelements;
		private Skybound.VisualStyles.VisualStyleLinkLabel llgetGUID;
		private System.Windows.Forms.TabPage tbskills;
		private System.Windows.Forms.GroupBox gbskills;
		internal System.Windows.Forms.ProgressBar pbcooking;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.TextBox tbfatness;
		internal System.Windows.Forms.ProgressBar pbfatness;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.TextBox tbcleaning;
		private System.Windows.Forms.TextBox tbcreativity;
		private System.Windows.Forms.TextBox tblogic;
		private System.Windows.Forms.TextBox tbbody;
		private System.Windows.Forms.TextBox tbcharisma;
		private System.Windows.Forms.TextBox tbmechanical;
		private System.Windows.Forms.TextBox tbcooking;
		internal System.Windows.Forms.ProgressBar pbcleaning;
		internal System.Windows.Forms.ProgressBar pbcreativity;
		internal System.Windows.Forms.ProgressBar pbbody;
		internal System.Windows.Forms.ProgressBar pbcharisma;
		internal System.Windows.Forms.ProgressBar pbmechanical;
		internal System.Windows.Forms.ProgressBar pblogic;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel2;
		private System.Windows.Forms.GroupBox gbgencharacter;
		internal System.Windows.Forms.ProgressBar pbgenneat;
		private System.Windows.Forms.TextBox tbgennice;
		private System.Windows.Forms.TextBox tbgenplayful;
		private System.Windows.Forms.TextBox tbgenactive;
		private System.Windows.Forms.TextBox tbgenoutgoing;
		private System.Windows.Forms.TextBox tbgenneat;
		internal System.Windows.Forms.ProgressBar pbgennice;
		internal System.Windows.Forms.ProgressBar pbgenplayful;
		internal System.Windows.Forms.ProgressBar pbgenactive;
		internal System.Windows.Forms.ProgressBar pbgenoutgoing;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel4;
		private System.Windows.Forms.TextBox tbromance;
		internal System.Windows.Forms.ProgressBar pbromance;
		private System.Windows.Forms.Label label76;
		private System.Windows.Forms.GroupBox gbschool;
		private System.Windows.Forms.Label label77;
		private System.Windows.Forms.Label label78;
		private System.Windows.Forms.TabPage tbext;
		private System.Windows.Forms.GroupBox gbdecay;
		private System.Windows.Forms.Label label79;
		private System.Windows.Forms.TextBox tbhunger;
		internal System.Windows.Forms.ProgressBar pbhunger;
		internal System.Windows.Forms.ProgressBar pbcomfort;
		private System.Windows.Forms.Label label80;
		private System.Windows.Forms.TextBox tbcomfort;
		internal System.Windows.Forms.ProgressBar pbbladder;
		private System.Windows.Forms.Label label81;
		private System.Windows.Forms.TextBox tbbladder;
		internal System.Windows.Forms.ProgressBar pbenergy;
		private System.Windows.Forms.Label label82;
		private System.Windows.Forms.TextBox tbenergy;
		internal System.Windows.Forms.ProgressBar pbhygiene;
		private System.Windows.Forms.Label label83;
		private System.Windows.Forms.TextBox tbhygiene;
		internal System.Windows.Forms.ProgressBar pbsocial;
		private System.Windows.Forms.Label label84;
		private System.Windows.Forms.TextBox tbsocial;
		internal System.Windows.Forms.ProgressBar pbfun;
		private System.Windows.Forms.Label label85;
		private System.Windows.Forms.TextBox tbfun;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label86;
		internal System.Windows.Forms.TextBox tbautonomy;
		private System.Windows.Forms.Label label87;
		internal System.Windows.Forms.TextBox tbnpc;
		internal System.Windows.Forms.ProgressBar pbjobperformance;
		internal System.Windows.Forms.TextBox tbjobperformance;
		private System.Windows.Forms.Label label88;
		internal System.Windows.Forms.ComboBox cbgrade;
		internal System.Windows.Forms.TextBox tbschooltype;
		internal System.Windows.Forms.ComboBox cbschooltype;
		private System.Windows.Forms.GroupBox groupBox2;
		internal System.Windows.Forms.CheckBox cbisghost;
		internal System.Windows.Forms.CheckBox cbpassobject;
		internal System.Windows.Forms.CheckBox cbpasswalls;
		internal System.Windows.Forms.CheckBox cbpasspeople;
		internal System.Windows.Forms.CheckBox cbignoretraversal;
		private System.Windows.Forms.GroupBox groupBox3;
		internal System.Windows.Forms.CheckBox cbfit;
		internal System.Windows.Forms.CheckBox cbpreginv;
		internal System.Windows.Forms.CheckBox cbpreghalf;
		internal System.Windows.Forms.CheckBox cbpregfull;
		internal System.Windows.Forms.CheckBox cbfat;
		internal System.Windows.Forms.TextBox tbfaminst;
		private System.Windows.Forms.Label label71;
		private System.Windows.Forms.Label label72;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.Label label74;
		private System.Windows.Forms.Label label75;
		internal System.Windows.Forms.Label lbtypename;
		private System.Windows.Forms.CheckBox cboutfamily;
		private System.Windows.Forms.CheckBox cbinfamily;
		private System.Windows.Forms.CheckBox cbinbest;
		private System.Windows.Forms.CheckBox cboutbest;
		internal System.Windows.Forms.CheckBox cbfamily;
		internal System.Windows.Forms.CheckBox cbbest;
		private Skybound.VisualStyles.VisualStyleLinkLabel llsrelcommit;
		internal System.Windows.Forms.TextBox tbsimdescfamname;
		internal System.Windows.Forms.ComboBox cbinfamtype;
		internal System.Windows.Forms.ComboBox cboutfamtype;
		internal System.Windows.Forms.TextBox tbvoice;
		private System.Windows.Forms.Label label90;
		internal System.Windows.Forms.ComboBox cbfamtype;
		private System.Windows.Forms.Label label91;
		internal System.Windows.Forms.TextBox tbflag;
		private System.Windows.Forms.Label label92;
		internal System.Windows.Forms.TextBox tbalbum;
		private System.Windows.Forms.Label label93;
		private System.Windows.Forms.Label label94;
		internal System.Windows.Forms.TextBox tbprevdays;
		internal System.Windows.Forms.TextBox tbagedur;
		private System.Windows.Forms.Label label95;
		internal System.Windows.Forms.TextBox tbunlinked;
		private System.Windows.Forms.Label label96;
		internal System.Windows.Forms.TextBox tborgguid;
		internal System.Windows.Forms.TextBox tbproxguid;
		private System.Windows.Forms.Label label97;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label label63;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox cbphone;
		private System.Windows.Forms.CheckBox cbbaby;
		private System.Windows.Forms.CheckBox cbcomputer;
		private System.Windows.Forms.CheckBox cblot;
		private System.Windows.Forms.CheckBox cbupdate;
		internal System.Windows.Forms.ComboBox cbmajor;
		internal System.Windows.Forms.Label label98;
		internal System.Windows.Forms.TextBox tbmajor;
		internal System.Windows.Forms.TabPage tbuni;
		internal System.Windows.Forms.Label label99;
		internal System.Windows.Forms.CheckBox cboncampus;
		internal System.Windows.Forms.Label label100;
		internal System.Windows.Forms.Label label101;
		internal System.Windows.Forms.Label label102;
		internal System.Windows.Forms.Label label103;
		internal System.Windows.Forms.ProgressBar pbeffort;
		private System.Windows.Forms.TextBox tbeffort;
		internal System.Windows.Forms.ProgressBar pblastgrade;
		private System.Windows.Forms.TextBox tblastgrade;
		internal System.Windows.Forms.TextBox tbsemester;
		internal System.Windows.Forms.TextBox tbinfluence;
		internal System.Windows.Forms.ProgressBar pbunitime;
		private System.Windows.Forms.TextBox tbunitime;
		private Skybound.VisualStyles.VisualStyleLinkLabel llfam;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel5;
		private Skybound.VisualStyles.VisualStyleLinkLabel llcloth;
		private Skybound.VisualStyles.VisualStyleLinkLabel lldna;
		internal System.Windows.Forms.TextBox tbsubhood;
		private System.Windows.Forms.Label label89;
		private Skybound.VisualStyles.VisualStyleLinkLabel linkLabel6;
		private Skybound.VisualStyles.VisualStyleProvider visualStyleProvider1;
		private Skybound.VisualStyles.VisualStyleLinkLabel llmore;


		internal SimPe.Interfaces.Plugin.IFileWrapperSaveExtension wrapper = null;
		public Elements()
		{
			//
			// Erforderlich für die Windows Form-Designerunterstützung
			//
		
			InitializeComponent();

			this.pbhygiene.Tag = 1000;
			this.pbhunger.Tag = 1000;
			this.pbcomfort.Tag = 1000;
			this.pbenergy.Tag = 1000;
			this.pbbladder.Tag = 1000;
			this.pbsocial.Tag = 1000;
			this.pbfun.Tag = 1000;
			this.pbjobperformance.Tag = 1000;
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Elements));
			this.JpegPanel = new System.Windows.Forms.Panel();
			this.pb = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.banner = new System.Windows.Forms.Label();
			this.xmlPanel = new System.Windows.Forms.Panel();
			this.rtb = new System.Windows.Forms.RichTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.visualStyleLinkLabel2 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.objdPanel = new System.Windows.Forms.Panel();
			this.cbupdate = new System.Windows.Forms.CheckBox();
			this.label63 = new System.Windows.Forms.Label();
			this.tbproxguid = new System.Windows.Forms.TextBox();
			this.label97 = new System.Windows.Forms.Label();
			this.tborgguid = new System.Windows.Forms.TextBox();
			this.lbtypename = new System.Windows.Forms.Label();
			this.llgetGUID = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbelements = new System.Windows.Forms.GroupBox();
			this.pnelements = new System.Windows.Forms.Panel();
			this.llcommitobjd = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tblottype = new System.Windows.Forms.TextBox();
			this.label65 = new System.Windows.Forms.Label();
			this.tbsimname = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbsimid = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.familytiePanel = new System.Windows.Forms.Panel();
			this.gbties = new System.Windows.Forms.GroupBox();
			this.btnewtie = new System.Windows.Forms.Button();
			this.cballtieablesims = new System.Windows.Forms.ComboBox();
			this.cbtietype = new System.Windows.Forms.ComboBox();
			this.lbties = new System.Windows.Forms.ListBox();
			this.btdeletetie = new System.Windows.Forms.Button();
			this.btaddtie = new System.Windows.Forms.Button();
			this.llcommitties = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.cbtiesims = new System.Windows.Forms.ComboBox();
			this.bttiecommit = new System.Windows.Forms.Button();
			this.label64 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label68 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.famiPanel = new System.Windows.Forms.Panel();
			this.tbsubhood = new System.Windows.Forms.TextBox();
			this.label89 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.cbcomputer = new System.Windows.Forms.CheckBox();
			this.cblot = new System.Windows.Forms.CheckBox();
			this.cbbaby = new System.Windows.Forms.CheckBox();
			this.cbphone = new System.Windows.Forms.CheckBox();
			this.tbalbum = new System.Windows.Forms.TextBox();
			this.label93 = new System.Windows.Forms.Label();
			this.tbflag = new System.Windows.Forms.TextBox();
			this.label92 = new System.Windows.Forms.Label();
			this.tblotinst = new System.Windows.Forms.TextBox();
			this.llFamiDeleteSim = new System.Windows.Forms.Button();
			this.llFamiAddSim = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.cbsims = new System.Windows.Forms.ComboBox();
			this.lbmembers = new System.Windows.Forms.ListBox();
			this.tbname = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.tbfamily = new System.Windows.Forms.TextBox();
			this.tbmoney = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.sdescPanel = new System.Windows.Forms.Panel();
			this.linkLabel6 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tcsdesc = new System.Windows.Forms.TabControl();
			this.tpinterests = new System.Windows.Forms.TabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label70 = new System.Windows.Forms.Label();
			this.label69 = new System.Windows.Forms.Label();
			this.label67 = new System.Windows.Forms.Label();
			this.pbwoman = new System.Windows.Forms.ProgressBar();
			this.tbwoman = new System.Windows.Forms.TextBox();
			this.label66 = new System.Windows.Forms.Label();
			this.pbman = new System.Windows.Forms.ProgressBar();
			this.tbman = new System.Windows.Forms.TextBox();
			this.pbsports = new System.Windows.Forms.ProgressBar();
			this.pbfashion = new System.Windows.Forms.ProgressBar();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.tbscifi = new System.Windows.Forms.TextBox();
			this.label28 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.pbhealth = new System.Windows.Forms.ProgressBar();
			this.label34 = new System.Windows.Forms.Label();
			this.pbpolitics = new System.Windows.Forms.ProgressBar();
			this.pbmonei = new System.Windows.Forms.ProgressBar();
			this.pbculture = new System.Windows.Forms.ProgressBar();
			this.pbfood = new System.Windows.Forms.ProgressBar();
			this.pbentertainment = new System.Windows.Forms.ProgressBar();
			this.pbparanormal = new System.Windows.Forms.ProgressBar();
			this.pbwork = new System.Windows.Forms.ProgressBar();
			this.tbtoys = new System.Windows.Forms.TextBox();
			this.tbschool = new System.Windows.Forms.TextBox();
			this.tbanimals = new System.Windows.Forms.TextBox();
			this.tbweather = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.tbwork = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.tbtravel = new System.Windows.Forms.TextBox();
			this.label42 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.tbcrime = new System.Windows.Forms.TextBox();
			this.tbsports = new System.Windows.Forms.TextBox();
			this.tbfashion = new System.Windows.Forms.TextBox();
			this.tbhealth = new System.Windows.Forms.TextBox();
			this.tbfood = new System.Windows.Forms.TextBox();
			this.tbpolitics = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.tbmonei = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.tbculture = new System.Windows.Forms.TextBox();
			this.tbentertainment = new System.Windows.Forms.TextBox();
			this.tbparanormal = new System.Windows.Forms.TextBox();
			this.tbenvironment = new System.Windows.Forms.TextBox();
			this.pbscifi = new System.Windows.Forms.ProgressBar();
			this.pbtoys = new System.Windows.Forms.ProgressBar();
			this.pbschool = new System.Windows.Forms.ProgressBar();
			this.label45 = new System.Windows.Forms.Label();
			this.pbanimals = new System.Windows.Forms.ProgressBar();
			this.pbweather = new System.Windows.Forms.ProgressBar();
			this.label44 = new System.Windows.Forms.Label();
			this.pbenvironment = new System.Windows.Forms.ProgressBar();
			this.label39 = new System.Windows.Forms.Label();
			this.pbtravel = new System.Windows.Forms.ProgressBar();
			this.label32 = new System.Windows.Forms.Label();
			this.pbcrime = new System.Windows.Forms.ProgressBar();
			this.linkLabel1 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tbcharacter = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbignoretraversal = new System.Windows.Forms.CheckBox();
			this.cbpasspeople = new System.Windows.Forms.CheckBox();
			this.cbpasswalls = new System.Windows.Forms.CheckBox();
			this.cbpassobject = new System.Windows.Forms.CheckBox();
			this.cbisghost = new System.Windows.Forms.CheckBox();
			this.gbcareer = new System.Windows.Forms.GroupBox();
			this.pbjobperformance = new System.Windows.Forms.ProgressBar();
			this.tbjobperformance = new System.Windows.Forms.TextBox();
			this.label88 = new System.Windows.Forms.Label();
			this.pbcarrerlevel = new System.Windows.Forms.ProgressBar();
			this.tbcarrerlevel = new System.Windows.Forms.TextBox();
			this.label61 = new System.Windows.Forms.Label();
			this.tbcareervalue = new System.Windows.Forms.TextBox();
			this.cbcareer = new System.Windows.Forms.ComboBox();
			this.label50 = new System.Windows.Forms.Label();
			this.gblifeline = new System.Windows.Forms.GroupBox();
			this.pblifelinepoints = new System.Windows.Forms.ProgressBar();
			this.label62 = new System.Windows.Forms.Label();
			this.tblifelinepoints = new System.Windows.Forms.TextBox();
			this.tblifelinescore = new System.Windows.Forms.TextBox();
			this.label60 = new System.Windows.Forms.Label();
			this.pbblizlifelinepoints = new System.Windows.Forms.ProgressBar();
			this.label59 = new System.Windows.Forms.Label();
			this.tbblizlifelinepoints = new System.Windows.Forms.TextBox();
			this.gbcharacter = new System.Windows.Forms.GroupBox();
			this.pbneat = new System.Windows.Forms.ProgressBar();
			this.tbnice = new System.Windows.Forms.TextBox();
			this.tbplayful = new System.Windows.Forms.TextBox();
			this.tbactive = new System.Windows.Forms.TextBox();
			this.tboutgoing = new System.Windows.Forms.TextBox();
			this.tbneat = new System.Windows.Forms.TextBox();
			this.pbnice = new System.Windows.Forms.ProgressBar();
			this.pbplayful = new System.Windows.Forms.ProgressBar();
			this.pbactive = new System.Windows.Forms.ProgressBar();
			this.pboutgoing = new System.Windows.Forms.ProgressBar();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.linkLabel3 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbgencharacter = new System.Windows.Forms.GroupBox();
			this.label71 = new System.Windows.Forms.Label();
			this.label72 = new System.Windows.Forms.Label();
			this.label73 = new System.Windows.Forms.Label();
			this.label74 = new System.Windows.Forms.Label();
			this.label75 = new System.Windows.Forms.Label();
			this.pbgenneat = new System.Windows.Forms.ProgressBar();
			this.tbgennice = new System.Windows.Forms.TextBox();
			this.tbgenplayful = new System.Windows.Forms.TextBox();
			this.tbgenactive = new System.Windows.Forms.TextBox();
			this.tbgenoutgoing = new System.Windows.Forms.TextBox();
			this.tbgenneat = new System.Windows.Forms.TextBox();
			this.pbgennice = new System.Windows.Forms.ProgressBar();
			this.pbgenplayful = new System.Windows.Forms.ProgressBar();
			this.pbgenactive = new System.Windows.Forms.ProgressBar();
			this.pbgenoutgoing = new System.Windows.Forms.ProgressBar();
			this.linkLabel4 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbschool = new System.Windows.Forms.GroupBox();
			this.cbschooltype = new System.Windows.Forms.ComboBox();
			this.cbgrade = new System.Windows.Forms.ComboBox();
			this.label77 = new System.Windows.Forms.Label();
			this.tbschooltype = new System.Windows.Forms.TextBox();
			this.label78 = new System.Windows.Forms.Label();
			this.tbrelations = new System.Windows.Forms.TabPage();
			this.gb = new System.Windows.Forms.GroupBox();
			this.cballrelsims = new System.Windows.Forms.ComboBox();
			this.btaddrelation = new System.Windows.Forms.Button();
			this.btdeleterelation = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.llsimrelcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbout = new System.Windows.Forms.GroupBox();
			this.cboutfamtype = new System.Windows.Forms.ComboBox();
			this.cboutbest = new System.Windows.Forms.CheckBox();
			this.cboutfamily = new System.Windows.Forms.CheckBox();
			this.cboutmarried = new System.Windows.Forms.CheckBox();
			this.cboutengaged = new System.Windows.Forms.CheckBox();
			this.cboutsteady = new System.Windows.Forms.CheckBox();
			this.cboutlove = new System.Windows.Forms.CheckBox();
			this.cboutcrush = new System.Windows.Forms.CheckBox();
			this.cboutbuddie = new System.Windows.Forms.CheckBox();
			this.cboutfriend = new System.Windows.Forms.CheckBox();
			this.cboutenemy = new System.Windows.Forms.CheckBox();
			this.tboutrellong = new System.Windows.Forms.TextBox();
			this.tboutrelshort = new System.Windows.Forms.TextBox();
			this.label53 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.lbrelations = new System.Windows.Forms.ListBox();
			this.gbin = new System.Windows.Forms.GroupBox();
			this.cbinfamtype = new System.Windows.Forms.ComboBox();
			this.cbinbest = new System.Windows.Forms.CheckBox();
			this.cbinfamily = new System.Windows.Forms.CheckBox();
			this.cbinmarried = new System.Windows.Forms.CheckBox();
			this.cbinengaged = new System.Windows.Forms.CheckBox();
			this.cbinsteady = new System.Windows.Forms.CheckBox();
			this.cbinlove = new System.Windows.Forms.CheckBox();
			this.cbincrush = new System.Windows.Forms.CheckBox();
			this.cbinbuddie = new System.Windows.Forms.CheckBox();
			this.cbinfriend = new System.Windows.Forms.CheckBox();
			this.cbinenemy = new System.Windows.Forms.CheckBox();
			this.tbinrellong = new System.Windows.Forms.TextBox();
			this.tbinrelshort = new System.Windows.Forms.TextBox();
			this.label54 = new System.Windows.Forms.Label();
			this.label55 = new System.Windows.Forms.Label();
			this.tbskills = new System.Windows.Forms.TabPage();
			this.gbskills = new System.Windows.Forms.GroupBox();
			this.tbromance = new System.Windows.Forms.TextBox();
			this.pbromance = new System.Windows.Forms.ProgressBar();
			this.label76 = new System.Windows.Forms.Label();
			this.pbcooking = new System.Windows.Forms.ProgressBar();
			this.label21 = new System.Windows.Forms.Label();
			this.tbfatness = new System.Windows.Forms.TextBox();
			this.pbfatness = new System.Windows.Forms.ProgressBar();
			this.label51 = new System.Windows.Forms.Label();
			this.tbcleaning = new System.Windows.Forms.TextBox();
			this.tbcreativity = new System.Windows.Forms.TextBox();
			this.tblogic = new System.Windows.Forms.TextBox();
			this.tbbody = new System.Windows.Forms.TextBox();
			this.tbcharisma = new System.Windows.Forms.TextBox();
			this.tbmechanical = new System.Windows.Forms.TextBox();
			this.tbcooking = new System.Windows.Forms.TextBox();
			this.pbcleaning = new System.Windows.Forms.ProgressBar();
			this.pbcreativity = new System.Windows.Forms.ProgressBar();
			this.pbbody = new System.Windows.Forms.ProgressBar();
			this.pbcharisma = new System.Windows.Forms.ProgressBar();
			this.pbmechanical = new System.Windows.Forms.ProgressBar();
			this.pblogic = new System.Windows.Forms.ProgressBar();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.linkLabel2 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tbext = new System.Windows.Forms.TabPage();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbfit = new System.Windows.Forms.CheckBox();
			this.cbpreginv = new System.Windows.Forms.CheckBox();
			this.cbpreghalf = new System.Windows.Forms.CheckBox();
			this.cbpregfull = new System.Windows.Forms.CheckBox();
			this.cbfat = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
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
			this.gbdecay = new System.Windows.Forms.GroupBox();
			this.pbfun = new System.Windows.Forms.ProgressBar();
			this.label85 = new System.Windows.Forms.Label();
			this.tbfun = new System.Windows.Forms.TextBox();
			this.pbsocial = new System.Windows.Forms.ProgressBar();
			this.label84 = new System.Windows.Forms.Label();
			this.tbsocial = new System.Windows.Forms.TextBox();
			this.pbhygiene = new System.Windows.Forms.ProgressBar();
			this.label83 = new System.Windows.Forms.Label();
			this.tbhygiene = new System.Windows.Forms.TextBox();
			this.pbenergy = new System.Windows.Forms.ProgressBar();
			this.label82 = new System.Windows.Forms.Label();
			this.tbenergy = new System.Windows.Forms.TextBox();
			this.pbbladder = new System.Windows.Forms.ProgressBar();
			this.label81 = new System.Windows.Forms.Label();
			this.tbbladder = new System.Windows.Forms.TextBox();
			this.pbcomfort = new System.Windows.Forms.ProgressBar();
			this.label80 = new System.Windows.Forms.Label();
			this.tbcomfort = new System.Windows.Forms.TextBox();
			this.pbhunger = new System.Windows.Forms.ProgressBar();
			this.label79 = new System.Windows.Forms.Label();
			this.tbhunger = new System.Windows.Forms.TextBox();
			this.tbuni = new System.Windows.Forms.TabPage();
			this.pbunitime = new System.Windows.Forms.ProgressBar();
			this.tbunitime = new System.Windows.Forms.TextBox();
			this.tbinfluence = new System.Windows.Forms.TextBox();
			this.tbsemester = new System.Windows.Forms.TextBox();
			this.pblastgrade = new System.Windows.Forms.ProgressBar();
			this.tblastgrade = new System.Windows.Forms.TextBox();
			this.pbeffort = new System.Windows.Forms.ProgressBar();
			this.tbeffort = new System.Windows.Forms.TextBox();
			this.label103 = new System.Windows.Forms.Label();
			this.label102 = new System.Windows.Forms.Label();
			this.label101 = new System.Windows.Forms.Label();
			this.label100 = new System.Windows.Forms.Label();
			this.cboncampus = new System.Windows.Forms.CheckBox();
			this.label99 = new System.Windows.Forms.Label();
			this.cbmajor = new System.Windows.Forms.ComboBox();
			this.label98 = new System.Windows.Forms.Label();
			this.tbmajor = new System.Windows.Forms.TextBox();
			this.lldna = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.llcloth = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.llfam = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tbsimdescfamname = new System.Windows.Forms.TextBox();
			this.tbfaminst = new System.Windows.Forms.TextBox();
			this.cbzodiac = new System.Windows.Forms.ComboBox();
			this.label49 = new System.Windows.Forms.Label();
			this.rbmale = new System.Windows.Forms.RadioButton();
			this.rbfemale = new System.Windows.Forms.RadioButton();
			this.label48 = new System.Windows.Forms.Label();
			this.cblifesection = new System.Windows.Forms.ComboBox();
			this.label47 = new System.Windows.Forms.Label();
			this.cbaspiration = new System.Windows.Forms.ComboBox();
			this.label46 = new System.Windows.Forms.Label();
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.llsdesccommit = new System.Windows.Forms.Button();
			this.tbsimdescname = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.tbsim = new System.Windows.Forms.TextBox();
			this.tbage = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lbfilename = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.linkLabel5 = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.realPanel = new System.Windows.Forms.Panel();
			this.label91 = new System.Windows.Forms.Label();
			this.cbfamtype = new System.Windows.Forms.ComboBox();
			this.llsrelcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.gbrelation = new System.Windows.Forms.GroupBox();
			this.cbbest = new System.Windows.Forms.CheckBox();
			this.cbfamily = new System.Windows.Forms.CheckBox();
			this.cbmarried = new System.Windows.Forms.CheckBox();
			this.cbengaged = new System.Windows.Forms.CheckBox();
			this.cbsteady = new System.Windows.Forms.CheckBox();
			this.cblove = new System.Windows.Forms.CheckBox();
			this.cbcrush = new System.Windows.Forms.CheckBox();
			this.cbbuddie = new System.Windows.Forms.CheckBox();
			this.cbfriend = new System.Windows.Forms.CheckBox();
			this.cbenemy = new System.Windows.Forms.CheckBox();
			this.tblongterm = new System.Windows.Forms.TextBox();
			this.tbshortterm = new System.Windows.Forms.TextBox();
			this.label57 = new System.Windows.Forms.Label();
			this.label58 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label56 = new System.Windows.Forms.Label();
			this.llrelcommit = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.visualStyleProvider1 = new Skybound.VisualStyles.VisualStyleProvider();
			this.llmore = new Skybound.VisualStyles.VisualStyleLinkLabel();
			this.JpegPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.xmlPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.objdPanel.SuspendLayout();
			this.gbelements.SuspendLayout();
			this.panel6.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.familytiePanel.SuspendLayout();
			this.gbties.SuspendLayout();
			this.panel8.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.famiPanel.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.sdescPanel.SuspendLayout();
			this.tcsdesc.SuspendLayout();
			this.tpinterests.SuspendLayout();
			this.tbcharacter.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gbcareer.SuspendLayout();
			this.gblifeline.SuspendLayout();
			this.gbcharacter.SuspendLayout();
			this.gbgencharacter.SuspendLayout();
			this.gbschool.SuspendLayout();
			this.tbrelations.SuspendLayout();
			this.gb.SuspendLayout();
			this.gbout.SuspendLayout();
			this.gbin.SuspendLayout();
			this.tbskills.SuspendLayout();
			this.gbskills.SuspendLayout();
			this.tbext.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.gbdecay.SuspendLayout();
			this.tbuni.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.realPanel.SuspendLayout();
			this.gbrelation.SuspendLayout();
			this.panel7.SuspendLayout();
			this.SuspendLayout();
			// 
			// JpegPanel
			// 
			this.JpegPanel.AccessibleDescription = resources.GetString("JpegPanel.AccessibleDescription");
			this.JpegPanel.AccessibleName = resources.GetString("JpegPanel.AccessibleName");
			this.JpegPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("JpegPanel.Anchor")));
			this.JpegPanel.AutoScroll = ((bool)(resources.GetObject("JpegPanel.AutoScroll")));
			this.JpegPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("JpegPanel.AutoScrollMargin")));
			this.JpegPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("JpegPanel.AutoScrollMinSize")));
			this.JpegPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("JpegPanel.BackgroundImage")));
			this.JpegPanel.Controls.Add(this.pb);
			this.JpegPanel.Controls.Add(this.panel2);
			this.JpegPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("JpegPanel.Dock")));
			this.JpegPanel.Enabled = ((bool)(resources.GetObject("JpegPanel.Enabled")));
			this.JpegPanel.Font = ((System.Drawing.Font)(resources.GetObject("JpegPanel.Font")));
			this.JpegPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("JpegPanel.ImeMode")));
			this.JpegPanel.Location = ((System.Drawing.Point)(resources.GetObject("JpegPanel.Location")));
			this.JpegPanel.Name = "JpegPanel";
			this.JpegPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("JpegPanel.RightToLeft")));
			this.JpegPanel.Size = ((System.Drawing.Size)(resources.GetObject("JpegPanel.Size")));
			this.JpegPanel.TabIndex = ((int)(resources.GetObject("JpegPanel.TabIndex")));
			this.JpegPanel.Text = resources.GetString("JpegPanel.Text");
			this.toolTip1.SetToolTip(this.JpegPanel, resources.GetString("JpegPanel.ToolTip"));
			this.JpegPanel.Visible = ((bool)(resources.GetObject("JpegPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.JpegPanel, true);
			// 
			// pb
			// 
			this.pb.AccessibleDescription = resources.GetString("pb.AccessibleDescription");
			this.pb.AccessibleName = resources.GetString("pb.AccessibleName");
			this.pb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pb.Anchor")));
			this.pb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pb.BackgroundImage")));
			this.pb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pb.Dock")));
			this.pb.Enabled = ((bool)(resources.GetObject("pb.Enabled")));
			this.pb.Font = ((System.Drawing.Font)(resources.GetObject("pb.Font")));
			this.pb.Image = ((System.Drawing.Image)(resources.GetObject("pb.Image")));
			this.pb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pb.ImeMode")));
			this.pb.Location = ((System.Drawing.Point)(resources.GetObject("pb.Location")));
			this.pb.Name = "pb";
			this.pb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pb.RightToLeft")));
			this.pb.Size = ((System.Drawing.Size)(resources.GetObject("pb.Size")));
			this.pb.SizeMode = ((System.Windows.Forms.PictureBoxSizeMode)(resources.GetObject("pb.SizeMode")));
			this.pb.TabIndex = ((int)(resources.GetObject("pb.TabIndex")));
			this.pb.TabStop = false;
			this.pb.Text = resources.GetString("pb.Text");
			this.toolTip1.SetToolTip(this.pb, resources.GetString("pb.ToolTip"));
			this.pb.Visible = ((bool)(resources.GetObject("pb.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.pb, true);
			// 
			// panel2
			// 
			this.panel2.AccessibleDescription = resources.GetString("panel2.AccessibleDescription");
			this.panel2.AccessibleName = resources.GetString("panel2.AccessibleName");
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel2.Anchor")));
			this.panel2.AutoScroll = ((bool)(resources.GetObject("panel2.AutoScroll")));
			this.panel2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMargin")));
			this.panel2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel2.AutoScrollMinSize")));
			this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
			this.panel2.Controls.Add(this.banner);
			this.panel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel2.Dock")));
			this.panel2.Enabled = ((bool)(resources.GetObject("panel2.Enabled")));
			this.panel2.Font = ((System.Drawing.Font)(resources.GetObject("panel2.Font")));
			this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel2.ImeMode")));
			this.panel2.Location = ((System.Drawing.Point)(resources.GetObject("panel2.Location")));
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel2.RightToLeft")));
			this.panel2.Size = ((System.Drawing.Size)(resources.GetObject("panel2.Size")));
			this.panel2.TabIndex = ((int)(resources.GetObject("panel2.TabIndex")));
			this.panel2.Text = resources.GetString("panel2.Text");
			this.toolTip1.SetToolTip(this.panel2, resources.GetString("panel2.ToolTip"));
			this.panel2.Visible = ((bool)(resources.GetObject("panel2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel2, true);
			// 
			// banner
			// 
			this.banner.AccessibleDescription = resources.GetString("banner.AccessibleDescription");
			this.banner.AccessibleName = resources.GetString("banner.AccessibleName");
			this.banner.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("banner.Anchor")));
			this.banner.AutoSize = ((bool)(resources.GetObject("banner.AutoSize")));
			this.banner.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("banner.Dock")));
			this.banner.Enabled = ((bool)(resources.GetObject("banner.Enabled")));
			this.banner.Font = ((System.Drawing.Font)(resources.GetObject("banner.Font")));
			this.banner.Image = ((System.Drawing.Image)(resources.GetObject("banner.Image")));
			this.banner.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.ImageAlign")));
			this.banner.ImageIndex = ((int)(resources.GetObject("banner.ImageIndex")));
			this.banner.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("banner.ImeMode")));
			this.banner.Location = ((System.Drawing.Point)(resources.GetObject("banner.Location")));
			this.banner.Name = "banner";
			this.banner.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("banner.RightToLeft")));
			this.banner.Size = ((System.Drawing.Size)(resources.GetObject("banner.Size")));
			this.banner.TabIndex = ((int)(resources.GetObject("banner.TabIndex")));
			this.banner.Text = resources.GetString("banner.Text");
			this.banner.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("banner.TextAlign")));
			this.toolTip1.SetToolTip(this.banner, resources.GetString("banner.ToolTip"));
			this.banner.Visible = ((bool)(resources.GetObject("banner.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.banner, true);
			// 
			// xmlPanel
			// 
			this.xmlPanel.AccessibleDescription = resources.GetString("xmlPanel.AccessibleDescription");
			this.xmlPanel.AccessibleName = resources.GetString("xmlPanel.AccessibleName");
			this.xmlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("xmlPanel.Anchor")));
			this.xmlPanel.AutoScroll = ((bool)(resources.GetObject("xmlPanel.AutoScroll")));
			this.xmlPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("xmlPanel.AutoScrollMargin")));
			this.xmlPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("xmlPanel.AutoScrollMinSize")));
			this.xmlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xmlPanel.BackgroundImage")));
			this.xmlPanel.Controls.Add(this.rtb);
			this.xmlPanel.Controls.Add(this.panel3);
			this.xmlPanel.Controls.Add(this.visualStyleLinkLabel2);
			this.xmlPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("xmlPanel.Dock")));
			this.xmlPanel.Enabled = ((bool)(resources.GetObject("xmlPanel.Enabled")));
			this.xmlPanel.Font = ((System.Drawing.Font)(resources.GetObject("xmlPanel.Font")));
			this.xmlPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("xmlPanel.ImeMode")));
			this.xmlPanel.Location = ((System.Drawing.Point)(resources.GetObject("xmlPanel.Location")));
			this.xmlPanel.Name = "xmlPanel";
			this.xmlPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("xmlPanel.RightToLeft")));
			this.xmlPanel.Size = ((System.Drawing.Size)(resources.GetObject("xmlPanel.Size")));
			this.xmlPanel.TabIndex = ((int)(resources.GetObject("xmlPanel.TabIndex")));
			this.xmlPanel.Text = resources.GetString("xmlPanel.Text");
			this.toolTip1.SetToolTip(this.xmlPanel, resources.GetString("xmlPanel.ToolTip"));
			this.xmlPanel.Visible = ((bool)(resources.GetObject("xmlPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.xmlPanel, true);
			// 
			// rtb
			// 
			this.rtb.AccessibleDescription = resources.GetString("rtb.AccessibleDescription");
			this.rtb.AccessibleName = resources.GetString("rtb.AccessibleName");
			this.rtb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("rtb.Anchor")));
			this.rtb.AutoSize = ((bool)(resources.GetObject("rtb.AutoSize")));
			this.rtb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rtb.BackgroundImage")));
			this.rtb.BulletIndent = ((int)(resources.GetObject("rtb.BulletIndent")));
			this.rtb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("rtb.Dock")));
			this.rtb.Enabled = ((bool)(resources.GetObject("rtb.Enabled")));
			this.rtb.Font = ((System.Drawing.Font)(resources.GetObject("rtb.Font")));
			this.rtb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("rtb.ImeMode")));
			this.rtb.Location = ((System.Drawing.Point)(resources.GetObject("rtb.Location")));
			this.rtb.MaxLength = ((int)(resources.GetObject("rtb.MaxLength")));
			this.rtb.Multiline = ((bool)(resources.GetObject("rtb.Multiline")));
			this.rtb.Name = "rtb";
			this.rtb.RightMargin = ((int)(resources.GetObject("rtb.RightMargin")));
			this.rtb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("rtb.RightToLeft")));
			this.rtb.ScrollBars = ((System.Windows.Forms.RichTextBoxScrollBars)(resources.GetObject("rtb.ScrollBars")));
			this.rtb.Size = ((System.Drawing.Size)(resources.GetObject("rtb.Size")));
			this.rtb.TabIndex = ((int)(resources.GetObject("rtb.TabIndex")));
			this.rtb.Text = resources.GetString("rtb.Text");
			this.toolTip1.SetToolTip(this.rtb, resources.GetString("rtb.ToolTip"));
			this.rtb.Visible = ((bool)(resources.GetObject("rtb.Visible")));
			this.rtb.WordWrap = ((bool)(resources.GetObject("rtb.WordWrap")));
			this.rtb.ZoomFactor = ((System.Single)(resources.GetObject("rtb.ZoomFactor")));
			// 
			// panel3
			// 
			this.panel3.AccessibleDescription = resources.GetString("panel3.AccessibleDescription");
			this.panel3.AccessibleName = resources.GetString("panel3.AccessibleName");
			this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel3.Anchor")));
			this.panel3.AutoScroll = ((bool)(resources.GetObject("panel3.AutoScroll")));
			this.panel3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMargin")));
			this.panel3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel3.AutoScrollMinSize")));
			this.panel3.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel3.Dock")));
			this.panel3.Enabled = ((bool)(resources.GetObject("panel3.Enabled")));
			this.panel3.Font = ((System.Drawing.Font)(resources.GetObject("panel3.Font")));
			this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel3.ImeMode")));
			this.panel3.Location = ((System.Drawing.Point)(resources.GetObject("panel3.Location")));
			this.panel3.Name = "panel3";
			this.panel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel3.RightToLeft")));
			this.panel3.Size = ((System.Drawing.Size)(resources.GetObject("panel3.Size")));
			this.panel3.TabIndex = ((int)(resources.GetObject("panel3.TabIndex")));
			this.panel3.Text = resources.GetString("panel3.Text");
			this.toolTip1.SetToolTip(this.panel3, resources.GetString("panel3.ToolTip"));
			this.panel3.Visible = ((bool)(resources.GetObject("panel3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel3, true);
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
			this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
			this.label1.Visible = ((bool)(resources.GetObject("label1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label1, true);
			// 
			// visualStyleLinkLabel2
			// 
			this.visualStyleLinkLabel2.AccessibleDescription = resources.GetString("visualStyleLinkLabel2.AccessibleDescription");
			this.visualStyleLinkLabel2.AccessibleName = resources.GetString("visualStyleLinkLabel2.AccessibleName");
			this.visualStyleLinkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("visualStyleLinkLabel2.Anchor")));
			this.visualStyleLinkLabel2.AutoSize = ((bool)(resources.GetObject("visualStyleLinkLabel2.AutoSize")));
			this.visualStyleLinkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("visualStyleLinkLabel2.Dock")));
			this.visualStyleLinkLabel2.Enabled = ((bool)(resources.GetObject("visualStyleLinkLabel2.Enabled")));
			this.visualStyleLinkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("visualStyleLinkLabel2.Font")));
			this.visualStyleLinkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("visualStyleLinkLabel2.Image")));
			this.visualStyleLinkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("visualStyleLinkLabel2.ImageAlign")));
			this.visualStyleLinkLabel2.ImageIndex = ((int)(resources.GetObject("visualStyleLinkLabel2.ImageIndex")));
			this.visualStyleLinkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("visualStyleLinkLabel2.ImeMode")));
			this.visualStyleLinkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("visualStyleLinkLabel2.LinkArea")));
			this.visualStyleLinkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("visualStyleLinkLabel2.Location")));
			this.visualStyleLinkLabel2.Name = "visualStyleLinkLabel2";
			this.visualStyleLinkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("visualStyleLinkLabel2.RightToLeft")));
			this.visualStyleLinkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("visualStyleLinkLabel2.Size")));
			this.visualStyleLinkLabel2.TabIndex = ((int)(resources.GetObject("visualStyleLinkLabel2.TabIndex")));
			this.visualStyleLinkLabel2.TabStop = true;
			this.visualStyleLinkLabel2.Text = resources.GetString("visualStyleLinkLabel2.Text");
			this.visualStyleLinkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("visualStyleLinkLabel2.TextAlign")));
			this.toolTip1.SetToolTip(this.visualStyleLinkLabel2, resources.GetString("visualStyleLinkLabel2.ToolTip"));
			this.visualStyleLinkLabel2.Visible = ((bool)(resources.GetObject("visualStyleLinkLabel2.Visible")));
			this.visualStyleLinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitXmlClick);
			// 
			// objdPanel
			// 
			this.objdPanel.AccessibleDescription = resources.GetString("objdPanel.AccessibleDescription");
			this.objdPanel.AccessibleName = resources.GetString("objdPanel.AccessibleName");
			this.objdPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("objdPanel.Anchor")));
			this.objdPanel.AutoScroll = ((bool)(resources.GetObject("objdPanel.AutoScroll")));
			this.objdPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("objdPanel.AutoScrollMargin")));
			this.objdPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("objdPanel.AutoScrollMinSize")));
			this.objdPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("objdPanel.BackgroundImage")));
			this.objdPanel.Controls.Add(this.cbupdate);
			this.objdPanel.Controls.Add(this.label63);
			this.objdPanel.Controls.Add(this.tbproxguid);
			this.objdPanel.Controls.Add(this.label97);
			this.objdPanel.Controls.Add(this.tborgguid);
			this.objdPanel.Controls.Add(this.lbtypename);
			this.objdPanel.Controls.Add(this.llgetGUID);
			this.objdPanel.Controls.Add(this.gbelements);
			this.objdPanel.Controls.Add(this.llcommitobjd);
			this.objdPanel.Controls.Add(this.tblottype);
			this.objdPanel.Controls.Add(this.label65);
			this.objdPanel.Controls.Add(this.tbsimname);
			this.objdPanel.Controls.Add(this.label9);
			this.objdPanel.Controls.Add(this.tbsimid);
			this.objdPanel.Controls.Add(this.label8);
			this.objdPanel.Controls.Add(this.panel6);
			this.objdPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("objdPanel.Dock")));
			this.objdPanel.Enabled = ((bool)(resources.GetObject("objdPanel.Enabled")));
			this.objdPanel.Font = ((System.Drawing.Font)(resources.GetObject("objdPanel.Font")));
			this.objdPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("objdPanel.ImeMode")));
			this.objdPanel.Location = ((System.Drawing.Point)(resources.GetObject("objdPanel.Location")));
			this.objdPanel.Name = "objdPanel";
			this.objdPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("objdPanel.RightToLeft")));
			this.objdPanel.Size = ((System.Drawing.Size)(resources.GetObject("objdPanel.Size")));
			this.objdPanel.TabIndex = ((int)(resources.GetObject("objdPanel.TabIndex")));
			this.objdPanel.Text = resources.GetString("objdPanel.Text");
			this.toolTip1.SetToolTip(this.objdPanel, resources.GetString("objdPanel.ToolTip"));
			this.objdPanel.Visible = ((bool)(resources.GetObject("objdPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.objdPanel, true);
			// 
			// cbupdate
			// 
			this.cbupdate.AccessibleDescription = resources.GetString("cbupdate.AccessibleDescription");
			this.cbupdate.AccessibleName = resources.GetString("cbupdate.AccessibleName");
			this.cbupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbupdate.Anchor")));
			this.cbupdate.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbupdate.Appearance")));
			this.cbupdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbupdate.BackgroundImage")));
			this.cbupdate.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.CheckAlign")));
			this.cbupdate.Checked = true;
			this.cbupdate.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbupdate.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbupdate.Dock")));
			this.cbupdate.Enabled = ((bool)(resources.GetObject("cbupdate.Enabled")));
			this.cbupdate.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbupdate.FlatStyle")));
			this.cbupdate.Font = ((System.Drawing.Font)(resources.GetObject("cbupdate.Font")));
			this.cbupdate.Image = ((System.Drawing.Image)(resources.GetObject("cbupdate.Image")));
			this.cbupdate.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.ImageAlign")));
			this.cbupdate.ImageIndex = ((int)(resources.GetObject("cbupdate.ImageIndex")));
			this.cbupdate.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbupdate.ImeMode")));
			this.cbupdate.Location = ((System.Drawing.Point)(resources.GetObject("cbupdate.Location")));
			this.cbupdate.Name = "cbupdate";
			this.cbupdate.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbupdate.RightToLeft")));
			this.cbupdate.Size = ((System.Drawing.Size)(resources.GetObject("cbupdate.Size")));
			this.cbupdate.TabIndex = ((int)(resources.GetObject("cbupdate.TabIndex")));
			this.cbupdate.Text = resources.GetString("cbupdate.Text");
			this.cbupdate.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbupdate.TextAlign")));
			this.toolTip1.SetToolTip(this.cbupdate, resources.GetString("cbupdate.ToolTip"));
			this.cbupdate.Visible = ((bool)(resources.GetObject("cbupdate.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbupdate, true);
			// 
			// label63
			// 
			this.label63.AccessibleDescription = resources.GetString("label63.AccessibleDescription");
			this.label63.AccessibleName = resources.GetString("label63.AccessibleName");
			this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label63.Anchor")));
			this.label63.AutoSize = ((bool)(resources.GetObject("label63.AutoSize")));
			this.label63.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label63.Dock")));
			this.label63.Enabled = ((bool)(resources.GetObject("label63.Enabled")));
			this.label63.Font = ((System.Drawing.Font)(resources.GetObject("label63.Font")));
			this.label63.Image = ((System.Drawing.Image)(resources.GetObject("label63.Image")));
			this.label63.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label63.ImageAlign")));
			this.label63.ImageIndex = ((int)(resources.GetObject("label63.ImageIndex")));
			this.label63.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label63.ImeMode")));
			this.label63.Location = ((System.Drawing.Point)(resources.GetObject("label63.Location")));
			this.label63.Name = "label63";
			this.label63.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label63.RightToLeft")));
			this.label63.Size = ((System.Drawing.Size)(resources.GetObject("label63.Size")));
			this.label63.TabIndex = ((int)(resources.GetObject("label63.TabIndex")));
			this.label63.Text = resources.GetString("label63.Text");
			this.label63.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label63.TextAlign")));
			this.toolTip1.SetToolTip(this.label63, resources.GetString("label63.ToolTip"));
			this.label63.Visible = ((bool)(resources.GetObject("label63.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label63, true);
			// 
			// tbproxguid
			// 
			this.tbproxguid.AccessibleDescription = resources.GetString("tbproxguid.AccessibleDescription");
			this.tbproxguid.AccessibleName = resources.GetString("tbproxguid.AccessibleName");
			this.tbproxguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbproxguid.Anchor")));
			this.tbproxguid.AutoSize = ((bool)(resources.GetObject("tbproxguid.AutoSize")));
			this.tbproxguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbproxguid.BackgroundImage")));
			this.tbproxguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbproxguid.Dock")));
			this.tbproxguid.Enabled = ((bool)(resources.GetObject("tbproxguid.Enabled")));
			this.tbproxguid.Font = ((System.Drawing.Font)(resources.GetObject("tbproxguid.Font")));
			this.tbproxguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbproxguid.ImeMode")));
			this.tbproxguid.Location = ((System.Drawing.Point)(resources.GetObject("tbproxguid.Location")));
			this.tbproxguid.MaxLength = ((int)(resources.GetObject("tbproxguid.MaxLength")));
			this.tbproxguid.Multiline = ((bool)(resources.GetObject("tbproxguid.Multiline")));
			this.tbproxguid.Name = "tbproxguid";
			this.tbproxguid.PasswordChar = ((char)(resources.GetObject("tbproxguid.PasswordChar")));
			this.tbproxguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbproxguid.RightToLeft")));
			this.tbproxguid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbproxguid.ScrollBars")));
			this.tbproxguid.Size = ((System.Drawing.Size)(resources.GetObject("tbproxguid.Size")));
			this.tbproxguid.TabIndex = ((int)(resources.GetObject("tbproxguid.TabIndex")));
			this.tbproxguid.Text = resources.GetString("tbproxguid.Text");
			this.tbproxguid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbproxguid.TextAlign")));
			this.toolTip1.SetToolTip(this.tbproxguid, resources.GetString("tbproxguid.ToolTip"));
			this.tbproxguid.Visible = ((bool)(resources.GetObject("tbproxguid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbproxguid, true);
			this.tbproxguid.WordWrap = ((bool)(resources.GetObject("tbproxguid.WordWrap")));
			// 
			// label97
			// 
			this.label97.AccessibleDescription = resources.GetString("label97.AccessibleDescription");
			this.label97.AccessibleName = resources.GetString("label97.AccessibleName");
			this.label97.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label97.Anchor")));
			this.label97.AutoSize = ((bool)(resources.GetObject("label97.AutoSize")));
			this.label97.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label97.Dock")));
			this.label97.Enabled = ((bool)(resources.GetObject("label97.Enabled")));
			this.label97.Font = ((System.Drawing.Font)(resources.GetObject("label97.Font")));
			this.label97.Image = ((System.Drawing.Image)(resources.GetObject("label97.Image")));
			this.label97.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label97.ImageAlign")));
			this.label97.ImageIndex = ((int)(resources.GetObject("label97.ImageIndex")));
			this.label97.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label97.ImeMode")));
			this.label97.Location = ((System.Drawing.Point)(resources.GetObject("label97.Location")));
			this.label97.Name = "label97";
			this.label97.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label97.RightToLeft")));
			this.label97.Size = ((System.Drawing.Size)(resources.GetObject("label97.Size")));
			this.label97.TabIndex = ((int)(resources.GetObject("label97.TabIndex")));
			this.label97.Text = resources.GetString("label97.Text");
			this.label97.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label97.TextAlign")));
			this.toolTip1.SetToolTip(this.label97, resources.GetString("label97.ToolTip"));
			this.label97.Visible = ((bool)(resources.GetObject("label97.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label97, true);
			// 
			// tborgguid
			// 
			this.tborgguid.AccessibleDescription = resources.GetString("tborgguid.AccessibleDescription");
			this.tborgguid.AccessibleName = resources.GetString("tborgguid.AccessibleName");
			this.tborgguid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tborgguid.Anchor")));
			this.tborgguid.AutoSize = ((bool)(resources.GetObject("tborgguid.AutoSize")));
			this.tborgguid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tborgguid.BackgroundImage")));
			this.tborgguid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tborgguid.Dock")));
			this.tborgguid.Enabled = ((bool)(resources.GetObject("tborgguid.Enabled")));
			this.tborgguid.Font = ((System.Drawing.Font)(resources.GetObject("tborgguid.Font")));
			this.tborgguid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tborgguid.ImeMode")));
			this.tborgguid.Location = ((System.Drawing.Point)(resources.GetObject("tborgguid.Location")));
			this.tborgguid.MaxLength = ((int)(resources.GetObject("tborgguid.MaxLength")));
			this.tborgguid.Multiline = ((bool)(resources.GetObject("tborgguid.Multiline")));
			this.tborgguid.Name = "tborgguid";
			this.tborgguid.PasswordChar = ((char)(resources.GetObject("tborgguid.PasswordChar")));
			this.tborgguid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tborgguid.RightToLeft")));
			this.tborgguid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tborgguid.ScrollBars")));
			this.tborgguid.Size = ((System.Drawing.Size)(resources.GetObject("tborgguid.Size")));
			this.tborgguid.TabIndex = ((int)(resources.GetObject("tborgguid.TabIndex")));
			this.tborgguid.Text = resources.GetString("tborgguid.Text");
			this.tborgguid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tborgguid.TextAlign")));
			this.toolTip1.SetToolTip(this.tborgguid, resources.GetString("tborgguid.ToolTip"));
			this.tborgguid.Visible = ((bool)(resources.GetObject("tborgguid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tborgguid, true);
			this.tborgguid.WordWrap = ((bool)(resources.GetObject("tborgguid.WordWrap")));
			// 
			// lbtypename
			// 
			this.lbtypename.AccessibleDescription = resources.GetString("lbtypename.AccessibleDescription");
			this.lbtypename.AccessibleName = resources.GetString("lbtypename.AccessibleName");
			this.lbtypename.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbtypename.Anchor")));
			this.lbtypename.AutoSize = ((bool)(resources.GetObject("lbtypename.AutoSize")));
			this.lbtypename.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbtypename.Dock")));
			this.lbtypename.Enabled = ((bool)(resources.GetObject("lbtypename.Enabled")));
			this.lbtypename.Font = ((System.Drawing.Font)(resources.GetObject("lbtypename.Font")));
			this.lbtypename.Image = ((System.Drawing.Image)(resources.GetObject("lbtypename.Image")));
			this.lbtypename.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtypename.ImageAlign")));
			this.lbtypename.ImageIndex = ((int)(resources.GetObject("lbtypename.ImageIndex")));
			this.lbtypename.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbtypename.ImeMode")));
			this.lbtypename.Location = ((System.Drawing.Point)(resources.GetObject("lbtypename.Location")));
			this.lbtypename.Name = "lbtypename";
			this.lbtypename.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbtypename.RightToLeft")));
			this.lbtypename.Size = ((System.Drawing.Size)(resources.GetObject("lbtypename.Size")));
			this.lbtypename.TabIndex = ((int)(resources.GetObject("lbtypename.TabIndex")));
			this.lbtypename.Text = resources.GetString("lbtypename.Text");
			this.lbtypename.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbtypename.TextAlign")));
			this.toolTip1.SetToolTip(this.lbtypename, resources.GetString("lbtypename.ToolTip"));
			this.lbtypename.Visible = ((bool)(resources.GetObject("lbtypename.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.lbtypename, true);
			// 
			// llgetGUID
			// 
			this.llgetGUID.AccessibleDescription = resources.GetString("llgetGUID.AccessibleDescription");
			this.llgetGUID.AccessibleName = resources.GetString("llgetGUID.AccessibleName");
			this.llgetGUID.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llgetGUID.Anchor")));
			this.llgetGUID.AutoSize = ((bool)(resources.GetObject("llgetGUID.AutoSize")));
			this.llgetGUID.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llgetGUID.Dock")));
			this.llgetGUID.Enabled = ((bool)(resources.GetObject("llgetGUID.Enabled")));
			this.llgetGUID.Font = ((System.Drawing.Font)(resources.GetObject("llgetGUID.Font")));
			this.llgetGUID.Image = ((System.Drawing.Image)(resources.GetObject("llgetGUID.Image")));
			this.llgetGUID.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llgetGUID.ImageAlign")));
			this.llgetGUID.ImageIndex = ((int)(resources.GetObject("llgetGUID.ImageIndex")));
			this.llgetGUID.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llgetGUID.ImeMode")));
			this.llgetGUID.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llgetGUID.LinkArea")));
			this.llgetGUID.Location = ((System.Drawing.Point)(resources.GetObject("llgetGUID.Location")));
			this.llgetGUID.Name = "llgetGUID";
			this.llgetGUID.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llgetGUID.RightToLeft")));
			this.llgetGUID.Size = ((System.Drawing.Size)(resources.GetObject("llgetGUID.Size")));
			this.llgetGUID.TabIndex = ((int)(resources.GetObject("llgetGUID.TabIndex")));
			this.llgetGUID.TabStop = true;
			this.llgetGUID.Text = resources.GetString("llgetGUID.Text");
			this.llgetGUID.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llgetGUID.TextAlign")));
			this.toolTip1.SetToolTip(this.llgetGUID, resources.GetString("llgetGUID.ToolTip"));
			this.llgetGUID.Visible = ((bool)(resources.GetObject("llgetGUID.Visible")));
			this.llgetGUID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GetGUIDClicked);
			// 
			// gbelements
			// 
			this.gbelements.AccessibleDescription = resources.GetString("gbelements.AccessibleDescription");
			this.gbelements.AccessibleName = resources.GetString("gbelements.AccessibleName");
			this.gbelements.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbelements.Anchor")));
			this.gbelements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbelements.BackgroundImage")));
			this.gbelements.Controls.Add(this.pnelements);
			this.gbelements.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbelements.Dock")));
			this.gbelements.Enabled = ((bool)(resources.GetObject("gbelements.Enabled")));
			this.gbelements.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbelements.Font = ((System.Drawing.Font)(resources.GetObject("gbelements.Font")));
			this.gbelements.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbelements.ImeMode")));
			this.gbelements.Location = ((System.Drawing.Point)(resources.GetObject("gbelements.Location")));
			this.gbelements.Name = "gbelements";
			this.gbelements.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbelements.RightToLeft")));
			this.gbelements.Size = ((System.Drawing.Size)(resources.GetObject("gbelements.Size")));
			this.gbelements.TabIndex = ((int)(resources.GetObject("gbelements.TabIndex")));
			this.gbelements.TabStop = false;
			this.gbelements.Text = resources.GetString("gbelements.Text");
			this.toolTip1.SetToolTip(this.gbelements, resources.GetString("gbelements.ToolTip"));
			this.gbelements.Visible = ((bool)(resources.GetObject("gbelements.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbelements, true);
			// 
			// pnelements
			// 
			this.pnelements.AccessibleDescription = resources.GetString("pnelements.AccessibleDescription");
			this.pnelements.AccessibleName = resources.GetString("pnelements.AccessibleName");
			this.pnelements.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pnelements.Anchor")));
			this.pnelements.AutoScroll = ((bool)(resources.GetObject("pnelements.AutoScroll")));
			this.pnelements.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("pnelements.AutoScrollMargin")));
			this.pnelements.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("pnelements.AutoScrollMinSize")));
			this.pnelements.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnelements.BackgroundImage")));
			this.pnelements.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pnelements.Dock")));
			this.pnelements.Enabled = ((bool)(resources.GetObject("pnelements.Enabled")));
			this.pnelements.Font = ((System.Drawing.Font)(resources.GetObject("pnelements.Font")));
			this.pnelements.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pnelements.ImeMode")));
			this.pnelements.Location = ((System.Drawing.Point)(resources.GetObject("pnelements.Location")));
			this.pnelements.Name = "pnelements";
			this.pnelements.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pnelements.RightToLeft")));
			this.pnelements.Size = ((System.Drawing.Size)(resources.GetObject("pnelements.Size")));
			this.pnelements.TabIndex = ((int)(resources.GetObject("pnelements.TabIndex")));
			this.pnelements.Text = resources.GetString("pnelements.Text");
			this.toolTip1.SetToolTip(this.pnelements, resources.GetString("pnelements.ToolTip"));
			this.pnelements.Visible = ((bool)(resources.GetObject("pnelements.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.pnelements, true);
			// 
			// llcommitobjd
			// 
			this.llcommitobjd.AccessibleDescription = resources.GetString("llcommitobjd.AccessibleDescription");
			this.llcommitobjd.AccessibleName = resources.GetString("llcommitobjd.AccessibleName");
			this.llcommitobjd.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommitobjd.Anchor")));
			this.llcommitobjd.AutoSize = ((bool)(resources.GetObject("llcommitobjd.AutoSize")));
			this.llcommitobjd.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommitobjd.Dock")));
			this.llcommitobjd.Enabled = ((bool)(resources.GetObject("llcommitobjd.Enabled")));
			this.llcommitobjd.Font = ((System.Drawing.Font)(resources.GetObject("llcommitobjd.Font")));
			this.llcommitobjd.Image = ((System.Drawing.Image)(resources.GetObject("llcommitobjd.Image")));
			this.llcommitobjd.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitobjd.ImageAlign")));
			this.llcommitobjd.ImageIndex = ((int)(resources.GetObject("llcommitobjd.ImageIndex")));
			this.llcommitobjd.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommitobjd.ImeMode")));
			this.llcommitobjd.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommitobjd.LinkArea")));
			this.llcommitobjd.Location = ((System.Drawing.Point)(resources.GetObject("llcommitobjd.Location")));
			this.llcommitobjd.Name = "llcommitobjd";
			this.llcommitobjd.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommitobjd.RightToLeft")));
			this.llcommitobjd.Size = ((System.Drawing.Size)(resources.GetObject("llcommitobjd.Size")));
			this.llcommitobjd.TabIndex = ((int)(resources.GetObject("llcommitobjd.TabIndex")));
			this.llcommitobjd.TabStop = true;
			this.llcommitobjd.Text = resources.GetString("llcommitobjd.Text");
			this.llcommitobjd.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitobjd.TextAlign")));
			this.toolTip1.SetToolTip(this.llcommitobjd, resources.GetString("llcommitobjd.ToolTip"));
			this.llcommitobjd.Visible = ((bool)(resources.GetObject("llcommitobjd.Visible")));
			this.llcommitobjd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitObjdClicked);
			// 
			// tblottype
			// 
			this.tblottype.AccessibleDescription = resources.GetString("tblottype.AccessibleDescription");
			this.tblottype.AccessibleName = resources.GetString("tblottype.AccessibleName");
			this.tblottype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblottype.Anchor")));
			this.tblottype.AutoSize = ((bool)(resources.GetObject("tblottype.AutoSize")));
			this.tblottype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblottype.BackgroundImage")));
			this.tblottype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblottype.Dock")));
			this.tblottype.Enabled = ((bool)(resources.GetObject("tblottype.Enabled")));
			this.tblottype.Font = ((System.Drawing.Font)(resources.GetObject("tblottype.Font")));
			this.tblottype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblottype.ImeMode")));
			this.tblottype.Location = ((System.Drawing.Point)(resources.GetObject("tblottype.Location")));
			this.tblottype.MaxLength = ((int)(resources.GetObject("tblottype.MaxLength")));
			this.tblottype.Multiline = ((bool)(resources.GetObject("tblottype.Multiline")));
			this.tblottype.Name = "tblottype";
			this.tblottype.PasswordChar = ((char)(resources.GetObject("tblottype.PasswordChar")));
			this.tblottype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblottype.RightToLeft")));
			this.tblottype.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblottype.ScrollBars")));
			this.tblottype.Size = ((System.Drawing.Size)(resources.GetObject("tblottype.Size")));
			this.tblottype.TabIndex = ((int)(resources.GetObject("tblottype.TabIndex")));
			this.tblottype.Text = resources.GetString("tblottype.Text");
			this.tblottype.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblottype.TextAlign")));
			this.toolTip1.SetToolTip(this.tblottype, resources.GetString("tblottype.ToolTip"));
			this.tblottype.Visible = ((bool)(resources.GetObject("tblottype.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblottype, true);
			this.tblottype.WordWrap = ((bool)(resources.GetObject("tblottype.WordWrap")));
			// 
			// label65
			// 
			this.label65.AccessibleDescription = resources.GetString("label65.AccessibleDescription");
			this.label65.AccessibleName = resources.GetString("label65.AccessibleName");
			this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label65.Anchor")));
			this.label65.AutoSize = ((bool)(resources.GetObject("label65.AutoSize")));
			this.label65.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label65.Dock")));
			this.label65.Enabled = ((bool)(resources.GetObject("label65.Enabled")));
			this.label65.Font = ((System.Drawing.Font)(resources.GetObject("label65.Font")));
			this.label65.Image = ((System.Drawing.Image)(resources.GetObject("label65.Image")));
			this.label65.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label65.ImageAlign")));
			this.label65.ImageIndex = ((int)(resources.GetObject("label65.ImageIndex")));
			this.label65.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label65.ImeMode")));
			this.label65.Location = ((System.Drawing.Point)(resources.GetObject("label65.Location")));
			this.label65.Name = "label65";
			this.label65.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label65.RightToLeft")));
			this.label65.Size = ((System.Drawing.Size)(resources.GetObject("label65.Size")));
			this.label65.TabIndex = ((int)(resources.GetObject("label65.TabIndex")));
			this.label65.Text = resources.GetString("label65.Text");
			this.label65.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label65.TextAlign")));
			this.toolTip1.SetToolTip(this.label65, resources.GetString("label65.ToolTip"));
			this.label65.Visible = ((bool)(resources.GetObject("label65.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label65, true);
			// 
			// tbsimname
			// 
			this.tbsimname.AccessibleDescription = resources.GetString("tbsimname.AccessibleDescription");
			this.tbsimname.AccessibleName = resources.GetString("tbsimname.AccessibleName");
			this.tbsimname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimname.Anchor")));
			this.tbsimname.AutoSize = ((bool)(resources.GetObject("tbsimname.AutoSize")));
			this.tbsimname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimname.BackgroundImage")));
			this.tbsimname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimname.Dock")));
			this.tbsimname.Enabled = ((bool)(resources.GetObject("tbsimname.Enabled")));
			this.tbsimname.Font = ((System.Drawing.Font)(resources.GetObject("tbsimname.Font")));
			this.tbsimname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimname.ImeMode")));
			this.tbsimname.Location = ((System.Drawing.Point)(resources.GetObject("tbsimname.Location")));
			this.tbsimname.MaxLength = ((int)(resources.GetObject("tbsimname.MaxLength")));
			this.tbsimname.Multiline = ((bool)(resources.GetObject("tbsimname.Multiline")));
			this.tbsimname.Name = "tbsimname";
			this.tbsimname.PasswordChar = ((char)(resources.GetObject("tbsimname.PasswordChar")));
			this.tbsimname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimname.RightToLeft")));
			this.tbsimname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimname.ScrollBars")));
			this.tbsimname.Size = ((System.Drawing.Size)(resources.GetObject("tbsimname.Size")));
			this.tbsimname.TabIndex = ((int)(resources.GetObject("tbsimname.TabIndex")));
			this.tbsimname.Text = resources.GetString("tbsimname.Text");
			this.tbsimname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimname.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsimname, resources.GetString("tbsimname.ToolTip"));
			this.tbsimname.Visible = ((bool)(resources.GetObject("tbsimname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimname, true);
			this.tbsimname.WordWrap = ((bool)(resources.GetObject("tbsimname.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label9, resources.GetString("label9.ToolTip"));
			this.label9.Visible = ((bool)(resources.GetObject("label9.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label9, true);
			// 
			// tbsimid
			// 
			this.tbsimid.AccessibleDescription = resources.GetString("tbsimid.AccessibleDescription");
			this.tbsimid.AccessibleName = resources.GetString("tbsimid.AccessibleName");
			this.tbsimid.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsimid.Anchor")));
			this.tbsimid.AutoSize = ((bool)(resources.GetObject("tbsimid.AutoSize")));
			this.tbsimid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsimid.BackgroundImage")));
			this.tbsimid.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsimid.Dock")));
			this.tbsimid.Enabled = ((bool)(resources.GetObject("tbsimid.Enabled")));
			this.tbsimid.Font = ((System.Drawing.Font)(resources.GetObject("tbsimid.Font")));
			this.tbsimid.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsimid.ImeMode")));
			this.tbsimid.Location = ((System.Drawing.Point)(resources.GetObject("tbsimid.Location")));
			this.tbsimid.MaxLength = ((int)(resources.GetObject("tbsimid.MaxLength")));
			this.tbsimid.Multiline = ((bool)(resources.GetObject("tbsimid.Multiline")));
			this.tbsimid.Name = "tbsimid";
			this.tbsimid.PasswordChar = ((char)(resources.GetObject("tbsimid.PasswordChar")));
			this.tbsimid.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsimid.RightToLeft")));
			this.tbsimid.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsimid.ScrollBars")));
			this.tbsimid.Size = ((System.Drawing.Size)(resources.GetObject("tbsimid.Size")));
			this.tbsimid.TabIndex = ((int)(resources.GetObject("tbsimid.TabIndex")));
			this.tbsimid.Text = resources.GetString("tbsimid.Text");
			this.tbsimid.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsimid.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsimid, resources.GetString("tbsimid.ToolTip"));
			this.tbsimid.Visible = ((bool)(resources.GetObject("tbsimid.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimid, true);
			this.tbsimid.WordWrap = ((bool)(resources.GetObject("tbsimid.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label8, resources.GetString("label8.ToolTip"));
			this.label8.Visible = ((bool)(resources.GetObject("label8.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label8, true);
			// 
			// panel6
			// 
			this.panel6.AccessibleDescription = resources.GetString("panel6.AccessibleDescription");
			this.panel6.AccessibleName = resources.GetString("panel6.AccessibleName");
			this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel6.Anchor")));
			this.panel6.AutoScroll = ((bool)(resources.GetObject("panel6.AutoScroll")));
			this.panel6.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMargin")));
			this.panel6.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel6.AutoScrollMinSize")));
			this.panel6.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
			this.panel6.Controls.Add(this.label12);
			this.panel6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel6.Dock")));
			this.panel6.Enabled = ((bool)(resources.GetObject("panel6.Enabled")));
			this.panel6.Font = ((System.Drawing.Font)(resources.GetObject("panel6.Font")));
			this.panel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel6.ImeMode")));
			this.panel6.Location = ((System.Drawing.Point)(resources.GetObject("panel6.Location")));
			this.panel6.Name = "panel6";
			this.panel6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel6.RightToLeft")));
			this.panel6.Size = ((System.Drawing.Size)(resources.GetObject("panel6.Size")));
			this.panel6.TabIndex = ((int)(resources.GetObject("panel6.TabIndex")));
			this.panel6.Text = resources.GetString("panel6.Text");
			this.toolTip1.SetToolTip(this.panel6, resources.GetString("panel6.ToolTip"));
			this.panel6.Visible = ((bool)(resources.GetObject("panel6.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel6, true);
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
			this.toolTip1.SetToolTip(this.label12, resources.GetString("label12.ToolTip"));
			this.label12.Visible = ((bool)(resources.GetObject("label12.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label12, true);
			// 
			// tabControl1
			// 
			this.tabControl1.AccessibleDescription = resources.GetString("tabControl1.AccessibleDescription");
			this.tabControl1.AccessibleName = resources.GetString("tabControl1.AccessibleName");
			this.tabControl1.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tabControl1.Alignment")));
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabControl1.Anchor")));
			this.tabControl1.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tabControl1.Appearance")));
			this.tabControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabControl1.BackgroundImage")));
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabControl1.Dock")));
			this.tabControl1.Enabled = ((bool)(resources.GetObject("tabControl1.Enabled")));
			this.tabControl1.Font = ((System.Drawing.Font)(resources.GetObject("tabControl1.Font")));
			this.tabControl1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabControl1.ImeMode")));
			this.tabControl1.ItemSize = ((System.Drawing.Size)(resources.GetObject("tabControl1.ItemSize")));
			this.tabControl1.Location = ((System.Drawing.Point)(resources.GetObject("tabControl1.Location")));
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = ((System.Drawing.Point)(resources.GetObject("tabControl1.Padding")));
			this.tabControl1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabControl1.RightToLeft")));
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.ShowToolTips = ((bool)(resources.GetObject("tabControl1.ShowToolTips")));
			this.tabControl1.Size = ((System.Drawing.Size)(resources.GetObject("tabControl1.Size")));
			this.tabControl1.TabIndex = ((int)(resources.GetObject("tabControl1.TabIndex")));
			this.tabControl1.Text = resources.GetString("tabControl1.Text");
			this.toolTip1.SetToolTip(this.tabControl1, resources.GetString("tabControl1.ToolTip"));
			this.tabControl1.Visible = ((bool)(resources.GetObject("tabControl1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabControl1, true);
			// 
			// tabPage4
			// 
			this.tabPage4.AccessibleDescription = resources.GetString("tabPage4.AccessibleDescription");
			this.tabPage4.AccessibleName = resources.GetString("tabPage4.AccessibleName");
			this.tabPage4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage4.Anchor")));
			this.tabPage4.AutoScroll = ((bool)(resources.GetObject("tabPage4.AutoScroll")));
			this.tabPage4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMargin")));
			this.tabPage4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage4.AutoScrollMinSize")));
			this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
			this.tabPage4.Controls.Add(this.familytiePanel);
			this.tabPage4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage4.Dock")));
			this.tabPage4.Enabled = ((bool)(resources.GetObject("tabPage4.Enabled")));
			this.tabPage4.Font = ((System.Drawing.Font)(resources.GetObject("tabPage4.Font")));
			this.tabPage4.ImageIndex = ((int)(resources.GetObject("tabPage4.ImageIndex")));
			this.tabPage4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage4.ImeMode")));
			this.tabPage4.Location = ((System.Drawing.Point)(resources.GetObject("tabPage4.Location")));
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage4.RightToLeft")));
			this.tabPage4.Size = ((System.Drawing.Size)(resources.GetObject("tabPage4.Size")));
			this.tabPage4.TabIndex = ((int)(resources.GetObject("tabPage4.TabIndex")));
			this.tabPage4.Text = resources.GetString("tabPage4.Text");
			this.toolTip1.SetToolTip(this.tabPage4, resources.GetString("tabPage4.ToolTip"));
			this.tabPage4.ToolTipText = resources.GetString("tabPage4.ToolTipText");
			this.tabPage4.Visible = ((bool)(resources.GetObject("tabPage4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage4, true);
			// 
			// familytiePanel
			// 
			this.familytiePanel.AccessibleDescription = resources.GetString("familytiePanel.AccessibleDescription");
			this.familytiePanel.AccessibleName = resources.GetString("familytiePanel.AccessibleName");
			this.familytiePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("familytiePanel.Anchor")));
			this.familytiePanel.AutoScroll = ((bool)(resources.GetObject("familytiePanel.AutoScroll")));
			this.familytiePanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("familytiePanel.AutoScrollMargin")));
			this.familytiePanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("familytiePanel.AutoScrollMinSize")));
			this.familytiePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("familytiePanel.BackgroundImage")));
			this.familytiePanel.Controls.Add(this.gbties);
			this.familytiePanel.Controls.Add(this.cbtiesims);
			this.familytiePanel.Controls.Add(this.bttiecommit);
			this.familytiePanel.Controls.Add(this.label64);
			this.familytiePanel.Controls.Add(this.panel8);
			this.familytiePanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("familytiePanel.Dock")));
			this.familytiePanel.Enabled = ((bool)(resources.GetObject("familytiePanel.Enabled")));
			this.familytiePanel.Font = ((System.Drawing.Font)(resources.GetObject("familytiePanel.Font")));
			this.familytiePanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("familytiePanel.ImeMode")));
			this.familytiePanel.Location = ((System.Drawing.Point)(resources.GetObject("familytiePanel.Location")));
			this.familytiePanel.Name = "familytiePanel";
			this.familytiePanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("familytiePanel.RightToLeft")));
			this.familytiePanel.Size = ((System.Drawing.Size)(resources.GetObject("familytiePanel.Size")));
			this.familytiePanel.TabIndex = ((int)(resources.GetObject("familytiePanel.TabIndex")));
			this.familytiePanel.Text = resources.GetString("familytiePanel.Text");
			this.toolTip1.SetToolTip(this.familytiePanel, resources.GetString("familytiePanel.ToolTip"));
			this.familytiePanel.Visible = ((bool)(resources.GetObject("familytiePanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.familytiePanel, true);
			// 
			// gbties
			// 
			this.gbties.AccessibleDescription = resources.GetString("gbties.AccessibleDescription");
			this.gbties.AccessibleName = resources.GetString("gbties.AccessibleName");
			this.gbties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbties.Anchor")));
			this.gbties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbties.BackgroundImage")));
			this.gbties.Controls.Add(this.btnewtie);
			this.gbties.Controls.Add(this.cballtieablesims);
			this.gbties.Controls.Add(this.cbtietype);
			this.gbties.Controls.Add(this.lbties);
			this.gbties.Controls.Add(this.btdeletetie);
			this.gbties.Controls.Add(this.btaddtie);
			this.gbties.Controls.Add(this.llcommitties);
			this.gbties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbties.Dock")));
			this.gbties.Enabled = ((bool)(resources.GetObject("gbties.Enabled")));
			this.gbties.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbties.Font = ((System.Drawing.Font)(resources.GetObject("gbties.Font")));
			this.gbties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbties.ImeMode")));
			this.gbties.Location = ((System.Drawing.Point)(resources.GetObject("gbties.Location")));
			this.gbties.Name = "gbties";
			this.gbties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbties.RightToLeft")));
			this.gbties.Size = ((System.Drawing.Size)(resources.GetObject("gbties.Size")));
			this.gbties.TabIndex = ((int)(resources.GetObject("gbties.TabIndex")));
			this.gbties.TabStop = false;
			this.gbties.Text = resources.GetString("gbties.Text");
			this.toolTip1.SetToolTip(this.gbties, resources.GetString("gbties.ToolTip"));
			this.gbties.Visible = ((bool)(resources.GetObject("gbties.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbties, true);
			// 
			// btnewtie
			// 
			this.btnewtie.AccessibleDescription = resources.GetString("btnewtie.AccessibleDescription");
			this.btnewtie.AccessibleName = resources.GetString("btnewtie.AccessibleName");
			this.btnewtie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btnewtie.Anchor")));
			this.btnewtie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnewtie.BackgroundImage")));
			this.btnewtie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btnewtie.Dock")));
			this.btnewtie.Enabled = ((bool)(resources.GetObject("btnewtie.Enabled")));
			this.btnewtie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btnewtie.FlatStyle")));
			this.btnewtie.Font = ((System.Drawing.Font)(resources.GetObject("btnewtie.Font")));
			this.btnewtie.Image = ((System.Drawing.Image)(resources.GetObject("btnewtie.Image")));
			this.btnewtie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnewtie.ImageAlign")));
			this.btnewtie.ImageIndex = ((int)(resources.GetObject("btnewtie.ImageIndex")));
			this.btnewtie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btnewtie.ImeMode")));
			this.btnewtie.Location = ((System.Drawing.Point)(resources.GetObject("btnewtie.Location")));
			this.btnewtie.Name = "btnewtie";
			this.btnewtie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btnewtie.RightToLeft")));
			this.btnewtie.Size = ((System.Drawing.Size)(resources.GetObject("btnewtie.Size")));
			this.btnewtie.TabIndex = ((int)(resources.GetObject("btnewtie.TabIndex")));
			this.btnewtie.Text = resources.GetString("btnewtie.Text");
			this.btnewtie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btnewtie.TextAlign")));
			this.toolTip1.SetToolTip(this.btnewtie, resources.GetString("btnewtie.ToolTip"));
			this.btnewtie.Visible = ((bool)(resources.GetObject("btnewtie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btnewtie, true);
			this.btnewtie.Click += new System.EventHandler(this.AddSimToTiesClick);
			// 
			// cballtieablesims
			// 
			this.cballtieablesims.AccessibleDescription = resources.GetString("cballtieablesims.AccessibleDescription");
			this.cballtieablesims.AccessibleName = resources.GetString("cballtieablesims.AccessibleName");
			this.cballtieablesims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cballtieablesims.Anchor")));
			this.cballtieablesims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cballtieablesims.BackgroundImage")));
			this.cballtieablesims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cballtieablesims.Dock")));
			this.cballtieablesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cballtieablesims.Enabled = ((bool)(resources.GetObject("cballtieablesims.Enabled")));
			this.cballtieablesims.Font = ((System.Drawing.Font)(resources.GetObject("cballtieablesims.Font")));
			this.cballtieablesims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cballtieablesims.ImeMode")));
			this.cballtieablesims.IntegralHeight = ((bool)(resources.GetObject("cballtieablesims.IntegralHeight")));
			this.cballtieablesims.ItemHeight = ((int)(resources.GetObject("cballtieablesims.ItemHeight")));
			this.cballtieablesims.Location = ((System.Drawing.Point)(resources.GetObject("cballtieablesims.Location")));
			this.cballtieablesims.MaxDropDownItems = ((int)(resources.GetObject("cballtieablesims.MaxDropDownItems")));
			this.cballtieablesims.MaxLength = ((int)(resources.GetObject("cballtieablesims.MaxLength")));
			this.cballtieablesims.Name = "cballtieablesims";
			this.cballtieablesims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cballtieablesims.RightToLeft")));
			this.cballtieablesims.Size = ((System.Drawing.Size)(resources.GetObject("cballtieablesims.Size")));
			this.cballtieablesims.TabIndex = ((int)(resources.GetObject("cballtieablesims.TabIndex")));
			this.cballtieablesims.Text = resources.GetString("cballtieablesims.Text");
			this.toolTip1.SetToolTip(this.cballtieablesims, resources.GetString("cballtieablesims.ToolTip"));
			this.cballtieablesims.Visible = ((bool)(resources.GetObject("cballtieablesims.Visible")));
			this.cballtieablesims.SelectedIndexChanged += new System.EventHandler(this.AllTieableSimsIndexChanged);
			// 
			// cbtietype
			// 
			this.cbtietype.AccessibleDescription = resources.GetString("cbtietype.AccessibleDescription");
			this.cbtietype.AccessibleName = resources.GetString("cbtietype.AccessibleName");
			this.cbtietype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtietype.Anchor")));
			this.cbtietype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtietype.BackgroundImage")));
			this.cbtietype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtietype.Dock")));
			this.cbtietype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtietype.Enabled = ((bool)(resources.GetObject("cbtietype.Enabled")));
			this.cbtietype.Font = ((System.Drawing.Font)(resources.GetObject("cbtietype.Font")));
			this.cbtietype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtietype.ImeMode")));
			this.cbtietype.IntegralHeight = ((bool)(resources.GetObject("cbtietype.IntegralHeight")));
			this.cbtietype.ItemHeight = ((int)(resources.GetObject("cbtietype.ItemHeight")));
			this.cbtietype.Location = ((System.Drawing.Point)(resources.GetObject("cbtietype.Location")));
			this.cbtietype.MaxDropDownItems = ((int)(resources.GetObject("cbtietype.MaxDropDownItems")));
			this.cbtietype.MaxLength = ((int)(resources.GetObject("cbtietype.MaxLength")));
			this.cbtietype.Name = "cbtietype";
			this.cbtietype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtietype.RightToLeft")));
			this.cbtietype.Size = ((System.Drawing.Size)(resources.GetObject("cbtietype.Size")));
			this.cbtietype.TabIndex = ((int)(resources.GetObject("cbtietype.TabIndex")));
			this.cbtietype.Text = resources.GetString("cbtietype.Text");
			this.toolTip1.SetToolTip(this.cbtietype, resources.GetString("cbtietype.ToolTip"));
			this.cbtietype.Visible = ((bool)(resources.GetObject("cbtietype.Visible")));
			// 
			// lbties
			// 
			this.lbties.AccessibleDescription = resources.GetString("lbties.AccessibleDescription");
			this.lbties.AccessibleName = resources.GetString("lbties.AccessibleName");
			this.lbties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbties.Anchor")));
			this.lbties.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbties.BackgroundImage")));
			this.lbties.ColumnWidth = ((int)(resources.GetObject("lbties.ColumnWidth")));
			this.lbties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbties.Dock")));
			this.lbties.Enabled = ((bool)(resources.GetObject("lbties.Enabled")));
			this.lbties.Font = ((System.Drawing.Font)(resources.GetObject("lbties.Font")));
			this.lbties.HorizontalExtent = ((int)(resources.GetObject("lbties.HorizontalExtent")));
			this.lbties.HorizontalScrollbar = ((bool)(resources.GetObject("lbties.HorizontalScrollbar")));
			this.lbties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbties.ImeMode")));
			this.lbties.IntegralHeight = ((bool)(resources.GetObject("lbties.IntegralHeight")));
			this.lbties.ItemHeight = ((int)(resources.GetObject("lbties.ItemHeight")));
			this.lbties.Location = ((System.Drawing.Point)(resources.GetObject("lbties.Location")));
			this.lbties.Name = "lbties";
			this.lbties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbties.RightToLeft")));
			this.lbties.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbties.ScrollAlwaysVisible")));
			this.lbties.Size = ((System.Drawing.Size)(resources.GetObject("lbties.Size")));
			this.lbties.TabIndex = ((int)(resources.GetObject("lbties.TabIndex")));
			this.toolTip1.SetToolTip(this.lbties, resources.GetString("lbties.ToolTip"));
			this.lbties.Visible = ((bool)(resources.GetObject("lbties.Visible")));
			this.lbties.SelectedIndexChanged += new System.EventHandler(this.TieIndexChanged);
			// 
			// btdeletetie
			// 
			this.btdeletetie.AccessibleDescription = resources.GetString("btdeletetie.AccessibleDescription");
			this.btdeletetie.AccessibleName = resources.GetString("btdeletetie.AccessibleName");
			this.btdeletetie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btdeletetie.Anchor")));
			this.btdeletetie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdeletetie.BackgroundImage")));
			this.btdeletetie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btdeletetie.Dock")));
			this.btdeletetie.Enabled = ((bool)(resources.GetObject("btdeletetie.Enabled")));
			this.btdeletetie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btdeletetie.FlatStyle")));
			this.btdeletetie.Font = ((System.Drawing.Font)(resources.GetObject("btdeletetie.Font")));
			this.btdeletetie.Image = ((System.Drawing.Image)(resources.GetObject("btdeletetie.Image")));
			this.btdeletetie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeletetie.ImageAlign")));
			this.btdeletetie.ImageIndex = ((int)(resources.GetObject("btdeletetie.ImageIndex")));
			this.btdeletetie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btdeletetie.ImeMode")));
			this.btdeletetie.Location = ((System.Drawing.Point)(resources.GetObject("btdeletetie.Location")));
			this.btdeletetie.Name = "btdeletetie";
			this.btdeletetie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btdeletetie.RightToLeft")));
			this.btdeletetie.Size = ((System.Drawing.Size)(resources.GetObject("btdeletetie.Size")));
			this.btdeletetie.TabIndex = ((int)(resources.GetObject("btdeletetie.TabIndex")));
			this.btdeletetie.Text = resources.GetString("btdeletetie.Text");
			this.btdeletetie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeletetie.TextAlign")));
			this.toolTip1.SetToolTip(this.btdeletetie, resources.GetString("btdeletetie.ToolTip"));
			this.btdeletetie.Visible = ((bool)(resources.GetObject("btdeletetie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btdeletetie, true);
			this.btdeletetie.Click += new System.EventHandler(this.DeleteTieClick);
			// 
			// btaddtie
			// 
			this.btaddtie.AccessibleDescription = resources.GetString("btaddtie.AccessibleDescription");
			this.btaddtie.AccessibleName = resources.GetString("btaddtie.AccessibleName");
			this.btaddtie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btaddtie.Anchor")));
			this.btaddtie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btaddtie.BackgroundImage")));
			this.btaddtie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btaddtie.Dock")));
			this.btaddtie.Enabled = ((bool)(resources.GetObject("btaddtie.Enabled")));
			this.btaddtie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btaddtie.FlatStyle")));
			this.btaddtie.Font = ((System.Drawing.Font)(resources.GetObject("btaddtie.Font")));
			this.btaddtie.Image = ((System.Drawing.Image)(resources.GetObject("btaddtie.Image")));
			this.btaddtie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddtie.ImageAlign")));
			this.btaddtie.ImageIndex = ((int)(resources.GetObject("btaddtie.ImageIndex")));
			this.btaddtie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btaddtie.ImeMode")));
			this.btaddtie.Location = ((System.Drawing.Point)(resources.GetObject("btaddtie.Location")));
			this.btaddtie.Name = "btaddtie";
			this.btaddtie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btaddtie.RightToLeft")));
			this.btaddtie.Size = ((System.Drawing.Size)(resources.GetObject("btaddtie.Size")));
			this.btaddtie.TabIndex = ((int)(resources.GetObject("btaddtie.TabIndex")));
			this.btaddtie.Text = resources.GetString("btaddtie.Text");
			this.btaddtie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddtie.TextAlign")));
			this.toolTip1.SetToolTip(this.btaddtie, resources.GetString("btaddtie.ToolTip"));
			this.btaddtie.Visible = ((bool)(resources.GetObject("btaddtie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btaddtie, true);
			this.btaddtie.Click += new System.EventHandler(this.AddTieClick);
			// 
			// llcommitties
			// 
			this.llcommitties.AccessibleDescription = resources.GetString("llcommitties.AccessibleDescription");
			this.llcommitties.AccessibleName = resources.GetString("llcommitties.AccessibleName");
			this.llcommitties.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcommitties.Anchor")));
			this.llcommitties.AutoSize = ((bool)(resources.GetObject("llcommitties.AutoSize")));
			this.llcommitties.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcommitties.Dock")));
			this.llcommitties.Enabled = ((bool)(resources.GetObject("llcommitties.Enabled")));
			this.llcommitties.Font = ((System.Drawing.Font)(resources.GetObject("llcommitties.Font")));
			this.llcommitties.Image = ((System.Drawing.Image)(resources.GetObject("llcommitties.Image")));
			this.llcommitties.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitties.ImageAlign")));
			this.llcommitties.ImageIndex = ((int)(resources.GetObject("llcommitties.ImageIndex")));
			this.llcommitties.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcommitties.ImeMode")));
			this.llcommitties.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcommitties.LinkArea")));
			this.llcommitties.Location = ((System.Drawing.Point)(resources.GetObject("llcommitties.Location")));
			this.llcommitties.Name = "llcommitties";
			this.llcommitties.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcommitties.RightToLeft")));
			this.llcommitties.Size = ((System.Drawing.Size)(resources.GetObject("llcommitties.Size")));
			this.llcommitties.TabIndex = ((int)(resources.GetObject("llcommitties.TabIndex")));
			this.llcommitties.TabStop = true;
			this.llcommitties.Text = resources.GetString("llcommitties.Text");
			this.llcommitties.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcommitties.TextAlign")));
			this.toolTip1.SetToolTip(this.llcommitties, resources.GetString("llcommitties.ToolTip"));
			this.llcommitties.Visible = ((bool)(resources.GetObject("llcommitties.Visible")));
			this.llcommitties.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CommitSimTieClicked);
			// 
			// cbtiesims
			// 
			this.cbtiesims.AccessibleDescription = resources.GetString("cbtiesims.AccessibleDescription");
			this.cbtiesims.AccessibleName = resources.GetString("cbtiesims.AccessibleName");
			this.cbtiesims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbtiesims.Anchor")));
			this.cbtiesims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbtiesims.BackgroundImage")));
			this.cbtiesims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbtiesims.Dock")));
			this.cbtiesims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbtiesims.Enabled = ((bool)(resources.GetObject("cbtiesims.Enabled")));
			this.cbtiesims.Font = ((System.Drawing.Font)(resources.GetObject("cbtiesims.Font")));
			this.cbtiesims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbtiesims.ImeMode")));
			this.cbtiesims.IntegralHeight = ((bool)(resources.GetObject("cbtiesims.IntegralHeight")));
			this.cbtiesims.ItemHeight = ((int)(resources.GetObject("cbtiesims.ItemHeight")));
			this.cbtiesims.Location = ((System.Drawing.Point)(resources.GetObject("cbtiesims.Location")));
			this.cbtiesims.MaxDropDownItems = ((int)(resources.GetObject("cbtiesims.MaxDropDownItems")));
			this.cbtiesims.MaxLength = ((int)(resources.GetObject("cbtiesims.MaxLength")));
			this.cbtiesims.Name = "cbtiesims";
			this.cbtiesims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbtiesims.RightToLeft")));
			this.cbtiesims.Size = ((System.Drawing.Size)(resources.GetObject("cbtiesims.Size")));
			this.cbtiesims.TabIndex = ((int)(resources.GetObject("cbtiesims.TabIndex")));
			this.cbtiesims.Text = resources.GetString("cbtiesims.Text");
			this.toolTip1.SetToolTip(this.cbtiesims, resources.GetString("cbtiesims.ToolTip"));
			this.cbtiesims.Visible = ((bool)(resources.GetObject("cbtiesims.Visible")));
			this.cbtiesims.SelectedIndexChanged += new System.EventHandler(this.FamilyTieSimIndexChanged);
			// 
			// bttiecommit
			// 
			this.bttiecommit.AccessibleDescription = resources.GetString("bttiecommit.AccessibleDescription");
			this.bttiecommit.AccessibleName = resources.GetString("bttiecommit.AccessibleName");
			this.bttiecommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("bttiecommit.Anchor")));
			this.bttiecommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttiecommit.BackgroundImage")));
			this.bttiecommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("bttiecommit.Dock")));
			this.bttiecommit.Enabled = ((bool)(resources.GetObject("bttiecommit.Enabled")));
			this.bttiecommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("bttiecommit.FlatStyle")));
			this.bttiecommit.Font = ((System.Drawing.Font)(resources.GetObject("bttiecommit.Font")));
			this.bttiecommit.Image = ((System.Drawing.Image)(resources.GetObject("bttiecommit.Image")));
			this.bttiecommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("bttiecommit.ImageAlign")));
			this.bttiecommit.ImageIndex = ((int)(resources.GetObject("bttiecommit.ImageIndex")));
			this.bttiecommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("bttiecommit.ImeMode")));
			this.bttiecommit.Location = ((System.Drawing.Point)(resources.GetObject("bttiecommit.Location")));
			this.bttiecommit.Name = "bttiecommit";
			this.bttiecommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("bttiecommit.RightToLeft")));
			this.bttiecommit.Size = ((System.Drawing.Size)(resources.GetObject("bttiecommit.Size")));
			this.bttiecommit.TabIndex = ((int)(resources.GetObject("bttiecommit.TabIndex")));
			this.bttiecommit.Text = resources.GetString("bttiecommit.Text");
			this.bttiecommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("bttiecommit.TextAlign")));
			this.toolTip1.SetToolTip(this.bttiecommit, resources.GetString("bttiecommit.ToolTip"));
			this.bttiecommit.Visible = ((bool)(resources.GetObject("bttiecommit.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.bttiecommit, true);
			this.bttiecommit.Click += new System.EventHandler(this.CommitTieClick);
			// 
			// label64
			// 
			this.label64.AccessibleDescription = resources.GetString("label64.AccessibleDescription");
			this.label64.AccessibleName = resources.GetString("label64.AccessibleName");
			this.label64.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label64.Anchor")));
			this.label64.AutoSize = ((bool)(resources.GetObject("label64.AutoSize")));
			this.label64.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label64.Dock")));
			this.label64.Enabled = ((bool)(resources.GetObject("label64.Enabled")));
			this.label64.Font = ((System.Drawing.Font)(resources.GetObject("label64.Font")));
			this.label64.Image = ((System.Drawing.Image)(resources.GetObject("label64.Image")));
			this.label64.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label64.ImageAlign")));
			this.label64.ImageIndex = ((int)(resources.GetObject("label64.ImageIndex")));
			this.label64.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label64.ImeMode")));
			this.label64.Location = ((System.Drawing.Point)(resources.GetObject("label64.Location")));
			this.label64.Name = "label64";
			this.label64.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label64.RightToLeft")));
			this.label64.Size = ((System.Drawing.Size)(resources.GetObject("label64.Size")));
			this.label64.TabIndex = ((int)(resources.GetObject("label64.TabIndex")));
			this.label64.Text = resources.GetString("label64.Text");
			this.label64.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label64.TextAlign")));
			this.toolTip1.SetToolTip(this.label64, resources.GetString("label64.ToolTip"));
			this.label64.Visible = ((bool)(resources.GetObject("label64.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label64, true);
			// 
			// panel8
			// 
			this.panel8.AccessibleDescription = resources.GetString("panel8.AccessibleDescription");
			this.panel8.AccessibleName = resources.GetString("panel8.AccessibleName");
			this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel8.Anchor")));
			this.panel8.AutoScroll = ((bool)(resources.GetObject("panel8.AutoScroll")));
			this.panel8.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel8.AutoScrollMargin")));
			this.panel8.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel8.AutoScrollMinSize")));
			this.panel8.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
			this.panel8.Controls.Add(this.label68);
			this.panel8.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel8.Dock")));
			this.panel8.Enabled = ((bool)(resources.GetObject("panel8.Enabled")));
			this.panel8.Font = ((System.Drawing.Font)(resources.GetObject("panel8.Font")));
			this.panel8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel8.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel8.ImeMode")));
			this.panel8.Location = ((System.Drawing.Point)(resources.GetObject("panel8.Location")));
			this.panel8.Name = "panel8";
			this.panel8.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel8.RightToLeft")));
			this.panel8.Size = ((System.Drawing.Size)(resources.GetObject("panel8.Size")));
			this.panel8.TabIndex = ((int)(resources.GetObject("panel8.TabIndex")));
			this.panel8.Text = resources.GetString("panel8.Text");
			this.toolTip1.SetToolTip(this.panel8, resources.GetString("panel8.ToolTip"));
			this.panel8.Visible = ((bool)(resources.GetObject("panel8.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel8, true);
			// 
			// label68
			// 
			this.label68.AccessibleDescription = resources.GetString("label68.AccessibleDescription");
			this.label68.AccessibleName = resources.GetString("label68.AccessibleName");
			this.label68.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label68.Anchor")));
			this.label68.AutoSize = ((bool)(resources.GetObject("label68.AutoSize")));
			this.label68.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label68.Dock")));
			this.label68.Enabled = ((bool)(resources.GetObject("label68.Enabled")));
			this.label68.Font = ((System.Drawing.Font)(resources.GetObject("label68.Font")));
			this.label68.Image = ((System.Drawing.Image)(resources.GetObject("label68.Image")));
			this.label68.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label68.ImageAlign")));
			this.label68.ImageIndex = ((int)(resources.GetObject("label68.ImageIndex")));
			this.label68.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label68.ImeMode")));
			this.label68.Location = ((System.Drawing.Point)(resources.GetObject("label68.Location")));
			this.label68.Name = "label68";
			this.label68.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label68.RightToLeft")));
			this.label68.Size = ((System.Drawing.Size)(resources.GetObject("label68.Size")));
			this.label68.TabIndex = ((int)(resources.GetObject("label68.TabIndex")));
			this.label68.Text = resources.GetString("label68.Text");
			this.label68.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label68.TextAlign")));
			this.toolTip1.SetToolTip(this.label68, resources.GetString("label68.ToolTip"));
			this.label68.Visible = ((bool)(resources.GetObject("label68.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label68, true);
			// 
			// tabPage1
			// 
			this.tabPage1.AccessibleDescription = resources.GetString("tabPage1.AccessibleDescription");
			this.tabPage1.AccessibleName = resources.GetString("tabPage1.AccessibleName");
			this.tabPage1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage1.Anchor")));
			this.tabPage1.AutoScroll = ((bool)(resources.GetObject("tabPage1.AutoScroll")));
			this.tabPage1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMargin")));
			this.tabPage1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage1.AutoScrollMinSize")));
			this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
			this.tabPage1.Controls.Add(this.famiPanel);
			this.tabPage1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage1.Dock")));
			this.tabPage1.Enabled = ((bool)(resources.GetObject("tabPage1.Enabled")));
			this.tabPage1.Font = ((System.Drawing.Font)(resources.GetObject("tabPage1.Font")));
			this.tabPage1.ImageIndex = ((int)(resources.GetObject("tabPage1.ImageIndex")));
			this.tabPage1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage1.ImeMode")));
			this.tabPage1.Location = ((System.Drawing.Point)(resources.GetObject("tabPage1.Location")));
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage1.RightToLeft")));
			this.tabPage1.Size = ((System.Drawing.Size)(resources.GetObject("tabPage1.Size")));
			this.tabPage1.TabIndex = ((int)(resources.GetObject("tabPage1.TabIndex")));
			this.tabPage1.Text = resources.GetString("tabPage1.Text");
			this.toolTip1.SetToolTip(this.tabPage1, resources.GetString("tabPage1.ToolTip"));
			this.tabPage1.ToolTipText = resources.GetString("tabPage1.ToolTipText");
			this.tabPage1.Visible = ((bool)(resources.GetObject("tabPage1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage1, true);
			// 
			// famiPanel
			// 
			this.famiPanel.AccessibleDescription = resources.GetString("famiPanel.AccessibleDescription");
			this.famiPanel.AccessibleName = resources.GetString("famiPanel.AccessibleName");
			this.famiPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("famiPanel.Anchor")));
			this.famiPanel.AutoScroll = ((bool)(resources.GetObject("famiPanel.AutoScroll")));
			this.famiPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("famiPanel.AutoScrollMargin")));
			this.famiPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("famiPanel.AutoScrollMinSize")));
			this.famiPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("famiPanel.BackgroundImage")));
			this.famiPanel.Controls.Add(this.tbsubhood);
			this.famiPanel.Controls.Add(this.label89);
			this.famiPanel.Controls.Add(this.groupBox4);
			this.famiPanel.Controls.Add(this.tbalbum);
			this.famiPanel.Controls.Add(this.label93);
			this.famiPanel.Controls.Add(this.tbflag);
			this.famiPanel.Controls.Add(this.label92);
			this.famiPanel.Controls.Add(this.tblotinst);
			this.famiPanel.Controls.Add(this.llFamiDeleteSim);
			this.famiPanel.Controls.Add(this.llFamiAddSim);
			this.famiPanel.Controls.Add(this.button1);
			this.famiPanel.Controls.Add(this.cbsims);
			this.famiPanel.Controls.Add(this.lbmembers);
			this.famiPanel.Controls.Add(this.tbname);
			this.famiPanel.Controls.Add(this.label6);
			this.famiPanel.Controls.Add(this.tbfamily);
			this.famiPanel.Controls.Add(this.tbmoney);
			this.famiPanel.Controls.Add(this.label5);
			this.famiPanel.Controls.Add(this.label4);
			this.famiPanel.Controls.Add(this.label3);
			this.famiPanel.Controls.Add(this.panel4);
			this.famiPanel.Controls.Add(this.label15);
			this.famiPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("famiPanel.Dock")));
			this.famiPanel.Enabled = ((bool)(resources.GetObject("famiPanel.Enabled")));
			this.famiPanel.Font = ((System.Drawing.Font)(resources.GetObject("famiPanel.Font")));
			this.famiPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("famiPanel.ImeMode")));
			this.famiPanel.Location = ((System.Drawing.Point)(resources.GetObject("famiPanel.Location")));
			this.famiPanel.Name = "famiPanel";
			this.famiPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("famiPanel.RightToLeft")));
			this.famiPanel.Size = ((System.Drawing.Size)(resources.GetObject("famiPanel.Size")));
			this.famiPanel.TabIndex = ((int)(resources.GetObject("famiPanel.TabIndex")));
			this.famiPanel.Text = resources.GetString("famiPanel.Text");
			this.toolTip1.SetToolTip(this.famiPanel, resources.GetString("famiPanel.ToolTip"));
			this.famiPanel.Visible = ((bool)(resources.GetObject("famiPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.famiPanel, true);
			// 
			// tbsubhood
			// 
			this.tbsubhood.AccessibleDescription = resources.GetString("tbsubhood.AccessibleDescription");
			this.tbsubhood.AccessibleName = resources.GetString("tbsubhood.AccessibleName");
			this.tbsubhood.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsubhood.Anchor")));
			this.tbsubhood.AutoSize = ((bool)(resources.GetObject("tbsubhood.AutoSize")));
			this.tbsubhood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsubhood.BackgroundImage")));
			this.tbsubhood.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsubhood.Dock")));
			this.tbsubhood.Enabled = ((bool)(resources.GetObject("tbsubhood.Enabled")));
			this.tbsubhood.Font = ((System.Drawing.Font)(resources.GetObject("tbsubhood.Font")));
			this.tbsubhood.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsubhood.ImeMode")));
			this.tbsubhood.Location = ((System.Drawing.Point)(resources.GetObject("tbsubhood.Location")));
			this.tbsubhood.MaxLength = ((int)(resources.GetObject("tbsubhood.MaxLength")));
			this.tbsubhood.Multiline = ((bool)(resources.GetObject("tbsubhood.Multiline")));
			this.tbsubhood.Name = "tbsubhood";
			this.tbsubhood.PasswordChar = ((char)(resources.GetObject("tbsubhood.PasswordChar")));
			this.tbsubhood.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsubhood.RightToLeft")));
			this.tbsubhood.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsubhood.ScrollBars")));
			this.tbsubhood.Size = ((System.Drawing.Size)(resources.GetObject("tbsubhood.Size")));
			this.tbsubhood.TabIndex = ((int)(resources.GetObject("tbsubhood.TabIndex")));
			this.tbsubhood.Text = resources.GetString("tbsubhood.Text");
			this.tbsubhood.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsubhood.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsubhood, resources.GetString("tbsubhood.ToolTip"));
			this.tbsubhood.Visible = ((bool)(resources.GetObject("tbsubhood.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsubhood, true);
			this.tbsubhood.WordWrap = ((bool)(resources.GetObject("tbsubhood.WordWrap")));
			// 
			// label89
			// 
			this.label89.AccessibleDescription = resources.GetString("label89.AccessibleDescription");
			this.label89.AccessibleName = resources.GetString("label89.AccessibleName");
			this.label89.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label89.Anchor")));
			this.label89.AutoSize = ((bool)(resources.GetObject("label89.AutoSize")));
			this.label89.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label89.Dock")));
			this.label89.Enabled = ((bool)(resources.GetObject("label89.Enabled")));
			this.label89.Font = ((System.Drawing.Font)(resources.GetObject("label89.Font")));
			this.label89.Image = ((System.Drawing.Image)(resources.GetObject("label89.Image")));
			this.label89.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label89.ImageAlign")));
			this.label89.ImageIndex = ((int)(resources.GetObject("label89.ImageIndex")));
			this.label89.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label89.ImeMode")));
			this.label89.Location = ((System.Drawing.Point)(resources.GetObject("label89.Location")));
			this.label89.Name = "label89";
			this.label89.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label89.RightToLeft")));
			this.label89.Size = ((System.Drawing.Size)(resources.GetObject("label89.Size")));
			this.label89.TabIndex = ((int)(resources.GetObject("label89.TabIndex")));
			this.label89.Text = resources.GetString("label89.Text");
			this.label89.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label89.TextAlign")));
			this.toolTip1.SetToolTip(this.label89, resources.GetString("label89.ToolTip"));
			this.label89.Visible = ((bool)(resources.GetObject("label89.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label89, true);
			// 
			// groupBox4
			// 
			this.groupBox4.AccessibleDescription = resources.GetString("groupBox4.AccessibleDescription");
			this.groupBox4.AccessibleName = resources.GetString("groupBox4.AccessibleName");
			this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox4.Anchor")));
			this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
			this.groupBox4.Controls.Add(this.cbcomputer);
			this.groupBox4.Controls.Add(this.cblot);
			this.groupBox4.Controls.Add(this.cbbaby);
			this.groupBox4.Controls.Add(this.cbphone);
			this.groupBox4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox4.Dock")));
			this.groupBox4.Enabled = ((bool)(resources.GetObject("groupBox4.Enabled")));
			this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox4.Font = ((System.Drawing.Font)(resources.GetObject("groupBox4.Font")));
			this.groupBox4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox4.ImeMode")));
			this.groupBox4.Location = ((System.Drawing.Point)(resources.GetObject("groupBox4.Location")));
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox4.RightToLeft")));
			this.groupBox4.Size = ((System.Drawing.Size)(resources.GetObject("groupBox4.Size")));
			this.groupBox4.TabIndex = ((int)(resources.GetObject("groupBox4.TabIndex")));
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = resources.GetString("groupBox4.Text");
			this.toolTip1.SetToolTip(this.groupBox4, resources.GetString("groupBox4.ToolTip"));
			this.groupBox4.Visible = ((bool)(resources.GetObject("groupBox4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox4, true);
			// 
			// cbcomputer
			// 
			this.cbcomputer.AccessibleDescription = resources.GetString("cbcomputer.AccessibleDescription");
			this.cbcomputer.AccessibleName = resources.GetString("cbcomputer.AccessibleName");
			this.cbcomputer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcomputer.Anchor")));
			this.cbcomputer.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcomputer.Appearance")));
			this.cbcomputer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcomputer.BackgroundImage")));
			this.cbcomputer.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.CheckAlign")));
			this.cbcomputer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcomputer.Dock")));
			this.cbcomputer.Enabled = ((bool)(resources.GetObject("cbcomputer.Enabled")));
			this.cbcomputer.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcomputer.FlatStyle")));
			this.cbcomputer.Font = ((System.Drawing.Font)(resources.GetObject("cbcomputer.Font")));
			this.cbcomputer.Image = ((System.Drawing.Image)(resources.GetObject("cbcomputer.Image")));
			this.cbcomputer.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.ImageAlign")));
			this.cbcomputer.ImageIndex = ((int)(resources.GetObject("cbcomputer.ImageIndex")));
			this.cbcomputer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcomputer.ImeMode")));
			this.cbcomputer.Location = ((System.Drawing.Point)(resources.GetObject("cbcomputer.Location")));
			this.cbcomputer.Name = "cbcomputer";
			this.cbcomputer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcomputer.RightToLeft")));
			this.cbcomputer.Size = ((System.Drawing.Size)(resources.GetObject("cbcomputer.Size")));
			this.cbcomputer.TabIndex = ((int)(resources.GetObject("cbcomputer.TabIndex")));
			this.cbcomputer.Text = resources.GetString("cbcomputer.Text");
			this.cbcomputer.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcomputer.TextAlign")));
			this.toolTip1.SetToolTip(this.cbcomputer, resources.GetString("cbcomputer.ToolTip"));
			this.cbcomputer.Visible = ((bool)(resources.GetObject("cbcomputer.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbcomputer, true);
			this.cbcomputer.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cblot
			// 
			this.cblot.AccessibleDescription = resources.GetString("cblot.AccessibleDescription");
			this.cblot.AccessibleName = resources.GetString("cblot.AccessibleName");
			this.cblot.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblot.Anchor")));
			this.cblot.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cblot.Appearance")));
			this.cblot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblot.BackgroundImage")));
			this.cblot.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.CheckAlign")));
			this.cblot.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblot.Dock")));
			this.cblot.Enabled = ((bool)(resources.GetObject("cblot.Enabled")));
			this.cblot.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cblot.FlatStyle")));
			this.cblot.Font = ((System.Drawing.Font)(resources.GetObject("cblot.Font")));
			this.cblot.Image = ((System.Drawing.Image)(resources.GetObject("cblot.Image")));
			this.cblot.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.ImageAlign")));
			this.cblot.ImageIndex = ((int)(resources.GetObject("cblot.ImageIndex")));
			this.cblot.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblot.ImeMode")));
			this.cblot.Location = ((System.Drawing.Point)(resources.GetObject("cblot.Location")));
			this.cblot.Name = "cblot";
			this.cblot.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblot.RightToLeft")));
			this.cblot.Size = ((System.Drawing.Size)(resources.GetObject("cblot.Size")));
			this.cblot.TabIndex = ((int)(resources.GetObject("cblot.TabIndex")));
			this.cblot.Text = resources.GetString("cblot.Text");
			this.cblot.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblot.TextAlign")));
			this.toolTip1.SetToolTip(this.cblot, resources.GetString("cblot.ToolTip"));
			this.cblot.Visible = ((bool)(resources.GetObject("cblot.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cblot, true);
			this.cblot.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cbbaby
			// 
			this.cbbaby.AccessibleDescription = resources.GetString("cbbaby.AccessibleDescription");
			this.cbbaby.AccessibleName = resources.GetString("cbbaby.AccessibleName");
			this.cbbaby.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbaby.Anchor")));
			this.cbbaby.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbaby.Appearance")));
			this.cbbaby.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbaby.BackgroundImage")));
			this.cbbaby.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.CheckAlign")));
			this.cbbaby.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbaby.Dock")));
			this.cbbaby.Enabled = ((bool)(resources.GetObject("cbbaby.Enabled")));
			this.cbbaby.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbaby.FlatStyle")));
			this.cbbaby.Font = ((System.Drawing.Font)(resources.GetObject("cbbaby.Font")));
			this.cbbaby.Image = ((System.Drawing.Image)(resources.GetObject("cbbaby.Image")));
			this.cbbaby.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.ImageAlign")));
			this.cbbaby.ImageIndex = ((int)(resources.GetObject("cbbaby.ImageIndex")));
			this.cbbaby.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbaby.ImeMode")));
			this.cbbaby.Location = ((System.Drawing.Point)(resources.GetObject("cbbaby.Location")));
			this.cbbaby.Name = "cbbaby";
			this.cbbaby.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbaby.RightToLeft")));
			this.cbbaby.Size = ((System.Drawing.Size)(resources.GetObject("cbbaby.Size")));
			this.cbbaby.TabIndex = ((int)(resources.GetObject("cbbaby.TabIndex")));
			this.cbbaby.Text = resources.GetString("cbbaby.Text");
			this.cbbaby.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbaby.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbaby, resources.GetString("cbbaby.ToolTip"));
			this.cbbaby.Visible = ((bool)(resources.GetObject("cbbaby.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbaby, true);
			this.cbbaby.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// cbphone
			// 
			this.cbphone.AccessibleDescription = resources.GetString("cbphone.AccessibleDescription");
			this.cbphone.AccessibleName = resources.GetString("cbphone.AccessibleName");
			this.cbphone.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbphone.Anchor")));
			this.cbphone.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbphone.Appearance")));
			this.cbphone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbphone.BackgroundImage")));
			this.cbphone.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.CheckAlign")));
			this.cbphone.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbphone.Dock")));
			this.cbphone.Enabled = ((bool)(resources.GetObject("cbphone.Enabled")));
			this.cbphone.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbphone.FlatStyle")));
			this.cbphone.Font = ((System.Drawing.Font)(resources.GetObject("cbphone.Font")));
			this.cbphone.Image = ((System.Drawing.Image)(resources.GetObject("cbphone.Image")));
			this.cbphone.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.ImageAlign")));
			this.cbphone.ImageIndex = ((int)(resources.GetObject("cbphone.ImageIndex")));
			this.cbphone.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbphone.ImeMode")));
			this.cbphone.Location = ((System.Drawing.Point)(resources.GetObject("cbphone.Location")));
			this.cbphone.Name = "cbphone";
			this.cbphone.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbphone.RightToLeft")));
			this.cbphone.Size = ((System.Drawing.Size)(resources.GetObject("cbphone.Size")));
			this.cbphone.TabIndex = ((int)(resources.GetObject("cbphone.TabIndex")));
			this.cbphone.Text = resources.GetString("cbphone.Text");
			this.cbphone.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbphone.TextAlign")));
			this.toolTip1.SetToolTip(this.cbphone, resources.GetString("cbphone.ToolTip"));
			this.cbphone.Visible = ((bool)(resources.GetObject("cbphone.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbphone, true);
			this.cbphone.CheckedChanged += new System.EventHandler(this.ChangeFlags);
			// 
			// tbalbum
			// 
			this.tbalbum.AccessibleDescription = resources.GetString("tbalbum.AccessibleDescription");
			this.tbalbum.AccessibleName = resources.GetString("tbalbum.AccessibleName");
			this.tbalbum.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbalbum.Anchor")));
			this.tbalbum.AutoSize = ((bool)(resources.GetObject("tbalbum.AutoSize")));
			this.tbalbum.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbalbum.BackgroundImage")));
			this.tbalbum.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbalbum.Dock")));
			this.tbalbum.Enabled = ((bool)(resources.GetObject("tbalbum.Enabled")));
			this.tbalbum.Font = ((System.Drawing.Font)(resources.GetObject("tbalbum.Font")));
			this.tbalbum.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbalbum.ImeMode")));
			this.tbalbum.Location = ((System.Drawing.Point)(resources.GetObject("tbalbum.Location")));
			this.tbalbum.MaxLength = ((int)(resources.GetObject("tbalbum.MaxLength")));
			this.tbalbum.Multiline = ((bool)(resources.GetObject("tbalbum.Multiline")));
			this.tbalbum.Name = "tbalbum";
			this.tbalbum.PasswordChar = ((char)(resources.GetObject("tbalbum.PasswordChar")));
			this.tbalbum.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbalbum.RightToLeft")));
			this.tbalbum.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbalbum.ScrollBars")));
			this.tbalbum.Size = ((System.Drawing.Size)(resources.GetObject("tbalbum.Size")));
			this.tbalbum.TabIndex = ((int)(resources.GetObject("tbalbum.TabIndex")));
			this.tbalbum.Text = resources.GetString("tbalbum.Text");
			this.tbalbum.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbalbum.TextAlign")));
			this.toolTip1.SetToolTip(this.tbalbum, resources.GetString("tbalbum.ToolTip"));
			this.tbalbum.Visible = ((bool)(resources.GetObject("tbalbum.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbalbum, true);
			this.tbalbum.WordWrap = ((bool)(resources.GetObject("tbalbum.WordWrap")));
			// 
			// label93
			// 
			this.label93.AccessibleDescription = resources.GetString("label93.AccessibleDescription");
			this.label93.AccessibleName = resources.GetString("label93.AccessibleName");
			this.label93.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label93.Anchor")));
			this.label93.AutoSize = ((bool)(resources.GetObject("label93.AutoSize")));
			this.label93.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label93.Dock")));
			this.label93.Enabled = ((bool)(resources.GetObject("label93.Enabled")));
			this.label93.Font = ((System.Drawing.Font)(resources.GetObject("label93.Font")));
			this.label93.Image = ((System.Drawing.Image)(resources.GetObject("label93.Image")));
			this.label93.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label93.ImageAlign")));
			this.label93.ImageIndex = ((int)(resources.GetObject("label93.ImageIndex")));
			this.label93.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label93.ImeMode")));
			this.label93.Location = ((System.Drawing.Point)(resources.GetObject("label93.Location")));
			this.label93.Name = "label93";
			this.label93.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label93.RightToLeft")));
			this.label93.Size = ((System.Drawing.Size)(resources.GetObject("label93.Size")));
			this.label93.TabIndex = ((int)(resources.GetObject("label93.TabIndex")));
			this.label93.Text = resources.GetString("label93.Text");
			this.label93.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label93.TextAlign")));
			this.toolTip1.SetToolTip(this.label93, resources.GetString("label93.ToolTip"));
			this.label93.Visible = ((bool)(resources.GetObject("label93.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label93, true);
			// 
			// tbflag
			// 
			this.tbflag.AccessibleDescription = resources.GetString("tbflag.AccessibleDescription");
			this.tbflag.AccessibleName = resources.GetString("tbflag.AccessibleName");
			this.tbflag.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbflag.Anchor")));
			this.tbflag.AutoSize = ((bool)(resources.GetObject("tbflag.AutoSize")));
			this.tbflag.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbflag.BackgroundImage")));
			this.tbflag.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbflag.Dock")));
			this.tbflag.Enabled = ((bool)(resources.GetObject("tbflag.Enabled")));
			this.tbflag.Font = ((System.Drawing.Font)(resources.GetObject("tbflag.Font")));
			this.tbflag.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbflag.ImeMode")));
			this.tbflag.Location = ((System.Drawing.Point)(resources.GetObject("tbflag.Location")));
			this.tbflag.MaxLength = ((int)(resources.GetObject("tbflag.MaxLength")));
			this.tbflag.Multiline = ((bool)(resources.GetObject("tbflag.Multiline")));
			this.tbflag.Name = "tbflag";
			this.tbflag.PasswordChar = ((char)(resources.GetObject("tbflag.PasswordChar")));
			this.tbflag.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbflag.RightToLeft")));
			this.tbflag.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbflag.ScrollBars")));
			this.tbflag.Size = ((System.Drawing.Size)(resources.GetObject("tbflag.Size")));
			this.tbflag.TabIndex = ((int)(resources.GetObject("tbflag.TabIndex")));
			this.tbflag.Text = resources.GetString("tbflag.Text");
			this.tbflag.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbflag.TextAlign")));
			this.toolTip1.SetToolTip(this.tbflag, resources.GetString("tbflag.ToolTip"));
			this.tbflag.Visible = ((bool)(resources.GetObject("tbflag.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbflag, true);
			this.tbflag.WordWrap = ((bool)(resources.GetObject("tbflag.WordWrap")));
			this.tbflag.TextChanged += new System.EventHandler(this.FlagChanged);
			// 
			// label92
			// 
			this.label92.AccessibleDescription = resources.GetString("label92.AccessibleDescription");
			this.label92.AccessibleName = resources.GetString("label92.AccessibleName");
			this.label92.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label92.Anchor")));
			this.label92.AutoSize = ((bool)(resources.GetObject("label92.AutoSize")));
			this.label92.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label92.Dock")));
			this.label92.Enabled = ((bool)(resources.GetObject("label92.Enabled")));
			this.label92.Font = ((System.Drawing.Font)(resources.GetObject("label92.Font")));
			this.label92.Image = ((System.Drawing.Image)(resources.GetObject("label92.Image")));
			this.label92.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label92.ImageAlign")));
			this.label92.ImageIndex = ((int)(resources.GetObject("label92.ImageIndex")));
			this.label92.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label92.ImeMode")));
			this.label92.Location = ((System.Drawing.Point)(resources.GetObject("label92.Location")));
			this.label92.Name = "label92";
			this.label92.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label92.RightToLeft")));
			this.label92.Size = ((System.Drawing.Size)(resources.GetObject("label92.Size")));
			this.label92.TabIndex = ((int)(resources.GetObject("label92.TabIndex")));
			this.label92.Text = resources.GetString("label92.Text");
			this.label92.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label92.TextAlign")));
			this.toolTip1.SetToolTip(this.label92, resources.GetString("label92.ToolTip"));
			this.label92.Visible = ((bool)(resources.GetObject("label92.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label92, true);
			// 
			// tblotinst
			// 
			this.tblotinst.AccessibleDescription = resources.GetString("tblotinst.AccessibleDescription");
			this.tblotinst.AccessibleName = resources.GetString("tblotinst.AccessibleName");
			this.tblotinst.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblotinst.Anchor")));
			this.tblotinst.AutoSize = ((bool)(resources.GetObject("tblotinst.AutoSize")));
			this.tblotinst.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblotinst.BackgroundImage")));
			this.tblotinst.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblotinst.Dock")));
			this.tblotinst.Enabled = ((bool)(resources.GetObject("tblotinst.Enabled")));
			this.tblotinst.Font = ((System.Drawing.Font)(resources.GetObject("tblotinst.Font")));
			this.tblotinst.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblotinst.ImeMode")));
			this.tblotinst.Location = ((System.Drawing.Point)(resources.GetObject("tblotinst.Location")));
			this.tblotinst.MaxLength = ((int)(resources.GetObject("tblotinst.MaxLength")));
			this.tblotinst.Multiline = ((bool)(resources.GetObject("tblotinst.Multiline")));
			this.tblotinst.Name = "tblotinst";
			this.tblotinst.PasswordChar = ((char)(resources.GetObject("tblotinst.PasswordChar")));
			this.tblotinst.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblotinst.RightToLeft")));
			this.tblotinst.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblotinst.ScrollBars")));
			this.tblotinst.Size = ((System.Drawing.Size)(resources.GetObject("tblotinst.Size")));
			this.tblotinst.TabIndex = ((int)(resources.GetObject("tblotinst.TabIndex")));
			this.tblotinst.Text = resources.GetString("tblotinst.Text");
			this.tblotinst.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblotinst.TextAlign")));
			this.toolTip1.SetToolTip(this.tblotinst, resources.GetString("tblotinst.ToolTip"));
			this.tblotinst.Visible = ((bool)(resources.GetObject("tblotinst.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblotinst, true);
			this.tblotinst.WordWrap = ((bool)(resources.GetObject("tblotinst.WordWrap")));
			// 
			// llFamiDeleteSim
			// 
			this.llFamiDeleteSim.AccessibleDescription = resources.GetString("llFamiDeleteSim.AccessibleDescription");
			this.llFamiDeleteSim.AccessibleName = resources.GetString("llFamiDeleteSim.AccessibleName");
			this.llFamiDeleteSim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llFamiDeleteSim.Anchor")));
			this.llFamiDeleteSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("llFamiDeleteSim.BackgroundImage")));
			this.llFamiDeleteSim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llFamiDeleteSim.Dock")));
			this.llFamiDeleteSim.Enabled = ((bool)(resources.GetObject("llFamiDeleteSim.Enabled")));
			this.llFamiDeleteSim.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("llFamiDeleteSim.FlatStyle")));
			this.llFamiDeleteSim.Font = ((System.Drawing.Font)(resources.GetObject("llFamiDeleteSim.Font")));
			this.llFamiDeleteSim.Image = ((System.Drawing.Image)(resources.GetObject("llFamiDeleteSim.Image")));
			this.llFamiDeleteSim.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiDeleteSim.ImageAlign")));
			this.llFamiDeleteSim.ImageIndex = ((int)(resources.GetObject("llFamiDeleteSim.ImageIndex")));
			this.llFamiDeleteSim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llFamiDeleteSim.ImeMode")));
			this.llFamiDeleteSim.Location = ((System.Drawing.Point)(resources.GetObject("llFamiDeleteSim.Location")));
			this.llFamiDeleteSim.Name = "llFamiDeleteSim";
			this.llFamiDeleteSim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llFamiDeleteSim.RightToLeft")));
			this.llFamiDeleteSim.Size = ((System.Drawing.Size)(resources.GetObject("llFamiDeleteSim.Size")));
			this.llFamiDeleteSim.TabIndex = ((int)(resources.GetObject("llFamiDeleteSim.TabIndex")));
			this.llFamiDeleteSim.Text = resources.GetString("llFamiDeleteSim.Text");
			this.llFamiDeleteSim.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiDeleteSim.TextAlign")));
			this.toolTip1.SetToolTip(this.llFamiDeleteSim, resources.GetString("llFamiDeleteSim.ToolTip"));
			this.llFamiDeleteSim.Visible = ((bool)(resources.GetObject("llFamiDeleteSim.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.llFamiDeleteSim, true);
			this.llFamiDeleteSim.Click += new System.EventHandler(this.FamiDeleteSimClick);
			// 
			// llFamiAddSim
			// 
			this.llFamiAddSim.AccessibleDescription = resources.GetString("llFamiAddSim.AccessibleDescription");
			this.llFamiAddSim.AccessibleName = resources.GetString("llFamiAddSim.AccessibleName");
			this.llFamiAddSim.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llFamiAddSim.Anchor")));
			this.llFamiAddSim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("llFamiAddSim.BackgroundImage")));
			this.llFamiAddSim.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llFamiAddSim.Dock")));
			this.llFamiAddSim.Enabled = ((bool)(resources.GetObject("llFamiAddSim.Enabled")));
			this.llFamiAddSim.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("llFamiAddSim.FlatStyle")));
			this.llFamiAddSim.Font = ((System.Drawing.Font)(resources.GetObject("llFamiAddSim.Font")));
			this.llFamiAddSim.Image = ((System.Drawing.Image)(resources.GetObject("llFamiAddSim.Image")));
			this.llFamiAddSim.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiAddSim.ImageAlign")));
			this.llFamiAddSim.ImageIndex = ((int)(resources.GetObject("llFamiAddSim.ImageIndex")));
			this.llFamiAddSim.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llFamiAddSim.ImeMode")));
			this.llFamiAddSim.Location = ((System.Drawing.Point)(resources.GetObject("llFamiAddSim.Location")));
			this.llFamiAddSim.Name = "llFamiAddSim";
			this.llFamiAddSim.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llFamiAddSim.RightToLeft")));
			this.llFamiAddSim.Size = ((System.Drawing.Size)(resources.GetObject("llFamiAddSim.Size")));
			this.llFamiAddSim.TabIndex = ((int)(resources.GetObject("llFamiAddSim.TabIndex")));
			this.llFamiAddSim.Text = resources.GetString("llFamiAddSim.Text");
			this.llFamiAddSim.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llFamiAddSim.TextAlign")));
			this.toolTip1.SetToolTip(this.llFamiAddSim, resources.GetString("llFamiAddSim.ToolTip"));
			this.llFamiAddSim.Visible = ((bool)(resources.GetObject("llFamiAddSim.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.llFamiAddSim, true);
			this.llFamiAddSim.Click += new System.EventHandler(this.FamiSimAddClick);
			// 
			// button1
			// 
			this.button1.AccessibleDescription = resources.GetString("button1.AccessibleDescription");
			this.button1.AccessibleName = resources.GetString("button1.AccessibleName");
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("button1.Anchor")));
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("button1.Dock")));
			this.button1.Enabled = ((bool)(resources.GetObject("button1.Enabled")));
			this.button1.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("button1.FlatStyle")));
			this.button1.Font = ((System.Drawing.Font)(resources.GetObject("button1.Font")));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.ImageAlign")));
			this.button1.ImageIndex = ((int)(resources.GetObject("button1.ImageIndex")));
			this.button1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("button1.ImeMode")));
			this.button1.Location = ((System.Drawing.Point)(resources.GetObject("button1.Location")));
			this.button1.Name = "button1";
			this.button1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("button1.RightToLeft")));
			this.button1.Size = ((System.Drawing.Size)(resources.GetObject("button1.Size")));
			this.button1.TabIndex = ((int)(resources.GetObject("button1.TabIndex")));
			this.button1.Text = resources.GetString("button1.Text");
			this.button1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("button1.TextAlign")));
			this.toolTip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
			this.button1.Visible = ((bool)(resources.GetObject("button1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.button1, true);
			this.button1.Click += new System.EventHandler(this.CommitFamiClick);
			// 
			// cbsims
			// 
			this.cbsims.AccessibleDescription = resources.GetString("cbsims.AccessibleDescription");
			this.cbsims.AccessibleName = resources.GetString("cbsims.AccessibleName");
			this.cbsims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsims.Anchor")));
			this.cbsims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsims.BackgroundImage")));
			this.cbsims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsims.Dock")));
			this.cbsims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbsims.Enabled = ((bool)(resources.GetObject("cbsims.Enabled")));
			this.cbsims.Font = ((System.Drawing.Font)(resources.GetObject("cbsims.Font")));
			this.cbsims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsims.ImeMode")));
			this.cbsims.IntegralHeight = ((bool)(resources.GetObject("cbsims.IntegralHeight")));
			this.cbsims.ItemHeight = ((int)(resources.GetObject("cbsims.ItemHeight")));
			this.cbsims.Location = ((System.Drawing.Point)(resources.GetObject("cbsims.Location")));
			this.cbsims.MaxDropDownItems = ((int)(resources.GetObject("cbsims.MaxDropDownItems")));
			this.cbsims.MaxLength = ((int)(resources.GetObject("cbsims.MaxLength")));
			this.cbsims.Name = "cbsims";
			this.cbsims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsims.RightToLeft")));
			this.cbsims.Size = ((System.Drawing.Size)(resources.GetObject("cbsims.Size")));
			this.cbsims.TabIndex = ((int)(resources.GetObject("cbsims.TabIndex")));
			this.cbsims.Text = resources.GetString("cbsims.Text");
			this.toolTip1.SetToolTip(this.cbsims, resources.GetString("cbsims.ToolTip"));
			this.cbsims.Visible = ((bool)(resources.GetObject("cbsims.Visible")));
			this.cbsims.SelectedIndexChanged += new System.EventHandler(this.SimSelectionChange);
			// 
			// lbmembers
			// 
			this.lbmembers.AccessibleDescription = resources.GetString("lbmembers.AccessibleDescription");
			this.lbmembers.AccessibleName = resources.GetString("lbmembers.AccessibleName");
			this.lbmembers.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbmembers.Anchor")));
			this.lbmembers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbmembers.BackgroundImage")));
			this.lbmembers.ColumnWidth = ((int)(resources.GetObject("lbmembers.ColumnWidth")));
			this.lbmembers.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbmembers.Dock")));
			this.lbmembers.Enabled = ((bool)(resources.GetObject("lbmembers.Enabled")));
			this.lbmembers.Font = ((System.Drawing.Font)(resources.GetObject("lbmembers.Font")));
			this.lbmembers.HorizontalExtent = ((int)(resources.GetObject("lbmembers.HorizontalExtent")));
			this.lbmembers.HorizontalScrollbar = ((bool)(resources.GetObject("lbmembers.HorizontalScrollbar")));
			this.lbmembers.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbmembers.ImeMode")));
			this.lbmembers.IntegralHeight = ((bool)(resources.GetObject("lbmembers.IntegralHeight")));
			this.lbmembers.ItemHeight = ((int)(resources.GetObject("lbmembers.ItemHeight")));
			this.lbmembers.Location = ((System.Drawing.Point)(resources.GetObject("lbmembers.Location")));
			this.lbmembers.Name = "lbmembers";
			this.lbmembers.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbmembers.RightToLeft")));
			this.lbmembers.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbmembers.ScrollAlwaysVisible")));
			this.lbmembers.Size = ((System.Drawing.Size)(resources.GetObject("lbmembers.Size")));
			this.lbmembers.TabIndex = ((int)(resources.GetObject("lbmembers.TabIndex")));
			this.toolTip1.SetToolTip(this.lbmembers, resources.GetString("lbmembers.ToolTip"));
			this.lbmembers.Visible = ((bool)(resources.GetObject("lbmembers.Visible")));
			this.lbmembers.SelectedIndexChanged += new System.EventHandler(this.FamiMemberSelectionClick);
			// 
			// tbname
			// 
			this.tbname.AccessibleDescription = resources.GetString("tbname.AccessibleDescription");
			this.tbname.AccessibleName = resources.GetString("tbname.AccessibleName");
			this.tbname.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbname.Anchor")));
			this.tbname.AutoSize = ((bool)(resources.GetObject("tbname.AutoSize")));
			this.tbname.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbname.BackgroundImage")));
			this.tbname.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbname.Dock")));
			this.tbname.Enabled = ((bool)(resources.GetObject("tbname.Enabled")));
			this.tbname.Font = ((System.Drawing.Font)(resources.GetObject("tbname.Font")));
			this.tbname.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbname.ImeMode")));
			this.tbname.Location = ((System.Drawing.Point)(resources.GetObject("tbname.Location")));
			this.tbname.MaxLength = ((int)(resources.GetObject("tbname.MaxLength")));
			this.tbname.Multiline = ((bool)(resources.GetObject("tbname.Multiline")));
			this.tbname.Name = "tbname";
			this.tbname.PasswordChar = ((char)(resources.GetObject("tbname.PasswordChar")));
			this.tbname.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbname.RightToLeft")));
			this.tbname.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbname.ScrollBars")));
			this.tbname.Size = ((System.Drawing.Size)(resources.GetObject("tbname.Size")));
			this.tbname.TabIndex = ((int)(resources.GetObject("tbname.TabIndex")));
			this.tbname.Text = resources.GetString("tbname.Text");
			this.tbname.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbname.TextAlign")));
			this.toolTip1.SetToolTip(this.tbname, resources.GetString("tbname.ToolTip"));
			this.tbname.Visible = ((bool)(resources.GetObject("tbname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbname, true);
			this.tbname.WordWrap = ((bool)(resources.GetObject("tbname.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label6, resources.GetString("label6.ToolTip"));
			this.label6.Visible = ((bool)(resources.GetObject("label6.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label6, true);
			// 
			// tbfamily
			// 
			this.tbfamily.AccessibleDescription = resources.GetString("tbfamily.AccessibleDescription");
			this.tbfamily.AccessibleName = resources.GetString("tbfamily.AccessibleName");
			this.tbfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfamily.Anchor")));
			this.tbfamily.AutoSize = ((bool)(resources.GetObject("tbfamily.AutoSize")));
			this.tbfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfamily.BackgroundImage")));
			this.tbfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfamily.Dock")));
			this.tbfamily.Enabled = ((bool)(resources.GetObject("tbfamily.Enabled")));
			this.tbfamily.Font = ((System.Drawing.Font)(resources.GetObject("tbfamily.Font")));
			this.tbfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfamily.ImeMode")));
			this.tbfamily.Location = ((System.Drawing.Point)(resources.GetObject("tbfamily.Location")));
			this.tbfamily.MaxLength = ((int)(resources.GetObject("tbfamily.MaxLength")));
			this.tbfamily.Multiline = ((bool)(resources.GetObject("tbfamily.Multiline")));
			this.tbfamily.Name = "tbfamily";
			this.tbfamily.PasswordChar = ((char)(resources.GetObject("tbfamily.PasswordChar")));
			this.tbfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfamily.RightToLeft")));
			this.tbfamily.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfamily.ScrollBars")));
			this.tbfamily.Size = ((System.Drawing.Size)(resources.GetObject("tbfamily.Size")));
			this.tbfamily.TabIndex = ((int)(resources.GetObject("tbfamily.TabIndex")));
			this.tbfamily.Text = resources.GetString("tbfamily.Text");
			this.tbfamily.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfamily, resources.GetString("tbfamily.ToolTip"));
			this.tbfamily.Visible = ((bool)(resources.GetObject("tbfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfamily, true);
			this.tbfamily.WordWrap = ((bool)(resources.GetObject("tbfamily.WordWrap")));
			// 
			// tbmoney
			// 
			this.tbmoney.AccessibleDescription = resources.GetString("tbmoney.AccessibleDescription");
			this.tbmoney.AccessibleName = resources.GetString("tbmoney.AccessibleName");
			this.tbmoney.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmoney.Anchor")));
			this.tbmoney.AutoSize = ((bool)(resources.GetObject("tbmoney.AutoSize")));
			this.tbmoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmoney.BackgroundImage")));
			this.tbmoney.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmoney.Dock")));
			this.tbmoney.Enabled = ((bool)(resources.GetObject("tbmoney.Enabled")));
			this.tbmoney.Font = ((System.Drawing.Font)(resources.GetObject("tbmoney.Font")));
			this.tbmoney.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmoney.ImeMode")));
			this.tbmoney.Location = ((System.Drawing.Point)(resources.GetObject("tbmoney.Location")));
			this.tbmoney.MaxLength = ((int)(resources.GetObject("tbmoney.MaxLength")));
			this.tbmoney.Multiline = ((bool)(resources.GetObject("tbmoney.Multiline")));
			this.tbmoney.Name = "tbmoney";
			this.tbmoney.PasswordChar = ((char)(resources.GetObject("tbmoney.PasswordChar")));
			this.tbmoney.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmoney.RightToLeft")));
			this.tbmoney.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmoney.ScrollBars")));
			this.tbmoney.Size = ((System.Drawing.Size)(resources.GetObject("tbmoney.Size")));
			this.tbmoney.TabIndex = ((int)(resources.GetObject("tbmoney.TabIndex")));
			this.tbmoney.Text = resources.GetString("tbmoney.Text");
			this.tbmoney.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmoney.TextAlign")));
			this.toolTip1.SetToolTip(this.tbmoney, resources.GetString("tbmoney.ToolTip"));
			this.tbmoney.Visible = ((bool)(resources.GetObject("tbmoney.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbmoney, true);
			this.tbmoney.WordWrap = ((bool)(resources.GetObject("tbmoney.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label5, resources.GetString("label5.ToolTip"));
			this.label5.Visible = ((bool)(resources.GetObject("label5.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label5, true);
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
			this.toolTip1.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
			this.label4.Visible = ((bool)(resources.GetObject("label4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label4, true);
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
			this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
			this.label3.Visible = ((bool)(resources.GetObject("label3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label3, true);
			// 
			// panel4
			// 
			this.panel4.AccessibleDescription = resources.GetString("panel4.AccessibleDescription");
			this.panel4.AccessibleName = resources.GetString("panel4.AccessibleName");
			this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel4.Anchor")));
			this.panel4.AutoScroll = ((bool)(resources.GetObject("panel4.AutoScroll")));
			this.panel4.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMargin")));
			this.panel4.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel4.AutoScrollMinSize")));
			this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel4.Dock")));
			this.panel4.Enabled = ((bool)(resources.GetObject("panel4.Enabled")));
			this.panel4.Font = ((System.Drawing.Font)(resources.GetObject("panel4.Font")));
			this.panel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel4.ImeMode")));
			this.panel4.Location = ((System.Drawing.Point)(resources.GetObject("panel4.Location")));
			this.panel4.Name = "panel4";
			this.panel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel4.RightToLeft")));
			this.panel4.Size = ((System.Drawing.Size)(resources.GetObject("panel4.Size")));
			this.panel4.TabIndex = ((int)(resources.GetObject("panel4.TabIndex")));
			this.panel4.Text = resources.GetString("panel4.Text");
			this.toolTip1.SetToolTip(this.panel4, resources.GetString("panel4.ToolTip"));
			this.panel4.Visible = ((bool)(resources.GetObject("panel4.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel4, true);
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
			this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
			this.label2.Visible = ((bool)(resources.GetObject("label2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label2, true);
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
			this.toolTip1.SetToolTip(this.label15, resources.GetString("label15.ToolTip"));
			this.label15.Visible = ((bool)(resources.GetObject("label15.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label15, true);
			// 
			// tabPage2
			// 
			this.tabPage2.AccessibleDescription = resources.GetString("tabPage2.AccessibleDescription");
			this.tabPage2.AccessibleName = resources.GetString("tabPage2.AccessibleName");
			this.tabPage2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage2.Anchor")));
			this.tabPage2.AutoScroll = ((bool)(resources.GetObject("tabPage2.AutoScroll")));
			this.tabPage2.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMargin")));
			this.tabPage2.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage2.AutoScrollMinSize")));
			this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
			this.tabPage2.Controls.Add(this.sdescPanel);
			this.tabPage2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage2.Dock")));
			this.tabPage2.Enabled = ((bool)(resources.GetObject("tabPage2.Enabled")));
			this.tabPage2.Font = ((System.Drawing.Font)(resources.GetObject("tabPage2.Font")));
			this.tabPage2.ImageIndex = ((int)(resources.GetObject("tabPage2.ImageIndex")));
			this.tabPage2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage2.ImeMode")));
			this.tabPage2.Location = ((System.Drawing.Point)(resources.GetObject("tabPage2.Location")));
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage2.RightToLeft")));
			this.tabPage2.Size = ((System.Drawing.Size)(resources.GetObject("tabPage2.Size")));
			this.tabPage2.TabIndex = ((int)(resources.GetObject("tabPage2.TabIndex")));
			this.tabPage2.Text = resources.GetString("tabPage2.Text");
			this.toolTip1.SetToolTip(this.tabPage2, resources.GetString("tabPage2.ToolTip"));
			this.tabPage2.ToolTipText = resources.GetString("tabPage2.ToolTipText");
			this.tabPage2.Visible = ((bool)(resources.GetObject("tabPage2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage2, true);
			// 
			// sdescPanel
			// 
			this.sdescPanel.AccessibleDescription = resources.GetString("sdescPanel.AccessibleDescription");
			this.sdescPanel.AccessibleName = resources.GetString("sdescPanel.AccessibleName");
			this.sdescPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("sdescPanel.Anchor")));
			this.sdescPanel.AutoScroll = ((bool)(resources.GetObject("sdescPanel.AutoScroll")));
			this.sdescPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("sdescPanel.AutoScrollMargin")));
			this.sdescPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("sdescPanel.AutoScrollMinSize")));
			this.sdescPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sdescPanel.BackgroundImage")));
			this.sdescPanel.Controls.Add(this.linkLabel6);
			this.sdescPanel.Controls.Add(this.tcsdesc);
			this.sdescPanel.Controls.Add(this.lldna);
			this.sdescPanel.Controls.Add(this.llcloth);
			this.sdescPanel.Controls.Add(this.llfam);
			this.sdescPanel.Controls.Add(this.tbsimdescfamname);
			this.sdescPanel.Controls.Add(this.tbfaminst);
			this.sdescPanel.Controls.Add(this.cbzodiac);
			this.sdescPanel.Controls.Add(this.label49);
			this.sdescPanel.Controls.Add(this.rbmale);
			this.sdescPanel.Controls.Add(this.rbfemale);
			this.sdescPanel.Controls.Add(this.label48);
			this.sdescPanel.Controls.Add(this.cblifesection);
			this.sdescPanel.Controls.Add(this.label47);
			this.sdescPanel.Controls.Add(this.cbaspiration);
			this.sdescPanel.Controls.Add(this.label46);
			this.sdescPanel.Controls.Add(this.pbImage);
			this.sdescPanel.Controls.Add(this.llsdesccommit);
			this.sdescPanel.Controls.Add(this.tbsimdescname);
			this.sdescPanel.Controls.Add(this.label13);
			this.sdescPanel.Controls.Add(this.tbsim);
			this.sdescPanel.Controls.Add(this.tbage);
			this.sdescPanel.Controls.Add(this.label10);
			this.sdescPanel.Controls.Add(this.panel5);
			this.sdescPanel.Controls.Add(this.linkLabel5);
			this.sdescPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("sdescPanel.Dock")));
			this.sdescPanel.Enabled = ((bool)(resources.GetObject("sdescPanel.Enabled")));
			this.sdescPanel.Font = ((System.Drawing.Font)(resources.GetObject("sdescPanel.Font")));
			this.sdescPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("sdescPanel.ImeMode")));
			this.sdescPanel.Location = ((System.Drawing.Point)(resources.GetObject("sdescPanel.Location")));
			this.sdescPanel.Name = "sdescPanel";
			this.sdescPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("sdescPanel.RightToLeft")));
			this.sdescPanel.Size = ((System.Drawing.Size)(resources.GetObject("sdescPanel.Size")));
			this.sdescPanel.TabIndex = ((int)(resources.GetObject("sdescPanel.TabIndex")));
			this.sdescPanel.Text = resources.GetString("sdescPanel.Text");
			this.toolTip1.SetToolTip(this.sdescPanel, resources.GetString("sdescPanel.ToolTip"));
			this.sdescPanel.Visible = ((bool)(resources.GetObject("sdescPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.sdescPanel, true);
			// 
			// linkLabel6
			// 
			this.linkLabel6.AccessibleDescription = resources.GetString("linkLabel6.AccessibleDescription");
			this.linkLabel6.AccessibleName = resources.GetString("linkLabel6.AccessibleName");
			this.linkLabel6.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel6.Anchor")));
			this.linkLabel6.AutoSize = ((bool)(resources.GetObject("linkLabel6.AutoSize")));
			this.linkLabel6.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel6.Dock")));
			this.linkLabel6.Enabled = ((bool)(resources.GetObject("linkLabel6.Enabled")));
			this.linkLabel6.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel6.Font")));
			this.linkLabel6.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel6.Image")));
			this.linkLabel6.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel6.ImageAlign")));
			this.linkLabel6.ImageIndex = ((int)(resources.GetObject("linkLabel6.ImageIndex")));
			this.linkLabel6.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel6.ImeMode")));
			this.linkLabel6.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel6.LinkArea")));
			this.linkLabel6.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel6.Location")));
			this.linkLabel6.Name = "linkLabel6";
			this.linkLabel6.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel6.RightToLeft")));
			this.linkLabel6.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel6.Size")));
			this.linkLabel6.TabIndex = ((int)(resources.GetObject("linkLabel6.TabIndex")));
			this.linkLabel6.TabStop = true;
			this.linkLabel6.Text = resources.GetString("linkLabel6.Text");
			this.linkLabel6.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel6.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel6, resources.GetString("linkLabel6.ToolTip"));
			this.linkLabel6.Visible = ((bool)(resources.GetObject("linkLabel6.Visible")));
			this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Relink);
			// 
			// tcsdesc
			// 
			this.tcsdesc.AccessibleDescription = resources.GetString("tcsdesc.AccessibleDescription");
			this.tcsdesc.AccessibleName = resources.GetString("tcsdesc.AccessibleName");
			this.tcsdesc.Alignment = ((System.Windows.Forms.TabAlignment)(resources.GetObject("tcsdesc.Alignment")));
			this.tcsdesc.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tcsdesc.Anchor")));
			this.tcsdesc.Appearance = ((System.Windows.Forms.TabAppearance)(resources.GetObject("tcsdesc.Appearance")));
			this.tcsdesc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tcsdesc.BackgroundImage")));
			this.tcsdesc.Controls.Add(this.tpinterests);
			this.tcsdesc.Controls.Add(this.tbext);
			this.tcsdesc.Controls.Add(this.tbcharacter);
			this.tcsdesc.Controls.Add(this.tbrelations);
			this.tcsdesc.Controls.Add(this.tbskills);
			this.tcsdesc.Controls.Add(this.tbuni);
			this.tcsdesc.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tcsdesc.Dock")));
			this.tcsdesc.Enabled = ((bool)(resources.GetObject("tcsdesc.Enabled")));
			this.tcsdesc.Font = ((System.Drawing.Font)(resources.GetObject("tcsdesc.Font")));
			this.tcsdesc.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tcsdesc.ImeMode")));
			this.tcsdesc.ItemSize = ((System.Drawing.Size)(resources.GetObject("tcsdesc.ItemSize")));
			this.tcsdesc.Location = ((System.Drawing.Point)(resources.GetObject("tcsdesc.Location")));
			this.tcsdesc.Name = "tcsdesc";
			this.tcsdesc.Padding = ((System.Drawing.Point)(resources.GetObject("tcsdesc.Padding")));
			this.tcsdesc.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tcsdesc.RightToLeft")));
			this.tcsdesc.SelectedIndex = 0;
			this.tcsdesc.ShowToolTips = ((bool)(resources.GetObject("tcsdesc.ShowToolTips")));
			this.tcsdesc.Size = ((System.Drawing.Size)(resources.GetObject("tcsdesc.Size")));
			this.tcsdesc.TabIndex = ((int)(resources.GetObject("tcsdesc.TabIndex")));
			this.tcsdesc.Text = resources.GetString("tcsdesc.Text");
			this.toolTip1.SetToolTip(this.tcsdesc, resources.GetString("tcsdesc.ToolTip"));
			this.tcsdesc.Visible = ((bool)(resources.GetObject("tcsdesc.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tcsdesc, true);
			// 
			// tpinterests
			// 
			this.tpinterests.AccessibleDescription = resources.GetString("tpinterests.AccessibleDescription");
			this.tpinterests.AccessibleName = resources.GetString("tpinterests.AccessibleName");
			this.tpinterests.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tpinterests.Anchor")));
			this.tpinterests.AutoScroll = ((bool)(resources.GetObject("tpinterests.AutoScroll")));
			this.tpinterests.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tpinterests.AutoScrollMargin")));
			this.tpinterests.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tpinterests.AutoScrollMinSize")));
			this.tpinterests.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpinterests.BackgroundImage")));
			this.tpinterests.Controls.Add(this.panel1);
			this.tpinterests.Controls.Add(this.label70);
			this.tpinterests.Controls.Add(this.label69);
			this.tpinterests.Controls.Add(this.label67);
			this.tpinterests.Controls.Add(this.pbwoman);
			this.tpinterests.Controls.Add(this.tbwoman);
			this.tpinterests.Controls.Add(this.label66);
			this.tpinterests.Controls.Add(this.pbman);
			this.tpinterests.Controls.Add(this.tbman);
			this.tpinterests.Controls.Add(this.pbsports);
			this.tpinterests.Controls.Add(this.pbfashion);
			this.tpinterests.Controls.Add(this.label38);
			this.tpinterests.Controls.Add(this.label37);
			this.tpinterests.Controls.Add(this.tbscifi);
			this.tpinterests.Controls.Add(this.label28);
			this.tpinterests.Controls.Add(this.label36);
			this.tpinterests.Controls.Add(this.label35);
			this.tpinterests.Controls.Add(this.pbhealth);
			this.tpinterests.Controls.Add(this.label34);
			this.tpinterests.Controls.Add(this.pbpolitics);
			this.tpinterests.Controls.Add(this.pbmonei);
			this.tpinterests.Controls.Add(this.pbculture);
			this.tpinterests.Controls.Add(this.pbfood);
			this.tpinterests.Controls.Add(this.pbentertainment);
			this.tpinterests.Controls.Add(this.pbparanormal);
			this.tpinterests.Controls.Add(this.pbwork);
			this.tpinterests.Controls.Add(this.tbtoys);
			this.tpinterests.Controls.Add(this.tbschool);
			this.tpinterests.Controls.Add(this.tbanimals);
			this.tpinterests.Controls.Add(this.tbweather);
			this.tpinterests.Controls.Add(this.label33);
			this.tpinterests.Controls.Add(this.tbwork);
			this.tpinterests.Controls.Add(this.label29);
			this.tpinterests.Controls.Add(this.label43);
			this.tpinterests.Controls.Add(this.tbtravel);
			this.tpinterests.Controls.Add(this.label42);
			this.tpinterests.Controls.Add(this.label40);
			this.tpinterests.Controls.Add(this.label41);
			this.tpinterests.Controls.Add(this.tbcrime);
			this.tpinterests.Controls.Add(this.tbsports);
			this.tpinterests.Controls.Add(this.tbfashion);
			this.tpinterests.Controls.Add(this.tbhealth);
			this.tpinterests.Controls.Add(this.tbfood);
			this.tpinterests.Controls.Add(this.tbpolitics);
			this.tpinterests.Controls.Add(this.label31);
			this.tpinterests.Controls.Add(this.tbmonei);
			this.tpinterests.Controls.Add(this.label30);
			this.tpinterests.Controls.Add(this.tbculture);
			this.tpinterests.Controls.Add(this.tbentertainment);
			this.tpinterests.Controls.Add(this.tbparanormal);
			this.tpinterests.Controls.Add(this.tbenvironment);
			this.tpinterests.Controls.Add(this.pbscifi);
			this.tpinterests.Controls.Add(this.pbtoys);
			this.tpinterests.Controls.Add(this.pbschool);
			this.tpinterests.Controls.Add(this.label45);
			this.tpinterests.Controls.Add(this.pbanimals);
			this.tpinterests.Controls.Add(this.pbweather);
			this.tpinterests.Controls.Add(this.label44);
			this.tpinterests.Controls.Add(this.pbenvironment);
			this.tpinterests.Controls.Add(this.label39);
			this.tpinterests.Controls.Add(this.pbtravel);
			this.tpinterests.Controls.Add(this.label32);
			this.tpinterests.Controls.Add(this.pbcrime);
			this.tpinterests.Controls.Add(this.linkLabel1);
			this.tpinterests.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tpinterests.Dock")));
			this.tpinterests.Enabled = ((bool)(resources.GetObject("tpinterests.Enabled")));
			this.tpinterests.Font = ((System.Drawing.Font)(resources.GetObject("tpinterests.Font")));
			this.tpinterests.ImageIndex = ((int)(resources.GetObject("tpinterests.ImageIndex")));
			this.tpinterests.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tpinterests.ImeMode")));
			this.tpinterests.Location = ((System.Drawing.Point)(resources.GetObject("tpinterests.Location")));
			this.tpinterests.Name = "tpinterests";
			this.tpinterests.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tpinterests.RightToLeft")));
			this.tpinterests.Size = ((System.Drawing.Size)(resources.GetObject("tpinterests.Size")));
			this.tpinterests.TabIndex = ((int)(resources.GetObject("tpinterests.TabIndex")));
			this.tpinterests.Text = resources.GetString("tpinterests.Text");
			this.toolTip1.SetToolTip(this.tpinterests, resources.GetString("tpinterests.ToolTip"));
			this.tpinterests.ToolTipText = resources.GetString("tpinterests.ToolTipText");
			this.tpinterests.Visible = ((bool)(resources.GetObject("tpinterests.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tpinterests, true);
			// 
			// panel1
			// 
			this.panel1.AccessibleDescription = resources.GetString("panel1.AccessibleDescription");
			this.panel1.AccessibleName = resources.GetString("panel1.AccessibleName");
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel1.Anchor")));
			this.panel1.AutoScroll = ((bool)(resources.GetObject("panel1.AutoScroll")));
			this.panel1.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMargin")));
			this.panel1.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel1.AutoScrollMinSize")));
			this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
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
			this.toolTip1.SetToolTip(this.panel1, resources.GetString("panel1.ToolTip"));
			this.panel1.Visible = ((bool)(resources.GetObject("panel1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel1, true);
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
			this.label70.ForeColor = System.Drawing.SystemColors.Desktop;
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
			this.toolTip1.SetToolTip(this.label70, resources.GetString("label70.ToolTip"));
			this.label70.Visible = ((bool)(resources.GetObject("label70.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label70, true);
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
			this.label69.ForeColor = System.Drawing.SystemColors.Desktop;
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
			this.toolTip1.SetToolTip(this.label69, resources.GetString("label69.ToolTip"));
			this.label69.Visible = ((bool)(resources.GetObject("label69.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label69, true);
			// 
			// label67
			// 
			this.label67.AccessibleDescription = resources.GetString("label67.AccessibleDescription");
			this.label67.AccessibleName = resources.GetString("label67.AccessibleName");
			this.label67.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label67.Anchor")));
			this.label67.AutoSize = ((bool)(resources.GetObject("label67.AutoSize")));
			this.label67.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label67.Dock")));
			this.label67.Enabled = ((bool)(resources.GetObject("label67.Enabled")));
			this.label67.Font = ((System.Drawing.Font)(resources.GetObject("label67.Font")));
			this.label67.Image = ((System.Drawing.Image)(resources.GetObject("label67.Image")));
			this.label67.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label67.ImageAlign")));
			this.label67.ImageIndex = ((int)(resources.GetObject("label67.ImageIndex")));
			this.label67.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label67.ImeMode")));
			this.label67.Location = ((System.Drawing.Point)(resources.GetObject("label67.Location")));
			this.label67.Name = "label67";
			this.label67.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label67.RightToLeft")));
			this.label67.Size = ((System.Drawing.Size)(resources.GetObject("label67.Size")));
			this.label67.TabIndex = ((int)(resources.GetObject("label67.TabIndex")));
			this.label67.Text = resources.GetString("label67.Text");
			this.label67.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label67.TextAlign")));
			this.toolTip1.SetToolTip(this.label67, resources.GetString("label67.ToolTip"));
			this.label67.Visible = ((bool)(resources.GetObject("label67.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label67, true);
			// 
			// pbwoman
			// 
			this.pbwoman.AccessibleDescription = resources.GetString("pbwoman.AccessibleDescription");
			this.pbwoman.AccessibleName = resources.GetString("pbwoman.AccessibleName");
			this.pbwoman.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbwoman.Anchor")));
			this.pbwoman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbwoman.BackgroundImage")));
			this.pbwoman.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbwoman.Dock")));
			this.pbwoman.Enabled = ((bool)(resources.GetObject("pbwoman.Enabled")));
			this.pbwoman.Font = ((System.Drawing.Font)(resources.GetObject("pbwoman.Font")));
			this.pbwoman.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbwoman.ImeMode")));
			this.pbwoman.Location = ((System.Drawing.Point)(resources.GetObject("pbwoman.Location")));
			this.pbwoman.Maximum = 2000;
			this.pbwoman.Name = "pbwoman";
			this.pbwoman.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbwoman.RightToLeft")));
			this.pbwoman.Size = ((System.Drawing.Size)(resources.GetObject("pbwoman.Size")));
			this.pbwoman.Step = 1;
			this.pbwoman.TabIndex = ((int)(resources.GetObject("pbwoman.TabIndex")));
			this.pbwoman.Text = resources.GetString("pbwoman.Text");
			this.toolTip1.SetToolTip(this.pbwoman, resources.GetString("pbwoman.ToolTip"));
			this.pbwoman.Visible = ((bool)(resources.GetObject("pbwoman.Visible")));
			this.pbwoman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbwoman.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbwoman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbwoman
			// 
			this.tbwoman.AccessibleDescription = resources.GetString("tbwoman.AccessibleDescription");
			this.tbwoman.AccessibleName = resources.GetString("tbwoman.AccessibleName");
			this.tbwoman.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbwoman.Anchor")));
			this.tbwoman.AutoSize = ((bool)(resources.GetObject("tbwoman.AutoSize")));
			this.tbwoman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbwoman.BackgroundImage")));
			this.tbwoman.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbwoman.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbwoman.Dock")));
			this.tbwoman.Enabled = ((bool)(resources.GetObject("tbwoman.Enabled")));
			this.tbwoman.Font = ((System.Drawing.Font)(resources.GetObject("tbwoman.Font")));
			this.tbwoman.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbwoman.ImeMode")));
			this.tbwoman.Location = ((System.Drawing.Point)(resources.GetObject("tbwoman.Location")));
			this.tbwoman.MaxLength = ((int)(resources.GetObject("tbwoman.MaxLength")));
			this.tbwoman.Multiline = ((bool)(resources.GetObject("tbwoman.Multiline")));
			this.tbwoman.Name = "tbwoman";
			this.tbwoman.PasswordChar = ((char)(resources.GetObject("tbwoman.PasswordChar")));
			this.tbwoman.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbwoman.RightToLeft")));
			this.tbwoman.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbwoman.ScrollBars")));
			this.tbwoman.Size = ((System.Drawing.Size)(resources.GetObject("tbwoman.Size")));
			this.tbwoman.TabIndex = ((int)(resources.GetObject("tbwoman.TabIndex")));
			this.tbwoman.Text = resources.GetString("tbwoman.Text");
			this.tbwoman.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbwoman.TextAlign")));
			this.toolTip1.SetToolTip(this.tbwoman, resources.GetString("tbwoman.ToolTip"));
			this.tbwoman.Visible = ((bool)(resources.GetObject("tbwoman.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbwoman, true);
			this.tbwoman.WordWrap = ((bool)(resources.GetObject("tbwoman.WordWrap")));
			this.tbwoman.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbwoman.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label66
			// 
			this.label66.AccessibleDescription = resources.GetString("label66.AccessibleDescription");
			this.label66.AccessibleName = resources.GetString("label66.AccessibleName");
			this.label66.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label66.Anchor")));
			this.label66.AutoSize = ((bool)(resources.GetObject("label66.AutoSize")));
			this.label66.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label66.Dock")));
			this.label66.Enabled = ((bool)(resources.GetObject("label66.Enabled")));
			this.label66.Font = ((System.Drawing.Font)(resources.GetObject("label66.Font")));
			this.label66.Image = ((System.Drawing.Image)(resources.GetObject("label66.Image")));
			this.label66.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label66.ImageAlign")));
			this.label66.ImageIndex = ((int)(resources.GetObject("label66.ImageIndex")));
			this.label66.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label66.ImeMode")));
			this.label66.Location = ((System.Drawing.Point)(resources.GetObject("label66.Location")));
			this.label66.Name = "label66";
			this.label66.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label66.RightToLeft")));
			this.label66.Size = ((System.Drawing.Size)(resources.GetObject("label66.Size")));
			this.label66.TabIndex = ((int)(resources.GetObject("label66.TabIndex")));
			this.label66.Text = resources.GetString("label66.Text");
			this.label66.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label66.TextAlign")));
			this.toolTip1.SetToolTip(this.label66, resources.GetString("label66.ToolTip"));
			this.label66.Visible = ((bool)(resources.GetObject("label66.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label66, true);
			// 
			// pbman
			// 
			this.pbman.AccessibleDescription = resources.GetString("pbman.AccessibleDescription");
			this.pbman.AccessibleName = resources.GetString("pbman.AccessibleName");
			this.pbman.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbman.Anchor")));
			this.pbman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbman.BackgroundImage")));
			this.pbman.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbman.Dock")));
			this.pbman.Enabled = ((bool)(resources.GetObject("pbman.Enabled")));
			this.pbman.Font = ((System.Drawing.Font)(resources.GetObject("pbman.Font")));
			this.pbman.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbman.ImeMode")));
			this.pbman.Location = ((System.Drawing.Point)(resources.GetObject("pbman.Location")));
			this.pbman.Maximum = 2000;
			this.pbman.Name = "pbman";
			this.pbman.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbman.RightToLeft")));
			this.pbman.Size = ((System.Drawing.Size)(resources.GetObject("pbman.Size")));
			this.pbman.Step = 1;
			this.pbman.TabIndex = ((int)(resources.GetObject("pbman.TabIndex")));
			this.pbman.Text = resources.GetString("pbman.Text");
			this.toolTip1.SetToolTip(this.pbman, resources.GetString("pbman.ToolTip"));
			this.pbman.Visible = ((bool)(resources.GetObject("pbman.Visible")));
			this.pbman.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbman.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbman.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbman
			// 
			this.tbman.AccessibleDescription = resources.GetString("tbman.AccessibleDescription");
			this.tbman.AccessibleName = resources.GetString("tbman.AccessibleName");
			this.tbman.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbman.Anchor")));
			this.tbman.AutoSize = ((bool)(resources.GetObject("tbman.AutoSize")));
			this.tbman.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbman.BackgroundImage")));
			this.tbman.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbman.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbman.Dock")));
			this.tbman.Enabled = ((bool)(resources.GetObject("tbman.Enabled")));
			this.tbman.Font = ((System.Drawing.Font)(resources.GetObject("tbman.Font")));
			this.tbman.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbman.ImeMode")));
			this.tbman.Location = ((System.Drawing.Point)(resources.GetObject("tbman.Location")));
			this.tbman.MaxLength = ((int)(resources.GetObject("tbman.MaxLength")));
			this.tbman.Multiline = ((bool)(resources.GetObject("tbman.Multiline")));
			this.tbman.Name = "tbman";
			this.tbman.PasswordChar = ((char)(resources.GetObject("tbman.PasswordChar")));
			this.tbman.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbman.RightToLeft")));
			this.tbman.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbman.ScrollBars")));
			this.tbman.Size = ((System.Drawing.Size)(resources.GetObject("tbman.Size")));
			this.tbman.TabIndex = ((int)(resources.GetObject("tbman.TabIndex")));
			this.tbman.Text = resources.GetString("tbman.Text");
			this.tbman.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbman.TextAlign")));
			this.toolTip1.SetToolTip(this.tbman, resources.GetString("tbman.ToolTip"));
			this.tbman.Visible = ((bool)(resources.GetObject("tbman.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbman, true);
			this.tbman.WordWrap = ((bool)(resources.GetObject("tbman.WordWrap")));
			this.tbman.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbman.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbsports
			// 
			this.pbsports.AccessibleDescription = resources.GetString("pbsports.AccessibleDescription");
			this.pbsports.AccessibleName = resources.GetString("pbsports.AccessibleName");
			this.pbsports.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbsports.Anchor")));
			this.pbsports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbsports.BackgroundImage")));
			this.pbsports.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbsports.Dock")));
			this.pbsports.Enabled = ((bool)(resources.GetObject("pbsports.Enabled")));
			this.pbsports.Font = ((System.Drawing.Font)(resources.GetObject("pbsports.Font")));
			this.pbsports.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbsports.ImeMode")));
			this.pbsports.Location = ((System.Drawing.Point)(resources.GetObject("pbsports.Location")));
			this.pbsports.Maximum = 10;
			this.pbsports.Name = "pbsports";
			this.pbsports.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbsports.RightToLeft")));
			this.pbsports.Size = ((System.Drawing.Size)(resources.GetObject("pbsports.Size")));
			this.pbsports.Step = 1;
			this.pbsports.TabIndex = ((int)(resources.GetObject("pbsports.TabIndex")));
			this.pbsports.Text = resources.GetString("pbsports.Text");
			this.toolTip1.SetToolTip(this.pbsports, resources.GetString("pbsports.ToolTip"));
			this.pbsports.Visible = ((bool)(resources.GetObject("pbsports.Visible")));
			this.pbsports.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbsports.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbsports.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbfashion
			// 
			this.pbfashion.AccessibleDescription = resources.GetString("pbfashion.AccessibleDescription");
			this.pbfashion.AccessibleName = resources.GetString("pbfashion.AccessibleName");
			this.pbfashion.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbfashion.Anchor")));
			this.pbfashion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfashion.BackgroundImage")));
			this.pbfashion.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbfashion.Dock")));
			this.pbfashion.Enabled = ((bool)(resources.GetObject("pbfashion.Enabled")));
			this.pbfashion.Font = ((System.Drawing.Font)(resources.GetObject("pbfashion.Font")));
			this.pbfashion.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbfashion.ImeMode")));
			this.pbfashion.Location = ((System.Drawing.Point)(resources.GetObject("pbfashion.Location")));
			this.pbfashion.Maximum = 10;
			this.pbfashion.Name = "pbfashion";
			this.pbfashion.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbfashion.RightToLeft")));
			this.pbfashion.Size = ((System.Drawing.Size)(resources.GetObject("pbfashion.Size")));
			this.pbfashion.Step = 1;
			this.pbfashion.TabIndex = ((int)(resources.GetObject("pbfashion.TabIndex")));
			this.pbfashion.Text = resources.GetString("pbfashion.Text");
			this.toolTip1.SetToolTip(this.pbfashion, resources.GetString("pbfashion.ToolTip"));
			this.pbfashion.Visible = ((bool)(resources.GetObject("pbfashion.Visible")));
			this.pbfashion.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbfashion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbfashion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label38
			// 
			this.label38.AccessibleDescription = resources.GetString("label38.AccessibleDescription");
			this.label38.AccessibleName = resources.GetString("label38.AccessibleName");
			this.label38.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label38.Anchor")));
			this.label38.AutoSize = ((bool)(resources.GetObject("label38.AutoSize")));
			this.label38.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label38.Dock")));
			this.label38.Enabled = ((bool)(resources.GetObject("label38.Enabled")));
			this.label38.Font = ((System.Drawing.Font)(resources.GetObject("label38.Font")));
			this.label38.Image = ((System.Drawing.Image)(resources.GetObject("label38.Image")));
			this.label38.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label38.ImageAlign")));
			this.label38.ImageIndex = ((int)(resources.GetObject("label38.ImageIndex")));
			this.label38.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label38.ImeMode")));
			this.label38.Location = ((System.Drawing.Point)(resources.GetObject("label38.Location")));
			this.label38.Name = "label38";
			this.label38.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label38.RightToLeft")));
			this.label38.Size = ((System.Drawing.Size)(resources.GetObject("label38.Size")));
			this.label38.TabIndex = ((int)(resources.GetObject("label38.TabIndex")));
			this.label38.Text = resources.GetString("label38.Text");
			this.label38.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label38.TextAlign")));
			this.toolTip1.SetToolTip(this.label38, resources.GetString("label38.ToolTip"));
			this.label38.Visible = ((bool)(resources.GetObject("label38.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label38, true);
			// 
			// label37
			// 
			this.label37.AccessibleDescription = resources.GetString("label37.AccessibleDescription");
			this.label37.AccessibleName = resources.GetString("label37.AccessibleName");
			this.label37.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label37.Anchor")));
			this.label37.AutoSize = ((bool)(resources.GetObject("label37.AutoSize")));
			this.label37.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label37.Dock")));
			this.label37.Enabled = ((bool)(resources.GetObject("label37.Enabled")));
			this.label37.Font = ((System.Drawing.Font)(resources.GetObject("label37.Font")));
			this.label37.Image = ((System.Drawing.Image)(resources.GetObject("label37.Image")));
			this.label37.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label37.ImageAlign")));
			this.label37.ImageIndex = ((int)(resources.GetObject("label37.ImageIndex")));
			this.label37.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label37.ImeMode")));
			this.label37.Location = ((System.Drawing.Point)(resources.GetObject("label37.Location")));
			this.label37.Name = "label37";
			this.label37.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label37.RightToLeft")));
			this.label37.Size = ((System.Drawing.Size)(resources.GetObject("label37.Size")));
			this.label37.TabIndex = ((int)(resources.GetObject("label37.TabIndex")));
			this.label37.Text = resources.GetString("label37.Text");
			this.label37.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label37.TextAlign")));
			this.toolTip1.SetToolTip(this.label37, resources.GetString("label37.ToolTip"));
			this.label37.Visible = ((bool)(resources.GetObject("label37.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label37, true);
			// 
			// tbscifi
			// 
			this.tbscifi.AccessibleDescription = resources.GetString("tbscifi.AccessibleDescription");
			this.tbscifi.AccessibleName = resources.GetString("tbscifi.AccessibleName");
			this.tbscifi.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbscifi.Anchor")));
			this.tbscifi.AutoSize = ((bool)(resources.GetObject("tbscifi.AutoSize")));
			this.tbscifi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbscifi.BackgroundImage")));
			this.tbscifi.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbscifi.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbscifi.Dock")));
			this.tbscifi.Enabled = ((bool)(resources.GetObject("tbscifi.Enabled")));
			this.tbscifi.Font = ((System.Drawing.Font)(resources.GetObject("tbscifi.Font")));
			this.tbscifi.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbscifi.ImeMode")));
			this.tbscifi.Location = ((System.Drawing.Point)(resources.GetObject("tbscifi.Location")));
			this.tbscifi.MaxLength = ((int)(resources.GetObject("tbscifi.MaxLength")));
			this.tbscifi.Multiline = ((bool)(resources.GetObject("tbscifi.Multiline")));
			this.tbscifi.Name = "tbscifi";
			this.tbscifi.PasswordChar = ((char)(resources.GetObject("tbscifi.PasswordChar")));
			this.tbscifi.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbscifi.RightToLeft")));
			this.tbscifi.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbscifi.ScrollBars")));
			this.tbscifi.Size = ((System.Drawing.Size)(resources.GetObject("tbscifi.Size")));
			this.tbscifi.TabIndex = ((int)(resources.GetObject("tbscifi.TabIndex")));
			this.tbscifi.Text = resources.GetString("tbscifi.Text");
			this.tbscifi.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbscifi.TextAlign")));
			this.toolTip1.SetToolTip(this.tbscifi, resources.GetString("tbscifi.ToolTip"));
			this.tbscifi.Visible = ((bool)(resources.GetObject("tbscifi.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbscifi, true);
			this.tbscifi.WordWrap = ((bool)(resources.GetObject("tbscifi.WordWrap")));
			this.tbscifi.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbscifi.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label28
			// 
			this.label28.AccessibleDescription = resources.GetString("label28.AccessibleDescription");
			this.label28.AccessibleName = resources.GetString("label28.AccessibleName");
			this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label28.Anchor")));
			this.label28.AutoSize = ((bool)(resources.GetObject("label28.AutoSize")));
			this.label28.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label28.Dock")));
			this.label28.Enabled = ((bool)(resources.GetObject("label28.Enabled")));
			this.label28.Font = ((System.Drawing.Font)(resources.GetObject("label28.Font")));
			this.label28.Image = ((System.Drawing.Image)(resources.GetObject("label28.Image")));
			this.label28.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label28.ImageAlign")));
			this.label28.ImageIndex = ((int)(resources.GetObject("label28.ImageIndex")));
			this.label28.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label28.ImeMode")));
			this.label28.Location = ((System.Drawing.Point)(resources.GetObject("label28.Location")));
			this.label28.Name = "label28";
			this.label28.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label28.RightToLeft")));
			this.label28.Size = ((System.Drawing.Size)(resources.GetObject("label28.Size")));
			this.label28.TabIndex = ((int)(resources.GetObject("label28.TabIndex")));
			this.label28.Text = resources.GetString("label28.Text");
			this.label28.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label28.TextAlign")));
			this.toolTip1.SetToolTip(this.label28, resources.GetString("label28.ToolTip"));
			this.label28.Visible = ((bool)(resources.GetObject("label28.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label28, true);
			// 
			// label36
			// 
			this.label36.AccessibleDescription = resources.GetString("label36.AccessibleDescription");
			this.label36.AccessibleName = resources.GetString("label36.AccessibleName");
			this.label36.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label36.Anchor")));
			this.label36.AutoSize = ((bool)(resources.GetObject("label36.AutoSize")));
			this.label36.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label36.Dock")));
			this.label36.Enabled = ((bool)(resources.GetObject("label36.Enabled")));
			this.label36.Font = ((System.Drawing.Font)(resources.GetObject("label36.Font")));
			this.label36.Image = ((System.Drawing.Image)(resources.GetObject("label36.Image")));
			this.label36.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label36.ImageAlign")));
			this.label36.ImageIndex = ((int)(resources.GetObject("label36.ImageIndex")));
			this.label36.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label36.ImeMode")));
			this.label36.Location = ((System.Drawing.Point)(resources.GetObject("label36.Location")));
			this.label36.Name = "label36";
			this.label36.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label36.RightToLeft")));
			this.label36.Size = ((System.Drawing.Size)(resources.GetObject("label36.Size")));
			this.label36.TabIndex = ((int)(resources.GetObject("label36.TabIndex")));
			this.label36.Text = resources.GetString("label36.Text");
			this.label36.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label36.TextAlign")));
			this.toolTip1.SetToolTip(this.label36, resources.GetString("label36.ToolTip"));
			this.label36.Visible = ((bool)(resources.GetObject("label36.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label36, true);
			// 
			// label35
			// 
			this.label35.AccessibleDescription = resources.GetString("label35.AccessibleDescription");
			this.label35.AccessibleName = resources.GetString("label35.AccessibleName");
			this.label35.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label35.Anchor")));
			this.label35.AutoSize = ((bool)(resources.GetObject("label35.AutoSize")));
			this.label35.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label35.Dock")));
			this.label35.Enabled = ((bool)(resources.GetObject("label35.Enabled")));
			this.label35.Font = ((System.Drawing.Font)(resources.GetObject("label35.Font")));
			this.label35.Image = ((System.Drawing.Image)(resources.GetObject("label35.Image")));
			this.label35.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label35.ImageAlign")));
			this.label35.ImageIndex = ((int)(resources.GetObject("label35.ImageIndex")));
			this.label35.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label35.ImeMode")));
			this.label35.Location = ((System.Drawing.Point)(resources.GetObject("label35.Location")));
			this.label35.Name = "label35";
			this.label35.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label35.RightToLeft")));
			this.label35.Size = ((System.Drawing.Size)(resources.GetObject("label35.Size")));
			this.label35.TabIndex = ((int)(resources.GetObject("label35.TabIndex")));
			this.label35.Text = resources.GetString("label35.Text");
			this.label35.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label35.TextAlign")));
			this.toolTip1.SetToolTip(this.label35, resources.GetString("label35.ToolTip"));
			this.label35.Visible = ((bool)(resources.GetObject("label35.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label35, true);
			// 
			// pbhealth
			// 
			this.pbhealth.AccessibleDescription = resources.GetString("pbhealth.AccessibleDescription");
			this.pbhealth.AccessibleName = resources.GetString("pbhealth.AccessibleName");
			this.pbhealth.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbhealth.Anchor")));
			this.pbhealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbhealth.BackgroundImage")));
			this.pbhealth.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbhealth.Dock")));
			this.pbhealth.Enabled = ((bool)(resources.GetObject("pbhealth.Enabled")));
			this.pbhealth.Font = ((System.Drawing.Font)(resources.GetObject("pbhealth.Font")));
			this.pbhealth.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbhealth.ImeMode")));
			this.pbhealth.Location = ((System.Drawing.Point)(resources.GetObject("pbhealth.Location")));
			this.pbhealth.Maximum = 10;
			this.pbhealth.Name = "pbhealth";
			this.pbhealth.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbhealth.RightToLeft")));
			this.pbhealth.Size = ((System.Drawing.Size)(resources.GetObject("pbhealth.Size")));
			this.pbhealth.Step = 1;
			this.pbhealth.TabIndex = ((int)(resources.GetObject("pbhealth.TabIndex")));
			this.pbhealth.Text = resources.GetString("pbhealth.Text");
			this.toolTip1.SetToolTip(this.pbhealth, resources.GetString("pbhealth.ToolTip"));
			this.pbhealth.Visible = ((bool)(resources.GetObject("pbhealth.Visible")));
			this.pbhealth.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbhealth.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbhealth.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label34
			// 
			this.label34.AccessibleDescription = resources.GetString("label34.AccessibleDescription");
			this.label34.AccessibleName = resources.GetString("label34.AccessibleName");
			this.label34.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label34.Anchor")));
			this.label34.AutoSize = ((bool)(resources.GetObject("label34.AutoSize")));
			this.label34.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label34.Dock")));
			this.label34.Enabled = ((bool)(resources.GetObject("label34.Enabled")));
			this.label34.Font = ((System.Drawing.Font)(resources.GetObject("label34.Font")));
			this.label34.Image = ((System.Drawing.Image)(resources.GetObject("label34.Image")));
			this.label34.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label34.ImageAlign")));
			this.label34.ImageIndex = ((int)(resources.GetObject("label34.ImageIndex")));
			this.label34.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label34.ImeMode")));
			this.label34.Location = ((System.Drawing.Point)(resources.GetObject("label34.Location")));
			this.label34.Name = "label34";
			this.label34.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label34.RightToLeft")));
			this.label34.Size = ((System.Drawing.Size)(resources.GetObject("label34.Size")));
			this.label34.TabIndex = ((int)(resources.GetObject("label34.TabIndex")));
			this.label34.Text = resources.GetString("label34.Text");
			this.label34.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label34.TextAlign")));
			this.toolTip1.SetToolTip(this.label34, resources.GetString("label34.ToolTip"));
			this.label34.Visible = ((bool)(resources.GetObject("label34.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label34, true);
			// 
			// pbpolitics
			// 
			this.pbpolitics.AccessibleDescription = resources.GetString("pbpolitics.AccessibleDescription");
			this.pbpolitics.AccessibleName = resources.GetString("pbpolitics.AccessibleName");
			this.pbpolitics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbpolitics.Anchor")));
			this.pbpolitics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbpolitics.BackgroundImage")));
			this.pbpolitics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbpolitics.Dock")));
			this.pbpolitics.Enabled = ((bool)(resources.GetObject("pbpolitics.Enabled")));
			this.pbpolitics.Font = ((System.Drawing.Font)(resources.GetObject("pbpolitics.Font")));
			this.pbpolitics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbpolitics.ImeMode")));
			this.pbpolitics.Location = ((System.Drawing.Point)(resources.GetObject("pbpolitics.Location")));
			this.pbpolitics.Maximum = 10;
			this.pbpolitics.Name = "pbpolitics";
			this.pbpolitics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbpolitics.RightToLeft")));
			this.pbpolitics.Size = ((System.Drawing.Size)(resources.GetObject("pbpolitics.Size")));
			this.pbpolitics.Step = 1;
			this.pbpolitics.TabIndex = ((int)(resources.GetObject("pbpolitics.TabIndex")));
			this.pbpolitics.Text = resources.GetString("pbpolitics.Text");
			this.toolTip1.SetToolTip(this.pbpolitics, resources.GetString("pbpolitics.ToolTip"));
			this.pbpolitics.Visible = ((bool)(resources.GetObject("pbpolitics.Visible")));
			this.pbpolitics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbpolitics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbpolitics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbmonei
			// 
			this.pbmonei.AccessibleDescription = resources.GetString("pbmonei.AccessibleDescription");
			this.pbmonei.AccessibleName = resources.GetString("pbmonei.AccessibleName");
			this.pbmonei.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbmonei.Anchor")));
			this.pbmonei.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbmonei.BackgroundImage")));
			this.pbmonei.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbmonei.Dock")));
			this.pbmonei.Enabled = ((bool)(resources.GetObject("pbmonei.Enabled")));
			this.pbmonei.Font = ((System.Drawing.Font)(resources.GetObject("pbmonei.Font")));
			this.pbmonei.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbmonei.ImeMode")));
			this.pbmonei.Location = ((System.Drawing.Point)(resources.GetObject("pbmonei.Location")));
			this.pbmonei.Maximum = 10;
			this.pbmonei.Name = "pbmonei";
			this.pbmonei.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbmonei.RightToLeft")));
			this.pbmonei.Size = ((System.Drawing.Size)(resources.GetObject("pbmonei.Size")));
			this.pbmonei.Step = 1;
			this.pbmonei.TabIndex = ((int)(resources.GetObject("pbmonei.TabIndex")));
			this.pbmonei.Text = resources.GetString("pbmonei.Text");
			this.toolTip1.SetToolTip(this.pbmonei, resources.GetString("pbmonei.ToolTip"));
			this.pbmonei.Visible = ((bool)(resources.GetObject("pbmonei.Visible")));
			this.pbmonei.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbmonei.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbmonei.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbculture
			// 
			this.pbculture.AccessibleDescription = resources.GetString("pbculture.AccessibleDescription");
			this.pbculture.AccessibleName = resources.GetString("pbculture.AccessibleName");
			this.pbculture.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbculture.Anchor")));
			this.pbculture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbculture.BackgroundImage")));
			this.pbculture.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbculture.Dock")));
			this.pbculture.Enabled = ((bool)(resources.GetObject("pbculture.Enabled")));
			this.pbculture.Font = ((System.Drawing.Font)(resources.GetObject("pbculture.Font")));
			this.pbculture.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbculture.ImeMode")));
			this.pbculture.Location = ((System.Drawing.Point)(resources.GetObject("pbculture.Location")));
			this.pbculture.Maximum = 10;
			this.pbculture.Name = "pbculture";
			this.pbculture.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbculture.RightToLeft")));
			this.pbculture.Size = ((System.Drawing.Size)(resources.GetObject("pbculture.Size")));
			this.pbculture.Step = 1;
			this.pbculture.TabIndex = ((int)(resources.GetObject("pbculture.TabIndex")));
			this.pbculture.Text = resources.GetString("pbculture.Text");
			this.toolTip1.SetToolTip(this.pbculture, resources.GetString("pbculture.ToolTip"));
			this.pbculture.Visible = ((bool)(resources.GetObject("pbculture.Visible")));
			this.pbculture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbculture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbculture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbfood
			// 
			this.pbfood.AccessibleDescription = resources.GetString("pbfood.AccessibleDescription");
			this.pbfood.AccessibleName = resources.GetString("pbfood.AccessibleName");
			this.pbfood.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbfood.Anchor")));
			this.pbfood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfood.BackgroundImage")));
			this.pbfood.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbfood.Dock")));
			this.pbfood.Enabled = ((bool)(resources.GetObject("pbfood.Enabled")));
			this.pbfood.Font = ((System.Drawing.Font)(resources.GetObject("pbfood.Font")));
			this.pbfood.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbfood.ImeMode")));
			this.pbfood.Location = ((System.Drawing.Point)(resources.GetObject("pbfood.Location")));
			this.pbfood.Maximum = 10;
			this.pbfood.Name = "pbfood";
			this.pbfood.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbfood.RightToLeft")));
			this.pbfood.Size = ((System.Drawing.Size)(resources.GetObject("pbfood.Size")));
			this.pbfood.Step = 1;
			this.pbfood.TabIndex = ((int)(resources.GetObject("pbfood.TabIndex")));
			this.pbfood.Text = resources.GetString("pbfood.Text");
			this.toolTip1.SetToolTip(this.pbfood, resources.GetString("pbfood.ToolTip"));
			this.pbfood.Visible = ((bool)(resources.GetObject("pbfood.Visible")));
			this.pbfood.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbfood.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbfood.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbentertainment
			// 
			this.pbentertainment.AccessibleDescription = resources.GetString("pbentertainment.AccessibleDescription");
			this.pbentertainment.AccessibleName = resources.GetString("pbentertainment.AccessibleName");
			this.pbentertainment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbentertainment.Anchor")));
			this.pbentertainment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbentertainment.BackgroundImage")));
			this.pbentertainment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbentertainment.Dock")));
			this.pbentertainment.Enabled = ((bool)(resources.GetObject("pbentertainment.Enabled")));
			this.pbentertainment.Font = ((System.Drawing.Font)(resources.GetObject("pbentertainment.Font")));
			this.pbentertainment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbentertainment.ImeMode")));
			this.pbentertainment.Location = ((System.Drawing.Point)(resources.GetObject("pbentertainment.Location")));
			this.pbentertainment.Maximum = 10;
			this.pbentertainment.Name = "pbentertainment";
			this.pbentertainment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbentertainment.RightToLeft")));
			this.pbentertainment.Size = ((System.Drawing.Size)(resources.GetObject("pbentertainment.Size")));
			this.pbentertainment.Step = 1;
			this.pbentertainment.TabIndex = ((int)(resources.GetObject("pbentertainment.TabIndex")));
			this.pbentertainment.Text = resources.GetString("pbentertainment.Text");
			this.toolTip1.SetToolTip(this.pbentertainment, resources.GetString("pbentertainment.ToolTip"));
			this.pbentertainment.Visible = ((bool)(resources.GetObject("pbentertainment.Visible")));
			this.pbentertainment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbentertainment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbentertainment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbparanormal
			// 
			this.pbparanormal.AccessibleDescription = resources.GetString("pbparanormal.AccessibleDescription");
			this.pbparanormal.AccessibleName = resources.GetString("pbparanormal.AccessibleName");
			this.pbparanormal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbparanormal.Anchor")));
			this.pbparanormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbparanormal.BackgroundImage")));
			this.pbparanormal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbparanormal.Dock")));
			this.pbparanormal.Enabled = ((bool)(resources.GetObject("pbparanormal.Enabled")));
			this.pbparanormal.Font = ((System.Drawing.Font)(resources.GetObject("pbparanormal.Font")));
			this.pbparanormal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbparanormal.ImeMode")));
			this.pbparanormal.Location = ((System.Drawing.Point)(resources.GetObject("pbparanormal.Location")));
			this.pbparanormal.Maximum = 10;
			this.pbparanormal.Name = "pbparanormal";
			this.pbparanormal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbparanormal.RightToLeft")));
			this.pbparanormal.Size = ((System.Drawing.Size)(resources.GetObject("pbparanormal.Size")));
			this.pbparanormal.Step = 1;
			this.pbparanormal.TabIndex = ((int)(resources.GetObject("pbparanormal.TabIndex")));
			this.pbparanormal.Text = resources.GetString("pbparanormal.Text");
			this.toolTip1.SetToolTip(this.pbparanormal, resources.GetString("pbparanormal.ToolTip"));
			this.pbparanormal.Visible = ((bool)(resources.GetObject("pbparanormal.Visible")));
			this.pbparanormal.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbparanormal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbparanormal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbwork
			// 
			this.pbwork.AccessibleDescription = resources.GetString("pbwork.AccessibleDescription");
			this.pbwork.AccessibleName = resources.GetString("pbwork.AccessibleName");
			this.pbwork.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbwork.Anchor")));
			this.pbwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbwork.BackgroundImage")));
			this.pbwork.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbwork.Dock")));
			this.pbwork.Enabled = ((bool)(resources.GetObject("pbwork.Enabled")));
			this.pbwork.Font = ((System.Drawing.Font)(resources.GetObject("pbwork.Font")));
			this.pbwork.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbwork.ImeMode")));
			this.pbwork.Location = ((System.Drawing.Point)(resources.GetObject("pbwork.Location")));
			this.pbwork.Maximum = 10;
			this.pbwork.Name = "pbwork";
			this.pbwork.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbwork.RightToLeft")));
			this.pbwork.Size = ((System.Drawing.Size)(resources.GetObject("pbwork.Size")));
			this.pbwork.Step = 1;
			this.pbwork.TabIndex = ((int)(resources.GetObject("pbwork.TabIndex")));
			this.pbwork.Text = resources.GetString("pbwork.Text");
			this.toolTip1.SetToolTip(this.pbwork, resources.GetString("pbwork.ToolTip"));
			this.pbwork.Visible = ((bool)(resources.GetObject("pbwork.Visible")));
			this.pbwork.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbwork.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbwork.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbtoys
			// 
			this.tbtoys.AccessibleDescription = resources.GetString("tbtoys.AccessibleDescription");
			this.tbtoys.AccessibleName = resources.GetString("tbtoys.AccessibleName");
			this.tbtoys.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbtoys.Anchor")));
			this.tbtoys.AutoSize = ((bool)(resources.GetObject("tbtoys.AutoSize")));
			this.tbtoys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbtoys.BackgroundImage")));
			this.tbtoys.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbtoys.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbtoys.Dock")));
			this.tbtoys.Enabled = ((bool)(resources.GetObject("tbtoys.Enabled")));
			this.tbtoys.Font = ((System.Drawing.Font)(resources.GetObject("tbtoys.Font")));
			this.tbtoys.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbtoys.ImeMode")));
			this.tbtoys.Location = ((System.Drawing.Point)(resources.GetObject("tbtoys.Location")));
			this.tbtoys.MaxLength = ((int)(resources.GetObject("tbtoys.MaxLength")));
			this.tbtoys.Multiline = ((bool)(resources.GetObject("tbtoys.Multiline")));
			this.tbtoys.Name = "tbtoys";
			this.tbtoys.PasswordChar = ((char)(resources.GetObject("tbtoys.PasswordChar")));
			this.tbtoys.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbtoys.RightToLeft")));
			this.tbtoys.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbtoys.ScrollBars")));
			this.tbtoys.Size = ((System.Drawing.Size)(resources.GetObject("tbtoys.Size")));
			this.tbtoys.TabIndex = ((int)(resources.GetObject("tbtoys.TabIndex")));
			this.tbtoys.Text = resources.GetString("tbtoys.Text");
			this.tbtoys.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbtoys.TextAlign")));
			this.toolTip1.SetToolTip(this.tbtoys, resources.GetString("tbtoys.ToolTip"));
			this.tbtoys.Visible = ((bool)(resources.GetObject("tbtoys.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbtoys, true);
			this.tbtoys.WordWrap = ((bool)(resources.GetObject("tbtoys.WordWrap")));
			this.tbtoys.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbtoys.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbschool
			// 
			this.tbschool.AccessibleDescription = resources.GetString("tbschool.AccessibleDescription");
			this.tbschool.AccessibleName = resources.GetString("tbschool.AccessibleName");
			this.tbschool.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbschool.Anchor")));
			this.tbschool.AutoSize = ((bool)(resources.GetObject("tbschool.AutoSize")));
			this.tbschool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbschool.BackgroundImage")));
			this.tbschool.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbschool.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbschool.Dock")));
			this.tbschool.Enabled = ((bool)(resources.GetObject("tbschool.Enabled")));
			this.tbschool.Font = ((System.Drawing.Font)(resources.GetObject("tbschool.Font")));
			this.tbschool.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbschool.ImeMode")));
			this.tbschool.Location = ((System.Drawing.Point)(resources.GetObject("tbschool.Location")));
			this.tbschool.MaxLength = ((int)(resources.GetObject("tbschool.MaxLength")));
			this.tbschool.Multiline = ((bool)(resources.GetObject("tbschool.Multiline")));
			this.tbschool.Name = "tbschool";
			this.tbschool.PasswordChar = ((char)(resources.GetObject("tbschool.PasswordChar")));
			this.tbschool.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbschool.RightToLeft")));
			this.tbschool.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbschool.ScrollBars")));
			this.tbschool.Size = ((System.Drawing.Size)(resources.GetObject("tbschool.Size")));
			this.tbschool.TabIndex = ((int)(resources.GetObject("tbschool.TabIndex")));
			this.tbschool.Text = resources.GetString("tbschool.Text");
			this.tbschool.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbschool.TextAlign")));
			this.toolTip1.SetToolTip(this.tbschool, resources.GetString("tbschool.ToolTip"));
			this.tbschool.Visible = ((bool)(resources.GetObject("tbschool.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbschool, true);
			this.tbschool.WordWrap = ((bool)(resources.GetObject("tbschool.WordWrap")));
			this.tbschool.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbschool.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbanimals
			// 
			this.tbanimals.AccessibleDescription = resources.GetString("tbanimals.AccessibleDescription");
			this.tbanimals.AccessibleName = resources.GetString("tbanimals.AccessibleName");
			this.tbanimals.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbanimals.Anchor")));
			this.tbanimals.AutoSize = ((bool)(resources.GetObject("tbanimals.AutoSize")));
			this.tbanimals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbanimals.BackgroundImage")));
			this.tbanimals.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbanimals.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbanimals.Dock")));
			this.tbanimals.Enabled = ((bool)(resources.GetObject("tbanimals.Enabled")));
			this.tbanimals.Font = ((System.Drawing.Font)(resources.GetObject("tbanimals.Font")));
			this.tbanimals.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbanimals.ImeMode")));
			this.tbanimals.Location = ((System.Drawing.Point)(resources.GetObject("tbanimals.Location")));
			this.tbanimals.MaxLength = ((int)(resources.GetObject("tbanimals.MaxLength")));
			this.tbanimals.Multiline = ((bool)(resources.GetObject("tbanimals.Multiline")));
			this.tbanimals.Name = "tbanimals";
			this.tbanimals.PasswordChar = ((char)(resources.GetObject("tbanimals.PasswordChar")));
			this.tbanimals.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbanimals.RightToLeft")));
			this.tbanimals.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbanimals.ScrollBars")));
			this.tbanimals.Size = ((System.Drawing.Size)(resources.GetObject("tbanimals.Size")));
			this.tbanimals.TabIndex = ((int)(resources.GetObject("tbanimals.TabIndex")));
			this.tbanimals.Text = resources.GetString("tbanimals.Text");
			this.tbanimals.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbanimals.TextAlign")));
			this.toolTip1.SetToolTip(this.tbanimals, resources.GetString("tbanimals.ToolTip"));
			this.tbanimals.Visible = ((bool)(resources.GetObject("tbanimals.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbanimals, true);
			this.tbanimals.WordWrap = ((bool)(resources.GetObject("tbanimals.WordWrap")));
			this.tbanimals.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbanimals.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbweather
			// 
			this.tbweather.AccessibleDescription = resources.GetString("tbweather.AccessibleDescription");
			this.tbweather.AccessibleName = resources.GetString("tbweather.AccessibleName");
			this.tbweather.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbweather.Anchor")));
			this.tbweather.AutoSize = ((bool)(resources.GetObject("tbweather.AutoSize")));
			this.tbweather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbweather.BackgroundImage")));
			this.tbweather.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbweather.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbweather.Dock")));
			this.tbweather.Enabled = ((bool)(resources.GetObject("tbweather.Enabled")));
			this.tbweather.Font = ((System.Drawing.Font)(resources.GetObject("tbweather.Font")));
			this.tbweather.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbweather.ImeMode")));
			this.tbweather.Location = ((System.Drawing.Point)(resources.GetObject("tbweather.Location")));
			this.tbweather.MaxLength = ((int)(resources.GetObject("tbweather.MaxLength")));
			this.tbweather.Multiline = ((bool)(resources.GetObject("tbweather.Multiline")));
			this.tbweather.Name = "tbweather";
			this.tbweather.PasswordChar = ((char)(resources.GetObject("tbweather.PasswordChar")));
			this.tbweather.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbweather.RightToLeft")));
			this.tbweather.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbweather.ScrollBars")));
			this.tbweather.Size = ((System.Drawing.Size)(resources.GetObject("tbweather.Size")));
			this.tbweather.TabIndex = ((int)(resources.GetObject("tbweather.TabIndex")));
			this.tbweather.Text = resources.GetString("tbweather.Text");
			this.tbweather.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbweather.TextAlign")));
			this.toolTip1.SetToolTip(this.tbweather, resources.GetString("tbweather.ToolTip"));
			this.tbweather.Visible = ((bool)(resources.GetObject("tbweather.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbweather, true);
			this.tbweather.WordWrap = ((bool)(resources.GetObject("tbweather.WordWrap")));
			this.tbweather.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbweather.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label33
			// 
			this.label33.AccessibleDescription = resources.GetString("label33.AccessibleDescription");
			this.label33.AccessibleName = resources.GetString("label33.AccessibleName");
			this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label33.Anchor")));
			this.label33.AutoSize = ((bool)(resources.GetObject("label33.AutoSize")));
			this.label33.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label33.Dock")));
			this.label33.Enabled = ((bool)(resources.GetObject("label33.Enabled")));
			this.label33.Font = ((System.Drawing.Font)(resources.GetObject("label33.Font")));
			this.label33.Image = ((System.Drawing.Image)(resources.GetObject("label33.Image")));
			this.label33.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label33.ImageAlign")));
			this.label33.ImageIndex = ((int)(resources.GetObject("label33.ImageIndex")));
			this.label33.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label33.ImeMode")));
			this.label33.Location = ((System.Drawing.Point)(resources.GetObject("label33.Location")));
			this.label33.Name = "label33";
			this.label33.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label33.RightToLeft")));
			this.label33.Size = ((System.Drawing.Size)(resources.GetObject("label33.Size")));
			this.label33.TabIndex = ((int)(resources.GetObject("label33.TabIndex")));
			this.label33.Text = resources.GetString("label33.Text");
			this.label33.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label33.TextAlign")));
			this.toolTip1.SetToolTip(this.label33, resources.GetString("label33.ToolTip"));
			this.label33.Visible = ((bool)(resources.GetObject("label33.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label33, true);
			// 
			// tbwork
			// 
			this.tbwork.AccessibleDescription = resources.GetString("tbwork.AccessibleDescription");
			this.tbwork.AccessibleName = resources.GetString("tbwork.AccessibleName");
			this.tbwork.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbwork.Anchor")));
			this.tbwork.AutoSize = ((bool)(resources.GetObject("tbwork.AutoSize")));
			this.tbwork.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbwork.BackgroundImage")));
			this.tbwork.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbwork.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbwork.Dock")));
			this.tbwork.Enabled = ((bool)(resources.GetObject("tbwork.Enabled")));
			this.tbwork.Font = ((System.Drawing.Font)(resources.GetObject("tbwork.Font")));
			this.tbwork.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbwork.ImeMode")));
			this.tbwork.Location = ((System.Drawing.Point)(resources.GetObject("tbwork.Location")));
			this.tbwork.MaxLength = ((int)(resources.GetObject("tbwork.MaxLength")));
			this.tbwork.Multiline = ((bool)(resources.GetObject("tbwork.Multiline")));
			this.tbwork.Name = "tbwork";
			this.tbwork.PasswordChar = ((char)(resources.GetObject("tbwork.PasswordChar")));
			this.tbwork.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbwork.RightToLeft")));
			this.tbwork.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbwork.ScrollBars")));
			this.tbwork.Size = ((System.Drawing.Size)(resources.GetObject("tbwork.Size")));
			this.tbwork.TabIndex = ((int)(resources.GetObject("tbwork.TabIndex")));
			this.tbwork.Text = resources.GetString("tbwork.Text");
			this.tbwork.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbwork.TextAlign")));
			this.toolTip1.SetToolTip(this.tbwork, resources.GetString("tbwork.ToolTip"));
			this.tbwork.Visible = ((bool)(resources.GetObject("tbwork.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbwork, true);
			this.tbwork.WordWrap = ((bool)(resources.GetObject("tbwork.WordWrap")));
			this.tbwork.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbwork.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label29
			// 
			this.label29.AccessibleDescription = resources.GetString("label29.AccessibleDescription");
			this.label29.AccessibleName = resources.GetString("label29.AccessibleName");
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label29.Anchor")));
			this.label29.AutoSize = ((bool)(resources.GetObject("label29.AutoSize")));
			this.label29.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label29.Dock")));
			this.label29.Enabled = ((bool)(resources.GetObject("label29.Enabled")));
			this.label29.Font = ((System.Drawing.Font)(resources.GetObject("label29.Font")));
			this.label29.Image = ((System.Drawing.Image)(resources.GetObject("label29.Image")));
			this.label29.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label29.ImageAlign")));
			this.label29.ImageIndex = ((int)(resources.GetObject("label29.ImageIndex")));
			this.label29.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label29.ImeMode")));
			this.label29.Location = ((System.Drawing.Point)(resources.GetObject("label29.Location")));
			this.label29.Name = "label29";
			this.label29.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label29.RightToLeft")));
			this.label29.Size = ((System.Drawing.Size)(resources.GetObject("label29.Size")));
			this.label29.TabIndex = ((int)(resources.GetObject("label29.TabIndex")));
			this.label29.Text = resources.GetString("label29.Text");
			this.label29.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label29.TextAlign")));
			this.toolTip1.SetToolTip(this.label29, resources.GetString("label29.ToolTip"));
			this.label29.Visible = ((bool)(resources.GetObject("label29.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label29, true);
			// 
			// label43
			// 
			this.label43.AccessibleDescription = resources.GetString("label43.AccessibleDescription");
			this.label43.AccessibleName = resources.GetString("label43.AccessibleName");
			this.label43.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label43.Anchor")));
			this.label43.AutoSize = ((bool)(resources.GetObject("label43.AutoSize")));
			this.label43.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label43.Dock")));
			this.label43.Enabled = ((bool)(resources.GetObject("label43.Enabled")));
			this.label43.Font = ((System.Drawing.Font)(resources.GetObject("label43.Font")));
			this.label43.Image = ((System.Drawing.Image)(resources.GetObject("label43.Image")));
			this.label43.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label43.ImageAlign")));
			this.label43.ImageIndex = ((int)(resources.GetObject("label43.ImageIndex")));
			this.label43.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label43.ImeMode")));
			this.label43.Location = ((System.Drawing.Point)(resources.GetObject("label43.Location")));
			this.label43.Name = "label43";
			this.label43.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label43.RightToLeft")));
			this.label43.Size = ((System.Drawing.Size)(resources.GetObject("label43.Size")));
			this.label43.TabIndex = ((int)(resources.GetObject("label43.TabIndex")));
			this.label43.Text = resources.GetString("label43.Text");
			this.label43.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label43.TextAlign")));
			this.toolTip1.SetToolTip(this.label43, resources.GetString("label43.ToolTip"));
			this.label43.Visible = ((bool)(resources.GetObject("label43.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label43, true);
			// 
			// tbtravel
			// 
			this.tbtravel.AccessibleDescription = resources.GetString("tbtravel.AccessibleDescription");
			this.tbtravel.AccessibleName = resources.GetString("tbtravel.AccessibleName");
			this.tbtravel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbtravel.Anchor")));
			this.tbtravel.AutoSize = ((bool)(resources.GetObject("tbtravel.AutoSize")));
			this.tbtravel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbtravel.BackgroundImage")));
			this.tbtravel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbtravel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbtravel.Dock")));
			this.tbtravel.Enabled = ((bool)(resources.GetObject("tbtravel.Enabled")));
			this.tbtravel.Font = ((System.Drawing.Font)(resources.GetObject("tbtravel.Font")));
			this.tbtravel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbtravel.ImeMode")));
			this.tbtravel.Location = ((System.Drawing.Point)(resources.GetObject("tbtravel.Location")));
			this.tbtravel.MaxLength = ((int)(resources.GetObject("tbtravel.MaxLength")));
			this.tbtravel.Multiline = ((bool)(resources.GetObject("tbtravel.Multiline")));
			this.tbtravel.Name = "tbtravel";
			this.tbtravel.PasswordChar = ((char)(resources.GetObject("tbtravel.PasswordChar")));
			this.tbtravel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbtravel.RightToLeft")));
			this.tbtravel.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbtravel.ScrollBars")));
			this.tbtravel.Size = ((System.Drawing.Size)(resources.GetObject("tbtravel.Size")));
			this.tbtravel.TabIndex = ((int)(resources.GetObject("tbtravel.TabIndex")));
			this.tbtravel.Text = resources.GetString("tbtravel.Text");
			this.tbtravel.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbtravel.TextAlign")));
			this.toolTip1.SetToolTip(this.tbtravel, resources.GetString("tbtravel.ToolTip"));
			this.tbtravel.Visible = ((bool)(resources.GetObject("tbtravel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbtravel, true);
			this.tbtravel.WordWrap = ((bool)(resources.GetObject("tbtravel.WordWrap")));
			this.tbtravel.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbtravel.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label42
			// 
			this.label42.AccessibleDescription = resources.GetString("label42.AccessibleDescription");
			this.label42.AccessibleName = resources.GetString("label42.AccessibleName");
			this.label42.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label42.Anchor")));
			this.label42.AutoSize = ((bool)(resources.GetObject("label42.AutoSize")));
			this.label42.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label42.Dock")));
			this.label42.Enabled = ((bool)(resources.GetObject("label42.Enabled")));
			this.label42.Font = ((System.Drawing.Font)(resources.GetObject("label42.Font")));
			this.label42.Image = ((System.Drawing.Image)(resources.GetObject("label42.Image")));
			this.label42.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label42.ImageAlign")));
			this.label42.ImageIndex = ((int)(resources.GetObject("label42.ImageIndex")));
			this.label42.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label42.ImeMode")));
			this.label42.Location = ((System.Drawing.Point)(resources.GetObject("label42.Location")));
			this.label42.Name = "label42";
			this.label42.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label42.RightToLeft")));
			this.label42.Size = ((System.Drawing.Size)(resources.GetObject("label42.Size")));
			this.label42.TabIndex = ((int)(resources.GetObject("label42.TabIndex")));
			this.label42.Text = resources.GetString("label42.Text");
			this.label42.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label42.TextAlign")));
			this.toolTip1.SetToolTip(this.label42, resources.GetString("label42.ToolTip"));
			this.label42.Visible = ((bool)(resources.GetObject("label42.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label42, true);
			// 
			// label40
			// 
			this.label40.AccessibleDescription = resources.GetString("label40.AccessibleDescription");
			this.label40.AccessibleName = resources.GetString("label40.AccessibleName");
			this.label40.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label40.Anchor")));
			this.label40.AutoSize = ((bool)(resources.GetObject("label40.AutoSize")));
			this.label40.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label40.Dock")));
			this.label40.Enabled = ((bool)(resources.GetObject("label40.Enabled")));
			this.label40.Font = ((System.Drawing.Font)(resources.GetObject("label40.Font")));
			this.label40.Image = ((System.Drawing.Image)(resources.GetObject("label40.Image")));
			this.label40.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label40.ImageAlign")));
			this.label40.ImageIndex = ((int)(resources.GetObject("label40.ImageIndex")));
			this.label40.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label40.ImeMode")));
			this.label40.Location = ((System.Drawing.Point)(resources.GetObject("label40.Location")));
			this.label40.Name = "label40";
			this.label40.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label40.RightToLeft")));
			this.label40.Size = ((System.Drawing.Size)(resources.GetObject("label40.Size")));
			this.label40.TabIndex = ((int)(resources.GetObject("label40.TabIndex")));
			this.label40.Text = resources.GetString("label40.Text");
			this.label40.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label40.TextAlign")));
			this.toolTip1.SetToolTip(this.label40, resources.GetString("label40.ToolTip"));
			this.label40.Visible = ((bool)(resources.GetObject("label40.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label40, true);
			// 
			// label41
			// 
			this.label41.AccessibleDescription = resources.GetString("label41.AccessibleDescription");
			this.label41.AccessibleName = resources.GetString("label41.AccessibleName");
			this.label41.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label41.Anchor")));
			this.label41.AutoSize = ((bool)(resources.GetObject("label41.AutoSize")));
			this.label41.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label41.Dock")));
			this.label41.Enabled = ((bool)(resources.GetObject("label41.Enabled")));
			this.label41.Font = ((System.Drawing.Font)(resources.GetObject("label41.Font")));
			this.label41.Image = ((System.Drawing.Image)(resources.GetObject("label41.Image")));
			this.label41.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label41.ImageAlign")));
			this.label41.ImageIndex = ((int)(resources.GetObject("label41.ImageIndex")));
			this.label41.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label41.ImeMode")));
			this.label41.Location = ((System.Drawing.Point)(resources.GetObject("label41.Location")));
			this.label41.Name = "label41";
			this.label41.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label41.RightToLeft")));
			this.label41.Size = ((System.Drawing.Size)(resources.GetObject("label41.Size")));
			this.label41.TabIndex = ((int)(resources.GetObject("label41.TabIndex")));
			this.label41.Text = resources.GetString("label41.Text");
			this.label41.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label41.TextAlign")));
			this.toolTip1.SetToolTip(this.label41, resources.GetString("label41.ToolTip"));
			this.label41.Visible = ((bool)(resources.GetObject("label41.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label41, true);
			// 
			// tbcrime
			// 
			this.tbcrime.AccessibleDescription = resources.GetString("tbcrime.AccessibleDescription");
			this.tbcrime.AccessibleName = resources.GetString("tbcrime.AccessibleName");
			this.tbcrime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcrime.Anchor")));
			this.tbcrime.AutoSize = ((bool)(resources.GetObject("tbcrime.AutoSize")));
			this.tbcrime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcrime.BackgroundImage")));
			this.tbcrime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcrime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcrime.Dock")));
			this.tbcrime.Enabled = ((bool)(resources.GetObject("tbcrime.Enabled")));
			this.tbcrime.Font = ((System.Drawing.Font)(resources.GetObject("tbcrime.Font")));
			this.tbcrime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcrime.ImeMode")));
			this.tbcrime.Location = ((System.Drawing.Point)(resources.GetObject("tbcrime.Location")));
			this.tbcrime.MaxLength = ((int)(resources.GetObject("tbcrime.MaxLength")));
			this.tbcrime.Multiline = ((bool)(resources.GetObject("tbcrime.Multiline")));
			this.tbcrime.Name = "tbcrime";
			this.tbcrime.PasswordChar = ((char)(resources.GetObject("tbcrime.PasswordChar")));
			this.tbcrime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcrime.RightToLeft")));
			this.tbcrime.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcrime.ScrollBars")));
			this.tbcrime.Size = ((System.Drawing.Size)(resources.GetObject("tbcrime.Size")));
			this.tbcrime.TabIndex = ((int)(resources.GetObject("tbcrime.TabIndex")));
			this.tbcrime.Text = resources.GetString("tbcrime.Text");
			this.tbcrime.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcrime.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcrime, resources.GetString("tbcrime.ToolTip"));
			this.tbcrime.Visible = ((bool)(resources.GetObject("tbcrime.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcrime, true);
			this.tbcrime.WordWrap = ((bool)(resources.GetObject("tbcrime.WordWrap")));
			this.tbcrime.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcrime.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbsports
			// 
			this.tbsports.AccessibleDescription = resources.GetString("tbsports.AccessibleDescription");
			this.tbsports.AccessibleName = resources.GetString("tbsports.AccessibleName");
			this.tbsports.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsports.Anchor")));
			this.tbsports.AutoSize = ((bool)(resources.GetObject("tbsports.AutoSize")));
			this.tbsports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsports.BackgroundImage")));
			this.tbsports.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbsports.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsports.Dock")));
			this.tbsports.Enabled = ((bool)(resources.GetObject("tbsports.Enabled")));
			this.tbsports.Font = ((System.Drawing.Font)(resources.GetObject("tbsports.Font")));
			this.tbsports.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsports.ImeMode")));
			this.tbsports.Location = ((System.Drawing.Point)(resources.GetObject("tbsports.Location")));
			this.tbsports.MaxLength = ((int)(resources.GetObject("tbsports.MaxLength")));
			this.tbsports.Multiline = ((bool)(resources.GetObject("tbsports.Multiline")));
			this.tbsports.Name = "tbsports";
			this.tbsports.PasswordChar = ((char)(resources.GetObject("tbsports.PasswordChar")));
			this.tbsports.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsports.RightToLeft")));
			this.tbsports.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsports.ScrollBars")));
			this.tbsports.Size = ((System.Drawing.Size)(resources.GetObject("tbsports.Size")));
			this.tbsports.TabIndex = ((int)(resources.GetObject("tbsports.TabIndex")));
			this.tbsports.Text = resources.GetString("tbsports.Text");
			this.tbsports.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsports.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsports, resources.GetString("tbsports.ToolTip"));
			this.tbsports.Visible = ((bool)(resources.GetObject("tbsports.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsports, true);
			this.tbsports.WordWrap = ((bool)(resources.GetObject("tbsports.WordWrap")));
			this.tbsports.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbsports.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbfashion
			// 
			this.tbfashion.AccessibleDescription = resources.GetString("tbfashion.AccessibleDescription");
			this.tbfashion.AccessibleName = resources.GetString("tbfashion.AccessibleName");
			this.tbfashion.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfashion.Anchor")));
			this.tbfashion.AutoSize = ((bool)(resources.GetObject("tbfashion.AutoSize")));
			this.tbfashion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfashion.BackgroundImage")));
			this.tbfashion.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbfashion.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfashion.Dock")));
			this.tbfashion.Enabled = ((bool)(resources.GetObject("tbfashion.Enabled")));
			this.tbfashion.Font = ((System.Drawing.Font)(resources.GetObject("tbfashion.Font")));
			this.tbfashion.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfashion.ImeMode")));
			this.tbfashion.Location = ((System.Drawing.Point)(resources.GetObject("tbfashion.Location")));
			this.tbfashion.MaxLength = ((int)(resources.GetObject("tbfashion.MaxLength")));
			this.tbfashion.Multiline = ((bool)(resources.GetObject("tbfashion.Multiline")));
			this.tbfashion.Name = "tbfashion";
			this.tbfashion.PasswordChar = ((char)(resources.GetObject("tbfashion.PasswordChar")));
			this.tbfashion.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfashion.RightToLeft")));
			this.tbfashion.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfashion.ScrollBars")));
			this.tbfashion.Size = ((System.Drawing.Size)(resources.GetObject("tbfashion.Size")));
			this.tbfashion.TabIndex = ((int)(resources.GetObject("tbfashion.TabIndex")));
			this.tbfashion.Text = resources.GetString("tbfashion.Text");
			this.tbfashion.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfashion.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfashion, resources.GetString("tbfashion.ToolTip"));
			this.tbfashion.Visible = ((bool)(resources.GetObject("tbfashion.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfashion, true);
			this.tbfashion.WordWrap = ((bool)(resources.GetObject("tbfashion.WordWrap")));
			this.tbfashion.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbfashion.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbhealth
			// 
			this.tbhealth.AccessibleDescription = resources.GetString("tbhealth.AccessibleDescription");
			this.tbhealth.AccessibleName = resources.GetString("tbhealth.AccessibleName");
			this.tbhealth.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbhealth.Anchor")));
			this.tbhealth.AutoSize = ((bool)(resources.GetObject("tbhealth.AutoSize")));
			this.tbhealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbhealth.BackgroundImage")));
			this.tbhealth.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbhealth.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbhealth.Dock")));
			this.tbhealth.Enabled = ((bool)(resources.GetObject("tbhealth.Enabled")));
			this.tbhealth.Font = ((System.Drawing.Font)(resources.GetObject("tbhealth.Font")));
			this.tbhealth.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbhealth.ImeMode")));
			this.tbhealth.Location = ((System.Drawing.Point)(resources.GetObject("tbhealth.Location")));
			this.tbhealth.MaxLength = ((int)(resources.GetObject("tbhealth.MaxLength")));
			this.tbhealth.Multiline = ((bool)(resources.GetObject("tbhealth.Multiline")));
			this.tbhealth.Name = "tbhealth";
			this.tbhealth.PasswordChar = ((char)(resources.GetObject("tbhealth.PasswordChar")));
			this.tbhealth.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbhealth.RightToLeft")));
			this.tbhealth.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbhealth.ScrollBars")));
			this.tbhealth.Size = ((System.Drawing.Size)(resources.GetObject("tbhealth.Size")));
			this.tbhealth.TabIndex = ((int)(resources.GetObject("tbhealth.TabIndex")));
			this.tbhealth.Text = resources.GetString("tbhealth.Text");
			this.tbhealth.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbhealth.TextAlign")));
			this.toolTip1.SetToolTip(this.tbhealth, resources.GetString("tbhealth.ToolTip"));
			this.tbhealth.Visible = ((bool)(resources.GetObject("tbhealth.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbhealth, true);
			this.tbhealth.WordWrap = ((bool)(resources.GetObject("tbhealth.WordWrap")));
			this.tbhealth.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbhealth.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbfood
			// 
			this.tbfood.AccessibleDescription = resources.GetString("tbfood.AccessibleDescription");
			this.tbfood.AccessibleName = resources.GetString("tbfood.AccessibleName");
			this.tbfood.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfood.Anchor")));
			this.tbfood.AutoSize = ((bool)(resources.GetObject("tbfood.AutoSize")));
			this.tbfood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfood.BackgroundImage")));
			this.tbfood.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbfood.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfood.Dock")));
			this.tbfood.Enabled = ((bool)(resources.GetObject("tbfood.Enabled")));
			this.tbfood.Font = ((System.Drawing.Font)(resources.GetObject("tbfood.Font")));
			this.tbfood.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfood.ImeMode")));
			this.tbfood.Location = ((System.Drawing.Point)(resources.GetObject("tbfood.Location")));
			this.tbfood.MaxLength = ((int)(resources.GetObject("tbfood.MaxLength")));
			this.tbfood.Multiline = ((bool)(resources.GetObject("tbfood.Multiline")));
			this.tbfood.Name = "tbfood";
			this.tbfood.PasswordChar = ((char)(resources.GetObject("tbfood.PasswordChar")));
			this.tbfood.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfood.RightToLeft")));
			this.tbfood.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfood.ScrollBars")));
			this.tbfood.Size = ((System.Drawing.Size)(resources.GetObject("tbfood.Size")));
			this.tbfood.TabIndex = ((int)(resources.GetObject("tbfood.TabIndex")));
			this.tbfood.Text = resources.GetString("tbfood.Text");
			this.tbfood.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfood.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfood, resources.GetString("tbfood.ToolTip"));
			this.tbfood.Visible = ((bool)(resources.GetObject("tbfood.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfood, true);
			this.tbfood.WordWrap = ((bool)(resources.GetObject("tbfood.WordWrap")));
			this.tbfood.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbfood.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbpolitics
			// 
			this.tbpolitics.AccessibleDescription = resources.GetString("tbpolitics.AccessibleDescription");
			this.tbpolitics.AccessibleName = resources.GetString("tbpolitics.AccessibleName");
			this.tbpolitics.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbpolitics.Anchor")));
			this.tbpolitics.AutoSize = ((bool)(resources.GetObject("tbpolitics.AutoSize")));
			this.tbpolitics.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbpolitics.BackgroundImage")));
			this.tbpolitics.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbpolitics.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbpolitics.Dock")));
			this.tbpolitics.Enabled = ((bool)(resources.GetObject("tbpolitics.Enabled")));
			this.tbpolitics.Font = ((System.Drawing.Font)(resources.GetObject("tbpolitics.Font")));
			this.tbpolitics.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbpolitics.ImeMode")));
			this.tbpolitics.Location = ((System.Drawing.Point)(resources.GetObject("tbpolitics.Location")));
			this.tbpolitics.MaxLength = ((int)(resources.GetObject("tbpolitics.MaxLength")));
			this.tbpolitics.Multiline = ((bool)(resources.GetObject("tbpolitics.Multiline")));
			this.tbpolitics.Name = "tbpolitics";
			this.tbpolitics.PasswordChar = ((char)(resources.GetObject("tbpolitics.PasswordChar")));
			this.tbpolitics.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbpolitics.RightToLeft")));
			this.tbpolitics.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbpolitics.ScrollBars")));
			this.tbpolitics.Size = ((System.Drawing.Size)(resources.GetObject("tbpolitics.Size")));
			this.tbpolitics.TabIndex = ((int)(resources.GetObject("tbpolitics.TabIndex")));
			this.tbpolitics.Text = resources.GetString("tbpolitics.Text");
			this.tbpolitics.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbpolitics.TextAlign")));
			this.toolTip1.SetToolTip(this.tbpolitics, resources.GetString("tbpolitics.ToolTip"));
			this.tbpolitics.Visible = ((bool)(resources.GetObject("tbpolitics.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbpolitics, true);
			this.tbpolitics.WordWrap = ((bool)(resources.GetObject("tbpolitics.WordWrap")));
			this.tbpolitics.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbpolitics.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label31
			// 
			this.label31.AccessibleDescription = resources.GetString("label31.AccessibleDescription");
			this.label31.AccessibleName = resources.GetString("label31.AccessibleName");
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label31.Anchor")));
			this.label31.AutoSize = ((bool)(resources.GetObject("label31.AutoSize")));
			this.label31.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label31.Dock")));
			this.label31.Enabled = ((bool)(resources.GetObject("label31.Enabled")));
			this.label31.Font = ((System.Drawing.Font)(resources.GetObject("label31.Font")));
			this.label31.Image = ((System.Drawing.Image)(resources.GetObject("label31.Image")));
			this.label31.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label31.ImageAlign")));
			this.label31.ImageIndex = ((int)(resources.GetObject("label31.ImageIndex")));
			this.label31.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label31.ImeMode")));
			this.label31.Location = ((System.Drawing.Point)(resources.GetObject("label31.Location")));
			this.label31.Name = "label31";
			this.label31.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label31.RightToLeft")));
			this.label31.Size = ((System.Drawing.Size)(resources.GetObject("label31.Size")));
			this.label31.TabIndex = ((int)(resources.GetObject("label31.TabIndex")));
			this.label31.Text = resources.GetString("label31.Text");
			this.label31.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label31.TextAlign")));
			this.toolTip1.SetToolTip(this.label31, resources.GetString("label31.ToolTip"));
			this.label31.Visible = ((bool)(resources.GetObject("label31.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label31, true);
			// 
			// tbmonei
			// 
			this.tbmonei.AccessibleDescription = resources.GetString("tbmonei.AccessibleDescription");
			this.tbmonei.AccessibleName = resources.GetString("tbmonei.AccessibleName");
			this.tbmonei.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmonei.Anchor")));
			this.tbmonei.AutoSize = ((bool)(resources.GetObject("tbmonei.AutoSize")));
			this.tbmonei.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmonei.BackgroundImage")));
			this.tbmonei.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbmonei.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmonei.Dock")));
			this.tbmonei.Enabled = ((bool)(resources.GetObject("tbmonei.Enabled")));
			this.tbmonei.Font = ((System.Drawing.Font)(resources.GetObject("tbmonei.Font")));
			this.tbmonei.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmonei.ImeMode")));
			this.tbmonei.Location = ((System.Drawing.Point)(resources.GetObject("tbmonei.Location")));
			this.tbmonei.MaxLength = ((int)(resources.GetObject("tbmonei.MaxLength")));
			this.tbmonei.Multiline = ((bool)(resources.GetObject("tbmonei.Multiline")));
			this.tbmonei.Name = "tbmonei";
			this.tbmonei.PasswordChar = ((char)(resources.GetObject("tbmonei.PasswordChar")));
			this.tbmonei.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmonei.RightToLeft")));
			this.tbmonei.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmonei.ScrollBars")));
			this.tbmonei.Size = ((System.Drawing.Size)(resources.GetObject("tbmonei.Size")));
			this.tbmonei.TabIndex = ((int)(resources.GetObject("tbmonei.TabIndex")));
			this.tbmonei.Text = resources.GetString("tbmonei.Text");
			this.tbmonei.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmonei.TextAlign")));
			this.toolTip1.SetToolTip(this.tbmonei, resources.GetString("tbmonei.ToolTip"));
			this.tbmonei.Visible = ((bool)(resources.GetObject("tbmonei.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbmonei, true);
			this.tbmonei.WordWrap = ((bool)(resources.GetObject("tbmonei.WordWrap")));
			this.tbmonei.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbmonei.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label30
			// 
			this.label30.AccessibleDescription = resources.GetString("label30.AccessibleDescription");
			this.label30.AccessibleName = resources.GetString("label30.AccessibleName");
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label30.Anchor")));
			this.label30.AutoSize = ((bool)(resources.GetObject("label30.AutoSize")));
			this.label30.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label30.Dock")));
			this.label30.Enabled = ((bool)(resources.GetObject("label30.Enabled")));
			this.label30.Font = ((System.Drawing.Font)(resources.GetObject("label30.Font")));
			this.label30.Image = ((System.Drawing.Image)(resources.GetObject("label30.Image")));
			this.label30.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label30.ImageAlign")));
			this.label30.ImageIndex = ((int)(resources.GetObject("label30.ImageIndex")));
			this.label30.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label30.ImeMode")));
			this.label30.Location = ((System.Drawing.Point)(resources.GetObject("label30.Location")));
			this.label30.Name = "label30";
			this.label30.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label30.RightToLeft")));
			this.label30.Size = ((System.Drawing.Size)(resources.GetObject("label30.Size")));
			this.label30.TabIndex = ((int)(resources.GetObject("label30.TabIndex")));
			this.label30.Text = resources.GetString("label30.Text");
			this.label30.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label30.TextAlign")));
			this.toolTip1.SetToolTip(this.label30, resources.GetString("label30.ToolTip"));
			this.label30.Visible = ((bool)(resources.GetObject("label30.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label30, true);
			// 
			// tbculture
			// 
			this.tbculture.AccessibleDescription = resources.GetString("tbculture.AccessibleDescription");
			this.tbculture.AccessibleName = resources.GetString("tbculture.AccessibleName");
			this.tbculture.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbculture.Anchor")));
			this.tbculture.AutoSize = ((bool)(resources.GetObject("tbculture.AutoSize")));
			this.tbculture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbculture.BackgroundImage")));
			this.tbculture.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbculture.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbculture.Dock")));
			this.tbculture.Enabled = ((bool)(resources.GetObject("tbculture.Enabled")));
			this.tbculture.Font = ((System.Drawing.Font)(resources.GetObject("tbculture.Font")));
			this.tbculture.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbculture.ImeMode")));
			this.tbculture.Location = ((System.Drawing.Point)(resources.GetObject("tbculture.Location")));
			this.tbculture.MaxLength = ((int)(resources.GetObject("tbculture.MaxLength")));
			this.tbculture.Multiline = ((bool)(resources.GetObject("tbculture.Multiline")));
			this.tbculture.Name = "tbculture";
			this.tbculture.PasswordChar = ((char)(resources.GetObject("tbculture.PasswordChar")));
			this.tbculture.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbculture.RightToLeft")));
			this.tbculture.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbculture.ScrollBars")));
			this.tbculture.Size = ((System.Drawing.Size)(resources.GetObject("tbculture.Size")));
			this.tbculture.TabIndex = ((int)(resources.GetObject("tbculture.TabIndex")));
			this.tbculture.Text = resources.GetString("tbculture.Text");
			this.tbculture.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbculture.TextAlign")));
			this.toolTip1.SetToolTip(this.tbculture, resources.GetString("tbculture.ToolTip"));
			this.tbculture.Visible = ((bool)(resources.GetObject("tbculture.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbculture, true);
			this.tbculture.WordWrap = ((bool)(resources.GetObject("tbculture.WordWrap")));
			this.tbculture.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbculture.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbentertainment
			// 
			this.tbentertainment.AccessibleDescription = resources.GetString("tbentertainment.AccessibleDescription");
			this.tbentertainment.AccessibleName = resources.GetString("tbentertainment.AccessibleName");
			this.tbentertainment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbentertainment.Anchor")));
			this.tbentertainment.AutoSize = ((bool)(resources.GetObject("tbentertainment.AutoSize")));
			this.tbentertainment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbentertainment.BackgroundImage")));
			this.tbentertainment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbentertainment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbentertainment.Dock")));
			this.tbentertainment.Enabled = ((bool)(resources.GetObject("tbentertainment.Enabled")));
			this.tbentertainment.Font = ((System.Drawing.Font)(resources.GetObject("tbentertainment.Font")));
			this.tbentertainment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbentertainment.ImeMode")));
			this.tbentertainment.Location = ((System.Drawing.Point)(resources.GetObject("tbentertainment.Location")));
			this.tbentertainment.MaxLength = ((int)(resources.GetObject("tbentertainment.MaxLength")));
			this.tbentertainment.Multiline = ((bool)(resources.GetObject("tbentertainment.Multiline")));
			this.tbentertainment.Name = "tbentertainment";
			this.tbentertainment.PasswordChar = ((char)(resources.GetObject("tbentertainment.PasswordChar")));
			this.tbentertainment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbentertainment.RightToLeft")));
			this.tbentertainment.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbentertainment.ScrollBars")));
			this.tbentertainment.Size = ((System.Drawing.Size)(resources.GetObject("tbentertainment.Size")));
			this.tbentertainment.TabIndex = ((int)(resources.GetObject("tbentertainment.TabIndex")));
			this.tbentertainment.Text = resources.GetString("tbentertainment.Text");
			this.tbentertainment.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbentertainment.TextAlign")));
			this.toolTip1.SetToolTip(this.tbentertainment, resources.GetString("tbentertainment.ToolTip"));
			this.tbentertainment.Visible = ((bool)(resources.GetObject("tbentertainment.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbentertainment, true);
			this.tbentertainment.WordWrap = ((bool)(resources.GetObject("tbentertainment.WordWrap")));
			this.tbentertainment.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbentertainment.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbparanormal
			// 
			this.tbparanormal.AccessibleDescription = resources.GetString("tbparanormal.AccessibleDescription");
			this.tbparanormal.AccessibleName = resources.GetString("tbparanormal.AccessibleName");
			this.tbparanormal.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbparanormal.Anchor")));
			this.tbparanormal.AutoSize = ((bool)(resources.GetObject("tbparanormal.AutoSize")));
			this.tbparanormal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbparanormal.BackgroundImage")));
			this.tbparanormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbparanormal.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbparanormal.Dock")));
			this.tbparanormal.Enabled = ((bool)(resources.GetObject("tbparanormal.Enabled")));
			this.tbparanormal.Font = ((System.Drawing.Font)(resources.GetObject("tbparanormal.Font")));
			this.tbparanormal.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbparanormal.ImeMode")));
			this.tbparanormal.Location = ((System.Drawing.Point)(resources.GetObject("tbparanormal.Location")));
			this.tbparanormal.MaxLength = ((int)(resources.GetObject("tbparanormal.MaxLength")));
			this.tbparanormal.Multiline = ((bool)(resources.GetObject("tbparanormal.Multiline")));
			this.tbparanormal.Name = "tbparanormal";
			this.tbparanormal.PasswordChar = ((char)(resources.GetObject("tbparanormal.PasswordChar")));
			this.tbparanormal.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbparanormal.RightToLeft")));
			this.tbparanormal.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbparanormal.ScrollBars")));
			this.tbparanormal.Size = ((System.Drawing.Size)(resources.GetObject("tbparanormal.Size")));
			this.tbparanormal.TabIndex = ((int)(resources.GetObject("tbparanormal.TabIndex")));
			this.tbparanormal.Text = resources.GetString("tbparanormal.Text");
			this.tbparanormal.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbparanormal.TextAlign")));
			this.toolTip1.SetToolTip(this.tbparanormal, resources.GetString("tbparanormal.ToolTip"));
			this.tbparanormal.Visible = ((bool)(resources.GetObject("tbparanormal.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbparanormal, true);
			this.tbparanormal.WordWrap = ((bool)(resources.GetObject("tbparanormal.WordWrap")));
			this.tbparanormal.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbparanormal.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbenvironment
			// 
			this.tbenvironment.AccessibleDescription = resources.GetString("tbenvironment.AccessibleDescription");
			this.tbenvironment.AccessibleName = resources.GetString("tbenvironment.AccessibleName");
			this.tbenvironment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbenvironment.Anchor")));
			this.tbenvironment.AutoSize = ((bool)(resources.GetObject("tbenvironment.AutoSize")));
			this.tbenvironment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbenvironment.BackgroundImage")));
			this.tbenvironment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbenvironment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbenvironment.Dock")));
			this.tbenvironment.Enabled = ((bool)(resources.GetObject("tbenvironment.Enabled")));
			this.tbenvironment.Font = ((System.Drawing.Font)(resources.GetObject("tbenvironment.Font")));
			this.tbenvironment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbenvironment.ImeMode")));
			this.tbenvironment.Location = ((System.Drawing.Point)(resources.GetObject("tbenvironment.Location")));
			this.tbenvironment.MaxLength = ((int)(resources.GetObject("tbenvironment.MaxLength")));
			this.tbenvironment.Multiline = ((bool)(resources.GetObject("tbenvironment.Multiline")));
			this.tbenvironment.Name = "tbenvironment";
			this.tbenvironment.PasswordChar = ((char)(resources.GetObject("tbenvironment.PasswordChar")));
			this.tbenvironment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbenvironment.RightToLeft")));
			this.tbenvironment.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbenvironment.ScrollBars")));
			this.tbenvironment.Size = ((System.Drawing.Size)(resources.GetObject("tbenvironment.Size")));
			this.tbenvironment.TabIndex = ((int)(resources.GetObject("tbenvironment.TabIndex")));
			this.tbenvironment.Text = resources.GetString("tbenvironment.Text");
			this.tbenvironment.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbenvironment.TextAlign")));
			this.toolTip1.SetToolTip(this.tbenvironment, resources.GetString("tbenvironment.ToolTip"));
			this.tbenvironment.Visible = ((bool)(resources.GetObject("tbenvironment.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbenvironment, true);
			this.tbenvironment.WordWrap = ((bool)(resources.GetObject("tbenvironment.WordWrap")));
			this.tbenvironment.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbenvironment.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbscifi
			// 
			this.pbscifi.AccessibleDescription = resources.GetString("pbscifi.AccessibleDescription");
			this.pbscifi.AccessibleName = resources.GetString("pbscifi.AccessibleName");
			this.pbscifi.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbscifi.Anchor")));
			this.pbscifi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbscifi.BackgroundImage")));
			this.pbscifi.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbscifi.Dock")));
			this.pbscifi.Enabled = ((bool)(resources.GetObject("pbscifi.Enabled")));
			this.pbscifi.Font = ((System.Drawing.Font)(resources.GetObject("pbscifi.Font")));
			this.pbscifi.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbscifi.ImeMode")));
			this.pbscifi.Location = ((System.Drawing.Point)(resources.GetObject("pbscifi.Location")));
			this.pbscifi.Maximum = 10;
			this.pbscifi.Name = "pbscifi";
			this.pbscifi.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbscifi.RightToLeft")));
			this.pbscifi.Size = ((System.Drawing.Size)(resources.GetObject("pbscifi.Size")));
			this.pbscifi.TabIndex = ((int)(resources.GetObject("pbscifi.TabIndex")));
			this.pbscifi.Text = resources.GetString("pbscifi.Text");
			this.toolTip1.SetToolTip(this.pbscifi, resources.GetString("pbscifi.ToolTip"));
			this.pbscifi.Visible = ((bool)(resources.GetObject("pbscifi.Visible")));
			this.pbscifi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbscifi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbscifi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbtoys
			// 
			this.pbtoys.AccessibleDescription = resources.GetString("pbtoys.AccessibleDescription");
			this.pbtoys.AccessibleName = resources.GetString("pbtoys.AccessibleName");
			this.pbtoys.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbtoys.Anchor")));
			this.pbtoys.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbtoys.BackgroundImage")));
			this.pbtoys.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbtoys.Dock")));
			this.pbtoys.Enabled = ((bool)(resources.GetObject("pbtoys.Enabled")));
			this.pbtoys.Font = ((System.Drawing.Font)(resources.GetObject("pbtoys.Font")));
			this.pbtoys.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbtoys.ImeMode")));
			this.pbtoys.Location = ((System.Drawing.Point)(resources.GetObject("pbtoys.Location")));
			this.pbtoys.Maximum = 10;
			this.pbtoys.Name = "pbtoys";
			this.pbtoys.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbtoys.RightToLeft")));
			this.pbtoys.Size = ((System.Drawing.Size)(resources.GetObject("pbtoys.Size")));
			this.pbtoys.Step = 1;
			this.pbtoys.TabIndex = ((int)(resources.GetObject("pbtoys.TabIndex")));
			this.pbtoys.Text = resources.GetString("pbtoys.Text");
			this.toolTip1.SetToolTip(this.pbtoys, resources.GetString("pbtoys.ToolTip"));
			this.pbtoys.Visible = ((bool)(resources.GetObject("pbtoys.Visible")));
			this.pbtoys.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbtoys.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbtoys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbschool
			// 
			this.pbschool.AccessibleDescription = resources.GetString("pbschool.AccessibleDescription");
			this.pbschool.AccessibleName = resources.GetString("pbschool.AccessibleName");
			this.pbschool.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbschool.Anchor")));
			this.pbschool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbschool.BackgroundImage")));
			this.pbschool.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbschool.Dock")));
			this.pbschool.Enabled = ((bool)(resources.GetObject("pbschool.Enabled")));
			this.pbschool.Font = ((System.Drawing.Font)(resources.GetObject("pbschool.Font")));
			this.pbschool.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbschool.ImeMode")));
			this.pbschool.Location = ((System.Drawing.Point)(resources.GetObject("pbschool.Location")));
			this.pbschool.Maximum = 10;
			this.pbschool.Name = "pbschool";
			this.pbschool.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbschool.RightToLeft")));
			this.pbschool.Size = ((System.Drawing.Size)(resources.GetObject("pbschool.Size")));
			this.pbschool.Step = 1;
			this.pbschool.TabIndex = ((int)(resources.GetObject("pbschool.TabIndex")));
			this.pbschool.Text = resources.GetString("pbschool.Text");
			this.toolTip1.SetToolTip(this.pbschool, resources.GetString("pbschool.ToolTip"));
			this.pbschool.Visible = ((bool)(resources.GetObject("pbschool.Visible")));
			this.pbschool.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbschool.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbschool.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label45
			// 
			this.label45.AccessibleDescription = resources.GetString("label45.AccessibleDescription");
			this.label45.AccessibleName = resources.GetString("label45.AccessibleName");
			this.label45.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label45.Anchor")));
			this.label45.AutoSize = ((bool)(resources.GetObject("label45.AutoSize")));
			this.label45.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label45.Dock")));
			this.label45.Enabled = ((bool)(resources.GetObject("label45.Enabled")));
			this.label45.Font = ((System.Drawing.Font)(resources.GetObject("label45.Font")));
			this.label45.Image = ((System.Drawing.Image)(resources.GetObject("label45.Image")));
			this.label45.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label45.ImageAlign")));
			this.label45.ImageIndex = ((int)(resources.GetObject("label45.ImageIndex")));
			this.label45.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label45.ImeMode")));
			this.label45.Location = ((System.Drawing.Point)(resources.GetObject("label45.Location")));
			this.label45.Name = "label45";
			this.label45.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label45.RightToLeft")));
			this.label45.Size = ((System.Drawing.Size)(resources.GetObject("label45.Size")));
			this.label45.TabIndex = ((int)(resources.GetObject("label45.TabIndex")));
			this.label45.Text = resources.GetString("label45.Text");
			this.label45.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label45.TextAlign")));
			this.toolTip1.SetToolTip(this.label45, resources.GetString("label45.ToolTip"));
			this.label45.Visible = ((bool)(resources.GetObject("label45.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label45, true);
			// 
			// pbanimals
			// 
			this.pbanimals.AccessibleDescription = resources.GetString("pbanimals.AccessibleDescription");
			this.pbanimals.AccessibleName = resources.GetString("pbanimals.AccessibleName");
			this.pbanimals.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbanimals.Anchor")));
			this.pbanimals.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbanimals.BackgroundImage")));
			this.pbanimals.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbanimals.Dock")));
			this.pbanimals.Enabled = ((bool)(resources.GetObject("pbanimals.Enabled")));
			this.pbanimals.Font = ((System.Drawing.Font)(resources.GetObject("pbanimals.Font")));
			this.pbanimals.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbanimals.ImeMode")));
			this.pbanimals.Location = ((System.Drawing.Point)(resources.GetObject("pbanimals.Location")));
			this.pbanimals.Maximum = 10;
			this.pbanimals.Name = "pbanimals";
			this.pbanimals.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbanimals.RightToLeft")));
			this.pbanimals.Size = ((System.Drawing.Size)(resources.GetObject("pbanimals.Size")));
			this.pbanimals.Step = 1;
			this.pbanimals.TabIndex = ((int)(resources.GetObject("pbanimals.TabIndex")));
			this.pbanimals.Text = resources.GetString("pbanimals.Text");
			this.toolTip1.SetToolTip(this.pbanimals, resources.GetString("pbanimals.ToolTip"));
			this.pbanimals.Visible = ((bool)(resources.GetObject("pbanimals.Visible")));
			this.pbanimals.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbanimals.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbanimals.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbweather
			// 
			this.pbweather.AccessibleDescription = resources.GetString("pbweather.AccessibleDescription");
			this.pbweather.AccessibleName = resources.GetString("pbweather.AccessibleName");
			this.pbweather.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbweather.Anchor")));
			this.pbweather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbweather.BackgroundImage")));
			this.pbweather.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbweather.Dock")));
			this.pbweather.Enabled = ((bool)(resources.GetObject("pbweather.Enabled")));
			this.pbweather.Font = ((System.Drawing.Font)(resources.GetObject("pbweather.Font")));
			this.pbweather.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbweather.ImeMode")));
			this.pbweather.Location = ((System.Drawing.Point)(resources.GetObject("pbweather.Location")));
			this.pbweather.Maximum = 10;
			this.pbweather.Name = "pbweather";
			this.pbweather.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbweather.RightToLeft")));
			this.pbweather.Size = ((System.Drawing.Size)(resources.GetObject("pbweather.Size")));
			this.pbweather.Step = 1;
			this.pbweather.TabIndex = ((int)(resources.GetObject("pbweather.TabIndex")));
			this.pbweather.Text = resources.GetString("pbweather.Text");
			this.toolTip1.SetToolTip(this.pbweather, resources.GetString("pbweather.ToolTip"));
			this.pbweather.Visible = ((bool)(resources.GetObject("pbweather.Visible")));
			this.pbweather.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbweather.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbweather.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label44
			// 
			this.label44.AccessibleDescription = resources.GetString("label44.AccessibleDescription");
			this.label44.AccessibleName = resources.GetString("label44.AccessibleName");
			this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label44.Anchor")));
			this.label44.AutoSize = ((bool)(resources.GetObject("label44.AutoSize")));
			this.label44.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label44.Dock")));
			this.label44.Enabled = ((bool)(resources.GetObject("label44.Enabled")));
			this.label44.Font = ((System.Drawing.Font)(resources.GetObject("label44.Font")));
			this.label44.Image = ((System.Drawing.Image)(resources.GetObject("label44.Image")));
			this.label44.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label44.ImageAlign")));
			this.label44.ImageIndex = ((int)(resources.GetObject("label44.ImageIndex")));
			this.label44.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label44.ImeMode")));
			this.label44.Location = ((System.Drawing.Point)(resources.GetObject("label44.Location")));
			this.label44.Name = "label44";
			this.label44.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label44.RightToLeft")));
			this.label44.Size = ((System.Drawing.Size)(resources.GetObject("label44.Size")));
			this.label44.TabIndex = ((int)(resources.GetObject("label44.TabIndex")));
			this.label44.Text = resources.GetString("label44.Text");
			this.label44.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label44.TextAlign")));
			this.toolTip1.SetToolTip(this.label44, resources.GetString("label44.ToolTip"));
			this.label44.Visible = ((bool)(resources.GetObject("label44.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label44, true);
			// 
			// pbenvironment
			// 
			this.pbenvironment.AccessibleDescription = resources.GetString("pbenvironment.AccessibleDescription");
			this.pbenvironment.AccessibleName = resources.GetString("pbenvironment.AccessibleName");
			this.pbenvironment.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbenvironment.Anchor")));
			this.pbenvironment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbenvironment.BackgroundImage")));
			this.pbenvironment.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbenvironment.Dock")));
			this.pbenvironment.Enabled = ((bool)(resources.GetObject("pbenvironment.Enabled")));
			this.pbenvironment.Font = ((System.Drawing.Font)(resources.GetObject("pbenvironment.Font")));
			this.pbenvironment.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbenvironment.ImeMode")));
			this.pbenvironment.Location = ((System.Drawing.Point)(resources.GetObject("pbenvironment.Location")));
			this.pbenvironment.Maximum = 10;
			this.pbenvironment.Name = "pbenvironment";
			this.pbenvironment.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbenvironment.RightToLeft")));
			this.pbenvironment.Size = ((System.Drawing.Size)(resources.GetObject("pbenvironment.Size")));
			this.pbenvironment.Step = 1;
			this.pbenvironment.TabIndex = ((int)(resources.GetObject("pbenvironment.TabIndex")));
			this.pbenvironment.Text = resources.GetString("pbenvironment.Text");
			this.toolTip1.SetToolTip(this.pbenvironment, resources.GetString("pbenvironment.ToolTip"));
			this.pbenvironment.Visible = ((bool)(resources.GetObject("pbenvironment.Visible")));
			this.pbenvironment.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbenvironment.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbenvironment.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label39
			// 
			this.label39.AccessibleDescription = resources.GetString("label39.AccessibleDescription");
			this.label39.AccessibleName = resources.GetString("label39.AccessibleName");
			this.label39.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label39.Anchor")));
			this.label39.AutoSize = ((bool)(resources.GetObject("label39.AutoSize")));
			this.label39.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label39.Dock")));
			this.label39.Enabled = ((bool)(resources.GetObject("label39.Enabled")));
			this.label39.Font = ((System.Drawing.Font)(resources.GetObject("label39.Font")));
			this.label39.Image = ((System.Drawing.Image)(resources.GetObject("label39.Image")));
			this.label39.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label39.ImageAlign")));
			this.label39.ImageIndex = ((int)(resources.GetObject("label39.ImageIndex")));
			this.label39.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label39.ImeMode")));
			this.label39.Location = ((System.Drawing.Point)(resources.GetObject("label39.Location")));
			this.label39.Name = "label39";
			this.label39.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label39.RightToLeft")));
			this.label39.Size = ((System.Drawing.Size)(resources.GetObject("label39.Size")));
			this.label39.TabIndex = ((int)(resources.GetObject("label39.TabIndex")));
			this.label39.Text = resources.GetString("label39.Text");
			this.label39.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label39.TextAlign")));
			this.toolTip1.SetToolTip(this.label39, resources.GetString("label39.ToolTip"));
			this.label39.Visible = ((bool)(resources.GetObject("label39.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label39, true);
			// 
			// pbtravel
			// 
			this.pbtravel.AccessibleDescription = resources.GetString("pbtravel.AccessibleDescription");
			this.pbtravel.AccessibleName = resources.GetString("pbtravel.AccessibleName");
			this.pbtravel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbtravel.Anchor")));
			this.pbtravel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbtravel.BackgroundImage")));
			this.pbtravel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbtravel.Dock")));
			this.pbtravel.Enabled = ((bool)(resources.GetObject("pbtravel.Enabled")));
			this.pbtravel.Font = ((System.Drawing.Font)(resources.GetObject("pbtravel.Font")));
			this.pbtravel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbtravel.ImeMode")));
			this.pbtravel.Location = ((System.Drawing.Point)(resources.GetObject("pbtravel.Location")));
			this.pbtravel.Maximum = 10;
			this.pbtravel.Name = "pbtravel";
			this.pbtravel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbtravel.RightToLeft")));
			this.pbtravel.Size = ((System.Drawing.Size)(resources.GetObject("pbtravel.Size")));
			this.pbtravel.Step = 1;
			this.pbtravel.TabIndex = ((int)(resources.GetObject("pbtravel.TabIndex")));
			this.pbtravel.Text = resources.GetString("pbtravel.Text");
			this.toolTip1.SetToolTip(this.pbtravel, resources.GetString("pbtravel.ToolTip"));
			this.pbtravel.Visible = ((bool)(resources.GetObject("pbtravel.Visible")));
			this.pbtravel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbtravel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbtravel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label32
			// 
			this.label32.AccessibleDescription = resources.GetString("label32.AccessibleDescription");
			this.label32.AccessibleName = resources.GetString("label32.AccessibleName");
			this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label32.Anchor")));
			this.label32.AutoSize = ((bool)(resources.GetObject("label32.AutoSize")));
			this.label32.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label32.Dock")));
			this.label32.Enabled = ((bool)(resources.GetObject("label32.Enabled")));
			this.label32.Font = ((System.Drawing.Font)(resources.GetObject("label32.Font")));
			this.label32.Image = ((System.Drawing.Image)(resources.GetObject("label32.Image")));
			this.label32.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label32.ImageAlign")));
			this.label32.ImageIndex = ((int)(resources.GetObject("label32.ImageIndex")));
			this.label32.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label32.ImeMode")));
			this.label32.Location = ((System.Drawing.Point)(resources.GetObject("label32.Location")));
			this.label32.Name = "label32";
			this.label32.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label32.RightToLeft")));
			this.label32.Size = ((System.Drawing.Size)(resources.GetObject("label32.Size")));
			this.label32.TabIndex = ((int)(resources.GetObject("label32.TabIndex")));
			this.label32.Text = resources.GetString("label32.Text");
			this.label32.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label32.TextAlign")));
			this.toolTip1.SetToolTip(this.label32, resources.GetString("label32.ToolTip"));
			this.label32.Visible = ((bool)(resources.GetObject("label32.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label32, true);
			// 
			// pbcrime
			// 
			this.pbcrime.AccessibleDescription = resources.GetString("pbcrime.AccessibleDescription");
			this.pbcrime.AccessibleName = resources.GetString("pbcrime.AccessibleName");
			this.pbcrime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcrime.Anchor")));
			this.pbcrime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcrime.BackgroundImage")));
			this.pbcrime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcrime.Dock")));
			this.pbcrime.Enabled = ((bool)(resources.GetObject("pbcrime.Enabled")));
			this.pbcrime.Font = ((System.Drawing.Font)(resources.GetObject("pbcrime.Font")));
			this.pbcrime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcrime.ImeMode")));
			this.pbcrime.Location = ((System.Drawing.Point)(resources.GetObject("pbcrime.Location")));
			this.pbcrime.Maximum = 10;
			this.pbcrime.Name = "pbcrime";
			this.pbcrime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcrime.RightToLeft")));
			this.pbcrime.Size = ((System.Drawing.Size)(resources.GetObject("pbcrime.Size")));
			this.pbcrime.Step = 1;
			this.pbcrime.TabIndex = ((int)(resources.GetObject("pbcrime.TabIndex")));
			this.pbcrime.Text = resources.GetString("pbcrime.Text");
			this.toolTip1.SetToolTip(this.pbcrime, resources.GetString("pbcrime.ToolTip"));
			this.pbcrime.Visible = ((bool)(resources.GetObject("pbcrime.Visible")));
			this.pbcrime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcrime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcrime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AccessibleDescription = resources.GetString("linkLabel1.AccessibleDescription");
			this.linkLabel1.AccessibleName = resources.GetString("linkLabel1.AccessibleName");
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel1.Anchor")));
			this.linkLabel1.AutoSize = ((bool)(resources.GetObject("linkLabel1.AutoSize")));
			this.linkLabel1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel1.Dock")));
			this.linkLabel1.Enabled = ((bool)(resources.GetObject("linkLabel1.Enabled")));
			this.linkLabel1.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel1.Font")));
			this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
			this.linkLabel1.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.ImageAlign")));
			this.linkLabel1.ImageIndex = ((int)(resources.GetObject("linkLabel1.ImageIndex")));
			this.linkLabel1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel1.ImeMode")));
			this.linkLabel1.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel1.LinkArea")));
			this.linkLabel1.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel1.Location")));
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel1.RightToLeft")));
			this.linkLabel1.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel1.Size")));
			this.linkLabel1.TabIndex = ((int)(resources.GetObject("linkLabel1.TabIndex")));
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
			this.linkLabel1.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel1.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel1, resources.GetString("linkLabel1.ToolTip"));
			this.linkLabel1.Visible = ((bool)(resources.GetObject("linkLabel1.Visible")));
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.InteresteProgressMaxClick);
			// 
			// tbcharacter
			// 
			this.tbcharacter.AccessibleDescription = resources.GetString("tbcharacter.AccessibleDescription");
			this.tbcharacter.AccessibleName = resources.GetString("tbcharacter.AccessibleName");
			this.tbcharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcharacter.Anchor")));
			this.tbcharacter.AutoScroll = ((bool)(resources.GetObject("tbcharacter.AutoScroll")));
			this.tbcharacter.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbcharacter.AutoScrollMargin")));
			this.tbcharacter.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbcharacter.AutoScrollMinSize")));
			this.tbcharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcharacter.BackgroundImage")));
			this.tbcharacter.Controls.Add(this.groupBox2);
			this.tbcharacter.Controls.Add(this.gbcareer);
			this.tbcharacter.Controls.Add(this.gblifeline);
			this.tbcharacter.Controls.Add(this.gbcharacter);
			this.tbcharacter.Controls.Add(this.gbgencharacter);
			this.tbcharacter.Controls.Add(this.gbschool);
			this.tbcharacter.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcharacter.Dock")));
			this.tbcharacter.Enabled = ((bool)(resources.GetObject("tbcharacter.Enabled")));
			this.tbcharacter.Font = ((System.Drawing.Font)(resources.GetObject("tbcharacter.Font")));
			this.tbcharacter.ImageIndex = ((int)(resources.GetObject("tbcharacter.ImageIndex")));
			this.tbcharacter.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcharacter.ImeMode")));
			this.tbcharacter.Location = ((System.Drawing.Point)(resources.GetObject("tbcharacter.Location")));
			this.tbcharacter.Name = "tbcharacter";
			this.tbcharacter.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcharacter.RightToLeft")));
			this.tbcharacter.Size = ((System.Drawing.Size)(resources.GetObject("tbcharacter.Size")));
			this.tbcharacter.TabIndex = ((int)(resources.GetObject("tbcharacter.TabIndex")));
			this.tbcharacter.Text = resources.GetString("tbcharacter.Text");
			this.toolTip1.SetToolTip(this.tbcharacter, resources.GetString("tbcharacter.ToolTip"));
			this.tbcharacter.ToolTipText = resources.GetString("tbcharacter.ToolTipText");
			this.tbcharacter.Visible = ((bool)(resources.GetObject("tbcharacter.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcharacter, true);
			// 
			// groupBox2
			// 
			this.groupBox2.AccessibleDescription = resources.GetString("groupBox2.AccessibleDescription");
			this.groupBox2.AccessibleName = resources.GetString("groupBox2.AccessibleName");
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox2.Anchor")));
			this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
			this.groupBox2.Controls.Add(this.cbignoretraversal);
			this.groupBox2.Controls.Add(this.cbpasspeople);
			this.groupBox2.Controls.Add(this.cbpasswalls);
			this.groupBox2.Controls.Add(this.cbpassobject);
			this.groupBox2.Controls.Add(this.cbisghost);
			this.groupBox2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox2.Dock")));
			this.groupBox2.Enabled = ((bool)(resources.GetObject("groupBox2.Enabled")));
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox2.Font = ((System.Drawing.Font)(resources.GetObject("groupBox2.Font")));
			this.groupBox2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox2.ImeMode")));
			this.groupBox2.Location = ((System.Drawing.Point)(resources.GetObject("groupBox2.Location")));
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox2.RightToLeft")));
			this.groupBox2.Size = ((System.Drawing.Size)(resources.GetObject("groupBox2.Size")));
			this.groupBox2.TabIndex = ((int)(resources.GetObject("groupBox2.TabIndex")));
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = resources.GetString("groupBox2.Text");
			this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
			this.groupBox2.Visible = ((bool)(resources.GetObject("groupBox2.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox2, true);
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
			this.toolTip1.SetToolTip(this.cbignoretraversal, resources.GetString("cbignoretraversal.ToolTip"));
			this.cbignoretraversal.Visible = ((bool)(resources.GetObject("cbignoretraversal.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbignoretraversal, true);
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
			this.toolTip1.SetToolTip(this.cbpasspeople, resources.GetString("cbpasspeople.ToolTip"));
			this.cbpasspeople.Visible = ((bool)(resources.GetObject("cbpasspeople.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpasspeople, true);
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
			this.toolTip1.SetToolTip(this.cbpasswalls, resources.GetString("cbpasswalls.ToolTip"));
			this.cbpasswalls.Visible = ((bool)(resources.GetObject("cbpasswalls.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpasswalls, true);
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
			this.toolTip1.SetToolTip(this.cbpassobject, resources.GetString("cbpassobject.ToolTip"));
			this.cbpassobject.Visible = ((bool)(resources.GetObject("cbpassobject.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpassobject, true);
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
			this.toolTip1.SetToolTip(this.cbisghost, resources.GetString("cbisghost.ToolTip"));
			this.cbisghost.Visible = ((bool)(resources.GetObject("cbisghost.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbisghost, true);
			// 
			// gbcareer
			// 
			this.gbcareer.AccessibleDescription = resources.GetString("gbcareer.AccessibleDescription");
			this.gbcareer.AccessibleName = resources.GetString("gbcareer.AccessibleName");
			this.gbcareer.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbcareer.Anchor")));
			this.gbcareer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbcareer.BackgroundImage")));
			this.gbcareer.Controls.Add(this.pbjobperformance);
			this.gbcareer.Controls.Add(this.tbjobperformance);
			this.gbcareer.Controls.Add(this.label88);
			this.gbcareer.Controls.Add(this.pbcarrerlevel);
			this.gbcareer.Controls.Add(this.tbcarrerlevel);
			this.gbcareer.Controls.Add(this.label61);
			this.gbcareer.Controls.Add(this.tbcareervalue);
			this.gbcareer.Controls.Add(this.cbcareer);
			this.gbcareer.Controls.Add(this.label50);
			this.gbcareer.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbcareer.Dock")));
			this.gbcareer.Enabled = ((bool)(resources.GetObject("gbcareer.Enabled")));
			this.gbcareer.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbcareer.Font = ((System.Drawing.Font)(resources.GetObject("gbcareer.Font")));
			this.gbcareer.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbcareer.ImeMode")));
			this.gbcareer.Location = ((System.Drawing.Point)(resources.GetObject("gbcareer.Location")));
			this.gbcareer.Name = "gbcareer";
			this.gbcareer.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbcareer.RightToLeft")));
			this.gbcareer.Size = ((System.Drawing.Size)(resources.GetObject("gbcareer.Size")));
			this.gbcareer.TabIndex = ((int)(resources.GetObject("gbcareer.TabIndex")));
			this.gbcareer.TabStop = false;
			this.gbcareer.Text = resources.GetString("gbcareer.Text");
			this.toolTip1.SetToolTip(this.gbcareer, resources.GetString("gbcareer.ToolTip"));
			this.gbcareer.Visible = ((bool)(resources.GetObject("gbcareer.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbcareer, true);
			// 
			// pbjobperformance
			// 
			this.pbjobperformance.AccessibleDescription = resources.GetString("pbjobperformance.AccessibleDescription");
			this.pbjobperformance.AccessibleName = resources.GetString("pbjobperformance.AccessibleName");
			this.pbjobperformance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbjobperformance.Anchor")));
			this.pbjobperformance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbjobperformance.BackgroundImage")));
			this.pbjobperformance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbjobperformance.Dock")));
			this.pbjobperformance.Enabled = ((bool)(resources.GetObject("pbjobperformance.Enabled")));
			this.pbjobperformance.Font = ((System.Drawing.Font)(resources.GetObject("pbjobperformance.Font")));
			this.pbjobperformance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbjobperformance.ImeMode")));
			this.pbjobperformance.Location = ((System.Drawing.Point)(resources.GetObject("pbjobperformance.Location")));
			this.pbjobperformance.Maximum = 2000;
			this.pbjobperformance.Name = "pbjobperformance";
			this.pbjobperformance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbjobperformance.RightToLeft")));
			this.pbjobperformance.Size = ((System.Drawing.Size)(resources.GetObject("pbjobperformance.Size")));
			this.pbjobperformance.Step = 1;
			this.pbjobperformance.TabIndex = ((int)(resources.GetObject("pbjobperformance.TabIndex")));
			this.pbjobperformance.Text = resources.GetString("pbjobperformance.Text");
			this.toolTip1.SetToolTip(this.pbjobperformance, resources.GetString("pbjobperformance.ToolTip"));
			this.pbjobperformance.Visible = ((bool)(resources.GetObject("pbjobperformance.Visible")));
			this.pbjobperformance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbjobperformance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbjobperformance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbjobperformance
			// 
			this.tbjobperformance.AccessibleDescription = resources.GetString("tbjobperformance.AccessibleDescription");
			this.tbjobperformance.AccessibleName = resources.GetString("tbjobperformance.AccessibleName");
			this.tbjobperformance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbjobperformance.Anchor")));
			this.tbjobperformance.AutoSize = ((bool)(resources.GetObject("tbjobperformance.AutoSize")));
			this.tbjobperformance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbjobperformance.BackgroundImage")));
			this.tbjobperformance.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbjobperformance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbjobperformance.Dock")));
			this.tbjobperformance.Enabled = ((bool)(resources.GetObject("tbjobperformance.Enabled")));
			this.tbjobperformance.Font = ((System.Drawing.Font)(resources.GetObject("tbjobperformance.Font")));
			this.tbjobperformance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbjobperformance.ImeMode")));
			this.tbjobperformance.Location = ((System.Drawing.Point)(resources.GetObject("tbjobperformance.Location")));
			this.tbjobperformance.MaxLength = ((int)(resources.GetObject("tbjobperformance.MaxLength")));
			this.tbjobperformance.Multiline = ((bool)(resources.GetObject("tbjobperformance.Multiline")));
			this.tbjobperformance.Name = "tbjobperformance";
			this.tbjobperformance.PasswordChar = ((char)(resources.GetObject("tbjobperformance.PasswordChar")));
			this.tbjobperformance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbjobperformance.RightToLeft")));
			this.tbjobperformance.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbjobperformance.ScrollBars")));
			this.tbjobperformance.Size = ((System.Drawing.Size)(resources.GetObject("tbjobperformance.Size")));
			this.tbjobperformance.TabIndex = ((int)(resources.GetObject("tbjobperformance.TabIndex")));
			this.tbjobperformance.Text = resources.GetString("tbjobperformance.Text");
			this.tbjobperformance.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbjobperformance.TextAlign")));
			this.toolTip1.SetToolTip(this.tbjobperformance, resources.GetString("tbjobperformance.ToolTip"));
			this.tbjobperformance.Visible = ((bool)(resources.GetObject("tbjobperformance.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbjobperformance, true);
			this.tbjobperformance.WordWrap = ((bool)(resources.GetObject("tbjobperformance.WordWrap")));
			this.tbjobperformance.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbjobperformance.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label88
			// 
			this.label88.AccessibleDescription = resources.GetString("label88.AccessibleDescription");
			this.label88.AccessibleName = resources.GetString("label88.AccessibleName");
			this.label88.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label88.Anchor")));
			this.label88.AutoSize = ((bool)(resources.GetObject("label88.AutoSize")));
			this.label88.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label88.Dock")));
			this.label88.Enabled = ((bool)(resources.GetObject("label88.Enabled")));
			this.label88.Font = ((System.Drawing.Font)(resources.GetObject("label88.Font")));
			this.label88.Image = ((System.Drawing.Image)(resources.GetObject("label88.Image")));
			this.label88.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label88.ImageAlign")));
			this.label88.ImageIndex = ((int)(resources.GetObject("label88.ImageIndex")));
			this.label88.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label88.ImeMode")));
			this.label88.Location = ((System.Drawing.Point)(resources.GetObject("label88.Location")));
			this.label88.Name = "label88";
			this.label88.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label88.RightToLeft")));
			this.label88.Size = ((System.Drawing.Size)(resources.GetObject("label88.Size")));
			this.label88.TabIndex = ((int)(resources.GetObject("label88.TabIndex")));
			this.label88.Text = resources.GetString("label88.Text");
			this.label88.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label88.TextAlign")));
			this.toolTip1.SetToolTip(this.label88, resources.GetString("label88.ToolTip"));
			this.label88.Visible = ((bool)(resources.GetObject("label88.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label88, true);
			// 
			// pbcarrerlevel
			// 
			this.pbcarrerlevel.AccessibleDescription = resources.GetString("pbcarrerlevel.AccessibleDescription");
			this.pbcarrerlevel.AccessibleName = resources.GetString("pbcarrerlevel.AccessibleName");
			this.pbcarrerlevel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcarrerlevel.Anchor")));
			this.pbcarrerlevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcarrerlevel.BackgroundImage")));
			this.pbcarrerlevel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcarrerlevel.Dock")));
			this.pbcarrerlevel.Enabled = ((bool)(resources.GetObject("pbcarrerlevel.Enabled")));
			this.pbcarrerlevel.Font = ((System.Drawing.Font)(resources.GetObject("pbcarrerlevel.Font")));
			this.pbcarrerlevel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcarrerlevel.ImeMode")));
			this.pbcarrerlevel.Location = ((System.Drawing.Point)(resources.GetObject("pbcarrerlevel.Location")));
			this.pbcarrerlevel.Maximum = 11;
			this.pbcarrerlevel.Name = "pbcarrerlevel";
			this.pbcarrerlevel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcarrerlevel.RightToLeft")));
			this.pbcarrerlevel.Size = ((System.Drawing.Size)(resources.GetObject("pbcarrerlevel.Size")));
			this.pbcarrerlevel.Step = 1;
			this.pbcarrerlevel.TabIndex = ((int)(resources.GetObject("pbcarrerlevel.TabIndex")));
			this.pbcarrerlevel.Text = resources.GetString("pbcarrerlevel.Text");
			this.toolTip1.SetToolTip(this.pbcarrerlevel, resources.GetString("pbcarrerlevel.ToolTip"));
			this.pbcarrerlevel.Visible = ((bool)(resources.GetObject("pbcarrerlevel.Visible")));
			this.pbcarrerlevel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcarrerlevel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcarrerlevel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbcarrerlevel
			// 
			this.tbcarrerlevel.AccessibleDescription = resources.GetString("tbcarrerlevel.AccessibleDescription");
			this.tbcarrerlevel.AccessibleName = resources.GetString("tbcarrerlevel.AccessibleName");
			this.tbcarrerlevel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcarrerlevel.Anchor")));
			this.tbcarrerlevel.AutoSize = ((bool)(resources.GetObject("tbcarrerlevel.AutoSize")));
			this.tbcarrerlevel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcarrerlevel.BackgroundImage")));
			this.tbcarrerlevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcarrerlevel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcarrerlevel.Dock")));
			this.tbcarrerlevel.Enabled = ((bool)(resources.GetObject("tbcarrerlevel.Enabled")));
			this.tbcarrerlevel.Font = ((System.Drawing.Font)(resources.GetObject("tbcarrerlevel.Font")));
			this.tbcarrerlevel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcarrerlevel.ImeMode")));
			this.tbcarrerlevel.Location = ((System.Drawing.Point)(resources.GetObject("tbcarrerlevel.Location")));
			this.tbcarrerlevel.MaxLength = ((int)(resources.GetObject("tbcarrerlevel.MaxLength")));
			this.tbcarrerlevel.Multiline = ((bool)(resources.GetObject("tbcarrerlevel.Multiline")));
			this.tbcarrerlevel.Name = "tbcarrerlevel";
			this.tbcarrerlevel.PasswordChar = ((char)(resources.GetObject("tbcarrerlevel.PasswordChar")));
			this.tbcarrerlevel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcarrerlevel.RightToLeft")));
			this.tbcarrerlevel.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcarrerlevel.ScrollBars")));
			this.tbcarrerlevel.Size = ((System.Drawing.Size)(resources.GetObject("tbcarrerlevel.Size")));
			this.tbcarrerlevel.TabIndex = ((int)(resources.GetObject("tbcarrerlevel.TabIndex")));
			this.tbcarrerlevel.Text = resources.GetString("tbcarrerlevel.Text");
			this.tbcarrerlevel.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcarrerlevel.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcarrerlevel, resources.GetString("tbcarrerlevel.ToolTip"));
			this.tbcarrerlevel.Visible = ((bool)(resources.GetObject("tbcarrerlevel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcarrerlevel, true);
			this.tbcarrerlevel.WordWrap = ((bool)(resources.GetObject("tbcarrerlevel.WordWrap")));
			this.tbcarrerlevel.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcarrerlevel.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// label61
			// 
			this.label61.AccessibleDescription = resources.GetString("label61.AccessibleDescription");
			this.label61.AccessibleName = resources.GetString("label61.AccessibleName");
			this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label61.Anchor")));
			this.label61.AutoSize = ((bool)(resources.GetObject("label61.AutoSize")));
			this.label61.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label61.Dock")));
			this.label61.Enabled = ((bool)(resources.GetObject("label61.Enabled")));
			this.label61.Font = ((System.Drawing.Font)(resources.GetObject("label61.Font")));
			this.label61.Image = ((System.Drawing.Image)(resources.GetObject("label61.Image")));
			this.label61.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label61.ImageAlign")));
			this.label61.ImageIndex = ((int)(resources.GetObject("label61.ImageIndex")));
			this.label61.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label61.ImeMode")));
			this.label61.Location = ((System.Drawing.Point)(resources.GetObject("label61.Location")));
			this.label61.Name = "label61";
			this.label61.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label61.RightToLeft")));
			this.label61.Size = ((System.Drawing.Size)(resources.GetObject("label61.Size")));
			this.label61.TabIndex = ((int)(resources.GetObject("label61.TabIndex")));
			this.label61.Text = resources.GetString("label61.Text");
			this.label61.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label61.TextAlign")));
			this.toolTip1.SetToolTip(this.label61, resources.GetString("label61.ToolTip"));
			this.label61.Visible = ((bool)(resources.GetObject("label61.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label61, true);
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
			this.toolTip1.SetToolTip(this.tbcareervalue, resources.GetString("tbcareervalue.ToolTip"));
			this.tbcareervalue.Visible = ((bool)(resources.GetObject("tbcareervalue.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcareervalue, true);
			this.tbcareervalue.WordWrap = ((bool)(resources.GetObject("tbcareervalue.WordWrap")));
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
			this.toolTip1.SetToolTip(this.cbcareer, resources.GetString("cbcareer.ToolTip"));
			this.cbcareer.Visible = ((bool)(resources.GetObject("cbcareer.Visible")));
			this.cbcareer.SelectedIndexChanged += new System.EventHandler(this.CareerIndexChanged);
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
			this.toolTip1.SetToolTip(this.label50, resources.GetString("label50.ToolTip"));
			this.label50.Visible = ((bool)(resources.GetObject("label50.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label50, true);
			// 
			// gblifeline
			// 
			this.gblifeline.AccessibleDescription = resources.GetString("gblifeline.AccessibleDescription");
			this.gblifeline.AccessibleName = resources.GetString("gblifeline.AccessibleName");
			this.gblifeline.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gblifeline.Anchor")));
			this.gblifeline.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gblifeline.BackgroundImage")));
			this.gblifeline.Controls.Add(this.pblifelinepoints);
			this.gblifeline.Controls.Add(this.label62);
			this.gblifeline.Controls.Add(this.tblifelinepoints);
			this.gblifeline.Controls.Add(this.tblifelinescore);
			this.gblifeline.Controls.Add(this.label60);
			this.gblifeline.Controls.Add(this.pbblizlifelinepoints);
			this.gblifeline.Controls.Add(this.label59);
			this.gblifeline.Controls.Add(this.tbblizlifelinepoints);
			this.gblifeline.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gblifeline.Dock")));
			this.gblifeline.Enabled = ((bool)(resources.GetObject("gblifeline.Enabled")));
			this.gblifeline.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gblifeline.Font = ((System.Drawing.Font)(resources.GetObject("gblifeline.Font")));
			this.gblifeline.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gblifeline.ImeMode")));
			this.gblifeline.Location = ((System.Drawing.Point)(resources.GetObject("gblifeline.Location")));
			this.gblifeline.Name = "gblifeline";
			this.gblifeline.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gblifeline.RightToLeft")));
			this.gblifeline.Size = ((System.Drawing.Size)(resources.GetObject("gblifeline.Size")));
			this.gblifeline.TabIndex = ((int)(resources.GetObject("gblifeline.TabIndex")));
			this.gblifeline.TabStop = false;
			this.gblifeline.Text = resources.GetString("gblifeline.Text");
			this.toolTip1.SetToolTip(this.gblifeline, resources.GetString("gblifeline.ToolTip"));
			this.gblifeline.Visible = ((bool)(resources.GetObject("gblifeline.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gblifeline, true);
			// 
			// pblifelinepoints
			// 
			this.pblifelinepoints.AccessibleDescription = resources.GetString("pblifelinepoints.AccessibleDescription");
			this.pblifelinepoints.AccessibleName = resources.GetString("pblifelinepoints.AccessibleName");
			this.pblifelinepoints.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pblifelinepoints.Anchor")));
			this.pblifelinepoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pblifelinepoints.BackgroundImage")));
			this.pblifelinepoints.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pblifelinepoints.Dock")));
			this.pblifelinepoints.Enabled = ((bool)(resources.GetObject("pblifelinepoints.Enabled")));
			this.pblifelinepoints.Font = ((System.Drawing.Font)(resources.GetObject("pblifelinepoints.Font")));
			this.pblifelinepoints.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pblifelinepoints.ImeMode")));
			this.pblifelinepoints.Location = ((System.Drawing.Point)(resources.GetObject("pblifelinepoints.Location")));
			this.pblifelinepoints.Maximum = 1200;
			this.pblifelinepoints.Name = "pblifelinepoints";
			this.pblifelinepoints.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pblifelinepoints.RightToLeft")));
			this.pblifelinepoints.Size = ((System.Drawing.Size)(resources.GetObject("pblifelinepoints.Size")));
			this.pblifelinepoints.Step = 1;
			this.pblifelinepoints.TabIndex = ((int)(resources.GetObject("pblifelinepoints.TabIndex")));
			this.pblifelinepoints.Text = resources.GetString("pblifelinepoints.Text");
			this.toolTip1.SetToolTip(this.pblifelinepoints, resources.GetString("pblifelinepoints.ToolTip"));
			this.pblifelinepoints.Visible = ((bool)(resources.GetObject("pblifelinepoints.Visible")));
			this.pblifelinepoints.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pblifelinepoints.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pblifelinepoints.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label62
			// 
			this.label62.AccessibleDescription = resources.GetString("label62.AccessibleDescription");
			this.label62.AccessibleName = resources.GetString("label62.AccessibleName");
			this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label62.Anchor")));
			this.label62.AutoSize = ((bool)(resources.GetObject("label62.AutoSize")));
			this.label62.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label62.Dock")));
			this.label62.Enabled = ((bool)(resources.GetObject("label62.Enabled")));
			this.label62.Font = ((System.Drawing.Font)(resources.GetObject("label62.Font")));
			this.label62.Image = ((System.Drawing.Image)(resources.GetObject("label62.Image")));
			this.label62.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label62.ImageAlign")));
			this.label62.ImageIndex = ((int)(resources.GetObject("label62.ImageIndex")));
			this.label62.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label62.ImeMode")));
			this.label62.Location = ((System.Drawing.Point)(resources.GetObject("label62.Location")));
			this.label62.Name = "label62";
			this.label62.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label62.RightToLeft")));
			this.label62.Size = ((System.Drawing.Size)(resources.GetObject("label62.Size")));
			this.label62.TabIndex = ((int)(resources.GetObject("label62.TabIndex")));
			this.label62.Text = resources.GetString("label62.Text");
			this.label62.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label62.TextAlign")));
			this.toolTip1.SetToolTip(this.label62, resources.GetString("label62.ToolTip"));
			this.label62.Visible = ((bool)(resources.GetObject("label62.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label62, true);
			// 
			// tblifelinepoints
			// 
			this.tblifelinepoints.AccessibleDescription = resources.GetString("tblifelinepoints.AccessibleDescription");
			this.tblifelinepoints.AccessibleName = resources.GetString("tblifelinepoints.AccessibleName");
			this.tblifelinepoints.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblifelinepoints.Anchor")));
			this.tblifelinepoints.AutoSize = ((bool)(resources.GetObject("tblifelinepoints.AutoSize")));
			this.tblifelinepoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblifelinepoints.BackgroundImage")));
			this.tblifelinepoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tblifelinepoints.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblifelinepoints.Dock")));
			this.tblifelinepoints.Enabled = ((bool)(resources.GetObject("tblifelinepoints.Enabled")));
			this.tblifelinepoints.Font = ((System.Drawing.Font)(resources.GetObject("tblifelinepoints.Font")));
			this.tblifelinepoints.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblifelinepoints.ImeMode")));
			this.tblifelinepoints.Location = ((System.Drawing.Point)(resources.GetObject("tblifelinepoints.Location")));
			this.tblifelinepoints.MaxLength = ((int)(resources.GetObject("tblifelinepoints.MaxLength")));
			this.tblifelinepoints.Multiline = ((bool)(resources.GetObject("tblifelinepoints.Multiline")));
			this.tblifelinepoints.Name = "tblifelinepoints";
			this.tblifelinepoints.PasswordChar = ((char)(resources.GetObject("tblifelinepoints.PasswordChar")));
			this.tblifelinepoints.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblifelinepoints.RightToLeft")));
			this.tblifelinepoints.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblifelinepoints.ScrollBars")));
			this.tblifelinepoints.Size = ((System.Drawing.Size)(resources.GetObject("tblifelinepoints.Size")));
			this.tblifelinepoints.TabIndex = ((int)(resources.GetObject("tblifelinepoints.TabIndex")));
			this.tblifelinepoints.Text = resources.GetString("tblifelinepoints.Text");
			this.tblifelinepoints.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblifelinepoints.TextAlign")));
			this.toolTip1.SetToolTip(this.tblifelinepoints, resources.GetString("tblifelinepoints.ToolTip"));
			this.tblifelinepoints.Visible = ((bool)(resources.GetObject("tblifelinepoints.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblifelinepoints, true);
			this.tblifelinepoints.WordWrap = ((bool)(resources.GetObject("tblifelinepoints.WordWrap")));
			this.tblifelinepoints.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tblifelinepoints.Leave += new System.EventHandler(this.ProgressBarTextLeave);
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
			this.toolTip1.SetToolTip(this.tblifelinescore, resources.GetString("tblifelinescore.ToolTip"));
			this.tblifelinescore.Visible = ((bool)(resources.GetObject("tblifelinescore.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblifelinescore, true);
			this.tblifelinescore.WordWrap = ((bool)(resources.GetObject("tblifelinescore.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label60, resources.GetString("label60.ToolTip"));
			this.label60.Visible = ((bool)(resources.GetObject("label60.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label60, true);
			// 
			// pbblizlifelinepoints
			// 
			this.pbblizlifelinepoints.AccessibleDescription = resources.GetString("pbblizlifelinepoints.AccessibleDescription");
			this.pbblizlifelinepoints.AccessibleName = resources.GetString("pbblizlifelinepoints.AccessibleName");
			this.pbblizlifelinepoints.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbblizlifelinepoints.Anchor")));
			this.pbblizlifelinepoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbblizlifelinepoints.BackgroundImage")));
			this.pbblizlifelinepoints.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbblizlifelinepoints.Dock")));
			this.pbblizlifelinepoints.Enabled = ((bool)(resources.GetObject("pbblizlifelinepoints.Enabled")));
			this.pbblizlifelinepoints.Font = ((System.Drawing.Font)(resources.GetObject("pbblizlifelinepoints.Font")));
			this.pbblizlifelinepoints.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbblizlifelinepoints.ImeMode")));
			this.pbblizlifelinepoints.Location = ((System.Drawing.Point)(resources.GetObject("pbblizlifelinepoints.Location")));
			this.pbblizlifelinepoints.Maximum = 1200;
			this.pbblizlifelinepoints.Name = "pbblizlifelinepoints";
			this.pbblizlifelinepoints.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbblizlifelinepoints.RightToLeft")));
			this.pbblizlifelinepoints.Size = ((System.Drawing.Size)(resources.GetObject("pbblizlifelinepoints.Size")));
			this.pbblizlifelinepoints.Step = 1;
			this.pbblizlifelinepoints.TabIndex = ((int)(resources.GetObject("pbblizlifelinepoints.TabIndex")));
			this.pbblizlifelinepoints.Text = resources.GetString("pbblizlifelinepoints.Text");
			this.toolTip1.SetToolTip(this.pbblizlifelinepoints, resources.GetString("pbblizlifelinepoints.ToolTip"));
			this.pbblizlifelinepoints.Visible = ((bool)(resources.GetObject("pbblizlifelinepoints.Visible")));
			this.pbblizlifelinepoints.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbblizlifelinepoints.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbblizlifelinepoints.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label59
			// 
			this.label59.AccessibleDescription = resources.GetString("label59.AccessibleDescription");
			this.label59.AccessibleName = resources.GetString("label59.AccessibleName");
			this.label59.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label59.Anchor")));
			this.label59.AutoSize = ((bool)(resources.GetObject("label59.AutoSize")));
			this.label59.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label59.Dock")));
			this.label59.Enabled = ((bool)(resources.GetObject("label59.Enabled")));
			this.label59.Font = ((System.Drawing.Font)(resources.GetObject("label59.Font")));
			this.label59.Image = ((System.Drawing.Image)(resources.GetObject("label59.Image")));
			this.label59.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label59.ImageAlign")));
			this.label59.ImageIndex = ((int)(resources.GetObject("label59.ImageIndex")));
			this.label59.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label59.ImeMode")));
			this.label59.Location = ((System.Drawing.Point)(resources.GetObject("label59.Location")));
			this.label59.Name = "label59";
			this.label59.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label59.RightToLeft")));
			this.label59.Size = ((System.Drawing.Size)(resources.GetObject("label59.Size")));
			this.label59.TabIndex = ((int)(resources.GetObject("label59.TabIndex")));
			this.label59.Text = resources.GetString("label59.Text");
			this.label59.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label59.TextAlign")));
			this.toolTip1.SetToolTip(this.label59, resources.GetString("label59.ToolTip"));
			this.label59.Visible = ((bool)(resources.GetObject("label59.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label59, true);
			// 
			// tbblizlifelinepoints
			// 
			this.tbblizlifelinepoints.AccessibleDescription = resources.GetString("tbblizlifelinepoints.AccessibleDescription");
			this.tbblizlifelinepoints.AccessibleName = resources.GetString("tbblizlifelinepoints.AccessibleName");
			this.tbblizlifelinepoints.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbblizlifelinepoints.Anchor")));
			this.tbblizlifelinepoints.AutoSize = ((bool)(resources.GetObject("tbblizlifelinepoints.AutoSize")));
			this.tbblizlifelinepoints.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbblizlifelinepoints.BackgroundImage")));
			this.tbblizlifelinepoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbblizlifelinepoints.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbblizlifelinepoints.Dock")));
			this.tbblizlifelinepoints.Enabled = ((bool)(resources.GetObject("tbblizlifelinepoints.Enabled")));
			this.tbblizlifelinepoints.Font = ((System.Drawing.Font)(resources.GetObject("tbblizlifelinepoints.Font")));
			this.tbblizlifelinepoints.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbblizlifelinepoints.ImeMode")));
			this.tbblizlifelinepoints.Location = ((System.Drawing.Point)(resources.GetObject("tbblizlifelinepoints.Location")));
			this.tbblizlifelinepoints.MaxLength = ((int)(resources.GetObject("tbblizlifelinepoints.MaxLength")));
			this.tbblizlifelinepoints.Multiline = ((bool)(resources.GetObject("tbblizlifelinepoints.Multiline")));
			this.tbblizlifelinepoints.Name = "tbblizlifelinepoints";
			this.tbblizlifelinepoints.PasswordChar = ((char)(resources.GetObject("tbblizlifelinepoints.PasswordChar")));
			this.tbblizlifelinepoints.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbblizlifelinepoints.RightToLeft")));
			this.tbblizlifelinepoints.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbblizlifelinepoints.ScrollBars")));
			this.tbblizlifelinepoints.Size = ((System.Drawing.Size)(resources.GetObject("tbblizlifelinepoints.Size")));
			this.tbblizlifelinepoints.TabIndex = ((int)(resources.GetObject("tbblizlifelinepoints.TabIndex")));
			this.tbblizlifelinepoints.Text = resources.GetString("tbblizlifelinepoints.Text");
			this.tbblizlifelinepoints.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbblizlifelinepoints.TextAlign")));
			this.toolTip1.SetToolTip(this.tbblizlifelinepoints, resources.GetString("tbblizlifelinepoints.ToolTip"));
			this.tbblizlifelinepoints.Visible = ((bool)(resources.GetObject("tbblizlifelinepoints.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbblizlifelinepoints, true);
			this.tbblizlifelinepoints.WordWrap = ((bool)(resources.GetObject("tbblizlifelinepoints.WordWrap")));
			this.tbblizlifelinepoints.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbblizlifelinepoints.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// gbcharacter
			// 
			this.gbcharacter.AccessibleDescription = resources.GetString("gbcharacter.AccessibleDescription");
			this.gbcharacter.AccessibleName = resources.GetString("gbcharacter.AccessibleName");
			this.gbcharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbcharacter.Anchor")));
			this.gbcharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbcharacter.BackgroundImage")));
			this.gbcharacter.Controls.Add(this.pbneat);
			this.gbcharacter.Controls.Add(this.tbnice);
			this.gbcharacter.Controls.Add(this.tbplayful);
			this.gbcharacter.Controls.Add(this.tbactive);
			this.gbcharacter.Controls.Add(this.tboutgoing);
			this.gbcharacter.Controls.Add(this.tbneat);
			this.gbcharacter.Controls.Add(this.pbnice);
			this.gbcharacter.Controls.Add(this.pbplayful);
			this.gbcharacter.Controls.Add(this.pbactive);
			this.gbcharacter.Controls.Add(this.pboutgoing);
			this.gbcharacter.Controls.Add(this.label20);
			this.gbcharacter.Controls.Add(this.label19);
			this.gbcharacter.Controls.Add(this.label18);
			this.gbcharacter.Controls.Add(this.label17);
			this.gbcharacter.Controls.Add(this.label16);
			this.gbcharacter.Controls.Add(this.linkLabel3);
			this.gbcharacter.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbcharacter.Dock")));
			this.gbcharacter.Enabled = ((bool)(resources.GetObject("gbcharacter.Enabled")));
			this.gbcharacter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbcharacter.Font = ((System.Drawing.Font)(resources.GetObject("gbcharacter.Font")));
			this.gbcharacter.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbcharacter.ImeMode")));
			this.gbcharacter.Location = ((System.Drawing.Point)(resources.GetObject("gbcharacter.Location")));
			this.gbcharacter.Name = "gbcharacter";
			this.gbcharacter.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbcharacter.RightToLeft")));
			this.gbcharacter.Size = ((System.Drawing.Size)(resources.GetObject("gbcharacter.Size")));
			this.gbcharacter.TabIndex = ((int)(resources.GetObject("gbcharacter.TabIndex")));
			this.gbcharacter.TabStop = false;
			this.gbcharacter.Text = resources.GetString("gbcharacter.Text");
			this.toolTip1.SetToolTip(this.gbcharacter, resources.GetString("gbcharacter.ToolTip"));
			this.gbcharacter.Visible = ((bool)(resources.GetObject("gbcharacter.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbcharacter, true);
			// 
			// pbneat
			// 
			this.pbneat.AccessibleDescription = resources.GetString("pbneat.AccessibleDescription");
			this.pbneat.AccessibleName = resources.GetString("pbneat.AccessibleName");
			this.pbneat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbneat.Anchor")));
			this.pbneat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbneat.BackgroundImage")));
			this.pbneat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbneat.Dock")));
			this.pbneat.Enabled = ((bool)(resources.GetObject("pbneat.Enabled")));
			this.pbneat.Font = ((System.Drawing.Font)(resources.GetObject("pbneat.Font")));
			this.pbneat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbneat.ImeMode")));
			this.pbneat.Location = ((System.Drawing.Point)(resources.GetObject("pbneat.Location")));
			this.pbneat.Maximum = 10;
			this.pbneat.Name = "pbneat";
			this.pbneat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbneat.RightToLeft")));
			this.pbneat.Size = ((System.Drawing.Size)(resources.GetObject("pbneat.Size")));
			this.pbneat.Step = 1;
			this.pbneat.TabIndex = ((int)(resources.GetObject("pbneat.TabIndex")));
			this.pbneat.Text = resources.GetString("pbneat.Text");
			this.toolTip1.SetToolTip(this.pbneat, resources.GetString("pbneat.ToolTip"));
			this.pbneat.Visible = ((bool)(resources.GetObject("pbneat.Visible")));
			this.pbneat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbneat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbneat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbnice
			// 
			this.tbnice.AccessibleDescription = resources.GetString("tbnice.AccessibleDescription");
			this.tbnice.AccessibleName = resources.GetString("tbnice.AccessibleName");
			this.tbnice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbnice.Anchor")));
			this.tbnice.AutoSize = ((bool)(resources.GetObject("tbnice.AutoSize")));
			this.tbnice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbnice.BackgroundImage")));
			this.tbnice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbnice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbnice.Dock")));
			this.tbnice.Enabled = ((bool)(resources.GetObject("tbnice.Enabled")));
			this.tbnice.Font = ((System.Drawing.Font)(resources.GetObject("tbnice.Font")));
			this.tbnice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbnice.ImeMode")));
			this.tbnice.Location = ((System.Drawing.Point)(resources.GetObject("tbnice.Location")));
			this.tbnice.MaxLength = ((int)(resources.GetObject("tbnice.MaxLength")));
			this.tbnice.Multiline = ((bool)(resources.GetObject("tbnice.Multiline")));
			this.tbnice.Name = "tbnice";
			this.tbnice.PasswordChar = ((char)(resources.GetObject("tbnice.PasswordChar")));
			this.tbnice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbnice.RightToLeft")));
			this.tbnice.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbnice.ScrollBars")));
			this.tbnice.Size = ((System.Drawing.Size)(resources.GetObject("tbnice.Size")));
			this.tbnice.TabIndex = ((int)(resources.GetObject("tbnice.TabIndex")));
			this.tbnice.Text = resources.GetString("tbnice.Text");
			this.tbnice.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbnice.TextAlign")));
			this.toolTip1.SetToolTip(this.tbnice, resources.GetString("tbnice.ToolTip"));
			this.tbnice.Visible = ((bool)(resources.GetObject("tbnice.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbnice, true);
			this.tbnice.WordWrap = ((bool)(resources.GetObject("tbnice.WordWrap")));
			this.tbnice.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbnice.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbplayful
			// 
			this.tbplayful.AccessibleDescription = resources.GetString("tbplayful.AccessibleDescription");
			this.tbplayful.AccessibleName = resources.GetString("tbplayful.AccessibleName");
			this.tbplayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbplayful.Anchor")));
			this.tbplayful.AutoSize = ((bool)(resources.GetObject("tbplayful.AutoSize")));
			this.tbplayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbplayful.BackgroundImage")));
			this.tbplayful.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbplayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbplayful.Dock")));
			this.tbplayful.Enabled = ((bool)(resources.GetObject("tbplayful.Enabled")));
			this.tbplayful.Font = ((System.Drawing.Font)(resources.GetObject("tbplayful.Font")));
			this.tbplayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbplayful.ImeMode")));
			this.tbplayful.Location = ((System.Drawing.Point)(resources.GetObject("tbplayful.Location")));
			this.tbplayful.MaxLength = ((int)(resources.GetObject("tbplayful.MaxLength")));
			this.tbplayful.Multiline = ((bool)(resources.GetObject("tbplayful.Multiline")));
			this.tbplayful.Name = "tbplayful";
			this.tbplayful.PasswordChar = ((char)(resources.GetObject("tbplayful.PasswordChar")));
			this.tbplayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbplayful.RightToLeft")));
			this.tbplayful.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbplayful.ScrollBars")));
			this.tbplayful.Size = ((System.Drawing.Size)(resources.GetObject("tbplayful.Size")));
			this.tbplayful.TabIndex = ((int)(resources.GetObject("tbplayful.TabIndex")));
			this.tbplayful.Text = resources.GetString("tbplayful.Text");
			this.tbplayful.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbplayful.TextAlign")));
			this.toolTip1.SetToolTip(this.tbplayful, resources.GetString("tbplayful.ToolTip"));
			this.tbplayful.Visible = ((bool)(resources.GetObject("tbplayful.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbplayful, true);
			this.tbplayful.WordWrap = ((bool)(resources.GetObject("tbplayful.WordWrap")));
			this.tbplayful.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbplayful.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbactive
			// 
			this.tbactive.AccessibleDescription = resources.GetString("tbactive.AccessibleDescription");
			this.tbactive.AccessibleName = resources.GetString("tbactive.AccessibleName");
			this.tbactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbactive.Anchor")));
			this.tbactive.AutoSize = ((bool)(resources.GetObject("tbactive.AutoSize")));
			this.tbactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbactive.BackgroundImage")));
			this.tbactive.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbactive.Dock")));
			this.tbactive.Enabled = ((bool)(resources.GetObject("tbactive.Enabled")));
			this.tbactive.Font = ((System.Drawing.Font)(resources.GetObject("tbactive.Font")));
			this.tbactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbactive.ImeMode")));
			this.tbactive.Location = ((System.Drawing.Point)(resources.GetObject("tbactive.Location")));
			this.tbactive.MaxLength = ((int)(resources.GetObject("tbactive.MaxLength")));
			this.tbactive.Multiline = ((bool)(resources.GetObject("tbactive.Multiline")));
			this.tbactive.Name = "tbactive";
			this.tbactive.PasswordChar = ((char)(resources.GetObject("tbactive.PasswordChar")));
			this.tbactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbactive.RightToLeft")));
			this.tbactive.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbactive.ScrollBars")));
			this.tbactive.Size = ((System.Drawing.Size)(resources.GetObject("tbactive.Size")));
			this.tbactive.TabIndex = ((int)(resources.GetObject("tbactive.TabIndex")));
			this.tbactive.Text = resources.GetString("tbactive.Text");
			this.tbactive.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbactive.TextAlign")));
			this.toolTip1.SetToolTip(this.tbactive, resources.GetString("tbactive.ToolTip"));
			this.tbactive.Visible = ((bool)(resources.GetObject("tbactive.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbactive, true);
			this.tbactive.WordWrap = ((bool)(resources.GetObject("tbactive.WordWrap")));
			this.tbactive.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbactive.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tboutgoing
			// 
			this.tboutgoing.AccessibleDescription = resources.GetString("tboutgoing.AccessibleDescription");
			this.tboutgoing.AccessibleName = resources.GetString("tboutgoing.AccessibleName");
			this.tboutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tboutgoing.Anchor")));
			this.tboutgoing.AutoSize = ((bool)(resources.GetObject("tboutgoing.AutoSize")));
			this.tboutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tboutgoing.BackgroundImage")));
			this.tboutgoing.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tboutgoing.Dock")));
			this.tboutgoing.Enabled = ((bool)(resources.GetObject("tboutgoing.Enabled")));
			this.tboutgoing.Font = ((System.Drawing.Font)(resources.GetObject("tboutgoing.Font")));
			this.tboutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tboutgoing.ImeMode")));
			this.tboutgoing.Location = ((System.Drawing.Point)(resources.GetObject("tboutgoing.Location")));
			this.tboutgoing.MaxLength = ((int)(resources.GetObject("tboutgoing.MaxLength")));
			this.tboutgoing.Multiline = ((bool)(resources.GetObject("tboutgoing.Multiline")));
			this.tboutgoing.Name = "tboutgoing";
			this.tboutgoing.PasswordChar = ((char)(resources.GetObject("tboutgoing.PasswordChar")));
			this.tboutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tboutgoing.RightToLeft")));
			this.tboutgoing.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tboutgoing.ScrollBars")));
			this.tboutgoing.Size = ((System.Drawing.Size)(resources.GetObject("tboutgoing.Size")));
			this.tboutgoing.TabIndex = ((int)(resources.GetObject("tboutgoing.TabIndex")));
			this.tboutgoing.Text = resources.GetString("tboutgoing.Text");
			this.tboutgoing.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tboutgoing.TextAlign")));
			this.toolTip1.SetToolTip(this.tboutgoing, resources.GetString("tboutgoing.ToolTip"));
			this.tboutgoing.Visible = ((bool)(resources.GetObject("tboutgoing.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tboutgoing, true);
			this.tboutgoing.WordWrap = ((bool)(resources.GetObject("tboutgoing.WordWrap")));
			this.tboutgoing.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tboutgoing.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbneat
			// 
			this.tbneat.AccessibleDescription = resources.GetString("tbneat.AccessibleDescription");
			this.tbneat.AccessibleName = resources.GetString("tbneat.AccessibleName");
			this.tbneat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbneat.Anchor")));
			this.tbneat.AutoSize = ((bool)(resources.GetObject("tbneat.AutoSize")));
			this.tbneat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbneat.BackgroundImage")));
			this.tbneat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbneat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbneat.Dock")));
			this.tbneat.Enabled = ((bool)(resources.GetObject("tbneat.Enabled")));
			this.tbneat.Font = ((System.Drawing.Font)(resources.GetObject("tbneat.Font")));
			this.tbneat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbneat.ImeMode")));
			this.tbneat.Location = ((System.Drawing.Point)(resources.GetObject("tbneat.Location")));
			this.tbneat.MaxLength = ((int)(resources.GetObject("tbneat.MaxLength")));
			this.tbneat.Multiline = ((bool)(resources.GetObject("tbneat.Multiline")));
			this.tbneat.Name = "tbneat";
			this.tbneat.PasswordChar = ((char)(resources.GetObject("tbneat.PasswordChar")));
			this.tbneat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbneat.RightToLeft")));
			this.tbneat.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbneat.ScrollBars")));
			this.tbneat.Size = ((System.Drawing.Size)(resources.GetObject("tbneat.Size")));
			this.tbneat.TabIndex = ((int)(resources.GetObject("tbneat.TabIndex")));
			this.tbneat.Text = resources.GetString("tbneat.Text");
			this.tbneat.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbneat.TextAlign")));
			this.toolTip1.SetToolTip(this.tbneat, resources.GetString("tbneat.ToolTip"));
			this.tbneat.Visible = ((bool)(resources.GetObject("tbneat.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbneat, true);
			this.tbneat.WordWrap = ((bool)(resources.GetObject("tbneat.WordWrap")));
			this.tbneat.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbneat.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbnice
			// 
			this.pbnice.AccessibleDescription = resources.GetString("pbnice.AccessibleDescription");
			this.pbnice.AccessibleName = resources.GetString("pbnice.AccessibleName");
			this.pbnice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbnice.Anchor")));
			this.pbnice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbnice.BackgroundImage")));
			this.pbnice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbnice.Dock")));
			this.pbnice.Enabled = ((bool)(resources.GetObject("pbnice.Enabled")));
			this.pbnice.Font = ((System.Drawing.Font)(resources.GetObject("pbnice.Font")));
			this.pbnice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbnice.ImeMode")));
			this.pbnice.Location = ((System.Drawing.Point)(resources.GetObject("pbnice.Location")));
			this.pbnice.Maximum = 10;
			this.pbnice.Name = "pbnice";
			this.pbnice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbnice.RightToLeft")));
			this.pbnice.Size = ((System.Drawing.Size)(resources.GetObject("pbnice.Size")));
			this.pbnice.Step = 1;
			this.pbnice.TabIndex = ((int)(resources.GetObject("pbnice.TabIndex")));
			this.pbnice.Text = resources.GetString("pbnice.Text");
			this.toolTip1.SetToolTip(this.pbnice, resources.GetString("pbnice.ToolTip"));
			this.pbnice.Visible = ((bool)(resources.GetObject("pbnice.Visible")));
			this.pbnice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbnice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbnice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbplayful
			// 
			this.pbplayful.AccessibleDescription = resources.GetString("pbplayful.AccessibleDescription");
			this.pbplayful.AccessibleName = resources.GetString("pbplayful.AccessibleName");
			this.pbplayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbplayful.Anchor")));
			this.pbplayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbplayful.BackgroundImage")));
			this.pbplayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbplayful.Dock")));
			this.pbplayful.Enabled = ((bool)(resources.GetObject("pbplayful.Enabled")));
			this.pbplayful.Font = ((System.Drawing.Font)(resources.GetObject("pbplayful.Font")));
			this.pbplayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbplayful.ImeMode")));
			this.pbplayful.Location = ((System.Drawing.Point)(resources.GetObject("pbplayful.Location")));
			this.pbplayful.Maximum = 10;
			this.pbplayful.Name = "pbplayful";
			this.pbplayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbplayful.RightToLeft")));
			this.pbplayful.Size = ((System.Drawing.Size)(resources.GetObject("pbplayful.Size")));
			this.pbplayful.Step = 1;
			this.pbplayful.TabIndex = ((int)(resources.GetObject("pbplayful.TabIndex")));
			this.pbplayful.Text = resources.GetString("pbplayful.Text");
			this.toolTip1.SetToolTip(this.pbplayful, resources.GetString("pbplayful.ToolTip"));
			this.pbplayful.Visible = ((bool)(resources.GetObject("pbplayful.Visible")));
			this.pbplayful.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbplayful.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbplayful.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbactive
			// 
			this.pbactive.AccessibleDescription = resources.GetString("pbactive.AccessibleDescription");
			this.pbactive.AccessibleName = resources.GetString("pbactive.AccessibleName");
			this.pbactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbactive.Anchor")));
			this.pbactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbactive.BackgroundImage")));
			this.pbactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbactive.Dock")));
			this.pbactive.Enabled = ((bool)(resources.GetObject("pbactive.Enabled")));
			this.pbactive.Font = ((System.Drawing.Font)(resources.GetObject("pbactive.Font")));
			this.pbactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbactive.ImeMode")));
			this.pbactive.Location = ((System.Drawing.Point)(resources.GetObject("pbactive.Location")));
			this.pbactive.Maximum = 10;
			this.pbactive.Name = "pbactive";
			this.pbactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbactive.RightToLeft")));
			this.pbactive.Size = ((System.Drawing.Size)(resources.GetObject("pbactive.Size")));
			this.pbactive.Step = 1;
			this.pbactive.TabIndex = ((int)(resources.GetObject("pbactive.TabIndex")));
			this.pbactive.Text = resources.GetString("pbactive.Text");
			this.toolTip1.SetToolTip(this.pbactive, resources.GetString("pbactive.ToolTip"));
			this.pbactive.Visible = ((bool)(resources.GetObject("pbactive.Visible")));
			this.pbactive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbactive.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbactive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pboutgoing
			// 
			this.pboutgoing.AccessibleDescription = resources.GetString("pboutgoing.AccessibleDescription");
			this.pboutgoing.AccessibleName = resources.GetString("pboutgoing.AccessibleName");
			this.pboutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pboutgoing.Anchor")));
			this.pboutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pboutgoing.BackgroundImage")));
			this.pboutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pboutgoing.Dock")));
			this.pboutgoing.Enabled = ((bool)(resources.GetObject("pboutgoing.Enabled")));
			this.pboutgoing.Font = ((System.Drawing.Font)(resources.GetObject("pboutgoing.Font")));
			this.pboutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pboutgoing.ImeMode")));
			this.pboutgoing.Location = ((System.Drawing.Point)(resources.GetObject("pboutgoing.Location")));
			this.pboutgoing.Maximum = 10;
			this.pboutgoing.Name = "pboutgoing";
			this.pboutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pboutgoing.RightToLeft")));
			this.pboutgoing.Size = ((System.Drawing.Size)(resources.GetObject("pboutgoing.Size")));
			this.pboutgoing.Step = 1;
			this.pboutgoing.TabIndex = ((int)(resources.GetObject("pboutgoing.TabIndex")));
			this.pboutgoing.Text = resources.GetString("pboutgoing.Text");
			this.toolTip1.SetToolTip(this.pboutgoing, resources.GetString("pboutgoing.ToolTip"));
			this.pboutgoing.Visible = ((bool)(resources.GetObject("pboutgoing.Visible")));
			this.pboutgoing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pboutgoing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pboutgoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label20
			// 
			this.label20.AccessibleDescription = resources.GetString("label20.AccessibleDescription");
			this.label20.AccessibleName = resources.GetString("label20.AccessibleName");
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label20.Anchor")));
			this.label20.AutoSize = ((bool)(resources.GetObject("label20.AutoSize")));
			this.label20.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label20.Dock")));
			this.label20.Enabled = ((bool)(resources.GetObject("label20.Enabled")));
			this.label20.Font = ((System.Drawing.Font)(resources.GetObject("label20.Font")));
			this.label20.Image = ((System.Drawing.Image)(resources.GetObject("label20.Image")));
			this.label20.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label20.ImageAlign")));
			this.label20.ImageIndex = ((int)(resources.GetObject("label20.ImageIndex")));
			this.label20.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label20.ImeMode")));
			this.label20.Location = ((System.Drawing.Point)(resources.GetObject("label20.Location")));
			this.label20.Name = "label20";
			this.label20.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label20.RightToLeft")));
			this.label20.Size = ((System.Drawing.Size)(resources.GetObject("label20.Size")));
			this.label20.TabIndex = ((int)(resources.GetObject("label20.TabIndex")));
			this.label20.Text = resources.GetString("label20.Text");
			this.label20.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label20.TextAlign")));
			this.toolTip1.SetToolTip(this.label20, resources.GetString("label20.ToolTip"));
			this.label20.Visible = ((bool)(resources.GetObject("label20.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label20, true);
			// 
			// label19
			// 
			this.label19.AccessibleDescription = resources.GetString("label19.AccessibleDescription");
			this.label19.AccessibleName = resources.GetString("label19.AccessibleName");
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label19.Anchor")));
			this.label19.AutoSize = ((bool)(resources.GetObject("label19.AutoSize")));
			this.label19.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label19.Dock")));
			this.label19.Enabled = ((bool)(resources.GetObject("label19.Enabled")));
			this.label19.Font = ((System.Drawing.Font)(resources.GetObject("label19.Font")));
			this.label19.Image = ((System.Drawing.Image)(resources.GetObject("label19.Image")));
			this.label19.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label19.ImageAlign")));
			this.label19.ImageIndex = ((int)(resources.GetObject("label19.ImageIndex")));
			this.label19.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label19.ImeMode")));
			this.label19.Location = ((System.Drawing.Point)(resources.GetObject("label19.Location")));
			this.label19.Name = "label19";
			this.label19.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label19.RightToLeft")));
			this.label19.Size = ((System.Drawing.Size)(resources.GetObject("label19.Size")));
			this.label19.TabIndex = ((int)(resources.GetObject("label19.TabIndex")));
			this.label19.Text = resources.GetString("label19.Text");
			this.label19.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label19.TextAlign")));
			this.toolTip1.SetToolTip(this.label19, resources.GetString("label19.ToolTip"));
			this.label19.Visible = ((bool)(resources.GetObject("label19.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label19, true);
			// 
			// label18
			// 
			this.label18.AccessibleDescription = resources.GetString("label18.AccessibleDescription");
			this.label18.AccessibleName = resources.GetString("label18.AccessibleName");
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label18.Anchor")));
			this.label18.AutoSize = ((bool)(resources.GetObject("label18.AutoSize")));
			this.label18.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label18.Dock")));
			this.label18.Enabled = ((bool)(resources.GetObject("label18.Enabled")));
			this.label18.Font = ((System.Drawing.Font)(resources.GetObject("label18.Font")));
			this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
			this.label18.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label18.ImageAlign")));
			this.label18.ImageIndex = ((int)(resources.GetObject("label18.ImageIndex")));
			this.label18.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label18.ImeMode")));
			this.label18.Location = ((System.Drawing.Point)(resources.GetObject("label18.Location")));
			this.label18.Name = "label18";
			this.label18.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label18.RightToLeft")));
			this.label18.Size = ((System.Drawing.Size)(resources.GetObject("label18.Size")));
			this.label18.TabIndex = ((int)(resources.GetObject("label18.TabIndex")));
			this.label18.Text = resources.GetString("label18.Text");
			this.label18.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label18.TextAlign")));
			this.toolTip1.SetToolTip(this.label18, resources.GetString("label18.ToolTip"));
			this.label18.Visible = ((bool)(resources.GetObject("label18.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label18, true);
			// 
			// label17
			// 
			this.label17.AccessibleDescription = resources.GetString("label17.AccessibleDescription");
			this.label17.AccessibleName = resources.GetString("label17.AccessibleName");
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label17.Anchor")));
			this.label17.AutoSize = ((bool)(resources.GetObject("label17.AutoSize")));
			this.label17.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label17.Dock")));
			this.label17.Enabled = ((bool)(resources.GetObject("label17.Enabled")));
			this.label17.Font = ((System.Drawing.Font)(resources.GetObject("label17.Font")));
			this.label17.Image = ((System.Drawing.Image)(resources.GetObject("label17.Image")));
			this.label17.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label17.ImageAlign")));
			this.label17.ImageIndex = ((int)(resources.GetObject("label17.ImageIndex")));
			this.label17.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label17.ImeMode")));
			this.label17.Location = ((System.Drawing.Point)(resources.GetObject("label17.Location")));
			this.label17.Name = "label17";
			this.label17.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label17.RightToLeft")));
			this.label17.Size = ((System.Drawing.Size)(resources.GetObject("label17.Size")));
			this.label17.TabIndex = ((int)(resources.GetObject("label17.TabIndex")));
			this.label17.Text = resources.GetString("label17.Text");
			this.label17.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label17.TextAlign")));
			this.toolTip1.SetToolTip(this.label17, resources.GetString("label17.ToolTip"));
			this.label17.Visible = ((bool)(resources.GetObject("label17.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label17, true);
			// 
			// label16
			// 
			this.label16.AccessibleDescription = resources.GetString("label16.AccessibleDescription");
			this.label16.AccessibleName = resources.GetString("label16.AccessibleName");
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label16.Anchor")));
			this.label16.AutoSize = ((bool)(resources.GetObject("label16.AutoSize")));
			this.label16.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label16.Dock")));
			this.label16.Enabled = ((bool)(resources.GetObject("label16.Enabled")));
			this.label16.Font = ((System.Drawing.Font)(resources.GetObject("label16.Font")));
			this.label16.Image = ((System.Drawing.Image)(resources.GetObject("label16.Image")));
			this.label16.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.ImageAlign")));
			this.label16.ImageIndex = ((int)(resources.GetObject("label16.ImageIndex")));
			this.label16.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label16.ImeMode")));
			this.label16.Location = ((System.Drawing.Point)(resources.GetObject("label16.Location")));
			this.label16.Name = "label16";
			this.label16.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label16.RightToLeft")));
			this.label16.Size = ((System.Drawing.Size)(resources.GetObject("label16.Size")));
			this.label16.TabIndex = ((int)(resources.GetObject("label16.TabIndex")));
			this.label16.Text = resources.GetString("label16.Text");
			this.label16.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label16.TextAlign")));
			this.toolTip1.SetToolTip(this.label16, resources.GetString("label16.ToolTip"));
			this.label16.Visible = ((bool)(resources.GetObject("label16.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label16, true);
			// 
			// linkLabel3
			// 
			this.linkLabel3.AccessibleDescription = resources.GetString("linkLabel3.AccessibleDescription");
			this.linkLabel3.AccessibleName = resources.GetString("linkLabel3.AccessibleName");
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel3.Anchor")));
			this.linkLabel3.AutoSize = ((bool)(resources.GetObject("linkLabel3.AutoSize")));
			this.linkLabel3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel3.Dock")));
			this.linkLabel3.Enabled = ((bool)(resources.GetObject("linkLabel3.Enabled")));
			this.linkLabel3.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel3.Font")));
			this.linkLabel3.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel3.Image")));
			this.linkLabel3.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel3.ImageAlign")));
			this.linkLabel3.ImageIndex = ((int)(resources.GetObject("linkLabel3.ImageIndex")));
			this.linkLabel3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel3.ImeMode")));
			this.linkLabel3.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel3.LinkArea")));
			this.linkLabel3.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel3.Location")));
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel3.RightToLeft")));
			this.linkLabel3.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel3.Size")));
			this.linkLabel3.TabIndex = ((int)(resources.GetObject("linkLabel3.TabIndex")));
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = resources.GetString("linkLabel3.Text");
			this.linkLabel3.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel3.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel3, resources.GetString("linkLabel3.ToolTip"));
			this.linkLabel3.Visible = ((bool)(resources.GetObject("linkLabel3.Visible")));
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CharacterProgressMaxClick);
			// 
			// gbgencharacter
			// 
			this.gbgencharacter.AccessibleDescription = resources.GetString("gbgencharacter.AccessibleDescription");
			this.gbgencharacter.AccessibleName = resources.GetString("gbgencharacter.AccessibleName");
			this.gbgencharacter.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbgencharacter.Anchor")));
			this.gbgencharacter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbgencharacter.BackgroundImage")));
			this.gbgencharacter.Controls.Add(this.label71);
			this.gbgencharacter.Controls.Add(this.label72);
			this.gbgencharacter.Controls.Add(this.label73);
			this.gbgencharacter.Controls.Add(this.label74);
			this.gbgencharacter.Controls.Add(this.label75);
			this.gbgencharacter.Controls.Add(this.pbgenneat);
			this.gbgencharacter.Controls.Add(this.tbgennice);
			this.gbgencharacter.Controls.Add(this.tbgenplayful);
			this.gbgencharacter.Controls.Add(this.tbgenactive);
			this.gbgencharacter.Controls.Add(this.tbgenoutgoing);
			this.gbgencharacter.Controls.Add(this.tbgenneat);
			this.gbgencharacter.Controls.Add(this.pbgennice);
			this.gbgencharacter.Controls.Add(this.pbgenplayful);
			this.gbgencharacter.Controls.Add(this.pbgenactive);
			this.gbgencharacter.Controls.Add(this.pbgenoutgoing);
			this.gbgencharacter.Controls.Add(this.linkLabel4);
			this.gbgencharacter.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbgencharacter.Dock")));
			this.gbgencharacter.Enabled = ((bool)(resources.GetObject("gbgencharacter.Enabled")));
			this.gbgencharacter.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbgencharacter.Font = ((System.Drawing.Font)(resources.GetObject("gbgencharacter.Font")));
			this.gbgencharacter.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbgencharacter.ImeMode")));
			this.gbgencharacter.Location = ((System.Drawing.Point)(resources.GetObject("gbgencharacter.Location")));
			this.gbgencharacter.Name = "gbgencharacter";
			this.gbgencharacter.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbgencharacter.RightToLeft")));
			this.gbgencharacter.Size = ((System.Drawing.Size)(resources.GetObject("gbgencharacter.Size")));
			this.gbgencharacter.TabIndex = ((int)(resources.GetObject("gbgencharacter.TabIndex")));
			this.gbgencharacter.TabStop = false;
			this.gbgencharacter.Text = resources.GetString("gbgencharacter.Text");
			this.toolTip1.SetToolTip(this.gbgencharacter, resources.GetString("gbgencharacter.ToolTip"));
			this.gbgencharacter.Visible = ((bool)(resources.GetObject("gbgencharacter.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbgencharacter, true);
			// 
			// label71
			// 
			this.label71.AccessibleDescription = resources.GetString("label71.AccessibleDescription");
			this.label71.AccessibleName = resources.GetString("label71.AccessibleName");
			this.label71.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label71.Anchor")));
			this.label71.AutoSize = ((bool)(resources.GetObject("label71.AutoSize")));
			this.label71.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label71.Dock")));
			this.label71.Enabled = ((bool)(resources.GetObject("label71.Enabled")));
			this.label71.Font = ((System.Drawing.Font)(resources.GetObject("label71.Font")));
			this.label71.Image = ((System.Drawing.Image)(resources.GetObject("label71.Image")));
			this.label71.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label71.ImageAlign")));
			this.label71.ImageIndex = ((int)(resources.GetObject("label71.ImageIndex")));
			this.label71.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label71.ImeMode")));
			this.label71.Location = ((System.Drawing.Point)(resources.GetObject("label71.Location")));
			this.label71.Name = "label71";
			this.label71.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label71.RightToLeft")));
			this.label71.Size = ((System.Drawing.Size)(resources.GetObject("label71.Size")));
			this.label71.TabIndex = ((int)(resources.GetObject("label71.TabIndex")));
			this.label71.Text = resources.GetString("label71.Text");
			this.label71.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label71.TextAlign")));
			this.toolTip1.SetToolTip(this.label71, resources.GetString("label71.ToolTip"));
			this.label71.Visible = ((bool)(resources.GetObject("label71.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label71, true);
			// 
			// label72
			// 
			this.label72.AccessibleDescription = resources.GetString("label72.AccessibleDescription");
			this.label72.AccessibleName = resources.GetString("label72.AccessibleName");
			this.label72.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label72.Anchor")));
			this.label72.AutoSize = ((bool)(resources.GetObject("label72.AutoSize")));
			this.label72.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label72.Dock")));
			this.label72.Enabled = ((bool)(resources.GetObject("label72.Enabled")));
			this.label72.Font = ((System.Drawing.Font)(resources.GetObject("label72.Font")));
			this.label72.Image = ((System.Drawing.Image)(resources.GetObject("label72.Image")));
			this.label72.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label72.ImageAlign")));
			this.label72.ImageIndex = ((int)(resources.GetObject("label72.ImageIndex")));
			this.label72.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label72.ImeMode")));
			this.label72.Location = ((System.Drawing.Point)(resources.GetObject("label72.Location")));
			this.label72.Name = "label72";
			this.label72.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label72.RightToLeft")));
			this.label72.Size = ((System.Drawing.Size)(resources.GetObject("label72.Size")));
			this.label72.TabIndex = ((int)(resources.GetObject("label72.TabIndex")));
			this.label72.Text = resources.GetString("label72.Text");
			this.label72.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label72.TextAlign")));
			this.toolTip1.SetToolTip(this.label72, resources.GetString("label72.ToolTip"));
			this.label72.Visible = ((bool)(resources.GetObject("label72.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label72, true);
			// 
			// label73
			// 
			this.label73.AccessibleDescription = resources.GetString("label73.AccessibleDescription");
			this.label73.AccessibleName = resources.GetString("label73.AccessibleName");
			this.label73.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label73.Anchor")));
			this.label73.AutoSize = ((bool)(resources.GetObject("label73.AutoSize")));
			this.label73.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label73.Dock")));
			this.label73.Enabled = ((bool)(resources.GetObject("label73.Enabled")));
			this.label73.Font = ((System.Drawing.Font)(resources.GetObject("label73.Font")));
			this.label73.Image = ((System.Drawing.Image)(resources.GetObject("label73.Image")));
			this.label73.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label73.ImageAlign")));
			this.label73.ImageIndex = ((int)(resources.GetObject("label73.ImageIndex")));
			this.label73.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label73.ImeMode")));
			this.label73.Location = ((System.Drawing.Point)(resources.GetObject("label73.Location")));
			this.label73.Name = "label73";
			this.label73.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label73.RightToLeft")));
			this.label73.Size = ((System.Drawing.Size)(resources.GetObject("label73.Size")));
			this.label73.TabIndex = ((int)(resources.GetObject("label73.TabIndex")));
			this.label73.Text = resources.GetString("label73.Text");
			this.label73.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label73.TextAlign")));
			this.toolTip1.SetToolTip(this.label73, resources.GetString("label73.ToolTip"));
			this.label73.Visible = ((bool)(resources.GetObject("label73.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label73, true);
			// 
			// label74
			// 
			this.label74.AccessibleDescription = resources.GetString("label74.AccessibleDescription");
			this.label74.AccessibleName = resources.GetString("label74.AccessibleName");
			this.label74.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label74.Anchor")));
			this.label74.AutoSize = ((bool)(resources.GetObject("label74.AutoSize")));
			this.label74.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label74.Dock")));
			this.label74.Enabled = ((bool)(resources.GetObject("label74.Enabled")));
			this.label74.Font = ((System.Drawing.Font)(resources.GetObject("label74.Font")));
			this.label74.Image = ((System.Drawing.Image)(resources.GetObject("label74.Image")));
			this.label74.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label74.ImageAlign")));
			this.label74.ImageIndex = ((int)(resources.GetObject("label74.ImageIndex")));
			this.label74.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label74.ImeMode")));
			this.label74.Location = ((System.Drawing.Point)(resources.GetObject("label74.Location")));
			this.label74.Name = "label74";
			this.label74.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label74.RightToLeft")));
			this.label74.Size = ((System.Drawing.Size)(resources.GetObject("label74.Size")));
			this.label74.TabIndex = ((int)(resources.GetObject("label74.TabIndex")));
			this.label74.Text = resources.GetString("label74.Text");
			this.label74.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label74.TextAlign")));
			this.toolTip1.SetToolTip(this.label74, resources.GetString("label74.ToolTip"));
			this.label74.Visible = ((bool)(resources.GetObject("label74.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label74, true);
			// 
			// label75
			// 
			this.label75.AccessibleDescription = resources.GetString("label75.AccessibleDescription");
			this.label75.AccessibleName = resources.GetString("label75.AccessibleName");
			this.label75.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label75.Anchor")));
			this.label75.AutoSize = ((bool)(resources.GetObject("label75.AutoSize")));
			this.label75.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label75.Dock")));
			this.label75.Enabled = ((bool)(resources.GetObject("label75.Enabled")));
			this.label75.Font = ((System.Drawing.Font)(resources.GetObject("label75.Font")));
			this.label75.Image = ((System.Drawing.Image)(resources.GetObject("label75.Image")));
			this.label75.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label75.ImageAlign")));
			this.label75.ImageIndex = ((int)(resources.GetObject("label75.ImageIndex")));
			this.label75.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label75.ImeMode")));
			this.label75.Location = ((System.Drawing.Point)(resources.GetObject("label75.Location")));
			this.label75.Name = "label75";
			this.label75.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label75.RightToLeft")));
			this.label75.Size = ((System.Drawing.Size)(resources.GetObject("label75.Size")));
			this.label75.TabIndex = ((int)(resources.GetObject("label75.TabIndex")));
			this.label75.Text = resources.GetString("label75.Text");
			this.label75.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label75.TextAlign")));
			this.toolTip1.SetToolTip(this.label75, resources.GetString("label75.ToolTip"));
			this.label75.Visible = ((bool)(resources.GetObject("label75.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label75, true);
			// 
			// pbgenneat
			// 
			this.pbgenneat.AccessibleDescription = resources.GetString("pbgenneat.AccessibleDescription");
			this.pbgenneat.AccessibleName = resources.GetString("pbgenneat.AccessibleName");
			this.pbgenneat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbgenneat.Anchor")));
			this.pbgenneat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbgenneat.BackgroundImage")));
			this.pbgenneat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbgenneat.Dock")));
			this.pbgenneat.Enabled = ((bool)(resources.GetObject("pbgenneat.Enabled")));
			this.pbgenneat.Font = ((System.Drawing.Font)(resources.GetObject("pbgenneat.Font")));
			this.pbgenneat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbgenneat.ImeMode")));
			this.pbgenneat.Location = ((System.Drawing.Point)(resources.GetObject("pbgenneat.Location")));
			this.pbgenneat.Maximum = 10;
			this.pbgenneat.Name = "pbgenneat";
			this.pbgenneat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbgenneat.RightToLeft")));
			this.pbgenneat.Size = ((System.Drawing.Size)(resources.GetObject("pbgenneat.Size")));
			this.pbgenneat.Step = 1;
			this.pbgenneat.TabIndex = ((int)(resources.GetObject("pbgenneat.TabIndex")));
			this.pbgenneat.Text = resources.GetString("pbgenneat.Text");
			this.toolTip1.SetToolTip(this.pbgenneat, resources.GetString("pbgenneat.ToolTip"));
			this.pbgenneat.Visible = ((bool)(resources.GetObject("pbgenneat.Visible")));
			this.pbgenneat.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbgenneat.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbgenneat.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbgennice
			// 
			this.tbgennice.AccessibleDescription = resources.GetString("tbgennice.AccessibleDescription");
			this.tbgennice.AccessibleName = resources.GetString("tbgennice.AccessibleName");
			this.tbgennice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgennice.Anchor")));
			this.tbgennice.AutoSize = ((bool)(resources.GetObject("tbgennice.AutoSize")));
			this.tbgennice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgennice.BackgroundImage")));
			this.tbgennice.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbgennice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgennice.Dock")));
			this.tbgennice.Enabled = ((bool)(resources.GetObject("tbgennice.Enabled")));
			this.tbgennice.Font = ((System.Drawing.Font)(resources.GetObject("tbgennice.Font")));
			this.tbgennice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgennice.ImeMode")));
			this.tbgennice.Location = ((System.Drawing.Point)(resources.GetObject("tbgennice.Location")));
			this.tbgennice.MaxLength = ((int)(resources.GetObject("tbgennice.MaxLength")));
			this.tbgennice.Multiline = ((bool)(resources.GetObject("tbgennice.Multiline")));
			this.tbgennice.Name = "tbgennice";
			this.tbgennice.PasswordChar = ((char)(resources.GetObject("tbgennice.PasswordChar")));
			this.tbgennice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgennice.RightToLeft")));
			this.tbgennice.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgennice.ScrollBars")));
			this.tbgennice.Size = ((System.Drawing.Size)(resources.GetObject("tbgennice.Size")));
			this.tbgennice.TabIndex = ((int)(resources.GetObject("tbgennice.TabIndex")));
			this.tbgennice.Text = resources.GetString("tbgennice.Text");
			this.tbgennice.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgennice.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgennice, resources.GetString("tbgennice.ToolTip"));
			this.tbgennice.Visible = ((bool)(resources.GetObject("tbgennice.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbgennice, true);
			this.tbgennice.WordWrap = ((bool)(resources.GetObject("tbgennice.WordWrap")));
			this.tbgennice.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbgennice.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbgenplayful
			// 
			this.tbgenplayful.AccessibleDescription = resources.GetString("tbgenplayful.AccessibleDescription");
			this.tbgenplayful.AccessibleName = resources.GetString("tbgenplayful.AccessibleName");
			this.tbgenplayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgenplayful.Anchor")));
			this.tbgenplayful.AutoSize = ((bool)(resources.GetObject("tbgenplayful.AutoSize")));
			this.tbgenplayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgenplayful.BackgroundImage")));
			this.tbgenplayful.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbgenplayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgenplayful.Dock")));
			this.tbgenplayful.Enabled = ((bool)(resources.GetObject("tbgenplayful.Enabled")));
			this.tbgenplayful.Font = ((System.Drawing.Font)(resources.GetObject("tbgenplayful.Font")));
			this.tbgenplayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgenplayful.ImeMode")));
			this.tbgenplayful.Location = ((System.Drawing.Point)(resources.GetObject("tbgenplayful.Location")));
			this.tbgenplayful.MaxLength = ((int)(resources.GetObject("tbgenplayful.MaxLength")));
			this.tbgenplayful.Multiline = ((bool)(resources.GetObject("tbgenplayful.Multiline")));
			this.tbgenplayful.Name = "tbgenplayful";
			this.tbgenplayful.PasswordChar = ((char)(resources.GetObject("tbgenplayful.PasswordChar")));
			this.tbgenplayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgenplayful.RightToLeft")));
			this.tbgenplayful.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgenplayful.ScrollBars")));
			this.tbgenplayful.Size = ((System.Drawing.Size)(resources.GetObject("tbgenplayful.Size")));
			this.tbgenplayful.TabIndex = ((int)(resources.GetObject("tbgenplayful.TabIndex")));
			this.tbgenplayful.Text = resources.GetString("tbgenplayful.Text");
			this.tbgenplayful.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgenplayful.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgenplayful, resources.GetString("tbgenplayful.ToolTip"));
			this.tbgenplayful.Visible = ((bool)(resources.GetObject("tbgenplayful.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbgenplayful, true);
			this.tbgenplayful.WordWrap = ((bool)(resources.GetObject("tbgenplayful.WordWrap")));
			this.tbgenplayful.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbgenplayful.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbgenactive
			// 
			this.tbgenactive.AccessibleDescription = resources.GetString("tbgenactive.AccessibleDescription");
			this.tbgenactive.AccessibleName = resources.GetString("tbgenactive.AccessibleName");
			this.tbgenactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgenactive.Anchor")));
			this.tbgenactive.AutoSize = ((bool)(resources.GetObject("tbgenactive.AutoSize")));
			this.tbgenactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgenactive.BackgroundImage")));
			this.tbgenactive.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbgenactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgenactive.Dock")));
			this.tbgenactive.Enabled = ((bool)(resources.GetObject("tbgenactive.Enabled")));
			this.tbgenactive.Font = ((System.Drawing.Font)(resources.GetObject("tbgenactive.Font")));
			this.tbgenactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgenactive.ImeMode")));
			this.tbgenactive.Location = ((System.Drawing.Point)(resources.GetObject("tbgenactive.Location")));
			this.tbgenactive.MaxLength = ((int)(resources.GetObject("tbgenactive.MaxLength")));
			this.tbgenactive.Multiline = ((bool)(resources.GetObject("tbgenactive.Multiline")));
			this.tbgenactive.Name = "tbgenactive";
			this.tbgenactive.PasswordChar = ((char)(resources.GetObject("tbgenactive.PasswordChar")));
			this.tbgenactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgenactive.RightToLeft")));
			this.tbgenactive.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgenactive.ScrollBars")));
			this.tbgenactive.Size = ((System.Drawing.Size)(resources.GetObject("tbgenactive.Size")));
			this.tbgenactive.TabIndex = ((int)(resources.GetObject("tbgenactive.TabIndex")));
			this.tbgenactive.Text = resources.GetString("tbgenactive.Text");
			this.tbgenactive.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgenactive.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgenactive, resources.GetString("tbgenactive.ToolTip"));
			this.tbgenactive.Visible = ((bool)(resources.GetObject("tbgenactive.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbgenactive, true);
			this.tbgenactive.WordWrap = ((bool)(resources.GetObject("tbgenactive.WordWrap")));
			this.tbgenactive.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbgenactive.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbgenoutgoing
			// 
			this.tbgenoutgoing.AccessibleDescription = resources.GetString("tbgenoutgoing.AccessibleDescription");
			this.tbgenoutgoing.AccessibleName = resources.GetString("tbgenoutgoing.AccessibleName");
			this.tbgenoutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgenoutgoing.Anchor")));
			this.tbgenoutgoing.AutoSize = ((bool)(resources.GetObject("tbgenoutgoing.AutoSize")));
			this.tbgenoutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgenoutgoing.BackgroundImage")));
			this.tbgenoutgoing.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbgenoutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgenoutgoing.Dock")));
			this.tbgenoutgoing.Enabled = ((bool)(resources.GetObject("tbgenoutgoing.Enabled")));
			this.tbgenoutgoing.Font = ((System.Drawing.Font)(resources.GetObject("tbgenoutgoing.Font")));
			this.tbgenoutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgenoutgoing.ImeMode")));
			this.tbgenoutgoing.Location = ((System.Drawing.Point)(resources.GetObject("tbgenoutgoing.Location")));
			this.tbgenoutgoing.MaxLength = ((int)(resources.GetObject("tbgenoutgoing.MaxLength")));
			this.tbgenoutgoing.Multiline = ((bool)(resources.GetObject("tbgenoutgoing.Multiline")));
			this.tbgenoutgoing.Name = "tbgenoutgoing";
			this.tbgenoutgoing.PasswordChar = ((char)(resources.GetObject("tbgenoutgoing.PasswordChar")));
			this.tbgenoutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgenoutgoing.RightToLeft")));
			this.tbgenoutgoing.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgenoutgoing.ScrollBars")));
			this.tbgenoutgoing.Size = ((System.Drawing.Size)(resources.GetObject("tbgenoutgoing.Size")));
			this.tbgenoutgoing.TabIndex = ((int)(resources.GetObject("tbgenoutgoing.TabIndex")));
			this.tbgenoutgoing.Text = resources.GetString("tbgenoutgoing.Text");
			this.tbgenoutgoing.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgenoutgoing.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgenoutgoing, resources.GetString("tbgenoutgoing.ToolTip"));
			this.tbgenoutgoing.Visible = ((bool)(resources.GetObject("tbgenoutgoing.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbgenoutgoing, true);
			this.tbgenoutgoing.WordWrap = ((bool)(resources.GetObject("tbgenoutgoing.WordWrap")));
			this.tbgenoutgoing.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbgenoutgoing.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbgenneat
			// 
			this.tbgenneat.AccessibleDescription = resources.GetString("tbgenneat.AccessibleDescription");
			this.tbgenneat.AccessibleName = resources.GetString("tbgenneat.AccessibleName");
			this.tbgenneat.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbgenneat.Anchor")));
			this.tbgenneat.AutoSize = ((bool)(resources.GetObject("tbgenneat.AutoSize")));
			this.tbgenneat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbgenneat.BackgroundImage")));
			this.tbgenneat.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbgenneat.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbgenneat.Dock")));
			this.tbgenneat.Enabled = ((bool)(resources.GetObject("tbgenneat.Enabled")));
			this.tbgenneat.Font = ((System.Drawing.Font)(resources.GetObject("tbgenneat.Font")));
			this.tbgenneat.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbgenneat.ImeMode")));
			this.tbgenneat.Location = ((System.Drawing.Point)(resources.GetObject("tbgenneat.Location")));
			this.tbgenneat.MaxLength = ((int)(resources.GetObject("tbgenneat.MaxLength")));
			this.tbgenneat.Multiline = ((bool)(resources.GetObject("tbgenneat.Multiline")));
			this.tbgenneat.Name = "tbgenneat";
			this.tbgenneat.PasswordChar = ((char)(resources.GetObject("tbgenneat.PasswordChar")));
			this.tbgenneat.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbgenneat.RightToLeft")));
			this.tbgenneat.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbgenneat.ScrollBars")));
			this.tbgenneat.Size = ((System.Drawing.Size)(resources.GetObject("tbgenneat.Size")));
			this.tbgenneat.TabIndex = ((int)(resources.GetObject("tbgenneat.TabIndex")));
			this.tbgenneat.Text = resources.GetString("tbgenneat.Text");
			this.tbgenneat.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbgenneat.TextAlign")));
			this.toolTip1.SetToolTip(this.tbgenneat, resources.GetString("tbgenneat.ToolTip"));
			this.tbgenneat.Visible = ((bool)(resources.GetObject("tbgenneat.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbgenneat, true);
			this.tbgenneat.WordWrap = ((bool)(resources.GetObject("tbgenneat.WordWrap")));
			this.tbgenneat.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbgenneat.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbgennice
			// 
			this.pbgennice.AccessibleDescription = resources.GetString("pbgennice.AccessibleDescription");
			this.pbgennice.AccessibleName = resources.GetString("pbgennice.AccessibleName");
			this.pbgennice.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbgennice.Anchor")));
			this.pbgennice.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbgennice.BackgroundImage")));
			this.pbgennice.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbgennice.Dock")));
			this.pbgennice.Enabled = ((bool)(resources.GetObject("pbgennice.Enabled")));
			this.pbgennice.Font = ((System.Drawing.Font)(resources.GetObject("pbgennice.Font")));
			this.pbgennice.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbgennice.ImeMode")));
			this.pbgennice.Location = ((System.Drawing.Point)(resources.GetObject("pbgennice.Location")));
			this.pbgennice.Maximum = 10;
			this.pbgennice.Name = "pbgennice";
			this.pbgennice.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbgennice.RightToLeft")));
			this.pbgennice.Size = ((System.Drawing.Size)(resources.GetObject("pbgennice.Size")));
			this.pbgennice.Step = 1;
			this.pbgennice.TabIndex = ((int)(resources.GetObject("pbgennice.TabIndex")));
			this.pbgennice.Text = resources.GetString("pbgennice.Text");
			this.toolTip1.SetToolTip(this.pbgennice, resources.GetString("pbgennice.ToolTip"));
			this.pbgennice.Visible = ((bool)(resources.GetObject("pbgennice.Visible")));
			this.pbgennice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbgennice.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbgennice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbgenplayful
			// 
			this.pbgenplayful.AccessibleDescription = resources.GetString("pbgenplayful.AccessibleDescription");
			this.pbgenplayful.AccessibleName = resources.GetString("pbgenplayful.AccessibleName");
			this.pbgenplayful.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbgenplayful.Anchor")));
			this.pbgenplayful.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbgenplayful.BackgroundImage")));
			this.pbgenplayful.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbgenplayful.Dock")));
			this.pbgenplayful.Enabled = ((bool)(resources.GetObject("pbgenplayful.Enabled")));
			this.pbgenplayful.Font = ((System.Drawing.Font)(resources.GetObject("pbgenplayful.Font")));
			this.pbgenplayful.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbgenplayful.ImeMode")));
			this.pbgenplayful.Location = ((System.Drawing.Point)(resources.GetObject("pbgenplayful.Location")));
			this.pbgenplayful.Maximum = 10;
			this.pbgenplayful.Name = "pbgenplayful";
			this.pbgenplayful.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbgenplayful.RightToLeft")));
			this.pbgenplayful.Size = ((System.Drawing.Size)(resources.GetObject("pbgenplayful.Size")));
			this.pbgenplayful.Step = 1;
			this.pbgenplayful.TabIndex = ((int)(resources.GetObject("pbgenplayful.TabIndex")));
			this.pbgenplayful.Text = resources.GetString("pbgenplayful.Text");
			this.toolTip1.SetToolTip(this.pbgenplayful, resources.GetString("pbgenplayful.ToolTip"));
			this.pbgenplayful.Visible = ((bool)(resources.GetObject("pbgenplayful.Visible")));
			this.pbgenplayful.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbgenplayful.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbgenplayful.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbgenactive
			// 
			this.pbgenactive.AccessibleDescription = resources.GetString("pbgenactive.AccessibleDescription");
			this.pbgenactive.AccessibleName = resources.GetString("pbgenactive.AccessibleName");
			this.pbgenactive.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbgenactive.Anchor")));
			this.pbgenactive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbgenactive.BackgroundImage")));
			this.pbgenactive.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbgenactive.Dock")));
			this.pbgenactive.Enabled = ((bool)(resources.GetObject("pbgenactive.Enabled")));
			this.pbgenactive.Font = ((System.Drawing.Font)(resources.GetObject("pbgenactive.Font")));
			this.pbgenactive.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbgenactive.ImeMode")));
			this.pbgenactive.Location = ((System.Drawing.Point)(resources.GetObject("pbgenactive.Location")));
			this.pbgenactive.Maximum = 10;
			this.pbgenactive.Name = "pbgenactive";
			this.pbgenactive.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbgenactive.RightToLeft")));
			this.pbgenactive.Size = ((System.Drawing.Size)(resources.GetObject("pbgenactive.Size")));
			this.pbgenactive.Step = 1;
			this.pbgenactive.TabIndex = ((int)(resources.GetObject("pbgenactive.TabIndex")));
			this.pbgenactive.Text = resources.GetString("pbgenactive.Text");
			this.toolTip1.SetToolTip(this.pbgenactive, resources.GetString("pbgenactive.ToolTip"));
			this.pbgenactive.Visible = ((bool)(resources.GetObject("pbgenactive.Visible")));
			this.pbgenactive.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbgenactive.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbgenactive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbgenoutgoing
			// 
			this.pbgenoutgoing.AccessibleDescription = resources.GetString("pbgenoutgoing.AccessibleDescription");
			this.pbgenoutgoing.AccessibleName = resources.GetString("pbgenoutgoing.AccessibleName");
			this.pbgenoutgoing.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbgenoutgoing.Anchor")));
			this.pbgenoutgoing.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbgenoutgoing.BackgroundImage")));
			this.pbgenoutgoing.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbgenoutgoing.Dock")));
			this.pbgenoutgoing.Enabled = ((bool)(resources.GetObject("pbgenoutgoing.Enabled")));
			this.pbgenoutgoing.Font = ((System.Drawing.Font)(resources.GetObject("pbgenoutgoing.Font")));
			this.pbgenoutgoing.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbgenoutgoing.ImeMode")));
			this.pbgenoutgoing.Location = ((System.Drawing.Point)(resources.GetObject("pbgenoutgoing.Location")));
			this.pbgenoutgoing.Maximum = 10;
			this.pbgenoutgoing.Name = "pbgenoutgoing";
			this.pbgenoutgoing.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbgenoutgoing.RightToLeft")));
			this.pbgenoutgoing.Size = ((System.Drawing.Size)(resources.GetObject("pbgenoutgoing.Size")));
			this.pbgenoutgoing.Step = 1;
			this.pbgenoutgoing.TabIndex = ((int)(resources.GetObject("pbgenoutgoing.TabIndex")));
			this.pbgenoutgoing.Text = resources.GetString("pbgenoutgoing.Text");
			this.toolTip1.SetToolTip(this.pbgenoutgoing, resources.GetString("pbgenoutgoing.ToolTip"));
			this.pbgenoutgoing.Visible = ((bool)(resources.GetObject("pbgenoutgoing.Visible")));
			this.pbgenoutgoing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbgenoutgoing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbgenoutgoing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// linkLabel4
			// 
			this.linkLabel4.AccessibleDescription = resources.GetString("linkLabel4.AccessibleDescription");
			this.linkLabel4.AccessibleName = resources.GetString("linkLabel4.AccessibleName");
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel4.Anchor")));
			this.linkLabel4.AutoSize = ((bool)(resources.GetObject("linkLabel4.AutoSize")));
			this.linkLabel4.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel4.Dock")));
			this.linkLabel4.Enabled = ((bool)(resources.GetObject("linkLabel4.Enabled")));
			this.linkLabel4.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel4.Font")));
			this.linkLabel4.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel4.Image")));
			this.linkLabel4.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel4.ImageAlign")));
			this.linkLabel4.ImageIndex = ((int)(resources.GetObject("linkLabel4.ImageIndex")));
			this.linkLabel4.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel4.ImeMode")));
			this.linkLabel4.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel4.LinkArea")));
			this.linkLabel4.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel4.Location")));
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel4.RightToLeft")));
			this.linkLabel4.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel4.Size")));
			this.linkLabel4.TabIndex = ((int)(resources.GetObject("linkLabel4.TabIndex")));
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = resources.GetString("linkLabel4.Text");
			this.linkLabel4.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel4.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel4, resources.GetString("linkLabel4.ToolTip"));
			this.linkLabel4.Visible = ((bool)(resources.GetObject("linkLabel4.Visible")));
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GeneticCharacterProgressMaxClick);
			// 
			// gbschool
			// 
			this.gbschool.AccessibleDescription = resources.GetString("gbschool.AccessibleDescription");
			this.gbschool.AccessibleName = resources.GetString("gbschool.AccessibleName");
			this.gbschool.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbschool.Anchor")));
			this.gbschool.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbschool.BackgroundImage")));
			this.gbschool.Controls.Add(this.cbschooltype);
			this.gbschool.Controls.Add(this.cbgrade);
			this.gbschool.Controls.Add(this.label77);
			this.gbschool.Controls.Add(this.tbschooltype);
			this.gbschool.Controls.Add(this.label78);
			this.gbschool.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbschool.Dock")));
			this.gbschool.Enabled = ((bool)(resources.GetObject("gbschool.Enabled")));
			this.gbschool.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbschool.Font = ((System.Drawing.Font)(resources.GetObject("gbschool.Font")));
			this.gbschool.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbschool.ImeMode")));
			this.gbschool.Location = ((System.Drawing.Point)(resources.GetObject("gbschool.Location")));
			this.gbschool.Name = "gbschool";
			this.gbschool.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbschool.RightToLeft")));
			this.gbschool.Size = ((System.Drawing.Size)(resources.GetObject("gbschool.Size")));
			this.gbschool.TabIndex = ((int)(resources.GetObject("gbschool.TabIndex")));
			this.gbschool.TabStop = false;
			this.gbschool.Text = resources.GetString("gbschool.Text");
			this.toolTip1.SetToolTip(this.gbschool, resources.GetString("gbschool.ToolTip"));
			this.gbschool.Visible = ((bool)(resources.GetObject("gbschool.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbschool, true);
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
			this.toolTip1.SetToolTip(this.cbschooltype, resources.GetString("cbschooltype.ToolTip"));
			this.cbschooltype.Visible = ((bool)(resources.GetObject("cbschooltype.Visible")));
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
			this.toolTip1.SetToolTip(this.cbgrade, resources.GetString("cbgrade.ToolTip"));
			this.cbgrade.Visible = ((bool)(resources.GetObject("cbgrade.Visible")));
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
			this.toolTip1.SetToolTip(this.label77, resources.GetString("label77.ToolTip"));
			this.label77.Visible = ((bool)(resources.GetObject("label77.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label77, true);
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
			this.toolTip1.SetToolTip(this.tbschooltype, resources.GetString("tbschooltype.ToolTip"));
			this.tbschooltype.Visible = ((bool)(resources.GetObject("tbschooltype.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbschooltype, true);
			this.tbschooltype.WordWrap = ((bool)(resources.GetObject("tbschooltype.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label78, resources.GetString("label78.ToolTip"));
			this.label78.Visible = ((bool)(resources.GetObject("label78.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label78, true);
			// 
			// tbrelations
			// 
			this.tbrelations.AccessibleDescription = resources.GetString("tbrelations.AccessibleDescription");
			this.tbrelations.AccessibleName = resources.GetString("tbrelations.AccessibleName");
			this.tbrelations.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbrelations.Anchor")));
			this.tbrelations.AutoScroll = ((bool)(resources.GetObject("tbrelations.AutoScroll")));
			this.tbrelations.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbrelations.AutoScrollMargin")));
			this.tbrelations.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbrelations.AutoScrollMinSize")));
			this.tbrelations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbrelations.BackgroundImage")));
			this.tbrelations.Controls.Add(this.gb);
			this.tbrelations.Controls.Add(this.llsimrelcommit);
			this.tbrelations.Controls.Add(this.gbout);
			this.tbrelations.Controls.Add(this.lbrelations);
			this.tbrelations.Controls.Add(this.gbin);
			this.tbrelations.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbrelations.Dock")));
			this.tbrelations.Enabled = ((bool)(resources.GetObject("tbrelations.Enabled")));
			this.tbrelations.Font = ((System.Drawing.Font)(resources.GetObject("tbrelations.Font")));
			this.tbrelations.ImageIndex = ((int)(resources.GetObject("tbrelations.ImageIndex")));
			this.tbrelations.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbrelations.ImeMode")));
			this.tbrelations.Location = ((System.Drawing.Point)(resources.GetObject("tbrelations.Location")));
			this.tbrelations.Name = "tbrelations";
			this.tbrelations.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbrelations.RightToLeft")));
			this.tbrelations.Size = ((System.Drawing.Size)(resources.GetObject("tbrelations.Size")));
			this.tbrelations.TabIndex = ((int)(resources.GetObject("tbrelations.TabIndex")));
			this.tbrelations.Text = resources.GetString("tbrelations.Text");
			this.toolTip1.SetToolTip(this.tbrelations, resources.GetString("tbrelations.ToolTip"));
			this.tbrelations.ToolTipText = resources.GetString("tbrelations.ToolTipText");
			this.tbrelations.Visible = ((bool)(resources.GetObject("tbrelations.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbrelations, true);
			// 
			// gb
			// 
			this.gb.AccessibleDescription = resources.GetString("gb.AccessibleDescription");
			this.gb.AccessibleName = resources.GetString("gb.AccessibleName");
			this.gb.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gb.Anchor")));
			this.gb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gb.BackgroundImage")));
			this.gb.Controls.Add(this.cballrelsims);
			this.gb.Controls.Add(this.btaddrelation);
			this.gb.Controls.Add(this.btdeleterelation);
			this.gb.Controls.Add(this.label14);
			this.gb.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gb.Dock")));
			this.gb.Enabled = ((bool)(resources.GetObject("gb.Enabled")));
			this.gb.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gb.Font = ((System.Drawing.Font)(resources.GetObject("gb.Font")));
			this.gb.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gb.ImeMode")));
			this.gb.Location = ((System.Drawing.Point)(resources.GetObject("gb.Location")));
			this.gb.Name = "gb";
			this.gb.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gb.RightToLeft")));
			this.gb.Size = ((System.Drawing.Size)(resources.GetObject("gb.Size")));
			this.gb.TabIndex = ((int)(resources.GetObject("gb.TabIndex")));
			this.gb.TabStop = false;
			this.gb.Text = resources.GetString("gb.Text");
			this.toolTip1.SetToolTip(this.gb, resources.GetString("gb.ToolTip"));
			this.gb.Visible = ((bool)(resources.GetObject("gb.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gb, true);
			// 
			// cballrelsims
			// 
			this.cballrelsims.AccessibleDescription = resources.GetString("cballrelsims.AccessibleDescription");
			this.cballrelsims.AccessibleName = resources.GetString("cballrelsims.AccessibleName");
			this.cballrelsims.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cballrelsims.Anchor")));
			this.cballrelsims.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cballrelsims.BackgroundImage")));
			this.cballrelsims.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cballrelsims.Dock")));
			this.cballrelsims.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cballrelsims.Enabled = ((bool)(resources.GetObject("cballrelsims.Enabled")));
			this.cballrelsims.Font = ((System.Drawing.Font)(resources.GetObject("cballrelsims.Font")));
			this.cballrelsims.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cballrelsims.ImeMode")));
			this.cballrelsims.IntegralHeight = ((bool)(resources.GetObject("cballrelsims.IntegralHeight")));
			this.cballrelsims.ItemHeight = ((int)(resources.GetObject("cballrelsims.ItemHeight")));
			this.cballrelsims.Location = ((System.Drawing.Point)(resources.GetObject("cballrelsims.Location")));
			this.cballrelsims.MaxDropDownItems = ((int)(resources.GetObject("cballrelsims.MaxDropDownItems")));
			this.cballrelsims.MaxLength = ((int)(resources.GetObject("cballrelsims.MaxLength")));
			this.cballrelsims.Name = "cballrelsims";
			this.cballrelsims.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cballrelsims.RightToLeft")));
			this.cballrelsims.Size = ((System.Drawing.Size)(resources.GetObject("cballrelsims.Size")));
			this.cballrelsims.TabIndex = ((int)(resources.GetObject("cballrelsims.TabIndex")));
			this.cballrelsims.Text = resources.GetString("cballrelsims.Text");
			this.toolTip1.SetToolTip(this.cballrelsims, resources.GetString("cballrelsims.ToolTip"));
			this.cballrelsims.Visible = ((bool)(resources.GetObject("cballrelsims.Visible")));
			this.cballrelsims.SelectedIndexChanged += new System.EventHandler(this.RelatableSimsIndexChanged);
			// 
			// btaddrelation
			// 
			this.btaddrelation.AccessibleDescription = resources.GetString("btaddrelation.AccessibleDescription");
			this.btaddrelation.AccessibleName = resources.GetString("btaddrelation.AccessibleName");
			this.btaddrelation.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btaddrelation.Anchor")));
			this.btaddrelation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btaddrelation.BackgroundImage")));
			this.btaddrelation.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btaddrelation.Dock")));
			this.btaddrelation.Enabled = ((bool)(resources.GetObject("btaddrelation.Enabled")));
			this.btaddrelation.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btaddrelation.FlatStyle")));
			this.btaddrelation.Font = ((System.Drawing.Font)(resources.GetObject("btaddrelation.Font")));
			this.btaddrelation.Image = ((System.Drawing.Image)(resources.GetObject("btaddrelation.Image")));
			this.btaddrelation.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddrelation.ImageAlign")));
			this.btaddrelation.ImageIndex = ((int)(resources.GetObject("btaddrelation.ImageIndex")));
			this.btaddrelation.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btaddrelation.ImeMode")));
			this.btaddrelation.Location = ((System.Drawing.Point)(resources.GetObject("btaddrelation.Location")));
			this.btaddrelation.Name = "btaddrelation";
			this.btaddrelation.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btaddrelation.RightToLeft")));
			this.btaddrelation.Size = ((System.Drawing.Size)(resources.GetObject("btaddrelation.Size")));
			this.btaddrelation.TabIndex = ((int)(resources.GetObject("btaddrelation.TabIndex")));
			this.btaddrelation.Text = resources.GetString("btaddrelation.Text");
			this.btaddrelation.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btaddrelation.TextAlign")));
			this.toolTip1.SetToolTip(this.btaddrelation, resources.GetString("btaddrelation.ToolTip"));
			this.btaddrelation.Visible = ((bool)(resources.GetObject("btaddrelation.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btaddrelation, true);
			this.btaddrelation.Click += new System.EventHandler(this.AddRelationClicked);
			// 
			// btdeleterelation
			// 
			this.btdeleterelation.AccessibleDescription = resources.GetString("btdeleterelation.AccessibleDescription");
			this.btdeleterelation.AccessibleName = resources.GetString("btdeleterelation.AccessibleName");
			this.btdeleterelation.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("btdeleterelation.Anchor")));
			this.btdeleterelation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btdeleterelation.BackgroundImage")));
			this.btdeleterelation.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("btdeleterelation.Dock")));
			this.btdeleterelation.Enabled = ((bool)(resources.GetObject("btdeleterelation.Enabled")));
			this.btdeleterelation.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("btdeleterelation.FlatStyle")));
			this.btdeleterelation.Font = ((System.Drawing.Font)(resources.GetObject("btdeleterelation.Font")));
			this.btdeleterelation.Image = ((System.Drawing.Image)(resources.GetObject("btdeleterelation.Image")));
			this.btdeleterelation.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeleterelation.ImageAlign")));
			this.btdeleterelation.ImageIndex = ((int)(resources.GetObject("btdeleterelation.ImageIndex")));
			this.btdeleterelation.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("btdeleterelation.ImeMode")));
			this.btdeleterelation.Location = ((System.Drawing.Point)(resources.GetObject("btdeleterelation.Location")));
			this.btdeleterelation.Name = "btdeleterelation";
			this.btdeleterelation.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("btdeleterelation.RightToLeft")));
			this.btdeleterelation.Size = ((System.Drawing.Size)(resources.GetObject("btdeleterelation.Size")));
			this.btdeleterelation.TabIndex = ((int)(resources.GetObject("btdeleterelation.TabIndex")));
			this.btdeleterelation.Text = resources.GetString("btdeleterelation.Text");
			this.btdeleterelation.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("btdeleterelation.TextAlign")));
			this.toolTip1.SetToolTip(this.btdeleterelation, resources.GetString("btdeleterelation.ToolTip"));
			this.btdeleterelation.Visible = ((bool)(resources.GetObject("btdeleterelation.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.btdeleterelation, true);
			this.btdeleterelation.Click += new System.EventHandler(this.DeleteRelationClicked);
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
			this.label14.ForeColor = System.Drawing.Color.Maroon;
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
			this.toolTip1.SetToolTip(this.label14, resources.GetString("label14.ToolTip"));
			this.label14.Visible = ((bool)(resources.GetObject("label14.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label14, true);
			// 
			// llsimrelcommit
			// 
			this.llsimrelcommit.AccessibleDescription = resources.GetString("llsimrelcommit.AccessibleDescription");
			this.llsimrelcommit.AccessibleName = resources.GetString("llsimrelcommit.AccessibleName");
			this.llsimrelcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsimrelcommit.Anchor")));
			this.llsimrelcommit.AutoSize = ((bool)(resources.GetObject("llsimrelcommit.AutoSize")));
			this.llsimrelcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsimrelcommit.Dock")));
			this.llsimrelcommit.Enabled = ((bool)(resources.GetObject("llsimrelcommit.Enabled")));
			this.llsimrelcommit.Font = ((System.Drawing.Font)(resources.GetObject("llsimrelcommit.Font")));
			this.llsimrelcommit.Image = ((System.Drawing.Image)(resources.GetObject("llsimrelcommit.Image")));
			this.llsimrelcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsimrelcommit.ImageAlign")));
			this.llsimrelcommit.ImageIndex = ((int)(resources.GetObject("llsimrelcommit.ImageIndex")));
			this.llsimrelcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsimrelcommit.ImeMode")));
			this.llsimrelcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llsimrelcommit.LinkArea")));
			this.llsimrelcommit.LinkColor = System.Drawing.Color.Blue;
			this.llsimrelcommit.Location = ((System.Drawing.Point)(resources.GetObject("llsimrelcommit.Location")));
			this.llsimrelcommit.Name = "llsimrelcommit";
			this.llsimrelcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsimrelcommit.RightToLeft")));
			this.llsimrelcommit.Size = ((System.Drawing.Size)(resources.GetObject("llsimrelcommit.Size")));
			this.llsimrelcommit.TabIndex = ((int)(resources.GetObject("llsimrelcommit.TabIndex")));
			this.llsimrelcommit.TabStop = true;
			this.llsimrelcommit.Text = resources.GetString("llsimrelcommit.Text");
			this.llsimrelcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsimrelcommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llsimrelcommit, resources.GetString("llsimrelcommit.ToolTip"));
			this.llsimrelcommit.Visible = ((bool)(resources.GetObject("llsimrelcommit.Visible")));
			this.llsimrelcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SimRelationCommit);
			// 
			// gbout
			// 
			this.gbout.AccessibleDescription = resources.GetString("gbout.AccessibleDescription");
			this.gbout.AccessibleName = resources.GetString("gbout.AccessibleName");
			this.gbout.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbout.Anchor")));
			this.gbout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbout.BackgroundImage")));
			this.gbout.Controls.Add(this.cboutfamtype);
			this.gbout.Controls.Add(this.cboutbest);
			this.gbout.Controls.Add(this.cboutfamily);
			this.gbout.Controls.Add(this.cboutmarried);
			this.gbout.Controls.Add(this.cboutengaged);
			this.gbout.Controls.Add(this.cboutsteady);
			this.gbout.Controls.Add(this.cboutlove);
			this.gbout.Controls.Add(this.cboutcrush);
			this.gbout.Controls.Add(this.cboutbuddie);
			this.gbout.Controls.Add(this.cboutfriend);
			this.gbout.Controls.Add(this.cboutenemy);
			this.gbout.Controls.Add(this.tboutrellong);
			this.gbout.Controls.Add(this.tboutrelshort);
			this.gbout.Controls.Add(this.label53);
			this.gbout.Controls.Add(this.label52);
			this.gbout.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbout.Dock")));
			this.gbout.Enabled = ((bool)(resources.GetObject("gbout.Enabled")));
			this.gbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbout.Font = ((System.Drawing.Font)(resources.GetObject("gbout.Font")));
			this.gbout.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbout.ImeMode")));
			this.gbout.Location = ((System.Drawing.Point)(resources.GetObject("gbout.Location")));
			this.gbout.Name = "gbout";
			this.gbout.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbout.RightToLeft")));
			this.gbout.Size = ((System.Drawing.Size)(resources.GetObject("gbout.Size")));
			this.gbout.TabIndex = ((int)(resources.GetObject("gbout.TabIndex")));
			this.gbout.TabStop = false;
			this.gbout.Text = resources.GetString("gbout.Text");
			this.toolTip1.SetToolTip(this.gbout, resources.GetString("gbout.ToolTip"));
			this.gbout.Visible = ((bool)(resources.GetObject("gbout.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbout, true);
			// 
			// cboutfamtype
			// 
			this.cboutfamtype.AccessibleDescription = resources.GetString("cboutfamtype.AccessibleDescription");
			this.cboutfamtype.AccessibleName = resources.GetString("cboutfamtype.AccessibleName");
			this.cboutfamtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutfamtype.Anchor")));
			this.cboutfamtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutfamtype.BackgroundImage")));
			this.cboutfamtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutfamtype.Dock")));
			this.cboutfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboutfamtype.Enabled = ((bool)(resources.GetObject("cboutfamtype.Enabled")));
			this.cboutfamtype.Font = ((System.Drawing.Font)(resources.GetObject("cboutfamtype.Font")));
			this.cboutfamtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutfamtype.ImeMode")));
			this.cboutfamtype.IntegralHeight = ((bool)(resources.GetObject("cboutfamtype.IntegralHeight")));
			this.cboutfamtype.ItemHeight = ((int)(resources.GetObject("cboutfamtype.ItemHeight")));
			this.cboutfamtype.Location = ((System.Drawing.Point)(resources.GetObject("cboutfamtype.Location")));
			this.cboutfamtype.MaxDropDownItems = ((int)(resources.GetObject("cboutfamtype.MaxDropDownItems")));
			this.cboutfamtype.MaxLength = ((int)(resources.GetObject("cboutfamtype.MaxLength")));
			this.cboutfamtype.Name = "cboutfamtype";
			this.cboutfamtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutfamtype.RightToLeft")));
			this.cboutfamtype.Size = ((System.Drawing.Size)(resources.GetObject("cboutfamtype.Size")));
			this.cboutfamtype.TabIndex = ((int)(resources.GetObject("cboutfamtype.TabIndex")));
			this.cboutfamtype.Text = resources.GetString("cboutfamtype.Text");
			this.toolTip1.SetToolTip(this.cboutfamtype, resources.GetString("cboutfamtype.ToolTip"));
			this.cboutfamtype.Visible = ((bool)(resources.GetObject("cboutfamtype.Visible")));
			this.cboutfamtype.SelectedIndexChanged += new System.EventHandler(this.cboutfamtype_SelectedIndexChanged);
			// 
			// cboutbest
			// 
			this.cboutbest.AccessibleDescription = resources.GetString("cboutbest.AccessibleDescription");
			this.cboutbest.AccessibleName = resources.GetString("cboutbest.AccessibleName");
			this.cboutbest.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutbest.Anchor")));
			this.cboutbest.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutbest.Appearance")));
			this.cboutbest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutbest.BackgroundImage")));
			this.cboutbest.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbest.CheckAlign")));
			this.cboutbest.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutbest.Dock")));
			this.cboutbest.Enabled = ((bool)(resources.GetObject("cboutbest.Enabled")));
			this.cboutbest.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutbest.FlatStyle")));
			this.cboutbest.Font = ((System.Drawing.Font)(resources.GetObject("cboutbest.Font")));
			this.cboutbest.Image = ((System.Drawing.Image)(resources.GetObject("cboutbest.Image")));
			this.cboutbest.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbest.ImageAlign")));
			this.cboutbest.ImageIndex = ((int)(resources.GetObject("cboutbest.ImageIndex")));
			this.cboutbest.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutbest.ImeMode")));
			this.cboutbest.Location = ((System.Drawing.Point)(resources.GetObject("cboutbest.Location")));
			this.cboutbest.Name = "cboutbest";
			this.cboutbest.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutbest.RightToLeft")));
			this.cboutbest.Size = ((System.Drawing.Size)(resources.GetObject("cboutbest.Size")));
			this.cboutbest.TabIndex = ((int)(resources.GetObject("cboutbest.TabIndex")));
			this.cboutbest.Text = resources.GetString("cboutbest.Text");
			this.cboutbest.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbest.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutbest, resources.GetString("cboutbest.ToolTip"));
			this.cboutbest.Visible = ((bool)(resources.GetObject("cboutbest.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutbest, true);
			// 
			// cboutfamily
			// 
			this.cboutfamily.AccessibleDescription = resources.GetString("cboutfamily.AccessibleDescription");
			this.cboutfamily.AccessibleName = resources.GetString("cboutfamily.AccessibleName");
			this.cboutfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutfamily.Anchor")));
			this.cboutfamily.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutfamily.Appearance")));
			this.cboutfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutfamily.BackgroundImage")));
			this.cboutfamily.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfamily.CheckAlign")));
			this.cboutfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutfamily.Dock")));
			this.cboutfamily.Enabled = ((bool)(resources.GetObject("cboutfamily.Enabled")));
			this.cboutfamily.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutfamily.FlatStyle")));
			this.cboutfamily.Font = ((System.Drawing.Font)(resources.GetObject("cboutfamily.Font")));
			this.cboutfamily.Image = ((System.Drawing.Image)(resources.GetObject("cboutfamily.Image")));
			this.cboutfamily.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfamily.ImageAlign")));
			this.cboutfamily.ImageIndex = ((int)(resources.GetObject("cboutfamily.ImageIndex")));
			this.cboutfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutfamily.ImeMode")));
			this.cboutfamily.Location = ((System.Drawing.Point)(resources.GetObject("cboutfamily.Location")));
			this.cboutfamily.Name = "cboutfamily";
			this.cboutfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutfamily.RightToLeft")));
			this.cboutfamily.Size = ((System.Drawing.Size)(resources.GetObject("cboutfamily.Size")));
			this.cboutfamily.TabIndex = ((int)(resources.GetObject("cboutfamily.TabIndex")));
			this.cboutfamily.Text = resources.GetString("cboutfamily.Text");
			this.cboutfamily.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutfamily, resources.GetString("cboutfamily.ToolTip"));
			this.cboutfamily.Visible = ((bool)(resources.GetObject("cboutfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutfamily, true);
			// 
			// cboutmarried
			// 
			this.cboutmarried.AccessibleDescription = resources.GetString("cboutmarried.AccessibleDescription");
			this.cboutmarried.AccessibleName = resources.GetString("cboutmarried.AccessibleName");
			this.cboutmarried.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutmarried.Anchor")));
			this.cboutmarried.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutmarried.Appearance")));
			this.cboutmarried.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutmarried.BackgroundImage")));
			this.cboutmarried.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutmarried.CheckAlign")));
			this.cboutmarried.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutmarried.Dock")));
			this.cboutmarried.Enabled = ((bool)(resources.GetObject("cboutmarried.Enabled")));
			this.cboutmarried.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutmarried.FlatStyle")));
			this.cboutmarried.Font = ((System.Drawing.Font)(resources.GetObject("cboutmarried.Font")));
			this.cboutmarried.Image = ((System.Drawing.Image)(resources.GetObject("cboutmarried.Image")));
			this.cboutmarried.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutmarried.ImageAlign")));
			this.cboutmarried.ImageIndex = ((int)(resources.GetObject("cboutmarried.ImageIndex")));
			this.cboutmarried.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutmarried.ImeMode")));
			this.cboutmarried.Location = ((System.Drawing.Point)(resources.GetObject("cboutmarried.Location")));
			this.cboutmarried.Name = "cboutmarried";
			this.cboutmarried.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutmarried.RightToLeft")));
			this.cboutmarried.Size = ((System.Drawing.Size)(resources.GetObject("cboutmarried.Size")));
			this.cboutmarried.TabIndex = ((int)(resources.GetObject("cboutmarried.TabIndex")));
			this.cboutmarried.Text = resources.GetString("cboutmarried.Text");
			this.cboutmarried.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutmarried.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutmarried, resources.GetString("cboutmarried.ToolTip"));
			this.cboutmarried.Visible = ((bool)(resources.GetObject("cboutmarried.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutmarried, true);
			// 
			// cboutengaged
			// 
			this.cboutengaged.AccessibleDescription = resources.GetString("cboutengaged.AccessibleDescription");
			this.cboutengaged.AccessibleName = resources.GetString("cboutengaged.AccessibleName");
			this.cboutengaged.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutengaged.Anchor")));
			this.cboutengaged.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutengaged.Appearance")));
			this.cboutengaged.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutengaged.BackgroundImage")));
			this.cboutengaged.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutengaged.CheckAlign")));
			this.cboutengaged.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutengaged.Dock")));
			this.cboutengaged.Enabled = ((bool)(resources.GetObject("cboutengaged.Enabled")));
			this.cboutengaged.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutengaged.FlatStyle")));
			this.cboutengaged.Font = ((System.Drawing.Font)(resources.GetObject("cboutengaged.Font")));
			this.cboutengaged.Image = ((System.Drawing.Image)(resources.GetObject("cboutengaged.Image")));
			this.cboutengaged.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutengaged.ImageAlign")));
			this.cboutengaged.ImageIndex = ((int)(resources.GetObject("cboutengaged.ImageIndex")));
			this.cboutengaged.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutengaged.ImeMode")));
			this.cboutengaged.Location = ((System.Drawing.Point)(resources.GetObject("cboutengaged.Location")));
			this.cboutengaged.Name = "cboutengaged";
			this.cboutengaged.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutengaged.RightToLeft")));
			this.cboutengaged.Size = ((System.Drawing.Size)(resources.GetObject("cboutengaged.Size")));
			this.cboutengaged.TabIndex = ((int)(resources.GetObject("cboutengaged.TabIndex")));
			this.cboutengaged.Text = resources.GetString("cboutengaged.Text");
			this.cboutengaged.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutengaged.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutengaged, resources.GetString("cboutengaged.ToolTip"));
			this.cboutengaged.Visible = ((bool)(resources.GetObject("cboutengaged.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutengaged, true);
			// 
			// cboutsteady
			// 
			this.cboutsteady.AccessibleDescription = resources.GetString("cboutsteady.AccessibleDescription");
			this.cboutsteady.AccessibleName = resources.GetString("cboutsteady.AccessibleName");
			this.cboutsteady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutsteady.Anchor")));
			this.cboutsteady.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutsteady.Appearance")));
			this.cboutsteady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutsteady.BackgroundImage")));
			this.cboutsteady.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutsteady.CheckAlign")));
			this.cboutsteady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutsteady.Dock")));
			this.cboutsteady.Enabled = ((bool)(resources.GetObject("cboutsteady.Enabled")));
			this.cboutsteady.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutsteady.FlatStyle")));
			this.cboutsteady.Font = ((System.Drawing.Font)(resources.GetObject("cboutsteady.Font")));
			this.cboutsteady.Image = ((System.Drawing.Image)(resources.GetObject("cboutsteady.Image")));
			this.cboutsteady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutsteady.ImageAlign")));
			this.cboutsteady.ImageIndex = ((int)(resources.GetObject("cboutsteady.ImageIndex")));
			this.cboutsteady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutsteady.ImeMode")));
			this.cboutsteady.Location = ((System.Drawing.Point)(resources.GetObject("cboutsteady.Location")));
			this.cboutsteady.Name = "cboutsteady";
			this.cboutsteady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutsteady.RightToLeft")));
			this.cboutsteady.Size = ((System.Drawing.Size)(resources.GetObject("cboutsteady.Size")));
			this.cboutsteady.TabIndex = ((int)(resources.GetObject("cboutsteady.TabIndex")));
			this.cboutsteady.Text = resources.GetString("cboutsteady.Text");
			this.cboutsteady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutsteady.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutsteady, resources.GetString("cboutsteady.ToolTip"));
			this.cboutsteady.Visible = ((bool)(resources.GetObject("cboutsteady.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutsteady, true);
			// 
			// cboutlove
			// 
			this.cboutlove.AccessibleDescription = resources.GetString("cboutlove.AccessibleDescription");
			this.cboutlove.AccessibleName = resources.GetString("cboutlove.AccessibleName");
			this.cboutlove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutlove.Anchor")));
			this.cboutlove.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutlove.Appearance")));
			this.cboutlove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutlove.BackgroundImage")));
			this.cboutlove.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutlove.CheckAlign")));
			this.cboutlove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutlove.Dock")));
			this.cboutlove.Enabled = ((bool)(resources.GetObject("cboutlove.Enabled")));
			this.cboutlove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutlove.FlatStyle")));
			this.cboutlove.Font = ((System.Drawing.Font)(resources.GetObject("cboutlove.Font")));
			this.cboutlove.Image = ((System.Drawing.Image)(resources.GetObject("cboutlove.Image")));
			this.cboutlove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutlove.ImageAlign")));
			this.cboutlove.ImageIndex = ((int)(resources.GetObject("cboutlove.ImageIndex")));
			this.cboutlove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutlove.ImeMode")));
			this.cboutlove.Location = ((System.Drawing.Point)(resources.GetObject("cboutlove.Location")));
			this.cboutlove.Name = "cboutlove";
			this.cboutlove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutlove.RightToLeft")));
			this.cboutlove.Size = ((System.Drawing.Size)(resources.GetObject("cboutlove.Size")));
			this.cboutlove.TabIndex = ((int)(resources.GetObject("cboutlove.TabIndex")));
			this.cboutlove.Text = resources.GetString("cboutlove.Text");
			this.cboutlove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutlove.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutlove, resources.GetString("cboutlove.ToolTip"));
			this.cboutlove.Visible = ((bool)(resources.GetObject("cboutlove.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutlove, true);
			// 
			// cboutcrush
			// 
			this.cboutcrush.AccessibleDescription = resources.GetString("cboutcrush.AccessibleDescription");
			this.cboutcrush.AccessibleName = resources.GetString("cboutcrush.AccessibleName");
			this.cboutcrush.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutcrush.Anchor")));
			this.cboutcrush.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutcrush.Appearance")));
			this.cboutcrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutcrush.BackgroundImage")));
			this.cboutcrush.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutcrush.CheckAlign")));
			this.cboutcrush.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutcrush.Dock")));
			this.cboutcrush.Enabled = ((bool)(resources.GetObject("cboutcrush.Enabled")));
			this.cboutcrush.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutcrush.FlatStyle")));
			this.cboutcrush.Font = ((System.Drawing.Font)(resources.GetObject("cboutcrush.Font")));
			this.cboutcrush.Image = ((System.Drawing.Image)(resources.GetObject("cboutcrush.Image")));
			this.cboutcrush.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutcrush.ImageAlign")));
			this.cboutcrush.ImageIndex = ((int)(resources.GetObject("cboutcrush.ImageIndex")));
			this.cboutcrush.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutcrush.ImeMode")));
			this.cboutcrush.Location = ((System.Drawing.Point)(resources.GetObject("cboutcrush.Location")));
			this.cboutcrush.Name = "cboutcrush";
			this.cboutcrush.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutcrush.RightToLeft")));
			this.cboutcrush.Size = ((System.Drawing.Size)(resources.GetObject("cboutcrush.Size")));
			this.cboutcrush.TabIndex = ((int)(resources.GetObject("cboutcrush.TabIndex")));
			this.cboutcrush.Text = resources.GetString("cboutcrush.Text");
			this.cboutcrush.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutcrush.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutcrush, resources.GetString("cboutcrush.ToolTip"));
			this.cboutcrush.Visible = ((bool)(resources.GetObject("cboutcrush.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutcrush, true);
			// 
			// cboutbuddie
			// 
			this.cboutbuddie.AccessibleDescription = resources.GetString("cboutbuddie.AccessibleDescription");
			this.cboutbuddie.AccessibleName = resources.GetString("cboutbuddie.AccessibleName");
			this.cboutbuddie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutbuddie.Anchor")));
			this.cboutbuddie.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutbuddie.Appearance")));
			this.cboutbuddie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutbuddie.BackgroundImage")));
			this.cboutbuddie.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbuddie.CheckAlign")));
			this.cboutbuddie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutbuddie.Dock")));
			this.cboutbuddie.Enabled = ((bool)(resources.GetObject("cboutbuddie.Enabled")));
			this.cboutbuddie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutbuddie.FlatStyle")));
			this.cboutbuddie.Font = ((System.Drawing.Font)(resources.GetObject("cboutbuddie.Font")));
			this.cboutbuddie.Image = ((System.Drawing.Image)(resources.GetObject("cboutbuddie.Image")));
			this.cboutbuddie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbuddie.ImageAlign")));
			this.cboutbuddie.ImageIndex = ((int)(resources.GetObject("cboutbuddie.ImageIndex")));
			this.cboutbuddie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutbuddie.ImeMode")));
			this.cboutbuddie.Location = ((System.Drawing.Point)(resources.GetObject("cboutbuddie.Location")));
			this.cboutbuddie.Name = "cboutbuddie";
			this.cboutbuddie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutbuddie.RightToLeft")));
			this.cboutbuddie.Size = ((System.Drawing.Size)(resources.GetObject("cboutbuddie.Size")));
			this.cboutbuddie.TabIndex = ((int)(resources.GetObject("cboutbuddie.TabIndex")));
			this.cboutbuddie.Text = resources.GetString("cboutbuddie.Text");
			this.cboutbuddie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutbuddie.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutbuddie, resources.GetString("cboutbuddie.ToolTip"));
			this.cboutbuddie.Visible = ((bool)(resources.GetObject("cboutbuddie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutbuddie, true);
			// 
			// cboutfriend
			// 
			this.cboutfriend.AccessibleDescription = resources.GetString("cboutfriend.AccessibleDescription");
			this.cboutfriend.AccessibleName = resources.GetString("cboutfriend.AccessibleName");
			this.cboutfriend.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutfriend.Anchor")));
			this.cboutfriend.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutfriend.Appearance")));
			this.cboutfriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutfriend.BackgroundImage")));
			this.cboutfriend.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfriend.CheckAlign")));
			this.cboutfriend.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutfriend.Dock")));
			this.cboutfriend.Enabled = ((bool)(resources.GetObject("cboutfriend.Enabled")));
			this.cboutfriend.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutfriend.FlatStyle")));
			this.cboutfriend.Font = ((System.Drawing.Font)(resources.GetObject("cboutfriend.Font")));
			this.cboutfriend.Image = ((System.Drawing.Image)(resources.GetObject("cboutfriend.Image")));
			this.cboutfriend.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfriend.ImageAlign")));
			this.cboutfriend.ImageIndex = ((int)(resources.GetObject("cboutfriend.ImageIndex")));
			this.cboutfriend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutfriend.ImeMode")));
			this.cboutfriend.Location = ((System.Drawing.Point)(resources.GetObject("cboutfriend.Location")));
			this.cboutfriend.Name = "cboutfriend";
			this.cboutfriend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutfriend.RightToLeft")));
			this.cboutfriend.Size = ((System.Drawing.Size)(resources.GetObject("cboutfriend.Size")));
			this.cboutfriend.TabIndex = ((int)(resources.GetObject("cboutfriend.TabIndex")));
			this.cboutfriend.Text = resources.GetString("cboutfriend.Text");
			this.cboutfriend.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutfriend.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutfriend, resources.GetString("cboutfriend.ToolTip"));
			this.cboutfriend.Visible = ((bool)(resources.GetObject("cboutfriend.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutfriend, true);
			// 
			// cboutenemy
			// 
			this.cboutenemy.AccessibleDescription = resources.GetString("cboutenemy.AccessibleDescription");
			this.cboutenemy.AccessibleName = resources.GetString("cboutenemy.AccessibleName");
			this.cboutenemy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cboutenemy.Anchor")));
			this.cboutenemy.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cboutenemy.Appearance")));
			this.cboutenemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cboutenemy.BackgroundImage")));
			this.cboutenemy.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutenemy.CheckAlign")));
			this.cboutenemy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cboutenemy.Dock")));
			this.cboutenemy.Enabled = ((bool)(resources.GetObject("cboutenemy.Enabled")));
			this.cboutenemy.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cboutenemy.FlatStyle")));
			this.cboutenemy.Font = ((System.Drawing.Font)(resources.GetObject("cboutenemy.Font")));
			this.cboutenemy.Image = ((System.Drawing.Image)(resources.GetObject("cboutenemy.Image")));
			this.cboutenemy.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutenemy.ImageAlign")));
			this.cboutenemy.ImageIndex = ((int)(resources.GetObject("cboutenemy.ImageIndex")));
			this.cboutenemy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cboutenemy.ImeMode")));
			this.cboutenemy.Location = ((System.Drawing.Point)(resources.GetObject("cboutenemy.Location")));
			this.cboutenemy.Name = "cboutenemy";
			this.cboutenemy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cboutenemy.RightToLeft")));
			this.cboutenemy.Size = ((System.Drawing.Size)(resources.GetObject("cboutenemy.Size")));
			this.cboutenemy.TabIndex = ((int)(resources.GetObject("cboutenemy.TabIndex")));
			this.cboutenemy.Text = resources.GetString("cboutenemy.Text");
			this.cboutenemy.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cboutenemy.TextAlign")));
			this.toolTip1.SetToolTip(this.cboutenemy, resources.GetString("cboutenemy.ToolTip"));
			this.cboutenemy.Visible = ((bool)(resources.GetObject("cboutenemy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboutenemy, true);
			// 
			// tboutrellong
			// 
			this.tboutrellong.AccessibleDescription = resources.GetString("tboutrellong.AccessibleDescription");
			this.tboutrellong.AccessibleName = resources.GetString("tboutrellong.AccessibleName");
			this.tboutrellong.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tboutrellong.Anchor")));
			this.tboutrellong.AutoSize = ((bool)(resources.GetObject("tboutrellong.AutoSize")));
			this.tboutrellong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tboutrellong.BackgroundImage")));
			this.tboutrellong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboutrellong.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tboutrellong.Dock")));
			this.tboutrellong.Enabled = ((bool)(resources.GetObject("tboutrellong.Enabled")));
			this.tboutrellong.Font = ((System.Drawing.Font)(resources.GetObject("tboutrellong.Font")));
			this.tboutrellong.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tboutrellong.ImeMode")));
			this.tboutrellong.Location = ((System.Drawing.Point)(resources.GetObject("tboutrellong.Location")));
			this.tboutrellong.MaxLength = ((int)(resources.GetObject("tboutrellong.MaxLength")));
			this.tboutrellong.Multiline = ((bool)(resources.GetObject("tboutrellong.Multiline")));
			this.tboutrellong.Name = "tboutrellong";
			this.tboutrellong.PasswordChar = ((char)(resources.GetObject("tboutrellong.PasswordChar")));
			this.tboutrellong.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tboutrellong.RightToLeft")));
			this.tboutrellong.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tboutrellong.ScrollBars")));
			this.tboutrellong.Size = ((System.Drawing.Size)(resources.GetObject("tboutrellong.Size")));
			this.tboutrellong.TabIndex = ((int)(resources.GetObject("tboutrellong.TabIndex")));
			this.tboutrellong.Text = resources.GetString("tboutrellong.Text");
			this.tboutrellong.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tboutrellong.TextAlign")));
			this.toolTip1.SetToolTip(this.tboutrellong, resources.GetString("tboutrellong.ToolTip"));
			this.tboutrellong.Visible = ((bool)(resources.GetObject("tboutrellong.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tboutrellong, true);
			this.tboutrellong.WordWrap = ((bool)(resources.GetObject("tboutrellong.WordWrap")));
			// 
			// tboutrelshort
			// 
			this.tboutrelshort.AccessibleDescription = resources.GetString("tboutrelshort.AccessibleDescription");
			this.tboutrelshort.AccessibleName = resources.GetString("tboutrelshort.AccessibleName");
			this.tboutrelshort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tboutrelshort.Anchor")));
			this.tboutrelshort.AutoSize = ((bool)(resources.GetObject("tboutrelshort.AutoSize")));
			this.tboutrelshort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tboutrelshort.BackgroundImage")));
			this.tboutrelshort.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tboutrelshort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tboutrelshort.Dock")));
			this.tboutrelshort.Enabled = ((bool)(resources.GetObject("tboutrelshort.Enabled")));
			this.tboutrelshort.Font = ((System.Drawing.Font)(resources.GetObject("tboutrelshort.Font")));
			this.tboutrelshort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tboutrelshort.ImeMode")));
			this.tboutrelshort.Location = ((System.Drawing.Point)(resources.GetObject("tboutrelshort.Location")));
			this.tboutrelshort.MaxLength = ((int)(resources.GetObject("tboutrelshort.MaxLength")));
			this.tboutrelshort.Multiline = ((bool)(resources.GetObject("tboutrelshort.Multiline")));
			this.tboutrelshort.Name = "tboutrelshort";
			this.tboutrelshort.PasswordChar = ((char)(resources.GetObject("tboutrelshort.PasswordChar")));
			this.tboutrelshort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tboutrelshort.RightToLeft")));
			this.tboutrelshort.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tboutrelshort.ScrollBars")));
			this.tboutrelshort.Size = ((System.Drawing.Size)(resources.GetObject("tboutrelshort.Size")));
			this.tboutrelshort.TabIndex = ((int)(resources.GetObject("tboutrelshort.TabIndex")));
			this.tboutrelshort.Text = resources.GetString("tboutrelshort.Text");
			this.tboutrelshort.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tboutrelshort.TextAlign")));
			this.toolTip1.SetToolTip(this.tboutrelshort, resources.GetString("tboutrelshort.ToolTip"));
			this.tboutrelshort.Visible = ((bool)(resources.GetObject("tboutrelshort.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tboutrelshort, true);
			this.tboutrelshort.WordWrap = ((bool)(resources.GetObject("tboutrelshort.WordWrap")));
			// 
			// label53
			// 
			this.label53.AccessibleDescription = resources.GetString("label53.AccessibleDescription");
			this.label53.AccessibleName = resources.GetString("label53.AccessibleName");
			this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label53.Anchor")));
			this.label53.AutoSize = ((bool)(resources.GetObject("label53.AutoSize")));
			this.label53.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label53.Dock")));
			this.label53.Enabled = ((bool)(resources.GetObject("label53.Enabled")));
			this.label53.Font = ((System.Drawing.Font)(resources.GetObject("label53.Font")));
			this.label53.Image = ((System.Drawing.Image)(resources.GetObject("label53.Image")));
			this.label53.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label53.ImageAlign")));
			this.label53.ImageIndex = ((int)(resources.GetObject("label53.ImageIndex")));
			this.label53.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label53.ImeMode")));
			this.label53.Location = ((System.Drawing.Point)(resources.GetObject("label53.Location")));
			this.label53.Name = "label53";
			this.label53.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label53.RightToLeft")));
			this.label53.Size = ((System.Drawing.Size)(resources.GetObject("label53.Size")));
			this.label53.TabIndex = ((int)(resources.GetObject("label53.TabIndex")));
			this.label53.Text = resources.GetString("label53.Text");
			this.label53.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label53.TextAlign")));
			this.toolTip1.SetToolTip(this.label53, resources.GetString("label53.ToolTip"));
			this.label53.Visible = ((bool)(resources.GetObject("label53.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label53, true);
			// 
			// label52
			// 
			this.label52.AccessibleDescription = resources.GetString("label52.AccessibleDescription");
			this.label52.AccessibleName = resources.GetString("label52.AccessibleName");
			this.label52.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label52.Anchor")));
			this.label52.AutoSize = ((bool)(resources.GetObject("label52.AutoSize")));
			this.label52.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label52.Dock")));
			this.label52.Enabled = ((bool)(resources.GetObject("label52.Enabled")));
			this.label52.Font = ((System.Drawing.Font)(resources.GetObject("label52.Font")));
			this.label52.Image = ((System.Drawing.Image)(resources.GetObject("label52.Image")));
			this.label52.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label52.ImageAlign")));
			this.label52.ImageIndex = ((int)(resources.GetObject("label52.ImageIndex")));
			this.label52.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label52.ImeMode")));
			this.label52.Location = ((System.Drawing.Point)(resources.GetObject("label52.Location")));
			this.label52.Name = "label52";
			this.label52.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label52.RightToLeft")));
			this.label52.Size = ((System.Drawing.Size)(resources.GetObject("label52.Size")));
			this.label52.TabIndex = ((int)(resources.GetObject("label52.TabIndex")));
			this.label52.Text = resources.GetString("label52.Text");
			this.label52.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label52.TextAlign")));
			this.toolTip1.SetToolTip(this.label52, resources.GetString("label52.ToolTip"));
			this.label52.Visible = ((bool)(resources.GetObject("label52.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label52, true);
			// 
			// lbrelations
			// 
			this.lbrelations.AccessibleDescription = resources.GetString("lbrelations.AccessibleDescription");
			this.lbrelations.AccessibleName = resources.GetString("lbrelations.AccessibleName");
			this.lbrelations.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbrelations.Anchor")));
			this.lbrelations.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lbrelations.BackgroundImage")));
			this.lbrelations.ColumnWidth = ((int)(resources.GetObject("lbrelations.ColumnWidth")));
			this.lbrelations.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbrelations.Dock")));
			this.lbrelations.Enabled = ((bool)(resources.GetObject("lbrelations.Enabled")));
			this.lbrelations.Font = ((System.Drawing.Font)(resources.GetObject("lbrelations.Font")));
			this.lbrelations.HorizontalExtent = ((int)(resources.GetObject("lbrelations.HorizontalExtent")));
			this.lbrelations.HorizontalScrollbar = ((bool)(resources.GetObject("lbrelations.HorizontalScrollbar")));
			this.lbrelations.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbrelations.ImeMode")));
			this.lbrelations.IntegralHeight = ((bool)(resources.GetObject("lbrelations.IntegralHeight")));
			this.lbrelations.ItemHeight = ((int)(resources.GetObject("lbrelations.ItemHeight")));
			this.lbrelations.Location = ((System.Drawing.Point)(resources.GetObject("lbrelations.Location")));
			this.lbrelations.Name = "lbrelations";
			this.lbrelations.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbrelations.RightToLeft")));
			this.lbrelations.ScrollAlwaysVisible = ((bool)(resources.GetObject("lbrelations.ScrollAlwaysVisible")));
			this.lbrelations.Size = ((System.Drawing.Size)(resources.GetObject("lbrelations.Size")));
			this.lbrelations.TabIndex = ((int)(resources.GetObject("lbrelations.TabIndex")));
			this.toolTip1.SetToolTip(this.lbrelations, resources.GetString("lbrelations.ToolTip"));
			this.lbrelations.Visible = ((bool)(resources.GetObject("lbrelations.Visible")));
			this.lbrelations.SelectedIndexChanged += new System.EventHandler(this.RelationListSelectedIndexChanged);
			// 
			// gbin
			// 
			this.gbin.AccessibleDescription = resources.GetString("gbin.AccessibleDescription");
			this.gbin.AccessibleName = resources.GetString("gbin.AccessibleName");
			this.gbin.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbin.Anchor")));
			this.gbin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbin.BackgroundImage")));
			this.gbin.Controls.Add(this.cbinfamtype);
			this.gbin.Controls.Add(this.cbinbest);
			this.gbin.Controls.Add(this.cbinfamily);
			this.gbin.Controls.Add(this.cbinmarried);
			this.gbin.Controls.Add(this.cbinengaged);
			this.gbin.Controls.Add(this.cbinsteady);
			this.gbin.Controls.Add(this.cbinlove);
			this.gbin.Controls.Add(this.cbincrush);
			this.gbin.Controls.Add(this.cbinbuddie);
			this.gbin.Controls.Add(this.cbinfriend);
			this.gbin.Controls.Add(this.cbinenemy);
			this.gbin.Controls.Add(this.tbinrellong);
			this.gbin.Controls.Add(this.tbinrelshort);
			this.gbin.Controls.Add(this.label54);
			this.gbin.Controls.Add(this.label55);
			this.gbin.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbin.Dock")));
			this.gbin.Enabled = ((bool)(resources.GetObject("gbin.Enabled")));
			this.gbin.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbin.Font = ((System.Drawing.Font)(resources.GetObject("gbin.Font")));
			this.gbin.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbin.ImeMode")));
			this.gbin.Location = ((System.Drawing.Point)(resources.GetObject("gbin.Location")));
			this.gbin.Name = "gbin";
			this.gbin.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbin.RightToLeft")));
			this.gbin.Size = ((System.Drawing.Size)(resources.GetObject("gbin.Size")));
			this.gbin.TabIndex = ((int)(resources.GetObject("gbin.TabIndex")));
			this.gbin.TabStop = false;
			this.gbin.Text = resources.GetString("gbin.Text");
			this.toolTip1.SetToolTip(this.gbin, resources.GetString("gbin.ToolTip"));
			this.gbin.Visible = ((bool)(resources.GetObject("gbin.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbin, true);
			// 
			// cbinfamtype
			// 
			this.cbinfamtype.AccessibleDescription = resources.GetString("cbinfamtype.AccessibleDescription");
			this.cbinfamtype.AccessibleName = resources.GetString("cbinfamtype.AccessibleName");
			this.cbinfamtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinfamtype.Anchor")));
			this.cbinfamtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinfamtype.BackgroundImage")));
			this.cbinfamtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinfamtype.Dock")));
			this.cbinfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbinfamtype.Enabled = ((bool)(resources.GetObject("cbinfamtype.Enabled")));
			this.cbinfamtype.Font = ((System.Drawing.Font)(resources.GetObject("cbinfamtype.Font")));
			this.cbinfamtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinfamtype.ImeMode")));
			this.cbinfamtype.IntegralHeight = ((bool)(resources.GetObject("cbinfamtype.IntegralHeight")));
			this.cbinfamtype.ItemHeight = ((int)(resources.GetObject("cbinfamtype.ItemHeight")));
			this.cbinfamtype.Location = ((System.Drawing.Point)(resources.GetObject("cbinfamtype.Location")));
			this.cbinfamtype.MaxDropDownItems = ((int)(resources.GetObject("cbinfamtype.MaxDropDownItems")));
			this.cbinfamtype.MaxLength = ((int)(resources.GetObject("cbinfamtype.MaxLength")));
			this.cbinfamtype.Name = "cbinfamtype";
			this.cbinfamtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinfamtype.RightToLeft")));
			this.cbinfamtype.Size = ((System.Drawing.Size)(resources.GetObject("cbinfamtype.Size")));
			this.cbinfamtype.TabIndex = ((int)(resources.GetObject("cbinfamtype.TabIndex")));
			this.cbinfamtype.Text = resources.GetString("cbinfamtype.Text");
			this.toolTip1.SetToolTip(this.cbinfamtype, resources.GetString("cbinfamtype.ToolTip"));
			this.cbinfamtype.Visible = ((bool)(resources.GetObject("cbinfamtype.Visible")));
			// 
			// cbinbest
			// 
			this.cbinbest.AccessibleDescription = resources.GetString("cbinbest.AccessibleDescription");
			this.cbinbest.AccessibleName = resources.GetString("cbinbest.AccessibleName");
			this.cbinbest.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinbest.Anchor")));
			this.cbinbest.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinbest.Appearance")));
			this.cbinbest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinbest.BackgroundImage")));
			this.cbinbest.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbest.CheckAlign")));
			this.cbinbest.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinbest.Dock")));
			this.cbinbest.Enabled = ((bool)(resources.GetObject("cbinbest.Enabled")));
			this.cbinbest.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinbest.FlatStyle")));
			this.cbinbest.Font = ((System.Drawing.Font)(resources.GetObject("cbinbest.Font")));
			this.cbinbest.Image = ((System.Drawing.Image)(resources.GetObject("cbinbest.Image")));
			this.cbinbest.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbest.ImageAlign")));
			this.cbinbest.ImageIndex = ((int)(resources.GetObject("cbinbest.ImageIndex")));
			this.cbinbest.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinbest.ImeMode")));
			this.cbinbest.Location = ((System.Drawing.Point)(resources.GetObject("cbinbest.Location")));
			this.cbinbest.Name = "cbinbest";
			this.cbinbest.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinbest.RightToLeft")));
			this.cbinbest.Size = ((System.Drawing.Size)(resources.GetObject("cbinbest.Size")));
			this.cbinbest.TabIndex = ((int)(resources.GetObject("cbinbest.TabIndex")));
			this.cbinbest.Text = resources.GetString("cbinbest.Text");
			this.cbinbest.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbest.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinbest, resources.GetString("cbinbest.ToolTip"));
			this.cbinbest.Visible = ((bool)(resources.GetObject("cbinbest.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinbest, true);
			// 
			// cbinfamily
			// 
			this.cbinfamily.AccessibleDescription = resources.GetString("cbinfamily.AccessibleDescription");
			this.cbinfamily.AccessibleName = resources.GetString("cbinfamily.AccessibleName");
			this.cbinfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinfamily.Anchor")));
			this.cbinfamily.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinfamily.Appearance")));
			this.cbinfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinfamily.BackgroundImage")));
			this.cbinfamily.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfamily.CheckAlign")));
			this.cbinfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinfamily.Dock")));
			this.cbinfamily.Enabled = ((bool)(resources.GetObject("cbinfamily.Enabled")));
			this.cbinfamily.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinfamily.FlatStyle")));
			this.cbinfamily.Font = ((System.Drawing.Font)(resources.GetObject("cbinfamily.Font")));
			this.cbinfamily.Image = ((System.Drawing.Image)(resources.GetObject("cbinfamily.Image")));
			this.cbinfamily.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfamily.ImageAlign")));
			this.cbinfamily.ImageIndex = ((int)(resources.GetObject("cbinfamily.ImageIndex")));
			this.cbinfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinfamily.ImeMode")));
			this.cbinfamily.Location = ((System.Drawing.Point)(resources.GetObject("cbinfamily.Location")));
			this.cbinfamily.Name = "cbinfamily";
			this.cbinfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinfamily.RightToLeft")));
			this.cbinfamily.Size = ((System.Drawing.Size)(resources.GetObject("cbinfamily.Size")));
			this.cbinfamily.TabIndex = ((int)(resources.GetObject("cbinfamily.TabIndex")));
			this.cbinfamily.Text = resources.GetString("cbinfamily.Text");
			this.cbinfamily.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinfamily, resources.GetString("cbinfamily.ToolTip"));
			this.cbinfamily.Visible = ((bool)(resources.GetObject("cbinfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinfamily, true);
			// 
			// cbinmarried
			// 
			this.cbinmarried.AccessibleDescription = resources.GetString("cbinmarried.AccessibleDescription");
			this.cbinmarried.AccessibleName = resources.GetString("cbinmarried.AccessibleName");
			this.cbinmarried.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinmarried.Anchor")));
			this.cbinmarried.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinmarried.Appearance")));
			this.cbinmarried.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinmarried.BackgroundImage")));
			this.cbinmarried.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinmarried.CheckAlign")));
			this.cbinmarried.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinmarried.Dock")));
			this.cbinmarried.Enabled = ((bool)(resources.GetObject("cbinmarried.Enabled")));
			this.cbinmarried.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinmarried.FlatStyle")));
			this.cbinmarried.Font = ((System.Drawing.Font)(resources.GetObject("cbinmarried.Font")));
			this.cbinmarried.Image = ((System.Drawing.Image)(resources.GetObject("cbinmarried.Image")));
			this.cbinmarried.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinmarried.ImageAlign")));
			this.cbinmarried.ImageIndex = ((int)(resources.GetObject("cbinmarried.ImageIndex")));
			this.cbinmarried.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinmarried.ImeMode")));
			this.cbinmarried.Location = ((System.Drawing.Point)(resources.GetObject("cbinmarried.Location")));
			this.cbinmarried.Name = "cbinmarried";
			this.cbinmarried.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinmarried.RightToLeft")));
			this.cbinmarried.Size = ((System.Drawing.Size)(resources.GetObject("cbinmarried.Size")));
			this.cbinmarried.TabIndex = ((int)(resources.GetObject("cbinmarried.TabIndex")));
			this.cbinmarried.Text = resources.GetString("cbinmarried.Text");
			this.cbinmarried.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinmarried.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinmarried, resources.GetString("cbinmarried.ToolTip"));
			this.cbinmarried.Visible = ((bool)(resources.GetObject("cbinmarried.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinmarried, true);
			// 
			// cbinengaged
			// 
			this.cbinengaged.AccessibleDescription = resources.GetString("cbinengaged.AccessibleDescription");
			this.cbinengaged.AccessibleName = resources.GetString("cbinengaged.AccessibleName");
			this.cbinengaged.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinengaged.Anchor")));
			this.cbinengaged.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinengaged.Appearance")));
			this.cbinengaged.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinengaged.BackgroundImage")));
			this.cbinengaged.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinengaged.CheckAlign")));
			this.cbinengaged.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinengaged.Dock")));
			this.cbinengaged.Enabled = ((bool)(resources.GetObject("cbinengaged.Enabled")));
			this.cbinengaged.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinengaged.FlatStyle")));
			this.cbinengaged.Font = ((System.Drawing.Font)(resources.GetObject("cbinengaged.Font")));
			this.cbinengaged.Image = ((System.Drawing.Image)(resources.GetObject("cbinengaged.Image")));
			this.cbinengaged.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinengaged.ImageAlign")));
			this.cbinengaged.ImageIndex = ((int)(resources.GetObject("cbinengaged.ImageIndex")));
			this.cbinengaged.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinengaged.ImeMode")));
			this.cbinengaged.Location = ((System.Drawing.Point)(resources.GetObject("cbinengaged.Location")));
			this.cbinengaged.Name = "cbinengaged";
			this.cbinengaged.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinengaged.RightToLeft")));
			this.cbinengaged.Size = ((System.Drawing.Size)(resources.GetObject("cbinengaged.Size")));
			this.cbinengaged.TabIndex = ((int)(resources.GetObject("cbinengaged.TabIndex")));
			this.cbinengaged.Text = resources.GetString("cbinengaged.Text");
			this.cbinengaged.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinengaged.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinengaged, resources.GetString("cbinengaged.ToolTip"));
			this.cbinengaged.Visible = ((bool)(resources.GetObject("cbinengaged.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinengaged, true);
			// 
			// cbinsteady
			// 
			this.cbinsteady.AccessibleDescription = resources.GetString("cbinsteady.AccessibleDescription");
			this.cbinsteady.AccessibleName = resources.GetString("cbinsteady.AccessibleName");
			this.cbinsteady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinsteady.Anchor")));
			this.cbinsteady.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinsteady.Appearance")));
			this.cbinsteady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinsteady.BackgroundImage")));
			this.cbinsteady.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinsteady.CheckAlign")));
			this.cbinsteady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinsteady.Dock")));
			this.cbinsteady.Enabled = ((bool)(resources.GetObject("cbinsteady.Enabled")));
			this.cbinsteady.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinsteady.FlatStyle")));
			this.cbinsteady.Font = ((System.Drawing.Font)(resources.GetObject("cbinsteady.Font")));
			this.cbinsteady.Image = ((System.Drawing.Image)(resources.GetObject("cbinsteady.Image")));
			this.cbinsteady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinsteady.ImageAlign")));
			this.cbinsteady.ImageIndex = ((int)(resources.GetObject("cbinsteady.ImageIndex")));
			this.cbinsteady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinsteady.ImeMode")));
			this.cbinsteady.Location = ((System.Drawing.Point)(resources.GetObject("cbinsteady.Location")));
			this.cbinsteady.Name = "cbinsteady";
			this.cbinsteady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinsteady.RightToLeft")));
			this.cbinsteady.Size = ((System.Drawing.Size)(resources.GetObject("cbinsteady.Size")));
			this.cbinsteady.TabIndex = ((int)(resources.GetObject("cbinsteady.TabIndex")));
			this.cbinsteady.Text = resources.GetString("cbinsteady.Text");
			this.cbinsteady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinsteady.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinsteady, resources.GetString("cbinsteady.ToolTip"));
			this.cbinsteady.Visible = ((bool)(resources.GetObject("cbinsteady.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinsteady, true);
			// 
			// cbinlove
			// 
			this.cbinlove.AccessibleDescription = resources.GetString("cbinlove.AccessibleDescription");
			this.cbinlove.AccessibleName = resources.GetString("cbinlove.AccessibleName");
			this.cbinlove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinlove.Anchor")));
			this.cbinlove.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinlove.Appearance")));
			this.cbinlove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinlove.BackgroundImage")));
			this.cbinlove.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinlove.CheckAlign")));
			this.cbinlove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinlove.Dock")));
			this.cbinlove.Enabled = ((bool)(resources.GetObject("cbinlove.Enabled")));
			this.cbinlove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinlove.FlatStyle")));
			this.cbinlove.Font = ((System.Drawing.Font)(resources.GetObject("cbinlove.Font")));
			this.cbinlove.Image = ((System.Drawing.Image)(resources.GetObject("cbinlove.Image")));
			this.cbinlove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinlove.ImageAlign")));
			this.cbinlove.ImageIndex = ((int)(resources.GetObject("cbinlove.ImageIndex")));
			this.cbinlove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinlove.ImeMode")));
			this.cbinlove.Location = ((System.Drawing.Point)(resources.GetObject("cbinlove.Location")));
			this.cbinlove.Name = "cbinlove";
			this.cbinlove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinlove.RightToLeft")));
			this.cbinlove.Size = ((System.Drawing.Size)(resources.GetObject("cbinlove.Size")));
			this.cbinlove.TabIndex = ((int)(resources.GetObject("cbinlove.TabIndex")));
			this.cbinlove.Text = resources.GetString("cbinlove.Text");
			this.cbinlove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinlove.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinlove, resources.GetString("cbinlove.ToolTip"));
			this.cbinlove.Visible = ((bool)(resources.GetObject("cbinlove.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinlove, true);
			// 
			// cbincrush
			// 
			this.cbincrush.AccessibleDescription = resources.GetString("cbincrush.AccessibleDescription");
			this.cbincrush.AccessibleName = resources.GetString("cbincrush.AccessibleName");
			this.cbincrush.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbincrush.Anchor")));
			this.cbincrush.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbincrush.Appearance")));
			this.cbincrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbincrush.BackgroundImage")));
			this.cbincrush.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbincrush.CheckAlign")));
			this.cbincrush.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbincrush.Dock")));
			this.cbincrush.Enabled = ((bool)(resources.GetObject("cbincrush.Enabled")));
			this.cbincrush.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbincrush.FlatStyle")));
			this.cbincrush.Font = ((System.Drawing.Font)(resources.GetObject("cbincrush.Font")));
			this.cbincrush.Image = ((System.Drawing.Image)(resources.GetObject("cbincrush.Image")));
			this.cbincrush.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbincrush.ImageAlign")));
			this.cbincrush.ImageIndex = ((int)(resources.GetObject("cbincrush.ImageIndex")));
			this.cbincrush.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbincrush.ImeMode")));
			this.cbincrush.Location = ((System.Drawing.Point)(resources.GetObject("cbincrush.Location")));
			this.cbincrush.Name = "cbincrush";
			this.cbincrush.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbincrush.RightToLeft")));
			this.cbincrush.Size = ((System.Drawing.Size)(resources.GetObject("cbincrush.Size")));
			this.cbincrush.TabIndex = ((int)(resources.GetObject("cbincrush.TabIndex")));
			this.cbincrush.Text = resources.GetString("cbincrush.Text");
			this.cbincrush.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbincrush.TextAlign")));
			this.toolTip1.SetToolTip(this.cbincrush, resources.GetString("cbincrush.ToolTip"));
			this.cbincrush.Visible = ((bool)(resources.GetObject("cbincrush.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbincrush, true);
			// 
			// cbinbuddie
			// 
			this.cbinbuddie.AccessibleDescription = resources.GetString("cbinbuddie.AccessibleDescription");
			this.cbinbuddie.AccessibleName = resources.GetString("cbinbuddie.AccessibleName");
			this.cbinbuddie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinbuddie.Anchor")));
			this.cbinbuddie.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinbuddie.Appearance")));
			this.cbinbuddie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinbuddie.BackgroundImage")));
			this.cbinbuddie.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbuddie.CheckAlign")));
			this.cbinbuddie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinbuddie.Dock")));
			this.cbinbuddie.Enabled = ((bool)(resources.GetObject("cbinbuddie.Enabled")));
			this.cbinbuddie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinbuddie.FlatStyle")));
			this.cbinbuddie.Font = ((System.Drawing.Font)(resources.GetObject("cbinbuddie.Font")));
			this.cbinbuddie.Image = ((System.Drawing.Image)(resources.GetObject("cbinbuddie.Image")));
			this.cbinbuddie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbuddie.ImageAlign")));
			this.cbinbuddie.ImageIndex = ((int)(resources.GetObject("cbinbuddie.ImageIndex")));
			this.cbinbuddie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinbuddie.ImeMode")));
			this.cbinbuddie.Location = ((System.Drawing.Point)(resources.GetObject("cbinbuddie.Location")));
			this.cbinbuddie.Name = "cbinbuddie";
			this.cbinbuddie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinbuddie.RightToLeft")));
			this.cbinbuddie.Size = ((System.Drawing.Size)(resources.GetObject("cbinbuddie.Size")));
			this.cbinbuddie.TabIndex = ((int)(resources.GetObject("cbinbuddie.TabIndex")));
			this.cbinbuddie.Text = resources.GetString("cbinbuddie.Text");
			this.cbinbuddie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinbuddie.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinbuddie, resources.GetString("cbinbuddie.ToolTip"));
			this.cbinbuddie.Visible = ((bool)(resources.GetObject("cbinbuddie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinbuddie, true);
			// 
			// cbinfriend
			// 
			this.cbinfriend.AccessibleDescription = resources.GetString("cbinfriend.AccessibleDescription");
			this.cbinfriend.AccessibleName = resources.GetString("cbinfriend.AccessibleName");
			this.cbinfriend.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinfriend.Anchor")));
			this.cbinfriend.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinfriend.Appearance")));
			this.cbinfriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinfriend.BackgroundImage")));
			this.cbinfriend.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfriend.CheckAlign")));
			this.cbinfriend.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinfriend.Dock")));
			this.cbinfriend.Enabled = ((bool)(resources.GetObject("cbinfriend.Enabled")));
			this.cbinfriend.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinfriend.FlatStyle")));
			this.cbinfriend.Font = ((System.Drawing.Font)(resources.GetObject("cbinfriend.Font")));
			this.cbinfriend.Image = ((System.Drawing.Image)(resources.GetObject("cbinfriend.Image")));
			this.cbinfriend.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfriend.ImageAlign")));
			this.cbinfriend.ImageIndex = ((int)(resources.GetObject("cbinfriend.ImageIndex")));
			this.cbinfriend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinfriend.ImeMode")));
			this.cbinfriend.Location = ((System.Drawing.Point)(resources.GetObject("cbinfriend.Location")));
			this.cbinfriend.Name = "cbinfriend";
			this.cbinfriend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinfriend.RightToLeft")));
			this.cbinfriend.Size = ((System.Drawing.Size)(resources.GetObject("cbinfriend.Size")));
			this.cbinfriend.TabIndex = ((int)(resources.GetObject("cbinfriend.TabIndex")));
			this.cbinfriend.Text = resources.GetString("cbinfriend.Text");
			this.cbinfriend.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinfriend.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinfriend, resources.GetString("cbinfriend.ToolTip"));
			this.cbinfriend.Visible = ((bool)(resources.GetObject("cbinfriend.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinfriend, true);
			// 
			// cbinenemy
			// 
			this.cbinenemy.AccessibleDescription = resources.GetString("cbinenemy.AccessibleDescription");
			this.cbinenemy.AccessibleName = resources.GetString("cbinenemy.AccessibleName");
			this.cbinenemy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbinenemy.Anchor")));
			this.cbinenemy.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbinenemy.Appearance")));
			this.cbinenemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbinenemy.BackgroundImage")));
			this.cbinenemy.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinenemy.CheckAlign")));
			this.cbinenemy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbinenemy.Dock")));
			this.cbinenemy.Enabled = ((bool)(resources.GetObject("cbinenemy.Enabled")));
			this.cbinenemy.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbinenemy.FlatStyle")));
			this.cbinenemy.Font = ((System.Drawing.Font)(resources.GetObject("cbinenemy.Font")));
			this.cbinenemy.Image = ((System.Drawing.Image)(resources.GetObject("cbinenemy.Image")));
			this.cbinenemy.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinenemy.ImageAlign")));
			this.cbinenemy.ImageIndex = ((int)(resources.GetObject("cbinenemy.ImageIndex")));
			this.cbinenemy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbinenemy.ImeMode")));
			this.cbinenemy.Location = ((System.Drawing.Point)(resources.GetObject("cbinenemy.Location")));
			this.cbinenemy.Name = "cbinenemy";
			this.cbinenemy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbinenemy.RightToLeft")));
			this.cbinenemy.Size = ((System.Drawing.Size)(resources.GetObject("cbinenemy.Size")));
			this.cbinenemy.TabIndex = ((int)(resources.GetObject("cbinenemy.TabIndex")));
			this.cbinenemy.Text = resources.GetString("cbinenemy.Text");
			this.cbinenemy.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbinenemy.TextAlign")));
			this.toolTip1.SetToolTip(this.cbinenemy, resources.GetString("cbinenemy.ToolTip"));
			this.cbinenemy.Visible = ((bool)(resources.GetObject("cbinenemy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbinenemy, true);
			// 
			// tbinrellong
			// 
			this.tbinrellong.AccessibleDescription = resources.GetString("tbinrellong.AccessibleDescription");
			this.tbinrellong.AccessibleName = resources.GetString("tbinrellong.AccessibleName");
			this.tbinrellong.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinrellong.Anchor")));
			this.tbinrellong.AutoSize = ((bool)(resources.GetObject("tbinrellong.AutoSize")));
			this.tbinrellong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinrellong.BackgroundImage")));
			this.tbinrellong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbinrellong.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinrellong.Dock")));
			this.tbinrellong.Enabled = ((bool)(resources.GetObject("tbinrellong.Enabled")));
			this.tbinrellong.Font = ((System.Drawing.Font)(resources.GetObject("tbinrellong.Font")));
			this.tbinrellong.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinrellong.ImeMode")));
			this.tbinrellong.Location = ((System.Drawing.Point)(resources.GetObject("tbinrellong.Location")));
			this.tbinrellong.MaxLength = ((int)(resources.GetObject("tbinrellong.MaxLength")));
			this.tbinrellong.Multiline = ((bool)(resources.GetObject("tbinrellong.Multiline")));
			this.tbinrellong.Name = "tbinrellong";
			this.tbinrellong.PasswordChar = ((char)(resources.GetObject("tbinrellong.PasswordChar")));
			this.tbinrellong.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinrellong.RightToLeft")));
			this.tbinrellong.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinrellong.ScrollBars")));
			this.tbinrellong.Size = ((System.Drawing.Size)(resources.GetObject("tbinrellong.Size")));
			this.tbinrellong.TabIndex = ((int)(resources.GetObject("tbinrellong.TabIndex")));
			this.tbinrellong.Text = resources.GetString("tbinrellong.Text");
			this.tbinrellong.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinrellong.TextAlign")));
			this.toolTip1.SetToolTip(this.tbinrellong, resources.GetString("tbinrellong.ToolTip"));
			this.tbinrellong.Visible = ((bool)(resources.GetObject("tbinrellong.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbinrellong, true);
			this.tbinrellong.WordWrap = ((bool)(resources.GetObject("tbinrellong.WordWrap")));
			// 
			// tbinrelshort
			// 
			this.tbinrelshort.AccessibleDescription = resources.GetString("tbinrelshort.AccessibleDescription");
			this.tbinrelshort.AccessibleName = resources.GetString("tbinrelshort.AccessibleName");
			this.tbinrelshort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbinrelshort.Anchor")));
			this.tbinrelshort.AutoSize = ((bool)(resources.GetObject("tbinrelshort.AutoSize")));
			this.tbinrelshort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbinrelshort.BackgroundImage")));
			this.tbinrelshort.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbinrelshort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbinrelshort.Dock")));
			this.tbinrelshort.Enabled = ((bool)(resources.GetObject("tbinrelshort.Enabled")));
			this.tbinrelshort.Font = ((System.Drawing.Font)(resources.GetObject("tbinrelshort.Font")));
			this.tbinrelshort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbinrelshort.ImeMode")));
			this.tbinrelshort.Location = ((System.Drawing.Point)(resources.GetObject("tbinrelshort.Location")));
			this.tbinrelshort.MaxLength = ((int)(resources.GetObject("tbinrelshort.MaxLength")));
			this.tbinrelshort.Multiline = ((bool)(resources.GetObject("tbinrelshort.Multiline")));
			this.tbinrelshort.Name = "tbinrelshort";
			this.tbinrelshort.PasswordChar = ((char)(resources.GetObject("tbinrelshort.PasswordChar")));
			this.tbinrelshort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbinrelshort.RightToLeft")));
			this.tbinrelshort.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbinrelshort.ScrollBars")));
			this.tbinrelshort.Size = ((System.Drawing.Size)(resources.GetObject("tbinrelshort.Size")));
			this.tbinrelshort.TabIndex = ((int)(resources.GetObject("tbinrelshort.TabIndex")));
			this.tbinrelshort.Text = resources.GetString("tbinrelshort.Text");
			this.tbinrelshort.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbinrelshort.TextAlign")));
			this.toolTip1.SetToolTip(this.tbinrelshort, resources.GetString("tbinrelshort.ToolTip"));
			this.tbinrelshort.Visible = ((bool)(resources.GetObject("tbinrelshort.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbinrelshort, true);
			this.tbinrelshort.WordWrap = ((bool)(resources.GetObject("tbinrelshort.WordWrap")));
			// 
			// label54
			// 
			this.label54.AccessibleDescription = resources.GetString("label54.AccessibleDescription");
			this.label54.AccessibleName = resources.GetString("label54.AccessibleName");
			this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label54.Anchor")));
			this.label54.AutoSize = ((bool)(resources.GetObject("label54.AutoSize")));
			this.label54.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label54.Dock")));
			this.label54.Enabled = ((bool)(resources.GetObject("label54.Enabled")));
			this.label54.Font = ((System.Drawing.Font)(resources.GetObject("label54.Font")));
			this.label54.Image = ((System.Drawing.Image)(resources.GetObject("label54.Image")));
			this.label54.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label54.ImageAlign")));
			this.label54.ImageIndex = ((int)(resources.GetObject("label54.ImageIndex")));
			this.label54.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label54.ImeMode")));
			this.label54.Location = ((System.Drawing.Point)(resources.GetObject("label54.Location")));
			this.label54.Name = "label54";
			this.label54.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label54.RightToLeft")));
			this.label54.Size = ((System.Drawing.Size)(resources.GetObject("label54.Size")));
			this.label54.TabIndex = ((int)(resources.GetObject("label54.TabIndex")));
			this.label54.Text = resources.GetString("label54.Text");
			this.label54.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label54.TextAlign")));
			this.toolTip1.SetToolTip(this.label54, resources.GetString("label54.ToolTip"));
			this.label54.Visible = ((bool)(resources.GetObject("label54.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label54, true);
			// 
			// label55
			// 
			this.label55.AccessibleDescription = resources.GetString("label55.AccessibleDescription");
			this.label55.AccessibleName = resources.GetString("label55.AccessibleName");
			this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label55.Anchor")));
			this.label55.AutoSize = ((bool)(resources.GetObject("label55.AutoSize")));
			this.label55.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label55.Dock")));
			this.label55.Enabled = ((bool)(resources.GetObject("label55.Enabled")));
			this.label55.Font = ((System.Drawing.Font)(resources.GetObject("label55.Font")));
			this.label55.Image = ((System.Drawing.Image)(resources.GetObject("label55.Image")));
			this.label55.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label55.ImageAlign")));
			this.label55.ImageIndex = ((int)(resources.GetObject("label55.ImageIndex")));
			this.label55.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label55.ImeMode")));
			this.label55.Location = ((System.Drawing.Point)(resources.GetObject("label55.Location")));
			this.label55.Name = "label55";
			this.label55.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label55.RightToLeft")));
			this.label55.Size = ((System.Drawing.Size)(resources.GetObject("label55.Size")));
			this.label55.TabIndex = ((int)(resources.GetObject("label55.TabIndex")));
			this.label55.Text = resources.GetString("label55.Text");
			this.label55.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label55.TextAlign")));
			this.toolTip1.SetToolTip(this.label55, resources.GetString("label55.ToolTip"));
			this.label55.Visible = ((bool)(resources.GetObject("label55.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label55, true);
			// 
			// tbskills
			// 
			this.tbskills.AccessibleDescription = resources.GetString("tbskills.AccessibleDescription");
			this.tbskills.AccessibleName = resources.GetString("tbskills.AccessibleName");
			this.tbskills.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbskills.Anchor")));
			this.tbskills.AutoScroll = ((bool)(resources.GetObject("tbskills.AutoScroll")));
			this.tbskills.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbskills.AutoScrollMargin")));
			this.tbskills.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbskills.AutoScrollMinSize")));
			this.tbskills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbskills.BackgroundImage")));
			this.tbskills.Controls.Add(this.gbskills);
			this.tbskills.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbskills.Dock")));
			this.tbskills.Enabled = ((bool)(resources.GetObject("tbskills.Enabled")));
			this.tbskills.Font = ((System.Drawing.Font)(resources.GetObject("tbskills.Font")));
			this.tbskills.ImageIndex = ((int)(resources.GetObject("tbskills.ImageIndex")));
			this.tbskills.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbskills.ImeMode")));
			this.tbskills.Location = ((System.Drawing.Point)(resources.GetObject("tbskills.Location")));
			this.tbskills.Name = "tbskills";
			this.tbskills.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbskills.RightToLeft")));
			this.tbskills.Size = ((System.Drawing.Size)(resources.GetObject("tbskills.Size")));
			this.tbskills.TabIndex = ((int)(resources.GetObject("tbskills.TabIndex")));
			this.tbskills.Text = resources.GetString("tbskills.Text");
			this.toolTip1.SetToolTip(this.tbskills, resources.GetString("tbskills.ToolTip"));
			this.tbskills.ToolTipText = resources.GetString("tbskills.ToolTipText");
			this.tbskills.Visible = ((bool)(resources.GetObject("tbskills.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbskills, true);
			// 
			// gbskills
			// 
			this.gbskills.AccessibleDescription = resources.GetString("gbskills.AccessibleDescription");
			this.gbskills.AccessibleName = resources.GetString("gbskills.AccessibleName");
			this.gbskills.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbskills.Anchor")));
			this.gbskills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbskills.BackgroundImage")));
			this.gbskills.Controls.Add(this.tbromance);
			this.gbskills.Controls.Add(this.pbromance);
			this.gbskills.Controls.Add(this.label76);
			this.gbskills.Controls.Add(this.pbcooking);
			this.gbskills.Controls.Add(this.label21);
			this.gbskills.Controls.Add(this.tbfatness);
			this.gbskills.Controls.Add(this.pbfatness);
			this.gbskills.Controls.Add(this.label51);
			this.gbskills.Controls.Add(this.tbcleaning);
			this.gbskills.Controls.Add(this.tbcreativity);
			this.gbskills.Controls.Add(this.tblogic);
			this.gbskills.Controls.Add(this.tbbody);
			this.gbskills.Controls.Add(this.tbcharisma);
			this.gbskills.Controls.Add(this.tbmechanical);
			this.gbskills.Controls.Add(this.tbcooking);
			this.gbskills.Controls.Add(this.pbcleaning);
			this.gbskills.Controls.Add(this.pbcreativity);
			this.gbskills.Controls.Add(this.pbbody);
			this.gbskills.Controls.Add(this.pbcharisma);
			this.gbskills.Controls.Add(this.pbmechanical);
			this.gbskills.Controls.Add(this.pblogic);
			this.gbskills.Controls.Add(this.label27);
			this.gbskills.Controls.Add(this.label26);
			this.gbskills.Controls.Add(this.label25);
			this.gbskills.Controls.Add(this.label24);
			this.gbskills.Controls.Add(this.label23);
			this.gbskills.Controls.Add(this.label22);
			this.gbskills.Controls.Add(this.linkLabel2);
			this.gbskills.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbskills.Dock")));
			this.gbskills.Enabled = ((bool)(resources.GetObject("gbskills.Enabled")));
			this.gbskills.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbskills.Font = ((System.Drawing.Font)(resources.GetObject("gbskills.Font")));
			this.gbskills.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbskills.ImeMode")));
			this.gbskills.Location = ((System.Drawing.Point)(resources.GetObject("gbskills.Location")));
			this.gbskills.Name = "gbskills";
			this.gbskills.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbskills.RightToLeft")));
			this.gbskills.Size = ((System.Drawing.Size)(resources.GetObject("gbskills.Size")));
			this.gbskills.TabIndex = ((int)(resources.GetObject("gbskills.TabIndex")));
			this.gbskills.TabStop = false;
			this.gbskills.Text = resources.GetString("gbskills.Text");
			this.toolTip1.SetToolTip(this.gbskills, resources.GetString("gbskills.ToolTip"));
			this.gbskills.Visible = ((bool)(resources.GetObject("gbskills.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbskills, true);
			this.gbskills.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.gbskills.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbromance
			// 
			this.tbromance.AccessibleDescription = resources.GetString("tbromance.AccessibleDescription");
			this.tbromance.AccessibleName = resources.GetString("tbromance.AccessibleName");
			this.tbromance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbromance.Anchor")));
			this.tbromance.AutoSize = ((bool)(resources.GetObject("tbromance.AutoSize")));
			this.tbromance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbromance.BackgroundImage")));
			this.tbromance.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbromance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbromance.Dock")));
			this.tbromance.Enabled = ((bool)(resources.GetObject("tbromance.Enabled")));
			this.tbromance.Font = ((System.Drawing.Font)(resources.GetObject("tbromance.Font")));
			this.tbromance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbromance.ImeMode")));
			this.tbromance.Location = ((System.Drawing.Point)(resources.GetObject("tbromance.Location")));
			this.tbromance.MaxLength = ((int)(resources.GetObject("tbromance.MaxLength")));
			this.tbromance.Multiline = ((bool)(resources.GetObject("tbromance.Multiline")));
			this.tbromance.Name = "tbromance";
			this.tbromance.PasswordChar = ((char)(resources.GetObject("tbromance.PasswordChar")));
			this.tbromance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbromance.RightToLeft")));
			this.tbromance.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbromance.ScrollBars")));
			this.tbromance.Size = ((System.Drawing.Size)(resources.GetObject("tbromance.Size")));
			this.tbromance.TabIndex = ((int)(resources.GetObject("tbromance.TabIndex")));
			this.tbromance.Text = resources.GetString("tbromance.Text");
			this.tbromance.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbromance.TextAlign")));
			this.toolTip1.SetToolTip(this.tbromance, resources.GetString("tbromance.ToolTip"));
			this.tbromance.Visible = ((bool)(resources.GetObject("tbromance.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbromance, true);
			this.tbromance.WordWrap = ((bool)(resources.GetObject("tbromance.WordWrap")));
			this.tbromance.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbromance.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbromance
			// 
			this.pbromance.AccessibleDescription = resources.GetString("pbromance.AccessibleDescription");
			this.pbromance.AccessibleName = resources.GetString("pbromance.AccessibleName");
			this.pbromance.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbromance.Anchor")));
			this.pbromance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbromance.BackgroundImage")));
			this.pbromance.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbromance.Dock")));
			this.pbromance.Enabled = ((bool)(resources.GetObject("pbromance.Enabled")));
			this.pbromance.Font = ((System.Drawing.Font)(resources.GetObject("pbromance.Font")));
			this.pbromance.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbromance.ImeMode")));
			this.pbromance.Location = ((System.Drawing.Point)(resources.GetObject("pbromance.Location")));
			this.pbromance.Maximum = 1000;
			this.pbromance.Name = "pbromance";
			this.pbromance.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbromance.RightToLeft")));
			this.pbromance.Size = ((System.Drawing.Size)(resources.GetObject("pbromance.Size")));
			this.pbromance.Step = 1;
			this.pbromance.TabIndex = ((int)(resources.GetObject("pbromance.TabIndex")));
			this.pbromance.Text = resources.GetString("pbromance.Text");
			this.toolTip1.SetToolTip(this.pbromance, resources.GetString("pbromance.ToolTip"));
			this.pbromance.Visible = ((bool)(resources.GetObject("pbromance.Visible")));
			this.pbromance.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbromance.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbromance.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label76
			// 
			this.label76.AccessibleDescription = resources.GetString("label76.AccessibleDescription");
			this.label76.AccessibleName = resources.GetString("label76.AccessibleName");
			this.label76.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label76.Anchor")));
			this.label76.AutoSize = ((bool)(resources.GetObject("label76.AutoSize")));
			this.label76.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label76.Dock")));
			this.label76.Enabled = ((bool)(resources.GetObject("label76.Enabled")));
			this.label76.Font = ((System.Drawing.Font)(resources.GetObject("label76.Font")));
			this.label76.Image = ((System.Drawing.Image)(resources.GetObject("label76.Image")));
			this.label76.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label76.ImageAlign")));
			this.label76.ImageIndex = ((int)(resources.GetObject("label76.ImageIndex")));
			this.label76.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label76.ImeMode")));
			this.label76.Location = ((System.Drawing.Point)(resources.GetObject("label76.Location")));
			this.label76.Name = "label76";
			this.label76.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label76.RightToLeft")));
			this.label76.Size = ((System.Drawing.Size)(resources.GetObject("label76.Size")));
			this.label76.TabIndex = ((int)(resources.GetObject("label76.TabIndex")));
			this.label76.Text = resources.GetString("label76.Text");
			this.label76.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label76.TextAlign")));
			this.toolTip1.SetToolTip(this.label76, resources.GetString("label76.ToolTip"));
			this.label76.Visible = ((bool)(resources.GetObject("label76.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label76, true);
			// 
			// pbcooking
			// 
			this.pbcooking.AccessibleDescription = resources.GetString("pbcooking.AccessibleDescription");
			this.pbcooking.AccessibleName = resources.GetString("pbcooking.AccessibleName");
			this.pbcooking.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcooking.Anchor")));
			this.pbcooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcooking.BackgroundImage")));
			this.pbcooking.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcooking.Dock")));
			this.pbcooking.Enabled = ((bool)(resources.GetObject("pbcooking.Enabled")));
			this.pbcooking.Font = ((System.Drawing.Font)(resources.GetObject("pbcooking.Font")));
			this.pbcooking.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcooking.ImeMode")));
			this.pbcooking.Location = ((System.Drawing.Point)(resources.GetObject("pbcooking.Location")));
			this.pbcooking.Maximum = 1000;
			this.pbcooking.Name = "pbcooking";
			this.pbcooking.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcooking.RightToLeft")));
			this.pbcooking.Size = ((System.Drawing.Size)(resources.GetObject("pbcooking.Size")));
			this.pbcooking.Step = 1;
			this.pbcooking.TabIndex = ((int)(resources.GetObject("pbcooking.TabIndex")));
			this.pbcooking.Text = resources.GetString("pbcooking.Text");
			this.toolTip1.SetToolTip(this.pbcooking, resources.GetString("pbcooking.ToolTip"));
			this.pbcooking.Visible = ((bool)(resources.GetObject("pbcooking.Visible")));
			this.pbcooking.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcooking.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcooking.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label21
			// 
			this.label21.AccessibleDescription = resources.GetString("label21.AccessibleDescription");
			this.label21.AccessibleName = resources.GetString("label21.AccessibleName");
			this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label21.Anchor")));
			this.label21.AutoSize = ((bool)(resources.GetObject("label21.AutoSize")));
			this.label21.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label21.Dock")));
			this.label21.Enabled = ((bool)(resources.GetObject("label21.Enabled")));
			this.label21.Font = ((System.Drawing.Font)(resources.GetObject("label21.Font")));
			this.label21.Image = ((System.Drawing.Image)(resources.GetObject("label21.Image")));
			this.label21.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label21.ImageAlign")));
			this.label21.ImageIndex = ((int)(resources.GetObject("label21.ImageIndex")));
			this.label21.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label21.ImeMode")));
			this.label21.Location = ((System.Drawing.Point)(resources.GetObject("label21.Location")));
			this.label21.Name = "label21";
			this.label21.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label21.RightToLeft")));
			this.label21.Size = ((System.Drawing.Size)(resources.GetObject("label21.Size")));
			this.label21.TabIndex = ((int)(resources.GetObject("label21.TabIndex")));
			this.label21.Text = resources.GetString("label21.Text");
			this.label21.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label21.TextAlign")));
			this.toolTip1.SetToolTip(this.label21, resources.GetString("label21.ToolTip"));
			this.label21.Visible = ((bool)(resources.GetObject("label21.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label21, true);
			// 
			// tbfatness
			// 
			this.tbfatness.AccessibleDescription = resources.GetString("tbfatness.AccessibleDescription");
			this.tbfatness.AccessibleName = resources.GetString("tbfatness.AccessibleName");
			this.tbfatness.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfatness.Anchor")));
			this.tbfatness.AutoSize = ((bool)(resources.GetObject("tbfatness.AutoSize")));
			this.tbfatness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfatness.BackgroundImage")));
			this.tbfatness.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbfatness.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfatness.Dock")));
			this.tbfatness.Enabled = ((bool)(resources.GetObject("tbfatness.Enabled")));
			this.tbfatness.Font = ((System.Drawing.Font)(resources.GetObject("tbfatness.Font")));
			this.tbfatness.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfatness.ImeMode")));
			this.tbfatness.Location = ((System.Drawing.Point)(resources.GetObject("tbfatness.Location")));
			this.tbfatness.MaxLength = ((int)(resources.GetObject("tbfatness.MaxLength")));
			this.tbfatness.Multiline = ((bool)(resources.GetObject("tbfatness.Multiline")));
			this.tbfatness.Name = "tbfatness";
			this.tbfatness.PasswordChar = ((char)(resources.GetObject("tbfatness.PasswordChar")));
			this.tbfatness.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfatness.RightToLeft")));
			this.tbfatness.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfatness.ScrollBars")));
			this.tbfatness.Size = ((System.Drawing.Size)(resources.GetObject("tbfatness.Size")));
			this.tbfatness.TabIndex = ((int)(resources.GetObject("tbfatness.TabIndex")));
			this.tbfatness.Text = resources.GetString("tbfatness.Text");
			this.tbfatness.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfatness.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfatness, resources.GetString("tbfatness.ToolTip"));
			this.tbfatness.Visible = ((bool)(resources.GetObject("tbfatness.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfatness, true);
			this.tbfatness.WordWrap = ((bool)(resources.GetObject("tbfatness.WordWrap")));
			this.tbfatness.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbfatness.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbfatness
			// 
			this.pbfatness.AccessibleDescription = resources.GetString("pbfatness.AccessibleDescription");
			this.pbfatness.AccessibleName = resources.GetString("pbfatness.AccessibleName");
			this.pbfatness.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbfatness.Anchor")));
			this.pbfatness.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfatness.BackgroundImage")));
			this.pbfatness.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbfatness.Dock")));
			this.pbfatness.Enabled = ((bool)(resources.GetObject("pbfatness.Enabled")));
			this.pbfatness.Font = ((System.Drawing.Font)(resources.GetObject("pbfatness.Font")));
			this.pbfatness.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbfatness.ImeMode")));
			this.pbfatness.Location = ((System.Drawing.Point)(resources.GetObject("pbfatness.Location")));
			this.pbfatness.Maximum = 1000;
			this.pbfatness.Name = "pbfatness";
			this.pbfatness.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbfatness.RightToLeft")));
			this.pbfatness.Size = ((System.Drawing.Size)(resources.GetObject("pbfatness.Size")));
			this.pbfatness.Step = 1;
			this.pbfatness.TabIndex = ((int)(resources.GetObject("pbfatness.TabIndex")));
			this.pbfatness.Text = resources.GetString("pbfatness.Text");
			this.toolTip1.SetToolTip(this.pbfatness, resources.GetString("pbfatness.ToolTip"));
			this.pbfatness.Visible = ((bool)(resources.GetObject("pbfatness.Visible")));
			this.pbfatness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbfatness.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbfatness.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label51
			// 
			this.label51.AccessibleDescription = resources.GetString("label51.AccessibleDescription");
			this.label51.AccessibleName = resources.GetString("label51.AccessibleName");
			this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label51.Anchor")));
			this.label51.AutoSize = ((bool)(resources.GetObject("label51.AutoSize")));
			this.label51.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label51.Dock")));
			this.label51.Enabled = ((bool)(resources.GetObject("label51.Enabled")));
			this.label51.Font = ((System.Drawing.Font)(resources.GetObject("label51.Font")));
			this.label51.Image = ((System.Drawing.Image)(resources.GetObject("label51.Image")));
			this.label51.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label51.ImageAlign")));
			this.label51.ImageIndex = ((int)(resources.GetObject("label51.ImageIndex")));
			this.label51.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label51.ImeMode")));
			this.label51.Location = ((System.Drawing.Point)(resources.GetObject("label51.Location")));
			this.label51.Name = "label51";
			this.label51.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label51.RightToLeft")));
			this.label51.Size = ((System.Drawing.Size)(resources.GetObject("label51.Size")));
			this.label51.TabIndex = ((int)(resources.GetObject("label51.TabIndex")));
			this.label51.Text = resources.GetString("label51.Text");
			this.label51.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label51.TextAlign")));
			this.toolTip1.SetToolTip(this.label51, resources.GetString("label51.ToolTip"));
			this.label51.Visible = ((bool)(resources.GetObject("label51.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label51, true);
			// 
			// tbcleaning
			// 
			this.tbcleaning.AccessibleDescription = resources.GetString("tbcleaning.AccessibleDescription");
			this.tbcleaning.AccessibleName = resources.GetString("tbcleaning.AccessibleName");
			this.tbcleaning.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcleaning.Anchor")));
			this.tbcleaning.AutoSize = ((bool)(resources.GetObject("tbcleaning.AutoSize")));
			this.tbcleaning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcleaning.BackgroundImage")));
			this.tbcleaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcleaning.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcleaning.Dock")));
			this.tbcleaning.Enabled = ((bool)(resources.GetObject("tbcleaning.Enabled")));
			this.tbcleaning.Font = ((System.Drawing.Font)(resources.GetObject("tbcleaning.Font")));
			this.tbcleaning.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcleaning.ImeMode")));
			this.tbcleaning.Location = ((System.Drawing.Point)(resources.GetObject("tbcleaning.Location")));
			this.tbcleaning.MaxLength = ((int)(resources.GetObject("tbcleaning.MaxLength")));
			this.tbcleaning.Multiline = ((bool)(resources.GetObject("tbcleaning.Multiline")));
			this.tbcleaning.Name = "tbcleaning";
			this.tbcleaning.PasswordChar = ((char)(resources.GetObject("tbcleaning.PasswordChar")));
			this.tbcleaning.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcleaning.RightToLeft")));
			this.tbcleaning.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcleaning.ScrollBars")));
			this.tbcleaning.Size = ((System.Drawing.Size)(resources.GetObject("tbcleaning.Size")));
			this.tbcleaning.TabIndex = ((int)(resources.GetObject("tbcleaning.TabIndex")));
			this.tbcleaning.Text = resources.GetString("tbcleaning.Text");
			this.tbcleaning.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcleaning.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcleaning, resources.GetString("tbcleaning.ToolTip"));
			this.tbcleaning.Visible = ((bool)(resources.GetObject("tbcleaning.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcleaning, true);
			this.tbcleaning.WordWrap = ((bool)(resources.GetObject("tbcleaning.WordWrap")));
			this.tbcleaning.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcleaning.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbcreativity
			// 
			this.tbcreativity.AccessibleDescription = resources.GetString("tbcreativity.AccessibleDescription");
			this.tbcreativity.AccessibleName = resources.GetString("tbcreativity.AccessibleName");
			this.tbcreativity.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcreativity.Anchor")));
			this.tbcreativity.AutoSize = ((bool)(resources.GetObject("tbcreativity.AutoSize")));
			this.tbcreativity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcreativity.BackgroundImage")));
			this.tbcreativity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcreativity.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcreativity.Dock")));
			this.tbcreativity.Enabled = ((bool)(resources.GetObject("tbcreativity.Enabled")));
			this.tbcreativity.Font = ((System.Drawing.Font)(resources.GetObject("tbcreativity.Font")));
			this.tbcreativity.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcreativity.ImeMode")));
			this.tbcreativity.Location = ((System.Drawing.Point)(resources.GetObject("tbcreativity.Location")));
			this.tbcreativity.MaxLength = ((int)(resources.GetObject("tbcreativity.MaxLength")));
			this.tbcreativity.Multiline = ((bool)(resources.GetObject("tbcreativity.Multiline")));
			this.tbcreativity.Name = "tbcreativity";
			this.tbcreativity.PasswordChar = ((char)(resources.GetObject("tbcreativity.PasswordChar")));
			this.tbcreativity.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcreativity.RightToLeft")));
			this.tbcreativity.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcreativity.ScrollBars")));
			this.tbcreativity.Size = ((System.Drawing.Size)(resources.GetObject("tbcreativity.Size")));
			this.tbcreativity.TabIndex = ((int)(resources.GetObject("tbcreativity.TabIndex")));
			this.tbcreativity.Text = resources.GetString("tbcreativity.Text");
			this.tbcreativity.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcreativity.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcreativity, resources.GetString("tbcreativity.ToolTip"));
			this.tbcreativity.Visible = ((bool)(resources.GetObject("tbcreativity.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcreativity, true);
			this.tbcreativity.WordWrap = ((bool)(resources.GetObject("tbcreativity.WordWrap")));
			this.tbcreativity.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcreativity.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tblogic
			// 
			this.tblogic.AccessibleDescription = resources.GetString("tblogic.AccessibleDescription");
			this.tblogic.AccessibleName = resources.GetString("tblogic.AccessibleName");
			this.tblogic.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblogic.Anchor")));
			this.tblogic.AutoSize = ((bool)(resources.GetObject("tblogic.AutoSize")));
			this.tblogic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblogic.BackgroundImage")));
			this.tblogic.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tblogic.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblogic.Dock")));
			this.tblogic.Enabled = ((bool)(resources.GetObject("tblogic.Enabled")));
			this.tblogic.Font = ((System.Drawing.Font)(resources.GetObject("tblogic.Font")));
			this.tblogic.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblogic.ImeMode")));
			this.tblogic.Location = ((System.Drawing.Point)(resources.GetObject("tblogic.Location")));
			this.tblogic.MaxLength = ((int)(resources.GetObject("tblogic.MaxLength")));
			this.tblogic.Multiline = ((bool)(resources.GetObject("tblogic.Multiline")));
			this.tblogic.Name = "tblogic";
			this.tblogic.PasswordChar = ((char)(resources.GetObject("tblogic.PasswordChar")));
			this.tblogic.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblogic.RightToLeft")));
			this.tblogic.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblogic.ScrollBars")));
			this.tblogic.Size = ((System.Drawing.Size)(resources.GetObject("tblogic.Size")));
			this.tblogic.TabIndex = ((int)(resources.GetObject("tblogic.TabIndex")));
			this.tblogic.Text = resources.GetString("tblogic.Text");
			this.tblogic.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblogic.TextAlign")));
			this.toolTip1.SetToolTip(this.tblogic, resources.GetString("tblogic.ToolTip"));
			this.tblogic.Visible = ((bool)(resources.GetObject("tblogic.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblogic, true);
			this.tblogic.WordWrap = ((bool)(resources.GetObject("tblogic.WordWrap")));
			this.tblogic.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tblogic.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbbody
			// 
			this.tbbody.AccessibleDescription = resources.GetString("tbbody.AccessibleDescription");
			this.tbbody.AccessibleName = resources.GetString("tbbody.AccessibleName");
			this.tbbody.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbbody.Anchor")));
			this.tbbody.AutoSize = ((bool)(resources.GetObject("tbbody.AutoSize")));
			this.tbbody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbbody.BackgroundImage")));
			this.tbbody.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbbody.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbbody.Dock")));
			this.tbbody.Enabled = ((bool)(resources.GetObject("tbbody.Enabled")));
			this.tbbody.Font = ((System.Drawing.Font)(resources.GetObject("tbbody.Font")));
			this.tbbody.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbbody.ImeMode")));
			this.tbbody.Location = ((System.Drawing.Point)(resources.GetObject("tbbody.Location")));
			this.tbbody.MaxLength = ((int)(resources.GetObject("tbbody.MaxLength")));
			this.tbbody.Multiline = ((bool)(resources.GetObject("tbbody.Multiline")));
			this.tbbody.Name = "tbbody";
			this.tbbody.PasswordChar = ((char)(resources.GetObject("tbbody.PasswordChar")));
			this.tbbody.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbbody.RightToLeft")));
			this.tbbody.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbbody.ScrollBars")));
			this.tbbody.Size = ((System.Drawing.Size)(resources.GetObject("tbbody.Size")));
			this.tbbody.TabIndex = ((int)(resources.GetObject("tbbody.TabIndex")));
			this.tbbody.Text = resources.GetString("tbbody.Text");
			this.tbbody.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbbody.TextAlign")));
			this.toolTip1.SetToolTip(this.tbbody, resources.GetString("tbbody.ToolTip"));
			this.tbbody.Visible = ((bool)(resources.GetObject("tbbody.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbbody, true);
			this.tbbody.WordWrap = ((bool)(resources.GetObject("tbbody.WordWrap")));
			this.tbbody.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbbody.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbcharisma
			// 
			this.tbcharisma.AccessibleDescription = resources.GetString("tbcharisma.AccessibleDescription");
			this.tbcharisma.AccessibleName = resources.GetString("tbcharisma.AccessibleName");
			this.tbcharisma.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcharisma.Anchor")));
			this.tbcharisma.AutoSize = ((bool)(resources.GetObject("tbcharisma.AutoSize")));
			this.tbcharisma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcharisma.BackgroundImage")));
			this.tbcharisma.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcharisma.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcharisma.Dock")));
			this.tbcharisma.Enabled = ((bool)(resources.GetObject("tbcharisma.Enabled")));
			this.tbcharisma.Font = ((System.Drawing.Font)(resources.GetObject("tbcharisma.Font")));
			this.tbcharisma.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcharisma.ImeMode")));
			this.tbcharisma.Location = ((System.Drawing.Point)(resources.GetObject("tbcharisma.Location")));
			this.tbcharisma.MaxLength = ((int)(resources.GetObject("tbcharisma.MaxLength")));
			this.tbcharisma.Multiline = ((bool)(resources.GetObject("tbcharisma.Multiline")));
			this.tbcharisma.Name = "tbcharisma";
			this.tbcharisma.PasswordChar = ((char)(resources.GetObject("tbcharisma.PasswordChar")));
			this.tbcharisma.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcharisma.RightToLeft")));
			this.tbcharisma.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcharisma.ScrollBars")));
			this.tbcharisma.Size = ((System.Drawing.Size)(resources.GetObject("tbcharisma.Size")));
			this.tbcharisma.TabIndex = ((int)(resources.GetObject("tbcharisma.TabIndex")));
			this.tbcharisma.Text = resources.GetString("tbcharisma.Text");
			this.tbcharisma.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcharisma.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcharisma, resources.GetString("tbcharisma.ToolTip"));
			this.tbcharisma.Visible = ((bool)(resources.GetObject("tbcharisma.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcharisma, true);
			this.tbcharisma.WordWrap = ((bool)(resources.GetObject("tbcharisma.WordWrap")));
			this.tbcharisma.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcharisma.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbmechanical
			// 
			this.tbmechanical.AccessibleDescription = resources.GetString("tbmechanical.AccessibleDescription");
			this.tbmechanical.AccessibleName = resources.GetString("tbmechanical.AccessibleName");
			this.tbmechanical.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbmechanical.Anchor")));
			this.tbmechanical.AutoSize = ((bool)(resources.GetObject("tbmechanical.AutoSize")));
			this.tbmechanical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbmechanical.BackgroundImage")));
			this.tbmechanical.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbmechanical.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbmechanical.Dock")));
			this.tbmechanical.Enabled = ((bool)(resources.GetObject("tbmechanical.Enabled")));
			this.tbmechanical.Font = ((System.Drawing.Font)(resources.GetObject("tbmechanical.Font")));
			this.tbmechanical.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbmechanical.ImeMode")));
			this.tbmechanical.Location = ((System.Drawing.Point)(resources.GetObject("tbmechanical.Location")));
			this.tbmechanical.MaxLength = ((int)(resources.GetObject("tbmechanical.MaxLength")));
			this.tbmechanical.Multiline = ((bool)(resources.GetObject("tbmechanical.Multiline")));
			this.tbmechanical.Name = "tbmechanical";
			this.tbmechanical.PasswordChar = ((char)(resources.GetObject("tbmechanical.PasswordChar")));
			this.tbmechanical.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbmechanical.RightToLeft")));
			this.tbmechanical.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbmechanical.ScrollBars")));
			this.tbmechanical.Size = ((System.Drawing.Size)(resources.GetObject("tbmechanical.Size")));
			this.tbmechanical.TabIndex = ((int)(resources.GetObject("tbmechanical.TabIndex")));
			this.tbmechanical.Text = resources.GetString("tbmechanical.Text");
			this.tbmechanical.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbmechanical.TextAlign")));
			this.toolTip1.SetToolTip(this.tbmechanical, resources.GetString("tbmechanical.ToolTip"));
			this.tbmechanical.Visible = ((bool)(resources.GetObject("tbmechanical.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbmechanical, true);
			this.tbmechanical.WordWrap = ((bool)(resources.GetObject("tbmechanical.WordWrap")));
			this.tbmechanical.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbmechanical.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbcooking
			// 
			this.tbcooking.AccessibleDescription = resources.GetString("tbcooking.AccessibleDescription");
			this.tbcooking.AccessibleName = resources.GetString("tbcooking.AccessibleName");
			this.tbcooking.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcooking.Anchor")));
			this.tbcooking.AutoSize = ((bool)(resources.GetObject("tbcooking.AutoSize")));
			this.tbcooking.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcooking.BackgroundImage")));
			this.tbcooking.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcooking.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcooking.Dock")));
			this.tbcooking.Enabled = ((bool)(resources.GetObject("tbcooking.Enabled")));
			this.tbcooking.Font = ((System.Drawing.Font)(resources.GetObject("tbcooking.Font")));
			this.tbcooking.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcooking.ImeMode")));
			this.tbcooking.Location = ((System.Drawing.Point)(resources.GetObject("tbcooking.Location")));
			this.tbcooking.MaxLength = ((int)(resources.GetObject("tbcooking.MaxLength")));
			this.tbcooking.Multiline = ((bool)(resources.GetObject("tbcooking.Multiline")));
			this.tbcooking.Name = "tbcooking";
			this.tbcooking.PasswordChar = ((char)(resources.GetObject("tbcooking.PasswordChar")));
			this.tbcooking.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcooking.RightToLeft")));
			this.tbcooking.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcooking.ScrollBars")));
			this.tbcooking.Size = ((System.Drawing.Size)(resources.GetObject("tbcooking.Size")));
			this.tbcooking.TabIndex = ((int)(resources.GetObject("tbcooking.TabIndex")));
			this.tbcooking.Text = resources.GetString("tbcooking.Text");
			this.tbcooking.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcooking.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcooking, resources.GetString("tbcooking.ToolTip"));
			this.tbcooking.Visible = ((bool)(resources.GetObject("tbcooking.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcooking, true);
			this.tbcooking.WordWrap = ((bool)(resources.GetObject("tbcooking.WordWrap")));
			this.tbcooking.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcooking.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbcleaning
			// 
			this.pbcleaning.AccessibleDescription = resources.GetString("pbcleaning.AccessibleDescription");
			this.pbcleaning.AccessibleName = resources.GetString("pbcleaning.AccessibleName");
			this.pbcleaning.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcleaning.Anchor")));
			this.pbcleaning.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcleaning.BackgroundImage")));
			this.pbcleaning.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcleaning.Dock")));
			this.pbcleaning.Enabled = ((bool)(resources.GetObject("pbcleaning.Enabled")));
			this.pbcleaning.Font = ((System.Drawing.Font)(resources.GetObject("pbcleaning.Font")));
			this.pbcleaning.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcleaning.ImeMode")));
			this.pbcleaning.Location = ((System.Drawing.Point)(resources.GetObject("pbcleaning.Location")));
			this.pbcleaning.Maximum = 1000;
			this.pbcleaning.Name = "pbcleaning";
			this.pbcleaning.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcleaning.RightToLeft")));
			this.pbcleaning.Size = ((System.Drawing.Size)(resources.GetObject("pbcleaning.Size")));
			this.pbcleaning.Step = 1;
			this.pbcleaning.TabIndex = ((int)(resources.GetObject("pbcleaning.TabIndex")));
			this.pbcleaning.Text = resources.GetString("pbcleaning.Text");
			this.toolTip1.SetToolTip(this.pbcleaning, resources.GetString("pbcleaning.ToolTip"));
			this.pbcleaning.Visible = ((bool)(resources.GetObject("pbcleaning.Visible")));
			this.pbcleaning.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcleaning.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcleaning.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbcreativity
			// 
			this.pbcreativity.AccessibleDescription = resources.GetString("pbcreativity.AccessibleDescription");
			this.pbcreativity.AccessibleName = resources.GetString("pbcreativity.AccessibleName");
			this.pbcreativity.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcreativity.Anchor")));
			this.pbcreativity.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcreativity.BackgroundImage")));
			this.pbcreativity.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcreativity.Dock")));
			this.pbcreativity.Enabled = ((bool)(resources.GetObject("pbcreativity.Enabled")));
			this.pbcreativity.Font = ((System.Drawing.Font)(resources.GetObject("pbcreativity.Font")));
			this.pbcreativity.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcreativity.ImeMode")));
			this.pbcreativity.Location = ((System.Drawing.Point)(resources.GetObject("pbcreativity.Location")));
			this.pbcreativity.Maximum = 1000;
			this.pbcreativity.Name = "pbcreativity";
			this.pbcreativity.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcreativity.RightToLeft")));
			this.pbcreativity.Size = ((System.Drawing.Size)(resources.GetObject("pbcreativity.Size")));
			this.pbcreativity.Step = 1;
			this.pbcreativity.TabIndex = ((int)(resources.GetObject("pbcreativity.TabIndex")));
			this.pbcreativity.Text = resources.GetString("pbcreativity.Text");
			this.toolTip1.SetToolTip(this.pbcreativity, resources.GetString("pbcreativity.ToolTip"));
			this.pbcreativity.Visible = ((bool)(resources.GetObject("pbcreativity.Visible")));
			this.pbcreativity.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcreativity.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcreativity.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbbody
			// 
			this.pbbody.AccessibleDescription = resources.GetString("pbbody.AccessibleDescription");
			this.pbbody.AccessibleName = resources.GetString("pbbody.AccessibleName");
			this.pbbody.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbbody.Anchor")));
			this.pbbody.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbbody.BackgroundImage")));
			this.pbbody.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbbody.Dock")));
			this.pbbody.Enabled = ((bool)(resources.GetObject("pbbody.Enabled")));
			this.pbbody.Font = ((System.Drawing.Font)(resources.GetObject("pbbody.Font")));
			this.pbbody.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbbody.ImeMode")));
			this.pbbody.Location = ((System.Drawing.Point)(resources.GetObject("pbbody.Location")));
			this.pbbody.Maximum = 1000;
			this.pbbody.Name = "pbbody";
			this.pbbody.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbbody.RightToLeft")));
			this.pbbody.Size = ((System.Drawing.Size)(resources.GetObject("pbbody.Size")));
			this.pbbody.Step = 1;
			this.pbbody.TabIndex = ((int)(resources.GetObject("pbbody.TabIndex")));
			this.pbbody.Text = resources.GetString("pbbody.Text");
			this.toolTip1.SetToolTip(this.pbbody, resources.GetString("pbbody.ToolTip"));
			this.pbbody.Visible = ((bool)(resources.GetObject("pbbody.Visible")));
			this.pbbody.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbbody.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbbody.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbcharisma
			// 
			this.pbcharisma.AccessibleDescription = resources.GetString("pbcharisma.AccessibleDescription");
			this.pbcharisma.AccessibleName = resources.GetString("pbcharisma.AccessibleName");
			this.pbcharisma.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcharisma.Anchor")));
			this.pbcharisma.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcharisma.BackgroundImage")));
			this.pbcharisma.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcharisma.Dock")));
			this.pbcharisma.Enabled = ((bool)(resources.GetObject("pbcharisma.Enabled")));
			this.pbcharisma.Font = ((System.Drawing.Font)(resources.GetObject("pbcharisma.Font")));
			this.pbcharisma.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcharisma.ImeMode")));
			this.pbcharisma.Location = ((System.Drawing.Point)(resources.GetObject("pbcharisma.Location")));
			this.pbcharisma.Maximum = 1000;
			this.pbcharisma.Name = "pbcharisma";
			this.pbcharisma.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcharisma.RightToLeft")));
			this.pbcharisma.Size = ((System.Drawing.Size)(resources.GetObject("pbcharisma.Size")));
			this.pbcharisma.Step = 1;
			this.pbcharisma.TabIndex = ((int)(resources.GetObject("pbcharisma.TabIndex")));
			this.pbcharisma.Text = resources.GetString("pbcharisma.Text");
			this.toolTip1.SetToolTip(this.pbcharisma, resources.GetString("pbcharisma.ToolTip"));
			this.pbcharisma.Visible = ((bool)(resources.GetObject("pbcharisma.Visible")));
			this.pbcharisma.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcharisma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcharisma.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pbmechanical
			// 
			this.pbmechanical.AccessibleDescription = resources.GetString("pbmechanical.AccessibleDescription");
			this.pbmechanical.AccessibleName = resources.GetString("pbmechanical.AccessibleName");
			this.pbmechanical.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbmechanical.Anchor")));
			this.pbmechanical.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbmechanical.BackgroundImage")));
			this.pbmechanical.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbmechanical.Dock")));
			this.pbmechanical.Enabled = ((bool)(resources.GetObject("pbmechanical.Enabled")));
			this.pbmechanical.Font = ((System.Drawing.Font)(resources.GetObject("pbmechanical.Font")));
			this.pbmechanical.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbmechanical.ImeMode")));
			this.pbmechanical.Location = ((System.Drawing.Point)(resources.GetObject("pbmechanical.Location")));
			this.pbmechanical.Maximum = 1000;
			this.pbmechanical.Name = "pbmechanical";
			this.pbmechanical.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbmechanical.RightToLeft")));
			this.pbmechanical.Size = ((System.Drawing.Size)(resources.GetObject("pbmechanical.Size")));
			this.pbmechanical.Step = 1;
			this.pbmechanical.TabIndex = ((int)(resources.GetObject("pbmechanical.TabIndex")));
			this.pbmechanical.Text = resources.GetString("pbmechanical.Text");
			this.toolTip1.SetToolTip(this.pbmechanical, resources.GetString("pbmechanical.ToolTip"));
			this.pbmechanical.Visible = ((bool)(resources.GetObject("pbmechanical.Visible")));
			this.pbmechanical.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbmechanical.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbmechanical.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// pblogic
			// 
			this.pblogic.AccessibleDescription = resources.GetString("pblogic.AccessibleDescription");
			this.pblogic.AccessibleName = resources.GetString("pblogic.AccessibleName");
			this.pblogic.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pblogic.Anchor")));
			this.pblogic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pblogic.BackgroundImage")));
			this.pblogic.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pblogic.Dock")));
			this.pblogic.Enabled = ((bool)(resources.GetObject("pblogic.Enabled")));
			this.pblogic.Font = ((System.Drawing.Font)(resources.GetObject("pblogic.Font")));
			this.pblogic.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pblogic.ImeMode")));
			this.pblogic.Location = ((System.Drawing.Point)(resources.GetObject("pblogic.Location")));
			this.pblogic.Maximum = 1000;
			this.pblogic.Name = "pblogic";
			this.pblogic.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pblogic.RightToLeft")));
			this.pblogic.Size = ((System.Drawing.Size)(resources.GetObject("pblogic.Size")));
			this.pblogic.Step = 1;
			this.pblogic.TabIndex = ((int)(resources.GetObject("pblogic.TabIndex")));
			this.pblogic.Text = resources.GetString("pblogic.Text");
			this.toolTip1.SetToolTip(this.pblogic, resources.GetString("pblogic.ToolTip"));
			this.pblogic.Visible = ((bool)(resources.GetObject("pblogic.Visible")));
			this.pblogic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pblogic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pblogic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label27
			// 
			this.label27.AccessibleDescription = resources.GetString("label27.AccessibleDescription");
			this.label27.AccessibleName = resources.GetString("label27.AccessibleName");
			this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label27.Anchor")));
			this.label27.AutoSize = ((bool)(resources.GetObject("label27.AutoSize")));
			this.label27.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label27.Dock")));
			this.label27.Enabled = ((bool)(resources.GetObject("label27.Enabled")));
			this.label27.Font = ((System.Drawing.Font)(resources.GetObject("label27.Font")));
			this.label27.Image = ((System.Drawing.Image)(resources.GetObject("label27.Image")));
			this.label27.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.ImageAlign")));
			this.label27.ImageIndex = ((int)(resources.GetObject("label27.ImageIndex")));
			this.label27.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label27.ImeMode")));
			this.label27.Location = ((System.Drawing.Point)(resources.GetObject("label27.Location")));
			this.label27.Name = "label27";
			this.label27.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label27.RightToLeft")));
			this.label27.Size = ((System.Drawing.Size)(resources.GetObject("label27.Size")));
			this.label27.TabIndex = ((int)(resources.GetObject("label27.TabIndex")));
			this.label27.Text = resources.GetString("label27.Text");
			this.label27.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label27.TextAlign")));
			this.toolTip1.SetToolTip(this.label27, resources.GetString("label27.ToolTip"));
			this.label27.Visible = ((bool)(resources.GetObject("label27.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label27, true);
			// 
			// label26
			// 
			this.label26.AccessibleDescription = resources.GetString("label26.AccessibleDescription");
			this.label26.AccessibleName = resources.GetString("label26.AccessibleName");
			this.label26.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label26.Anchor")));
			this.label26.AutoSize = ((bool)(resources.GetObject("label26.AutoSize")));
			this.label26.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label26.Dock")));
			this.label26.Enabled = ((bool)(resources.GetObject("label26.Enabled")));
			this.label26.Font = ((System.Drawing.Font)(resources.GetObject("label26.Font")));
			this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
			this.label26.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label26.ImageAlign")));
			this.label26.ImageIndex = ((int)(resources.GetObject("label26.ImageIndex")));
			this.label26.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label26.ImeMode")));
			this.label26.Location = ((System.Drawing.Point)(resources.GetObject("label26.Location")));
			this.label26.Name = "label26";
			this.label26.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label26.RightToLeft")));
			this.label26.Size = ((System.Drawing.Size)(resources.GetObject("label26.Size")));
			this.label26.TabIndex = ((int)(resources.GetObject("label26.TabIndex")));
			this.label26.Text = resources.GetString("label26.Text");
			this.label26.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label26.TextAlign")));
			this.toolTip1.SetToolTip(this.label26, resources.GetString("label26.ToolTip"));
			this.label26.Visible = ((bool)(resources.GetObject("label26.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label26, true);
			// 
			// label25
			// 
			this.label25.AccessibleDescription = resources.GetString("label25.AccessibleDescription");
			this.label25.AccessibleName = resources.GetString("label25.AccessibleName");
			this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label25.Anchor")));
			this.label25.AutoSize = ((bool)(resources.GetObject("label25.AutoSize")));
			this.label25.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label25.Dock")));
			this.label25.Enabled = ((bool)(resources.GetObject("label25.Enabled")));
			this.label25.Font = ((System.Drawing.Font)(resources.GetObject("label25.Font")));
			this.label25.Image = ((System.Drawing.Image)(resources.GetObject("label25.Image")));
			this.label25.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label25.ImageAlign")));
			this.label25.ImageIndex = ((int)(resources.GetObject("label25.ImageIndex")));
			this.label25.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label25.ImeMode")));
			this.label25.Location = ((System.Drawing.Point)(resources.GetObject("label25.Location")));
			this.label25.Name = "label25";
			this.label25.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label25.RightToLeft")));
			this.label25.Size = ((System.Drawing.Size)(resources.GetObject("label25.Size")));
			this.label25.TabIndex = ((int)(resources.GetObject("label25.TabIndex")));
			this.label25.Text = resources.GetString("label25.Text");
			this.label25.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label25.TextAlign")));
			this.toolTip1.SetToolTip(this.label25, resources.GetString("label25.ToolTip"));
			this.label25.Visible = ((bool)(resources.GetObject("label25.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label25, true);
			// 
			// label24
			// 
			this.label24.AccessibleDescription = resources.GetString("label24.AccessibleDescription");
			this.label24.AccessibleName = resources.GetString("label24.AccessibleName");
			this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label24.Anchor")));
			this.label24.AutoSize = ((bool)(resources.GetObject("label24.AutoSize")));
			this.label24.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label24.Dock")));
			this.label24.Enabled = ((bool)(resources.GetObject("label24.Enabled")));
			this.label24.Font = ((System.Drawing.Font)(resources.GetObject("label24.Font")));
			this.label24.Image = ((System.Drawing.Image)(resources.GetObject("label24.Image")));
			this.label24.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label24.ImageAlign")));
			this.label24.ImageIndex = ((int)(resources.GetObject("label24.ImageIndex")));
			this.label24.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label24.ImeMode")));
			this.label24.Location = ((System.Drawing.Point)(resources.GetObject("label24.Location")));
			this.label24.Name = "label24";
			this.label24.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label24.RightToLeft")));
			this.label24.Size = ((System.Drawing.Size)(resources.GetObject("label24.Size")));
			this.label24.TabIndex = ((int)(resources.GetObject("label24.TabIndex")));
			this.label24.Text = resources.GetString("label24.Text");
			this.label24.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label24.TextAlign")));
			this.toolTip1.SetToolTip(this.label24, resources.GetString("label24.ToolTip"));
			this.label24.Visible = ((bool)(resources.GetObject("label24.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label24, true);
			// 
			// label23
			// 
			this.label23.AccessibleDescription = resources.GetString("label23.AccessibleDescription");
			this.label23.AccessibleName = resources.GetString("label23.AccessibleName");
			this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label23.Anchor")));
			this.label23.AutoSize = ((bool)(resources.GetObject("label23.AutoSize")));
			this.label23.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label23.Dock")));
			this.label23.Enabled = ((bool)(resources.GetObject("label23.Enabled")));
			this.label23.Font = ((System.Drawing.Font)(resources.GetObject("label23.Font")));
			this.label23.Image = ((System.Drawing.Image)(resources.GetObject("label23.Image")));
			this.label23.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label23.ImageAlign")));
			this.label23.ImageIndex = ((int)(resources.GetObject("label23.ImageIndex")));
			this.label23.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label23.ImeMode")));
			this.label23.Location = ((System.Drawing.Point)(resources.GetObject("label23.Location")));
			this.label23.Name = "label23";
			this.label23.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label23.RightToLeft")));
			this.label23.Size = ((System.Drawing.Size)(resources.GetObject("label23.Size")));
			this.label23.TabIndex = ((int)(resources.GetObject("label23.TabIndex")));
			this.label23.Text = resources.GetString("label23.Text");
			this.label23.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label23.TextAlign")));
			this.toolTip1.SetToolTip(this.label23, resources.GetString("label23.ToolTip"));
			this.label23.Visible = ((bool)(resources.GetObject("label23.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label23, true);
			// 
			// label22
			// 
			this.label22.AccessibleDescription = resources.GetString("label22.AccessibleDescription");
			this.label22.AccessibleName = resources.GetString("label22.AccessibleName");
			this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label22.Anchor")));
			this.label22.AutoSize = ((bool)(resources.GetObject("label22.AutoSize")));
			this.label22.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label22.Dock")));
			this.label22.Enabled = ((bool)(resources.GetObject("label22.Enabled")));
			this.label22.Font = ((System.Drawing.Font)(resources.GetObject("label22.Font")));
			this.label22.Image = ((System.Drawing.Image)(resources.GetObject("label22.Image")));
			this.label22.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label22.ImageAlign")));
			this.label22.ImageIndex = ((int)(resources.GetObject("label22.ImageIndex")));
			this.label22.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label22.ImeMode")));
			this.label22.Location = ((System.Drawing.Point)(resources.GetObject("label22.Location")));
			this.label22.Name = "label22";
			this.label22.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label22.RightToLeft")));
			this.label22.Size = ((System.Drawing.Size)(resources.GetObject("label22.Size")));
			this.label22.TabIndex = ((int)(resources.GetObject("label22.TabIndex")));
			this.label22.Text = resources.GetString("label22.Text");
			this.label22.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label22.TextAlign")));
			this.toolTip1.SetToolTip(this.label22, resources.GetString("label22.ToolTip"));
			this.label22.Visible = ((bool)(resources.GetObject("label22.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label22, true);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AccessibleDescription = resources.GetString("linkLabel2.AccessibleDescription");
			this.linkLabel2.AccessibleName = resources.GetString("linkLabel2.AccessibleName");
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel2.Anchor")));
			this.linkLabel2.AutoSize = ((bool)(resources.GetObject("linkLabel2.AutoSize")));
			this.linkLabel2.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel2.Dock")));
			this.linkLabel2.Enabled = ((bool)(resources.GetObject("linkLabel2.Enabled")));
			this.linkLabel2.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel2.Font")));
			this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
			this.linkLabel2.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.ImageAlign")));
			this.linkLabel2.ImageIndex = ((int)(resources.GetObject("linkLabel2.ImageIndex")));
			this.linkLabel2.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel2.ImeMode")));
			this.linkLabel2.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel2.LinkArea")));
			this.linkLabel2.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel2.Location")));
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel2.RightToLeft")));
			this.linkLabel2.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel2.Size")));
			this.linkLabel2.TabIndex = ((int)(resources.GetObject("linkLabel2.TabIndex")));
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = resources.GetString("linkLabel2.Text");
			this.linkLabel2.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel2.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel2, resources.GetString("linkLabel2.ToolTip"));
			this.linkLabel2.Visible = ((bool)(resources.GetObject("linkLabel2.Visible")));
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SkillsProgressMaxClick);
			// 
			// tbext
			// 
			this.tbext.AccessibleDescription = resources.GetString("tbext.AccessibleDescription");
			this.tbext.AccessibleName = resources.GetString("tbext.AccessibleName");
			this.tbext.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbext.Anchor")));
			this.tbext.AutoScroll = ((bool)(resources.GetObject("tbext.AutoScroll")));
			this.tbext.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbext.AutoScrollMargin")));
			this.tbext.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbext.AutoScrollMinSize")));
			this.tbext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbext.BackgroundImage")));
			this.tbext.Controls.Add(this.groupBox3);
			this.tbext.Controls.Add(this.groupBox1);
			this.tbext.Controls.Add(this.gbdecay);
			this.tbext.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbext.Dock")));
			this.tbext.Enabled = ((bool)(resources.GetObject("tbext.Enabled")));
			this.tbext.Font = ((System.Drawing.Font)(resources.GetObject("tbext.Font")));
			this.tbext.ImageIndex = ((int)(resources.GetObject("tbext.ImageIndex")));
			this.tbext.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbext.ImeMode")));
			this.tbext.Location = ((System.Drawing.Point)(resources.GetObject("tbext.Location")));
			this.tbext.Name = "tbext";
			this.tbext.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbext.RightToLeft")));
			this.tbext.Size = ((System.Drawing.Size)(resources.GetObject("tbext.Size")));
			this.tbext.TabIndex = ((int)(resources.GetObject("tbext.TabIndex")));
			this.tbext.Text = resources.GetString("tbext.Text");
			this.toolTip1.SetToolTip(this.tbext, resources.GetString("tbext.ToolTip"));
			this.tbext.ToolTipText = resources.GetString("tbext.ToolTipText");
			this.tbext.Visible = ((bool)(resources.GetObject("tbext.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbext, true);
			// 
			// groupBox3
			// 
			this.groupBox3.AccessibleDescription = resources.GetString("groupBox3.AccessibleDescription");
			this.groupBox3.AccessibleName = resources.GetString("groupBox3.AccessibleName");
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox3.Anchor")));
			this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
			this.groupBox3.Controls.Add(this.cbfit);
			this.groupBox3.Controls.Add(this.cbpreginv);
			this.groupBox3.Controls.Add(this.cbpreghalf);
			this.groupBox3.Controls.Add(this.cbpregfull);
			this.groupBox3.Controls.Add(this.cbfat);
			this.groupBox3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox3.Dock")));
			this.groupBox3.Enabled = ((bool)(resources.GetObject("groupBox3.Enabled")));
			this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox3.Font = ((System.Drawing.Font)(resources.GetObject("groupBox3.Font")));
			this.groupBox3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox3.ImeMode")));
			this.groupBox3.Location = ((System.Drawing.Point)(resources.GetObject("groupBox3.Location")));
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox3.RightToLeft")));
			this.groupBox3.Size = ((System.Drawing.Size)(resources.GetObject("groupBox3.Size")));
			this.groupBox3.TabIndex = ((int)(resources.GetObject("groupBox3.TabIndex")));
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = resources.GetString("groupBox3.Text");
			this.toolTip1.SetToolTip(this.groupBox3, resources.GetString("groupBox3.ToolTip"));
			this.groupBox3.Visible = ((bool)(resources.GetObject("groupBox3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox3, true);
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
			this.toolTip1.SetToolTip(this.cbfit, resources.GetString("cbfit.ToolTip"));
			this.cbfit.Visible = ((bool)(resources.GetObject("cbfit.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfit, true);
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
			this.toolTip1.SetToolTip(this.cbpreginv, resources.GetString("cbpreginv.ToolTip"));
			this.cbpreginv.Visible = ((bool)(resources.GetObject("cbpreginv.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpreginv, true);
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
			this.toolTip1.SetToolTip(this.cbpreghalf, resources.GetString("cbpreghalf.ToolTip"));
			this.cbpreghalf.Visible = ((bool)(resources.GetObject("cbpreghalf.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpreghalf, true);
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
			this.toolTip1.SetToolTip(this.cbpregfull, resources.GetString("cbpregfull.ToolTip"));
			this.cbpregfull.Visible = ((bool)(resources.GetObject("cbpregfull.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbpregfull, true);
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
			this.toolTip1.SetToolTip(this.cbfat, resources.GetString("cbfat.ToolTip"));
			this.cbfat.Visible = ((bool)(resources.GetObject("cbfat.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfat, true);
			// 
			// groupBox1
			// 
			this.groupBox1.AccessibleDescription = resources.GetString("groupBox1.AccessibleDescription");
			this.groupBox1.AccessibleName = resources.GetString("groupBox1.AccessibleName");
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("groupBox1.Anchor")));
			this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
			this.groupBox1.Controls.Add(this.label96);
			this.groupBox1.Controls.Add(this.tbunlinked);
			this.groupBox1.Controls.Add(this.label95);
			this.groupBox1.Controls.Add(this.tbagedur);
			this.groupBox1.Controls.Add(this.tbprevdays);
			this.groupBox1.Controls.Add(this.label94);
			this.groupBox1.Controls.Add(this.tbvoice);
			this.groupBox1.Controls.Add(this.label90);
			this.groupBox1.Controls.Add(this.tbnpc);
			this.groupBox1.Controls.Add(this.label87);
			this.groupBox1.Controls.Add(this.tbautonomy);
			this.groupBox1.Controls.Add(this.label86);
			this.groupBox1.Controls.Add(this.llmore);
			this.groupBox1.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("groupBox1.Dock")));
			this.groupBox1.Enabled = ((bool)(resources.GetObject("groupBox1.Enabled")));
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Font = ((System.Drawing.Font)(resources.GetObject("groupBox1.Font")));
			this.groupBox1.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("groupBox1.ImeMode")));
			this.groupBox1.Location = ((System.Drawing.Point)(resources.GetObject("groupBox1.Location")));
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("groupBox1.RightToLeft")));
			this.groupBox1.Size = ((System.Drawing.Size)(resources.GetObject("groupBox1.Size")));
			this.groupBox1.TabIndex = ((int)(resources.GetObject("groupBox1.TabIndex")));
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = resources.GetString("groupBox1.Text");
			this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
			this.groupBox1.Visible = ((bool)(resources.GetObject("groupBox1.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.groupBox1, true);
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
			this.toolTip1.SetToolTip(this.label96, resources.GetString("label96.ToolTip"));
			this.label96.Visible = ((bool)(resources.GetObject("label96.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label96, true);
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
			this.toolTip1.SetToolTip(this.tbunlinked, resources.GetString("tbunlinked.ToolTip"));
			this.tbunlinked.Visible = ((bool)(resources.GetObject("tbunlinked.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbunlinked, true);
			this.tbunlinked.WordWrap = ((bool)(resources.GetObject("tbunlinked.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label95, resources.GetString("label95.ToolTip"));
			this.label95.Visible = ((bool)(resources.GetObject("label95.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label95, true);
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
			this.toolTip1.SetToolTip(this.tbagedur, resources.GetString("tbagedur.ToolTip"));
			this.tbagedur.Visible = ((bool)(resources.GetObject("tbagedur.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbagedur, true);
			this.tbagedur.WordWrap = ((bool)(resources.GetObject("tbagedur.WordWrap")));
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
			this.toolTip1.SetToolTip(this.tbprevdays, resources.GetString("tbprevdays.ToolTip"));
			this.tbprevdays.Visible = ((bool)(resources.GetObject("tbprevdays.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbprevdays, true);
			this.tbprevdays.WordWrap = ((bool)(resources.GetObject("tbprevdays.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label94, resources.GetString("label94.ToolTip"));
			this.label94.Visible = ((bool)(resources.GetObject("label94.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label94, true);
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
			this.toolTip1.SetToolTip(this.tbvoice, resources.GetString("tbvoice.ToolTip"));
			this.tbvoice.Visible = ((bool)(resources.GetObject("tbvoice.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbvoice, true);
			this.tbvoice.WordWrap = ((bool)(resources.GetObject("tbvoice.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label90, resources.GetString("label90.ToolTip"));
			this.label90.Visible = ((bool)(resources.GetObject("label90.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label90, true);
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
			this.toolTip1.SetToolTip(this.tbnpc, resources.GetString("tbnpc.ToolTip"));
			this.tbnpc.Visible = ((bool)(resources.GetObject("tbnpc.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbnpc, true);
			this.tbnpc.WordWrap = ((bool)(resources.GetObject("tbnpc.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label87, resources.GetString("label87.ToolTip"));
			this.label87.Visible = ((bool)(resources.GetObject("label87.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label87, true);
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
			this.toolTip1.SetToolTip(this.tbautonomy, resources.GetString("tbautonomy.ToolTip"));
			this.tbautonomy.Visible = ((bool)(resources.GetObject("tbautonomy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbautonomy, true);
			this.tbautonomy.WordWrap = ((bool)(resources.GetObject("tbautonomy.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label86, resources.GetString("label86.ToolTip"));
			this.label86.Visible = ((bool)(resources.GetObject("label86.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label86, true);
			// 
			// gbdecay
			// 
			this.gbdecay.AccessibleDescription = resources.GetString("gbdecay.AccessibleDescription");
			this.gbdecay.AccessibleName = resources.GetString("gbdecay.AccessibleName");
			this.gbdecay.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbdecay.Anchor")));
			this.gbdecay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbdecay.BackgroundImage")));
			this.gbdecay.Controls.Add(this.pbfun);
			this.gbdecay.Controls.Add(this.label85);
			this.gbdecay.Controls.Add(this.tbfun);
			this.gbdecay.Controls.Add(this.pbsocial);
			this.gbdecay.Controls.Add(this.label84);
			this.gbdecay.Controls.Add(this.tbsocial);
			this.gbdecay.Controls.Add(this.pbhygiene);
			this.gbdecay.Controls.Add(this.label83);
			this.gbdecay.Controls.Add(this.tbhygiene);
			this.gbdecay.Controls.Add(this.pbenergy);
			this.gbdecay.Controls.Add(this.label82);
			this.gbdecay.Controls.Add(this.tbenergy);
			this.gbdecay.Controls.Add(this.pbbladder);
			this.gbdecay.Controls.Add(this.label81);
			this.gbdecay.Controls.Add(this.tbbladder);
			this.gbdecay.Controls.Add(this.pbcomfort);
			this.gbdecay.Controls.Add(this.label80);
			this.gbdecay.Controls.Add(this.tbcomfort);
			this.gbdecay.Controls.Add(this.pbhunger);
			this.gbdecay.Controls.Add(this.label79);
			this.gbdecay.Controls.Add(this.tbhunger);
			this.gbdecay.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbdecay.Dock")));
			this.gbdecay.Enabled = ((bool)(resources.GetObject("gbdecay.Enabled")));
			this.gbdecay.Font = ((System.Drawing.Font)(resources.GetObject("gbdecay.Font")));
			this.gbdecay.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbdecay.ImeMode")));
			this.gbdecay.Location = ((System.Drawing.Point)(resources.GetObject("gbdecay.Location")));
			this.gbdecay.Name = "gbdecay";
			this.gbdecay.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbdecay.RightToLeft")));
			this.gbdecay.Size = ((System.Drawing.Size)(resources.GetObject("gbdecay.Size")));
			this.gbdecay.TabIndex = ((int)(resources.GetObject("gbdecay.TabIndex")));
			this.gbdecay.TabStop = false;
			this.gbdecay.Text = resources.GetString("gbdecay.Text");
			this.toolTip1.SetToolTip(this.gbdecay, resources.GetString("gbdecay.ToolTip"));
			this.gbdecay.Visible = ((bool)(resources.GetObject("gbdecay.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbdecay, true);
			// 
			// pbfun
			// 
			this.pbfun.AccessibleDescription = resources.GetString("pbfun.AccessibleDescription");
			this.pbfun.AccessibleName = resources.GetString("pbfun.AccessibleName");
			this.pbfun.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbfun.Anchor")));
			this.pbfun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbfun.BackgroundImage")));
			this.pbfun.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbfun.Dock")));
			this.pbfun.Enabled = ((bool)(resources.GetObject("pbfun.Enabled")));
			this.pbfun.Font = ((System.Drawing.Font)(resources.GetObject("pbfun.Font")));
			this.pbfun.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbfun.ImeMode")));
			this.pbfun.Location = ((System.Drawing.Point)(resources.GetObject("pbfun.Location")));
			this.pbfun.Maximum = 2000;
			this.pbfun.Name = "pbfun";
			this.pbfun.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbfun.RightToLeft")));
			this.pbfun.Size = ((System.Drawing.Size)(resources.GetObject("pbfun.Size")));
			this.pbfun.Step = 1;
			this.pbfun.TabIndex = ((int)(resources.GetObject("pbfun.TabIndex")));
			this.pbfun.Tag = "500";
			this.pbfun.Text = resources.GetString("pbfun.Text");
			this.toolTip1.SetToolTip(this.pbfun, resources.GetString("pbfun.ToolTip"));
			this.pbfun.Visible = ((bool)(resources.GetObject("pbfun.Visible")));
			this.pbfun.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileNameMouseUp);
			this.pbfun.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbfun.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label85
			// 
			this.label85.AccessibleDescription = resources.GetString("label85.AccessibleDescription");
			this.label85.AccessibleName = resources.GetString("label85.AccessibleName");
			this.label85.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label85.Anchor")));
			this.label85.AutoSize = ((bool)(resources.GetObject("label85.AutoSize")));
			this.label85.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label85.Dock")));
			this.label85.Enabled = ((bool)(resources.GetObject("label85.Enabled")));
			this.label85.Font = ((System.Drawing.Font)(resources.GetObject("label85.Font")));
			this.label85.Image = ((System.Drawing.Image)(resources.GetObject("label85.Image")));
			this.label85.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label85.ImageAlign")));
			this.label85.ImageIndex = ((int)(resources.GetObject("label85.ImageIndex")));
			this.label85.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label85.ImeMode")));
			this.label85.Location = ((System.Drawing.Point)(resources.GetObject("label85.Location")));
			this.label85.Name = "label85";
			this.label85.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label85.RightToLeft")));
			this.label85.Size = ((System.Drawing.Size)(resources.GetObject("label85.Size")));
			this.label85.TabIndex = ((int)(resources.GetObject("label85.TabIndex")));
			this.label85.Text = resources.GetString("label85.Text");
			this.label85.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label85.TextAlign")));
			this.toolTip1.SetToolTip(this.label85, resources.GetString("label85.ToolTip"));
			this.label85.Visible = ((bool)(resources.GetObject("label85.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label85, true);
			// 
			// tbfun
			// 
			this.tbfun.AccessibleDescription = resources.GetString("tbfun.AccessibleDescription");
			this.tbfun.AccessibleName = resources.GetString("tbfun.AccessibleName");
			this.tbfun.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbfun.Anchor")));
			this.tbfun.AutoSize = ((bool)(resources.GetObject("tbfun.AutoSize")));
			this.tbfun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbfun.BackgroundImage")));
			this.tbfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbfun.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbfun.Dock")));
			this.tbfun.Enabled = ((bool)(resources.GetObject("tbfun.Enabled")));
			this.tbfun.Font = ((System.Drawing.Font)(resources.GetObject("tbfun.Font")));
			this.tbfun.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbfun.ImeMode")));
			this.tbfun.Location = ((System.Drawing.Point)(resources.GetObject("tbfun.Location")));
			this.tbfun.MaxLength = ((int)(resources.GetObject("tbfun.MaxLength")));
			this.tbfun.Multiline = ((bool)(resources.GetObject("tbfun.Multiline")));
			this.tbfun.Name = "tbfun";
			this.tbfun.PasswordChar = ((char)(resources.GetObject("tbfun.PasswordChar")));
			this.tbfun.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbfun.RightToLeft")));
			this.tbfun.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbfun.ScrollBars")));
			this.tbfun.Size = ((System.Drawing.Size)(resources.GetObject("tbfun.Size")));
			this.tbfun.TabIndex = ((int)(resources.GetObject("tbfun.TabIndex")));
			this.tbfun.Text = resources.GetString("tbfun.Text");
			this.tbfun.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbfun.TextAlign")));
			this.toolTip1.SetToolTip(this.tbfun, resources.GetString("tbfun.ToolTip"));
			this.tbfun.Visible = ((bool)(resources.GetObject("tbfun.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfun, true);
			this.tbfun.WordWrap = ((bool)(resources.GetObject("tbfun.WordWrap")));
			this.tbfun.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbfun.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbsocial
			// 
			this.pbsocial.AccessibleDescription = resources.GetString("pbsocial.AccessibleDescription");
			this.pbsocial.AccessibleName = resources.GetString("pbsocial.AccessibleName");
			this.pbsocial.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbsocial.Anchor")));
			this.pbsocial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbsocial.BackgroundImage")));
			this.pbsocial.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbsocial.Dock")));
			this.pbsocial.Enabled = ((bool)(resources.GetObject("pbsocial.Enabled")));
			this.pbsocial.Font = ((System.Drawing.Font)(resources.GetObject("pbsocial.Font")));
			this.pbsocial.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbsocial.ImeMode")));
			this.pbsocial.Location = ((System.Drawing.Point)(resources.GetObject("pbsocial.Location")));
			this.pbsocial.Maximum = 2000;
			this.pbsocial.Name = "pbsocial";
			this.pbsocial.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbsocial.RightToLeft")));
			this.pbsocial.Size = ((System.Drawing.Size)(resources.GetObject("pbsocial.Size")));
			this.pbsocial.Step = 1;
			this.pbsocial.TabIndex = ((int)(resources.GetObject("pbsocial.TabIndex")));
			this.pbsocial.Tag = "500";
			this.pbsocial.Text = resources.GetString("pbsocial.Text");
			this.toolTip1.SetToolTip(this.pbsocial, resources.GetString("pbsocial.ToolTip"));
			this.pbsocial.Visible = ((bool)(resources.GetObject("pbsocial.Visible")));
			this.pbsocial.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbsocial.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbsocial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label84
			// 
			this.label84.AccessibleDescription = resources.GetString("label84.AccessibleDescription");
			this.label84.AccessibleName = resources.GetString("label84.AccessibleName");
			this.label84.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label84.Anchor")));
			this.label84.AutoSize = ((bool)(resources.GetObject("label84.AutoSize")));
			this.label84.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label84.Dock")));
			this.label84.Enabled = ((bool)(resources.GetObject("label84.Enabled")));
			this.label84.Font = ((System.Drawing.Font)(resources.GetObject("label84.Font")));
			this.label84.Image = ((System.Drawing.Image)(resources.GetObject("label84.Image")));
			this.label84.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label84.ImageAlign")));
			this.label84.ImageIndex = ((int)(resources.GetObject("label84.ImageIndex")));
			this.label84.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label84.ImeMode")));
			this.label84.Location = ((System.Drawing.Point)(resources.GetObject("label84.Location")));
			this.label84.Name = "label84";
			this.label84.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label84.RightToLeft")));
			this.label84.Size = ((System.Drawing.Size)(resources.GetObject("label84.Size")));
			this.label84.TabIndex = ((int)(resources.GetObject("label84.TabIndex")));
			this.label84.Text = resources.GetString("label84.Text");
			this.label84.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label84.TextAlign")));
			this.toolTip1.SetToolTip(this.label84, resources.GetString("label84.ToolTip"));
			this.label84.Visible = ((bool)(resources.GetObject("label84.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label84, true);
			// 
			// tbsocial
			// 
			this.tbsocial.AccessibleDescription = resources.GetString("tbsocial.AccessibleDescription");
			this.tbsocial.AccessibleName = resources.GetString("tbsocial.AccessibleName");
			this.tbsocial.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbsocial.Anchor")));
			this.tbsocial.AutoSize = ((bool)(resources.GetObject("tbsocial.AutoSize")));
			this.tbsocial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbsocial.BackgroundImage")));
			this.tbsocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbsocial.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbsocial.Dock")));
			this.tbsocial.Enabled = ((bool)(resources.GetObject("tbsocial.Enabled")));
			this.tbsocial.Font = ((System.Drawing.Font)(resources.GetObject("tbsocial.Font")));
			this.tbsocial.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbsocial.ImeMode")));
			this.tbsocial.Location = ((System.Drawing.Point)(resources.GetObject("tbsocial.Location")));
			this.tbsocial.MaxLength = ((int)(resources.GetObject("tbsocial.MaxLength")));
			this.tbsocial.Multiline = ((bool)(resources.GetObject("tbsocial.Multiline")));
			this.tbsocial.Name = "tbsocial";
			this.tbsocial.PasswordChar = ((char)(resources.GetObject("tbsocial.PasswordChar")));
			this.tbsocial.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbsocial.RightToLeft")));
			this.tbsocial.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbsocial.ScrollBars")));
			this.tbsocial.Size = ((System.Drawing.Size)(resources.GetObject("tbsocial.Size")));
			this.tbsocial.TabIndex = ((int)(resources.GetObject("tbsocial.TabIndex")));
			this.tbsocial.Text = resources.GetString("tbsocial.Text");
			this.tbsocial.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbsocial.TextAlign")));
			this.toolTip1.SetToolTip(this.tbsocial, resources.GetString("tbsocial.ToolTip"));
			this.tbsocial.Visible = ((bool)(resources.GetObject("tbsocial.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsocial, true);
			this.tbsocial.WordWrap = ((bool)(resources.GetObject("tbsocial.WordWrap")));
			this.tbsocial.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbsocial.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbhygiene
			// 
			this.pbhygiene.AccessibleDescription = resources.GetString("pbhygiene.AccessibleDescription");
			this.pbhygiene.AccessibleName = resources.GetString("pbhygiene.AccessibleName");
			this.pbhygiene.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbhygiene.Anchor")));
			this.pbhygiene.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbhygiene.BackgroundImage")));
			this.pbhygiene.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbhygiene.Dock")));
			this.pbhygiene.Enabled = ((bool)(resources.GetObject("pbhygiene.Enabled")));
			this.pbhygiene.Font = ((System.Drawing.Font)(resources.GetObject("pbhygiene.Font")));
			this.pbhygiene.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbhygiene.ImeMode")));
			this.pbhygiene.Location = ((System.Drawing.Point)(resources.GetObject("pbhygiene.Location")));
			this.pbhygiene.Maximum = 2000;
			this.pbhygiene.Name = "pbhygiene";
			this.pbhygiene.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbhygiene.RightToLeft")));
			this.pbhygiene.Size = ((System.Drawing.Size)(resources.GetObject("pbhygiene.Size")));
			this.pbhygiene.Step = 1;
			this.pbhygiene.TabIndex = ((int)(resources.GetObject("pbhygiene.TabIndex")));
			this.pbhygiene.Tag = "500";
			this.pbhygiene.Text = resources.GetString("pbhygiene.Text");
			this.toolTip1.SetToolTip(this.pbhygiene, resources.GetString("pbhygiene.ToolTip"));
			this.pbhygiene.Visible = ((bool)(resources.GetObject("pbhygiene.Visible")));
			this.pbhygiene.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbhygiene.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbhygiene.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label83
			// 
			this.label83.AccessibleDescription = resources.GetString("label83.AccessibleDescription");
			this.label83.AccessibleName = resources.GetString("label83.AccessibleName");
			this.label83.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label83.Anchor")));
			this.label83.AutoSize = ((bool)(resources.GetObject("label83.AutoSize")));
			this.label83.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label83.Dock")));
			this.label83.Enabled = ((bool)(resources.GetObject("label83.Enabled")));
			this.label83.Font = ((System.Drawing.Font)(resources.GetObject("label83.Font")));
			this.label83.Image = ((System.Drawing.Image)(resources.GetObject("label83.Image")));
			this.label83.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label83.ImageAlign")));
			this.label83.ImageIndex = ((int)(resources.GetObject("label83.ImageIndex")));
			this.label83.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label83.ImeMode")));
			this.label83.Location = ((System.Drawing.Point)(resources.GetObject("label83.Location")));
			this.label83.Name = "label83";
			this.label83.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label83.RightToLeft")));
			this.label83.Size = ((System.Drawing.Size)(resources.GetObject("label83.Size")));
			this.label83.TabIndex = ((int)(resources.GetObject("label83.TabIndex")));
			this.label83.Text = resources.GetString("label83.Text");
			this.label83.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label83.TextAlign")));
			this.toolTip1.SetToolTip(this.label83, resources.GetString("label83.ToolTip"));
			this.label83.Visible = ((bool)(resources.GetObject("label83.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label83, true);
			// 
			// tbhygiene
			// 
			this.tbhygiene.AccessibleDescription = resources.GetString("tbhygiene.AccessibleDescription");
			this.tbhygiene.AccessibleName = resources.GetString("tbhygiene.AccessibleName");
			this.tbhygiene.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbhygiene.Anchor")));
			this.tbhygiene.AutoSize = ((bool)(resources.GetObject("tbhygiene.AutoSize")));
			this.tbhygiene.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbhygiene.BackgroundImage")));
			this.tbhygiene.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbhygiene.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbhygiene.Dock")));
			this.tbhygiene.Enabled = ((bool)(resources.GetObject("tbhygiene.Enabled")));
			this.tbhygiene.Font = ((System.Drawing.Font)(resources.GetObject("tbhygiene.Font")));
			this.tbhygiene.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbhygiene.ImeMode")));
			this.tbhygiene.Location = ((System.Drawing.Point)(resources.GetObject("tbhygiene.Location")));
			this.tbhygiene.MaxLength = ((int)(resources.GetObject("tbhygiene.MaxLength")));
			this.tbhygiene.Multiline = ((bool)(resources.GetObject("tbhygiene.Multiline")));
			this.tbhygiene.Name = "tbhygiene";
			this.tbhygiene.PasswordChar = ((char)(resources.GetObject("tbhygiene.PasswordChar")));
			this.tbhygiene.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbhygiene.RightToLeft")));
			this.tbhygiene.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbhygiene.ScrollBars")));
			this.tbhygiene.Size = ((System.Drawing.Size)(resources.GetObject("tbhygiene.Size")));
			this.tbhygiene.TabIndex = ((int)(resources.GetObject("tbhygiene.TabIndex")));
			this.tbhygiene.Text = resources.GetString("tbhygiene.Text");
			this.tbhygiene.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbhygiene.TextAlign")));
			this.toolTip1.SetToolTip(this.tbhygiene, resources.GetString("tbhygiene.ToolTip"));
			this.tbhygiene.Visible = ((bool)(resources.GetObject("tbhygiene.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbhygiene, true);
			this.tbhygiene.WordWrap = ((bool)(resources.GetObject("tbhygiene.WordWrap")));
			this.tbhygiene.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbhygiene.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbenergy
			// 
			this.pbenergy.AccessibleDescription = resources.GetString("pbenergy.AccessibleDescription");
			this.pbenergy.AccessibleName = resources.GetString("pbenergy.AccessibleName");
			this.pbenergy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbenergy.Anchor")));
			this.pbenergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbenergy.BackgroundImage")));
			this.pbenergy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbenergy.Dock")));
			this.pbenergy.Enabled = ((bool)(resources.GetObject("pbenergy.Enabled")));
			this.pbenergy.Font = ((System.Drawing.Font)(resources.GetObject("pbenergy.Font")));
			this.pbenergy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbenergy.ImeMode")));
			this.pbenergy.Location = ((System.Drawing.Point)(resources.GetObject("pbenergy.Location")));
			this.pbenergy.Maximum = 2000;
			this.pbenergy.Name = "pbenergy";
			this.pbenergy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbenergy.RightToLeft")));
			this.pbenergy.Size = ((System.Drawing.Size)(resources.GetObject("pbenergy.Size")));
			this.pbenergy.Step = 1;
			this.pbenergy.TabIndex = ((int)(resources.GetObject("pbenergy.TabIndex")));
			this.pbenergy.Tag = "500";
			this.pbenergy.Text = resources.GetString("pbenergy.Text");
			this.toolTip1.SetToolTip(this.pbenergy, resources.GetString("pbenergy.ToolTip"));
			this.pbenergy.Visible = ((bool)(resources.GetObject("pbenergy.Visible")));
			this.pbenergy.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbenergy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbenergy.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label82
			// 
			this.label82.AccessibleDescription = resources.GetString("label82.AccessibleDescription");
			this.label82.AccessibleName = resources.GetString("label82.AccessibleName");
			this.label82.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label82.Anchor")));
			this.label82.AutoSize = ((bool)(resources.GetObject("label82.AutoSize")));
			this.label82.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label82.Dock")));
			this.label82.Enabled = ((bool)(resources.GetObject("label82.Enabled")));
			this.label82.Font = ((System.Drawing.Font)(resources.GetObject("label82.Font")));
			this.label82.Image = ((System.Drawing.Image)(resources.GetObject("label82.Image")));
			this.label82.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label82.ImageAlign")));
			this.label82.ImageIndex = ((int)(resources.GetObject("label82.ImageIndex")));
			this.label82.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label82.ImeMode")));
			this.label82.Location = ((System.Drawing.Point)(resources.GetObject("label82.Location")));
			this.label82.Name = "label82";
			this.label82.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label82.RightToLeft")));
			this.label82.Size = ((System.Drawing.Size)(resources.GetObject("label82.Size")));
			this.label82.TabIndex = ((int)(resources.GetObject("label82.TabIndex")));
			this.label82.Text = resources.GetString("label82.Text");
			this.label82.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label82.TextAlign")));
			this.toolTip1.SetToolTip(this.label82, resources.GetString("label82.ToolTip"));
			this.label82.Visible = ((bool)(resources.GetObject("label82.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label82, true);
			// 
			// tbenergy
			// 
			this.tbenergy.AccessibleDescription = resources.GetString("tbenergy.AccessibleDescription");
			this.tbenergy.AccessibleName = resources.GetString("tbenergy.AccessibleName");
			this.tbenergy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbenergy.Anchor")));
			this.tbenergy.AutoSize = ((bool)(resources.GetObject("tbenergy.AutoSize")));
			this.tbenergy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbenergy.BackgroundImage")));
			this.tbenergy.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbenergy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbenergy.Dock")));
			this.tbenergy.Enabled = ((bool)(resources.GetObject("tbenergy.Enabled")));
			this.tbenergy.Font = ((System.Drawing.Font)(resources.GetObject("tbenergy.Font")));
			this.tbenergy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbenergy.ImeMode")));
			this.tbenergy.Location = ((System.Drawing.Point)(resources.GetObject("tbenergy.Location")));
			this.tbenergy.MaxLength = ((int)(resources.GetObject("tbenergy.MaxLength")));
			this.tbenergy.Multiline = ((bool)(resources.GetObject("tbenergy.Multiline")));
			this.tbenergy.Name = "tbenergy";
			this.tbenergy.PasswordChar = ((char)(resources.GetObject("tbenergy.PasswordChar")));
			this.tbenergy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbenergy.RightToLeft")));
			this.tbenergy.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbenergy.ScrollBars")));
			this.tbenergy.Size = ((System.Drawing.Size)(resources.GetObject("tbenergy.Size")));
			this.tbenergy.TabIndex = ((int)(resources.GetObject("tbenergy.TabIndex")));
			this.tbenergy.Text = resources.GetString("tbenergy.Text");
			this.tbenergy.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbenergy.TextAlign")));
			this.toolTip1.SetToolTip(this.tbenergy, resources.GetString("tbenergy.ToolTip"));
			this.tbenergy.Visible = ((bool)(resources.GetObject("tbenergy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbenergy, true);
			this.tbenergy.WordWrap = ((bool)(resources.GetObject("tbenergy.WordWrap")));
			this.tbenergy.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbenergy.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbbladder
			// 
			this.pbbladder.AccessibleDescription = resources.GetString("pbbladder.AccessibleDescription");
			this.pbbladder.AccessibleName = resources.GetString("pbbladder.AccessibleName");
			this.pbbladder.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbbladder.Anchor")));
			this.pbbladder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbbladder.BackgroundImage")));
			this.pbbladder.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbbladder.Dock")));
			this.pbbladder.Enabled = ((bool)(resources.GetObject("pbbladder.Enabled")));
			this.pbbladder.Font = ((System.Drawing.Font)(resources.GetObject("pbbladder.Font")));
			this.pbbladder.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbbladder.ImeMode")));
			this.pbbladder.Location = ((System.Drawing.Point)(resources.GetObject("pbbladder.Location")));
			this.pbbladder.Maximum = 2000;
			this.pbbladder.Name = "pbbladder";
			this.pbbladder.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbbladder.RightToLeft")));
			this.pbbladder.Size = ((System.Drawing.Size)(resources.GetObject("pbbladder.Size")));
			this.pbbladder.Step = 1;
			this.pbbladder.TabIndex = ((int)(resources.GetObject("pbbladder.TabIndex")));
			this.pbbladder.Tag = "500";
			this.pbbladder.Text = resources.GetString("pbbladder.Text");
			this.toolTip1.SetToolTip(this.pbbladder, resources.GetString("pbbladder.ToolTip"));
			this.pbbladder.Visible = ((bool)(resources.GetObject("pbbladder.Visible")));
			this.pbbladder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbbladder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbbladder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label81
			// 
			this.label81.AccessibleDescription = resources.GetString("label81.AccessibleDescription");
			this.label81.AccessibleName = resources.GetString("label81.AccessibleName");
			this.label81.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label81.Anchor")));
			this.label81.AutoSize = ((bool)(resources.GetObject("label81.AutoSize")));
			this.label81.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label81.Dock")));
			this.label81.Enabled = ((bool)(resources.GetObject("label81.Enabled")));
			this.label81.Font = ((System.Drawing.Font)(resources.GetObject("label81.Font")));
			this.label81.Image = ((System.Drawing.Image)(resources.GetObject("label81.Image")));
			this.label81.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label81.ImageAlign")));
			this.label81.ImageIndex = ((int)(resources.GetObject("label81.ImageIndex")));
			this.label81.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label81.ImeMode")));
			this.label81.Location = ((System.Drawing.Point)(resources.GetObject("label81.Location")));
			this.label81.Name = "label81";
			this.label81.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label81.RightToLeft")));
			this.label81.Size = ((System.Drawing.Size)(resources.GetObject("label81.Size")));
			this.label81.TabIndex = ((int)(resources.GetObject("label81.TabIndex")));
			this.label81.Text = resources.GetString("label81.Text");
			this.label81.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label81.TextAlign")));
			this.toolTip1.SetToolTip(this.label81, resources.GetString("label81.ToolTip"));
			this.label81.Visible = ((bool)(resources.GetObject("label81.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label81, true);
			// 
			// tbbladder
			// 
			this.tbbladder.AccessibleDescription = resources.GetString("tbbladder.AccessibleDescription");
			this.tbbladder.AccessibleName = resources.GetString("tbbladder.AccessibleName");
			this.tbbladder.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbbladder.Anchor")));
			this.tbbladder.AutoSize = ((bool)(resources.GetObject("tbbladder.AutoSize")));
			this.tbbladder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbbladder.BackgroundImage")));
			this.tbbladder.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbbladder.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbbladder.Dock")));
			this.tbbladder.Enabled = ((bool)(resources.GetObject("tbbladder.Enabled")));
			this.tbbladder.Font = ((System.Drawing.Font)(resources.GetObject("tbbladder.Font")));
			this.tbbladder.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbbladder.ImeMode")));
			this.tbbladder.Location = ((System.Drawing.Point)(resources.GetObject("tbbladder.Location")));
			this.tbbladder.MaxLength = ((int)(resources.GetObject("tbbladder.MaxLength")));
			this.tbbladder.Multiline = ((bool)(resources.GetObject("tbbladder.Multiline")));
			this.tbbladder.Name = "tbbladder";
			this.tbbladder.PasswordChar = ((char)(resources.GetObject("tbbladder.PasswordChar")));
			this.tbbladder.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbbladder.RightToLeft")));
			this.tbbladder.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbbladder.ScrollBars")));
			this.tbbladder.Size = ((System.Drawing.Size)(resources.GetObject("tbbladder.Size")));
			this.tbbladder.TabIndex = ((int)(resources.GetObject("tbbladder.TabIndex")));
			this.tbbladder.Text = resources.GetString("tbbladder.Text");
			this.tbbladder.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbbladder.TextAlign")));
			this.toolTip1.SetToolTip(this.tbbladder, resources.GetString("tbbladder.ToolTip"));
			this.tbbladder.Visible = ((bool)(resources.GetObject("tbbladder.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbbladder, true);
			this.tbbladder.WordWrap = ((bool)(resources.GetObject("tbbladder.WordWrap")));
			this.tbbladder.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbbladder.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbcomfort
			// 
			this.pbcomfort.AccessibleDescription = resources.GetString("pbcomfort.AccessibleDescription");
			this.pbcomfort.AccessibleName = resources.GetString("pbcomfort.AccessibleName");
			this.pbcomfort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbcomfort.Anchor")));
			this.pbcomfort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbcomfort.BackgroundImage")));
			this.pbcomfort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbcomfort.Dock")));
			this.pbcomfort.Enabled = ((bool)(resources.GetObject("pbcomfort.Enabled")));
			this.pbcomfort.Font = ((System.Drawing.Font)(resources.GetObject("pbcomfort.Font")));
			this.pbcomfort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbcomfort.ImeMode")));
			this.pbcomfort.Location = ((System.Drawing.Point)(resources.GetObject("pbcomfort.Location")));
			this.pbcomfort.Maximum = 2000;
			this.pbcomfort.Name = "pbcomfort";
			this.pbcomfort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbcomfort.RightToLeft")));
			this.pbcomfort.Size = ((System.Drawing.Size)(resources.GetObject("pbcomfort.Size")));
			this.pbcomfort.Step = 1;
			this.pbcomfort.TabIndex = ((int)(resources.GetObject("pbcomfort.TabIndex")));
			this.pbcomfort.Tag = "500";
			this.pbcomfort.Text = resources.GetString("pbcomfort.Text");
			this.toolTip1.SetToolTip(this.pbcomfort, resources.GetString("pbcomfort.ToolTip"));
			this.pbcomfort.Visible = ((bool)(resources.GetObject("pbcomfort.Visible")));
			this.pbcomfort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbcomfort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbcomfort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label80
			// 
			this.label80.AccessibleDescription = resources.GetString("label80.AccessibleDescription");
			this.label80.AccessibleName = resources.GetString("label80.AccessibleName");
			this.label80.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label80.Anchor")));
			this.label80.AutoSize = ((bool)(resources.GetObject("label80.AutoSize")));
			this.label80.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label80.Dock")));
			this.label80.Enabled = ((bool)(resources.GetObject("label80.Enabled")));
			this.label80.Font = ((System.Drawing.Font)(resources.GetObject("label80.Font")));
			this.label80.Image = ((System.Drawing.Image)(resources.GetObject("label80.Image")));
			this.label80.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label80.ImageAlign")));
			this.label80.ImageIndex = ((int)(resources.GetObject("label80.ImageIndex")));
			this.label80.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label80.ImeMode")));
			this.label80.Location = ((System.Drawing.Point)(resources.GetObject("label80.Location")));
			this.label80.Name = "label80";
			this.label80.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label80.RightToLeft")));
			this.label80.Size = ((System.Drawing.Size)(resources.GetObject("label80.Size")));
			this.label80.TabIndex = ((int)(resources.GetObject("label80.TabIndex")));
			this.label80.Text = resources.GetString("label80.Text");
			this.label80.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label80.TextAlign")));
			this.toolTip1.SetToolTip(this.label80, resources.GetString("label80.ToolTip"));
			this.label80.Visible = ((bool)(resources.GetObject("label80.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label80, true);
			// 
			// tbcomfort
			// 
			this.tbcomfort.AccessibleDescription = resources.GetString("tbcomfort.AccessibleDescription");
			this.tbcomfort.AccessibleName = resources.GetString("tbcomfort.AccessibleName");
			this.tbcomfort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbcomfort.Anchor")));
			this.tbcomfort.AutoSize = ((bool)(resources.GetObject("tbcomfort.AutoSize")));
			this.tbcomfort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbcomfort.BackgroundImage")));
			this.tbcomfort.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbcomfort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbcomfort.Dock")));
			this.tbcomfort.Enabled = ((bool)(resources.GetObject("tbcomfort.Enabled")));
			this.tbcomfort.Font = ((System.Drawing.Font)(resources.GetObject("tbcomfort.Font")));
			this.tbcomfort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbcomfort.ImeMode")));
			this.tbcomfort.Location = ((System.Drawing.Point)(resources.GetObject("tbcomfort.Location")));
			this.tbcomfort.MaxLength = ((int)(resources.GetObject("tbcomfort.MaxLength")));
			this.tbcomfort.Multiline = ((bool)(resources.GetObject("tbcomfort.Multiline")));
			this.tbcomfort.Name = "tbcomfort";
			this.tbcomfort.PasswordChar = ((char)(resources.GetObject("tbcomfort.PasswordChar")));
			this.tbcomfort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbcomfort.RightToLeft")));
			this.tbcomfort.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbcomfort.ScrollBars")));
			this.tbcomfort.Size = ((System.Drawing.Size)(resources.GetObject("tbcomfort.Size")));
			this.tbcomfort.TabIndex = ((int)(resources.GetObject("tbcomfort.TabIndex")));
			this.tbcomfort.Text = resources.GetString("tbcomfort.Text");
			this.tbcomfort.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbcomfort.TextAlign")));
			this.toolTip1.SetToolTip(this.tbcomfort, resources.GetString("tbcomfort.ToolTip"));
			this.tbcomfort.Visible = ((bool)(resources.GetObject("tbcomfort.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbcomfort, true);
			this.tbcomfort.WordWrap = ((bool)(resources.GetObject("tbcomfort.WordWrap")));
			this.tbcomfort.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbcomfort.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbhunger
			// 
			this.pbhunger.AccessibleDescription = resources.GetString("pbhunger.AccessibleDescription");
			this.pbhunger.AccessibleName = resources.GetString("pbhunger.AccessibleName");
			this.pbhunger.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbhunger.Anchor")));
			this.pbhunger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbhunger.BackgroundImage")));
			this.pbhunger.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbhunger.Dock")));
			this.pbhunger.Enabled = ((bool)(resources.GetObject("pbhunger.Enabled")));
			this.pbhunger.Font = ((System.Drawing.Font)(resources.GetObject("pbhunger.Font")));
			this.pbhunger.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbhunger.ImeMode")));
			this.pbhunger.Location = ((System.Drawing.Point)(resources.GetObject("pbhunger.Location")));
			this.pbhunger.Maximum = 2000;
			this.pbhunger.Name = "pbhunger";
			this.pbhunger.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbhunger.RightToLeft")));
			this.pbhunger.Size = ((System.Drawing.Size)(resources.GetObject("pbhunger.Size")));
			this.pbhunger.Step = 1;
			this.pbhunger.TabIndex = ((int)(resources.GetObject("pbhunger.TabIndex")));
			this.pbhunger.Tag = "(int)500";
			this.pbhunger.Text = resources.GetString("pbhunger.Text");
			this.toolTip1.SetToolTip(this.pbhunger, resources.GetString("pbhunger.ToolTip"));
			this.pbhunger.Visible = ((bool)(resources.GetObject("pbhunger.Visible")));
			this.pbhunger.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbhunger.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbhunger.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// label79
			// 
			this.label79.AccessibleDescription = resources.GetString("label79.AccessibleDescription");
			this.label79.AccessibleName = resources.GetString("label79.AccessibleName");
			this.label79.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label79.Anchor")));
			this.label79.AutoSize = ((bool)(resources.GetObject("label79.AutoSize")));
			this.label79.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label79.Dock")));
			this.label79.Enabled = ((bool)(resources.GetObject("label79.Enabled")));
			this.label79.Font = ((System.Drawing.Font)(resources.GetObject("label79.Font")));
			this.label79.Image = ((System.Drawing.Image)(resources.GetObject("label79.Image")));
			this.label79.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label79.ImageAlign")));
			this.label79.ImageIndex = ((int)(resources.GetObject("label79.ImageIndex")));
			this.label79.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label79.ImeMode")));
			this.label79.Location = ((System.Drawing.Point)(resources.GetObject("label79.Location")));
			this.label79.Name = "label79";
			this.label79.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label79.RightToLeft")));
			this.label79.Size = ((System.Drawing.Size)(resources.GetObject("label79.Size")));
			this.label79.TabIndex = ((int)(resources.GetObject("label79.TabIndex")));
			this.label79.Text = resources.GetString("label79.Text");
			this.label79.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label79.TextAlign")));
			this.toolTip1.SetToolTip(this.label79, resources.GetString("label79.ToolTip"));
			this.label79.Visible = ((bool)(resources.GetObject("label79.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label79, true);
			// 
			// tbhunger
			// 
			this.tbhunger.AccessibleDescription = resources.GetString("tbhunger.AccessibleDescription");
			this.tbhunger.AccessibleName = resources.GetString("tbhunger.AccessibleName");
			this.tbhunger.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbhunger.Anchor")));
			this.tbhunger.AutoSize = ((bool)(resources.GetObject("tbhunger.AutoSize")));
			this.tbhunger.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbhunger.BackgroundImage")));
			this.tbhunger.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbhunger.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbhunger.Dock")));
			this.tbhunger.Enabled = ((bool)(resources.GetObject("tbhunger.Enabled")));
			this.tbhunger.Font = ((System.Drawing.Font)(resources.GetObject("tbhunger.Font")));
			this.tbhunger.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbhunger.ImeMode")));
			this.tbhunger.Location = ((System.Drawing.Point)(resources.GetObject("tbhunger.Location")));
			this.tbhunger.MaxLength = ((int)(resources.GetObject("tbhunger.MaxLength")));
			this.tbhunger.Multiline = ((bool)(resources.GetObject("tbhunger.Multiline")));
			this.tbhunger.Name = "tbhunger";
			this.tbhunger.PasswordChar = ((char)(resources.GetObject("tbhunger.PasswordChar")));
			this.tbhunger.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbhunger.RightToLeft")));
			this.tbhunger.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbhunger.ScrollBars")));
			this.tbhunger.Size = ((System.Drawing.Size)(resources.GetObject("tbhunger.Size")));
			this.tbhunger.TabIndex = ((int)(resources.GetObject("tbhunger.TabIndex")));
			this.tbhunger.Text = resources.GetString("tbhunger.Text");
			this.tbhunger.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbhunger.TextAlign")));
			this.toolTip1.SetToolTip(this.tbhunger, resources.GetString("tbhunger.ToolTip"));
			this.tbhunger.Visible = ((bool)(resources.GetObject("tbhunger.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbhunger, true);
			this.tbhunger.WordWrap = ((bool)(resources.GetObject("tbhunger.WordWrap")));
			this.tbhunger.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbhunger.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// tbuni
			// 
			this.tbuni.AccessibleDescription = resources.GetString("tbuni.AccessibleDescription");
			this.tbuni.AccessibleName = resources.GetString("tbuni.AccessibleName");
			this.tbuni.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbuni.Anchor")));
			this.tbuni.AutoScroll = ((bool)(resources.GetObject("tbuni.AutoScroll")));
			this.tbuni.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tbuni.AutoScrollMargin")));
			this.tbuni.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tbuni.AutoScrollMinSize")));
			this.tbuni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbuni.BackgroundImage")));
			this.tbuni.Controls.Add(this.pbunitime);
			this.tbuni.Controls.Add(this.tbunitime);
			this.tbuni.Controls.Add(this.tbinfluence);
			this.tbuni.Controls.Add(this.tbsemester);
			this.tbuni.Controls.Add(this.pblastgrade);
			this.tbuni.Controls.Add(this.tblastgrade);
			this.tbuni.Controls.Add(this.pbeffort);
			this.tbuni.Controls.Add(this.tbeffort);
			this.tbuni.Controls.Add(this.label103);
			this.tbuni.Controls.Add(this.label102);
			this.tbuni.Controls.Add(this.label101);
			this.tbuni.Controls.Add(this.label100);
			this.tbuni.Controls.Add(this.cboncampus);
			this.tbuni.Controls.Add(this.label99);
			this.tbuni.Controls.Add(this.cbmajor);
			this.tbuni.Controls.Add(this.label98);
			this.tbuni.Controls.Add(this.tbmajor);
			this.tbuni.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbuni.Dock")));
			this.tbuni.Enabled = ((bool)(resources.GetObject("tbuni.Enabled")));
			this.tbuni.Font = ((System.Drawing.Font)(resources.GetObject("tbuni.Font")));
			this.tbuni.ImageIndex = ((int)(resources.GetObject("tbuni.ImageIndex")));
			this.tbuni.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbuni.ImeMode")));
			this.tbuni.Location = ((System.Drawing.Point)(resources.GetObject("tbuni.Location")));
			this.tbuni.Name = "tbuni";
			this.tbuni.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbuni.RightToLeft")));
			this.tbuni.Size = ((System.Drawing.Size)(resources.GetObject("tbuni.Size")));
			this.tbuni.TabIndex = ((int)(resources.GetObject("tbuni.TabIndex")));
			this.tbuni.Text = resources.GetString("tbuni.Text");
			this.toolTip1.SetToolTip(this.tbuni, resources.GetString("tbuni.ToolTip"));
			this.tbuni.ToolTipText = resources.GetString("tbuni.ToolTipText");
			this.tbuni.Visible = ((bool)(resources.GetObject("tbuni.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbuni, true);
			this.tbuni.Click += new System.EventHandler(this.tbuni_Click);
			// 
			// pbunitime
			// 
			this.pbunitime.AccessibleDescription = resources.GetString("pbunitime.AccessibleDescription");
			this.pbunitime.AccessibleName = resources.GetString("pbunitime.AccessibleName");
			this.pbunitime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbunitime.Anchor")));
			this.pbunitime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbunitime.BackgroundImage")));
			this.pbunitime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbunitime.Dock")));
			this.pbunitime.Enabled = ((bool)(resources.GetObject("pbunitime.Enabled")));
			this.pbunitime.Font = ((System.Drawing.Font)(resources.GetObject("pbunitime.Font")));
			this.pbunitime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbunitime.ImeMode")));
			this.pbunitime.Location = ((System.Drawing.Point)(resources.GetObject("pbunitime.Location")));
			this.pbunitime.Maximum = 72;
			this.pbunitime.Name = "pbunitime";
			this.pbunitime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbunitime.RightToLeft")));
			this.pbunitime.Size = ((System.Drawing.Size)(resources.GetObject("pbunitime.Size")));
			this.pbunitime.Step = 1;
			this.pbunitime.TabIndex = ((int)(resources.GetObject("pbunitime.TabIndex")));
			this.pbunitime.Text = resources.GetString("pbunitime.Text");
			this.toolTip1.SetToolTip(this.pbunitime, resources.GetString("pbunitime.ToolTip"));
			this.pbunitime.Visible = ((bool)(resources.GetObject("pbunitime.Visible")));
			this.pbunitime.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbunitime.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbunitime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbunitime
			// 
			this.tbunitime.AccessibleDescription = resources.GetString("tbunitime.AccessibleDescription");
			this.tbunitime.AccessibleName = resources.GetString("tbunitime.AccessibleName");
			this.tbunitime.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbunitime.Anchor")));
			this.tbunitime.AutoSize = ((bool)(resources.GetObject("tbunitime.AutoSize")));
			this.tbunitime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbunitime.BackgroundImage")));
			this.tbunitime.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbunitime.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbunitime.Dock")));
			this.tbunitime.Enabled = ((bool)(resources.GetObject("tbunitime.Enabled")));
			this.tbunitime.Font = ((System.Drawing.Font)(resources.GetObject("tbunitime.Font")));
			this.tbunitime.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbunitime.ImeMode")));
			this.tbunitime.Location = ((System.Drawing.Point)(resources.GetObject("tbunitime.Location")));
			this.tbunitime.MaxLength = ((int)(resources.GetObject("tbunitime.MaxLength")));
			this.tbunitime.Multiline = ((bool)(resources.GetObject("tbunitime.Multiline")));
			this.tbunitime.Name = "tbunitime";
			this.tbunitime.PasswordChar = ((char)(resources.GetObject("tbunitime.PasswordChar")));
			this.tbunitime.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbunitime.RightToLeft")));
			this.tbunitime.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbunitime.ScrollBars")));
			this.tbunitime.Size = ((System.Drawing.Size)(resources.GetObject("tbunitime.Size")));
			this.tbunitime.TabIndex = ((int)(resources.GetObject("tbunitime.TabIndex")));
			this.tbunitime.Text = resources.GetString("tbunitime.Text");
			this.tbunitime.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbunitime.TextAlign")));
			this.toolTip1.SetToolTip(this.tbunitime, resources.GetString("tbunitime.ToolTip"));
			this.tbunitime.Visible = ((bool)(resources.GetObject("tbunitime.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbunitime, true);
			this.tbunitime.WordWrap = ((bool)(resources.GetObject("tbunitime.WordWrap")));
			this.tbunitime.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbunitime.Leave += new System.EventHandler(this.ProgressBarTextLeave);
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
			this.toolTip1.SetToolTip(this.tbinfluence, resources.GetString("tbinfluence.ToolTip"));
			this.tbinfluence.Visible = ((bool)(resources.GetObject("tbinfluence.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbinfluence, true);
			this.tbinfluence.WordWrap = ((bool)(resources.GetObject("tbinfluence.WordWrap")));
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
			this.toolTip1.SetToolTip(this.tbsemester, resources.GetString("tbsemester.ToolTip"));
			this.tbsemester.Visible = ((bool)(resources.GetObject("tbsemester.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsemester, true);
			this.tbsemester.WordWrap = ((bool)(resources.GetObject("tbsemester.WordWrap")));
			// 
			// pblastgrade
			// 
			this.pblastgrade.AccessibleDescription = resources.GetString("pblastgrade.AccessibleDescription");
			this.pblastgrade.AccessibleName = resources.GetString("pblastgrade.AccessibleName");
			this.pblastgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pblastgrade.Anchor")));
			this.pblastgrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pblastgrade.BackgroundImage")));
			this.pblastgrade.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pblastgrade.Dock")));
			this.pblastgrade.Enabled = ((bool)(resources.GetObject("pblastgrade.Enabled")));
			this.pblastgrade.Font = ((System.Drawing.Font)(resources.GetObject("pblastgrade.Font")));
			this.pblastgrade.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pblastgrade.ImeMode")));
			this.pblastgrade.Location = ((System.Drawing.Point)(resources.GetObject("pblastgrade.Location")));
			this.pblastgrade.Maximum = 5;
			this.pblastgrade.Minimum = 1;
			this.pblastgrade.Name = "pblastgrade";
			this.pblastgrade.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pblastgrade.RightToLeft")));
			this.pblastgrade.Size = ((System.Drawing.Size)(resources.GetObject("pblastgrade.Size")));
			this.pblastgrade.Step = 1;
			this.pblastgrade.TabIndex = ((int)(resources.GetObject("pblastgrade.TabIndex")));
			this.pblastgrade.Text = resources.GetString("pblastgrade.Text");
			this.toolTip1.SetToolTip(this.pblastgrade, resources.GetString("pblastgrade.ToolTip"));
			this.pblastgrade.Value = 1;
			this.pblastgrade.Visible = ((bool)(resources.GetObject("pblastgrade.Visible")));
			this.pblastgrade.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pblastgrade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pblastgrade.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tblastgrade
			// 
			this.tblastgrade.AccessibleDescription = resources.GetString("tblastgrade.AccessibleDescription");
			this.tblastgrade.AccessibleName = resources.GetString("tblastgrade.AccessibleName");
			this.tblastgrade.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblastgrade.Anchor")));
			this.tblastgrade.AutoSize = ((bool)(resources.GetObject("tblastgrade.AutoSize")));
			this.tblastgrade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblastgrade.BackgroundImage")));
			this.tblastgrade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tblastgrade.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblastgrade.Dock")));
			this.tblastgrade.Enabled = ((bool)(resources.GetObject("tblastgrade.Enabled")));
			this.tblastgrade.Font = ((System.Drawing.Font)(resources.GetObject("tblastgrade.Font")));
			this.tblastgrade.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblastgrade.ImeMode")));
			this.tblastgrade.Location = ((System.Drawing.Point)(resources.GetObject("tblastgrade.Location")));
			this.tblastgrade.MaxLength = ((int)(resources.GetObject("tblastgrade.MaxLength")));
			this.tblastgrade.Multiline = ((bool)(resources.GetObject("tblastgrade.Multiline")));
			this.tblastgrade.Name = "tblastgrade";
			this.tblastgrade.PasswordChar = ((char)(resources.GetObject("tblastgrade.PasswordChar")));
			this.tblastgrade.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblastgrade.RightToLeft")));
			this.tblastgrade.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblastgrade.ScrollBars")));
			this.tblastgrade.Size = ((System.Drawing.Size)(resources.GetObject("tblastgrade.Size")));
			this.tblastgrade.TabIndex = ((int)(resources.GetObject("tblastgrade.TabIndex")));
			this.tblastgrade.Text = resources.GetString("tblastgrade.Text");
			this.tblastgrade.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblastgrade.TextAlign")));
			this.toolTip1.SetToolTip(this.tblastgrade, resources.GetString("tblastgrade.ToolTip"));
			this.tblastgrade.Visible = ((bool)(resources.GetObject("tblastgrade.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblastgrade, true);
			this.tblastgrade.WordWrap = ((bool)(resources.GetObject("tblastgrade.WordWrap")));
			this.tblastgrade.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tblastgrade.Leave += new System.EventHandler(this.ProgressBarTextLeave);
			// 
			// pbeffort
			// 
			this.pbeffort.AccessibleDescription = resources.GetString("pbeffort.AccessibleDescription");
			this.pbeffort.AccessibleName = resources.GetString("pbeffort.AccessibleName");
			this.pbeffort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("pbeffort.Anchor")));
			this.pbeffort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbeffort.BackgroundImage")));
			this.pbeffort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("pbeffort.Dock")));
			this.pbeffort.Enabled = ((bool)(resources.GetObject("pbeffort.Enabled")));
			this.pbeffort.Font = ((System.Drawing.Font)(resources.GetObject("pbeffort.Font")));
			this.pbeffort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("pbeffort.ImeMode")));
			this.pbeffort.Location = ((System.Drawing.Point)(resources.GetObject("pbeffort.Location")));
			this.pbeffort.Maximum = 1000;
			this.pbeffort.Name = "pbeffort";
			this.pbeffort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("pbeffort.RightToLeft")));
			this.pbeffort.Size = ((System.Drawing.Size)(resources.GetObject("pbeffort.Size")));
			this.pbeffort.Step = 1;
			this.pbeffort.TabIndex = ((int)(resources.GetObject("pbeffort.TabIndex")));
			this.pbeffort.Text = resources.GetString("pbeffort.Text");
			this.toolTip1.SetToolTip(this.pbeffort, resources.GetString("pbeffort.ToolTip"));
			this.pbeffort.Visible = ((bool)(resources.GetObject("pbeffort.Visible")));
			this.pbeffort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseUp);
			this.pbeffort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseMove);
			this.pbeffort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ProgressBarMouseDown);
			// 
			// tbeffort
			// 
			this.tbeffort.AccessibleDescription = resources.GetString("tbeffort.AccessibleDescription");
			this.tbeffort.AccessibleName = resources.GetString("tbeffort.AccessibleName");
			this.tbeffort.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbeffort.Anchor")));
			this.tbeffort.AutoSize = ((bool)(resources.GetObject("tbeffort.AutoSize")));
			this.tbeffort.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbeffort.BackgroundImage")));
			this.tbeffort.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbeffort.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbeffort.Dock")));
			this.tbeffort.Enabled = ((bool)(resources.GetObject("tbeffort.Enabled")));
			this.tbeffort.Font = ((System.Drawing.Font)(resources.GetObject("tbeffort.Font")));
			this.tbeffort.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbeffort.ImeMode")));
			this.tbeffort.Location = ((System.Drawing.Point)(resources.GetObject("tbeffort.Location")));
			this.tbeffort.MaxLength = ((int)(resources.GetObject("tbeffort.MaxLength")));
			this.tbeffort.Multiline = ((bool)(resources.GetObject("tbeffort.Multiline")));
			this.tbeffort.Name = "tbeffort";
			this.tbeffort.PasswordChar = ((char)(resources.GetObject("tbeffort.PasswordChar")));
			this.tbeffort.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbeffort.RightToLeft")));
			this.tbeffort.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbeffort.ScrollBars")));
			this.tbeffort.Size = ((System.Drawing.Size)(resources.GetObject("tbeffort.Size")));
			this.tbeffort.TabIndex = ((int)(resources.GetObject("tbeffort.TabIndex")));
			this.tbeffort.Text = resources.GetString("tbeffort.Text");
			this.tbeffort.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbeffort.TextAlign")));
			this.toolTip1.SetToolTip(this.tbeffort, resources.GetString("tbeffort.ToolTip"));
			this.tbeffort.Visible = ((bool)(resources.GetObject("tbeffort.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbeffort, true);
			this.tbeffort.WordWrap = ((bool)(resources.GetObject("tbeffort.WordWrap")));
			this.tbeffort.TextChanged += new System.EventHandler(this.ProgressBarTextChanged);
			this.tbeffort.Leave += new System.EventHandler(this.ProgressBarTextLeave);
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
			this.toolTip1.SetToolTip(this.label103, resources.GetString("label103.ToolTip"));
			this.label103.Visible = ((bool)(resources.GetObject("label103.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label103, true);
			// 
			// label102
			// 
			this.label102.AccessibleDescription = resources.GetString("label102.AccessibleDescription");
			this.label102.AccessibleName = resources.GetString("label102.AccessibleName");
			this.label102.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label102.Anchor")));
			this.label102.AutoSize = ((bool)(resources.GetObject("label102.AutoSize")));
			this.label102.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label102.Dock")));
			this.label102.Enabled = ((bool)(resources.GetObject("label102.Enabled")));
			this.label102.Font = ((System.Drawing.Font)(resources.GetObject("label102.Font")));
			this.label102.Image = ((System.Drawing.Image)(resources.GetObject("label102.Image")));
			this.label102.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label102.ImageAlign")));
			this.label102.ImageIndex = ((int)(resources.GetObject("label102.ImageIndex")));
			this.label102.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label102.ImeMode")));
			this.label102.Location = ((System.Drawing.Point)(resources.GetObject("label102.Location")));
			this.label102.Name = "label102";
			this.label102.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label102.RightToLeft")));
			this.label102.Size = ((System.Drawing.Size)(resources.GetObject("label102.Size")));
			this.label102.TabIndex = ((int)(resources.GetObject("label102.TabIndex")));
			this.label102.Text = resources.GetString("label102.Text");
			this.label102.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label102.TextAlign")));
			this.toolTip1.SetToolTip(this.label102, resources.GetString("label102.ToolTip"));
			this.label102.Visible = ((bool)(resources.GetObject("label102.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label102, true);
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
			this.toolTip1.SetToolTip(this.label101, resources.GetString("label101.ToolTip"));
			this.label101.Visible = ((bool)(resources.GetObject("label101.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label101, true);
			// 
			// label100
			// 
			this.label100.AccessibleDescription = resources.GetString("label100.AccessibleDescription");
			this.label100.AccessibleName = resources.GetString("label100.AccessibleName");
			this.label100.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label100.Anchor")));
			this.label100.AutoSize = ((bool)(resources.GetObject("label100.AutoSize")));
			this.label100.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label100.Dock")));
			this.label100.Enabled = ((bool)(resources.GetObject("label100.Enabled")));
			this.label100.Font = ((System.Drawing.Font)(resources.GetObject("label100.Font")));
			this.label100.Image = ((System.Drawing.Image)(resources.GetObject("label100.Image")));
			this.label100.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label100.ImageAlign")));
			this.label100.ImageIndex = ((int)(resources.GetObject("label100.ImageIndex")));
			this.label100.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label100.ImeMode")));
			this.label100.Location = ((System.Drawing.Point)(resources.GetObject("label100.Location")));
			this.label100.Name = "label100";
			this.label100.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label100.RightToLeft")));
			this.label100.Size = ((System.Drawing.Size)(resources.GetObject("label100.Size")));
			this.label100.TabIndex = ((int)(resources.GetObject("label100.TabIndex")));
			this.label100.Text = resources.GetString("label100.Text");
			this.label100.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label100.TextAlign")));
			this.toolTip1.SetToolTip(this.label100, resources.GetString("label100.ToolTip"));
			this.label100.Visible = ((bool)(resources.GetObject("label100.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label100, true);
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
			this.toolTip1.SetToolTip(this.cboncampus, resources.GetString("cboncampus.ToolTip"));
			this.cboncampus.Visible = ((bool)(resources.GetObject("cboncampus.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cboncampus, true);
			// 
			// label99
			// 
			this.label99.AccessibleDescription = resources.GetString("label99.AccessibleDescription");
			this.label99.AccessibleName = resources.GetString("label99.AccessibleName");
			this.label99.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label99.Anchor")));
			this.label99.AutoSize = ((bool)(resources.GetObject("label99.AutoSize")));
			this.label99.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label99.Dock")));
			this.label99.Enabled = ((bool)(resources.GetObject("label99.Enabled")));
			this.label99.Font = ((System.Drawing.Font)(resources.GetObject("label99.Font")));
			this.label99.Image = ((System.Drawing.Image)(resources.GetObject("label99.Image")));
			this.label99.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label99.ImageAlign")));
			this.label99.ImageIndex = ((int)(resources.GetObject("label99.ImageIndex")));
			this.label99.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label99.ImeMode")));
			this.label99.Location = ((System.Drawing.Point)(resources.GetObject("label99.Location")));
			this.label99.Name = "label99";
			this.label99.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label99.RightToLeft")));
			this.label99.Size = ((System.Drawing.Size)(resources.GetObject("label99.Size")));
			this.label99.TabIndex = ((int)(resources.GetObject("label99.TabIndex")));
			this.label99.Text = resources.GetString("label99.Text");
			this.label99.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label99.TextAlign")));
			this.toolTip1.SetToolTip(this.label99, resources.GetString("label99.ToolTip"));
			this.label99.Visible = ((bool)(resources.GetObject("label99.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label99, true);
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
			this.toolTip1.SetToolTip(this.cbmajor, resources.GetString("cbmajor.ToolTip"));
			this.cbmajor.Visible = ((bool)(resources.GetObject("cbmajor.Visible")));
			this.cbmajor.SelectedIndexChanged += new System.EventHandler(this.SelectMajor);
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
			this.toolTip1.SetToolTip(this.label98, resources.GetString("label98.ToolTip"));
			this.label98.Visible = ((bool)(resources.GetObject("label98.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label98, true);
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
			this.toolTip1.SetToolTip(this.tbmajor, resources.GetString("tbmajor.ToolTip"));
			this.tbmajor.Visible = ((bool)(resources.GetObject("tbmajor.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbmajor, true);
			this.tbmajor.WordWrap = ((bool)(resources.GetObject("tbmajor.WordWrap")));
			// 
			// lldna
			// 
			this.lldna.AccessibleDescription = resources.GetString("lldna.AccessibleDescription");
			this.lldna.AccessibleName = resources.GetString("lldna.AccessibleName");
			this.lldna.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lldna.Anchor")));
			this.lldna.AutoSize = ((bool)(resources.GetObject("lldna.AutoSize")));
			this.lldna.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lldna.Dock")));
			this.lldna.Enabled = ((bool)(resources.GetObject("lldna.Enabled")));
			this.lldna.Font = ((System.Drawing.Font)(resources.GetObject("lldna.Font")));
			this.lldna.Image = ((System.Drawing.Image)(resources.GetObject("lldna.Image")));
			this.lldna.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldna.ImageAlign")));
			this.lldna.ImageIndex = ((int)(resources.GetObject("lldna.ImageIndex")));
			this.lldna.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lldna.ImeMode")));
			this.lldna.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("lldna.LinkArea")));
			this.lldna.Location = ((System.Drawing.Point)(resources.GetObject("lldna.Location")));
			this.lldna.Name = "lldna";
			this.lldna.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lldna.RightToLeft")));
			this.lldna.Size = ((System.Drawing.Size)(resources.GetObject("lldna.Size")));
			this.lldna.TabIndex = ((int)(resources.GetObject("lldna.TabIndex")));
			this.lldna.TabStop = true;
			this.lldna.Text = resources.GetString("lldna.Text");
			this.lldna.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lldna.TextAlign")));
			this.toolTip1.SetToolTip(this.lldna, resources.GetString("lldna.ToolTip"));
			this.lldna.Visible = ((bool)(resources.GetObject("lldna.Visible")));
			this.lldna.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lldna_LinkClicked);
			// 
			// llcloth
			// 
			this.llcloth.AccessibleDescription = resources.GetString("llcloth.AccessibleDescription");
			this.llcloth.AccessibleName = resources.GetString("llcloth.AccessibleName");
			this.llcloth.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llcloth.Anchor")));
			this.llcloth.AutoSize = ((bool)(resources.GetObject("llcloth.AutoSize")));
			this.llcloth.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llcloth.Dock")));
			this.llcloth.Enabled = ((bool)(resources.GetObject("llcloth.Enabled")));
			this.llcloth.Font = ((System.Drawing.Font)(resources.GetObject("llcloth.Font")));
			this.llcloth.Image = ((System.Drawing.Image)(resources.GetObject("llcloth.Image")));
			this.llcloth.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcloth.ImageAlign")));
			this.llcloth.ImageIndex = ((int)(resources.GetObject("llcloth.ImageIndex")));
			this.llcloth.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llcloth.ImeMode")));
			this.llcloth.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llcloth.LinkArea")));
			this.llcloth.Location = ((System.Drawing.Point)(resources.GetObject("llcloth.Location")));
			this.llcloth.Name = "llcloth";
			this.llcloth.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llcloth.RightToLeft")));
			this.llcloth.Size = ((System.Drawing.Size)(resources.GetObject("llcloth.Size")));
			this.llcloth.TabIndex = ((int)(resources.GetObject("llcloth.TabIndex")));
			this.llcloth.TabStop = true;
			this.llcloth.Text = resources.GetString("llcloth.Text");
			this.llcloth.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llcloth.TextAlign")));
			this.toolTip1.SetToolTip(this.llcloth, resources.GetString("llcloth.ToolTip"));
			this.llcloth.Visible = ((bool)(resources.GetObject("llcloth.Visible")));
			this.llcloth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llcloth_LinkClicked);
			// 
			// llfam
			// 
			this.llfam.AccessibleDescription = resources.GetString("llfam.AccessibleDescription");
			this.llfam.AccessibleName = resources.GetString("llfam.AccessibleName");
			this.llfam.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llfam.Anchor")));
			this.llfam.AutoSize = ((bool)(resources.GetObject("llfam.AutoSize")));
			this.llfam.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llfam.Dock")));
			this.llfam.Enabled = ((bool)(resources.GetObject("llfam.Enabled")));
			this.llfam.Font = ((System.Drawing.Font)(resources.GetObject("llfam.Font")));
			this.llfam.Image = ((System.Drawing.Image)(resources.GetObject("llfam.Image")));
			this.llfam.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llfam.ImageAlign")));
			this.llfam.ImageIndex = ((int)(resources.GetObject("llfam.ImageIndex")));
			this.llfam.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llfam.ImeMode")));
			this.llfam.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llfam.LinkArea")));
			this.llfam.Location = ((System.Drawing.Point)(resources.GetObject("llfam.Location")));
			this.llfam.Name = "llfam";
			this.llfam.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llfam.RightToLeft")));
			this.llfam.Size = ((System.Drawing.Size)(resources.GetObject("llfam.Size")));
			this.llfam.TabIndex = ((int)(resources.GetObject("llfam.TabIndex")));
			this.llfam.TabStop = true;
			this.llfam.Text = resources.GetString("llfam.Text");
			this.llfam.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llfam.TextAlign")));
			this.toolTip1.SetToolTip(this.llfam, resources.GetString("llfam.ToolTip"));
			this.llfam.Visible = ((bool)(resources.GetObject("llfam.Visible")));
			this.llfam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenFamily);
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
			this.toolTip1.SetToolTip(this.tbsimdescfamname, resources.GetString("tbsimdescfamname.ToolTip"));
			this.tbsimdescfamname.Visible = ((bool)(resources.GetObject("tbsimdescfamname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimdescfamname, true);
			this.tbsimdescfamname.WordWrap = ((bool)(resources.GetObject("tbsimdescfamname.WordWrap")));
			this.tbsimdescfamname.TextChanged += new System.EventHandler(this.SimNameChanged);
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
			this.toolTip1.SetToolTip(this.tbfaminst, resources.GetString("tbfaminst.ToolTip"));
			this.tbfaminst.Visible = ((bool)(resources.GetObject("tbfaminst.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbfaminst, true);
			this.tbfaminst.WordWrap = ((bool)(resources.GetObject("tbfaminst.WordWrap")));
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
			this.toolTip1.SetToolTip(this.cbzodiac, resources.GetString("cbzodiac.ToolTip"));
			this.cbzodiac.Visible = ((bool)(resources.GetObject("cbzodiac.Visible")));
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
			this.toolTip1.SetToolTip(this.label49, resources.GetString("label49.ToolTip"));
			this.label49.Visible = ((bool)(resources.GetObject("label49.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label49, true);
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
			this.toolTip1.SetToolTip(this.rbmale, resources.GetString("rbmale.ToolTip"));
			this.rbmale.Visible = ((bool)(resources.GetObject("rbmale.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.rbmale, true);
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
			this.toolTip1.SetToolTip(this.rbfemale, resources.GetString("rbfemale.ToolTip"));
			this.rbfemale.Visible = ((bool)(resources.GetObject("rbfemale.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.rbfemale, true);
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
			this.toolTip1.SetToolTip(this.label48, resources.GetString("label48.ToolTip"));
			this.label48.Visible = ((bool)(resources.GetObject("label48.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label48, true);
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
			this.toolTip1.SetToolTip(this.cblifesection, resources.GetString("cblifesection.ToolTip"));
			this.cblifesection.Visible = ((bool)(resources.GetObject("cblifesection.Visible")));
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
			this.toolTip1.SetToolTip(this.label47, resources.GetString("label47.ToolTip"));
			this.label47.Visible = ((bool)(resources.GetObject("label47.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label47, true);
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
			this.toolTip1.SetToolTip(this.cbaspiration, resources.GetString("cbaspiration.ToolTip"));
			this.cbaspiration.Visible = ((bool)(resources.GetObject("cbaspiration.Visible")));
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
			this.toolTip1.SetToolTip(this.label46, resources.GetString("label46.ToolTip"));
			this.label46.Visible = ((bool)(resources.GetObject("label46.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label46, true);
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
			this.toolTip1.SetToolTip(this.pbImage, resources.GetString("pbImage.ToolTip"));
			this.pbImage.Visible = ((bool)(resources.GetObject("pbImage.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.pbImage, true);
			// 
			// llsdesccommit
			// 
			this.llsdesccommit.AccessibleDescription = resources.GetString("llsdesccommit.AccessibleDescription");
			this.llsdesccommit.AccessibleName = resources.GetString("llsdesccommit.AccessibleName");
			this.llsdesccommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsdesccommit.Anchor")));
			this.llsdesccommit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("llsdesccommit.BackgroundImage")));
			this.llsdesccommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsdesccommit.Dock")));
			this.llsdesccommit.Enabled = ((bool)(resources.GetObject("llsdesccommit.Enabled")));
			this.llsdesccommit.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("llsdesccommit.FlatStyle")));
			this.llsdesccommit.Font = ((System.Drawing.Font)(resources.GetObject("llsdesccommit.Font")));
			this.llsdesccommit.Image = ((System.Drawing.Image)(resources.GetObject("llsdesccommit.Image")));
			this.llsdesccommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsdesccommit.ImageAlign")));
			this.llsdesccommit.ImageIndex = ((int)(resources.GetObject("llsdesccommit.ImageIndex")));
			this.llsdesccommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsdesccommit.ImeMode")));
			this.llsdesccommit.Location = ((System.Drawing.Point)(resources.GetObject("llsdesccommit.Location")));
			this.llsdesccommit.Name = "llsdesccommit";
			this.llsdesccommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsdesccommit.RightToLeft")));
			this.llsdesccommit.Size = ((System.Drawing.Size)(resources.GetObject("llsdesccommit.Size")));
			this.llsdesccommit.TabIndex = ((int)(resources.GetObject("llsdesccommit.TabIndex")));
			this.llsdesccommit.Text = resources.GetString("llsdesccommit.Text");
			this.llsdesccommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsdesccommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llsdesccommit, resources.GetString("llsdesccommit.ToolTip"));
			this.llsdesccommit.Visible = ((bool)(resources.GetObject("llsdesccommit.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.llsdesccommit, true);
			this.llsdesccommit.Click += new System.EventHandler(this.CommitSDescClick);
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
			this.toolTip1.SetToolTip(this.tbsimdescname, resources.GetString("tbsimdescname.ToolTip"));
			this.tbsimdescname.Visible = ((bool)(resources.GetObject("tbsimdescname.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsimdescname, true);
			this.tbsimdescname.WordWrap = ((bool)(resources.GetObject("tbsimdescname.WordWrap")));
			this.tbsimdescname.TextChanged += new System.EventHandler(this.SimNameChanged);
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
			this.toolTip1.SetToolTip(this.label13, resources.GetString("label13.ToolTip"));
			this.label13.Visible = ((bool)(resources.GetObject("label13.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label13, true);
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
			this.toolTip1.SetToolTip(this.tbsim, resources.GetString("tbsim.ToolTip"));
			this.tbsim.Visible = ((bool)(resources.GetObject("tbsim.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbsim, true);
			this.tbsim.WordWrap = ((bool)(resources.GetObject("tbsim.WordWrap")));
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
			this.toolTip1.SetToolTip(this.tbage, resources.GetString("tbage.ToolTip"));
			this.tbage.Visible = ((bool)(resources.GetObject("tbage.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbage, true);
			this.tbage.WordWrap = ((bool)(resources.GetObject("tbage.WordWrap")));
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
			this.toolTip1.SetToolTip(this.label10, resources.GetString("label10.ToolTip"));
			this.label10.Visible = ((bool)(resources.GetObject("label10.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label10, true);
			// 
			// panel5
			// 
			this.panel5.AccessibleDescription = resources.GetString("panel5.AccessibleDescription");
			this.panel5.AccessibleName = resources.GetString("panel5.AccessibleName");
			this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel5.Anchor")));
			this.panel5.AutoScroll = ((bool)(resources.GetObject("panel5.AutoScroll")));
			this.panel5.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMargin")));
			this.panel5.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel5.AutoScrollMinSize")));
			this.panel5.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
			this.panel5.Controls.Add(this.lbfilename);
			this.panel5.Controls.Add(this.label11);
			this.panel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel5.Dock")));
			this.panel5.Enabled = ((bool)(resources.GetObject("panel5.Enabled")));
			this.panel5.Font = ((System.Drawing.Font)(resources.GetObject("panel5.Font")));
			this.panel5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel5.ImeMode")));
			this.panel5.Location = ((System.Drawing.Point)(resources.GetObject("panel5.Location")));
			this.panel5.Name = "panel5";
			this.panel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel5.RightToLeft")));
			this.panel5.Size = ((System.Drawing.Size)(resources.GetObject("panel5.Size")));
			this.panel5.TabIndex = ((int)(resources.GetObject("panel5.TabIndex")));
			this.panel5.Text = resources.GetString("panel5.Text");
			this.toolTip1.SetToolTip(this.panel5, resources.GetString("panel5.ToolTip"));
			this.panel5.Visible = ((bool)(resources.GetObject("panel5.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel5, true);
			// 
			// lbfilename
			// 
			this.lbfilename.AccessibleDescription = resources.GetString("lbfilename.AccessibleDescription");
			this.lbfilename.AccessibleName = resources.GetString("lbfilename.AccessibleName");
			this.lbfilename.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("lbfilename.Anchor")));
			this.lbfilename.AutoSize = ((bool)(resources.GetObject("lbfilename.AutoSize")));
			this.lbfilename.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("lbfilename.Dock")));
			this.lbfilename.Enabled = ((bool)(resources.GetObject("lbfilename.Enabled")));
			this.lbfilename.Font = ((System.Drawing.Font)(resources.GetObject("lbfilename.Font")));
			this.lbfilename.Image = ((System.Drawing.Image)(resources.GetObject("lbfilename.Image")));
			this.lbfilename.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfilename.ImageAlign")));
			this.lbfilename.ImageIndex = ((int)(resources.GetObject("lbfilename.ImageIndex")));
			this.lbfilename.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("lbfilename.ImeMode")));
			this.lbfilename.Location = ((System.Drawing.Point)(resources.GetObject("lbfilename.Location")));
			this.lbfilename.Name = "lbfilename";
			this.lbfilename.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("lbfilename.RightToLeft")));
			this.lbfilename.Size = ((System.Drawing.Size)(resources.GetObject("lbfilename.Size")));
			this.lbfilename.TabIndex = ((int)(resources.GetObject("lbfilename.TabIndex")));
			this.lbfilename.Text = resources.GetString("lbfilename.Text");
			this.lbfilename.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("lbfilename.TextAlign")));
			this.toolTip1.SetToolTip(this.lbfilename, resources.GetString("lbfilename.ToolTip"));
			this.lbfilename.Visible = ((bool)(resources.GetObject("lbfilename.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.lbfilename, true);
			this.lbfilename.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FileNameMouseUp);
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
			this.toolTip1.SetToolTip(this.label11, resources.GetString("label11.ToolTip"));
			this.label11.Visible = ((bool)(resources.GetObject("label11.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label11, true);
			// 
			// linkLabel5
			// 
			this.linkLabel5.AccessibleDescription = resources.GetString("linkLabel5.AccessibleDescription");
			this.linkLabel5.AccessibleName = resources.GetString("linkLabel5.AccessibleName");
			this.linkLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("linkLabel5.Anchor")));
			this.linkLabel5.AutoSize = ((bool)(resources.GetObject("linkLabel5.AutoSize")));
			this.linkLabel5.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("linkLabel5.Dock")));
			this.linkLabel5.Enabled = ((bool)(resources.GetObject("linkLabel5.Enabled")));
			this.linkLabel5.Font = ((System.Drawing.Font)(resources.GetObject("linkLabel5.Font")));
			this.linkLabel5.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel5.Image")));
			this.linkLabel5.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel5.ImageAlign")));
			this.linkLabel5.ImageIndex = ((int)(resources.GetObject("linkLabel5.ImageIndex")));
			this.linkLabel5.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("linkLabel5.ImeMode")));
			this.linkLabel5.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("linkLabel5.LinkArea")));
			this.linkLabel5.Location = ((System.Drawing.Point)(resources.GetObject("linkLabel5.Location")));
			this.linkLabel5.Name = "linkLabel5";
			this.linkLabel5.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("linkLabel5.RightToLeft")));
			this.linkLabel5.Size = ((System.Drawing.Size)(resources.GetObject("linkLabel5.Size")));
			this.linkLabel5.TabIndex = ((int)(resources.GetObject("linkLabel5.TabIndex")));
			this.linkLabel5.TabStop = true;
			this.linkLabel5.Text = resources.GetString("linkLabel5.Text");
			this.linkLabel5.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("linkLabel5.TextAlign")));
			this.toolTip1.SetToolTip(this.linkLabel5, resources.GetString("linkLabel5.ToolTip"));
			this.linkLabel5.Visible = ((bool)(resources.GetObject("linkLabel5.Visible")));
			this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OpenWantsFears);
			// 
			// tabPage3
			// 
			this.tabPage3.AccessibleDescription = resources.GetString("tabPage3.AccessibleDescription");
			this.tabPage3.AccessibleName = resources.GetString("tabPage3.AccessibleName");
			this.tabPage3.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tabPage3.Anchor")));
			this.tabPage3.AutoScroll = ((bool)(resources.GetObject("tabPage3.AutoScroll")));
			this.tabPage3.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMargin")));
			this.tabPage3.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("tabPage3.AutoScrollMinSize")));
			this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
			this.tabPage3.Controls.Add(this.objdPanel);
			this.tabPage3.Controls.Add(this.realPanel);
			this.tabPage3.Controls.Add(this.xmlPanel);
			this.tabPage3.Controls.Add(this.JpegPanel);
			this.tabPage3.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tabPage3.Dock")));
			this.tabPage3.Enabled = ((bool)(resources.GetObject("tabPage3.Enabled")));
			this.tabPage3.Font = ((System.Drawing.Font)(resources.GetObject("tabPage3.Font")));
			this.tabPage3.ImageIndex = ((int)(resources.GetObject("tabPage3.ImageIndex")));
			this.tabPage3.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tabPage3.ImeMode")));
			this.tabPage3.Location = ((System.Drawing.Point)(resources.GetObject("tabPage3.Location")));
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tabPage3.RightToLeft")));
			this.tabPage3.Size = ((System.Drawing.Size)(resources.GetObject("tabPage3.Size")));
			this.tabPage3.TabIndex = ((int)(resources.GetObject("tabPage3.TabIndex")));
			this.tabPage3.Text = resources.GetString("tabPage3.Text");
			this.toolTip1.SetToolTip(this.tabPage3, resources.GetString("tabPage3.ToolTip"));
			this.tabPage3.ToolTipText = resources.GetString("tabPage3.ToolTipText");
			this.tabPage3.Visible = ((bool)(resources.GetObject("tabPage3.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tabPage3, true);
			// 
			// realPanel
			// 
			this.realPanel.AccessibleDescription = resources.GetString("realPanel.AccessibleDescription");
			this.realPanel.AccessibleName = resources.GetString("realPanel.AccessibleName");
			this.realPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("realPanel.Anchor")));
			this.realPanel.AutoScroll = ((bool)(resources.GetObject("realPanel.AutoScroll")));
			this.realPanel.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("realPanel.AutoScrollMargin")));
			this.realPanel.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("realPanel.AutoScrollMinSize")));
			this.realPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("realPanel.BackgroundImage")));
			this.realPanel.Controls.Add(this.label91);
			this.realPanel.Controls.Add(this.cbfamtype);
			this.realPanel.Controls.Add(this.llsrelcommit);
			this.realPanel.Controls.Add(this.gbrelation);
			this.realPanel.Controls.Add(this.tblongterm);
			this.realPanel.Controls.Add(this.tbshortterm);
			this.realPanel.Controls.Add(this.label57);
			this.realPanel.Controls.Add(this.label58);
			this.realPanel.Controls.Add(this.panel7);
			this.realPanel.Controls.Add(this.llrelcommit);
			this.realPanel.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("realPanel.Dock")));
			this.realPanel.Enabled = ((bool)(resources.GetObject("realPanel.Enabled")));
			this.realPanel.Font = ((System.Drawing.Font)(resources.GetObject("realPanel.Font")));
			this.realPanel.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("realPanel.ImeMode")));
			this.realPanel.Location = ((System.Drawing.Point)(resources.GetObject("realPanel.Location")));
			this.realPanel.Name = "realPanel";
			this.realPanel.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("realPanel.RightToLeft")));
			this.realPanel.Size = ((System.Drawing.Size)(resources.GetObject("realPanel.Size")));
			this.realPanel.TabIndex = ((int)(resources.GetObject("realPanel.TabIndex")));
			this.realPanel.Text = resources.GetString("realPanel.Text");
			this.toolTip1.SetToolTip(this.realPanel, resources.GetString("realPanel.ToolTip"));
			this.realPanel.Visible = ((bool)(resources.GetObject("realPanel.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.realPanel, true);
			// 
			// label91
			// 
			this.label91.AccessibleDescription = resources.GetString("label91.AccessibleDescription");
			this.label91.AccessibleName = resources.GetString("label91.AccessibleName");
			this.label91.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label91.Anchor")));
			this.label91.AutoSize = ((bool)(resources.GetObject("label91.AutoSize")));
			this.label91.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label91.Dock")));
			this.label91.Enabled = ((bool)(resources.GetObject("label91.Enabled")));
			this.label91.Font = ((System.Drawing.Font)(resources.GetObject("label91.Font")));
			this.label91.Image = ((System.Drawing.Image)(resources.GetObject("label91.Image")));
			this.label91.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.ImageAlign")));
			this.label91.ImageIndex = ((int)(resources.GetObject("label91.ImageIndex")));
			this.label91.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label91.ImeMode")));
			this.label91.Location = ((System.Drawing.Point)(resources.GetObject("label91.Location")));
			this.label91.Name = "label91";
			this.label91.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label91.RightToLeft")));
			this.label91.Size = ((System.Drawing.Size)(resources.GetObject("label91.Size")));
			this.label91.TabIndex = ((int)(resources.GetObject("label91.TabIndex")));
			this.label91.Text = resources.GetString("label91.Text");
			this.label91.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label91.TextAlign")));
			this.toolTip1.SetToolTip(this.label91, resources.GetString("label91.ToolTip"));
			this.label91.Visible = ((bool)(resources.GetObject("label91.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label91, true);
			// 
			// cbfamtype
			// 
			this.cbfamtype.AccessibleDescription = resources.GetString("cbfamtype.AccessibleDescription");
			this.cbfamtype.AccessibleName = resources.GetString("cbfamtype.AccessibleName");
			this.cbfamtype.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamtype.Anchor")));
			this.cbfamtype.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamtype.BackgroundImage")));
			this.cbfamtype.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamtype.Dock")));
			this.cbfamtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbfamtype.Enabled = ((bool)(resources.GetObject("cbfamtype.Enabled")));
			this.cbfamtype.Font = ((System.Drawing.Font)(resources.GetObject("cbfamtype.Font")));
			this.cbfamtype.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamtype.ImeMode")));
			this.cbfamtype.IntegralHeight = ((bool)(resources.GetObject("cbfamtype.IntegralHeight")));
			this.cbfamtype.ItemHeight = ((int)(resources.GetObject("cbfamtype.ItemHeight")));
			this.cbfamtype.Location = ((System.Drawing.Point)(resources.GetObject("cbfamtype.Location")));
			this.cbfamtype.MaxDropDownItems = ((int)(resources.GetObject("cbfamtype.MaxDropDownItems")));
			this.cbfamtype.MaxLength = ((int)(resources.GetObject("cbfamtype.MaxLength")));
			this.cbfamtype.Name = "cbfamtype";
			this.cbfamtype.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamtype.RightToLeft")));
			this.cbfamtype.Size = ((System.Drawing.Size)(resources.GetObject("cbfamtype.Size")));
			this.cbfamtype.TabIndex = ((int)(resources.GetObject("cbfamtype.TabIndex")));
			this.cbfamtype.Text = resources.GetString("cbfamtype.Text");
			this.toolTip1.SetToolTip(this.cbfamtype, resources.GetString("cbfamtype.ToolTip"));
			this.cbfamtype.Visible = ((bool)(resources.GetObject("cbfamtype.Visible")));
			// 
			// llsrelcommit
			// 
			this.llsrelcommit.AccessibleDescription = resources.GetString("llsrelcommit.AccessibleDescription");
			this.llsrelcommit.AccessibleName = resources.GetString("llsrelcommit.AccessibleName");
			this.llsrelcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llsrelcommit.Anchor")));
			this.llsrelcommit.AutoSize = ((bool)(resources.GetObject("llsrelcommit.AutoSize")));
			this.llsrelcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llsrelcommit.Dock")));
			this.llsrelcommit.Enabled = ((bool)(resources.GetObject("llsrelcommit.Enabled")));
			this.llsrelcommit.Font = ((System.Drawing.Font)(resources.GetObject("llsrelcommit.Font")));
			this.llsrelcommit.Image = ((System.Drawing.Image)(resources.GetObject("llsrelcommit.Image")));
			this.llsrelcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsrelcommit.ImageAlign")));
			this.llsrelcommit.ImageIndex = ((int)(resources.GetObject("llsrelcommit.ImageIndex")));
			this.llsrelcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llsrelcommit.ImeMode")));
			this.llsrelcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llsrelcommit.LinkArea")));
			this.llsrelcommit.Location = ((System.Drawing.Point)(resources.GetObject("llsrelcommit.Location")));
			this.llsrelcommit.Name = "llsrelcommit";
			this.llsrelcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llsrelcommit.RightToLeft")));
			this.llsrelcommit.Size = ((System.Drawing.Size)(resources.GetObject("llsrelcommit.Size")));
			this.llsrelcommit.TabIndex = ((int)(resources.GetObject("llsrelcommit.TabIndex")));
			this.llsrelcommit.TabStop = true;
			this.llsrelcommit.Text = resources.GetString("llsrelcommit.Text");
			this.llsrelcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llsrelcommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llsrelcommit, resources.GetString("llsrelcommit.ToolTip"));
			this.llsrelcommit.Visible = ((bool)(resources.GetObject("llsrelcommit.Visible")));
			this.llsrelcommit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RelationshipFileCommit);
			// 
			// gbrelation
			// 
			this.gbrelation.AccessibleDescription = resources.GetString("gbrelation.AccessibleDescription");
			this.gbrelation.AccessibleName = resources.GetString("gbrelation.AccessibleName");
			this.gbrelation.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("gbrelation.Anchor")));
			this.gbrelation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbrelation.BackgroundImage")));
			this.gbrelation.Controls.Add(this.cbbest);
			this.gbrelation.Controls.Add(this.cbfamily);
			this.gbrelation.Controls.Add(this.cbmarried);
			this.gbrelation.Controls.Add(this.cbengaged);
			this.gbrelation.Controls.Add(this.cbsteady);
			this.gbrelation.Controls.Add(this.cblove);
			this.gbrelation.Controls.Add(this.cbcrush);
			this.gbrelation.Controls.Add(this.cbbuddie);
			this.gbrelation.Controls.Add(this.cbfriend);
			this.gbrelation.Controls.Add(this.cbenemy);
			this.gbrelation.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("gbrelation.Dock")));
			this.gbrelation.Enabled = ((bool)(resources.GetObject("gbrelation.Enabled")));
			this.gbrelation.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.gbrelation.Font = ((System.Drawing.Font)(resources.GetObject("gbrelation.Font")));
			this.gbrelation.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("gbrelation.ImeMode")));
			this.gbrelation.Location = ((System.Drawing.Point)(resources.GetObject("gbrelation.Location")));
			this.gbrelation.Name = "gbrelation";
			this.gbrelation.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("gbrelation.RightToLeft")));
			this.gbrelation.Size = ((System.Drawing.Size)(resources.GetObject("gbrelation.Size")));
			this.gbrelation.TabIndex = ((int)(resources.GetObject("gbrelation.TabIndex")));
			this.gbrelation.TabStop = false;
			this.gbrelation.Text = resources.GetString("gbrelation.Text");
			this.toolTip1.SetToolTip(this.gbrelation, resources.GetString("gbrelation.ToolTip"));
			this.gbrelation.Visible = ((bool)(resources.GetObject("gbrelation.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.gbrelation, true);
			// 
			// cbbest
			// 
			this.cbbest.AccessibleDescription = resources.GetString("cbbest.AccessibleDescription");
			this.cbbest.AccessibleName = resources.GetString("cbbest.AccessibleName");
			this.cbbest.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbest.Anchor")));
			this.cbbest.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbest.Appearance")));
			this.cbbest.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbest.BackgroundImage")));
			this.cbbest.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.CheckAlign")));
			this.cbbest.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbest.Dock")));
			this.cbbest.Enabled = ((bool)(resources.GetObject("cbbest.Enabled")));
			this.cbbest.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbest.FlatStyle")));
			this.cbbest.Font = ((System.Drawing.Font)(resources.GetObject("cbbest.Font")));
			this.cbbest.Image = ((System.Drawing.Image)(resources.GetObject("cbbest.Image")));
			this.cbbest.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.ImageAlign")));
			this.cbbest.ImageIndex = ((int)(resources.GetObject("cbbest.ImageIndex")));
			this.cbbest.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbest.ImeMode")));
			this.cbbest.Location = ((System.Drawing.Point)(resources.GetObject("cbbest.Location")));
			this.cbbest.Name = "cbbest";
			this.cbbest.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbest.RightToLeft")));
			this.cbbest.Size = ((System.Drawing.Size)(resources.GetObject("cbbest.Size")));
			this.cbbest.TabIndex = ((int)(resources.GetObject("cbbest.TabIndex")));
			this.cbbest.Text = resources.GetString("cbbest.Text");
			this.cbbest.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbest.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbest, resources.GetString("cbbest.ToolTip"));
			this.cbbest.Visible = ((bool)(resources.GetObject("cbbest.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbest, true);
			// 
			// cbfamily
			// 
			this.cbfamily.AccessibleDescription = resources.GetString("cbfamily.AccessibleDescription");
			this.cbfamily.AccessibleName = resources.GetString("cbfamily.AccessibleName");
			this.cbfamily.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfamily.Anchor")));
			this.cbfamily.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfamily.Appearance")));
			this.cbfamily.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfamily.BackgroundImage")));
			this.cbfamily.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.CheckAlign")));
			this.cbfamily.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfamily.Dock")));
			this.cbfamily.Enabled = ((bool)(resources.GetObject("cbfamily.Enabled")));
			this.cbfamily.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfamily.FlatStyle")));
			this.cbfamily.Font = ((System.Drawing.Font)(resources.GetObject("cbfamily.Font")));
			this.cbfamily.Image = ((System.Drawing.Image)(resources.GetObject("cbfamily.Image")));
			this.cbfamily.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.ImageAlign")));
			this.cbfamily.ImageIndex = ((int)(resources.GetObject("cbfamily.ImageIndex")));
			this.cbfamily.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfamily.ImeMode")));
			this.cbfamily.Location = ((System.Drawing.Point)(resources.GetObject("cbfamily.Location")));
			this.cbfamily.Name = "cbfamily";
			this.cbfamily.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfamily.RightToLeft")));
			this.cbfamily.Size = ((System.Drawing.Size)(resources.GetObject("cbfamily.Size")));
			this.cbfamily.TabIndex = ((int)(resources.GetObject("cbfamily.TabIndex")));
			this.cbfamily.Text = resources.GetString("cbfamily.Text");
			this.cbfamily.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfamily.TextAlign")));
			this.toolTip1.SetToolTip(this.cbfamily, resources.GetString("cbfamily.ToolTip"));
			this.cbfamily.Visible = ((bool)(resources.GetObject("cbfamily.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfamily, true);
			// 
			// cbmarried
			// 
			this.cbmarried.AccessibleDescription = resources.GetString("cbmarried.AccessibleDescription");
			this.cbmarried.AccessibleName = resources.GetString("cbmarried.AccessibleName");
			this.cbmarried.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbmarried.Anchor")));
			this.cbmarried.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbmarried.Appearance")));
			this.cbmarried.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbmarried.BackgroundImage")));
			this.cbmarried.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.CheckAlign")));
			this.cbmarried.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbmarried.Dock")));
			this.cbmarried.Enabled = ((bool)(resources.GetObject("cbmarried.Enabled")));
			this.cbmarried.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbmarried.FlatStyle")));
			this.cbmarried.Font = ((System.Drawing.Font)(resources.GetObject("cbmarried.Font")));
			this.cbmarried.Image = ((System.Drawing.Image)(resources.GetObject("cbmarried.Image")));
			this.cbmarried.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.ImageAlign")));
			this.cbmarried.ImageIndex = ((int)(resources.GetObject("cbmarried.ImageIndex")));
			this.cbmarried.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbmarried.ImeMode")));
			this.cbmarried.Location = ((System.Drawing.Point)(resources.GetObject("cbmarried.Location")));
			this.cbmarried.Name = "cbmarried";
			this.cbmarried.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbmarried.RightToLeft")));
			this.cbmarried.Size = ((System.Drawing.Size)(resources.GetObject("cbmarried.Size")));
			this.cbmarried.TabIndex = ((int)(resources.GetObject("cbmarried.TabIndex")));
			this.cbmarried.Text = resources.GetString("cbmarried.Text");
			this.cbmarried.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbmarried.TextAlign")));
			this.toolTip1.SetToolTip(this.cbmarried, resources.GetString("cbmarried.ToolTip"));
			this.cbmarried.Visible = ((bool)(resources.GetObject("cbmarried.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbmarried, true);
			// 
			// cbengaged
			// 
			this.cbengaged.AccessibleDescription = resources.GetString("cbengaged.AccessibleDescription");
			this.cbengaged.AccessibleName = resources.GetString("cbengaged.AccessibleName");
			this.cbengaged.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbengaged.Anchor")));
			this.cbengaged.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbengaged.Appearance")));
			this.cbengaged.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbengaged.BackgroundImage")));
			this.cbengaged.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.CheckAlign")));
			this.cbengaged.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbengaged.Dock")));
			this.cbengaged.Enabled = ((bool)(resources.GetObject("cbengaged.Enabled")));
			this.cbengaged.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbengaged.FlatStyle")));
			this.cbengaged.Font = ((System.Drawing.Font)(resources.GetObject("cbengaged.Font")));
			this.cbengaged.Image = ((System.Drawing.Image)(resources.GetObject("cbengaged.Image")));
			this.cbengaged.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.ImageAlign")));
			this.cbengaged.ImageIndex = ((int)(resources.GetObject("cbengaged.ImageIndex")));
			this.cbengaged.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbengaged.ImeMode")));
			this.cbengaged.Location = ((System.Drawing.Point)(resources.GetObject("cbengaged.Location")));
			this.cbengaged.Name = "cbengaged";
			this.cbengaged.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbengaged.RightToLeft")));
			this.cbengaged.Size = ((System.Drawing.Size)(resources.GetObject("cbengaged.Size")));
			this.cbengaged.TabIndex = ((int)(resources.GetObject("cbengaged.TabIndex")));
			this.cbengaged.Text = resources.GetString("cbengaged.Text");
			this.cbengaged.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbengaged.TextAlign")));
			this.toolTip1.SetToolTip(this.cbengaged, resources.GetString("cbengaged.ToolTip"));
			this.cbengaged.Visible = ((bool)(resources.GetObject("cbengaged.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbengaged, true);
			// 
			// cbsteady
			// 
			this.cbsteady.AccessibleDescription = resources.GetString("cbsteady.AccessibleDescription");
			this.cbsteady.AccessibleName = resources.GetString("cbsteady.AccessibleName");
			this.cbsteady.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbsteady.Anchor")));
			this.cbsteady.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbsteady.Appearance")));
			this.cbsteady.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbsteady.BackgroundImage")));
			this.cbsteady.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.CheckAlign")));
			this.cbsteady.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbsteady.Dock")));
			this.cbsteady.Enabled = ((bool)(resources.GetObject("cbsteady.Enabled")));
			this.cbsteady.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbsteady.FlatStyle")));
			this.cbsteady.Font = ((System.Drawing.Font)(resources.GetObject("cbsteady.Font")));
			this.cbsteady.Image = ((System.Drawing.Image)(resources.GetObject("cbsteady.Image")));
			this.cbsteady.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.ImageAlign")));
			this.cbsteady.ImageIndex = ((int)(resources.GetObject("cbsteady.ImageIndex")));
			this.cbsteady.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbsteady.ImeMode")));
			this.cbsteady.Location = ((System.Drawing.Point)(resources.GetObject("cbsteady.Location")));
			this.cbsteady.Name = "cbsteady";
			this.cbsteady.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbsteady.RightToLeft")));
			this.cbsteady.Size = ((System.Drawing.Size)(resources.GetObject("cbsteady.Size")));
			this.cbsteady.TabIndex = ((int)(resources.GetObject("cbsteady.TabIndex")));
			this.cbsteady.Text = resources.GetString("cbsteady.Text");
			this.cbsteady.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbsteady.TextAlign")));
			this.toolTip1.SetToolTip(this.cbsteady, resources.GetString("cbsteady.ToolTip"));
			this.cbsteady.Visible = ((bool)(resources.GetObject("cbsteady.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbsteady, true);
			// 
			// cblove
			// 
			this.cblove.AccessibleDescription = resources.GetString("cblove.AccessibleDescription");
			this.cblove.AccessibleName = resources.GetString("cblove.AccessibleName");
			this.cblove.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cblove.Anchor")));
			this.cblove.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cblove.Appearance")));
			this.cblove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cblove.BackgroundImage")));
			this.cblove.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.CheckAlign")));
			this.cblove.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cblove.Dock")));
			this.cblove.Enabled = ((bool)(resources.GetObject("cblove.Enabled")));
			this.cblove.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cblove.FlatStyle")));
			this.cblove.Font = ((System.Drawing.Font)(resources.GetObject("cblove.Font")));
			this.cblove.Image = ((System.Drawing.Image)(resources.GetObject("cblove.Image")));
			this.cblove.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.ImageAlign")));
			this.cblove.ImageIndex = ((int)(resources.GetObject("cblove.ImageIndex")));
			this.cblove.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cblove.ImeMode")));
			this.cblove.Location = ((System.Drawing.Point)(resources.GetObject("cblove.Location")));
			this.cblove.Name = "cblove";
			this.cblove.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cblove.RightToLeft")));
			this.cblove.Size = ((System.Drawing.Size)(resources.GetObject("cblove.Size")));
			this.cblove.TabIndex = ((int)(resources.GetObject("cblove.TabIndex")));
			this.cblove.Text = resources.GetString("cblove.Text");
			this.cblove.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cblove.TextAlign")));
			this.toolTip1.SetToolTip(this.cblove, resources.GetString("cblove.ToolTip"));
			this.cblove.Visible = ((bool)(resources.GetObject("cblove.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cblove, true);
			// 
			// cbcrush
			// 
			this.cbcrush.AccessibleDescription = resources.GetString("cbcrush.AccessibleDescription");
			this.cbcrush.AccessibleName = resources.GetString("cbcrush.AccessibleName");
			this.cbcrush.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbcrush.Anchor")));
			this.cbcrush.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbcrush.Appearance")));
			this.cbcrush.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbcrush.BackgroundImage")));
			this.cbcrush.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.CheckAlign")));
			this.cbcrush.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbcrush.Dock")));
			this.cbcrush.Enabled = ((bool)(resources.GetObject("cbcrush.Enabled")));
			this.cbcrush.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbcrush.FlatStyle")));
			this.cbcrush.Font = ((System.Drawing.Font)(resources.GetObject("cbcrush.Font")));
			this.cbcrush.Image = ((System.Drawing.Image)(resources.GetObject("cbcrush.Image")));
			this.cbcrush.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.ImageAlign")));
			this.cbcrush.ImageIndex = ((int)(resources.GetObject("cbcrush.ImageIndex")));
			this.cbcrush.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbcrush.ImeMode")));
			this.cbcrush.Location = ((System.Drawing.Point)(resources.GetObject("cbcrush.Location")));
			this.cbcrush.Name = "cbcrush";
			this.cbcrush.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbcrush.RightToLeft")));
			this.cbcrush.Size = ((System.Drawing.Size)(resources.GetObject("cbcrush.Size")));
			this.cbcrush.TabIndex = ((int)(resources.GetObject("cbcrush.TabIndex")));
			this.cbcrush.Text = resources.GetString("cbcrush.Text");
			this.cbcrush.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbcrush.TextAlign")));
			this.toolTip1.SetToolTip(this.cbcrush, resources.GetString("cbcrush.ToolTip"));
			this.cbcrush.Visible = ((bool)(resources.GetObject("cbcrush.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbcrush, true);
			// 
			// cbbuddie
			// 
			this.cbbuddie.AccessibleDescription = resources.GetString("cbbuddie.AccessibleDescription");
			this.cbbuddie.AccessibleName = resources.GetString("cbbuddie.AccessibleName");
			this.cbbuddie.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbbuddie.Anchor")));
			this.cbbuddie.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbbuddie.Appearance")));
			this.cbbuddie.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbbuddie.BackgroundImage")));
			this.cbbuddie.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.CheckAlign")));
			this.cbbuddie.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbbuddie.Dock")));
			this.cbbuddie.Enabled = ((bool)(resources.GetObject("cbbuddie.Enabled")));
			this.cbbuddie.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbbuddie.FlatStyle")));
			this.cbbuddie.Font = ((System.Drawing.Font)(resources.GetObject("cbbuddie.Font")));
			this.cbbuddie.Image = ((System.Drawing.Image)(resources.GetObject("cbbuddie.Image")));
			this.cbbuddie.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.ImageAlign")));
			this.cbbuddie.ImageIndex = ((int)(resources.GetObject("cbbuddie.ImageIndex")));
			this.cbbuddie.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbbuddie.ImeMode")));
			this.cbbuddie.Location = ((System.Drawing.Point)(resources.GetObject("cbbuddie.Location")));
			this.cbbuddie.Name = "cbbuddie";
			this.cbbuddie.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbbuddie.RightToLeft")));
			this.cbbuddie.Size = ((System.Drawing.Size)(resources.GetObject("cbbuddie.Size")));
			this.cbbuddie.TabIndex = ((int)(resources.GetObject("cbbuddie.TabIndex")));
			this.cbbuddie.Text = resources.GetString("cbbuddie.Text");
			this.cbbuddie.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbbuddie.TextAlign")));
			this.toolTip1.SetToolTip(this.cbbuddie, resources.GetString("cbbuddie.ToolTip"));
			this.cbbuddie.Visible = ((bool)(resources.GetObject("cbbuddie.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbbuddie, true);
			// 
			// cbfriend
			// 
			this.cbfriend.AccessibleDescription = resources.GetString("cbfriend.AccessibleDescription");
			this.cbfriend.AccessibleName = resources.GetString("cbfriend.AccessibleName");
			this.cbfriend.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbfriend.Anchor")));
			this.cbfriend.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbfriend.Appearance")));
			this.cbfriend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbfriend.BackgroundImage")));
			this.cbfriend.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.CheckAlign")));
			this.cbfriend.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbfriend.Dock")));
			this.cbfriend.Enabled = ((bool)(resources.GetObject("cbfriend.Enabled")));
			this.cbfriend.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbfriend.FlatStyle")));
			this.cbfriend.Font = ((System.Drawing.Font)(resources.GetObject("cbfriend.Font")));
			this.cbfriend.Image = ((System.Drawing.Image)(resources.GetObject("cbfriend.Image")));
			this.cbfriend.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.ImageAlign")));
			this.cbfriend.ImageIndex = ((int)(resources.GetObject("cbfriend.ImageIndex")));
			this.cbfriend.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbfriend.ImeMode")));
			this.cbfriend.Location = ((System.Drawing.Point)(resources.GetObject("cbfriend.Location")));
			this.cbfriend.Name = "cbfriend";
			this.cbfriend.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbfriend.RightToLeft")));
			this.cbfriend.Size = ((System.Drawing.Size)(resources.GetObject("cbfriend.Size")));
			this.cbfriend.TabIndex = ((int)(resources.GetObject("cbfriend.TabIndex")));
			this.cbfriend.Text = resources.GetString("cbfriend.Text");
			this.cbfriend.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbfriend.TextAlign")));
			this.toolTip1.SetToolTip(this.cbfriend, resources.GetString("cbfriend.ToolTip"));
			this.cbfriend.Visible = ((bool)(resources.GetObject("cbfriend.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbfriend, true);
			// 
			// cbenemy
			// 
			this.cbenemy.AccessibleDescription = resources.GetString("cbenemy.AccessibleDescription");
			this.cbenemy.AccessibleName = resources.GetString("cbenemy.AccessibleName");
			this.cbenemy.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("cbenemy.Anchor")));
			this.cbenemy.Appearance = ((System.Windows.Forms.Appearance)(resources.GetObject("cbenemy.Appearance")));
			this.cbenemy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cbenemy.BackgroundImage")));
			this.cbenemy.CheckAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.CheckAlign")));
			this.cbenemy.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("cbenemy.Dock")));
			this.cbenemy.Enabled = ((bool)(resources.GetObject("cbenemy.Enabled")));
			this.cbenemy.FlatStyle = ((System.Windows.Forms.FlatStyle)(resources.GetObject("cbenemy.FlatStyle")));
			this.cbenemy.Font = ((System.Drawing.Font)(resources.GetObject("cbenemy.Font")));
			this.cbenemy.Image = ((System.Drawing.Image)(resources.GetObject("cbenemy.Image")));
			this.cbenemy.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.ImageAlign")));
			this.cbenemy.ImageIndex = ((int)(resources.GetObject("cbenemy.ImageIndex")));
			this.cbenemy.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("cbenemy.ImeMode")));
			this.cbenemy.Location = ((System.Drawing.Point)(resources.GetObject("cbenemy.Location")));
			this.cbenemy.Name = "cbenemy";
			this.cbenemy.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("cbenemy.RightToLeft")));
			this.cbenemy.Size = ((System.Drawing.Size)(resources.GetObject("cbenemy.Size")));
			this.cbenemy.TabIndex = ((int)(resources.GetObject("cbenemy.TabIndex")));
			this.cbenemy.Text = resources.GetString("cbenemy.Text");
			this.cbenemy.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("cbenemy.TextAlign")));
			this.toolTip1.SetToolTip(this.cbenemy, resources.GetString("cbenemy.ToolTip"));
			this.cbenemy.Visible = ((bool)(resources.GetObject("cbenemy.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.cbenemy, true);
			// 
			// tblongterm
			// 
			this.tblongterm.AccessibleDescription = resources.GetString("tblongterm.AccessibleDescription");
			this.tblongterm.AccessibleName = resources.GetString("tblongterm.AccessibleName");
			this.tblongterm.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tblongterm.Anchor")));
			this.tblongterm.AutoSize = ((bool)(resources.GetObject("tblongterm.AutoSize")));
			this.tblongterm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblongterm.BackgroundImage")));
			this.tblongterm.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tblongterm.Dock")));
			this.tblongterm.Enabled = ((bool)(resources.GetObject("tblongterm.Enabled")));
			this.tblongterm.Font = ((System.Drawing.Font)(resources.GetObject("tblongterm.Font")));
			this.tblongterm.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tblongterm.ImeMode")));
			this.tblongterm.Location = ((System.Drawing.Point)(resources.GetObject("tblongterm.Location")));
			this.tblongterm.MaxLength = ((int)(resources.GetObject("tblongterm.MaxLength")));
			this.tblongterm.Multiline = ((bool)(resources.GetObject("tblongterm.Multiline")));
			this.tblongterm.Name = "tblongterm";
			this.tblongterm.PasswordChar = ((char)(resources.GetObject("tblongterm.PasswordChar")));
			this.tblongterm.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tblongterm.RightToLeft")));
			this.tblongterm.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tblongterm.ScrollBars")));
			this.tblongterm.Size = ((System.Drawing.Size)(resources.GetObject("tblongterm.Size")));
			this.tblongterm.TabIndex = ((int)(resources.GetObject("tblongterm.TabIndex")));
			this.tblongterm.Text = resources.GetString("tblongterm.Text");
			this.tblongterm.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tblongterm.TextAlign")));
			this.toolTip1.SetToolTip(this.tblongterm, resources.GetString("tblongterm.ToolTip"));
			this.tblongterm.Visible = ((bool)(resources.GetObject("tblongterm.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tblongterm, true);
			this.tblongterm.WordWrap = ((bool)(resources.GetObject("tblongterm.WordWrap")));
			// 
			// tbshortterm
			// 
			this.tbshortterm.AccessibleDescription = resources.GetString("tbshortterm.AccessibleDescription");
			this.tbshortterm.AccessibleName = resources.GetString("tbshortterm.AccessibleName");
			this.tbshortterm.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("tbshortterm.Anchor")));
			this.tbshortterm.AutoSize = ((bool)(resources.GetObject("tbshortterm.AutoSize")));
			this.tbshortterm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbshortterm.BackgroundImage")));
			this.tbshortterm.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("tbshortterm.Dock")));
			this.tbshortterm.Enabled = ((bool)(resources.GetObject("tbshortterm.Enabled")));
			this.tbshortterm.Font = ((System.Drawing.Font)(resources.GetObject("tbshortterm.Font")));
			this.tbshortterm.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("tbshortterm.ImeMode")));
			this.tbshortterm.Location = ((System.Drawing.Point)(resources.GetObject("tbshortterm.Location")));
			this.tbshortterm.MaxLength = ((int)(resources.GetObject("tbshortterm.MaxLength")));
			this.tbshortterm.Multiline = ((bool)(resources.GetObject("tbshortterm.Multiline")));
			this.tbshortterm.Name = "tbshortterm";
			this.tbshortterm.PasswordChar = ((char)(resources.GetObject("tbshortterm.PasswordChar")));
			this.tbshortterm.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("tbshortterm.RightToLeft")));
			this.tbshortterm.ScrollBars = ((System.Windows.Forms.ScrollBars)(resources.GetObject("tbshortterm.ScrollBars")));
			this.tbshortterm.Size = ((System.Drawing.Size)(resources.GetObject("tbshortterm.Size")));
			this.tbshortterm.TabIndex = ((int)(resources.GetObject("tbshortterm.TabIndex")));
			this.tbshortterm.Text = resources.GetString("tbshortterm.Text");
			this.tbshortterm.TextAlign = ((System.Windows.Forms.HorizontalAlignment)(resources.GetObject("tbshortterm.TextAlign")));
			this.toolTip1.SetToolTip(this.tbshortterm, resources.GetString("tbshortterm.ToolTip"));
			this.tbshortterm.Visible = ((bool)(resources.GetObject("tbshortterm.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.tbshortterm, true);
			this.tbshortterm.WordWrap = ((bool)(resources.GetObject("tbshortterm.WordWrap")));
			// 
			// label57
			// 
			this.label57.AccessibleDescription = resources.GetString("label57.AccessibleDescription");
			this.label57.AccessibleName = resources.GetString("label57.AccessibleName");
			this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label57.Anchor")));
			this.label57.AutoSize = ((bool)(resources.GetObject("label57.AutoSize")));
			this.label57.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label57.Dock")));
			this.label57.Enabled = ((bool)(resources.GetObject("label57.Enabled")));
			this.label57.Font = ((System.Drawing.Font)(resources.GetObject("label57.Font")));
			this.label57.Image = ((System.Drawing.Image)(resources.GetObject("label57.Image")));
			this.label57.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label57.ImageAlign")));
			this.label57.ImageIndex = ((int)(resources.GetObject("label57.ImageIndex")));
			this.label57.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label57.ImeMode")));
			this.label57.Location = ((System.Drawing.Point)(resources.GetObject("label57.Location")));
			this.label57.Name = "label57";
			this.label57.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label57.RightToLeft")));
			this.label57.Size = ((System.Drawing.Size)(resources.GetObject("label57.Size")));
			this.label57.TabIndex = ((int)(resources.GetObject("label57.TabIndex")));
			this.label57.Text = resources.GetString("label57.Text");
			this.label57.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label57.TextAlign")));
			this.toolTip1.SetToolTip(this.label57, resources.GetString("label57.ToolTip"));
			this.label57.Visible = ((bool)(resources.GetObject("label57.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label57, true);
			// 
			// label58
			// 
			this.label58.AccessibleDescription = resources.GetString("label58.AccessibleDescription");
			this.label58.AccessibleName = resources.GetString("label58.AccessibleName");
			this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label58.Anchor")));
			this.label58.AutoSize = ((bool)(resources.GetObject("label58.AutoSize")));
			this.label58.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label58.Dock")));
			this.label58.Enabled = ((bool)(resources.GetObject("label58.Enabled")));
			this.label58.Font = ((System.Drawing.Font)(resources.GetObject("label58.Font")));
			this.label58.Image = ((System.Drawing.Image)(resources.GetObject("label58.Image")));
			this.label58.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label58.ImageAlign")));
			this.label58.ImageIndex = ((int)(resources.GetObject("label58.ImageIndex")));
			this.label58.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label58.ImeMode")));
			this.label58.Location = ((System.Drawing.Point)(resources.GetObject("label58.Location")));
			this.label58.Name = "label58";
			this.label58.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label58.RightToLeft")));
			this.label58.Size = ((System.Drawing.Size)(resources.GetObject("label58.Size")));
			this.label58.TabIndex = ((int)(resources.GetObject("label58.TabIndex")));
			this.label58.Text = resources.GetString("label58.Text");
			this.label58.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label58.TextAlign")));
			this.toolTip1.SetToolTip(this.label58, resources.GetString("label58.ToolTip"));
			this.label58.Visible = ((bool)(resources.GetObject("label58.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label58, true);
			// 
			// panel7
			// 
			this.panel7.AccessibleDescription = resources.GetString("panel7.AccessibleDescription");
			this.panel7.AccessibleName = resources.GetString("panel7.AccessibleName");
			this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("panel7.Anchor")));
			this.panel7.AutoScroll = ((bool)(resources.GetObject("panel7.AutoScroll")));
			this.panel7.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("panel7.AutoScrollMargin")));
			this.panel7.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("panel7.AutoScrollMinSize")));
			this.panel7.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.panel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel7.BackgroundImage")));
			this.panel7.Controls.Add(this.label56);
			this.panel7.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("panel7.Dock")));
			this.panel7.Enabled = ((bool)(resources.GetObject("panel7.Enabled")));
			this.panel7.Font = ((System.Drawing.Font)(resources.GetObject("panel7.Font")));
			this.panel7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.panel7.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("panel7.ImeMode")));
			this.panel7.Location = ((System.Drawing.Point)(resources.GetObject("panel7.Location")));
			this.panel7.Name = "panel7";
			this.panel7.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("panel7.RightToLeft")));
			this.panel7.Size = ((System.Drawing.Size)(resources.GetObject("panel7.Size")));
			this.panel7.TabIndex = ((int)(resources.GetObject("panel7.TabIndex")));
			this.panel7.Text = resources.GetString("panel7.Text");
			this.toolTip1.SetToolTip(this.panel7, resources.GetString("panel7.ToolTip"));
			this.panel7.Visible = ((bool)(resources.GetObject("panel7.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.panel7, true);
			// 
			// label56
			// 
			this.label56.AccessibleDescription = resources.GetString("label56.AccessibleDescription");
			this.label56.AccessibleName = resources.GetString("label56.AccessibleName");
			this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("label56.Anchor")));
			this.label56.AutoSize = ((bool)(resources.GetObject("label56.AutoSize")));
			this.label56.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("label56.Dock")));
			this.label56.Enabled = ((bool)(resources.GetObject("label56.Enabled")));
			this.label56.Font = ((System.Drawing.Font)(resources.GetObject("label56.Font")));
			this.label56.Image = ((System.Drawing.Image)(resources.GetObject("label56.Image")));
			this.label56.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label56.ImageAlign")));
			this.label56.ImageIndex = ((int)(resources.GetObject("label56.ImageIndex")));
			this.label56.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("label56.ImeMode")));
			this.label56.Location = ((System.Drawing.Point)(resources.GetObject("label56.Location")));
			this.label56.Name = "label56";
			this.label56.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("label56.RightToLeft")));
			this.label56.Size = ((System.Drawing.Size)(resources.GetObject("label56.Size")));
			this.label56.TabIndex = ((int)(resources.GetObject("label56.TabIndex")));
			this.label56.Text = resources.GetString("label56.Text");
			this.label56.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("label56.TextAlign")));
			this.toolTip1.SetToolTip(this.label56, resources.GetString("label56.ToolTip"));
			this.label56.Visible = ((bool)(resources.GetObject("label56.Visible")));
			this.visualStyleProvider1.SetVisualStyleSupport(this.label56, true);
			// 
			// llrelcommit
			// 
			this.llrelcommit.AccessibleDescription = resources.GetString("llrelcommit.AccessibleDescription");
			this.llrelcommit.AccessibleName = resources.GetString("llrelcommit.AccessibleName");
			this.llrelcommit.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llrelcommit.Anchor")));
			this.llrelcommit.AutoSize = ((bool)(resources.GetObject("llrelcommit.AutoSize")));
			this.llrelcommit.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llrelcommit.Dock")));
			this.llrelcommit.Enabled = ((bool)(resources.GetObject("llrelcommit.Enabled")));
			this.llrelcommit.Font = ((System.Drawing.Font)(resources.GetObject("llrelcommit.Font")));
			this.llrelcommit.Image = ((System.Drawing.Image)(resources.GetObject("llrelcommit.Image")));
			this.llrelcommit.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrelcommit.ImageAlign")));
			this.llrelcommit.ImageIndex = ((int)(resources.GetObject("llrelcommit.ImageIndex")));
			this.llrelcommit.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llrelcommit.ImeMode")));
			this.llrelcommit.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llrelcommit.LinkArea")));
			this.llrelcommit.Location = ((System.Drawing.Point)(resources.GetObject("llrelcommit.Location")));
			this.llrelcommit.Name = "llrelcommit";
			this.llrelcommit.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llrelcommit.RightToLeft")));
			this.llrelcommit.Size = ((System.Drawing.Size)(resources.GetObject("llrelcommit.Size")));
			this.llrelcommit.TabIndex = ((int)(resources.GetObject("llrelcommit.TabIndex")));
			this.llrelcommit.Text = resources.GetString("llrelcommit.Text");
			this.llrelcommit.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llrelcommit.TextAlign")));
			this.toolTip1.SetToolTip(this.llrelcommit, resources.GetString("llrelcommit.ToolTip"));
			this.llrelcommit.Visible = ((bool)(resources.GetObject("llrelcommit.Visible")));
			// 
			// llmore
			// 
			this.llmore.AccessibleDescription = resources.GetString("llmore.AccessibleDescription");
			this.llmore.AccessibleName = resources.GetString("llmore.AccessibleName");
			this.llmore.Anchor = ((System.Windows.Forms.AnchorStyles)(resources.GetObject("llmore.Anchor")));
			this.llmore.AutoSize = ((bool)(resources.GetObject("llmore.AutoSize")));
			this.llmore.Dock = ((System.Windows.Forms.DockStyle)(resources.GetObject("llmore.Dock")));
			this.llmore.Enabled = ((bool)(resources.GetObject("llmore.Enabled")));
			this.llmore.Font = ((System.Drawing.Font)(resources.GetObject("llmore.Font")));
			this.llmore.Image = ((System.Drawing.Image)(resources.GetObject("llmore.Image")));
			this.llmore.ImageAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmore.ImageAlign")));
			this.llmore.ImageIndex = ((int)(resources.GetObject("llmore.ImageIndex")));
			this.llmore.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("llmore.ImeMode")));
			this.llmore.LinkArea = ((System.Windows.Forms.LinkArea)(resources.GetObject("llmore.LinkArea")));
			this.llmore.Location = ((System.Drawing.Point)(resources.GetObject("llmore.Location")));
			this.llmore.Name = "llmore";
			this.llmore.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("llmore.RightToLeft")));
			this.llmore.Size = ((System.Drawing.Size)(resources.GetObject("llmore.Size")));
			this.llmore.TabIndex = ((int)(resources.GetObject("llmore.TabIndex")));
			this.llmore.TabStop = true;
			this.llmore.Text = resources.GetString("llmore.Text");
			this.llmore.TextAlign = ((System.Drawing.ContentAlignment)(resources.GetObject("llmore.TextAlign")));
			this.toolTip1.SetToolTip(this.llmore, resources.GetString("llmore.ToolTip"));
			this.llmore.Visible = ((bool)(resources.GetObject("llmore.Visible")));
			this.llmore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SdscShowMore);
			// 
			// Elements
			// 
			this.AccessibleDescription = resources.GetString("$this.AccessibleDescription");
			this.AccessibleName = resources.GetString("$this.AccessibleName");
			this.AutoScaleBaseSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScaleBaseSize")));
			this.AutoScroll = ((bool)(resources.GetObject("$this.AutoScroll")));
			this.AutoScrollMargin = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMargin")));
			this.AutoScrollMinSize = ((System.Drawing.Size)(resources.GetObject("$this.AutoScrollMinSize")));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = ((System.Drawing.Size)(resources.GetObject("$this.ClientSize")));
			this.Controls.Add(this.tabControl1);
			this.Enabled = ((bool)(resources.GetObject("$this.Enabled")));
			this.Font = ((System.Drawing.Font)(resources.GetObject("$this.Font")));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("$this.ImeMode")));
			this.Location = ((System.Drawing.Point)(resources.GetObject("$this.Location")));
			this.MaximumSize = ((System.Drawing.Size)(resources.GetObject("$this.MaximumSize")));
			this.MinimumSize = ((System.Drawing.Size)(resources.GetObject("$this.MinimumSize")));
			this.Name = "Elements";
			this.RightToLeft = ((System.Windows.Forms.RightToLeft)(resources.GetObject("$this.RightToLeft")));
			this.StartPosition = ((System.Windows.Forms.FormStartPosition)(resources.GetObject("$this.StartPosition")));
			this.Text = resources.GetString("$this.Text");
			this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
			this.JpegPanel.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.xmlPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.objdPanel.ResumeLayout(false);
			this.gbelements.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage4.ResumeLayout(false);
			this.familytiePanel.ResumeLayout(false);
			this.gbties.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.famiPanel.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.sdescPanel.ResumeLayout(false);
			this.tcsdesc.ResumeLayout(false);
			this.tpinterests.ResumeLayout(false);
			this.tbcharacter.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.gbcareer.ResumeLayout(false);
			this.gblifeline.ResumeLayout(false);
			this.gbcharacter.ResumeLayout(false);
			this.gbgencharacter.ResumeLayout(false);
			this.gbschool.ResumeLayout(false);
			this.tbrelations.ResumeLayout(false);
			this.gb.ResumeLayout(false);
			this.gbout.ResumeLayout(false);
			this.gbin.ResumeLayout(false);
			this.tbskills.ResumeLayout(false);
			this.gbskills.ResumeLayout(false);
			this.tbext.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.gbdecay.ResumeLayout(false);
			this.tbuni.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.realPanel.ResumeLayout(false);
			this.gbrelation.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void CommitFamiClick(object sender, System.EventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					SimPe.PackedFiles.Wrapper.Fami fami = (Wrapper.Fami)wrapper;
					fami.Money = Convert.ToInt32(tbmoney.Text);
					fami.Friends = Convert.ToUInt32(tbfamily.Text);
					fami.Flags = Convert.ToUInt32(tbflag.Text, 16);
					fami.AlbumGUID = Convert.ToUInt32(tbalbum.Text, 16);
					fami.SubHoodNumber = Convert.ToUInt32(tbsubhood.Text, 16);

					uint[] members = new uint[lbmembers.Items.Count];
					for (int i=0; i< members.Length; i++) 
					{
						members[i] = ((SimPe.Interfaces.IAlias)lbmembers.Items[i]).Id;
						SimPe.PackedFiles.Wrapper.SDesc sdesc = fami.GetDescriptionFile(members[i]);
						sdesc.FamilyInstance = (ushort)fami.FileDescriptor.Instance;
						sdesc.SynchronizeUserData();
					}
					fami.Members = members;

					fami.LotInstance = Convert.ToUInt32(this.tblotinst.Text, 16);
					//name was changed
					if (tbname.Text != fami.Name) fami.Name = tbname.Text;

					wrapper.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				}
				catch (Exception ex) {
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitfamily"), ex);
				}
				finally 
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void CommitXmlClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.Xml xml = (Wrapper.Xml)wrapper;
					xml.Text = rtb.Text;
					wrapper.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				} 
				catch (Exception) {}
			}
		}

		private void CommitSDescClick(object sender, System.EventArgs e)
		{
			SimRelationCommit(null, null);
			if (wrapper!=null) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					SimPe.PackedFiles.Wrapper.SDesc sdesc = (Wrapper.SDesc)wrapper;
					sdesc.CharacterDescription.Age = Convert.ToUInt16(tbage.Text);
					sdesc.SimId = Convert.ToUInt32(tbsim.Text, 16);

					//Random Data
					if (this.cbaspiration.SelectedIndex != -1) sdesc.CharacterDescription.Aspiration = (Data.LocalizedAspirationTypes)cbaspiration.Items[cbaspiration.SelectedIndex];
					if (this.cbzodiac.SelectedIndex != -1) sdesc.CharacterDescription.ZodiacSign = (Data.LocalizedZodiacSignes)cbzodiac.Items[cbzodiac.SelectedIndex];
					if (this.cblifesection.SelectedIndex != -1) sdesc.CharacterDescription.LifeSection = (Data.LocalizedLifeSections)cblifesection.Items[cblifesection.SelectedIndex];
					if (rbfemale.Checked) sdesc.CharacterDescription.Gender = Data.MetaData.Gender.Female;
					else sdesc.CharacterDescription.Gender = Data.MetaData.Gender.Male;					
					sdesc.CharacterDescription.LifelinePoints = (short)(pblifelinepoints.Value - 600);
					sdesc.CharacterDescription.BlizLifelinePoints = (ushort)pbblizlifelinepoints.Value;
					sdesc.CharacterDescription.CareerPerformance = (short)(pbjobperformance.Value - 1000);
					sdesc.CharacterDescription.VoiceType = Convert.ToUInt16(tbvoice.Text, 16);
					sdesc.CharacterDescription.PrevAgeDays = Convert.ToUInt16(tbprevdays.Text);
					sdesc.CharacterDescription.AgeDuration = Convert.ToUInt16(tbagedur.Text);
					sdesc.Unlinked = Convert.ToUInt16(tbunlinked.Text, 16);
					try { 
						sdesc.FamilyInstance = Convert.ToUInt16(this.tbfaminst.Text, 16);
						sdesc.CharacterDescription.LifelineScore = Convert.ToUInt32(tblifelinescore.Text); 
						if (this.cbschooltype.SelectedIndex==0) sdesc.CharacterDescription.SchoolType = (Data.MetaData.SchoolTypes)Convert.ToUInt32(tbschooltype.Text, 16);
						else if (cbschooltype.SelectedIndex>0) 
						{
							Data.MetaData.SchoolTypes type;
							object o = cbschooltype.Items[cbschooltype.SelectedIndex];
							if (o.GetType()==typeof(Data.Alias)) type = (Data.LocalizedSchoolType)((uint)((Data.Alias)o).Id); 
							else type = (Data.LocalizedSchoolType)o;
							sdesc.CharacterDescription.SchoolType = type;
						}
						sdesc.CharacterDescription.CareerLevel = Convert.ToUInt16(this.tbcarrerlevel.Text);

						if (cbgrade.SelectedIndex>=0) sdesc.CharacterDescription.Grade = (Data.LocalizedGrades)cbgrade.Items[cbgrade.SelectedIndex];
						sdesc.CharacterDescription.AutonomyLevel = Convert.ToUInt16(tbautonomy.Text, 16);
						sdesc.CharacterDescription.NPCType = Convert.ToUInt16(tbnpc.Text, 16);
					} catch (Exception) {}

					//University Stuff
					try { 	
						sdesc.University.Major = (Data.Majors)Convert.ToUInt32(tbmajor.Text, 16);												
						sdesc.University.Semester = Convert.ToUInt16(tbsemester.Text);
						sdesc.University.Influence = Convert.ToUInt16(tbinfluence.Text);
					} catch (Exception) {}

					if (cboncampus.Checked) sdesc.University.OnCampus = 0x01; else if (sdesc.University.OnCampus==0x01) sdesc.University.OnCampus = 0;
					sdesc.University.Time = (ushort)pbunitime.Value;
					sdesc.University.Effort = (ushort)pbeffort.Value;
					sdesc.University.Grade = (ushort)((pblastgrade.Maximum - this.pblastgrade.Value) * (1000 / (this.pblastgrade.Maximum-pblastgrade.Minimum)));

					//Career
					try { sdesc.CharacterDescription.Career = (Data.LocalizedCareers)Helper.HexStringToUInt(tbcareervalue.Text); } catch (Exception) {}
					

					//ghost flags
					sdesc.CharacterDescription.GhostFlag.IsGhost = cbisghost.Checked;
					sdesc.CharacterDescription.GhostFlag.CanPassThroughObjects = cbpassobject.Checked;
					sdesc.CharacterDescription.GhostFlag.CanPassThroughWalls = cbpasswalls.Checked;
					sdesc.CharacterDescription.GhostFlag.CanPassThroughPeople = cbpasspeople.Checked;
					sdesc.CharacterDescription.GhostFlag.IgnoreTraversalCosts = cbignoretraversal.Checked;

					//body flags
					sdesc.CharacterDescription.BodyFlag.Fit = cbfit.Checked;
					sdesc.CharacterDescription.BodyFlag.Fat = cbfat.Checked;
					sdesc.CharacterDescription.BodyFlag.PregnantFull = cbpregfull.Checked;
					sdesc.CharacterDescription.BodyFlag.PregnantHalf = cbpreghalf.Checked;
					sdesc.CharacterDescription.BodyFlag.PregnantHidden = cbpreginv.Checked;

					//Character
					sdesc.Character.Neat = (ushort)(pbneat.Value * 100);
					sdesc.Character.Outgoing = (ushort)(pboutgoing.Value * 100);
					sdesc.Character.Active = (ushort)(pbactive.Value * 100);
					sdesc.Character.Playful = (ushort)(pbplayful.Value * 100);
					sdesc.Character.Nice = (ushort)(pbnice.Value * 100);

					//Decay
					sdesc.Decay.Hunger = (short)(this.pbhunger.Value - 1000);
					sdesc.Decay.Comfort = (short)(this.pbcomfort.Value - 1000);
					sdesc.Decay.Bladder = (short)(this.pbbladder.Value - 1000);
					sdesc.Decay.Energy = (short)(this.pbenergy.Value - 1000);
					sdesc.Decay.Hygiene = (short)(this.pbhygiene.Value - 1000);
					sdesc.Decay.Social = (short)(this.pbsocial.Value - 1000);
					sdesc.Decay.Fun = (short)(this.pbfun.Value - 1000);

					//Genetic Character
					sdesc.GeneticCharacter.Neat = (ushort)(pbgenneat.Value * 100);
					sdesc.GeneticCharacter.Outgoing = (ushort)(pbgenoutgoing.Value * 100);
					sdesc.GeneticCharacter.Active = (ushort)(pbgenactive.Value * 100);
					sdesc.GeneticCharacter.Playful = (ushort)(pbgenplayful.Value * 100);
					sdesc.GeneticCharacter.Nice = (ushort)(pbgennice.Value * 100);

					//Skills
					sdesc.Skills.Body = (ushort)pbbody.Value;
					sdesc.Skills.Charisma = (ushort)pbcharisma.Value;
					sdesc.Skills.Cleaning = (ushort)pbcleaning.Value;
					sdesc.Skills.Cooking = (ushort)pbcooking.Value;
					sdesc.Skills.Creativity = (ushort)pbcreativity.Value;
					sdesc.Skills.Logic = (ushort)pblogic.Value;
					sdesc.Skills.Mechanical = (ushort)pbmechanical.Value;
					sdesc.Skills.Fatness = (ushort)pbfatness.Value;
					sdesc.Skills.Romance = (ushort)pbromance.Value;

					//Interests
					sdesc.Interests.Woman = (short)(pbwoman.Value - 1000);
					sdesc.Interests.Man = (short)(pbman.Value - 1000);
					sdesc.Interests.Animals = (ushort)(pbanimals.Value * 100);
					sdesc.Interests.Crime= (ushort)(pbcrime.Value * 100);
					sdesc.Interests.Culture= (ushort)(pbculture.Value * 100);
					sdesc.Interests.Entertainment= (ushort)(pbentertainment.Value * 100);
					sdesc.Interests.Environment= (ushort)(pbenvironment.Value * 100);
					sdesc.Interests.Fashion= (ushort)(pbfashion.Value * 100);
					sdesc.Interests.Food = (ushort)(pbfood.Value * 100);
					sdesc.Interests.Health = (ushort)(pbhealth.Value * 100);
					sdesc.Interests.Money = (ushort)(pbmonei.Value * 100);
					sdesc.Interests.Paranormal = (ushort)(pbparanormal.Value * 100);
					sdesc.Interests.Politics = (ushort)(pbpolitics.Value * 100);
					sdesc.Interests.School = (ushort)(pbschool.Value * 100);
					sdesc.Interests.Scifi = (ushort)(pbscifi.Value * 100);
					sdesc.Interests.Sports = (ushort)(pbsports.Value * 100);
					sdesc.Interests.Toys = (ushort)(pbtoys.Value * 100);
					sdesc.Interests.Travel = (ushort)(pbtravel.Value * 100);
					sdesc.Interests.Weather = (ushort)(pbweather.Value * 100);
					sdesc.Interests.Work = (ushort)(pbwork.Value * 100);

					wrapper.SynchronizeUserData();

					//change Sim Name
					if ((System.IO.File.Exists(sdesc.CharacterFileName)) && (simnamechanged)) 
					{
						try 
						{
							SimPe.Packages.GeneratableFile file = new SimPe.Packages.GeneratableFile(sdesc.CharacterFileName);
							Interfaces.Files.IPackedFileDescriptor[] pfds = file.FindFiles(Data.MetaData.CTSS_FILE);
							if (pfds.Length>0) 
							{
								SimPe.PackedFiles.Wrapper.Str str = new SimPe.PackedFiles.Wrapper.Str();
								str.ProcessData(pfds[0], file);
								foreach (SimPe.PackedFiles.Wrapper.StrLanguage lng in str.Languages)
								{
									if (lng == null) continue;
									if (str.LanguageItems(lng)[0x0] != null) str.LanguageItems(lng)[0x0].Title = this.tbsimdescname.Text;
									if (str.LanguageItems(lng)[0x2] != null) str.LanguageItems(lng)[0x2].Title = this.tbsimdescfamname.Text;
								}
								str.SynchronizeUserData();
								file.Save();
							}

							//update the Data in the Provider
							SimPe.Data.Alias a = (Data.Alias)sdesc.NameProvider.FindName(sdesc.SimId);
							if (a!=null) 
							{
								a.Name = this.tbsimdescname.Text;
								if (a.Tag.Length>=2) a.Tag[2] = this.tbsimdescfamname.Text;
							}
						} 
						catch (Exception ex) 
						{
							Helper.ExceptionMessage("Unable to change the Sim Name", ex);
						}
					}

					MessageBox.Show(Localization.Manager.GetString("commited"));
				}
				catch (Exception ex) {
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitsdesc"), ex);
				}
				finally 
				{
					this.Cursor = Cursors.Default;
				}
			}
		}

		private void FamiSimAddClick(object sender, System.EventArgs e)
		{
			if (cbsims.SelectedIndex>=0) 
			{
				if (!this.lbmembers.Items.Contains(cbsims.Items[cbsims.SelectedIndex]))
					this.lbmembers.Items.Add(cbsims.Items[cbsims.SelectedIndex]);
			}
		}

		private void SimSelectionChange(object sender, System.EventArgs e)
		{
			this.llFamiAddSim.Enabled = ((((ComboBox)sender).SelectedIndex>=0) && (((ComboBox)sender).Items.Count>0));
		}

		private void FamiMemberSelectionClick(object sender, System.EventArgs e)
		{
			this.llFamiDeleteSim.Enabled = (((ListBox)sender).SelectedIndex>=0);
			this.llFamiDeleteSim.Invalidate();
			this.llFamiDeleteSim.Update();
		}

		private void FamiDeleteSimClick(object sender, System.EventArgs e)
		{
			if (lbmembers.SelectedIndex>=0) 
			{
				lbmembers.Items.Remove(lbmembers.Items[lbmembers.SelectedIndex]);
			}
		}

		private void FileNameMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right) 
			{
				if (((Label)sender).Tag!=null)
					Clipboard.SetDataObject(((Label)sender).Tag, true);
			}
		}				

		private void CareerIndexChanged(object sender, System.EventArgs e)
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

		#region FAMi ProgressBar Handling
		private void InteresteProgressMaxClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProgressBarMaximize(this.tpinterests);

		}

		private void GeneticCharacterProgressMaxClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProgressBarMaximize(this.gbgencharacter);
		}

		private void CharacterProgressMaxClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProgressBarMaximize(this.gbcharacter);
		}

		private void SkillsProgressMaxClick(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			ProgressBarMaximize(this.gbskills);
			pbfatness.Value = 0;
			tbfatness.Text = "0";
		}

		internal void ProgressBarMaximize(Control parent) 
		{
			foreach(Control c in parent.Controls) 
			{
				if (c.GetType()== typeof(ProgressBar)) 
				{
					ProgressBar pb = ((ProgressBar)c);
					if (pb.Maximum<1000) pb.Value = pb.Maximum;
					else pb.Value = pb.Maximum-1;											 
				}				
			}
			ProgressBarUpdate(parent);
		}

		internal void ProgressBarUpdate(Control parent) 
		{
			foreach(Control c in parent.Controls) 
			{
				if (c.GetType().Name=="ProgressBar") ProgressBarUpdate((ProgressBar)c, null);
			}
		}

		internal void UpdateAllProgressTextValues() 
		{
			ProgressBarUpdate(this.gbskills);
			ProgressBarUpdate(this.gbcharacter);
			ProgressBarUpdate(this.tpinterests);
			ProgressBarUpdate(this.gblifeline);
			ProgressBarUpdate(this.gbcareer);
			ProgressBarUpdate(this.gbgencharacter);
			ProgressBarUpdate(this.gbdecay);
			ProgressBarUpdate(this.tbuni);
		}

		private void ProgressBarUpdate(ProgressBar pb, System.Windows.Forms.MouseEventArgs e) 
		{
			if (e!=null) pb.Value = Math.Max(pb.Minimum, Math.Min(pb.Maximum, Convert.ToInt32(Math.Round(((double)e.X / (double)pb.Width) * pb.Maximum))));
			foreach(Control c in pb.Parent.Controls) 
			{
				if (c.GetType().Name=="TextBox") 
				{
					TextBox tb = (TextBox)c;
					if (tb.Name == pb.Name.Replace("pb", "tb")) 
					{
						if (pb.Tag!=null) c.Text = (pb.Value - (int)pb.Tag).ToString();
						else c.Text = pb.Value.ToString();
					}
				}
			}
		}

		private void ProgressBarMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			//pb.Tag = null;
			ProgressBarUpdate(pb, e);
		}

		private void ProgressBarMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			//pb.Tag = true;
			ProgressBarUpdate(pb, e);
		}

		private void ProgressBarMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ProgressBar pb = (ProgressBar)sender;
			if (e.Button == MouseButtons.Left) 
			{
				ProgressBarUpdate(pb, e);
			}

		}

		protected void GetAssignedProgressbar(TextBox tb) 
		{
			foreach(Control c in tb.Parent.Controls) 
			{
				if (c.GetType().Name=="ProgressBar") 
				{
					ProgressBar pb = (ProgressBar)c;	
					if (tb.Name == pb.Name.Replace("pb", "tb")) 
					{
						tb.Tag = pb;
						break;
					}
				}
			}
		}

		private void ProgressBarTextChanged(object sender, System.EventArgs e)
		{
			TextBox tb = (TextBox)sender;
			ProgressBar pb = null;
			if (tb.Tag == null ) GetAssignedProgressbar(tb);			
			if (tb.Tag == null ) return;

			pb = (ProgressBar)tb.Tag;
			try 
			{
				if (pb.Tag!=null) pb.Value = Math.Max(0, Math.Min(pb.Maximum, Convert.ToInt16(tb.Text) + (int)pb.Tag));
				else pb.Value = Math.Max(0, Math.Min(pb.Maximum, Convert.ToInt16(tb.Text)));
			} 
			catch(Exception){}
		}

		private void ProgressBarTextLeave(object sender, System.EventArgs e)
		{
			if (sender.GetType() != typeof(TextBox)) return;
			TextBox tb = (TextBox)sender;
			ProgressBar pb = null;
			if (tb.Tag == null ) GetAssignedProgressbar(tb);	
			if (tb.Tag == null ) return;

			pb = (ProgressBar)tb.Tag;
			try 
			{
				if (pb.Tag!=null) tb.Text = (pb.Value - (int)pb.Tag).ToString();
				else tb.Text = pb.Value.ToString();
			} 
			catch(Exception){}
		}
		#endregion

		#region Family Ties
		private void FamilyTieSimIndexChanged(object sender, System.EventArgs e)
		{
			this.btdeletetie.Enabled = false;
			if (this.cbtiesims.SelectedIndex < 0) return;
			FamilyTieSim sim = (FamilyTieSim)cbtiesims.Items[cbtiesims.SelectedIndex];

			this.lbties.Items.Clear();
			foreach (FamilyTieItem tie in sim.Ties) 
			{
				lbties.Items.Add(tie);
			}
		}

		private void AllTieableSimsIndexChanged(object sender, System.EventArgs e)
		{
			this.btaddtie.Enabled = false;
			this.btnewtie.Enabled = false;
			if (this.cballtieablesims.SelectedIndex < 0) return;
			this.btnewtie.Enabled = true;
			if (this.cbtiesims.SelectedIndex < 0) return;			
			this.btaddtie.Enabled = true;
		}		

		private void DeleteTieClick(object sender, System.EventArgs e)
		{
			this.btaddtie.Enabled = false;
			if (this.lbties.SelectedIndex < 0) return;
			lbties.Items.Remove(lbties.Items[lbties.SelectedIndex]);
		}

		private void AddTieClick(object sender, System.EventArgs e)
		{
			if (this.cballtieablesims.SelectedIndex < 0) return;
			if (this.cbtietype.SelectedIndex < 0) return;

			try 
			{
				SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				Data.MetaData.FamilyTieTypes ftt = (Data.LocalizedFamilyTieTypes)this.cbtietype.Items[cbtietype.SelectedIndex];
				FamilyTieSim fts = (FamilyTieSim)this.cballtieablesims.Items[cballtieablesims.SelectedIndex];
				FamilyTieItem tie = new FamilyTieItem(ftt, fts.Instance, famt);
				this.lbties.Items.Add(tie);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("cantaddtie"), ex);
			}
		}

		private void CommitSimTieClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (this.cbtiesims.SelectedIndex < 0) return;

			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				
					FamilyTieSim fts = (FamilyTieSim)cbtiesims.Items[cbtiesims.SelectedIndex];
					FamilyTieItem[] ftis = new FamilyTieItem[lbties.Items.Count];
					for (int i=0; i<lbties.Items.Count; i++) 
					{
						ftis[i] = (FamilyTieItem)lbties.Items[i];
					}
					fts.Ties = ftis;					
				}
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitfamt"), ex);
				}
			}
		}		

		private void TieIndexChanged(object sender, System.EventArgs e)
		{
			this.btdeletetie.Enabled = false;
			if (this.lbties.SelectedIndex < 0) return;
			this.btdeletetie.Enabled = true;
		}

		private void CommitTieClick(object sender, System.EventArgs e)
		{
			CommitSimTieClicked(null, null);
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.FamilyTies famt = (Wrapper.FamilyTies)wrapper;
				
					FamilyTieSim[] sims = new FamilyTieSim[cbtiesims.Items.Count];
					for (int i=0; i<sims.Length; i++) 
					{
						sims[i] = (FamilyTieSim)cbtiesims.Items[i];
					}
					famt.Sims = sims;

					famt.SynchronizeUserData();				
				}
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommittie"), ex);
				}
			}
		}		

		private void AddSimToTiesClick(object sender, System.EventArgs e)
		{
			if (this.cballtieablesims.SelectedIndex < 0) return;
			FamilyTieSim sim = (FamilyTieSim)this.cballtieablesims.Items[cballtieablesims.SelectedIndex];
			sim.Ties = new FamilyTieItem[0];			

			//check if the tie exists
			bool exists = false;
			foreach (FamilyTieSim exsim in cbtiesims.Items) 
			{
				if (exsim.Instance==sim.Instance) 
				{
					exists = true;
					break;
				}
			}//foreach

			if (!exists) 
			{
				cbtiesims.Items.Add(sim);
			}
		}
		#endregion

		#region Relationships
		private void RelationListSelectedIndexChanged(object sender, System.EventArgs e)
		{
			ListBox lb = (ListBox)sender;
			gbout.Enabled = false;
			gbin.Enabled = false;
			btdeleterelation.Enabled = false;
			this.llsimrelcommit.Enabled = false;
			
			if (lb.SelectedIndex<0) return;
			this.llsimrelcommit.Enabled = true;
			gbout.Enabled = true;
			gbin.Enabled = true;
			gbout.Refresh();
			gbin.Refresh();
			btdeleterelation.Enabled = true;

			SimRelations rels = (SimRelations)lb.Items[lb.SelectedIndex];

			tboutrelshort.Text = rels.OutboundRelation.Shortterm.ToString();
			tboutrellong.Text = rels.OutboundRelation.Longterm.ToString();

			tbinrelshort.Text = rels.InboundRelation.Shortterm.ToString();
			tbinrellong.Text = rels.InboundRelation.Longterm.ToString();

			this.cboutenemy.Checked = rels.OutboundRelation.RelationState.IsEnemy;
			this.cboutfriend.Checked = rels.OutboundRelation.RelationState.IsFriend;
			this.cboutbuddie.Checked = rels.OutboundRelation.RelationState.IsBuddie;
			this.cboutbest.Checked = rels.OutboundRelation.RelationState.IsKnown;
			this.cboutcrush.Checked = rels.OutboundRelation.RelationState.HasCrush;
			this.cboutlove.Checked = rels.OutboundRelation.RelationState.InLove;
			this.cboutsteady.Checked = rels.OutboundRelation.RelationState.GoSteady;
			this.cboutengaged.Checked = rels.OutboundRelation.RelationState.IsEngaged;
			this.cboutmarried.Checked = rels.OutboundRelation.RelationState.IsMarried;
			this.cboutfamily.Checked = rels.OutboundRelation.RelationState.IsFamilyMember;
			this.cboutfamtype.SelectedIndex = 0;
			for (int i=1; i<this.cboutfamtype.Items.Count; i++) 
				if (cboutfamtype.Items[i] == new Data.LocalizedRelationshipTypes(rels.OutboundRelation.FamilyRelation)) 
				{
					this.cboutfamtype.SelectedIndex = i;
					break;
				}

			this.cbinenemy.Checked = rels.InboundRelation.RelationState.IsEnemy;
			this.cbinfriend.Checked = rels.InboundRelation.RelationState.IsFriend;
			this.cbinbuddie.Checked = rels.InboundRelation.RelationState.IsBuddie;
			this.cbinbest.Checked = rels.InboundRelation.RelationState.IsKnown;
			this.cbincrush.Checked = rels.InboundRelation.RelationState.HasCrush;
			this.cbinlove.Checked = rels.InboundRelation.RelationState.InLove;
			this.cbinsteady.Checked = rels.InboundRelation.RelationState.GoSteady;
			this.cbinengaged.Checked = rels.InboundRelation.RelationState.IsEngaged;
			this.cbinmarried.Checked = rels.InboundRelation.RelationState.IsMarried;
			this.cbinfamily.Checked = rels.InboundRelation.RelationState.IsFamilyMember;
			this.cbinfamtype.SelectedIndex = 0;
			for (int i=1; i<this.cbinfamtype.Items.Count; i++) 
				if (cbinfamtype.Items[i] == new Data.LocalizedRelationshipTypes(rels.InboundRelation.FamilyRelation)) 
				{
					this.cbinfamtype.SelectedIndex = i;
					break;
				}
		}

		private void RelationshipFileCommit(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
		
			if (wrapper!=null) 
			{
				try 
				{
					SimPe.PackedFiles.Wrapper.SRel srel = (Wrapper.SRel)wrapper;
					srel.Shortterm = Convert.ToInt32(tbshortterm.Text);
					srel.Longterm = Convert.ToInt32(tblongterm.Text);

					SimPe.PackedFiles.Wrapper.RelationshipFlags outf = new SimPe.PackedFiles.Wrapper.RelationshipFlags(0);
					outf.IsEnemy = this.cbenemy.Checked;
					outf.IsFriend = this.cbfriend.Checked;
					outf.IsBuddie = this.cbbuddie.Checked;
					outf.IsKnown = this.cbbest.Checked;
					outf.HasCrush = this.cbcrush.Checked;
					outf.InLove = this.cblove.Checked;
					outf.GoSteady = this.cbsteady.Checked;
					outf.IsEngaged = this.cbengaged.Checked;
					outf.IsMarried = this.cbmarried.Checked;
					outf.IsFamilyMember = this.cbfamily.Checked;
					srel.RelationState = outf;
					if (cbfamtype.SelectedIndex>0)
						srel.FamilyRelation = (Data.LocalizedRelationshipTypes)cbfamtype.Items[cbfamtype.SelectedIndex];


					wrapper.SynchronizeUserData();
					MessageBox.Show("Changes were comitted!");
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage("Unable to Save Relationship Information!", ex);
				}
			}
		}

		private void SimRelationCommit(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					if (this.lbrelations.SelectedIndex<0) return;//throw new Exception("No Relationship selected!");
					SimRelations rels = (SimRelations)this.lbrelations.Items[this.lbrelations.SelectedIndex];

					rels.OutboundRelation.Shortterm = Convert.ToInt32(tboutrelshort.Text);
					rels.OutboundRelation.Longterm = Convert.ToInt32(tboutrellong.Text);
					
					rels.InboundRelation.Shortterm = Convert.ToInt32(tbinrelshort.Text);
					rels.InboundRelation.Longterm = Convert.ToInt32(tbinrellong.Text);
					
					SimPe.PackedFiles.Wrapper.RelationshipFlags outf = new SimPe.PackedFiles.Wrapper.RelationshipFlags(0);
					outf.IsEnemy = this.cboutenemy.Checked;
					outf.IsFriend = this.cboutfriend.Checked;
					outf.IsBuddie = this.cboutbuddie.Checked;
					outf.IsKnown = this.cboutbest.Checked;
					outf.HasCrush = this.cboutcrush.Checked;
					outf.InLove = this.cboutlove.Checked;
					outf.GoSteady = this.cboutsteady.Checked;
					outf.IsEngaged = this.cboutengaged.Checked;
					outf.IsMarried = this.cboutmarried.Checked;
					outf.IsFamilyMember = this.cboutfamily.Checked;
					rels.OutboundRelation.RelationState = outf;
					if (rels.OutboundRelation.FamilyRelation != Data.MetaData.RelationshipTypes.Unset_Unknown || (cboutfamtype.SelectedIndex>0))
						rels.OutboundRelation.FamilyRelation = (Data.LocalizedRelationshipTypes)cboutfamtype.Items[cboutfamtype.SelectedIndex];

					SimPe.PackedFiles.Wrapper.RelationshipFlags inf = new SimPe.PackedFiles.Wrapper.RelationshipFlags(0);
					inf.IsEnemy = this.cbinenemy.Checked;
					inf.IsFriend = this.cbinfriend.Checked;
					inf.IsBuddie = this.cbinbuddie.Checked;
					inf.IsKnown = this.cbinbest.Checked;
					inf.HasCrush = this.cbincrush.Checked;
					inf.InLove = this.cbinlove.Checked;
					inf.GoSteady = this.cbinsteady.Checked;
					inf.IsEngaged = this.cbinengaged.Checked;
					inf.IsMarried = this.cbinmarried.Checked;
					inf.IsFamilyMember = this.cbinfamily.Checked;
					rels.InboundRelation.RelationState = inf;
					if (rels.InboundRelation.FamilyRelation != Data.MetaData.RelationshipTypes.Unset_Unknown || (cbinfamtype.SelectedIndex>0))
						rels.InboundRelation.FamilyRelation = (Data.LocalizedRelationshipTypes)cbinfamtype.Items[cbinfamtype.SelectedIndex];
					

					rels.SynchronizeUserData();
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitrelation"), ex);
				}
			}
		}

		private void RelatableSimsIndexChanged(object sender, System.EventArgs e)
		{
			btaddrelation.Enabled = false;
			if (this.cballrelsims.SelectedIndex<0) return;
			btaddrelation.Enabled = true;
		}	

		private void AddRelationClicked(object sender, System.EventArgs e)
		{
			if (this.cballrelsims.SelectedIndex<0) return;

			try 
			{
				//get the Target and SOurces Sim Data
				SimPe.PackedFiles.Wrapper.SDesc sdesc = (Wrapper.SDesc)wrapper;
				Wrapper.SRel[] srel = new Wrapper.SRel[2];
				SimPe.Interfaces.IAlias targetsim = (SimPe.Interfaces.IAlias)cballrelsims.Items[cballrelsims.SelectedIndex];
				ushort targetinstance = sdesc.DescriptionProvider.GetInstance(targetsim.Id);

				//Creat new Relationships
				srel[1] = new Wrapper.SRel();				
				srel[1].FileDescriptor = sdesc.Package.FindFile(Data.MetaData.RELATION_FILE, 0, sdesc.FileDescriptor.Group, (uint)(sdesc.FileDescriptor.Instance + (targetinstance << 16)));				
				srel[1].Package = sdesc.Package;
				srel[0] = new Wrapper.SRel();
				srel[0].FileDescriptor = sdesc.Package.FindFile(Data.MetaData.RELATION_FILE, 0, sdesc.FileDescriptor.Group, (uint)((sdesc.FileDescriptor.Instance << 16)+ targetinstance));				
				srel[0].Package = sdesc.Package;

				Wrapper.SDesc tdesc = (Wrapper.SDesc)sdesc.DescriptionProvider.FindSim((ushort)targetinstance);
				if (tdesc!=null) 
				{
					ushort[] instances1 = new ushort[tdesc.Relations.SimInstances.Length+1];

					tdesc.Relations.SimInstances.CopyTo(instances1, 0);
					instances1[instances1.Length-1] = sdesc.Instance;
					tdesc.Relations.SimInstances = instances1;
					tdesc.SynchronizeUserData();
				}
				//create a new Relationship
				if (srel[0].FileDescriptor==null) 
				{					
					srel[0].FileDescriptor = sdesc.Package.Add(Data.MetaData.RELATION_FILE, 0, sdesc.FileDescriptor.Group, (uint)((sdesc.FileDescriptor.Instance << 16)+ targetinstance));					
				}

				//create a new Relationship
				if (srel[1].FileDescriptor==null) 
				{
					srel[1].FileDescriptor = sdesc.Package.Add(Data.MetaData.RELATION_FILE, 0, sdesc.FileDescriptor.Group, (uint)(sdesc.FileDescriptor.Instance + (targetinstance << 16)));
				}
				ushort[] instances2 = new ushort[sdesc.Relations.SimInstances.Length+1];
				sdesc.Relations.SimInstances.CopyTo(instances2, 0);
				instances2[instances2.Length-1] = targetinstance;
				sdesc.Relations.SimInstances = instances2;					
				sdesc.SynchronizeUserData();
				

				
				SimRelations rel = new SimRelations(srel);
				rel.NameTag = cballrelsims.Items[cballrelsims.SelectedIndex].ToString();
				this.lbrelations.Items.Add(rel);

				
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("cantaddrelation"), ex);
			}
		}

		private void DeleteRelationClicked(object sender, System.EventArgs e)
		{
			if (this.lbrelations.SelectedIndex<0) return;
			try 
			{
				//get the Target and SOurces Sim Data
				SimPe.PackedFiles.Wrapper.SDesc sdesc = (Wrapper.SDesc)wrapper;
				
				SimRelations rel = (SimRelations)lbrelations.Items[lbrelations.SelectedIndex];
				rel.OutboundRelation.FileDescriptor.MarkForDelete = true;
				rel.InboundRelation.FileDescriptor.MarkForDelete = true;
				ushort tinstance = (ushort)(rel.OutboundRelation.FileDescriptor.Instance & 0x0000ffff);
				ArrayList list = new ArrayList();
				ushort[] instances;

				//remove relation from the Target sim
				Wrapper.SDesc tdesc = (Wrapper.SDesc)sdesc.DescriptionProvider.FindSim(tinstance);
				if (tdesc!=null) 
				{					
					foreach (ushort u in tdesc.Relations.SimInstances) if (u != sdesc.Instance) list.Add(u);					
					instances = new ushort[list.Count];
					list.CopyTo(instances);
					tdesc.Relations.SimInstances = instances;
					tdesc.SynchronizeUserData();
				}

				//romove from the current sim
				list = new ArrayList();
				foreach (ushort u in sdesc.Relations.SimInstances) if (u != tinstance) list.Add(u);					

				instances = new ushort[list.Count];
				list.CopyTo(instances);
				sdesc.Relations.SimInstances = instances;
				sdesc.SynchronizeUserData();

				//remove from list
				lbrelations.Items.Remove(lbrelations.Items[lbrelations.SelectedIndex]);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage(Localization.Manager.GetString("cantdeleterelation"), ex);
			}
			this.btdeleterelation.Enabled = false;
		}
		#endregion		

		private void CommitObjdClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			if (wrapper!=null) 
			{
				try 
				{
					this.Cursor = Cursors.WaitCursor;
					SimPe.PackedFiles.Wrapper.Objd objd = (Wrapper.Objd)wrapper;					

					foreach (Control c in pnelements.Controls) 
					{
						if (c.GetType() == typeof(TextBox)) 
						{
							TextBox tb = (TextBox)c;
							if (tb.Tag!=null) 
							{
								string name = (string)tb.Tag;
								Wrapper.ObjdItem item = (Wrapper.ObjdItem)objd.Attributes[name];
								item.val = Convert.ToUInt16(tb.Text, 16);
								objd.Attributes[name] = item;
							}
						}
					}

					objd.Type = (ushort)Helper.HexStringToUInt(tblottype.Text);
					objd.Guid = (uint)Helper.HexStringToUInt(tbsimid.Text);
					objd.FileName = tbsimname.Text;
					objd.OriginalGuid = (uint)Helper.HexStringToUInt(this.tborgguid.Text);
					objd.ProxyGuid = (uint)Helper.HexStringToUInt(this.tbproxguid.Text);

					objd.SynchronizeUserData();
					MessageBox.Show(Localization.Manager.GetString("commited"));
				} 
				catch (Exception ex) 
				{
					Helper.ExceptionMessage(Localization.Manager.GetString("cantcommitobjd"), ex);
				}
			}
		}

		private void GetGUIDClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			Sims.GUID.GUIDGetterForm form = new Sims.GUID.GUIDGetterForm();
			Registry reg = new Registry();

			try 
			{
				uint oldguid = Convert.ToUInt32(tbsimid.Text, 16);
				uint guid = form.GetNewGUID(reg.Username, reg.Password, oldguid);

				reg.Username = form.tbusername.Text;
				reg.Password = form.tbpassword.Text;
				this.tbsimid.Text = "0x"+Helper.HexString(guid);

				if (cbupdate.Checked) 
				{
					SimPe.Plugin.FixGuid fg = new SimPe.Plugin.FixGuid(((SimPe.PackedFiles.Wrapper.Objd)wrapper).Package);
					ArrayList al = new ArrayList();
					SimPe.Plugin.GuidSet gs = new SimPe.Plugin.GuidSet();
					gs.oldguid = oldguid;
					gs.guid = guid;
					al.Add(gs);

					fg.FixGuids(al);

					((SimPe.PackedFiles.Wrapper.Objd)wrapper).Guid = guid;
					wrapper.SynchronizeUserData();
				}
			} 
			catch (Exception) {}
		}

		internal bool simnamechanged;
		private void SimNameChanged(object sender, System.EventArgs e)
		{
			simnamechanged = true;
		}

		private void FlagChanged(object sender, System.EventArgs e)
		{
			if (tbflag.Tag!=null) return;
			tbflag.Tag = true;
			try 
			{
				uint flag = Convert.ToUInt32(tbflag.Text, 16);
				SimPe.PackedFiles.Wrapper.FamiFlags flags = new SimPe.PackedFiles.Wrapper.FamiFlags((ushort)flag);

				this.cbphone.Checked = flags.HasPhone;
				this.cbcomputer.Checked = flags.HasComputer;
				this.cbbaby.Checked = flags.HasBaby;
				this.cblot.Checked = flags.NewLot;

				
			} 
			catch (Exception) {}
			finally 
			{
				tbflag.Tag = null;
			}
		}

		private void ChangeFlags(object sender, System.EventArgs e)
		{
			if (tbflag.Tag!=null) return;
			tbflag.Tag = true;
			try {
				uint flag = Convert.ToUInt32(tbflag.Text, 16) & 0xffff0000;
				
				SimPe.PackedFiles.Wrapper.FamiFlags flags = new SimPe.PackedFiles.Wrapper.FamiFlags(0);

				flags.HasPhone = this.cbphone.Checked;
				flags.HasComputer = this.cbcomputer.Checked;
				flags.HasBaby = this.cbbaby.Checked;
				flags.NewLot = this.cblot.Checked;

				flag = flag | flags.Value;
				tbflag.Text = "0x"+Helper.HexString(flag);
			} 
			catch (Exception) {}
			finally 
			{
				tbflag.Tag = null;
			}
		}

		private void cboutfamtype_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void SelectMajor(object sender, System.EventArgs e)
		{
			if (cbmajor.SelectedIndex<0) return;
			object o = cbmajor.Items[cbmajor.SelectedIndex];
			Data.Majors v;
			if (o.GetType()==typeof(Data.Alias)) v = (Data.Majors)((Data.Alias)o).Id; 
			else v = (Data.Majors)o;
			
			if ( v == Data.Majors.Unknown) return;

			tbmajor.Text = "0x"+Helper.HexString((uint)v);
		}

		private void tbuni_Click(object sender, System.EventArgs e)
		{
		
		}

		private void OpenWantsFears(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				if (MessageBox.Show(SimPe.Localization.Manager.GetString("open_wnt_from_sdsc"), SimPe.Localization.Manager.GetString("question"), MessageBoxButtons.YesNo)==DialogResult.Yes)
					this.CommitSDescClick(null, null);

				//Open File
				SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
				Interfaces.Files.IPackedFileDescriptor pfd = wrp.Package.NewDescriptor(0xCD95548E, wrp.FileDescriptor.SubType, wrp.FileDescriptor.Group, wrp.FileDescriptor.Instance); //try a W&f File
				pfd = wrp.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd);
			}
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void OpenFamily(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				uint inst = Convert.ToUInt32(this.tbfaminst.Text, 16);
				if (MessageBox.Show(SimPe.Localization.Manager.GetString("open_fami_from_sdsc"), SimPe.Localization.Manager.GetString("question"), MessageBoxButtons.YesNo)==DialogResult.Yes)
					this.CommitSDescClick(null, null);

				SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
				Interfaces.Files.IPackedFileDescriptor pfd = wrp.Package.NewDescriptor(0x46414D49, wrp.FileDescriptor.SubType, wrp.FileDescriptor.Group, inst); //try a Fami File
				pfd = wrp.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void lldna_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				if (MessageBox.Show(SimPe.Localization.Manager.GetString("open_dna_from_sdsc"), SimPe.Localization.Manager.GetString("question"), MessageBoxButtons.YesNo)==DialogResult.Yes)
					this.CommitSDescClick(null, null);

				SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
				Interfaces.Files.IPackedFileDescriptor pfd = wrp.Package.NewDescriptor(0xEBFEE33F, wrp.FileDescriptor.SubType, wrp.FileDescriptor.Group, wrp.FileDescriptor.Instance); //try a DNA File
				pfd = wrp.Package.FindFile(pfd);
				SimPe.RemoteControl.OpenPackedFile(pfd);
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void llcloth_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			try 
			{
				SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
				if (System.IO.File.Exists(wrp.CharacterFileName)) 
				{
					uint inst = Convert.ToUInt32(this.tbfaminst.Text, 16);
					if (MessageBox.Show(SimPe.Localization.Manager.GetString("open_cloth_from_sdsc"), SimPe.Localization.Manager.GetString("question"), MessageBoxButtons.YesNo)==DialogResult.Yes)
					{
						this.CommitSDescClick(null, null);
						((SimPe.Packages.GeneratableFile)wrp.Package).Save();
					}

				
					SimPe.Packages.GeneratableFile fl = new SimPe.Packages.GeneratableFile(wrp.CharacterFileName);

					Interfaces.Files.IPackedFileDescriptor[] pfds = fl.FindFile(0xAC506764, 0, 0x1);
					if (pfds.Length>0) 
					{
						SimPe.RemoteControl.OpenPackage(wrp.CharacterFileName);						
						SimPe.RemoteControl.OpenPackedFile(pfds[0]);
					}
				}
			} 
			catch (Exception ex) 
			{
				Helper.ExceptionMessage("", ex);
			}
		}

		private void Relink(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{

			SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
			this.tbsim.Text = "0x"+Helper.HexString(SimRelinkForm.Execute(wrp));
		}

		private void SdscShowMore(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			SimPe.PackedFiles.Wrapper.SDesc wrp = (SimPe.PackedFiles.Wrapper.SDesc)wrapper;
			if (SdscExtendedForm.Execute(wrp)) wrp.UIHandler.UpdateGUI(wrp);			
		}

		

		

	}
}
